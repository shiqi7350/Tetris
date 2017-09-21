using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SLua;
using System.IO;

public sealed class GameMain : MonoBehaviour
{
    private static GameMain instance;
    public static GameMain Instance { get { return instance; } }

    Button button_rotate;
    Button button_left;
    Button button_right;
    Button button_down;
    float drop_speed = 120f;
    float drop_speed_const = 120f;

    //1,2,3,4,5,6,7
    int t_type = 1;

    GameObject resBlock;

    Block b;

    Frame f;

    Text score;
    long get_line_num = 0;



    // 主luaState
    private LuaSvr lua;
    public static LuaSvr Lua { get { return instance.lua; } }

    void Start()
    {
        score = transform.Find("ScoreBg/Score").GetComponent<Text>();
        score.text = get_line_num.ToString();

        f = new Frame();
        button_rotate = transform.Find("Btn_Rotate").GetComponent<Button>();
        button_rotate.onClick.AddListener(delegate ()
        {
            this.OnClick_Rotate(button_rotate.gameObject);
        });
        button_left = transform.Find("Btn_Left").GetComponent<Button>();
        button_left.onClick.AddListener(delegate ()
        {
            this.OnClick_Left(button_left.gameObject);
        });
        button_right = transform.Find("Btn_Right").GetComponent<Button>();
        button_right.onClick.AddListener(delegate ()
        {
            this.OnClick_Right(button_right.gameObject);
        });
        button_down = transform.Find("Btn_Down").GetComponent<Button>();
        button_down.onClick.AddListener(delegate ()
        {
            this.OnClick_Down(button_down.gameObject);
        });

        resBlock = transform.Find("Panel/block").gameObject;

        CreateRandomBlock();

        //加入Lua虚拟机
        lua = new LuaSvr();

        //设置Lua 脚本启动代理
        LuaState.loaderDelegate = ((string fn) =>
        {
            //获取Lua文件执行目录
            string file_path = Directory.GetCurrentDirectory() + "/Assets/Lua/" + fn;
            Debug.Log(file_path);
            return File.ReadAllBytes(file_path);
        }
        );
        //Lua虚拟机 初始化  ，LuaVMReady为初始化完成之后 执行的方法
        lua.init(null, LuaVMReady);

        // luaState.doFile("HelloLua.lua");

    }

    void LuaVMReady()
    {
        lua.start("HelloLua.lua");
        /*
        if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.WindowsEditor)
        {
            // 注意: 当在editor下运行时，直接使用 ROOT/lua 目录下的原始文件，不会使用更新下来的文件
            lua.luaState.doString("package.path = '" + Application.dataPath + "/Lua/?.lua'");
            // StartGameLogic();

            lua.luaState.doString("require 'HelloLua'");
        }
        else
        {
            // string cachePath = Application.temporaryCachePath;
            // lua.luaState.doString("package.path = '" + cachePath + "/lua/?.lua'");
            // if (!Directory.Exists(cachePath + "/lua"))
            // {
            //     MyLogger.Info("首次运行，正在准备基础文件...");
            //     WWWLoader.LoadFromStreaming("scripts.pack", UnpackScripts, UnpackScriptsError);
            // }
            // else
            // {
            //     StartGameLogic();
            // }
        }
        */
    }

    float c_time = 0f;
    float tap_time = 0.05f;
    float drop_time = 0f;
    bool is_dropping = true;
    void Update()
    {
        if (game_over) return;
        if (is_dropping)
        {
            // c_time += Time.deltaTime;
            // if (c_time >= tap_time)
            // {
            //     c_time = 0f;
            Block_Drop(b, drop_speed * Time.deltaTime);

            if (IsDropEnd())
            {
                foreach (Node n in b.nodeList)
                {
                    int[] idx = f.GetFrameIndex(n.GetPos().x, n.GetPos().y + Node.leng * 0.5f);
                    if (idx[1] >= f.high_size - 1)
                    {
                        ShowGameOver();
                        return;
                    }
                    if (f.IsFullFrame(idx[0], idx[1]))
                    {
                        Debug.LogError("不为空的或不存在的 Frame 被赋值！");
                        return;
                    }
                    f.all_node[idx[0], idx[1]] = n;
                }

                int num = f.DeleteLine();
                if (num > 0)
                {
                    get_line_num += num;
                    UpdateScore();
                    is_dropping = false;
                }
                else
                {
                    CreateRandomBlock();
                }
            }
            // }
        }
        else
        {
            drop_time += Time.deltaTime;
            if (drop_time >= tap_time)
            {
                drop_time = 0f;
                f.DeleteLine_Drop();
                CreateRandomBlock();
            }
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            OnClick_Left(null);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            OnClick_Down(null);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            OnClick_Right(null);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            OnClick_Rotate(null);
        }
    }
    void UpdateScore()
    {
        if (get_line_num % 50 == 0)
        {
            drop_speed += 20f;
            drop_speed_const += 20f;
        }
        score.text = get_line_num.ToString();
    }

    bool is_normal_drop = true;
    bool IsDropEnd()
    {
        if (is_normal_drop)
        {
            // string sss = "";
            for (int i = 0; i < b.down_list.Count; i++)
            {
                Vector3 pos = b.down_list[i].GetPos();
                float x = pos.x;
                float y = pos.y;
                if (y - Node.leng * 0.5f <= f.down_max_pos)
                {
                    AdjustBlock(1, f.down_max_pos + Node.leng * 0.5f - y);
                    return true;
                }

                int hi = GetCurHighFullFrame(x, y + Node.leng * 0.5f);
                // sss += ",hi=" + hi + ", y = " + y + "\n";
                if (hi <= -1) continue;

                if (y - Node.leng * 0.5f <= f.down_max_pos + (hi + 1) * Node.leng)
                {
                    AdjustBlock(1, f.down_max_pos + Node.leng * 0.5f + (hi + 1) * Node.leng - y);
                    return true;
                }
            }
            // print(sss);
        }
        else
        {
            Vector3 pos = b.down_list[up_indx].GetPos();
            // float x = pos.x;
            float y = pos.y;

            if (y - Node.leng * 0.5f <= f.down_max_pos + (down_indx + 1) * Node.leng)
            {
                AdjustBlock(1, f.down_max_pos + Node.leng * 0.5f + (down_indx + 1) * Node.leng - y);
                return true;
            }
        }
        return false;
    }

    int GetCurHighFullFrame(float x, float y)
    {
        int[] poIndx = f.GetFrameIndex(x, y);
        int xIndx = poIndx[0];
        int yIndx = poIndx[1];
        if (yIndx >= f.high_size) yIndx = f.high_size - 1;

        for (int h = yIndx - 1; h >= 0; h--)
        {
            if (f.IsFullFrame(xIndx, h))
            {
                return h;
            }
        }
        return -1;
    }


    void AdjustBlock(int type, float offset)
    {
        if (1 == type) //往下 过头
        {
            Vector3 v = b.GetPos();
            b.SetShape(new Vector3(v.x, v.y + offset, 0f));
        }
    }

    Block CreateBlock(char shape_ch, int type)
    {
        Node[] nl = new Node[4];
        for (int i = 0; i < 4; i++)
        {
            GameObject o = Instantiate(resBlock);
            o.transform.SetParent(transform.Find("Panel"));
            o.transform.localScale = Vector3.one;
            nl[i] = new Node(o.transform);
        }
        Block tmp_b = new Block();

        switch (shape_ch)
        {
            case 'I':
                tmp_b = new I_Block(nl, type);
                t_type = 1;
                break;
            case 'L':
                tmp_b = new L_Block(nl, type);
                t_type = 2;
                break;
            case 'J':
                tmp_b = new J_Block(nl, type);
                t_type = 3;
                break;
            case 'T':
                tmp_b = new T_Block(nl, type);
                t_type = 4;
                break;
            case 'Z':
                tmp_b = new Z_Block(nl, type);
                t_type = 5;
                break;
            case 'S':
                tmp_b = new S_Block(nl, type);
                t_type = 6;
                break;
            case 'O':
                tmp_b = new O_Block(nl, type);
                t_type = 7;
                break;
        }
        return tmp_b;
    }
    /// <summary>
    /// 创建随机的 块
    /// </summary>
    void CreateRandomBlock()
    {
        char[] sc = new char[7] { 'I', 'L', 'J', 'T', 'Z', 'S', 'O' };
        int rNum = Random.Range(0, sc.Length);
        int rType = 0;
        switch (sc[rNum])
        {
            case 'I':
                rType = Random.Range(1, 3);
                break;
            case 'L':
            case 'J':
            case 'T':
                rType = Random.Range(1, 5);
                break;
            case 'S':
            case 'Z':
                rType = Random.Range(1, 3);
                break;
            case 'O':
                rType = 1;
                break;
        }

        b = CreateBlock(sc[rNum], rType);
        // b = CreateBlock('I', 1);
        b.SetColor(Random.Range(1, 8));
        b.SetShape(new Vector3(0f, 600f, 0f));
        drop_speed = drop_speed_const;
        is_normal_drop = true;
        is_dropping = true;
    }

    void Block_Drop(Block curB, float speed)
    {
        for (int i = 0; i < 4; i++)
        {
            curB.nodeList[i].Drop(speed);
        }
    }

    void OnClick_Rotate(GameObject o)
    {
        if (!is_normal_drop) return;
        //旋转 （全都是 顺时针旋转）
        Vector3 central_point = b.GetPos();
        b.flag++;
        if (b.flag > b.maxFlag)
        {
            b.flag = 1;
        }
        int offset_x = Adjust_SetShape(central_point);
        if (offset_x == 1000)
        {
            b.flag--;
            if (b.flag < 1) b.flag = b.maxFlag;
        }
        else
        {
            b.SetShape(new Vector3(central_point.x + offset_x * Node.leng, central_point.y, 0f));
        }
    }

    /// <summary>
    /// 调整 变换后水平位置
    /// </summary>
    /// <returns></returns>
    int Adjust_SetShape(Vector3 central_point)
    {
        // print(central_point.x + ", " + central_point.y);
        if (IsValidNode(central_point))
        {
            // Debug.LogWarning("合法旋转");
            return 0;
        }
        else//右移一次
        {
            if (IsValidNode(new Vector3(central_point.x + Node.leng, central_point.y, 0f)))
            {
                // Debug.LogWarning("右移一次");
                return 1;
            }
            else//再右移一次
            {
                if (IsValidNode(new Vector3(central_point.x + 2 * Node.leng, central_point.y, 0f)))
                {
                    // Debug.LogWarning("右移两次");
                    return 2;
                }
                else//左移一次
                {
                    if (IsValidNode(new Vector3(central_point.x - Node.leng, central_point.y, 0f)))
                    {
                        // Debug.LogWarning("左移一次");
                        return -1;
                    }
                    else//再左移一次
                    {
                        if (IsValidNode(new Vector3(central_point.x - 2 * Node.leng, central_point.y, 0f)))
                        {
                            // Debug.LogWarning("左移两次");
                            return -2;
                        }
                        else
                        {
                            // Debug.LogWarning("不可旋转");
                            return 1000;
                        }
                    }
                }
            }
        }
    }

    /// <summary>
    /// 判断指定坐标处生成的块中每一个Node位置是否合法
    /// </summary>
    /// <param name="central_point"></param>
    /// <returns></returns>
    bool IsValidNode(Vector3 central_point)
    {
        List<Vector3> v_vect = b.V_SetShape(central_point);
        for (int i = 0; i < v_vect.Count; i++)
        {
            int[] idx = f.GetFrameIndex(v_vect[i].x, v_vect[i].y);
            // Debug.LogWarning(idx[0] + ", " + idx[1]);
            if (idx[1] >= f.high_size && idx[0] >= 0 && idx[0] < f.wide_size)
            {
                continue;
            }
            if (f.IsFullFrame(idx[0], idx[1]))
            {
                return false;
            }
        }
        return true;
    }


    void OnClick_Left(GameObject o)
    {
        if (!is_normal_drop) return;
        List<Node> left_node_list = b.GetLeftNode();
        for (int i = 0; i < left_node_list.Count; i++)
        {
            Vector3 pos = left_node_list[i].GetPos();
            float x = pos.x;
            float y = pos.y;
            if (x - Node.leng * 0.5f <= f.left_max_pos) //超出 左 边界
            {
                return;
            }
            int[] idx = f.GetFrameIndex(x - Node.leng, y);
            if (idx[1] >= f.high_size) continue;

            if (idx[0] < 0 || f.IsFullFrame(idx[0], idx[1])) //左边 有块
            {
                return;
            }
        }
        Vector3 v = b.GetPos();
        b.SetShape(new Vector3(v.x - Node.leng, v.y, 0f));
    }
    void OnClick_Right(GameObject o)
    {
        if (!is_normal_drop) return;
        List<Node> right_node_list = b.GetRightNode();
        for (int i = 0; i < right_node_list.Count; i++)
        {
            Vector3 pos = right_node_list[i].GetPos();
            float x = pos.x;
            float y = pos.y;
            if (x - Node.leng * 0.5f >= f.right_max_pos) //超出 右 边界
            {
                return;
            }
            int[] idx = f.GetFrameIndex(x + Node.leng, y);
            if (idx[1] >= f.high_size) continue;
            if (idx[0] >= f.wide_size || f.IsFullFrame(idx[0], idx[1])) //右边 有块
            {
                return;
            }
        }
        Vector3 v = b.GetPos();
        b.SetShape(new Vector3(v.x + Node.leng, v.y, 0f));
    }

    int up_indx = 0;
    int down_indx = -1;
    void OnClick_Down(GameObject o)
    {
        if (!is_normal_drop) return;
        float h_length = 20000f;
        // cur_y_index.Clear();
        for (int i = 0; i < b.down_list.Count; i++)
        {
            Vector3 pos = b.down_list[i].GetPos();
            float x = pos.x;
            float y = pos.y;
            int low_h = GetCurHighFullFrame(x, y);
            float x_offset = y - (f.down_max_pos + (low_h + 1) * Node.leng);
            if (h_length > x_offset)
            {
                h_length = x_offset;
                up_indx = i;
                down_indx = low_h;
            }
        }
        is_normal_drop = false;
        drop_speed = 4000f;
    }

    bool game_over = false;
    void ShowGameOver()
    {
        game_over = true;
        Debug.LogError("Game Over!");
    }
}
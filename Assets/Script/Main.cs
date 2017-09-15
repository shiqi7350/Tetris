using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    Button button_rotate;
    Button button_left;
    Button button_right;
    Button button_down;
    float drop_speed = 200f;
    float drop_speed_const = 200f;

    //1,2,3,4,5,6,7
    int t_type = 1;

    GameObject resBlock;

    Block b;

    Frame f;
    void Start()
    {
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
                    int[] idx = f.GetFrameIndex(n.GetPos().x, n.GetPos().y);
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

                if (f.DeleteLine())
                {
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


    bool is_normal_drop = true;
    bool IsDropEnd()
    {
        if (is_normal_drop)
        {
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

                int hi = GetCurHighFullFrame(x, y);
                if (hi <= -1) continue;

                if (y - Node.leng * 0.5f <= f.down_max_pos + (hi + 1) * Node.leng)
                {
                    AdjustBlock(1, f.down_max_pos + Node.leng * 0.5f + (hi + 1) * Node.leng - y);
                    return true;
                }
            }
        }
        else
        {
            Vector3 pos = b.down_list[up_indx].GetPos();
            float x = pos.x;
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
        // b = CreateBlock('J', 4);
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
        b.SetShape(central_point);
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
        drop_speed *= 20f;
    }

    bool game_over = false;
    void ShowGameOver()
    {
        game_over = true;
        Debug.LogError("Game Over!");
    }
}
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
        button_rotate.onClick.AddListener(delegate()
        {
            this.OnClick_Rotate(button_rotate.gameObject);
        });
        button_left = transform.Find("Btn_Left").GetComponent<Button>();
        button_left.onClick.AddListener(delegate()
        {
            this.OnClick_Left(button_left.gameObject);
        });
        button_right = transform.Find("Btn_Right").GetComponent<Button>();
        button_right.onClick.AddListener(delegate()
        {
            this.OnClick_Right(button_right.gameObject);
        });
        button_down = transform.Find("Btn_Down").GetComponent<Button>();
        button_down.onClick.AddListener(delegate()
        {
            this.OnClick_Down(button_down.gameObject);
        });

        resBlock = transform.Find("Panel/block").gameObject;

        CreateRandomBlock();

    }

    float c_time = 0f;
    float tap_time = 0.05f;
    float drop_time = 0f;
    bool is_dropping = false;
    void Update()
    {
        if (is_dropping)
        {
            drop_time += Time.deltaTime;
            if (drop_time >= tap_time)
            {
                drop_time = 0f;
                f.DeleteLine_Drop();
                CreateRandomBlock();
                is_dropping = false;
            }
        }
        else
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
                    if (f.all_node[idx[0], idx[1]] != null)
                    {
                        Debug.LogError("不为空的Frame 被赋值！");
                    }
                    f.all_node[idx[0], idx[1]] = n;
                }
                string testStr = "";
                for (int j = f.high_size - 1; j >= 0; j--)
                {
                    for (int i = 0; i < f.wide_size; i++)
                    {
                        string s = " ";
                        if (f.all_node[i, j] != null)
                            s = "□";
                        testStr += s + ", ";
                    }
                    testStr += "\n";
                }
                // Debug.Log(testStr);
                if (f.DeleteLine())
                {
                    is_dropping = true;
                }
                else
                {
                    CreateRandomBlock();
                }
            }
            // }
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

    bool IsDropEnd()
    {
        for (int i = 0; i < b.down_list.Count; i++)
        {
            Vector3 pos = b.down_list[i].GetPos();
            float x = pos.x;
            float y = pos.y;
            int[] poIndx = f.GetFrameIndex(x, y);
            int xIndx = poIndx[0];
            int yIndx = poIndx[1];
            if (yIndx >= f.high_size) continue;

            int hi = -1;
            for (int h = yIndx - 1; h >= 0; h--)
            {
                if (f.IsFullFrame(xIndx, h))
                {
                    hi = h;
                    // Debug.LogWarning("hi =" + hi);
                    break;
                }
            }
            if (y - Node.leng * 0.5f <= f.down_max)
            {
                AdjustBlock(1, f.down_max + Node.leng * 0.5f - y);
                return true;
            }
            else if (hi > -1 && y - Node.leng * 0.5f <= f.down_max + (hi + 1) * Node.leng)
            {
                AdjustBlock(1, f.down_max + Node.leng * 0.5f + (hi + 1) * Node.leng - y);
                return true;
            }
        }
        return false;
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
                t_type = 3;
                break;
            case 'T':
                t_type = 4;
                break;
            case 'Z':
                t_type = 5;
                break;
            case 'S':
                t_type = 6;
                break;
            case 'O':
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
        char[] sc = new char[2] { 'L', 'I' };
        int rNum = Random.Range(0, sc.Length);
        int rType = 0;
        if (sc[rNum] == 'L')
        {
            rType = Random.Range(1, 5);
        }
        else if (sc[rNum] == 'I')
        {
            rType = Random.Range(1, 3);
        }
        b = CreateBlock(sc[rNum], rType);
        // b = CreateBlock('I', 1);
        b.SetColor(Random.Range(1, 8));
        b.SetShape(new Vector3(0f, 600f, 0f));
        drop_speed = drop_speed_const;
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
        List<Node> left_node_list = b.GetLeftNode();
        for (int i = 0; i < left_node_list.Count; i++)
        {
            Vector3 pos = left_node_list[i].GetPos();
            float x = pos.x;
            float y = pos.y;
            if (x - Node.leng * 0.5f <= f.left_max) //超出 左 边界
            {
                return;
            }
            int[] idx = f.GetFrameIndex(x - Node.leng, y);
            if (idx == null || f.IsFullFrame(idx[0], idx[1])) //左边 有块
            {
                return;
            }
        }
        Vector3 v = b.GetPos();
        b.SetShape(new Vector3(v.x - Node.leng, v.y, 0f));
    }
    void OnClick_Right(GameObject o)
    {
        List<Node> right_node_list = b.GetRightNode();
        for (int i = 0; i < right_node_list.Count; i++)
        {
            Vector3 pos = right_node_list[i].GetPos();
            float x = pos.x;
            float y = pos.y;
            if (x - Node.leng * 0.5f >= f.right_max) //超出 右 边界
            {
                return;
            }
            int[] idx = f.GetFrameIndex(x + Node.leng, y);
            if (idx == null || f.IsFullFrame(idx[0], idx[1])) //右边 有块
            {
                return;
            }
        }
        Vector3 v = b.GetPos();
        b.SetShape(new Vector3(v.x + Node.leng, v.y, 0f));
    }
    void OnClick_Down(GameObject o)
    {

        drop_speed *= 20f;
    }
}
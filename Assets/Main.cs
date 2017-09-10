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
    void Start()
    {
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

    void Update()
    {
        float lowest = b.IsDropEnd(-531f);
        if (-1 != lowest)
        {
            Vector3 v = b.GetPos();
            float xv = v.x;
            float yv = v.y;
            b.SetShape(new Vector3(xv, yv + (-530f - lowest), 0f));
            print("lowest = " + lowest + ", b.GetPos().y = " + b.GetPos().y);
            CreateRandomBlock();
        }
        else
        {
            Block_Drop(b, drop_speed * Time.deltaTime);
        }
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
        Vector3 v = b.GetPos();
        // if(v.x == )
        b.SetShape(new Vector3(v.x - Node.leng, v.y, 0f));
    }
    void OnClick_Right(GameObject o)
    {
        Vector3 v = b.GetPos();
        // if(v.x == )
        b.SetShape(new Vector3(v.x + Node.leng, v.y, 0f));
    }
    void OnClick_Down(GameObject o)
    {
        drop_speed *= 100f;
    }
}
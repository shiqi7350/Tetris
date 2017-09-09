using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    Button button;
    float drop_speed = 500f;

    Transform[] t_child;

    //1,2,3,4
    int t_type = 1;

    GameObject resBlock;

    List<Vector3[]> vPos = new List<Vector3[]>();

    Block b;
    void Start()
    {
        button = transform.Find("Btn_Rotate").GetComponent<Button>();
        button.onClick.AddListener(delegate()
        {
            this.OnClick(button.gameObject);
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
        if (b.IsDropEnd(-531f)) //b.GetPos().y > -531f)
        {
            Vector3 v = b.GetPos();
            float xv = v.x;
            float yv = v.y;
            float dis_all = Mathf.Abs(yv + 530f);
            int div_yv = (int)(dis_all / (Node.leng * 0.5f)) + 1;

            if (div_yv == 1) div_yv = 0;

            b.SetShape(new Vector3(xv, -530f + (div_yv * Node.leng * 0.5f), 0f));

            List<float> lf = b.GetLowPos_Y();
            for (int i = 0; i < lf.Count; i++)
            {
                if (lf[i] < -530f)
                {
                    v = b.GetPos();
                    xv = v.x;
                    yv = v.y;
                    b.SetShape(new Vector3(xv, yv - 530f - lf[i], 0f));
                }
            }
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
    }

    void Block_Drop(Block curB, float speed)
    {
        for (int i = 0; i < 4; i++)
        {
            curB.nodeList[i].Drop(speed);
        }
    }

    void OnClick(GameObject o)
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

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    Button button;
    float drop_speed = 200f;

    Transform[] t_child;

    //1,2,3,4
    int t_type = 1;

    GameObject resBlock;

    List<Vector3[]> vPos = new List<Vector3[]>();

    Block b;
    Block b2;
    void Start()
    {
        button = transform.Find("Image").GetComponent<Button>();
        button.onClick.AddListener(delegate()
        {
            this.OnClick(button.gameObject);
        });
        resBlock = transform.Find("Panel/block").gameObject;

        b = CreateBlock('I', 2);
        b.SetPos(0f, 600f, 0f);

        // b2 = CreateBlock('L', 3);
        // b2.SetPos(0f, 300f, 0f);
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

        b.SetBroNodePos();
        float xxtmp = b.GetLowPos().y;
        if (xxtmp > -500f)
        {
            Block_Drop(b, 100f * Time.deltaTime);
        }
        else
        {
            b = CreateBlock('L', 3);
            b.SetPos(0f, 600f, 0f);
        }
    }

    void Block_Drop(Block curB, float speed)
    {
        for (int i = 0; i < 4; i++)
        {
            curB.nodeList[i].Drop(speed);
        }
        // curB.central_node.Drop(speed);
    }

    void OnClick(GameObject o)
    {
        //旋转 （全都是 顺时针旋转）

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    Button button;

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
                break;
            case 'L':
                tmp_b = new L_Block(nl, type);
                break;
            case 'J':
                break;
            case 'T':
                break;
            case 'Z':
                break;
            case 'S':
                break;
            case 'O':
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
        curB.central_node.Drop(speed);
    }

    void OnClick(GameObject o) { }













    
}
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

    List<Vector3[]> vPos = new List<Vector3[]> ();

    Block b;
    void Start ()
    {
        button = transform.Find ("Image").GetComponent<Button> ();
        button.onClick.AddListener (delegate ()
        {
            this.OnClick (button.gameObject);
        });
        resBlock = transform.Find ("Panel/block").gameObject;

        b = CreateBlock ('I', 2);
        b.SetPos (0f, 10f, 0f);

        Block b2 = CreateBlock ('L', 3);
        b2.SetPos (0f, 300f, 0f);
    }

    Block CreateBlock (char shape_ch, int type)
    {

        Node[] nl = new Node[4];
        for (int i = 0; i < 4; i++)
        {
            GameObject o = Instantiate (resBlock);
            o.transform.parent = transform.Find ("Panel");
            o.transform.localScale = Vector3.one;
            nl[i] = new Node (o.transform);
        }
        Block b = new Block ();

        switch (shape_ch)
        {
            case 'I':
                b = new I_Block (nl, type);
                break;
            case 'L':
                b = new L_Block (nl, type);
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
        return b;
    }

    void Update ()
    {
        b.SetBroNodePos ();
    }

    void OnClick (GameObject o) { }
}
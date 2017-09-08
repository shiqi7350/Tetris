using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node
{
    public static float node_leng = 50f;
    Transform node;
    public float offset_x = 0f;
    public float offset_y = 0f;

    public Node(Transform t)
    {
        node = t;
    }

    public void SetColor(Color c)
    {
        node.GetComponent<Image>().color = c;
    }
    public void DestroyNode()
    {
        GameObject.Destroy(node.gameObject);
    }

    public void SetPos(Vector3 vPos)
    {
        node.localPosition = vPos;
    }
    public Vector3 GetPos()
    {
        return node.localPosition;
    }

    public void Horizon_Move(float offset)
    {
        float x = node.localPosition.x;
        float y = node.localPosition.y;
        node.localPosition = new Vector3(x + offset, y, 0f);
    }

    public void Drop(float speed)
    {
        float x = node.localPosition.x;
        float y = node.localPosition.y;
        node.localPosition = new Vector3(x, y - speed, 0f);
    }
}

public class Block
{
    public Node[] nodeList;
    public Node central_node;

    public Block()
    {
        nodeList = new Node[4];
    }

    public void SetColor(Color c)
    {
        for (int i = 0; i < nodeList.Length; i++)
        {
            nodeList[i].SetColor(c);
        }
    }

    public void SetPos(Vector3 pos)
    {
        central_node.SetPos(pos);
        SetBroNodePos();
    }
    public void SetPos(float x, float y, float z)
    {
        SetPos(new Vector3(x, y, z));
    }
    public virtual Vector3 GetLowPos() //抽象方法
    {
        return Vector3.zero;
    }

    public void SetBroNodePos()
    {
        Vector3 cPos = central_node.GetPos();
        for (int i = 1; i <= 3; i++)
        {
            nodeList[i].SetPos(new Vector3(cPos.x + nodeList[i].offset_x, cPos.y + nodeList[i].offset_y, 0f));
        }
    }
}

/// <summary>
/// I类型块
/// </summary>
public class I_Block : Block
{
    /// <summary>
    /// 1:竖向  2:横向
    /// </summary>
    int flag = 1;
    public I_Block(Node[] nList, int type) : base()
    {
        flag = type;
        nodeList = nList;
        central_node = nodeList[0];
        SetShape();
        SetBroNodePos();
    }

    public override Vector3 GetLowPos()
    {
        if (flag == 1)
        {
            return nodeList[3].GetPos() + new Vector3(0f, -Node.node_leng / 2, 0f);
        }
        else
        {
            return nodeList[0].GetPos() + new Vector3(Node.node_leng / 2, -Node.node_leng, 0f);
        }
    }

    public void SetShape()
    {
        if (flag == 1)//竖向
        {
            nodeList[1].offset_x = 0f;
            nodeList[2].offset_x = 0f;
            nodeList[3].offset_x = 0f;

            nodeList[1].offset_y = 2 * Node.node_leng;
            nodeList[2].offset_y = Node.node_leng;
            nodeList[3].offset_y = -Node.node_leng;
        }
        else if (flag == 2)//横向
        {
            nodeList[1].offset_x = 2 * Node.node_leng;
            nodeList[2].offset_x = Node.node_leng;
            nodeList[3].offset_x = -Node.node_leng;

            nodeList[1].offset_y = 0f;
            nodeList[2].offset_y = 0f;
            nodeList[3].offset_y = 0f;
        }
    }
}

public class L_Block : Block
{
    /// <summary>
    /// 1:  ■
    ///     ■
    ///     ■ ■
    /// ——————————————————————————————————————————————————————————————————————
    /// 2:  ■ ■ ■
    ///     ■     
    /// ——————————————————————————————————————————————————————————————————————
    /// 3:  ■ ■
    ///       ■
    ///       ■
    /// ——————————————————————————————————————————————————————————————————————
    /// 4:      ■
    ///     ■ ■ ■
    /// ——————————————————————————————————————————————————————————————————————
    /// </summary>
    int flag = 1;
    public L_Block(Node[] nList, int type) : base()
    {
        flag = type;
        nodeList = nList;
        central_node = nodeList[0];
        SetShape();
        SetBroNodePos();
    }
    public override Vector3 GetLowPos()
    {
        if (flag == 1)
        {
            return nodeList[0].GetPos() + new Vector3(0f, -Node.node_leng / 2, 0f);
        }
        else if (2 == flag)
        {
            return nodeList[0].GetPos() + new Vector3(0f, -1.5f * Node.node_leng, 0f);
        }
        else if (3 == flag)
        {
            return nodeList[0].GetPos() + new Vector3(0f, -2.5f * Node.node_leng, 0f);
        }
        else
        {
            return nodeList[0].GetPos() + new Vector3(0f, -Node.node_leng / 2, 0f);
        }
    }

    public void SetShape()
    {
        if (flag == 1)//
        {
            nodeList[1].offset_x = 0f;
            nodeList[2].offset_x = 0f;
            nodeList[3].offset_x = Node.node_leng;

            nodeList[1].offset_y = 2 * Node.node_leng;
            nodeList[2].offset_y = Node.node_leng;
            nodeList[3].offset_y = 0;
        }
        else if (flag == 2)//
        {
            nodeList[1].offset_x = Node.node_leng;
            nodeList[2].offset_x = 2 * Node.node_leng;
            nodeList[3].offset_x = 0f;

            nodeList[1].offset_y = 0f;
            nodeList[2].offset_y = 0f;
            nodeList[3].offset_y = -Node.node_leng;
        }
        /// ——————————————————————————————————————————————————————————————————————
        /// 4:      ■
        ///     ■ ■ ■
        /// ——————————————————————————————————————————————————————————————————————
        else if (flag == 3)//
        {
            nodeList[1].offset_x = -Node.node_leng;
            nodeList[2].offset_x = 0f;
            nodeList[3].offset_x = 0f;

            nodeList[1].offset_y = 0f;
            nodeList[2].offset_y = -Node.node_leng;
            nodeList[3].offset_y = -2 * Node.node_leng;
        }
        else if (flag == 4)//
        {
            nodeList[1].offset_x = -2 * Node.node_leng;
            nodeList[2].offset_x = -Node.node_leng;
            nodeList[3].offset_x = 0f;

            nodeList[1].offset_y = 0f;
            nodeList[2].offset_y = 0f;
            nodeList[3].offset_y = Node.node_leng;
        }
    }
}

public class J_Block : Block
{ }

public class O_Block : Block
{ }

public class T_Block : Block
{ }

public class S_Block : Block
{ }

public class Z_Block : Block
{ }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node
{
    public static float leng = 50f;
    Transform node;

    public Node(Transform t)
    {
        node = t;
        node.gameObject.name = "Node";
    }

    public void SetColor(int color)
    {
        node.GetComponent<Image>().sprite = Resources.Load("0" + color, typeof (Sprite)) as Sprite;;
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
    public int flag = 1;
    /// <summary>
    /// 单个块的形态数
    /// </summary>
    public int maxFlag = 1;
    public Node[] nodeList;

    public Block()
    {
        nodeList = new Node[4];
    }

    public void SetColor(int color)
    {
        for (int i = 0; i < nodeList.Length; i++)
        {
            nodeList[i].SetColor(color);
        }
    }

    public virtual void SetShape(Vector3 v) { }

    public virtual Vector3 GetPos()
    {
        return Vector3.zero;
    }

    public virtual List<Node> GetRightNode() { return null; }
    public virtual List<Node> GetLeftNode() { return null; }
    public virtual List<Node> GetDownNode() { return null; }
}

/// <summary>
/// I类型块
/// </summary>
public class I_Block : Block
{
    /// <summary>
    /// 1:竖向  2:横向
    /// ■
    /// ■
    /// ■
    /// ■
    /// </summary>
    public I_Block(Node[] nList, int type) : base()
    {
        flag = type;
        maxFlag = 2;
        nodeList = nList;
    }
    public override Vector3 GetPos()
    {
        if (flag == 1)
        {
            return nodeList[2].GetPos() + new Vector3(Node.leng * 0.5f, -Node.leng * 0.5f, 0f);
        }
        else if (flag == 2)
        {
            return nodeList[1].GetPos() + new Vector3(Node.leng * 0.5f, -Node.leng * 0.5f, 0f);
        }
        return Vector3.zero;
    }

    public override void SetShape(Vector3 v)
    {
        if (flag == 1)
        {
            nodeList[0].SetPos(new Vector3(v.x - Node.leng * 0.5f, v.y + Node.leng * 2.5f, 0f));
            nodeList[1].SetPos(new Vector3(v.x - Node.leng * 0.5f, v.y + Node.leng * 1.5f, 0f));
            nodeList[2].SetPos(new Vector3(v.x - Node.leng * 0.5f, v.y + Node.leng * 0.5f, 0f));
            nodeList[3].SetPos(new Vector3(v.x - Node.leng * 0.5f, v.y - Node.leng * 0.5f, 0f));
        }
        else if (flag == 2)
        {
            nodeList[0].SetPos(new Vector3(v.x - Node.leng * 1.5f, v.y + Node.leng * 0.5f, 0f));
            nodeList[1].SetPos(new Vector3(v.x - Node.leng * 0.5f, v.y + Node.leng * 0.5f, 0f));
            nodeList[2].SetPos(new Vector3(v.x + Node.leng * 0.5f, v.y + Node.leng * 0.5f, 0f));
            nodeList[3].SetPos(new Vector3(v.x + Node.leng * 1.5f, v.y + Node.leng * 0.5f, 0f));
        }
    }

    public override List<Node> GetRightNode()
    {
        List<Node> xlist = new List<Node>();
        if (flag == 1)
        {
            for (int i = 0; i < 4; i++)
                xlist.Add(nodeList[i]);
        }
        else
        {
            xlist.Add(nodeList[3]);
        }
        return xlist;
    }
    public override List<Node> GetLeftNode()
    {
        List<Node> xlist = new List<Node>();
        if (flag == 1)
        {
            for (int i = 0; i < 4; i++)
                xlist.Add(nodeList[i]);
        }
        else
        {
            xlist.Add(nodeList[0]);
        }
        return xlist;
    }
    public override List<Node> GetDownNode()
    {
        List<Node> ylist = new List<Node>();
        if (flag == 1)
        {
            ylist.Add(nodeList[3]);

        }
        else
        {
            for (int i = 0; i < 4; i++)
                ylist.Add(nodeList[i]);
        }
        return ylist;
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
    public L_Block(Node[] nList, int type) : base()
    {
        flag = type;
        maxFlag = 4;
        nodeList = nList;
    }
    public override void SetShape(Vector3 v)
    {
        if (flag == 1)
        {
            nodeList[0].SetPos(new Vector3(v.x - Node.leng * 0.5f, v.y + 1.5f * Node.leng, 0f));
            nodeList[1].SetPos(new Vector3(v.x - Node.leng * 0.5f, v.y + 0.5f * Node.leng, 0f));
            nodeList[2].SetPos(new Vector3(v.x - Node.leng * 0.5f, v.y - 0.5f * Node.leng, 0f));
            nodeList[3].SetPos(new Vector3(v.x + Node.leng * 0.5f, v.y - 0.5f * Node.leng, 0f));
        }
        else if (flag == 2)
        {
            nodeList[0].SetPos(new Vector3(v.x - Node.leng * 0.5f, v.y + Node.leng * 0.5f, 0f));
            nodeList[1].SetPos(new Vector3(v.x + Node.leng * 0.5f, v.y + Node.leng * 0.5f, 0f));
            nodeList[2].SetPos(new Vector3(v.x + Node.leng * 1.5f, v.y + Node.leng * 0.5f, 0f));
            nodeList[3].SetPos(new Vector3(v.x - Node.leng * 0.5f, v.y - Node.leng * 0.5f, 0f));
        }
        else if (flag == 3)
        {
            nodeList[0].SetPos(new Vector3(v.x - Node.leng * 0.5f, v.y + Node.leng * 0.5f, 0f));
            nodeList[1].SetPos(new Vector3(v.x + Node.leng * 0.5f, v.y + Node.leng * 0.5f, 0f));
            nodeList[2].SetPos(new Vector3(v.x + Node.leng * 0.5f, v.y - Node.leng * 0.5f, 0f));
            nodeList[3].SetPos(new Vector3(v.x + Node.leng * 0.5f, v.y - Node.leng * 1.5f, 0f));
        }
        else if (flag == 4)
        {
            nodeList[0].SetPos(new Vector3(v.x + Node.leng * 0.5f, v.y + Node.leng * 0.5f, 0f));
            nodeList[1].SetPos(new Vector3(v.x - Node.leng * 1.5f, v.y - Node.leng * 0.5f, 0f));
            nodeList[2].SetPos(new Vector3(v.x - Node.leng * 0.5f, v.y - Node.leng * 0.5f, 0f));
            nodeList[3].SetPos(new Vector3(v.x + Node.leng * 0.5f, v.y - Node.leng * 0.5f, 0f));
        }
    }
    public override Vector3 GetPos()
    {
        Vector3 v = nodeList[0].GetPos();
        if (flag == 1)
        {
            v = v + new Vector3(Node.leng * 0.5f, -Node.leng * 1.5f, 0f);
        }
        else if (flag == 2)
        {
            v = v + new Vector3(Node.leng * 0.5f, -Node.leng * 0.5f, 0f);
        }
        else if (flag == 3)
        {
            v = v + new Vector3(Node.leng * 0.5f, -Node.leng * 0.5f, 0f);
        }
        else if (flag == 4)
        {
            v = v + new Vector3(-Node.leng * 0.5f, -Node.leng * 0.5f, 0f);
        }
        return v;
    }

    public override List<Node> GetLeftNode()
    {
        List<Node> list = new List<Node>();
        if (1 == flag)
        {
            list.Add(nodeList[0]);
            list.Add(nodeList[1]);
            list.Add(nodeList[2]);
        }
        else if (2 == flag)
        {
            list.Add(nodeList[0]);
            list.Add(nodeList[3]);
        }
        else if (3 == flag)
        {
            list.Add(nodeList[0]);
            list.Add(nodeList[2]);
            list.Add(nodeList[3]);
        }
        else if (4 == flag)
        {
            list.Add(nodeList[0]);
            list.Add(nodeList[1]);
        }
        return list;
    }
    public override List<Node> GetRightNode()
    {
        List<Node> list = new List<Node>();
        if (1 == flag)
        {
            list.Add(nodeList[0]);
            list.Add(nodeList[1]);
            list.Add(nodeList[3]);
        }
        else if (2 == flag)
        {
            list.Add(nodeList[2]);
            list.Add(nodeList[3]);
        }
        else if (3 == flag)
        {
            list.Add(nodeList[1]);
            list.Add(nodeList[2]);
            list.Add(nodeList[3]);
        }
        else if (4 == flag)
        {
            list.Add(nodeList[1]);
            list.Add(nodeList[3]);
        }
        return list;
    }
    public override List<Node> GetDownNode()
    {
        List<Node> list = new List<Node>();
        if (1 == flag)
        {
            list.Add(nodeList[2]);
            list.Add(nodeList[3]);
        }
        else if (2 == flag)
        {
            list.Add(nodeList[1]);
            list.Add(nodeList[2]);
            list.Add(nodeList[3]);
        }
        else if (3 == flag)
        {
            list.Add(nodeList[0]);
            list.Add(nodeList[3]);
        }
        else if (4 == flag)
        {
            list.Add(nodeList[1]);
            list.Add(nodeList[2]);
            list.Add(nodeList[3]);
        }
        return list;
    }
}

public class J_Block : Block { }

public class O_Block : Block { }

public class T_Block : Block { }

public class S_Block : Block { }

public class Z_Block : Block { }
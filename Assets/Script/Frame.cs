using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame
{
    public int wide_size = 14;
    public int high_size = 21;
    public float left_max = -350f;
    public float right_max = 350f;
    public float down_max = -530f;
    public float up_max = 520f;

    public Node[, ] all_node;
    public Frame()
    {
        all_node = new Node[14, 21];
        for (int i = 0; i < 14; i++)
        {
            for (int j = 0; j < 21; j++)
            {
                all_node[i, j] = null;
            }
        }
    }

    //
    // 20
    // |
    // 0-13
    public int[] GetFrameIndex(float x, float y)
    {
        int h = (int)((x - left_max) / 50);
        int v = (int)((y - down_max) / 50);
        if (h < 0 || h > 13 || v < 0) // || v > 20)
            return null;
        return new int[2] { h, v };
    }

    public Vector3 GetFramePos(float x, float y)
    {
        int[] xidx = GetFrameIndex(x, y);
        if (xidx == null) return Vector3.zero;
        float xpos = left_max + Node.leng * (0.5f + xidx[0]);
        float ypos = down_max + Node.leng * (0.5f + xidx[1]);
        return new Vector3(xpos, ypos, 0f);
    }

    public void SetFrameFull(Node n)
    {
        Vector3 v = n.GetPos();
        int[] idxx = GetFrameIndex(v.x, v.y);
        all_node[idxx[0], idxx[1]] = n;
    }

    public bool IsFullFrame(int i, int j)
    {
        if (i < 0 || i >= wide_size || j < 0 || j >= high_size) return true;
        return all_node[i, j] != null;
    }

    // public bool IsFullFrame(float x, float y)
    // {
    //     int[] xidx = GetFrameIndex(x, y);
    //     if (xidx == null)
    //         return true;
    //     return IsFullFrame(xidx[0], xidx[1]);
    // }

    List<int> ready_down_flag = new List<int>();
    public bool DeleteLine()
    {
        ready_down_flag.Clear();
        for (int j = 0; j < high_size; j++)
        {
            bool is_line_full = true;
            for (int i = 0; i < wide_size; i++)
            {
                if (all_node[i, j] == null)
                {
                    is_line_full = false;
                    break;
                }
            }
            if (is_line_full)
            {
                ready_down_flag.Add(j);
                for (int i = 0; i < wide_size; i++)
                {
                    all_node[i, j].DestroyNode();
                    all_node[i, j] = null;
                }
            }
        }
        return ready_down_flag.Count > 0;
    }
    public void DeleteLine_Drop()
    {
        if (ready_down_flag.Count > 0)
        {
            for (int i = ready_down_flag.Count - 1; i >= 0; i--)
            {
                int j = ready_down_flag[i];
                for (int x = 0; x < wide_size; x++)
                {
                    for (int y = j + 1; y < high_size; y++)
                    {
                        if (all_node[x, y] != null)
                        {
                            Vector3 v = all_node[x, y].GetPos();
                            Node tmp_node = all_node[x, y];
                            all_node[x, y] = null;
                            tmp_node.SetPos(new Vector3(v.x, v.y - Node.leng, 0f));
                            all_node[x, y - 1] = tmp_node;
                        }
                    }
                }

            }
        }
    }
}
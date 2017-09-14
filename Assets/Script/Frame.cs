using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame
{
    public int wide_size = 14;
    public int high_size = 21;
    public float left_max_pos = -350f;
    public float right_max_pos = 350f;
    public float down_max_pos = -530f;
    public float up_max_pos = 520f;

    public Node[,] all_node;
    public Frame()
    {
        all_node = new Node[wide_size, high_size];
        for (int i = 0; i < wide_size; i++)
        {
            for (int j = 0; j < high_size; j++)
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
        int h = (int)((x - left_max_pos) / 50);
        int v = (int)((y - down_max_pos) / 50);
        return new int[2] { h, v };
    }


    public bool IsFullFrame(int i, int j)
    {
        if (i < 0 || i >= wide_size || j < 0 || j >= high_size) return true;
        return all_node[i, j] != null;
    }

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
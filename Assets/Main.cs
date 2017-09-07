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

    List<Vector3[]> vPos = new List<Vector3[]>();


    void Start()
    {
        button = transform.Find("Image").GetComponent<Button>();
        button.onClick.AddListener(delegate ()
        {
            this.OnClick(button.gameObject);
        });
    }

    void Update()
    {

    }

    void OnClick(GameObject o)
    {
    }
}



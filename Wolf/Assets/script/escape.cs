using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class escape : MonoBehaviour
{
    Image ctrl;

    private void Start()
    {
        ctrl = GetComponentInChildren<Image>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKey(KeyCode.C))
        {
            Color temp = ctrl.color;
            temp.a = 1;
            ctrl.color = temp;
        }
        else
        {
            Color temp = ctrl.color;
            temp.a = 0;
            ctrl.color = temp;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BtnTap : MonoBehaviour {

    public GameObject vbBtnObj;
    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("VirtualButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (vbBtnObj.name == "VirtualButton")
        {
        Application.OpenURL("https://www.acer.com/ac/ru/RU/content/model/NX.HW3ER.003");
        Debug.Log("Button released");
        }
    }
}

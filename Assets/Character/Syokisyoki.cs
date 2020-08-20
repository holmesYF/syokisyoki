
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syokisyoki : MonoBehaviour
{
    public static Syokisyoki Instance { get; } = new Syokisyoki();
    public ParameterData ParameterData { get; private set; } = new ParameterData(0,0,1.0f,0);


    private Syokisyoki()
    {

    }

    public void UpdateParameterData(ParameterData parameterData)
    {
        this.ParameterData.Add(parameterData);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //　油布の担当
        //  Parameter.Speedの速度で、矢印キー入力に応じ動く
        if (Input.GetKey(KeyCode.LeftArrow)&&(this.gameObject.transform.position.x >= -25.0f))
        {
            Vector3 syokisyoki_pos = this.transform.position;
            syokisyoki_pos.x -= ParameterData.Speed;
            this.transform.position = syokisyoki_pos;
        }
        else if (Input.GetKey(KeyCode.RightArrow)&& (this.gameObject.transform.position.x <= 25.0f))
        {
            Vector3 syokisyoki_pos = this.transform.position;
            syokisyoki_pos.x += ParameterData.Speed;
            this.transform.position = syokisyoki_pos;
        }
    }
}

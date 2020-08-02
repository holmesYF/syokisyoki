﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syokisyoki : MonoBehaviour
{
    public Syokisyoki Instance { get; } = new Syokisyoki();
    public ParameterData ParameterData { get; private set; } = new ParameterData(0,0,1,0);


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
        Debug.Log(Instance.ParameterData.Speed);
        //　油布の担当
        //  Parameter.Speedの速度で、矢印キー入力に応じ動く
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 syokisyoki_pos = this.transform.position;
            syokisyoki_pos.x -= ParameterData.Speed;
            this.transform.position = syokisyoki_pos;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 syokisyoki_pos = this.transform.position;
            syokisyoki_pos.x += ParameterData.Speed;
            this.transform.position = syokisyoki_pos;
        }
    }
}


﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Syokisyoki : MonoBehaviour
{
    //public static Syokisyoki Instance { get; } = new Syokisyoki();
    public ParameterData ParameterData { get; private set; } = new ParameterData(0,255,1.0f,2);
    SpriteRenderer syokirenderer;
    public bool GameFlag;


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
        syokirenderer = this.gameObject.GetComponent<SpriteRenderer>();
        GameFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlag) {
            syokirenderer.color = new Color(ParameterData.BlackDepth / 255f, ParameterData.BlackDepth / 255f, ParameterData.BlackDepth / 255f, 255);
            Debug.Log(ParameterData.BlackDepth);
            Debug.Log(this.gameObject.GetComponent<SpriteRenderer>().color);
            //　油布の担当
            //  Parameter.Speedの速度で、矢印キー入力に応じ動く
            if (Input.GetKey(KeyCode.LeftArrow) && (this.gameObject.transform.position.x >= -25.0f))
            {
                Vector3 syokisyoki_pos = this.transform.position;
                syokisyoki_pos.x -= ParameterData.Speed;
                this.transform.position = syokisyoki_pos;
            }
            else if (Input.GetKey(KeyCode.RightArrow) && (this.gameObject.transform.position.x <= 25.0f))
            {
                Vector3 syokisyoki_pos = this.transform.position;
                syokisyoki_pos.x += ParameterData.Speed;
                this.transform.position = syokisyoki_pos;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        UpdateParameterData(collision.GetComponent<Item>().ParameterData);
        Destroy(collision.gameObject);
        Debug.Log(this.ParameterData.Credit);
    }
}

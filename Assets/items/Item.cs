﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public ParameterData ParameterData { get; protected set; }
    public Sprite Picture { get; protected set; }
    public double Speed { get; protected set; }
    public string Name { get; protected set; }


    public abstract void Start();

    public virtual void Update()
    {
        Transform t = this.transform;
        Vector3 pos = t.position;
        pos.y -= 0.02f * (float)Speed;
        t.position = pos;
        if(this.transform.position.y < -12)
        {
            Destroy(this.gameObject);
        }
    }

    public void ChangeItemSpeed(float Speed)
    {
        this.Speed = Speed;
    }


}

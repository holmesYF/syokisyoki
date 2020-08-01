using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public ParameterData ParameterData { get; protected set; }
    public Texture Picture { get; protected set; }
    public double Speed { get; protected set; }
    public string Name { get; protected set; }

    
    public virtual void Start()
    {

    }

    public virtual void Update()
    {
        Transform t = this.transform;
        Vector3 pos = t.position;
        pos.y += 0.01f * (float)Speed;
        t.position = pos;
    }

    public void ChangeItemSpeed(double Speed)
    {
        this.Speed = Speed;
    }

    // 油布の仕事
    // オブジェクトが接触したらしたみたいな感じでManagerに渡す。
    //private OnTouched()
    //{
    //    Manager.NotifyOnTouch(this.ParameterData);
    //}
}

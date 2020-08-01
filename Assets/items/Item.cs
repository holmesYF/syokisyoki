using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ParameterData ParameterData { get; protected set; }
    public Texture Picture { get; protected set; }
    public int Speed { get; protected set; }
    public string Name { get; protected set; }



    void Start()
    {

    }

    public virtual void Update()
    {
        Transform t = this.transform;
        Vector3 pos = t.position;
        pos.y += 0.01f * Speed;
        t.position = pos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : Item
{
    public ParameterData ParameterData;
    // Start is called before the first frame update
    void Start()
    {
        this.ParameterData = new ParameterData(0, 0, 0, 0);
        this.Speed = 2;
        this.Name = "Credit";
    }
    
    public override void Update()
    {
        Transform t = this.transform;
        Vector3 pos = t.position;
        pos.x += 0.01f * Speed;
        t.position = pos;
    }

}

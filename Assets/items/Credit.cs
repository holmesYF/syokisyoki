using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : Item
{
    // Start is called before the first frame update
    public override void Start()
    {
        // 油布
        this.Picture = Resources.Load<Sprite>("kato");
        this.ParameterData = new ParameterData(100, 0, 1, 1);
        this.Speed = 1;
        this.Name = "Credit";
    }

    public override void Update()
    {
        //Transform t = this.transform;
        //Vector3 pos = t.position;
        //pos.y -= 0.01f;
        //t.position = pos;
    }
}

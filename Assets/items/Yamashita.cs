using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yamashita : Item
{
    public override void Start()
    {
        // 油布
        this.Picture = Resources.Load <Sprite>("yamasita");
        this.ParameterData = new ParameterData(0, 0, 0.5, 0);
        this.Speed = 1;
        this.Name = "Yamashita";
    }
}

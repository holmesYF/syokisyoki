using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kusunoki : Item
{
    public override void Start()
    {
        // 油布
        this.Picture = Resources.Load<Sprite>("kusunoki");
        this.ParameterData = new ParameterData(10, 0, 2, 0);
        this.Speed = 1;
        this.Name = "Kusunoki";
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kusunoki : Item
{
    public override void Start()
    {
        this.Picture = Resources.Load<Sprite>("kusunoki");
        this.ParameterData = new ParameterData(10, 0, 1.1f, 0);
        this.Speed = 1;
        this.Name = "Kusunoki";
    }

}

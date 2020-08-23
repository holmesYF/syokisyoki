using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiro : Item
{
    public override void Start()
    {
        this.Picture = Resources.Load<Sprite>("hiro");
        this.ParameterData = new ParameterData(10, -50, 1, 0);
        this.Speed = 1;
        this.Name = "Hiro";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kakeru : Item
{
    public virtual void Start()
    {
        // 油布
        this.Picture = Resources.Load<Sprite>("kakeru");
        this.ParameterData = new ParameterData(10, 2, 1, 0);
        this.Speed = 1;
        this.Name = "Kakeru";
    }

}

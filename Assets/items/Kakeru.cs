using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kakeru : Item
{
    public override void Start()
    {
        // 油布
        this.Picture = Resources.Load<Sprite>("kakeru");
        this.gameObject.GetComponent<SpriteRenderer>().sprite = this.Picture;
        this.ParameterData = new ParameterData(10, 50, 1, 0);
        this.Speed = 1;
        this.Name = "Kakeru";
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kusunoki : MonoBehaviour
{
    public virtual void Start()
    {
        // 油布
        // this.Picture = 
        this.ParameterData = new ParameterData(10, 0, 2, 0);
        this.Speed = 1;
        this.Name = "Kusunoki";
    }

}

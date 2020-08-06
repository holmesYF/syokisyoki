using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easy : Strategy
{
     public override Order getOrder()
    {
        return order;
    }
}

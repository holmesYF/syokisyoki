using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hard : Strategy
{
    float counter = 0;
    public override Vector2 get_pos()
    {
        if(counter <= 0)
        {
            counter = 100;
            Vector2 next_pos = new Vector2(Random.Range(-25, 25), this.pos.y);
            return next_pos;
        }
        else
        {
            counter -= this.data.Speed * 2;
            return this.pos;
        }
    }
}

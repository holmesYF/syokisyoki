using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal : Strategy
{
    int direction = 1;
    int counter = 0;
    public override Vector2 get_pos()
    {
        if(counter == 0)
        {
            direction *= -1;
            counter = Random.Range(10, 100);
            Vector2 next_pos = new Vector2(this.pos.x + direction * this.data.Speed,this.pos.y);
            return next_pos;
        }
        else
        {
            counter -= 1;
            if(this.pos.x >= 25.0f || this.pos.x <= -25.0f)
            {
                direction *= -1;
            }
            Vector2 next_pos = new Vector2(this.pos.x + direction * this.data.Speed, this.pos.y);
            return next_pos;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal : Strategy
{
    float MOVE = 2.0f;
    int direction = 1;
    int counter = 0;
    public override Vector2 get_pos()
    {
        if(counter == 0)
        {
            direction *= -1;
            counter = Random.Range(5, 20);
            Vector2 next_pos = new Vector2(this.pos.x + direction * MOVE,this.pos.y);
            return next_pos;
        }
        else
        {
            counter -= 1;
            if(this.pos.x >= 25.0f || this.pos.x <= -25.0f)
            {
                direction *= -1;
            }
            Vector2 next_pos = new Vector2(this.pos.x + direction * MOVE, this.pos.y);
            return next_pos;
        }
    }
}

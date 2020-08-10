using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easy : Strategy
{
    bool direction;
    public override Vector2 get_pos()
    {
        if(this.pos.x >= 25.0f)
        {
            this.direction = false;
        }
        else if(this.pos.x <= -25.0f)
        {
            this.direction = true;
        }
        if (direction)
        {
            Vector2 next_pos = new Vector2(this.pos.x + 0.2f,this.pos.y);
            return next_pos;
        }
        else
        {
            Vector2 next_pos = new Vector2(this.pos.x - 0.2f, this.pos.y);
            return next_pos;
        }
    }
}

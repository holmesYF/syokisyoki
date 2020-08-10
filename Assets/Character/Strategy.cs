using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Strategy : MonoBehaviour
{
    protected Order order;
    protected Strategy()
    {
        this.order = new Order();
    }
    protected Vector2 pos;
    public abstract Order getOrder();
    public virtual void set_pos(Vector2 pos) {
        this.pos = pos;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Strategy : MonoBehaviour
{
    protected Vector2 pos;
    protected ParameterData data;
    public abstract Vector2 get_pos();
    public virtual void set_pos(Vector2 pos) {
        this.pos = pos;
    }
    public virtual void set_paramater(ParameterData data)
    {
        this.data = data;
    }
}
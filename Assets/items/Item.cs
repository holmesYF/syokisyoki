using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public ParameterData ParameterData { get; protected set; }
    public Sprite Picture { get; protected set; }
    //textuerからSpriteにした
    public double Speed { get; protected set; }
    public string Name { get; protected set; }


    public abstract void Start();

    public virtual void Update()
    {
        Transform t = this.transform;
        Vector3 pos = t.position;
        pos.y += 0.01f * (float)Speed;
        t.position = pos;
        if(this.transform.position.y < -100)
        {
            Destroy(this.gameObject);
        }
    }

    public void ChangeItemSpeed(float Speed)
    {
        this.Speed = Speed;
    }

    // 油布の仕事
    // オブジェクトが接触したらしたみたいな感じでManagerに渡す。
    //private OnTouched()
    //{
    //    Manager.NotifyOnTouch(this.ParameterData);
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Manager.Instance.NotifyOnTouch(this.ParameterData);
        Destroy(this.gameObject);
    }
}

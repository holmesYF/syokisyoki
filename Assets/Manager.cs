using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Manager: MonoBehaviour 
{
    #region Field
    public int AllCredit { get; private set; }
    public int HasCredit { get; }
    public Timer ElapsedTime = new Timer(1000); // 1秒ごとに関数を実行
    public int TermCounter { get; private set; } = 1;
    #endregion
    Vector2 kato_farst_pos = new Vector2(0.0f, 10.0f);
    Vector2 kato_size = new Vector2(3.0f, 3.0f);

    Vector2 syokisyoki_farst_pos = new Vector2(0.0f, -9.0f);
    Vector2 syokisyoki_size = new Vector2(0.6f, 0.6f);
    Vector2 syokisyoki_collider = new Vector2(-0.21f,0.05f);

    public static Manager Instance { get; private set; } = new Manager();
    private Manager()
    {
        ElapsedTime.Elapsed += new ElapsedEventHandler(CreateScene);
    }

    private void CreateScene(object sender, ElapsedEventArgs e)
    {
        TermCounter++;

    }

    void Start()
    {

    }

    private void Awake()
    {
        GameObject kato = new GameObject("kato_prefab");
        kato.AddComponent<Transform>();
        kato.AddComponent<SpriteRenderer>();
        kato.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("kato");
        kato.transform.position = kato_farst_pos;
        kato.transform.localScale = kato_size;

        GameObject syokisyoki = new GameObject("syoki_prefab");
        syokisyoki.AddComponent<Transform>();
        syokisyoki.AddComponent<SpriteRenderer>();
        syokisyoki.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("syokisyoki");
        syokisyoki.transform.position = syokisyoki_farst_pos;
        syokisyoki.transform.localScale = syokisyoki_size;
        syokisyoki.AddComponent<CircleCollider2D>();
        CircleCollider2D syoki_collider = syokisyoki.GetComponent<CircleCollider2D>();
        syoki_collider.radius = 5;//syokisyokiの当たり判定サイズ
        syoki_collider.offset = syokisyoki_collider;//当たり判定オフセット 名前が微妙
        syokisyoki.AddComponent<Rigidbody2D>();
        syokisyoki.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        syokisyoki.AddComponent<Syokisyoki>();
    }

    void Update()
    {

    }

    public void NotifyOnTouch(ParameterData parameterData)
    {
        
    }

}


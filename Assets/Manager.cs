using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Manager: MonoBehaviour 
{
    #region Field
    public int AllCredit { get; private set; }
    public int HasCredit { get; }
    public Timer ElapsedTime = new Timer(10000); // 1秒ごとに関数を実行
    public int TermCounter { get; private set; } = 2;
    #endregion
    float firsttime;
    public GameObject Kato { get; private set; }
    public GameObject Syokisyoki { get; private set; }
    //public ItemFactory ItemFactory = new ItemFactory();
    //public static Manager Instance { get; private set; } = new Manager();
    private Manager()
    {

    }

    //private void CreateScene(object sender, ElapsedEventArgs e)
    //{

    //    Debug.Log("cre8");
    //    Debug_ d = GetComponent<Debug_>();
    //    d.call();
    //    TermCounter += 1;
    //    this.gameObject.GetComponent<ItemFactory>().CreateItem(ItemList.Kusunoki);
    //}

    private void CreateScene2()
    {
        Debug.Log("cre8");
        Debug_ d = GetComponent<Debug_>();
        d.call();
        TermCounter += 1;
        this.gameObject.GetComponent<ItemFactory>().CreateItem(ItemList.Kusunoki, Vector2.zero);
        this.gameObject.GetComponent<ItemFactory>().CreateItem(ItemList.Kakeru, Vector2.zero);
        this.gameObject.GetComponent<ItemFactory>().CreateItem(ItemList.Credit, Kato.GetComponent<Transform>().position);
        this.gameObject.GetComponent<ItemFactory>().CreateItem(ItemList.Yamashita, Vector2.zero);
    }

    void Start()
    {
        //ElapsedTime.Elapsed += new ElapsedEventHandler(CreateScene);
        //ElapsedTime.Start();
        //Debug_ d = GetComponent<Debug_>();
        //d.call();
        NotifyOnTouch(new ParameterData(0, 0, 1.0f, 0));
    }

    private void Awake()
    {
        CreateKato();
        CreateSyokisyoki();
        firsttime = 5;
    }
    private void CreateKato()
    {
        Kato = new GameObject("kato_prefab");
        Vector2 kato_farst_pos = new Vector2(0.0f, 10.0f);

        Vector2 kato_size = new Vector2(3.0f, 3.0f);

        Kato.AddComponent<SpriteRenderer>();
        Kato.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("kato");
        Kato.transform.position = kato_farst_pos;
        Kato.transform.localScale = kato_size;

        Kato.AddComponent<Katosan>();
        Kato.GetComponent<Katosan>().set_strategy(new Hard());
    }
    private void CreateSyokisyoki()
    {
        Vector2 syokisyoki_farst_pos = new Vector2(0.0f, -9.0f);
        Vector2 syokisyoki_size = new Vector2(0.6f, 0.6f);
        Vector2 syokisyoki_collider = new Vector2(-0.21f, 0.05f);


        Syokisyoki = new GameObject("syoki_prefab");
        Syokisyoki.AddComponent<SpriteRenderer>();
        Syokisyoki.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("syokisyoki");
        Syokisyoki.transform.position = syokisyoki_farst_pos;
        Syokisyoki.transform.localScale = syokisyoki_size;
        Syokisyoki.AddComponent<CircleCollider2D>();
        CircleCollider2D syoki_collider = Syokisyoki.GetComponent<CircleCollider2D>();
        syoki_collider.radius = 5;//syokisyokiの当たり判定サイズ
        syoki_collider.offset = syokisyoki_collider;//当たり判定オフセット 名前が微妙
        Syokisyoki.AddComponent<Rigidbody2D>();
        Syokisyoki.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        Syokisyoki.AddComponent<Syokisyoki>();
    }


    void Update()
    {
        if(firsttime <= Time.time)
        {
            firsttime = Time.time + 5;
            CreateScene2();
        }
    }

    public void NotifyOnTouch(ParameterData parameterData)
    {
        Syokisyoki.GetComponent<Syokisyoki>().UpdateParameterData(parameterData);
    }

}



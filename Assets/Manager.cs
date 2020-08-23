using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using UnityEngine.UI;

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
    public GameObject ScoreObject;
    public GameObject GradeObject;
    public GameObject gameover;
    public GameObject gameclear;
    bool GameFlag;
    //public ItemFactory ItemFactory = new ItemFactory();
    //public static Manager Instance { get; private set; } = new Manager();

    private void CreateScene2()
    {
        TermCounter += 1;
        StartCoroutine("CreateItems");
    }
    IEnumerator CreateItems()
    {
        this.gameObject.GetComponent<ItemFactory>().CreateItem(ItemList.Kusunoki, Vector2.zero);
        yield return new WaitForSeconds(1);
        this.gameObject.GetComponent<ItemFactory>().CreateItem(ItemList.Hiro, Vector2.zero);
        yield return new WaitForSeconds(1); 
        this.gameObject.GetComponent<ItemFactory>().CreateItem(ItemList.Kakeru, Vector2.zero);
        yield return new WaitForSeconds(2);  
        this.gameObject.GetComponent<ItemFactory>().CreateItem(ItemList.Credit, Kato.GetComponent<Transform>().position);
        yield return new WaitForSeconds(5); 
        this.gameObject.GetComponent<ItemFactory>().CreateItem(ItemList.Yamashita, Vector2.zero);
    }
    void Start()
    {
        NotifyOnTouch(new ParameterData(0, 0, 1.0f, 0));
        GameFlag = true;
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
        Vector2 kato_farst_pos = new Vector2(0.0f, 11.0f);

        Vector2 kato_size = new Vector2(3.0f, 3.0f);

        Kato.AddComponent<SpriteRenderer>();
        Kato.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("kato");
        Kato.transform.position = kato_farst_pos;
        Kato.transform.localScale = kato_size;

        Kato.AddComponent<Katosan>();
        Kato.GetComponent<Katosan>().set_strategy(Level.get_level());
    }
    private void CreateSyokisyoki()
    {
        Vector2 syokisyoki_farst_pos = new Vector2(0.0f, -11.0f);
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
        if (GameFlag)
        {
            if (firsttime <= Time.time)
            {
                firsttime = Time.time + 5;
                CreateScene2();
            }
            ScoreObject.GetComponent<Text>().text = Syokisyoki.GetComponent<Syokisyoki>().ParameterData.Score.ToString();
            GradeObject.GetComponent<Text>().text = GradeStateManager.GetCurrentGrade(Syokisyoki.GetComponent<Syokisyoki>().ParameterData.Credit);
            if (Syokisyoki.GetComponent<Syokisyoki>().ParameterData.Credit == 16)
                GameClear();
        }
    }

    public void NotifyOnTouch(ParameterData parameterData)
    {
        Syokisyoki.GetComponent<Syokisyoki>().UpdateParameterData(parameterData);
    }

    public void GameOver()
    {
        if (GameFlag)
        {
            Stop();
            gameover.transform.Find("Text").gameObject.GetComponent<Text>().text = "あなたは" + GradeStateManager.GetCurrentGrade(Syokisyoki.GetComponent<Syokisyoki>().ParameterData.Credit) + "で留年しました\n"
                + "Score:" + Syokisyoki.GetComponent<Syokisyoki>().ParameterData.Score.ToString();
            gameover.SetActive(true);
        }
    }

    public void GameClear()
    {
        Stop();
        gameclear.transform.Find("Text").gameObject.GetComponent<Text>().text = "卒業おめでとう\n"
            + "Score:" + Syokisyoki.GetComponent<Syokisyoki>().ParameterData.Score.ToString();
        gameclear.SetActive(true);
    }
    private void Stop()
    {
        GameFlag = false;
        Syokisyoki.GetComponent<Syokisyoki>().GameFlag = false;
        Kato.GetComponent<Katosan>().GameFlag = false;
    }
}



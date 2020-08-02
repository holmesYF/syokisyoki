using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFactory
{
    public static ItemFactory Instance { get; private set; } = new ItemFactory();

    public Dictionary<ItemList, int> CreatedItemNum { get; private set; } = new Dictionary<ItemList, int>();
    
    private ItemFactory()
    {
        InitCreatedItemNum();
    }
    private void InitCreatedItemNum()
    {
        CreatedItemNum.Add(ItemList.Credit, 0);
        CreatedItemNum.Add(ItemList.Kakeru, 0);
        CreatedItemNum.Add(ItemList.Kusunoki, 0);
        CreatedItemNum.Add(ItemList.Yamashita, 0);
    }

    //public CreateItem(ItemList targetItem)
    //{
    //    CreatedItemNum[targetItem]++;

    //    Vector2 syokisyoki_farst_pos = new Vector2(0.0f, -9.0f);
    //    Vector2 syokisyoki_size = new Vector2(0.6f, 0.6f);
    //    Vector2 syokisyoki_collider = new Vector2(-0.21f, 0.05f);


    //    var Syokisyoki = new GameObject("syoki_prefab");
    //    Syokisyoki.AddComponent<SpriteRenderer>();
    //    Syokisyoki.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("syokisyoki");
    //    Syokisyoki.transform.position = syokisyoki_farst_pos;
    //    Syokisyoki.transform.localScale = syokisyoki_size;
    //    Syokisyoki.AddComponent<CircleCollider2D>();
    //    CircleCollider2D syoki_collider = Syokisyoki.GetComponent<CircleCollider2D>();
    //    syoki_collider.radius = 5;//syokisyokiの当たり判定サイズ
    //    syoki_collider.offset = syokisyoki_collider;//当たり判定オフセット 名前が微妙
    //    Syokisyoki.AddComponent<Rigidbody2D>();
    //    Syokisyoki.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
    //    Syokisyoki.AddComponent<Syokisyoki>();
    //}
}

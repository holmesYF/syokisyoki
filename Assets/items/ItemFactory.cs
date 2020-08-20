using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFactory : MonoBehaviour
{
    GameObject kusunoki_prefab = (GameObject)Resources.Load("kusunoki_prefab");
    GameObject kakeru_prefab = (GameObject)Resources.Load("kakeru_prefab");
    GameObject yamasita_prefab = (GameObject)Resources.Load("yamasita_prefab");
    GameObject credit_prefab = (GameObject)Resources.Load("kusunoki_prefab");
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


    public void CreateItem(ItemList targetItem)
    {
        CreatedItemNum[targetItem]++;
        Debug.Log("koko");
        //GameObject NewObject = new GameObject("Item");
        //NewObject.AddComponent<SpriteRenderer>();
        var rand = new System.Random();

        Vector2 firstPosition = new Vector2(rand.Next(-25, 26), 0);
        switch(targetItem)
        {
            case ItemList.Credit:
                //NewObject.name = "Credit";
                //NewObject.AddComponent<Credit>();
                //NewObject.GetComponent<SpriteRenderer>().sprite = NewObject.GetComponent<Credit>().Picture;
                firstPosition = Katosan.Instance.transform.position;
                break;

            case ItemList.Kakeru:
                //NewObject.name = "Kakeru";
                //NewObject.AddComponent<Kakeru>();
                //NewObject.GetComponent<SpriteRenderer>().sprite = NewObject.GetComponent<Kakeru>().Picture;
                break;

            case ItemList.Kusunoki:
                Instantiate(kusunoki_prefab, firstPosition, Quaternion.identity);
                //NewObject.name = "Kusunoki";
                //NewObject.AddComponent<Kusunoki>();
                //NewObject.GetComponent<SpriteRenderer>().sprite = NewObject.GetComponent<Kusunoki>().Picture;
                break;

            case ItemList.Yamashita:
                //NewObject.name = "Yamashita";
                //NewObject.AddComponent<Yamashita>();
                //NewObject.GetComponent<SpriteRenderer>().sprite = NewObject.GetComponent<Yamashita>().Picture;
                break;

            default:
                throw new System.Exception();
        }

        //Vector2 itemSize = new Vector2(0.6f, 0.6f);
        //Vector2 itemCollider = new Vector2(-0.21f, 0.05f);

        //NewObject.transform.position = firstPosition;
        //NewObject.transform.localScale = itemSize;

        //NewObject.AddComponent<CircleCollider2D>();
        //CircleCollider2D syoki_collider = NewObject.GetComponent<CircleCollider2D>();
        //syoki_collider.radius = 5;//syokisyokiの当たり判定サイズ
        //syoki_collider.offset = itemCollider;//当たり判定オフセット 名前が微妙
        
        //NewObject.AddComponent<Rigidbody2D>();
        //NewObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
    }
}

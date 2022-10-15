using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;


public class Cards
{
    private string color;
    private string value;
    private Sprite image;
    
    public string GetColor()
    {
        return color;
    }
    
    public string GetValue()
    {
        return value;
    }
    
    public Sprite GetImage()
    {
        return image;
    }

    public Cards(string color, string value, Sprite image)
    {
        this.color = color;
        this.value = value;
        this.image = image;

    }
}

public class click : MonoBehaviour
{
    private List<string> colors = new List<string>() { "Cross", "Hearts", "Spades", "Diamonds" };
    private List<string> values = new List<string>() { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
    [SerializeField] private Sprite[] cardsImage = new Sprite[52];
    public GameObject prefab;
    private List<Cards> cards = new List<Cards>();
    private List<GameObject> l = new List<GameObject>();
    private List<bool> b = new List<bool>();
    private int im = 0;

    void Start()
    {
        for(int i =0; i<colors.Count; i++)
        {
            for (int e = 0; e < values.Count; e++)
            {
                cards.Add(new Cards(colors[i], values[e], cardsImage[im]));
                im++;
                b.Add(false);
            }
        }

     /*   for (int i = 0; i < cards.Count; i++)
        {
            GameObject n = Instantiate(prefab);
            n.name = cards[i].GetColor() + " " + cards[i].GetValue();
            n.gameObject.transform.Find("CardBack").GetComponent<SpriteRenderer>().sprite = cards[i].GetImage();
            l.Add(n);
        }*/
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            int rand = Random.Range(0, 51);
            if (hit.collider != null && hit.collider.name == name && hit.transform.name == "Cards" && b[rand]!=true)
            {
                GameObject n = Instantiate(prefab);
                n.name = cards[rand].GetColor() + " " + cards[rand].GetValue();
                n.gameObject.transform.Find("CardBack").GetComponent<SpriteRenderer>().sprite = cards[rand].GetImage();
                b[rand] = true;
                n.transform.position = transform.position - transform.position + new Vector3(0, 9, 96);
                l.Add(n);
            }
        }
    }
}

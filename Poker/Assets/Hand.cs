using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    // Start is called before the first frame update
    public CardsAssetPackDeck deck;
    public Transform cards;
    public List<CardInstance> getCards()
    {
        List<CardInstance> cards=new List<CardInstance>();

        for(int i=0; i<transform.childCount; i++)
        {
            cards.Add(transform.GetChild(i).gameObject.GetComponent<CardInstance>());
        }
        return cards;
    }
    
    void Start()
    {
        var card=deck.DrawAndCreateCard();
        card.transform.SetParent(cards);
    }

    // Update is called once per frame
    void Update()
    {
     for(int i = 0; i < cards.childCount; i++)
        {
            cards.GetChild(i).transform.localPosition = new Vector3(1*i,0,0);
            cards.GetChild(i).transform.localRotation = Quaternion.Euler(90, -90, 0);
        }   
    }
}

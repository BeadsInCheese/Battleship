using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableCards : MonoBehaviour
{
    // Start is called before the first frame update
    public CardsAssetPackDeck deck;
    public float padding;
    public void drawStartCards()
    {
        for (var indexer = 0; indexer < 5; indexer++)
        {
            var card = deck.DrawAndCreateCard();

            card.transform.SetParent(transform);
        }

    }
    void Start()
    {
        drawStartCards();
    }

    // Update is called once per frame
    void Update()
    {
        for(var i=0; i<transform.childCount; i++)
        {

            var child=transform.GetChild(i);
            child.localPosition = Vector3.zero + new Vector3( 0,0, i * padding);
            child.rotation = Quaternion.Euler(0,90,0);
            child.localScale = Vector3.one*4;

        }
    }
}

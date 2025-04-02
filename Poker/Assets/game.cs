using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    // Start is called before the first frame update
    public CardsAssetPackDeck deck;
    public TableCards table;
    public int pot;
    void Start()
    {
        deck.DrawAndCreateCard();
        
    }
    public int getHandValue() {

        return 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

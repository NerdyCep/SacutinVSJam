using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public CardSO card;
    public TextMeshPro mnameText;

    void Start()
    {
        mnameText.text = card.name;  
    }

}

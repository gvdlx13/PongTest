using Assets;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TitleController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI winnerDisplay;

    // Start is called before the first frame update
    void Awake()
    {
        winnerDisplay.text = Winner.winner;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
    Text text;
    public static int scoreValue;

    //Use this for initialization

    void Start()
    {
        text = GetComponent<Text>();
    }

    //Update is callsed one per frame
    /*
    private void Update()
    {
        if (whosTurn == 1)
        {
            player1 = player1 + randomDiceSide + 1;
            Debug.Log("Random dice" + randomDiceSide);
            Debug.Log("player1 " + player1);
            yield return new WaitForSeconds(0.05f);
        }

        if (whosTurn == -1)
        {
            player2 = player2 + randomDiceSide + 1;
            Debug.Log("Random dice" + randomDiceSide);
            Debug.Log("player2 " + player2);
            yield return new WaitForSeconds(0.05f);
        }
        text.text = "Score:" + scoreValue;
    }*/
}
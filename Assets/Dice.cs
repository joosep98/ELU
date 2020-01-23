using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private int whosTurn = 1;
    private bool coroutineAllowed = true;

    

    public int player1 = 0;
    public int player2 = 0;

    public int size = 1;

  
    // Use this for initialization
    private void Start () {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[3];
	}

    private void OnMouseDown()
    {
        if (!GameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
    }

    public IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 4);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

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
            /*Debug.Log("Random dice" + randomDiceSide);*/
            /*Debug.Log("player2 " + player2);*/
            yield return new WaitForSeconds(0.05f);
        }

        
        if(player1 >= 14)
        {
            GameControl.gameOver = true;
            //vaja juurde teha ka et gameover tekst n'itaks
        }

        GameControl.diceSideThrown = randomDiceSide + 1;
        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        } else if (whosTurn == -1)
        {
            GameControl.MovePlayer(2);
        }
        whosTurn *= -1;
        coroutineAllowed = true;
    }

    
    
}

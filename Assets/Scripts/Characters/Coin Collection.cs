using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private static int Coin = 0;
public void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            Coin++;
            Debug.Log("Coin Inventory: " + Coin);
            Destroy(gameObject);
       }
    }

}

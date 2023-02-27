using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int value;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            FindObjectOfType<GameManager>().addGold(value);
            Destroy(gameObject);
        }
    }
}

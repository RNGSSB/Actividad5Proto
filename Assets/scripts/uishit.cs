using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uishit : MonoBehaviour
{

    public TMP_Text text;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            text.text = "COINS: " + player.GetComponent<playermovement>().coinCount.ToString() + " SWAG: " + player.GetComponent<playermovement>().swagCount.ToString();
        }
        else {
            Destroy(gameObject);
        }
    }
}

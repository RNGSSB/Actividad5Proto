using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int carril = 0;
    public bool letGo = false;
    public int coinCount = 0;
    public int swagCount = 0;
    public GameObject nintendoForgotAboutMario;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") > 0 && carril != 1 && !letGo)
        {
            rb.position += new Vector2(0, 2);
            carril += 1;
            letGo = true;
        }
        else if (Input.GetAxisRaw("Vertical") < 0 && carril != -1 && !letGo)
        {
            rb.position += new Vector2(0, -2);
            carril -= 1;
            letGo = true;
        }

        if (Input.GetAxisRaw("Vertical") == 0) {
            letGo = false;
        } 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "coin") {
            coinCount += 1;
            Destroy(collision.gameObject);
        }

        if (collision.tag == "enemigo")
        {

            Instantiate(nintendoForgotAboutMario);
            Destroy(collision.gameObject);
            Application.Quit();
        }

        if (collision.tag == "gangsta")
        {
            swagCount += 20;
            Destroy(collision.gameObject);
        }

        if (collision.tag == "pikmin")
        {
            coinCount += 5;
            swagCount += 5;
            Destroy(collision.gameObject);
        }
    }
}

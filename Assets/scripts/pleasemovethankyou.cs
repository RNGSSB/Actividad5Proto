using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pleasemovethankyou : MonoBehaviour
{
    public float speed = -0.04f;
    public float timeRemaining = 1;
    public bool isCoin = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(speed, 0));
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else {
            Debug.Log("KILL YOURSELF!!!! /j");
            Destroy(gameObject);
        }
    }
}

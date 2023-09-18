using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thingspawner : MonoBehaviour
{
    public GameObject stupidFuckingBackground;
    public GameObject iHatePikmin;
    public GameObject superGangstaMario;
    public GameObject cash;
    public GameObject antiCristo;
    public float timeRemaining = 0.5f;
    public float timePikmin = 15;
    public float timeCash = 5;
    public float timeAntiCristo = 10;
    public float timeGangsta = 30;
    public float timer;
    public float timerPikmin;
    public float timerGangsta;
    public float timerCash;
    public float timerAnti;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = timeRemaining;
        timerCash = timeCash;
        timerPikmin = timePikmin;
        timerGangsta = timeGangsta;
        timerAnti = timeAntiCristo;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else {
            Instantiate(stupidFuckingBackground);
            timer = timeRemaining;
        }

        if (timerCash > 0)
        {
            timerCash -= Time.deltaTime;
        }
        else
        {
            Instantiate(cash, new Vector3(20, Random.Range(-1, 2) * 2,0), transform.rotation) ;
            timerCash = timeCash;
        }

        if (timerAnti > 0)
        {
            timerAnti -= Time.deltaTime;
        }
        else
        {
            Instantiate(antiCristo, new Vector3(20, Random.Range(-1, 2) * 2, 0), transform.rotation);
            timerAnti = timeAntiCristo;
        }

        if (timerGangsta > 0)
        {
            timerGangsta -= Time.deltaTime;
        }
        else
        {
            Instantiate(superGangstaMario, new Vector3(20, Random.Range(-1, 2) * 2, 0), transform.rotation);
            timerGangsta = timeGangsta;
        }

        if (timerPikmin > 0)
        {
            timerPikmin -= Time.deltaTime;
        }
        else
        {
            Instantiate(iHatePikmin, new Vector3(20, Random.Range(-1, 2) * 2, 0), transform.rotation);
            timerPikmin = timePikmin;
        }
    }
}

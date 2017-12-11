using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FootballScript : MonoBehaviour {

    int rNum;

	// Use this for initialization
	void Start () {
        Random r = new Random();
        rNum = Random.Range(1, 3);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (rNum % 2 == 0))
        {
            this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(-2f, 10f);
            }
        }
    }
}

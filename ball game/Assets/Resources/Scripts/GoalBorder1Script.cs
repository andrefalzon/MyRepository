using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBorder1Script : MonoBehaviour {

    Player1UIScript player1 = new Player1UIScript();


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        player1.IncrementOne(1);
    }
}

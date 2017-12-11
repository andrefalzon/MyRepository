using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 12) - 6;
        print(mousePosInUnits);


        Vector3 newPaddlePos = new Vector3(gameObject.transform.position.x, mousePosInUnits, gameObject.transform.position.z);

        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -5.113f, 5.113f);

        gameObject.transform.position = newPaddlePos;


    }
}

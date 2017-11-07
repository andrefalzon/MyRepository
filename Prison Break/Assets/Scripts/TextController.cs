using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    enum States { cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, corridor_0, stairs_0,floor, closet_door, stairs_1, corridor_1, in_closet, stair_2, corridor_2, corridor_3, courtyard}

    public Text myText;
    States myState;

	// Use this for initialization
	void Start () {

        myState = States.cell;

        //intialise myState to cell


		
	}

    // Update is called once per frame
    void Update()
    {
        if (myState == States.cell) { Cell(); }
        else if (myState ==States.sheets_0) { Sheets_0(); }
        else if (myState == States.mirror) { Mirror(); }
        else if (myState == States.lock_0) { Lock_0(); }
        else if (myState == States.cell_mirror) { Cell_Mirror(); }
        else if (myState == States.sheets_1) { Sheets_1(); }
        else if (myState == States.lock_1) { Lock_1(); }
        else if (myState == States.corridor_0) { Corridor_0(); }
        else if (myState == States.stairs_0) { Stairs_0(); }
        else if (myState == States.floor) { Floor(); }
        else if (myState == States.corridor_0) { Corridor_0(); }
        else if (myState == States.corridor_0) { Corridor_0(); }
        else if (myState == States.corridor_0) { Corridor_0(); }




    }
    void Cell()
    {
        myText.text = "You are in a prison cell and you want to escape. " +
        "\nThere are some dirty sheets on the bed, a mirror on th wall " +
        "and the door is locked from outside.\n\n" +
        "Press S to view the sheets, M to view the mirror and L to view" +
        " the lock.";

            if (Input.GetKeyDown(KeyCode.S))        { myState = States.sheets_0; }
            else if (Input.GetKeyDown(KeyCode.M))   { myState = States.mirror; }
            else if (Input.GetKeyDown(KeyCode.L))   { myState = States.lock_0; }
        }

    void Sheets_0()
    {
        myText.text = "These sheets are very dirty! I guess you would expect that from prison. Hopefully they are changed soon!" +
            "\n\nPress R to return back to the middle of the cell";

        if (Input.GetKeyDown(KeyCode.R))             { myState = States.cell; }
    }

    void Lock_0()
    {
        myText.text = "This is one of those buttons locks. You have no idea what the combination is." +
            " You wish you could somehow see where the dirty fingerprints were." + 
            "\n\nPress R to return back to the middle of the cell"; 

         if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
    }

    void Mirror()
    {
        myText.text = "That dirty old mirror on the wall seems losse!" + "\n\nPress T to take the mirror or R return to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.T)) { myState = States.cell_mirror; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
    }

    void Cell_Mirror()
    {
        myText.text = " You are still in your cell and you still want to escape!" +
            "There are still some dirty sheets on the bed and the cell door which is firmly locked" +
            "\n\nPress S to view the sheets, L to view the lock.";

        if (Input.GetKeyDown(KeyCode.S))        { myState = States.sheets_1; }
        else if (Input.GetKeyDown(KeyCode.L))   { myState = States.lock_1; }


    }

    void Sheets_1 ()
    {
        myText.text = "Holding a mirror in your hand, wont make the sheets look any better and cleaner" +
            "\n\nPress R to return back to the middle of the cell";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell_mirror; }
    }

    void Lock_1()
    {
        myText.text = "You carefully put the mirror through the bars, and return it round to see the lock" +
            "You can now see the fingerprints on the buttons" +
            "Your press the dirty buttons and hear a click!!" +
            "\n\nPress O to open, R to return back to the cell";

        if (Input.GetKeyDown(KeyCode.O)) { myState = States.corridor_0; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell_mirror; }
    }

    void Corridor_0()
    {
        myText.text = "You are not free yet!! " +
            "\n\nPress S to go stairs_0, press F to go floor or press C to enter the closet_door";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.stairs_0; }
        else if (Input.GetKeyDown(KeyCode.F)) { myState = States.floor; }
        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.closet_door; }

    }

    void Floor()
    {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip.\n\n";
    }

    void Stairs_0()
    {

    }
}

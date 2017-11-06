using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    //Skapa nuvarande HP för enemy
    //Skapa max HP för enemy
    //Skapa nuvarande HP för muren
    //Skapa max HP för muren

	// Use this for initialization
	void Start ()
    {
        //Nuvarande HP sätts till max HP för enemy
        //Nuvarande HP sätts till max HP för muren
    }

    // Update is called once per frame
    void Update ()
    {
		//Om HP är mindre eller lika med 0
            //Karaktären dör
        
        //Om HP för muren är mindre eller lika med 0
            //Spelaren förlorar gamet

        //Om spelaren träffar en enemy
            //Karaktären som träffas tappar HP beroende på vart skottet träffar och på vilket skott som skjutits

        //Om spells eller liknande torn träffar en enemy
            //Är det en DOT eller tar karaktären direkt dmg
                //Om det är en DOT så tar karaktären dmg över tid (DOT beror på vilken spell som träffar karaktären)
                //Annars tar karaktären direkt dmg (dmg beror på vad det är som träffar karaktären)

        //När HP minskas för en enemey så sänks HP-mätaren som tillhör karaktären
        
        //När HP minskas för muren så sänks HP-mätaren som tillhör muren

        //Om murens HP är mindre eller lika med 75%
            //Muren ändrar utseende

        //Om murens HP är mindre eller lika med 50%
            //Muren ändrar utseende

        //Om murens HP är mindre eller lika med 25%
            //Muren ändrar utseende

        //Om murens HP är mindre eller lika med 0
            //Muren ändrar utseende
	}
}

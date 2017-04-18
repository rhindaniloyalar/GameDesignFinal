/************************PlayerCreationGUI**********************************
 *Programmer: Christine Jordan
 *Class: PlayerCreationGUI
 *Inheritance: MonoBehaviour
 *Date Created: 11/25/15
 *Date Modified: 11/25/15
 *Project: Project Avenon
 *Purpose: Class to maintain the user interface for creating a player
 *         character.
 *Changelog: [11/26/15] Added class comment header.
 ***************************************************************************/
using UnityEngine;
using System.Collections;

public class PlayerCreationGUI : MonoBehaviour
{
    public enum CreateACharacterStates
    {
        CLASS_SELECTION, //display all classes
        STAT_ALLOCATION, //allocate stats
        FINAL_SETUP      //name and misc items, gender
    }

    public static CreateACharacterStates currentState;
    private CreateCharacterFunctions displayFunctions = new CreateCharacterFunctions();

    /*******************************Start****************************************
     * In:
     * Out:
     * Purpose: Use this for initialization
     * **************************************************************************/
    void Start()
    {
        currentState = CreateACharacterStates.CLASS_SELECTION; //starts @ class selection
    }
    /******************************Update***************************************
    * In:
    * Out:
    * Purpose: Update is called once per frame
    * **************************************************************************/
    void Update()
    {
        switch (currentState)
        {
            case (CreateACharacterStates.CLASS_SELECTION):
                break;
            case (CreateACharacterStates.STAT_ALLOCATION):
                break;
            case (CreateACharacterStates.FINAL_SETUP):
                break;
        }
    }
    /********************************OnGUI***************************************
    * In:
    * Out:
    * Purpose: Manage GUI for Character creation
    * **************************************************************************/
    void OnGUI()
    {
        displayFunctions.DisplayMainItems();
        if (currentState == CreateACharacterStates.CLASS_SELECTION)
        {
            displayFunctions.DisplayClassSelections();
        }
        if (currentState == CreateACharacterStates.STAT_ALLOCATION)
        {
            displayFunctions.DisplayStatAllocation();
        }
        if (currentState == CreateACharacterStates.FINAL_SETUP)
        {
            displayFunctions.DisplayFinalSetup();
        }
    }
}

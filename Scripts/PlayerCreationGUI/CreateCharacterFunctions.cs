/**********************CreateCharacterFunctions*****************************
 *Programmer: Christine Jordan
 *Class: CreateCharacterFunctions
 *Inheritance: None
 *Date Created: 11/25/15
 *Date Modified: 11/25/15
 *Project: Project Avenon
 *Purpose: Holds the functions for creating a charcater fo the game.
 *Changelog: [11/26/15]
 ***************************************************************************/
using UnityEngine;
using System.Collections;

public class CreateCharacterFunctions
{
    private int classSelection;
    private BaseClass player = new BaseClass();
    private StatAllocationModule statAllocationModule = new StatAllocationModule();
    private string[] classNames = new string[] {"Barbarian", "Bard", "Cleric", "Druid",
                 "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Wizard" };
    private string firstName = "First Name";
    private string surName = "Sur Name";
    private string bio = "Character Bio";
    private string[] genderTypes = new string[2] { "Male", "Female" };
    private int genderSelection;

    /************************DisplayClassSelection********************************
     * In:
     * Out:
     * Purpose: List of toggle buttons for each class
     *          selection grid
     * **************************************************************************/
    public void DisplayClassSelections()
    {
        classSelection = GUI.SelectionGrid(new Rect(25, 25, 300, 250), classSelection,
            classNames, 3);
        GUI.Label(new Rect(Screen.width / 2, 40, 300, 300), FindClassDescription(classSelection));
        GUI.Label(new Rect(Screen.width / 2, 80, 300, 300), FindClassStatValues(classSelection));
    }

    /************************FindClassDescription*********************************
     * In: classSelection
     * Out: tempClass.ClassDescription
     * Purpose: find ad display class description for the player.
     *          TODO: Combine FindClassDescription & FindClassStats to a single
     *                function.
     * **************************************************************************/
    private string FindClassDescription(int classIndex)
    {
        if (classIndex == 4)
        {
            BaseClass tempClass = new FighterClass();
            return tempClass.ClassDescription;
        }
        else if (classIndex == 10)
        {
            BaseClass tempClass = new WizardClass();
            return tempClass.ClassDescription;
        }
        else
        {
            return "This class not yet implemented," +
                " Implemented classes are Fighter and Wizard.";
        }
    }

    /************************FindClassStatValues**********************************
     * In: classSelection
     * Out: ToString for the given class
     * Purpose: 
     * **************************************************************************/
    private string FindClassStatValues(int classIndex)
    {
        if (classIndex == 4)
        {
            BaseClass tempClass = new FighterClass();
            return tempClass.ToString();               //returns overridden ToString for class
        }
        else if (classIndex == 10)
        {
            BaseClass tempClass = new WizardClass();
            return tempClass.ToString();
        }
        else
        {
            return "No Stats Available";
        }
    }

    /************************DisplayStatAllocation*******************************
    * In:
    * Out:
    * Purpose: list of stats with plus/negative buttons to add stats
    *          logic so player cannon add more than stats given or reduce below
    *          starting stats 
    * **************************************************************************/
    public void DisplayStatAllocation()
    {
        statAllocationModule.DisplayAllocationModule();
    }

    /************************DisplayFinalSetup***********************************
     * In:
     * Out:
     * Purpose: name character, choose gender, add a background story.
     * **************************************************************************/
    public void DisplayFinalSetup()
    {
        firstName = GUI.TextArea(new Rect(20, 10, 150, 25), firstName, 10);
        surName = GUI.TextArea(new Rect(20, 55, 150, 25), surName, 10);
        bio = GUI.TextArea(new Rect(20, 90, 250, 200), bio, 250);

        genderSelection = GUI.SelectionGrid(new Rect(200, 10, 115, 40), genderSelection,
            genderTypes, 2);
    }

    /****************************ChooseClass**************************************
     * In:
     * Out:
     * Purpose:
     * **************************************************************************/
    private void ChooseClass(int classIndex)
    {
        if (classIndex == 4)
        {
            player = new FighterClass();
            GameInfoManager.PlayerClass = new FighterClass();
        }
        else if (classIndex == 10)
        {
            player = new WizardClass();
            GameInfoManager.PlayerClass = new WizardClass();
        }
        else
        {
            player = null;
        }
    }

    /************************DisplayFinalSetup***********************************
    * In:
    * Out:
    * Purpose:
    * **************************************************************************/
    public void DisplayMainItems()
    {
        GUI.Label(new Rect(Screen.width / 2, 20, 200, 500), "Create New Character");
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;

        if (GUI.Button(new Rect(270, 400, 50, 25), "<<<"))
        {
            //turn transform tagged as player left
            player.Rotate(Vector3.up * 10);
        }

        if (GUI.Button(new Rect(430, 400, 50, 25), ">>>"))
        {
            //turn transform tagged as player right
            player.Rotate(Vector3.down * 10);
        }

        if (PlayerCreationGUI.currentState != //if not in final setup display next button
                PlayerCreationGUI.CreateACharacterStates.FINAL_SETUP)
        {
            if (GUI.Button(new Rect(600, 400, 50, 25), "Next"))
            {
                NextButton();
            }
        }
        else if (PlayerCreationGUI.currentState == //if in final setup display finish button
                PlayerCreationGUI.CreateACharacterStates.FINAL_SETUP)
        {
            if (GUI.Button(new Rect(600, 400, 50, 25), "Finish"))
            {
                FinishButton();
            }
        }

        if (PlayerCreationGUI.currentState != //if not in Class_Selection display back button
                PlayerCreationGUI.CreateACharacterStates.CLASS_SELECTION)
        {
            if (GUI.Button(new Rect(150, 400, 50, 25), "Back"))
            {
                BackButton();
            }
        }
    }

    /****************************NextButton**************************************
     * In:
     * Out:
     * Purpose: 
     * **************************************************************************/
    public void NextButton()
    {
        if (PlayerCreationGUI.currentState == //if in class selection move to stat allocation
                   PlayerCreationGUI.CreateACharacterStates.CLASS_SELECTION)
        {
            ChooseClass(classSelection);
            if (GameInfoManager.PlayerClass != null)
            {
                PlayerCreationGUI.currentState = //if in stat allocation move to final setup
                    PlayerCreationGUI.CreateACharacterStates.STAT_ALLOCATION;
            }
        }
        else if (PlayerCreationGUI.currentState ==
            PlayerCreationGUI.CreateACharacterStates.STAT_ALLOCATION)
        {
            SaveStats();
            PlayerCreationGUI.currentState =
                PlayerCreationGUI.CreateACharacterStates.FINAL_SETUP;
        }
    }

    /*****************************FinishButton***********************************
    * In:
    * Out:
    * Purpose: 
    * **************************************************************************/
    public void FinishButton()
    {
        GameInfoManager.PlayerName = firstName;
        GameInfoManager.PlayerBio = bio;

        if (genderSelection == 0)
            GameInfoManager.IsMale = true;
        else if (genderSelection == 1)
            GameInfoManager.IsMale = false;

        SaveGame.SaveAllInformation();
        GameInfoManager.CurrentHitPoints = 
            GameInfoManager.MaxHitPoints = GameInfoManager.Constitution * 5;

        GameInfoManager.PlayerCurrentEnergy =
            GameInfoManager.PlayerMaxEnergy = GameInfoManager.Constitution * 3;


        //GameInfoManager.playerAbilities = player.playerAbilities;       
        Application.LoadLevel("Wasteland");
    }

    /****************************BackButton**************************************
    * In:
    * Out:
    * Purpose: 
    * **************************************************************************/
    public void BackButton()
    {
        if (PlayerCreationGUI.currentState == //if in Stat_Allocation move to Class_Selection
                        PlayerCreationGUI.CreateACharacterStates.STAT_ALLOCATION)
        {
            statAllocationModule.didRunOnce = false;
            PlayerCreationGUI.currentState = //if in Final_Setup move to Stat_Allocation
                PlayerCreationGUI.CreateACharacterStates.CLASS_SELECTION;
        }
        else if (PlayerCreationGUI.currentState ==
            PlayerCreationGUI.CreateACharacterStates.FINAL_SETUP)
        {
            PlayerCreationGUI.currentState =
                PlayerCreationGUI.CreateACharacterStates.STAT_ALLOCATION;
        }
    }

    /*****************************SaveStats**************************************
    * In:
    * Out:
    * Purpose: 
    * **************************************************************************/
    public void SaveStats()
    {
        GameInfoManager.Strength = statAllocationModule.pointsToAllocate[0];
        GameInfoManager.Constitution = statAllocationModule.pointsToAllocate[1];
        GameInfoManager.Dexterity = statAllocationModule.pointsToAllocate[2];
        GameInfoManager.Intellegence = statAllocationModule.pointsToAllocate[3];
        GameInfoManager.Wisdom = statAllocationModule.pointsToAllocate[4];
        GameInfoManager.Charisma = statAllocationModule.pointsToAllocate[5];
    }
}

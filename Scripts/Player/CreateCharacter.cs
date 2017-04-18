/**************************CreateCharacter**********************************
 *Programmer: Christine Jordan
 *Class: PlayerController
 *Inheritance: Monobehaviour
 *Date Created: 11/5/15
 *Date Modified: 11/7/15
 *Project: Project Avenon
 *Purpose:
 *ChangeLog: [11/5/15] Created Script
 *           [11/8/15] Added comment headers.
 ***************************************************************************/
using UnityEngine;
using System.Collections;

public class CreateCharacter: MonoBehaviour
{
    private BasePlayer newPlayer;
    private bool isWizardClass = false;
    private bool isFighterClass = false;
    private string playerName = "Enter Name.";
	
    // Use this for initialization
	void Start ()
    {
        newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

/*********************************OnGUI**************************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName, 15);
        if (GUILayout.Toggle(isWizardClass, "Wizard"))
        {
            isWizardClass = true;
            isFighterClass = false;
        }
        if(GUILayout.Toggle(isFighterClass, "Fighter"))
        {
            isFighterClass = true;
            isWizardClass = false;
        }

        if (GUILayout.Button("Create"))
        {
            if (isWizardClass)
            {
                newPlayer.PlayerClass = new WizardClass();
            }
            else if (isFighterClass)
            {
                newPlayer.PlayerClass = new FighterClass();
            }

            StoreNewPlayerInfo();
            SaveGame.SaveAllInformation();
            Debug.Log("Player Class: " + newPlayer.PlayerClass.ClassName);
        }
        if (GUILayout.Button("Load"))
        {
            Application.LoadLevel("test");
        }
    }
/*************************StoreNewPlayerInfo*********************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    private void StoreNewPlayerInfo()
    {
        GameInfoManager.PlayerName = newPlayer.PlayerName;
        GameInfoManager.PlayerLevel = newPlayer.PlayerLevel;
        GameInfoManager.Strength = newPlayer.Strength;
        GameInfoManager.Intellegence = newPlayer.Intellegence;
        GameInfoManager.Constitution = newPlayer.Constitution;
        GameInfoManager.Wisdom = newPlayer.Wisdom;
        GameInfoManager.Charisma = newPlayer.Charisma;
        GameInfoManager.Dexterity = newPlayer.Dexterity;
    }

/*************************CreateNewPlayer************************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    private void CreateNewPlayer()
    {
        newPlayer.PlayerLevel = 1;
        newPlayer.PlayerName = playerName;

        //newPlayer.MaxHitPoints =
        //newPlayer.CurrentHitPoints =
        //newPlayer.ArmorClass =

        newPlayer.Strength = newPlayer.PlayerClass.Strength;
        newPlayer.Intellegence = newPlayer.PlayerClass.Intellegence;
        newPlayer.Constitution = newPlayer.PlayerClass.Constitution;
        newPlayer.Wisdom = newPlayer.PlayerClass.Wisdom;
        newPlayer.Charisma = newPlayer.PlayerClass.Charisma;
        newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;

        newPlayer.CopperPiece = 0;
        newPlayer.SilverPiece = 0;
        newPlayer.GoldPiece = 0;
        newPlayer.PlatinumPiece = 0;

        newPlayer.CurrentXP = 0;
        newPlayer.RequiredXP = 1000;
    }
}

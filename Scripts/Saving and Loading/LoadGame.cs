/*****************************LoadGame*************************************
 *Programmer: Christine Jordan
 *Class: LoadGame    
 *Inheritance: NONE    
 *Date Created: 11/7/15
 *Date Modified: 11/7/15
 *Project: Project Avenon
 *Purpose:
 *ChangeLog: [11/7/15]
 ***************************************************************************/
using UnityEngine;
using System.Collections;

public class LoadGame
{
/***************************LoadAllInformation*******************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    public static void LoadAllInformation()
    {
        GameInfoManager.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameInfoManager.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInfoManager.Strength = PlayerPrefs.GetInt("STRENGTH");
        GameInfoManager.Constitution = PlayerPrefs.GetInt("CONSTITUITION");
        GameInfoManager.Dexterity = PlayerPrefs.GetInt("DEXTERITY");
        GameInfoManager.Intellegence = PlayerPrefs.GetInt("INTELLEGENCE");
        GameInfoManager.Wisdom = PlayerPrefs.GetInt("WISDOM");
        GameInfoManager.Charisma = PlayerPrefs.GetInt("CHARISMA");
        GameInfoManager.CopperPiece = PlayerPrefs.GetInt("COPPERPIECE");
        GameInfoManager.SilverPiece = PlayerPrefs.GetInt("SILVERPIECE");
        GameInfoManager.GoldPiece = PlayerPrefs.GetInt("GOLDPIECE");
        GameInfoManager.PlatinumPiece = PlayerPrefs.GetInt("PLATINUMPIECE");

        if (PlayerPrefs.GetString("HEAD") != null)
            GameInfoManager.Equipment1 = (BaseEquipable)PPSerialization.Load("HEAD");
    }
}

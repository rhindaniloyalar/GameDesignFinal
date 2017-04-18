/******************************SaveGame*************************************
 *Programmer: Christine Jordan
 *Class: SaveGame      
 *Inheritance: NONE    
 *Date Created: 11/7/15
 *Date Modified: 11/7/15
 *Project: Project Avenon
 *Purpose:
 *ChangeLog: [11/7/15]
 ***************************************************************************/
using UnityEngine;
using System.Collections;

public class SaveGame
{
/***************************SaveAllInformation*******************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInfoManager.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", GameInfoManager.PlayerName);
        PlayerPrefs.SetInt("STRENGTH", GameInfoManager.Strength);
        PlayerPrefs.SetInt("CONSTITUITION", GameInfoManager.Constitution);
        PlayerPrefs.SetInt("DEXTERITY", GameInfoManager.Dexterity);
        PlayerPrefs.SetInt("INTELLEGENCE", GameInfoManager.Intellegence);
        PlayerPrefs.SetInt("WISDOM", GameInfoManager.Wisdom);
        PlayerPrefs.SetInt("CHARISMA", GameInfoManager.Charisma);
        PlayerPrefs.SetInt("COPPERPIECE", GameInfoManager.CopperPiece);
        PlayerPrefs.SetInt("SILVERPIECE", GameInfoManager.SilverPiece);
        PlayerPrefs.SetInt("GOLDPIECE", GameInfoManager.GoldPiece);
        PlayerPrefs.SetInt("PLATINUMPIECE", GameInfoManager.PlatinumPiece);
        

        if (GameInfoManager.Equipment1 != null)
            PPSerialization.Save("HEAD", GameInfoManager.Equipment1);
    }
}

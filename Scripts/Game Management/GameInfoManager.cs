/************************GameInfoManager************************************
 *Programmer: Christine Jordan
 *Class: GameInformation
 *Inheritance: MonoBehavior
 *Date Created:  [11/4/15]
 *Date Modified: [12/10/15]
 *Project: Project Avenon
 *Purpose: Manages player data for saving/loading the game. Will implement
 *          serializeable instead of player prefs.
 *Changelog: [11/4/15] 
 *           [11/7/15] 
 ***************************************************************************/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameInfoManager : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static string PlayerName { get; set; }
    public static bool IsMale { get; set; }
    public static string PlayerBio { get; set; }
    public static BaseClass PlayerClass { get; set; }
    public static int PlayerLevel { get; set; }
    public static int CurrentXP { get; set; }
    public static int RequiredXP { get; set; }
    public static int PlayerMaxHealth { get; set; }
    public static int PlayerMaxEnergy { get; set; }
    public static int PlayerCurrentHealth { get; set; }
    public static int PlayerCurrentEnergy { get; set; }

    //Base Stats
    public static int MaxHitPoints { get; set; }
    public static int CurrentHitPoints { get; set; }
    public static int ArmorClass { get; set; }
    public static int Strength { get; set; }
    public static int Constitution { get; set; }
    public static int Dexterity { get; set; }
    public static int Intellegence { get; set; }
    public static int Wisdom { get; set; }
    public static int Charisma { get; set; }

    //Equipable
    public static BaseEquipable Equipment1 { get; set; } //Main Hand

    //Abilities
    //public static List<BaseAbility> playerAbilities;
    public static BaseAbility mainAbility = new BasicAttack();
    public static BaseAbility secondaryAbility = new SwordSlash();
    

    //Currency
    public static int CopperPiece { get; set; }
    public static int SilverPiece { get; set; }
    public static int GoldPiece { get; set; }
    public static int PlatinumPiece { get; set; }
}

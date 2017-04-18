/*******************************BasePlayer**********************************
 *Programmer: Christine Jordan
 *Class: BasePlayer
 *Inheritance: NONE
 *Date Created: 11/4/15
 *Date Modified: 11/8/15
 *Project: Project Avenon
 *Purpose:
 *ChangeLog: [11/4/15] Created script.
 *           [11/8/15] Added comment headers. Added hit point variables, 
 *           four forms of currency, armor class and xp variables.   
 ***************************************************************************/
public class BasePlayer
{
    private string playerName;      //name of the character
    private int playerLevel;        //current level of the player
    private BaseClass playerClass;  //class the payer chooses to play

    private int maxHitPoints;       //amount of damage player can take before game over
    private int currentHitPoints;   //amount of hit points player currently has
    private int strength;           //melee attack modifier
    private int constitution;       //health modifier
    private int dexterity;          //ranged attack & avoidance modifier 
    private int intellegence;       //spellcasting modifier for some arcane classes
    private int wisdom;             //spellcasting modifier for some divine classes
    private int charisma;           //spellcasting modifier for some divine & arcane casters
    private int armorClass;         //damage reduction

    //currency
    private int copperPiece;        //base currency
    private int silverPiece;        //low currency 10cp = 1sp
    private int goldPiece;          //mid currency 10sp = 1gp
    private int platinumPiece;      //highest currency 100gp = 1pp

    private int currentXP;          //Experience points the player owns
    private int requiredXP;         //Experience points the player needs to level up
    private int statPointsToAllocate;

/*****************************Getters&Setters*********************************
 * In:
 * Out:
 * Purpose: To set and retrieve game information for this class
 * **************************************************************************/
    public string PlayerName { get; set; }
    public int PlayerLevel { get; set; }
    public BaseClass PlayerClass { get; set; }

    public int MaxHitPoints { get; set; }
    public int CurrentHitPoints { get; set; }
    public int MaxEnergy { get; set; }
    public int CurrentEnergy { get; set; }
    public int ArmorClass { get; set; }
    public int Strength { get; set; }
    public int Constitution { get; set; }
    public int Dexterity { get; set; }
    public int Intellegence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    public int CopperPiece { get; set; }
    public int SilverPiece { get; set; }
    public int GoldPiece { get; set; }
    public int PlatinumPiece { get; set; }

    public int CurrentXP { get; set; }
    public int RequiredXP { get; set; }
    public int StatPointsToAllocate { get; set; }
    //End getters and setters
}

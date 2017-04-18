/*****************************BaseClass*************************************
 *Programmer: Christine Jordan
 *Class: BaseClass
 *Inheritance: NONE
 *Date Created: 11/4/15
 *Date Modified:11/7/15
 *Project: Project Avenon
 *Purpose: The base class for all character classes in the game.
 *Changelog: [11/3/15] Started with the 6 base stats, str,con,dex,int,wis,
 *           cha, characterClassName and characterClassDescription. Explicit
 *           getters and setters.
 *           [11/7/15] Changed getters and setters to {get; set;}. Changed
 *           to className and classDescription. Added skills, acrobatics,
 *           athletics, arcana, stealth, bluff, intimidate, and corresponding
 *           getters & setters.
 *           [12/13/15] Added enum data type for declaring main and secondary
 *           stat types.      
 ***************************************************************************/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 public class BaseClass
{
    public enum MainStats
    {
        STR,        //strength
        CON,        //constitution
        DEX,        //dexterity
        INT,        //intellegence
        WIS,        //wisdom
        CHA         //charisma
    }
    
    public struct Skill
    {
        bool isClassSkill;
        int skillScore;
        MainStats statAdded;
    }

    private string className;
    private string classDescription;
    public List<BaseAbility> playerAbilities = new List<BaseAbility>();

    //stats
    private int baseHitPoints;      //base hitpoints gained per level
    private int strength;           //melee attack modifier
    private int constitution;       //health modifier
    private int dexterity;          //ranged attack & avoidance modifier 
    private int intellegence;       //spellcasting modifier for some arcane classes
    private int wisdom;             //spellcasting modifier for some divine classes
    private int charisma;           //spellcasting modifier for some divine & arcane casters
    public MainStats mainStat;      //mainstat for the class (this is what is used for damage calculation)
    public MainStats secondaryStat; //secondary stat for the class (this is used for energy/mana calculation)
    
    //skills (not Implemented yet)
    //need a structure to both flag as class skill
    //&& hold numerical data.
    //linked lists of arrays of 2 maybe?
    //struct of bool/int/type???
    private int acrobatics;        //Dexterity based skill.
    private int appraise;          //Intelligence based skill
    private int athletics;         //not a part of pathfinder in general (Str based)
    private int bluff;             //Charisma based skill
    private int climb;             //Strength based skill
    private int craft;             //Intellegence based skill
    private int diplomacy;         //Charisma based skill
    private int disableDevice;     //Intelligence based skill
    private int disguise;          //Charisma based skill
    private int escapeArtist;      //Dexterity based skill
    private int fly;               //Dexterity based skill
    private int handleAnimal;      //Charisma based skill
    private int heal;              //Wisdom based skill
    private int intimidate;        //Charisma based skills
    private int linguistics;       //Intellegence based skill
    private int perception;        //Wisdom based skills
    private int perform;           //Charisma based skill
    private int profession;        //Wisdom based score
    private int ride;              //Dexterity based skills
    private int senseMotive;       //Wisdom based skill
    private int sleightOfHand;     //Dexterity based skill
    private int spellcraft;        //Intelligence based skill
    private int stealth;           //Dexterity based skill
    private int survival;          //Wisdom based skill
    private int swim;              //Strength based skill
    private int useMagicDevice;    //Charisma based skill

    //knowledge skills    
    //all knowledge skills are Intellegence based  
    private int knowledgeArcana;
    private int knowledgeDungeoneering;
    private int knowledgeEngineering;
    private int knowledgeGeography;
    private int knowledgeHistory;
    private int knowledgeLocal;
    private int knowledgeNobility;
    private int knowledgePlanes;
    private int knowledgeReligion;

   /***************************Getters&Setters**********************************
    * In:
    * Out:
    * Purpose: 
    * **************************************************************************/
    public string ClassName
    {
        get { return className; }
        set { className = value; }
    }
    public string ClassDescription
    {
        get { return classDescription; }
        set { classDescription = value; }
    }
    public int BaseHitPoints
    {
        get { return baseHitPoints; }
        set { baseHitPoints = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Constitution
    {
        get { return constitution; }
        set { constitution = value; }
    }
    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }
    public int Intellegence
    {
        get { return intellegence; }
        set { intellegence = value; }
    }
    public int Wisdom
    {
        get { return wisdom; }
        set { wisdom = value; }
    }
    public int Charisma
    {
        get { return charisma; }
        set { charisma = value; }
    }
    public MainStats MainStat
    {
        get { return mainStat; }
        set { mainStat = value; }
    }
    public MainStats SecondaryStat
    {
        get { return secondaryStat; }
        set { secondaryStat = value; }
    }
    //public MainStats MainStat {get { return mainStat; }}

    public int Acrobatics { get; set; }
    public int Appraise { get; set; }
    public int Athletics { get; set; }
    public int Bluff { get; set; }
    public int Intimidate { get; set; }
    public int Stealth { get; set; }

    public int KnowledgeArcana { get; set; }

    //End Getters&Setters

    /**************************ToString******************************************
    * In:
    * Out:
    * Purpose: converts the object to a string for output
    * **************************************************************************/
    public override string ToString()
    {
        return string.Format("Strength: " + Strength + "\n" +
                             "Constitution: " + Constitution + "\n" +
                             "Dexterity: " + Dexterity + "\n" +
                             "Intellegence: " + Intellegence + "\n" +
                             "Wisdom: " + Wisdom + "\n" +
                             "Charisma: " + Charisma + "\n");
    }
}

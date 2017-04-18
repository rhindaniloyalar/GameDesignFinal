/*****************************WizardClass***************************************
 *Programmer: Christine Jordan                                                 *
 *Class: WizardCLass
 *Inheritance: BaseClass
 *Date Created: 11/4/15
 *Date Modified:11/4/15
 *Project: Project Avenon
 *Purpose: Wizard Class for Spellcasting classes in the game.
 *Changelog: [11/4/15] Added class constructor WizardClass()
 *******************************************************************************/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class WizardClass : BaseClass   
{
/******************************WizardClass***********************************
 * In:
 * Out:
 * Purpose: constructor for WizardClass
 * **************************************************************************/
    public WizardClass()
    {
        ClassName = "Wizard";
        ClassDescription = "Spellcaster Class-Favors Intellegence and Constitution";
        Strength = 9;
        Constitution = 15;
        Dexterity = 14;
        Wisdom = 13;
        Intellegence = 15;
        Charisma = 12;
        mainStat = MainStats.INT;
        secondaryStat = MainStats.CON;
        playerAbilities.Add(new BasicAttack());
        playerAbilities.Add(new FireBall());
    }
}

/*****************************FighterClass**************************************
 *Programmer: Christine Jordan                                                 *
 *Class: FighterClass
 *Inheritance: BaseClass
 *Date Created: 11/4/15
 *Date Modified:11/4/15
 *Project: Project Avenon
 *Purpose: Fighter Class for melee character classes in the game.
 *Changelog: [11/4/15] Added class constructor FighterClass()
 *******************************************************************************/
public class FighterClass : BaseClass  
{
/******************************FighterClass**********************************
 * In:
 * Out:
 * Purpose: constructor for FighterClass
 * **************************************************************************/
    public FighterClass()
    {
        ClassName = "Fighter";
        ClassDescription = "Melee class-Favors Strength and Constitution";
        Strength = 15;
        Constitution = 15;
        Dexterity = 14;
        Wisdom = 13;
        Intellegence = 9;
        Charisma = 12;
        MainStat = MainStats.STR;
        SecondaryStat = MainStats.CON;
        playerAbilities.Add(new BasicAttack());
        playerAbilities.Add(new SwordSlash());
    }
}

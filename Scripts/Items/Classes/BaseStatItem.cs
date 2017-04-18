/*****************************BaseStatItem********************************
 *Programmer: Christine Jordan
 *Class: BaseStatItem
 *Inheritance: BaseItem
 *Date Created: 11/4/15
 *Date Modified: 11/7/15
 *Project: Project Avenon
 *Purpose:
 *ChangeLog [11/4/15]
 *          [11/7/15]
 ***************************************************************************/
 [System.Serializable]
public class BaseStatItem : BaseItem {

    private int strength;
    private int constitution;
    private int dexterity;
    private int intellegence;
    private int wisdom;
    private int charisma;

/*****************************Getters&Setters********************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    public int Strength { get; set; }
    public int Constitution { get; set; }
    public int Dexterity { get; set; }
    public int Intellegence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    //End getters and setters
}

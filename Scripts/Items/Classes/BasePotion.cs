/*****************************BasePotion**********************************
 *Programmer: Christine Jordan
 *Class: BasePotion
 *Inheritance: BaseItem -> BaseStatItem
 *Date Created: [11/4/15]
 *Date Modified: [11/8/15]
 *Project:
 *Purpose:
 *Changelog: [11/4/15] Created script.
 *           [11/8/15] Added comment headers.
 ***************************************************************************/

public class BasePotion : BaseStatItem
{
    public enum PotionTypes
    {
        HEALTH,
        ENERGY,
        STRENGTH,
        INTELLEGENCE,
    }

    private PotionTypes potionType;
    private int spellEffectID;
/*************************Getters&Setters************************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    public PotionTypes PotionType { get; set; }
    public int SpellEffectID { get; set; }
//End Getters&Setters
}

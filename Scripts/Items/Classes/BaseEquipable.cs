/****************************BaseEquipment********************************
 *Programmer: Christine Jordan
 *Class: BaseEquipment
 *Inheritance: BaseItem -> BaseStatItem
 *Date Created: [11/4/15]
 *Date Modified: [11/8/15]
 *Project: Project Avenon
 *Purpose: 
 *Changelog: [11/4/15] Created script.
 *           [11/8/15] Added comment headers.
 ***************************************************************************/
 [System.Serializable]
public class BaseEquipable : BaseStatItem
    // BaseItem -> BaseStatItem -> BaseEquipment
{
	public enum EquipmentTypes
    {
        HEAD,
        CHEST,
        SHOULDERS,
        LEGS,
        FEET,
        EARRING,
        RING,
        NECK
    }

    private EquipmentTypes equipmentType;
    private int spellEffectID;
    private int armorValue;

/****************************Getters&Setters*********************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    public EquipmentTypes EquipmentType { get; set; }
    public int SpellEffectID { get; set; }
    public int ArmorValue { get; set; }
    //End Getters & Setters
}

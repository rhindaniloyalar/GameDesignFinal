/*****************************BaseWeapon**********************************
 *Programmer: Christine Jordan
 *Class: BaseWeapon 
 *Inherits from: <- BaseStatItem <-BaseItem
 *Date Created: 11/4/15
 *Date Modified: 11/8/15
 *Project: Project Avenon
 *Purpose:
 *Changelog: [11/4/15] Created script.
 *           [11/8/15] Added comment sections.
 ***************************************************************************/
 [System.Serializable]
 public class BaseWeapon : BaseStatItem  
    // BaseWeapon <- BaseStatItem <- BaseItem
{
	public enum WeaponTypes
    {
        SWORD,
        STAFF,
        DAGGER,
        BOW,
        SHIELD,
        POLEARM,
        AXE
    }

    private WeaponTypes weaponType;
    private int spellEffectID;
    private int damageValue;

 /*****************************Getters&Setters*******************************
 * In:
 * Out:
 * Purpose: Set and retrieve the weapon's private data.
 * **************************************************************************/
    public WeaponTypes WeaponType { get; set; }
    public int SpellEffectID { get; set; }
    public int DamageValue { get; set; }
    //End Getters and Setters
}

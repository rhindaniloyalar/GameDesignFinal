/*****************************CreateNewWeapon********************************
 *Programmer: Christine Jordan
 *Class: CreateNewWeapon
 *Inheritance: MonoBehaviour
 *Date Created: 11/3/15
 *Date Modified: 12/8/15
 *Project: Project Avenon
 *Purpose: Creating new weapons from chests or mob drops
 *ChangeLog:
 ***************************************************************************/
using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

    private BaseWeapon newWeapon;
    //2d Array for name && type????
    private string[] weaponNames = new string[12];

    void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.WeaponType.ToString());
    }

/*****************************CreateWeapon***********************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();

        //asign weapon name
        newWeapon.ItemName = "W" + Random.Range(1, 101);
        //create a description
        newWeapon.ItemDescription = "This is a weapon";
        //weapon id
        newWeapon.ItemID = Random.Range(1, 101);
        //stats
        newWeapon.Strength = Random.Range(1, 6);
        newWeapon.Constitution = Random.Range(1, 6);
        newWeapon.Dexterity = Random.Range(1, 6);
        newWeapon.Intellegence = Random.Range(1, 6);
        newWeapon.Wisdom = Random.Range(1, 6);
        newWeapon.Charisma = Random.Range(1, 6);
        //choose type of weapon
        ChooseWeaponType();
        //Damage
        newWeapon.DamageValue = Random.Range(1, 12);
        //spell effect ID
    }
/*****************************ChooseWeaponType*******************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    private void ChooseWeaponType()
    {
        //these 2 lines of code do what the 13 below do
        System.Array weapons =
            System.Enum.GetValues(typeof(BaseWeapon.WeaponTypes));
        newWeapon.WeaponType =
            (BaseWeapon.WeaponTypes)weapons.GetValue(Random.Range(0, weapons.Length));
        
        /*
        int random = Random.Range(1, 7);

        if (random == 1)
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
        if (random == 2)
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
        if (random == 3)
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
        if (random == 4)
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.POLEARM;
        if (random == 5)
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
        if (random == 6)
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
        */
    }   
}

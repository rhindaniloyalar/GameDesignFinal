/****************************CreateNewEquipment***************************
 *Programmer: Christine Jordan
 *Class: CreateNewEquipment
 *Inheritance: MonoBehaviour
 *Date Created: 11/4/15
 *Date Modified: 11/8/15
 *Project: Project Avenon
 *Purpose: 
 *Changelog: [11/4/15] Created script.
 *           [11/8/15] Added comment headers.
 ***************************************************************************/
using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {

    BaseEquipable newEquipment;
    private string[] itemNames = new string[] {"Common", "Good", "Great",
        "Legendary" };

    void Start()
    {
        CreateEquipment();
        Debug.Log(newEquipment.ItemName);
        Debug.Log(newEquipment.EquipmentType.ToString());
    }

/*****************************CreateEquipment********************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    private void CreateEquipment()
    {
        newEquipment = new BaseEquipable();
        newEquipment.ItemName = itemNames[Random.Range(0, 4)];
        newEquipment.ItemID = Random.Range(1, 101);
        ChooseItemType();
        newEquipment.Strength = Random.Range(1, 6);
        newEquipment.Constitution = Random.Range(1, 6);
        newEquipment.Dexterity = Random.Range(1, 6);
        newEquipment.Intellegence = Random.Range(1, 6);
        newEquipment.Wisdom = Random.Range(1, 6);
        newEquipment.Charisma = Random.Range(1, 6);
    }

/*****************************ChooseItemType*********************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    private void ChooseItemType()
    {
        int random = Random.Range(1, 9);

        if (random == 1)
            newEquipment.EquipmentType = BaseEquipable.EquipmentTypes.HEAD;
        if (random == 2)
            newEquipment.EquipmentType = BaseEquipable.EquipmentTypes.CHEST;
        if (random == 3)
            newEquipment.EquipmentType = BaseEquipable.EquipmentTypes.EARRING;
        if (random == 4)
            newEquipment.EquipmentType = BaseEquipable.EquipmentTypes.FEET;
        if (random == 5)
            newEquipment.EquipmentType = BaseEquipable.EquipmentTypes.LEGS;
        if (random == 6)
            newEquipment.EquipmentType = BaseEquipable.EquipmentTypes.NECK;
        if (random == 7)
            newEquipment.EquipmentType = BaseEquipable.EquipmentTypes.RING;
        if (random == 8)
            newEquipment.EquipmentType = BaseEquipable.EquipmentTypes.SHOULDERS;
      
    }
}


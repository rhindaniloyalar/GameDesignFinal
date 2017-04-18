/*****************************FileHeader**********************************
 *Programmer: Christine Jordan
 *Class: StatAllocationModule
 *Inheritance: None
 *Date Created: [12/6/15]
 *Date Modified: [12/7/15]
 *Project: Project Avenon
 *Purpose: Allocate Stat points for character creation and level up.
 *Changelog:
 *************************************************************************/
using System.Collections;
using UnityEngine;

public class StatAllocationModule
{
    private string[] statNames = new string[6] { "Strength: ", "Constitution: ", "Dexterity: ",
        "Intellect: ", "Wisdom: ", "Charisma: " };
    private string[] statDescriptions = new string[6] { "Physical Damage Modifier",
        "Health Modifier", "Ranged Damage Modifier", "Spell Modifier for Wizards",
        "Spell Modifier for Clerics/Druids", "Spell Modifier for Bards/Sorcerers" };

    //private bool[] statSelections = new bool[6];
    public int[] pointsToAllocate = new int[6]; //starting stat values + allocation points
    private int[] baseStatPoints = new int[6];  //starting stat values

    private int availPoints = 5;
    public bool didRunOnce = false;

    /*****************************MethodName*************************************
    * In:
    * Out:
    * Purpose: 
    * **************************************************************************/
    public void DisplayAllocationModule()
    {
        if (!didRunOnce)
        {
            RetrieveBaseStatPoints();
            didRunOnce = true;
        }
        DisplayStatToggleSwitches();
        DisplayStatAlterationButtons();
    }

    /*****************************MethodName*************************************
    * In:
    * Out:
    * Purpose: 
    * **************************************************************************/
    private void DisplayStatToggleSwitches()
    {
        for (int i = 0; i < statNames.Length; ++i)
        {
            GUI.Label(new Rect(10, 60 * i + 10, 150, 50), statNames[i]);
            GUI.Label(new Rect(100, 60 * i + 10, 100, 50), pointsToAllocate[i].ToString());
            GUI.Label(new Rect(10, 60 * i + 30, 150, 50), statDescriptions[i]);
        }
    }

    /**************************DisplayStatDescriptions***************************
    * In:
    * Out:
    * Purpose: This function is currently not needed.
    * **************************************************************************/
    private void DisplayStatDescriptions(bool[] stat)
    {
        if (stat[0])
        {
            GUI.Label(new Rect(0, 0, 0, 0), statDescriptions[0]);
        }
        else if (stat[1])
        {
            GUI.Label(new Rect(0, 0, 0, 0), statDescriptions[1]);
        }
        else if (stat[2])
        {
            GUI.Label(new Rect(0, 0, 0, 0), statDescriptions[2]);
        }
        else if (stat[3])
        {
            GUI.Label(new Rect(0, 0, 0, 0), statDescriptions[3]);
        }
        else if (stat[4])
        {
            GUI.Label(new Rect(0, 0, 0, 0), statDescriptions[4]);
        }
        else if (stat[5])
        {
            GUI.Label(new Rect(0, 0, 0, 0), statDescriptions[5]);
        }
    }

    /*********************DisplayStatAlterationButtons**************************
    * In:
    * Out:
    * Purpose: holds the logic for increasing/decreasing stat points
    *          cannot go below the base stats. 
    * **************************************************************************/
    private void DisplayStatAlterationButtons()
    {
        for (int i = 0; i < pointsToAllocate.Length; i++)
        {
            //if we still have points to spend display increment button
            if (pointsToAllocate[i] >= baseStatPoints[i] &&
                availPoints > 0)
            {
                if (GUI.Button(new Rect(200, 60 * i + 10, 50, 50), "+"))
                {
                    ++pointsToAllocate[i];
                    --availPoints;
                }
            }
            //if we can still decriment points display decriment button
            if (pointsToAllocate[i] > baseStatPoints[i])
            {
                if (GUI.Button(new Rect(260, 60 * i + 10, 50, 50), "-"))
                {
                    --pointsToAllocate[i];
                    ++availPoints;
                }
            }
        }
    }

    /**********************RetrieveBaseStatPoints********************************
    * In:
    * Out:
    * Purpose: 
    * **************************************************************************/
    private void RetrieveBaseStatPoints()
    {
        if (GameInfoManager.PlayerClass != null)
        {
            BaseClass tempClass = GameInfoManager.PlayerClass;

            pointsToAllocate[0] = tempClass.Strength;
            baseStatPoints[0] = tempClass.Strength;

            pointsToAllocate[1] = tempClass.Constitution;
            baseStatPoints[1] = tempClass.Constitution;

            pointsToAllocate[2] = tempClass.Dexterity;
            baseStatPoints[2] = tempClass.Dexterity;

            pointsToAllocate[3] = tempClass.Intellegence;
            baseStatPoints[3] = tempClass.Intellegence;

            pointsToAllocate[4] = tempClass.Wisdom;
            baseStatPoints[4] = tempClass.Wisdom;

            pointsToAllocate[5] = tempClass.Charisma;
            baseStatPoints[5] = tempClass.Charisma;
        }
    }
}
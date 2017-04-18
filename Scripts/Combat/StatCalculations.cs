//TODO add comment and function headers
using UnityEngine;
using System.Collections;

public class StatCalculations
{
    private float strMod = 0.15f;
    private float conMod = 0.15f;
    private float dexMod = 0.15f;
    private float intMod = 0.1f;
    private float wisMod = 0.1f;
    private float chaMod = 0.1f;
    private int acMod = 2;

    public enum StatTypes
    {
        STRENGTH,
        CONSTITUTION,
        DEXTERITY,
        INTELLIGENCE,
        WISDOM,
        CHARISMA,
        ARMOR_CLASS
    }
    public int CalculateStat(int statVal, StatTypes statType, int lvl)
    {
        //float modifier;

        if (statType == StatTypes.STRENGTH)
        {
            //modifier = strMod;
            return (statVal + (int)(statVal * strMod * lvl));
        }
        else if (statType == StatTypes.CONSTITUTION)
        {
            //modifier = conMod;
            return (statVal + (int)(statVal * conMod * lvl));
        }
        else if (statType == StatTypes.DEXTERITY)
        {
            //modifier = dexMod;
            return (statVal + (int)(statVal * dexMod * lvl));
        }
        else if (statType == StatTypes.INTELLIGENCE)
        {
            //modifier = intMod;
            return (statVal + (int)(statVal * intMod * lvl));
        }
        else if (statType == StatTypes.WISDOM)
        {
            //modifier = wisMod;
            return (statVal + (int)(statVal * wisMod * lvl));
        }
        else if (statType == StatTypes.CHARISMA)
        {
            //modifier = chaMod;
            return (statVal + (int)(statVal * chaMod * lvl));
        }
        else if (statType == StatTypes.ARMOR_CLASS)
        {
            //modifier = acMod;
            return (statVal + (int)(statVal + acMod * lvl));
        }
        else
            return 0;        
    }
    public int CalculateHealth(int statValue)
    {
        return (statValue * 3);
    }
    public int CalculateEnergy(int statValue)
    {
        return(statValue * 4);
    }
}

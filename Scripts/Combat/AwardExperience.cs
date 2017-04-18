/****************************AwardExperience************************************
 *Programmer: Christine Jordan                                                 *
 *Class: LevelUp
 *Inheritance: NONE
 *Date Created: 11/7/15
 *Date Modified:11/7/15
 *Project: Project Avenon
 *Purpose: Class to calculate and maintain experience points and determines when
 *         it is time to level up. Made static so it can be acessed from 
 *         anywhere in the game
 *Changelog: [11/7/15] Added LevelUpCharacter(), checked against 
 *           CurrentXP>RequiredXP & PlayerLevel to MAX_LEVEL. Function to 
 *           determine next level's xp. 
 *******************************************************************************/
public static class AwardExperience
{
    private static int xpAlloted;
    private static LevelUp levelUp = new LevelUp();
    /******************************AddExperience*********************************
     * In:
     * Out:
     * Purpose: Adds experience points for challenges the player encounters.
     * **************************************************************************/
    public static void AddExperience()
    {
        xpAlloted = GameInfoManager.PlayerLevel * 100;
        GameInfoManager.CurrentXP += xpAlloted;
    }

    //public static void AddExplorationExperience()
    //{
    //exploration xp???
    //work in progress
    //}

    //public static void LoseExperience()
    //{
    //lose xp from losing a fight
    //making wrong decision?
    //not to reduce level
    //}


    /**************************CheckLevelUp*************************************
    * In:
    * Out:
    * Purpose: Checks to see if the player leveled up after awarding XP
    * **************************************************************************/
    private static void CheckLevelUp()
    {
        if (GameInfoManager.CurrentXP >= GameInfoManager.RequiredXP)
        {
            //level up
            levelUp.LevelUpCharacter();            
        }
    }

    //private static void CheckLevelDown()
    //{   
    //if lose level from lost fight??
    //}    
}

/*****************************LevelUp*******************************************
 *Programmer: Christine Jordan                                                 *
 *Class: LevelUp
 *Inheritance: NONE
 *Date Created: 11/7/15
 *Date Modified:11/7/15
 *Project: Project Avenon
 *Purpose: Class to maintain the player level and calculate xp needed to advance
           to the next level.
 *Changelog: [11/7/15] Added LevelUpCharacter(), checked against 
             CurrentXP>RequiredXP & PlayerLevel to MAX_LEVEL. Function to 
             determine next level's xp. 
 *******************************************************************************/
public class LevelUp
{
    public const int MAX_PLAYER_LEVEL = 50;

/**************************LevelUpCharacter**********************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    public void LevelUpCharacter()
    {
        //check if current xp > required xp
        if (GameInfoManager.CurrentXP > GameInfoManager.RequiredXP)
            GameInfoManager.CurrentXP -= GameInfoManager.RequiredXP;        
        else
            GameInfoManager.CurrentXP = 0;        
        if (GameInfoManager.PlayerLevel < MAX_PLAYER_LEVEL)
            GameInfoManager.PlayerLevel += 1;        
        else
            GameInfoManager.PlayerLevel = MAX_PLAYER_LEVEL;
        
        //allocate stat points
        //skill points
        //movement speed increases
        //feats granted
        //award achievments
        //determine next lvl's xp
        DetermineRequiredXP();
    }

/***************************DetermineRequiredXP******************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    private void DetermineRequiredXP()
    {
        int temp = (GameInfoManager.PlayerLevel * 1000); //fix this maybe?
        GameInfoManager.RequiredXP = temp;
    }

    //video 20 3:30 next level algorithm
    //private int XPForNextLevel(int PlayerLevel)
    //{
    //  playerLevel += 1;
    //  int levels = 50;
    //  float xpLevel1 = 500f;
    //  float xpLevel50 = 400000f;
    //  float temp1 = Mathf.log(xpLevel50/xpLevel);
    //  float b = temp1/(levels-1);
    //  float temp2 = (Mathf.Exp(b) - 1);
    //  float a = (xpLevel1)/temp2;
    //  int oldxp = (int) (a*Mathf.Exp((float)b*(playerLevel-1)));
    //  int newxp = (int) (a * Mathf.Exp((float)(b*playerLevel);
    //  int temp = newxp - oldxp;
    //  temp = (int)Math.Round((float) temp/10f)*10;
    //  return temp;
    //}
}

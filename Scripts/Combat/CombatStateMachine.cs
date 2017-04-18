/***********************CombatStateMachine**********************************
 *Programmer: Christine Jordan
 *Class: CombatStateMachine
 *Date Created: 11/4/15
 *Date Modified:11/7/15
 *Project: Project Avenon
 *Purpose: Controls and manages the state for the game's turnbased combat 
 *         system.
 *Changelog: [11/4/15] Created script.
 *           [11/7/15] Added comment headers.
 ***************************************************************************/
using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour {
    private bool hasAddedXP = false;
    private BattleStateStart battleStateStart = new BattleStateStart();
    private BattleStateCalulateDamage battleCalcScript = new BattleStateCalulateDamage();
    private BattleStateEnemyChoice enemyChoiceScript = new BattleStateEnemyChoice();
    public static BaseAbility playerUsedAbility;
    public static BaseAbility enemyUsedAbility = new BasicAttack();
    public static int turnCount;
    //public static bool playerDidCompleteTurn;
    //public static bool enemyDidCompleteTurn;
    public int totalTurnCount;
    public static bool isPlayerTurn;
    public static BattleStates currentTurn;  //marks whose turn it is
    /***************************enumBattleStates*********************************
    * In:
    * Out:
    * Purpose: 
    * **************************************************************************/
    public enum BattleStates
    {
        START,
        END_TURN,
        PLAYER_CHOICE,
        CALCULATE_DAMAGE,
        ADD_STATUS_EFFECT,      
        ENEMY_CHOICE,
        LOSE,
        WIN,
        RAN_AWAY
    }

    public static BattleStates currentState;
/********************************Start***************************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
   
    void Start ()
    {
        currentState = BattleStates.START;
        hasAddedXP = false;
	}
/*******************************Update***************************************
 * In:
 * Out:
 * Purpose: Maintains the combat states for turn based combat
 * **************************************************************************/
    
    void Update ()
    {
        Debug.Log(currentState);
        switch (currentState)
        {
            case (BattleStates.START):               
                battleStateStart.PrepareBattle();
                totalTurnCount = 0;                
                break;
            case (BattleStates.PLAYER_CHOICE):
                currentTurn = BattleStates.PLAYER_CHOICE;
                break;
            case (BattleStates.ENEMY_CHOICE):
                currentTurn = BattleStates.ENEMY_CHOICE;
                currentState = BattleStates.CALCULATE_DAMAGE;
                //enemyChoiceScript.EnemyCompleteTurn();
                break;
            case (BattleStates.CALCULATE_DAMAGE):
                if (currentTurn == BattleStates.PLAYER_CHOICE)
                    battleCalcScript.CalculatePlayerAbilityDamage(playerUsedAbility);
                if (currentTurn == BattleStates.ENEMY_CHOICE)
                    battleCalcScript.CalculateEnemyAbilityDamage(enemyUsedAbility);
                break;
            case (BattleStates.ADD_STATUS_EFFECT):
                //if status effect exists add it here
                break;
            case (BattleStates.END_TURN):
                //playerDidCompleteTurn = false;
                //enemyDidCompleteTurn = false;
                ++totalTurnCount;
                Debug.Log(totalTurnCount);
                Debug.Break();
                if(CheckWinCondition())
                {
                    currentState = BattleStates.WIN;
                }
                else if (CheckLoseCondition())
                {
                    currentState = BattleStates.LOSE;
                }
                else
                {
                    if (currentTurn == BattleStates.PLAYER_CHOICE)
                    {
                        currentState = BattleStates.ENEMY_CHOICE;
                    }
                    else
                    {
                        currentState = BattleStates.PLAYER_CHOICE;
                    }
                }
                break;
            case (BattleStates.WIN):
                if (!hasAddedXP)
                {
                    //AwardExperience.AddExperience();
                    //go back to exploration scene
                }
                Application.LoadLevel("Wasteland");
                break;
            case (BattleStates.LOSE):
                //not sure what happens here yet
                //game over for now. player goes back
                //to start screen
                Application.LoadLevel("IntroScreen");
                break;
            case (BattleStates.RAN_AWAY):
                Application.LoadLevel("Wasteland");
                break;
        }
	}

    private bool CheckWinCondition()
    {
        if (BattleStateStart.newEnemy.CurrentHitPoints <= 0)
            return true;
        else 
            return false;
    }

    private bool CheckLoseCondition()
    {
        if (GameInfoManager.CurrentHitPoints <= 0)
            return true;
        else
            return false;
    }
    /*******************************OnGUI****************************************
     * In:
     * Out:
     * Purpose: 
     * **************************************************************************/
    void OnGUI()
    {
        if (GUILayout.Button("Next State"))
        {
            if (currentState == BattleStates.START)
                currentState = BattleStates.PLAYER_CHOICE;
            if (currentState == BattleStates.ENEMY_CHOICE)
                currentState = BattleStates.PLAYER_CHOICE;
        }
    }
}

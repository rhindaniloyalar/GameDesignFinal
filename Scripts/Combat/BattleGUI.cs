using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BattleGUI : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnGUI()
    {
        if(CombatStateMachine.currentState == 
            CombatStateMachine.BattleStates.PLAYER_CHOICE)
        {
            DisplayPlayerChoices();
        }

        GUI.Label(new Rect(Screen.width - 400, Screen.height - 50, 90, 50),
            "Player Health: " + GameInfoManager.CurrentHitPoints.ToString());
        GUI.Label(new Rect(Screen.width - 500, Screen.height - 50, 90, 50),
            "Enemy Health: " + BattleStateStart.newEnemy.CurrentHitPoints.ToString());

        //enemy health
        //player health
        //enemy data
        //player information
    }

    private void DisplayPlayerChoices()
    {
        //buttons for players moves
        if (GUI.Button(new Rect(Screen.width - 300, Screen.height - 50, 90, 30),
            GameInfoManager.mainAbility.AbilityName))
        {
            CombatStateMachine.playerUsedAbility = GameInfoManager.mainAbility;
            CombatStateMachine.currentState = 
                CombatStateMachine.BattleStates.CALCULATE_DAMAGE;
        }
        if (GUI.Button(new Rect(Screen.width - 200, Screen.height - 50, 90, 30),
            GameInfoManager.secondaryAbility.AbilityName))
        {
            CombatStateMachine.playerUsedAbility = GameInfoManager.secondaryAbility;
            CombatStateMachine.currentState =
                CombatStateMachine.BattleStates.CALCULATE_DAMAGE;
        }
        if (GUI.Button(new Rect(Screen.width - 100, Screen.height - 50, 90, 30),
            "Run"))
        {
            if(Random.Range(0,26) < 25)
            {
                CombatStateMachine.currentState =
                 CombatStateMachine.BattleStates.RAN_AWAY;
            }
            else
                CombatStateMachine.currentState =
                 CombatStateMachine.BattleStates.ENEMY_CHOICE;
        }
    }   
}

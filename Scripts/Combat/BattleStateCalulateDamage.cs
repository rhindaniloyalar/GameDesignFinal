//TODO headers
using UnityEngine;
using System.Collections;

public class BattleStateCalulateDamage
{
    private StatCalculations statCalcScript = new StatCalculations();
    private int totalUsedAbilityDamage;
    private BattleStateStart startScript = new BattleStateStart();

    public void CalculatePlayerAbilityDamage(BaseAbility usedAbility)
    {
        Debug.Log("Used Ability: " + usedAbility.AbilityName);
        Debug.Log(usedAbility.AbilityPower);
        //Debug.Break();
        totalUsedAbilityDamage = usedAbility.AbilityPower + CalculateDamage();
        Debug.Log(totalUsedAbilityDamage);
        //CombatStateMachine.playerDidCompleteTurn = true;
        BattleStateStart.newEnemy.CurrentHitPoints -= totalUsedAbilityDamage;
        CombatStateMachine.currentState = CombatStateMachine.BattleStates.END_TURN;           
    }

    public void CalculateEnemyAbilityDamage(BaseAbility usedAbility)
    {
        Debug.Log("Used Ability: " + usedAbility.AbilityName);
        Debug.Log(usedAbility.AbilityPower);
        totalUsedAbilityDamage = usedAbility.AbilityPower + 15;
        Debug.Log(totalUsedAbilityDamage);
        //CombatStateMachine.enemyDidCompleteTurn = true;
        GameInfoManager.CurrentHitPoints -= totalUsedAbilityDamage;
        CombatStateMachine.currentState = CombatStateMachine.BattleStates.END_TURN;
    }

    private int CalculateDamage()
    {
        if (GameInfoManager.PlayerClass.ClassName == "Fighter")
        {
            //Debug.Log(GameInfoManager.Strength);
            return GameInfoManager.Strength;
        }
        else if (GameInfoManager.PlayerClass.ClassName == "Wizard")
        {
            return GameInfoManager.Intellegence;
        }
        else
            return 0;
    }	

    private void ChangeStates()
    {
        if (CombatStateMachine.isPlayerTurn)
        {
            CombatStateMachine.currentState = 
                CombatStateMachine.BattleStates.ENEMY_CHOICE;
        }
        else if (!CombatStateMachine.isPlayerTurn)
        {
            CombatStateMachine.currentState = 
                CombatStateMachine.BattleStates.PLAYER_CHOICE;
        }

        ++CombatStateMachine.turnCount;

        if (CombatStateMachine.turnCount % 2 == 0)
        {
            //end turn
        }

    }
}
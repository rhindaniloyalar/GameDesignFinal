using UnityEngine;
using System.Collections;

public class BattleStateEnemyChoice
{
    public BaseAbility enemyAttack;
    private int totalPlayerHealth;
    private int playerHealthPercentage;
    

    public void EnemyCompleteTurn()
    {
        CombatStateMachine.enemyUsedAbility = ChooseEnemyAbility();
        CombatStateMachine.currentState = CombatStateMachine.BattleStates.CALCULATE_DAMAGE;     
    }
   //needs a new script eventually
    public BaseAbility ChooseEnemyAbility()
    {
        totalPlayerHealth = GameInfoManager.PlayerCurrentHealth;
        playerHealthPercentage = (totalPlayerHealth / 100) * 100;

        if (playerHealthPercentage >= 75)
        {
            enemyAttack = new SwordSlash();
            return enemyAttack; 
        }
        else if (playerHealthPercentage < 75 && playerHealthPercentage >= 50)
        {
            enemyAttack = new BasicAttack();
            return enemyAttack;
        }
        else if (playerHealthPercentage < 50)
        {
            enemyAttack = new BasicAttack();
            return enemyAttack;
        }

        enemyAttack = new BasicAttack();
        return enemyAttack;
    }    
}

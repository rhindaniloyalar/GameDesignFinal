/******************************BattleStateStart********************************
 *Programmer: Christine Jordan
 *Class: GameInformation
 *Inheritance: MonoBehavior
 *Date Created:  [12/9/15]
 *Date Modified: [12/9/15]
 *Project: Project Avenon
 *Purpose: Sets up the turn based battle system when battle starts
 *Changelog: 
 ***************************************************************************/
using UnityEngine;
using System.Collections;

public class BattleStateStart
{
    public static BasePlayer newEnemy = new BasePlayer(); //need an enemy array for more than 1 in a battle
    private StatCalculations statCalculations = new StatCalculations();
    private BaseClass[] classTypes = new BaseClass[] { new FighterClass(), new WizardClass() };
    private string[] enemyNames = new string[] { "Goblin Warrior" };
    private bool isEnemy;  //not in use yet
    private int playerHealth;
    private int playerEnergy;  //add intel for wizard

    public void PrepareBattle()
    {
        //create enemy
        CreateNewEnemy();
        //find player vitals
        DeterminePlayerVitals();
        //compare dex stats for who goes first
        ChooseWhoGoesFirst();
    }

    private void CreateNewEnemy()
    {
        newEnemy.PlayerName = enemyNames[0];

        newEnemy.PlayerLevel = Random.Range(GameInfoManager.PlayerLevel - 2, 
            GameInfoManager.PlayerLevel + 2);
        newEnemy.PlayerClass = new FighterClass();

        newEnemy.Strength = statCalculations.CalculateStat(newEnemy.Strength, 
            StatCalculations.StatTypes.STRENGTH, newEnemy.PlayerLevel);

        newEnemy.Strength = statCalculations.CalculateStat(newEnemy.Dexterity, 
            StatCalculations.StatTypes.DEXTERITY, newEnemy.PlayerLevel);

        newEnemy.Strength = statCalculations.CalculateStat(newEnemy.Intellegence, 
            StatCalculations.StatTypes.INTELLIGENCE, newEnemy.PlayerLevel);

        newEnemy.Strength = statCalculations.CalculateStat(newEnemy.Wisdom, 
            StatCalculations.StatTypes.WISDOM, newEnemy.PlayerLevel);

        newEnemy.Strength = statCalculations.CalculateStat(newEnemy.Charisma, 
            StatCalculations.StatTypes.CHARISMA, newEnemy.PlayerLevel);

        newEnemy.CurrentHitPoints = 100;
        Debug.Log(newEnemy.CurrentHitPoints);
        Debug.Break();

            //newEnemy.MaxHitPoints = 100;

        newEnemy.CurrentEnergy =
            newEnemy.MaxEnergy = 50;

    }
    private void ChooseWhoGoesFirst()
    {
        if ((GameInfoManager.Dexterity + Random.Range(0,7)) > 
            (newEnemy.Dexterity + Random.Range(0,7)))
        {
            //player goes first
            CombatStateMachine.isPlayerTurn = true;
            CombatStateMachine.currentState = 
                CombatStateMachine.BattleStates.PLAYER_CHOICE;
        }
        else if ((GameInfoManager.Dexterity + Random.Range(0, 7)) <
           (newEnemy.Dexterity + Random.Range(0, 7)))
        {
            CombatStateMachine.isPlayerTurn = false;
            CombatStateMachine.currentState =
                CombatStateMachine.BattleStates.ENEMY_CHOICE;
        }
        else if ((GameInfoManager.Dexterity + Random.Range(0, 7)) ==
           (newEnemy.Dexterity + Random.Range(0, 7)))
        {
            CombatStateMachine.isPlayerTurn = true;
            //make additional calculation to see what is a tie breaker
            CombatStateMachine.currentState =
                CombatStateMachine.BattleStates.PLAYER_CHOICE;
        }
    }


    private void DeterminePlayerVitals()
    {
        playerHealth = statCalculations.CalculateHealth(GameInfoManager.Constitution);
        playerEnergy = statCalculations.CalculateEnergy(GameInfoManager.Strength);
        GameInfoManager.PlayerCurrentHealth = playerHealth;
        GameInfoManager.PlayerCurrentEnergy = playerEnergy;    
    }
}
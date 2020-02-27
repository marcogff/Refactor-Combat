using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Events;

public class CombatManager : MonoBehaviour
{
    public static CombatManager Instance;

    [Header("General")]
    public bool isPaused;
    public bool isTurnPlayer;

    public Transform groupPlayers;
    public Transform groupEnemies;

    private bool _isActionEnable;
    private WaitForSeconds combatTransition;
    private WaitForSeconds combatWaitTime;
    private WaitForSeconds evaluationDuration;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
        Destroy(this);
    }

    private void Start()
    {
        combatTransition = new WaitForSeconds(GameData.Instance.combatConfig.transitionDuration);
        combatWaitTime = new WaitForSeconds(GameData.Instance.combatConfig.waitCombatDuration);
        evaluationDuration = new WaitForSeconds(GameData.Instance.combatConfig.evaluationDuration);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            uIController.Menu(isPaused);
        }

    }
}

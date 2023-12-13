//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CharacterStatsHandler : MonoBehaviour
//{
//    [SerializeField] private CharacterStats baseStats;
//    public CharacterStats CurrentStates { get; private set; }
//    public List<CharacterStats> statsModifiers = new List<CharacterStats>();

//    private void Update()
//    {
//        UpdateCharacterStats();
//    }

//    private void UpdateCharacterStats()
//    {
//        CharacterSO characterSO = null;
//        if (baseStats.characterSO != null)
//        {
//            characterSO = Instantiate(baseStats.characterSO);
//        }
//        CurrentStates = new CharacterStats { characterSO = characterSO };

//        CurrentStates.statsChangeType = baseStats.statsChangeType;
//        CurrentStates.playerName = baseStats.playerName; // 닉네임 변경권?
//        CurrentStates.Level = baseStats.Level;
//        CurrentStates.maxHP = baseStats.maxHP;
//        CurrentStates.HP = baseStats.HP;
//        CurrentStates.ATK = baseStats.ATK;
//        CurrentStates.DEF = baseStats.DEF;
//        CurrentStates.Critical = baseStats.Critical;
//        CurrentStates.EXP = baseStats.EXP;
//        CurrentStates.maxEXP = baseStats.maxEXP;
//        CurrentStates.money = baseStats.money;
//    }
//}
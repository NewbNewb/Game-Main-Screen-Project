using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultCharacterData", menuName = "CharacterStats/Stats/Default", order = 0)]
public class CharacterSO : ScriptableObject
{
    // ���� �� ���� ���Ϸ� �����
    [Header("Character Info")]
    public string playerName;
    public int Level;
    public int maxHP;
    public int HP;
    public int ATK;
    public int DEF;
    public int Critical;
    public int EXP;
    public int maxEXP;
    public int money;
}

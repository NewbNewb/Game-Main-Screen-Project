using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainUIStatus : MonoBehaviour
{
    public TextMeshProUGUI hpText;
    public TextMeshProUGUI atkText;
    public TextMeshProUGUI defText;
    public TextMeshProUGUI criticalText;

    [SerializeField] private CharacterSO characterSO;

    void Update()
    {
        // 현재 스텟값을 스테이터스 UI에 기입
        hpText.text = characterSO.maxHP.ToString();
        atkText.text = characterSO.ATK.ToString();
        defText.text = characterSO.DEF.ToString();
        criticalText.text = characterSO.Critical.ToString();

    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainUILevel : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI exeText;
    public Slider exeBarSlider;

    [SerializeField] private CharacterSO characterSO;

    void Update()
    {
        // 현재 레벨 값을 메인 UI에 기입
        levelText.text = "LV. " + characterSO.Level.ToString();
        exeText.text = characterSO.EXP.ToString()+ " / " + characterSO.maxEXP.ToString();

        // 현재 경험치에 따라 경험치 바 벨류값 변경
        SetExe();
    }
    void SetExe()
    {
        float maxExp = characterSO.maxEXP;
        float exp = characterSO.EXP;
        exeBarSlider.value = exp / maxExp;
    }
}

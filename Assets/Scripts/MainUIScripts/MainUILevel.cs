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
        // ���� ���� ���� ���� UI�� ����
        levelText.text = "LV. " + characterSO.Level.ToString();
        exeText.text = characterSO.EXP.ToString()+ " / " + characterSO.maxEXP.ToString();

        // ���� ����ġ�� ���� ����ġ �� ������ ����
        SetExe();
    }
    void SetExe()
    {
        float maxExp = characterSO.maxEXP;
        float exp = characterSO.EXP;
        exeBarSlider.value = exp / maxExp;
    }
}

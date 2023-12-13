using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainUIMoney : MonoBehaviour
{
    public TextMeshProUGUI moneyText;

    [SerializeField] private CharacterSO characterSO;

    void Update()
    {
        // 현재 돈 값을 메인 UI에 기입
        moneyText.text = string.Format("{0:#,###}",characterSO.money);
    }
}

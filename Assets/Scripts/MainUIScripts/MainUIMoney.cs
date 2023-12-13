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
        // ���� �� ���� ���� UI�� ����
        moneyText.text = string.Format("{0:#,###}",characterSO.money);
    }
}

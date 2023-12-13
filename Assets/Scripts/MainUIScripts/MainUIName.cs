using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainUIName : MonoBehaviour
{
    public TextMeshProUGUI nameText;

    [SerializeField] private CharacterSO characterSO;

    void Awake()
    {
        // ���� �÷��̾� �̸� ���� ���� UI�� ���� (�ӽ÷� 1����)
        nameText.text = characterSO.playerName;
    }
}

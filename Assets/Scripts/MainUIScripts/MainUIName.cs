using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainUIName : MonoBehaviour
{
    public TextMeshProUGUI nameText;

    [SerializeField] private CharacterSO characterSO;

    void Awake()
    {
        // 현재 플레이어 이름 값을 메인 UI에 기입 (임시로 1번만)
        nameText.text = characterSO.playerName;
    }
}

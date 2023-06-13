using TMPro;
using UnityEngine;

/// <summary> Менеджер монеток.</summary>
public class CoinManager : MonoBehaviour
{
    /// <summary> Текстовое поле количества монет.</summary>
    [SerializeField] private TMP_Text _coinsNumberText;

    /// <summary> Количество монет, собранных персонажем на уровне.</summary>
    private int _coinsNumber;

    /// <summary> Синглтон.</summary>
    public static CoinManager Instance { get; set; }

    /// <summary> Инициализируем синглтон.</summary>
    private void Awake()
    {
        Instance = this;
    }

    /// <summary> Увеличить количество монет.</summary>
    public void IncrementCoinsNumber()
    {
        _coinsNumber++;
        _coinsNumberText.text = _coinsNumber.ToString();
    }
}

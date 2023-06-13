using UnityEngine;

/// <summary> Игровой менеджер.</summary>
public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;

    /// <summary> Событие на нажатие кнопки Играть.</summary>
    public void OnClickPlay()
    {
        _startMenu.SetActive(false);
    }
}

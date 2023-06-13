using UnityEngine;

/// <summary> Монетка.</summary>
public class Coin : MonoBehaviour
{
    /// <summary> Скорость поворота в секунду.</summary>
    [SerializeField] private float _rotationSpeed;

    /// <summary> Вращаем монетку.</summary>
    private void Update()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }

    /// <summary> Вызывается, когда Collider входит в триггер.</summary>
    /// <param name="other"> Collider.</param>
    private void OnTriggerEnter(Collider other)
    {
        CoinManager.Instance.IncrementCoinsNumber();
        Destroy(gameObject);
    }
}

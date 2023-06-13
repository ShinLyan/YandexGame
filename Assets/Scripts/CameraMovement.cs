using UnityEngine;

/// <summary> ѕеремещение камеры.</summary>
public class CameraMovement : MonoBehaviour
{
    /// <summary> ÷ель, за которой следует камера.</summary>
    [SerializeField] private Transform _target;

    /// <summary>  аждый кадр позици€ камеры равна позиции цели.</summary>
    private void LateUpdate() // ¬место Update используем это, чтобы убрать дергание камеры.
    {
        transform.position = _target.position;
    }
}

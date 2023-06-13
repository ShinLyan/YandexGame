using UnityEngine;

/// <summary> Перемещение игрока.</summary>
public class PlayerMovement : MonoBehaviour
{
    /// <summary> Скорость персонажа в м/с.</summary>
    [SerializeField] private float _speed;

    /// <summary> Аниматор.</summary>
    [SerializeField] private Animator _animator;

    /// <summary> Предыдущее позиция мыши по оси X.</summary>
    private float _prevMousePositionX;

    /// <summary> Угол поворота по оси Y.</summary>
    private float _eulerY;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ЛКМ
        {
            _prevMousePositionX = Input.mousePosition.x;

            _animator.SetBool("IsRunning", true); // Анимация.
        }

        // Перемещение персонажа.
        if (Input.GetMouseButton(0)) // ЛКМ
        {
            // transform.forward - направление оси Z.
            // Чтобы перемещение не зависило от мощности устройства, необходимо умножить на deltaTime.
            var newPosition = transform.position + _speed * Time.deltaTime * transform.forward;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f); // Ограничение перемещения за рамки платформы.
            transform.position = newPosition;

            // Поворот персонажа в зависимости от местоположения мыши на экране.
            float deltaX = Input.mousePosition.x - _prevMousePositionX;
            _prevMousePositionX = Input.mousePosition.x;
   
            _eulerY += deltaX;
            _eulerY = Mathf.Clamp(_eulerY, -70, 70); // Ограничение величины угла поворота.
            transform.eulerAngles = new Vector3(0, _eulerY, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetBool("IsRunning", false);
        }
    }
}

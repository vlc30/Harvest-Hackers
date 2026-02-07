using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector2 v = Keyboard.current != null
            ? new Vector2(
                (Keyboard.current.dKey.isPressed ? 1 : 0) - (Keyboard.current.aKey.isPressed ? 1 : 0),
                (Keyboard.current.wKey.isPressed ? 1 : 0) - (Keyboard.current.sKey.isPressed ? 1 : 0)
              )
            : Vector2.zero;

        Vector3 direction = new Vector3(v.x, v.y, 0f).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}

using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 2f;

    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private float lastHorizontal = 1f; // default facing right

    void Start()
    {
        // Get Animator and SpriteRenderer from Visuals child
        animator = GetComponentInChildren<Animator>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();

        if(animator == null)
            Debug.LogError("Animator not found on " + gameObject.name);
        if(spriteRenderer == null)
            Debug.LogError("SpriteRenderer not found on " + gameObject.name);
    }

    void Update()
    {
        // Get input
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, vertical, 0f);

        // Move the player
        transform.position += direction * speed * Time.deltaTime;

        // Animate
        AnimateMovement(direction);
    }

    void AnimateMovement(Vector3 direction)
    {
        if(animator == null) return;

        bool isMoving = direction.magnitude > 0f;
        animator.SetBool("isMoving", isMoving);
        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);

        if(spriteRenderer != null)
        {
            // Only update last horizontal when player is pressing left/right
            if(direction.x != 0f)
                lastHorizontal = direction.x;
            


        }
    }
}

using UnityEngine;

public class PlayerPaddleController : MonoBehaviour
{
    public float speed = 5f;

    public bool isPlayer = false;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        if (isPlayer)
            spriteRenderer.color = SaveController.instance.colorPlayer;
      

    }

    void Update()
    {
        float moveInput = 0f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveInput = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            moveInput = -1f;
        }

        Vector3 newPosition = transform.position + Vector3.up * moveInput * speed * Time.deltaTime;

        newPosition.y = Mathf.Clamp(newPosition.y, -4.5f, 4.5f);

        transform.position = newPosition;
    }
}

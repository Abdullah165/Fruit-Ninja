using UnityEngine;

public class ObjectController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] enum ObjectDirection { UP, UPLeft, UPRight };
    [SerializeField] float jumpForce = 300f;

    [SerializeField] ObjectDirection objectDirection;
   
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        switch (objectDirection)
        {
            case ObjectDirection.UPLeft:
                rb.AddForce((Vector2.up + (Vector2.left / 8)) * jumpForce);
                break;
            case ObjectDirection.UPRight:
                rb.AddForce((Vector2.up + (Vector2.right / 8)) * jumpForce);
                break;
            case ObjectDirection.UP:
                rb.AddForce(Vector2.up * jumpForce);
                break;
            default:
                break;
        }

        Destroy(gameObject, 3f);
    }
}

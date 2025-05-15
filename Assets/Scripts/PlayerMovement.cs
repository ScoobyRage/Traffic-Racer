using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    private float torqueF = 1750*2f; // Torque for rotation
    private float resetSpeed = 0.5f; // Speed of rotation reset (lower = slower)
    private float wresetSpeed = 0.9f; // Speed of rotation reset (lower = slower)
    void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody>(); // Auto-assign Rigidbody if not set
    }

    void Update()
    {
        // Right movement (D or Right Arrow)
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(0, torqueF, 0);
        }
        // Left movement (A or Left Arrow)
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(0, -torqueF, 0);
        }
        else if(Input.GetKey(KeyCode.W))
        {
            Quaternion targetRotation = Quaternion.identity; // (0, 0, 0) rotation
            Quaternion newRotation = Quaternion.Slerp(
                rb.rotation,
                targetRotation,
                wresetSpeed * Time.fixedDeltaTime
            );
            rb.MoveRotation(newRotation);
        }
        
        // No input: Slowly reset rotation to (0, 0, 0)
        else
        {
            Quaternion targetRotation = Quaternion.identity; // (0, 0, 0) rotation
            Quaternion newRotation = Quaternion.Slerp(
                rb.rotation,
                targetRotation,
                resetSpeed * Time.fixedDeltaTime
            );
            rb.MoveRotation(newRotation);
        }
    }
}
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float _velocity = 6f;
    [SerializeField] private float turnSpeed = 2f;

    private @PlayerContoller controller;
    private Rigidbody rb;
    private void Awake()
    {
        controller = new @PlayerContoller();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 velocity = rb.velocity;
        velocity.x = -_velocity;
        rb.velocity = velocity;

        var moveDirection = controller.Move.UpDown.ReadValue<Vector2>();
        rb.AddForce(new Vector3(moveDirection.x, 0, moveDirection.y) * turnSpeed);
    }

    public void UpControlButtonPressed() => rb.AddForce(new Vector3(0, 0, -7) * turnSpeed);

    public void DownControlButtonPressed() => rb.AddForce(new Vector3(0, 0, 7) * turnSpeed);

    private void OnEnable() => controller.Enable();

    private void OnDisable() => controller?.Disable();
}

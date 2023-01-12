using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class WindFlying : MonoBehaviour
{
    [SerializeField] float flyingForce = 2f;
    [SerializeField] Transform head;
    [SerializeField] Transform rH;
    [SerializeField] InputActionProperty triggerAxis;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 flyingDirection = rH.position - head.position;
        float triggerValue = triggerAxis.action.ReadValue<float>();

        if (triggerValue > 0.2f)
        {
            rb.useGravity = false;

        }
        else
        {
            rb.useGravity = true;
        }
        transform.position += flyingDirection.normalized * flyingForce * Time.deltaTime;
    }
}

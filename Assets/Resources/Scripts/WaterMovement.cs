using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WaterMovement : MonoBehaviour
{
    public InputActionProperty rightThumbStick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 thumbStick = rightThumbStick.action.ReadValue<Vector2>();
        //transform.Translate(new Vector3(1 * thumbStick.x * Time.deltaTime, 1 * thumbStick.y * Time.deltaTime, 0.5f * Time.deltaTime));
        transform.Translate(new Vector3(0,0, 0.5f * Time.deltaTime));
    }

   
    private void OnEnable()
    {
        transform.eulerAngles = new Vector3(0,180,0);
    }
}

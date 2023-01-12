using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] Transform respawnPos;
    [SerializeField] Transform StartPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            TunnelingVignetteScript.instance.fullFade();
            transform.position = respawnPos.position; //will be replaced by load a level
        }

        if (collision.gameObject.CompareTag("Flower"))
        {
            GetComponent<WaterMovement>().enabled = false;
            GetComponent<WindFlying>().enabled = false;
            TunnelingVignetteScript.instance.fullFade();
            transform.position = StartPos.position; //will be replaced by load a level
        }
    }
     
}

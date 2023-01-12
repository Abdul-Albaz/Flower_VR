using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBehaviour : MonoBehaviour
{
    [SerializeField] Transform fruit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Growing()
    {
        //LeanTween.scale(gameObject, new Vector3(2, 2, 2), 1.5f);
        if (transform.localScale.x <= 3)
        {
            LeanTween.scale(gameObject, new Vector3(transform.localScale.x + 0.1f, transform.localScale.y + 0.1f, transform.localScale.z + 0.1f), 1.5f);

        }

    }

    public void Fruiting()
    {
        //fruit animaion or popUp fruit
        if (transform.localScale.x <= 2)
        {
            LeanTween.scale(fruit.gameObject, new Vector3(fruit.localScale.x + 0.1f, fruit.localScale.y + 0.1f, fruit.localScale.z + 0.1f), 1.5f);

        }
    }

    private void OnTriggerStay(Collider other)
    {
        

        if (other.name == "watering_can")
        {
            bool _isWatering = other.gameObject.GetComponent<KettleBehaviour>().isWatering;
            if (_isWatering)
            {
                Growing();
            }
        }
    }
}

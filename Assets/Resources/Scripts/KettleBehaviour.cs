using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class KettleBehaviour : MonoBehaviour
{
    public  bool isWatering;
    // Start is called before the first frame update
    void Start()
    {
        
    }

  

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Watering(bool _isWatering)
    {
        isWatering = _isWatering;
        StartCoroutine(watre());
        
    }


    IEnumerator watre()
    {
        while (isWatering)
        {
            Debug.Log("Wateriing");
            yield return null;
        }

    }


}

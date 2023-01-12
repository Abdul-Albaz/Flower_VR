using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectSuppertation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabable = GetComponent<XRGrabInteractable>();
        grabable.activated.AddListener(supprateparts);
    }

    private void supprateparts(ActivateEventArgs arg0)
    {
        float offset = 1;
        foreach (Transform child in transform)
        {
            offset *= 2f;
            LeanTween.moveLocalX(child.gameObject , offset, 1.5f);
        }
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;
using UnityEngine.UI;

public class LableBehaviour : MonoBehaviour
{
    
    [SerializeField] Transform lableOwner;
    [SerializeField] Vector3 LableScale;
    [SerializeField] Vector3 offset;
    Transform player;
    [SerializeField] GameObject panle;
    [SerializeField] TextMeshProUGUI defntionText;
    [SerializeField] string defntion;
    [SerializeField] TextMeshProUGUI NameText;
    [SerializeField] string partName;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera").transform;
        //partName = lableOwner.name;
        NameText.text = partName;
        PopUp();
        defntionText.text = defntion;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = lableOwner.transform.position + offset;
        transform.LookAt(player);
        transform.forward *= -1;
    }

    public void PopUp()
    {
        
        transform.position = lableOwner.transform.position + offset;
        transform.localScale = Vector3.zero;
        LeanTween.scale(gameObject, LableScale, 0.4f);
    }

    public void showInfo()
    {
        panle.SetActive(!panle.activeSelf);
        //panle.LeanScaleY(3f, 0.5f);
    }
}

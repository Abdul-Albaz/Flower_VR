using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;
using UnityEngine.UI;

public class TutorialGuide : MonoBehaviour
{
    [SerializeField] Canvas guidePanle;
    [SerializeField] TextMeshProUGUI guideUIText;
    [SerializeField] string[] guideText;
    [SerializeField] GameObject Arrow;
    [SerializeField] Transform[] ArrowTargets;
    Transform player;
    public int levelPhaseIndex;
    public enum LevelPhase
    {
        pickUpKettle,watering, explaination, mergeByWind, mergeByWater
    }
    LevelPhase CurrentLevelPhase;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        ArrowPointing(0);
    }

    // Update is called once per frame
    void Update()
    {
        guidePanle.transform.LookAt(player);
        guidePanle.transform.forward *= -1;
    }

   public  void ArrowPointing(int index)
     {
        Arrow.transform.position = new Vector3(ArrowTargets[index].position.x, ArrowTargets[index].position.y + 1, ArrowTargets[index].position.z);
        
     }

    public  void SetTextGuide(int index)
    {
        
         guidePanle.transform.position = ArrowTargets[index].transform.position + new Vector3(0, 2.5f, 0);
         guideUIText.text = guideText[index];
           
    }

    public void SetTurorialPhase(int index)
    {
        
        ArrowPointing(index);
        SetTextGuide(index);
    }
}

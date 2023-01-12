using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TunnelingVignetteScript : MonoBehaviour
{
    public static TunnelingVignetteScript instance;
    Material VigneteMaterial;
    public float ApertureSize;
    public float FeatheringEffect;
    public InputActionProperty teleportAction;
    float fadeTime = 0.8f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        VigneteMaterial = GetComponent<Renderer>().material;
        //ShowTunnleing();
         
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ShowTunnleing()
    {
        VigneteMaterial.SetFloat("_ApertureSize", ApertureSize);
        VigneteMaterial.SetFloat("_FeatheringEffect", FeatheringEffect);
    }

    public void FadeInTunnleing()
    {
        StartCoroutine(fadeingIn());
    }

    public void FadeOutTunnleing()
    {
        StartCoroutine(fadeingOut());
    }

    public void fullFade()
    {
        StartCoroutine(fadeingIn());
        StartCoroutine(fadeingOut());

    }
    IEnumerator fadeingIn()
    {
        float elapsedtime = 0;
        while (elapsedtime < fadeTime)
        {
            VigneteMaterial.SetFloat("_ApertureSize", Mathf.Lerp(ApertureSize, 0,(elapsedtime / fadeTime)));
            VigneteMaterial.SetFloat("_FeatheringEffect", Mathf.Lerp(FeatheringEffect, 0, (elapsedtime / fadeTime)));
            elapsedtime += Time.deltaTime;
            yield return null;
        }

    }

    IEnumerator fadeingOut()
    {
        float elapsedtime = 0;
        while (elapsedtime < fadeTime)
        {
            VigneteMaterial.SetFloat("_ApertureSize", Mathf.Lerp(0,ApertureSize, (elapsedtime / fadeTime)));
            VigneteMaterial.SetFloat("_FeatheringEffect", Mathf.Lerp(0,FeatheringEffect, (elapsedtime / fadeTime)));
            elapsedtime += Time.deltaTime;
            yield return null;
        }

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InvButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isHold = false;
    public GameObject isPlayer;
    public CubeExplode script;

    void Start()
    {
    isPlayer=GameObject.Find("Player");
    script=isPlayer.GetComponent<CubeExplode>();
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        script.isHold = true;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        script.isHold = false;
    }

}

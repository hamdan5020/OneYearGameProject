using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckForPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool buttonpressed;
    // Start is called before the first frame update
    void Start()
    {
        buttonpressed = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonpressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonpressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool getButtonPressed()
    {
        return buttonpressed;
    }
}

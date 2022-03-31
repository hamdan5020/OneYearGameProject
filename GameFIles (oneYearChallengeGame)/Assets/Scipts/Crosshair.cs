using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{

    [SerializeField] float minX = -3.0f;
    [SerializeField] float maxX = 9.5f;
    [SerializeField] float minY = -2.8f;
    [SerializeField] float maxY = 3.5f;
    [SerializeField] float minXIgnore = 0.35f;
    
    [SerializeField] float crosshairOffset = 1f;
    [SerializeField] Vector2 standByScale;
    


    Vector3 targetOrigin;
    Vector3 worldVec;
    Vector2 originalScale;

    // Start is called before the first frame update
    void Start()
    {
        worldVec = new Vector3();
        originalScale = transform.localScale;
        targetOrigin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCrosshairToTouchPos();
    }

    public void MoveCrosshairToTouchPos()
    {
        if (Input.touchCount > 0 && Camera.main.ScreenToViewportPoint(Input.GetTouch(0).position).x > minXIgnore)
        {
            
            transform.localScale = originalScale;
            worldVec.x = Mathf.Clamp(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).x, minX, maxX);
            worldVec.y = Mathf.Clamp(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).y + crosshairOffset, minY, maxY);
            worldVec.z = 0;
            
            transform.position = worldVec;

            
        } else if (Input.touchCount <= 0)
        {
            transform.position = targetOrigin;
            transform.localScale = standByScale;
        }


    }
}

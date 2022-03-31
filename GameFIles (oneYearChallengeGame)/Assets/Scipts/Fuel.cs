using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuel : MonoBehaviour
{
    float playerFuel;
    void Start()
    {
        playerFuel = FindObjectOfType<Player>().GetRobotFuelLevel();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / playerFuel;
    }

    
}

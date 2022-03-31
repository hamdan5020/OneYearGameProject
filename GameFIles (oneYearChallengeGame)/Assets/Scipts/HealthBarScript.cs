using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealth(Player player)
    {
        // *1f is important (converts int to float for decimal slider value)
        GetComponent<Slider>().value = player.GetCrntHealth() *1f / player.GetMaxHealth() * 1f; 
    }
}

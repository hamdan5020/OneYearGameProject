using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Player : MonoBehaviour
{
    [SerializeField] float fuel = 100f;
    Rigidbody2D rb;

    [SerializeField] float playerSpeed = 10f;
    [SerializeField] Button forwardsButton;
    [SerializeField] Button backwardsButton;
    [SerializeField] int maxHealth = 100;
    int currentHealth;

    HealthBarScript healthBar;

    void Start()
    {
        healthBar = FindObjectOfType<HealthBarScript>();
        currentHealth = maxHealth;
        healthBar.UpdateHealth(this);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FindObjectOfType<Crosshair>().MoveCrosshairToTouchPos();
        if (forwardsButton.GetComponent<CheckForPress>().getButtonPressed())
        {
            rb.velocity = new Vector2(playerSpeed, rb.velocity.y);
            

        }else if (backwardsButton.GetComponent<CheckForPress>().getButtonPressed())
        {
            rb.velocity = new Vector2(-playerSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }
        
    }


    public float GetRobotFuelLevel()
    {
        return fuel;
    }

    public void DamagePlayer(int damagePoints)
    {
        currentHealth -= damagePoints;
        healthBar.UpdateHealth(this);
    }

    public int GetCrntHealth()
    {
        return currentHealth;
    }

    public int GetMaxHealth()
    {
        return maxHealth;
    }


}

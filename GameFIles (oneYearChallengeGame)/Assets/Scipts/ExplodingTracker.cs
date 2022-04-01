using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingTracker : MonoBehaviour
{
    
    Player player;
    Enemy enemyComp;

    [Header("SFX")]
    [SerializeField] AudioClip explosionSFX;
    [SerializeField] float volume = 0.5f;

    [Header("VFX")]
    [SerializeField] GameObject explosionVFX;

    // Start is called before the first frame update
    void Start()
    {
        enemyComp = GetComponent<Enemy>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer(player);
    }

    private void MoveToPlayer(Player player)
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemyComp.GetSpeed() * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            Explode();
            collision.gameObject.GetComponent<Player>().DamagePlayer(enemyComp.GetDamage());
        }
    }

    private void Explode()
    {
        AudioSource.PlayClipAtPoint(explosionSFX, Camera.main.transform.position, volume);
        Instantiate(explosionVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

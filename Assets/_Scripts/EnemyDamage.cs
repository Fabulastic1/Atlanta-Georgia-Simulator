using AtlantaGeorgia;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage; 
    public MaxHealth PlayerHealth;
    private PlayerController playerController; 

    private void Start()
    {
        playerController = PlayerHealth.GetComponent<PlayerController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
         
            PlayerHealth.TakeDamage(damage);

           
            Vector2 knockbackDirection = (collision.transform.position - transform.position).normalized;

           
            playerController.TriggerKnockback(knockbackDirection);
        }
    }
}

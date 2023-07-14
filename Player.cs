using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public AudioSource audioSource;  
    public AudioClip damageSound;
    public int coins;
    public AudioClip collectSound;
   
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
   
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    public void CollectCoins()
    {
        coins++;
     
        //audioSource.PlayOneShot(collectSound);

        print("Собранные монетки: " + coins);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool isActive;
  
    void Update()
    {
        if (isActive)
        {
            transform.position += direction * speed * Time.deltaTime; 
        }
    }

    void OnCollisionEnter(Collision other)
    {
        
        if (other.collider.tag == "Player")
        {
            isActive = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlatformStop")
        {
            direction *= -1;
        }
    }
}

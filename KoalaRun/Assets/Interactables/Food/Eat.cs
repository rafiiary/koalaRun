using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    public GameObject particles;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(particles, transform.position, transform.rotation);
            Destroy(this.gameObject);
            PlayerAttributeController.addLeaf();
            LeafTextController.updateLeavesText();
        }
    }
}

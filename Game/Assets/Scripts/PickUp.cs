using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUp : MonoBehaviour
{
    [SerializeField]

    SpriteRenderer spriteRenderer;
    int multiplyRandom = 255;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Destroy(collision.gameObject);

            float randomNumber = Random.Range(1, 256) / 255.0f;
            spriteRenderer.color = new Color(randomNumber, Random.value, randomNumber);
        }
    }
}

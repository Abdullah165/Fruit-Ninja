using UnityEngine.UI;
using UnityEngine;
using System;

public class Fruit : MonoBehaviour,IDamageable
{
    public static event EventHandler OnScoredChanged;


    [SerializeField] Sprite objectSlices;
    [SerializeField] AudioSource audio;

   

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audio.Play();
            gameObject.GetComponent<Image>().sprite = objectSlices;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
        }
    }

    public void Damage()
    {
        OnScoredChanged?.Invoke(this, EventArgs.Empty);
    }
}

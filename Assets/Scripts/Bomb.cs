using System;
using UnityEngine;

public class Bomb : MonoBehaviour, IDamageable
{    
    public static event EventHandler OnGameOver;

    [SerializeField] GameObject explosionPrefab;
    [SerializeField] AudioSource audioSource;

    public void Damage()
    {
        //Hide the bomb gameObject
        //play explosion effect
        //play the explosion sound effect

        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        audioSource.Play();

        StartCoroutine(LoadGameOverScene());
    }

    IEnumerator LoadGameOverScene()
    {
        yield return new WaitForSeconds(0.7f);

        OnGameOver?.Invoke(this, EventArgs.Empty);
    }
}

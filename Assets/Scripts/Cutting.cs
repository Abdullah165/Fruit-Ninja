using System;
using UnityEngine;

public class Cutting : MonoBehaviour
{
    private Vector3 touchPosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            transform.position = touchPosition;


            transform.Translate(new Vector2(transform.position.x, transform.position.y) * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDamageable damageable = collision.GetComponent<IDamageable>();

        if(damageable != null)
        {
            damageable.Damage();
        }
    }
}

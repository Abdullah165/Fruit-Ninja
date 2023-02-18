using System;
using UnityEngine;

public class Bomb : MonoBehaviour, IDamageable
{    
    public static event EventHandler OnGameOver;

    public void Damage()
    {
        OnGameOver?.Invoke(this, EventArgs.Empty);
    }
}

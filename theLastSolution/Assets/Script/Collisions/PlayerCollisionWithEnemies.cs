using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisionWithEnemies : MonoBehaviour
{
    public GameObject canvasGameOver;
    public Slider healthSlider;
    private float _collisionValue = 0.2f;

    private const string SWMAN1H = "SwordMan1h";
    private const string SWMAN2H = "SwordMan2h";
    private const string SWMAN3H = "SwordMan3h";
    private const string SWMAN4H = "SwordMan4h";
    private const string SWMAN5H = "SwordMan5h";
    private const string SWMAN1V = "SwordMan1v";
    private const string SWMAN2V = "SwordMan2v";
    private const string SWMAN3V = "SwordMan3v";
    private const string SWMAN4V = "SwordMan4v";
    private const string HealthPotion = "HealthPotion";

    private void OnCollisionEnter2D(Collision2D col)
    {
        
        switch (col.gameObject.name)
        {
            case SWMAN1H:
                CollisionWithEnemy(col);
                break;
            case SWMAN2H:
                CollisionWithEnemy(col);
                break;
            case SWMAN3H:
                CollisionWithEnemy(col);
                break;
            case SWMAN4H:
                CollisionWithEnemy(col);
                break;
            case SWMAN5H:
                CollisionWithEnemy(col);
                break;
            case SWMAN1V:
                CollisionWithEnemy(col);
                break;
            case SWMAN2V:
                CollisionWithEnemy(col);
                break;
            case SWMAN3V:
                CollisionWithEnemy(col);
                break;
            case SWMAN4V:
                CollisionWithEnemy(col);
                break;
            case HealthPotion:
                healthSlider.value += _collisionValue * 2;
                col.gameObject.SetActive(false);
                break;
            default:
                Debug.Log("Collision with " + col.gameObject.name);
                break;
        }
    }

    private void CollisionWithEnemy(Collision2D col)
    {
        col.gameObject.SetActive(false);
        if (healthSlider.value - _collisionValue <= 0)
        {
            Time.timeScale = 0f;
            canvasGameOver.SetActive(true);
        }
        else
        {
            healthSlider.value -= _collisionValue;
        }
    }
}

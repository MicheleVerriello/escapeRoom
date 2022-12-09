using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisionWithEnemies : MonoBehaviour
{
    public GameObject canvasGameOver;
    public Slider healthSlider;
    public AudioSource enemyCollisionAudio;
    public AudioSource wallCollisionAudio;
    public AudioSource potionCollisionAudio;
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
    private const string Chest1 = "Chest1";
    private const string Chest2 = "Chest2";
    private const string Chest3 = "Chest3";
    private const string Chest4 = "Chest4";
    private const string Key1 = "Key1";
    private const string Key2 = "Key2";
    private const string Key3 = "Key3";
    private const string Key4 = "Key4";

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
                potionCollisionAudio.Play();
                healthSlider.value += _collisionValue * 2;
                col.gameObject.SetActive(false);
                break;
            case Chest1:
                Debug.Log("C1");
                potionCollisionAudio.Play();
                break;
            case Chest2:
                Debug.Log("C1");
                potionCollisionAudio.Play();
                break;
            case Chest3:
                Debug.Log("C1");
                potionCollisionAudio.Play();
                break;
            case Chest4:
                Debug.Log("C1");
                potionCollisionAudio.Play();
                break;
            case Key1:
                Debug.Log("C1");
                potionCollisionAudio.Play();
                break;
            case Key2:
                Debug.Log("C1");
                potionCollisionAudio.Play();
                break;
            case Key3:
                Debug.Log("C1");
                potionCollisionAudio.Play();
                break;
            case Key4:
                Debug.Log("C1");
                potionCollisionAudio.Play();
                break;
            default:
                wallCollisionAudio.Play();
                Debug.Log("Collision with " + col.gameObject.name);
                break;
        }
    }

    private void CollisionWithEnemy(Collision2D col)
    {
        enemyCollisionAudio.Play();
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

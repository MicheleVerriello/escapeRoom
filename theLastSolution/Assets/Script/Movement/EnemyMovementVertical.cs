using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementVertical : MonoBehaviour
{
    private float yDirection;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        yDirection = 2 * Time.deltaTime * speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, yDirection, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.yDirection *= -1;
    }
}

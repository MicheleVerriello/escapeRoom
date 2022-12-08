using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMovement : MonoBehaviour
{
    private float xDirection;
    // Start is called before the first frame update
    void Start()
    {
        xDirection = 2 * Time.deltaTime * 100;
        this.xDirection *= -1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xDirection, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 charscale = transform.localScale;
        charscale.x *= -1; //flipping
        transform.localScale = charscale;
        this.xDirection *= -1;
    }
}

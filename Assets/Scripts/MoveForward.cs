using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 10f;
    private float leftlim = -50f;
    private float rightlim = 50f;
    private float uplim = 100f;
    private float downlim = -20f;

   

    // Update is called once per frame
    void Update()
    {
        //movimiento constante de la bala
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        //Bala de tinta desaparece al llegar a los bordes
        if (transform.position.y > uplim)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > rightlim)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < downlim)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < leftlim)
        {
            Destroy(gameObject);
        }
    }
}

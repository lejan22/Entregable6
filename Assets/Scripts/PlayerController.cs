using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject proyectil;
    private Quaternion Up = Quaternion.Euler(0, 0, 0);
    private Quaternion Down = Quaternion.Euler(0, 0, 180);
    private Quaternion Right = Quaternion.Euler(0, 0, -90);
    private Quaternion Left = Quaternion.Euler(0, 0, 90);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SpawnProyectil(Down);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SpawnProyectil(Right);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SpawnProyectil(Left);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SpawnProyectil(Up);
        }
    }
    public void SpawnProyectil(Quaternion rotate)
    {
        //Colocamos el proyectil de tinta con la rotación adecuada
        Instantiate(proyectil, transform.position,
        rotate);
    }
}

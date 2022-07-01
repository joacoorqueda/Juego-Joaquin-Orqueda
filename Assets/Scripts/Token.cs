using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    // Start is called before the first frame update

    Inventario inventario;


    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }


       void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.name == "Player")
            {
                inventario.Cantidad = inventario.Cantidad + 1;
                Destroy(gameObject);
            }

        }


    }
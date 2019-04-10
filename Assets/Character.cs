using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    void Start()
    {
        int rnd = UnityEngine.Random.Range(4, 11);
        for (int i = 0; i < rnd; i++)
        {
            int ad = UnityEngine.Random.Range(0, 2);
            if (ad == 0)
            {
                new Zombie(1,1,1);
            }else
                new Aldeano(1,1,1);
        }
    }
    void Update()
    {
    }
}
internal class Zombie
{
    private Renderer color;
    private GameObject create;
    public Zombie(float altura, float peso, float profundidad)
    {
        create = GameObject.CreatePrimitive(PrimitiveType.Cube);
        create.transform.localPosition = new Vector3(altura, peso, profundidad);
        float x = UnityEngine.Random.Range(-10, 10);
        float z = UnityEngine.Random.Range(-10, 10);
        create.transform.position = new Vector3(x, 0, z);
        color = create.GetComponent<Renderer>();
        int cora = UnityEngine.Random.Range(0, 3);
        if (cora == 0)
        {
            color.material.color = Color.cyan;
            Debug.Log("Soy un zombie de color Cyan");
        }
        else if (cora == 1)
        {
            color.material.color = Color.magenta;
            Debug.Log("Soy un zombie de color Magenta");
        }
        else if (cora == 2)
        {
            color.material.color = Color.green;
            Debug.Log("Soy un zombie de color Verde");
        }
    }
}
internal class Aldeano
{
    string[] nombrea;
    
    private GameObject otro;

    public Aldeano(float altura, float peso, float profundidad)
    {
        otro = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        otro.transform.localPosition = new Vector3(altura, peso, profundidad);
        float x = UnityEngine.Random.Range(-10, 10);
        float z = UnityEngine.Random.Range(-10, 10);
        otro.transform.position = new Vector3(x, 0, z);

        nombrea = new string[]
        {
         "María Carmen","Maria", "Carmen","Josefa","Ana Maria","Isable","Maria Dolores","Laura","Maria Teresa", "Antonia","Jose","Manuel","Francisco"
         ,"David","Juan", "Jose Antonio","Javier","Jose Luis", "Daniel","Camila"
        };


        
        Debug.Log("Hola soy " + nombrea[UnityEngine.Random.Range(1, 21)]+ " Y tengo " + UnityEngine.Random.Range(15,101));
        
    }
}

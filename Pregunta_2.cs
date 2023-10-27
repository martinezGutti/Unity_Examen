using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta_2 : MonoBehaviour
{
    private GameObject zombie;


    // Start is called before the first frame update
    void Start()
    {
        zombie = GameObject.Find("Zombie");
    }

    // Update is called once per frame
    void Update()
    {
        zombie.transform.Translate(0,0,0.5f * Time.deltaTime);
    }
}

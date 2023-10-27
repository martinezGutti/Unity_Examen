using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta_3 : MonoBehaviour
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
        if(Input.GetKey(KeyCode.T)) {
            int x = UnityEngine.Random.Range(-5, 5);
            int z = UnityEngine.Random.Range(-5, 5);
            zombie.transform.position = new Vector3(x, -4f, z);
        }
    }
}

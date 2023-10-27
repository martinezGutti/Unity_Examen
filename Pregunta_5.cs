using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta_5 : MonoBehaviour
{
    private GameObject zombie;
    private GameObject chair;
    private GameObject spider1;
    private GameObject spider2;
    private GameObject spider3;

    private bool near;

    // Start is called before the first frame update
    void Start()
    {
        zombie = GameObject.Find("Zombie");
        chair = GameObject.Find("Chair");
        spider1 = GameObject.Find("Spider_One");
        spider2 = GameObject.Find("Spider_Two");
        spider3 = GameObject.Find("Spider_Three");

        near = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(near) {
            float spider1_dist = Vector3.Distance(spider1.transform.position, zombie.transform.position);
            float spider2_dist = Vector3.Distance(spider2.transform.position, zombie.transform.position);
            float spider3_dist = Vector3.Distance(spider3.transform.position, zombie.transform.position);

            Vector3 spider1_direction = Vector3.MoveTowards(spider1.transform.position, zombie.transform.position, spider1_dist * Time.deltaTime);
            spider1.transform.position = spider1_direction;

            Vector3 spider2_direction = Vector3.MoveTowards(spider2.transform.position, zombie.transform.position, spider1_dist * Time.deltaTime);
            spider2.transform.position = spider2_direction;

            Vector3 spider3_direction = Vector3.MoveTowards(spider3.transform.position, zombie.transform.position, spider1_dist * Time.deltaTime);
            spider3.transform.position = spider3_direction;
        }
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log("HALLO=");
        if(collision.gameObject == zombie) {
            near = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta_4 : MonoBehaviour
{
    private GameObject tableau;
    private GameObject flowerPot_1;
    private GameObject flowerPot_2;
    private GameObject chair_1;
    private GameObject chair_2;
    private GameObject zombie;

    private bool done;

    public float distanceTrigger;
    public float distanceToZombie;
    // Start is called before the first frame update
    void Start()
    {
        done = false;

        tableau = GameObject.Find("Tableau");
        flowerPot_1 = GameObject.Find("Pot de fleur 006");
        flowerPot_2 = GameObject.Find("Pot de fleur 2");
        chair_1 = GameObject.Find("Chaise001");
        chair_2 = GameObject.Find("Chaise003");
        zombie = GameObject.Find("Zombie");

    }

    // Update is called once per frame
    void Update()
    {
        double actual_distance = Vector3.Distance(tableau.transform.position, zombie.transform.position);

        if(!done && actual_distance < distanceTrigger) {
            int x = UnityEngine.Random.Range(0, 10);
            int z = UnityEngine.Random.Range(0, 10);
            float y = flowerPot_1.transform.position.y;

            flowerPot_1.transform.position = new Vector3(x, y, z);

            x = UnityEngine.Random.Range(0, 10);
            z = UnityEngine.Random.Range(0, 10);
            y = flowerPot_2.transform.position.y;

            flowerPot_2.transform.position = new Vector3(x, y, z);
            done = true;

        }

        if(done) {
            float chair1_dist = Vector3.Distance(chair_1.transform.position, zombie.transform.position);
            Vector3 chair1_distance = Vector3.MoveTowards(chair_1.transform.position, zombie.transform.position, (chair1_dist - distanceToZombie) * Time.deltaTime);
            chair_1.transform.position = chair1_distance;

            float chair2_dist = Vector3.Distance(chair_2.transform.position, zombie.transform.position);
            Vector3 chair2_distance = Vector3.MoveTowards(chair_2.transform.position, zombie.transform.position, (chair2_dist - distanceToZombie) * Time.deltaTime);
            chair_2.transform.position = chair2_distance;
        }

    }
}

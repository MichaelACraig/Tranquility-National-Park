using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{

    public float speed = 2;
    public float pointA = 20;
    public float pointB = -15;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((int)transform.position.z == pointA)
        {
            gameObject.transform.Rotate(0, 180, 0);
            gameObject.transform.Translate(0, 0, 1);
        }
        if ((int)transform.position.z == pointB)
        {
            gameObject.transform.Rotate(0, 180, 0);
            gameObject.transform.Translate(0, 0, 1);
        }
        else
        {
            gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class NewBehaviourScript : MonoBehaviour
{
    public int postion;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    public GameObject Car;
    public PathCreator pathCreator;
    public float speed = 8;
    private float dist;
    // Update is called once per frame
    void Update()
    {
        if (postion > 0)
        {
            postion -= 1;
        }
        else
        {
            dist += speed * Time.deltaTime;
            Car.transform.position = pathCreator.path.GetPointAtDistance(dist);
            Car.transform.rotation = pathCreator.path.GetRotationAtDistance(dist);
        }

    }
}
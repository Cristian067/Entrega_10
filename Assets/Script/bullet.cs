using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] private bool spin;
    [SerializeField] private float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spin)
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed, Space.World);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
        


        

    }
}

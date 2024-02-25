using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private UIManager uiManager;

    [SerializeField] private float topBound = 30f;
    [SerializeField] private float botBound = -10f;



    // Start is called before the first frame update
    void Start()
    {

        uiManager = FindObjectOfType<UIManager>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < botBound) 
        {
            
            Destroy(gameObject);
            Debug.Log("Te han comido por fallar");
            uiManager.ShowGameOverPanel();
            Time.timeScale = 0f;
        }
        
    }











}

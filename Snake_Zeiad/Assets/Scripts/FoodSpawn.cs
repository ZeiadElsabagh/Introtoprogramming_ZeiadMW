using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    //MW CCNY

    //GLOBAL VARIABLES
    public GameObject foodPrefab;

    //Border positions
    public Transform TopWall;
    public Transform BottomWall;
    public Transform LeftWall;
    public Transform RightWall;
    private float yPos;

    void Start()
    {
        //invoke("spawn", 4);
        InvokeRepeating("spawn", 3, 4);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        //Debug.log("Spawn Called");

        int xPos = (int)Random.Range(LeftWall.position.x, RightWall.position.x);
        int xPos = (int)Random.Range(TopWall.position.y, BottomWall.position.y);

        Instantiate(foodPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
    }   
}

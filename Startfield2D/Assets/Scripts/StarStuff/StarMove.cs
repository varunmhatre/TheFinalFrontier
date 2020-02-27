using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMove : MonoBehaviour
{
    //Every star should move at a different speed
    private int uniqueStarSpeed;

    //Function to move star
    private IMoveFunctions _moveStar;

    private void Awake()
    {
        _moveStar = GetComponent<IMoveFunctions>();
    }

    void Start()
    {
        //Set speed of star
        SetStarSpeed();
    }

    void Update()
    {
        //Update star position
        transform.position += _moveStar.Move(transform, uniqueStarSpeed);
    }

    //Set speed randomly within a range
    public void SetStarSpeed()
    {
        uniqueStarSpeed = Random.Range(100, 500);
    }
}

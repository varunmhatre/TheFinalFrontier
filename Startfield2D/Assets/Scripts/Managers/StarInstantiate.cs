using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Handles the instantiation of the stars when projet starts
public class StarInstantiate : MonoBehaviour
{
    //Star that will be instantiated
    [SerializeField] private GameObject starPrefab;
    //Number of stars that will be displayed on the screen
    [SerializeField] [Range (50,10000)] private int numberOfStars = 1000;
    //Size of the stars
    private int starSize = 20;

    //Interface to instantiate star
    private IInstantiator _instantiateStars;

    private void Awake()
    {
        _instantiateStars = GetComponent<IInstantiator>();
    }

    void Start()
    {

        _instantiateStars.InstantiatorStars(starPrefab, numberOfStars, starSize);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Despawns star when it goes off screen
public class StarDespawn : MonoBehaviour
{
    //Interface to despawn star
    private IDespawner _starDespawner;

    //Interface to check if star goes off screen
    private IOffScreenCheck _starLoc;

    private void Awake()
    {
        _starDespawner = GetComponent<IDespawner>();

        _starLoc = GetComponent<IOffScreenCheck>();
    }

    void Update()
    {
        //If star goes off screen, despawn star
        if (_starLoc.IsOffScreen(transform))
        {
            _starDespawner.DespawnStar(transform);
        }
    }

}

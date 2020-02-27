using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Interface to despawn star
public interface IDespawner
{
    void DespawnStar(Transform objectToDespawn);
}

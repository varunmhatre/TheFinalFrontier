using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Interface to instatiate star
public interface IInstantiator
{
    List<GameObject> InstantiatorStars(GameObject star, int numStars, int size);
}

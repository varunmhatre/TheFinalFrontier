using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This implementation of IInstantiator pools the instantiated stars to allow for reuse of resources
public class StarPool : MonoBehaviour, IInstantiator
{
    //Create a star pool and returns the list of instantiated stars
    public List<GameObject> InstantiatorStars(GameObject star, int numStars, int size)
    {
        List<GameObject> stars = new List<GameObject>();
        for (int i = 0; i < numStars; i++)
        {
            GameObject obj = (GameObject)Instantiate(star);
            obj.transform.parent = transform;
            obj.transform.localScale = new Vector3(size, size, 1);
            stars.Add(obj);
        }

        return stars;
    }
}

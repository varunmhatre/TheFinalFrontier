using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This implementation of IDespawner simply move star back on screen with new values
public class MoveNearCenter : MonoBehaviour, IDespawner
{
    //Send star back on screen and reset speed of star
    public void DespawnStar(Transform objectToDespawn)
    {
        objectToDespawn.localPosition = new Vector3(UnityEngine.Random.Range(-Screen.width / 2, Screen.width / 2), UnityEngine.Random.Range(-Screen.height / 2, Screen.height / 2));
        GetComponent<StarMove>().SetStarSpeed();
    }

}

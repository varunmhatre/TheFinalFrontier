using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This implementation of IOffScreenCheck simply checks if the star is outside the bounds of the screen
public class WithinScreen : MonoBehaviour, IOffScreenCheck
{
    //Checks if object is off screen
    public bool IsOffScreen(Transform pos)
    {
        if (Mathf.Abs(pos.localPosition.x) > Screen.width / 2)
        {
            return true;
        }
        if (Mathf.Abs(pos.localPosition.y) > Screen.height / 2)
        {
            return true;
        }
        return false;
    }
}

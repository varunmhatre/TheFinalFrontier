using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Interface to check if star is off screen
public interface IOffScreenCheck
{
    bool IsOffScreen(Transform star);
}

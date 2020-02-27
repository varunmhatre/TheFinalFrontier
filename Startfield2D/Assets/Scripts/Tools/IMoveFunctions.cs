using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Interface to move star
public interface IMoveFunctions 
{
    Vector3 Move(Transform star, int speed);
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This implementation of IMoveFunctions move the star away from at a rate of d^2, where is the distance of the star from the center
public class ExponentialMove : MonoBehaviour, IMoveFunctions
{
    //Accelerate the star as it moves away from the center
    public Vector3 Move(Transform star, int speed)
    {
        float y = star.position.x * star.position.x + star.position.y * star.position.y;
        Vector2 pos2D = new Vector2(transform.position.x, transform.position.y).normalized;
        return new Vector3(pos2D.x, pos2D.y, 0) * y / speed;
    }
}

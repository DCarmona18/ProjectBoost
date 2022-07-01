using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Friendly Tag");
            break;
            case "Finish":
                Debug.Log("Finish Tag");
            break;
            case "Fuel":
                Debug.Log("Fuel Tag");
            break;
            default:
            break;
        }
    }
}

using UnityEngine;

public class ControllCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }
}

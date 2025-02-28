using UnityEngine;

public class ControllCollision : MonoBehaviour
{
    [SerializeField] GameObject destoyedVFX;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        Instantiate(destoyedVFX, transform.position, destoyedVFX.transform.rotation);
        Destroy(gameObject);
    }
}

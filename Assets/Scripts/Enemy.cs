using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destoyedVFX;
    private void OnParticleCollision(GameObject other)
    {
        Instantiate(destoyedVFX, transform.position, destoyedVFX.transform.rotation); //Quarternion.identity for spawn 000 rotation instead of the last arugment which is the parent objects rotation
        Destroy(this.gameObject);
    }
}

using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destoyedVFX;
    [SerializeField] int hitPoints = 6;
    [SerializeField] int scoreValue = 10;

    Scoreboard scoreboard;

    private void Start()
    {
        scoreboard = FindAnyObjectByType<Scoreboard>();
    }
    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        hitPoints--;

        if (hitPoints <= 0)
        {
            scoreboard.IncreaseScore(scoreValue);
            Instantiate(destoyedVFX, transform.position, destoyedVFX.transform.rotation); //Quarternion.identity for spawn 000 rotation instead of the last arugment which is the parent objects rotation
            Destroy(this.gameObject);
        }
    }
}

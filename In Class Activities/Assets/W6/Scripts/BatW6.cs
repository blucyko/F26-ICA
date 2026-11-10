using UnityEditor.Experimental.GraphView;
using UnityEditor.VersionControl;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : BatManager
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private GameObject _catPlayer;
    private bool isChasing = false;

    public void startChase()
    {
        isChasing = true;
        // Move towards the player
        Vector3 direction = (_catPlayer.transform.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
    public void stopChase()
    {
        isChasing = false;
    }
}

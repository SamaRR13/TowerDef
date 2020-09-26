using UnityEngine;

public class TowerTrigger : MonoBehaviour
{
    public Tower twr;
    public bool lockE;
    public GameObject curTarget;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemyBug") && !lockE)
        {
            twr.target = other.gameObject.transform;
            curTarget = other.gameObject;
            lockE = true;
        }
    }
    private void Update()
    {
        if (!curTarget)
        {
            lockE = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("enemyBug") && other.gameObject == curTarget)
        {
            lockE = false;
        }
    }
}


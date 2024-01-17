using System;
using UnityEngine;

public class ExplosinConponent : MonoBehaviour
{
    public float force = 20f;
    public float radius = 5f;
    public bool exploreInStart;

    private void Start()
    {
        if (exploreInStart) Explode();
    }

    public void Explode()
    {
        var colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (var currentCollider in colliders)
        {
            var currentRigidbody = currentCollider.GetComponent<Rigidbody>();
            if (currentRigidbody != null)
            {
                currentRigidbody.AddExplosionForce(force, transform.position, radius);
            }
        }
    }
}

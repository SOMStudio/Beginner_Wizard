using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    [Header("Components")]
    [SerializeField] private SpawnComponent spawnComponent;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spawnComponent.Spawn();
        }
    }
}

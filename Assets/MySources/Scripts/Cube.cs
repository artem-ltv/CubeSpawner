using UnityEngine;

public class Cube : MonoBehaviour
{
    private CubeSpawner _spawner;
    private float _distanceFromSpawner;

    private void Start() =>
        _spawner = FindObjectOfType<CubeSpawner>();
    

    private void Update()
    {
        if (Vector3.Distance(transform.position, _spawner.transform.position) > _distanceFromSpawner)
            Die();
    }

    private void Die() =>
        Destroy(gameObject);
    
    public void SetDistance(float distance) =>
        _distanceFromSpawner = distance;
}

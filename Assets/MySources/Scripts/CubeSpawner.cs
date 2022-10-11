using System.Collections;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private Cube _cube;
    [SerializeField] private ControlPanel _controlPanel;

    private float _speed = 1;
    private float _delaySpawn = 1;
    private float _distance = 1;

    private void Start() =>
        StartCoroutine(SpawnDelay());
    

    private IEnumerator SpawnDelay()
    {
        while (true)
        {
            yield return new WaitForSeconds(_delaySpawn);
            Cube newCube = Instantiate(_cube, transform.position, Quaternion.identity);
            newCube.SetDistance(_distance);

            CubeMovement newCubeMovement = newCube.GetComponent<CubeMovement>();
            newCubeMovement.SetMoveSpeed(_speed);
        }
    }

    private void OnEnable() =>
        _controlPanel.UpdatingValues += UpdateValuesForCube;
    

    private void OnDisable() =>
        _controlPanel.UpdatingValues -= UpdateValuesForCube;


    private void UpdateValuesForCube(float speed, float delaySpawn, float distance)
    {
        _speed = speed;
        _delaySpawn = delaySpawn;
        _distance = distance;
    }
}

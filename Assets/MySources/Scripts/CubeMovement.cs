using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    private float _moveSpeed;

    private void Update() =>
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);

    public void SetMoveSpeed(float speed) =>
        _moveSpeed = speed;
}

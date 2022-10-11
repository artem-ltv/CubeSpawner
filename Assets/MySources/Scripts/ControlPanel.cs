using UnityEngine;
using UnityEngine.Events;

public class ControlPanel : MonoBehaviour
{
    public event UnityAction<float, float, float> UpdatingValues;

    private float _speed = 1;
    private float _delaySpawn = 1;
    private float _distance = 1;

    public void ChangeSpeed(string value)
    {
        float.TryParse(value, out _speed);
        UpdatingValues?.Invoke(_speed, _delaySpawn, _distance);
        Debug.Log($"Speed {_speed}");
    }

    public void ChangeDelaySpawn(string value)
    {
        float.TryParse(value, out _delaySpawn);
        UpdatingValues?.Invoke(_speed, _delaySpawn, _distance);
        Debug.Log($"Delay {_delaySpawn}");
    }

    public void ChangeDistance(string value)
    {
        float.TryParse(value, out _distance);
        UpdatingValues?.Invoke(_speed, _delaySpawn, _distance);
        Debug.Log($"Distance {_distance}");
    }
}

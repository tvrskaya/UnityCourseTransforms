using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 10f;

    private void Update()
    {
        transform.Rotate(transform.up, _rotationSpeed * Time.deltaTime);
    }
}

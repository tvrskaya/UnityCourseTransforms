using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;

    private void Update()
    {
        transform.Translate(new Vector3(_moveSpeed * Time.deltaTime, 0, 0));
    }
}

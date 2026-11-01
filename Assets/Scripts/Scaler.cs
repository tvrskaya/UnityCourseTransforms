using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 10f;

    private void Update()
    {
        float scaleUpdate = _scaleSpeed * Time.deltaTime;
        transform.localScale += new Vector3(scaleUpdate, scaleUpdate, scaleUpdate);
    }
}

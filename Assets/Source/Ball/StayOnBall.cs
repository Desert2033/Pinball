using UnityEngine;

public class StayOnBall : MonoBehaviour
{
    [SerializeField] private float _constPositionY;

    [SerializeField] private Vector3 _constRotation;

    private Vector3 _constPosition;

    private void Start()
    {
        _constPosition = new Vector3(transform.position.x, _constPositionY, transform.position.z);
    }

    private void Update()
    {
        _constPosition.x = transform.position.x;

        _constPosition.z = transform.position.z;

        transform.localPosition = new Vector3(transform.position.x, _constPositionY, transform.position.z); ;

        transform.localRotation = Quaternion.Euler(_constRotation);
    }
}

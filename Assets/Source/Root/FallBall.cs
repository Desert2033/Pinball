using UnityEngine;

namespace Source
{
    public class FallBall : MonoBehaviour
    {
        private float _impactStrength = 1f;

        private void OnCollisionStay(Collision collision)
        {
            if (collision.transform.TryGetComponent<Rigidbody>(out Rigidbody rigidbody))
            {
                rigidbody.AddForce(Vector3.forward * _impactStrength, ForceMode.Impulse);
            }
        }
    }
}

using UnityEngine;

namespace Source {
    public class PlusBall : MonoBehaviour
    {
        [SerializeField] private Transform _pointStartBall;

        private BallSetup _ballSetup;

        private void Start()
        {
            _ballSetup = new BallSetup();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.TryGetComponent<BallView>(out BallView ballView))
            {
                _ballSetup.AddBall(_pointStartBall.position);
            }
        }

        private void OnDisable()
        {
            _ballSetup.OnDisableAll();
        }
    }
}

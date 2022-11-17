using UnityEngine;

namespace Source
{
    public class Stick : MonoBehaviour
    {
        [SerializeField] ClickMouseControl _clickMouseControl;

        [SerializeField] float _impactStrength;

        private Animation _thisAnimation;

        private bool _isMove = false;

        private void OnValidate()
        {
            if (_impactStrength == 0)
            {
                _impactStrength = 1;
            }
        }

        private void Start()
        {
            _thisAnimation = GetComponent<Animation>();
        }

        private void OnEnable()
        {
            _clickMouseControl.OnClick += MoveStick;
        }

        private void OnDisable()
        {
            _clickMouseControl.OnClick -= MoveStick;
        }

        public void MoveStick()
        {
            _thisAnimation.Play();
        }

        private void OnCollisionStay(Collision collision)
        {
            _isMove = _thisAnimation.isPlaying;

            if (collision.transform.TryGetComponent<Rigidbody>(out Rigidbody rigidbody) && _isMove)
            {
                rigidbody.AddForce(Vector3.forward * _impactStrength, ForceMode.Impulse);
            }
        }
    }
}

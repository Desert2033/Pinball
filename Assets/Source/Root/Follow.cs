using UnityEngine;

namespace Source
{
    public class Follow : MonoBehaviour
    {
        [SerializeField] private Transform _target;

        [SerializeField] private Vector3 _offset;

        private void OnValidate()
        {
            if (_offset == null)
            {
                _offset = new Vector3(0f, 0f, 0f);
            }
        }

        private void LateUpdate()
        {
            transform.position = _target.position + _offset;
        }

        public void SetTarget(Transform target)
        {
            _target = target;
        }
    }
}

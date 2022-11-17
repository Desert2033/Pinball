using UnityEngine;
using System;

namespace Source
{
    public class BallView : MonoBehaviour
    {        
        private Rigidbody _thisRigidbody;

        public Action<int> OnCollisionPointBonus;

        public int Points { get; set; }

        private void Start()
        {            
            _thisRigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            Move(-Vector3.forward);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.TryGetComponent<PointsBonus>(out PointsBonus pointsBonus))
            {
                OnCollisionPointBonus?.Invoke(pointsBonus.CountGivePoints);
            }
        }

        public void Move(Vector3 direction)
        {
            _thisRigidbody.AddForce(direction * 10f);
        }
    }
}

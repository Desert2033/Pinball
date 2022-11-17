using UnityEngine;
using System;

namespace Source
{
    public class FinishOfLevelView : MonoBehaviour
    {
        public event Action<int> OnCollisionBall;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.TryGetComponent<BallView>(out BallView ballView))
            {
                OnCollisionBall?.Invoke(ballView.Points);
            }
        }
    }
}

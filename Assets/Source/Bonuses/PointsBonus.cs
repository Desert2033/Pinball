using UnityEngine;
using TMPro;

namespace Source
{
    public class PointsBonus : MonoBehaviour
    {
        [SerializeField] private int _countGivePoints;
        public int CountGivePoints => _countGivePoints;

        [SerializeField] private TextMeshProUGUI _pointsText;

        [SerializeField] private TextMeshProUGUI _pointsTextGive;

        private Animation _pointsAnimationGive;

        private void Start()
        {
            _pointsText.text = $"{_countGivePoints}";

            _pointsTextGive.text = $"+{_countGivePoints}";

            _pointsAnimationGive = GetComponent<Animation>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.transform.TryGetComponent<BallView>(out BallView ballView)) 
            {
                _pointsAnimationGive.Play();
            }
        }
    }
}

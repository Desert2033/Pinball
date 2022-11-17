using UnityEngine;
using System;
using TMPro;

namespace Source
{
    public class GamePointsView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textViewPoint;

        public event Action OnAddPoints;

        public void SetPoints(int points)
        { 
            _textViewPoint.text = $"{points}";

            OnAddPoints?.Invoke();
        }
    }
}

using System;
using UnityEngine;

namespace Source
{
    public class ClickMouseControl : MonoBehaviour
    {
        public event Action OnClick;

        private void OnMouseDown()
        {
            OnClick?.Invoke();
        }
    }
}

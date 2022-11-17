using System;

namespace Source
{
    public class Ball
    {
        public int Points { get; private set; } = 0;

        public event Action OnAddPoints;

        public void AddPoints(int points)
        {
            Points += points;

            OnAddPoints?.Invoke();
        }
    }
}

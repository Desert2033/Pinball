using System;

namespace Source
{
    public class FinishOfLevel
    {
        public int Points { get; private set; }

        public event Action OnRemovePoints;

        public event Action OutOfPoints;

        public FinishOfLevel(int points)
        {
            Points = points;
        }

        public void RemovePoints(int points)
        {
            Points -= points;

            if (Points <= 0)
            {
                Points = 0;
                OutOfPoints?.Invoke();
            }

            OnRemovePoints?.Invoke();
        }
    }
}

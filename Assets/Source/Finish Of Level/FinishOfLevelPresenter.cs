namespace Source
{
    public class FinishOfLevelPresenter
    {
        private FinishOfLevel _finishOfLevelModel;

        private GamePointsView _pointsView;

        private FinishOfLevelView _finishOfLevelView;

        public FinishOfLevelPresenter(FinishOfLevel finishOfLevelModel, GamePointsView pointsView, FinishOfLevelView finishOfLevelView)
        {
            _finishOfLevelModel = finishOfLevelModel;

            _pointsView = pointsView;

            _finishOfLevelView = finishOfLevelView;
        }

        public void OnEnable()
        {
            ShowPoints();

            _finishOfLevelModel.OnRemovePoints += ShowPoints;

            _finishOfLevelView.OnCollisionBall += OnCollisionBall;
        }

        public void OnDisable()
        {
            _finishOfLevelModel.OnRemovePoints -= ShowPoints;

            _finishOfLevelView.OnCollisionBall -= OnCollisionBall;
        }

        public void ShowPoints()
        {
            _pointsView.SetPoints(_finishOfLevelModel.Points);
        }

        public void OnCollisionBall(int points)
        {
            _finishOfLevelModel.RemovePoints(points);
        }
    }
}

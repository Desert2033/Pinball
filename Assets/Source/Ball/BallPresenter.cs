namespace Source {
    public class BallPresenter
    {
        private Ball _ballModel;

        private GamePointsView _pointsView;

        private BallView _ballView;

        public BallPresenter(Ball ballModel, GamePointsView pointsView, BallView ballView)
        {
            _ballModel = ballModel;

            _pointsView = pointsView;

            _ballView = ballView;
        }

        public void OnEnable()
        {
            _ballModel.OnAddPoints += ShowPoints;

            _ballView.OnCollisionPointBonus += CollisionPointsBonus;

            _ballView.Points = _ballModel.Points;
        }

        public void OnDisable()
        { 
            _ballModel.OnAddPoints -= ShowPoints;

            _ballView.OnCollisionPointBonus -= CollisionPointsBonus;
        }

        public void ShowPoints()
        {
            _pointsView.SetPoints(_ballModel.Points);
        }

        public void CollisionPointsBonus(int points)
        {
            _ballModel.AddPoints(points);

            _ballView.Points = _ballModel.Points;
        }
    }
}

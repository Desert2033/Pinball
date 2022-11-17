using System.Collections.Generic;
using UnityEngine;

namespace Source {
    public class BallSetup
    {
        private List<BallPresenter> _balls;

        public BallSetup()
        {
            _balls = new List<BallPresenter>();
        }

        public void AddBall(Vector3 pointStart)
        {
            GameObject ballGameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Ball/Ball"));

            GameObject gamePointsObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Ball/Game Points"));

            GamePointsView pointsView = gamePointsObject.GetComponentInChildren<GamePointsView>();

            Follow followPoints = gamePointsObject.GetComponentInChildren<Follow>();

            followPoints.SetTarget(ballGameObject.transform);

            ballGameObject.transform.position = pointStart;

            BallView ballView = ballGameObject.GetComponentInChildren<BallView>();

            Ball ballModel = new Ball();

            BallPresenter ballPresenter = new BallPresenter(ballModel, pointsView, ballView);

            ballPresenter.OnEnable();

            _balls.Add(ballPresenter);
        }

        public void OnDisableAll()
        {
            foreach (var ball in _balls)
            {
                ball.OnDisable();
            }
        }
    }
}

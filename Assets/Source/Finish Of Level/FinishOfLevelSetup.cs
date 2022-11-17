using UnityEngine;

namespace Source
{
    public class FinishOfLevelSetup
    {
        private FinishOfLevelView _finishOfLevelView;

        private GamePointsView _pointsView;

        private FinishOfLevelPresenter _finishOfLevelPresenter;

        private FinishOfLevel _finishOfLevelModel;
        public FinishOfLevel FinishOfLevelModel => _finishOfLevelModel;

        private int _pointsForFinish;

        public FinishOfLevelSetup(int pointsForFinish)
        {
            _pointsForFinish = pointsForFinish;
        }

        public void OnEnable()
        {
            GameObject finishOfLevel = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Finish Of Level"));

            _finishOfLevelView = finishOfLevel.GetComponent<FinishOfLevelView>();

            _pointsView = finishOfLevel.GetComponentInChildren<GamePointsView>();

            _finishOfLevelModel = new FinishOfLevel(_pointsForFinish);

            _finishOfLevelPresenter = new FinishOfLevelPresenter(_finishOfLevelModel, _pointsView, _finishOfLevelView);

            _finishOfLevelPresenter.OnEnable();
        }

        public void OnDisable()
        {
            _finishOfLevelPresenter.OnDisable();
        }

        public void OnDestroy()
        {
            OnDisable();
            MonoBehaviour.Destroy(_finishOfLevelView.gameObject);
        }
    }
}
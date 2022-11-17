using System.Collections;
using UnityEngine;

namespace Source {
    public class Level : MonoBehaviour
    {
        [SerializeField] private Transform _ballStartPoint;

        [SerializeField] private int _pointsForFinish;

        [SerializeField] private ParticleSystem _winStars;

        private BallSetup _ballSetup;

        private FinishOfLevelSetup _finishOfLevelSetup;

        private Game _game;

        private void OnEnable()
        {
            _game = FindObjectOfType<Game>();

            _finishOfLevelSetup = new FinishOfLevelSetup(_pointsForFinish);

            _ballSetup = new BallSetup();

            _finishOfLevelSetup.OnEnable();

            _finishOfLevelSetup.FinishOfLevelModel.OutOfPoints += EndLevel;

            _ballSetup.AddBall(_ballStartPoint.position);
        }

        private void OnDisable()
        {
            _finishOfLevelSetup.OnDisable();

            _ballSetup.OnDisableAll();
        }

        public void EndLevel()
        {
            _finishOfLevelSetup.OnDestroy();

            _winStars.Play();

            StartCoroutine(WaitAfterNexLevel());
        }

        public IEnumerator WaitAfterNexLevel()
        {
            yield return new WaitForSeconds(1f);

            _game.LoadNextLevel();
        }
    }
}
    

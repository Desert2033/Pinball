using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Source {
    public class Game : MonoBehaviour
    {
        private List<string> _levelsScene;

        private string _currentLevelScene;

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void Start()
        {
            _levelsScene = new List<string>();

            _levelsScene.Add("Level 1");

            _levelsScene.Add("Level 2");

            InitLevel(0);
        }

        private void InitLevel(int index)
        {
            _currentLevelScene = _levelsScene[index];

        }

        public void LoadNextLevel()
        {
            int indexNewLevel = _levelsScene.IndexOf(_currentLevelScene) + 1;

            indexNewLevel = indexNewLevel < _levelsScene.Count ? indexNewLevel : 0;

            _currentLevelScene = _levelsScene[indexNewLevel];

            SceneManager.LoadScene(_currentLevelScene);
        }
    }
}

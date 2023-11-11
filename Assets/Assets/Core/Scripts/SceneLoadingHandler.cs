using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public class SceneLoadingHandler : MonoBehaviour
    {
        [SerializeField]
        private SceneContext _sceneContext;
        private void OnEnable()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
        {
            if (scene.name == nameof(SceneConstants.LoadingScene))
            {
                var loadingSceneController = new LoadingSceneController(_sceneContext);
                loadingSceneController.Init();
            }
        }
    }
}
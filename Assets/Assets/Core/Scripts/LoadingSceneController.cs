using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public class LoadingSceneController
    {
        private LoadingSceneView _loadingSceneView;
        private readonly SceneContext _sceneContext;

        public LoadingSceneController(SceneContext sceneContext)
        {
            _sceneContext = sceneContext;
        }
        public void Init()
        {
            _loadingSceneView = Object.Instantiate(_sceneContext._loadingSceneViewPrefab, _sceneContext._loadingSceneContainer);
            WaitingForDataIsLoadedAndOpenGameScene().Forget();
        }

        private async UniTask WaitingForDataIsLoadedAndOpenGameScene()
        {
            await UniTask.Delay(5000);
            await SceneManager.LoadSceneAsync(nameof(SceneConstants.GameScene));
        }
        
    }
}
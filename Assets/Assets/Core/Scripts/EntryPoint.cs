using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public class EntryPoint : MonoBehaviour
    {
        private void Start()
        {
            SceneManager.LoadScene(nameof(SceneConstants.LoadingScene));
        }
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RPG.SceneManagement
{
    public class Portal : MonoBehaviour
    {
        [SerializeField] private int _sceneToLoad = -1;

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.tag == "Player")
            {
                SceneManager.LoadScene(_sceneToLoad);
            }
        }
    }
}

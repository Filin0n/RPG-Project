using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

namespace RPG.SceneManagement
{
    public class Portal : MonoBehaviour
    {
        

        [SerializeField] private int _sceneToLoad = -1;
        [SerializeField] private Transform spawnPoint;

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.tag == "Player")
            {
                StartCoroutine(Transition());
            }
        }

        private IEnumerator Transition()
        {
            DontDestroyOnLoad(gameObject);
            yield return SceneManager.LoadSceneAsync(_sceneToLoad);

            Portal otherPortal = GetOtherPortal();
            UpdatePlayer(otherPortal);

            Destroy(gameObject);
        }

        private void UpdatePlayer(Portal otherPortal)
        {
            Transform player = GameObject.FindWithTag("Player").transform;
            player.GetComponent<NavMeshAgent>().Warp(otherPortal.spawnPoint.position);
            player.rotation = otherPortal.spawnPoint.rotation;
        }

        private Portal GetOtherPortal()
        {
            foreach (Portal portal in FindObjectsOfType<Portal>())
            {
                if (portal == this) continue;

                return portal;
            }
            return null;
        }
    }
}

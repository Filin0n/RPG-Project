﻿using System.Collections;
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
                StartCoroutine(Transition());
            }
        }

        private IEnumerator Transition()
        {
            DontDestroyOnLoad(gameObject);
            yield return SceneManager.LoadSceneAsync(_sceneToLoad);

            print("Scene Loaded");
            Destroy(gameObject);
        }
    }
}

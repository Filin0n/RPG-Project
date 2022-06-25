using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace RPG.Cinematics
{
    public class SinematicTrigger : MonoBehaviour
    {
        private bool _alredyTriggered = false;

        private void OnTriggerEnter(Collider collider) 
        {
            if (collider.tag == "Player" && !_alredyTriggered)
            {
                _alredyTriggered = true;
                GetComponent<PlayableDirector>().Play();
            }
        }
    }
}

﻿using System;
using UnityEngine;
using UnityEngine.Playables;

namespace RPG.Cinematics
{
    internal class CinematicControlRemover : MonoBehaviour
    {
        private void Start() 
        {
            GetComponent<PlayableDirector>().played += DisableControl;
            GetComponent<PlayableDirector>().stopped += EnableControl;
        }

        private void DisableControl(PlayableDirector pd)
        {
            print("DisableControl");
        }

        private void EnableControl(PlayableDirector pd)
        {
            print("EnableControl");
        }
    }
}


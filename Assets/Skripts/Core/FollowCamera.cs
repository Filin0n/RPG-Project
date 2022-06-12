using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core 
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] private Transform _target;

        private void LateUpdate()
        {
            if (_target != null)
            {
                transform.position = _target.position;
            }
        }
    }
}
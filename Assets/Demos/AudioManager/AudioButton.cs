using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CyberBuggy
{
    public class AudioButton : MonoBehaviour
    {
        [SerializeField] private AudioEvent _audioEvent;
        [SerializeField] private AudioSource _audioSource;
        public void OnClick()
        {
            _audioEvent.Play(_audioSource);
        }
    }
}

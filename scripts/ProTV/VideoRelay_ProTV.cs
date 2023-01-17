
using UdonSharp;
using UnityEngine;
using VRC.Udon;
using ArchiTech;
using YesVRC;

namespace YesVRC.AudioObjects
{
    public class VideoRelay_ProTV : UdonSharpBehaviour
    {
        [SerializeField] private TVManagerV2 _videoPlayer;

        private void OnTriggerEnter(Collider other)
        {
            Audio_Holder obj = (Audio_Holder)other.gameObject.GetComponent(typeof(UdonBehaviour));
            if (obj)
            {
                _videoPlayer.activeManager.player.PlayURL(obj.url);
            }
        }
    }
}


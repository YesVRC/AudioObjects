
using UdonSharp;
using UdonSharp.Video;
using UnityEngine;
using VRC.Udon;

namespace YesVRC.AudioObjects
{
    public class VideoRelay_USharpVideo : UdonSharpBehaviour
    {
        [SerializeField] private USharpVideoPlayer _videoPlayer;

        private void OnTriggerEnter(Collider other)
        {
            Audio_Holder obj = (Audio_Holder)other.gameObject.GetComponent(typeof(UdonBehaviour));
            if (obj)
            {
                _videoPlayer.PlayVideo(obj.url);
            }
        }
    }
}


using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

namespace YesVRC.AudioObjects
{
   public class Audio_Holder : UdonSharpBehaviour
   {
      [UdonSynced] public VRCUrl url;
      public Texture2D image;
   }
}

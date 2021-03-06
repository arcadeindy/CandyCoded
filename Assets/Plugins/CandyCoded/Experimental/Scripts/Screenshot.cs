using System;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace CandyCoded.Experimental
{

    public static class Screenshot
    {

        private static readonly DateTime epoch = new DateTime(1970, 1, 1);

        private static int GetTimestamp()
        {

            return (int)(DateTime.UtcNow - epoch).TotalSeconds;

        }

#if UNITY_EDITOR
        [MenuItem("Window/CandyCoded/Save Screenshot")]
#endif
        public static void SaveNormalResolutionImage()
        {

            Save(1);

        }

#if UNITY_EDITOR
        [MenuItem("Window/CandyCoded/Save Screenshot @ 2x")]
#endif

        public static void SaveHighResolutionImage()
        {

            Save(2);

        }

        public static void Save(int ratio)
        {

            var filename = string.Format("{0}/{1}.png", Application.persistentDataPath, GetTimestamp());

            ScreenCapture.CaptureScreenshot(filename, ratio);

            Debug.Log(string.Format("Saved screenshot to {0}", filename));

        }

    }

}

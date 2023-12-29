using MelonLoader;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TestMod
{
    public static class BuildInfo
    {
        public const string Name = "TestMod"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Mod for Testing"; // Description for the Mod.  (Set as null if none)
        public const string Author = "TestAuthor"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class TestMod : MelonMod
    {
        public GameObject mainCam = null;
        public override void OnInitializeMelon() {
            MelonLogger.Msg("OnApplicationStart");
        }

        public override void OnLateInitializeMelon() // Runs after OnApplicationStart.
        {
            MelonLogger.Msg("OnApplicationLateStart");
        }

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            MelonLogger.Msg("OnSceneWasLoaded: " + buildindex.ToString() + " | " + sceneName);
        }

        public override void OnSceneWasInitialized(int buildindex, string sceneName) // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
        {
            MelonCoroutines.Start(FindHeadsetObject());
            mainCam = GameObject.Find("Headset");
            
            MelonLogger.Msg("OnSceneWasInitialized: " + buildindex.ToString() + " | " + sceneName);
            
        }

        private IEnumerator FindHeadsetObject()
        {
            while (true)
            {
                mainCam = GameObject.Find("Headset");
                if (mainCam != null)
                {
                    Debug.Log("Main cam is not null, this is good.");
                    break;
                }
                else
                {
                    Debug.Log("Main cam is null, waiting for it...");
                }
                yield return mainCam;
            }
            Camera cameraComponent = mainCam.GetComponent<Camera>();
            if (SceneManager.GetActiveScene().name == "Gym" || SceneManager.GetActiveScene().name == "Park")
            {
                if (cameraComponent != null)
                {
                    cameraComponent.fieldOfView = 120f;
                    Debug.Log("FOV set to 120.");
                }
                else
                {
                    Debug.Log("Camera component not found on Main cam.");
                }
            }
            else
            {
                if (cameraComponent != null)
                {
                    cameraComponent.fieldOfView = 87.9547f;
                    Debug.Log("FOV set to 87.9547 (defualt)");
                }
                else
                {
                    Debug.Log("Camera component not found on Main cam.");
                }
            }
        }

        public override void OnSceneWasUnloaded(int buildIndex, string sceneName) {
            MelonLogger.Msg("OnSceneWasUnloaded: " + buildIndex.ToString() + " | " + sceneName);
        }

        public override void OnUpdate() // Runs once per frame.
        {
            
        }

        public override void OnFixedUpdate() // Can run multiple times per frame. Mostly used for Physics.
        {
            
        }

        public override void OnLateUpdate() // Runs once per frame after OnUpdate and OnFixedUpdate have finished.
        {
            
        }

        public override void OnGUI() // Can run multiple times per frame. Mostly used for Unity's IMGUI.
        {
            
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            
        }

        public override void OnPreferencesSaved() // Runs when Melon Preferences get saved.
        {
            
        }

        public override void OnPreferencesLoaded() // Runs when Melon Preferences get loaded.
        {
            
        }
    }
}
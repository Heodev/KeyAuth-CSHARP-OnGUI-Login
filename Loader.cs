using Facebook.WitAi;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Example
{
    public class MyLoader
    {
        private static void Init()
        {
            load = new GameObject();
            load.AddComponent<Gui>();
            UnityEngine.Object.DontDestroyOnLoad(load);
        }

        private static void Unload()
        {
            UnityEngine.Object.Destroy(load);
        }

        private static GameObject load;
    }
}
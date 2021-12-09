using System;
using UnityEngine;

namespace UnityVrBase
{
    public class Bootstrap : MonoBehaviour
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Init()
            //private void Awake()
            //private void Start()
        {
            Debug.unityLogger.logHandler = new UnityDebugLogHandler();

            Debug.Log("[Bootstrap] - Init");
            Debug.Log("[Bootstrap] - Application.dataPath:" + Application.dataPath);
            Debug.Log("[Bootstrap] - Application.persistentDataPath:" + Application.persistentDataPath);
        }

        private void Awake()
        {
            Debug.Log("[Bootstrap] - Awake");
        }

        private void Start()
        {
            Debug.Log("[Bootstrap] - Start");
        }
        
    }
}
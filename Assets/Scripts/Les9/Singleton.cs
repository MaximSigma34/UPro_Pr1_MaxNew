using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour  where T : MonoBehaviour 
{
    public static bool isApplicationQuit;
    private static T _instance;
    private static System.Object _Lock = new System.Object();

    public static T Instance
    {
        get
        {
            if (isApplicationQuit)
                return null;
            lock (_Lock)
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();
                    if(_instance == null)
                    {
                        var singleton = new GameObject("[Singleton]" + typeof(T));
                        _instance = singleton.AddComponent<T>();
                        DontDestroyOnLoad(_instance);
                    }
                }

                return _instance;
            }
        }
    }

    public virtual void OnDestroy()
    {
        isApplicationQuit = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (!instance)
                instance = FindObjectOfType<T>();
            return instance;
        }
    }

    protected virtual void Awake()
    {
        if (!instance)
            instance = (T) this;
        else
            Destroy(this);
    }
}

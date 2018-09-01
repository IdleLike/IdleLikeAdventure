using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable][CreateAssetMenu]
public class TestDB : ScriptableObject {

    private static TestDB instance;
    public static TestDB Instance
    {
        get
        {
            if (instance == null)
            {
                instance = Resources.Load<TestDB>("TestDB");
            }
            return instance;
        }
    }





}

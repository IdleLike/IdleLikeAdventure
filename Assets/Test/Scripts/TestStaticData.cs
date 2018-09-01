using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable][CreateAssetMenu]
public class TestStaticData : ScriptableObject {

    private static TestStaticData instance;
    public static TestStaticData Instance
    {
        get
        {
            if (instance == null)
            {
                instance = Resources.Load<TestStaticData>("TestData");
            }
            return instance;
        }
    }





}

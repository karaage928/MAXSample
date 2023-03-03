using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAXAdManager : MonoBehaviour
{

    void Start()
    {

        MaxSdk.SetSdkKey("knMndr37VXt9r8cc1CGq-6yn-iHfV1UUeb0Lthboe2rznMROtaspsHs4pAAWs425bl-hRT7D9KBG8Z1nZ-_sSH");
        MaxSdk.InitializeSdk();

        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) => {
            Debug.Log("MAX Initialized.");
        };

    }

}
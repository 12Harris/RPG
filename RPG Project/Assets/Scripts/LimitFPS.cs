using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitFPS : MonoBehaviour
{
   private int _targetFrameRate = 60;
   void Awake()
   {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = _targetFrameRate;
   }

   void Update()
   {
        if(Application.targetFrameRate != _targetFrameRate)
        {
            Application.targetFrameRate = _targetFrameRate;
        }
   }
}

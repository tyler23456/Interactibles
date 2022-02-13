using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

using GDA.Interfaces;

namespace GDA.Interactibles.UserCameraSettings
{
    public class CameraSettings : MonoBehaviour, ICameraSettings
    {
        CinemachineVirtualCamera camVirtual;

        public int getFOV
        {
            get { return (int)camVirtual.m_Lens.FieldOfView; }
        }

        void Start()
        {
            camVirtual = Camera.main.GetComponent<CinemachineBrain>().ActiveVirtualCamera.VirtualCameraGameObject.GetComponent<CinemachineVirtualCamera>();
        }

        public void SetFOV(float value)
        {
            camVirtual.m_Lens.FieldOfView = value;
        }
    }
}
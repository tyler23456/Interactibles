using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDA.Interfaces
{
    public interface ICameraSettings
    {
        int getFOV { get; }

        void SetFOV(float value);
    }
}
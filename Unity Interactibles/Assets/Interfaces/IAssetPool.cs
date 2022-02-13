using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDA.Interfaces
{
    public interface IAssetPool
    {
        Dictionary<string, GameObject> abilities { get; }
        Dictionary<string, GameObject> hitFX { get; }

        GameObject[] players { get; }
        GameObject[] spawners { get; }

        AudioClip[] leftWalkSteps { get; }
        AudioClip[] rightWalkSteps { get; }
        AudioClip[] leftSprintSteps { get; }
        AudioClip[] rightSprintSteps { get; }

        AudioClip[] meleeHits { get; }
        AudioClip[] abilityHits { get; }
        Dictionary<string, AudioClip> menuFX { get; }
    }
}

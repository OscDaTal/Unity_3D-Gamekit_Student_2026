using UnityEngine;
using FMOD.Studio;
using FMODUnity;

[CreateAssetMenu(fileName = "InteractableAudio", menuName = "Scriptable Objects/InteractableAudio")]
public class InteractableAudio : ScriptableObject
{
    [SerializeField] private EventReference pickupHealth, boxDestroyAudio, doorAudio;

    public void PickupHealthPlay()
    {
        RuntimeManager.PlayOneShot(pickupHealth);
    }
    
    public void BoxDestroyPlay(Transform objectTransform)
    {
        RuntimeManager.PlayOneShot(boxDestroyAudio, objectTransform.position);
    }
}
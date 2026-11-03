using UnityEngine;

public class SurvivalMod : MonoBehaviour
{
    [SerializeField]
    float thirstLevel = 100f;

    [SerializeField] private float thirstRate = 0.001f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        thirstLevel -= thirstRate * Time.deltaTime;
    }
}

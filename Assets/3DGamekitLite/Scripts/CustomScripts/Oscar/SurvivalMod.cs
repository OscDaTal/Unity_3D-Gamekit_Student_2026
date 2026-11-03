using System;
using UnityEngine;

public class SurvivalMod : MonoBehaviour
{
    [SerializeField]
    private float thirstLevel = 100f;
    [SerializeField]
    private float thirstRate = 1f;

    [SerializeField] private GameObject playerObject;

    private bool thirsty = false;
    private bool parched = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        thirstLevel -= Mathf.Clamp(thirstRate * Time.deltaTime, 0f, thirstLevel);
        if (thirstLevel <= 50f && !thirsty)
        {
            Debug.Log("Im getting thirsty👅👅👅👅");
            thirsty = true;
        } else if (thirstLevel <= 15f && !parched)
        {
            Debug.Log("*golly gee willikers, it seems like im dying of thirst*");
            parched = true;
        }
    }
}

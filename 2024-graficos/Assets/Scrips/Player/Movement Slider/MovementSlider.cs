using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementSlider : MonoBehaviour
{
    [SerializeField] string player;
    [SerializeField] Slider mainSlider;

    void Awake()
    {
        Debug.Log("Value in slider is : " + PlayerPrefs.GetFloat(player));

        mainSlider.value = PlayerPrefs.GetFloat(player);
    }

    public void Update()
    {
        PlayerPrefs.SetFloat(player, mainSlider.value);
    }
}

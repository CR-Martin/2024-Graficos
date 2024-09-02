using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MovementSlider : MonoBehaviour
{
    [SerializeField] string player;
    [SerializeField] Slider mainSlider;
    [SerializeField] TMP_Text text;
    void Awake()
    {

        mainSlider.value = PlayerPrefs.GetFloat(player);
        text.text = "player speed: " + PlayerPrefs.GetFloat(player).ToString();
    }

    public void Update()
    {
        PlayerPrefs.SetFloat(player, mainSlider.value);
        text.text = "player speed: " + PlayerPrefs.GetFloat(player).ToString();

    }
}

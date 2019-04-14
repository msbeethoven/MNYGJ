using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIExperience : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerData;

    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = playerData.PlayerExperience.ToString();
    }
}

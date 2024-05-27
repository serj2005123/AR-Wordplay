using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabIconsChanged : MonoBehaviour
{

    [SerializeField] Sprite OffSprite;

    Toggle toggle;
    Image DefaultImage;
    Sprite DefaultSprite;
    void Awake()
    {
        toggle = GetComponent<Toggle>();

        DefaultImage = toggle.GetComponent<Image>();

        DefaultSprite = DefaultImage.sprite;

        toggle.onValueChanged.AddListener(OnSwitch);

        if (toggle.isOn)
            OnSwitch(true);
    }
    void OnSwitch(bool on)
    {
        DefaultImage.sprite = (on ? DefaultSprite : OffSprite);
    }

    void OnDestroy()
    {
        toggle.onValueChanged.RemoveListener(OnSwitch);

    }

}
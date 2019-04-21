using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceSelection : MonoBehaviour
{

    public Image _avatarImage;
    public Button _prevButton, _nextButton;

    public AvatarSprites _sprites;

    public int startIndex = 0;
    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        _avatarImage.sprite = _sprites.Avatars[startIndex];
        SetCurrentIndex(startIndex);
        _prevButton.onClick.AddListener(OnPreviousClick);
        _nextButton.onClick.AddListener(OnNextClick);
    }

    private void OnPreviousClick()
    {
        int newIndex = currentIndex - 1;
        if (newIndex < 0){
            newIndex = _sprites.Avatars.Length - 1;
        }
        SetCurrentIndex(newIndex);
        _avatarImage.sprite = _sprites.Avatars[currentIndex];
    }

    private void OnNextClick()
    {
        int newIndex = currentIndex + 1;
        if (newIndex > _sprites.Avatars.Length - 1){
            newIndex = 0;
        }
        SetCurrentIndex(newIndex);
        _avatarImage.sprite = _sprites.Avatars[currentIndex];
    }

    private void SetCurrentIndex (int newCurrentIndex){
        currentIndex = newCurrentIndex;

        PlayerPrefs.SetInt("AvatarIndex", currentIndex);
    }

}


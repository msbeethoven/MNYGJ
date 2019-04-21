using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCurrentAvatar : MonoBehaviour
{
  // Start is called before the first frame update
  public int currentAvatarIndex;

  public Image _avatarImage;
  public AvatarSprites _sprites;
  void Start()
  {
    currentAvatarIndex = PlayerPrefs.GetInt("AvatarIndex");
    DisplayAvatar();

  }

  public void DisplayAvatar()
  {
    _avatarImage.sprite = _sprites.Avatars[currentAvatarIndex];
  }


}

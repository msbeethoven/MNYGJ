using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Avatar Sprite", menuName = "Faces", order = 53)]
public class AvatarSprites : ScriptableObject
{
    [SerializeField]
    private Sprite [] avatars;

    public Sprite[] Avatars
    {
        get
        {
            return avatars;
        }
    }
}

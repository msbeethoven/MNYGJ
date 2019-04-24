using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    private BoxCollider2D _collider;

    public bool CanMove
    { 
        get
        {
            Collider2D[] colliders = new Collider2D[10];
            _collider.OverlapCollider(new ContactFilter2D().NoFilter(), colliders);
            foreach (Collider2D overlappingCollider in colliders)
            {
                if (overlappingCollider != null && overlappingCollider.tag == "Impassable")
                {
                    return false;
                }
            }
            return true;
        }
    }

    private void Awake()
    {
        _collider = GetComponent<BoxCollider2D>();
    }
}

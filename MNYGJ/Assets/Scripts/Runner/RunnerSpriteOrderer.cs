using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class RunnerSpriteOrderer : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer = null;

    private void Reset()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Vector3 position = transform.position;
        float y = position.y;
        _spriteRenderer.sortingOrder = -Mathf.RoundToInt(y * 100);
    }
}

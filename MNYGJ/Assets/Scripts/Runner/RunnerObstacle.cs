using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class RunnerObstacle : MonoBehaviour
{
    [SerializeField]
    private Transform _playerTransform = null;

    [SerializeField]
    private SpriteRenderer _spriteRenderer = null;

    [SerializeField]
    private int _inFrontOfCharacterSortingOrder = 11, _behindCharacterSortingOrder = 9;

    private void Reset()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _playerTransform = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        Vector3 position = transform.position,
        playerPosition = _playerTransform.position;

        _spriteRenderer.sortingOrder = position.y < playerPosition.y ? _inFrontOfCharacterSortingOrder : _behindCharacterSortingOrder;
    }
}

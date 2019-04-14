using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
  public float moveSpeed = 3f;
  public float counter = 0;
  public float moveForce = 10f;
  private bool isMoving = false;
  public Vector2 endPosition;
  public Vector2 startPosition;
  private new Rigidbody2D rigidbody;

  // Start is called before the first frame update

  void Start()
  {
    rigidbody = GetComponent<Rigidbody2D>();

  }

  // Update is called once per frame
  void Update()
  {

    if (!isMoving)
    {

      if (Input.GetButtonDown("Jump"))
      {
        StartCoroutine("MoveForward");
        counter++;

        if (counter % 2 != 0)
        {
          StopCoroutine("MoveForward");
          isMoving = false;

        }

      }

    }
  }


  private IEnumerator MoveForward()
  {
    isMoving = true;
    // Touch touch = Input.GetTouch(1);

    // Debug.Log(touch.position);
    transform.Translate(Vector3.up * 20 * Time.deltaTime);

    yield return new WaitForSeconds(.1f);
    isMoving = false;
    yield return null;
  }

}

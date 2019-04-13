using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
  public float moveSpeed = 3f;

  public float counter = 0;
  public float moveForce = 10f;
  private bool isMoving = false;

  private bool shouldLerp = false;

  public float timeStartedLerping;
  public float lerpTime;
  public Vector2 endPosition;
  public Vector2 startPosition;
  private Rigidbody2D rigidbody;


  private void StartLerping()
  {
    timeStartedLerping = Time.time;
    shouldLerp = true;

  }
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
          Debug.Log("ya");
          StopCoroutine("MoveForward");
          isMoving = false;
          
        }

      }

    }
  }

  public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime = 1)
  {

    float timeSinceStarted = Time.time - timeStartedLerping;

    float percentageComplete = timeSinceStarted / lerpTime;

    var result = Vector3.Lerp(start, end, percentageComplete);
    return result;

    transform.position = Lerp(startPosition, endPosition, timeStartedLerping, lerpTime);

  }

  private IEnumerator MoveForward()
  {
    isMoving = true;
    //rigidbody.AddForce(new Vector2(10f, moveForce));
    transform.Translate(Vector3.up * 10 * Time.deltaTime);

    yield return new WaitForSeconds(.1f);
    isMoving = false;
    yield return null;
  }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour

{
  // Start is called before the first frame update
  private BoxCollider2D boxcoll;
  private float backgroundsize;


  void Start()
  {
      boxcoll = GetComponent<BoxCollider2D>();
      backgroundsize = boxcoll.size.y;
  }

  // Update is called once per frame
  void Update()
  {
      if(transform.position.y < -backgroundsize){
          RepeatBackground();
      }

  }

  void RepeatBackground(){
      Vector2 BGOffset = new Vector2(0, backgroundsize * 2f);
      transform.position = (Vector2)transform.position + BGOffset;
      //Vector2 BGOffset = new Vector2(0, backgroundsize * 2f * this.transform.localScale.y);
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimate : MonoBehaviour
{
  public void getAnimatorWalking()
    {
        this.GetComponent<Animator>().Play("1");
    }
  public void getAnimatorDance()
    {
        this.GetComponent<Animator>().Play("2");
    }
}

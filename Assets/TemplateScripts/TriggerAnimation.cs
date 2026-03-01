using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    /**
     * This script triggers the animation when it's used with GazeOverEvent.cs
     * 
     */

    [SerializeField] private Animator myAnimationController;

    void Start()
    {
        myAnimationController.SetBool("playAnim", false);
    }

    //Start the animation when hover starts
    public void playAnimation()
    {
        myAnimationController.SetBool("playAnim", true);
    }

    //Stop the animation when hover ends
    public void stopAnimation()
    {
        myAnimationController.SetBool("playAnim", false);
    }
}

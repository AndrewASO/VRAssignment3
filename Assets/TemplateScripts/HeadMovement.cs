using UnityEngine;

public class HeadMovement : MonoBehaviour {

    public float tiltThreshold = 30f;   //Degrees down to trigger movement
    public float movSpd = 2f;          //How fast the playerRoot would move
    public Transform playerRoot;       //Object containing the main camera since main camera can't be moved

    // Update is called once per frame
    void Update() {
        //Get camera forward direction
        Vector3 camForward = Camera.main.transform.forward;

        //Project onto horizontal plane (ignoring y so there isn't vertical movement)
        Vector3 horizontalForward = Vector3.ProjectOnPlane(camForward, Vector3.up).normalized;

        //Computing downward angle: 0 would be looking straight ahead, and positive would be looking down
        float downAngle = Vector3.SignedAngle(horizontalForward, camForward, -Camera.main.transform.right);
        //Signed angle gives positive when looking down since -right is used as an axis

        //Check to see if downAngle goes beyond the tiltThreshold
        if(downAngle > tiltThreshold ) {
            //Move player root in the horizontal forward direction
            Vector3 move = horizontalForward * movSpd * Time.deltaTime;
            playerRoot.Translate(move, Space.World);
        }
    }
}

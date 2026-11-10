using UnityEngine;

public class RobotStartButton : MonoBehaviour
{
    public RobotController robotController;

    public void StartRobot()
    {
        if (robotController == null)
            return;

        robotController.StartRobot();

        enabled = false;
    }
}
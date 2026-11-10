using UnityEngine;

public class StartZone : MonoBehaviour
{
    [Header("Робот")]
    public Rigidbody robotRigidbody;

    [Header("Точки крепления")]
    public RobotMountPoint headMountPoint;
    public RobotMountPoint bodyMountPoint;

    [Header("Управление")]
    public RobotController robotController;

    private bool activated = false;

    private void OnTriggerStay(Collider other)
    {
        if (activated)
            return;

        // Проверяем, что в зоне находится наш робот
        if (other.attachedRigidbody != robotRigidbody)
            return;

        // Проверяем установку деталей
        bool headInstalled = headMountPoint.IsOccupied;
        bool bodyInstalled = bodyMountPoint.IsOccupied;

        if (headInstalled && bodyInstalled)
        {
            
            robotController.enabled = true;
            activated = true;
        }
    }
}
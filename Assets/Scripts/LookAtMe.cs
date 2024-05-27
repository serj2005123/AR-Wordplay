using UnityEngine;

public class LookAtMe : MonoBehaviour
{
    Transform cameraTrasnf;

    public Transform[] lookPoints;
    float damping;

    void Start()
    {
        damping = 0.5f;
        cameraTrasnf = Camera.main.transform;
    }

    void Update()
    {

        foreach (Transform tr in lookPoints)
        {
            var lookPos = cameraTrasnf.position - tr.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(-lookPos);
            tr.rotation = Quaternion.Slerp(tr.rotation, rotation, damping);
        }

    }
}

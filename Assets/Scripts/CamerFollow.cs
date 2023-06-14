using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject leftBounds;
    [SerializeField] GameObject rightBounds;


    public float smoothDampTime = 0.15f;
    private Vector3 smoothDampVelocity = Vector3.zero;
    private float cameraWidth, cameraHeight, levelMinX, levelMaxX;
    // Start is called before the first frame update
    void Start()
    {
        cameraHeight = Camera.main.orthographicSize * 2;
        cameraWidth = cameraHeight * Camera.main.aspect;

        float leftBoundsWidth = leftBounds.transform.GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2;
        float rightBoundsWidth = rightBounds.transform.GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2;
        levelMinX = leftBounds.transform.position.x + leftBoundsWidth + (cameraWidth / 2);
        levelMaxX = rightBounds.transform.position.x - rightBoundsWidth - (cameraWidth / 2);

    }

    // Update is called once per frame
    void Update()
    {
        float targetX = Mathf.Max(levelMinX, Mathf.Min(levelMaxX, player.transform.position.x));
        float x = Mathf.SmoothDamp(transform.position.x, targetX, ref smoothDampVelocity.x, smoothDampTime);

        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}

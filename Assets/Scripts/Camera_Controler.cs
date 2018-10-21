using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controler : MonoBehaviour 
{
    public GameObject followTarget;
    private Vector3 targetPos;
    public float move_speed;

    public BoxCollider2D boundBox;
    private Vector3 maxBounds;
    private Vector3 minBounds;

    private Camera Kamera;
    private float halfHeight;
    private float halfWidth;

	// Use this for initialization
	void Start () 
    {
        maxBounds = boundBox.bounds.max;
        minBounds = boundBox.bounds.min;

        Kamera = GetComponent<Camera>();
        halfHeight = Kamera.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;
	}
	
	// Update is called once per frame
	void Update () 
    {
		targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position =  Vector3.Lerp(transform.position, targetPos, move_speed * Time.deltaTime);

        float clampedx = Mathf.Clamp(transform.position.x, minBounds.x + halfWidth, maxBounds.x - halfWidth);
        float clampedy = Mathf.Clamp(transform.position.y, minBounds.y + halfHeight, maxBounds.y - halfHeight);
        transform.position = new Vector3(clampedx, clampedy, transform.position.z);
	}
}

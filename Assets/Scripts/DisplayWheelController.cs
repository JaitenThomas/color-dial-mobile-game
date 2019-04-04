using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayWheelController : MonoBehaviour {


    public float speed;

    // Use this for initialization
    void Start () {
       // StartCoroutine(Rotate(5));
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }

    public IEnumerator Rotate(float duration)
    {
        //yield return new WaitForSeconds(3);

        float startRotation = transform.eulerAngles.z;
        float endRotation = startRotation + 360.0f;
        float t = 0.0f;
        while (t < duration)
        {
            t += Time.deltaTime;
            float zRotation = Mathf.Lerp(startRotation, endRotation, t / duration) % 360.0f;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, zRotation);
            yield return null;
        }
    }
}

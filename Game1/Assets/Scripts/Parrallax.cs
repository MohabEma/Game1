using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parrallax : MonoBehaviour
{
    public Transform[] backgrounds;
    private float[] parralaxScales;
    public float smoothing;
    public Transform cam;
    private Vector3 previousCamPos;

    void Awake()
    {
        cam = Camera.main.transform;
    }

    void Start()
    {
        previousCamPos = cam.position;
        parralaxScales = new float[backgrounds.Length];
        for (int i = 0; i < backgrounds.Length; i++)
        {
            parralaxScales[i] = backgrounds[i].position.z * -1;
        }
    }

    void Update()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            float parralax = (previousCamPos.x - cam.position.x) * parralaxScales[i];
            float backgroundTargetPosX = backgrounds[i].position.x + parralax;
            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }
        previousCamPos = cam.position;
    }

}

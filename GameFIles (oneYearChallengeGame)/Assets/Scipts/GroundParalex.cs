using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundParalex : MonoBehaviour
{
    [SerializeField] float ParalexSpeed = 1f;
    Material groundMat;
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        groundMat = GetComponent<Renderer>().material;
        offset = new Vector2(ParalexSpeed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        groundMat.mainTextureOffset += offset * Time.deltaTime;
    }
}

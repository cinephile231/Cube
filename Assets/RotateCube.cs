using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private Vector3 rotateAmount;

    private void Start()
    {
        rotateAmount = Vector3.up * 10;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(rotateAmount * Time.deltaTime);
    }
}

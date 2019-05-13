using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSetting : MonoBehaviour
{
    public Material[] material;

    Renderer renderer;
    public bool isRed = false;
    public bool isBlue = false;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.sharedMaterial = material[0];
        isRed = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RedDiamond"))
        {
            renderer.sharedMaterial = material[0];
            isRed = true;
            isBlue = false;
        }

        if (other.gameObject.CompareTag("BlueDiamond"))
        {
            renderer.sharedMaterial = material[1];
            isRed = false;
            isBlue = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSetting : MonoBehaviour
{
    public Material[] material;
    public Material[] trailMaterial;

    Renderer bRenderer;
    TrailRenderer trailRenderer;
    public bool isRed = false;
    public bool isBlue = false;
    // Start is called before the first frame update
    void Start()
    {
        bRenderer = GetComponent<MeshRenderer>();
        trailRenderer = GetComponent<TrailRenderer>();
        bRenderer.sharedMaterial = material[0];
        trailRenderer.material = trailMaterial[0];
        isRed = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RedDiamond"))
        {
            bRenderer.sharedMaterial = material[0];
            trailRenderer.material = trailMaterial[0];
            isRed = true;
            isBlue = false;
        }

        if (other.gameObject.CompareTag("BlueDiamond"))
        {
            bRenderer.sharedMaterial = material[1];
            trailRenderer.material = trailMaterial[1];
            isRed = false;
            isBlue = true;
        }
    }
}

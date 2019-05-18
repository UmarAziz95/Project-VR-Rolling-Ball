using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CompleteTimeText : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        textMesh.text = LevelProperties.completeTime.ToString("F");
    }

}

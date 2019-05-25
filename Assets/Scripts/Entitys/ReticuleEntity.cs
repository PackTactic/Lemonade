using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PositionController))]
public class ReticuleEntity : MonoBehaviour
{
    public PositionController positionController;

    // Start is called before the first frame update
    void Start()
    {
        positionController = GetComponent<PositionController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

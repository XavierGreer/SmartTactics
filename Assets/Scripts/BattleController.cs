using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
    FieldManager fieldManager = new FieldManager();
    [SerializeField] int testInt;

    // Start is called before the first frame update
    void Start()
    {
        fieldManager.RowHeight = 5;
        testInt = fieldManager.RowHeight;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplicateMesh : MonoBehaviour
{
    public int rows;
    public int columns;
    public GameObject meshPrefab;

    // Start is called before the first frame update
    void Start()
    {
        if (meshPrefab == null) {
            return;
        }

        for (int rowIndex=0; rowIndex < rows; rowIndex++) {
            for (int colIndex = 0; colIndex < columns; colIndex++) {
                Instantiate(meshPrefab, new Vector3(rowIndex - rows / 2f, 0, colIndex - columns / 2f), Quaternion.identity, this.transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

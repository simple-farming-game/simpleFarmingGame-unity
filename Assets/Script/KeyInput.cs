using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    public TileMapEdit TileMapEdit;
    public GameObject playerPos;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = GetComponent<Transform>();
        TileMapEdit = GetComponent<TileMapEdit>();
    }

    // Update is called once per frame
    void Update()
    {
        TileMapEdit.
    }
}

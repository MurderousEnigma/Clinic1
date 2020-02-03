using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPlayerMove : MonoBehaviour
{
    private CharacterController pController;
    public float movement = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        pController = GetComponent<CharacterController>();
    }

    //continuously move player forward
    void Update()
    {
        pController.Move((Vector3.forward * movement) *  Time.deltaTime);
    }
}

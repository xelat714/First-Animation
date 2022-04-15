using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float _float;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hareket();
    }

    void Hareket()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * _float, Input.GetAxis("Vertical") * Time.deltaTime * _float);
    }
}

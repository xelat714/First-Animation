using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCyle : MonoBehaviour
{

    [SerializeField] float _lifeTime;
    float _currentTime;

    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _lifeTime)
        {
            Destroy(this.gameObject);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Skybox))]
public class SkyboxController : MonoBehaviour
{
    [SerializeField] List<Material> _skyboxMaterials;

    Skybox _skybox;
    // Start is called before the first frame update

    private void Awake()
    {
        _skybox = GetComponent<Skybox>();
    }

    private void OnEnable()
    {
        ChangeSkybox(0);
    }

    private void ChangeSkybox(int skybox)
    {
        if(_skybox != null && skybox >= 0 && skybox <= _skyboxMaterials.Count)
        {
            _skybox.material = _skyboxMaterials[skybox];
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemColorChanger : MonoBehaviour
{
    private Renderer gemRenderer;
    public ParticleSystem sparks = default;

    private void Start()
    {
        gemRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ChangeGemColor();
            sparks.Play();
        }
    }


    private void ChangeGemColor()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);

        gemRenderer.material.color = newColor;
    }
}


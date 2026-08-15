using System;
using UnityEngine;
using UnityEngine.UIElements;

public class meter_script : MonoBehaviour
{
    [SerializeField] private GameObject meter;
    [SerializeField] private SpriteRenderer sprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float growth;

    // Update is called once per frame
    void FixedUpdate()
    {
        growth += 0.05f;
        if (growth < 5)
        {
            sprite.color = Color.orange;
        }
    }
    void Update()
    {
        meter.transform.localScale = new Vector2 (1, growth);
    }
}

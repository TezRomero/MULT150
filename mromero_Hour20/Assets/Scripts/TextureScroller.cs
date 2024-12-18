using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float speed = .5f;

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
    Renderer renderer;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    float offset;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * speed;
        if (offset > 1)
            offset -= 1;
        renderer.material.mainTextureOffset = new Vector2(0, offset);
    }
}

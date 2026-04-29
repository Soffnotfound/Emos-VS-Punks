using System;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    [Serializable]
    public struct StyleData
    {
        public string styleName;
        public Sprite styleSprite;
    }

    public StyleData[] availableStyles;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnEnable()
    {
        //Debug.Log("SpriteChange se ha habilitado y se suscribe al evento de cambio de estilo");
        NoteSpawner.OnSpriteStyleChange += UpdateSpriteStyle;
    }

    void OnDisable()
    {
        NoteSpawner.OnSpriteStyleChange -= UpdateSpriteStyle;
    }

    void UpdateSpriteStyle(string style)
    {
        //Debug.Log($"Recibido evento de cambio de estilo: {style}");
        foreach (StyleData data in availableStyles)
        {
            //Debug.Log("Comparando");
            //Debug.Log(data.styleName);
            //Debug.Log("con");
            //Debug.Log(style);

            if (data.styleName.Trim().Equals(style.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                //Debug.Log("If 1");
                if (spriteRenderer != null && data.styleSprite != null)
                {
                    //Debug.Log("If 2");

                    spriteRenderer.sprite = data.styleSprite;
                    return;
                }
            }
        }

        //Debug.Log($"Estilo '{style}' no encontrado");
    }
}

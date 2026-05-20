using System;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    [Serializable]
    public struct StyleData
    {
        public string styleName;
        public Sprite styleSprite;
        public Sprite pressedSprite;
    }

    public StyleData[] availableStyles;
    private SpriteRenderer spriteRenderer;
    public KeyCode keyToPress;
    public int directionIndex;

    private bool isPressed = false;

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

                    if(isPressed && data.pressedSprite != null)
                    {
                        //Debug.Log("If 3 - Presionado");
                        spriteRenderer.sprite = data.pressedSprite;
                    }
                    else
                    {
                        //Debug.Log("If 3 - No presionado");
                        spriteRenderer.sprite = data.styleSprite;
                    }

                    //spriteRenderer.sprite = data.styleSprite;
                    return;
                }
            }
        }

        //Debug.Log($"Estilo '{style}' no encontrado");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        isPressed = true;
        // Debug.Log("Tiempo global: " + GameManager.tiempoJuegoGlobal);
        // if (other.gameObject.tag == "NPC")
        // {
        //     spriteRenderer.sprite = pressedImage;
        //     NPCController.instance.SetPressed(directionIndex);
        // }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        isPressed = false;
        // if (other.gameObject.tag == "NPC")
        // {
        //     spriteRenderer.sprite = defaultImage;
        //     NPCController.instance.SetPressed(0);
        // }
    }
}

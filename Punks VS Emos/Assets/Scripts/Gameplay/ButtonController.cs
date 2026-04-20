using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public KeyCode keyToPress;
    public int directionIndex = 1; 

    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            theSR.sprite = pressedImage;
        }

        if (Input.GetKeyUp(keyToPress))
        {
            theSR.sprite = defaultImage;
        }
    }

    public  void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "NPC")
        {
            theSR.sprite = pressedImage;
            NPCController.instance.SetPressed(directionIndex);
        }
    }

    public  void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "NPC")
        {
            theSR.sprite = defaultImage;
            NPCController.instance.SetPressed(0);
        }
    }
}

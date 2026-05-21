using UnityEngine;

using UnityEngine.UI;
public class BrilloManager : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image PanelBrillo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("Brillo", 0.5f);

        PanelBrillo.color = new Color(PanelBrillo.color.r, PanelBrillo.color.g, PanelBrillo.color.b, 1-slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSlider(float valor)
    {
         sliderValue = valor;
        PlayerPrefs.SetFloat("Brillo", sliderValue);
        PanelBrillo.color = new Color(PanelBrillo.color.r, PanelBrillo.color.g, PanelBrillo.color.b, 1-sliderValue);
    }
}

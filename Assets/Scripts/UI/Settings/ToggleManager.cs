using UnityEngine;
using UnityEngine.UI;
using TMPro;

    public class ToggleFunctionality : MonoBehaviour
    {
        [SerializeField] private Toggle toggle;
        [SerializeField] private GameObject arrows;
        [SerializeField] private GameObject Music;
        [SerializeField] private GameObject Sound;

    private void OnEnable()
    {
        toggle.onValueChanged.AddListener(SetToggle);
    }

    private void OnDisable()
    {
        toggle.onValueChanged.RemoveListener(SetToggle);
    }

    private void SetToggle(bool toggleValue)
    {
        if (toggleValue)
        {
            arrows.gameObject.SetActive(true);
        }
        else
            arrows.gameObject.SetActive(false);

    }

    private void SetMusicToggle(bool toggleValue)
    {
        if (toggleValue)
        {
            Music.gameObject.SetActive(true);
        }
        else
            Music.gameObject.SetActive(false);

    }

    public void ToggleValueThroughScript()
    {
        toggle.isOn = !toggle.isOn;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectCollector : MonoBehaviour
{

    [SerializeField]
    private int collected;
    public TextMeshProUGUI collectText;


    private void Start()
    {
        collected = 0;
    }

    private void Update()
    {
        collectText.text = collected.ToString();
    }
}

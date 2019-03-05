using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIPlayerText : MonoBehaviour
{
    private TextMeshProUGUI tmText;

    private void Awake()
    {
        tmText = GetComponent<TextMeshProUGUI>();
    }

    internal void HandlePlayerInitialized(int playerNumber)
    {
        tmText.text = String.Format("Player {0} Joined!", playerNumber);
        StartCoroutine(ClearTextAfterDelay());
    }

    private IEnumerator ClearTextAfterDelay()
    {
        yield return new WaitForSeconds(2);
        tmText.text = string.Empty;
    }
}
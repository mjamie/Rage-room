using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class BreakableCounter : MonoBehaviour
{
    [SerializeField] private string breakableName;
    [SerializeField][Tooltip("Does not need to be added")] private TextMeshProUGUI textLeftOverPanel;
    [SerializeField] UnityEvent OnAllBreakablesBroken;

    private int breakableCount;

    private void Start()
    {
        breakableCount = transform.childCount;
    }

    public void OnCheckBreakablesCount()
    {
        breakableCount--;

        if (textLeftOverPanel != null)
        {
            textLeftOverPanel.text = breakableName +": " + breakableCount;
        }
        else
        {
            print(breakableName + ": " + breakableCount);
        }

        if (breakableCount <= 0)
        {
            OnAllBreakablesBroken.Invoke();
        }
    }
}

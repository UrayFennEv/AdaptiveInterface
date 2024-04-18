using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsDeactivator : MonoBehaviour
{
    [SerializeField] private GameObject _settingsMenu;

    private void Start()
    {
        _settingsMenu = GameObject.Find("Settings Menu");
    }

    public void DiactivateMenu()
    {
        _settingsMenu.SetActive(false);
    }
}

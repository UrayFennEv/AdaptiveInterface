using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDeactivator : MonoBehaviour
{
    [SerializeField] private GameObject _playMenu;

    private void Start()
    {
        _playMenu = GameObject.Find("Play Menu");
    }

    public void DiactivateMenu()
    {
        _playMenu.SetActive(false);
    }
}

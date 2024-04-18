using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerElements : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}

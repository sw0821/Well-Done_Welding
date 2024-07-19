using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvents : MonoBehaviour
{
    public void PlayBtn()
    {
        LoadingController.LoadScene("Ground");
    }
}

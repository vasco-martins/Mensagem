using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFX : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip clickSound;
    public AudioClip hoverSound;

    public void HoverSound()
    {
        audioSource.PlayOneShot(hoverSound);
    }


    public void ClickSound()
    {
        audioSource.PlayOneShot(clickSound  );
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksController : MonoBehaviour
{
    public Animator[] fireworkAnimators;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entrando en la zona. ¡Activar fuegos artificiales!");
        SetFireworksState(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Saliendo de la zona. Detener fuegos artificiales.");
        SetFireworksState(false);
    }

    void SetFireworksState(bool isTouching)
    {
        foreach (Animator anim in fireworkAnimators)
        {
            anim.SetBool("isTouching", isTouching);
        }
    }
}

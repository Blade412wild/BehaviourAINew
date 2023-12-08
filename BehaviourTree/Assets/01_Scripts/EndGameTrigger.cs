using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameTrigger : MonoBehaviour
{
    public delegate void EndGame();
    public static event EndGame OnEndGameTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() != null)
        {
            OnEndGameTrigger.Invoke();
        }

    }

}

using UnityEngine;

public class EndScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider Crown)
    {
        if (Crown.gameObject.tag == "Player")
        {
            PlayerController player = Crown.gameObject.GetComponent<PlayerController>();
            Debug.Log("You won! " + "You got " + player.points + " points!");
        }
    }
}

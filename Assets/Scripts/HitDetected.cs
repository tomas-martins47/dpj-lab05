using UnityEngine;
using UnityEngine.UIElements;

public class HitDetected : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private Material flagGreen;

    private void OnCollisionEnter(Collision Collided)
    {
        if (Collided.gameObject.tag == "Player")
        {
            meshRenderer.material = flagGreen;
            PlayerController player = Collided.gameObject.GetComponent<PlayerController>();
            player.points += 1;
            //Debug.Log("+1 Point, Total: " + player.points);
        }
    }
}

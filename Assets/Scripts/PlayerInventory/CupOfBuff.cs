using UnityEngine;

public class CupOfBuff : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;

    [SerializeField] private Tips tips;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tips.Tip();
            playerMovement.SpeedBuff();
            Destroy(this.gameObject);
        }
    }
}

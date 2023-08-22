using System.Collections;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject ragdoll;
    [SerializeField] private GameObject playerUI;
    [SerializeField] private GameObject deathScreen;

    [SerializeField] private AudioSource music;

    private Vector3 V3;

    private void Update()
    {
        V3 = player.transform.position;
    }

    public void Death()
    {
        Vector3 look = player.transform.forward;
        player.SetActive(false);
        ragdoll.SetActive(true);
        playerUI.SetActive(false);
        
        Instantiate(ragdoll, V3, Quaternion.LookRotation(look));
        StartCoroutine(DeathScreen());
    }

    public IEnumerator DeathScreen()
    {
        yield return new WaitForSeconds(2f);
        deathScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
}

using System.Collections;
using System.Linq.Expressions;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject ragdoll;

    [SerializeField] private GameObject playerUI;
    [SerializeField] private GameObject deathScreen;

    private Vector3 V3;

    private void Update()
    {
        V3 = player.transform.position;
    }

    public void Death()
    {
        player.SetActive(false);
        ragdoll.SetActive(true);
        playerUI.SetActive(false);
        Instantiate(ragdoll, V3, transform.rotation);
        StartCoroutine(DeathScreen());
    }
    IEnumerator DeathScreen()
    {
        yield return new WaitForSeconds(2f);
        deathScreen.SetActive(true);
    }
}

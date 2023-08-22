using UnityEngine;

public class Kris : MonoBehaviour
{
    [SerializeField] private Animation anim;
    [SerializeField] private GameObject kris;
    [SerializeField] private GameObject player;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Vector3.Distance(player.transform.position, kris.transform.position) <= 2f)
            {
                anim.Play();
            }
        }
    }
}

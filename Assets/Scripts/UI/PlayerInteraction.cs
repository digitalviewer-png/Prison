using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private GameObject mainCharacter;
    [SerializeField] private GameObject door;
    [SerializeField] private GameObject guard;

    [SerializeField] private AudioSource music;

    [SerializeField] private Animation doorAnim;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Vector3.Distance(mainCharacter.transform.position, door.transform.position) <= 2f) 
            {
                music.Play();
                doorAnim.Play();
                guard.SetActive(true);
            }
        }
    }
}

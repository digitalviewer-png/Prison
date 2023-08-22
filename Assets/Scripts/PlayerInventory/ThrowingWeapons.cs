using UnityEngine;

public class ThrowingWeapons : MonoBehaviour
{
    [SerializeField] private GameObject weaponType1, weaponType2;
    [SerializeField] private GameObject spawnPoint;

    [SerializeField] private Camera cam;

    [SerializeField] private float spawnSpeed = 100f;

    public void Throw(int weapon)
    {
        Vector3 look = -spawnPoint.transform.forward;

        if (weapon == 1 && Cursor.lockState == CursorLockMode.Locked)
        {
            Debug.Log("Kinul");
            Instantiate(weaponType1, spawnPoint.transform.position, Quaternion.LookRotation(look)).GetComponent<Rigidbody>().AddForce(transform.forward * spawnSpeed);
        }

        else if (weapon == 2 && Cursor.lockState == CursorLockMode.Locked)
        {
            Instantiate(weaponType2, spawnPoint.transform.position, Quaternion.LookRotation(look)).GetComponent<Rigidbody>().AddForce(transform.forward * spawnSpeed);
        }
    }

}

using UnityEngine;

public class DestructionObject : MonoBehaviour
{
    [SerializeField] private GameObject dubina;

    public void DestroyObject()
    {
        Destroy(dubina);
    }
}

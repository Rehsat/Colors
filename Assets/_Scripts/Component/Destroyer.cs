using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public void DestroyObject(GameObject objectToDestroy)
    {
        Destroy(objectToDestroy);
    }
}

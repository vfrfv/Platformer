using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    public event UnityAction Colected;

    public void ToCollect()
    {
        gameObject.SetActive(false);

        Colected?.Invoke();
    }
}



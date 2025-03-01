using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Les9
{
    public class ColPlayerCoin : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Coin>()) BankManager.Instance.Coin = 1;
        }

    }
}
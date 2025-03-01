using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Les9
{
    public class BankManager : Singleton<BankManager>
    {
        private int coin = 0;
        public int Coin 
        {
            get => coin; 
            set => coin += value; 
        }
    }
}
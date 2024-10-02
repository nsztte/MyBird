using UnityEngine;

namespace MyBird
{
    public class GameManager : MonoBehaviour
    {
        #region Variables
        public static bool IsStart { get; set; }
        #endregion

        private void Start()
        {
            //초기화
            IsStart = false;
        }
    }
}
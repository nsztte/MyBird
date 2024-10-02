using UnityEngine;

namespace MyBird
{
    public class GroundMove : MonoBehaviour
    {
        #region Variables
        [SerializeField] private float moveSpeed = 5f;
        private Vector3 startPosition;
        #endregion

        // Update is called once per frame
        void Update()
        {
            MoveGround();
        }

        void MoveGround()
        {
            //if (GameManager.IsStart == false)
            //    return;

            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);

            if (transform.localPosition.x <= -8.4f)     //position: 월드기준, localposition: 부모기준
            {
                transform.localPosition = new Vector3(transform.localPosition.x + 8.4f, transform.localPosition.y, transform.localPosition.z);
            }
        }
    }
}
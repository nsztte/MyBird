using UnityEngine;

namespace MyBird
{
    public class SpawnManger : MonoBehaviour
    {
        #region
        //파이프 프리팹
        public GameObject pipePrefab;

        //스폰 타이머
        //[SerializeField] private float spawnTimer = 1f;
        private float countdown = 0f;

        [SerializeField] private float maxSpawnTimer = 1.05f;
        [SerializeField] private float minSpawnTimer = 0.95f;

        //스폰 위치
        [SerializeField] private float maxspawnY = 3.5f;
        [SerializeField] private float minspawnY = -1.5f;
        #endregion


        private void Update()
        {
            if (GameManager.IsStart == false || GameManager.IsDeath)
                return;
           
            //스폰 타이머
            if (countdown <= 0f)
            {
                //스폰
                SpawnPipe();

                //초기화
                //countdown = spawnTimer;
                countdown = Random.Range(minSpawnTimer, maxSpawnTimer);
            }
            countdown -= Time.deltaTime;
        }

        void SpawnPipe()
        {
            float spawnY = transform.position.y + Random.Range(minspawnY, maxspawnY);
            Vector3 spawnPosition = new Vector3(transform.position.x, spawnY, 0f);
            Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
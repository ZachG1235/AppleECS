using System.Collections;
using System.Collections.Generic;
using Unity.Entities.UniversalDelegates;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.Entities.SystemBaseDelegates;

public class BadApple : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject objectPrefab;
    public float chance = 0.1f;
    public int amountOnScreen = 0;
    public List<GameObject> objects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float maybeChance = Random.Range(0.0f, 1);
        if (maybeChance < chance)
        {
            float spawnY = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float spawnX = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

            Vector3 spawnPosition = Vector3.zero;
            spawnPosition.x = spawnX;
            spawnPosition.y = spawnY;
            spawnPosition.z -= 5;
            Instantiate(objectPrefab, spawnPosition, Quaternion.identity);

            amountOnScreen++;
        }

    }
}

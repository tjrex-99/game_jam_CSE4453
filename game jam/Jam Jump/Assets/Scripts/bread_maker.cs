using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bread_maker : MonoBehaviour
{
    public GameObject bread_prefab;
    public GameObject mayo_prefab;
    public GameObject pb_prefab;
    private GameObject highest_bread;

    public float level_width = 5f;

    public int bread_count = 200;
    public float bread_minY = 0.3f;
    public float bread_maxY = 1.7f;

    public int mayo_count = 25;
    public float mayo_minY = 10f;
    public float mayo_maxY = 20f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 bread_spawn_pos = new Vector3();
        Vector3 mayo_spawn_pos = new Vector3();

        for (int i = 0; i < bread_count; i++)
        {
            bread_spawn_pos.y += Random.Range(bread_minY, bread_maxY);
            bread_spawn_pos.x = Random.Range(-level_width, level_width);
            highest_bread = Instantiate(bread_prefab, bread_spawn_pos, Quaternion.identity);
        }

        for (int i = 0; i < mayo_count; i++)
        {
            mayo_spawn_pos.y += Random.Range(mayo_minY, mayo_maxY);
            mayo_spawn_pos.x = Random.Range(-level_width, level_width);
            Instantiate(mayo_prefab, mayo_spawn_pos, Quaternion.identity);
        }

        Vector3 pb_spawn_pos = new Vector3(0f, bread_spawn_pos.y + 1.5f, 2f);

        Instantiate(pb_prefab, pb_spawn_pos, Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainQuery : MonoBehaviour
{
    [SerializeField] Terrain LinkedTerrain;

    Vector3 TerrainScale;

    // Start is called before the first frame update
    void Start()
    {
        TerrainScale = LinkedTerrain.terrainData.size;
    }

    // Update is called once per frame
    void Update()
    {
        // convert the location to a 0 to 1 value
        float x = (transform.position.x - LinkedTerrain.transform.position.x) / TerrainScale.x;
        float y = (transform.position.z - LinkedTerrain.transform.position.z) / TerrainScale.z;

        // retrieve the height and the y component of the normal
        float height = LinkedTerrain.terrainData.GetInterpolatedHeight(x, y);
        float normalY = LinkedTerrain.terrainData.GetInterpolatedNormal(x, y).y;
        Debug.Log(height + " : " + normalY);
    }
}

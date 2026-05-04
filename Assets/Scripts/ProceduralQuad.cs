using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class ProceduralQuad : MonoBehaviour
{
    private Mesh mesh;

    void Start()
    {
        mesh = new Mesh();
        mesh.name = "Procedural Quad";

        GetComponent<MeshFilter>().mesh = mesh;

        Vector3[] vertices =
        {
            new Vector3(0, 0, 0), // 0
            new Vector3(1, 0, 0), // 1
            new Vector3(0, 1, 0), // 2
            new Vector3(1, 1, 0)  // 3
        };

        int[] triangles =
        {
            0, 2, 1,
            2, 3, 1
        };

        Vector2[] uv =
        {
            new Vector2(0, 0),
            new Vector2(1, 0),
            new Vector2(0, 1),
            new Vector2(1, 1)
        };

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uv;

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
    }
}
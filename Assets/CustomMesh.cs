using UnityEngine;
using System.Collections;

public class CustomMesh : MonoBehaviour {

	void Start () {
        Mesh m = new Mesh();
        m.vertices = new Vector3[] {
            new Vector3(-5.0f, -5.0f, 0.0f),
            new Vector3(-5.0f, 5.0f, 0.0f),
            new Vector3(5.0f,5.0f,0.0f),
            new Vector3(5.0f,-5.0f,0.0f)
        };

        m.triangles = new int[] {
            0, 1, 2,
            0, 2, 3
        };

        m.uv = new Vector2[]
        {
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f,2.0f),
            new Vector2(2.0f,2.0f),
            new Vector2(2.0f,0.0f)
        };

        m.colors = new Color[]
        {
            Color.cyan,
            Color.red,
            Color.white,
            Color.green,
        };

        GetComponent<MeshFilter>().mesh = m;
	}

	void Update () {
	
	}
}

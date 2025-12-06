using UnityEngine;

public class Cube2 : Cube
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Lấy component MeshRenderer
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        if (renderer != null)
        {
            renderer.material.color = color(); // Đổi màu cube
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override Color color()
    {
        cubeColor = Color.blue;
        return cubeColor;
    }
}

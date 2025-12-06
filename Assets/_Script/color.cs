using UnityEngine;

public class color : MonoBehaviour
{
    public Color cubeColor = Color.red;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Lấy component MeshRenderer
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        if (renderer != null)
        {
            renderer.material.color = cubeColor; // Đổi màu cube
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class ChangeMaterialOnTrigger : MonoBehaviour
{
    public MaterialData[] materials;

    private int currentIndex = 0;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        ApplyMaterial(materials[currentIndex]);
    }

    void OnTriggerEnter(Collider other)
    {
        currentIndex = (currentIndex + 1) % materials.Length;
        ApplyMaterial(materials[currentIndex]);
    }

    void ApplyMaterial(MaterialData data)
    {
        Material mat = MaterialManager.Instance.GenerateMaterial(data);
        rend.material = mat;
    }
}


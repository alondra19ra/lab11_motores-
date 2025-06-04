using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    public static MaterialManager Instance;
    public Material baseMaterial;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Material GenerateMaterial(MaterialData data)
    {
        Material newMat = new Material(baseMaterial);
        newMat.color = data.baseColor;
        newMat.SetFloat("_Metallic", data.metallic);
        newMat.SetFloat("_Smoothness", data.smoothness);
        return newMat;
    }
}


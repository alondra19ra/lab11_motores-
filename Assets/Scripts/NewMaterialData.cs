using UnityEngine;

[CreateAssetMenu(fileName = "NewMaterialData", menuName = "Custom/MaterialData")]
public class MaterialData : ScriptableObject
{
    public string materialName;
    public Color baseColor;
    public float metallic;
    public float smoothness;
}


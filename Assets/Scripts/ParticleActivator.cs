using UnityEngine;

public class ParticleActivator : MonoBehaviour
{
    public ParticleSystem ps;
    public Material[] particleMaterials;
    private int index = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var renderer = ps.GetComponent<ParticleSystemRenderer>();
            renderer.material = particleMaterials[index];

            ps.Play();
            index = (index + 1) % particleMaterials.Length;
        }
    }
}


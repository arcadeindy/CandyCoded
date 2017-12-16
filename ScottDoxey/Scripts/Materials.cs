using System.Collections.Generic;
using UnityEngine;

namespace ScottDoxey {

    public static class Materials {

        public static Material[] GetMaterialsInChildren(GameObject gameObject) {

            List<Material> materials = new List<Material>();

            Renderer[] renderers = gameObject.GetComponentsInChildren<Renderer>();

            foreach (Renderer renderer in renderers) {

                foreach (Material material in renderer.materials) {

                    materials.Add(material);

                }

            }

            return materials.ToArray();

        }

        public static void SetMaterialsToBlendMode(Material[] materials, ScottDoxey.StandardShader.BlendMode blendMode) {

            foreach (Material material in materials) {

                ScottDoxey.StandardShader.SetupMaterialWithBlendMode(material, blendMode);

            }

        }

        public static Color SetColorAlpha(Color color, float alpha = 1) {

            color.a = alpha;

            return color;

        }

    }

}

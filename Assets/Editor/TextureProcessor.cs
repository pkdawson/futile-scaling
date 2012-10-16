using UnityEngine;
using UnityEditor;

public class TextureProcessor : AssetPostprocessor
{
    public void OnPreprocessTexture()
    {
        TextureImporter importer = assetImporter as TextureImporter;
        importer.filterMode = FilterMode.Point;
		importer.textureType = TextureImporterType.GUI;
		importer.anisoLevel = 0;
		importer.textureFormat = TextureImporterFormat.AutomaticTruecolor;
    }
}

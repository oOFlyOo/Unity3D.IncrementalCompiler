using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class CompilerSwitch
{
    static CompilerSwitch()
    {
        SwitchCompiler();
    }

    private static PluginImporter GetCompilerPluginImporter()
    {
        foreach (var importer in PluginImporter.GetAllImporters())
        {
            if (importer.assetPath.Contains("CompilerPlugin.dll"))
            {
                return importer;
            }
        }
        return null;
    }


    /// <summary>
    /// 其实如果需要关闭，直接去 Inspector 关闭即可
    /// 考虑到 SVN
    /// </summary>
    private static void SwitchCompiler()
    {
        OnlyWindows();
    }

    private static void OnlyWindows()
    {
        GetCompilerPluginImporter().SetEditorData("OS", "Windows");
    }
}

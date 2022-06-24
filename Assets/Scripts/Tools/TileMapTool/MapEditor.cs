using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace xPoke.Tools.TileMapEditor
{
#if UNITY_EDITOR
    public partial class TileMapEditor : EditorWindow
    {

        [MenuItem("Tools/Map Editor")]
        public static void StartEditor()
        {
            TileMapEditor mapEditorWindow = EditorWindow.GetWindow<TileMapEditor>("Map Editor", true);
            mapEditorWindow.Show();
        }

        void OnEnable()
        {
            // Find the "Hidden/Internal-Colored" shader, and cache it for use.
            _material = new Material(Shader.Find("Hidden/Internal-Colored"));

            InitializeMatrix();

            PopulateDropDownOptions();
        }

        private void OnDisable()
        {
            SaveMatrix();
        }

        void OnGUI()
        {
            DrawGrid();
            DrawDrawTileSection();
            DrawAddTileSection();
        }

    }
#endif
}

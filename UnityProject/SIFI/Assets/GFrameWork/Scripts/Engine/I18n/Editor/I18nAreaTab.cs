﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GFrame.I18N
{
    public class I18nAreaTab : EditorTab
    {
        public override void OnOpen(I18NConfig config)
        {
            base.OnOpen(config);
            Log.e("I18nAreaTab open");
        }

        public override void OnDraw()
        {
            GUILayout.BeginVertical();

            for (int i = 0; i < config.areas.Count; i++)
            {

            }

            GUILayout.EndVertical();
            if (GUILayout.Button("Save")) Save();
        }

        private void Save()
        {
            I18NConfig config = null;
            string folderPath = "Assets/Resources/Config/";
            FileHelper.CreateDirctory(PathHelper.AssetsPath2ABSPath(folderPath));
            string dataPath = folderPath + "I18NConfig.asset";
            config = AssetDatabase.LoadAssetAtPath<I18NConfig>(dataPath);
            if (config == null)
            {
                config = ScriptableObject.CreateInstance<I18NConfig>();
                AssetDatabase.CreateAsset(config, dataPath);
            }

            config.SetAreaInfo(new[] { "CN", "JP" });
            config.SetKey(new[] { "name", "value" });
            EditorUtility.SetDirty(config);
            AssetDatabase.SaveAssets();
        }
    }
}

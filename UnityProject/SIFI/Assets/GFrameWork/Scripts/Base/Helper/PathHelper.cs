﻿//  Desc:        Framework For Game Develop with Unity3d
//  Copyright:   Copyright (C) 2017 SnowCold. All rights reserved.
//  WebSite:     https://github.com/SnowCold/Qarth
//  Blog:        http://blog.csdn.net/snowcoldgame
//  Author:      SnowCold
//  E-mail:      snowcold.ouyang@gmail.com
using System;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace GFrame
{
    public class PathHelper
    {

        public static string AssetsPath2ABSPath(string assetsPath)
        {
            string assetRootPath = System.IO.Path.GetFullPath(Application.dataPath);
            assetRootPath = assetRootPath.Substring(0, assetRootPath.Length - 6) + assetsPath;
            return assetRootPath.Replace("\\", "/");
        }

        public static string AssetPath2ReltivePath(string path)
        {
            if (path == null)
            {
                return null;
            }

            return path.Replace("Assets/", "");
        }

        public static string FileNameWithoutSuffix(string name)
        {
            if (name == null)
            {
                return null;
            }

            int endIndex = name.LastIndexOf('.');
            if (endIndex > 0)
            {
                return name.Substring(0, endIndex);
            }
            return name;
        }

        public static string FullAssetPath2Name(string fullPath)
        {
            string name = FileNameWithoutSuffix(fullPath);
            if (name == null)
            {
                return null;
            }

            int endIndex = name.LastIndexOf('/');
            if (endIndex > 0)
            {
                return name.Substring(endIndex + 1);
            }
            return name;
        }

        public static string GetFolderPath(string filePath)
        {
            FileInfo info = new FileInfo(filePath);
            return info.Directory.FullName + "/";
        }
    }
}

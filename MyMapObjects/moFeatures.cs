﻿using System.Collections.Generic;

namespace MyMapObjects
{
    public class moFeatures
    {
        #region 字段

        private readonly List<moFeature> _Features;   //要素集合
        #endregion

        #region 构造函数

        public moFeatures()
        {
            _Features = new List<moFeature>();
        }
        #endregion

        #region 属性

        /// <summary>
        /// 获取要素数目
        /// </summary>
        public int Count => _Features.Count;

        #endregion

        #region 方法

        /// <summary>
        /// 获取指定索引号的元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public moFeature GetItem(int index)
        {
            return _Features[index];
        }

        /// <summary>
        /// 设置指定索引号的元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="feature"></param>
        public void SetItem(int index, moFeature feature)
        {
            _Features[index] = feature;
        }

        /// <summary>
        /// 在末尾追加一个元素
        /// </summary>
        /// <param name="feature"></param>
        public void Add(moFeature feature)
        {
            _Features.Add(feature);
        }

        /// <summary>
        /// 删除指定索引号的元素
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            _Features.RemoveAt(index);
        }

        /// <summary>
        /// 删除指定元素
        /// </summary>
        /// <param name="features"></param>
        public void Remove(moFeature feature)
        {
            _ = _Features.Remove(feature);
        }

        /// <summary>
        /// 清除所有元素
        /// </summary>
        public void Clear()
        {
            _Features.Clear();
        }

        #endregion
    }
}

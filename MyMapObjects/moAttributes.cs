﻿using System.Collections.Generic;

namespace MyMapObjects
{
    //说明：属性集合类
    public class moAttributes
    {
        #region 字段

        private readonly List<object> _Attributes;   //属性值集合

        #endregion

        #region 构造函数

        public moAttributes()
        {
            _Attributes = new List<object>();
        }

        #endregion

        #region 属性

        #endregion

        #region 方法 

        /// <summary>
        /// 获取指定索引号的元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object GetItem(int index)
        {
            return _Attributes[index];
        }

        /// <summary>
        /// 设置指定索引号的元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="attributeValue"></param>
        public void SetItem(int index, object attributeValue)
        {
            _Attributes[index] = attributeValue;
        }

        /// <summary>
        /// 将所有元素复制到一个新的数组
        /// </summary>
        /// <returns></returns>
        public object[] ToArray()
        {
            return _Attributes.ToArray();
        }

        /// <summary>
        /// 从值数组中获取所有值
        /// </summary>
        /// <param name="attributeValues"></param>
        public void FromArray(object[] attributeValues)
        {
            _Attributes.Clear();
            _Attributes.AddRange(attributeValues);
        }

        /// <summary>
        /// 在末尾追加一个值
        /// </summary>
        /// <param name="attributeValue"></param>
        public void Append(object attributeValue)
        {
            _Attributes.Add(attributeValue);
        }

        /// <summary>
        /// 删除指定索引号的元素
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            _Attributes.RemoveAt(index);
        }


        /// <summary>
        /// 克隆
        /// </summary>
        /// <returns></returns>
        public moAttributes Clone()
        {
            moAttributes sAttributes = new moAttributes();
            sAttributes._Attributes.AddRange(_Attributes);
            return sAttributes;
        }
        #endregion

    }
}

using System;
using HXAvocado.Code;

namespace HXAvocado.Entity
{
    /// <summary>
    /// 版 本 0.1.0
    /// AGPLv3
    /// 创建人：袁皓
    /// 日 期：2018.12.17
    /// 描 述：模型预设操作 
    /// </summary>
    public class IEntity<TEntity>
    {
        public void Create()
        {
            var entity = this as ICreationAudited;
            entity.ID = Common.GuId();
            //暂时没有用户这里存字符串
            entity.CreatorUserId = "No user";
            entity.CreatorTime = DateTime.Now;
        }
        public void Modify(string keyValue)
        {
            var entity = this as IModificationAudited;
            entity.ID = keyValue;
            //暂时没有用户这里存字符串
            entity.LastModifyUserId = "No user";
            entity.LastModifyTime = DateTime.Now;
        }
        public void Remove()
        {
            var entity = this as IDeleteAudited;
            //暂时没有用户这里存字符串
            entity.DeleteUserId = "No user";
            entity.DeleteTime = DateTime.Now;
            entity.DeleteMark = true;
        }
    }
}

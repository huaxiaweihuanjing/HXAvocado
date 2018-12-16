using System;
using HXAvocado.Code;

namespace HXAvocado.Entity
{
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

//using AutoMapper;
//using AutoMapper.Internal;
//using Microsoft.Azure.Mobile;
//using Microsoft.Azure.Mobile.Server;
//using Microsoft.Azure.Mobile.Server.Tables;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Net.Http;
//using System.Reflection;
//using System.Threading.Tasks;
//using System.Web;
//using System.Web.Http;
//using System.Web.Http.OData;

//namespace handycareappService.Models
//{
//    public class SimpleMappedEntityDomainManager<TData, TModel>
//        : MappedEntityDomainManager<TData, TModel>
//        where TData : class, ITableData, new()
//        where TModel : class
//    {
//        private Expression<Func<TModel, object>> dbKeyProperty;
//        public SimpleMappedEntityDomainManager(DbContext context,
//            HttpRequestMessage request, MobileAppSettingsDictionary services,
//            Expression<Func<TModel, object>> dbKeyProperty)
//            : base(context, request)
//        {
//            this.dbKeyProperty = dbKeyProperty;
//        }
//        public override SingleResult<TData> Lookup(string id)
//        {
//            return this.LookupEntity(GeneratePredicate(id));
//        }
//        public override Task<TData> UpdateAsync(string id, Delta<TData> patch)
//        {
//            return this.UpdateEntityAsync(patch, ConvertId(id));
//        }
//        public override Task<bool> DeleteAsync(string id)
//        {
//            return this.DeleteItemAsync(ConvertId(id));
//        }
//        private static Expression<Func<TModel, bool>> GeneratePredicate(string id)
//        {
//            var m = Mapper.FindTypeMapFor<TModel, TData>();
//            var pmForId = m.GetExistingPropertyMapFor(new PropertyAccessor(typeof(TData).GetProperty("Id")));
//            var keyString = pmForId.CustomExpression;
//            var predicate = Expression.Lambda<Func<TModel, bool>>(
//                Expression.Equal(keyString.Body, Expression.Constant(id)),
//                keyString.Parameters[0]);
//            return predicate;
//        }
//        private object ConvertId(string id)
//        {
//            var m = Mapper.FindTypeMapFor<TData, TModel>();
//            var keyPropertyAccessor = GetPropertyAccessor(this.dbKeyProperty);
//            var pmForId = m.GetExistingPropertyMapFor(new PropertyAccessor(keyPropertyAccessor));
//            TData tmp = new TData() { Id = id };
//            var convertedId = pmForId.CustomExpression.Compile().DynamicInvoke(tmp);
//            return convertedId;
//        }
//        private PropertyInfo GetPropertyAccessor(Expression exp)
//        {
//            if (exp.NodeType == ExpressionType.Lambda)
//            {
//                var lambda = exp as LambdaExpression;
//                return GetPropertyAccessor(lambda.Body);
//            }
//            else if (exp.NodeType == ExpressionType.Convert)
//            {
//                var convert = exp as UnaryExpression;
//                return GetPropertyAccessor(convert.Operand);
//            }
//            else if (exp.NodeType == ExpressionType.MemberAccess)
//            {
//                var propExp = exp as System.Linq.Expressions.MemberExpression;
//                return propExp.Member as PropertyInfo;
//            }
//            else
//            {
//                throw new InvalidOperationException("Unexpected expression node type: " + exp.NodeType);
//            }
//        }
//    }
//}
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Interfaces
{
	public interface IRepository <TContext,TEntity, TValidator>
		where TContext:DbContext,new()
		where TEntity:class,IEntity,new()
		where TValidator: IValidator, new()
	{
		void Add(TContext context, TEntity entity);
		void AddRange(TContext context, List<TEntity> entities);
		void Delete(TContext context, TEntity entity);
		void Save(TContext context);
		TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter);
		List<TEntity> GetAll(TContext context);
	}
}

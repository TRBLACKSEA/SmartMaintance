using FluentValidation;
using OtoTamirTakip.Interfaces;
using OtoTamirTakip.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Repository
{
	public class EntityRepository<TContext, TEntity, TValidator> : IRepository<TContext, TEntity, TValidator>
		where TContext : DbContext, new()
		where TEntity : class, IEntity, new()
		where TValidator : IValidator,new()
	{
		public void Add(TContext context, TEntity entity)
		{
			TValidator validator = new TValidator();
			var validationResult = ValidatorTool.Validate(validator, entity);
			if(validationResult)
			{
				context.Set<TEntity>().Add(entity);
			}
		}

		public void AddRange(TContext context, List<TEntity> entities)
		{
			bool validationResult=false;
			TValidator validator = new TValidator();
			foreach (var entity in entities)
			{
				validationResult = ValidatorTool.Validate(validator, entity);
			}
			if(validationResult)
			{
				context.Set<TEntity>().AddRange(entities);
			}
		}
		public void Save(TContext context)
		{
			context.SaveChanges();
		}

		public void Delete(TContext context, TEntity entity)
		{
			context.Set<TEntity>().Remove(entity);
		}

		public TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
		{
			return context.Set<TEntity>().Where(filter).FirstOrDefault();
		}

		public List<TEntity> GetAll(TContext context)
		{
			return context.Set<TEntity>().ToList();
		}


	}
}

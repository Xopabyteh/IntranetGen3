﻿using Havit.Data.EntityFrameworkCore.Patterns.QueryServices;
using Havit.Extensions.DependencyInjection.Abstractions;
using Havit.Linq;
using MensaGymnazium.IntranetGen3.Contracts;
using MensaGymnazium.IntranetGen3.DataLayer.DataSources;

namespace MensaGymnazium.IntranetGen3.DataLayer.Queries
{
	[Service]
	public class SubjectListQuery : QueryBase<SubjectListItemDto>, ISubjectListQuery
	{
		private readonly ISubjectDataSource subjectDataSource;

		public SubjectListQuery(ISubjectDataSource subjectDataSource)
		{
			this.subjectDataSource = subjectDataSource;
		}

		public SubjectListQueryFilter Filter { get; set; }

		protected override IQueryable<SubjectListItemDto> Query()
		{
			// TODO Filter
			// TODO Richer DTO?

			var data = subjectDataSource.Data;

			if (!String.IsNullOrWhiteSpace(Filter.Name))
			{
				data = data.Where(s => s.Name.Contains(Filter.Name));
			}

			data = data.WhereIf(Filter.SubjectTypeId != null,
				s => s.TypeRelations.Any(r => r.SubjectTypeId == Filter.SubjectTypeId));

			data = data.WhereIf(Filter.SubjectCategoryId != null,
				 s => s.CategoryId == Filter.SubjectCategoryId);

			var result = data.Select(s => new SubjectListItemDto()
			{
				SubjectId = s.Id,
				Name = s.Name,
				CategoryId = s.CategoryId,
				SubjectTypeIds = s.TypeRelations.Select(tr => tr.SubjectTypeId).ToList(),
				Capacity = s.Capacity,
				Grade = s.GradeRelations.Select(tr => tr.GradeId).ToList(),
			});

			return result;
		}

		public async Task<DataFragmentResult<SubjectListItemDto>> GetDataFragmentAsync(int startIndex, int? count, CancellationToken cancellationToken = default)
		{
			return new()
			{
				Data = await SelectDataFragmentAsync(startIndex, count, cancellationToken),
				TotalCount = await CountAsync(cancellationToken)
			};
		}

	}
}

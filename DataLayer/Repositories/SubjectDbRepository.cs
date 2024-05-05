﻿using System.Linq.Expressions;
using Havit.Data.Patterns.DataLoaders;
using MensaGymnazium.IntranetGen3.Model;

namespace MensaGymnazium.IntranetGen3.DataLayer.Repositories;

public partial class SubjectDbRepository : ISubjectRepository
{
	public Task<List<Subject>> GetAllIncludingDeletedAsync(CancellationToken cancellationToken)
	{
		return this.DataIncludingDeleted.ToListAsync(cancellationToken);
	}
	protected override IEnumerable<Expression<Func<Subject, object>>> GetLoadReferences()
	{
		yield return x => x.GradeRelations;
	}

	protected override async Task LoadReferencesAsync(Subject[] entities, CancellationToken cancellationToken = default)
	{
		await base.LoadReferencesAsync(entities, cancellationToken);
		await DataLoader.LoadAllAsync(entities, x => x.GradeRelations).ThenLoadAsync(x => x.Grade);
	}
}

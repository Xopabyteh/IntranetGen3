﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Havit.Data.EntityFrameworkCore;
using Havit.Data.EntityFrameworkCore.Patterns.DataSources;
using Havit.Data.EntityFrameworkCore.Patterns.SoftDeletes;

namespace MensaGymnazium.IntranetGen3.DataLayer.DataSources;

[System.CodeDom.Compiler.GeneratedCode("Havit.Data.EntityFrameworkCore.CodeGenerator", "1.0")]
public partial class SubjectCategoryDbDataSource : DbDataSource<MensaGymnazium.IntranetGen3.Model.SubjectCategory>, ISubjectCategoryDataSource
{
	public SubjectCategoryDbDataSource(IDbContext dbContext, ISoftDeleteManager softDeleteManager)
		: base(dbContext, softDeleteManager)
	{
	}
}

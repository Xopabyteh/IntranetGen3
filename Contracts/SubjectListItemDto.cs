﻿using System.Collections.Generic;
using MensaGymnazium.IntranetGen3.Primitives;

namespace MensaGymnazium.IntranetGen3.Contracts
{
	public record SubjectListItemDto
	{
		public int SubjectId { get; set; }
		public string Name { get; set; }
		public int CategoryId { get; set; }
		public int Capacity { get; set; }
		public ScheduleSlotInDay ScheduleSlotInDay { get; set; }
		public List<int> SubjectTypeIds { get; set; } = new List<int>();
		public List<int> Grade { get; set; } = new List<int>();
	}
}

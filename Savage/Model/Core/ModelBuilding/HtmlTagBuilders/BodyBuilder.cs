﻿using Savage.Core.SourceCodeModeling.Structure.HtmlTags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Savage.Core.ModelBuilding.Builders
{
    public class BodyBuilder : ITagBuilder
    {
		Body BodyTag
		{
			get;
			set;
		}

		public void Build(Object buildingElement, ref Grid buildingSpace)
		{
			BodyTag = buildingElement as Body;
		}
	}
}

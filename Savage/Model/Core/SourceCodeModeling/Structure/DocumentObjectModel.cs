﻿using System.IO;
using System.Windows;

namespace Savage.Core.SourceCodeModeling.Structure
{
	public class DocumentObjectModel
    {
		public DocumentObjectModel()
		{
		}		

        public DocumentObjectModel(Root root)
        {
            Root = root;
        }

        public Root Root { get; set; } = new Root();

    }
}
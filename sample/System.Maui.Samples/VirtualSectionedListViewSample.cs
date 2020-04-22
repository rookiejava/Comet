﻿using System;
namespace System.Maui.Samples
{
	public class VirtualSectionedListViewSample : View
	{
		public VirtualSectionedListViewSample()
		{
			Body = () => new SectionedListView<int>
			{
				SectionCount = () => 10,
				SectionFor = (s) => new Section<int>
				{
					Header = new Label ($"Header: {s}"),
					Count = () => 10,
					ItemFor = (index) => index,
					ViewFor = (i) => new Label ($"Row: {i}"),
				},
			};
		}
	}
}
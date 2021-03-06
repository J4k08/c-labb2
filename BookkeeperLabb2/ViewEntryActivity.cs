﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BookkeeperLabb2
{
	[Activity(Label = "ViewEntryActivity")]
	public class ViewEntryActivity : Activity
	{

		ListView entryList;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.EntryListLayout);

			entryList = FindViewById<ListView>(Resource.Id.LV_entries);

			entryList.Adapter = new EntryAdapter(this);

		}
	}
}

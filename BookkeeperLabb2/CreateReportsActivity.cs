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
	[Activity(Label = "CreateReportsActivity")]
	public class CreateReportsActivity : Activity
	{
		TextView taxReport;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.TaxReportLayout);

			taxReport = FindViewById<TextView>(Resource.Id.TV_createReport);

			taxReport.Text = BookKeeperManager.Instance.GetTaxReport();
		}
	}
}

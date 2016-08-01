
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
using XavHotDog.core;

namespace XavHotDog
{
	[Activity(Label = "Hot Dog Detail", MainLauncher = false)]
	public class XavHotDogDetailActivity : Activity
	{

		ImageView hotDogImageView;
		TextView hotDogNameTextView;
		TextView hotDogShortDescriptionTextView;
		TextView hotDogDescriptionTextView;
		TextView hotDogPriceTextView;
		Button cancelButton;
		Button orderButton;
		EditText amountEditText;

		HotDog hotDog;
		HotDogDataService dataService;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.HotDogDetailView);
			FindView();
			BindData();
		}


		private void FindView() {
			hotDogImageView = FindViewById<ImageView>(Resource.Id.hotDogImageView);
			hotDogNameTextView = FindViewById<TextView>(Resource.Id.hotDogNameTextView);
			hotDogShortDescriptionTextView = FindViewById<TextView>(Resource.Id.hotDogShortDescriptionTextView);
			hotDogDescriptionTextView = FindViewById<TextView>(Resource.Id.hotDogDescriptionTextView);
			hotDogPriceTextView = FindViewById<TextView>(Resource.Id.hotDogPriceTextView);
			cancelButton = FindViewById<Button>(Resource.Id.cancelButton);
			orderButton = FindViewById<Button>(Resource.Id.orderButton);
			amountEditText = FindViewById<EditText>(Resource.Id.amountEditText);
		}

		private void BindData() {
			dataService = new HotDogDataService();
			hotDog = dataService.GetHotDogById(1);

			if (hotDog != null)
			{
				hotDogNameTextView.Text = hotDog.Name;
				hotDogShortDescriptionTextView.Text = hotDog.ShortDescription;
				hotDogDescriptionTextView.Text = hotDog.Descritpion;
				hotDogPriceTextView.Text = hotDog.Price.ToString();

				string mImage = "http://lorempixel.com/200/100/food";

				//todo change mImage in hotDog.imagePath
				var bitmapImage = ImageHelper.GetImageBitmapFromUrl(mImage);

				if (bitmapImage != null) {
					hotDogImageView.SetImageBitmap(bitmapImage);
				}

			}
			else {

				throw new SystemException("Error no HotDog Found !");
			}

		}

		private void HandleEvents() {

			orderButton.Click += OrderButton_Click;
			cancelButton.Click += CancelButton_Click;
		}

		private void OrderButton_Click(object sender, EventArgs e) {

			var dialog = new AlertDialog.Builder(this);
			dialog.SetTitle("Confirmation");
			dialog.SetMessage("Add to Cart");
			dialog.Show();
		}

		private void CancelButton_Click(object Sender, EventArgs e) {

			throw new ApplicationException("no cancel");
		}

	}
}


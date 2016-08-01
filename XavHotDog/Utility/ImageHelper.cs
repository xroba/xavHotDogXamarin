using System;
using System.Net;
using Android.Graphics;


namespace XavHotDog
{
	public class ImageHelper
	{
		public ImageHelper()
		{
		}

		public static Bitmap GetImageBitmapFromUrl(string url) {

			WebClient webClient = new WebClient();
			Bitmap bitmapImage = null;


			var imageBytes = webClient.DownloadData(url);

			if (imageBytes != null && imageBytes.Length > 0) {

				bitmapImage = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
			}



			return bitmapImage;
		}
	}
}


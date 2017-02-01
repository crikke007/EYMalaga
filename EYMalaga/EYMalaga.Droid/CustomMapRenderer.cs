using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;

using Android.Widget;
using Xamarin.Forms;
using EYMalaga;
using EYMalaga.Droid;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;

[assembly: ExportRenderer(typeof(CustomMap), typeof(CustomMapRenderer))]
namespace EYMalaga.Droid
{
    public class CustomMapRenderer : MapRenderer, IOnMapReadyCallback
    {
        GoogleMap map;
        List<Position> routeCoordinates;

        protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Unsubscribe
            }

            if (e.NewElement != null)
            {
                var formsMap = (CustomMap)e.NewElement;
                routeCoordinates = formsMap.RouteCoordinates;

                ((MapView)Control).GetMapAsync(this);
            }
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            map = googleMap;

            var polylineOptions = new PolylineOptions();
            polylineOptions.InvokeColor(0x66FF0000);

            foreach (var position in routeCoordinates)
            {
                polylineOptions.Add(new LatLng(position.Latitude, position.Longitude));
            }

            map.AddPolyline(polylineOptions);
        }
    }
}
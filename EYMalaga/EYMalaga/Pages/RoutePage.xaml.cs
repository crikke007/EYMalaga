using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace EYMalaga.Pages
{
    public partial class RoutePage : ContentPage
    {
        public RoutePage()
        {
            InitializeComponent();

            customMap.RouteCoordinates.Add(new Position(51.174914, 4.821034));
            customMap.RouteCoordinates.Add(new Position(51.176980, 4.836359));
            customMap.RouteCoordinates.Add(new Position(51.173547, 4.839211));
            customMap.RouteCoordinates.Add(new Position(51.177253, 4.850111));
            customMap.RouteCoordinates.Add(new Position(51.183376, 4.848226));



            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(51.175832, 4.825234), Distance.FromMiles(1.0)));
        }

        
    }
}

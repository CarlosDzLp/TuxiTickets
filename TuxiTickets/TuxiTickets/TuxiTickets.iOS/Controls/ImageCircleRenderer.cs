using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using TuxiTickets.Controls;
using TuxiTickets.iOS.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(ImageCircle),typeof(ImageCircleRenderer))]
namespace TuxiTickets.iOS.Controls
{
    [Preserve(AllMembers = true)]
    public class ImageCircleRenderer : ImageRenderer
    {
        const string borderName = "borderLayerName";
        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);
            if (Element == null)
                return;
            CreateCircle();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == VisualElement.HeightProperty.PropertyName ||
                e.PropertyName == VisualElement.WidthProperty.PropertyName ||
                e.PropertyName == ImageCircle.BorderColorProperty.PropertyName ||
                e.PropertyName == ImageCircle.BorderThicknessProperty.PropertyName ||
                e.PropertyName == ImageCircle.FillColorProperty.PropertyName)
            {
                CreateCircle();
            }
        }

        private void CreateCircle()
        {
            try
            {
                var min = Math.Min(Element.Width, Element.Height);
                Control.Layer.CornerRadius = (nfloat)(min / 2.0);
                Control.Layer.MasksToBounds = false;
                Control.BackgroundColor = ((ImageCircle)Element).FillColor.ToUIColor();
                Control.ClipsToBounds = true;
                var borderThickness = ((ImageCircle)Element).BorderThickness;
                //Remove previously added layers
                var tempLayer = Control.Layer.Sublayers?
                    .Where(p => p.Name == borderName)
                    .FirstOrDefault();
                tempLayer?.RemoveFromSuperLayer();
                var externalBorder = new CALayer();
                externalBorder.Name = borderName;
                externalBorder.CornerRadius = Control.Layer.CornerRadius;
                externalBorder.Frame = new CGRect(-.5, -.5, min + 1, min + 1);
                externalBorder.BorderColor = ((ImageCircle)Element).BorderColor.ToCGColor();
                externalBorder.BorderWidth = ((ImageCircle)Element).BorderThickness;
                Control.Layer.AddSublayer(externalBorder);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Unable to create circle image: " + ex);
            }
        }
    }
}
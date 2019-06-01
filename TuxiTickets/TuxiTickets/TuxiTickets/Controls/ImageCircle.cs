using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using  Xamarin.Forms;

namespace TuxiTickets.Controls
{
    [DesignTimeVisible(true)]
    public class ImageCircle : Image
    {
        public static readonly BindableProperty BorderThicknessProperty =
            BindableProperty.Create(propertyName: nameof(BorderThickness),
                returnType: typeof(float),
                declaringType: typeof(ImageCircle),
                defaultValue: 0F);

        public float BorderThickness
        {
            get { return (float)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(propertyName: nameof(BorderColor),
                returnType: typeof(Color),
                declaringType: typeof(ImageCircle),
                defaultValue: Color.White);

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty FillColorProperty =
            BindableProperty.Create(propertyName: nameof(FillColor),
                returnType: typeof(Color),
                declaringType: typeof(ImageCircle),
                defaultValue: Color.Transparent);

        public Color FillColor
        {
            get { return (Color)GetValue(FillColorProperty); }
            set { SetValue(FillColorProperty, value); }
        }
    }
}

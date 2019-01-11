new CarouselView
{
    ItemsSource = new List<object>
    {
        new { Image = "test.png", Title = "Test" },
        new { Image = "test.png", Title = "Test" },
        new { Image = "test.png", Title = "Test" }
    },

    ItemTemplate = new DataTemplate(() =>
    {
        Image imageCarousel = new Image { WidthRequest = 50 };
        imageCarousel.SetBinding(Image.SourceProperty, "Image");

        Label labelCarousel = new Label {  };
        labelCarousel.SetBinding(Label.TextProperty, "Title");

        var Frame = new Frame
        {
            Content = new StackLayout
            {
                Children = { imageCarousel, labelCarousel }

            }
        };

        Frame.On<Xamarin.Forms.PlatformConfiguration.iOS>()
           .SetIsShadowEnabled(true)
           .SetShadowColor(Color.Black)
           .SetShadowOffset(new Size(0, 7))
           .SetShadowOpacity(0.1)
           .SetShadowRadius(7);

        return Frame;

    })
}

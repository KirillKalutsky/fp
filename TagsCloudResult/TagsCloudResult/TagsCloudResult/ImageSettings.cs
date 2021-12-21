﻿using System.Drawing;

namespace TagsCloudContainer
{
    public class ImageSettings
    {
        public Size ImageSize { get; }
        public FontFamily FontFamily { get; }
        public Color TextColor { get; }
        public Color BackgroundColor { get; }

        public FontStyle FontStyle { get; }

        public ImageSettings(Size imageSize, FontFamily fontFamily, Color textColor, Color backgroundColor)
        {
            ImageSize = imageSize;
            FontFamily = fontFamily;
            TextColor = textColor;
            BackgroundColor = backgroundColor;
            FontStyle = FontStyle.Regular;
        }
    }
}

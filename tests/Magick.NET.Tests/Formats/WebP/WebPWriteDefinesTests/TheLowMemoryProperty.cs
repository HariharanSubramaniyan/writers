﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using ImageMagick;
using ImageMagick.Formats;
using Xunit;

namespace Magick.NET.Tests;

public partial class WebPWriteDefinesTests
{
    public class TheLowMemoryProperty : WebPWriteDefinesTests
    {
        [Fact]
        public void ShouldSetTheDefineWhenSetToTrue()
        {
            using var image = new MagickImage(Files.Builtin.Logo);
            image.Settings.SetDefines(new WebPWriteDefines
            {
                LowMemory = true,
            });

            Assert.Equal("true", image.Settings.GetDefine(MagickFormat.WebP, "low-memory"));
        }

        [Fact]
        public void ShouldSetTheDefineWhenSetToFalse()
        {
            using var image = new MagickImage();
            image.Settings.SetDefines(new WebPWriteDefines
            {
                LowMemory = false,
            });

            Assert.Equal("false", image.Settings.GetDefine(MagickFormat.WebP, "low-memory"));
        }
    }
}

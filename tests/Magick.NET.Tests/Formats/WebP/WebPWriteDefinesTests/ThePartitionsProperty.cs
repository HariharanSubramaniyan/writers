﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using ImageMagick;
using ImageMagick.Formats;
using Xunit;

namespace Magick.NET.Tests;

public partial class WebPWriteDefinesTests
{
    public class ThePartitionsProperty : WebPWriteDefinesTests
    {
        [Fact]
        public void ShouldSetTheDefine()
        {
            using var image = new MagickImage(Files.Builtin.Logo);
            image.Settings.SetDefines(new WebPWriteDefines
            {
                Partitions = 2,
            });

            Assert.Equal("2", image.Settings.GetDefine(MagickFormat.WebP, "partitions"));
        }
    }
}

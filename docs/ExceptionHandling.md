# Exception handling

## Exception handling

```C#
try
{
    // Read invalid jpg file
    using var image = new MagickImage(SampleFiles.InvalidFileJpg);
}
// Catch any MagickException
catch (MagickException exception)
{
    // Write excepion raised when reading the invalid jpg to the console
    Console.WriteLine(exception.Message);
}

try
{
    // Read corrupt jpg file
    using var image = new MagickImage(SampleFiles.CorruptImageJpg);
}
// Catch only MagickCorruptImageErrorException
catch (MagickCorruptImageErrorException exception)
{
    // Write excepion raised when reading the corrupt jpg to the console
    Console.WriteLine(exception.Message);
}
```

## Obtain warning that occurred during reading

```C#
using var image = new MagickImage();

// Attach event handler to warning event
image.Warning += MagickImage_Warning;

// Read file that will raise a warning.
image.Read(SampleFiles.FileWithWarningJpg);
```

using System;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Tools.rtv
{
    public  class ZipTools
    {

      public static byte[] Compress(byte[] data, bool bestCompression)
      {
          byte[] buffer;
          using (MemoryStream stream = new MemoryStream(data))
          {
              using (MemoryStream stream2 = new MemoryStream())
              {
                  Compress(stream, stream2, bestCompression);
                  buffer = stream2.ToArray();
              }
          }
          return buffer;
      }
      public static string Compress(string text, bool bestCompression)
      {
          string str;
          using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(text)))
          {
              using (MemoryStream stream2 = new MemoryStream())
              {
                  Compress(stream, stream2, bestCompression);
                  byte[] buffer = new byte[stream2.Length];
                  stream2.Read(buffer, 0, buffer.Length);
                  str = Convert.ToBase64String(buffer);
              }
          }
          return str;
      }
      public static void Compress(Stream source, Stream destination, bool bestCompression)
      {
          if (source.CanSeek)
          {
              source.Position = 0L;
          }
          using (Stream stream = new DeflateStream(destination,CompressionMode.Compress , true))
          {
              Pump(source, stream);
          }
          if (source.CanSeek)
          {
              source.Position = 0L;
          }
          if (destination.CanSeek)
          {
              destination.Position = 0L;
          }
      }

      public static void Compress(string sourceFilePath, string destinationFilePath, bool bestCompression)
      {
          long num;
          Compress(sourceFilePath, destinationFilePath, bestCompression, out num);
      }
      public static void Compress(string sourceFilePath, string destinationFilePath, bool bestCompression, out long compressedFileSize)
      {
          using (FileStream stream = File.OpenRead(sourceFilePath))
          {
              using (FileStream stream2 = File.Create(destinationFilePath))
              {
                  Compress(stream, stream2, bestCompression);
                  compressedFileSize = stream2.Length;
              }
          }
      }

      public static void CompressStreamToItself(Stream stream, bool bestCompression)
      {
          using (MemoryStream stream2 = new MemoryStream())
          {
              Compress(stream, stream2, bestCompression);
              stream.SetLength(0L);
              stream2.Position = 0L;
              stream2.WriteTo(stream);
              if (stream.CanSeek)
              {
                  stream.Position = 0L;
              }
          }
      }


      public static byte[] Decompress(byte[] data)
      {
          byte[] buffer;
          using (MemoryStream stream = new MemoryStream(data))
          {
              using (MemoryStream stream2 = new MemoryStream())
              {
                  Decompress(stream, stream2);
                  buffer = stream2.ToArray();
              }
          }
          return buffer;
      }


      public static string Decompress(string compressedText)
      {
          string str;
          byte[] buffer = Convert.FromBase64String(compressedText);
          using (MemoryStream stream = new MemoryStream())
          {
              stream.Write(buffer, 0, buffer.Length);
              using (MemoryStream stream2 = new MemoryStream())
              {
                  Decompress(stream, stream2);
                  byte[] buffer2 = new byte[stream2.Length];
                  stream2.Read(buffer2, 0, Convert.ToInt32(stream2.Length));
                  str = Encoding.UTF8.GetString(buffer2);
              }
          }
          return str;
      }


      public static void Decompress(Stream source, Stream destination)
      {
          if (source.CanSeek)
          {
              source.Position = 0L;
          }
          using (Stream stream = new DeflateStream(source,CompressionMode.Decompress, true))
          {
              Pump(stream, destination);
          }
          if (source.CanSeek)
          {
              source.Position = 0L;
          }
          if (destination.CanSeek)
          {
              destination.Position = 0L;
          }
      }

     




      public static void Decompress(string sourceFilePath, string destinationFilePath)
      {
          using (FileStream stream = File.OpenRead(sourceFilePath))
          {
              using (FileStream stream2 = File.Create(destinationFilePath))
              {
                  Decompress(stream, stream2);
              }
          }
      }


      public static MemoryStream DecompressAsMemoryStream(Stream source)
      {
          MemoryStream destination = new MemoryStream();
          Decompress(source, destination);
          return destination;
      }

      private static void Pump(Stream input, Stream output)
      {
          int num;
          if (input.CanSeek)
          {
              num = Convert.ToInt32(Math.Min((long)maxBufferSize, input.Length));
          }
          else
          {
              num = 0x2800;
          }
          byte[] buffer = new byte[num];
          try
          {
              int num2;
              while ((num2 = input.Read(buffer, 0, num)) > 0)
              {
                  output.Write(buffer, 0, num2);
                  if (!(input is DeflateStream) && (num2 < num))
                  {
                      return;
                  }
              }
          }
          catch (Exception exception)
          {
             // if (!(exception is ZlibException) || !exception.Message.Contains("inflating"))
             // {
                  throw exception;
              //}
          }
      }

      private static int maxBufferSize;



    }
}

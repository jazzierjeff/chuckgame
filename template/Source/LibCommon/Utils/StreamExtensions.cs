﻿using System;
using System.IO;

namespace LibCommon.Utils
{
    public static class StreamExtensions
    {
        public static byte[] ReadAllBytes(this Stream source)
        {
            byte[] readBuffer = new byte[4096];

            int totalBytesRead = 0;
            int bytesRead;

            while ((bytesRead = source.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
            {
                totalBytesRead += bytesRead;

                if (totalBytesRead != readBuffer.Length) continue;
                int nextByte = source.ReadByte();
                if (nextByte == -1) continue;

                byte[] temp = new byte[readBuffer.Length*2];
                Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                Buffer.SetByte(temp, totalBytesRead, (byte) nextByte);
                readBuffer = temp;
                totalBytesRead++;
            }

            byte[] buffer = readBuffer;
            if (readBuffer.Length != totalBytesRead)
            {
                buffer = new byte[totalBytesRead];
                Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
            }
            return buffer;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyTitle("protobuf3")]
[assembly: AssemblyDescription("Protocol Buffers 3 implementation for C#")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Google")]
[assembly: AssemblyProduct("Google.Protobuf")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("9f9d77b8-fa5e-4f1a-b3e7-03442b8ea892")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyVersion("3.1.0.0")]
namespace Google.Protobuf
{
	internal static class ByteArray
	{
		private const int CopyThreshold = 12;

		internal static void Copy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
		{
			if (count > 12)
			{
				Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
				return;
			}
			int num = srcOffset + count;
			for (int i = srcOffset; i < num; i++)
			{
				dst[dstOffset++] = src[i];
			}
		}

		internal static void Reverse(byte[] bytes)
		{
			int num = 0;
			int num2 = bytes.Length - 1;
			while (num < num2)
			{
				byte b = bytes[num];
				bytes[num] = bytes[num2];
				bytes[num2] = b;
				num++;
				num2--;
			}
		}
	}
	public sealed class ByteString : IEnumerable<byte>, IEnumerable, IEquatable<ByteString>
	{
		internal static class Unsafe
		{
			internal static ByteString FromBytes(byte[] bytes)
			{
				return new ByteString(bytes);
			}

			internal static byte[] GetBuffer(ByteString bytes)
			{
				return bytes.bytes;
			}
		}

		private static readonly ByteString empty = new ByteString(new byte[0]);

		private readonly byte[] bytes;

		public static ByteString Empty => empty;

		public int Length => bytes.Length;

		public bool IsEmpty => Length == 0;

		public byte this[int index] => bytes[index];

		internal static ByteString AttachBytes(byte[] bytes)
		{
			return new ByteString(bytes);
		}

		private ByteString(byte[] bytes)
		{
			this.bytes = bytes;
		}

		public byte[] ToByteArray()
		{
			return (byte[])bytes.Clone();
		}

		public string ToBase64()
		{
			return Convert.ToBase64String(bytes);
		}

		public static ByteString FromBase64(string bytes)
		{
			if (!(bytes == ""))
			{
				return new ByteString(Convert.FromBase64String(bytes));
			}
			return Empty;
		}

		public static ByteString CopyFrom(params byte[] bytes)
		{
			return new ByteString((byte[])bytes.Clone());
		}

		public static ByteString CopyFrom(byte[] bytes, int offset, int count)
		{
			byte[] dst = new byte[count];
			ByteArray.Copy(bytes, offset, dst, 0, count);
			return new ByteString(dst);
		}

		public static ByteString CopyFrom(string text, Encoding encoding)
		{
			return new ByteString(encoding.GetBytes(text));
		}

		public static ByteString CopyFromUtf8(string text)
		{
			return CopyFrom(text, Encoding.UTF8);
		}

		public string ToString(Encoding encoding)
		{
			return encoding.GetString(bytes, 0, bytes.Length);
		}

		public string ToStringUtf8()
		{
			return ToString(Encoding.UTF8);
		}

		public IEnumerator<byte> GetEnumerator()
		{
			return ((IEnumerable<byte>)bytes).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public CodedInputStream CreateCodedInput()
		{
			return new CodedInputStream(bytes);
		}

		public static bool operator ==(ByteString lhs, ByteString rhs)
		{
			if ((object)lhs == rhs)
			{
				return true;
			}
			if ((object)lhs == null || (object)rhs == null)
			{
				return false;
			}
			if (lhs.bytes.Length != rhs.bytes.Length)
			{
				return false;
			}
			for (int i = 0; i < lhs.Length; i++)
			{
				if (rhs.bytes[i] != lhs.bytes[i])
				{
					return false;
				}
			}
			return true;
		}

		public static bool operator !=(ByteString lhs, ByteString rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object obj)
		{
			return this == obj as ByteString;
		}

		public override int GetHashCode()
		{
			int num = 23;
			byte[] array = bytes;
			foreach (byte b in array)
			{
				num = (num << 8) | b;
			}
			return num;
		}

		public bool Equals(ByteString other)
		{
			return this == other;
		}

		internal void WriteRawBytesTo(CodedOutputStream outputStream)
		{
			outputStream.WriteRawBytes(bytes, 0, bytes.Length);
		}

		public void CopyTo(byte[] array, int position)
		{
			ByteArray.Copy(bytes, 0, array, position, bytes.Length);
		}

		public void WriteTo(Stream outputStream)
		{
			outputStream.Write(bytes, 0, bytes.Length);
		}
	}
	public sealed class CodedInputStream : IDisposable
	{
		private readonly bool leaveOpen;

		private readonly byte[] buffer;

		private int bufferSize;

		private int bufferSizeAfterLimit;

		private int bufferPos;

		private readonly Stream input;

		private uint lastTag;

		private uint nextTag;

		private bool hasNextTag;

		internal const int DefaultRecursionLimit = 64;

		internal const int DefaultSizeLimit = 67108864;

		internal const int BufferSize = 4096;

		private int totalBytesRetired;

		private int currentLimit = int.MaxValue;

		private int recursionDepth;

		private readonly int recursionLimit;

		private readonly int sizeLimit;

		public long Position
		{
			get
			{
				if (input != null)
				{
					return input.Position - (bufferSize + bufferSizeAfterLimit - bufferPos);
				}
				return bufferPos;
			}
		}

		internal uint LastTag => lastTag;

		public int SizeLimit => sizeLimit;

		public int RecursionLimit => recursionLimit;

		internal bool ReachedLimit
		{
			get
			{
				if (currentLimit == int.MaxValue)
				{
					return false;
				}
				return totalBytesRetired + bufferPos >= currentLimit;
			}
		}

		public bool IsAtEnd
		{
			get
			{
				if (bufferPos == bufferSize)
				{
					return !RefillBuffer(mustSucceed: false);
				}
				return false;
			}
		}

		public CodedInputStream(byte[] buffer)
			: this(null, ProtoPreconditions.CheckNotNull(buffer, "buffer"), 0, buffer.Length)
		{
		}

		public CodedInputStream(byte[] buffer, int offset, int length)
			: this(null, ProtoPreconditions.CheckNotNull(buffer, "buffer"), offset, offset + length)
		{
			if (offset < 0 || offset > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offset", "Offset must be within the buffer");
			}
			if (length < 0 || offset + length > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("length", "Length must be non-negative and within the buffer");
			}
		}

		public CodedInputStream(Stream input)
			: this(input, leaveOpen: false)
		{
		}

		public CodedInputStream(Stream input, bool leaveOpen)
			: this(ProtoPreconditions.CheckNotNull(input, "input"), new byte[4096], 0, 0)
		{
			this.leaveOpen = leaveOpen;
		}

		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize)
		{
			this.input = input;
			this.buffer = buffer;
			this.bufferPos = bufferPos;
			this.bufferSize = bufferSize;
			sizeLimit = 67108864;
			recursionLimit = 64;
		}

		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, int sizeLimit, int recursionLimit)
			: this(input, buffer, bufferPos, bufferSize)
		{
			if (sizeLimit <= 0)
			{
				throw new ArgumentOutOfRangeException("sizeLimit", "Size limit must be positive");
			}
			if (recursionLimit <= 0)
			{
				throw new ArgumentOutOfRangeException("recursionLimit!", "Recursion limit must be positive");
			}
			this.sizeLimit = sizeLimit;
			this.recursionLimit = recursionLimit;
		}

		public static CodedInputStream CreateWithLimits(Stream input, int sizeLimit, int recursionLimit)
		{
			return new CodedInputStream(input, new byte[4096], 0, 0, sizeLimit, recursionLimit);
		}

		public void Dispose()
		{
			if (!leaveOpen)
			{
				input.Dispose();
			}
		}

		internal void CheckReadEndOfStreamTag()
		{
			if (lastTag != 0)
			{
				throw InvalidProtocolBufferException.MoreDataAvailable();
			}
		}

		public uint PeekTag()
		{
			if (hasNextTag)
			{
				return nextTag;
			}
			uint num = lastTag;
			nextTag = ReadTag();
			hasNextTag = true;
			lastTag = num;
			return nextTag;
		}

		public uint ReadTag()
		{
			if (hasNextTag)
			{
				lastTag = nextTag;
				hasNextTag = false;
				return lastTag;
			}
			if (bufferPos + 2 <= bufferSize)
			{
				int num = buffer[bufferPos++];
				if (num < 128)
				{
					lastTag = (uint)num;
				}
				else
				{
					int num2 = num & 0x7F;
					if ((num = buffer[bufferPos++]) < 128)
					{
						num2 |= num << 7;
						lastTag = (uint)num2;
					}
					else
					{
						bufferPos -= 2;
						lastTag = ReadRawVarint32();
					}
				}
			}
			else
			{
				if (IsAtEnd)
				{
					lastTag = 0u;
					return 0u;
				}
				lastTag = ReadRawVarint32();
			}
			if (lastTag == 0)
			{
				throw InvalidProtocolBufferException.InvalidTag();
			}
			return lastTag;
		}

		public void SkipLastField()
		{
			if (lastTag == 0)
			{
				throw new InvalidOperationException("SkipLastField cannot be called at the end of a stream");
			}
			switch (WireFormat.GetTagWireType(lastTag))
			{
			case WireFormat.WireType.StartGroup:
				SkipGroup(lastTag);
				break;
			case WireFormat.WireType.EndGroup:
				throw new InvalidProtocolBufferException("SkipLastField called on an end-group tag, indicating that the corresponding start-group was missing");
			case WireFormat.WireType.Fixed32:
				ReadFixed32();
				break;
			case WireFormat.WireType.Fixed64:
				ReadFixed64();
				break;
			case WireFormat.WireType.LengthDelimited:
			{
				int size = ReadLength();
				SkipRawBytes(size);
				break;
			}
			case WireFormat.WireType.Varint:
				ReadRawVarint32();
				break;
			}
		}

		private void SkipGroup(uint startGroupTag)
		{
			recursionDepth++;
			if (recursionDepth >= recursionLimit)
			{
				throw InvalidProtocolBufferException.RecursionLimitExceeded();
			}
			uint num;
			while (true)
			{
				num = ReadTag();
				if (num == 0)
				{
					throw InvalidProtocolBufferException.TruncatedMessage();
				}
				if (WireFormat.GetTagWireType(num) == WireFormat.WireType.EndGroup)
				{
					break;
				}
				SkipLastField();
			}
			int tagFieldNumber = WireFormat.GetTagFieldNumber(startGroupTag);
			int tagFieldNumber2 = WireFormat.GetTagFieldNumber(num);
			if (tagFieldNumber != tagFieldNumber2)
			{
				throw new InvalidProtocolBufferException($"Mismatched end-group tag. Started with field {tagFieldNumber}; ended with field {tagFieldNumber2}");
			}
			recursionDepth--;
		}

		public double ReadDouble()
		{
			return BitConverter.Int64BitsToDouble((long)ReadRawLittleEndian64());
		}

		public float ReadFloat()
		{
			if (BitConverter.IsLittleEndian && 4 <= bufferSize - bufferPos)
			{
				float result = BitConverter.ToSingle(buffer, bufferPos);
				bufferPos += 4;
				return result;
			}
			byte[] array = ReadRawBytes(4);
			if (!BitConverter.IsLittleEndian)
			{
				ByteArray.Reverse(array);
			}
			return BitConverter.ToSingle(array, 0);
		}

		public ulong ReadUInt64()
		{
			return ReadRawVarint64();
		}

		public long ReadInt64()
		{
			return (long)ReadRawVarint64();
		}

		public int ReadInt32()
		{
			return (int)ReadRawVarint32();
		}

		public ulong ReadFixed64()
		{
			return ReadRawLittleEndian64();
		}

		public uint ReadFixed32()
		{
			return ReadRawLittleEndian32();
		}

		public bool ReadBool()
		{
			return ReadRawVarint32() != 0;
		}

		public string ReadString()
		{
			int num = ReadLength();
			if (num == 0)
			{
				return "";
			}
			if (num <= bufferSize - bufferPos)
			{
				string result = CodedOutputStream.Utf8Encoding.GetString(buffer, bufferPos, num);
				bufferPos += num;
				return result;
			}
			return CodedOutputStream.Utf8Encoding.GetString(ReadRawBytes(num), 0, num);
		}

		public void ReadMessage(IMessage builder)
		{
			int byteLimit = ReadLength();
			if (recursionDepth >= recursionLimit)
			{
				throw InvalidProtocolBufferException.RecursionLimitExceeded();
			}
			int oldLimit = PushLimit(byteLimit);
			recursionDepth++;
			builder.MergeFrom(this);
			CheckReadEndOfStreamTag();
			if (!ReachedLimit)
			{
				throw InvalidProtocolBufferException.TruncatedMessage();
			}
			recursionDepth--;
			PopLimit(oldLimit);
		}

		public ByteString ReadBytes()
		{
			int num = ReadLength();
			if (num <= bufferSize - bufferPos && num > 0)
			{
				ByteString result = ByteString.CopyFrom(buffer, bufferPos, num);
				bufferPos += num;
				return result;
			}
			return ByteString.AttachBytes(ReadRawBytes(num));
		}

		public uint ReadUInt32()
		{
			return ReadRawVarint32();
		}

		public int ReadEnum()
		{
			return (int)ReadRawVarint32();
		}

		public int ReadSFixed32()
		{
			return (int)ReadRawLittleEndian32();
		}

		public long ReadSFixed64()
		{
			return (long)ReadRawLittleEndian64();
		}

		public int ReadSInt32()
		{
			return DecodeZigZag32(ReadRawVarint32());
		}

		public long ReadSInt64()
		{
			return DecodeZigZag64(ReadRawVarint64());
		}

		public int ReadLength()
		{
			return (int)ReadRawVarint32();
		}

		public bool MaybeConsumeTag(uint tag)
		{
			if (PeekTag() == tag)
			{
				hasNextTag = false;
				return true;
			}
			return false;
		}

		private uint SlowReadRawVarint32()
		{
			int num = ReadRawByte();
			if (num < 128)
			{
				return (uint)num;
			}
			int num2 = num & 0x7F;
			if ((num = ReadRawByte()) < 128)
			{
				num2 |= num << 7;
			}
			else
			{
				num2 |= (num & 0x7F) << 7;
				if ((num = ReadRawByte()) < 128)
				{
					num2 |= num << 14;
				}
				else
				{
					num2 |= (num & 0x7F) << 14;
					if ((num = ReadRawByte()) < 128)
					{
						num2 |= num << 21;
					}
					else
					{
						num2 |= (num & 0x7F) << 21;
						num2 |= (num = ReadRawByte()) << 28;
						if (num >= 128)
						{
							for (int i = 0; i < 5; i++)
							{
								if (ReadRawByte() < 128)
								{
									return (uint)num2;
								}
							}
							throw InvalidProtocolBufferException.MalformedVarint();
						}
					}
				}
			}
			return (uint)num2;
		}

		internal uint ReadRawVarint32()
		{
			if (bufferPos + 5 > bufferSize)
			{
				return SlowReadRawVarint32();
			}
			int num = buffer[bufferPos++];
			if (num < 128)
			{
				return (uint)num;
			}
			int num2 = num & 0x7F;
			if ((num = buffer[bufferPos++]) < 128)
			{
				num2 |= num << 7;
			}
			else
			{
				num2 |= (num & 0x7F) << 7;
				if ((num = buffer[bufferPos++]) < 128)
				{
					num2 |= num << 14;
				}
				else
				{
					num2 |= (num & 0x7F) << 14;
					if ((num = buffer[bufferPos++]) < 128)
					{
						num2 |= num << 21;
					}
					else
					{
						num2 |= (num & 0x7F) << 21;
						num2 |= (num = buffer[bufferPos++]) << 28;
						if (num >= 128)
						{
							for (int i = 0; i < 5; i++)
							{
								if (ReadRawByte() < 128)
								{
									return (uint)num2;
								}
							}
							throw InvalidProtocolBufferException.MalformedVarint();
						}
					}
				}
			}
			return (uint)num2;
		}

		internal static uint ReadRawVarint32(Stream input)
		{
			int num = 0;
			int i;
			for (i = 0; i < 32; i += 7)
			{
				int num2 = input.ReadByte();
				if (num2 == -1)
				{
					throw InvalidProtocolBufferException.TruncatedMessage();
				}
				num |= (num2 & 0x7F) << i;
				if ((num2 & 0x80) == 0)
				{
					return (uint)num;
				}
			}
			for (; i < 64; i += 7)
			{
				int num3 = input.ReadByte();
				if (num3 == -1)
				{
					throw InvalidProtocolBufferException.TruncatedMessage();
				}
				if ((num3 & 0x80) == 0)
				{
					return (uint)num;
				}
			}
			throw InvalidProtocolBufferException.MalformedVarint();
		}

		internal ulong ReadRawVarint64()
		{
			int i = 0;
			ulong num = 0uL;
			for (; i < 64; i += 7)
			{
				byte b = ReadRawByte();
				num |= (ulong)((long)(b & 0x7F) << i);
				if ((b & 0x80) == 0)
				{
					return num;
				}
			}
			throw InvalidProtocolBufferException.MalformedVarint();
		}

		internal uint ReadRawLittleEndian32()
		{
			byte num = ReadRawByte();
			uint num2 = ReadRawByte();
			uint num3 = ReadRawByte();
			uint num4 = ReadRawByte();
			return num | (num2 << 8) | (num3 << 16) | (num4 << 24);
		}

		internal ulong ReadRawLittleEndian64()
		{
			long num = ReadRawByte();
			ulong num2 = ReadRawByte();
			ulong num3 = ReadRawByte();
			ulong num4 = ReadRawByte();
			ulong num5 = ReadRawByte();
			ulong num6 = ReadRawByte();
			ulong num7 = ReadRawByte();
			ulong num8 = ReadRawByte();
			return (ulong)num | (num2 << 8) | (num3 << 16) | (num4 << 24) | (num5 << 32) | (num6 << 40) | (num7 << 48) | (num8 << 56);
		}

		internal static int DecodeZigZag32(uint n)
		{
			return (int)((n >> 1) ^ (0 - (n & 1)));
		}

		internal static long DecodeZigZag64(ulong n)
		{
			return (long)((n >> 1) ^ (0L - (n & 1)));
		}

		internal int PushLimit(int byteLimit)
		{
			if (byteLimit < 0)
			{
				throw InvalidProtocolBufferException.NegativeSize();
			}
			byteLimit += totalBytesRetired + bufferPos;
			int num = currentLimit;
			if (byteLimit > num)
			{
				throw InvalidProtocolBufferException.TruncatedMessage();
			}
			currentLimit = byteLimit;
			RecomputeBufferSizeAfterLimit();
			return num;
		}

		private void RecomputeBufferSizeAfterLimit()
		{
			bufferSize += bufferSizeAfterLimit;
			int num = totalBytesRetired + bufferSize;
			if (num > currentLimit)
			{
				bufferSizeAfterLimit = num - currentLimit;
				bufferSize -= bufferSizeAfterLimit;
			}
			else
			{
				bufferSizeAfterLimit = 0;
			}
		}

		internal void PopLimit(int oldLimit)
		{
			currentLimit = oldLimit;
			RecomputeBufferSizeAfterLimit();
		}

		private bool RefillBuffer(bool mustSucceed)
		{
			if (bufferPos < bufferSize)
			{
				throw new InvalidOperationException("RefillBuffer() called when buffer wasn't empty.");
			}
			if (totalBytesRetired + bufferSize == currentLimit)
			{
				if (mustSucceed)
				{
					throw InvalidProtocolBufferException.TruncatedMessage();
				}
				return false;
			}
			totalBytesRetired += bufferSize;
			bufferPos = 0;
			bufferSize = ((input != null) ? input.Read(buffer, 0, buffer.Length) : 0);
			if (bufferSize < 0)
			{
				throw new InvalidOperationException("Stream.Read returned a negative count");
			}
			if (bufferSize == 0)
			{
				if (mustSucceed)
				{
					throw InvalidProtocolBufferException.TruncatedMessage();
				}
				return false;
			}
			RecomputeBufferSizeAfterLimit();
			int num = totalBytesRetired + bufferSize + bufferSizeAfterLimit;
			if (num > sizeLimit || num < 0)
			{
				throw InvalidProtocolBufferException.SizeLimitExceeded();
			}
			return true;
		}

		internal byte ReadRawByte()
		{
			if (bufferPos == bufferSize)
			{
				RefillBuffer(mustSucceed: true);
			}
			return buffer[bufferPos++];
		}

		internal byte[] ReadRawBytes(int size)
		{
			if (size < 0)
			{
				throw InvalidProtocolBufferException.NegativeSize();
			}
			if (totalBytesRetired + bufferPos + size > currentLimit)
			{
				SkipRawBytes(currentLimit - totalBytesRetired - bufferPos);
				throw InvalidProtocolBufferException.TruncatedMessage();
			}
			if (size <= bufferSize - bufferPos)
			{
				byte[] array = new byte[size];
				ByteArray.Copy(buffer, bufferPos, array, 0, size);
				bufferPos += size;
				return array;
			}
			if (size < buffer.Length)
			{
				byte[] array2 = new byte[size];
				int num = bufferSize - bufferPos;
				ByteArray.Copy(buffer, bufferPos, array2, 0, num);
				bufferPos = bufferSize;
				RefillBuffer(mustSucceed: true);
				while (size - num > bufferSize)
				{
					Buffer.BlockCopy(buffer, 0, array2, num, bufferSize);
					num += bufferSize;
					bufferPos = bufferSize;
					RefillBuffer(mustSucceed: true);
				}
				ByteArray.Copy(buffer, 0, array2, num, size - num);
				bufferPos = size - num;
				return array2;
			}
			int num2 = bufferPos;
			int num3 = bufferSize;
			totalBytesRetired += bufferSize;
			bufferPos = 0;
			bufferSize = 0;
			int num4 = size - (num3 - num2);
			List<byte[]> list = new List<byte[]>();
			while (num4 > 0)
			{
				byte[] array3 = new byte[Math.Min(num4, buffer.Length)];
				int num5;
				for (int i = 0; i < array3.Length; i += num5)
				{
					num5 = ((input == null) ? (-1) : input.Read(array3, i, array3.Length - i));
					if (num5 <= 0)
					{
						throw InvalidProtocolBufferException.TruncatedMessage();
					}
					totalBytesRetired += num5;
				}
				num4 -= array3.Length;
				list.Add(array3);
			}
			byte[] array4 = new byte[size];
			int num6 = num3 - num2;
			ByteArray.Copy(buffer, num2, array4, 0, num6);
			foreach (byte[] item in list)
			{
				Buffer.BlockCopy(item, 0, array4, num6, item.Length);
				num6 += item.Length;
			}
			return array4;
		}

		private void SkipRawBytes(int size)
		{
			if (size < 0)
			{
				throw InvalidProtocolBufferException.NegativeSize();
			}
			if (totalBytesRetired + bufferPos + size > currentLimit)
			{
				SkipRawBytes(currentLimit - totalBytesRetired - bufferPos);
				throw InvalidProtocolBufferException.TruncatedMessage();
			}
			if (size <= bufferSize - bufferPos)
			{
				bufferPos += size;
				return;
			}
			int num = bufferSize - bufferPos;
			totalBytesRetired += bufferSize;
			bufferPos = 0;
			bufferSize = 0;
			if (num < size)
			{
				if (input == null)
				{
					throw InvalidProtocolBufferException.TruncatedMessage();
				}
				SkipImpl(size - num);
				totalBytesRetired += size - num;
			}
		}

		private void SkipImpl(int amountToSkip)
		{
			if (input.CanSeek)
			{
				long position = input.Position;
				input.Position += amountToSkip;
				if (input.Position != position + amountToSkip)
				{
					throw InvalidProtocolBufferException.TruncatedMessage();
				}
				return;
			}
			byte[] array = new byte[Math.Min(1024, amountToSkip)];
			while (amountToSkip > 0)
			{
				int num = input.Read(array, 0, Math.Min(array.Length, amountToSkip));
				if (num <= 0)
				{
					throw InvalidProtocolBufferException.TruncatedMessage();
				}
				amountToSkip -= num;
			}
		}
	}
	public sealed class CodedOutputStream : IDisposable
	{
		public sealed class OutOfSpaceException : IOException
		{
			internal OutOfSpaceException()
				: base("CodedOutputStream was writing to a flat byte array and ran out of space.")
			{
			}
		}

		private const int LittleEndian64Size = 8;

		private const int LittleEndian32Size = 4;

		internal static readonly Encoding Utf8Encoding = Encoding.UTF8;

		public static readonly int DefaultBufferSize = 4096;

		private readonly bool leaveOpen;

		private readonly byte[] buffer;

		private readonly int limit;

		private int position;

		private readonly Stream output;

		public long Position
		{
			get
			{
				if (output != null)
				{
					return output.Position + position;
				}
				return position;
			}
		}

		public int SpaceLeft
		{
			get
			{
				if (output == null)
				{
					return limit - position;
				}
				throw new InvalidOperationException("SpaceLeft can only be called on CodedOutputStreams that are writing to a flat array.");
			}
		}

		public static int ComputeDoubleSize(double value)
		{
			return 8;
		}

		public static int ComputeFloatSize(float value)
		{
			return 4;
		}

		public static int ComputeUInt64Size(ulong value)
		{
			return ComputeRawVarint64Size(value);
		}

		public static int ComputeInt64Size(long value)
		{
			return ComputeRawVarint64Size((ulong)value);
		}

		public static int ComputeInt32Size(int value)
		{
			if (value >= 0)
			{
				return ComputeRawVarint32Size((uint)value);
			}
			return 10;
		}

		public static int ComputeFixed64Size(ulong value)
		{
			return 8;
		}

		public static int ComputeFixed32Size(uint value)
		{
			return 4;
		}

		public static int ComputeBoolSize(bool value)
		{
			return 1;
		}

		public static int ComputeStringSize(string value)
		{
			int byteCount = Utf8Encoding.GetByteCount(value);
			return ComputeLengthSize(byteCount) + byteCount;
		}

		public static int ComputeGroupSize(IMessage value)
		{
			return value.CalculateSize();
		}

		public static int ComputeMessageSize(IMessage value)
		{
			int num = value.CalculateSize();
			return ComputeLengthSize(num) + num;
		}

		public static int ComputeBytesSize(ByteString value)
		{
			return ComputeLengthSize(value.Length) + value.Length;
		}

		public static int ComputeUInt32Size(uint value)
		{
			return ComputeRawVarint32Size(value);
		}

		public static int ComputeEnumSize(int value)
		{
			return ComputeInt32Size(value);
		}

		public static int ComputeSFixed32Size(int value)
		{
			return 4;
		}

		public static int ComputeSFixed64Size(long value)
		{
			return 8;
		}

		public static int ComputeSInt32Size(int value)
		{
			return ComputeRawVarint32Size(EncodeZigZag32(value));
		}

		public static int ComputeSInt64Size(long value)
		{
			return ComputeRawVarint64Size(EncodeZigZag64(value));
		}

		public static int ComputeLengthSize(int length)
		{
			return ComputeRawVarint32Size((uint)length);
		}

		public static int ComputeRawVarint32Size(uint value)
		{
			if ((value & 0xFFFFFF80u) == 0)
			{
				return 1;
			}
			if ((value & 0xFFFFC000u) == 0)
			{
				return 2;
			}
			if ((value & 0xFFE00000u) == 0)
			{
				return 3;
			}
			if ((value & 0xF0000000u) == 0)
			{
				return 4;
			}
			return 5;
		}

		public static int ComputeRawVarint64Size(ulong value)
		{
			if ((value & 0xFFFFFFFFFFFFFF80uL) == 0L)
			{
				return 1;
			}
			if ((value & 0xFFFFFFFFFFFFC000uL) == 0L)
			{
				return 2;
			}
			if ((value & 0xFFFFFFFFFFE00000uL) == 0L)
			{
				return 3;
			}
			if ((value & 0xFFFFFFFFF0000000uL) == 0L)
			{
				return 4;
			}
			if ((value & 0xFFFFFFF800000000uL) == 0L)
			{
				return 5;
			}
			if ((value & 0xFFFFFC0000000000uL) == 0L)
			{
				return 6;
			}
			if ((value & 0xFFFE000000000000uL) == 0L)
			{
				return 7;
			}
			if ((value & 0xFF00000000000000uL) == 0L)
			{
				return 8;
			}
			if ((value & 0x8000000000000000uL) == 0L)
			{
				return 9;
			}
			return 10;
		}

		public static int ComputeTagSize(int fieldNumber)
		{
			return ComputeRawVarint32Size(WireFormat.MakeTag(fieldNumber, WireFormat.WireType.Varint));
		}

		public CodedOutputStream(byte[] flatArray)
			: this(flatArray, 0, flatArray.Length)
		{
		}

		private CodedOutputStream(byte[] buffer, int offset, int length)
		{
			output = null;
			this.buffer = buffer;
			position = offset;
			limit = offset + length;
			leaveOpen = true;
		}

		private CodedOutputStream(Stream output, byte[] buffer, bool leaveOpen)
		{
			this.output = ProtoPreconditions.CheckNotNull(output, "output");
			this.buffer = buffer;
			position = 0;
			limit = buffer.Length;
			this.leaveOpen = leaveOpen;
		}

		public CodedOutputStream(Stream output)
			: this(output, DefaultBufferSize, leaveOpen: false)
		{
		}

		public CodedOutputStream(Stream output, int bufferSize)
			: this(output, new byte[bufferSize], leaveOpen: false)
		{
		}

		public CodedOutputStream(Stream output, bool leaveOpen)
			: this(output, DefaultBufferSize, leaveOpen)
		{
		}

		public CodedOutputStream(Stream output, int bufferSize, bool leaveOpen)
			: this(output, new byte[bufferSize], leaveOpen)
		{
		}

		public void WriteDouble(double value)
		{
			WriteRawLittleEndian64((ulong)BitConverter.DoubleToInt64Bits(value));
		}

		public void WriteFloat(float value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if (!BitConverter.IsLittleEndian)
			{
				ByteArray.Reverse(bytes);
			}
			if (limit - position >= 4)
			{
				buffer[position++] = bytes[0];
				buffer[position++] = bytes[1];
				buffer[position++] = bytes[2];
				buffer[position++] = bytes[3];
			}
			else
			{
				WriteRawBytes(bytes, 0, 4);
			}
		}

		public void WriteUInt64(ulong value)
		{
			WriteRawVarint64(value);
		}

		public void WriteInt64(long value)
		{
			WriteRawVarint64((ulong)value);
		}

		public void WriteInt32(int value)
		{
			if (value >= 0)
			{
				WriteRawVarint32((uint)value);
			}
			else
			{
				WriteRawVarint64((ulong)value);
			}
		}

		public void WriteFixed64(ulong value)
		{
			WriteRawLittleEndian64(value);
		}

		public void WriteFixed32(uint value)
		{
			WriteRawLittleEndian32(value);
		}

		public void WriteBool(bool value)
		{
			WriteRawByte((byte)(value ? 1 : 0));
		}

		public void WriteString(string value)
		{
			int byteCount = Utf8Encoding.GetByteCount(value);
			WriteLength(byteCount);
			if (limit - position >= byteCount)
			{
				if (byteCount == value.Length)
				{
					for (int i = 0; i < byteCount; i++)
					{
						buffer[position + i] = (byte)value[i];
					}
				}
				else
				{
					Utf8Encoding.GetBytes(value, 0, value.Length, buffer, position);
				}
				position += byteCount;
			}
			else
			{
				byte[] bytes = Utf8Encoding.GetBytes(value);
				WriteRawBytes(bytes);
			}
		}

		public void WriteMessage(IMessage value)
		{
			WriteLength(value.CalculateSize());
			value.WriteTo(this);
		}

		public void WriteBytes(ByteString value)
		{
			WriteLength(value.Length);
			value.WriteRawBytesTo(this);
		}

		public void WriteUInt32(uint value)
		{
			WriteRawVarint32(value);
		}

		public void WriteEnum(int value)
		{
			WriteInt32(value);
		}

		public void WriteSFixed32(int value)
		{
			WriteRawLittleEndian32((uint)value);
		}

		public void WriteSFixed64(long value)
		{
			WriteRawLittleEndian64((ulong)value);
		}

		public void WriteSInt32(int value)
		{
			WriteRawVarint32(EncodeZigZag32(value));
		}

		public void WriteSInt64(long value)
		{
			WriteRawVarint64(EncodeZigZag64(value));
		}

		public void WriteLength(int length)
		{
			WriteRawVarint32((uint)length);
		}

		public void WriteTag(int fieldNumber, WireFormat.WireType type)
		{
			WriteRawVarint32(WireFormat.MakeTag(fieldNumber, type));
		}

		public void WriteTag(uint tag)
		{
			WriteRawVarint32(tag);
		}

		public void WriteRawTag(byte b1)
		{
			WriteRawByte(b1);
		}

		public void WriteRawTag(byte b1, byte b2)
		{
			WriteRawByte(b1);
			WriteRawByte(b2);
		}

		public void WriteRawTag(byte b1, byte b2, byte b3)
		{
			WriteRawByte(b1);
			WriteRawByte(b2);
			WriteRawByte(b3);
		}

		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4)
		{
			WriteRawByte(b1);
			WriteRawByte(b2);
			WriteRawByte(b3);
			WriteRawByte(b4);
		}

		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5)
		{
			WriteRawByte(b1);
			WriteRawByte(b2);
			WriteRawByte(b3);
			WriteRawByte(b4);
			WriteRawByte(b5);
		}

		internal void WriteRawVarint32(uint value)
		{
			if (value < 128 && position < limit)
			{
				buffer[position++] = (byte)value;
				return;
			}
			while (value > 127 && position < limit)
			{
				buffer[position++] = (byte)((value & 0x7F) | 0x80);
				value >>= 7;
			}
			while (value > 127)
			{
				WriteRawByte((byte)((value & 0x7F) | 0x80));
				value >>= 7;
			}
			if (position < limit)
			{
				buffer[position++] = (byte)value;
			}
			else
			{
				WriteRawByte((byte)value);
			}
		}

		internal void WriteRawVarint64(ulong value)
		{
			while (value > 127 && position < limit)
			{
				buffer[position++] = (byte)((value & 0x7F) | 0x80);
				value >>= 7;
			}
			while (value > 127)
			{
				WriteRawByte((byte)((value & 0x7F) | 0x80));
				value >>= 7;
			}
			if (position < limit)
			{
				buffer[position++] = (byte)value;
			}
			else
			{
				WriteRawByte((byte)value);
			}
		}

		internal void WriteRawLittleEndian32(uint value)
		{
			if (position + 4 > limit)
			{
				WriteRawByte((byte)value);
				WriteRawByte((byte)(value >> 8));
				WriteRawByte((byte)(value >> 16));
				WriteRawByte((byte)(value >> 24));
			}
			else
			{
				buffer[position++] = (byte)value;
				buffer[position++] = (byte)(value >> 8);
				buffer[position++] = (byte)(value >> 16);
				buffer[position++] = (byte)(value >> 24);
			}
		}

		internal void WriteRawLittleEndian64(ulong value)
		{
			if (position + 8 > limit)
			{
				WriteRawByte((byte)value);
				WriteRawByte((byte)(value >> 8));
				WriteRawByte((byte)(value >> 16));
				WriteRawByte((byte)(value >> 24));
				WriteRawByte((byte)(value >> 32));
				WriteRawByte((byte)(value >> 40));
				WriteRawByte((byte)(value >> 48));
				WriteRawByte((byte)(value >> 56));
			}
			else
			{
				buffer[position++] = (byte)value;
				buffer[position++] = (byte)(value >> 8);
				buffer[position++] = (byte)(value >> 16);
				buffer[position++] = (byte)(value >> 24);
				buffer[position++] = (byte)(value >> 32);
				buffer[position++] = (byte)(value >> 40);
				buffer[position++] = (byte)(value >> 48);
				buffer[position++] = (byte)(value >> 56);
			}
		}

		internal void WriteRawByte(byte value)
		{
			if (position == limit)
			{
				RefreshBuffer();
			}
			buffer[position++] = value;
		}

		internal void WriteRawByte(uint value)
		{
			WriteRawByte((byte)value);
		}

		internal void WriteRawBytes(byte[] value)
		{
			WriteRawBytes(value, 0, value.Length);
		}

		internal void WriteRawBytes(byte[] value, int offset, int length)
		{
			if (limit - position >= length)
			{
				ByteArray.Copy(value, offset, buffer, position, length);
				position += length;
				return;
			}
			int num = limit - position;
			ByteArray.Copy(value, offset, buffer, position, num);
			offset += num;
			length -= num;
			position = limit;
			RefreshBuffer();
			if (length <= limit)
			{
				ByteArray.Copy(value, offset, buffer, 0, length);
				position = length;
			}
			else
			{
				output.Write(value, offset, length);
			}
		}

		internal static uint EncodeZigZag32(int n)
		{
			return (uint)((n << 1) ^ (n >> 31));
		}

		internal static ulong EncodeZigZag64(long n)
		{
			return (ulong)((n << 1) ^ (n >> 63));
		}

		private void RefreshBuffer()
		{
			if (output == null)
			{
				throw new OutOfSpaceException();
			}
			output.Write(buffer, 0, position);
			position = 0;
		}

		public void Dispose()
		{
			Flush();
			if (!leaveOpen)
			{
				output.Dispose();
			}
		}

		public void Flush()
		{
			if (output != null)
			{
				RefreshBuffer();
			}
		}

		public void CheckNoSpaceLeft()
		{
			if (SpaceLeft != 0)
			{
				throw new InvalidOperationException("Did not write as much data as expected.");
			}
		}
	}
	public static class FieldCodec
	{
		private static class WrapperCodecs
		{
			private static readonly Dictionary<System.Type, object> Codecs = new Dictionary<System.Type, object>
			{
				{
					typeof(bool),
					ForBool(WireFormat.MakeTag(1, WireFormat.WireType.Varint))
				},
				{
					typeof(int),
					ForInt32(WireFormat.MakeTag(1, WireFormat.WireType.Varint))
				},
				{
					typeof(long),
					ForInt64(WireFormat.MakeTag(1, WireFormat.WireType.Varint))
				},
				{
					typeof(uint),
					ForUInt32(WireFormat.MakeTag(1, WireFormat.WireType.Varint))
				},
				{
					typeof(ulong),
					ForUInt64(WireFormat.MakeTag(1, WireFormat.WireType.Varint))
				},
				{
					typeof(float),
					ForFloat(WireFormat.MakeTag(1, WireFormat.WireType.Fixed32))
				},
				{
					typeof(double),
					ForDouble(WireFormat.MakeTag(1, WireFormat.WireType.Fixed64))
				},
				{
					typeof(string),
					ForString(WireFormat.MakeTag(1, WireFormat.WireType.LengthDelimited))
				},
				{
					typeof(ByteString),
					ForBytes(WireFormat.MakeTag(1, WireFormat.WireType.LengthDelimited))
				}
			};

			internal static FieldCodec<T> GetCodec<T>()
			{
				if (!Codecs.TryGetValue(typeof(T), out var value))
				{
					throw new InvalidOperationException("Invalid type argument requested for wrapper codec: " + typeof(T));
				}
				return (FieldCodec<T>)value;
			}

			internal static T Read<T>(CodedInputStream input, FieldCodec<T> codec)
			{
				int byteLimit = input.ReadLength();
				int oldLimit = input.PushLimit(byteLimit);
				T result = codec.DefaultValue;
				uint num;
				while ((num = input.ReadTag()) != 0)
				{
					if (num == codec.Tag)
					{
						result = codec.Read(input);
					}
					else
					{
						input.SkipLastField();
					}
				}
				input.CheckReadEndOfStreamTag();
				input.PopLimit(oldLimit);
				return result;
			}

			internal static void Write<T>(CodedOutputStream output, T value, FieldCodec<T> codec)
			{
				output.WriteLength(codec.CalculateSizeWithTag(value));
				codec.WriteTagAndValue(output, value);
			}

			internal static int CalculateSize<T>(T value, FieldCodec<T> codec)
			{
				int num = codec.CalculateSizeWithTag(value);
				return CodedOutputStream.ComputeLengthSize(num) + num;
			}
		}

		public static FieldCodec<string> ForString(uint tag)
		{
			return new FieldCodec<string>((CodedInputStream input) => input.ReadString(), delegate(CodedOutputStream output, string value)
			{
				output.WriteString(value);
			}, CodedOutputStream.ComputeStringSize, tag);
		}

		public static FieldCodec<ByteString> ForBytes(uint tag)
		{
			return new FieldCodec<ByteString>((CodedInputStream input) => input.ReadBytes(), delegate(CodedOutputStream output, ByteString value)
			{
				output.WriteBytes(value);
			}, CodedOutputStream.ComputeBytesSize, tag);
		}

		public static FieldCodec<bool> ForBool(uint tag)
		{
			return new FieldCodec<bool>((CodedInputStream input) => input.ReadBool(), delegate(CodedOutputStream output, bool value)
			{
				output.WriteBool(value);
			}, CodedOutputStream.ComputeBoolSize, tag);
		}

		public static FieldCodec<int> ForInt32(uint tag)
		{
			return new FieldCodec<int>((CodedInputStream input) => input.ReadInt32(), delegate(CodedOutputStream output, int value)
			{
				output.WriteInt32(value);
			}, CodedOutputStream.ComputeInt32Size, tag);
		}

		public static FieldCodec<int> ForSInt32(uint tag)
		{
			return new FieldCodec<int>((CodedInputStream input) => input.ReadSInt32(), delegate(CodedOutputStream output, int value)
			{
				output.WriteSInt32(value);
			}, CodedOutputStream.ComputeSInt32Size, tag);
		}

		public static FieldCodec<uint> ForFixed32(uint tag)
		{
			return new FieldCodec<uint>((CodedInputStream input) => input.ReadFixed32(), delegate(CodedOutputStream output, uint value)
			{
				output.WriteFixed32(value);
			}, 4, tag);
		}

		public static FieldCodec<int> ForSFixed32(uint tag)
		{
			return new FieldCodec<int>((CodedInputStream input) => input.ReadSFixed32(), delegate(CodedOutputStream output, int value)
			{
				output.WriteSFixed32(value);
			}, 4, tag);
		}

		public static FieldCodec<uint> ForUInt32(uint tag)
		{
			return new FieldCodec<uint>((CodedInputStream input) => input.ReadUInt32(), delegate(CodedOutputStream output, uint value)
			{
				output.WriteUInt32(value);
			}, CodedOutputStream.ComputeUInt32Size, tag);
		}

		public static FieldCodec<long> ForInt64(uint tag)
		{
			return new FieldCodec<long>((CodedInputStream input) => input.ReadInt64(), delegate(CodedOutputStream output, long value)
			{
				output.WriteInt64(value);
			}, CodedOutputStream.ComputeInt64Size, tag);
		}

		public static FieldCodec<long> ForSInt64(uint tag)
		{
			return new FieldCodec<long>((CodedInputStream input) => input.ReadSInt64(), delegate(CodedOutputStream output, long value)
			{
				output.WriteSInt64(value);
			}, CodedOutputStream.ComputeSInt64Size, tag);
		}

		public static FieldCodec<ulong> ForFixed64(uint tag)
		{
			return new FieldCodec<ulong>((CodedInputStream input) => input.ReadFixed64(), delegate(CodedOutputStream output, ulong value)
			{
				output.WriteFixed64(value);
			}, 8, tag);
		}

		public static FieldCodec<long> ForSFixed64(uint tag)
		{
			return new FieldCodec<long>((CodedInputStream input) => input.ReadSFixed64(), delegate(CodedOutputStream output, long value)
			{
				output.WriteSFixed64(value);
			}, 8, tag);
		}

		public static FieldCodec<ulong> ForUInt64(uint tag)
		{
			return new FieldCodec<ulong>((CodedInputStream input) => input.ReadUInt64(), delegate(CodedOutputStream output, ulong value)
			{
				output.WriteUInt64(value);
			}, CodedOutputStream.ComputeUInt64Size, tag);
		}

		public static FieldCodec<float> ForFloat(uint tag)
		{
			return new FieldCodec<float>((CodedInputStream input) => input.ReadFloat(), delegate(CodedOutputStream output, float value)
			{
				output.WriteFloat(value);
			}, CodedOutputStream.ComputeFloatSize, tag);
		}

		public static FieldCodec<double> ForDouble(uint tag)
		{
			return new FieldCodec<double>((CodedInputStream input) => input.ReadDouble(), delegate(CodedOutputStream output, double value)
			{
				output.WriteDouble(value);
			}, CodedOutputStream.ComputeDoubleSize, tag);
		}

		public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32)
		{
			return new FieldCodec<T>((CodedInputStream input) => fromInt32(input.ReadEnum()), delegate(CodedOutputStream output, T value)
			{
				output.WriteEnum(toInt32(value));
			}, (T value) => CodedOutputStream.ComputeEnumSize(toInt32(value)), tag);
		}

		public static FieldCodec<T> ForMessage<T>(uint tag, MessageParser<T> parser) where T : IMessage<T>
		{
			return new FieldCodec<T>(delegate(CodedInputStream input)
			{
				T val = parser.CreateTemplate();
				input.ReadMessage(val);
				return val;
			}, delegate(CodedOutputStream output, T value)
			{
				output.WriteMessage(value);
			}, (T message) => CodedOutputStream.ComputeMessageSize(message), tag);
		}

		public static FieldCodec<T> ForClassWrapper<T>(uint tag) where T : class
		{
			FieldCodec<T> nestedCodec = WrapperCodecs.GetCodec<T>();
			return new FieldCodec<T>((CodedInputStream input) => WrapperCodecs.Read(input, nestedCodec), delegate(CodedOutputStream output, T value)
			{
				WrapperCodecs.Write(output, value, nestedCodec);
			}, (T value) => WrapperCodecs.CalculateSize(value, nestedCodec), tag, null);
		}

		public static FieldCodec<T?> ForStructWrapper<T>(uint tag) where T : struct
		{
			FieldCodec<T> nestedCodec = WrapperCodecs.GetCodec<T>();
			return new FieldCodec<T?>((CodedInputStream input) => WrapperCodecs.Read(input, nestedCodec), delegate(CodedOutputStream output, T? value)
			{
				WrapperCodecs.Write(output, value.Value, nestedCodec);
			}, (T? value) => value.HasValue ? WrapperCodecs.CalculateSize(value.Value, nestedCodec) : 0, tag, null);
		}
	}
	public sealed class FieldCodec<T>
	{
		private static readonly T DefaultDefault;

		private static readonly bool TypeSupportsPacking;

		private readonly int tagSize;

		internal bool PackedRepeatedField { get; }

		internal Action<CodedOutputStream, T> ValueWriter { get; }

		internal Func<T, int> ValueSizeCalculator { get; }

		internal Func<CodedInputStream, T> ValueReader { get; }

		internal int FixedSize { get; }

		internal uint Tag { get; }

		internal T DefaultValue { get; }

		static FieldCodec()
		{
			TypeSupportsPacking = default(T) != null;
			if (typeof(T) == typeof(string))
			{
				DefaultDefault = (T)(object)"";
			}
			else if (typeof(T) == typeof(ByteString))
			{
				DefaultDefault = (T)(object)ByteString.Empty;
			}
		}

		internal static bool IsPackedRepeatedField(uint tag)
		{
			if (TypeSupportsPacking)
			{
				return WireFormat.GetTagWireType(tag) == WireFormat.WireType.LengthDelimited;
			}
			return false;
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, int fixedSize, uint tag)
			: this(reader, writer, (Func<T, int>)((T _) => fixedSize), tag)
		{
			FixedSize = fixedSize;
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, int> sizeCalculator, uint tag)
			: this(reader, writer, sizeCalculator, tag, DefaultDefault)
		{
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, int> sizeCalculator, uint tag, T defaultValue)
		{
			ValueReader = reader;
			ValueWriter = writer;
			ValueSizeCalculator = sizeCalculator;
			FixedSize = 0;
			Tag = tag;
			DefaultValue = defaultValue;
			tagSize = CodedOutputStream.ComputeRawVarint32Size(tag);
			PackedRepeatedField = IsPackedRepeatedField(tag);
		}

		public void WriteTagAndValue(CodedOutputStream output, T value)
		{
			if (!IsDefault(value))
			{
				output.WriteTag(Tag);
				ValueWriter(output, value);
			}
		}

		public T Read(CodedInputStream input)
		{
			return ValueReader(input);
		}

		public int CalculateSizeWithTag(T value)
		{
			if (!IsDefault(value))
			{
				return ValueSizeCalculator(value) + tagSize;
			}
			return 0;
		}

		private bool IsDefault(T value)
		{
			return EqualityComparer<T>.Default.Equals(value, DefaultValue);
		}
	}
	internal static class FrameworkPortability
	{
		internal static readonly RegexOptions CompiledRegexWhereAvailable = (System.Enum.IsDefined(typeof(RegexOptions), 8) ? ((RegexOptions)8) : RegexOptions.None);
	}
	public interface ICustomDiagnosticMessage : IMessage
	{
		string ToDiagnosticString();
	}
	public interface IDeepCloneable<T>
	{
		T Clone();
	}
	public interface IMessage
	{
		MessageDescriptor Descriptor { get; }

		void MergeFrom(CodedInputStream input);

		void WriteTo(CodedOutputStream output);

		int CalculateSize();
	}
	public interface IMessage<T> : IMessage, IEquatable<T>, IDeepCloneable<T> where T : IMessage<T>
	{
		void MergeFrom(T message);
	}
	public sealed class InvalidJsonException : IOException
	{
		internal InvalidJsonException(string message)
			: base(message)
		{
		}
	}
	public sealed class InvalidProtocolBufferException : IOException
	{
		internal InvalidProtocolBufferException(string message)
			: base(message)
		{
		}

		internal InvalidProtocolBufferException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		internal static InvalidProtocolBufferException MoreDataAvailable()
		{
			return new InvalidProtocolBufferException("Completed reading a message while more data was available in the stream.");
		}

		internal static InvalidProtocolBufferException TruncatedMessage()
		{
			return new InvalidProtocolBufferException("While parsing a protocol message, the input ended unexpectedly in the middle of a field.  This could mean either than the input has been truncated or that an embedded message misreported its own length.");
		}

		internal static InvalidProtocolBufferException NegativeSize()
		{
			return new InvalidProtocolBufferException("CodedInputStream encountered an embedded string or message which claimed to have negative size.");
		}

		internal static InvalidProtocolBufferException MalformedVarint()
		{
			return new InvalidProtocolBufferException("CodedInputStream encountered a malformed varint.");
		}

		internal static InvalidProtocolBufferException InvalidTag()
		{
			return new InvalidProtocolBufferException("Protocol message contained an invalid tag (zero).");
		}

		internal static InvalidProtocolBufferException InvalidBase64(Exception innerException)
		{
			return new InvalidProtocolBufferException("Invalid base64 data", innerException);
		}

		internal static InvalidProtocolBufferException InvalidEndTag()
		{
			return new InvalidProtocolBufferException("Protocol message end-group tag did not match expected tag.");
		}

		internal static InvalidProtocolBufferException RecursionLimitExceeded()
		{
			return new InvalidProtocolBufferException("Protocol message had too many levels of nesting.  May be malicious.  Use CodedInputStream.SetRecursionLimit() to increase the depth limit.");
		}

		internal static InvalidProtocolBufferException JsonRecursionLimitExceeded()
		{
			return new InvalidProtocolBufferException("Protocol message had too many levels of nesting.  May be malicious.  Use JsonParser.Settings to increase the depth limit.");
		}

		internal static InvalidProtocolBufferException SizeLimitExceeded()
		{
			return new InvalidProtocolBufferException("Protocol message was too large.  May be malicious.  Use CodedInputStream.SetSizeLimit() to increase the size limit.");
		}

		internal static InvalidProtocolBufferException InvalidMessageStreamTag()
		{
			return new InvalidProtocolBufferException("Stream of protocol messages had invalid tag. Expected tag is length-delimited field 1.");
		}
	}
	public sealed class JsonFormatter
	{
		public sealed class Settings
		{
			public static Settings Default { get; }

			public bool FormatDefaultValues { get; }

			public TypeRegistry TypeRegistry { get; }

			static Settings()
			{
				Default = new Settings(formatDefaultValues: false);
			}

			public Settings(bool formatDefaultValues)
				: this(formatDefaultValues, TypeRegistry.Empty)
			{
			}

			public Settings(bool formatDefaultValues, TypeRegistry typeRegistry)
			{
				FormatDefaultValues = formatDefaultValues;
				TypeRegistry = ProtoPreconditions.CheckNotNull(typeRegistry, "typeRegistry");
			}
		}

		private static class OriginalEnumValueHelper
		{
			private static readonly Dictionary<System.Type, Dictionary<object, string>> dictionaries = new Dictionary<System.Type, Dictionary<object, string>>();

			internal static string GetOriginalName(object value)
			{
				System.Type type = value.GetType();
				Dictionary<object, string> value2;
				lock (dictionaries)
				{
					if (!dictionaries.TryGetValue(type, out value2))
					{
						value2 = GetNameMapping(type);
						dictionaries[type] = value2;
					}
				}
				value2.TryGetValue(value, out var value3);
				return value3;
			}

			private static Dictionary<object, string> GetNameMapping(System.Type enumType)
			{
				return enumType.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).ToDictionary((FieldInfo f) => f.GetValue(null), (FieldInfo f) => (f.GetCustomAttributes(typeof(OriginalNameAttribute), inherit: false).FirstOrDefault() as OriginalNameAttribute)?.Name ?? f.Name);
			}
		}

		internal const string AnyTypeUrlField = "@type";

		internal const string AnyDiagnosticValueField = "@value";

		internal const string AnyWellKnownTypeValueField = "value";

		private const string TypeUrlPrefix = "type.googleapis.com";

		private const string NameValueSeparator = ": ";

		private const string PropertySeparator = ", ";

		private static readonly JsonFormatter diagnosticFormatter;

		private static readonly string[] CommonRepresentations;

		private readonly Settings settings;

		private const string Hex = "0123456789abcdef";

		public static JsonFormatter Default { get; }

		private bool DiagnosticOnly => this == diagnosticFormatter;

		static JsonFormatter()
		{
			Default = new JsonFormatter(Settings.Default);
			diagnosticFormatter = new JsonFormatter(Settings.Default);
			CommonRepresentations = new string[160]
			{
				"\\u0000", "\\u0001", "\\u0002", "\\u0003", "\\u0004", "\\u0005", "\\u0006", "\\u0007", "\\b", "\\t",
				"\\n", "\\u000b", "\\f", "\\r", "\\u000e", "\\u000f", "\\u0010", "\\u0011", "\\u0012", "\\u0013",
				"\\u0014", "\\u0015", "\\u0016", "\\u0017", "\\u0018", "\\u0019", "\\u001a", "\\u001b", "\\u001c", "\\u001d",
				"\\u001e", "\\u001f", "", "", "\\\"", "", "", "", "", "",
				"", "", "", "", "", "", "", "", "", "",
				"", "", "", "", "", "", "", "", "", "",
				"\\u003c", "", "\\u003e", "", "", "", "", "", "", "",
				"", "", "", "", "", "", "", "", "", "",
				"", "", "", "", "", "", "", "", "", "",
				"", "", "\\\\", "", "", "", "", "", "", "",
				"", "", "", "", "", "", "", "", "", "",
				"", "", "", "", "", "", "", "", "", "",
				"", "", "", "", "", "", "", "\\u007f", "\\u0080", "\\u0081",
				"\\u0082", "\\u0083", "\\u0084", "\\u0085", "\\u0086", "\\u0087", "\\u0088", "\\u0089", "\\u008a", "\\u008b",
				"\\u008c", "\\u008d", "\\u008e", "\\u008f", "\\u0090", "\\u0091", "\\u0092", "\\u0093", "\\u0094", "\\u0095",
				"\\u0096", "\\u0097", "\\u0098", "\\u0099", "\\u009a", "\\u009b", "\\u009c", "\\u009d", "\\u009e", "\\u009f"
			};
			for (int i = 0; i < CommonRepresentations.Length; i++)
			{
				if (CommonRepresentations[i] == "")
				{
					CommonRepresentations[i] = ((char)i).ToString();
				}
			}
		}

		public JsonFormatter(Settings settings)
		{
			this.settings = settings;
		}

		public string Format(IMessage message)
		{
			StringWriter stringWriter = new StringWriter();
			Format(message, stringWriter);
			return stringWriter.ToString();
		}

		public void Format(IMessage message, TextWriter writer)
		{
			ProtoPreconditions.CheckNotNull(message, "message");
			ProtoPreconditions.CheckNotNull(writer, "writer");
			if (message.Descriptor.IsWellKnownType)
			{
				WriteWellKnownTypeValue(writer, message.Descriptor, message);
			}
			else
			{
				WriteMessage(writer, message);
			}
		}

		public static string ToDiagnosticString(IMessage message)
		{
			ProtoPreconditions.CheckNotNull(message, "message");
			return diagnosticFormatter.Format(message);
		}

		private void WriteMessage(TextWriter writer, IMessage message)
		{
			if (message == null)
			{
				WriteNull(writer);
				return;
			}
			if (DiagnosticOnly && message is ICustomDiagnosticMessage customDiagnosticMessage)
			{
				writer.Write(customDiagnosticMessage.ToDiagnosticString());
				return;
			}
			writer.Write("{ ");
			bool flag = WriteMessageFields(writer, message, assumeFirstFieldWritten: false);
			writer.Write(flag ? " }" : "}");
		}

		private bool WriteMessageFields(TextWriter writer, IMessage message, bool assumeFirstFieldWritten)
		{
			MessageDescriptor.FieldCollection fields = message.Descriptor.Fields;
			bool flag = !assumeFirstFieldWritten;
			foreach (FieldDescriptor item in fields.InFieldNumberOrder())
			{
				IFieldAccessor accessor = item.Accessor;
				if (item.ContainingOneof != null && item.ContainingOneof.Accessor.GetCaseFieldDescriptor(message) != item)
				{
					continue;
				}
				object value = accessor.GetValue(message);
				if (item.ContainingOneof != null || settings.FormatDefaultValues || !IsDefaultValue(accessor, value))
				{
					if (!flag)
					{
						writer.Write(", ");
					}
					WriteString(writer, accessor.Descriptor.JsonName);
					writer.Write(": ");
					WriteValue(writer, value);
					flag = false;
				}
			}
			return !flag;
		}

		private static string ToCamelCaseForFieldMask(string input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				char c = input[i];
				if (c >= 'A' && c <= 'Z')
				{
					throw new InvalidOperationException($"Invalid field mask to be converted to JSON: {input}");
				}
				if (c == '_' && i < input.Length - 1)
				{
					char c2 = input[i + 1];
					if (c2 < 'a' || c2 > 'z')
					{
						throw new InvalidOperationException($"Invalid field mask to be converted to JSON: {input}");
					}
				}
			}
			return ToCamelCase(input);
		}

		internal static string ToCamelCase(string input)
		{
			bool flag = false;
			bool flag2 = true;
			bool flag3 = false;
			bool flag4 = true;
			StringBuilder stringBuilder = new StringBuilder(input.Length);
			int num = 0;
			while (num < input.Length)
			{
				flag3 = char.IsUpper(input[num]);
				if (input[num] == '_')
				{
					flag = true;
					if (stringBuilder.Length != 0)
					{
						flag4 = false;
					}
				}
				else if (flag4)
				{
					if (stringBuilder.Length != 0 && flag3 && (!flag2 || (num + 1 < input.Length && char.IsLower(input[num + 1]))))
					{
						flag4 = false;
						stringBuilder.Append(input[num]);
					}
					else
					{
						stringBuilder.Append(char.ToLowerInvariant(input[num]));
					}
				}
				else if (flag)
				{
					flag = false;
					if (char.IsLower(input[num]))
					{
						stringBuilder.Append(char.ToUpperInvariant(input[num]));
					}
					else
					{
						stringBuilder.Append(input[num]);
					}
				}
				else
				{
					stringBuilder.Append(char.ToLowerInvariant(input[num]));
				}
				num++;
				flag2 = flag3;
			}
			return stringBuilder.ToString();
		}

		private static void WriteNull(TextWriter writer)
		{
			writer.Write("null");
		}

		private static bool IsDefaultValue(IFieldAccessor accessor, object value)
		{
			if (accessor.Descriptor.IsMap)
			{
				return ((IDictionary)value).Count == 0;
			}
			if (accessor.Descriptor.IsRepeated)
			{
				return ((IList)value).Count == 0;
			}
			switch (accessor.Descriptor.FieldType)
			{
			case FieldType.Bool:
				return !(bool)value;
			case FieldType.Bytes:
				return (ByteString)value == ByteString.Empty;
			case FieldType.String:
				return (string)value == "";
			case FieldType.Double:
				return (double)value == 0.0;
			case FieldType.Int32:
			case FieldType.SFixed32:
			case FieldType.SInt32:
			case FieldType.Enum:
				return (int)value == 0;
			case FieldType.Fixed32:
			case FieldType.UInt32:
				return (uint)value == 0;
			case FieldType.UInt64:
			case FieldType.Fixed64:
				return (ulong)value == 0;
			case FieldType.Int64:
			case FieldType.SFixed64:
			case FieldType.SInt64:
				return (long)value == 0;
			case FieldType.Float:
				return (float)value == 0f;
			case FieldType.Group:
			case FieldType.Message:
				return value == null;
			default:
				throw new ArgumentException("Invalid field type");
			}
		}

		public void WriteValue(TextWriter writer, object value)
		{
			if (value == null)
			{
				WriteNull(writer);
			}
			else if (value is bool)
			{
				writer.Write(((bool)value) ? "true" : "false");
			}
			else if (value is ByteString)
			{
				writer.Write('"');
				writer.Write(((ByteString)value).ToBase64());
				writer.Write('"');
			}
			else if (value is string)
			{
				WriteString(writer, (string)value);
			}
			else if (value is IDictionary)
			{
				WriteDictionary(writer, (IDictionary)value);
			}
			else if (value is IList)
			{
				WriteList(writer, (IList)value);
			}
			else if (value is int || value is uint)
			{
				IFormattable formattable = (IFormattable)value;
				writer.Write(formattable.ToString("d", CultureInfo.InvariantCulture));
			}
			else if (value is long || value is ulong)
			{
				writer.Write('"');
				IFormattable formattable2 = (IFormattable)value;
				writer.Write(formattable2.ToString("d", CultureInfo.InvariantCulture));
				writer.Write('"');
			}
			else if (value is System.Enum)
			{
				string originalName = OriginalEnumValueHelper.GetOriginalName(value);
				if (originalName != null)
				{
					WriteString(writer, originalName);
				}
				else
				{
					WriteValue(writer, (int)value);
				}
			}
			else if (value is float || value is double)
			{
				string text = ((IFormattable)value).ToString("r", CultureInfo.InvariantCulture);
				switch (text)
				{
				case "NaN":
				case "Infinity":
				case "-Infinity":
					writer.Write('"');
					writer.Write(text);
					writer.Write('"');
					break;
				default:
					writer.Write(text);
					break;
				}
			}
			else
			{
				if (!(value is IMessage))
				{
					throw new ArgumentException("Unable to format value of type " + value.GetType());
				}
				Format((IMessage)value, writer);
			}
		}

		private void WriteWellKnownTypeValue(TextWriter writer, MessageDescriptor descriptor, object value)
		{
			if (value == null)
			{
				WriteNull(writer);
			}
			else if (descriptor.IsWrapperType)
			{
				if (value is IMessage)
				{
					IMessage message = (IMessage)value;
					value = message.Descriptor.Fields[1].Accessor.GetValue(message);
				}
				WriteValue(writer, value);
			}
			else if (descriptor.FullName == Timestamp.Descriptor.FullName)
			{
				WriteTimestamp(writer, (IMessage)value);
			}
			else if (descriptor.FullName == Duration.Descriptor.FullName)
			{
				WriteDuration(writer, (IMessage)value);
			}
			else if (descriptor.FullName == FieldMask.Descriptor.FullName)
			{
				WriteFieldMask(writer, (IMessage)value);
			}
			else if (descriptor.FullName == Struct.Descriptor.FullName)
			{
				WriteStruct(writer, (IMessage)value);
			}
			else if (descriptor.FullName == ListValue.Descriptor.FullName)
			{
				IFieldAccessor accessor = descriptor.Fields[1].Accessor;
				WriteList(writer, (IList)accessor.GetValue((IMessage)value));
			}
			else if (descriptor.FullName == Value.Descriptor.FullName)
			{
				WriteStructFieldValue(writer, (IMessage)value);
			}
			else if (descriptor.FullName == Any.Descriptor.FullName)
			{
				WriteAny(writer, (IMessage)value);
			}
			else
			{
				WriteMessage(writer, (IMessage)value);
			}
		}

		private void WriteTimestamp(TextWriter writer, IMessage value)
		{
			int nanoseconds = (int)value.Descriptor.Fields[2].Accessor.GetValue(value);
			long seconds = (long)value.Descriptor.Fields[1].Accessor.GetValue(value);
			writer.Write(Timestamp.ToJson(seconds, nanoseconds, DiagnosticOnly));
		}

		private void WriteDuration(TextWriter writer, IMessage value)
		{
			int nanoseconds = (int)value.Descriptor.Fields[2].Accessor.GetValue(value);
			long seconds = (long)value.Descriptor.Fields[1].Accessor.GetValue(value);
			writer.Write(Duration.ToJson(seconds, nanoseconds, DiagnosticOnly));
		}

		private void WriteFieldMask(TextWriter writer, IMessage value)
		{
			IList<string> paths = (IList<string>)value.Descriptor.Fields[1].Accessor.GetValue(value);
			writer.Write(FieldMask.ToJson(paths, DiagnosticOnly));
		}

		private void WriteAny(TextWriter writer, IMessage value)
		{
			if (DiagnosticOnly)
			{
				WriteDiagnosticOnlyAny(writer, value);
				return;
			}
			string text = (string)value.Descriptor.Fields[1].Accessor.GetValue(value);
			ByteString data = (ByteString)value.Descriptor.Fields[2].Accessor.GetValue(value);
			string typeName = Any.GetTypeName(text);
			MessageDescriptor messageDescriptor = settings.TypeRegistry.Find(typeName);
			if (messageDescriptor == null)
			{
				throw new InvalidOperationException($"Type registry has no descriptor for type name '{typeName}'");
			}
			IMessage message = messageDescriptor.Parser.ParseFrom(data);
			writer.Write("{ ");
			WriteString(writer, "@type");
			writer.Write(": ");
			WriteString(writer, text);
			if (messageDescriptor.IsWellKnownType)
			{
				writer.Write(", ");
				WriteString(writer, "value");
				writer.Write(": ");
				WriteWellKnownTypeValue(writer, messageDescriptor, message);
			}
			else
			{
				WriteMessageFields(writer, message, assumeFirstFieldWritten: true);
			}
			writer.Write(" }");
		}

		private void WriteDiagnosticOnlyAny(TextWriter writer, IMessage value)
		{
			string text = (string)value.Descriptor.Fields[1].Accessor.GetValue(value);
			ByteString byteString = (ByteString)value.Descriptor.Fields[2].Accessor.GetValue(value);
			writer.Write("{ ");
			WriteString(writer, "@type");
			writer.Write(": ");
			WriteString(writer, text);
			writer.Write(", ");
			WriteString(writer, "@value");
			writer.Write(": ");
			writer.Write('"');
			writer.Write(byteString.ToBase64());
			writer.Write('"');
			writer.Write(" }");
		}

		private void WriteStruct(TextWriter writer, IMessage message)
		{
			writer.Write("{ ");
			IDictionary obj = (IDictionary)message.Descriptor.Fields[1].Accessor.GetValue(message);
			bool flag = true;
			foreach (DictionaryEntry item in obj)
			{
				string text = (string)item.Key;
				IMessage message2 = (IMessage)item.Value;
				if (string.IsNullOrEmpty(text) || message2 == null)
				{
					throw new InvalidOperationException("Struct fields cannot have an empty key or a null value.");
				}
				if (!flag)
				{
					writer.Write(", ");
				}
				WriteString(writer, text);
				writer.Write(": ");
				WriteStructFieldValue(writer, message2);
				flag = false;
			}
			writer.Write(flag ? "}" : " }");
		}

		private void WriteStructFieldValue(TextWriter writer, IMessage message)
		{
			FieldDescriptor caseFieldDescriptor = message.Descriptor.Oneofs[0].Accessor.GetCaseFieldDescriptor(message);
			if (caseFieldDescriptor == null)
			{
				throw new InvalidOperationException("Value message must contain a value for the oneof.");
			}
			object value = caseFieldDescriptor.Accessor.GetValue(message);
			switch (caseFieldDescriptor.FieldNumber)
			{
			case 2:
			case 3:
			case 4:
				WriteValue(writer, value);
				break;
			case 5:
			case 6:
			{
				IMessage message2 = (IMessage)caseFieldDescriptor.Accessor.GetValue(message);
				WriteWellKnownTypeValue(writer, message2.Descriptor, message2);
				break;
			}
			case 1:
				WriteNull(writer);
				break;
			default:
				throw new InvalidOperationException("Unexpected case in struct field: " + caseFieldDescriptor.FieldNumber);
			}
		}

		internal void WriteList(TextWriter writer, IList list)
		{
			writer.Write("[ ");
			bool flag = true;
			foreach (object item in list)
			{
				if (!flag)
				{
					writer.Write(", ");
				}
				WriteValue(writer, item);
				flag = false;
			}
			writer.Write(flag ? "]" : " ]");
		}

		internal void WriteDictionary(TextWriter writer, IDictionary dictionary)
		{
			writer.Write("{ ");
			bool flag = true;
			foreach (DictionaryEntry item in dictionary)
			{
				if (!flag)
				{
					writer.Write(", ");
				}
				string text;
				if (item.Key is string)
				{
					text = (string)item.Key;
				}
				else if (item.Key is bool)
				{
					text = (((bool)item.Key) ? "true" : "false");
				}
				else
				{
					if (!(item.Key is int) && !((item.Key is uint) | (item.Key is long)) && !(item.Key is ulong))
					{
						if (item.Key == null)
						{
							throw new ArgumentException("Dictionary has entry with null key");
						}
						throw new ArgumentException("Unhandled dictionary key type: " + item.Key.GetType());
					}
					text = ((IFormattable)item.Key).ToString("d", CultureInfo.InvariantCulture);
				}
				WriteString(writer, text);
				writer.Write(": ");
				WriteValue(writer, item.Value);
				flag = false;
			}
			writer.Write(flag ? "}" : " }");
		}

		internal static void WriteString(TextWriter writer, string text)
		{
			writer.Write('"');
			for (int i = 0; i < text.Length; i++)
			{
				char c = text[i];
				if (c < '\u00a0')
				{
					writer.Write(CommonRepresentations[(uint)c]);
					continue;
				}
				if (char.IsHighSurrogate(c))
				{
					i++;
					if (i == text.Length || !char.IsLowSurrogate(text[i]))
					{
						throw new ArgumentException("String contains low surrogate not followed by high surrogate");
					}
					HexEncodeUtf16CodeUnit(writer, c);
					HexEncodeUtf16CodeUnit(writer, text[i]);
					continue;
				}
				if (char.IsLowSurrogate(c))
				{
					throw new ArgumentException("String contains high surrogate not preceded by low surrogate");
				}
				switch (c)
				{
				case 173u:
				case 1757u:
				case 1807u:
				case 6068u:
				case 6069u:
				case 65279u:
				case 65529u:
				case 65530u:
				case 65531u:
					HexEncodeUtf16CodeUnit(writer, c);
					continue;
				}
				if ((c >= '\u0600' && c <= '\u0603') || (c >= '\u200b' && c <= '\u200f') || (c >= '\u2028' && c <= '\u202e') || (c >= '\u2060' && c <= '\u2064') || (c >= '\u206a' && c <= '\u206f'))
				{
					HexEncodeUtf16CodeUnit(writer, c);
				}
				else
				{
					writer.Write(c);
				}
			}
			writer.Write('"');
		}

		private static void HexEncodeUtf16CodeUnit(TextWriter writer, char c)
		{
			writer.Write("\\u");
			writer.Write("0123456789abcdef"[((int)c >> 12) & 0xF]);
			writer.Write("0123456789abcdef"[((int)c >> 8) & 0xF]);
			writer.Write("0123456789abcdef"[((int)c >> 4) & 0xF]);
			writer.Write("0123456789abcdef"[c & 0xF]);
		}
	}
	public sealed class JsonParser
	{
		public sealed class Settings
		{
			public static Settings Default { get; }

			public int RecursionLimit { get; }

			public TypeRegistry TypeRegistry { get; }

			static Settings()
			{
				Default = new Settings(64);
			}

			public Settings(int recursionLimit)
				: this(recursionLimit, TypeRegistry.Empty)
			{
			}

			public Settings(int recursionLimit, TypeRegistry typeRegistry)
			{
				RecursionLimit = recursionLimit;
				TypeRegistry = ProtoPreconditions.CheckNotNull(typeRegistry, "typeRegistry");
			}
		}

		private static readonly Regex TimestampRegex = new Regex("^(?<datetime>[0-9]{4}-[01][0-9]-[0-3][0-9]T[012][0-9]:[0-5][0-9]:[0-5][0-9])(?<subseconds>\\.[0-9]{1,9})?(?<offset>(Z|[+-][0-1][0-9]:[0-5][0-9]))$", FrameworkPortability.CompiledRegexWhereAvailable);

		private static readonly Regex DurationRegex = new Regex("^(?<sign>-)?(?<int>[0-9]{1,12})(?<subseconds>\\.[0-9]{1,9})?s$", FrameworkPortability.CompiledRegexWhereAvailable);

		private static readonly int[] SubsecondScalingFactors = new int[11]
		{
			0, 100000000, 100000000, 10000000, 1000000, 100000, 10000, 1000, 100, 10,
			1
		};

		private static readonly char[] FieldMaskPathSeparators = new char[1] { ',' };

		private static readonly JsonParser defaultInstance = new JsonParser(Settings.Default);

		private static readonly Dictionary<string, Action<JsonParser, IMessage, JsonTokenizer>> WellKnownTypeHandlers = new Dictionary<string, Action<JsonParser, IMessage, JsonTokenizer>>
		{
			{
				Timestamp.Descriptor.FullName,
				delegate(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
				{
					MergeTimestamp(message, tokenizer.Next());
				}
			},
			{
				Duration.Descriptor.FullName,
				delegate(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
				{
					MergeDuration(message, tokenizer.Next());
				}
			},
			{
				Value.Descriptor.FullName,
				delegate(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
				{
					parser.MergeStructValue(message, tokenizer);
				}
			},
			{
				ListValue.Descriptor.FullName,
				delegate(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
				{
					parser.MergeRepeatedField(message, message.Descriptor.Fields[1], tokenizer);
				}
			},
			{
				Struct.Descriptor.FullName,
				delegate(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
				{
					parser.MergeStruct(message, tokenizer);
				}
			},
			{
				Any.Descriptor.FullName,
				delegate(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
				{
					parser.MergeAny(message, tokenizer);
				}
			},
			{
				FieldMask.Descriptor.FullName,
				delegate(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
				{
					MergeFieldMask(message, tokenizer.Next());
				}
			},
			{
				Int32Value.Descriptor.FullName,
				MergeWrapperField
			},
			{
				Int64Value.Descriptor.FullName,
				MergeWrapperField
			},
			{
				UInt32Value.Descriptor.FullName,
				MergeWrapperField
			},
			{
				UInt64Value.Descriptor.FullName,
				MergeWrapperField
			},
			{
				FloatValue.Descriptor.FullName,
				MergeWrapperField
			},
			{
				DoubleValue.Descriptor.FullName,
				MergeWrapperField
			},
			{
				BytesValue.Descriptor.FullName,
				MergeWrapperField
			},
			{
				StringValue.Descriptor.FullName,
				MergeWrapperField
			},
			{
				BoolValue.Descriptor.FullName,
				MergeWrapperField
			}
		};

		private readonly Settings settings;

		public static JsonParser Default => defaultInstance;

		private static void MergeWrapperField(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
		{
			parser.MergeField(message, message.Descriptor.Fields[1], tokenizer);
		}

		public JsonParser(Settings settings)
		{
			this.settings = settings;
		}

		internal void Merge(IMessage message, string json)
		{
			Merge(message, new StringReader(json));
		}

		internal void Merge(IMessage message, TextReader jsonReader)
		{
			JsonTokenizer jsonTokenizer = JsonTokenizer.FromTextReader(jsonReader);
			Merge(message, jsonTokenizer);
			if (jsonTokenizer.Next() != JsonToken.EndDocument)
			{
				throw new InvalidProtocolBufferException("Expected end of JSON after object");
			}
		}

		private void Merge(IMessage message, JsonTokenizer tokenizer)
		{
			if (tokenizer.ObjectDepth > settings.RecursionLimit)
			{
				throw InvalidProtocolBufferException.JsonRecursionLimitExceeded();
			}
			if (message.Descriptor.IsWellKnownType && WellKnownTypeHandlers.TryGetValue(message.Descriptor.FullName, out var value))
			{
				value(this, message, tokenizer);
				return;
			}
			JsonToken jsonToken = tokenizer.Next();
			if (jsonToken.Type != JsonToken.TokenType.StartObject)
			{
				throw new InvalidProtocolBufferException("Expected an object");
			}
			IDictionary<string, FieldDescriptor> dictionary = message.Descriptor.Fields.ByJsonName();
			HashSet<OneofDescriptor> hashSet = null;
			string stringValue;
			while (true)
			{
				jsonToken = tokenizer.Next();
				if (jsonToken.Type == JsonToken.TokenType.EndObject)
				{
					return;
				}
				if (jsonToken.Type != JsonToken.TokenType.Name)
				{
					throw new InvalidOperationException("Unexpected token type " + jsonToken.Type);
				}
				stringValue = jsonToken.StringValue;
				if (!dictionary.TryGetValue(stringValue, out var value2))
				{
					break;
				}
				if (value2.ContainingOneof != null)
				{
					if (hashSet == null)
					{
						hashSet = new HashSet<OneofDescriptor>();
					}
					if (!hashSet.Add(value2.ContainingOneof))
					{
						throw new InvalidProtocolBufferException($"Multiple values specified for oneof {value2.ContainingOneof.Name}");
					}
				}
				MergeField(message, value2, tokenizer);
			}
			throw new InvalidProtocolBufferException("Unknown field: " + stringValue);
		}

		private void MergeField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			if (jsonToken.Type == JsonToken.TokenType.Null && (field.IsMap || field.IsRepeated || !IsGoogleProtobufValueField(field)))
			{
				field.Accessor.Clear(message);
				return;
			}
			tokenizer.PushBack(jsonToken);
			if (field.IsMap)
			{
				MergeMapField(message, field, tokenizer);
				return;
			}
			if (field.IsRepeated)
			{
				MergeRepeatedField(message, field, tokenizer);
				return;
			}
			object value = ParseSingleValue(field, tokenizer);
			field.Accessor.SetValue(message, value);
		}

		private void MergeRepeatedField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			if (jsonToken.Type != JsonToken.TokenType.StartArray)
			{
				throw new InvalidProtocolBufferException("Repeated field value was not an array. Token type: " + jsonToken.Type);
			}
			IList list = (IList)field.Accessor.GetValue(message);
			while (true)
			{
				jsonToken = tokenizer.Next();
				if (jsonToken.Type == JsonToken.TokenType.EndArray)
				{
					return;
				}
				tokenizer.PushBack(jsonToken);
				if (jsonToken.Type == JsonToken.TokenType.Null)
				{
					break;
				}
				list.Add(ParseSingleValue(field, tokenizer));
			}
			throw new InvalidProtocolBufferException("Repeated field elements cannot be null");
		}

		private void MergeMapField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			if (jsonToken.Type != JsonToken.TokenType.StartObject)
			{
				throw new InvalidProtocolBufferException("Expected an object to populate a map");
			}
			MessageDescriptor messageType = field.MessageType;
			FieldDescriptor fieldDescriptor = messageType.FindFieldByNumber(1);
			FieldDescriptor fieldDescriptor2 = messageType.FindFieldByNumber(2);
			if (fieldDescriptor == null || fieldDescriptor2 == null)
			{
				throw new InvalidProtocolBufferException("Invalid map field: " + field.FullName);
			}
			IDictionary dictionary = (IDictionary)field.Accessor.GetValue(message);
			while (true)
			{
				jsonToken = tokenizer.Next();
				if (jsonToken.Type == JsonToken.TokenType.EndObject)
				{
					return;
				}
				object key = ParseMapKey(fieldDescriptor, jsonToken.StringValue);
				object obj = ParseSingleValue(fieldDescriptor2, tokenizer);
				if (obj == null)
				{
					break;
				}
				dictionary[key] = obj;
			}
			throw new InvalidProtocolBufferException("Map values must not be null");
		}

		private static bool IsGoogleProtobufValueField(FieldDescriptor field)
		{
			if (field.FieldType == FieldType.Message)
			{
				return field.MessageType.FullName == Value.Descriptor.FullName;
			}
			return false;
		}

		private object ParseSingleValue(FieldDescriptor field, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			if (jsonToken.Type == JsonToken.TokenType.Null)
			{
				if (IsGoogleProtobufValueField(field))
				{
					return Value.ForNull();
				}
				return null;
			}
			FieldType fieldType = field.FieldType;
			if (fieldType == FieldType.Message)
			{
				if (!field.MessageType.IsWrapperType)
				{
					tokenizer.PushBack(jsonToken);
					IMessage message = NewMessageForField(field);
					Merge(message, tokenizer);
					return message;
				}
				field = field.MessageType.Fields[1];
				fieldType = field.FieldType;
			}
			switch (jsonToken.Type)
			{
			case JsonToken.TokenType.False:
			case JsonToken.TokenType.True:
				if (fieldType == FieldType.Bool)
				{
					return jsonToken.Type == JsonToken.TokenType.True;
				}
				break;
			case JsonToken.TokenType.StringValue:
				return ParseSingleStringValue(field, jsonToken.StringValue);
			case JsonToken.TokenType.Number:
				return ParseSingleNumberValue(field, jsonToken);
			case JsonToken.TokenType.Null:
				throw new NotImplementedException("Haven't worked out what to do for null yet");
			}
			throw new InvalidProtocolBufferException(string.Concat("Unsupported JSON token type ", jsonToken.Type, " for field type ", fieldType));
		}

		public T Parse<T>(string json) where T : IMessage, new()
		{
			ProtoPreconditions.CheckNotNull(json, "json");
			return Parse<T>(new StringReader(json));
		}

		public T Parse<T>(TextReader jsonReader) where T : IMessage, new()
		{
			ProtoPreconditions.CheckNotNull(jsonReader, "jsonReader");
			T val = new T();
			Merge(val, jsonReader);
			return val;
		}

		public IMessage Parse(string json, MessageDescriptor descriptor)
		{
			ProtoPreconditions.CheckNotNull(json, "json");
			ProtoPreconditions.CheckNotNull(descriptor, "descriptor");
			return Parse(new StringReader(json), descriptor);
		}

		public IMessage Parse(TextReader jsonReader, MessageDescriptor descriptor)
		{
			ProtoPreconditions.CheckNotNull(jsonReader, "jsonReader");
			ProtoPreconditions.CheckNotNull(descriptor, "descriptor");
			IMessage message = descriptor.Parser.CreateTemplate();
			Merge(message, jsonReader);
			return message;
		}

		private void MergeStructValue(IMessage message, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			MessageDescriptor.FieldCollection fields = message.Descriptor.Fields;
			switch (jsonToken.Type)
			{
			case JsonToken.TokenType.Null:
				fields[1].Accessor.SetValue(message, 0);
				break;
			case JsonToken.TokenType.StringValue:
				fields[3].Accessor.SetValue(message, jsonToken.StringValue);
				break;
			case JsonToken.TokenType.Number:
				fields[2].Accessor.SetValue(message, jsonToken.NumberValue);
				break;
			case JsonToken.TokenType.False:
			case JsonToken.TokenType.True:
				fields[4].Accessor.SetValue(message, jsonToken.Type == JsonToken.TokenType.True);
				break;
			case JsonToken.TokenType.StartObject:
			{
				FieldDescriptor fieldDescriptor2 = fields[5];
				IMessage message3 = NewMessageForField(fieldDescriptor2);
				tokenizer.PushBack(jsonToken);
				Merge(message3, tokenizer);
				fieldDescriptor2.Accessor.SetValue(message, message3);
				break;
			}
			case JsonToken.TokenType.StartArray:
			{
				FieldDescriptor fieldDescriptor = fields[6];
				IMessage message2 = NewMessageForField(fieldDescriptor);
				tokenizer.PushBack(jsonToken);
				Merge(message2, tokenizer);
				fieldDescriptor.Accessor.SetValue(message, message2);
				break;
			}
			default:
				throw new InvalidOperationException("Unexpected token type: " + jsonToken.Type);
			}
		}

		private void MergeStruct(IMessage message, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			if (jsonToken.Type != JsonToken.TokenType.StartObject)
			{
				throw new InvalidProtocolBufferException("Expected object value for Struct");
			}
			tokenizer.PushBack(jsonToken);
			FieldDescriptor field = message.Descriptor.Fields[1];
			MergeMapField(message, field, tokenizer);
		}

		private void MergeAny(IMessage message, JsonTokenizer tokenizer)
		{
			List<JsonToken> list = new List<JsonToken>();
			JsonToken jsonToken = tokenizer.Next();
			if (jsonToken.Type != JsonToken.TokenType.StartObject)
			{
				throw new InvalidProtocolBufferException("Expected object value for Any");
			}
			int objectDepth = tokenizer.ObjectDepth;
			while (jsonToken.Type != JsonToken.TokenType.Name || jsonToken.StringValue != "@type" || tokenizer.ObjectDepth != objectDepth)
			{
				list.Add(jsonToken);
				jsonToken = tokenizer.Next();
				if (tokenizer.ObjectDepth < objectDepth)
				{
					throw new InvalidProtocolBufferException("Any message with no @type");
				}
			}
			jsonToken = tokenizer.Next();
			if (jsonToken.Type != JsonToken.TokenType.StringValue)
			{
				throw new InvalidProtocolBufferException("Expected string value for Any.@type");
			}
			string stringValue = jsonToken.StringValue;
			string typeName = Any.GetTypeName(stringValue);
			MessageDescriptor obj = settings.TypeRegistry.Find(typeName) ?? throw new InvalidOperationException($"Type registry has no descriptor for type name '{typeName}'");
			JsonTokenizer tokenizer2 = JsonTokenizer.FromReplayedTokens(list, tokenizer);
			IMessage message2 = obj.Parser.CreateTemplate();
			if (obj.IsWellKnownType)
			{
				MergeWellKnownTypeAnyBody(message2, tokenizer2);
			}
			else
			{
				Merge(message2, tokenizer2);
			}
			ByteString value = message2.ToByteString();
			message.Descriptor.Fields[1].Accessor.SetValue(message, stringValue);
			message.Descriptor.Fields[2].Accessor.SetValue(message, value);
		}

		private void MergeWellKnownTypeAnyBody(IMessage body, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			jsonToken = tokenizer.Next();
			if (jsonToken.Type != JsonToken.TokenType.Name || jsonToken.StringValue != "value")
			{
				throw new InvalidProtocolBufferException(string.Format("Expected '{0}' property for well-known type Any body", "value"));
			}
			Merge(body, tokenizer);
			jsonToken = tokenizer.Next();
			if (jsonToken.Type != JsonToken.TokenType.EndObject)
			{
				throw new InvalidProtocolBufferException("Expected end-object token after @type/value for well-known type");
			}
		}

		private static object ParseMapKey(FieldDescriptor field, string keyText)
		{
			switch (field.FieldType)
			{
			case FieldType.Bool:
				if (keyText == "true")
				{
					return true;
				}
				if (keyText == "false")
				{
					return false;
				}
				throw new InvalidProtocolBufferException("Invalid string for bool map key: " + keyText);
			case FieldType.String:
				return keyText;
			case FieldType.Int32:
			case FieldType.SFixed32:
			case FieldType.SInt32:
				return ParseNumericString(keyText, int.Parse);
			case FieldType.Fixed32:
			case FieldType.UInt32:
				return ParseNumericString(keyText, uint.Parse);
			case FieldType.Int64:
			case FieldType.SFixed64:
			case FieldType.SInt64:
				return ParseNumericString(keyText, long.Parse);
			case FieldType.UInt64:
			case FieldType.Fixed64:
				return ParseNumericString(keyText, ulong.Parse);
			default:
				throw new InvalidProtocolBufferException("Invalid field type for map: " + field.FieldType);
			}
		}

		private static object ParseSingleNumberValue(FieldDescriptor field, JsonToken token)
		{
			double numberValue = token.NumberValue;
			checked
			{
				try
				{
					switch (field.FieldType)
					{
					case FieldType.Int32:
					case FieldType.SFixed32:
					case FieldType.SInt32:
						CheckInteger(numberValue);
						return (int)numberValue;
					case FieldType.Fixed32:
					case FieldType.UInt32:
						CheckInteger(numberValue);
						return (uint)numberValue;
					case FieldType.Int64:
					case FieldType.SFixed64:
					case FieldType.SInt64:
						CheckInteger(numberValue);
						return (long)numberValue;
					case FieldType.UInt64:
					case FieldType.Fixed64:
						CheckInteger(numberValue);
						return (ulong)numberValue;
					case FieldType.Double:
						return numberValue;
					case FieldType.Float:
						if (double.IsNaN(numberValue))
						{
							return float.NaN;
						}
						if (numberValue > 3.4028234663852886E+38 || numberValue < -3.4028234663852886E+38)
						{
							if (double.IsPositiveInfinity(numberValue))
							{
								return float.PositiveInfinity;
							}
							if (double.IsNegativeInfinity(numberValue))
							{
								return float.NegativeInfinity;
							}
							throw new InvalidProtocolBufferException($"Value out of range: {numberValue}");
						}
						return (float)numberValue;
					case FieldType.Enum:
						CheckInteger(numberValue);
						return (int)numberValue;
					default:
						throw new InvalidProtocolBufferException($"Unsupported conversion from JSON number for field type {field.FieldType}");
					}
				}
				catch (OverflowException)
				{
					throw new InvalidProtocolBufferException($"Value out of range: {numberValue}");
				}
			}
		}

		private static void CheckInteger(double value)
		{
			if (double.IsInfinity(value) || double.IsNaN(value))
			{
				throw new InvalidProtocolBufferException($"Value not an integer: {value}");
			}
			if (value != Math.Floor(value))
			{
				throw new InvalidProtocolBufferException($"Value not an integer: {value}");
			}
		}

		private static object ParseSingleStringValue(FieldDescriptor field, string text)
		{
			switch (field.FieldType)
			{
			case FieldType.String:
				return text;
			case FieldType.Bytes:
				try
				{
					return ByteString.FromBase64(text);
				}
				catch (FormatException innerException)
				{
					throw InvalidProtocolBufferException.InvalidBase64(innerException);
				}
			case FieldType.Int32:
			case FieldType.SFixed32:
			case FieldType.SInt32:
				return ParseNumericString(text, int.Parse);
			case FieldType.Fixed32:
			case FieldType.UInt32:
				return ParseNumericString(text, uint.Parse);
			case FieldType.Int64:
			case FieldType.SFixed64:
			case FieldType.SInt64:
				return ParseNumericString(text, long.Parse);
			case FieldType.UInt64:
			case FieldType.Fixed64:
				return ParseNumericString(text, ulong.Parse);
			case FieldType.Double:
			{
				double num2 = ParseNumericString(text, double.Parse);
				ValidateInfinityAndNan(text, double.IsPositiveInfinity(num2), double.IsNegativeInfinity(num2), double.IsNaN(num2));
				return num2;
			}
			case FieldType.Float:
			{
				float num = ParseNumericString(text, float.Parse);
				ValidateInfinityAndNan(text, float.IsPositiveInfinity(num), float.IsNegativeInfinity(num), float.IsNaN(num));
				return num;
			}
			case FieldType.Enum:
				return (field.EnumType.FindValueByName(text) ?? throw new InvalidProtocolBufferException($"Invalid enum value: {text} for enum type: {field.EnumType.FullName}")).Number;
			default:
				throw new InvalidProtocolBufferException($"Unsupported conversion from JSON string for field type {field.FieldType}");
			}
		}

		private static IMessage NewMessageForField(FieldDescriptor field)
		{
			return field.MessageType.Parser.CreateTemplate();
		}

		private static T ParseNumericString<T>(string text, Func<string, NumberStyles, IFormatProvider, T> parser)
		{
			if (text.StartsWith("+"))
			{
				throw new InvalidProtocolBufferException($"Invalid numeric value: {text}");
			}
			if (text.StartsWith("0") && text.Length > 1)
			{
				if (text[1] >= '0' && text[1] <= '9')
				{
					throw new InvalidProtocolBufferException($"Invalid numeric value: {text}");
				}
			}
			else if (text.StartsWith("-0") && text.Length > 2 && text[2] >= '0' && text[2] <= '9')
			{
				throw new InvalidProtocolBufferException($"Invalid numeric value: {text}");
			}
			try
			{
				return parser(text, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, CultureInfo.InvariantCulture);
			}
			catch (FormatException)
			{
				throw new InvalidProtocolBufferException($"Invalid numeric value for type: {text}");
			}
			catch (OverflowException)
			{
				throw new InvalidProtocolBufferException($"Value out of range: {text}");
			}
		}

		private static void ValidateInfinityAndNan(string text, bool isPositiveInfinity, bool isNegativeInfinity, bool isNaN)
		{
			if ((isPositiveInfinity && text != "Infinity") || (isNegativeInfinity && text != "-Infinity") || (isNaN && text != "NaN"))
			{
				throw new InvalidProtocolBufferException($"Invalid numeric value: {text}");
			}
		}

		private static void MergeTimestamp(IMessage message, JsonToken token)
		{
			if (token.Type != JsonToken.TokenType.StringValue)
			{
				throw new InvalidProtocolBufferException("Expected string value for Timestamp");
			}
			Match match = TimestampRegex.Match(token.StringValue);
			if (!match.Success)
			{
				throw new InvalidProtocolBufferException($"Invalid Timestamp value: {token.StringValue}");
			}
			string value = match.Groups["datetime"].Value;
			string value2 = match.Groups["subseconds"].Value;
			string value3 = match.Groups["offset"].Value;
			try
			{
				Timestamp timestamp = Timestamp.FromDateTime(DateTime.ParseExact(value, "yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal));
				int num = 0;
				if (value2 != "")
				{
					num = int.Parse(value2.Substring(1), CultureInfo.InvariantCulture) * SubsecondScalingFactors[value2.Length];
				}
				int num2 = 0;
				if (value3 != "Z")
				{
					int num3 = ((value3[0] == '-') ? 1 : (-1));
					int num4 = int.Parse(value3.Substring(1, 2), CultureInfo.InvariantCulture);
					int num5 = int.Parse(value3.Substring(4, 2));
					int num6 = num4 * 60 + num5;
					if (num6 > 1080)
					{
						throw new InvalidProtocolBufferException("Invalid Timestamp value: " + token.StringValue);
					}
					if (num6 == 0 && num3 == 1)
					{
						throw new InvalidProtocolBufferException("Invalid Timestamp value: " + token.StringValue);
					}
					num2 = num3 * num6 * 60;
				}
				if (num2 < 0 && num > 0)
				{
					num2++;
					num -= 1000000000;
				}
				if (num2 != 0 || num != 0)
				{
					timestamp += new Duration
					{
						Nanos = num,
						Seconds = num2
					};
					if (timestamp.Seconds < -62135596800L || timestamp.Seconds > 253402300799L)
					{
						throw new InvalidProtocolBufferException("Invalid Timestamp value: " + token.StringValue);
					}
				}
				message.Descriptor.Fields[1].Accessor.SetValue(message, timestamp.Seconds);
				message.Descriptor.Fields[2].Accessor.SetValue(message, timestamp.Nanos);
			}
			catch (FormatException)
			{
				throw new InvalidProtocolBufferException("Invalid Timestamp value: " + token.StringValue);
			}
		}

		private static void MergeDuration(IMessage message, JsonToken token)
		{
			if (token.Type != JsonToken.TokenType.StringValue)
			{
				throw new InvalidProtocolBufferException("Expected string value for Duration");
			}
			Match match = DurationRegex.Match(token.StringValue);
			if (!match.Success)
			{
				throw new InvalidProtocolBufferException("Invalid Duration value: " + token.StringValue);
			}
			string value = match.Groups["sign"].Value;
			string value2 = match.Groups["int"].Value;
			if (value2[0] == '0' && value2.Length > 1)
			{
				throw new InvalidProtocolBufferException("Invalid Duration value: " + token.StringValue);
			}
			string value3 = match.Groups["subseconds"].Value;
			int num = ((!(value == "-")) ? 1 : (-1));
			try
			{
				long num2 = long.Parse(value2, CultureInfo.InvariantCulture) * num;
				int num3 = 0;
				if (value3 != "")
				{
					num3 = int.Parse(value3.Substring(1)) * SubsecondScalingFactors[value3.Length] * num;
				}
				if (!Duration.IsNormalized(num2, num3))
				{
					throw new InvalidProtocolBufferException($"Invalid Duration value: {token.StringValue}");
				}
				message.Descriptor.Fields[1].Accessor.SetValue(message, num2);
				message.Descriptor.Fields[2].Accessor.SetValue(message, num3);
			}
			catch (FormatException)
			{
				throw new InvalidProtocolBufferException($"Invalid Duration value: {token.StringValue}");
			}
		}

		private static void MergeFieldMask(IMessage message, JsonToken token)
		{
			if (token.Type != JsonToken.TokenType.StringValue)
			{
				throw new InvalidProtocolBufferException("Expected string value for FieldMask");
			}
			string[] array = token.StringValue.Split(FieldMaskPathSeparators, StringSplitOptions.RemoveEmptyEntries);
			IList list = (IList)message.Descriptor.Fields[1].Accessor.GetValue(message);
			string[] array2 = array;
			foreach (string text in array2)
			{
				list.Add(ToSnakeCase(text));
			}
		}

		private static string ToSnakeCase(string text)
		{
			StringBuilder stringBuilder = new StringBuilder(text.Length * 2);
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < text.Length; i++)
			{
				char c = text[i];
				if (c >= 'A' && c <= 'Z')
				{
					if (flag && (flag2 || (i + 1 < text.Length && text[i + 1] >= 'a' && text[i + 1] <= 'z')))
					{
						stringBuilder.Append('_');
					}
					stringBuilder.Append((char)(c + 97 - 65));
					flag = true;
					flag2 = false;
				}
				else
				{
					stringBuilder.Append(c);
					if (c == '_')
					{
						throw new InvalidProtocolBufferException($"Invalid field mask: {text}");
					}
					flag = true;
					flag2 = true;
				}
			}
			return stringBuilder.ToString();
		}
	}
	internal sealed class JsonToken : IEquatable<JsonToken>
	{
		internal enum TokenType
		{
			Null,
			False,
			True,
			StringValue,
			Number,
			Name,
			StartObject,
			EndObject,
			StartArray,
			EndArray,
			EndDocument
		}

		private static readonly JsonToken _true = new JsonToken(TokenType.True);

		private static readonly JsonToken _false = new JsonToken(TokenType.False);

		private static readonly JsonToken _null = new JsonToken(TokenType.Null);

		private static readonly JsonToken startObject = new JsonToken(TokenType.StartObject);

		private static readonly JsonToken endObject = new JsonToken(TokenType.EndObject);

		private static readonly JsonToken startArray = new JsonToken(TokenType.StartArray);

		private static readonly JsonToken endArray = new JsonToken(TokenType.EndArray);

		private static readonly JsonToken endDocument = new JsonToken(TokenType.EndDocument);

		private readonly TokenType type;

		private readonly string stringValue;

		private readonly double numberValue;

		internal static JsonToken Null => _null;

		internal static JsonToken False => _false;

		internal static JsonToken True => _true;

		internal static JsonToken StartObject => startObject;

		internal static JsonToken EndObject => endObject;

		internal static JsonToken StartArray => startArray;

		internal static JsonToken EndArray => endArray;

		internal static JsonToken EndDocument => endDocument;

		internal TokenType Type => type;

		internal string StringValue => stringValue;

		internal double NumberValue => numberValue;

		internal static JsonToken Name(string name)
		{
			return new JsonToken(TokenType.Name, name);
		}

		internal static JsonToken Value(string value)
		{
			return new JsonToken(TokenType.StringValue, value);
		}

		internal static JsonToken Value(double value)
		{
			return new JsonToken(TokenType.Number, null, value);
		}

		private JsonToken(TokenType type, string stringValue = null, double numberValue = 0.0)
		{
			this.type = type;
			this.stringValue = stringValue;
			this.numberValue = numberValue;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as JsonToken);
		}

		public override int GetHashCode()
		{
			return (((int)(17 * 31 + type) * 31 + stringValue != null) ? stringValue.GetHashCode() : 0) * 31 + numberValue.GetHashCode();
		}

		public override string ToString()
		{
			return type switch
			{
				TokenType.Null => "null", 
				TokenType.True => "true", 
				TokenType.False => "false", 
				TokenType.Name => "name (" + stringValue + ")", 
				TokenType.StringValue => "value (" + stringValue + ")", 
				TokenType.Number => "number (" + numberValue + ")", 
				TokenType.StartObject => "start-object", 
				TokenType.EndObject => "end-object", 
				TokenType.StartArray => "start-array", 
				TokenType.EndArray => "end-array", 
				TokenType.EndDocument => "end-document", 
				_ => throw new InvalidOperationException("Token is of unknown type " + type), 
			};
		}

		public bool Equals(JsonToken other)
		{
			if (other == null)
			{
				return false;
			}
			if (other.type == type && other.stringValue == stringValue)
			{
				return other.numberValue.Equals(numberValue);
			}
			return false;
		}
	}
	internal abstract class JsonTokenizer
	{
		private class JsonReplayTokenizer : JsonTokenizer
		{
			private readonly IList<JsonToken> tokens;

			private readonly JsonTokenizer nextTokenizer;

			private int nextTokenIndex;

			internal JsonReplayTokenizer(IList<JsonToken> tokens, JsonTokenizer nextTokenizer)
			{
				this.tokens = tokens;
				this.nextTokenizer = nextTokenizer;
			}

			protected override JsonToken NextImpl()
			{
				if (nextTokenIndex >= tokens.Count)
				{
					return nextTokenizer.Next();
				}
				return tokens[nextTokenIndex++];
			}
		}

		private sealed class JsonTextTokenizer : JsonTokenizer
		{
			private enum ContainerType
			{
				Document,
				Object,
				Array
			}

			[Flags]
			private enum State
			{
				StartOfDocument = 1,
				ExpectedEndOfDocument = 2,
				ReaderExhausted = 4,
				ObjectStart = 8,
				ObjectBeforeColon = 0x10,
				ObjectAfterColon = 0x20,
				ObjectAfterProperty = 0x40,
				ObjectAfterComma = 0x80,
				ArrayStart = 0x100,
				ArrayAfterValue = 0x200,
				ArrayAfterComma = 0x400
			}

			private class PushBackReader
			{
				private readonly TextReader reader;

				private char? nextChar;

				internal PushBackReader(TextReader reader)
				{
					this.reader = reader;
				}

				internal char? Read()
				{
					if (nextChar.HasValue)
					{
						char? result = nextChar;
						nextChar = null;
						return result;
					}
					int num = reader.Read();
					if (num != -1)
					{
						return (char)num;
					}
					return null;
				}

				internal char ReadOrFail(string messageOnFailure)
				{
					char? c = Read();
					if (!c.HasValue)
					{
						throw CreateException(messageOnFailure);
					}
					return c.Value;
				}

				internal void PushBack(char c)
				{
					if (nextChar.HasValue)
					{
						throw new InvalidOperationException("Cannot push back when already buffering a character");
					}
					nextChar = c;
				}

				internal InvalidJsonException CreateException(string message)
				{
					return new InvalidJsonException(message);
				}
			}

			private static readonly State ValueStates = State.StartOfDocument | State.ObjectAfterColon | State.ArrayStart | State.ArrayAfterComma;

			private readonly Stack<ContainerType> containerStack = new Stack<ContainerType>();

			private readonly PushBackReader reader;

			private State state;

			internal JsonTextTokenizer(TextReader reader)
			{
				this.reader = new PushBackReader(reader);
				state = State.StartOfDocument;
				containerStack.Push(ContainerType.Document);
			}

			protected override JsonToken NextImpl()
			{
				if (state == State.ReaderExhausted)
				{
					throw new InvalidOperationException("Next() called after end of document");
				}
				while (true)
				{
					char? c = reader.Read();
					if (!c.HasValue)
					{
						break;
					}
					switch (c.Value)
					{
					case '\t':
					case '\n':
					case '\r':
					case ' ':
						break;
					case ':':
						ValidateState(State.ObjectBeforeColon, "Invalid state to read a colon: ");
						state = State.ObjectAfterColon;
						break;
					case ',':
						ValidateState(State.ObjectAfterProperty | State.ArrayAfterValue, "Invalid state to read a colon: ");
						state = ((state == State.ObjectAfterProperty) ? State.ObjectAfterComma : State.ArrayAfterComma);
						break;
					case '"':
					{
						string text = ReadString();
						if ((state & (State.ObjectStart | State.ObjectAfterComma)) != 0)
						{
							state = State.ObjectBeforeColon;
							return JsonToken.Name(text);
						}
						ValidateAndModifyStateForValue("Invalid state to read a double quote: ");
						return JsonToken.Value(text);
					}
					case '{':
						ValidateState(ValueStates, "Invalid state to read an open brace: ");
						state = State.ObjectStart;
						containerStack.Push(ContainerType.Object);
						return JsonToken.StartObject;
					case '}':
						ValidateState(State.ObjectStart | State.ObjectAfterProperty, "Invalid state to read a close brace: ");
						PopContainer();
						return JsonToken.EndObject;
					case '[':
						ValidateState(ValueStates, "Invalid state to read an open square bracket: ");
						state = State.ArrayStart;
						containerStack.Push(ContainerType.Array);
						return JsonToken.StartArray;
					case ']':
						ValidateState(State.ArrayStart | State.ArrayAfterValue, "Invalid state to read a close square bracket: ");
						PopContainer();
						return JsonToken.EndArray;
					case 'n':
						ConsumeLiteral("null");
						ValidateAndModifyStateForValue("Invalid state to read a null literal: ");
						return JsonToken.Null;
					case 't':
						ConsumeLiteral("true");
						ValidateAndModifyStateForValue("Invalid state to read a true literal: ");
						return JsonToken.True;
					case 'f':
						ConsumeLiteral("false");
						ValidateAndModifyStateForValue("Invalid state to read a false literal: ");
						return JsonToken.False;
					case '-':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
					{
						double value = ReadNumber(c.Value);
						ValidateAndModifyStateForValue("Invalid state to read a number token: ");
						return JsonToken.Value(value);
					}
					default:
						throw new InvalidJsonException("Invalid first character of token: " + c.Value);
					}
				}
				ValidateState(State.ExpectedEndOfDocument, "Unexpected end of document in state: ");
				state = State.ReaderExhausted;
				return JsonToken.EndDocument;
			}

			private void ValidateState(State validStates, string errorPrefix)
			{
				if ((validStates & state) == 0)
				{
					throw reader.CreateException(errorPrefix + state);
				}
			}

			private string ReadString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				bool flag = false;
				while (true)
				{
					char c = reader.ReadOrFail("Unexpected end of text while reading string");
					if (c < ' ')
					{
						throw reader.CreateException(string.Format(CultureInfo.InvariantCulture, "Invalid character in string literal: U+{0:x4}", (int)c));
					}
					switch (c)
					{
					case '"':
						if (flag)
						{
							throw reader.CreateException("Invalid use of surrogate pair code units");
						}
						return stringBuilder.ToString();
					case '\\':
						c = ReadEscapedCharacter();
						break;
					}
					if (flag != char.IsLowSurrogate(c))
					{
						break;
					}
					flag = char.IsHighSurrogate(c);
					stringBuilder.Append(c);
				}
				throw reader.CreateException("Invalid use of surrogate pair code units");
			}

			private char ReadEscapedCharacter()
			{
				char c = reader.ReadOrFail("Unexpected end of text while reading character escape sequence");
				return c switch
				{
					'n' => '\n', 
					'\\' => '\\', 
					'b' => '\b', 
					'f' => '\f', 
					'r' => '\r', 
					't' => '\t', 
					'"' => '"', 
					'/' => '/', 
					'u' => ReadUnicodeEscape(), 
					_ => throw reader.CreateException(string.Format(CultureInfo.InvariantCulture, "Invalid character in character escape sequence: U+{0:x4}", (int)c)), 
				};
			}

			private char ReadUnicodeEscape()
			{
				int num = 0;
				for (int i = 0; i < 4; i++)
				{
					char c = reader.ReadOrFail("Unexpected end of text while reading Unicode escape sequence");
					int num2;
					if (c >= '0' && c <= '9')
					{
						num2 = c - 48;
					}
					else if (c >= 'a' && c <= 'f')
					{
						num2 = c - 97 + 10;
					}
					else
					{
						if (c < 'A' || c > 'F')
						{
							throw reader.CreateException(string.Format(CultureInfo.InvariantCulture, "Invalid character in character escape sequence: U+{0:x4}", (int)c));
						}
						num2 = c - 65 + 10;
					}
					num = (num << 4) + num2;
				}
				return (char)num;
			}

			private void ConsumeLiteral(string text)
			{
				for (int i = 1; i < text.Length; i++)
				{
					char? c = reader.Read();
					if (!c.HasValue)
					{
						throw reader.CreateException("Unexpected end of text while reading literal token " + text);
					}
					if (c.Value != text[i])
					{
						throw reader.CreateException("Unexpected character while reading literal token " + text);
					}
				}
			}

			private double ReadNumber(char initialCharacter)
			{
				StringBuilder stringBuilder = new StringBuilder();
				if (initialCharacter == '-')
				{
					stringBuilder.Append("-");
				}
				else
				{
					reader.PushBack(initialCharacter);
				}
				char? c = ReadInt(stringBuilder);
				if (c == '.')
				{
					c = ReadFrac(stringBuilder);
				}
				if (c == 'e' || c == 'E')
				{
					c = ReadExp(stringBuilder);
				}
				if (c.HasValue)
				{
					reader.PushBack(c.Value);
				}
				try
				{
					return double.Parse(stringBuilder.ToString(), NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, CultureInfo.InvariantCulture);
				}
				catch (OverflowException)
				{
					throw reader.CreateException("Numeric value out of range: " + stringBuilder);
				}
			}

			private char? ReadInt(StringBuilder builder)
			{
				char c = reader.ReadOrFail("Invalid numeric literal");
				if (c < '0' || c > '9')
				{
					throw reader.CreateException("Invalid numeric literal");
				}
				builder.Append(c);
				int count;
				char? result = ConsumeDigits(builder, out count);
				if (c == '0' && count != 0)
				{
					throw reader.CreateException("Invalid numeric literal: leading 0 for non-zero value.");
				}
				return result;
			}

			private char? ReadFrac(StringBuilder builder)
			{
				builder.Append('.');
				int count;
				char? result = ConsumeDigits(builder, out count);
				if (count == 0)
				{
					throw reader.CreateException("Invalid numeric literal: fraction with no trailing digits");
				}
				return result;
			}

			private char? ReadExp(StringBuilder builder)
			{
				builder.Append('E');
				char? c = reader.Read();
				if (!c.HasValue)
				{
					throw reader.CreateException("Invalid numeric literal: exponent with no trailing digits");
				}
				if (c == '-' || c == '+')
				{
					builder.Append(c.Value);
				}
				else
				{
					reader.PushBack(c.Value);
				}
				c = ConsumeDigits(builder, out var count);
				if (count == 0)
				{
					throw reader.CreateException("Invalid numeric literal: exponent without value");
				}
				return c;
			}

			private char? ConsumeDigits(StringBuilder builder, out int count)
			{
				count = 0;
				char? result;
				while (true)
				{
					result = reader.Read();
					if (!result.HasValue || result.Value < '0' || result.Value > '9')
					{
						break;
					}
					count++;
					builder.Append(result.Value);
				}
				return result;
			}

			private void ValidateAndModifyStateForValue(string errorPrefix)
			{
				ValidateState(ValueStates, errorPrefix);
				switch (state)
				{
				case State.StartOfDocument:
					state = State.ExpectedEndOfDocument;
					break;
				case State.ObjectAfterColon:
					state = State.ObjectAfterProperty;
					break;
				case State.ArrayStart:
				case State.ArrayAfterComma:
					state = State.ArrayAfterValue;
					break;
				default:
					throw new InvalidOperationException("ValidateAndModifyStateForValue does not handle all value states (and should)");
				}
			}

			private void PopContainer()
			{
				containerStack.Pop();
				ContainerType containerType = containerStack.Peek();
				switch (containerType)
				{
				case ContainerType.Object:
					state = State.ObjectAfterProperty;
					break;
				case ContainerType.Array:
					state = State.ArrayAfterValue;
					break;
				case ContainerType.Document:
					state = State.ExpectedEndOfDocument;
					break;
				default:
					throw new InvalidOperationException("Unexpected container type: " + containerType);
				}
			}
		}

		private JsonToken bufferedToken;

		internal int ObjectDepth { get; private set; }

		internal static JsonTokenizer FromTextReader(TextReader reader)
		{
			return new JsonTextTokenizer(reader);
		}

		internal static JsonTokenizer FromReplayedTokens(IList<JsonToken> tokens, JsonTokenizer continuation)
		{
			return new JsonReplayTokenizer(tokens, continuation);
		}

		internal void PushBack(JsonToken token)
		{
			if (bufferedToken != null)
			{
				throw new InvalidOperationException("Can't push back twice");
			}
			bufferedToken = token;
			if (token.Type == JsonToken.TokenType.StartObject)
			{
				ObjectDepth--;
			}
			else if (token.Type == JsonToken.TokenType.EndObject)
			{
				ObjectDepth++;
			}
		}

		internal JsonToken Next()
		{
			JsonToken jsonToken;
			if (bufferedToken != null)
			{
				jsonToken = bufferedToken;
				bufferedToken = null;
			}
			else
			{
				jsonToken = NextImpl();
			}
			if (jsonToken.Type == JsonToken.TokenType.StartObject)
			{
				ObjectDepth++;
			}
			else if (jsonToken.Type == JsonToken.TokenType.EndObject)
			{
				ObjectDepth--;
			}
			return jsonToken;
		}

		protected abstract JsonToken NextImpl();
	}
	internal sealed class LimitedInputStream : Stream
	{
		private readonly Stream proxied;

		private int bytesLeft;

		public override bool CanRead => true;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		public override long Position
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		internal LimitedInputStream(Stream proxied, int size)
		{
			this.proxied = proxied;
			bytesLeft = size;
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			if (bytesLeft > 0)
			{
				int num = proxied.Read(buffer, offset, Math.Min(bytesLeft, count));
				bytesLeft -= num;
				return num;
			}
			return 0;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}
	}
	public static class MessageExtensions
	{
		public static void MergeFrom(this IMessage message, byte[] data)
		{
			ProtoPreconditions.CheckNotNull(message, "message");
			ProtoPreconditions.CheckNotNull(data, "data");
			CodedInputStream codedInputStream = new CodedInputStream(data);
			message.MergeFrom(codedInputStream);
			codedInputStream.CheckReadEndOfStreamTag();
		}

		public static void MergeFrom(this IMessage message, ByteString data)
		{
			ProtoPreconditions.CheckNotNull(message, "message");
			ProtoPreconditions.CheckNotNull(data, "data");
			CodedInputStream codedInputStream = data.CreateCodedInput();
			message.MergeFrom(codedInputStream);
			codedInputStream.CheckReadEndOfStreamTag();
		}

		public static void MergeFrom(this IMessage message, Stream input)
		{
			ProtoPreconditions.CheckNotNull(message, "message");
			ProtoPreconditions.CheckNotNull(input, "input");
			CodedInputStream codedInputStream = new CodedInputStream(input);
			message.MergeFrom(codedInputStream);
			codedInputStream.CheckReadEndOfStreamTag();
		}

		public static void MergeDelimitedFrom(this IMessage message, Stream input)
		{
			ProtoPreconditions.CheckNotNull(message, "message");
			ProtoPreconditions.CheckNotNull(input, "input");
			int size = (int)CodedInputStream.ReadRawVarint32(input);
			Stream input2 = new LimitedInputStream(input, size);
			message.MergeFrom(input2);
		}

		public static byte[] ToByteArray(this IMessage message)
		{
			ProtoPreconditions.CheckNotNull(message, "message");
			byte[] array = new byte[message.CalculateSize()];
			CodedOutputStream codedOutputStream = new CodedOutputStream(array);
			message.WriteTo(codedOutputStream);
			codedOutputStream.CheckNoSpaceLeft();
			return array;
		}

		public static void WriteTo(this IMessage message, Stream output)
		{
			ProtoPreconditions.CheckNotNull(message, "message");
			ProtoPreconditions.CheckNotNull(output, "output");
			CodedOutputStream codedOutputStream = new CodedOutputStream(output);
			message.WriteTo(codedOutputStream);
			codedOutputStream.Flush();
		}

		public static void WriteDelimitedTo(this IMessage message, Stream output)
		{
			ProtoPreconditions.CheckNotNull(message, "message");
			ProtoPreconditions.CheckNotNull(output, "output");
			CodedOutputStream codedOutputStream = new CodedOutputStream(output);
			codedOutputStream.WriteRawVarint32((uint)message.CalculateSize());
			message.WriteTo(codedOutputStream);
			codedOutputStream.Flush();
		}

		public static ByteString ToByteString(this IMessage message)
		{
			ProtoPreconditions.CheckNotNull(message, "message");
			return ByteString.AttachBytes(message.ToByteArray());
		}
	}
	public class MessageParser
	{
		private Func<IMessage> factory;

		internal MessageParser(Func<IMessage> factory)
		{
			this.factory = factory;
		}

		internal IMessage CreateTemplate()
		{
			return factory();
		}

		public IMessage ParseFrom(byte[] data)
		{
			ProtoPreconditions.CheckNotNull(data, "data");
			IMessage message = factory();
			message.MergeFrom(data);
			return message;
		}

		public IMessage ParseFrom(ByteString data)
		{
			ProtoPreconditions.CheckNotNull(data, "data");
			IMessage message = factory();
			message.MergeFrom(data);
			return message;
		}

		public IMessage ParseFrom(Stream input)
		{
			IMessage message = factory();
			message.MergeFrom(input);
			return message;
		}

		public IMessage ParseDelimitedFrom(Stream input)
		{
			IMessage message = factory();
			message.MergeDelimitedFrom(input);
			return message;
		}

		public IMessage ParseFrom(CodedInputStream input)
		{
			IMessage message = factory();
			message.MergeFrom(input);
			return message;
		}

		public IMessage ParseJson(string json)
		{
			IMessage message = factory();
			JsonParser.Default.Merge(message, json);
			return message;
		}
	}
	public sealed class MessageParser<T> : MessageParser where T : IMessage<T>
	{
		private readonly Func<T> factory;

		public MessageParser(Func<T> factory)
			: base(() => factory())
		{
			this.factory = factory;
		}

		internal new T CreateTemplate()
		{
			return factory();
		}

		public new T ParseFrom(byte[] data)
		{
			ProtoPreconditions.CheckNotNull(data, "data");
			T val = factory();
			val.MergeFrom(data);
			return val;
		}

		public new T ParseFrom(ByteString data)
		{
			ProtoPreconditions.CheckNotNull(data, "data");
			T val = factory();
			val.MergeFrom(data);
			return val;
		}

		public new T ParseFrom(Stream input)
		{
			T val = factory();
			val.MergeFrom(input);
			return val;
		}

		public new T ParseDelimitedFrom(Stream input)
		{
			T val = factory();
			val.MergeDelimitedFrom(input);
			return val;
		}

		public new T ParseFrom(CodedInputStream input)
		{
			T result = factory();
			result.MergeFrom(input);
			return result;
		}

		public new T ParseJson(string json)
		{
			T val = factory();
			JsonParser.Default.Merge(val, json);
			return val;
		}
	}
	public static class ProtoPreconditions
	{
		public static T CheckNotNull<T>(T value, string name) where T : class
		{
			if (value == null)
			{
				throw new ArgumentNullException(name);
			}
			return value;
		}

		internal static T CheckNotNullUnconstrained<T>(T value, string name)
		{
			if (value == null)
			{
				throw new ArgumentNullException(name);
			}
			return value;
		}
	}
	public static class WireFormat
	{
		public enum WireType : uint
		{
			Varint,
			Fixed64,
			LengthDelimited,
			StartGroup,
			EndGroup,
			Fixed32
		}

		private const int TagTypeBits = 3;

		private const uint TagTypeMask = 7u;

		public static WireType GetTagWireType(uint tag)
		{
			return (WireType)(tag & 7);
		}

		public static int GetTagFieldNumber(uint tag)
		{
			return (int)tag >> 3;
		}

		public static uint MakeTag(int fieldNumber, WireType wireType)
		{
			return (uint)(fieldNumber << 3) | (uint)wireType;
		}
	}
}
namespace Google.Protobuf.WellKnownTypes
{
	public static class AnyReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static AnyReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chlnb29nbGUvcHJvdG9idWYvYW55LnByb3RvEg9nb29nbGUucHJvdG9idWYi" + "JgoDQW55EhAKCHR5cGVfdXJsGAEgASgJEg0KBXZhbHVlGAIgASgMQm8KE2Nv" + "bS5nb29nbGUucHJvdG9idWZCCEFueVByb3RvUAFaJWdpdGh1Yi5jb20vZ29s" + "YW5nL3Byb3RvYnVmL3B0eXBlcy9hbnmiAgNHUEKqAh5Hb29nbGUuUHJvdG9i" + "dWYuV2VsbEtub3duVHlwZXNiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Any), Any.Parser, new string[2] { "TypeUrl", "Value" }, null, null, null)
			}));
		}
	}
	public sealed class Any : IMessage<Any>, IMessage, IEquatable<Any>, IDeepCloneable<Any>
	{
		private static readonly MessageParser<Any> _parser = new MessageParser<Any>(() => new Any());

		public const int TypeUrlFieldNumber = 1;

		private string typeUrl_ = "";

		public const int ValueFieldNumber = 2;

		private ByteString value_ = ByteString.Empty;

		private const string DefaultPrefix = "type.googleapis.com";

		[DebuggerNonUserCode]
		public static MessageParser<Any> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => AnyReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string TypeUrl
		{
			get
			{
				return typeUrl_;
			}
			set
			{
				typeUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString Value
		{
			get
			{
				return value_;
			}
			set
			{
				value_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public Any()
		{
		}

		[DebuggerNonUserCode]
		public Any(Any other)
			: this()
		{
			typeUrl_ = other.typeUrl_;
			value_ = other.value_;
		}

		[DebuggerNonUserCode]
		public Any Clone()
		{
			return new Any(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Any);
		}

		[DebuggerNonUserCode]
		public bool Equals(Any other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (TypeUrl != other.TypeUrl)
			{
				return false;
			}
			if (Value != other.Value)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (TypeUrl.Length != 0)
			{
				num ^= TypeUrl.GetHashCode();
			}
			if (Value.Length != 0)
			{
				num ^= Value.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (TypeUrl.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(TypeUrl);
			}
			if (Value.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(Value);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (TypeUrl.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(TypeUrl);
			}
			if (Value.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(Value);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Any other)
		{
			if (other != null)
			{
				if (other.TypeUrl.Length != 0)
				{
					TypeUrl = other.TypeUrl;
				}
				if (other.Value.Length != 0)
				{
					Value = other.Value;
				}
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					TypeUrl = input.ReadString();
					break;
				case 18u:
					Value = input.ReadBytes();
					break;
				}
			}
		}

		private static string GetTypeUrl(MessageDescriptor descriptor, string prefix)
		{
			if (!prefix.EndsWith("/"))
			{
				return prefix + "/" + descriptor.FullName;
			}
			return prefix + descriptor.FullName;
		}

		internal static string GetTypeName(string typeUrl)
		{
			int num = typeUrl.LastIndexOf('/');
			if (num != -1)
			{
				return typeUrl.Substring(num + 1);
			}
			return "";
		}

		public T Unpack<T>() where T : IMessage, new()
		{
			T val = new T();
			if (GetTypeName(TypeUrl) != val.Descriptor.FullName)
			{
				throw new InvalidProtocolBufferException($"Full type name for {val.Descriptor.Name} is {val.Descriptor.FullName}; Any message's type url is {TypeUrl}");
			}
			val.MergeFrom(Value);
			return val;
		}

		public static Any Pack(IMessage message)
		{
			return Pack(message, "type.googleapis.com");
		}

		public static Any Pack(IMessage message, string typeUrlPrefix)
		{
			ProtoPreconditions.CheckNotNull(message, "message");
			ProtoPreconditions.CheckNotNull(typeUrlPrefix, "typeUrlPrefix");
			return new Any
			{
				TypeUrl = GetTypeUrl(message.Descriptor, typeUrlPrefix),
				Value = message.ToByteString()
			};
		}
	}
	public static class ApiReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static ApiReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chlnb29nbGUvcHJvdG9idWYvYXBpLnByb3RvEg9nb29nbGUucHJvdG9idWYa" + "JGdvb2dsZS9wcm90b2J1Zi9zb3VyY2VfY29udGV4dC5wcm90bxoaZ29vZ2xl" + "L3Byb3RvYnVmL3R5cGUucHJvdG8igQIKA0FwaRIMCgRuYW1lGAEgASgJEigK" + "B21ldGhvZHMYAiADKAsyFy5nb29nbGUucHJvdG9idWYuTWV0aG9kEigKB29w" + "dGlvbnMYAyADKAsyFy5nb29nbGUucHJvdG9idWYuT3B0aW9uEg8KB3ZlcnNp" + "b24YBCABKAkSNgoOc291cmNlX2NvbnRleHQYBSABKAsyHi5nb29nbGUucHJv" + "dG9idWYuU291cmNlQ29udGV4dBImCgZtaXhpbnMYBiADKAsyFi5nb29nbGUu" + "cHJvdG9idWYuTWl4aW4SJwoGc3ludGF4GAcgASgOMhcuZ29vZ2xlLnByb3Rv" + "YnVmLlN5bnRheCLVAQoGTWV0aG9kEgwKBG5hbWUYASABKAkSGAoQcmVxdWVz" + "dF90eXBlX3VybBgCIAEoCRIZChFyZXF1ZXN0X3N0cmVhbWluZxgDIAEoCBIZ" + "ChFyZXNwb25zZV90eXBlX3VybBgEIAEoCRIaChJyZXNwb25zZV9zdHJlYW1p" + "bmcYBSABKAgSKAoHb3B0aW9ucxgGIAMoCzIXLmdvb2dsZS5wcm90b2J1Zi5P" + "cHRpb24SJwoGc3ludGF4GAcgASgOMhcuZ29vZ2xlLnByb3RvYnVmLlN5bnRh" + "eCIjCgVNaXhpbhIMCgRuYW1lGAEgASgJEgwKBHJvb3QYAiABKAlCSAoTY29t" + "Lmdvb2dsZS5wcm90b2J1ZkIIQXBpUHJvdG9QAaICA0dQQqoCHkdvb2dsZS5Q" + "cm90b2J1Zi5XZWxsS25vd25UeXBlc2IGcHJvdG8z"), new FileDescriptor[2]
			{
				SourceContextReflection.Descriptor,
				TypeReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[3]
			{
				new GeneratedClrTypeInfo(typeof(Api), Api.Parser, new string[7] { "Name", "Methods", "Options", "Version", "SourceContext", "Mixins", "Syntax" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(Method), Method.Parser, new string[7] { "Name", "RequestTypeUrl", "RequestStreaming", "ResponseTypeUrl", "ResponseStreaming", "Options", "Syntax" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(Mixin), Mixin.Parser, new string[2] { "Name", "Root" }, null, null, null)
			}));
		}
	}
	public sealed class Api : IMessage<Api>, IMessage, IEquatable<Api>, IDeepCloneable<Api>
	{
		private static readonly MessageParser<Api> _parser = new MessageParser<Api>(() => new Api());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int MethodsFieldNumber = 2;

		private static readonly FieldCodec<Method> _repeated_methods_codec = FieldCodec.ForMessage(18u, Method.Parser);

		private readonly RepeatedField<Method> methods_ = new RepeatedField<Method>();

		public const int OptionsFieldNumber = 3;

		private static readonly FieldCodec<Option> _repeated_options_codec = FieldCodec.ForMessage(26u, Option.Parser);

		private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

		public const int VersionFieldNumber = 4;

		private string version_ = "";

		public const int SourceContextFieldNumber = 5;

		private SourceContext sourceContext_;

		public const int MixinsFieldNumber = 6;

		private static readonly FieldCodec<Mixin> _repeated_mixins_codec = FieldCodec.ForMessage(50u, Mixin.Parser);

		private readonly RepeatedField<Mixin> mixins_ = new RepeatedField<Mixin>();

		public const int SyntaxFieldNumber = 7;

		private Syntax syntax_;

		[DebuggerNonUserCode]
		public static MessageParser<Api> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => ApiReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<Method> Methods => methods_;

		[DebuggerNonUserCode]
		public RepeatedField<Option> Options => options_;

		[DebuggerNonUserCode]
		public string Version
		{
			get
			{
				return version_;
			}
			set
			{
				version_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public SourceContext SourceContext
		{
			get
			{
				return sourceContext_;
			}
			set
			{
				sourceContext_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<Mixin> Mixins => mixins_;

		[DebuggerNonUserCode]
		public Syntax Syntax
		{
			get
			{
				return syntax_;
			}
			set
			{
				syntax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Api()
		{
		}

		[DebuggerNonUserCode]
		public Api(Api other)
			: this()
		{
			name_ = other.name_;
			methods_ = other.methods_.Clone();
			options_ = other.options_.Clone();
			version_ = other.version_;
			SourceContext = ((other.sourceContext_ != null) ? other.SourceContext.Clone() : null);
			mixins_ = other.mixins_.Clone();
			syntax_ = other.syntax_;
		}

		[DebuggerNonUserCode]
		public Api Clone()
		{
			return new Api(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Api);
		}

		[DebuggerNonUserCode]
		public bool Equals(Api other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (!methods_.Equals(other.methods_))
			{
				return false;
			}
			if (!options_.Equals(other.options_))
			{
				return false;
			}
			if (Version != other.Version)
			{
				return false;
			}
			if (!object.Equals(SourceContext, other.SourceContext))
			{
				return false;
			}
			if (!mixins_.Equals(other.mixins_))
			{
				return false;
			}
			if (Syntax != other.Syntax)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			num ^= methods_.GetHashCode();
			num ^= options_.GetHashCode();
			if (Version.Length != 0)
			{
				num ^= Version.GetHashCode();
			}
			if (sourceContext_ != null)
			{
				num ^= SourceContext.GetHashCode();
			}
			num ^= mixins_.GetHashCode();
			if (Syntax != Syntax.Proto2)
			{
				num ^= Syntax.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			methods_.WriteTo(output, _repeated_methods_codec);
			options_.WriteTo(output, _repeated_options_codec);
			if (Version.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(Version);
			}
			if (sourceContext_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(SourceContext);
			}
			mixins_.WriteTo(output, _repeated_mixins_codec);
			if (Syntax != Syntax.Proto2)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)Syntax);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			num += methods_.CalculateSize(_repeated_methods_codec);
			num += options_.CalculateSize(_repeated_options_codec);
			if (Version.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Version);
			}
			if (sourceContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(SourceContext);
			}
			num += mixins_.CalculateSize(_repeated_mixins_codec);
			if (Syntax != Syntax.Proto2)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)Syntax);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Api other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			methods_.Add(other.methods_);
			options_.Add(other.options_);
			if (other.Version.Length != 0)
			{
				Version = other.Version;
			}
			if (other.sourceContext_ != null)
			{
				if (sourceContext_ == null)
				{
					sourceContext_ = new SourceContext();
				}
				SourceContext.MergeFrom(other.SourceContext);
			}
			mixins_.Add(other.mixins_);
			if (other.Syntax != Syntax.Proto2)
			{
				Syntax = other.Syntax;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					methods_.AddEntriesFrom(input, _repeated_methods_codec);
					break;
				case 26u:
					options_.AddEntriesFrom(input, _repeated_options_codec);
					break;
				case 34u:
					Version = input.ReadString();
					break;
				case 42u:
					if (sourceContext_ == null)
					{
						sourceContext_ = new SourceContext();
					}
					input.ReadMessage(sourceContext_);
					break;
				case 50u:
					mixins_.AddEntriesFrom(input, _repeated_mixins_codec);
					break;
				case 56u:
					syntax_ = (Syntax)input.ReadEnum();
					break;
				}
			}
		}
	}
	public sealed class Method : IMessage<Method>, IMessage, IEquatable<Method>, IDeepCloneable<Method>
	{
		private static readonly MessageParser<Method> _parser = new MessageParser<Method>(() => new Method());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int RequestTypeUrlFieldNumber = 2;

		private string requestTypeUrl_ = "";

		public const int RequestStreamingFieldNumber = 3;

		private bool requestStreaming_;

		public const int ResponseTypeUrlFieldNumber = 4;

		private string responseTypeUrl_ = "";

		public const int ResponseStreamingFieldNumber = 5;

		private bool responseStreaming_;

		public const int OptionsFieldNumber = 6;

		private static readonly FieldCodec<Option> _repeated_options_codec = FieldCodec.ForMessage(50u, Option.Parser);

		private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

		public const int SyntaxFieldNumber = 7;

		private Syntax syntax_;

		[DebuggerNonUserCode]
		public static MessageParser<Method> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => ApiReflection.Descriptor.MessageTypes[1];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public string RequestTypeUrl
		{
			get
			{
				return requestTypeUrl_;
			}
			set
			{
				requestTypeUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public bool RequestStreaming
		{
			get
			{
				return requestStreaming_;
			}
			set
			{
				requestStreaming_ = value;
			}
		}

		[DebuggerNonUserCode]
		public string ResponseTypeUrl
		{
			get
			{
				return responseTypeUrl_;
			}
			set
			{
				responseTypeUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public bool ResponseStreaming
		{
			get
			{
				return responseStreaming_;
			}
			set
			{
				responseStreaming_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<Option> Options => options_;

		[DebuggerNonUserCode]
		public Syntax Syntax
		{
			get
			{
				return syntax_;
			}
			set
			{
				syntax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Method()
		{
		}

		[DebuggerNonUserCode]
		public Method(Method other)
			: this()
		{
			name_ = other.name_;
			requestTypeUrl_ = other.requestTypeUrl_;
			requestStreaming_ = other.requestStreaming_;
			responseTypeUrl_ = other.responseTypeUrl_;
			responseStreaming_ = other.responseStreaming_;
			options_ = other.options_.Clone();
			syntax_ = other.syntax_;
		}

		[DebuggerNonUserCode]
		public Method Clone()
		{
			return new Method(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Method);
		}

		[DebuggerNonUserCode]
		public bool Equals(Method other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (RequestTypeUrl != other.RequestTypeUrl)
			{
				return false;
			}
			if (RequestStreaming != other.RequestStreaming)
			{
				return false;
			}
			if (ResponseTypeUrl != other.ResponseTypeUrl)
			{
				return false;
			}
			if (ResponseStreaming != other.ResponseStreaming)
			{
				return false;
			}
			if (!options_.Equals(other.options_))
			{
				return false;
			}
			if (Syntax != other.Syntax)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			if (RequestTypeUrl.Length != 0)
			{
				num ^= RequestTypeUrl.GetHashCode();
			}
			if (RequestStreaming)
			{
				num ^= RequestStreaming.GetHashCode();
			}
			if (ResponseTypeUrl.Length != 0)
			{
				num ^= ResponseTypeUrl.GetHashCode();
			}
			if (ResponseStreaming)
			{
				num ^= ResponseStreaming.GetHashCode();
			}
			num ^= options_.GetHashCode();
			if (Syntax != Syntax.Proto2)
			{
				num ^= Syntax.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			if (RequestTypeUrl.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(RequestTypeUrl);
			}
			if (RequestStreaming)
			{
				output.WriteRawTag(24);
				output.WriteBool(RequestStreaming);
			}
			if (ResponseTypeUrl.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(ResponseTypeUrl);
			}
			if (ResponseStreaming)
			{
				output.WriteRawTag(40);
				output.WriteBool(ResponseStreaming);
			}
			options_.WriteTo(output, _repeated_options_codec);
			if (Syntax != Syntax.Proto2)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)Syntax);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			if (RequestTypeUrl.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(RequestTypeUrl);
			}
			if (RequestStreaming)
			{
				num += 2;
			}
			if (ResponseTypeUrl.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(ResponseTypeUrl);
			}
			if (ResponseStreaming)
			{
				num += 2;
			}
			num += options_.CalculateSize(_repeated_options_codec);
			if (Syntax != Syntax.Proto2)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)Syntax);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Method other)
		{
			if (other != null)
			{
				if (other.Name.Length != 0)
				{
					Name = other.Name;
				}
				if (other.RequestTypeUrl.Length != 0)
				{
					RequestTypeUrl = other.RequestTypeUrl;
				}
				if (other.RequestStreaming)
				{
					RequestStreaming = other.RequestStreaming;
				}
				if (other.ResponseTypeUrl.Length != 0)
				{
					ResponseTypeUrl = other.ResponseTypeUrl;
				}
				if (other.ResponseStreaming)
				{
					ResponseStreaming = other.ResponseStreaming;
				}
				options_.Add(other.options_);
				if (other.Syntax != Syntax.Proto2)
				{
					Syntax = other.Syntax;
				}
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					RequestTypeUrl = input.ReadString();
					break;
				case 24u:
					RequestStreaming = input.ReadBool();
					break;
				case 34u:
					ResponseTypeUrl = input.ReadString();
					break;
				case 40u:
					ResponseStreaming = input.ReadBool();
					break;
				case 50u:
					options_.AddEntriesFrom(input, _repeated_options_codec);
					break;
				case 56u:
					syntax_ = (Syntax)input.ReadEnum();
					break;
				}
			}
		}
	}
	public sealed class Mixin : IMessage<Mixin>, IMessage, IEquatable<Mixin>, IDeepCloneable<Mixin>
	{
		private static readonly MessageParser<Mixin> _parser = new MessageParser<Mixin>(() => new Mixin());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int RootFieldNumber = 2;

		private string root_ = "";

		[DebuggerNonUserCode]
		public static MessageParser<Mixin> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => ApiReflection.Descriptor.MessageTypes[2];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public string Root
		{
			get
			{
				return root_;
			}
			set
			{
				root_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public Mixin()
		{
		}

		[DebuggerNonUserCode]
		public Mixin(Mixin other)
			: this()
		{
			name_ = other.name_;
			root_ = other.root_;
		}

		[DebuggerNonUserCode]
		public Mixin Clone()
		{
			return new Mixin(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Mixin);
		}

		[DebuggerNonUserCode]
		public bool Equals(Mixin other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (Root != other.Root)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			if (Root.Length != 0)
			{
				num ^= Root.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			if (Root.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(Root);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			if (Root.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Root);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Mixin other)
		{
			if (other != null)
			{
				if (other.Name.Length != 0)
				{
					Name = other.Name;
				}
				if (other.Root.Length != 0)
				{
					Root = other.Root;
				}
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					Root = input.ReadString();
					break;
				}
			}
		}
	}
	public static class DurationReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static DurationReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5nb29nbGUvcHJvdG9idWYvZHVyYXRpb24ucHJvdG8SD2dvb2dsZS5wcm90" + "b2J1ZiIqCghEdXJhdGlvbhIPCgdzZWNvbmRzGAEgASgDEg0KBW5hbm9zGAIg" + "ASgFQnwKE2NvbS5nb29nbGUucHJvdG9idWZCDUR1cmF0aW9uUHJvdG9QAVoq" + "Z2l0aHViLmNvbS9nb2xhbmcvcHJvdG9idWYvcHR5cGVzL2R1cmF0aW9u+AEB" + "ogIDR1BCqgIeR29vZ2xlLlByb3RvYnVmLldlbGxLbm93blR5cGVzYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Duration), Duration.Parser, new string[2] { "Seconds", "Nanos" }, null, null, null)
			}));
		}
	}
	public sealed class Duration : IMessage<Duration>, IMessage, IEquatable<Duration>, IDeepCloneable<Duration>, ICustomDiagnosticMessage
	{
		private static readonly MessageParser<Duration> _parser = new MessageParser<Duration>(() => new Duration());

		public const int SecondsFieldNumber = 1;

		private long seconds_;

		public const int NanosFieldNumber = 2;

		private int nanos_;

		public const int NanosecondsPerSecond = 1000000000;

		public const int NanosecondsPerTick = 100;

		public const long MaxSeconds = 315576000000L;

		public const long MinSeconds = -315576000000L;

		internal const int MaxNanoseconds = 999999999;

		internal const int MinNanoseconds = -999999999;

		[DebuggerNonUserCode]
		public static MessageParser<Duration> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DurationReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public long Seconds
		{
			get
			{
				return seconds_;
			}
			set
			{
				seconds_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Nanos
		{
			get
			{
				return nanos_;
			}
			set
			{
				nanos_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Duration()
		{
		}

		[DebuggerNonUserCode]
		public Duration(Duration other)
			: this()
		{
			seconds_ = other.seconds_;
			nanos_ = other.nanos_;
		}

		[DebuggerNonUserCode]
		public Duration Clone()
		{
			return new Duration(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Duration);
		}

		[DebuggerNonUserCode]
		public bool Equals(Duration other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Seconds != other.Seconds)
			{
				return false;
			}
			if (Nanos != other.Nanos)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Seconds != 0L)
			{
				num ^= Seconds.GetHashCode();
			}
			if (Nanos != 0)
			{
				num ^= Nanos.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Seconds != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(Seconds);
			}
			if (Nanos != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(Nanos);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Seconds != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(Seconds);
			}
			if (Nanos != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(Nanos);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Duration other)
		{
			if (other != null)
			{
				if (other.Seconds != 0L)
				{
					Seconds = other.Seconds;
				}
				if (other.Nanos != 0)
				{
					Nanos = other.Nanos;
				}
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 8u:
					Seconds = input.ReadInt64();
					break;
				case 16u:
					Nanos = input.ReadInt32();
					break;
				}
			}
		}

		internal static bool IsNormalized(long seconds, int nanoseconds)
		{
			if (seconds < -315576000000L || seconds > 315576000000L || nanoseconds < -999999999 || nanoseconds > 999999999)
			{
				return false;
			}
			return Math.Sign(seconds) * Math.Sign(nanoseconds) != -1;
		}

		public TimeSpan ToTimeSpan()
		{
			if (!IsNormalized(Seconds, Nanos))
			{
				throw new InvalidOperationException("Duration was not a valid normalized duration");
			}
			checked
			{
				return TimeSpan.FromTicks(Seconds * 10000000 + unchecked(Nanos / 100));
			}
		}

		public static Duration FromTimeSpan(TimeSpan timeSpan)
		{
			long ticks = timeSpan.Ticks;
			long seconds = ticks / 10000000;
			checked
			{
				int nanos = (int)unchecked(ticks % 10000000) * 100;
				return new Duration
				{
					Seconds = seconds,
					Nanos = nanos
				};
			}
		}

		public static Duration operator -(Duration value)
		{
			ProtoPreconditions.CheckNotNull(value, "value");
			return checked(Normalize(-value.Seconds, -value.Nanos));
		}

		public static Duration operator +(Duration lhs, Duration rhs)
		{
			ProtoPreconditions.CheckNotNull(lhs, "lhs");
			ProtoPreconditions.CheckNotNull(rhs, "rhs");
			return checked(Normalize(lhs.Seconds + rhs.Seconds, lhs.Nanos + rhs.Nanos));
		}

		public static Duration operator -(Duration lhs, Duration rhs)
		{
			ProtoPreconditions.CheckNotNull(lhs, "lhs");
			ProtoPreconditions.CheckNotNull(rhs, "rhs");
			return checked(Normalize(lhs.Seconds - rhs.Seconds, lhs.Nanos - rhs.Nanos));
		}

		internal static Duration Normalize(long seconds, int nanoseconds)
		{
			int num = nanoseconds / 1000000000;
			seconds += num;
			nanoseconds -= num * 1000000000;
			if (seconds < 0 && nanoseconds > 0)
			{
				seconds++;
				nanoseconds -= 1000000000;
			}
			else if (seconds > 0 && nanoseconds < 0)
			{
				seconds--;
				nanoseconds += 1000000000;
			}
			return new Duration
			{
				Seconds = seconds,
				Nanos = nanoseconds
			};
		}

		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly)
		{
			if (IsNormalized(seconds, nanoseconds))
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append('"');
				if (seconds == 0L && nanoseconds < 0)
				{
					stringBuilder.Append('-');
				}
				stringBuilder.Append(seconds.ToString("d", CultureInfo.InvariantCulture));
				AppendNanoseconds(stringBuilder, Math.Abs(nanoseconds));
				stringBuilder.Append("s\"");
				return stringBuilder.ToString();
			}
			if (diagnosticOnly)
			{
				return string.Format(CultureInfo.InvariantCulture, "{{ \"@warning\": \"Invalid Duration\", \"seconds\": \"{0}\", \"nanos\": {1} }}", seconds, nanoseconds);
			}
			throw new InvalidOperationException("Non-normalized duration value");
		}

		public string ToDiagnosticString()
		{
			return ToJson(Seconds, Nanos, diagnosticOnly: true);
		}

		internal static void AppendNanoseconds(StringBuilder builder, int nanos)
		{
			if (nanos != 0)
			{
				builder.Append('.');
				if (nanos % 1000000 == 0)
				{
					builder.Append((nanos / 1000000).ToString("d3", CultureInfo.InvariantCulture));
				}
				else if (nanos % 1000 == 0)
				{
					builder.Append((nanos / 1000).ToString("d6", CultureInfo.InvariantCulture));
				}
				else
				{
					builder.Append(nanos.ToString("d9", CultureInfo.InvariantCulture));
				}
			}
		}
	}
	public static class EmptyReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static EmptyReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8SD2dvb2dsZS5wcm90b2J1" + "ZiIHCgVFbXB0eUJ2ChNjb20uZ29vZ2xlLnByb3RvYnVmQgpFbXB0eVByb3Rv" + "UAFaJ2dpdGh1Yi5jb20vZ29sYW5nL3Byb3RvYnVmL3B0eXBlcy9lbXB0efgB" + "AaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Empty), Empty.Parser, null, null, null, null)
			}));
		}
	}
	public sealed class Empty : IMessage<Empty>, IMessage, IEquatable<Empty>, IDeepCloneable<Empty>
	{
		private static readonly MessageParser<Empty> _parser = new MessageParser<Empty>(() => new Empty());

		[DebuggerNonUserCode]
		public static MessageParser<Empty> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => EmptyReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public Empty()
		{
		}

		[DebuggerNonUserCode]
		public Empty(Empty other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public Empty Clone()
		{
			return new Empty(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Empty);
		}

		[DebuggerNonUserCode]
		public bool Equals(Empty other)
		{
			if (other == null)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 1;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Empty other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				input.SkipLastField();
			}
		}
	}
	public static class FieldMaskReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static FieldMaskReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90bxIPZ29vZ2xlLnBy" + "b3RvYnVmIhoKCUZpZWxkTWFzaxINCgVwYXRocxgBIAMoCUJOChNjb20uZ29v" + "Z2xlLnByb3RvYnVmQg5GaWVsZE1hc2tQcm90b1ABogIDR1BCqgIeR29vZ2xl" + "LlByb3RvYnVmLldlbGxLbm93blR5cGVzYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(FieldMask), FieldMask.Parser, new string[1] { "Paths" }, null, null, null)
			}));
		}
	}
	public sealed class FieldMask : IMessage<FieldMask>, IMessage, IEquatable<FieldMask>, IDeepCloneable<FieldMask>, ICustomDiagnosticMessage
	{
		private static readonly MessageParser<FieldMask> _parser = new MessageParser<FieldMask>(() => new FieldMask());

		public const int PathsFieldNumber = 1;

		private static readonly FieldCodec<string> _repeated_paths_codec = FieldCodec.ForString(10u);

		private readonly RepeatedField<string> paths_ = new RepeatedField<string>();

		[DebuggerNonUserCode]
		public static MessageParser<FieldMask> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => FieldMaskReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public RepeatedField<string> Paths => paths_;

		[DebuggerNonUserCode]
		public FieldMask()
		{
		}

		[DebuggerNonUserCode]
		public FieldMask(FieldMask other)
			: this()
		{
			paths_ = other.paths_.Clone();
		}

		[DebuggerNonUserCode]
		public FieldMask Clone()
		{
			return new FieldMask(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as FieldMask);
		}

		[DebuggerNonUserCode]
		public bool Equals(FieldMask other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (!paths_.Equals(other.paths_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 1 ^ paths_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			paths_.WriteTo(output, _repeated_paths_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0 + paths_.CalculateSize(_repeated_paths_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(FieldMask other)
		{
			if (other != null)
			{
				paths_.Add(other.paths_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 10)
				{
					input.SkipLastField();
				}
				else
				{
					paths_.AddEntriesFrom(input, _repeated_paths_codec);
				}
			}
		}

		internal static string ToJson(IList<string> paths, bool diagnosticOnly)
		{
			string text = paths.FirstOrDefault((string p) => !ValidatePath(p));
			if (text == null)
			{
				StringWriter stringWriter = new StringWriter();
				IEnumerable<string> source = paths.Select(JsonFormatter.ToCamelCase);
				JsonFormatter.WriteString(stringWriter, string.Join(",", source.ToArray()));
				return stringWriter.ToString();
			}
			if (diagnosticOnly)
			{
				StringWriter stringWriter2 = new StringWriter();
				stringWriter2.Write("{ \"@warning\": \"Invalid FieldMask\", \"paths\": ");
				JsonFormatter.Default.WriteList(stringWriter2, (IList)paths);
				stringWriter2.Write(" }");
				return stringWriter2.ToString();
			}
			throw new InvalidOperationException($"Invalid field mask to be converted to JSON: {text}");
		}

		private static bool ValidatePath(string input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				char c = input[i];
				if (c >= 'A' && c <= 'Z')
				{
					return false;
				}
				if (c == '_' && i < input.Length - 1)
				{
					char c2 = input[i + 1];
					if (c2 < 'a' || c2 > 'z')
					{
						return false;
					}
				}
			}
			return true;
		}

		public string ToDiagnosticString()
		{
			return ToJson(Paths, diagnosticOnly: true);
		}
	}
	public static class SourceContextReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static SourceContextReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRnb29nbGUvcHJvdG9idWYvc291cmNlX2NvbnRleHQucHJvdG8SD2dvb2ds" + "ZS5wcm90b2J1ZiIiCg1Tb3VyY2VDb250ZXh0EhEKCWZpbGVfbmFtZRgBIAEo" + "CUJSChNjb20uZ29vZ2xlLnByb3RvYnVmQhJTb3VyY2VDb250ZXh0UHJvdG9Q" + "AaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(SourceContext), SourceContext.Parser, new string[1] { "FileName" }, null, null, null)
			}));
		}
	}
	public sealed class SourceContext : IMessage<SourceContext>, IMessage, IEquatable<SourceContext>, IDeepCloneable<SourceContext>
	{
		private static readonly MessageParser<SourceContext> _parser = new MessageParser<SourceContext>(() => new SourceContext());

		public const int FileNameFieldNumber = 1;

		private string fileName_ = "";

		[DebuggerNonUserCode]
		public static MessageParser<SourceContext> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => SourceContextReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string FileName
		{
			get
			{
				return fileName_;
			}
			set
			{
				fileName_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public SourceContext()
		{
		}

		[DebuggerNonUserCode]
		public SourceContext(SourceContext other)
			: this()
		{
			fileName_ = other.fileName_;
		}

		[DebuggerNonUserCode]
		public SourceContext Clone()
		{
			return new SourceContext(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as SourceContext);
		}

		[DebuggerNonUserCode]
		public bool Equals(SourceContext other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (FileName != other.FileName)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (FileName.Length != 0)
			{
				num ^= FileName.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (FileName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(FileName);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (FileName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(FileName);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(SourceContext other)
		{
			if (other != null && other.FileName.Length != 0)
			{
				FileName = other.FileName;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 10)
				{
					input.SkipLastField();
				}
				else
				{
					FileName = input.ReadString();
				}
			}
		}
	}
	public static class StructReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static StructReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chxnb29nbGUvcHJvdG9idWYvc3RydWN0LnByb3RvEg9nb29nbGUucHJvdG9i" + "dWYihAEKBlN0cnVjdBIzCgZmaWVsZHMYASADKAsyIy5nb29nbGUucHJvdG9i" + "dWYuU3RydWN0LkZpZWxkc0VudHJ5GkUKC0ZpZWxkc0VudHJ5EgsKA2tleRgB" + "IAEoCRIlCgV2YWx1ZRgCIAEoCzIWLmdvb2dsZS5wcm90b2J1Zi5WYWx1ZToC" + "OAEi6gEKBVZhbHVlEjAKCm51bGxfdmFsdWUYASABKA4yGi5nb29nbGUucHJv" + "dG9idWYuTnVsbFZhbHVlSAASFgoMbnVtYmVyX3ZhbHVlGAIgASgBSAASFgoM" + "c3RyaW5nX3ZhbHVlGAMgASgJSAASFAoKYm9vbF92YWx1ZRgEIAEoCEgAEi8K" + "DHN0cnVjdF92YWx1ZRgFIAEoCzIXLmdvb2dsZS5wcm90b2J1Zi5TdHJ1Y3RI" + "ABIwCgpsaXN0X3ZhbHVlGAYgASgLMhouZ29vZ2xlLnByb3RvYnVmLkxpc3RW" + "YWx1ZUgAQgYKBGtpbmQiMwoJTGlzdFZhbHVlEiYKBnZhbHVlcxgBIAMoCzIW" + "Lmdvb2dsZS5wcm90b2J1Zi5WYWx1ZSobCglOdWxsVmFsdWUSDgoKTlVMTF9W" + "QUxVRRAAQoEBChNjb20uZ29vZ2xlLnByb3RvYnVmQgtTdHJ1Y3RQcm90b1AB" + "WjFnaXRodWIuY29tL2dvbGFuZy9wcm90b2J1Zi9wdHlwZXMvc3RydWN0O3N0" + "cnVjdHBi+AEBogIDR1BCqgIeR29vZ2xlLlByb3RvYnVmLldlbGxLbm93blR5" + "cGVzYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new System.Type[1] { typeof(NullValue) }, new GeneratedClrTypeInfo[3]
			{
				new GeneratedClrTypeInfo(typeof(Struct), Struct.Parser, new string[1] { "Fields" }, null, null, new GeneratedClrTypeInfo[1]),
				new GeneratedClrTypeInfo(typeof(Value), Value.Parser, new string[6] { "NullValue", "NumberValue", "StringValue", "BoolValue", "StructValue", "ListValue" }, new string[1] { "Kind" }, null, null),
				new GeneratedClrTypeInfo(typeof(ListValue), ListValue.Parser, new string[1] { "Values" }, null, null, null)
			}));
		}
	}
	public enum NullValue
	{
		[OriginalName("NULL_VALUE")]
		NullValue
	}
	public sealed class Struct : IMessage<Struct>, IMessage, IEquatable<Struct>, IDeepCloneable<Struct>
	{
		private static readonly MessageParser<Struct> _parser = new MessageParser<Struct>(() => new Struct());

		public const int FieldsFieldNumber = 1;

		private static readonly MapField<string, Value>.Codec _map_fields_codec = new MapField<string, Value>.Codec(FieldCodec.ForString(10u), FieldCodec.ForMessage(18u, Value.Parser), 10u);

		private readonly MapField<string, Value> fields_ = new MapField<string, Value>();

		[DebuggerNonUserCode]
		public static MessageParser<Struct> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => StructReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public MapField<string, Value> Fields => fields_;

		[DebuggerNonUserCode]
		public Struct()
		{
		}

		[DebuggerNonUserCode]
		public Struct(Struct other)
			: this()
		{
			fields_ = other.fields_.Clone();
		}

		[DebuggerNonUserCode]
		public Struct Clone()
		{
			return new Struct(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Struct);
		}

		[DebuggerNonUserCode]
		public bool Equals(Struct other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (!Fields.Equals(other.Fields))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 1 ^ Fields.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			fields_.WriteTo(output, _map_fields_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0 + fields_.CalculateSize(_map_fields_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Struct other)
		{
			if (other != null)
			{
				fields_.Add(other.fields_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 10)
				{
					input.SkipLastField();
				}
				else
				{
					fields_.AddEntriesFrom(input, _map_fields_codec);
				}
			}
		}
	}
	public sealed class Value : IMessage<Value>, IMessage, IEquatable<Value>, IDeepCloneable<Value>
	{
		public enum KindOneofCase
		{
			None,
			NullValue,
			NumberValue,
			StringValue,
			BoolValue,
			StructValue,
			ListValue
		}

		private static readonly MessageParser<Value> _parser = new MessageParser<Value>(() => new Value());

		public const int NullValueFieldNumber = 1;

		public const int NumberValueFieldNumber = 2;

		public const int StringValueFieldNumber = 3;

		public const int BoolValueFieldNumber = 4;

		public const int StructValueFieldNumber = 5;

		public const int ListValueFieldNumber = 6;

		private object kind_;

		private KindOneofCase kindCase_;

		[DebuggerNonUserCode]
		public static MessageParser<Value> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => StructReflection.Descriptor.MessageTypes[1];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public NullValue NullValue
		{
			get
			{
				if (kindCase_ != KindOneofCase.NullValue)
				{
					return NullValue.NullValue;
				}
				return (NullValue)kind_;
			}
			set
			{
				kind_ = value;
				kindCase_ = KindOneofCase.NullValue;
			}
		}

		[DebuggerNonUserCode]
		public double NumberValue
		{
			get
			{
				if (kindCase_ != KindOneofCase.NumberValue)
				{
					return 0.0;
				}
				return (double)kind_;
			}
			set
			{
				kind_ = value;
				kindCase_ = KindOneofCase.NumberValue;
			}
		}

		[DebuggerNonUserCode]
		public string StringValue
		{
			get
			{
				if (kindCase_ != KindOneofCase.StringValue)
				{
					return "";
				}
				return (string)kind_;
			}
			set
			{
				kind_ = ProtoPreconditions.CheckNotNull(value, "value");
				kindCase_ = KindOneofCase.StringValue;
			}
		}

		[DebuggerNonUserCode]
		public bool BoolValue
		{
			get
			{
				if (kindCase_ != KindOneofCase.BoolValue)
				{
					return false;
				}
				return (bool)kind_;
			}
			set
			{
				kind_ = value;
				kindCase_ = KindOneofCase.BoolValue;
			}
		}

		[DebuggerNonUserCode]
		public Struct StructValue
		{
			get
			{
				if (kindCase_ != KindOneofCase.StructValue)
				{
					return null;
				}
				return (Struct)kind_;
			}
			set
			{
				kind_ = value;
				kindCase_ = ((value != null) ? KindOneofCase.StructValue : KindOneofCase.None);
			}
		}

		[DebuggerNonUserCode]
		public ListValue ListValue
		{
			get
			{
				if (kindCase_ != KindOneofCase.ListValue)
				{
					return null;
				}
				return (ListValue)kind_;
			}
			set
			{
				kind_ = value;
				kindCase_ = ((value != null) ? KindOneofCase.ListValue : KindOneofCase.None);
			}
		}

		[DebuggerNonUserCode]
		public KindOneofCase KindCase => kindCase_;

		[DebuggerNonUserCode]
		public Value()
		{
		}

		[DebuggerNonUserCode]
		public Value(Value other)
			: this()
		{
			switch (other.KindCase)
			{
			case KindOneofCase.NullValue:
				NullValue = other.NullValue;
				break;
			case KindOneofCase.NumberValue:
				NumberValue = other.NumberValue;
				break;
			case KindOneofCase.StringValue:
				StringValue = other.StringValue;
				break;
			case KindOneofCase.BoolValue:
				BoolValue = other.BoolValue;
				break;
			case KindOneofCase.StructValue:
				StructValue = other.StructValue.Clone();
				break;
			case KindOneofCase.ListValue:
				ListValue = other.ListValue.Clone();
				break;
			}
		}

		[DebuggerNonUserCode]
		public Value Clone()
		{
			return new Value(this);
		}

		[DebuggerNonUserCode]
		public void ClearKind()
		{
			kindCase_ = KindOneofCase.None;
			kind_ = null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Value);
		}

		[DebuggerNonUserCode]
		public bool Equals(Value other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (NullValue != other.NullValue)
			{
				return false;
			}
			if (NumberValue != other.NumberValue)
			{
				return false;
			}
			if (StringValue != other.StringValue)
			{
				return false;
			}
			if (BoolValue != other.BoolValue)
			{
				return false;
			}
			if (!object.Equals(StructValue, other.StructValue))
			{
				return false;
			}
			if (!object.Equals(ListValue, other.ListValue))
			{
				return false;
			}
			if (KindCase != other.KindCase)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (kindCase_ == KindOneofCase.NullValue)
			{
				num ^= NullValue.GetHashCode();
			}
			if (kindCase_ == KindOneofCase.NumberValue)
			{
				num ^= NumberValue.GetHashCode();
			}
			if (kindCase_ == KindOneofCase.StringValue)
			{
				num ^= StringValue.GetHashCode();
			}
			if (kindCase_ == KindOneofCase.BoolValue)
			{
				num ^= BoolValue.GetHashCode();
			}
			if (kindCase_ == KindOneofCase.StructValue)
			{
				num ^= StructValue.GetHashCode();
			}
			if (kindCase_ == KindOneofCase.ListValue)
			{
				num ^= ListValue.GetHashCode();
			}
			return num ^ (int)kindCase_;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (kindCase_ == KindOneofCase.NullValue)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)NullValue);
			}
			if (kindCase_ == KindOneofCase.NumberValue)
			{
				output.WriteRawTag(17);
				output.WriteDouble(NumberValue);
			}
			if (kindCase_ == KindOneofCase.StringValue)
			{
				output.WriteRawTag(26);
				output.WriteString(StringValue);
			}
			if (kindCase_ == KindOneofCase.BoolValue)
			{
				output.WriteRawTag(32);
				output.WriteBool(BoolValue);
			}
			if (kindCase_ == KindOneofCase.StructValue)
			{
				output.WriteRawTag(42);
				output.WriteMessage(StructValue);
			}
			if (kindCase_ == KindOneofCase.ListValue)
			{
				output.WriteRawTag(50);
				output.WriteMessage(ListValue);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (kindCase_ == KindOneofCase.NullValue)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)NullValue);
			}
			if (kindCase_ == KindOneofCase.NumberValue)
			{
				num += 9;
			}
			if (kindCase_ == KindOneofCase.StringValue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(StringValue);
			}
			if (kindCase_ == KindOneofCase.BoolValue)
			{
				num += 2;
			}
			if (kindCase_ == KindOneofCase.StructValue)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(StructValue);
			}
			if (kindCase_ == KindOneofCase.ListValue)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(ListValue);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Value other)
		{
			if (other != null)
			{
				switch (other.KindCase)
				{
				case KindOneofCase.NullValue:
					NullValue = other.NullValue;
					break;
				case KindOneofCase.NumberValue:
					NumberValue = other.NumberValue;
					break;
				case KindOneofCase.StringValue:
					StringValue = other.StringValue;
					break;
				case KindOneofCase.BoolValue:
					BoolValue = other.BoolValue;
					break;
				case KindOneofCase.StructValue:
					StructValue = other.StructValue;
					break;
				case KindOneofCase.ListValue:
					ListValue = other.ListValue;
					break;
				}
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 8u:
					kind_ = input.ReadEnum();
					kindCase_ = KindOneofCase.NullValue;
					break;
				case 17u:
					NumberValue = input.ReadDouble();
					break;
				case 26u:
					StringValue = input.ReadString();
					break;
				case 32u:
					BoolValue = input.ReadBool();
					break;
				case 42u:
				{
					Struct obj = new Struct();
					if (kindCase_ == KindOneofCase.StructValue)
					{
						obj.MergeFrom(StructValue);
					}
					input.ReadMessage(obj);
					StructValue = obj;
					break;
				}
				case 50u:
				{
					ListValue listValue = new ListValue();
					if (kindCase_ == KindOneofCase.ListValue)
					{
						listValue.MergeFrom(ListValue);
					}
					input.ReadMessage(listValue);
					ListValue = listValue;
					break;
				}
				}
			}
		}

		public static Value ForString(string value)
		{
			ProtoPreconditions.CheckNotNull(value, "value");
			return new Value
			{
				StringValue = value
			};
		}

		public static Value ForNumber(double value)
		{
			return new Value
			{
				NumberValue = value
			};
		}

		public static Value ForBool(bool value)
		{
			return new Value
			{
				BoolValue = value
			};
		}

		public static Value ForNull()
		{
			return new Value
			{
				NullValue = NullValue.NullValue
			};
		}

		public static Value ForList(params Value[] values)
		{
			ProtoPreconditions.CheckNotNull(values, "values");
			return new Value
			{
				ListValue = new ListValue
				{
					Values = { (IEnumerable<Value>)values }
				}
			};
		}

		public static Value ForStruct(Struct value)
		{
			ProtoPreconditions.CheckNotNull(value, "value");
			return new Value
			{
				StructValue = value
			};
		}
	}
	public sealed class ListValue : IMessage<ListValue>, IMessage, IEquatable<ListValue>, IDeepCloneable<ListValue>
	{
		private static readonly MessageParser<ListValue> _parser = new MessageParser<ListValue>(() => new ListValue());

		public const int ValuesFieldNumber = 1;

		private static readonly FieldCodec<Value> _repeated_values_codec = FieldCodec.ForMessage(10u, Value.Parser);

		private readonly RepeatedField<Value> values_ = new RepeatedField<Value>();

		[DebuggerNonUserCode]
		public static MessageParser<ListValue> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => StructReflection.Descriptor.MessageTypes[2];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public RepeatedField<Value> Values => values_;

		[DebuggerNonUserCode]
		public ListValue()
		{
		}

		[DebuggerNonUserCode]
		public ListValue(ListValue other)
			: this()
		{
			values_ = other.values_.Clone();
		}

		[DebuggerNonUserCode]
		public ListValue Clone()
		{
			return new ListValue(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as ListValue);
		}

		[DebuggerNonUserCode]
		public bool Equals(ListValue other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (!values_.Equals(other.values_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 1 ^ values_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			values_.WriteTo(output, _repeated_values_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0 + values_.CalculateSize(_repeated_values_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(ListValue other)
		{
			if (other != null)
			{
				values_.Add(other.values_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 10)
				{
					input.SkipLastField();
				}
				else
				{
					values_.AddEntriesFrom(input, _repeated_values_codec);
				}
			}
		}
	}
	public static class TimeExtensions
	{
		public static Timestamp ToTimestamp(this DateTime dateTime)
		{
			return Timestamp.FromDateTime(dateTime);
		}

		public static Timestamp ToTimestamp(this DateTimeOffset dateTimeOffset)
		{
			return Timestamp.FromDateTimeOffset(dateTimeOffset);
		}

		public static Duration ToDuration(this TimeSpan timeSpan)
		{
			return Duration.FromTimeSpan(timeSpan);
		}
	}
	public static class TimestampReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static TimestampReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvEg9nb29nbGUucHJv" + "dG9idWYiKwoJVGltZXN0YW1wEg8KB3NlY29uZHMYASABKAMSDQoFbmFub3MY" + "AiABKAVCfgoTY29tLmdvb2dsZS5wcm90b2J1ZkIOVGltZXN0YW1wUHJvdG9Q" + "AVorZ2l0aHViLmNvbS9nb2xhbmcvcHJvdG9idWYvcHR5cGVzL3RpbWVzdGFt" + "cPgBAaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
			{
				new GeneratedClrTypeInfo(typeof(Timestamp), Timestamp.Parser, new string[2] { "Seconds", "Nanos" }, null, null, null)
			}));
		}
	}
	public sealed class Timestamp : IMessage<Timestamp>, IMessage, IEquatable<Timestamp>, IDeepCloneable<Timestamp>, ICustomDiagnosticMessage
	{
		private static readonly MessageParser<Timestamp> _parser = new MessageParser<Timestamp>(() => new Timestamp());

		public const int SecondsFieldNumber = 1;

		private long seconds_;

		public const int NanosFieldNumber = 2;

		private int nanos_;

		private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		private const long BclSecondsAtUnixEpoch = 62135596800L;

		internal const long UnixSecondsAtBclMaxValue = 253402300799L;

		internal const long UnixSecondsAtBclMinValue = -62135596800L;

		internal const int MaxNanos = 999999999;

		[DebuggerNonUserCode]
		public static MessageParser<Timestamp> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => TimestampReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public long Seconds
		{
			get
			{
				return seconds_;
			}
			set
			{
				seconds_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Nanos
		{
			get
			{
				return nanos_;
			}
			set
			{
				nanos_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Timestamp()
		{
		}

		[DebuggerNonUserCode]
		public Timestamp(Timestamp other)
			: this()
		{
			seconds_ = other.seconds_;
			nanos_ = other.nanos_;
		}

		[DebuggerNonUserCode]
		public Timestamp Clone()
		{
			return new Timestamp(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Timestamp);
		}

		[DebuggerNonUserCode]
		public bool Equals(Timestamp other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Seconds != other.Seconds)
			{
				return false;
			}
			if (Nanos != other.Nanos)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Seconds != 0L)
			{
				num ^= Seconds.GetHashCode();
			}
			if (Nanos != 0)
			{
				num ^= Nanos.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Seconds != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(Seconds);
			}
			if (Nanos != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(Nanos);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Seconds != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(Seconds);
			}
			if (Nanos != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(Nanos);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Timestamp other)
		{
			if (other != null)
			{
				if (other.Seconds != 0L)
				{
					Seconds = other.Seconds;
				}
				if (other.Nanos != 0)
				{
					Nanos = other.Nanos;
				}
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 8u:
					Seconds = input.ReadInt64();
					break;
				case 16u:
					Nanos = input.ReadInt32();
					break;
				}
			}
		}

		private static bool IsNormalized(long seconds, int nanoseconds)
		{
			if (nanoseconds >= 0 && nanoseconds <= 999999999 && seconds >= -62135596800L)
			{
				return seconds <= 253402300799L;
			}
			return false;
		}

		public static Duration operator -(Timestamp lhs, Timestamp rhs)
		{
			ProtoPreconditions.CheckNotNull(lhs, "lhs");
			ProtoPreconditions.CheckNotNull(rhs, "rhs");
			return checked(Duration.Normalize(lhs.Seconds - rhs.Seconds, lhs.Nanos - rhs.Nanos));
		}

		public static Timestamp operator +(Timestamp lhs, Duration rhs)
		{
			ProtoPreconditions.CheckNotNull(lhs, "lhs");
			ProtoPreconditions.CheckNotNull(rhs, "rhs");
			return checked(Normalize(lhs.Seconds + rhs.Seconds, lhs.Nanos + rhs.Nanos));
		}

		public static Timestamp operator -(Timestamp lhs, Duration rhs)
		{
			ProtoPreconditions.CheckNotNull(lhs, "lhs");
			ProtoPreconditions.CheckNotNull(rhs, "rhs");
			return checked(Normalize(lhs.Seconds - rhs.Seconds, lhs.Nanos - rhs.Nanos));
		}

		public DateTime ToDateTime()
		{
			if (!IsNormalized(Seconds, Nanos))
			{
				throw new InvalidOperationException("Timestamp contains invalid values: Seconds={Seconds}; Nanos={Nanos}");
			}
			return UnixEpoch.AddSeconds(Seconds).AddTicks(Nanos / 100);
		}

		public DateTimeOffset ToDateTimeOffset()
		{
			return new DateTimeOffset(ToDateTime(), TimeSpan.Zero);
		}

		public static Timestamp FromDateTime(DateTime dateTime)
		{
			if (dateTime.Kind != DateTimeKind.Utc)
			{
				throw new ArgumentException("Conversion from DateTime to Timestamp requires the DateTime kind to be Utc", "dateTime");
			}
			long num = dateTime.Ticks / 10000000;
			int nanos = (int)(dateTime.Ticks % 10000000) * 100;
			return new Timestamp
			{
				Seconds = num - 62135596800L,
				Nanos = nanos
			};
		}

		public static Timestamp FromDateTimeOffset(DateTimeOffset dateTimeOffset)
		{
			return FromDateTime(dateTimeOffset.UtcDateTime);
		}

		internal static Timestamp Normalize(long seconds, int nanoseconds)
		{
			int num = nanoseconds / 1000000000;
			seconds += num;
			nanoseconds -= num * 1000000000;
			if (nanoseconds < 0)
			{
				nanoseconds += 1000000000;
				seconds--;
			}
			return new Timestamp
			{
				Seconds = seconds,
				Nanos = nanoseconds
			};
		}

		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly)
		{
			if (IsNormalized(seconds, nanoseconds))
			{
				DateTime dateTime = UnixEpoch.AddSeconds(seconds);
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append('"');
				stringBuilder.Append(dateTime.ToString("yyyy'-'MM'-'dd'T'HH:mm:ss", CultureInfo.InvariantCulture));
				Duration.AppendNanoseconds(stringBuilder, nanoseconds);
				stringBuilder.Append("Z\"");
				return stringBuilder.ToString();
			}
			if (diagnosticOnly)
			{
				return string.Format(CultureInfo.InvariantCulture, "{{ \"@warning\": \"Invalid Timestamp\", \"seconds\": \"{0}\", \"nanos\": {1} }}", seconds, nanoseconds);
			}
			throw new InvalidOperationException("Non-normalized timestamp value");
		}

		public string ToDiagnosticString()
		{
			return ToJson(Seconds, Nanos, diagnosticOnly: true);
		}
	}
	public static class TypeReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static TypeReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chpnb29nbGUvcHJvdG9idWYvdHlwZS5wcm90bxIPZ29vZ2xlLnByb3RvYnVm" + "Ghlnb29nbGUvcHJvdG9idWYvYW55LnByb3RvGiRnb29nbGUvcHJvdG9idWYv" + "c291cmNlX2NvbnRleHQucHJvdG8i1wEKBFR5cGUSDAoEbmFtZRgBIAEoCRIm" + "CgZmaWVsZHMYAiADKAsyFi5nb29nbGUucHJvdG9idWYuRmllbGQSDgoGb25l" + "b2ZzGAMgAygJEigKB29wdGlvbnMYBCADKAsyFy5nb29nbGUucHJvdG9idWYu" + "T3B0aW9uEjYKDnNvdXJjZV9jb250ZXh0GAUgASgLMh4uZ29vZ2xlLnByb3Rv" + "YnVmLlNvdXJjZUNvbnRleHQSJwoGc3ludGF4GAYgASgOMhcuZ29vZ2xlLnBy" + "b3RvYnVmLlN5bnRheCLVBQoFRmllbGQSKQoEa2luZBgBIAEoDjIbLmdvb2ds" + "ZS5wcm90b2J1Zi5GaWVsZC5LaW5kEjcKC2NhcmRpbmFsaXR5GAIgASgOMiIu" + "Z29vZ2xlLnByb3RvYnVmLkZpZWxkLkNhcmRpbmFsaXR5Eg4KBm51bWJlchgD" + "IAEoBRIMCgRuYW1lGAQgASgJEhAKCHR5cGVfdXJsGAYgASgJEhMKC29uZW9m" + "X2luZGV4GAcgASgFEg4KBnBhY2tlZBgIIAEoCBIoCgdvcHRpb25zGAkgAygL" + "MhcuZ29vZ2xlLnByb3RvYnVmLk9wdGlvbhIRCglqc29uX25hbWUYCiABKAkS" + "FQoNZGVmYXVsdF92YWx1ZRgLIAEoCSLIAgoES2luZBIQCgxUWVBFX1VOS05P" + "V04QABIPCgtUWVBFX0RPVUJMRRABEg4KClRZUEVfRkxPQVQQAhIOCgpUWVBF" + "X0lOVDY0EAMSDwoLVFlQRV9VSU5UNjQQBBIOCgpUWVBFX0lOVDMyEAUSEAoM" + "VFlQRV9GSVhFRDY0EAYSEAoMVFlQRV9GSVhFRDMyEAcSDQoJVFlQRV9CT09M" + "EAgSDwoLVFlQRV9TVFJJTkcQCRIOCgpUWVBFX0dST1VQEAoSEAoMVFlQRV9N" + "RVNTQUdFEAsSDgoKVFlQRV9CWVRFUxAMEg8KC1RZUEVfVUlOVDMyEA0SDQoJ" + "VFlQRV9FTlVNEA4SEQoNVFlQRV9TRklYRUQzMhAPEhEKDVRZUEVfU0ZJWEVE" + "NjQQEBIPCgtUWVBFX1NJTlQzMhAREg8KC1RZUEVfU0lOVDY0EBIidAoLQ2Fy" + "ZGluYWxpdHkSFwoTQ0FSRElOQUxJVFlfVU5LTk9XThAAEhgKFENBUkRJTkFM" + "SVRZX09QVElPTkFMEAESGAoUQ0FSRElOQUxJVFlfUkVRVUlSRUQQAhIYChRD" + "QVJESU5BTElUWV9SRVBFQVRFRBADIs4BCgRFbnVtEgwKBG5hbWUYASABKAkS" + "LQoJZW51bXZhbHVlGAIgAygLMhouZ29vZ2xlLnByb3RvYnVmLkVudW1WYWx1" + "ZRIoCgdvcHRpb25zGAMgAygLMhcuZ29vZ2xlLnByb3RvYnVmLk9wdGlvbhI2" + "Cg5zb3VyY2VfY29udGV4dBgEIAEoCzIeLmdvb2dsZS5wcm90b2J1Zi5Tb3Vy" + "Y2VDb250ZXh0EicKBnN5bnRheBgFIAEoDjIXLmdvb2dsZS5wcm90b2J1Zi5T" + "eW50YXgiUwoJRW51bVZhbHVlEgwKBG5hbWUYASABKAkSDgoGbnVtYmVyGAIg" + "ASgFEigKB29wdGlvbnMYAyADKAsyFy5nb29nbGUucHJvdG9idWYuT3B0aW9u" + "IjsKBk9wdGlvbhIMCgRuYW1lGAEgASgJEiMKBXZhbHVlGAIgASgLMhQuZ29v" + "Z2xlLnByb3RvYnVmLkFueSouCgZTeW50YXgSEQoNU1lOVEFYX1BST1RPMhAA" + "EhEKDVNZTlRBWF9QUk9UTzMQAUJMChNjb20uZ29vZ2xlLnByb3RvYnVmQglU" + "eXBlUHJvdG9QAfgBAaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25v" + "d25UeXBlc2IGcHJvdG8z"), new FileDescriptor[2]
			{
				AnyReflection.Descriptor,
				SourceContextReflection.Descriptor
			}, new GeneratedClrTypeInfo(new System.Type[1] { typeof(Syntax) }, new GeneratedClrTypeInfo[5]
			{
				new GeneratedClrTypeInfo(typeof(Type), Type.Parser, new string[6] { "Name", "Fields", "Oneofs", "Options", "SourceContext", "Syntax" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(Field), Field.Parser, new string[10] { "Kind", "Cardinality", "Number", "Name", "TypeUrl", "OneofIndex", "Packed", "Options", "JsonName", "DefaultValue" }, null, new System.Type[2]
				{
					typeof(Field.Types.Kind),
					typeof(Field.Types.Cardinality)
				}, null),
				new GeneratedClrTypeInfo(typeof(Enum), Enum.Parser, new string[5] { "Name", "Enumvalue", "Options", "SourceContext", "Syntax" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(EnumValue), EnumValue.Parser, new string[3] { "Name", "Number", "Options" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(Option), Option.Parser, new string[2] { "Name", "Value" }, null, null, null)
			}));
		}
	}
	public enum Syntax
	{
		[OriginalName("SYNTAX_PROTO2")]
		Proto2,
		[OriginalName("SYNTAX_PROTO3")]
		Proto3
	}
	public sealed class Type : IMessage<Type>, IMessage, IEquatable<Type>, IDeepCloneable<Type>
	{
		private static readonly MessageParser<Type> _parser = new MessageParser<Type>(() => new Type());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int FieldsFieldNumber = 2;

		private static readonly FieldCodec<Field> _repeated_fields_codec = FieldCodec.ForMessage(18u, Field.Parser);

		private readonly RepeatedField<Field> fields_ = new RepeatedField<Field>();

		public const int OneofsFieldNumber = 3;

		private static readonly FieldCodec<string> _repeated_oneofs_codec = FieldCodec.ForString(26u);

		private readonly RepeatedField<string> oneofs_ = new RepeatedField<string>();

		public const int OptionsFieldNumber = 4;

		private static readonly FieldCodec<Option> _repeated_options_codec = FieldCodec.ForMessage(34u, Option.Parser);

		private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

		public const int SourceContextFieldNumber = 5;

		private SourceContext sourceContext_;

		public const int SyntaxFieldNumber = 6;

		private Syntax syntax_;

		[DebuggerNonUserCode]
		public static MessageParser<Type> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => TypeReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<Field> Fields => fields_;

		[DebuggerNonUserCode]
		public RepeatedField<string> Oneofs => oneofs_;

		[DebuggerNonUserCode]
		public RepeatedField<Option> Options => options_;

		[DebuggerNonUserCode]
		public SourceContext SourceContext
		{
			get
			{
				return sourceContext_;
			}
			set
			{
				sourceContext_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Syntax Syntax
		{
			get
			{
				return syntax_;
			}
			set
			{
				syntax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Type()
		{
		}

		[DebuggerNonUserCode]
		public Type(Type other)
			: this()
		{
			name_ = other.name_;
			fields_ = other.fields_.Clone();
			oneofs_ = other.oneofs_.Clone();
			options_ = other.options_.Clone();
			SourceContext = ((other.sourceContext_ != null) ? other.SourceContext.Clone() : null);
			syntax_ = other.syntax_;
		}

		[DebuggerNonUserCode]
		public Type Clone()
		{
			return new Type(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Type);
		}

		[DebuggerNonUserCode]
		public bool Equals(Type other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (!fields_.Equals(other.fields_))
			{
				return false;
			}
			if (!oneofs_.Equals(other.oneofs_))
			{
				return false;
			}
			if (!options_.Equals(other.options_))
			{
				return false;
			}
			if (!object.Equals(SourceContext, other.SourceContext))
			{
				return false;
			}
			if (Syntax != other.Syntax)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			num ^= fields_.GetHashCode();
			num ^= oneofs_.GetHashCode();
			num ^= options_.GetHashCode();
			if (sourceContext_ != null)
			{
				num ^= SourceContext.GetHashCode();
			}
			if (Syntax != Syntax.Proto2)
			{
				num ^= Syntax.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			fields_.WriteTo(output, _repeated_fields_codec);
			oneofs_.WriteTo(output, _repeated_oneofs_codec);
			options_.WriteTo(output, _repeated_options_codec);
			if (sourceContext_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(SourceContext);
			}
			if (Syntax != Syntax.Proto2)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)Syntax);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			num += fields_.CalculateSize(_repeated_fields_codec);
			num += oneofs_.CalculateSize(_repeated_oneofs_codec);
			num += options_.CalculateSize(_repeated_options_codec);
			if (sourceContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(SourceContext);
			}
			if (Syntax != Syntax.Proto2)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)Syntax);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Type other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			fields_.Add(other.fields_);
			oneofs_.Add(other.oneofs_);
			options_.Add(other.options_);
			if (other.sourceContext_ != null)
			{
				if (sourceContext_ == null)
				{
					sourceContext_ = new SourceContext();
				}
				SourceContext.MergeFrom(other.SourceContext);
			}
			if (other.Syntax != Syntax.Proto2)
			{
				Syntax = other.Syntax;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					fields_.AddEntriesFrom(input, _repeated_fields_codec);
					break;
				case 26u:
					oneofs_.AddEntriesFrom(input, _repeated_oneofs_codec);
					break;
				case 34u:
					options_.AddEntriesFrom(input, _repeated_options_codec);
					break;
				case 42u:
					if (sourceContext_ == null)
					{
						sourceContext_ = new SourceContext();
					}
					input.ReadMessage(sourceContext_);
					break;
				case 48u:
					syntax_ = (Syntax)input.ReadEnum();
					break;
				}
			}
		}
	}
	public sealed class Field : IMessage<Field>, IMessage, IEquatable<Field>, IDeepCloneable<Field>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum Kind
			{
				[OriginalName("TYPE_UNKNOWN")]
				TypeUnknown,
				[OriginalName("TYPE_DOUBLE")]
				TypeDouble,
				[OriginalName("TYPE_FLOAT")]
				TypeFloat,
				[OriginalName("TYPE_INT64")]
				TypeInt64,
				[OriginalName("TYPE_UINT64")]
				TypeUint64,
				[OriginalName("TYPE_INT32")]
				TypeInt32,
				[OriginalName("TYPE_FIXED64")]
				TypeFixed64,
				[OriginalName("TYPE_FIXED32")]
				TypeFixed32,
				[OriginalName("TYPE_BOOL")]
				TypeBool,
				[OriginalName("TYPE_STRING")]
				TypeString,
				[OriginalName("TYPE_GROUP")]
				TypeGroup,
				[OriginalName("TYPE_MESSAGE")]
				TypeMessage,
				[OriginalName("TYPE_BYTES")]
				TypeBytes,
				[OriginalName("TYPE_UINT32")]
				TypeUint32,
				[OriginalName("TYPE_ENUM")]
				TypeEnum,
				[OriginalName("TYPE_SFIXED32")]
				TypeSfixed32,
				[OriginalName("TYPE_SFIXED64")]
				TypeSfixed64,
				[OriginalName("TYPE_SINT32")]
				TypeSint32,
				[OriginalName("TYPE_SINT64")]
				TypeSint64
			}

			public enum Cardinality
			{
				[OriginalName("CARDINALITY_UNKNOWN")]
				Unknown,
				[OriginalName("CARDINALITY_OPTIONAL")]
				Optional,
				[OriginalName("CARDINALITY_REQUIRED")]
				Required,
				[OriginalName("CARDINALITY_REPEATED")]
				Repeated
			}
		}

		private static readonly MessageParser<Field> _parser = new MessageParser<Field>(() => new Field());

		public const int KindFieldNumber = 1;

		private Types.Kind kind_;

		public const int CardinalityFieldNumber = 2;

		private Types.Cardinality cardinality_;

		public const int NumberFieldNumber = 3;

		private int number_;

		public const int NameFieldNumber = 4;

		private string name_ = "";

		public const int TypeUrlFieldNumber = 6;

		private string typeUrl_ = "";

		public const int OneofIndexFieldNumber = 7;

		private int oneofIndex_;

		public const int PackedFieldNumber = 8;

		private bool packed_;

		public const int OptionsFieldNumber = 9;

		private static readonly FieldCodec<Option> _repeated_options_codec = FieldCodec.ForMessage(74u, Option.Parser);

		private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

		public const int JsonNameFieldNumber = 10;

		private string jsonName_ = "";

		public const int DefaultValueFieldNumber = 11;

		private string defaultValue_ = "";

		[DebuggerNonUserCode]
		public static MessageParser<Field> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => TypeReflection.Descriptor.MessageTypes[1];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public Types.Kind Kind
		{
			get
			{
				return kind_;
			}
			set
			{
				kind_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Types.Cardinality Cardinality
		{
			get
			{
				return cardinality_;
			}
			set
			{
				cardinality_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Number
		{
			get
			{
				return number_;
			}
			set
			{
				number_ = value;
			}
		}

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public string TypeUrl
		{
			get
			{
				return typeUrl_;
			}
			set
			{
				typeUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int OneofIndex
		{
			get
			{
				return oneofIndex_;
			}
			set
			{
				oneofIndex_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool Packed
		{
			get
			{
				return packed_;
			}
			set
			{
				packed_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<Option> Options => options_;

		[DebuggerNonUserCode]
		public string JsonName
		{
			get
			{
				return jsonName_;
			}
			set
			{
				jsonName_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public string DefaultValue
		{
			get
			{
				return defaultValue_;
			}
			set
			{
				defaultValue_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public Field()
		{
		}

		[DebuggerNonUserCode]
		public Field(Field other)
			: this()
		{
			kind_ = other.kind_;
			cardinality_ = other.cardinality_;
			number_ = other.number_;
			name_ = other.name_;
			typeUrl_ = other.typeUrl_;
			oneofIndex_ = other.oneofIndex_;
			packed_ = other.packed_;
			options_ = other.options_.Clone();
			jsonName_ = other.jsonName_;
			defaultValue_ = other.defaultValue_;
		}

		[DebuggerNonUserCode]
		public Field Clone()
		{
			return new Field(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Field);
		}

		[DebuggerNonUserCode]
		public bool Equals(Field other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Kind != other.Kind)
			{
				return false;
			}
			if (Cardinality != other.Cardinality)
			{
				return false;
			}
			if (Number != other.Number)
			{
				return false;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (TypeUrl != other.TypeUrl)
			{
				return false;
			}
			if (OneofIndex != other.OneofIndex)
			{
				return false;
			}
			if (Packed != other.Packed)
			{
				return false;
			}
			if (!options_.Equals(other.options_))
			{
				return false;
			}
			if (JsonName != other.JsonName)
			{
				return false;
			}
			if (DefaultValue != other.DefaultValue)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Kind != Types.Kind.TypeUnknown)
			{
				num ^= Kind.GetHashCode();
			}
			if (Cardinality != Types.Cardinality.Unknown)
			{
				num ^= Cardinality.GetHashCode();
			}
			if (Number != 0)
			{
				num ^= Number.GetHashCode();
			}
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			if (TypeUrl.Length != 0)
			{
				num ^= TypeUrl.GetHashCode();
			}
			if (OneofIndex != 0)
			{
				num ^= OneofIndex.GetHashCode();
			}
			if (Packed)
			{
				num ^= Packed.GetHashCode();
			}
			num ^= options_.GetHashCode();
			if (JsonName.Length != 0)
			{
				num ^= JsonName.GetHashCode();
			}
			if (DefaultValue.Length != 0)
			{
				num ^= DefaultValue.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Kind != Types.Kind.TypeUnknown)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)Kind);
			}
			if (Cardinality != Types.Cardinality.Unknown)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)Cardinality);
			}
			if (Number != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(Number);
			}
			if (Name.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(Name);
			}
			if (TypeUrl.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(TypeUrl);
			}
			if (OneofIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(OneofIndex);
			}
			if (Packed)
			{
				output.WriteRawTag(64);
				output.WriteBool(Packed);
			}
			options_.WriteTo(output, _repeated_options_codec);
			if (JsonName.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(JsonName);
			}
			if (DefaultValue.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(DefaultValue);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Kind != Types.Kind.TypeUnknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)Kind);
			}
			if (Cardinality != Types.Cardinality.Unknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)Cardinality);
			}
			if (Number != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(Number);
			}
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			if (TypeUrl.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(TypeUrl);
			}
			if (OneofIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(OneofIndex);
			}
			if (Packed)
			{
				num += 2;
			}
			num += options_.CalculateSize(_repeated_options_codec);
			if (JsonName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(JsonName);
			}
			if (DefaultValue.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(DefaultValue);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Field other)
		{
			if (other != null)
			{
				if (other.Kind != Types.Kind.TypeUnknown)
				{
					Kind = other.Kind;
				}
				if (other.Cardinality != Types.Cardinality.Unknown)
				{
					Cardinality = other.Cardinality;
				}
				if (other.Number != 0)
				{
					Number = other.Number;
				}
				if (other.Name.Length != 0)
				{
					Name = other.Name;
				}
				if (other.TypeUrl.Length != 0)
				{
					TypeUrl = other.TypeUrl;
				}
				if (other.OneofIndex != 0)
				{
					OneofIndex = other.OneofIndex;
				}
				if (other.Packed)
				{
					Packed = other.Packed;
				}
				options_.Add(other.options_);
				if (other.JsonName.Length != 0)
				{
					JsonName = other.JsonName;
				}
				if (other.DefaultValue.Length != 0)
				{
					DefaultValue = other.DefaultValue;
				}
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 8u:
					kind_ = (Types.Kind)input.ReadEnum();
					break;
				case 16u:
					cardinality_ = (Types.Cardinality)input.ReadEnum();
					break;
				case 24u:
					Number = input.ReadInt32();
					break;
				case 34u:
					Name = input.ReadString();
					break;
				case 50u:
					TypeUrl = input.ReadString();
					break;
				case 56u:
					OneofIndex = input.ReadInt32();
					break;
				case 64u:
					Packed = input.ReadBool();
					break;
				case 74u:
					options_.AddEntriesFrom(input, _repeated_options_codec);
					break;
				case 82u:
					JsonName = input.ReadString();
					break;
				case 90u:
					DefaultValue = input.ReadString();
					break;
				}
			}
		}
	}
	public sealed class Enum : IMessage<Enum>, IMessage, IEquatable<Enum>, IDeepCloneable<Enum>
	{
		private static readonly MessageParser<Enum> _parser = new MessageParser<Enum>(() => new Enum());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int EnumvalueFieldNumber = 2;

		private static readonly FieldCodec<EnumValue> _repeated_enumvalue_codec = FieldCodec.ForMessage(18u, EnumValue.Parser);

		private readonly RepeatedField<EnumValue> enumvalue_ = new RepeatedField<EnumValue>();

		public const int OptionsFieldNumber = 3;

		private static readonly FieldCodec<Option> _repeated_options_codec = FieldCodec.ForMessage(26u, Option.Parser);

		private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

		public const int SourceContextFieldNumber = 4;

		private SourceContext sourceContext_;

		public const int SyntaxFieldNumber = 5;

		private Syntax syntax_;

		[DebuggerNonUserCode]
		public static MessageParser<Enum> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => TypeReflection.Descriptor.MessageTypes[2];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<EnumValue> Enumvalue => enumvalue_;

		[DebuggerNonUserCode]
		public RepeatedField<Option> Options => options_;

		[DebuggerNonUserCode]
		public SourceContext SourceContext
		{
			get
			{
				return sourceContext_;
			}
			set
			{
				sourceContext_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Syntax Syntax
		{
			get
			{
				return syntax_;
			}
			set
			{
				syntax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Enum()
		{
		}

		[DebuggerNonUserCode]
		public Enum(Enum other)
			: this()
		{
			name_ = other.name_;
			enumvalue_ = other.enumvalue_.Clone();
			options_ = other.options_.Clone();
			SourceContext = ((other.sourceContext_ != null) ? other.SourceContext.Clone() : null);
			syntax_ = other.syntax_;
		}

		[DebuggerNonUserCode]
		public Enum Clone()
		{
			return new Enum(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Enum);
		}

		[DebuggerNonUserCode]
		public bool Equals(Enum other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (!enumvalue_.Equals(other.enumvalue_))
			{
				return false;
			}
			if (!options_.Equals(other.options_))
			{
				return false;
			}
			if (!object.Equals(SourceContext, other.SourceContext))
			{
				return false;
			}
			if (Syntax != other.Syntax)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			num ^= enumvalue_.GetHashCode();
			num ^= options_.GetHashCode();
			if (sourceContext_ != null)
			{
				num ^= SourceContext.GetHashCode();
			}
			if (Syntax != Syntax.Proto2)
			{
				num ^= Syntax.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			enumvalue_.WriteTo(output, _repeated_enumvalue_codec);
			options_.WriteTo(output, _repeated_options_codec);
			if (sourceContext_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(SourceContext);
			}
			if (Syntax != Syntax.Proto2)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)Syntax);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			num += enumvalue_.CalculateSize(_repeated_enumvalue_codec);
			num += options_.CalculateSize(_repeated_options_codec);
			if (sourceContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(SourceContext);
			}
			if (Syntax != Syntax.Proto2)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)Syntax);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Enum other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			enumvalue_.Add(other.enumvalue_);
			options_.Add(other.options_);
			if (other.sourceContext_ != null)
			{
				if (sourceContext_ == null)
				{
					sourceContext_ = new SourceContext();
				}
				SourceContext.MergeFrom(other.SourceContext);
			}
			if (other.Syntax != Syntax.Proto2)
			{
				Syntax = other.Syntax;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					enumvalue_.AddEntriesFrom(input, _repeated_enumvalue_codec);
					break;
				case 26u:
					options_.AddEntriesFrom(input, _repeated_options_codec);
					break;
				case 34u:
					if (sourceContext_ == null)
					{
						sourceContext_ = new SourceContext();
					}
					input.ReadMessage(sourceContext_);
					break;
				case 40u:
					syntax_ = (Syntax)input.ReadEnum();
					break;
				}
			}
		}
	}
	public sealed class EnumValue : IMessage<EnumValue>, IMessage, IEquatable<EnumValue>, IDeepCloneable<EnumValue>
	{
		private static readonly MessageParser<EnumValue> _parser = new MessageParser<EnumValue>(() => new EnumValue());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int NumberFieldNumber = 2;

		private int number_;

		public const int OptionsFieldNumber = 3;

		private static readonly FieldCodec<Option> _repeated_options_codec = FieldCodec.ForMessage(26u, Option.Parser);

		private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

		[DebuggerNonUserCode]
		public static MessageParser<EnumValue> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => TypeReflection.Descriptor.MessageTypes[3];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int Number
		{
			get
			{
				return number_;
			}
			set
			{
				number_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<Option> Options => options_;

		[DebuggerNonUserCode]
		public EnumValue()
		{
		}

		[DebuggerNonUserCode]
		public EnumValue(EnumValue other)
			: this()
		{
			name_ = other.name_;
			number_ = other.number_;
			options_ = other.options_.Clone();
		}

		[DebuggerNonUserCode]
		public EnumValue Clone()
		{
			return new EnumValue(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as EnumValue);
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumValue other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (Number != other.Number)
			{
				return false;
			}
			if (!options_.Equals(other.options_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			if (Number != 0)
			{
				num ^= Number.GetHashCode();
			}
			return num ^ options_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			if (Number != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(Number);
			}
			options_.WriteTo(output, _repeated_options_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			if (Number != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(Number);
			}
			return num + options_.CalculateSize(_repeated_options_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(EnumValue other)
		{
			if (other != null)
			{
				if (other.Name.Length != 0)
				{
					Name = other.Name;
				}
				if (other.Number != 0)
				{
					Number = other.Number;
				}
				options_.Add(other.options_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 16u:
					Number = input.ReadInt32();
					break;
				case 26u:
					options_.AddEntriesFrom(input, _repeated_options_codec);
					break;
				}
			}
		}
	}
	public sealed class Option : IMessage<Option>, IMessage, IEquatable<Option>, IDeepCloneable<Option>
	{
		private static readonly MessageParser<Option> _parser = new MessageParser<Option>(() => new Option());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int ValueFieldNumber = 2;

		private Any value_;

		[DebuggerNonUserCode]
		public static MessageParser<Option> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => TypeReflection.Descriptor.MessageTypes[4];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public Any Value
		{
			get
			{
				return value_;
			}
			set
			{
				value_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Option()
		{
		}

		[DebuggerNonUserCode]
		public Option(Option other)
			: this()
		{
			name_ = other.name_;
			Value = ((other.value_ != null) ? other.Value.Clone() : null);
		}

		[DebuggerNonUserCode]
		public Option Clone()
		{
			return new Option(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Option);
		}

		[DebuggerNonUserCode]
		public bool Equals(Option other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (!object.Equals(Value, other.Value))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			if (value_ != null)
			{
				num ^= Value.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			if (value_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(Value);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			if (value_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(Value);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Option other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.value_ != null)
			{
				if (value_ == null)
				{
					value_ = new Any();
				}
				Value.MergeFrom(other.Value);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					if (value_ == null)
					{
						value_ = new Any();
					}
					input.ReadMessage(value_);
					break;
				}
			}
		}
	}
	public static class WrappersReflection
	{
		private static FileDescriptor descriptor;

		internal const int WrapperValueFieldNumber = 1;

		public static FileDescriptor Descriptor => descriptor;

		static WrappersReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8SD2dvb2dsZS5wcm90" + "b2J1ZiIcCgtEb3VibGVWYWx1ZRINCgV2YWx1ZRgBIAEoASIbCgpGbG9hdFZh" + "bHVlEg0KBXZhbHVlGAEgASgCIhsKCkludDY0VmFsdWUSDQoFdmFsdWUYASAB" + "KAMiHAoLVUludDY0VmFsdWUSDQoFdmFsdWUYASABKAQiGwoKSW50MzJWYWx1" + "ZRINCgV2YWx1ZRgBIAEoBSIcCgtVSW50MzJWYWx1ZRINCgV2YWx1ZRgBIAEo" + "DSIaCglCb29sVmFsdWUSDQoFdmFsdWUYASABKAgiHAoLU3RyaW5nVmFsdWUS" + "DQoFdmFsdWUYASABKAkiGwoKQnl0ZXNWYWx1ZRINCgV2YWx1ZRgBIAEoDEJ8" + "ChNjb20uZ29vZ2xlLnByb3RvYnVmQg1XcmFwcGVyc1Byb3RvUAFaKmdpdGh1" + "Yi5jb20vZ29sYW5nL3Byb3RvYnVmL3B0eXBlcy93cmFwcGVyc/gBAaICA0dQ" + "QqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[9]
			{
				new GeneratedClrTypeInfo(typeof(DoubleValue), DoubleValue.Parser, new string[1] { "Value" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(FloatValue), FloatValue.Parser, new string[1] { "Value" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(Int64Value), Int64Value.Parser, new string[1] { "Value" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(UInt64Value), UInt64Value.Parser, new string[1] { "Value" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(Int32Value), Int32Value.Parser, new string[1] { "Value" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(UInt32Value), UInt32Value.Parser, new string[1] { "Value" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(BoolValue), BoolValue.Parser, new string[1] { "Value" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(StringValue), StringValue.Parser, new string[1] { "Value" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(BytesValue), BytesValue.Parser, new string[1] { "Value" }, null, null, null)
			}));
		}
	}
	public sealed class DoubleValue : IMessage<DoubleValue>, IMessage, IEquatable<DoubleValue>, IDeepCloneable<DoubleValue>
	{
		private static readonly MessageParser<DoubleValue> _parser = new MessageParser<DoubleValue>(() => new DoubleValue());

		public const int ValueFieldNumber = 1;

		private double value_;

		[DebuggerNonUserCode]
		public static MessageParser<DoubleValue> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => WrappersReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public double Value
		{
			get
			{
				return value_;
			}
			set
			{
				value_ = value;
			}
		}

		[DebuggerNonUserCode]
		public DoubleValue()
		{
		}

		[DebuggerNonUserCode]
		public DoubleValue(DoubleValue other)
			: this()
		{
			value_ = other.value_;
		}

		[DebuggerNonUserCode]
		public DoubleValue Clone()
		{
			return new DoubleValue(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as DoubleValue);
		}

		[DebuggerNonUserCode]
		public bool Equals(DoubleValue other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Value != other.Value)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Value != 0.0)
			{
				num ^= Value.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Value != 0.0)
			{
				output.WriteRawTag(9);
				output.WriteDouble(Value);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Value != 0.0)
			{
				num += 9;
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(DoubleValue other)
		{
			if (other != null && other.Value != 0.0)
			{
				Value = other.Value;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 9)
				{
					input.SkipLastField();
				}
				else
				{
					Value = input.ReadDouble();
				}
			}
		}
	}
	public sealed class FloatValue : IMessage<FloatValue>, IMessage, IEquatable<FloatValue>, IDeepCloneable<FloatValue>
	{
		private static readonly MessageParser<FloatValue> _parser = new MessageParser<FloatValue>(() => new FloatValue());

		public const int ValueFieldNumber = 1;

		private float value_;

		[DebuggerNonUserCode]
		public static MessageParser<FloatValue> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => WrappersReflection.Descriptor.MessageTypes[1];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public float Value
		{
			get
			{
				return value_;
			}
			set
			{
				value_ = value;
			}
		}

		[DebuggerNonUserCode]
		public FloatValue()
		{
		}

		[DebuggerNonUserCode]
		public FloatValue(FloatValue other)
			: this()
		{
			value_ = other.value_;
		}

		[DebuggerNonUserCode]
		public FloatValue Clone()
		{
			return new FloatValue(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as FloatValue);
		}

		[DebuggerNonUserCode]
		public bool Equals(FloatValue other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Value != other.Value)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Value != 0f)
			{
				num ^= Value.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Value != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(Value);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Value != 0f)
			{
				num += 5;
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(FloatValue other)
		{
			if (other != null && other.Value != 0f)
			{
				Value = other.Value;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 13)
				{
					input.SkipLastField();
				}
				else
				{
					Value = input.ReadFloat();
				}
			}
		}
	}
	public sealed class Int64Value : IMessage<Int64Value>, IMessage, IEquatable<Int64Value>, IDeepCloneable<Int64Value>
	{
		private static readonly MessageParser<Int64Value> _parser = new MessageParser<Int64Value>(() => new Int64Value());

		public const int ValueFieldNumber = 1;

		private long value_;

		[DebuggerNonUserCode]
		public static MessageParser<Int64Value> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => WrappersReflection.Descriptor.MessageTypes[2];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public long Value
		{
			get
			{
				return value_;
			}
			set
			{
				value_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Int64Value()
		{
		}

		[DebuggerNonUserCode]
		public Int64Value(Int64Value other)
			: this()
		{
			value_ = other.value_;
		}

		[DebuggerNonUserCode]
		public Int64Value Clone()
		{
			return new Int64Value(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Int64Value);
		}

		[DebuggerNonUserCode]
		public bool Equals(Int64Value other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Value != other.Value)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Value != 0L)
			{
				num ^= Value.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Value != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(Value);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Value != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(Value);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Int64Value other)
		{
			if (other != null && other.Value != 0L)
			{
				Value = other.Value;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 8)
				{
					input.SkipLastField();
				}
				else
				{
					Value = input.ReadInt64();
				}
			}
		}
	}
	public sealed class UInt64Value : IMessage<UInt64Value>, IMessage, IEquatable<UInt64Value>, IDeepCloneable<UInt64Value>
	{
		private static readonly MessageParser<UInt64Value> _parser = new MessageParser<UInt64Value>(() => new UInt64Value());

		public const int ValueFieldNumber = 1;

		private ulong value_;

		[DebuggerNonUserCode]
		public static MessageParser<UInt64Value> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => WrappersReflection.Descriptor.MessageTypes[3];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public ulong Value
		{
			get
			{
				return value_;
			}
			set
			{
				value_ = value;
			}
		}

		[DebuggerNonUserCode]
		public UInt64Value()
		{
		}

		[DebuggerNonUserCode]
		public UInt64Value(UInt64Value other)
			: this()
		{
			value_ = other.value_;
		}

		[DebuggerNonUserCode]
		public UInt64Value Clone()
		{
			return new UInt64Value(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as UInt64Value);
		}

		[DebuggerNonUserCode]
		public bool Equals(UInt64Value other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Value != other.Value)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Value != 0L)
			{
				num ^= Value.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Value != 0L)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(Value);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Value != 0L)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(Value);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(UInt64Value other)
		{
			if (other != null && other.Value != 0L)
			{
				Value = other.Value;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 8)
				{
					input.SkipLastField();
				}
				else
				{
					Value = input.ReadUInt64();
				}
			}
		}
	}
	public sealed class Int32Value : IMessage<Int32Value>, IMessage, IEquatable<Int32Value>, IDeepCloneable<Int32Value>
	{
		private static readonly MessageParser<Int32Value> _parser = new MessageParser<Int32Value>(() => new Int32Value());

		public const int ValueFieldNumber = 1;

		private int value_;

		[DebuggerNonUserCode]
		public static MessageParser<Int32Value> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => WrappersReflection.Descriptor.MessageTypes[4];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public int Value
		{
			get
			{
				return value_;
			}
			set
			{
				value_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Int32Value()
		{
		}

		[DebuggerNonUserCode]
		public Int32Value(Int32Value other)
			: this()
		{
			value_ = other.value_;
		}

		[DebuggerNonUserCode]
		public Int32Value Clone()
		{
			return new Int32Value(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as Int32Value);
		}

		[DebuggerNonUserCode]
		public bool Equals(Int32Value other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Value != other.Value)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Value != 0)
			{
				num ^= Value.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Value != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(Value);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(Value);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Int32Value other)
		{
			if (other != null && other.Value != 0)
			{
				Value = other.Value;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 8)
				{
					input.SkipLastField();
				}
				else
				{
					Value = input.ReadInt32();
				}
			}
		}
	}
	public sealed class UInt32Value : IMessage<UInt32Value>, IMessage, IEquatable<UInt32Value>, IDeepCloneable<UInt32Value>
	{
		private static readonly MessageParser<UInt32Value> _parser = new MessageParser<UInt32Value>(() => new UInt32Value());

		public const int ValueFieldNumber = 1;

		private uint value_;

		[DebuggerNonUserCode]
		public static MessageParser<UInt32Value> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => WrappersReflection.Descriptor.MessageTypes[5];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public uint Value
		{
			get
			{
				return value_;
			}
			set
			{
				value_ = value;
			}
		}

		[DebuggerNonUserCode]
		public UInt32Value()
		{
		}

		[DebuggerNonUserCode]
		public UInt32Value(UInt32Value other)
			: this()
		{
			value_ = other.value_;
		}

		[DebuggerNonUserCode]
		public UInt32Value Clone()
		{
			return new UInt32Value(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as UInt32Value);
		}

		[DebuggerNonUserCode]
		public bool Equals(UInt32Value other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Value != other.Value)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Value != 0)
			{
				num ^= Value.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Value != 0)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(Value);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(Value);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(UInt32Value other)
		{
			if (other != null && other.Value != 0)
			{
				Value = other.Value;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 8)
				{
					input.SkipLastField();
				}
				else
				{
					Value = input.ReadUInt32();
				}
			}
		}
	}
	public sealed class BoolValue : IMessage<BoolValue>, IMessage, IEquatable<BoolValue>, IDeepCloneable<BoolValue>
	{
		private static readonly MessageParser<BoolValue> _parser = new MessageParser<BoolValue>(() => new BoolValue());

		public const int ValueFieldNumber = 1;

		private bool value_;

		[DebuggerNonUserCode]
		public static MessageParser<BoolValue> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => WrappersReflection.Descriptor.MessageTypes[6];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public bool Value
		{
			get
			{
				return value_;
			}
			set
			{
				value_ = value;
			}
		}

		[DebuggerNonUserCode]
		public BoolValue()
		{
		}

		[DebuggerNonUserCode]
		public BoolValue(BoolValue other)
			: this()
		{
			value_ = other.value_;
		}

		[DebuggerNonUserCode]
		public BoolValue Clone()
		{
			return new BoolValue(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as BoolValue);
		}

		[DebuggerNonUserCode]
		public bool Equals(BoolValue other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Value != other.Value)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Value)
			{
				num ^= Value.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Value)
			{
				output.WriteRawTag(8);
				output.WriteBool(Value);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Value)
			{
				num += 2;
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(BoolValue other)
		{
			if (other != null && other.Value)
			{
				Value = other.Value;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 8)
				{
					input.SkipLastField();
				}
				else
				{
					Value = input.ReadBool();
				}
			}
		}
	}
	public sealed class StringValue : IMessage<StringValue>, IMessage, IEquatable<StringValue>, IDeepCloneable<StringValue>
	{
		private static readonly MessageParser<StringValue> _parser = new MessageParser<StringValue>(() => new StringValue());

		public const int ValueFieldNumber = 1;

		private string value_ = "";

		[DebuggerNonUserCode]
		public static MessageParser<StringValue> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => WrappersReflection.Descriptor.MessageTypes[7];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Value
		{
			get
			{
				return value_;
			}
			set
			{
				value_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public StringValue()
		{
		}

		[DebuggerNonUserCode]
		public StringValue(StringValue other)
			: this()
		{
			value_ = other.value_;
		}

		[DebuggerNonUserCode]
		public StringValue Clone()
		{
			return new StringValue(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as StringValue);
		}

		[DebuggerNonUserCode]
		public bool Equals(StringValue other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Value != other.Value)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Value.Length != 0)
			{
				num ^= Value.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Value.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Value);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Value.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Value);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(StringValue other)
		{
			if (other != null && other.Value.Length != 0)
			{
				Value = other.Value;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 10)
				{
					input.SkipLastField();
				}
				else
				{
					Value = input.ReadString();
				}
			}
		}
	}
	public sealed class BytesValue : IMessage<BytesValue>, IMessage, IEquatable<BytesValue>, IDeepCloneable<BytesValue>
	{
		private static readonly MessageParser<BytesValue> _parser = new MessageParser<BytesValue>(() => new BytesValue());

		public const int ValueFieldNumber = 1;

		private ByteString value_ = ByteString.Empty;

		[DebuggerNonUserCode]
		public static MessageParser<BytesValue> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => WrappersReflection.Descriptor.MessageTypes[8];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public ByteString Value
		{
			get
			{
				return value_;
			}
			set
			{
				value_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public BytesValue()
		{
		}

		[DebuggerNonUserCode]
		public BytesValue(BytesValue other)
			: this()
		{
			value_ = other.value_;
		}

		[DebuggerNonUserCode]
		public BytesValue Clone()
		{
			return new BytesValue(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as BytesValue);
		}

		[DebuggerNonUserCode]
		public bool Equals(BytesValue other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Value != other.Value)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Value.Length != 0)
			{
				num ^= Value.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Value.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteBytes(Value);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Value.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(Value);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(BytesValue other)
		{
			if (other != null && other.Value.Length != 0)
			{
				Value = other.Value;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 10)
				{
					input.SkipLastField();
				}
				else
				{
					Value = input.ReadBytes();
				}
			}
		}
	}
}
namespace Google.Protobuf.Reflection
{
	internal static class DescriptorReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => descriptor;

		static DescriptorReflection()
		{
			descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBnb29nbGUvcHJvdG9idWYvZGVzY3JpcHRvci5wcm90bxIPZ29vZ2xlLnBy" + "b3RvYnVmIkcKEUZpbGVEZXNjcmlwdG9yU2V0EjIKBGZpbGUYASADKAsyJC5n" + "b29nbGUucHJvdG9idWYuRmlsZURlc2NyaXB0b3JQcm90byLbAwoTRmlsZURl" + "c2NyaXB0b3JQcm90bxIMCgRuYW1lGAEgASgJEg8KB3BhY2thZ2UYAiABKAkS" + "EgoKZGVwZW5kZW5jeRgDIAMoCRIZChFwdWJsaWNfZGVwZW5kZW5jeRgKIAMo" + "BRIXCg93ZWFrX2RlcGVuZGVuY3kYCyADKAUSNgoMbWVzc2FnZV90eXBlGAQg" + "AygLMiAuZ29vZ2xlLnByb3RvYnVmLkRlc2NyaXB0b3JQcm90bxI3CgllbnVt" + "X3R5cGUYBSADKAsyJC5nb29nbGUucHJvdG9idWYuRW51bURlc2NyaXB0b3JQ" + "cm90bxI4CgdzZXJ2aWNlGAYgAygLMicuZ29vZ2xlLnByb3RvYnVmLlNlcnZp" + "Y2VEZXNjcmlwdG9yUHJvdG8SOAoJZXh0ZW5zaW9uGAcgAygLMiUuZ29vZ2xl" + "LnByb3RvYnVmLkZpZWxkRGVzY3JpcHRvclByb3RvEi0KB29wdGlvbnMYCCAB" + "KAsyHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMSOQoQc291cmNlX2Nv" + "ZGVfaW5mbxgJIAEoCzIfLmdvb2dsZS5wcm90b2J1Zi5Tb3VyY2VDb2RlSW5m" + "bxIOCgZzeW50YXgYDCABKAki8AQKD0Rlc2NyaXB0b3JQcm90bxIMCgRuYW1l" + "GAEgASgJEjQKBWZpZWxkGAIgAygLMiUuZ29vZ2xlLnByb3RvYnVmLkZpZWxk" + "RGVzY3JpcHRvclByb3RvEjgKCWV4dGVuc2lvbhgGIAMoCzIlLmdvb2dsZS5w" + "cm90b2J1Zi5GaWVsZERlc2NyaXB0b3JQcm90bxI1CgtuZXN0ZWRfdHlwZRgD" + "IAMoCzIgLmdvb2dsZS5wcm90b2J1Zi5EZXNjcmlwdG9yUHJvdG8SNwoJZW51" + "bV90eXBlGAQgAygLMiQuZ29vZ2xlLnByb3RvYnVmLkVudW1EZXNjcmlwdG9y" + "UHJvdG8SSAoPZXh0ZW5zaW9uX3JhbmdlGAUgAygLMi8uZ29vZ2xlLnByb3Rv" + "YnVmLkRlc2NyaXB0b3JQcm90by5FeHRlbnNpb25SYW5nZRI5CgpvbmVvZl9k" + "ZWNsGAggAygLMiUuZ29vZ2xlLnByb3RvYnVmLk9uZW9mRGVzY3JpcHRvclBy" + "b3RvEjAKB29wdGlvbnMYByABKAsyHy5nb29nbGUucHJvdG9idWYuTWVzc2Fn" + "ZU9wdGlvbnMSRgoOcmVzZXJ2ZWRfcmFuZ2UYCSADKAsyLi5nb29nbGUucHJv" + "dG9idWYuRGVzY3JpcHRvclByb3RvLlJlc2VydmVkUmFuZ2USFQoNcmVzZXJ2" + "ZWRfbmFtZRgKIAMoCRosCg5FeHRlbnNpb25SYW5nZRINCgVzdGFydBgBIAEo" + "BRILCgNlbmQYAiABKAUaKwoNUmVzZXJ2ZWRSYW5nZRINCgVzdGFydBgBIAEo" + "BRILCgNlbmQYAiABKAUivAUKFEZpZWxkRGVzY3JpcHRvclByb3RvEgwKBG5h" + "bWUYASABKAkSDgoGbnVtYmVyGAMgASgFEjoKBWxhYmVsGAQgASgOMisuZ29v" + "Z2xlLnByb3RvYnVmLkZpZWxkRGVzY3JpcHRvclByb3RvLkxhYmVsEjgKBHR5" + "cGUYBSABKA4yKi5nb29nbGUucHJvdG9idWYuRmllbGREZXNjcmlwdG9yUHJv" + "dG8uVHlwZRIRCgl0eXBlX25hbWUYBiABKAkSEAoIZXh0ZW5kZWUYAiABKAkS" + "FQoNZGVmYXVsdF92YWx1ZRgHIAEoCRITCgtvbmVvZl9pbmRleBgJIAEoBRIR" + "Cglqc29uX25hbWUYCiABKAkSLgoHb3B0aW9ucxgIIAEoCzIdLmdvb2dsZS5w" + "cm90b2J1Zi5GaWVsZE9wdGlvbnMitgIKBFR5cGUSDwoLVFlQRV9ET1VCTEUQ" + "ARIOCgpUWVBFX0ZMT0FUEAISDgoKVFlQRV9JTlQ2NBADEg8KC1RZUEVfVUlO" + "VDY0EAQSDgoKVFlQRV9JTlQzMhAFEhAKDFRZUEVfRklYRUQ2NBAGEhAKDFRZ" + "UEVfRklYRUQzMhAHEg0KCVRZUEVfQk9PTBAIEg8KC1RZUEVfU1RSSU5HEAkS" + "DgoKVFlQRV9HUk9VUBAKEhAKDFRZUEVfTUVTU0FHRRALEg4KClRZUEVfQllU" + "RVMQDBIPCgtUWVBFX1VJTlQzMhANEg0KCVRZUEVfRU5VTRAOEhEKDVRZUEVf" + "U0ZJWEVEMzIQDxIRCg1UWVBFX1NGSVhFRDY0EBASDwoLVFlQRV9TSU5UMzIQ" + "ERIPCgtUWVBFX1NJTlQ2NBASIkMKBUxhYmVsEhIKDkxBQkVMX09QVElPTkFM" + "EAESEgoOTEFCRUxfUkVRVUlSRUQQAhISCg5MQUJFTF9SRVBFQVRFRBADIlQK" + "FE9uZW9mRGVzY3JpcHRvclByb3RvEgwKBG5hbWUYASABKAkSLgoHb3B0aW9u" + "cxgCIAEoCzIdLmdvb2dsZS5wcm90b2J1Zi5PbmVvZk9wdGlvbnMijAEKE0Vu" + "dW1EZXNjcmlwdG9yUHJvdG8SDAoEbmFtZRgBIAEoCRI4CgV2YWx1ZRgCIAMo" + "CzIpLmdvb2dsZS5wcm90b2J1Zi5FbnVtVmFsdWVEZXNjcmlwdG9yUHJvdG8S" + "LQoHb3B0aW9ucxgDIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5FbnVtT3B0aW9u" + "cyJsChhFbnVtVmFsdWVEZXNjcmlwdG9yUHJvdG8SDAoEbmFtZRgBIAEoCRIO" + "CgZudW1iZXIYAiABKAUSMgoHb3B0aW9ucxgDIAEoCzIhLmdvb2dsZS5wcm90" + "b2J1Zi5FbnVtVmFsdWVPcHRpb25zIpABChZTZXJ2aWNlRGVzY3JpcHRvclBy" + "b3RvEgwKBG5hbWUYASABKAkSNgoGbWV0aG9kGAIgAygLMiYuZ29vZ2xlLnBy" + "b3RvYnVmLk1ldGhvZERlc2NyaXB0b3JQcm90bxIwCgdvcHRpb25zGAMgASgL" + "Mh8uZ29vZ2xlLnByb3RvYnVmLlNlcnZpY2VPcHRpb25zIsEBChVNZXRob2RE" + "ZXNjcmlwdG9yUHJvdG8SDAoEbmFtZRgBIAEoCRISCgppbnB1dF90eXBlGAIg" + "ASgJEhMKC291dHB1dF90eXBlGAMgASgJEi8KB29wdGlvbnMYBCABKAsyHi5n" + "b29nbGUucHJvdG9idWYuTWV0aG9kT3B0aW9ucxIfChBjbGllbnRfc3RyZWFt" + "aW5nGAUgASgIOgVmYWxzZRIfChBzZXJ2ZXJfc3RyZWFtaW5nGAYgASgIOgVm" + "YWxzZSKEBQoLRmlsZU9wdGlvbnMSFAoMamF2YV9wYWNrYWdlGAEgASgJEhwK" + "FGphdmFfb3V0ZXJfY2xhc3NuYW1lGAggASgJEiIKE2phdmFfbXVsdGlwbGVf" + "ZmlsZXMYCiABKAg6BWZhbHNlEikKHWphdmFfZ2VuZXJhdGVfZXF1YWxzX2Fu" + "ZF9oYXNoGBQgASgIQgIYARIlChZqYXZhX3N0cmluZ19jaGVja191dGY4GBsg" + "ASgIOgVmYWxzZRJGCgxvcHRpbWl6ZV9mb3IYCSABKA4yKS5nb29nbGUucHJv" + "dG9idWYuRmlsZU9wdGlvbnMuT3B0aW1pemVNb2RlOgVTUEVFRBISCgpnb19w" + "YWNrYWdlGAsgASgJEiIKE2NjX2dlbmVyaWNfc2VydmljZXMYECABKAg6BWZh" + "bHNlEiQKFWphdmFfZ2VuZXJpY19zZXJ2aWNlcxgRIAEoCDoFZmFsc2USIgoT" + "cHlfZ2VuZXJpY19zZXJ2aWNlcxgSIAEoCDoFZmFsc2USGQoKZGVwcmVjYXRl" + "ZBgXIAEoCDoFZmFsc2USHwoQY2NfZW5hYmxlX2FyZW5hcxgfIAEoCDoFZmFs" + "c2USGQoRb2JqY19jbGFzc19wcmVmaXgYJCABKAkSGAoQY3NoYXJwX25hbWVz" + "cGFjZRglIAEoCRJDChR1bmludGVycHJldGVkX29wdGlvbhjnByADKAsyJC5n" + "b29nbGUucHJvdG9idWYuVW5pbnRlcnByZXRlZE9wdGlvbiI6CgxPcHRpbWl6" + "ZU1vZGUSCQoFU1BFRUQQARINCglDT0RFX1NJWkUQAhIQCgxMSVRFX1JVTlRJ" + "TUUQAyoJCOgHEICAgIACSgQIJhAnIuwBCg5NZXNzYWdlT3B0aW9ucxImChdt" + "ZXNzYWdlX3NldF93aXJlX2Zvcm1hdBgBIAEoCDoFZmFsc2USLgofbm9fc3Rh" + "bmRhcmRfZGVzY3JpcHRvcl9hY2Nlc3NvchgCIAEoCDoFZmFsc2USGQoKZGVw" + "cmVjYXRlZBgDIAEoCDoFZmFsc2USEQoJbWFwX2VudHJ5GAcgASgIEkMKFHVu" + "aW50ZXJwcmV0ZWRfb3B0aW9uGOcHIAMoCzIkLmdvb2dsZS5wcm90b2J1Zi5V" + "bmludGVycHJldGVkT3B0aW9uKgkI6AcQgICAgAJKBAgIEAkingMKDEZpZWxk" + "T3B0aW9ucxI6CgVjdHlwZRgBIAEoDjIjLmdvb2dsZS5wcm90b2J1Zi5GaWVs" + "ZE9wdGlvbnMuQ1R5cGU6BlNUUklORxIOCgZwYWNrZWQYAiABKAgSPwoGanN0" + "eXBlGAYgASgOMiQuZ29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0aW9ucy5KU1R5" + "cGU6CUpTX05PUk1BTBITCgRsYXp5GAUgASgIOgVmYWxzZRIZCgpkZXByZWNh" + "dGVkGAMgASgIOgVmYWxzZRITCgR3ZWFrGAogASgIOgVmYWxzZRJDChR1bmlu" + "dGVycHJldGVkX29wdGlvbhjnByADKAsyJC5nb29nbGUucHJvdG9idWYuVW5p" + "bnRlcnByZXRlZE9wdGlvbiIvCgVDVHlwZRIKCgZTVFJJTkcQABIICgRDT1JE" + "EAESEAoMU1RSSU5HX1BJRUNFEAIiNQoGSlNUeXBlEg0KCUpTX05PUk1BTBAA" + "Eg0KCUpTX1NUUklORxABEg0KCUpTX05VTUJFUhACKgkI6AcQgICAgAJKBAgE" + "EAUiXgoMT25lb2ZPcHRpb25zEkMKFHVuaW50ZXJwcmV0ZWRfb3B0aW9uGOcH" + "IAMoCzIkLmdvb2dsZS5wcm90b2J1Zi5VbmludGVycHJldGVkT3B0aW9uKgkI" + "6AcQgICAgAIijQEKC0VudW1PcHRpb25zEhMKC2FsbG93X2FsaWFzGAIgASgI" + "EhkKCmRlcHJlY2F0ZWQYAyABKAg6BWZhbHNlEkMKFHVuaW50ZXJwcmV0ZWRf" + "b3B0aW9uGOcHIAMoCzIkLmdvb2dsZS5wcm90b2J1Zi5VbmludGVycHJldGVk" + "T3B0aW9uKgkI6AcQgICAgAIifQoQRW51bVZhbHVlT3B0aW9ucxIZCgpkZXBy" + "ZWNhdGVkGAEgASgIOgVmYWxzZRJDChR1bmludGVycHJldGVkX29wdGlvbhjn" + "ByADKAsyJC5nb29nbGUucHJvdG9idWYuVW5pbnRlcnByZXRlZE9wdGlvbioJ" + "COgHEICAgIACInsKDlNlcnZpY2VPcHRpb25zEhkKCmRlcHJlY2F0ZWQYISAB" + "KAg6BWZhbHNlEkMKFHVuaW50ZXJwcmV0ZWRfb3B0aW9uGOcHIAMoCzIkLmdv" + "b2dsZS5wcm90b2J1Zi5VbmludGVycHJldGVkT3B0aW9uKgkI6AcQgICAgAIi" + "egoNTWV0aG9kT3B0aW9ucxIZCgpkZXByZWNhdGVkGCEgASgIOgVmYWxzZRJD" + "ChR1bmludGVycHJldGVkX29wdGlvbhjnByADKAsyJC5nb29nbGUucHJvdG9i" + "dWYuVW5pbnRlcnByZXRlZE9wdGlvbioJCOgHEICAgIACIp4CChNVbmludGVy" + "cHJldGVkT3B0aW9uEjsKBG5hbWUYAiADKAsyLS5nb29nbGUucHJvdG9idWYu" + "VW5pbnRlcnByZXRlZE9wdGlvbi5OYW1lUGFydBIYChBpZGVudGlmaWVyX3Zh" + "bHVlGAMgASgJEhoKEnBvc2l0aXZlX2ludF92YWx1ZRgEIAEoBBIaChJuZWdh" + "dGl2ZV9pbnRfdmFsdWUYBSABKAMSFAoMZG91YmxlX3ZhbHVlGAYgASgBEhQK" + "DHN0cmluZ192YWx1ZRgHIAEoDBIXCg9hZ2dyZWdhdGVfdmFsdWUYCCABKAka" + "MwoITmFtZVBhcnQSEQoJbmFtZV9wYXJ0GAEgAigJEhQKDGlzX2V4dGVuc2lv" + "bhgCIAIoCCLVAQoOU291cmNlQ29kZUluZm8SOgoIbG9jYXRpb24YASADKAsy" + "KC5nb29nbGUucHJvdG9idWYuU291cmNlQ29kZUluZm8uTG9jYXRpb24ahgEK" + "CExvY2F0aW9uEhAKBHBhdGgYASADKAVCAhABEhAKBHNwYW4YAiADKAVCAhAB" + "EhgKEGxlYWRpbmdfY29tbWVudHMYAyABKAkSGQoRdHJhaWxpbmdfY29tbWVu" + "dHMYBCABKAkSIQoZbGVhZGluZ19kZXRhY2hlZF9jb21tZW50cxgGIAMoCSKn" + "AQoRR2VuZXJhdGVkQ29kZUluZm8SQQoKYW5ub3RhdGlvbhgBIAMoCzItLmdv" + "b2dsZS5wcm90b2J1Zi5HZW5lcmF0ZWRDb2RlSW5mby5Bbm5vdGF0aW9uGk8K" + "CkFubm90YXRpb24SEAoEcGF0aBgBIAMoBUICEAESEwoLc291cmNlX2ZpbGUY" + "AiABKAkSDQoFYmVnaW4YAyABKAUSCwoDZW5kGAQgASgFQlgKE2NvbS5nb29n" + "bGUucHJvdG9idWZCEERlc2NyaXB0b3JQcm90b3NIAVoKZGVzY3JpcHRvcqIC" + "A0dQQqoCGkdvb2dsZS5Qcm90b2J1Zi5SZWZsZWN0aW9u"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[20]
			{
				new GeneratedClrTypeInfo(typeof(FileDescriptorSet), FileDescriptorSet.Parser, new string[1] { "File" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(FileDescriptorProto), FileDescriptorProto.Parser, new string[12]
				{
					"Name", "Package", "Dependency", "PublicDependency", "WeakDependency", "MessageType", "EnumType", "Service", "Extension", "Options",
					"SourceCodeInfo", "Syntax"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(DescriptorProto), DescriptorProto.Parser, new string[10] { "Name", "Field", "Extension", "NestedType", "EnumType", "ExtensionRange", "OneofDecl", "Options", "ReservedRange", "ReservedName" }, null, null, new GeneratedClrTypeInfo[2]
				{
					new GeneratedClrTypeInfo(typeof(DescriptorProto.Types.ExtensionRange), DescriptorProto.Types.ExtensionRange.Parser, new string[2] { "Start", "End" }, null, null, null),
					new GeneratedClrTypeInfo(typeof(DescriptorProto.Types.ReservedRange), DescriptorProto.Types.ReservedRange.Parser, new string[2] { "Start", "End" }, null, null, null)
				}),
				new GeneratedClrTypeInfo(typeof(FieldDescriptorProto), FieldDescriptorProto.Parser, new string[10] { "Name", "Number", "Label", "Type", "TypeName", "Extendee", "DefaultValue", "OneofIndex", "JsonName", "Options" }, null, new System.Type[2]
				{
					typeof(FieldDescriptorProto.Types.Type),
					typeof(FieldDescriptorProto.Types.Label)
				}, null),
				new GeneratedClrTypeInfo(typeof(OneofDescriptorProto), OneofDescriptorProto.Parser, new string[2] { "Name", "Options" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(EnumDescriptorProto), EnumDescriptorProto.Parser, new string[3] { "Name", "Value", "Options" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(EnumValueDescriptorProto), EnumValueDescriptorProto.Parser, new string[3] { "Name", "Number", "Options" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(ServiceDescriptorProto), ServiceDescriptorProto.Parser, new string[3] { "Name", "Method", "Options" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(MethodDescriptorProto), MethodDescriptorProto.Parser, new string[6] { "Name", "InputType", "OutputType", "Options", "ClientStreaming", "ServerStreaming" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(FileOptions), FileOptions.Parser, new string[15]
				{
					"JavaPackage", "JavaOuterClassname", "JavaMultipleFiles", "JavaGenerateEqualsAndHash", "JavaStringCheckUtf8", "OptimizeFor", "GoPackage", "CcGenericServices", "JavaGenericServices", "PyGenericServices",
					"Deprecated", "CcEnableArenas", "ObjcClassPrefix", "CsharpNamespace", "UninterpretedOption"
				}, null, new System.Type[1] { typeof(FileOptions.Types.OptimizeMode) }, null),
				new GeneratedClrTypeInfo(typeof(MessageOptions), MessageOptions.Parser, new string[5] { "MessageSetWireFormat", "NoStandardDescriptorAccessor", "Deprecated", "MapEntry", "UninterpretedOption" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(FieldOptions), FieldOptions.Parser, new string[7] { "Ctype", "Packed", "Jstype", "Lazy", "Deprecated", "Weak", "UninterpretedOption" }, null, new System.Type[2]
				{
					typeof(FieldOptions.Types.CType),
					typeof(FieldOptions.Types.JSType)
				}, null),
				new GeneratedClrTypeInfo(typeof(OneofOptions), OneofOptions.Parser, new string[1] { "UninterpretedOption" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(EnumOptions), EnumOptions.Parser, new string[3] { "AllowAlias", "Deprecated", "UninterpretedOption" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(EnumValueOptions), EnumValueOptions.Parser, new string[2] { "Deprecated", "UninterpretedOption" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(ServiceOptions), ServiceOptions.Parser, new string[2] { "Deprecated", "UninterpretedOption" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(MethodOptions), MethodOptions.Parser, new string[2] { "Deprecated", "UninterpretedOption" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(UninterpretedOption), UninterpretedOption.Parser, new string[7] { "Name", "IdentifierValue", "PositiveIntValue", "NegativeIntValue", "DoubleValue", "StringValue", "AggregateValue" }, null, null, new GeneratedClrTypeInfo[1]
				{
					new GeneratedClrTypeInfo(typeof(UninterpretedOption.Types.NamePart), UninterpretedOption.Types.NamePart.Parser, new string[2] { "NamePart_", "IsExtension" }, null, null, null)
				}),
				new GeneratedClrTypeInfo(typeof(SourceCodeInfo), SourceCodeInfo.Parser, new string[1] { "Location" }, null, null, new GeneratedClrTypeInfo[1]
				{
					new GeneratedClrTypeInfo(typeof(SourceCodeInfo.Types.Location), SourceCodeInfo.Types.Location.Parser, new string[5] { "Path", "Span", "LeadingComments", "TrailingComments", "LeadingDetachedComments" }, null, null, null)
				}),
				new GeneratedClrTypeInfo(typeof(GeneratedCodeInfo), GeneratedCodeInfo.Parser, new string[1] { "Annotation" }, null, null, new GeneratedClrTypeInfo[1]
				{
					new GeneratedClrTypeInfo(typeof(GeneratedCodeInfo.Types.Annotation), GeneratedCodeInfo.Types.Annotation.Parser, new string[4] { "Path", "SourceFile", "Begin", "End" }, null, null, null)
				})
			}));
		}
	}
	internal sealed class FileDescriptorSet : IMessage<FileDescriptorSet>, IMessage, IEquatable<FileDescriptorSet>, IDeepCloneable<FileDescriptorSet>
	{
		private static readonly MessageParser<FileDescriptorSet> _parser = new MessageParser<FileDescriptorSet>(() => new FileDescriptorSet());

		public const int FileFieldNumber = 1;

		private static readonly FieldCodec<FileDescriptorProto> _repeated_file_codec = FieldCodec.ForMessage(10u, FileDescriptorProto.Parser);

		private readonly RepeatedField<FileDescriptorProto> file_ = new RepeatedField<FileDescriptorProto>();

		[DebuggerNonUserCode]
		public static MessageParser<FileDescriptorSet> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public RepeatedField<FileDescriptorProto> File => file_;

		[DebuggerNonUserCode]
		public FileDescriptorSet()
		{
		}

		[DebuggerNonUserCode]
		public FileDescriptorSet(FileDescriptorSet other)
			: this()
		{
			file_ = other.file_.Clone();
		}

		[DebuggerNonUserCode]
		public FileDescriptorSet Clone()
		{
			return new FileDescriptorSet(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as FileDescriptorSet);
		}

		[DebuggerNonUserCode]
		public bool Equals(FileDescriptorSet other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (!file_.Equals(other.file_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 1 ^ file_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			file_.WriteTo(output, _repeated_file_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0 + file_.CalculateSize(_repeated_file_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(FileDescriptorSet other)
		{
			if (other != null)
			{
				file_.Add(other.file_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 10)
				{
					input.SkipLastField();
				}
				else
				{
					file_.AddEntriesFrom(input, _repeated_file_codec);
				}
			}
		}
	}
	internal sealed class FileDescriptorProto : IMessage<FileDescriptorProto>, IMessage, IEquatable<FileDescriptorProto>, IDeepCloneable<FileDescriptorProto>
	{
		private static readonly MessageParser<FileDescriptorProto> _parser = new MessageParser<FileDescriptorProto>(() => new FileDescriptorProto());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int PackageFieldNumber = 2;

		private string package_ = "";

		public const int DependencyFieldNumber = 3;

		private static readonly FieldCodec<string> _repeated_dependency_codec = FieldCodec.ForString(26u);

		private readonly RepeatedField<string> dependency_ = new RepeatedField<string>();

		public const int PublicDependencyFieldNumber = 10;

		private static readonly FieldCodec<int> _repeated_publicDependency_codec = FieldCodec.ForInt32(80u);

		private readonly RepeatedField<int> publicDependency_ = new RepeatedField<int>();

		public const int WeakDependencyFieldNumber = 11;

		private static readonly FieldCodec<int> _repeated_weakDependency_codec = FieldCodec.ForInt32(88u);

		private readonly RepeatedField<int> weakDependency_ = new RepeatedField<int>();

		public const int MessageTypeFieldNumber = 4;

		private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec = FieldCodec.ForMessage(34u, DescriptorProto.Parser);

		private readonly RepeatedField<DescriptorProto> messageType_ = new RepeatedField<DescriptorProto>();

		public const int EnumTypeFieldNumber = 5;

		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec = FieldCodec.ForMessage(42u, EnumDescriptorProto.Parser);

		private readonly RepeatedField<EnumDescriptorProto> enumType_ = new RepeatedField<EnumDescriptorProto>();

		public const int ServiceFieldNumber = 6;

		private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec = FieldCodec.ForMessage(50u, ServiceDescriptorProto.Parser);

		private readonly RepeatedField<ServiceDescriptorProto> service_ = new RepeatedField<ServiceDescriptorProto>();

		public const int ExtensionFieldNumber = 7;

		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec = FieldCodec.ForMessage(58u, FieldDescriptorProto.Parser);

		private readonly RepeatedField<FieldDescriptorProto> extension_ = new RepeatedField<FieldDescriptorProto>();

		public const int OptionsFieldNumber = 8;

		private FileOptions options_;

		public const int SourceCodeInfoFieldNumber = 9;

		private SourceCodeInfo sourceCodeInfo_;

		public const int SyntaxFieldNumber = 12;

		private string syntax_ = "";

		[DebuggerNonUserCode]
		public static MessageParser<FileDescriptorProto> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[1];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public string Package
		{
			get
			{
				return package_;
			}
			set
			{
				package_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<string> Dependency => dependency_;

		[DebuggerNonUserCode]
		public RepeatedField<int> PublicDependency => publicDependency_;

		[DebuggerNonUserCode]
		public RepeatedField<int> WeakDependency => weakDependency_;

		[DebuggerNonUserCode]
		public RepeatedField<DescriptorProto> MessageType => messageType_;

		[DebuggerNonUserCode]
		public RepeatedField<EnumDescriptorProto> EnumType => enumType_;

		[DebuggerNonUserCode]
		public RepeatedField<ServiceDescriptorProto> Service => service_;

		[DebuggerNonUserCode]
		public RepeatedField<FieldDescriptorProto> Extension => extension_;

		[DebuggerNonUserCode]
		public FileOptions Options
		{
			get
			{
				return options_;
			}
			set
			{
				options_ = value;
			}
		}

		[DebuggerNonUserCode]
		public SourceCodeInfo SourceCodeInfo
		{
			get
			{
				return sourceCodeInfo_;
			}
			set
			{
				sourceCodeInfo_ = value;
			}
		}

		[DebuggerNonUserCode]
		public string Syntax
		{
			get
			{
				return syntax_;
			}
			set
			{
				syntax_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public FileDescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public FileDescriptorProto(FileDescriptorProto other)
			: this()
		{
			name_ = other.name_;
			package_ = other.package_;
			dependency_ = other.dependency_.Clone();
			publicDependency_ = other.publicDependency_.Clone();
			weakDependency_ = other.weakDependency_.Clone();
			messageType_ = other.messageType_.Clone();
			enumType_ = other.enumType_.Clone();
			service_ = other.service_.Clone();
			extension_ = other.extension_.Clone();
			Options = ((other.options_ != null) ? other.Options.Clone() : null);
			SourceCodeInfo = ((other.sourceCodeInfo_ != null) ? other.SourceCodeInfo.Clone() : null);
			syntax_ = other.syntax_;
		}

		[DebuggerNonUserCode]
		public FileDescriptorProto Clone()
		{
			return new FileDescriptorProto(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as FileDescriptorProto);
		}

		[DebuggerNonUserCode]
		public bool Equals(FileDescriptorProto other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (Package != other.Package)
			{
				return false;
			}
			if (!dependency_.Equals(other.dependency_))
			{
				return false;
			}
			if (!publicDependency_.Equals(other.publicDependency_))
			{
				return false;
			}
			if (!weakDependency_.Equals(other.weakDependency_))
			{
				return false;
			}
			if (!messageType_.Equals(other.messageType_))
			{
				return false;
			}
			if (!enumType_.Equals(other.enumType_))
			{
				return false;
			}
			if (!service_.Equals(other.service_))
			{
				return false;
			}
			if (!extension_.Equals(other.extension_))
			{
				return false;
			}
			if (!object.Equals(Options, other.Options))
			{
				return false;
			}
			if (!object.Equals(SourceCodeInfo, other.SourceCodeInfo))
			{
				return false;
			}
			if (Syntax != other.Syntax)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			if (Package.Length != 0)
			{
				num ^= Package.GetHashCode();
			}
			num ^= dependency_.GetHashCode();
			num ^= publicDependency_.GetHashCode();
			num ^= weakDependency_.GetHashCode();
			num ^= messageType_.GetHashCode();
			num ^= enumType_.GetHashCode();
			num ^= service_.GetHashCode();
			num ^= extension_.GetHashCode();
			if (options_ != null)
			{
				num ^= Options.GetHashCode();
			}
			if (sourceCodeInfo_ != null)
			{
				num ^= SourceCodeInfo.GetHashCode();
			}
			if (Syntax.Length != 0)
			{
				num ^= Syntax.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			if (Package.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(Package);
			}
			dependency_.WriteTo(output, _repeated_dependency_codec);
			messageType_.WriteTo(output, _repeated_messageType_codec);
			enumType_.WriteTo(output, _repeated_enumType_codec);
			service_.WriteTo(output, _repeated_service_codec);
			extension_.WriteTo(output, _repeated_extension_codec);
			if (options_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(Options);
			}
			if (sourceCodeInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(SourceCodeInfo);
			}
			publicDependency_.WriteTo(output, _repeated_publicDependency_codec);
			weakDependency_.WriteTo(output, _repeated_weakDependency_codec);
			if (Syntax.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(Syntax);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			if (Package.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Package);
			}
			num += dependency_.CalculateSize(_repeated_dependency_codec);
			num += publicDependency_.CalculateSize(_repeated_publicDependency_codec);
			num += weakDependency_.CalculateSize(_repeated_weakDependency_codec);
			num += messageType_.CalculateSize(_repeated_messageType_codec);
			num += enumType_.CalculateSize(_repeated_enumType_codec);
			num += service_.CalculateSize(_repeated_service_codec);
			num += extension_.CalculateSize(_repeated_extension_codec);
			if (options_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(Options);
			}
			if (sourceCodeInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(SourceCodeInfo);
			}
			if (Syntax.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Syntax);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(FileDescriptorProto other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Package.Length != 0)
			{
				Package = other.Package;
			}
			dependency_.Add(other.dependency_);
			publicDependency_.Add(other.publicDependency_);
			weakDependency_.Add(other.weakDependency_);
			messageType_.Add(other.messageType_);
			enumType_.Add(other.enumType_);
			service_.Add(other.service_);
			extension_.Add(other.extension_);
			if (other.options_ != null)
			{
				if (options_ == null)
				{
					options_ = new FileOptions();
				}
				Options.MergeFrom(other.Options);
			}
			if (other.sourceCodeInfo_ != null)
			{
				if (sourceCodeInfo_ == null)
				{
					sourceCodeInfo_ = new SourceCodeInfo();
				}
				SourceCodeInfo.MergeFrom(other.SourceCodeInfo);
			}
			if (other.Syntax.Length != 0)
			{
				Syntax = other.Syntax;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					Package = input.ReadString();
					break;
				case 26u:
					dependency_.AddEntriesFrom(input, _repeated_dependency_codec);
					break;
				case 34u:
					messageType_.AddEntriesFrom(input, _repeated_messageType_codec);
					break;
				case 42u:
					enumType_.AddEntriesFrom(input, _repeated_enumType_codec);
					break;
				case 50u:
					service_.AddEntriesFrom(input, _repeated_service_codec);
					break;
				case 58u:
					extension_.AddEntriesFrom(input, _repeated_extension_codec);
					break;
				case 66u:
					if (options_ == null)
					{
						options_ = new FileOptions();
					}
					input.ReadMessage(options_);
					break;
				case 74u:
					if (sourceCodeInfo_ == null)
					{
						sourceCodeInfo_ = new SourceCodeInfo();
					}
					input.ReadMessage(sourceCodeInfo_);
					break;
				case 80u:
				case 82u:
					publicDependency_.AddEntriesFrom(input, _repeated_publicDependency_codec);
					break;
				case 88u:
				case 90u:
					weakDependency_.AddEntriesFrom(input, _repeated_weakDependency_codec);
					break;
				case 98u:
					Syntax = input.ReadString();
					break;
				}
			}
		}
	}
	internal sealed class DescriptorProto : IMessage<DescriptorProto>, IMessage, IEquatable<DescriptorProto>, IDeepCloneable<DescriptorProto>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal sealed class ExtensionRange : IMessage<ExtensionRange>, IMessage, IEquatable<ExtensionRange>, IDeepCloneable<ExtensionRange>
			{
				private static readonly MessageParser<ExtensionRange> _parser = new MessageParser<ExtensionRange>(() => new ExtensionRange());

				public const int StartFieldNumber = 1;

				private int start_;

				public const int EndFieldNumber = 2;

				private int end_;

				[DebuggerNonUserCode]
				public static MessageParser<ExtensionRange> Parser => _parser;

				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor => DescriptorProto.Descriptor.NestedTypes[0];

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor => Descriptor;

				[DebuggerNonUserCode]
				public int Start
				{
					get
					{
						return start_;
					}
					set
					{
						start_ = value;
					}
				}

				[DebuggerNonUserCode]
				public int End
				{
					get
					{
						return end_;
					}
					set
					{
						end_ = value;
					}
				}

				[DebuggerNonUserCode]
				public ExtensionRange()
				{
				}

				[DebuggerNonUserCode]
				public ExtensionRange(ExtensionRange other)
					: this()
				{
					start_ = other.start_;
					end_ = other.end_;
				}

				[DebuggerNonUserCode]
				public ExtensionRange Clone()
				{
					return new ExtensionRange(this);
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return Equals(other as ExtensionRange);
				}

				[DebuggerNonUserCode]
				public bool Equals(ExtensionRange other)
				{
					if (other == null)
					{
						return false;
					}
					if (other == this)
					{
						return true;
					}
					if (Start != other.Start)
					{
						return false;
					}
					if (End != other.End)
					{
						return false;
					}
					return true;
				}

				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					if (Start != 0)
					{
						num ^= Start.GetHashCode();
					}
					if (End != 0)
					{
						num ^= End.GetHashCode();
					}
					return num;
				}

				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					if (Start != 0)
					{
						output.WriteRawTag(8);
						output.WriteInt32(Start);
					}
					if (End != 0)
					{
						output.WriteRawTag(16);
						output.WriteInt32(End);
					}
				}

				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					if (Start != 0)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(Start);
					}
					if (End != 0)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(End);
					}
					return num;
				}

				[DebuggerNonUserCode]
				public void MergeFrom(ExtensionRange other)
				{
					if (other != null)
					{
						if (other.Start != 0)
						{
							Start = other.Start;
						}
						if (other.End != 0)
						{
							End = other.End;
						}
					}
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					uint num;
					while ((num = input.ReadTag()) != 0)
					{
						switch (num)
						{
						default:
							input.SkipLastField();
							break;
						case 8u:
							Start = input.ReadInt32();
							break;
						case 16u:
							End = input.ReadInt32();
							break;
						}
					}
				}
			}

			internal sealed class ReservedRange : IMessage<ReservedRange>, IMessage, IEquatable<ReservedRange>, IDeepCloneable<ReservedRange>
			{
				private static readonly MessageParser<ReservedRange> _parser = new MessageParser<ReservedRange>(() => new ReservedRange());

				public const int StartFieldNumber = 1;

				private int start_;

				public const int EndFieldNumber = 2;

				private int end_;

				[DebuggerNonUserCode]
				public static MessageParser<ReservedRange> Parser => _parser;

				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor => DescriptorProto.Descriptor.NestedTypes[1];

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor => Descriptor;

				[DebuggerNonUserCode]
				public int Start
				{
					get
					{
						return start_;
					}
					set
					{
						start_ = value;
					}
				}

				[DebuggerNonUserCode]
				public int End
				{
					get
					{
						return end_;
					}
					set
					{
						end_ = value;
					}
				}

				[DebuggerNonUserCode]
				public ReservedRange()
				{
				}

				[DebuggerNonUserCode]
				public ReservedRange(ReservedRange other)
					: this()
				{
					start_ = other.start_;
					end_ = other.end_;
				}

				[DebuggerNonUserCode]
				public ReservedRange Clone()
				{
					return new ReservedRange(this);
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return Equals(other as ReservedRange);
				}

				[DebuggerNonUserCode]
				public bool Equals(ReservedRange other)
				{
					if (other == null)
					{
						return false;
					}
					if (other == this)
					{
						return true;
					}
					if (Start != other.Start)
					{
						return false;
					}
					if (End != other.End)
					{
						return false;
					}
					return true;
				}

				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					if (Start != 0)
					{
						num ^= Start.GetHashCode();
					}
					if (End != 0)
					{
						num ^= End.GetHashCode();
					}
					return num;
				}

				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					if (Start != 0)
					{
						output.WriteRawTag(8);
						output.WriteInt32(Start);
					}
					if (End != 0)
					{
						output.WriteRawTag(16);
						output.WriteInt32(End);
					}
				}

				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					if (Start != 0)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(Start);
					}
					if (End != 0)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(End);
					}
					return num;
				}

				[DebuggerNonUserCode]
				public void MergeFrom(ReservedRange other)
				{
					if (other != null)
					{
						if (other.Start != 0)
						{
							Start = other.Start;
						}
						if (other.End != 0)
						{
							End = other.End;
						}
					}
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					uint num;
					while ((num = input.ReadTag()) != 0)
					{
						switch (num)
						{
						default:
							input.SkipLastField();
							break;
						case 8u:
							Start = input.ReadInt32();
							break;
						case 16u:
							End = input.ReadInt32();
							break;
						}
					}
				}
			}
		}

		private static readonly MessageParser<DescriptorProto> _parser = new MessageParser<DescriptorProto>(() => new DescriptorProto());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int FieldFieldNumber = 2;

		private static readonly FieldCodec<FieldDescriptorProto> _repeated_field_codec = FieldCodec.ForMessage(18u, FieldDescriptorProto.Parser);

		private readonly RepeatedField<FieldDescriptorProto> field_ = new RepeatedField<FieldDescriptorProto>();

		public const int ExtensionFieldNumber = 6;

		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec = FieldCodec.ForMessage(50u, FieldDescriptorProto.Parser);

		private readonly RepeatedField<FieldDescriptorProto> extension_ = new RepeatedField<FieldDescriptorProto>();

		public const int NestedTypeFieldNumber = 3;

		private static readonly FieldCodec<DescriptorProto> _repeated_nestedType_codec = FieldCodec.ForMessage(26u, Parser);

		private readonly RepeatedField<DescriptorProto> nestedType_ = new RepeatedField<DescriptorProto>();

		public const int EnumTypeFieldNumber = 4;

		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec = FieldCodec.ForMessage(34u, EnumDescriptorProto.Parser);

		private readonly RepeatedField<EnumDescriptorProto> enumType_ = new RepeatedField<EnumDescriptorProto>();

		public const int ExtensionRangeFieldNumber = 5;

		private static readonly FieldCodec<Types.ExtensionRange> _repeated_extensionRange_codec = FieldCodec.ForMessage(42u, Types.ExtensionRange.Parser);

		private readonly RepeatedField<Types.ExtensionRange> extensionRange_ = new RepeatedField<Types.ExtensionRange>();

		public const int OneofDeclFieldNumber = 8;

		private static readonly FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec = FieldCodec.ForMessage(66u, OneofDescriptorProto.Parser);

		private readonly RepeatedField<OneofDescriptorProto> oneofDecl_ = new RepeatedField<OneofDescriptorProto>();

		public const int OptionsFieldNumber = 7;

		private MessageOptions options_;

		public const int ReservedRangeFieldNumber = 9;

		private static readonly FieldCodec<Types.ReservedRange> _repeated_reservedRange_codec = FieldCodec.ForMessage(74u, Types.ReservedRange.Parser);

		private readonly RepeatedField<Types.ReservedRange> reservedRange_ = new RepeatedField<Types.ReservedRange>();

		public const int ReservedNameFieldNumber = 10;

		private static readonly FieldCodec<string> _repeated_reservedName_codec = FieldCodec.ForString(82u);

		private readonly RepeatedField<string> reservedName_ = new RepeatedField<string>();

		[DebuggerNonUserCode]
		public static MessageParser<DescriptorProto> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[2];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<FieldDescriptorProto> Field => field_;

		[DebuggerNonUserCode]
		public RepeatedField<FieldDescriptorProto> Extension => extension_;

		[DebuggerNonUserCode]
		public RepeatedField<DescriptorProto> NestedType => nestedType_;

		[DebuggerNonUserCode]
		public RepeatedField<EnumDescriptorProto> EnumType => enumType_;

		[DebuggerNonUserCode]
		public RepeatedField<Types.ExtensionRange> ExtensionRange => extensionRange_;

		[DebuggerNonUserCode]
		public RepeatedField<OneofDescriptorProto> OneofDecl => oneofDecl_;

		[DebuggerNonUserCode]
		public MessageOptions Options
		{
			get
			{
				return options_;
			}
			set
			{
				options_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<Types.ReservedRange> ReservedRange => reservedRange_;

		[DebuggerNonUserCode]
		public RepeatedField<string> ReservedName => reservedName_;

		[DebuggerNonUserCode]
		public DescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public DescriptorProto(DescriptorProto other)
			: this()
		{
			name_ = other.name_;
			field_ = other.field_.Clone();
			extension_ = other.extension_.Clone();
			nestedType_ = other.nestedType_.Clone();
			enumType_ = other.enumType_.Clone();
			extensionRange_ = other.extensionRange_.Clone();
			oneofDecl_ = other.oneofDecl_.Clone();
			Options = ((other.options_ != null) ? other.Options.Clone() : null);
			reservedRange_ = other.reservedRange_.Clone();
			reservedName_ = other.reservedName_.Clone();
		}

		[DebuggerNonUserCode]
		public DescriptorProto Clone()
		{
			return new DescriptorProto(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as DescriptorProto);
		}

		[DebuggerNonUserCode]
		public bool Equals(DescriptorProto other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (!field_.Equals(other.field_))
			{
				return false;
			}
			if (!extension_.Equals(other.extension_))
			{
				return false;
			}
			if (!nestedType_.Equals(other.nestedType_))
			{
				return false;
			}
			if (!enumType_.Equals(other.enumType_))
			{
				return false;
			}
			if (!extensionRange_.Equals(other.extensionRange_))
			{
				return false;
			}
			if (!oneofDecl_.Equals(other.oneofDecl_))
			{
				return false;
			}
			if (!object.Equals(Options, other.Options))
			{
				return false;
			}
			if (!reservedRange_.Equals(other.reservedRange_))
			{
				return false;
			}
			if (!reservedName_.Equals(other.reservedName_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			num ^= field_.GetHashCode();
			num ^= extension_.GetHashCode();
			num ^= nestedType_.GetHashCode();
			num ^= enumType_.GetHashCode();
			num ^= extensionRange_.GetHashCode();
			num ^= oneofDecl_.GetHashCode();
			if (options_ != null)
			{
				num ^= Options.GetHashCode();
			}
			num ^= reservedRange_.GetHashCode();
			return num ^ reservedName_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			field_.WriteTo(output, _repeated_field_codec);
			nestedType_.WriteTo(output, _repeated_nestedType_codec);
			enumType_.WriteTo(output, _repeated_enumType_codec);
			extensionRange_.WriteTo(output, _repeated_extensionRange_codec);
			extension_.WriteTo(output, _repeated_extension_codec);
			if (options_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(Options);
			}
			oneofDecl_.WriteTo(output, _repeated_oneofDecl_codec);
			reservedRange_.WriteTo(output, _repeated_reservedRange_codec);
			reservedName_.WriteTo(output, _repeated_reservedName_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			num += field_.CalculateSize(_repeated_field_codec);
			num += extension_.CalculateSize(_repeated_extension_codec);
			num += nestedType_.CalculateSize(_repeated_nestedType_codec);
			num += enumType_.CalculateSize(_repeated_enumType_codec);
			num += extensionRange_.CalculateSize(_repeated_extensionRange_codec);
			num += oneofDecl_.CalculateSize(_repeated_oneofDecl_codec);
			if (options_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(Options);
			}
			num += reservedRange_.CalculateSize(_repeated_reservedRange_codec);
			return num + reservedName_.CalculateSize(_repeated_reservedName_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(DescriptorProto other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			field_.Add(other.field_);
			extension_.Add(other.extension_);
			nestedType_.Add(other.nestedType_);
			enumType_.Add(other.enumType_);
			extensionRange_.Add(other.extensionRange_);
			oneofDecl_.Add(other.oneofDecl_);
			if (other.options_ != null)
			{
				if (options_ == null)
				{
					options_ = new MessageOptions();
				}
				Options.MergeFrom(other.Options);
			}
			reservedRange_.Add(other.reservedRange_);
			reservedName_.Add(other.reservedName_);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					field_.AddEntriesFrom(input, _repeated_field_codec);
					break;
				case 26u:
					nestedType_.AddEntriesFrom(input, _repeated_nestedType_codec);
					break;
				case 34u:
					enumType_.AddEntriesFrom(input, _repeated_enumType_codec);
					break;
				case 42u:
					extensionRange_.AddEntriesFrom(input, _repeated_extensionRange_codec);
					break;
				case 50u:
					extension_.AddEntriesFrom(input, _repeated_extension_codec);
					break;
				case 58u:
					if (options_ == null)
					{
						options_ = new MessageOptions();
					}
					input.ReadMessage(options_);
					break;
				case 66u:
					oneofDecl_.AddEntriesFrom(input, _repeated_oneofDecl_codec);
					break;
				case 74u:
					reservedRange_.AddEntriesFrom(input, _repeated_reservedRange_codec);
					break;
				case 82u:
					reservedName_.AddEntriesFrom(input, _repeated_reservedName_codec);
					break;
				}
			}
		}
	}
	internal sealed class FieldDescriptorProto : IMessage<FieldDescriptorProto>, IMessage, IEquatable<FieldDescriptorProto>, IDeepCloneable<FieldDescriptorProto>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum Type
			{
				[OriginalName("TYPE_DOUBLE")]
				Double = 1,
				[OriginalName("TYPE_FLOAT")]
				Float,
				[OriginalName("TYPE_INT64")]
				Int64,
				[OriginalName("TYPE_UINT64")]
				Uint64,
				[OriginalName("TYPE_INT32")]
				Int32,
				[OriginalName("TYPE_FIXED64")]
				Fixed64,
				[OriginalName("TYPE_FIXED32")]
				Fixed32,
				[OriginalName("TYPE_BOOL")]
				Bool,
				[OriginalName("TYPE_STRING")]
				String,
				[OriginalName("TYPE_GROUP")]
				Group,
				[OriginalName("TYPE_MESSAGE")]
				Message,
				[OriginalName("TYPE_BYTES")]
				Bytes,
				[OriginalName("TYPE_UINT32")]
				Uint32,
				[OriginalName("TYPE_ENUM")]
				Enum,
				[OriginalName("TYPE_SFIXED32")]
				Sfixed32,
				[OriginalName("TYPE_SFIXED64")]
				Sfixed64,
				[OriginalName("TYPE_SINT32")]
				Sint32,
				[OriginalName("TYPE_SINT64")]
				Sint64
			}

			internal enum Label
			{
				[OriginalName("LABEL_OPTIONAL")]
				Optional = 1,
				[OriginalName("LABEL_REQUIRED")]
				Required,
				[OriginalName("LABEL_REPEATED")]
				Repeated
			}
		}

		private static readonly MessageParser<FieldDescriptorProto> _parser = new MessageParser<FieldDescriptorProto>(() => new FieldDescriptorProto());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int NumberFieldNumber = 3;

		private int number_;

		public const int LabelFieldNumber = 4;

		private Types.Label label_;

		public const int TypeFieldNumber = 5;

		private Types.Type type_;

		public const int TypeNameFieldNumber = 6;

		private string typeName_ = "";

		public const int ExtendeeFieldNumber = 2;

		private string extendee_ = "";

		public const int DefaultValueFieldNumber = 7;

		private string defaultValue_ = "";

		public const int OneofIndexFieldNumber = 9;

		private int oneofIndex_;

		public const int JsonNameFieldNumber = 10;

		private string jsonName_ = "";

		public const int OptionsFieldNumber = 8;

		private FieldOptions options_;

		[DebuggerNonUserCode]
		public static MessageParser<FieldDescriptorProto> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[3];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int Number
		{
			get
			{
				return number_;
			}
			set
			{
				number_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Types.Label Label
		{
			get
			{
				return label_;
			}
			set
			{
				label_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Types.Type Type
		{
			get
			{
				return type_;
			}
			set
			{
				type_ = value;
			}
		}

		[DebuggerNonUserCode]
		public string TypeName
		{
			get
			{
				return typeName_;
			}
			set
			{
				typeName_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public string Extendee
		{
			get
			{
				return extendee_;
			}
			set
			{
				extendee_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public string DefaultValue
		{
			get
			{
				return defaultValue_;
			}
			set
			{
				defaultValue_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int OneofIndex
		{
			get
			{
				return oneofIndex_;
			}
			set
			{
				oneofIndex_ = value;
			}
		}

		[DebuggerNonUserCode]
		public string JsonName
		{
			get
			{
				return jsonName_;
			}
			set
			{
				jsonName_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public FieldOptions Options
		{
			get
			{
				return options_;
			}
			set
			{
				options_ = value;
			}
		}

		[DebuggerNonUserCode]
		public FieldDescriptorProto()
		{
			OnConstruction();
		}

		private void OnConstruction()
		{
			OneofIndex = -1;
		}

		[DebuggerNonUserCode]
		public FieldDescriptorProto(FieldDescriptorProto other)
			: this()
		{
			name_ = other.name_;
			number_ = other.number_;
			label_ = other.label_;
			type_ = other.type_;
			typeName_ = other.typeName_;
			extendee_ = other.extendee_;
			defaultValue_ = other.defaultValue_;
			oneofIndex_ = other.oneofIndex_;
			jsonName_ = other.jsonName_;
			Options = ((other.options_ != null) ? other.Options.Clone() : null);
		}

		[DebuggerNonUserCode]
		public FieldDescriptorProto Clone()
		{
			return new FieldDescriptorProto(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as FieldDescriptorProto);
		}

		[DebuggerNonUserCode]
		public bool Equals(FieldDescriptorProto other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (Number != other.Number)
			{
				return false;
			}
			if (Label != other.Label)
			{
				return false;
			}
			if (Type != other.Type)
			{
				return false;
			}
			if (TypeName != other.TypeName)
			{
				return false;
			}
			if (Extendee != other.Extendee)
			{
				return false;
			}
			if (DefaultValue != other.DefaultValue)
			{
				return false;
			}
			if (OneofIndex != other.OneofIndex)
			{
				return false;
			}
			if (JsonName != other.JsonName)
			{
				return false;
			}
			if (!object.Equals(Options, other.Options))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			if (Number != 0)
			{
				num ^= Number.GetHashCode();
			}
			if (Label != 0)
			{
				num ^= Label.GetHashCode();
			}
			if (Type != 0)
			{
				num ^= Type.GetHashCode();
			}
			if (TypeName.Length != 0)
			{
				num ^= TypeName.GetHashCode();
			}
			if (Extendee.Length != 0)
			{
				num ^= Extendee.GetHashCode();
			}
			if (DefaultValue.Length != 0)
			{
				num ^= DefaultValue.GetHashCode();
			}
			if (OneofIndex != 0)
			{
				num ^= OneofIndex.GetHashCode();
			}
			if (JsonName.Length != 0)
			{
				num ^= JsonName.GetHashCode();
			}
			if (options_ != null)
			{
				num ^= Options.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			if (Extendee.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(Extendee);
			}
			if (Number != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(Number);
			}
			if (Label != 0)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)Label);
			}
			if (Type != 0)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)Type);
			}
			if (TypeName.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(TypeName);
			}
			if (DefaultValue.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(DefaultValue);
			}
			if (options_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(Options);
			}
			if (OneofIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(OneofIndex);
			}
			if (JsonName.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(JsonName);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			if (Number != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(Number);
			}
			if (Label != 0)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)Label);
			}
			if (Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
			}
			if (TypeName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(TypeName);
			}
			if (Extendee.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Extendee);
			}
			if (DefaultValue.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(DefaultValue);
			}
			if (OneofIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(OneofIndex);
			}
			if (JsonName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(JsonName);
			}
			if (options_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(Options);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(FieldDescriptorProto other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Number != 0)
			{
				Number = other.Number;
			}
			if (other.Label != 0)
			{
				Label = other.Label;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.TypeName.Length != 0)
			{
				TypeName = other.TypeName;
			}
			if (other.Extendee.Length != 0)
			{
				Extendee = other.Extendee;
			}
			if (other.DefaultValue.Length != 0)
			{
				DefaultValue = other.DefaultValue;
			}
			if (other.OneofIndex != 0)
			{
				OneofIndex = other.OneofIndex;
			}
			if (other.JsonName.Length != 0)
			{
				JsonName = other.JsonName;
			}
			if (other.options_ != null)
			{
				if (options_ == null)
				{
					options_ = new FieldOptions();
				}
				Options.MergeFrom(other.Options);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					Extendee = input.ReadString();
					break;
				case 24u:
					Number = input.ReadInt32();
					break;
				case 32u:
					label_ = (Types.Label)input.ReadEnum();
					break;
				case 40u:
					type_ = (Types.Type)input.ReadEnum();
					break;
				case 50u:
					TypeName = input.ReadString();
					break;
				case 58u:
					DefaultValue = input.ReadString();
					break;
				case 66u:
					if (options_ == null)
					{
						options_ = new FieldOptions();
					}
					input.ReadMessage(options_);
					break;
				case 72u:
					OneofIndex = input.ReadInt32();
					break;
				case 82u:
					JsonName = input.ReadString();
					break;
				}
			}
		}
	}
	internal sealed class OneofDescriptorProto : IMessage<OneofDescriptorProto>, IMessage, IEquatable<OneofDescriptorProto>, IDeepCloneable<OneofDescriptorProto>
	{
		private static readonly MessageParser<OneofDescriptorProto> _parser = new MessageParser<OneofDescriptorProto>(() => new OneofDescriptorProto());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int OptionsFieldNumber = 2;

		private OneofOptions options_;

		[DebuggerNonUserCode]
		public static MessageParser<OneofDescriptorProto> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[4];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public OneofOptions Options
		{
			get
			{
				return options_;
			}
			set
			{
				options_ = value;
			}
		}

		[DebuggerNonUserCode]
		public OneofDescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public OneofDescriptorProto(OneofDescriptorProto other)
			: this()
		{
			name_ = other.name_;
			Options = ((other.options_ != null) ? other.Options.Clone() : null);
		}

		[DebuggerNonUserCode]
		public OneofDescriptorProto Clone()
		{
			return new OneofDescriptorProto(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as OneofDescriptorProto);
		}

		[DebuggerNonUserCode]
		public bool Equals(OneofDescriptorProto other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (!object.Equals(Options, other.Options))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			if (options_ != null)
			{
				num ^= Options.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			if (options_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(Options);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			if (options_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(Options);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(OneofDescriptorProto other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.options_ != null)
			{
				if (options_ == null)
				{
					options_ = new OneofOptions();
				}
				Options.MergeFrom(other.Options);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					if (options_ == null)
					{
						options_ = new OneofOptions();
					}
					input.ReadMessage(options_);
					break;
				}
			}
		}
	}
	internal sealed class EnumDescriptorProto : IMessage<EnumDescriptorProto>, IMessage, IEquatable<EnumDescriptorProto>, IDeepCloneable<EnumDescriptorProto>
	{
		private static readonly MessageParser<EnumDescriptorProto> _parser = new MessageParser<EnumDescriptorProto>(() => new EnumDescriptorProto());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int ValueFieldNumber = 2;

		private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec = FieldCodec.ForMessage(18u, EnumValueDescriptorProto.Parser);

		private readonly RepeatedField<EnumValueDescriptorProto> value_ = new RepeatedField<EnumValueDescriptorProto>();

		public const int OptionsFieldNumber = 3;

		private EnumOptions options_;

		[DebuggerNonUserCode]
		public static MessageParser<EnumDescriptorProto> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[5];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<EnumValueDescriptorProto> Value => value_;

		[DebuggerNonUserCode]
		public EnumOptions Options
		{
			get
			{
				return options_;
			}
			set
			{
				options_ = value;
			}
		}

		[DebuggerNonUserCode]
		public EnumDescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public EnumDescriptorProto(EnumDescriptorProto other)
			: this()
		{
			name_ = other.name_;
			value_ = other.value_.Clone();
			Options = ((other.options_ != null) ? other.Options.Clone() : null);
		}

		[DebuggerNonUserCode]
		public EnumDescriptorProto Clone()
		{
			return new EnumDescriptorProto(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as EnumDescriptorProto);
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumDescriptorProto other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (!value_.Equals(other.value_))
			{
				return false;
			}
			if (!object.Equals(Options, other.Options))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			num ^= value_.GetHashCode();
			if (options_ != null)
			{
				num ^= Options.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			value_.WriteTo(output, _repeated_value_codec);
			if (options_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(Options);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			num += value_.CalculateSize(_repeated_value_codec);
			if (options_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(Options);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(EnumDescriptorProto other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			value_.Add(other.value_);
			if (other.options_ != null)
			{
				if (options_ == null)
				{
					options_ = new EnumOptions();
				}
				Options.MergeFrom(other.Options);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					value_.AddEntriesFrom(input, _repeated_value_codec);
					break;
				case 26u:
					if (options_ == null)
					{
						options_ = new EnumOptions();
					}
					input.ReadMessage(options_);
					break;
				}
			}
		}
	}
	internal sealed class EnumValueDescriptorProto : IMessage<EnumValueDescriptorProto>, IMessage, IEquatable<EnumValueDescriptorProto>, IDeepCloneable<EnumValueDescriptorProto>
	{
		private static readonly MessageParser<EnumValueDescriptorProto> _parser = new MessageParser<EnumValueDescriptorProto>(() => new EnumValueDescriptorProto());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int NumberFieldNumber = 2;

		private int number_;

		public const int OptionsFieldNumber = 3;

		private EnumValueOptions options_;

		[DebuggerNonUserCode]
		public static MessageParser<EnumValueDescriptorProto> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[6];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int Number
		{
			get
			{
				return number_;
			}
			set
			{
				number_ = value;
			}
		}

		[DebuggerNonUserCode]
		public EnumValueOptions Options
		{
			get
			{
				return options_;
			}
			set
			{
				options_ = value;
			}
		}

		[DebuggerNonUserCode]
		public EnumValueDescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public EnumValueDescriptorProto(EnumValueDescriptorProto other)
			: this()
		{
			name_ = other.name_;
			number_ = other.number_;
			Options = ((other.options_ != null) ? other.Options.Clone() : null);
		}

		[DebuggerNonUserCode]
		public EnumValueDescriptorProto Clone()
		{
			return new EnumValueDescriptorProto(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as EnumValueDescriptorProto);
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumValueDescriptorProto other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (Number != other.Number)
			{
				return false;
			}
			if (!object.Equals(Options, other.Options))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			if (Number != 0)
			{
				num ^= Number.GetHashCode();
			}
			if (options_ != null)
			{
				num ^= Options.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			if (Number != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(Number);
			}
			if (options_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(Options);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			if (Number != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(Number);
			}
			if (options_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(Options);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(EnumValueDescriptorProto other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Number != 0)
			{
				Number = other.Number;
			}
			if (other.options_ != null)
			{
				if (options_ == null)
				{
					options_ = new EnumValueOptions();
				}
				Options.MergeFrom(other.Options);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 16u:
					Number = input.ReadInt32();
					break;
				case 26u:
					if (options_ == null)
					{
						options_ = new EnumValueOptions();
					}
					input.ReadMessage(options_);
					break;
				}
			}
		}
	}
	internal sealed class ServiceDescriptorProto : IMessage<ServiceDescriptorProto>, IMessage, IEquatable<ServiceDescriptorProto>, IDeepCloneable<ServiceDescriptorProto>
	{
		private static readonly MessageParser<ServiceDescriptorProto> _parser = new MessageParser<ServiceDescriptorProto>(() => new ServiceDescriptorProto());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int MethodFieldNumber = 2;

		private static readonly FieldCodec<MethodDescriptorProto> _repeated_method_codec = FieldCodec.ForMessage(18u, MethodDescriptorProto.Parser);

		private readonly RepeatedField<MethodDescriptorProto> method_ = new RepeatedField<MethodDescriptorProto>();

		public const int OptionsFieldNumber = 3;

		private ServiceOptions options_;

		[DebuggerNonUserCode]
		public static MessageParser<ServiceDescriptorProto> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[7];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<MethodDescriptorProto> Method => method_;

		[DebuggerNonUserCode]
		public ServiceOptions Options
		{
			get
			{
				return options_;
			}
			set
			{
				options_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ServiceDescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public ServiceDescriptorProto(ServiceDescriptorProto other)
			: this()
		{
			name_ = other.name_;
			method_ = other.method_.Clone();
			Options = ((other.options_ != null) ? other.Options.Clone() : null);
		}

		[DebuggerNonUserCode]
		public ServiceDescriptorProto Clone()
		{
			return new ServiceDescriptorProto(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as ServiceDescriptorProto);
		}

		[DebuggerNonUserCode]
		public bool Equals(ServiceDescriptorProto other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (!method_.Equals(other.method_))
			{
				return false;
			}
			if (!object.Equals(Options, other.Options))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			num ^= method_.GetHashCode();
			if (options_ != null)
			{
				num ^= Options.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			method_.WriteTo(output, _repeated_method_codec);
			if (options_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(Options);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			num += method_.CalculateSize(_repeated_method_codec);
			if (options_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(Options);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(ServiceDescriptorProto other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			method_.Add(other.method_);
			if (other.options_ != null)
			{
				if (options_ == null)
				{
					options_ = new ServiceOptions();
				}
				Options.MergeFrom(other.Options);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					method_.AddEntriesFrom(input, _repeated_method_codec);
					break;
				case 26u:
					if (options_ == null)
					{
						options_ = new ServiceOptions();
					}
					input.ReadMessage(options_);
					break;
				}
			}
		}
	}
	internal sealed class MethodDescriptorProto : IMessage<MethodDescriptorProto>, IMessage, IEquatable<MethodDescriptorProto>, IDeepCloneable<MethodDescriptorProto>
	{
		private static readonly MessageParser<MethodDescriptorProto> _parser = new MessageParser<MethodDescriptorProto>(() => new MethodDescriptorProto());

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int InputTypeFieldNumber = 2;

		private string inputType_ = "";

		public const int OutputTypeFieldNumber = 3;

		private string outputType_ = "";

		public const int OptionsFieldNumber = 4;

		private MethodOptions options_;

		public const int ClientStreamingFieldNumber = 5;

		private bool clientStreaming_;

		public const int ServerStreamingFieldNumber = 6;

		private bool serverStreaming_;

		[DebuggerNonUserCode]
		public static MessageParser<MethodDescriptorProto> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[8];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return name_;
			}
			set
			{
				name_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public string InputType
		{
			get
			{
				return inputType_;
			}
			set
			{
				inputType_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public string OutputType
		{
			get
			{
				return outputType_;
			}
			set
			{
				outputType_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MethodOptions Options
		{
			get
			{
				return options_;
			}
			set
			{
				options_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool ClientStreaming
		{
			get
			{
				return clientStreaming_;
			}
			set
			{
				clientStreaming_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool ServerStreaming
		{
			get
			{
				return serverStreaming_;
			}
			set
			{
				serverStreaming_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MethodDescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public MethodDescriptorProto(MethodDescriptorProto other)
			: this()
		{
			name_ = other.name_;
			inputType_ = other.inputType_;
			outputType_ = other.outputType_;
			Options = ((other.options_ != null) ? other.Options.Clone() : null);
			clientStreaming_ = other.clientStreaming_;
			serverStreaming_ = other.serverStreaming_;
		}

		[DebuggerNonUserCode]
		public MethodDescriptorProto Clone()
		{
			return new MethodDescriptorProto(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as MethodDescriptorProto);
		}

		[DebuggerNonUserCode]
		public bool Equals(MethodDescriptorProto other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Name != other.Name)
			{
				return false;
			}
			if (InputType != other.InputType)
			{
				return false;
			}
			if (OutputType != other.OutputType)
			{
				return false;
			}
			if (!object.Equals(Options, other.Options))
			{
				return false;
			}
			if (ClientStreaming != other.ClientStreaming)
			{
				return false;
			}
			if (ServerStreaming != other.ServerStreaming)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Name.Length != 0)
			{
				num ^= Name.GetHashCode();
			}
			if (InputType.Length != 0)
			{
				num ^= InputType.GetHashCode();
			}
			if (OutputType.Length != 0)
			{
				num ^= OutputType.GetHashCode();
			}
			if (options_ != null)
			{
				num ^= Options.GetHashCode();
			}
			if (ClientStreaming)
			{
				num ^= ClientStreaming.GetHashCode();
			}
			if (ServerStreaming)
			{
				num ^= ServerStreaming.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Name);
			}
			if (InputType.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(InputType);
			}
			if (OutputType.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(OutputType);
			}
			if (options_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(Options);
			}
			if (ClientStreaming)
			{
				output.WriteRawTag(40);
				output.WriteBool(ClientStreaming);
			}
			if (ServerStreaming)
			{
				output.WriteRawTag(48);
				output.WriteBool(ServerStreaming);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(Name);
			}
			if (InputType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(InputType);
			}
			if (OutputType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(OutputType);
			}
			if (options_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(Options);
			}
			if (ClientStreaming)
			{
				num += 2;
			}
			if (ServerStreaming)
			{
				num += 2;
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MethodDescriptorProto other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.InputType.Length != 0)
			{
				InputType = other.InputType;
			}
			if (other.OutputType.Length != 0)
			{
				OutputType = other.OutputType;
			}
			if (other.options_ != null)
			{
				if (options_ == null)
				{
					options_ = new MethodOptions();
				}
				Options.MergeFrom(other.Options);
			}
			if (other.ClientStreaming)
			{
				ClientStreaming = other.ClientStreaming;
			}
			if (other.ServerStreaming)
			{
				ServerStreaming = other.ServerStreaming;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					Name = input.ReadString();
					break;
				case 18u:
					InputType = input.ReadString();
					break;
				case 26u:
					OutputType = input.ReadString();
					break;
				case 34u:
					if (options_ == null)
					{
						options_ = new MethodOptions();
					}
					input.ReadMessage(options_);
					break;
				case 40u:
					ClientStreaming = input.ReadBool();
					break;
				case 48u:
					ServerStreaming = input.ReadBool();
					break;
				}
			}
		}
	}
	internal sealed class FileOptions : IMessage<FileOptions>, IMessage, IEquatable<FileOptions>, IDeepCloneable<FileOptions>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum OptimizeMode
			{
				[OriginalName("SPEED")]
				Speed = 1,
				[OriginalName("CODE_SIZE")]
				CodeSize,
				[OriginalName("LITE_RUNTIME")]
				LiteRuntime
			}
		}

		private static readonly MessageParser<FileOptions> _parser = new MessageParser<FileOptions>(() => new FileOptions());

		public const int JavaPackageFieldNumber = 1;

		private string javaPackage_ = "";

		public const int JavaOuterClassnameFieldNumber = 8;

		private string javaOuterClassname_ = "";

		public const int JavaMultipleFilesFieldNumber = 10;

		private bool javaMultipleFiles_;

		public const int JavaGenerateEqualsAndHashFieldNumber = 20;

		private bool javaGenerateEqualsAndHash_;

		public const int JavaStringCheckUtf8FieldNumber = 27;

		private bool javaStringCheckUtf8_;

		public const int OptimizeForFieldNumber = 9;

		private Types.OptimizeMode optimizeFor_;

		public const int GoPackageFieldNumber = 11;

		private string goPackage_ = "";

		public const int CcGenericServicesFieldNumber = 16;

		private bool ccGenericServices_;

		public const int JavaGenericServicesFieldNumber = 17;

		private bool javaGenericServices_;

		public const int PyGenericServicesFieldNumber = 18;

		private bool pyGenericServices_;

		public const int DeprecatedFieldNumber = 23;

		private bool deprecated_;

		public const int CcEnableArenasFieldNumber = 31;

		private bool ccEnableArenas_;

		public const int ObjcClassPrefixFieldNumber = 36;

		private string objcClassPrefix_ = "";

		public const int CsharpNamespaceFieldNumber = 37;

		private string csharpNamespace_ = "";

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		[DebuggerNonUserCode]
		public static MessageParser<FileOptions> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[9];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public string JavaPackage
		{
			get
			{
				return javaPackage_;
			}
			set
			{
				javaPackage_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public string JavaOuterClassname
		{
			get
			{
				return javaOuterClassname_;
			}
			set
			{
				javaOuterClassname_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public bool JavaMultipleFiles
		{
			get
			{
				return javaMultipleFiles_;
			}
			set
			{
				javaMultipleFiles_ = value;
			}
		}

		[Obsolete]
		[DebuggerNonUserCode]
		public bool JavaGenerateEqualsAndHash
		{
			get
			{
				return javaGenerateEqualsAndHash_;
			}
			set
			{
				javaGenerateEqualsAndHash_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool JavaStringCheckUtf8
		{
			get
			{
				return javaStringCheckUtf8_;
			}
			set
			{
				javaStringCheckUtf8_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Types.OptimizeMode OptimizeFor
		{
			get
			{
				return optimizeFor_;
			}
			set
			{
				optimizeFor_ = value;
			}
		}

		[DebuggerNonUserCode]
		public string GoPackage
		{
			get
			{
				return goPackage_;
			}
			set
			{
				goPackage_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public bool CcGenericServices
		{
			get
			{
				return ccGenericServices_;
			}
			set
			{
				ccGenericServices_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool JavaGenericServices
		{
			get
			{
				return javaGenericServices_;
			}
			set
			{
				javaGenericServices_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool PyGenericServices
		{
			get
			{
				return pyGenericServices_;
			}
			set
			{
				pyGenericServices_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool Deprecated
		{
			get
			{
				return deprecated_;
			}
			set
			{
				deprecated_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool CcEnableArenas
		{
			get
			{
				return ccEnableArenas_;
			}
			set
			{
				ccEnableArenas_ = value;
			}
		}

		[DebuggerNonUserCode]
		public string ObjcClassPrefix
		{
			get
			{
				return objcClassPrefix_;
			}
			set
			{
				objcClassPrefix_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public string CsharpNamespace
		{
			get
			{
				return csharpNamespace_;
			}
			set
			{
				csharpNamespace_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

		[DebuggerNonUserCode]
		public FileOptions()
		{
		}

		[DebuggerNonUserCode]
		public FileOptions(FileOptions other)
			: this()
		{
			javaPackage_ = other.javaPackage_;
			javaOuterClassname_ = other.javaOuterClassname_;
			javaMultipleFiles_ = other.javaMultipleFiles_;
			javaGenerateEqualsAndHash_ = other.javaGenerateEqualsAndHash_;
			javaStringCheckUtf8_ = other.javaStringCheckUtf8_;
			optimizeFor_ = other.optimizeFor_;
			goPackage_ = other.goPackage_;
			ccGenericServices_ = other.ccGenericServices_;
			javaGenericServices_ = other.javaGenericServices_;
			pyGenericServices_ = other.pyGenericServices_;
			deprecated_ = other.deprecated_;
			ccEnableArenas_ = other.ccEnableArenas_;
			objcClassPrefix_ = other.objcClassPrefix_;
			csharpNamespace_ = other.csharpNamespace_;
			uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		[DebuggerNonUserCode]
		public FileOptions Clone()
		{
			return new FileOptions(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as FileOptions);
		}

		[DebuggerNonUserCode]
		public bool Equals(FileOptions other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (JavaPackage != other.JavaPackage)
			{
				return false;
			}
			if (JavaOuterClassname != other.JavaOuterClassname)
			{
				return false;
			}
			if (JavaMultipleFiles != other.JavaMultipleFiles)
			{
				return false;
			}
			if (JavaGenerateEqualsAndHash != other.JavaGenerateEqualsAndHash)
			{
				return false;
			}
			if (JavaStringCheckUtf8 != other.JavaStringCheckUtf8)
			{
				return false;
			}
			if (OptimizeFor != other.OptimizeFor)
			{
				return false;
			}
			if (GoPackage != other.GoPackage)
			{
				return false;
			}
			if (CcGenericServices != other.CcGenericServices)
			{
				return false;
			}
			if (JavaGenericServices != other.JavaGenericServices)
			{
				return false;
			}
			if (PyGenericServices != other.PyGenericServices)
			{
				return false;
			}
			if (Deprecated != other.Deprecated)
			{
				return false;
			}
			if (CcEnableArenas != other.CcEnableArenas)
			{
				return false;
			}
			if (ObjcClassPrefix != other.ObjcClassPrefix)
			{
				return false;
			}
			if (CsharpNamespace != other.CsharpNamespace)
			{
				return false;
			}
			if (!uninterpretedOption_.Equals(other.uninterpretedOption_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (JavaPackage.Length != 0)
			{
				num ^= JavaPackage.GetHashCode();
			}
			if (JavaOuterClassname.Length != 0)
			{
				num ^= JavaOuterClassname.GetHashCode();
			}
			if (JavaMultipleFiles)
			{
				num ^= JavaMultipleFiles.GetHashCode();
			}
			if (JavaGenerateEqualsAndHash)
			{
				num ^= JavaGenerateEqualsAndHash.GetHashCode();
			}
			if (JavaStringCheckUtf8)
			{
				num ^= JavaStringCheckUtf8.GetHashCode();
			}
			if (OptimizeFor != 0)
			{
				num ^= OptimizeFor.GetHashCode();
			}
			if (GoPackage.Length != 0)
			{
				num ^= GoPackage.GetHashCode();
			}
			if (CcGenericServices)
			{
				num ^= CcGenericServices.GetHashCode();
			}
			if (JavaGenericServices)
			{
				num ^= JavaGenericServices.GetHashCode();
			}
			if (PyGenericServices)
			{
				num ^= PyGenericServices.GetHashCode();
			}
			if (Deprecated)
			{
				num ^= Deprecated.GetHashCode();
			}
			if (CcEnableArenas)
			{
				num ^= CcEnableArenas.GetHashCode();
			}
			if (ObjcClassPrefix.Length != 0)
			{
				num ^= ObjcClassPrefix.GetHashCode();
			}
			if (CsharpNamespace.Length != 0)
			{
				num ^= CsharpNamespace.GetHashCode();
			}
			return num ^ uninterpretedOption_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (JavaPackage.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(JavaPackage);
			}
			if (JavaOuterClassname.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(JavaOuterClassname);
			}
			if (OptimizeFor != 0)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)OptimizeFor);
			}
			if (JavaMultipleFiles)
			{
				output.WriteRawTag(80);
				output.WriteBool(JavaMultipleFiles);
			}
			if (GoPackage.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(GoPackage);
			}
			if (CcGenericServices)
			{
				output.WriteRawTag(128, 1);
				output.WriteBool(CcGenericServices);
			}
			if (JavaGenericServices)
			{
				output.WriteRawTag(136, 1);
				output.WriteBool(JavaGenericServices);
			}
			if (PyGenericServices)
			{
				output.WriteRawTag(144, 1);
				output.WriteBool(PyGenericServices);
			}
			if (JavaGenerateEqualsAndHash)
			{
				output.WriteRawTag(160, 1);
				output.WriteBool(JavaGenerateEqualsAndHash);
			}
			if (Deprecated)
			{
				output.WriteRawTag(184, 1);
				output.WriteBool(Deprecated);
			}
			if (JavaStringCheckUtf8)
			{
				output.WriteRawTag(216, 1);
				output.WriteBool(JavaStringCheckUtf8);
			}
			if (CcEnableArenas)
			{
				output.WriteRawTag(248, 1);
				output.WriteBool(CcEnableArenas);
			}
			if (ObjcClassPrefix.Length != 0)
			{
				output.WriteRawTag(162, 2);
				output.WriteString(ObjcClassPrefix);
			}
			if (CsharpNamespace.Length != 0)
			{
				output.WriteRawTag(170, 2);
				output.WriteString(CsharpNamespace);
			}
			uninterpretedOption_.WriteTo(output, _repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (JavaPackage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(JavaPackage);
			}
			if (JavaOuterClassname.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(JavaOuterClassname);
			}
			if (JavaMultipleFiles)
			{
				num += 2;
			}
			if (JavaGenerateEqualsAndHash)
			{
				num += 3;
			}
			if (JavaStringCheckUtf8)
			{
				num += 3;
			}
			if (OptimizeFor != 0)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)OptimizeFor);
			}
			if (GoPackage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(GoPackage);
			}
			if (CcGenericServices)
			{
				num += 3;
			}
			if (JavaGenericServices)
			{
				num += 3;
			}
			if (PyGenericServices)
			{
				num += 3;
			}
			if (Deprecated)
			{
				num += 3;
			}
			if (CcEnableArenas)
			{
				num += 3;
			}
			if (ObjcClassPrefix.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(ObjcClassPrefix);
			}
			if (CsharpNamespace.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(CsharpNamespace);
			}
			return num + uninterpretedOption_.CalculateSize(_repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(FileOptions other)
		{
			if (other != null)
			{
				if (other.JavaPackage.Length != 0)
				{
					JavaPackage = other.JavaPackage;
				}
				if (other.JavaOuterClassname.Length != 0)
				{
					JavaOuterClassname = other.JavaOuterClassname;
				}
				if (other.JavaMultipleFiles)
				{
					JavaMultipleFiles = other.JavaMultipleFiles;
				}
				if (other.JavaGenerateEqualsAndHash)
				{
					JavaGenerateEqualsAndHash = other.JavaGenerateEqualsAndHash;
				}
				if (other.JavaStringCheckUtf8)
				{
					JavaStringCheckUtf8 = other.JavaStringCheckUtf8;
				}
				if (other.OptimizeFor != 0)
				{
					OptimizeFor = other.OptimizeFor;
				}
				if (other.GoPackage.Length != 0)
				{
					GoPackage = other.GoPackage;
				}
				if (other.CcGenericServices)
				{
					CcGenericServices = other.CcGenericServices;
				}
				if (other.JavaGenericServices)
				{
					JavaGenericServices = other.JavaGenericServices;
				}
				if (other.PyGenericServices)
				{
					PyGenericServices = other.PyGenericServices;
				}
				if (other.Deprecated)
				{
					Deprecated = other.Deprecated;
				}
				if (other.CcEnableArenas)
				{
					CcEnableArenas = other.CcEnableArenas;
				}
				if (other.ObjcClassPrefix.Length != 0)
				{
					ObjcClassPrefix = other.ObjcClassPrefix;
				}
				if (other.CsharpNamespace.Length != 0)
				{
					CsharpNamespace = other.CsharpNamespace;
				}
				uninterpretedOption_.Add(other.uninterpretedOption_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 10u:
					JavaPackage = input.ReadString();
					break;
				case 66u:
					JavaOuterClassname = input.ReadString();
					break;
				case 72u:
					optimizeFor_ = (Types.OptimizeMode)input.ReadEnum();
					break;
				case 80u:
					JavaMultipleFiles = input.ReadBool();
					break;
				case 90u:
					GoPackage = input.ReadString();
					break;
				case 128u:
					CcGenericServices = input.ReadBool();
					break;
				case 136u:
					JavaGenericServices = input.ReadBool();
					break;
				case 144u:
					PyGenericServices = input.ReadBool();
					break;
				case 160u:
					JavaGenerateEqualsAndHash = input.ReadBool();
					break;
				case 184u:
					Deprecated = input.ReadBool();
					break;
				case 216u:
					JavaStringCheckUtf8 = input.ReadBool();
					break;
				case 248u:
					CcEnableArenas = input.ReadBool();
					break;
				case 290u:
					ObjcClassPrefix = input.ReadString();
					break;
				case 298u:
					CsharpNamespace = input.ReadString();
					break;
				case 7994u:
					uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
					break;
				}
			}
		}
	}
	internal sealed class MessageOptions : IMessage<MessageOptions>, IMessage, IEquatable<MessageOptions>, IDeepCloneable<MessageOptions>
	{
		private static readonly MessageParser<MessageOptions> _parser = new MessageParser<MessageOptions>(() => new MessageOptions());

		public const int MessageSetWireFormatFieldNumber = 1;

		private bool messageSetWireFormat_;

		public const int NoStandardDescriptorAccessorFieldNumber = 2;

		private bool noStandardDescriptorAccessor_;

		public const int DeprecatedFieldNumber = 3;

		private bool deprecated_;

		public const int MapEntryFieldNumber = 7;

		private bool mapEntry_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		[DebuggerNonUserCode]
		public static MessageParser<MessageOptions> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[10];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public bool MessageSetWireFormat
		{
			get
			{
				return messageSetWireFormat_;
			}
			set
			{
				messageSetWireFormat_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool NoStandardDescriptorAccessor
		{
			get
			{
				return noStandardDescriptorAccessor_;
			}
			set
			{
				noStandardDescriptorAccessor_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool Deprecated
		{
			get
			{
				return deprecated_;
			}
			set
			{
				deprecated_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool MapEntry
		{
			get
			{
				return mapEntry_;
			}
			set
			{
				mapEntry_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

		[DebuggerNonUserCode]
		public MessageOptions()
		{
		}

		[DebuggerNonUserCode]
		public MessageOptions(MessageOptions other)
			: this()
		{
			messageSetWireFormat_ = other.messageSetWireFormat_;
			noStandardDescriptorAccessor_ = other.noStandardDescriptorAccessor_;
			deprecated_ = other.deprecated_;
			mapEntry_ = other.mapEntry_;
			uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		[DebuggerNonUserCode]
		public MessageOptions Clone()
		{
			return new MessageOptions(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as MessageOptions);
		}

		[DebuggerNonUserCode]
		public bool Equals(MessageOptions other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (MessageSetWireFormat != other.MessageSetWireFormat)
			{
				return false;
			}
			if (NoStandardDescriptorAccessor != other.NoStandardDescriptorAccessor)
			{
				return false;
			}
			if (Deprecated != other.Deprecated)
			{
				return false;
			}
			if (MapEntry != other.MapEntry)
			{
				return false;
			}
			if (!uninterpretedOption_.Equals(other.uninterpretedOption_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (MessageSetWireFormat)
			{
				num ^= MessageSetWireFormat.GetHashCode();
			}
			if (NoStandardDescriptorAccessor)
			{
				num ^= NoStandardDescriptorAccessor.GetHashCode();
			}
			if (Deprecated)
			{
				num ^= Deprecated.GetHashCode();
			}
			if (MapEntry)
			{
				num ^= MapEntry.GetHashCode();
			}
			return num ^ uninterpretedOption_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (MessageSetWireFormat)
			{
				output.WriteRawTag(8);
				output.WriteBool(MessageSetWireFormat);
			}
			if (NoStandardDescriptorAccessor)
			{
				output.WriteRawTag(16);
				output.WriteBool(NoStandardDescriptorAccessor);
			}
			if (Deprecated)
			{
				output.WriteRawTag(24);
				output.WriteBool(Deprecated);
			}
			if (MapEntry)
			{
				output.WriteRawTag(56);
				output.WriteBool(MapEntry);
			}
			uninterpretedOption_.WriteTo(output, _repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (MessageSetWireFormat)
			{
				num += 2;
			}
			if (NoStandardDescriptorAccessor)
			{
				num += 2;
			}
			if (Deprecated)
			{
				num += 2;
			}
			if (MapEntry)
			{
				num += 2;
			}
			return num + uninterpretedOption_.CalculateSize(_repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MessageOptions other)
		{
			if (other != null)
			{
				if (other.MessageSetWireFormat)
				{
					MessageSetWireFormat = other.MessageSetWireFormat;
				}
				if (other.NoStandardDescriptorAccessor)
				{
					NoStandardDescriptorAccessor = other.NoStandardDescriptorAccessor;
				}
				if (other.Deprecated)
				{
					Deprecated = other.Deprecated;
				}
				if (other.MapEntry)
				{
					MapEntry = other.MapEntry;
				}
				uninterpretedOption_.Add(other.uninterpretedOption_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 8u:
					MessageSetWireFormat = input.ReadBool();
					break;
				case 16u:
					NoStandardDescriptorAccessor = input.ReadBool();
					break;
				case 24u:
					Deprecated = input.ReadBool();
					break;
				case 56u:
					MapEntry = input.ReadBool();
					break;
				case 7994u:
					uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
					break;
				}
			}
		}
	}
	internal sealed class FieldOptions : IMessage<FieldOptions>, IMessage, IEquatable<FieldOptions>, IDeepCloneable<FieldOptions>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum CType
			{
				[OriginalName("STRING")]
				String,
				[OriginalName("CORD")]
				Cord,
				[OriginalName("STRING_PIECE")]
				StringPiece
			}

			internal enum JSType
			{
				[OriginalName("JS_NORMAL")]
				JsNormal,
				[OriginalName("JS_STRING")]
				JsString,
				[OriginalName("JS_NUMBER")]
				JsNumber
			}
		}

		private static readonly MessageParser<FieldOptions> _parser = new MessageParser<FieldOptions>(() => new FieldOptions());

		public const int CtypeFieldNumber = 1;

		private Types.CType ctype_;

		public const int PackedFieldNumber = 2;

		private bool packed_;

		public const int JstypeFieldNumber = 6;

		private Types.JSType jstype_;

		public const int LazyFieldNumber = 5;

		private bool lazy_;

		public const int DeprecatedFieldNumber = 3;

		private bool deprecated_;

		public const int WeakFieldNumber = 10;

		private bool weak_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		[DebuggerNonUserCode]
		public static MessageParser<FieldOptions> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[11];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public Types.CType Ctype
		{
			get
			{
				return ctype_;
			}
			set
			{
				ctype_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool Packed
		{
			get
			{
				return packed_;
			}
			set
			{
				packed_ = value;
			}
		}

		[DebuggerNonUserCode]
		public Types.JSType Jstype
		{
			get
			{
				return jstype_;
			}
			set
			{
				jstype_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool Lazy
		{
			get
			{
				return lazy_;
			}
			set
			{
				lazy_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool Deprecated
		{
			get
			{
				return deprecated_;
			}
			set
			{
				deprecated_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool Weak
		{
			get
			{
				return weak_;
			}
			set
			{
				weak_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

		[DebuggerNonUserCode]
		public FieldOptions()
		{
			OnConstruction();
		}

		private void OnConstruction()
		{
			Packed = true;
		}

		[DebuggerNonUserCode]
		public FieldOptions(FieldOptions other)
			: this()
		{
			ctype_ = other.ctype_;
			packed_ = other.packed_;
			jstype_ = other.jstype_;
			lazy_ = other.lazy_;
			deprecated_ = other.deprecated_;
			weak_ = other.weak_;
			uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		[DebuggerNonUserCode]
		public FieldOptions Clone()
		{
			return new FieldOptions(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as FieldOptions);
		}

		[DebuggerNonUserCode]
		public bool Equals(FieldOptions other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Ctype != other.Ctype)
			{
				return false;
			}
			if (Packed != other.Packed)
			{
				return false;
			}
			if (Jstype != other.Jstype)
			{
				return false;
			}
			if (Lazy != other.Lazy)
			{
				return false;
			}
			if (Deprecated != other.Deprecated)
			{
				return false;
			}
			if (Weak != other.Weak)
			{
				return false;
			}
			if (!uninterpretedOption_.Equals(other.uninterpretedOption_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Ctype != Types.CType.String)
			{
				num ^= Ctype.GetHashCode();
			}
			if (Packed)
			{
				num ^= Packed.GetHashCode();
			}
			if (Jstype != Types.JSType.JsNormal)
			{
				num ^= Jstype.GetHashCode();
			}
			if (Lazy)
			{
				num ^= Lazy.GetHashCode();
			}
			if (Deprecated)
			{
				num ^= Deprecated.GetHashCode();
			}
			if (Weak)
			{
				num ^= Weak.GetHashCode();
			}
			return num ^ uninterpretedOption_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Ctype != Types.CType.String)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)Ctype);
			}
			if (Packed)
			{
				output.WriteRawTag(16);
				output.WriteBool(Packed);
			}
			if (Deprecated)
			{
				output.WriteRawTag(24);
				output.WriteBool(Deprecated);
			}
			if (Lazy)
			{
				output.WriteRawTag(40);
				output.WriteBool(Lazy);
			}
			if (Jstype != Types.JSType.JsNormal)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)Jstype);
			}
			if (Weak)
			{
				output.WriteRawTag(80);
				output.WriteBool(Weak);
			}
			uninterpretedOption_.WriteTo(output, _repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Ctype != Types.CType.String)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)Ctype);
			}
			if (Packed)
			{
				num += 2;
			}
			if (Jstype != Types.JSType.JsNormal)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)Jstype);
			}
			if (Lazy)
			{
				num += 2;
			}
			if (Deprecated)
			{
				num += 2;
			}
			if (Weak)
			{
				num += 2;
			}
			return num + uninterpretedOption_.CalculateSize(_repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(FieldOptions other)
		{
			if (other != null)
			{
				if (other.Ctype != Types.CType.String)
				{
					Ctype = other.Ctype;
				}
				if (other.Packed)
				{
					Packed = other.Packed;
				}
				if (other.Jstype != Types.JSType.JsNormal)
				{
					Jstype = other.Jstype;
				}
				if (other.Lazy)
				{
					Lazy = other.Lazy;
				}
				if (other.Deprecated)
				{
					Deprecated = other.Deprecated;
				}
				if (other.Weak)
				{
					Weak = other.Weak;
				}
				uninterpretedOption_.Add(other.uninterpretedOption_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 8u:
					ctype_ = (Types.CType)input.ReadEnum();
					break;
				case 16u:
					Packed = input.ReadBool();
					break;
				case 24u:
					Deprecated = input.ReadBool();
					break;
				case 40u:
					Lazy = input.ReadBool();
					break;
				case 48u:
					jstype_ = (Types.JSType)input.ReadEnum();
					break;
				case 80u:
					Weak = input.ReadBool();
					break;
				case 7994u:
					uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
					break;
				}
			}
		}
	}
	internal sealed class OneofOptions : IMessage<OneofOptions>, IMessage, IEquatable<OneofOptions>, IDeepCloneable<OneofOptions>
	{
		private static readonly MessageParser<OneofOptions> _parser = new MessageParser<OneofOptions>(() => new OneofOptions());

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		[DebuggerNonUserCode]
		public static MessageParser<OneofOptions> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[12];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

		[DebuggerNonUserCode]
		public OneofOptions()
		{
		}

		[DebuggerNonUserCode]
		public OneofOptions(OneofOptions other)
			: this()
		{
			uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		[DebuggerNonUserCode]
		public OneofOptions Clone()
		{
			return new OneofOptions(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as OneofOptions);
		}

		[DebuggerNonUserCode]
		public bool Equals(OneofOptions other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (!uninterpretedOption_.Equals(other.uninterpretedOption_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 1 ^ uninterpretedOption_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			uninterpretedOption_.WriteTo(output, _repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0 + uninterpretedOption_.CalculateSize(_repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(OneofOptions other)
		{
			if (other != null)
			{
				uninterpretedOption_.Add(other.uninterpretedOption_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 7994)
				{
					input.SkipLastField();
				}
				else
				{
					uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
				}
			}
		}
	}
	internal sealed class EnumOptions : IMessage<EnumOptions>, IMessage, IEquatable<EnumOptions>, IDeepCloneable<EnumOptions>
	{
		private static readonly MessageParser<EnumOptions> _parser = new MessageParser<EnumOptions>(() => new EnumOptions());

		public const int AllowAliasFieldNumber = 2;

		private bool allowAlias_;

		public const int DeprecatedFieldNumber = 3;

		private bool deprecated_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		[DebuggerNonUserCode]
		public static MessageParser<EnumOptions> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[13];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public bool AllowAlias
		{
			get
			{
				return allowAlias_;
			}
			set
			{
				allowAlias_ = value;
			}
		}

		[DebuggerNonUserCode]
		public bool Deprecated
		{
			get
			{
				return deprecated_;
			}
			set
			{
				deprecated_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

		[DebuggerNonUserCode]
		public EnumOptions()
		{
		}

		[DebuggerNonUserCode]
		public EnumOptions(EnumOptions other)
			: this()
		{
			allowAlias_ = other.allowAlias_;
			deprecated_ = other.deprecated_;
			uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		[DebuggerNonUserCode]
		public EnumOptions Clone()
		{
			return new EnumOptions(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as EnumOptions);
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumOptions other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (AllowAlias != other.AllowAlias)
			{
				return false;
			}
			if (Deprecated != other.Deprecated)
			{
				return false;
			}
			if (!uninterpretedOption_.Equals(other.uninterpretedOption_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (AllowAlias)
			{
				num ^= AllowAlias.GetHashCode();
			}
			if (Deprecated)
			{
				num ^= Deprecated.GetHashCode();
			}
			return num ^ uninterpretedOption_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (AllowAlias)
			{
				output.WriteRawTag(16);
				output.WriteBool(AllowAlias);
			}
			if (Deprecated)
			{
				output.WriteRawTag(24);
				output.WriteBool(Deprecated);
			}
			uninterpretedOption_.WriteTo(output, _repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (AllowAlias)
			{
				num += 2;
			}
			if (Deprecated)
			{
				num += 2;
			}
			return num + uninterpretedOption_.CalculateSize(_repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(EnumOptions other)
		{
			if (other != null)
			{
				if (other.AllowAlias)
				{
					AllowAlias = other.AllowAlias;
				}
				if (other.Deprecated)
				{
					Deprecated = other.Deprecated;
				}
				uninterpretedOption_.Add(other.uninterpretedOption_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 16u:
					AllowAlias = input.ReadBool();
					break;
				case 24u:
					Deprecated = input.ReadBool();
					break;
				case 7994u:
					uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
					break;
				}
			}
		}
	}
	internal sealed class EnumValueOptions : IMessage<EnumValueOptions>, IMessage, IEquatable<EnumValueOptions>, IDeepCloneable<EnumValueOptions>
	{
		private static readonly MessageParser<EnumValueOptions> _parser = new MessageParser<EnumValueOptions>(() => new EnumValueOptions());

		public const int DeprecatedFieldNumber = 1;

		private bool deprecated_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		[DebuggerNonUserCode]
		public static MessageParser<EnumValueOptions> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[14];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public bool Deprecated
		{
			get
			{
				return deprecated_;
			}
			set
			{
				deprecated_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

		[DebuggerNonUserCode]
		public EnumValueOptions()
		{
		}

		[DebuggerNonUserCode]
		public EnumValueOptions(EnumValueOptions other)
			: this()
		{
			deprecated_ = other.deprecated_;
			uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		[DebuggerNonUserCode]
		public EnumValueOptions Clone()
		{
			return new EnumValueOptions(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as EnumValueOptions);
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumValueOptions other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Deprecated != other.Deprecated)
			{
				return false;
			}
			if (!uninterpretedOption_.Equals(other.uninterpretedOption_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Deprecated)
			{
				num ^= Deprecated.GetHashCode();
			}
			return num ^ uninterpretedOption_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Deprecated)
			{
				output.WriteRawTag(8);
				output.WriteBool(Deprecated);
			}
			uninterpretedOption_.WriteTo(output, _repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Deprecated)
			{
				num += 2;
			}
			return num + uninterpretedOption_.CalculateSize(_repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(EnumValueOptions other)
		{
			if (other != null)
			{
				if (other.Deprecated)
				{
					Deprecated = other.Deprecated;
				}
				uninterpretedOption_.Add(other.uninterpretedOption_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 8u:
					Deprecated = input.ReadBool();
					break;
				case 7994u:
					uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
					break;
				}
			}
		}
	}
	internal sealed class ServiceOptions : IMessage<ServiceOptions>, IMessage, IEquatable<ServiceOptions>, IDeepCloneable<ServiceOptions>
	{
		private static readonly MessageParser<ServiceOptions> _parser = new MessageParser<ServiceOptions>(() => new ServiceOptions());

		public const int DeprecatedFieldNumber = 33;

		private bool deprecated_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		[DebuggerNonUserCode]
		public static MessageParser<ServiceOptions> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[15];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public bool Deprecated
		{
			get
			{
				return deprecated_;
			}
			set
			{
				deprecated_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

		[DebuggerNonUserCode]
		public ServiceOptions()
		{
		}

		[DebuggerNonUserCode]
		public ServiceOptions(ServiceOptions other)
			: this()
		{
			deprecated_ = other.deprecated_;
			uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		[DebuggerNonUserCode]
		public ServiceOptions Clone()
		{
			return new ServiceOptions(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as ServiceOptions);
		}

		[DebuggerNonUserCode]
		public bool Equals(ServiceOptions other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Deprecated != other.Deprecated)
			{
				return false;
			}
			if (!uninterpretedOption_.Equals(other.uninterpretedOption_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Deprecated)
			{
				num ^= Deprecated.GetHashCode();
			}
			return num ^ uninterpretedOption_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Deprecated)
			{
				output.WriteRawTag(136, 2);
				output.WriteBool(Deprecated);
			}
			uninterpretedOption_.WriteTo(output, _repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Deprecated)
			{
				num += 3;
			}
			return num + uninterpretedOption_.CalculateSize(_repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(ServiceOptions other)
		{
			if (other != null)
			{
				if (other.Deprecated)
				{
					Deprecated = other.Deprecated;
				}
				uninterpretedOption_.Add(other.uninterpretedOption_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 264u:
					Deprecated = input.ReadBool();
					break;
				case 7994u:
					uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
					break;
				}
			}
		}
	}
	internal sealed class MethodOptions : IMessage<MethodOptions>, IMessage, IEquatable<MethodOptions>, IDeepCloneable<MethodOptions>
	{
		private static readonly MessageParser<MethodOptions> _parser = new MessageParser<MethodOptions>(() => new MethodOptions());

		public const int DeprecatedFieldNumber = 33;

		private bool deprecated_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		[DebuggerNonUserCode]
		public static MessageParser<MethodOptions> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[16];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public bool Deprecated
		{
			get
			{
				return deprecated_;
			}
			set
			{
				deprecated_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

		[DebuggerNonUserCode]
		public MethodOptions()
		{
		}

		[DebuggerNonUserCode]
		public MethodOptions(MethodOptions other)
			: this()
		{
			deprecated_ = other.deprecated_;
			uninterpretedOption_ = other.uninterpretedOption_.Clone();
		}

		[DebuggerNonUserCode]
		public MethodOptions Clone()
		{
			return new MethodOptions(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as MethodOptions);
		}

		[DebuggerNonUserCode]
		public bool Equals(MethodOptions other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (Deprecated != other.Deprecated)
			{
				return false;
			}
			if (!uninterpretedOption_.Equals(other.uninterpretedOption_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (Deprecated)
			{
				num ^= Deprecated.GetHashCode();
			}
			return num ^ uninterpretedOption_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (Deprecated)
			{
				output.WriteRawTag(136, 2);
				output.WriteBool(Deprecated);
			}
			uninterpretedOption_.WriteTo(output, _repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (Deprecated)
			{
				num += 3;
			}
			return num + uninterpretedOption_.CalculateSize(_repeated_uninterpretedOption_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MethodOptions other)
		{
			if (other != null)
			{
				if (other.Deprecated)
				{
					Deprecated = other.Deprecated;
				}
				uninterpretedOption_.Add(other.uninterpretedOption_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 264u:
					Deprecated = input.ReadBool();
					break;
				case 7994u:
					uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
					break;
				}
			}
		}
	}
	internal sealed class UninterpretedOption : IMessage<UninterpretedOption>, IMessage, IEquatable<UninterpretedOption>, IDeepCloneable<UninterpretedOption>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal sealed class NamePart : IMessage<NamePart>, IMessage, IEquatable<NamePart>, IDeepCloneable<NamePart>
			{
				private static readonly MessageParser<NamePart> _parser = new MessageParser<NamePart>(() => new NamePart());

				public const int NamePart_FieldNumber = 1;

				private string namePart_ = "";

				public const int IsExtensionFieldNumber = 2;

				private bool isExtension_;

				[DebuggerNonUserCode]
				public static MessageParser<NamePart> Parser => _parser;

				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor => UninterpretedOption.Descriptor.NestedTypes[0];

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor => Descriptor;

				[DebuggerNonUserCode]
				public string NamePart_
				{
					get
					{
						return namePart_;
					}
					set
					{
						namePart_ = ProtoPreconditions.CheckNotNull(value, "value");
					}
				}

				[DebuggerNonUserCode]
				public bool IsExtension
				{
					get
					{
						return isExtension_;
					}
					set
					{
						isExtension_ = value;
					}
				}

				[DebuggerNonUserCode]
				public NamePart()
				{
				}

				[DebuggerNonUserCode]
				public NamePart(NamePart other)
					: this()
				{
					namePart_ = other.namePart_;
					isExtension_ = other.isExtension_;
				}

				[DebuggerNonUserCode]
				public NamePart Clone()
				{
					return new NamePart(this);
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return Equals(other as NamePart);
				}

				[DebuggerNonUserCode]
				public bool Equals(NamePart other)
				{
					if (other == null)
					{
						return false;
					}
					if (other == this)
					{
						return true;
					}
					if (NamePart_ != other.NamePart_)
					{
						return false;
					}
					if (IsExtension != other.IsExtension)
					{
						return false;
					}
					return true;
				}

				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					if (NamePart_.Length != 0)
					{
						num ^= NamePart_.GetHashCode();
					}
					if (IsExtension)
					{
						num ^= IsExtension.GetHashCode();
					}
					return num;
				}

				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					if (NamePart_.Length != 0)
					{
						output.WriteRawTag(10);
						output.WriteString(NamePart_);
					}
					if (IsExtension)
					{
						output.WriteRawTag(16);
						output.WriteBool(IsExtension);
					}
				}

				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					if (NamePart_.Length != 0)
					{
						num += 1 + CodedOutputStream.ComputeStringSize(NamePart_);
					}
					if (IsExtension)
					{
						num += 2;
					}
					return num;
				}

				[DebuggerNonUserCode]
				public void MergeFrom(NamePart other)
				{
					if (other != null)
					{
						if (other.NamePart_.Length != 0)
						{
							NamePart_ = other.NamePart_;
						}
						if (other.IsExtension)
						{
							IsExtension = other.IsExtension;
						}
					}
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					uint num;
					while ((num = input.ReadTag()) != 0)
					{
						switch (num)
						{
						default:
							input.SkipLastField();
							break;
						case 10u:
							NamePart_ = input.ReadString();
							break;
						case 16u:
							IsExtension = input.ReadBool();
							break;
						}
					}
				}
			}
		}

		private static readonly MessageParser<UninterpretedOption> _parser = new MessageParser<UninterpretedOption>(() => new UninterpretedOption());

		public const int NameFieldNumber = 2;

		private static readonly FieldCodec<Types.NamePart> _repeated_name_codec = FieldCodec.ForMessage(18u, Types.NamePart.Parser);

		private readonly RepeatedField<Types.NamePart> name_ = new RepeatedField<Types.NamePart>();

		public const int IdentifierValueFieldNumber = 3;

		private string identifierValue_ = "";

		public const int PositiveIntValueFieldNumber = 4;

		private ulong positiveIntValue_;

		public const int NegativeIntValueFieldNumber = 5;

		private long negativeIntValue_;

		public const int DoubleValueFieldNumber = 6;

		private double doubleValue_;

		public const int StringValueFieldNumber = 7;

		private ByteString stringValue_ = ByteString.Empty;

		public const int AggregateValueFieldNumber = 8;

		private string aggregateValue_ = "";

		[DebuggerNonUserCode]
		public static MessageParser<UninterpretedOption> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[17];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public RepeatedField<Types.NamePart> Name => name_;

		[DebuggerNonUserCode]
		public string IdentifierValue
		{
			get
			{
				return identifierValue_;
			}
			set
			{
				identifierValue_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ulong PositiveIntValue
		{
			get
			{
				return positiveIntValue_;
			}
			set
			{
				positiveIntValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public long NegativeIntValue
		{
			get
			{
				return negativeIntValue_;
			}
			set
			{
				negativeIntValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public double DoubleValue
		{
			get
			{
				return doubleValue_;
			}
			set
			{
				doubleValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString StringValue
		{
			get
			{
				return stringValue_;
			}
			set
			{
				stringValue_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public string AggregateValue
		{
			get
			{
				return aggregateValue_;
			}
			set
			{
				aggregateValue_ = ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public UninterpretedOption()
		{
		}

		[DebuggerNonUserCode]
		public UninterpretedOption(UninterpretedOption other)
			: this()
		{
			name_ = other.name_.Clone();
			identifierValue_ = other.identifierValue_;
			positiveIntValue_ = other.positiveIntValue_;
			negativeIntValue_ = other.negativeIntValue_;
			doubleValue_ = other.doubleValue_;
			stringValue_ = other.stringValue_;
			aggregateValue_ = other.aggregateValue_;
		}

		[DebuggerNonUserCode]
		public UninterpretedOption Clone()
		{
			return new UninterpretedOption(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as UninterpretedOption);
		}

		[DebuggerNonUserCode]
		public bool Equals(UninterpretedOption other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (!name_.Equals(other.name_))
			{
				return false;
			}
			if (IdentifierValue != other.IdentifierValue)
			{
				return false;
			}
			if (PositiveIntValue != other.PositiveIntValue)
			{
				return false;
			}
			if (NegativeIntValue != other.NegativeIntValue)
			{
				return false;
			}
			if (DoubleValue != other.DoubleValue)
			{
				return false;
			}
			if (StringValue != other.StringValue)
			{
				return false;
			}
			if (AggregateValue != other.AggregateValue)
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= name_.GetHashCode();
			if (IdentifierValue.Length != 0)
			{
				num ^= IdentifierValue.GetHashCode();
			}
			if (PositiveIntValue != 0L)
			{
				num ^= PositiveIntValue.GetHashCode();
			}
			if (NegativeIntValue != 0L)
			{
				num ^= NegativeIntValue.GetHashCode();
			}
			if (DoubleValue != 0.0)
			{
				num ^= DoubleValue.GetHashCode();
			}
			if (StringValue.Length != 0)
			{
				num ^= StringValue.GetHashCode();
			}
			if (AggregateValue.Length != 0)
			{
				num ^= AggregateValue.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			name_.WriteTo(output, _repeated_name_codec);
			if (IdentifierValue.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(IdentifierValue);
			}
			if (PositiveIntValue != 0L)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(PositiveIntValue);
			}
			if (NegativeIntValue != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(NegativeIntValue);
			}
			if (DoubleValue != 0.0)
			{
				output.WriteRawTag(49);
				output.WriteDouble(DoubleValue);
			}
			if (StringValue.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(StringValue);
			}
			if (AggregateValue.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(AggregateValue);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += name_.CalculateSize(_repeated_name_codec);
			if (IdentifierValue.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(IdentifierValue);
			}
			if (PositiveIntValue != 0L)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(PositiveIntValue);
			}
			if (NegativeIntValue != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(NegativeIntValue);
			}
			if (DoubleValue != 0.0)
			{
				num += 9;
			}
			if (StringValue.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(StringValue);
			}
			if (AggregateValue.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(AggregateValue);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(UninterpretedOption other)
		{
			if (other != null)
			{
				name_.Add(other.name_);
				if (other.IdentifierValue.Length != 0)
				{
					IdentifierValue = other.IdentifierValue;
				}
				if (other.PositiveIntValue != 0L)
				{
					PositiveIntValue = other.PositiveIntValue;
				}
				if (other.NegativeIntValue != 0L)
				{
					NegativeIntValue = other.NegativeIntValue;
				}
				if (other.DoubleValue != 0.0)
				{
					DoubleValue = other.DoubleValue;
				}
				if (other.StringValue.Length != 0)
				{
					StringValue = other.StringValue;
				}
				if (other.AggregateValue.Length != 0)
				{
					AggregateValue = other.AggregateValue;
				}
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				switch (num)
				{
				default:
					input.SkipLastField();
					break;
				case 18u:
					name_.AddEntriesFrom(input, _repeated_name_codec);
					break;
				case 26u:
					IdentifierValue = input.ReadString();
					break;
				case 32u:
					PositiveIntValue = input.ReadUInt64();
					break;
				case 40u:
					NegativeIntValue = input.ReadInt64();
					break;
				case 49u:
					DoubleValue = input.ReadDouble();
					break;
				case 58u:
					StringValue = input.ReadBytes();
					break;
				case 66u:
					AggregateValue = input.ReadString();
					break;
				}
			}
		}
	}
	internal sealed class SourceCodeInfo : IMessage<SourceCodeInfo>, IMessage, IEquatable<SourceCodeInfo>, IDeepCloneable<SourceCodeInfo>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal sealed class Location : IMessage<Location>, IMessage, IEquatable<Location>, IDeepCloneable<Location>
			{
				private static readonly MessageParser<Location> _parser = new MessageParser<Location>(() => new Location());

				public const int PathFieldNumber = 1;

				private static readonly FieldCodec<int> _repeated_path_codec = FieldCodec.ForInt32(10u);

				private readonly RepeatedField<int> path_ = new RepeatedField<int>();

				public const int SpanFieldNumber = 2;

				private static readonly FieldCodec<int> _repeated_span_codec = FieldCodec.ForInt32(18u);

				private readonly RepeatedField<int> span_ = new RepeatedField<int>();

				public const int LeadingCommentsFieldNumber = 3;

				private string leadingComments_ = "";

				public const int TrailingCommentsFieldNumber = 4;

				private string trailingComments_ = "";

				public const int LeadingDetachedCommentsFieldNumber = 6;

				private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec = FieldCodec.ForString(50u);

				private readonly RepeatedField<string> leadingDetachedComments_ = new RepeatedField<string>();

				[DebuggerNonUserCode]
				public static MessageParser<Location> Parser => _parser;

				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor => SourceCodeInfo.Descriptor.NestedTypes[0];

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor => Descriptor;

				[DebuggerNonUserCode]
				public RepeatedField<int> Path => path_;

				[DebuggerNonUserCode]
				public RepeatedField<int> Span => span_;

				[DebuggerNonUserCode]
				public string LeadingComments
				{
					get
					{
						return leadingComments_;
					}
					set
					{
						leadingComments_ = ProtoPreconditions.CheckNotNull(value, "value");
					}
				}

				[DebuggerNonUserCode]
				public string TrailingComments
				{
					get
					{
						return trailingComments_;
					}
					set
					{
						trailingComments_ = ProtoPreconditions.CheckNotNull(value, "value");
					}
				}

				[DebuggerNonUserCode]
				public RepeatedField<string> LeadingDetachedComments => leadingDetachedComments_;

				[DebuggerNonUserCode]
				public Location()
				{
				}

				[DebuggerNonUserCode]
				public Location(Location other)
					: this()
				{
					path_ = other.path_.Clone();
					span_ = other.span_.Clone();
					leadingComments_ = other.leadingComments_;
					trailingComments_ = other.trailingComments_;
					leadingDetachedComments_ = other.leadingDetachedComments_.Clone();
				}

				[DebuggerNonUserCode]
				public Location Clone()
				{
					return new Location(this);
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return Equals(other as Location);
				}

				[DebuggerNonUserCode]
				public bool Equals(Location other)
				{
					if (other == null)
					{
						return false;
					}
					if (other == this)
					{
						return true;
					}
					if (!path_.Equals(other.path_))
					{
						return false;
					}
					if (!span_.Equals(other.span_))
					{
						return false;
					}
					if (LeadingComments != other.LeadingComments)
					{
						return false;
					}
					if (TrailingComments != other.TrailingComments)
					{
						return false;
					}
					if (!leadingDetachedComments_.Equals(other.leadingDetachedComments_))
					{
						return false;
					}
					return true;
				}

				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					num ^= path_.GetHashCode();
					num ^= span_.GetHashCode();
					if (LeadingComments.Length != 0)
					{
						num ^= LeadingComments.GetHashCode();
					}
					if (TrailingComments.Length != 0)
					{
						num ^= TrailingComments.GetHashCode();
					}
					return num ^ leadingDetachedComments_.GetHashCode();
				}

				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					path_.WriteTo(output, _repeated_path_codec);
					span_.WriteTo(output, _repeated_span_codec);
					if (LeadingComments.Length != 0)
					{
						output.WriteRawTag(26);
						output.WriteString(LeadingComments);
					}
					if (TrailingComments.Length != 0)
					{
						output.WriteRawTag(34);
						output.WriteString(TrailingComments);
					}
					leadingDetachedComments_.WriteTo(output, _repeated_leadingDetachedComments_codec);
				}

				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					num += path_.CalculateSize(_repeated_path_codec);
					num += span_.CalculateSize(_repeated_span_codec);
					if (LeadingComments.Length != 0)
					{
						num += 1 + CodedOutputStream.ComputeStringSize(LeadingComments);
					}
					if (TrailingComments.Length != 0)
					{
						num += 1 + CodedOutputStream.ComputeStringSize(TrailingComments);
					}
					return num + leadingDetachedComments_.CalculateSize(_repeated_leadingDetachedComments_codec);
				}

				[DebuggerNonUserCode]
				public void MergeFrom(Location other)
				{
					if (other != null)
					{
						path_.Add(other.path_);
						span_.Add(other.span_);
						if (other.LeadingComments.Length != 0)
						{
							LeadingComments = other.LeadingComments;
						}
						if (other.TrailingComments.Length != 0)
						{
							TrailingComments = other.TrailingComments;
						}
						leadingDetachedComments_.Add(other.leadingDetachedComments_);
					}
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					uint num;
					while ((num = input.ReadTag()) != 0)
					{
						switch (num)
						{
						default:
							input.SkipLastField();
							break;
						case 8u:
						case 10u:
							path_.AddEntriesFrom(input, _repeated_path_codec);
							break;
						case 16u:
						case 18u:
							span_.AddEntriesFrom(input, _repeated_span_codec);
							break;
						case 26u:
							LeadingComments = input.ReadString();
							break;
						case 34u:
							TrailingComments = input.ReadString();
							break;
						case 50u:
							leadingDetachedComments_.AddEntriesFrom(input, _repeated_leadingDetachedComments_codec);
							break;
						}
					}
				}
			}
		}

		private static readonly MessageParser<SourceCodeInfo> _parser = new MessageParser<SourceCodeInfo>(() => new SourceCodeInfo());

		public const int LocationFieldNumber = 1;

		private static readonly FieldCodec<Types.Location> _repeated_location_codec = FieldCodec.ForMessage(10u, Types.Location.Parser);

		private readonly RepeatedField<Types.Location> location_ = new RepeatedField<Types.Location>();

		[DebuggerNonUserCode]
		public static MessageParser<SourceCodeInfo> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[18];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public RepeatedField<Types.Location> Location => location_;

		[DebuggerNonUserCode]
		public SourceCodeInfo()
		{
		}

		[DebuggerNonUserCode]
		public SourceCodeInfo(SourceCodeInfo other)
			: this()
		{
			location_ = other.location_.Clone();
		}

		[DebuggerNonUserCode]
		public SourceCodeInfo Clone()
		{
			return new SourceCodeInfo(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as SourceCodeInfo);
		}

		[DebuggerNonUserCode]
		public bool Equals(SourceCodeInfo other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (!location_.Equals(other.location_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 1 ^ location_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			location_.WriteTo(output, _repeated_location_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0 + location_.CalculateSize(_repeated_location_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(SourceCodeInfo other)
		{
			if (other != null)
			{
				location_.Add(other.location_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 10)
				{
					input.SkipLastField();
				}
				else
				{
					location_.AddEntriesFrom(input, _repeated_location_codec);
				}
			}
		}
	}
	internal sealed class GeneratedCodeInfo : IMessage<GeneratedCodeInfo>, IMessage, IEquatable<GeneratedCodeInfo>, IDeepCloneable<GeneratedCodeInfo>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal sealed class Annotation : IMessage<Annotation>, IMessage, IEquatable<Annotation>, IDeepCloneable<Annotation>
			{
				private static readonly MessageParser<Annotation> _parser = new MessageParser<Annotation>(() => new Annotation());

				public const int PathFieldNumber = 1;

				private static readonly FieldCodec<int> _repeated_path_codec = FieldCodec.ForInt32(10u);

				private readonly RepeatedField<int> path_ = new RepeatedField<int>();

				public const int SourceFileFieldNumber = 2;

				private string sourceFile_ = "";

				public const int BeginFieldNumber = 3;

				private int begin_;

				public const int EndFieldNumber = 4;

				private int end_;

				[DebuggerNonUserCode]
				public static MessageParser<Annotation> Parser => _parser;

				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor => GeneratedCodeInfo.Descriptor.NestedTypes[0];

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor => Descriptor;

				[DebuggerNonUserCode]
				public RepeatedField<int> Path => path_;

				[DebuggerNonUserCode]
				public string SourceFile
				{
					get
					{
						return sourceFile_;
					}
					set
					{
						sourceFile_ = ProtoPreconditions.CheckNotNull(value, "value");
					}
				}

				[DebuggerNonUserCode]
				public int Begin
				{
					get
					{
						return begin_;
					}
					set
					{
						begin_ = value;
					}
				}

				[DebuggerNonUserCode]
				public int End
				{
					get
					{
						return end_;
					}
					set
					{
						end_ = value;
					}
				}

				[DebuggerNonUserCode]
				public Annotation()
				{
				}

				[DebuggerNonUserCode]
				public Annotation(Annotation other)
					: this()
				{
					path_ = other.path_.Clone();
					sourceFile_ = other.sourceFile_;
					begin_ = other.begin_;
					end_ = other.end_;
				}

				[DebuggerNonUserCode]
				public Annotation Clone()
				{
					return new Annotation(this);
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return Equals(other as Annotation);
				}

				[DebuggerNonUserCode]
				public bool Equals(Annotation other)
				{
					if (other == null)
					{
						return false;
					}
					if (other == this)
					{
						return true;
					}
					if (!path_.Equals(other.path_))
					{
						return false;
					}
					if (SourceFile != other.SourceFile)
					{
						return false;
					}
					if (Begin != other.Begin)
					{
						return false;
					}
					if (End != other.End)
					{
						return false;
					}
					return true;
				}

				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					num ^= path_.GetHashCode();
					if (SourceFile.Length != 0)
					{
						num ^= SourceFile.GetHashCode();
					}
					if (Begin != 0)
					{
						num ^= Begin.GetHashCode();
					}
					if (End != 0)
					{
						num ^= End.GetHashCode();
					}
					return num;
				}

				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					path_.WriteTo(output, _repeated_path_codec);
					if (SourceFile.Length != 0)
					{
						output.WriteRawTag(18);
						output.WriteString(SourceFile);
					}
					if (Begin != 0)
					{
						output.WriteRawTag(24);
						output.WriteInt32(Begin);
					}
					if (End != 0)
					{
						output.WriteRawTag(32);
						output.WriteInt32(End);
					}
				}

				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					num += path_.CalculateSize(_repeated_path_codec);
					if (SourceFile.Length != 0)
					{
						num += 1 + CodedOutputStream.ComputeStringSize(SourceFile);
					}
					if (Begin != 0)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(Begin);
					}
					if (End != 0)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(End);
					}
					return num;
				}

				[DebuggerNonUserCode]
				public void MergeFrom(Annotation other)
				{
					if (other != null)
					{
						path_.Add(other.path_);
						if (other.SourceFile.Length != 0)
						{
							SourceFile = other.SourceFile;
						}
						if (other.Begin != 0)
						{
							Begin = other.Begin;
						}
						if (other.End != 0)
						{
							End = other.End;
						}
					}
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					uint num;
					while ((num = input.ReadTag()) != 0)
					{
						switch (num)
						{
						default:
							input.SkipLastField();
							break;
						case 8u:
						case 10u:
							path_.AddEntriesFrom(input, _repeated_path_codec);
							break;
						case 18u:
							SourceFile = input.ReadString();
							break;
						case 24u:
							Begin = input.ReadInt32();
							break;
						case 32u:
							End = input.ReadInt32();
							break;
						}
					}
				}
			}
		}

		private static readonly MessageParser<GeneratedCodeInfo> _parser = new MessageParser<GeneratedCodeInfo>(() => new GeneratedCodeInfo());

		public const int AnnotationFieldNumber = 1;

		private static readonly FieldCodec<Types.Annotation> _repeated_annotation_codec = FieldCodec.ForMessage(10u, Types.Annotation.Parser);

		private readonly RepeatedField<Types.Annotation> annotation_ = new RepeatedField<Types.Annotation>();

		[DebuggerNonUserCode]
		public static MessageParser<GeneratedCodeInfo> Parser => _parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[19];

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => Descriptor;

		[DebuggerNonUserCode]
		public RepeatedField<Types.Annotation> Annotation => annotation_;

		[DebuggerNonUserCode]
		public GeneratedCodeInfo()
		{
		}

		[DebuggerNonUserCode]
		public GeneratedCodeInfo(GeneratedCodeInfo other)
			: this()
		{
			annotation_ = other.annotation_.Clone();
		}

		[DebuggerNonUserCode]
		public GeneratedCodeInfo Clone()
		{
			return new GeneratedCodeInfo(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return Equals(other as GeneratedCodeInfo);
		}

		[DebuggerNonUserCode]
		public bool Equals(GeneratedCodeInfo other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (!annotation_.Equals(other.annotation_))
			{
				return false;
			}
			return true;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 1 ^ annotation_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			annotation_.WriteTo(output, _repeated_annotation_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0 + annotation_.CalculateSize(_repeated_annotation_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(GeneratedCodeInfo other)
		{
			if (other != null)
			{
				annotation_.Add(other.annotation_);
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0)
			{
				if (num != 10)
				{
					input.SkipLastField();
				}
				else
				{
					annotation_.AddEntriesFrom(input, _repeated_annotation_codec);
				}
			}
		}
	}
	public abstract class DescriptorBase : IDescriptor
	{
		private readonly FileDescriptor file;

		private readonly string fullName;

		private readonly int index;

		public int Index => index;

		public abstract string Name { get; }

		public string FullName => fullName;

		public FileDescriptor File => file;

		internal DescriptorBase(FileDescriptor file, string fullName, int index)
		{
			this.file = file;
			this.fullName = fullName;
			this.index = index;
		}
	}
	internal sealed class DescriptorPool
	{
		private struct DescriptorIntPair : IEquatable<DescriptorIntPair>
		{
			private readonly int number;

			private readonly IDescriptor descriptor;

			internal DescriptorIntPair(IDescriptor descriptor, int number)
			{
				this.number = number;
				this.descriptor = descriptor;
			}

			public bool Equals(DescriptorIntPair other)
			{
				if (descriptor == other.descriptor)
				{
					return number == other.number;
				}
				return false;
			}

			public override bool Equals(object obj)
			{
				if (obj is DescriptorIntPair)
				{
					return Equals((DescriptorIntPair)obj);
				}
				return false;
			}

			public override int GetHashCode()
			{
				return descriptor.GetHashCode() * 65535 + number;
			}
		}

		private readonly IDictionary<string, IDescriptor> descriptorsByName = new Dictionary<string, IDescriptor>();

		private readonly IDictionary<DescriptorIntPair, FieldDescriptor> fieldsByNumber = new Dictionary<DescriptorIntPair, FieldDescriptor>();

		private readonly IDictionary<DescriptorIntPair, EnumValueDescriptor> enumValuesByNumber = new Dictionary<DescriptorIntPair, EnumValueDescriptor>();

		private readonly HashSet<FileDescriptor> dependencies;

		private static readonly Regex ValidationRegex = new Regex("^[_A-Za-z][_A-Za-z0-9]*$", FrameworkPortability.CompiledRegexWhereAvailable);

		internal DescriptorPool(FileDescriptor[] dependencyFiles)
		{
			dependencies = new HashSet<FileDescriptor>();
			for (int i = 0; i < dependencyFiles.Length; i++)
			{
				dependencies.Add(dependencyFiles[i]);
				ImportPublicDependencies(dependencyFiles[i]);
			}
			foreach (FileDescriptor fileDescriptor in dependencyFiles)
			{
				AddPackage(fileDescriptor.Package, fileDescriptor);
			}
		}

		private void ImportPublicDependencies(FileDescriptor file)
		{
			foreach (FileDescriptor publicDependency in file.PublicDependencies)
			{
				if (dependencies.Add(publicDependency))
				{
					ImportPublicDependencies(publicDependency);
				}
			}
		}

		internal T FindSymbol<T>(string fullName) where T : class
		{
			descriptorsByName.TryGetValue(fullName, out var value);
			if (value is T result)
			{
				return result;
			}
			foreach (FileDescriptor dependency in dependencies)
			{
				dependency.DescriptorPool.descriptorsByName.TryGetValue(fullName, out value);
				if (value is T result2)
				{
					return result2;
				}
			}
			return null;
		}

		internal void AddPackage(string fullName, FileDescriptor file)
		{
			int num = fullName.LastIndexOf('.');
			string text;
			if (num != -1)
			{
				AddPackage(fullName.Substring(0, num), file);
				text = fullName.Substring(num + 1);
			}
			else
			{
				text = fullName;
			}
			if (descriptorsByName.TryGetValue(fullName, out var value) && !(value is PackageDescriptor))
			{
				throw new DescriptorValidationException(file, "\"" + text + "\" is already defined (as something other than a package) in file \"" + value.File.Name + "\".");
			}
			descriptorsByName[fullName] = new PackageDescriptor(text, fullName, file);
		}

		internal void AddSymbol(IDescriptor descriptor)
		{
			ValidateSymbolName(descriptor);
			string fullName = descriptor.FullName;
			if (descriptorsByName.TryGetValue(fullName, out var value))
			{
				int num = fullName.LastIndexOf('.');
				string description = ((descriptor.File != value.File) ? ("\"" + fullName + "\" is already defined in file \"" + value.File.Name + "\".") : ((num != -1) ? ("\"" + fullName.Substring(num + 1) + "\" is already defined in \"" + fullName.Substring(0, num) + "\".") : ("\"" + fullName + "\" is already defined.")));
				throw new DescriptorValidationException(descriptor, description);
			}
			descriptorsByName[fullName] = descriptor;
		}

		private static void ValidateSymbolName(IDescriptor descriptor)
		{
			if (descriptor.Name == "")
			{
				throw new DescriptorValidationException(descriptor, "Missing name.");
			}
			if (!ValidationRegex.IsMatch(descriptor.Name))
			{
				throw new DescriptorValidationException(descriptor, "\"" + descriptor.Name + "\" is not a valid identifier.");
			}
		}

		internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number)
		{
			fieldsByNumber.TryGetValue(new DescriptorIntPair(messageDescriptor, number), out var value);
			return value;
		}

		internal EnumValueDescriptor FindEnumValueByNumber(EnumDescriptor enumDescriptor, int number)
		{
			enumValuesByNumber.TryGetValue(new DescriptorIntPair(enumDescriptor, number), out var value);
			return value;
		}

		internal void AddFieldByNumber(FieldDescriptor field)
		{
			DescriptorIntPair key = new DescriptorIntPair(field.ContainingType, field.FieldNumber);
			if (fieldsByNumber.TryGetValue(key, out var value))
			{
				throw new DescriptorValidationException(field, "Field number " + field.FieldNumber + "has already been used in \"" + field.ContainingType.FullName + "\" by field \"" + value.Name + "\".");
			}
			fieldsByNumber[key] = field;
		}

		internal void AddEnumValueByNumber(EnumValueDescriptor enumValue)
		{
			DescriptorIntPair key = new DescriptorIntPair(enumValue.EnumDescriptor, enumValue.Number);
			if (!enumValuesByNumber.ContainsKey(key))
			{
				enumValuesByNumber[key] = enumValue;
			}
		}

		internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo)
		{
			IDescriptor descriptor;
			if (name.StartsWith("."))
			{
				descriptor = FindSymbol<IDescriptor>(name.Substring(1));
			}
			else
			{
				int num = name.IndexOf('.');
				string value = ((num == -1) ? name : name.Substring(0, num));
				StringBuilder stringBuilder = new StringBuilder(relativeTo.FullName);
				while (true)
				{
					int num2 = stringBuilder.ToString().LastIndexOf(".");
					if (num2 == -1)
					{
						descriptor = FindSymbol<IDescriptor>(name);
						break;
					}
					stringBuilder.Length = num2 + 1;
					stringBuilder.Append(value);
					descriptor = FindSymbol<IDescriptor>(stringBuilder.ToString());
					if (descriptor != null)
					{
						if (num != -1)
						{
							stringBuilder.Length = num2 + 1;
							stringBuilder.Append(name);
							descriptor = FindSymbol<IDescriptor>(stringBuilder.ToString());
						}
						break;
					}
					stringBuilder.Length = num2;
				}
			}
			if (descriptor == null)
			{
				throw new DescriptorValidationException(relativeTo, "\"" + name + "\" is not defined.");
			}
			return descriptor;
		}
	}
	internal static class DescriptorUtil
	{
		internal delegate TOutput IndexedConverter<TInput, TOutput>(TInput element, int index);

		internal static IList<TOutput> ConvertAndMakeReadOnly<TInput, TOutput>(IList<TInput> input, IndexedConverter<TInput, TOutput> converter)
		{
			TOutput[] array = new TOutput[input.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = converter(input[i], i);
			}
			return new ReadOnlyCollection<TOutput>(array);
		}
	}
	public sealed class DescriptorValidationException : Exception
	{
		private readonly string name;

		private readonly string description;

		public string ProblemSymbolName => name;

		public string Description => description;

		internal DescriptorValidationException(IDescriptor problemDescriptor, string description)
			: base(problemDescriptor.FullName + ": " + description)
		{
			name = problemDescriptor.FullName;
			this.description = description;
		}

		internal DescriptorValidationException(IDescriptor problemDescriptor, string description, Exception cause)
			: base(problemDescriptor.FullName + ": " + description, cause)
		{
			name = problemDescriptor.FullName;
			this.description = description;
		}
	}
	public sealed class EnumDescriptor : DescriptorBase
	{
		private readonly EnumDescriptorProto proto;

		private readonly MessageDescriptor containingType;

		private readonly IList<EnumValueDescriptor> values;

		private readonly System.Type clrType;

		internal EnumDescriptorProto Proto => proto;

		public override string Name => proto.Name;

		public System.Type ClrType => clrType;

		public MessageDescriptor ContainingType => containingType;

		public IList<EnumValueDescriptor> Values => values;

		internal EnumDescriptor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, System.Type clrType)
			: base(file, file.ComputeFullName(parent, proto.Name), index)
		{
			EnumDescriptor parent2 = this;
			this.proto = proto;
			this.clrType = clrType;
			containingType = parent;
			if (proto.Value.Count == 0)
			{
				throw new DescriptorValidationException(this, "Enums must contain at least one value.");
			}
			values = DescriptorUtil.ConvertAndMakeReadOnly(proto.Value, (EnumValueDescriptorProto value, int i) => new EnumValueDescriptor(value, file, parent2, i));
			base.File.DescriptorPool.AddSymbol(this);
		}

		public EnumValueDescriptor FindValueByNumber(int number)
		{
			return base.File.DescriptorPool.FindEnumValueByNumber(this, number);
		}

		public EnumValueDescriptor FindValueByName(string name)
		{
			return base.File.DescriptorPool.FindSymbol<EnumValueDescriptor>(base.FullName + "." + name);
		}
	}
	public sealed class EnumValueDescriptor : DescriptorBase
	{
		private readonly EnumDescriptor enumDescriptor;

		private readonly EnumValueDescriptorProto proto;

		internal EnumValueDescriptorProto Proto => proto;

		public override string Name => proto.Name;

		public int Number => Proto.Number;

		public EnumDescriptor EnumDescriptor => enumDescriptor;

		internal EnumValueDescriptor(EnumValueDescriptorProto proto, FileDescriptor file, EnumDescriptor parent, int index)
			: base(file, parent.FullName + "." + proto.Name, index)
		{
			this.proto = proto;
			enumDescriptor = parent;
			file.DescriptorPool.AddSymbol(this);
			file.DescriptorPool.AddEnumValueByNumber(this);
		}
	}
	internal abstract class FieldAccessorBase : IFieldAccessor
	{
		private readonly Func<IMessage, object> getValueDelegate;

		private readonly FieldDescriptor descriptor;

		public FieldDescriptor Descriptor => descriptor;

		internal FieldAccessorBase(PropertyInfo property, FieldDescriptor descriptor)
		{
			this.descriptor = descriptor;
			getValueDelegate = ReflectionUtil.CreateFuncIMessageObject(property.GetGetMethod());
		}

		public object GetValue(IMessage message)
		{
			return getValueDelegate(message);
		}

		public abstract void Clear(IMessage message);

		public abstract void SetValue(IMessage message, object value);
	}
	public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor>
	{
		private EnumDescriptor enumType;

		private MessageDescriptor messageType;

		private FieldType fieldType;

		private readonly string propertyName;

		private IFieldAccessor accessor;

		public MessageDescriptor ContainingType { get; }

		public OneofDescriptor ContainingOneof { get; }

		public string JsonName { get; }

		internal FieldDescriptorProto Proto { get; }

		public override string Name => Proto.Name;

		public IFieldAccessor Accessor => accessor;

		public bool IsRepeated => Proto.Label == FieldDescriptorProto.Types.Label.Repeated;

		public bool IsMap
		{
			get
			{
				if (fieldType == FieldType.Message && messageType.Proto.Options != null)
				{
					return messageType.Proto.Options.MapEntry;
				}
				return false;
			}
		}

		public bool IsPacked
		{
			get
			{
				if (Proto.Options != null)
				{
					return Proto.Options.Packed;
				}
				return true;
			}
		}

		public FieldType FieldType => fieldType;

		public int FieldNumber => Proto.Number;

		public EnumDescriptor EnumType
		{
			get
			{
				if (fieldType != FieldType.Enum)
				{
					throw new InvalidOperationException("EnumType is only valid for enum fields.");
				}
				return enumType;
			}
		}

		public MessageDescriptor MessageType
		{
			get
			{
				if (fieldType != FieldType.Message)
				{
					throw new InvalidOperationException("MessageType is only valid for message fields.");
				}
				return messageType;
			}
		}

		internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName)
			: base(file, file.ComputeFullName(parent, proto.Name), index)
		{
			Proto = proto;
			if (proto.Type != 0)
			{
				fieldType = GetFieldTypeFromProtoType(proto.Type);
			}
			if (FieldNumber <= 0)
			{
				throw new DescriptorValidationException(this, "Field numbers must be positive integers.");
			}
			ContainingType = parent;
			if (proto.OneofIndex != -1)
			{
				if (proto.OneofIndex < 0 || proto.OneofIndex >= parent.Proto.OneofDecl.Count)
				{
					throw new DescriptorValidationException(this, $"FieldDescriptorProto.oneof_index is out of range for type {parent.Name}");
				}
				ContainingOneof = parent.Oneofs[proto.OneofIndex];
			}
			file.DescriptorPool.AddSymbol(this);
			this.propertyName = propertyName;
			JsonName = ((Proto.JsonName == "") ? JsonFormatter.ToCamelCase(Proto.Name) : Proto.JsonName);
		}

		private static FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type)
		{
			return type switch
			{
				FieldDescriptorProto.Types.Type.Double => FieldType.Double, 
				FieldDescriptorProto.Types.Type.Float => FieldType.Float, 
				FieldDescriptorProto.Types.Type.Int64 => FieldType.Int64, 
				FieldDescriptorProto.Types.Type.Uint64 => FieldType.UInt64, 
				FieldDescriptorProto.Types.Type.Int32 => FieldType.Int32, 
				FieldDescriptorProto.Types.Type.Fixed64 => FieldType.Fixed64, 
				FieldDescriptorProto.Types.Type.Fixed32 => FieldType.Fixed32, 
				FieldDescriptorProto.Types.Type.Bool => FieldType.Bool, 
				FieldDescriptorProto.Types.Type.String => FieldType.String, 
				FieldDescriptorProto.Types.Type.Group => FieldType.Group, 
				FieldDescriptorProto.Types.Type.Message => FieldType.Message, 
				FieldDescriptorProto.Types.Type.Bytes => FieldType.Bytes, 
				FieldDescriptorProto.Types.Type.Uint32 => FieldType.UInt32, 
				FieldDescriptorProto.Types.Type.Enum => FieldType.Enum, 
				FieldDescriptorProto.Types.Type.Sfixed32 => FieldType.SFixed32, 
				FieldDescriptorProto.Types.Type.Sfixed64 => FieldType.SFixed64, 
				FieldDescriptorProto.Types.Type.Sint32 => FieldType.SInt32, 
				FieldDescriptorProto.Types.Type.Sint64 => FieldType.SInt64, 
				_ => throw new ArgumentException("Invalid type specified"), 
			};
		}

		public int CompareTo(FieldDescriptor other)
		{
			if (other.ContainingType != ContainingType)
			{
				throw new ArgumentException("FieldDescriptors can only be compared to other FieldDescriptors for fields of the same message type.");
			}
			return FieldNumber - other.FieldNumber;
		}

		internal void CrossLink()
		{
			if (Proto.TypeName != "")
			{
				IDescriptor descriptor = base.File.DescriptorPool.LookupSymbol(Proto.TypeName, this);
				if (Proto.Type != 0)
				{
					if (descriptor is MessageDescriptor)
					{
						fieldType = FieldType.Message;
					}
					else
					{
						if (!(descriptor is EnumDescriptor))
						{
							throw new DescriptorValidationException(this, $"\"{Proto.TypeName}\" is not a type.");
						}
						fieldType = FieldType.Enum;
					}
				}
				if (fieldType == FieldType.Message)
				{
					if (!(descriptor is MessageDescriptor))
					{
						throw new DescriptorValidationException(this, $"\"{Proto.TypeName}\" is not a message type.");
					}
					messageType = (MessageDescriptor)descriptor;
					if (Proto.DefaultValue != "")
					{
						throw new DescriptorValidationException(this, "Messages can't have default values.");
					}
				}
				else
				{
					if (fieldType != FieldType.Enum)
					{
						throw new DescriptorValidationException(this, "Field with primitive type has type_name.");
					}
					if (!(descriptor is EnumDescriptor))
					{
						throw new DescriptorValidationException(this, $"\"{Proto.TypeName}\" is not an enum type.");
					}
					enumType = (EnumDescriptor)descriptor;
				}
			}
			else if (fieldType == FieldType.Message || fieldType == FieldType.Enum)
			{
				throw new DescriptorValidationException(this, "Field with message or enum type missing type_name.");
			}
			base.File.DescriptorPool.AddFieldByNumber(this);
			if (ContainingType != null && ContainingType.Proto.Options != null && ContainingType.Proto.Options.MessageSetWireFormat)
			{
				throw new DescriptorValidationException(this, "MessageSet format is not supported.");
			}
			accessor = CreateAccessor();
		}

		private IFieldAccessor CreateAccessor()
		{
			if (propertyName == null)
			{
				return null;
			}
			PropertyInfo property = ContainingType.ClrType.GetProperty(propertyName);
			if (property == null)
			{
				throw new DescriptorValidationException(this, $"Property {propertyName} not found in {ContainingType.ClrType}");
			}
			if (!IsMap)
			{
				if (!IsRepeated)
				{
					return new SingleFieldAccessor(property, this);
				}
				return new RepeatedFieldAccessor(property, this);
			}
			return new MapFieldAccessor(property, this);
		}
	}
	public enum FieldType
	{
		Double,
		Float,
		Int64,
		UInt64,
		Int32,
		Fixed64,
		Fixed32,
		Bool,
		String,
		Group,
		Message,
		Bytes,
		UInt32,
		SFixed32,
		SFixed64,
		SInt32,
		SInt64,
		Enum
	}
	public sealed class FileDescriptor : IDescriptor
	{
		internal FileDescriptorProto Proto { get; }

		public string Name => Proto.Name;

		public string Package => Proto.Package;

		public IList<MessageDescriptor> MessageTypes { get; }

		public IList<EnumDescriptor> EnumTypes { get; }

		public IList<ServiceDescriptor> Services { get; }

		public IList<FileDescriptor> Dependencies { get; }

		public IList<FileDescriptor> PublicDependencies { get; }

		public ByteString SerializedData { get; }

		string IDescriptor.FullName => Name;

		FileDescriptor IDescriptor.File => this;

		internal DescriptorPool DescriptorPool { get; }

		public static FileDescriptor DescriptorProtoFileDescriptor => DescriptorReflection.Descriptor;

		private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
			FileDescriptor file = this;
			SerializedData = descriptorData;
			DescriptorPool = pool;
			Proto = proto;
			Dependencies = new ReadOnlyCollection<FileDescriptor>((FileDescriptor[])dependencies.Clone());
			PublicDependencies = DeterminePublicDependencies(this, proto, dependencies, allowUnknownDependencies);
			pool.AddPackage(Package, this);
			MessageTypes = DescriptorUtil.ConvertAndMakeReadOnly(proto.MessageType, (DescriptorProto message, int index) => new MessageDescriptor(message, file, null, index, generatedCodeInfo.NestedTypes[index]));
			EnumTypes = DescriptorUtil.ConvertAndMakeReadOnly(proto.EnumType, (EnumDescriptorProto enumType, int index) => new EnumDescriptor(enumType, file, null, index, generatedCodeInfo.NestedEnums[index]));
			Services = DescriptorUtil.ConvertAndMakeReadOnly(proto.Service, (ServiceDescriptorProto service, int index) => new ServiceDescriptor(service, this, index));
		}

		internal string ComputeFullName(MessageDescriptor parent, string name)
		{
			if (parent != null)
			{
				return parent.FullName + "." + name;
			}
			if (Package.Length > 0)
			{
				return Package + "." + name;
			}
			return name;
		}

		private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor @this, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies)
		{
			Dictionary<string, FileDescriptor> dictionary = new Dictionary<string, FileDescriptor>();
			foreach (FileDescriptor fileDescriptor in dependencies)
			{
				dictionary[fileDescriptor.Name] = fileDescriptor;
			}
			List<FileDescriptor> list = new List<FileDescriptor>();
			for (int j = 0; j < proto.PublicDependency.Count; j++)
			{
				int num = proto.PublicDependency[j];
				if (num < 0 || num >= proto.Dependency.Count)
				{
					throw new DescriptorValidationException(@this, "Invalid public dependency index.");
				}
				string text = proto.Dependency[num];
				FileDescriptor fileDescriptor2 = dictionary[text];
				if (fileDescriptor2 == null)
				{
					if (!allowUnknownDependencies)
					{
						throw new DescriptorValidationException(@this, "Invalid public dependency: " + text);
					}
				}
				else
				{
					list.Add(fileDescriptor2);
				}
			}
			return new ReadOnlyCollection<FileDescriptor>(list);
		}

		public T FindTypeByName<T>(string name) where T : class, IDescriptor
		{
			if (name.IndexOf('.') != -1)
			{
				return null;
			}
			if (Package.Length > 0)
			{
				name = Package + "." + name;
			}
			T val = DescriptorPool.FindSymbol<T>(name);
			if (val != null && val.File == this)
			{
				return val;
			}
			return null;
		}

		private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
			if (dependencies == null)
			{
				dependencies = new FileDescriptor[0];
			}
			DescriptorPool pool = new DescriptorPool(dependencies);
			FileDescriptor fileDescriptor = new FileDescriptor(descriptorData, proto, dependencies, pool, allowUnknownDependencies, generatedCodeInfo);
			if (dependencies.Length != proto.Dependency.Count)
			{
				throw new DescriptorValidationException(fileDescriptor, "Dependencies passed to FileDescriptor.BuildFrom() don't match those listed in the FileDescriptorProto.");
			}
			fileDescriptor.CrossLink();
			return fileDescriptor;
		}

		private void CrossLink()
		{
			foreach (MessageDescriptor messageType in MessageTypes)
			{
				messageType.CrossLink();
			}
			foreach (ServiceDescriptor service in Services)
			{
				service.CrossLink();
			}
		}

		public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
			FileDescriptorProto fileDescriptorProto;
			try
			{
				fileDescriptorProto = FileDescriptorProto.Parser.ParseFrom(descriptorData);
			}
			catch (InvalidProtocolBufferException innerException)
			{
				throw new ArgumentException("Failed to parse protocol buffer descriptor for generated code.", innerException);
			}
			try
			{
				return BuildFrom(ByteString.CopyFrom(descriptorData), fileDescriptorProto, dependencies, allowUnknownDependencies: true, generatedCodeInfo);
			}
			catch (DescriptorValidationException innerException2)
			{
				throw new ArgumentException($"Invalid embedded descriptor for \"{fileDescriptorProto.Name}\".", innerException2);
			}
		}

		public override string ToString()
		{
			return $"FileDescriptor for {Name}";
		}
	}
	public sealed class GeneratedClrTypeInfo
	{
		private static readonly string[] EmptyNames = new string[0];

		private static readonly GeneratedClrTypeInfo[] EmptyCodeInfo = new GeneratedClrTypeInfo[0];

		public System.Type ClrType { get; private set; }

		public MessageParser Parser { get; }

		public string[] PropertyNames { get; }

		public string[] OneofNames { get; }

		public GeneratedClrTypeInfo[] NestedTypes { get; }

		public System.Type[] NestedEnums { get; }

		public GeneratedClrTypeInfo(System.Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, System.Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes)
		{
			NestedTypes = nestedTypes ?? EmptyCodeInfo;
			NestedEnums = nestedEnums ?? ReflectionUtil.EmptyTypes;
			ClrType = clrType;
			Parser = parser;
			PropertyNames = propertyNames ?? EmptyNames;
			OneofNames = oneofNames ?? EmptyNames;
		}

		public GeneratedClrTypeInfo(System.Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes)
			: this(null, null, null, null, nestedEnums, nestedTypes)
		{
		}
	}
	public interface IDescriptor
	{
		string Name { get; }

		string FullName { get; }

		FileDescriptor File { get; }
	}
	public interface IFieldAccessor
	{
		FieldDescriptor Descriptor { get; }

		void Clear(IMessage message);

		object GetValue(IMessage message);

		void SetValue(IMessage message, object value);
	}
	internal sealed class MapFieldAccessor : FieldAccessorBase
	{
		internal MapFieldAccessor(PropertyInfo property, FieldDescriptor descriptor)
			: base(property, descriptor)
		{
		}

		public override void Clear(IMessage message)
		{
			((IDictionary)GetValue(message)).Clear();
		}

		public override void SetValue(IMessage message, object value)
		{
			throw new InvalidOperationException("SetValue is not implemented for map fields");
		}
	}
	public sealed class MessageDescriptor : DescriptorBase
	{
		public sealed class FieldCollection
		{
			private readonly MessageDescriptor messageDescriptor;

			public FieldDescriptor this[int number] => messageDescriptor.FindFieldByNumber(number) ?? throw new KeyNotFoundException("No such field number");

			public FieldDescriptor this[string name] => messageDescriptor.FindFieldByName(name) ?? throw new KeyNotFoundException("No such field name");

			internal FieldCollection(MessageDescriptor messageDescriptor)
			{
				this.messageDescriptor = messageDescriptor;
			}

			public IList<FieldDescriptor> InDeclarationOrder()
			{
				return messageDescriptor.fieldsInDeclarationOrder;
			}

			public IList<FieldDescriptor> InFieldNumberOrder()
			{
				return messageDescriptor.fieldsInNumberOrder;
			}

			internal IDictionary<string, FieldDescriptor> ByJsonName()
			{
				return messageDescriptor.jsonFieldMap;
			}
		}

		private static readonly HashSet<string> WellKnownTypeNames = new HashSet<string> { "google/protobuf/any.proto", "google/protobuf/api.proto", "google/protobuf/duration.proto", "google/protobuf/empty.proto", "google/protobuf/wrappers.proto", "google/protobuf/timestamp.proto", "google/protobuf/field_mask.proto", "google/protobuf/source_context.proto", "google/protobuf/struct.proto", "google/protobuf/type.proto" };

		private readonly IList<FieldDescriptor> fieldsInDeclarationOrder;

		private readonly IList<FieldDescriptor> fieldsInNumberOrder;

		private readonly IDictionary<string, FieldDescriptor> jsonFieldMap;

		public override string Name => Proto.Name;

		internal DescriptorProto Proto { get; }

		public System.Type ClrType { get; }

		public MessageParser Parser { get; }

		internal bool IsWellKnownType
		{
			get
			{
				if (base.File.Package == "google.protobuf")
				{
					return WellKnownTypeNames.Contains(base.File.Name);
				}
				return false;
			}
		}

		internal bool IsWrapperType
		{
			get
			{
				if (base.File.Package == "google.protobuf")
				{
					return base.File.Name == "google/protobuf/wrappers.proto";
				}
				return false;
			}
		}

		public MessageDescriptor ContainingType { get; }

		public FieldCollection Fields { get; }

		public IList<MessageDescriptor> NestedTypes { get; }

		public IList<EnumDescriptor> EnumTypes { get; }

		public IList<OneofDescriptor> Oneofs { get; }

		internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo)
			: base(file, file.ComputeFullName(parent, proto.Name), typeIndex)
		{
			MessageDescriptor messageDescriptor = this;
			Proto = proto;
			Parser = generatedCodeInfo?.Parser;
			ClrType = generatedCodeInfo?.ClrType;
			ContainingType = parent;
			Oneofs = DescriptorUtil.ConvertAndMakeReadOnly(proto.OneofDecl, (OneofDescriptorProto oneof, int index) => new OneofDescriptor(oneof, file, messageDescriptor, index, generatedCodeInfo.OneofNames[index]));
			NestedTypes = DescriptorUtil.ConvertAndMakeReadOnly(proto.NestedType, (DescriptorProto type, int index) => new MessageDescriptor(type, file, messageDescriptor, index, generatedCodeInfo.NestedTypes[index]));
			EnumTypes = DescriptorUtil.ConvertAndMakeReadOnly(proto.EnumType, (EnumDescriptorProto type, int index) => new EnumDescriptor(type, file, messageDescriptor, index, generatedCodeInfo.NestedEnums[index]));
			fieldsInDeclarationOrder = DescriptorUtil.ConvertAndMakeReadOnly(proto.Field, delegate(FieldDescriptorProto field, int index)
			{
				FileDescriptor fileDescriptor = file;
				MessageDescriptor parent2 = messageDescriptor;
				GeneratedClrTypeInfo generatedClrTypeInfo = generatedCodeInfo;
				return new FieldDescriptor(field, fileDescriptor, parent2, index, (generatedClrTypeInfo != null) ? generatedClrTypeInfo.PropertyNames[index] : null);
			});
			fieldsInNumberOrder = new ReadOnlyCollection<FieldDescriptor>(fieldsInDeclarationOrder.OrderBy((FieldDescriptor field) => field.FieldNumber).ToArray());
			jsonFieldMap = CreateJsonFieldMap(fieldsInNumberOrder);
			file.DescriptorPool.AddSymbol(this);
			Fields = new FieldCollection(this);
		}

		private static ReadOnlyDictionary<string, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields)
		{
			Dictionary<string, FieldDescriptor> dictionary = new Dictionary<string, FieldDescriptor>();
			foreach (FieldDescriptor field in fields)
			{
				dictionary[field.Name] = field;
				dictionary[field.JsonName] = field;
			}
			return new ReadOnlyDictionary<string, FieldDescriptor>(dictionary);
		}

		public FieldDescriptor FindFieldByName(string name)
		{
			return base.File.DescriptorPool.FindSymbol<FieldDescriptor>(base.FullName + "." + name);
		}

		public FieldDescriptor FindFieldByNumber(int number)
		{
			return base.File.DescriptorPool.FindFieldByNumber(this, number);
		}

		public T FindDescriptor<T>(string name) where T : class, IDescriptor
		{
			return base.File.DescriptorPool.FindSymbol<T>(base.FullName + "." + name);
		}

		internal void CrossLink()
		{
			foreach (MessageDescriptor nestedType in NestedTypes)
			{
				nestedType.CrossLink();
			}
			foreach (FieldDescriptor item in fieldsInDeclarationOrder)
			{
				item.CrossLink();
			}
			foreach (OneofDescriptor oneof in Oneofs)
			{
				oneof.CrossLink();
			}
		}
	}
	public sealed class MethodDescriptor : DescriptorBase
	{
		private readonly MethodDescriptorProto proto;

		private readonly ServiceDescriptor service;

		private MessageDescriptor inputType;

		private MessageDescriptor outputType;

		public ServiceDescriptor Service => service;

		public MessageDescriptor InputType => inputType;

		public MessageDescriptor OutputType => outputType;

		public bool IsClientStreaming => proto.ClientStreaming;

		public bool IsServerStreaming => proto.ServerStreaming;

		internal MethodDescriptorProto Proto => proto;

		public override string Name => proto.Name;

		internal MethodDescriptor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index)
			: base(file, parent.FullName + "." + proto.Name, index)
		{
			this.proto = proto;
			service = parent;
			file.DescriptorPool.AddSymbol(this);
		}

		internal void CrossLink()
		{
			IDescriptor descriptor = base.File.DescriptorPool.LookupSymbol(Proto.InputType, this);
			if (!(descriptor is MessageDescriptor))
			{
				throw new DescriptorValidationException(this, "\"" + Proto.InputType + "\" is not a message type.");
			}
			inputType = (MessageDescriptor)descriptor;
			descriptor = base.File.DescriptorPool.LookupSymbol(Proto.OutputType, this);
			if (!(descriptor is MessageDescriptor))
			{
				throw new DescriptorValidationException(this, "\"" + Proto.OutputType + "\" is not a message type.");
			}
			outputType = (MessageDescriptor)descriptor;
		}
	}
	public sealed class OneofAccessor
	{
		private readonly Func<IMessage, int> caseDelegate;

		private readonly Action<IMessage> clearDelegate;

		private OneofDescriptor descriptor;

		public OneofDescriptor Descriptor => descriptor;

		internal OneofAccessor(PropertyInfo caseProperty, MethodInfo clearMethod, OneofDescriptor descriptor)
		{
			if (!caseProperty.CanRead)
			{
				throw new ArgumentException("Cannot read from property");
			}
			this.descriptor = descriptor;
			caseDelegate = ReflectionUtil.CreateFuncIMessageT<int>(caseProperty.GetGetMethod());
			this.descriptor = descriptor;
			clearDelegate = ReflectionUtil.CreateActionIMessage(clearMethod);
		}

		public void Clear(IMessage message)
		{
			clearDelegate(message);
		}

		public FieldDescriptor GetCaseFieldDescriptor(IMessage message)
		{
			int num = caseDelegate(message);
			if (num > 0)
			{
				return descriptor.ContainingType.FindFieldByNumber(num);
			}
			return null;
		}
	}
	public sealed class OneofDescriptor : DescriptorBase
	{
		private readonly OneofDescriptorProto proto;

		private MessageDescriptor containingType;

		private IList<FieldDescriptor> fields;

		private readonly OneofAccessor accessor;

		public override string Name => proto.Name;

		public MessageDescriptor ContainingType => containingType;

		public IList<FieldDescriptor> Fields => fields;

		public OneofAccessor Accessor => accessor;

		internal OneofDescriptor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName)
			: base(file, file.ComputeFullName(parent, proto.Name), index)
		{
			this.proto = proto;
			containingType = parent;
			file.DescriptorPool.AddSymbol(this);
			accessor = CreateAccessor(clrName);
		}

		internal void CrossLink()
		{
			List<FieldDescriptor> list = new List<FieldDescriptor>();
			foreach (FieldDescriptor item in ContainingType.Fields.InDeclarationOrder())
			{
				if (item.ContainingOneof == this)
				{
					list.Add(item);
				}
			}
			fields = new ReadOnlyCollection<FieldDescriptor>(list);
		}

		private OneofAccessor CreateAccessor(string clrName)
		{
			PropertyInfo caseProperty = containingType.ClrType.GetProperty(clrName + "Case") ?? throw new DescriptorValidationException(this, $"Property {clrName}Case not found in {containingType.ClrType}");
			MethodInfo method = containingType.ClrType.GetMethod("Clear" + clrName);
			if (method == null)
			{
				throw new DescriptorValidationException(this, $"Method Clear{clrName} not found in {containingType.ClrType}");
			}
			return new OneofAccessor(caseProperty, method, this);
		}
	}
	[AttributeUsage(AttributeTargets.Field)]
	public class OriginalNameAttribute : Attribute
	{
		public string Name { get; set; }

		public OriginalNameAttribute(string name)
		{
			Name = ProtoPreconditions.CheckNotNull(name, "name");
		}
	}
	internal sealed class PackageDescriptor : IDescriptor
	{
		private readonly string name;

		private readonly string fullName;

		private readonly FileDescriptor file;

		public string Name => name;

		public string FullName => fullName;

		public FileDescriptor File => file;

		internal PackageDescriptor(string name, string fullName, FileDescriptor file)
		{
			this.file = file;
			this.fullName = fullName;
			this.name = name;
		}
	}
	internal static class ReflectionUtil
	{
		internal static readonly System.Type[] EmptyTypes = new System.Type[0];

		internal static Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IMessage), "p");
			return Expression.Lambda<Func<IMessage, object>>(Expression.Convert(Expression.Call(Expression.Convert(parameterExpression, method.DeclaringType), method), typeof(object)), new ParameterExpression[1] { parameterExpression }).Compile();
		}

		internal static Func<IMessage, T> CreateFuncIMessageT<T>(MethodInfo method)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IMessage), "p");
			return Expression.Lambda<Func<IMessage, T>>(Expression.Convert(Expression.Call(Expression.Convert(parameterExpression, method.DeclaringType), method), typeof(T)), new ParameterExpression[1] { parameterExpression }).Compile();
		}

		internal static Action<IMessage, object> CreateActionIMessageObject(MethodInfo method)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IMessage), "target");
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object), "arg");
			UnaryExpression instance = Expression.Convert(parameterExpression, method.DeclaringType);
			Expression expression = Expression.Convert(parameterExpression2, method.GetParameters()[0].ParameterType);
			return Expression.Lambda<Action<IMessage, object>>(Expression.Call(instance, method, expression), new ParameterExpression[2] { parameterExpression, parameterExpression2 }).Compile();
		}

		internal static Action<IMessage> CreateActionIMessage(MethodInfo method)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IMessage), "target");
			return Expression.Lambda<Action<IMessage>>(Expression.Call(Expression.Convert(parameterExpression, method.DeclaringType), method), new ParameterExpression[1] { parameterExpression }).Compile();
		}
	}
	internal sealed class RepeatedFieldAccessor : FieldAccessorBase
	{
		internal RepeatedFieldAccessor(PropertyInfo property, FieldDescriptor descriptor)
			: base(property, descriptor)
		{
		}

		public override void Clear(IMessage message)
		{
			((IList)GetValue(message)).Clear();
		}

		public override void SetValue(IMessage message, object value)
		{
			throw new InvalidOperationException("SetValue is not implemented for repeated fields");
		}
	}
	public sealed class ServiceDescriptor : DescriptorBase
	{
		private readonly ServiceDescriptorProto proto;

		private readonly IList<MethodDescriptor> methods;

		public override string Name => proto.Name;

		internal ServiceDescriptorProto Proto => proto;

		public IList<MethodDescriptor> Methods => methods;

		internal ServiceDescriptor(ServiceDescriptorProto proto, FileDescriptor file, int index)
			: base(file, file.ComputeFullName(null, proto.Name), index)
		{
			ServiceDescriptor parent = this;
			this.proto = proto;
			methods = DescriptorUtil.ConvertAndMakeReadOnly(proto.Method, (MethodDescriptorProto method, int i) => new MethodDescriptor(method, file, parent, i));
			file.DescriptorPool.AddSymbol(this);
		}

		public MethodDescriptor FindMethodByName(string name)
		{
			return base.File.DescriptorPool.FindSymbol<MethodDescriptor>(base.FullName + "." + name);
		}

		internal void CrossLink()
		{
			foreach (MethodDescriptor method in methods)
			{
				method.CrossLink();
			}
		}
	}
	internal sealed class SingleFieldAccessor : FieldAccessorBase
	{
		private readonly Action<IMessage, object> setValueDelegate;

		private readonly Action<IMessage> clearDelegate;

		internal SingleFieldAccessor(PropertyInfo property, FieldDescriptor descriptor)
			: base(property, descriptor)
		{
			if (!property.CanWrite)
			{
				throw new ArgumentException("Not all required properties/methods available");
			}
			setValueDelegate = ReflectionUtil.CreateActionIMessageObject(property.GetSetMethod());
			System.Type propertyType = property.PropertyType;
			object defaultValue = ((descriptor.FieldType == FieldType.Message) ? null : ((propertyType == typeof(string)) ? "" : ((propertyType == typeof(ByteString)) ? ByteString.Empty : Activator.CreateInstance(propertyType))));
			clearDelegate = delegate(IMessage message)
			{
				SetValue(message, defaultValue);
			};
		}

		public override void Clear(IMessage message)
		{
			clearDelegate(message);
		}

		public override void SetValue(IMessage message, object value)
		{
			setValueDelegate(message, value);
		}
	}
	public sealed class TypeRegistry
	{
		private class Builder
		{
			private readonly Dictionary<string, MessageDescriptor> types;

			private readonly HashSet<string> fileDescriptorNames;

			internal Builder()
			{
				types = new Dictionary<string, MessageDescriptor>();
				fileDescriptorNames = new HashSet<string>();
			}

			internal void AddFile(FileDescriptor fileDescriptor)
			{
				if (!fileDescriptorNames.Add(fileDescriptor.Name))
				{
					return;
				}
				foreach (FileDescriptor dependency in fileDescriptor.Dependencies)
				{
					AddFile(dependency);
				}
				foreach (MessageDescriptor messageType in fileDescriptor.MessageTypes)
				{
					AddMessage(messageType);
				}
			}

			private void AddMessage(MessageDescriptor messageDescriptor)
			{
				foreach (MessageDescriptor nestedType in messageDescriptor.NestedTypes)
				{
					AddMessage(nestedType);
				}
				types[messageDescriptor.FullName] = messageDescriptor;
			}

			internal TypeRegistry Build()
			{
				return new TypeRegistry(types);
			}
		}

		private readonly Dictionary<string, MessageDescriptor> fullNameToMessageMap;

		public static TypeRegistry Empty { get; } = new TypeRegistry(new Dictionary<string, MessageDescriptor>());

		private TypeRegistry(Dictionary<string, MessageDescriptor> fullNameToMessageMap)
		{
			this.fullNameToMessageMap = fullNameToMessageMap;
		}

		public MessageDescriptor Find(string fullName)
		{
			fullNameToMessageMap.TryGetValue(fullName, out var value);
			return value;
		}

		public static TypeRegistry FromFiles(params FileDescriptor[] fileDescriptors)
		{
			return FromFiles((IEnumerable<FileDescriptor>)fileDescriptors);
		}

		public static TypeRegistry FromFiles(IEnumerable<FileDescriptor> fileDescriptors)
		{
			ProtoPreconditions.CheckNotNull(fileDescriptors, "fileDescriptors");
			Builder builder = new Builder();
			foreach (FileDescriptor fileDescriptor in fileDescriptors)
			{
				builder.AddFile(fileDescriptor);
			}
			return builder.Build();
		}

		public static TypeRegistry FromMessages(params MessageDescriptor[] messageDescriptors)
		{
			return FromMessages((IEnumerable<MessageDescriptor>)messageDescriptors);
		}

		public static TypeRegistry FromMessages(IEnumerable<MessageDescriptor> messageDescriptors)
		{
			ProtoPreconditions.CheckNotNull(messageDescriptors, "messageDescriptors");
			return FromFiles(messageDescriptors.Select((MessageDescriptor md) => md.File));
		}
	}
}
namespace Google.Protobuf.Compatibility
{
	internal static class PropertyInfoExtensions
	{
		internal static MethodInfo GetGetMethod(this PropertyInfo target)
		{
			MethodInfo getMethod = target.GetGetMethod();
			if (getMethod == null || !getMethod.IsPublic)
			{
				return null;
			}
			return getMethod;
		}

		internal static MethodInfo GetSetMethod(this PropertyInfo target)
		{
			MethodInfo setMethod = target.GetSetMethod();
			if (setMethod == null || !setMethod.IsPublic)
			{
				return null;
			}
			return setMethod;
		}
	}
}
namespace Google.Protobuf.Collections
{
	public sealed class MapField<TKey, TValue> : IDeepCloneable<MapField<TKey, TValue>>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IEquatable<MapField<TKey, TValue>>, IDictionary, ICollection
	{
		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			private readonly IEnumerator<KeyValuePair<TKey, TValue>> enumerator;

			public object Current => Entry;

			public DictionaryEntry Entry => new DictionaryEntry(Key, Value);

			public object Key => enumerator.Current.Key;

			public object Value => enumerator.Current.Value;

			internal DictionaryEnumerator(IEnumerator<KeyValuePair<TKey, TValue>> enumerator)
			{
				this.enumerator = enumerator;
			}

			public bool MoveNext()
			{
				return enumerator.MoveNext();
			}

			public void Reset()
			{
				enumerator.Reset();
			}
		}

		public sealed class Codec
		{
			internal class MessageAdapter : IMessage
			{
				private static readonly byte[] ZeroLengthMessageStreamData = new byte[1];

				private readonly Codec codec;

				internal TKey Key { get; set; }

				internal TValue Value { get; set; }

				MessageDescriptor IMessage.Descriptor => null;

				internal MessageAdapter(Codec codec)
				{
					this.codec = codec;
				}

				internal void Reset()
				{
					Key = codec.keyCodec.DefaultValue;
					Value = codec.valueCodec.DefaultValue;
				}

				public void MergeFrom(CodedInputStream input)
				{
					uint num;
					while ((num = input.ReadTag()) != 0)
					{
						if (num == codec.keyCodec.Tag)
						{
							Key = codec.keyCodec.Read(input);
						}
						else if (num == codec.valueCodec.Tag)
						{
							Value = codec.valueCodec.Read(input);
						}
						else
						{
							input.SkipLastField();
						}
					}
					if (Value == null)
					{
						Value = codec.valueCodec.Read(new CodedInputStream(ZeroLengthMessageStreamData));
					}
				}

				public void WriteTo(CodedOutputStream output)
				{
					codec.keyCodec.WriteTagAndValue(output, Key);
					codec.valueCodec.WriteTagAndValue(output, Value);
				}

				public int CalculateSize()
				{
					return codec.keyCodec.CalculateSizeWithTag(Key) + codec.valueCodec.CalculateSizeWithTag(Value);
				}
			}

			private readonly FieldCodec<TKey> keyCodec;

			private readonly FieldCodec<TValue> valueCodec;

			private readonly uint mapTag;

			internal uint MapTag => mapTag;

			public Codec(FieldCodec<TKey> keyCodec, FieldCodec<TValue> valueCodec, uint mapTag)
			{
				this.keyCodec = keyCodec;
				this.valueCodec = valueCodec;
				this.mapTag = mapTag;
			}
		}

		private class MapView<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection
		{
			private readonly MapField<TKey, TValue> parent;

			private readonly Func<KeyValuePair<TKey, TValue>, T> projection;

			private readonly Func<T, bool> containsCheck;

			public int Count => parent.Count;

			public bool IsReadOnly => true;

			public bool IsSynchronized => false;

			public object SyncRoot => parent;

			internal MapView(MapField<TKey, TValue> parent, Func<KeyValuePair<TKey, TValue>, T> projection, Func<T, bool> containsCheck)
			{
				this.parent = parent;
				this.projection = projection;
				this.containsCheck = containsCheck;
			}

			public void Add(T item)
			{
				throw new NotSupportedException();
			}

			public void Clear()
			{
				throw new NotSupportedException();
			}

			public bool Contains(T item)
			{
				return containsCheck(item);
			}

			public void CopyTo(T[] array, int arrayIndex)
			{
				if (arrayIndex < 0)
				{
					throw new ArgumentOutOfRangeException("arrayIndex");
				}
				if (arrayIndex + Count >= array.Length)
				{
					throw new ArgumentException("Not enough space in the array", "array");
				}
				using IEnumerator<T> enumerator = GetEnumerator();
				while (enumerator.MoveNext())
				{
					T current = enumerator.Current;
					array[arrayIndex++] = current;
				}
			}

			public IEnumerator<T> GetEnumerator()
			{
				return parent.list.Select(projection).GetEnumerator();
			}

			public bool Remove(T item)
			{
				throw new NotSupportedException();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}

			public void CopyTo(Array array, int index)
			{
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				if (index + Count >= array.Length)
				{
					throw new ArgumentException("Not enough space in the array", "array");
				}
				using IEnumerator<T> enumerator = GetEnumerator();
				while (enumerator.MoveNext())
				{
					T current = enumerator.Current;
					array.SetValue(current, index++);
				}
			}
		}

		private readonly Dictionary<TKey, LinkedListNode<KeyValuePair<TKey, TValue>>> map = new Dictionary<TKey, LinkedListNode<KeyValuePair<TKey, TValue>>>();

		private readonly LinkedList<KeyValuePair<TKey, TValue>> list = new LinkedList<KeyValuePair<TKey, TValue>>();

		public TValue this[TKey key]
		{
			get
			{
				ProtoPreconditions.CheckNotNullUnconstrained(key, "key");
				if (TryGetValue(key, out var value))
				{
					return value;
				}
				throw new KeyNotFoundException();
			}
			set
			{
				ProtoPreconditions.CheckNotNullUnconstrained(key, "key");
				if (value == null)
				{
					ProtoPreconditions.CheckNotNullUnconstrained(value, "value");
				}
				KeyValuePair<TKey, TValue> value2 = new KeyValuePair<TKey, TValue>(key, value);
				if (map.TryGetValue(key, out var value3))
				{
					value3.Value = value2;
					return;
				}
				value3 = list.AddLast(value2);
				map[key] = value3;
			}
		}

		public ICollection<TKey> Keys => new MapView<TKey>(this, (KeyValuePair<TKey, TValue> pair) => pair.Key, ContainsKey);

		public ICollection<TValue> Values => new MapView<TValue>(this, (KeyValuePair<TKey, TValue> pair) => pair.Value, ContainsValue);

		public int Count => list.Count;

		public bool IsReadOnly => false;

		bool IDictionary.IsFixedSize => false;

		ICollection IDictionary.Keys => (ICollection)Keys;

		ICollection IDictionary.Values => (ICollection)Values;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => this;

		object IDictionary.this[object key]
		{
			get
			{
				ProtoPreconditions.CheckNotNull(key, "key");
				if (!(key is TKey))
				{
					return null;
				}
				TryGetValue((TKey)key, out var value);
				return value;
			}
			set
			{
				this[(TKey)key] = (TValue)value;
			}
		}

		public MapField<TKey, TValue> Clone()
		{
			MapField<TKey, TValue> mapField = new MapField<TKey, TValue>();
			if (typeof(IDeepCloneable<TValue>).IsAssignableFrom(typeof(TValue)))
			{
				foreach (KeyValuePair<TKey, TValue> item in list)
				{
					mapField.Add(item.Key, ((IDeepCloneable<TValue>)(object)item.Value).Clone());
				}
			}
			else
			{
				mapField.Add(this);
			}
			return mapField;
		}

		public void Add(TKey key, TValue value)
		{
			if (ContainsKey(key))
			{
				throw new ArgumentException("Key already exists in map", "key");
			}
			this[key] = value;
		}

		public bool ContainsKey(TKey key)
		{
			ProtoPreconditions.CheckNotNullUnconstrained(key, "key");
			return map.ContainsKey(key);
		}

		private bool ContainsValue(TValue value)
		{
			EqualityComparer<TValue> comparer = EqualityComparer<TValue>.Default;
			return list.Any((KeyValuePair<TKey, TValue> pair) => comparer.Equals(pair.Value, value));
		}

		public bool Remove(TKey key)
		{
			ProtoPreconditions.CheckNotNullUnconstrained(key, "key");
			if (map.TryGetValue(key, out var value))
			{
				map.Remove(key);
				value.List.Remove(value);
				return true;
			}
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			if (map.TryGetValue(key, out var value2))
			{
				value = value2.Value.Value;
				return true;
			}
			value = default(TValue);
			return false;
		}

		public void Add(IDictionary<TKey, TValue> entries)
		{
			ProtoPreconditions.CheckNotNull(entries, "entries");
			foreach (KeyValuePair<TKey, TValue> entry in entries)
			{
				Add(entry.Key, entry.Value);
			}
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return list.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
			Add(item.Key, item.Value);
		}

		public void Clear()
		{
			list.Clear();
			map.Clear();
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			if (TryGetValue(item.Key, out var value))
			{
				return EqualityComparer<TValue>.Default.Equals(item.Value, value);
			}
			return false;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			list.CopyTo(array, arrayIndex);
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			if (item.Key == null)
			{
				throw new ArgumentException("Key is null", "item");
			}
			if (map.TryGetValue(item.Key, out var value) && EqualityComparer<TValue>.Default.Equals(item.Value, value.Value.Value))
			{
				map.Remove(item.Key);
				value.List.Remove(value);
				return true;
			}
			return false;
		}

		public override bool Equals(object other)
		{
			return Equals(other as MapField<TKey, TValue>);
		}

		public override int GetHashCode()
		{
			EqualityComparer<TValue> equalityComparer = EqualityComparer<TValue>.Default;
			int num = 0;
			foreach (KeyValuePair<TKey, TValue> item in list)
			{
				num ^= item.Key.GetHashCode() * 31 + equalityComparer.GetHashCode(item.Value);
			}
			return num;
		}

		public bool Equals(MapField<TKey, TValue> other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (other.Count != Count)
			{
				return false;
			}
			EqualityComparer<TValue> equalityComparer = EqualityComparer<TValue>.Default;
			using (IEnumerator<KeyValuePair<TKey, TValue>> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<TKey, TValue> current = enumerator.Current;
					if (!other.TryGetValue(current.Key, out var value))
					{
						return false;
					}
					if (!equalityComparer.Equals(value, current.Value))
					{
						return false;
					}
				}
			}
			return true;
		}

		public void AddEntriesFrom(CodedInputStream input, Codec codec)
		{
			Codec.MessageAdapter messageAdapter = new Codec.MessageAdapter(codec);
			do
			{
				messageAdapter.Reset();
				input.ReadMessage(messageAdapter);
				this[messageAdapter.Key] = messageAdapter.Value;
			}
			while (input.MaybeConsumeTag(codec.MapTag));
		}

		public void WriteTo(CodedOutputStream output, Codec codec)
		{
			Codec.MessageAdapter messageAdapter = new Codec.MessageAdapter(codec);
			foreach (KeyValuePair<TKey, TValue> item in list)
			{
				messageAdapter.Key = item.Key;
				messageAdapter.Value = item.Value;
				output.WriteTag(codec.MapTag);
				output.WriteMessage(messageAdapter);
			}
		}

		public int CalculateSize(Codec codec)
		{
			if (Count == 0)
			{
				return 0;
			}
			Codec.MessageAdapter messageAdapter = new Codec.MessageAdapter(codec);
			int num = 0;
			foreach (KeyValuePair<TKey, TValue> item in list)
			{
				messageAdapter.Key = item.Key;
				messageAdapter.Value = item.Value;
				num += CodedOutputStream.ComputeRawVarint32Size(codec.MapTag);
				num += CodedOutputStream.ComputeMessageSize(messageAdapter);
			}
			return num;
		}

		public override string ToString()
		{
			StringWriter stringWriter = new StringWriter();
			JsonFormatter.Default.WriteDictionary(stringWriter, this);
			return stringWriter.ToString();
		}

		void IDictionary.Add(object key, object value)
		{
			Add((TKey)key, (TValue)value);
		}

		bool IDictionary.Contains(object key)
		{
			if (!(key is TKey))
			{
				return false;
			}
			return ContainsKey((TKey)key);
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new DictionaryEnumerator(GetEnumerator());
		}

		void IDictionary.Remove(object key)
		{
			ProtoPreconditions.CheckNotNull(key, "key");
			if (key is TKey)
			{
				Remove((TKey)key);
			}
		}

		void ICollection.CopyTo(Array array, int index)
		{
			((ICollection)this.Select((KeyValuePair<TKey, TValue> pair) => new DictionaryEntry(pair.Key, pair.Value)).ToList()).CopyTo(array, index);
		}
	}
	internal sealed class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		private readonly IDictionary<TKey, TValue> wrapped;

		public ICollection<TKey> Keys => wrapped.Keys;

		public ICollection<TValue> Values => wrapped.Values;

		public TValue this[TKey key]
		{
			get
			{
				return wrapped[key];
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		public int Count => wrapped.Count;

		public bool IsReadOnly => true;

		public ReadOnlyDictionary(IDictionary<TKey, TValue> wrapped)
		{
			this.wrapped = wrapped;
		}

		public void Add(TKey key, TValue value)
		{
			throw new InvalidOperationException();
		}

		public bool ContainsKey(TKey key)
		{
			return wrapped.ContainsKey(key);
		}

		public bool Remove(TKey key)
		{
			throw new InvalidOperationException();
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return wrapped.TryGetValue(key, out value);
		}

		public void Add(KeyValuePair<TKey, TValue> item)
		{
			throw new InvalidOperationException();
		}

		public void Clear()
		{
			throw new InvalidOperationException();
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return wrapped.Contains(item);
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			wrapped.CopyTo(array, arrayIndex);
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			throw new InvalidOperationException();
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return wrapped.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)wrapped).GetEnumerator();
		}

		public override bool Equals(object obj)
		{
			return wrapped.Equals(obj);
		}

		public override int GetHashCode()
		{
			return wrapped.GetHashCode();
		}

		public override string ToString()
		{
			return wrapped.ToString();
		}
	}
	public sealed class RepeatedField<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IDeepCloneable<RepeatedField<T>>, IEquatable<RepeatedField<T>>
	{
		private static readonly T[] EmptyArray = new T[0];

		private const int MinArraySize = 8;

		private T[] array = EmptyArray;

		private int count;

		public int Count => count;

		public bool IsReadOnly => false;

		public T this[int index]
		{
			get
			{
				if (index < 0 || index >= count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return array[index];
			}
			set
			{
				if (index < 0 || index >= count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				ProtoPreconditions.CheckNotNullUnconstrained(value, "value");
				array[index] = value;
			}
		}

		bool IList.IsFixedSize => false;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => this;

		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (T)value;
			}
		}

		public RepeatedField<T> Clone()
		{
			RepeatedField<T> repeatedField = new RepeatedField<T>();
			if (this.array != EmptyArray)
			{
				repeatedField.array = (T[])this.array.Clone();
				if (repeatedField.array is IDeepCloneable<T>[] array)
				{
					for (int i = 0; i < count; i++)
					{
						repeatedField.array[i] = array[i].Clone();
					}
				}
			}
			repeatedField.count = count;
			return repeatedField;
		}

		public void AddEntriesFrom(CodedInputStream input, FieldCodec<T> codec)
		{
			uint lastTag = input.LastTag;
			Func<CodedInputStream, T> valueReader = codec.ValueReader;
			if (FieldCodec<T>.IsPackedRepeatedField(lastTag))
			{
				int num = input.ReadLength();
				if (num > 0)
				{
					int oldLimit = input.PushLimit(num);
					while (!input.ReachedLimit)
					{
						Add(valueReader(input));
					}
					input.PopLimit(oldLimit);
				}
			}
			else
			{
				do
				{
					Add(valueReader(input));
				}
				while (input.MaybeConsumeTag(lastTag));
			}
		}

		public int CalculateSize(FieldCodec<T> codec)
		{
			if (count == 0)
			{
				return 0;
			}
			uint tag = codec.Tag;
			if (codec.PackedRepeatedField)
			{
				int num = CalculatePackedDataSize(codec);
				return CodedOutputStream.ComputeRawVarint32Size(tag) + CodedOutputStream.ComputeLengthSize(num) + num;
			}
			Func<T, int> valueSizeCalculator = codec.ValueSizeCalculator;
			int num2 = count * CodedOutputStream.ComputeRawVarint32Size(tag);
			for (int i = 0; i < count; i++)
			{
				num2 += valueSizeCalculator(array[i]);
			}
			return num2;
		}

		private int CalculatePackedDataSize(FieldCodec<T> codec)
		{
			int fixedSize = codec.FixedSize;
			if (fixedSize == 0)
			{
				Func<T, int> valueSizeCalculator = codec.ValueSizeCalculator;
				int num = 0;
				for (int i = 0; i < count; i++)
				{
					num += valueSizeCalculator(array[i]);
				}
				return num;
			}
			return fixedSize * Count;
		}

		public void WriteTo(CodedOutputStream output, FieldCodec<T> codec)
		{
			if (count == 0)
			{
				return;
			}
			Action<CodedOutputStream, T> valueWriter = codec.ValueWriter;
			uint tag = codec.Tag;
			if (codec.PackedRepeatedField)
			{
				uint value = (uint)CalculatePackedDataSize(codec);
				output.WriteTag(tag);
				output.WriteRawVarint32(value);
				for (int i = 0; i < count; i++)
				{
					valueWriter(output, array[i]);
				}
			}
			else
			{
				for (int j = 0; j < count; j++)
				{
					output.WriteTag(tag);
					valueWriter(output, array[j]);
				}
			}
		}

		private void EnsureSize(int size)
		{
			if (array.Length < size)
			{
				size = Math.Max(size, 8);
				T[] destinationArray = new T[Math.Max(array.Length * 2, size)];
				Array.Copy(array, 0, destinationArray, 0, array.Length);
				array = destinationArray;
			}
		}

		public void Add(T item)
		{
			ProtoPreconditions.CheckNotNullUnconstrained(item, "item");
			EnsureSize(count + 1);
			array[count++] = item;
		}

		public void Clear()
		{
			array = EmptyArray;
			count = 0;
		}

		public bool Contains(T item)
		{
			return IndexOf(item) != -1;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			Array.Copy(this.array, 0, array, arrayIndex, count);
		}

		public bool Remove(T item)
		{
			int num = IndexOf(item);
			if (num == -1)
			{
				return false;
			}
			Array.Copy(array, num + 1, array, num, count - num - 1);
			count--;
			array[count] = default(T);
			return true;
		}

		public void AddRange(IEnumerable<T> values)
		{
			ProtoPreconditions.CheckNotNull(values, "values");
			if (values is RepeatedField<T> repeatedField)
			{
				EnsureSize(count + repeatedField.count);
				Array.Copy(repeatedField.array, 0, array, count, repeatedField.count);
				count += repeatedField.count;
				return;
			}
			if (values is ICollection { Count: var num } collection)
			{
				if (default(T) == null)
				{
					foreach (object item in collection)
					{
						if (item == null)
						{
							throw new ArgumentException("Sequence contained null element", "values");
						}
					}
				}
				EnsureSize(count + num);
				collection.CopyTo(array, count);
				count += num;
				return;
			}
			foreach (T value in values)
			{
				Add(value);
			}
		}

		public void Add(IEnumerable<T> values)
		{
			AddRange(values);
		}

		public IEnumerator<T> GetEnumerator()
		{
			for (int i = 0; i < count; i++)
			{
				yield return array[i];
			}
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as RepeatedField<T>);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public override int GetHashCode()
		{
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				num = num * 31 + array[i].GetHashCode();
			}
			return num;
		}

		public bool Equals(RepeatedField<T> other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			if (other.Count != Count)
			{
				return false;
			}
			EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
			for (int i = 0; i < count; i++)
			{
				if (!equalityComparer.Equals(array[i], other.array[i]))
				{
					return false;
				}
			}
			return true;
		}

		public int IndexOf(T item)
		{
			ProtoPreconditions.CheckNotNullUnconstrained(item, "item");
			EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
			for (int i = 0; i < count; i++)
			{
				if (equalityComparer.Equals(array[i], item))
				{
					return i;
				}
			}
			return -1;
		}

		public void Insert(int index, T item)
		{
			ProtoPreconditions.CheckNotNullUnconstrained(item, "item");
			if (index < 0 || index > count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			EnsureSize(count + 1);
			Array.Copy(array, index, array, index + 1, count - index);
			array[index] = item;
			count++;
		}

		public void RemoveAt(int index)
		{
			if (index < 0 || index >= count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			Array.Copy(array, index + 1, array, index, count - index - 1);
			count--;
			array[count] = default(T);
		}

		public override string ToString()
		{
			StringWriter stringWriter = new StringWriter();
			JsonFormatter.Default.WriteList(stringWriter, this);
			return stringWriter.ToString();
		}

		void ICollection.CopyTo(Array array, int index)
		{
			Array.Copy(this.array, 0, array, index, count);
		}

		int IList.Add(object value)
		{
			Add((T)value);
			return count - 1;
		}

		bool IList.Contains(object value)
		{
			if (value is T)
			{
				return Contains((T)value);
			}
			return false;
		}

		int IList.IndexOf(object value)
		{
			if (!(value is T))
			{
				return -1;
			}
			return IndexOf((T)value);
		}

		void IList.Insert(int index, object value)
		{
			Insert(index, (T)value);
		}

		void IList.Remove(object value)
		{
			if (value is T)
			{
				Remove((T)value);
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;

[assembly: AssemblyVersion("1.0.0.0")]
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class BitPacker
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct IntFloatType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public uint AsUInt;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public float AsFloat;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly int[] REQUIRED_BITS_LOOKUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private object context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private StreamBuffer stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private byte[] buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool isWriting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int totalLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int readBufferOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly byte[] scratchBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int scratchByteIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int scratchBitIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int scratchByteLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private IntFloatType intFloatConverter;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x255CB40", Offset = "0x255BF40", VA = "0x18255CB40")]
		public static int RequiredBits(uint maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x255C200", Offset = "0x255B600", VA = "0x18255C200")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x255D560", Offset = "0x255C960", VA = "0x18255D560")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x255CD10", Offset = "0x255C110", VA = "0x18255CD10")]
		public void StartWriting(StreamBuffer stream, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x255CCD0", Offset = "0x255C0D0", VA = "0x18255CCD0")]
		private void StartWritingInternal(StreamBuffer stream, byte[] buffer, object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x255C0D0", Offset = "0x255B4D0", VA = "0x18255C0D0")]
		public int FinishWriting()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x255CC50", Offset = "0x255C050", VA = "0x18255CC50")]
		public void StartReading(StreamBuffer stream, int length, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x255CC80", Offset = "0x255C080", VA = "0x18255CC80")]
		public void StartReading(byte[] buffer, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x255CC10", Offset = "0x255C010", VA = "0x18255CC10")]
		private void StartReadingInternal(StreamBuffer stream, byte[] buffer, int length, object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x255C0A0", Offset = "0x255B4A0", VA = "0x18255C0A0")]
		public void FinishReading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x255D0E0", Offset = "0x255C4E0", VA = "0x18255D0E0")]
		public void WriteGuid(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x255C5D0", Offset = "0x255B9D0", VA = "0x18255C5D0")]
		public Guid ReadGuid()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x255CED0", Offset = "0x255C2D0", VA = "0x18255CED0")]
		public void WriteBool(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x255C440", Offset = "0x255B840", VA = "0x18255C440")]
		public bool ReadBool()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x255D160", Offset = "0x255C560", VA = "0x18255D160")]
		public void WriteInt(int value, int minimum, int maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x255C6A0", Offset = "0x255BAA0", VA = "0x18255C6A0")]
		public int ReadInt(int minimum, int maximum)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x255CF00", Offset = "0x255C300", VA = "0x18255CF00")]
		public void WriteByte(byte value, byte minimum, byte maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x255D210", Offset = "0x255C610", VA = "0x18255D210")]
		public void WriteUInt(uint value, uint minimum, uint maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x255C460", Offset = "0x255B860", VA = "0x18255C460")]
		public byte ReadByte(byte minimum, byte maximum)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x255C730", Offset = "0x255BB30", VA = "0x18255C730")]
		public uint ReadUInt(uint minimum, uint maximum)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x255D2E0", Offset = "0x255C6E0", VA = "0x18255D2E0")]
		public void WriteVarInt(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x255C7E0", Offset = "0x255BBE0", VA = "0x18255C7E0")]
		public int ReadVarInt()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1482CF0", Offset = "0x14820F0", VA = "0x181482CF0")]
		private static uint EncodeZigZag32(int n)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x14802C0", Offset = "0x147F6C0", VA = "0x1814802C0")]
		private static int DecodeZigZag32(uint n)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x255D350", Offset = "0x255C750", VA = "0x18255D350")]
		public void WriteVarUInt(uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x255D360", Offset = "0x255C760", VA = "0x18255D360")]
		public void WriteVarULong(ulong value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x255C8D0", Offset = "0x255BCD0", VA = "0x18255C8D0")]
		public uint ReadVarUInt()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x255C980", Offset = "0x255BD80", VA = "0x18255C980")]
		public ulong ReadVarULong()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x255CFB0", Offset = "0x255C3B0", VA = "0x18255CFB0")]
		public void WriteFloat(float value, float minimum, float maximum, int bits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x255C4F0", Offset = "0x255B8F0", VA = "0x18255C4F0")]
		public float ReadFloat(float minimum, float maximum, int bits)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x255D2C0", Offset = "0x255C6C0", VA = "0x18255D2C0")]
		public void WriteUncompressedFloat(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x255C7B0", Offset = "0x255BBB0", VA = "0x18255C7B0")]
		public float ReadUncompressedFloat()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB87970", Offset = "0xB86D70", VA = "0x180B87970")]
		public void WriteList<T>(IList<T> list, Action<BitPacker, T> writeElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD83010", Offset = "0xD82410", VA = "0x180D83010")]
		public List<T> ReadList<T>(Func<BitPacker, T> readElement)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x255CD50", Offset = "0x255C150", VA = "0x18255CD50")]
		protected void WriteBits(uint value, int bits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x255C220", Offset = "0x255B620", VA = "0x18255C220")]
		protected uint ReadBits(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x255C110", Offset = "0x255B510", VA = "0x18255C110")]
		private void FlushScratchBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x255CA30", Offset = "0x255BE30", VA = "0x18255CA30")]
		private void RefillScratchBuffer()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}

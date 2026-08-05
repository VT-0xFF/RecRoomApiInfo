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
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public uint AsUInt;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public float AsFloat;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected const int DEFAULT_SCRATCH_BUFFER_SIZE = 128;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly int[] REQUIRED_BITS_LOOKUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private object context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private StreamBuffer stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private byte[] buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool isWriting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int totalLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int readBufferOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly byte[] scratchBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int scratchByteIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int scratchBitIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int scratchByteLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IntFloatType intFloatConverter;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3125910", Offset = "0x3124510", VA = "0x183125910")]
		public static int RequiredBits(uint maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3124FF0", Offset = "0x3123BF0", VA = "0x183124FF0")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3126310", Offset = "0x3124F10", VA = "0x183126310")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3125AE0", Offset = "0x31246E0", VA = "0x183125AE0")]
		public void StartWriting(StreamBuffer stream, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3125AA0", Offset = "0x31246A0", VA = "0x183125AA0")]
		private void StartWritingInternal(StreamBuffer stream, byte[] buffer, object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3124ED0", Offset = "0x3123AD0", VA = "0x183124ED0")]
		public int FinishWriting()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3125A20", Offset = "0x3124620", VA = "0x183125A20")]
		public void StartReading(StreamBuffer stream, int length, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3125A50", Offset = "0x3124650", VA = "0x183125A50")]
		public void StartReading(byte[] buffer, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x31259E0", Offset = "0x31245E0", VA = "0x1831259E0")]
		private void StartReadingInternal(StreamBuffer stream, byte[] buffer, int length, object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3124EA0", Offset = "0x3123AA0", VA = "0x183124EA0")]
		public void FinishReading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3125EA0", Offset = "0x3124AA0", VA = "0x183125EA0")]
		public void WriteGuid(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x31253B0", Offset = "0x3123FB0", VA = "0x1831253B0")]
		public Guid ReadGuid()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3125C90", Offset = "0x3124890", VA = "0x183125C90")]
		public void WriteBool(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3125220", Offset = "0x3123E20", VA = "0x183125220")]
		public bool ReadBool()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3125F20", Offset = "0x3124B20", VA = "0x183125F20")]
		public void WriteInt(int value, int minimum, int maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3125470", Offset = "0x3124070", VA = "0x183125470")]
		public int ReadInt(int minimum, int maximum)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3125CC0", Offset = "0x31248C0", VA = "0x183125CC0")]
		public void WriteByte(byte value, byte minimum, byte maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3125FD0", Offset = "0x3124BD0", VA = "0x183125FD0")]
		public void WriteUInt(uint value, uint minimum, uint maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3125240", Offset = "0x3123E40", VA = "0x183125240")]
		public byte ReadByte(byte minimum, byte maximum)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3125500", Offset = "0x3124100", VA = "0x183125500")]
		public uint ReadUInt(uint minimum, uint maximum)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x31260A0", Offset = "0x3124CA0", VA = "0x1831260A0")]
		public void WriteVarInt(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x31255B0", Offset = "0x31241B0", VA = "0x1831255B0")]
		public int ReadVarInt()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1881D10", Offset = "0x1880910", VA = "0x181881D10")]
		private static uint EncodeZigZag32(int n)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x187F1A0", Offset = "0x187DDA0", VA = "0x18187F1A0")]
		private static int DecodeZigZag32(uint n)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3126110", Offset = "0x3124D10", VA = "0x183126110")]
		public void WriteVarUInt(uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3126120", Offset = "0x3124D20", VA = "0x183126120")]
		public void WriteVarULong(ulong value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x31256A0", Offset = "0x31242A0", VA = "0x1831256A0")]
		public uint ReadVarUInt()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3125750", Offset = "0x3124350", VA = "0x183125750")]
		public ulong ReadVarULong()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3125D70", Offset = "0x3124970", VA = "0x183125D70")]
		public void WriteFloat(float value, float minimum, float maximum, int bits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x31252D0", Offset = "0x3123ED0", VA = "0x1831252D0")]
		public float ReadFloat(float minimum, float maximum, int bits)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3126080", Offset = "0x3124C80", VA = "0x183126080")]
		public void WriteUncompressedFloat(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3125580", Offset = "0x3124180", VA = "0x183125580")]
		public float ReadUncompressedFloat()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xF173A0", Offset = "0xF15FA0", VA = "0x180F173A0")]
		public void WriteList<T>(IList<T> list, Action<BitPacker, T> writeElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1012A90", Offset = "0x1011690", VA = "0x181012A90")]
		public List<T> ReadList<T>(Func<BitPacker, T> readElement)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3125B20", Offset = "0x3124720", VA = "0x183125B20")]
		protected void WriteBits(uint value, int bits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3125010", Offset = "0x3123C10", VA = "0x183125010")]
		protected uint ReadBits(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3124F10", Offset = "0x3123B10", VA = "0x183124F10")]
		private void FlushScratchBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3125800", Offset = "0x3124400", VA = "0x183125800")]
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

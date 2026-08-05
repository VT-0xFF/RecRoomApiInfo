using System;
using System.Collections.Generic;
using System.IO;
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
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public uint AsUInt;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
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
		private StreamBuffer streamBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Stream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Memory<byte> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool isWriting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int totalLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int readBufferOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly byte[] scratchBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int scratchByteIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int scratchBitIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int scratchByteLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IntFloatType intFloatConverter;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA76630", Offset = "0xA75A30", VA = "0x180A76630")]
		public static int RequiredBits(uint maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA75BF0", Offset = "0xA74FF0", VA = "0x180A75BF0")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA770C0", Offset = "0xA764C0", VA = "0x180A770C0")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA76880", Offset = "0xA75C80", VA = "0x180A76880")]
		public void StartWriting(StreamBuffer streamBuffer, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA76830", Offset = "0xA75C30", VA = "0x180A76830")]
		private void StartWritingInternal([Optional] StreamBuffer streamBuffer, [Optional] Memory<byte> buffer, [Optional] Stream stream, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA75960", Offset = "0xA74D60", VA = "0x180A75960")]
		public int FinishWriting()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA767E0", Offset = "0xA75BE0", VA = "0x180A767E0")]
		public void StartReading(StreamBuffer streamBuffer, int length, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA76740", Offset = "0xA75B40", VA = "0x180A76740")]
		public void StartReading(byte[] buffer, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA76700", Offset = "0xA75B00", VA = "0x180A76700")]
		private void StartReadingInternal(int length, [Optional] StreamBuffer streamBuffer, [Optional] Memory<byte> buffer, [Optional] Stream stream, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA75900", Offset = "0xA74D00", VA = "0x180A75900")]
		public void FinishReading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA76C50", Offset = "0xA76050", VA = "0x180A76C50")]
		public void WriteGuid(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA75FB0", Offset = "0xA753B0", VA = "0x180A75FB0")]
		public Guid ReadGuid()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA76A40", Offset = "0xA75E40", VA = "0x180A76A40")]
		public void WriteBool(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA75E20", Offset = "0xA75220", VA = "0x180A75E20")]
		public bool ReadBool()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA76CD0", Offset = "0xA760D0", VA = "0x180A76CD0")]
		public void WriteInt(int value, int minimum, int maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA76070", Offset = "0xA75470", VA = "0x180A76070")]
		public int ReadInt(int minimum, int maximum)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA76A70", Offset = "0xA75E70", VA = "0x180A76A70")]
		public void WriteByte(byte value, byte minimum, byte maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA76D80", Offset = "0xA76180", VA = "0x180A76D80")]
		public void WriteUInt(uint value, uint minimum, uint maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA75E40", Offset = "0xA75240", VA = "0x180A75E40")]
		public byte ReadByte(byte minimum, byte maximum)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA76100", Offset = "0xA75500", VA = "0x180A76100")]
		public uint ReadUInt(uint minimum, uint maximum)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA76E50", Offset = "0xA76250", VA = "0x180A76E50")]
		public void WriteVarInt(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA761B0", Offset = "0xA755B0", VA = "0x180A761B0")]
		public int ReadVarInt()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA758F0", Offset = "0xA74CF0", VA = "0x180A758F0")]
		private static uint EncodeZigZag32(int n)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA758E0", Offset = "0xA74CE0", VA = "0x180A758E0")]
		private static int DecodeZigZag32(uint n)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA76EC0", Offset = "0xA762C0", VA = "0x180A76EC0")]
		public void WriteVarUInt(uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA76ED0", Offset = "0xA762D0", VA = "0x180A76ED0")]
		public void WriteVarULong(ulong value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA762A0", Offset = "0xA756A0", VA = "0x180A762A0")]
		public uint ReadVarUInt()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA76350", Offset = "0xA75750", VA = "0x180A76350")]
		public ulong ReadVarULong()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA76B20", Offset = "0xA75F20", VA = "0x180A76B20")]
		public void WriteFloat(float value, float minimum, float maximum, int bits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA75ED0", Offset = "0xA752D0", VA = "0x180A75ED0")]
		public float ReadFloat(float minimum, float maximum, int bits)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA76E30", Offset = "0xA76230", VA = "0x180A76E30")]
		public void WriteUncompressedFloat(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA76180", Offset = "0xA75580", VA = "0x180A76180")]
		public float ReadUncompressedFloat()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1782500", Offset = "0x1781900", VA = "0x181782500")]
		public void WriteList<T>(IList<T> list, Action<BitPacker, T> writeElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1C5FCC0", Offset = "0x1C5F0C0", VA = "0x181C5FCC0")]
		public List<T> ReadList<T>(Func<BitPacker, T> readElement)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA768D0", Offset = "0xA75CD0", VA = "0x180A768D0")]
		public void WriteBits(uint value, int bits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA75C10", Offset = "0xA75010", VA = "0x180A75C10")]
		public uint ReadBits(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA759E0", Offset = "0xA74DE0", VA = "0x180A759E0")]
		private void FlushScratchBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA76400", Offset = "0xA75800", VA = "0x180A76400")]
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

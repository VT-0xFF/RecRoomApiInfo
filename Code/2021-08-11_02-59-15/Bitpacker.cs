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
		[Cpp2IlInjected.Address(RVA = "0x894350", Offset = "0x893750", VA = "0x180894350")]
		public static int RequiredBits(uint maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x893A30", Offset = "0x892E30", VA = "0x180893A30")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x894D50", Offset = "0x894150", VA = "0x180894D50")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x894520", Offset = "0x893920", VA = "0x180894520")]
		public void StartWriting(StreamBuffer stream, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8944E0", Offset = "0x8938E0", VA = "0x1808944E0")]
		private void StartWritingInternal(StreamBuffer stream, byte[] buffer, object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x893910", Offset = "0x892D10", VA = "0x180893910")]
		public int FinishWriting()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893860", VA = "0x180894460")]
		public void StartReading(StreamBuffer stream, int length, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		public void StartReading(byte[] buffer, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x894420", Offset = "0x893820", VA = "0x180894420")]
		private void StartReadingInternal(StreamBuffer stream, byte[] buffer, int length, object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8938E0", Offset = "0x892CE0", VA = "0x1808938E0")]
		public void FinishReading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8948E0", Offset = "0x893CE0", VA = "0x1808948E0")]
		public void WriteGuid(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x893DF0", Offset = "0x8931F0", VA = "0x180893DF0")]
		public Guid ReadGuid()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8946D0", Offset = "0x893AD0", VA = "0x1808946D0")]
		public void WriteBool(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x893C60", Offset = "0x893060", VA = "0x180893C60")]
		public bool ReadBool()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960")]
		public void WriteInt(int value, int minimum, int maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x893EB0", Offset = "0x8932B0", VA = "0x180893EB0")]
		public int ReadInt(int minimum, int maximum)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x894700", Offset = "0x893B00", VA = "0x180894700")]
		public void WriteByte(byte value, byte minimum, byte maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x894A10", Offset = "0x893E10", VA = "0x180894A10")]
		public void WriteUInt(uint value, uint minimum, uint maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x893C80", Offset = "0x893080", VA = "0x180893C80")]
		public byte ReadByte(byte minimum, byte maximum)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x893F40", Offset = "0x893340", VA = "0x180893F40")]
		public uint ReadUInt(uint minimum, uint maximum)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x894AE0", Offset = "0x893EE0", VA = "0x180894AE0")]
		public void WriteVarInt(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x893FF0", Offset = "0x8933F0", VA = "0x180893FF0")]
		public int ReadVarInt()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x42F3B0", Offset = "0x42E7B0", VA = "0x18042F3B0")]
		private static uint EncodeZigZag32(int n)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x42C800", Offset = "0x42BC00", VA = "0x18042C800")]
		private static int DecodeZigZag32(uint n)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x894B50", Offset = "0x893F50", VA = "0x180894B50")]
		public void WriteVarUInt(uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x894B60", Offset = "0x893F60", VA = "0x180894B60")]
		public void WriteVarULong(ulong value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8940E0", Offset = "0x8934E0", VA = "0x1808940E0")]
		public uint ReadVarUInt()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x894190", Offset = "0x893590", VA = "0x180894190")]
		public ulong ReadVarULong()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8947B0", Offset = "0x893BB0", VA = "0x1808947B0")]
		public void WriteFloat(float value, float minimum, float maximum, int bits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x893D10", Offset = "0x893110", VA = "0x180893D10")]
		public float ReadFloat(float minimum, float maximum, int bits)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x894AC0", Offset = "0x893EC0", VA = "0x180894AC0")]
		public void WriteUncompressedFloat(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x893FC0", Offset = "0x8933C0", VA = "0x180893FC0")]
		public float ReadUncompressedFloat()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x14B5E80", Offset = "0x14B5280", VA = "0x1814B5E80")]
		public void WriteList<T>(IList<T> list, Action<BitPacker, T> writeElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2740520", Offset = "0x273F920", VA = "0x182740520")]
		public List<T> ReadList<T>(Func<BitPacker, T> readElement)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x894560", Offset = "0x893960", VA = "0x180894560")]
		protected void WriteBits(uint value, int bits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x893A50", Offset = "0x892E50", VA = "0x180893A50")]
		protected uint ReadBits(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x893950", Offset = "0x892D50", VA = "0x180893950")]
		private void FlushScratchBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x894240", Offset = "0x893640", VA = "0x180894240")]
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

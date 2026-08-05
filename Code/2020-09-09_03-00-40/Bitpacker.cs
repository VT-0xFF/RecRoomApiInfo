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
		[Cpp2IlInjected.Address(RVA = "0xDD8720", Offset = "0xDD7320", VA = "0x180DD8720")]
		public static int RequiredBits(uint maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xDD7E00", Offset = "0xDD6A00", VA = "0x180DD7E00")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xDD9120", Offset = "0xDD7D20", VA = "0x180DD9120")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xDD88F0", Offset = "0xDD74F0", VA = "0x180DD88F0")]
		public void StartWriting(StreamBuffer stream, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xDD88B0", Offset = "0xDD74B0", VA = "0x180DD88B0")]
		private void StartWritingInternal(StreamBuffer stream, byte[] buffer, object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xDD7CE0", Offset = "0xDD68E0", VA = "0x180DD7CE0")]
		public int FinishWriting()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xDD8830", Offset = "0xDD7430", VA = "0x180DD8830")]
		public void StartReading(StreamBuffer stream, int length, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDD8860", Offset = "0xDD7460", VA = "0x180DD8860")]
		public void StartReading(byte[] buffer, [Optional] object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDD87F0", Offset = "0xDD73F0", VA = "0x180DD87F0")]
		private void StartReadingInternal(StreamBuffer stream, byte[] buffer, int length, object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDD7CB0", Offset = "0xDD68B0", VA = "0x180DD7CB0")]
		public void FinishReading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDD8CB0", Offset = "0xDD78B0", VA = "0x180DD8CB0")]
		public void WriteGuid(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDD81C0", Offset = "0xDD6DC0", VA = "0x180DD81C0")]
		public Guid ReadGuid()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xDD8AA0", Offset = "0xDD76A0", VA = "0x180DD8AA0")]
		public void WriteBool(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xDD8030", Offset = "0xDD6C30", VA = "0x180DD8030")]
		public bool ReadBool()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xDD8D30", Offset = "0xDD7930", VA = "0x180DD8D30")]
		public void WriteInt(int value, int minimum, int maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xDD8280", Offset = "0xDD6E80", VA = "0x180DD8280")]
		public int ReadInt(int minimum, int maximum)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDD8AD0", Offset = "0xDD76D0", VA = "0x180DD8AD0")]
		public void WriteByte(byte value, byte minimum, byte maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xDD8DE0", Offset = "0xDD79E0", VA = "0x180DD8DE0")]
		public void WriteUInt(uint value, uint minimum, uint maximum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDD8050", Offset = "0xDD6C50", VA = "0x180DD8050")]
		public byte ReadByte(byte minimum, byte maximum)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xDD8310", Offset = "0xDD6F10", VA = "0x180DD8310")]
		public uint ReadUInt(uint minimum, uint maximum)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xDD8EB0", Offset = "0xDD7AB0", VA = "0x180DD8EB0")]
		public void WriteVarInt(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xDD83C0", Offset = "0xDD6FC0", VA = "0x180DD83C0")]
		public int ReadVarInt()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5C10C0", Offset = "0x5BFCC0", VA = "0x1805C10C0")]
		private static uint EncodeZigZag32(int n)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5BE540", Offset = "0x5BD140", VA = "0x1805BE540")]
		private static int DecodeZigZag32(uint n)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xDD8F20", Offset = "0xDD7B20", VA = "0x180DD8F20")]
		public void WriteVarUInt(uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xDD8F30", Offset = "0xDD7B30", VA = "0x180DD8F30")]
		public void WriteVarULong(ulong value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xDD84B0", Offset = "0xDD70B0", VA = "0x180DD84B0")]
		public uint ReadVarUInt()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xDD8560", Offset = "0xDD7160", VA = "0x180DD8560")]
		public ulong ReadVarULong()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xDD8B80", Offset = "0xDD7780", VA = "0x180DD8B80")]
		public void WriteFloat(float value, float minimum, float maximum, int bits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xDD80E0", Offset = "0xDD6CE0", VA = "0x180DD80E0")]
		public float ReadFloat(float minimum, float maximum, int bits)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xDD8E90", Offset = "0xDD7A90", VA = "0x180DD8E90")]
		public void WriteUncompressedFloat(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xDD8390", Offset = "0xDD6F90", VA = "0x180DD8390")]
		public float ReadUncompressedFloat()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1B68CF0", Offset = "0x1B678F0", VA = "0x181B68CF0")]
		public void WriteList<T>(IList<T> list, Action<BitPacker, T> writeElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1DEFBD0", Offset = "0x1DEE7D0", VA = "0x181DEFBD0")]
		public List<T> ReadList<T>(Func<BitPacker, T> readElement)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xDD8930", Offset = "0xDD7530", VA = "0x180DD8930")]
		protected void WriteBits(uint value, int bits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xDD7E20", Offset = "0xDD6A20", VA = "0x180DD7E20")]
		protected uint ReadBits(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDD7D20", Offset = "0xDD6920", VA = "0x180DD7D20")]
		private void FlushScratchBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xDD8610", Offset = "0xDD7210", VA = "0x180DD8610")]
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

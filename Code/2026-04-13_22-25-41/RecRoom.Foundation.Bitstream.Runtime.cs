using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class SVGOSYYBXCW
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
	public SVGOSYYBXCW()
	{
	}
}
namespace _LogRegistration.RecRoom_Foundation_Bitstream_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9857D40", Offset = "0x9856740", VA = "0x189857D40", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Foundation.Bitstream
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public ref struct BitstreamReader
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public delegate BitstreamReader RefillHandler(BitstreamReader ctx);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		internal readonly ReadOnlySpan<byte> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly RefillHandler refillCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int byteOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal int bitOffset;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9857C50", Offset = "0x9856650", VA = "0x189857C50")]
		public BitstreamReader(ReadOnlySpan<byte> data, int byteOffset = 0, int bitOffset = 0, [Optional] RefillHandler refillCallback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class NIHXXVQXKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9857DC0", Offset = "0x98567C0", VA = "0x189857DC0")]
		public static int IYAIHYLFMYV(this BitstreamReader a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9857EF0", Offset = "0x98568F0", VA = "0x189857EF0")]
		public static int RRMMSEEBFVQ(this BitstreamReader a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9857EA0", Offset = "0x98568A0", VA = "0x189857EA0")]
		public static uint KAHREDSGUMZ(this BitstreamReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class XJQQSJJNYYU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class OVZGJYVQUIK
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct LongDoubleType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public uint AsUInt0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public uint AsUInt1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public double AsDouble;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class SXIWCWKUPSV
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct IntFloatType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public uint AsUInt;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public float AsFloat;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class UFGQRWWDSQW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class XJGGJBLKWIR
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly int[] EOVFAGHEFRO;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9859240", Offset = "0x9857C40", VA = "0x189859240")]
		public static int PSXQLGNKUYI(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9859020", Offset = "0x9857A20", VA = "0x189859020")]
		public static uint LBRPXEPOOCX(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x98594E0", Offset = "0x9857EE0", VA = "0x1898594E0")]
		private static uint YHGTIGRRUDW(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9859090", Offset = "0x9857A90", VA = "0x189859090")]
		public static int LHJMSQXESMN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x98592F0", Offset = "0x9857CF0", VA = "0x1898592F0")]
		public static int RRMMSEEBFVQ(BitstreamReader a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9858F10", Offset = "0x9857910", VA = "0x189858F10")]
		public static uint KAHREDSGUMZ(BitstreamReader a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9859150", Offset = "0x9857B50", VA = "0x189859150")]
		public static ulong PQPFPYNJYBM(BitstreamReader a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9858B20", Offset = "0x9857520", VA = "0x189858B20")]
		public static int IYAIHYLFMYV(int a, int b, BitstreamReader c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9859480", Offset = "0x9857E80", VA = "0x189859480")]
		public static uint WSEIXPTTMVK(int a, BitstreamReader b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x98582C0", Offset = "0x9856CC0", VA = "0x1898582C0")]
		public static uint AHSIEYCLJYE(int a, BitstreamReader b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9858A40", Offset = "0x9857440", VA = "0x189858A40")]
		private static void FHLKBFAEXIJ(BitstreamReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9858690", Offset = "0x9857090", VA = "0x189858690")]
		public static void AQJRYHTKZNK(int a, int b, int c, BitstreamWriter d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x98590B0", Offset = "0x9857AB0", VA = "0x1898590B0")]
		public static void NTRHRNVJHMB(int a, BitstreamWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x98594F0", Offset = "0x9857EF0", VA = "0x1898594F0")]
		public static void YNVTXPOZPPS(uint a, BitstreamWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9858BD0", Offset = "0x98575D0", VA = "0x189858BD0")]
		public static void JLTOBFFIMVL(ulong a, BitstreamWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9858770", Offset = "0x9857170", VA = "0x189858770")]
		public static void CCBUTKFHHQX(uint a, int b, BitstreamWriter c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9859400", Offset = "0x9857E00", VA = "0x189859400")]
		private static void UNBBADTZQTL(BitstreamWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9859350", Offset = "0x9857D50", VA = "0x189859350")]
		private static ulong RZLRTYJOIYR(ulong a, BitstreamWriter b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9858750", Offset = "0x9857150", VA = "0x189858750")]
		public static int BYECBTFIBDE(BitstreamWriter a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class TFNDBRXJUXS
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86955B0", Offset = "0x8693FB0", VA = "0x1886955B0")]
		public static int XPJVHPJIREP(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86B84F0", Offset = "0x86B6EF0", VA = "0x1886B84F0")]
		public static uint RRDDCWFSCMD(int a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public ref struct BitstreamWriter
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class PKXBGBCPIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log KZEIFDHBWKO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal readonly Span<byte> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal int byteOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal int bitOffset;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ReadOnlySpan<byte> GBDQURFEUCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9857C70", Offset = "0x9856670", VA = "0x189857C70")]
			get
			{
				return default(ReadOnlySpan<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFB10", Offset = "0x2AEE510", VA = "0x182AEFB10")]
		public BitstreamWriter(Span<byte> data, int byteOffset = 0, int bitOffset = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class NYMFMDWMOBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9857F80", Offset = "0x9856980", VA = "0x189857F80")]
		public static void AQJRYHTKZNK(this BitstreamWriter a, int b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98580D0", Offset = "0x9856AD0", VA = "0x1898580D0")]
		public static void NTRHRNVJHMB(this BitstreamWriter a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x98581A0", Offset = "0x9856BA0", VA = "0x1898581A0")]
		public static void YNVTXPOZPPS(this BitstreamWriter a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9858070", Offset = "0x9856A70", VA = "0x189858070")]
		public static int IWGKOYRBAJT(this BitstreamWriter a)
		{
			return default(int);
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

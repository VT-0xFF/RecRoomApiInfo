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
internal class IXBFVIJSSFJ
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
	[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
	public IXBFVIJSSFJ()
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
		[Cpp2IlInjected.Address(RVA = "0x99C3C00", Offset = "0x99C2600", VA = "0x1899C3C00", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x99C3950", Offset = "0x99C2350", VA = "0x1899C3950")]
		public BitstreamReader(ReadOnlySpan<byte> data, int byteOffset = 0, int bitOffset = 0, [Optional] RefillHandler refillCallback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class DQAOXHZHMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99C3AD0", Offset = "0x99C24D0", VA = "0x1899C3AD0")]
		public static int YGIOOONRVBE(this BitstreamReader a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99C3A40", Offset = "0x99C2440", VA = "0x1899C3A40")]
		public static int JYDXORXYWLF(this BitstreamReader a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99C3BB0", Offset = "0x99C25B0", VA = "0x1899C3BB0")]
		public static uint ZVCSQBZGEJE(this BitstreamReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class OFFNTCLOIDH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class VLAVTTVESMT
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
	public static class CUVGVBGVPLI
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
	public static class GMXFWKTZKVZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class MWJDHFEUNRO
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly int[] EIJRHUFPAQN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99C4330", Offset = "0x99C2D30", VA = "0x1899C4330")]
		public static int OZIILGIDOQX(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99C4C80", Offset = "0x99C3680", VA = "0x1899C4C80")]
		public static uint WWNASOFYIUY(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99C45B0", Offset = "0x99C2FB0", VA = "0x1899C45B0")]
		private static uint RYVZLEYMFHF(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99C41B0", Offset = "0x99C2BB0", VA = "0x1899C41B0")]
		public static int JJCCXPGAAVW(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99C41D0", Offset = "0x99C2BD0", VA = "0x1899C41D0")]
		public static int JYDXORXYWLF(BitstreamReader a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99C4E00", Offset = "0x99C3800", VA = "0x1899C4E00")]
		public static uint ZVCSQBZGEJE(BitstreamReader a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99C44C0", Offset = "0x99C2EC0", VA = "0x1899C44C0")]
		public static ulong QIBQPIPKHNF(BitstreamReader a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99C4CF0", Offset = "0x99C36F0", VA = "0x1899C4CF0")]
		public static int YGIOOONRVBE(int a, int b, BitstreamReader c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99C43E0", Offset = "0x99C2DE0", VA = "0x1899C43E0")]
		public static uint PEEVVQQGQYV(int a, BitstreamReader b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99C3D40", Offset = "0x99C2740", VA = "0x1899C3D40")]
		public static uint FPEWAJHHINR(int a, BitstreamReader b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x99C4230", Offset = "0x99C2C30", VA = "0x1899C4230")]
		private static void KQPWZPOYECC(BitstreamReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99C3C80", Offset = "0x99C2680", VA = "0x1899C3C80")]
		public static void BJRCNMZBKZH(int a, int b, int c, BitstreamWriter d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99C4110", Offset = "0x99C2B10", VA = "0x1899C4110")]
		public static void FYNASIKQSMS(int a, BitstreamWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99C4DA0", Offset = "0x99C37A0", VA = "0x1899C4DA0")]
		public static void YZTAZOTNXAB(uint a, BitstreamWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99C4670", Offset = "0x99C3070", VA = "0x1899C4670")]
		public static void TLJMXKSEGAS(ulong a, BitstreamWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99C49B0", Offset = "0x99C33B0", VA = "0x1899C49B0")]
		public static void WJUSEHRXXRK(uint a, int b, BitstreamWriter c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99C4440", Offset = "0x99C2E40", VA = "0x1899C4440")]
		private static void PGCYPKPYFIQ(BitstreamWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99C45C0", Offset = "0x99C2FC0", VA = "0x1899C45C0")]
		private static ulong SPGFTLODKOO(ulong a, BitstreamWriter b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x99C4310", Offset = "0x99C2D10", VA = "0x1899C4310")]
		public static int LOMLKNASVXH(BitstreamWriter a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class IGQFNQMMAQL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x87FD5C0", Offset = "0x87FBFC0", VA = "0x1887FD5C0")]
		public static int NNIEIDSQSEE(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8820530", Offset = "0x881EF30", VA = "0x188820530")]
		public static uint FPVWLIYBVIQ(int a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public ref struct BitstreamWriter
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class ZKMWEVBPGQU
		{
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log KNJEMMUNATP;
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
		public ReadOnlySpan<byte> CXTVOWDYCYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x99C3970", Offset = "0x99C2370", VA = "0x1899C3970")]
			get
			{
				return default(ReadOnlySpan<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B25B50", Offset = "0x2B24550", VA = "0x182B25B50")]
		public BitstreamWriter(Span<byte> data, int byteOffset = 0, int bitOffset = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class YEPKVIKVIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99C4FA0", Offset = "0x99C39A0", VA = "0x1899C4FA0")]
		public static void BJRCNMZBKZH(this BitstreamWriter a, int b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99C5090", Offset = "0x99C3A90", VA = "0x1899C5090")]
		public static void FYNASIKQSMS(this BitstreamWriter a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99C51C0", Offset = "0x99C3BC0", VA = "0x1899C51C0")]
		public static void YZTAZOTNXAB(this BitstreamWriter a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99C5160", Offset = "0x99C3B60", VA = "0x1899C5160")]
		public static int PMZAMVALXHI(this BitstreamWriter a)
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

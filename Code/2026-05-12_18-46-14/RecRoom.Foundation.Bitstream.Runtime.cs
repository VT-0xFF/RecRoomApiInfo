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
internal class TMRYTQGXOHE
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
	[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
	public TMRYTQGXOHE()
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
		[Cpp2IlInjected.Address(RVA = "0x99A5B40", Offset = "0x99A4540", VA = "0x1899A5B40", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99A44F0", Offset = "0x99A2EF0", VA = "0x1899A44F0")]
		public BitstreamReader(ReadOnlySpan<byte> data, int byteOffset = 0, int bitOffset = 0, [Optional] RefillHandler refillCallback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class IALBQUHPONY
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99A5950", Offset = "0x99A4350", VA = "0x1899A5950")]
		public static int HIFHBNCGMQZ(this BitstreamReader a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99A5A30", Offset = "0x99A4430", VA = "0x1899A5A30")]
		public static int JEFSJGICRNE(this BitstreamReader a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99A5900", Offset = "0x99A4300", VA = "0x1899A5900")]
		public static uint CEVYCDSDPEB(this BitstreamReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EAGUUHMGJNC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ZNEIZTJBSDI
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
	public static class BGVTDJJDIXD
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
	public static class XCABDBRIUKG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class CRJSTHGSHQR
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly int[] NTMSTEYZOYQ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99A4F90", Offset = "0x99A3990", VA = "0x1899A4F90")]
		public static int IWFXGTFBJQQ(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99A5800", Offset = "0x99A4200", VA = "0x1899A5800")]
		public static uint XXKSPQMGSTJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99A5490", Offset = "0x99A3E90", VA = "0x1899A5490")]
		private static uint TTEHLGTUPKI(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99A54A0", Offset = "0x99A3EA0", VA = "0x1899A54A0")]
		public static int UBESBCMUNWB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99A5040", Offset = "0x99A3A40", VA = "0x1899A5040")]
		public static int JEFSJGICRNE(BitstreamReader a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99A4DD0", Offset = "0x99A37D0", VA = "0x1899A4DD0")]
		public static uint CEVYCDSDPEB(BitstreamReader a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99A53A0", Offset = "0x99A3DA0", VA = "0x1899A53A0")]
		public static ulong THXSHZJRNDY(BitstreamReader a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99A4EE0", Offset = "0x99A38E0", VA = "0x1899A4EE0")]
		public static int HIFHBNCGMQZ(int a, int b, BitstreamReader c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99A5340", Offset = "0x99A3D40", VA = "0x1899A5340")]
		public static uint TFUVJQOMAPK(int a, BitstreamReader b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99A4980", Offset = "0x99A3380", VA = "0x1899A4980")]
		public static uint BQKTWCZPQRK(int a, BitstreamReader b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x99A50A0", Offset = "0x99A3AA0", VA = "0x1899A50A0")]
		private static void JJCVBWVKRXP(BitstreamReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99A5220", Offset = "0x99A3C20", VA = "0x1899A5220")]
		public static void LYBYTMRTFRG(int a, int b, int c, BitstreamWriter d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99A5180", Offset = "0x99A3B80", VA = "0x1899A5180")]
		public static void JXCAHELXMSN(int a, BitstreamWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99A52E0", Offset = "0x99A3CE0", VA = "0x1899A52E0")]
		public static void QLFLSOUNNZS(uint a, BitstreamWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99A54C0", Offset = "0x99A3EC0", VA = "0x1899A54C0")]
		public static void UXBWVJPLFZL(ulong a, BitstreamWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99A4600", Offset = "0x99A3000", VA = "0x1899A4600")]
		public static void BDXJXHHKLMT(uint a, int b, BitstreamWriter c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99A4D50", Offset = "0x99A3750", VA = "0x1899A4D50")]
		private static void BYTXJZXMLCF(BitstreamWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99A48D0", Offset = "0x99A32D0", VA = "0x1899A48D0")]
		private static ulong BOZFFVVTDVH(ulong a, BitstreamWriter b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x99A45E0", Offset = "0x99A2FE0", VA = "0x1899A45E0")]
		public static int AZBCXZQNDYG(BitstreamWriter a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class YSUAADBCXYA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x87F3810", Offset = "0x87F2210", VA = "0x1887F3810")]
		public static int LUVWDFLXZGX(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8816470", Offset = "0x8814E70", VA = "0x188816470")]
		public static uint AKRWMKALQUH(int a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public ref struct BitstreamWriter
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class IFUUXGAGFIX
		{
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log OMWAZFACTUS;
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
		public ReadOnlySpan<byte> PCXYAUBOJTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x99A4510", Offset = "0x99A2F10", VA = "0x1899A4510")]
			get
			{
				return default(ReadOnlySpan<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E5B0", Offset = "0x2B0CFB0", VA = "0x182B0E5B0")]
		public BitstreamWriter(Span<byte> data, int byteOffset = 0, int bitOffset = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class MLZMBDGJFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99A5C90", Offset = "0x99A4690", VA = "0x1899A5C90")]
		public static void LYBYTMRTFRG(this BitstreamWriter a, int b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99A5BC0", Offset = "0x99A45C0", VA = "0x1899A5BC0")]
		public static void JXCAHELXMSN(this BitstreamWriter a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99A5D80", Offset = "0x99A4780", VA = "0x1899A5D80")]
		public static void QLFLSOUNNZS(this BitstreamWriter a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99A5E10", Offset = "0x99A4810", VA = "0x1899A5E10")]
		public static int WZDARLRHBLH(this BitstreamWriter a)
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

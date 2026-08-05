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
internal class UFSCIDMSTJW
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
	[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
	public UFSCIDMSTJW()
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
		[Cpp2IlInjected.Address(RVA = "0x99B8CC0", Offset = "0x99B7CC0", VA = "0x1899B8CC0", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x99B8760", Offset = "0x99B7760", VA = "0x1899B8760")]
		public BitstreamReader(ReadOnlySpan<byte> data, int byteOffset = 0, int bitOffset = 0, [Optional] RefillHandler refillCallback)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HHKDCXLAZJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99B8850", Offset = "0x99B7850", VA = "0x1899B8850")]
		public static int SRZOMTPTEDB(this BitstreamReader a, int b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99B8980", Offset = "0x99B7980", VA = "0x1899B8980")]
		public static int XSXMZXXVXAY(this BitstreamReader a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99B8930", Offset = "0x99B7930", VA = "0x1899B8930")]
		public static uint XAMJLVGAHYP(this BitstreamReader a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class DGFBUTQWXVU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EHFTPUYKKYU
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
	public static class UYYLOREZZLR
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
	public static class LRFCCGRPCSU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class AMUDJNVSKPF
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly int[] ITALHPRQDWK;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99B7810", Offset = "0x99B6810", VA = "0x1899B7810")]
		public static int DCSBEVRSWLI(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99B7AC0", Offset = "0x99B6AC0", VA = "0x1899B7AC0")]
		public static uint MZUJBMYOVMJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99B86C0", Offset = "0x99B76C0", VA = "0x1899B86C0")]
		private static uint YYZYZJDUMYS(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99B78C0", Offset = "0x99B68C0", VA = "0x1899B78C0")]
		public static int HWXYPTUENFN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99B8550", Offset = "0x99B7550", VA = "0x1899B8550")]
		public static int XSXMZXXVXAY(BitstreamReader a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99B8380", Offset = "0x99B7380", VA = "0x1899B8380")]
		public static uint XAMJLVGAHYP(BitstreamReader a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99B8290", Offset = "0x99B7290", VA = "0x1899B8290")]
		public static ulong TWMTFJUDMQE(BitstreamReader a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99B81E0", Offset = "0x99B71E0", VA = "0x1899B81E0")]
		public static int SRZOMTPTEDB(int a, int b, BitstreamReader c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99B78E0", Offset = "0x99B68E0", VA = "0x1899B78E0")]
		public static uint KQBLNDLQRNA(int a, BitstreamReader b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99B7440", Offset = "0x99B6440", VA = "0x1899B7440")]
		public static uint CZJYJDPMYYG(int a, BitstreamReader b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x99B79E0", Offset = "0x99B69E0", VA = "0x1899B79E0")]
		private static void LMEGQOCUUAT(BitstreamReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99B8490", Offset = "0x99B7490", VA = "0x1899B8490")]
		public static void XBZMJMQYWBI(int a, int b, int c, BitstreamWriter d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99B7940", Offset = "0x99B6940", VA = "0x1899B7940")]
		public static void KTHTSHEGMFZ(int a, BitstreamWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99B8660", Offset = "0x99B7660", VA = "0x1899B8660")]
		public static void YUJQANUWRCG(uint a, BitstreamWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99B7E80", Offset = "0x99B6E80", VA = "0x1899B7E80")]
		public static void PVBKVIITRMP(ulong a, BitstreamWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99B7BB0", Offset = "0x99B6BB0", VA = "0x1899B7BB0")]
		public static void OEZSGADWXFH(uint a, int b, BitstreamWriter c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99B7B30", Offset = "0x99B6B30", VA = "0x1899B7B30")]
		private static void NQLXQOQGSWH(BitstreamWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99B85B0", Offset = "0x99B75B0", VA = "0x1899B85B0")]
		private static ulong YLUEDWBBQHR(ulong a, BitstreamWriter b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x99B81C0", Offset = "0x99B71C0", VA = "0x1899B81C0")]
		public static int QQOEOTSMFAM(BitstreamWriter a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class TDFEZOECPYG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x87F23F0", Offset = "0x87F13F0", VA = "0x1887F23F0")]
		public static int AIKYPSPXSVX(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8815330", Offset = "0x8814330", VA = "0x188815330")]
		public static uint JLOQOCFJIDP(int a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public ref struct BitstreamWriter
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class RFGVZIOOVTL
		{
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log NSTUKEGGGWA;
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
		public ReadOnlySpan<byte> RWYDMHOFPJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x99B8780", Offset = "0x99B7780", VA = "0x1899B8780")]
			get
			{
				return default(ReadOnlySpan<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2AF14F0", Offset = "0x2AF04F0", VA = "0x182AF14F0")]
		public BitstreamWriter(Span<byte> data, int byteOffset = 0, int bitOffset = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class JDWDQTWKWFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99B8B40", Offset = "0x99B7B40", VA = "0x1899B8B40")]
		public static void XBZMJMQYWBI(this BitstreamWriter a, int b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99B8A10", Offset = "0x99B7A10", VA = "0x1899B8A10")]
		public static void KTHTSHEGMFZ(this BitstreamWriter a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99B8C30", Offset = "0x99B7C30", VA = "0x1899B8C30")]
		public static void YUJQANUWRCG(this BitstreamWriter a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99B8AE0", Offset = "0x99B7AE0", VA = "0x1899B8AE0")]
		public static int MSZAGIMVWMD(this BitstreamWriter a)
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

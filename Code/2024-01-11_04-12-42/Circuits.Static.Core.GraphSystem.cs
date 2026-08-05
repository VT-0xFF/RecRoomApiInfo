using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1D1A8B0", Offset = "0x1D192B0", VA = "0x181D1A8B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B8FA0", VA = "0x1807BA5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NBIHIIGMJMA<TMInput, TMOutput, TMNode> : IEnumerator<MCAPNBAEEIC<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CADOAGFMMHI<TMInput, TMOutput, TMNode> MNAADHLABHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KALKEILIPDO<TMInput, TMOutput, TMNode> EJHIILPIOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool KMNCFEHMJAG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly MCAPNBAEEIC<TMNode> POOCAABBIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3E35860", Offset = "0x3E34260", VA = "0x183E35860", Slot = "4")]
		get
		{
			return default(MCAPNBAEEIC<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3E35700", Offset = "0x3E34100", VA = "0x183E35700", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3E35790", Offset = "0x3E34190", VA = "0x183E35790")]
	internal NBIHIIGMJMA([In] CADOAGFMMHI<TMInput, TMOutput, TMNode> LHMIEHOPGMO, [In] KALKEILIPDO<TMInput, TMOutput, TMNode> ABNKFAFHOCF, bool GIKCJMDLKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E355C0", Offset = "0x3E33FC0", VA = "0x183E355C0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3E35680", Offset = "0x3E34080", VA = "0x183E35680", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3E35540", Offset = "0x3E33F40", VA = "0x183E35540", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BGCNBBNNHDF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x23BC290", Offset = "0x23BAC90", VA = "0x1823BC290")]
	public static NBIHIIGMJMA<TMInput, TMOutput, TMNode> KBFODEGLBLG<TMInput, TMOutput, TMNode>([In] IGJDFAMIODI<TMInput, TMOutput, TMNode> GEJAOFJBOBM, MCAPNBAEEIC<TMNode> HBBHIHHDOHG)
	{
		return default(NBIHIIGMJMA<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct KALKEILIPDO<TMInput, TMOutput, TMNode> : IEnumerator<MCAPNBAEEIC<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>.DJGENCPPMEO KODOLGBJINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>.DJGENCPPMEO NHKFMLHNDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly HHELJKHAMFM<TMInput, TMOutput, TMNode> BFDABPDKEEK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MCAPNBAEEIC<TMInput> POOCAABBIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3A97100", Offset = "0x3A95B00", VA = "0x183A97100", Slot = "4")]
		get
		{
			return default(MCAPNBAEEIC<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3A96FD0", Offset = "0x3A959D0", VA = "0x183A96FD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3A97080", Offset = "0x3A95A80", VA = "0x183A97080")]
	internal KALKEILIPDO([In] EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>.DJGENCPPMEO FHBIJHHGFCH, [In] EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>.DJGENCPPMEO OMLJOBLOJJA, [In] HHELJKHAMFM<TMInput, TMOutput, TMNode> IKGIMODMNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A96E00", Offset = "0x3A95800", VA = "0x183A96E00", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3A96F60", Offset = "0x3A95960", VA = "0x183A96F60", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A96D90", Offset = "0x3A95790", VA = "0x183A96D90", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HJGBKBCJJFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x26171F0", Offset = "0x2615BF0", VA = "0x1826171F0")]
	public static KALKEILIPDO<TMInput, TMOutput, TMNode> KBFODEGLBLG<TMInput, TMOutput, TMNode>([In] IGJDFAMIODI<TMInput, TMOutput, TMNode> GEJAOFJBOBM, MCAPNBAEEIC<TMNode> HBBHIHHDOHG)
	{
		return default(KALKEILIPDO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct CADOAGFMMHI<TMInput, TMOutput, TMNode> : IEnumerator<MCAPNBAEEIC<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>.DJGENCPPMEO LLENPMMEOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>.DJGENCPPMEO DIEGHBHANHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly JDCAPHJAGOD<TMInput, TMOutput, TMNode> IPFDCMKOOOD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MCAPNBAEEIC<TMOutput> POOCAABBIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3A97100", Offset = "0x3A95B00", VA = "0x183A97100", Slot = "4")]
		get
		{
			return default(MCAPNBAEEIC<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3A96FD0", Offset = "0x3A959D0", VA = "0x183A96FD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A97080", Offset = "0x3A95A80", VA = "0x183A97080")]
	internal CADOAGFMMHI([In] EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>.DJGENCPPMEO PILAGEJGBAF, [In] EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>.DJGENCPPMEO BFHGFDHCLGM, [In] JDCAPHJAGOD<TMInput, TMOutput, TMNode> LGFLJBEEBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A96E00", Offset = "0x3A95800", VA = "0x183A96E00", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A96F60", Offset = "0x3A95960", VA = "0x183A96F60", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A96D90", Offset = "0x3A95790", VA = "0x183A96D90", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JLKOHDENLGI
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x267B720", Offset = "0x267A120", VA = "0x18267B720")]
	public static CADOAGFMMHI<TMInput, TMOutput, TMNode> KBFODEGLBLG<TMInput, TMOutput, TMNode>([In] IGJDFAMIODI<TMInput, TMOutput, TMNode> GEJAOFJBOBM, MCAPNBAEEIC<TMNode> HBBHIHHDOHG)
	{
		return default(CADOAGFMMHI<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IGJDFAMIODI<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public JDCAPHJAGOD<TMInput, TMOutput, TMNode> KPMJMGDLNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public HHELJKHAMFM<TMInput, TMOutput, TMNode> DOEIDKFLHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public ECAFEKDGPNB<TMInput, TMOutput, TMNode> BBECKGNKNFK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x382EA00", Offset = "0x382D400", VA = "0x18382EA00")]
	internal IGJDFAMIODI([In] JDCAPHJAGOD<TMInput, TMOutput, TMNode> LGFLJBEEBBB, [In] HHELJKHAMFM<TMInput, TMOutput, TMNode> IKGIMODMNHD, [In] ECAFEKDGPNB<TMInput, TMOutput, TMNode> DIIKPNHFJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x382E750", Offset = "0x382D150", VA = "0x18382E750")]
	public static IGJDFAMIODI<TMInput?, TMOutput?, TMNode?> KBFODEGLBLG()
	{
		return default(IGJDFAMIODI<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JFBPHAIFPGL
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x265A950", Offset = "0x2659350", VA = "0x18265A950")]
	public static FLIDAHLNOLH? JLKDILEIJOC<TMInput, TMOutput, TMNode>([In] this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x265A280", Offset = "0x2658C80", VA = "0x18265A280")]
	public static IGJDFAMIODI<TMInput?, TMOutput?, TMNode?> DCJJDHFPDEL<TMInput, TMOutput, TMNode>(this FLIDAHLNOLH JFFAAHPEFOB)
	{
		return default(IGJDFAMIODI<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x265ABE0", Offset = "0x26595E0", VA = "0x18265ABE0")]
	public static void MMELNECKPAK<TMInput, TMOutput, TMNode>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x265AAB0", Offset = "0x26594B0", VA = "0x18265AAB0")]
	public static void LODHJDNEAMP<TMInput, TMOutput, TMNode>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> GHKAKPMMCLC, MCAPNBAEEIC<TMInput> MEAFDGBFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x265A050", Offset = "0x2658A50", VA = "0x18265A050")]
	public static void ALFKNKIJFMF<TMInput, TMOutput, TMNode>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> GHKAKPMMCLC, MCAPNBAEEIC<TMInput> MEAFDGBFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x265AB10", Offset = "0x2659510", VA = "0x18265AB10")]
	public static bool MKLFOBIAGJA<TMInput, TMOutput, TMNode>([In] this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> GHKAKPMMCLC, MCAPNBAEEIC<TMInput> MEAFDGBFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x265ADD0", Offset = "0x26597D0", VA = "0x18265ADD0")]
	public static MCAPNBAEEIC<TMNode?> NFPCNDLPNHD<TMNode, TMInput, TMOutput>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
		return default(MCAPNBAEEIC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x265AE60", Offset = "0x2659860", VA = "0x18265AE60")]
	public static void NGDIMIONEKK<TMInput, TMOutput, TMNode>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> HBBHIHHDOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x265A800", Offset = "0x2659200", VA = "0x18265A800")]
	public static MCAPNBAEEIC<TMInput?> FDOJBDLLJKA<TMInput, TMOutput, TMNode>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> HBBHIHHDOHG)
	{
		return default(MCAPNBAEEIC<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x265B090", Offset = "0x2659A90", VA = "0x18265B090")]
	public static MCAPNBAEEIC<TMOutput?> PPPOJBNFDOL<TMOutput, TMInput, TMNode>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> HBBHIHHDOHG)
	{
		return default(MCAPNBAEEIC<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x265A0B0", Offset = "0x2658AB0", VA = "0x18265A0B0")]
	public static MCAPNBAEEIC<TMInput?> AOLMFHGLAEI<TMInput, TMOutput, TMNode>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> HBBHIHHDOHG, int BNALCEABILL)
	{
		return default(MCAPNBAEEIC<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x265AA30", Offset = "0x2659430", VA = "0x18265AA30")]
	public static MCAPNBAEEIC<TMOutput?> LGNKAJNHOGI<TMOutput, TMInput, TMNode>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> HBBHIHHDOHG, int BNALCEABILL)
	{
		return default(MCAPNBAEEIC<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x265A130", Offset = "0x2658B30", VA = "0x18265A130")]
	public static void BDBFNAJHPKP<TMInput, TMOutput, TMNode>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> HBBHIHHDOHG, int IOHOLINFLCC, int BCJNBCPAIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x265A1D0", Offset = "0x2658BD0", VA = "0x18265A1D0")]
	public static void CHANHOECMAF<TMInput, TMOutput, TMNode>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> HBBHIHHDOHG, int IOHOLINFLCC, int BCJNBCPAIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x265A660", Offset = "0x2659060", VA = "0x18265A660")]
	public static void DMIIEJPAOOO<TMInput, TMOutput, TMNode>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMInput> JHADLKLHEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x265A870", Offset = "0x2659270", VA = "0x18265A870")]
	public static void JHMBHFPMHLF<TMInput, TMOutput, TMNode>(this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> MHDEGKMDGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
	public static PPMKCPHBKHK<TMInput?> PGNIAMABJJP<TMInput, TMOutput, TMNode>([In] this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
		return default(PPMKCPHBKHK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x265A270", Offset = "0x2658C70", VA = "0x18265A270")]
	public static PPMKCPHBKHK<TMOutput?> CKLBGHDGAAC<TMOutput, TMInput, TMNode>([In] this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
		return default(PPMKCPHBKHK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x265AF70", Offset = "0x2659970", VA = "0x18265AF70")]
	public static PPMKCPHBKHK<TMNode?> NNEDBNMJLPB<TMNode, TMInput, TMOutput>([In] this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
		return default(PPMKCPHBKHK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x265A5F0", Offset = "0x2658FF0", VA = "0x18265A5F0")]
	public static KALKEILIPDO<TMInput?, TMOutput?, TMNode?> OBACELEMLEA<TMInput, TMOutput, TMNode>([In] this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
		return default(KALKEILIPDO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x265A5F0", Offset = "0x2658FF0", VA = "0x18265A5F0")]
	public static CADOAGFMMHI<TMInput?, TMOutput?, TMNode?> DJFCGPIDMKC<TMInput, TMOutput, TMNode>([In] this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
		return default(CADOAGFMMHI<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x265A750", Offset = "0x2659150", VA = "0x18265A750")]
	public static NBIHIIGMJMA<TMInput?, TMOutput?, TMNode?> DOOADEBJNOI<TMInput, TMOutput, TMNode>([In] this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
		return default(NBIHIIGMJMA<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x265AF80", Offset = "0x2659980", VA = "0x18265AF80")]
	public static PNBLMENNDBH<MCAPNBAEEIC<TMInput?>, KALKEILIPDO<TMInput?, TMOutput?, TMNode?>> PAFLKHLAKJO<TMInput, TMOutput, TMNode>([In] this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
		return default(PNBLMENNDBH<MCAPNBAEEIC<TMInput>, KALKEILIPDO<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x265AC40", Offset = "0x2659640", VA = "0x18265AC40")]
	public static PNBLMENNDBH<MCAPNBAEEIC<TMNode?>, NBIHIIGMJMA<TMInput?, TMOutput?, TMNode?>> MPCGNAFPCOK<TMNode, TMInput, TMOutput>([In] this IGJDFAMIODI<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
		return default(PNBLMENNDBH<MCAPNBAEEIC<TMNode>, NBIHIIGMJMA<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JDCAPHJAGOD<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal PPMKCPHBKHK<TMInput> KGOKGPHKOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal IAEDKNOAMLN<TMInput, MCAPNBAEEIC<TMNode>> KLBLIMIKLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal IAEDKNOAMLN<TMInput, EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>> BFDABPDKEEK;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3232080", Offset = "0x3230A80", VA = "0x183232080")]
	internal JDCAPHJAGOD([In] PPMKCPHBKHK<TMInput> CILJIOLHCAG, [In] IAEDKNOAMLN<TMInput, MCAPNBAEEIC<TMNode>> DIIKPNHFJPB, [In] IAEDKNOAMLN<TMInput, EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>> IKGIMODMNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3231EC0", Offset = "0x32308C0", VA = "0x183231EC0")]
	internal static JDCAPHJAGOD<TMInput, TMOutput, TMNode> KBFODEGLBLG()
	{
		return default(JDCAPHJAGOD<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JMEKLJNAILF
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x267BF60", Offset = "0x267A960", VA = "0x18267BF60")]
	internal static NLDJIIFMEFI JLKDILEIJOC<TMInput, TMOutput, TMNode>([In] this JDCAPHJAGOD<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x267BA50", Offset = "0x267A450", VA = "0x18267BA50")]
	internal static JDCAPHJAGOD<TMInput, TMOutput, TMNode> DCJJDHFPDEL<TMInput, TMOutput, TMNode>(this NLDJIIFMEFI JFFAAHPEFOB)
	{
		return default(JDCAPHJAGOD<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x267C2F0", Offset = "0x267ACF0", VA = "0x18267C2F0")]
	private static PIOFFLKAOEB LPCCPAMFBKG<TMOutput>([In] this EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x267B7D0", Offset = "0x267A1D0", VA = "0x18267B7D0")]
	private static EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>> BAGMHIENGHH<TMOutput>(this PIOFFLKAOEB JFFAAHPEFOB)
	{
		return default(EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2612100", Offset = "0x2610B00", VA = "0x182612100")]
	internal static void MMELNECKPAK<TMInput, TMOutput, TMNode>(this JDCAPHJAGOD<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2611750", Offset = "0x2610150", VA = "0x182611750")]
	internal static MCAPNBAEEIC<TMInput> DJHBNCJMBIC<TMInput, TMOutput, TMNode>(this JDCAPHJAGOD<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> NADDHKKGBAN)
	{
		return default(MCAPNBAEEIC<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2611C20", Offset = "0x2610620", VA = "0x182611C20")]
	internal static void KHFIPNFMONP<TMInput, TMOutput, TMNode>(this JDCAPHJAGOD<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMInput> KABOEEEDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x23AC7D0", Offset = "0x23AB1D0", VA = "0x1823AC7D0")]
	public static bool HJONBPBKLNN<TMInput, TMOutput, TMNode>([In] this JDCAPHJAGOD<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMInput> KABOEEEDCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2611830", Offset = "0x2610230", VA = "0x182611830")]
	public static MCAPNBAEEIC<TMNode> GBMIBFCHJGL<TMNode, TMInput, TMOutput>([In] this JDCAPHJAGOD<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMInput> KABOEEEDCAB)
	{
		return default(MCAPNBAEEIC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2611850", Offset = "0x2610250", VA = "0x182611850")]
	public static int JFBMBKMFFKM<TMInput, TMOutput, TMNode>([In] this JDCAPHJAGOD<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMInput> KABOEEEDCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2611700", Offset = "0x2610100", VA = "0x182611700")]
	public static MCAPNBAEEIC<TMOutput> DPKKHNHMLJO<TMOutput, TMInput, TMNode>([In] this JDCAPHJAGOD<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMInput> KABOEEEDCAB, int BNALCEABILL)
	{
		return default(MCAPNBAEEIC<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x26117F0", Offset = "0x26101F0", VA = "0x1826117F0")]
	internal static void GMBPIOBNACO<TMInput, TMOutput, TMNode>(this JDCAPHJAGOD<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMInput> KABOEEEDCAB, MCAPNBAEEIC<TMOutput> MHDEGKMDGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x26117F0", Offset = "0x26101F0", VA = "0x1826117F0")]
	internal static void OLKGEJLMGLJ<TMInput, TMOutput, TMNode>(this JDCAPHJAGOD<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMInput> KABOEEEDCAB, MCAPNBAEEIC<TMOutput> MHDEGKMDGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2611190", Offset = "0x260FB90", VA = "0x182611190")]
	public static EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>.DJGENCPPMEO OADHBGMDIOC<TMOutput, TMInput, TMNode>([In] this JDCAPHJAGOD<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMInput> KABOEEEDCAB)
	{
		return default(EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>.DJGENCPPMEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2611190", Offset = "0x260FB90", VA = "0x182611190")]
	public static NJAACNDOILB<MCAPNBAEEIC<TMOutput>, EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>.DJGENCPPMEO> BEAOEINOMHL<TMOutput, TMInput, TMNode>([In] this JDCAPHJAGOD<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMInput> KABOEEEDCAB)
	{
		return default(NJAACNDOILB<MCAPNBAEEIC<TMOutput>, EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>.DJGENCPPMEO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct ECAFEKDGPNB<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal PPMKCPHBKHK<TMNode> KGOKGPHKOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal IAEDKNOAMLN<TMNode, EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>> IPFDCMKOOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal IAEDKNOAMLN<TMNode, EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>> BFDABPDKEEK;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3232080", Offset = "0x3230A80", VA = "0x183232080")]
	internal ECAFEKDGPNB([In] PPMKCPHBKHK<TMNode> CILJIOLHCAG, [In] IAEDKNOAMLN<TMNode, EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>> LGFLJBEEBBB, [In] IAEDKNOAMLN<TMNode, EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>> IKGIMODMNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3231EC0", Offset = "0x32308C0", VA = "0x183231EC0")]
	internal static ECAFEKDGPNB<TMInput, TMOutput, TMNode> KBFODEGLBLG()
	{
		return default(ECAFEKDGPNB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LACEOKONGCM
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x26BC8B0", Offset = "0x26BB2B0", VA = "0x1826BC8B0")]
	internal static FLMEAKNKDHL JLKDILEIJOC<TMInput, TMOutput, TMNode>([In] this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x26BBB80", Offset = "0x26BA580", VA = "0x1826BBB80")]
	internal static ECAFEKDGPNB<TMInput, TMOutput, TMNode> DCJJDHFPDEL<TMInput, TMOutput, TMNode>(this FLMEAKNKDHL JFFAAHPEFOB)
	{
		return default(ECAFEKDGPNB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x26BC460", Offset = "0x26BAE60", VA = "0x1826BC460")]
	private static GHMJJFBFOKB IBOHMLAJPEK<TMInput>([In] this EFFJEOGHPGG<MCAPNBAEEIC<TMInput>> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x26BCFF0", Offset = "0x26BB9F0", VA = "0x1826BCFF0")]
	private static EFFJEOGHPGG<MCAPNBAEEIC<TMInput>> NPOMJDJBEMA<TMInput>(this GHMJJFBFOKB JFFAAHPEFOB)
	{
		return default(EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x26BC290", Offset = "0x26BAC90", VA = "0x1826BC290")]
	private static JMAMAIMGCGC HIOMAKHALNC<TMOutput>([In] this EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26BC630", Offset = "0x26BB030", VA = "0x1826BC630")]
	private static EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>> IENAGLPANDG<TMOutput>(this JMAMAIMGCGC JFFAAHPEFOB)
	{
		return default(EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26BCD30", Offset = "0x26BB730", VA = "0x1826BCD30")]
	internal static void MMELNECKPAK<TMInput, TMOutput, TMNode>(this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x26BC0E0", Offset = "0x26BAAE0", VA = "0x1826BC0E0")]
	internal static MCAPNBAEEIC<TMNode> DJHBNCJMBIC<TMNode, TMInput, TMOutput>(this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, [In] EFFJEOGHPGG<MCAPNBAEEIC<TMInput>> LGFLJBEEBBB, [In] EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>> IKGIMODMNHD)
	{
		return default(MCAPNBAEEIC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x26BCC70", Offset = "0x26BB670", VA = "0x1826BCC70")]
	internal static void KHFIPNFMONP<TMInput, TMOutput, TMNode>(this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x23AC7D0", Offset = "0x23AB1D0", VA = "0x1823AC7D0")]
	public static bool HJONBPBKLNN<TMInput, TMOutput, TMNode>([In] this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x23AC940", Offset = "0x23AB340", VA = "0x1823AC940")]
	public static int KGEAHABPDOH<TMInput, TMOutput, TMNode>([In] this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x26BC250", Offset = "0x26BAC50", VA = "0x1826BC250")]
	public static int HAEALBLGGDL<TMInput, TMOutput, TMNode>([In] this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2611850", Offset = "0x2610250", VA = "0x182611850")]
	public static int JFBMBKMFFKM<TMInput, TMOutput, TMNode>([In] this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x26BC090", Offset = "0x26BAA90", VA = "0x1826BC090")]
	public static MCAPNBAEEIC<TMInput> DDFJCHMAIPH<TMInput, TMOutput, TMNode>([In] this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB, int BNALCEABILL)
	{
		return default(MCAPNBAEEIC<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2611700", Offset = "0x2610100", VA = "0x182611700")]
	public static MCAPNBAEEIC<TMOutput> DPKKHNHMLJO<TMOutput, TMInput, TMNode>([In] this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB, int BNALCEABILL)
	{
		return default(MCAPNBAEEIC<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x26BC210", Offset = "0x26BAC10", VA = "0x1826BC210")]
	internal static void GHMJDBKJBOG<TMInput, TMOutput, TMNode>(this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB, MCAPNBAEEIC<TMInput> JHADLKLHEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x26117F0", Offset = "0x26101F0", VA = "0x1826117F0")]
	internal static void GMBPIOBNACO<TMInput, TMOutput, TMNode>(this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB, MCAPNBAEEIC<TMOutput> MHDEGKMDGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x26BC1C0", Offset = "0x26BABC0", VA = "0x1826BC1C0")]
	internal static void EKJEPANCLLE<TMInput, TMOutput, TMNode>(this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB, int BNALCEABILL, MCAPNBAEEIC<TMInput> JHADLKLHEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x26BC170", Offset = "0x26BAB70", VA = "0x1826BC170")]
	internal static void EJPPFKOOGGF<TMInput, TMOutput, TMNode>(this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB, int BNALCEABILL, MCAPNBAEEIC<TMOutput> MHDEGKMDGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x26BC210", Offset = "0x26BAC10", VA = "0x1826BC210")]
	internal static void FHFDAPJDKMN<TMInput, TMOutput, TMNode>(this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB, MCAPNBAEEIC<TMInput> JHADLKLHEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x26117F0", Offset = "0x26101F0", VA = "0x1826117F0")]
	internal static void OLKGEJLMGLJ<TMInput, TMOutput, TMNode>(this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB, MCAPNBAEEIC<TMOutput> MHDEGKMDGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x26BBB20", Offset = "0x26BA520", VA = "0x1826BBB20")]
	public static EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>.DJGENCPPMEO ODLCAPEEHKD<TMInput, TMOutput, TMNode>([In] this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
		return default(EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>.DJGENCPPMEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2611190", Offset = "0x260FB90", VA = "0x182611190")]
	public static EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>.DJGENCPPMEO OADHBGMDIOC<TMOutput, TMInput, TMNode>([In] this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
		return default(EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>.DJGENCPPMEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x26BBB20", Offset = "0x26BA520", VA = "0x1826BBB20")]
	public static NJAACNDOILB<MCAPNBAEEIC<TMInput>, EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>.DJGENCPPMEO> BJDJDEJMPMH<TMInput, TMOutput, TMNode>([In] this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
		return default(NJAACNDOILB<MCAPNBAEEIC<TMInput>, EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>.DJGENCPPMEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2611190", Offset = "0x260FB90", VA = "0x182611190")]
	public static NJAACNDOILB<MCAPNBAEEIC<TMOutput>, EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>.DJGENCPPMEO> BEAOEINOMHL<TMOutput, TMInput, TMNode>([In] this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> KABOEEEDCAB)
	{
		return default(NJAACNDOILB<MCAPNBAEEIC<TMOutput>, EFFJEOGHPGG<MCAPNBAEEIC<TMOutput>>.DJGENCPPMEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x264E780", Offset = "0x264D180", VA = "0x18264E780")]
	public static PNBLMENNDBH<MCAPNBAEEIC<TMNode>, PPMKCPHBKHK<TMNode>.GGGHPPAOBNC> KPDAPACPOJO<TMNode, TMInput, TMOutput>([In] this ECAFEKDGPNB<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
		return default(PNBLMENNDBH<MCAPNBAEEIC<TMNode>, PPMKCPHBKHK<TMNode>.GGGHPPAOBNC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HHELJKHAMFM<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal PPMKCPHBKHK<TMOutput> KGOKGPHKOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal IAEDKNOAMLN<TMOutput, MCAPNBAEEIC<TMNode>> KLBLIMIKLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal IAEDKNOAMLN<TMOutput, EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>> IPFDCMKOOOD;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3232080", Offset = "0x3230A80", VA = "0x183232080")]
	internal HHELJKHAMFM([In] PPMKCPHBKHK<TMOutput> CILJIOLHCAG, [In] IAEDKNOAMLN<TMOutput, MCAPNBAEEIC<TMNode>> DIIKPNHFJPB, [In] IAEDKNOAMLN<TMOutput, EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>> LGFLJBEEBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3231EC0", Offset = "0x32308C0", VA = "0x183231EC0")]
	internal static HHELJKHAMFM<TMInput, TMOutput, TMNode> KBFODEGLBLG()
	{
		return default(HHELJKHAMFM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GPHNHPGEALB
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2611890", Offset = "0x2610290", VA = "0x182611890")]
	internal static IMHFLLMMGJF JLKDILEIJOC<TMInput, TMOutput, TMNode>([In] this HHELJKHAMFM<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x26111F0", Offset = "0x260FBF0", VA = "0x1826111F0")]
	internal static HHELJKHAMFM<TMInput, TMOutput, TMNode> DCJJDHFPDEL<TMInput, TMOutput, TMNode>(this IMHFLLMMGJF JFFAAHPEFOB)
	{
		return default(HHELJKHAMFM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2611CB0", Offset = "0x26106B0", VA = "0x182611CB0")]
	private static MOLMGEMOAJJ LPPLIMDGKMJ<TMInput>([In] this EFFJEOGHPGG<MCAPNBAEEIC<TMInput>> JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2611E80", Offset = "0x2610880", VA = "0x182611E80")]
	private static EFFJEOGHPGG<MCAPNBAEEIC<TMInput>> MKLOJLMCMDH<TMInput>(this MOLMGEMOAJJ JFFAAHPEFOB)
	{
		return default(EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2612100", Offset = "0x2610B00", VA = "0x182612100")]
	internal static void MMELNECKPAK<TMInput, TMOutput, TMNode>(this HHELJKHAMFM<TMInput, TMOutput, TMNode> JFFAAHPEFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2611750", Offset = "0x2610150", VA = "0x182611750")]
	internal static MCAPNBAEEIC<TMOutput> DJHBNCJMBIC<TMOutput, TMInput, TMNode>(this HHELJKHAMFM<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMNode> NADDHKKGBAN)
	{
		return default(MCAPNBAEEIC<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2611C20", Offset = "0x2610620", VA = "0x182611C20")]
	internal static void KHFIPNFMONP<TMInput, TMOutput, TMNode>(this HHELJKHAMFM<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> KABOEEEDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x23AC7D0", Offset = "0x23AB1D0", VA = "0x1823AC7D0")]
	public static bool HJONBPBKLNN<TMInput, TMOutput, TMNode>([In] this HHELJKHAMFM<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> KABOEEEDCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2611830", Offset = "0x2610230", VA = "0x182611830")]
	public static MCAPNBAEEIC<TMNode> GBMIBFCHJGL<TMNode, TMInput, TMOutput>([In] this HHELJKHAMFM<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> KABOEEEDCAB)
	{
		return default(MCAPNBAEEIC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2611850", Offset = "0x2610250", VA = "0x182611850")]
	public static int HAEALBLGGDL<TMInput, TMOutput, TMNode>([In] this HHELJKHAMFM<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> KABOEEEDCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2611700", Offset = "0x2610100", VA = "0x182611700")]
	public static MCAPNBAEEIC<TMInput> DDFJCHMAIPH<TMInput, TMOutput, TMNode>([In] this HHELJKHAMFM<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> KABOEEEDCAB, int BNALCEABILL)
	{
		return default(MCAPNBAEEIC<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x26117F0", Offset = "0x26101F0", VA = "0x1826117F0")]
	internal static void GHMJDBKJBOG<TMInput, TMOutput, TMNode>(this HHELJKHAMFM<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> KABOEEEDCAB, MCAPNBAEEIC<TMInput> JHADLKLHEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x26117F0", Offset = "0x26101F0", VA = "0x1826117F0")]
	internal static void FHFDAPJDKMN<TMInput, TMOutput, TMNode>(this HHELJKHAMFM<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> KABOEEEDCAB, MCAPNBAEEIC<TMInput> JHADLKLHEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2611190", Offset = "0x260FB90", VA = "0x182611190")]
	public static EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>.DJGENCPPMEO ODLCAPEEHKD<TMInput, TMOutput, TMNode>([In] this HHELJKHAMFM<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> KABOEEEDCAB)
	{
		return default(EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>.DJGENCPPMEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2611190", Offset = "0x260FB90", VA = "0x182611190")]
	public static NJAACNDOILB<MCAPNBAEEIC<TMInput>, EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>.DJGENCPPMEO> BJDJDEJMPMH<TMInput, TMOutput, TMNode>([In] this HHELJKHAMFM<TMInput, TMOutput, TMNode> JFFAAHPEFOB, MCAPNBAEEIC<TMOutput> KABOEEEDCAB)
	{
		return default(NJAACNDOILB<MCAPNBAEEIC<TMInput>, EFFJEOGHPGG<MCAPNBAEEIC<TMInput>>.DJGENCPPMEO>);
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

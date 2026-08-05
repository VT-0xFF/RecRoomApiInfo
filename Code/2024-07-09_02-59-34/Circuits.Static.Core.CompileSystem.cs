using System;
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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7BF0", Offset = "0x1FE67F0", VA = "0x181FE7BF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct EBEJCBAHMFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> GEMBEJKLFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int IKFOCKOFOBP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
	public EBEJCBAHMFC(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JHLMDBFGCJO, int JEHLDDEOFLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LBPEBBCLLJL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class CIANCMNHDDG : ACEJKGEBNMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct FBEKPMAGJJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly BGNDAENKAGM<byte> OGDFFAONEHE;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A740", Offset = "0x1F99340", VA = "0x181F9A740")]
		public FBEKPMAGJJI(BGNDAENKAGM<byte> GABEBEKDBIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0100", Offset = "0x1FDED00", VA = "0x181FE0100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class GJCJDKEEHLP : ACEJKGEBNMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct EGMJLBGKACC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> JIGODDAOKDD;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
		public EGMJLBGKACC(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> IEJCAIAJHJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum IECPHGEAMKD
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		BytesImmediate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		X32Immediate
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class IKJINJNOAAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class ACEJKGEBNMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct KFIKGKDPPGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly IECPHGEAMKD PBMGCIOLAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly JCIKKDEFAFO<ACEJKGEBNMN> HLELINFJNBO;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
		public KFIKGKDPPGH(IECPHGEAMKD KEIKGFCGOKN, JCIKKDEFAFO<ACEJKGEBNMN> KFDABGLPFON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class IMLKFEONCPJ : ACEJKGEBNMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MAPAKNLGJCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> GMLAMJGACLH;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
		public MAPAKNLGJCB(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> BHBIGHBHJIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class FNDLJALEGLF : ACEJKGEBNMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct FNHFJJGLICC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly OBHAAEALFBF CFGONMLKACH;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
		public FNHFJJGLICC(OBHAAEALFBF DHHMNELNKME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0180", Offset = "0x1FDED80", VA = "0x181FE0180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal JALBMGGBFMG<IKJINJNOAAI, KFIKGKDPPGH> POJNHGJKAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal JALBMGGBFMG<CIANCMNHDDG, FBEKPMAGJJI> IDGDHIPHJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal JALBMGGBFMG<GJCJDKEEHLP, EGMJLBGKACC> LKKMDPGBNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal JALBMGGBFMG<IMLKFEONCPJ, MAPAKNLGJCB> PPGALNFBADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal JALBMGGBFMG<FNDLJALEGLF, FNHFJJGLICC> CPCBONOHAAF;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6D90", Offset = "0x1FE5990", VA = "0x181FE6D90")]
	private LBPEBBCLLJL([In] JALBMGGBFMG<IKJINJNOAAI, KFIKGKDPPGH> OOOAMIHIBEH, [In] JALBMGGBFMG<CIANCMNHDDG, FBEKPMAGJJI> AHOJNBJOJLJ, [In] JALBMGGBFMG<GJCJDKEEHLP, EGMJLBGKACC> KPHDCLOGMOP, [In] JALBMGGBFMG<IMLKFEONCPJ, MAPAKNLGJCB> BBFFHEFMHHB, [In] JALBMGGBFMG<FNDLJALEGLF, FNHFJJGLICC> CHEOGPDECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6C50", Offset = "0x1FE5850", VA = "0x181FE6C50")]
	public static LBPEBBCLLJL FCDPFGJNKNI()
	{
		return default(LBPEBBCLLJL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ILPDGDGEKOL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE68E0", Offset = "0x1FE54E0", VA = "0x181FE68E0")]
	public static void KHBCMNOGPLL(this LBPEBBCLLJL ENEDBNLKLJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum CAABOFKJNDE
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NIPJFALODIE
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class ADJJCJLNJIK : MGLOAPNHJLN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct ENKBAEBOLCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> ALPOGFNAKAH;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
		public ENKBAEBOLCH(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> FKJIJLGNBHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum IBMGBNHNPMD
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Branch,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		DeadEndData,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		OutNode
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class DPCGKKALOBI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class MGLOAPNHJLN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct COPLENMMPLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly IBMGBNHNPMD PBMGCIOLAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly JCIKKDEFAFO<MGLOAPNHJLN> HLELINFJNBO;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
		public COPLENMMPLA(IBMGBNHNPMD KEIKGFCGOKN, JCIKKDEFAFO<MGLOAPNHJLN> KFDABGLPFON)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal JALBMGGBFMG<DPCGKKALOBI, COPLENMMPLA> POJNHGJKAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal JALBMGGBFMG<ADJJCJLNJIK, ENKBAEBOLCH> CCMHBDHCEJF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6A10", Offset = "0x1FE5610", VA = "0x181FE6A10")]
	private NIPJFALODIE([In] JALBMGGBFMG<DPCGKKALOBI, COPLENMMPLA> OOOAMIHIBEH, [In] JALBMGGBFMG<ADJJCJLNJIK, ENKBAEBOLCH> GBIJGDJJILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7AB0", Offset = "0x1FE66B0", VA = "0x181FE7AB0")]
	public static NIPJFALODIE FCDPFGJNKNI()
	{
		return default(NIPJFALODIE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class DJLLOHABPEM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0060", Offset = "0x1FDEC60", VA = "0x181FE0060")]
	public static void KHBCMNOGPLL(this NIPJFALODIE ENEDBNLKLJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PAACBJHDHEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public JFDANJHACCB<int> OPGNAAMEAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public JFDANJHACCB<int> HILBEJIAODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int BKFLDJOHPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int MAMFCBCFENF;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7DE0", Offset = "0x1FE69E0", VA = "0x181FE7DE0")]
	private PAACBJHDHEK([In] JFDANJHACCB<int> ALJMAJIJKFE, [In] JFDANJHACCB<int> PELOEHJAHBN, int OLKBLIIGMNH, int OEMKEJEPNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7D40", Offset = "0x1FE6940", VA = "0x181FE7D40")]
	public static PAACBJHDHEK FCDPFGJNKNI()
	{
		return default(PAACBJHDHEK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KADDBLHJMFO
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6BF0", Offset = "0x1FE57F0", VA = "0x181FE6BF0")]
	public static void KHBCMNOGPLL(this PAACBJHDHEK ENEDBNLKLJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GNMAIGIKODN
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum OPBBIFPLDFE
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class IIGCEOJFBFM : LFDDJCCPHGO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct NNEPOCNCMIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly JCIKKDEFAFO<BBBBLNOKCHG> MKEAPNEBEHN;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
		public NNEPOCNCMIN(JCIKKDEFAFO<BBBBLNOKCHG> BNOMKIFCIDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class KGLHOJJIDHA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class LFDDJCCPHGO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct FHBCFDNHBHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly OPBBIFPLDFE PBMGCIOLAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly JCIKKDEFAFO<LFDDJCCPHGO> HLELINFJNBO;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
		private FHBCFDNHBHA(OPBBIFPLDFE KEIKGFCGOKN, JCIKKDEFAFO<LFDDJCCPHGO> KFDABGLPFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0170", Offset = "0x1FDED70", VA = "0x181FE0170")]
		public static FHBCFDNHBHA FCDPFGJNKNI(OPBBIFPLDFE KEIKGFCGOKN, JCIKKDEFAFO<LFDDJCCPHGO> KFDABGLPFON)
		{
			return default(FHBCFDNHBHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class IFMIABAJMPK : LFDDJCCPHGO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct MCAHEBLBFPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly JCIKKDEFAFO<BBBBLNOKCHG> MKEAPNEBEHN;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
		public MCAHEBLBFPO(JCIKKDEFAFO<BBBBLNOKCHG> BNOMKIFCIDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class BBBBLNOKCHG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct IMDBMKLHOMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public JFDANJHACCB<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> HNBCLGKHNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public JFDANJHACCB<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> BGACFLOPHNF;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6A10", Offset = "0x1FE5610", VA = "0x181FE6A10")]
		private IMDBMKLHOMJ([In] JFDANJHACCB<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> BIIHFCIFFAD, [In] JFDANJHACCB<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> CLHJHKCPGMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6990", Offset = "0x1FE5590", VA = "0x181FE6990")]
		public static IMDBMKLHOMJ FCDPFGJNKNI()
		{
			return default(IMDBMKLHOMJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal JALBMGGBFMG<KGLHOJJIDHA, FHBCFDNHBHA> POJNHGJKAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal JALBMGGBFMG<IFMIABAJMPK, MCAHEBLBFPO> MKNJLHFEOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal JALBMGGBFMG<IIGCEOJFBFM, NNEPOCNCMIN> NCIHALJJOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal JFDANJHACCB<(JCIKKDEFAFO<KGLHOJJIDHA> CallId, JCIKKDEFAFO<BBBBLNOKCHG> IOId)> OJOEGHKNHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal JALBMGGBFMG<BBBBLNOKCHG, IMDBMKLHOMJ> NHDLNAGAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal KCNOHKPEBHA<BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>> ANICFNKLGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal KCNOHKPEBHA<BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>> OKHBGNBLMIB;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FE55D0", Offset = "0x1FE41D0", VA = "0x181FE55D0")]
	private GNMAIGIKODN([In] JALBMGGBFMG<KGLHOJJIDHA, FHBCFDNHBHA> OOOAMIHIBEH, [In] JALBMGGBFMG<IFMIABAJMPK, MCAHEBLBFPO> IDMIPEHHDLB, [In] JALBMGGBFMG<IIGCEOJFBFM, NNEPOCNCMIN> KDDALHKFDLN, [In] JFDANJHACCB<(JCIKKDEFAFO<KGLHOJJIDHA> CallId, JCIKKDEFAFO<BBBBLNOKCHG> IOId)> MMKMFGEJCGG, [In] JALBMGGBFMG<BBBBLNOKCHG, IMDBMKLHOMJ> HIHCFOMBLCD, [In] KCNOHKPEBHA<BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>> NPLGMIIKBND, [In] KCNOHKPEBHA<BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>> PBJFEFPMMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5430", Offset = "0x1FE4030", VA = "0x181FE5430")]
	public static GNMAIGIKODN FCDPFGJNKNI()
	{
		return default(GNMAIGIKODN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class CPDDPKHELLB
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0010", Offset = "0x1FDEC10", VA = "0x181FE0010")]
	private static void KHBCMNOGPLL(this GNMAIGIKODN.IMDBMKLHOMJ ENEDBNLKLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFE00", Offset = "0x1FDEA00", VA = "0x181FDFE00")]
	public static void KHBCMNOGPLL(this GNMAIGIKODN ENEDBNLKLJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HIENOIMPHLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public JFDANJHACCB<byte> IMOBKHCMDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal GNMAIGIKODN JLDJGMFCCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal NIMNFJBMPAP OFNMJBAPCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> EEFEOGLPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal LBPEBBCLLJL ELEFFIFJPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal NIPJFALODIE ECEABLCLPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal KCNOHKPEBHA<EBPAJHFGHPO, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>?> FBDNMHIOJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal JFDANJHACCB<JCIKKDEFAFO<EBPAJHFGHPO>> BGLAGJNFACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?> GAGJNKLLFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> VariableId, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>> ByteCodeWriteLocation)> BPEBPKMIOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> DJNFKJIKCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal NGOIBHIHIJM OOGMAILCJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal BDKHDCEJNOM OHCHABHFOFE;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6200", Offset = "0x1FE4E00", VA = "0x181FE6200")]
	private HIENOIMPHLO([In] JFDANJHACCB<byte> ODBIEHMMCPH, [In] GNMAIGIKODN DBDFMMBHNCE, [In] NIMNFJBMPAP GBLDOLNGOMD, [In] LBPEBBCLLJL KILBCGHLHEG, [In] NIPJFALODIE BHFCEPKAAGF, [In] KCNOHKPEBHA<EBPAJHFGHPO, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>?> OKMAMMLALHN, [In] JFDANJHACCB<JCIKKDEFAFO<EBPAJHFGHPO>> BHNMHCGHNIJ, [In] KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?> ICNPCHKFAAA, [In] JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> VariableId, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>> ByteCodeWriteLocation)> FPHHKEPNAEH, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> OMLMAMPEANI, [In] NGOIBHIHIJM JPIICINMOPP, [In] BDKHDCEJNOM CGGKCFFILBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5740", Offset = "0x1FE4340", VA = "0x181FE5740")]
	public static HIENOIMPHLO FCDPFGJNKNI()
	{
		return default(HIENOIMPHLO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class AHDFBDFFIEC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct HNDBPEADBMG : PMKFFAMDIED<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>, KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6570", Offset = "0x1FE5170", VA = "0x181FE6570")]
		public JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6620", Offset = "0x1FE5220", VA = "0x181FE6620", Slot = "4")]
		public JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> KFBKIBAKELJ(int BAEBMIBABAE)
		{
			return default(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80")]
		public bool FGCLJEIKOLP(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>> COOBAOCKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "5")]
		private bool HNMPJGGKPGA(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>> COOBAOCKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6560", Offset = "0x1FE5160", VA = "0x181FE6560", Slot = "6")]
		private JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JLIDFOFJGPD(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct NEMGIKFOGIK : JDHCEPACLDN<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>, KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7300", Offset = "0x1FE5F00", VA = "0x181FE7300")]
		public JFDANJHACCB<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>> CEDBHODPJLB(int AANPNADINAI, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>> COOBAOCKFHD)
		{
			return default(JFDANJHACCB<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7380", Offset = "0x1FE5F80", VA = "0x181FE7380")]
		public JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7430", Offset = "0x1FE6030", VA = "0x181FE7430", Slot = "6")]
		public void LOIGEBBDMHM(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>> COOBAOCKFHD, JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7300", Offset = "0x1FE5F00", VA = "0x181FE7300", Slot = "4")]
		private JFDANJHACCB<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>> CLMBOKABIPA(int AANPNADINAI, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>> COOBAOCKFHD)
		{
			return default(JFDANJHACCB<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7370", Offset = "0x1FE5F70", VA = "0x181FE7370", Slot = "5")]
		private JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> IFPPBGFPEIO(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct JALDCDDDDHE : PMKFFAMDIED<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>, KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6A60", Offset = "0x1FE5660", VA = "0x181FE6A60")]
		public JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6B10", Offset = "0x1FE5710", VA = "0x181FE6B10", Slot = "4")]
		public JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> KFBKIBAKELJ(int BAEBMIBABAE)
		{
			return default(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80")]
		public bool FGCLJEIKOLP(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>> COOBAOCKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "5")]
		private bool LAIHCBBNCDE(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>> COOBAOCKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6A50", Offset = "0x1FE5650", VA = "0x181FE6A50", Slot = "6")]
		private JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> BOEIBGHMEFG(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct BIDLPBGOMIP : JDHCEPACLDN<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>, KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF660", Offset = "0x1FDE260", VA = "0x181FDF660")]
		public JFDANJHACCB<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>> CEDBHODPJLB(int AANPNADINAI, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>> COOBAOCKFHD)
		{
			return default(JFDANJHACCB<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF6D0", Offset = "0x1FDE2D0", VA = "0x181FDF6D0")]
		public JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF780", Offset = "0x1FDE380", VA = "0x181FDF780", Slot = "6")]
		public void LOIGEBBDMHM(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>> COOBAOCKFHD, JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF660", Offset = "0x1FDE260", VA = "0x181FDF660", Slot = "4")]
		private JFDANJHACCB<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>> PGKGDAFJNAL(int AANPNADINAI, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>> COOBAOCKFHD)
		{
			return default(JFDANJHACCB<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF840", Offset = "0x1FDE440", VA = "0x181FDF840", Slot = "5")]
		private JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> PPKHGCIDBAC(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BAEBMIBABAE, [In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct MNAEPJCDADG : PMKFFAMDIED<JCIKKDEFAFO<BNGCKMJMGMP>, KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7200", Offset = "0x1FE5E00", VA = "0x181FE7200")]
		public JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(JCIKKDEFAFO<BNGCKMJMGMP> BAEBMIBABAE, [In] KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1FE72D0", Offset = "0x1FE5ED0", VA = "0x181FE72D0", Slot = "4")]
		public JCIKKDEFAFO<BNGCKMJMGMP> KFBKIBAKELJ(int BAEBMIBABAE)
		{
			return default(JCIKKDEFAFO<BNGCKMJMGMP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7190", Offset = "0x1FE5D90", VA = "0x181FE7190")]
		public bool FGCLJEIKOLP(JCIKKDEFAFO<BNGCKMJMGMP> BAEBMIBABAE, [In] KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?> COOBAOCKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7190", Offset = "0x1FE5D90", VA = "0x181FE7190", Slot = "5")]
		private bool ENFOCCIANKA(JCIKKDEFAFO<BNGCKMJMGMP> BAEBMIBABAE, [In] KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?> COOBAOCKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7180", Offset = "0x1FE5D80", VA = "0x181FE7180", Slot = "6")]
		private JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> CJFFACNPGKK(JCIKKDEFAFO<BNGCKMJMGMP> BAEBMIBABAE, [In] KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct LHDONGAEHOD : JDHCEPACLDN<JCIKKDEFAFO<BNGCKMJMGMP>, KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6E20", Offset = "0x1FE5A20", VA = "0x181FE6E20")]
		public JFDANJHACCB<JCIKKDEFAFO<BNGCKMJMGMP>> CEDBHODPJLB(int AANPNADINAI, [In] KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?> COOBAOCKFHD)
		{
			return default(JFDANJHACCB<JCIKKDEFAFO<BNGCKMJMGMP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6EA0", Offset = "0x1FE5AA0", VA = "0x181FE6EA0")]
		public JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(JCIKKDEFAFO<BNGCKMJMGMP> BAEBMIBABAE, [In] KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6F70", Offset = "0x1FE5B70", VA = "0x181FE6F70", Slot = "6")]
		public void LOIGEBBDMHM(JCIKKDEFAFO<BNGCKMJMGMP> BAEBMIBABAE, KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?> COOBAOCKFHD, JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6E20", Offset = "0x1FE5A20", VA = "0x181FE6E20", Slot = "4")]
		private JFDANJHACCB<JCIKKDEFAFO<BNGCKMJMGMP>> GMJLFLCFOAO(int AANPNADINAI, [In] KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?> COOBAOCKFHD)
		{
			return default(JFDANJHACCB<JCIKKDEFAFO<BNGCKMJMGMP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6E90", Offset = "0x1FE5A90", VA = "0x181FE6E90", Slot = "5")]
		private JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> HKBIOONDLJD(JCIKKDEFAFO<BNGCKMJMGMP> BAEBMIBABAE, [In] KCNOHKPEBHA<BNGCKMJMGMP, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>?> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct NOKFEJKHCAO : PMKFFAMDIED<int, JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7B40", Offset = "0x1FE6740", VA = "0x181FE7B40")]
		public JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> VariableId, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x13A98A0", Offset = "0x13A84A0", VA = "0x1813A98A0", Slot = "4")]
		public int KFBKIBAKELJ(int BAEBMIBABAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80")]
		public bool FGCLJEIKOLP(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> VariableId, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "5")]
		private bool ELLICKMLKMK(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> VariableId, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7BE0", Offset = "0x1FE67E0", VA = "0x181FE7BE0", Slot = "6")]
		private JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> KEMCEHBMKGJ(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> VariableId, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct BNMKEDPBBMO : JDHCEPACLDN<int, JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFA70", Offset = "0x1FDE670", VA = "0x181FDFA70")]
		public JFDANJHACCB<int> CEDBHODPJLB(int AANPNADINAI, [In] JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> VariableId, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JFDANJHACCB<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFAF0", Offset = "0x1FDE6F0", VA = "0x181FDFAF0")]
		public JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> VariableId, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFB90", Offset = "0x1FDE790", VA = "0x181FDFB90", Slot = "6")]
		public void LOIGEBBDMHM(int BAEBMIBABAE, JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> VariableId, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>> ByteCodeWriteLocation)> COOBAOCKFHD, JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFA70", Offset = "0x1FDE670", VA = "0x181FDFA70", Slot = "4")]
		private JFDANJHACCB<int> IMGOPECFLLP(int AANPNADINAI, [In] JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> VariableId, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JFDANJHACCB<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFAE0", Offset = "0x1FDE6E0", VA = "0x181FDFAE0", Slot = "5")]
		private JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> INPMBFFFFAE(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> VariableId, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<OPFCLJJOIHA>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct OJEGKDEPODL : PMKFFAMDIED<int, JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7C80", Offset = "0x1FE6880", VA = "0x181FE7C80")]
		public JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x13A98A0", Offset = "0x13A84A0", VA = "0x1813A98A0", Slot = "4")]
		public int KFBKIBAKELJ(int BAEBMIBABAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80")]
		public bool FGCLJEIKOLP(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "5")]
		private bool HIIOJADFKKI(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7C70", Offset = "0x1FE6870", VA = "0x181FE7C70", Slot = "6")]
		private JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> DMJBOENHCPE(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct ABMINAHHHKH : JDHCEPACLDN<int, JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCCC0", Offset = "0x1FDB8C0", VA = "0x181FDCCC0")]
		public JFDANJHACCB<int> CEDBHODPJLB(int AANPNADINAI, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JFDANJHACCB<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCD40", Offset = "0x1FDB940", VA = "0x181FDCD40")]
		public JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCDE0", Offset = "0x1FDB9E0", VA = "0x181FDCDE0", Slot = "6")]
		public void LOIGEBBDMHM(int BAEBMIBABAE, JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD, JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCCC0", Offset = "0x1FDB8C0", VA = "0x181FDCCC0", Slot = "4")]
		private JFDANJHACCB<int> LLKIBFEBAJM(int AANPNADINAI, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JFDANJHACCB<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCD30", Offset = "0x1FDB930", VA = "0x181FDCD30", Slot = "5")]
		private JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> HJKBKCKBKHN(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct JMDMLKMDNHB : PMKFFAMDIED<int, JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6B50", Offset = "0x1FE5750", VA = "0x181FE6B50")]
		public JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x13A98A0", Offset = "0x13A84A0", VA = "0x1813A98A0", Slot = "4")]
		public int KFBKIBAKELJ(int BAEBMIBABAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80")]
		public bool FGCLJEIKOLP(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "5")]
		private bool HIIOJADFKKI(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6B40", Offset = "0x1FE5740", VA = "0x181FE6B40", Slot = "6")]
		private JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> DMJBOENHCPE(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct BLNLNJKCOCK : JDHCEPACLDN<int, JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF850", Offset = "0x1FDE450", VA = "0x181FDF850")]
		public JFDANJHACCB<int> CEDBHODPJLB(int AANPNADINAI, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JFDANJHACCB<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF8D0", Offset = "0x1FDE4D0", VA = "0x181FDF8D0")]
		public JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF970", Offset = "0x1FDE570", VA = "0x181FDF970", Slot = "6")]
		public void LOIGEBBDMHM(int BAEBMIBABAE, JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD, JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF850", Offset = "0x1FDE450", VA = "0x181FDF850", Slot = "4")]
		private JFDANJHACCB<int> LLKIBFEBAJM(int AANPNADINAI, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JFDANJHACCB<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF8C0", Offset = "0x1FDE4C0", VA = "0x181FDF8C0", Slot = "5")]
		private JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> HJKBKCKBKHN(int BAEBMIBABAE, [In] JFDANJHACCB<(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> Target, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> ByteCodeWriteLocation)> COOBAOCKFHD)
		{
			return default(JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct CNOODMPOJLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> HCGDNCJHFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool FPJIEJMLFGC;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x10F2B40", Offset = "0x10F1740", VA = "0x1810F2B40")]
		public CNOODMPOJLK(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE, bool NCJBGEEIFFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFC90", Offset = "0x1FDE890", VA = "0x181FDFC90")]
		public void LLELCMMKHDC([Out] JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE, [Out] bool NCJBGEEIFFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct EFJPAHPKGNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly JCIKKDEFAFO<BNGCKMJMGMP> MBCCDMFICNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> HCGDNCJHFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool FPJIEJMLFGC;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE00F0", Offset = "0x1FDECF0", VA = "0x181FE00F0")]
		public EFJPAHPKGNF(JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE, bool NCJBGEEIFFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE00E0", Offset = "0x1FDECE0", VA = "0x181FE00E0")]
		public void LLELCMMKHDC([Out] JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE, [Out] bool NCJBGEEIFFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE00C0", Offset = "0x1FDECC0", VA = "0x181FE00C0")]
		public void LLELCMMKHDC([Out] JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE, [Out] JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI, [Out] bool NCJBGEEIFFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct IDBEOHLFMGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly JCIKKDEFAFO<BNGCKMJMGMP> MBCCDMFICNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> HCGDNCJHFDL;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
		public IDBEOHLFMGF(JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6700", Offset = "0x1FE5300", VA = "0x181FE6700")]
		public void LLELCMMKHDC([Out] JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE, [Out] JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE4C0", Offset = "0x1FDD0C0", VA = "0x181FDE4C0")]
	public static void KHBCMNOGPLL(this HIENOIMPHLO ENEDBNLKLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE790", Offset = "0x1FDD390", VA = "0x181FDE790")]
	public static void KIJGJPKNOCH(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<EBPAJHFGHPO> NHPBHEJEOBE, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> MNLOHEIBPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD600", Offset = "0x1FDC200", VA = "0x181FDD600")]
	public static void DKKJKJMGNPG(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<EBPAJHFGHPO> NHPBHEJEOBE, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> MNLOHEIBPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1FDCED0", Offset = "0x1FDBAD0", VA = "0x181FDCED0")]
	public static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>? AIGCFMGFPHK([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<EBPAJHFGHPO> NHPBHEJEOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1FDECB0", Offset = "0x1FDD8B0", VA = "0x181FDECB0")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> NOHBGJBCECH([In] this HIENOIMPHLO ENEDBNLKLJL)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEEE0", Offset = "0x1FDDAE0", VA = "0x181FDEEE0")]
	private static void PBINMEDJKOL(this HIENOIMPHLO ENEDBNLKLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1FDED10", Offset = "0x1FDD910", VA = "0x181FDED10")]
	private static JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>? NOJIBFIKHBJ([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDF80", Offset = "0x1FDCB80", VA = "0x181FDDF80")]
	public static void HPFGMODIEED(this HIENOIMPHLO ENEDBNLKLJL, [In] JFDANJHACCB<EBEJCBAHMFC> KDMECOHKCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEBD0", Offset = "0x1FDD7D0", VA = "0x181FDEBD0")]
	public static LBPEBBCLLJL.IECPHGEAMKD MIEDDFMPGND([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE)
	{
		return default(LBPEBBCLLJL.IECPHGEAMKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDC70", Offset = "0x1FDC870", VA = "0x181FDDC70")]
	public static BGNDAENKAGM<byte> FPCHMIIJPEP([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE)
	{
		return default(BGNDAENKAGM<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF260", Offset = "0x1FDDE60", VA = "0x181FDF260")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PIKMAANOIND([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE0F0", Offset = "0x1FDCCF0", VA = "0x181FDE0F0")]
	public static OBHAAEALFBF IDEEEANCILO([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x31EE320", Offset = "0x31ECF20", VA = "0x1831EE320")]
	private static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> CDNNNKMKMMO<TMJoin>(this HIENOIMPHLO ENEDBNLKLJL, LBPEBBCLLJL.IECPHGEAMKD KEIKGFCGOKN, JCIKKDEFAFO<TMJoin> KFDABGLPFON) where TMJoin : LBPEBBCLLJL.ACEJKGEBNMN
	{
		return default(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDE70", Offset = "0x1FDCA70", VA = "0x181FDDE70")]
	public static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GPFKDBLBGJC(this HIENOIMPHLO ENEDBNLKLJL, bool CNBMKFDCNCM)
	{
		return default(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDEF0", Offset = "0x1FDCAF0", VA = "0x181FDDEF0")]
	public static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> HBOHFHKCBIO(this HIENOIMPHLO ENEDBNLKLJL, BGNDAENKAGM<byte> GABEBEKDBIP)
	{
		return default(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD420", Offset = "0x1FDC020", VA = "0x181FDD420")]
	public static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> CAFIMFCENNG(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> IEJCAIAJHJG)
	{
		return default(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE440", Offset = "0x1FDD040", VA = "0x181FDE440")]
	public static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> JDBNILPCBGP(this HIENOIMPHLO ENEDBNLKLJL, int CCEKDLFPICE)
	{
		return default(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FDCF80", Offset = "0x1FDBB80", VA = "0x181FDCF80")]
	public static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> AJADCILFFPO(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> BHBIGHBHJIJ)
	{
		return default(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x31EEC40", Offset = "0x31ED840", VA = "0x1831EEC40")]
	private static JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI> LKNLLIDCLPD<TMJoin>(this HIENOIMPHLO ENEDBNLKLJL, NIPJFALODIE.IBMGBNHNPMD KEIKGFCGOKN, JCIKKDEFAFO<TMJoin> KFDABGLPFON) where TMJoin : NIPJFALODIE.MGLOAPNHJLN
	{
		return default(JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEEA0", Offset = "0x1FDDAA0", VA = "0x181FDEEA0")]
	public static JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI> OLFNMJMJBPC(this HIENOIMPHLO ENEDBNLKLJL)
	{
		return default(JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE960", Offset = "0x1FDD560", VA = "0x181FDE960")]
	public static JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI> KNDLLLOAFBC(this HIENOIMPHLO ENEDBNLKLJL)
	{
		return default(JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEE20", Offset = "0x1FDDA20", VA = "0x181FDEE20")]
	public static JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI> ODPMLMIJOIA(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> FKJIJLGNBHN)
	{
		return default(JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE2B0", Offset = "0x1FDCEB0", VA = "0x181FDE2B0")]
	public static JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI> IJHGLLBEADB(this HIENOIMPHLO ENEDBNLKLJL)
	{
		return default(JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEAD0", Offset = "0x1FDD6D0", VA = "0x181FDEAD0")]
	public static JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI> LAGINDJKJLH(this HIENOIMPHLO ENEDBNLKLJL)
	{
		return default(JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDDF0", Offset = "0x1FDC9F0", VA = "0x181FDDDF0")]
	public static GNMAIGIKODN.OPBBIFPLDFE GJFGKPMFLCM([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA> BCOMNBLLPBE)
	{
		return default(GNMAIGIKODN.OPBBIFPLDFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEB10", Offset = "0x1FDD710", VA = "0x181FDEB10")]
	public static DGFDEPEHIEJ<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>, GKKEBEKOJGK<GNMAIGIKODN.BBBBLNOKCHG>> LIFCCDPILAA([In] this HIENOIMPHLO ENEDBNLKLJL)
	{
		return default(DGFDEPEHIEJ<JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>, GKKEBEKOJGK<GNMAIGIKODN.BBBBLNOKCHG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD240", Offset = "0x1FDBE40", VA = "0x181FDD240")]
	public static JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BEOPGMPPOFB([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA> BCOMNBLLPBE)
	{
		return default(JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD1C0", Offset = "0x1FDBDC0", VA = "0x181FDD1C0")]
	public static GNMAIGIKODN.IMDBMKLHOMJ BBAPAIAPBJO([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BNOMKIFCIDJ)
	{
		return default(GNMAIGIKODN.IMDBMKLHOMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEB50", Offset = "0x1FDD750", VA = "0x181FDEB50")]
	public static GNMAIGIKODN.IMDBMKLHOMJ LOPCCFOLOHH(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BNOMKIFCIDJ)
	{
		return default(GNMAIGIKODN.IMDBMKLHOMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x31EEAA0", Offset = "0x31ED6A0", VA = "0x1831EEAA0")]
	private static JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA> JMCMGBNOJFO<TMJoin>(this HIENOIMPHLO ENEDBNLKLJL, GNMAIGIKODN.OPBBIFPLDFE KEIKGFCGOKN, JCIKKDEFAFO<TMJoin> KFDABGLPFON) where TMJoin : GNMAIGIKODN.LFDDJCCPHGO
	{
		return default(JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF350", Offset = "0x1FDDF50", VA = "0x181FDF350")]
	public static (JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA>, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>) PNEJAEFKPHL(this HIENOIMPHLO ENEDBNLKLJL)
	{
		return default((JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA>, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD9E0", Offset = "0x1FDC5E0", VA = "0x181FDD9E0")]
	public static (JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA>, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>) FBLPNCCKPGL(this HIENOIMPHLO ENEDBNLKLJL)
	{
		return default((JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA>, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDBA0", Offset = "0x1FDC7A0", VA = "0x181FDDBA0")]
	public static JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA> FEFDGNKHLIE(this HIENOIMPHLO ENEDBNLKLJL)
	{
		return default(JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDD60", Offset = "0x1FDC960", VA = "0x181FDDD60")]
	public static void GAAFGDICINF(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG> BNOMKIFCIDJ, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> EDMOAPGCGAC, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>> EDFAOGMBHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31EF130", Offset = "0x31EDD30", VA = "0x1831EF130")]
	public static CNOODMPOJLK MJALAEDECFF<TDeps, TStateSys>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI) where TDeps : DJOIABOLBPD<TStateSys>
	{
		return default(CNOODMPOJLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x31EE090", Offset = "0x31ECC90", VA = "0x1831EE090")]
	public static EFJPAHPKGNF BNPCFEPCFBH<TDeps, TStateSys>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BKMEFFNPIFK> DDPGCLLGMBN, int DLKDICJKMOE) where TDeps : DJOIABOLBPD<TStateSys>
	{
		return default(EFJPAHPKGNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x31EECF0", Offset = "0x31ED8F0", VA = "0x1831EECF0")]
	public static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>? MDBDEGADEPP<TDeps, TStateSys>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BKMEFFNPIFK> DDPGCLLGMBN, [In] ReadOnlySpan<int> CBIBPENNCLK, [In] Span<IDBEOHLFMGF> AIIMDOCOEBL) where TDeps : DJOIABOLBPD<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31EE3D0", Offset = "0x31ECFD0", VA = "0x1831EE3D0")]
	public static JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI> FNHABNMMKJE<TDeps, TStateSys>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<EBPAJHFGHPO> NHPBHEJEOBE) where TDeps : DJOIABOLBPD<TStateSys>
	{
		return default(JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD000", Offset = "0x1FDBC00", VA = "0x181FDD000")]
	public static NIMNFJBMPAP.PHMAPCGMPBE AJAOCEHKBOO([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> CABAGOHBNFK)
	{
		return default(NIMNFJBMPAP.PHMAPCGMPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD510", Offset = "0x1FDC110", VA = "0x181FDD510")]
	public static NIMNFJBMPAP.BBFHPJLMIDP DIIPPKCKLKL([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> CABAGOHBNFK)
	{
		return default(NIMNFJBMPAP.BBFHPJLMIDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD6D0", Offset = "0x1FDC2D0", VA = "0x181FDD6D0")]
	public static NIMNFJBMPAP.CHENAAJOKBI ECJFBBAJOEB([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> CABAGOHBNFK)
	{
		return default(NIMNFJBMPAP.CHENAAJOKBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD7C0", Offset = "0x1FDC3C0", VA = "0x181FDD7C0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> ENPJHNFHDGN(this HIENOIMPHLO ENEDBNLKLJL, int? DADIIODDGIH, string LONKACOOPGJ)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF0C0", Offset = "0x1FDDCC0", VA = "0x181FDF0C0")]
	public static NIMNFJBMPAP.GKDEFAKDGHL PDBNCDEKHDD([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> CABAGOHBNFK)
	{
		return default(NIMNFJBMPAP.GKDEFAKDGHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF050", Offset = "0x1FDDC50", VA = "0x181FDF050")]
	public static NIMNFJBMPAP.GLGNFAECKDN PCBPCNOIGFO([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> CABAGOHBNFK)
	{
		return default(NIMNFJBMPAP.GLGNFAECKDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD4A0", Offset = "0x1FDC0A0", VA = "0x181FDD4A0")]
	public static int? CCENFFLJNKI([In] this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> CABAGOHBNFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x31EEB40", Offset = "0x31ED740", VA = "0x1831EEB40")]
	private static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> LBDMEFAJLIH<TMJoin>(this HIENOIMPHLO ENEDBNLKLJL, int? DADIIODDGIH, NIMNFJBMPAP.GLGNFAECKDN KEIKGFCGOKN, JCIKKDEFAFO<TMJoin> KFDABGLPFON) where TMJoin : NIMNFJBMPAP.IJDCJCHHIKB
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF1B0", Offset = "0x1FDDDB0", VA = "0x181FDF1B0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PIIFAEBKALH(this HIENOIMPHLO ENEDBNLKLJL, int? DADIIODDGIH, JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA> BCOMNBLLPBE, int BAEBMIBABAE)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEC50", Offset = "0x1FDD850", VA = "0x181FDEC50")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> NJMMLPBMEEH(this HIENOIMPHLO ENEDBNLKLJL, int? DADIIODDGIH)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE2F0", Offset = "0x1FDCEF0", VA = "0x181FDE2F0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> IKBANLIDKAO(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>? OLAMHADIADO, int? DADIIODDGIH)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD950", Offset = "0x1FDC550", VA = "0x181FDD950")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EOPFFFLJHBN(this HIENOIMPHLO ENEDBNLKLJL, int? DADIIODDGIH, int BAEBMIBABAE)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEDC0", Offset = "0x1FDD9C0", VA = "0x181FDEDC0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> NPEOKADKPPB(this HIENOIMPHLO ENEDBNLKLJL, int? DADIIODDGIH)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE820", Offset = "0x1FDD420", VA = "0x181FDE820")]
	public static void KLMJKFBFHPK(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> BHBIGHBHJIJ, JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA> BCOMNBLLPBE, int BAEBMIBABAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE9A0", Offset = "0x1FDD5A0", VA = "0x181FDE9A0")]
	public static void KOLNKMOJEEH(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> BHBIGHBHJIJ, int BAEBMIBABAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE1E0", Offset = "0x1FDCDE0", VA = "0x181FDE1E0")]
	public static void IENPJLCEMKC(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> BHBIGHBHJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDBE0", Offset = "0x1FDC7E0", VA = "0x181FDDBE0")]
	public static void FLFKAMBENEJ(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> EEOLDJILHGA, JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> HMKECEKAEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD0F0", Offset = "0x1FDBCF0", VA = "0x181FDD0F0")]
	public static void AKKPIIHOCCC(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> BHBIGHBHJIJ, JCIKKDEFAFO<CBKKBBEDBLD<BEOOHFDIPMD>> LANPECACMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x31EE990", Offset = "0x31ED590", VA = "0x1831EE990")]
	public static void HCBAEMLIDIJ<M>(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> BHBIGHBHJIJ, JCIKKDEFAFO<CBKKBBEDBLD<DKNAMEIKMHD<M>>> LANPECACMAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface DJOIABOLBPD<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JCIKKDEFAFO<OHFLOCDKCBK> KEICOGILLEC(TStateSys BNPIGEKBIOD);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JCIKKDEFAFO<OHFLOCDKCBK> GDBHOJNKKAC(TStateSys BNPIGEKBIOD);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JCIKKDEFAFO<OHFLOCDKCBK> GGPEOCIAOIJ(TStateSys BNPIGEKBIOD);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JCIKKDEFAFO<OHFLOCDKCBK> NIMICAAOPOJ(TStateSys BNPIGEKBIOD);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI> GDPKMHMBAHD(TStateSys BNPIGEKBIOD, HIENOIMPHLO FAHLNPKGHIM, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> ALACLFGANED(TStateSys BNPIGEKBIOD, HIENOIMPHLO FAHLNPKGHIM, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<EBPAJHFGHPO> NHPBHEJEOBE);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NPEFLMMONEA(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JCIKKDEFAFO<EBPAJHFGHPO> FIHIIOKKOEG(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI, int AFFJKIAILLF);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CAABOFKJNDE OCMFKFKAPGJ(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GHOKKLDEPMI(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int GNEIJPDMOEM(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BGNDAENKAGM<byte> CBJDLDEGCOI(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(BGNDAENKAGM<byte>, JCIKKDEFAFO<OHFLOCDKCBK>) BPLBBBEOBII(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BNGCKMJMGMP> OMLIBFPFCNI);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int CEAEDIMBKBO(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<EBPAJHFGHPO> NHPBHEJEOBE);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JCIKKDEFAFO<BNGCKMJMGMP> DAGCIODMLJA(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<EBPAJHFGHPO> NHPBHEJEOBE, int DLKDICJKMOE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JCIKKDEFAFO<BNGCKMJMGMP> MOJDOBGBFFO(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, JCIKKDEFAFO<BKMEFFNPIFK> DDPGCLLGMBN, int DLKDICJKMOE);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int PACFHDCJNBP(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? OMEGMKJMFKA(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, int BAEBMIBABAE);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int JNHLMIPAMLL(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? OGPLPKGADED(TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE, int BAEBMIBABAE);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GJNEFFEDMDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2B37680", Offset = "0x2B36280", VA = "0x182B37680")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB?> IHDCJOHFHCG<T, TOpInput, TOpOutput>(this HIENOIMPHLO ENEDBNLKLJL, T HFIDNJCGLJB, T MGPFNHKFBHO, int AEDBNEHAPHG, IntPtr NPALNKANGEN)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2B37AF0", Offset = "0x2B366F0", VA = "0x182B37AF0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB?> JNPOBEINNKG<T, TOpInput, TOpOutput>(this HIENOIMPHLO ENEDBNLKLJL, T HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO, int AEDBNEHAPHG, IntPtr NPALNKANGEN)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2B37980", Offset = "0x2B36580", VA = "0x182B37980")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB?> JJPFHBJJEKE<TOpInput, TOpOutput>(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO, int AEDBNEHAPHG, IntPtr NPALNKANGEN)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0E10", Offset = "0x1FDFA10", VA = "0x181FE0E10")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> BHMMBLLCGOF(this HIENOIMPHLO ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE17E0", Offset = "0x1FE03E0", VA = "0x181FE17E0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> DLKBHGBLCPK(this HIENOIMPHLO ENEDBNLKLJL, float EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4B30", Offset = "0x1FE3730", VA = "0x181FE4B30")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PDNCHCDKLAG(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FE09F0", Offset = "0x1FDF5F0", VA = "0x181FE09F0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> AIADBFEFOEH(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2DB0", Offset = "0x1FE19B0", VA = "0x181FE2DB0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> JEIOBJECLIF(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4190", Offset = "0x1FE2D90", VA = "0x181FE4190")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MOHFLAIJGGD(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1530", Offset = "0x1FE0130", VA = "0x181FE1530")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> DJIFEBPEDLP(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE16C0", Offset = "0x1FE02C0", VA = "0x181FE16C0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> DLFNLGLIIFD(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE24F0", Offset = "0x1FE10F0", VA = "0x181FE24F0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> GMKMAIHEGCN(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2900", Offset = "0x1FE1500", VA = "0x181FE2900")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> HHCGMDCAGCJ(this HIENOIMPHLO ENEDBNLKLJL, int HFIDNJCGLJB, int MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FE42D0", Offset = "0x1FE2ED0", VA = "0x181FE42D0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MPOCGLOHJBO(this HIENOIMPHLO ENEDBNLKLJL, int HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1DB0", Offset = "0x1FE09B0", VA = "0x181FE1DB0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> ENMDOKAOFOL(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3420", Offset = "0x1FE2020", VA = "0x181FE3420")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> KAICJFBFBPA(this HIENOIMPHLO ENEDBNLKLJL, float HFIDNJCGLJB, float MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FE12C0", Offset = "0x1FDFEC0", VA = "0x181FE12C0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> DAELGHHEPKP(this HIENOIMPHLO ENEDBNLKLJL, float HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3260", Offset = "0x1FE1E60", VA = "0x181FE3260")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> JMEHDCBEJHB(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3D60", Offset = "0x1FE2960", VA = "0x181FE3D60")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> LIJMLLENIEP(this HIENOIMPHLO ENEDBNLKLJL, int HFIDNJCGLJB, int MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4DB0", Offset = "0x1FE39B0", VA = "0x181FE4DB0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PIJCLPJHBNC(this HIENOIMPHLO ENEDBNLKLJL, int HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2C10", Offset = "0x1FE1810", VA = "0x181FE2C10")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> ILPLNFIAGKC(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FE23D0", Offset = "0x1FE0FD0", VA = "0x181FE23D0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> GEEGJDAIPPB(this HIENOIMPHLO ENEDBNLKLJL, float HFIDNJCGLJB, float MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FE43F0", Offset = "0x1FE2FF0", VA = "0x181FE43F0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> NAKFMAHBCFH(this HIENOIMPHLO ENEDBNLKLJL, float HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE01A0", Offset = "0x1FDEDA0", VA = "0x181FE01A0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> AAAKPKMNGMI(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4AB0", Offset = "0x1FE36B0", VA = "0x181FE4AB0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PCMECNEFIEH(this HIENOIMPHLO ENEDBNLKLJL, int HFIDNJCGLJB, int MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FE33A0", Offset = "0x1FE1FA0", VA = "0x181FE33A0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> JONOAJHONND(this HIENOIMPHLO ENEDBNLKLJL, int HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE46D0", Offset = "0x1FE32D0", VA = "0x181FE46D0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> NJHDKKJAGFO(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1620", Offset = "0x1FE0220", VA = "0x181FE1620")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> DKAIGDEHOCB(this HIENOIMPHLO ENEDBNLKLJL, float HFIDNJCGLJB, float MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3730", Offset = "0x1FE2330", VA = "0x181FE3730")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> KLPMOJLODHF(this HIENOIMPHLO ENEDBNLKLJL, float HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4F50", Offset = "0x1FE3B50", VA = "0x181FE4F50")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PKJCMELPOHE(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2220", Offset = "0x1FE0E20", VA = "0x181FE2220")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> GBNIFHAOJMI(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1050", Offset = "0x1FDFC50", VA = "0x181FE1050")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> BMLLHCDHKEI(this HIENOIMPHLO ENEDBNLKLJL, int IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FE27E0", Offset = "0x1FE13E0", VA = "0x181FE27E0")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> GOMGBCABNHC(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2630", Offset = "0x1FE1230", VA = "0x181FE2630")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> GMLBBIENFNH(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GLPIHFPMAFE)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3DE0", Offset = "0x1FE29E0", VA = "0x181FE3DE0")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> LMMCBNLHIGD(this HIENOIMPHLO ENEDBNLKLJL, int IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2450", Offset = "0x1FE1050", VA = "0x181FE2450")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> GJDFMMHMJOC(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4FD0", Offset = "0x1FE3BD0", VA = "0x181FE4FD0")]
	public static (JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA>, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>) PMDMPOLGFDC(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<LLMICBBDFED> IFJPMDFKHAK, [In] ReadOnlySpan<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> BIIHFCIFFAD, [In] ReadOnlySpan<int?> KHGPHKGKIGB, [In] Span<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> MENPDHKHPNP)
	{
		return default((JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA>, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0350", Offset = "0x1FDEF50", VA = "0x181FE0350")]
	public static (JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA>, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>) AGCIMKAFLIN(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<BGLFKEALHMM> FOENMDBDFCI, [In] ReadOnlySpan<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> BIIHFCIFFAD, [In] ReadOnlySpan<int?> KHGPHKGKIGB, [In] Span<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> MENPDHKHPNP)
	{
		return default((JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA>, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2B35780", Offset = "0x2B34380", VA = "0x182B35780")]
	public static (JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<OHFLOCDKCBK>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<TMarker>>, JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA>) BHGHEGBPGLP<TMarker>(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<OHFLOCDKCBK> JFKIJOPNADK, [In] ReadOnlySpan<byte> JGFKFMMOAJO)
	{
		return default((JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<CBKKBBEDBLD<OHFLOCDKCBK>>, JCIKKDEFAFO<CBKKBBEDBLD<CEBNLENGEOG>>, JCIKKDEFAFO<CBKKBBEDBLD<TMarker>>, JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3CA0", Offset = "0x1FE28A0", VA = "0x181FE3CA0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> LHJMOBHDNLJ(this HIENOIMPHLO ENEDBNLKLJL, int LHEHPOLGBPN, [Optional] JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>? BIAIEKINDGJ)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0900", Offset = "0x1FDF500", VA = "0x181FE0900")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> AHGNEHJBNDC(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> LHEHPOLGBPN, [Optional] JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>? BIAIEKINDGJ)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4880", Offset = "0x1FE3480", VA = "0x181FE4880")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> OHFNGHGLIAL(this HIENOIMPHLO ENEDBNLKLJL, [In] ReadOnlySpan<byte> LHEHPOLGBPN, [Optional] JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>? BIAIEKINDGJ)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE45B0", Offset = "0x1FE31B0", VA = "0x181FE45B0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> NEOEDLLKJPM(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> LHEHPOLGBPN, int INGCLKPLIOP, [Optional] JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>? BIAIEKINDGJ)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE11C0", Offset = "0x1FDFDC0", VA = "0x181FE11C0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> CFGHJCAIMFL(this HIENOIMPHLO ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1900", Offset = "0x1FE0500", VA = "0x181FE1900")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> DPAGACALDAN(this HIENOIMPHLO ENEDBNLKLJL, float EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1C60", Offset = "0x1FE0860", VA = "0x181FE1C60")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EHLLENFKBON(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3520", Offset = "0x1FE2120", VA = "0x181FE3520")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> KDADAEMMNJE(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1FE29F0", Offset = "0x1FE15F0", VA = "0x181FE29F0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> IIGLFEDEKMD(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1FE07C0", Offset = "0x1FDF3C0", VA = "0x181FE07C0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> AHAABBAONGP(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1FE21A0", Offset = "0x1FE0DA0", VA = "0x181FE21A0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> GAJIDJJIHME(this HIENOIMPHLO ENEDBNLKLJL, int HFIDNJCGLJB, int MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2880", Offset = "0x1FE1480", VA = "0x181FE2880")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> HCDGJGFMFHJ(this HIENOIMPHLO ENEDBNLKLJL, int HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2010", Offset = "0x1FE0C10", VA = "0x181FE2010")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> FGLBDNJGFFL(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> HFIDNJCGLJB, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MGPFNHKFBHO)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE37B0", Offset = "0x1FE23B0", VA = "0x181FE37B0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> KMKIOFKBNDJ(this HIENOIMPHLO ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0220", Offset = "0x1FDEE20", VA = "0x181FE0220")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> AELCIGIMIBH(this HIENOIMPHLO ENEDBNLKLJL, float EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4C70", Offset = "0x1FE3870", VA = "0x181FE4C70")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PFNEEDLEEKG(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE10D0", Offset = "0x1FDFCD0", VA = "0x181FE10D0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> CCICONKHLND(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2C90", Offset = "0x1FE1890", VA = "0x181FE2C90")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> IOALNEBJELB(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4050", Offset = "0x1FE2C50", VA = "0x181FE4050")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MNLCKFNGOEK(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE16A0", Offset = "0x1FE02A0", VA = "0x181FE16A0")]
	public static JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>> DKHKJGIHIJE(this HIENOIMPHLO ENEDBNLKLJL)
	{
		return default(JCIKKDEFAFO<CBKKBBEDBLD<CBKKBBEDBLD<CHMHJEBDLEO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2B10", Offset = "0x1FE1710", VA = "0x181FE2B10")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> IKGCBIJGKCL(this HIENOIMPHLO ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4E30", Offset = "0x1FE3A30", VA = "0x181FE4E30")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PKIFMOHGDDO(this HIENOIMPHLO ENEDBNLKLJL, float EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0CD0", Offset = "0x1FDF8D0", VA = "0x181FE0CD0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> BGFGNAPKODE(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE38B0", Offset = "0x1FE24B0", VA = "0x181FE38B0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> LGCKCBMBCDP(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1EF0", Offset = "0x1FE0AF0", VA = "0x181FE1EF0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> FFEDKAHFPBA(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0F10", Offset = "0x1FDFB10", VA = "0x181FE0F10")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> BLMFHBAADCH(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3F50", Offset = "0x1FE2B50", VA = "0x181FE3F50")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MECGBEAPOPJ(this HIENOIMPHLO ENEDBNLKLJL, int IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2090", Offset = "0x1FE0C90", VA = "0x181FE2090")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> FLLFOMOPNKM(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> IIPLJLPCLBC)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1DA0", Offset = "0x1FE09A0", VA = "0x181FE1DA0")]
	public static void EJLMLOOEBCA(this HIENOIMPHLO ENEDBNLKLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0AE0", Offset = "0x1FDF6E0", VA = "0x181FE0AE0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> BCECLICCBJL(this HIENOIMPHLO ENEDBNLKLJL, float EIMAMGODFEG, float PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1B40", Offset = "0x1FE0740", VA = "0x181FE1B40")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EHCCJCJOOJB(this HIENOIMPHLO ENEDBNLKLJL, float EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4970", Offset = "0x1FE3570", VA = "0x181FE4970")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> ONOIMHCPJBJ(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3E60", Offset = "0x1FE2A60", VA = "0x181FE3E60")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> MAEOMMKMCHB(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1A20", Offset = "0x1FE0620", VA = "0x181FE1A20")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> ECNENGBJFIM(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4470", Offset = "0x1FE3070", VA = "0x181FE4470")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> NDNKIOHHFCP(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2ED0", Offset = "0x1FE1AD0", VA = "0x181FE2ED0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> JEMJMDDFHLL(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> CEEAEJIIBFG, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> PBJMFINFOBH)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0BE0", Offset = "0x1FDF7E0", VA = "0x181FE0BE0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> BEIJNIMMJNJ(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, int PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3610", Offset = "0x1FE2210", VA = "0x181FE3610")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> KEHHAKPDKNP(this HIENOIMPHLO ENEDBNLKLJL, int EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1FE13F0", Offset = "0x1FDFFF0", VA = "0x181FE13F0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> DCMHOENKPOP(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> EIMAMGODFEG, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> PMIMEIKCDGB)
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2B351E0", Offset = "0x2B33DE0", VA = "0x182B351E0")]
	public static void ALAJBNPLJGM<TDeps, TState>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TState FFBJIDDDHKC, JCIKKDEFAFO<LLMICBBDFED> IFJPMDFKHAK, [In] ReadOnlySpan<JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>> ILNBJCCDMPF, [In] ReadOnlySpan<int?> KHGPHKGKIGB, [In] Span<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> MENPDHKHPNP, [In] Span<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> AEMGIEHEPOJ, [In] ReadOnlySpan<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>?> HJPPLGMHNMF) where TDeps : notnull, DJOIABOLBPD<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2B35880", Offset = "0x2B34480", VA = "0x182B35880")]
	public static void CBEIKIBMHMP<TDeps, TState>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TState FFBJIDDDHKC, JCIKKDEFAFO<BGLFKEALHMM> FKJLAAGOMNG, [In] ReadOnlySpan<JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>> CLHNOEBGHDF, [In] ReadOnlySpan<int?> KHGPHKGKIGB, [In] Span<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> MENPDHKHPNP, [In] Span<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>> AEMGIEHEPOJ, [In] ReadOnlySpan<JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>?> HJPPLGMHNMF) where TDeps : notnull, DJOIABOLBPD<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2B36620", Offset = "0x2B35220", VA = "0x182B36620")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> FHNJMNCCNOK<TDeps, TState>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TState FFBJIDDDHKC, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> OLAMHADIADO, [Optional] JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>? BIAIEKINDGJ) where TDeps : notnull, DJOIABOLBPD<TState> where TState : notnull
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2B361C0", Offset = "0x2B34DC0", VA = "0x182B361C0")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> FFIMGOCEPBL<TDeps, TState>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TState FFBJIDDDHKC, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> FKJIJLGNBHN, [Optional] JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>? BIAIEKINDGJ) where TDeps : notnull, DJOIABOLBPD<TState> where TState : notnull
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2B37240", Offset = "0x2B35E40", VA = "0x182B37240")]
	public static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GOCDFAFNGBD<TDeps, TStateSys>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TStateSys BNPIGEKBIOD) where TDeps : notnull, DJOIABOLBPD<TStateSys> where TStateSys : notnull
	{
		return default(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2B37470", Offset = "0x2B36070", VA = "0x182B37470")]
	public static JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI> HEKDIMOGHBO<TDeps, TStateSys>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TStateSys BNPIGEKBIOD) where TDeps : notnull, DJOIABOLBPD<TStateSys> where TStateSys : notnull
	{
		return default(JCIKKDEFAFO<NIPJFALODIE.DPCGKKALOBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4750", Offset = "0x1FE3350", VA = "0x181FE4750")]
	public static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> OBJGGPOLNLL(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> HMNINDMJBDL, IntPtr DOKCDDDJAMD, IntPtr BFPHLIAFAGG)
	{
		return default(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1FE39A0", Offset = "0x1FE25A0", VA = "0x181FE39A0")]
	public static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> LHIKODDIAGL(this HIENOIMPHLO ENEDBNLKLJL, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> JDOMIMHBKFD, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> HMIJICGDEBO, IntPtr IMAEOFEHLIK, IntPtr NNMBFPPKHLJ, IntPtr HLJICGMOFOC, bool KLMOGODGAHO)
	{
		return default(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2B36B20", Offset = "0x2B35720", VA = "0x182B36B20")]
	public static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GACIPCLDLKE<TDeps, TState>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TState FFBJIDDDHKC, JCIKKDEFAFO<LLMICBBDFED> GKPHAENFFJB, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> JDOMIMHBKFD, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> HMIJICGDEBO, int? AHAHPDKBCHM, [Optional] IntPtr LPHMPMGCAKP) where TDeps : notnull, DJOIABOLBPD<TState> where TState : notnull
	{
		return default(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2B36800", Offset = "0x2B35400", VA = "0x182B36800")]
	private static JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> GACIPCLDLKE<TDeps, TState>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TState FFBJIDDDHKC, JCIKKDEFAFO<LLMICBBDFED> GKPHAENFFJB, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> JDOMIMHBKFD, JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI> HMIJICGDEBO, int? AHAHPDKBCHM) where TDeps : notnull, DJOIABOLBPD<TState> where TState : notnull
	{
		return default(JCIKKDEFAFO<LBPEBBCLLJL.IKJINJNOAAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2B35E20", Offset = "0x2B34A20", VA = "0x182B35E20")]
	public static JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> DGCIJKADKMD<TDeps, TState>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TState FFBJIDDDHKC, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB> LHEHPOLGBPN, JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>? BIAIEKINDGJ) where TDeps : notnull, DJOIABOLBPD<TState> where TState : notnull
	{
		return default(JCIKKDEFAFO<NIMNFJBMPAP.JIFBEGCLMEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2B37E90", Offset = "0x2B36A90", VA = "0x182B37E90")]
	public static void NEOEJKELJHF<TDeps, TState>(this HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TState FFBJIDDDHKC, int EMJMHDNNEDG) where TDeps : notnull, DJOIABOLBPD<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct KGDHMIPBKGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> PEMDDDIIIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> JABFNPFAJGH;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
	public KGDHMIPBKGI(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> KBPJOMNHCMA, JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> LDBLPCPNCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6C40", Offset = "0x1FE5840", VA = "0x181FE6C40")]
	public static KGDHMIPBKGI FCDPFGJNKNI(JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>> KBPJOMNHCMA)
	{
		return default(KGDHMIPBKGI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct NIMNFJBMPAP
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class AKGDPGIFGKB : IJDCJCHHIKB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct PHMAPCGMPBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA> PMDFONLBFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int ICIBDGPPAOE;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
		public PHMAPCGMPBE(JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA> BCOMNBLLPBE, int BAEBMIBABAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class MENBBDHOHKH : IJDCJCHHIKB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct BBFHPJLMIDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int ICIBDGPPAOE;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
		public BBFHPJLMIDP(int BAEBMIBABAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class DHAFBOKDIBI : IJDCJCHHIKB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct CHENAAJOKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA> PMDFONLBFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int ICIBDGPPAOE;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
		public CHENAAJOKBI(JCIKKDEFAFO<GNMAIGIKODN.KGLHOJJIDHA> BCOMNBLLPBE, int BAEBMIBABAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum GLGNFAECKDN
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class JIFBEGCLMEB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class IJDCJCHHIKB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct ONGJICKHBEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? IECLANOBPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public KGDHMIPBKGI BJBIKBAFIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public GLGNFAECKDN PBMGCIOLAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public JCIKKDEFAFO<IJDCJCHHIKB> HLELINFJNBO;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7D20", Offset = "0x1FE6920", VA = "0x181FE7D20")]
		public ONGJICKHBEJ(int? DADIIODDGIH, [In] KGDHMIPBKGI PGCNFMPADNG, GLGNFAECKDN KEIKGFCGOKN, JCIKKDEFAFO<IJDCJCHHIKB> KFDABGLPFON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class FDNBGADKBEO : IJDCJCHHIKB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct GKDEFAKDGHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int ICIBDGPPAOE;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510")]
		public GKDEFAKDGHL(int BAEBMIBABAE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal OKMPIMBAFGM<JIFBEGCLMEB, ONGJICKHBEJ> POJNHGJKAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal OKMPIMBAFGM<AKGDPGIFGKB, PHMAPCGMPBE> KFNOCOEBDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal OKMPIMBAFGM<DHAFBOKDIBI, CHENAAJOKBI> EFCIONCEJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal OKMPIMBAFGM<FDNBGADKBEO, GKDEFAKDGHL> OCFONHCOION;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal OKMPIMBAFGM<MENBBDHOHKH, BBFHPJLMIDP> APPEGDAEGHI;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7980", Offset = "0x1FE6580", VA = "0x181FE7980")]
	private NIMNFJBMPAP([In] OKMPIMBAFGM<JIFBEGCLMEB, ONGJICKHBEJ> OOOAMIHIBEH, [In] OKMPIMBAFGM<AKGDPGIFGKB, PHMAPCGMPBE> IPJCLABLMEG, [In] OKMPIMBAFGM<DHAFBOKDIBI, CHENAAJOKBI> MKEGJNMBGBA, [In] OKMPIMBAFGM<FDNBGADKBEO, GKDEFAKDGHL> LLABMNHBMHB, [In] OKMPIMBAFGM<MENBBDHOHKH, BBFHPJLMIDP> OHJIKHHHCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7790", Offset = "0x1FE6390", VA = "0x181FE7790")]
	public static NIMNFJBMPAP FCDPFGJNKNI()
	{
		return default(NIMNFJBMPAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class MGLPHLFEDKA
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7050", Offset = "0x1FE5C50", VA = "0x181FE7050")]
	public static void KHBCMNOGPLL(this NIMNFJBMPAP ENEDBNLKLJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class COCCOICJLIH
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFCA0", Offset = "0x1FDE8A0", VA = "0x181FDFCA0")]
	public static void MGFNPLKOLEC(HIENOIMPHLO ENEDBNLKLJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct NGOIBHIHIJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, PAACBJHDHEK> EONLEHJLLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int HCIGDHAILLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int HFMBDCAFBKC;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7750", Offset = "0x1FE6350", VA = "0x181FE7750")]
	private NGOIBHIHIJM([In] KCNOHKPEBHA<GNMAIGIKODN.BBBBLNOKCHG, PAACBJHDHEK> ABHLDNOKCLF, int EEENHHDHLFC, int HAOFEOGBMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE74F0", Offset = "0x1FE60F0", VA = "0x181FE74F0")]
	public static NGOIBHIHIJM FCDPFGJNKNI()
	{
		return default(NGOIBHIHIJM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7560", Offset = "0x1FE6160", VA = "0x181FE7560")]
	public void KHBCMNOGPLL([In] HIENOIMPHLO KKOKJDBNFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA77A0", Offset = "0x2CA63A0", VA = "0x182CA77A0")]
	public static void MGFNPLKOLEC<TDeps, TStateSys>(HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TStateSys BNPIGEKBIOD, JCIKKDEFAFO<LDNFOKBFEMK> CJJOKEDEAPE) where TDeps : notnull, DJOIABOLBPD<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class IKNNEOJFENI
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6710", Offset = "0x1FE5310", VA = "0x181FE6710")]
	public static void MGFNPLKOLEC(HIENOIMPHLO ENEDBNLKLJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct BDKHDCEJNOM
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface DMFALPAIOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MBFCLFBLECO(JFDANJHACCB<byte> ODBIEHMMCPH, int HDKCOOKMDLO);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct MHJMINNLLDA : DMFALPAIOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7100", Offset = "0x1FE5D00", VA = "0x181FE7100", Slot = "4")]
		public void MBFCLFBLECO(JFDANJHACCB<byte> ODBIEHMMCPH, int HDKCOOKMDLO)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct HBBFILODFED : DMFALPAIOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5690", Offset = "0x1FE4290", VA = "0x181FE5690", Slot = "4")]
		public void MBFCLFBLECO(JFDANJHACCB<byte> ODBIEHMMCPH, int HDKCOOKMDLO)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct PMLKNICHDKK : DMFALPAIOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7E40", Offset = "0x1FE6A40", VA = "0x181FE7E40", Slot = "4")]
		public void MBFCLFBLECO(JFDANJHACCB<byte> ODBIEHMMCPH, int HDKCOOKMDLO)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct ICCAAGJGINI : DMFALPAIOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6650", Offset = "0x1FE5250", VA = "0x181FE6650", Slot = "4")]
		public void MBFCLFBLECO(JFDANJHACCB<byte> ODBIEHMMCPH, int HDKCOOKMDLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class FIJKPNPAFJF<TCallProcessorDeps> where TCallProcessorDeps : struct, DMFALPAIOBL
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps PLLBOMGPHPP;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BBB0", Offset = "0x2A7A7B0", VA = "0x182A7BBB0")]
		public static int MGFNPLKOLEC<TDeps, TStateSys>(TDeps EIDBKEEIBKK, TStateSys FFBJIDDDHKC, HIENOIMPHLO KKOKJDBNFON, [In] JFDANJHACCB<byte> PNLIOBCLHBK, int HJCFKINBOFA) where TDeps : DJOIABOLBPD<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private JFDANJHACCB<EBEJCBAHMFC> LPDDMCMBLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>> GDPBEDFCCHE;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF620", Offset = "0x1FDE220", VA = "0x181FDF620")]
	private BDKHDCEJNOM([In] JFDANJHACCB<EBEJCBAHMFC> KDMECOHKCOG, Dictionary<JCIKKDEFAFO<CBKKBBEDBLD<CHMHJEBDLEO>>, JCIKKDEFAFO<GNMAIGIKODN.BBBBLNOKCHG>> PBOLNPPKKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF520", Offset = "0x1FDE120", VA = "0x181FDF520")]
	public static BDKHDCEJNOM FCDPFGJNKNI()
	{
		return default(BDKHDCEJNOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF5E0", Offset = "0x1FDE1E0", VA = "0x181FDF5E0")]
	public void KHBCMNOGPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x28EF2D0", Offset = "0x28EDED0", VA = "0x1828EF2D0")]
	public static void MGFNPLKOLEC<TDeps, TStateSys>(HIENOIMPHLO ENEDBNLKLJL, TDeps EIDBKEEIBKK, TStateSys BNPIGEKBIOD) where TDeps : DJOIABOLBPD<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class AJPLMNPCOCO<TDeps, TIndex, TValues> where TDeps : struct, JDHCEPACLDN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps PLLBOMGPHPP;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3D33A20", Offset = "0x3D32620", VA = "0x183D33A20")]
	public static void MGFNPLKOLEC([In] JFDANJHACCB<EBEJCBAHMFC> KDMECOHKCOG, int AANPNADINAI, TValues COOBAOCKFHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface JDHCEPACLDN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JFDANJHACCB<TIndex> CEDBHODPJLB(int AANPNADINAI, [In] TValues COOBAOCKFHD);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(TIndex BAEBMIBABAE, [In] TValues COOBAOCKFHD);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOIGEBBDMHM(TIndex BAEBMIBABAE, TValues COOBAOCKFHD, JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> IIPLJLPCLBC);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface PMKFFAMDIED<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex KFBKIBAKELJ(int BAEBMIBABAE);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FGCLJEIKOLP(TIndex BAEBMIBABAE, [In] TValues COOBAOCKFHD);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JCIKKDEFAFO<CBKKBBEDBLD<OPFCLJJOIHA>> JNFGCCOHMHD(TIndex BAEBMIBABAE, [In] TValues COOBAOCKFHD);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class EGJBACLOIHL<TDeps, TIndex, TValues> where TDeps : struct, PMKFFAMDIED<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps PLLBOMGPHPP;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3846350", Offset = "0x3844F50", VA = "0x183846350")]
	public static JFDANJHACCB<TIndex> MGFNPLKOLEC(int AANPNADINAI, [In] TValues COOBAOCKFHD)
	{
		return default(JFDANJHACCB<TIndex>);
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

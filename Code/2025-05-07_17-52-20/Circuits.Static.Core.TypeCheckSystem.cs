using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct EDJNMCMNJBC<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType KFIKOGBAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind EJDIHGILANH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xC16D80", Offset = "0xC15D80", VA = "0x180C16D80")]
	internal EDJNMCMNJBC(TType MLCOGCMJLBB, IOKind BAFEPPLCHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x44BCFF0", Offset = "0x44BBFF0", VA = "0x1844BCFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MELGBDJADFK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x390E370", Offset = "0x390D370", VA = "0x18390E370")]
	public static EDJNMCMNJBC<TType> ACADPGMDEBE<TType>(TType MLCOGCMJLBB, IOKind BAFEPPLCHEP)
	{
		return default(EDJNMCMNJBC<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x390E410", Offset = "0x390D410", VA = "0x18390E410")]
	public static (TType, IOKind) OLNMFLOGPBC<TType>([In] this EDJNMCMNJBC<TType> OCACDKEJIIB)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x390E3A0", Offset = "0x390D3A0", VA = "0x18390E3A0")]
	public static void BGDNOIMKKGE<TType>([In] this EDJNMCMNJBC<TType> OCACDKEJIIB, [Out] TType MLCOGCMJLBB, [Out] IOKind BAFEPPLCHEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct ECPCPHEGAHA<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly ACIGJEEGNFK<TNode> KFHPLAEDEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ACIGJEEGNFK<TNode> BCKCKKFOOCC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x44BB5A0", Offset = "0x44BA5A0", VA = "0x1844BB5A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LGAOKKHKNEE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x38F7450", Offset = "0x38F6450", VA = "0x1838F7450")]
	public static (ACIGJEEGNFK<TNode>, ACIGJEEGNFK<TNode>) OLNMFLOGPBC<TNode>([In] this ECPCPHEGAHA<TNode> OCACDKEJIIB)
	{
		return default((ACIGJEEGNFK<TNode>, ACIGJEEGNFK<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x38F7350", Offset = "0x38F6350", VA = "0x1838F7350")]
	public static void BGDNOIMKKGE<TNode>([In] this ECPCPHEGAHA<TNode> OCACDKEJIIB, [Out] ACIGJEEGNFK<TNode> JOOBCOFNIAM, [Out] ACIGJEEGNFK<TNode> MCIIEEEAOOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GDOJMPAIEGB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NEPIHMACEAF JLKHCADHFAI(TRoot KNNDNAPJIDP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType EMHLIJNHOCO(TRoot KNNDNAPJIDP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EDJNMCMNJBC<TType> FOKCLEOJCCH(TRoot KNNDNAPJIDP, [In] EDJNMCMNJBC<TType> OBNCJFFHHLB, [In] EDJNMCMNJBC<TType> ODHPFGNCGDP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LDOCHHENGGK(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TNode GOJJJBGJPAM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FLLNLGEOEIM(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TNode GOJJJBGJPAM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput JPJOKPMANAN(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TNode GOJJJBGJPAM, int OHHMJGCBCKD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int LDHGCGPNIEC(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TNode GOJJJBGJPAM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput HOCEBDNJPIF(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TNode GOJJJBGJPAM, int OHHMJGCBCKD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<FKLAGBNMNLI<TType>> ADPAONLIMNN(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TNode GOJJJBGJPAM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<ECPCPHEGAHA<TNode>> GDEHCADFOFM(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TNode GOJJJBGJPAM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType ODLOFNKLEEA(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TInput HPLMFDGMJFE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int HIOPJCCIEBJ(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TInput HPLMFDGMJFE);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput LKCLOLMPEME(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TInput HPLMFDGMJFE, int OHHMJGCBCKD);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode MBEEBPKOFKB(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TInput HPLMFDGMJFE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType DKFFBFJFLEL(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TOutput MFNAKEDKNJF);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int GLAJALGNFID(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TOutput MFNAKEDKNJF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput GDBDCBCNIBE(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TOutput MFNAKEDKNJF, int OHHMJGCBCKD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode GJCAAMKFDOA(TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, TOutput MFNAKEDKNJF);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FLHJJFHDLNL(TRoot KNNDNAPJIDP, TType MLCOGCMJLBB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType JNLFGJLAKFP(TRoot KNNDNAPJIDP, TType MLCOGCMJLBB, IEnumerable<TType> GPBMGCJHBOG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EMPJKHNKDJM(TRoot KNNDNAPJIDP, TType MLCOGCMJLBB, Action<TType> DCCBDFNGPDJ, Action<TType> NJOCMIKJFOC, Action<TType> CBMGKKLGAPJ, Action<TType> BHOGMFAMNGM);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType BPEPOKOIBIB(TRoot KNNDNAPJIDP, TType MLCOGCMJLBB);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string BFJGDMFPHKH(TRoot KNNDNAPJIDP, TType MLCOGCMJLBB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification CLCMPNJAHOI(TRoot KNNDNAPJIDP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	HHHCCNLMPJL<TOutputSubstitution[], OGMCLKGLBPG> GJEJIOKEOOD(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm HNCEODLHBPO(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm JOIGKFLMEEN(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG, TTerm CGBEIKAMKGA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm EMPCICDHOEP(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG, TTerm EKBPMBFJFCG, TTerm FMDPDNGNNPP);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OEFHFEMDLLJ(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG, TTerm OBNCJFFHHLB, TTerm ODHPFGNCGDP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool MGCFKEHLLCN(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG, TOutputTerm JMPAJNNALOB);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool CKIGMBEEFIF(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG, TOutputTerm JMPAJNNALOB);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm IOHJBDKOPAH(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG, TOutputTerm JMPAJNNALOB);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm EPBBCFIJBAM(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG, TOutputTerm JMPAJNNALOB);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm IKDBLNHCGNI(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG, TOutputTerm JMPAJNNALOB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm LCFKNCIKGLH(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG, TOutputSubstitution JEJDCPMILEK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm JJOLEJDGLMC(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG, TOutputSubstitution JEJDCPMILEK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm BNHMKCFAJKO(TRoot KNNDNAPJIDP, TUnification MNBBBPGAAAG, TTerm CGBEIKAMKGA);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct IHHABGGEIDN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::GDOJMPAIEGB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820")]
	public static global::IHHABGGEIDN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> ACADPGMDEBE()
	{
		return default(global::IHHABGGEIDN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AENEIAFDMMP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class LELNAMAAKCL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::GDOJMPAIEGB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class BDCLJGDNFDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot FMDIEJKNFGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps DNEFEDCIDAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification DHJFCMLEAHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph HALGBIGEKEI;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public NEPIHMACEAF LHGHBGCIKKC
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x61B86A0", Offset = "0x61B76A0", VA = "0x1861B86A0")]
				get
				{
					return default(NEPIHMACEAF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x61B8AB0", Offset = "0x61B7AB0", VA = "0x1861B8AB0")]
			private BDCLJGDNFDJ(TRoot KNNDNAPJIDP, TDeps MMCKJCAOGBM, TUnification DLNMCLEEBEK, TGraph NOKCJFMDPME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x61B5E80", Offset = "0x61B4E80", VA = "0x1861B5E80")]
			public static BDCLJGDNFDJ ACADPGMDEBE(TRoot KNNDNAPJIDP, TDeps MMCKJCAOGBM, TUnification DLNMCLEEBEK, TGraph NOKCJFMDPME)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x61B6C90", Offset = "0x61B5C90", VA = "0x1861B6C90")]
			public TType EMHLIJNHOCO()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x61B7310", Offset = "0x61B6310", VA = "0x1861B7310")]
			public EDJNMCMNJBC<TType> FOKCLEOJCCH(EDJNMCMNJBC<TType> OBNCJFFHHLB, EDJNMCMNJBC<TType> ODHPFGNCGDP)
			{
				return default(EDJNMCMNJBC<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x61B8200", Offset = "0x61B7200", VA = "0x1861B8200")]
			public int LDOCHHENGGK(TNode GOJJJBGJPAM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x61B7250", Offset = "0x61B6250", VA = "0x1861B7250")]
			public int FLLNLGEOEIM(TNode GOJJJBGJPAM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x61B7F00", Offset = "0x61B6F00", VA = "0x1861B7F00")]
			public TInput JPJOKPMANAN(TNode GOJJJBGJPAM, int OHHMJGCBCKD)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x61B8140", Offset = "0x61B7140", VA = "0x1861B8140")]
			public int LDHGCGPNIEC(TNode GOJJJBGJPAM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x61B7A70", Offset = "0x61B6A70", VA = "0x1861B7A70")]
			public TOutput HOCEBDNJPIF(TNode GOJJJBGJPAM, int OHHMJGCBCKD)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x61B6390", Offset = "0x61B5390", VA = "0x1861B6390")]
			public IEnumerable<FKLAGBNMNLI<TType>> ADPAONLIMNN(TNode GOJJJBGJPAM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x61B7650", Offset = "0x61B6650", VA = "0x1861B7650")]
			public IEnumerable<ECPCPHEGAHA<TNode>> GDEHCADFOFM([In] TNode GOJJJBGJPAM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x61B8860", Offset = "0x61B7860", VA = "0x1861B8860")]
			public TType ODLOFNKLEEA(TInput HPLMFDGMJFE)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x61B6450", Offset = "0x61B5450", VA = "0x1861B6450")]
			public int AKHKNBGAJOA(TInput HPLMFDGMJFE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x61B8360", Offset = "0x61B7360", VA = "0x1861B8360")]
			public TOutput LKCLOLMPEME(TInput HPLMFDGMJFE, int OHHMJGCBCKD)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x61B84B0", Offset = "0x61B74B0", VA = "0x1861B84B0")]
			public TNode MBEEBPKOFKB(TInput HPLMFDGMJFE)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x61B6B50", Offset = "0x61B5B50", VA = "0x1861B6B50")]
			public TType DKFFBFJFLEL(TOutput MFNAKEDKNJF)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x61B6200", Offset = "0x61B5200", VA = "0x1861B6200")]
			public int ACOJMKJNFFP(TOutput MFNAKEDKNJF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x61B7600", Offset = "0x61B6600", VA = "0x1861B7600")]
			public TInput GDBDCBCNIBE(TOutput MFNAKEDKNJF, int OHHMJGCBCKD)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x61B7750", Offset = "0x61B6750", VA = "0x1861B7750")]
			public TNode GJCAAMKFDOA(TOutput MFNAKEDKNJF)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x61B7100", Offset = "0x61B6100", VA = "0x1861B7100")]
			public bool FLHJJFHDLNL(TType MLCOGCMJLBB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x61B7CB0", Offset = "0x61B6CB0", VA = "0x1861B7CB0")]
			public TType JNLFGJLAKFP(TType MLCOGCMJLBB, IEnumerable<TType> GPBMGCJHBOG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x61B6E60", Offset = "0x61B5E60", VA = "0x1861B6E60")]
			public void EMPJKHNKDJM(TType MLCOGCMJLBB, Action<TType> DCCBDFNGPDJ, Action<TType> NJOCMIKJFOC, Action<TType> CBMGKKLGAPJ, Action<TType> BHOGMFAMNGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x61B6870", Offset = "0x61B5870", VA = "0x1861B6870")]
			public TType BPEPOKOIBIB(TType MLCOGCMJLBB)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x61B66D0", Offset = "0x61B56D0", VA = "0x1861B66D0")]
			public string BFJGDMFPHKH(TType MLCOGCMJLBB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x61B7920", Offset = "0x61B6920", VA = "0x1861B7920")]
			public TTerm HNCEODLHBPO()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x61B7D70", Offset = "0x61B6D70", VA = "0x1861B7D70")]
			public TTerm JOIGKFLMEEN(TTerm CGBEIKAMKGA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x61B6E10", Offset = "0x61B5E10", VA = "0x1861B6E10")]
			public TTerm EMPCICDHOEP(TTerm EKBPMBFJFCG, TTerm FMDPDNGNNPP)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x61B89E0", Offset = "0x61B79E0", VA = "0x1861B89E0")]
			public void OEFHFEMDLLJ(TTerm OBNCJFFHHLB, TTerm ODHPFGNCGDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x61B6960", Offset = "0x61B5960", VA = "0x1861B6960")]
			public bool CKIGMBEEFIF(TOutputTerm CGBEIKAMKGA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x61B85A0", Offset = "0x61B75A0", VA = "0x1861B85A0")]
			public bool MGCFKEHLLCN(TOutputTerm CGBEIKAMKGA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x61B65B0", Offset = "0x61B55B0", VA = "0x1861B65B0")]
			public TTerm BENGOECFJFB(TOutputTerm JMPAJNNALOB)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x61B6FE0", Offset = "0x61B5FE0", VA = "0x1861B6FE0")]
			public TOutputTerm EPBBCFIJBAM(TOutputTerm CGBEIKAMKGA)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x61B7AC0", Offset = "0x61B6AC0", VA = "0x1861B7AC0")]
			public TOutputTerm IKDBLNHCGNI(TOutputTerm CGBEIKAMKGA)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x61B8070", Offset = "0x61B7070", VA = "0x1861B8070")]
			public TTerm LCFKNCIKGLH(TOutputSubstitution PODODCPOFNJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x61B7BE0", Offset = "0x61B6BE0", VA = "0x1861B7BE0")]
			public TOutputTerm JJOLEJDGLMC(TOutputSubstitution PODODCPOFNJ)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x61B67D0", Offset = "0x61B57D0", VA = "0x1861B67D0")]
			public TOutputTerm BNHMKCFAJKO(TTerm CGBEIKAMKGA)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class NJNLFGDKFIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public BDCLJGDNFDJ arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public NJNLFGDKFIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x53D2B10", Offset = "0x53D1B10", VA = "0x1853D2B10")]
			internal int MLIFGFIAELP(BDCLJGDNFDJ arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x53D29F0", Offset = "0x53D19F0", VA = "0x1853D29F0")]
			internal TInput CEEJKGDMNFF(BDCLJGDNFDJ arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x53D2AB0", Offset = "0x53D1AB0", VA = "0x1853D2AB0")]
			internal int JBOIDBNKNKE(BDCLJGDNFDJ arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x53D27B0", Offset = "0x53D17B0", VA = "0x1853D27B0")]
			internal TOutput AFMABOACHOM(BDCLJGDNFDJ arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FHLJIPMBJKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public BDCLJGDNFDJ arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, ACIGJEEGNFK<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<ACIGJEEGNFK<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, EDJNMCMNJBC<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public FHLJIPMBJKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x496A200", Offset = "0x4969200", VA = "0x18496A200")]
			internal (string, TTerm) NEGABGGIINF(FKLAGBNMNLI<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class ACPLEBJHGAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public BDCLJGDNFDJ arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, EDJNMCMNJBC<TType>>> idToType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IOKind ioKind;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public List<TTerm> terms;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IReadOnlyDictionary<string, TTerm> typeParameterToId;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public ACPLEBJHGAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4A22480", Offset = "0x4A21480", VA = "0x184A22480")]
			internal void PFNKJJBDDHG(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4A21C90", Offset = "0x4A20C90", VA = "0x184A21C90")]
			internal void LBPOLPMBBBI(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4A21A70", Offset = "0x4A20A70", VA = "0x184A21A70")]
			internal void FONBBFFKGOB(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4A22140", Offset = "0x4A21140", VA = "0x184A22140")]
			internal void LHIJOMJJCLJ(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class OHIHOLIJLLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public BDCLJGDNFDJ arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public OHIHOLIJLLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4AC7EA0", Offset = "0x4AC6EA0", VA = "0x184AC7EA0")]
			internal TTerm GCIHJLPNIBH(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x50F9450", Offset = "0x50F8450", VA = "0x1850F9450")]
		private static LOECJBACHMA NBMDBKABAKM([CallerMemberName] string NFHOBPDKIPM = "")
		{
			return default(LOECJBACHMA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x50EC3F0", Offset = "0x50EB3F0", VA = "0x1850EC3F0")]
		public static Dictionary<TNode, List<FKLAGBNMNLI<TType>>> KILDMCDHGDN(TRoot KNNDNAPJIDP, TDeps MMCKJCAOGBM, TGraph NOKCJFMDPME, IEnumerable<TNode> GDEABELPJHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x50FA400", Offset = "0x50F9400", VA = "0x1850FA400")]
		private static (Dictionary<TTerm, ACIGJEEGNFK<TNode>>, List<KeyValuePair<TTerm, EDJNMCMNJBC<TType>>>) PCDKIBLIBLO(IEnumerable<TNode> GDEABELPJHH, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
			return default((Dictionary<TTerm, ACIGJEEGNFK<TNode>>, List<KeyValuePair<TTerm, EDJNMCMNJBC<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x50EC9E0", Offset = "0x50EB9E0", VA = "0x1850EC9E0")]
		private static void KILFLGLPLKK(TNode GOJJJBGJPAM, Dictionary<TInput, TTerm> DHCIELPLLAD, Dictionary<TOutput, TTerm> AHHODGKJOAC, Dictionary<TTerm, ACIGJEEGNFK<TNode>> JHHMAEFADBG, Dictionary<ACIGJEEGNFK<TNode>, TTerm> PIJJOMAPHOD, List<KeyValuePair<TTerm, EDJNMCMNJBC<TType>>> OPBDIEKFCCB, Stack<TNode> PMHACNBJBOJ, List<ECPCPHEGAHA<TNode>> AOPKOKBLBBG, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x50F1E60", Offset = "0x50F0E60", VA = "0x1850F1E60")]
		private static Dictionary<string, TTerm> LICAOMKCHLG(TNode GOJJJBGJPAM, Dictionary<TTerm, ACIGJEEGNFK<TNode>> JHHMAEFADBG, Dictionary<ACIGJEEGNFK<TNode>, TTerm> FNGDDIHJMHK, List<KeyValuePair<TTerm, EDJNMCMNJBC<TType>>> OPBDIEKFCCB, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0640", Offset = "0x3CBF640", VA = "0x183CC0640")]
		private static (TPort, TTerm)[] HBONMLPDEFK<TPort>(TNode GOJJJBGJPAM, Func<BDCLJGDNFDJ, TNode, int> OOJBJHMFIEO, Func<BDCLJGDNFDJ, TNode, int, TPort> DMALCIMBAMO, Func<BDCLJGDNFDJ, TPort, TType> ADEMIFONKEM, Dictionary<TPort, TTerm> CCANGINMMCA, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x50F67D0", Offset = "0x50F57D0", VA = "0x1850F67D0")]
		private static (TTerm, TTerm) NBFIJMGINFL((TOutput Output, TTerm Id)[] JAPHJOLMCAH, List<KeyValuePair<TTerm, EDJNMCMNJBC<TType>>> OPBDIEKFCCB, Dictionary<string, TTerm> FNGDDIHJMHK, Stack<TNode> PMHACNBJBOJ, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x50EF150", Offset = "0x50EE150", VA = "0x1850EF150")]
		private static void KJDKDIGMDPE((TInput PortKey, TTerm Id)[] ODHLNAONGFG, TTerm NJKENGKIHNB, TTerm LLAJBHMJPPB, List<KeyValuePair<TTerm, EDJNMCMNJBC<TType>>> OPBDIEKFCCB, Dictionary<TOutput, TTerm> AHHODGKJOAC, Dictionary<string, TTerm> FNGDDIHJMHK, Stack<TNode> PMHACNBJBOJ, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x50E77F0", Offset = "0x50E67F0", VA = "0x1850E77F0")]
		private static TTerm DIINNFOPGKB(TInput HPLMFDGMJFE, List<KeyValuePair<TTerm, EDJNMCMNJBC<TType>>> OPBDIEKFCCB, Dictionary<TOutput, TTerm> AHHODGKJOAC, Stack<TNode> PMHACNBJBOJ, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x50F21B0", Offset = "0x50F11B0", VA = "0x1850F21B0")]
		private static TTerm MGAJOBFEABH([In] TType MLCOGCMJLBB, IOKind BAFEPPLCHEP, List<KeyValuePair<TTerm, EDJNMCMNJBC<TType>>> OPBDIEKFCCB, IReadOnlyDictionary<string, TTerm> FNGDDIHJMHK, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x50E7DA0", Offset = "0x50E6DA0", VA = "0x1850E7DA0")]
		private static Dictionary<TNode, List<FKLAGBNMNLI<TType>>> HBDKGMDJLAL(TOutputSubstitution[] LHAIGDFIBJD, Dictionary<TTerm, ACIGJEEGNFK<TNode>> JHHMAEFADBG, IEnumerable<KeyValuePair<TTerm, EDJNMCMNJBC<TType>>> OPBDIEKFCCB, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x50F5E30", Offset = "0x50F4E30", VA = "0x1850F5E30")]
		private static Dictionary<TNode, List<FKLAGBNMNLI<TType>>> MMFLFNBOPGI(Dictionary<TTerm, ACIGJEEGNFK<TNode>> JHHMAEFADBG, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x50FCC20", Offset = "0x50FBC20", VA = "0x1850FCC20")]
		private static void PEOEIBHCKNA([In] TNode GOJJJBGJPAM, Stack<TNode> PMHACNBJBOJ, List<ECPCPHEGAHA<TNode>> AOPKOKBLBBG, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x50F9EE0", Offset = "0x50F8EE0", VA = "0x1850F9EE0")]
		private static void NJFFNKFEFAO(Dictionary<ACIGJEEGNFK<TNode>, TTerm> FNGDDIHJMHK, List<ECPCPHEGAHA<TNode>> AOPKOKBLBBG, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x50F3860", Offset = "0x50F2860", VA = "0x1850F3860")]
		private static Dictionary<TTerm, TType> MHKAPNKAGAF(Dictionary<TTerm, TOutputSubstitution> LHAIGDFIBJD, IEnumerable<KeyValuePair<TTerm, EDJNMCMNJBC<TType>>> OPBDIEKFCCB, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x50EA460", Offset = "0x50E9460", VA = "0x1850EA460")]
		private static HHIMBEIEIME<TType> JDJFDJPFFCC(TOutputTerm MLCOGCMJLBB, Dictionary<TTerm, TType> OPBDIEKFCCB, Dictionary<TTerm, TType> FEHNEKGGBGC, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
			return default(HHIMBEIEIME<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x50E6610", Offset = "0x50E5610", VA = "0x1850E6610")]
		private static TOutputTerm BEPLIJKPLLE(TOutputTerm GMDONIOMHEM, BDCLJGDNFDJ GIOLPIPFPPJ)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3F66A60", Offset = "0x3F65A60", VA = "0x183F66A60")]
	public static Dictionary<TNode, List<FKLAGBNMNLI<TType>>> KILDMCDHGDN<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::IHHABGGEIDN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> OCACDKEJIIB, TRoot KNNDNAPJIDP, TGraph NOKCJFMDPME, IEnumerable<TNode> GDEABELPJHH) where TDeps : global::GDOJMPAIEGB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct FKLAGBNMNLI<TType> : IEquatable<FKLAGBNMNLI<TType>>, DAMNADAKDKD<FKLAGBNMNLI<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string IJKBIMCGCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType MMDLJNNEJLP;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4975B70", Offset = "0x4974B70", VA = "0x184975B70")]
	internal FKLAGBNMNLI(string NFHOBPDKIPM, [In] TType DHBOHDBBDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x49759B0", Offset = "0x49749B0", VA = "0x1849759B0")]
	public bool DJLLIPJENJL([In] FKLAGBNMNLI<TType> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4975A90", Offset = "0x4974A90", VA = "0x184975A90", Slot = "4")]
	public bool Equals(FKLAGBNMNLI<TType> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4973870", Offset = "0x4972870", VA = "0x184973870", Slot = "0")]
	public override bool Equals(object MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x28027D0", Offset = "0x28017D0", VA = "0x1828027D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4975B30", Offset = "0x4974B30", VA = "0x184975B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4975AE0", Offset = "0x4974AE0", VA = "0x184975AE0", Slot = "5")]
	private bool FKBJKBJDNMP([In] FKLAGBNMNLI<TType> MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HHLKAOEELPI
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x38687B0", Offset = "0x38677B0", VA = "0x1838687B0")]
	public static FKLAGBNMNLI<TType> ACADPGMDEBE<TType>(string NFHOBPDKIPM, TType DHBOHDBBDMO)
	{
		return default(FKLAGBNMNLI<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x38687E0", Offset = "0x38677E0", VA = "0x1838687E0")]
	public static (string, TType) OLNMFLOGPBC<TType>([In] this FKLAGBNMNLI<TType> OCACDKEJIIB)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct ACIGJEEGNFK<TNode> : IEquatable<ACIGJEEGNFK<TNode>>, DAMNADAKDKD<ACIGJEEGNFK<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode KFNFIFHNECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string IJKBIMCGCEM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x162A720", Offset = "0x1629720", VA = "0x18162A720")]
	internal ACIGJEEGNFK(TNode GOJJJBGJPAM, string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4A20390", Offset = "0x4A1F390", VA = "0x184A20390")]
	public bool DJLLIPJENJL([In] ACIGJEEGNFK<TNode> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4A205A0", Offset = "0x4A1F5A0", VA = "0x184A205A0", Slot = "4")]
	public bool Equals(ACIGJEEGNFK<TNode> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4973870", Offset = "0x4972870", VA = "0x184973870", Slot = "0")]
	public override bool Equals(object MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4A205F0", Offset = "0x4A1F5F0", VA = "0x184A205F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4A20740", Offset = "0x4A1F740", VA = "0x184A20740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4A206B0", Offset = "0x4A1F6B0", VA = "0x184A206B0", Slot = "5")]
	private bool NOMGFOOOBFP([In] ACIGJEEGNFK<TNode> MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DPGJOGHIBFP
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x36B4350", Offset = "0x36B3350", VA = "0x1836B4350")]
	public static ACIGJEEGNFK<TNode> ACADPGMDEBE<TNode>(TNode GOJJJBGJPAM, string NFHOBPDKIPM)
	{
		return default(ACIGJEEGNFK<TNode>);
	}
}
namespace Cpp2IlInjected;

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

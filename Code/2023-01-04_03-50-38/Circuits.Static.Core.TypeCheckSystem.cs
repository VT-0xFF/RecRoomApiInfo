using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Utilities;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct HLCNADPBOKM<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType AKDIGOBFKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind PBLJAIAOBBC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7775B0", Offset = "0x7769B0", VA = "0x1807775B0")]
	internal HLCNADPBOKM(TType FPPBLNEEHBP, IOKind LKFGBKGPJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A4ADA0", Offset = "0x2A4A1A0", VA = "0x182A4ADA0")]
	public void ADGEHKFIFPI(out TType FPPBLNEEHBP, out IOKind LKFGBKGPJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A4ADD0", Offset = "0x2A4A1D0", VA = "0x182A4ADD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AKCFNMMOLIA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x15D7280", Offset = "0x15D6680", VA = "0x1815D7280")]
	public static global::HLCNADPBOKM<TType> IKMCJIAOBME<TType>(TType FPPBLNEEHBP, IOKind LKFGBKGPJGF)
	{
		return default(global::HLCNADPBOKM<TType>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct PBGJLCLMCMM<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly global::BBMOOEEBPAH<TNode> CLNHOKEGMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly global::BBMOOEEBPAH<TNode> JMCDAEIOADM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37542B0", Offset = "0x37536B0", VA = "0x1837542B0")]
	public void ADGEHKFIFPI(out global::BBMOOEEBPAH<TNode> HOHNFHDFLIK, out global::BBMOOEEBPAH<TNode> IBLJPHDNENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x37542F0", Offset = "0x37536F0", VA = "0x1837542F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DFGAODFOFKK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KELKMONMHFI OONJLCKIPOJ(TRoot NMIIAOIKHMI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType LFFIOIBCNLI(TRoot NMIIAOIKHMI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::HLCNADPBOKM<TType> IEPFNNOFKCF(TRoot NMIIAOIKHMI, in global::HLCNADPBOKM<TType> LBABLKMFGKM, in global::HLCNADPBOKM<TType> MGCAIGBBIIM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HPNCDPMFCPO(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TNode EJMIEPKLJDN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KMNFEHAKHIC(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TNode EJMIEPKLJDN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput BBJDGBODBOF(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TNode EJMIEPKLJDN, int HMJKJGLHFKE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NKKPAIHKPFB(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TNode EJMIEPKLJDN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput FJHEGLCEIEN(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TNode EJMIEPKLJDN, int HMJKJGLHFKE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<global::AOIHICMGIHB<TType>> DEDCHGMDMHP(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TNode EJMIEPKLJDN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<global::PBGJLCLMCMM<TNode>> KDHDJHPJEJC(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TNode EJMIEPKLJDN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType NHPELNIOPEI(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TInput PHGHFOGNNLI);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int EBPNJMHFINI(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TInput PHGHFOGNNLI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput MAHLLHHEFIH(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TInput PHGHFOGNNLI, int HMJKJGLHFKE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode GNHOJMMNBNI(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TInput PHGHFOGNNLI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType FPCGBIMJOEK(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TOutput FCKALLNNNCF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int DHIINAALGEJ(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TOutput FCKALLNNNCF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput FJHOEIPDKHI(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TOutput FCKALLNNNCF, int HMJKJGLHFKE);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode FDIOIKDAHGL(TRoot NMIIAOIKHMI, TGraph AEIPELDEEKO, TOutput FCKALLNNNCF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool JOMJNEBBAJG(TRoot NMIIAOIKHMI, TType FPPBLNEEHBP);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType BIAEKKFJLJJ(TRoot NMIIAOIKHMI, TType FPPBLNEEHBP, IEnumerable<TType> IAMDLKMDIBC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BNGEOBJPKPH(TRoot NMIIAOIKHMI, TType FPPBLNEEHBP, Action<TType> KFILHNLLJGG, Action<TType> JNOBDLCBEOB, Action<TType> PDLPOGFNKLN, Action<TType> IFAJNGCBGJL);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType JFOKFJGPHFP(TRoot NMIIAOIKHMI, TType FPPBLNEEHBP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string EPIFCLEOLCD(TRoot NMIIAOIKHMI, TType FPPBLNEEHBP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification FHBHOAGCMLF(TRoot NMIIAOIKHMI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	global::BFOGDGGAJLJ<TOutputSubstitution[], DJBJKBPDGID> ENFGJJJOILO(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm FHKCOEMONHO(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm NLKBLIMAOKG(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL, TTerm LMFIGFEEKCJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm OCBACGNBJBN(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL, TTerm JOEHIOLFBGJ, TTerm IJAPHJMEHJM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NFMJLMJAALM(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL, TTerm LBABLKMFGKM, TTerm MGCAIGBBIIM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool NFAHFIJCMNM(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL, TOutputTerm APNLHALKFOA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool APEEBKEFCCG(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL, TOutputTerm APNLHALKFOA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm NBAMLHHAFNP(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL, TOutputTerm APNLHALKFOA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm FANFIDLOACH(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL, TOutputTerm APNLHALKFOA);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm DNOCKJHMKHI(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL, TOutputTerm APNLHALKFOA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm AFBIACCCIIC(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL, TOutputSubstitution MAMHJIEEDPD);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm BGKOMODCHDM(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL, TOutputSubstitution MAMHJIEEDPD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm GIECIEBDCJL(TRoot NMIIAOIKHMI, TUnification KPGGDBOFKAL, TTerm LMFIGFEEKCJ);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct IADNJLCLFBH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::DFGAODFOFKK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00")]
	public static global::IADNJLCLFBH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> IKMCJIAOBME()
	{
		return default(global::IADNJLCLFBH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PMLPNMFIKFI
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private static class CKNPCKMMBBC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::DFGAODFOFKK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private sealed class NEKLIMDAKIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot OGEOEBLKHMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps NIMBBNBIFOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification FOKGHPKMFFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph JAILOADFPDN;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public KELKMONMHFI INKGIONNEFK
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x342B610", Offset = "0x342AA10", VA = "0x18342B610")]
				get
				{
					return default(KELKMONMHFI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x342BC30", Offset = "0x342B030", VA = "0x18342BC30")]
			private NEKLIMDAKIK(TRoot NMIIAOIKHMI, TDeps MHCCDFMDJCL, TUnification DOLBDOHBLFD, TGraph AEIPELDEEKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x342B0B0", Offset = "0x342A4B0", VA = "0x18342B0B0")]
			public static NEKLIMDAKIK IKMCJIAOBME(TRoot NMIIAOIKHMI, TDeps MHCCDFMDJCL, TUnification DOLBDOHBLFD, TGraph AEIPELDEEKO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x342B480", Offset = "0x342A880", VA = "0x18342B480")]
			public TType LFFIOIBCNLI()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x342AF70", Offset = "0x342A370", VA = "0x18342AF70")]
			public global::HLCNADPBOKM<TType> IEPFNNOFKCF(global::HLCNADPBOKM<TType> LBABLKMFGKM, global::HLCNADPBOKM<TType> MGCAIGBBIIM)
			{
				return default(global::HLCNADPBOKM<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x342ACD0", Offset = "0x342A0D0", VA = "0x18342ACD0")]
			public int HPNCDPMFCPO(TNode EJMIEPKLJDN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x342B450", Offset = "0x342A850", VA = "0x18342B450")]
			public int KMNFEHAKHIC(TNode EJMIEPKLJDN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3429EC0", Offset = "0x34292C0", VA = "0x183429EC0")]
			public TInput BBJDGBODBOF(TNode EJMIEPKLJDN, int HMJKJGLHFKE)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x342B980", Offset = "0x342AD80", VA = "0x18342B980")]
			public int NKKPAIHKPFB(TNode EJMIEPKLJDN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x342A820", Offset = "0x3429C20", VA = "0x18342A820")]
			public TOutput FJHEGLCEIEN(TNode EJMIEPKLJDN, int HMJKJGLHFKE)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x342A290", Offset = "0x3429690", VA = "0x18342A290")]
			public IEnumerable<global::AOIHICMGIHB<TType>> DEDCHGMDMHP(TNode EJMIEPKLJDN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x342B300", Offset = "0x342A700", VA = "0x18342B300")]
			public IEnumerable<global::PBGJLCLMCMM<TNode>> KDHDJHPJEJC(in TNode EJMIEPKLJDN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x342AA80", Offset = "0x3429E80", VA = "0x18342AA80")]
			public TType NHPELNIOPEI(TInput PHGHFOGNNLI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x342A4A0", Offset = "0x34298A0", VA = "0x18342A4A0")]
			public int DOKAHFOOACB(TInput PHGHFOGNNLI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x342B520", Offset = "0x342A920", VA = "0x18342B520")]
			public TOutput MAHLLHHEFIH(TInput PHGHFOGNNLI, int HMJKJGLHFKE)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x342A730", Offset = "0x3429B30", VA = "0x18342A730")]
			public TNode GNHOJMMNBNI(TInput PHGHFOGNNLI)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x342AA80", Offset = "0x3429E80", VA = "0x18342AA80")]
			public TType FPCGBIMJOEK(TOutput FCKALLNNNCF)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x342AD90", Offset = "0x342A190", VA = "0x18342AD90")]
			public int IDAOKKHPKIL(TOutput FCKALLNNNCF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x342A900", Offset = "0x3429D00", VA = "0x18342A900")]
			public TInput FJHOEIPDKHI(TOutput FCKALLNNNCF, int HMJKJGLHFKE)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x342A730", Offset = "0x3429B30", VA = "0x18342A730")]
			public TNode FDIOIKDAHGL(TOutput FCKALLNNNCF)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x342B2D0", Offset = "0x342A6D0", VA = "0x18342B2D0")]
			public bool JOMJNEBBAJG(TType FPPBLNEEHBP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x342A060", Offset = "0x3429460", VA = "0x18342A060")]
			public TType BIAEKKFJLJJ(TType FPPBLNEEHBP, IEnumerable<TType> IAMDLKMDIBC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x342A120", Offset = "0x3429520", VA = "0x18342A120")]
			public void BNGEOBJPKPH(TType FPPBLNEEHBP, Action<TType> KFILHNLLJGG, Action<TType> JNOBDLCBEOB, Action<TType> PDLPOGFNKLN, Action<TType> IFAJNGCBGJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x342B1A0", Offset = "0x342A5A0", VA = "0x18342B1A0")]
			public TType JFOKFJGPHFP(TType FPPBLNEEHBP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x342A4E0", Offset = "0x34298E0", VA = "0x18342A4E0")]
			public string EPIFCLEOLCD(TType FPPBLNEEHBP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x342A7F0", Offset = "0x3429BF0", VA = "0x18342A7F0")]
			public TTerm FHKCOEMONHO()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x342BAD0", Offset = "0x342AED0", VA = "0x18342BAD0")]
			public TTerm NLKBLIMAOKG(TTerm LMFIGFEEKCJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x342BBF0", Offset = "0x342AFF0", VA = "0x18342BBF0")]
			public TTerm OCBACGNBJBN(TTerm JOEHIOLFBGJ, TTerm IJAPHJMEHJM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x342B7C0", Offset = "0x342ABC0", VA = "0x18342B7C0")]
			public void NFMJLMJAALM(TTerm LBABLKMFGKM, TTerm MGCAIGBBIIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3429E00", Offset = "0x3429200", VA = "0x183429E00")]
			public bool APEEBKEFCCG(TOutputTerm LMFIGFEEKCJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x342B790", Offset = "0x342AB90", VA = "0x18342B790")]
			public bool NFAHFIJCMNM(TOutputTerm LMFIGFEEKCJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x342AC10", Offset = "0x342A010", VA = "0x18342AC10")]
			public TTerm HCINNBLAFBG(TOutputTerm APNLHALKFOA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x342A5E0", Offset = "0x34299E0", VA = "0x18342A5E0")]
			public TOutputTerm FANFIDLOACH(TOutputTerm LMFIGFEEKCJ)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x342A350", Offset = "0x3429750", VA = "0x18342A350")]
			public TOutputTerm DNOCKJHMKHI(TOutputTerm LMFIGFEEKCJ)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3429DD0", Offset = "0x34291D0", VA = "0x183429DD0")]
			public TTerm AFBIACCCIIC(TOutputSubstitution DAHIPNOGAKO)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x342A030", Offset = "0x3429430", VA = "0x18342A030")]
			public TOutputTerm BGKOMODCHDM(TOutputSubstitution DAHIPNOGAKO)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x342AAC0", Offset = "0x3429EC0", VA = "0x18342AAC0")]
			public TOutputTerm GIECIEBDCJL(TTerm LMFIGFEEKCJ)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class CGEKFMBNEDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public NEKLIMDAKIK arg;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
			public CGEKFMBNEDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3098F90", Offset = "0x3098390", VA = "0x183098F90")]
			internal int <GenerateConstraintsForNode>b__0(NEKLIMDAKIK arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x3A73730", Offset = "0x3A72B30", VA = "0x183A73730")]
			internal TInput <GenerateConstraintsForNode>b__1(NEKLIMDAKIK arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3A737D0", Offset = "0x3A72BD0", VA = "0x183A737D0")]
			internal int <GenerateConstraintsForNode>b__3(NEKLIMDAKIK arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3A73810", Offset = "0x3A72C10", VA = "0x183A73810")]
			internal TOutput <GenerateConstraintsForNode>b__4(NEKLIMDAKIK arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class NJAIKNGOJGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public NEKLIMDAKIK arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, global::BBMOOEEBPAH<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<global::BBMOOEEBPAH<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, global::HLCNADPBOKM<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
			public NJAIKNGOJGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x39C37C0", Offset = "0x39C2BC0", VA = "0x1839C37C0")]
			internal (string, TTerm) <IdentifyTypeParameters>b__0(global::AOIHICMGIHB<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IOBHANPOBGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public NEKLIMDAKIK arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, global::HLCNADPBOKM<TType>>> idToType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IOKind ioKind;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public List<TTerm> terms;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IReadOnlyDictionary<string, TTerm> typeParameterToId;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
			public IOBHANPOBGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1F01F70", Offset = "0x1F01370", VA = "0x181F01F70")]
			internal void <GetTypeUnificationTerm>b__0(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1F02300", Offset = "0x1F01700", VA = "0x181F02300")]
			internal void <GetTypeUnificationTerm>b__1(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x1F02630", Offset = "0x1F01A30", VA = "0x181F02630")]
			internal void <GetTypeUnificationTerm>b__2(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1F02880", Offset = "0x1F01C80", VA = "0x181F02880")]
			internal void <GetTypeUnificationTerm>b__3(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CCJPIABCJFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public NEKLIMDAKIK arg;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
			public CCJPIABCJFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x1D51D50", Offset = "0x1D51150", VA = "0x181D51D50")]
			internal TTerm <GetTypeParameterAssignments>b__1(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x276D330", Offset = "0x276C730", VA = "0x18276D330")]
		private static GALJLEKAIAJ AJKAFGOPFIK([CallerMemberName] string DHKKANIEGMN = "")
		{
			return default(GALJLEKAIAJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x276F3B0", Offset = "0x276E7B0", VA = "0x18276F3B0")]
		public static Dictionary<TNode, List<global::AOIHICMGIHB<TType>>> BHJPLNDOBGI(TRoot NMIIAOIKHMI, TDeps MHCCDFMDJCL, TGraph AEIPELDEEKO, IEnumerable<TNode> OFFALFCPBEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2771770", Offset = "0x2770B70", VA = "0x182771770")]
		private static (Dictionary<TTerm, global::BBMOOEEBPAH<TNode>>, List<KeyValuePair<TTerm, global::HLCNADPBOKM<TType>>>) EINDAPCBLJM(IEnumerable<TNode> OFFALFCPBEN, NEKLIMDAKIK NJOHOALIBEB)
		{
			return default((Dictionary<TTerm, global::BBMOOEEBPAH<TNode>>, List<KeyValuePair<TTerm, global::HLCNADPBOKM<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x276C600", Offset = "0x276BA00", VA = "0x18276C600")]
		private static void AGLPPEAKDPN(TNode EJMIEPKLJDN, Dictionary<TInput, TTerm> FMHLCCIANIL, Dictionary<TOutput, TTerm> PCGBIAILHBB, Dictionary<TTerm, global::BBMOOEEBPAH<TNode>> LEHLAJEMCGI, Dictionary<global::BBMOOEEBPAH<TNode>, TTerm> ALMJOGKONHE, List<KeyValuePair<TTerm, global::HLCNADPBOKM<TType>>> GOPHGFOOAOG, Stack<TNode> CDHGKDAIHPJ, List<global::PBGJLCLMCMM<TNode>> AHPALDPDPPE, NEKLIMDAKIK NJOHOALIBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2777D20", Offset = "0x2777120", VA = "0x182777D20")]
		private static Dictionary<string, TTerm> KIFIIEMOJAA(TNode EJMIEPKLJDN, Dictionary<TTerm, global::BBMOOEEBPAH<TNode>> LEHLAJEMCGI, Dictionary<global::BBMOOEEBPAH<TNode>, TTerm> HIIKLENPEBF, List<KeyValuePair<TTerm, global::HLCNADPBOKM<TType>>> GOPHGFOOAOG, NEKLIMDAKIK NJOHOALIBEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x23CED80", Offset = "0x23CE180", VA = "0x1823CED80")]
		private static (TPort, TTerm)[] EFJAPHHIKOO<TPort>(TNode EJMIEPKLJDN, Func<NEKLIMDAKIK, TNode, int> NEILBIMCNMP, Func<NEKLIMDAKIK, TNode, int, TPort> LDICCEMACAF, Func<NEKLIMDAKIK, TPort, TType> FBOPEJNDLKH, Dictionary<TPort, TTerm> HOOANNFINDF, NEKLIMDAKIK NJOHOALIBEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x276D3B0", Offset = "0x276C7B0", VA = "0x18276D3B0")]
		private static (TTerm, TTerm) BAHPJBAOHCP((TOutput Output, TTerm Id)[] FOGMLGBNDHM, List<KeyValuePair<TTerm, global::HLCNADPBOKM<TType>>> GOPHGFOOAOG, Dictionary<string, TTerm> HIIKLENPEBF, Stack<TNode> CDHGKDAIHPJ, NEKLIMDAKIK NJOHOALIBEB)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x276FEC0", Offset = "0x276F2C0", VA = "0x18276FEC0")]
		private static void EFKBEAIBEMN((TInput PortKey, TTerm Id)[] HMNFHEDJJHK, TTerm LLOMCJALACO, TTerm MLNCGOINDCN, List<KeyValuePair<TTerm, global::HLCNADPBOKM<TType>>> GOPHGFOOAOG, Dictionary<TOutput, TTerm> PCGBIAILHBB, Dictionary<string, TTerm> HIIKLENPEBF, Stack<TNode> CDHGKDAIHPJ, NEKLIMDAKIK NJOHOALIBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2776330", Offset = "0x2775730", VA = "0x182776330")]
		private static TTerm FPIIHBCAENP(TInput PHGHFOGNNLI, List<KeyValuePair<TTerm, global::HLCNADPBOKM<TType>>> GOPHGFOOAOG, Dictionary<TOutput, TTerm> PCGBIAILHBB, Stack<TNode> CDHGKDAIHPJ, NEKLIMDAKIK NJOHOALIBEB)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x276F920", Offset = "0x276ED20", VA = "0x18276F920")]
		private static TTerm DFFGCAAPEBE(in TType FPPBLNEEHBP, IOKind LKFGBKGPJGF, List<KeyValuePair<TTerm, global::HLCNADPBOKM<TType>>> GOPHGFOOAOG, IReadOnlyDictionary<string, TTerm> HIIKLENPEBF, NEKLIMDAKIK NJOHOALIBEB)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2778BA0", Offset = "0x2777FA0", VA = "0x182778BA0")]
		private static Dictionary<TNode, List<global::AOIHICMGIHB<TType>>> POPFBFFHFGF(TOutputSubstitution[] POEHFIJOHLG, Dictionary<TTerm, global::BBMOOEEBPAH<TNode>> LEHLAJEMCGI, IEnumerable<KeyValuePair<TTerm, global::HLCNADPBOKM<TType>>> GOPHGFOOAOG, NEKLIMDAKIK NJOHOALIBEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2776C90", Offset = "0x2776090", VA = "0x182776C90")]
		private static Dictionary<TNode, List<global::AOIHICMGIHB<TType>>> GGCMOBMEFGJ(Dictionary<TTerm, global::BBMOOEEBPAH<TNode>> LEHLAJEMCGI, NEKLIMDAKIK NJOHOALIBEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x276B130", Offset = "0x276A530", VA = "0x18276B130")]
		private static void AADLOGGOHHN(in TNode EJMIEPKLJDN, Stack<TNode> CDHGKDAIHPJ, List<global::PBGJLCLMCMM<TNode>> AHPALDPDPPE, NEKLIMDAKIK NJOHOALIBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x27770A0", Offset = "0x27764A0", VA = "0x1827770A0")]
		private static void JAOGJKGEMPA(Dictionary<global::BBMOOEEBPAH<TNode>, TTerm> HIIKLENPEBF, List<global::PBGJLCLMCMM<TNode>> AHPALDPDPPE, NEKLIMDAKIK NJOHOALIBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2774E90", Offset = "0x2774290", VA = "0x182774E90")]
		private static Dictionary<TTerm, TType> FDFDEPFEADN(Dictionary<TTerm, TOutputSubstitution> POEHFIJOHLG, IEnumerable<KeyValuePair<TTerm, global::HLCNADPBOKM<TType>>> GOPHGFOOAOG, NEKLIMDAKIK NJOHOALIBEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2772D30", Offset = "0x2772130", VA = "0x182772D30")]
		private static global::CANFHBMAPOB<TType> EKEJIIJGBHP(TOutputTerm FPPBLNEEHBP, Dictionary<TTerm, TType> GOPHGFOOAOG, Dictionary<TTerm, TType> GJFJIDJNDMK, NEKLIMDAKIK NJOHOALIBEB)
		{
			return default(global::CANFHBMAPOB<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2777C60", Offset = "0x2777060", VA = "0x182777C60")]
		private static TOutputTerm JDBGAJKBLJM(TOutputTerm CEDMNGBNJPL, NEKLIMDAKIK NJOHOALIBEB)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4062B20", Offset = "0x4061F20", VA = "0x184062B20")]
	public static Dictionary<TNode, List<global::AOIHICMGIHB<TType>>> BHJPLNDOBGI<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>(in global::IADNJLCLFBH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> LKINCHDLDIG, TRoot NMIIAOIKHMI, TDeps MHCCDFMDJCL, TGraph AEIPELDEEKO, IEnumerable<TNode> OFFALFCPBEN) where TDeps : global::DFGAODFOFKK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct AOIHICMGIHB<TType> : IEquatable<global::AOIHICMGIHB<TType>>, global::ABCEMJGLGHA<global::AOIHICMGIHB<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string GAELEJJHLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType LMMJCIKCFJL;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x29C9220", Offset = "0x29C8620", VA = "0x1829C9220")]
	internal AOIHICMGIHB(string DHKKANIEGMN, in TType ICOECEHFOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x31055A0", Offset = "0x31049A0", VA = "0x1831055A0")]
	public bool OPIKPALMMII(in global::AOIHICMGIHB<TType> EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3105490", Offset = "0x3104890", VA = "0x183105490", Slot = "4")]
	public bool Equals(global::AOIHICMGIHB<TType> EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3105400", Offset = "0x3104800", VA = "0x183105400", Slot = "0")]
	public override bool Equals(object EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x726990", Offset = "0x725D90", VA = "0x180726990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3105680", Offset = "0x3104A80", VA = "0x183105680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x31054E0", Offset = "0x31048E0", VA = "0x1831054E0")]
	public (string, TType) JAFDFCCEOHK()
	{
		return default((string, TType));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3105550", Offset = "0x3104950", VA = "0x183105550", Slot = "5")]
	private bool KEEKHGPNDAG(in global::AOIHICMGIHB<TType> EPJIAIAEMFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IFLEPFIBOJI
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F680", Offset = "0x1F7EA80", VA = "0x181F7F680")]
	public static global::AOIHICMGIHB<TType> IKMCJIAOBME<TType>(string DHKKANIEGMN, TType ICOECEHFOLL)
	{
		return default(global::AOIHICMGIHB<TType>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct BBMOOEEBPAH<TNode> : IEquatable<global::BBMOOEEBPAH<TNode>>, global::ABCEMJGLGHA<global::BBMOOEEBPAH<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode BFJCCHHFLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string GAELEJJHLDP;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x728A10", Offset = "0x727E10", VA = "0x180728A10")]
	internal BBMOOEEBPAH(TNode EJMIEPKLJDN, string DHKKANIEGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0DC0", Offset = "0x3CE01C0", VA = "0x183CE0DC0")]
	public bool OPIKPALMMII(in global::BBMOOEEBPAH<TNode> EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0D20", Offset = "0x3CE0120", VA = "0x183CE0D20", Slot = "4")]
	public bool Equals(global::BBMOOEEBPAH<TNode> EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3105400", Offset = "0x3104800", VA = "0x183105400", Slot = "0")]
	public override bool Equals(object EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x726990", Offset = "0x725D90", VA = "0x180726990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0EA0", Offset = "0x3CE02A0", VA = "0x183CE0EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0D70", Offset = "0x3CE0170", VA = "0x183CE0D70", Slot = "5")]
	private bool KJJFDHGOGOM(in global::BBMOOEEBPAH<TNode> EPJIAIAEMFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OLKMMNMAHPP
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEB80", Offset = "0x1FBDF80", VA = "0x181FBEB80")]
	public static global::BBMOOEEBPAH<TNode> IKMCJIAOBME<TNode>(TNode EJMIEPKLJDN, string DHKKANIEGMN)
	{
		return default(global::BBMOOEEBPAH<TNode>);
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

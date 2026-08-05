using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct BMOAMJOGDAN<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType DLLABFENMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind KIGCMFCAAHH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x93D320", Offset = "0x93BD20", VA = "0x18093D320")]
	internal BMOAMJOGDAN(TType BKKHBFLPOHJ, IOKind IBIIPLNONKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x529ECA0", Offset = "0x529D6A0", VA = "0x18529ECA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CPEFGNBHFOE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2310", Offset = "0x2CF0D10", VA = "0x182CF2310")]
	public static BMOAMJOGDAN<TType> AELHPDENENI<TType>(TType BKKHBFLPOHJ, IOKind IBIIPLNONKN)
	{
		return default(BMOAMJOGDAN<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2CF23B0", Offset = "0x2CF0DB0", VA = "0x182CF23B0")]
	public static (TType, IOKind) NJHGPHLJDBE<TType>([In] this BMOAMJOGDAN<TType> PCBICLOONMH)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2340", Offset = "0x2CF0D40", VA = "0x182CF2340")]
	public static void KGDOKCMJMKM<TType>([In] this BMOAMJOGDAN<TType> PCBICLOONMH, [Out] TType BKKHBFLPOHJ, [Out] IOKind IBIIPLNONKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct DGHNMHNHJFG<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly OEOGEDBHJIJ<TNode> KNHOICOKCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly OEOGEDBHJIJ<TNode> EODFNBDELOB;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5C83ED0", Offset = "0x5C828D0", VA = "0x185C83ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MAJJGJKHPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2FD5990", Offset = "0x2FD4390", VA = "0x182FD5990")]
	public static (OEOGEDBHJIJ<TNode>, OEOGEDBHJIJ<TNode>) NJHGPHLJDBE<TNode>([In] this DGHNMHNHJFG<TNode> PCBICLOONMH)
	{
		return default((OEOGEDBHJIJ<TNode>, OEOGEDBHJIJ<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2FD5890", Offset = "0x2FD4290", VA = "0x182FD5890")]
	public static void KGDOKCMJMKM<TNode>([In] this DGHNMHNHJFG<TNode> PCBICLOONMH, [Out] OEOGEDBHJIJ<TNode> FCKNABCAAPB, [Out] OEOGEDBHJIJ<TNode> JGIIKLPFBFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PNAGJPMDMAD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKEIJILMEEL GBPBCEFGAKE(TRoot ELFANOAFHKM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType DMCMIFIIDOH(TRoot ELFANOAFHKM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BMOAMJOGDAN<TType> HJMBIDGEDKO(TRoot ELFANOAFHKM, [In] BMOAMJOGDAN<TType> GPBGMCKGICE, [In] BMOAMJOGDAN<TType> PGFJAECCPCN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BGCKAGFBFEG(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TNode OFGAFPGJIKO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AGIDICEOMJB(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TNode OFGAFPGJIKO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput LPJENILEHGG(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TNode OFGAFPGJIKO, int GCBONJOGHCD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HOEMCFFACON(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TNode OFGAFPGJIKO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput FGNFLAGJECN(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TNode OFGAFPGJIKO, int GCBONJOGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<DCEMBPFEKIN<TType>> DJENNPLHJNH(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TNode OFGAFPGJIKO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<DGHNMHNHJFG<TNode>> OLMDFADLHME(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TNode OFGAFPGJIKO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType NKFIJGDLLJH(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TInput CPOLINJHFNA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int GBBJPIIKOFJ(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TInput CPOLINJHFNA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput KFCCGPJADAF(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TInput CPOLINJHFNA, int GCBONJOGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode PECFCBNBHDC(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TInput CPOLINJHFNA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType KHILFDLGPKI(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TOutput JFBDPBFFKPN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int MCLDNHCJFHE(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TOutput JFBDPBFFKPN);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput GFBMFJOCMFC(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TOutput JFBDPBFFKPN, int GCBONJOGHCD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode OKGHGBPCIJN(TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, TOutput JFBDPBFFKPN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HHGPJLECLON(TRoot ELFANOAFHKM, TType BKKHBFLPOHJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType HPKCJEFIEOF(TRoot ELFANOAFHKM, TType BKKHBFLPOHJ, IEnumerable<TType> IGLOMEKEODJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NNGDJMAFIDC(TRoot ELFANOAFHKM, TType BKKHBFLPOHJ, Action<TType> FEBJBIKCAIG, Action<TType> IMGNJKKHMNN, Action<TType> PIPMJIJBCHO, Action<TType> IFPICNFNJBN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType GPMCIEFHPBN(TRoot ELFANOAFHKM, TType BKKHBFLPOHJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string BBKKKAJFLLK(TRoot ELFANOAFHKM, TType BKKHBFLPOHJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification NNBKPHCMAHE(TRoot ELFANOAFHKM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	OKPKCEBGDLD<TOutputSubstitution[], JMDMKJMGBCA> FLLFLNGNECP(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm OMLFAGGGCOJ(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm JOFOOIDCJHD(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP, TTerm LJEHOJLCJND);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm BEMDFFNONFP(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP, TTerm LFAPGGMCBIK, TTerm DIJABOFBAKO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IKDEEMLPPNN(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP, TTerm GPBGMCKGICE, TTerm PGFJAECCPCN);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool CBBPEKOPKGO(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP, TOutputTerm FFNOFEKDNGF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool GFEJHDIPNEJ(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP, TOutputTerm FFNOFEKDNGF);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm MANEFEDFGOF(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP, TOutputTerm FFNOFEKDNGF);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm NLEEEMAJPKH(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP, TOutputTerm FFNOFEKDNGF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm GCJMBKKCCLO(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP, TOutputTerm FFNOFEKDNGF);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm PGGMEEKNABG(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP, TOutputSubstitution BCCJFFHHDLD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm PCLBLIELGJK(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP, TOutputSubstitution BCCJFFHHDLD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm LKJOEOJLIFH(TRoot ELFANOAFHKM, TUnification ACAOFAMLDIP, TTerm LJEHOJLCJND);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PPBLAEGBBCL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::PNAGJPMDMAD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0")]
	public static global::PPBLAEGBBCL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> AELHPDENENI()
	{
		return default(global::PPBLAEGBBCL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EHMJMIFAKGI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class FDLGMGBPIDP<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::PNAGJPMDMAD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class NFEAOPKJJIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot BPFDMKBMANG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps NEHPFNJEPBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification ANEILAOFOEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph DBKNLGEBFJB;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public AKEIJILMEEL CEGDPJJMNPB
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x493C820", Offset = "0x493B220", VA = "0x18493C820")]
				get
				{
					return default(AKEIJILMEEL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x493EAF0", Offset = "0x493D4F0", VA = "0x18493EAF0")]
			private NFEAOPKJJIG(TRoot ELFANOAFHKM, TDeps JOIGIEDFOGO, TUnification AMPPDFOPGJB, TGraph ADJABNNJNMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x493BFF0", Offset = "0x493A9F0", VA = "0x18493BFF0")]
			public static NFEAOPKJJIG AELHPDENENI(TRoot ELFANOAFHKM, TDeps JOIGIEDFOGO, TUnification AMPPDFOPGJB, TGraph ADJABNNJNMI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x493CA60", Offset = "0x493B460", VA = "0x18493CA60")]
			public TType DMCMIFIIDOH()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x493D2C0", Offset = "0x493BCC0", VA = "0x18493D2C0")]
			public BMOAMJOGDAN<TType> HJMBIDGEDKO(BMOAMJOGDAN<TType> GPBGMCKGICE, BMOAMJOGDAN<TType> PGFJAECCPCN)
			{
				return default(BMOAMJOGDAN<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x493C680", Offset = "0x493B080", VA = "0x18493C680")]
			public int BGCKAGFBFEG(TNode OFGAFPGJIKO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x493C2D0", Offset = "0x493ACD0", VA = "0x18493C2D0")]
			public int AGIDICEOMJB(TNode OFGAFPGJIKO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x493DF90", Offset = "0x493C990", VA = "0x18493DF90")]
			public TInput LPJENILEHGG(TNode OFGAFPGJIKO, int GCBONJOGHCD)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x493D490", Offset = "0x493BE90", VA = "0x18493D490")]
			public int HOEMCFFACON(TNode OFGAFPGJIKO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x493CC20", Offset = "0x493B620", VA = "0x18493CC20")]
			public TOutput FGNFLAGJECN(TNode OFGAFPGJIKO, int GCBONJOGHCD)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x493C9A0", Offset = "0x493B3A0", VA = "0x18493C9A0")]
			public IEnumerable<DCEMBPFEKIN<TType>> DJENNPLHJNH(TNode OFGAFPGJIKO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x493E700", Offset = "0x493D100", VA = "0x18493E700")]
			public IEnumerable<DGHNMHNHJFG<TNode>> OLMDFADLHME([In] TNode OFGAFPGJIKO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x493E170", Offset = "0x493CB70", VA = "0x18493E170")]
			public TType NKFIJGDLLJH(TInput CPOLINJHFNA)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x493DCC0", Offset = "0x493C6C0", VA = "0x18493DCC0")]
			public int LKAEILMDEEH(TInput CPOLINJHFNA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x493DA30", Offset = "0x493C430", VA = "0x18493DA30")]
			public TOutput KFCCGPJADAF(TInput CPOLINJHFNA, int GCBONJOGHCD)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x493E900", Offset = "0x493D300", VA = "0x18493E900")]
			public TNode PECFCBNBHDC(TInput CPOLINJHFNA)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x493DC70", Offset = "0x493C670", VA = "0x18493DC70")]
			public TType KHILFDLGPKI(TOutput JFBDPBFFKPN)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x493E0A0", Offset = "0x493CAA0", VA = "0x18493E0A0")]
			public int MCCFLLFAKAG(TOutput JFBDPBFFKPN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x493CE30", Offset = "0x493B830", VA = "0x18493CE30")]
			public TInput GFBMFJOCMFC(TOutput JFBDPBFFKPN, int GCBONJOGHCD)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x493E5A0", Offset = "0x493CFA0", VA = "0x18493E5A0")]
			public TNode OKGHGBPCIJN(TOutput JFBDPBFFKPN)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x493D1B0", Offset = "0x493BBB0", VA = "0x18493D1B0")]
			public bool HHGPJLECLON(TType BKKHBFLPOHJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x493D590", Offset = "0x493BF90", VA = "0x18493D590")]
			public TType HPKCJEFIEOF(TType BKKHBFLPOHJ, IEnumerable<TType> IGLOMEKEODJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x493E4C0", Offset = "0x493CEC0", VA = "0x18493E4C0")]
			public void NNGDJMAFIDC(TType BKKHBFLPOHJ, Action<TType> FEBJBIKCAIG, Action<TType> IMGNJKKHMNN, Action<TType> PIPMJIJBCHO, Action<TType> IFPICNFNJBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x493D170", Offset = "0x493BB70", VA = "0x18493D170")]
			public TType GPMCIEFHPBN(TType BKKHBFLPOHJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x493C310", Offset = "0x493AD10", VA = "0x18493C310")]
			public string BBKKKAJFLLK(TType BKKHBFLPOHJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x493E7B0", Offset = "0x493D1B0", VA = "0x18493E7B0")]
			public TTerm OMLFAGGGCOJ()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x493D9E0", Offset = "0x493C3E0", VA = "0x18493D9E0")]
			public TTerm JOFOOIDCJHD(TTerm LJEHOJLCJND)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x493C5B0", Offset = "0x493AFB0", VA = "0x18493C5B0")]
			public TTerm BEMDFFNONFP(TTerm LFAPGGMCBIK, TTerm DIJABOFBAKO)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x493D650", Offset = "0x493C050", VA = "0x18493D650")]
			public void IKDEEMLPPNN(TTerm GPBGMCKGICE, TTerm PGFJAECCPCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x493D020", Offset = "0x493BA20", VA = "0x18493D020")]
			public bool GFEJHDIPNEJ(TOutputTerm LJEHOJLCJND)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x493C7D0", Offset = "0x493B1D0", VA = "0x18493C7D0")]
			public bool CBBPEKOPKGO(TOutputTerm LJEHOJLCJND)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x493D7F0", Offset = "0x493C1F0", VA = "0x18493D7F0")]
			public TTerm JEPOKAPIBBL(TOutputTerm FFNOFEKDNGF)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x493E350", Offset = "0x493CD50", VA = "0x18493E350")]
			public TOutputTerm NLEEEMAJPKH(TOutputTerm LJEHOJLCJND)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x493CD60", Offset = "0x493B760", VA = "0x18493CD60")]
			public TOutputTerm GCJMBKKCCLO(TOutputTerm LJEHOJLCJND)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x493EA20", Offset = "0x493D420", VA = "0x18493EA20")]
			public TTerm PGGMEEKNABG(TOutputSubstitution COCIGKAFDMF)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x493E8B0", Offset = "0x493D2B0", VA = "0x18493E8B0")]
			public TOutputTerm PCLBLIELGJK(TOutputSubstitution COCIGKAFDMF)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x493DEA0", Offset = "0x493C8A0", VA = "0x18493DEA0")]
			public TOutputTerm LKJOEOJLIFH(TTerm LJEHOJLCJND)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class DENHMKGBLIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public NFEAOPKJJIG arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public DENHMKGBLIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5C83010", Offset = "0x5C81A10", VA = "0x185C83010")]
			internal int FKGEMMBFEGL(NFEAOPKJJIG arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5C82D70", Offset = "0x5C81770", VA = "0x185C82D70")]
			internal TInput BILEAGNFFHP(NFEAOPKJJIG arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5C83070", Offset = "0x5C81A70", VA = "0x185C83070")]
			internal int LPHGBFKCLKJ(NFEAOPKJJIG arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5C82F40", Offset = "0x5C81940", VA = "0x185C82F40")]
			internal TOutput BLOBHJAOFIC(NFEAOPKJJIG arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GEBDGNIGNBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public NFEAOPKJJIG arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, OEOGEDBHJIJ<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<OEOGEDBHJIJ<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, BMOAMJOGDAN<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public GEBDGNIGNBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x40E36C0", Offset = "0x40E20C0", VA = "0x1840E36C0")]
			internal (string, TTerm) IJBCBHBPAPD(DCEMBPFEKIN<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class NCDHGCEINDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public NFEAOPKJJIG arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, BMOAMJOGDAN<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public NCDHGCEINDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4911070", Offset = "0x490FA70", VA = "0x184911070")]
			internal void GHILEIIJKFJ(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x49115D0", Offset = "0x490FFD0", VA = "0x1849115D0")]
			internal void MJAEKNFKEBF(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4911800", Offset = "0x4910200", VA = "0x184911800")]
			internal void NOMKACDGOOL(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4910A70", Offset = "0x490F470", VA = "0x184910A70")]
			internal void DGOMJLLEFJA(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AMGIMIPHALE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public NFEAOPKJJIG arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public AMGIMIPHALE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3F15C70", Offset = "0x3F14670", VA = "0x183F15C70")]
			internal TTerm INFLCBIHOKA(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3F26A30", Offset = "0x3F25430", VA = "0x183F26A30")]
		private static AAMDACFJKLP GMHPJPEEBMF([CallerMemberName] string JHJFHDOAMLG = "")
		{
			return default(AAMDACFJKLP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3F27830", Offset = "0x3F26230", VA = "0x183F27830")]
		public static Dictionary<TNode, List<DCEMBPFEKIN<TType>>> IDOAKBNKGFN(TRoot ELFANOAFHKM, TDeps JOIGIEDFOGO, TGraph ADJABNNJNMI, IEnumerable<TNode> IFJDAJAAFOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3F21B80", Offset = "0x3F20580", VA = "0x183F21B80")]
		private static (Dictionary<TTerm, OEOGEDBHJIJ<TNode>>, List<KeyValuePair<TTerm, BMOAMJOGDAN<TType>>>) GIDKEPBLEFD(IEnumerable<TNode> IFJDAJAAFOI, NFEAOPKJJIG BCHPPGPOGNC)
		{
			return default((Dictionary<TTerm, OEOGEDBHJIJ<TNode>>, List<KeyValuePair<TTerm, BMOAMJOGDAN<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3F2F0B0", Offset = "0x3F2DAB0", VA = "0x183F2F0B0")]
		private static void MAKJCLFEFHC(TNode OFGAFPGJIKO, Dictionary<TInput, TTerm> ODFOIHANAGF, Dictionary<TOutput, TTerm> PPADFJJBFMI, Dictionary<TTerm, OEOGEDBHJIJ<TNode>> KGCELLEMKBF, Dictionary<OEOGEDBHJIJ<TNode>, TTerm> NPAKCBLLMKP, List<KeyValuePair<TTerm, BMOAMJOGDAN<TType>>> AMBGDKPEPFO, Stack<TNode> BMIANBILOAL, List<DGHNMHNHJFG<TNode>> BADMKHHAPNL, NFEAOPKJJIG BCHPPGPOGNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D030", Offset = "0x3F1BA30", VA = "0x183F1D030")]
		private static Dictionary<string, TTerm> DGPONMDINBO(TNode OFGAFPGJIKO, Dictionary<TTerm, OEOGEDBHJIJ<TNode>> KGCELLEMKBF, Dictionary<OEOGEDBHJIJ<TNode>, TTerm> NGHIKFMCFJL, List<KeyValuePair<TTerm, BMOAMJOGDAN<TType>>> AMBGDKPEPFO, NFEAOPKJJIG BCHPPGPOGNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2E1E3C0", Offset = "0x2E1CDC0", VA = "0x182E1E3C0")]
		private static (TPort, TTerm)[] OCIMGCEEGPO<TPort>(TNode OFGAFPGJIKO, Func<NFEAOPKJJIG, TNode, int> CMFFKHMDMOD, Func<NFEAOPKJJIG, TNode, int, TPort> OLBNFEDBJIF, Func<NFEAOPKJJIG, TPort, TType> FOEHIAFLKKM, Dictionary<TPort, TTerm> HHPCNNBBGFK, NFEAOPKJJIG BCHPPGPOGNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3F19D60", Offset = "0x3F18760", VA = "0x183F19D60")]
		private static (TTerm, TTerm) AMNAFGLBCEC((TOutput Output, TTerm Id)[] MIKFPDPEONJ, List<KeyValuePair<TTerm, BMOAMJOGDAN<TType>>> AMBGDKPEPFO, Dictionary<string, TTerm> NGHIKFMCFJL, Stack<TNode> BMIANBILOAL, NFEAOPKJJIG BCHPPGPOGNC)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3F25C00", Offset = "0x3F24600", VA = "0x183F25C00")]
		private static void GJJNIGPDGOK((TInput PortKey, TTerm Id)[] PLBFDFIBHMD, TTerm AIAAIMOKNLI, TTerm BEJKOLMIIHG, List<KeyValuePair<TTerm, BMOAMJOGDAN<TType>>> AMBGDKPEPFO, Dictionary<TOutput, TTerm> PPADFJJBFMI, Dictionary<string, TTerm> NGHIKFMCFJL, Stack<TNode> BMIANBILOAL, NFEAOPKJJIG BCHPPGPOGNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B1C0", Offset = "0x3F29BC0", VA = "0x183F2B1C0")]
		private static TTerm KOOOCJBDILI(TInput CPOLINJHFNA, List<KeyValuePair<TTerm, BMOAMJOGDAN<TType>>> AMBGDKPEPFO, Dictionary<TOutput, TTerm> PPADFJJBFMI, Stack<TNode> BMIANBILOAL, NFEAOPKJJIG BCHPPGPOGNC)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C9D0", Offset = "0x3F1B3D0", VA = "0x183F1C9D0")]
		private static TTerm DEOLHJNDEKI([In] TType BKKHBFLPOHJ, IOKind IBIIPLNONKN, List<KeyValuePair<TTerm, BMOAMJOGDAN<TType>>> AMBGDKPEPFO, IReadOnlyDictionary<string, TTerm> NGHIKFMCFJL, NFEAOPKJJIG BCHPPGPOGNC)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3F29880", Offset = "0x3F28280", VA = "0x183F29880")]
		private static Dictionary<TNode, List<DCEMBPFEKIN<TType>>> JFAIGPMDPPG(TOutputSubstitution[] ELLJPFOFCHF, Dictionary<TTerm, OEOGEDBHJIJ<TNode>> KGCELLEMKBF, IEnumerable<KeyValuePair<TTerm, BMOAMJOGDAN<TType>>> AMBGDKPEPFO, NFEAOPKJJIG BCHPPGPOGNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C730", Offset = "0x3F2B130", VA = "0x183F2C730")]
		private static Dictionary<TNode, List<DCEMBPFEKIN<TType>>> LIBDJFAHLLJ(Dictionary<TTerm, OEOGEDBHJIJ<TNode>> KGCELLEMKBF, NFEAOPKJJIG BCHPPGPOGNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D5A0", Offset = "0x3F2BFA0", VA = "0x183F2D5A0")]
		private static void LICBKOJKJDJ([In] TNode OFGAFPGJIKO, Stack<TNode> BMIANBILOAL, List<DGHNMHNHJFG<TNode>> BADMKHHAPNL, NFEAOPKJJIG BCHPPGPOGNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C200", Offset = "0x3F2AC00", VA = "0x183F2C200")]
		private static void LDDFAMAAMAJ(Dictionary<OEOGEDBHJIJ<TNode>, TTerm> NGHIKFMCFJL, List<DGHNMHNHJFG<TNode>> BADMKHHAPNL, NFEAOPKJJIG BCHPPGPOGNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3F20AD0", Offset = "0x3F1F4D0", VA = "0x183F20AD0")]
		private static Dictionary<TTerm, TType> GFKPKIOLGCP(Dictionary<TTerm, TOutputSubstitution> ELLJPFOFCHF, IEnumerable<KeyValuePair<TTerm, BMOAMJOGDAN<TType>>> AMBGDKPEPFO, NFEAOPKJJIG BCHPPGPOGNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E030", Offset = "0x3F1CA30", VA = "0x183F1E030")]
		private static BHEDPLGAJGK<TType> ENEPNDFONEK(TOutputTerm BKKHBFLPOHJ, Dictionary<TTerm, TType> AMBGDKPEPFO, Dictionary<TTerm, TType> CAMFPBAFKPB, NFEAOPKJJIG BCHPPGPOGNC)
		{
			return default(BHEDPLGAJGK<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3F30CA0", Offset = "0x3F2F6A0", VA = "0x183F30CA0")]
		private static TOutputTerm PBIMENELFFF(TOutputTerm FBEGJAJANKL, NFEAOPKJJIG BCHPPGPOGNC)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2D489B0", Offset = "0x2D473B0", VA = "0x182D489B0")]
	public static Dictionary<TNode, List<DCEMBPFEKIN<TType>>> IDOAKBNKGFN<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::PPBLAEGBBCL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> PCBICLOONMH, TRoot ELFANOAFHKM, TGraph ADJABNNJNMI, IEnumerable<TNode> IFJDAJAAFOI) where TDeps : global::PNAGJPMDMAD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct DCEMBPFEKIN<TType> : IEquatable<DCEMBPFEKIN<TType>>, OKIKCDAEAAO<DCEMBPFEKIN<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string OENPDLODONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType LALMJDFCEAJ;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4673470", Offset = "0x4671E70", VA = "0x184673470")]
	internal DCEMBPFEKIN(string JHJFHDOAMLG, [In] TType LOEOOHBHPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5C75080", Offset = "0x5C73A80", VA = "0x185C75080")]
	public bool PGEDFKHCPLD([In] DCEMBPFEKIN<TType> GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5C75030", Offset = "0x5C73A30", VA = "0x185C75030", Slot = "4")]
	public bool Equals(DCEMBPFEKIN<TType> GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4A53710", Offset = "0x4A52110", VA = "0x184A53710", Slot = "0")]
	public override bool Equals(object GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x22F5F90", Offset = "0x22F4990", VA = "0x1822F5F90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5C75160", Offset = "0x5C73B60", VA = "0x185C75160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5C74FE0", Offset = "0x5C739E0", VA = "0x185C74FE0", Slot = "5")]
	private bool BFCHBHPGHHF([In] DCEMBPFEKIN<TType> GDOGPMPJPOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LJNHPCAHAHH
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2FB17A0", Offset = "0x2FB01A0", VA = "0x182FB17A0")]
	public static DCEMBPFEKIN<TType> AELHPDENENI<TType>(string JHJFHDOAMLG, TType LOEOOHBHPPK)
	{
		return default(DCEMBPFEKIN<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2FB17D0", Offset = "0x2FB01D0", VA = "0x182FB17D0")]
	public static (string, TType) NJHGPHLJDBE<TType>([In] this DCEMBPFEKIN<TType> PCBICLOONMH)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct OEOGEDBHJIJ<TNode> : IEquatable<OEOGEDBHJIJ<TNode>>, OKIKCDAEAAO<OEOGEDBHJIJ<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode EFJLBHNFDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string OENPDLODONH;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1116530", Offset = "0x1114F30", VA = "0x181116530")]
	internal OEOGEDBHJIJ(TNode OFGAFPGJIKO, string JHJFHDOAMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4A53A30", Offset = "0x4A52430", VA = "0x184A53A30")]
	public bool PGEDFKHCPLD([In] OEOGEDBHJIJ<TNode> GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4A537F0", Offset = "0x4A521F0", VA = "0x184A537F0", Slot = "4")]
	public bool Equals(OEOGEDBHJIJ<TNode> GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4A53710", Offset = "0x4A52110", VA = "0x184A53710", Slot = "0")]
	public override bool Equals(object GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4A53840", Offset = "0x4A52240", VA = "0x184A53840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4A53B50", Offset = "0x4A52550", VA = "0x184A53B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4A53900", Offset = "0x4A52300", VA = "0x184A53900", Slot = "5")]
	private bool NNJKCGKBAPL([In] OEOGEDBHJIJ<TNode> GDOGPMPJPOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class CHHOBHMNGKL
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9990", Offset = "0x2CE8390", VA = "0x182CE9990")]
	public static OEOGEDBHJIJ<TNode> AELHPDENENI<TNode>(TNode OFGAFPGJIKO, string JHJFHDOAMLG)
	{
		return default(OEOGEDBHJIJ<TNode>);
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

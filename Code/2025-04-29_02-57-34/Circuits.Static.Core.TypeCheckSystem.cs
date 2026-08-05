using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct LBHEJIIINFM<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType PLJKCMOLLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind NBJANACOCME;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xBF1070", Offset = "0xBF0470", VA = "0x180BF1070")]
	internal LBHEJIIINFM(TType KHNCICOHHHJ, IOKind MPLBLNBNKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E8A8C0", Offset = "0x4E89CC0", VA = "0x184E8A8C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KODFBCKLGGC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3787790", Offset = "0x3786B90", VA = "0x183787790")]
	public static LBHEJIIINFM<TType> FABCCGGAHMJ<TType>(TType KHNCICOHHHJ, IOKind MPLBLNBNKKE)
	{
		return default(LBHEJIIINFM<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3787830", Offset = "0x3786C30", VA = "0x183787830")]
	public static (TType, IOKind) MLEFDCBMJFG<TType>([In] this LBHEJIIINFM<TType> KBBJDOAJMAF)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37877C0", Offset = "0x3786BC0", VA = "0x1837877C0")]
	public static void JGKNJHGPNLN<TType>([In] this LBHEJIIINFM<TType> KBBJDOAJMAF, [Out] TType KHNCICOHHHJ, [Out] IOKind MPLBLNBNKKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct HBIIAHKKCCF<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly ACCGNHDCINF<TNode> FLCJODBFNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ACCGNHDCINF<TNode> LIKNAILBEMA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x490D750", Offset = "0x490CB50", VA = "0x18490D750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PCHLMMBHBMD
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x38BE3C0", Offset = "0x38BD7C0", VA = "0x1838BE3C0")]
	public static (ACCGNHDCINF<TNode>, ACCGNHDCINF<TNode>) MLEFDCBMJFG<TNode>([In] this HBIIAHKKCCF<TNode> KBBJDOAJMAF)
	{
		return default((ACCGNHDCINF<TNode>, ACCGNHDCINF<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x38BE2C0", Offset = "0x38BD6C0", VA = "0x1838BE2C0")]
	public static void JGKNJHGPNLN<TNode>([In] this HBIIAHKKCCF<TNode> KBBJDOAJMAF, [Out] ACCGNHDCINF<TNode> BGDONNBGCJK, [Out] ACCGNHDCINF<TNode> DKEKGDBAIOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DJBHIIHLADB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KCDBMGEGNCI KOPAMFOMIDG(TRoot DGFFJNKGDJD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType OGJNEDFCBML(TRoot DGFFJNKGDJD);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LBHEJIIINFM<TType> JHPNMHEBJGM(TRoot DGFFJNKGDJD, [In] LBHEJIIINFM<TType> PPPJAHNPKAO, [In] LBHEJIIINFM<TType> DFIFINAEGII);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JLMNBHHNGIF(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TNode HAIECNDMOKO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LLNMIHAEOCP(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TNode HAIECNDMOKO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput EENJKGKGONK(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TNode HAIECNDMOKO, int COPLIEINKOF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OBOPNDCJHFB(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TNode HAIECNDMOKO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput DCFPCOOFCFD(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TNode HAIECNDMOKO, int COPLIEINKOF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<EFKGNLIPPPJ<TType>> OAMGLHIAPJN(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TNode HAIECNDMOKO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<HBIIAHKKCCF<TNode>> PJFJGGLCJIB(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TNode HAIECNDMOKO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType JGPKALMMGEB(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TInput EOMFNMMGCEC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int KLBOBFIONOE(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TInput EOMFNMMGCEC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput BJJCKFGHDFD(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TInput EOMFNMMGCEC, int COPLIEINKOF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode LPCEAMAKOJC(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TInput EOMFNMMGCEC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType HJJJLEHIPNE(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TOutput GKIPCPOAHBN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int IJILGJDDKLG(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TOutput GKIPCPOAHBN);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput JAKEGIBNOKO(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TOutput GKIPCPOAHBN, int COPLIEINKOF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode PKJHKOEOCAP(TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, TOutput GKIPCPOAHBN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OLELNKELDEE(TRoot DGFFJNKGDJD, TType KHNCICOHHHJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType FDJHLEGPNPK(TRoot DGFFJNKGDJD, TType KHNCICOHHHJ, IEnumerable<TType> NBCOKMAIIOG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AMPENLIEIGJ(TRoot DGFFJNKGDJD, TType KHNCICOHHHJ, Action<TType> AFHPEILJIBE, Action<TType> HJFJOEAMFEJ, Action<TType> EHJJINJKAKE, Action<TType> DADPIJBDIIB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType EFGECMHGEIP(TRoot DGFFJNKGDJD, TType KHNCICOHHHJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string OIDKHGIFEOK(TRoot DGFFJNKGDJD, TType KHNCICOHHHJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification GDMBGBJFJID(TRoot DGFFJNKGDJD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BECHBBIPIFM<TOutputSubstitution[], IDMJKCLDJLO> CMLHLHEEPFL(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm LLJKBKKDOLK(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm PLMBDPKDBFC(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB, TTerm CIKGLIGGJLG);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm HOCLDLMOALO(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB, TTerm GKCLMOEIPKF, TTerm BJFBLFCILOA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OCJBBDLNFBK(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB, TTerm PPPJAHNPKAO, TTerm DFIFINAEGII);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool IPOKDFHEDGP(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB, TOutputTerm NKLNJEIEFPA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool KMNBFNFEJPI(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB, TOutputTerm NKLNJEIEFPA);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm PLKDNCKBNPH(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB, TOutputTerm NKLNJEIEFPA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm DGDGPNPIFMA(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB, TOutputTerm NKLNJEIEFPA);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm MIDAANCJLKH(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB, TOutputTerm NKLNJEIEFPA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm PEEPDFMGELJ(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB, TOutputSubstitution NFHCLCBLFAK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm AIDCDALFDAC(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB, TOutputSubstitution NFHCLCBLFAK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm MJKBAHIHIMK(TRoot DGFFJNKGDJD, TUnification NIMIJAGKNNB, TTerm CIKGLIGGJLG);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CDFCOMEHPLK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::DJBHIIHLADB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0")]
	public static global::CDFCOMEHPLK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> FABCCGGAHMJ()
	{
		return default(global::CDFCOMEHPLK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MDCAIMCLFCG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class HJALDADEMIK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::DJBHIIHLADB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class NAPAAHHNJHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot IAKDDPPLCKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps AIPJEAABAPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification DKOBNJOAGLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph KHOBIPOMNHM;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public KCDBMGEGNCI NLAEHINMBAA
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x5153DD0", Offset = "0x51531D0", VA = "0x185153DD0")]
				get
				{
					return default(KCDBMGEGNCI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5156410", Offset = "0x5155810", VA = "0x185156410")]
			private NAPAAHHNJHB(TRoot DGFFJNKGDJD, TDeps BGLHIFBEGOD, TUnification NIFBJDMBBLK, TGraph OFGCJBCHPLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5154510", Offset = "0x5153910", VA = "0x185154510")]
			public static NAPAAHHNJHB FABCCGGAHMJ(TRoot DGFFJNKGDJD, TDeps BGLHIFBEGOD, TUnification NIFBJDMBBLK, TGraph OFGCJBCHPLD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5155D60", Offset = "0x5155160", VA = "0x185155D60")]
			public TType OGJNEDFCBML()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x51550E0", Offset = "0x51544E0", VA = "0x1851550E0")]
			public LBHEJIIINFM<TType> JHPNMHEBJGM(LBHEJIIINFM<TType> PPPJAHNPKAO, LBHEJIIINFM<TType> DFIFINAEGII)
			{
				return default(LBHEJIIINFM<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5155200", Offset = "0x5154600", VA = "0x185155200")]
			public int JLMNBHHNGIF(TNode HAIECNDMOKO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5155490", Offset = "0x5154890", VA = "0x185155490")]
			public int LLNMIHAEOCP(TNode HAIECNDMOKO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5154220", Offset = "0x5153620", VA = "0x185154220")]
			public TInput EENJKGKGONK(TNode HAIECNDMOKO, int COPLIEINKOF)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x51559B0", Offset = "0x5154DB0", VA = "0x1851559B0")]
			public int OBOPNDCJHFB(TNode HAIECNDMOKO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5153FD0", Offset = "0x51533D0", VA = "0x185153FD0")]
			public TOutput DCFPCOOFCFD(TNode HAIECNDMOKO, int COPLIEINKOF)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5155970", Offset = "0x5154D70", VA = "0x185155970")]
			public IEnumerable<EFKGNLIPPPJ<TType>> OAMGLHIAPJN(TNode HAIECNDMOKO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5156110", Offset = "0x5155510", VA = "0x185156110")]
			public IEnumerable<HBIIAHKKCCF<TNode>> PJFJGGLCJIB([In] TNode HAIECNDMOKO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5154E60", Offset = "0x5154260", VA = "0x185154E60")]
			public TType JGPKALMMGEB(TInput EOMFNMMGCEC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5153C10", Offset = "0x5153010", VA = "0x185153C10")]
			public int BKAAALNGBDJ(TInput EOMFNMMGCEC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5153A50", Offset = "0x5152E50", VA = "0x185153A50")]
			public TOutput BJJCKFGHDFD(TInput EOMFNMMGCEC, int COPLIEINKOF)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5155550", Offset = "0x5154950", VA = "0x185155550")]
			public TNode LPCEAMAKOJC(TInput EOMFNMMGCEC)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5154960", Offset = "0x5153D60", VA = "0x185154960")]
			public TType HJJJLEHIPNE(TOutput GKIPCPOAHBN)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x51547F0", Offset = "0x5153BF0", VA = "0x1851547F0")]
			public int GINOILEDFMA(TOutput GKIPCPOAHBN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5154D70", Offset = "0x5154170", VA = "0x185154D70")]
			public TInput JAKEGIBNOKO(TOutput GKIPCPOAHBN, int COPLIEINKOF)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x51562A0", Offset = "0x51556A0", VA = "0x1851562A0")]
			public TNode PKJHKOEOCAP(TOutput GKIPCPOAHBN)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5155FC0", Offset = "0x51553C0", VA = "0x185155FC0")]
			public bool OLELNKELDEE(TType KHNCICOHHHJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5154730", Offset = "0x5153B30", VA = "0x185154730")]
			public TType FDJHLEGPNPK(TType KHNCICOHHHJ, IEnumerable<TType> NBCOKMAIIOG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x51538D0", Offset = "0x5152CD0", VA = "0x1851538D0")]
			public void AMPENLIEIGJ(TType KHNCICOHHHJ, Action<TType> AFHPEILJIBE, Action<TType> HJFJOEAMFEJ, Action<TType> EHJJINJKAKE, Action<TType> DADPIJBDIIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5154310", Offset = "0x5153710", VA = "0x185154310")]
			public TType EFGECMHGEIP(TType KHNCICOHHHJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5155DE0", Offset = "0x51551E0", VA = "0x185155DE0")]
			public string OIDKHGIFEOK(TType KHNCICOHHHJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5155410", Offset = "0x5154810", VA = "0x185155410")]
			public TTerm LLJKBKKDOLK()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x51563C0", Offset = "0x51557C0", VA = "0x1851563C0")]
			public TTerm PLMBDPKDBFC(TTerm CIKGLIGGJLG)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5154B80", Offset = "0x5153F80", VA = "0x185154B80")]
			public TTerm HOCLDLMOALO(TTerm GKCLMOEIPKF, TTerm BJFBLFCILOA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5155AB0", Offset = "0x5154EB0", VA = "0x185155AB0")]
			public void OCJBBDLNFBK(TTerm PPPJAHNPKAO, TTerm DFIFINAEGII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5155310", Offset = "0x5154710", VA = "0x185155310")]
			public bool KMNBFNFEJPI(TOutputTerm CIKGLIGGJLG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5154C20", Offset = "0x5154020", VA = "0x185154C20")]
			public bool IPOKDFHEDGP(TOutputTerm CIKGLIGGJLG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5153E10", Offset = "0x5153210", VA = "0x185153E10")]
			public TTerm DALPGEONAMJ(TOutputTerm NKLNJEIEFPA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5154160", Offset = "0x5153560", VA = "0x185154160")]
			public TOutputTerm DGDGPNPIFMA(TOutputTerm CIKGLIGGJLG)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5155740", Offset = "0x5154B40", VA = "0x185155740")]
			public TOutputTerm MIDAANCJLKH(TOutputTerm CIKGLIGGJLG)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5156080", Offset = "0x5155480", VA = "0x185156080")]
			public TTerm PEEPDFMGELJ(TOutputSubstitution EBOANFDMHMJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5153880", Offset = "0x5152C80", VA = "0x185153880")]
			public TOutputTerm AIDCDALFDAC(TOutputSubstitution EBOANFDMHMJ)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x51557E0", Offset = "0x5154BE0", VA = "0x1851557E0")]
			public TOutputTerm MJKBAHIHIMK(TTerm CIKGLIGGJLG)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class EHOOOKFJFNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public NAPAAHHNJHB arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public EHOOOKFJFNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4399D40", Offset = "0x4399140", VA = "0x184399D40")]
			internal int APMEJFDNIDC(NAPAAHHNJHB arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4399FD0", Offset = "0x43993D0", VA = "0x184399FD0")]
			internal TInput FDELMBIOPFA(NAPAAHHNJHB arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x439A0A0", Offset = "0x43994A0", VA = "0x18439A0A0")]
			internal int LJJGBDOPHDK(NAPAAHHNJHB arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4399E00", Offset = "0x4399200", VA = "0x184399E00")]
			internal TOutput ECFLALHEIKB(NAPAAHHNJHB arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NHAMFOOADKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public NAPAAHHNJHB arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, ACCGNHDCINF<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<ACCGNHDCINF<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, LBHEJIIINFM<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public NHAMFOOADKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x51A1770", Offset = "0x51A0B70", VA = "0x1851A1770")]
			internal (string, TTerm) ECADBLOOCGL(EFKGNLIPPPJ<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CLCNPOEKGHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public NAPAAHHNJHB arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, LBHEJIIINFM<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public CLCNPOEKGHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x662F790", Offset = "0x662EB90", VA = "0x18662F790")]
			internal void PNGJOMGKFFG(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x662F560", Offset = "0x662E960", VA = "0x18662F560")]
			internal void MCLKHBKCIAD(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x662F0A0", Offset = "0x662E4A0", VA = "0x18662F0A0")]
			internal void HIJIKMPPBJM(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x662ECE0", Offset = "0x662E0E0", VA = "0x18662ECE0")]
			internal void BAIMFFPMBJK(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class KPADFMLJEGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public NAPAAHHNJHB arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public KPADFMLJEGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x439E510", Offset = "0x439D910", VA = "0x18439E510")]
			internal TTerm HMIILNDEMMP(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x492D260", Offset = "0x492C660", VA = "0x18492D260")]
		private static NCHPFIPPILF GJHJPDJPIPE([CallerMemberName] string KCCMEIDBNGP = "")
		{
			return default(NCHPFIPPILF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x492C130", Offset = "0x492B530", VA = "0x18492C130")]
		public static Dictionary<TNode, List<EFKGNLIPPPJ<TType>>> COFANEHPHPH(TRoot DGFFJNKGDJD, TDeps BGLHIFBEGOD, TGraph OFGCJBCHPLD, IEnumerable<TNode> ELKEEDJPIPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x492F410", Offset = "0x492E810", VA = "0x18492F410")]
		private static (Dictionary<TTerm, ACCGNHDCINF<TNode>>, List<KeyValuePair<TTerm, LBHEJIIINFM<TType>>>) MBCKPPKNHJK(IEnumerable<TNode> ELKEEDJPIPG, NAPAAHHNJHB LICDMCPJILC)
		{
			return default((Dictionary<TTerm, ACCGNHDCINF<TNode>>, List<KeyValuePair<TTerm, LBHEJIIINFM<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4928CA0", Offset = "0x49280A0", VA = "0x184928CA0")]
		private static void AGMONCBGFMH(TNode HAIECNDMOKO, Dictionary<TInput, TTerm> COLBNOFKDGK, Dictionary<TOutput, TTerm> EHAIHJDNHHM, Dictionary<TTerm, ACCGNHDCINF<TNode>> IIAKLDHNALH, Dictionary<ACCGNHDCINF<TNode>, TTerm> IPJEGNOMLFO, List<KeyValuePair<TTerm, LBHEJIIINFM<TType>>> HIIFLKONIEL, Stack<TNode> OPHFMGNIODA, List<HBIIAHKKCCF<TNode>> CPHODOJNGLK, NAPAAHHNJHB LICDMCPJILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x492AD20", Offset = "0x492A120", VA = "0x18492AD20")]
		private static Dictionary<string, TTerm> CBFKDEDHGEO(TNode HAIECNDMOKO, Dictionary<TTerm, ACCGNHDCINF<TNode>> IIAKLDHNALH, Dictionary<ACCGNHDCINF<TNode>, TTerm> DPOKNNDIOLO, List<KeyValuePair<TTerm, LBHEJIIINFM<TType>>> HIIFLKONIEL, NAPAAHHNJHB LICDMCPJILC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA490", Offset = "0x3AD9890", VA = "0x183ADA490")]
		private static (TPort, TTerm)[] FPMABADBAKD<TPort>(TNode HAIECNDMOKO, Func<NAPAAHHNJHB, TNode, int> NLDMLFJOBEL, Func<NAPAAHHNJHB, TNode, int, TPort> OAOKEFLOMGP, Func<NAPAAHHNJHB, TPort, TType> LMJOGIIOFPN, Dictionary<TPort, TTerm> GJMEKLEGMNB, NAPAAHHNJHB LICDMCPJILC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x49299E0", Offset = "0x4928DE0", VA = "0x1849299E0")]
		private static (TTerm, TTerm) AJEMNLMBFNJ((TOutput Output, TTerm Id)[] HFLJADBFFBE, List<KeyValuePair<TTerm, LBHEJIIINFM<TType>>> HIIFLKONIEL, Dictionary<string, TTerm> DPOKNNDIOLO, Stack<TNode> OPHFMGNIODA, NAPAAHHNJHB LICDMCPJILC)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x49301A0", Offset = "0x492F5A0", VA = "0x1849301A0")]
		private static void PBCKGKDPOMA((TInput PortKey, TTerm Id)[] KCOKOMAOHGE, TTerm CIPHPJIJIKI, TTerm BNAIINDKFGJ, List<KeyValuePair<TTerm, LBHEJIIINFM<TType>>> HIIFLKONIEL, Dictionary<TOutput, TTerm> EHAIHJDNHHM, Dictionary<string, TTerm> DPOKNNDIOLO, Stack<TNode> OPHFMGNIODA, NAPAAHHNJHB LICDMCPJILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x492E4F0", Offset = "0x492D8F0", VA = "0x18492E4F0")]
		private static TTerm KEOKJBIFIPP(TInput EOMFNMMGCEC, List<KeyValuePair<TTerm, LBHEJIIINFM<TType>>> HIIFLKONIEL, Dictionary<TOutput, TTerm> EHAIHJDNHHM, Stack<TNode> OPHFMGNIODA, NAPAAHHNJHB LICDMCPJILC)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x492CC00", Offset = "0x492C000", VA = "0x18492CC00")]
		private static TTerm FDBFDCGKOLO([In] TType KHNCICOHHHJ, IOKind MPLBLNBNKKE, List<KeyValuePair<TTerm, LBHEJIIINFM<TType>>> HIIFLKONIEL, IReadOnlyDictionary<string, TTerm> DPOKNNDIOLO, NAPAAHHNJHB LICDMCPJILC)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x492D2A0", Offset = "0x492C6A0", VA = "0x18492D2A0")]
		private static Dictionary<TNode, List<EFKGNLIPPPJ<TType>>> IIFCLBAKEGC(TOutputSubstitution[] NFKDPKMBKKB, Dictionary<TTerm, ACCGNHDCINF<TNode>> IIAKLDHNALH, IEnumerable<KeyValuePair<TTerm, LBHEJIIINFM<TType>>> HIIFLKONIEL, NAPAAHHNJHB LICDMCPJILC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x492C730", Offset = "0x492BB30", VA = "0x18492C730")]
		private static Dictionary<TNode, List<EFKGNLIPPPJ<TType>>> EALGAJFAHFF(Dictionary<TTerm, ACCGNHDCINF<TNode>> IIAKLDHNALH, NAPAAHHNJHB LICDMCPJILC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x492A890", Offset = "0x4929C90", VA = "0x18492A890")]
		private static void BCOKIMNJENO([In] TNode HAIECNDMOKO, Stack<TNode> OPHFMGNIODA, List<HBIIAHKKCCF<TNode>> CPHODOJNGLK, NAPAAHHNJHB LICDMCPJILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x492DFC0", Offset = "0x492D3C0", VA = "0x18492DFC0")]
		private static void ILHHCFLAHJJ(Dictionary<ACCGNHDCINF<TNode>, TTerm> DPOKNNDIOLO, List<HBIIAHKKCCF<TNode>> CPHODOJNGLK, NAPAAHHNJHB LICDMCPJILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x492B070", Offset = "0x492A470", VA = "0x18492B070")]
		private static Dictionary<TTerm, TType> CLMDAMPENAN(Dictionary<TTerm, TOutputSubstitution> NFKDPKMBKKB, IEnumerable<KeyValuePair<TTerm, LBHEJIIINFM<TType>>> HIIFLKONIEL, NAPAAHHNJHB LICDMCPJILC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x492EAC0", Offset = "0x492DEC0", VA = "0x18492EAC0")]
		private static JCEPLOKMLCO<TType> LIPHHAKHPPC(TOutputTerm KHNCICOHHHJ, Dictionary<TTerm, TType> HIIFLKONIEL, Dictionary<TTerm, TType> NMAEEMHJHKP, NAPAAHHNJHB LICDMCPJILC)
		{
			return default(JCEPLOKMLCO<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4930020", Offset = "0x492F420", VA = "0x184930020")]
		private static TOutputTerm NCIIKPLAAGF(TOutputTerm DIPNEOBCEGN, NAPAAHHNJHB LICDMCPJILC)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x37B6160", Offset = "0x37B5560", VA = "0x1837B6160")]
	public static Dictionary<TNode, List<EFKGNLIPPPJ<TType>>> COFANEHPHPH<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::CDFCOMEHPLK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> KBBJDOAJMAF, TRoot DGFFJNKGDJD, TGraph OFGCJBCHPLD, IEnumerable<TNode> ELKEEDJPIPG) where TDeps : global::DJBHIIHLADB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct EFKGNLIPPPJ<TType> : IEquatable<EFKGNLIPPPJ<TType>>, MOCNKDDHAGL<EFKGNLIPPPJ<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string LIPJOHOCCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType JBLDOKONFNI;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x438C430", Offset = "0x438B830", VA = "0x18438C430")]
	internal EFKGNLIPPPJ(string KCCMEIDBNGP, [In] TType OHEENGJEBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x438C230", Offset = "0x438B630", VA = "0x18438C230")]
	public bool DJLDNMDKCFF([In] EFKGNLIPPPJ<TType> DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x438C310", Offset = "0x438B710", VA = "0x18438C310", Slot = "4")]
	public bool Equals(EFKGNLIPPPJ<TType> DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x438C360", Offset = "0x438B760", VA = "0x18438C360", Slot = "0")]
	public override bool Equals(object DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x276E440", Offset = "0x276D840", VA = "0x18276E440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x438C3F0", Offset = "0x438B7F0", VA = "0x18438C3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x438C1E0", Offset = "0x438B5E0", VA = "0x18438C1E0", Slot = "5")]
	private bool BKKABMFOKCL([In] EFKGNLIPPPJ<TType> DMMBOHMLHLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GIOHGCOLEOF
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x36A9D20", Offset = "0x36A9120", VA = "0x1836A9D20")]
	public static EFKGNLIPPPJ<TType> FABCCGGAHMJ<TType>(string KCCMEIDBNGP, TType OHEENGJEBAE)
	{
		return default(EFKGNLIPPPJ<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x36A9D50", Offset = "0x36A9150", VA = "0x1836A9D50")]
	public static (string, TType) MLEFDCBMJFG<TType>([In] this EFKGNLIPPPJ<TType> KBBJDOAJMAF)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct ACCGNHDCINF<TNode> : IEquatable<ACCGNHDCINF<TNode>>, MOCNKDDHAGL<ACCGNHDCINF<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode NIADBHDFAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string LIPJOHOCCJK;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x15CFB00", Offset = "0x15CEF00", VA = "0x1815CFB00")]
	internal ACCGNHDCINF(TNode HAIECNDMOKO, string KCCMEIDBNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x48A3510", Offset = "0x48A2910", VA = "0x1848A3510")]
	public bool DJLDNMDKCFF([In] ACCGNHDCINF<TNode> DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x48A3720", Offset = "0x48A2B20", VA = "0x1848A3720", Slot = "4")]
	public bool Equals(ACCGNHDCINF<TNode> DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x438C360", Offset = "0x438B760", VA = "0x18438C360", Slot = "0")]
	public override bool Equals(object DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x48A3770", Offset = "0x48A2B70", VA = "0x1848A3770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x48A3820", Offset = "0x48A2C20", VA = "0x1848A3820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x48A34C0", Offset = "0x48A28C0", VA = "0x1848A34C0", Slot = "5")]
	private bool ADHCBDIJCDJ([In] ACCGNHDCINF<TNode> DMMBOHMLHLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FJOAOMFCIHD
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x368FB60", Offset = "0x368EF60", VA = "0x18368FB60")]
	public static ACCGNHDCINF<TNode> FABCCGGAHMJ<TNode>(TNode HAIECNDMOKO, string KCCMEIDBNGP)
	{
		return default(ACCGNHDCINF<TNode>);
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

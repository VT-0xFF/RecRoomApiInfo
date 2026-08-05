using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct ODEFNJPDEJE<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType EANPJBEPKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind IOCPPLNEFCJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x168FAE0", Offset = "0x168EEE0", VA = "0x18168FAE0")]
	internal ODEFNJPDEJE(TType IJFAMCPOKBO, IOKind DCLJLOLGABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3CE24F0", Offset = "0x3CE18F0", VA = "0x183CE24F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EKKAAKLPIFG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2259F90", Offset = "0x2259390", VA = "0x182259F90")]
	public static ODEFNJPDEJE<TType> LJCGEPFBFCG<TType>(TType IJFAMCPOKBO, IOKind DCLJLOLGABK)
	{
		return default(ODEFNJPDEJE<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2259EF0", Offset = "0x22592F0", VA = "0x182259EF0")]
	public static (TType, IOKind) DDKPKJICCAG<TType>([In] this ODEFNJPDEJE<TType> LDMHFMNLDHG)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2259F30", Offset = "0x2259330", VA = "0x182259F30")]
	public static void LHHELOIEGGD<TType>([In] this ODEFNJPDEJE<TType> LDMHFMNLDHG, [Out] TType IJFAMCPOKBO, [Out] IOKind DCLJLOLGABK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct DALHEAAIMOC<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MELNOIPLALE<TNode> ECOADNKJMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MELNOIPLALE<TNode> HBJDIOFJODO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4C73EC0", Offset = "0x4C732C0", VA = "0x184C73EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LAPBCKNOGAE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24473C0", Offset = "0x24467C0", VA = "0x1824473C0")]
	public static (MELNOIPLALE<TNode>, MELNOIPLALE<TNode>) DDKPKJICCAG<TNode>([In] this DALHEAAIMOC<TNode> LDMHFMNLDHG)
	{
		return default((MELNOIPLALE<TNode>, MELNOIPLALE<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2447460", Offset = "0x2446860", VA = "0x182447460")]
	public static void LHHELOIEGGD<TNode>([In] this DALHEAAIMOC<TNode> LDMHFMNLDHG, [Out] MELNOIPLALE<TNode> GFPOLPOKADD, [Out] MELNOIPLALE<TNode> PBBDJDKAOCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CMHGHMLCKJN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OHCNHGOOJKE GFCCLLAEGPN(TRoot OGEFIHKILIO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType AACGHDBCGOH(TRoot OGEFIHKILIO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ODEFNJPDEJE<TType> AMGENGFPAGN(TRoot OGEFIHKILIO, [In] ODEFNJPDEJE<TType> IBOMHLKOLJB, [In] ODEFNJPDEJE<TType> FFDHLLBEMJM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CHLGKEMIIFI(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TNode OMFNHGCDBFM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ELGOEKFCLBF(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TNode OMFNHGCDBFM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput GKBLKDFODKJ(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TNode OMFNHGCDBFM, int APOENOPNHBG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int BCFOAGBOHNI(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TNode OMFNHGCDBFM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput BIHMCFNABCG(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TNode OMFNHGCDBFM, int APOENOPNHBG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<KIFFCCLLLHL<TType>> IPIHPHFEBEI(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TNode OMFNHGCDBFM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<DALHEAAIMOC<TNode>> PKFJDAFOPOK(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TNode OMFNHGCDBFM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType DCPEEEBNBKP(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TInput CEPHEIEJHPL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int NNIAODFPMLI(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TInput CEPHEIEJHPL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput AMLEIEAJMDH(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TInput CEPHEIEJHPL, int APOENOPNHBG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode HFMOGFLIPBC(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TInput CEPHEIEJHPL);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType FNAGAKEMPHF(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TOutput GOPGHHGNMKB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int IDMMBEMCKPD(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TOutput GOPGHHGNMKB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput HCJFJFLHKMO(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TOutput GOPGHHGNMKB, int APOENOPNHBG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode DICFMBBDOHH(TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, TOutput GOPGHHGNMKB);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool GEIAEGMDCNE(TRoot OGEFIHKILIO, TType IJFAMCPOKBO);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType IKNKLBEKBMH(TRoot OGEFIHKILIO, TType IJFAMCPOKBO, IEnumerable<TType> GEMGLENAPNB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ALMMJJJIDGG(TRoot OGEFIHKILIO, TType IJFAMCPOKBO, Action<TType> OGKMNAHHLGM, Action<TType> NFHMBJMLNBE, Action<TType> AKKCCHAGKJN, Action<TType> EAPDAPHFMOO);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType JHFMHHPCMCP(TRoot OGEFIHKILIO, TType IJFAMCPOKBO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string IIANJGOEJMI(TRoot OGEFIHKILIO, TType IJFAMCPOKBO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification LBIEIAOJIIL(TRoot OGEFIHKILIO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KJFLOMPEKGD<TOutputSubstitution[], ILAPNMDMBPF> DHMALAEINFF(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm KJKMNFCDJNH(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm KAPDHGCHDPE(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA, TTerm FPALKJKANAM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm AFNEKODFKCL(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA, TTerm IJKBDHBGLAG, TTerm MMKIEIGFJGA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PDDDFBAFKAO(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA, TTerm IBOMHLKOLJB, TTerm FFDHLLBEMJM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool CIJEIEOEOBI(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA, TOutputTerm MMKAOAJHNGJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool CFNGOLFEHDJ(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA, TOutputTerm MMKAOAJHNGJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm PBLOFHDHEBL(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA, TOutputTerm MMKAOAJHNGJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm PFHJEHDCAML(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA, TOutputTerm MMKAOAJHNGJ);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm HLEJKILHJOO(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA, TOutputTerm MMKAOAJHNGJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm OKIGCJIKDLF(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA, TOutputSubstitution HGLKNGCKOFF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm IBBJHPGMAMG(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA, TOutputSubstitution HGLKNGCKOFF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm GFMIBCHIGMB(TRoot OGEFIHKILIO, TUnification NHNMMHPMFJA, TTerm FPALKJKANAM);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct KIHADGJOHJG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CMHGHMLCKJN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300")]
	public static global::KIHADGJOHJG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> LJCGEPFBFCG()
	{
		return default(global::KIHADGJOHJG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PACIOBLAFEG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class AGNCFMLAFBG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CMHGHMLCKJN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class AOMGGJPEHIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot DFDPGOHHPEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps EJNMFKPHFIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification IHKJANFDHIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph HCHGFPOCLLA;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public OHCNHGOOJKE ANPBDMGKGDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x37D6BA0", Offset = "0x37D5FA0", VA = "0x1837D6BA0")]
				get
				{
					return default(OHCNHGOOJKE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x37D8F50", Offset = "0x37D8350", VA = "0x1837D8F50")]
			private AOMGGJPEHIA(TRoot OGEFIHKILIO, TDeps PGFIMHKNEFE, TUnification KNAENDPOHIK, TGraph DAJNAHBJHGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x37D8830", Offset = "0x37D7C30", VA = "0x1837D8830")]
			public static AOMGGJPEHIA LJCGEPFBFCG(TRoot OGEFIHKILIO, TDeps PGFIMHKNEFE, TUnification KNAENDPOHIK, TGraph DAJNAHBJHGJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x37D63C0", Offset = "0x37D57C0", VA = "0x1837D63C0")]
			public TType AACGHDBCGOH()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x37D68D0", Offset = "0x37D5CD0", VA = "0x1837D68D0")]
			public ODEFNJPDEJE<TType> AMGENGFPAGN(ODEFNJPDEJE<TType> IBOMHLKOLJB, ODEFNJPDEJE<TType> FFDHLLBEMJM)
			{
				return default(ODEFNJPDEJE<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x37D6FE0", Offset = "0x37D63E0", VA = "0x1837D6FE0")]
			public int CHLGKEMIIFI(TNode OMFNHGCDBFM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x37D7590", Offset = "0x37D6990", VA = "0x1837D7590")]
			public int ELGOEKFCLBF(TNode OMFNHGCDBFM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x37D7990", Offset = "0x37D6D90", VA = "0x1837D7990")]
			public TInput GKBLKDFODKJ(TNode OMFNHGCDBFM, int APOENOPNHBG)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x37D6C20", Offset = "0x37D6020", VA = "0x1837D6C20")]
			public int BCFOAGBOHNI(TNode OMFNHGCDBFM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x37D6D80", Offset = "0x37D6180", VA = "0x1837D6D80")]
			public TOutput BIHMCFNABCG(TNode OMFNHGCDBFM, int APOENOPNHBG)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x37D81D0", Offset = "0x37D75D0", VA = "0x1837D81D0")]
			public IEnumerable<KIFFCCLLLHL<TType>> IPIHPHFEBEI(TNode OMFNHGCDBFM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x37D8E90", Offset = "0x37D8290", VA = "0x1837D8E90")]
			public IEnumerable<DALHEAAIMOC<TNode>> PKFJDAFOPOK([In] TNode OMFNHGCDBFM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x37D7320", Offset = "0x37D6720", VA = "0x1837D7320")]
			public TType DCPEEEBNBKP(TInput CEPHEIEJHPL)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x37D8980", Offset = "0x37D7D80", VA = "0x1837D8980")]
			public int LMGCELAAFOK(TInput CEPHEIEJHPL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x37D69D0", Offset = "0x37D5DD0", VA = "0x1837D69D0")]
			public TOutput AMLEIEAJMDH(TInput CEPHEIEJHPL, int APOENOPNHBG)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x37D7BF0", Offset = "0x37D6FF0", VA = "0x1837D7BF0")]
			public TNode HFMOGFLIPBC(TInput CEPHEIEJHPL)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x37D76A0", Offset = "0x37D6AA0", VA = "0x1837D76A0")]
			public TType FNAGAKEMPHF(TOutput GOPGHHGNMKB)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x37D8420", Offset = "0x37D7820", VA = "0x1837D8420")]
			public int KBOJGDJAPGN(TOutput GOPGHHGNMKB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x37D7A80", Offset = "0x37D6E80", VA = "0x1837D7A80")]
			public TInput HCJFJFLHKMO(TOutput GOPGHHGNMKB, int APOENOPNHBG)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x37D7430", Offset = "0x37D6830", VA = "0x1837D7430")]
			public TNode DICFMBBDOHH(TOutput GOPGHHGNMKB)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x37D76F0", Offset = "0x37D6AF0", VA = "0x1837D76F0")]
			public bool GEIAEGMDCNE(TType IJFAMCPOKBO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x37D80D0", Offset = "0x37D74D0", VA = "0x1837D80D0")]
			public TType IKNKLBEKBMH(TType IJFAMCPOKBO, IEnumerable<TType> GEMGLENAPNB)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x37D6700", Offset = "0x37D5B00", VA = "0x1837D6700")]
			public void ALMMJJJIDGG(TType IJFAMCPOKBO, Action<TType> OGKMNAHHLGM, Action<TType> NFHMBJMLNBE, Action<TType> AKKCCHAGKJN, Action<TType> EAPDAPHFMOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x37D8280", Offset = "0x37D7680", VA = "0x1837D8280")]
			public TType JHFMHHPCMCP(TType IJFAMCPOKBO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x37D8010", Offset = "0x37D7410", VA = "0x1837D8010")]
			public string IIANJGOEJMI(TType IJFAMCPOKBO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x37D8580", Offset = "0x37D7980", VA = "0x1837D8580")]
			public TTerm KJKMNFCDJNH()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x37D83D0", Offset = "0x37D77D0", VA = "0x1837D83D0")]
			public TTerm KAPDHGCHDPE(TTerm FPALKJKANAM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x37D6440", Offset = "0x37D5840", VA = "0x1837D6440")]
			public TTerm AFNEKODFKCL(TTerm IJKBDHBGLAG, TTerm MMKIEIGFJGA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x37D8C60", Offset = "0x37D8060", VA = "0x1837D8C60")]
			public void PDDDFBAFKAO(TTerm IBOMHLKOLJB, TTerm FFDHLLBEMJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x37D6E40", Offset = "0x37D6240", VA = "0x1837D6E40")]
			public bool CFNGOLFEHDJ(TOutputTerm FPALKJKANAM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x37D7060", Offset = "0x37D6460", VA = "0x1837D7060")]
			public bool CIJEIEOEOBI(TOutputTerm FPALKJKANAM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x37D7250", Offset = "0x37D6650", VA = "0x1837D7250")]
			public TTerm CKMKMACJJMD(TOutputTerm MMKAOAJHNGJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x37D8D80", Offset = "0x37D8180", VA = "0x1837D8D80")]
			public TOutputTerm PFHJEHDCAML(TOutputTerm FPALKJKANAM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x37D7D60", Offset = "0x37D7160", VA = "0x1837D7D60")]
			public TOutputTerm HLEJKILHJOO(TOutputTerm FPALKJKANAM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x37D8A40", Offset = "0x37D7E40", VA = "0x1837D8A40")]
			public TTerm OKIGCJIKDLF(TOutputSubstitution ECFKCIHCLMP)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x37D7E30", Offset = "0x37D7230", VA = "0x1837D7E30")]
			public TOutputTerm IBBJHPGMAMG(TOutputSubstitution ECFKCIHCLMP)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x37D78D0", Offset = "0x37D6CD0", VA = "0x1837D78D0")]
			public TOutputTerm GFMIBCHIGMB(TTerm FPALKJKANAM)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class ECCGDGFGFON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public AOMGGJPEHIA arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public ECCGDGFGFON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3032A90", Offset = "0x3031E90", VA = "0x183032A90")]
			internal int DPCPPHNAJGA(AOMGGJPEHIA arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3032D60", Offset = "0x3032160", VA = "0x183032D60")]
			internal TInput GJHDPHCJPBB(AOMGGJPEHIA arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x3032B80", Offset = "0x3031F80", VA = "0x183032B80")]
			internal int FEBGDEMMJJO(AOMGGJPEHIA arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3032BD0", Offset = "0x3031FD0", VA = "0x183032BD0")]
			internal TOutput FEBIJMOAMOJ(AOMGGJPEHIA arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class BMDCHFODOOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public AOMGGJPEHIA arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, MELNOIPLALE<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<MELNOIPLALE<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, ODEFNJPDEJE<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public BMDCHFODOOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x484EE70", Offset = "0x484E270", VA = "0x18484EE70")]
			internal (string, TTerm) CHMOMDLMEOJ(KIFFCCLLLHL<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GMPDIIPKNDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AOMGGJPEHIA arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, ODEFNJPDEJE<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public GMPDIIPKNDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x34FAA50", Offset = "0x34F9E50", VA = "0x1834FAA50")]
			internal void BIFLCDNCDLB(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x34FA660", Offset = "0x34F9A60", VA = "0x1834FA660")]
			internal void AGMIBDEFEBP(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x34FAED0", Offset = "0x34FA2D0", VA = "0x1834FAED0")]
			internal void FAIJANIPHMB(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x34FB390", Offset = "0x34FA790", VA = "0x1834FB390")]
			internal void JMHGAMNFDJC(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ODCDFEEACMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public AOMGGJPEHIA arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public ODCDFEEACMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x36325A0", Offset = "0x36319A0", VA = "0x1836325A0")]
			internal TTerm FFGHELCNDEJ(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x348F7E0", Offset = "0x348EBE0", VA = "0x18348F7E0")]
		private static IFJBIMNJFBM AGFIMKHEPFL([CallerMemberName] string LFAIHEECJFK = "")
		{
			return default(IFJBIMNJFBM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3493E90", Offset = "0x3493290", VA = "0x183493E90")]
		public static Dictionary<TNode, List<KIFFCCLLLHL<TType>>> FALEOOGEIHN(TRoot OGEFIHKILIO, TDeps PGFIMHKNEFE, TGraph DAJNAHBJHGJ, IEnumerable<TNode> FLOHIIOGPDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x349B620", Offset = "0x349AA20", VA = "0x18349B620")]
		private static (Dictionary<TTerm, MELNOIPLALE<TNode>>, List<KeyValuePair<TTerm, ODEFNJPDEJE<TType>>>) NANIOPLMABL(IEnumerable<TNode> FLOHIIOGPDI, AOMGGJPEHIA GCCIFMALMDL)
		{
			return default((Dictionary<TTerm, MELNOIPLALE<TNode>>, List<KeyValuePair<TTerm, ODEFNJPDEJE<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x349CD40", Offset = "0x349C140", VA = "0x18349CD40")]
		private static void NNAIPFKOODC(TNode OMFNHGCDBFM, Dictionary<TInput, TTerm> IFNACECNKCB, Dictionary<TOutput, TTerm> LEEDIOGDINB, Dictionary<TTerm, MELNOIPLALE<TNode>> BKLIOIHDKPN, Dictionary<MELNOIPLALE<TNode>, TTerm> DPLFNLKDLGP, List<KeyValuePair<TTerm, ODEFNJPDEJE<TType>>> NPHJPLCPIHA, Stack<TNode> HBJPECKDNIB, List<DALHEAAIMOC<TNode>> DDKNHPFDGFA, AOMGGJPEHIA GCCIFMALMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x348FBB0", Offset = "0x348EFB0", VA = "0x18348FBB0")]
		private static Dictionary<string, TTerm> BEJIFDCOKKE(TNode OMFNHGCDBFM, Dictionary<TTerm, MELNOIPLALE<TNode>> BKLIOIHDKPN, Dictionary<MELNOIPLALE<TNode>, TTerm> EIMLPHIIEFG, List<KeyValuePair<TTerm, ODEFNJPDEJE<TType>>> NPHJPLCPIHA, AOMGGJPEHIA GCCIFMALMDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2048010", Offset = "0x2047410", VA = "0x182048010")]
		private static (TPort, TTerm)[] LPJIOJPLJDE<TPort>(TNode OMFNHGCDBFM, Func<AOMGGJPEHIA, TNode, int> KKIIKKMDGAF, Func<AOMGGJPEHIA, TNode, int, TPort> EIOGICJENAH, Func<AOMGGJPEHIA, TPort, TType> HLMGMONPODP, Dictionary<TPort, TTerm> DNNDINFBGNO, AOMGGJPEHIA GCCIFMALMDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3491840", Offset = "0x3490C40", VA = "0x183491840")]
		private static (TTerm, TTerm) DBDMJPENLGO((TOutput Output, TTerm Id)[] LGAADCPJKII, List<KeyValuePair<TTerm, ODEFNJPDEJE<TType>>> NPHJPLCPIHA, Dictionary<string, TTerm> EIMLPHIIEFG, Stack<TNode> HBJPECKDNIB, AOMGGJPEHIA GCCIFMALMDL)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x34950D0", Offset = "0x34944D0", VA = "0x1834950D0")]
		private static void FCKFCKJICPA((TInput PortKey, TTerm Id)[] IHKNHBMCJPM, TTerm BEOENHOFKCJ, TTerm MIHLEEILKCI, List<KeyValuePair<TTerm, ODEFNJPDEJE<TType>>> NPHJPLCPIHA, Dictionary<TOutput, TTerm> LEEDIOGDINB, Dictionary<string, TTerm> EIMLPHIIEFG, Stack<TNode> HBJPECKDNIB, AOMGGJPEHIA GCCIFMALMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x349E5B0", Offset = "0x349D9B0", VA = "0x18349E5B0")]
		private static TTerm OPKCPJNHMDN(TInput CEPHEIEJHPL, List<KeyValuePair<TTerm, ODEFNJPDEJE<TType>>> NPHJPLCPIHA, Dictionary<TOutput, TTerm> LEEDIOGDINB, Stack<TNode> HBJPECKDNIB, AOMGGJPEHIA GCCIFMALMDL)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3498D30", Offset = "0x3498130", VA = "0x183498D30")]
		private static TTerm LGPIJEFKNCE([In] TType IJFAMCPOKBO, IOKind DCLJLOLGABK, List<KeyValuePair<TTerm, ODEFNJPDEJE<TType>>> NPHJPLCPIHA, IReadOnlyDictionary<string, TTerm> EIMLPHIIEFG, AOMGGJPEHIA GCCIFMALMDL)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x34A3A30", Offset = "0x34A2E30", VA = "0x1834A3A30")]
		private static Dictionary<TNode, List<KIFFCCLLLHL<TType>>> PINPGAIGPDG(TOutputSubstitution[] DHEAJHNCIJE, Dictionary<TTerm, MELNOIPLALE<TNode>> BKLIOIHDKPN, IEnumerable<KeyValuePair<TTerm, ODEFNJPDEJE<TType>>> NPHJPLCPIHA, AOMGGJPEHIA GCCIFMALMDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3499760", Offset = "0x3498B60", VA = "0x183499760")]
		private static Dictionary<TNode, List<KIFFCCLLLHL<TType>>> LMBIAPLPANL(Dictionary<TTerm, MELNOIPLALE<TNode>> BKLIOIHDKPN, AOMGGJPEHIA GCCIFMALMDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3492910", Offset = "0x3491D10", VA = "0x183492910")]
		private static void EHCMPNIPDGB([In] TNode OMFNHGCDBFM, Stack<TNode> HBJPECKDNIB, List<DALHEAAIMOC<TNode>> DDKNHPFDGFA, AOMGGJPEHIA GCCIFMALMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3497DA0", Offset = "0x34971A0", VA = "0x183497DA0")]
		private static void JKCPGECFKAF(Dictionary<MELNOIPLALE<TNode>, TTerm> EIMLPHIIEFG, List<DALHEAAIMOC<TNode>> DDKNHPFDGFA, AOMGGJPEHIA GCCIFMALMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x34A0410", Offset = "0x349F810", VA = "0x1834A0410")]
		private static Dictionary<TTerm, TType> PIICLPJFFDB(Dictionary<TTerm, TOutputSubstitution> DHEAJHNCIJE, IEnumerable<KeyValuePair<TTerm, ODEFNJPDEJE<TType>>> NPHJPLCPIHA, AOMGGJPEHIA GCCIFMALMDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3496930", Offset = "0x3495D30", VA = "0x183496930")]
		private static GBADDJOKMAC<TType> HGHEJHBHCIA(TOutputTerm IJFAMCPOKBO, Dictionary<TTerm, TType> NPHJPLCPIHA, Dictionary<TTerm, TType> MKOBKFKDLMA, AOMGGJPEHIA GCCIFMALMDL)
		{
			return default(GBADDJOKMAC<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3498710", Offset = "0x3497B10", VA = "0x183498710")]
		private static TOutputTerm KODNDPIBAJG(TOutputTerm CKEFLLGJAPK, AOMGGJPEHIA GCCIFMALMDL)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x25083D0", Offset = "0x25077D0", VA = "0x1825083D0")]
	public static Dictionary<TNode, List<KIFFCCLLLHL<TType>>> FALEOOGEIHN<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::KIHADGJOHJG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> LDMHFMNLDHG, TRoot OGEFIHKILIO, TGraph DAJNAHBJHGJ, IEnumerable<TNode> FLOHIIOGPDI) where TDeps : global::CMHGHMLCKJN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct KIFFCCLLLHL<TType> : IEquatable<KIFFCCLLLHL<TType>>, EGCLJEBFBCM<KIFFCCLLLHL<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string PCDEPGOAGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType CNHEPHGCDBO;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x38DF170", Offset = "0x38DE570", VA = "0x1838DF170")]
	internal KIFFCCLLLHL(string LFAIHEECJFK, [In] TType MPNKMLEGHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x38DEF40", Offset = "0x38DE340", VA = "0x1838DEF40")]
	public bool AAEBAKABHLH([In] KIFFCCLLLHL<TType> LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x38DF010", Offset = "0x38DE410", VA = "0x1838DF010", Slot = "4")]
	public bool Equals(KIFFCCLLLHL<TType> LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x38DF060", Offset = "0x38DE460", VA = "0x1838DF060", Slot = "0")]
	public override bool Equals(object LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1CA8040", Offset = "0x1CA7440", VA = "0x181CA8040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x38DF130", Offset = "0x38DE530", VA = "0x1838DF130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x38DF0E0", Offset = "0x38DE4E0", VA = "0x1838DF0E0", Slot = "5")]
	private bool NDMNKONJLBH([In] KIFFCCLLLHL<TType> LJIBJAOOGGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MJBENCGMEON
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2478500", Offset = "0x2477900", VA = "0x182478500")]
	public static KIFFCCLLLHL<TType> LJCGEPFBFCG<TType>(string LFAIHEECJFK, TType MPNKMLEGHGD)
	{
		return default(KIFFCCLLLHL<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x24784C0", Offset = "0x24778C0", VA = "0x1824784C0")]
	public static (string, TType) DDKPKJICCAG<TType>([In] this KIFFCCLLLHL<TType> LDMHFMNLDHG)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct MELNOIPLALE<TNode> : IEquatable<MELNOIPLALE<TNode>>, EGCLJEBFBCM<MELNOIPLALE<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode OOKKFAKNCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string PCDEPGOAGDO;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAE29E0", Offset = "0xAE1DE0", VA = "0x180AE29E0")]
	internal MELNOIPLALE(TNode OMFNHGCDBFM, string LFAIHEECJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B61440", Offset = "0x3B60840", VA = "0x183B61440")]
	public bool AAEBAKABHLH([In] MELNOIPLALE<TNode> LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B61630", Offset = "0x3B60A30", VA = "0x183B61630", Slot = "4")]
	public bool Equals(MELNOIPLALE<TNode> LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38DF060", Offset = "0x38DE460", VA = "0x1838DF060", Slot = "0")]
	public override bool Equals(object LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B61680", Offset = "0x3B60A80", VA = "0x183B61680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B617D0", Offset = "0x3B60BD0", VA = "0x183B617D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3B616F0", Offset = "0x3B60AF0", VA = "0x183B616F0", Slot = "5")]
	private bool PHCDOOAONEC([In] MELNOIPLALE<TNode> LJIBJAOOGGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MEAHIMIJKMA
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x24715C0", Offset = "0x24709C0", VA = "0x1824715C0")]
	public static MELNOIPLALE<TNode> LJCGEPFBFCG<TNode>(TNode OMFNHGCDBFM, string LFAIHEECJFK)
	{
		return default(MELNOIPLALE<TNode>);
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

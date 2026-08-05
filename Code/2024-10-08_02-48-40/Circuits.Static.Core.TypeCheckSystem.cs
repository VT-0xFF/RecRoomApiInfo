using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct LIAMDHJBPNG<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType DGMPJMIJKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind BNPCHMFPAII;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F44CD0", Offset = "0x1F43ED0", VA = "0x181F44CD0")]
	internal LIAMDHJBPNG(TType EIHDAHDDDEG, IOKind DDLIPKKLPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4554CB0", Offset = "0x4553EB0", VA = "0x184554CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JAEMDAJLFBF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C1F0", Offset = "0x2E6B3F0", VA = "0x182E6C1F0")]
	public static LIAMDHJBPNG<TType> MIFIOLMMIDE<TType>(TType EIHDAHDDDEG, IOKind DDLIPKKLPCN)
	{
		return default(LIAMDHJBPNG<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C1B0", Offset = "0x2E6B3B0", VA = "0x182E6C1B0")]
	public static (TType, IOKind) EHJOEFIMJLN<TType>([In] this LIAMDHJBPNG<TType> AEFKHDNCNFD)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C140", Offset = "0x2E6B340", VA = "0x182E6C140")]
	public static void BINADAOPODH<TType>([In] this LIAMDHJBPNG<TType> AEFKHDNCNFD, [Out] TType EIHDAHDDDEG, [Out] IOKind DDLIPKKLPCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct ENJKIKBOKFP<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly BNMIIHIHIIO<TNode> JHHIHBDGAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly BNMIIHIHIIO<TNode> GOIFCDBDHNP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3AF31C0", Offset = "0x3AF23C0", VA = "0x183AF31C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CCLDCOGNGIL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D510", Offset = "0x2C1C710", VA = "0x182C1D510")]
	public static (BNMIIHIHIIO<TNode>, BNMIIHIHIIO<TNode>) EHJOEFIMJLN<TNode>([In] this ENJKIKBOKFP<TNode> AEFKHDNCNFD)
	{
		return default((BNMIIHIHIIO<TNode>, BNMIIHIHIIO<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D410", Offset = "0x2C1C610", VA = "0x182C1D410")]
	public static void BINADAOPODH<TNode>([In] this ENJKIKBOKFP<TNode> AEFKHDNCNFD, [Out] BNMIIHIHIIO<TNode> PCICJLNHPMM, [Out] BNMIIHIHIIO<TNode> OIJJJJFPNNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LMEFELNLGOE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DCEFINLNIIK EALLKLHBBKL(TRoot LPLEFLJFGNH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType GEDBKGEEBKL(TRoot LPLEFLJFGNH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LIAMDHJBPNG<TType> ADFGCAENCHC(TRoot LPLEFLJFGNH, [In] LIAMDHJBPNG<TType> ICLLFDEBJIO, [In] LIAMDHJBPNG<TType> JPMAPOMKNPF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NNGPKLLAAPH(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TNode MOPDELCEJCO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BJAKBFLHNLH(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TNode MOPDELCEJCO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput KBBEAIDLCOG(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TNode MOPDELCEJCO, int KINMHNEMPOD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int GANEGCNOHEO(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TNode MOPDELCEJCO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput LLEODEIEIDP(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TNode MOPDELCEJCO, int KINMHNEMPOD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<ABBEGLLMLNB<TType>> BBBIHNONNAJ(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TNode MOPDELCEJCO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<ENJKIKBOKFP<TNode>> MMPMHNOPIKP(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TNode MOPDELCEJCO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType DGCGFMCJKIG(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TInput GJDJIDOLBAE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int GBPOPIHJLAK(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TInput GJDJIDOLBAE);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput JNEDFNLOLJL(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TInput GJDJIDOLBAE, int KINMHNEMPOD);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode DMAOIJMFICA(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TInput GJDJIDOLBAE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType JLMNLJCOMHI(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TOutput EKGBCGOKPGJ);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int DIOOODAFKIB(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TOutput EKGBCGOKPGJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput FMABLONNNLN(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TOutput EKGBCGOKPGJ, int KINMHNEMPOD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode OOAAIHHBACK(TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, TOutput EKGBCGOKPGJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool DEAFDJCMLKN(TRoot LPLEFLJFGNH, TType EIHDAHDDDEG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType HKKBGLAMKAP(TRoot LPLEFLJFGNH, TType EIHDAHDDDEG, IEnumerable<TType> EPOHECHHJNA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EAIKHMNOOAO(TRoot LPLEFLJFGNH, TType EIHDAHDDDEG, Action<TType> LDADJLGPIJG, Action<TType> ABMEFCEGLLJ, Action<TType> KDLFHNIEFFP, Action<TType> IAPLLJNHMGA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType KKKENJEAJPL(TRoot LPLEFLJFGNH, TType EIHDAHDDDEG);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string FDEGLFJHLKD(TRoot LPLEFLJFGNH, TType EIHDAHDDDEG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification BBCGPGCHDAJ(TRoot LPLEFLJFGNH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KJEOKHCIBGM<TOutputSubstitution[], KKIKBNLICGH> GHEIGGCAJPD(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm CDGFHBCINBD(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm MOMBOKOBAEI(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL, TTerm DCHPAENALHH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm HGGLDGKJCBP(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL, TTerm GPICPIOFNKM, TTerm LJAJEPCPDJL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LLPIENONLLI(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL, TTerm ICLLFDEBJIO, TTerm JPMAPOMKNPF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool NBCKMCNFIHH(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL, TOutputTerm LACOCNLPOBA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool AKMBEHOOPJC(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL, TOutputTerm LACOCNLPOBA);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm NPCENGBFEDJ(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL, TOutputTerm LACOCNLPOBA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm KCEIJPBAIOH(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL, TOutputTerm LACOCNLPOBA);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm LICLPDPNJPC(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL, TOutputTerm LACOCNLPOBA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm MGNOFIEHGLO(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL, TOutputSubstitution MLONKOKBODH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm CKILCKEGAMA(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL, TOutputSubstitution MLONKOKBODH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm CLPAIBFOGIG(TRoot LPLEFLJFGNH, TUnification LPIBGEJMLIL, TTerm DCHPAENALHH);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct NMACCGBCIFD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::LMEFELNLGOE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80")]
	public static global::NMACCGBCIFD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> MIFIOLMMIDE()
	{
		return default(global::NMACCGBCIFD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LOPINDINNNB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class PHGBEFONFDF<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::LMEFELNLGOE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class JCHLHFCALFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot IBCOIOCGJOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps FJJPJEBEMAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification NBKFJPMCMBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph BFJCINLLGLN;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public DCEFINLNIIK GFGEEMKIKNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x43494E0", Offset = "0x43486E0", VA = "0x1843494E0")]
				get
				{
					return default(DCEFINLNIIK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x434B980", Offset = "0x434AB80", VA = "0x18434B980")]
			private JCHLHFCALFH(TRoot LPLEFLJFGNH, TDeps LJHLMAFOMCA, TUnification NKBAOACIMLB, TGraph LMEHCBGAMFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x434AFC0", Offset = "0x434A1C0", VA = "0x18434AFC0")]
			public static JCHLHFCALFH MIFIOLMMIDE(TRoot LPLEFLJFGNH, TDeps LJHLMAFOMCA, TUnification NKBAOACIMLB, TGraph LMEHCBGAMFO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x434A010", Offset = "0x4349210", VA = "0x18434A010")]
			public TType GEDBKGEEBKL()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x43490A0", Offset = "0x43482A0", VA = "0x1843490A0")]
			public LIAMDHJBPNG<TType> ADFGCAENCHC(LIAMDHJBPNG<TType> ICLLFDEBJIO, LIAMDHJBPNG<TType> JPMAPOMKNPF)
			{
				return default(LIAMDHJBPNG<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x434B560", Offset = "0x434A760", VA = "0x18434B560")]
			public int NNGPKLLAAPH(TNode MOPDELCEJCO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4349300", Offset = "0x4348500", VA = "0x184349300")]
			public int BJAKBFLHNLH(TNode MOPDELCEJCO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x434A600", Offset = "0x4349800", VA = "0x18434A600")]
			public TInput KBBEAIDLCOG(TNode MOPDELCEJCO, int KINMHNEMPOD)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4349F10", Offset = "0x4349110", VA = "0x184349F10")]
			public int GANEGCNOHEO(TNode MOPDELCEJCO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x434AB40", Offset = "0x4349D40", VA = "0x18434AB40")]
			public TOutput LLEODEIEIDP(TNode MOPDELCEJCO, int KINMHNEMPOD)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4349200", Offset = "0x4348400", VA = "0x184349200")]
			public IEnumerable<ABBEGLLMLNB<TType>> BBBIHNONNAJ(TNode MOPDELCEJCO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x434B1E0", Offset = "0x434A3E0", VA = "0x18434B1E0")]
			public IEnumerable<ENJKIKBOKFP<TNode>> MMPMHNOPIKP([In] TNode MOPDELCEJCO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4349920", Offset = "0x4348B20", VA = "0x184349920")]
			public TType DGCGFMCJKIG(TInput GJDJIDOLBAE)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x434B870", Offset = "0x434AA70", VA = "0x18434B870")]
			public int PHMDEHEBMKH(TInput GJDJIDOLBAE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x434A530", Offset = "0x4349730", VA = "0x18434A530")]
			public TOutput JNEDFNLOLJL(TInput GJDJIDOLBAE, int KINMHNEMPOD)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4349AB0", Offset = "0x4348CB0", VA = "0x184349AB0")]
			public TNode DMAOIJMFICA(TInput GJDJIDOLBAE)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x434A390", Offset = "0x4349590", VA = "0x18434A390")]
			public TType JLMNLJCOMHI(TOutput EKGBCGOKPGJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x434A910", Offset = "0x4349B10", VA = "0x18434A910")]
			public int KGMPMMJMDPL(TOutput EKGBCGOKPGJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4349EC0", Offset = "0x43490C0", VA = "0x184349EC0")]
			public TInput FMABLONNNLN(TOutput EKGBCGOKPGJ, int KINMHNEMPOD)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x434B6B0", Offset = "0x434A8B0", VA = "0x18434B6B0")]
			public TNode OOAAIHHBACK(TOutput EKGBCGOKPGJ)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x43497C0", Offset = "0x43489C0", VA = "0x1843497C0")]
			public bool DEAFDJCMLKN(TType EIHDAHDDDEG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x434A2D0", Offset = "0x43494D0", VA = "0x18434A2D0")]
			public TType HKKBGLAMKAP(TType EIHDAHDDDEG, IEnumerable<TType> EPOHECHHJNA)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4349C00", Offset = "0x4348E00", VA = "0x184349C00")]
			public void EAIKHMNOOAO(TType EIHDAHDDDEG, Action<TType> LDADJLGPIJG, Action<TType> ABMEFCEGLLJ, Action<TType> KDLFHNIEFFP, Action<TType> IAPLLJNHMGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x434AA00", Offset = "0x4349C00", VA = "0x18434AA00")]
			public TType KKKENJEAJPL(TType EIHDAHDDDEG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4349C60", Offset = "0x4348E60", VA = "0x184349C60")]
			public string FDEGLFJHLKD(TType EIHDAHDDDEG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4349510", Offset = "0x4348710", VA = "0x184349510")]
			public TTerm CDGFHBCINBD()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x434B3A0", Offset = "0x434A5A0", VA = "0x18434B3A0")]
			public TTerm MOMBOKOBAEI(TTerm DCHPAENALHH)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x434A180", Offset = "0x4349380", VA = "0x18434A180")]
			public TTerm HGGLDGKJCBP(TTerm GPICPIOFNKM, TTerm LJAJEPCPDJL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x434ADB0", Offset = "0x4349FB0", VA = "0x18434ADB0")]
			public void LLPIENONLLI(TTerm ICLLFDEBJIO, TTerm JPMAPOMKNPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4349100", Offset = "0x4348300", VA = "0x184349100")]
			public bool AKMBEHOOPJC(TOutputTerm DCHPAENALHH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x434B4A0", Offset = "0x434A6A0", VA = "0x18434B4A0")]
			public bool NBCKMCNFIHH(TOutputTerm DCHPAENALHH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x434B7B0", Offset = "0x434A9B0", VA = "0x18434B7B0")]
			public TTerm PECDGFCIDIB(TOutputTerm LACOCNLPOBA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x434A7C0", Offset = "0x43499C0", VA = "0x18434A7C0")]
			public TOutputTerm KCEIJPBAIOH(TOutputTerm DCHPAENALHH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x434AAC0", Offset = "0x4349CC0", VA = "0x18434AAC0")]
			public TOutputTerm LICLPDPNJPC(TOutputTerm DCHPAENALHH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x434ADF0", Offset = "0x4349FF0", VA = "0x18434ADF0")]
			public TTerm MGNOFIEHGLO(TOutputSubstitution MMLGNFNDHIM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4349600", Offset = "0x4348800", VA = "0x184349600")]
			public TOutputTerm CKILCKEGAMA(TOutputSubstitution MMLGNFNDHIM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x43496C0", Offset = "0x43488C0", VA = "0x1843496C0")]
			public TOutputTerm CLPAIBFOGIG(TTerm DCHPAENALHH)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class MEHBDDLHNNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public JCHLHFCALFH arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public MEHBDDLHNNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x477D380", Offset = "0x477C580", VA = "0x18477D380")]
			internal int NMKCCBLIFEB(JCHLHFCALFH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x477D3E0", Offset = "0x477C5E0", VA = "0x18477D3E0")]
			internal TInput NMLAIGGGNIK(JCHLHFCALFH arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x477D260", Offset = "0x477C460", VA = "0x18477D260")]
			internal int EPPEOJDBDMI(JCHLHFCALFH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x477D110", Offset = "0x477C310", VA = "0x18477D110")]
			internal TOutput CIMKEEGDJJJ(JCHLHFCALFH arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PAFEHIPDOJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public JCHLHFCALFH arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, BNMIIHIHIIO<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<BNMIIHIHIIO<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, LIAMDHJBPNG<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public PAFEHIPDOJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4A7A080", Offset = "0x4A79280", VA = "0x184A7A080")]
			internal (string, TTerm) LFLCMBLDBEE(ABBEGLLMLNB<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class NDFNIOBODKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public JCHLHFCALFH arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, LIAMDHJBPNG<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public NDFNIOBODKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4825980", Offset = "0x4824B80", VA = "0x184825980")]
			internal void INLMMLBOCLL(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4825500", Offset = "0x4824700", VA = "0x184825500")]
			internal void CMFBMADGPPB(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4825300", Offset = "0x4824500", VA = "0x184825300")]
			internal void BNFLPCJAMLG(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4825EC0", Offset = "0x48250C0", VA = "0x184825EC0")]
			internal void NIKMIFBBFAB(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class FMMFHKOEJMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JCHLHFCALFH arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public FMMFHKOEJMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0B90", Offset = "0x3EAFD90", VA = "0x183EB0B90")]
			internal TTerm MIAIOHOMAJA(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4A93BA0", Offset = "0x4A92DA0", VA = "0x184A93BA0")]
		private static AEIPCCBKKNC ECOKNHHNNNF([CallerMemberName] string EPPPGDEIJCI = "")
		{
			return default(AEIPCCBKKNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4A9FF90", Offset = "0x4A9F190", VA = "0x184A9FF90")]
		public static Dictionary<TNode, List<ABBEGLLMLNB<TType>>> OONFNONJPIH(TRoot LPLEFLJFGNH, TDeps LJHLMAFOMCA, TGraph LMEHCBGAMFO, IEnumerable<TNode> HJGCGMFMBNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4A951B0", Offset = "0x4A943B0", VA = "0x184A951B0")]
		private static (Dictionary<TTerm, BNMIIHIHIIO<TNode>>, List<KeyValuePair<TTerm, LIAMDHJBPNG<TType>>>) FEDLLIKLJDJ(IEnumerable<TNode> HJGCGMFMBNC, JCHLHFCALFH LFMCCJGKEKP)
		{
			return default((Dictionary<TTerm, BNMIIHIHIIO<TNode>>, List<KeyValuePair<TTerm, LIAMDHJBPNG<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4A98440", Offset = "0x4A97640", VA = "0x184A98440")]
		private static void HMEKJJCMJPC(TNode MOPDELCEJCO, Dictionary<TInput, TTerm> OKLIPLPEINE, Dictionary<TOutput, TTerm> GEJHKKCCKBJ, Dictionary<TTerm, BNMIIHIHIIO<TNode>> EMNNKPNOOEI, Dictionary<BNMIIHIHIIO<TNode>, TTerm> KDKIDPJHIAK, List<KeyValuePair<TTerm, LIAMDHJBPNG<TType>>> BEKEGIHEIGM, Stack<TNode> HFHPFLIBKJE, List<ENJKIKBOKFP<TNode>> BEJIPPHIGPE, JCHLHFCALFH LFMCCJGKEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4A91C70", Offset = "0x4A90E70", VA = "0x184A91C70")]
		private static Dictionary<string, TTerm> CBKOKPPHCKF(TNode MOPDELCEJCO, Dictionary<TTerm, BNMIIHIHIIO<TNode>> EMNNKPNOOEI, Dictionary<BNMIIHIHIIO<TNode>, TTerm> NJIKFLKFDLB, List<KeyValuePair<TTerm, LIAMDHJBPNG<TType>>> BEKEGIHEIGM, JCHLHFCALFH LFMCCJGKEKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3198F10", Offset = "0x3198110", VA = "0x183198F10")]
		private static (TPort, TTerm)[] PDCHNEEGCBD<TPort>(TNode MOPDELCEJCO, Func<JCHLHFCALFH, TNode, int> JMOAFKEFGHN, Func<JCHLHFCALFH, TNode, int, TPort> LDNLHKJJBIA, Func<JCHLHFCALFH, TPort, TType> HBKBHGMBCBC, Dictionary<TPort, TTerm> BPHKPGEABKN, JCHLHFCALFH LFMCCJGKEKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4A99A30", Offset = "0x4A98C30", VA = "0x184A99A30")]
		private static (TTerm, TTerm) LNMLIHNOFPF((TOutput Output, TTerm Id)[] LHAMIBOABAD, List<KeyValuePair<TTerm, LIAMDHJBPNG<TType>>> BEKEGIHEIGM, Dictionary<string, TTerm> NJIKFLKFDLB, Stack<TNode> HFHPFLIBKJE, JCHLHFCALFH LFMCCJGKEKP)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4A9BF30", Offset = "0x4A9B130", VA = "0x184A9BF30")]
		private static void MBHMKMBMMCM((TInput PortKey, TTerm Id)[] IKILLKMDKCN, TTerm NPHLMCCFBOL, TTerm HJKEBHPFAOO, List<KeyValuePair<TTerm, LIAMDHJBPNG<TType>>> BEKEGIHEIGM, Dictionary<TOutput, TTerm> GEJHKKCCKBJ, Dictionary<string, TTerm> NJIKFLKFDLB, Stack<TNode> HFHPFLIBKJE, JCHLHFCALFH LFMCCJGKEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4A96C30", Offset = "0x4A95E30", VA = "0x184A96C30")]
		private static TTerm HGMMILCMIHA(TInput GJDJIDOLBAE, List<KeyValuePair<TTerm, LIAMDHJBPNG<TType>>> BEKEGIHEIGM, Dictionary<TOutput, TTerm> GEJHKKCCKBJ, Stack<TNode> HFHPFLIBKJE, JCHLHFCALFH LFMCCJGKEKP)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4A96620", Offset = "0x4A95820", VA = "0x184A96620")]
		private static TTerm FNMKOHLCPDI([In] TType EIHDAHDDDEG, IOKind DDLIPKKLPCN, List<KeyValuePair<TTerm, LIAMDHJBPNG<TType>>> BEKEGIHEIGM, IReadOnlyDictionary<string, TTerm> NJIKFLKFDLB, JCHLHFCALFH LFMCCJGKEKP)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4A92280", Offset = "0x4A91480", VA = "0x184A92280")]
		private static Dictionary<TNode, List<ABBEGLLMLNB<TType>>> EBCAHCJEEEL(TOutputSubstitution[] JFDDMGFCHKO, Dictionary<TTerm, BNMIIHIHIIO<TNode>> EMNNKPNOOEI, IEnumerable<KeyValuePair<TTerm, LIAMDHJBPNG<TType>>> BEKEGIHEIGM, JCHLHFCALFH LFMCCJGKEKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4A99580", Offset = "0x4A98780", VA = "0x184A99580")]
		private static Dictionary<TNode, List<ABBEGLLMLNB<TType>>> LLBAGNPCAPB(Dictionary<TTerm, BNMIIHIHIIO<TNode>> EMNNKPNOOEI, JCHLHFCALFH LFMCCJGKEKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4A961B0", Offset = "0x4A953B0", VA = "0x184A961B0")]
		private static void FMINEKGMOCI([In] TNode MOPDELCEJCO, Stack<TNode> HFHPFLIBKJE, List<ENJKIKBOKFP<TNode>> BEJIPPHIGPE, JCHLHFCALFH LFMCCJGKEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4A93C20", Offset = "0x4A92E20", VA = "0x184A93C20")]
		private static void ELHLLPOOKMJ(Dictionary<BNMIIHIHIIO<TNode>, TTerm> NJIKFLKFDLB, List<ENJKIKBOKFP<TNode>> BEJIPPHIGPE, JCHLHFCALFH LFMCCJGKEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4A9E9E0", Offset = "0x4A9DBE0", VA = "0x184A9E9E0")]
		private static Dictionary<TTerm, TType> MMJMLHHGNND(Dictionary<TTerm, TOutputSubstitution> JFDDMGFCHKO, IEnumerable<KeyValuePair<TTerm, LIAMDHJBPNG<TType>>> BEKEGIHEIGM, JCHLHFCALFH LFMCCJGKEKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4A9B650", Offset = "0x4A9A850", VA = "0x184A9B650")]
		private static BMNACOJIPCO<TType> LOAPLODILCN(TOutputTerm EIHDAHDDDEG, Dictionary<TTerm, TType> BEKEGIHEIGM, Dictionary<TTerm, TType> MNONINFHDLB, JCHLHFCALFH LFMCCJGKEKP)
		{
			return default(BMNACOJIPCO<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4A91FA0", Offset = "0x4A911A0", VA = "0x184A91FA0")]
		private static TOutputTerm DBNJEFBIFFH(TOutputTerm LCHODBHFLCN, JCHLHFCALFH LFMCCJGKEKP)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2EF98C0", Offset = "0x2EF8AC0", VA = "0x182EF98C0")]
	public static Dictionary<TNode, List<ABBEGLLMLNB<TType>>> OONFNONJPIH<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::NMACCGBCIFD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> AEFKHDNCNFD, TRoot LPLEFLJFGNH, TGraph LMEHCBGAMFO, IEnumerable<TNode> HJGCGMFMBNC) where TDeps : global::LMEFELNLGOE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct ABBEGLLMLNB<TType> : IEquatable<ABBEGLLMLNB<TType>>, OKLAGBJBBOM<ABBEGLLMLNB<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string HPIOEFIINLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType DOOELMFJAEK;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3F006A0", Offset = "0x3EFF8A0", VA = "0x183F006A0")]
	internal ABBEGLLMLNB(string EPPPGDEIJCI, [In] TType NOICBIFMAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3F00580", Offset = "0x3EFF780", VA = "0x183F00580")]
	public bool NFOFFGFCKAM([In] ABBEGLLMLNB<TType> KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3F004E0", Offset = "0x3EFF6E0", VA = "0x183F004E0", Slot = "4")]
	public bool Equals(ABBEGLLMLNB<TType> KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF920", Offset = "0x3ADEB20", VA = "0x183ADF920", Slot = "0")]
	public override bool Equals(object KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2256AB0", Offset = "0x2255CB0", VA = "0x182256AB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3F00660", Offset = "0x3EFF860", VA = "0x183F00660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3F00530", Offset = "0x3EFF730", VA = "0x183F00530", Slot = "5")]
	private bool MNELPOLJKMO([In] ABBEGLLMLNB<TType> KDHPJMADEAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BLCGOJBAHHA
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC650", Offset = "0x2BAB850", VA = "0x182BAC650")]
	public static ABBEGLLMLNB<TType> MIFIOLMMIDE<TType>(string EPPPGDEIJCI, TType NOICBIFMAOP)
	{
		return default(ABBEGLLMLNB<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC610", Offset = "0x2BAB810", VA = "0x182BAC610")]
	public static (string, TType) EHJOEFIMJLN<TType>([In] this ABBEGLLMLNB<TType> AEFKHDNCNFD)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct BNMIIHIHIIO<TNode> : IEquatable<BNMIIHIHIIO<TNode>>, OKLAGBJBBOM<BNMIIHIHIIO<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode HNNALMMBIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string HPIOEFIINLC;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1070F90", Offset = "0x1070190", VA = "0x181070F90")]
	internal BNMIIHIHIIO(TNode MOPDELCEJCO, string EPPPGDEIJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x52EF200", Offset = "0x52EE400", VA = "0x1852EF200")]
	public bool NFOFFGFCKAM([In] BNMIIHIHIIO<TNode> KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x52EEF70", Offset = "0x52EE170", VA = "0x1852EEF70", Slot = "4")]
	public bool Equals(BNMIIHIHIIO<TNode> KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF920", Offset = "0x3ADEB20", VA = "0x183ADF920", Slot = "0")]
	public override bool Equals(object KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x52EF010", Offset = "0x52EE210", VA = "0x1852EF010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x52EF2E0", Offset = "0x52EE4E0", VA = "0x1852EF2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x52EF080", Offset = "0x52EE280", VA = "0x1852EF080", Slot = "5")]
	private bool IKLGFOKLIEI([In] BNMIIHIHIIO<TNode> KDHPJMADEAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FAHCCLJPODI
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2DF9F40", Offset = "0x2DF9140", VA = "0x182DF9F40")]
	public static BNMIIHIHIIO<TNode> MIFIOLMMIDE<TNode>(TNode MOPDELCEJCO, string EPPPGDEIJCI)
	{
		return default(BNMIIHIHIIO<TNode>);
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

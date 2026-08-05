using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Utilities;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct GNLOOIIPLPM<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType CMCPPDDMLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind DPFKPOECPKM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xDEFB60", Offset = "0xDEE960", VA = "0x180DEFB60")]
	internal GNLOOIIPLPM(TType IGEIBCJNCHF, IOKind OJLBHBFPFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x477AEB0", Offset = "0x4779CB0", VA = "0x18477AEB0")]
	public void KONCNEDHOLC(out TType IGEIBCJNCHF, out IOKind OJLBHBFPFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x477AEE0", Offset = "0x4779CE0", VA = "0x18477AEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GICFHPIMHMF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3A1D4E0", Offset = "0x3A1C2E0", VA = "0x183A1D4E0")]
	public static global::GNLOOIIPLPM<TType> DHGKFEMNGCO<TType>(TType IGEIBCJNCHF, IOKind OJLBHBFPFHN)
	{
		return default(global::GNLOOIIPLPM<TType>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct EGFOKMOJNKK<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly global::GFGHCGDNGKM<TNode> NKGMKFCONIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly global::GFGHCGDNGKM<TNode> FCHBAIJIGPG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D83180", Offset = "0x3D81F80", VA = "0x183D83180")]
	public void KONCNEDHOLC(out global::GFGHCGDNGKM<TNode> LKPNMPOCKEL, out global::GFGHCGDNGKM<TNode> JJHFBCIJNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D832B0", Offset = "0x3D820B0", VA = "0x183D832B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HEKFJCACNKI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AICOOGMCGFE NOKHMLDKPLG(TRoot JMLKLPJONJN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType EKKJAMDPHAF(TRoot JMLKLPJONJN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::GNLOOIIPLPM<TType> FKEPDPICCHJ(TRoot JMLKLPJONJN, in global::GNLOOIIPLPM<TType> JCHPGJLCOCJ, in global::GNLOOIIPLPM<TType> GHMOJHOMMOK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IECFMBHEOOP(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TNode ABKPGPJAFGM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int EBPEHBHNMDF(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TNode ABKPGPJAFGM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput CEFBMFMPPHM(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TNode ABKPGPJAFGM, int NPDGHPHAKDK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NMAAFBALEDB(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TNode ABKPGPJAFGM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput JEKGGJKGBOC(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TNode ABKPGPJAFGM, int NPDGHPHAKDK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<global::POIJLGADGHJ<TType>> HINMHBBBLBI(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TNode ABKPGPJAFGM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<global::EGFOKMOJNKK<TNode>> GJGBLFOFFJL(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TNode ABKPGPJAFGM);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType FAALLAMBBNJ(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TInput GIEOCCOFGEG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int CANHDOOCCJI(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TInput GIEOCCOFGEG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput KLKDPKGAMMD(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TInput GIEOCCOFGEG, int NPDGHPHAKDK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode GKCMLHMMCJN(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TInput GIEOCCOFGEG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType MDBCJLDCNHC(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TOutput DFKELFPKPFG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int MIPLICDENIB(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TOutput DFKELFPKPFG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput MKHLHJAAGMN(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TOutput DFKELFPKPFG, int NPDGHPHAKDK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode MFPKHOCLKHB(TRoot JMLKLPJONJN, TGraph CCICHMPIDIO, TOutput DFKELFPKPFG);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MNMACKAPFMI(TRoot JMLKLPJONJN, TType IGEIBCJNCHF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType HMILGGDPCHC(TRoot JMLKLPJONJN, TType IGEIBCJNCHF, IEnumerable<TType> MOELJOHPLBF);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LBKGLLGDFHJ(TRoot JMLKLPJONJN, TType IGEIBCJNCHF, Action<TType> CNGDFALEIOD, Action<TType> GCDHDNFEJPC, Action<TType> JKHCKEJNGNH, Action<TType> ALLIGJIPAHH);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType CAPJGOABNBE(TRoot JMLKLPJONJN, TType IGEIBCJNCHF);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string FKCANMJELJK(TRoot JMLKLPJONJN, TType IGEIBCJNCHF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification MGECLJKHOIB(TRoot JMLKLPJONJN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	global::CIOEKKBILIB<TOutputSubstitution[], AAHLPJGCFPM> FPGHFGKGDBB(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm KNEFBMCGOFJ(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm FENBAJBNIDI(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK, TTerm ANBKMEHEPHF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm BBNMLPKEELH(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK, TTerm LLJOHLBBLLB, TTerm FOPGHCLMOAD);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AGFOOJLDOBP(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK, TTerm JCHPGJLCOCJ, TTerm GHMOJHOMMOK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool HBPNMHKNIKL(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK, TOutputTerm BLHHOELACME);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool ADEGELGNPAH(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK, TOutputTerm BLHHOELACME);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm OJPNDAAAGLB(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK, TOutputTerm BLHHOELACME);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm FEIGOKCHIFC(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK, TOutputTerm BLHHOELACME);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm JBCLMJOGBDC(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK, TOutputTerm BLHHOELACME);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm KECKFDJJPEL(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK, TOutputSubstitution CFILIIPJGEC);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm DDCNDIAHCKN(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK, TOutputSubstitution CFILIIPJGEC);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm MIOBAGJKLOC(TRoot JMLKLPJONJN, TUnification AKMBICPEBLK, TTerm ANBKMEHEPHF);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct FBCBIOHEMHG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HEKFJCACNKI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00")]
	public static global::FBCBIOHEMHG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> DHGKFEMNGCO()
	{
		return default(global::FBCBIOHEMHG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HBKKLKOOOPA
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private static class MOACHKMIBDO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HEKFJCACNKI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private sealed class MBDALOILLEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot GHOIKAHCODP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps PPNEKNCPEMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification AOBIINIBKGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph HCPHIHNGIPH;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public AICOOGMCGFE BEPDJPMPPFJ
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x4009830", Offset = "0x4008630", VA = "0x184009830")]
				get
				{
					return default(AICOOGMCGFE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x400AFD0", Offset = "0x4009DD0", VA = "0x18400AFD0")]
			private MBDALOILLEM(TRoot JMLKLPJONJN, TDeps GODJKHDKJCI, TUnification KGDFDINKACH, TGraph CCICHMPIDIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4009650", Offset = "0x4008450", VA = "0x184009650")]
			public static MBDALOILLEM DHGKFEMNGCO(TRoot JMLKLPJONJN, TDeps GODJKHDKJCI, TUnification KGDFDINKACH, TGraph CCICHMPIDIO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4009A50", Offset = "0x4008850", VA = "0x184009A50")]
			public TType EKKJAMDPHAF()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4009DD0", Offset = "0x4008BD0", VA = "0x184009DD0")]
			public global::GNLOOIIPLPM<TType> FKEPDPICCHJ(global::GNLOOIIPLPM<TType> JCHPGJLCOCJ, global::GNLOOIIPLPM<TType> GHMOJHOMMOK)
			{
				return default(global::GNLOOIIPLPM<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x400A530", Offset = "0x4009330", VA = "0x18400A530")]
			public int IECFMBHEOOP(TNode ABKPGPJAFGM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4009920", Offset = "0x4008720", VA = "0x184009920")]
			public int EBPEHBHNMDF(TNode ABKPGPJAFGM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4009540", Offset = "0x4008340", VA = "0x184009540")]
			public TInput CEFBMFMPPHM(TNode ABKPGPJAFGM, int NPDGHPHAKDK)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x400AF10", Offset = "0x4009D10", VA = "0x18400AF10")]
			public int NMAAFBALEDB(TNode ABKPGPJAFGM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x400A6B0", Offset = "0x40094B0", VA = "0x18400A6B0")]
			public TOutput JEKGGJKGBOC(TNode ABKPGPJAFGM, int NPDGHPHAKDK)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x400A320", Offset = "0x4009120", VA = "0x18400A320")]
			public IEnumerable<global::POIJLGADGHJ<TType>> HINMHBBBLBI(TNode ABKPGPJAFGM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x400A0D0", Offset = "0x4008ED0", VA = "0x18400A0D0")]
			public IEnumerable<global::EGFOKMOJNKK<TNode>> GJGBLFOFFJL(in TNode ABKPGPJAFGM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4009A80", Offset = "0x4008880", VA = "0x184009A80")]
			public TType FAALLAMBBNJ(TInput GIEOCCOFGEG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4009FC0", Offset = "0x4008DC0", VA = "0x184009FC0")]
			public int FOBFHAIFHKE(TInput GIEOCCOFGEG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x400A910", Offset = "0x4009710", VA = "0x18400A910")]
			public TOutput KLKDPKGAMMD(TInput GIEOCCOFGEG, int NPDGHPHAKDK)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x400A220", Offset = "0x4009020", VA = "0x18400A220")]
			public TNode GKCMLHMMCJN(TInput GIEOCCOFGEG)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4009A80", Offset = "0x4008880", VA = "0x184009A80")]
			public TType MDBCJLDCNHC(TOutput DFKELFPKPFG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x400A000", Offset = "0x4008E00", VA = "0x18400A000")]
			public int GFOBBFNBBJO(TOutput DFKELFPKPFG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x400AD70", Offset = "0x4009B70", VA = "0x18400AD70")]
			public TInput MKHLHJAAGMN(TOutput DFKELFPKPFG, int NPDGHPHAKDK)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x400A220", Offset = "0x4009020", VA = "0x18400A220")]
			public TNode MFPKHOCLKHB(TOutput DFKELFPKPFG)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x400AEE0", Offset = "0x4009CE0", VA = "0x18400AEE0")]
			public bool MNMACKAPFMI(TType IGEIBCJNCHF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x400A3E0", Offset = "0x40091E0", VA = "0x18400A3E0")]
			public TType HMILGGDPCHC(TType IGEIBCJNCHF, IEnumerable<TType> MOELJOHPLBF)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x400AB40", Offset = "0x4009940", VA = "0x18400AB40")]
			public void LBKGLLGDFHJ(TType IGEIBCJNCHF, Action<TType> CNGDFALEIOD, Action<TType> GCDHDNFEJPC, Action<TType> JKHCKEJNGNH, Action<TType> ALLIGJIPAHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4009400", Offset = "0x4008200", VA = "0x184009400")]
			public TType CAPJGOABNBE(TType IGEIBCJNCHF)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4009CD0", Offset = "0x4008AD0", VA = "0x184009CD0")]
			public string FKCANMJELJK(TType IGEIBCJNCHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x400A9F0", Offset = "0x40097F0", VA = "0x18400A9F0")]
			public TTerm KNEFBMCGOFJ()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4009CA0", Offset = "0x4008AA0", VA = "0x184009CA0")]
			public TTerm FENBAJBNIDI(TTerm ANBKMEHEPHF)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x40092D0", Offset = "0x40080D0", VA = "0x1840092D0")]
			public TTerm BBNMLPKEELH(TTerm LLJOHLBBLLB, TTerm FOPGHCLMOAD)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x40091A0", Offset = "0x4007FA0", VA = "0x1840091A0")]
			public void AGFOOJLDOBP(TTerm JCHPGJLCOCJ, TTerm GHMOJHOMMOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4009170", Offset = "0x4007F70", VA = "0x184009170")]
			public bool ADEGELGNPAH(TOutputTerm ANBKMEHEPHF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x400A260", Offset = "0x4009060", VA = "0x18400A260")]
			public bool HBPNMHKNIKL(TOutputTerm ANBKMEHEPHF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x400A850", Offset = "0x4009650", VA = "0x18400A850")]
			public TTerm KJLBEELLKGN(TOutputTerm BLHHOELACME)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4009B50", Offset = "0x4008950", VA = "0x184009B50")]
			public TOutputTerm FEIGOKCHIFC(TOutputTerm ANBKMEHEPHF)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x400A560", Offset = "0x4009360", VA = "0x18400A560")]
			public TOutputTerm JBCLMJOGBDC(TOutputTerm ANBKMEHEPHF)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x400A700", Offset = "0x4009500", VA = "0x18400A700")]
			public TTerm KECKFDJJPEL(TOutputSubstitution PCKNJCPNLFD)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4009620", Offset = "0x4008420", VA = "0x184009620")]
			public TOutputTerm DDCNDIAHCKN(TOutputSubstitution PCKNJCPNLFD)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x400AD40", Offset = "0x4009B40", VA = "0x18400AD40")]
			public TOutputTerm MIOBAGJKLOC(TTerm ANBKMEHEPHF)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class GDBOKPPCHLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public MBDALOILLEM arg;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
			public GDBOKPPCHLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x45000F0", Offset = "0x44FEEF0", VA = "0x1845000F0")]
			internal int <GenerateConstraintsForNode>b__0(MBDALOILLEM arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x45EDD00", Offset = "0x45ECB00", VA = "0x1845EDD00")]
			internal TInput <GenerateConstraintsForNode>b__1(MBDALOILLEM arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x45EDDA0", Offset = "0x45ECBA0", VA = "0x1845EDDA0")]
			internal int <GenerateConstraintsForNode>b__3(MBDALOILLEM arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x45EDE20", Offset = "0x45ECC20", VA = "0x1845EDE20")]
			internal TOutput <GenerateConstraintsForNode>b__4(MBDALOILLEM arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class KDFBBBDHNAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public MBDALOILLEM arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, global::GFGHCGDNGKM<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<global::GFGHCGDNGKM<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, global::GNLOOIIPLPM<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
			public KDFBBBDHNAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x431D280", Offset = "0x431C080", VA = "0x18431D280")]
			internal (string, TTerm) <IdentifyTypeParameters>b__0(global::POIJLGADGHJ<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HKLCICHNENJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public MBDALOILLEM arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, global::GNLOOIIPLPM<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
			public HKLCICHNENJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x508E700", Offset = "0x508D500", VA = "0x18508E700")]
			internal void <GetTypeUnificationTerm>b__0(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x508EC40", Offset = "0x508DA40", VA = "0x18508EC40")]
			internal void <GetTypeUnificationTerm>b__1(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x508EF70", Offset = "0x508DD70", VA = "0x18508EF70")]
			internal void <GetTypeUnificationTerm>b__2(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x508F0D0", Offset = "0x508DED0", VA = "0x18508F0D0")]
			internal void <GetTypeUnificationTerm>b__3(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class JEAKECAIIIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public MBDALOILLEM arg;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
			public JEAKECAIIIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3B1A2C0", Offset = "0x3B190C0", VA = "0x183B1A2C0")]
			internal TTerm <GetTypeParameterAssignments>b__1(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x382C0D0", Offset = "0x382AED0", VA = "0x18382C0D0")]
		private static PINJGMNEJPA DNCJKFPJLBC([CallerMemberName] string IADPDEAGFAB = "")
		{
			return default(PINJGMNEJPA);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3837870", Offset = "0x3836670", VA = "0x183837870")]
		public static Dictionary<TNode, List<global::POIJLGADGHJ<TType>>> OIDDLBLEPIJ(TRoot JMLKLPJONJN, TDeps GODJKHDKJCI, TGraph CCICHMPIDIO, IEnumerable<TNode> GCCLBHFGCCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x382E220", Offset = "0x382D020", VA = "0x18382E220")]
		private static (Dictionary<TTerm, global::GFGHCGDNGKM<TNode>>, List<KeyValuePair<TTerm, global::GNLOOIIPLPM<TType>>>) EDGNPELFDDK(IEnumerable<TNode> GCCLBHFGCCN, MBDALOILLEM JCKDEHJPDNC)
		{
			return default((Dictionary<TTerm, global::GFGHCGDNGKM<TNode>>, List<KeyValuePair<TTerm, global::GNLOOIIPLPM<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x38305E0", Offset = "0x382F3E0", VA = "0x1838305E0")]
		private static void FLHDMFEHKMB(TNode ABKPGPJAFGM, Dictionary<TInput, TTerm> OBEHCDPCBME, Dictionary<TOutput, TTerm> DJPFDBCINNE, Dictionary<TTerm, global::GFGHCGDNGKM<TNode>> AMDKGNGGLAD, Dictionary<global::GFGHCGDNGKM<TNode>, TTerm> PDHGMHJNIAC, List<KeyValuePair<TTerm, global::GNLOOIIPLPM<TType>>> ECHKDKBFMGE, Stack<TNode> OPHMGPCEJDI, List<global::EGFOKMOJNKK<TNode>> JDGKMOPFACN, MBDALOILLEM JCKDEHJPDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3834EA0", Offset = "0x3833CA0", VA = "0x183834EA0")]
		private static Dictionary<string, TTerm> JHIIFCMLCBB(TNode ABKPGPJAFGM, Dictionary<TTerm, global::GFGHCGDNGKM<TNode>> AMDKGNGGLAD, Dictionary<global::GFGHCGDNGKM<TNode>, TTerm> MCFHLGBLBAE, List<KeyValuePair<TTerm, global::GNLOOIIPLPM<TType>>> ECHKDKBFMGE, MBDALOILLEM JCKDEHJPDNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2F71380", Offset = "0x2F70180", VA = "0x182F71380")]
		private static (TPort, TTerm)[] JDMLBEPFAGI<TPort>(TNode ABKPGPJAFGM, Func<MBDALOILLEM, TNode, int> BICIAKIMFHN, Func<MBDALOILLEM, TNode, int, TPort> NCLKMHBFKOD, Func<MBDALOILLEM, TPort, TType> BAEOIPMMAJJ, Dictionary<TPort, TTerm> FGFOOGLJNDG, MBDALOILLEM JCKDEHJPDNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x382AB00", Offset = "0x3829900", VA = "0x18382AB00")]
		private static (TTerm, TTerm) AEPEELIBLLL((TOutput Output, TTerm Id)[] FJGIFHEDEGA, List<KeyValuePair<TTerm, global::GNLOOIIPLPM<TType>>> ECHKDKBFMGE, Dictionary<string, TTerm> MCFHLGBLBAE, Stack<TNode> OPHMGPCEJDI, MBDALOILLEM JCKDEHJPDNC)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x382C970", Offset = "0x382B770", VA = "0x18382C970")]
		private static void ECEACFJMDAB((TInput PortKey, TTerm Id)[] KFCHPFPIFMM, TTerm NEDOJHAHKCD, TTerm LCLMALMEBPM, List<KeyValuePair<TTerm, global::GNLOOIIPLPM<TType>>> ECHKDKBFMGE, Dictionary<TOutput, TTerm> DJPFDBCINNE, Dictionary<string, TTerm> MCFHLGBLBAE, Stack<TNode> OPHMGPCEJDI, MBDALOILLEM JCKDEHJPDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x382F7E0", Offset = "0x382E5E0", VA = "0x18382F7E0")]
		private static TTerm EEFELDEGGLA(TInput GIEOCCOFGEG, List<KeyValuePair<TTerm, global::GNLOOIIPLPM<TType>>> ECHKDKBFMGE, Dictionary<TOutput, TTerm> DJPFDBCINNE, Stack<TNode> OPHMGPCEJDI, MBDALOILLEM JCKDEHJPDNC)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3833210", Offset = "0x3832010", VA = "0x183833210")]
		private static TTerm IMAANFNBAEF(in TType IGEIBCJNCHF, IOKind OJLBHBFPFHN, List<KeyValuePair<TTerm, global::GNLOOIIPLPM<TType>>> ECHKDKBFMGE, IReadOnlyDictionary<string, TTerm> MCFHLGBLBAE, MBDALOILLEM JCKDEHJPDNC)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3834330", Offset = "0x3833130", VA = "0x183834330")]
		private static Dictionary<TNode, List<global::POIJLGADGHJ<TType>>> JHALEAGHIMH(TOutputSubstitution[] MOJNELIONAA, Dictionary<TTerm, global::GFGHCGDNGKM<TNode>> AMDKGNGGLAD, IEnumerable<KeyValuePair<TTerm, global::GNLOOIIPLPM<TType>>> ECHKDKBFMGE, MBDALOILLEM JCKDEHJPDNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x382C560", Offset = "0x382B360", VA = "0x18382C560")]
		private static Dictionary<TNode, List<global::POIJLGADGHJ<TType>>> DPFKKIEGFNP(Dictionary<TTerm, global::GFGHCGDNGKM<TNode>> AMDKGNGGLAD, MBDALOILLEM JCKDEHJPDNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x38374B0", Offset = "0x38362B0", VA = "0x1838374B0")]
		private static void LEIHMNPPNKG(in TNode ABKPGPJAFGM, Stack<TNode> OPHMGPCEJDI, List<global::EGFOKMOJNKK<TNode>> JDGKMOPFACN, MBDALOILLEM JCKDEHJPDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x382BC70", Offset = "0x382AA70", VA = "0x18382BC70")]
		private static void CADJMCLHDPN(Dictionary<global::GFGHCGDNGKM<TNode>, TTerm> MCFHLGBLBAE, List<global::EGFOKMOJNKK<TNode>> JDGKMOPFACN, MBDALOILLEM JCKDEHJPDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3836150", Offset = "0x3834F50", VA = "0x183836150")]
		private static Dictionary<TTerm, TType> KGIMEGKPJOL(Dictionary<TTerm, TOutputSubstitution> MOJNELIONAA, IEnumerable<KeyValuePair<TTerm, global::GNLOOIIPLPM<TType>>> ECHKDKBFMGE, MBDALOILLEM JCKDEHJPDNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3832060", Offset = "0x3830E60", VA = "0x183832060")]
		private static global::GEAFEOEEKFP<TType> GJMLKHLHKMN(TOutputTerm IGEIBCJNCHF, Dictionary<TTerm, TType> ECHKDKBFMGE, Dictionary<TTerm, TType> KEJPIFGMADN, MBDALOILLEM JCKDEHJPDNC)
		{
			return default(global::GEAFEOEEKFP<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3830230", Offset = "0x382F030", VA = "0x183830230")]
		private static TOutputTerm EKMEFDBLLBL(TOutputTerm MNPCOBAHLNK, MBDALOILLEM JCKDEHJPDNC)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A100", Offset = "0x3A28F00", VA = "0x183A2A100")]
	public static Dictionary<TNode, List<global::POIJLGADGHJ<TType>>> OIDDLBLEPIJ<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>(in global::FBCBIOHEMHG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> BLHHJNENDMO, TRoot JMLKLPJONJN, TDeps GODJKHDKJCI, TGraph CCICHMPIDIO, IEnumerable<TNode> GCCLBHFGCCN) where TDeps : global::HEKFJCACNKI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct POIJLGADGHJ<TType> : IEquatable<global::POIJLGADGHJ<TType>>, global::JPJCEIEIHHO<global::POIJLGADGHJ<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ADMEEJPABPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType LECBNPAHLCO;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3A54610", Offset = "0x3A53410", VA = "0x183A54610")]
	internal POIJLGADGHJ(string IADPDEAGFAB, in TType NFPAANIOGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3A54350", Offset = "0x3A53150", VA = "0x183A54350")]
	public bool AFCKBDHDODL(in global::POIJLGADGHJ<TType> KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3A54530", Offset = "0x3A53330", VA = "0x183A54530", Slot = "4")]
	public bool Equals(global::POIJLGADGHJ<TType> KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3A544A0", Offset = "0x3A532A0", VA = "0x183A544A0", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xDAC560", Offset = "0xDAB360", VA = "0x180DAC560", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3A545D0", Offset = "0x3A533D0", VA = "0x183A545D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3A54430", Offset = "0x3A53230", VA = "0x183A54430")]
	public (string, TType) EEDJLONFEOD()
	{
		return default((string, TType));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3A54580", Offset = "0x3A53380", VA = "0x183A54580", Slot = "5")]
	private bool MHAMMHFHEBM(in global::POIJLGADGHJ<TType> KICLNADFIEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JFBOPFBBJMG
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3FB7FA0", Offset = "0x3FB6DA0", VA = "0x183FB7FA0")]
	public static global::POIJLGADGHJ<TType> DHGKFEMNGCO<TType>(string IADPDEAGFAB, TType NFPAANIOGGN)
	{
		return default(global::POIJLGADGHJ<TType>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GFGHCGDNGKM<TNode> : IEquatable<global::GFGHCGDNGKM<TNode>>, global::JPJCEIEIHHO<global::GFGHCGDNGKM<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode HJEOADKLLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string ADMEEJPABPA;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xB49000", Offset = "0xB47E00", VA = "0x180B49000")]
	internal GFGHCGDNGKM(TNode ABKPGPJAFGM, string IADPDEAGFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4289FF0", Offset = "0x4288DF0", VA = "0x184289FF0")]
	public bool AFCKBDHDODL(in global::GFGHCGDNGKM<TNode> KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x428A200", Offset = "0x4289000", VA = "0x18428A200", Slot = "4")]
	public bool Equals(global::GFGHCGDNGKM<TNode> KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3A544A0", Offset = "0x3A532A0", VA = "0x183A544A0", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x428A2F0", Offset = "0x42890F0", VA = "0x18428A2F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x428A3C0", Offset = "0x42891C0", VA = "0x18428A3C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x428A2A0", Offset = "0x42890A0", VA = "0x18428A2A0", Slot = "5")]
	private bool FKCDFHPEJPP(in global::GFGHCGDNGKM<TNode> KICLNADFIEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CLOBAOKFDBP
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x37A3450", Offset = "0x37A2250", VA = "0x1837A3450")]
	public static global::GFGHCGDNGKM<TNode> DHGKFEMNGCO<TNode>(TNode ABKPGPJAFGM, string IADPDEAGFAB)
	{
		return default(global::GFGHCGDNGKM<TNode>);
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

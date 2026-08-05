using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Foundation;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JFFKJBIOAKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GPPMOHAANAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FLIGFJKPJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	FNAEIBBBBBE FJFMINOOJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int JAFFPMLLMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GBOMBBGKIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GJMLAGIENDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NJDBOINPCMI;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BCKGIDDFJND();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HLHCMEABLOF(object MFKHKDDANII, bool KKMLACEOGNI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IBKOOAPFHBH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GMPCDFILNOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string PHLFNBHNCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool MFNKIKPGNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DHEKJNOFONA<T> : GMPCDFILNOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T DOALEALIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMEFODCKIFJ(T FCPDBBAAIEF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class ANIGAAGFKEA<T> : DHEKJNOFONA<T>, GMPCDFILNOM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly IEJEGKIFFLB<T> ACFPOEBGLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly IEJEGKIFFLB<T> JGCIEDFFEBH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string PHLFNBHNCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xFA7D10", Offset = "0xFA6710", VA = "0x180FA7D10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BAPAIIMDKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x54DDBB0", Offset = "0x54DC5B0", VA = "0x1854DDBB0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T GOIDDCDMPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x54DE180", Offset = "0x54DCB80", VA = "0x1854DE180", Slot = "11")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x54DD140", Offset = "0x54DBB40", VA = "0x1854DD140", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T DOALEALIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x54DCF90", Offset = "0x54DB990", VA = "0x1854DCF90", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x54DCFE0", Offset = "0x54DB9E0", VA = "0x1854DCFE0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x54DCF90", Offset = "0x54DB990", VA = "0x1854DCF90")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x54DE7A0", Offset = "0x54DD1A0", VA = "0x1854DE7A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MFNKIKPGNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x460A020", Offset = "0x4608A20", VA = "0x18460A020", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4609DD0", Offset = "0x46087D0", VA = "0x184609DD0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DGEAHJMLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x54DD120", Offset = "0x54DBB20", VA = "0x1854DD120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x54DE250", Offset = "0x54DCC50", VA = "0x1854DE250", Slot = "10")]
	public void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x54DED90", Offset = "0x54DD790", VA = "0x1854DED90")]
	public ANIGAAGFKEA([In] KCBJFMGBHLK BLPDDGCLNPE, T LOOGMANDIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x54DD6F0", Offset = "0x54DC0F0", VA = "0x1854DD6F0")]
	private void JLJKNKILIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x54DE640", Offset = "0x54DD040", VA = "0x1854DE640", Slot = "5")]
	public void OMEFODCKIFJ(T FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x54DE4C0", Offset = "0x54DCEC0", VA = "0x1854DE4C0")]
	public void OMEFODCKIFJ(T FCPDBBAAIEF, bool FEANEIIACPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4609780", Offset = "0x4608180", VA = "0x184609780", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class OCPNIJGPFMM<T1, T2> : DHEKJNOFONA<(T1, T2)>, GMPCDFILNOM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly OKNGBMEOAAC<T1, T2> ACFPOEBGLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly OKNGBMEOAAC<T1, T2> JGCIEDFFEBH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string PHLFNBHNCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xFA7D10", Offset = "0xFA6710", VA = "0x180FA7D10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BAPAIIMDKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5B9EF30", Offset = "0x5B9D930", VA = "0x185B9EF30", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BPBOABCOGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5B9F4D0", Offset = "0x5B9DED0", VA = "0x185B9F4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool KODJFKJMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5B9E5B0", Offset = "0x5B9CFB0", VA = "0x185B9E5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public (T1, T2) GOIDDCDMPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5B9F100", Offset = "0x5B9DB00", VA = "0x185B9F100", Slot = "11")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5B9E960", Offset = "0x5B9D360", VA = "0x185B9E960", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public (T1, T2) DOALEALIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5B9E880", Offset = "0x5B9D280", VA = "0x185B9E880", Slot = "4")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5B9E520", Offset = "0x5B9CF20", VA = "0x185B9E520", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public (T1, T2) AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5B9E4D0", Offset = "0x5B9CED0", VA = "0x185B9E4D0")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5B9F940", Offset = "0x5B9E340", VA = "0x185B9F940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T1 HAOGNLGPEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5B9EB40", Offset = "0x5B9D540", VA = "0x185B9EB40")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B9EC00", Offset = "0x5B9D600", VA = "0x185B9EC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T1 HAEAJGDCPMC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5B9EE00", Offset = "0x5B9D800", VA = "0x185B9EE00")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T1 CIPDKLICKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B9EE00", Offset = "0x5B9D800", VA = "0x185B9EE00")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5B9E7A0", Offset = "0x5B9D1A0", VA = "0x185B9E7A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T2 NHHPBGCJINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5B9F7D0", Offset = "0x5B9E1D0", VA = "0x185B9F7D0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5B9F2C0", Offset = "0x5B9DCC0", VA = "0x185B9F2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T2 CGCPHMKBGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5B9F1E0", Offset = "0x5B9DBE0", VA = "0x185B9F1E0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T2 FHOHEFDNCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5B9F1E0", Offset = "0x5B9DBE0", VA = "0x185B9F1E0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5B9F270", Offset = "0x5B9DC70", VA = "0x185B9F270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MFNKIKPGNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x460A020", Offset = "0x4608A20", VA = "0x18460A020", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4609DD0", Offset = "0x46087D0", VA = "0x184609DD0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5B9F5C0", Offset = "0x5B9DFC0", VA = "0x185B9F5C0", Slot = "10")]
	public void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5B9FBA0", Offset = "0x5B9E5A0", VA = "0x185B9FBA0")]
	public OCPNIJGPFMM([In] KCBJFMGBHLK BLPDDGCLNPE, T1 KBFPPJOIJKN, T2 KBKBBFPJKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5B9ED40", Offset = "0x5B9D740", VA = "0x185B9ED40")]
	private void JLJKNKILIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5B9F6A0", Offset = "0x5B9E0A0", VA = "0x185B9F6A0")]
	public void OIAGHGBAEPN(T1 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5B9F8A0", Offset = "0x5B9E2A0", VA = "0x185B9F8A0")]
	public void OMEFODCKIFJ(T1 CALFLPHHCDN, T2 NCJINNKBBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5B9F8E0", Offset = "0x5B9E2E0", VA = "0x185B9F8E0", Slot = "5")]
	private void PFOPAMEELLA((T1, T2) FEBGNHCBECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4609780", Offset = "0x4608180", VA = "0x184609780", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class CGFIAHLPNFN<T1, T2, T3> : DHEKJNOFONA<(T1, T2, T3)>, GMPCDFILNOM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly GGPMHGIMEHO<T1, T2, T3> ACFPOEBGLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly GGPMHGIMEHO<T1, T2, T3> JGCIEDFFEBH;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string PHLFNBHNCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xFA7D10", Offset = "0xFA6710", VA = "0x180FA7D10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool BAPAIIMDKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x54DDFB0", Offset = "0x54DC9B0", VA = "0x1854DDFB0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool BPBOABCOGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5B9F4D0", Offset = "0x5B9DED0", VA = "0x185B9F4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool KODJFKJMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5B9E6B0", Offset = "0x5B9D0B0", VA = "0x185B9E6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool KBEGNJCPBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6CDA7D0", Offset = "0x6CD91D0", VA = "0x186CDA7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public (T1, T2, T3) GOIDDCDMPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6CDBDB0", Offset = "0x6CDA7B0", VA = "0x186CDBDB0", Slot = "11")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6CDB060", Offset = "0x6CD9A60", VA = "0x186CDB060", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public (T1, T2, T3) DOALEALIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6CDAF40", Offset = "0x6CD9940", VA = "0x186CDAF40", Slot = "4")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6CDA6F0", Offset = "0x6CD90F0", VA = "0x186CDA6F0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T1 HAOGNLGPEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6CDB360", Offset = "0x6CD9D60", VA = "0x186CDB360")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6CDB3A0", Offset = "0x6CD9DA0", VA = "0x186CDB3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T1 HAEAJGDCPMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6CDBB40", Offset = "0x6CDA540", VA = "0x186CDBB40")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T1 CIPDKLICKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6CDBB40", Offset = "0x6CDA540", VA = "0x186CDBB40")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6CDACE0", Offset = "0x6CD96E0", VA = "0x186CDACE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T2 NHHPBGCJINK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6CDC870", Offset = "0x6CDB270", VA = "0x186CDC870")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6CDC380", Offset = "0x6CDAD80", VA = "0x186CDC380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T2 CGCPHMKBGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6CDBFF0", Offset = "0x6CDA9F0", VA = "0x186CDBFF0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T2 FHOHEFDNCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6CDBFF0", Offset = "0x6CDA9F0", VA = "0x186CDBFF0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6CDC360", Offset = "0x6CDAD60", VA = "0x186CDC360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T3 MDBIPKPPINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6CDC310", Offset = "0x6CDAD10", VA = "0x186CDC310")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6CDB690", Offset = "0x6CDA090", VA = "0x186CDB690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public T3 IJKPMEBJCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6CDB590", Offset = "0x6CD9F90", VA = "0x186CDB590")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T3 OHHOGEECPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6CDB590", Offset = "0x6CD9F90", VA = "0x186CDB590")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6CDC050", Offset = "0x6CDAA50", VA = "0x186CDC050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool MFNKIKPGNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x460A020", Offset = "0x4608A20", VA = "0x18460A020", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6CDC4D0", Offset = "0x6CDAED0", VA = "0x186CDC4D0", Slot = "10")]
	public void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6CDCD90", Offset = "0x6CDB790", VA = "0x186CDCD90")]
	public CGFIAHLPNFN([In] KCBJFMGBHLK BLPDDGCLNPE, T1 KBFPPJOIJKN, T2 KBKBBFPJKDP, T3 MMIDDJABFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB7B0", Offset = "0x6CDA1B0", VA = "0x186CDB7B0")]
	private void JLJKNKILIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6CDC790", Offset = "0x6CDB190", VA = "0x186CDC790")]
	public void OIAGHGBAEPN(T1 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6CDAC00", Offset = "0x6CD9600", VA = "0x186CDAC00")]
	public void CMNLNAHKFCJ(T2 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6CDC230", Offset = "0x6CDAC30", VA = "0x186CDC230")]
	public void MBFBKBBHJJK(T3 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6CDC8F0", Offset = "0x6CDB2F0", VA = "0x186CDC8F0")]
	public void OMEFODCKIFJ(T1 CALFLPHHCDN, T2 NCJINNKBBPK, T3 GNOBJDOMCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6CDBAE0", Offset = "0x6CDA4E0", VA = "0x186CDBAE0", Slot = "5")]
	private void JNCDHGNCLJK((T1, T2, T3) FEBGNHCBECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4609780", Offset = "0x4608180", VA = "0x184609780", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class DMGHDPKPPFA<T1, T2, T3, T4> : DHEKJNOFONA<(T1, T2, T3, T4)>, GMPCDFILNOM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CHPBAJEOFCF<T1, T2, T3, T4> ACFPOEBGLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CHPBAJEOFCF<T1, T2, T3, T4> JGCIEDFFEBH;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string PHLFNBHNCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xFA7D10", Offset = "0xFA6710", VA = "0x180FA7D10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public (T1, T2, T3, T4) DOALEALIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x46097C0", Offset = "0x46081C0", VA = "0x1846097C0", Slot = "4")]
		get
		{
			return default((T1, T2, T3, T4));
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4609730", Offset = "0x4608130", VA = "0x184609730", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public T2 CGCPHMKBGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4609D90", Offset = "0x4608790", VA = "0x184609D90")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T3 IJKPMEBJCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4609AE0", Offset = "0x46084E0", VA = "0x184609AE0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public T4 IHGGMKLNGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x460A0E0", Offset = "0x4608AE0", VA = "0x18460A0E0")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MFNKIKPGNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x460A020", Offset = "0x4608A20", VA = "0x18460A020", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4609DD0", Offset = "0x46087D0", VA = "0x184609DD0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x460A120", Offset = "0x4608B20", VA = "0x18460A120")]
	public DMGHDPKPPFA([In] KCBJFMGBHLK BLPDDGCLNPE, T1 KBFPPJOIJKN, T2 KBKBBFPJKDP, T3 MMIDDJABFFB, T4 PHKHHBAJMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4609B20", Offset = "0x4608520", VA = "0x184609B20")]
	private void JLJKNKILIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4609DF0", Offset = "0x46087F0", VA = "0x184609DF0")]
	public void OIAGHGBAEPN(T1 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x460A090", Offset = "0x4608A90", VA = "0x18460A090")]
	public void OMEFODCKIFJ(T1 CALFLPHHCDN, T2 NCJINNKBBPK, T3 GNOBJDOMCBE, T4 EPGFIFGFFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4609A60", Offset = "0x4608460", VA = "0x184609A60", Slot = "5")]
	private void FIIKIAJDJEF((T1, T2, T3, T4) FEBGNHCBECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4609780", Offset = "0x4608180", VA = "0x184609780", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HPLBEPNNHHO
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8649CA0", Offset = "0x86486A0", VA = "0x188649CA0")]
	public static string JKJCKKKKLHN(this KCBJFMGBHLK BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xC56A80", Offset = "0xC55480", VA = "0x180C56A80")]
	public static HFMCCLJOJPF NLPCAJLLGAG(this KCBJFMGBHLK BLPDDGCLNPE)
	{
		return default(HFMCCLJOJPF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IEJEGKIFFLB<T> : HAONIGKGKEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x52D7D10", Offset = "0x52D6710", VA = "0x1852D7D10")]
	public IEJEGKIFFLB([In] KCBJFMGBHLK BLPDDGCLNPE, T KJMOBDOKFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x52D7F20", Offset = "0x52D6920", VA = "0x1852D7F20")]
	public IEJEGKIFFLB(MEDDKFIHEPM IJNPIDPIBFP, FNAEIBBBBBE BLHNDOLLIDD, string HPFHOBCPNEF, T KJMOBDOKFBF, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x52D8DE0", Offset = "0x52D77E0", VA = "0x1852D8DE0")]
	public IEJEGKIFFLB(MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, T KJMOBDOKFBF, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x52DA5D0", Offset = "0x52D8FD0", VA = "0x1852DA5D0")]
	public IEJEGKIFFLB(MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, T KJMOBDOKFBF, HFMCCLJOJPF BEHPCHIBLCJ, bool KMJHALECOIH, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OKNGBMEOAAC<T1, T2> : DKLCOMPOJPM<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5BBD0D0", Offset = "0x5BBBAD0", VA = "0x185BBD0D0")]
	public OKNGBMEOAAC([In] KCBJFMGBHLK BLPDDGCLNPE, T1 INALOGAIBPP, T2 HFNKPAJJCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5BBD690", Offset = "0x5BBC090", VA = "0x185BBD690")]
	public OKNGBMEOAAC(MEDDKFIHEPM IJNPIDPIBFP, FNAEIBBBBBE BLHNDOLLIDD, string HPFHOBCPNEF, T1 INALOGAIBPP, T2 HFNKPAJJCHC, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5BBCF00", Offset = "0x5BBB900", VA = "0x185BBCF00")]
	public OKNGBMEOAAC(MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, T1 INALOGAIBPP, T2 HFNKPAJJCHC, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5BBFDD0", Offset = "0x5BBE7D0", VA = "0x185BBFDD0")]
	public OKNGBMEOAAC(MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, T1 INALOGAIBPP, T2 HFNKPAJJCHC, HFMCCLJOJPF BEHPCHIBLCJ, bool KMJHALECOIH, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GGPMHGIMEHO<T1, T2, T3> : KBKEJJPIFCE<T1, T2, T3>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x512B750", Offset = "0x512A150", VA = "0x18512B750")]
	public GGPMHGIMEHO([In] KCBJFMGBHLK BLPDDGCLNPE, T1 INALOGAIBPP, T2 HFNKPAJJCHC, T3 CGJIFEGMDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x512BF40", Offset = "0x512A940", VA = "0x18512BF40")]
	public GGPMHGIMEHO(MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, T1 INALOGAIBPP, T2 HFNKPAJJCHC, T3 CGJIFEGMDIH, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CHPBAJEOFCF<T1, T2, T3, T4> : NOFPMMMLLGI<T1, T2, T3, T4>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6CE3030", Offset = "0x6CE1A30", VA = "0x186CE3030")]
	public CHPBAJEOFCF([In] KCBJFMGBHLK BLPDDGCLNPE, T1 INALOGAIBPP, T2 HFNKPAJJCHC, T3 CGJIFEGMDIH, T4 JAHCEGNMLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6CE33A0", Offset = "0x6CE1DA0", VA = "0x186CE33A0")]
	public CHPBAJEOFCF(MEDDKFIHEPM IJNPIDPIBFP, FNAEIBBBBBE BLHNDOLLIDD, string HPFHOBCPNEF, T1 INALOGAIBPP, T2 HFNKPAJJCHC, T3 CGJIFEGMDIH, T4 JAHCEGNMLCH, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6CE3C40", Offset = "0x6CE2640", VA = "0x186CE3C40")]
	public CHPBAJEOFCF(MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, T1 INALOGAIBPP, T2 HFNKPAJJCHC, T3 CGJIFEGMDIH, T4 JAHCEGNMLCH, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BMNKBCJJJAN<T1, T2, T3, T4, T5> : LABFCPGPJOH<T1, T2, T3, T4, T5>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x67803B0", Offset = "0x677EDB0", VA = "0x1867803B0")]
	public BMNKBCJJJAN(MEDDKFIHEPM IJNPIDPIBFP, FNAEIBBBBBE BLHNDOLLIDD, string HPFHOBCPNEF, T1 INALOGAIBPP, T2 HFNKPAJJCHC, T3 CGJIFEGMDIH, T4 JAHCEGNMLCH, T5 DPJEPKPKPDD, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6780920", Offset = "0x677F320", VA = "0x186780920")]
	public BMNKBCJJJAN(MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, T1 INALOGAIBPP, T2 HFNKPAJJCHC, T3 CGJIFEGMDIH, T4 JAHCEGNMLCH, T5 DPJEPKPKPDD, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MHAJEMFILLB<T> : HAONIGKGKEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5961AD0", Offset = "0x59604D0", VA = "0x185961AD0")]
	public MHAJEMFILLB(FNAEIBBBBBE BLHNDOLLIDD, string HPFHOBCPNEF, T KJMOBDOKFBF, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IHNANHEPMFJ<T1, T2> : DKLCOMPOJPM<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x52ED110", Offset = "0x52EBB10", VA = "0x1852ED110")]
	public IHNANHEPMFJ(FNAEIBBBBBE BLHNDOLLIDD, string HPFHOBCPNEF, T1 GJBJDGENJBO, T2 HOPPHPEGEMF, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BNJFEJLHECM
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEJEGKIFFLB<T1> LMFJFBPCMBH<T1>(string HPFHOBCPNEF, T1 GJBJDGENJBO, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LBKEBGKJCHG : BNJFEJLHECM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly OLAKLKNCBPM LBPJAFCCELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MEDDKFIHEPM IJNPIDPIBFP;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xAB5980", Offset = "0xAB4380", VA = "0x180AB5980")]
	public LBKEBGKJCHG(OLAKLKNCBPM LBPJAFCCELM, MEDDKFIHEPM GJCBKLMDDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3E6C0B0", Offset = "0x3E6AAB0", VA = "0x183E6C0B0", Slot = "4")]
	public IEJEGKIFFLB<T1> LMFJFBPCMBH<T1>(string HPFHOBCPNEF, T1 GJBJDGENJBO, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KOCBELMMLEE : MEDDKFIHEPM
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ViewId LDMJPMEJPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MEDDKFIHEPM
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JLMGBOEIMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool JODFPGCPBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string CMLGDDAABND
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool IFLJKFOMMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RegisterDestroyHandler(LCOGLBFMOJP OIAJENBJKKC);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UnregisterDestroyHandler(LCOGLBFMOJP OIAJENBJKKC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CCALMIHGJBM
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8649C50", Offset = "0x8648650", VA = "0x188649C50")]
	public static bool CMMFIDFPDFF(this MEDDKFIHEPM IJNPIDPIBFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OLAKLKNCBPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	FNAEIBBBBBE OPIAAKOABFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool DGEAHJMLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool NIDBLCGELDA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFALNPPLGKO();

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object HIJKDJFFDNK(string HPFHOBCPNEF);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	object ICIMEMJDPBM(FNAEIBBBBBE AFLHBKMHOEB, string HPFHOBCPNEF);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MHFEKOIHNJH(string HPFHOBCPNEF, object FCPDBBAAIEF);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BLLOJICGCPG(FNAEIBBBBBE AFLHBKMHOEB, string HPFHOBCPNEF, object FCPDBBAAIEF);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EHPHKCDAELJ<T>(string HPFHOBCPNEF, T KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JMEBJDOOBGM([CanBeNull] FNAEIBBBBBE AFLHBKMHOEB, string HPFHOBCPNEF, LNEGOBLMDJL LLBGMEOFPEB);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BIHIIDIMFPM([CanBeNull] FNAEIBBBBBE AFLHBKMHOEB, string HPFHOBCPNEF, LNEGOBLMDJL LLBGMEOFPEB);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "11")]
	T HHFCHDIMFIJ<T>(object KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "12")]
	object LMMMFMDMPCP<T>(T KJMOBDOKFBF);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OOIEBCDHAKP();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ALBANBFODMC();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LMLDNMIPNEO(string LGDIEGLPFLO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KCBJFMGBHLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public FNAEIBBBBBE BLHNDOLLIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public MEDDKFIHEPM IJNPIDPIBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public string HPFHOBCPNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public HFMCCLJOJPF BEHPCHIBLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool KMJHALECOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action AEPCPKCINPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public OLAKLKNCBPM LBPJAFCCELM;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8649D30", Offset = "0x8648730", VA = "0x188649D30")]
	public KCBJFMGBHLK(KCBJFMGBHLK GOCNHGEHNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8649DB0", Offset = "0x86487B0", VA = "0x188649DB0")]
	public KCBJFMGBHLK(MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8649CE0", Offset = "0x86486E0", VA = "0x188649CE0")]
	public static KCBJFMGBHLK DIHLONADDEL(MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, HFMCCLJOJPF BEHPCHIBLCJ, [Optional] Action AEPCPKCINPI, [Optional] OLAKLKNCBPM LBPJAFCCELM)
	{
		return default(KCBJFMGBHLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class JJDLGAIJOLB
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3E24CC0", Offset = "0x3E236C0", VA = "0x183E24CC0")]
	public static IEJEGKIFFLB<T> NGLHHABABGM<T>(this KCBJFMGBHLK BLPDDGCLNPE, T KJMOBDOKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3E24AF0", Offset = "0x3E234F0", VA = "0x183E24AF0")]
	public static OKNGBMEOAAC<T1, T2> NGLHHABABGM<T1, T2>(this KCBJFMGBHLK BLPDDGCLNPE, T1 DKGGELGHAIN, T2 HGPNNFMGGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3E24B90", Offset = "0x3E23590", VA = "0x183E24B90")]
	public static GGPMHGIMEHO<T1, T2, T3> NGLHHABABGM<T1, T2, T3>(this KCBJFMGBHLK BLPDDGCLNPE, T1 DKGGELGHAIN, T2 HGPNNFMGGIK, T3 PJOHGJEAGFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3E24F00", Offset = "0x3E23900", VA = "0x183E24F00")]
	public static CHPBAJEOFCF<T1, T2, T3, T4> NGLHHABABGM<T1, T2, T3, T4>(this KCBJFMGBHLK BLPDDGCLNPE, T1 DKGGELGHAIN, T2 HGPNNFMGGIK, T3 PJOHGJEAGFP, T4 LCJCLAFDIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3E24C40", Offset = "0x3E23640", VA = "0x183E24C40")]
	public static ANIGAAGFKEA<T> FDGEKILBIFI<T>(this KCBJFMGBHLK BLPDDGCLNPE, T KJMOBDOKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3E24AF0", Offset = "0x3E234F0", VA = "0x183E24AF0")]
	public static OCPNIJGPFMM<T1, T2> FDGEKILBIFI<T1, T2>(this KCBJFMGBHLK BLPDDGCLNPE, T1 DKGGELGHAIN, T2 HGPNNFMGGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3E24B90", Offset = "0x3E23590", VA = "0x183E24B90")]
	public static CGFIAHLPNFN<T1, T2, T3> FDGEKILBIFI<T1, T2, T3>(this KCBJFMGBHLK BLPDDGCLNPE, T1 DKGGELGHAIN, T2 HGPNNFMGGIK, T3 PJOHGJEAGFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3E24F00", Offset = "0x3E23900", VA = "0x183E24F00")]
	public static DMGHDPKPPFA<T1, T2, T3, T4> FDGEKILBIFI<T1, T2, T3, T4>(this KCBJFMGBHLK BLPDDGCLNPE, T1 DKGGELGHAIN, T2 HGPNNFMGGIK, T3 PJOHGJEAGFP, T4 LCJCLAFDIIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class LNEGOBLMDJL : LCOGLBFMOJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Flags]
	private enum LLJOMGIEMAG
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Disposed = 1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		LastSetLocally = 2,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Synchronizing = 4,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		ModifiedOffline = 8,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 4
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static Stack<OLAKLKNCBPM> BIBNFGIKMJN;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static bool AKMIMMMHFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly FNAEIBBBBBE BLHNDOLLIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly MEDDKFIHEPM IJNPIDPIBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly string HPFHOBCPNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly HFMCCLJOJPF BEHPCHIBLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly Action AEPCPKCINPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected OLAKLKNCBPM PDKMPMKACMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private LLJOMGIEMAG JHBIAAAGFJK;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static OLAKLKNCBPM MCPDFDOICFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x864A160", Offset = "0x8648B60", VA = "0x18864A160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool GPIKFHJEMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x864B480", Offset = "0x8649E80", VA = "0x18864B480")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x864AD50", Offset = "0x8649750", VA = "0x18864AD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private bool HGLJLKAJCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x864A000", Offset = "0x8648A00", VA = "0x18864A000")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x864A430", Offset = "0x8648E30", VA = "0x18864A430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private bool HHNOINOFONI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x864A150", Offset = "0x8648B50", VA = "0x18864A150")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8649F40", Offset = "0x8648940", VA = "0x188649F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool MFNKIKPGNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x864B470", Offset = "0x8649E70", VA = "0x18864B470")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x864B260", Offset = "0x8649C60", VA = "0x18864B260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected virtual object MEMEJBJJBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool OFDJECKJALC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x864AD00", Offset = "0x8649700", VA = "0x18864AD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int NLJOONDDJJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xECFBA0", Offset = "0xECE5A0", VA = "0x180ECFBA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1026A90", Offset = "0x1025490", VA = "0x181026A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string PHLFNBHNCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool DGEAHJMLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x864A1D0", Offset = "0x8648BD0", VA = "0x18864A1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8649F60", Offset = "0x8648960", VA = "0x188649F60")]
	public static void BJNJBKPBIMD(OLAKLKNCBPM EOIMGJJLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool ACIBDFOKKNH();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x864B620", Offset = "0x864A020", VA = "0x18864B620")]
	protected LNEGOBLMDJL(FNAEIBBBBBE BLHNDOLLIDD, MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, HFMCCLJOJPF BEHPCHIBLCJ, Action AEPCPKCINPI, OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x864A7B0", Offset = "0x86491B0", VA = "0x18864A7B0", Slot = "1")]
	~LNEGOBLMDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x864A2C0", Offset = "0x8648CC0", VA = "0x18864A2C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x864A9E0", Offset = "0x86493E0", VA = "0x18864A9E0")]
	private void HECOPGPMBKM(bool DCIDDOBMDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x864AAC0", Offset = "0x86494C0", VA = "0x18864AAC0")]
	private object JKLIFGHKEMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x864A810", Offset = "0x8649210", VA = "0x18864A810")]
	protected void GFALNPPLGKO(bool KMJHALECOIH, object LOOGMANDIJE, bool FECGDCDLGBB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x864A770", Offset = "0x8649170", VA = "0x18864A770")]
	protected void FNAEMEPGHFK(object FCPDBBAAIEF, bool LHAPAELOPDK = true, bool ALNOMKINIIH = false, bool FEANEIIACPG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x864AD70", Offset = "0x8649770", VA = "0x18864AD70")]
	protected void NADAHCEIIBK(object FCPDBBAAIEF, bool LLIFOGHJLHF, bool LHAPAELOPDK, bool ALNOMKINIIH = false, bool FEANEIIACPG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x864B180", Offset = "0x8649B80", VA = "0x18864B180")]
	internal void NKELCENPCLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x864B200", Offset = "0x8649C00", VA = "0x18864B200")]
	private void NNJNFJCKGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x864ACA0", Offset = "0x86496A0", VA = "0x18864ACA0")]
	private void LBKDHBNJINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x864AC30", Offset = "0x8649630", VA = "0x18864AC30", Slot = "4")]
	private void KEPDCCNCNIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x864AA80", Offset = "0x8649480", VA = "0x18864AA80", Slot = "5")]
	private void HEGJJIHKHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x864A010", Offset = "0x8648A10", VA = "0x18864A010")]
	public bool CMKCIDKPNLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x864AFC0", Offset = "0x86499C0", VA = "0x18864AFC0")]
	public bool NADMDEAKJPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x864B320", Offset = "0x8649D20", VA = "0x18864B320")]
	private bool OELNMFIBEHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x864A5B0", Offset = "0x8648FB0", VA = "0x18864A5B0")]
	internal void EODPHJDIEMM(object FCPDBBAAIEF, int PMJFFBMBLLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x864A660", Offset = "0x8649060", VA = "0x18864A660")]
	private void FIHFFIGNILA(object FCPDBBAAIEF, bool ALNOMKINIIH, bool FEANEIIACPG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x864AAB0", Offset = "0x86494B0", VA = "0x18864AAB0")]
	private bool HOEEBEOBGID(LLJOMGIEMAG MAFBHNHEGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x864AA90", Offset = "0x8649490", VA = "0x18864AA90")]
	private void HIBJOCCMPMH(LLJOMGIEMAG MAFBHNHEGDO, bool KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x864A220", Offset = "0x8648C20", VA = "0x18864A220")]
	public static string DENFNPIANLL(FNAEIBBBBBE BLHNDOLLIDD, string HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x864B490", Offset = "0x8649E90", VA = "0x18864B490")]
	public static string PBLGIPMICEP(MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x864A450", Offset = "0x8648E50", VA = "0x18864A450")]
	public static bool EMPGGKGBLMI(object EICJFDNFOCB, object MIBIEOGGIAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class ALLDMPLDOCG : OLAKLKNCBPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly Dictionary<object, object> POLEONKNBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly List<string> PFOMCPGBLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly Dictionary<object, object> HOBMEODFEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<string> DFDKAFJAJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool ICPNMNBNLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	protected readonly Dictionary<string, object> LFLNPHOEIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	protected readonly Dictionary<FNAEIBBBBBE, Dictionary<string, object>> CJFNEDPEKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<string> PIEMALFPDGF;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public abstract Dictionary<object, object> OHEHCFNHBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract int JOIMFDCPMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public abstract FNAEIBBBBBE OPIAAKOABFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public abstract bool DGEAHJMLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract bool NIDBLCGELDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual bool BMDMBKBPKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool DOGEECCMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xADB270", Offset = "0xAD9C70", VA = "0x180ADB270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x32DBA40", Offset = "0x32DA440", VA = "0x1832DBA40", Slot = "12")]
	public void EHPHKCDAELJ<T>(string HPFHOBCPNEF, T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8647A90", Offset = "0x8646490", VA = "0x188647A90", Slot = "11")]
	public void BLLOJICGCPG(FNAEIBBBBBE BLHNDOLLIDD, string HPFHOBCPNEF, object KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8648770", Offset = "0x8647170", VA = "0x188648770", Slot = "9")]
	public object ICIMEMJDPBM(FNAEIBBBBBE BLHNDOLLIDD, string HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8649790", Offset = "0x8648190", VA = "0x188649790", Slot = "10")]
	public void MHFEKOIHNJH(string HPFHOBCPNEF, object KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x86485E0", Offset = "0x8646FE0", VA = "0x1886485E0", Slot = "8")]
	public object HIJKDJFFDNK(string HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8648D00", Offset = "0x8647700", VA = "0x188648D00", Slot = "13")]
	public void JMEBJDOOBGM(FNAEIBBBBBE AFLHBKMHOEB, string HPFHOBCPNEF, LNEGOBLMDJL LLBGMEOFPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x86477E0", Offset = "0x86461E0", VA = "0x1886477E0", Slot = "14")]
	public void BIHIIDIMFPM(FNAEIBBBBBE AFLHBKMHOEB, string HPFHOBCPNEF, LNEGOBLMDJL LLBGMEOFPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8648E10", Offset = "0x8647810", VA = "0x188648E10")]
	private void KHBDJJHBDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8647B70", Offset = "0x8646570", VA = "0x188647B70")]
	private void BOGOMBMHOPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8647C50", Offset = "0x8646650", VA = "0x188647C50")]
	private void CBLIDLNDOCB(FNAEIBBBBBE BLHNDOLLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8648860", Offset = "0x8647260", VA = "0x188648860")]
	protected void ILIHONNCILM(FNAEIBBBBBE DIJBLMOBAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8648680", Offset = "0x8647080", VA = "0x188648680")]
	protected void ICCEMKPHKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8648150", Offset = "0x8646B50", VA = "0x188648150")]
	protected void FNDHLMPDPGC(IDictionary<object, object> LCGFPGGKBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x86498B0", Offset = "0x86482B0", VA = "0x1886498B0")]
	protected void NKFPPJAOEIK(FNAEIBBBBBE ABEOEBEFJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8647520", Offset = "0x8645F20", VA = "0x188647520")]
	protected void ALIPMMPFKEF(FNAEIBBBBBE BLHNDOLLIDD, IDictionary<object, object> LCGFPGGKBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8648160", Offset = "0x8646B60", VA = "0x188648160")]
	private void GKPGOIFAHBI(IDictionary<object, object> LCGFPGGKBNI, Dictionary<string, object> PGJENIOCAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8649310", Offset = "0x8647D10", VA = "0x188649310")]
	private static void MDNLKOABACN(object NEHGNMPJGOJ, object ELEBIIGLBPL, int PMJFFBMBLLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8648E60", Offset = "0x8647860", VA = "0x188648E60")]
	private static void LCOOIPJAKHE(Dictionary<string, object> PGJENIOCAKP, string HPFHOBCPNEF, LNEGOBLMDJL LLBGMEOFPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8647CB0", Offset = "0x86466B0", VA = "0x188647CB0")]
	private static void DEHKBOFFCHH(Dictionary<string, object> PGJENIOCAKP, string HPFHOBCPNEF, LNEGOBLMDJL LLBGMEOFPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8649920", Offset = "0x8648320", VA = "0x188649920", Slot = "17")]
	public void OOIEBCDHAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	protected abstract void MONLKMGDEDK(Dictionary<object, object> POLEONKNBHO);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8647440", Offset = "0x8645E40", VA = "0x188647440", Slot = "18")]
	public void ALBANBFODMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "28")]
	protected abstract void NLCJKAPLEPN(Dictionary<object, object> HOBMEODFEIL);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x86475B0", Offset = "0x8645FB0", VA = "0x1886475B0")]
	private void AMLPDKJKOEB(Dictionary<object, object> CHKNMIEHDKL, List<string> MKPLOPGGNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8649510", Offset = "0x8647F10", VA = "0x188649510")]
	private void MEKKHOGDPAD(IDictionary<object, object> LCGFPGGKBNI, [Out] int PMJFFBMBLLE, [Out] string[] MPFKKAKLFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8647BC0", Offset = "0x86465C0", VA = "0x188647BC0")]
	public void CBFBFBHENGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8648080", Offset = "0x8646A80", VA = "0x188648080")]
	public void FJLPKFMNCJJ(FNAEIBBBBBE BLHNDOLLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8648990", Offset = "0x8647390", VA = "0x188648990")]
	public void JBIABNFMDMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "29")]
	protected abstract HashSet<int> KLNKAGNFELB(bool OMIEDHIIFPA, bool KNDNJGBAPPG);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8649080", Offset = "0x8647A80", VA = "0x188649080", Slot = "19")]
	public void LMLDNMIPNEO(string LGDIEGLPFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8647E80", Offset = "0x8646880", VA = "0x188647E80")]
	protected string DENFNPIANLL(FNAEIBBBBBE BLHNDOLLIDD, string HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract object LMMMFMDMPCP<T>(T KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract T HHFCHDIMFIJ<T>(object KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "32")]
	public virtual void GFALNPPLGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8647F20", Offset = "0x8646920", VA = "0x188647F20", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "33")]
	protected virtual void OOELGODMJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8649A20", Offset = "0x8648420", VA = "0x188649A20")]
	protected ALLDMPLDOCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class HAONIGKGKEF<T1> : LNEGOBLMDJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T1 GJBJDGENJBO;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected virtual T1 EMDFMOGODII
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x518C4B0", Offset = "0x518AEB0", VA = "0x18518C4B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x518AF90", Offset = "0x5189990", VA = "0x18518AF90", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected override object MEMEJBJJBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4601C70", Offset = "0x4600670", VA = "0x184601C70", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x518C7D0", Offset = "0x518B1D0", VA = "0x18518C7D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x518AD90", Offset = "0x5189790", VA = "0x18518AD90", Slot = "9")]
	protected override bool ACIBDFOKKNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x518CD10", Offset = "0x518B710", VA = "0x18518CD10")]
	protected HAONIGKGKEF([In] KCBJFMGBHLK BLPDDGCLNPE, T1 GJBJDGENJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x518CDD0", Offset = "0x518B7D0", VA = "0x18518CDD0")]
	protected HAONIGKGKEF(FNAEIBBBBBE BLHNDOLLIDD, MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, T1 GJBJDGENJBO, HFMCCLJOJPF BEHPCHIBLCJ, bool KMJHALECOIH, Action AEPCPKCINPI, OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x518C440", Offset = "0x518AE40", VA = "0x18518C440")]
	public T1 GFFPJLNAMHB()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x518B5D0", Offset = "0x5189FD0", VA = "0x18518B5D0")]
	public void FNAEMEPGHFK(T1 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x518B1E0", Offset = "0x5189BE0", VA = "0x18518B1E0")]
	public void FNAEMEPGHFK(T1 FCPDBBAAIEF, bool LHAPAELOPDK, bool ALNOMKINIIH = false, bool FEANEIIACPG = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class DKLCOMPOJPM<T1, T2> : LNEGOBLMDJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private T1 GJBJDGENJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T2 HOPPHPEGEMF;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected virtual T1 EMDFMOGODII
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x10B2160", Offset = "0x10B0B60", VA = "0x1810B2160", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x12D0200", Offset = "0x12CEC00", VA = "0x1812D0200", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected virtual T2 PEIILNCFAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x10AA260", Offset = "0x10A8C60", VA = "0x1810AA260", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x10B1A00", Offset = "0x10B0400", VA = "0x1810B1A00", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public T2 OHDIAHKBKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1735100", Offset = "0x1733B00", VA = "0x181735100")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	protected override object MEMEJBJJBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4601C70", Offset = "0x4600670", VA = "0x184601C70", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4602D20", Offset = "0x4601720", VA = "0x184602D20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x45FD130", Offset = "0x45FBB30", VA = "0x1845FD130", Slot = "9")]
	protected override bool ACIBDFOKKNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4606300", Offset = "0x4604D00", VA = "0x184606300")]
	protected DKLCOMPOJPM([In] KCBJFMGBHLK BLPDDGCLNPE, T1 GJBJDGENJBO, T2 HOPPHPEGEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4606EB0", Offset = "0x46058B0", VA = "0x184606EB0")]
	protected DKLCOMPOJPM(FNAEIBBBBBE BLHNDOLLIDD, MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, T1 GJBJDGENJBO, T2 HOPPHPEGEMF, HFMCCLJOJPF BEHPCHIBLCJ, bool KMJHALECOIH, Action AEPCPKCINPI, OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x45FDCB0", Offset = "0x45FC6B0", VA = "0x1845FDCB0")]
	public T1 EELAJPCKAHE()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4603660", Offset = "0x4602060", VA = "0x184603660")]
	public void NKDAGEFAEAP(T1 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1735100", Offset = "0x1733B00", VA = "0x181735100")]
	public T2 IBINEACCICG()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x46041F0", Offset = "0x4602BF0", VA = "0x1846041F0")]
	public void PFFAFEEGHJC(T2 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4600A70", Offset = "0x45FF470", VA = "0x184600A70")]
	public void FNAEMEPGHFK(T1 CALFLPHHCDN, T2 NCJINNKBBPK, bool LHAPAELOPDK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class KBKEJJPIFCE<T1, T2, T3> : LNEGOBLMDJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private T1 GJBJDGENJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T2 HOPPHPEGEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private T3 KMPAPNFACNH;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected virtual T1 EMDFMOGODII
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB2F830", Offset = "0xB2E230", VA = "0x180B2F830", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xB2F800", Offset = "0xB2E200", VA = "0x180B2F800", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected virtual T2 PEIILNCFAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAE4550", Offset = "0xAE2F50", VA = "0x180AE4550", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1619010", Offset = "0x1617A10", VA = "0x181619010", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	protected virtual T3 DCAPKKPJAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xAB4810", Offset = "0xAB3210", VA = "0x180AB4810", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T1 HJDEHIGKBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x45FDCB0", Offset = "0x45FC6B0", VA = "0x1845FDCB0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T2 OHDIAHKBKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1735100", Offset = "0x1733B00", VA = "0x181735100")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T3 BACKLIPODBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x563C530", Offset = "0x563AF30", VA = "0x18563C530")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected override object MEMEJBJJBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4601C70", Offset = "0x4600670", VA = "0x184601C70", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x563AA50", Offset = "0x5639450", VA = "0x18563AA50", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5636030", Offset = "0x5634A30", VA = "0x185636030", Slot = "9")]
	protected override bool ACIBDFOKKNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x563F230", Offset = "0x563DC30", VA = "0x18563F230")]
	protected KBKEJJPIFCE([In] KCBJFMGBHLK BLPDDGCLNPE, T1 GJBJDGENJBO, T2 HOPPHPEGEMF, T3 KMPAPNFACNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x563F540", Offset = "0x563DF40", VA = "0x18563F540")]
	protected KBKEJJPIFCE(FNAEIBBBBBE BLHNDOLLIDD, MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, T1 GJBJDGENJBO, T2 HOPPHPEGEMF, T3 KMPAPNFACNH, HFMCCLJOJPF BEHPCHIBLCJ, bool KMJHALECOIH, Action AEPCPKCINPI, OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x45FDCB0", Offset = "0x45FC6B0", VA = "0x1845FDCB0")]
	public T1 EELAJPCKAHE()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x563BF10", Offset = "0x563A910", VA = "0x18563BF10")]
	public void NKDAGEFAEAP(T1 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1735100", Offset = "0x1733B00", VA = "0x181735100")]
	public T2 IBINEACCICG()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x563CD80", Offset = "0x563B780", VA = "0x18563CD80")]
	public void PFFAFEEGHJC(T2 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x563C530", Offset = "0x563AF30", VA = "0x18563C530")]
	public T3 PGCBLPCLGOB()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x563C850", Offset = "0x563B250", VA = "0x18563C850")]
	public void OFFEAKEOFBC(T3 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x563A4E0", Offset = "0x5638EE0", VA = "0x18563A4E0")]
	public void FNAEMEPGHFK(T1 CALFLPHHCDN, T2 NCJINNKBBPK, T3 GNOBJDOMCBE, bool LHAPAELOPDK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class NOFPMMMLLGI<T1, T2, T3, T4> : LNEGOBLMDJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T1 GJBJDGENJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private T2 HOPPHPEGEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private T3 KMPAPNFACNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private T4 NKMLIMKKNNG;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual T1 EMDFMOGODII
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xF7CCF0", Offset = "0xF7B6F0", VA = "0x180F7CCF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x56FA400", Offset = "0x56F8E00", VA = "0x1856FA400", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	protected virtual T2 PEIILNCFAON
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5130", Offset = "0x1FC3B30", VA = "0x181FC5130", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x56FB7F0", Offset = "0x56FA1F0", VA = "0x1856FB7F0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	protected virtual T3 DCAPKKPJAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5A7ED50", Offset = "0x5A7D750", VA = "0x185A7ED50", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5A7DCB0", Offset = "0x5A7C6B0", VA = "0x185A7DCB0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	protected virtual T4 EKFALMGKCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x16F5610", Offset = "0x16F4010", VA = "0x1816F5610", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x167D7E0", Offset = "0x167C1E0", VA = "0x18167D7E0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public T2 OHDIAHKBKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x45FDC40", Offset = "0x45FC640", VA = "0x1845FDC40")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T3 BACKLIPODBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x563C550", Offset = "0x563AF50", VA = "0x18563C550")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T4 BEKKJIODKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x211ED70", Offset = "0x211D770", VA = "0x18211ED70")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	protected override object MEMEJBJJBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x4601C70", Offset = "0x4600670", VA = "0x184601C70", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5A7D110", Offset = "0x5A7BB10", VA = "0x185A7D110", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5A78D40", Offset = "0x5A77740", VA = "0x185A78D40", Slot = "9")]
	protected override bool ACIBDFOKKNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5A80760", Offset = "0x5A7F160", VA = "0x185A80760")]
	protected NOFPMMMLLGI([In] KCBJFMGBHLK BLPDDGCLNPE, T1 GJBJDGENJBO, T2 HOPPHPEGEMF, T3 KMPAPNFACNH, T4 NKMLIMKKNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5A80BD0", Offset = "0x5A7F5D0", VA = "0x185A80BD0")]
	protected NOFPMMMLLGI(FNAEIBBBBBE BLHNDOLLIDD, MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, T1 GJBJDGENJBO, T2 HOPPHPEGEMF, T3 KMPAPNFACNH, T4 NKMLIMKKNNG, HFMCCLJOJPF BEHPCHIBLCJ, bool KMJHALECOIH, Action AEPCPKCINPI, OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x45FDCB0", Offset = "0x45FC6B0", VA = "0x1845FDCB0")]
	public T1 EELAJPCKAHE()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5A7DF10", Offset = "0x5A7C910", VA = "0x185A7DF10")]
	public void NKDAGEFAEAP(T1 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x45FDC40", Offset = "0x45FC640", VA = "0x1845FDC40")]
	public T2 IBINEACCICG()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5A7F120", Offset = "0x5A7DB20", VA = "0x185A7F120")]
	public void PFFAFEEGHJC(T2 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x563C550", Offset = "0x563AF50", VA = "0x18563C550")]
	public T3 PGCBLPCLGOB()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5A7E8F0", Offset = "0x5A7D2F0", VA = "0x185A7E8F0")]
	public void OFFEAKEOFBC(T3 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x211ED70", Offset = "0x211D770", VA = "0x18211ED70")]
	public T4 JDPJOJEOGCN()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5A79090", Offset = "0x5A77A90", VA = "0x185A79090")]
	public void DOFECGGAPEN(T4 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5A79E70", Offset = "0x5A78870", VA = "0x185A79E70")]
	public void FNAEMEPGHFK(T1 CALFLPHHCDN, T2 NCJINNKBBPK, T3 GNOBJDOMCBE, T4 EPGFIFGFFBL, bool LHAPAELOPDK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class LABFCPGPJOH<T1, T2, T3, T4, T5> : LNEGOBLMDJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T1 GJBJDGENJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T2 HOPPHPEGEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T3 KMPAPNFACNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T4 NKMLIMKKNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private T5 MPGDPDEHNED;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	protected virtual T1 EMDFMOGODII
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB2F830", Offset = "0xB2E230", VA = "0x180B2F830", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xB2F800", Offset = "0xB2E200", VA = "0x180B2F800", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	protected virtual T2 PEIILNCFAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1493F50", Offset = "0x1492950", VA = "0x181493F50", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x14943C0", Offset = "0x1492DC0", VA = "0x1814943C0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	protected virtual T3 DCAPKKPJAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xAC8250", Offset = "0xAC6C50", VA = "0x180AC8250", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xE33F60", Offset = "0xE32960", VA = "0x180E33F60", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	protected virtual T4 EKFALMGKCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xAE4510", Offset = "0xAE2F10", VA = "0x180AE4510", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xAE4570", Offset = "0xAE2F70", VA = "0x180AE4570", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	protected virtual T5 MEAPCFOLIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1847790", Offset = "0x1846190", VA = "0x181847790", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return (T5)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1847CF0", Offset = "0x18466F0", VA = "0x181847CF0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	protected override object MEMEJBJJBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4601C70", Offset = "0x4600670", VA = "0x184601C70", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x56FA8C0", Offset = "0x56F92C0", VA = "0x1856FA8C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x56F70F0", Offset = "0x56F5AF0", VA = "0x1856F70F0", Slot = "9")]
	protected override bool ACIBDFOKKNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x56FCC90", Offset = "0x56FB690", VA = "0x1856FCC90")]
	protected LABFCPGPJOH(FNAEIBBBBBE BLHNDOLLIDD, MEDDKFIHEPM IJNPIDPIBFP, string HPFHOBCPNEF, T1 GJBJDGENJBO, T2 HOPPHPEGEMF, T3 KMPAPNFACNH, T4 NKMLIMKKNNG, T5 MPGDPDEHNED, HFMCCLJOJPF BEHPCHIBLCJ, bool KMJHALECOIH, Action AEPCPKCINPI, OLAKLKNCBPM LBPJAFCCELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x45FDCB0", Offset = "0x45FC6B0", VA = "0x1845FDCB0")]
	public T1 EELAJPCKAHE()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x56FB360", Offset = "0x56F9D60", VA = "0x1856FB360")]
	public void NKDAGEFAEAP(T1 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x1735100", Offset = "0x1733B00", VA = "0x181735100")]
	public T2 IBINEACCICG()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x56FBE40", Offset = "0x56FA840", VA = "0x1856FBE40")]
	public void PFFAFEEGHJC(T2 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x563C530", Offset = "0x563AF30", VA = "0x18563C530")]
	public T3 PGCBLPCLGOB()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x56FBBC0", Offset = "0x56FA5C0", VA = "0x1856FBBC0")]
	public void OFFEAKEOFBC(T3 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x211ED70", Offset = "0x211D770", VA = "0x18211ED70")]
	public T4 JDPJOJEOGCN()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x56F8210", Offset = "0x56F6C10", VA = "0x1856F8210")]
	public void DOFECGGAPEN(T4 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x56FA450", Offset = "0x56F8E50", VA = "0x1856FA450")]
	public T5 KJEOGAIJJON()
	{
		return (T5)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x56FB1B0", Offset = "0x56F9BB0", VA = "0x1856FB1B0")]
	public void NBFMJJPCNHH(T5 FCPDBBAAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x56F9210", Offset = "0x56F7C10", VA = "0x1856F9210")]
	public void FNAEMEPGHFK(T1 CALFLPHHCDN, T2 NCJINNKBBPK, T3 GNOBJDOMCBE, T4 EPGFIFGFFBL, T5 NNCEPJENAEM)
	{
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

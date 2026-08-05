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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x271EF20", Offset = "0x271E320", VA = "0x18271EF20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LHOEELKBONN : IEnumerator<DIOIGPDCAIB>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DHHBLOIGGCA<FNFJOKDEBDH>.IMNADMCLLKO NILKCCFMEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private OPIJJGMNDIA<FNFJOKDEBDH, DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>> IDLJNBIJKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP FLNJAPGILOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool DDANGMKILIP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DIOIGPDCAIB CHOEFFOHNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x271DCC0", Offset = "0x271D0C0", VA = "0x18271DCC0", Slot = "4")]
		get
		{
			return default(DIOIGPDCAIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x271DC00", Offset = "0x271D000", VA = "0x18271DC00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x271DC50", Offset = "0x271D050", VA = "0x18271DC50")]
	internal LHOEELKBONN([In] DHHBLOIGGCA<FNFJOKDEBDH>.IMNADMCLLKO ODOMHEMMJAK, [In] OPIJJGMNDIA<FNFJOKDEBDH, DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>> NHKGIFGEAFH, [In] DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP IGFKOMODHIO, bool BIPCKIAPMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x271DA00", Offset = "0x271CE00", VA = "0x18271DA00", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x271DBC0", Offset = "0x271CFC0", VA = "0x18271DBC0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x271D990", Offset = "0x271CD90", VA = "0x18271D990", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CNOHDFKEBBP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal EHCJHGHNPOB ICBEEBJFNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal DGELALHADMN LEAMOJGMDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal OMGJMPGJPPP MJIEFOEEEJC;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x271AD80", Offset = "0x271A180", VA = "0x18271AD80")]
	internal CNOHDFKEBBP([In] EHCJHGHNPOB KCOKOMAOHGE, [In] DGELALHADMN HFLJADBFFBE, [In] OMGJMPGJPPP ELKEEDJPIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2718780", Offset = "0x2717B80", VA = "0x182718780")]
	public static CNOHDFKEBBP FABCCGGAHMJ()
	{
		return default(CNOHDFKEBBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27185A0", Offset = "0x27179A0", VA = "0x1827185A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x271AAC0", Offset = "0x2719EC0", VA = "0x18271AAC0")]
	public readonly MNIGJBFEKOP PEGKBLBFNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2717ED0", Offset = "0x27172D0", VA = "0x182717ED0")]
	public void BAMHKPJJECC(JHLAGGIINPD<FNFJOKDEBDH> KGFJHAILICO, JHLAGGIINPD<ODIMEMELOCG> GEPJDHHGCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x271A170", Offset = "0x2719570", VA = "0x18271A170")]
	public JHLAGGIINPD<ODIMEMELOCG> LEHJDGJPGFA(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(JHLAGGIINPD<ODIMEMELOCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27190E0", Offset = "0x27184E0", VA = "0x1827190E0")]
	public JHLAGGIINPD<AIKGKILEHOL> GNDKAMOFOMP()
	{
		return default(JHLAGGIINPD<AIKGKILEHOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2719A10", Offset = "0x2718E10", VA = "0x182719A10")]
	public JHLAGGIINPD<FNFJOKDEBDH> KBMLMJLNDFG(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(JHLAGGIINPD<FNFJOKDEBDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2718C20", Offset = "0x2718020", VA = "0x182718C20")]
	public readonly bool FOBBBGNFHHB(JHLAGGIINPD<FNFJOKDEBDH> KGFJHAILICO, JHLAGGIINPD<ODIMEMELOCG> GEPJDHHGCON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2718DB0", Offset = "0x27181B0", VA = "0x182718DB0")]
	public readonly IDKGJOKGMAA<DIOIGPDCAIB, LHOEELKBONN> GFEJFJAGDCG()
	{
		return default(IDKGJOKGMAA<DIOIGPDCAIB, LHOEELKBONN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x271A5A0", Offset = "0x27199A0", VA = "0x18271A5A0")]
	public readonly LHOEELKBONN NCGKCGCCMIM()
	{
		return default(LHOEELKBONN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2718490", Offset = "0x2717890", VA = "0x182718490")]
	public readonly IDKGJOKGMAA<JHLAGGIINPD<ODIMEMELOCG>, DHHBLOIGGCA<ODIMEMELOCG>.IMNADMCLLKO> DFDBKBEDNNB()
	{
		return default(IDKGJOKGMAA<JHLAGGIINPD<ODIMEMELOCG>, DHHBLOIGGCA<ODIMEMELOCG>.IMNADMCLLKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2719970", Offset = "0x2718D70", VA = "0x182719970")]
	public readonly JHLAGGIINPD<ODIMEMELOCG> JHBDKNPKLAE(JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI, int DNDEDEPADFH)
	{
		return default(JHLAGGIINPD<ODIMEMELOCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2718090", Offset = "0x2717490", VA = "0x182718090")]
	public readonly IDKGJOKGMAA<JHLAGGIINPD<NAIAPDHIGPH>, JFJFIEPBAJC<NAIAPDHIGPH>> CBMALOCBHPG(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(IDKGJOKGMAA<JHLAGGIINPD<NAIAPDHIGPH>, JFJFIEPBAJC<NAIAPDHIGPH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2718500", Offset = "0x2717900", VA = "0x182718500")]
	public readonly JFJFIEPBAJC<NAIAPDHIGPH> DLKDGHPGBFE(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(JFJFIEPBAJC<NAIAPDHIGPH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x271A210", Offset = "0x2719610", VA = "0x18271A210")]
	public readonly JHLAGGIINPD<ODIMEMELOCG> LMAIECKDAPM(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<NAIAPDHIGPH> DNDEDEPADFH)
	{
		return default(JHLAGGIINPD<ODIMEMELOCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x271AA00", Offset = "0x2719E00", VA = "0x18271AA00")]
	public readonly IDKGJOKGMAA<JHLAGGIINPD<ODIMEMELOCG>, NFPHBHGACCC> PEDNOMMIKCK(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(IDKGJOKGMAA<JHLAGGIINPD<ODIMEMELOCG>, NFPHBHGACCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x271AB90", Offset = "0x2719F90", VA = "0x18271AB90")]
	public readonly NFPHBHGACCC PMJJGIKOINO(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(NFPHBHGACCC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2719030", Offset = "0x2718430", VA = "0x182719030")]
	public readonly KJPCEECADCG<JHLAGGIINPD<ODIMEMELOCG>, DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP> GLIDOIJIPAE(JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return default(KJPCEECADCG<JHLAGGIINPD<ODIMEMELOCG>, DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x271A0C0", Offset = "0x27194C0", VA = "0x18271A0C0")]
	public readonly DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP KLNBCAFNMND(JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return default(DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x27185D0", Offset = "0x27179D0", VA = "0x1827185D0")]
	public readonly KJPCEECADCG<JHLAGGIINPD<ODIMEMELOCG>, DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP> EAAOPEMJJJF(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(KJPCEECADCG<JHLAGGIINPD<ODIMEMELOCG>, DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2719470", Offset = "0x2718870", VA = "0x182719470")]
	public readonly DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP GPJAALKIHEE(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x271A7C0", Offset = "0x2719BC0", VA = "0x18271A7C0")]
	public readonly IDKGJOKGMAA<JHLAGGIINPD<AIKGKILEHOL>, CNDPJBHIKMC> OLPLBJBPGMP(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(IDKGJOKGMAA<JHLAGGIINPD<AIKGKILEHOL>, CNDPJBHIKMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x271AC80", Offset = "0x271A080", VA = "0x18271AC80")]
	public readonly CNDPJBHIKMC PPNBPIBFLDL(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(CNDPJBHIKMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x271A990", Offset = "0x2719D90", VA = "0x18271A990")]
	public readonly IDKGJOKGMAA<JHLAGGIINPD<AIKGKILEHOL>, DHHBLOIGGCA<AIKGKILEHOL>.IMNADMCLLKO> ONEPDPNFHHI()
	{
		return default(IDKGJOKGMAA<JHLAGGIINPD<AIKGKILEHOL>, DHHBLOIGGCA<AIKGKILEHOL>.IMNADMCLLKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x271A920", Offset = "0x2719D20", VA = "0x18271A920")]
	public readonly DHHBLOIGGCA<AIKGKILEHOL>.IMNADMCLLKO OMFKBOLGCDL()
	{
		return default(DHHBLOIGGCA<AIKGKILEHOL>.IMNADMCLLKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x27191E0", Offset = "0x27185E0", VA = "0x1827191E0")]
	public readonly int GNGMIAEAIBP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2718FF0", Offset = "0x27183F0", VA = "0x182718FF0")]
	public readonly int GKMKBLPFFNA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x271A350", Offset = "0x2719750", VA = "0x18271A350")]
	public readonly int MABLJAFINNK(JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x271A3D0", Offset = "0x27197D0", VA = "0x18271A3D0")]
	public readonly int MAJDJNLCEGH(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2717D90", Offset = "0x2717190", VA = "0x182717D90")]
	public readonly int AHKBOINIANG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2718560", Offset = "0x2717960", VA = "0x182718560")]
	public readonly int DMAMINOMMIO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2718700", Offset = "0x2717B00", VA = "0x182718700")]
	public readonly int EHCAPINAMIP(JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2718BA0", Offset = "0x2717FA0", VA = "0x182718BA0")]
	public readonly int FJHJDFJJNKO(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2717FD0", Offset = "0x27173D0", VA = "0x182717FD0")]
	public readonly JHLAGGIINPD<FNFJOKDEBDH> BAPBLKIFPGP(JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC, int NAANDAAKIBL)
	{
		return default(JHLAGGIINPD<FNFJOKDEBDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2718190", Offset = "0x2717590", VA = "0x182718190")]
	public readonly IDKGJOKGMAA<JHLAGGIINPD<NIHOBGMELIC>, JFJFIEPBAJC<NIHOBGMELIC>> COFFGBLIEDG(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(IDKGJOKGMAA<JHLAGGIINPD<NIHOBGMELIC>, JFJFIEPBAJC<NIHOBGMELIC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x271A760", Offset = "0x2719B60", VA = "0x18271A760")]
	public readonly JFJFIEPBAJC<NIHOBGMELIC> OLEMGILPIKM(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(JFJFIEPBAJC<NIHOBGMELIC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2719850", Offset = "0x2718C50", VA = "0x182719850")]
	public readonly JHLAGGIINPD<FNFJOKDEBDH> ICPDKPPMKMO(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<NIHOBGMELIC> NAANDAAKIBL)
	{
		return default(JHLAGGIINPD<FNFJOKDEBDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x271A450", Offset = "0x2719850", VA = "0x18271A450")]
	public readonly KJPCEECADCG<JHLAGGIINPD<FNFJOKDEBDH>, DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>.CDPCMNJLJIP> MBANGGKLCOE(JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return default(KJPCEECADCG<JHLAGGIINPD<FNFJOKDEBDH>, DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>.CDPCMNJLJIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x271A2B0", Offset = "0x27196B0", VA = "0x18271A2B0")]
	public readonly DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>.CDPCMNJLJIP LOLODKIEIJA(JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return default(DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>.CDPCMNJLJIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2717CA0", Offset = "0x27170A0", VA = "0x182717CA0")]
	public readonly GMAFFJKNHEL AGFLPHFEAIN(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(GMAFFJKNHEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2718120", Offset = "0x2717520", VA = "0x182718120")]
	public readonly DHHBLOIGGCA<FNFJOKDEBDH>.IMNADMCLLKO CDAIBGAFNKC()
	{
		return default(DHHBLOIGGCA<FNFJOKDEBDH>.IMNADMCLLKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x271A4F0", Offset = "0x27198F0", VA = "0x18271A4F0")]
	public readonly KJPCEECADCG<JHLAGGIINPD<FNFJOKDEBDH>, DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>.CDPCMNJLJIP> MDCABIJCMBF(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(KJPCEECADCG<JHLAGGIINPD<FNFJOKDEBDH>, DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>.CDPCMNJLJIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2718AF0", Offset = "0x2717EF0", VA = "0x182718AF0")]
	public readonly DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>.CDPCMNJLJIP FALDFDDMNFL(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>.CDPCMNJLJIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2718680", Offset = "0x2717A80", VA = "0x182718680")]
	public readonly JHLAGGIINPD<AIKGKILEHOL> EAPABJOLBGN(JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return default(JHLAGGIINPD<AIKGKILEHOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x27198F0", Offset = "0x2718CF0", VA = "0x1827198F0")]
	public readonly JHLAGGIINPD<AIKGKILEHOL> IJFEDBOHNBE(JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return default(JHLAGGIINPD<AIKGKILEHOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2717C50", Offset = "0x2717050", VA = "0x182717C50")]
	public readonly bool ADFANNODNKL(JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x271A650", Offset = "0x2719A50", VA = "0x18271A650")]
	public JHLAGGIINPD<ODIMEMELOCG> NFJKIDIFJPA(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<NAIAPDHIGPH> DNDEDEPADFH)
	{
		return default(JHLAGGIINPD<ODIMEMELOCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2719520", Offset = "0x2718920", VA = "0x182719520")]
	public JHLAGGIINPD<FNFJOKDEBDH> HFKGAOBNIJJ(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<NIHOBGMELIC> NAANDAAKIBL)
	{
		return default(JHLAGGIINPD<FNFJOKDEBDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2718070", Offset = "0x2717470", VA = "0x182718070")]
	public readonly bool BOLGJADEOCB(JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x271AB70", Offset = "0x2719F70", VA = "0x18271AB70")]
	public readonly bool PGLEHNCOEFA(JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2718EF0", Offset = "0x27182F0", VA = "0x182718EF0")]
	public void GHDNGOCLHNC(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<NAIAPDHIGPH> OOGAFLADJIH, JHLAGGIINPD<NAIAPDHIGPH> JOJHMIHNAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2719370", Offset = "0x2718770", VA = "0x182719370")]
	public void GOCOGMGMMPK(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<NIHOBGMELIC> GHEOGPEJEMP, JHLAGGIINPD<NIHOBGMELIC> BIJCDJBBALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x271A710", Offset = "0x2719B10", VA = "0x18271A710")]
	public readonly bool OFOIDPPBEDL(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2719AB0", Offset = "0x2718EB0", VA = "0x182719AB0")]
	public readonly bool KCCNHCJMKIH(JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2717DD0", Offset = "0x27171D0", VA = "0x182717DD0")]
	public void AHKDHIGENKP(JHLAGGIINPD<FNFJOKDEBDH> KGFJHAILICO, JHLAGGIINPD<ODIMEMELOCG> GEPJDHHGCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2718220", Offset = "0x2717620", VA = "0x182718220")]
	public void DDOJEKBCNPB(JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2719B00", Offset = "0x2718F00", VA = "0x182719B00")]
	public void KFHNAKEPIJN(JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x27195E0", Offset = "0x27189E0", VA = "0x1827195E0")]
	public void HJEGNOPFMPJ(JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DPAHPAOHCHC
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
	public static DHHBLOIGGCA<ODIMEMELOCG> EGMMPDLDKDG([In] this CNOHDFKEBBP KBBJDOAJMAF)
	{
		return default(DHHBLOIGGCA<ODIMEMELOCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x271B720", Offset = "0x271AB20", VA = "0x18271B720")]
	public static DHHBLOIGGCA<FNFJOKDEBDH> JOLLDECLHOB([In] this CNOHDFKEBBP KBBJDOAJMAF)
	{
		return default(DHHBLOIGGCA<FNFJOKDEBDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x271B730", Offset = "0x271AB30", VA = "0x18271B730")]
	public static DHHBLOIGGCA<AIKGKILEHOL> KHCPCADOLHO([In] this CNOHDFKEBBP KBBJDOAJMAF)
	{
		return default(DHHBLOIGGCA<AIKGKILEHOL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal struct EHCJHGHNPOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public DHHBLOIGGCA<ODIMEMELOCG> PDAGFGPCPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public OPIJJGMNDIA<ODIMEMELOCG, JHLAGGIINPD<AIKGKILEHOL>> HPLIECNOAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public OPIJJGMNDIA<ODIMEMELOCG, DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>> IPFDEKMDFDB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x271B6B0", Offset = "0x271AAB0", VA = "0x18271B6B0")]
	public EHCJHGHNPOB([In] DHHBLOIGGCA<ODIMEMELOCG> NEKLIAOKPCC, [In] OPIJJGMNDIA<ODIMEMELOCG, JHLAGGIINPD<AIKGKILEHOL>> ELKEEDJPIPG, [In] OPIJJGMNDIA<ODIMEMELOCG, DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>> HFLJADBFFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x271B9C0", Offset = "0x271ADC0", VA = "0x18271B9C0")]
	public static EHCJHGHNPOB FABCCGGAHMJ()
	{
		return default(EHCJHGHNPOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x271B820", Offset = "0x271AC20", VA = "0x18271B820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x271BCD0", Offset = "0x271B0D0", VA = "0x18271BCD0")]
	public readonly MLLCDMMNCBI PEGKBLBFNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x271BAA0", Offset = "0x271AEA0", VA = "0x18271BAA0")]
	public JHLAGGIINPD<ODIMEMELOCG> JGDNGNDGOPK(JHLAGGIINPD<AIKGKILEHOL> HAIECNDMOKO)
	{
		return default(JHLAGGIINPD<ODIMEMELOCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x271B740", Offset = "0x271AB40", VA = "0x18271B740")]
	public void AOLPCAOCNBA(JHLAGGIINPD<ODIMEMELOCG> FBLIJIPJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x271BB60", Offset = "0x271AF60", VA = "0x18271BB60")]
	[CompilerGenerated]
	internal static GKBDBIKANBH JJIIKHKBOML([In] DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>> KBBJDOAJMAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NFPHBHGACCC : IEnumerator<JHLAGGIINPD<ODIMEMELOCG>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>.CDPCMNJLJIP NILKCCFMEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP BMPPHCKLHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly OPIJJGMNDIA<FNFJOKDEBDH, DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>> GIMLIKNMGLP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JHLAGGIINPD<ODIMEMELOCG> CHOEFFOHNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x271EEE0", Offset = "0x271E2E0", VA = "0x18271EEE0", Slot = "4")]
		get
		{
			return default(JHLAGGIINPD<ODIMEMELOCG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x271EE70", Offset = "0x271E270", VA = "0x18271EE70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x271C200", Offset = "0x271B600", VA = "0x18271C200")]
	internal NFPHBHGACCC([In] DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>.CDPCMNJLJIP ODOMHEMMJAK, [In] DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP IMJFEFNGMAG, [In] OPIJJGMNDIA<FNFJOKDEBDH, DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>> EFHPFGAKJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x271ECD0", Offset = "0x271E0D0", VA = "0x18271ECD0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x271EE10", Offset = "0x271E210", VA = "0x18271EE10", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x271EC70", Offset = "0x271E070", VA = "0x18271EC70", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal struct OMGJMPGJPPP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public DHHBLOIGGCA<AIKGKILEHOL> PDAGFGPCPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public OPIJJGMNDIA<AIKGKILEHOL, DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>> CLDBNMHKFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public OPIJJGMNDIA<AIKGKILEHOL, DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>> IPFDEKMDFDB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x271B6B0", Offset = "0x271AAB0", VA = "0x18271B6B0")]
	public OMGJMPGJPPP([In] DHHBLOIGGCA<AIKGKILEHOL> NEKLIAOKPCC, [In] OPIJJGMNDIA<AIKGKILEHOL, DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>> KCOKOMAOHGE, [In] OPIJJGMNDIA<AIKGKILEHOL, DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>> HFLJADBFFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x271F3B0", Offset = "0x271E7B0", VA = "0x18271F3B0")]
	public static OMGJMPGJPPP FABCCGGAHMJ()
	{
		return default(OMGJMPGJPPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x271F0E0", Offset = "0x271E4E0", VA = "0x18271F0E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x271F820", Offset = "0x271EC20", VA = "0x18271F820")]
	public readonly OIBMJAKFFJC PEGKBLBFNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x271F770", Offset = "0x271EB70", VA = "0x18271F770")]
	public JHLAGGIINPD<AIKGKILEHOL> JGDNGNDGOPK([In] DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>> KCOKOMAOHGE, [In] DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>> HFLJADBFFBE)
	{
		return default(JHLAGGIINPD<AIKGKILEHOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x271EFA0", Offset = "0x271E3A0", VA = "0x18271EFA0")]
	public void AOLPCAOCNBA(JHLAGGIINPD<AIKGKILEHOL> FBLIJIPJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x271F600", Offset = "0x271EA00", VA = "0x18271F600")]
	[CompilerGenerated]
	internal static PPIBMGPKPAI JAGJMJHMEKB([In] DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>> KBBJDOAJMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x271F490", Offset = "0x271E890", VA = "0x18271F490")]
	[CompilerGenerated]
	internal static PHBIPKEGPHE IJKNHFPBLGN([In] DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>> KBBJDOAJMAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CNDPJBHIKMC : IEnumerator<JHLAGGIINPD<AIKGKILEHOL>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private NFPHBHGACCC JAPHOGHGIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly OPIJJGMNDIA<ODIMEMELOCG, JHLAGGIINPD<AIKGKILEHOL>> KCCIOIHNMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private GMAFFJKNHEL MEBAMLMNPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly OPIJJGMNDIA<FNFJOKDEBDH, JHLAGGIINPD<AIKGKILEHOL>> KIHODDBFEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private bool PBHHGMLPLDJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly JHLAGGIINPD<AIKGKILEHOL> CHOEFFOHNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2717AD0", Offset = "0x2716ED0", VA = "0x182717AD0", Slot = "4")]
		get
		{
			return default(JHLAGGIINPD<AIKGKILEHOL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x27179D0", Offset = "0x2716DD0", VA = "0x1827179D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2717A20", Offset = "0x2716E20", VA = "0x182717A20")]
	internal CNDPJBHIKMC([In] NFPHBHGACCC IGIKDBGNKKO, [In] OPIJJGMNDIA<ODIMEMELOCG, JHLAGGIINPD<AIKGKILEHOL>> HOCBNMDOAGM, [In] GMAFFJKNHEL ACFIBCIEMHH, [In] OPIJJGMNDIA<FNFJOKDEBDH, JHLAGGIINPD<AIKGKILEHOL>> CKCFMCJNGBG, bool PAGCCCKOLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x27178D0", Offset = "0x2716CD0", VA = "0x1827178D0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2717920", Offset = "0x2716D20", VA = "0x182717920", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2717830", Offset = "0x2716C30", VA = "0x182717830", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal struct DGELALHADMN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public DHHBLOIGGCA<FNFJOKDEBDH> PDAGFGPCPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OPIJJGMNDIA<FNFJOKDEBDH, JHLAGGIINPD<AIKGKILEHOL>> HPLIECNOAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OPIJJGMNDIA<FNFJOKDEBDH, DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>> CLDBNMHKFGJ;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x271B6B0", Offset = "0x271AAB0", VA = "0x18271B6B0")]
	public DGELALHADMN([In] DHHBLOIGGCA<FNFJOKDEBDH> NEKLIAOKPCC, [In] OPIJJGMNDIA<FNFJOKDEBDH, JHLAGGIINPD<AIKGKILEHOL>> ELKEEDJPIPG, [In] OPIJJGMNDIA<FNFJOKDEBDH, DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>> KCOKOMAOHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x271B0E0", Offset = "0x271A4E0", VA = "0x18271B0E0")]
	public static DGELALHADMN FABCCGGAHMJ()
	{
		return default(DGELALHADMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x271AF40", Offset = "0x271A340", VA = "0x18271AF40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x271B3F0", Offset = "0x271A7F0", VA = "0x18271B3F0")]
	public readonly LAHLCLJEJFG PEGKBLBFNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x271B1C0", Offset = "0x271A5C0", VA = "0x18271B1C0")]
	public JHLAGGIINPD<FNFJOKDEBDH> JGDNGNDGOPK(JHLAGGIINPD<AIKGKILEHOL> HAIECNDMOKO)
	{
		return default(JHLAGGIINPD<FNFJOKDEBDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x271AE60", Offset = "0x271A260", VA = "0x18271AE60")]
	public void AOLPCAOCNBA(JHLAGGIINPD<FNFJOKDEBDH> FBLIJIPJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x271B280", Offset = "0x271A680", VA = "0x18271B280")]
	[CompilerGenerated]
	internal static PKCABDJIOCI NPKBGGBNCEP([In] DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>> KBBJDOAJMAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GMAFFJKNHEL : IEnumerator<JHLAGGIINPD<FNFJOKDEBDH>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP NFPOKLEICNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>.CDPCMNJLJIP JPELOLDMJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly OPIJJGMNDIA<ODIMEMELOCG, DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>> LOECIFNGFBI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JHLAGGIINPD<FNFJOKDEBDH> CHOEFFOHNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x271C260", Offset = "0x271B660", VA = "0x18271C260", Slot = "4")]
		get
		{
			return default(JHLAGGIINPD<FNFJOKDEBDH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x271C190", Offset = "0x271B590", VA = "0x18271C190", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x271C200", Offset = "0x271B600", VA = "0x18271C200")]
	internal GMAFFJKNHEL([In] DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>.CDPCMNJLJIP CODOOKPLAMG, [In] DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>.CDPCMNJLJIP IDCLLJFFJGI, [In] OPIJJGMNDIA<ODIMEMELOCG, DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>> EEMOCPIIHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x271BFF0", Offset = "0x271B3F0", VA = "0x18271BFF0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x271C130", Offset = "0x271B530", VA = "0x18271C130", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x271BF90", Offset = "0x271B390", VA = "0x18271BF90", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class PBBGHPEKOOK
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x271FE40", Offset = "0x271F240", VA = "0x18271FE40")]
	public static OMGJMPGJPPP ILOIKAMJPOD(this OIBMJAKFFJC KBBJDOAJMAF)
	{
		return default(OMGJMPGJPPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x271FB10", Offset = "0x271EF10", VA = "0x18271FB10")]
	public static void AOLPCAOCNBA(this OIBMJAKFFJC KBBJDOAJMAF, int FBLIJIPJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x271FC20", Offset = "0x271F020", VA = "0x18271FC20")]
	[CompilerGenerated]
	internal static DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>> ENMODGAKOEH(PPIBMGPKPAI KBBJDOAJMAF)
	{
		return default(DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x27202E0", Offset = "0x271F6E0", VA = "0x1827202E0")]
	[CompilerGenerated]
	internal static DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>> KBKLCEIJPIG(PHBIPKEGPHE KBBJDOAJMAF)
	{
		return default(DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KCENGNHDAOH
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x271CBE0", Offset = "0x271BFE0", VA = "0x18271CBE0")]
	public static CNOHDFKEBBP ILOIKAMJPOD(this MNIGJBFEKOP KBBJDOAJMAF)
	{
		return default(CNOHDFKEBBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x271D6F0", Offset = "0x271CAF0", VA = "0x18271D6F0")]
	public static JHLAGGIINPD<ODIMEMELOCG> LMAIECKDAPM(this MNIGJBFEKOP KBBJDOAJMAF, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<NAIAPDHIGPH> DNDEDEPADFH)
	{
		return default(JHLAGGIINPD<ODIMEMELOCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x271C6E0", Offset = "0x271BAE0", VA = "0x18271C6E0")]
	public static IDKGJOKGMAA<JHLAGGIINPD<ODIMEMELOCG>, FLLAJGOOPGI<ODIMEMELOCG>.IKJECAPIBKM> GLIDOIJIPAE(this MNIGJBFEKOP KBBJDOAJMAF, JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return default(IDKGJOKGMAA<JHLAGGIINPD<ODIMEMELOCG>, FLLAJGOOPGI<ODIMEMELOCG>.IKJECAPIBKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x271C580", Offset = "0x271B980", VA = "0x18271C580")]
	public static IEnumerable<int> EAAOPEMJJJF(this MNIGJBFEKOP KBBJDOAJMAF, int PPHFMFHOCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x271D7A0", Offset = "0x271CBA0", VA = "0x18271D7A0")]
	public static int MAJDJNLCEGH(this MNIGJBFEKOP KBBJDOAJMAF, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x271C660", Offset = "0x271BA60", VA = "0x18271C660")]
	public static int FJHJDFJJNKO(this MNIGJBFEKOP KBBJDOAJMAF, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x271CAC0", Offset = "0x271BEC0", VA = "0x18271CAC0")]
	public static JHLAGGIINPD<FNFJOKDEBDH> ICPDKPPMKMO(this MNIGJBFEKOP KBBJDOAJMAF, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ, JHLAGGIINPD<NIHOBGMELIC> NAANDAAKIBL)
	{
		return default(JHLAGGIINPD<FNFJOKDEBDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x271D820", Offset = "0x271CC20", VA = "0x18271D820")]
	public static IDKGJOKGMAA<JHLAGGIINPD<FNFJOKDEBDH>, FLLAJGOOPGI<FNFJOKDEBDH>.IKJECAPIBKM> MBANGGKLCOE(this MNIGJBFEKOP KBBJDOAJMAF, JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return default(IDKGJOKGMAA<JHLAGGIINPD<FNFJOKDEBDH>, FLLAJGOOPGI<FNFJOKDEBDH>.IKJECAPIBKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x271D920", Offset = "0x271CD20", VA = "0x18271D920")]
	public static IEnumerable<int> MDCABIJCMBF(this MNIGJBFEKOP KBBJDOAJMAF, int PPHFMFHOCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x271C5F0", Offset = "0x271B9F0", VA = "0x18271C5F0")]
	public static JHLAGGIINPD<AIKGKILEHOL> EAPABJOLBGN(this MNIGJBFEKOP KBBJDOAJMAF, JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
		return default(JHLAGGIINPD<AIKGKILEHOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x271CB70", Offset = "0x271BF70", VA = "0x18271CB70")]
	public static JHLAGGIINPD<AIKGKILEHOL> IJFEDBOHNBE(this MNIGJBFEKOP KBBJDOAJMAF, JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
		return default(JHLAGGIINPD<AIKGKILEHOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x271C2A0", Offset = "0x271B6A0", VA = "0x18271C2A0")]
	public static void DDOJEKBCNPB(this MNIGJBFEKOP KBBJDOAJMAF, JHLAGGIINPD<ODIMEMELOCG> ELDPAHOBCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x271CFD0", Offset = "0x271C3D0", VA = "0x18271CFD0")]
	public static void KFHNAKEPIJN(this MNIGJBFEKOP KBBJDOAJMAF, int PPHFMFHOCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x271C7E0", Offset = "0x271BBE0", VA = "0x18271C7E0")]
	public static void HJEGNOPFMPJ(this MNIGJBFEKOP KBBJDOAJMAF, JHLAGGIINPD<FNFJOKDEBDH> CIPHPJIJIKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class NCGIHBDIHEH
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x271E7D0", Offset = "0x271DBD0", VA = "0x18271E7D0")]
	public static EHCJHGHNPOB ILOIKAMJPOD(this MLLCDMMNCBI KBBJDOAJMAF)
	{
		return default(EHCJHGHNPOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x271E4E0", Offset = "0x271D8E0", VA = "0x18271E4E0")]
	public static void AOLPCAOCNBA(this MLLCDMMNCBI KBBJDOAJMAF, int FBLIJIPJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x271E5B0", Offset = "0x271D9B0", VA = "0x18271E5B0")]
	[CompilerGenerated]
	internal static DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>> FOHIFACIIJH(GKBDBIKANBH KBBJDOAJMAF)
	{
		return default(DNPCPJMGLMI<JHLAGGIINPD<FNFJOKDEBDH>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal static class LIAFKFFMCIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x271DE20", Offset = "0x271D220", VA = "0x18271DE20")]
	public static DGELALHADMN ILOIKAMJPOD(this LAHLCLJEJFG KBBJDOAJMAF)
	{
		return default(DGELALHADMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x271DD50", Offset = "0x271D150", VA = "0x18271DD50")]
	public static void AOLPCAOCNBA(this LAHLCLJEJFG KBBJDOAJMAF, int FBLIJIPJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x271E2C0", Offset = "0x271D6C0", VA = "0x18271E2C0")]
	[CompilerGenerated]
	internal static DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>> OKBJLFMLIKB(PKCABDJIOCI KBBJDOAJMAF)
	{
		return default(DNPCPJMGLMI<JHLAGGIINPD<ODIMEMELOCG>>);
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

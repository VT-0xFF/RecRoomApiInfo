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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x277E3C0", Offset = "0x277CBC0", VA = "0x18277E3C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EGPNJJEKCDG : IEnumerator<PKIPLDOOGNO>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DPFLMJLLNFF<BFEAKKGKCCO>.IBBHMEAIIGI HNIIFJPEABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private OABOCIAOEJE<BFEAKKGKCCO, PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>> DMHFBKGGGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM NHJGODDKIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool BJLBALJONLG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PKIPLDOOGNO IECKFCICFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2777CB0", Offset = "0x27764B0", VA = "0x182777CB0", Slot = "4")]
		get
		{
			return default(PKIPLDOOGNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2777BF0", Offset = "0x27763F0", VA = "0x182777BF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2777C40", Offset = "0x2776440", VA = "0x182777C40")]
	internal EGPNJJEKCDG([In] DPFLMJLLNFF<BFEAKKGKCCO>.IBBHMEAIIGI AFFDKBCNEIK, [In] OABOCIAOEJE<BFEAKKGKCCO, PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>> KGHPLJHKJGL, [In] PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM FPKENGMCION, bool JEGMHBHOPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27779F0", Offset = "0x27761F0", VA = "0x1827779F0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2777BB0", Offset = "0x27763B0", VA = "0x182777BB0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2777980", Offset = "0x2776180", VA = "0x182777980", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MOBJABBAOJK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal JMAJDEBHCCM HMCPLGNPINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal CMKGOEBEAAJ DPKFJGFAEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal IEPDKFABIIO CGBKJBGLKDP;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x277E2E0", Offset = "0x277CAE0", VA = "0x18277E2E0")]
	internal MOBJABBAOJK([In] JMAJDEBHCCM FDHEHNFLELM, [In] CMKGOEBEAAJ DKIIEIBDPOD, [In] IEPDKFABIIO CHHNLHCEBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x277BA80", Offset = "0x277A280", VA = "0x18277BA80")]
	public static MOBJABBAOJK CJOJELENPLJ()
	{
		return default(MOBJABBAOJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x277BFF0", Offset = "0x277A7F0", VA = "0x18277BFF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x277DA50", Offset = "0x277C250", VA = "0x18277DA50")]
	public readonly MOMGKBONDJE LIJGMGKAKKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x277CE50", Offset = "0x277B650", VA = "0x18277CE50")]
	public void IGHIMPKFAHK(NLPIAAOFKEO<BFEAKKGKCCO> HHLKACCBEBO, NLPIAAOFKEO<GCOKIOOPJJN> AJOCPGOGBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x277CDB0", Offset = "0x277B5B0", VA = "0x18277CDB0")]
	public NLPIAAOFKEO<GCOKIOOPJJN> IDPOIKBADEN(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(NLPIAAOFKEO<GCOKIOOPJJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x277C2B0", Offset = "0x277AAB0", VA = "0x18277C2B0")]
	public NLPIAAOFKEO<KGLBPIDLJAB> FPKIAPPOKKP()
	{
		return default(NLPIAAOFKEO<KGLBPIDLJAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x277DB80", Offset = "0x277C380", VA = "0x18277DB80")]
	public NLPIAAOFKEO<BFEAKKGKCCO> MLLGNMFAKKB(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(NLPIAAOFKEO<BFEAKKGKCCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x277B4C0", Offset = "0x2779CC0", VA = "0x18277B4C0")]
	public readonly bool BEBIPADCGMH(NLPIAAOFKEO<BFEAKKGKCCO> HHLKACCBEBO, NLPIAAOFKEO<GCOKIOOPJJN> AJOCPGOGBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x277BEB0", Offset = "0x277A6B0", VA = "0x18277BEB0")]
	public readonly PFNCDBFLBAH<PKIPLDOOGNO, EGPNJJEKCDG> DNIEJEHLLHN()
	{
		return default(PFNCDBFLBAH<PKIPLDOOGNO, EGPNJJEKCDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x277CBE0", Offset = "0x277B3E0", VA = "0x18277CBE0")]
	public readonly EGPNJJEKCDG HOIPIDAGMPH()
	{
		return default(EGPNJJEKCDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x277B310", Offset = "0x2779B10", VA = "0x18277B310")]
	public readonly PFNCDBFLBAH<NLPIAAOFKEO<GCOKIOOPJJN>, DPFLMJLLNFF<GCOKIOOPJJN>.IBBHMEAIIGI> ADPGAHLCPMM()
	{
		return default(PFNCDBFLBAH<NLPIAAOFKEO<GCOKIOOPJJN>, DPFLMJLLNFF<GCOKIOOPJJN>.IBBHMEAIIGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x277CD10", Offset = "0x277B510", VA = "0x18277CD10")]
	public readonly NLPIAAOFKEO<GCOKIOOPJJN> ICPAOLMECFA(NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH, int KFAILCHCEPI)
	{
		return default(NLPIAAOFKEO<GCOKIOOPJJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x277D810", Offset = "0x277C010", VA = "0x18277D810")]
	public readonly PFNCDBFLBAH<NLPIAAOFKEO<LHDAOLHHICL>, KIMMOLCOCCH<LHDAOLHHICL>> LCEACFDGNFN(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(PFNCDBFLBAH<NLPIAAOFKEO<LHDAOLHHICL>, KIMMOLCOCCH<LHDAOLHHICL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x277CF50", Offset = "0x277B750", VA = "0x18277CF50")]
	public readonly KIMMOLCOCCH<LHDAOLHHICL> IGPBKLOCJMG(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(KIMMOLCOCCH<LHDAOLHHICL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x277B960", Offset = "0x277A160", VA = "0x18277B960")]
	public readonly NLPIAAOFKEO<GCOKIOOPJJN> CFKCIPDOAOK(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<LHDAOLHHICL> KFAILCHCEPI)
	{
		return default(NLPIAAOFKEO<GCOKIOOPJJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x277C1F0", Offset = "0x277A9F0", VA = "0x18277C1F0")]
	public readonly PFNCDBFLBAH<NLPIAAOFKEO<GCOKIOOPJJN>, KMIAFJKGENC> FKKOOAPFHLM(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(PFNCDBFLBAH<NLPIAAOFKEO<GCOKIOOPJJN>, KMIAFJKGENC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x277DE70", Offset = "0x277C670", VA = "0x18277DE70")]
	public readonly KMIAFJKGENC ONMFAOGLBJB(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(KMIAFJKGENC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x277DCC0", Offset = "0x277C4C0", VA = "0x18277DCC0")]
	public readonly GCOMBNOPDLG<NLPIAAOFKEO<GCOKIOOPJJN>, PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM> NMKAMKCCFGF(NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return default(GCOMBNOPDLG<NLPIAAOFKEO<GCOKIOOPJJN>, PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x277D9A0", Offset = "0x277C1A0", VA = "0x18277D9A0")]
	public readonly PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM LGHOLNPBIJH(NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return default(PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x277B8B0", Offset = "0x277A0B0", VA = "0x18277B8B0")]
	public readonly GCOMBNOPDLG<NLPIAAOFKEO<GCOKIOOPJJN>, PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM> CEMDLCIKHLK(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(GCOMBNOPDLG<NLPIAAOFKEO<GCOKIOOPJJN>, PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x277D390", Offset = "0x277BB90", VA = "0x18277D390")]
	public readonly PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM KBBKJIAIOMP(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x277B1B0", Offset = "0x27799B0", VA = "0x18277B1B0")]
	public readonly PFNCDBFLBAH<NLPIAAOFKEO<KGLBPIDLJAB>, OGONKHNMHLJ> ABDJLHPFCDA(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(PFNCDBFLBAH<NLPIAAOFKEO<KGLBPIDLJAB>, OGONKHNMHLJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x277B7B0", Offset = "0x2779FB0", VA = "0x18277B7B0")]
	public readonly OGONKHNMHLJ BOANHKKKKNH(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(OGONKHNMHLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x277D530", Offset = "0x277BD30", VA = "0x18277D530")]
	public readonly PFNCDBFLBAH<NLPIAAOFKEO<KGLBPIDLJAB>, DPFLMJLLNFF<KGLBPIDLJAB>.IBBHMEAIIGI> LBCCLJKACFE()
	{
		return default(PFNCDBFLBAH<NLPIAAOFKEO<KGLBPIDLJAB>, DPFLMJLLNFF<KGLBPIDLJAB>.IBBHMEAIIGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x277C0C0", Offset = "0x277A8C0", VA = "0x18277C0C0")]
	public readonly DPFLMJLLNFF<KGLBPIDLJAB>.IBBHMEAIIGI FAPBMLJCNEA()
	{
		return default(DPFLMJLLNFF<KGLBPIDLJAB>.IBBHMEAIIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x277CFB0", Offset = "0x277B7B0", VA = "0x18277CFB0")]
	public readonly int JADFJJLHEED()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x277B380", Offset = "0x2779B80", VA = "0x18277B380")]
	public readonly int AMKHIMDDNFB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x277E260", Offset = "0x277CA60", VA = "0x18277E260")]
	public readonly int PPGJPMJFABJ(NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x277DFB0", Offset = "0x277C7B0", VA = "0x18277DFB0")]
	public readonly int PAEMEIJLDMO(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x277E030", Offset = "0x277C830", VA = "0x18277E030")]
	public readonly int PCJDJPGOJKP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x277D350", Offset = "0x277BB50", VA = "0x18277D350")]
	public readonly int JNBPJLGOLIE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x277DB00", Offset = "0x277C300", VA = "0x18277DB00")]
	public readonly int MDHMBFKGNBD(NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x277D440", Offset = "0x277BC40", VA = "0x18277D440")]
	public readonly int KBKFDJMHHMO(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x277D200", Offset = "0x277BA00", VA = "0x18277D200")]
	public readonly NLPIAAOFKEO<BFEAKKGKCCO> JEDMKICLGBH(NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC, int ANCLACDALFJ)
	{
		return default(NLPIAAOFKEO<BFEAKKGKCCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x277E1B0", Offset = "0x277C9B0", VA = "0x18277E1B0")]
	public readonly PFNCDBFLBAH<NLPIAAOFKEO<EKLADAEAEJL>, KIMMOLCOCCH<EKLADAEAEJL>> PKLGHCIJIPB(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(PFNCDBFLBAH<NLPIAAOFKEO<EKLADAEAEJL>, KIMMOLCOCCH<EKLADAEAEJL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x277B700", Offset = "0x2779F00", VA = "0x18277B700")]
	public readonly KIMMOLCOCCH<EKLADAEAEJL> BKHGHOGGFGK(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(KIMMOLCOCCH<EKLADAEAEJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x277DC20", Offset = "0x277C420", VA = "0x18277DC20")]
	public readonly NLPIAAOFKEO<BFEAKKGKCCO> MPELBHPEMKK(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<EKLADAEAEJL> ANCLACDALFJ)
	{
		return default(NLPIAAOFKEO<BFEAKKGKCCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x277D160", Offset = "0x277B960", VA = "0x18277D160")]
	public readonly GCOMBNOPDLG<NLPIAAOFKEO<BFEAKKGKCCO>, PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>.FCGDBKGLPLM> JDBACEBHECF(NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return default(GCOMBNOPDLG<NLPIAAOFKEO<BFEAKKGKCCO>, PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>.FCGDBKGLPLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x277C020", Offset = "0x277A820", VA = "0x18277C020")]
	public readonly PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>.FCGDBKGLPLM EKLBMPPEBHN(NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return default(PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>.FCGDBKGLPLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x277E070", Offset = "0x277C870", VA = "0x18277E070")]
	public readonly EEBGNHBBELO PHPGEHPCJIK(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(EEBGNHBBELO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x277D4C0", Offset = "0x277BCC0", VA = "0x18277D4C0")]
	public readonly DPFLMJLLNFF<BFEAKKGKCCO>.IBBHMEAIIGI KDCDCNJNKLL()
	{
		return default(DPFLMJLLNFF<BFEAKKGKCCO>.IBBHMEAIIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x277D2A0", Offset = "0x277BAA0", VA = "0x18277D2A0")]
	public readonly GCOMBNOPDLG<NLPIAAOFKEO<BFEAKKGKCCO>, PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>.FCGDBKGLPLM> JKANBGPOBIB(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(GCOMBNOPDLG<NLPIAAOFKEO<BFEAKKGKCCO>, PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>.FCGDBKGLPLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x277B650", Offset = "0x2779E50", VA = "0x18277B650")]
	public readonly PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>.FCGDBKGLPLM BFOCIMINACF(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>.FCGDBKGLPLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x277BA00", Offset = "0x277A200", VA = "0x18277BA00")]
	public readonly NLPIAAOFKEO<KGLBPIDLJAB> CGEAOLDCFPP(NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return default(NLPIAAOFKEO<KGLBPIDLJAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x277CC90", Offset = "0x277B490", VA = "0x18277CC90")]
	public readonly NLPIAAOFKEO<KGLBPIDLJAB> IBJAAHEFCJH(NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return default(NLPIAAOFKEO<KGLBPIDLJAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x277DF60", Offset = "0x277C760", VA = "0x18277DF60")]
	public readonly bool PADMIBLILBN(NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x277BDF0", Offset = "0x277A5F0", VA = "0x18277BDF0")]
	public NLPIAAOFKEO<GCOKIOOPJJN> COCFAHIGBLC(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<LHDAOLHHICL> KFAILCHCEPI)
	{
		return default(NLPIAAOFKEO<GCOKIOOPJJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x277C130", Offset = "0x277A930", VA = "0x18277C130")]
	public NLPIAAOFKEO<BFEAKKGKCCO> FHLMLNIFAMA(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<EKLADAEAEJL> ANCLACDALFJ)
	{
		return default(NLPIAAOFKEO<BFEAKKGKCCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x277D140", Offset = "0x277B940", VA = "0x18277D140")]
	public readonly bool JCNDKJMKJCI(NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x277E240", Offset = "0x277CA40", VA = "0x18277E240")]
	public readonly bool PLGFDNBGANB(NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x277B3C0", Offset = "0x2779BC0", VA = "0x18277B3C0")]
	public void BANCGMJMDGA(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<LHDAOLHHICL> KKEBLDOJFLM, NLPIAAOFKEO<LHDAOLHHICL> OKMDIHLJGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x277D8A0", Offset = "0x277C0A0", VA = "0x18277D8A0")]
	public void LEGEMEHEOON(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<EKLADAEAEJL> EMBJPGDKKGJ, NLPIAAOFKEO<EKLADAEAEJL> ICLLEBNFECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x277B760", Offset = "0x2779F60", VA = "0x18277B760")]
	public readonly bool BLKFNMIIHGP(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x277E160", Offset = "0x277C960", VA = "0x18277E160")]
	public readonly bool PJAGEBCEPLP(NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x277DD70", Offset = "0x277C570", VA = "0x18277DD70")]
	public void OKLCIHPOJGB(NLPIAAOFKEO<BFEAKKGKCCO> HHLKACCBEBO, NLPIAAOFKEO<GCOKIOOPJJN> AJOCPGOGBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x277D5A0", Offset = "0x277BDA0", VA = "0x18277D5A0")]
	public void LBCFGBOHNDC(NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x277C620", Offset = "0x277AE20", VA = "0x18277C620")]
	public void HCICIIILIPC(NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x277C3B0", Offset = "0x277ABB0", VA = "0x18277C3B0")]
	public void GNBMHHHDKCA(NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class AEADHJJGONB
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static DPFLMJLLNFF<GCOKIOOPJJN> IJHMFCBDNHJ([In] this MOBJABBAOJK NFOGFJOGLPE)
	{
		return default(DPFLMJLLNFF<GCOKIOOPJJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2775CB0", Offset = "0x27744B0", VA = "0x182775CB0")]
	public static DPFLMJLLNFF<BFEAKKGKCCO> LMIKOFAHKEO([In] this MOBJABBAOJK NFOGFJOGLPE)
	{
		return default(DPFLMJLLNFF<BFEAKKGKCCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2775CA0", Offset = "0x27744A0", VA = "0x182775CA0")]
	public static DPFLMJLLNFF<KGLBPIDLJAB> LAAPAIIMOMC([In] this MOBJABBAOJK NFOGFJOGLPE)
	{
		return default(DPFLMJLLNFF<KGLBPIDLJAB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal struct JMAJDEBHCCM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public DPFLMJLLNFF<GCOKIOOPJJN> KMMLBAFNILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public OABOCIAOEJE<GCOKIOOPJJN, NLPIAAOFKEO<KGLBPIDLJAB>> FJEIKHDKLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public OABOCIAOEJE<GCOKIOOPJJN, PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>> IOHEIPPFBJB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2776C50", Offset = "0x2775450", VA = "0x182776C50")]
	public JMAJDEBHCCM([In] DPFLMJLLNFF<GCOKIOOPJJN> GFLKAHBLNKA, [In] OABOCIAOEJE<GCOKIOOPJJN, NLPIAAOFKEO<KGLBPIDLJAB>> CHHNLHCEBAM, [In] OABOCIAOEJE<GCOKIOOPJJN, PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>> DKIIEIBDPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x277A830", Offset = "0x2779030", VA = "0x18277A830")]
	public static JMAJDEBHCCM CJOJELENPLJ()
	{
		return default(JMAJDEBHCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x277A910", Offset = "0x2779110", VA = "0x18277A910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x277AC50", Offset = "0x2779450", VA = "0x18277AC50")]
	public readonly DJBEOPCOBEI LIJGMGKAKKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x277AB90", Offset = "0x2779390", VA = "0x18277AB90")]
	public NLPIAAOFKEO<GCOKIOOPJJN> LIDOJKMJGCF(NLPIAAOFKEO<KGLBPIDLJAB> GDFCBMOFMFN)
	{
		return default(NLPIAAOFKEO<GCOKIOOPJJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x277AAB0", Offset = "0x27792B0", VA = "0x18277AAB0")]
	public void IHLFGIKCBJJ(NLPIAAOFKEO<GCOKIOOPJJN> MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x277A6D0", Offset = "0x2778ED0", VA = "0x18277A6D0")]
	[CompilerGenerated]
	internal static CALOOPCMDAK CGIPKAADKEG([In] PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>> NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KMIAFJKGENC : IEnumerator<NLPIAAOFKEO<GCOKIOOPJJN>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>.FCGDBKGLPLM HNIIFJPEABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM IDCNMADMJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly OABOCIAOEJE<BFEAKKGKCCO, PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>> EIKJMMFKAJP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NLPIAAOFKEO<GCOKIOOPJJN> IECKFCICFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x277B170", Offset = "0x2779970", VA = "0x18277B170", Slot = "4")]
		get
		{
			return default(NLPIAAOFKEO<GCOKIOOPJJN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x277B100", Offset = "0x2779900", VA = "0x18277B100", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27778E0", Offset = "0x27760E0", VA = "0x1827778E0")]
	internal KMIAFJKGENC([In] PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>.FCGDBKGLPLM AFFDKBCNEIK, [In] PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM NJFDOAPAGLH, [In] OABOCIAOEJE<BFEAKKGKCCO, PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>> AHOIDIIGKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x277AF60", Offset = "0x2779760", VA = "0x18277AF60", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x277B0A0", Offset = "0x27798A0", VA = "0x18277B0A0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x277AF00", Offset = "0x2779700", VA = "0x18277AF00", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal struct IEPDKFABIIO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public DPFLMJLLNFF<KGLBPIDLJAB> KMMLBAFNILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public OABOCIAOEJE<KGLBPIDLJAB, PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>> MGGBGLEGENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public OABOCIAOEJE<KGLBPIDLJAB, PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>> IOHEIPPFBJB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2776C50", Offset = "0x2775450", VA = "0x182776C50")]
	public IEPDKFABIIO([In] DPFLMJLLNFF<KGLBPIDLJAB> GFLKAHBLNKA, [In] OABOCIAOEJE<KGLBPIDLJAB, PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>> FDHEHNFLELM, [In] OABOCIAOEJE<KGLBPIDLJAB, PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>> DKIIEIBDPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2779B90", Offset = "0x2778390", VA = "0x182779B90")]
	public static IEPDKFABIIO CJOJELENPLJ()
	{
		return default(IEPDKFABIIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2779C70", Offset = "0x2778470", VA = "0x182779C70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x277A3F0", Offset = "0x2778BF0", VA = "0x18277A3F0")]
	public readonly CCEEPFDCDEG LIJGMGKAKKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x277A340", Offset = "0x2778B40", VA = "0x18277A340")]
	public NLPIAAOFKEO<KGLBPIDLJAB> LIDOJKMJGCF([In] PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>> FDHEHNFLELM, [In] PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>> DKIIEIBDPOD)
	{
		return default(NLPIAAOFKEO<KGLBPIDLJAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x277A200", Offset = "0x2778A00", VA = "0x18277A200")]
	public void IHLFGIKCBJJ(NLPIAAOFKEO<KGLBPIDLJAB> MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x277A0A0", Offset = "0x27788A0", VA = "0x18277A0A0")]
	[CompilerGenerated]
	internal static LOPKGCKGDOL GOFOMKLNHBB([In] PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>> NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2779F40", Offset = "0x2778740", VA = "0x182779F40")]
	[CompilerGenerated]
	internal static BOFIAHAONCJ GHCFNEOMJBG([In] PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>> NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OGONKHNMHLJ : IEnumerator<NLPIAAOFKEO<KGLBPIDLJAB>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private KMIAFJKGENC KPLCJIEDJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly OABOCIAOEJE<GCOKIOOPJJN, NLPIAAOFKEO<KGLBPIDLJAB>> AHODBEODGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private EEBGNHBBELO DAKIJJDGLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly OABOCIAOEJE<BFEAKKGKCCO, NLPIAAOFKEO<KGLBPIDLJAB>> ANBCGMHMFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private bool DIEJACAPJBG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly NLPIAAOFKEO<KGLBPIDLJAB> IECKFCICFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x277E6E0", Offset = "0x277CEE0", VA = "0x18277E6E0", Slot = "4")]
		get
		{
			return default(NLPIAAOFKEO<KGLBPIDLJAB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x277E5E0", Offset = "0x277CDE0", VA = "0x18277E5E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x277E630", Offset = "0x277CE30", VA = "0x18277E630")]
	internal OGONKHNMHLJ([In] KMIAFJKGENC GENJFBMCAGD, [In] OABOCIAOEJE<GCOKIOOPJJN, NLPIAAOFKEO<KGLBPIDLJAB>> NKCBGGDDCOM, [In] EEBGNHBBELO LMNLPDKHDDM, [In] OABOCIAOEJE<BFEAKKGKCCO, NLPIAAOFKEO<KGLBPIDLJAB>> PDNLIJBHFDM, bool BFAFILJMGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x277E4E0", Offset = "0x277CCE0", VA = "0x18277E4E0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x277E530", Offset = "0x277CD30", VA = "0x18277E530", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x277E440", Offset = "0x277CC40", VA = "0x18277E440", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal struct CMKGOEBEAAJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public DPFLMJLLNFF<BFEAKKGKCCO> KMMLBAFNILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OABOCIAOEJE<BFEAKKGKCCO, NLPIAAOFKEO<KGLBPIDLJAB>> FJEIKHDKLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OABOCIAOEJE<BFEAKKGKCCO, PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>> MGGBGLEGENI;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2776C50", Offset = "0x2775450", VA = "0x182776C50")]
	public CMKGOEBEAAJ([In] DPFLMJLLNFF<BFEAKKGKCCO> GFLKAHBLNKA, [In] OABOCIAOEJE<BFEAKKGKCCO, NLPIAAOFKEO<KGLBPIDLJAB>> CHHNLHCEBAM, [In] OABOCIAOEJE<BFEAKKGKCCO, PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>> FDHEHNFLELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2776420", Offset = "0x2774C20", VA = "0x182776420")]
	public static CMKGOEBEAAJ CJOJELENPLJ()
	{
		return default(CMKGOEBEAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2776500", Offset = "0x2774D00", VA = "0x182776500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x27769A0", Offset = "0x27751A0", VA = "0x1827769A0")]
	public readonly NEEDEFPBKEE LIJGMGKAKKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x27768E0", Offset = "0x27750E0", VA = "0x1827768E0")]
	public NLPIAAOFKEO<BFEAKKGKCCO> LIDOJKMJGCF(NLPIAAOFKEO<KGLBPIDLJAB> GDFCBMOFMFN)
	{
		return default(NLPIAAOFKEO<BFEAKKGKCCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2776800", Offset = "0x2775000", VA = "0x182776800")]
	public void IHLFGIKCBJJ(NLPIAAOFKEO<BFEAKKGKCCO> MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x27766A0", Offset = "0x2774EA0", VA = "0x1827766A0")]
	[CompilerGenerated]
	internal static NIIBFNAPGNG HJFKCMMNCDL([In] PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>> NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EEBGNHBBELO : IEnumerator<NLPIAAOFKEO<BFEAKKGKCCO>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM BKCNAHJHPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>.FCGDBKGLPLM EHGGOFHPGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly OABOCIAOEJE<GCOKIOOPJJN, PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>> FLKFHEANJIO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NLPIAAOFKEO<BFEAKKGKCCO> IECKFCICFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2777940", Offset = "0x2776140", VA = "0x182777940", Slot = "4")]
		get
		{
			return default(NLPIAAOFKEO<BFEAKKGKCCO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2777870", Offset = "0x2776070", VA = "0x182777870", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x27778E0", Offset = "0x27760E0", VA = "0x1827778E0")]
	internal EEBGNHBBELO([In] PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>.FCGDBKGLPLM APLLKKHHKLF, [In] PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>.FCGDBKGLPLM FKEMLCJEMPC, [In] OABOCIAOEJE<GCOKIOOPJJN, PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>> KCBPFNOGDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x27776D0", Offset = "0x2775ED0", VA = "0x1827776D0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2777810", Offset = "0x2776010", VA = "0x182777810", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2777670", Offset = "0x2775E70", VA = "0x182777670", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class DALHFPDHDPM
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2776FE0", Offset = "0x27757E0", VA = "0x182776FE0")]
	public static IEPDKFABIIO MPBEICGIKAG(this CCEEPFDCDEG NFOGFJOGLPE)
	{
		return default(IEPDKFABIIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2776CC0", Offset = "0x27754C0", VA = "0x182776CC0")]
	public static void IHLFGIKCBJJ(this CCEEPFDCDEG NFOGFJOGLPE, int MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2776DD0", Offset = "0x27755D0", VA = "0x182776DD0")]
	[CompilerGenerated]
	internal static PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>> JPEEEMDMKJC(LOPKGCKGDOL NFOGFJOGLPE)
	{
		return default(PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2777460", Offset = "0x2775C60", VA = "0x182777460")]
	[CompilerGenerated]
	internal static PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>> OAAOPOBKCMC(BOFIAHAONCJ NFOGFJOGLPE)
	{
		return default(PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IBMHFNGBDCJ
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2779570", Offset = "0x2777D70", VA = "0x182779570")]
	public static MOBJABBAOJK MPBEICGIKAG(this MOMGKBONDJE NFOGFJOGLPE)
	{
		return default(MOBJABBAOJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2778510", Offset = "0x2776D10", VA = "0x182778510")]
	public static NLPIAAOFKEO<GCOKIOOPJJN> CFKCIPDOAOK(this MOMGKBONDJE NFOGFJOGLPE, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<LHDAOLHHICL> KFAILCHCEPI)
	{
		return default(NLPIAAOFKEO<GCOKIOOPJJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2779A10", Offset = "0x2778210", VA = "0x182779A10")]
	public static PFNCDBFLBAH<NLPIAAOFKEO<GCOKIOOPJJN>, DHJIKHIMNHO<GCOKIOOPJJN>.OICECCGJPIJ> NMKAMKCCFGF(this MOMGKBONDJE NFOGFJOGLPE, NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return default(PFNCDBFLBAH<NLPIAAOFKEO<GCOKIOOPJJN>, DHJIKHIMNHO<GCOKIOOPJJN>.OICECCGJPIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x27784A0", Offset = "0x2776CA0", VA = "0x1827784A0")]
	public static IEnumerable<int> CEMDLCIKHLK(this MOMGKBONDJE NFOGFJOGLPE, int OPPFCAMGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2779B10", Offset = "0x2778310", VA = "0x182779B10")]
	public static int PAEMEIJLDMO(this MOMGKBONDJE NFOGFJOGLPE, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2779210", Offset = "0x2777A10", VA = "0x182779210")]
	public static int KBKFDJMHHMO(this MOMGKBONDJE NFOGFJOGLPE, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2779960", Offset = "0x2778160", VA = "0x182779960")]
	public static NLPIAAOFKEO<BFEAKKGKCCO> MPELBHPEMKK(this MOMGKBONDJE NFOGFJOGLPE, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA, NLPIAAOFKEO<EKLADAEAEJL> ANCLACDALFJ)
	{
		return default(NLPIAAOFKEO<BFEAKKGKCCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x27790A0", Offset = "0x27778A0", VA = "0x1827790A0")]
	public static PFNCDBFLBAH<NLPIAAOFKEO<BFEAKKGKCCO>, DHJIKHIMNHO<BFEAKKGKCCO>.OICECCGJPIJ> JDBACEBHECF(this MOMGKBONDJE NFOGFJOGLPE, NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return default(PFNCDBFLBAH<NLPIAAOFKEO<BFEAKKGKCCO>, DHJIKHIMNHO<BFEAKKGKCCO>.OICECCGJPIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x27791A0", Offset = "0x27779A0", VA = "0x1827791A0")]
	public static IEnumerable<int> JKANBGPOBIB(this MOMGKBONDJE NFOGFJOGLPE, int OPPFCAMGFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x27785C0", Offset = "0x2776DC0", VA = "0x1827785C0")]
	public static NLPIAAOFKEO<KGLBPIDLJAB> CGEAOLDCFPP(this MOMGKBONDJE NFOGFJOGLPE, NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
		return default(NLPIAAOFKEO<KGLBPIDLJAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2779030", Offset = "0x2777830", VA = "0x182779030")]
	public static NLPIAAOFKEO<KGLBPIDLJAB> IBJAAHEFCJH(this MOMGKBONDJE NFOGFJOGLPE, NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
		return default(NLPIAAOFKEO<KGLBPIDLJAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2779290", Offset = "0x2777A90", VA = "0x182779290")]
	public static void LBCFGBOHNDC(this MOMGKBONDJE NFOGFJOGLPE, NLPIAAOFKEO<GCOKIOOPJJN> ECEBGAIHGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2778910", Offset = "0x2777110", VA = "0x182778910")]
	public static void HCICIIILIPC(this MOMGKBONDJE NFOGFJOGLPE, int OPPFCAMGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2778630", Offset = "0x2776E30", VA = "0x182778630")]
	public static void GNBMHHHDKCA(this MOMGKBONDJE NFOGFJOGLPE, NLPIAAOFKEO<BFEAKKGKCCO> GHICKGEHGDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class CGOEBOFBALG
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2775FA0", Offset = "0x27747A0", VA = "0x182775FA0")]
	public static JMAJDEBHCCM MPBEICGIKAG(this DJBEOPCOBEI NFOGFJOGLPE)
	{
		return default(JMAJDEBHCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2775ED0", Offset = "0x27746D0", VA = "0x182775ED0")]
	public static void IHLFGIKCBJJ(this DJBEOPCOBEI NFOGFJOGLPE, int MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2775CC0", Offset = "0x27744C0", VA = "0x182775CC0")]
	[CompilerGenerated]
	internal static PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>> CPECEDJFDGC(CALOOPCMDAK NFOGFJOGLPE)
	{
		return default(PFLMDAPEOIN<NLPIAAOFKEO<BFEAKKGKCCO>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal static class EMHBNIMKLME
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2778020", Offset = "0x2776820", VA = "0x182778020")]
	public static CMKGOEBEAAJ MPBEICGIKAG(this NEEDEFPBKEE NFOGFJOGLPE)
	{
		return default(CMKGOEBEAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2777D40", Offset = "0x2776540", VA = "0x182777D40")]
	public static void IHLFGIKCBJJ(this NEEDEFPBKEE NFOGFJOGLPE, int MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2777E10", Offset = "0x2776610", VA = "0x182777E10")]
	[CompilerGenerated]
	internal static PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>> LOGBNOJBGJJ(NIIBFNAPGNG NFOGFJOGLPE)
	{
		return default(PFLMDAPEOIN<NLPIAAOFKEO<GCOKIOOPJJN>>);
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

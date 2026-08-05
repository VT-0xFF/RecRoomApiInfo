using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.ObjectModel;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Networking_Experiment_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85F6390", Offset = "0x85F4990", VA = "0x1885F6390", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HCKBIEPELFM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLCHBCGBAPI(OBHLIKKGGFI ENMBHGMENHL, bool OIMEEMPLNHI = false);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FPGCCIOPGHJ(OBHLIKKGGFI[] GKALKDCGDJC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LADGNPLFONN();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MPEKMCNJBHJ(int JCBIELMJFID, int MGKEEIKKKDN, bool BGNPJGNBDDP, GameObject JJEACKINPOJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJJGPKEKEOB(int MGKEEIKKKDN, [Optional] int? BMJHIECPJIH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ANCNGJBMCNC(NDDAOAIJPDM CBIMJBOHKKP, [Out] OBHLIKKGGFI MDNGLGKBAIP, bool ELFGFOHDJMI = true);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OFAJKCPBFMJ(NDDAOAIJPDM CBIMJBOHKKP, [Out] int HPBNEHBIONP, [Out] OBHLIKKGGFI[] GKALKDCGDJC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PMIHPMHPLCP(NDDAOAIJPDM CBIMJBOHKKP, [Out] int MGKEEIKKKDN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HDFBCANOJON(NDDAOAIJPDM CBIMJBOHKKP, [Out] int PCAHNNIBKBK, [Out] int[] LMECGFFCALK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HCOIPDCHCKC(int HPBNEHBIONP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MFFBPJONGFJ(int HPBNEHBIONP, int[] LMECGFFCALK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EOCFBMMIPIA(int[] LMECGFFCALK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HCANELHLEKC(int[] LMECGFFCALK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LNIIEMFMEPL(int HPBNEHBIONP, int MGKEEIKKKDN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GANEPLMJMLL
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NADEFEMGAND(ViewId JCBIELMJFID);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FPFOLHHNHIM(NDDAOAIJPDM CBIMJBOHKKP, [Out] ViewId JCBIELMJFID, [Out] string HFFKJPDLDPD, [Out] int MEIHIEPFMPH, [Out] object[] MGPPHEGFGJP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGHINPDPDBM(ViewId EPNGEANGHIF, string HFFKJPDLDPD, JCJIPGJBFOG GKHJONMBNCD, MEINMPIOLGA AGIMJJDFEAF, DIAEAGCMBLG OIPFPGJBCLL, object[] ENMBHGMENHL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HEADNLGAOFF : NAICMPCIHAH, AHLBFLGEMBG, CEFAIAFEDDC, LHELGJDFGCA, IDOMFCOODOJ, LMDECLFEPME, NFBOJFIGOOE, HJCADCECDLB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private NAICMPCIHAH IGLALLOBGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85F35F0", Offset = "0x85F1BF0", VA = "0x1885F35F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float GNEFBJCGICE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85F4DC0", Offset = "0x85F33C0", VA = "0x1885F4DC0", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ALMFAKMOCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85F2AC0", Offset = "0x85F10C0", VA = "0x1885F2AC0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HMCHAHBAEDD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85F5290", Offset = "0x85F3890", VA = "0x1885F5290", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ACIEEJKEAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85F4160", Offset = "0x85F2760", VA = "0x1885F4160", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CNHBLGKNIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85F5620", Offset = "0x85F3C20", VA = "0x1885F5620", Slot = "17")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float NHOEGFOFNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85F3210", Offset = "0x85F1810", VA = "0x1885F3210", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public float OKKCHCIBFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85F4B10", Offset = "0x85F3110", VA = "0x1885F4B10", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DMKEKGNGEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85F4A80", Offset = "0x85F3080", VA = "0x1885F4A80", Slot = "26")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double COHKBGGHDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85F2C50", Offset = "0x85F1250", VA = "0x1885F2C50", Slot = "28")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FGDJOPOONMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85F2230", Offset = "0x85F0830", VA = "0x1885F2230", Slot = "29")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool CHKNHCOCIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85F4060", Offset = "0x85F2660", VA = "0x1885F4060", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public OHBJKFKAMJM MGOKIAEJCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85F2560", Offset = "0x85F0B60", VA = "0x1885F2560", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JBHPEMNBKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85F4CB0", Offset = "0x85F32B0", VA = "0x1885F4CB0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KNGJNLHKGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85F2D50", Offset = "0x85F1350", VA = "0x1885F2D50", Slot = "37")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool CFEEBCNFDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85F4FD0", Offset = "0x85F35D0", VA = "0x1885F4FD0", Slot = "39")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85F21A0", Offset = "0x85F07A0", VA = "0x1885F21A0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool GNPPGGBCCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85F3630", Offset = "0x85F1C30", VA = "0x1885F3630", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DMOJCIPDMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85F5840", Offset = "0x85F3E40", VA = "0x1885F5840", Slot = "42")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public object HOINAFKFKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F40", Offset = "0x85F3540", VA = "0x1885F4F40", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool BNDDKBMBBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85F3CC0", Offset = "0x85F22C0", VA = "0x1885F3CC0", Slot = "44")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85F5A60", Offset = "0x85F4060", VA = "0x1885F5A60", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MEINMPIOLGA KPFDOFKDHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85F5720", Offset = "0x85F3D20", VA = "0x1885F5720", Slot = "66")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int KBBLEKKGKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85F40E0", Offset = "0x85F26E0", VA = "0x1885F40E0", Slot = "67")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PACGCBGHHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85F2A40", Offset = "0x85F1040", VA = "0x1885F2A40", Slot = "68")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MEINMPIOLGA PFCGDMMCNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85F3DE0", Offset = "0x85F23E0", VA = "0x1885F3DE0", Slot = "69")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool OPHODICPLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85F1D00", Offset = "0x85F0300", VA = "0x1885F1D00", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int DCBGDKBHDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85F26E0", Offset = "0x85F0CE0", VA = "0x1885F26E0", Slot = "71")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string MGNHNKMFPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85F2090", Offset = "0x85F0690", VA = "0x1885F2090", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Func<string, string> KHHDJBGKKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85F2B40", Offset = "0x85F1140", VA = "0x1885F2B40", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public APNPJIHONFB NCJODLKCFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85F5C20", Offset = "0x85F4220", VA = "0x1885F5C20", Slot = "84")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool AEGKNAAJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85F56A0", Offset = "0x85F3CA0", VA = "0x1885F56A0", Slot = "30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85F29B0", Offset = "0x85F0FB0", VA = "0x1885F29B0", Slot = "31")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string NCCDKPFKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85F42F0", Offset = "0x85F28F0", VA = "0x1885F42F0", Slot = "85")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long FGPAFPDBJOC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85F4A00", Offset = "0x85F3000", VA = "0x1885F4A00", Slot = "86")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long HNMLGLHIDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85F3C40", Offset = "0x85F2240", VA = "0x1885F3C40", Slot = "87")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action MGFIIJJEECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85F38C0", Offset = "0x85F1EC0", VA = "0x1885F38C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85F5150", Offset = "0x85F3750", VA = "0x1885F5150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<OHBJKFKAMJM, OHBJKFKAMJM> MMCLCBFHCEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85F3440", Offset = "0x85F1A40", VA = "0x1885F3440", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85F1E30", Offset = "0x85F0430", VA = "0x1885F1E30", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<bool> EDJJMKNCBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85F5C70", Offset = "0x85F4270", VA = "0x1885F5C70", Slot = "50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85F2760", Offset = "0x85F0D60", VA = "0x1885F2760", Slot = "51")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<string, long> FNLMEOJMHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85F1D80", Offset = "0x85F0380", VA = "0x1885F1D80", Slot = "59")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85F3B90", Offset = "0x85F2190", VA = "0x1885F3B90", Slot = "60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<NDDAOAIJPDM> OIDCBMIFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85F30F0", Offset = "0x85F16F0", VA = "0x1885F30F0", Slot = "61")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85F24C0", Offset = "0x85F0AC0", VA = "0x1885F24C0", Slot = "62")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<MEINMPIOLGA> MCIFEABBMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85F3960", Offset = "0x85F1F60", VA = "0x1885F3960", Slot = "64")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85F57A0", Offset = "0x85F3DA0", VA = "0x1885F57A0", Slot = "65")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action FGJOKFHIKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85F51F0", Offset = "0x85F37F0", VA = "0x1885F51F0", Slot = "81")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85F59C0", Offset = "0x85F3FC0", VA = "0x1885F59C0", Slot = "82")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85F34F0", Offset = "0x85F1AF0", VA = "0x1885F34F0")]
	[EGNICHGEFDG.KHJDAJHJKCM.GHFDKJOPLIL]
	internal static void FBMOEFONPBI(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85F6060", Offset = "0x85F4660", VA = "0x1885F6060")]
	[Preserve]
	public HEADNLGAOFF([EDHLHMEHMKO(null)] KOKHKIMHGDN KKBKIBCBEEP, [EDHLHMEHMKO(null)] PPDMNHJDNPO KBABFBFPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85F2EE0", Offset = "0x85F14E0", VA = "0x1885F2EE0", Slot = "89")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x85F4500", Offset = "0x85F2B00", VA = "0x1885F4500")]
	private void KDMCBCLBONP(NAICMPCIHAH GGKBHEFBGKO, NAICMPCIHAH GPHHOLLCMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x134F7B0", Offset = "0x134DDB0", VA = "0x18134F7B0")]
	private void BFFLNBNDFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x85F2810", Offset = "0x85F0E10", VA = "0x1885F2810")]
	private void CKLEMCHNNPC(OHBJKFKAMJM EEABELMIPJI, OHBJKFKAMJM NIAFOLJGPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xE67640", Offset = "0xE65C40", VA = "0x180E67640")]
	private void KCLDAAHBPCA(bool KBFGPLLMDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x25AE800", Offset = "0x25ACE00", VA = "0x1825AE800")]
	private void CGPIOEODEDB(string GPEIAHGICNA, long KAFKANIDHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x10B3500", Offset = "0x10B1B00", VA = "0x1810B3500")]
	private void PMNFCFFIGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x85F58C0", Offset = "0x85F3EC0", VA = "0x1885F58C0", Slot = "57")]
	public void NJDHEAJNCPB(StringBuilder HPKPMAMMCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x85F22B0", Offset = "0x85F08B0", VA = "0x1885F22B0", Slot = "14")]
	public void BEIKDCLJKAD(List<object> BBBJHCKNPGO, int NDMFOILAFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85F5E30", Offset = "0x85F4430", VA = "0x1885F5E30", Slot = "16")]
	public void PACPCFGNADO(object EKHHBKLNJDE, int JPKKOPNBEKB, bool FNNCBALLFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x85F5F50", Offset = "0x85F4550", VA = "0x1885F5F50", Slot = "20")]
	public void PEBAJADHGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x85F3B00", Offset = "0x85F2100", VA = "0x1885F3B00", Slot = "49")]
	public bool GJGLHDFOBIA(object HDOBFKICCHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x85F5050", Offset = "0x85F3650", VA = "0x1885F5050", Slot = "22")]
	public object LPNJIHLFELG(NativeArray<byte> CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x85F5520", Offset = "0x85F3B20", VA = "0x1885F5520", Slot = "23")]
	public int MGNOCJDGOCF(NDDAOAIJPDM CBIMJBOHKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x85F4EC0", Offset = "0x85F34C0", VA = "0x1885F4EC0", Slot = "48")]
	public void LILDAAPKGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x85F25E0", Offset = "0x85F0BE0", VA = "0x1885F25E0", Slot = "15")]
	public void CCAKJHLMEAK(int EAHHAHHANOL, object CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x85F3D40", Offset = "0x85F2340", VA = "0x1885F3D40", Slot = "76")]
	public MEINMPIOLGA IAFNOHJJOGN(int NODOENPBIEC, bool INDECHPKAEO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85F4460", Offset = "0x85F2A60", VA = "0x1885F4460", Slot = "75")]
	public MEINMPIOLGA JPENGCFJFPO(int NMBBIDCMGIO, bool INDECHPKAEO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85F3A00", Offset = "0x85F2000", VA = "0x1885F3A00", Slot = "77")]
	public MEINMPIOLGA GJEHMLGEOPE(int NMBBIDCMGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85F3E60", Offset = "0x85F2460", VA = "0x1885F3E60", Slot = "56")]
	public bool ICFJHCNKKBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85F3190", Offset = "0x85F1790", VA = "0x1885F3190", Slot = "11")]
	public bool ENPEKLKNGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x85F2000", Offset = "0x85F0600", VA = "0x1885F2000", Slot = "78")]
	public IReadOnlyList<MEINMPIOLGA> AOBKCBCGJCI(bool INDECHPKAEO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85F3FD0", Offset = "0x85F25D0", VA = "0x1885F3FD0", Slot = "79")]
	public IReadOnlyList<MEINMPIOLGA> IFBEAPPPNEM(bool INDECHPKAEO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x85F23C0", Offset = "0x85F09C0", VA = "0x1885F23C0", Slot = "47")]
	public bool BHABAIMDJBA(string NDLDAJEDFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x85F2DD0", Offset = "0x85F13D0", VA = "0x1885F2DD0", Slot = "46")]
	public bool DOHINIGMAHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x85F5D20", Offset = "0x85F4320", VA = "0x1885F5D20", Slot = "58")]
	public bool OLPBGODHDFO(bool IALBHFEGHCA, [Out] string DAANGKEHOHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85F4980", Offset = "0x85F2F80", VA = "0x1885F4980", Slot = "13")]
	public void KGBAMNIJMIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85F37C0", Offset = "0x85F1DC0", VA = "0x1885F37C0", Slot = "55")]
	public IDisposable FNEKMNKEMIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x85F5AF0", Offset = "0x85F40F0", VA = "0x1885F5AF0", Slot = "63")]
	public bool OCGDKHDBJGH(byte NLMJOFNGIOJ, object EJBPFCPIDKI, CIJKFJMOGHC KNBPPAKDDHK, OFKCPCBBNAB AFKPOIFBEPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x85F43E0", Offset = "0x85F29E0", VA = "0x1885F43E0", Slot = "83")]
	public void JOFEMLBGNPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85F41E0", Offset = "0x85F27E0", VA = "0x1885F41E0", Slot = "12")]
	public void JBDBHBCAPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x85F1EE0", Offset = "0x85F04E0", VA = "0x1885F1EE0", Slot = "21")]
	public void ANHNANMIGBP(object MPIDDJPOOMJ, NativeList<byte> CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x85F5420", Offset = "0x85F3A20", VA = "0x1885F5420", Slot = "38")]
	public void MGNLFNMEBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x85F4C30", Offset = "0x85F3230", VA = "0x1885F4C30", Slot = "18")]
	public void KOJGMODHLAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x85F3840", Offset = "0x85F1E40", VA = "0x1885F3840", Slot = "19")]
	public void FONCEKIAEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x85F5FD0", Offset = "0x85F45D0", VA = "0x1885F5FD0", Slot = "80")]
	public bool PFNCPLADJAN(MEINMPIOLGA GJLDAIKCCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x85F4260", Offset = "0x85F2860", VA = "0x1885F4260", Slot = "52")]
	public void JCDDANPJEHF(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x85F36B0", Offset = "0x85F1CB0", VA = "0x1885F36B0", Slot = "54")]
	public void FJIEPNAAHKB(object INEEADCBMPK, bool KBFGPLLMDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x85F4D30", Offset = "0x85F3330", VA = "0x1885F4D30", Slot = "53")]
	public void KPOOBNHJLPM(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x85F2E50", Offset = "0x85F1450", VA = "0x1885F2E50", Slot = "27")]
	public void DOLHFNNIBOJ(string NHDBEANECII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x85F5310", Offset = "0x85F3910", VA = "0x1885F5310", Slot = "10")]
	public float MDOJBNGHPMF(bool POONFKAOGBG, int BIKKHMAEGMH = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x85F3330", Offset = "0x85F1930", VA = "0x1885F3330", Slot = "74")]
	public void EOEBEPDJCEL(string NDIENANOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x85F2930", Offset = "0x85F0F30", VA = "0x1885F2930", Slot = "88")]
	public int COKKGJOKJCH()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KALILONNKKK
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Photon,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	GameServer
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.Application)]
public interface KOKHKIMHGDN
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[ServiceLifetime(Lifetime.Application)]
public interface PPDMNHJDNPO
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DJAOPHJJPDI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static KALILONNKKK OAABGNIGIAC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static KALILONNKKK LAJBNKOKEHC;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static bool DIOLDCOODJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85F18E0", Offset = "0x85EFEE0", VA = "0x1885F18E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static KALILONNKKK ECMJAJDLJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85F10B0", Offset = "0x85EF6B0", VA = "0x1885F10B0")]
		get
		{
			return default(KALILONNKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static NAICMPCIHAH OPDHCIOALHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x85F1780", Offset = "0x85EFD80", VA = "0x1885F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85F14F0", Offset = "0x85EFAF0", VA = "0x1885F14F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static NAICMPCIHAH ODNNKJAJOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85F1100", Offset = "0x85EF700", VA = "0x1885F1100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85F1870", Offset = "0x85EFE70", VA = "0x1885F1870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static NAICMPCIHAH IGLALLOBGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85F1210", Offset = "0x85EF810", VA = "0x1885F1210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static HCKBIEPELFM AGDBCFNIIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85F19B0", Offset = "0x85EFFB0", VA = "0x1885F19B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85F1B70", Offset = "0x85F0170", VA = "0x1885F1B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static HCKBIEPELFM CAHLCPOGGNO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85F14A0", Offset = "0x85EFAA0", VA = "0x1885F14A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x85F1430", Offset = "0x85EFA30", VA = "0x1885F1430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static HCKBIEPELFM LICHKJAHBDF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x85F1320", Offset = "0x85EF920", VA = "0x1885F1320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static GANEPLMJMLL IOEHEJLIICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85F1150", Offset = "0x85EF750", VA = "0x1885F1150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x85F1940", Offset = "0x85EFF40", VA = "0x1885F1940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static GANEPLMJMLL LILDKMGKCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x85F0E30", Offset = "0x85EF430", VA = "0x1885F0E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x85F11A0", Offset = "0x85EF7A0", VA = "0x1885F11A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static GANEPLMJMLL POANBGBKOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85F1560", Offset = "0x85EFB60", VA = "0x1885F1560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event Action<NAICMPCIHAH, NAICMPCIHAH> KDMCBCLBONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85F0D20", Offset = "0x85EF320", VA = "0x1885F0D20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85F1670", Offset = "0x85EFC70", VA = "0x1885F1670")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x85F1BE0", Offset = "0x85F01E0", VA = "0x1885F1BE0")]
	static DJAOPHJJPDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x85F0F30", Offset = "0x85EF530", VA = "0x1885F0F30")]
	public static void BDBKJLHAGCA(KOKHKIMHGDN KKBKIBCBEEP, PPDMNHJDNPO KBABFBFPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x85F1A00", Offset = "0x85F0000", VA = "0x1885F1A00")]
	public static void OMPLLEJGDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x85F0E80", Offset = "0x85EF480", VA = "0x1885F0E80")]
	private static void AMMKEMCIDOA(KALILONNKKK PONLNACHBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x85F17D0", Offset = "0x85EFDD0", VA = "0x1885F17D0")]
	private static void LCNEMACFLNB(ENLEPBNNKEG GBLKGLDKKGF)
	{
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

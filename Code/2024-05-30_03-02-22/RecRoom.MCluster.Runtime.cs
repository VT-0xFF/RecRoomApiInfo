using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.MCluster;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct GNABFAMEBGE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] CNKEKOCHBGG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] CNOKCDHOLNI;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] KEIKIOJAGNE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD96860", Offset = "0xD95A60", VA = "0x180D96860")]
	public static int EEILLPDEBJG(FDGFKCFHLBH HEJPMNEGHKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6442910", Offset = "0x6441B10", VA = "0x186442910")]
	public static int DBKKIFEFJLC(FDGFKCFHLBH HEJPMNEGHKB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FPCHPFFPIFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int DELNKALBBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PGOEEDICGMC DONCFJLOJHD(int IMEBMAMHMJD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 OIIKICEDKGE(int IMEBMAMHMJD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KLLANJMFCIJ FNOJDKHIGPH();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FDBLAAIALEN GKPJJMGOPCN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LCMPEKEBDKI : BBIMPHAGKAM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KLLANJMFCIJ HANHCEFMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform MCPDIFJJLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<MHIOBMFICDG> IMOIIGFHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BNCCFFJHNHM EPKCEGLBEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private OLCGBPDHKPP JKAKJDHGJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool ECCNCNGFNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private FPCHPFFPIFJ IJJMEPMPJAE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float PBAHNDPLFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8346B0", Offset = "0x8338B0", VA = "0x1808346B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F8EE0", Offset = "0x9F80E0", VA = "0x1809F8EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HOEABLJPPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x913800", Offset = "0x912A00", VA = "0x180913800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9138B0", Offset = "0x912AB0", VA = "0x1809138B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool AINGMHHNHPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x10784B0", Offset = "0x10776B0", VA = "0x1810784B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1077D80", Offset = "0x1076F80", VA = "0x181077D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool FHMOGPBMCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64444E0", Offset = "0x64436E0", VA = "0x1864444E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x64440C0", Offset = "0x64432C0", VA = "0x1864440C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OJKCAIHOAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x131D320", Offset = "0x131C520", VA = "0x18131D320", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6445320", Offset = "0x6444520", VA = "0x186445320")]
	public LCMPEKEBDKI(FPCHPFFPIFJ MBDIAFEJCBP, bool MPNNLNCBOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64444F0", Offset = "0x64436F0", VA = "0x1864444F0")]
	private bool HHAGAEEGGDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6444710", Offset = "0x6443910", VA = "0x186444710", Slot = "4")]
	public bool LGLNKEHGBKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6444300", Offset = "0x6443500", VA = "0x186444300", Slot = "5")]
	public bool DBKEHPIBNHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64440D0", Offset = "0x64432D0", VA = "0x1864440D0", Slot = "6")]
	public void BIFLKBKPGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x64444D0", Offset = "0x64436D0", VA = "0x1864444D0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GIOEIENBGGB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JECEPGGCBEF(CommandBuffer DHAMGOCKPFO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MANAJKIHBFA : GIOEIENBGGB
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int ALHOENKOJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier IAONGPPGIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3F24800", Offset = "0x3F23A00", VA = "0x183F24800")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6445430", Offset = "0x6444630", VA = "0x186445430")]
	public MANAJKIHBFA(int IFAFPBGLEJO, RenderTargetIdentifier JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x64453E0", Offset = "0x64445E0", VA = "0x1864453E0", Slot = "4")]
	public void JECEPGGCBEF(CommandBuffer DHAMGOCKPFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct ICILKDGIFIL : GIOEIENBGGB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int ALHOENKOJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] OKJHCMOHLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x837D60", Offset = "0x836F60", VA = "0x180837D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xCE5780", Offset = "0xCE4980", VA = "0x180CE5780")]
	public ICILKDGIFIL(int IFAFPBGLEJO, Vector4[] JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6443000", Offset = "0x6442200", VA = "0x186443000", Slot = "4")]
	public void JECEPGGCBEF(CommandBuffer DHAMGOCKPFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct EGNBCNKLOAF : GIOEIENBGGB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int ALHOENKOJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] MOOADEDHBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x837D60", Offset = "0x836F60", VA = "0x180837D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xCE5780", Offset = "0xCE4980", VA = "0x180CE5780")]
	public EGNBCNKLOAF(int IFAFPBGLEJO, float[] JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x64415F0", Offset = "0x64407F0", VA = "0x1864415F0", Slot = "4")]
	public void JECEPGGCBEF(CommandBuffer DHAMGOCKPFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KPEJHIBMDBM : GIOEIENBGGB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool EHNLPDCDCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1ADD2E0", Offset = "0x1ADC4E0", VA = "0x181ADD2E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3906230", Offset = "0x3905430", VA = "0x183906230")]
	public KPEJHIBMDBM(string IIADHBOODBK, bool IJMGAKGNGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6444080", Offset = "0x6443280", VA = "0x186444080", Slot = "4")]
	public void JECEPGGCBEF(CommandBuffer DHAMGOCKPFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct FDBLAAIALEN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 ILGAOBANMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 GFKJMGENKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83B450", Offset = "0x83A650", VA = "0x18083B450")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int CFADPLNCNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x831BC0", Offset = "0x830DC0", VA = "0x180831BC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IOIJFKGMCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x807FC0", Offset = "0x8071C0", VA = "0x180807FC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float JBADMLBIPGB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x834710", Offset = "0x833910", VA = "0x180834710")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6441810", Offset = "0x6440A10", VA = "0x186441810")]
	public FDBLAAIALEN(Color LHAAJEOMGEG, int OHPHEEKKPLI, int ANKFEMDGJKO, float DKLPPEACDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8843A0", Offset = "0x8835A0", VA = "0x1808843A0")]
	private static float4 JACIOKINLEM(Color LHAAJEOMGEG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6441780", Offset = "0x6440980", VA = "0x186441780")]
	private static Hash128 FIJFAHEIFIN(FDBLAAIALEN MBDIAFEJCBP)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BNCCFFJHNHM : BBIMPHAGKAM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string DDAMGJBPJHJ;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string EGFHHEFGCGF;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string KLHKKFJMLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private FDBLAAIALEN EHDDJAGLPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private BBJPFDHFEEF OOHAKCENEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 AKCKIAOBCII;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public OLCGBPDHKPP MAMFLEJGABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F0060", Offset = "0x7EF260", VA = "0x1807F0060")]
		[CompilerGenerated]
		get
		{
			return default(OLCGBPDHKPP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA12E40", Offset = "0xA12040", VA = "0x180A12E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HOEABLJPPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x549C120", Offset = "0x549B320", VA = "0x18549C120")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x549C130", Offset = "0x549B330", VA = "0x18549C130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool AINGMHHNHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1E33F70", Offset = "0x1E33170", VA = "0x181E33F70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x61E22E0", Offset = "0x61E14E0", VA = "0x1861E22E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OJKCAIHOAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool FHMOGPBMCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5553B00", Offset = "0x5552D00", VA = "0x185553B00", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x61E2250", Offset = "0x61E1450", VA = "0x1861E2250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int DMDPAHAMEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x64406A0", Offset = "0x643F8A0", VA = "0x1864406A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6440D40", Offset = "0x643FF40", VA = "0x186440D40")]
	public BNCCFFJHNHM(FDBLAAIALEN LFDBOGKPJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x64409B0", Offset = "0x643FBB0", VA = "0x1864409B0")]
	private bool HHAGAEEGGDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6440AC0", Offset = "0x643FCC0", VA = "0x186440AC0", Slot = "4")]
	public bool LGLNKEHGBKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6440C10", Offset = "0x643FE10", VA = "0x186440C10")]
	private static BBJPFDHFEEF PCEKNEJEDPA(FDBLAAIALEN MBDIAFEJCBP)
	{
		return default(BBJPFDHFEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6440800", Offset = "0x643FA00", VA = "0x186440800", Slot = "5")]
	public bool DBKEHPIBNHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x64406F0", Offset = "0x643F8F0", VA = "0x1864406F0", Slot = "6")]
	public void BIFLKBKPGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "9")]
	public void Dispose()
	{
	}
}
namespace RecRoom.MCluster
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MClusterData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[Reload("Shaders/ClusterUpdate.compute", ReloadAttribute.Package.Root)]
			public ComputeShader UpdateShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Reload("Shaders/ClusterRaster.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ClusterRasterShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[Reload("Shaders/ClusterCoarseCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader CoarseCullShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[Reload("Shaders/ClusterFineCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader FineCullShader;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6445450", Offset = "0x6444650", VA = "0x186445450", Slot = "0")]
		public override bool Equals(object JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6445650", Offset = "0x6444850", VA = "0x186445650", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x834750", Offset = "0x833950", VA = "0x180834750")]
		public MClusterData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleRendererFeature(null)]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private FIJOPHBOGDD opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static NAAFELGIDII CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6445D20", Offset = "0x6444F20", VA = "0x186445D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6445D60", Offset = "0x6444F60", VA = "0x186445D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6445730", Offset = "0x6444930", VA = "0x186445730", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6445700", Offset = "0x6444900", VA = "0x186445700", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNDOIBEKKNI, RenderingData ILAACNNKCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6445B90", Offset = "0x6444D90", VA = "0x186445B90")]
		public void KMCMMEMNBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xCEE250", Offset = "0xCED450", VA = "0x180CEE250")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class NDGLHIGDIIL<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private KKGONODNLCJ KFEFJNPLIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KKGONODNLCJ IOGNHJEIBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer KMBKJBDCPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture OMACEDDHLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int OOHOJHONGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int EJACIKGDBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string OBPKNNMAHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string BEHEEKGJFNM;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7D45E0", Offset = "0x7D37E0", VA = "0x1807D45E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int IOJFGEGKEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xD0BDB0", Offset = "0xD0AFB0", VA = "0x180D0BDB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int AHMBFGLLAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7E69C0", Offset = "0x7E5BC0", VA = "0x1807E69C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4195D00", Offset = "0x4194F00", VA = "0x184195D00")]
	public NDGLHIGDIIL(string IIADHBOODBK, int DOLMFENHGHC, [Optional] RenderTextureFormat? IBEIMKOECHH, bool LDLBFDPBHBK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4192960", Offset = "0x4191B60", VA = "0x184192960")]
	public void DBKEHPIBNHN(CommandBuffer DHAMGOCKPFO, NativeArray<ValType> JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4194E80", Offset = "0x4194080", VA = "0x184194E80")]
	public void IOHGGACLKAB(CommandBuffer DHAMGOCKPFO, ComputeShader AHIFKEAEDKE, int PNOPEILJOEO, int BEKIDGAIEKB = -1, int MPEFOMAAPHI = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4194720", Offset = "0x4193920", VA = "0x184194720")]
	public void IOHGGACLKAB(Material OOHAKCENEJE, int BEKIDGAIEKB = -1, int MPEFOMAAPHI = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4193560", Offset = "0x4192760", VA = "0x184193560", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DIFBPPMCCLD
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOHGGACLKAB(Material LFDBOGKPJGC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NDHFJJBGHFB<SrcEntry, DstEntry> : DIFBPPMCCLD, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] LPADJNDBCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected KKGONODNLCJ NNJPFLAKHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected KKGONODNLCJ LDJGLHEEPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> CKFBCEPMFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> PAEALFECGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int NJADFCBPCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int LNPNACOJLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected NDGLHIGDIIL<int> NOJKFAGFHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected NDGLHIGDIIL<SrcEntry> LKELFMDFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected NDGLHIGDIIL<DstEntry> IALJKIPHBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader KEIAKCBEJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int NADBENCCAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int MOLGFBCOBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int BFKPLKHPKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int FPKMKEMIEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int DHGAIMLLKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int DJHIJNMLHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int GAIFJDEGOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int NKFFFMMKBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int KLJMHCGLFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int OKCNFLDBIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int JNMKBEDBOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int GBHIMKHBEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string JOBBJAKJHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] IICKPKNDFNK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BLFJFFIPIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4198210", Offset = "0x4197410", VA = "0x184198210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string MDLKJIPHGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x41983E0", Offset = "0x41975E0", VA = "0x1841983E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x419C340", Offset = "0x419B540", VA = "0x18419C340")]
	public NDHFJJBGHFB(string IIADHBOODBK, int HOMAIIGCHBM, int EKBNIONHLDO, RenderTextureFormat IBEIMKOECHH, ComputeShader LLEKDPAOOGJ, int NFLGBKIFJGB = 0, int BHIFPPEBCAF = 0, int BHPCINBNLLH = 0, int JKLLEBNKGFH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4197D80", Offset = "0x4196F80", VA = "0x184197D80")]
	public int DNHFILIBLCP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4197D30", Offset = "0x4196F30", VA = "0x184197D30")]
	protected void DGLNKDMKADC(int PMNHOLIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x41999A0", Offset = "0x4198BA0", VA = "0x1841999A0")]
	public OLCGBPDHKPP LGLNKEHGBKE(SrcEntry JLJKEBMIIPF)
	{
		return default(OLCGBPDHKPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4197760", Offset = "0x4196960", VA = "0x184197760")]
	public bool DBKEHPIBNHN(OLCGBPDHKPP DHPHAFDDMEE, SrcEntry JLJKEBMIIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4196FE0", Offset = "0x41961E0", VA = "0x184196FE0")]
	public bool BIFLKBKPGJE(OLCGBPDHKPP DHPHAFDDMEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "6")]
	protected virtual void NFKCJHCHBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4199EC0", Offset = "0x41990C0", VA = "0x184199EC0", Slot = "7")]
	public void ONMDAMKOJAM(CommandBuffer DHAMGOCKPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x419A500", Offset = "0x4199700", VA = "0x18419A500", Slot = "8")]
	public void ONMDAMKOJAM(CommandBuffer DHAMGOCKPFO, ComputeShader LLEKDPAOOGJ, int NFLGBKIFJGB = -1, int BHIFPPEBCAF = -1, int BHPCINBNLLH = -1, int JKLLEBNKGFH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4198220", Offset = "0x4197420", VA = "0x184198220", Slot = "9")]
	public void IOHGGACLKAB(CommandBuffer DHAMGOCKPFO, ComputeShader LLEKDPAOOGJ, int NFLGBKIFJGB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4198390", Offset = "0x4197590", VA = "0x184198390", Slot = "4")]
	public void IOHGGACLKAB(Material OOHAKCENEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x41980B0", Offset = "0x41972B0", VA = "0x1841980B0", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KKGONODNLCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong CGKHMCNCGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong BKFDJPALJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KGOLLDIGPDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct NBOONIEMEAL : KKGONODNLCJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable ODJHHINLGOI;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong CGKHMCNCGOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x837D60", Offset = "0x836F60", VA = "0x180837D60", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5C36FE0", Offset = "0x5C361E0", VA = "0x185C36FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong BKFDJPALJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x142DE70", Offset = "0x142D070", VA = "0x18142DE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x48851D0", Offset = "0x48843D0", VA = "0x1848851D0")]
		internal NBOONIEMEAL(IDisposable DEJIFECLDJE, ulong GDBAJMIHBCP, ulong NLIGIFAANKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x644EE70", Offset = "0x644E070", VA = "0x18644EE70", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct BFOJJDJAJBN : KKGONODNLCJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture LPJMPHFBCDJ;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong CGKHMCNCGOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x837D60", Offset = "0x836F60", VA = "0x180837D60", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5C36FE0", Offset = "0x5C361E0", VA = "0x185C36FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong BKFDJPALJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x142DE70", Offset = "0x142D070", VA = "0x18142DE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x64404D0", Offset = "0x643F6D0", VA = "0x1864404D0")]
		public BFOJJDJAJBN(RenderTexture LDDEKCHDPGH, ulong BEAAHCHOAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6440430", Offset = "0x643F630", VA = "0x186440430", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong EBKNKCHCJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6443D30", Offset = "0x6442F30", VA = "0x186443D30")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6444040", Offset = "0x6443240", VA = "0x186444040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong MBMDKLOCDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6443D70", Offset = "0x6442F70", VA = "0x186443D70")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6443DB0", Offset = "0x6442FB0", VA = "0x186443DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x64437B0", Offset = "0x64429B0", VA = "0x1864437B0")]
	public static ComputeBuffer ADOMMGOMPJC(int BIFLOKBJAPK, int MFFPPPKEHML, ComputeBufferType HHJOOHJDNNM, [Out] KKGONODNLCJ DHPHAFDDMEE, ComputeBufferMode CKIGLEMFOLA = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6443990", Offset = "0x6442B90", VA = "0x186443990")]
	public static RenderTexture ADOMMGOMPJC(int IPJDBOHPCBD, int BNEGPEKPMPM, int CHGLFFFCFCA, RenderTextureFormat IBEIMKOECHH, [Out] KKGONODNLCJ DHPHAFDDMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2A20330", Offset = "0x2A1F530", VA = "0x182A20330")]
	public static NativeArray<T> PANNCGEHIEC<T>(NativeArray<T> ODJHHINLGOI, ulong MKCBFIBLIDD, [Out] KKGONODNLCJ DHPHAFDDMEE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2A20290", Offset = "0x2A1F490", VA = "0x182A20290")]
	public static NativeArray<T> ADOMMGOMPJC<T>(int MKCBFIBLIDD, Allocator LGNDPBNMKMP, [Out] KKGONODNLCJ DHPHAFDDMEE, NativeArrayOptions PPBCABJPHLO = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6443DF0", Offset = "0x6442FF0", VA = "0x186443DF0")]
	public static void HJOADCBEFJH(KKGONODNLCJ ODJHHINLGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6443F40", Offset = "0x6443140", VA = "0x186443F40")]
	public static uint KHJBCAPGNMG(RenderTextureFormat IBEIMKOECHH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GIPOIPPELPB : NDHFJJBGHFB<BHAOKOINKJL, BHAOKOINKJL>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct GLDBLCHCLLI : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> LPKCEOBOMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> CKAOOFEAPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> BJPNPAFAMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> PBMKIEBOFFD;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6441DF0", Offset = "0x6440FF0", VA = "0x186441DF0")]
		public GLDBLCHCLLI(NativeArray<int> KMKDHAGMHIF, NativeArray<float> GLJJLANPDAB, NativeArray<float4x4> NKMHLEIMPIK, NativeArray<float4> PNOCJBJFGJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6442750", Offset = "0x6441950", VA = "0x186442750", Slot = "4")]
		public void Execute(int PMNHOLIPOMJ, TransformAccess HANHCEFMJDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct GENOCOEAJCJ : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> LPKCEOBOMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> DIGPDNGGBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> MAMKBBAMCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<BHAOKOINKJL> OEFMADKIFID;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6441DF0", Offset = "0x6440FF0", VA = "0x186441DF0")]
		public GENOCOEAJCJ(NativeArray<int> KMKDHAGMHIF, NativeArray<float4x4> EEPMOBPBOOD, NativeArray<float4> MAEDGPOOBDG, NativeArray<BHAOKOINKJL> MMPICMIHPIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6441D80", Offset = "0x6440F80", VA = "0x186441D80", Slot = "4")]
		public void Execute(int PMNHOLIPOMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte KPACCKHJHLD = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray MJICCJFMOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> OEEOLPPKJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> CNJCBNAKENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> PIKKLJJBMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> IPBLNPGPPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> JLJBOGONCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private KKGONODNLCJ ODNFLDPACPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private KKGONODNLCJ EEIIFBOHMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private KKGONODNLCJ NGIEFAAEIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private KKGONODNLCJ FIHFOCDPPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private KKGONODNLCJ JEIEFHCOKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform INALJECPHMF;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6442470", Offset = "0x6441670", VA = "0x186442470")]
	public GIPOIPPELPB(int HOMAIIGCHBM, int EKBNIONHLDO, ComputeShader LLEKDPAOOGJ, int NFLGBKIFJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6442270", Offset = "0x6441470", VA = "0x186442270", Slot = "6")]
	protected override void NFKCJHCHBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x64420D0", Offset = "0x64412D0", VA = "0x1864420D0")]
	private void GABIAMMEDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6441F70", Offset = "0x6441170", VA = "0x186441F70")]
	public bool FMCICFMEJLE(OLCGBPDHKPP DHPHAFDDMEE, Transform HANHCEFMJDD, float CLDELADKNLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6442190", Offset = "0x6441390", VA = "0x186442190")]
	public void KBKAGNBIKDO(OLCGBPDHKPP DHPHAFDDMEE, float CLDELADKNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6441EC0", Offset = "0x64410C0", VA = "0x186441EC0")]
	public void EIOENGFFNID(OLCGBPDHKPP DHPHAFDDMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6441E20", Offset = "0x6441020", VA = "0x186441E20", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PGOEEDICGMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FBPCJNPPGNE JDPAOPOAJJL();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EAAEDLFKPIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 ILGAOBANMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int BOGJAJJGCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int HOBAKICFGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> HFHFPGFAPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> BONJNMKEEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> LOPJOOMECKA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> HDMJIDCCPFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> OLLJBIKDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> ANFBJOJLOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int NFIFGGHCBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int KCEDBAEADOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int OKDALPNBEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool GKJMKMAFEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ONMDAMKOJAM();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KBACJGGACAE : EAAEDLFKPIP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private PGOEEDICGMC BHHLPOJGGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private FBPCJNPPGNE COKNMDIBDNP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 ILGAOBANMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x83B450", Offset = "0x83A650", VA = "0x18083B450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8E5680", Offset = "0x8E4880", VA = "0x1808E5680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool OEJJLODKOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8B0", Offset = "0x7CDAB0", VA = "0x1807CE8B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int BOGJAJJGCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x807FC0", Offset = "0x8071C0", VA = "0x180807FC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x807560", Offset = "0x806760", VA = "0x180807560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int HOBAKICFGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7CDFF0", Offset = "0x7CD1F0", VA = "0x1807CDFF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7CDFE0", Offset = "0x7CD1E0", VA = "0x1807CDFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int LKIODHEJFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA91C10", Offset = "0xA90E10", VA = "0x180A91C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> HFHFPGFAPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x64431B0", Offset = "0x64423B0", VA = "0x1864431B0", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> BONJNMKEEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x64432F0", Offset = "0x64424F0", VA = "0x1864432F0", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> LOPJOOMECKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x64432C0", Offset = "0x64424C0", VA = "0x1864432C0", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> HDMJIDCCPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6443370", Offset = "0x6442570", VA = "0x186443370", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> OLLJBIKDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x64433E0", Offset = "0x64425E0", VA = "0x1864433E0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> ANFBJOJLOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6443340", Offset = "0x6442540", VA = "0x186443340", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool GKJMKMAFEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x91A950", Offset = "0x919B50", VA = "0x18091A950", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x99DF40", Offset = "0x99D140", VA = "0x18099DF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int NFIFGGHCBPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x64432B0", Offset = "0x64424B0", VA = "0x1864432B0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int KCEDBAEADOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6443320", Offset = "0x6442520", VA = "0x186443320", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int OKDALPNBEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6443190", Offset = "0x6442390", VA = "0x186443190", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6443520", Offset = "0x6442720", VA = "0x186443520")]
	public KBACJGGACAE(Hash128 ICJNJPHEBHD, PGOEEDICGMC BHHLPOJGGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6443410", Offset = "0x6442610", VA = "0x186443410", Slot = "16")]
	public void ONMDAMKOJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6443220", Offset = "0x6442420", VA = "0x186443220", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct OLCGBPDHKPP : IEquatable<OLCGBPDHKPP>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly OLCGBPDHKPP LCFMFCBHMEC;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int DMDPAHAMEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x9CBB80", Offset = "0x9CAD80", VA = "0x1809CBB80")]
	public OLCGBPDHKPP(int PMNHOLIPOMJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x644F070", Offset = "0x644E270", VA = "0x18644F070", Slot = "4")]
	public bool Equals(OLCGBPDHKPP JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x644EFA0", Offset = "0x644E1A0", VA = "0x18644EFA0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x644F0C0", Offset = "0x644E2C0", VA = "0x18644F0C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MHIOBMFICDG : BBIMPHAGKAM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool ECCNCNGFNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private EAAEDLFKPIP HGNKCNMLAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<OLCGBPDHKPP> FIPPLIOOAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<OLCGBPDHKPP> GNPGPFGGNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<OLCGBPDHKPP> LAMLKBJMACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> MCEOIEKIKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int KLFJEECIELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int NMJAALBACJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int HFBAPEDCGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int JGGAPEJCFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int HMINAKEIBOA;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int DMDPAHAMEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6445ED0", Offset = "0x64450D0", VA = "0x186445ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x64472B0", Offset = "0x64464B0", VA = "0x1864472B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool HOEABLJPPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9A0", Offset = "0x8CBBA0", VA = "0x1808CC9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x906310", Offset = "0x905510", VA = "0x180906310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool AINGMHHNHPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xABF9C0", Offset = "0xABEBC0", VA = "0x180ABF9C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xABFA40", Offset = "0xABEC40", VA = "0x180ABFA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool OJKCAIHOAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool FHMOGPBMCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x46C1780", Offset = "0x46C0980", VA = "0x1846C1780", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x188A9E0", Offset = "0x1889BE0", VA = "0x18188A9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float PBAHNDPLFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x834DC0", Offset = "0x833FC0", VA = "0x180834DC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1C56650", Offset = "0x1C55850", VA = "0x181C56650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6447A70", Offset = "0x6446C70", VA = "0x186447A70")]
	public MHIOBMFICDG(EAAEDLFKPIP COKNMDIBDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x64475B0", Offset = "0x64467B0", VA = "0x1864475B0")]
	private void OAIPGJHLAOB(EAAEDLFKPIP COKNMDIBDNP, int KLFJEECIELH, int JBIGMOFFAPA, int PMNHOLIPOMJ, int KEPAAEOJNLB, EDNGJMAGPON JLJKEBMIIPF, float HPDJBKJMJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x64472F0", Offset = "0x64464F0", VA = "0x1864472F0")]
	private void NPGHFPAHKFO(EAAEDLFKPIP COKNMDIBDNP, int PIDJELOJIAL, int PMNHOLIPOMJ, uint3 JKIELFAPFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6446670", Offset = "0x6445870", VA = "0x186446670")]
	private bool HHAGAEEGGDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6446910", Offset = "0x6445B10", VA = "0x186446910", Slot = "4")]
	public bool LGLNKEHGBKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x64465F0", Offset = "0x64457F0", VA = "0x1864465F0", Slot = "5")]
	public bool DBKEHPIBNHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6445F80", Offset = "0x6445180", VA = "0x186445F80", Slot = "6")]
	public void BIFLKBKPGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6445E70", Offset = "0x6445070", VA = "0x186445E70")]
	public void ABNACNBEFKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6445E70", Offset = "0x6445070", VA = "0x186445E70", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BBIMPHAGKAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool OJKCAIHOAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool FHMOGPBMCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGLNKEHGBKE();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DBKEHPIBNHN();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIFLKBKPGJE();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PNNKKAMPAGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float KDBBAGKAKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, MHIOBMFICDG> HOKBIJGGOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, BNCCFFJHNHM> HACENCEIBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<BBIMPHAGKAM> NKNOMCFEHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<BBIMPHAGKAM> AOMCEFPLOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<BBIMPHAGKAM> CJECBNOFJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int JCAPLAHJOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int KPCNPBCDEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float LDHCMKAAHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool DJEGFEEECAF;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GPBKGBKCHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xD131C0", Offset = "0xD123C0", VA = "0x180D131C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xD187A0", Offset = "0xD179A0", VA = "0x180D187A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool EPJHIGALHCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6450070", Offset = "0x644F270", VA = "0x186450070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string MDLKJIPHGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x644FCC0", Offset = "0x644EEC0", VA = "0x18644FCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x64500D0", Offset = "0x644F2D0", VA = "0x1864500D0")]
	public void MLNIEDGBCNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x64500C0", Offset = "0x644F2C0", VA = "0x1864500C0")]
	public void MKLBKKBDJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x64506A0", Offset = "0x644F8A0", VA = "0x1864506A0")]
	public PNNKKAMPAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x644F700", Offset = "0x644E900", VA = "0x18644F700")]
	public LCMPEKEBDKI FLGJIGKCNJL(FPCHPFFPIFJ PNLOKOBAKEP, bool MPNNLNCBOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x644FB10", Offset = "0x644ED10", VA = "0x18644FB10")]
	public BNCCFFJHNHM FLGJIGKCNJL(FDBLAAIALEN OOHAKCENEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x644FC50", Offset = "0x644EE50", VA = "0x18644FC50")]
	public bool HLHEBBKGHCH(Hash128 IFAFPBGLEJO, [Out] MHIOBMFICDG NBNCJJNFEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x644F830", Offset = "0x644EA30", VA = "0x18644F830")]
	public MHIOBMFICDG FLGJIGKCNJL(EAAEDLFKPIP COKNMDIBDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x64500E0", Offset = "0x644F2E0", VA = "0x1864500E0")]
	private void OBFNLPNHIOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x644F560", Offset = "0x644E760", VA = "0x18644F560")]
	private bool AKKPDLOENBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6450100", Offset = "0x644F300", VA = "0x186450100")]
	public void ONMDAMKOJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x644F5F0", Offset = "0x644E7F0", VA = "0x18644F5F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x64505B0", Offset = "0x644F7B0", VA = "0x1864505B0")]
	public void PDLGLCIAPGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AKFBDAINJNI : NDHFJJBGHFB<DLBPGAFCEKE, DLBPGAFCEKE>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6440350", Offset = "0x643F550", VA = "0x186440350")]
	public AKFBDAINJNI(int HOMAIIGCHBM, int EKBNIONHLDO, ComputeShader LLEKDPAOOGJ, int NFLGBKIFJGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OGEDHCKIOGH : NDHFJJBGHFB<BBJPFDHFEEF, BBJPFDHFEEF>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x644EEF0", Offset = "0x644E0F0", VA = "0x18644EEF0")]
	public OGEDHCKIOGH(int HOMAIIGCHBM, int EKBNIONHLDO, ComputeShader LLEKDPAOOGJ, int NFLGBKIFJGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IDJFPBGGBCO : NDHFJJBGHFB<JEHNILONNOO, JEHNILONNOO>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6443030", Offset = "0x6442230", VA = "0x186443030")]
	public IDJFPBGGBCO(int HOMAIIGCHBM, int EKBNIONHLDO, ComputeShader LLEKDPAOOGJ, int NFLGBKIFJGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class MGKOEADJNDA : NDHFJJBGHFB<PGIGPLDKFMJ, JLNMOJCHPAL>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6445DC0", Offset = "0x6444FC0", VA = "0x186445DC0")]
	public MGKOEADJNDA(int HOMAIIGCHBM, int EKBNIONHLDO, ComputeShader LLEKDPAOOGJ, int NFLGBKIFJGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EICMMJNDFHO : NDHFJJBGHFB<OLMFBENPNFH, OLMFBENPNFH>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6441620", Offset = "0x6440820", VA = "0x186441620")]
	public EICMMJNDFHO(int HOMAIIGCHBM, int EKBNIONHLDO, ComputeShader LLEKDPAOOGJ, int NFLGBKIFJGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class FIJOPHBOGDD : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NAAFELGIDII GOEIEHOPHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool IJMGAKGNGDB;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool AIFMEFAAGNB;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6441D40", Offset = "0x6440F40", VA = "0x186441D40")]
	public FIJOPHBOGDD(NAAFELGIDII HKFEOIMMDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6441BB0", Offset = "0x6440DB0", VA = "0x186441BB0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer DHAMGOCKPFO, RenderingData ILAACNNKCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6441940", Offset = "0x6440B40", VA = "0x186441940", Slot = "6")]
	public override void Configure(CommandBuffer DHAMGOCKPFO, RenderTextureDescriptor BIECFHMLOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6441980", Offset = "0x6440B80", VA = "0x186441980", Slot = "9")]
	public override void Execute(ScriptableRenderContext EOIJJPCMNGA, RenderingData ILAACNNKCPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class DMLPPJHGOLN
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct KFFGBDOIHCG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string IIADHBOODBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer DHAMGOCKPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext EOIJJPCMNGA;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x64436A0", Offset = "0x64428A0", VA = "0x1864436A0")]
		public KFFGBDOIHCG(string NGCAJIAAIMC, ScriptableRenderContext PLEDDOCNEOP, [Out] CommandBuffer FMBIBFHJDHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x64435F0", Offset = "0x64427F0", VA = "0x1864435F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6441300", Offset = "0x6440500", VA = "0x186441300")]
	public static bool MBDIMCCDBEN(RenderingData ILAACNNKCPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6441450", Offset = "0x6440650", VA = "0x186441450")]
	public static void MILCANEPAHK(CommandBuffer DHAMGOCKPFO, ScriptableRenderContext EOIJJPCMNGA, ShadowDrawingSettings JCJLHILODCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x64410D0", Offset = "0x64402D0", VA = "0x1864410D0")]
	public static void DJLGJJNKPDC(CommandBuffer DHAMGOCKPFO, ScriptableRenderContext EOIJJPCMNGA, RenderingData ILAACNNKCPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NAAFELGIDII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class KCOKKFNHOHG
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int PBAJBGPCAGL;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int LNKLKBNOHCM;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static NDGLHIGDIIL<EPEKAFOJJGB> LILJCIGDLDL;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static NDGLHIGDIIL<uint> APAIPCJONGK;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static KKGONODNLCJ BCHPGIGANFL;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer AFHEHNDGOHN;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<DIFBPPMCCLD> MMIALKDFHCG;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int MNAKHMGHEDP;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int DHAAPDBFKAF;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int KFEIALAIDMD;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int KFEKDFKGKNK;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] JGOJDGNACFG;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] IGPJOPGFKPI;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static GIOEIENBGGB[][] HCFFOEGILJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] CLLHECMOOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int ICIIFMKALNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int BNFPLCEFJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int OMFBPLFDIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int DOOEFINCICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int NNOLIOJOADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int DKELFCMEFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int KLAINCEDCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int DCBLANEIBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int NGOCNIAFNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int DCGINHODFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int BCIPLBKDLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int ILFGACDAMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int DIFOIFEDCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int MDGLMNMCCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int EDHFJLHAAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int LAEJECAHLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int BJNBFIPCLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int OCNMFENGAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] GCONIOLBIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private PNNKKAMPAGM LHGKCLGFLPP;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool NCJMMLEGMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6448BC0", Offset = "0x6447DC0", VA = "0x186448BC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x644DAC0", Offset = "0x644CCC0", VA = "0x18644DAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool EEHHAJNELLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x644D500", Offset = "0x644C700", VA = "0x18644D500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6448C10", Offset = "0x6447E10", VA = "0x186448C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData GICDCDBMPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x644DBF0", Offset = "0x644CDF0", VA = "0x18644DBF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x644A300", Offset = "0x6449500", VA = "0x18644A300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static GIPOIPPELPB OOAGDLAFEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6447CB0", Offset = "0x6446EB0", VA = "0x186447CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x644DB80", Offset = "0x644CD80", VA = "0x18644DB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static AKFBDAINJNI PNMLNCNOCIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x644D3D0", Offset = "0x644C5D0", VA = "0x18644D3D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x644A290", Offset = "0x6449490", VA = "0x18644A290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static OGEDHCKIOGH ECDMKEMCGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6447BE0", Offset = "0x6446DE0", VA = "0x186447BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6448CE0", Offset = "0x6447EE0", VA = "0x186448CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static IDJFPBGGBCO IJJLBPDOLED
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x644C5E0", Offset = "0x644B7E0", VA = "0x18644C5E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6448C70", Offset = "0x6447E70", VA = "0x186448C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static MGKOEADJNDA MJJGJIHOMBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x644C4B0", Offset = "0x644B6B0", VA = "0x18644C4B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6448D50", Offset = "0x6447F50", VA = "0x186448D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static EICMMJNDFHO LFPMIDOBDAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x644EB10", Offset = "0x644DD10", VA = "0x18644EB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x644E910", Offset = "0x644DB10", VA = "0x18644E910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material BMFEPIHJMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6447D00", Offset = "0x6446F00", VA = "0x186447D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x644DA40", Offset = "0x644CC40", VA = "0x18644DA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material PABGCPCFMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x644DB20", Offset = "0x644CD20", VA = "0x18644DB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x644C630", Offset = "0x644B830", VA = "0x18644C630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material ICBPMDPGCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6447D60", Offset = "0x6446F60", VA = "0x186447D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x644EA90", Offset = "0x644DC90", VA = "0x18644EA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material KAFBMJGEJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x644EA30", Offset = "0x644DC30", VA = "0x18644EA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6447C30", Offset = "0x6446E30", VA = "0x186447C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool BDOGFMCAGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x644A370", Offset = "0x6449570", VA = "0x18644A370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x644C510", Offset = "0x644B710", VA = "0x18644C510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool EPJHIGALHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x644D370", Offset = "0x644C570", VA = "0x18644D370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string MDLKJIPHGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x644CC90", Offset = "0x644BE90", VA = "0x18644CC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x644EC10", Offset = "0x644DE10", VA = "0x18644EC10")]
	internal NAAFELGIDII([Optional] MClusterData IBBGELMKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6448DD0", Offset = "0x6447FD0", VA = "0x186448DD0")]
	public void CNOOLEDIEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x644E990", Offset = "0x644DB90", VA = "0x18644E990")]
	public void OHBJIDOBKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x64486C0", Offset = "0x64478C0", VA = "0x1864486C0")]
	public void BEMOFNOEACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x644A850", Offset = "0x6449A50", VA = "0x18644A850")]
	public bool FOLDEBBIAEL(Hash128 ICJNJPHEBHD, [Out] MHIOBMFICDG COKNMDIBDNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x644A790", Offset = "0x6449990", VA = "0x18644A790")]
	public MHIOBMFICDG FLGJIGKCNJL(EAAEDLFKPIP JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x644A3D0", Offset = "0x64495D0", VA = "0x18644A3D0")]
	public BNCCFFJHNHM FLGJIGKCNJL(FDBLAAIALEN OOHAKCENEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x644A5D0", Offset = "0x64497D0", VA = "0x18644A5D0")]
	public LCMPEKEBDKI FLGJIGKCNJL(FPCHPFFPIFJ PNLOKOBAKEP, bool MPNNLNCBOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x64486D0", Offset = "0x64478D0", VA = "0x1864486D0")]
	public void BIFLKBKPGJE(BBIMPHAGKAM LPDMDILMCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x644A8F0", Offset = "0x6449AF0", VA = "0x18644A8F0")]
	public static void GINNLFFIBIO(FDGFKCFHLBH HEJPMNEGHKB, GIOEIENBGGB[] JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6447DC0", Offset = "0x6446FC0", VA = "0x186447DC0")]
	private void ALPPMBBJOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x644DC40", Offset = "0x644CE40", VA = "0x18644DC40")]
	private static void NPHLCJECCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x644D720", Offset = "0x644C920", VA = "0x18644D720")]
	public void LLBOEDDNJLE(CommandBuffer DHAMGOCKPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x644D550", Offset = "0x644C750", VA = "0x18644D550")]
	public void LIAOPKOKJFO([Optional] ScriptableRenderContext? EOIJJPCMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x644AF40", Offset = "0x644A140", VA = "0x18644AF40")]
	public void HEOGLOFLPBF(CommandBuffer DHAMGOCKPFO, ShadowSplitData CFOAFENIIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x644B220", Offset = "0x644A420", VA = "0x18644B220")]
	public void HEOGLOFLPBF(CommandBuffer DHAMGOCKPFO, CameraData NOGFDJHOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x644A9E0", Offset = "0x6449BE0", VA = "0x18644A9E0")]
	public void GNMFELMLGEF(CommandBuffer DHAMGOCKPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x644C570", Offset = "0x644B770", VA = "0x18644C570")]
	public void ICAECBEDKMK(CommandBuffer DHAMGOCKPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6448720", Offset = "0x6447920", VA = "0x186448720")]
	public void BOGFJFJCABB(CommandBuffer DHAMGOCKPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x644C6B0", Offset = "0x644B8B0", VA = "0x18644C6B0")]
	public void JIGKIKGAIHC(CommandBuffer DHAMGOCKPFO, FDGFKCFHLBH MBNICEHPDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x644D420", Offset = "0x644C620", VA = "0x18644D420")]
	public void KMCMMEMNBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x644B500", Offset = "0x644A700", VA = "0x18644B500")]
	public void HJOADCBEFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x644A180", Offset = "0x6449380", VA = "0x18644A180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BFMIFCHOAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1E21D80", Offset = "0x1E20F80", VA = "0x181E21D80")]
	public static int IPBKPCOKGNF(int BJOOMLAOBEG, int ODNELCGHBAB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BHAOKOINKJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 CHNFGGMHOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 CEJNIELPBPD;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly BHAOKOINKJL OLJBJFJIGDG;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly BHAOKOINKJL LCFMFCBHMEC;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6440670", Offset = "0x643F870", VA = "0x186440670")]
	public BHAOKOINKJL(float4x4 GPDNAJODHBN, float4 PDFKJBFBBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6440500", Offset = "0x643F700", VA = "0x186440500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct EDNGJMAGPON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 CAOOPLKANIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 BGIIKDPIDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 MBNLKPDJGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 EEJHJKFHKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 GBMOFHPCKAF;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct GLJKFOFFADC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 CAOOPLKANIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 BGIIKDPIDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 MBNLKPDJGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 EEJHJKFHKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 GBMOFHPCKAF;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct JLNMOJCHPAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public GLJKFOFFADC IMEANGAPDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public GLJKFOFFADC NJNIMFOAMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public GLJKFOFFADC PHHEMBGJNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public GLJKFOFFADC GPNLACDPPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public GLJKFOFFADC AHJPDJIKOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public GLJKFOFFADC AEHGJMCICAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public GLJKFOFFADC KDCIOJPOHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public GLJKFOFFADC LMOKDFAHGLL;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct PGIGPLDKFMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public EDNGJMAGPON IMEANGAPDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public EDNGJMAGPON NJNIMFOAMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public EDNGJMAGPON PHHEMBGJNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public EDNGJMAGPON GPNLACDPPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public EDNGJMAGPON AHJPDJIKOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public EDNGJMAGPON AEHGJMCICAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public EDNGJMAGPON KDCIOJPOHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public EDNGJMAGPON LMOKDFAHGLL;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct BBJPFDHFEEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 FFGAEBLCHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint OHPHEEKKPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint ANKFEMDGJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float DKLPPEACDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint GHJGOKEKFOA;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6440400", Offset = "0x643F600", VA = "0x186440400")]
	public BBJPFDHFEEF(FDBLAAIALEN OOHAKCENEJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct EPEKAFOJJGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint BOKMKFPGMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint ONNKBJGKKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint KEPAAEOJNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint GHJGOKEKFOA;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x64416D0", Offset = "0x64408D0", VA = "0x1864416D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JEHNILONNOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint JBIGMOFFAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint IMGBDJFHBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint NMJAALBACJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint GHJGOKEKFOA;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x64430E0", Offset = "0x64422E0", VA = "0x1864430E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct DLBPGAFCEKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint GGPGONDEEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint DBGPGBEKOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint DMKIADOGJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint OBDOMJBOJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint KGDPGAPAOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint PLCCHMIBJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint KOGOBODEEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint GHJGOKEKFOA;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6440D80", Offset = "0x643FF80", VA = "0x186440D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct OLMFBENPNFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 DMBEBFKCDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 GMOCNANMGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 PIENPDCPAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 HIKIFNENNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 EKIINAJHMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 LNCJPMNOMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 LHFLEOLPAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 LLNOJMEKMIF;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x644F150", Offset = "0x644E350", VA = "0x18644F150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum FDGFKCFHLBH
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	DepthOnly,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Transparent,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Shadow
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

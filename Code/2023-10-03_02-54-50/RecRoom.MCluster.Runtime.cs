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
public struct NHIKLBJJMGG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] KFGFKMNPKGB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] OLIMDJAMKKH;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] INCFKPPNLNH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xBCE930", Offset = "0xBCD130", VA = "0x180BCE930")]
	public static int NDICEGJNMLG(ILKJDFDAGEF HAGBNKDONGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1C60", Offset = "0x5CD0460", VA = "0x185CD1C60")]
	public static int FMMPJGNHNKN(ILKJDFDAGEF HAGBNKDONGH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BIDFGLJCHBO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int FCOLANCDCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CADDPHNGDAA ALFKDFCCJPO(int OLLEBMKIFPO);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 NLPBJMJDFMA(int OLLEBMKIFPO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FEDLPIHABFD NFBOIDPEJFF();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PMAJPDDBAFD CHBBFJMFGJD();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ANBPMMDBELG : DHMEBDNPOHE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FEDLPIHABFD KHFCFAPNPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform FDHLPPGIJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<PJNDDCPELHI> CFNHHCLKOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EJNMHPBIFEF ILDEOMJKNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private BBLMPIJHLJP LGICIKJMFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool PFFBJIDFGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BIDFGLJCHBO DKIJMBLHJFB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float KNGPGFNPJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x803780", Offset = "0x801F80", VA = "0x180803780")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA0ACB0", Offset = "0xA094B0", VA = "0x180A0ACB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BNFKEABEFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x803760", Offset = "0x801F60", VA = "0x180803760")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAE4F40", Offset = "0xAE3740", VA = "0x180AE4F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OFFABBDOJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE80", Offset = "0x7AC680", VA = "0x1807ADE80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7ADA30", Offset = "0x7AC230", VA = "0x1807ADA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IMJOLDEPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CCE4A0", Offset = "0x5CCCCA0", VA = "0x185CCE4A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CCE490", Offset = "0x5CCCC90", VA = "0x185CCE490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PDPGJLKKMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x102F2C0", Offset = "0x102DAC0", VA = "0x18102F2C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE900", Offset = "0x5CCD100", VA = "0x185CCE900")]
	public ANBPMMDBELG(BIDFGLJCHBO GCCCOPFGNBA, bool DJAEOPCHCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE6E0", Offset = "0x5CCCEE0", VA = "0x185CCE6E0")]
	private bool OPPIBJODKDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD690", Offset = "0x5CCBE90", VA = "0x185CCD690", Slot = "4")]
	public bool EIGFNHEIDIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE2C0", Offset = "0x5CCCAC0", VA = "0x185CCE2C0", Slot = "5")]
	public bool HFBGFFHILGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE4B0", Offset = "0x5CCCCB0", VA = "0x185CCE4B0", Slot = "6")]
	public void OICBJJIPNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD680", Offset = "0x5CCBE80", VA = "0x185CCD680", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GLABIIIMNEM
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMMNFGGAACM(CommandBuffer EKAPBJIIHMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JDMKMPIJACL : GLABIIIMNEM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int IDAENCJFMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier JDOLAAOIGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x396EF20", Offset = "0x396D720", VA = "0x18396EF20")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0510", Offset = "0x5CCED10", VA = "0x185CD0510")]
	public JDMKMPIJACL(int LJHGKCLAIHG, RenderTargetIdentifier KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD04C0", Offset = "0x5CCECC0", VA = "0x185CD04C0", Slot = "4")]
	public void HMMNFGGAACM(CommandBuffer EKAPBJIIHMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PFLJNAGGAMI : GLABIIIMNEM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int IDAENCJFMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] GBHNAAJPJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98EAD0", Offset = "0x98D2D0", VA = "0x18098EAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xAB95B0", Offset = "0xAB7DB0", VA = "0x180AB95B0")]
	public PFLJNAGGAMI(int LJHGKCLAIHG, Vector4[] KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CD44A0", Offset = "0x5CD2CA0", VA = "0x185CD44A0", Slot = "4")]
	public void HMMNFGGAACM(CommandBuffer EKAPBJIIHMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct FENOCJBHMOD : GLABIIIMNEM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int IDAENCJFMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] OJFCLGGJOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98EAD0", Offset = "0x98D2D0", VA = "0x18098EAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xAB95B0", Offset = "0xAB7DB0", VA = "0x180AB95B0")]
	public FENOCJBHMOD(int LJHGKCLAIHG, float[] KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFD10", Offset = "0x5CCE510", VA = "0x185CCFD10", Slot = "4")]
	public void HMMNFGGAACM(CommandBuffer EKAPBJIIHMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LKFBCJJFMJI : GLABIIIMNEM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string MJLCABAKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool HAOKFJJANAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1770960", Offset = "0x176F160", VA = "0x181770960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3472AB0", Offset = "0x34712B0", VA = "0x183472AB0")]
	public LKFBCJJFMJI(string BOBHOMKFHJB, bool ICGNKEDIKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CD10A0", Offset = "0x5CCF8A0", VA = "0x185CD10A0", Slot = "4")]
	public void HMMNFGGAACM(CommandBuffer EKAPBJIIHMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PMAJPDDBAFD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 NLGIGOMBFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 FHAPLDLNOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA70070", Offset = "0xA6E870", VA = "0x180A70070")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int GBKPPFHDFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x807520", Offset = "0x805D20", VA = "0x180807520")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OCOBJNCBLJN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7A1FB0", Offset = "0x7A07B0", VA = "0x1807A1FB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float POOIOGOHPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B4810", VA = "0x1807B6010")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6300", Offset = "0x5CD4B00", VA = "0x185CD6300")]
	public PMAJPDDBAFD(Color JFJPGCGPBNP, int HEDMOPPGPED, int GIBOEKFJFBH, float HGONGHCBCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x52EA220", Offset = "0x52E8A20", VA = "0x1852EA220")]
	private static float4 OFNPNMONJMC(Color JFJPGCGPBNP)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6270", Offset = "0x5CD4A70", VA = "0x185CD6270")]
	private static Hash128 BNIFECJEJGG(PMAJPDDBAFD GCCCOPFGNBA)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EJNMHPBIFEF : DHMEBDNPOHE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string GBFPILOOOBJ;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string IPKAEFFBCIK;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string IDIGDLGEKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private PMAJPDDBAFD CDMJCDBNLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private KCIDBPHNMCD LGHJCFHBOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 PLKMHAHIAHG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public BBLMPIJHLJP CBLPPOKNLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x788B50", Offset = "0x787350", VA = "0x180788B50")]
		[CompilerGenerated]
		get
		{
			return default(BBLMPIJHLJP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80B8E0", Offset = "0x80A0E0", VA = "0x18080B8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BNFKEABEFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1914110", Offset = "0x1912910", VA = "0x181914110")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1913500", Offset = "0x1911D00", VA = "0x181913500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OFFABBDOJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x19134C0", Offset = "0x1911CC0", VA = "0x1819134C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1913540", Offset = "0x1911D40", VA = "0x181913540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PDPGJLKKMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool IMJOLDEPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4F38ED0", Offset = "0x4F376D0", VA = "0x184F38ED0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5B30210", Offset = "0x5B2EA10", VA = "0x185B30210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int DIEGBKIOLGK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF670", Offset = "0x5CCDE70", VA = "0x185CCF670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFCD0", Offset = "0x5CCE4D0", VA = "0x185CCFCD0")]
	public EJNMHPBIFEF(PMAJPDDBAFD LEILKFCIMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFAD0", Offset = "0x5CCE2D0", VA = "0x185CCFAD0")]
	private bool OPPIBJODKDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF6C0", Offset = "0x5CCDEC0", VA = "0x185CCF6C0", Slot = "4")]
	public bool EIGFNHEIDIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF630", Offset = "0x5CCDE30", VA = "0x185CCF630")]
	private static KCIDBPHNMCD BLNFOIEGHCO(PMAJPDDBAFD GCCCOPFGNBA)
	{
		return default(KCIDBPHNMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF810", Offset = "0x5CCE010", VA = "0x185CCF810", Slot = "5")]
	public bool HFBGFFHILGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF9C0", Offset = "0x5CCE1C0", VA = "0x185CCF9C0", Slot = "6")]
	public void OICBJJIPNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1240", Offset = "0x5CCFA40", VA = "0x185CD1240", Slot = "0")]
		public override bool Equals(object GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1440", Offset = "0x5CCFC40", VA = "0x185CD1440", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x825B10", Offset = "0x824310", VA = "0x180825B10")]
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
		private PMHJJKNIHMM opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static PNKBHONFGJO CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5CD1B10", Offset = "0x5CD0310", VA = "0x185CD1B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5CD1B50", Offset = "0x5CD0350", VA = "0x185CD1B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1520", Offset = "0x5CCFD20", VA = "0x185CD1520", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5CD14F0", Offset = "0x5CCFCF0", VA = "0x185CD14F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHDBAAFPFPI, RenderingData DHCHFJANCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1980", Offset = "0x5CD0180", VA = "0x185CD1980")]
		public void NIBNGIBBOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xAC5A10", Offset = "0xAC4210", VA = "0x180AC5A10")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JDMCMMDOING<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private ANELLOPCHDB GGHNFOOKAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private ANELLOPCHDB OFLKGILPEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer HCGOALONBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture GBKPOBHHCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int KCNECBODNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int NECFPPJEFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string KEOGJDFNAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string JCJJFFOJBMO;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7658D0", Offset = "0x7640D0", VA = "0x1807658D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int LLNHGHFGBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAE7DE0", Offset = "0xAE65E0", VA = "0x180AE7DE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int IGLPBIOJOPB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x77F540", Offset = "0x77DD40", VA = "0x18077F540")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3840790", Offset = "0x383EF90", VA = "0x183840790")]
	public JDMCMMDOING(string BOBHOMKFHJB, int NMCGKJFPOLN, [Optional] RenderTextureFormat? NODJEJKFPPC, bool NJDFHBPGJNI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x383F6D0", Offset = "0x383DED0", VA = "0x18383F6D0")]
	public void HFBGFFHILGI(CommandBuffer EKAPBJIIHMJ, NativeArray<ValType> KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x383DC80", Offset = "0x383C480", VA = "0x18383DC80")]
	public void EFOOHAEILDH(CommandBuffer EKAPBJIIHMJ, ComputeShader IJDLFFJJGFP, int FCIHGJBPEMN, int ILGEMCBGALI = -1, int CEAPPPCNKAE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x383EFF0", Offset = "0x383D7F0", VA = "0x18383EFF0")]
	public void EFOOHAEILDH(Material LGHJCFHBOJC, int ILGEMCBGALI = -1, int CEAPPPCNKAE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x383D7D0", Offset = "0x383BFD0", VA = "0x18383D7D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EKEHLMMMOII
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFOOHAEILDH(Material LEILKFCIMIM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NLFNELHAHNL<SrcEntry, DstEntry> : EKEHLMMMOII, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] KLDHCDIOEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected ANELLOPCHDB FKIFNEHHAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected ANELLOPCHDB OHDBKPIJELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> MBLJNFJECEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> NPEFGCIELFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int LFCDFGEEEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int JLCOIFJELOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected JDMCMMDOING<int> FLLNCOLKFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected JDMCMMDOING<SrcEntry> LBJLOKHNHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected JDMCMMDOING<DstEntry> DAEJDPCNHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader KJGIBILGBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int PIDADHOCLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int DDDADEGIICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int JBGILCLNCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int AGMPJABILCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int PNEEFFOCLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int KHAOIALNANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int ODJDDHELOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int KBDBEDKGPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int CBGHJOEFKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int BDHBNPNEKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int CEBHKPGHINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int CMCENADKGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string BMIJPLGOIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] CIAEFJMPJDC;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int NAPGODGMHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3AE0", Offset = "0x3CB22E0", VA = "0x183CB3AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string ACNMINMFHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4390", Offset = "0x3CB2B90", VA = "0x183CB4390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4F40", Offset = "0x3CB3740", VA = "0x183CB4F40")]
	public NLFNELHAHNL(string BOBHOMKFHJB, int BLMGHGDBIPG, int HNLJNHOFJMC, RenderTextureFormat NODJEJKFPPC, ComputeShader IMHCBGHKGKG, int BILIFDNNHCM = 0, int MKGMEIHOJOD = 0, int EHGBIOPCIKC = 0, int JJLCDNPPGMD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4ED0", Offset = "0x3CB36D0", VA = "0x183CB4ED0")]
	public int PIEHOAHCLAJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3A90", Offset = "0x3CB2290", VA = "0x183CB3A90")]
	protected void JJJGLEPODPN(int ADMJKDLHPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2B80", Offset = "0x3CB1380", VA = "0x183CB2B80")]
	public BBLMPIJHLJP EIGFNHEIDIC(SrcEntry KOIMDAJNDOD)
	{
		return default(BBLMPIJHLJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3810", Offset = "0x3CB2010", VA = "0x183CB3810")]
	public bool HFBGFFHILGI(BBLMPIJHLJP FJFHMLGEMLM, SrcEntry KOIMDAJNDOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3D70", Offset = "0x3CB2570", VA = "0x183CB3D70")]
	public bool OICBJJIPNIH(BBLMPIJHLJP FJFHMLGEMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "6")]
	protected virtual void ECAGFLDBNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0FC0", Offset = "0x3CAF7C0", VA = "0x183CB0FC0", Slot = "7")]
	public void AOPBNMABOJM(CommandBuffer EKAPBJIIHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1940", Offset = "0x3CB0140", VA = "0x183CB1940", Slot = "8")]
	public void AOPBNMABOJM(CommandBuffer EKAPBJIIHMJ, ComputeShader IMHCBGHKGKG, int BILIFDNNHCM = -1, int MKGMEIHOJOD = -1, int EHGBIOPCIKC = -1, int JJLCDNPPGMD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3CB23E0", Offset = "0x3CB0BE0", VA = "0x183CB23E0", Slot = "9")]
	public void EFOOHAEILDH(CommandBuffer EKAPBJIIHMJ, ComputeShader IMHCBGHKGKG, int BILIFDNNHCM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2550", Offset = "0x3CB0D50", VA = "0x183CB2550", Slot = "4")]
	public void EFOOHAEILDH(Material LGHJCFHBOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2020", Offset = "0x3CB0820", VA = "0x183CB2020", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ANELLOPCHDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong GOMKJBPKCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong FCMHMMAOGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KCHKAECHPDC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct GMAMJIDIMHN : ANELLOPCHDB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable EEFNHBCEIAO;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong GOMKJBPKCFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x98EAD0", Offset = "0x98D2D0", VA = "0x18098EAD0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x558A770", Offset = "0x5588F70", VA = "0x18558A770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong FCMHMMAOGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x115C840", Offset = "0x115B040", VA = "0x18115C840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0030", Offset = "0x5CCE830", VA = "0x185CD0030")]
		internal GMAMJIDIMHN(IDisposable CBHHDCADMLO, ulong OLCGHAPFAML, ulong MIEJOBHEPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFFB0", Offset = "0x5CCE7B0", VA = "0x185CCFFB0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct PBDBMMNOICM : ANELLOPCHDB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture OOJLMNMFOBJ;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong GOMKJBPKCFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x98EAD0", Offset = "0x98D2D0", VA = "0x18098EAD0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x558A770", Offset = "0x5588F70", VA = "0x18558A770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong FCMHMMAOGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x115C840", Offset = "0x115B040", VA = "0x18115C840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4470", Offset = "0x5CD2C70", VA = "0x185CD4470")]
		public PBDBMMNOICM(RenderTexture PNEGHHIDKPD, ulong JLCNNIGLGKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5CD43D0", Offset = "0x5CD2BD0", VA = "0x185CD43D0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong DPOPBMIMMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0CA0", Offset = "0x5CCF4A0", VA = "0x185CD0CA0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0E70", Offset = "0x5CCF670", VA = "0x185CD0E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong CNNLJHCEIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0E30", Offset = "0x5CCF630", VA = "0x185CD0E30")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0C60", Offset = "0x5CCF460", VA = "0x185CD0C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD06E0", Offset = "0x5CCEEE0", VA = "0x185CD06E0")]
	public static ComputeBuffer GFPEABNIECK(int JEDNJDDHFHB, int MMFIJNMIOGO, ComputeBufferType BJKOKHNAAID, [Out] ANELLOPCHDB FJFHMLGEMLM, ComputeBufferMode CHDCFCNHAFI = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD08C0", Offset = "0x5CCF0C0", VA = "0x185CD08C0")]
	public static RenderTexture GFPEABNIECK(int EECPDFLCEFA, int OENMLNGACGK, int AODOAAEJFFK, RenderTextureFormat NODJEJKFPPC, [Out] ANELLOPCHDB FJFHMLGEMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x24420F0", Offset = "0x24408F0", VA = "0x1824420F0")]
	public static NativeArray<T> CMHECIDLOOA<T>(NativeArray<T> EEFNHBCEIAO, ulong OOHKMCMOCLB, [Out] ANELLOPCHDB FJFHMLGEMLM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2442F50", Offset = "0x2441750", VA = "0x182442F50")]
	public static NativeArray<T> GFPEABNIECK<T>(int OOHKMCMOCLB, Allocator OPPHPFNHPMG, [Out] ANELLOPCHDB FJFHMLGEMLM, NativeArrayOptions LCBBKAOBGLA = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0CE0", Offset = "0x5CCF4E0", VA = "0x185CD0CE0")]
	public static void LJGAFCKKELL(ANELLOPCHDB EEFNHBCEIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD05E0", Offset = "0x5CCEDE0", VA = "0x185CD05E0")]
	public static uint FHPGLPJLJJG(RenderTextureFormat NODJEJKFPPC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OOAJOCMLCNF : NLFNELHAHNL<EBHCBELCANB, EBHCBELCANB>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct LDHNNPMBNJN : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> ONFPCKLHDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> KCLMNGKCJOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> INLNJGGPNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> ADJKLGJJGJB;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0490", Offset = "0x5CCEC90", VA = "0x185CD0490")]
		public LDHNNPMBNJN(NativeArray<int> GHONNAOMKOE, NativeArray<float> HGEOKKLHAAJ, NativeArray<float4x4> KCBMIEBOAGN, NativeArray<float4> DJCMKPANPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0EE0", Offset = "0x5CCF6E0", VA = "0x185CD0EE0", Slot = "4")]
		public void Execute(int ADMJKDLHPCI, TransformAccess KHFCFAPNPDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct JDJLHJKJHGI : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> ONFPCKLHDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> DBHKDJECLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> PFGPMNFBHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<EBHCBELCANB> KPGOEINHJCH;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0490", Offset = "0x5CCEC90", VA = "0x185CD0490")]
		public JDJLHJKJHGI(NativeArray<int> GHONNAOMKOE, NativeArray<float4x4> EHHFBGLCODK, NativeArray<float4> JDBFGABEKHH, NativeArray<EBHCBELCANB> PCLAHFAGOCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0420", Offset = "0x5CCEC20", VA = "0x185CD0420", Slot = "4")]
		public void Execute(int ADMJKDLHPCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte PEHOIFMNEDI = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray EGMOLMCKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> JNOIDEFMNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> EKMHPCLHMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> MEDDCDFDJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> EJPPAKJGDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> KOPODLMOCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private ANELLOPCHDB AHKLLKLAOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private ANELLOPCHDB BIKADBHINFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private ANELLOPCHDB MCHCPLCCECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private ANELLOPCHDB EJIJIJJBNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private ANELLOPCHDB CFOBILPJHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform IIGAHEBKJPD;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD40F0", Offset = "0x5CD28F0", VA = "0x185CD40F0")]
	public OOAJOCMLCNF(int BLMGHGDBIPG, int HNLJNHOFJMC, ComputeShader IMHCBGHKGKG, int BILIFDNNHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3BF0", Offset = "0x5CD23F0", VA = "0x185CD3BF0", Slot = "6")]
	protected override void ECAGFLDBNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3DF0", Offset = "0x5CD25F0", VA = "0x185CD3DF0")]
	private void FJBPJAJPKEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3EB0", Offset = "0x5CD26B0", VA = "0x185CD3EB0")]
	public bool JAFJMGJNEPM(BBLMPIJHLJP FJFHMLGEMLM, Transform KHFCFAPNPDN, float PMANEMPAFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4010", Offset = "0x5CD2810", VA = "0x185CD4010")]
	public void JFELICEMBAO(BBLMPIJHLJP FJFHMLGEMLM, float PMANEMPAFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3AA0", Offset = "0x5CD22A0", VA = "0x185CD3AA0")]
	public void AILKIOOHJPL(BBLMPIJHLJP FJFHMLGEMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3B50", Offset = "0x5CD2350", VA = "0x185CD3B50", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CADDPHNGDAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ANLJNALAKBD LEICLPMPLAP();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LIHKCAOMEOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 NLGIGOMBFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int BNMCGLMBCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int NEOHOODKHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> MGPEIGPKABN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> PCDALKOIBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> CGICHKKPCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> KLPPCHJOFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> GPPECKFKBFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> OCHJHCHMGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int EFNBNBLJIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int LCGOCKJNGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int EJIBEAODNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool EMACBBGPPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AOPBNMABOJM();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NMBMDJOGLMH : LIHKCAOMEOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private CADDPHNGDAA KKABPKCAPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private ANLJNALAKBD MPLECHMLAIA;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 NLGIGOMBFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA70070", Offset = "0xA6E870", VA = "0x180A70070", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1A5EFC0", Offset = "0x1A5D7C0", VA = "0x181A5EFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool LMKKHDNCOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x762A80", Offset = "0x761280", VA = "0x180762A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int BNMCGLMBCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7A1FB0", Offset = "0x7A07B0", VA = "0x1807A1FB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7A15B0", Offset = "0x79FDB0", VA = "0x1807A15B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int NEOHOODKHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x76A350", Offset = "0x768B50", VA = "0x18076A350", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x76A390", Offset = "0x768B90", VA = "0x18076A390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int PNFIFNDCLEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86DFB0", Offset = "0x86C7B0", VA = "0x18086DFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> MGPEIGPKABN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5CD25C0", Offset = "0x5CD0DC0", VA = "0x185CD25C0", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> PCDALKOIBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2430", Offset = "0x5CD0C30", VA = "0x185CD2430", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> CGICHKKPCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5CD24F0", Offset = "0x5CD0CF0", VA = "0x185CD24F0", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> KLPPCHJOFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2550", Offset = "0x5CD0D50", VA = "0x185CD2550", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> GPPECKFKBFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2520", Offset = "0x5CD0D20", VA = "0x185CD2520", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> OCHJHCHMGIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2650", Offset = "0x5CD0E50", VA = "0x185CD2650", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EMACBBGPPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CB0", Offset = "0x7B54B0", VA = "0x1807B6CB0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B6890", Offset = "0x7B5090", VA = "0x1807B6890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int EFNBNBLJIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2680", Offset = "0x5CD0E80", VA = "0x185CD2680", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int LCGOCKJNGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2690", Offset = "0x5CD0E90", VA = "0x185CD2690", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int EJIBEAODNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2630", Offset = "0x5CD0E30", VA = "0x185CD2630", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5CD26B0", Offset = "0x5CD0EB0", VA = "0x185CD26B0")]
	public NMBMDJOGLMH(Hash128 DFIDMFGDKCM, CADDPHNGDAA KKABPKCAPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2320", Offset = "0x5CD0B20", VA = "0x185CD2320", Slot = "16")]
	public void AOPBNMABOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2460", Offset = "0x5CD0C60", VA = "0x185CD2460", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct BBLMPIJHLJP : IEquatable<BBLMPIJHLJP>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly BBLMPIJHLJP GCBDJIKNIJL;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int DIEGBKIOLGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFB0", Offset = "0x7EB7B0", VA = "0x1807ECFB0")]
	public BBLMPIJHLJP(int ADMJKDLHPCI = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEA90", Offset = "0x5CCD290", VA = "0x185CCEA90", Slot = "4")]
	public bool Equals(BBLMPIJHLJP GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE9C0", Offset = "0x5CCD1C0", VA = "0x185CCE9C0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEAE0", Offset = "0x5CCD2E0", VA = "0x185CCEAE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PJNDDCPELHI : DHMEBDNPOHE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool PFFBJIDFGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private LIHKCAOMEOF HAAHBFIFGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<BBLMPIJHLJP> LLMLNEGEIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<BBLMPIJHLJP> PLKIKCAFJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<BBLMPIJHLJP> HEILEGGLFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> BNJBBCCHOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int HDFGJAGJOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int PBLGJLMCPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int JMOBKJPLBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int MJANOJBHJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int FLAIDFGHCLC;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int DIEGBKIOLGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5CD47A0", Offset = "0x5CD2FA0", VA = "0x185CD47A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4850", Offset = "0x5CD3050", VA = "0x185CD4850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool BNFKEABEFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B28A0", Offset = "0x7B10A0", VA = "0x1807B28A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8620", Offset = "0x8B6E20", VA = "0x1808B8620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool OFFABBDOJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9F9590", Offset = "0x9F7D90", VA = "0x1809F9590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F95A0", Offset = "0x9F7DA0", VA = "0x1809F95A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool PDPGJLKKMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool IMJOLDEPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x152CA00", Offset = "0x152B200", VA = "0x18152CA00", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x152C9A0", Offset = "0x152B1A0", VA = "0x18152C9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float KNGPGFNPJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x19E6010", Offset = "0x19E4810", VA = "0x1819E6010")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7910", Offset = "0x1FE6110", VA = "0x181FE7910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6100", Offset = "0x5CD4900", VA = "0x185CD6100")]
	public PJNDDCPELHI(LIHKCAOMEOF MPLECHMLAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5310", Offset = "0x5CD3B10", VA = "0x185CD5310")]
	private void HGEJDDMANLN(LIHKCAOMEOF MPLECHMLAIA, int HDFGJAGJOEO, int OKGNGMKHAJN, int ADMJKDLHPCI, int NHPBKJPIFFB, HLNCFFEOFNP KOIMDAJNDOD, float FBFKJDDEGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5CD44D0", Offset = "0x5CD2CD0", VA = "0x185CD44D0")]
	private void DCAEINMBIBE(LIHKCAOMEOF MPLECHMLAIA, int BOKEBOMMKEE, int ADMJKDLHPCI, uint3 ILICLKPABDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5E60", Offset = "0x5CD4660", VA = "0x185CD5E60")]
	private bool OPPIBJODKDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5CD48F0", Offset = "0x5CD30F0", VA = "0x185CD48F0", Slot = "4")]
	public bool EIGFNHEIDIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5290", Offset = "0x5CD3A90", VA = "0x185CD5290", Slot = "5")]
	public bool HFBGFFHILGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5CD57F0", Offset = "0x5CD3FF0", VA = "0x185CD57F0", Slot = "6")]
	public void OICBJJIPNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4890", Offset = "0x5CD3090", VA = "0x185CD4890")]
	public void JGCCCFIPOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4890", Offset = "0x5CD3090", VA = "0x185CD4890", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DHMEBDNPOHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool PDPGJLKKMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool IMJOLDEPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EIGFNHEIDIC();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HFBGFFHILGI();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OICBJJIPNIH();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OKKHJOOFILC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float ENAAILEBPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, PJNDDCPELHI> GIHPFFNFDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, EJNMHPBIFEF> OPKMHIEPCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<DHMEBDNPOHE> BPKPDKGDHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<DHMEBDNPOHE> AHLCIFHNLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<DHMEBDNPOHE> DLBFICADBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int MJKIHCEJDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int GDBAMOAFBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float DNJFGBNABAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool BGPLNIMHNED;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool CJFAJBKNJCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAC9D50", Offset = "0xAC8550", VA = "0x180AC9D50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xAE6250", Offset = "0xAE4A50", VA = "0x180AE6250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool DIKPMJKHEKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5CD34C0", Offset = "0x5CD1CC0", VA = "0x185CD34C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string ACNMINMFHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CD3530", Offset = "0x5CD1D30", VA = "0x185CD3530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2D30", Offset = "0x5CD1530", VA = "0x185CD2D30")]
	public void BGLIAIKNCOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2E50", Offset = "0x5CD1650", VA = "0x185CD2E50")]
	public void FGDNAACAGEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3910", Offset = "0x5CD2110", VA = "0x185CD3910")]
	public OKKHJOOFILC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2F60", Offset = "0x5CD1760", VA = "0x185CD2F60")]
	public ANBPMMDBELG JKCLJMACCFA(BIDFGLJCHBO AOCDGMDEJCJ, bool DJAEOPCHCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3380", Offset = "0x5CD1B80", VA = "0x185CD3380")]
	public EJNMHPBIFEF JKCLJMACCFA(PMAJPDDBAFD LGHJCFHBOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2E60", Offset = "0x5CD1660", VA = "0x185CD2E60")]
	public bool FJPJMMODGHF(Hash128 LJHGKCLAIHG, [Out] PJNDDCPELHI PFAIPPELJLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3090", Offset = "0x5CD1890", VA = "0x185CD3090")]
	public PJNDDCPELHI JKCLJMACCFA(LIHKCAOMEOF MPLECHMLAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3510", Offset = "0x5CD1D10", VA = "0x185CD3510")]
	private void NFJICGLLJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2ED0", Offset = "0x5CD16D0", VA = "0x185CD2ED0")]
	private bool GANMCOIPBHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5CD27B0", Offset = "0x5CD0FB0", VA = "0x185CD27B0")]
	public void AOPBNMABOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2D40", Offset = "0x5CD1540", VA = "0x185CD2D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2C80", Offset = "0x5CD1480", VA = "0x185CD2C80")]
	public void BDFMIJLBLMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ABEANDLFLJD : NLFNELHAHNL<HBOCJNPPIDN, HBOCJNPPIDN>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD5D0", Offset = "0x5CCBDD0", VA = "0x185CCD5D0")]
	public ABEANDLFLJD(int BLMGHGDBIPG, int HNLJNHOFJMC, ComputeShader IMHCBGHKGKG, int BILIFDNNHCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OEAOMHKNHEC : NLFNELHAHNL<KCIDBPHNMCD, KCIDBPHNMCD>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2700", Offset = "0x5CD0F00", VA = "0x185CD2700")]
	public OEAOMHKNHEC(int BLMGHGDBIPG, int HNLJNHOFJMC, ComputeShader IMHCBGHKGKG, int BILIFDNNHCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LOOOPNNGMNG : NLFNELHAHNL<MAMMCHCLMNO, MAMMCHCLMNO>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5CD10E0", Offset = "0x5CCF8E0", VA = "0x185CD10E0")]
	public LOOOPNNGMNG(int BLMGHGDBIPG, int HNLJNHOFJMC, ComputeShader IMHCBGHKGKG, int BILIFDNNHCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FKJOOKIDHJA : NLFNELHAHNL<CEINPEFIAJM, MDIAJNPAEEC>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFF00", Offset = "0x5CCE700", VA = "0x185CCFF00")]
	public FKJOOKIDHJA(int BLMGHGDBIPG, int HNLJNHOFJMC, ComputeShader IMHCBGHKGKG, int BILIFDNNHCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JFJKCJLKAHH : NLFNELHAHNL<DFNKFBPAHDJ, DFNKFBPAHDJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0530", Offset = "0x5CCED30", VA = "0x185CD0530")]
	public JFJKCJLKAHH(int BLMGHGDBIPG, int HNLJNHOFJMC, ComputeShader IMHCBGHKGKG, int BILIFDNNHCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class PMHJJKNIHMM : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private PNKBHONFGJO GCEEPLHGCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool ICGNKEDIKDH;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool GKAKEGPKHLG;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6830", Offset = "0x5CD5030", VA = "0x185CD6830")]
	public PMHJJKNIHMM(PNKBHONFGJO DIMPLPIFKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5CD66A0", Offset = "0x5CD4EA0", VA = "0x185CD66A0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer EKAPBJIIHMJ, RenderingData DHCHFJANCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6430", Offset = "0x5CD4C30", VA = "0x185CD6430", Slot = "6")]
	public override void Configure(CommandBuffer EKAPBJIIHMJ, RenderTextureDescriptor KHDCCCPFKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6470", Offset = "0x5CD4C70", VA = "0x185CD6470", Slot = "9")]
	public override void Execute(ScriptableRenderContext LIODJEBJPCP, RenderingData DHCHFJANCMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class CGEAHLCKCKO
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct FHKCEIGKAKL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string BOBHOMKFHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer EKAPBJIIHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext LIODJEBJPCP;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFDF0", Offset = "0x5CCE5F0", VA = "0x185CCFDF0")]
		public FHKCEIGKAKL(string FCDDAAMLIKG, ScriptableRenderContext NHIKMMAPCEJ, [Out] CommandBuffer CJBLEDGPENB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFD40", Offset = "0x5CCE540", VA = "0x185CCFD40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEF40", Offset = "0x5CCD740", VA = "0x185CCEF40")]
	public static bool PDBJPANGNDG(RenderingData DHCHFJANCMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEDA0", Offset = "0x5CCD5A0", VA = "0x185CCEDA0")]
	public static void MOMPMJELIEL(CommandBuffer EKAPBJIIHMJ, ScriptableRenderContext LIODJEBJPCP, ShadowDrawingSettings JGGHNBAOHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEB70", Offset = "0x5CCD370", VA = "0x185CCEB70")]
	public static void HDDPLDHGMCH(CommandBuffer EKAPBJIIHMJ, ScriptableRenderContext LIODJEBJPCP, RenderingData DHCHFJANCMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class PNKBHONFGJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class HNOIJNCDKEG
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int BLBKEPHOOIB;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int NOIPHAFGMLC;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static JDMCMMDOING<MDDJNFGJDGO> MINCBFMEMEE;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static JDMCMMDOING<uint> NCHCLGOMPBK;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static ANELLOPCHDB IGIICCEDKKF;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer AHHGCPMHOIC;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<EKEHLMMMOII> ONJDHANLKLB;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int GKEDHFIDILA;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int OMHNMHMIDGA;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int HBHLHBAIBKE;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int CENMJAJJAGB;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] IFOIBGPHILK;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] LLKDAONGNPN;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static GLABIIIMNEM[][] HOGMHAHEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] BNDDEJDIPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int NKPPHDDCNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int JGGEKIDBBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int OCPKDGJOBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int GODGDJDACHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int GCDEPJELNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int JDPONAOIFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int AHFKHPEJOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int HPNCLHCLCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int PDLEAKMKCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int EHELNLIALDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int FFFMBODFEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int EEJHNDJENPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int KFHCKJKFKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int HFFMOKNFKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int PEFGPCABMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int OHKGIMLGEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int FKMMCNKMGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int LNGGNBNOHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] MNMJGOHOFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private OKKHJOOFILC POECPPOOMBF;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool NKJOAKEGNMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB220", Offset = "0x5CD9A20", VA = "0x185CDB220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB280", Offset = "0x5CD9A80", VA = "0x185CDB280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool MHFIHAEBOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5CDCE40", Offset = "0x5CDB640", VA = "0x185CDCE40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5CD74A0", Offset = "0x5CD5CA0", VA = "0x185CD74A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData KJPNLGBHIKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5CDB1D0", Offset = "0x5CD99D0", VA = "0x185CDB1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6870", Offset = "0x5CD5070", VA = "0x185CD6870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static OOAJOCMLCNF EIEEOPGDAID
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD700", Offset = "0x5CDBF00", VA = "0x185CDD700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC6F0", Offset = "0x5CDAEF0", VA = "0x185CDC6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static ABEANDLFLJD NHIGGCKIGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5CD93E0", Offset = "0x5CD7BE0", VA = "0x185CD93E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5CDCEE0", Offset = "0x5CDB6E0", VA = "0x185CDCEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static OEAOMHKNHEC CBPDHEHMNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6A00", Offset = "0x5CD5200", VA = "0x185CD6A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5CD84F0", Offset = "0x5CD6CF0", VA = "0x185CD84F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static LOOOPNNGMNG CMHPBEILBKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8BA0", Offset = "0x5CD73A0", VA = "0x185CD8BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5CD7430", Offset = "0x5CD5C30", VA = "0x185CD7430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static FKJOOKIDHJA MMOKOICJGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5CD7670", Offset = "0x5CD5E70", VA = "0x185CD7670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8560", Offset = "0x5CD6D60", VA = "0x185CD8560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static JFJKCJLKAHH AEJJCCOMJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5CD76D0", Offset = "0x5CD5ED0", VA = "0x185CD76D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5CD9360", Offset = "0x5CD7B60", VA = "0x185CD9360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material IMBJFDKPHKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8C50", Offset = "0x5CD7450", VA = "0x185CD8C50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6980", Offset = "0x5CD5180", VA = "0x185CD6980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material FNBMOEEIECH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8E80", Offset = "0x5CD7680", VA = "0x185CD8E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5CD7730", Offset = "0x5CD5F30", VA = "0x185CD7730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material JCHMCMCIHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8BF0", Offset = "0x5CD73F0", VA = "0x185CD8BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6A50", Offset = "0x5CD5250", VA = "0x185CD6A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material OJDAJMADHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC690", Offset = "0x5CDAE90", VA = "0x185CDC690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8470", Offset = "0x5CD6C70", VA = "0x185CD8470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool OIOJFFDEPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5CD7500", Offset = "0x5CD5D00", VA = "0x185CD7500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6AD0", Offset = "0x5CD52D0", VA = "0x185CD6AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool DIKPMJKHEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5CDA1C0", Offset = "0x5CD89C0", VA = "0x185CDA1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string ACNMINMFHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5CDCF50", Offset = "0x5CDB750", VA = "0x185CDCF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD890", Offset = "0x5CDC090", VA = "0x185CDD890")]
	internal PNKBHONFGJO([Optional] MClusterData ECLAPNKKCOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB2E0", Offset = "0x5CD9AE0", VA = "0x185CDB2E0")]
	public void MJKJMKCCJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD750", Offset = "0x5CDBF50", VA = "0x185CDD750")]
	public void PMPOKCFOFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB270", Offset = "0x5CD9A70", VA = "0x185CDB270")]
	public void LOOHPPNFLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD68E0", Offset = "0x5CD50E0", VA = "0x185CD68E0")]
	public bool AFDGEGADMDL(Hash128 DFIDMFGDKCM, [Out] PJNDDCPELHI MPLECHMLAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD90A0", Offset = "0x5CD78A0", VA = "0x185CD90A0")]
	public PJNDDCPELHI JKCLJMACCFA(LIHKCAOMEOF KOIMDAJNDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9160", Offset = "0x5CD7960", VA = "0x185CD9160")]
	public EJNMHPBIFEF JKCLJMACCFA(PMAJPDDBAFD LGHJCFHBOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8EE0", Offset = "0x5CD76E0", VA = "0x185CD8EE0")]
	public ANBPMMDBELG JKCLJMACCFA(BIDFGLJCHBO AOCDGMDEJCJ, bool DJAEOPCHCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5CDCE90", Offset = "0x5CDB690", VA = "0x185CDCE90")]
	public void OICBJJIPNIH(DHMEBDNPOHE POHIAPLOGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD610", Offset = "0x5CDBE10", VA = "0x185CDD610")]
	public static void OPBMLNGMFIO(ILKJDFDAGEF HAGBNKDONGH, GLABIIIMNEM[] KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6B30", Offset = "0x5CD5330", VA = "0x185CD6B30")]
	private void CKNMKPJINNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5CD77B0", Offset = "0x5CD5FB0", VA = "0x185CD77B0")]
	private static void FCCCILPJHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9EA0", Offset = "0x5CD86A0", VA = "0x185CD9EA0")]
	public void LFDNNLNBIDD(CommandBuffer EKAPBJIIHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8CB0", Offset = "0x5CD74B0", VA = "0x185CD8CB0")]
	public void IMJHDKOPNFF([Optional] ScriptableRenderContext? LIODJEBJPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5CD85E0", Offset = "0x5CD6DE0", VA = "0x185CD85E0")]
	public void HGOPLOPOIBF(CommandBuffer EKAPBJIIHMJ, ShadowSplitData OODFCJCAAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5CD88C0", Offset = "0x5CD70C0", VA = "0x185CD88C0")]
	public void HGOPLOPOIBF(CommandBuffer EKAPBJIIHMJ, CameraData IDOEMKFJGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5CD98D0", Offset = "0x5CD80D0", VA = "0x185CD98D0")]
	public void KKENJKIMDLF(CommandBuffer EKAPBJIIHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9E30", Offset = "0x5CD8630", VA = "0x185CD9E30")]
	public void LDOMANFBKIK(CommandBuffer EKAPBJIIHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9430", Offset = "0x5CD7C30", VA = "0x185CD9430")]
	public void KJINJEIAEAC(CommandBuffer EKAPBJIIHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC840", Offset = "0x5CDB040", VA = "0x185CDC840")]
	public void OAPEADECICJ(CommandBuffer EKAPBJIIHMJ, ILKJDFDAGEF OEFKIGGENBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC760", Offset = "0x5CDAF60", VA = "0x185CDC760")]
	public void NIBNGIBBOFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA220", Offset = "0x5CD8A20", VA = "0x185CDA220")]
	public void LJGAFCKKELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7560", Offset = "0x5CD5D60", VA = "0x185CD7560", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LNELKGHBLGA
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1BC44F0", Offset = "0x1BC2CF0", VA = "0x181BC44F0")]
	public static int BAAMDPGKPJL(int PBGHCEIGALN, int FDKLBCGDFNG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct EBHCBELCANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 EDHBFCGEBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 FMNDDJMGCNK;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly EBHCBELCANB LHNDPDGNGDB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly EBHCBELCANB GCBDJIKNIJL;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF600", Offset = "0x5CCDE00", VA = "0x185CCF600")]
	public EBHCBELCANB(float4x4 HAAGMJFDAEC, float4 AENFNKEINAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF490", Offset = "0x5CCDC90", VA = "0x185CCF490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct HLNCFFEOFNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 OBAACBLACLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 HOBKDEMPIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 BHGDJDBFMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 HLCFCEEFBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 NGGGGJJAJMH;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct NKOGEKFLKGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 OBAACBLACLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 HOBKDEMPIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 BHGDJDBFMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 HLCFCEEFBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 NGGGGJJAJMH;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct MDIAJNPAEEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public NKOGEKFLKGD PNGHFGKKLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public NKOGEKFLKGD AMDGLJGHGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public NKOGEKFLKGD DHGEHEHLDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public NKOGEKFLKGD LPKFFKMPNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public NKOGEKFLKGD OKMPDHKEJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public NKOGEKFLKGD INDIEINEELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public NKOGEKFLKGD EMOHDIHCGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public NKOGEKFLKGD BBKLFFNGOJG;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct CEINPEFIAJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public HLNCFFEOFNP PNGHFGKKLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public HLNCFFEOFNP AMDGLJGHGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public HLNCFFEOFNP DHGEHEHLDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public HLNCFFEOFNP LPKFFKMPNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public HLNCFFEOFNP OKMPDHKEJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public HLNCFFEOFNP INDIEINEELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public HLNCFFEOFNP EMOHDIHCGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public HLNCFFEOFNP BBKLFFNGOJG;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct KCIDBPHNMCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 LJJKPOHFBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint HEDMOPPGPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint GIBOEKFJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float HGONGHCBCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint NDOJLHNIEIC;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0EB0", Offset = "0x5CCF6B0", VA = "0x185CD0EB0")]
	public KCIDBPHNMCD(PMAJPDDBAFD LGHJCFHBOJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct MDDJNFGJDGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint GBPEIFKFMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint FDCPJGNJDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint NHPBKJPIFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint NDOJLHNIEIC;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1BB0", Offset = "0x5CD03B0", VA = "0x185CD1BB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MAMMCHCLMNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint OKGNGMKHAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint AAIJHFEABIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint PBLGJLMCPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint NDOJLHNIEIC;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1190", Offset = "0x5CCF990", VA = "0x185CD1190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct HBOCJNPPIDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint OJNFNBPIHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint PLAHKIDPEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint OKMBHFBKMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint DLPNGHPDIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint CELAAEIHLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint JJOMFGJPGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint KCCDFHGHPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint NDOJLHNIEIC;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0070", Offset = "0x5CCE870", VA = "0x185CD0070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DFNKFBPAHDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 OPDNEDKCDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 FCNLHMLEHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 AGHGFEFMHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 FAPNFIFJHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 PPAHLNNJDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 KELGEAGPCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 JBOBDPIFHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 HINIMMDAGBK;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF090", Offset = "0x5CCD890", VA = "0x185CCF090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum ILKJDFDAGEF
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

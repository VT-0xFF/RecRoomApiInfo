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
public struct DJDHEGKDALF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] KFNHHNCDICN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] JOBPPJGBOAF;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] NIDNAPKAIED;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C640", VA = "0x180E6D640")]
	public static int BNADEAHMDCK(BAALHBNFBKN HGBAHFEDPPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69C5130", Offset = "0x69C4130", VA = "0x1869C5130")]
	public static int HMJAOEOGEJI(BAALHBNFBKN HGBAHFEDPPC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FHEPGJPDCOK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int MGLEGKNOAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FBINCAOPJMA IAHPLMIAOBD(int HCJLPFCODLH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 LFEMKGOKFBB(int HCJLPFCODLH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GBHEIPHNIPH KMLIHMADMEN();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ILDLIPCGHJO OIOOHJHOJAB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class COHAEPAAKHJ : HABDGOFIACM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private GBHEIPHNIPH DBCCBLKNBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform JGGFMOELPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<JINBCGMELGC> LCOLAMKNHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private DCEOFBHAJFI FEGOFLOGGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private LJHOJNHCLKP JPHLJMAMKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool CFCFIJMNGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private FHEPGJPDCOK JGOJINJBKBP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float ICCIAHENBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x95D9A0", Offset = "0x95C9A0", VA = "0x18095D9A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB8A390", Offset = "0xB89390", VA = "0x180B8A390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BEMKIEJCAPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAB4320", Offset = "0xAB3320", VA = "0x180AB4320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAB43D0", Offset = "0xAB33D0", VA = "0x180AB43D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DGHOMHMBAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x129E530", Offset = "0x129D530", VA = "0x18129E530")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x129DA10", Offset = "0x129CA10", VA = "0x18129DA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LEDIDDIHCAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6058C10", Offset = "0x6057C10", VA = "0x186058C10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6058A30", Offset = "0x6057A30", VA = "0x186058A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool COKPMKJDOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x14C1BC0", Offset = "0x14C0BC0", VA = "0x1814C1BC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69C4980", Offset = "0x69C3980", VA = "0x1869C4980")]
	public COHAEPAAKHJ(FHEPGJPDCOK CEIDENCIKBF, bool BEHPFKPDFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69C4760", Offset = "0x69C3760", VA = "0x1869C4760")]
	private bool ILGBEHMKBEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69C3B40", Offset = "0x69C2B40", VA = "0x1869C3B40", Slot = "4")]
	public bool GKAGDNHKNII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69C3970", Offset = "0x69C2970", VA = "0x1869C3970", Slot = "5")]
	public bool GACAEOGENLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69C3740", Offset = "0x69C2740", VA = "0x1869C3740", Slot = "6")]
	public void FFDBNDOHLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69C3730", Offset = "0x69C2730", VA = "0x1869C3730", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PCKLLPJPGJH
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGOOJOEILOF(CommandBuffer AHCDKJKGIAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EJFMLMOHHIK : PCKLLPJPGJH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int BJDAIFPCLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB57280", Offset = "0xB56280", VA = "0x180B57280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier PMGBABDIDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x42B2030", Offset = "0x42B1030", VA = "0x1842B2030")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69C5A60", Offset = "0x69C4A60", VA = "0x1869C5A60")]
	public EJFMLMOHHIK(int KHLDDJPHOBA, RenderTargetIdentifier AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69C5A10", Offset = "0x69C4A10", VA = "0x1869C5A10", Slot = "4")]
	public void AGOOJOEILOF(CommandBuffer AHCDKJKGIAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct LKJJECACDLG : PCKLLPJPGJH
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int BJDAIFPCLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB57280", Offset = "0xB56280", VA = "0x180B57280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] DBHBNCNCCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99F860", Offset = "0x99E860", VA = "0x18099F860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xEB7C80", Offset = "0xEB6C80", VA = "0x180EB7C80")]
	public LKJJECACDLG(int KHLDDJPHOBA, Vector4[] AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69D1BA0", Offset = "0x69D0BA0", VA = "0x1869D1BA0", Slot = "4")]
	public void AGOOJOEILOF(CommandBuffer AHCDKJKGIAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CGHNEJPKBKM : PCKLLPJPGJH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int BJDAIFPCLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB57280", Offset = "0xB56280", VA = "0x180B57280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] JLCFKAKAEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99F860", Offset = "0x99E860", VA = "0x18099F860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xEB7C80", Offset = "0xEB6C80", VA = "0x180EB7C80")]
	public CGHNEJPKBKM(int KHLDDJPHOBA, float[] AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69C3700", Offset = "0x69C2700", VA = "0x1869C3700", Slot = "4")]
	public void AGOOJOEILOF(CommandBuffer AHCDKJKGIAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HANJOGICFFG : PCKLLPJPGJH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool MALNNBLLMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1CCD220", Offset = "0x1CCC220", VA = "0x181CCD220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42D0330", Offset = "0x42CF330", VA = "0x1842D0330")]
	public HANJOGICFFG(string CKEJJGPNKGO, bool HFODIMENHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69C6B10", Offset = "0x69C5B10", VA = "0x1869C6B10", Slot = "4")]
	public void AGOOJOEILOF(CommandBuffer AHCDKJKGIAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct ILDLIPCGHJO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 OCKDPLOMKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 HNLEEKLHLEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9A27D0", Offset = "0x9A17D0", VA = "0x1809A27D0")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int JCHBLLCNIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9ABFE0", Offset = "0x9AAFE0", VA = "0x1809ABFE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int AKINBFILMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x891670", Offset = "0x890670", VA = "0x180891670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float ENCBGHAKEJG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x95D8F0", Offset = "0x95C8F0", VA = "0x18095D8F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69CF180", Offset = "0x69CE180", VA = "0x1869CF180")]
	public ILDLIPCGHJO(Color NHCEIDKGILJ, int AGHKIKGEHPJ, int NMKJGMDJHGN, float KHHHJFPFEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA0CBC0", Offset = "0xA0BBC0", VA = "0x180A0CBC0")]
	private static float4 KKGANOAJKOJ(Color NHCEIDKGILJ)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69CF0F0", Offset = "0x69CE0F0", VA = "0x1869CF0F0")]
	private static Hash128 GKIDAPOIGNP(ILDLIPCGHJO CEIDENCIKBF)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DCEOFBHAJFI : HABDGOFIACM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string NNLKLCLENDE;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string JLNGEGAOIEN;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string PCFALNGEPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private ILDLIPCGHJO JHOBIMFBJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private HPMDBGEOMNH JNFDDANGPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 GNACJMBDOEP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public LJHOJNHCLKP HPBGOMBFNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x879460", Offset = "0x878460", VA = "0x180879460")]
		[CompilerGenerated]
		get
		{
			return default(LJHOJNHCLKP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xBA4E70", Offset = "0xBA3E70", VA = "0x180BA4E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BEMKIEJCAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x59C1CE0", Offset = "0x59C0CE0", VA = "0x1859C1CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x59C1CF0", Offset = "0x59C0CF0", VA = "0x1859C1CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DGHOMHMBAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F75E80", Offset = "0x1F74E80", VA = "0x181F75E80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69611B0", Offset = "0x69601B0", VA = "0x1869611B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool COKPMKJDOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LEDIDDIHCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5A79890", Offset = "0x5A78890", VA = "0x185A79890", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x69C4A80", Offset = "0x69C3A80", VA = "0x1869C4A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int LCNJIFOOGIB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x69C4FB0", Offset = "0x69C3FB0", VA = "0x1869C4FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69C50F0", Offset = "0x69C40F0", VA = "0x1869C50F0")]
	public DCEOFBHAJFI(ILDLIPCGHJO PKNJHGJGMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69C4EA0", Offset = "0x69C3EA0", VA = "0x1869C4EA0")]
	private bool ILGBEHMKBEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69C4D50", Offset = "0x69C3D50", VA = "0x1869C4D50", Slot = "4")]
	public bool GKAGDNHKNII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69C4A40", Offset = "0x69C3A40", VA = "0x1869C4A40")]
	private static HPMDBGEOMNH AJOHDKGDCNO(ILDLIPCGHJO CEIDENCIKBF)
	{
		return default(HPMDBGEOMNH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x69C4BA0", Offset = "0x69C3BA0", VA = "0x1869C4BA0", Slot = "5")]
	public bool GACAEOGENLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69C4A90", Offset = "0x69C3A90", VA = "0x1869C4A90", Slot = "6")]
	public void FFDBNDOHLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x69D1D20", Offset = "0x69D0D20", VA = "0x1869D1D20", Slot = "0")]
		public override bool Equals(object ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x69D1F20", Offset = "0x69D0F20", VA = "0x1869D1F20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x939730", Offset = "0x938730", VA = "0x180939730")]
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
		private AJANBAFJABB opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static IBGAMBBOFCE CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x69D25F0", Offset = "0x69D15F0", VA = "0x1869D25F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x69D2630", Offset = "0x69D1630", VA = "0x1869D2630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x69D2000", Offset = "0x69D1000", VA = "0x1869D2000", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x69D1FD0", Offset = "0x69D0FD0", VA = "0x1869D1FD0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EIOJIOLKBHF, RenderingData LMJMAMMDCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x69D2460", Offset = "0x69D1460", VA = "0x1869D2460")]
		public void JEOEANHIGEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xEA0340", Offset = "0xE9F340", VA = "0x180EA0340")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PJCDJKBGMKA<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private MLLJOKFFDKJ GKEDKNPPDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private MLLJOKFFDKJ IFLHJAOMKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer NNGAELLJIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture IMBAEPFAAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int NDHAKLDMPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int LEFICHFHENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string IBEPCPNHCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string OLCGMAJIFKB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8593D0", Offset = "0x8583D0", VA = "0x1808593D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int EEJNICEHMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xEC1B80", Offset = "0xEC0B80", VA = "0x180EC1B80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int OPMKJIFJCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86FE80", Offset = "0x86EE80", VA = "0x18086FE80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x47A7D50", Offset = "0x47A6D50", VA = "0x1847A7D50")]
	public PJCDJKBGMKA(string CKEJJGPNKGO, int MILPCMEHEHJ, [Optional] RenderTextureFormat? CGMALBKGCGL, bool MFNKAPFLIMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x47A76C0", Offset = "0x47A66C0", VA = "0x1847A76C0")]
	public void GACAEOGENLN(CommandBuffer AHCDKJKGIAJ, NativeArray<ValType> AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x47A6290", Offset = "0x47A5290", VA = "0x1847A6290")]
	public void ELJBBJPHKKO(CommandBuffer AHCDKJKGIAJ, ComputeShader MIPOOJKHBGC, int DLHCGJKFCIC, int BENFLCAPHNC = -1, int EJHPNMBDPCH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x47A6400", Offset = "0x47A5400", VA = "0x1847A6400")]
	public void ELJBBJPHKKO(Material JNFDDANGPCP, int BENFLCAPHNC = -1, int EJHPNMBDPCH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x47A5B00", Offset = "0x47A4B00", VA = "0x1847A5B00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EGAOHEDNAPP
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELJBBJPHKKO(Material PKNJHGJGMIC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HPBAGBODPJJ<SrcEntry, DstEntry> : EGAOHEDNAPP, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] KCCBNAOFLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected MLLJOKFFDKJ AEBJFDEEAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected MLLJOKFFDKJ LIMOOHJFENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> PJHGCGKOEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> EBLNCPCCCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int KDAKHJPBJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int NGOMEOMOGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected PJCDJKBGMKA<int> EJIAPJAFEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected PJCDJKBGMKA<SrcEntry> GGHIFCHGJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected PJCDJKBGMKA<DstEntry> LPGHDDDGBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader ECJOHAEHLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int KBNBKNPLAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int GDNIOCCMOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int GOCIJFNPFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int INJLCDHGCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int JGJAONJDLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int AICJKEFBGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int FPOINCMOHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int CGPPNLDAJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int JIFOPAOAFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int BGFMOFAKICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int AMKKELKFEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int KDLMOJCIIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string OEJOAAMIEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] MELKABJJOKM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MANBHPILCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3E00180", Offset = "0x3DFF180", VA = "0x183E00180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string OMBKPEIEFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3E004E0", Offset = "0x3DFF4E0", VA = "0x183E004E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3E00C90", Offset = "0x3DFFC90", VA = "0x183E00C90")]
	public HPBAGBODPJJ(string CKEJJGPNKGO, int KLPHADDHJKI, int ODBNMKOEOOJ, RenderTextureFormat CGMALBKGCGL, ComputeShader EFEINBNHIFC, int KMELCOBKNJJ = 0, int DNLHAGLIBML = 0, int LFCJKAHLFFK = 0, int IGJOLGCGKAF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3E00190", Offset = "0x3DFF190", VA = "0x183E00190")]
	public int NBCCEJGNIGI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3E00130", Offset = "0x3DFF130", VA = "0x183E00130")]
	protected void JEDJFCIDILC(int HCALFJOJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFDB0", Offset = "0x3DFEDB0", VA = "0x183DFFDB0")]
	public LJHOJNHCLKP GKAGDNHKNII(SrcEntry AHGAPHMJDIB)
	{
		return default(LJHOJNHCLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFBD0", Offset = "0x3DFEBD0", VA = "0x183DFFBD0")]
	public bool GACAEOGENLN(LJHOJNHCLKP EFPCBKOLOGB, SrcEntry AHGAPHMJDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF8F0", Offset = "0x3DFE8F0", VA = "0x183DFF8F0")]
	public bool FFDBNDOHLIO(LJHOJNHCLKP EFPCBKOLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "6")]
	protected virtual void HIHPBIIFHBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF110", Offset = "0x3DFE110", VA = "0x183DFF110", Slot = "7")]
	public void BBIHBOJGPNA(CommandBuffer AHCDKJKGIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF170", Offset = "0x3DFE170", VA = "0x183DFF170", Slot = "8")]
	public void BBIHBOJGPNA(CommandBuffer AHCDKJKGIAJ, ComputeShader EFEINBNHIFC, int KMELCOBKNJJ = -1, int DNLHAGLIBML = -1, int LFCJKAHLFFK = -1, int IGJOLGCGKAF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF6D0", Offset = "0x3DFE6D0", VA = "0x183DFF6D0", Slot = "9")]
	public void ELJBBJPHKKO(CommandBuffer AHCDKJKGIAJ, ComputeShader EFEINBNHIFC, int KMELCOBKNJJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF870", Offset = "0x3DFE870", VA = "0x183DFF870", Slot = "4")]
	public void ELJBBJPHKKO(Material JNFDDANGPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF5D0", Offset = "0x3DFE5D0", VA = "0x183DFF5D0", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MLLJOKFFDKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong CCLOEIPGJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong PKBIAJEDMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LDCMANMODLG
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct MBAKBPCEOCC : MLLJOKFFDKJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable APCOPGLENMB;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong CCLOEIPGJJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x99F860", Offset = "0x99E860", VA = "0x18099F860", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6187790", Offset = "0x6186790", VA = "0x186187790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong PKBIAJEDMPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x15E8280", Offset = "0x15E7280", VA = "0x1815E8280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4CE7AF0", Offset = "0x4CE6AF0", VA = "0x184CE7AF0")]
		internal MBAKBPCEOCC(IDisposable HMGEGIKCFLF, ulong PMJBHMJFDMO, ulong JIFBJCGLNGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x69D1BD0", Offset = "0x69D0BD0", VA = "0x1869D1BD0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct MBGEFAHHOOE : MLLJOKFFDKJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture PADHCHFNFJP;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong CCLOEIPGJJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x99F860", Offset = "0x99E860", VA = "0x18099F860", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6187790", Offset = "0x6186790", VA = "0x186187790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong PKBIAJEDMPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x15E8280", Offset = "0x15E7280", VA = "0x1815E8280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69D1CF0", Offset = "0x69D0CF0", VA = "0x1869D1CF0")]
		public MBGEFAHHOOE(RenderTexture JCAGFNGDAAB, ulong KGKGJNEBBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69D1C50", Offset = "0x69D0C50", VA = "0x1869D1C50", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong DICMCCOJAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69D1970", Offset = "0x69D0970", VA = "0x1869D1970")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69D1270", Offset = "0x69D0270", VA = "0x1869D1270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong EBDBMOJFPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69D1930", Offset = "0x69D0930", VA = "0x1869D1930")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69D19B0", Offset = "0x69D09B0", VA = "0x1869D19B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69D12B0", Offset = "0x69D02B0", VA = "0x1869D12B0")]
	public static ComputeBuffer EAPGIKBOING(int DOPPKGNLPAC, int PCEDKEAJLAC, ComputeBufferType HNGLFCFOHLI, [Out] MLLJOKFFDKJ EFPCBKOLOGB, ComputeBufferMode HIJBNPKNLJC = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69D1490", Offset = "0x69D0490", VA = "0x1869D1490")]
	public static RenderTexture EAPGIKBOING(int KHPDGKDNGIK, int GOBCOFIHFBN, int EOFGGGAGOCO, RenderTextureFormat CGMALBKGCGL, [Out] MLLJOKFFDKJ EFPCBKOLOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B4F0", Offset = "0x2C7A4F0", VA = "0x182C7B4F0")]
	public static NativeArray<T> GIAHFJEKODB<T>(NativeArray<T> APCOPGLENMB, ulong IGIHBEMLMOK, [Out] MLLJOKFFDKJ EFPCBKOLOGB) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B430", Offset = "0x2C7A430", VA = "0x182C7B430")]
	public static NativeArray<T> EAPGIKBOING<T>(int IGIHBEMLMOK, Allocator OOMMBGGEBLM, [Out] MLLJOKFFDKJ EFPCBKOLOGB, NativeArrayOptions OLBNLJKBNFE = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69D1120", Offset = "0x69D0120", VA = "0x1869D1120")]
	public static void CANECBKHGDE(MLLJOKFFDKJ APCOPGLENMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69D1830", Offset = "0x69D0830", VA = "0x1869D1830")]
	public static uint EKDMAEHPLEN(RenderTextureFormat CGMALBKGCGL)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OHPPMPHLLFN : HPBAGBODPJJ<ACNIIAFFCOO, ACNIIAFFCOO>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct DJIGDPFPEKJ : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> NICMIAJNEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> ANDJPHADDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> DGELAMNHMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> MBGBCILEIBB;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69C59E0", Offset = "0x69C49E0", VA = "0x1869C59E0")]
		public DJIGDPFPEKJ(NativeArray<int> PCBBDHFNBPH, NativeArray<float> EALBCNGDPME, NativeArray<float4x4> MHHNNCMLMED, NativeArray<float4> PNNIIPACCEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x69C5820", Offset = "0x69C4820", VA = "0x1869C5820", Slot = "4")]
		public void Execute(int HCALFJOJKJO, TransformAccess DBCCBLKNBHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct FMEPNFGDKBP : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> NICMIAJNEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> DCBCKDDOPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> EMIFHBNCNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<ACNIIAFFCOO> AHCCBADMIKE;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69C59E0", Offset = "0x69C49E0", VA = "0x1869C59E0")]
		public FMEPNFGDKBP(NativeArray<int> PCBBDHFNBPH, NativeArray<float4x4> PCFJFJDEJLJ, NativeArray<float4> FFJIDBFMMAN, NativeArray<ACNIIAFFCOO> FLACBNGODHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69C5DA0", Offset = "0x69C4DA0", VA = "0x1869C5DA0", Slot = "4")]
		public void Execute(int HCALFJOJKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte JNIBAPKAFOB = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray PGNLEEKOIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> JEBDPACCIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> LBCBCGNLDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> KPKIJMPGEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> IGOKOEPFMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> BCMJDFAHMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private MLLJOKFFDKJ LJBNKKIMMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private MLLJOKFFDKJ BAEGALBLDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private MLLJOKFFDKJ BIBBALFHANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private MLLJOKFFDKJ LMMJKFGGMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private MLLJOKFFDKJ JGPPODHKIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform PBPDGNLGJIG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x69D3170", Offset = "0x69D2170", VA = "0x1869D3170")]
	public OHPPMPHLLFN(int KLPHADDHJKI, int ODBNMKOEOOJ, ComputeShader EFEINBNHIFC, int KMELCOBKNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x69D2C70", Offset = "0x69D1C70", VA = "0x1869D2C70", Slot = "6")]
	protected override void HIHPBIIFHBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x69D2E70", Offset = "0x69D1E70", VA = "0x1869D2E70")]
	private void JBEBMDAGKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x69D3010", Offset = "0x69D2010", VA = "0x1869D3010")]
	public bool OMMIFOBENKK(LJHOJNHCLKP EFPCBKOLOGB, Transform DBCCBLKNBHK, float LKLGOGNDGED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x69D2F30", Offset = "0x69D1F30", VA = "0x1869D2F30")]
	public void JLIIPJLNJHL(LJHOJNHCLKP EFPCBKOLOGB, float LKLGOGNDGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x69D2B20", Offset = "0x69D1B20", VA = "0x1869D2B20")]
	public void ALCFDGNNBMN(LJHOJNHCLKP EFPCBKOLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x69D2BD0", Offset = "0x69D1BD0", VA = "0x1869D2BD0", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FBINCAOPJMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMNEIJMNCCM DLAELEJPAOG();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NEFNDHHPKHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 OCKDPLOMKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int GLOPGFJKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int ILCNKKELGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> ANCEDMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> IAPOJLIJOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> BPLJOFBGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> JPJCNJBLACK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> FBLOMBCJIML
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> DANKACMHEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int BDBFGKNADOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int KGKBLMCLFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int HALOMKNKMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool CECAIPICJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BBIHBOJGPNA();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OFFBHLPJKDH : NEFNDHHPKHH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private FBINCAOPJMA OLAKLKHPHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private CMNEIJMNCCM EIOKGMMIDKC;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 OCKDPLOMKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9A27D0", Offset = "0x9A17D0", VA = "0x1809A27D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA892A0", Offset = "0xA882A0", VA = "0x180A892A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool FHAIFEJLENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x851600", Offset = "0x850600", VA = "0x180851600")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int GLOPGFJKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x891670", Offset = "0x890670", VA = "0x180891670", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x890C60", Offset = "0x88FC60", VA = "0x180890C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int ILCNKKELGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x854630", Offset = "0x853630", VA = "0x180854630", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x854680", Offset = "0x853680", VA = "0x180854680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int GHNNEKCMIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xC48E70", Offset = "0xC47E70", VA = "0x180C48E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> ANCEDMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x69D29D0", Offset = "0x69D19D0", VA = "0x1869D29D0", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> IAPOJLIJOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x69D2910", Offset = "0x69D1910", VA = "0x1869D2910", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> BPLJOFBGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x69D2A70", Offset = "0x69D1A70", VA = "0x1869D2A70", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> JPJCNJBLACK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x69D2740", Offset = "0x69D1740", VA = "0x1869D2740", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> FBLOMBCJIML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69D28C0", Offset = "0x69D18C0", VA = "0x1869D28C0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> DANKACMHEGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69D2A40", Offset = "0x69D1A40", VA = "0x1869D2A40", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CECAIPICJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA68730", Offset = "0xA67730", VA = "0x180A68730", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA68570", Offset = "0xA67570", VA = "0x180A68570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int BDBFGKNADOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x69D2AA0", Offset = "0x69D1AA0", VA = "0x1869D2AA0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int KGKBLMCLFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x69D28F0", Offset = "0x69D18F0", VA = "0x1869D28F0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int HALOMKNKMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69D2AB0", Offset = "0x69D1AB0", VA = "0x1869D2AB0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x69D2AD0", Offset = "0x69D1AD0", VA = "0x1869D2AD0")]
	public OFFBHLPJKDH(Hash128 NPOAPJJLLAJ, FBINCAOPJMA OLAKLKHPHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69D27B0", Offset = "0x69D17B0", VA = "0x1869D27B0", Slot = "16")]
	public void BBIHBOJGPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69D2940", Offset = "0x69D1940", VA = "0x1869D2940", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct LJHOJNHCLKP : IEquatable<LJHOJNHCLKP>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly LJHOJNHCLKP JDOOJIEMHEC;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int LCNJIFOOGIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xB57280", Offset = "0xB56280", VA = "0x180B57280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260")]
	public LJHOJNHCLKP(int HCALFJOJKJO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x69D1AC0", Offset = "0x69D0AC0", VA = "0x1869D1AC0", Slot = "4")]
	public bool Equals(LJHOJNHCLKP ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x69D19F0", Offset = "0x69D09F0", VA = "0x1869D19F0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x69D1B10", Offset = "0x69D0B10", VA = "0x1869D1B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JINBCGMELGC : HABDGOFIACM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool CFCFIJMNGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NEFNDHHPKHH AMIGLCDBMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<LJHOJNHCLKP> PPILJPABDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<LJHOJNHCLKP> NLGKCGAEKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<LJHOJNHCLKP> ENKENDGGNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> OBCLDGPBDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int LLEMLEJAAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int DKMKGMBDOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int CBHDGOFNNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int PNCIFNJBNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int FFLKFJOMCFN;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int LCNJIFOOGIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x69D0EC0", Offset = "0x69CFEC0", VA = "0x1869D0EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x69D0F70", Offset = "0x69CFF70", VA = "0x1869D0F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool BEMKIEJCAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8A3710", Offset = "0x8A2710", VA = "0x1808A3710")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool DGHOMHMBAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xC5CD80", Offset = "0xC5BD80", VA = "0x180C5CD80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xC5CD00", Offset = "0xC5BD00", VA = "0x180C5CD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool COKPMKJDOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LEDIDDIHCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4AE6A80", Offset = "0x4AE5A80", VA = "0x184AE6A80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1A7D0C0", Offset = "0x1A7C0C0", VA = "0x181A7D0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float ICCIAHENBOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x99B4D0", Offset = "0x99A4D0", VA = "0x18099B4D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1E54210", Offset = "0x1E53210", VA = "0x181E54210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x69D0FB0", Offset = "0x69CFFB0", VA = "0x1869D0FB0")]
	public JINBCGMELGC(NEFNDHHPKHH EIOKGMMIDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x69CF680", Offset = "0x69CE680", VA = "0x1869CF680")]
	private void FBJJEIELMMC(NEFNDHHPKHH EIOKGMMIDKC, int LLEMLEJAAAD, int PPFCJEGIFGA, int HCALFJOJKJO, int NBIAIANKLKE, BFNADCOEKBF AHGAPHMJDIB, float DJGBNFILEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x69CF3C0", Offset = "0x69CE3C0", VA = "0x1869CF3C0")]
	private void EEPMNMEIPPG(NEFNDHHPKHH EIOKGMMIDKC, int HDMCHBIINEP, int HCALFJOJKJO, uint3 FKJMHGALHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x69D0C20", Offset = "0x69CFC20", VA = "0x1869D0C20")]
	private bool ILGBEHMKBEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x69D0240", Offset = "0x69CF240", VA = "0x1869D0240", Slot = "4")]
	public bool GKAGDNHKNII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x69D01C0", Offset = "0x69CF1C0", VA = "0x1869D01C0", Slot = "5")]
	public bool GACAEOGENLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x69CFB50", Offset = "0x69CEB50", VA = "0x1869CFB50", Slot = "6")]
	public void FFDBNDOHLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x69CF360", Offset = "0x69CE360", VA = "0x1869CF360")]
	public void BOHCHHKNKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x69CF360", Offset = "0x69CE360", VA = "0x1869CF360", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HABDGOFIACM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool COKPMKJDOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool LEDIDDIHCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKAGDNHKNII();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GACAEOGENLN();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFDBNDOHLIO();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HDGLAFGJMPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float PPIBIBIIJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, JINBCGMELGC> BGPOBHJKOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, DCEOFBHAJFI> MDKLNHCDODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<HABDGOFIACM> JHPILIJLLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<HABDGOFIACM> MEIEJLCMCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<HABDGOFIACM> JAHABIDKFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int POCDEDNELDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int PCNPGBAMAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float BDHOPICDBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool NKIADLPJHDI;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool OBPBBNAHOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xEC4BB0", Offset = "0xEC3BB0", VA = "0x180EC4BB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xED7330", Offset = "0xED6330", VA = "0x180ED7330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool HGKDLHAINID
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x69C7C00", Offset = "0x69C6C00", VA = "0x1869C7C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string OMBKPEIEFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x69C7850", Offset = "0x69C6850", VA = "0x1869C7850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x69C7100", Offset = "0x69C6100", VA = "0x1869C7100")]
	public void CAECLNOEJHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x69C7110", Offset = "0x69C6110", VA = "0x1869C7110")]
	public void CODEDACMJOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x69C7C90", Offset = "0x69C6C90", VA = "0x1869C7C90")]
	public HDGLAFGJMPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x69C7230", Offset = "0x69C6230", VA = "0x1869C7230")]
	public COHAEPAAKHJ GGLLICMBJNI(FHEPGJPDCOK KCAPGDAGEBJ, bool BEHPFKPDFBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x69C7360", Offset = "0x69C6360", VA = "0x1869C7360")]
	public DCEOFBHAJFI GGLLICMBJNI(ILDLIPCGHJO JNFDDANGPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x69C6BE0", Offset = "0x69C5BE0", VA = "0x1869C6BE0")]
	public bool ABPCJAHKMJD(Hash128 KHLDDJPHOBA, [Out] JINBCGMELGC OFBDFCHNKLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69C74A0", Offset = "0x69C64A0", VA = "0x1869C74A0")]
	public JINBCGMELGC GGLLICMBJNI(NEFNDHHPKHH EIOKGMMIDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x69C7780", Offset = "0x69C6780", VA = "0x1869C7780")]
	private void LNEAJEBAENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x69C6B50", Offset = "0x69C5B50", VA = "0x1869C6B50")]
	private bool AAPNFHACHCF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x69C6C50", Offset = "0x69C5C50", VA = "0x1869C6C50")]
	public void BBIHBOJGPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x69C7120", Offset = "0x69C6120", VA = "0x1869C7120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x69C77A0", Offset = "0x69C67A0", VA = "0x1869C77A0")]
	public void MMIDMHDBOBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BIPMNAGAPGI : HPBAGBODPJJ<GNCAKNIFNAA, GNCAKNIFNAA>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x69C35A0", Offset = "0x69C25A0", VA = "0x1869C35A0")]
	public BIPMNAGAPGI(int KLPHADDHJKI, int ODBNMKOEOOJ, ComputeShader EFEINBNHIFC, int KMELCOBKNJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CDNAHCOBEOE : HPBAGBODPJJ<HPMDBGEOMNH, HPMDBGEOMNH>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x69C3650", Offset = "0x69C2650", VA = "0x1869C3650")]
	public CDNAHCOBEOE(int KLPHADDHJKI, int ODBNMKOEOOJ, ComputeShader EFEINBNHIFC, int KMELCOBKNJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FGFCFOCJJDL : HPBAGBODPJJ<JDFJJIEGDOI, JDFJJIEGDOI>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69C5A80", Offset = "0x69C4A80", VA = "0x1869C5A80")]
	public FGFCFOCJJDL(int KLPHADDHJKI, int ODBNMKOEOOJ, ComputeShader EFEINBNHIFC, int KMELCOBKNJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FHBFOBBOKAP : HPBAGBODPJJ<JGHDOEGAEEP, HLBADOLPFMN>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x69C5B30", Offset = "0x69C4B30", VA = "0x1869C5B30")]
	public FHBFOBBOKAP(int KLPHADDHJKI, int ODBNMKOEOOJ, ComputeShader EFEINBNHIFC, int KMELCOBKNJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OAMCLMGHOCH : HPBAGBODPJJ<GDOOAECIOGD, GDOOAECIOGD>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x69D2690", Offset = "0x69D1690", VA = "0x1869D2690")]
	public OAMCLMGHOCH(int KLPHADDHJKI, int ODBNMKOEOOJ, ComputeShader EFEINBNHIFC, int KMELCOBKNJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class AJANBAFJABB : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IBGAMBBOFCE CEJENKBOLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool HFODIMENHKG;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool BNBCDJOBHLP;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x69C34B0", Offset = "0x69C24B0", VA = "0x1869C34B0")]
	public AJANBAFJABB(IBGAMBBOFCE BDJIFPEHCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x69C3320", Offset = "0x69C2320", VA = "0x1869C3320", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer AHCDKJKGIAJ, RenderingData LMJMAMMDCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x69C30B0", Offset = "0x69C20B0", VA = "0x1869C30B0", Slot = "6")]
	public override void Configure(CommandBuffer AHCDKJKGIAJ, RenderTextureDescriptor GLAMOICMHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x69C30F0", Offset = "0x69C20F0", VA = "0x1869C30F0", Slot = "9")]
	public override void Execute(ScriptableRenderContext PDLLDMABKGP, RenderingData LMJMAMMDCBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class GIBJPAGBMHH
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct FKLLMDMIMCG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string CKEJJGPNKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer AHCDKJKGIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext PDLLDMABKGP;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x69C5C90", Offset = "0x69C4C90", VA = "0x1869C5C90")]
		public FKLLMDMIMCG(string MAHKCAIMMJJ, ScriptableRenderContext PNGFEKFFDIF, [Out] CommandBuffer OIPDGIDNEAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x69C5BE0", Offset = "0x69C4BE0", VA = "0x1869C5BE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x69C6670", Offset = "0x69C5670", VA = "0x1869C6670")]
	public static bool PPAHBBEHJKC(RenderingData LMJMAMMDCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x69C64D0", Offset = "0x69C54D0", VA = "0x1869C64D0")]
	public static void GJFABCKKHON(CommandBuffer AHCDKJKGIAJ, ScriptableRenderContext PDLLDMABKGP, ShadowDrawingSettings MCEFNBMGMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x69C62A0", Offset = "0x69C52A0", VA = "0x1869C62A0")]
	public static void GCDMDBMJLNG(CommandBuffer AHCDKJKGIAJ, ScriptableRenderContext PDLLDMABKGP, RenderingData LMJMAMMDCBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class IBGAMBBOFCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class GGJCCDDLGPN
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int KPCAFDJCLPN;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int LNEONMOFOJP;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static PJCDJKBGMKA<BHBEKDFGPHE> EBNGJKNHKON;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static PJCDJKBGMKA<uint> MDIELLHBMMG;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static MLLJOKFFDKJ BOPAOGNGPGC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer GGNKHIIIKJC;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<EGAOHEDNAPP> LLNMNIIIHIF;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int PFEDFKGOIOP;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int DEHJHHOHBGG;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int LEIKGKEBEBJ;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int KPHCFGJEBPK;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] OFMFEBEEFIB;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] MDILBKHKJDL;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static PCKLLPJPGJH[][] DIIEAJBDIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] BGGKAKCLFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int LCMJCKFAIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int DBCFGNLELEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int CEHPPLKOGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int LLIJKJMDFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int IKPLLIIDGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int PKCMFJJOOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int OLFMHBMHJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int JEMCAHIMOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int BADOMKHNNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int NNGMCPOMFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int PGJMHIAFPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int NKCDGGHKGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int FBIIGENNIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int HAGMPEGAONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int LOAKHCBELOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int HIFKHIHOEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int IFANCLKDAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int BGFBHKFJCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] FBKCHCEFGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private HDGLAFGJMPJ OKKBNKAAKBO;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool LNMMCKLGGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x69C9580", Offset = "0x69C8580", VA = "0x1869C9580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x69CB9E0", Offset = "0x69CA9E0", VA = "0x1869CB9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool HBAHLOCIAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x69CE630", Offset = "0x69CD630", VA = "0x1869CE630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x69CA8B0", Offset = "0x69C98B0", VA = "0x1869CA8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData KHBLMBBNMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x69C7F40", Offset = "0x69C6F40", VA = "0x1869C7F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x69CD920", Offset = "0x69CC920", VA = "0x1869CD920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static OHPPMPHLLFN PELFJELDKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x69C94B0", Offset = "0x69C84B0", VA = "0x1869C94B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x69CE6F0", Offset = "0x69CD6F0", VA = "0x1869CE6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static BIPMNAGAPGI ADFKIOAJFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x69C8010", Offset = "0x69C7010", VA = "0x1869C8010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x69C7E50", Offset = "0x69C6E50", VA = "0x1869C7E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static CDNAHCOBEOE MOCLJGBDCBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x69CD8D0", Offset = "0x69CC8D0", VA = "0x1869CD8D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x69CE680", Offset = "0x69CD680", VA = "0x1869CE680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static FGFCFOCJJDL INJOEKLHEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x69CA040", Offset = "0x69C9040", VA = "0x1869CA040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x69CED80", Offset = "0x69CDD80", VA = "0x1869CED80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static FHBFOBBOKAP OFPLECODFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x69CA110", Offset = "0x69C9110", VA = "0x1869CA110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x69CA760", Offset = "0x69C9760", VA = "0x1869CA760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static OAMCLMGHOCH IJLAHFKAKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x69C95D0", Offset = "0x69C85D0", VA = "0x1869C95D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x69C9500", Offset = "0x69C8500", VA = "0x1869C9500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material HONEMBKNPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x69CBA40", Offset = "0x69CAA40", VA = "0x1869CBA40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x69C7EC0", Offset = "0x69C6EC0", VA = "0x1869C7EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material PFCGMDHMHGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x69CE760", Offset = "0x69CD760", VA = "0x1869CE760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69CD850", Offset = "0x69CC850", VA = "0x1869CD850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material NHJMHFIPDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x69CBB40", Offset = "0x69CAB40", VA = "0x1869CBB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x69C7F90", Offset = "0x69C6F90", VA = "0x1869C7F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material AMLJKJNBOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x69CA910", Offset = "0x69C9910", VA = "0x1869CA910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x69CA090", Offset = "0x69C9090", VA = "0x1869CA090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool BHJONKONCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x69CA850", Offset = "0x69C9850", VA = "0x1869CA850")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x69C9740", Offset = "0x69C8740", VA = "0x1869C9740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool HGKDLHAINID
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x69CE070", Offset = "0x69CD070", VA = "0x1869CE070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string OMBKPEIEFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x69CD990", Offset = "0x69CC990", VA = "0x1869CD990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x69CEE90", Offset = "0x69CDE90", VA = "0x1869CEE90")]
	internal IBGAMBBOFCE([Optional] MClusterData CMCMHDHBJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x69CBBA0", Offset = "0x69CABA0", VA = "0x1869CBBA0")]
	public void LFNNOPDGNGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x69C97A0", Offset = "0x69C87A0", VA = "0x1869C97A0")]
	public void FFCEPGCHINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x69CA030", Offset = "0x69C9030", VA = "0x1869CA030")]
	public void GGPNPLMKGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x69CBAA0", Offset = "0x69CAAA0", VA = "0x1869CBAA0")]
	public bool JPGHAPOLGNI(Hash128 NPOAPJJLLAJ, [Out] JINBCGMELGC EIOKGMMIDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x69C9F70", Offset = "0x69C8F70", VA = "0x1869C9F70")]
	public JINBCGMELGC GGLLICMBJNI(NEFNDHHPKHH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x69C9BB0", Offset = "0x69C8BB0", VA = "0x1869C9BB0")]
	public DCEOFBHAJFI GGLLICMBJNI(ILDLIPCGHJO JNFDDANGPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x69C9DB0", Offset = "0x69C8DB0", VA = "0x1869C9DB0")]
	public COHAEPAAKHJ GGLLICMBJNI(FHEPGJPDCOK KCAPGDAGEBJ, bool BEHPFKPDFBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x69C9840", Offset = "0x69C8840", VA = "0x1869C9840")]
	public void FFDBNDOHLIO(HABDGOFIACM KIICPOGENEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x69CB640", Offset = "0x69CA640", VA = "0x1869CB640")]
	public static void JEDOHHCFLOM(BAALHBNFBKN HGBAHFEDPPC, PCKLLPJPGJH[] AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x69CCF50", Offset = "0x69CBF50", VA = "0x1869CCF50")]
	private void LNIKHCEIPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x69CA970", Offset = "0x69C9970", VA = "0x1869CA970")]
	private static void JACHNENANNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x69C9890", Offset = "0x69C8890", VA = "0x1869C9890")]
	public void GFJLDHIOADD(CommandBuffer AHCDKJKGIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x69CB810", Offset = "0x69CA810", VA = "0x1869CB810")]
	public void JFLMFOLIDPN([Optional] ScriptableRenderContext? PDLLDMABKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x69CE7C0", Offset = "0x69CD7C0", VA = "0x1869CE7C0")]
	public void PHABDIANNNC(CommandBuffer AHCDKJKGIAJ, ShadowSplitData MECOMACAAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x69CEAA0", Offset = "0x69CDAA0", VA = "0x1869CEAA0")]
	public void PHABDIANNNC(CommandBuffer AHCDKJKGIAJ, CameraData AOGHHDBLABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x69CE0D0", Offset = "0x69CD0D0", VA = "0x1869CE0D0")]
	public void NIHHBJBKHPK(CommandBuffer AHCDKJKGIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x69CA7E0", Offset = "0x69C97E0", VA = "0x1869CA7E0")]
	public void HJKEBHKCNCP(CommandBuffer AHCDKJKGIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x69C8060", Offset = "0x69C7060", VA = "0x1869C8060")]
	public void BPGIDKCONKG(CommandBuffer AHCDKJKGIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x69CA170", Offset = "0x69C9170", VA = "0x1869CA170")]
	public void GMKDGGBBHKN(CommandBuffer AHCDKJKGIAJ, BAALHBNFBKN DGLLFEHAMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x69CB730", Offset = "0x69CA730", VA = "0x1869CB730")]
	public void JEOEANHIGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x69C8500", Offset = "0x69C7500", VA = "0x1869C8500")]
	public void CANECBKHGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x69C9630", Offset = "0x69C8630", VA = "0x1869C9630", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class IBMNEHGECEN
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1F63C30", Offset = "0x1F62C30", VA = "0x181F63C30")]
	public static int OFKCBDHKEBC(int GGJGGMKAJPM, int KEMKICHMKHB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct ACNIIAFFCOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 CBDANHPJBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 DEHIBDOPIIB;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly ACNIIAFFCOO FPKEBMFGGLP;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly ACNIIAFFCOO JDOOJIEMHEC;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x42D05C0", Offset = "0x42CF5C0", VA = "0x1842D05C0")]
	public ACNIIAFFCOO(float4x4 APAPLJNPNGD, float4 KCMKCPCEKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x69C2F40", Offset = "0x69C1F40", VA = "0x1869C2F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct BFNADCOEKBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 LLLHNMGEKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 NJOPFIOMLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 KGIJHOHKCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 CICNGKAHLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 NJPJCHJCFAK;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct MGFBKMAIFOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 LLLHNMGEKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 NJOPFIOMLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 KGIJHOHKCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 CICNGKAHLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 NJPJCHJCFAK;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct HLBADOLPFMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public MGFBKMAIFOM KKIPMKBBOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public MGFBKMAIFOM LACHDKAIAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public MGFBKMAIFOM IMBKOCKNIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public MGFBKMAIFOM EHEOHEFOOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public MGFBKMAIFOM AJOFJEKCFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public MGFBKMAIFOM CDFMLDALHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public MGFBKMAIFOM JMDIBLMBKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public MGFBKMAIFOM EHDMBCFILFM;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct JGHDOEGAEEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public BFNADCOEKBF KKIPMKBBOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public BFNADCOEKBF LACHDKAIAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public BFNADCOEKBF IMBKOCKNIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public BFNADCOEKBF EHEOHEFOOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public BFNADCOEKBF AJOFJEKCFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public BFNADCOEKBF CDFMLDALHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public BFNADCOEKBF JMDIBLMBKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public BFNADCOEKBF EHDMBCFILFM;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct HPMDBGEOMNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 OPGILNOKCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint AGHKIKGEHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint NMKJGMDJHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float KHHHJFPFEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint DEMLNEGAFPP;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x69C7E20", Offset = "0x69C6E20", VA = "0x1869C7E20")]
	public HPMDBGEOMNH(ILDLIPCGHJO JNFDDANGPCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct BHBEKDFGPHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint EHEHFBEAAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint MHLJNJEKBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint NBIAIANKLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint DEMLNEGAFPP;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x69C34F0", Offset = "0x69C24F0", VA = "0x1869C34F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JDFJJIEGDOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint PPFCJEGIFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint KJKGEHDOCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint DKMKGMBDOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint DEMLNEGAFPP;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x69CF2B0", Offset = "0x69CE2B0", VA = "0x1869CF2B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct GNCAKNIFNAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint BOBDGMLNJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint KBPAEDAMODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint JEPIKNEAHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint KAJPAJJMNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint CHGAHEIKPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint JCLBNFFCONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint FFOBEBFCDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint DEMLNEGAFPP;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x69C67C0", Offset = "0x69C57C0", VA = "0x1869C67C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct GDOOAECIOGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 PELJAEKEHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 NEJBHJNKLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 ACBJOOGGKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 NOENKCCDNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 NDGNDFOHDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 CDMICDIFBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 BCMKDDIACIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 NKCIOFKENIH;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x69C5E10", Offset = "0x69C4E10", VA = "0x1869C5E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum BAALHBNFBKN
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

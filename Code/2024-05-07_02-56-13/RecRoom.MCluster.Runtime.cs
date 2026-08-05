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
public struct DBOOEFDMPPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] MHMPNNHDFAJ;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] LNHMJNLBFEG;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] MGHHIIFNFIH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD64C80", Offset = "0xD63E80", VA = "0x180D64C80")]
	public static int HIPNEJLILBN(PGOMAJBMJLL AGBFFDLLICJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x62305C0", Offset = "0x622F7C0", VA = "0x1862305C0")]
	public static int FCEMGAHBDJN(PGOMAJBMJLL AGBFFDLLICJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EEAKGMPCBLB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BLMDCGGKAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NOIJOHIFIKB LOJDFJCAKIK(int DKNFDKCGOLD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 AIMDPDHABDK(int DKNFDKCGOLD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NMHECPHFLPD ELPCJJKDBEC();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MKACELPBNLB PKIAINMDFAO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DEMNBLNIAFC : FFOMOPMPLDI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NMHECPHFLPD GCDMIBEHAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform MACELADKFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<KJLKNLMDACC> HPFOKNPFDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private DDBMPFGBPKL FODAMINAEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private KMJDMMPPAEF OGOEHLIAIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool LBHEKOBNCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EEAKGMPCBLB MEELLDMMJGB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float CFAPHNNOJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x941250", Offset = "0x940450", VA = "0x180941250")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x94D310", Offset = "0x94C510", VA = "0x18094D310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool APKNJHPGAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x872830", Offset = "0x871A30", VA = "0x180872830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8728E0", Offset = "0x871AE0", VA = "0x1808728E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LGKOADCOBLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x103C290", Offset = "0x103B490", VA = "0x18103C290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x103BBE0", Offset = "0x103ADE0", VA = "0x18103BBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LBCIKBPNKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6231500", Offset = "0x6230700", VA = "0x186231500", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6231950", Offset = "0x6230B50", VA = "0x186231950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IOLHIPJLEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1272760", Offset = "0x1271960", VA = "0x181272760", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6232590", Offset = "0x6231790", VA = "0x186232590")]
	public DEMNBLNIAFC(EEAKGMPCBLB FNIBPAONDEO, bool MAPOPEEFJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6231510", Offset = "0x6230710", VA = "0x186231510")]
	private bool LIGPFFNGBLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6231960", Offset = "0x6230B60", VA = "0x186231960", Slot = "4")]
	public bool OEOPOJPHCNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6231330", Offset = "0x6230530", VA = "0x186231330", Slot = "5")]
	public bool GKEPGFOADJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6231730", Offset = "0x6230930", VA = "0x186231730", Slot = "6")]
	public void MFEEKLGJAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6231320", Offset = "0x6230520", VA = "0x186231320", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OHILOCOEJEI
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLMPOJGAFKF(CommandBuffer PJBGKGJIDOO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct POBIAJFGHHL : OHILOCOEJEI
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int GHMLFHHEGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier HLOOBJAOBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D10910", Offset = "0x3D0FB10", VA = "0x183D10910")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x623FDF0", Offset = "0x623EFF0", VA = "0x18623FDF0")]
	public POBIAJFGHHL(int JNIKIHKLGAD, RenderTargetIdentifier FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x623FDA0", Offset = "0x623EFA0", VA = "0x18623FDA0", Slot = "4")]
	public void BLMPOJGAFKF(CommandBuffer PJBGKGJIDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PFMJJLHDFLO : OHILOCOEJEI
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int GHMLFHHEGMK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] NHFMMDILLJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9154B0", Offset = "0x9146B0", VA = "0x1809154B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xC46070", Offset = "0xC45270", VA = "0x180C46070")]
	public PFMJJLHDFLO(int JNIKIHKLGAD, Vector4[] FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x623F970", Offset = "0x623EB70", VA = "0x18623F970", Slot = "4")]
	public void BLMPOJGAFKF(CommandBuffer PJBGKGJIDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GDLOIJPNPMN : OHILOCOEJEI
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int GHMLFHHEGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] LBMJAFDCBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9154B0", Offset = "0x9146B0", VA = "0x1809154B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xC46070", Offset = "0xC45270", VA = "0x180C46070")]
	public GDLOIJPNPMN(int JNIKIHKLGAD, float[] FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x62334E0", Offset = "0x62326E0", VA = "0x1862334E0", Slot = "4")]
	public void BLMPOJGAFKF(CommandBuffer PJBGKGJIDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct OOMCBBEABKN : OHILOCOEJEI
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool JDLAAFJNJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x19E6010", Offset = "0x19E5210", VA = "0x1819E6010")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x398C940", Offset = "0x398BB40", VA = "0x18398C940")]
	public OOMCBBEABKN(string IKEFBMMMAJB, bool FFABKOCEGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x623E650", Offset = "0x623D850", VA = "0x18623E650", Slot = "4")]
	public void BLMPOJGAFKF(CommandBuffer PJBGKGJIDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MKACELPBNLB
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 CAFLFDOEGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 OKFOAOPLJPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x843A80", Offset = "0x842C80", VA = "0x180843A80")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int JMNMILLIANI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x821ED0", Offset = "0x8210D0", VA = "0x180821ED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int AEALIJJKKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F40C0", Offset = "0x7F32C0", VA = "0x1807F40C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float ABAMDCJOKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x96FA50", Offset = "0x96EC50", VA = "0x18096FA50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62375C0", Offset = "0x62367C0", VA = "0x1862375C0")]
	public MKACELPBNLB(Color NHDAKDKKMHH, int NFDEEDDAFGL, int OLIJILKFIJO, float AAKEMFMCHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8C10", Offset = "0x1CE7E10", VA = "0x181CE8C10")]
	private static float4 CJIPPKJGHKJ(Color NHDAKDKKMHH)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6237530", Offset = "0x6236730", VA = "0x186237530")]
	private static Hash128 FJCPCBIIKOA(MKACELPBNLB FNIBPAONDEO)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DDBMPFGBPKL : FFOMOPMPLDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string ELMLKHJBKHF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string BHKKGGBPKDF;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string AHBAIIKMHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private MKACELPBNLB CHEMBIBEPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private MHLNOOHMCIH PEGNOKKFPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 GNNKJJCHEKB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public KMJDMMPPAEF LAJFKDEHKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1B0", Offset = "0x7DB3B0", VA = "0x1807DC1B0")]
		[CompilerGenerated]
		get
		{
			return default(KMJDMMPPAEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x948B80", Offset = "0x947D80", VA = "0x180948B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool APKNJHPGAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x52B97E0", Offset = "0x52B89E0", VA = "0x1852B97E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x52B97F0", Offset = "0x52B89F0", VA = "0x1852B97F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LGKOADCOBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1DCDE40", Offset = "0x1DCD040", VA = "0x181DCDE40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5900", Offset = "0x5FE4B00", VA = "0x185FE5900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IOLHIPJLEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LBCIKBPNKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x536F540", Offset = "0x536E740", VA = "0x18536F540", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5A70", Offset = "0x5FE4C70", VA = "0x185FE5A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int JPDBMMOIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6231060", Offset = "0x6230260", VA = "0x186231060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62312E0", Offset = "0x62304E0", VA = "0x1862312E0")]
	public DDBMPFGBPKL(MKACELPBNLB ODOPCMMDNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6230E20", Offset = "0x6230020", VA = "0x186230E20")]
	private bool LIGPFFNGBLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62310B0", Offset = "0x62302B0", VA = "0x1862310B0", Slot = "4")]
	public bool OEOPOJPHCNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6230F20", Offset = "0x6230120", VA = "0x186230F20")]
	private static MHLNOOHMCIH LNEFBOKGGFH(MKACELPBNLB FNIBPAONDEO)
	{
		return default(MHLNOOHMCIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6230C70", Offset = "0x622FE70", VA = "0x186230C70", Slot = "5")]
	public bool GKEPGFOADJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6230F60", Offset = "0x6230160", VA = "0x186230F60", Slot = "6")]
	public void MFEEKLGJAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6236BB0", Offset = "0x6235DB0", VA = "0x186236BB0", Slot = "0")]
		public override bool Equals(object NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6236DB0", Offset = "0x6235FB0", VA = "0x186236DB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x89ADA0", Offset = "0x899FA0", VA = "0x18089ADA0")]
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
		private JIDPMIPJDMH opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static OIBNJBDNAHI CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6237470", Offset = "0x6236670", VA = "0x186237470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x62374B0", Offset = "0x62366B0", VA = "0x1862374B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6236E90", Offset = "0x6236090", VA = "0x186236E90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6236E60", Offset = "0x6236060", VA = "0x186236E60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CPHKADKGBCP, RenderingData JHNOMFMDOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x62372E0", Offset = "0x62364E0", VA = "0x1862372E0")]
		public void KPLOEOKNPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xC574D0", Offset = "0xC566D0", VA = "0x180C574D0")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CALAICHOFNM<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private EFEBGMFHHBP CCJCMFLCFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private EFEBGMFHHBP JGMHJNBNFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer JCPGENGJFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture ABPIIMNLAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int PGBEJFCCGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int ENIFIBMNPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string LLAJCPFCFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string FGOGJGPDKKD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCF0", Offset = "0x7BEEF0", VA = "0x1807BFCF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int LFCPKHOPIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xC75050", Offset = "0xC74250", VA = "0x180C75050")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int DONPHJONELM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7D2A30", Offset = "0x7D1C30", VA = "0x1807D2A30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4A843C0", Offset = "0x4A835C0", VA = "0x184A843C0")]
	public CALAICHOFNM(string IKEFBMMMAJB, int GILLNJMGIFO, [Optional] RenderTextureFormat? IHFDBLMLKMD, bool IJGLADFDDAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4A80FF0", Offset = "0x4A801F0", VA = "0x184A80FF0")]
	public void GKEPGFOADJA(CommandBuffer PJBGKGJIDOO, NativeArray<ValType> FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4A829D0", Offset = "0x4A81BD0", VA = "0x184A829D0")]
	public void HHIKPOOHMOJ(CommandBuffer PJBGKGJIDOO, ComputeShader PFJNLOECCCA, int JPPHPNOHGNG, int OJKJAMGHGNM = -1, int HOFCCEOKGJJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4A82CB0", Offset = "0x4A81EB0", VA = "0x184A82CB0")]
	public void HHIKPOOHMOJ(Material PEGNOKKFPLO, int OJKJAMGHGNM = -1, int HOFCCEOKGJJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4A80890", Offset = "0x4A7FA90", VA = "0x184A80890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NDIANEKBPPB
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHIKPOOHMOJ(Material ODOPCMMDNBA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OEFCDPPNDDE<SrcEntry, DstEntry> : NDIANEKBPPB, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] KOCOKLIJMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected EFEBGMFHHBP DCMGIEPBEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected EFEBGMFHHBP CCGJAHAMEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> PEEBCECDHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> OOEBPJOPGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int BCIKHGNCBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int KODAKMDLBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected CALAICHOFNM<int> FOEEHNJCHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected CALAICHOFNM<SrcEntry> MFFCMNIEDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected CALAICHOFNM<DstEntry> AEIJANDNCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader NINHIEJILDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int OFCJHLLCDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int CNIOFAHFNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int NBJIOCINLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int NLEOJEBKEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int GDPNFLLPMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int OEIBGDMHGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int AJEJOAPEOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int ECNIFNBEOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int GCCMBINHBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int NIHDIEMAPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int NGLAHNLPJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int OFBBKGKFGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string LBEBDHJDGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] ABECABDDBMA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int FGPMDJIDHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4175DD0", Offset = "0x4174FD0", VA = "0x184175DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string GLCKJKAIFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4175DE0", Offset = "0x4174FE0", VA = "0x184175DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x417B110", Offset = "0x417A310", VA = "0x18417B110")]
	public OEFCDPPNDDE(string IKEFBMMMAJB, int FLLEPAKEGHM, int NHNFDMADPCB, RenderTextureFormat IHFDBLMLKMD, ComputeShader GEBANKACJBN, int KECGCCHOMBE = 0, int ECBPHGAFEDL = 0, int IMAMJAEOEPK = 0, int NMAHDDJPKEM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4176EC0", Offset = "0x41760C0", VA = "0x184176EC0")]
	public int CGAJHOHIHHK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4179520", Offset = "0x4178720", VA = "0x184179520")]
	protected void NDDNHLMJJFO(int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4179850", Offset = "0x4178A50", VA = "0x184179850")]
	public KMJDMMPPAEF OEOPOJPHCNL(SrcEntry FODGEDCJIDC)
	{
		return default(KMJDMMPPAEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4177880", Offset = "0x4176A80", VA = "0x184177880")]
	public bool GKEPGFOADJA(KMJDMMPPAEF EIKDEMMADOB, SrcEntry FODGEDCJIDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4179420", Offset = "0x4178620", VA = "0x184179420")]
	public bool MFEEKLGJAPH(KMJDMMPPAEF EIKDEMMADOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "6")]
	protected virtual void HFOHOPLGOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x41785E0", Offset = "0x41777E0", VA = "0x1841785E0", Slot = "7")]
	public void LJBOMINMHAP(CommandBuffer PJBGKGJIDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x41782E0", Offset = "0x41774E0", VA = "0x1841782E0", Slot = "8")]
	public void LJBOMINMHAP(CommandBuffer PJBGKGJIDOO, ComputeShader GEBANKACJBN, int KECGCCHOMBE = -1, int ECBPHGAFEDL = -1, int IMAMJAEOEPK = -1, int NMAHDDJPKEM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4177E20", Offset = "0x4177020", VA = "0x184177E20", Slot = "9")]
	public void HHIKPOOHMOJ(CommandBuffer PJBGKGJIDOO, ComputeShader GEBANKACJBN, int KECGCCHOMBE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4177F90", Offset = "0x4177190", VA = "0x184177F90", Slot = "4")]
	public void HHIKPOOHMOJ(Material PEGNOKKFPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4176F30", Offset = "0x4176130", VA = "0x184176F30", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EFEBGMFHHBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong LIMPPGFGEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong KGNJJHGBHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JDIIFEJLDKH
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct BMFCJFKIDJO : EFEBGMFHHBP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable HKFDJMCEGFF;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong LIMPPGFGEJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9154B0", Offset = "0x9146B0", VA = "0x1809154B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5A3C810", Offset = "0x5A3BA10", VA = "0x185A3C810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong KGNJJHGBHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1380DC0", Offset = "0x137FFC0", VA = "0x181380DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4705D90", Offset = "0x4704F90", VA = "0x184705D90")]
		internal BMFCJFKIDJO(IDisposable LAGNFJJGJBG, ulong POJPHGEADJP, ulong INOJJAEHIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x62303E0", Offset = "0x622F5E0", VA = "0x1862303E0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct FEABNJPOHBO : EFEBGMFHHBP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture PMJBCJODPKB;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong LIMPPGFGEJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9154B0", Offset = "0x9146B0", VA = "0x1809154B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5A3C810", Offset = "0x5A3BA10", VA = "0x185A3C810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong KGNJJHGBHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1380DC0", Offset = "0x137FFC0", VA = "0x181380DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6233020", Offset = "0x6232220", VA = "0x186233020")]
		public FEABNJPOHBO(RenderTexture AFMCPMEGELI, ulong IHHCAGAOGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6232F80", Offset = "0x6232180", VA = "0x186232F80", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong KILOKAFJJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6233750", Offset = "0x6232950", VA = "0x186233750")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6233A20", Offset = "0x6232C20", VA = "0x186233A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong PFDONIJEAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6233FC0", Offset = "0x62331C0", VA = "0x186233FC0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6233790", Offset = "0x6232990", VA = "0x186233790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6233DF0", Offset = "0x6232FF0", VA = "0x186233DF0")]
	public static ComputeBuffer LAFNMEJJDLL(int KIGJDGACGDD, int BMMBLLHNCBJ, ComputeBufferType FLPJMDMACMC, [Out] EFEBGMFHHBP EIKDEMMADOB, ComputeBufferMode MAGPNICKDGE = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6233A60", Offset = "0x6232C60", VA = "0x186233A60")]
	public static RenderTexture LAFNMEJJDLL(int OPAEHCFOMFA, int CPFEGDHJOBM, int JOJPILNPIBH, RenderTextureFormat IHFDBLMLKMD, [Out] EFEBGMFHHBP EIKDEMMADOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2942C40", Offset = "0x2941E40", VA = "0x182942C40")]
	public static NativeArray<T> DLCDFCIFABF<T>(NativeArray<T> HKFDJMCEGFF, ulong HHOELNLHIEN, [Out] EFEBGMFHHBP EIKDEMMADOB) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2943AA0", Offset = "0x2942CA0", VA = "0x182943AA0")]
	public static NativeArray<T> LAFNMEJJDLL<T>(int HHOELNLHIEN, Allocator ILEAEEDKNCF, [Out] EFEBGMFHHBP EIKDEMMADOB, NativeArrayOptions LDPJIDDAJGB = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x62337D0", Offset = "0x62329D0", VA = "0x1862337D0")]
	public static void HDPILJBHDHI(EFEBGMFHHBP HKFDJMCEGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6233920", Offset = "0x6232B20", VA = "0x186233920")]
	public static uint HLGCGOJLHGA(RenderTextureFormat IHFDBLMLKMD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DGNJELHHEBD : OEFCDPPNDDE<JBCCDGFGLFO, JBCCDGFGLFO>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct BIPOLFBMFIG : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> ILADMHGOKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> JKAMKCEIBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> GPJHKAIMIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> FLJKPIKKOHI;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x62303B0", Offset = "0x622F5B0", VA = "0x1862303B0")]
		public BIPOLFBMFIG(NativeArray<int> OOLADGJNLBG, NativeArray<float> FLGOHMHHPBA, NativeArray<float4x4> MBHJGCAIFOH, NativeArray<float4> HAPMKMKPLMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62301F0", Offset = "0x622F3F0", VA = "0x1862301F0", Slot = "4")]
		public void Execute(int HMFNCGHECPG, TransformAccess GCDMIBEHAIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct NCMKJCDGNEC : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> ILADMHGOKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> GNILECNHCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> HHDNLFDHJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<JBCCDGFGLFO> AGFKIOLMGBH;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x62303B0", Offset = "0x622F5B0", VA = "0x1862303B0")]
		public NCMKJCDGNEC(NativeArray<int> OOLADGJNLBG, NativeArray<float4x4> AIHJCNMPCKK, NativeArray<float4> CCCGKMOANIP, NativeArray<JBCCDGFGLFO> BOFPFAHMDKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62376F0", Offset = "0x62368F0", VA = "0x1862376F0", Slot = "4")]
		public void Execute(int HMFNCGHECPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte KILHCNBOFCJ = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray IDFNEJPLMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> MPFKBPFFAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> EGJKJJKALPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> HCAEPFMHNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> LPKMFBODHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> FMJNHGNGGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private EFEBGMFHHBP IOHGHJDIMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EFEBGMFHHBP PCNMEMAKLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EFEBGMFHHBP EEGFOEENMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EFEBGMFHHBP EMDLJNCIDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private EFEBGMFHHBP FMJAONJOAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform FKNHEDFIAJP;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6232CA0", Offset = "0x6231EA0", VA = "0x186232CA0")]
	public DGNJELHHEBD(int FLLEPAKEGHM, int NHNFDMADPCB, ComputeShader GEBANKACJBN, int KECGCCHOMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6232AA0", Offset = "0x6231CA0", VA = "0x186232AA0", Slot = "6")]
	protected override void HFOHOPLGOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6232900", Offset = "0x6231B00", VA = "0x186232900")]
	private void EJIAGCGIMNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6232650", Offset = "0x6231850", VA = "0x186232650")]
	public bool APFLAGJKNHK(KMJDMMPPAEF EIKDEMMADOB, Transform GCDMIBEHAIO, float EIEIEOFNBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x62329C0", Offset = "0x6231BC0", VA = "0x1862329C0")]
	public void HAFJCDPIKEA(KMJDMMPPAEF EIKDEMMADOB, float EIEIEOFNBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x62327B0", Offset = "0x62319B0", VA = "0x1862327B0")]
	public void DJBAKCMMELC(KMJDMMPPAEF EIKDEMMADOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6232860", Offset = "0x6231A60", VA = "0x186232860", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NOIJOHIFIKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLHCPFCIGJP IBGEGAABELB();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OOMHHILGFON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 CAFLFDOEGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int EPECIFGNGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int ALHCGDDKPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> MFDMLPFPBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> GDFBIKCODFE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> AAENIMHAOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> JKKLDAJBLKL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> BILAKMPMPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> JJPCLAJJMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int LEAFPJOKFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int CJCKIBDOODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int PJHFMMEDFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool FFHDBCENFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LJBOMINMHAP();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GAOEDDDJJDJ : OOMHHILGFON, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NOIJOHIFIKB OGLGMFOLKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HLHCPFCIGJP PGNOHIOKGKO;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 CAFLFDOEGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x843A80", Offset = "0x842C80", VA = "0x180843A80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8439E0", Offset = "0x842BE0", VA = "0x1808439E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool IMGIMLMNILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7B6000", Offset = "0x7B5200", VA = "0x1807B6000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int EPECIFGNGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F40C0", Offset = "0x7F32C0", VA = "0x1807F40C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7F36B0", Offset = "0x7F28B0", VA = "0x1807F36B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int ALHCGDDKPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B9980", Offset = "0x7B8B80", VA = "0x1807B9980", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9970", Offset = "0x7B8B70", VA = "0x1807B9970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int EHAIABPKIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA039A0", Offset = "0xA02BA0", VA = "0x180A039A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> MFDMLPFPBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6233410", Offset = "0x6232610", VA = "0x186233410", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> GDFBIKCODFE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6233150", Offset = "0x6232350", VA = "0x186233150", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> AAENIMHAOFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6233120", Offset = "0x6232320", VA = "0x186233120", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> JKKLDAJBLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6233260", Offset = "0x6232460", VA = "0x186233260", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> BILAKMPMPLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x62333E0", Offset = "0x62325E0", VA = "0x1862333E0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> JJPCLAJJMFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6233210", Offset = "0x6232410", VA = "0x186233210", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FFHDBCENFBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8772A0", Offset = "0x8764A0", VA = "0x1808772A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x96F200", Offset = "0x96E400", VA = "0x18096F200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int LEAFPJOKFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6233480", Offset = "0x6232680", VA = "0x186233480", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int CJCKIBDOODN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6233100", Offset = "0x6232300", VA = "0x186233100", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int PJHFMMEDFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6233240", Offset = "0x6232440", VA = "0x186233240", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6233490", Offset = "0x6232690", VA = "0x186233490")]
	public GAOEDDDJJDJ(Hash128 LNOOCJJIMOE, NOIJOHIFIKB OGLGMFOLKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x62332D0", Offset = "0x62324D0", VA = "0x1862332D0", Slot = "16")]
	public void LJBOMINMHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6233180", Offset = "0x6232380", VA = "0x186233180", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KMJDMMPPAEF : IEquatable<KMJDMMPPAEF>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly KMJDMMPPAEF BKMHILKPIAJ;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int JPDBMMOIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
	public KMJDMMPPAEF(int HMFNCGHECPG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x62366E0", Offset = "0x62358E0", VA = "0x1862366E0", Slot = "4")]
	public bool Equals(KMJDMMPPAEF NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6236730", Offset = "0x6235930", VA = "0x186236730", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6236800", Offset = "0x6235A00", VA = "0x186236800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KJLKNLMDACC : FFOMOPMPLDI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool LBHEKOBNCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private OOMHHILGFON FEHBLGPPOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<KMJDMMPPAEF> BKNNDHCKONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<KMJDMMPPAEF> ONALNDELKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<KMJDMMPPAEF> HKMJPAJPCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> NFMLMEEPBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int ILFCMJPICCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int MANLMKKLAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int MDCFGBIIPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int OEHJKBKENHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int IDBBOMEGONB;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int JPDBMMOIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6235B20", Offset = "0x6234D20", VA = "0x186235B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6234F20", Offset = "0x6234120", VA = "0x186234F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool APKNJHPGAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x827680", Offset = "0x826880", VA = "0x180827680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x88CAB0", Offset = "0x88BCB0", VA = "0x18088CAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool LGKOADCOBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA339A0", Offset = "0xA32BA0", VA = "0x180A339A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA33990", Offset = "0xA32B90", VA = "0x180A33990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool IOLHIPJLEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LBCIKBPNKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4545A30", Offset = "0x4544C30", VA = "0x184545A30", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x17B7290", Offset = "0x17B6490", VA = "0x1817B7290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float CFAPHNNOJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1B65870", Offset = "0x1B64A70", VA = "0x181B65870")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1B65880", Offset = "0x1B64A80", VA = "0x181B65880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6236570", Offset = "0x6235770", VA = "0x186236570")]
	public KJLKNLMDACC(OOMHHILGFON PGNOHIOKGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6234960", Offset = "0x6233B60", VA = "0x186234960")]
	private void BLDBJDFOJFI(OOMHHILGFON PGNOHIOKGKO, int ILFCMJPICCH, int OIPDFMEJMHM, int HMFNCGHECPG, int CCLMIDNHCLJ, AKLBGHOCHLG FODGEDCJIDC, float FMDLHFFHAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6235850", Offset = "0x6234A50", VA = "0x186235850")]
	private void MGGFAIIMFEN(OOMHHILGFON PGNOHIOKGKO, int PHBEKBCLEPJ, int HMFNCGHECPG, uint3 BOMJDAAMLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6234F60", Offset = "0x6234160", VA = "0x186234F60")]
	private bool LIGPFFNGBLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6235BD0", Offset = "0x6234DD0", VA = "0x186235BD0", Slot = "4")]
	public bool OEOPOJPHCNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6234EA0", Offset = "0x62340A0", VA = "0x186234EA0", Slot = "5")]
	public bool GKEPGFOADJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6235200", Offset = "0x6234400", VA = "0x186235200", Slot = "6")]
	public void MFEEKLGJAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6234E40", Offset = "0x6234040", VA = "0x186234E40")]
	public void GBONMDDBBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6234E40", Offset = "0x6234040", VA = "0x186234E40", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FFOMOPMPLDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool IOLHIPJLEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool LBCIKBPNKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OEOPOJPHCNL();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GKEPGFOADJA();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFEEKLGJAPH();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PAAEJIELAKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float GFCECHEBDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, KJLKNLMDACC> GGDHHPELAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, DDBMPFGBPKL> IMHAGGOJKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<FFOMOPMPLDI> IABEOJLHNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<FFOMOPMPLDI> FNNNBDMOABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<FFOMOPMPLDI> AALKGCFHLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int LIDHINDCCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int ALCKLPGGEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float LKJLLIAJNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool BDOFHLBNHDP;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool EKBCDCBEGLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xC7BA60", Offset = "0xC7AC60", VA = "0x180C7BA60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xC7F980", Offset = "0xC7EB80", VA = "0x180C7F980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GJNFAMFHLJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x623F270", Offset = "0x623E470", VA = "0x18623F270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string GLCKJKAIFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x623E740", Offset = "0x623D940", VA = "0x18623E740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x623F2C0", Offset = "0x623E4C0", VA = "0x18623F2C0")]
	public void IMGNLAGMKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x623EB50", Offset = "0x623DD50", VA = "0x18623EB50")]
	public void DJJOGECEPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x623F7E0", Offset = "0x623E9E0", VA = "0x18623F7E0")]
	public PAAEJIELAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x623ED10", Offset = "0x623DF10", VA = "0x18623ED10")]
	public DEMNBLNIAFC FPMBLPAHIMD(EEAKGMPCBLB JHPIMPOFIFB, bool MAPOPEEFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x623EE40", Offset = "0x623E040", VA = "0x18623EE40")]
	public DDBMPFGBPKL FPMBLPAHIMD(MKACELPBNLB PEGNOKKFPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x623EAE0", Offset = "0x623DCE0", VA = "0x18623EAE0")]
	public bool DINFEHNNGHJ(Hash128 JNIKIHKLGAD, [Out] KJLKNLMDACC KCNKGLKHKHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x623EF80", Offset = "0x623E180", VA = "0x18623EF80")]
	public KJLKNLMDACC FPMBLPAHIMD(OOMHHILGFON PGNOHIOKGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x623EB60", Offset = "0x623DD60", VA = "0x18623EB60")]
	private void DMJKMGLLLHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x623EC90", Offset = "0x623DE90", VA = "0x18623EC90")]
	private bool FEBAPOIBPDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x623F2D0", Offset = "0x623E4D0", VA = "0x18623F2D0")]
	public void LJBOMINMHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x623EB80", Offset = "0x623DD80", VA = "0x18623EB80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x623E690", Offset = "0x623D890", VA = "0x18623E690")]
	public void AIIBPKPBMBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LGGDALMDDJH : OEFCDPPNDDE<BAGMAGOFMCK, BAGMAGOFMCK>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6236890", Offset = "0x6235A90", VA = "0x186236890")]
	public LGGDALMDDJH(int FLLEPAKEGHM, int NHNFDMADPCB, ComputeShader GEBANKACJBN, int KECGCCHOMBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HMFPICPEPLJ : OEFCDPPNDDE<MHLNOOHMCIH, MHLNOOHMCIH>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6233510", Offset = "0x6232710", VA = "0x186233510")]
	public HMFPICPEPLJ(int FLLEPAKEGHM, int NHNFDMADPCB, ComputeShader GEBANKACJBN, int KECGCCHOMBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BMLMDEKENJH : OEFCDPPNDDE<CNDAFBJIEHF, CNDAFBJIEHF>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6230460", Offset = "0x622F660", VA = "0x186230460")]
	public BMLMDEKENJH(int FLLEPAKEGHM, int NHNFDMADPCB, ComputeShader GEBANKACJBN, int KECGCCHOMBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FKALJCPIJAF : OEFCDPPNDDE<LDLHDJFJOMD, PGMDMAKIKHB>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6233050", Offset = "0x6232250", VA = "0x186233050")]
	public FKALJCPIJAF(int FLLEPAKEGHM, int NHNFDMADPCB, ComputeShader GEBANKACJBN, int KECGCCHOMBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LOPELJOEOOD : OEFCDPPNDDE<PFOAGHDBOBE, PFOAGHDBOBE>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6236B00", Offset = "0x6235D00", VA = "0x186236B00")]
	public LOPELJOEOOD(int FLLEPAKEGHM, int NHNFDMADPCB, ComputeShader GEBANKACJBN, int KECGCCHOMBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class JIDPMIPJDMH : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private OIBNJBDNAHI AADBIMCEMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool FFABKOCEGNL;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool LMCAACGHJPA;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6234400", Offset = "0x6233600", VA = "0x186234400")]
	public JIDPMIPJDMH(OIBNJBDNAHI FKHPBOIHFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6234270", Offset = "0x6233470", VA = "0x186234270", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer PJBGKGJIDOO, RenderingData JHNOMFMDOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6234000", Offset = "0x6233200", VA = "0x186234000", Slot = "6")]
	public override void Configure(CommandBuffer PJBGKGJIDOO, RenderTextureDescriptor LKPABMNGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6234040", Offset = "0x6233240", VA = "0x186234040", Slot = "9")]
	public override void Execute(ScriptableRenderContext KAEEGPAIBEC, RenderingData JHNOMFMDOBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class KBAGJMOGAON
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct LOEIEKKIHDA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string IKEFBMMMAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer PJBGKGJIDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext KAEEGPAIBEC;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x62369F0", Offset = "0x6235BF0", VA = "0x1862369F0")]
		public LOEIEKKIHDA(string BMEJMNHKCHL, ScriptableRenderContext PGEAFJPHCGO, [Out] CommandBuffer IDNBCBNABJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6236940", Offset = "0x6235B40", VA = "0x186236940", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6234810", Offset = "0x6233A10", VA = "0x186234810")]
	public static bool OGHPKHKEIJI(RenderingData JHNOMFMDOBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6234440", Offset = "0x6233640", VA = "0x186234440")]
	public static void ENENCDGGGBN(CommandBuffer PJBGKGJIDOO, ScriptableRenderContext KAEEGPAIBEC, ShadowDrawingSettings NIAAPCOCKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x62345E0", Offset = "0x62337E0", VA = "0x1862345E0")]
	public static void OEPKFPOIMHE(CommandBuffer PJBGKGJIDOO, ScriptableRenderContext KAEEGPAIBEC, RenderingData JHNOMFMDOBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class OIBNJBDNAHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class AFPFBGAEIHH
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int LFCNNGLMGHO;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int LGIKBKCNHCM;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static CALAICHOFNM<ALJOHJDLMMB> AIGJMLIFFGI;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static CALAICHOFNM<uint> EGGLIBCILGP;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static EFEBGMFHHBP PPJONJMMIIH;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer GJLHHKBBHPP;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<NDIANEKBPPB> BNMIEIALEPE;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int ICIJCJIFBDP;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int GMIJONLEGGF;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int ENCGHEGGHJB;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int AOJONHBIPLI;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] PDGHLJCMDNG;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] OFINKGKAOJB;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static OHILOCOEJEI[][] JPOFLLJKIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] LOMLBAGBHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int NGIOCAHFJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int JPMEONONODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int IFBECMOOACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int PKHDIMBPCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int DNLPKIEAKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int NLCGCHGEMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int OHLBNBHGPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int ALIPFMHLHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int CENCBDNHGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int DAIIHMCPIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int JMMGFIFPJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int PPAEAFCBGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int DJBAMKNGMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int GCCPOKAIKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int ILHJCMHLBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int KFHBFMIIHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int CEGJAKGILCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int OKNAOFHLIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] FAEFADHLGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private PAAEJIELAKN KAAGNIECNKN;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool GIMPJHBMOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6239C80", Offset = "0x6238E80", VA = "0x186239C80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6239F30", Offset = "0x6239130", VA = "0x186239F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool JLAFLPDEFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x623D8C0", Offset = "0x623CAC0", VA = "0x18623D8C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x623DC30", Offset = "0x623CE30", VA = "0x18623DC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData HCKHOAGNJJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x623DD30", Offset = "0x623CF30", VA = "0x18623DD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x623D910", Offset = "0x623CB10", VA = "0x18623D910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static DGNJELHHEBD GMDKNCBHEBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x623DC90", Offset = "0x623CE90", VA = "0x18623DC90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x623A920", Offset = "0x6239B20", VA = "0x18623A920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static LGGDALMDDJH HNIMHKOEPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x623D3C0", Offset = "0x623C5C0", VA = "0x18623D3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x623CBB0", Offset = "0x623BDB0", VA = "0x18623CBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static HMFPICPEPLJ MICBODFGEFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x623DAB0", Offset = "0x623CCB0", VA = "0x18623DAB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x623DA40", Offset = "0x623CC40", VA = "0x18623DA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static BMLMDEKENJH CMNHFNAOHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x623DCE0", Offset = "0x623CEE0", VA = "0x18623DCE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6239C10", Offset = "0x6238E10", VA = "0x186239C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static FKALJCPIJAF HFONDGJBLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x623D790", Offset = "0x623C990", VA = "0x18623D790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x623D350", Offset = "0x623C550", VA = "0x18623D350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static LOPELJOEOOD EBKDHFAKCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x623CC70", Offset = "0x623BE70", VA = "0x18623CC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6239D40", Offset = "0x6238F40", VA = "0x186239D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material AJHJFFHBGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x623E310", Offset = "0x623D510", VA = "0x18623E310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x623D9D0", Offset = "0x623CBD0", VA = "0x18623D9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material HNOMMKNKNLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x623CC20", Offset = "0x623BE20", VA = "0x18623CC20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6239CD0", Offset = "0x6238ED0", VA = "0x186239CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material BGFEAKMMDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x623DB00", Offset = "0x623CD00", VA = "0x18623DB00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6239DB0", Offset = "0x6238FB0", VA = "0x186239DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material MNOAIOELIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6239BB0", Offset = "0x6238DB0", VA = "0x186239BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x623D720", Offset = "0x623C920", VA = "0x18623D720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool ECDGDCFKJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x623CCC0", Offset = "0x623BEC0", VA = "0x18623CCC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x623E2B0", Offset = "0x623D4B0", VA = "0x18623E2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool GJNFAMFHLJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x623D2F0", Offset = "0x623C4F0", VA = "0x18623D2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string GLCKJKAIFDL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6238CE0", Offset = "0x6237EE0", VA = "0x186238CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x623E3F0", Offset = "0x623D5F0", VA = "0x18623E3F0")]
	internal OIBNJBDNAHI([Optional] MClusterData OFDGLJIBPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x623A990", Offset = "0x6239B90", VA = "0x18623A990")]
	public void GEJAFFIMNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x623A410", Offset = "0x6239610", VA = "0x18623A410")]
	public void ENMAPOINFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6239C00", Offset = "0x6238E00", VA = "0x186239C00")]
	public void BKFDGJADDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6239940", Offset = "0x6238B40", VA = "0x186239940")]
	public bool BIGAIIENMEK(Hash128 LNOOCJJIMOE, [Out] KJLKNLMDACC PGNOHIOKGKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x623A860", Offset = "0x6239A60", VA = "0x18623A860")]
	public KJLKNLMDACC FPMBLPAHIMD(OOMHHILGFON FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x623A4B0", Offset = "0x62396B0", VA = "0x18623A4B0")]
	public DDBMPFGBPKL FPMBLPAHIMD(MKACELPBNLB PEGNOKKFPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x623A6A0", Offset = "0x62398A0", VA = "0x18623A6A0")]
	public DEMNBLNIAFC FPMBLPAHIMD(EEAKGMPCBLB JHPIMPOFIFB, bool MAPOPEEFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x623D980", Offset = "0x623CB80", VA = "0x18623D980")]
	public void MFEEKLGJAPH(FFOMOPMPLDI POKLKCPNLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x623DB50", Offset = "0x623CD50", VA = "0x18623DB50")]
	public static void NHHEMADKING(PGOMAJBMJLL AGBFFDLLICJ, OHILOCOEJEI[] FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x62383A0", Offset = "0x62375A0", VA = "0x1862383A0")]
	private void ACJGNBNGAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6237760", Offset = "0x6236960", VA = "0x186237760")]
	private static void AAKFOFPJOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x623D410", Offset = "0x623C610", VA = "0x18623D410")]
	public void JKBHMJEBDII(CommandBuffer PJBGKGJIDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x62399E0", Offset = "0x6238BE0", VA = "0x1862399E0")]
	public void BILCJOLLGFG([Optional] ScriptableRenderContext? KAEEGPAIBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6239670", Offset = "0x6238870", VA = "0x186239670")]
	public void BIFCEBOAAEK(CommandBuffer PJBGKGJIDOO, ShadowSplitData BFLHLPGGINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6239390", Offset = "0x6238590", VA = "0x186239390")]
	public void BIFCEBOAAEK(CommandBuffer PJBGKGJIDOO, CameraData HJLGOOJIBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x623DD80", Offset = "0x623CF80", VA = "0x18623DD80")]
	public void OPLEAGBBOAM(CommandBuffer PJBGKGJIDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6238C70", Offset = "0x6237E70", VA = "0x186238C70")]
	public void AJFJEGNJBIC(CommandBuffer PJBGKGJIDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6239F90", Offset = "0x6239190", VA = "0x186239F90")]
	public void ECBMKBGAADG(CommandBuffer PJBGKGJIDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x623CD10", Offset = "0x623BF10", VA = "0x18623CD10")]
	public void HOPKCFGNEGK(CommandBuffer PJBGKGJIDOO, PGOMAJBMJLL OKDPGLBCNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x623D7E0", Offset = "0x623C9E0", VA = "0x18623D7E0")]
	public void KPLOEOKNPAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x623BCB0", Offset = "0x623AEB0", VA = "0x18623BCB0")]
	public void HDPILJBHDHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6239E20", Offset = "0x6239020", VA = "0x186239E20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FBMLNKEGGMA
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1DBBDB0", Offset = "0x1DBAFB0", VA = "0x181DBBDB0")]
	public static int BHBMMDLPKLN(int GJIHJJPNBNJ, int DNNLOONMADI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct JBCCDGFGLFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 EHCAOMJIJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 JOLKEELJNDB;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly JBCCDGFGLFO JEJOHGCKNJH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly JBCCDGFGLFO BKMHILKPIAJ;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6233720", Offset = "0x6232920", VA = "0x186233720")]
	public JBCCDGFGLFO(float4x4 BBOGJKIJIEG, float4 DCEGGDPKEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x62335C0", Offset = "0x62327C0", VA = "0x1862335C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct AKLBGHOCHLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 DHMMMGDKPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 IAAOFHLOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 JNJKKJAIGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 IMNFACKKNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 EFECAOPKLGM;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct LFCNOBENNAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 DHMMMGDKPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 IAAOFHLOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 JNJKKJAIGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 IMNFACKKNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 EFECAOPKLGM;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct PGMDMAKIKHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public LFCNOBENNAM FOAPNMPJDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public LFCNOBENNAM MGOMBJNHENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public LFCNOBENNAM DLBNIHKOEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public LFCNOBENNAM EFHCAGNAOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public LFCNOBENNAM DGOHGBPHHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public LFCNOBENNAM DDNMANICALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public LFCNOBENNAM AIKJBHOICHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public LFCNOBENNAM HEBPLEFGMKP;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct LDLHDJFJOMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public AKLBGHOCHLG FOAPNMPJDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public AKLBGHOCHLG MGOMBJNHENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public AKLBGHOCHLG DLBNIHKOEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public AKLBGHOCHLG EFHCAGNAOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public AKLBGHOCHLG DGOHGBPHHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public AKLBGHOCHLG DDNMANICALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public AKLBGHOCHLG AIKJBHOICHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public AKLBGHOCHLG HEBPLEFGMKP;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct MHLNOOHMCIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 DLLDKNALJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint NFDEEDDAFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint OLIJILKFIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float AAKEMFMCHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint OBAOAOPJGFK;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6237500", Offset = "0x6236700", VA = "0x186237500")]
	public MHLNOOHMCIH(MKACELPBNLB PEGNOKKFPLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct ALJOHJDLMMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint OCFOEGMKEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint CCNMPEAEKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint CCLMIDNHCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint OBAOAOPJGFK;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x622FE10", Offset = "0x622F010", VA = "0x18622FE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct CNDAFBJIEHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint OIPDFMEJMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint BELEFFFHCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint MANLMKKLAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint OBAOAOPJGFK;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6230510", Offset = "0x622F710", VA = "0x186230510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BAGMAGOFMCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint CODKAKNBBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint FJCMEJAPEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint JIONEBFPJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint GNODEGDIPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint DKPBBHEGKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint ENOLODOHKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint PAHCADHNEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint OBAOAOPJGFK;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x622FEC0", Offset = "0x622F0C0", VA = "0x18622FEC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct PFOAGHDBOBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 MCKAONAAPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 IAOCAFHHBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 JCPMHIBHMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 OGJEAENOJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 LHCODKKANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 ECOCGMCAEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 BHCKBLMDFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 PBFMMLNGFLG;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x623F9A0", Offset = "0x623EBA0", VA = "0x18623F9A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum PGOMAJBMJLL
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

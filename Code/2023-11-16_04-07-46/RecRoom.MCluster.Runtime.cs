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
public struct JHOHHAFOLBC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] IBDMMAADEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] HOOKMFIFCJP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] GECCECDPCIP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD512D0", Offset = "0xD502D0", VA = "0x180D512D0")]
	public static int PCOMEDOMMNC(JPNJAFMAHML OKHIKFDOHBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E256E0", Offset = "0x5E246E0", VA = "0x185E256E0")]
	public static int JPKHLMCOKCL(JPNJAFMAHML OKHIKFDOHBI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ACADDCJHMIO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int MNFMBGMPNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CCLBPPIKLFP JJKODFABMLK(int KBODLDDGOHA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 GJPBIFBBODC(int KBODLDDGOHA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OHLMKILJLIL FKGJFKLEPBD();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PAAKEFABMDD FBJMOHIEKHG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AMBLDLPMMOP : EPCMINNAEGG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private OHLMKILJLIL PIMEBPKGKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform PBFKOFPFLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<CHBDFKCNBFK> LIFADOAGCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BOCIKCJPKLP HEPGDPMMLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private DDLHFHIBOKP ICIMDBEAGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool JAANNJMMAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ACADDCJHMIO HEIPOMNDPLM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float EFECCJPGBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA8B950", Offset = "0xA8A950", VA = "0x180A8B950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KJGFLFPGDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x854630", Offset = "0x853630", VA = "0x180854630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB61F10", Offset = "0xB60F10", VA = "0x180B61F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OHAAFFOLBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE70", Offset = "0x7BBE70", VA = "0x1807BCE70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB20", Offset = "0x7BBB20", VA = "0x1807BCB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JFINHHLMGII
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E20550", Offset = "0x5E1F550", VA = "0x185E20550", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E20540", Offset = "0x5E1F540", VA = "0x185E20540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FJAHPKGBODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10DAD40", Offset = "0x10D9D40", VA = "0x1810DAD40", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E209B0", Offset = "0x5E1F9B0", VA = "0x185E209B0")]
	public AMBLDLPMMOP(ACADDCJHMIO NMPKCMJCPLB, bool BFBLEFNJFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E20560", Offset = "0x5E1F560", VA = "0x185E20560")]
	private bool KMACMDABKEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F740", Offset = "0x5E1E740", VA = "0x185E1F740", Slot = "4")]
	public bool GPDFOMDKBKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E20370", Offset = "0x5E1F370", VA = "0x185E20370", Slot = "5")]
	public bool HOEJNKLEAPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E20780", Offset = "0x5E1F780", VA = "0x185E20780", Slot = "6")]
	public void MOJJDBCCFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F730", Offset = "0x5E1E730", VA = "0x185E1F730", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DALIGBDFGPN
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IAHEJKMLEDO(CommandBuffer ABAMJLEGHLP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct ECBFDDEKBJG : DALIGBDFGPN
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int GMIBMNELHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier DLMBELCNGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3A4A920", Offset = "0x3A49920", VA = "0x183A4A920")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E24870", Offset = "0x5E23870", VA = "0x185E24870")]
	public ECBFDDEKBJG(int LPCEACMGEAL, RenderTargetIdentifier FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E24820", Offset = "0x5E23820", VA = "0x185E24820", Slot = "4")]
	public void IAHEJKMLEDO(CommandBuffer ABAMJLEGHLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PNFELGHMOEH : DALIGBDFGPN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int GMIBMNELHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] EBMKCJCLFMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDA0", Offset = "0x7FEDA0", VA = "0x1807FFDA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xB38FC0", Offset = "0xB37FC0", VA = "0x180B38FC0")]
	public PNFELGHMOEH(int LPCEACMGEAL, Vector4[] FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FB40", Offset = "0x5E2EB40", VA = "0x185E2FB40", Slot = "4")]
	public void IAHEJKMLEDO(CommandBuffer ABAMJLEGHLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct IGLFDOBOGAG : DALIGBDFGPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int GMIBMNELHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] CHDJBBEJALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDA0", Offset = "0x7FEDA0", VA = "0x1807FFDA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xB38FC0", Offset = "0xB37FC0", VA = "0x180B38FC0")]
	public IGLFDOBOGAG(int LPCEACMGEAL, float[] FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E25680", Offset = "0x5E24680", VA = "0x185E25680", Slot = "4")]
	public void IAHEJKMLEDO(CommandBuffer ABAMJLEGHLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct CECJEEHPHPA : DALIGBDFGPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string GMOLFEBHJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool LODDGFKFEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x180F600", Offset = "0x180E600", VA = "0x18180F600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3A50C20", Offset = "0x3A4FC20", VA = "0x183A50C20")]
	public CECJEEHPHPA(string JNMEJDHMADI, bool NHIMOAGIDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E211C0", Offset = "0x5E201C0", VA = "0x185E211C0", Slot = "4")]
	public void IAHEJKMLEDO(CommandBuffer ABAMJLEGHLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PAAKEFABMDD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 HBHMHFJIPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 ONFMICMLFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAF06A0", Offset = "0xAEF6A0", VA = "0x180AF06A0")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int FEMICJKOEJG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8620A0", Offset = "0x8610A0", VA = "0x1808620A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int INCAHFAPEKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B13F0", Offset = "0x7B03F0", VA = "0x1807B13F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float DNDJJDPPGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB00", Offset = "0x7BDB00", VA = "0x1807BEB00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F570", Offset = "0x5E2E570", VA = "0x185E2F570")]
	public PAAKEFABMDD(Color NGFEKFKHCIJ, int OPHAELLKBLA, int MEGKEAHLAIG, float GLAGANBHNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x53F3FB0", Offset = "0x53F2FB0", VA = "0x1853F3FB0")]
	private static float4 IEEGCCIGMAD(Color NGFEKFKHCIJ)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F4E0", Offset = "0x5E2E4E0", VA = "0x185E2F4E0")]
	private static Hash128 BNINPFPPFGA(PAAKEFABMDD NMPKCMJCPLB)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BOCIKCJPKLP : EPCMINNAEGG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string KCMKFIFBJPA;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string MPPDGFLCMEA;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string PLCJNNFIHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private PAAKEFABMDD GGEDCHJKKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private IHJEPOCDHCM DMOCGBANHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 HHDNGGHJMAO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DDLHFHIBOKP AKLAINCEDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x797A80", Offset = "0x796A80", VA = "0x180797A80")]
		[CompilerGenerated]
		get
		{
			return default(DDLHFHIBOKP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85DD70", Offset = "0x85CD70", VA = "0x18085DD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KJGFLFPGDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x19BAC20", Offset = "0x19B9C20", VA = "0x1819BAC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x19BC180", Offset = "0x19BB180", VA = "0x1819BC180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OHAAFFOLBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x19BBA40", Offset = "0x19BAA40", VA = "0x1819BBA40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x19BA840", Offset = "0x19B9840", VA = "0x1819BA840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FJAHPKGBODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x78B130", Offset = "0x78A130", VA = "0x18078B130", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool JFINHHLMGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5038B70", Offset = "0x5037B70", VA = "0x185038B70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5C66500", Offset = "0x5C65500", VA = "0x185C66500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int KLNGLNIFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5E20F30", Offset = "0x5E1FF30", VA = "0x185E20F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E21180", Offset = "0x5E20180", VA = "0x185E21180")]
	public BOCIKCJPKLP(PAAKEFABMDD OKLPBIOMJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E20DE0", Offset = "0x5E1FDE0", VA = "0x185E20DE0")]
	private bool KMACMDABKEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E20AE0", Offset = "0x5E1FAE0", VA = "0x185E20AE0", Slot = "4")]
	public bool GPDFOMDKBKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5E20EF0", Offset = "0x5E1FEF0", VA = "0x185E20EF0")]
	private static IHJEPOCDHCM LGDDNCCPIAO(PAAKEFABMDD NMPKCMJCPLB)
	{
		return default(IHJEPOCDHCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E20C30", Offset = "0x5E1FC30", VA = "0x185E20C30", Slot = "5")]
	public bool HOEJNKLEAPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E20F80", Offset = "0x5E1FF80", VA = "0x185E20F80", Slot = "6")]
	public void MOJJDBCCFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5E267B0", Offset = "0x5E257B0", VA = "0x185E267B0", Slot = "0")]
		public override bool Equals(object EJEDDDCGMMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E269B0", Offset = "0x5E259B0", VA = "0x185E269B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x802230", Offset = "0x801230", VA = "0x180802230")]
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
		private JOGMIPELCKN opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static NIMADGGCBKN CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5E27080", Offset = "0x5E26080", VA = "0x185E27080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5E270C0", Offset = "0x5E260C0", VA = "0x185E270C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E26A90", Offset = "0x5E25A90", VA = "0x185E26A90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5E26A60", Offset = "0x5E25A60", VA = "0x185E26A60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CHHDBJPKECN, RenderingData CBHJAMEJCKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5E26EF0", Offset = "0x5E25EF0", VA = "0x185E26EF0")]
		public void POCGBNBKDPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xB41130", Offset = "0xB40130", VA = "0x180B41130")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LFCFHDHEKFL<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NAFMFBDKNKG NHLCMKFKEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NAFMFBDKNKG JOJHDHEFLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer DNOEKBBFHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture PGPICMKHAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int OAJJJOGAEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int ELHMBJHHIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string NACMAMLCDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string PDHBEECJMPD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x779C50", Offset = "0x778C50", VA = "0x180779C50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int LONGGBFBPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xB5E2C0", Offset = "0xB5D2C0", VA = "0x180B5E2C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int HAKFCLEGMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x78E470", Offset = "0x78D470", VA = "0x18078E470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3A789D0", Offset = "0x3A779D0", VA = "0x183A789D0")]
	public LFCFHDHEKFL(string JNMEJDHMADI, int BCAHJLGPFBN, [Optional] RenderTextureFormat? DBCIFBLNDEG, bool IBBMAGHPLBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3A770B0", Offset = "0x3A760B0", VA = "0x183A770B0")]
	public void HOEJNKLEAPP(CommandBuffer ABAMJLEGHLP, NativeArray<ValType> FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3A76990", Offset = "0x3A75990", VA = "0x183A76990")]
	public void FGLPGFANHBC(CommandBuffer ABAMJLEGHLP, ComputeShader KOPFMLKPCGI, int GGIJCCJPHKL, int JLBCEHGFLJF = -1, int JKFFCKCDPDN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3A76720", Offset = "0x3A75720", VA = "0x183A76720")]
	public void FGLPGFANHBC(Material DMOCGBANHDO, int JLBCEHGFLJF = -1, int JKFFCKCDPDN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3A75760", Offset = "0x3A74760", VA = "0x183A75760", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NDPACNCENPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGLPGFANHBC(Material OKLPBIOMJKA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EDHMODJBNIH<SrcEntry, DstEntry> : NDPACNCENPJ, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] IBLFODNLKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected NAFMFBDKNKG LNBODCAHGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected NAFMFBDKNKG KBPLGDEACGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> HJBEFKLOIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> JEBOPBHCNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int NKDLMBEMCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int OFLALGBOMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected LFCFHDHEKFL<int> CAHCEOEEHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected LFCFHDHEKFL<SrcEntry> IOCHGECANHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected LFCFHDHEKFL<DstEntry> FGPNMOAJPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader CIMLOIFFHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int ELBEGLLNJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int LHLJHFBHHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int DPLBDKEFDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int PKEOJLKKNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int OBGPEJNKBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int ICHGODAPNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int AKAGDOKBKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int MKFIALHANBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int KDLGOLMJMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int MMLPMFIPOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int JCCCNDEGALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int HGKPIHKPFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string NLEFOJEDIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] DMAOGNJJEOC;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IMIICCEIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x30EFAF0", Offset = "0x30EEAF0", VA = "0x1830EFAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string HDJKPODLFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x30EC0E0", Offset = "0x30EB0E0", VA = "0x1830EC0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x30EFFA0", Offset = "0x30EEFA0", VA = "0x1830EFFA0")]
	public EDHMODJBNIH(string JNMEJDHMADI, int KJJPJCJLIJO, int JIIKBFHLPLM, RenderTextureFormat DBCIFBLNDEG, ComputeShader BHDLNKIEFKH, int CEIEPIGNPKA = 0, int NDOMONELIDG = 0, int LCDEHHADMEP = 0, int JIKMKAMPAPP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x30EF780", Offset = "0x30EE780", VA = "0x1830EF780")]
	public int MGPBMOAECFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x30ECDD0", Offset = "0x30EBDD0", VA = "0x1830ECDD0")]
	protected void EBPNKEFKKII(int NFJIPMHILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x30ECFE0", Offset = "0x30EBFE0", VA = "0x1830ECFE0")]
	public DDLHFHIBOKP GPDFOMDKBKK(SrcEntry FCLEEDACIMH)
	{
		return default(DDLHFHIBOKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x30EDDF0", Offset = "0x30ECDF0", VA = "0x1830EDDF0")]
	public bool HOEJNKLEAPP(DDLHFHIBOKP LJOOGDNJBGF, SrcEntry FCLEEDACIMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x30EF9F0", Offset = "0x30EE9F0", VA = "0x1830EF9F0")]
	public bool MOJJDBCCFOB(DDLHFHIBOKP LJOOGDNJBGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "6")]
	protected virtual void BDGGAIJKLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x30EE4D0", Offset = "0x30ED4D0", VA = "0x1830EE4D0", Slot = "7")]
	public void JAJNLJFHHLE(CommandBuffer ABAMJLEGHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x30EF470", Offset = "0x30EE470", VA = "0x1830EF470", Slot = "8")]
	public void JAJNLJFHHLE(CommandBuffer ABAMJLEGHLP, ComputeShader BHDLNKIEFKH, int CEIEPIGNPKA = -1, int NDOMONELIDG = -1, int LCDEHHADMEP = -1, int JIKMKAMPAPP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x30ECE20", Offset = "0x30EBE20", VA = "0x1830ECE20", Slot = "9")]
	public void FGLPGFANHBC(CommandBuffer ABAMJLEGHLP, ComputeShader BHDLNKIEFKH, int CEIEPIGNPKA = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x30ECF90", Offset = "0x30EBF90", VA = "0x1830ECF90", Slot = "4")]
	public void FGLPGFANHBC(Material DMOCGBANHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x30ECAD0", Offset = "0x30EBAD0", VA = "0x1830ECAD0", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NAFMFBDKNKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong BNCMMFOIDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong HEPHLDMOOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FCBCNMCCKFC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct PFNKCHKPCHE : NAFMFBDKNKG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable KBFOAANENEJ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong BNCMMFOIDDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7FFDA0", Offset = "0x7FEDA0", VA = "0x1807FFDA0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x56C3390", Offset = "0x56C2390", VA = "0x1856C3390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong HEPHLDMOOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1205280", Offset = "0x1204280", VA = "0x181205280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FB00", Offset = "0x5E2EB00", VA = "0x185E2FB00")]
		internal PFNKCHKPCHE(IDisposable OLIHGHCBJFM, ulong KDPHGEBCOEO, ulong JIOKNGIDMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FA80", Offset = "0x5E2EA80", VA = "0x185E2FA80", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct GINLHKNCAGB : NAFMFBDKNKG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture FOPBKILMOKB;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong BNCMMFOIDDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7FFDA0", Offset = "0x7FEDA0", VA = "0x1807FFDA0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x56C3390", Offset = "0x56C2390", VA = "0x1856C3390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong HEPHLDMOOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1205280", Offset = "0x1204280", VA = "0x181205280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E25330", Offset = "0x5E24330", VA = "0x185E25330")]
		public GINLHKNCAGB(RenderTexture ALGCGDPDEAF, ulong POLPMAJACPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E25290", Offset = "0x5E24290", VA = "0x185E25290", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong PGAIAHKEKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E251D0", Offset = "0x5E241D0", VA = "0x185E251D0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E24FC0", Offset = "0x5E23FC0", VA = "0x185E24FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong FPCPEDIGKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E25150", Offset = "0x5E24150", VA = "0x185E25150")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E25190", Offset = "0x5E24190", VA = "0x185E25190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5E24940", Offset = "0x5E23940", VA = "0x185E24940")]
	public static ComputeBuffer BJANKEDJCNP(int AGLAJIDEGHD, int ACEOIBHPCDO, ComputeBufferType CFGJPNBLNDJ, [Out] NAFMFBDKNKG LJOOGDNJBGF, ComputeBufferMode PMFIIBOFEAB = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5E24B20", Offset = "0x5E23B20", VA = "0x185E24B20")]
	public static RenderTexture BJANKEDJCNP(int ODOFMKIIGFF, int MFEOMIOJEPD, int JAGDEKNJOFJ, RenderTextureFormat DBCIFBLNDEG, [Out] NAFMFBDKNKG LJOOGDNJBGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x24D2BD0", Offset = "0x24D1BD0", VA = "0x1824D2BD0")]
	public static NativeArray<T> KOENCFOFMDF<T>(NativeArray<T> KBFOAANENEJ, ulong EHBIPHOJPOK, [Out] NAFMFBDKNKG LJOOGDNJBGF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x24D2B30", Offset = "0x24D1B30", VA = "0x1824D2B30")]
	public static NativeArray<T> BJANKEDJCNP<T>(int EHBIPHOJPOK, Allocator OIPBEAGANJF, [Out] NAFMFBDKNKG LJOOGDNJBGF, NativeArrayOptions DGHDFHCPCLI = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5E25000", Offset = "0x5E24000", VA = "0x185E25000")]
	public static void EPEJEEPODAB(NAFMFBDKNKG KBFOAANENEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E24EC0", Offset = "0x5E23EC0", VA = "0x185E24EC0")]
	public static uint DMHEFNAOOOB(RenderTextureFormat DBCIFBLNDEG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MPFBDCBOKDG : EDHMODJBNIH<NMFMKFAMPLC, NMFMKFAMPLC>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct MLMKANNJMCN : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> ACDOLGANNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> AIKDADGGDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> PIBAGOBGJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> NIODNKMMPOC;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5D0AB70", Offset = "0x5D09B70", VA = "0x185D0AB70")]
		public MLMKANNJMCN(NativeArray<int> AEJJCCBFCDP, NativeArray<float> CIHAGELPDDA, NativeArray<float4x4> ELKEFHBKIGK, NativeArray<float4> LLCCMCKHKCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E271D0", Offset = "0x5E261D0", VA = "0x185E271D0", Slot = "4")]
		public void Execute(int NFJIPMHILEL, TransformAccess PIMEBPKGKBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct BIBGFBGGCDC : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> ACDOLGANNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> HFBCKIHEHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> KCKINBCPADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<NMFMKFAMPLC> LLJIEGHIEFJ;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5D0AB70", Offset = "0x5D09B70", VA = "0x185D0AB70")]
		public BIBGFBGGCDC(NativeArray<int> AEJJCCBFCDP, NativeArray<float4x4> FNBIPGAMEHJ, NativeArray<float4> KNJJKJDCALK, NativeArray<NMFMKFAMPLC> HPCDKOJJCBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5E20A70", Offset = "0x5E1FA70", VA = "0x185E20A70", Slot = "4")]
		public void Execute(int NFJIPMHILEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte MCAIKNDDFOH = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray LIFEGOCFDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> AGMDKCOFBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> NKNBDGHPBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> FPCGDLHOJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> BEBEHFHLJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> DDPFGENBBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NAFMFBDKNKG DNHKEMOLGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NAFMFBDKNKG MLFMKOCKMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NAFMFBDKNKG FJAGNGEMLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NAFMFBDKNKG FMFBACAIGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NAFMFBDKNKG HDCKNNAIGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform PGCKFILMCIA;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E279E0", Offset = "0x5E269E0", VA = "0x185E279E0")]
	public MPFBDCBOKDG(int KJJPJCJLIJO, int JIIKBFHLPLM, ComputeShader BHDLNKIEFKH, int CEIEPIGNPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E274F0", Offset = "0x5E264F0", VA = "0x185E274F0", Slot = "6")]
	protected override void BDGGAIJKLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E27870", Offset = "0x5E26870", VA = "0x185E27870")]
	private void EHKBLEHDJKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E27390", Offset = "0x5E26390", VA = "0x185E27390")]
	public bool APBIJKJNINH(DDLHFHIBOKP LJOOGDNJBGF, Transform PIMEBPKGKBD, float PFGNBFKMPEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E27790", Offset = "0x5E26790", VA = "0x185E27790")]
	public void EFLDJIALJCF(DDLHFHIBOKP LJOOGDNJBGF, float PFGNBFKMPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5E27930", Offset = "0x5E26930", VA = "0x185E27930")]
	public void FAKEDBAFNKO(DDLHFHIBOKP LJOOGDNJBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E276F0", Offset = "0x5E266F0", VA = "0x185E276F0", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CCLBPPIKLFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPDLEIFKJLD FAMMDIJKGAD();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GOCFALMBONK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 HBHMHFJIPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int LMIBGJEGPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int GCEFKOJKPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> PGFEEKJAPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> EBJBCGNMBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> HLGBMEDNNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> KLJINCECHLF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> FHHBFJIGAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> MFKDFDBCCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int PBOFDOODINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int JNFNNAJOOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int ACLNJJNMOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool OPNJGOEBKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JAJNLJFHHLE();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PFECDOHKBJF : GOCFALMBONK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private CCLBPPIKLFP CNBIFEFJCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private KPDLEIFKJLD KBKBNNLDMCD;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 HBHMHFJIPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAF06A0", Offset = "0xAEF6A0", VA = "0x180AF06A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1B3D060", Offset = "0x1B3C060", VA = "0x181B3D060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool EJKNLADNENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x774F00", Offset = "0x773F00", VA = "0x180774F00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int LMIBGJEGPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7B13F0", Offset = "0x7B03F0", VA = "0x1807B13F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F30", Offset = "0x7AFF30", VA = "0x1807B0F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int GCEFKOJKPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7786E0", Offset = "0x7776E0", VA = "0x1807786E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x777F90", Offset = "0x776F90", VA = "0x180777F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int FLHBBPNAKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFE0", Offset = "0x8DEFE0", VA = "0x1808DFFE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> PGFEEKJAPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F6A0", Offset = "0x5E2E6A0", VA = "0x185E2F6A0", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> EBJBCGNMBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F9A0", Offset = "0x5E2E9A0", VA = "0x185E2F9A0", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> HLGBMEDNNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FA00", Offset = "0x5E2EA00", VA = "0x185E2FA00", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> KLJINCECHLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F750", Offset = "0x5E2E750", VA = "0x185E2F750", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> FHHBFJIGAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F7C0", Offset = "0x5E2E7C0", VA = "0x185E2F7C0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> MFKDFDBCCGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F9D0", Offset = "0x5E2E9D0", VA = "0x185E2F9D0", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OPNJGOEBKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB30", Offset = "0x7BDB30", VA = "0x1807BEB30", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB10", Offset = "0x7BDB10", VA = "0x1807BEB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int PBOFDOODINP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F990", Offset = "0x5E2E990", VA = "0x185E2F990", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int JNFNNAJOOFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F710", Offset = "0x5E2E710", VA = "0x185E2F710", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int ACLNJJNMOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F730", Offset = "0x5E2E730", VA = "0x185E2F730", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FA30", Offset = "0x5E2EA30", VA = "0x185E2FA30")]
	public PFECDOHKBJF(Hash128 PBHLHLBGOBP, CCLBPPIKLFP CNBIFEFJCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F880", Offset = "0x5E2E880", VA = "0x185E2F880", Slot = "16")]
	public void JAJNLJFHHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F7F0", Offset = "0x5E2E7F0", VA = "0x185E2F7F0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DDLHFHIBOKP : IEquatable<DDLHFHIBOKP>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly DDLHFHIBOKP GHGNOAMLPEA;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int KLNGLNIFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x82BE50", Offset = "0x82AE50", VA = "0x18082BE50")]
	public DDLHFHIBOKP(int NFJIPMHILEL = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E232D0", Offset = "0x5E222D0", VA = "0x185E232D0", Slot = "4")]
	public bool Equals(DDLHFHIBOKP EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E23320", Offset = "0x5E22320", VA = "0x185E23320", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E233F0", Offset = "0x5E223F0", VA = "0x185E233F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CHBDFKCNBFK : EPCMINNAEGG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool JAANNJMMAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private GOCFALMBONK PKKPMLHCCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<DDLHFHIBOKP> BIKPLGBIAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<DDLHFHIBOKP> IHMPKJLDPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<DDLHFHIBOKP> EABEDIAAFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> MACPNEHKCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int AIAOEMFDGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int CMHFLEIFIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int IMGIEJJPJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int CBPFOHJAGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int MJPKFFIAIHO;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int KLNGLNIFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E22400", Offset = "0x5E21400", VA = "0x185E22400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E22DF0", Offset = "0x5E21DF0", VA = "0x185E22DF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool KJGFLFPGDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C4710", Offset = "0x7C3710", VA = "0x1807C4710")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8F2680", Offset = "0x8F1680", VA = "0x1808F2680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool OHAAFFOLBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA58AB0", Offset = "0xA57AB0", VA = "0x180A58AB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA58AC0", Offset = "0xA57AC0", VA = "0x180A58AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool FJAHPKGBODK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x78B130", Offset = "0x78A130", VA = "0x18078B130", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool JFINHHLMGII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x15E7EA0", Offset = "0x15E6EA0", VA = "0x1815E7EA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x15E7E40", Offset = "0x15E6E40", VA = "0x1815E7E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float EFECCJPGBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1991660", Offset = "0x1990660", VA = "0x181991660")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1991650", Offset = "0x1990650", VA = "0x181991650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E22E30", Offset = "0x5E21E30", VA = "0x185E22E30")]
	public CHBDFKCNBFK(GOCFALMBONK KBKBNNLDMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E21200", Offset = "0x5E20200", VA = "0x185E21200")]
	private void COGGNOPDPLD(GOCFALMBONK KBKBNNLDMCD, int AIAOEMFDGOE, int MOKJDBHNJNG, int NFJIPMHILEL, int IIKFNBADHFE, FMPNLKDNHOB FCLEEDACIMH, float PJKECHJELLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E22B20", Offset = "0x5E21B20", VA = "0x185E22B20")]
	private void PADJGLELAKP(GOCFALMBONK KBKBNNLDMCD, int EIAGLLPICME, int NFJIPMHILEL, uint3 IMPDKKMFOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E22160", Offset = "0x5E21160", VA = "0x185E22160")]
	private bool KMACMDABKEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E21740", Offset = "0x5E20740", VA = "0x185E21740", Slot = "4")]
	public bool GPDFOMDKBKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E220E0", Offset = "0x5E210E0", VA = "0x185E220E0", Slot = "5")]
	public bool HOEJNKLEAPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E224B0", Offset = "0x5E214B0", VA = "0x185E224B0", Slot = "6")]
	public void MOJJDBCCFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E216E0", Offset = "0x5E206E0", VA = "0x185E216E0")]
	public void LOGKAIIDGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E216E0", Offset = "0x5E206E0", VA = "0x185E216E0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EPCMINNAEGG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool FJAHPKGBODK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool JFINHHLMGII
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPDFOMDKBKK();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HOEJNKLEAPP();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MOJJDBCCFOB();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EBHIJHKDNAG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float DHPBCAKNDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, CHBDFKCNBFK> PCHLIONMDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, BOCIKCJPKLP> BHHBLLBIKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<EPCMINNAEGG> PBFBOGNPHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<EPCMINNAEGG> DIIKMGDNBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<EPCMINNAEGG> NEFJDECHJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int ENJGKGCFMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int MGIBFFKNHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float FPFMGJLGHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool IFOIDFHCINI;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool AMLFBEEPLCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xB43720", Offset = "0xB42720", VA = "0x180B43720")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xB61CE0", Offset = "0xB60CE0", VA = "0x180B61CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool BHLOKKCOBJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E23B00", Offset = "0x5E22B00", VA = "0x185E23B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string HDJKPODLFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E235A0", Offset = "0x5E225A0", VA = "0x185E235A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E23B50", Offset = "0x5E22B50", VA = "0x185E23B50")]
	public void IICICGDJNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E240E0", Offset = "0x5E230E0", VA = "0x185E240E0")]
	public void NBAPOALDBJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E24690", Offset = "0x5E23690", VA = "0x185E24690")]
	public EBHIJHKDNAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E240F0", Offset = "0x5E230F0", VA = "0x185E240F0")]
	public AMBLDLPMMOP NOIKFHNFAKL(ACADDCJHMIO PBJLMCDEAOF, bool BFBLEFNJFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E24510", Offset = "0x5E23510", VA = "0x185E24510")]
	public BOCIKCJPKLP NOIKFHNFAKL(PAAKEFABMDD DMOCGBANHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E23530", Offset = "0x5E22530", VA = "0x185E23530")]
	public bool CBJGMHDPIFN(Hash128 LPCEACMGEAL, [Out] CHBDFKCNBFK AAMIJEPOMEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E24220", Offset = "0x5E23220", VA = "0x185E24220")]
	public CHBDFKCNBFK NOIKFHNFAKL(GOCFALMBONK KBKBNNLDMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E240C0", Offset = "0x5E230C0", VA = "0x185E240C0")]
	private void LLGLCJBIMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E24030", Offset = "0x5E23030", VA = "0x185E24030")]
	private bool LHPNKCDJHAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E23B60", Offset = "0x5E22B60", VA = "0x185E23B60")]
	public void JAJNLJFHHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E23940", Offset = "0x5E22940", VA = "0x185E23940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E23A50", Offset = "0x5E22A50", VA = "0x185E23A50")]
	public void GKHBGHBBEKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ENINPEHNPIC : EDHMODJBNIH<DAAJGADGPHE, DAAJGADGPHE>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E24890", Offset = "0x5E23890", VA = "0x185E24890")]
	public ENINPEHNPIC(int KJJPJCJLIJO, int JIIKBFHLPLM, ComputeShader BHDLNKIEFKH, int CEIEPIGNPKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GOANHKBAEGH : EDHMODJBNIH<IHJEPOCDHCM, IHJEPOCDHCM>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E25360", Offset = "0x5E24360", VA = "0x185E25360")]
	public GOANHKBAEGH(int KJJPJCJLIJO, int JIIKBFHLPLM, ComputeShader BHDLNKIEFKH, int CEIEPIGNPKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MHFGHHAEFDL : EDHMODJBNIH<IGIMAOMDBFE, IGIMAOMDBFE>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E27120", Offset = "0x5E26120", VA = "0x185E27120")]
	public MHFGHHAEFDL(int KJJPJCJLIJO, int JIIKBFHLPLM, ComputeShader BHDLNKIEFKH, int CEIEPIGNPKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class AKNAEMLGAOI : EDHMODJBNIH<PKAOJPLPAHK, OAMJMKJKBDD>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F680", Offset = "0x5E1E680", VA = "0x185E1F680")]
	public AKNAEMLGAOI(int KJJPJCJLIJO, int JIIKBFHLPLM, ComputeShader BHDLNKIEFKH, int CEIEPIGNPKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LFDHDHPNKED : EDHMODJBNIH<NLBGCHAFJDD, NLBGCHAFJDD>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E26700", Offset = "0x5E25700", VA = "0x185E26700")]
	public LFDHDHPNKED(int KJJPJCJLIJO, int JIIKBFHLPLM, ComputeShader BHDLNKIEFKH, int CEIEPIGNPKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class JOGMIPELCKN : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NIMADGGCBKN MLOMECHANLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool NHIMOAGIDEG;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool HKBMIKPNNAP;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E261A0", Offset = "0x5E251A0", VA = "0x185E261A0")]
	public JOGMIPELCKN(NIMADGGCBKN AKNIALAFLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E26010", Offset = "0x5E25010", VA = "0x185E26010", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer ABAMJLEGHLP, RenderingData CBHJAMEJCKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E25DA0", Offset = "0x5E24DA0", VA = "0x185E25DA0", Slot = "6")]
	public override void Configure(CommandBuffer ABAMJLEGHLP, RenderTextureDescriptor ADCKCJMOEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E25DE0", Offset = "0x5E24DE0", VA = "0x185E25DE0", Slot = "9")]
	public override void Execute(ScriptableRenderContext ACJODAOHIHK, RenderingData CBHJAMEJCKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class KPELDFANFPG
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct GOGKPEFOINI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string JNMEJDHMADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer ABAMJLEGHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext ACJODAOHIHK;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E254C0", Offset = "0x5E244C0", VA = "0x185E254C0")]
		public GOGKPEFOINI(string NPNICBDEINH, ScriptableRenderContext CGHOJFMCKPI, [Out] CommandBuffer IIILHCDBEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E25410", Offset = "0x5E24410", VA = "0x185E25410", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E261E0", Offset = "0x5E251E0", VA = "0x185E261E0")]
	public static bool BDMIANKMHHA(RenderingData CBHJAMEJCKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E26330", Offset = "0x5E25330", VA = "0x185E26330")]
	public static void KBMCAOFBEGP(CommandBuffer ABAMJLEGHLP, ScriptableRenderContext ACJODAOHIHK, ShadowDrawingSettings KDIHMLHIEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E264D0", Offset = "0x5E254D0", VA = "0x185E264D0")]
	public static void PJFGPEDOKLF(CommandBuffer ABAMJLEGHLP, ScriptableRenderContext ACJODAOHIHK, RenderingData CBHJAMEJCKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NIMADGGCBKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class FJDIFAFONCI
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int COIABBKIAMJ;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int AADMHGKDHJB;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static LFCFHDHEKFL<DICNPKEKADB> CJLDFIODIGC;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static LFCFHDHEKFL<uint> LKAMIHMBHFA;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static NAFMFBDKNKG JPKLKEOMJEC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer DACAJPOACFJ;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<NDPACNCENPJ> KFDLLBKPLEG;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int ILMPHECBFNM;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int DDCJNILNOHE;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int GOLBELPPFAD;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int HJOLEONDAAF;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] MICAFDIGEBC;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] CLKJKDDGMHJ;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static DALIGBDFGPN[][] NGNABEBCLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] HCJPNBCGJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int OOCFEDILMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int CNDAHFMGLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int HLPBHPLKHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int LLJLJPBALKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int KOOOOFEBBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int DNMFKJBAOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int EFBOADHFDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int BBLMHKMFCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int LOLGJAHGEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int JCHNIFGOBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int FLIILEDAMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int KAAMHJLMHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int LPKODMGFBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int NFAEFNNNFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int HPDAENBAOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int IEPLHMKLBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int FKLLMNCDCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int HKHEMKHHMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] OIKIOABEEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private EBHIJHKDNAG MOCDHLEFPEH;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool KFOFAAMLPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E27DC0", Offset = "0x5E26DC0", VA = "0x185E27DC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E1C0", Offset = "0x5E2D1C0", VA = "0x185E2E1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool DJBKAIBHIDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E29320", Offset = "0x5E28320", VA = "0x185E29320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E9E0", Offset = "0x5E2D9E0", VA = "0x185E2E9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData ALHHFFKAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D7F0", Offset = "0x5E2C7F0", VA = "0x185E2D7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CB90", Offset = "0x5E2BB90", VA = "0x185E2CB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static MPFBDCBOKDG DICHEOALMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E27F70", Offset = "0x5E26F70", VA = "0x185E27F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D060", Offset = "0x5E2C060", VA = "0x185E2D060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static ENINPEHNPIC AKCLKLOCHON
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EBF0", Offset = "0x5E2DBF0", VA = "0x185E2EBF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CB20", Offset = "0x5E2BB20", VA = "0x185E2CB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static GOANHKBAEGH GOLDGHHALGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EA40", Offset = "0x5E2DA40", VA = "0x185E2EA40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E410", Offset = "0x5E2D410", VA = "0x185E2E410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static MHFGHHAEFDL GPCMHKCFLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E28B20", Offset = "0x5E27B20", VA = "0x185E28B20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EA90", Offset = "0x5E2DA90", VA = "0x185E2EA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static AKNAEMLGAOI NLMKIMAOLEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E980", Offset = "0x5E2D980", VA = "0x185E2E980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E390", Offset = "0x5E2D390", VA = "0x185E2E390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static LFDHDHPNKED GMOAOLOBDNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D730", Offset = "0x5E2C730", VA = "0x185E2D730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E140", Offset = "0x5E2D140", VA = "0x185E2E140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material ILFGNAMFHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E2E0", Offset = "0x5E2D2E0", VA = "0x185E2E2E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CC00", Offset = "0x5E2BC00", VA = "0x185E2CC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material CLJPHNPKNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CC80", Offset = "0x5E2BC80", VA = "0x185E2CC80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E480", Offset = "0x5E2D480", VA = "0x185E2E480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material LILOPMAJKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E220", Offset = "0x5E2D220", VA = "0x185E2E220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D6B0", Offset = "0x5E2C6B0", VA = "0x185E2D6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material MEGAGGCJJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D790", Offset = "0x5E2C790", VA = "0x185E2D790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D630", Offset = "0x5E2C630", VA = "0x185E2D630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool KANMGJKDFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5E27CC0", Offset = "0x5E26CC0", VA = "0x185E27CC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E280", Offset = "0x5E2D280", VA = "0x185E2E280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool BHLOKKCOBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CCE0", Offset = "0x5E2BCE0", VA = "0x185E2CCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string HDJKPODLFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5E28460", Offset = "0x5E27460", VA = "0x185E28460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E2ECE0", Offset = "0x5E2DCE0", VA = "0x185E2ECE0")]
	internal NIMADGGCBKN([Optional] MClusterData LFAAFBNONFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E29930", Offset = "0x5E28930", VA = "0x185E29930")]
	public void EMCBFDNIFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5E27D20", Offset = "0x5E26D20", VA = "0x185E27D20")]
	public void BAKNMOOPBHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EBE0", Offset = "0x5E2DBE0", VA = "0x185E2EBE0")]
	public void PPAEJOOFKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5E28B70", Offset = "0x5E27B70", VA = "0x185E28B70")]
	public bool DLINCMLGKJB(Hash128 PBHLHLBGOBP, [Out] CHBDFKCNBFK KBKBNNLDMCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E6C0", Offset = "0x5E2D6C0", VA = "0x185E2E6C0")]
	public CHBDFKCNBFK NOIKFHNFAKL(GOCFALMBONK FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E780", Offset = "0x5E2D780", VA = "0x185E2E780")]
	public BOCIKCJPKLP NOIKFHNFAKL(PAAKEFABMDD DMOCGBANHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E500", Offset = "0x5E2D500", VA = "0x185E2E500")]
	public AMBLDLPMMOP NOIKFHNFAKL(ACADDCJHMIO PBJLMCDEAOF, bool BFBLEFNJFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E340", Offset = "0x5E2D340", VA = "0x185E2E340")]
	public void MOJJDBCCFOB(EPCMINNAEGG KDFFFMLCHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5E27E10", Offset = "0x5E26E10", VA = "0x185E27E10")]
	public static void CBKFNFKNEII(JPNJAFMAHML OKHIKFDOHBI, DALIGBDFGPN[] FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D840", Offset = "0x5E2C840", VA = "0x185E2D840")]
	private void LJFJNKOHFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BE60", Offset = "0x5E2AE60", VA = "0x185E2BE60")]
	private static void FBCPCLEOHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CD40", Offset = "0x5E2BD40", VA = "0x185E2CD40")]
	public void HBKCEAGEKHA(CommandBuffer ABAMJLEGHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BC90", Offset = "0x5E2AC90", VA = "0x185E2BC90")]
	public void EPIFNPKKNCG([Optional] ScriptableRenderContext? ACJODAOHIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E29650", Offset = "0x5E28650", VA = "0x185E29650")]
	public void EEEFOILBEJI(CommandBuffer ABAMJLEGHLP, ShadowSplitData DBHNOAIHEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5E29370", Offset = "0x5E28370", VA = "0x185E29370")]
	public void EEEFOILBEJI(CommandBuffer ABAMJLEGHLP, CameraData PLNAJHAGOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D0D0", Offset = "0x5E2C0D0", VA = "0x185E2D0D0")]
	public void HFMENBEJGKN(CommandBuffer ABAMJLEGHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5E27F00", Offset = "0x5E26F00", VA = "0x185E27F00")]
	public void CCNLANIPJBN(CommandBuffer ABAMJLEGHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5E27FC0", Offset = "0x5E26FC0", VA = "0x185E27FC0")]
	public void DGOKALEAJJD(CommandBuffer ABAMJLEGHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E28C10", Offset = "0x5E27C10", VA = "0x185E28C10")]
	public void DOFOCCFNGHO(CommandBuffer ABAMJLEGHLP, JPNJAFMAHML KJLKAIKKMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EB00", Offset = "0x5E2DB00", VA = "0x185E2EB00")]
	public void POCGBNBKDPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2ACE0", Offset = "0x5E29CE0", VA = "0x185E2ACE0")]
	public void EPEJEEPODAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5E29210", Offset = "0x5E28210", VA = "0x185E29210", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BABDPEJADOE
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1C43F50", Offset = "0x1C42F50", VA = "0x181C43F50")]
	public static int KMLFIBHFMNC(int LNBKADIBNBM, int LPDGHMPNLHL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NMFMKFAMPLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 BPHLNPPAHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 GCOEJCFLBDE;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly NMFMKFAMPLC MOHIGIDCFLP;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly NMFMKFAMPLC GHGNOAMLPEA;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F4B0", Offset = "0x5E2E4B0", VA = "0x185E2F4B0")]
	public NMFMKFAMPLC(float4x4 DLECBCGBBKK, float4 NFDNFGPGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F340", Offset = "0x5E2E340", VA = "0x185E2F340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct FMPNLKDNHOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 LPGLCEHEHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 IPOPAPIAACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 IMPPGGNEKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 JLCFKGNEDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 IGBAILFEFPJ;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct MDHEMMNLNLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 LPGLCEHEHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 IPOPAPIAACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 IMPPGGNEKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 JLCFKGNEDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 IGBAILFEFPJ;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct OAMJMKJKBDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public MDHEMMNLNLP KOMKPAINOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public MDHEMMNLNLP DIDBCPIMCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public MDHEMMNLNLP DAPOLBJAFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public MDHEMMNLNLP GOIAEPHBKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public MDHEMMNLNLP LOOECMGFFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public MDHEMMNLNLP CAFPDIJLKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public MDHEMMNLNLP IJIFBHNJDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public MDHEMMNLNLP FAJHFPMEFAN;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct PKAOJPLPAHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public FMPNLKDNHOB KOMKPAINOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public FMPNLKDNHOB DIDBCPIMCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public FMPNLKDNHOB DAPOLBJAFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public FMPNLKDNHOB GOIAEPHBKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public FMPNLKDNHOB LOOECMGFFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public FMPNLKDNHOB CAFPDIJLKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public FMPNLKDNHOB IJIFBHNJDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public FMPNLKDNHOB FAJHFPMEFAN;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct IHJEPOCDHCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 DFDPPFBJPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint OPHAELLKBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint MEGKEAHLAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float GLAGANBHNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint OJIPMLLHOKH;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5E256B0", Offset = "0x5E246B0", VA = "0x185E256B0")]
	public IHJEPOCDHCM(PAAKEFABMDD DMOCGBANHDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct DICNPKEKADB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint JOILGGOCDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint KLIOPCAJAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint IIKFNBADHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint OJIPMLLHOKH;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5E23480", Offset = "0x5E22480", VA = "0x185E23480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct IGIMAOMDBFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint MOKJDBHNJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint LHHEHAMEAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint CMHFLEIFIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint OJIPMLLHOKH;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5E255D0", Offset = "0x5E245D0", VA = "0x185E255D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct DAAJGADGPHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint PFDKANEIIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint AMKLDLHFKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint MKDBCEKMDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint FFDLNLLFOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint OEKPHECADPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint CDJLNDOKFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint JBOCFBJHCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint OJIPMLLHOKH;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5E22FA0", Offset = "0x5E21FA0", VA = "0x185E22FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct NLBGCHAFJDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 GFCFPFPADKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 IIMNGDPBGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 INEOKNKNIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 BNEBLDDOIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 DHIGCCKKCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 MKGIHGEMKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 AIMAPLEPENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 KGLFPJOGALJ;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EF40", Offset = "0x5E2DF40", VA = "0x185E2EF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum JPNJAFMAHML
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

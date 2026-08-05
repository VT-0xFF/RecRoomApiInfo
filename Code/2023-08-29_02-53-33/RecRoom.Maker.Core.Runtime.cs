using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F55E10", Offset = "0x6F55210", VA = "0x186F55E10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0F70", VA = "0x1808D1B70")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0020", Offset = "0x6DF420")]
public class BINAFEJABHI<TData> : PGMHKCOHDMJ<INFNJGILAMD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IMAFPFJJMOF JHLCNAGBMAD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24CE790", Offset = "0x24CDB90", VA = "0x1824CE790")]
	public BINAFEJABHI(Vector3 BENHEKCBBGH, bool KEDHFKEIBIM, INFNJGILAMD<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x24CE720", Offset = "0x24CDB20", VA = "0x1824CE720", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0090", Offset = "0x6DF490")]
public class BENLNJOBICJ<TSpawnType, TSpawnInfo> : HAHIFJKDHDA<HFOOLGALCLE<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0100", Offset = "0x6DF500")]
	private readonly JNMLECDBGNM<TSpawnInfo> KLEPOOAJLPJ;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24C8630", Offset = "0x24C7A30", VA = "0x1824C8630")]
	public BENLNJOBICJ(TSpawnInfo GNMBDAPHMDI, Vector3 OMFIFBMFGMG, Quaternion PFHPGOOLCFP, float DBJGDGDHOMC, HFOOLGALCLE<TSpawnType, TSpawnInfo> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24C8510", Offset = "0x24C7910", VA = "0x1824C8510", Slot = "4")]
	public override Task<TSpawnType> GFPNCFCIMGJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct ODBDKNAIFBA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public IEnumerable<TData> BALKFBMBGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public bool MPMJHHNPHOE;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3E84300", Offset = "0x3E83700", VA = "0x183E84300")]
	public ODBDKNAIFBA(IEnumerable<TData> DMNDFDDCHDC, bool FIEOFBMDPHB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MNKCGCDACAH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEFNIEMECKA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E01A0", Offset = "0x6DF5A0")] in FEAEGOBKBAI<TData?> JNDDJJNIMCP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JKGFKIGIBND(in MIONPAIJEIO MDAKPFCGHMI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JKGFKIGIBND(in DENGGMNMEHH MDAKPFCGHMI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JBMIDDANHKD();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JEJLAKNHMJL<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TNode HBFFGOHAABE;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2D125F0", Offset = "0x2D119F0", VA = "0x182D125F0")]
	public JEJLAKNHMJL(TNode HBFFGOHAABE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EPIPFCLCHCM<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TNode HHABKCLMPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public LLOIIELJCNI OBDFBDIJBKN;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F003B0", Offset = "0x1EFF7B0", VA = "0x181F003B0")]
	public EPIPFCLCHCM(TNode HHABKCLMPLJ, LLOIIELJCNI OBDFBDIJBKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0210", Offset = "0x6DF610")]
public class JMECIFIEMNA<TData> : PGMHKCOHDMJ<OMCBNBDABGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0280", Offset = "0x6DF680")]
	private readonly ODBDKNAIFBA<TData> HHEHFNGHKHA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x205FC10", Offset = "0x205F010", VA = "0x18205FC10")]
	public JMECIFIEMNA(List<TData> CJPIHDACEJM, OMCBNBDABGE<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9150", Offset = "0x1EF8550", VA = "0x181EF9150", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LGAPFDGALHD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFPNCFCIMGJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E02E0", Offset = "0x6DF6E0")] in GEMLGGLBKBI<TData?> MMKIFDPKPBF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ICONNHPLLKA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> BALKFBMBGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public PCJLEJOLJBG KDNJICPHKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public KFDDOGLDHLG BECJDGLKCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float BIANDFIBNPF;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xEF1280", Offset = "0xEF0680", VA = "0x180EF1280")]
	public ICONNHPLLKA(IEnumerable<TData> DKJFPAONLAF, PCJLEJOLJBG FJGGIOBFKGO, KFDDOGLDHLG JMOIMJGFABM, float BIANDFIBNPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal static class CCNGNJAHGDH
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F552F0", Offset = "0x6F546F0", VA = "0x186F552F0")]
	public static void KCDMADIJBNE(IEnumerable OHPPBPBLLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x515CFA0", Offset = "0x515C3A0", VA = "0x18515CFA0")]
	public static void KCDMADIJBNE<T>(T[] KGHLGBOMEFA) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JPEPPCIBIBI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFPNCFCIMGJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0350", Offset = "0x6DF750")] in OLIEPGDACEG<T?> NPLBAPFBJDE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GJDNOJBPNBM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public TData[] BALKFBMBGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public PCJLEJOLJBG[] KDNJICPHKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public KFDDOGLDHLG[] BECJDGLKCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float[] BIANDFIBNPF;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2741CD0", Offset = "0x27410D0", VA = "0x182741CD0")]
	public GJDNOJBPNBM(TData[] DKJFPAONLAF, PCJLEJOLJBG[] FJGGIOBFKGO, KFDDOGLDHLG[] JMOIMJGFABM, float[] BIANDFIBNPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AFEACEPNMDE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FBGHDJKKOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KOOGENPICJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KEDIEKAKEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ACDGPGNLGFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EDLIEHFDBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Guid BIINNCDBOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int NANJAGEOPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Vector3 OMFIFBMFGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly Quaternion PFHPGOOLCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float IPHDKMMKPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly bool KEDHFKEIBIM;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F55580", Offset = "0x6F54980", VA = "0x186F55580")]
	public EDLIEHFDBBF(Guid BIINNCDBOHG, int NANJAGEOPJI, Vector3 OMFIFBMFGMG, Quaternion PFHPGOOLCFP, float IPHDKMMKPIL, bool KEDHFKEIBIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MEFEDKCLGFM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEFNIEMECKA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0400", Offset = "0x6DF800")] in HJPEFNDHNPP<TData?> JNDDJJNIMCP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JKGFKIGIBND(in GPOHDOHAOPG MDAKPFCGHMI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JBMIDDANHKD();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct MIONPAIJEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly float JLFGAMMLIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Vector3 LOJEGOGCDJF;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4CFD110", Offset = "0x4CFC510", VA = "0x184CFD110")]
	public MIONPAIJEIO(float JLFGAMMLIDN, Vector3 LOJEGOGCDJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DENGGMNMEHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Vector3 MNNHCJFDGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly float JLFGAMMLIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 LOJEGOGCDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool KEDHFKEIBIM;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F55550", Offset = "0x6F54950", VA = "0x186F55550")]
	public DENGGMNMEHH(Vector3 MNNHCJFDGJE, float JLFGAMMLIDN, Vector3 LOJEGOGCDJF, bool KEDHFKEIBIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PCNLMNMFCNC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AFKHJBFIGIL> GFPNCFCIMGJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0470", Offset = "0x6DF870")] GMMAHJBBOGF<TData> IJLMDKABMDC);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E04D0", Offset = "0x6DF8D0")]
public class MAIHHMOGFIA<TData> : PGMHKCOHDMJ<LFJHGHFIKHK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly IHCICPCDIIL CEIAODOACOM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2DCAD10", Offset = "0x2DCA110", VA = "0x182DCAD10")]
	public MAIHHMOGFIA(Vector3 PBEGANGJIAO, LFJHGHFIKHK<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x24CE720", Offset = "0x24CDB20", VA = "0x1824CE720", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NACPEGGDJFD<TData> where TData : KMIMCKFNCNA
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFPNCFCIMGJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0540", Offset = "0x6DF940")] in AOMMNOBDCGI<TData> PLGAIFNAAJM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFPNCFCIMGJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E05B0", Offset = "0x6DF9B0")] in DDNODIIBAFL<TData> PLGAIFNAAJM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class LGAAPBJNGAI
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum IHNILOACCED
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2424B70", Offset = "0x2423F70", VA = "0x182424B70")]
	public static void OMPGLKCPGHE<T>(T PFLHMFKPPJD, IHNILOACCED JLNNFEOBAMK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2424AE0", Offset = "0x2423EE0", VA = "0x182424AE0")]
	public static void OMPGLKCPGHE<T>(T PFLHMFKPPJD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x24249C0", Offset = "0x2423DC0", VA = "0x1824249C0")]
	public static void KBBBHNPGLKC<T>(T PFLHMFKPPJD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2424890", Offset = "0x2423C90", VA = "0x182424890")]
	public static T IKHPLCCBENN<T>(IHNILOACCED JLNNFEOBAMK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2424950", Offset = "0x2423D50", VA = "0x182424950")]
	public static T IKHPLCCBENN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2424A70", Offset = "0x2423E70", VA = "0x182424A70")]
	public static bool NKFEOHPFFBA<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0620", Offset = "0x6DFA20")]
public class PDHAOFMEKDB<TData> : PGMHKCOHDMJ<OMCBNBDABGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1934980", Offset = "0x1933D80", VA = "0x181934980")]
	public PDHAOFMEKDB(OMCBNBDABGE<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2E80", Offset = "0x2CE2280", VA = "0x182CE2E80", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BLKJBCGPIPD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 OCPINBDMADB, Vector3 KDLMOBCGODE, float AMDMMLBNHAH, out T OGOKCKNFPIA, out Vector3 BGJBKNHMNMF, out Collider CDOCGOMODOK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 OCPINBDMADB, Vector3 KDLMOBCGODE, float HEONKAPIPHN, float AMDMMLBNHAH, T[] IBCJIFJFPOK, out Vector3 LCLFLAHENCP, out Collider FOEOHGDHECO);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 OCPINBDMADB, float HEONKAPIPHN, Vector3 EKKKAFJJHAL, T[] IBCJIFJFPOK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class KAFHMMBLEHH<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	protected TReceiver CBPNIOPEEID;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2102ED0", Offset = "0x21022D0", VA = "0x182102ED0")]
	public KAFHMMBLEHH(TReceiver CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute GFPNCFCIMGJ();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BBOLGKGDPMA
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AFKHJBFIGIL> GFPNCFCIMGJ(OGNDNMFOLNO CGPFDIALNFI);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0690", Offset = "0x6DFA90")]
public class OPMIBLHMEFH<TData> : PGMHKCOHDMJ<KJAHHILHBHE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0700", Offset = "0x6DFB00")]
	private readonly HKEDKBAACJO<TData> HGOKHLJDLMB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5278650", Offset = "0x5277A50", VA = "0x185278650")]
	public OPMIBLHMEFH(IEnumerable<TData> DKJFPAONLAF, PCJLEJOLJBG FJGGIOBFKGO, KFDDOGLDHLG JMOIMJGFABM, float BIANDFIBNPF, bool MPMJHHNPHOE, KJAHHILHBHE<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9150", Offset = "0x1EF8550", VA = "0x181EF9150", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0760", Offset = "0x6DFB60")]
public class ENBBGIFPDHB<TData> : PGMHKCOHDMJ<INFNJGILAMD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1934980", Offset = "0x1933D80", VA = "0x181934980")]
	public ENBBGIFPDHB(INFNJGILAMD<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1EF8EA0", Offset = "0x1EF82A0", VA = "0x181EF8EA0", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E07D0", Offset = "0x6DFBD0")]
public class BJPKOOGEGNN<TData> : PGMHKCOHDMJ<NKIGMIDKJPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0840", Offset = "0x6DFC40")]
	private readonly JHMLKDNPPMC<TData> CEIAODOACOM;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x24D0ED0", Offset = "0x24D02D0", VA = "0x1824D0ED0")]
	public BJPKOOGEGNN(IEnumerable<TData> DKJFPAONLAF, Vector3 PBEGANGJIAO, bool MPMJHHNPHOE, NKIGMIDKJPF<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9150", Offset = "0x1EF8550", VA = "0x181EF9150", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JHMLKDNPPMC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly IEnumerable<TData> DKJFPAONLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly Vector3 PBEGANGJIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly bool MPMJHHNPHOE;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D234D0", Offset = "0x2D228D0", VA = "0x182D234D0")]
	public JHMLKDNPPMC(IEnumerable<TData> DKJFPAONLAF, Vector3 PBEGANGJIAO, bool MPMJHHNPHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NKIGMIDKJPF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFPNCFCIMGJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E08A0", Offset = "0x6DFCA0")] in JHMLKDNPPMC<TData?> CEIAODOACOM);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0910", Offset = "0x6DFD10")]
public class KFONAOGFIGK<TData> : PGMHKCOHDMJ<OMCBNBDABGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly bool MPMJHHNPHOE;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x220CF20", Offset = "0x220C320", VA = "0x18220CF20")]
	public KFONAOGFIGK(bool MPMJHHNPHOE, OMCBNBDABGE<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x220CEB0", Offset = "0x220C2B0", VA = "0x18220CEB0", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface MFINDEGDPIH<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEFNIEMECKA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0980", Offset = "0x6DFD80")] in JEJLAKNHMJL<TNode?> JNDDJJNIMCP);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JBMIDDANHKD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E09F0", Offset = "0x6DFDF0")] in EPIPFCLCHCM<TNode?> DAFLBDINBBM);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OHOHMLJCAOD();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0A60", Offset = "0x6DFE60")]
public class OCELABDKLAD<TNode> : PGMHKCOHDMJ<MFINDEGDPIH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1934980", Offset = "0x1933D80", VA = "0x181934980")]
	public OCELABDKLAD(MFINDEGDPIH<TNode> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x20403B0", Offset = "0x203F7B0", VA = "0x1820403B0", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MDKBNLDEOPL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFPNCFCIMGJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0AD0", Offset = "0x6DFED0")] in GJDNOJBPNBM<TData?> HGOKHLJDLMB);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class EIAFDCJIFFA
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct BCPGNKPAPKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public bool LCPADJGNILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public EPBOEGFMAOO MLELCNDKKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public EPBOEGFMAOO BINLAEMOPHI;
	}

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static BCPGNKPAPKJ ABCPOIMCIFH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CancellationToken OAJBGMIJHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6F555C0", Offset = "0x6F549C0", VA = "0x186F555C0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static EPBOEGFMAOO MLELCNDKKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6F55860", Offset = "0x6F54C60", VA = "0x186F55860")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6F55940", Offset = "0x6F54D40", VA = "0x186F55940")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F55620", Offset = "0x6F54A20", VA = "0x186F55620")]
	[GHLDKGGJCDP(BOCOADOGGBA.Room, FGNCLGKDFDK.None)]
	private static void ENBCKKNHJOJ(EPBOEGFMAOO KBNNDGPPJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F556D0", Offset = "0x6F54AD0", VA = "0x186F556D0")]
	public static void FJKIFKDAPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F55810", Offset = "0x6F54C10", VA = "0x186F55810")]
	private static EPBOEGFMAOO GJEGPKDJIKJ(EPBOEGFMAOO OPNNECJOBEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IEGNMDAILFM<TData> : KNFNACPODPK, EHLIGMMFMAK<TData>, OMCBNBDABGE<TData>, PNPKCIPEJDE<TData>, AFEACEPNMDE, BLKJBCGPIPD<TData>, JJMLHCJBBOE, DCLJEECJBHN
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GEMLGGLBKBI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly IEnumerable<TData> DKJFPAONLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly Quaternion PBEGANGJIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly Vector3? LOJEGOGCDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool CCEKKDJEGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool MPMJHHNPHOE;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x21250E0", Offset = "0x21244E0", VA = "0x1821250E0")]
	public GEMLGGLBKBI(IEnumerable<TData> DKJFPAONLAF, Quaternion PBEGANGJIAO, Vector3? LOJEGOGCDJF, bool CCEKKDJEGDB, bool MPMJHHNPHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0B60", Offset = "0x6DFF60")]
public class GHDLNMCGHAO<T> : PGMHKCOHDMJ<JPEPPCIBIBI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0BD0", Offset = "0x6DFFD0")]
	private readonly OLIEPGDACEG<T> NPLBAPFBJDE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x212C920", Offset = "0x212BD20", VA = "0x18212C920")]
	public GHDLNMCGHAO(T GDNOLIODDHJ, bool GJAKLGELMFK, JPEPPCIBIBI<T> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9150", Offset = "0x1EF8550", VA = "0x181EF9150", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct HKEDKBAACJO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public IEnumerable<TData> BALKFBMBGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public PCJLEJOLJBG KDNJICPHKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public KFDDOGLDHLG BECJDGLKCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float BIANDFIBNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool MPMJHHNPHOE;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA4370", Offset = "0x2DA3770", VA = "0x182DA4370")]
	public HKEDKBAACJO(IEnumerable<TData> DKJFPAONLAF, PCJLEJOLJBG FJGGIOBFKGO, KFDDOGLDHLG JMOIMJGFABM, float BIANDFIBNPF, bool MPMJHHNPHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0C30", Offset = "0x6E0030")]
public class CDLJEHFFPKC<TData> : PGMHKCOHDMJ<MNKCGCDACAH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly DENGGMNMEHH FHDKMOJMDAC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB050", Offset = "0x2CDA450", VA = "0x182CDB050")]
	public CDLJEHFFPKC(Vector3 MNNHCJFDGJE, float JLFGAMMLIDN, Vector3 LOJEGOGCDJF, bool KHHDIMMFNDP, MNKCGCDACAH<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAFE0", Offset = "0x2CDA3E0", VA = "0x182CDAFE0", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct DHAGIAHNBME<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T GDNOLIODDHJ;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2046020", Offset = "0x2045420", VA = "0x182046020")]
	public DHAGIAHNBME(T JONECHLDOEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0CA0", Offset = "0x6E00A0")]
public class LMFAFMOFPKC<TData> : PGMHKCOHDMJ<OMCBNBDABGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0D10", Offset = "0x6E0110")]
	private readonly ODBDKNAIFBA<TData> HHEHFNGHKHA;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF930", Offset = "0x3FEED30", VA = "0x183FEF930")]
	public LMFAFMOFPKC(List<TData> CJPIHDACEJM, OMCBNBDABGE<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF870", Offset = "0x3FEEC70", VA = "0x183FEF870", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct NGPKPFJKKHB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly IEnumerable<TData> BALKFBMBGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool BGDCBLDAINI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27CA590", Offset = "0x27C9990", VA = "0x1827CA590")]
	public NGPKPFJKKHB(IEnumerable<TData> DKJFPAONLAF, bool MPMJHHNPHOE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface DCLJEECJBHN
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LNCHJMFHBFC DGEJJOIMCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0DB0", Offset = "0x6E01B0")]
public class OMEKENLOKPI<TData> : PGMHKCOHDMJ<OMCBNBDABGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0E20", Offset = "0x6E0220")]
	private readonly ODBDKNAIFBA<TData> HHEHFNGHKHA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3373160", Offset = "0x3372560", VA = "0x183373160")]
	public OMEKENLOKPI(List<TData> CJPIHDACEJM, bool MPMJHHNPHOE, OMCBNBDABGE<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2218B90", Offset = "0x2217F90", VA = "0x182218B90", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct OGNDNMFOLNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool BGDCBLDAINI;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x17DD240", Offset = "0x17DC640", VA = "0x1817DD240")]
	public OGNDNMFOLNO(bool MPMJHHNPHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface EHLIGMMFMAK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T ICNDEPGFBMI, [Optional] ACHEKCMGEOE? DILPMIKBIBB, bool MNLOKKJKOAE = true);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int ECOAGJBCGAI, IEnumerable<T> GHPBLCEJEKI, bool MNLOKKJKOAE = true);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int ECOAGJBCGAI, IEnumerable<T> GHPBLCEJEKI, ACHEKCMGEOE DILPMIKBIBB, bool MNLOKKJKOAE = true);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct FEAEGOBKBAI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly IEnumerable<TData> DKJFPAONLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool MPMJHHNPHOE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x19479F0", Offset = "0x1946DF0", VA = "0x1819479F0")]
	public FEAEGOBKBAI(IEnumerable<TData> DKJFPAONLAF, bool MPMJHHNPHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0E80", Offset = "0x6E0280")]
public class KKILBHGJHEH<TData> : HAHIFJKDHDA<OCCGLCCOHBO<TData>, AFKHJBFIGIL> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0EF0", Offset = "0x6E02F0")]
	private readonly NGPKPFJKKHB<TData> GILJNKPCIGI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x22189A0", Offset = "0x2217DA0", VA = "0x1822189A0")]
	public KKILBHGJHEH(IEnumerable<TData> DKJFPAONLAF, bool MPMJHHNPHOE, OCCGLCCOHBO<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2218880", Offset = "0x2217C80", VA = "0x182218880", Slot = "4")]
	public override Task<AFKHJBFIGIL> GFPNCFCIMGJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0F50", Offset = "0x6E0350")]
public class IPEMLNCNKJG<TData> : PGMHKCOHDMJ<INFNJGILAMD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0FC0", Offset = "0x6E03C0")]
	private readonly HAJFOFLABNN<TData> JHLCNAGBMAD;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23544F0", Offset = "0x23538F0", VA = "0x1823544F0")]
	public IPEMLNCNKJG(TData GDNOLIODDHJ, bool MPMJHHNPHOE, INFNJGILAMD<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9150", Offset = "0x1EF8550", VA = "0x181EF9150", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct HAJFOFLABNN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly TData GDNOLIODDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool MPMJHHNPHOE;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x358B230", Offset = "0x358A630", VA = "0x18358B230")]
	public HAJFOFLABNN(TData GDNOLIODDHJ, bool MPMJHHNPHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct JOLJMIDKFFJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly IEnumerable<TData> DKJFPAONLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool MPMJHHNPHOE;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x32769D0", Offset = "0x3275DD0", VA = "0x1832769D0")]
	public JOLJMIDKFFJ(IEnumerable<TData> DKJFPAONLAF, bool MPMJHHNPHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1020", Offset = "0x6E0420")]
public class DBDLNHEMPCJ<T> : PGMHKCOHDMJ<EADJLEPBONF<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1934980", Offset = "0x1933D80", VA = "0x181934980")]
	public DBDLNHEMPCJ(EADJLEPBONF<T> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1F5DB00", Offset = "0x1F5CF00", VA = "0x181F5DB00", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1090", Offset = "0x6E0490")]
public class DPNJMEDNBNI<TData> : PGMHKCOHDMJ<MNKCGCDACAH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly MIONPAIJEIO FHDKMOJMDAC;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2E2FBD0", Offset = "0x2E2EFD0", VA = "0x182E2FBD0")]
	public DPNJMEDNBNI(float JLFGAMMLIDN, Vector3 LOJEGOGCDJF, MNKCGCDACAH<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x24CE720", Offset = "0x24CDB20", VA = "0x1824CE720", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1100", Offset = "0x6E0500")]
public class HMPFKIFBLFJ<TData> : PGMHKCOHDMJ<MEFEDKCLGFM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1934980", Offset = "0x1933D80", VA = "0x181934980")]
	public HMPFKIFBLFJ(MEFEDKCLGFM<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x20403B0", Offset = "0x203F7B0", VA = "0x1820403B0", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1170", Offset = "0x6E0570")]
public class BEODJCOALKB<TData> : PGMHKCOHDMJ<MEFEDKCLGFM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E11E0", Offset = "0x6E05E0")]
	private readonly HJPEFNDHNPP<TData> MMKIFDPKPBF;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x24C8950", Offset = "0x24C7D50", VA = "0x1824C8950")]
	public BEODJCOALKB(IEnumerable<TData> DKJFPAONLAF, bool MPMJHHNPHOE, MEFEDKCLGFM<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9150", Offset = "0x1EF8550", VA = "0x181EF9150", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1240", Offset = "0x6E0640")]
public class JEDDHFPAPJK<TNode> : PGMHKCOHDMJ<MFINDEGDPIH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E12B0", Offset = "0x6E06B0")]
	private readonly JEJLAKNHMJL<TNode> JNDDJJNIMCP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2D11940", Offset = "0x2D10D40", VA = "0x182D11940")]
	public JEDDHFPAPJK(TNode NMJHIEKOGKI, MFINDEGDPIH<TNode> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9150", Offset = "0x1EF8550", VA = "0x181EF9150", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1310", Offset = "0x6E0710")]
public class CLIKBIJJLPI<TData> : PGMHKCOHDMJ<LFJHGHFIKHK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1380", Offset = "0x6E0780")]
	private readonly JOLJMIDKFFJ<TData> CEIAODOACOM;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x328CA00", Offset = "0x328BE00", VA = "0x18328CA00")]
	public CLIKBIJJLPI(IEnumerable<TData> DKJFPAONLAF, bool MPMJHHNPHOE, LFJHGHFIKHK<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9150", Offset = "0x1EF8550", VA = "0x181EF9150", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct HJPEFNDHNPP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly IEnumerable<TData> DKJFPAONLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly bool MPMJHHNPHOE;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3300", Offset = "0x2DA2700", VA = "0x182DA3300")]
	public HJPEFNDHNPP(IEnumerable<TData> DKJFPAONLAF, bool MPMJHHNPHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E13E0", Offset = "0x6E07E0")]
public class MBIJJDPBGIA<TNode> : PGMHKCOHDMJ<MFINDEGDPIH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1450", Offset = "0x6E0850")]
	private readonly EPIPFCLCHCM<TNode> DAFLBDINBBM;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD970", Offset = "0x2DCCD70", VA = "0x182DCD970")]
	public MBIJJDPBGIA(TNode HHABKCLMPLJ, LLOIIELJCNI OBDFBDIJBKN, MFINDEGDPIH<TNode> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD8B0", Offset = "0x2DCCCB0", VA = "0x182DCD8B0", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface OCCGLCCOHBO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AFKHJBFIGIL> BGODJKPGPEG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E14B0", Offset = "0x6E08B0")] in NGPKPFJKKHB<TData> HHEHFNGHKHA, CancellationToken DNKHCCGNODC);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1520", Offset = "0x6E0920")]
public class NBLEBCMGGGL : HAHIFJKDHDA<BBOLGKGDPMA, AFKHJBFIGIL>
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class FAGCOBOOKIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder<AFKHJBFIGIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NBLEBCMGGGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private AFKHJBFIGIL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<AFKHJBFIGIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public FAGCOBOOKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F55A00", Offset = "0x6F54E00", VA = "0x186F55A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OGNDNMFOLNO PKNGDHDHIIC;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F55DB0", Offset = "0x6F551B0", VA = "0x186F55DB0")]
	public NBLEBCMGGGL(bool MPMJHHNPHOE, BBOLGKGDPMA CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6F55C60", Offset = "0x6F55060", VA = "0x186F55C60", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FAGCOBOOKIM))]
	public override Task<AFKHJBFIGIL> GFPNCFCIMGJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface OMCBNBDABGE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJOIJELLEIP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E15F0", Offset = "0x6E09F0")] in ODBDKNAIFBA<TData> HHEHFNGHKHA);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFMJLODMAFI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1660", Offset = "0x6E0A60")] in ODBDKNAIFBA<TData> HHEHFNGHKHA);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEGMHEGJOAK(in bool GJFKKIAKEEG);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CMLMFAOCFNA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E16D0", Offset = "0x6E0AD0")] in ODBDKNAIFBA<TData> HHEHFNGHKHA);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KAMAILMBOKH();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NKPNBCKEMBC(in TData FAEFIDOHNBA);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct GPOHDOHAOPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly Quaternion PBEGANGJIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly Vector3? LOJEGOGCDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool CCEKKDJEGDB;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x523E370", Offset = "0x523D770", VA = "0x18523E370")]
	public GPOHDOHAOPG(Quaternion PBEGANGJIAO, Vector3? LOJEGOGCDJF, bool CCEKKDJEGDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface INFNJGILAMD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEFNIEMECKA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1740", Offset = "0x6E0B40")] in HAJFOFLABNN<TData?> JNDDJJNIMCP);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JKGFKIGIBND(in IMAFPFJJMOF MDAKPFCGHMI);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JKGFKIGIBND(in EDLIEHFDBBF MDAKPFCGHMI);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JBMIDDANHKD();
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct IHCICPCDIIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly Vector3 PBEGANGJIAO;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public IHCICPCDIIL(Vector3 PBEGANGJIAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E17B0", Offset = "0x6E0BB0")]
public class ENDFJPKHACA<T> : PGMHKCOHDMJ<EADJLEPBONF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1820", Offset = "0x6E0C20")]
	private readonly DHAGIAHNBME<T> JGOFEFJMPLB;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9210", Offset = "0x1EF8610", VA = "0x181EF9210")]
	public ENDFJPKHACA(T GDNOLIODDHJ, EADJLEPBONF<T> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9150", Offset = "0x1EF8550", VA = "0x181EF9150", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1880", Offset = "0x6E0C80")]
public class KCCGGIILJGE<TData> : PGMHKCOHDMJ<LGAPFDGALHD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E18F0", Offset = "0x6E0CF0")]
	private readonly GEMLGGLBKBI<TData> MMKIFDPKPBF;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2109F20", Offset = "0x2109320", VA = "0x182109F20")]
	public KCCGGIILJGE(IEnumerable<TData> DKJFPAONLAF, Quaternion PBEGANGJIAO, Vector3? LOJEGOGCDJF, bool CCEKKDJEGDB, bool MPMJHHNPHOE, LGAPFDGALHD<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9150", Offset = "0x1EF8550", VA = "0x181EF9150", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1950", Offset = "0x6E0D50")]
public class PBKFAPFHCBB<TData> : PGMHKCOHDMJ<MNKCGCDACAH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1934980", Offset = "0x1933D80", VA = "0x181934980")]
	public PBKFAPFHCBB(MNKCGCDACAH<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1EF8EA0", Offset = "0x1EF82A0", VA = "0x181EF8EA0", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E19C0", Offset = "0x6E0DC0")]
public class NHDEPPLJCBI<TData> : PGMHKCOHDMJ<MEFEDKCLGFM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly GPOHDOHAOPG MMKIFDPKPBF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x27CB190", Offset = "0x27CA590", VA = "0x1827CB190")]
	public NHDEPPLJCBI(Quaternion PBEGANGJIAO, Vector3? LOJEGOGCDJF, bool CCEKKDJEGDB, MEFEDKCLGFM<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x24CE720", Offset = "0x24CDB20", VA = "0x1824CE720", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1A30", Offset = "0x6E0E30")]
public class PHEJCCIAOCF<TData> : PGMHKCOHDMJ<MDKBNLDEOPL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1AA0", Offset = "0x6E0EA0")]
	private readonly GJDNOJBPNBM<TData> HGOKHLJDLMB;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2D05F10", Offset = "0x2D05310", VA = "0x182D05F10")]
	public PHEJCCIAOCF(TData[] DKJFPAONLAF, PCJLEJOLJBG[] FJGGIOBFKGO, KFDDOGLDHLG[] JMOIMJGFABM, float[] BIANDFIBNPF, MDKBNLDEOPL<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2A9ED70", Offset = "0x2A9E170", VA = "0x182A9ED70", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1B00", Offset = "0x6E0F00")]
public class KLBLNDMBJNB<TData> : PGMHKCOHDMJ<NACPEGGDJFD<TData>> where TData : notnull, KMIMCKFNCNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1B70", Offset = "0x6E0F70")]
	private readonly DDNODIIBAFL<TData> PLGAIFNAAJM;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2218C50", Offset = "0x2218050", VA = "0x182218C50")]
	public KLBLNDMBJNB(List<TData> DKJFPAONLAF, List<bool> HPIDPAJMAFA, NACPEGGDJFD<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2218B90", Offset = "0x2217F90", VA = "0x182218B90", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1BD0", Offset = "0x6E0FD0")]
public class LFIDDHMNOOI<TData> : PGMHKCOHDMJ<LFJHGHFIKHK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1934980", Offset = "0x1933D80", VA = "0x181934980")]
	public LFIDDHMNOOI(LFJHGHFIKHK<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x20403B0", Offset = "0x203F7B0", VA = "0x1820403B0", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct IMAFPFJJMOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly Vector3 BENHEKCBBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool KEDHFKEIBIM;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F55C40", Offset = "0x6F55040", VA = "0x186F55C40")]
	public IMAFPFJJMOF(Vector3 BENHEKCBBGH, bool KEDHFKEIBIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct OLIEPGDACEG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly T GDNOLIODDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly bool LELAHPJGHJC;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3372D20", Offset = "0x3372120", VA = "0x183372D20")]
	public OLIEPGDACEG(T JONECHLDOEI, bool GJAKLGELMFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface KNMBOJPDOLI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JKGFKIGIBND([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1C40", Offset = "0x6E1040")] in ICONNHPLLKA<TData?> HGOKHLJDLMB);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBMIDDANHKD();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1CB0", Offset = "0x6E10B0")]
public class NMIJNMJIICH<TData> : PGMHKCOHDMJ<KNMBOJPDOLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1D20", Offset = "0x6E1120")]
	private readonly ICONNHPLLKA<TData> HGOKHLJDLMB;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EE30", Offset = "0x2A9E230", VA = "0x182A9EE30")]
	public NMIJNMJIICH(IEnumerable<TData> DKJFPAONLAF, PCJLEJOLJBG FJGGIOBFKGO, KFDDOGLDHLG JMOIMJGFABM, float BIANDFIBNPF, KNMBOJPDOLI<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A9ED70", Offset = "0x2A9E170", VA = "0x182A9ED70", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface HFOOLGALCLE<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> ACHOMKHCDHA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1D80", Offset = "0x6E1180")] in JNMLECDBGNM<TSpawnInfo> MOOKLMBKBIB, CancellationToken DNKHCCGNODC);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct JNMLECDBGNM<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public TSpawnInfo DPKHNDKHIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Vector3 OMFIFBMFGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Quaternion PFHPGOOLCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float DBJGDGDHOMC;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9E0240", Offset = "0x9DF640", VA = "0x1809E0240")]
	public JNMLECDBGNM(TSpawnInfo DPKHNDKHIPH, Vector3 OMFIFBMFGMG, Quaternion PFHPGOOLCFP, float DBJGDGDHOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface KMIMCKFNCNA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DBFNCBEPICN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1DF0", Offset = "0x6E11F0")]
public class HABMELCGEEP<TData> : PGMHKCOHDMJ<INFNJGILAMD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly EDLIEHFDBBF JHLCNAGBMAD;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3586F00", Offset = "0x3586300", VA = "0x183586F00")]
	public HABMELCGEEP(Guid BIINNCDBOHG, int NANJAGEOPJI, Vector3 OMFIFBMFGMG, Quaternion PFHPGOOLCFP, float IPHDKMMKPIL, bool KEDHFKEIBIM, INFNJGILAMD<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2CDAFE0", Offset = "0x2CDA3E0", VA = "0x182CDAFE0", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct GMMAHJBBOGF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public TData CINFBNBPKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public IReadOnlyList<TData> KLPACPNOLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool BGDCBLDAINI;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x274AE30", Offset = "0x274A230", VA = "0x18274AE30")]
	public GMMAHJBBOGF(TData BJNKGNMLMOI, IReadOnlyList<TData> NMCJLBKNLIF, bool MPMJHHNPHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JHDNGAMIFNG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(ALLHEOKOEID LKKIAIIPIIK);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData GDNOLIODDHJ, Collider CDOCGOMODOK, ALLHEOKOEID LKKIAIIPIIK, [Optional] ACHEKCMGEOE? OJLJEFOKLLK);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget(out TData GDNOLIODDHJ);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1E60", Offset = "0x6E1260")]
public class LEIEAICOBBJ<TData> : PGMHKCOHDMJ<NACPEGGDJFD<TData>> where TData : notnull, KMIMCKFNCNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1ED0", Offset = "0x6E12D0")]
	private readonly AOMMNOBDCGI<TData> PLGAIFNAAJM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x203F7E0", Offset = "0x203EBE0", VA = "0x18203F7E0")]
	public LEIEAICOBBJ(List<TData> DKJFPAONLAF, bool FJCENOEFEBH, NACPEGGDJFD<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9150", Offset = "0x1EF8550", VA = "0x181EF9150", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1F30", Offset = "0x6E1330")]
public class NGHEJENGDLN<TData> : PGMHKCOHDMJ<OMCBNBDABGE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly TData FAEFIDOHNBA;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x27CA000", Offset = "0x27C9400", VA = "0x1827CA000")]
	public NGHEJENGDLN(TData FAEFIDOHNBA, OMCBNBDABGE<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x27C9EA0", Offset = "0x27C92A0", VA = "0x1827C9EA0", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1FA0", Offset = "0x6E13A0")]
public class HNGPHAMOIIB<TData> : HAHIFJKDHDA<PCNLMNMFCNC<TData>, AFKHJBFIGIL> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class FNIOCJEDGBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<AFKHJBFIGIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public HNGPHAMOIIB<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private AFKHJBFIGIL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<AFKHJBFIGIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public FNIOCJEDGBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x373EE80", Offset = "0x373E280", VA = "0x18373EE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2010", Offset = "0x6E1410")]
	private readonly GMMAHJBBOGF<TData> MJOCOHLLPOC;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1790", Offset = "0x2DB0B90", VA = "0x182DB1790")]
	public HNGPHAMOIIB(TData BJNKGNMLMOI, IReadOnlyList<TData> NMCJLBKNLIF, bool MPMJHHNPHOE, PCNLMNMFCNC<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1620", Offset = "0x2DB0A20", VA = "0x182DB1620", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HNGPHAMOIIB<>.FNIOCJEDGBF))]
	public override Task<AFKHJBFIGIL> GFPNCFCIMGJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E20E0", Offset = "0x6E14E0")]
public abstract class PGMHKCOHDMJ<TReceiver> : KAFHMMBLEHH<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1934980", Offset = "0x1933D80", VA = "0x181934980")]
	public PGMHKCOHDMJ(TReceiver CBPNIOPEEID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface KNFNACPODPK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Bounds APKBODMKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Transform ELLGIIKJGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Bounds CBALEJNCKNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform HIKJBHFCGKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Vector3 PAKBDNAHPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool GANDIPAMGDN = true, int MGCCKFCEJMH = 0);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool MAGFPELOLAD, object GAOLOMEJCOK);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct AOMMNOBDCGI<TData> where TData : notnull, KMIMCKFNCNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public IEnumerable<TData> BALKFBMBGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool FJCENOEFEBH;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x256DF70", Offset = "0x256D370", VA = "0x18256DF70")]
	public AOMMNOBDCGI(IEnumerable<TData> DMNDFDDCHDC, bool LIJILFJJNEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct DDNODIIBAFL<TData> where TData : notnull, KMIMCKFNCNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public List<TData> BALKFBMBGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public List<bool> HPIDPAJMAFA;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2B0CD30", Offset = "0x2B0C130", VA = "0x182B0CD30")]
	public DDNODIIBAFL(List<TData> DMNDFDDCHDC, List<bool> JIOJBEMJHGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface PNPKCIPEJDE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool PDCEBPAAPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int EFCJJAMJEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	IEnumerable<TData> HDEKKILHFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData ADJFAODNAMI);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData ADJFAODNAMI);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface JJMLHCJBBOE
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface LFJHGHFIKHK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEFNIEMECKA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2150", Offset = "0x6E1550")] in JOLJMIDKFFJ<TData?> ADPEICNPNDC);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JKGFKIGIBND(in IHCICPCDIIL MDAKPFCGHMI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JBMIDDANHKD();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E21C0", Offset = "0x6E15C0")]
public class MJPHKLPJOKO<TData> : PGMHKCOHDMJ<KNMBOJPDOLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1934980", Offset = "0x1933D80", VA = "0x181934980")]
	public MJPHKLPJOKO(KNMBOJPDOLI<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x274BE20", Offset = "0x274B220", VA = "0x18274BE20", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface CKHNKPEFJGB : KMIMCKFNCNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2230", Offset = "0x6E1630")]
public abstract class HAHIFJKDHDA<TReceiver, TFromTask> : KAFHMMBLEHH<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1934980", Offset = "0x1933D80", VA = "0x181934980")]
	public HAHIFJKDHDA(TReceiver CBPNIOPEEID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface EADJLEPBONF<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEFNIEMECKA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E22A0", Offset = "0x6E16A0")] in DHAGIAHNBME<T?> JGOFEFJMPLB);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JBMIDDANHKD();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2310", Offset = "0x6E1710")]
public class JEJAHAMOOJI<TData> : PGMHKCOHDMJ<MNKCGCDACAH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2380", Offset = "0x6E1780")]
	private readonly FEAEGOBKBAI<TData> FHDKMOJMDAC;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2D124B0", Offset = "0x2D118B0", VA = "0x182D124B0")]
	public JEJAHAMOOJI(IEnumerable<TData> DKJFPAONLAF, bool MPMJHHNPHOE, MNKCGCDACAH<TData> CBPNIOPEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9150", Offset = "0x1EF8550", VA = "0x181EF9150", Slot = "4")]
	public override bool GFPNCFCIMGJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface KJAHHILHBHE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFPNCFCIMGJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E23E0", Offset = "0x6E17E0")] in HKEDKBAACJO<TData?> HGOKHLJDLMB);
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

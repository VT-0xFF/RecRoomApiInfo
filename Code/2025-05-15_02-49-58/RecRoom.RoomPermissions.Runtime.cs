using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x849CFE0", Offset = "0x849B5E0", VA = "0x18849CFE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MKGDLGMGGGP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
namespace _AssemblyRegistry.RecRoom_RoomPermissions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x849F840", Offset = "0x849DE40", VA = "0x18849F840", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LFEKMPIFLEG<TPermission>(TPermission NOKCCPNANAA);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void HCKMKEONKBP(AIPAHMNCJKP EKEPPODJHCN);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KDOPLEBADFF
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IFBLPKMHGJM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AOEALMFNCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NCMNBBNLIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EBJJHKOJNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MNEIFGPPHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool AAMFBMOBHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GIJALHDONHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class NOOBHNHMPJO
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum JBFDHHGFFFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid APOJNDMLPJB;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid HIJJKNIDCPK;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid JBIMMKBDLNJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid DKBKJDJNMGL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid MMBAICKIKPG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid DMHABBONMKD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly HIMOGHLLMID<PFBDGKHFNEC, Guid> HHKBKJGPMFO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<PFBDGKHFNEC> NPKIDMAJOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x849CA40", Offset = "0x849B040", VA = "0x18849CA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x849CB40", Offset = "0x849B140", VA = "0x18849CB40")]
	public static PFBDGKHFNEC KBDDAMDPBJP(Guid DGNNPFFMIEE)
	{
		return default(PFBDGKHFNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x849C8F0", Offset = "0x849AEF0", VA = "0x18849C8F0")]
	public static Guid AKHBEHBBMEA(PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x849CAB0", Offset = "0x849B0B0", VA = "0x18849CAB0")]
	public static bool IKCOGBPNJBD(PFBDGKHFNEC HKANNFNOACJ, [Out] Guid DGNNPFFMIEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x849CC10", Offset = "0x849B210", VA = "0x18849CC10")]
	public static bool MAIPLENDJAD(Guid DGNNPFFMIEE, [Out] PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x849CCB0", Offset = "0x849B2B0", VA = "0x18849CCB0")]
	public static PFBDGKHFNEC NECNDNOKPGH(PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(PFBDGKHFNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x849C990", Offset = "0x849AF90", VA = "0x18849C990")]
	public static JBFDHHGFFFN BICKADHNKCN(PFBDGKHFNEC MINGCDGJMLO)
	{
		return default(JBFDHHGFFFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x849CBD0", Offset = "0x849B1D0", VA = "0x18849CBD0")]
	internal static PFBDGKHFNEC LIAPOMCKDBP(JBFDHHGFFFN KMIMDKDAIBP)
	{
		return default(PFBDGKHFNEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GIMNFOIOBOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KFIHMONGDEE ENBFCLCBHLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<CFPJGPNOHCB> OCBMFBINDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HCKMKEONKBP POKLBHKDKGF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<CFPJGPNOHCB> JGDKECODANM(bool JGNKEBJNFOP = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CFPJGPNOHCB OKAPKPEPOGA(AIPAHMNCJKP EKEPPODJHCN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PJDBJBFMPAC(AIPAHMNCJKP EKEPPODJHCN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<CFPJGPNOHCB> IKDFNMINMBM(AIPAHMNCJKP EKEPPODJHCN, bool ACKBBIOAMDK = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PLCGPIMABMB(AIPAHMNCJKP LGMAGEHLHOO, PFBDGKHFNEC HKANNFNOACJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CFPJGPNOHCB HOOHNDFDINC(PFBDGKHFNEC HKANNFNOACJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PJLDDEGIJNK<T>(PFBDGKHFNEC HKANNFNOACJ, OBMOGFDJOBC NOKCCPNANAA, bool NIJJCCHEIAO, T GIOLPIPFPPJ, [Optional] Action GNHCGEEEONG) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string PMKOOMMAGFH(OBMOGFDJOBC NOKCCPNANAA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NGDAIAMBBJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KOMJCAMEIOF(BPLHNECCAPN MKIDPONBDDE, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBKNJKBOIMD(BPLHNECCAPN MKIDPONBDDE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OCDFMHHAGGB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AIPAHMNCJKP GOBODFFBLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PAIKJEGABFG IJOCJPJPEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GOMNLGPHFID FJHCOGJEAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<JOMFHGHJHIM> MDEPFIHBGMP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LNCAOAIDMNG;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PFBDGKHFNEC CLLLBFMBGAP(AIPAHMNCJKP EKEPPODJHCN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<JOMFHGHJHIM> DDIIPDDCNOP(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MELDHOOGAKE(long CINEDGEJAIA, IReadOnlyList<OFBHEANMOBO> ACGHNKLBJIB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task DABMKHECJPE(long CINEDGEJAIA, long DPKCNMHAPEB, IReadOnlyList<OFBHEANMOBO> ACGHNKLBJIB);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<AIPAHMNCJKP> LGPEBKDABFL();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MCJIBCHBAMI
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84959D0", Offset = "0x8493FD0", VA = "0x1884959D0")]
	public static PFBDGKHFNEC IDDMHOLKNEI(this OCDFMHHAGGB DFOJNPMAGPB)
	{
		return default(PFBDGKHFNEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PMAFLOMPMIM<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string KEHMBFAHCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event LFEKMPIFLEG<TPermission> PFKEDCAACJO;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class NGADBJDOAHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? OMCAANNLCKA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? MMGBJDNAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x849B460", Offset = "0x8499A60", VA = "0x18849B460")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x849B530", Offset = "0x8499B30", VA = "0x18849B530")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x849B630", Offset = "0x8499C30", VA = "0x18849B630")]
	protected NGADBJDOAHA(object? LFJIHHEOJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DKFJJBJKAHH(object? OHLIHBDBKCE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class EKOLPPIPOML<T> : NGADBJDOAHA where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> EFGNCEEFOAD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4522C90", Offset = "0x4521290", VA = "0x184522C90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x45229B0", Offset = "0x4520FB0", VA = "0x1845229B0", Slot = "4")]
	public override bool DKFJJBJKAHH(object? OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4523140", Offset = "0x4521740", VA = "0x184523140")]
	public bool JFNLPJGNLKA(T CDKCFPGJLFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x45235B0", Offset = "0x4521BB0", VA = "0x1845235B0")]
	public EKOLPPIPOML(T JMMNJNFGHEP, IEqualityComparer<T> EFGNCEEFOAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class GNOJCPNFEBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<OBMOGFDJOBC, bool> KGDFDOMHIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<OBMOGFDJOBC, NGADBJDOAHA> NGPNFCCODJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LFPMLEGOPKF GECELIOBPDP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8492A90", Offset = "0x8491090", VA = "0x188492A90")]
	public GNOJCPNFEBO(LFPMLEGOPKF GECELIOBPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8492830", Offset = "0x8490E30", VA = "0x188492830")]
	public bool NGAKDLHJJMJ(OBMOGFDJOBC NOKCCPNANAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x387EDD0", Offset = "0x387D3D0", VA = "0x18387EDD0")]
	public bool MACLMPPHJIE<T>(OBMOGFDJOBC NOKCCPNANAA, bool NIJJCCHEIAO, T OHLIHBDBKCE) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x387E8D0", Offset = "0x387CED0", VA = "0x18387E8D0")]
	public (bool, T?) CEIIHLBDAJO<T>(OBMOGFDJOBC NOKCCPNANAA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8492750", Offset = "0x8490D50", VA = "0x188492750")]
	public bool MACLMPPHJIE(OBMOGFDJOBC NOKCCPNANAA, bool NIJJCCHEIAO, object OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84924F0", Offset = "0x8490AF0", VA = "0x1884924F0")]
	public (bool, object) CEIIHLBDAJO(OBMOGFDJOBC NOKCCPNANAA)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x387ED70", Offset = "0x387D370", VA = "0x18387ED70")]
	private void DBAJKGLJLIP<T>(OBMOGFDJOBC NOKCCPNANAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8492680", Offset = "0x8490C80", VA = "0x188492680")]
	private NGADBJDOAHA IGECJOPBGJP(OBMOGFDJOBC NOKCCPNANAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84928A0", Offset = "0x8490EA0", VA = "0x1884928A0")]
	public void ONHIFELDMEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class NOCEBOJNANN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string HKGGJOPMJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type EDIGHEFJBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly PBMNAOFIPGF OOICOLIJHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly OBMOGFDJOBC PIOGCGDMFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public DFNKOKEMIAI BFKDLGPKEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MCEMAPCCFIK EKCLJDDJLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public LHPFOCINBMB GOCBKENEMLA;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x849C850", Offset = "0x849AE50", VA = "0x18849C850")]
	public NOCEBOJNANN(Type EEGGCODEADK, string OMCLCFINMNI, OBMOGFDJOBC NOKCCPNANAA, DFNKOKEMIAI NLCFDLAEFLJ, MCEMAPCCFIK MNFCPLKOOOF, LHPFOCINBMB EFPOINCEKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x849C750", Offset = "0x849AD50", VA = "0x18849C750")]
	public object BJCMMMIOKGD(object? MIJLJBIHDMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x39B6D50", Offset = "0x39B5350", VA = "0x1839B6D50")]
	public void DBAJKGLJLIP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x849C7A0", Offset = "0x849ADA0", VA = "0x18849C7A0")]
	public void DBAJKGLJLIP(Type FJPDOPHOCIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class BLJCCCKMIIE<T> : NOCEBOJNANN where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string JOJNAIPOOAL(T OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T NLMPCJKKAHP(string? FMGFDMMJJAA, T JMMNJNFGHEP);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PNCLGJPIICC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public JOJNAIPOOAL serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public NLMPCJKKAHP parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PNCLGJPIICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x563AC00", Offset = "0x5639200", VA = "0x18563AC00")]
		internal string GOAGLAFDPGD(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x563AB40", Offset = "0x5639140", VA = "0x18563AB40")]
		internal object ABMHHCHGLAC(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x633D690", Offset = "0x633BC90", VA = "0x18633D690")]
	public BLJCCCKMIIE(OBMOGFDJOBC NOKCCPNANAA, string OMCLCFINMNI, [Optional] JOJNAIPOOAL? NLCFDLAEFLJ, [Optional] NLMPCJKKAHP? MNFCPLKOOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x633C830", Offset = "0x633AE30", VA = "0x18633C830")]
	private static object? AKDPGDCBDMI(NLMPCJKKAHP? MNFCPLKOOOF, string? FMGFDMMJJAA, object? JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x633CE60", Offset = "0x633B460", VA = "0x18633CE60")]
	private static string DFNAEDFOBIJ(JOJNAIPOOAL? CHMEKGIMIFF, object? OHLIHBDBKCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string DFNKOKEMIAI(object? OHLIHBDBKCE);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object MCEMAPCCFIK(string? FMGFDMMJJAA, [Optional] object JMMNJNFGHEP);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate NGADBJDOAHA LHPFOCINBMB();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class LFPMLEGOPKF
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class FINILLMIJAE : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static FINILLMIJAE MLIJHBGBMKP;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84921C0", Offset = "0x84907C0", VA = "0x1884921C0", Slot = "4")]
		public bool Equals(List<string> CEJAAIDLEPA, List<string> IMNDAJIDDFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8492310", Offset = "0x8490910", VA = "0x188492310", Slot = "5")]
		public int GetHashCode(List<string> BOMDCGFKGKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FINILLMIJAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class DCIFPEKNECN : ONJKNCMKDMF<MKGDLGMGGGP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8491920", Offset = "0x848FF20", VA = "0x188491920", Slot = "9")]
		public override string DFNAEDFOBIJ(MKGDLGMGGGP HPLMFDGMJFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8491A10", Offset = "0x8490010", VA = "0x188491A10", Slot = "10")]
		protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] MKGDLGMGGGP OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8491BF0", Offset = "0x84901F0", VA = "0x188491BF0")]
		public DCIFPEKNECN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly DAADDOGNPCG DPPBPNKEADF;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly DCIFPEKNECN KPJHPIMEBDC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<NOCEBOJNANN> EFMNMIFAMBM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<OBMOGFDJOBC> MNPIGMDEOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<OBMOGFDJOBC, NOCEBOJNANN> ACCHCPLJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84956B0", Offset = "0x8493CB0", VA = "0x1884956B0")]
	public LFPMLEGOPKF([Optional] IList<NOCEBOJNANN>? PKJBIGNJNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8494140", Offset = "0x8492740", VA = "0x188494140")]
	public NOCEBOJNANN BEDHGFMKFDB(OBMOGFDJOBC NOKCCPNANAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KFIHMONGDEE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CFPJGPNOHCB OEFMDNFKAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class NGDMMIIKHPH : KFIHMONGDEE
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static NGDMMIIKHPH JNCLLGEOMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly OFKLEEBEDFB JDLMCAFBKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<OFKLEEBEDFB> HECHGBPLPKM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CFPJGPNOHCB OEFMDNFKAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x849C640", Offset = "0x849AC40", VA = "0x18849C640")]
	public NGDMMIIKHPH(OFKLEEBEDFB NKAIBBIMDFD, IReadOnlyList<OFKLEEBEDFB> JFHOJCFAEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x849B730", Offset = "0x8499D30", VA = "0x18849B730")]
	private static NGDMMIIKHPH JFBGGJPHLJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DKNKBAONLND
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<PFBDGKHFNEC> IAKMENHBLJD;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8491C30", Offset = "0x8490230", VA = "0x188491C30")]
	public static bool BPNPPHEGGEJ(this AIPAHMNCJKP MCADOGGHICO, PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8491D10", Offset = "0x8490310", VA = "0x188491D10")]
	public static bool EIIADOCBDOC(this AIPAHMNCJKP MCADOGGHICO, PFBDGKHFNEC HKANNFNOACJ, GOMNLGPHFID NMKJEHFFHPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KAMLEJBKEMM
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool EFGHHOLEBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool MEPLMDPALNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool OOMDHPJDBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool MABEBNCBOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool ICJBCPKJMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GEIFLBLNBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool EEFFOBAMJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool JKFPACABBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool BANJIDLLADI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DJJKNIIADMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool FEGOJKDKANL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FLHLAOFKPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> OGAPDKPOJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	MKGDLGMGGGP JHDMDDEHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CFPJGPNOHCB : KAMLEJBKEMM, IFBLPKMHGJM, PMAFLOMPMIM<OBMOGFDJOBC>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string NBHOAKHGCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	PFBDGKHFNEC PFIGMIHJLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) HIBANGAJEMM<T>(OBMOGFDJOBC NOKCCPNANAA) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum OBMOGFDJOBC
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CAN_ADD_ROOM_BANS = 1018,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CAN_MODIFY_ROOM_WIDE_ASSETS = 1019
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class OFKLEEBEDFB : CFPJGPNOHCB, KAMLEJBKEMM, IFBLPKMHGJM, PMAFLOMPMIM<OBMOGFDJOBC>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly LFPMLEGOPKF AOKCANFEOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly GNOJCPNFEBO LAPONJACCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? GNGGGNCPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? CBBDOKDHGGH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool GICGNHOOBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x849E0A0", Offset = "0x849C6A0", VA = "0x18849E0A0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool KMENCPHAKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x849D150", Offset = "0x849B750", VA = "0x18849D150", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool HKJNKEEHILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x849D0B0", Offset = "0x849B6B0", VA = "0x18849D0B0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool ODHMAEOKEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x849D060", Offset = "0x849B660", VA = "0x18849D060", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool LOGLEBMILJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x849E240", Offset = "0x849C840", VA = "0x18849E240", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool AHNIAGMFMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x849D250", Offset = "0x849B850", VA = "0x18849D250", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public PFBDGKHFNEC PFIGMIHJLAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6E90", Offset = "0xAB5490", VA = "0x180AB6E90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(PFBDGKHFNEC);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9F41E0", Offset = "0x9F27E0", VA = "0x1809F41E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string KEHMBFAHCPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x849D2A0", Offset = "0x849B8A0", VA = "0x18849D2A0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x849D100", Offset = "0x849B700", VA = "0x18849D100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string NBHOAKHGCLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x849D2A0", Offset = "0x849B8A0", VA = "0x18849D2A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool OEJBLMNBGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD81E20", Offset = "0xD80420", VA = "0x180D81E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xD81E40", Offset = "0xD80440", VA = "0x180D81E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool EFGHHOLEBDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x849EE00", Offset = "0x849D400", VA = "0x18849EE00", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MKGDLGMGGGP JHDMDDEHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x849E000", Offset = "0x849C600", VA = "0x18849E000", Slot = "20")]
		get
		{
			return default(MKGDLGMGGGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MEPLMDPALNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x849EA20", Offset = "0x849D020", VA = "0x18849EA20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool OOMDHPJDBKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x849EA70", Offset = "0x849D070", VA = "0x18849EA70", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool MABEBNCBOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x849EB10", Offset = "0x849D110", VA = "0x18849EB10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ICJBCPKJMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x849EC40", Offset = "0x849D240", VA = "0x18849EC40", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GEIFLBLNBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x849EB60", Offset = "0x849D160", VA = "0x18849EB60", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool EEFFOBAMJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x849E050", Offset = "0x849C650", VA = "0x18849E050", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool JKFPACABBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x849E870", Offset = "0x849CE70", VA = "0x18849E870", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool BANJIDLLADI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x849D2F0", Offset = "0x849B8F0", VA = "0x18849D2F0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> OGAPDKPOJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x849E8C0", Offset = "0x849CEC0", VA = "0x18849E8C0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GKICBGPFFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x849E0A0", Offset = "0x849C6A0", VA = "0x18849E0A0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool AHBABOEMAGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x849E240", Offset = "0x849C840", VA = "0x18849E240", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool OFLIGIDFMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x849D150", Offset = "0x849B750", VA = "0x18849D150", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DJJKNIIADMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x849ED40", Offset = "0x849D340", VA = "0x18849ED40", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool FEGOJKDKANL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x849EAC0", Offset = "0x849D0C0", VA = "0x18849EAC0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool KGEDGDCHABL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x849D0B0", Offset = "0x849B6B0", VA = "0x18849D0B0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool FLHLAOFKPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x849DFB0", Offset = "0x849C5B0", VA = "0x18849DFB0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IKKEIINMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x849D060", Offset = "0x849B660", VA = "0x18849D060", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CFGIAMMCIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x849D250", Offset = "0x849B850", VA = "0x18849D250", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event LFEKMPIFLEG<OBMOGFDJOBC> PFKEDCAACJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x849D1A0", Offset = "0x849B7A0", VA = "0x18849D1A0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x849EC90", Offset = "0x849D290", VA = "0x18849EC90", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x39EE890", Offset = "0x39ECE90", VA = "0x1839EE890", Slot = "6")]
	public (bool, T?) HIBANGAJEMM<T>(OBMOGFDJOBC NOKCCPNANAA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x39EEA80", Offset = "0x39ED080", VA = "0x1839EEA80")]
	public OFKLEEBEDFB JOEEOAGHHPC<T>(OBMOGFDJOBC NOKCCPNANAA, bool NIJJCCHEIAO, T OHLIHBDBKCE) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x849EED0", Offset = "0x849D4D0", VA = "0x18849EED0")]
	public OFKLEEBEDFB(PFBDGKHFNEC HKANNFNOACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x849EEF0", Offset = "0x849D4F0", VA = "0x18849EEF0")]
	public OFKLEEBEDFB(PFBDGKHFNEC HKANNFNOACJ, [Optional] string? GNGGGNCPLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x849EF10", Offset = "0x849D510", VA = "0x18849EF10")]
	public OFKLEEBEDFB(OFKLEEBEDFB GCEOKOBHBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x849EF90", Offset = "0x849D590", VA = "0x18849EF90")]
	internal OFKLEEBEDFB(PFBDGKHFNEC ODEKBMAHGAA, [Optional] string? GNGGGNCPLMA, [Optional] OFKLEEBEDFB? GCEOKOBHBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x849E1D0", Offset = "0x849C7D0", VA = "0x18849E1D0")]
	public static PBMNAOFIPGF FNGLHLIJLGL(OBMOGFDJOBC NOKCCPNANAA)
	{
		return default(PBMNAOFIPGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x849ED90", Offset = "0x849D390", VA = "0x18849ED90")]
	public void ONHIFELDMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x849D340", Offset = "0x849B940", VA = "0x18849D340")]
	internal OFKLEEBEDFB DBLOBBIGBLO(OFKLEEBEDFB DGHGIDMNANB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x849E490", Offset = "0x849CA90", VA = "0x18849E490")]
	internal IReadOnlyCollection<OBMOGFDJOBC> JDEFNGBGNOL(OFKLEEBEDFB GCEOKOBHBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x849E0F0", Offset = "0x849C6F0", VA = "0x18849E0F0")]
	public bool FJGMNFHNBMA(OBMOGFDJOBC NOKCCPNANAA, bool NIJJCCHEIAO, string PEOCGPNOLEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x849E920", Offset = "0x849CF20", VA = "0x18849E920")]
	public (bool, string) JONKLGDCNPN(OBMOGFDJOBC NOKCCPNANAA)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x849EDB0", Offset = "0x849D3B0", VA = "0x18849EDB0")]
	internal void PNKNFIFDEJK(OBMOGFDJOBC NOKCCPNANAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x849E290", Offset = "0x849C890", VA = "0x18849E290")]
	public DPMCODEOIFI IGIDBGLAKOE(Func<PFBDGKHFNEC, Guid> CJNDJAOFGHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x849D630", Offset = "0x849BC30", VA = "0x18849D630")]
	public void DJCLACKEADP(DPMCODEOIFI GLCHJAACDIN, Func<Guid, PFBDGKHFNEC> HDOGGOFLJGK, [Optional] PFBDGKHFNEC? GHOJAPAMNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x849EBB0", Offset = "0x849D1B0", VA = "0x18849EBB0")]
	[CompilerGenerated]
	private void LELJKGEHNCG(OBMOGFDJOBC FKLOKGHDFAH, LAHFPFBLEBD CLOAJJHEKPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MNAGCMFEGKD : NGDAIAMBBJJ, GIMNFOIOBOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KCKLLHDEBKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public OFKLEEBEDFB newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KCKLLHDEBKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8494110", Offset = "0x8492710", VA = "0x188494110")]
		internal bool OKIIOLBFIEH(OFKLEEBEDFB rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class CKLCGCFBCPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public PFBDGKHFNEC roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CKLCGCFBCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1BEA370", Offset = "0x1BE8970", VA = "0x181BEA370")]
		internal bool OCKGNAEBEFF(PFBDGKHFNEC r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct DAPCMIEGPDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public MNAGCMFEGKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BPLHNECCAPN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<JOMFHGHJHIM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8491250", Offset = "0x848F850", VA = "0x188491250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x84918C0", Offset = "0x848FEC0", VA = "0x1884918C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class EJBEJAAGEAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EJBEJAAGEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8491F30", Offset = "0x8490530", VA = "0x188491F30")]
		internal void GKFKAIHBPEC(DPMCODEOIFI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8492010", Offset = "0x8490610", VA = "0x188492010")]
		internal void LBJNHJEMAIO(DPMCODEOIFI r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct OHDCNJBEGNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public BPLHNECCAPN roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FBECHLNGIHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<DPMCODEOIFI, LAHFPFBLEBD> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FBECHLNGIHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8492130", Offset = "0x8490730", VA = "0x188492130")]
		internal void BLBFPADNHIF(DPMCODEOIFI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8492190", Offset = "0x8490790", VA = "0x188492190")]
		internal void KPBPOEPIEMN(DPMCODEOIFI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8492160", Offset = "0x8490760", VA = "0x188492160")]
		internal void IINFIOGFDMP(DPMCODEOIFI r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class JJMPMNKGJED<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public JJMPMNKGJED<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<JOMFHGHJHIM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4072810", Offset = "0x4070E10", VA = "0x184072810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public OBMOGFDJOBC rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public PFBDGKHFNEC accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public PBMNAOFIPGF recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public MNAGCMFEGKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JJMPMNKGJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4E84030", Offset = "0x4E82630", VA = "0x184E84030")]
		[AsyncStateMachine(typeof(JJMPMNKGJED<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void KBMEDODODHC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct HHJGKMKINOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<OFBHEANMOBO> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HIOBCLDKEPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public OCDFMHHAGGB rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public BPLHNECCAPN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<PFBDGKHFNEC, OFKLEEBEDFB> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public ABHKBFFIJLO debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8492D40", Offset = "0x8491340", VA = "0x188492D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8493860", Offset = "0x8491E60", VA = "0x188493860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly OCDFMHHAGGB DFOJNPMAGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NGDMMIIKHPH EEOMLIBNNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly ABHKBFFIJLO KPKDGGHCPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, OFKLEEBEDFB> HJLAACOFLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<PFBDGKHFNEC, OFKLEEBEDFB> BAMGBIMNCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<PFBDGKHFNEC, OFKLEEBEDFB> NNDNBKNDLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<OFKLEEBEDFB> FLGKCNKPDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool GNPDEIBGGEN;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly OBMOGFDJOBC[] HCDFMNDNEJL;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public KFIHMONGDEE ENBFCLCBHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<CFPJGPNOHCB> OCBMFBINDDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x84962A0", Offset = "0x84948A0", VA = "0x1884962A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HCKMKEONKBP POKLBHKDKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8496B60", Offset = "0x8495160", VA = "0x188496B60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8497670", Offset = "0x8495C70", VA = "0x188497670", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8498E00", Offset = "0x8497400", VA = "0x188498E00")]
	[AOJMKBDAFKB.IAGHHAMHDJE]
	internal static void MAKIPFCGLCJ(AINJBKKEAIL PJLGMBBLBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x849B1A0", Offset = "0x84997A0", VA = "0x18849B1A0")]
	[UnityEngine.Scripting.Preserve]
	internal MNAGCMFEGKD([DJIFKCCBBND(null)] OCDFMHHAGGB EDNBMPPAPBG, [DJIFKCCBBND(null)] NGDMMIIKHPH JMMIIBCKDLI, [DJIFKCCBBND(null)] ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x84971E0", Offset = "0x84957E0", VA = "0x1884971E0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x84962F0", Offset = "0x84948F0", VA = "0x1884962F0")]
	private void BNNAIMFLKJI(IEnumerable<OFKLEEBEDFB> HNFKCKOMPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x849AA20", Offset = "0x8499020", VA = "0x18849AA20", Slot = "12")]
	public bool PJDBJBFMPAC(AIPAHMNCJKP EKEPPODJHCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8498DF0", Offset = "0x84973F0", VA = "0x188498DF0")]
	private void LNCAOAIDMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8497820", Offset = "0x8495E20", VA = "0x188497820")]
	private void FJHHJBIMEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8498610", Offset = "0x8496C10", VA = "0x188498610", Slot = "10")]
	public IReadOnlyList<CFPJGPNOHCB> JGDKECODANM(bool JGNKEBJNFOP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8499590", Offset = "0x8497B90", VA = "0x188499590", Slot = "11")]
	public CFPJGPNOHCB OKAPKPEPOGA(AIPAHMNCJKP EKEPPODJHCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x849A400", Offset = "0x8498A00", VA = "0x18849A400")]
	private PFBDGKHFNEC ONOKMPKAAIE(AIPAHMNCJKP EKEPPODJHCN)
	{
		return default(PFBDGKHFNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x849AAF0", Offset = "0x84990F0", VA = "0x18849AAF0", Slot = "14")]
	public bool PLCGPIMABMB(AIPAHMNCJKP LGMAGEHLHOO, PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8497D60", Offset = "0x8496360", VA = "0x188497D60", Slot = "15")]
	public CFPJGPNOHCB HOOHNDFDINC(PFBDGKHFNEC HKANNFNOACJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8498AC0", Offset = "0x84970C0", VA = "0x188498AC0")]
	private static bool LIFDJBNAPFF(GGPHJONNNGN MCDDAKEHKOC, PFBDGKHFNEC HKANNFNOACJ, [Out] DPMCODEOIFI? IECFIDMJPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8499480", Offset = "0x8497A80", VA = "0x188499480")]
	private static void MIOIJLFJGDA(GGPHJONNNGN MCDDAKEHKOC, Action<DPMCODEOIFI> CMCNMLKAKIO, PFBDGKHFNEC ENMFNLHEENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x84991F0", Offset = "0x84977F0", VA = "0x1884991F0")]
	private static void MIOIJLFJGDA(GGPHJONNNGN MCDDAKEHKOC, Action<DPMCODEOIFI> CMCNMLKAKIO, Predicate<PFBDGKHFNEC> FONMAAKKEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8497E00", Offset = "0x8496400", VA = "0x188497E00")]
	private void ICAICCAHOCL(AIPAHMNCJKP EKEPPODJHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x84989A0", Offset = "0x8496FA0", VA = "0x1884989A0", Slot = "4")]
	[AsyncStateMachine(typeof(DAPCMIEGPDM))]
	public Task KOMJCAMEIOF([CanBeNull] BPLHNECCAPN MKIDPONBDDE, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
	public void GBKNJKBOIMD(BPLHNECCAPN MKIDPONBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8496C00", Offset = "0x8495200", VA = "0x188496C00")]
	private void DAOGGBFBKED(GGPHJONNNGN EBPPFIKFCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8498690", Offset = "0x8496C90", VA = "0x188498690")]
	internal static string KDDNBJGLIJO(OCDFMHHAGGB DFOJNPMAGPB, BPLHNECCAPN MKIDPONBDDE, IReadOnlyDictionary<PFBDGKHFNEC, OFKLEEBEDFB> BAMGBIMNCEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x84996A0", Offset = "0x8497CA0", VA = "0x1884996A0")]
	private static void ONDJJDFHOCF(BPLHNECCAPN MKIDPONBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8497A10", Offset = "0x8496010", VA = "0x188497A10")]
	private static void GOEGNBHCGMC(GGPHJONNNGN LDDKPIJDLPF, IReadOnlyDictionary<PFBDGKHFNEC, OFKLEEBEDFB> BAMGBIMNCEH, StringBuilder ANGPDNIFHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8497710", Offset = "0x8495D10", VA = "0x188497710")]
	private static bool FBDJBOKILMN(string IOIDIAPBNEL, [Out] Guid PMIEBEDAACI, [Out] PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8495A30", Offset = "0x8494030", VA = "0x188495A30")]
	private static void AHCKCNBHDFB(BPLHNECCAPN MKIDPONBDDE, StringBuilder ANGPDNIFHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x39428D0", Offset = "0x3940ED0", VA = "0x1839428D0", Slot = "16")]
	public bool PJLDDEGIJNK<T>(PFBDGKHFNEC HKANNFNOACJ, OBMOGFDJOBC NOKCCPNANAA, bool NIJJCCHEIAO, T GIOLPIPFPPJ, [Optional] Action GNHCGEEEONG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x849AC80", Offset = "0x8499280", VA = "0x18849AC80", Slot = "17")]
	public string PMKOOMMAGFH(OBMOGFDJOBC NOKCCPNANAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x849A810", Offset = "0x8498E10", VA = "0x18849A810")]
	private void PHCFOMLEOBG(PFBDGKHFNEC HKANNFNOACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8499570", Offset = "0x8497B70", VA = "0x188499570")]
	private bool NFKNFHNOAFH(AIPAHMNCJKP EKEPPODJHCN, PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x849A4D0", Offset = "0x8498AD0", VA = "0x18849A4D0")]
	internal OFKLEEBEDFB PCKGKHLPNJN(AIPAHMNCJKP EKEPPODJHCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8498600", Offset = "0x8496C00", VA = "0x188498600", Slot = "13")]
	public IReadOnlyList<CFPJGPNOHCB> IKDFNMINMBM(AIPAHMNCJKP EKEPPODJHCN, bool ACKBBIOAMDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8498FC0", Offset = "0x84975C0", VA = "0x188498FC0")]
	internal IReadOnlyList<OFKLEEBEDFB> MFLMNOILHOK(AIPAHMNCJKP EKEPPODJHCN, bool ACKBBIOAMDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8497E70", Offset = "0x8496470", VA = "0x188497E70")]
	private void IEAEHEAPMPH(JOMFHGHJHIM BNBMOOFMDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x849ACF0", Offset = "0x84992F0", VA = "0x18849ACF0")]
	private static bool POCMOEGPKOE(OFKLEEBEDFB HIGEAOFBLKO, IReadOnlyDictionary<PFBDGKHFNEC, OFKLEEBEDFB> BAMGBIMNCEH, [Out] IReadOnlyList<OBMOGFDJOBC> OKGPCGIEEPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8496160", Offset = "0x8494760", VA = "0x188496160")]
	[AsyncStateMachine(typeof(HIOBCLDKEPH))]
	private static Task BGCIPFMDFBD(OCDFMHHAGGB DFOJNPMAGPB, BPLHNECCAPN MKIDPONBDDE, IReadOnlyDictionary<PFBDGKHFNEC, OFKLEEBEDFB> BAMGBIMNCEH, ABHKBFFIJLO KPKDGGHCPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8496F40", Offset = "0x8495540", VA = "0x188496F40")]
	[CompilerGenerated]
	internal static void DIJFJKLDKJA(Func<DPMCODEOIFI, LAHFPFBLEBD> LKBOFLBEHID, OHDCNJBEGNH P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x84972F0", Offset = "0x84958F0", VA = "0x1884972F0")]
	[CompilerGenerated]
	internal static bool EABFELHEBOG(PFBDGKHFNEC HKANNFNOACJ, OBMOGFDJOBC NOKCCPNANAA, [Out] OFBHEANMOBO HIBJFEHGMOE, HHJGKMKINOA P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EOGPBNNKNGG
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHDKDANENDA(AIPAHMNCJKP FKPCNJDOKFK, AIPAHMNCJKP AMGNIPEHDKA, IEnumerable<AIPAHMNCJKP> LFHJKBOPNAB, [Out] MKGDLGMGGGP NJFJGIKBOIP, [Out] BAIGFBCBCAG CNHKLJNNAFO);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string EJGANONGCHM(BAIGFBCBCAG PBIIKCHJFME);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum BAIGFBCBCAG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class IPKLIBACDCD : EOGPBNNKNGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly GIMNFOIOBOF IKIMMLIMAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly BCJMCFPBBMH IHEEFOAFCAI;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IPKLIBACDCD([DJIFKCCBBND(null)] GIMNFOIOBOF INMKFMCLHLA, [DJIFKCCBBND(null)] BCJMCFPBBMH DGBMFJMFAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x84940D0", Offset = "0x84926D0", VA = "0x1884940D0")]
	private static MGNELHNLHHI? JBCACIFFCCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x84938C0", Offset = "0x8491EC0", VA = "0x1884938C0", Slot = "4")]
	public bool EHDKDANENDA(AIPAHMNCJKP FKPCNJDOKFK, AIPAHMNCJKP AMGNIPEHDKA, IEnumerable<AIPAHMNCJKP> LFHJKBOPNAB, [Out] MKGDLGMGGGP NJFJGIKBOIP, [Out] BAIGFBCBCAG CNHKLJNNAFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x84939C0", Offset = "0x8491FC0", VA = "0x1884939C0", Slot = "5")]
	public string EJGANONGCHM(BAIGFBCBCAG PBIIKCHJFME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8493AC0", Offset = "0x84920C0", VA = "0x188493AC0")]
	internal bool HFNIKICLBDH(AIPAHMNCJKP FKPCNJDOKFK, AIPAHMNCJKP AMGNIPEHDKA, IEnumerable<AIPAHMNCJKP> LFHJKBOPNAB, GOMNLGPHFID NMKJEHFFHPL, MGNELHNLHHI? PNJGCNAICIF, [Out] MKGDLGMGGGP NJFJGIKBOIP, [Out] BAIGFBCBCAG CNHKLJNNAFO)
	{
		return default(bool);
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

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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x84B7560", Offset = "0x84B6560", VA = "0x1884B7560")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
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
		[Cpp2IlInjected.Address(RVA = "0x84B9E30", Offset = "0x84B8E30", VA = "0x1884B9E30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
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
		[Cpp2IlInjected.Address(RVA = "0x84B6F80", Offset = "0x84B5F80", VA = "0x1884B6F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x84B7090", Offset = "0x84B6090", VA = "0x1884B7090")]
	public static PFBDGKHFNEC KBDDAMDPBJP(Guid DGNNPFFMIEE)
	{
		return default(PFBDGKHFNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x84B6E30", Offset = "0x84B5E30", VA = "0x1884B6E30")]
	public static Guid AKHBEHBBMEA(PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84B7000", Offset = "0x84B6000", VA = "0x1884B7000")]
	public static bool IKCOGBPNJBD(PFBDGKHFNEC HKANNFNOACJ, [Out] Guid DGNNPFFMIEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84B7160", Offset = "0x84B6160", VA = "0x1884B7160")]
	public static bool MAIPLENDJAD(Guid DGNNPFFMIEE, [Out] PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84B7200", Offset = "0x84B6200", VA = "0x1884B7200")]
	public static PFBDGKHFNEC NECNDNOKPGH(PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(PFBDGKHFNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84B6ED0", Offset = "0x84B5ED0", VA = "0x1884B6ED0")]
	public static JBFDHHGFFFN BICKADHNKCN(PFBDGKHFNEC MINGCDGJMLO)
	{
		return default(JBFDHHGFFFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84B7120", Offset = "0x84B6120", VA = "0x1884B7120")]
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
	[Cpp2IlInjected.Address(RVA = "0x84AFDC0", Offset = "0x84AEDC0", VA = "0x1884AFDC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84B5970", Offset = "0x84B4970", VA = "0x1884B5970")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84B5A50", Offset = "0x84B4A50", VA = "0x1884B5A50")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x84B5B50", Offset = "0x84B4B50", VA = "0x1884B5B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x44E85F0", Offset = "0x44E75F0", VA = "0x1844E85F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x44E82F0", Offset = "0x44E72F0", VA = "0x1844E82F0", Slot = "4")]
	public override bool DKFJJBJKAHH(object? OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x44E8AD0", Offset = "0x44E7AD0", VA = "0x1844E8AD0")]
	public bool JFNLPJGNLKA(T CDKCFPGJLFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x44E8F60", Offset = "0x44E7F60", VA = "0x1844E8F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x84ACE20", Offset = "0x84ABE20", VA = "0x1884ACE20")]
	public GNOJCPNFEBO(LFPMLEGOPKF GECELIOBPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x84ACBC0", Offset = "0x84ABBC0", VA = "0x1884ACBC0")]
	public bool NGAKDLHJJMJ(OBMOGFDJOBC NOKCCPNANAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x38609C0", Offset = "0x385F9C0", VA = "0x1838609C0")]
	public bool MACLMPPHJIE<T>(OBMOGFDJOBC NOKCCPNANAA, bool NIJJCCHEIAO, T OHLIHBDBKCE) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x38604C0", Offset = "0x385F4C0", VA = "0x1838604C0")]
	public (bool, T?) CEIIHLBDAJO<T>(OBMOGFDJOBC NOKCCPNANAA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x84ACAE0", Offset = "0x84ABAE0", VA = "0x1884ACAE0")]
	public bool MACLMPPHJIE(OBMOGFDJOBC NOKCCPNANAA, bool NIJJCCHEIAO, object OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84AC870", Offset = "0x84AB870", VA = "0x1884AC870")]
	public (bool, object) CEIIHLBDAJO(OBMOGFDJOBC NOKCCPNANAA)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3860960", Offset = "0x385F960", VA = "0x183860960")]
	private void DBAJKGLJLIP<T>(OBMOGFDJOBC NOKCCPNANAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x84ACA10", Offset = "0x84ABA10", VA = "0x1884ACA10")]
	private NGADBJDOAHA IGECJOPBGJP(OBMOGFDJOBC NOKCCPNANAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84ACC30", Offset = "0x84ABC30", VA = "0x1884ACC30")]
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
	[Cpp2IlInjected.Address(RVA = "0x84B6D90", Offset = "0x84B5D90", VA = "0x1884B6D90")]
	public NOCEBOJNANN(Type EEGGCODEADK, string OMCLCFINMNI, OBMOGFDJOBC NOKCCPNANAA, DFNKOKEMIAI NLCFDLAEFLJ, MCEMAPCCFIK MNFCPLKOOOF, LHPFOCINBMB EFPOINCEKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84B6C90", Offset = "0x84B5C90", VA = "0x1884B6C90")]
	public object BJCMMMIOKGD(object? MIJLJBIHDMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x399A7A0", Offset = "0x39997A0", VA = "0x18399A7A0")]
	public void DBAJKGLJLIP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84B6CE0", Offset = "0x84B5CE0", VA = "0x1884B6CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public PNCLGJPIICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x562E320", Offset = "0x562D320", VA = "0x18562E320")]
		internal string GOAGLAFDPGD(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x562E260", Offset = "0x562D260", VA = "0x18562E260")]
		internal object ABMHHCHGLAC(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x63AD4A0", Offset = "0x63AC4A0", VA = "0x1863AD4A0")]
	public BLJCCCKMIIE(OBMOGFDJOBC NOKCCPNANAA, string OMCLCFINMNI, [Optional] JOJNAIPOOAL? NLCFDLAEFLJ, [Optional] NLMPCJKKAHP? MNFCPLKOOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x63AC5C0", Offset = "0x63AB5C0", VA = "0x1863AC5C0")]
	private static object? AKDPGDCBDMI(NLMPCJKKAHP? MNFCPLKOOOF, string? FMGFDMMJJAA, object? JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x63ACC40", Offset = "0x63ABC40", VA = "0x1863ACC40")]
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
		[Cpp2IlInjected.Address(RVA = "0x84AC530", Offset = "0x84AB530", VA = "0x1884AC530", Slot = "4")]
		public bool Equals(List<string> CEJAAIDLEPA, List<string> IMNDAJIDDFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x84AC680", Offset = "0x84AB680", VA = "0x1884AC680", Slot = "5")]
		public int GetHashCode(List<string> BOMDCGFKGKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FINILLMIJAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class DCIFPEKNECN : ONJKNCMKDMF<MKGDLGMGGGP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84ABC80", Offset = "0x84AAC80", VA = "0x1884ABC80", Slot = "9")]
		public override string DFNAEDFOBIJ(MKGDLGMGGGP HPLMFDGMJFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x84ABD70", Offset = "0x84AAD70", VA = "0x1884ABD70", Slot = "10")]
		protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] MKGDLGMGGGP OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x84ABF50", Offset = "0x84AAF50", VA = "0x1884ABF50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84AFA70", Offset = "0x84AEA70", VA = "0x1884AFA70")]
	public LFPMLEGOPKF([Optional] IList<NOCEBOJNANN>? PKJBIGNJNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x84AE4D0", Offset = "0x84AD4D0", VA = "0x1884AE4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x84B6B80", Offset = "0x84B5B80", VA = "0x1884B6B80")]
	public NGDMMIIKHPH(OFKLEEBEDFB NKAIBBIMDFD, IReadOnlyList<OFKLEEBEDFB> JFHOJCFAEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x84B5C60", Offset = "0x84B4C60", VA = "0x1884B5C60")]
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
	[Cpp2IlInjected.Address(RVA = "0x84ABF90", Offset = "0x84AAF90", VA = "0x1884ABF90")]
	public static bool BPNPPHEGGEJ(this AIPAHMNCJKP MCADOGGHICO, PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x84AC070", Offset = "0x84AB070", VA = "0x1884AC070")]
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
		[Cpp2IlInjected.Address(RVA = "0x84B8620", Offset = "0x84B7620", VA = "0x1884B8620", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool KMENCPHAKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x84B76D0", Offset = "0x84B66D0", VA = "0x1884B76D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool HKJNKEEHILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x84B7630", Offset = "0x84B6630", VA = "0x1884B7630", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool ODHMAEOKEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x84B75E0", Offset = "0x84B65E0", VA = "0x1884B75E0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool LOGLEBMILJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x84B87D0", Offset = "0x84B77D0", VA = "0x1884B87D0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool AHNIAGMFMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x84B77D0", Offset = "0x84B67D0", VA = "0x1884B77D0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public PFBDGKHFNEC PFIGMIHJLAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5F80", Offset = "0xAA4F80", VA = "0x180AA5F80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(PFBDGKHFNEC);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1F0", Offset = "0x9F91F0", VA = "0x1809FA1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string KEHMBFAHCPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x84B7820", Offset = "0x84B6820", VA = "0x1884B7820", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x84B7680", Offset = "0x84B6680", VA = "0x1884B7680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string NBHOAKHGCLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x84B7820", Offset = "0x84B6820", VA = "0x1884B7820", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool OEJBLMNBGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD6F400", Offset = "0xD6E400", VA = "0x180D6F400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xD6F420", Offset = "0xD6E420", VA = "0x180D6F420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool EFGHHOLEBDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x84B9390", Offset = "0x84B8390", VA = "0x1884B9390", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MKGDLGMGGGP JHDMDDEHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x84B8580", Offset = "0x84B7580", VA = "0x1884B8580", Slot = "20")]
		get
		{
			return default(MKGDLGMGGGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MEPLMDPALNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x84B8FB0", Offset = "0x84B7FB0", VA = "0x1884B8FB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool OOMDHPJDBKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x84B9000", Offset = "0x84B8000", VA = "0x1884B9000", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool MABEBNCBOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x84B90A0", Offset = "0x84B80A0", VA = "0x1884B90A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ICJBCPKJMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x84B91D0", Offset = "0x84B81D0", VA = "0x1884B91D0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GEIFLBLNBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x84B90F0", Offset = "0x84B80F0", VA = "0x1884B90F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool EEFFOBAMJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x84B85D0", Offset = "0x84B75D0", VA = "0x1884B85D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool JKFPACABBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x84B8E00", Offset = "0x84B7E00", VA = "0x1884B8E00", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool BANJIDLLADI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x84B7870", Offset = "0x84B6870", VA = "0x1884B7870", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> OGAPDKPOJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x84B8E50", Offset = "0x84B7E50", VA = "0x1884B8E50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GKICBGPFFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x84B8620", Offset = "0x84B7620", VA = "0x1884B8620", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool AHBABOEMAGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x84B87D0", Offset = "0x84B77D0", VA = "0x1884B87D0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool OFLIGIDFMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x84B76D0", Offset = "0x84B66D0", VA = "0x1884B76D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DJJKNIIADMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x84B92D0", Offset = "0x84B82D0", VA = "0x1884B92D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool FEGOJKDKANL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x84B9050", Offset = "0x84B8050", VA = "0x1884B9050", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool KGEDGDCHABL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x84B7630", Offset = "0x84B6630", VA = "0x1884B7630", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool FLHLAOFKPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x84B8530", Offset = "0x84B7530", VA = "0x1884B8530", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IKKEIINMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x84B75E0", Offset = "0x84B65E0", VA = "0x1884B75E0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CFGIAMMCIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x84B77D0", Offset = "0x84B67D0", VA = "0x1884B77D0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event LFEKMPIFLEG<OBMOGFDJOBC> PFKEDCAACJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x84B7720", Offset = "0x84B6720", VA = "0x1884B7720", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x84B9220", Offset = "0x84B8220", VA = "0x1884B9220", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x39D2000", Offset = "0x39D1000", VA = "0x1839D2000", Slot = "6")]
	public (bool, T?) HIBANGAJEMM<T>(OBMOGFDJOBC NOKCCPNANAA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x39D21F0", Offset = "0x39D11F0", VA = "0x1839D21F0")]
	public OFKLEEBEDFB JOEEOAGHHPC<T>(OBMOGFDJOBC NOKCCPNANAA, bool NIJJCCHEIAO, T OHLIHBDBKCE) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x84B9470", Offset = "0x84B8470", VA = "0x1884B9470")]
	public OFKLEEBEDFB(PFBDGKHFNEC HKANNFNOACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x84B9490", Offset = "0x84B8490", VA = "0x1884B9490")]
	public OFKLEEBEDFB(PFBDGKHFNEC HKANNFNOACJ, [Optional] string? GNGGGNCPLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x84B94B0", Offset = "0x84B84B0", VA = "0x1884B94B0")]
	public OFKLEEBEDFB(OFKLEEBEDFB GCEOKOBHBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x84B9540", Offset = "0x84B8540", VA = "0x1884B9540")]
	internal OFKLEEBEDFB(PFBDGKHFNEC ODEKBMAHGAA, [Optional] string? GNGGGNCPLMA, [Optional] OFKLEEBEDFB? GCEOKOBHBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x84B8750", Offset = "0x84B7750", VA = "0x1884B8750")]
	public static PBMNAOFIPGF FNGLHLIJLGL(OBMOGFDJOBC NOKCCPNANAA)
	{
		return default(PBMNAOFIPGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x84B9320", Offset = "0x84B8320", VA = "0x1884B9320")]
	public void ONHIFELDMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x84B78C0", Offset = "0x84B68C0", VA = "0x1884B78C0")]
	internal OFKLEEBEDFB DBLOBBIGBLO(OFKLEEBEDFB DGHGIDMNANB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x84B8A20", Offset = "0x84B7A20", VA = "0x1884B8A20")]
	internal IReadOnlyCollection<OBMOGFDJOBC> JDEFNGBGNOL(OFKLEEBEDFB GCEOKOBHBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x84B8670", Offset = "0x84B7670", VA = "0x1884B8670")]
	public bool FJGMNFHNBMA(OBMOGFDJOBC NOKCCPNANAA, bool NIJJCCHEIAO, string PEOCGPNOLEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x84B8EB0", Offset = "0x84B7EB0", VA = "0x1884B8EB0")]
	public (bool, string) JONKLGDCNPN(OBMOGFDJOBC NOKCCPNANAA)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x84B9340", Offset = "0x84B8340", VA = "0x1884B9340")]
	internal void PNKNFIFDEJK(OBMOGFDJOBC NOKCCPNANAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x84B8820", Offset = "0x84B7820", VA = "0x1884B8820")]
	public DPMCODEOIFI IGIDBGLAKOE(Func<PFBDGKHFNEC, Guid> CJNDJAOFGHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x84B7BB0", Offset = "0x84B6BB0", VA = "0x1884B7BB0")]
	public void DJCLACKEADP(DPMCODEOIFI GLCHJAACDIN, Func<Guid, PFBDGKHFNEC> HDOGGOFLJGK, [Optional] PFBDGKHFNEC? GHOJAPAMNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x84B9140", Offset = "0x84B8140", VA = "0x1884B9140")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KCKLLHDEBKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x84AE4A0", Offset = "0x84AD4A0", VA = "0x1884AE4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CKLCGCFBCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1BD20C0", Offset = "0x1BD10C0", VA = "0x181BD20C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84AB5B0", Offset = "0x84AA5B0", VA = "0x1884AB5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x84ABC20", Offset = "0x84AAC20", VA = "0x1884ABC20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EJBEJAAGEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x84AC2A0", Offset = "0x84AB2A0", VA = "0x1884AC2A0")]
		internal void GKFKAIHBPEC(DPMCODEOIFI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x84AC380", Offset = "0x84AB380", VA = "0x1884AC380")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FBECHLNGIHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x84AC4A0", Offset = "0x84AB4A0", VA = "0x1884AC4A0")]
		internal void BLBFPADNHIF(DPMCODEOIFI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x84AC500", Offset = "0x84AB500", VA = "0x1884AC500")]
		internal void KPBPOEPIEMN(DPMCODEOIFI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x84AC4D0", Offset = "0x84AB4D0", VA = "0x1884AC4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4031B60", Offset = "0x4030B60", VA = "0x184031B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JJMPMNKGJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4E3BF20", Offset = "0x4E3AF20", VA = "0x184E3BF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x84AD0D0", Offset = "0x84AC0D0", VA = "0x1884AD0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x84ADBF0", Offset = "0x84ACBF0", VA = "0x1884ADBF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<CFPJGPNOHCB> OCBMFBINDDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x84B06A0", Offset = "0x84AF6A0", VA = "0x1884B06A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HCKMKEONKBP POKLBHKDKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x84B0F70", Offset = "0x84AFF70", VA = "0x1884B0F70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x84B1A80", Offset = "0x84B0A80", VA = "0x1884B1A80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x84B3220", Offset = "0x84B2220", VA = "0x1884B3220")]
	[AOJMKBDAFKB.IAGHHAMHDJE]
	internal static void MAKIPFCGLCJ(AINJBKKEAIL PJLGMBBLBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x84B56B0", Offset = "0x84B46B0", VA = "0x1884B56B0")]
	[UnityEngine.Scripting.Preserve]
	internal MNAGCMFEGKD([DJIFKCCBBND(null)] OCDFMHHAGGB EDNBMPPAPBG, [DJIFKCCBBND(null)] NGDMMIIKHPH JMMIIBCKDLI, [DJIFKCCBBND(null)] ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x84B15F0", Offset = "0x84B05F0", VA = "0x1884B15F0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x84B06F0", Offset = "0x84AF6F0", VA = "0x1884B06F0")]
	private void BNNAIMFLKJI(IEnumerable<OFKLEEBEDFB> HNFKCKOMPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x84B4F10", Offset = "0x84B3F10", VA = "0x1884B4F10", Slot = "12")]
	public bool PJDBJBFMPAC(AIPAHMNCJKP EKEPPODJHCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x84B3210", Offset = "0x84B2210", VA = "0x1884B3210")]
	private void LNCAOAIDMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x84B1C30", Offset = "0x84B0C30", VA = "0x1884B1C30")]
	private void FJHHJBIMEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x84B2A30", Offset = "0x84B1A30", VA = "0x1884B2A30", Slot = "10")]
	public IReadOnlyList<CFPJGPNOHCB> JGDKECODANM(bool JGNKEBJNFOP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x84B39B0", Offset = "0x84B29B0", VA = "0x1884B39B0", Slot = "11")]
	public CFPJGPNOHCB OKAPKPEPOGA(AIPAHMNCJKP EKEPPODJHCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x84B48F0", Offset = "0x84B38F0", VA = "0x1884B48F0")]
	private PFBDGKHFNEC ONOKMPKAAIE(AIPAHMNCJKP EKEPPODJHCN)
	{
		return default(PFBDGKHFNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x84B4FE0", Offset = "0x84B3FE0", VA = "0x1884B4FE0", Slot = "14")]
	public bool PLCGPIMABMB(AIPAHMNCJKP LGMAGEHLHOO, PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x84B2170", Offset = "0x84B1170", VA = "0x1884B2170", Slot = "15")]
	public CFPJGPNOHCB HOOHNDFDINC(PFBDGKHFNEC HKANNFNOACJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x84B2EE0", Offset = "0x84B1EE0", VA = "0x1884B2EE0")]
	private static bool LIFDJBNAPFF(GGPHJONNNGN MCDDAKEHKOC, PFBDGKHFNEC HKANNFNOACJ, [Out] DPMCODEOIFI? IECFIDMJPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x84B38A0", Offset = "0x84B28A0", VA = "0x1884B38A0")]
	private static void MIOIJLFJGDA(GGPHJONNNGN MCDDAKEHKOC, Action<DPMCODEOIFI> CMCNMLKAKIO, PFBDGKHFNEC ENMFNLHEENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x84B3610", Offset = "0x84B2610", VA = "0x1884B3610")]
	private static void MIOIJLFJGDA(GGPHJONNNGN MCDDAKEHKOC, Action<DPMCODEOIFI> CMCNMLKAKIO, Predicate<PFBDGKHFNEC> FONMAAKKEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x84B2210", Offset = "0x84B1210", VA = "0x1884B2210")]
	private void ICAICCAHOCL(AIPAHMNCJKP EKEPPODJHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x84B2DC0", Offset = "0x84B1DC0", VA = "0x1884B2DC0", Slot = "4")]
	[AsyncStateMachine(typeof(DAPCMIEGPDM))]
	public Task KOMJCAMEIOF([CanBeNull] BPLHNECCAPN MKIDPONBDDE, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
	public void GBKNJKBOIMD(BPLHNECCAPN MKIDPONBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x84B1010", Offset = "0x84B0010", VA = "0x1884B1010")]
	private void DAOGGBFBKED(GGPHJONNNGN EBPPFIKFCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x84B2AB0", Offset = "0x84B1AB0", VA = "0x1884B2AB0")]
	internal static string KDDNBJGLIJO(OCDFMHHAGGB DFOJNPMAGPB, BPLHNECCAPN MKIDPONBDDE, IReadOnlyDictionary<PFBDGKHFNEC, OFKLEEBEDFB> BAMGBIMNCEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x84B3AC0", Offset = "0x84B2AC0", VA = "0x1884B3AC0")]
	private static void ONDJJDFHOCF(BPLHNECCAPN MKIDPONBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x84B1E20", Offset = "0x84B0E20", VA = "0x1884B1E20")]
	private static void GOEGNBHCGMC(GGPHJONNNGN LDDKPIJDLPF, IReadOnlyDictionary<PFBDGKHFNEC, OFKLEEBEDFB> BAMGBIMNCEH, StringBuilder ANGPDNIFHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x84B1B20", Offset = "0x84B0B20", VA = "0x1884B1B20")]
	private static bool FBDJBOKILMN(string IOIDIAPBNEL, [Out] Guid PMIEBEDAACI, [Out] PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x84AFE20", Offset = "0x84AEE20", VA = "0x1884AFE20")]
	private static void AHCKCNBHDFB(BPLHNECCAPN MKIDPONBDDE, StringBuilder ANGPDNIFHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3924F90", Offset = "0x3923F90", VA = "0x183924F90", Slot = "16")]
	public bool PJLDDEGIJNK<T>(PFBDGKHFNEC HKANNFNOACJ, OBMOGFDJOBC NOKCCPNANAA, bool NIJJCCHEIAO, T GIOLPIPFPPJ, [Optional] Action GNHCGEEEONG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x84B5170", Offset = "0x84B4170", VA = "0x1884B5170", Slot = "17")]
	public string PMKOOMMAGFH(OBMOGFDJOBC NOKCCPNANAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x84B4D00", Offset = "0x84B3D00", VA = "0x1884B4D00")]
	private void PHCFOMLEOBG(PFBDGKHFNEC HKANNFNOACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x84B3990", Offset = "0x84B2990", VA = "0x1884B3990")]
	private bool NFKNFHNOAFH(AIPAHMNCJKP EKEPPODJHCN, PFBDGKHFNEC HKANNFNOACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x84B49C0", Offset = "0x84B39C0", VA = "0x1884B49C0")]
	internal OFKLEEBEDFB PCKGKHLPNJN(AIPAHMNCJKP EKEPPODJHCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x84B2A20", Offset = "0x84B1A20", VA = "0x1884B2A20", Slot = "13")]
	public IReadOnlyList<CFPJGPNOHCB> IKDFNMINMBM(AIPAHMNCJKP EKEPPODJHCN, bool ACKBBIOAMDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x84B33E0", Offset = "0x84B23E0", VA = "0x1884B33E0")]
	internal IReadOnlyList<OFKLEEBEDFB> MFLMNOILHOK(AIPAHMNCJKP EKEPPODJHCN, bool ACKBBIOAMDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x84B2280", Offset = "0x84B1280", VA = "0x1884B2280")]
	private void IEAEHEAPMPH(JOMFHGHJHIM BNBMOOFMDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x84B51F0", Offset = "0x84B41F0", VA = "0x1884B51F0")]
	private static bool POCMOEGPKOE(OFKLEEBEDFB HIGEAOFBLKO, IReadOnlyDictionary<PFBDGKHFNEC, OFKLEEBEDFB> BAMGBIMNCEH, [Out] IReadOnlyList<OBMOGFDJOBC> OKGPCGIEEPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x84B0560", Offset = "0x84AF560", VA = "0x1884B0560")]
	[AsyncStateMachine(typeof(HIOBCLDKEPH))]
	private static Task BGCIPFMDFBD(OCDFMHHAGGB DFOJNPMAGPB, BPLHNECCAPN MKIDPONBDDE, IReadOnlyDictionary<PFBDGKHFNEC, OFKLEEBEDFB> BAMGBIMNCEH, ABHKBFFIJLO KPKDGGHCPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x84B1350", Offset = "0x84B0350", VA = "0x1884B1350")]
	[CompilerGenerated]
	internal static void DIJFJKLDKJA(Func<DPMCODEOIFI, LAHFPFBLEBD> LKBOFLBEHID, OHDCNJBEGNH P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x84B1700", Offset = "0x84B0700", VA = "0x1884B1700")]
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
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IPKLIBACDCD([DJIFKCCBBND(null)] GIMNFOIOBOF INMKFMCLHLA, [DJIFKCCBBND(null)] BCJMCFPBBMH DGBMFJMFAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x84AE460", Offset = "0x84AD460", VA = "0x1884AE460")]
	private static MGNELHNLHHI? JBCACIFFCCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x84ADC50", Offset = "0x84ACC50", VA = "0x1884ADC50", Slot = "4")]
	public bool EHDKDANENDA(AIPAHMNCJKP FKPCNJDOKFK, AIPAHMNCJKP AMGNIPEHDKA, IEnumerable<AIPAHMNCJKP> LFHJKBOPNAB, [Out] MKGDLGMGGGP NJFJGIKBOIP, [Out] BAIGFBCBCAG CNHKLJNNAFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x84ADD50", Offset = "0x84ACD50", VA = "0x1884ADD50", Slot = "5")]
	public string EJGANONGCHM(BAIGFBCBCAG PBIIKCHJFME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x84ADE50", Offset = "0x84ACE50", VA = "0x1884ADE50")]
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

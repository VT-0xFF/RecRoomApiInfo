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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x62C39B0", Offset = "0x62C21B0", VA = "0x1862C39B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78D480", Offset = "0x78BC80", VA = "0x18078D480")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CGLOOEGKFMF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void PFPPFKBBLBD<TPermission>(TPermission JIJNIAAMIGO);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void GODEJOMPMHO(JLNLBCDKCMG LGPACJLCOIG);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FOHOMHPPMNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PPBFCMMOJFC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LCNADFIELNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NEFEGHFAGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CLMGBBNNBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NEIMOJAFPME
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool AJJLKHNJNKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CLKPEEFJEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class PNNINEMPNNP
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum HEJBFFEGPIL
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
	public static readonly Guid HMCMENAOFCD;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid FGJCLBHKHBD;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid KIACKGGIDCA;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid AHMLPMOPPDK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid PAMAFGHCDHN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid MGOKKOCJDOC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly FNHGOJEHHDC<GKJFLIMLEBM, Guid> PFDOOMCMGKG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<GKJFLIMLEBM> MOJMAJAMIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62C4880", Offset = "0x62C3080", VA = "0x1862C4880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62C4990", Offset = "0x62C3190", VA = "0x1862C4990")]
	public static GKJFLIMLEBM EMJJBKBDNPO(Guid OJPOLEONBAO)
	{
		return default(GKJFLIMLEBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62C4A20", Offset = "0x62C3220", VA = "0x1862C4A20")]
	public static Guid FHDJJDEJDMP(GKJFLIMLEBM HPMANOIFKMD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62C4900", Offset = "0x62C3100", VA = "0x1862C4900")]
	public static bool EHJEBAHFIGD(GKJFLIMLEBM HPMANOIFKMD, [Out] Guid OJPOLEONBAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62C4B70", Offset = "0x62C3370", VA = "0x1862C4B70")]
	public static bool PIIKDOCOFFM(Guid OJPOLEONBAO, [Out] GKJFLIMLEBM HPMANOIFKMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62C4800", Offset = "0x62C3000", VA = "0x1862C4800")]
	public static GKJFLIMLEBM BIFEFCDDBLG(GKJFLIMLEBM HPMANOIFKMD)
	{
		return default(GKJFLIMLEBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62C4AC0", Offset = "0x62C32C0", VA = "0x1862C4AC0")]
	public static HEJBFFEGPIL GDCFEOLCEIO(GKJFLIMLEBM ACGHOIBFAIH)
	{
		return default(HEJBFFEGPIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62C4840", Offset = "0x62C3040", VA = "0x1862C4840")]
	internal static GKJFLIMLEBM CDPMHMEOGDA(HEJBFFEGPIL DEHFDJLJKBL)
	{
		return default(GKJFLIMLEBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LLCNAFFDIOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OJBJANFGCBP EOFECEEFKLP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<KNCCMDDFJDM> JJILNKLBFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GODEJOMPMHO MJNOBHDMJJB;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<KNCCMDDFJDM> JCLPDPDPKEI(bool MHJJMBIPBBF = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KNCCMDDFJDM OIADDPIKMCE(JLNLBCDKCMG LGPACJLCOIG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MBFDDMFKEDK(JLNLBCDKCMG LGPACJLCOIG);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<KNCCMDDFJDM> LPPCDFIJOPG(JLNLBCDKCMG LGPACJLCOIG, bool GKDLACNKCJH = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BLLCOPLGLNO(JLNLBCDKCMG IDDGIEJNHBN, GKJFLIMLEBM HPMANOIFKMD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KNCCMDDFJDM ENHGDBEMALB(GKJFLIMLEBM HPMANOIFKMD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AMBDGCDONKJ<T>(GKJFLIMLEBM HPMANOIFKMD, JGCEBHAKNOE JIJNIAAMIGO, bool LCEIELLCABO, T OIFDKAEILPK) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OHNEFNGAHFI
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MJHJHEFMMEE(OGBHGJIPJCE KAGMDCLCJHI, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KICCPMFHGMG(OGBHGJIPJCE KAGMDCLCJHI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FFIDJCGDBME
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JLNLBCDKCMG BPCDKOHENOB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FAPHDJICDBI IPDBFADPDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MEGCEJKCLCC LIMNFFDICJK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<IMOCEMEPOKG> LFICCPGCDLA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action KNPCMNPKEPD;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GKJFLIMLEBM IFPLNKBEGHE(JLNLBCDKCMG LGPACJLCOIG);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IMOCEMEPOKG> OPPICEELHOE(CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task DEAMPFHIAFG(long NBNJFKJOFIF, long HEOAHEPJHCF, IReadOnlyList<HFOPJKJEADE> DHLOMDIGMPF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<JLNLBCDKCMG> NKDICLKBIGJ();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ODJJEFMHHBH
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x62C4570", Offset = "0x62C2D70", VA = "0x1862C4570")]
	public static GKJFLIMLEBM PNPLOONHLDJ(this FFIDJCGDBME GIMOEBMDCLN)
	{
		return default(GKJFLIMLEBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EAEOAJGDBJC<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string AMOGCFOEPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PFPPFKBBLBD<TPermission> BHBIIFIJMPO;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class CBJGDIMPCHI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? EEHMNEKBHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	protected CBJGDIMPCHI(object? JJEIMCAMHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DKMEDKGGILM(object? FKKGMPDEPMA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class KIBGDMNCPIO<T> : CBJGDIMPCHI where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T LDEEHDEGLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> HAFCFDDDOOP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T PENMJFOMGMH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D07D0", Offset = "0x7CEFD0", VA = "0x1807D07D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3875960", Offset = "0x3874160", VA = "0x183875960", Slot = "4")]
	public override bool DKMEDKGGILM(object? FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3875D30", Offset = "0x3874530", VA = "0x183875D30")]
	public bool PFOAFIIONEE(T EBAJCDFKCLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3876290", Offset = "0x3874A90", VA = "0x183876290")]
	public KIBGDMNCPIO(T LOJDAJFIDPG, IEqualityComparer<T> HAFCFDDDOOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class MAOOLKLGEHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<JGCEBHAKNOE, bool> FOAJAOGLEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<JGCEBHAKNOE, CBJGDIMPCHI> KDNKOAEOLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly NIAAJDNLMDA COGNCOKAOCJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62C2540", Offset = "0x62C0D40", VA = "0x1862C2540")]
	public MAOOLKLGEHI(NIAAJDNLMDA COGNCOKAOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62C24D0", Offset = "0x62C0CD0", VA = "0x1862C24D0")]
	public bool JGDPNLCCMKI(JGCEBHAKNOE JIJNIAAMIGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2431C20", Offset = "0x2430420", VA = "0x182431C20")]
	public bool DLIOCMMMBFA<T>(JGCEBHAKNOE JIJNIAAMIGO, bool LCEIELLCABO, T FKKGMPDEPMA) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2432130", Offset = "0x2430930", VA = "0x182432130")]
	public (bool, T?) HFKOMEPHPLA<T>(JGCEBHAKNOE JIJNIAAMIGO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x62C2320", Offset = "0x62C0B20", VA = "0x1862C2320")]
	public bool DLIOCMMMBFA(JGCEBHAKNOE JIJNIAAMIGO, bool LCEIELLCABO, object FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62C2400", Offset = "0x62C0C00", VA = "0x1862C2400")]
	public (bool, object) HFKOMEPHPLA(JGCEBHAKNOE JIJNIAAMIGO)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2432500", Offset = "0x2430D00", VA = "0x182432500")]
	private void MHIOPNPKOGH<T>(JGCEBHAKNOE JIJNIAAMIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x62C2250", Offset = "0x62C0A50", VA = "0x1862C2250")]
	private CBJGDIMPCHI CJOCGHJPGBF(JGCEBHAKNOE JIJNIAAMIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x62C2050", Offset = "0x62C0850", VA = "0x1862C2050")]
	public void BLJINGEKGJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class PLMNNEIPJEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string HCOINFFCEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type HKCDDKBDCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly OAOLHNJEMPM DMBLEGKGJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly JGCEBHAKNOE HNIADAMGDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public KMJFFDMLKEE LNFEJHEFBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public BDFCDOMOPFF ACGNBBDILHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public MDLGFNCBAFD PMNHBCGCHBN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62C4760", Offset = "0x62C2F60", VA = "0x1862C4760")]
	public PLMNNEIPJEP(Type CIPGIAFFCPN, string MAFCJJOEEAC, JGCEBHAKNOE JIJNIAAMIGO, KMJFFDMLKEE BGAANCEGOLN, BDFCDOMOPFF HIDBEJFLHBB, MDLGFNCBAFD LGFFGJADBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x62C4710", Offset = "0x62C2F10", VA = "0x1862C4710")]
	public object PIIMLDDAEHK(object? IFHFGCDLDEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x24F9A50", Offset = "0x24F8250", VA = "0x1824F9A50")]
	public void MHIOPNPKOGH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x62C4660", Offset = "0x62C2E60", VA = "0x1862C4660")]
	public void MHIOPNPKOGH(Type FINGJAANNKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class OFLDHBEHMEC<T> : PLMNNEIPJEP where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string HJGCJJOGOGJ(T FKKGMPDEPMA);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T AIEMDONGJDK(string? GJKOFBAHNIK, T LOJDAJFIDPG);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BKAJKPDNDJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HJGCJJOGOGJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AIEMDONGJDK parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BKAJKPDNDJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x440D380", Offset = "0x440BB80", VA = "0x18440D380")]
		internal string EHIAOAJMCDN(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x440D420", Offset = "0x440BC20", VA = "0x18440D420")]
		internal object OFMALHOHAIB(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5310", Offset = "0x3CD3B10", VA = "0x183CD5310")]
	public OFLDHBEHMEC(JGCEBHAKNOE JIJNIAAMIGO, string MAFCJJOEEAC, [Optional] HJGCJJOGOGJ? BGAANCEGOLN, [Optional] AIEMDONGJDK? HIDBEJFLHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5010", Offset = "0x3CD3810", VA = "0x183CD5010")]
	private static object? PFKIHJFLILM(AIEMDONGJDK? HIDBEJFLHBB, string? GJKOFBAHNIK, object? LOJDAJFIDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4770", Offset = "0x3CD2F70", VA = "0x183CD4770")]
	private static string BBOAPHOFBBK(HJGCJJOGOGJ? MGLLGADBECD, object? FKKGMPDEPMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string KMJFFDMLKEE(object? FKKGMPDEPMA);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object BDFCDOMOPFF(string? GJKOFBAHNIK, [Optional] object LOJDAJFIDPG);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate CBJGDIMPCHI MDLGFNCBAFD();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class NIAAJDNLMDA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class JAMGPIOFEGP : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static JAMGPIOFEGP FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62BFB30", Offset = "0x62BE330", VA = "0x1862BFB30", Slot = "4")]
		public bool Equals(List<string> IILAPOMEGLM, List<string> BNBBAPGFCCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62BFC80", Offset = "0x62BE480", VA = "0x1862BFC80", Slot = "5")]
		public int GetHashCode(List<string> CBBCDNDPNHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public JAMGPIOFEGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class FMOJKMNOPPL : NPAPAIDMBBP<CGLOOEGKFMF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62BECA0", Offset = "0x62BD4A0", VA = "0x1862BECA0", Slot = "9")]
		public override string BBOAPHOFBBK(CGLOOEGKFMF EIGOIPKAPOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62BED90", Offset = "0x62BD590", VA = "0x1862BED90", Slot = "10")]
		protected override bool EKNKDDKBKKA(string EIGOIPKAPOI, [Out] CGLOOEGKFMF FKKGMPDEPMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62BEF70", Offset = "0x62BD770", VA = "0x1862BEF70")]
		public FMOJKMNOPPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly LPDMFHFNAFL MKLHCJNFNDI;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly FMOJKMNOPPL LOCCIPCFNJL;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<PLMNNEIPJEP> CHKHEIJBJLL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<JGCEBHAKNOE> FGNNGDFAJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<JGCEBHAKNOE, PLMNNEIPJEP> DBGJEPACOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62C3660", Offset = "0x62C1E60", VA = "0x1862C3660")]
	public NIAAJDNLMDA([Optional] IList<PLMNNEIPJEP>? JBBHEKIFLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62C27F0", Offset = "0x62C0FF0", VA = "0x1862C27F0")]
	public PLMNNEIPJEP CKIEHCIFGIB(JGCEBHAKNOE JIJNIAAMIGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OJBJANFGCBP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KNCCMDDFJDM JAFEFONOLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class OABEIOBPHLG : OJBJANFGCBP
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static OABEIOBPHLG PCHKBMHNIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly KBGOBICGKJH CCDMBANJAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<KBGOBICGKJH> NPCPLMCLGMG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public KNCCMDDFJDM JAFEFONOLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x62C4460", Offset = "0x62C2C60", VA = "0x1862C4460")]
	public OABEIOBPHLG(KBGOBICGKJH DEOBNKOCBGO, IReadOnlyList<KBGOBICGKJH> NMAGAMHALMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x62C3A30", Offset = "0x62C2230", VA = "0x1862C3A30")]
	private static OABEIOBPHLG FFHFBAEADBG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class DLALADKCDAK
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<GKJFLIMLEBM> DBFHODKENHB;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x62BE150", Offset = "0x62BC950", VA = "0x1862BE150")]
	public static bool JBKFAHLDPFC(this JLNLBCDKCMG AKFGFNBMNIF, GKJFLIMLEBM HPMANOIFKMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x62BE0D0", Offset = "0x62BC8D0", VA = "0x1862BE0D0")]
	public static bool DNGKOMEGEKO(this JLNLBCDKCMG AKFGFNBMNIF, GKJFLIMLEBM HPMANOIFKMD, MEGCEJKCLCC FMODJNJIODP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface PHDIFHKKDJH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool MIBJMLNGKEB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool PGAMFFDADGE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool EJOLICBNDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool GPDOBJOMFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool HAJNJJMCMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ICOPBFLIJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MMJJKLKKJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool MACOKAOFHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool FGEBKNIKMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GIEAHMNMLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool GCBAJMDDKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JMBENFHJHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> FLBPFABMLPA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	CGLOOEGKFMF GCOHNOJJBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KNCCMDDFJDM : PHDIFHKKDJH, PPBFCMMOJFC, EAEOAJGDBJC<JGCEBHAKNOE>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string MMGJBAMGPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	GKJFLIMLEBM HPCHAJOADHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) AJNODABJMCO<T>(JGCEBHAKNOE JIJNIAAMIGO) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum JGCEBHAKNOE
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class KBGOBICGKJH : KNCCMDDFJDM, PHDIFHKKDJH, PPBFCMMOJFC, EAEOAJGDBJC<JGCEBHAKNOE>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly NIAAJDNLMDA CCHEHELHAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly MAOOLKLGEHI NAMIEKCLOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? OCPDHJDNAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? OFOBOGGLMPD;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool CFBODAPDPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62C1250", Offset = "0x62BFA50", VA = "0x1862C1250", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool FIJKJGDCAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x62C1010", Offset = "0x62BF810", VA = "0x1862C1010", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool IDEEPKJCFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x62C1060", Offset = "0x62BF860", VA = "0x1862C1060", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool BOCLBOHLDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x62C0330", Offset = "0x62BEB30", VA = "0x1862C0330", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool NLBIAECCAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x62C1530", Offset = "0x62BFD30", VA = "0x1862C1530", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool EPANBIGKIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x62BFE70", Offset = "0x62BE670", VA = "0x1862BFE70", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public GKJFLIMLEBM HPCHAJOADHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7D07D0", Offset = "0x7CEFD0", VA = "0x1807D07D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(GKJFLIMLEBM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x770F70", Offset = "0x76F770", VA = "0x180770F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string AMOGCFOEPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x62C15D0", Offset = "0x62BFDD0", VA = "0x1862C15D0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x62C03D0", Offset = "0x62BEBD0", VA = "0x1862C03D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string MMGJBAMGPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x62C15D0", Offset = "0x62BFDD0", VA = "0x1862C15D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool CFONBNIIELD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7D3A30", Offset = "0x7D2230", VA = "0x1807D3A30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7D32A0", Offset = "0x7D1AA0", VA = "0x1807D32A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool MIBJMLNGKEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x62C10B0", Offset = "0x62BF8B0", VA = "0x1862C10B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public CGLOOEGKFMF GCOHNOJJBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x62C1100", Offset = "0x62BF900", VA = "0x1862C1100", Slot = "20")]
		get
		{
			return default(CGLOOEGKFMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PGAMFFDADGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x62C0440", Offset = "0x62BEC40", VA = "0x1862C0440", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool EJOLICBNDOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x62C12F0", Offset = "0x62BFAF0", VA = "0x1862C12F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GPDOBJOMFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62C0380", Offset = "0x62BEB80", VA = "0x1862C0380", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool HAJNJJMCMFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62C1B30", Offset = "0x62C0330", VA = "0x1862C1B30", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ICOPBFLIJDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x62C1CB0", Offset = "0x62C04B0", VA = "0x1862C1CB0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MMJJKLKKJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x62C19A0", Offset = "0x62C01A0", VA = "0x1862C19A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool MACOKAOFHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x62C19F0", Offset = "0x62C01F0", VA = "0x1862C19F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool FGEBKNIKMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x62C1A40", Offset = "0x62C0240", VA = "0x1862C1A40", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> FLBPFABMLPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x62C14D0", Offset = "0x62BFCD0", VA = "0x1862C14D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool IBNGHPCKFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x62C1250", Offset = "0x62BFA50", VA = "0x1862C1250", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool NHECAEDCOLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x62C1530", Offset = "0x62BFD30", VA = "0x1862C1530", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool EABGPALBMMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x62C1010", Offset = "0x62BF810", VA = "0x1862C1010", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GIEAHMNMLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x62C1AE0", Offset = "0x62C02E0", VA = "0x1862C1AE0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GCBAJMDDKON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x62C1A90", Offset = "0x62C0290", VA = "0x1862C1A90", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool ILDDGGMMBND
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x62C1060", Offset = "0x62BF860", VA = "0x1862C1060", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JMBENFHJHBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x62C12A0", Offset = "0x62BFAA0", VA = "0x1862C12A0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LMGNEDMKOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x62C0330", Offset = "0x62BEB30", VA = "0x1862C0330", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GMHMOAIPHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x62BFE70", Offset = "0x62BE670", VA = "0x1862BFE70", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event PFPPFKBBLBD<JGCEBHAKNOE> BHBIIFIJMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62C1C00", Offset = "0x62C0400", VA = "0x1862C1C00", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x62C1420", Offset = "0x62BFC20", VA = "0x1862C1420", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x23F9DA0", Offset = "0x23F85A0", VA = "0x1823F9DA0", Slot = "6")]
	public (bool, T?) AJNODABJMCO<T>(JGCEBHAKNOE JIJNIAAMIGO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x23F9F30", Offset = "0x23F8730", VA = "0x1823F9F30")]
	public KBGOBICGKJH AKDBNDHKOAJ<T>(JGCEBHAKNOE JIJNIAAMIGO, bool LCEIELLCABO, T FKKGMPDEPMA) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x62C1E20", Offset = "0x62C0620", VA = "0x1862C1E20")]
	public KBGOBICGKJH(GKJFLIMLEBM HPMANOIFKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x62C2030", Offset = "0x62C0830", VA = "0x1862C2030")]
	public KBGOBICGKJH(GKJFLIMLEBM HPMANOIFKMD, [Optional] string? OCPDHJDNAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x62C1E40", Offset = "0x62C0640", VA = "0x1862C1E40")]
	public KBGOBICGKJH(KBGOBICGKJH BKDJBIJPPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62C1ED0", Offset = "0x62C06D0", VA = "0x1862C1ED0")]
	internal KBGOBICGKJH(GKJFLIMLEBM HNJLCJKEJAD, [Optional] string? OCPDHJDNAAP, [Optional] KBGOBICGKJH? BKDJBIJPPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x62C1B80", Offset = "0x62C0380", VA = "0x1862C1B80")]
	public static OAOLHNJEMPM LJODEOEFDCK(JGCEBHAKNOE JIJNIAAMIGO)
	{
		return default(OAOLHNJEMPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x62C0420", Offset = "0x62BEC20", VA = "0x1862C0420")]
	public void BLJINGEKGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x62C1620", Offset = "0x62BFE20", VA = "0x1862C1620")]
	internal KBGOBICGKJH IOCBHDGBGCL(KBGOBICGKJH MECCBCHCPGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x62BFEC0", Offset = "0x62BE6C0", VA = "0x1862BFEC0")]
	internal IReadOnlyCollection<JGCEBHAKNOE> APFJFNBJOAO(KBGOBICGKJH BKDJBIJPPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x62C1340", Offset = "0x62BFB40", VA = "0x1862C1340")]
	public bool GGDPAIDKBNI(JGCEBHAKNOE JIJNIAAMIGO, bool LCEIELLCABO, string KKGIEAENIJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62C1150", Offset = "0x62BF950", VA = "0x1862C1150")]
	public (bool, string) FACHNDOKKLN(JGCEBHAKNOE JIJNIAAMIGO)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x62C1580", Offset = "0x62BFD80", VA = "0x1862C1580")]
	internal void IGMBMDAGBBL(JGCEBHAKNOE JIJNIAAMIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x62C0490", Offset = "0x62BEC90", VA = "0x1862C0490")]
	public LFJPNGJOKEF CKFLEABPNCE(Func<GKJFLIMLEBM, Guid> OICLBKJJHAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x62C0690", Offset = "0x62BEE90", VA = "0x1862C0690")]
	public void CMBHAJDLIEG(LFJPNGJOKEF EJMLFEGEAJA, Func<Guid, GKJFLIMLEBM> NCLGHIIEODI, [Optional] GKJFLIMLEBM? PEIMFOGCGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x62C1D00", Offset = "0x62C0500", VA = "0x1862C1D00")]
	[CompilerGenerated]
	private void PCDACKENLMA(JGCEBHAKNOE GKEECGAPCAD, KPIDLPGBEPB AIJCNJILDPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AAENOKPLCJK : OHNEFNGAHFI, LLCNAFFDIOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class ABCJONGBDGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public KBGOBICGKJH newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ABCJONGBDGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x62BD840", Offset = "0x62BC040", VA = "0x1862BD840")]
		internal bool NIPLOAGAAKO(KBGOBICGKJH rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class GFNMKHMIHMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public GKJFLIMLEBM roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public GFNMKHMIHMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x62BEFB0", Offset = "0x62BD7B0", VA = "0x1862BEFB0")]
		internal bool CPMCKKPAOJE(GKJFLIMLEBM r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct ENOGBEGKDLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AAENOKPLCJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public OGBHGJIPJCE roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<IMOCEMEPOKG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x62BE5E0", Offset = "0x62BCDE0", VA = "0x1862BE5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x62BEC40", Offset = "0x62BD440", VA = "0x1862BEC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EJHOOANNNPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public EJHOOANNNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x62BE3E0", Offset = "0x62BCBE0", VA = "0x1862BE3E0")]
		internal void NHCIHOOPKLP(LFJPNGJOKEF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x62BE4C0", Offset = "0x62BCCC0", VA = "0x1862BE4C0")]
		internal void NLOCPNEIOJM(LFJPNGJOKEF r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct MOINKFDLEAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public OGBHGJIPJCE roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PAPODAEKOFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<LFJPNGJOKEF, KPIDLPGBEPB> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public PAPODAEKOFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x62C4630", Offset = "0x62C2E30", VA = "0x1862C4630")]
		internal void ODCCILHEBOH(LFJPNGJOKEF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x62C45D0", Offset = "0x62C2DD0", VA = "0x1862C45D0")]
		internal void EDIDONGPBBB(LFJPNGJOKEF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x62C4600", Offset = "0x62C2E00", VA = "0x1862C4600")]
		internal void HCHEPALBLFB(LFJPNGJOKEF r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FFPHPNDEHHC<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public FFPHPNDEHHC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private TaskAwaiter<IMOCEMEPOKG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2E8E430", Offset = "0x2E8CC30", VA = "0x182E8E430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x840DA0", Offset = "0x83F5A0", VA = "0x180840DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AAENOKPLCJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JGCEBHAKNOE rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GKJFLIMLEBM accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public OAOLHNJEMPM recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FFPHPNDEHHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x340E160", Offset = "0x340C960", VA = "0x18340E160")]
		[AsyncStateMachine(typeof(FFPHPNDEHHC<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void KJCPCMCIEFN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct NDMGGAIBADA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<HFOPJKJEADE> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GPHFGNAECEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FFIDJCGDBME rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public OGBHGJIPJCE roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<GKJFLIMLEBM, KBGOBICGKJH> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public PEBGCLKOELH debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x62BEFC0", Offset = "0x62BD7C0", VA = "0x1862BEFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x62BFAD0", Offset = "0x62BE2D0", VA = "0x1862BFAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly FFIDJCGDBME GIMOEBMDCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly OABEIOBPHLG DOBIPLILKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PEBGCLKOELH AALLGIODHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, KBGOBICGKJH> JJGOFCOMKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<GKJFLIMLEBM, KBGOBICGKJH> CAGEJJLOFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<GKJFLIMLEBM, KBGOBICGKJH> BBNEIMHFOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<KBGOBICGKJH> BMHCIPGAGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool HCIOFBIPEKP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly JGCEBHAKNOE[] GKLCALIOAAH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public OJBJANFGCBP EOFECEEFKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<KNCCMDDFJDM> JJILNKLBFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x62BB7C0", Offset = "0x62B9FC0", VA = "0x1862BB7C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event GODEJOMPMHO MJNOBHDMJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x62BA100", Offset = "0x62B8900", VA = "0x1862BA100", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x62BA060", Offset = "0x62B8860", VA = "0x1862BA060", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x62BC0B0", Offset = "0x62BA8B0", VA = "0x1862BC0B0")]
	[NJKKEFDLCAD(CEDKDBJGKHF.Room, AFMDLPKJFNK.None)]
	private static void PFJBINLDPOI(LLKIHBKOOLA OBCMACCCGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x62BD580", Offset = "0x62BBD80", VA = "0x1862BD580")]
	[UnityEngine.Scripting.Preserve]
	internal AAENOKPLCJK([KEKICHOEFEB(null)] FFIDJCGDBME KHGJGLFFAIF, [KEKICHOEFEB(null)] OABEIOBPHLG LNFEBHENPIJ, [KEKICHOEFEB(null)] PEBGCLKOELH AALLGIODHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x62B9640", Offset = "0x62B7E40", VA = "0x1862B9640", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x62B8850", Offset = "0x62B7050", VA = "0x1862B8850")]
	private void BLBCDJDPPCM(IEnumerable<KBGOBICGKJH> MAONCADOPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x62BABD0", Offset = "0x62B93D0", VA = "0x1862BABD0", Slot = "12")]
	public bool MBFDDMFKEDK(JLNLBCDKCMG LGPACJLCOIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x62BA570", Offset = "0x62B8D70", VA = "0x1862BA570")]
	private void KNPCMNPKEPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x62B9E70", Offset = "0x62B8670", VA = "0x1862B9E70")]
	private void FPFKHDAAKJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x62BA4F0", Offset = "0x62B8CF0", VA = "0x1862BA4F0", Slot = "10")]
	public IReadOnlyList<KNCCMDDFJDM> JCLPDPDPKEI(bool MHJJMBIPBBF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x62BB810", Offset = "0x62BA010", VA = "0x1862BB810", Slot = "11")]
	public KNCCMDDFJDM OIADDPIKMCE(JLNLBCDKCMG LGPACJLCOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x62BB240", Offset = "0x62B9A40", VA = "0x1862BB240")]
	private GKJFLIMLEBM NOCECGLPHHG(JLNLBCDKCMG LGPACJLCOIG)
	{
		return default(GKJFLIMLEBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x62B90D0", Offset = "0x62B78D0", VA = "0x1862B90D0", Slot = "14")]
	public bool BLLCOPLGLNO(JLNLBCDKCMG IDDGIEJNHBN, GKJFLIMLEBM HPMANOIFKMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x62B9DD0", Offset = "0x62B85D0", VA = "0x1862B9DD0", Slot = "15")]
	public KNCCMDDFJDM ENHGDBEMALB(GKJFLIMLEBM HPMANOIFKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x62BC270", Offset = "0x62BAA70", VA = "0x1862BC270")]
	private static bool PKBNODFCMOF(NNGHOBBHANP PKAHHFACHLF, GKJFLIMLEBM HPMANOIFKMD, [Out] LFJPNGJOKEF? GAMIJNALJFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x62B9CE0", Offset = "0x62B84E0", VA = "0x1862B9CE0")]
	private static void EMOBFGFKLKK(NNGHOBBHANP PKAHHFACHLF, Action<LFJPNGJOKEF> GNEIDJFPILF, GKJFLIMLEBM LNEIJKGBKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x62B9A50", Offset = "0x62B8250", VA = "0x1862B9A50")]
	private static void EMOBFGFKLKK(NNGHOBBHANP PKAHHFACHLF, Action<LFJPNGJOKEF> GNEIDJFPILF, Predicate<GKJFLIMLEBM> KIILFLMMCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x62B9490", Offset = "0x62B7C90", VA = "0x1862B9490")]
	private void CILGNEKGOMH(JLNLBCDKCMG LGPACJLCOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x62BACA0", Offset = "0x62B94A0", VA = "0x1862BACA0", Slot = "4")]
	[AsyncStateMachine(typeof(ENOGBEGKDLE))]
	public Task MJHJHEFMMEE([CanBeNull] OGBHGJIPJCE KAGMDCLCJHI, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
	public void KICCPMFHGMG(OGBHGJIPJCE KAGMDCLCJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x62B7DD0", Offset = "0x62B65D0", VA = "0x1862B7DD0")]
	private void BFFMNLCNKOD(NNGHOBBHANP NLCNDKMOMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x62B9750", Offset = "0x62B7F50", VA = "0x1862B9750")]
	internal static string EHJFMDFPAFA(FFIDJCGDBME GIMOEBMDCLN, OGBHGJIPJCE KAGMDCLCJHI, IReadOnlyDictionary<GKJFLIMLEBM, KBGOBICGKJH> CAGEJJLOFPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x62BC5A0", Offset = "0x62BADA0", VA = "0x1862BC5A0")]
	private static void PKDHNODGBFN(OGBHGJIPJCE KAGMDCLCJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x62BA1A0", Offset = "0x62B89A0", VA = "0x1862BA1A0")]
	private static void HPDAMIKEMDA(NNGHOBBHANP FIGLCADLMHO, IReadOnlyDictionary<GKJFLIMLEBM, KBGOBICGKJH> CAGEJJLOFPH, StringBuilder EGFHEKBKNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x62BB130", Offset = "0x62B9930", VA = "0x1862BB130")]
	private static bool NFDLAPJPFOJ(string EDNPGODEKPC, [Out] Guid OIPOCODJIHI, [Out] GKJFLIMLEBM HPMANOIFKMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x62B8110", Offset = "0x62B6910", VA = "0x1862B8110")]
	private static void BIAILBDANPP(OGBHGJIPJCE KAGMDCLCJHI, StringBuilder EGFHEKBKNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2995690", Offset = "0x2993E90", VA = "0x182995690", Slot = "16")]
	public bool AMBDGCDONKJ<T>(GKJFLIMLEBM HPMANOIFKMD, JGCEBHAKNOE JIJNIAAMIGO, bool LCEIELLCABO, T OIFDKAEILPK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x62BB310", Offset = "0x62B9B10", VA = "0x1862BB310")]
	private void NOCOAHFCMCE(GKJFLIMLEBM HPMANOIFKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x62B7DB0", Offset = "0x62B65B0", VA = "0x1862B7DB0")]
	private bool APKJGDMPMFO(JLNLBCDKCMG LGPACJLCOIG, GKJFLIMLEBM HPMANOIFKMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x62BA870", Offset = "0x62B9070", VA = "0x1862BA870")]
	internal KBGOBICGKJH LJBJBMFCFLN(JLNLBCDKCMG LGPACJLCOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x62BABC0", Offset = "0x62B93C0", VA = "0x1862BABC0", Slot = "13")]
	public IReadOnlyList<KNCCMDDFJDM> LPPCDFIJOPG(JLNLBCDKCMG LGPACJLCOIG, bool GKDLACNKCJH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x62B9260", Offset = "0x62B7A60", VA = "0x1862B9260")]
	internal IReadOnlyList<KBGOBICGKJH> CFLCFLKKALH(JLNLBCDKCMG LGPACJLCOIG, bool GKDLACNKCJH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x62BB920", Offset = "0x62BA120", VA = "0x1862BB920")]
	private void OJMPDGJJCBD(IMOCEMEPOKG BGNCIFHLPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x62BA580", Offset = "0x62B8D80", VA = "0x1862BA580")]
	private static bool LHJHFEOLHCK(KBGOBICGKJH BKHAINDBBBL, IReadOnlyDictionary<GKJFLIMLEBM, KBGOBICGKJH> CAGEJJLOFPH, [Out] IReadOnlyList<JGCEBHAKNOE> FOKPPAFFOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x62B9500", Offset = "0x62B7D00", VA = "0x1862B9500")]
	[AsyncStateMachine(typeof(GPHFGNAECEM))]
	private static Task DLFGEDDHKIN(FFIDJCGDBME GIMOEBMDCLN, OGBHGJIPJCE KAGMDCLCJHI, IReadOnlyDictionary<GKJFLIMLEBM, KBGOBICGKJH> CAGEJJLOFPH, PEBGCLKOELH AALLGIODHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x62BB520", Offset = "0x62B9D20", VA = "0x1862BB520")]
	[CompilerGenerated]
	internal static void ODPBDILJKKK(Func<LFJPNGJOKEF, KPIDLPGBEPB> NFJCDCHLMCE, MOINKFDLEAO P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x62BADC0", Offset = "0x62B95C0", VA = "0x1862BADC0")]
	[CompilerGenerated]
	internal static bool MNCENODPELF(GKJFLIMLEBM HPMANOIFKMD, JGCEBHAKNOE JIJNIAAMIGO, [Out] HFOPJKJEADE BECGKCKMAAI, NDMGGAIBADA P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BCNFGMKJLEB
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNLNLGIGDIN(JLNLBCDKCMG BDGKDAAJHIN, JLNLBCDKCMG AHPJHAAIJCK, IEnumerable<JLNLBCDKCMG> AFELKFAJKCL, [Out] CGLOOEGKFMF FJLBLAACBNF, [Out] HDBDIODPNII EPEEJIEFEKJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JJILJIBEAPC(HDBDIODPNII EBJHDKCOIMK);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum HDBDIODPNII : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class CCHMFCICFIM : BCNFGMKJLEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LLCNAFFDIOC BBLMPALNAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly EBEJDEHBKCB JLNJLGFPIIA;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7619F0", Offset = "0x7601F0", VA = "0x1807619F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CCHMFCICFIM([KEKICHOEFEB(null)] LLCNAFFDIOC BKCLMFOJAJA, [KEKICHOEFEB(null)] EBEJDEHBKCB AAFOFKHIJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x62BDE90", Offset = "0x62BC690", VA = "0x1862BDE90")]
	private static OLKIIONHPOO? GIIMLCKJAND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x62BDED0", Offset = "0x62BC6D0", VA = "0x1862BDED0", Slot = "4")]
	public bool HNLNLGIGDIN(JLNLBCDKCMG BDGKDAAJHIN, JLNLBCDKCMG AHPJHAAIJCK, IEnumerable<JLNLBCDKCMG> AFELKFAJKCL, [Out] CGLOOEGKFMF FJLBLAACBNF, [Out] HDBDIODPNII EPEEJIEFEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x62BDFD0", Offset = "0x62BC7D0", VA = "0x1862BDFD0", Slot = "5")]
	public string JJILJIBEAPC(HDBDIODPNII EBJHDKCOIMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x62BD870", Offset = "0x62BC070", VA = "0x1862BD870")]
	internal bool CJLHOHPGKAC(JLNLBCDKCMG BDGKDAAJHIN, JLNLBCDKCMG AHPJHAAIJCK, IEnumerable<JLNLBCDKCMG> AFELKFAJKCL, MEGCEJKCLCC FMODJNJIODP, OLKIIONHPOO? CHMOALNMBOD, [Out] CGLOOEGKFMF FJLBLAACBNF, [Out] HDBDIODPNII EPEEJIEFEKJ)
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

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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67B0A30", Offset = "0x67AFC30", VA = "0x1867B0A30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum AIAMNFIDPJH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void PKLLNOFPADE<TPermission>(TPermission FMHMPBCJLOK);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void KOELBOELJJB(HIKDHAMGKKP CNFKLDMHALN);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum GBFMALHCPHA
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GCPOEMNNOCA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OONKIKGKOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool GKEMBHCBOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GBNAIJKDLHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FDOEOMCDKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GCHOAHDLAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MAGDLLLKLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class EMIPPDGHKHO
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum APKLCOOCEHM
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
	public static readonly Guid CMNMHLJJCGG;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid KPKMICFHOOI;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid DKIEKGOFNHC;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid KOFCLFMGJOO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid AJBOGCFABIB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid LDDFIKHFBNI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly KAHFDMOGNCF<GGFLPAJCNPO, Guid> LKLKDEFAEIB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<GGFLPAJCNPO> PFEBHFGKOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x67A9160", Offset = "0x67A8360", VA = "0x1867A9160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67A91D0", Offset = "0x67A83D0", VA = "0x1867A91D0")]
	public static GGFLPAJCNPO OJLMKMCJLKD(Guid JJMGPACFMMB)
	{
		return default(GGFLPAJCNPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67A8E60", Offset = "0x67A8060", VA = "0x1867A8E60")]
	public static Guid FCMHKMALJMG(GGFLPAJCNPO GLJGOCGHKHL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x67A9020", Offset = "0x67A8220", VA = "0x1867A9020")]
	public static bool HIEMLONLLHC(GGFLPAJCNPO GLJGOCGHKHL, [Out] Guid JJMGPACFMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x67A8F80", Offset = "0x67A8180", VA = "0x1867A8F80")]
	public static bool HGIMICAOOKF(Guid JJMGPACFMMB, [Out] GGFLPAJCNPO GLJGOCGHKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x67A8F00", Offset = "0x67A8100", VA = "0x1867A8F00")]
	public static GGFLPAJCNPO FGAALEEGAMG(GGFLPAJCNPO GLJGOCGHKHL)
	{
		return default(GGFLPAJCNPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67A90B0", Offset = "0x67A82B0", VA = "0x1867A90B0")]
	public static APKLCOOCEHM KKLFKKIBDNH(GGFLPAJCNPO HCIEOODIEPK)
	{
		return default(APKLCOOCEHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x67A8F40", Offset = "0x67A8140", VA = "0x1867A8F40")]
	internal static GGFLPAJCNPO GDCIFHAIFKA(APKLCOOCEHM OKEALIJFOKH)
	{
		return default(GGFLPAJCNPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FCBIKEPAMHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NIPHJIFFEHO MFGJPGHBFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<NJCOMNIODCJ> GPHBKBMPKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KOELBOELJJB HDCCDBMKLEB;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<NJCOMNIODCJ> IHMOKOFOAGO(bool IEMIPJOLAEL = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NJCOMNIODCJ FHIEBFBAONN(HIKDHAMGKKP CNFKLDMHALN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DAGJLLPEBJL(HIKDHAMGKKP CNFKLDMHALN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<NJCOMNIODCJ> EIAEEFCMLCB(HIKDHAMGKKP CNFKLDMHALN, bool FIPEEOODLEG = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HDJIKMGHLGK(HIKDHAMGKKP LEPECKKEAML, GGFLPAJCNPO GLJGOCGHKHL);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NJCOMNIODCJ DAKCNMBBKIB(GGFLPAJCNPO GLJGOCGHKHL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BFEIAKHPKBH<T>(GGFLPAJCNPO GLJGOCGHKHL, BGGEDFANOCK FMHMPBCJLOK, bool AFPPPEFKLDG, T INFIIIMCAKM, [Optional] Action ECEJJFAJHNL) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JBDPGBFFIAA
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IGFJHEDJDNE(KCKCHBANCCN MDDPLLFCMCP, CancellationToken IOOGCHJMBIE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNEBAMOFJLB(KCKCHBANCCN MDDPLLFCMCP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PNCLFHOGAOD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HIKDHAMGKKP HGNBJNACNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FFGHPCFGFAO MEBKKJLKJHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OLCGENEEPKG OGELOJJMNGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GDAMKJDBEKB> BENIDCLBFAJ;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GHOCHDAIODP;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GGFLPAJCNPO KDPBNHCPLLF(HIKDHAMGKKP CNFKLDMHALN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GDAMKJDBEKB> HOIANGNMMBH(CancellationToken IOOGCHJMBIE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MCDHMHDPJII(long AFFIJANPBLG, long OHAIPPKJCDJ, IReadOnlyList<GDLBMIBGIEO> EIPBFJIEEGM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<HIKDHAMGKKP> PEEBHDNLKFD();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DCHNDPDLNOI
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67A75A0", Offset = "0x67A67A0", VA = "0x1867A75A0")]
	public static GGFLPAJCNPO FBDJLGLNJML(this PNCLFHOGAOD IPIKCPPHKHI)
	{
		return default(GGFLPAJCNPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PNAHIMHNACA<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string BIJHEPLHLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PKLLNOFPADE<TPermission> DOMKNNOFGKK;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class MIBIPJKBFMA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? IHEOIHMEGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	protected MIBIPJKBFMA(object? OAJPFOIPJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool MPDNNEIICMH(object? EKDDCPALANJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class JAGGPLIEGDN<T> : MIBIPJKBFMA where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T NLDHOKFCMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> CFNACOMKDNJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T LJLHDNLHLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82DA00", Offset = "0x82CC00", VA = "0x18082DA00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEAE0", Offset = "0x3BDDCE0", VA = "0x183BDEAE0", Slot = "4")]
	public override bool MPDNNEIICMH(object? EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEEA0", Offset = "0x3BDE0A0", VA = "0x183BDEEA0")]
	public bool ODONKBODLGL(T DIFJFLOFNLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF1D0", Offset = "0x3BDE3D0", VA = "0x183BDF1D0")]
	public JAGGPLIEGDN(T LKGDLFBLIFL, IEqualityComparer<T> CFNACOMKDNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PJEMJDBFPML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<BGGEDFANOCK, bool> HCIPIHBLLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<BGGEDFANOCK, MIBIPJKBFMA> MLBGIPKEACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly BIEPECNAFFL JKJPDJPJJMH;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67B0FA0", Offset = "0x67B01A0", VA = "0x1867B0FA0")]
	public PJEMJDBFPML(BIEPECNAFFL JKJPDJPJJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x67B0F30", Offset = "0x67B0130", VA = "0x1867B0F30")]
	public bool OIHIIPEAMLC(BGGEDFANOCK FMHMPBCJLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A11780", Offset = "0x2A10980", VA = "0x182A11780")]
	public bool FOCFOMNJLEM<T>(BGGEDFANOCK FMHMPBCJLOK, bool AFPPPEFKLDG, T EKDDCPALANJ) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A113B0", Offset = "0x2A105B0", VA = "0x182A113B0")]
	public (bool, T?) ALIACOEHJHO<T>(BGGEDFANOCK FMHMPBCJLOK) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x67B0D80", Offset = "0x67AFF80", VA = "0x1867B0D80")]
	public bool FOCFOMNJLEM(BGGEDFANOCK FMHMPBCJLOK, bool AFPPPEFKLDG, object EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67B0AC0", Offset = "0x67AFCC0", VA = "0x1867B0AC0")]
	public (bool, object) ALIACOEHJHO(BGGEDFANOCK FMHMPBCJLOK)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A11C60", Offset = "0x2A10E60", VA = "0x182A11C60")]
	private void OLINPBJOGLC<T>(BGGEDFANOCK FMHMPBCJLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x67B0E60", Offset = "0x67B0060", VA = "0x1867B0E60")]
	private MIBIPJKBFMA KADHDHLMDNO(BGGEDFANOCK FMHMPBCJLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x67B0B90", Offset = "0x67AFD90", VA = "0x1867B0B90")]
	public void FCKCGPJIDLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class AJGMGNEKAFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string BJGHKOAJBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type MDMBKAGMDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly ICIBJNFKPBG BNNADIOBAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly BGGEDFANOCK OKCMJNOGOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public BCCBHGKIBFI DMMJMDDBFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public GMNGLNNNJAL PBLGIHOAGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NLJELAHBHIA ABDEDJNHIEL;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x67A3B70", Offset = "0x67A2D70", VA = "0x1867A3B70")]
	public AJGMGNEKAFN(Type BFCDKHCBOIF, string HHFPCNEJHHB, BGGEDFANOCK FMHMPBCJLOK, BCCBHGKIBFI DDKLMNEDMBF, GMNGLNNNJAL JFCHEFIEAHJ, NLJELAHBHIA LBEKPNMPHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x67A3A70", Offset = "0x67A2C70", VA = "0x1867A3A70")]
	public object JBAOMOCFBBG(object? MEJMHKPOODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2EABF70", Offset = "0x2EAB170", VA = "0x182EABF70")]
	public void OLINPBJOGLC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x67A3AC0", Offset = "0x67A2CC0", VA = "0x1867A3AC0")]
	public void OLINPBJOGLC(Type OBMAPHDPAMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class DLIBLCNGCFD<T> : AJGMGNEKAFN where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string GIIKPOFALLA(T EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T NPFBFLKKFAN(string? OOEIDIMDDAF, T LKGDLFBLIFL);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BHPNJAGIJEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GIIKPOFALLA serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NPFBFLKKFAN parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public BHPNJAGIJEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x47C3700", Offset = "0x47C2900", VA = "0x1847C3700")]
		internal string GKHFFIHJBKA(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x47C3670", Offset = "0x47C2870", VA = "0x1847C3670")]
		internal object EHOPPBADEDD(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x50A16A0", Offset = "0x50A08A0", VA = "0x1850A16A0")]
	public DLIBLCNGCFD(BGGEDFANOCK FMHMPBCJLOK, string HHFPCNEJHHB, [Optional] GIIKPOFALLA? DDKLMNEDMBF, [Optional] NPFBFLKKFAN? JFCHEFIEAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x50A0E30", Offset = "0x50A0030", VA = "0x1850A0E30")]
	private static object? MAOCPLNNJJM(NPFBFLKKFAN? JFCHEFIEAHJ, string? OOEIDIMDDAF, object? LKGDLFBLIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x50A0B90", Offset = "0x509FD90", VA = "0x1850A0B90")]
	private static string JCBMCDNAHJB(GIIKPOFALLA? GEIIEBDKAGH, object? EKDDCPALANJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string BCCBHGKIBFI(object? EKDDCPALANJ);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object GMNGLNNNJAL(string? OOEIDIMDDAF, [Optional] object LKGDLFBLIFL);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate MIBIPJKBFMA NLJELAHBHIA();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class BIEPECNAFFL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class KMEPNHPCEIO : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static KMEPNHPCEIO EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x67B0370", Offset = "0x67AF570", VA = "0x1867B0370", Slot = "4")]
		public bool Equals(List<string> EFCGILCAOIA, List<string> DDIIOJEJOLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x67B04C0", Offset = "0x67AF6C0", VA = "0x1867B04C0", Slot = "5")]
		public int GetHashCode(List<string> GLMGCMELGFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public KMEPNHPCEIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class KMMEPJNJAFA : AKGKDELNPCP<AIAMNFIDPJH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x67B06A0", Offset = "0x67AF8A0", VA = "0x1867B06A0", Slot = "9")]
		public override string JCBMCDNAHJB(AIAMNFIDPJH BHCBEHDFPNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x67B0790", Offset = "0x67AF990", VA = "0x1867B0790", Slot = "10")]
		protected override bool LJLECNJOIOC(string BHCBEHDFPNA, [Out] AIAMNFIDPJH EKDDCPALANJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x67B0960", Offset = "0x67AFB60", VA = "0x1867B0960")]
		public KMMEPJNJAFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly MHEJIFJIOEN JHHNOECLCHH;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly KMMEPJNJAFA CKMHANAJFKB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<AJGMGNEKAFN> JKGMGLMHMMA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<BGGEDFANOCK> DIGCFJFGGMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<BGGEDFANOCK, AJGMGNEKAFN> PHMMPJODANM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x67A50E0", Offset = "0x67A42E0", VA = "0x1867A50E0")]
	public BIEPECNAFFL([Optional] IList<AJGMGNEKAFN>? AMNFBBLGBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67A3C40", Offset = "0x67A2E40", VA = "0x1867A3C40")]
	public AJGMGNEKAFN DCDAJOOJNCN(BGGEDFANOCK FMHMPBCJLOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NIPHJIFFEHO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NJCOMNIODCJ FKLDMDGMJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class ELFOEDGEGME : NIPHJIFFEHO
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static ELFOEDGEGME PGGKKFEJALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly BPFEINPHMEC CENIGHELJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<BPFEINPHMEC> ONCIILDIPBI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NJCOMNIODCJ FKLDMDGMJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x67A8D50", Offset = "0x67A7F50", VA = "0x1867A8D50")]
	public ELFOEDGEGME(BPFEINPHMEC MHBGAPDLIBD, IReadOnlyList<BPFEINPHMEC> GPCPDLPOGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67A8160", Offset = "0x67A7360", VA = "0x1867A8160")]
	private static ELFOEDGEGME GKINIIOGFDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class EKKAPKIFNBC
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<GGFLPAJCNPO> FCECCMHDEJO;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x67A7EE0", Offset = "0x67A70E0", VA = "0x1867A7EE0")]
	public static bool PBHDCDBMLFF(this HIKDHAMGKKP OCPFMBDHGAP, GGFLPAJCNPO GLJGOCGHKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x67A7E60", Offset = "0x67A7060", VA = "0x1867A7E60")]
	public static bool BBKDPMOCCNM(this HIKDHAMGKKP OCPFMBDHGAP, GGFLPAJCNPO GLJGOCGHKHL, OLCGENEEPKG KGCGLJBCCKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface LOMOKCEOPNH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CGEJIJEDLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NBHGINCHOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool GLOELHEIOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool KHNPKPPEIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PGKGPDAGGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KCHLFLIIDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JAKCNEBJDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool HICMFGMJEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool BIBFKCBOFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GNAKHBAEHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool KPCNHDGCKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool PHFPDBOFAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> ONKNDOOHCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	AIAMNFIDPJH KCOKIBNPFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NJCOMNIODCJ : LOMOKCEOPNH, GCPOEMNNOCA, PNAHIMHNACA<BGGEDFANOCK>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string KMFEEDNFLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	GGFLPAJCNPO NKELEPPIBPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) LMBKEFMMFIM<T>(BGGEDFANOCK FMHMPBCJLOK) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum BGGEDFANOCK
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
internal class BPFEINPHMEC : NJCOMNIODCJ, LOMOKCEOPNH, GCPOEMNNOCA, PNAHIMHNACA<BGGEDFANOCK>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly BIEPECNAFFL CFKNIIGOAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly PJEMJDBFPML OCHPCJKCPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? ACIHGMDKINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? AOOJODEHIFE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool MGLDPMBGMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x67A6460", Offset = "0x67A5660", VA = "0x1867A6460", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool LNFJGIMNHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x67A6370", Offset = "0x67A5570", VA = "0x1867A6370", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool IADOJBJJPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x67A5630", Offset = "0x67A4830", VA = "0x1867A5630", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool FNPAGLLPOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x67A6020", Offset = "0x67A5220", VA = "0x1867A6020", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool JPNJJIPNPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x67A7270", Offset = "0x67A6470", VA = "0x1867A7270", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool PJNHOMFHNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x67A63C0", Offset = "0x67A55C0", VA = "0x1867A63C0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public GGFLPAJCNPO NKELEPPIBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x82DA00", Offset = "0x82CC00", VA = "0x18082DA00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(GGFLPAJCNPO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7BA590", Offset = "0x7B9790", VA = "0x1807BA590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string BIJHEPLHLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x67A6410", Offset = "0x67A5610", VA = "0x1867A6410", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x67A6EA0", Offset = "0x67A60A0", VA = "0x1867A6EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string KMFEEDNFLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x67A6410", Offset = "0x67A5610", VA = "0x1867A6410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool APOMANHHLCD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x872BA0", Offset = "0x871DA0", VA = "0x180872BA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x872470", Offset = "0x871670", VA = "0x180872470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool CGEJIJEDLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x67A6720", Offset = "0x67A5920", VA = "0x1867A6720", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public AIAMNFIDPJH KCOKIBNPFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x67A72C0", Offset = "0x67A64C0", VA = "0x1867A72C0", Slot = "20")]
		get
		{
			return default(AIAMNFIDPJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NBHGINCHOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x67A6620", Offset = "0x67A5820", VA = "0x1867A6620", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GLOELHEIOHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x67A5400", Offset = "0x67A4600", VA = "0x1867A5400", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KHNPKPPEIBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x67A6E50", Offset = "0x67A6050", VA = "0x1867A6E50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool PGKGPDAGGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x67A6D60", Offset = "0x67A5F60", VA = "0x1867A6D60", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool KCHLFLIIDKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x67A6DB0", Offset = "0x67A5FB0", VA = "0x1867A6DB0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JAKCNEBJDNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x67A6E00", Offset = "0x67A6000", VA = "0x1867A6E00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HICMFGMJEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x67A6850", Offset = "0x67A5A50", VA = "0x1867A6850", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool BIBFKCBOFIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x67A5450", Offset = "0x67A4650", VA = "0x1867A5450", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> ONKNDOOHCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x67A6550", Offset = "0x67A5750", VA = "0x1867A6550", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool HACDBKDLLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x67A6460", Offset = "0x67A5660", VA = "0x1867A6460", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool KCCPKKEIGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x67A7270", Offset = "0x67A6470", VA = "0x1867A7270", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DHKEODPMDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x67A6370", Offset = "0x67A5570", VA = "0x1867A6370", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GNAKHBAEHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x67A64B0", Offset = "0x67A56B0", VA = "0x1867A64B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KPCNHDGCKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x67A6500", Offset = "0x67A5700", VA = "0x1867A6500", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FCHGKKODDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x67A5630", Offset = "0x67A4830", VA = "0x1867A5630", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool PHFPDBOFAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x67A68A0", Offset = "0x67A5AA0", VA = "0x1867A68A0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CHFHFMHHEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x67A6020", Offset = "0x67A5220", VA = "0x1867A6020", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool FLKFFCNGHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x67A63C0", Offset = "0x67A55C0", VA = "0x1867A63C0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event PKLLNOFPADE<BGGEDFANOCK> DOMKNNOFGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x67A54F0", Offset = "0x67A46F0", VA = "0x1867A54F0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x67A6670", Offset = "0x67A5870", VA = "0x1867A6670", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2670B90", Offset = "0x266FD90", VA = "0x182670B90", Slot = "6")]
	public (bool, T?) LMBKEFMMFIM<T>(BGGEDFANOCK FMHMPBCJLOK) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2670B50", Offset = "0x266FD50", VA = "0x182670B50")]
	public BPFEINPHMEC AHPPGGMFKGO<T>(BGGEDFANOCK FMHMPBCJLOK, bool AFPPPEFKLDG, T EKDDCPALANJ) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67A7410", Offset = "0x67A6610", VA = "0x1867A7410")]
	public BPFEINPHMEC(GGFLPAJCNPO GLJGOCGHKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67A7580", Offset = "0x67A6780", VA = "0x1867A7580")]
	public BPFEINPHMEC(GGFLPAJCNPO GLJGOCGHKHL, [Optional] string? ACIHGMDKINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67A7390", Offset = "0x67A6590", VA = "0x1867A7390")]
	public BPFEINPHMEC(BPFEINPHMEC NIOFEBNKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67A7430", Offset = "0x67A6630", VA = "0x1867A7430")]
	internal BPFEINPHMEC(GGFLPAJCNPO CDFBKCIBKPK, [Optional] string? ACIHGMDKINE, [Optional] BPFEINPHMEC? NIOFEBNKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x67A65B0", Offset = "0x67A57B0", VA = "0x1867A65B0")]
	public static ICIBJNFKPBG LHFDMHNEIGK(BGGEDFANOCK FMHMPBCJLOK)
	{
		return default(ICIBJNFKPBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x67A6000", Offset = "0x67A5200", VA = "0x1867A6000")]
	public void FCKCGPJIDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x67A6EF0", Offset = "0x67A60F0", VA = "0x1867A6EF0")]
	internal BPFEINPHMEC PCPDGJLJLPL(BPFEINPHMEC GKOLAILEKGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x67A68F0", Offset = "0x67A5AF0", VA = "0x1867A68F0")]
	internal IReadOnlyCollection<BGGEDFANOCK> OGEBIAEMLFN(BPFEINPHMEC NIOFEBNKLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x67A6770", Offset = "0x67A5970", VA = "0x1867A6770")]
	public bool MFDODHEPMNN(BGGEDFANOCK FMHMPBCJLOK, bool AFPPPEFKLDG, string DGIHDPAKMJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x67A6070", Offset = "0x67A5270", VA = "0x1867A6070")]
	public (bool, string) HFIKPILPMIM(BGGEDFANOCK FMHMPBCJLOK)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x67A54A0", Offset = "0x67A46A0", VA = "0x1867A54A0")]
	internal void BFMDEDDHANJ(BGGEDFANOCK FMHMPBCJLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x67A6170", Offset = "0x67A5370", VA = "0x1867A6170")]
	public HOHNGBILCOM IAPHJLLHGIE(Func<GGFLPAJCNPO, Guid> IGNGLPKDNMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x67A5680", Offset = "0x67A4880", VA = "0x1867A5680")]
	public void EOBDIKNJLHL(HOHNGBILCOM KMEMONMPCEC, Func<Guid, GGFLPAJCNPO> GDHMHOHNCKP, [Optional] GGFLPAJCNPO? ADBKMCOBEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x67A55A0", Offset = "0x67A47A0", VA = "0x1867A55A0")]
	[CompilerGenerated]
	private void CNCNNPNEGLH(BGGEDFANOCK OIFJNJNGFFG, FEEGNJOLJBO NFDJGDBIFAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ILDLCICOADM : JBDPGBFFIAA, FCBIKEPAMHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class AMMCICGJOLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public BPFEINPHMEC newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public AMMCICGJOLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x67A3C10", Offset = "0x67A2E10", VA = "0x1867A3C10")]
		internal bool JAGKFIGHDEJ(BPFEINPHMEC rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class OPFANECJJOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public GGFLPAJCNPO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public OPFANECJJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x67B0AB0", Offset = "0x67AFCB0", VA = "0x1867B0AB0")]
		internal bool PCHLMOGBICG(GGFLPAJCNPO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct ICPPGECPANK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public ILDLCICOADM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KCKCHBANCCN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<GDAMKJDBEKB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x67A9750", Offset = "0x67A8950", VA = "0x1867A9750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67A9DC0", Offset = "0x67A8FC0", VA = "0x1867A9DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GBIJODKJCMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public GBIJODKJCMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x67A9550", Offset = "0x67A8750", VA = "0x1867A9550")]
		internal void GFHJMFIJHFI(HOHNGBILCOM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x67A9630", Offset = "0x67A8830", VA = "0x1867A9630")]
		internal void MDDIDNKOCGP(HOHNGBILCOM r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct MLDHHMCINNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KCKCHBANCCN roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class LGBBGDPOFAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<HOHNGBILCOM, FEEGNJOLJBO> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public LGBBGDPOFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x67B09D0", Offset = "0x67AFBD0", VA = "0x1867B09D0")]
		internal void EAHFAKADFMC(HOHNGBILCOM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x67B0A00", Offset = "0x67AFC00", VA = "0x1867B0A00")]
		internal void FLIEPKJFGEA(HOHNGBILCOM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x67B09A0", Offset = "0x67AFBA0", VA = "0x1867B09A0")]
		internal void DPLKOFAGDGH(HOHNGBILCOM r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NHOEJCGKKCF<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public NHOEJCGKKCF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<GDAMKJDBEKB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x321D290", Offset = "0x321C490", VA = "0x18321D290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x893800", Offset = "0x892A00", VA = "0x180893800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public ILDLCICOADM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public BGGEDFANOCK rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GGFLPAJCNPO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public ICIBJNFKPBG recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public NHOEJCGKKCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3D10", Offset = "0x3FF2F10", VA = "0x183FF3D10")]
		[AsyncStateMachine(typeof(NHOEJCGKKCF<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void HEFIKFOKLJJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct DJACEMAAICC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<GDLBMIBGIEO> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JPBPKPIBBHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public PNCLFHOGAOD rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KCKCHBANCCN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<GGFLPAJCNPO, BPFEINPHMEC> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public EHOGINAOANG debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x67AF800", Offset = "0x67AEA00", VA = "0x1867AF800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x67B0310", Offset = "0x67AF510", VA = "0x1867B0310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly PNCLFHOGAOD IPIKCPPHKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly ELFOEDGEGME FEGANGDNBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EHOGINAOANG BNDOEFHACCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, BPFEINPHMEC> FKBGAHGJCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<GGFLPAJCNPO, BPFEINPHMEC> NGLLHAEEHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<GGFLPAJCNPO, BPFEINPHMEC> FJAIEKHHNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<BPFEINPHMEC> HGLDBAHFHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool ILNNNLFEIOJ;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly BGGEDFANOCK[] HJDBLGKEOCK;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NIPHJIFFEHO MFGJPGHBFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<NJCOMNIODCJ> GPHBKBMPKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x67AEA10", Offset = "0x67ADC10", VA = "0x1867AEA10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event KOELBOELJJB HDCCDBMKLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x67AA1A0", Offset = "0x67A93A0", VA = "0x1867AA1A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x67ACCB0", Offset = "0x67ABEB0", VA = "0x1867ACCB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x67AF1C0", Offset = "0x67AE3C0", VA = "0x1867AF1C0")]
	[BDCLMMIIFOD(AILNDCKFLHJ.Room, CIJFMPALMOO.None)]
	private static void OIJIAIDGBGE(JGBEMAKPOMJ PKLEDCMJNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x67AF540", Offset = "0x67AE740", VA = "0x1867AF540")]
	[UnityEngine.Scripting.Preserve]
	internal ILDLCICOADM([MINIJLJAKNC(null)] PNCLFHOGAOD IIFJIDPFPPD, [MINIJLJAKNC(null)] ELFOEDGEGME CPCAFNKBACN, [MINIJLJAKNC(null)] EHOGINAOANG BNDOEFHACCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67AC7C0", Offset = "0x67AB9C0", VA = "0x1867AC7C0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x67ADB10", Offset = "0x67ACD10", VA = "0x1867ADB10")]
	private void IJOAEGBPPJN(IEnumerable<BPFEINPHMEC> HGEKLLEPBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67AB270", Offset = "0x67AA470", VA = "0x1867AB270", Slot = "12")]
	public bool DAGJLLPEBJL(HIKDHAMGKKP CNFKLDMHALN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x67ACF80", Offset = "0x67AC180", VA = "0x1867ACF80")]
	private void GHOCHDAIODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x67AD2D0", Offset = "0x67AC4D0", VA = "0x1867AD2D0")]
	private void HBFJIOPMBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x67ADA90", Offset = "0x67ACC90", VA = "0x1867ADA90", Slot = "10")]
	public IReadOnlyList<NJCOMNIODCJ> IHMOKOFOAGO(bool IEMIPJOLAEL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x67ACA60", Offset = "0x67ABC60", VA = "0x1867ACA60", Slot = "11")]
	public NJCOMNIODCJ FHIEBFBAONN(HIKDHAMGKKP CNFKLDMHALN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x67AAFA0", Offset = "0x67AA1A0", VA = "0x1867AAFA0")]
	private GGFLPAJCNPO CMCDEECEPMP(HIKDHAMGKKP CNFKLDMHALN)
	{
		return default(GGFLPAJCNPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x67AD4B0", Offset = "0x67AC6B0", VA = "0x1867AD4B0", Slot = "14")]
	public bool HDJIKMGHLGK(HIKDHAMGKKP LEPECKKEAML, GGFLPAJCNPO GLJGOCGHKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x67AB340", Offset = "0x67AA540", VA = "0x1867AB340", Slot = "15")]
	public NJCOMNIODCJ DAKCNMBBKIB(GGFLPAJCNPO GLJGOCGHKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x67AD640", Offset = "0x67AC840", VA = "0x1867AD640")]
	private static bool IDIPBDBAFGL(HDPAFDLOJAD LAHIHKPGHEN, GGFLPAJCNPO GLJGOCGHKHL, [Out] HOHNGBILCOM? IKAGLPEIFOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x67A9E20", Offset = "0x67A9020", VA = "0x1867A9E20")]
	private static void BFBMMGGDONF(HDPAFDLOJAD LAHIHKPGHEN, Action<HOHNGBILCOM> FGHLDKANBKE, GGFLPAJCNPO MIDELGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x67A9F10", Offset = "0x67A9110", VA = "0x1867A9F10")]
	private static void BFBMMGGDONF(HDPAFDLOJAD LAHIHKPGHEN, Action<HOHNGBILCOM> FGHLDKANBKE, Predicate<GGFLPAJCNPO> NLFFGHNAJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x67AC8E0", Offset = "0x67ABAE0", VA = "0x1867AC8E0")]
	private void EIBPFEABADL(HIKDHAMGKKP CNFKLDMHALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x67AD970", Offset = "0x67ACB70", VA = "0x1867AD970", Slot = "4")]
	[AsyncStateMachine(typeof(ICPPGECPANK))]
	public Task IGFJHEDJDNE([CanBeNull] KCKCHBANCCN MDDPLLFCMCP, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
	public void DNEBAMOFJLB(KCKCHBANCCN MDDPLLFCMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67ACF90", Offset = "0x67AC190", VA = "0x1867ACF90")]
	private void GPOBEDNHFOL(HDPAFDLOJAD DKGNFADMDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x67AB3E0", Offset = "0x67AA5E0", VA = "0x1867AB3E0")]
	internal static string DIKNINICICH(PNCLFHOGAOD IPIKCPPHKHI, KCKCHBANCCN MDDPLLFCMCP, IReadOnlyDictionary<GGFLPAJCNPO, BPFEINPHMEC> NGLLHAEEHGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x67ABA60", Offset = "0x67AAC60", VA = "0x1867ABA60")]
	private static void DKMLKMIJANH(KCKCHBANCCN MDDPLLFCMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x67AE3E0", Offset = "0x67AD5E0", VA = "0x1867AE3E0")]
	private static void ILLABEEBGNO(HDPAFDLOJAD KHEKPMGDCEH, IReadOnlyDictionary<GGFLPAJCNPO, BPFEINPHMEC> NGLLHAEEHGH, StringBuilder DAGHEEBPDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x67AC950", Offset = "0x67ABB50", VA = "0x1867AC950")]
	private static bool EMMDMBCNBEG(string HPHKGDIGLAC, [Out] Guid ONKAJCEICCO, [Out] GGFLPAJCNPO GLJGOCGHKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x67AEA80", Offset = "0x67ADC80", VA = "0x1867AEA80")]
	private static void LKAFMNPHLEJ(KCKCHBANCCN MDDPLLFCMCP, StringBuilder DAGHEEBPDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x28C0370", Offset = "0x28BF570", VA = "0x1828C0370", Slot = "16")]
	public bool BFEIAKHPKBH<T>(GGFLPAJCNPO GLJGOCGHKHL, BGGEDFANOCK FMHMPBCJLOK, bool AFPPPEFKLDG, T INFIIIMCAKM, [Optional] Action ECEJJFAJHNL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x67AB070", Offset = "0x67AA270", VA = "0x1867AB070")]
	private void CNKGDOFOLKJ(GGFLPAJCNPO GLJGOCGHKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x67AEA60", Offset = "0x67ADC60", VA = "0x1867AEA60")]
	private bool JLABNDHJDMP(HIKDHAMGKKP CNFKLDMHALN, GGFLPAJCNPO GLJGOCGHKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67AA4E0", Offset = "0x67A96E0", VA = "0x1867AA4E0")]
	internal BPFEINPHMEC CBLDEDEBBLL(HIKDHAMGKKP CNFKLDMHALN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x67AC8D0", Offset = "0x67ABAD0", VA = "0x1867AC8D0", Slot = "13")]
	public IReadOnlyList<NJCOMNIODCJ> EIAEEFCMLCB(HIKDHAMGKKP CNFKLDMHALN, bool FIPEEOODLEG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x67ACD50", Offset = "0x67ABF50", VA = "0x1867ACD50")]
	internal IReadOnlyList<BPFEINPHMEC> GFPMCDPPDCN(HIKDHAMGKKP CNFKLDMHALN, bool FIPEEOODLEG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x67AA820", Offset = "0x67A9A20", VA = "0x1867AA820")]
	private void CKGENPONAHD(GDAMKJDBEKB CKJOGCDGPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x67AE730", Offset = "0x67AD930", VA = "0x1867AE730")]
	private static bool ILOCGDIABFH(BPFEINPHMEC DPMFNCJKPAE, IReadOnlyDictionary<GGFLPAJCNPO, BPFEINPHMEC> NGLLHAEEHGH, [Out] IReadOnlyList<BGGEDFANOCK> AJAHFILMOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x67ACB70", Offset = "0x67ABD70", VA = "0x1867ACB70")]
	[AsyncStateMachine(typeof(JPBPKPIBBHF))]
	private static Task GCGGJHMAAFA(PNCLFHOGAOD IPIKCPPHKHI, KCKCHBANCCN MDDPLLFCMCP, IReadOnlyDictionary<GGFLPAJCNPO, BPFEINPHMEC> NGLLHAEEHGH, EHOGINAOANG BNDOEFHACCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x67AA240", Offset = "0x67A9440", VA = "0x1867AA240")]
	[CompilerGenerated]
	internal static void BIBJONAAMLB(Func<HOHNGBILCOM, FEEGNJOLJBO> IBMABKBAGMI, MLDHHMCINNF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x67AB6F0", Offset = "0x67AA8F0", VA = "0x1867AB6F0")]
	[CompilerGenerated]
	internal static bool DKLDLLIAJPL(GGFLPAJCNPO GLJGOCGHKHL, BGGEDFANOCK FMHMPBCJLOK, [Out] GDLBMIBGIEO DOKGJAKODJG, DJACEMAAICC P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface FMCENOBJJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DIAAMNIFJDA(HIKDHAMGKKP EHJJGLIENPH, HIKDHAMGKKP LFFKMAIKMLE, IEnumerable<HIKDHAMGKKP> HGFPOPJHINK, [Out] AIAMNFIDPJH MKLJIFKDGNO, [Out] BJIDJAHHNDP KLKMAMBCGNL);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CIPNIMBKKMD(BJIDJAHHNDP EKLOBJLHJGK);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum BJIDJAHHNDP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class DEKPHOOMGML : FMCENOBJJLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly FCBIKEPAMHA HNGOPGHPNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly PPPEHBAHHHL JMNOOGIFFBH;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7B8ED0", Offset = "0x7B80D0", VA = "0x1807B8ED0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DEKPHOOMGML([MINIJLJAKNC(null)] FCBIKEPAMHA MOHHKHLBCJG, [MINIJLJAKNC(null)] PPPEHBAHHHL MGPBJJEBLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x67A7800", Offset = "0x67A6A00", VA = "0x1867A7800")]
	private static BOIGPPJKBAO? IHEJAPCBIGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x67A7700", Offset = "0x67A6900", VA = "0x1867A7700", Slot = "4")]
	public bool DIAAMNIFJDA(HIKDHAMGKKP EHJJGLIENPH, HIKDHAMGKKP LFFKMAIKMLE, IEnumerable<HIKDHAMGKKP> HGFPOPJHINK, [Out] AIAMNFIDPJH MKLJIFKDGNO, [Out] BJIDJAHHNDP KLKMAMBCGNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x67A7600", Offset = "0x67A6800", VA = "0x1867A7600", Slot = "5")]
	public string CIPNIMBKKMD(BJIDJAHHNDP EKLOBJLHJGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x67A7840", Offset = "0x67A6A40", VA = "0x1867A7840")]
	internal bool PAECCGCHPPO(HIKDHAMGKKP EHJJGLIENPH, HIKDHAMGKKP LFFKMAIKMLE, IEnumerable<HIKDHAMGKKP> HGFPOPJHINK, OLCGENEEPKG KGCGLJBCCKC, BOIGPPJKBAO? AHEPGDLAIGF, [Out] AIAMNFIDPJH MKLJIFKDGNO, [Out] BJIDJAHHNDP KLKMAMBCGNL)
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

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
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using RecRoom.ObjectModel;
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C08610", Offset = "0x8C07010", VA = "0x188C08610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum EANCPNKNNCD
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
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C0EC40", Offset = "0x8C0D640", VA = "0x188C0EC40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LPJINJHPOPB<TPermission>(TPermission OBHPOGNNDEL);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void NJFGCFCLOJH(POIAKMBAMML JGGGINODJOB);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KAMFOKNIBEH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FFNFELMAECO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NBPFCGMPDAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool GDCHPADBPAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AMEDGIPDHJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NFANJCDHKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NHFAMAECAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AKFCNBBAEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool JHMFNKIBGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class IGEIANHJKDJ
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum MJGNONKFEKF
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
	public static readonly Guid BPEPIDMGMLK;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid BCEBOFDLHFK;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid MCOJGIDFFAO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid KLAHILGEGPO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid MODCPOBNLPK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid AFHEKICLLEA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly BALMIJFADEC<HDAMBOGOJKO, Guid> NINFOBNNKLA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	internal static IEnumerable<HDAMBOGOJKO> FFMAFMBLONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C07440", Offset = "0x8C05E40", VA = "0x188C07440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8C070B0", Offset = "0x8C05AB0", VA = "0x188C070B0")]
	public static HDAMBOGOJKO AJBIGHLECGA(Guid DNLDANFOOJK)
	{
		return default(HDAMBOGOJKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8C07140", Offset = "0x8C05B40", VA = "0x188C07140")]
	public static Guid EDGALMMGDKD(HDAMBOGOJKO NKNABIJPMJI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8C073B0", Offset = "0x8C05DB0", VA = "0x188C073B0")]
	public static bool OIKHCEPAELH(HDAMBOGOJKO NKNABIJPMJI, [Out] Guid DNLDANFOOJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8C07220", Offset = "0x8C05C20", VA = "0x188C07220")]
	public static bool IEKIAONHMMH(Guid DNLDANFOOJK, [Out] HDAMBOGOJKO NKNABIJPMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8C072C0", Offset = "0x8C05CC0", VA = "0x188C072C0")]
	public static HDAMBOGOJKO IPLDPJABKEL(HDAMBOGOJKO NKNABIJPMJI)
	{
		return default(HDAMBOGOJKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8C07300", Offset = "0x8C05D00", VA = "0x188C07300")]
	public static MJGNONKFEKF NAPDILAPCJF(HDAMBOGOJKO GAJNGHINCEP)
	{
		return default(MJGNONKFEKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8C071E0", Offset = "0x8C05BE0", VA = "0x188C071E0")]
	internal static HDAMBOGOJKO HFBAKEBCKHA(MJGNONKFEKF GOPHBMKJDOP)
	{
		return default(HDAMBOGOJKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FIHGGGMJFFG
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	POIAKMBAMML PFBPJPFKPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FIICLMFOJBM LFCCMFGBFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DJEKJMDOAHO FIANMCBEBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<DLJNKAILDBN> PMEALILKLIP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AAPOFHHEEHA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HDAMBOGOJKO EMBJBNKHKEJ(POIAKMBAMML JGGGINODJOB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DLJNKAILDBN> NFBEGIIJEPL(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task PHFJGLBPDED(long DKMPIOFKFMN, IReadOnlyList<BJDGMPOCBPN> GIMKACOKHHF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task NLFGBFBKIGD(long DKMPIOFKFMN, long JCFCCOKDCNL, IReadOnlyList<BJDGMPOCBPN> GIMKACOKHHF);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<POIAKMBAMML> KKDKCDCDEHP();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CMLMCOJAPCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8C02EC0", Offset = "0x8C018C0", VA = "0x188C02EC0")]
	public static HDAMBOGOJKO LCPKJJFCGLE(this FIHGGGMJFFG JLNHFPBCGGA)
	{
		return default(HDAMBOGOJKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface PNGLEDCIFFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OIIDKCMFBHK BOCONHJHDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NJFGCFCLOJH AIHBMIOAMBD;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<NJKFMMADGKM> AFIFCABODFN(bool HFLOLCHDALP = false);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NJKFMMADGKM MMBBEFLAKAM(POIAKMBAMML JGGGINODJOB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DEDLGMIKNMJ(POIAKMBAMML JGGGINODJOB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<NJKFMMADGKM> EBPGLOINIIM(POIAKMBAMML JGGGINODJOB, bool IGAKOFFMIPJ = false);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LDDIHLFEJEL(POIAKMBAMML PAKFIPDGEKF, HDAMBOGOJKO NKNABIJPMJI);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NJKFMMADGKM AAEDEPMLBMF(HDAMBOGOJKO NKNABIJPMJI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NOCFNJMMCEC<T>(HDAMBOGOJKO NKNABIJPMJI, COANBILAONK OBHPOGNNDEL, bool GHKIEOOIIAH, T GOMJJOOOEFM, [Optional] Action NKLDDODJMDK) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string GLPBNLBCHEO(COANBILAONK OBHPOGNNDEL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LGMAOEJJFGD(POIAKMBAMML JGGGINODJOB, COANBILAONK LKLEJCNLAIG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FIHJDAGKIAG
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AJAFLHLIODD(AJDHPEOBCFP OBPEHAFILEK, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MPHMBOLOJLL<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string NMAMMDODMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event LPJINJHPOPB<TPermission> LKCCFLJPELH;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class NFCIBNKMAKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? GGPBJNHDAOL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? JEKDDPNJGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8C08340", Offset = "0x8C06D40", VA = "0x188C08340")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8C08410", Offset = "0x8C06E10", VA = "0x188C08410")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8C08510", Offset = "0x8C06F10", VA = "0x188C08510")]
	protected NFCIBNKMAKJ(object? NHNDIDFKLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool GGPINOLOFNI(object? PDKJBMPOMNC);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class KIGDJKPIDEJ<T> : NFCIBNKMAKJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> MJKIOFPPIML;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x54F6520", Offset = "0x54F4F20", VA = "0x1854F6520")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x54F6610", Offset = "0x54F5010", VA = "0x1854F6610", Slot = "4")]
	public override bool GGPINOLOFNI(object? PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x54F69E0", Offset = "0x54F53E0", VA = "0x1854F69E0")]
	public bool OEDHGKHBHHP(T JOGAFJEMHLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x54F6FD0", Offset = "0x54F59D0", VA = "0x1854F6FD0")]
	public KIGDJKPIDEJ(T KKCMINIPIBD, IEqualityComparer<T> MJKIOFPPIML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class LGDDMFJDDIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<COANBILAONK, bool> EBMJHNGNFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<COANBILAONK, NFCIBNKMAKJ> FENOJOMKJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BGPPMBIBOHL EAHGIJPDHGK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8C07D80", Offset = "0x8C06780", VA = "0x188C07D80")]
	public LGDDMFJDDIM(BGPPMBIBOHL EAHGIJPDHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8C07A40", Offset = "0x8C06440", VA = "0x188C07A40")]
	public bool MIMICEDDPML(COANBILAONK OBHPOGNNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D43320", Offset = "0x3D41D20", VA = "0x183D43320")]
	public bool MMDDCEALNII<T>(COANBILAONK OBHPOGNNDEL, bool GHKIEOOIIAH, T PDKJBMPOMNC) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D42F10", Offset = "0x3D41910", VA = "0x183D42F10")]
	public (bool, T?) DLLFGDLFMHI<T>(COANBILAONK OBHPOGNNDEL) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8C07AB0", Offset = "0x8C064B0", VA = "0x188C07AB0")]
	public bool MMDDCEALNII(COANBILAONK OBHPOGNNDEL, bool GHKIEOOIIAH, object PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8C077E0", Offset = "0x8C061E0", VA = "0x188C077E0")]
	public (bool, object) DLLFGDLFMHI(COANBILAONK OBHPOGNNDEL)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D432E0", Offset = "0x3D41CE0", VA = "0x183D432E0")]
	private void ICNJOHHBADD<T>(COANBILAONK OBHPOGNNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8C07970", Offset = "0x8C06370", VA = "0x188C07970")]
	private NFCIBNKMAKJ HIHJEECAGEJ(COANBILAONK OBHPOGNNDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8C07B90", Offset = "0x8C06590", VA = "0x188C07B90")]
	public void PPLGCIJIBLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class OPIKHIDPNJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string BMEFPAKGMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type BFJOKGEAKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly JANAGHAMOJG NJJJKOLILAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly COANBILAONK NLJMIELJENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public PPCLKGODOLD BPBMDPNNHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MAJIIDAGGMM GGCPNHBKNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public JCKLAJJHGPF ENEMJGNJJKO;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8C0E410", Offset = "0x8C0CE10", VA = "0x188C0E410")]
	public OPIKHIDPNJK(Type MELPGCNFIAB, string NKEANKNENKE, COANBILAONK OBHPOGNNDEL, PPCLKGODOLD ILPPBCBDKOD, MAJIIDAGGMM KHEGLFEFFNL, JCKLAJJHGPF NOLNDMAPHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8C0E3C0", Offset = "0x8C0CDC0", VA = "0x188C0E3C0")]
	public object OLFENOHODOH(object? EFNHKCDKOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E51300", Offset = "0x3E4FD00", VA = "0x183E51300")]
	public void ICNJOHHBADD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8C0E310", Offset = "0x8C0CD10", VA = "0x188C0E310")]
	public void ICNJOHHBADD(Type FCHCBMFNMKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class LBADJMGABEE<T> : OPIKHIDPNJK where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string APKLAOKOKLM(T PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T IDHLABMDLLN(string? DENCIKMPOFG, T KKCMINIPIBD);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MOFLLBANHNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public APKLAOKOKLM serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public IDHLABMDLLN parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MOFLLBANHNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x58471A0", Offset = "0x5845BA0", VA = "0x1858471A0")]
		internal string OKDDNCMJJLP(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5847100", Offset = "0x5845B00", VA = "0x185847100")]
		internal object CNDDJOKCEKK(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5580F20", Offset = "0x557F920", VA = "0x185580F20")]
	public LBADJMGABEE(COANBILAONK OBHPOGNNDEL, string NKEANKNENKE, [Optional] APKLAOKOKLM? ILPPBCBDKOD, [Optional] IDHLABMDLLN? KHEGLFEFFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5580310", Offset = "0x557ED10", VA = "0x185580310")]
	private static object? JBBKNKCPLNK(IDHLABMDLLN? KHEGLFEFFNL, string? DENCIKMPOFG, object? KKCMINIPIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x557FDB0", Offset = "0x557E7B0", VA = "0x18557FDB0")]
	private static string AGNKEKDJGCC(APKLAOKOKLM? MHPCFEABIDK, object? PDKJBMPOMNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string PPCLKGODOLD(object? PDKJBMPOMNC);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object MAJIIDAGGMM(string? DENCIKMPOFG, [Optional] object KKCMINIPIBD);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate NFCIBNKMAKJ JCKLAJJHGPF();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class BGPPMBIBOHL
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class GCIMCBNFNFJ : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static GCIMCBNFNFJ NDAIDGNOFDA;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8C04070", Offset = "0x8C02A70", VA = "0x188C04070", Slot = "4")]
		public bool Equals(List<string> IECENJOJFJH, List<string> OFOCBNJJIJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8C041C0", Offset = "0x8C02BC0", VA = "0x188C041C0", Slot = "5")]
		public int GetHashCode(List<string> CEFJEHJNIAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GCIMCBNFNFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class NCAOJBKJFML : LABNKHCBIEH<EANCPNKNNCD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8C08030", Offset = "0x8C06A30", VA = "0x188C08030", Slot = "9")]
		public override string AGNKEKDJGCC(EANCPNKNNCD GMLILPJAKBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8C08120", Offset = "0x8C06B20", VA = "0x188C08120", Slot = "10")]
		protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] EANCPNKNNCD PDKJBMPOMNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8C08300", Offset = "0x8C06D00", VA = "0x188C08300")]
		public NCAOJBKJFML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly ODCJOONMCGF JLCLDKNHEPF;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly NCAOJBKJFML DLCBPBBDAIE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<OPIKHIDPNJK> LDKFILNHFHF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<COANBILAONK> CONKKPHFJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<COANBILAONK, OPIKHIDPNJK> AHCCGGPOLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8C02B70", Offset = "0x8C01570", VA = "0x188C02B70")]
	public BGPPMBIBOHL([Optional] IList<OPIKHIDPNJK>? BMBIHECLFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8C015D0", Offset = "0x8BFFFD0", VA = "0x188C015D0")]
	public OPIKHIDPNJK EFGIEFMCGPF(COANBILAONK OBHPOGNNDEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface OIIDKCMFBHK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NJKFMMADGKM GNBALDDFHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class IFNPPLJBJCC : OIIDKCMFBHK
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static IFNPPLJBJCC CGEIOKLBAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly IEPODPNOFAN NGPADOMCIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<IEPODPNOFAN> BPGIPENKLGI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NJKFMMADGKM GNBALDDFHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8C06FA0", Offset = "0x8C059A0", VA = "0x188C06FA0")]
	public IFNPPLJBJCC(IEPODPNOFAN OJOCNAJNNFJ, IReadOnlyList<IEPODPNOFAN> JKIMOHOMGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8C06050", Offset = "0x8C04A50", VA = "0x188C06050")]
	private static IFNPPLJBJCC EILGPOKCPFE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DBHFAFPCECM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<HDAMBOGOJKO> EBOIBPJMDBP;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8C031A0", Offset = "0x8C01BA0", VA = "0x188C031A0")]
	public static bool ONBGGINAGDD(this POIAKMBAMML PIAAPOBLMOF, HDAMBOGOJKO NKNABIJPMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8C03120", Offset = "0x8C01B20", VA = "0x188C03120")]
	public static bool KHLADJKIGHG(this POIAKMBAMML PIAAPOBLMOF, HDAMBOGOJKO NKNABIJPMJI, DJEKJMDOAHO EKGOPNCKLNO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PACPDKBELFG
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IReadOnlyList<string> NKFAJCJEDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	EANCPNKNNCD EMPNOBAMOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NJKFMMADGKM : PACPDKBELFG, FFNFELMAECO, MPHMBOLOJLL<COANBILAONK>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string DJIALAIKLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	HDAMBOGOJKO JMPBOCOBOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) EGMJBGEODCH<T>(COANBILAONK OBHPOGNNDEL) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class IEPODPNOFAN : NJKFMMADGKM, PACPDKBELFG, FFNFELMAECO, MPHMBOLOJLL<COANBILAONK>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly BGPPMBIBOHL PFJHAAKICDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly LGDDMFJDDIM KIONCPKLHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? OCIOHGDBDKK;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool BDBLDACILBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8C04840", Offset = "0x8C03240", VA = "0x188C04840", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool NGDCEFGGKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8C04430", Offset = "0x8C02E30", VA = "0x188C04430", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool PMOFOJGIEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8C04980", Offset = "0x8C03380", VA = "0x188C04980", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool ILDFFGOPBNB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8C04890", Offset = "0x8C03290", VA = "0x188C04890", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool FHLJDGMJMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8C04930", Offset = "0x8C03330", VA = "0x188C04930", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool HHHFMLNDHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8C04AB0", Offset = "0x8C034B0", VA = "0x188C04AB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private bool OIHPNJIMOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8C048E0", Offset = "0x8C032E0", VA = "0x188C048E0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public HDAMBOGOJKO JMPBOCOBOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(HDAMBOGOJKO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA87B30", Offset = "0xA86530", VA = "0x180A87B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string NMAMMDODMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8C04B60", Offset = "0x8C03560", VA = "0x188C04B60", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string DJIALAIKLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8C04B60", Offset = "0x8C03560", VA = "0x188C04B60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool BEIAKNKHGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAB3420", Offset = "0xAB1E20", VA = "0x180AB3420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAB31A0", Offset = "0xAB1BA0", VA = "0x180AB31A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public EANCPNKNNCD EMPNOBAMOOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C05300", Offset = "0x8C03D00", VA = "0x188C05300", Slot = "8")]
		get
		{
			return default(EANCPNKNNCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<string> NKFAJCJEDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C04B00", Offset = "0x8C03500", VA = "0x188C04B00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool EFOJIGDMAKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C04840", Offset = "0x8C03240", VA = "0x188C04840", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool DHNNFDOJJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C04930", Offset = "0x8C03330", VA = "0x188C04930", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BDCKLFFNHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C04430", Offset = "0x8C02E30", VA = "0x188C04430", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ABOGENFKJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C04980", Offset = "0x8C03380", VA = "0x188C04980", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool FCNCINPCBMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8C04890", Offset = "0x8C03290", VA = "0x188C04890", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GEIADOAAJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C04AB0", Offset = "0x8C034B0", VA = "0x188C04AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LJLFKAAKCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C048E0", Offset = "0x8C032E0", VA = "0x188C048E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event LPJINJHPOPB<COANBILAONK> LKCCFLJPELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8C04EB0", Offset = "0x8C038B0", VA = "0x188C04EB0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8C04F60", Offset = "0x8C03960", VA = "0x188C04F60", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3CAFA50", Offset = "0x3CAE450", VA = "0x183CAFA50", Slot = "6")]
	public (bool, T?) EGMJBGEODCH<T>(COANBILAONK OBHPOGNNDEL) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3CAFA10", Offset = "0x3CAE410", VA = "0x183CAFA10")]
	public IEPODPNOFAN DOMELKNPJFC<T>(COANBILAONK OBHPOGNNDEL, bool GHKIEOOIIAH, T PDKJBMPOMNC) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8C06030", Offset = "0x8C04A30", VA = "0x188C06030")]
	public IEPODPNOFAN(HDAMBOGOJKO NKNABIJPMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8C06010", Offset = "0x8C04A10", VA = "0x188C06010")]
	public IEPODPNOFAN(HDAMBOGOJKO NKNABIJPMJI, [Optional] string? OCIOHGDBDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8C05F80", Offset = "0x8C04980", VA = "0x188C05F80")]
	public IEPODPNOFAN(IEPODPNOFAN MKEIOCOFPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8C05E40", Offset = "0x8C04840", VA = "0x188C05E40")]
	internal IEPODPNOFAN(HDAMBOGOJKO AIEHGBKNBKC, [Optional] string? OCIOHGDBDKK, [Optional] IEPODPNOFAN? MKEIOCOFPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8C043B0", Offset = "0x8C02DB0", VA = "0x188C043B0")]
	public static JANAGHAMOJG ACIJAAAGFKK(COANBILAONK OBHPOGNNDEL)
	{
		return default(JANAGHAMOJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8C05D90", Offset = "0x8C04790", VA = "0x188C05D90")]
	public void PPLGCIJIBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8C05010", Offset = "0x8C03A10", VA = "0x188C05010")]
	internal IEPODPNOFAN JNLHNGCHENA(IEPODPNOFAN AFNCGIOMIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8C04480", Offset = "0x8C02E80", VA = "0x188C04480")]
	internal IReadOnlyCollection<COANBILAONK> BCDPIPBINMD(IEPODPNOFAN MKEIOCOFPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8C049D0", Offset = "0x8C033D0", VA = "0x188C049D0")]
	public bool DLKKCKKFCOJ(COANBILAONK OBHPOGNNDEL, bool GHKIEOOIIAH, string FDBONHPHELJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8C04DB0", Offset = "0x8C037B0", VA = "0x188C04DB0")]
	public (bool, string) IFHKDOMCKPM(COANBILAONK OBHPOGNNDEL)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8C05D40", Offset = "0x8C04740", VA = "0x188C05D40")]
	internal void PNIOFOPBLPA(COANBILAONK OBHPOGNNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8C04BB0", Offset = "0x8C035B0", VA = "0x188C04BB0")]
	public COCAGKFGHGK IBMEFFFCANK(Func<HDAMBOGOJKO, Guid> FBHBMOMLNCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8C053E0", Offset = "0x8C03DE0", VA = "0x188C053E0")]
	public void OMLGJJGBEFH(COCAGKFGHGK CNJAEELANFM, Func<Guid, HDAMBOGOJKO> FEGMALFPGHN, [Optional] HDAMBOGOJKO? NEGBJJLHOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8C05350", Offset = "0x8C03D50", VA = "0x188C05350")]
	[CompilerGenerated]
	private void OCIDHCIIEGJ(COANBILAONK LKLEJCNLAIG, KLHDHCIBIBI EKLKAGANPEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OMMDLPAAHCG : FIHJDAGKIAG, PNGLEDCIFFA, IDisposable, PMOFMPANOGG
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FOGPKGGOOPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IEPODPNOFAN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FOGPKGGOOPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C04040", Offset = "0x8C02A40", VA = "0x188C04040")]
		internal bool LCPCPKEJIAE(IEPODPNOFAN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class AEPNEDIBIGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public HDAMBOGOJKO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AEPNEDIBIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1ED0FE0", Offset = "0x1ECF9E0", VA = "0x181ED0FE0")]
		internal bool AJDILDFEAFC(HDAMBOGOJKO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct AEHOFEONIDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public OMMDLPAAHCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AJDHPEOBCFP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<DLJNKAILDBN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8C006B0", Offset = "0x8BFF0B0", VA = "0x188C006B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C00D20", Offset = "0x8BFF720", VA = "0x188C00D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DBBFMCAJPKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public DBBFMCAJPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C03040", Offset = "0x8C01A40", VA = "0x188C03040")]
		internal void EOCKFIDDDLL(COCAGKFGHGK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C02F20", Offset = "0x8C01920", VA = "0x188C02F20")]
		internal void EGGMHEGNEFO(COCAGKFGHGK r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct DGJKFMKLCEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AJDHPEOBCFP roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FNCKMFKFMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Func<COCAGKFGHGK, KLHDHCIBIBI> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FNCKMFKFMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8C04010", Offset = "0x8C02A10", VA = "0x188C04010")]
		internal void MNLNPLDGLBC(COCAGKFGHGK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8C03FE0", Offset = "0x8C029E0", VA = "0x188C03FE0")]
		internal void EIACPLLGGFO(COCAGKFGHGK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8C03FB0", Offset = "0x8C029B0", VA = "0x188C03FB0")]
		internal void DJNGHPBGCAN(COCAGKFGHGK r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PBOPHKHNEDJ<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public PBOPHKHNEDJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<DLJNKAILDBN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4466A00", Offset = "0x4465400", VA = "0x184466A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public COANBILAONK rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public HDAMBOGOJKO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public JANAGHAMOJG recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public OMMDLPAAHCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PBOPHKHNEDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5AF76C0", Offset = "0x5AF60C0", VA = "0x185AF76C0")]
		[AsyncStateMachine(typeof(PBOPHKHNEDJ<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void KPGJLHKAPJL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct IIMNPBEFCIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IReadOnlyList<BJDGMPOCBPN> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DOKNFAENPEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public FIHGGGMJFFG rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AJDHPEOBCFP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IReadOnlyDictionary<HDAMBOGOJKO, IEPODPNOFAN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public JBEAJCDGOAE debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8C03430", Offset = "0x8C01E30", VA = "0x188C03430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8C03F50", Offset = "0x8C02950", VA = "0x188C03F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly FIHGGGMJFFG JLNHFPBCGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IFNPPLJBJCC ACPBHHHJHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly JBEAJCDGOAE FHJFJFFNNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<int, IEPODPNOFAN> LPNAMKBHBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly Dictionary<HDAMBOGOJKO, IEPODPNOFAN> AJFLDBOIHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly Dictionary<HDAMBOGOJKO, IEPODPNOFAN> FHFBBBJFGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly List<IEPODPNOFAN> FFJPKELFEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool JKDOPDEGNGG;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly COANBILAONK[] OMFGKPLBMJO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public OIIDKCMFBHK BOCONHJHDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NJFGCFCLOJH AIHBMIOAMBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C0C580", Offset = "0x8C0AF80", VA = "0x188C0C580", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C0DCB0", Offset = "0x8C0C6B0", VA = "0x188C0DCB0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8C08F20", Offset = "0x8C07920", VA = "0x188C08F20")]
	[PPMDKOHJEBA.DAJFAGCFHOC]
	internal static void CPNCCEEHJEL(CFAMNNNCHJA GEPFIGLFPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8C0E050", Offset = "0x8C0CA50", VA = "0x188C0E050")]
	[UnityEngine.Scripting.Preserve]
	internal OMMDLPAAHCG([LNLOHEINMEO(null)] FIHGGGMJFFG CNBNMGMJOED, [LNLOHEINMEO(null)] IFNPPLJBJCC LFIOPNDMCLK, [LNLOHEINMEO(null)] JBEAJCDGOAE FHJFJFFNNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8C09E20", Offset = "0x8C08820", VA = "0x188C09E20", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8C0B310", Offset = "0x8C09D10", VA = "0x188C0B310")]
	private void HAFGHEMBDIO(IEnumerable<IEPODPNOFAN> FKJEEEGMFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8C09820", Offset = "0x8C08220", VA = "0x188C09820", Slot = "10")]
	public bool DEDLGMIKNMJ(POIAKMBAMML JGGGINODJOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8C08730", Offset = "0x8C07130", VA = "0x188C08730")]
	private void AAPOFHHEEHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8C0DAC0", Offset = "0x8C0C4C0", VA = "0x188C0DAC0")]
	private void OADBDAAIGGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8C08A90", Offset = "0x8C07490", VA = "0x188C08A90", Slot = "8")]
	public IReadOnlyList<NJKFMMADGKM> AFIFCABODFN(bool HFLOLCHDALP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D9B0", Offset = "0x8C0C3B0", VA = "0x188C0D9B0", Slot = "9")]
	public NJKFMMADGKM MMBBEFLAKAM(POIAKMBAMML JGGGINODJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D370", Offset = "0x8C0BD70", VA = "0x188C0D370")]
	private HDAMBOGOJKO LLCKBECLMOI(POIAKMBAMML JGGGINODJOB)
	{
		return default(HDAMBOGOJKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D060", Offset = "0x8C0BA60", VA = "0x188C0D060", Slot = "12")]
	public bool LDDIHLFEJEL(POIAKMBAMML PAKFIPDGEKF, HDAMBOGOJKO NKNABIJPMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8C08690", Offset = "0x8C07090", VA = "0x188C08690", Slot = "13")]
	public NJKFMMADGKM AAEDEPMLBMF(HDAMBOGOJKO NKNABIJPMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8C0C250", Offset = "0x8C0AC50", VA = "0x188C0C250")]
	private static bool JFDIGNPLIML(ECFHJBBECLP BINDFEHCGCF, HDAMBOGOJKO NKNABIJPMJI, [Out] COCAGKFGHGK? FGNPCJMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8C09960", Offset = "0x8C08360", VA = "0x188C09960")]
	private static void DGIPEIGPIJE(ECFHJBBECLP BINDFEHCGCF, Action<COCAGKFGHGK> GKNKPIOHEEO, HDAMBOGOJKO JCJJMBKBGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8C09A50", Offset = "0x8C08450", VA = "0x188C09A50")]
	private static void DGIPEIGPIJE(ECFHJBBECLP BINDFEHCGCF, Action<COCAGKFGHGK> GKNKPIOHEEO, Predicate<HDAMBOGOJKO> KMOMLJGCMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8C098F0", Offset = "0x8C082F0", VA = "0x188C098F0")]
	private void DFLKIINENFE(POIAKMBAMML JGGGINODJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8C08B10", Offset = "0x8C07510", VA = "0x188C08B10", Slot = "4")]
	[AsyncStateMachine(typeof(AEHOFEONIDN))]
	public Task AJAFLHLIODD([CanBeNull] AJDHPEOBCFP OBPEHAFILEK, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8C0BB90", Offset = "0x8C0A590", VA = "0x188C0BB90")]
	private void HODBBGCKCIN(ECFHJBBECLP LOOIMAMAHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A150", Offset = "0x8C08B50", VA = "0x188C0A150")]
	internal static string FJFLJBGNAEM(FIHGGGMJFFG JLNHFPBCGGA, AJDHPEOBCFP OBPEHAFILEK, IReadOnlyDictionary<HDAMBOGOJKO, IEPODPNOFAN> AJFLDBOIHNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A460", Offset = "0x8C08E60", VA = "0x188C0A460")]
	private static void GCCPNEEPNJI(AJDHPEOBCFP OBPEHAFILEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8C08740", Offset = "0x8C07140", VA = "0x188C08740")]
	private static void ABHFBIOIPEF(ECFHJBBECLP OLIKHPLDNAM, IReadOnlyDictionary<HDAMBOGOJKO, IEPODPNOFAN> AJFLDBOIHNO, StringBuilder OAGCPEMBKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8C0DD70", Offset = "0x8C0C770", VA = "0x188C0DD70")]
	private static bool PIKAEALDNEE(string KEIPIFKOHJP, [Out] Guid KDBGPPEHGEI, [Out] HDAMBOGOJKO NKNABIJPMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8C090E0", Offset = "0x8C07AE0", VA = "0x188C090E0")]
	private static void DCLHEKBMJHM(AJDHPEOBCFP OBPEHAFILEK, StringBuilder OAGCPEMBKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E4E5C0", Offset = "0x3E4CFC0", VA = "0x183E4E5C0", Slot = "14")]
	public bool NOCFNJMMCEC<T>(HDAMBOGOJKO NKNABIJPMJI, COANBILAONK OBHPOGNNDEL, bool GHKIEOOIIAH, T GOMJJOOOEFM, [Optional] Action NKLDDODJMDK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8C0B290", Offset = "0x8C09C90", VA = "0x188C0B290", Slot = "15")]
	public string GLPBNLBCHEO(COANBILAONK OBHPOGNNDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D1D0", Offset = "0x8C0BBD0", VA = "0x188C0D1D0", Slot = "16")]
	public bool LGMAOEJJFGD(POIAKMBAMML JGGGINODJOB, COANBILAONK LKLEJCNLAIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D2C0", Offset = "0x8C0BCC0", VA = "0x188C0D2C0", Slot = "18")]
	public bool LGMAOEJJFGD(int FCNHLPKGBDC, COANBILAONK LKLEJCNLAIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8C09F40", Offset = "0x8C08940", VA = "0x188C09F40")]
	private void EFBDPLFOHBF(HDAMBOGOJKO NKNABIJPMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8C0DD50", Offset = "0x8C0C750", VA = "0x188C0DD50")]
	private bool OHEIPOFMLJM(POIAKMBAMML JGGGINODJOB, HDAMBOGOJKO NKNABIJPMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D670", Offset = "0x8C0C070", VA = "0x188C0D670")]
	internal IEPODPNOFAN MKGGFOGJIPP(POIAKMBAMML JGGGINODJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8C09F30", Offset = "0x8C08930", VA = "0x188C09F30", Slot = "11")]
	public IReadOnlyList<NJKFMMADGKM> EBPGLOINIIM(POIAKMBAMML JGGGINODJOB, bool IGAKOFFMIPJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D440", Offset = "0x8C0BE40", VA = "0x188C0D440")]
	internal IReadOnlyList<IEPODPNOFAN> MIACHEJPBDI(POIAKMBAMML JGGGINODJOB, bool IGAKOFFMIPJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8C0C8C0", Offset = "0x8C0B2C0", VA = "0x188C0C8C0")]
	private void KKKAIDMCCFP(DLJNKAILDBN KDJKKNOKODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8C08C30", Offset = "0x8C07630", VA = "0x188C08C30")]
	private static bool CEOMKOCMBMB(IEPODPNOFAN IGJBPGJJBJA, IReadOnlyDictionary<HDAMBOGOJKO, IEPODPNOFAN> AJFLDBOIHNO, [Out] IReadOnlyList<COANBILAONK> OCBGKDBLAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8C09CE0", Offset = "0x8C086E0", VA = "0x188C09CE0")]
	[AsyncStateMachine(typeof(DOKNFAENPEJ))]
	private static Task DJNBGDFOCGD(FIHGGGMJFFG JLNHFPBCGGA, AJDHPEOBCFP OBPEHAFILEK, IReadOnlyDictionary<HDAMBOGOJKO, IEPODPNOFAN> AJFLDBOIHNO, JBEAJCDGOAE FHJFJFFNNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8C0C620", Offset = "0x8C0B020", VA = "0x188C0C620")]
	[CompilerGenerated]
	internal static void KGPJNDNGNGL(Func<COCAGKFGHGK, KLHDHCIBIBI> OJBPHKICKEC, DGJKFMKLCEA P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8C0BED0", Offset = "0x8C0A8D0", VA = "0x188C0BED0")]
	[CompilerGenerated]
	internal static bool IBINDDLJJPH(HDAMBOGOJKO NKNABIJPMJI, COANBILAONK OBHPOGNNDEL, [Out] BJDGMPOCBPN GKIEIINBMEP, IIMNPBEFCIC P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MADAEGFAMKN
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BHOGNIHMDEM(POIAKMBAMML PFCHJBKFLLL, POIAKMBAMML BJPPIEEMNGM, IEnumerable<POIAKMBAMML> LGGLJNBJJPF, [Out] EANCPNKNNCD CJEGBDMNDCM, [Out] FPKLNIPOJDI JMKDPNKOEOO);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GACAJKBONDK(FPKLNIPOJDI HFPFFGBMHNG);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum FPKLNIPOJDI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class BBFCKBFFCGN : MADAEGFAMKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly PNGLEDCIFFA NDIOAEHEBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly FBLPGNOKACC BEBGEFMNNLN;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA93780", Offset = "0xA92180", VA = "0x180A93780")]
	[RecRoom.NoEngine.Common.Preserve]
	public BBFCKBFFCGN([LNLOHEINMEO(null)] PNGLEDCIFFA NDIOAEHEBLG, [LNLOHEINMEO(null)] FBLPGNOKACC COJDOHCKAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8C01590", Offset = "0x8BFFF90", VA = "0x188C01590")]
	private static ILEDGGKJOBB? MINHCKCKLKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8C00D80", Offset = "0x8BFF780", VA = "0x188C00D80", Slot = "4")]
	public bool BHOGNIHMDEM(POIAKMBAMML PFCHJBKFLLL, POIAKMBAMML BJPPIEEMNGM, IEnumerable<POIAKMBAMML> LGGLJNBJJPF, [Out] EANCPNKNNCD CJEGBDMNDCM, [Out] FPKLNIPOJDI JMKDPNKOEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8C00E80", Offset = "0x8BFF880", VA = "0x188C00E80", Slot = "5")]
	public string GACAJKBONDK(FPKLNIPOJDI HFPFFGBMHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8C00F80", Offset = "0x8BFF980", VA = "0x188C00F80")]
	internal bool IKMLEHPPNCC(POIAKMBAMML PFCHJBKFLLL, POIAKMBAMML BJPPIEEMNGM, IEnumerable<POIAKMBAMML> LGGLJNBJJPF, DJEKJMDOAHO EKGOPNCKLNO, ILEDGGKJOBB? DPCPCMEFHKM, [Out] EANCPNKNNCD CJEGBDMNDCM, [Out] FPKLNIPOJDI JMKDPNKOEOO)
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

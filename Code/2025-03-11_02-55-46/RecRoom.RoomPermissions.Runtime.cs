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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E04300", Offset = "0x7E03700", VA = "0x187E04300")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IDJLOGIIMJB
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
		[Cpp2IlInjected.Address(RVA = "0x7E056A0", Offset = "0x7E04AA0", VA = "0x187E056A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void CFDPJONBKPI<TPermission>(TPermission NABOCLBCNCC);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void NLCDMMJKIPG(NOFCMGEHFOO EMIBCBKNENI);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MAEAPDOFOJK
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DGCKMCFMMDN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NIPAGJKDKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PKDBDAEJJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LNKJNACCHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IJGGMKMLKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KGKIDMBPICM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KLACILADHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class PGGEAJMOMCI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum CCPAHEJHOEM
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
	public static readonly Guid HNFFAHCPLMH;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid KCCJDELHJKC;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid CBFHBHHHEDH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid IKLDOBJCOAK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid IHBDLNLLPLC;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid AKAJHOIGPJM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly NHNBBIGCHBE<DFFCINOLDEH, Guid> DMKDGGHPEAJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<DFFCINOLDEH> GLAPIAPPLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7E04500", Offset = "0x7E03900", VA = "0x187E04500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7E045B0", Offset = "0x7E039B0", VA = "0x187E045B0")]
	public static DFFCINOLDEH NNFIAJADEDH(Guid BCIHOIBCNMJ)
	{
		return default(DFFCINOLDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E043B0", Offset = "0x7E037B0", VA = "0x187E043B0")]
	public static Guid DNLEFHCHLOM(DFFCINOLDEH LCMAJKBCACM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E04720", Offset = "0x7E03B20", VA = "0x187E04720")]
	public static bool OODDKIFFOHI(DFFCINOLDEH LCMAJKBCACM, [Out] Guid BCIHOIBCNMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E04640", Offset = "0x7E03A40", VA = "0x187E04640")]
	public static bool OHILCCJOLPL(Guid BCIHOIBCNMJ, [Out] DFFCINOLDEH LCMAJKBCACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E046E0", Offset = "0x7E03AE0", VA = "0x187E046E0")]
	public static DFFCINOLDEH OMKJIBAPHDO(DFFCINOLDEH LCMAJKBCACM)
	{
		return default(DFFCINOLDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E04450", Offset = "0x7E03850", VA = "0x187E04450")]
	public static CCPAHEJHOEM IEBIHPBELJO(DFFCINOLDEH OGJOEANFLPO)
	{
		return default(CCPAHEJHOEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E04570", Offset = "0x7E03970", VA = "0x187E04570")]
	internal static DFFCINOLDEH NLADHKJPLPM(CCPAHEJHOEM CHNCNIIHGKH)
	{
		return default(DFFCINOLDEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JLDHFHDIFFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GAIICCGGNNH HHELFBPOMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<DAJGIHKBPMI> MBHGAFKFGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NLCDMMJKIPG KEDPABJOOHI;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<DAJGIHKBPMI> JKADKHHNLLL(bool LPGFNFMEIEL = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DAJGIHKBPMI CNOKDAMACCG(NOFCMGEHFOO EMIBCBKNENI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HIFBOGAILDH(NOFCMGEHFOO EMIBCBKNENI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<DAJGIHKBPMI> CANCPIPFGHI(NOFCMGEHFOO EMIBCBKNENI, bool MNBHDOCBKLE = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool INLFMPGOKGH(NOFCMGEHFOO KAGIEFMHHOG, DFFCINOLDEH LCMAJKBCACM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DAJGIHKBPMI IIDACFGPFDP(DFFCINOLDEH LCMAJKBCACM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EAACCCEJCEA<T>(DFFCINOLDEH LCMAJKBCACM, FPCJMGENLEJ NABOCLBCNCC, bool CBHKFCAHBMB, T EEHMKJMNANF, [Optional] Action PIOACHJDPOO) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string FIIOKEBELCM(FPCJMGENLEJ NABOCLBCNCC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KFMIHGPODCC
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HMGLHIHPBPE(OIBKBLGJIPN EDHFGAMFCNC, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEAEJIKMEHP(OIBKBLGJIPN EDHFGAMFCNC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MOAOGIJGMIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NOFCMGEHFOO MMFHALPOBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DNHLENAINEA JNCONCODHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FGPODGGHBLK MDPBAJGDGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<DJIBDADPHAK> LIJOKBHCAJF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action FEJCBCPPDFB;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DFFCINOLDEH IINEKDMIMIB(NOFCMGEHFOO EMIBCBKNENI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DJIBDADPHAK> BEHCDJJHLHL(CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BLGKHGOABGF(long LFNEDMLHPHM, IReadOnlyList<DIIKPGCOBKG> MAAGMJPICGI);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task EEDFICFOPPM(long LFNEDMLHPHM, long BEGDDCHOHOL, IReadOnlyList<DIIKPGCOBKG> MAAGMJPICGI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<NOFCMGEHFOO> KACOHNDDAPH();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IGPKBGHPOCE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7DFCD80", Offset = "0x7DFC180", VA = "0x187DFCD80")]
	public static DFFCINOLDEH DIMIHHAICDJ(this MOAOGIJGMIG CFHMOFCAGNL)
	{
		return default(DFFCINOLDEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OIIAGKHLOGG<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string OEOGABEGHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CFDPJONBKPI<TPermission> NGDBLJAKOMF;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class DNOLBLNDKHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? PKGIJJMCPAP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? BLDAKECEOEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7DF71D0", Offset = "0x7DF65D0", VA = "0x187DF71D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7DF70D0", Offset = "0x7DF64D0", VA = "0x187DF70D0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7DF72A0", Offset = "0x7DF66A0", VA = "0x187DF72A0")]
	protected DNOLBLNDKHF(object? FCKAMAIANOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool EEMHKMEOGED(object? PEBNJNGMMHE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class AAAICNBPGDC<T> : DNOLBLNDKHF where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> HMLMHCLAIJJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4602450", Offset = "0x4601850", VA = "0x184602450")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4602910", Offset = "0x4601D10", VA = "0x184602910", Slot = "4")]
	public override bool EEMHKMEOGED(object? PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4602B10", Offset = "0x4601F10", VA = "0x184602B10")]
	public bool JLJJFINHIEA(T HEPEPPCJKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x46030B0", Offset = "0x46024B0", VA = "0x1846030B0")]
	public AAAICNBPGDC(T CIKOELCEFFM, IEqualityComparer<T> HMLMHCLAIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class DPMFJANEIPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<FPCJMGENLEJ, bool> CLBCAHGBKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<FPCJMGENLEJ, DNOLBLNDKHF> HHFMPEDAJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MFGLPHCJKEF MLNEIEBHOHB;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7940", Offset = "0x7DF6D40", VA = "0x187DF7940")]
	public DPMFJANEIPL(MFGLPHCJKEF MLNEIEBHOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7590", Offset = "0x7DF6990", VA = "0x187DF7590")]
	public bool DJLDHPKDNLN(FPCJMGENLEJ NABOCLBCNCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x32DAB70", Offset = "0x32D9F70", VA = "0x1832DAB70")]
	public bool HAOIIMBAKLD<T>(FPCJMGENLEJ NABOCLBCNCC, bool CBHKFCAHBMB, T PEBNJNGMMHE) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x32DB170", Offset = "0x32DA570", VA = "0x1832DB170")]
	public (bool, T?) LEKBENBFOCI<T>(FPCJMGENLEJ NABOCLBCNCC) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7600", Offset = "0x7DF6A00", VA = "0x187DF7600")]
	public bool HAOIIMBAKLD(FPCJMGENLEJ NABOCLBCNCC, bool CBHKFCAHBMB, object PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7DF77B0", Offset = "0x7DF6BB0", VA = "0x187DF77B0")]
	public (bool, object) LEKBENBFOCI(FPCJMGENLEJ NABOCLBCNCC)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x32DB110", Offset = "0x32DA510", VA = "0x1832DB110")]
	private void JHGPFGEOAGF<T>(FPCJMGENLEJ NABOCLBCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7DF76E0", Offset = "0x7DF6AE0", VA = "0x187DF76E0")]
	private DNOLBLNDKHF IJINFKAKEHB(FPCJMGENLEJ NABOCLBCNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7DF73A0", Offset = "0x7DF67A0", VA = "0x187DF73A0")]
	public void CEIKCENNFPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class PKJCIPFMEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ADEJLEBKGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type CFJABFMLKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly IHEMNAHBKNM KHPJLBIENON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly FPCJMGENLEJ HNLJFGNALLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public AGHCBAMODPB JGPHNEIHIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OOHLPKJMBIB NOJALLBBAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PPKMOCGJAFJ NLNOFBIAEGO;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E04BA0", Offset = "0x7E03FA0", VA = "0x187E04BA0")]
	public PKJCIPFMEJF(Type IAMGIENOKPK, string MIHAJKBEPGJ, FPCJMGENLEJ NABOCLBCNCC, AGHCBAMODPB FIGNAEGIMFI, OOHLPKJMBIB MLJMIIEFEGL, PPKMOCGJAFJ ODCPKKCOCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E04AA0", Offset = "0x7E03EA0", VA = "0x187E04AA0")]
	public object BAEEJDANCJC(object? MNALNBMKJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x36705D0", Offset = "0x366F9D0", VA = "0x1836705D0")]
	public void JHGPFGEOAGF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E04AF0", Offset = "0x7E03EF0", VA = "0x187E04AF0")]
	public void JHGPFGEOAGF(Type GKJFNOOHOBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class OHEDEPGGPDK<T> : PKJCIPFMEJF where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string BHCDKFBNKPB(T PEBNJNGMMHE);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T GOGILPCEENJ(string? FJEMLNBDONM, T CIKOELCEFFM);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PGBHNBMIEGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public BHCDKFBNKPB serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GOGILPCEENJ parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PGBHNBMIEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5092280", Offset = "0x5091680", VA = "0x185092280")]
		internal string NEJCHNJLNGK(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5092100", Offset = "0x5091500", VA = "0x185092100")]
		internal object CCMBIMPLJGK(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4FA4710", Offset = "0x4FA3B10", VA = "0x184FA4710")]
	public OHEDEPGGPDK(FPCJMGENLEJ NABOCLBCNCC, string MIHAJKBEPGJ, [Optional] BHCDKFBNKPB? FIGNAEGIMFI, [Optional] GOGILPCEENJ? MLJMIIEFEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3DE0", Offset = "0x4FA31E0", VA = "0x184FA3DE0")]
	private static object? NHMCOOCBIHH(GOGILPCEENJ? MLJMIIEFEGL, string? FJEMLNBDONM, object? CIKOELCEFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3540", Offset = "0x4FA2940", VA = "0x184FA3540")]
	private static string EFGCEHNIDJN(BHCDKFBNKPB? OKFHBFFCAAG, object? PEBNJNGMMHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string AGHCBAMODPB(object? PEBNJNGMMHE);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object OOHLPKJMBIB(string? FJEMLNBDONM, [Optional] object CIKOELCEFFM);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate DNOLBLNDKHF PPKMOCGJAFJ();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class MFGLPHCJKEF
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class EDNNJLNBFIP : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static EDNNJLNBFIP AJPLFLPAHGP;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8F10", Offset = "0x7DF8310", VA = "0x187DF8F10", Slot = "4")]
		public bool Equals(List<string> COMHOHNLIIN, List<string> PJGBAACMKFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9060", Offset = "0x7DF8460", VA = "0x187DF9060", Slot = "5")]
		public int GetHashCode(List<string> NBAMGPFDMIB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public EDNNJLNBFIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class EDKMHGDJIPA : BJHJCCAALGG<IDJLOGIIMJB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8DE0", Offset = "0x7DF81E0", VA = "0x187DF8DE0", Slot = "9")]
		public override string EFGCEHNIDJN(IDJLOGIIMJB NIPDIMDKGGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8C10", Offset = "0x7DF8010", VA = "0x187DF8C10", Slot = "10")]
		protected override bool AOOMDNHEJHF(string NIPDIMDKGGA, [Out] IDJLOGIIMJB PEBNJNGMMHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8ED0", Offset = "0x7DF82D0", VA = "0x187DF8ED0")]
		public EDKMHGDJIPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly MLLDMLHCKKE NBCLNEOOLMA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EDKMHGDJIPA NAPHIFPHNIM;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<PKJCIPFMEJF> HCLOMLENNAD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<FPCJMGENLEJ> IFCLMNHOEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<FPCJMGENLEJ, PKJCIPFMEJF> JPFEFGABJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E03FE0", Offset = "0x7E033E0", VA = "0x187E03FE0")]
	public MFGLPHCJKEF([Optional] IList<PKJCIPFMEJF>? LEJMEONICBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E02A70", Offset = "0x7E01E70", VA = "0x187E02A70")]
	public PKJCIPFMEJF DFNCOJBFIKP(FPCJMGENLEJ NABOCLBCNCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GAIICCGGNNH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DAJGIHKBPMI PPHPLFPDCBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class EAELIPFCDMP : GAIICCGGNNH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static EAELIPFCDMP DPFHJCLELJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly EPKAHJGCHGD LDKBKGKAKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<EPKAHJGCHGD> EDEKHDBANAF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DAJGIHKBPMI PPHPLFPDCBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8B00", Offset = "0x7DF7F00", VA = "0x187DF8B00")]
	public EAELIPFCDMP(EPKAHJGCHGD DCHLPKJDNFC, IReadOnlyList<EPKAHJGCHGD> NEDAMHFBMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7BF0", Offset = "0x7DF6FF0", VA = "0x187DF7BF0")]
	private static EAELIPFCDMP ALDMJELDDJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class POABJIPLJKB
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<DFFCINOLDEH> LJNCGIFCDFG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7E04CC0", Offset = "0x7E040C0", VA = "0x187E04CC0")]
	public static bool PKNEPOPCDOH(this NOFCMGEHFOO BAEPHPHLIBE, DFFCINOLDEH LCMAJKBCACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E04C40", Offset = "0x7E04040", VA = "0x187E04C40")]
	public static bool FOOFOLALFOE(this NOFCMGEHFOO BAEPHPHLIBE, DFFCINOLDEH LCMAJKBCACM, FGPODGGHBLK BMCIAEPHBNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface DAOGGDMIPHG
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool DJFAPHBMHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool IKEGHCNJIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool BAHJNPFPJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool BGGIJAKMOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KHJMNMFNLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AMDLIJELHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MINBGDBMDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LMPFMAOFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool BBDBAGJHFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DAMABABALPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool IGLMKNFJANF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NADNFIHFOIO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> JEJEDNLKCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IDJLOGIIMJB APDFBEGCDJG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DAJGIHKBPMI : DAOGGDMIPHG, DGCKMCFMMDN, OIIAGKHLOGG<FPCJMGENLEJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string AEIAOMEHJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DFFCINOLDEH ONAIPCPCLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) MMBHHAGCBGD<T>(FPCJMGENLEJ NABOCLBCNCC) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum FPCJMGENLEJ
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
internal class EPKAHJGCHGD : DAJGIHKBPMI, DAOGGDMIPHG, DGCKMCFMMDN, OIIAGKHLOGG<FPCJMGENLEJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly MFGLPHCJKEF LGEOGGMFOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly DPMFJANEIPL HGIKKBBGMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? KPMLIIAPNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? COHPMHMJJJF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool JGKMEHPPHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA9B0", Offset = "0x7DF9DB0", VA = "0x187DFA9B0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool MMDCNCGEMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9A30", Offset = "0x7DF8E30", VA = "0x187DF9A30", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool FEJCDDIHMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9290", Offset = "0x7DF8690", VA = "0x187DF9290", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool LDJJKFLICDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9400", Offset = "0x7DF8800", VA = "0x187DF9400", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool LIBFGMGKAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9A80", Offset = "0x7DF8E80", VA = "0x187DF9A80", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool CMIMIBKCFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7DF97B0", Offset = "0x7DF8BB0", VA = "0x187DF97B0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public DFFCINOLDEH ONAIPCPCLCB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xC02DE0", Offset = "0xC021E0", VA = "0x180C02DE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DFFCINOLDEH);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x970B00", Offset = "0x96FF00", VA = "0x180970B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string OEOGABEGHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAA00", Offset = "0x7DF9E00", VA = "0x187DFAA00", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAC00", Offset = "0x7DFA000", VA = "0x187DFAC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string AEIAOMEHJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAA00", Offset = "0x7DF9E00", VA = "0x187DFAA00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool MLFJODNGJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xC6AD40", Offset = "0xC6A140", VA = "0x180C6AD40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xC6AD60", Offset = "0xC6A160", VA = "0x180C6AD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool DJFAPHBMHKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7DF99E0", Offset = "0x7DF8DE0", VA = "0x187DF99E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IDJLOGIIMJB APDFBEGCDJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9240", Offset = "0x7DF8640", VA = "0x187DF9240", Slot = "20")]
		get
		{
			return default(IDJLOGIIMJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IKEGHCNJIBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAB60", Offset = "0x7DF9F60", VA = "0x187DFAB60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool BAHJNPFPJLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9E50", Offset = "0x7DF9250", VA = "0x187DF9E50", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BGGIJAKMOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9990", Offset = "0x7DF8D90", VA = "0x187DF9990", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool KHJMNMFNLIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9E00", Offset = "0x7DF9200", VA = "0x187DF9E00", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool AMDLIJELHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9940", Offset = "0x7DF8D40", VA = "0x187DF9940", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MINBGDBMDLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9800", Offset = "0x7DF8C00", VA = "0x187DF9800", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool LMPFMAOFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9BB0", Offset = "0x7DF8FB0", VA = "0x187DF9BB0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool BBDBAGJHFDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7DF98A0", Offset = "0x7DF8CA0", VA = "0x187DF98A0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> JEJEDNLKCOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAA50", Offset = "0x7DF9E50", VA = "0x187DFAA50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool IIGHLECPEPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA9B0", Offset = "0x7DF9DB0", VA = "0x187DFA9B0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool OJPGBNMIKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9A80", Offset = "0x7DF8E80", VA = "0x187DF9A80", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool HCNNFDHKNMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9A30", Offset = "0x7DF8E30", VA = "0x187DF9A30", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DAMABABALPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7DF98F0", Offset = "0x7DF8CF0", VA = "0x187DF98F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool IGLMKNFJANF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFABB0", Offset = "0x7DF9FB0", VA = "0x187DFABB0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool MLLFMFAELKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9290", Offset = "0x7DF8690", VA = "0x187DF9290", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool NADNFIHFOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9850", Offset = "0x7DF8C50", VA = "0x187DF9850", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EBLJMHINEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9400", Offset = "0x7DF8800", VA = "0x187DF9400", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool HIGBMJNEGFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DF97B0", Offset = "0x7DF8BB0", VA = "0x187DF97B0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event CFDPJONBKPI<FPCJMGENLEJ> NGDBLJAKOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9EA0", Offset = "0x7DF92A0", VA = "0x187DF9EA0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAAB0", Offset = "0x7DF9EB0", VA = "0x187DFAAB0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3319180", Offset = "0x3318580", VA = "0x183319180", Slot = "6")]
	public (bool, T?) MMBHHAGCBGD<T>(FPCJMGENLEJ NABOCLBCNCC) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3319120", Offset = "0x3318520", VA = "0x183319120")]
	public EPKAHJGCHGD EKJMKDLKGKF<T>(FPCJMGENLEJ NABOCLBCNCC, bool CBHKFCAHBMB, T PEBNJNGMMHE) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7DFB0C0", Offset = "0x7DFA4C0", VA = "0x187DFB0C0")]
	public EPKAHJGCHGD(DFFCINOLDEH LCMAJKBCACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7DFB2B0", Offset = "0x7DFA6B0", VA = "0x187DFB2B0")]
	public EPKAHJGCHGD(DFFCINOLDEH LCMAJKBCACM, [Optional] string? KPMLIIAPNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7DFB230", Offset = "0x7DFA630", VA = "0x187DFB230")]
	public EPKAHJGCHGD(EPKAHJGCHGD EBOBGNJKHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DFB0E0", Offset = "0x7DFA4E0", VA = "0x187DFB0E0")]
	internal EPKAHJGCHGD(DFFCINOLDEH FEKJJECODNK, [Optional] string? KPMLIIAPNAK, [Optional] EPKAHJGCHGD? EBOBGNJKHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9450", Offset = "0x7DF8850", VA = "0x187DF9450")]
	public static IHEMNAHBKNM CLAMEBELFDK(FPCJMGENLEJ NABOCLBCNCC)
	{
		return default(IHEMNAHBKNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7DF93E0", Offset = "0x7DF87E0", VA = "0x187DF93E0")]
	public void CEIKCENNFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7DF94C0", Offset = "0x7DF88C0", VA = "0x187DF94C0")]
	internal EPKAHJGCHGD CMLHFHIIBCN(EPKAHJGCHGD GHLPDADJEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAC50", Offset = "0x7DFA050", VA = "0x187DFAC50")]
	internal IReadOnlyCollection<FPCJMGENLEJ> PFNDDGDDDJB(EPKAHJGCHGD EBOBGNJKHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9AD0", Offset = "0x7DF8ED0", VA = "0x187DF9AD0")]
	public bool ICDEEENHGGJ(FPCJMGENLEJ NABOCLBCNCC, bool CBHKFCAHBMB, string OKEMDEPGCIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7DF92E0", Offset = "0x7DF86E0", VA = "0x187DF92E0")]
	public (bool, string) BDLOHNKMHIM(FPCJMGENLEJ NABOCLBCNCC)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9F50", Offset = "0x7DF9350", VA = "0x187DF9F50")]
	internal void KJCEKCCJLIH(FPCJMGENLEJ NABOCLBCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9C00", Offset = "0x7DF9000", VA = "0x187DF9C00")]
	public AHGGLBDMFKN IPMPOLOIDIL(Func<DFFCINOLDEH, Guid> MNGOPEMBMNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA030", Offset = "0x7DF9430", VA = "0x187DFA030")]
	public void LNJNNOKFDOA(AHGGLBDMFKN MDIPGEGDECD, Func<Guid, DFFCINOLDEH> ICPBGAMJLDP, [Optional] DFFCINOLDEH? DNHDNGNADCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9FA0", Offset = "0x7DF93A0", VA = "0x187DF9FA0")]
	[CompilerGenerated]
	private void LFHOLBLCLGI(FPCJMGENLEJ COILMCBILPO, PEDBNHOCMJI FMAGJNPDPIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class IMNDMDBAAAE : KFMIHGPODCC, JLDHFHDIFFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class OJHKANBJOOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public EPKAHJGCHGD newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OJHKANBJOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7E04380", Offset = "0x7E03780", VA = "0x187E04380")]
		internal bool FBKDHOFGOMA(EPKAHJGCHGD rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class LBCOANPCDGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public DFFCINOLDEH roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LBCOANPCDGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1A05530", Offset = "0x1A04930", VA = "0x181A05530")]
		internal bool GJHAFAEMABF(DFFCINOLDEH r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct IABOGAGHKLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public IMNDMDBAAAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public OIBKBLGJIPN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<DJIBDADPHAK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC6B0", Offset = "0x7DFBAB0", VA = "0x187DFC6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCD20", Offset = "0x7DFC120", VA = "0x187DFCD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class IKOGOGOOCNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public IKOGOGOOCNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCF00", Offset = "0x7DFC300", VA = "0x187DFCF00")]
		internal void MBHAILJMMFM(AHGGLBDMFKN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCDE0", Offset = "0x7DFC1E0", VA = "0x187DFCDE0")]
		internal void GBFIHOEGOKO(AHGGLBDMFKN r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct CDOGLMAJPJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public OIBKBLGJIPN roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JHFDPCJJHCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<AHGGLBDMFKN, PEDBNHOCMJI> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JHFDPCJJHCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7E02A40", Offset = "0x7E01E40", VA = "0x187E02A40")]
		internal void KOMBPKEBOLK(AHGGLBDMFKN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7E029E0", Offset = "0x7E01DE0", VA = "0x187E029E0")]
		internal void GACMPNNOBKI(AHGGLBDMFKN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7E02A10", Offset = "0x7E01E10", VA = "0x187E02A10")]
		internal void GFBEIOOKIJN(AHGGLBDMFKN r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class GONDCDOEMJK<T> where T : notnull
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
			public GONDCDOEMJK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<DJIBDADPHAK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3D5A6D0", Offset = "0x3D59AD0", VA = "0x183D5A6D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FPCJMGENLEJ rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public DFFCINOLDEH accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public IHEMNAHBKNM recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public IMNDMDBAAAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GONDCDOEMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x46DEF70", Offset = "0x46DE370", VA = "0x1846DEF70")]
		[AsyncStateMachine(typeof(GONDCDOEMJK<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void BDNHJHLGCAF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CFJOPALBMNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<DIIKPGCOBKG> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HPOFPDKFDFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public MOAOGIJGMIG rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public OIBKBLGJIPN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<DFFCINOLDEH, EPKAHJGCHGD> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public JJHMNFHFHIL debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7DFBB30", Offset = "0x7DFAF30", VA = "0x187DFBB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC650", Offset = "0x7DFBA50", VA = "0x187DFC650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly MOAOGIJGMIG CFHMOFCAGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly EAELIPFCDMP LKLLPLLEEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly JJHMNFHFHIL NLLOMHBDPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, EPKAHJGCHGD> LIFNBJDOMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<DFFCINOLDEH, EPKAHJGCHGD> BKMBGIOHEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<DFFCINOLDEH, EPKAHJGCHGD> LGMDOKGECFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<EPKAHJGCHGD> KEKPPKLMDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool PCBGNOLJJBF;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly FPCJMGENLEJ[] BMLHPLOOPKG;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GAIICCGGNNH HHELFBPOMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<DAJGIHKBPMI> MBHGAFKFGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDB40", Offset = "0x7DFCF40", VA = "0x187DFDB40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NLCDMMJKIPG KEDPABJOOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7E02300", Offset = "0x7E01700", VA = "0x187E02300", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE700", Offset = "0x7DFDB00", VA = "0x187DFE700", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E023A0", Offset = "0x7E017A0", VA = "0x187E023A0")]
	[AEDFFNEEAKJ.LPKEDHFAMMA]
	internal static void PPNAAKNMPKA(LEPFMCICNAK BFCIDAHLIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7E02720", Offset = "0x7E01B20", VA = "0x187E02720")]
	[UnityEngine.Scripting.Preserve]
	internal IMNDMDBAAAE([PNFCCJKFMBH(null)] MOAOGIJGMIG LPOAEFODHIE, [PNFCCJKFMBH(null)] EAELIPFCDMP KACEEICJDHI, [PNFCCJKFMBH(null)] JJHMNFHFHIL NLLOMHBDPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDEC0", Offset = "0x7DFD2C0", VA = "0x187DFDEC0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE870", Offset = "0x7DFDC70", VA = "0x187DFE870")]
	private void HMBPOIDNFNC(IEnumerable<EPKAHJGCHGD> IJHFLFJGJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE7A0", Offset = "0x7DFDBA0", VA = "0x187DFE7A0", Slot = "12")]
	public bool HIFBOGAILDH(NOFCMGEHFOO EMIBCBKNENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDFD0", Offset = "0x7DFD3D0", VA = "0x187DFDFD0")]
	private void FEJCBCPPDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7E00F10", Offset = "0x7E00310", VA = "0x187E00F10")]
	private void LCLOAGBHKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7E00180", Offset = "0x7DFF580", VA = "0x187E00180", Slot = "10")]
	public IReadOnlyList<DAJGIHKBPMI> JKADKHHNLLL(bool LPGFNFMEIEL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDA30", Offset = "0x7DFCE30", VA = "0x187DFDA30", Slot = "11")]
	public DAJGIHKBPMI CNOKDAMACCG(NOFCMGEHFOO EMIBCBKNENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE630", Offset = "0x7DFDA30", VA = "0x187DFE630")]
	private DFFCINOLDEH GMCJOJKPEAN(NOFCMGEHFOO EMIBCBKNENI)
	{
		return default(DFFCINOLDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7DFFFF0", Offset = "0x7DFF3F0", VA = "0x187DFFFF0", Slot = "14")]
	public bool INLFMPGOKGH(NOFCMGEHFOO KAGIEFMHHOG, DFFCINOLDEH LCMAJKBCACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7DFFF50", Offset = "0x7DFF350", VA = "0x187DFFF50", Slot = "15")]
	public DAJGIHKBPMI IIDACFGPFDP(DFFCINOLDEH LCMAJKBCACM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDB90", Offset = "0x7DFCF90", VA = "0x187DFDB90")]
	private static bool DPILBNAJBMK(EGPLNMAPJMB HOMGOHLJFCL, DFFCINOLDEH LCMAJKBCACM, [Out] AHGGLBDMFKN? CAIMKOBFDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD570", Offset = "0x7DFC970", VA = "0x187DFD570")]
	private static void BGLCDAKDPHJ(EGPLNMAPJMB HOMGOHLJFCL, Action<AHGGLBDMFKN> AFEFDBEIEAB, DFFCINOLDEH HOHDCNPPBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD2E0", Offset = "0x7DFC6E0", VA = "0x187DFD2E0")]
	private static void BGLCDAKDPHJ(EGPLNMAPJMB HOMGOHLJFCL, Action<AHGGLBDMFKN> AFEFDBEIEAB, Predicate<DFFCINOLDEH> ECEMELGOLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD670", Offset = "0x7DFCA70", VA = "0x187DFD670")]
	private void CJADBAPKMLG(NOFCMGEHFOO EMIBCBKNENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7DFF0D0", Offset = "0x7DFE4D0", VA = "0x187DFF0D0", Slot = "4")]
	[AsyncStateMachine(typeof(IABOGAGHKLP))]
	public Task HMGLHIHPBPE([CanBeNull] OIBKBLGJIPN EDHFGAMFCNC, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
	public void NEAEJIKMEHP(OIBKBLGJIPN EDHFGAMFCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E01540", Offset = "0x7E00940", VA = "0x187E01540")]
	private void MNFPFONDIEC(EGPLNMAPJMB FBMHEEOHION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E010F0", Offset = "0x7E004F0", VA = "0x187E010F0")]
	internal static string LMHGIEBJEOK(MOAOGIJGMIG CFHMOFCAGNL, OIBKBLGJIPN EDHFGAMFCNC, IReadOnlyDictionary<DFFCINOLDEH, EPKAHJGCHGD> BKMBGIOHEBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7DFF1F0", Offset = "0x7DFE5F0", VA = "0x187DFF1F0")]
	private static void ICOHBBFKGHE(OIBKBLGJIPN EDHFGAMFCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD6E0", Offset = "0x7DFCAE0", VA = "0x187DFD6E0")]
	private static void CMOLNJGIOIJ(EGPLNMAPJMB AGBOCJGKFAH, IReadOnlyDictionary<DFFCINOLDEH, EPKAHJGCHGD> BKMBGIOHEBC, StringBuilder FALPCDINAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E01FC0", Offset = "0x7E013C0", VA = "0x187E01FC0")]
	private static bool NDFPKCFELNF(string JPIAEONMNFL, [Out] Guid PBFEJJDKLCF, [Out] DFFCINOLDEH LCMAJKBCACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E01880", Offset = "0x7E00C80", VA = "0x187E01880")]
	private static void NAOIOEFDHIL(OIBKBLGJIPN EDHFGAMFCNC, StringBuilder FALPCDINAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3508140", Offset = "0x3507540", VA = "0x183508140", Slot = "16")]
	public bool EAACCCEJCEA<T>(DFFCINOLDEH LCMAJKBCACM, FPCJMGENLEJ NABOCLBCNCC, bool CBHKFCAHBMB, T EEHMKJMNANF, [Optional] Action PIOACHJDPOO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE5C0", Offset = "0x7DFD9C0", VA = "0x187DFE5C0", Slot = "17")]
	public string FIIOKEBELCM(FPCJMGENLEJ NABOCLBCNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E00D10", Offset = "0x7E00110", VA = "0x187E00D10")]
	private void LBLJPBGPAIP(DFFCINOLDEH LCMAJKBCACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD2C0", Offset = "0x7DFC6C0", VA = "0x187DFD2C0")]
	private bool AGBJPMCMGIC(NOFCMGEHFOO EMIBCBKNENI, DFFCINOLDEH LCMAJKBCACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE280", Offset = "0x7DFD680", VA = "0x187DFE280")]
	internal EPKAHJGCHGD FGOPONKEMLN(NOFCMGEHFOO EMIBCBKNENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD660", Offset = "0x7DFCA60", VA = "0x187DFD660", Slot = "13")]
	public IReadOnlyList<DAJGIHKBPMI> CANCPIPFGHI(NOFCMGEHFOO EMIBCBKNENI, bool MNBHDOCBKLE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7E020D0", Offset = "0x7E014D0", VA = "0x187E020D0")]
	internal IReadOnlyList<EPKAHJGCHGD> NIKKONNJFKE(NOFCMGEHFOO EMIBCBKNENI, bool MNBHDOCBKLE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7E00580", Offset = "0x7DFF980", VA = "0x187E00580")]
	private void KLMHKJLNCGL(DJIBDADPHAK MBOILFDAICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7DFCFE0", Offset = "0x7DFC3E0", VA = "0x187DFCFE0")]
	private static bool AEOJGOMEALO(EPKAHJGCHGD MHJNNJDGKJK, IReadOnlyDictionary<DFFCINOLDEH, EPKAHJGCHGD> BKMBGIOHEBC, [Out] IReadOnlyList<FPCJMGENLEJ> OMBHGLEPPGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7E01400", Offset = "0x7E00800", VA = "0x187E01400")]
	[AsyncStateMachine(typeof(HPOFPDKFDFO))]
	private static Task MHIBIPEMICI(MOAOGIJGMIG CFHMOFCAGNL, OIBKBLGJIPN EDHFGAMFCNC, IReadOnlyDictionary<DFFCINOLDEH, EPKAHJGCHGD> BKMBGIOHEBC, JJHMNFHFHIL NLLOMHBDPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDFE0", Offset = "0x7DFD3E0", VA = "0x187DFDFE0")]
	[CompilerGenerated]
	internal static void FGHLCMIKMFI(Func<AHGGLBDMFKN, PEDBNHOCMJI> NHDOIOCAEHG, CDOGLMAJPJM P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E00200", Offset = "0x7DFF600", VA = "0x187E00200")]
	[CompilerGenerated]
	internal static bool KILEBDPCKKI(DFFCINOLDEH LCMAJKBCACM, FPCJMGENLEJ NABOCLBCNCC, [Out] DIIKPGCOBKG JBKDOBPCKEL, CFJOPALBMNG P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface KMLNKGJIBCE
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCPLMLEDHMM(NOFCMGEHFOO CKEJGCJMNJG, NOFCMGEHFOO JCGKEEJICEH, IEnumerable<NOFCMGEHFOO> DLCIDBIBGKK, [Out] IDJLOGIIMJB CJPBAHCBDCE, [Out] MAPHDKJNDNF OBEJECAKLII);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string IENELCHOPGP(MAPHDKJNDNF EEMJDBEHHLK);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum MAPHDKJNDNF : byte
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
internal class FCACEJEALEK : KMLNKGJIBCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly JLDHFHDIFFB ACANGAAGCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly BAHOEEMOHKM MCGFABCNAID;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x96FAD0", Offset = "0x96EED0", VA = "0x18096FAD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FCACEJEALEK([PNFCCJKFMBH(null)] JLDHFHDIFFB APHCPLAMIDO, [PNFCCJKFMBH(null)] BAHOEEMOHKM CIILKPBDAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7DFB2D0", Offset = "0x7DFA6D0", VA = "0x187DFB2D0")]
	private static MAEJONMHNOJ? AJJNJFFCEEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7DFBA30", Offset = "0x7DFAE30", VA = "0x187DFBA30", Slot = "4")]
	public bool PCPLMLEDHMM(NOFCMGEHFOO CKEJGCJMNJG, NOFCMGEHFOO JCGKEEJICEH, IEnumerable<NOFCMGEHFOO> DLCIDBIBGKK, [Out] IDJLOGIIMJB CJPBAHCBDCE, [Out] MAPHDKJNDNF OBEJECAKLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7DFB930", Offset = "0x7DFAD30", VA = "0x187DFB930", Slot = "5")]
	public string IENELCHOPGP(MAPHDKJNDNF EEMJDBEHHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7DFB310", Offset = "0x7DFA710", VA = "0x187DFB310")]
	internal bool HMGCEDNMNMF(NOFCMGEHFOO CKEJGCJMNJG, NOFCMGEHFOO JCGKEEJICEH, IEnumerable<NOFCMGEHFOO> DLCIDBIBGKK, FGPODGGHBLK BMCIAEPHBNG, MAEJONMHNOJ? GNGOLANFKAC, [Out] IDJLOGIIMJB CJPBAHCBDCE, [Out] MAPHDKJNDNF OBEJECAKLII)
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

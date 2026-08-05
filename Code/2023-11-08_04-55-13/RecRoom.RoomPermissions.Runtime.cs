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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x642A160", Offset = "0x6428F60", VA = "0x18642A160")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x799BA0", Offset = "0x7989A0", VA = "0x180799BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OGLCMKHOHBO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void NPBPBGBIMGJ<TPermission>(TPermission BEMKOPGNEDI);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HIAGANPAKHA(IPAKCCOJEDA CDPDNIBBMJC);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KDJAHJNJKLF
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HMEDGLHHGLC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FNPMAILBKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool GEFFBNCOALK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JNKMGMCCLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FADBBPCAMDA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HGFGOIAIDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BKPCPJMFMKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class PDIMPJNPKJE
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum EOMCCJOCDFO
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
	public static readonly Guid DPKLKLNOCOC;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid CJIIGPMIHBI;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid EKBEPDENOCF;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid AKCKIIFMAGI;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid LHLCHDPAPDF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid KLBIHCJHABM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly KLJONNPNKOB<NKNIPGBFGFH, Guid> BNENGHKKFPN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<NKNIPGBFGFH> GFPBBDBJECM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x642B010", Offset = "0x6429E10", VA = "0x18642B010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x642AF40", Offset = "0x6429D40", VA = "0x18642AF40")]
	public static NKNIPGBFGFH ICALDAPEDID(Guid CHLMGBPAGHG)
	{
		return default(NKNIPGBFGFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x642B090", Offset = "0x6429E90", VA = "0x18642B090")]
	public static Guid OKKHGIBLKAI(NKNIPGBFGFH HCFKLGEOBNA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x642AEB0", Offset = "0x6429CB0", VA = "0x18642AEB0")]
	public static bool GEADFGGLKBA(NKNIPGBFGFH HCFKLGEOBNA, [Out] Guid CHLMGBPAGHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x642AD20", Offset = "0x6429B20", VA = "0x18642AD20")]
	public static bool CCFBCKNBFGA(Guid CHLMGBPAGHG, [Out] NKNIPGBFGFH HCFKLGEOBNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x642ADC0", Offset = "0x6429BC0", VA = "0x18642ADC0")]
	public static NKNIPGBFGFH ENCGPDNPKLN(NKNIPGBFGFH HCFKLGEOBNA)
	{
		return default(NKNIPGBFGFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x642AE00", Offset = "0x6429C00", VA = "0x18642AE00")]
	public static EOMCCJOCDFO EPDFDPAJNOH(NKNIPGBFGFH NONIBBIKAJF)
	{
		return default(EOMCCJOCDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x642AFD0", Offset = "0x6429DD0", VA = "0x18642AFD0")]
	internal static NKNIPGBFGFH KLCGIBKDPIF(EOMCCJOCDFO HIIJPIIKKGB)
	{
		return default(NKNIPGBFGFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BMEMAKHKMIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	EDGHOOODNFP HLFFOIBEIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<KNPPHHOOEAB> PLNFCMINCFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HIAGANPAKHA BMHKGHPOLMK;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<KNPPHHOOEAB> KHFFDKDMMKG(bool CMMGEMAGPDJ = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KNPPHHOOEAB HKENIOKDNKI(IPAKCCOJEDA CDPDNIBBMJC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JBMHFAHBGLN(IPAKCCOJEDA CDPDNIBBMJC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<KNPPHHOOEAB> HBCOOPMPPBP(IPAKCCOJEDA CDPDNIBBMJC, bool DICOCDIDJAJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GJAFAEPGCDA(IPAKCCOJEDA POILGFLJECO, NKNIPGBFGFH HCFKLGEOBNA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KNPPHHOOEAB JNFAIFCACJJ(NKNIPGBFGFH HCFKLGEOBNA);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JKLNEOBJOJH<T>(NKNIPGBFGFH HCFKLGEOBNA, MHIJDEFMHPE BEMKOPGNEDI, bool HBDENKEPEDJ, T DGPDINALLHC) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JBBCKOEGMBI
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AMJEFDLFDID(LJCPPKMEKBD PBPDKBKCOEP, CancellationToken ELPOPHCEGNN);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LAKCBOKPJFE(LJCPPKMEKBD PBPDKBKCOEP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LEADPLCIFEH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IPAKCCOJEDA JHABHJDDJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ADHMNGMGDGK ABIIJHPPANI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NHAAALGKHMB KKGPOJHIKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<JKOMPPKGAJO> NGDCLCDNLFC;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MAAKAAMPNEP;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NKNIPGBFGFH NHGGMOPNAEB(IPAKCCOJEDA CDPDNIBBMJC);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<JKOMPPKGAJO> MBFAKPCALOO(CancellationToken ELPOPHCEGNN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GKFIKJCJGLJ(long GCFELHFPIGG, long PDNAFDGOEDL, IReadOnlyList<MELAPIMEKMA> HDFHCLGIDPJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<IPAKCCOJEDA> DKCEOJFPCBE();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DIKDGMNJJMB
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6420150", Offset = "0x641EF50", VA = "0x186420150")]
	public static NKNIPGBFGFH LLBHAIDEHHH(this LEADPLCIFEH OPMNIGAJFCF)
	{
		return default(NKNIPGBFGFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IKGEJFCJIJN<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string NOCDPCLBNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NPBPBGBIMGJ<TPermission> JCGAMEDIOAF;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class HHEBPJJOKFC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? HDLEDLJJFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x770F00", Offset = "0x76FD00", VA = "0x180770F00")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
	protected HHEBPJJOKFC(object? NLNJLDKBIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool OKHJGDGOHOJ(object? PHPDIJICBJO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class JMMIDHKFADD<T> : HHEBPJJOKFC where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T ICGNBKFLKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> POCKAPPDGKD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T DHGNDNJJJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81EC90", Offset = "0x81DA90", VA = "0x18081EC90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x39C5DF0", Offset = "0x39C4BF0", VA = "0x1839C5DF0", Slot = "4")]
	public override bool OKHJGDGOHOJ(object? PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x39C6070", Offset = "0x39C4E70", VA = "0x1839C6070")]
	public bool PJOKCBAOCHA(T EPNHBNANDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x39C6370", Offset = "0x39C5170", VA = "0x1839C6370")]
	public JMMIDHKFADD(T JDDKNLMJJIF, IEqualityComparer<T> POCKAPPDGKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class AKPCOKGHDHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<MHIJDEFMHPE, bool> HNJNDEFKGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<MHIJDEFMHPE, HHEBPJJOKFC> NMPBJGJAIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly KOJKNGJGNCJ DMKEFNIALFD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x641EAD0", Offset = "0x641D8D0", VA = "0x18641EAD0")]
	public AKPCOKGHDHK(KOJKNGJGNCJ DMKEFNIALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x641E8B0", Offset = "0x641D6B0", VA = "0x18641E8B0")]
	public bool IHCIBJMJAPK(MHIJDEFMHPE BEMKOPGNEDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2B111E0", Offset = "0x2B0FFE0", VA = "0x182B111E0")]
	public bool IMPBKNOADOB<T>(MHIJDEFMHPE BEMKOPGNEDI, bool HBDENKEPEDJ, T PHPDIJICBJO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B10E10", Offset = "0x2B0FC10", VA = "0x182B10E10")]
	public (bool, T?) HMNEFDDIMAE<T>(MHIJDEFMHPE BEMKOPGNEDI) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x641E920", Offset = "0x641D720", VA = "0x18641E920")]
	public bool IMPBKNOADOB(MHIJDEFMHPE BEMKOPGNEDI, bool HBDENKEPEDJ, object PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x641E7E0", Offset = "0x641D5E0", VA = "0x18641E7E0")]
	public (bool, object) HMNEFDDIMAE(MHIJDEFMHPE BEMKOPGNEDI)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2B116F0", Offset = "0x2B104F0", VA = "0x182B116F0")]
	private void JBBMJACILMI<T>(MHIJDEFMHPE BEMKOPGNEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x641EA00", Offset = "0x641D800", VA = "0x18641EA00")]
	private HHEBPJJOKFC PLBEJHIOLFK(MHIJDEFMHPE BEMKOPGNEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x641E5E0", Offset = "0x641D3E0", VA = "0x18641E5E0")]
	public void HFOGCAJENDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class FHBLFNCBJNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string AMLIJCHMEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type ANPGCMDHKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly KFALCHBJAGJ KHJDADPGBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly MHIJDEFMHPE EPGGCHDAANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public PIJAFIKOEAO EKMADFOLIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MNLEGKNFPLE FAEJOABNGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public JICNJLGHAGO FIHKICKOGPL;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6420340", Offset = "0x641F140", VA = "0x186420340")]
	public FHBLFNCBJNI(Type LDONCDBAMJO, string CPIBLBNONOO, MHIJDEFMHPE BEMKOPGNEDI, PIJAFIKOEAO OANFDGHAMIO, MNLEGKNFPLE IJALJEIFIHN, JICNJLGHAGO OCODCCAEGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x64202F0", Offset = "0x641F0F0", VA = "0x1864202F0")]
	public object KLJKCBADCAK(object? LCIDHBCOPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x24C5300", Offset = "0x24C4100", VA = "0x1824C5300")]
	public void JBBMJACILMI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6420240", Offset = "0x641F040", VA = "0x186420240")]
	public void JBBMJACILMI(Type AHNMONACAMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class DOLKLJMMLJL<T> : FHBLFNCBJNI where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string GNCMMEBOOBO(T PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T ODFLOMJIKJJ(string? OBLKEKJMFLI, T JDDKNLMJJIF);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class IFEJDNIJFNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GNCMMEBOOBO serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public ODFLOMJIKJJ parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public IFEJDNIJFNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3746220", Offset = "0x3745020", VA = "0x183746220")]
		internal string JLHJDNENLDA(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3746180", Offset = "0x3744F80", VA = "0x183746180")]
		internal object HMGMDKHPAMB(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4DC3770", Offset = "0x4DC2570", VA = "0x184DC3770")]
	public DOLKLJMMLJL(MHIJDEFMHPE BEMKOPGNEDI, string CPIBLBNONOO, [Optional] GNCMMEBOOBO? OANFDGHAMIO, [Optional] ODFLOMJIKJJ? IJALJEIFIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2040", Offset = "0x4DC0E40", VA = "0x184DC2040")]
	private static object? LKNPCKIALBL(ODFLOMJIKJJ? IJALJEIFIHN, string? OBLKEKJMFLI, object? JDDKNLMJJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2E50", Offset = "0x4DC1C50", VA = "0x184DC2E50")]
	private static string OJBJHHLKILJ(GNCMMEBOOBO? EDAGJPDJBFL, object? PHPDIJICBJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string PIJAFIKOEAO(object? PHPDIJICBJO);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object MNLEGKNFPLE(string? OBLKEKJMFLI, [Optional] object JDDKNLMJJIF);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate HHEBPJJOKFC JICNJLGHAGO();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class KOJKNGJGNCJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class KCAOIPAKOLB : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static KCAOIPAKOLB ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6428280", Offset = "0x6427080", VA = "0x186428280", Slot = "4")]
		public bool Equals(List<string> GPMOHKANAAB, List<string> GGKPCMCCKDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64283D0", Offset = "0x64271D0", VA = "0x1864283D0", Slot = "5")]
		public int GetHashCode(List<string> KANAGAAAGHJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public KCAOIPAKOLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class AHMEEIGGGMG : CGJOLKIBFHL<OGLCMKHOHBO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x641E4B0", Offset = "0x641D2B0", VA = "0x18641E4B0", Slot = "9")]
		public override string OJBJHHLKILJ(OGLCMKHOHBO JHAPDKALKLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x641E2D0", Offset = "0x641D0D0", VA = "0x18641E2D0", Slot = "10")]
		protected override bool IPBIPNKFMPF(string JHAPDKALKLI, [Out] OGLCMKHOHBO PHPDIJICBJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x641E5A0", Offset = "0x641D3A0", VA = "0x18641E5A0")]
		public AHMEEIGGGMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly PDKFECEGPIC GFAFPIMBFAA;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly AHMEEIGGGMG EPBLDLIONLJ;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<FHBLFNCBJNI> BJDMOAAKKLD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<MHIJDEFMHPE> APENBDNHJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<MHIJDEFMHPE, FHBLFNCBJNI> EABNHPIHHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6429AF0", Offset = "0x64288F0", VA = "0x186429AF0")]
	public KOJKNGJGNCJ([Optional] IList<FHBLFNCBJNI>? DPBDMCPCDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6428C80", Offset = "0x6427A80", VA = "0x186428C80")]
	public FHBLFNCBJNI AFPBNGGHHOC(MHIJDEFMHPE BEMKOPGNEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EDGHOOODNFP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KNPPHHOOEAB FBNNIJFFLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class OGKJJOACKOH : EDGHOOODNFP
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static OGKJJOACKOH NILEPEJHENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly GBMGPLGPOIA CEGFOEJFPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<GBMGPLGPOIA> LJIMPAINJEN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public KNPPHHOOEAB FBNNIJFFLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x642AC10", Offset = "0x6429A10", VA = "0x18642AC10")]
	public OGKJJOACKOH(GBMGPLGPOIA FJBMKNGKFID, IReadOnlyList<GBMGPLGPOIA> HAGMPCFFIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x642A1E0", Offset = "0x6428FE0", VA = "0x18642A1E0")]
	private static OGKJJOACKOH NACKJENJIHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MPOILEIPMOK
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<NKNIPGBFGFH> JPLEJECGMFP;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6429E50", Offset = "0x6428C50", VA = "0x186429E50")]
	public static bool CBFENJKPGIB(this IPAKCCOJEDA JOLNBNLAOPP, NKNIPGBFGFH HCFKLGEOBNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6429F30", Offset = "0x6428D30", VA = "0x186429F30")]
	public static bool NGDCJEJCJDN(this IPAKCCOJEDA JOLNBNLAOPP, NKNIPGBFGFH HCFKLGEOBNA, NHAAALGKHMB CIFAGCOCCLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface BDEAGOHCPLP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool NFPBENEKHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool JGOPGKDHCOA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool HCMAIFHDFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool MNKBKMCPPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool BDGPKDIHKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NFCBPIODCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool AJADCLDKLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool MEIKJMJAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool CMGJCOBMGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GGLFLAIKGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool CPJFEHGJPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool PFDPDBILGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> MLIKNNBKNHE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OGLCMKHOHBO FMKCNBIPIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KNPPHHOOEAB : BDEAGOHCPLP, HMEDGLHHGLC, IKGEJFCJIJN<MHIJDEFMHPE>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string CGLCOBMCJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	NKNIPGBFGFH KBOGIGIBDDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) EKLMOMODABK<T>(MHIJDEFMHPE BEMKOPGNEDI) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum MHIJDEFMHPE
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
internal class GBMGPLGPOIA : KNPPHHOOEAB, BDEAGOHCPLP, HMEDGLHHGLC, IKGEJFCJIJN<MHIJDEFMHPE>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly KOJKNGJGNCJ OPMNAGAIFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly AKPCOKGHDHK DGEHCBFJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? PFDOLBJOAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? LENEIICPKLG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool DJDJHJPKFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x64262E0", Offset = "0x64250E0", VA = "0x1864262E0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool CKOHIFEFLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6426950", Offset = "0x6425750", VA = "0x186426950", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool LHKJDOPLKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x64269F0", Offset = "0x64257F0", VA = "0x1864269F0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool GOBFAKPMKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6425E70", Offset = "0x6424C70", VA = "0x186425E70", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool MDMLLPIIMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6426330", Offset = "0x6425130", VA = "0x186426330", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool BOJKLNOOEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6426A40", Offset = "0x6425840", VA = "0x186426A40", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NKNIPGBFGFH KBOGIGIBDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x81EC90", Offset = "0x81DA90", VA = "0x18081EC90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NKNIPGBFGFH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7717F0", Offset = "0x7705F0", VA = "0x1807717F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string NOCDPCLBNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6427270", Offset = "0x6426070", VA = "0x186427270", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x64266A0", Offset = "0x64254A0", VA = "0x1864266A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string CGLCOBMCJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6427270", Offset = "0x6426070", VA = "0x186427270", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool COFIPCAACJK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8204F0", Offset = "0x81F2F0", VA = "0x1808204F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x81FDC0", Offset = "0x81EBC0", VA = "0x18081FDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NFPBENEKHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6426650", Offset = "0x6425450", VA = "0x186426650", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public OGLCMKHOHBO FMKCNBIPIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x64272C0", Offset = "0x64260C0", VA = "0x1864272C0", Slot = "20")]
		get
		{
			return default(OGLCMKHOHBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool JGOPGKDHCOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x64269A0", Offset = "0x64257A0", VA = "0x1864269A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool HCMAIFHDFHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x64267F0", Offset = "0x64255F0", VA = "0x1864267F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool MNKBKMCPPKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6426290", Offset = "0x6425090", VA = "0x186426290", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool BDGPKDIHKON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6426900", Offset = "0x6425700", VA = "0x186426900", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool NFCBPIODCND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x64267A0", Offset = "0x64255A0", VA = "0x1864267A0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool AJADCLDKLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6426600", Offset = "0x6425400", VA = "0x186426600", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool MEIKJMJAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x64270F0", Offset = "0x6425EF0", VA = "0x1864270F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool CMGJCOBMGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6426890", Offset = "0x6425690", VA = "0x186426890", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> MLIKNNBKNHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x64266F0", Offset = "0x64254F0", VA = "0x1864266F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GAEKPLFOBED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x64262E0", Offset = "0x64250E0", VA = "0x1864262E0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool ALAPEMBGADB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6426330", Offset = "0x6425130", VA = "0x186426330", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool LGCABKNMFGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6426950", Offset = "0x6425750", VA = "0x186426950", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GGLFLAIKGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6427220", Offset = "0x6426020", VA = "0x186427220", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CPJFEHGJPEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6426750", Offset = "0x6425550", VA = "0x186426750", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NFBILENMAEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x64269F0", Offset = "0x64257F0", VA = "0x1864269F0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool PFDPDBILGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6426240", Offset = "0x6425040", VA = "0x186426240", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JACLJIHBKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6425E70", Offset = "0x6424C70", VA = "0x186425E70", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DKACEILJHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6426A40", Offset = "0x6425840", VA = "0x186426A40", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NPBPBGBIMGJ<MHIJDEFMHPE> JCGAMEDIOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6426A90", Offset = "0x6425890", VA = "0x186426A90", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6427040", Offset = "0x6425E40", VA = "0x186427040", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x24EE510", Offset = "0x24ED310", VA = "0x1824EE510", Slot = "6")]
	public (bool, T?) EKLMOMODABK<T>(MHIJDEFMHPE BEMKOPGNEDI) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x24EE4D0", Offset = "0x24ED2D0", VA = "0x1824EE4D0")]
	public GBMGPLGPOIA ADOHODEHPDG<T>(MHIJDEFMHPE BEMKOPGNEDI, bool HBDENKEPEDJ, T PHPDIJICBJO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6427EB0", Offset = "0x6426CB0", VA = "0x186427EB0")]
	public GBMGPLGPOIA(NKNIPGBFGFH HCFKLGEOBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6428030", Offset = "0x6426E30", VA = "0x186428030")]
	public GBMGPLGPOIA(NKNIPGBFGFH HCFKLGEOBNA, [Optional] string? PFDOLBJOAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6427E20", Offset = "0x6426C20", VA = "0x186427E20")]
	public GBMGPLGPOIA(GBMGPLGPOIA NEADNBBKPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6427ED0", Offset = "0x6426CD0", VA = "0x186427ED0")]
	internal GBMGPLGPOIA(NKNIPGBFGFH DJFJFEOJFJE, [Optional] string? PFDOLBJOAIG, [Optional] GBMGPLGPOIA? NEADNBBKPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6426380", Offset = "0x6425180", VA = "0x186426380")]
	public static KFALCHBJAGJ CLIALJJMIHA(MHIJDEFMHPE BEMKOPGNEDI)
	{
		return default(KFALCHBJAGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x64268E0", Offset = "0x64256E0", VA = "0x1864268E0")]
	public void HFOGCAJENDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6425EC0", Offset = "0x6424CC0", VA = "0x186425EC0")]
	internal GBMGPLGPOIA BDEHPLCAHMJ(GBMGPLGPOIA PIHGDBENOIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6426BD0", Offset = "0x64259D0", VA = "0x186426BD0")]
	internal IReadOnlyCollection<MHIJDEFMHPE> KLIGLKFNLOP(GBMGPLGPOIA NEADNBBKPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6427140", Offset = "0x6425F40", VA = "0x186427140")]
	public bool MFFKKFINMBD(MHIJDEFMHPE BEMKOPGNEDI, bool HBDENKEPEDJ, string AFAHLHBHFFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6427310", Offset = "0x6426110", VA = "0x186427310")]
	public (bool, string) PGBDBPIAGBM(MHIJDEFMHPE BEMKOPGNEDI)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6426840", Offset = "0x6425640", VA = "0x186426840")]
	internal void HDEJBLDJBBI(MHIJDEFMHPE BEMKOPGNEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6426400", Offset = "0x6425200", VA = "0x186426400")]
	public IGNLPILKLMC EBAIMCJLMCI(Func<NKNIPGBFGFH, Guid> HAPLFJCNLPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6427410", Offset = "0x6426210", VA = "0x186427410")]
	public void PNIKGOJBGLP(IGNLPILKLMC LEFKCDECFNF, Func<Guid, NKNIPGBFGFH> EGAAPLFPCFC, [Optional] NKNIPGBFGFH? IOIOPDIMDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6426B40", Offset = "0x6425940", VA = "0x186426B40")]
	[CompilerGenerated]
	private void KHALNKACHGC(MHIJDEFMHPE PBDMMGIBPHB, PGALHFJAONP JMCJGGKNJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FIACGAAHFIM : JBBCKOEGMBI, BMEMAKHKMIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class JMDAKMDHKIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public GBMGPLGPOIA newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public JMDAKMDHKIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6428250", Offset = "0x6427050", VA = "0x186428250")]
		internal bool BMFBPANJGND(GBMGPLGPOIA rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MPLGGBNHDOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NKNIPGBFGFH roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public MPLGGBNHDOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6429E40", Offset = "0x6428C40", VA = "0x186429E40")]
		internal bool DEABPDKIOMI(NKNIPGBFGFH r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct KGAFDDHPIJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public FIACGAAHFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LJCPPKMEKBD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<JKOMPPKGAJO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x64285C0", Offset = "0x64273C0", VA = "0x1864285C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6428C20", Offset = "0x6427A20", VA = "0x186428C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JLAECEHJLFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public JLAECEHJLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6428050", Offset = "0x6426E50", VA = "0x186428050")]
		internal void GNLKJLKMFOH(IGNLPILKLMC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6428130", Offset = "0x6426F30", VA = "0x186428130")]
		internal void HBMDFMKGJAB(IGNLPILKLMC r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FGDAINLBCPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LJCPPKMEKBD roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FANEDMBBBNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<IGNLPILKLMC, PGALHFJAONP> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public FANEDMBBBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x64201B0", Offset = "0x641EFB0", VA = "0x1864201B0")]
		internal void CELDJDGIGGD(IGNLPILKLMC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6420210", Offset = "0x641F010", VA = "0x186420210")]
		internal void OEOELLMOMCJ(IGNLPILKLMC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x64201E0", Offset = "0x641EFE0", VA = "0x1864201E0")]
		internal void IPKKJOKFKMI(IGNLPILKLMC r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class MMACKLKCEBB<T> where T : notnull
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
			public MMACKLKCEBB<T> <>4__this;

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
			private TaskAwaiter<JKOMPPKGAJO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2F5C390", Offset = "0x2F5B190", VA = "0x182F5C390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8A0", Offset = "0x8BE6A0", VA = "0x1808BF8A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public FIACGAAHFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MHIJDEFMHPE rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NKNIPGBFGFH accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public KFALCHBJAGJ recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public MMACKLKCEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3CC44B0", Offset = "0x3CC32B0", VA = "0x183CC44B0")]
		[AsyncStateMachine(typeof(MMACKLKCEBB<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void BCGIAJHJONE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct NCAADOIGBKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<MELAPIMEKMA> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CHDPHGNCEBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LEADPLCIFEH rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public LJCPPKMEKBD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<NKNIPGBFGFH, GBMGPLGPOIA> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public LJJNDAKCKFN debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x641ED80", Offset = "0x641DB80", VA = "0x18641ED80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x641F890", Offset = "0x641E690", VA = "0x18641F890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly LEADPLCIFEH OPMNIGAJFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly OGKJJOACKOH JCLDDGBCIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly LJJNDAKCKFN PAGGDEHFIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, GBMGPLGPOIA> HEKAJEBJEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<NKNIPGBFGFH, GBMGPLGPOIA> GBHLENGOJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<NKNIPGBFGFH, GBMGPLGPOIA> KOCIEFHLKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<GBMGPLGPOIA> IGBPJBNGOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool LMBBIAPHPBF;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly MHIJDEFMHPE[] CJOFGCPGBDD;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public EDGHOOODNFP HLFFOIBEIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<KNPPHHOOEAB> PLNFCMINCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6421720", Offset = "0x6420520", VA = "0x186421720", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HIAGANPAKHA BMHKGHPOLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x64220A0", Offset = "0x6420EA0", VA = "0x1864220A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6422000", Offset = "0x6420E00", VA = "0x186422000", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6422140", Offset = "0x6420F40", VA = "0x186422140")]
	[IBKPEPPEMNJ(INBBGMADPCI.Room, MIBJABCBNEH.None)]
	private static void GLHDCMGJMLB(KIDCBAFLGEK NOFONEKOMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6425BB0", Offset = "0x64249B0", VA = "0x186425BB0")]
	[UnityEngine.Scripting.Preserve]
	internal FIACGAAHFIM([HOHGLGKGFHE(null)] LEADPLCIFEH JPIPJEBOIJG, [HOHGLGKGFHE(null)] OGKJJOACKOH GEBMIOHLPLN, [HOHGLGKGFHE(null)] LJJNDAKCKFN PAGGDEHFIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6421B70", Offset = "0x6420970", VA = "0x186421B70", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6425160", Offset = "0x6423F60", VA = "0x186425160")]
	private void PLLMKEBKOFB(IEnumerable<GBMGPLGPOIA> DPPHAOPKMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6422AC0", Offset = "0x64218C0", VA = "0x186422AC0", Slot = "12")]
	public bool JBMHFAHBGLN(IPAKCCOJEDA CDPDNIBBMJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6423760", Offset = "0x6422560", VA = "0x186423760")]
	private void MAAKAAMPNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6421C80", Offset = "0x6420A80", VA = "0x186421C80")]
	private void GFGAAMBCLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6423470", Offset = "0x6422270", VA = "0x186423470", Slot = "10")]
	public IReadOnlyList<KNPPHHOOEAB> KHFFDKDMMKG(bool CMMGEMAGPDJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6422310", Offset = "0x6421110", VA = "0x186422310", Slot = "11")]
	public KNPPHHOOEAB HKENIOKDNKI(IPAKCCOJEDA CDPDNIBBMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6421770", Offset = "0x6420570", VA = "0x186421770")]
	private NKNIPGBFGFH DDHGICMDJEI(IPAKCCOJEDA CDPDNIBBMJC)
	{
		return default(NKNIPGBFGFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6421E70", Offset = "0x6420C70", VA = "0x186421E70", Slot = "14")]
	public bool GJAFAEPGCDA(IPAKCCOJEDA POILGFLJECO, NKNIPGBFGFH HCFKLGEOBNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6422F00", Offset = "0x6421D00", VA = "0x186422F00", Slot = "15")]
	public KNPPHHOOEAB JNFAIFCACJJ(NKNIPGBFGFH HCFKLGEOBNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6421840", Offset = "0x6420640", VA = "0x186421840")]
	private static bool DJDJMGIAKBO(MLMFMNDJAMB JJNOFDCCEOM, NKNIPGBFGFH HCFKLGEOBNA, [Out] IGNLPILKLMC? NLPMLCNJBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6423F60", Offset = "0x6422D60", VA = "0x186423F60")]
	private static void NDLKEMLGNNC(MLMFMNDJAMB JJNOFDCCEOM, Action<IGNLPILKLMC> EFLIEOMFFOM, NKNIPGBFGFH HIBLFJFPCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6423CD0", Offset = "0x6422AD0", VA = "0x186423CD0")]
	private static void NDLKEMLGNNC(MLMFMNDJAMB JJNOFDCCEOM, Action<IGNLPILKLMC> EFLIEOMFFOM, Predicate<NKNIPGBFGFH> OBHKLAEKFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6422420", Offset = "0x6421220", VA = "0x186422420")]
	private void HNIMKDNBHCB(IPAKCCOJEDA CDPDNIBBMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6420EC0", Offset = "0x641FCC0", VA = "0x186420EC0", Slot = "4")]
	[AsyncStateMachine(typeof(KGAFDDHPIJG))]
	public Task AMJEFDLFDID([CanBeNull] LJCPPKMEKBD PBPDKBKCOEP, CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
	public void LAKCBOKPJFE(LJCPPKMEKBD PBPDKBKCOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6422780", Offset = "0x6421580", VA = "0x186422780")]
	private void IPGDOCCAEEH(MLMFMNDJAMB KCOPECLBFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6424050", Offset = "0x6422E50", VA = "0x186424050")]
	internal static string OOMCJDCHMEJ(LEADPLCIFEH OPMNIGAJFCF, LJCPPKMEKBD PBPDKBKCOEP, IReadOnlyDictionary<NKNIPGBFGFH, GBMGPLGPOIA> GBHLENGOJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6424350", Offset = "0x6423150", VA = "0x186424350")]
	private static void OPALAMOIFMA(LJCPPKMEKBD PBPDKBKCOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6423770", Offset = "0x6422570", VA = "0x186423770")]
	private static void MPIBFEMHDEM(MLMFMNDJAMB HFPDOPMJDKD, IReadOnlyDictionary<NKNIPGBFGFH, GBMGPLGPOIA> GBHLENGOJGN, StringBuilder LLEKNALHAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x64234F0", Offset = "0x64222F0", VA = "0x1864234F0")]
	private static bool KIIJBDEEIOP(string LKAGKHGDBHJ, [Out] Guid ECCEMCHADOO, [Out] NKNIPGBFGFH HCFKLGEOBNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6420FE0", Offset = "0x641FDE0", VA = "0x186420FE0")]
	private static void BHAHODPFOKC(LJCPPKMEKBD PBPDKBKCOEP, StringBuilder LLEKNALHAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x24C5D50", Offset = "0x24C4B50", VA = "0x1824C5D50", Slot = "16")]
	public bool JKLNEOBJOJH<T>(NKNIPGBFGFH HCFKLGEOBNA, MHIJDEFMHPE BEMKOPGNEDI, bool HBDENKEPEDJ, T DGPDINALLHC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6423AC0", Offset = "0x64228C0", VA = "0x186423AC0")]
	private void NDGKIKHEBPO(NKNIPGBFGFH HCFKLGEOBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6423740", Offset = "0x6422540", VA = "0x186423740")]
	private bool LNHOFNMAJGN(IPAKCCOJEDA CDPDNIBBMJC, NKNIPGBFGFH HCFKLGEOBNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6420B70", Offset = "0x641F970", VA = "0x186420B70")]
	internal GBMGPLGPOIA ALJKLAEHCFA(IPAKCCOJEDA CDPDNIBBMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6422300", Offset = "0x6421100", VA = "0x186422300", Slot = "13")]
	public IReadOnlyList<KNPPHHOOEAB> HBCOOPMPPBP(IPAKCCOJEDA CDPDNIBBMJC, bool DICOCDIDJAJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6422FA0", Offset = "0x6421DA0", VA = "0x186422FA0")]
	internal IReadOnlyList<GBMGPLGPOIA> JOGCDIOFLIH(IPAKCCOJEDA CDPDNIBBMJC, bool DICOCDIDJAJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x64203E0", Offset = "0x641F1E0", VA = "0x1864203E0")]
	private void AAHIKHBGAMA(JKOMPPKGAJO PDLFJIKJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6422490", Offset = "0x6421290", VA = "0x186422490")]
	private static bool IJGIOCENFGF(GBMGPLGPOIA HLDMIJFLKHL, IReadOnlyDictionary<NKNIPGBFGFH, GBMGPLGPOIA> GBHLENGOJGN, [Out] IReadOnlyList<MHIJDEFMHPE> IBMMALLBEEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6423600", Offset = "0x6422400", VA = "0x186423600")]
	[AsyncStateMachine(typeof(CHDPHGNCEBA))]
	private static Task LMBOOLBAEIJ(LEADPLCIFEH OPMNIGAJFCF, LJCPPKMEKBD PBPDKBKCOEP, IReadOnlyDictionary<NKNIPGBFGFH, GBMGPLGPOIA> GBHLENGOJGN, LJJNDAKCKFN PAGGDEHFIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x64231D0", Offset = "0x6421FD0", VA = "0x1864231D0")]
	[CompilerGenerated]
	internal static void KANOALHKKMN(Func<IGNLPILKLMC, PGALHFJAONP> MAHABJBEPJG, FGDAINLBCPK P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6422B90", Offset = "0x6421990", VA = "0x186422B90")]
	[CompilerGenerated]
	internal static bool JFEIHMGOAGE(NKNIPGBFGFH HCFKLGEOBNA, MHIJDEFMHPE BEMKOPGNEDI, [Out] MELAPIMEKMA CDPFMGIHNFM, NCAADOIGBKD P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface EACNEFNDNBK
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EPAGFGNOKIG(IPAKCCOJEDA CMADIPMLKLD, IPAKCCOJEDA GFDCFJFLNHJ, IEnumerable<IPAKCCOJEDA> HOFJONHMFOA, [Out] OGLCMKHOHBO HMIILCPJMLG, [Out] HLJMMIPHOJK CBCFBBCEEKK);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BPKJCPIGPLJ(HLJMMIPHOJK DPJMHPGLBPH);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum HLJMMIPHOJK : byte
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
internal class CJMCFJNALFE : EACNEFNDNBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly BMEMAKHKMIP OHEFKEFALIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly LNOCJFAAHGF NGAGGHGEENL;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x77D1D0", Offset = "0x77BFD0", VA = "0x18077D1D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CJMCFJNALFE([HOHGLGKGFHE(null)] BMEMAKHKMIP NGFFMECOEMM, [HOHGLGKGFHE(null)] LNOCJFAAHGF OLODMELMKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x641F8F0", Offset = "0x641E6F0", VA = "0x18641F8F0")]
	private static HAFKAFIEAFH? ALAPICPFFHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x641FA30", Offset = "0x641E830", VA = "0x18641FA30", Slot = "4")]
	public bool EPAGFGNOKIG(IPAKCCOJEDA CMADIPMLKLD, IPAKCCOJEDA GFDCFJFLNHJ, IEnumerable<IPAKCCOJEDA> HOFJONHMFOA, [Out] OGLCMKHOHBO HMIILCPJMLG, [Out] HLJMMIPHOJK CBCFBBCEEKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x641F930", Offset = "0x641E730", VA = "0x18641F930", Slot = "5")]
	public string BPKJCPIGPLJ(HLJMMIPHOJK DPJMHPGLBPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x641FB30", Offset = "0x641E930", VA = "0x18641FB30")]
	internal bool ODLKMDONJML(IPAKCCOJEDA CMADIPMLKLD, IPAKCCOJEDA GFDCFJFLNHJ, IEnumerable<IPAKCCOJEDA> HOFJONHMFOA, NHAAALGKHMB CIFAGCOCCLM, HAFKAFIEAFH? LEFABLNPMNH, [Out] OGLCMKHOHBO HMIILCPJMLG, [Out] HLJMMIPHOJK CBCFBBCEEKK)
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

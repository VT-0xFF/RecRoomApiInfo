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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6788130", Offset = "0x6786D30", VA = "0x186788130")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HNPPGFNOEIF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void OPAAAGJJNMN<TPermission>(TPermission MIOGFANMOKK);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void CNPIKKMPCKP(IFDGJPHDBFK POHDOBOBLAI);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum JAKHFCPHLBG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GNMCONCJGCC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OGDJANNOGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NNGEKMMDJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KOHDHEBKMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CLGCBCAEGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NDDJOKLJBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AGGHBDPMLBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class AKDGKCHEPDP
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum KBKKJEALJAD
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
	public static readonly Guid JNCCFPJBMLG;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid ABEBAPAALLC;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid GEMMKINHBKB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid IBMGCHAIHMC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid IFJINCCLBGM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid FPNHAMCBKAM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly DAJNAAKCDOL<FCBBBJOCNBI, Guid> IHGONHCJOIO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<FCBBBJOCNBI> BAMGJKDIPON
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x677B240", Offset = "0x6779E40", VA = "0x18677B240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x677B0D0", Offset = "0x6779CD0", VA = "0x18677B0D0")]
	public static FCBBBJOCNBI EJCDNFPOCLK(Guid AGEGEBLOPIL)
	{
		return default(FCBBBJOCNBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x677B1A0", Offset = "0x6779DA0", VA = "0x18677B1A0")]
	public static Guid KPIGCBJBIJK(FCBBBJOCNBI BBMIBIHAJCI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x677B3A0", Offset = "0x6779FA0", VA = "0x18677B3A0")]
	public static bool PMNJDHJGBKN(FCBBBJOCNBI BBMIBIHAJCI, [Out] Guid AGEGEBLOPIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x677B300", Offset = "0x6779F00", VA = "0x18677B300")]
	public static bool OLNELALBJAD(Guid AGEGEBLOPIL, [Out] FCBBBJOCNBI BBMIBIHAJCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x677B2C0", Offset = "0x6779EC0", VA = "0x18677B2C0")]
	public static FCBBBJOCNBI NOOECLKLJCI(FCBBBJOCNBI BBMIBIHAJCI)
	{
		return default(FCBBBJOCNBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x677B020", Offset = "0x6779C20", VA = "0x18677B020")]
	public static KBKKJEALJAD CJKMIDCNKJM(FCBBBJOCNBI BBNACGMIMOE)
	{
		return default(KBKKJEALJAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x677B160", Offset = "0x6779D60", VA = "0x18677B160")]
	internal static FCBBBJOCNBI JICOIDOHIOP(KBKKJEALJAD HAJILNILIOM)
	{
		return default(FCBBBJOCNBI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LMDHDFDJOMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NJEAAKIMGOO KKEHEJIAFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<BKDPFMINLKC> GCJBGFPHEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CNPIKKMPCKP HMNHOIJEBNE;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<BKDPFMINLKC> MMPCDJGELFM(bool ADMKJAHDMGF = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BKDPFMINLKC MGLDAOEHFPI(IFDGJPHDBFK POHDOBOBLAI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FKNNDJBCHBE(IFDGJPHDBFK POHDOBOBLAI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<BKDPFMINLKC> BIAHNNOLKMI(IFDGJPHDBFK POHDOBOBLAI, bool AHFLLLDLCHG = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HFLJKAJHLKJ(IFDGJPHDBFK HEHNOMNHBDP, FCBBBJOCNBI BBMIBIHAJCI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BKDPFMINLKC DCOBPMJOBFF(FCBBBJOCNBI BBMIBIHAJCI);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BIDIAEBKPOB<T>(FCBBBJOCNBI BBMIBIHAJCI, OGKHGGEONIC MIOGFANMOKK, bool JMOFFFJINOG, T KPLKBKJIAEI, [Optional] Action NGGOBIOBKHN) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OLAAHLHLMDK
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AFGMPKCJKHJ(KAILJKAMMLK MAOJLJBOFIK, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNOCADHEBDC(KAILJKAMMLK MAOJLJBOFIK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ELHDMJKFAGK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IFDGJPHDBFK CIBDPCDMPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JENGLAFMNAE ABOJJHFMNIG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EOHIAKIOJAN PABKEANJOMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CMJMDMDILDO> COACCIHLCPN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OLBDHGNJEMH;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FCBBBJOCNBI OLDBFDFAIOD(IFDGJPHDBFK POHDOBOBLAI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CMJMDMDILDO> MNLDIHFLFKP(CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task AJGBLBENDAE(long MGDJPIEDFNB, long FLKBFMIKIPD, IReadOnlyList<CAILNLEFHFE> LKKBCNGKIKL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<IFDGJPHDBFK> KDMDIJOIIDD();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BEDGBIEMEKO
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x677B750", Offset = "0x677A350", VA = "0x18677B750")]
	public static FCBBBJOCNBI PHMINIHMJJF(this ELHDMJKFAGK OHBHDJMFGPK)
	{
		return default(FCBBBJOCNBI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DPDDIJNLDHL<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string DGBEEJJINMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OPAAAGJJNMN<TPermission> IAMDDGNMBPO;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class CHCHAHJNBBB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? ICFNGKOIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	protected CHCHAHJNBBB(object? COAIGDDIHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool BCGBDCOPDAE(object? BLKAHBIJBJO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class MLAFMCAENDO<T> : CHCHAHJNBBB where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T IHGHBPMHEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> BEKCNBGJCPO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T BLAEOCKJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82E0E0", Offset = "0x82CCE0", VA = "0x18082E0E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F950", Offset = "0x3E5E550", VA = "0x183E5F950", Slot = "4")]
	public override bool BCGBDCOPDAE(object? BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E5FD20", Offset = "0x3E5E920", VA = "0x183E5FD20")]
	public bool NHDMMFNICBO(T EFCEHJFFFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E5FE50", Offset = "0x3E5EA50", VA = "0x183E5FE50")]
	public MLAFMCAENDO(T FCKGAANHHID, IEqualityComparer<T> BEKCNBGJCPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class JCMGOGJMLLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<OGKHGGEONIC, bool> EAHEFBPAJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<OGKHGGEONIC, CHCHAHJNBBB> PLECIGDLGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly FHBHGAIICAK DDLFMHHMOOJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67814A0", Offset = "0x67800A0", VA = "0x1867814A0")]
	public JCMGOGJMLLI(FHBHGAIICAK DDLFMHHMOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6781080", Offset = "0x677FC80", VA = "0x186781080")]
	public bool EOHOLHBHKFH(OGKHGGEONIC MIOGFANMOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2839EE0", Offset = "0x2838AE0", VA = "0x182839EE0")]
	public bool LIOMCGCCOEM<T>(OGKHGGEONIC MIOGFANMOKK, bool JMOFFFJINOG, T BLKAHBIJBJO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2839AD0", Offset = "0x28386D0", VA = "0x182839AD0")]
	public (bool, T?) AKBMBBDNEFI<T>(OGKHGGEONIC MIOGFANMOKK) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x67811C0", Offset = "0x677FDC0", VA = "0x1867811C0")]
	public bool LIOMCGCCOEM(OGKHGGEONIC MIOGFANMOKK, bool JMOFFFJINOG, object BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6780FB0", Offset = "0x677FBB0", VA = "0x186780FB0")]
	public (bool, object) AKBMBBDNEFI(OGKHGGEONIC MIOGFANMOKK)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2839EA0", Offset = "0x2838AA0", VA = "0x182839EA0")]
	private void CGCKMDCHEEE<T>(OGKHGGEONIC MIOGFANMOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x67810F0", Offset = "0x677FCF0", VA = "0x1867810F0")]
	private CHCHAHJNBBB IHIHGNFGFAL(OGKHGGEONIC MIOGFANMOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x67812A0", Offset = "0x677FEA0", VA = "0x1867812A0")]
	public void NGAEJJMLEOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class DKHKEDOCGIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string EHAAMAPBCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type GCFPFICIOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly CKCKFIPAEBA JIGGJDLEPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly OGKHGGEONIC DFLBLHOMHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public LFCEIAOGKPL EGLBJLHLOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PCCIHPFGFJG GDPAGPOPEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public GGHHDNBFDNN NMMLFPJBBCF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x677CF70", Offset = "0x677BB70", VA = "0x18677CF70")]
	public DKHKEDOCGIH(Type LLJFMGAJIDF, string HJKKEICKEBK, OGKHGGEONIC MIOGFANMOKK, LFCEIAOGKPL ICGPABIMHIA, PCCIHPFGFJG HMLOOINEJLE, GGHHDNBFDNN BCAKHNIBACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x677CE70", Offset = "0x677BA70", VA = "0x18677CE70")]
	public object AEBFFPFGHCJ(object? NAFFCAIMPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2672D00", Offset = "0x2671900", VA = "0x182672D00")]
	public void CGCKMDCHEEE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x677CEC0", Offset = "0x677BAC0", VA = "0x18677CEC0")]
	public void CGCKMDCHEEE(Type GICJJDHKGBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class JPIJGDGOKPF<T> : DKHKEDOCGIH where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string DODJGOJIHPB(T BLKAHBIJBJO);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T CFGBIAIFDOO(string? PJPKPPODKPP, T FCKGAANHHID);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class EBJDONEADMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DODJGOJIHPB serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CFGBIAIFDOO parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public EBJDONEADMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x33045F0", Offset = "0x33031F0", VA = "0x1833045F0")]
		internal string HILAGMEKOAE(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3304620", Offset = "0x3303220", VA = "0x183304620")]
		internal object HNLHLMFNKCB(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B2EFB0", Offset = "0x3B2DBB0", VA = "0x183B2EFB0")]
	public JPIJGDGOKPF(OGKHGGEONIC MIOGFANMOKK, string HJKKEICKEBK, [Optional] DODJGOJIHPB? ICGPABIMHIA, [Optional] CFGBIAIFDOO? HMLOOINEJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B2DB60", Offset = "0x3B2C760", VA = "0x183B2DB60")]
	private static object? DPCADENMEMJ(CFGBIAIFDOO? HMLOOINEJLE, string? PJPKPPODKPP, object? FCKGAANHHID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B2E690", Offset = "0x3B2D290", VA = "0x183B2E690")]
	private static string GAPNIKJAJOO(DODJGOJIHPB? KHCLDMPEOGK, object? BLKAHBIJBJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string LFCEIAOGKPL(object? BLKAHBIJBJO);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object PCCIHPFGFJG(string? PJPKPPODKPP, [Optional] object FCKGAANHHID);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate CHCHAHJNBBB GGHHDNBFDNN();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class FHBHGAIICAK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class MGEJDMPALHM : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static MGEJDMPALHM EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6787DF0", Offset = "0x67869F0", VA = "0x186787DF0", Slot = "4")]
		public bool Equals(List<string> KLNIMOGOBLK, List<string> EGCIDIGPDPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6787F40", Offset = "0x6786B40", VA = "0x186787F40", Slot = "5")]
		public int GetHashCode(List<string> OGGNGHKHHGI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public MGEJDMPALHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class LCNHILAHNDC : CINNGFKCAFK<HNPPGFNOEIF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6782000", Offset = "0x6780C00", VA = "0x186782000", Slot = "9")]
		public override string GAPNIKJAJOO(HNPPGFNOEIF KMJAEAGEOPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6781E20", Offset = "0x6780A20", VA = "0x186781E20", Slot = "10")]
		protected override bool CMMKDGKEILF(string KMJAEAGEOPB, [Out] HNPPGFNOEIF BLKAHBIJBJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x67820F0", Offset = "0x6780CF0", VA = "0x1867820F0")]
		public LCNHILAHNDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly IFCCAKPBANB JANIKFNDGFO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly LCNHILAHNDC FONNGGIAPKO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<DKHKEDOCGIH> ALCLBGBKEAB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<OGKHGGEONIC> JOELPMOAPDI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<OGKHGGEONIC, DKHKEDOCGIH> AMKKGGIHCKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x677EA80", Offset = "0x677D680", VA = "0x18677EA80")]
	public FHBHGAIICAK([Optional] IList<DKHKEDOCGIH>? KPKKFIPKCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x677DC10", Offset = "0x677C810", VA = "0x18677DC10")]
	public DKHKEDOCGIH COEFEFJEHAJ(OGKHGGEONIC MIOGFANMOKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NJEAAKIMGOO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BKDPFMINLKC DCNJFDGCOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class DKEGHHGPPJM : NJEAAKIMGOO
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static DKEGHHGPPJM CEINFGEAOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly INKPAPILEPG MMBLMEHJGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<INKPAPILEPG> IIIPBHILNLM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public BKDPFMINLKC DCNJFDGCOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x677CD60", Offset = "0x677B960", VA = "0x18677CD60")]
	public DKEGHHGPPJM(INKPAPILEPG LNIPILEOCFM, IReadOnlyList<INKPAPILEPG> GKKHDHBODLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x677C330", Offset = "0x677AF30", VA = "0x18677C330")]
	private static DKEGHHGPPJM KOOEGFCFDDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class BPHICOBLHMD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<FCBBBJOCNBI> CLOMIIFCCII;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x677B7B0", Offset = "0x677A3B0", VA = "0x18677B7B0")]
	public static bool KMONKPICFBF(this IFDGJPHDBFK ANJKAMGJFHP, FCBBBJOCNBI BBMIBIHAJCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x677B890", Offset = "0x677A490", VA = "0x18677B890")]
	public static bool OGCIPNNIFDO(this IFDGJPHDBFK ANJKAMGJFHP, FCBBBJOCNBI BBMIBIHAJCI, EOHIAKIOJAN HGHFFDCBAEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface DKBCILIBBAN
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JMADHCAFJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool OOPLBLFPFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool IECPEPIJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool HNCANIMOFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool CGAPCJOKNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NLDIOMMKGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool OLIDPBNBOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool NBMGPAHIOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool FCHINBIIHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MOGLLHCAMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BDEHMEHEDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool IPFALCAOMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> EGPFBDOHLHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HNPPGFNOEIF FCOLBAFJGLI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BKDPFMINLKC : DKBCILIBBAN, GNMCONCJGCC, DPDDIJNLDHL<OGKHGGEONIC>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string NIMDBAOKFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	FCBBBJOCNBI IGCOBDOEAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) MCFCOOOKJMF<T>(OGKHGGEONIC MIOGFANMOKK) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum OGKHGGEONIC
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
internal class INKPAPILEPG : BKDPFMINLKC, DKBCILIBBAN, GNMCONCJGCC, DPDDIJNLDHL<OGKHGGEONIC>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly FHBHGAIICAK BNNONMLMJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly JCMGOGJMLLI EEIGLOHDDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? PIDAEMIKIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? KPHPLGHKNHF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool BGGAFJOLBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x677EFC0", Offset = "0x677DBC0", VA = "0x18677EFC0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool ECIEKHFDCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x677FA60", Offset = "0x677E660", VA = "0x18677FA60", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool HECGDLJLFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x677EED0", Offset = "0x677DAD0", VA = "0x18677EED0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool JMIJHKIKCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x677EF70", Offset = "0x677DB70", VA = "0x18677EF70", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool FIOBJAOLFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6780520", Offset = "0x677F120", VA = "0x186780520", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool CDFHFMIFKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x677F460", Offset = "0x677E060", VA = "0x18677F460", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public FCBBBJOCNBI IGCOBDOEAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x82E0E0", Offset = "0x82CCE0", VA = "0x18082E0E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(FCBBBJOCNBI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C70", Offset = "0x7AF870", VA = "0x1807B0C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string DGBEEJJINMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6780480", Offset = "0x677F080", VA = "0x186780480", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x67804D0", Offset = "0x677F0D0", VA = "0x1867804D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string NIMDBAOKFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6780480", Offset = "0x677F080", VA = "0x186780480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NCAHHGJOINC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86E080", Offset = "0x86CC80", VA = "0x18086E080")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x86D450", Offset = "0x86C050", VA = "0x18086D450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JMADHCAFJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x677FAB0", Offset = "0x677E6B0", VA = "0x18677FAB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HNPPGFNOEIF FCOLBAFJGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x677F8C0", Offset = "0x677E4C0", VA = "0x18677F8C0", Slot = "20")]
		get
		{
			return default(HNPPGFNOEIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OOPLBLFPFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x677F410", Offset = "0x677E010", VA = "0x18677F410", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IECPEPIJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x67806E0", Offset = "0x677F2E0", VA = "0x1867806E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HNCANIMOFLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x677EF20", Offset = "0x677DB20", VA = "0x18677EF20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool CGAPCJOKNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6780730", Offset = "0x677F330", VA = "0x186780730", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool NLDIOMMKGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x677F4B0", Offset = "0x677E0B0", VA = "0x18677F4B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool OLIDPBNBOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6780570", Offset = "0x677F170", VA = "0x186780570", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool NBMGPAHIOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x677F870", Offset = "0x677E470", VA = "0x18677F870", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool FCHINBIIHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6780640", Offset = "0x677F240", VA = "0x186780640", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> EGPFBDOHLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x67805C0", Offset = "0x677F1C0", VA = "0x1867805C0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool PHNFMMGHHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x677EFC0", Offset = "0x677DBC0", VA = "0x18677EFC0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool FOKBOAAPMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6780520", Offset = "0x677F120", VA = "0x186780520", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool AOHCDAMJHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x677FA60", Offset = "0x677E660", VA = "0x18677FA60", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool MOGLLHCAMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x677EE80", Offset = "0x677DA80", VA = "0x18677EE80", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool BDEHMEHEDNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x677F910", Offset = "0x677E510", VA = "0x18677F910", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PGDGDJMCAED
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x677EED0", Offset = "0x677DAD0", VA = "0x18677EED0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool IPFALCAOMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6780690", Offset = "0x677F290", VA = "0x186780690", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool AKLDKBHFPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x677EF70", Offset = "0x677DB70", VA = "0x18677EF70", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CEJNAEHMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x677F460", Offset = "0x677E060", VA = "0x18677F460", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event OPAAAGJJNMN<OGKHGGEONIC> IAMDDGNMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x677EDD0", Offset = "0x677D9D0", VA = "0x18677EDD0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6780780", Offset = "0x677F380", VA = "0x186780780", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x282BFE0", Offset = "0x282ABE0", VA = "0x18282BFE0", Slot = "6")]
	public (bool, T?) MCFCOOOKJMF<T>(OGKHGGEONIC MIOGFANMOKK) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x282BFA0", Offset = "0x282ABA0", VA = "0x18282BFA0")]
	public INKPAPILEPG LJKADNDNJPB<T>(OGKHGGEONIC MIOGFANMOKK, bool JMOFFFJINOG, T BLKAHBIJBJO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6780F90", Offset = "0x677FB90", VA = "0x186780F90")]
	public INKPAPILEPG(FCBBBJOCNBI BBMIBIHAJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6780EE0", Offset = "0x677FAE0", VA = "0x186780EE0")]
	public INKPAPILEPG(FCBBBJOCNBI BBMIBIHAJCI, [Optional] string? PIDAEMIKIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6780F00", Offset = "0x677FB00", VA = "0x186780F00")]
	public INKPAPILEPG(INKPAPILEPG PLJMKOHMPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6780D80", Offset = "0x677F980", VA = "0x186780D80")]
	internal INKPAPILEPG(FCBBBJOCNBI JKIMKGEHECA, [Optional] string? PIDAEMIKIED, [Optional] INKPAPILEPG? PLJMKOHMPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x677F390", Offset = "0x677DF90", VA = "0x18677F390")]
	public static CKCKFIPAEBA EDGNNMNGMNG(OGKHGGEONIC MIOGFANMOKK)
	{
		return default(CKCKFIPAEBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6780620", Offset = "0x677F220", VA = "0x186780620")]
	public void NGAEJJMLEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x677F010", Offset = "0x677DC10", VA = "0x18677F010")]
	internal INKPAPILEPG EAKEEGKMGFB(INKPAPILEPG BNMEKCNDAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6780880", Offset = "0x677F480", VA = "0x186780880")]
	internal IReadOnlyCollection<OGKHGGEONIC> PLJCLLNOGIK(INKPAPILEPG PLJMKOHMPFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x677F590", Offset = "0x677E190", VA = "0x18677F590")]
	public bool FMOHDPBPHGD(OGKHGGEONIC MIOGFANMOKK, bool JMOFFFJINOG, string GGMAGHMODMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x677F960", Offset = "0x677E560", VA = "0x18677F960")]
	public (bool, string) IJAEAANFLAF(OGKHGGEONIC MIOGFANMOKK)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6780830", Offset = "0x677F430", VA = "0x186780830")]
	internal void PLEFOMCDNDH(OGKHGGEONIC MIOGFANMOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x677F670", Offset = "0x677E270", VA = "0x18677F670")]
	public IMHNJALICIF GIHCBMJPLGI(Func<FCBBBJOCNBI, Guid> IINKFPBGPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x677FB00", Offset = "0x677E700", VA = "0x18677FB00")]
	public void KIACEODLIPB(IMHNJALICIF FPPLBEHIGOH, Func<Guid, FCBBBJOCNBI> BDNEDPHDBBM, [Optional] FCBBBJOCNBI? KJDEMJPFGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x677F500", Offset = "0x677E100", VA = "0x18677F500")]
	[CompilerGenerated]
	private void FILEIFJBDGD(OGKHGGEONIC APIHMIJADJB, PNFDCLGEGPN GCFJHNOPLAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MBJEJKHAJFO : OLAAHLHLMDK, LMDHDFDJOMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class AHOGDHHBEPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public INKPAPILEPG newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public AHOGDHHBEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x677AFF0", Offset = "0x6779BF0", VA = "0x18677AFF0")]
		internal bool CACMDPBCIOA(INKPAPILEPG rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CJLDOAPOHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public FCBBBJOCNBI roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public CJLDOAPOHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x677BAC0", Offset = "0x677A6C0", VA = "0x18677BAC0")]
		internal bool JNBOLKGECKJ(FCBBBJOCNBI r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct JGLNFHDJELN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public MBJEJKHAJFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KAILJKAMMLK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<CMJMDMDILDO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6781750", Offset = "0x6780350", VA = "0x186781750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6781DC0", Offset = "0x67809C0", VA = "0x186781DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LGBKBDFPEEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LGBKBDFPEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6782250", Offset = "0x6780E50", VA = "0x186782250")]
		internal void NHBNACJDKDM(IMHNJALICIF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6782130", Offset = "0x6780D30", VA = "0x186782130")]
		internal void GIABJGDEEEH(IMHNJALICIF r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct GBNEBCOMIKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KAILJKAMMLK roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class EOGHHBEHAIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<IMHNJALICIF, PNFDCLGEGPN> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public EOGHHBEHAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x677DB80", Offset = "0x677C780", VA = "0x18677DB80")]
		internal void BKOBGHNMNNE(IMHNJALICIF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x677DBB0", Offset = "0x677C7B0", VA = "0x18677DBB0")]
		internal void DMKFNNNIABA(IMHNJALICIF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x677DBE0", Offset = "0x677C7E0", VA = "0x18677DBE0")]
		internal void OIADADMMEBM(IMHNJALICIF r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AIHJGEALDOF<T> where T : notnull
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
			public AIHJGEALDOF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<CMJMDMDILDO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3128300", Offset = "0x3126F00", VA = "0x183128300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x892CC0", Offset = "0x8918C0", VA = "0x180892CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public MBJEJKHAJFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public OGKHGGEONIC rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public FCBBBJOCNBI accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CKCKFIPAEBA recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public AIHJGEALDOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x37CD080", Offset = "0x37CBC80", VA = "0x1837CD080")]
		[AsyncStateMachine(typeof(AIHJGEALDOF<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void CPELAHJFDKC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JDGDLGHKEME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<CAILNLEFHFE> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct EFNLBPKEAEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public ELHDMJKFAGK rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KAILJKAMMLK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<FCBBBJOCNBI, INKPAPILEPG> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public JHCGFNDBLGH debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x677D010", Offset = "0x677BC10", VA = "0x18677D010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x677DB20", Offset = "0x677C720", VA = "0x18677DB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly ELHDMJKFAGK OHBHDJMFGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly DKEGHHGPPJM JDAGEMHHGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly JHCGFNDBLGH GHBANDGKKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, INKPAPILEPG> DHKFILNLEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<FCBBBJOCNBI, INKPAPILEPG> FHJLEEPFHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<FCBBBJOCNBI, INKPAPILEPG> NPLEMPLDOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<INKPAPILEPG> BGDIFBONAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool JACPPFKPKNG;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly OGKHGGEONIC[] CKJEDGINEDC;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NJEAAKIMGOO KKEHEJIAFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<BKDPFMINLKC> GCJBGFPHEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6782330", Offset = "0x6780F30", VA = "0x186782330", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event CNPIKKMPCKP HMNHOIJEBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6783200", Offset = "0x6781E00", VA = "0x186783200", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6784160", Offset = "0x6782D60", VA = "0x186784160", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6782380", Offset = "0x6780F80", VA = "0x186782380")]
	[JDFNDIEGGDI(EEILJHHLCPL.Room, COFBNFOEGIB.None)]
	private static void ADHPCFGLOFB(OJEGDOKHPNO KFDFGHNENJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6787B30", Offset = "0x6786730", VA = "0x186787B30")]
	[UnityEngine.Scripting.Preserve]
	internal MBJEJKHAJFO([NNEMKPMNJAE(null)] ELHDMJKFAGK OHFDINMOAKP, [NNEMKPMNJAE(null)] DKEGHHGPPJM CBLPFEFNBCK, [NNEMKPMNJAE(null)] JHCGFNDBLGH GHBANDGKKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67830F0", Offset = "0x6781CF0", VA = "0x1867830F0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6786940", Offset = "0x6785540", VA = "0x186786940")]
	private void NJHNNHIFPMF(IEnumerable<INKPAPILEPG> GNFDIFIMJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6783420", Offset = "0x6782020", VA = "0x186783420", Slot = "12")]
	public bool FKNNDJBCHBE(IFDGJPHDBFK POHDOBOBLAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x67873F0", Offset = "0x6785FF0", VA = "0x1867873F0")]
	private void OLBDHGNJEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6786750", Offset = "0x6785350", VA = "0x186786750")]
	private void NGCJAIONDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6785160", Offset = "0x6783D60", VA = "0x186785160", Slot = "10")]
	public IReadOnlyList<BKDPFMINLKC> MMPCDJGELFM(bool ADMKJAHDMGF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6785050", Offset = "0x6783C50", VA = "0x186785050", Slot = "11")]
	public BKDPFMINLKC MGLDAOEHFPI(IFDGJPHDBFK POHDOBOBLAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6784200", Offset = "0x6782E00", VA = "0x186784200")]
	private FCBBBJOCNBI HODCJKDMLFP(IFDGJPHDBFK POHDOBOBLAI)
	{
		return default(FCBBBJOCNBI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6783FD0", Offset = "0x6782BD0", VA = "0x186783FD0", Slot = "14")]
	public bool HFLJKAJHLKJ(IFDGJPHDBFK HEHNOMNHBDP, FCBBBJOCNBI BBMIBIHAJCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6782D20", Offset = "0x6781920", VA = "0x186782D20", Slot = "15")]
	public BKDPFMINLKC DCOBPMJOBFF(FCBBBJOCNBI BBMIBIHAJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6782DC0", Offset = "0x67819C0", VA = "0x186782DC0")]
	private static bool DFDMIIBMBFK(CPOCHFHOIPP JBJHFGCAIMD, FCBBBJOCNBI BBMIBIHAJCI, [Out] IMHNJALICIF? PLODKBINLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6784CD0", Offset = "0x67838D0", VA = "0x186784CD0")]
	private static void LHINFCPOBOC(CPOCHFHOIPP JBJHFGCAIMD, Action<IMHNJALICIF> ILABIBCNFCB, FCBBBJOCNBI HLJMHDPDEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6784DC0", Offset = "0x67839C0", VA = "0x186784DC0")]
	private static void LHINFCPOBOC(CPOCHFHOIPP JBJHFGCAIMD, Action<IMHNJALICIF> ILABIBCNFCB, Predicate<FCBBBJOCNBI> MEJCNDGLMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x67832A0", Offset = "0x6781EA0", VA = "0x1867832A0")]
	private void FDOFBEFODMB(IFDGJPHDBFK POHDOBOBLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6782540", Offset = "0x6781140", VA = "0x186782540", Slot = "4")]
	[AsyncStateMachine(typeof(JGLNFHDJELN))]
	public Task AFGMPKCJKHJ([CanBeNull] KAILJKAMMLK MAOJLJBOFIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
	public void MNOCADHEBDC(KAILJKAMMLK MAOJLJBOFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67829E0", Offset = "0x67815E0", VA = "0x1867829E0")]
	private void BOIKBJMOKEF(CPOCHFHOIPP JLHJFPGNICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x67849C0", Offset = "0x67835C0", VA = "0x1867849C0")]
	internal static string LHAIEDGBJFE(ELHDMJKFAGK OHBHDJMFGPK, KAILJKAMMLK MAOJLJBOFIK, IReadOnlyDictionary<FCBBBJOCNBI, INKPAPILEPG> FHJLEEPFHLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x67851E0", Offset = "0x6783DE0", VA = "0x1867851E0")]
	private static void NBPDOBOOAHC(KAILJKAMMLK MAOJLJBOFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6787610", Offset = "0x6786210", VA = "0x186787610")]
	private static void PJOIODFOIBE(CPOCHFHOIPP POBCDDFPHEC, IReadOnlyDictionary<FCBBBJOCNBI, INKPAPILEPG> FHJLEEPFHLM, StringBuilder PKKEOPPGNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6783310", Offset = "0x6781F10", VA = "0x186783310")]
	private static bool FFCIKDNNFNK(string CMEALKEGCCJ, [Out] Guid PIKKHDDAMEO, [Out] FCBBBJOCNBI BBMIBIHAJCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6786010", Offset = "0x6784C10", VA = "0x186786010")]
	private static void NCMPLOHOLJG(KAILJKAMMLK MAOJLJBOFIK, StringBuilder PKKEOPPGNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2892F90", Offset = "0x2891B90", VA = "0x182892F90", Slot = "16")]
	public bool BIDIAEBKPOB<T>(FCBBBJOCNBI BBMIBIHAJCI, OGKHGGEONIC MIOGFANMOKK, bool JMOFFFJINOG, T KPLKBKJIAEI, [Optional] Action NGGOBIOBKHN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6787400", Offset = "0x6786000", VA = "0x186787400")]
	private void PCEFGLKCLAO(FCBBBJOCNBI BBMIBIHAJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x67842D0", Offset = "0x6782ED0", VA = "0x1867842D0")]
	private bool IMNDCNPEAJB(IFDGJPHDBFK POHDOBOBLAI, FCBBBJOCNBI BBMIBIHAJCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6783C80", Offset = "0x6782880", VA = "0x186783C80")]
	internal INKPAPILEPG HANCCDEHHFC(IFDGJPHDBFK POHDOBOBLAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x67829D0", Offset = "0x67815D0", VA = "0x1867829D0", Slot = "13")]
	public IReadOnlyList<BKDPFMINLKC> BIAHNNOLKMI(IFDGJPHDBFK POHDOBOBLAI, bool AHFLLLDLCHG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x67871C0", Offset = "0x6785DC0", VA = "0x1867871C0")]
	internal IReadOnlyList<INKPAPILEPG> OEMIHBOEDEO(IFDGJPHDBFK POHDOBOBLAI, bool AHFLLLDLCHG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x67834F0", Offset = "0x67820F0", VA = "0x1867834F0")]
	private void GOCMLMFDFGH(CMJMDMDILDO KHJJADICPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x67846D0", Offset = "0x67832D0", VA = "0x1867846D0")]
	private static bool KCPKLEJGPIN(INKPAPILEPG MCFJIDJHJKB, IReadOnlyDictionary<FCBBBJOCNBI, INKPAPILEPG> FHJLEEPFHLM, [Out] IReadOnlyList<OGKHGGEONIC> KCNEGIOOFOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6784590", Offset = "0x6783190", VA = "0x186784590")]
	[AsyncStateMachine(typeof(EFNLBPKEAEK))]
	private static Task JKMNJOCLOOI(ELHDMJKFAGK OHBHDJMFGPK, KAILJKAMMLK MAOJLJBOFIK, IReadOnlyDictionary<FCBBBJOCNBI, INKPAPILEPG> FHJLEEPFHLM, JHCGFNDBLGH GHBANDGKKGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x67842F0", Offset = "0x6782EF0", VA = "0x1867842F0")]
	[CompilerGenerated]
	internal static void IPCBEFMNLIM(Func<IMHNJALICIF, PNFDCLGEGPN> OGNKDMLJGDF, GBNEBCOMIKO P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6782660", Offset = "0x6781260", VA = "0x186782660")]
	[CompilerGenerated]
	internal static bool BGEPFDMDNGD(FCBBBJOCNBI BBMIBIHAJCI, OGKHGGEONIC MIOGFANMOKK, [Out] CAILNLEFHFE FIMELHFJENE, JDGDLGHKEME P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface DDABMPJIJJA
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OLDCMDMFGDO(IFDGJPHDBFK PAGLKOKGACA, IFDGJPHDBFK EAEABLJGELG, IEnumerable<IFDGJPHDBFK> LJBDGDMOCPO, [Out] HNPPGFNOEIF CGGNGMOLBJF, [Out] LEMKJNIDHNH LPCPEGHDANN);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string PCDFEOOGDBD(LEMKJNIDHNH JOOJJBNHDOE);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum LEMKJNIDHNH : byte
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
internal class DGEHMCIECJO : DDABMPJIJJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly LMDHDFDJOMO CPFBAPHBMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NOLIKPGBOMF PBCBHHPIJLH;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7BF470", Offset = "0x7BE070", VA = "0x1807BF470")]
	[RecRoom.NoEngine.Common.Preserve]
	public DGEHMCIECJO([NNEMKPMNJAE(null)] LMDHDFDJOMO HFMBCFMLKEN, [NNEMKPMNJAE(null)] NOLIKPGBOMF MHDACFNICOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x677BAD0", Offset = "0x677A6D0", VA = "0x18677BAD0")]
	private static AMHFOAEFDAH? BBLBIKNJOOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x677C130", Offset = "0x677AD30", VA = "0x18677C130", Slot = "4")]
	public bool OLDCMDMFGDO(IFDGJPHDBFK PAGLKOKGACA, IFDGJPHDBFK EAEABLJGELG, IEnumerable<IFDGJPHDBFK> LJBDGDMOCPO, [Out] HNPPGFNOEIF CGGNGMOLBJF, [Out] LEMKJNIDHNH LPCPEGHDANN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x677C230", Offset = "0x677AE30", VA = "0x18677C230", Slot = "5")]
	public string PCDFEOOGDBD(LEMKJNIDHNH JOOJJBNHDOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x677BB10", Offset = "0x677A710", VA = "0x18677BB10")]
	internal bool LOLFBPIHIAD(IFDGJPHDBFK PAGLKOKGACA, IFDGJPHDBFK EAEABLJGELG, IEnumerable<IFDGJPHDBFK> LJBDGDMOCPO, EOHIAKIOJAN HGHFFDCBAEB, AMHFOAEFDAH? BMHAJKOEDGN, [Out] HNPPGFNOEIF CGGNGMOLBJF, [Out] LEMKJNIDHNH LPCPEGHDANN)
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

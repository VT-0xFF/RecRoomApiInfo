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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x6635B20", Offset = "0x6634520", VA = "0x186635B20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B8FA0", VA = "0x1807BA5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MOEELKEHIKL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void MHMLNJKGPJH<TPermission>(TPermission OBHHHMCGCJO);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HCBGGPHNENE(ALIAPFOBNEL GPBJMOIHKHJ);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum PFHCGPICOFE
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GMJCOEBMNMP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MFIPMDLPFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool OFMGNEAOAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MKFCCMHEHND
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NKPPAPFHBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GIBLHFABKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MFIPIDDEMFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class LLABAMEHMNG
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum LHMKGBONOKM
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
	public static readonly Guid DADBFHIOIND;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid IBNJEGFFLAG;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid MFDDPLCPDEN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid LDAOEPKFJJO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid KGMODDPOOEE;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid CHHHKECJJEH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly COEDLFJDMNE<EAJCNPHALOG, Guid> BOANCDCANHI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<EAJCNPHALOG> CFCKACOOCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6635580", Offset = "0x6633F80", VA = "0x186635580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x66354F0", Offset = "0x6633EF0", VA = "0x1866354F0")]
	public static EAJCNPHALOG PJFHPEDFAMM(Guid DMMBGEACBPP)
	{
		return default(EAJCNPHALOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6635410", Offset = "0x6633E10", VA = "0x186635410")]
	public static Guid HABAOIHPIOA(EAJCNPHALOG ONHMAOJLIAF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6635380", Offset = "0x6633D80", VA = "0x186635380")]
	public static bool DHOGENJHBCC(EAJCNPHALOG ONHMAOJLIAF, [Out] Guid DMMBGEACBPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x66351F0", Offset = "0x6633BF0", VA = "0x1866351F0")]
	public static bool AKCNNJOJGGN(Guid DMMBGEACBPP, [Out] EAJCNPHALOG ONHMAOJLIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x66354B0", Offset = "0x6633EB0", VA = "0x1866354B0")]
	public static EAJCNPHALOG NCFMGEHEOPN(EAJCNPHALOG ONHMAOJLIAF)
	{
		return default(EAJCNPHALOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6635290", Offset = "0x6633C90", VA = "0x186635290")]
	public static LHMKGBONOKM BCBFJGOGHHI(EAJCNPHALOG MLPNHMKMDIC)
	{
		return default(LHMKGBONOKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6635340", Offset = "0x6633D40", VA = "0x186635340")]
	internal static EAJCNPHALOG BDPCKEAPBBH(LHMKGBONOKM KGMCPLOKJFI)
	{
		return default(EAJCNPHALOG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PGNOMIBHBKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BOICFLAPOOM CBHHMMODGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<OGHGBFEMKAA> NHHCIMIHMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HCBGGPHNENE DEHDMMNIJBJ;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<OGHGBFEMKAA> OGJILCKADPM(bool NMNAHLBMBHO = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OGHGBFEMKAA KPJLJEDJJIA(ALIAPFOBNEL GPBJMOIHKHJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CLCKJGGNOPG(ALIAPFOBNEL GPBJMOIHKHJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<OGHGBFEMKAA> JBPFIGICOMA(ALIAPFOBNEL GPBJMOIHKHJ, bool DBACCAINPBE = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ABPHPJJDMFC(ALIAPFOBNEL CJILAADBMKN, EAJCNPHALOG ONHMAOJLIAF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OGHGBFEMKAA GDNKDJAPJIF(EAJCNPHALOG ONHMAOJLIAF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KGBJKDHADPE<T>(EAJCNPHALOG ONHMAOJLIAF, EPMDEKONPEM OBHHHMCGCJO, bool BJDGKDLPHLB, T GKNEMODKAOC) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FNEJFHNLAOF
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MKABGJHIEAN(IIJFOAGLFOC JIPHHKDPFBO, CancellationToken EAPNOLMLMHM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AELMEFLPLLD(IIJFOAGLFOC JIPHHKDPFBO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DDBCMDGIPAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	ALIAPFOBNEL ODCOGFDDMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MJFKPIOCNNN DKCFCPINLDK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NIAMCICJLAO PGAKOGBMCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KCMDIBDNBCP> IFKNBHNMFPM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CMNOKCFPDBN;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EAJCNPHALOG BNLKEBMAPCB(ALIAPFOBNEL GPBJMOIHKHJ);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KCMDIBDNBCP> DKKPBKJHJDF(CancellationToken EAPNOLMLMHM);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task ADMJBFJCBLD(long FKNNHALPBIJ, long FBGPCHAEJLL, IReadOnlyList<BDLMPKFIDFB> EPLOCDOFKGI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<ALIAPFOBNEL> EBEBKABBGKC();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GLEPPHKPABN
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6633770", Offset = "0x6632170", VA = "0x186633770")]
	public static EAJCNPHALOG PPLMMIENHAG(this DDBCMDGIPAC NIHJHDGCNFC)
	{
		return default(EAJCNPHALOG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JHEBLIONNCG<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string ONNGLBIINAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MHMLNJKGPJH<TPermission> DHHGIDMDLPB;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class FMBKGFAMCMG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? DJHIKKJKGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	protected FMBKGFAMCMG(object? MHOHFCIICEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool BKHNKAIGJPM(object? BEEGCHJLJFC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class JDEHHBEOJEP<T> : FMBKGFAMCMG where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T OBCLHNKPGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> JOIKBJDLPPP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T BMLGNHJJEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8113D0", Offset = "0x80FDD0", VA = "0x1808113D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x39F49E0", Offset = "0x39F33E0", VA = "0x1839F49E0", Slot = "4")]
	public override bool BKHNKAIGJPM(object? BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x39F4E10", Offset = "0x39F3810", VA = "0x1839F4E10")]
	public bool LODLNODGPFB(T BMMJAMMBGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x39F5040", Offset = "0x39F3A40", VA = "0x1839F5040")]
	public JDEHHBEOJEP(T DMIGONFFMAF, IEqualityComparer<T> JOIKBJDLPPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OBBBHBFLHFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<EPMDEKONPEM, bool> GGAAFGKBDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<EPMDEKONPEM, FMBKGFAMCMG> HJGCEPPCFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HPLEEBCAPFI ICFMKEMLLNK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6636090", Offset = "0x6634A90", VA = "0x186636090")]
	public OBBBHBFLHFJ(HPLEEBCAPFI ICFMKEMLLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6635D50", Offset = "0x6634750", VA = "0x186635D50")]
	public bool KDJHIPGLNNJ(EPMDEKONPEM OBHHHMCGCJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x276B180", Offset = "0x2769B80", VA = "0x18276B180")]
	public bool IFEDOPKOCAN<T>(EPMDEKONPEM OBHHHMCGCJO, bool BJDGKDLPHLB, T BEEGCHJLJFC) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x276ADB0", Offset = "0x27697B0", VA = "0x18276ADB0")]
	public (bool, T?) GJGMLIBLIAK<T>(EPMDEKONPEM OBHHHMCGCJO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6635C70", Offset = "0x6634670", VA = "0x186635C70")]
	public bool IFEDOPKOCAN(EPMDEKONPEM OBHHHMCGCJO, bool BJDGKDLPHLB, object BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6635BA0", Offset = "0x66345A0", VA = "0x186635BA0")]
	public (bool, object) GJGMLIBLIAK(EPMDEKONPEM OBHHHMCGCJO)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x276B690", Offset = "0x276A090", VA = "0x18276B690")]
	private void MEPAJHAFFMH<T>(EPMDEKONPEM OBHHHMCGCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6635FC0", Offset = "0x66349C0", VA = "0x186635FC0")]
	private FMBKGFAMCMG MPKCLAKPHIK(EPMDEKONPEM OBHHHMCGCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6635DC0", Offset = "0x66347C0", VA = "0x186635DC0")]
	public void KKLPCMCNGHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class HBDJJFHGAFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string NBMOENGHIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type PLPCLMGPOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly ODKHCHECHBO DNBOMLCDDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly EPMDEKONPEM CCGPGICMGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public PEHAMDNIFGL NBDJLLCIOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public KABGKHFMPBA OABBOGLHAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public BAFHALMHGKA PJLNAGLDGGP;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x66338D0", Offset = "0x66322D0", VA = "0x1866338D0")]
	public HBDJJFHGAFP(Type BMNBBHHIGMG, string PNCFHDMHAHL, EPMDEKONPEM OBHHHMCGCJO, PEHAMDNIFGL JMNFDDPDIKF, KABGKHFMPBA GHGJLOPGAJN, BAFHALMHGKA HBIDIFJLFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x66337D0", Offset = "0x66321D0", VA = "0x1866337D0")]
	public object CIPCOOGIIJL(object? CGDFJMJIABO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2613D50", Offset = "0x2612750", VA = "0x182613D50")]
	public void MEPAJHAFFMH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6633820", Offset = "0x6632220", VA = "0x186633820")]
	public void MEPAJHAFFMH(Type PFGFOCCIBEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CPLHDINDIJA<T> : HBDJJFHGAFP where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string DLILAJCGMEL(T BEEGCHJLJFC);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T CIPJGBPCMFO(string? OMBDOFINKFJ, T DMIGONFFMAF);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GBIDIABHMPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DLILAJCGMEL serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CIPJGBPCMFO parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public GBIDIABHMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3699AC0", Offset = "0x36984C0", VA = "0x183699AC0")]
		internal string EJBGCBEILGG(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3699AF0", Offset = "0x36984F0", VA = "0x183699AF0")]
		internal object LFCDKCNJFOG(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4D8F060", Offset = "0x4D8DA60", VA = "0x184D8F060")]
	public CPLHDINDIJA(EPMDEKONPEM OBHHHMCGCJO, string PNCFHDMHAHL, [Optional] DLILAJCGMEL? JMNFDDPDIKF, [Optional] CIPJGBPCMFO? GHGJLOPGAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4D8DD40", Offset = "0x4D8C740", VA = "0x184D8DD40")]
	private static object? DCJJDHFPDEL(CIPJGBPCMFO? GHGJLOPGAJN, string? OMBDOFINKFJ, object? DMIGONFFMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4D8E7A0", Offset = "0x4D8D1A0", VA = "0x184D8E7A0")]
	private static string JLKDILEIJOC(DLILAJCGMEL? CONFAIBAGAI, object? BEEGCHJLJFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string PEHAMDNIFGL(object? BEEGCHJLJFC);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object KABGKHFMPBA(string? OMBDOFINKFJ, [Optional] object DMIGONFFMAF);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate FMBKGFAMCMG BAFHALMHGKA();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class HPLEEBCAPFI
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class CBDOICJNBMM : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static CBDOICJNBMM KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6629290", Offset = "0x6627C90", VA = "0x186629290", Slot = "4")]
		public bool Equals(List<string> MGCANBJCGMI, List<string> MMANNCDCEPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x66293E0", Offset = "0x6627DE0", VA = "0x1866293E0", Slot = "5")]
		public int GetHashCode(List<string> GKNPKJAGNGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public CBDOICJNBMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class FOIDNFKIGHE : LMJCGKPFDCH<MOEELKEHIKL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6632B00", Offset = "0x6631500", VA = "0x186632B00", Slot = "9")]
		public override string JLKDILEIJOC(MOEELKEHIKL KIEPLBLJKOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6632920", Offset = "0x6631320", VA = "0x186632920", Slot = "10")]
		protected override bool FNJCJLGJCOA(string KIEPLBLJKOI, [Out] MOEELKEHIKL BEEGCHJLJFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6632BF0", Offset = "0x66315F0", VA = "0x186632BF0")]
		public FOIDNFKIGHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly HKDBLPPDNNB OCONFMILCLL;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly FOIDNFKIGHE PMNJGDBLDJA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<HBDJJFHGAFP> IBPKMGAGGGM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<EPMDEKONPEM> ANLPIHEFJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<EPMDEKONPEM, HBDJJFHGAFP> GIJICPDGLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6634EA0", Offset = "0x66338A0", VA = "0x186634EA0")]
	public HPLEEBCAPFI([Optional] IList<HBDJJFHGAFP>? CBBBDGNLPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6634030", Offset = "0x6632A30", VA = "0x186634030")]
	public HBDJJFHGAFP OOGCEDIMLHJ(EPMDEKONPEM OBHHHMCGCJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BOICFLAPOOM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	OGHGBFEMKAA OMCENBKNHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class FOKKPCLPMBD : BOICFLAPOOM
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static FOKKPCLPMBD PKMKBJCMDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly CBPACKEHBAL LOIFADACBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<CBPACKEHBAL> EOEJIKEJIKE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public OGHGBFEMKAA OMCENBKNHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6633660", Offset = "0x6632060", VA = "0x186633660")]
	public FOKKPCLPMBD(CBPACKEHBAL HDDEJLBDDPC, IReadOnlyList<CBPACKEHBAL> KKMIAGAEICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6632C30", Offset = "0x6631630", VA = "0x186632C30")]
	private static FOKKPCLPMBD LCDEANFHIHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CLKDMMLCKDO
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<EAJCNPHALOG> HMDENLCKGCI;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x662C090", Offset = "0x662AA90", VA = "0x18662C090")]
	public static bool FDGJKNCIOOG(this ALIAPFOBNEL EMBKGHEJPFB, EAJCNPHALOG ONHMAOJLIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x662C010", Offset = "0x662AA10", VA = "0x18662C010")]
	public static bool EIPCLLJAMKI(this ALIAPFOBNEL EMBKGHEJPFB, EAJCNPHALOG ONHMAOJLIAF, NIAMCICJLAO FNLJMOHGLMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OFLFEKNHJDB
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool BBCLBEDDKEB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool EGLBCECMHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool FJNHHGGEMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool JHONGDMFGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool ABEABBDAMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NAOHFCKDFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool DFEIMGPMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LAMBOLNODPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MPDJHKEAJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DEDIILEOEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool CNABMLDLHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LIEJPFHEFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> MBPGLGADJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	MOEELKEHIKL LMOGKABOCAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OGHGBFEMKAA : OFLFEKNHJDB, GMJCOEBMNMP, JHEBLIONNCG<EPMDEKONPEM>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string IPAFIADGDHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	EAJCNPHALOG CIHCBKBJLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) KLLLMLOMPPG<T>(EPMDEKONPEM OBHHHMCGCJO) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum EPMDEKONPEM
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
internal class CBPACKEHBAL : OGHGBFEMKAA, OFLFEKNHJDB, GMJCOEBMNMP, JHEBLIONNCG<EPMDEKONPEM>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly HPLEEBCAPFI DIAFJPAAPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly OBBBHBFLHFJ COFPIKOHIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? DCPNBIILEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? ADHDLDFNEKK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool MICCOACILON
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x662A160", Offset = "0x6628B60", VA = "0x18662A160", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool BFPDHFEIGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x66296D0", Offset = "0x66280D0", VA = "0x1866296D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool GJMBLMAKFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6629920", Offset = "0x6628320", VA = "0x186629920", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool GADJNJOABDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x662A070", Offset = "0x6628A70", VA = "0x18662A070", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool DJDHCCLEHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6629DC0", Offset = "0x66287C0", VA = "0x186629DC0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool NAAPPIAGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x662A300", Offset = "0x6628D00", VA = "0x18662A300", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EAJCNPHALOG CIHCBKBJLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8113D0", Offset = "0x80FDD0", VA = "0x1808113D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(EAJCNPHALOG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x792750", Offset = "0x791150", VA = "0x180792750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string ONNGLBIINAI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x662AF80", Offset = "0x6629980", VA = "0x18662AF80", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x662AF30", Offset = "0x6629930", VA = "0x18662AF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string IPAFIADGDHG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x662AF80", Offset = "0x6629980", VA = "0x18662AF80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool EBMJEFCEBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x814F20", Offset = "0x813920", VA = "0x180814F20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x814920", Offset = "0x813320", VA = "0x180814920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool BBCLBEDDKEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x662A350", Offset = "0x6628D50", VA = "0x18662A350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MOEELKEHIKL LMOGKABOCAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x662A260", Offset = "0x6628C60", VA = "0x18662A260", Slot = "20")]
		get
		{
			return default(MOEELKEHIKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EGLBCECMHCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x662AE90", Offset = "0x6629890", VA = "0x18662AE90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FJNHHGGEMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6629EA0", Offset = "0x66288A0", VA = "0x186629EA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JHONGDMFGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x662B440", Offset = "0x6629E40", VA = "0x18662B440", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ABEABBDAMND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6629970", Offset = "0x6628370", VA = "0x186629970", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool NAOHFCKDFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6629EF0", Offset = "0x66288F0", VA = "0x186629EF0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool DFEIMGPMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x662AD20", Offset = "0x6629720", VA = "0x18662AD20", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool LAMBOLNODPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x66295D0", Offset = "0x6627FD0", VA = "0x1866295D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool MPDJHKEAJPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x662A110", Offset = "0x6628B10", VA = "0x18662A110", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> MBPGLGADJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x662B490", Offset = "0x6629E90", VA = "0x18662B490", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool KIJGKKHALKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x662A160", Offset = "0x6628B60", VA = "0x18662A160", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool GNHJPDJFDHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6629DC0", Offset = "0x66287C0", VA = "0x186629DC0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool PJBDINJCBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x66296D0", Offset = "0x66280D0", VA = "0x1866296D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DEDIILEOEIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x662A2B0", Offset = "0x6628CB0", VA = "0x18662A2B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CNABMLDLHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x662A020", Offset = "0x6628A20", VA = "0x18662A020", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool DHJOMHBHFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6629920", Offset = "0x6628320", VA = "0x186629920", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool LIEJPFHEFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x662AEE0", Offset = "0x66298E0", VA = "0x18662AEE0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LGMDGAPAIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x662A070", Offset = "0x6628A70", VA = "0x18662A070", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DKEPANAEGOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x662A300", Offset = "0x6628D00", VA = "0x18662A300", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MHMLNJKGPJH<EPMDEKONPEM> DHHGIDMDLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6629620", Offset = "0x6628020", VA = "0x186629620", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x662A1B0", Offset = "0x6628BB0", VA = "0x18662A1B0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x242D700", Offset = "0x242C100", VA = "0x18242D700", Slot = "6")]
	public (bool, T?) KLLLMLOMPPG<T>(EPMDEKONPEM OBHHHMCGCJO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x242D6C0", Offset = "0x242C0C0", VA = "0x18242D6C0")]
	public CBPACKEHBAL BDBEHKEEOCN<T>(EPMDEKONPEM OBHHHMCGCJO, bool BJDGKDLPHLB, T BEEGCHJLJFC) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x662B630", Offset = "0x662A030", VA = "0x18662B630")]
	public CBPACKEHBAL(EAJCNPHALOG ONHMAOJLIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x662B580", Offset = "0x6629F80", VA = "0x18662B580")]
	public CBPACKEHBAL(EAJCNPHALOG ONHMAOJLIAF, [Optional] string? DCPNBIILEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x662B5A0", Offset = "0x6629FA0", VA = "0x18662B5A0")]
	public CBPACKEHBAL(CBPACKEHBAL KBJODPAJEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x662B650", Offset = "0x662A050", VA = "0x18662B650")]
	internal CBPACKEHBAL(EAJCNPHALOG LOOCFHPNGKJ, [Optional] string? DCPNBIILEDJ, [Optional] CBPACKEHBAL? KBJODPAJEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x66299C0", Offset = "0x66283C0", VA = "0x1866299C0")]
	public static ODKHCHECHBO BGOMFLLHLMD(EPMDEKONPEM OBHHHMCGCJO)
	{
		return default(ODKHCHECHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x662AD70", Offset = "0x6629770", VA = "0x18662AD70")]
	public void KKLPCMCNGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6629A40", Offset = "0x6628440", VA = "0x186629A40")]
	internal CBPACKEHBAL CAFGCPONOAH(CBPACKEHBAL ILGHFDEENLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x662AFD0", Offset = "0x66299D0", VA = "0x18662AFD0")]
	internal IReadOnlyCollection<EPMDEKONPEM> ODNFJNAJBLF(CBPACKEHBAL KBJODPAJEON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6629F40", Offset = "0x6628940", VA = "0x186629F40")]
	public bool EDOCBJEFMGH(EPMDEKONPEM OBHHHMCGCJO, bool BJDGKDLPHLB, string IPAFDJOECHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x662AD90", Offset = "0x6629790", VA = "0x18662AD90")]
	public (bool, string) LCHHLCMFDPE(EPMDEKONPEM OBHHHMCGCJO)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x662A0C0", Offset = "0x6628AC0", VA = "0x18662A0C0")]
	internal void ENFICNGBKAA(EPMDEKONPEM OBHHHMCGCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6629720", Offset = "0x6628120", VA = "0x186629720")]
	public EBOANAMDCHB AONGCFEAEKI(Func<EAJCNPHALOG, Guid> OECFMJODBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x662A3A0", Offset = "0x6628DA0", VA = "0x18662A3A0")]
	public void KBPMIINGEPB(EBOANAMDCHB KLOEIDELJKA, Func<Guid, EAJCNPHALOG> NGCLHGJKIFO, [Optional] EAJCNPHALOG? CMMOHGGINGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6629E10", Offset = "0x6628810", VA = "0x186629E10")]
	[CompilerGenerated]
	private void DLKIMBGNCKJ(EPMDEKONPEM LIMHMCDHOOJ, KABOJFLALGL IAJIGOJJLJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FAJLOBDHAKP : FNEJFHNLAOF, PGNOMIBHBKF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class BEHJJLPOOAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CBPACKEHBAL newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public BEHJJLPOOAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x66291D0", Offset = "0x6627BD0", VA = "0x1866291D0")]
		internal bool OIOMEOMGNII(CBPACKEHBAL rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class AFFGNDBOHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public EAJCNPHALOG roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public AFFGNDBOHHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x66291C0", Offset = "0x6627BC0", VA = "0x1866291C0")]
		internal bool BDKCOHKOAAH(EAJCNPHALOG r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct HIFIMLLEKMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public FAJLOBDHAKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IIJFOAGLFOC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<KCMDIBDNBCP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6633970", Offset = "0x6632370", VA = "0x186633970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6633FD0", Offset = "0x66329D0", VA = "0x186633FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NPDBLDGLOMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public NPDBLDGLOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6635920", Offset = "0x6634320", VA = "0x186635920")]
		internal void FFOLCMPDHCK(EBOANAMDCHB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6635A00", Offset = "0x6634400", VA = "0x186635A00")]
		internal void KPOFOCHOEJH(EBOANAMDCHB r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct APPNAIBAFJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public IIJFOAGLFOC roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BEKEPJNPION
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<EBOANAMDCHB, KABOJFLALGL> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public BEKEPJNPION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6629200", Offset = "0x6627C00", VA = "0x186629200")]
		internal void BDLAGJLILAB(EBOANAMDCHB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6629260", Offset = "0x6627C60", VA = "0x186629260")]
		internal void ODOGLABEAPD(EBOANAMDCHB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6629230", Offset = "0x6627C30", VA = "0x186629230")]
		internal void CCPGBAGPGIJ(EBOANAMDCHB r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class OMMHIJJCKAM<T> where T : notnull
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
			public OMMHIJJCKAM<T> <>4__this;

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
			private TaskAwaiter<KCMDIBDNBCP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x304B0D0", Offset = "0x3049AD0", VA = "0x18304B0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x926CC0", Offset = "0x9256C0", VA = "0x180926CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public FAJLOBDHAKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public EPMDEKONPEM rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public EAJCNPHALOG accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public ODKHCHECHBO recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public OMMHIJJCKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3FC4F40", Offset = "0x3FC3940", VA = "0x183FC4F40")]
		[AsyncStateMachine(typeof(OMMHIJJCKAM<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void IECFPLKCFMN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct GLGPFKDLOMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<BDLMPKFIDFB> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct EDDIJMJCPLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DDBCMDGIPAC rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IIJFOAGLFOC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<EAJCNPHALOG, CBPACKEHBAL> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public PBKNGMAHDIF debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x662C320", Offset = "0x662AD20", VA = "0x18662C320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x662CE30", Offset = "0x662B830", VA = "0x18662CE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DDBCMDGIPAC NIHJHDGCNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly FOKKPCLPMBD FCPKLBDAKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PBKNGMAHDIF ICBDEBAHBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, CBPACKEHBAL> NBEHPICNMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<EAJCNPHALOG, CBPACKEHBAL> FNDEHBECIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<EAJCNPHALOG, CBPACKEHBAL> IBKGKMCFBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<CBPACKEHBAL> LCDFFGOMPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool BCEGAIABJLA;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly EPMDEKONPEM[] FDLIBKGCBBE;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public BOICFLAPOOM CBHHMMODGHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<OGHGBFEMKAA> NHHCIMIHMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x662F740", Offset = "0x662E140", VA = "0x18662F740", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HCBGGPHNENE DEHDMMNIJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6632150", Offset = "0x6630B50", VA = "0x186632150", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x662FAE0", Offset = "0x662E4E0", VA = "0x18662FAE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x662FF70", Offset = "0x662E970", VA = "0x18662FF70")]
	[BBBFDPEBAMC(JFAJKKONDHJ.Room, HLEKCCEDPHP.None)]
	private static void KKNBNMHPDDL(AFDLAPABCDH BEFGBMMMDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6632660", Offset = "0x6631060", VA = "0x186632660")]
	[UnityEngine.Scripting.Preserve]
	internal FAJLOBDHAKP([KNBPONIPMPA(null)] DDBCMDGIPAC DHDDDHEAADL, [KNBPONIPMPA(null)] FOKKPCLPMBD BEFMFFGOPPN, [KNBPONIPMPA(null)] PBKNGMAHDIF ICBDEBAHBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x662F630", Offset = "0x662E030", VA = "0x18662F630", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6631030", Offset = "0x662FA30", VA = "0x186631030")]
	private void NMNICKDKCIM(IEnumerable<CBPACKEHBAL> BIJKGFNMBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x662EBD0", Offset = "0x662D5D0", VA = "0x18662EBD0", Slot = "12")]
	public bool CLCKJGGNOPG(ALIAPFOBNEL GPBJMOIHKHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x662ECA0", Offset = "0x662D6A0", VA = "0x18662ECA0")]
	private void CMNOKCFPDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x662F440", Offset = "0x662DE40", VA = "0x18662F440")]
	private void DNMMNJLPFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6631BF0", Offset = "0x66305F0", VA = "0x186631BF0", Slot = "10")]
	public IReadOnlyList<OGHGBFEMKAA> OGJILCKADPM(bool NMNAHLBMBHO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6630130", Offset = "0x662EB30", VA = "0x186630130", Slot = "11")]
	public OGHGBFEMKAA KPJLJEDJJIA(ALIAPFOBNEL GPBJMOIHKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6630C30", Offset = "0x662F630", VA = "0x186630C30")]
	private EAJCNPHALOG MDHDMDDABKG(ALIAPFOBNEL GPBJMOIHKHJ)
	{
		return default(EAJCNPHALOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x662CE90", Offset = "0x662B890", VA = "0x18662CE90", Slot = "14")]
	public bool ABPHPJJDMFC(ALIAPFOBNEL CJILAADBMKN, EAJCNPHALOG ONHMAOJLIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x662FB80", Offset = "0x662E580", VA = "0x18662FB80", Slot = "15")]
	public OGHGBFEMKAA GDNKDJAPJIF(EAJCNPHALOG ONHMAOJLIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6631C70", Offset = "0x6630670", VA = "0x186631C70")]
	private static bool OICAMPIOFEO(BNLIJMHLNIE NHHNIAABNJJ, EAJCNPHALOG ONHMAOJLIAF, [Out] EBOANAMDCHB? MCEJOIINAIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6630260", Offset = "0x662EC60", VA = "0x186630260")]
	private static void LEGJECHEGNB(BNLIJMHLNIE NHHNIAABNJJ, Action<EBOANAMDCHB> NGAKIEFEGCN, EAJCNPHALOG FDMLBFAAAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6630350", Offset = "0x662ED50", VA = "0x186630350")]
	private static void LEGJECHEGNB(BNLIJMHLNIE NHHNIAABNJJ, Action<EBOANAMDCHB> NGAKIEFEGCN, Predicate<EAJCNPHALOG> KFFEPOOPIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x66320E0", Offset = "0x6630AE0", VA = "0x1866320E0")]
	private void OLOIPNJJAGL(ALIAPFOBNEL GPBJMOIHKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6630F10", Offset = "0x662F910", VA = "0x186630F10", Slot = "4")]
	[AsyncStateMachine(typeof(HIFIMLLEKMJ))]
	public Task MKABGJHIEAN([CanBeNull] IIJFOAGLFOC JIPHHKDPFBO, CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
	public void AELMEFLPLLD(IIJFOAGLFOC JIPHHKDPFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x66318B0", Offset = "0x66302B0", VA = "0x1866318B0")]
	private void OAPGHPKIMPN(BNLIJMHLNIE LCPMEDFLLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x66305E0", Offset = "0x662EFE0", VA = "0x1866305E0")]
	internal static string LHPPFDLMJDL(DDBCMDGIPAC NIHJHDGCNFC, IIJFOAGLFOC JIPHHKDPFBO, IReadOnlyDictionary<EAJCNPHALOG, CBPACKEHBAL> FNDEHBECIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x662DA50", Offset = "0x662C450", VA = "0x18662DA50")]
	private static void BEFLPBAKFJG(IIJFOAGLFOC JIPHHKDPFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x66308E0", Offset = "0x662F2E0", VA = "0x1866308E0")]
	private static void LNBEDOFKEDO(BNLIJMHLNIE BKNECHKFPEK, IReadOnlyDictionary<EAJCNPHALOG, CBPACKEHBAL> FNDEHBECIBC, StringBuilder HGEDECPEDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x662FC20", Offset = "0x662E620", VA = "0x18662FC20")]
	private static bool HDJACNGMGFH(string JELDAADHOEM, [Out] Guid DJPHMIKCPGE, [Out] EAJCNPHALOG ONHMAOJLIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x662D020", Offset = "0x662BA20", VA = "0x18662D020")]
	private static void ACHKBIKHCIG(IIJFOAGLFOC JIPHHKDPFBO, StringBuilder HGEDECPEDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x25DC090", Offset = "0x25DAA90", VA = "0x1825DC090", Slot = "16")]
	public bool KGBJKDHADPE<T>(EAJCNPHALOG ONHMAOJLIAF, EPMDEKONPEM OBHHHMCGCJO, bool BJDGKDLPHLB, T GKNEMODKAOC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6630D00", Offset = "0x662F700", VA = "0x186630D00")]
	private void MENHLBJKFNO(EAJCNPHALOG ONHMAOJLIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6630240", Offset = "0x662EC40", VA = "0x186630240")]
	private bool LCOPMBOLNCA(ALIAPFOBNEL GPBJMOIHKHJ, EAJCNPHALOG ONHMAOJLIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x662F790", Offset = "0x662E190", VA = "0x18662F790")]
	internal CBPACKEHBAL FCDMOFIIKBE(ALIAPFOBNEL GPBJMOIHKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x662FF60", Offset = "0x662E960", VA = "0x18662FF60", Slot = "13")]
	public IReadOnlyList<OGHGBFEMKAA> JBPFIGICOMA(ALIAPFOBNEL GPBJMOIHKHJ, bool DBACCAINPBE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x662FD30", Offset = "0x662E730", VA = "0x18662FD30")]
	internal IReadOnlyList<CBPACKEHBAL> JAAKKCACEDI(ALIAPFOBNEL GPBJMOIHKHJ, bool DBACCAINPBE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x662ECB0", Offset = "0x662D6B0", VA = "0x18662ECB0")]
	private void DFAOGIIBBJH(KCMDIBDNBCP NCDOAFPFHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x662D760", Offset = "0x662C160", VA = "0x18662D760")]
	private static bool AHGIGCLINHF(CBPACKEHBAL FENJJKAOHEM, IReadOnlyDictionary<EAJCNPHALOG, CBPACKEHBAL> FNDEHBECIBC, [Out] IReadOnlyList<EPMDEKONPEM> GGAIIGLGDEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6631FA0", Offset = "0x66309A0", VA = "0x186631FA0")]
	[AsyncStateMachine(typeof(EDDIJMJCPLA))]
	private static Task OLEAHKKNLHN(DDBCMDGIPAC NIHJHDGCNFC, IIJFOAGLFOC JIPHHKDPFBO, IReadOnlyDictionary<EAJCNPHALOG, CBPACKEHBAL> FNDEHBECIBC, PBKNGMAHDIF ICBDEBAHBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x66321F0", Offset = "0x6630BF0", VA = "0x1866321F0")]
	[CompilerGenerated]
	internal static void PIOGPDIJOOO(Func<EBOANAMDCHB, KABOJFLALGL> GIIEOKILECE, APPNAIBAFJE P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x662E860", Offset = "0x662D260", VA = "0x18662E860")]
	[CompilerGenerated]
	internal static bool CFLCPPPBEEK(EAJCNPHALOG ONHMAOJLIAF, EPMDEKONPEM OBHHHMCGCJO, [Out] BDLMPKFIDFB DAGBEIPFEOK, GLGPFKDLOMI P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface ODPHOPKLIOA
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEKGBPOPDAF(ALIAPFOBNEL NOJEIILBLHL, ALIAPFOBNEL MOFFBLJNEAK, IEnumerable<ALIAPFOBNEL> GOIGIGHNNMP, [Out] MOEELKEHIKL BGLBBFOBDJI, [Out] GDFMECKGMFB CEFJPHJNHLJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CJMMGFKDGFM(GDFMECKGMFB GAADIJELDAC);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum GDFMECKGMFB : byte
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
internal class CEDNLAIHDLB : ODPHOPKLIOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly PGNOMIBHBKF HEEIMMKEJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OPPDFNJAPMK PCLONKAONME;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x797640", Offset = "0x796040", VA = "0x180797640")]
	[RecRoom.NoEngine.Common.Preserve]
	public CEDNLAIHDLB([KNBPONIPMPA(null)] PGNOMIBHBKF FDBMABNHJKB, [KNBPONIPMPA(null)] OPPDFNJAPMK HHOHAAOPIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x662BFD0", Offset = "0x662A9D0", VA = "0x18662BFD0")]
	private static EPMACIOCLIA? DFEANGANCCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x662B7B0", Offset = "0x662A1B0", VA = "0x18662B7B0", Slot = "4")]
	public bool AEKGBPOPDAF(ALIAPFOBNEL NOJEIILBLHL, ALIAPFOBNEL MOFFBLJNEAK, IEnumerable<ALIAPFOBNEL> GOIGIGHNNMP, [Out] MOEELKEHIKL BGLBBFOBDJI, [Out] GDFMECKGMFB CEFJPHJNHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x662BED0", Offset = "0x662A8D0", VA = "0x18662BED0", Slot = "5")]
	public string CJMMGFKDGFM(GDFMECKGMFB GAADIJELDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x662B8B0", Offset = "0x662A2B0", VA = "0x18662B8B0")]
	internal bool BNKDJGLKABM(ALIAPFOBNEL NOJEIILBLHL, ALIAPFOBNEL MOFFBLJNEAK, IEnumerable<ALIAPFOBNEL> GOIGIGHNNMP, NIAMCICJLAO FNLJMOHGLMB, EPMACIOCLIA? CHFDAFHNIME, [Out] MOEELKEHIKL BGLBBFOBDJI, [Out] GDFMECKGMFB CEFJPHJNHLJ)
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

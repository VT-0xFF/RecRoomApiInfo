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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x89A85C0", Offset = "0x89A73C0", VA = "0x1889A85C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LACCHDHLMGL
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
		[Cpp2IlInjected.Address(RVA = "0x89AB690", Offset = "0x89AA490", VA = "0x1889AB690", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void GDJBGJEANEM<TPermission>(TPermission GBENKEHPCAE);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void BGLEDEMEIPH(CDKFIILELLC IFADLDJHCLA);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PKCNAKNLOCL
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JILPCJGJCOH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NCMPMGJFDON
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool IDAJIONJEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FAKACLCHECC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PNPBHLOLMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PEGMOOCBNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HIHCCPNJDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class GNLOLHOHGCD
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum OOMKEINOHEB
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
	public static readonly Guid HPAGFGAMOCL;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid IMLPPFBBIBC;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid GFGCEGAMBMH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid MKDIGHNIOKL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid KPDJKCDBCIH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid NJFIHAOINEL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly BHFMKBLANEG<KIBEKEOAJNC, Guid> NMGODHEOHOH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<KIBEKEOAJNC> KFBHNEFAKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x89A4050", Offset = "0x89A2E50", VA = "0x1889A4050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x89A41E0", Offset = "0x89A2FE0", VA = "0x1889A41E0")]
	public static KIBEKEOAJNC FFCPCEGDMID(Guid OKDHAOKOGCM)
	{
		return default(KIBEKEOAJNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x89A4270", Offset = "0x89A3070", VA = "0x1889A4270")]
	public static Guid HMIOGMKMCPA(KIBEKEOAJNC EFPNPCKFLCA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x89A4110", Offset = "0x89A2F10", VA = "0x1889A4110")]
	public static bool CKNHBLOJLDF(KIBEKEOAJNC EFPNPCKFLCA, [Out] Guid OKDHAOKOGCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x89A4310", Offset = "0x89A3110", VA = "0x1889A4310")]
	public static bool MFLLNOJLNJB(Guid OKDHAOKOGCM, [Out] KIBEKEOAJNC EFPNPCKFLCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x89A40D0", Offset = "0x89A2ED0", VA = "0x1889A40D0")]
	public static KIBEKEOAJNC BGCPOIJBGMC(KIBEKEOAJNC EFPNPCKFLCA)
	{
		return default(KIBEKEOAJNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x89A43B0", Offset = "0x89A31B0", VA = "0x1889A43B0")]
	public static OOMKEINOHEB NMKPDMDDLHC(KIBEKEOAJNC PMOBICAELFD)
	{
		return default(OOMKEINOHEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x89A41A0", Offset = "0x89A2FA0", VA = "0x1889A41A0")]
	internal static KIBEKEOAJNC EJKOIAFODCI(OOMKEINOHEB FJFCONNNOGP)
	{
		return default(KIBEKEOAJNC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ACALDNIFCKD
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	CDKFIILELLC MJGODKHPGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	PLJJBKEIPKH FBKEHCPFNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AACPGJNOFJH OFAHOLAEKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<PEPNNBPKDIF> DPJLPIBFJFP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LFBGBIDBCBI;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KIBEKEOAJNC FPOMCCJICFL(CDKFIILELLC IFADLDJHCLA);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PEPNNBPKDIF> BOFLHMAEOHE(CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task IPJJDABEMIF(long NCGHDDJNJOM, IReadOnlyList<CFOCDBEOIAK> LLBEDKOEFDH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task AJPEPFGCEDI(long NCGHDDJNJOM, long HEPLHKILNBD, IReadOnlyList<CFOCDBEOIAK> LLBEDKOEFDH);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<CDKFIILELLC> AHPICJMDOIN();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KCLNDJGKNDD
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x89A7CD0", Offset = "0x89A6AD0", VA = "0x1889A7CD0")]
	public static KIBEKEOAJNC EDNCDPBNPCM(this ACALDNIFCKD EDGMLFJJNEM)
	{
		return default(KIBEKEOAJNC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface HKKAGIBCPIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IHLLLOLMEHF NLGOAIFOIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event BGLEDEMEIPH DBCAMCAPHIE;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<GHOKJBMENHO> CCNMCHLMBIG(bool PMBGGLJBNJN = false);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GHOKJBMENHO JBKLFLGGLFF(CDKFIILELLC IFADLDJHCLA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NJCPODEFFAD(CDKFIILELLC IFADLDJHCLA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<GHOKJBMENHO> MFFGDALHEEM(CDKFIILELLC IFADLDJHCLA, bool JALFNMMMHLA = false);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CFGIAKCLIIO(CDKFIILELLC LGJHILBEOFI, KIBEKEOAJNC EFPNPCKFLCA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GHOKJBMENHO DBGPBCIPOKD(KIBEKEOAJNC EFPNPCKFLCA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FMFLDJPGBAG<T>(KIBEKEOAJNC EFPNPCKFLCA, DCJLBCLCFAB GBENKEHPCAE, bool MLHPNLNEMAJ, T AGJNJFMNGDN, [Optional] Action EBOKGIHGIME) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string MGDJNPHENIN(DCJLBCLCFAB GBENKEHPCAE);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BCJNEFHNILA(CDKFIILELLC IFADLDJHCLA, DCJLBCLCFAB MPCCFAHBPJM);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OECBIEEPJDG
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FBDCDKEGJCJ(IMABAOJCLFC JBNEABKLADH, CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LHNOIEHBDBE<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string JFEJJDJHBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GDJBGJEANEM<TPermission> MNBEGAINNEI;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class GGMGNHEDAFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? JCKJCCDJMPI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public object? IEJGHHHHCPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89A3D60", Offset = "0x89A2B60", VA = "0x1889A3D60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x89A3E40", Offset = "0x89A2C40", VA = "0x1889A3E40")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x89A3F40", Offset = "0x89A2D40", VA = "0x1889A3F40")]
	protected GGMGNHEDAFK(object? CFDEPNOKKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PDGEMODFENH(object? BNECONOIKOE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class GPDLDMMBLCL<T> : GGMGNHEDAFK where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> JPJEBIEBIKM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T HBDLGDLEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4DD7B30", Offset = "0x4DD6930", VA = "0x184DD7B30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4DD82E0", Offset = "0x4DD70E0", VA = "0x184DD82E0", Slot = "4")]
	public override bool PDGEMODFENH(object? BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4DD7D10", Offset = "0x4DD6B10", VA = "0x184DD7D10")]
	public bool NDDHLFKHEOB(T KEKOEMKANGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4DD86B0", Offset = "0x4DD74B0", VA = "0x184DD86B0")]
	public GPDLDMMBLCL(T JILABBLHNAO, IEqualityComparer<T> JPJEBIEBIKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class MOBPDJEOGBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<DCJLBCLCFAB, bool> CGCNPGJFODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<DCJLBCLCFAB, GGMGNHEDAFK> FEBKECKCBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly JHDEMBLJOBK FFGBOBCBOIF;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x89A8310", Offset = "0x89A7110", VA = "0x1889A8310")]
	public MOBPDJEOGBD(JHDEMBLJOBK FFGBOBCBOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x89A7D60", Offset = "0x89A6B60", VA = "0x1889A7D60")]
	public bool CDFBHBMFEEG(DCJLBCLCFAB GBENKEHPCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0EF0", Offset = "0x3C9FCF0", VA = "0x183CA0EF0")]
	public bool OMJMGCJICMJ<T>(DCJLBCLCFAB GBENKEHPCAE, bool MLHPNLNEMAJ, T BNECONOIKOE) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0B20", Offset = "0x3C9F920", VA = "0x183CA0B20")]
	public (bool, T?) LECAFKGCIFI<T>(DCJLBCLCFAB GBENKEHPCAE) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x89A8230", Offset = "0x89A7030", VA = "0x1889A8230")]
	public bool OMJMGCJICMJ(DCJLBCLCFAB GBENKEHPCAE, bool MLHPNLNEMAJ, object BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x89A7DD0", Offset = "0x89A6BD0", VA = "0x1889A7DD0")]
	public (bool, object) LECAFKGCIFI(DCJLBCLCFAB GBENKEHPCAE)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0AE0", Offset = "0x3C9F8E0", VA = "0x183CA0AE0")]
	private void AEHODACAFCM<T>(DCJLBCLCFAB GBENKEHPCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x89A8160", Offset = "0x89A6F60", VA = "0x1889A8160")]
	private GGMGNHEDAFK OIOLINFGOPF(DCJLBCLCFAB GBENKEHPCAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x89A7F70", Offset = "0x89A6D70", VA = "0x1889A7F70")]
	public void LKAHAIDDBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class BDDLFLICCOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string HAPNNFMFLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type HCDBENEOCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly HAPKFNDOCNC AIKCKECLJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly DCJLBCLCFAB LKGNLPJKEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public EJAIPGLCCOD OJMMLKPCIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public JJPMHBNENAH AOFHFGFAMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public LECKDPHCGLC AMOLIHDPGIM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x899D600", Offset = "0x899C400", VA = "0x18899D600")]
	public BDDLFLICCOA(Type CDDMPFCKLIB, string JFBBNLMLCMN, DCJLBCLCFAB GBENKEHPCAE, EJAIPGLCCOD KIHICFEDBDF, JJPMHBNENAH OLNBPOCEGKD, LECKDPHCGLC EFMEFDKPNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x899D5B0", Offset = "0x899C3B0", VA = "0x18899D5B0")]
	public object PLMMHEHFCKC(object? LOKLFHKEJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3933060", Offset = "0x3931E60", VA = "0x183933060")]
	public void AEHODACAFCM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x899D500", Offset = "0x899C300", VA = "0x18899D500")]
	public void AEHODACAFCM(Type JFDOICANDCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class FNKLEDBKFKI<T> : BDDLFLICCOA where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string IPMDABECMAH(T BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T HDIPFCIFKBD(string? FPGBLHCFMGE, T JILABBLHNAO);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GEFBCDLOPPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IPMDABECMAH serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HDIPFCIFKBD parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GEFBCDLOPPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4D7DD50", Offset = "0x4D7CB50", VA = "0x184D7DD50")]
		internal string CABKDCOCKPB(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4D7DE90", Offset = "0x4D7CC90", VA = "0x184D7DE90")]
		internal object HGLEAMJBNCO(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4CD5730", Offset = "0x4CD4530", VA = "0x184CD5730")]
	public FNKLEDBKFKI(DCJLBCLCFAB GBENKEHPCAE, string JFBBNLMLCMN, [Optional] IPMDABECMAH? KIHICFEDBDF, [Optional] HDIPFCIFKBD? OLNBPOCEGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4CD4320", Offset = "0x4CD3120", VA = "0x184CD4320")]
	private static object? KIDJPDKJMHF(HDIPFCIFKBD? OLNBPOCEGKD, string? FPGBLHCFMGE, object? JILABBLHNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4CD4C10", Offset = "0x4CD3A10", VA = "0x184CD4C10")]
	private static string NEJFHFKCOKJ(IPMDABECMAH? PLJAJAFBPLD, object? BNECONOIKOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string EJAIPGLCCOD(object? BNECONOIKOE);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object JJPMHBNENAH(string? FPGBLHCFMGE, [Optional] object JILABBLHNAO);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate GGMGNHEDAFK LECKDPHCGLC();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class JHDEMBLJOBK
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class PALNACDPBMB : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static PALNACDPBMB ODAOEPEFKDK;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x89A9890", Offset = "0x89A8690", VA = "0x1889A9890", Slot = "4")]
		public bool Equals(List<string> DHOMBGCEEAK, List<string> EDBCCDDDLPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x89A99E0", Offset = "0x89A87E0", VA = "0x1889A99E0", Slot = "5")]
		public int GetHashCode(List<string> MKPNGAKJFMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PALNACDPBMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class PGOHKCMNHJK : KKBKGFKIBLB<LACCHDHLMGL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x89A9BD0", Offset = "0x89A89D0", VA = "0x1889A9BD0", Slot = "9")]
		public override string NEJFHFKCOKJ(LACCHDHLMGL PADDIEKMDDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x89A9CC0", Offset = "0x89A8AC0", VA = "0x1889A9CC0", Slot = "10")]
		protected override bool PCCJOMNBKIL(string PADDIEKMDDH, [Out] LACCHDHLMGL BNECONOIKOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x89A9E90", Offset = "0x89A8C90", VA = "0x1889A9E90")]
		public PGOHKCMNHJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly PPCIAMACLAP IHEBADHBCFP;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly PGOHKCMNHJK PINKMILNENF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<BDDLFLICCOA> FJIGJEIFPIC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<DCJLBCLCFAB> COGLDPPDIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<DCJLBCLCFAB, BDDLFLICCOA> NPBLKHMNCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x89A7980", Offset = "0x89A6780", VA = "0x1889A7980")]
	public JHDEMBLJOBK([Optional] IList<BDDLFLICCOA>? NLIFCBOMJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x89A63E0", Offset = "0x89A51E0", VA = "0x1889A63E0")]
	public BDDLFLICCOA FCKKMPJNMPP(DCJLBCLCFAB GBENKEHPCAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IHLLLOLMEHF
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	GHOKJBMENHO EDMNJHBOAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class PIGMNHDAOCC : IHLLLOLMEHF
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static PIGMNHDAOCC OCFBFLLNPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly JAIOLBAJOLO IBGMLAOIABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<JAIOLBAJOLO> CEAFKCKEJNE;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GHOKJBMENHO EDMNJHBOAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x89AADF0", Offset = "0x89A9BF0", VA = "0x1889AADF0")]
	public PIGMNHDAOCC(JAIOLBAJOLO ICAJDEAHNFE, IReadOnlyList<JAIOLBAJOLO> LNHCILDJJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x89A9ED0", Offset = "0x89A8CD0", VA = "0x1889A9ED0")]
	private static PIGMNHDAOCC HJPBKANHLHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class AAPIKFHPGGC
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<KIBEKEOAJNC> CEGOKPKGFPO;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x899D160", Offset = "0x899BF60", VA = "0x18899D160")]
	public static bool EGFDIEAEHHL(this CDKFIILELLC BFIOOMKAEHA, KIBEKEOAJNC EFPNPCKFLCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x899D240", Offset = "0x899C040", VA = "0x18899D240")]
	public static bool EOGANNELCMD(this CDKFIILELLC BFIOOMKAEHA, KIBEKEOAJNC EFPNPCKFLCA, AACPGJNOFJH HDJLJGEPGEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface AFIFAAGOGPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IReadOnlyList<string> NHOPEFJFJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LACCHDHLMGL APMLMMGOMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GHOKJBMENHO : AFIFAAGOGPJ, JILPCJGJCOH, LHNOIEHBDBE<DCJLBCLCFAB>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string MCGIGKOLLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KIBEKEOAJNC DDDPEFEFHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) ALDCMALABCL<T>(DCJLBCLCFAB GBENKEHPCAE) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class JAIOLBAJOLO : GHOKJBMENHO, AFIFAAGOGPJ, JILPCJGJCOH, LHNOIEHBDBE<DCJLBCLCFAB>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly JHDEMBLJOBK KOPACGAFMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly MOBPDJEOGBD EMHCBEHMJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? IANIJJEIJNF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool JCAKCMBGNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x89A47D0", Offset = "0x89A35D0", VA = "0x1889A47D0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool MIOAOOECENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x89A5C20", Offset = "0x89A4A20", VA = "0x1889A5C20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool BDKAJFCIEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89A60F0", Offset = "0x89A4EF0", VA = "0x1889A60F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool ADMIHBIFFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x89A4B00", Offset = "0x89A3900", VA = "0x1889A4B00", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool CGNEHBGBCKH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x89A4780", Offset = "0x89A3580", VA = "0x1889A4780", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool FLIDAIMGNNL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89A4AB0", Offset = "0x89A38B0", VA = "0x1889A4AB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public KIBEKEOAJNC DDDPEFEFHAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAAA5A0", Offset = "0xAA93A0", VA = "0x180AAA5A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(KIBEKEOAJNC);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE90", Offset = "0xA59C90", VA = "0x180A5AE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string JFEJJDJHBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89A5B80", Offset = "0x89A4980", VA = "0x1889A5B80", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string MCGIGKOLLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x89A5B80", Offset = "0x89A4980", VA = "0x1889A5B80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HBPJKNBBFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA86430", Offset = "0xA85230", VA = "0x180A86430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA861B0", Offset = "0xA84FB0", VA = "0x180A861B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public LACCHDHLMGL APMLMMGOMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x89A5840", Offset = "0x89A4640", VA = "0x1889A5840", Slot = "8")]
		get
		{
			return default(LACCHDHLMGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyList<string> NHOPEFJFJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x89A4E80", Offset = "0x89A3C80", VA = "0x1889A4E80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool OCBALGBLDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x89A47D0", Offset = "0x89A35D0", VA = "0x1889A47D0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool DHNBNFOAGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x89A4780", Offset = "0x89A3580", VA = "0x1889A4780", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool IKIAGOFCCFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x89A5C20", Offset = "0x89A4A20", VA = "0x1889A5C20", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool HCNNPDFMKID
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x89A60F0", Offset = "0x89A4EF0", VA = "0x1889A60F0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PIFBKLBKAMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x89A4B00", Offset = "0x89A3900", VA = "0x1889A4B00", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ANIJCGHINJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x89A4AB0", Offset = "0x89A38B0", VA = "0x1889A4AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event GDJBGJEANEM<DCJLBCLCFAB> MNBEGAINNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x89A4A00", Offset = "0x89A3800", VA = "0x1889A4A00", Slot = "15")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89A4B50", Offset = "0x89A3950", VA = "0x1889A4B50", Slot = "16")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3BE56E0", Offset = "0x3BE44E0", VA = "0x183BE56E0", Slot = "6")]
	public (bool, T?) ALDCMALABCL<T>(DCJLBCLCFAB GBENKEHPCAE) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5870", Offset = "0x3BE4670", VA = "0x183BE5870")]
	public JAIOLBAJOLO APHCODPCGCK<T>(DCJLBCLCFAB GBENKEHPCAE, bool MLHPNLNEMAJ, T BNECONOIKOE) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x89A63C0", Offset = "0x89A51C0", VA = "0x1889A63C0")]
	public JAIOLBAJOLO(KIBEKEOAJNC EFPNPCKFLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x89A6260", Offset = "0x89A5060", VA = "0x1889A6260")]
	public JAIOLBAJOLO(KIBEKEOAJNC EFPNPCKFLCA, [Optional] string? IANIJJEIJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x89A61D0", Offset = "0x89A4FD0", VA = "0x1889A61D0")]
	public JAIOLBAJOLO(JAIOLBAJOLO OFLOOAHEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x89A6280", Offset = "0x89A5080", VA = "0x1889A6280")]
	internal JAIOLBAJOLO(KIBEKEOAJNC HHCDBILHJJP, [Optional] string? IANIJJEIJNF, [Optional] JAIOLBAJOLO? OFLOOAHEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x89A4E00", Offset = "0x89A3C00", VA = "0x1889A4E00")]
	public static HAPKFNDOCNC EHKFLPMMADE(DCJLBCLCFAB GBENKEHPCAE)
	{
		return default(HAPKFNDOCNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x89A5C70", Offset = "0x89A4A70", VA = "0x1889A5C70")]
	public void LKAHAIDDBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x89A5890", Offset = "0x89A4690", VA = "0x1889A5890")]
	internal JAIOLBAJOLO JIKKJBKEALF(JAIOLBAJOLO JNPLKDBONMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x89A5C90", Offset = "0x89A4A90", VA = "0x1889A5C90")]
	internal IReadOnlyCollection<DCJLBCLCFAB> LKMBLBJMLGG(JAIOLBAJOLO OFLOOAHEGHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x89A4820", Offset = "0x89A3620", VA = "0x1889A4820")]
	public bool ACEDCFGCIHP(DCJLBCLCFAB GBENKEHPCAE, bool MLHPNLNEMAJ, string ELMGACMEGNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x89A4900", Offset = "0x89A3700", VA = "0x1889A4900")]
	public (bool, string) APFKILDCBCL(DCJLBCLCFAB GBENKEHPCAE)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x89A5BD0", Offset = "0x89A49D0", VA = "0x1889A5BD0")]
	internal void KIIGKNILFAG(DCJLBCLCFAB GBENKEHPCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x89A4C00", Offset = "0x89A3A00", VA = "0x1889A4C00")]
	public ADBDHEHAPCC ECFHPHNFILM(Func<KIBEKEOAJNC, Guid> DLLFHKCGMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x89A4EE0", Offset = "0x89A3CE0", VA = "0x1889A4EE0")]
	public void HGFKONKPFDO(ADBDHEHAPCC CCMIGFLJKPN, Func<Guid, KIBEKEOAJNC> ODJOOMJPAOI, [Optional] KIBEKEOAJNC? GEKPJMOLKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x89A6060", Offset = "0x89A4E60", VA = "0x1889A6060")]
	[CompilerGenerated]
	private void MBNFBHFILDE(DCJLBCLCFAB MPCCFAHBPJM, JJEBHLKCNLO JEFHCOPJANM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CMEGMHCBKEH : OECBIEEPJDG, HKKAGIBCPIH, IDisposable, HJFMGPKIICN
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KFFOLDCPKOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public JAIOLBAJOLO newRole;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KFFOLDCPKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x89A7D30", Offset = "0x89A6B30", VA = "0x1889A7D30")]
		internal bool DAHNDOEDNHC(JAIOLBAJOLO rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CBAAPFHEEIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KIBEKEOAJNC roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public CBAAPFHEEIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E339F0", Offset = "0x1E327F0", VA = "0x181E339F0")]
		internal bool HIJOMKLHMMG(KIBEKEOAJNC r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct ONCADJMBBLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CMEGMHCBKEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IMABAOJCLFC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<PEPNNBPKDIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x89A91C0", Offset = "0x89A7FC0", VA = "0x1889A91C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x89A9830", Offset = "0x89A8630", VA = "0x1889A9830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DNNIDJMKEDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DNNIDJMKEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x89A3300", Offset = "0x89A2100", VA = "0x1889A3300")]
		internal void GCFMOKNJPOB(ADBDHEHAPCC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x89A33E0", Offset = "0x89A21E0", VA = "0x1889A33E0")]
		internal void MKFMJFMOCJF(ADBDHEHAPCC r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct GKJKGHCILNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public IMABAOJCLFC roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class AMOFDLDCIII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Func<ADBDHEHAPCC, JJEBHLKCNLO> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AMOFDLDCIII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x899D470", Offset = "0x899C270", VA = "0x18899D470")]
		internal void AKAEBELIHBN(ADBDHEHAPCC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x899D4A0", Offset = "0x899C2A0", VA = "0x18899D4A0")]
		internal void CCPMGGJIPMI(ADBDHEHAPCC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x899D4D0", Offset = "0x899C2D0", VA = "0x18899D4D0")]
		internal void DFOOAGMBLHB(ADBDHEHAPCC r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IFJEEBBKDDM<T> where T : notnull
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
			public IFJEEBBKDDM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<PEPNNBPKDIF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x43896C0", Offset = "0x43884C0", VA = "0x1843896C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAAD270", Offset = "0xAAC070", VA = "0x180AAD270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public DCJLBCLCFAB rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public KIBEKEOAJNC accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public HAPKFNDOCNC recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CMEGMHCBKEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public IFJEEBBKDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4F197F0", Offset = "0x4F185F0", VA = "0x184F197F0")]
		[AsyncStateMachine(typeof(IFJEEBBKDDM<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void FBIFPNFDGGA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct KMLDLJIKOOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IReadOnlyList<CFOCDBEOIAK> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct OIPNPPCBOKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public ACALDNIFCKD rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public IMABAOJCLFC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IReadOnlyDictionary<KIBEKEOAJNC, JAIOLBAJOLO> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public NEFGBBBPMJE debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x89A8640", Offset = "0x89A7440", VA = "0x1889A8640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x89A9160", Offset = "0x89A7F60", VA = "0x1889A9160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly ACALDNIFCKD EDGMLFJJNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PIGMNHDAOCC CJPCNCBOHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly NEFGBBBPMJE LFAMJEMPOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<int, JAIOLBAJOLO> MCCFKFGIIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly Dictionary<KIBEKEOAJNC, JAIOLBAJOLO> ONAECMFHFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly Dictionary<KIBEKEOAJNC, JAIOLBAJOLO> DIMIBIMJOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly List<JAIOLBAJOLO> PABECGFGGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool GFHOOBPAIED;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly DCJLBCLCFAB[] BMBKGEOMPEG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public IHLLLOLMEHF NLGOAIFOIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event BGLEDEMEIPH DBCAMCAPHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x89A20F0", Offset = "0x89A0EF0", VA = "0x1889A20F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x89A0B50", Offset = "0x899F950", VA = "0x1889A0B50", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x89A2AD0", Offset = "0x89A18D0", VA = "0x1889A2AD0")]
	[ONLJNMLDJBD.CLIPOMEJNOE]
	internal static void NPDNKFNEHEP(LOAHJOOKLEP MHIANKFNOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x89A3040", Offset = "0x89A1E40", VA = "0x1889A3040")]
	[UnityEngine.Scripting.Preserve]
	internal CMEGMHCBKEH([OLOAAHJODHH(null)] ACALDNIFCKD MJPADMFOLBH, [OLOAAHJODHH(null)] PIGMNHDAOCC LLPIFBKHEPF, [OLOAAHJODHH(null)] NEFGBBBPMJE LFAMJEMPOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x899E8A0", Offset = "0x899D6A0", VA = "0x18899E8A0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x89A2190", Offset = "0x89A0F90", VA = "0x1889A2190")]
	private void MMEMDFAHADA(IEnumerable<JAIOLBAJOLO> BMAPAIFJGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A00", Offset = "0x89A1800", VA = "0x1889A2A00", Slot = "10")]
	public bool NJCPODEFFAD(CDKFIILELLC IFADLDJHCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x89A1D80", Offset = "0x89A0B80", VA = "0x1889A1D80")]
	private void LFBGBIDBCBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x89A2C90", Offset = "0x89A1A90", VA = "0x1889A2C90")]
	private void OGLBCKPDPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x899E610", Offset = "0x899D410", VA = "0x18899E610", Slot = "8")]
	public IReadOnlyList<GHOKJBMENHO> CCNMCHLMBIG(bool PMBGGLJBNJN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x89A0BF0", Offset = "0x899F9F0", VA = "0x1889A0BF0", Slot = "9")]
	public GHOKJBMENHO JBKLFLGGLFF(CDKFIILELLC IFADLDJHCLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x89A1D90", Offset = "0x89A0B90", VA = "0x1889A1D90")]
	private KIBEKEOAJNC LPMLDBGAMEB(CDKFIILELLC IFADLDJHCLA)
	{
		return default(KIBEKEOAJNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x899E690", Offset = "0x899D490", VA = "0x18899E690", Slot = "12")]
	public bool CFGIAKCLIIO(CDKFIILELLC LGJHILBEOFI, KIBEKEOAJNC EFPNPCKFLCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x899E800", Offset = "0x899D600", VA = "0x18899E800", Slot = "13")]
	public GHOKJBMENHO DBGPBCIPOKD(KIBEKEOAJNC EFPNPCKFLCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x899EE60", Offset = "0x899DC60", VA = "0x18899EE60")]
	private static bool FLGBMBPGPAD(FIAOBGPLMHH ODAOGJMGNPG, KIBEKEOAJNC EFPNPCKFLCA, [Out] ADBDHEHAPCC? PKCIJCPIKKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x89A0A60", Offset = "0x899F860", VA = "0x1889A0A60")]
	private static void IMBFKKHNHPC(FIAOBGPLMHH ODAOGJMGNPG, Action<ADBDHEHAPCC> LKCKPOFPCKB, KIBEKEOAJNC MEAJNFPEOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x89A07D0", Offset = "0x899F5D0", VA = "0x1889A07D0")]
	private static void IMBFKKHNHPC(FIAOBGPLMHH ODAOGJMGNPG, Action<ADBDHEHAPCC> LKCKPOFPCKB, Predicate<KIBEKEOAJNC> HLHPEMDLFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x89A0760", Offset = "0x899F560", VA = "0x1889A0760")]
	private void IJCMOHOLKGD(CDKFIILELLC IFADLDJHCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x899ED40", Offset = "0x899DB40", VA = "0x18899ED40", Slot = "4")]
	[AsyncStateMachine(typeof(ONCADJMBBLA))]
	public Task FBDCDKEGJCJ([CanBeNull] IMABAOJCLFC JBNEABKLADH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x89A00D0", Offset = "0x899EED0", VA = "0x1889A00D0")]
	private void HANHDDDODDM(FIAOBGPLMHH AHPIPFFHGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x89A17D0", Offset = "0x89A05D0", VA = "0x1889A17D0")]
	internal static string KPKNPJIKKPF(ACALDNIFCKD EDGMLFJJNEM, IMABAOJCLFC JBNEABKLADH, IReadOnlyDictionary<KIBEKEOAJNC, JAIOLBAJOLO> ONAECMFHFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x899F190", Offset = "0x899DF90", VA = "0x18899F190")]
	private static void GCMEMPKACBF(IMABAOJCLFC JBNEABKLADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x89A0410", Offset = "0x899F210", VA = "0x1889A0410")]
	private static void HIAPPICPADL(FIAOBGPLMHH LDMHPFEMHGM, IReadOnlyDictionary<KIBEKEOAJNC, JAIOLBAJOLO> ONAECMFHFEE, StringBuilder BHNOGGAHFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x899FFC0", Offset = "0x899EDC0", VA = "0x18899FFC0")]
	private static bool GGNAPPMOPEP(string LPFLPIMAAFG, [Out] Guid ONINOIJBBGN, [Out] KIBEKEOAJNC EFPNPCKFLCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x89A1080", Offset = "0x899FE80", VA = "0x1889A1080")]
	private static void JJNJCMAJKCO(IMABAOJCLFC JBNEABKLADH, StringBuilder BHNOGGAHFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x399BA10", Offset = "0x399A810", VA = "0x18399BA10", Slot = "14")]
	public bool FMFLDJPGBAG<T>(KIBEKEOAJNC EFPNPCKFLCA, DCJLBCLCFAB GBENKEHPCAE, bool MLHPNLNEMAJ, T AGJNJFMNGDN, [Optional] Action EBOKGIHGIME) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x89A2070", Offset = "0x89A0E70", VA = "0x1889A2070", Slot = "15")]
	public string MGDJNPHENIN(DCJLBCLCFAB GBENKEHPCAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x899D9E0", Offset = "0x899C7E0", VA = "0x18899D9E0", Slot = "16")]
	public bool BCJNEFHNILA(CDKFIILELLC IFADLDJHCLA, DCJLBCLCFAB MPCCFAHBPJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x899DAD0", Offset = "0x899C8D0", VA = "0x18899DAD0", Slot = "18")]
	public bool BCJNEFHNILA(int FLHCGDNOCHL, DCJLBCLCFAB MPCCFAHBPJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x89A1E60", Offset = "0x89A0C60", VA = "0x1889A1E60")]
	private void MCMGEBFDPBL(KIBEKEOAJNC EFPNPCKFLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x899EBE0", Offset = "0x899D9E0", VA = "0x18899EBE0")]
	private bool ENKFIEDLGJH(CDKFIILELLC IFADLDJHCLA, KIBEKEOAJNC EFPNPCKFLCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x899D6A0", Offset = "0x899C4A0", VA = "0x18899D6A0")]
	internal JAIOLBAJOLO AGAFNMINDJE(CDKFIILELLC IFADLDJHCLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x89A2060", Offset = "0x89A0E60", VA = "0x1889A2060", Slot = "11")]
	public IReadOnlyList<GHOKJBMENHO> MFFGDALHEEM(CDKFIILELLC IFADLDJHCLA, bool JALFNMMMHLA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x899E9B0", Offset = "0x899D7B0", VA = "0x18899E9B0")]
	internal IReadOnlyList<JAIOLBAJOLO> EENIBMHLKDF(CDKFIILELLC IFADLDJHCLA, bool JALFNMMMHLA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x899DE70", Offset = "0x899CC70", VA = "0x18899DE70")]
	private void CBOMCCGDNIO(PEPNNBPKDIF JCGLDPBNJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x899DB80", Offset = "0x899C980", VA = "0x18899DB80")]
	private static bool BMBMDIELFNG(JAIOLBAJOLO FMJKBLCMEGF, IReadOnlyDictionary<KIBEKEOAJNC, JAIOLBAJOLO> ONAECMFHFEE, [Out] IReadOnlyList<DCJLBCLCFAB> BCGKKKBKJPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x899EC00", Offset = "0x899DA00", VA = "0x18899EC00")]
	[AsyncStateMachine(typeof(OIPNPPCBOKB))]
	private static Task FACMMHFCHKJ(ACALDNIFCKD EDGMLFJJNEM, IMABAOJCLFC JBNEABKLADH, IReadOnlyDictionary<KIBEKEOAJNC, JAIOLBAJOLO> ONAECMFHFEE, NEFGBBBPMJE LFAMJEMPOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x89A1AE0", Offset = "0x89A08E0", VA = "0x1889A1AE0")]
	[CompilerGenerated]
	internal static void LELGIPAJNDH(Func<ADBDHEHAPCC, JJEBHLKCNLO> LHACKKMLBIC, GKJKGHCILNO P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x89A0D00", Offset = "0x899FB00", VA = "0x1889A0D00")]
	[CompilerGenerated]
	internal static bool JCKBAJGGOLA(KIBEKEOAJNC EFPNPCKFLCA, DCJLBCLCFAB GBENKEHPCAE, [Out] CFOCDBEOIAK OGHIGOMGKPM, KMLDLJIKOOJ P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CHNFDMJMANN
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBOGJHACNLB(CDKFIILELLC OPECIEGPPHP, CDKFIILELLC FFDOMBNDKEM, IEnumerable<CDKFIILELLC> BKHGLEAHMAH, [Out] LACCHDHLMGL BFALIOFACEH, [Out] NADJHFBMPNE LPMHHOHBBPN);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BLHOPIMFMAB(NADJHFBMPNE HOBPFLLHDLD);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum NADJHFBMPNE : byte
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
internal class EKKMKJMMPPG : CHNFDMJMANN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly HKKAGIBCPIH GPGHGIKBKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly FGEJDDNHHKH GCHHEKMCHEC;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA639A0", Offset = "0xA627A0", VA = "0x180A639A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EKKMKJMMPPG([OLOAAHJODHH(null)] HKKAGIBCPIH GPGHGIKBKOG, [OLOAAHJODHH(null)] FGEJDDNHHKH CCCFDPDMCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x89A3D20", Offset = "0x89A2B20", VA = "0x1889A3D20")]
	private static BAFAHHEIMPO? MCIMGAGAHBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x89A3C20", Offset = "0x89A2A20", VA = "0x1889A3C20", Slot = "4")]
	public bool EBOGJHACNLB(CDKFIILELLC OPECIEGPPHP, CDKFIILELLC FFDOMBNDKEM, IEnumerable<CDKFIILELLC> BKHGLEAHMAH, [Out] LACCHDHLMGL BFALIOFACEH, [Out] NADJHFBMPNE LPMHHOHBBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x89A3B20", Offset = "0x89A2920", VA = "0x1889A3B20", Slot = "5")]
	public string BLHOPIMFMAB(NADJHFBMPNE HOBPFLLHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x89A3500", Offset = "0x89A2300", VA = "0x1889A3500")]
	internal bool AMADJIALNCL(CDKFIILELLC OPECIEGPPHP, CDKFIILELLC FFDOMBNDKEM, IEnumerable<CDKFIILELLC> BKHGLEAHMAH, AACPGJNOFJH HDJLJGEPGEG, BAFAHHEIMPO? ANECCOBHAFI, [Out] LACCHDHLMGL BFALIOFACEH, [Out] NADJHFBMPNE LPMHHOHBBPN)
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

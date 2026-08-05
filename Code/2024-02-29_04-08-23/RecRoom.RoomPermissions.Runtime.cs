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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6611AB0", Offset = "0x66108B0", VA = "0x186611AB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LDDMPLJDBDN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void EIPANEHLKND<TPermission>(TPermission AGPPJHLAEDL);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void KNBLBACAGKB(MNFCKJNKANA ACNHNLBOPON);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum IHLDMGCFOOE
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DELIELAMGBH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ONEMDNEGPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NABEJOCLAMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EPLHMEALFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EDPPCBAIPFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FDOAFJBAMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JANKCDEDLLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class JNNPMGOGGCC
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum FPCJGEENPKJ
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
	public static readonly Guid PCCLFBNAHPI;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid KLJLCFJDIFD;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid DDNMEJENDNM;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid EMCFLAGGFML;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid NLPBPOIBCPA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid OBIBHNFLCHI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly CHOJBDFCFOC<FBFELBFAABF, Guid> CKFDOMHACDF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<FBFELBFAABF> LKAOHNJFDEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6610AB0", Offset = "0x660F8B0", VA = "0x186610AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6610B30", Offset = "0x660F930", VA = "0x186610B30")]
	public static FBFELBFAABF CIMLIOHFBLN(Guid FANIDECOFDM)
	{
		return default(FBFELBFAABF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6610C00", Offset = "0x660FA00", VA = "0x186610C00")]
	public static Guid IFIOJDGLKGP(FBFELBFAABF CBBDDCAOGKD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6610D40", Offset = "0x660FB40", VA = "0x186610D40")]
	public static bool JEMOBENLDNB(FBFELBFAABF CBBDDCAOGKD, [Out] Guid FANIDECOFDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6610CA0", Offset = "0x660FAA0", VA = "0x186610CA0")]
	public static bool INMPLBDGOOH(Guid FANIDECOFDM, [Out] FBFELBFAABF CBBDDCAOGKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6610BC0", Offset = "0x660F9C0", VA = "0x186610BC0")]
	public static FBFELBFAABF DDMEDKHINKO(FBFELBFAABF CBBDDCAOGKD)
	{
		return default(FBFELBFAABF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6610E10", Offset = "0x660FC10", VA = "0x186610E10")]
	public static FPCJGEENPKJ OHKPNLIONIA(FBFELBFAABF MPJIDDGDCNI)
	{
		return default(FPCJGEENPKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6610DD0", Offset = "0x660FBD0", VA = "0x186610DD0")]
	internal static FBFELBFAABF MHKPEIINNOM(FPCJGEENPKJ MEBEJKKBLMN)
	{
		return default(FBFELBFAABF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FOKDDMBPLBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OLFHIKKELJF BKAFPPCEBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<DPCEHPBDAFI> FNHMBHHMNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KNBLBACAGKB PFLINPFCCDJ;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<DPCEHPBDAFI> DOKOHPNPFOE(bool PIJJDJBILEF = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DPCEHPBDAFI JCFMDKOHKGP(MNFCKJNKANA ACNHNLBOPON);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GPGEADBBKPF(MNFCKJNKANA ACNHNLBOPON);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<DPCEHPBDAFI> GAHDCHNGDAK(MNFCKJNKANA ACNHNLBOPON, bool MDDPOOLGKOJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HPKEJJKEOMC(MNFCKJNKANA JOLMOLGNOFM, FBFELBFAABF CBBDDCAOGKD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DPCEHPBDAFI HOHBJNBIHAK(FBFELBFAABF CBBDDCAOGKD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HMKAAMLBPAN<T>(FBFELBFAABF CBBDDCAOGKD, MJPOKEDANBD AGPPJHLAEDL, bool CJNKLILLDLJ, T MLBFGGJBJJC, [Optional] Action JIJKGINGJEA) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GNKPKKPNPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AFBMJJBHNJD(LBFMLKMCDDP JJGMEBEMOEB, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJDKHFFNEOG(LBFMLKMCDDP JJGMEBEMOEB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NNCIHKMOPDE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	MNFCKJNKANA EDMAPIBKBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EJEIFLCIKHD MENKDJNCBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KEHHDGIBOGN EBILINJDIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KBLFDHEFLKH> LIOBBPFGCIE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MOJNCDCPNPG;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FBFELBFAABF GANIKAKEDBG(MNFCKJNKANA ACNHNLBOPON);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KBLFDHEFLKH> IOEAIDPKHML(CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task OMFEDDFGEEJ(long CGIDLDOBHII, long FDDHOJFABCM, IReadOnlyList<EAODJFHDLKK> NJFJINOFIJD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<MNFCKJNKANA> CLPILMFGDFI();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KPAGFLNMGBC
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6611A40", Offset = "0x6610840", VA = "0x186611A40")]
	public static FBFELBFAABF LEKEOKHHJGE(this NNCIHKMOPDE JHJMODDJFJB)
	{
		return default(FBFELBFAABF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OCMACAKJBOL<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string FNMBKODDINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EIPANEHLKND<TPermission> LFFIGIBCGDI;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class LIJJNPDLMFA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? IPEALMPLOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	protected LIJJNPDLMFA(object? PLMHLABJDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool HAMHPDPLHOK(object? NKKIECLCEML);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class NKCBKPHMNLD<T> : LIJJNPDLMFA where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T ILLPEAHBEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> JGAKNKKHJBJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x822960", Offset = "0x821760", VA = "0x180822960")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E75050", Offset = "0x3E73E50", VA = "0x183E75050", Slot = "4")]
	public override bool HAMHPDPLHOK(object? NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E74BD0", Offset = "0x3E739D0", VA = "0x183E74BD0")]
	public bool EEKFPCCGPHJ(T GOOMNFNLFLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E75370", Offset = "0x3E74170", VA = "0x183E75370")]
	public NKCBKPHMNLD(T IDLIOJCDHNC, IEqualityComparer<T> JGAKNKKHJBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OELLOGIMANL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<MJPOKEDANBD, bool> GCGNIHAHIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<MJPOKEDANBD, LIJJNPDLMFA> DFAKIMFAEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly GPNMHGKBPLF DCDHLHKPING;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x66121C0", Offset = "0x6610FC0", VA = "0x1866121C0")]
	public OELLOGIMANL(GPNMHGKBPLF DCDHLHKPING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6611CD0", Offset = "0x6610AD0", VA = "0x186611CD0")]
	public bool EEHIFNDKCGE(MJPOKEDANBD AGPPJHLAEDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2851F30", Offset = "0x2850D30", VA = "0x182851F30")]
	public bool KNAKMLODFBL<T>(MJPOKEDANBD AGPPJHLAEDL, bool CJNKLILLDLJ, T NKKIECLCEML) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2852440", Offset = "0x2851240", VA = "0x182852440")]
	public (bool, T?) PBKHDMEPMFI<T>(MJPOKEDANBD AGPPJHLAEDL) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6612010", Offset = "0x6610E10", VA = "0x186612010")]
	public bool KNAKMLODFBL(MJPOKEDANBD AGPPJHLAEDL, bool CJNKLILLDLJ, object NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x66120F0", Offset = "0x6610EF0", VA = "0x1866120F0")]
	public (bool, object) PBKHDMEPMFI(MJPOKEDANBD AGPPJHLAEDL)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2851EF0", Offset = "0x2850CF0", VA = "0x182851EF0")]
	private void IEOPIEDAHPJ<T>(MJPOKEDANBD AGPPJHLAEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6611F40", Offset = "0x6610D40", VA = "0x186611F40")]
	private LIJJNPDLMFA JKGGOLKHIKI(MJPOKEDANBD AGPPJHLAEDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6611D40", Offset = "0x6610B40", VA = "0x186611D40")]
	public void GMFAKINJIKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class ODHNNLBNHAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string GICPKDKGGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type CPJDOLJCAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly EDIBCCKGODH GGNHNHGEJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly MJPOKEDANBD PIEDKINDFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public GDMCJMPMJEC HMBCKGJKPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public JPIJHLNACKC BGGKIPCMINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public CHJKFCEEKCB FFNIFBLOMFI;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6611C30", Offset = "0x6610A30", VA = "0x186611C30")]
	public ODHNNLBNHAE(Type FBPIGEGIOJF, string HNNMPGDGHBP, MJPOKEDANBD AGPPJHLAEDL, GDMCJMPMJEC OFBBDLLHIFG, JPIJHLNACKC NLHGJJKODKN, CHJKFCEEKCB HHFMGGJMJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6611BE0", Offset = "0x66109E0", VA = "0x186611BE0")]
	public object NMLJPLEFNBL(object? FPEEGIOMOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x284B260", Offset = "0x284A060", VA = "0x18284B260")]
	public void IEOPIEDAHPJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6611B30", Offset = "0x6610930", VA = "0x186611B30")]
	public void IEOPIEDAHPJ(Type ICFCDDDGJGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class GILEPFIKCKL<T> : ODHNNLBNHAE where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string OGOIDBKHJKP(T NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T OPGGEDNILGL(string? NMKBOLGEHFE, T IDLIOJCDHNC);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class MMLHELJMJCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public OGOIDBKHJKP serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public OPGGEDNILGL parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public MMLHELJMJCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3DF3AC0", Offset = "0x3DF28C0", VA = "0x183DF3AC0")]
		internal string IAAMCOOOKCL(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3DF3B60", Offset = "0x3DF2960", VA = "0x183DF3B60")]
		internal object NIPJHGHIHLB(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x36C5AB0", Offset = "0x36C48B0", VA = "0x1836C5AB0")]
	public GILEPFIKCKL(MJPOKEDANBD AGPPJHLAEDL, string HNNMPGDGHBP, [Optional] OGOIDBKHJKP? OFBBDLLHIFG, [Optional] OPGGEDNILGL? NLHGJJKODKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x36C4D20", Offset = "0x36C3B20", VA = "0x1836C4D20")]
	private static object? CINNELLPCMC(OPGGEDNILGL? NLHGJJKODKN, string? NMKBOLGEHFE, object? IDLIOJCDHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x36C57F0", Offset = "0x36C45F0", VA = "0x1836C57F0")]
	private static string FILLENIGNNA(OGOIDBKHJKP? KFPGJLJLJJO, object? NKKIECLCEML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string GDMCJMPMJEC(object? NKKIECLCEML);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object JPIJHLNACKC(string? NMKBOLGEHFE, [Optional] object IDLIOJCDHNC);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate LIJJNPDLMFA CHJKFCEEKCB();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class GPNMHGKBPLF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class DCPGKOHEGBP : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static DCPGKOHEGBP AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6607A70", Offset = "0x6606870", VA = "0x186607A70", Slot = "4")]
		public bool Equals(List<string> AHPBAINPGNA, List<string> KMGCEBLELOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6607BC0", Offset = "0x66069C0", VA = "0x186607BC0", Slot = "5")]
		public int GetHashCode(List<string> NHLNHJGAONN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DCPGKOHEGBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class JFBAMJPLAGM : EMKOBGBMKCM<LDDMPLJDBDN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6610770", Offset = "0x660F570", VA = "0x186610770", Slot = "9")]
		public override string FILLENIGNNA(LDDMPLJDBDN ECKJJAACLOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6610860", Offset = "0x660F660", VA = "0x186610860", Slot = "10")]
		protected override bool ILCKJPOOHGA(string ECKJJAACLOE, [Out] LDDMPLJDBDN NKKIECLCEML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6610A40", Offset = "0x660F840", VA = "0x186610A40")]
		public JFBAMJPLAGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly LGIPOKIPLPC FPNJJPNAFCB;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly JFBAMJPLAGM HNBBKPOGLDO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<ODHNNLBNHAE> CHCICKKJBDM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<MJPOKEDANBD> BCEKJLILLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<MJPOKEDANBD, ODHNNLBNHAE> PMANMBOIPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x660F220", Offset = "0x660E020", VA = "0x18660F220")]
	public GPNMHGKBPLF([Optional] IList<ODHNNLBNHAE>? ENOJBKFCOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x660E3B0", Offset = "0x660D1B0", VA = "0x18660E3B0")]
	public ODHNNLBNHAE BKEINMHAEGE(MJPOKEDANBD AGPPJHLAEDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OLFHIKKELJF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DPCEHPBDAFI FLNHKEOFMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class HMPBGOCCPPB : OLFHIKKELJF
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static HMPBGOCCPPB DNBKDDOOKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly ONEGDICBOHO IJGACHIMBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<ONEGDICBOHO> KJGGCDHHJGP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DPCEHPBDAFI FLNHKEOFMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x660FFA0", Offset = "0x660EDA0", VA = "0x18660FFA0")]
	public HMPBGOCCPPB(ONEGDICBOHO LOOAJMNANLE, IReadOnlyList<ONEGDICBOHO> LCIPDEOOPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x660F570", Offset = "0x660E370", VA = "0x18660F570")]
	private static HMPBGOCCPPB CEPJAMPPKNB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PLBNLGLOGLI
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<FBFELBFAABF> DJMFEOFANPA;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6614650", Offset = "0x6613450", VA = "0x186614650")]
	public static bool BJGNFCFHJEI(this MNFCKJNKANA NGFKMPBFIHD, FBFELBFAABF CBBDDCAOGKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6614730", Offset = "0x6613530", VA = "0x186614730")]
	public static bool OBKKEBOAOMM(this MNFCKJNKANA NGFKMPBFIHD, FBFELBFAABF CBBDDCAOGKD, KEHHDGIBOGN DGCMNINLNDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface ABHFEMMPIPO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool NDKMMKACDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool BNFKFGMNDDG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CCGFGDEKNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool JJHGMAIGPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IINLBDLINKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GIFAONKIOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool ECINIGKNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool GJABDDPMLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool GGCNIANOJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DPFIIOBCAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool DJIKNMIMNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool CJEGDABKLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> KGBLFBGCPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LDDMPLJDBDN CGKMLKFAHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface DPCEHPBDAFI : ABHFEMMPIPO, DELIELAMGBH, OCMACAKJBOL<MJPOKEDANBD>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string MGFEJGECHII
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	FBFELBFAABF LLLILFCNHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) LAJNDMPPLJM<T>(MJPOKEDANBD AGPPJHLAEDL) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum MJPOKEDANBD
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
internal class ONEGDICBOHO : DPCEHPBDAFI, ABHFEMMPIPO, DELIELAMGBH, OCMACAKJBOL<MJPOKEDANBD>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly GPNMHGKBPLF JALDDBLOAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly OELLOGIMANL MGOBNDMKBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? FCBAKJINFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? LBGEDLOIAPN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool ENGJNGBGLOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x66124C0", Offset = "0x66112C0", VA = "0x1866124C0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool LMKFAKFEILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6613B70", Offset = "0x6612970", VA = "0x186613B70", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool MGDMOAIDLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x66128B0", Offset = "0x66116B0", VA = "0x1866128B0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool ANPMNEMHAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x66126B0", Offset = "0x66114B0", VA = "0x1866126B0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool JHDOGMMJNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6612510", Offset = "0x6611310", VA = "0x186612510", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool KBBCCFDLLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x66127A0", Offset = "0x66115A0", VA = "0x1866127A0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public FBFELBFAABF LLLILFCNHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x822960", Offset = "0x821760", VA = "0x180822960", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(FBFELBFAABF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7B3330", Offset = "0x7B2130", VA = "0x1807B3330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string FNMBKODDINK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6612C00", Offset = "0x6611A00", VA = "0x186612C00", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x66142C0", Offset = "0x66130C0", VA = "0x1866142C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string MGFEJGECHII
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6612C00", Offset = "0x6611A00", VA = "0x186612C00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool JPAEHMLGEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x89A840", Offset = "0x899640", VA = "0x18089A840")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x89A130", Offset = "0x898F30", VA = "0x18089A130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NDKMMKACDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6612560", Offset = "0x6611360", VA = "0x186612560", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LDDMPLJDBDN CGKMLKFAHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6612860", Offset = "0x6611660", VA = "0x186612860", Slot = "20")]
		get
		{
			return default(LDDMPLJDBDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BNFKFGMNDDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6612C50", Offset = "0x6611A50", VA = "0x186612C50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool CCGFGDEKNIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6612470", Offset = "0x6611270", VA = "0x186612470", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JJHGMAIGPDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6613BC0", Offset = "0x66129C0", VA = "0x186613BC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IINLBDLINKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6613CB0", Offset = "0x6612AB0", VA = "0x186613CB0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GIFAONKIOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6612D30", Offset = "0x6611B30", VA = "0x186612D30", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool ECINIGKNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6612700", Offset = "0x6611500", VA = "0x186612700", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool GJABDDPMLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6613C10", Offset = "0x6612A10", VA = "0x186613C10", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool GGCNIANOJEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6612900", Offset = "0x6611700", VA = "0x186612900", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> KGBLFBGCPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6613D00", Offset = "0x6612B00", VA = "0x186613D00", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool IPBCLJGCCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x66124C0", Offset = "0x66112C0", VA = "0x1866124C0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool NLBMIJIEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6612510", Offset = "0x6611310", VA = "0x186612510", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool LOMDKJOGKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6613B70", Offset = "0x6612970", VA = "0x186613B70", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DPFIIOBCAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x66127F0", Offset = "0x66115F0", VA = "0x1866127F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool DJIKNMIMNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6613C60", Offset = "0x6612A60", VA = "0x186613C60", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool HOAPLAFPECI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x66128B0", Offset = "0x66116B0", VA = "0x1866128B0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool CJEGDABKLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x66140E0", Offset = "0x6612EE0", VA = "0x1866140E0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BLOIDKPAPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x66126B0", Offset = "0x66114B0", VA = "0x1866126B0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool NNENMBFDKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x66127A0", Offset = "0x66115A0", VA = "0x1866127A0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EIPANEHLKND<MJPOKEDANBD> LFFIGIBCGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6612950", Offset = "0x6611750", VA = "0x186612950", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6614210", Offset = "0x6613010", VA = "0x186614210", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2858CE0", Offset = "0x2857AE0", VA = "0x182858CE0", Slot = "6")]
	public (bool, T?) LAJNDMPPLJM<T>(MJPOKEDANBD AGPPJHLAEDL) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2858CA0", Offset = "0x2857AA0", VA = "0x182858CA0")]
	public ONEGDICBOHO EOEDFGCABGF<T>(MJPOKEDANBD AGPPJHLAEDL, bool CJNKLILLDLJ, T NKKIECLCEML) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6614630", Offset = "0x6613430", VA = "0x186614630")]
	public ONEGDICBOHO(FBFELBFAABF CBBDDCAOGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6614420", Offset = "0x6613220", VA = "0x186614420")]
	public ONEGDICBOHO(FBFELBFAABF CBBDDCAOGKD, [Optional] string? FCBAKJINFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x66145A0", Offset = "0x66133A0", VA = "0x1866145A0")]
	public ONEGDICBOHO(ONEGDICBOHO HKEHIHNMMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6614440", Offset = "0x6613240", VA = "0x186614440")]
	internal ONEGDICBOHO(FBFELBFAABF MEFHPHFJMGH, [Optional] string? FCBAKJINFEB, [Optional] ONEGDICBOHO? HKEHIHNMMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6614310", Offset = "0x6613110", VA = "0x186614310")]
	public static EDIBCCKGODH PPHHLKPDJFK(MJPOKEDANBD AGPPJHLAEDL)
	{
		return default(EDIBCCKGODH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6612840", Offset = "0x6611640", VA = "0x186612840")]
	public void GMFAKINJIKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6613D60", Offset = "0x6612B60", VA = "0x186613D60")]
	internal ONEGDICBOHO MIFFLKPNDLN(ONEGDICBOHO PHMFEJJDIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6613700", Offset = "0x6612500", VA = "0x186613700")]
	internal IReadOnlyCollection<MJPOKEDANBD> JLEDLPHOJFD(ONEGDICBOHO HKEHIHNMMDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6614130", Offset = "0x6612F30", VA = "0x186614130")]
	public bool NDPFEFPEKMO(MJPOKEDANBD AGPPJHLAEDL, bool CJNKLILLDLJ, string NGODECBOJDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x66125B0", Offset = "0x66113B0", VA = "0x1866125B0")]
	public (bool, string) CLHHHKICGJG(MJPOKEDANBD AGPPJHLAEDL)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6612750", Offset = "0x6611550", VA = "0x186612750")]
	internal void EMPKPLMDAKP(MJPOKEDANBD AGPPJHLAEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6612A00", Offset = "0x6611800", VA = "0x186612A00")]
	public IKMBBPOMBEL IAIJCKOLGKH(Func<FBFELBFAABF, Guid> APLBHNAOBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6612D80", Offset = "0x6611B80", VA = "0x186612D80")]
	public void JIDDJLOFLKF(IKMBBPOMBEL MFNIIHDIBEB, Func<Guid, FBFELBFAABF> HENCNKCFDKP, [Optional] FBFELBFAABF? CJOIBOBKFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6612CA0", Offset = "0x6611AA0", VA = "0x186612CA0")]
	[CompilerGenerated]
	private void JCKKNLIKOEK(MJPOKEDANBD CGNBGCHBHPI, JOCJJEGBLHC AJFIALNDPHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GBLOLCMBKPI : GNKPKKPNPCC, FOKDDMBPLBC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class JKJPOAKNJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public ONEGDICBOHO newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public JKJPOAKNJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6610A80", Offset = "0x660F880", VA = "0x186610A80")]
		internal bool JADPFMGINLK(ONEGDICBOHO rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class LPDHLLFNNNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public FBFELBFAABF roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public LPDHLLFNNNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6611AA0", Offset = "0x66108A0", VA = "0x186611AA0")]
		internal bool IAINCMCEPAK(FBFELBFAABF r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct IHALJGHIADI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public GBLOLCMBKPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LBFMLKMCDDP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<KBLFDHEFLKH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x66100B0", Offset = "0x660EEB0", VA = "0x1866100B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6610710", Offset = "0x660F510", VA = "0x186610710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class CDMPAPKIGKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CDMPAPKIGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6607990", Offset = "0x6606790", VA = "0x186607990")]
		internal void LEPCMDPDENG(IKMBBPOMBEL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6607870", Offset = "0x6606670", VA = "0x186607870")]
		internal void HGKMKMHOLOF(IKMBBPOMBEL r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct AOHANKNLPGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LBFMLKMCDDP roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class AEMLMABLMKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<IKMBBPOMBEL, JOCJJEGBLHC> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public AEMLMABLMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x66077E0", Offset = "0x66065E0", VA = "0x1866077E0")]
		internal void EJMBFLIGCCM(IKMBBPOMBEL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6607810", Offset = "0x6606610", VA = "0x186607810")]
		internal void FGFHNBMIKFC(IKMBBPOMBEL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6607840", Offset = "0x6606640", VA = "0x186607840")]
		internal void KFBNFPMMFDH(IKMBBPOMBEL r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AMNLCHJGFGF<T> where T : notnull
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
			public AMNLCHJGFGF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<KBLFDHEFLKH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x304AAB0", Offset = "0x30498B0", VA = "0x18304AAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x920680", Offset = "0x91F480", VA = "0x180920680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public GBLOLCMBKPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MJPOKEDANBD rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public FBFELBFAABF accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public EDIBCCKGODH recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public AMNLCHJGFGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3738380", Offset = "0x3737180", VA = "0x183738380")]
		[AsyncStateMachine(typeof(AMNLCHJGFGF<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void PKIOIPEBIOA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct EEEGNILBPMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<EAODJFHDLKK> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DOGBMLGGHFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public NNCIHKMOPDE rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LBFMLKMCDDP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<FBFELBFAABF, ONEGDICBOHO> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FHEHABMALFA debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6607DB0", Offset = "0x6606BB0", VA = "0x186607DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x66088C0", Offset = "0x66076C0", VA = "0x1866088C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly NNCIHKMOPDE JHJMODDJFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly HMPBGOCCPPB IINBOMAILBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FHEHABMALFA HDPKDHNLNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, ONEGDICBOHO> LOBIGAKBHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<FBFELBFAABF, ONEGDICBOHO> FNBLAPFAIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<FBFELBFAABF, ONEGDICBOHO> ELNLNLBCHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<ONEGDICBOHO> AMPOICBKPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool EPIGBFCOFMJ;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly MJPOKEDANBD[] HFNINNMDCMF;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public OLFHIKKELJF BKAFPPCEBNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<DPCEHPBDAFI> FNHMBHHMNFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x660B700", Offset = "0x660A500", VA = "0x18660B700", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event KNBLBACAGKB PFLINPFCCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x66095D0", Offset = "0x66083D0", VA = "0x1866095D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x660AD70", Offset = "0x6609B70", VA = "0x18660AD70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x660B540", Offset = "0x660A340", VA = "0x18660B540")]
	[NAAAALLPNIA(KMIEHGCCHON.Room, PBKIGNPNCFO.None)]
	private static void LHBJIPOANBJ(IBPIJCMLLGH GGHBEJLCMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x660E0F0", Offset = "0x660CEF0", VA = "0x18660E0F0")]
	[UnityEngine.Scripting.Preserve]
	internal GBLOLCMBKPI([LICAMFFCLCL(null)] NNCIHKMOPDE LGMNCLBBEIL, [LICAMFFCLCL(null)] HMPBGOCCPPB OBJFCJLMPAF, [LICAMFFCLCL(null)] FHEHABMALFA HDPKDHNLNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6609670", Offset = "0x6608470", VA = "0x186609670", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x660C890", Offset = "0x660B690", VA = "0x18660C890")]
	private void OILKIACCFAO(IEnumerable<ONEGDICBOHO> CMHNLAIFBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6609AA0", Offset = "0x66088A0", VA = "0x186609AA0", Slot = "12")]
	public bool GPGEADBBKPF(MNFCKJNKANA ACNHNLBOPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x660C1D0", Offset = "0x660AFD0", VA = "0x18660C1D0")]
	private void MOJNCDCPNPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6608920", Offset = "0x6607720", VA = "0x186608920")]
	private void AEAFHOOIFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6609550", Offset = "0x6608350", VA = "0x186609550", Slot = "10")]
	public IReadOnlyList<DPCEHPBDAFI> DOKOHPNPFOE(bool PIJJDJBILEF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x660AB20", Offset = "0x6609920", VA = "0x18660AB20", Slot = "11")]
	public DPCEHPBDAFI JCFMDKOHKGP(MNFCKJNKANA ACNHNLBOPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6609180", Offset = "0x6607F80", VA = "0x186609180")]
	private FBFELBFAABF DEFDMGJFGAO(MNFCKJNKANA ACNHNLBOPON)
	{
		return default(FBFELBFAABF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6609F60", Offset = "0x6608D60", VA = "0x186609F60", Slot = "14")]
	public bool HPKEJJKEOMC(MNFCKJNKANA JOLMOLGNOFM, FBFELBFAABF CBBDDCAOGKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6609EC0", Offset = "0x6608CC0", VA = "0x186609EC0", Slot = "15")]
	public DPCEHPBDAFI HOHBJNBIHAK(FBFELBFAABF CBBDDCAOGKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x660C1E0", Offset = "0x660AFE0", VA = "0x18660C1E0")]
	private static bool NEGEHPPGHML(NBKCNIDPBKA GCHCDOBCMGH, FBFELBFAABF CBBDDCAOGKD, [Out] IKMBBPOMBEL? LNLPIDEPPMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x660C7A0", Offset = "0x660B5A0", VA = "0x18660C7A0")]
	private static void OBLHNDIMNEE(NBKCNIDPBKA GCHCDOBCMGH, Action<IKMBBPOMBEL> ALALDGMPPMF, FBFELBFAABF HHGJEJJLPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x660C510", Offset = "0x660B310", VA = "0x18660C510")]
	private static void OBLHNDIMNEE(NBKCNIDPBKA GCHCDOBCMGH, Action<IKMBBPOMBEL> ALALDGMPPMF, Predicate<FBFELBFAABF> MOHODNECMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x660B4D0", Offset = "0x660A2D0", VA = "0x18660B4D0")]
	private void LDPCDFPMDEF(MNFCKJNKANA ACNHNLBOPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6608B10", Offset = "0x6607910", VA = "0x186608B10", Slot = "4")]
	[AsyncStateMachine(typeof(IHALJGHIADI))]
	public Task AFBMJJBHNJD([CanBeNull] LBFMLKMCDDP JJGMEBEMOEB, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
	public void DJDKHFFNEOG(LBFMLKMCDDP JJGMEBEMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x660B750", Offset = "0x660A550", VA = "0x18660B750")]
	private void MHJPNLEBHMN(NBKCNIDPBKA BNJOKJNGCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6609250", Offset = "0x6608050", VA = "0x186609250")]
	internal static string DEJOLBIMMGO(NNCIHKMOPDE JHJMODDJFJB, LBFMLKMCDDP JJGMEBEMOEB, IReadOnlyDictionary<FBFELBFAABF, ONEGDICBOHO> FNBLAPFAIDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x660D110", Offset = "0x660BF10", VA = "0x18660D110")]
	private static void PGGMAFLCHDN(LBFMLKMCDDP JJGMEBEMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6609B70", Offset = "0x6608970", VA = "0x186609B70")]
	private static void HGHCGDAPLBG(NBKCNIDPBKA CMGBFHDLHLL, IReadOnlyDictionary<FBFELBFAABF, ONEGDICBOHO> FNBLAPFAIDJ, StringBuilder CECACINMOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6608E40", Offset = "0x6607C40", VA = "0x186608E40")]
	private static bool BHOJFONOFPD(string MKEOECJIPCN, [Out] Guid AAIDFFCHJEH, [Out] FBFELBFAABF CBBDDCAOGKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x660BA90", Offset = "0x660A890", VA = "0x18660BA90")]
	private static void MOIJPCODBFP(LBFMLKMCDDP JJGMEBEMOEB, StringBuilder CECACINMOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x26EFC80", Offset = "0x26EEA80", VA = "0x1826EFC80", Slot = "16")]
	public bool HMKAAMLBPAN<T>(FBFELBFAABF CBBDDCAOGKD, MJPOKEDANBD AGPPJHLAEDL, bool CJNKLILLDLJ, T MLBFGGJBJJC, [Optional] Action JIJKGINGJEA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6608C30", Offset = "0x6607A30", VA = "0x186608C30")]
	private void AOIFOJIMEDG(FBFELBFAABF CBBDDCAOGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6609780", Offset = "0x6608580", VA = "0x186609780")]
	private bool EMBKHNDFNJD(MNFCKJNKANA ACNHNLBOPON, FBFELBFAABF CBBDDCAOGKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x660B180", Offset = "0x6609F80", VA = "0x18660B180")]
	internal ONEGDICBOHO LCEEHGKDDBJ(MNFCKJNKANA ACNHNLBOPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6609A90", Offset = "0x6608890", VA = "0x186609A90", Slot = "13")]
	public IReadOnlyList<DPCEHPBDAFI> GAHDCHNGDAK(MNFCKJNKANA ACNHNLBOPON, bool MDDPOOLGKOJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6608F50", Offset = "0x6607D50", VA = "0x186608F50")]
	internal IReadOnlyList<ONEGDICBOHO> CCOJKNNGHLH(MNFCKJNKANA ACNHNLBOPON, bool MDDPOOLGKOJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x660A0F0", Offset = "0x6608EF0", VA = "0x18660A0F0")]
	private void IDAFACCHAHL(KBLFDHEFLKH LKLCBAPPIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x66097A0", Offset = "0x66085A0", VA = "0x1866097A0")]
	private static bool FHHMMCNKAOM(ONEGDICBOHO ELOPPPGCOOJ, IReadOnlyDictionary<FBFELBFAABF, ONEGDICBOHO> FNBLAPFAIDJ, [Out] IReadOnlyList<MJPOKEDANBD> PPHOOPPGCPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x660AC30", Offset = "0x6609A30", VA = "0x18660AC30")]
	[AsyncStateMachine(typeof(DOGBMLGGHFC))]
	private static Task JCJNMKNNOJO(NNCIHKMOPDE JHJMODDJFJB, LBFMLKMCDDP JJGMEBEMOEB, IReadOnlyDictionary<FBFELBFAABF, ONEGDICBOHO> FNBLAPFAIDJ, FHEHABMALFA HDPKDHNLNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x660A880", Offset = "0x6609680", VA = "0x18660A880")]
	[CompilerGenerated]
	internal static void IKJJOBAHMPH(Func<IKMBBPOMBEL, JOCJJEGBLHC> KGGDJNAJCPH, AOHANKNLPGH P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x660AE10", Offset = "0x6609C10", VA = "0x18660AE10")]
	[CompilerGenerated]
	internal static bool JJNJIHHNNLG(FBFELBFAABF CBBDDCAOGKD, MJPOKEDANBD AGPPJHLAEDL, [Out] EAODJFHDLKK HDODBHKILEP, EEEGNILBPMC P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface JIADABJJGFC
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPKCNCKJMPE(MNFCKJNKANA IIKPMFEBEMA, MNFCKJNKANA EPEEMGIBCJP, IEnumerable<MNFCKJNKANA> KLCELIPFBKJ, [Out] LDDMPLJDBDN EOFJBMMKLGK, [Out] DNHEJHOCNPH GIMKLMKDMBO);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string OCMGLBNDCLC(DNHEJHOCNPH BPADMIFEFLF);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum DNHEJHOCNPH : byte
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
internal class KKCKNKLJNOC : JIADABJJGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly FOKDDMBPLBC PGJPIPEPLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly BDFLOHIKIKK FKNLBCEMJPI;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F90", Offset = "0x7B0D90", VA = "0x1807B1F90")]
	[RecRoom.NoEngine.Common.Preserve]
	public KKCKNKLJNOC([LICAMFFCLCL(null)] FOKDDMBPLBC JOEOLCOHOON, [LICAMFFCLCL(null)] BDFLOHIKIKK EEEPDFFIEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6611900", Offset = "0x6610700", VA = "0x186611900")]
	private static HILELHEEFEE? LPAJFAPABKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6611800", Offset = "0x6610600", VA = "0x186611800", Slot = "4")]
	public bool HPKCNCKJMPE(MNFCKJNKANA IIKPMFEBEMA, MNFCKJNKANA EPEEMGIBCJP, IEnumerable<MNFCKJNKANA> KLCELIPFBKJ, [Out] LDDMPLJDBDN EOFJBMMKLGK, [Out] DNHEJHOCNPH GIMKLMKDMBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6611940", Offset = "0x6610740", VA = "0x186611940", Slot = "5")]
	public string OCMGLBNDCLC(DNHEJHOCNPH BPADMIFEFLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x66111E0", Offset = "0x660FFE0", VA = "0x1866111E0")]
	internal bool CGDOJHAKAOE(MNFCKJNKANA IIKPMFEBEMA, MNFCKJNKANA EPEEMGIBCJP, IEnumerable<MNFCKJNKANA> KLCELIPFBKJ, KEHHDGIBOGN DGCMNINLNDE, HILELHEEFEE? KCANKJLIOLC, [Out] LDDMPLJDBDN EOFJBMMKLGK, [Out] DNHEJHOCNPH GIMKLMKDMBO)
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

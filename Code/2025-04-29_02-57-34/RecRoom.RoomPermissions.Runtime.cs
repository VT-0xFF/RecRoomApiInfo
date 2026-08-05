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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x83493A0", Offset = "0x83487A0", VA = "0x1883493A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HHJAPFEFMOO
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
		[Cpp2IlInjected.Address(RVA = "0x8349C40", Offset = "0x8349040", VA = "0x188349C40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void IPILJPDDDAB<TPermission>(TPermission JMKNDIFGMNN);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void HHFBOBCDKMN(EKIKILMCLIO PCGEDHPAHKB);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KIDAAJNECAH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JJPGLEDNJHP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PFOHJJFGGDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool EGIGLDJIKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PHBBGMLKGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GMDHALEAHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FPJPGAPIDLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MFEIOIIAPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class FIKJMNMFLJF
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum PAJPEDHFPMO
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
	public static readonly Guid DECCJEPPJFO;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid FDAJAPOKKHO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid DLANGALHAPM;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid NJMCNHIJENK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid OBKEIENMOEO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid GKGIKBGFHIB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly DPOKGANNFJP<JMJBOEJBCPI, Guid> CHOKDLELFAF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<JMJBOEJBCPI> DEIAEFFGMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8345530", Offset = "0x8344930", VA = "0x188345530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x83455B0", Offset = "0x83449B0", VA = "0x1883455B0")]
	public static JMJBOEJBCPI OOAMLALDPIH(Guid FIAGFFPOAHP)
	{
		return default(JMJBOEJBCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x83452B0", Offset = "0x83446B0", VA = "0x1883452B0")]
	public static Guid GMIJJAIEGDI(JMJBOEJBCPI HLBEKEOHNEI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x83454A0", Offset = "0x83448A0", VA = "0x1883454A0")]
	public static bool LPEFJHKOBDD(JMJBOEJBCPI HLBEKEOHNEI, [Out] Guid FIAGFFPOAHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8345350", Offset = "0x8344750", VA = "0x188345350")]
	public static bool IFNMJGMGJCL(Guid FIAGFFPOAHP, [Out] JMJBOEJBCPI HLBEKEOHNEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8345270", Offset = "0x8344670", VA = "0x188345270")]
	public static JMJBOEJBCPI DFEPFLCKMMK(JMJBOEJBCPI HLBEKEOHNEI)
	{
		return default(JMJBOEJBCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x83453F0", Offset = "0x83447F0", VA = "0x1883453F0")]
	public static PAJPEDHFPMO KAFAMBLIKDP(JMJBOEJBCPI MHJGCLAJEFI)
	{
		return default(PAJPEDHFPMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8345230", Offset = "0x8344630", VA = "0x188345230")]
	internal static JMJBOEJBCPI CJKIAPGPDDN(PAJPEDHFPMO PKDFNIEDKEN)
	{
		return default(JMJBOEJBCPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KBDLPIDDMPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ALIIAMMIGLH OKGNACECKOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<IMIDKHMKBGA> IFOLGKMBHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HHFBOBCDKMN CNHMPIOMFKC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<IMIDKHMKBGA> BDDDNFINJIA(bool PBKGEGICMAO = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IMIDKHMKBGA CJBBAPJNFEJ(EKIKILMCLIO PCGEDHPAHKB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EDPGEMIPMGK(EKIKILMCLIO PCGEDHPAHKB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<IMIDKHMKBGA> MPIFLPFBODD(EKIKILMCLIO PCGEDHPAHKB, bool GEKBLDAICAN = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ELEACHPDHMI(EKIKILMCLIO LLJOPDGODFN, JMJBOEJBCPI HLBEKEOHNEI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IMIDKHMKBGA CBBICPGEGHB(JMJBOEJBCPI HLBEKEOHNEI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MBGNGPIDAFN<T>(JMJBOEJBCPI HLBEKEOHNEI, MCGEPIMAEII JMKNDIFGMNN, bool DMEPAPCCCNF, T LICDMCPJILC, [Optional] Action NHPFCFCADKB) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string MNBEGCPEEKN(MCGEPIMAEII JMKNDIFGMNN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EMCNCPBBKPI
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HKEOIAOAJPB(MMIOGOBDHFC NILNGFKCINL, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNANLPCENPP(MMIOGOBDHFC NILNGFKCINL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JLPIHLHPFLF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EKIKILMCLIO EPJKFIDHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ECGOJJLBFIL DIEKANAMOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HNAJHGJKLNP NCJAHPOHGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<ALOJCBLEHGG> KKLILGEJGPL;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action ECMNGGOEDBG;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JMJBOEJBCPI ELIADGKDCNL(EKIKILMCLIO PCGEDHPAHKB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<ALOJCBLEHGG> ONDLBOEAGIP(CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BFAGDCEPJAD(long NFMLPECGLEO, IReadOnlyList<LKPCFELAMKB> NMPLADHCHKI);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task HEAIIAKDKPA(long NFMLPECGLEO, long PIEICLNIOGJ, IReadOnlyList<LKPCFELAMKB> NMPLADHCHKI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<EKIKILMCLIO> MHIHICBBACB();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FPCPHEAHMLA
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8345960", Offset = "0x8344D60", VA = "0x188345960")]
	public static JMJBOEJBCPI HMMIJNHAHKJ(this JLPIHLHPFLF PABKKJHIGIK)
	{
		return default(JMJBOEJBCPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ECPILNEPGLE<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string DGKBAEKOCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event IPILJPDDDAB<TPermission> FHIMIIDIKPE;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class GJGLGKBFEKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? FPKKKPOCKHK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? CPEICFGNMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8346540", Offset = "0x8345940", VA = "0x188346540")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8346620", Offset = "0x8345A20", VA = "0x188346620")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8346720", Offset = "0x8345B20", VA = "0x188346720")]
	protected GJGLGKBFEKB(object? GFFLLCPKMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool KGKLHKNNLNM(object? OOEMJLHLIHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class MIMFMAHHBFP<T> : GJGLGKBFEKB where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> CIEFMHCOCHD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x50C6D90", Offset = "0x50C6190", VA = "0x1850C6D90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x50C77D0", Offset = "0x50C6BD0", VA = "0x1850C77D0", Slot = "4")]
	public override bool KGKLHKNNLNM(object? OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x50C70A0", Offset = "0x50C64A0", VA = "0x1850C70A0")]
	public bool JDGGGPFKNPF(T OMEAONLOIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x50C7A10", Offset = "0x50C6E10", VA = "0x1850C7A10")]
	public MIMFMAHHBFP(T JMBBJHIBCGJ, IEqualityComparer<T> CIEFMHCOCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class AOJNKHBIJHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<MCGEPIMAEII, bool> OILPIJBMKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<MCGEPIMAEII, GJGLGKBFEKB> FLDBINHLBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly CGAPNMHKEGG MNMHDGMBMIN;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83414A0", Offset = "0x83408A0", VA = "0x1883414A0")]
	public AOJNKHBIJHB(CGAPNMHKEGG MNMHDGMBMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8341080", Offset = "0x8340480", VA = "0x188341080")]
	public bool EHIHEFGIEEK(MCGEPIMAEII JMKNDIFGMNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3E68E70", Offset = "0x3E68270", VA = "0x183E68E70")]
	public bool FONGMEGCDCL<T>(MCGEPIMAEII JMKNDIFGMNN, bool DMEPAPCCCNF, T OOEMJLHLIHJ) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E68970", Offset = "0x3E67D70", VA = "0x183E68970")]
	public (bool, T?) EAOKMHCNHFG<T>(MCGEPIMAEII JMKNDIFGMNN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x83410F0", Offset = "0x83404F0", VA = "0x1883410F0")]
	public bool FONGMEGCDCL(MCGEPIMAEII JMKNDIFGMNN, bool DMEPAPCCCNF, object OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8340EE0", Offset = "0x83402E0", VA = "0x188340EE0")]
	public (bool, object) EAOKMHCNHFG(MCGEPIMAEII JMKNDIFGMNN)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3E68E10", Offset = "0x3E68210", VA = "0x183E68E10")]
	private void FJIGKMBECAL<T>(MCGEPIMAEII JMKNDIFGMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x83413D0", Offset = "0x83407D0", VA = "0x1883413D0")]
	private GJGLGKBFEKB KNGHEHCNPPE(MCGEPIMAEII JMKNDIFGMNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x83411D0", Offset = "0x83405D0", VA = "0x1883411D0")]
	public void JDPEGIPNLOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class LMDOPMIIPLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ODEDFFJLGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type FNLCGKHOOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly CEKMAHGBMDE FKAIKBAGOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly MCGEPIMAEII CEHDICFAFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NHMJOMMGHIJ KIBDCLDMLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NIPAPMOMDPA JEOOLDAPNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public IABMAJDOJIP JLCJELDDHKO;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8348C30", Offset = "0x8348030", VA = "0x188348C30")]
	public LMDOPMIIPLM(Type EMJOLJHILJL, string EFJMFKDKNNF, MCGEPIMAEII JMKNDIFGMNN, NHMJOMMGHIJ OKLFJMEHIBN, NIPAPMOMDPA MKDBJJICPBK, IABMAJDOJIP PELEBFGPFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8348BE0", Offset = "0x8347FE0", VA = "0x188348BE0")]
	public object IPKHAJGKKMJ(object? DMMBOHMLHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x379EF00", Offset = "0x379E300", VA = "0x18379EF00")]
	public void FJIGKMBECAL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8348B30", Offset = "0x8347F30", VA = "0x188348B30")]
	public void FJIGKMBECAL(Type GGFNDHFCLFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class COMCJLGLPIG<T> : LMDOPMIIPLM where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string MPEDAGNIMDP(T OOEMJLHLIHJ);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T DJGAHGEHIMD(string? PMKBJOADKJL, T JMBBJHIBCGJ);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class HMJAKAFDJMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public MPEDAGNIMDP serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DJGAHGEHIMD parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public HMJAKAFDJMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x496AD70", Offset = "0x496A170", VA = "0x18496AD70")]
		internal string DHCBMCCGFFN(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x496ACB0", Offset = "0x496A0B0", VA = "0x18496ACB0")]
		internal object CBPOBNJLAJO(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x663C030", Offset = "0x663B430", VA = "0x18663C030")]
	public COMCJLGLPIG(MCGEPIMAEII JMKNDIFGMNN, string EFJMFKDKNNF, [Optional] MPEDAGNIMDP? OKLFJMEHIBN, [Optional] DJGAHGEHIMD? MKDBJJICPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x663AE00", Offset = "0x663A200", VA = "0x18663AE00")]
	private static object? ILOIKAMJPOD(DJGAHGEHIMD? MKDBJJICPBK, string? PMKBJOADKJL, object? JMBBJHIBCGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x663B7A0", Offset = "0x663ABA0", VA = "0x18663B7A0")]
	private static string PEGKBLBFNLH(MPEDAGNIMDP? FEAFGOMBLJN, object? OOEMJLHLIHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string NHMJOMMGHIJ(object? OOEMJLHLIHJ);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object NIPAPMOMDPA(string? PMKBJOADKJL, [Optional] object JMBBJHIBCGJ);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate GJGLGKBFEKB IABMAJDOJIP();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class CGAPNMHKEGG
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class EJMKGLIIGJC : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static EJMKGLIIGJC IADGMEFIGGI;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8344690", Offset = "0x8343A90", VA = "0x188344690", Slot = "4")]
		public bool Equals(List<string> COBPEJEHIHC, List<string> CEJJJCAALLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x83447E0", Offset = "0x8343BE0", VA = "0x1883447E0", Slot = "5")]
		public int GetHashCode(List<string> KLANNNFBLNB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public EJMKGLIIGJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class DJMBDIKEGGD : JLJMOHNJPKF<HHJAPFEFMOO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8344560", Offset = "0x8343960", VA = "0x188344560", Slot = "9")]
		public override string PEGKBLBFNLH(HHJAPFEFMOO EOMFNMMGCEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8344380", Offset = "0x8343780", VA = "0x188344380", Slot = "10")]
		protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] HHJAPFEFMOO OOEMJLHLIHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8344650", Offset = "0x8343A50", VA = "0x188344650")]
		public DJMBDIKEGGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly IDMCKJCNEHH EHPOOCACCOH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly DJMBDIKEGGD POBFMACPHMC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<LMDOPMIIPLM> HEBNBBFMLAH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<MCGEPIMAEII> CJIGACHMONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<MCGEPIMAEII, LMDOPMIIPLM> DPICNIFPGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8343D20", Offset = "0x8343120", VA = "0x188343D20")]
	public CGAPNMHKEGG([Optional] IList<LMDOPMIIPLM>? JHFGODKEFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8342780", Offset = "0x8341B80", VA = "0x188342780")]
	public LMDOPMIIPLM FBMOLDHJMNK(MCGEPIMAEII JMKNDIFGMNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface ALIIAMMIGLH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IMIDKHMKBGA GNIKKAFGKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class CBJFINMNEMB : ALIIAMMIGLH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static CBJFINMNEMB INGPPKJEIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly JFABEAGEHMF POAOFJJABKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<JFABEAGEHMF> EIJIOGOJOCN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IMIDKHMKBGA GNIKKAFGKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8342670", Offset = "0x8341A70", VA = "0x188342670")]
	public CBJFINMNEMB(JFABEAGEHMF JFENPDAIKCA, IReadOnlyList<JFABEAGEHMF> CEDFAIEFIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8341750", Offset = "0x8340B50", VA = "0x188341750")]
	private static CBJFINMNEMB BJEHPIBFBIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DCAAFCPJKAL
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<JMJBOEJBCPI> DPNDHDLCCDC;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8344070", Offset = "0x8343470", VA = "0x188344070")]
	public static bool HAKAAGFIFKC(this EKIKILMCLIO HANDOEBGAFL, JMJBOEJBCPI HLBEKEOHNEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8344150", Offset = "0x8343550", VA = "0x188344150")]
	public static bool MEDMGDMJCFO(this EKIKILMCLIO HANDOEBGAFL, JMJBOEJBCPI HLBEKEOHNEI, HNAJHGJKLNP LCBJKEIGKLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface EMBMDCOGLFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CCOBKHLJCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool FNIMCIPIDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ADNNIHOJKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool HFONPDBFLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IIFDKGOCKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DFHCMEHBJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool IBCMJCCIMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool NKKGLAAFNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NHPLHEMDHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EFHKONDEJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool PHFLAFDGFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HGBBPAOFCOO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> MAMABOPPFJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HHJAPFEFMOO MMKNBFDJKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IMIDKHMKBGA : EMBMDCOGLFJ, JJPGLEDNJHP, ECPILNEPGLE<MCGEPIMAEII>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string OALKJAJGMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JMJBOEJBCPI AJMJGKFIAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) HFNJOGJCNEG<T>(MCGEPIMAEII JMKNDIFGMNN) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum MCGEPIMAEII
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
internal class JFABEAGEHMF : IMIDKHMKBGA, EMBMDCOGLFJ, JJPGLEDNJHP, ECPILNEPGLE<MCGEPIMAEII>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly CGAPNMHKEGG MKNEFPHFIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly AOJNKHBIJHB KHGKJFEFGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? CLPOIBBIGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? HJNGLADMGAI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool BJICGCKKJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x83472B0", Offset = "0x83466B0", VA = "0x1883472B0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool LICFGNBHMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x83468B0", Offset = "0x8345CB0", VA = "0x1883468B0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool JAMENHJGLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8346DE0", Offset = "0x83461E0", VA = "0x188346DE0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool FNKCPGPJOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8346E80", Offset = "0x8346280", VA = "0x188346E80", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool JLHMALLALIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8347560", Offset = "0x8346960", VA = "0x188347560", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool OLBEKJNKLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8346860", Offset = "0x8345C60", VA = "0x188346860", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public JMJBOEJBCPI AJMJGKFIAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA813E0", Offset = "0xA807E0", VA = "0x180A813E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JMJBOEJBCPI);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9CBEE0", Offset = "0x9CB2E0", VA = "0x1809CBEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string DGKBAEKOCAP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x83473D0", Offset = "0x83467D0", VA = "0x1883473D0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8347260", Offset = "0x8346660", VA = "0x188347260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string OALKJAJGMCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x83473D0", Offset = "0x83467D0", VA = "0x1883473D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool CMAKIOLCKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD4A610", Offset = "0xD49A10", VA = "0x180D4A610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xD4A630", Offset = "0xD49A30", VA = "0x180D4A630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool CCOBKHLJCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8347420", Offset = "0x8346820", VA = "0x188347420", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HHJAPFEFMOO MMKNBFDJKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8347850", Offset = "0x8346C50", VA = "0x188347850", Slot = "20")]
		get
		{
			return default(HHJAPFEFMOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FNIMCIPIDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83482D0", Offset = "0x83476D0", VA = "0x1883482D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool ADNNIHOJKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8347380", Offset = "0x8346780", VA = "0x188347380", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HFONPDBFLEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8346F20", Offset = "0x8346320", VA = "0x188346F20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IIFDKGOCKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8346E30", Offset = "0x8346230", VA = "0x188346E30", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool DFHCMEHBJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8347470", Offset = "0x8346870", VA = "0x188347470", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool IBCMJCCIMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8348370", Offset = "0x8347770", VA = "0x188348370", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool NKKGLAAFNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x83474C0", Offset = "0x83468C0", VA = "0x1883474C0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool NHPLHEMDHPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8347800", Offset = "0x8346C00", VA = "0x188347800", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> MAMABOPPFJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8346990", Offset = "0x8345D90", VA = "0x188346990", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool CGLFLKMKBKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x83472B0", Offset = "0x83466B0", VA = "0x1883472B0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool MGGIILPFEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8347560", Offset = "0x8346960", VA = "0x188347560", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool HLGGLHOJHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x83468B0", Offset = "0x8345CB0", VA = "0x1883468B0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool EFHKONDEJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x83475B0", Offset = "0x83469B0", VA = "0x1883475B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool PHFLAFDGFDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8348320", Offset = "0x8347720", VA = "0x188348320", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool ICCAJNCHJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8346DE0", Offset = "0x83461E0", VA = "0x188346DE0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool HGBBPAOFCOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8346ED0", Offset = "0x83462D0", VA = "0x188346ED0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CAEEOGIKPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8346E80", Offset = "0x8346280", VA = "0x188346E80", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LFCPGEDGGHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8346860", Offset = "0x8345C60", VA = "0x188346860", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event IPILJPDDDAB<MCGEPIMAEII> FHIMIIDIKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x83485C0", Offset = "0x83479C0", VA = "0x1883485C0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8348220", Offset = "0x8347620", VA = "0x188348220", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3750E10", Offset = "0x3750210", VA = "0x183750E10", Slot = "6")]
	public (bool, T?) HFNJOGJCNEG<T>(MCGEPIMAEII JMKNDIFGMNN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3750DB0", Offset = "0x37501B0", VA = "0x183750DB0")]
	public JFABEAGEHMF DKNGCDJFFDF<T>(MCGEPIMAEII JMKNDIFGMNN, bool DMEPAPCCCNF, T OOEMJLHLIHJ) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8348790", Offset = "0x8347B90", VA = "0x188348790")]
	public JFABEAGEHMF(JMJBOEJBCPI HLBEKEOHNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x83487B0", Offset = "0x8347BB0", VA = "0x1883487B0")]
	public JFABEAGEHMF(JMJBOEJBCPI HLBEKEOHNEI, [Optional] string? CLPOIBBIGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8348700", Offset = "0x8347B00", VA = "0x188348700")]
	public JFABEAGEHMF(JFABEAGEHMF NPNFADAAKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x83487D0", Offset = "0x8347BD0", VA = "0x1883487D0")]
	internal JFABEAGEHMF(JMJBOEJBCPI IEEPPJOPPBL, [Optional] string? CLPOIBBIGAP, [Optional] JFABEAGEHMF? NPNFADAAKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8347300", Offset = "0x8346700", VA = "0x188347300")]
	public static CEKMAHGBMDE EOPIPBLLHFC(MCGEPIMAEII JMKNDIFGMNN)
	{
		return default(CEKMAHGBMDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8347600", Offset = "0x8346A00", VA = "0x188347600")]
	public void JDPEGIPNLOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8346F70", Offset = "0x8346370", VA = "0x188346F70")]
	internal JFABEAGEHMF DGJPJOGONDA(JFABEAGEHMF AFMHBNHLCNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x83469F0", Offset = "0x8345DF0", VA = "0x1883469F0")]
	internal IReadOnlyCollection<MCGEPIMAEII> BIOKGNHBAIE(JFABEAGEHMF NPNFADAAKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8347620", Offset = "0x8346A20", VA = "0x188347620")]
	public bool JHAGCNHNMAI(MCGEPIMAEII JMKNDIFGMNN, bool DMEPAPCCCNF, string MKBOJPGHMDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8347700", Offset = "0x8346B00", VA = "0x188347700")]
	public (bool, string) KFONLIINKMC(MCGEPIMAEII JMKNDIFGMNN)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8347510", Offset = "0x8346910", VA = "0x188347510")]
	internal void IEEOHGJDPNM(MCGEPIMAEII JMKNDIFGMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x83483C0", Offset = "0x83477C0", VA = "0x1883483C0")]
	public PBOMEOMHPGF ONPFCMIPIGJ(Func<JMJBOEJBCPI, Guid> MLEEGCMMNKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x83478A0", Offset = "0x8346CA0", VA = "0x1883478A0")]
	public void KPIOBAHIPKN(PBOMEOMHPGF JKBLJBIHILD, Func<Guid, JMJBOEJBCPI> JAOCCPOGNOP, [Optional] JMJBOEJBCPI? IIKKNPHJKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8346900", Offset = "0x8345D00", VA = "0x188346900")]
	[CompilerGenerated]
	private void ANDMBJFJLMB(MCGEPIMAEII EFPCFDLPKAB, EDGIDGGNDJC CLPPFCEGLLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class AMGKCPFDFBB : EMCNCPBBKPI, KBDLPIDDMPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JCJGGCHBEPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public JFABEAGEHMF newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public JCJGGCHBEPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8346830", Offset = "0x8345C30", VA = "0x188346830")]
		internal bool NHPMNNJFDHO(JFABEAGEHMF rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class CGADMJGDOCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public JMJBOEJBCPI roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public CGADMJGDOCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1B68460", Offset = "0x1B67860", VA = "0x181B68460")]
		internal bool EIFPEFFLBDL(JMJBOEJBCPI r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct LOLBMBPGOGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AMGKCPFDFBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public MMIOGOBDHFC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<ALOJCBLEHGG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8348CD0", Offset = "0x83480D0", VA = "0x188348CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8349340", Offset = "0x8348740", VA = "0x188349340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KFADNBNABMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KFADNBNABMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8348930", Offset = "0x8347D30", VA = "0x188348930")]
		internal void CHKBIBEFHMO(PBOMEOMHPGF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8348A10", Offset = "0x8347E10", VA = "0x188348A10")]
		internal void DDMGJCEANED(PBOMEOMHPGF r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct BGIMKHJBJKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public MMIOGOBDHFC roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class ONMEHMIKOLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<PBOMEOMHPGF, EDGIDGGNDJC> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public ONMEHMIKOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8349450", Offset = "0x8348850", VA = "0x188349450")]
		internal void HGGGONAIGOC(PBOMEOMHPGF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8349480", Offset = "0x8348880", VA = "0x188349480")]
		internal void JGOCEJLBGBC(PBOMEOMHPGF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8349420", Offset = "0x8348820", VA = "0x188349420")]
		internal void BIEKHHPACEL(PBOMEOMHPGF r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class JFNGNPPKPGE<T> where T : notnull
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
			public JFNGNPPKPGE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<ALOJCBLEHGG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3F50290", Offset = "0x3F4F690", VA = "0x183F50290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public MCGEPIMAEII rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public JMJBOEJBCPI accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CEKMAHGBMDE recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AMGKCPFDFBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public JFNGNPPKPGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4C8BE40", Offset = "0x4C8B240", VA = "0x184C8BE40")]
		[AsyncStateMachine(typeof(JFNGNPPKPGE<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void DNKIKGJJAPM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct ILEGHOBHDEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<LKPCFELAMKB> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct GEDMBBDCHGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public JLPIHLHPFLF rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public MMIOGOBDHFC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<JMJBOEJBCPI, JFABEAGEHMF> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public IEDDOEABFGN debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x83459C0", Offset = "0x8344DC0", VA = "0x1883459C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x83464E0", Offset = "0x83458E0", VA = "0x1883464E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly JLPIHLHPFLF PABKKJHIGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CBJFINMNEMB LFAGNJLHEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IEDDOEABFGN GKILNJBFBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, JFABEAGEHMF> GFOFEKIKJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<JMJBOEJBCPI, JFABEAGEHMF> NLIEKDDPIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<JMJBOEJBCPI, JFABEAGEHMF> GBLOABALPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<JFABEAGEHMF> FDGFBFNCNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool AMKKPICLNPH;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly MCGEPIMAEII[] LHBJCCEEIAE;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public ALIIAMMIGLH OKGNACECKOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<IMIDKHMKBGA> IFOLGKMBHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x833C660", Offset = "0x833BA60", VA = "0x18833C660", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HHFBOBCDKMN CNHMPIOMFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x833B360", Offset = "0x833A760", VA = "0x18833B360", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x833E2D0", Offset = "0x833D6D0", VA = "0x18833E2D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x833BD90", Offset = "0x833B190", VA = "0x18833BD90")]
	[ACPGCKDGGJH.OGKIIIOLJPE]
	internal static void BIBAMGIFFDO(NPCGGDCACLM MIOIJELPIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8340C20", Offset = "0x8340020", VA = "0x188340C20")]
	[UnityEngine.Scripting.Preserve]
	internal AMGKCPFDFBB([MGCCDFKFGBG(null)] JLPIHLHPFLF GFDFEFGLNDA, [MGCCDFKFGBG(null)] CBJFINMNEMB LFCPEJMLFDI, [MGCCDFKFGBG(null)] IEDDOEABFGN GKILNJBFBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x833C540", Offset = "0x833B940", VA = "0x18833C540", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x833F390", Offset = "0x833E790", VA = "0x18833F390")]
	private void JONFALBCPOE(IEnumerable<JFABEAGEHMF> FMIPLFNJMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x833C6B0", Offset = "0x833BAB0", VA = "0x18833C6B0", Slot = "12")]
	public bool EDPGEMIPMGK(EKIKILMCLIO PCGEDHPAHKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x833C650", Offset = "0x833BA50", VA = "0x18833C650")]
	private void ECMNGGOEDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x833E370", Offset = "0x833D770", VA = "0x18833E370")]
	private void IKEHLACCCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x833B990", Offset = "0x833AD90", VA = "0x18833B990", Slot = "10")]
	public IReadOnlyList<IMIDKHMKBGA> BDDDNFINJIA(bool PBKGEGICMAO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x833C340", Offset = "0x833B740", VA = "0x18833C340", Slot = "11")]
	public IMIDKHMKBGA CJBBAPJNFEJ(EKIKILMCLIO PCGEDHPAHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x833C450", Offset = "0x833B850", VA = "0x18833C450")]
	private JMJBOEJBCPI DHHKOECIAMO(EKIKILMCLIO PCGEDHPAHKB)
	{
		return default(JMJBOEJBCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x833C780", Offset = "0x833BB80", VA = "0x18833C780", Slot = "14")]
	public bool ELEACHPDHMI(EKIKILMCLIO LLJOPDGODFN, JMJBOEJBCPI HLBEKEOHNEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x833BF50", Offset = "0x833B350", VA = "0x18833BF50", Slot = "15")]
	public IMIDKHMKBGA CBBICPGEGHB(JMJBOEJBCPI HLBEKEOHNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x833FF50", Offset = "0x833F350", VA = "0x18833FF50")]
	private static bool MPIJKCAGILD(IONMPGMKDIF PMEFMPPDCHM, JMJBOEJBCPI HLBEKEOHNEI, [Out] PBOMEOMHPGF? AIIOFMJICDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x833BA10", Offset = "0x833AE10", VA = "0x18833BA10")]
	private static void BDIHJHHJPLK(IONMPGMKDIF PMEFMPPDCHM, Action<PBOMEOMHPGF> JAMDLIEBBOP, JMJBOEJBCPI OCFLNPAGIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x833BB00", Offset = "0x833AF00", VA = "0x18833BB00")]
	private static void BDIHJHHJPLK(IONMPGMKDIF PMEFMPPDCHM, Action<PBOMEOMHPGF> JAMDLIEBBOP, Predicate<JMJBOEJBCPI> ONALKNLJEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x833FC20", Offset = "0x833F020", VA = "0x18833FC20")]
	private void KFJDLFIBLNK(EKIKILMCLIO PCGEDHPAHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x833D800", Offset = "0x833CC00", VA = "0x18833D800", Slot = "4")]
	[AsyncStateMachine(typeof(LOLBMBPGOGI))]
	public Task HKEOIAOAJPB([CanBeNull] MMIOGOBDHFC NILNGFKCINL, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
	public void KNANLPCENPP(MMIOGOBDHFC NILNGFKCINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8340710", Offset = "0x833FB10", VA = "0x188340710")]
	private void PICDMALPBEH(IONMPGMKDIF HKFACFGHIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x833D1A0", Offset = "0x833C5A0", VA = "0x18833D1A0")]
	internal static string HGIMCHAPLCK(JLPIHLHPFLF PABKKJHIGIK, MMIOGOBDHFC NILNGFKCINL, IReadOnlyDictionary<JMJBOEJBCPI, JFABEAGEHMF> NLIEKDDPIMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x833E560", Offset = "0x833D960", VA = "0x18833E560")]
	private static void JHIAOLABGHJ(MMIOGOBDHFC NILNGFKCINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x833D4B0", Offset = "0x833C8B0", VA = "0x18833D4B0")]
	private static void HHOAFLBAOJG(IONMPGMKDIF AAPEAGMKIFA, IReadOnlyDictionary<JMJBOEJBCPI, JFABEAGEHMF> NLIEKDDPIMO, StringBuilder EMMOAAGAFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8340280", Offset = "0x833F680", VA = "0x188340280")]
	private static bool NMMKABBCLKM(string BHEKKMKAFGI, [Out] Guid CIPEPBHBJDJ, [Out] JMJBOEJBCPI HLBEKEOHNEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x833CA50", Offset = "0x833BE50", VA = "0x18833CA50")]
	private static void HEPIKNAAMKB(MMIOGOBDHFC NILNGFKCINL, StringBuilder EMMOAAGAFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3E67120", Offset = "0x3E66520", VA = "0x183E67120", Slot = "16")]
	public bool MBGNGPIDAFN<T>(JMJBOEJBCPI HLBEKEOHNEI, MCGEPIMAEII JMKNDIFGMNN, bool DMEPAPCCCNF, T LICDMCPJILC, [Optional] Action NHPFCFCADKB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x833FEC0", Offset = "0x833F2C0", VA = "0x18833FEC0", Slot = "17")]
	public string MNBEGCPEEKN(MCGEPIMAEII JMKNDIFGMNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x833E0C0", Offset = "0x833D4C0", VA = "0x18833E0C0")]
	private void HNHJAMGBOJA(JMJBOEJBCPI HLBEKEOHNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x833C520", Offset = "0x833B920", VA = "0x18833C520")]
	private bool DJCEIHDKKNJ(EKIKILMCLIO PCGEDHPAHKB, JMJBOEJBCPI HLBEKEOHNEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x833BFF0", Offset = "0x833B3F0", VA = "0x18833BFF0")]
	internal JFABEAGEHMF CCFGJMPEGJI(EKIKILMCLIO PCGEDHPAHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x833FF40", Offset = "0x833F340", VA = "0x18833FF40", Slot = "13")]
	public IReadOnlyList<IMIDKHMKBGA> MPIFLPFBODD(EKIKILMCLIO PCGEDHPAHKB, bool GEKBLDAICAN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x833FC90", Offset = "0x833F090", VA = "0x18833FC90")]
	internal IReadOnlyList<JFABEAGEHMF> MHJHHMCHBJB(EKIKILMCLIO PCGEDHPAHKB, bool GEKBLDAICAN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x833D920", Offset = "0x833CD20", VA = "0x18833D920")]
	private void HLDJBLHPJOL(ALOJCBLEHGG BHANGFLFAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x833B400", Offset = "0x833A800", VA = "0x18833B400")]
	private static bool AKDJCDFCICG(JFABEAGEHMF GAOCFNKLEOF, IReadOnlyDictionary<JMJBOEJBCPI, JFABEAGEHMF> NLIEKDDPIMO, [Out] IReadOnlyList<MCGEPIMAEII> KBIBBLDBFEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x833C910", Offset = "0x833BD10", VA = "0x18833C910")]
	[AsyncStateMachine(typeof(GEDMBBDCHGL))]
	private static Task FFBIDKMFFIK(JLPIHLHPFLF PABKKJHIGIK, MMIOGOBDHFC NILNGFKCINL, IReadOnlyDictionary<JMJBOEJBCPI, JFABEAGEHMF> NLIEKDDPIMO, IEDDOEABFGN GKILNJBFBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x833B6F0", Offset = "0x833AAF0", VA = "0x18833B6F0")]
	[CompilerGenerated]
	internal static void ALGGBGLKHPE(Func<PBOMEOMHPGF, EDGIDGGNDJC> ILJDFBNGHOL, BGIMKHJBJKH P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8340390", Offset = "0x833F790", VA = "0x188340390")]
	[CompilerGenerated]
	internal static bool PGFPJNIECOE(JMJBOEJBCPI HLBEKEOHNEI, MCGEPIMAEII JMKNDIFGMNN, [Out] LKPCFELAMKB FLMIOFFJMEA, ILEGHOBHDEN P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface JDHOLGNBCAO
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KLAIPIKIPEI(EKIKILMCLIO PICKKMIAFAP, EKIKILMCLIO COCDAADMIAM, IEnumerable<EKIKILMCLIO> KOMMCJLNADK, [Out] HHJAPFEFMOO GMOMFMPGIJD, [Out] DALCMEHPFBM OKDMALCPOLK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string IEKKGKMMOEJ(DALCMEHPFBM DLFEHLEPJPL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum DALCMEHPFBM : byte
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
internal class EPBPMALNLCF : JDHOLGNBCAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly KBDLPIDDMPP OGLLFJNEJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly GGPHLOLMNFI LKPODJFOADG;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9CD730", Offset = "0x9CCB30", VA = "0x1809CD730")]
	[RecRoom.NoEngine.Common.Preserve]
	public EPBPMALNLCF([MGCCDFKFGBG(null)] KBDLPIDDMPP MGOMEBANOMN, [MGCCDFKFGBG(null)] GGPHLOLMNFI IOAAEBILMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x83449D0", Offset = "0x8343DD0", VA = "0x1883449D0")]
	private static HLFGEEPGPHA? GNOPCNOINKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8345130", Offset = "0x8344530", VA = "0x188345130", Slot = "4")]
	public bool KLAIPIKIPEI(EKIKILMCLIO PICKKMIAFAP, EKIKILMCLIO COCDAADMIAM, IEnumerable<EKIKILMCLIO> KOMMCJLNADK, [Out] HHJAPFEFMOO GMOMFMPGIJD, [Out] DALCMEHPFBM OKDMALCPOLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8345030", Offset = "0x8344430", VA = "0x188345030", Slot = "5")]
	public string IEKKGKMMOEJ(DALCMEHPFBM DLFEHLEPJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8344A10", Offset = "0x8343E10", VA = "0x188344A10")]
	internal bool IBCKIODGIGM(EKIKILMCLIO PICKKMIAFAP, EKIKILMCLIO COCDAADMIAM, IEnumerable<EKIKILMCLIO> KOMMCJLNADK, HNAJHGJKLNP LCBJKEIGKLM, HLFGEEPGPHA? HNKFCFEFLPL, [Out] HHJAPFEFMOO GMOMFMPGIJD, [Out] DALCMEHPFBM OKDMALCPOLK)
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

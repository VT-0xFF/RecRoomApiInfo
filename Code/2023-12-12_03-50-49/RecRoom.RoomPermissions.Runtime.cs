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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x644E6A0", Offset = "0x644CEA0", VA = "0x18644E6A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CD00", Offset = "0x79B500", VA = "0x18079CD00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DHAHCLBNAEE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void FDJHGLNKOOE<TPermission>(TPermission OFEPLFCOAOA);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void ANEJDBLGHLP(PDJKNJCPPID DDADADFKCOE);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DDAGPLKJDBH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EOFNNNFNGOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FMLHMJGLCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool EEENBCCMPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BEFLABPONPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CNFHDDCJCHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OBIIKGKBJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JIBOGKGFGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class AGFKEKMGNOH
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum ILCCFDDKGOD
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
	public static readonly Guid ANGDHIHACEM;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid HHCIBAIFHKL;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid NBCMODHOPPG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid JIEEBCJMBCB;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid OBOEFAFEDMF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid NNAFGBGKELI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly BKLNIGMHCHA<JEENPKBELMH, Guid> MEEFPBKIKGL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<JEENPKBELMH> HHHMLJOJLPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64476D0", Offset = "0x6445ED0", VA = "0x1864476D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6447750", Offset = "0x6445F50", VA = "0x186447750")]
	public static JEENPKBELMH IKLOCLINBJG(Guid CLGOKAHLILM)
	{
		return default(JEENPKBELMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6447510", Offset = "0x6445D10", VA = "0x186447510")]
	public static Guid AALKIBCNGIA(JEENPKBELMH LPABMFHONFN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x64477E0", Offset = "0x6445FE0", VA = "0x1864477E0")]
	public static bool KBMIBJKMPBN(JEENPKBELMH LPABMFHONFN, [Out] Guid CLGOKAHLILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64475F0", Offset = "0x6445DF0", VA = "0x1864475F0")]
	public static bool DCPKPIOFIFH(Guid CLGOKAHLILM, [Out] JEENPKBELMH LPABMFHONFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64475B0", Offset = "0x6445DB0", VA = "0x1864475B0")]
	public static JEENPKBELMH AOKLNLJAGIN(JEENPKBELMH LPABMFHONFN)
	{
		return default(JEENPKBELMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6447870", Offset = "0x6446070", VA = "0x186447870")]
	public static ILCCFDDKGOD KMMJEMBDNOG(JEENPKBELMH PDHCJLPMEKO)
	{
		return default(ILCCFDDKGOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6447690", Offset = "0x6445E90", VA = "0x186447690")]
	internal static JEENPKBELMH HIJFHHCKINK(ILCCFDDKGOD KBGMPDBPAML)
	{
		return default(JEENPKBELMH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CFAALOCOBOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	DGJJMPKDLBP MDFNLMMNJFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<NPLHBNFHGFG> PLIDKLEKABG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ANEJDBLGHLP HHFHMEGENGK;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<NPLHBNFHGFG> HFCFJCLLEJI(bool FFIABMHANIB = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NPLHBNFHGFG IALBEBDNODC(PDJKNJCPPID DDADADFKCOE);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KCNANANKJHL(PDJKNJCPPID DDADADFKCOE);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<NPLHBNFHGFG> HOAMEOHOEFB(PDJKNJCPPID DDADADFKCOE, bool EBKFBLHIOIH = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ADIBDFDJBKL(PDJKNJCPPID OFAEJNGNAON, JEENPKBELMH LPABMFHONFN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NPLHBNFHGFG AMFBHKMOGDI(JEENPKBELMH LPABMFHONFN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FPJHHBILCBF<T>(JEENPKBELMH LPABMFHONFN, KBBIIMGGCIM OFEPLFCOAOA, bool ELLLCEMHFIO, T AKIAGKECAIA) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FNEGLKKLIFH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MLBKFFBMLCI(IJMHNDANHLN HCADKDIKPMA, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGJLOBHPOFM(IJMHNDANHLN HCADKDIKPMA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NMNDLHPLKIH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PDJKNJCPPID BDBPKPKNPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MPLKHMAMHAD HKMBNOMAFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IKGFEJPGNIE JONLPDEFLCG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<EPCLCGMOMLF> OCFDOMHBKLJ;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OCBCFJANPHN;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JEENPKBELMH HMPBKHOGKLO(PDJKNJCPPID DDADADFKCOE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<EPCLCGMOMLF> KMDDFLGFOGN(CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MKFCBEDCFJH(long AKDANPAICOC, long NOJFBKAHMKA, IReadOnlyList<AKKFDNCELCA> FNEKIIKHBEG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<PDJKNJCPPID> DKAHHJMCJCG();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EEGDGLDIEIA
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6448FE0", Offset = "0x64477E0", VA = "0x186448FE0")]
	public static JEENPKBELMH HCAIDIHDEEK(this NMNDLHPLKIH KIEIJPLCJOJ)
	{
		return default(JEENPKBELMH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JLEIFIEKEEM<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string FPBNGHPMGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FDJHGLNKOOE<TPermission> CJKDFPENIPD;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class GCCMHIOAJBP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? JJCCNENHFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	protected GCCMHIOAJBP(object? DDPAJEDOCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool LLKOMIADMLM(object? DOLICEBFIPF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class GNKPCECKPFH<T> : GCCMHIOAJBP where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T MDOEKMBFPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> LPAEICJJCCK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T HMHFMLFLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F30", Offset = "0x7F5730", VA = "0x1807F6F30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3533A00", Offset = "0x3532200", VA = "0x183533A00", Slot = "4")]
	public override bool LLKOMIADMLM(object? DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3533600", Offset = "0x3531E00", VA = "0x183533600")]
	public bool HBNHGLPIGDD(T IAONCJKFCOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3533B00", Offset = "0x3532300", VA = "0x183533B00")]
	public GNKPCECKPFH(T OGJIDOCEOED, IEqualityComparer<T> LPAEICJJCCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class CDFCLGMDAEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<KBBIIMGGCIM, bool> BHALOFNOAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<KBBIIMGGCIM, GCCMHIOAJBP> BMOIIGLCBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HLEFKKOLOIJ LFBCNKIPAEM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x64481C0", Offset = "0x64469C0", VA = "0x1864481C0")]
	public CDFCLGMDAEJ(HLEFKKOLOIJ LFBCNKIPAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6447DA0", Offset = "0x64465A0", VA = "0x186447DA0")]
	public bool HKBFGCJHDDL(KBBIIMGGCIM OFEPLFCOAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2329410", Offset = "0x2327C10", VA = "0x182329410")]
	public bool KNBKCKIHMLF<T>(KBBIIMGGCIM OFEPLFCOAOA, bool ELLLCEMHFIO, T DOLICEBFIPF) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2329000", Offset = "0x2327800", VA = "0x182329000")]
	public (bool, T?) BHNCAPEAJBG<T>(KBBIIMGGCIM OFEPLFCOAOA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6447EE0", Offset = "0x64466E0", VA = "0x186447EE0")]
	public bool KNBKCKIHMLF(KBBIIMGGCIM OFEPLFCOAOA, bool ELLLCEMHFIO, object DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6447CD0", Offset = "0x64464D0", VA = "0x186447CD0")]
	public (bool, object) BHNCAPEAJBG(KBBIIMGGCIM OFEPLFCOAOA)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x23293D0", Offset = "0x2327BD0", VA = "0x1823293D0")]
	private void FIPCLHBFLMD<T>(KBBIIMGGCIM OFEPLFCOAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6447E10", Offset = "0x6446610", VA = "0x186447E10")]
	private GCCMHIOAJBP JOFEDCNEGGP(KBBIIMGGCIM OFEPLFCOAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6447FC0", Offset = "0x64467C0", VA = "0x186447FC0")]
	public void NPHNEALIHOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class PLODMEMNMOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string EMOKHLCDPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type DCANPKLEHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly NMBIONGKNOE LBODGMDIJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KBBIIMGGCIM DPJOLHHCNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MJHMNPEKDND HFOBKHGGKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public IENHOFKECOH IPCCLKJPHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public HBCMHFFOPDP EMDIFOKPFIF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x64545F0", Offset = "0x6452DF0", VA = "0x1864545F0")]
	public PLODMEMNMOC(Type BDEHFOGLODE, string KCFCPAIFOFP, KBBIIMGGCIM OFEPLFCOAOA, MJHMNPEKDND ACPAOEICDCK, IENHOFKECOH HCJAIHNHAPG, HBCMHFFOPDP IOLMBPDAGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x64545A0", Offset = "0x6452DA0", VA = "0x1864545A0")]
	public object HMAOFLALLOC(object? FPJCFKAMJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2659B10", Offset = "0x2658310", VA = "0x182659B10")]
	public void FIPCLHBFLMD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x64544F0", Offset = "0x6452CF0", VA = "0x1864544F0")]
	public void FIPCLHBFLMD(Type MPGICNJLCBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class OMPCOINAANJ<T> : PLODMEMNMOC where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string HHCKBPDOGOA(T DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T MONFEPKOIED(string? CINBLJGLMAA, T OGJIDOCEOED);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CPFOGNOABGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HHCKBPDOGOA serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MONFEPKOIED parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public CPFOGNOABGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4A9CB10", Offset = "0x4A9B310", VA = "0x184A9CB10")]
		internal string KBIKAAMEJFK(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4A9CB40", Offset = "0x4A9B340", VA = "0x184A9CB40")]
		internal object LJNHPGHCPDC(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E900", Offset = "0x3E3D100", VA = "0x183E3E900")]
	public OMPCOINAANJ(KBBIIMGGCIM OFEPLFCOAOA, string KCFCPAIFOFP, [Optional] HHCKBPDOGOA? ACPAOEICDCK, [Optional] MONFEPKOIED? HCJAIHNHAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D800", Offset = "0x3E3C000", VA = "0x183E3D800")]
	private static object? AEDPLFCAHJC(MONFEPKOIED? HCJAIHNHAPG, string? CINBLJGLMAA, object? OGJIDOCEOED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E060", Offset = "0x3E3C860", VA = "0x183E3E060")]
	private static string JMOOMJHDBEG(HHCKBPDOGOA? DMFHEJPABKC, object? DOLICEBFIPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string MJHMNPEKDND(object? DOLICEBFIPF);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object IENHOFKECOH(string? CINBLJGLMAA, [Optional] object OGJIDOCEOED);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate GCCMHIOAJBP HBCMHFFOPDP();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class HLEFKKOLOIJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class PHCCIJBNJIL : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static PHCCIJBNJIL ODCBNHJKAMO;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64541B0", Offset = "0x64529B0", VA = "0x1864541B0", Slot = "4")]
		public bool Equals(List<string> GJPJIELLCID, List<string> HBNKALMNLPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6454300", Offset = "0x6452B00", VA = "0x186454300", Slot = "5")]
		public int GetHashCode(List<string> BEKFGDCEJDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public PHCCIJBNJIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class DMHLOJFNMBJ : KLKLOHKPECF<DHAHCLBNAEE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6448EB0", Offset = "0x64476B0", VA = "0x186448EB0", Slot = "9")]
		public override string JMOOMJHDBEG(DHAHCLBNAEE LLJFBBILFIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6448CD0", Offset = "0x64474D0", VA = "0x186448CD0", Slot = "10")]
		protected override bool EJKMNGAGOLL(string LLJFBBILFIJ, [Out] DHAHCLBNAEE DOLICEBFIPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6448FA0", Offset = "0x64477A0", VA = "0x186448FA0")]
		public DMHLOJFNMBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly AOBDAFGPMEE ODFCHECHIGJ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly DMHLOJFNMBJ DCLOIMNNDHH;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<PLODMEMNMOC> OANMPGHJGJC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<KBBIIMGGCIM> DJMJLNEPCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<KBBIIMGGCIM, PLODMEMNMOC> CLLLAJEPLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x644AC50", Offset = "0x6449450", VA = "0x18644AC50")]
	public HLEFKKOLOIJ([Optional] IList<PLODMEMNMOC>? AKNEHIBKOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6449DE0", Offset = "0x64485E0", VA = "0x186449DE0")]
	public PLODMEMNMOC IAGKAMDOGLF(KBBIIMGGCIM OFEPLFCOAOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DGJJMPKDLBP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NPLHBNFHGFG BNDENLBEMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class MMJJMMOAAKD : DGJJMPKDLBP
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static MMJJMMOAAKD CGLKGNNLBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly MBJHOABJMKJ AOGENANPELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<MBJHOABJMKJ> ILCCEPJCAGJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NPLHBNFHGFG BNDENLBEMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x644E580", Offset = "0x644CD80", VA = "0x18644E580")]
	public MMJJMMOAAKD(MBJHOABJMKJ OFPMINGFFNN, IReadOnlyList<MBJHOABJMKJ> FEMLGLLPLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x644DB50", Offset = "0x644C350", VA = "0x18644DB50")]
	private static MMJJMMOAAKD DAIAMJBBJCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LELAMPBAJEE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<JEENPKBELMH> GLIPLPFAGED;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x644AFA0", Offset = "0x64497A0", VA = "0x18644AFA0")]
	public static bool CDMNGDEFFIA(this PDJKNJCPPID MNBNFIINGLG, JEENPKBELMH LPABMFHONFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x644B080", Offset = "0x6449880", VA = "0x18644B080")]
	public static bool IILOKBAHDDN(this PDJKNJCPPID MNBNFIINGLG, JEENPKBELMH LPABMFHONFN, IKGFEJPGNIE AHIPEEBEEBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface KIJINGGJNAP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool IKNNNGOPHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool DNFCNDCMMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool NGOGFCOIBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PNPFDEKDLJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool NAGIELPHCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DPIAPHNPDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool FEKIMCHLHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool OOIBPEJFCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool DBCOKKGIKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool CIICEDIBNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool KBEHJJPCKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool ACLBKMOBMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> BEMMOBPGBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DHAHCLBNAEE CIDIJAKHDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NPLHBNFHGFG : KIJINGGJNAP, EOFNNNFNGOD, JLEIFIEKEEM<KBBIIMGGCIM>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string EDCDGMNKCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JEENPKBELMH KCNLEIOEKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) HJDNCBEKFPF<T>(KBBIIMGGCIM OFEPLFCOAOA) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KBBIIMGGCIM
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
internal class MBJHOABJMKJ : NPLHBNFHGFG, KIJINGGJNAP, EOFNNNFNGOD, JLEIFIEKEEM<KBBIIMGGCIM>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly HLEFKKOLOIJ EJNEGENIFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly CDFCLGMDAEJ LGFFJJOBBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? KJLNDHFCGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? JKHFJNAJDCF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool KBMPEFCJOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x644C670", Offset = "0x644AE70", VA = "0x18644C670", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool FDJHKNNIMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x644C480", Offset = "0x644AC80", VA = "0x18644C480", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool OIAHIEGINCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x644C530", Offset = "0x644AD30", VA = "0x18644C530", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool OFNLPAAHPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x644BE10", Offset = "0x644A610", VA = "0x18644BE10", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool FBIDFMPOIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x644B970", Offset = "0x644A170", VA = "0x18644B970", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool ICDOOMMBNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x644C880", Offset = "0x644B080", VA = "0x18644C880", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public JEENPKBELMH KCNLEIOEKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F30", Offset = "0x7F5730", VA = "0x1807F6F30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JEENPKBELMH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x775870", Offset = "0x774070", VA = "0x180775870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string FPBNGHPMGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x644D840", Offset = "0x644C040", VA = "0x18644D840", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x644CA10", Offset = "0x644B210", VA = "0x18644CA10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string EDCDGMNKCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x644D840", Offset = "0x644C040", VA = "0x18644D840", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool DIGBOABEDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x859070", Offset = "0x857870", VA = "0x180859070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x858D20", Offset = "0x857520", VA = "0x180858D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool IKNNNGOPHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x644C920", Offset = "0x644B120", VA = "0x18644C920", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public DHAHCLBNAEE CIDIJAKHDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x644C5D0", Offset = "0x644ADD0", VA = "0x18644C5D0", Slot = "20")]
		get
		{
			return default(DHAHCLBNAEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DNFCNDCMMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x644CE20", Offset = "0x644B620", VA = "0x18644CE20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool NGOGFCOIBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x644CE70", Offset = "0x644B670", VA = "0x18644CE70", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PNPFDEKDLJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x644C8D0", Offset = "0x644B0D0", VA = "0x18644C8D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool NAGIELPHCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x644CB00", Offset = "0x644B300", VA = "0x18644CB00", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool DPIAPHNPDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x644CA60", Offset = "0x644B260", VA = "0x18644CA60", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool FEKIMCHLHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x644C9C0", Offset = "0x644B1C0", VA = "0x18644C9C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool OOIBPEJFCON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x644C970", Offset = "0x644B170", VA = "0x18644C970", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool DBCOKKGIKHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x644C580", Offset = "0x644AD80", VA = "0x18644C580", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> BEMMOBPGBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x644C4D0", Offset = "0x644ACD0", VA = "0x18644C4D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool MLIGIMAHDFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x644C670", Offset = "0x644AE70", VA = "0x18644C670", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool POJAHDABKMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x644B970", Offset = "0x644A170", VA = "0x18644B970", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool OCGOHNCPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x644C480", Offset = "0x644AC80", VA = "0x18644C480", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool CIICEDIBNLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x644C830", Offset = "0x644B030", VA = "0x18644C830", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KBEHJJPCKEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x644C620", Offset = "0x644AE20", VA = "0x18644C620", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool OLJIOPNFJLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x644C530", Offset = "0x644AD30", VA = "0x18644C530", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool ACLBKMOBMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x644B9C0", Offset = "0x644A1C0", VA = "0x18644B9C0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FLAHJMNKKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x644BE10", Offset = "0x644A610", VA = "0x18644BE10", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool AIOMNEKMBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x644C880", Offset = "0x644B080", VA = "0x18644C880", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FDJHGLNKOOE<KBBIIMGGCIM> CJKDFPENIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x644CD70", Offset = "0x644B570", VA = "0x18644CD70", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x644C2D0", Offset = "0x644AAD0", VA = "0x18644C2D0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x258F260", Offset = "0x258DA60", VA = "0x18258F260", Slot = "6")]
	public (bool, T?) HJDNCBEKFPF<T>(KBBIIMGGCIM OFEPLFCOAOA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x258F3F0", Offset = "0x258DBF0", VA = "0x18258F3F0")]
	public MBJHOABJMKJ IEOOMJNPLAA<T>(KBBIIMGGCIM OFEPLFCOAOA, bool ELLLCEMHFIO, T DOLICEBFIPF) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x644D920", Offset = "0x644C120", VA = "0x18644D920")]
	public MBJHOABJMKJ(JEENPKBELMH LPABMFHONFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x644D9D0", Offset = "0x644C1D0", VA = "0x18644D9D0")]
	public MBJHOABJMKJ(JEENPKBELMH LPABMFHONFN, [Optional] string? KJLNDHFCGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x644D940", Offset = "0x644C140", VA = "0x18644D940")]
	public MBJHOABJMKJ(MBJHOABJMKJ OMFNNEMJKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x644D9F0", Offset = "0x644C1F0", VA = "0x18644D9F0")]
	internal MBJHOABJMKJ(JEENPKBELMH JDEHJBDAKBF, [Optional] string? KJLNDHFCGPF, [Optional] MBJHOABJMKJ? OMFNNEMJKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x644BD90", Offset = "0x644A590", VA = "0x18644BD90")]
	public static NMBIONGKNOE BEEGMIEGEFE(KBBIIMGGCIM OFEPLFCOAOA)
	{
		return default(NMBIONGKNOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x644CD50", Offset = "0x644B550", VA = "0x18644CD50")]
	public void NPHNEALIHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x644BA10", Offset = "0x644A210", VA = "0x18644BA10")]
	internal MBJHOABJMKJ AJBBIABDJEF(MBJHOABJMKJ ECCJOAKKHBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x644BE60", Offset = "0x644A660", VA = "0x18644BE60")]
	internal IReadOnlyCollection<KBBIIMGGCIM> CCKDHKOCCGB(MBJHOABJMKJ OMFNNEMJKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x644C750", Offset = "0x644AF50", VA = "0x18644C750")]
	public bool IKDPIOBJNCO(KBBIIMGGCIM OFEPLFCOAOA, bool ELLLCEMHFIO, string FEINPNOGILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x644C380", Offset = "0x644AB80", VA = "0x18644C380")]
	public (bool, string) CKNMLDHJBBF(KBBIIMGGCIM OFEPLFCOAOA)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x644CAB0", Offset = "0x644B2B0", VA = "0x18644CAB0")]
	internal void LPCHEICIGCE(KBBIIMGGCIM OFEPLFCOAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x644CB50", Offset = "0x644B350", VA = "0x18644CB50")]
	public CODEAMKFFJB MFFINAGGPGN(Func<JEENPKBELMH, Guid> AMPLGBGOKJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x644CEC0", Offset = "0x644B6C0", VA = "0x18644CEC0")]
	public void OOHDHCOLONG(CODEAMKFFJB HBAJKAPGNAK, Func<Guid, JEENPKBELMH> FNIPNPHACAH, [Optional] JEENPKBELMH? GAIJDPMONKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x644C6C0", Offset = "0x644AEC0", VA = "0x18644C6C0")]
	[CompilerGenerated]
	private void IDLIFPKMHMJ(KBBIIMGGCIM EKGOFJLJNKG, LHFLFDFDAAG GAFNLDGCDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OELFOAADMHO : FNEGLKKLIFH, CFAALOCOBOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class ENCDMPHNPCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public MBJHOABJMKJ newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public ENCDMPHNPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6449040", Offset = "0x6447840", VA = "0x186449040")]
		internal bool DBNMJFFBFII(MBJHOABJMKJ rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MOMNDBHILAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public JEENPKBELMH roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public MOMNDBHILAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x644E690", Offset = "0x644CE90", VA = "0x18644E690")]
		internal bool HEJABCKKABA(JEENPKBELMH r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct LHAFHBLBKKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public OELFOAADMHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IJMHNDANHLN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<EPCLCGMOMLF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x644B2B0", Offset = "0x6449AB0", VA = "0x18644B2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x644B910", Offset = "0x644A110", VA = "0x18644B910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EOEGIEIKHNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public EOEGIEIKHNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6449190", Offset = "0x6447990", VA = "0x186449190")]
		internal void DLCBCHFBCOA(CODEAMKFFJB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6449070", Offset = "0x6447870", VA = "0x186449070")]
		internal void BGGKMPKLKLK(CODEAMKFFJB r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct EKMCBHOPAHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public IJMHNDANHLN roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class AKKMFMPNOEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CODEAMKFFJB, LHFLFDFDAAG> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public AKKMFMPNOEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6447C70", Offset = "0x6446470", VA = "0x186447C70")]
		internal void FAFIAAAGNKC(CODEAMKFFJB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6447CA0", Offset = "0x64464A0", VA = "0x186447CA0")]
		internal void NGLHGNPBNDD(CODEAMKFFJB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6447C40", Offset = "0x6446440", VA = "0x186447C40")]
		internal void AOAPHPNJMMA(CODEAMKFFJB r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class ALJKMBAKKEL<T> where T : notnull
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
			public ALJKMBAKKEL<T> <>4__this;

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
			private TaskAwaiter<EPCLCGMOMLF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2F72E50", Offset = "0x2F71650", VA = "0x182F72E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7EDD10", Offset = "0x7EC510", VA = "0x1807EDD10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public OELFOAADMHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KBBIIMGGCIM rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public JEENPKBELMH accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public NMBIONGKNOE recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public ALJKMBAKKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3660BD0", Offset = "0x365F3D0", VA = "0x183660BD0")]
		[AsyncStateMachine(typeof(ALJKMBAKKEL<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void HBDEDDALNND()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct EEBBMOIBCAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<AKKFDNCELCA> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct FGEHLKJJHLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public NMNDLHPLKIH rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IJMHNDANHLN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<JEENPKBELMH, MBJHOABJMKJ> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public NALNLDCPMEL debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6449270", Offset = "0x6447A70", VA = "0x186449270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6449D80", Offset = "0x6448580", VA = "0x186449D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly NMNDLHPLKIH KIEIJPLCJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly MMJJMMOAAKD BAEGCELPGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NALNLDCPMEL PJBAMFAKMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, MBJHOABJMKJ> PKFDEBAENOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<JEENPKBELMH, MBJHOABJMKJ> HNMIKDGNKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<JEENPKBELMH, MBJHOABJMKJ> CFIDLJEGMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<MBJHOABJMKJ> JAANGDCADIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool FOOAEPMCGFO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly KBBIIMGGCIM[] IHCKLLPHMIL;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public DGJJMPKDLBP MDFNLMMNJFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<NPLHBNFHGFG> PLIDKLEKABG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6451470", Offset = "0x644FC70", VA = "0x186451470", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event ANEJDBLGHLP HHFHMEGENGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x644EA90", Offset = "0x644D290", VA = "0x18644EA90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6451090", Offset = "0x644F890", VA = "0x186451090", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6450ED0", Offset = "0x644F6D0", VA = "0x186450ED0")]
	[IOOPNJKFHOG(JJAMOFEKMEH.Room, FICJCHGEBPC.None)]
	private static void IEHGJHACKNO(PHIPPCBHDOE OFJPADAKEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6453EF0", Offset = "0x64526F0", VA = "0x186453EF0")]
	[UnityEngine.Scripting.Preserve]
	internal OELFOAADMHO([NBBCAEDCKMG(null)] NMNDLHPLKIH CMCAHCAKJLE, [NBBCAEDCKMG(null)] MMJJMMOAAKD PFMBBFOPLCM, [NBBCAEDCKMG(null)] NALNLDCPMEL PJBAMFAKMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6450290", Offset = "0x644EA90", VA = "0x186450290", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6452160", Offset = "0x6450960", VA = "0x186452160")]
	private void MECBNMHFKOK(IEnumerable<MBJHOABJMKJ> NLKKPDMABJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x64514C0", Offset = "0x644FCC0", VA = "0x1864514C0", Slot = "12")]
	public bool KCNANANKJHL(PDJKNJCPPID DDADADFKCOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6453700", Offset = "0x6451F00", VA = "0x186453700")]
	private void OCBCFJANPHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6453710", Offset = "0x6451F10", VA = "0x186453710")]
	private void OGNOPPPHEMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x64509C0", Offset = "0x644F1C0", VA = "0x1864509C0", Slot = "10")]
	public IReadOnlyList<NPLHBNFHGFG> HFCFJCLLEJI(bool FFIABMHANIB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6450A50", Offset = "0x644F250", VA = "0x186450A50", Slot = "11")]
	public NPLHBNFHGFG IALBEBDNODC(PDJKNJCPPID DDADADFKCOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x64535C0", Offset = "0x6451DC0", VA = "0x1864535C0")]
	private JEENPKBELMH NINPDPLCJCJ(PDJKNJCPPID DDADADFKCOE)
	{
		return default(JEENPKBELMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x644E720", Offset = "0x644CF20", VA = "0x18644E720", Slot = "14")]
	public bool ADIBDFDJBKL(PDJKNJCPPID OFAEJNGNAON, JEENPKBELMH LPABMFHONFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x644E9F0", Offset = "0x644D1F0", VA = "0x18644E9F0", Slot = "15")]
	public NPLHBNFHGFG AMFBHKMOGDI(JEENPKBELMH LPABMFHONFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6453290", Offset = "0x6451A90", VA = "0x186453290")]
	private static bool NCIPJHAKKAN(GIPBHFIIHCK INKGDLNLGBD, JEENPKBELMH LPABMFHONFN, [Out] CODEAMKFFJB? BJJEIOLHNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6450630", Offset = "0x644EE30", VA = "0x186450630")]
	private static void FMBKIEJCLGG(GIPBHFIIHCK INKGDLNLGBD, Action<CODEAMKFFJB> LMFLCNJAOCM, JEENPKBELMH NBMLHGCAJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x64503A0", Offset = "0x644EBA0", VA = "0x1864503A0")]
	private static void FMBKIEJCLGG(GIPBHFIIHCK INKGDLNLGBD, Action<CODEAMKFFJB> LMFLCNJAOCM, Predicate<JEENPKBELMH> HHKKPJOGCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6453690", Offset = "0x6451E90", VA = "0x186453690")]
	private void NKHHKOGCPKJ(PDJKNJCPPID DDADADFKCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6453170", Offset = "0x6451970", VA = "0x186453170", Slot = "4")]
	[AsyncStateMachine(typeof(LHAFHBLBKKD))]
	public Task MLBKFFBMLCI([CanBeNull] IJMHNDANHLN HCADKDIKPMA, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
	public void IGJLOBHPOFM(IJMHNDANHLN HCADKDIKPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6451130", Offset = "0x644F930", VA = "0x186451130")]
	private void IOJDNENFHHN(GIPBHFIIHCK PGHDMMCDICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6451590", Offset = "0x644FD90", VA = "0x186451590")]
	internal static string KJJOHIAGNEA(NMNDLHPLKIH KIEIJPLCJOJ, IJMHNDANHLN HCADKDIKPMA, IReadOnlyDictionary<JEENPKBELMH, MBJHOABJMKJ> HNMIKDGNKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x644EB30", Offset = "0x644D330", VA = "0x18644EB30")]
	private static void CBFBJLHBKCL(IJMHNDANHLN HCADKDIKPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6451BE0", Offset = "0x64503E0", VA = "0x186451BE0")]
	private static void KPOHFMBBFDH(GIPBHFIIHCK BNKBGOKGDPI, IReadOnlyDictionary<JEENPKBELMH, MBJHOABJMKJ> HNMIKDGNKEL, StringBuilder IGEGOKKIEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6453C10", Offset = "0x6452410", VA = "0x186453C10")]
	private static bool PKMIBIACFAK(string HLLFEKOFJCE, [Out] Guid MAHGNGOLHDP, [Out] JEENPKBELMH LPABMFHONFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x644FB50", Offset = "0x644E350", VA = "0x18644FB50")]
	private static void COPOJFICBKO(IJMHNDANHLN HCADKDIKPMA, StringBuilder IGEGOKKIEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2649480", Offset = "0x2647C80", VA = "0x182649480", Slot = "16")]
	public bool FPJHHBILCBF<T>(JEENPKBELMH LPABMFHONFN, KBBIIMGGCIM OFEPLFCOAOA, bool ELLLCEMHFIO, T AKIAGKECAIA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x644F940", Offset = "0x644E140", VA = "0x18644F940")]
	private void CEDBEEHKDLJ(JEENPKBELMH LPABMFHONFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6453BF0", Offset = "0x64523F0", VA = "0x186453BF0")]
	private bool PDFMLACHDMJ(PDJKNJCPPID DDADADFKCOE, JEENPKBELMH LPABMFHONFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6451890", Offset = "0x6450090", VA = "0x186451890")]
	internal MBJHOABJMKJ KKFDHAJEOND(PDJKNJCPPID DDADADFKCOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6450A40", Offset = "0x644F240", VA = "0x186450A40", Slot = "13")]
	public IReadOnlyList<NPLHBNFHGFG> HOAMEOHOEFB(PDJKNJCPPID DDADADFKCOE, bool EBKFBLHIOIH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6451F30", Offset = "0x6450730", VA = "0x186451F30")]
	internal IReadOnlyList<MBJHOABJMKJ> MDHEGOIKENL(PDJKNJCPPID DDADADFKCOE, bool EBKFBLHIOIH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x64529E0", Offset = "0x64511E0", VA = "0x1864529E0")]
	private void MEKDCIADLDN(EPCLCGMOMLF JJPPAECGFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6453900", Offset = "0x6452100", VA = "0x186453900")]
	private static bool PABJHDOLIHI(MBJHOABJMKJ PNFJMHHAJKA, IReadOnlyDictionary<JEENPKBELMH, MBJHOABJMKJ> HNMIKDGNKEL, [Out] IReadOnlyList<KBBIIMGGCIM> EPMCMLACLGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x644E8B0", Offset = "0x644D0B0", VA = "0x18644E8B0")]
	[AsyncStateMachine(typeof(FGEHLKJJHLA))]
	private static Task AMAIDAOALOK(NMNDLHPLKIH KIEIJPLCJOJ, IJMHNDANHLN HCADKDIKPMA, IReadOnlyDictionary<JEENPKBELMH, MBJHOABJMKJ> HNMIKDGNKEL, NALNLDCPMEL PJBAMFAKMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6450720", Offset = "0x644EF20", VA = "0x186450720")]
	[CompilerGenerated]
	internal static void HAMOFICOHMC(Func<CODEAMKFFJB, LHFLFDFDAAG> COFDJKGEHKN, EKMCBHOPAHI P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6450B60", Offset = "0x644F360", VA = "0x186450B60")]
	[CompilerGenerated]
	internal static bool ICBOAEJMNJN(JEENPKBELMH LPABMFHONFN, KBBIIMGGCIM OFEPLFCOAOA, [Out] AKKFDNCELCA OALDJIKINIO, EEBBMOIBCAD P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NNNHCKKNOKD
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOEAFHGMFPD(PDJKNJCPPID MFIAANNBJII, PDJKNJCPPID NDPHGPNCEDG, IEnumerable<PDJKNJCPPID> BLGJJPPHJAL, [Out] DHAHCLBNAEE EOKCGCCDJKN, [Out] PCKKHHIOBJB JMLHMNIEHKM);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string EMLJPFFAPEK(PCKKHHIOBJB HHBCGCLONJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum PCKKHHIOBJB : byte
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
internal class DLFHNICOKMF : NNNHCKKNOKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly CFAALOCOBOB AJHELBGBGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly GKMEKIONPCF CBKHIMNFLIN;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x77D5B0", Offset = "0x77BDB0", VA = "0x18077D5B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DLFHNICOKMF([NBBCAEDCKMG(null)] CFAALOCOBOB ONPHNMOCFIF, [NBBCAEDCKMG(null)] GKMEKIONPCF APOFMANPBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6448C90", Offset = "0x6447490", VA = "0x186448C90")]
	private static JMMIODLHIMN? PHLDCNCPDEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6448470", Offset = "0x6446C70", VA = "0x186448470", Slot = "4")]
	public bool AOEAFHGMFPD(PDJKNJCPPID MFIAANNBJII, PDJKNJCPPID NDPHGPNCEDG, IEnumerable<PDJKNJCPPID> BLGJJPPHJAL, [Out] DHAHCLBNAEE EOKCGCCDJKN, [Out] PCKKHHIOBJB JMLHMNIEHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6448B90", Offset = "0x6447390", VA = "0x186448B90", Slot = "5")]
	public string EMLJPFFAPEK(PCKKHHIOBJB HHBCGCLONJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6448570", Offset = "0x6446D70", VA = "0x186448570")]
	internal bool DPNLAMOFODA(PDJKNJCPPID MFIAANNBJII, PDJKNJCPPID NDPHGPNCEDG, IEnumerable<PDJKNJCPPID> BLGJJPPHJAL, IKGFEJPGNIE AHIPEEBEEBE, JMMIODLHIMN? KBKIKHJNCEE, [Out] DHAHCLBNAEE EOKCGCCDJKN, [Out] PCKKHHIOBJB JMLHMNIEHKM)
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

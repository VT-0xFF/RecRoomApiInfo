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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x869C050", Offset = "0x869AC50", VA = "0x18869C050")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum AHHGMMJOKCP
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
		[Cpp2IlInjected.Address(RVA = "0x869D290", Offset = "0x869BE90", VA = "0x18869D290", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void ELJBACCKLEM<TPermission>(TPermission PMNLAKKLOLA);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void LEJOFPEKPOH(BJCCECIKIFB NEOGODNGJJE);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JNEAGOKCAAM
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IPBADKEJGLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MCPNDEINIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DOEOIIMFBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KAOBAFDCBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DBKKPBNIKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ABHDJBDNKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KHLMCCBLBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class DJJDIJPJJAA
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum ANOEJFBNNAK
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
	public static readonly Guid MINIDLGEKBH;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid PIINPLHLDOH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid PJDMFODLHOA;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid JLLIBEFEPML;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid FOIEFMHMIOJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid PAIMAOPEIFE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly INGCHEDHPMH<KPJEMKAIFIO, Guid> OBLGKJKCCFK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<KPJEMKAIFIO> CLBEPEIPBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86947A0", Offset = "0x86933A0", VA = "0x1886947A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8694540", Offset = "0x8693140", VA = "0x188694540")]
	public static KPJEMKAIFIO GMHKOHKDEGM(Guid LHECJJHBNHF)
	{
		return default(KPJEMKAIFIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x86944A0", Offset = "0x86930A0", VA = "0x1886944A0")]
	public static Guid DGEAGLFKEDB(KPJEMKAIFIO EGKHAMHPNFJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8694410", Offset = "0x8693010", VA = "0x188694410")]
	public static bool DALDAPBANDC(KPJEMKAIFIO EGKHAMHPNFJ, [Out] Guid LHECJJHBNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x86945D0", Offset = "0x86931D0", VA = "0x1886945D0")]
	public static bool HCGOGKHINKJ(Guid LHECJJHBNHF, [Out] KPJEMKAIFIO EGKHAMHPNFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8694670", Offset = "0x8693270", VA = "0x188694670")]
	public static KPJEMKAIFIO IDLPKJFODEE(KPJEMKAIFIO EGKHAMHPNFJ)
	{
		return default(KPJEMKAIFIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x86946B0", Offset = "0x86932B0", VA = "0x1886946B0")]
	public static ANOEJFBNNAK LDIILOFIGOB(KPJEMKAIFIO BJNNMBGKPCO)
	{
		return default(ANOEJFBNNAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8694760", Offset = "0x8693360", VA = "0x188694760")]
	internal static KPJEMKAIFIO NBCGLIFLMJA(ANOEJFBNNAK KMDMKABEHIA)
	{
		return default(KPJEMKAIFIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PILHBOHAGEH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BJCCECIKIFB PPMLHENPPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FJAIPDANBOO CMAGOEIHGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	KINJLHLHADG BBCCIEDHHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KEFBCAHLMFC> LJHEGDNMKKF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HEHHMEAJFFK;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KPJEMKAIFIO FGIOCKNPNOE(BJCCECIKIFB NEOGODNGJJE);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KEFBCAHLMFC> EABAKDOIADK(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BEBLIFGMBBF(long JKJNCHGDMGL, IReadOnlyList<AECJBGKCCJM> FBCBBNDNDCE);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task EHEPHILIPLI(long JKJNCHGDMGL, long OKLPJIPAHKD, IReadOnlyList<AECJBGKCCJM> FBCBBNDNDCE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<BJCCECIKIFB> CFAOLGGOIBM();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CBLDGKDJGOA
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8694380", Offset = "0x8692F80", VA = "0x188694380")]
	public static KPJEMKAIFIO OBKHNEKHMPI(this PILHBOHAGEH ABIBADPJLCA)
	{
		return default(KPJEMKAIFIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface KAHCNMCOEPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KPCELFGCCOF MFBHBEELLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LEJOFPEKPOH OPIJMICPPIB;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<NMLOJLKDPAC> EONFKJHMFID(bool LDCBBPJGACI = false);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NMLOJLKDPAC HMBKICJPCNG(BJCCECIKIFB NEOGODNGJJE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KIDJCFMPKLC(BJCCECIKIFB NEOGODNGJJE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<NMLOJLKDPAC> HILIFKIPCCK(BJCCECIKIFB NEOGODNGJJE, bool HIADOIIFCME = false);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CDCFAMJAGAJ(BJCCECIKIFB OCCPGDJBGBN, KPJEMKAIFIO EGKHAMHPNFJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NMLOJLKDPAC HMAMLJGKIND(KPJEMKAIFIO EGKHAMHPNFJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OIJELLCANMF<T>(KPJEMKAIFIO EGKHAMHPNFJ, DBAKCHLGNBP PMNLAKKLOLA, bool AGOMBFAIKEN, T NOONBIFJDPN, [Optional] Action APBLNHDGNDB) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string DLJPAOHEIHB(DBAKCHLGNBP PMNLAKKLOLA);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EBCDGODJGHA(BJCCECIKIFB NEOGODNGJJE, DBAKCHLGNBP NONBAJMGCBM);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KNGLFOAJOMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GOHBLPJOMPG(LCCGADBLEIF DEELHKGGHPE, CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EPOIOCMCPIP<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string HHMJBBJEOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ELJBACCKLEM<TPermission> AMHJAAFLCCP;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class BCCOMDKFGON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? NNPIGCEOLEE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public object? HLDKPBAHNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86940B0", Offset = "0x8692CB0", VA = "0x1886940B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8694180", Offset = "0x8692D80", VA = "0x188694180")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8694280", Offset = "0x8692E80", VA = "0x188694280")]
	protected BCCOMDKFGON(object? PMJOIGCGFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool BJEJKLJFPOA(object? OOHGFGHCOAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class GFLGNLBFMPH<T> : BCCOMDKFGON where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> DIMPLJBNCJB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E9A0", Offset = "0x4D0D5A0", VA = "0x184D0E9A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4D0DFB0", Offset = "0x4D0CBB0", VA = "0x184D0DFB0", Slot = "4")]
	public override bool BJEJKLJFPOA(object? OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E5A0", Offset = "0x4D0D1A0", VA = "0x184D0E5A0")]
	public bool EMBBJABKBLL(T PBBNNJNKKNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4D0EBC0", Offset = "0x4D0D7C0", VA = "0x184D0EBC0")]
	public GFLGNLBFMPH(T IPOLOHBNCGD, IEqualityComparer<T> DIMPLJBNCJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class JELFOBJOIBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<DBAKCHLGNBP, bool> CAHFHCFHIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<DBAKCHLGNBP, BCCOMDKFGON> LFJOPPIOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FPKHECPOFII NJKKOOLOKBO;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x869B8F0", Offset = "0x869A4F0", VA = "0x18869B8F0")]
	public JELFOBJOIBC(FPKHECPOFII NJKKOOLOKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x869B880", Offset = "0x869A480", VA = "0x18869B880")]
	public bool MMEJOIGNFIB(DBAKCHLGNBP PMNLAKKLOLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F5C0", Offset = "0x3B1E1C0", VA = "0x183B1F5C0")]
	public bool JJHFALHKCOO<T>(DBAKCHLGNBP PMNLAKKLOLA, bool AGOMBFAIKEN, T OOHGFGHCOAJ) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B1FAA0", Offset = "0x3B1E6A0", VA = "0x183B1FAA0")]
	public (bool, T?) MHNIGJMFGMP<T>(DBAKCHLGNBP PMNLAKKLOLA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x869B350", Offset = "0x8699F50", VA = "0x18869B350")]
	public bool JJHFALHKCOO(DBAKCHLGNBP PMNLAKKLOLA, bool AGOMBFAIKEN, object OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x869B6F0", Offset = "0x869A2F0", VA = "0x18869B6F0")]
	public (bool, object) MHNIGJMFGMP(DBAKCHLGNBP PMNLAKKLOLA)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F580", Offset = "0x3B1E180", VA = "0x183B1F580")]
	private void BONEBBGGJHD<T>(DBAKCHLGNBP PMNLAKKLOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x869B620", Offset = "0x869A220", VA = "0x18869B620")]
	private BCCOMDKFGON LCCABALCAEJ(DBAKCHLGNBP PMNLAKKLOLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x869B430", Offset = "0x869A030", VA = "0x18869B430")]
	public void JNDJOLODDLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class KMAFBPKLEAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string DLMLBBCIDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type MGJHLNOGGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly FAMNJALANDH APIPLBJONKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly DBAKCHLGNBP PIOPAIOPCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public CJAEKIEDLLH MGFFBOHBKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public BJHEHFENOII AMCAALAADPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public CJONPJOMIIL GGKGJABHIBK;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x869BCA0", Offset = "0x869A8A0", VA = "0x18869BCA0")]
	public KMAFBPKLEAD(Type BMCIOCGELPO, string IGBMPBJHPMH, DBAKCHLGNBP PMNLAKKLOLA, CJAEKIEDLLH PIMLNAOOBFC, BJHEHFENOII GOPDAGJIBDC, CJONPJOMIIL CKGEPOFMBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x869BC50", Offset = "0x869A850", VA = "0x18869BC50")]
	public object CGMPHGGGFBL(object? GMNGNCHKEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B6BEF0", Offset = "0x3B6AAF0", VA = "0x183B6BEF0")]
	public void BONEBBGGJHD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x869BBA0", Offset = "0x869A7A0", VA = "0x18869BBA0")]
	public void BONEBBGGJHD(Type IGGOPJEBGNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class FIDJBBCFJGA<T> : KMAFBPKLEAD where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string KCIHMLPABMJ(T OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T DGCHEPGFCDD(string? EMBJKPAOHDH, T IPOLOHBNCGD);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class ADLCCCHBFDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KCIHMLPABMJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DGCHEPGFCDD parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ADLCCCHBFDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4D5ACF0", Offset = "0x4D598F0", VA = "0x184D5ACF0")]
		internal string LGBCCJOCEAA(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4D5AC60", Offset = "0x4D59860", VA = "0x184D5AC60")]
		internal object HCBIBJEIEFG(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4C11AB0", Offset = "0x4C106B0", VA = "0x184C11AB0")]
	public FIDJBBCFJGA(DBAKCHLGNBP PMNLAKKLOLA, string IGBMPBJHPMH, [Optional] KCIHMLPABMJ? PIMLNAOOBFC, [Optional] DGCHEPGFCDD? GOPDAGJIBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4C10C40", Offset = "0x4C0F840", VA = "0x184C10C40")]
	private static object? EBAGJKMAFHO(DGCHEPGFCDD? GOPDAGJIBDC, string? EMBJKPAOHDH, object? IPOLOHBNCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4C104A0", Offset = "0x4C0F0A0", VA = "0x184C104A0")]
	private static string BLPDEIDOFHH(KCIHMLPABMJ? CFBPIGENDEN, object? OOHGFGHCOAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string CJAEKIEDLLH(object? OOHGFGHCOAJ);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object BJHEHFENOII(string? EMBJKPAOHDH, [Optional] object IPOLOHBNCGD);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate BCCOMDKFGON CJONPJOMIIL();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class FPKHECPOFII
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class IFHAPJLHFJI : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static IFHAPJLHFJI LBPNLDGACAA;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8698690", Offset = "0x8697290", VA = "0x188698690", Slot = "4")]
		public bool Equals(List<string> KFGAJBKADFK, List<string> FEABMDLFEMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x86987E0", Offset = "0x86973E0", VA = "0x1886987E0", Slot = "5")]
		public int GetHashCode(List<string> KDKJDFFGNJJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public IFHAPJLHFJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class LKCACKCGHJK : JKEJPMNNMJN<AHHGMMJOKCP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x869BD40", Offset = "0x869A940", VA = "0x18869BD40", Slot = "9")]
		public override string BLPDEIDOFHH(AHHGMMJOKCP OLMHJMNEENP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x869BE30", Offset = "0x869AA30", VA = "0x18869BE30", Slot = "10")]
		protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] AHHGMMJOKCP OOHGFGHCOAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x869C010", Offset = "0x869AC10", VA = "0x18869C010")]
		public LKCACKCGHJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly FCPNPFMCDBN FFDPBANILIB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly LKCACKCGHJK FBHANFFEFOB;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<KMAFBPKLEAD> DJBOCCGIPFE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<DBAKCHLGNBP> KPHHFCEEGHG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<DBAKCHLGNBP, KMAFBPKLEAD> AEFMAPKHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8696930", Offset = "0x8695530", VA = "0x188696930")]
	public FPKHECPOFII([Optional] IList<KMAFBPKLEAD>? CIKEMDCNNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8694B00", Offset = "0x8693700", VA = "0x188694B00")]
	public KMAFBPKLEAD MGIHPBEMGOA(DBAKCHLGNBP PMNLAKKLOLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KPCELFGCCOF
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NMLOJLKDPAC GIPOLNLHDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class GDNNFKAHLFB : KPCELFGCCOF
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static GDNNFKAHLFB CHCDBJLNBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly IKOIECNEEBH BFDGDKDJLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<IKOIECNEEBH> CDJMDLDMKHJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NMLOJLKDPAC GIPOLNLHDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8697D30", Offset = "0x8696930", VA = "0x188697D30")]
	public GDNNFKAHLFB(IKOIECNEEBH MGKFLFNPLCP, IReadOnlyList<IKOIECNEEBH> KIPPAIMOBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8696C50", Offset = "0x8695850", VA = "0x188696C50")]
	private static GDNNFKAHLFB BNJCAJNOOJF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class PKJJECEINBO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<KPJEMKAIFIO> MFNLDDJCHPL;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x869C830", Offset = "0x869B430", VA = "0x18869C830")]
	public static bool FMGKIAKHLEE(this BJCCECIKIFB DMMFONEMJLA, KPJEMKAIFIO EGKHAMHPNFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x869C910", Offset = "0x869B510", VA = "0x18869C910")]
	public static bool HIOIFPKDFOE(this BJCCECIKIFB DMMFONEMJLA, KPJEMKAIFIO EGKHAMHPNFJ, KINJLHLHADG BAAHMPCCABG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NMJOGKHNPKH
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IReadOnlyList<string> CGLEFDJAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	AHHGMMJOKCP MAFFOGMPNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NMLOJLKDPAC : NMJOGKHNPKH, IPBADKEJGLJ, EPOIOCMCPIP<DBAKCHLGNBP>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string HIEIDFLFGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KPJEMKAIFIO CPCPGEGIFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) HKOIAPHABKP<T>(DBAKCHLGNBP PMNLAKKLOLA) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class IKOIECNEEBH : NMLOJLKDPAC, NMJOGKHNPKH, IPBADKEJGLJ, EPOIOCMCPIP<DBAKCHLGNBP>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly FPKHECPOFII FGEMKFFMDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly JELFOBJOIBC CFPMHJGFKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? GGKFDOCECBH;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool KIAGMAKAOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x869A430", Offset = "0x8699030", VA = "0x18869A430", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool KDIEPDJPNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8699C80", Offset = "0x8698880", VA = "0x188699C80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool KBPPNMJPJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86996E0", Offset = "0x86982E0", VA = "0x1886996E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool NHHHGICDMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8699690", Offset = "0x8698290", VA = "0x188699690", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool NPAHOCFDHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8699640", Offset = "0x8698240", VA = "0x188699640", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool FDPJCDIAHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8699C30", Offset = "0x8698830", VA = "0x188699C30", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public KPJEMKAIFIO CPCPGEGIFLK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA6B040", Offset = "0xA69C40", VA = "0x180A6B040", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(KPJEMKAIFIO);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB30", Offset = "0xA1D730", VA = "0x180A1EB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string HHMJBBJEOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x869ADE0", Offset = "0x86999E0", VA = "0x18869ADE0", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA27D40", Offset = "0xA26940", VA = "0x180A27D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string HIEIDFLFGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x869ADE0", Offset = "0x86999E0", VA = "0x18869ADE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool DJNFFJMGLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA4B580", Offset = "0xA4A180", VA = "0x180A4B580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3A0", Offset = "0xA49FA0", VA = "0x180A4B3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public AHHGMMJOKCP MAFFOGMPNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8699BE0", Offset = "0x86987E0", VA = "0x188699BE0", Slot = "8")]
		get
		{
			return default(AHHGMMJOKCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyList<string> CGLEFDJAEND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8699B80", Offset = "0x8698780", VA = "0x188699B80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool AHCLLHEFBLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x869A430", Offset = "0x8699030", VA = "0x18869A430", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool PJOOKNKCPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8699640", Offset = "0x8698240", VA = "0x188699640", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool AKKGIFILLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8699C80", Offset = "0x8698880", VA = "0x188699C80", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool BHPKCDGCLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x86996E0", Offset = "0x86982E0", VA = "0x1886996E0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool POIBIILALLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8699690", Offset = "0x8698290", VA = "0x188699690", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MPFAMGKFKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8699C30", Offset = "0x8698830", VA = "0x188699C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event ELJBACCKLEM<DBAKCHLGNBP> AMHJAAFLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x869AE30", Offset = "0x8699A30", VA = "0x18869AE30", Slot = "15")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x869A110", Offset = "0x8698D10", VA = "0x18869A110", Slot = "16")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3B30", Offset = "0x3AF2730", VA = "0x183AF3B30", Slot = "6")]
	public (bool, T?) HKOIAPHABKP<T>(DBAKCHLGNBP PMNLAKKLOLA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3AFCC30", Offset = "0x3AFB830", VA = "0x183AFCC30")]
	public IKOIECNEEBH MJLLGAHNGDG<T>(DBAKCHLGNBP PMNLAKKLOLA, bool AGOMBFAIKEN, T OOHGFGHCOAJ) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x869B130", Offset = "0x8699D30", VA = "0x18869B130")]
	public IKOIECNEEBH(KPJEMKAIFIO EGKHAMHPNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x869AF60", Offset = "0x8699B60", VA = "0x18869AF60")]
	public IKOIECNEEBH(KPJEMKAIFIO EGKHAMHPNFJ, [Optional] string? GGKFDOCECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x869B0B0", Offset = "0x8699CB0", VA = "0x18869B0B0")]
	public IKOIECNEEBH(IKOIECNEEBH DJBPOCPMAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x869AF80", Offset = "0x8699B80", VA = "0x18869AF80")]
	internal IKOIECNEEBH(KPJEMKAIFIO HCDHFFAKDNI, [Optional] string? GGKFDOCECBH, [Optional] IKOIECNEEBH? DJBPOCPMAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8699FC0", Offset = "0x8698BC0", VA = "0x188699FC0")]
	public static FAMNJALANDH FDFIBLMCPMG(DBAKCHLGNBP PMNLAKKLOLA)
	{
		return default(FAMNJALANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x869A1C0", Offset = "0x8698DC0", VA = "0x18869A1C0")]
	public void JNDJOLODDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8699CD0", Offset = "0x86988D0", VA = "0x188699CD0")]
	internal IKOIECNEEBH FCFGEOLOFMK(IKOIECNEEBH BIADPFHKIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x86997C0", Offset = "0x86983C0", VA = "0x1886997C0")]
	internal IReadOnlyCollection<DBAKCHLGNBP> CMICAOGODDE(IKOIECNEEBH DJBPOCPMAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x869A030", Offset = "0x8698C30", VA = "0x18869A030")]
	public bool GEMJOFGMMHN(DBAKCHLGNBP PMNLAKKLOLA, bool AGOMBFAIKEN, string IJLACADNEMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8699540", Offset = "0x8698140", VA = "0x188699540")]
	public (bool, string) APBPBMGIMPB(DBAKCHLGNBP PMNLAKKLOLA)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x869A3E0", Offset = "0x8698FE0", VA = "0x18869A3E0")]
	internal void LEDEOPOLHPD(DBAKCHLGNBP PMNLAKKLOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x869A1E0", Offset = "0x8698DE0", VA = "0x18869A1E0")]
	public BNOAOJGGNDB LAHJGFFFHDG(Func<KPJEMKAIFIO, Guid> ILBGAMGPHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x869A480", Offset = "0x8699080", VA = "0x18869A480")]
	public void MPLODBFKDCL(BNOAOJGGNDB BOPJBGOGLBL, Func<Guid, KPJEMKAIFIO> EDAFEGCIGNO, [Optional] KPJEMKAIFIO? BMEJCJDHKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8699730", Offset = "0x8698330", VA = "0x188699730")]
	[CompilerGenerated]
	private void BNFGCGCADPJ(DBAKCHLGNBP NONBAJMGCBM, FCNGALPAMHK LBKAMOIJMNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AIBHIDKEBCI : KNGLFOAJOMJ, KAHCNMCOEPK, IDisposable, JJBJFMJFHNL
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CEMBFIKKJED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IKOIECNEEBH newRole;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public CEMBFIKKJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x86943E0", Offset = "0x8692FE0", VA = "0x1886943E0")]
		internal bool KGPBIDCJBHI(IKOIECNEEBH rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class FKNGCGANCBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KPJEMKAIFIO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FKNGCGANCBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1D84390", Offset = "0x1D82F90", VA = "0x181D84390")]
		internal bool LMMPAPHBFLJ(KPJEMKAIFIO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct OMOBBICCEFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AIBHIDKEBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public LCCGADBLEIF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<KEFBCAHLMFC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x869C160", Offset = "0x869AD60", VA = "0x18869C160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x869C7D0", Offset = "0x869B3D0", VA = "0x18869C7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ILGCGALOLGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ILGCGALOLGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x869B270", Offset = "0x8699E70", VA = "0x18869B270")]
		internal void NJIAOPBFHEF(BNOAOJGGNDB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x869B150", Offset = "0x8699D50", VA = "0x18869B150")]
		internal void BAFPADFIJNG(BNOAOJGGNDB r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct CHKNCGDFKCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public LCCGADBLEIF roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class OFMJEBBHELI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Func<BNOAOJGGNDB, FCNGALPAMHK> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OFMJEBBHELI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x869C130", Offset = "0x869AD30", VA = "0x18869C130")]
		internal void PNDGKGCNGBI(BNOAOJGGNDB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x869C100", Offset = "0x869AD00", VA = "0x18869C100")]
		internal void OOKIBJMKODA(BNOAOJGGNDB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x869C0D0", Offset = "0x869ACD0", VA = "0x18869C0D0")]
		internal void KICHFAKMMFD(BNOAOJGGNDB r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LDPICDOEIDJ<T> where T : notnull
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
			public LDPICDOEIDJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<KEFBCAHLMFC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x426B410", Offset = "0x426A010", VA = "0x18426B410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public DBAKCHLGNBP rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public KPJEMKAIFIO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public FAMNJALANDH recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AIBHIDKEBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LDPICDOEIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5283760", Offset = "0x5282360", VA = "0x185283760")]
		[AsyncStateMachine(typeof(LDPICDOEIDJ<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void AJCAIENJJAC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct PPEFGEIJNFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IReadOnlyList<AECJBGKCCJM> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct IHGOAFAILGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public PILHBOHAGEH rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public LCCGADBLEIF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IReadOnlyDictionary<KPJEMKAIFIO, IKOIECNEEBH> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public DGKBILEDBJJ debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x86989C0", Offset = "0x86975C0", VA = "0x1886989C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x86994E0", Offset = "0x86980E0", VA = "0x1886994E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly PILHBOHAGEH ABIBADPJLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GDNNFKAHLFB BECPDEMODAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly DGKBILEDBJJ KHABKJJDOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<int, IKOIECNEEBH> PAAFPGFLGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly Dictionary<KPJEMKAIFIO, IKOIECNEEBH> JPECLJGHJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly Dictionary<KPJEMKAIFIO, IKOIECNEEBH> OKKEFLKGBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly List<IKOIECNEEBH> BNLGCPOKFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool AJKFFPNDFOG;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly DBAKCHLGNBP[] MANALCJAOGF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public KPCELFGCCOF MFBHBEELLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LEJOFPEKPOH OPIJMICPPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x868F660", Offset = "0x868E260", VA = "0x18868F660", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8690CB0", Offset = "0x868F8B0", VA = "0x188690CB0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8692590", Offset = "0x8691190", VA = "0x188692590")]
	[IGNGJLOKDFM.NGODLIIFCIB]
	internal static void MACELCFKDEA(PFGPAPHADOM AKKHFHFGLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8693DF0", Offset = "0x86929F0", VA = "0x188693DF0")]
	[UnityEngine.Scripting.Preserve]
	internal AIBHIDKEBCI([GFNPNOLPMKK(null)] PILHBOHAGEH EEFLBDGNDFO, [GFNPNOLPMKK(null)] GDNNFKAHLFB IICDKAOHMAI, [GFNPNOLPMKK(null)] DGKBILEDBJJ KHABKJJDOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x868F100", Offset = "0x868DD00", VA = "0x18868F100", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8693330", Offset = "0x8691F30", VA = "0x188693330")]
	private void PPKDEOFBJOJ(IEnumerable<IKOIECNEEBH> KGDCGOGBDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8691D90", Offset = "0x8690990", VA = "0x188691D90", Slot = "10")]
	public bool KIDJCFMPKLC(BJCCECIKIFB NEOGODNGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x86909A0", Offset = "0x868F5A0", VA = "0x1886909A0")]
	private void HEHHMEAJFFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x868E6E0", Offset = "0x868D2E0", VA = "0x18868E6E0")]
	private void AHDJNMCANEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x868F5E0", Offset = "0x868E1E0", VA = "0x18868F5E0", Slot = "8")]
	public IReadOnlyList<NMLOJLKDPAC> EONFKJHMFID(bool LDCBBPJGACI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8690BA0", Offset = "0x868F7A0", VA = "0x188690BA0", Slot = "9")]
	public NMLOJLKDPAC HMBKICJPCNG(BJCCECIKIFB NEOGODNGJJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8692D40", Offset = "0x8691940", VA = "0x188692D40")]
	private KPJEMKAIFIO NCPMEINJNDD(BJCCECIKIFB NEOGODNGJJE)
	{
		return default(KPJEMKAIFIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x868EBE0", Offset = "0x868D7E0", VA = "0x18868EBE0", Slot = "12")]
	public bool CDCFAMJAGAJ(BJCCECIKIFB OCCPGDJBGBN, KPJEMKAIFIO EGKHAMHPNFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8690B00", Offset = "0x868F700", VA = "0x188690B00", Slot = "13")]
	public NMLOJLKDPAC HMAMLJGKIND(KPJEMKAIFIO EGKHAMHPNFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8690550", Offset = "0x868F150", VA = "0x188690550")]
	private static bool GEEEAFHABGI(KBEGKAMIGGA CHOGJFIDDHF, KPJEMKAIFIO EGKHAMHPNFJ, [Out] BNOAOJGGNDB? PADFFFHCCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8692E80", Offset = "0x8691A80", VA = "0x188692E80")]
	private static void NOFCAMGGDEK(KBEGKAMIGGA CHOGJFIDDHF, Action<BNOAOJGGNDB> FDOCKICPPPJ, KPJEMKAIFIO PFDMFOLHADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8692F70", Offset = "0x8691B70", VA = "0x188692F70")]
	private static void NOFCAMGGDEK(KBEGKAMIGGA CHOGJFIDDHF, Action<BNOAOJGGNDB> FDOCKICPPPJ, Predicate<KPJEMKAIFIO> DNGKJEHNNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8692E10", Offset = "0x8691A10", VA = "0x188692E10")]
	private void NMFABIFNIAL(BJCCECIKIFB NEOGODNGJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8690880", Offset = "0x868F480", VA = "0x188690880", Slot = "4")]
	[AsyncStateMachine(typeof(OMOBBICCEFP))]
	public Task GOHBLPJOMPG([CanBeNull] LCCGADBLEIF DEELHKGGHPE, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x868F700", Offset = "0x868E300", VA = "0x18868F700")]
	private void FFIAAFEIDKH(KBEGKAMIGGA HKLIODEJDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x868E8D0", Offset = "0x868D4D0", VA = "0x18868E8D0")]
	internal static string APJGMJIFJHF(PILHBOHAGEH ABIBADPJLCA, LCCGADBLEIF DEELHKGGHPE, IReadOnlyDictionary<KPJEMKAIFIO, IKOIECNEEBH> JPECLJGHJHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8690D50", Offset = "0x868F950", VA = "0x188690D50")]
	private static void IDEEAIPNEIH(LCCGADBLEIF DEELHKGGHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8692750", Offset = "0x8691350", VA = "0x188692750")]
	private static void MJGDCHKIIOA(KBEGKAMIGGA LODPGBPAMOK, IReadOnlyDictionary<KPJEMKAIFIO, IKOIECNEEBH> JPECLJGHJHE, StringBuilder KMIPPIHGKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8693220", Offset = "0x8691E20", VA = "0x188693220")]
	private static bool PMMNCMLMAEO(string LMBHJNENEKO, [Out] Guid KBNFFHLIFCL, [Out] KPJEMKAIFIO EGKHAMHPNFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8691E60", Offset = "0x8690A60", VA = "0x188691E60")]
	private static void KKNNHAAIPCP(LCCGADBLEIF DEELHKGGHPE, StringBuilder KMIPPIHGKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3044E90", Offset = "0x3043A90", VA = "0x183044E90", Slot = "14")]
	public bool OIJELLCANMF<T>(KPJEMKAIFIO EGKHAMHPNFJ, DBAKCHLGNBP PMNLAKKLOLA, bool AGOMBFAIKEN, T NOONBIFJDPN, [Optional] Action APBLNHDGNDB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x868F090", Offset = "0x868DC90", VA = "0x18868F090", Slot = "15")]
	public string DLJPAOHEIHB(DBAKCHLGNBP PMNLAKKLOLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x868F210", Offset = "0x868DE10", VA = "0x18868F210", Slot = "16")]
	public bool EBCDGODJGHA(BJCCECIKIFB NEOGODNGJJE, DBAKCHLGNBP NONBAJMGCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x868F300", Offset = "0x868DF00", VA = "0x18868F300", Slot = "18")]
	public bool EBCDGODJGHA(int KJIKHIJJPOK, DBAKCHLGNBP NONBAJMGCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x868E4D0", Offset = "0x868D0D0", VA = "0x18868E4D0")]
	private void ABCINBCHBIF(KPJEMKAIFIO EGKHAMHPNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8693200", Offset = "0x8691E00", VA = "0x188693200")]
	private bool OBPHPAFGHKG(BJCCECIKIFB NEOGODNGJJE, KPJEMKAIFIO EGKHAMHPNFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x868ED50", Offset = "0x868D950", VA = "0x18868ED50")]
	internal IKOIECNEEBH CFHIFCEGLGK(BJCCECIKIFB NEOGODNGJJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x86909B0", Offset = "0x868F5B0", VA = "0x1886909B0", Slot = "11")]
	public IReadOnlyList<NMLOJLKDPAC> HILIFKIPCCK(BJCCECIKIFB NEOGODNGJJE, bool HIADOIIFCME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x868F3B0", Offset = "0x868DFB0", VA = "0x18868F3B0")]
	internal IReadOnlyList<IKOIECNEEBH> EIPMLMMIOKA(BJCCECIKIFB NEOGODNGJJE, bool HIADOIIFCME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x868FDC0", Offset = "0x868E9C0", VA = "0x18868FDC0")]
	private void FPHAJOPLOCH(KEFBCAHLMFC OPNNHJLDEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8691AB0", Offset = "0x86906B0", VA = "0x188691AB0")]
	private static bool KFIDBNFEAOO(IKOIECNEEBH NDECDNFOLKC, IReadOnlyDictionary<KPJEMKAIFIO, IKOIECNEEBH> JPECLJGHJHE, [Out] IReadOnlyList<DBAKCHLGNBP> LNDPGAACAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x86909C0", Offset = "0x868F5C0", VA = "0x1886909C0")]
	[AsyncStateMachine(typeof(IHGOAFAILGE))]
	private static Task HIPIEKGOGBB(PILHBOHAGEH ABIBADPJLCA, LCCGADBLEIF DEELHKGGHPE, IReadOnlyDictionary<KPJEMKAIFIO, IKOIECNEEBH> JPECLJGHJHE, DGKBILEDBJJ KHABKJJDOCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8692AA0", Offset = "0x86916A0", VA = "0x188692AA0")]
	[CompilerGenerated]
	internal static void MMIKPECGILN(Func<BNOAOJGGNDB, FCNGALPAMHK> ODJNHNOOEGN, CHKNCGDFKCI P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x868FA40", Offset = "0x868E640", VA = "0x18868FA40")]
	[CompilerGenerated]
	internal static bool FOOKMMOFJJA(KPJEMKAIFIO EGKHAMHPNFJ, DBAKCHLGNBP PMNLAKKLOLA, [Out] AECJBGKCCJM POEILIGOCBG, PPEFGEIJNFK P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface POBIJABIOLE
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMBBEMBFOGE(BJCCECIKIFB OCPMOCOCNGN, BJCCECIKIFB FBFNMJIPPGM, IEnumerable<BJCCECIKIFB> KJIGEANKNKD, [Out] AHHGMMJOKCP DAHPHKONELG, [Out] OAGCDMCHCBJ GBBNPABCELC);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HABIGNLPOPP(OAGCDMCHCBJ OFIOJNPOAKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum OAGCDMCHCBJ : byte
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
internal class GMIHOEGGJAO : POBIJABIOLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly KAHCNMCOEPK GCAGCMNINFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MJNNFGALKJN KNKMPLIDDKI;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA20DD0", Offset = "0xA1F9D0", VA = "0x180A20DD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GMIHOEGGJAO([GFNPNOLPMKK(null)] KAHCNMCOEPK GCAGCMNINFC, [GFNPNOLPMKK(null)] MJNNFGALKJN OAKPFGOENJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8698450", Offset = "0x8697050", VA = "0x188698450")]
	private static ANICCEDEIDE? GFJFAFNOKHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8698590", Offset = "0x8697190", VA = "0x188698590", Slot = "4")]
	public bool KMBBEMBFOGE(BJCCECIKIFB OCPMOCOCNGN, BJCCECIKIFB FBFNMJIPPGM, IEnumerable<BJCCECIKIFB> KJIGEANKNKD, [Out] AHHGMMJOKCP DAHPHKONELG, [Out] OAGCDMCHCBJ GBBNPABCELC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8698490", Offset = "0x8697090", VA = "0x188698490", Slot = "5")]
	public string HABIGNLPOPP(OAGCDMCHCBJ OFIOJNPOAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8697E40", Offset = "0x8696A40", VA = "0x188697E40")]
	internal bool FAKGOOFJIFI(BJCCECIKIFB OCPMOCOCNGN, BJCCECIKIFB FBFNMJIPPGM, IEnumerable<BJCCECIKIFB> KJIGEANKNKD, KINJLHLHADG BAAHMPCCABG, ANICCEDEIDE? ICFCDCAOGMF, [Out] AHHGMMJOKCP DAHPHKONELG, [Out] OAGCDMCHCBJ GBBNPABCELC)
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

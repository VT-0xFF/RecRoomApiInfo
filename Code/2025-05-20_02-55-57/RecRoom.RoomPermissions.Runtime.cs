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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85164E0", Offset = "0x85156E0", VA = "0x1885164E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BOPNNAHOPKJ
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
		[Cpp2IlInjected.Address(RVA = "0x8517540", Offset = "0x8516740", VA = "0x188517540", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HFDFECPHEPD<TPermission>(TPermission JEMKMMGBOPI);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void FHNCFNMKHFJ(KPDBONCIMNC PNBFNEJFAPC);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum IMKLMCEIGAH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OJFDENPAEEA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LKMOJAAMFBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BLLLDLHLMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NLMAHKFOLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AOOGJNFKJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool IGPENOKAECE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OEIJPFEAMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class IDFFDLIHOLA
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum DKCJGEBFCGG
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
	public static readonly Guid BPLPGPJELAN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid MNFAHPEDBKJ;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid GKNKPAFLCCE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid OFPAGGBFFPL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid BBLDLCDMING;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid JDOHDFODMMK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LCPDAGGPADI<ODJGKIKFMEP, Guid> PBMLEOMDKNP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<ODJGKIKFMEP> OACFBADEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8514070", Offset = "0x8513270", VA = "0x188514070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8513F30", Offset = "0x8513130", VA = "0x188513F30")]
	public static ODJGKIKFMEP NELELKDKLHD(Guid DIHOLCNHIND)
	{
		return default(ODJGKIKFMEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x85140E0", Offset = "0x85132E0", VA = "0x1885140E0")]
	public static Guid OEJDCHGEOJL(ODJGKIKFMEP KPOGGIAFAJP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8513DC0", Offset = "0x8512FC0", VA = "0x188513DC0")]
	public static bool CGFFEOACPMA(ODJGKIKFMEP KPOGGIAFAJP, [Out] Guid DIHOLCNHIND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8513E90", Offset = "0x8513090", VA = "0x188513E90")]
	public static bool LIDCJGOBCIG(Guid DIHOLCNHIND, [Out] ODJGKIKFMEP KPOGGIAFAJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8513E50", Offset = "0x8513050", VA = "0x188513E50")]
	public static ODJGKIKFMEP CHOKGBEFPNG(ODJGKIKFMEP KPOGGIAFAJP)
	{
		return default(ODJGKIKFMEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8513FC0", Offset = "0x85131C0", VA = "0x188513FC0")]
	public static DKCJGEBFCGG NIFJHLEJJAH(ODJGKIKFMEP MKEDJBJDOID)
	{
		return default(DKCJGEBFCGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8514180", Offset = "0x8513380", VA = "0x188514180")]
	internal static ODJGKIKFMEP PHOBHLBOFCA(DKCJGEBFCGG LAIKEHONPHC)
	{
		return default(ODJGKIKFMEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GELOLPBACFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BPAFGBBHJGH IPLJMBJJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<DIKAFKMBKJE> OOOGDECBLDL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event FHNCFNMKHFJ OBNHKCKMHMN;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<DIKAFKMBKJE> EDPLOOEFDAF(bool NMGOPIOHDNJ = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DIKAFKMBKJE AONLKHEMJLH(KPDBONCIMNC PNBFNEJFAPC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ANMBGGPDMPH(KPDBONCIMNC PNBFNEJFAPC);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<DIKAFKMBKJE> GFAHAHNCHJM(KPDBONCIMNC PNBFNEJFAPC, bool ICDKAJOOHBN = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool APLPHMFIFOK(KPDBONCIMNC HMEBBCAKILL, ODJGKIKFMEP KPOGGIAFAJP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DIKAFKMBKJE AHOIIOMBJEJ(ODJGKIKFMEP KPOGGIAFAJP);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HAAHIEMEAKK<T>(ODJGKIKFMEP KPOGGIAFAJP, BMBHEAPGKKC JEMKMMGBOPI, bool KNLNPCEFPJN, T HLMDGBFCIDH, [Optional] Action NGAHPPGKMOC) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string HANBBCLPHHB(BMBHEAPGKKC JEMKMMGBOPI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GJPJGLDADND
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DEHHBONLIHB(CBMANFMCNIJ GIKGHELDAKC, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCEMAAIFHPI(CBMANFMCNIJ GIKGHELDAKC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LAPOOHDFFKP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	KPDBONCIMNC HJOKCGMKHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LDKIAIAGMBD MGFLPMIHPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JKGEOIDCPBI GJEAIDAGIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CPHNLHDOFND> FNCNOICPBAE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action INPBAIAMGOL;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ODJGKIKFMEP EBBKPJLJICG(KPDBONCIMNC PNBFNEJFAPC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CPHNLHDOFND> GFEKBLFOAAL(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task ALKOAIHKPPD(long BENLNHBBIME, IReadOnlyList<EBEFPKKIKEK> PCHACDBBBHA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task KJIAGAEDDHD(long BENLNHBBIME, long OECKHCOHBDG, IReadOnlyList<EBEFPKKIKEK> PCHACDBBBHA);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KPDBONCIMNC> HIEJNCNIDBP();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LENOLMJLJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85154D0", Offset = "0x85146D0", VA = "0x1885154D0")]
	public static ODJGKIKFMEP ENCCEFPBBDC(this LAPOOHDFFKP BFMIAHPOMMP)
	{
		return default(ODJGKIKFMEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JOMIOFICGIF<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string PAFBHFGKAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HFDFECPHEPD<TPermission> IJJDCLFFMGN;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class DDNAABEFJDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? GKLCOPLLFMK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? GIGFHLDOIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8510E10", Offset = "0x8510010", VA = "0x188510E10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8510D10", Offset = "0x850FF10", VA = "0x188510D10")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8510EE0", Offset = "0x85100E0", VA = "0x188510EE0")]
	protected DDNAABEFJDA(object? MEGBKMMAGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DFKHJHBMAIH(object? MLCDCHNOCFI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class IIJLFELGMLF<T> : DDNAABEFJDA where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> LEABKHICHOK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4C85BA0", Offset = "0x4C84DA0", VA = "0x184C85BA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4C85610", Offset = "0x4C84810", VA = "0x184C85610", Slot = "4")]
	public override bool DFKHJHBMAIH(object? MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4C85FF0", Offset = "0x4C851F0", VA = "0x184C85FF0")]
	public bool OMJALONEDOG(T FCMNGOAODCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4C86210", Offset = "0x4C85410", VA = "0x184C86210")]
	public IIJLFELGMLF(T FAGKKFIFNNI, IEqualityComparer<T> LEABKHICHOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class OKOGFPHGKMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<BMBHEAPGKKC, bool> OKHKIIMJAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<BMBHEAPGKKC, DDNAABEFJDA> AGMMDLLJEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DGAJHOFPODJ FIBBMHNDNBN;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8516B00", Offset = "0x8515D00", VA = "0x188516B00")]
	public OKOGFPHGKMJ(DGAJHOFPODJ FIBBMHNDNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8516560", Offset = "0x8515760", VA = "0x188516560")]
	public bool CGLMPAIIGMG(BMBHEAPGKKC JEMKMMGBOPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x39F65D0", Offset = "0x39F57D0", VA = "0x1839F65D0")]
	public bool LOHCIJGDILN<T>(BMBHEAPGKKC JEMKMMGBOPI, bool KNLNPCEFPJN, T MLCDCHNOCFI) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x39F6130", Offset = "0x39F5330", VA = "0x1839F6130")]
	public (bool, T?) KGNPPFFBBDO<T>(BMBHEAPGKKC JEMKMMGBOPI) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8516A20", Offset = "0x8515C20", VA = "0x188516A20")]
	public bool LOHCIJGDILN(BMBHEAPGKKC JEMKMMGBOPI, bool KNLNPCEFPJN, object MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8516890", Offset = "0x8515A90", VA = "0x188516890")]
	public (bool, object) KGNPPFFBBDO(BMBHEAPGKKC JEMKMMGBOPI)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x39F60D0", Offset = "0x39F52D0", VA = "0x1839F60D0")]
	private void AFOGJGHIJHE<T>(BMBHEAPGKKC JEMKMMGBOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x85165D0", Offset = "0x85157D0", VA = "0x1885165D0")]
	private DDNAABEFJDA DAGHBLDKJAL(BMBHEAPGKKC JEMKMMGBOPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85166A0", Offset = "0x85158A0", VA = "0x1885166A0")]
	public void HFACLKNFIPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class GEOHBNCEGHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string GKPIDFDNOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type ALBBPJEAIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly CHEBJNBGEBC GFEKGKCIOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly BMBHEAPGKKC BCPDNKIMLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public CGEFHGOCBFI HBCAJKGPIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public PNKNNFKPGDF BHPEGEHKEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NAOLDDHFBHM LCHHAKPAFCP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8512E70", Offset = "0x8512070", VA = "0x188512E70")]
	public GEOHBNCEGHE(Type POJDGGFPOMG, string AOEGJGILOAO, BMBHEAPGKKC JEMKMMGBOPI, CGEFHGOCBFI ANLPFLHKJPM, PNKNNFKPGDF MECFLIAIHIC, NAOLDDHFBHM HNDLHIEMEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8512E20", Offset = "0x8512020", VA = "0x188512E20")]
	public object FMMOJKPJOGK(object? FNJGMJGALLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x381FF50", Offset = "0x381F150", VA = "0x18381FF50")]
	public void AFOGJGHIJHE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8512D70", Offset = "0x8511F70", VA = "0x188512D70")]
	public void AFOGJGHIJHE(Type IHKCGHCPJPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class NNMMMGCEMAE<T> : GEOHBNCEGHE where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string FDKKAINPDKI(T MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T BPFJNEOFOBI(string? HAKPAIGEOLP, T FAGKKFIFNNI);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MCJPLIIPFJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FDKKAINPDKI serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BPFJNEOFOBI parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MCJPLIIPFJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x52D6AC0", Offset = "0x52D5CC0", VA = "0x1852D6AC0")]
		internal string MLBJPLDJHGA(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x52D68B0", Offset = "0x52D5AB0", VA = "0x1852D68B0")]
		internal object KPEBKPHHGGC(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x53BFC00", Offset = "0x53BEE00", VA = "0x1853BFC00")]
	public NNMMMGCEMAE(BMBHEAPGKKC JEMKMMGBOPI, string AOEGJGILOAO, [Optional] FDKKAINPDKI? ANLPFLHKJPM, [Optional] BPFJNEOFOBI? MECFLIAIHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x53BF5E0", Offset = "0x53BE7E0", VA = "0x1853BF5E0")]
	private static object? JKAINKAKBPB(BPFJNEOFOBI? MECFLIAIHIC, string? HAKPAIGEOLP, object? FAGKKFIFNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x53BEAA0", Offset = "0x53BDCA0", VA = "0x1853BEAA0")]
	private static string CEBCPPBDNIB(FDKKAINPDKI? AMHHGIBOFPD, object? MLCDCHNOCFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string CGEFHGOCBFI(object? MLCDCHNOCFI);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object PNKNNFKPGDF(string? HAKPAIGEOLP, [Optional] object FAGKKFIFNNI);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate DDNAABEFJDA NAOLDDHFBHM();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class DGAJHOFPODJ
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class HGKJGMLKLLP : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static HGKJGMLKLLP NDDGJHHDBNJ;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8513A90", Offset = "0x8512C90", VA = "0x188513A90", Slot = "4")]
		public bool Equals(List<string> CCOLDGJALNH, List<string> JCBKIOEHCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8513BE0", Offset = "0x8512DE0", VA = "0x188513BE0", Slot = "5")]
		public int GetHashCode(List<string> DBCLNEGBNLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HGKJGMLKLLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class ACGDCOEABJA : BNHGMLNCOLP<BOPNNAHOPKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8508F50", Offset = "0x8508150", VA = "0x188508F50", Slot = "9")]
		public override string CEBCPPBDNIB(BOPNNAHOPKJ EEEOGOJIPGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8509040", Offset = "0x8508240", VA = "0x188509040", Slot = "10")]
		protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] BOPNNAHOPKJ MLCDCHNOCFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8509220", Offset = "0x8508420", VA = "0x188509220")]
		public ACGDCOEABJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly NPKNJCEPGGJ DNBHILJEABK;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly ACGDCOEABJA OGKPBOJCHKO;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<GEOHBNCEGHE> JHEFOGFOIOK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<BMBHEAPGKKC> ABMECJOHOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<BMBHEAPGKKC, GEOHBNCEGHE> PNGDMPLCDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8512850", Offset = "0x8511A50", VA = "0x188512850")]
	public DGAJHOFPODJ([Optional] IList<GEOHBNCEGHE>? DDPHDDLNPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85112E0", Offset = "0x85104E0", VA = "0x1885112E0")]
	public GEOHBNCEGHE FLEKDELDBHD(BMBHEAPGKKC JEMKMMGBOPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BPAFGBBHJGH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DIKAFKMBKJE PJFOCIAMDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class LCKPFCPFAPE : BPAFGBBHJGH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static LCKPFCPFAPE IOMAJGHFNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly BPCLIDDPAHH EMGILBEGJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<BPCLIDDPAHH> FPDOBIJKJEN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DIKAFKMBKJE PJFOCIAMDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x85153C0", Offset = "0x85145C0", VA = "0x1885153C0")]
	public LCKPFCPFAPE(BPCLIDDPAHH ENIMJHNJAKP, IReadOnlyList<BPCLIDDPAHH> MFGEGIFLLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x85144B0", Offset = "0x85136B0", VA = "0x1885144B0")]
	private static LCKPFCPFAPE CLPEMCMFLOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DDOEBHADEDO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<ODJGKIKFMEP> FFBKMPOBKIA;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8511060", Offset = "0x8510260", VA = "0x188511060")]
	public static bool NGABIHJGEAA(this KPDBONCIMNC MHLIPNBBNLC, ODJGKIKFMEP KPOGGIAFAJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8510FE0", Offset = "0x85101E0", VA = "0x188510FE0")]
	public static bool AJBIKCPALLI(this KPDBONCIMNC MHLIPNBBNLC, ODJGKIKFMEP KPOGGIAFAJP, JKGEOIDCPBI GAGMCMAACOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface IDLKLGAPLDI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool OONGCCOMDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LGDABLCBKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool FDNCKCHJDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LCKKNHCKKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EJMGHOAGNPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LIEDHFCJENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NJNKKMDOJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool FMDKIAKMLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool KIEBDJMKKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool FDKGJGOAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool AGAHAMGCKLP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool ECFNLJMLOJM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> AMLJPFCDIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BOPNNAHOPKJ NIIHOELGJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DIKAFKMBKJE : IDLKLGAPLDI, OJFDENPAEEA, JOMIOFICGIF<BMBHEAPGKKC>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string FECLJPBHHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	ODJGKIKFMEP IFHFGECABJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) KFBJNDLIHEB<T>(BMBHEAPGKKC JEMKMMGBOPI) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum BMBHEAPGKKC
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
internal class BPCLIDDPAHH : DIKAFKMBKJE, IDLKLGAPLDI, OJFDENPAEEA, JOMIOFICGIF<BMBHEAPGKKC>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly DGAJHOFPODJ DPPDHLHPMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly OKOGFPHGKMJ GFCOEBEBGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? PKBJAHBPNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? JIHJECMDCII;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool CKBJMDMJPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x850FD50", Offset = "0x850EF50", VA = "0x18850FD50", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool MADJAKIPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x850FB30", Offset = "0x850ED30", VA = "0x18850FB30", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool MIBPINGKICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x850FBD0", Offset = "0x850EDD0", VA = "0x18850FBD0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool HMDDMAHMNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x850FB80", Offset = "0x850ED80", VA = "0x18850FB80", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool LAOLCCNCLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x850F7A0", Offset = "0x850E9A0", VA = "0x18850F7A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool PGHINKGIFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x850FDA0", Offset = "0x850EFA0", VA = "0x18850FDA0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ODJGKIKFMEP IFHFGECABJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAACFF0", Offset = "0xAAC1F0", VA = "0x180AACFF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(ODJGKIKFMEP);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9F8320", Offset = "0x9F7520", VA = "0x1809F8320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string PAFBHFGKAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x850F7F0", Offset = "0x850E9F0", VA = "0x18850F7F0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x850F840", Offset = "0x850EA40", VA = "0x18850F840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string FECLJPBHHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x850F7F0", Offset = "0x850E9F0", VA = "0x18850F7F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool IHBHJCHEMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD8A840", Offset = "0xD89A40", VA = "0x180D8A840")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xD8A860", Offset = "0xD89A60", VA = "0x180D8A860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OONGCCOMDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x85101D0", Offset = "0x850F3D0", VA = "0x1885101D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public BOPNNAHOPKJ NIIHOELGJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x850FA40", Offset = "0x850EC40", VA = "0x18850FA40", Slot = "20")]
		get
		{
			return default(BOPNNAHOPKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LGDABLCBKBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x850FC40", Offset = "0x850EE40", VA = "0x18850FC40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FDNCKCHJDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x850FD00", Offset = "0x850EF00", VA = "0x18850FD00", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LCKKNHCKKEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x850F750", Offset = "0x850E950", VA = "0x18850F750", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool EJMGHOAGNPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x850EC90", Offset = "0x850DE90", VA = "0x18850EC90", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool LIEDHFCJENC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x850ED80", Offset = "0x850DF80", VA = "0x18850ED80", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool NJNKKMDOJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x850F940", Offset = "0x850EB40", VA = "0x18850F940", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool FMDKIAKMLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8510930", Offset = "0x850FB30", VA = "0x188510930", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool KIEBDJMKKMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x850ECE0", Offset = "0x850DEE0", VA = "0x18850ECE0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> AMLJPFCDIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x850F8E0", Offset = "0x850EAE0", VA = "0x18850F8E0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool PABBFDFPIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x850FD50", Offset = "0x850EF50", VA = "0x18850FD50", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool JJCJLFPDPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x850F7A0", Offset = "0x850E9A0", VA = "0x18850F7A0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool OPAGLNGKGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x850FB30", Offset = "0x850ED30", VA = "0x18850FB30", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool FDKGJGOAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x850ED30", Offset = "0x850DF30", VA = "0x18850ED30", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool AGAHAMGCKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x850F890", Offset = "0x850EA90", VA = "0x18850F890", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool LBKJJKNGLKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x850FBD0", Offset = "0x850EDD0", VA = "0x18850FBD0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool ECFNLJMLOJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x850FA90", Offset = "0x850EC90", VA = "0x18850FA90", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CKNDMIJHGBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x850FB80", Offset = "0x850ED80", VA = "0x18850FB80", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LJLMGOCGLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x850FDA0", Offset = "0x850EFA0", VA = "0x18850FDA0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HFDFECPHEPD<BMBHEAPGKKC> IJJDCLFFMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x85107A0", Offset = "0x850F9A0", VA = "0x1885107A0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x850F990", Offset = "0x850EB90", VA = "0x18850F990", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x35BB530", Offset = "0x35BA730", VA = "0x1835BB530", Slot = "6")]
	public (bool, T?) KFBJNDLIHEB<T>(BMBHEAPGKKC JEMKMMGBOPI) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x35BB4D0", Offset = "0x35BA6D0", VA = "0x1835BB4D0")]
	public BPCLIDDPAHH HJNBMEKNOID<T>(BMBHEAPGKKC JEMKMMGBOPI, bool KNLNPCEFPJN, T MLCDCHNOCFI) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8510B00", Offset = "0x850FD00", VA = "0x188510B00")]
	public BPCLIDDPAHH(ODJGKIKFMEP KPOGGIAFAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8510BA0", Offset = "0x850FDA0", VA = "0x188510BA0")]
	public BPCLIDDPAHH(ODJGKIKFMEP KPOGGIAFAJP, [Optional] string? PKBJAHBPNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8510B20", Offset = "0x850FD20", VA = "0x188510B20")]
	public BPCLIDDPAHH(BPCLIDDPAHH DIFNINBGAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8510BC0", Offset = "0x850FDC0", VA = "0x188510BC0")]
	internal BPCLIDDPAHH(ODJGKIKFMEP BKMIPPHHKEE, [Optional] string? PKBJAHBPNBC, [Optional] BPCLIDDPAHH? DIFNINBGAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x850FC90", Offset = "0x850EE90", VA = "0x18850FC90")]
	public static CHEBJNBGEBC IJBOKDBPMDE(BMBHEAPGKKC JEMKMMGBOPI)
	{
		return default(CHEBJNBGEBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x850FC20", Offset = "0x850EE20", VA = "0x18850FC20")]
	public void HFACLKNFIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8510420", Offset = "0x850F620", VA = "0x188510420")]
	internal BPCLIDDPAHH MOGCPGEODAD(BPCLIDDPAHH JHKAGJFMICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x850FDF0", Offset = "0x850EFF0", VA = "0x18850FDF0")]
	internal IReadOnlyCollection<BMBHEAPGKKC> MAHOJFGCJHM(BPCLIDDPAHH DIFNINBGAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8510850", Offset = "0x850FA50", VA = "0x188510850")]
	public bool OFOEBCFGOCH(BMBHEAPGKKC JEMKMMGBOPI, bool KNLNPCEFPJN, string EHGGJEMJANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8510980", Offset = "0x850FB80", VA = "0x188510980")]
	public (bool, string) PMPDGIBDEFF(BMBHEAPGKKC JEMKMMGBOPI)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x850FAE0", Offset = "0x850ECE0", VA = "0x18850FAE0")]
	internal void GBPELLCGKPG(BMBHEAPGKKC JEMKMMGBOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8510220", Offset = "0x850F420", VA = "0x188510220")]
	public JCBADNJLBNA MIAHOBKNAGO(Func<ODJGKIKFMEP, Guid> MCJKEHBBPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x850EDD0", Offset = "0x850DFD0", VA = "0x18850EDD0")]
	public void BOIHFCOPPDF(JCBADNJLBNA GMBHHDBFDJH, Func<Guid, ODJGKIKFMEP> HIMJBJDNMJL, [Optional] ODJGKIKFMEP? PFKBBJBEMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8510710", Offset = "0x850F910", VA = "0x188510710")]
	[CompilerGenerated]
	private void OBNBFCFJNCB(BMBHEAPGKKC AKJMPCHECLI, JKIEJHOAADF GFCCOPMMEHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class ANJCHKJAGDA : GJPJGLDADND, GELOLPBACFD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class PJGOJHFPMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public BPCLIDDPAHH newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PJGOJHFPMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8516DB0", Offset = "0x8515FB0", VA = "0x188516DB0")]
		internal bool IIIILJMEDDA(BPCLIDDPAHH rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MFDJBGNIPDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public ODJGKIKFMEP roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MFDJBGNIPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1C09A00", Offset = "0x1C08C00", VA = "0x181C09A00")]
		internal bool PNKHJIINBKB(ODJGKIKFMEP r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct MELHGBDKGHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public ANJCHKJAGDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CBMANFMCNIJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<CPHNLHDOFND> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8515530", Offset = "0x8514730", VA = "0x188515530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8515BA0", Offset = "0x8514DA0", VA = "0x188515BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class ELPOBECJGFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ELPOBECJGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8512C90", Offset = "0x8511E90", VA = "0x188512C90")]
		internal void FAJCCKDCDHB(JCBADNJLBNA r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8512B70", Offset = "0x8511D70", VA = "0x188512B70")]
		internal void BEHFDBAKLLB(JCBADNJLBNA r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct PILNOKLPIKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CBMANFMCNIJ roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NMHNLDIBAPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<JCBADNJLBNA, JKIEJHOAADF> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NMHNLDIBAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x85164B0", Offset = "0x85156B0", VA = "0x1885164B0")]
		internal void NMDHFFDHJGM(JCBADNJLBNA r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8516480", Offset = "0x8515680", VA = "0x188516480")]
		internal void LPOIDDKPKKH(JCBADNJLBNA r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8516450", Offset = "0x8515650", VA = "0x188516450")]
		internal void GEBJDFAFGNM(JCBADNJLBNA r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class PPMGLEKLFCE<T> where T : notnull
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
			public PPMGLEKLFCE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<CPHNLHDOFND> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x40C3570", Offset = "0x40C2770", VA = "0x1840C3570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public BMBHEAPGKKC rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public ODJGKIKFMEP accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CHEBJNBGEBC recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public ANJCHKJAGDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PPMGLEKLFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x563FF60", Offset = "0x563F160", VA = "0x18563FF60")]
		[AsyncStateMachine(typeof(PPMGLEKLFCE<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void OGHCJKMAGFP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GGAPLGMIFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<EBEFPKKIKEK> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HELNHACLCJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public LAPOOHDFFKP rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CBMANFMCNIJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<ODJGKIKFMEP, BPCLIDDPAHH> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public DECADMNPJIG debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8512F10", Offset = "0x8512110", VA = "0x188512F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8513A30", Offset = "0x8512C30", VA = "0x188513A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly LAPOOHDFFKP BFMIAHPOMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly LCKPFCPFAPE LNHAFNIFPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly DECADMNPJIG ICPFLHOEKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, BPCLIDDPAHH> LPGDPKNCAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<ODJGKIKFMEP, BPCLIDDPAHH> BCKEBJNGPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<ODJGKIKFMEP, BPCLIDDPAHH> AHGGHPONOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<BPCLIDDPAHH> OIJPAAIEFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool CBBPCPJADMB;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly BMBHEAPGKKC[] LHJGDIFDKMF;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public BPAFGBBHJGH IPLJMBJJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<DIKAFKMBKJE> OOOGDECBLDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8509FC0", Offset = "0x85091C0", VA = "0x188509FC0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event FHNCFNMKHFJ OBNHKCKMHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x850B410", Offset = "0x850A610", VA = "0x18850B410", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x850B4D0", Offset = "0x850A6D0", VA = "0x18850B4D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x850DB60", Offset = "0x850CD60", VA = "0x18850DB60")]
	[DBIDCJGLKKO.IJEBINAOMBK]
	internal static void NPCFNJKLMBL(HILJAABEPDC PHIACDDDGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x850E9D0", Offset = "0x850DBD0", VA = "0x18850E9D0")]
	[UnityEngine.Scripting.Preserve]
	internal ANJCHKJAGDA([ALHAHLCGLLK(null)] LAPOOHDFFKP ELDKFLLJACG, [ALHAHLCGLLK(null)] LCKPFCPFAPE MGNGOELBDEA, [ALHAHLCGLLK(null)] DECADMNPJIG ICPFLHOEKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x850B570", Offset = "0x850A770", VA = "0x18850B570", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x850A0B0", Offset = "0x85092B0", VA = "0x18850A0B0")]
	private void AIGPNLDLKPF(IEnumerable<BPCLIDDPAHH> GJPGBJIAEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x850A920", Offset = "0x8509B20", VA = "0x18850A920", Slot = "12")]
	public bool ANMBGGPDMPH(KPDBONCIMNC PNBFNEJFAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x850CC90", Offset = "0x850BE90", VA = "0x18850CC90")]
	private void INPBAIAMGOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x850C370", Offset = "0x850B570", VA = "0x18850C370")]
	private void IFOBDBDAFNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x850B920", Offset = "0x850AB20", VA = "0x18850B920", Slot = "10")]
	public IReadOnlyList<DIKAFKMBKJE> EDPLOOEFDAF(bool NMGOPIOHDNJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x850B050", Offset = "0x850A250", VA = "0x18850B050", Slot = "11")]
	public DIKAFKMBKJE AONLKHEMJLH(KPDBONCIMNC PNBFNEJFAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x850C010", Offset = "0x850B210", VA = "0x18850C010")]
	private ODJGKIKFMEP FEABGMBFOGE(KPDBONCIMNC PNBFNEJFAPC)
	{
		return default(ODJGKIKFMEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x850B160", Offset = "0x850A360", VA = "0x18850B160", Slot = "14")]
	public bool APLPHMFIFOK(KPDBONCIMNC HMEBBCAKILL, ODJGKIKFMEP KPOGGIAFAJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x850A010", Offset = "0x8509210", VA = "0x18850A010", Slot = "15")]
	public DIKAFKMBKJE AHOIIOMBJEJ(ODJGKIKFMEP KPOGGIAFAJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x850B9A0", Offset = "0x850ABA0", VA = "0x18850B9A0")]
	private static bool EFFLEFFIJDM(NNKCCICEACJ FADFEDGIDIO, ODJGKIKFMEP KPOGGIAFAJP, [Out] JCBADNJLBNA? JFEEPNAOFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x850CCA0", Offset = "0x850BEA0", VA = "0x18850CCA0")]
	private static void JIMKHAKHEKI(NNKCCICEACJ FADFEDGIDIO, Action<JCBADNJLBNA> JIAIOBGEAPI, ODJGKIKFMEP JLJLKLEIIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x850CD90", Offset = "0x850BF90", VA = "0x18850CD90")]
	private static void JIMKHAKHEKI(NNKCCICEACJ FADFEDGIDIO, Action<JCBADNJLBNA> JIAIOBGEAPI, Predicate<ODJGKIKFMEP> MJBNGGAHAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x850D360", Offset = "0x850C560", VA = "0x18850D360")]
	private void MJBJGBDPNLC(KPDBONCIMNC PNBFNEJFAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x850B2F0", Offset = "0x850A4F0", VA = "0x18850B2F0", Slot = "4")]
	[AsyncStateMachine(typeof(MELHGBDKGHL))]
	public Task DEHHBONLIHB([CanBeNull] CBMANFMCNIJ GIKGHELDAKC, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
	public void CCEMAAIFHPI(CBMANFMCNIJ GIKGHELDAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x850BCD0", Offset = "0x850AED0", VA = "0x18850BCD0")]
	private void EMGLOIAENHI(NNKCCICEACJ KLKENBCNDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x850AD40", Offset = "0x8509F40", VA = "0x18850AD40")]
	internal static string ANPGOHBNNKE(LAPOOHDFFKP BFMIAHPOMMP, CBMANFMCNIJ GIKGHELDAKC, IReadOnlyDictionary<ODJGKIKFMEP, BPCLIDDPAHH> BCKEBJNGPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8509260", Offset = "0x8508460", VA = "0x188509260")]
	private static void ABBCBBJMFHH(CBMANFMCNIJ GIKGHELDAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x850A9F0", Offset = "0x8509BF0", VA = "0x18850A9F0")]
	private static void ANNKGNNMDEJ(NNKCCICEACJ ABAIMCHOJIA, IReadOnlyDictionary<ODJGKIKFMEP, BPCLIDDPAHH> BCKEBJNGPHC, StringBuilder NDGOLEHJPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x850DF50", Offset = "0x850D150", VA = "0x18850DF50")]
	private static bool OMFBLKPAFJE(string LNPPEOMJKDP, [Out] Guid GLACNCKNPME, [Out] ODJGKIKFMEP KPOGGIAFAJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x850C560", Offset = "0x850B760", VA = "0x18850C560")]
	private static void IHJJBPFEGMN(CBMANFMCNIJ GIKGHELDAKC, StringBuilder NDGOLEHJPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4019E50", Offset = "0x4019050", VA = "0x184019E50", Slot = "16")]
	public bool HAAHIEMEAKK<T>(ODJGKIKFMEP KPOGGIAFAJP, BMBHEAPGKKC JEMKMMGBOPI, bool KNLNPCEFPJN, T HLMDGBFCIDH, [Optional] Action NGAHPPGKMOC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x850C300", Offset = "0x850B500", VA = "0x18850C300", Slot = "17")]
	public string HANBBCLPHHB(BMBHEAPGKKC JEMKMMGBOPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x850C0E0", Offset = "0x850B2E0", VA = "0x18850C0E0")]
	private void GCOIBLKLNLN(ODJGKIKFMEP KPOGGIAFAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x850B4B0", Offset = "0x850A6B0", VA = "0x18850B4B0")]
	private bool DKAKAMPCBKN(KPDBONCIMNC PNBFNEJFAPC, ODJGKIKFMEP KPOGGIAFAJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x850D020", Offset = "0x850C220", VA = "0x18850D020")]
	internal BPCLIDDPAHH KDPICKGJCPA(KPDBONCIMNC PNBFNEJFAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x850C2F0", Offset = "0x850B4F0", VA = "0x18850C2F0", Slot = "13")]
	public IReadOnlyList<DIKAFKMBKJE> GFAHAHNCHJM(KPDBONCIMNC PNBFNEJFAPC, bool ICDKAJOOHBN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x850DD20", Offset = "0x850CF20", VA = "0x18850DD20")]
	internal IReadOnlyList<BPCLIDDPAHH> OABLDDLCHNH(KPDBONCIMNC PNBFNEJFAPC, bool ICDKAJOOHBN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x850D3D0", Offset = "0x850C5D0", VA = "0x18850D3D0")]
	private void NAIHCOPPFMO(CPHNLHDOFND CEDHDKPMFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x850E060", Offset = "0x850D260", VA = "0x18850E060")]
	private static bool OMOILOJBENG(BPCLIDDPAHH OHKFCKMNNPG, IReadOnlyDictionary<ODJGKIKFMEP, BPCLIDDPAHH> BCKEBJNGPHC, [Out] IReadOnlyList<BMBHEAPGKKC> KLPNKHLICNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x850E340", Offset = "0x850D540", VA = "0x18850E340")]
	[AsyncStateMachine(typeof(HELNHACLCJL))]
	private static Task PCBPIJBJNAP(LAPOOHDFFKP BFMIAHPOMMP, CBMANFMCNIJ GIKGHELDAKC, IReadOnlyDictionary<ODJGKIKFMEP, BPCLIDDPAHH> BCKEBJNGPHC, DECADMNPJIG ICPFLHOEKBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x850B680", Offset = "0x850A880", VA = "0x18850B680")]
	[CompilerGenerated]
	internal static void EBHINDFBBEG(Func<JCBADNJLBNA, JKIEJHOAADF> OLIFDBJNLHC, PILNOKLPIKI P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x850E480", Offset = "0x850D680", VA = "0x18850E480")]
	[CompilerGenerated]
	internal static bool POCGDFHGNCB(ODJGKIKFMEP KPOGGIAFAJP, BMBHEAPGKKC JEMKMMGBOPI, [Out] EBEFPKKIKEK LCIHNLBDIEM, GGAPLGMIFNM P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface CGDJJFKGDAA
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEGGNNOOINH(KPDBONCIMNC GGCFJLIMOHF, KPDBONCIMNC NHNGKJECLMM, IEnumerable<KPDBONCIMNC> HGHKLJMOJGG, [Out] BOPNNAHOPKJ DHIPMOLDIFA, [Out] NPBJEDBLCKK MCGOHECHPLE);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string AIEJAGCDMOK(NPBJEDBLCKK PJLLNCGBPCN);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum NPBJEDBLCKK : byte
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
internal class NEIIPEHFDAP : CGDJJFKGDAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly GELOLPBACFD EPMMJLMMKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly NNHMMJEEAKM NHIALHGKIEL;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	[RecRoom.NoEngine.Common.Preserve]
	public NEIIPEHFDAP([ALHAHLCGLLK(null)] GELOLPBACFD FPNLIOOFPMP, [ALHAHLCGLLK(null)] NNHMMJEEAKM JHHCADKMAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8515D00", Offset = "0x8514F00", VA = "0x188515D00")]
	private static LJGFDKPJIBN? HEFDOGGGCNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8515D40", Offset = "0x8514F40", VA = "0x188515D40", Slot = "4")]
	public bool HEGGNNOOINH(KPDBONCIMNC GGCFJLIMOHF, KPDBONCIMNC NHNGKJECLMM, IEnumerable<KPDBONCIMNC> HGHKLJMOJGG, [Out] BOPNNAHOPKJ DHIPMOLDIFA, [Out] NPBJEDBLCKK MCGOHECHPLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8515C00", Offset = "0x8514E00", VA = "0x188515C00", Slot = "5")]
	public string AIEJAGCDMOK(NPBJEDBLCKK PJLLNCGBPCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8515E40", Offset = "0x8515040", VA = "0x188515E40")]
	internal bool NHDJGBFAPFI(KPDBONCIMNC GGCFJLIMOHF, KPDBONCIMNC NHNGKJECLMM, IEnumerable<KPDBONCIMNC> HGHKLJMOJGG, JKGEOIDCPBI GAGMCMAACOG, LJGFDKPJIBN? DDHCDDGDOCB, [Out] BOPNNAHOPKJ DHIPMOLDIFA, [Out] NPBJEDBLCKK MCGOHECHPLE)
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

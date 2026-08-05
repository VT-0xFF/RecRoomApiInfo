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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x73A9000", Offset = "0x73A7C00", VA = "0x1873A9000")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LKAEIDGNBJK
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
		[Cpp2IlInjected.Address(RVA = "0x73AB300", Offset = "0x73A9F00", VA = "0x1873AB300", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void DLBHKEIBOKD<TPermission>(TPermission KCHJNDEMFCA);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void CBKNNBDCKBI(JNNGHBDDOHB PMNDEDNNDFE);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JNEOAJPEPPD
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IGDMOEOOKCL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HOOIJIMFPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BPHBMNMNDKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PMHJBBEMHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PIGDOCGNPIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KOENLDADNLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MEMCMKHICGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class HIIIECABBFE
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum CNDGFCKPDKI
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
	public static readonly Guid DLBFIKFMGBA;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid FPBIMPCPBJL;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid PHCAPPBDMKM;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid EBMJKGFBBLN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid NNJNMKPHCEK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid LOIOPJKDODA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly BOCODBGPDEE<COEKCFMGBLF, Guid> ENEJCFNEHPF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<COEKCFMGBLF> PDICLAIINDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x73A7D30", Offset = "0x73A6930", VA = "0x1873A7D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x73A7CA0", Offset = "0x73A68A0", VA = "0x1873A7CA0")]
	public static COEKCFMGBLF KNCAHBIMJGI(Guid OCIHAODAEFD)
	{
		return default(COEKCFMGBLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x73A7AC0", Offset = "0x73A66C0", VA = "0x1873A7AC0")]
	public static Guid FJCADPBLLMK(COEKCFMGBLF DJGOPLFOHEO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x73A7C10", Offset = "0x73A6810", VA = "0x1873A7C10")]
	public static bool KDAIJIGNIDF(COEKCFMGBLF DJGOPLFOHEO, [Out] Guid OCIHAODAEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x73A79E0", Offset = "0x73A65E0", VA = "0x1873A79E0")]
	public static bool DILNCKFDEEC(Guid OCIHAODAEFD, [Out] COEKCFMGBLF DJGOPLFOHEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x73A79A0", Offset = "0x73A65A0", VA = "0x1873A79A0")]
	public static COEKCFMGBLF CIJKJALOPFM(COEKCFMGBLF DJGOPLFOHEO)
	{
		return default(COEKCFMGBLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x73A7B60", Offset = "0x73A6760", VA = "0x1873A7B60")]
	public static CNDGFCKPDKI GNHKOCCFCKC(COEKCFMGBLF PDMEOOGMNPE)
	{
		return default(CNDGFCKPDKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x73A7A80", Offset = "0x73A6680", VA = "0x1873A7A80")]
	internal static COEKCFMGBLF EOOLOIIHDKN(CNDGFCKPDKI NEDCIMNMHGD)
	{
		return default(COEKCFMGBLF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GJDKEAKALAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PGFBJGLPIGD AKMDLKBMJKL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<PBDKDCDPJJF> NODGFHAODGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CBKNNBDCKBI FPBMDKEBEGL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<PBDKDCDPJJF> IBAEOINGAHL(bool OEFJDDLGOKP = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PBDKDCDPJJF GFFGPJHFDAE(JNNGHBDDOHB PMNDEDNNDFE);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EEBFKPHBKFD(JNNGHBDDOHB PMNDEDNNDFE);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<PBDKDCDPJJF> LEJFAPOBCBK(JNNGHBDDOHB PMNDEDNNDFE, bool DBIHACNNGFB = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PFFOOIKDPNG(JNNGHBDDOHB HPCKJGAGHFH, COEKCFMGBLF DJGOPLFOHEO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PBDKDCDPJJF LDCHDAPFHGN(COEKCFMGBLF DJGOPLFOHEO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OGJELJMBKAB<T>(COEKCFMGBLF DJGOPLFOHEO, BBHFLBAFFBO KCHJNDEMFCA, bool EMFGOKFBDIK, T DHPKKMMKOFE, [Optional] Action CHFPFGONJOD) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string HMKHJDLHDNN(BBHFLBAFFBO KCHJNDEMFCA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IBDFEACNGPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DFDONDDHFKO(NJKJANBEOPF DJNINBEOIHC, CancellationToken CKKFHABGBNL);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAHJLOMMGLJ(NJKJANBEOPF DJNINBEOIHC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JLDLMDDONJA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JNNGHBDDOHB AJKMKMCLIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BNLKEKFCJDK CGEAKHFGNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DEDAENPLIGI GLKBNLMGJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<DBGOJKACCBA> GAMHFAIMKDB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PJGBCFMJEBP;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	COEKCFMGBLF DAPJAFMCLBE(JNNGHBDDOHB PMNDEDNNDFE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DBGOJKACCBA> AJKNMHJCNDP(CancellationToken CKKFHABGBNL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task HAKADDFCINL(long GLOFJPFEAOO, IReadOnlyList<KKDBHLLPIAF> DKFBKIGGBEM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task AJBJHCLGPIL(long GLOFJPFEAOO, long GPIHEOKIECF, IReadOnlyList<KKDBHLLPIAF> DKFBKIGGBEM);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<JNNGHBDDOHB> IKJLKAOKFDO();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BHNAKKALFJP
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x739CD80", Offset = "0x739B980", VA = "0x18739CD80")]
	public static COEKCFMGBLF CJNMCPBMIMC(this JLDLMDDONJA NNFEJCJFLGB)
	{
		return default(COEKCFMGBLF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GKHFALACNIM<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string AMJIDBOBGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event DLBHKEIBOKD<TPermission> LAIBHKLFEPB;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class KEFEGDJJFPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? HHMEKBKMBNH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? CPHBOBDNJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x73A8A80", Offset = "0x73A7680", VA = "0x1873A8A80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x73A8980", Offset = "0x73A7580", VA = "0x1873A8980")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x73A8B50", Offset = "0x73A7750", VA = "0x1873A8B50")]
	protected KEFEGDJJFPB(object? GPBIMJNGKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PCMHMJJJIIL(object? CABLCDOIFFL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OCBJJOGCFJD<T> : KEFEGDJJFPB where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> DMMDHIPDEFD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T PPPKGAOABBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x47977F0", Offset = "0x47963F0", VA = "0x1847977F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x47978D0", Offset = "0x47964D0", VA = "0x1847978D0", Slot = "4")]
	public override bool PCMHMJJJIIL(object? CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4797300", Offset = "0x4795F00", VA = "0x184797300")]
	public bool HINMBBIGIOO(T GDCEFKOPCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4797D50", Offset = "0x4796950", VA = "0x184797D50")]
	public OCBJJOGCFJD(T IEDAFAANJNE, IEqualityComparer<T> DMMDHIPDEFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class JOJCNHOGDFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<BBHFLBAFFBO, bool> AIPIAKMLBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<BBHFLBAFFBO, KEFEGDJJFPB> OGMBCICNIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FJIJEOGJKHA MJFPKGANABJ;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x73A86D0", Offset = "0x73A72D0", VA = "0x1873A86D0")]
	public JOJCNHOGDFM(FJIJEOGJKHA MJFPKGANABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x73A83F0", Offset = "0x73A6FF0", VA = "0x1873A83F0")]
	public bool HMKBFFMDCEN(BBHFLBAFFBO KCHJNDEMFCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3DC0", Offset = "0x2EA29C0", VA = "0x182EA3DC0")]
	public bool LHJPNIDANOD<T>(BBHFLBAFFBO KCHJNDEMFCA, bool EMFGOKFBDIK, T CABLCDOIFFL) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4340", Offset = "0x2EA2F40", VA = "0x182EA4340")]
	public (bool, T?) NHJONPLOKLJ<T>(BBHFLBAFFBO KCHJNDEMFCA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x73A8460", Offset = "0x73A7060", VA = "0x1873A8460")]
	public bool LHJPNIDANOD(BBHFLBAFFBO KCHJNDEMFCA, bool EMFGOKFBDIK, object CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x73A8540", Offset = "0x73A7140", VA = "0x1873A8540")]
	public (bool, object) NHJONPLOKLJ(BBHFLBAFFBO KCHJNDEMFCA)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3D60", Offset = "0x2EA2960", VA = "0x182EA3D60")]
	private void DFKPGEGNKCK<T>(BBHFLBAFFBO KCHJNDEMFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x73A8120", Offset = "0x73A6D20", VA = "0x1873A8120")]
	private KEFEGDJJFPB CEECAMAGJFM(BBHFLBAFFBO KCHJNDEMFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x73A81F0", Offset = "0x73A6DF0", VA = "0x1873A81F0")]
	public void HEPCPKEKBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class KEHENNFGBLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string MDADLGCDEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type GNEIBLCMHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly GGINFJBKKLI EGAMCIFKBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly BBHFLBAFFBO APAOOAANICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NLCFINLLHKC CBPFLAPDJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public BJJKAIDJPNB IOCEFGCHHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public KNFHNLBCBFL PEHNMICDCPC;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x73A8D50", Offset = "0x73A7950", VA = "0x1873A8D50")]
	public KEHENNFGBLM(Type EEGKLDPCKFG, string PDEMOMMIPEM, BBHFLBAFFBO KCHJNDEMFCA, NLCFINLLHKC HJFNGPCCLHP, BJJKAIDJPNB JBCAFDMCLHP, KNFHNLBCBFL HHMMHLOEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x73A8D00", Offset = "0x73A7900", VA = "0x1873A8D00")]
	public object LDFLFLHGIMM(object? FDOEIPBMJJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2EC6F90", Offset = "0x2EC5B90", VA = "0x182EC6F90")]
	public void DFKPGEGNKCK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x73A8C50", Offset = "0x73A7850", VA = "0x1873A8C50")]
	public void DFKPGEGNKCK(Type BHKNNIKCHCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class KNBEHKMAKGC<T> : KEHENNFGBLM where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string APKOHAKCGFA(T CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T OMGMAEHAEDO(string? HJLFANPGJBG, T IEDAFAANJNE);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PIIFOENOKAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public APKOHAKCGFA serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public OMGMAEHAEDO parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public PIIFOENOKAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x488E260", Offset = "0x488CE60", VA = "0x18488E260")]
		internal string LPJHGCEDCFM(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x488E1A0", Offset = "0x488CDA0", VA = "0x18488E1A0")]
		internal object HGCOEELFGPL(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x42D5F10", Offset = "0x42D4B10", VA = "0x1842D5F10")]
	public KNBEHKMAKGC(BBHFLBAFFBO KCHJNDEMFCA, string PDEMOMMIPEM, [Optional] APKOHAKCGFA? HJFNGPCCLHP, [Optional] OMGMAEHAEDO? JBCAFDMCLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x42D4DA0", Offset = "0x42D39A0", VA = "0x1842D4DA0")]
	private static object? ICHKPGLOBMP(OMGMAEHAEDO? JBCAFDMCLHP, string? HJLFANPGJBG, object? IEDAFAANJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x42D5350", Offset = "0x42D3F50", VA = "0x1842D5350")]
	private static string IMPFBNFMBKJ(APKOHAKCGFA? KDDLBJMNLFE, object? CABLCDOIFFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string NLCFINLLHKC(object? CABLCDOIFFL);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object BJJKAIDJPNB(string? HJLFANPGJBG, [Optional] object IEDAFAANJNE);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate KEFEGDJJFPB KNFHNLBCBFL();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class FJIJEOGJKHA
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class EAFIDMPIHCJ : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static EAFIDMPIHCJ AAGIFLNDKEI;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x739EEA0", Offset = "0x739DAA0", VA = "0x18739EEA0", Slot = "4")]
		public bool Equals(List<string> MBJABMPNEHF, List<string> MNMGCDILGBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x739EFF0", Offset = "0x739DBF0", VA = "0x18739EFF0", Slot = "5")]
		public int GetHashCode(List<string> PLAMADMDGIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public EAFIDMPIHCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class GLBLKIODHMJ : EPBLMOPKMBJ<LKAEIDGNBJK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x73A7870", Offset = "0x73A6470", VA = "0x1873A7870", Slot = "9")]
		public override string IMPFBNFMBKJ(LKAEIDGNBJK GKMKPBACAOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x73A7690", Offset = "0x73A6290", VA = "0x1873A7690", Slot = "10")]
		protected override bool EDEPEOFHMAG(string GKMKPBACAOC, [Out] LKAEIDGNBJK CABLCDOIFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x73A7960", Offset = "0x73A6560", VA = "0x1873A7960")]
		public GLBLKIODHMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly EMJALAONDMC KIAADCBLKCJ;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly GLBLKIODHMJ KELCEEHEHOI;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<KEHENNFGBLM> PKFFFIFJCFA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<BBHFLBAFFBO> DKCHEKBLIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<BBHFLBAFFBO, KEHENNFGBLM> PEBIFKFJMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x73A7370", Offset = "0x73A5F70", VA = "0x1873A7370")]
	public FJIJEOGJKHA([Optional] IList<KEHENNFGBLM>? CNAMAFBMDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73A5E60", Offset = "0x73A4A60", VA = "0x1873A5E60")]
	public KEHENNFGBLM IJLIBMAGNFI(BBHFLBAFFBO KCHJNDEMFCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PGFBJGLPIGD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PBDKDCDPJJF BJBKIFLODKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class ONHFCOCPJLK : PGFBJGLPIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static ONHFCOCPJLK PFHBAADPCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly CGNAAPKOBOE GPEGBDEEHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<CGNAAPKOBOE> OCAEGGPNNBI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public PBDKDCDPJJF BJBKIFLODKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x73A9F10", Offset = "0x73A8B10", VA = "0x1873A9F10")]
	public ONHFCOCPJLK(CGNAAPKOBOE KAPLKCHGMKN, IReadOnlyList<CGNAAPKOBOE> FAALHHEFHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x73A9080", Offset = "0x73A7C80", VA = "0x1873A9080")]
	private static ONHFCOCPJLK KIALLGLGCMM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class EOICAJGPDDE
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<COEKCFMGBLF> IBKLPLADFOI;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x73A0100", Offset = "0x739ED00", VA = "0x1873A0100")]
	public static bool EBPBECDLOBE(this JNNGHBDDOHB LPBGKGEIKDB, COEKCFMGBLF DJGOPLFOHEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x73A01E0", Offset = "0x739EDE0", VA = "0x1873A01E0")]
	public static bool LOBOJPFOPJE(this JNNGHBDDOHB LPBGKGEIKDB, COEKCFMGBLF DJGOPLFOHEO, DEDAENPLIGI DFPAFMLPFMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KHMJGBECDAA
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool OBLCNEOCMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LBJJAFFJBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool HMAILHLMELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool FMIEFJPPAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PMGMOKJPGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CPNJJKIDKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NEAOCOGGOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool IOOAPDFAPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool DBODCHFCALE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool KCJMKGGHCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool JFPOLJIIOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JBAENOPFEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> NADGHHNFDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LKAEIDGNBJK LMDEFBGHCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface PBDKDCDPJJF : KHMJGBECDAA, IGDMOEOOKCL, GKHFALACNIM<BBHFLBAFFBO>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string PKMFKKFBEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	COEKCFMGBLF LIKENBPKLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) LKCNNDKHJDP<T>(BBHFLBAFFBO KCHJNDEMFCA) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum BBHFLBAFFBO
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
	CAN_ADD_ROOM_BANS = 1018
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class CGNAAPKOBOE : PBDKDCDPJJF, KHMJGBECDAA, IGDMOEOOKCL, GKHFALACNIM<BBHFLBAFFBO>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly FJIJEOGJKHA BPPHNPJBPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly JOJCNHOGDFM EKLFMBCABPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? OBJNFKCEEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? MBLBGMAHEDP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool LMNMGIGLJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x739CE80", Offset = "0x739BA80", VA = "0x18739CE80", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool DCHACDANCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x739CED0", Offset = "0x739BAD0", VA = "0x18739CED0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool BDFKCFDKJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x739E1E0", Offset = "0x739CDE0", VA = "0x18739E1E0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool HKOJFJBDGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x739E250", Offset = "0x739CE50", VA = "0x18739E250", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool NFEFLLHNKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x739E2A0", Offset = "0x739CEA0", VA = "0x18739E2A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool OPBKGGEBPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x739D010", Offset = "0x739BC10", VA = "0x18739D010", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public COEKCFMGBLF LIKENBPKLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA22440", Offset = "0xA21040", VA = "0x180A22440", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(COEKCFMGBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x892E30", Offset = "0x891A30", VA = "0x180892E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string AMJIDBOBGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x739CF70", Offset = "0x739BB70", VA = "0x18739CF70", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x739CFC0", Offset = "0x739BBC0", VA = "0x18739CFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string PKMFKKFBEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x739CF70", Offset = "0x739BB70", VA = "0x18739CF70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool AOFAPONAFDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA22400", Offset = "0xA21000", VA = "0x180A22400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xB9D5C0", Offset = "0xB9C1C0", VA = "0x180B9D5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OBLCNEOCMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x739D0B0", Offset = "0x739BCB0", VA = "0x18739D0B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LKAEIDGNBJK LMDEFBGHCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x739E2F0", Offset = "0x739CEF0", VA = "0x18739E2F0", Slot = "20")]
		get
		{
			return default(LKAEIDGNBJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LBJJAFFJBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x739E540", Offset = "0x739D140", VA = "0x18739E540", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool HMAILHLMELC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x739EBC0", Offset = "0x739D7C0", VA = "0x18739EBC0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool FMIEFJPPAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x739D060", Offset = "0x739BC60", VA = "0x18739D060", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool PMGMOKJPGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x739E140", Offset = "0x739CD40", VA = "0x18739E140", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CPNJJKIDKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x739DAD0", Offset = "0x739C6D0", VA = "0x18739DAD0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool NEAOCOGGOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x739EB10", Offset = "0x739D710", VA = "0x18739EB10", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool IOOAPDFAPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x739E190", Offset = "0x739CD90", VA = "0x18739E190", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool DBODCHFCALE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x739CF20", Offset = "0x739BB20", VA = "0x18739CF20", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> NADGHHNFDBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x739EB60", Offset = "0x739D760", VA = "0x18739EB60", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GGCJCEHMNEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x739CE80", Offset = "0x739BA80", VA = "0x18739CE80", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool CBPBDFKNDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x739E2A0", Offset = "0x739CEA0", VA = "0x18739E2A0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool JOFIJGGHPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x739CED0", Offset = "0x739BAD0", VA = "0x18739CED0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool KCJMKGGHCHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x739DBD0", Offset = "0x739C7D0", VA = "0x18739DBD0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JFPOLJIIOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x739DA80", Offset = "0x739C680", VA = "0x18739DA80", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool CPAFNGBLNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x739E1E0", Offset = "0x739CDE0", VA = "0x18739E1E0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JBAENOPFEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x739DC20", Offset = "0x739C820", VA = "0x18739DC20", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LDEIFIGDEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x739E250", Offset = "0x739CE50", VA = "0x18739E250", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OODKAPJGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x739D010", Offset = "0x739BC10", VA = "0x18739D010", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event DLBHKEIBOKD<BBHFLBAFFBO> LAIBHKLFEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x739DB20", Offset = "0x739C720", VA = "0x18739DB20", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x739E770", Offset = "0x739D370", VA = "0x18739E770", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2C00510", Offset = "0x2BFF110", VA = "0x182C00510", Slot = "6")]
	public (bool, T?) LKCNNDKHJDP<T>(BBHFLBAFFBO KCHJNDEMFCA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2C004B0", Offset = "0x2BFF0B0", VA = "0x182C004B0")]
	public CGNAAPKOBOE JMEINDCNDNN<T>(BBHFLBAFFBO KCHJNDEMFCA, bool EMFGOKFBDIK, T CABLCDOIFFL) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x739EC90", Offset = "0x739D890", VA = "0x18739EC90")]
	public CGNAAPKOBOE(COEKCFMGBLF DJGOPLFOHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x739ED30", Offset = "0x739D930", VA = "0x18739ED30")]
	public CGNAAPKOBOE(COEKCFMGBLF DJGOPLFOHEO, [Optional] string? OBJNFKCEEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x739ECB0", Offset = "0x739D8B0", VA = "0x18739ECB0")]
	public CGNAAPKOBOE(CGNAAPKOBOE HAOJHCGDKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x739ED50", Offset = "0x739D950", VA = "0x18739ED50")]
	internal CGNAAPKOBOE(COEKCFMGBLF DMOKIHCMODK, [Optional] string? OBJNFKCEEBH, [Optional] CGNAAPKOBOE? HAOJHCGDKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x739CE10", Offset = "0x739BA10", VA = "0x18739CE10")]
	public static GGINFJBKKLI ACHPJLOOBCK(BBHFLBAFFBO KCHJNDEMFCA)
	{
		return default(GGINFJBKKLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x739E230", Offset = "0x739CE30", VA = "0x18739E230")]
	public void HEPCPKEKBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x739E820", Offset = "0x739D420", VA = "0x18739E820")]
	internal CGNAAPKOBOE MBHBMGCLFJG(CGNAAPKOBOE AFDBGPMNOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x739DC70", Offset = "0x739C870", VA = "0x18739DC70")]
	internal IReadOnlyCollection<BBHFLBAFFBO> GBKEAFBIGGC(CGNAAPKOBOE HAOJHCGDKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x739E060", Offset = "0x739CC60", VA = "0x18739E060")]
	public bool GJNGCOCKGFG(BBHFLBAFFBO KCHJNDEMFCA, bool EMFGOKFBDIK, string OBONPLFBAOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x739E590", Offset = "0x739D190", VA = "0x18739E590")]
	public (bool, string) JGAAOHHAAEB(BBHFLBAFFBO KCHJNDEMFCA)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x739E690", Offset = "0x739D290", VA = "0x18739E690")]
	internal void JIDBCCGBDNE(BBHFLBAFFBO KCHJNDEMFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x739E340", Offset = "0x739CF40", VA = "0x18739E340")]
	public GDLHGCPNMPP IADCMOOOFFG(Func<COEKCFMGBLF, Guid> EGJGBJKBIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x739D100", Offset = "0x739BD00", VA = "0x18739D100")]
	public void EAIPBLIBBJG(GDLHGCPNMPP PFJNCHGMPML, Func<Guid, COEKCFMGBLF> GJKNFEIMIAC, [Optional] COEKCFMGBLF? PCGOFCGOCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x739E6E0", Offset = "0x739D2E0", VA = "0x18739E6E0")]
	[CompilerGenerated]
	private void JMFMCOCCOIJ(BBHFLBAFFBO GLNPAEHFBLP, GNDHAPJAJEA GEMLANMMJGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FHKGPEOEJPH : IBDFEACNGPJ, GJDKEAKALAI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class BPMCHBOCPLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CGNAAPKOBOE newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public BPMCHBOCPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x739CDE0", Offset = "0x739B9E0", VA = "0x18739CDE0")]
		internal bool MNLNMHLKGNJ(CGNAAPKOBOE rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class KOBMCAFILDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public COEKCFMGBLF roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public KOBMCAFILDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x73A8DF0", Offset = "0x73A79F0", VA = "0x1873A8DF0")]
		internal bool CAJGDNKPHEK(COEKCFMGBLF r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct EALCCHGOIGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FHKGPEOEJPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NJKJANBEOPF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<DBGOJKACCBA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x739F1D0", Offset = "0x739DDD0", VA = "0x18739F1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x739F840", Offset = "0x739E440", VA = "0x18739F840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class LCIHKLADKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public LCIHKLADKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x73A8E00", Offset = "0x73A7A00", VA = "0x1873A8E00")]
		internal void GIDDGEMHDEC(GDLHGCPNMPP r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x73A8EE0", Offset = "0x73A7AE0", VA = "0x1873A8EE0")]
		internal void HNKJLOAFMCC(GDLHGCPNMPP r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct HLJBGDKHPNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public NJKJANBEOPF roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IFFIMPMCJCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<GDLHGCPNMPP, GNDHAPJAJEA> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public IFFIMPMCJCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x73A80C0", Offset = "0x73A6CC0", VA = "0x1873A80C0")]
		internal void EGHIKPLLNIA(GDLHGCPNMPP r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x73A8090", Offset = "0x73A6C90", VA = "0x1873A8090")]
		internal void BECBOEMGELF(GDLHGCPNMPP r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x73A80F0", Offset = "0x73A6CF0", VA = "0x1873A80F0")]
		internal void NDDHDPLDKKF(GDLHGCPNMPP r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class APOMKNCEGPI<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public APOMKNCEGPI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<DBGOJKACCBA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x37846D0", Offset = "0x37832D0", VA = "0x1837846D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public BBHFLBAFFBO rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public COEKCFMGBLF accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public GGINFJBKKLI recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public FHKGPEOEJPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public APOMKNCEGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4064A30", Offset = "0x4063630", VA = "0x184064A30")]
		[AsyncStateMachine(typeof(APOMKNCEGPI<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void NFCEKHLGNCN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JPJPIJJOPIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<KKDBHLLPIAF> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct POPAOPHLAIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public JLDLMDDONJA rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public NJKJANBEOPF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<COEKCFMGBLF, CGNAAPKOBOE> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public PCJJBDFPBKI debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x73AA020", Offset = "0x73A8C20", VA = "0x1873AA020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x73AAB40", Offset = "0x73A9740", VA = "0x1873AAB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly JLDLMDDONJA NNFEJCJFLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly ONHFCOCPJLK IDIGKELGAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly PCJJBDFPBKI JKNBMKCLLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, CGNAAPKOBOE> KGMFAGOMCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<COEKCFMGBLF, CGNAAPKOBOE> DHFOFKDIOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<COEKCFMGBLF, CGNAAPKOBOE> ILGFGAMADEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<CGNAAPKOBOE> HDKCCELOKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool MEMAGCOCCGI;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly BBHFLBAFFBO[] MGCHADJDFJH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public PGFBJGLPIGD AKMDLKBMJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<PBDKDCDPJJF> NODGFHAODGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x73A4BF0", Offset = "0x73A37F0", VA = "0x1873A4BF0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event CBKNNBDCKBI FPBMDKEBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x73A4F10", Offset = "0x73A3B10", VA = "0x1873A4F10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x73A4B50", Offset = "0x73A3750", VA = "0x1873A4B50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x73A4C40", Offset = "0x73A3840", VA = "0x1873A4C40")]
	[BOLBLOCFHKO.HNILJJLDPFA]
	internal static void NPEAJDJKCFF(EAEKKMJPCLA AFCCBOCJBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x73A5BA0", Offset = "0x73A47A0", VA = "0x1873A5BA0")]
	[UnityEngine.Scripting.Preserve]
	internal FHKGPEOEJPH([JGAMIMHCGFI(null)] JLDLMDDONJA HNFBJAFMCJL, [JGAMIMHCGFI(null)] ONHFCOCPJLK KELLMIFGFLI, [JGAMIMHCGFI(null)] PCJJBDFPBKI JKNBMKCLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x73A10E0", Offset = "0x739FCE0", VA = "0x1873A10E0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x73A4FB0", Offset = "0x73A3BB0", VA = "0x1873A4FB0")]
	private void PFDNFAMKCDB(IEnumerable<CGNAAPKOBOE> NGGMKLAJIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x73A1260", Offset = "0x739FE60", VA = "0x1873A1260", Slot = "12")]
	public bool EEBFKPHBKFD(JNNGHBDDOHB PMNDEDNNDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x73A59C0", Offset = "0x73A45C0", VA = "0x1873A59C0")]
	private void PJGBCFMJEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x73A1680", Offset = "0x73A0280", VA = "0x1873A1680")]
	private void EGHIBJHKIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x73A3160", Offset = "0x73A1D60", VA = "0x1873A3160", Slot = "10")]
	public IReadOnlyList<PBDKDCDPJJF> IBAEOINGAHL(bool OEFJDDLGOKP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x73A2FE0", Offset = "0x73A1BE0", VA = "0x1873A2FE0", Slot = "11")]
	public PBDKDCDPJJF GFFGPJHFDAE(JNNGHBDDOHB PMNDEDNNDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x73A4A80", Offset = "0x73A3680", VA = "0x1873A4A80")]
	private COEKCFMGBLF MIHKFOOCJHC(JNNGHBDDOHB PMNDEDNNDFE)
	{
		return default(COEKCFMGBLF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x73A5830", Offset = "0x73A4430", VA = "0x1873A5830", Slot = "14")]
	public bool PFFOOIKDPNG(JNNGHBDDOHB HPCKJGAGHFH, COEKCFMGBLF DJGOPLFOHEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x73A39D0", Offset = "0x73A25D0", VA = "0x1873A39D0", Slot = "15")]
	public PBDKDCDPJJF LDCHDAPFHGN(COEKCFMGBLF DJGOPLFOHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x73A36A0", Offset = "0x73A22A0", VA = "0x1873A36A0")]
	private static bool LCIPCGOLNBP(IFCPDGENOJH KOPMEJGLDNG, COEKCFMGBLF DJGOPLFOHEO, [Out] GDLHGCPNMPP? KECGNDFMJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x73A3470", Offset = "0x73A2070", VA = "0x1873A3470")]
	private static void IPCFIGHBCDD(IFCPDGENOJH KOPMEJGLDNG, Action<GDLHGCPNMPP> GOLPEJCHLKD, COEKCFMGBLF OHONHHNIDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x73A31E0", Offset = "0x73A1DE0", VA = "0x1873A31E0")]
	private static void IPCFIGHBCDD(IFCPDGENOJH KOPMEJGLDNG, Action<GDLHGCPNMPP> GOLPEJCHLKD, Predicate<COEKCFMGBLF> ENFLLBNJNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x73A11F0", Offset = "0x739FDF0", VA = "0x1873A11F0")]
	private void EBLINMGCACG(JNNGHBDDOHB PMNDEDNNDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x73A0D90", Offset = "0x739F990", VA = "0x1873A0D90", Slot = "4")]
	[AsyncStateMachine(typeof(EALCCHGOIGK))]
	public Task DFDONDDHFKO([CanBeNull] NJKJANBEOPF DJNINBEOIHC, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
	public void AAHJLOMMGLJ(NJKJANBEOPF DJNINBEOIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x73A1A80", Offset = "0x73A0680", VA = "0x1873A1A80")]
	private void EGOGGLALEGG(IFCPDGENOJH APNMENADOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x73A0420", Offset = "0x739F020", VA = "0x1873A0420")]
	internal static string BLNHAELEKFG(JLDLMDDONJA NNFEJCJFLGB, NJKJANBEOPF DJNINBEOIHC, IReadOnlyDictionary<COEKCFMGBLF, CGNAAPKOBOE> DHFOFKDIOAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x73A3A80", Offset = "0x73A2680", VA = "0x1873A3A80")]
	private static void LGJKDBGABNL(NJKJANBEOPF DJNINBEOIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x73A1330", Offset = "0x739FF30", VA = "0x1873A1330")]
	private static void EFCBCDABDML(IFCPDGENOJH NKLCHOKPMKO, IReadOnlyDictionary<COEKCFMGBLF, CGNAAPKOBOE> DHFOFKDIOAE, StringBuilder HCEFOKKADIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x73A4E00", Offset = "0x73A3A00", VA = "0x1873A4E00")]
	private static bool OEGDCMGAHLO(string CDKHINIHJCH, [Out] Guid MGCPBMCDHGF, [Out] COEKCFMGBLF DJGOPLFOHEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x73A1DC0", Offset = "0x73A09C0", VA = "0x1873A1DC0")]
	private static void FBLHJODPKCO(NJKJANBEOPF DJNINBEOIHC, StringBuilder HCEFOKKADIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9FA0", Offset = "0x2DE8BA0", VA = "0x182DE9FA0", Slot = "16")]
	public bool OGJELJMBKAB<T>(COEKCFMGBLF DJGOPLFOHEO, BBHFLBAFFBO KCHJNDEMFCA, bool EMFGOKFBDIK, T DHPKKMMKOFE, [Optional] Action CHFPFGONJOD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x73A30F0", Offset = "0x73A1CF0", VA = "0x1873A30F0", Slot = "17")]
	public string HMKHJDLHDNN(BBHFLBAFFBO KCHJNDEMFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x73A1870", Offset = "0x73A0470", VA = "0x1873A1870")]
	private void EGLPONHMLHN(COEKCFMGBLF DJGOPLFOHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x73A0400", Offset = "0x739F000", VA = "0x1873A0400")]
	private bool BEEGKCJINLK(JNNGHBDDOHB PMNDEDNNDFE, COEKCFMGBLF DJGOPLFOHEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x73A2500", Offset = "0x73A1100", VA = "0x1873A2500")]
	internal CGNAAPKOBOE FGJEKDAJPDM(JNNGHBDDOHB PMNDEDNNDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x73A3A70", Offset = "0x73A2670", VA = "0x1873A3A70", Slot = "13")]
	public IReadOnlyList<PBDKDCDPJJF> LEJFAPOBCBK(JNNGHBDDOHB PMNDEDNNDFE, bool DBIHACNNGFB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x73A0EB0", Offset = "0x739FAB0", VA = "0x1873A0EB0")]
	internal IReadOnlyList<CGNAAPKOBOE> DJNPMDGENJA(JNNGHBDDOHB PMNDEDNNDFE, bool DBIHACNNGFB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x73A2850", Offset = "0x73A1450", VA = "0x1873A2850")]
	private void FNEBIBIKALM(DBGOJKACCBA NJDKHCHJIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x73A0AB0", Offset = "0x739F6B0", VA = "0x1873A0AB0")]
	private static bool DCGNAIFOFFG(CGNAAPKOBOE PPPFBGHIKII, IReadOnlyDictionary<COEKCFMGBLF, CGNAAPKOBOE> DHFOFKDIOAE, [Out] IReadOnlyList<BBHFLBAFFBO> NAMLHMGMHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x73A3560", Offset = "0x73A2160", VA = "0x1873A3560")]
	[AsyncStateMachine(typeof(POPAOPHLAIO))]
	private static Task KJNLICCFMNM(JLDLMDDONJA NNFEJCJFLGB, NJKJANBEOPF DJNINBEOIHC, IReadOnlyDictionary<COEKCFMGBLF, CGNAAPKOBOE> DHFOFKDIOAE, PCJJBDFPBKI JKNBMKCLLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x73A47E0", Offset = "0x73A33E0", VA = "0x1873A47E0")]
	[CompilerGenerated]
	internal static void LKBHBNFDOGE(Func<GDLHGCPNMPP, GNDHAPJAJEA> AOFBPBABGGD, HLJBGDKHPNP P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x73A0730", Offset = "0x739F330", VA = "0x1873A0730")]
	[CompilerGenerated]
	internal static bool DBPOPABLNPN(COEKCFMGBLF DJGOPLFOHEO, BBHFLBAFFBO KCHJNDEMFCA, [Out] KKDBHLLPIAF HPAAMFDAALF, JPJPIJJOPIG P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface CCEKOEMCOIP
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CMIPGBJNBCB(JNNGHBDDOHB ICNKAAHOPBA, JNNGHBDDOHB PBKJGIHGKFK, IEnumerable<JNNGHBDDOHB> GJDGADIPGLD, [Out] LKAEIDGNBJK OEIHMOIPIEI, [Out] CBHDHLFOMFL HGPJBGHLMDH);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string LDEAOHAKBFC(CBHDHLFOMFL KNOCLOMEIMM);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum CBHDHLFOMFL : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class EMHACNILGLF : CCEKOEMCOIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly GJDKEAKALAI DKANPEDPAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly CGFNMJJMEFP LNGALJMPFLB;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x887A10", Offset = "0x886610", VA = "0x180887A10")]
	[RecRoom.NoEngine.Common.Preserve]
	public EMHACNILGLF([JGAMIMHCGFI(null)] GJDKEAKALAI LGLLCBDBLGJ, [JGAMIMHCGFI(null)] CGFNMJJMEFP LMHPBNJJAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x739FFC0", Offset = "0x739EBC0", VA = "0x18739FFC0")]
	private static ILKPFMBHNJM? FMMEHNIOCON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x739FEC0", Offset = "0x739EAC0", VA = "0x18739FEC0", Slot = "4")]
	public bool CMIPGBJNBCB(JNNGHBDDOHB ICNKAAHOPBA, JNNGHBDDOHB PBKJGIHGKFK, IEnumerable<JNNGHBDDOHB> GJDGADIPGLD, [Out] LKAEIDGNBJK OEIHMOIPIEI, [Out] CBHDHLFOMFL HGPJBGHLMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x73A0000", Offset = "0x739EC00", VA = "0x1873A0000", Slot = "5")]
	public string LDEAOHAKBFC(CBHDHLFOMFL KNOCLOMEIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x739F8A0", Offset = "0x739E4A0", VA = "0x18739F8A0")]
	internal bool BFIDDEJLHLG(JNNGHBDDOHB ICNKAAHOPBA, JNNGHBDDOHB PBKJGIHGKFK, IEnumerable<JNNGHBDDOHB> GJDGADIPGLD, DEDAENPLIGI DFPAFMLPFMP, ILKPFMBHNJM? HFMBBCPPOHA, [Out] LKAEIDGNBJK OEIHMOIPIEI, [Out] CBHDHLFOMFL HGPJBGHLMDH)
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

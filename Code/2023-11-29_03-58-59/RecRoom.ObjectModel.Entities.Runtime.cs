using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5EE4C90", Offset = "0x5EE4090", VA = "0x185EE4C90")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class AMLGJDINHAF<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] AANBLFPMIKL;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x20DEBE0", Offset = "0x20DDFE0", VA = "0x1820DEBE0")]
	public static void DNNGBDOKCBE<TField>(int DIENMHDGFGP, string MDFAJJKMBAI, IJEFMLHBHIL MONJDCAOMGD, [Out] IGMLEMKENNP<TField> PGPOOACGDAP) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20E1410", Offset = "0x20E0810", VA = "0x1820E1410")]
	public static void FFCGNNCDHLL<TField>(int DIENMHDGFGP, string MDFAJJKMBAI, [Out] LFAGCJKBKCF<TField> JJOBNGACPHH) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class BKMKDOLGGAC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EE45D0", Offset = "0x5EE39D0", VA = "0x185EE45D0")]
	public static FieldInfo[] HNIJAKIBOHD(Type LFLAEPCPMDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class HHMCCNEFLHO<View, Data> : MKBKEJFIDNL where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType NPEDPDCFMII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type HDNINBHNHAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x35FCC40", Offset = "0x35FC040", VA = "0x1835FCC40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int HOFOODBNGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x35FA010", Offset = "0x35F9410", VA = "0x1835FA010", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x35FA480", Offset = "0x35F9880", VA = "0x1835FA480")]
	public Data IABCNAGKCJI(Entity HPMKKHPHJEE)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View DBMHICPLCAC(Entity HPMKKHPHJEE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2E2FDD0", Offset = "0x2E2F1D0", VA = "0x182E2FDD0", Slot = "14")]
	public override T DBMHICPLCAC<T>(Entity HPMKKHPHJEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
	protected HHMCCNEFLHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class MKBKEJFIDNL : IJEFMLHBHIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle FNMPNGIAGIC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager JBCKLBHEAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1245EC0", Offset = "0x12452C0", VA = "0x181245EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type HDNINBHNHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int HOFOODBNGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type CAEKJNAEEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x962770", Offset = "0x961B70", VA = "0x180962770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int NFCHIJKHAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5AA0", Offset = "0x5EE4EA0", VA = "0x185EE5AA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private BHLONKBJEEN[] OELLOLADKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D18AF0", Offset = "0x3D17EF0", VA = "0x183D18AF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual BHLONKBJEEN[] PJJPDIKMALL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5A10", Offset = "0x5EE4E10", VA = "0x185EE5A10", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5C00", Offset = "0x5EE5000", VA = "0x185EE5C00")]
	public void GJHPIDDJMKM(EntityManager LPAJKOAHLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T DBMHICPLCAC<T>(Entity HPMKKHPHJEE) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5B10", Offset = "0x5EE4F10", VA = "0x185EE5B10", Slot = "8")]
	public (uint, uint) BKJCJOMPHLM(Entity HPMKKHPHJEE)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5920", Offset = "0x5EE4D20", VA = "0x185EE5920", Slot = "9")]
	public bool ANBGGMELADF(Entity HPMKKHPHJEE, (uint order, uint change) AJLAIKHEKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	protected MKBKEJFIDNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IKEMJGPHHIH
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EDGPEACGGBN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FANDAOKFPNJ BLAMBJHHNOG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GGGBNADCKOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FOHJPGKGKGM(Entity HPMKKHPHJEE, object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BCPICGCOADI(Entity HPMKKHPHJEE, object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ECGMHLLIGMD(Entity HPMKKHPHJEE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ODBFPPDCPGP(Entity HPMKKHPHJEE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IDEMBMNEGFM<TComponentData, TValue> : IPAKNBEDMHL<TValue>, IDisposable where TComponentData : struct, EDGPEACGGBN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class NCPCBIDMLLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> HAPGAOAPCEH;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int AEFHJLMLIJL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2F860A0", Offset = "0x2F854A0", VA = "0x182F860A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B180", Offset = "0x3D1A580", VA = "0x183D1B180")]
		public bool PADMPCCLLMJ([Out] TValue NMENOOMOOJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B050", Offset = "0x3D1A450", VA = "0x183D1B050")]
		public void BKKEPFPDOJH(object NOEAHPPKHNC, TValue NMENOOMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B100", Offset = "0x3D1A500", VA = "0x183D1B100")]
		public bool HBMDGHADMGB(object NOEAHPPKHNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3D1AF70", Offset = "0x3D1A370", VA = "0x183D1AF70")]
		public int AGBMHGFHFBJ(object NOEAHPPKHNC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B270", Offset = "0x3D1A670", VA = "0x183D1B270")]
		public NCPCBIDMLLI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<NCPCBIDMLLI> MACJLFEOEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private KCGAOGIEEHN<FANDAOKFPNJ, NCPCBIDMLLI> EIMHGHIKPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager LPAJKOAHLHJ;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3737B30", Offset = "0x3736F30", VA = "0x183737B30")]
	public IDEMBMNEGFM(EntityManager LPAJKOAHLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x37376B0", Offset = "0x3736AB0", VA = "0x1837376B0", Slot = "4")]
	public void FOHJPGKGKGM(Entity HPMKKHPHJEE, object NOEAHPPKHNC, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x37373E0", Offset = "0x37367E0", VA = "0x1837373E0", Slot = "5")]
	public bool BCPICGCOADI(Entity HPMKKHPHJEE, object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3737A30", Offset = "0x3736E30", VA = "0x183737A30", Slot = "6")]
	public bool PADMPCCLLMJ(Entity HPMKKHPHJEE, [Out] TValue NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3737580", Offset = "0x3736980", VA = "0x183737580", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x37377F0", Offset = "0x3736BF0", VA = "0x1837377F0")]
	private void GNJKNMCFNCH(NCPCBIDMLLI OPFKOJBALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3737880", Offset = "0x3736C80", VA = "0x183737880")]
	private bool IPDILMLOJIA(Entity HPMKKHPHJEE, [Out] FANDAOKFPNJ GLPBINKHJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x37375A0", Offset = "0x37369A0", VA = "0x1837375A0")]
	private void EDBHCAFNNNC(Entity HPMKKHPHJEE, FANDAOKFPNJ GLPBINKHJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3737690", Offset = "0x3736A90", VA = "0x183737690")]
	private bool EDGOEPLMDPC(FANDAOKFPNJ GLPBINKHJFN, [Out] NCPCBIDMLLI OPFKOJBALOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3737940", Offset = "0x3736D40", VA = "0x183737940")]
	private NCPCBIDMLLI MDFAOCFAAIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IPAKNBEDMHL<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOHJPGKGKGM(Entity HPMKKHPHJEE, object NOEAHPPKHNC, TValue NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BCPICGCOADI(Entity HPMKKHPHJEE, object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PADMPCCLLMJ(Entity HPMKKHPHJEE, [Out] TValue NMENOOMOOJP);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FANDAOKFPNJ : LBFGJMACCDO, IEquatable<FANDAOKFPNJ>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly FANDAOKFPNJ KIPGGFDKPNJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int FFCPNJCJDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86A070", Offset = "0x869470", VA = "0x18086A070", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x869F80", Offset = "0x869380", VA = "0x180869F80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int PJEJHIMPGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x20A07C0", Offset = "0x209FBC0", VA = "0x1820A07C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5304080", Offset = "0x5303480", VA = "0x185304080", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4CB0", Offset = "0x5EE40B0", VA = "0x185EE4CB0", Slot = "8")]
	public bool Equals(FANDAOKFPNJ LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4D00", Offset = "0x5EE4100", VA = "0x185EE4D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IGGGJGPIDCM<THasTokensTag> : GGGBNADCKOL, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GBIKKFKHKKF BLHBFCHIDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, FANDAOKFPNJ> KDJOMBCBJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> MACJLFEOEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private KCGAOGIEEHN<FANDAOKFPNJ, HashSet<object>> EIMHGHIKPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager LPAJKOAHLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem IFMOJGCCOGE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3748110", Offset = "0x3747510", VA = "0x183748110")]
	public IGGGJGPIDCM(EntityManager LPAJKOAHLHJ, EntityCommandBufferSystem IFMOJGCCOGE, GBIKKFKHKKF OMNJPFACPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3746200", Offset = "0x3745600", VA = "0x183746200", Slot = "4")]
	public bool FOHJPGKGKGM(Entity HPMKKHPHJEE, object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3744E10", Offset = "0x3744210", VA = "0x183744E10", Slot = "5")]
	public bool BCPICGCOADI(Entity HPMKKHPHJEE, object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3745510", Offset = "0x3744910", VA = "0x183745510", Slot = "6")]
	public bool ECGMHLLIGMD(Entity HPMKKHPHJEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3745700", Offset = "0x3744B00", VA = "0x183745700", Slot = "9")]
	public bool ECGMHLLIGMD(FANDAOKFPNJ GLPBINKHJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3747E10", Offset = "0x3747210", VA = "0x183747E10", Slot = "7")]
	public bool ODBFPPDCPGP(Entity HPMKKHPHJEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3745490", Offset = "0x3744890", VA = "0x183745490", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3746A80", Offset = "0x3745E80", VA = "0x183746A80")]
	private void GNJKNMCFNCH(HashSet<object> OPFKOJBALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3746BD0", Offset = "0x3745FD0", VA = "0x183746BD0")]
	private bool IPDILMLOJIA(Entity HPMKKHPHJEE, [Out] FANDAOKFPNJ GLPBINKHJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3747A90", Offset = "0x3746E90", VA = "0x183747A90")]
	private bool MIKCCHKKEJN(Entity HPMKKHPHJEE, [Out] FANDAOKFPNJ GLPBINKHJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3746FE0", Offset = "0x37463E0", VA = "0x183746FE0")]
	private void LLLLKOPBIPK(Entity HPMKKHPHJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3745C50", Offset = "0x3745050", VA = "0x183745C50")]
	private void EINEJDPAOHF(Entity HPMKKHPHJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3744B20", Offset = "0x3743F20", VA = "0x183744B20")]
	private void ANJIGJNGEFK(Entity HPMKKHPHJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3745AD0", Offset = "0x3744ED0", VA = "0x183745AD0")]
	private void EDBHCAFNNNC(Entity HPMKKHPHJEE, FANDAOKFPNJ GLPBINKHJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x37468E0", Offset = "0x3745CE0", VA = "0x1837468E0")]
	private bool GIBODKNLAIC(FANDAOKFPNJ GLPBINKHJFN, [Out] HashSet<object> OPFKOJBALOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3747710", Offset = "0x3746B10", VA = "0x183747710")]
	private HashSet<object> MDFAOCFAAIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IPDDJOFEGCJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GBHLHMLOHNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int ELJAGIMMLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int APAKJDHFMCK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ABGKMLNHNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x86A070", Offset = "0x869470", VA = "0x18086A070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x20A07C0", Offset = "0x209FBC0", VA = "0x1820A07C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5304080", Offset = "0x5303480", VA = "0x185304080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int HDCGLLKPLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86A070", Offset = "0x869470", VA = "0x18086A070")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x869F80", Offset = "0x869380", VA = "0x180869F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DGNONMCIIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5110", Offset = "0x5EE4510", VA = "0x185EE5110")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5100", Offset = "0x5EE4500", VA = "0x185EE5100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA0EEF0", Offset = "0xA0E2F0", VA = "0x180A0EEF0")]
	private GBHLHMLOHNM(int ELJAGIMMLLH, int APAKJDHFMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1CDB750", Offset = "0x1CDAB50", VA = "0x181CDB750")]
	public static GBHLHMLOHNM DIKGGICIANL(int ELJAGIMMLLH, int APAKJDHFMCK)
	{
		return default(GBHLHMLOHNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EE50F0", Offset = "0x5EE44F0", VA = "0x185EE50F0")]
	public static GBHLHMLOHNM BJMHLDLENEH(int DFOEGCCLIEM, int CBMPBFEPCHD)
	{
		return default(GBHLHMLOHNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5120", Offset = "0x5EE4520", VA = "0x185EE5120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HHCIAOCHEPJ : OLGBPNMJEBM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDE60", Offset = "0x5ECD260", VA = "0x185ECDE60")]
	public float CDGLHMLMIMK([In] float3 NMENOOMOOJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDE60", Offset = "0x5ECD260", VA = "0x185ECDE60", Slot = "4")]
	private float IIHIFKPNEHP([In] float3 NMENOOMOOJP)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BABPHNJOGGI : OLGBPNMJEBM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF6B0", Offset = "0x5ECEAB0", VA = "0x185ECF6B0")]
	public float CDGLHMLMIMK([In] float3 NMENOOMOOJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF6B0", Offset = "0x5ECEAB0", VA = "0x185ECF6B0", Slot = "4")]
	private float IIHIFKPNEHP([In] float3 NMENOOMOOJP)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LAHEEPMEECF : OLGBPNMJEBM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1984F30", Offset = "0x1984330", VA = "0x181984F30")]
	public float CDGLHMLMIMK([In] float3 NMENOOMOOJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1984F30", Offset = "0x1984330", VA = "0x181984F30", Slot = "4")]
	private float IIHIFKPNEHP([In] float3 NMENOOMOOJP)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GCLAAPIGAHM : OLGBPNMJEBM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x12CDE50", Offset = "0x12CD250", VA = "0x1812CDE50")]
	public int CDGLHMLMIMK([In] int3 NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12CDE50", Offset = "0x12CD250", VA = "0x1812CDE50", Slot = "4")]
	private int IOHLDFNHOLL([In] int3 NMENOOMOOJP)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KFFPMOLDGCE : OLGBPNMJEBM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD550", Offset = "0x5ECC950", VA = "0x185ECD550")]
	public int CDGLHMLMIMK([In] int3 NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD550", Offset = "0x5ECC950", VA = "0x185ECD550", Slot = "4")]
	private int IOHLDFNHOLL([In] int3 NMENOOMOOJP)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GOAOHIDJLCI : OLGBPNMJEBM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x159F4C0", Offset = "0x159E8C0", VA = "0x18159F4C0")]
	public int CDGLHMLMIMK([In] int3 NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x159F4C0", Offset = "0x159E8C0", VA = "0x18159F4C0", Slot = "4")]
	private int IOHLDFNHOLL([In] int3 NMENOOMOOJP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AHPDIFNDOGP : BDAJIPEGBOD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type DECFJAFCKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type IKJKADMMILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4570", Offset = "0x5EE3970", VA = "0x185EE4570")]
	public AHPDIFNDOGP(Type FBJBPPKHCNA, Type KHHECCGMILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CMDHDENCJBG : BDAJIPEGBOD
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type IKJKADMMILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9A80", Offset = "0x5DF8E80", VA = "0x185DF9A80")]
	public CMDHDENCJBG(Type KHHECCGMILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ODFJGOPOPBF : BDAJIPEGBOD
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x780500", VA = "0x180781100")]
	public ODFJGOPOPBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class GEEACBBCBEF<Data> : JIOHMKNKHOO where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data LHECNHAABJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x35311E0", Offset = "0x35305E0", VA = "0x1835311E0", Slot = "8")]
	protected virtual bool PINFNCCIICC(ReadOnlySpan<Data> OHFHGCFJPNC, MIOOEEHOEOM ABEKHHIEFDL, [Out] ReadOnlySpan<byte> HMABDLODHOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "9")]
	protected virtual bool ELFPJNJJDOF(int AJLAIKHEKDH, Span<Data> OHFHGCFJPNC, [In] ReadOnlySpan<byte> HMABDLODHOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3531120", Offset = "0x3530520", VA = "0x183531120", Slot = "5")]
	internal sealed override bool PINFNCCIICC(Unity.Entities.Chunk HGJPDBCCKEP, int PLKDIBLEJML, MIOOEEHOEOM ABEKHHIEFDL, [Out] ReadOnlySpan<byte> HMABDLODHOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x35300C0", Offset = "0x352F4C0", VA = "0x1835300C0", Slot = "6")]
	internal sealed override bool ELFPJNJJDOF(int AJLAIKHEKDH, Unity.Entities.Chunk HGJPDBCCKEP, int PLKDIBLEJML, [In] ReadOnlySpan<byte> HMABDLODHOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D3D0", Offset = "0x2E2C7D0", VA = "0x182E2D3D0")]
	protected NOMMNPDFGPO<Protobuf> MMLKGCDKIHE<Protobuf>(ReadOnlySpan<Data> OHFHGCFJPNC) where Protobuf : IMessage, new()
	{
		return default(NOMMNPDFGPO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D350", Offset = "0x2E2C750", VA = "0x182E2D350")]
	protected BEGFHGFIJDN<Protobuf> GAMLBMKJNCJ<Protobuf>(ReadOnlySpan<byte> HMABDLODHOL, ReadOnlySpan<Data> OHFHGCFJPNC, Action<Protobuf> KEALKDLINPL) where Protobuf : IMessage, new()
	{
		return default(BEGFHGFIJDN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
	protected GEEACBBCBEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class JIOHMKNKHOO
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int PJEJHIMPGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EE55E0", Offset = "0x5EE49E0", VA = "0x185EE55E0", Slot = "5")]
	internal virtual bool PINFNCCIICC(Unity.Entities.Chunk HGJPDBCCKEP, int PLKDIBLEJML, MIOOEEHOEOM ABEKHHIEFDL, [Out] ReadOnlySpan<byte> HMABDLODHOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "6")]
	internal virtual bool ELFPJNJJDOF(int AJLAIKHEKDH, Unity.Entities.Chunk HGJPDBCCKEP, int PLKDIBLEJML, [In] ReadOnlySpan<byte> HMABDLODHOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	protected JIOHMKNKHOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HFPPDJILOAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class EMDMJNCKNKL : SystemBase, HFPPDJILOAP
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4AD0", Offset = "0x5EE3ED0", VA = "0x185EE4AD0")]
	public ComponentDataFromEntity KLGIKACAPCH(int AKGGDDJAFEP, bool JDJMNMBHOCF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4AB0", Offset = "0x5EE3EB0", VA = "0x185EE4AB0")]
	public EntityExistenceLookupByEntity CMEHIHGPNIC()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4B90", Offset = "0x5EE3F90", VA = "0x185EE4B90", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x780500", VA = "0x180781100")]
	protected EMDMJNCKNKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class POPCFCMFANO : EMDMJNCKNKL
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6260", Offset = "0x5EE5660", VA = "0x185EE6260", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x780500", VA = "0x180781100")]
	protected POPCFCMFANO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class OBFCLDAIFOL
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class INHCCKIPMHF : IFABCODACLA
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5590", Offset = "0x5EE4990", VA = "0x185EE5590", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase EBDPMOMALHM();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5540", Offset = "0x5EE4940", VA = "0x185EE5540")]
	protected ComponentSystemBase NJFBLMGCGOF(params ComponentSystemBase[] NKODNOBODNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2547190", Offset = "0x2546590", VA = "0x182547190")]
	protected ComponentSystemBase NJFBLMGCGOF<T>(params ComponentSystemBase[] NKODNOBODNE) where T : IFABCODACLA, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2547060", Offset = "0x2546460", VA = "0x182547060")]
	protected ComponentSystemBase EIBNDGPHBJE<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2547060", Offset = "0x2546460", VA = "0x182547060")]
	protected ComponentSystemBase OLJKHHBKLLE<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EE54F0", Offset = "0x5EE48F0", VA = "0x185EE54F0")]
	protected ComponentSystemBase KNIIGGHLDFC(params SystemHandleUntyped[] NKODNOBODNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2547100", Offset = "0x2546500", VA = "0x182547100")]
	protected ComponentSystemBase KNIIGGHLDFC<T>(params SystemHandleUntyped[] NKODNOBODNE) where T : IFABCODACLA, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x25470A0", Offset = "0x25464A0", VA = "0x1825470A0")]
	protected SystemHandleUntyped JPNNDIFIHDF<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5EE51B0", Offset = "0x5EE45B0", VA = "0x185EE51B0")]
	protected INHCCKIPMHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IFABCODACLA : HBHPJAPGOIE
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EE54C0", Offset = "0x5EE48C0", VA = "0x185EE54C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EE51B0", Offset = "0x5EE45B0", VA = "0x185EE51B0")]
	public IFABCODACLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class HBHPJAPGOIE : ComponentSystemGroup, HFPPDJILOAP
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5EE51B0", Offset = "0x5EE45B0", VA = "0x185EE51B0")]
	protected HBHPJAPGOIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class FKFAHKPMIHO : EntityCommandBufferSystem, HFPPDJILOAP
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x780500", VA = "0x180781100")]
	protected FKFAHKPMIHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OLGBPNMJEBM<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo CDGLHMLMIMK([In] TFrom NMENOOMOOJP);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface BJLIBDBMMKB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JPJPDIEKGCK(T NMENOOMOOJP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct EMNAIHPLMBB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> KJDNJKDINCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer KDLBKGPNBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes IPNJPLHFJFL;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4BA0", Offset = "0x5EE3FA0", VA = "0x185EE4BA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct PFCCEFCEAFG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> KJDNJKDINCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer KDLBKGPNBDH;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5FA0", Offset = "0x5EE53A0", VA = "0x185EE5FA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct OMPFNDMALGM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> KJDNJKDINCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer KDLBKGPNBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType FALALGNIKGO;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5F20", Offset = "0x5EE5320", VA = "0x185EE5F20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct PFPKJDPEOPJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> KJDNJKDINCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> KKOACPFFAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer KDLBKGPNBDH;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3EE6200", Offset = "0x3EE5600", VA = "0x183EE6200", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct BNANBBNEAAB<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> KJDNJKDINCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> GDGKEEBHCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer KDLBKGPNBDH;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct MCEHGCCFCNF<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> KJDNJKDINCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T NMENOOMOOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer KDLBKGPNBDH;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C680", Offset = "0x3C9BA80", VA = "0x183C9C680", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct MDLBMEKFFJA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, OLGBPNMJEBM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> LGLINHFCCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> KDIDEIEMMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap ONCLGAMIHNG;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct FIGNIANEEKF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity HDIBJLNBPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> LGLINHFCCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> KDIDEIEMMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int HPJHMEPCOMD;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4D50", Offset = "0x5EE4150", VA = "0x185EE4D50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct JKHDOLMFKBD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KHGOCJFPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> LGLINHFCCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> DBLBMIKEOFD;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct ALPNNDHKDNF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, OLGBPNMJEBM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> BNPJFFLINCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> KDIDEIEMMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap ONCLGAMIHNG;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct NFFEBFFFOMA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KHHECCGMILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> BFAHHLHNMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> MHJAEPGFFLG;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct AEICNIPOELF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KHHECCGMILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> BFAHHLHNMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> MHJAEPGFFLG;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3559CC0", Offset = "0x35590C0", VA = "0x183559CC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct HDHLFGKEJDJ<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> LGLINHFCCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> DBLBMIKEOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> BPNNOGCKFDH;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x35DD100", Offset = "0x35DC500", VA = "0x1835DD100", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct BLAKNIFGJNB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : OLGBPNMJEBM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> LGLINHFCCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> DBLBMIKEOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> BPNNOGCKFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap ONCLGAMIHNG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct GBAKIJANNAP<T, TPredicate> : IJob where T : struct where TPredicate : struct, BJLIBDBMMKB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> LGLINHFCCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> ENNNBDMFGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> DCPOHBPGMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate ONCLGAMIHNG;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x34FF730", Offset = "0x34FEB30", VA = "0x1834FF730", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct DJIGNLEJOPI<T, TPredicate> : IJob where T : struct where TPredicate : struct, BJLIBDBMMKB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> LGLINHFCCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> DBLBMIKEOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate ONCLGAMIHNG;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct AGDJAGPMLCO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity KHHECCGMILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> BFAHHLHNMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> GFJJCGJKBLA;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE44E0", Offset = "0x5EE38E0", VA = "0x185EE44E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct LDGPIMABPOP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity KHHECCGMILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> BFAHHLHNMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> GFJJCGJKBLA;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE55F0", Offset = "0x5EE49F0", VA = "0x185EE55F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class HANDKDHIJOP
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FCPFDPFAJAM
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x24E5DF0", Offset = "0x24E51F0", VA = "0x1824E5DF0")]
	public static bool DNAPEFOLCJI<T>(this NativeArray<Entity> BFAHHLHNMDH, EntityManager LPAJKOAHLHJ, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class BOBINIOCICK
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class IIANCBONBGF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public IIANCBONBGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EFIEAMNJAJL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public EFIEAMNJAJL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> ICLKFLJKJJC;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5EE49E0", Offset = "0x5EE3DE0", VA = "0x185EE49E0")]
	public BOBINIOCICK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class DKAGLBLIKIJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class KPJKCJKPMGE
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct MEKPPIEIGFD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct FACNGEBLOGI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal MEKPPIEIGFD<TFrom> ECLIMLPEPIL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> BPLFEJNHBNI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct DNFFBHEPNJJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct EHINEJALKOM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal DNFFBHEPNJJ<TFrom> ECLIMLPEPIL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> BPLFEJNHBNI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct JGLNMEOJOGH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct NAFPGLIAMPL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal JGLNMEOJOGH<TFrom> ECLIMLPEPIL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> BPLFEJNHBNI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct AFOACBKFAMI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct AFBEKNAIDDF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal AFOACBKFAMI<TFrom> ECLIMLPEPIL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> BPLFEJNHBNI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class HNJIIDKNJHA
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class ANDNPLLDOEF
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B39BF0", Offset = "0x2B38FF0", VA = "0x182B39BF0")]
	public static NativeList<T> IMIIIJJNMBJ<T>(this NativeList<T> KJIPDAEMHFL, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B39C70", Offset = "0x2B39070", VA = "0x182B39C70")]
	public static NativeList<T> IMIIIJJNMBJ<T>(this NativeArray<T> KJIPDAEMHFL, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class BAJPBADFHHG
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class IAKGNCHJLED
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x253D200", Offset = "0x253C600", VA = "0x18253D200")]
	[ELEBMKGAMEH]
	public static JobHandle MBGKPKCFHPB<T>(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArrayAsync<Entity> KJDNJKDINCI, NativeArrayAsync<T> KKOACPFFAML, [Optional] JobHandle FNHILJAOBLM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x253D360", Offset = "0x253C760", VA = "0x18253D360")]
	[ELEBMKGAMEH]
	public static JobHandle MBGKPKCFHPB<T>(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArrayAsync<Entity> KJDNJKDINCI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x253D0E0", Offset = "0x253C4E0", VA = "0x18253D0E0")]
	[ELEBMKGAMEH]
	public static JobHandle MBGKPKCFHPB<T>(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArray<Entity> KJDNJKDINCI, [Optional] JobHandle FNHILJAOBLM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5200", Offset = "0x5EE4600", VA = "0x185EE5200")]
	[ELEBMKGAMEH]
	public static JobHandle MBGKPKCFHPB(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArray<Entity> KJDNJKDINCI, ComponentTypes IPNJPLHFJFL, [Optional] JobHandle FNHILJAOBLM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5370", Offset = "0x5EE4770", VA = "0x185EE5370")]
	[ELEBMKGAMEH]
	public static JobHandle MBGKPKCFHPB(this EntityCommandBufferSystem IFMOJGCCOGE, EntityCommandBuffer KDLBKGPNBDH, NativeArray<Entity> KJDNJKDINCI, ComponentTypes IPNJPLHFJFL, [Optional] JobHandle FNHILJAOBLM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class EHEHOADECHB
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x23D3340", Offset = "0x23D2740", VA = "0x1823D3340")]
	[ELEBMKGAMEH]
	public static JobHandle MLNBDIFADIC<T>(this EntityCommandBufferSystem IFMOJGCCOGE, EntityCommandBuffer KDLBKGPNBDH, EntityQuery HCMBDLKPHME, T NMENOOMOOJP) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class LHIIADEKGEG
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5680", Offset = "0x5EE4A80", VA = "0x185EE5680")]
	[ELEBMKGAMEH]
	public static JobHandle GIEILNGFBEO(this EntityCommandBufferSystem IFMOJGCCOGE, NativeList<Entity> KJDNJKDINCI, [Optional] JobHandle FNHILJAOBLM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5810", Offset = "0x5EE4C10", VA = "0x185EE5810")]
	[ELEBMKGAMEH]
	public static JobHandle GIEILNGFBEO(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArrayAsync<Entity> KJDNJKDINCI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class POGLGDHGNCB
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2672330", Offset = "0x2671730", VA = "0x182672330")]
	public static void LPEDFIPFEPE<T>(this EntityCommandBufferSystem IFMOJGCCOGE, EntityQuery HCMBDLKPHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2672270", Offset = "0x2671670", VA = "0x182672270")]
	[ELEBMKGAMEH]
	public static JobHandle HENIJCCIKIK<T>(this EntityCommandBufferSystem IFMOJGCCOGE, NativeListAsync<Entity> KJDNJKDINCI, [Optional] JobHandle FNHILJAOBLM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x26720E0", Offset = "0x26714E0", VA = "0x1826720E0")]
	[ELEBMKGAMEH]
	public static JobHandle HENIJCCIKIK<T>(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArrayAsync<Entity> KJDNJKDINCI, [Optional] JobHandle FNHILJAOBLM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class CLNKBNJKBID
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2348660", Offset = "0x2347A60", VA = "0x182348660")]
	[ELEBMKGAMEH]
	public static JobHandle DNIMHIAICAD<T>(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArray<Entity> KJDNJKDINCI, NativeArray<T> KKOACPFFAML, JobHandle FNHILJAOBLM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class MKOIGNDLMBA
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x25A8930", Offset = "0x25A7D30", VA = "0x1825A8930")]
	[ELEBMKGAMEH]
	public static JobHandle EFFNOMHAIBH<T>(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArray<Entity> KJDNJKDINCI, T NMENOOMOOJP, [Optional] JobHandle FNHILJAOBLM) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x25A8860", Offset = "0x25A7C60", VA = "0x1825A8860")]
	[ELEBMKGAMEH]
	public static JobHandle EFFNOMHAIBH<T>(this EntityCommandBufferSystem IFMOJGCCOGE, EntityCommandBuffer KDLBKGPNBDH, NativeArray<Entity> KJDNJKDINCI, T NMENOOMOOJP, [Optional] JobHandle FNHILJAOBLM) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class CLHCFNFOKPB
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2346EF0", Offset = "0x23462F0", VA = "0x182346EF0")]
	public static NativeList<T> IMIIIJJNMBJ<T>(NativeList<T> KJIPDAEMHFL, Allocator LJHPECEMAME) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class OEJHANICFIG
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2654840", Offset = "0x2653C40", VA = "0x182654840")]
	public static NativeArray<T> CGAJEPCCNEM<T>(this NativeList<Entity> KJIPDAEMHFL, EntityManager LPAJKOAHLHJ, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x26544C0", Offset = "0x26538C0", VA = "0x1826544C0")]
	public static NativeArray<T> CGAJEPCCNEM<T>(this NativeArray<Entity> KJIPDAEMHFL, EntityManager LPAJKOAHLHJ, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5D40", Offset = "0x5EE5140", VA = "0x185EE5D40")]
	public static NativeArray<Entity> GDLFFFCOFHL(this NativeArray<Entity> KJIPDAEMHFL, EntityManager LPAJKOAHLHJ, ComponentType FALALGNIKGO, Allocator LJHPECEMAME = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2654AB0", Offset = "0x2653EB0", VA = "0x182654AB0")]
	public static NativeArray<T> HEONAOMPGCN<T>(this NativeArray<Entity> KJIPDAEMHFL, EntityManager LPAJKOAHLHJ, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class DFEMBKEEMNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct IKBIPMDJNCD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct HBBANMOKGLI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public IKBIPMDJNCD<TFrom> BPLFEJNHBNI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> LGLINHFCCMM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct CIJBLKKCEGB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct NOKJFJACPAM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public CIJBLKKCEGB<TFrom> BPLFEJNHBNI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> LGLINHFCCMM;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct NPMPHPPPNMI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct DDCOGDICFNE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public NPMPHPPPNMI<TFrom> BPLFEJNHBNI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> LGLINHFCCMM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class OFDPNDMGPEJ
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class HNMPKHJJLPF
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct ALJPLPLBPPH : OLGBPNMJEBM<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> KIBBEAKMOKC;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5EE45C0", Offset = "0x5EE39C0", VA = "0x185EE45C0")]
		[BurstCompatible]
		public Entity CDGLHMLMIMK([In] Entity NMENOOMOOJP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5EE45C0", Offset = "0x5EE39C0", VA = "0x185EE45C0", Slot = "4")]
		private Entity FEACILDFADP([In] Entity NMENOOMOOJP)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class BAEOADGAOKN
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct IOACOBOAABK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> ENNNBDMFGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> LGLINHFCCMM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct FPDALBFMAJI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> ENNNBDMFGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> LGLINHFCCMM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct EEBMPCEOJDJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> ENNNBDMFGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> LGLINHFCCMM;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2E29A20", Offset = "0x2E28E20", VA = "0x182E29A20")]
		public NativeListAsync<Entity> JPJPDIEKGCK<TPredicate>() where TPredicate : struct, BJLIBDBMMKB<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x22B8CD0", Offset = "0x22B80D0", VA = "0x1822B8CD0")]
	public static EEBMPCEOJDJ<T> DPBIPNOPOGG<T>(this NativeArrayAsync<Entity> BFAHHLHNMDH, NativeArrayAsync<T> KJIPDAEMHFL, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct
	{
		return default(EEBMPCEOJDJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class BJCLJHGBIPE
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x22C6930", Offset = "0x22C5D30", VA = "0x1822C6930")]
	public static NativeListAsync<Entity> KDJCCFPAIMG<T, TPredicate>(this NativeArrayAsync<T> KJIPDAEMHFL, NativeArrayAsync<Entity> BFAHHLHNMDH, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct where TPredicate : struct, BJLIBDBMMKB<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x22C69F0", Offset = "0x22C5DF0", VA = "0x1822C69F0")]
	private static NativeListAsync<Entity> OFHMBMMGHOJ<T, TPredicate>(NativeArrayAsync<T> MCKOGDGJFGN, NativeArrayAsync<Entity> BFAHHLHNMDH, int HKIFHAEDDHO, Allocator LJHPECEMAME) where T : struct where TPredicate : struct, BJLIBDBMMKB<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class KJIMKJLDHKG
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct PKGKIGJCCGL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> LGLINHFCCMM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct BHAKMHDBDHO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> LGLINHFCCMM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct DFHFKGKDDAI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> LGLINHFCCMM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct KHNJMIEEMKO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator LJHPECEMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> LGLINHFCCMM;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class AOLDCAJFHDG
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class JFHHFIBCEMF
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x255C740", Offset = "0x255BB40", VA = "0x18255C740")]
	public static NativeList<Entity> KFBGFMIJOKP<T>(this NativeArray<Entity> BFAHHLHNMDH, EntityManager LPAJKOAHLHJ, Allocator LJHPECEMAME = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class HLABANBNHLL
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class GOILCJPDIIM
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct LNACALCLOMP<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> NCABOBFFNFK;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA190", Offset = "0x1CC9590", VA = "0x181CCA190")]
		public LNACALCLOMP(NativeArray<TSrc> NCABOBFFNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DC950", Offset = "0x7DBD50", VA = "0x1807DC950")]
		public BMKPHJIHLHD<TSrc, TValue> NAJJCDHEOHH<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(BMKPHJIHLHD<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct BMKPHJIHLHD<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> NCABOBFFNFK;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA190", Offset = "0x1CC9590", VA = "0x181CCA190")]
		public BMKPHJIHLHD(NativeArray<TSrc> NCABOBFFNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DC950", Offset = "0x7DBD50", VA = "0x1807DC950")]
		public HOLKJNIBFBI<TSrc, TValue, TSelector> LGCBMHJEDEJ<TSelector>() where TSelector : struct, OLGBPNMJEBM<TSrc, TValue>
		{
			return default(HOLKJNIBFBI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct HOLKJNIBFBI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, OLGBPNMJEBM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> NCABOBFFNFK;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA190", Offset = "0x1CC9590", VA = "0x181CCA190")]
		public HOLKJNIBFBI(NativeArray<TSrc> NCABOBFFNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x361FAB0", Offset = "0x361EEB0", VA = "0x18361FAB0")]
		public NEGGDFLNDBH<TSrc, TValue, TSelector> NJFBLMGCGOF()
		{
			return default(NEGGDFLNDBH<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct AFFCIAJNDOK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, OLGBPNMJEBM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> NCABOBFFNFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector KNJNAONDGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int DIENMHDGFGP;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue ADHFGEBEBLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x355A8E0", Offset = "0x3559CE0", VA = "0x18355A8E0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int FFCPNJCJDLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x992A60", Offset = "0x991E60", VA = "0x180992A60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int NAHNDBFADBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1CDCE90", Offset = "0x1CDC290", VA = "0x181CDCE90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x355A980", Offset = "0x3559D80", VA = "0x18355A980")]
		public AFFCIAJNDOK(NativeArray<TSrc> NCABOBFFNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x355A970", Offset = "0x3559D70", VA = "0x18355A970")]
		public bool LOAMOBEEKKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x355A800", Offset = "0x3559C00", VA = "0x18355A800")]
		private TSrc AEODHHCKODN(int JNJOJJJELGE)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct NEGGDFLNDBH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, OLGBPNMJEBM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private AFFCIAJNDOK<TSrc, TValue, TSelector> BLENDJLAJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue GKIPCMABLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int HHKMAFFMIKG;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public GBHLHMLOHNM IACFIFEHPJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x3D228E0", Offset = "0x3D21CE0", VA = "0x183D228E0")]
			get
			{
				return default(GBHLHMLOHNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue BEDPNJMGHIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x770C30", Offset = "0x770030", VA = "0x180770C30")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, GBHLHMLOHNM range) ADHFGEBEBLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x3D22920", Offset = "0x3D21D20", VA = "0x183D22920")]
			get
			{
				return default((TValue, GBHLHMLOHNM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D22B40", Offset = "0x3D21F40", VA = "0x183D22B40")]
		public NEGGDFLNDBH(NativeArray<TSrc> NCABOBFFNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x35DE460", Offset = "0x35DD860", VA = "0x1835DE460")]
		public NEGGDFLNDBH<TSrc, TValue, TSelector> HMFAGAOEPDF()
		{
			return default(NEGGDFLNDBH<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D22A00", Offset = "0x3D21E00", VA = "0x183D22A00")]
		public bool LOAMOBEEKKC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2529800", Offset = "0x2528C00", VA = "0x182529800")]
	public static LNACALCLOMP<T> JBCKGNALLLH<T>(this NativeList<T> HAPGAOAPCEH) where T : struct
	{
		return default(LNACALCLOMP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DC950", Offset = "0x7DBD50", VA = "0x1807DC950")]
	public static LNACALCLOMP<T> JBCKGNALLLH<T>(this NativeArray<T> NCABOBFFNFK) where T : struct
	{
		return default(LNACALCLOMP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class NJGEBCGJNKI
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct CMLCCFELEJI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly NCABOBFFNFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int HHKMAFFMIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int JLHCGOGBOKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T GKIPCMABLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T LADHLMJHDCN;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public GBHLHMLOHNM IACFIFEHPJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x30E2650", Offset = "0x30E1A50", VA = "0x1830E2650")]
			get
			{
				return default(GBHLHMLOHNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T BEDPNJMGHIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x30E25F0", Offset = "0x30E19F0", VA = "0x1830E25F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, GBHLHMLOHNM) ADHFGEBEBLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x49052D0", Offset = "0x49046D0", VA = "0x1849052D0")]
			get
			{
				return default((T, GBHLHMLOHNM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4905800", Offset = "0x4904C00", VA = "0x184905800")]
		public CMLCCFELEJI(NativeArray<T> NCABOBFFNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4905290", Offset = "0x4904690", VA = "0x184905290")]
		public CMLCCFELEJI<T> HMFAGAOEPDF()
		{
			return default(CMLCCFELEJI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4905450", Offset = "0x4904850", VA = "0x184905450")]
		public bool LOAMOBEEKKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D34D50", Offset = "0x2D34150", VA = "0x182D34D50")]
		public EAFAHCFADDC<T, TComparer> JGALOPJHGNE<TComparer>([Optional] TComparer ANGCKFJMOCP) where TComparer : struct, IEqualityComparer<T>
		{
			return default(EAFAHCFADDC<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct EAFAHCFADDC<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly NCABOBFFNFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int HHKMAFFMIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int JLHCGOGBOKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T GKIPCMABLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T LADHLMJHDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer ANGCKFJMOCP;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public GBHLHMLOHNM IACFIFEHPJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x30E2650", Offset = "0x30E1A50", VA = "0x1830E2650")]
			get
			{
				return default(GBHLHMLOHNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T BEDPNJMGHIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x30E25F0", Offset = "0x30E19F0", VA = "0x1830E25F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, GBHLHMLOHNM range) ADHFGEBEBLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x30E2660", Offset = "0x30E1A60", VA = "0x1830E2660")]
			get
			{
				return default((T, GBHLHMLOHNM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x30E2910", Offset = "0x30E1D10", VA = "0x1830E2910")]
		public EAFAHCFADDC(NativeArray<T>.ReadOnly NCABOBFFNFK, TComparer ANGCKFJMOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x30E2610", Offset = "0x30E1A10", VA = "0x1830E2610")]
		public EAFAHCFADDC<T, TComparer> HMFAGAOEPDF()
		{
			return default(EAFAHCFADDC<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x30E2730", Offset = "0x30E1B30", VA = "0x1830E2730")]
		public bool LOAMOBEEKKC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x262A270", Offset = "0x2629670", VA = "0x18262A270")]
	public static CMLCCFELEJI<T> NJFBLMGCGOF<T>(this NativeArray<T> NCABOBFFNFK) where T : struct
	{
		return default(CMLCCFELEJI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface FNFFEJMKGBJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class EHCNJHCFJKA
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct BEGFHGFIJDN<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class ADGKDGNJKIG : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public BEGFHGFIJDN<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9FC980", Offset = "0x9FBD80", VA = "0x1809FC980", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x34B4510", Offset = "0x34B3910", VA = "0x1834B4510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public ADGKDGNJKIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3558800", Offset = "0x3557C00", VA = "0x183558800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x35589B0", Offset = "0x3557DB0", VA = "0x1835589B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> KEALKDLINPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream LOEGNCGHNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream MLKAKJCIDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf CMLOJIGJPLH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int NAHNDBFADBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x896540", Offset = "0x895940", VA = "0x180896540")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x454F650", Offset = "0x454EA50", VA = "0x18454F650")]
	private BEGFHGFIJDN(byte[] PNJHGINLCID, Action<Protobuf> KEALKDLINPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D31FE0", Offset = "0x2D313E0", VA = "0x182D31FE0")]
	public static BEGFHGFIJDN<Protobuf> EBILOFOJHAE<Data>(ReadOnlySpan<byte> HMABDLODHOL, ReadOnlySpan<Data> OHFHGCFJPNC, Action<Protobuf> KEALKDLINPL)
	{
		return default(BEGFHGFIJDN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x454F4C0", Offset = "0x454E8C0", VA = "0x18454F4C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x454F500", Offset = "0x454E900", VA = "0x18454F500", Slot = "4")]
	[IteratorStateMachine(typeof(BEGFHGFIJDN<>.ADGKDGNJKIG))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x454F5F0", Offset = "0x454E9F0", VA = "0x18454F5F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct NOMMNPDFGPO<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] PNJHGINLCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf CMLOJIGJPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream LOEGNCGHNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream GACFCGMNHMJ;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3D354A0", Offset = "0x3D348A0", VA = "0x183D354A0")]
	private NOMMNPDFGPO(byte[] PNJHGINLCID, [In] Protobuf CMLOJIGJPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x24449D0", Offset = "0x2443DD0", VA = "0x1824449D0")]
	public static NOMMNPDFGPO<Protobuf> EBILOFOJHAE<T>(ReadOnlySpan<T> OHFHGCFJPNC)
	{
		return default(NOMMNPDFGPO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3D353E0", Offset = "0x3D347E0", VA = "0x183D353E0")]
	public void JJOGEMFJEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3D35410", Offset = "0x3D34810", VA = "0x183D35410")]
	public ByteString MOKLMPPBAAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3D352B0", Offset = "0x3D346B0", VA = "0x183D352B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct ELFCBKNKGPI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream LOEGNCGHNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream MLKAKJCIDAB;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4A70", Offset = "0x5EE3E70", VA = "0x185EE4A70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct PFJADGENENH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] PNJHGINLCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream LOEGNCGHNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream GACFCGMNHMJ;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6040", Offset = "0x5EE5440", VA = "0x185EE6040", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class BMCNDNBGMJD
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void LCAFPHNKMCE<From, To>(From BPLFEJNHBNI, To BBPJDJCFMPF, MIOOEEHOEOM ABEKHHIEFDL);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class ICDLCDCDBDM<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static LCAFPHNKMCE<From, To> LIDOHOPADKA;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public ICDLCDCDBDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4710", Offset = "0x5EE3B10", VA = "0x185EE4710")]
	static BMCNDNBGMJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x22CDA30", Offset = "0x22CCE30", VA = "0x1822CDA30")]
	public static void APJFNOOLOEI<T>(LCAFPHNKMCE<T, T> GADPMHIKPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x22CE170", Offset = "0x22CD570", VA = "0x1822CE170")]
	public static void APJFNOOLOEI<From, To>(LCAFPHNKMCE<From, To> GADPMHIKPIO, LCAFPHNKMCE<To, From> OMEIDJJJOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x22CD540", Offset = "0x22CC940", VA = "0x1822CD540")]
	public static void APJFNOOLOEI<From, To>(LCAFPHNKMCE<From, To> LIDOHOPADKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x22D1840", Offset = "0x22D0C40", VA = "0x1822D1840")]
	public static LCAFPHNKMCE<From, To> HGBPINDKMAI<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x22CAEF0", Offset = "0x22CA2F0", VA = "0x1822CAEF0")]
	public static void ABDAGIKPMGH<From, To>(From BPLFEJNHBNI, To BBPJDJCFMPF, MIOOEEHOEOM ABEKHHIEFDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class MIOOEEHOEOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> ODLAEFGMEAH;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1CA31C0", Offset = "0x1CA25C0", VA = "0x181CA31C0")]
	public MIOOEEHOEOM(NativeArray<EntityRemapUtility.EntityRemapInfo> ODLAEFGMEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5910", Offset = "0x5EE4D10", VA = "0x185EE5910")]
	public Entity HHDNGDCNMJE(Entity HFLNDIDMJFD)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class PGGFEMAIGAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6170", Offset = "0x5EE5570", VA = "0x185EE6170")]
	public static ulong JCHJKFKABAG(Type LFLAEPCPMDG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6200", Offset = "0x5EE5600", VA = "0x185EE6200")]
	public static ulong JCHJKFKABAG(string BFDCPCDANHA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum NOKJPMKJKDE
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[AttributeUsage(AttributeTargets.Class)]
public class DPALCLNGKEO : BDAJIPEGBOD
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x780500", VA = "0x180781100")]
	public DPALCLNGKEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class FKCBCGJDHMD
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4EB0", Offset = "0x5EE42B0", VA = "0x185EE4EB0")]
	private unsafe static Span<byte> IICOADOLFBB(Unity.Entities.Chunk* HGJPDBCCKEP, int PLKDIBLEJML)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x24FE320", Offset = "0x24FD720", VA = "0x1824FE320")]
	public unsafe static Span<T> GNFKPEEEOLJ<T>(Unity.Entities.Chunk* HGJPDBCCKEP, int PLKDIBLEJML)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x234D4F0", Offset = "0x234C8F0", VA = "0x18234D4F0")]
	public static Span<T> GNFKPEEEOLJ<T>(this Unity.Entities.Chunk HGJPDBCCKEP, int PLKDIBLEJML)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4E50", Offset = "0x5EE4250", VA = "0x185EE4E50")]
	public unsafe static Span<Entity> GIAMHDHFBLJ(Unity.Entities.Chunk* HGJPDBCCKEP)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4F80", Offset = "0x5EE4380", VA = "0x185EE4F80")]
	public unsafe static void ILNOFIHDCKG(Unity.Entities.Chunk* HGJPDBCCKEP, int PLKDIBLEJML)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class DADPLEAPLGN
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DADPLEAPLGN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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

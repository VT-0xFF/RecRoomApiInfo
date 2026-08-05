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
		[Cpp2IlInjected.Address(RVA = "0x5EE4BB0", Offset = "0x5EE3FB0", VA = "0x185EE4BB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x20DECA0", Offset = "0x20DE0A0", VA = "0x1820DECA0")]
	public static void DNNGBDOKCBE<TField>(int DIENMHDGFGP, string MDFAJJKMBAI, IJEFMLHBHIL MONJDCAOMGD, [Out] IGMLEMKENNP<TField> PGPOOACGDAP) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20E14D0", Offset = "0x20E08D0", VA = "0x1820E14D0")]
	public static void FFCGNNCDHLL<TField>(int DIENMHDGFGP, string MDFAJJKMBAI, [Out] LFAGCJKBKCF<TField> JJOBNGACPHH) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class BKMKDOLGGAC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EE44F0", Offset = "0x5EE38F0", VA = "0x185EE44F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x35FE250", Offset = "0x35FD650", VA = "0x1835FE250", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int HOFOODBNGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x35FB620", Offset = "0x35FAA20", VA = "0x1835FB620", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x35FBA90", Offset = "0x35FAE90", VA = "0x1835FBA90")]
	public Data IABCNAGKCJI(Entity HPMKKHPHJEE)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View DBMHICPLCAC(Entity HPMKKHPHJEE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2E2FE60", Offset = "0x2E2F260", VA = "0x182E2FE60", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0x1245F70", Offset = "0x1245370", VA = "0x181245F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x962820", Offset = "0x961C20", VA = "0x180962820", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int NFCHIJKHAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5EE59C0", Offset = "0x5EE4DC0", VA = "0x185EE59C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private BHLONKBJEEN[] OELLOLADKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D19F40", Offset = "0x3D19340", VA = "0x183D19F40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual BHLONKBJEEN[] PJJPDIKMALL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5930", Offset = "0x5EE4D30", VA = "0x185EE5930", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5B20", Offset = "0x5EE4F20", VA = "0x185EE5B20")]
	public void GJHPIDDJMKM(EntityManager LPAJKOAHLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T DBMHICPLCAC<T>(Entity HPMKKHPHJEE) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5A30", Offset = "0x5EE4E30", VA = "0x185EE5A30", Slot = "8")]
	public (uint, uint) BKJCJOMPHLM(Entity HPMKKHPHJEE)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5840", Offset = "0x5EE4C40", VA = "0x185EE5840", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F86130", Offset = "0x2F85530", VA = "0x182F86130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C5D0", Offset = "0x3D1B9D0", VA = "0x183D1C5D0")]
		public bool PADMPCCLLMJ([Out] TValue NMENOOMOOJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C4A0", Offset = "0x3D1B8A0", VA = "0x183D1C4A0")]
		public void BKKEPFPDOJH(object NOEAHPPKHNC, TValue NMENOOMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C550", Offset = "0x3D1B950", VA = "0x183D1C550")]
		public bool HBMDGHADMGB(object NOEAHPPKHNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C3C0", Offset = "0x3D1B7C0", VA = "0x183D1C3C0")]
		public int AGBMHGFHFBJ(object NOEAHPPKHNC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C6C0", Offset = "0x3D1BAC0", VA = "0x183D1C6C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3739140", Offset = "0x3738540", VA = "0x183739140")]
	public IDEMBMNEGFM(EntityManager LPAJKOAHLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3738CC0", Offset = "0x37380C0", VA = "0x183738CC0", Slot = "4")]
	public void FOHJPGKGKGM(Entity HPMKKHPHJEE, object NOEAHPPKHNC, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x37389F0", Offset = "0x3737DF0", VA = "0x1837389F0", Slot = "5")]
	public bool BCPICGCOADI(Entity HPMKKHPHJEE, object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3739040", Offset = "0x3738440", VA = "0x183739040", Slot = "6")]
	public bool PADMPCCLLMJ(Entity HPMKKHPHJEE, [Out] TValue NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3738B90", Offset = "0x3737F90", VA = "0x183738B90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3738E00", Offset = "0x3738200", VA = "0x183738E00")]
	private void GNJKNMCFNCH(NCPCBIDMLLI OPFKOJBALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3738E90", Offset = "0x3738290", VA = "0x183738E90")]
	private bool IPDILMLOJIA(Entity HPMKKHPHJEE, [Out] FANDAOKFPNJ GLPBINKHJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3738BB0", Offset = "0x3737FB0", VA = "0x183738BB0")]
	private void EDBHCAFNNNC(Entity HPMKKHPHJEE, FANDAOKFPNJ GLPBINKHJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3738CA0", Offset = "0x37380A0", VA = "0x183738CA0")]
	private bool EDGOEPLMDPC(FANDAOKFPNJ GLPBINKHJFN, [Out] NCPCBIDMLLI OPFKOJBALOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3738F50", Offset = "0x3738350", VA = "0x183738F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x86A0B0", Offset = "0x8694B0", VA = "0x18086A0B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x869FC0", Offset = "0x8693C0", VA = "0x180869FC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x20A0880", Offset = "0x209FC80", VA = "0x1820A0880", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5303FA0", Offset = "0x53033A0", VA = "0x185303FA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4BD0", Offset = "0x5EE3FD0", VA = "0x185EE4BD0", Slot = "8")]
	public bool Equals(FANDAOKFPNJ LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4C20", Offset = "0x5EE4020", VA = "0x185EE4C20", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x37496C0", Offset = "0x3748AC0", VA = "0x1837496C0")]
	public IGGGJGPIDCM(EntityManager LPAJKOAHLHJ, EntityCommandBufferSystem IFMOJGCCOGE, GBIKKFKHKKF OMNJPFACPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37477B0", Offset = "0x3746BB0", VA = "0x1837477B0", Slot = "4")]
	public bool FOHJPGKGKGM(Entity HPMKKHPHJEE, object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x37463C0", Offset = "0x37457C0", VA = "0x1837463C0", Slot = "5")]
	public bool BCPICGCOADI(Entity HPMKKHPHJEE, object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3746AC0", Offset = "0x3745EC0", VA = "0x183746AC0", Slot = "6")]
	public bool ECGMHLLIGMD(Entity HPMKKHPHJEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3746CB0", Offset = "0x37460B0", VA = "0x183746CB0", Slot = "9")]
	public bool ECGMHLLIGMD(FANDAOKFPNJ GLPBINKHJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x37493C0", Offset = "0x37487C0", VA = "0x1837493C0", Slot = "7")]
	public bool ODBFPPDCPGP(Entity HPMKKHPHJEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3746A40", Offset = "0x3745E40", VA = "0x183746A40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3748030", Offset = "0x3747430", VA = "0x183748030")]
	private void GNJKNMCFNCH(HashSet<object> OPFKOJBALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3748180", Offset = "0x3747580", VA = "0x183748180")]
	private bool IPDILMLOJIA(Entity HPMKKHPHJEE, [Out] FANDAOKFPNJ GLPBINKHJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3749040", Offset = "0x3748440", VA = "0x183749040")]
	private bool MIKCCHKKEJN(Entity HPMKKHPHJEE, [Out] FANDAOKFPNJ GLPBINKHJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3748590", Offset = "0x3747990", VA = "0x183748590")]
	private void LLLLKOPBIPK(Entity HPMKKHPHJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3747200", Offset = "0x3746600", VA = "0x183747200")]
	private void EINEJDPAOHF(Entity HPMKKHPHJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x37460D0", Offset = "0x37454D0", VA = "0x1837460D0")]
	private void ANJIGJNGEFK(Entity HPMKKHPHJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3747080", Offset = "0x3746480", VA = "0x183747080")]
	private void EDBHCAFNNNC(Entity HPMKKHPHJEE, FANDAOKFPNJ GLPBINKHJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3747E90", Offset = "0x3747290", VA = "0x183747E90")]
	private bool GIBODKNLAIC(FANDAOKFPNJ GLPBINKHJFN, [Out] HashSet<object> OPFKOJBALOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3748CC0", Offset = "0x37480C0", VA = "0x183748CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86A0B0", Offset = "0x8694B0", VA = "0x18086A0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x20A0880", Offset = "0x209FC80", VA = "0x1820A0880")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5303FA0", Offset = "0x53033A0", VA = "0x185303FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int HDCGLLKPLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86A0B0", Offset = "0x8694B0", VA = "0x18086A0B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x869FC0", Offset = "0x8693C0", VA = "0x180869FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DGNONMCIIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5030", Offset = "0x5EE4430", VA = "0x185EE5030")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5020", Offset = "0x5EE4420", VA = "0x185EE5020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA0EFA0", Offset = "0xA0E3A0", VA = "0x180A0EFA0")]
	private GBHLHMLOHNM(int ELJAGIMMLLH, int APAKJDHFMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1CDB940", Offset = "0x1CDAD40", VA = "0x181CDB940")]
	public static GBHLHMLOHNM DIKGGICIANL(int ELJAGIMMLLH, int APAKJDHFMCK)
	{
		return default(GBHLHMLOHNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5010", Offset = "0x5EE4410", VA = "0x185EE5010")]
	public static GBHLHMLOHNM BJMHLDLENEH(int DFOEGCCLIEM, int CBMPBFEPCHD)
	{
		return default(GBHLHMLOHNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5040", Offset = "0x5EE4440", VA = "0x185EE5040", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x5ECDD80", Offset = "0x5ECD180", VA = "0x185ECDD80")]
	public float CDGLHMLMIMK([In] float3 NMENOOMOOJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDD80", Offset = "0x5ECD180", VA = "0x185ECDD80", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5ECF5D0", Offset = "0x5ECE9D0", VA = "0x185ECF5D0")]
	public float CDGLHMLMIMK([In] float3 NMENOOMOOJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF5D0", Offset = "0x5ECE9D0", VA = "0x185ECF5D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1984FE0", Offset = "0x19843E0", VA = "0x181984FE0")]
	public float CDGLHMLMIMK([In] float3 NMENOOMOOJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1984FE0", Offset = "0x19843E0", VA = "0x181984FE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x12CDF00", Offset = "0x12CD300", VA = "0x1812CDF00")]
	public int CDGLHMLMIMK([In] int3 NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12CDF00", Offset = "0x12CD300", VA = "0x1812CDF00", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5ECD470", Offset = "0x5ECC870", VA = "0x185ECD470")]
	public int CDGLHMLMIMK([In] int3 NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD470", Offset = "0x5ECC870", VA = "0x185ECD470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x159F570", Offset = "0x159E970", VA = "0x18159F570")]
	public int CDGLHMLMIMK([In] int3 NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x159F570", Offset = "0x159E970", VA = "0x18159F570", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE4490", Offset = "0x5EE3890", VA = "0x185EE4490")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DF99A0", Offset = "0x5DF8DA0", VA = "0x185DF99A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x35328D0", Offset = "0x3531CD0", VA = "0x1835328D0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3532810", Offset = "0x3531C10", VA = "0x183532810", Slot = "5")]
	internal sealed override bool PINFNCCIICC(Unity.Entities.Chunk HGJPDBCCKEP, int PLKDIBLEJML, MIOOEEHOEOM ABEKHHIEFDL, [Out] ReadOnlySpan<byte> HMABDLODHOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x35317B0", Offset = "0x3530BB0", VA = "0x1835317B0", Slot = "6")]
	internal sealed override bool ELFPJNJJDOF(int AJLAIKHEKDH, Unity.Entities.Chunk HGJPDBCCKEP, int PLKDIBLEJML, [In] ReadOnlySpan<byte> HMABDLODHOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D460", Offset = "0x2E2C860", VA = "0x182E2D460")]
	protected NOMMNPDFGPO<Protobuf> MMLKGCDKIHE<Protobuf>(ReadOnlySpan<Data> OHFHGCFJPNC) where Protobuf : IMessage, new()
	{
		return default(NOMMNPDFGPO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D3E0", Offset = "0x2E2C7E0", VA = "0x182E2D3E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE5500", Offset = "0x5EE4900", VA = "0x185EE5500", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE49F0", Offset = "0x5EE3DF0", VA = "0x185EE49F0")]
	public ComponentDataFromEntity KLGIKACAPCH(int AKGGDDJAFEP, bool JDJMNMBHOCF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EE49D0", Offset = "0x5EE3DD0", VA = "0x185EE49D0")]
	public EntityExistenceLookupByEntity CMEHIHGPNIC()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4AB0", Offset = "0x5EE3EB0", VA = "0x185EE4AB0", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE6180", Offset = "0x5EE5580", VA = "0x185EE6180", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE54B0", Offset = "0x5EE48B0", VA = "0x185EE54B0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase EBDPMOMALHM();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5460", Offset = "0x5EE4860", VA = "0x185EE5460")]
	protected ComponentSystemBase NJFBLMGCGOF(params ComponentSystemBase[] NKODNOBODNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2547220", Offset = "0x2546620", VA = "0x182547220")]
	protected ComponentSystemBase NJFBLMGCGOF<T>(params ComponentSystemBase[] NKODNOBODNE) where T : IFABCODACLA, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25470F0", Offset = "0x25464F0", VA = "0x1825470F0")]
	protected ComponentSystemBase EIBNDGPHBJE<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x25470F0", Offset = "0x25464F0", VA = "0x1825470F0")]
	protected ComponentSystemBase OLJKHHBKLLE<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5410", Offset = "0x5EE4810", VA = "0x185EE5410")]
	protected ComponentSystemBase KNIIGGHLDFC(params SystemHandleUntyped[] NKODNOBODNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2547190", Offset = "0x2546590", VA = "0x182547190")]
	protected ComponentSystemBase KNIIGGHLDFC<T>(params SystemHandleUntyped[] NKODNOBODNE) where T : IFABCODACLA, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2547130", Offset = "0x2546530", VA = "0x182547130")]
	protected SystemHandleUntyped JPNNDIFIHDF<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5EE50D0", Offset = "0x5EE44D0", VA = "0x185EE50D0")]
	protected INHCCKIPMHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IFABCODACLA : HBHPJAPGOIE
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EE53E0", Offset = "0x5EE47E0", VA = "0x185EE53E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EE50D0", Offset = "0x5EE44D0", VA = "0x185EE50D0")]
	public IFABCODACLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class HBHPJAPGOIE : ComponentSystemGroup, HFPPDJILOAP
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5EE50D0", Offset = "0x5EE44D0", VA = "0x185EE50D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE4AC0", Offset = "0x5EE3EC0", VA = "0x185EE4AC0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE5EC0", Offset = "0x5EE52C0", VA = "0x185EE5EC0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE5E40", Offset = "0x5EE5240", VA = "0x185EE5E40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3EE7620", Offset = "0x3EE6A20", VA = "0x183EE7620", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C9DB20", Offset = "0x3C9CF20", VA = "0x183C9DB20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE4C70", Offset = "0x5EE4070", VA = "0x185EE4C70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3557760", Offset = "0x3556B60", VA = "0x183557760", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x35DE770", Offset = "0x35DDB70", VA = "0x1835DE770", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3500E20", Offset = "0x3500220", VA = "0x183500E20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE4400", Offset = "0x5EE3800", VA = "0x185EE4400", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE5510", Offset = "0x5EE4910", VA = "0x185EE5510", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x24E5E80", Offset = "0x24E5280", VA = "0x1824E5E80")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE4900", Offset = "0x5EE3D00", VA = "0x185EE4900")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B39C80", Offset = "0x2B39080", VA = "0x182B39C80")]
	public static NativeList<T> IMIIIJJNMBJ<T>(this NativeList<T> KJIPDAEMHFL, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B39D00", Offset = "0x2B39100", VA = "0x182B39D00")]
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
	[Cpp2IlInjected.Address(RVA = "0x253D290", Offset = "0x253C690", VA = "0x18253D290")]
	[ELEBMKGAMEH]
	public static JobHandle MBGKPKCFHPB<T>(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArrayAsync<Entity> KJDNJKDINCI, NativeArrayAsync<T> KKOACPFFAML, [Optional] JobHandle FNHILJAOBLM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x253D3F0", Offset = "0x253C7F0", VA = "0x18253D3F0")]
	[ELEBMKGAMEH]
	public static JobHandle MBGKPKCFHPB<T>(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArrayAsync<Entity> KJDNJKDINCI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x253D170", Offset = "0x253C570", VA = "0x18253D170")]
	[ELEBMKGAMEH]
	public static JobHandle MBGKPKCFHPB<T>(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArray<Entity> KJDNJKDINCI, [Optional] JobHandle FNHILJAOBLM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5120", Offset = "0x5EE4520", VA = "0x185EE5120")]
	[ELEBMKGAMEH]
	public static JobHandle MBGKPKCFHPB(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArray<Entity> KJDNJKDINCI, ComponentTypes IPNJPLHFJFL, [Optional] JobHandle FNHILJAOBLM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5290", Offset = "0x5EE4690", VA = "0x185EE5290")]
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
	[Cpp2IlInjected.Address(RVA = "0x23D33D0", Offset = "0x23D27D0", VA = "0x1823D33D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE55A0", Offset = "0x5EE49A0", VA = "0x185EE55A0")]
	[ELEBMKGAMEH]
	public static JobHandle GIEILNGFBEO(this EntityCommandBufferSystem IFMOJGCCOGE, NativeList<Entity> KJDNJKDINCI, [Optional] JobHandle FNHILJAOBLM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5730", Offset = "0x5EE4B30", VA = "0x185EE5730")]
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
	[Cpp2IlInjected.Address(RVA = "0x26723C0", Offset = "0x26717C0", VA = "0x1826723C0")]
	public static void LPEDFIPFEPE<T>(this EntityCommandBufferSystem IFMOJGCCOGE, EntityQuery HCMBDLKPHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2672300", Offset = "0x2671700", VA = "0x182672300")]
	[ELEBMKGAMEH]
	public static JobHandle HENIJCCIKIK<T>(this EntityCommandBufferSystem IFMOJGCCOGE, NativeListAsync<Entity> KJDNJKDINCI, [Optional] JobHandle FNHILJAOBLM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2672170", Offset = "0x2671570", VA = "0x182672170")]
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
	[Cpp2IlInjected.Address(RVA = "0x2348710", Offset = "0x2347B10", VA = "0x182348710")]
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
	[Cpp2IlInjected.Address(RVA = "0x25A89C0", Offset = "0x25A7DC0", VA = "0x1825A89C0")]
	[ELEBMKGAMEH]
	public static JobHandle EFFNOMHAIBH<T>(this EntityCommandBufferSystem IFMOJGCCOGE, NativeArray<Entity> KJDNJKDINCI, T NMENOOMOOJP, [Optional] JobHandle FNHILJAOBLM) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x25A88F0", Offset = "0x25A7CF0", VA = "0x1825A88F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2346FA0", Offset = "0x23463A0", VA = "0x182346FA0")]
	public static NativeList<T> IMIIIJJNMBJ<T>(NativeList<T> KJIPDAEMHFL, Allocator LJHPECEMAME) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class OEJHANICFIG
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x26548D0", Offset = "0x2653CD0", VA = "0x1826548D0")]
	public static NativeArray<T> CGAJEPCCNEM<T>(this NativeList<Entity> KJIPDAEMHFL, EntityManager LPAJKOAHLHJ, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2654550", Offset = "0x2653950", VA = "0x182654550")]
	public static NativeArray<T> CGAJEPCCNEM<T>(this NativeArray<Entity> KJIPDAEMHFL, EntityManager LPAJKOAHLHJ, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5C60", Offset = "0x5EE5060", VA = "0x185EE5C60")]
	public static NativeArray<Entity> GDLFFFCOFHL(this NativeArray<Entity> KJIPDAEMHFL, EntityManager LPAJKOAHLHJ, ComponentType FALALGNIKGO, Allocator LJHPECEMAME = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2654B40", Offset = "0x2653F40", VA = "0x182654B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EE44E0", Offset = "0x5EE38E0", VA = "0x185EE44E0")]
		[BurstCompatible]
		public Entity CDGLHMLMIMK([In] Entity NMENOOMOOJP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5EE44E0", Offset = "0x5EE38E0", VA = "0x185EE44E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E29AB0", Offset = "0x2E28EB0", VA = "0x182E29AB0")]
		public NativeListAsync<Entity> JPJPDIEKGCK<TPredicate>() where TPredicate : struct, BJLIBDBMMKB<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x22B8D90", Offset = "0x22B8190", VA = "0x1822B8D90")]
	public static EEBMPCEOJDJ<T> DPBIPNOPOGG<T>(this NativeArrayAsync<Entity> BFAHHLHNMDH, NativeArrayAsync<T> KJIPDAEMHFL, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct
	{
		return default(EEBMPCEOJDJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class BJCLJHGBIPE
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x22C69F0", Offset = "0x22C5DF0", VA = "0x1822C69F0")]
	public static NativeListAsync<Entity> KDJCCFPAIMG<T, TPredicate>(this NativeArrayAsync<T> KJIPDAEMHFL, NativeArrayAsync<Entity> BFAHHLHNMDH, Allocator LJHPECEMAME = Allocator.TempJob) where T : struct where TPredicate : struct, BJLIBDBMMKB<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x22C6AB0", Offset = "0x22C5EB0", VA = "0x1822C6AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x255C7D0", Offset = "0x255BBD0", VA = "0x18255C7D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
		public LNACALCLOMP(NativeArray<TSrc> NCABOBFFNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
		public BMKPHJIHLHD(NativeArray<TSrc> NCABOBFFNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
		public HOLKJNIBFBI(NativeArray<TSrc> NCABOBFFNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x36210C0", Offset = "0x36204C0", VA = "0x1836210C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3558380", Offset = "0x3557780", VA = "0x183558380")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int FFCPNJCJDLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x992B10", Offset = "0x991F10", VA = "0x180992B10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int NAHNDBFADBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1CDD080", Offset = "0x1CDC480", VA = "0x181CDD080")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3558420", Offset = "0x3557820", VA = "0x183558420")]
		public AFFCIAJNDOK(NativeArray<TSrc> NCABOBFFNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3558410", Offset = "0x3557810", VA = "0x183558410")]
		public bool LOAMOBEEKKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x35582A0", Offset = "0x35576A0", VA = "0x1835582A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D23D30", Offset = "0x3D23130", VA = "0x183D23D30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D23D70", Offset = "0x3D23170", VA = "0x183D23D70")]
			get
			{
				return default((TValue, GBHLHMLOHNM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D23F90", Offset = "0x3D23390", VA = "0x183D23F90")]
		public NEGGDFLNDBH(NativeArray<TSrc> NCABOBFFNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x35DFAD0", Offset = "0x35DEED0", VA = "0x1835DFAD0")]
		public NEGGDFLNDBH<TSrc, TValue, TSelector> HMFAGAOEPDF()
		{
			return default(NEGGDFLNDBH<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D23E50", Offset = "0x3D23250", VA = "0x183D23E50")]
		public bool LOAMOBEEKKC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2529890", Offset = "0x2528C90", VA = "0x182529890")]
	public static LNACALCLOMP<T> JBCKGNALLLH<T>(this NativeList<T> HAPGAOAPCEH) where T : struct
	{
		return default(LNACALCLOMP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
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
			[Cpp2IlInjected.Address(RVA = "0x30E26E0", Offset = "0x30E1AE0", VA = "0x1830E26E0")]
			get
			{
				return default(GBHLHMLOHNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T BEDPNJMGHIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x30E2680", Offset = "0x30E1A80", VA = "0x1830E2680")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, GBHLHMLOHNM) ADHFGEBEBLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4905190", Offset = "0x4904590", VA = "0x184905190")]
			get
			{
				return default((T, GBHLHMLOHNM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x49056C0", Offset = "0x4904AC0", VA = "0x1849056C0")]
		public CMLCCFELEJI(NativeArray<T> NCABOBFFNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4905150", Offset = "0x4904550", VA = "0x184905150")]
		public CMLCCFELEJI<T> HMFAGAOEPDF()
		{
			return default(CMLCCFELEJI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4905310", Offset = "0x4904710", VA = "0x184905310")]
		public bool LOAMOBEEKKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D34DE0", Offset = "0x2D341E0", VA = "0x182D34DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x30E26E0", Offset = "0x30E1AE0", VA = "0x1830E26E0")]
			get
			{
				return default(GBHLHMLOHNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T BEDPNJMGHIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x30E2680", Offset = "0x30E1A80", VA = "0x1830E2680")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, GBHLHMLOHNM range) ADHFGEBEBLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x30E26F0", Offset = "0x30E1AF0", VA = "0x1830E26F0")]
			get
			{
				return default((T, GBHLHMLOHNM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x30E29A0", Offset = "0x30E1DA0", VA = "0x1830E29A0")]
		public EAFAHCFADDC(NativeArray<T>.ReadOnly NCABOBFFNFK, TComparer ANGCKFJMOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x30E26A0", Offset = "0x30E1AA0", VA = "0x1830E26A0")]
		public EAFAHCFADDC<T, TComparer> HMFAGAOEPDF()
		{
			return default(EAFAHCFADDC<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x30E27C0", Offset = "0x30E1BC0", VA = "0x1830E27C0")]
		public bool LOAMOBEEKKC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x262A300", Offset = "0x2629700", VA = "0x18262A300")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FCA30", Offset = "0x9FBE30", VA = "0x1809FCA30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x34B5C00", Offset = "0x34B5000", VA = "0x1834B5C00", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x35562A0", Offset = "0x35556A0", VA = "0x1835562A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3556450", Offset = "0x3555850", VA = "0x183556450", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x896580", Offset = "0x895980", VA = "0x180896580")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4550A70", Offset = "0x454FE70", VA = "0x184550A70")]
	private BEGFHGFIJDN(byte[] PNJHGINLCID, Action<Protobuf> KEALKDLINPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D32070", Offset = "0x2D31470", VA = "0x182D32070")]
	public static BEGFHGFIJDN<Protobuf> EBILOFOJHAE<Data>(ReadOnlySpan<byte> HMABDLODHOL, ReadOnlySpan<Data> OHFHGCFJPNC, Action<Protobuf> KEALKDLINPL)
	{
		return default(BEGFHGFIJDN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x45508E0", Offset = "0x454FCE0", VA = "0x1845508E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4550920", Offset = "0x454FD20", VA = "0x184550920", Slot = "4")]
	[IteratorStateMachine(typeof(BEGFHGFIJDN<>.ADGKDGNJKIG))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4550A10", Offset = "0x454FE10", VA = "0x184550A10", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D368F0", Offset = "0x3D35CF0", VA = "0x183D368F0")]
	private NOMMNPDFGPO(byte[] PNJHGINLCID, [In] Protobuf CMLOJIGJPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2444A60", Offset = "0x2443E60", VA = "0x182444A60")]
	public static NOMMNPDFGPO<Protobuf> EBILOFOJHAE<T>(ReadOnlySpan<T> OHFHGCFJPNC)
	{
		return default(NOMMNPDFGPO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3D36830", Offset = "0x3D35C30", VA = "0x183D36830")]
	public void JJOGEMFJEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3D36860", Offset = "0x3D35C60", VA = "0x183D36860")]
	public ByteString MOKLMPPBAAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3D36700", Offset = "0x3D35B00", VA = "0x183D36700", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE4990", Offset = "0x5EE3D90", VA = "0x185EE4990", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE5F60", Offset = "0x5EE5360", VA = "0x185EE5F60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE4630", Offset = "0x5EE3A30", VA = "0x185EE4630")]
	static BMCNDNBGMJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x22CDAF0", Offset = "0x22CCEF0", VA = "0x1822CDAF0")]
	public static void APJFNOOLOEI<T>(LCAFPHNKMCE<T, T> GADPMHIKPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x22CE230", Offset = "0x22CD630", VA = "0x1822CE230")]
	public static void APJFNOOLOEI<From, To>(LCAFPHNKMCE<From, To> GADPMHIKPIO, LCAFPHNKMCE<To, From> OMEIDJJJOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x22CD600", Offset = "0x22CCA00", VA = "0x1822CD600")]
	public static void APJFNOOLOEI<From, To>(LCAFPHNKMCE<From, To> LIDOHOPADKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x22D1900", Offset = "0x22D0D00", VA = "0x1822D1900")]
	public static LCAFPHNKMCE<From, To> HGBPINDKMAI<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x22CAFB0", Offset = "0x22CA3B0", VA = "0x1822CAFB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CA33B0", Offset = "0x1CA27B0", VA = "0x181CA33B0")]
	public MIOOEEHOEOM(NativeArray<EntityRemapUtility.EntityRemapInfo> ODLAEFGMEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5830", Offset = "0x5EE4C30", VA = "0x185EE5830")]
	public Entity HHDNGDCNMJE(Entity HFLNDIDMJFD)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class PGGFEMAIGAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6090", Offset = "0x5EE5490", VA = "0x185EE6090")]
	public static ulong JCHJKFKABAG(Type LFLAEPCPMDG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6120", Offset = "0x5EE5520", VA = "0x185EE6120")]
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
	[Cpp2IlInjected.Address(RVA = "0x5EE4DD0", Offset = "0x5EE41D0", VA = "0x185EE4DD0")]
	private unsafe static Span<byte> IICOADOLFBB(Unity.Entities.Chunk* HGJPDBCCKEP, int PLKDIBLEJML)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x24FE3B0", Offset = "0x24FD7B0", VA = "0x1824FE3B0")]
	public unsafe static Span<T> GNFKPEEEOLJ<T>(Unity.Entities.Chunk* HGJPDBCCKEP, int PLKDIBLEJML)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x234D5A0", Offset = "0x234C9A0", VA = "0x18234D5A0")]
	public static Span<T> GNFKPEEEOLJ<T>(this Unity.Entities.Chunk HGJPDBCCKEP, int PLKDIBLEJML)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4D70", Offset = "0x5EE4170", VA = "0x185EE4D70")]
	public unsafe static Span<Entity> GIAMHDHFBLJ(Unity.Entities.Chunk* HGJPDBCCKEP)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4EA0", Offset = "0x5EE42A0", VA = "0x185EE4EA0")]
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

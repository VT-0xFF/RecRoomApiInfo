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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EC6440", Offset = "0x5EC5440", VA = "0x185EC6440")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class NDNPOHALHKE<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] GILEMILABDP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x242AF70", Offset = "0x2429F70", VA = "0x18242AF70")]
	public static void FNIJGIBCDNE<TField>(int NFJIPMHILEL, string JNMEJDHMADI, GOAMEDBOBIK NJBGPNBDDGB, [Out] JNLGBPNGHPJ<TField> BHNFFMEOAFJ) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x242CA20", Offset = "0x242BA20", VA = "0x18242CA20")]
	public static void HPPJNLPJJOE<TField>(int NFJIPMHILEL, string JNMEJDHMADI, [Out] ENCNPEPPFND<TField> PNEABPKDNJE) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class PGGHFPAHHCD
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7230", Offset = "0x5EC6230", VA = "0x185EC7230")]
	public static FieldInfo[] CGFMCCHMNEP(Type CFGJPNBLNDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class CFAOHNCOENM<View, Data> : HOELMJJHJAA where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType FKIEOJFBOID;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type LBDHPPHGJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x47F5020", Offset = "0x47F4020", VA = "0x1847F5020", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int NEPACHCFFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x47F31A0", Offset = "0x47F21A0", VA = "0x1847F31A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x47F4540", Offset = "0x47F3540", VA = "0x1847F4540")]
	public Data HHLLGGPPLHA(Entity CFNJODNKJAM)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View JIKMAEMLOON(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2D17EA0", Offset = "0x2D16EA0", VA = "0x182D17EA0", Slot = "14")]
	public override T JIKMAEMLOON<T>(Entity CFNJODNKJAM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
	protected CFAOHNCOENM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class HOELMJJHJAA : GOAMEDBOBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle BCDPMNJDOCD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager PBDLFNMMACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1205280", Offset = "0x1204280", VA = "0x181205280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type LBDHPPHGJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int NEPACHCFFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type KJEHKBMNABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x909E80", Offset = "0x908E80", VA = "0x180909E80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int OJFODIKMHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5EC68B0", Offset = "0x5EC58B0", VA = "0x185EC68B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private JNEBOFIEDGJ[] GAEGEDHIPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D00480", Offset = "0x3CFF480", VA = "0x183D00480", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual JNEBOFIEDGJ[] CBOKFHKIDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6C40", Offset = "0x5EC5C40", VA = "0x185EC6C40", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6920", Offset = "0x5EC5920", VA = "0x185EC6920")]
	public void EMCBFDNIFOC(EntityManager OHEFKBDAJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T JIKMAEMLOON<T>(Entity CFNJODNKJAM) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6A60", Offset = "0x5EC5A60", VA = "0x185EC6A60", Slot = "8")]
	public (uint, uint) ENDKFKGIOMM(Entity CFNJODNKJAM)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6B50", Offset = "0x5EC5B50", VA = "0x185EC6B50", Slot = "9")]
	public bool KFGECDNNDHO(Entity CFNJODNKJAM, (uint order, uint change) CEJKGGNMCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	protected HOELMJJHJAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LBDACGBGMNG
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BEBHONAALEL : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OLCNJDGDDON IJNFDCAGGMJ
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
public interface IMKAIDLMDLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DCJHDAMIICH(Entity CFNJODNKJAM, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DCOHNKAEKPH(Entity CFNJODNKJAM, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JEJEJJEMOEG(Entity CFNJODNKJAM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HAANOMGPBAG(Entity CFNJODNKJAM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PBOALIAGEKE<TComponentData, TValue> : IEOPCCIINHF<TValue>, IDisposable where TComponentData : struct, BEBHONAALEL
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class HHINFMJPALH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> LOKHPAFMLOJ;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int PLKFCNLILAN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2F73550", Offset = "0x2F72550", VA = "0x182F73550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x360E7D0", Offset = "0x360D7D0", VA = "0x18360E7D0")]
		public bool CLPPENILEDH([Out] TValue APPJEOKOGAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x360E8C0", Offset = "0x360D8C0", VA = "0x18360E8C0")]
		public void GPDFOMDKBKK(object PDIBILKHEBM, TValue APPJEOKOGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x360E970", Offset = "0x360D970", VA = "0x18360E970")]
		public bool MOJJDBCCFOB(object PDIBILKHEBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x360E9F0", Offset = "0x360D9F0", VA = "0x18360E9F0")]
		public int OPMHHHDIACE(object PDIBILKHEBM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x360EAD0", Offset = "0x360DAD0", VA = "0x18360EAD0")]
		public HHINFMJPALH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<HHINFMJPALH> DPIKINCBNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private HNHENJDNJAG<OLCNJDGDDON, HHINFMJPALH> CGALDOCOMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager OHEFKBDAJBH;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0F40", Offset = "0x3E9FF40", VA = "0x183EA0F40")]
	public PBOALIAGEKE(EntityManager OHEFKBDAJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3EA08F0", Offset = "0x3E9F8F0", VA = "0x183EA08F0", Slot = "4")]
	public void DCJHDAMIICH(Entity CFNJODNKJAM, object PDIBILKHEBM, TValue APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0A30", Offset = "0x3E9FA30", VA = "0x183EA0A30", Slot = "5")]
	public bool DCOHNKAEKPH(Entity CFNJODNKJAM, object PDIBILKHEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3EA07F0", Offset = "0x3E9F7F0", VA = "0x183EA07F0", Slot = "6")]
	public bool CLPPENILEDH(Entity CFNJODNKJAM, [Out] TValue APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0BD0", Offset = "0x3E9FBD0", VA = "0x183EA0BD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0BF0", Offset = "0x3E9FBF0", VA = "0x183EA0BF0")]
	private void FKBFCJNAFAO(HHINFMJPALH ADMIGACGICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0C80", Offset = "0x3E9FC80", VA = "0x183EA0C80")]
	private bool FLEBBNDNJAL(Entity CFNJODNKJAM, [Out] OLCNJDGDDON LJOOGDNJBGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0D60", Offset = "0x3E9FD60", VA = "0x183EA0D60")]
	private void KHDIEBAJGAA(Entity CFNJODNKJAM, OLCNJDGDDON LJOOGDNJBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0D40", Offset = "0x3E9FD40", VA = "0x183EA0D40")]
	private bool GMOAOLINHBD(OLCNJDGDDON LJOOGDNJBGF, [Out] HHINFMJPALH ADMIGACGICI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0E50", Offset = "0x3E9FE50", VA = "0x183EA0E50")]
	private HHINFMJPALH PHIKGKHGECG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IEOPCCIINHF<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCJHDAMIICH(Entity CFNJODNKJAM, object PDIBILKHEBM, TValue APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DCOHNKAEKPH(Entity CFNJODNKJAM, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLPPENILEDH(Entity CFNJODNKJAM, [Out] TValue APPJEOKOGAK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OLCNJDGDDON : PMNNCLPDDJB, IEquatable<OLCNJDGDDON>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly OLCNJDGDDON GHGNOAMLPEA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int KLNGLNIFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x82BE50", Offset = "0x82AE50", VA = "0x18082BE50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int JIGAGOBMBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x208F330", Offset = "0x208E330", VA = "0x18208F330", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x52EBC80", Offset = "0x52EAC80", VA = "0x1852EBC80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7190", Offset = "0x5EC6190", VA = "0x185EC7190", Slot = "8")]
	public bool Equals(OLCNJDGDDON EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC71E0", Offset = "0x5EC61E0", VA = "0x185EC71E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FIKDJJKONND<THasTokensTag> : IMKAIDLMDLI, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, OLCNJDGDDON> JJGBFAINJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> DPIKINCBNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private HNHENJDNJAG<OLCNJDGDDON, HashSet<object>> CGALDOCOMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager OHEFKBDAJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem AFOGGBJKBMH;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x34623B0", Offset = "0x34613B0", VA = "0x1834623B0")]
	public FIKDJJKONND(EntityManager OHEFKBDAJBH, EntityCommandBufferSystem AFOGGBJKBMH, IMFBLHALHMN GIFNGLAPIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x345EE70", Offset = "0x345DE70", VA = "0x18345EE70", Slot = "4")]
	public bool DCJHDAMIICH(Entity CFNJODNKJAM, object PDIBILKHEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x345F150", Offset = "0x345E150", VA = "0x18345F150", Slot = "5")]
	public bool DCOHNKAEKPH(Entity CFNJODNKJAM, object PDIBILKHEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3460A50", Offset = "0x345FA50", VA = "0x183460A50", Slot = "6")]
	public bool JEJEJJEMOEG(Entity CFNJODNKJAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3460B90", Offset = "0x345FB90", VA = "0x183460B90", Slot = "9")]
	public bool JEJEJJEMOEG(OLCNJDGDDON LJOOGDNJBGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3460550", Offset = "0x345F550", VA = "0x183460550", Slot = "7")]
	public bool HAANOMGPBAG(Entity CFNJODNKJAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x345F980", Offset = "0x345E980", VA = "0x18345F980", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3460060", Offset = "0x345F060", VA = "0x183460060")]
	private void FKBFCJNAFAO(HashSet<object> ADMIGACGICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x34603B0", Offset = "0x345F3B0", VA = "0x1834603B0")]
	private bool FLEBBNDNJAL(Entity CFNJODNKJAM, [Out] OLCNJDGDDON LJOOGDNJBGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3461480", Offset = "0x3460480", VA = "0x183461480")]
	private bool NGCCNAKEMLD(Entity CFNJODNKJAM, [Out] OLCNJDGDDON LJOOGDNJBGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x34616C0", Offset = "0x34606C0", VA = "0x1834616C0")]
	private void PCICCMAJMPK(Entity CFNJODNKJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x345FBE0", Offset = "0x345EBE0", VA = "0x18345FBE0")]
	private void EICHBDENEOJ(Entity CFNJODNKJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3461100", Offset = "0x3460100", VA = "0x183461100")]
	private void KOGCEKADHLJ(Entity CFNJODNKJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3460F30", Offset = "0x345FF30", VA = "0x183460F30")]
	private void KHDIEBAJGAA(Entity CFNJODNKJAM, OLCNJDGDDON LJOOGDNJBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x345E900", Offset = "0x345D900", VA = "0x18345E900")]
	private bool DALBPHOBEIB(OLCNJDGDDON LJOOGDNJBGF, [Out] HashSet<object> ADMIGACGICI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3461CB0", Offset = "0x3460CB0", VA = "0x183461CB0")]
	private HashSet<object> PHIKGKHGECG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IMOJFIHFPBG
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HFBGOGMEEFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int ODJLNMBFCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int AGLAJIDEGHD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int LHJLBNLNFHH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x208F330", Offset = "0x208E330", VA = "0x18208F330")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x52EBC80", Offset = "0x52EAC80", VA = "0x1852EBC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NHOMPAOPOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82BE50", Offset = "0x82AE50", VA = "0x18082BE50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KCHJEPMNGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5EC67D0", Offset = "0x5EC57D0", VA = "0x185EC67D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5EC67F0", Offset = "0x5EC57F0", VA = "0x185EC67F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9CE1C0", Offset = "0x9CD1C0", VA = "0x1809CE1C0")]
	private HFBGOGMEEFA(int ODJLNMBFCPC, int AGLAJIDEGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1CC9A40", Offset = "0x1CC8A40", VA = "0x181CC9A40")]
	public static HFBGOGMEEFA ACKJAHEBPIL(int ODJLNMBFCPC, int AGLAJIDEGHD)
	{
		return default(HFBGOGMEEFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EC67E0", Offset = "0x5EC57E0", VA = "0x185EC67E0")]
	public static HFBGOGMEEFA HNDCGNBNHNP(int CEJJMMEOKPD, int HGIJPKEDKIN)
	{
		return default(HFBGOGMEEFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6800", Offset = "0x5EC5800", VA = "0x185EC6800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct EBJKHBPLJLN : IHDGDPNGEKH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5EB12A0", Offset = "0x5EB02A0", VA = "0x185EB12A0")]
	public float EALBBHEHGED([In] float3 APPJEOKOGAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB12A0", Offset = "0x5EB02A0", VA = "0x185EB12A0", Slot = "4")]
	private float ICONPDPFLHK([In] float3 APPJEOKOGAK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FJAIEMNJBOM : IHDGDPNGEKH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0E40", Offset = "0x5EAFE40", VA = "0x185EB0E40")]
	public float EALBBHEHGED([In] float3 APPJEOKOGAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0E40", Offset = "0x5EAFE40", VA = "0x185EB0E40", Slot = "4")]
	private float ICONPDPFLHK([In] float3 APPJEOKOGAK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DKKAFMAHGCE : IHDGDPNGEKH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1945510", Offset = "0x1944510", VA = "0x181945510")]
	public float EALBBHEHGED([In] float3 APPJEOKOGAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1945510", Offset = "0x1944510", VA = "0x181945510", Slot = "4")]
	private float ICONPDPFLHK([In] float3 APPJEOKOGAK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CFNHPJNPPDN : IHDGDPNGEKH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1294EC0", Offset = "0x1293EC0", VA = "0x181294EC0")]
	public int EALBBHEHGED([In] int3 APPJEOKOGAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1294EC0", Offset = "0x1293EC0", VA = "0x181294EC0", Slot = "4")]
	private int JCEELHKMFHJ([In] int3 APPJEOKOGAK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PJAKIFPDANF : IHDGDPNGEKH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EB10F0", Offset = "0x5EB00F0", VA = "0x185EB10F0")]
	public int EALBBHEHGED([In] int3 APPJEOKOGAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EB10F0", Offset = "0x5EB00F0", VA = "0x185EB10F0", Slot = "4")]
	private int JCEELHKMFHJ([In] int3 APPJEOKOGAK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NNIJHHBNPAJ : IHDGDPNGEKH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1567230", Offset = "0x1566230", VA = "0x181567230")]
	public int EALBBHEHGED([In] int3 APPJEOKOGAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1567230", Offset = "0x1566230", VA = "0x181567230", Slot = "4")]
	private int JCEELHKMFHJ([In] int3 APPJEOKOGAK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LKINONHJNBF : GBHCDPMMINH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type ACAIBNLLNJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type DKMKEGOJICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7050", Offset = "0x5EC6050", VA = "0x185EC7050")]
	public LKINONHJNBF(Type AGGMPBLPHAE, Type GDINPPFBCBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AHAJAAJDPNM : GBHCDPMMINH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type DKMKEGOJICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC5F0", Offset = "0x5DDB5F0", VA = "0x185DDC5F0")]
	public AHAJAAJDPNM(Type GDINPPFBCBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NEOBOPDOEMF : GBHCDPMMINH
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x780100", Offset = "0x77F100", VA = "0x180780100")]
	public NEOBOPDOEMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class JGCJAHMFLKN<Data> : BKPNNJPKIHN where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data ENPBEGLBBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x38D88C0", Offset = "0x38D78C0", VA = "0x1838D88C0", Slot = "8")]
	protected virtual bool JMIBEIHLPBA(ReadOnlySpan<Data> DHAGBOIMPBD, HNBGCPCCNKG OPHMJAFDELD, [Out] ReadOnlySpan<byte> LNCOLHOCFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "9")]
	protected virtual bool FEMIPPAGCJC(int CEJKGGNMCNG, Span<Data> DHAGBOIMPBD, [In] ReadOnlySpan<byte> LNCOLHOCFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x38D88D0", Offset = "0x38D78D0", VA = "0x1838D88D0", Slot = "5")]
	internal sealed override bool JMIBEIHLPBA(Unity.Entities.Chunk LGELEHBGOKE, int JPADAKIILJM, HNBGCPCCNKG OPHMJAFDELD, [Out] ReadOnlySpan<byte> LNCOLHOCFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x38D7D10", Offset = "0x38D6D10", VA = "0x1838D7D10", Slot = "6")]
	internal sealed override bool FEMIPPAGCJC(int CEJKGGNMCNG, Unity.Entities.Chunk LGELEHBGOKE, int JPADAKIILJM, [In] ReadOnlySpan<byte> LNCOLHOCFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x23A2F70", Offset = "0x23A1F70", VA = "0x1823A2F70")]
	protected FAMLFGCGLHA<Protobuf> HEBOOLGCGPC<Protobuf>(ReadOnlySpan<Data> DHAGBOIMPBD) where Protobuf : IMessage, new()
	{
		return default(FAMLFGCGLHA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x23A2EF0", Offset = "0x23A1EF0", VA = "0x1823A2EF0")]
	protected NKKCHHMDCED<Protobuf> EJGIDDPHCNC<Protobuf>(ReadOnlySpan<byte> LNCOLHOCFJN, ReadOnlySpan<Data> DHAGBOIMPBD, Action<Protobuf> NCNMDNOOKKD) where Protobuf : IMessage, new()
	{
		return default(NKKCHHMDCED<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
	protected JGCJAHMFLKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class BKPNNJPKIHN
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int JIGAGOBMBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5B20", Offset = "0x5EC4B20", VA = "0x185EC5B20", Slot = "5")]
	internal virtual bool JMIBEIHLPBA(Unity.Entities.Chunk LGELEHBGOKE, int JPADAKIILJM, HNBGCPCCNKG OPHMJAFDELD, [Out] ReadOnlySpan<byte> LNCOLHOCFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "6")]
	internal virtual bool FEMIPPAGCJC(int CEJKGGNMCNG, Unity.Entities.Chunk LGELEHBGOKE, int JPADAKIILJM, [In] ReadOnlySpan<byte> LNCOLHOCFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	protected BKPNNJPKIHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GLNCCHFFGOJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class FHJCDMLNNPN : SystemBase, GLNCCHFFGOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6480", Offset = "0x5EC5480", VA = "0x185EC6480")]
	public ComponentDataFromEntity OGAHMPMBIBP(int MEGKEAHLAIG, bool KFKOEHDGBLD = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6460", Offset = "0x5EC5460", VA = "0x185EC6460")]
	public EntityExistenceLookupByEntity ILPMEODHOAG()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6540", Offset = "0x5EC5540", VA = "0x185EC6540", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x780100", Offset = "0x77F100", VA = "0x180780100")]
	protected FHJCDMLNNPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class IMAFONDDCAI : FHJCDMLNNPN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6CD0", Offset = "0x5EC5CD0", VA = "0x185EC6CD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x780100", Offset = "0x77F100", VA = "0x180780100")]
	protected IMAFONDDCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class LNJDLNOPPCB
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class NJFNDCIHPGP : EPKJAPPOGBC
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7140", Offset = "0x5EC6140", VA = "0x185EC7140", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase MIJJPPKFMEJ();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC70F0", Offset = "0x5EC60F0", VA = "0x185EC70F0")]
	protected ComponentSystemBase NHLHLGIAJNN(params ComponentSystemBase[] JOBFEDHABOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x25FFD20", Offset = "0x25FED20", VA = "0x1825FFD20")]
	protected ComponentSystemBase NHLHLGIAJNN<T>(params ComponentSystemBase[] JOBFEDHABOB) where T : EPKJAPPOGBC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25FFBF0", Offset = "0x25FEBF0", VA = "0x1825FFBF0")]
	protected ComponentSystemBase FEEGBAMHMIH<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x25FFBF0", Offset = "0x25FEBF0", VA = "0x1825FFBF0")]
	protected ComponentSystemBase GGKLNPBFLAK<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EC70A0", Offset = "0x5EC60A0", VA = "0x185EC70A0")]
	protected ComponentSystemBase JKGEIOLGPMP(params SystemHandleUntyped[] JOBFEDHABOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x25FFC30", Offset = "0x25FEC30", VA = "0x1825FFC30")]
	protected ComponentSystemBase JKGEIOLGPMP<T>(params SystemHandleUntyped[] JOBFEDHABOB) where T : EPKJAPPOGBC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x25FFCC0", Offset = "0x25FECC0", VA = "0x1825FFCC0")]
	protected SystemHandleUntyped MPKBLOPFDDA<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5B30", Offset = "0x5EC4B30", VA = "0x185EC5B30")]
	protected NJFNDCIHPGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EPKJAPPOGBC : BOMDBAHAIOF
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6410", Offset = "0x5EC5410", VA = "0x185EC6410", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5B30", Offset = "0x5EC4B30", VA = "0x185EC5B30")]
	public EPKJAPPOGBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class BOMDBAHAIOF : ComponentSystemGroup, GLNCCHFFGOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5B30", Offset = "0x5EC4B30", VA = "0x185EC5B30")]
	protected BOMDBAHAIOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class OKOPJNLFHGH : EntityCommandBufferSystem, GLNCCHFFGOJ
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x780100", Offset = "0x77F100", VA = "0x180780100")]
	protected OKOPJNLFHGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IHDGDPNGEKH<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo EALBBHEHGED([In] TFrom APPJEOKOGAK);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KIIJKDKPALK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEFHOPBHDGD(T APPJEOKOGAK);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct PJPGKHLHOLK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> DJHDIEIFFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer EMANHPLBNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes CNGJDCEOHGG;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7640", Offset = "0x5EC6640", VA = "0x185EC7640", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct GNCBBCICIAO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> DJHDIEIFFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer EMANHPLBNLC;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6730", Offset = "0x5EC5730", VA = "0x185EC6730", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct PKNLAPOAODJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> DJHDIEIFFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer EMANHPLBNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType LFECKICDIOG;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7730", Offset = "0x5EC6730", VA = "0x185EC7730", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct KFAMFOEHNJL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> DJHDIEIFFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> FCLEEDACIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer EMANHPLBNLC;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x396B470", Offset = "0x396A470", VA = "0x18396B470", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct CLMPFGLEKAN<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> DJHDIEIFFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> ALBJDCCCHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer EMANHPLBNLC;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct MLHPJAOGALG<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> DJHDIEIFFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T APPJEOKOGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer EMANHPLBNLC;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3CBA670", Offset = "0x3CB9670", VA = "0x183CBA670", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct MFMDGMNLDIG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IHDGDPNGEKH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> PCBCJGHOIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> GBCADLKOHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap NFDFJOBAEPD;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct EKIKDJCELGJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity KGCIJPCEBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> PCBCJGHOIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> GBCADLKOHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int CFAJDPLDJBK;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6310", Offset = "0x5EC5310", VA = "0x185EC6310", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct GIMFLHKNHIF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CDIENHCANEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> PCBCJGHOIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> JDLCJGKDNDL;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct OCMIAFLLKEA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IHDGDPNGEKH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> KONJLJEOGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> GBCADLKOHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap NFDFJOBAEPD;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct NNGMHCKMOII<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GDINPPFBCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> NGMOEIECONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> PALJNDNGDDJ;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct BMFHEHAHLON<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GDINPPFBCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> NGMOEIECONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> PALJNDNGDDJ;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x45716C0", Offset = "0x45706C0", VA = "0x1845716C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct BDCIMLAIKHK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> PCBCJGHOIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> JDLCJGKDNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> GLBBOMGLNKK;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x452F400", Offset = "0x452E400", VA = "0x18452F400", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct PNBKMNJMPLI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : IHDGDPNGEKH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> PCBCJGHOIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> JDLCJGKDNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> GLBBOMGLNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap NFDFJOBAEPD;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct EFAIPIKIAGH<T, TPredicate> : IJob where T : struct where TPredicate : struct, KIIJKDKPALK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> PCBCJGHOIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> LEPHLABNEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> NFGFACMLGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate NFDFJOBAEPD;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x30FBC40", Offset = "0x30FAC40", VA = "0x1830FBC40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct CIHGGEBGGBI<T, TPredicate> : IJob where T : struct where TPredicate : struct, KIIJKDKPALK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> PCBCJGHOIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> JDLCJGKDNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate NFDFJOBAEPD;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct PPCHHJEAOLA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity GDINPPFBCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> NGMOEIECONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> MLCBHJCCMED;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC77B0", Offset = "0x5EC67B0", VA = "0x185EC77B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct KIMFEDBBAKE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity GDINPPFBCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> NGMOEIECONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> MLCBHJCCMED;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6D00", Offset = "0x5EC5D00", VA = "0x185EC6D00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class AGPJDCLHLGF
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CJDKOEGKPNG
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2329300", Offset = "0x2328300", VA = "0x182329300")]
	public static bool KDBGBHBJJIJ<T>(this NativeArray<Entity> NGMOEIECONA, EntityManager OHEFKBDAJBH, Allocator OIPBEAGANJF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class BHCHJLPGKJN
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class FHNIMGGCILN<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public FHNIMGGCILN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class AGPBLNEOKEJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public AGPBLNEOKEJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> BMNAPABAMKO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5A90", Offset = "0x5EC4A90", VA = "0x185EC5A90")]
	public BHCHJLPGKJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BIFOPACPGOE
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class OHAGAEEHKFE
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct FGBIOKPAMEO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct KLKCDGJDKCK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal FGBIOKPAMEO<TFrom> IGPIMCJILMM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> AEMKIPDFHEB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct CAGNINFGGLI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct PNMDMMGNMPB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal CAGNINFGGLI<TFrom> IGPIMCJILMM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> AEMKIPDFHEB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct PKMMPFGAHHE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct KJEIMGECIFG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal PKMMPFGAHHE<TFrom> IGPIMCJILMM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> AEMKIPDFHEB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct HACKKKAJMLL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct POKAFJHIFFI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal HACKKKAJMLL<TFrom> IGPIMCJILMM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> AEMKIPDFHEB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class NDGBLBKLCEB
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class OCEFKJDLJDA
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x261C450", Offset = "0x261B450", VA = "0x18261C450")]
	public static NativeList<T> DGIOGECGDMN<T>(this NativeList<T> EJBJFAMOOMH, Allocator OIPBEAGANJF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x261C2D0", Offset = "0x261B2D0", VA = "0x18261C2D0")]
	public static NativeList<T> DGIOGECGDMN<T>(this NativeArray<T> EJBJFAMOOMH, Allocator OIPBEAGANJF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class MFONDAMNIAH
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class KMKJGOCAIHF
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2558070", Offset = "0x2557070", VA = "0x182558070")]
	[FJDNBPGGJAJ]
	public static JobHandle LCAIDALGAIE<T>(this EntityCommandBufferSystem AFOGGBJKBMH, NativeArrayAsync<Entity> DJHDIEIFFIA, NativeArrayAsync<T> FCLEEDACIMH, [Optional] JobHandle MLNNJICJMIO) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2557FD0", Offset = "0x2556FD0", VA = "0x182557FD0")]
	[FJDNBPGGJAJ]
	public static JobHandle LCAIDALGAIE<T>(this EntityCommandBufferSystem AFOGGBJKBMH, NativeArrayAsync<Entity> DJHDIEIFFIA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2557EB0", Offset = "0x2556EB0", VA = "0x182557EB0")]
	[FJDNBPGGJAJ]
	public static JobHandle LCAIDALGAIE<T>(this EntityCommandBufferSystem AFOGGBJKBMH, NativeArray<Entity> DJHDIEIFFIA, [Optional] JobHandle MLNNJICJMIO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6D90", Offset = "0x5EC5D90", VA = "0x185EC6D90")]
	[FJDNBPGGJAJ]
	public static JobHandle LCAIDALGAIE(this EntityCommandBufferSystem AFOGGBJKBMH, NativeArray<Entity> DJHDIEIFFIA, ComponentTypes CNGJDCEOHGG, [Optional] JobHandle MLNNJICJMIO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6F00", Offset = "0x5EC5F00", VA = "0x185EC6F00")]
	[FJDNBPGGJAJ]
	public static JobHandle LCAIDALGAIE(this EntityCommandBufferSystem AFOGGBJKBMH, EntityCommandBuffer EMANHPLBNLC, NativeArray<Entity> DJHDIEIFFIA, ComponentTypes CNGJDCEOHGG, [Optional] JobHandle MLNNJICJMIO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LEHOOMDBOHM
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x255C4C0", Offset = "0x255B4C0", VA = "0x18255C4C0")]
	[FJDNBPGGJAJ]
	public static JobHandle DEHMBOIHNOP<T>(this EntityCommandBufferSystem AFOGGBJKBMH, EntityCommandBuffer EMANHPLBNLC, EntityQuery NDCKJDAKMMH, T APPJEOKOGAK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class CMIDKDGFEBB
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5C70", Offset = "0x5EC4C70", VA = "0x185EC5C70")]
	[FJDNBPGGJAJ]
	public static JobHandle BEDDNBGAIPA(this EntityCommandBufferSystem AFOGGBJKBMH, NativeList<Entity> DJHDIEIFFIA, [Optional] JobHandle MLNNJICJMIO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5E00", Offset = "0x5EC4E00", VA = "0x185EC5E00")]
	[FJDNBPGGJAJ]
	public static JobHandle BEDDNBGAIPA(this EntityCommandBufferSystem AFOGGBJKBMH, NativeArrayAsync<Entity> DJHDIEIFFIA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class KKMBFPBPMIE
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2556030", Offset = "0x2555030", VA = "0x182556030")]
	public static void COKCFFJHCDB<T>(this EntityCommandBufferSystem AFOGGBJKBMH, EntityQuery NDCKJDAKMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x25567E0", Offset = "0x25557E0", VA = "0x1825567E0")]
	[FJDNBPGGJAJ]
	public static JobHandle IOLPFGDFDFB<T>(this EntityCommandBufferSystem AFOGGBJKBMH, NativeListAsync<Entity> DJHDIEIFFIA, [Optional] JobHandle MLNNJICJMIO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2556650", Offset = "0x2555650", VA = "0x182556650")]
	[FJDNBPGGJAJ]
	public static JobHandle IOLPFGDFDFB<T>(this EntityCommandBufferSystem AFOGGBJKBMH, NativeArrayAsync<Entity> DJHDIEIFFIA, [Optional] JobHandle MLNNJICJMIO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class DJNDPMFNKAP
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2365D80", Offset = "0x2364D80", VA = "0x182365D80")]
	[FJDNBPGGJAJ]
	public static JobHandle GJLFJNJLELC<T>(this EntityCommandBufferSystem AFOGGBJKBMH, NativeArray<Entity> DJHDIEIFFIA, NativeArray<T> FCLEEDACIMH, JobHandle MLNNJICJMIO) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class OMEKGIPJDFA
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2636970", Offset = "0x2635970", VA = "0x182636970")]
	[FJDNBPGGJAJ]
	public static JobHandle INJIEAFHPJO<T>(this EntityCommandBufferSystem AFOGGBJKBMH, NativeArray<Entity> DJHDIEIFFIA, T APPJEOKOGAK, [Optional] JobHandle MLNNJICJMIO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2636A50", Offset = "0x2635A50", VA = "0x182636A50")]
	[FJDNBPGGJAJ]
	public static JobHandle INJIEAFHPJO<T>(this EntityCommandBufferSystem AFOGGBJKBMH, EntityCommandBuffer EMANHPLBNLC, NativeArray<Entity> DJHDIEIFFIA, T APPJEOKOGAK, [Optional] JobHandle MLNNJICJMIO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class NDDPFHFGCFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x25FB500", Offset = "0x25FA500", VA = "0x1825FB500")]
	public static NativeList<T> DGIOGECGDMN<T>(NativeList<T> EJBJFAMOOMH, Allocator OIPBEAGANJF) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class GIKCMFHPBNA
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x24EDFA0", Offset = "0x24ECFA0", VA = "0x1824EDFA0")]
	public static NativeArray<T> MNMFANGFAKL<T>(this NativeList<Entity> EJBJFAMOOMH, EntityManager OHEFKBDAJBH, Allocator OIPBEAGANJF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x24EDA60", Offset = "0x24ECA60", VA = "0x1824EDA60")]
	public static NativeArray<T> MNMFANGFAKL<T>(this NativeArray<Entity> EJBJFAMOOMH, EntityManager OHEFKBDAJBH, Allocator OIPBEAGANJF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6550", Offset = "0x5EC5550", VA = "0x185EC6550")]
	public static NativeArray<Entity> DOOJLLKBOFC(this NativeArray<Entity> EJBJFAMOOMH, EntityManager OHEFKBDAJBH, ComponentType LFECKICDIOG, Allocator OIPBEAGANJF = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x24ED980", Offset = "0x24EC980", VA = "0x1824ED980")]
	public static NativeArray<T> JNJGJNILLNF<T>(this NativeArray<Entity> EJBJFAMOOMH, EntityManager OHEFKBDAJBH, Allocator OIPBEAGANJF = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class EALGIGHDJFD
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct BFPHBBOCPIK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct MDDDMPHKELJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public BFPHBBOCPIK<TFrom> AEMKIPDFHEB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> PCBCJGHOIKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct FPIMBFJAFDO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct NFHCKOFNMAL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public FPIMBFJAFDO<TFrom> AEMKIPDFHEB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> PCBCJGHOIKP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct JKMGDBBGGIF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct KOJLOLPOMMC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public JKMGDBBGGIF<TFrom> AEMKIPDFHEB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> PCBCJGHOIKP;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class IBCBKHHFMOD
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class MLKGNGGKIHP
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct HGEEPLGNMHI : IHDGDPNGEKH<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> FCOGBOIDDCJ;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6890", Offset = "0x5EC5890", VA = "0x185EC6890")]
		[BurstCompatible]
		public Entity EALBBHEHGED([In] Entity APPJEOKOGAK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6890", Offset = "0x5EC5890", VA = "0x185EC6890", Slot = "4")]
		private Entity AFKHIJPFAKI([In] Entity APPJEOKOGAK)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class BPKHIPBLIEE
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct GPMNBGALLNO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> LEPHLABNEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> PCBCJGHOIKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct EMHHBMAHKCK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> LEPHLABNEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> PCBCJGHOIKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct IBDAAHDIFPF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> LEPHLABNEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> PCBCJGHOIKP;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x23A1C70", Offset = "0x23A0C70", VA = "0x1823A1C70")]
		public NativeListAsync<Entity> NEFHOPBHDGD<TPredicate>() where TPredicate : struct, KIIJKDKPALK<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x22C58D0", Offset = "0x22C48D0", VA = "0x1822C58D0")]
	public static IBDAAHDIFPF<T> NKCCPFJPLLJ<T>(this NativeArrayAsync<Entity> NGMOEIECONA, NativeArrayAsync<T> EJBJFAMOOMH, Allocator OIPBEAGANJF = Allocator.TempJob) where T : struct
	{
		return default(IBDAAHDIFPF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class AINELGMIDGB
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2B0DB10", Offset = "0x2B0CB10", VA = "0x182B0DB10")]
	public static NativeListAsync<Entity> EBMACJGAEFP<T, TPredicate>(this NativeArrayAsync<T> EJBJFAMOOMH, NativeArrayAsync<Entity> NGMOEIECONA, Allocator OIPBEAGANJF = Allocator.TempJob) where T : struct where TPredicate : struct, KIIJKDKPALK<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2B0DBD0", Offset = "0x2B0CBD0", VA = "0x182B0DBD0")]
	private static NativeListAsync<Entity> FGMIJNJFCLG<T, TPredicate>(NativeArrayAsync<T> ANNOLKNEJMK, NativeArrayAsync<Entity> NGMOEIECONA, int EHBIPHOJPOK, Allocator OIPBEAGANJF) where T : struct where TPredicate : struct, KIIJKDKPALK<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class BAJIOINOHFP
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct ILJHKKPKONK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> PCBCJGHOIKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct KHGFEJLDEIL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> PCBCJGHOIKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct BIIKCBOECPN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> PCBCJGHOIKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct ICAIELHBFLG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator OIPBEAGANJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> PCBCJGHOIKP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class ADONIKCHPPL
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class MDIBJAAIIEL
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2578500", Offset = "0x2577500", VA = "0x182578500")]
	public static NativeList<Entity> OKOCEOGOABG<T>(this NativeArray<Entity> NGMOEIECONA, EntityManager OHEFKBDAJBH, Allocator OIPBEAGANJF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class OJPPDDLPEND
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class FPNGHPFCCIK
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct MIPOPGBNEII<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> FHOLKIOOKFG;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1CBB2C0", Offset = "0x1CBA2C0", VA = "0x181CBB2C0")]
		public MIPOPGBNEII(NativeArray<TSrc> FHOLKIOOKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0")]
		public HMFFFBMIOIE<TSrc, TValue> EIGNAFDKFMG<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(HMFFFBMIOIE<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct HMFFFBMIOIE<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> FHOLKIOOKFG;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1CBB2C0", Offset = "0x1CBA2C0", VA = "0x181CBB2C0")]
		public HMFFFBMIOIE(NativeArray<TSrc> FHOLKIOOKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0")]
		public HAEFIKCKFKE<TSrc, TValue, TSelector> NBPBJDKMIKE<TSelector>() where TSelector : struct, IHDGDPNGEKH<TSrc, TValue>
		{
			return default(HAEFIKCKFKE<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct HAEFIKCKFKE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IHDGDPNGEKH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> FHOLKIOOKFG;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1CBB2C0", Offset = "0x1CBA2C0", VA = "0x181CBB2C0")]
		public HAEFIKCKFKE(NativeArray<TSrc> FHOLKIOOKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x35CEFA0", Offset = "0x35CDFA0", VA = "0x1835CEFA0")]
		public IHMLHPGLFNE<TSrc, TValue, TSelector> NHLHLGIAJNN()
		{
			return default(IHMLHPGLFNE<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct JONMPKIGFGC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, IHDGDPNGEKH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> FHOLKIOOKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector CDMJONFOGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int NFJIPMHILEL;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue PADEIDMLAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x39099F0", Offset = "0x39089F0", VA = "0x1839099F0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int KLNGLNIFDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x9580D0", Offset = "0x9570D0", VA = "0x1809580D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int EPGHPPHAJKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1CCC140", Offset = "0x1CCB140", VA = "0x181CCC140")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3909A80", Offset = "0x3908A80", VA = "0x183909A80")]
		public JONMPKIGFGC(NativeArray<TSrc> FHOLKIOOKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3909900", Offset = "0x3908900", VA = "0x183909900")]
		public bool IONEFAECJHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3909910", Offset = "0x3908910", VA = "0x183909910")]
		private TSrc KOJELGHJPNP(int LNBKADIBNBM)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct IHMLHPGLFNE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IHDGDPNGEKH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private JONMPKIGFGC<TSrc, TValue, TSelector> EKKLLDJDCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue EBLMHPAOJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int HOLHNBPNHFM;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public HFBGOGMEEFA BNNMEPLCJOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x373E810", Offset = "0x373D810", VA = "0x18373E810")]
			get
			{
				return default(HFBGOGMEEFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue KOIDEOJJOKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x775DA0", Offset = "0x774DA0", VA = "0x180775DA0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, HFBGOGMEEFA range) PADEIDMLAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x373E990", Offset = "0x373D990", VA = "0x18373E990")]
			get
			{
				return default((TValue, HFBGOGMEEFA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x373EA70", Offset = "0x373DA70", VA = "0x18373EA70")]
		public IHMLHPGLFNE(NativeArray<TSrc> FHOLKIOOKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x362A360", Offset = "0x3629360", VA = "0x18362A360")]
		public IHMLHPGLFNE<TSrc, TValue, TSelector> PKEKCLMIDEH()
		{
			return default(IHMLHPGLFNE<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x373E850", Offset = "0x373D850", VA = "0x18373E850")]
		public bool IONEFAECJHK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x24DFC70", Offset = "0x24DEC70", VA = "0x1824DFC70")]
	public static MIPOPGBNEII<T> DBNLMHGEDAD<T>(this NativeList<T> LOKHPAFMLOJ) where T : struct
	{
		return default(MIPOPGBNEII<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0")]
	public static MIPOPGBNEII<T> DBNLMHGEDAD<T>(this NativeArray<T> FHOLKIOOKFG) where T : struct
	{
		return default(MIPOPGBNEII<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class IDIDDAMNPFH
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct COPCDDBHLFP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly FHOLKIOOKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int HOLHNBPNHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int FNBONPPAFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T EBLMHPAOJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T EMHNDEAJNLL;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public HFBGOGMEEFA BNNMEPLCJOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x38D0BD0", Offset = "0x38CFBD0", VA = "0x1838D0BD0")]
			get
			{
				return default(HFBGOGMEEFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T KOIDEOJJOKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x3171D20", Offset = "0x3170D20", VA = "0x183171D20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, HFBGOGMEEFA) PADEIDMLAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x48EBCE0", Offset = "0x48EACE0", VA = "0x1848EBCE0")]
			get
			{
				return default((T, HFBGOGMEEFA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x48EBEA0", Offset = "0x48EAEA0", VA = "0x1848EBEA0")]
		public COPCDDBHLFP(NativeArray<T> FHOLKIOOKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x48EBE60", Offset = "0x48EAE60", VA = "0x1848EBE60")]
		public COPCDDBHLFP<T> PKEKCLMIDEH()
		{
			return default(COPCDDBHLFP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x48EB930", Offset = "0x48EA930", VA = "0x1848EB930")]
		public bool IONEFAECJHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2E05A40", Offset = "0x2E04A40", VA = "0x182E05A40")]
		public JDMNIFFJLIN<T, TComparer> GBEFEJEBDAN<TComparer>([Optional] TComparer DPCOIAEMLLN) where TComparer : struct, IEqualityComparer<T>
		{
			return default(JDMNIFFJLIN<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct JDMNIFFJLIN<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly FHOLKIOOKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int HOLHNBPNHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int FNBONPPAFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T EBLMHPAOJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T EMHNDEAJNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer DPCOIAEMLLN;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public HFBGOGMEEFA BNNMEPLCJOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x38D0BD0", Offset = "0x38CFBD0", VA = "0x1838D0BD0")]
			get
			{
				return default(HFBGOGMEEFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T KOIDEOJJOKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x3171D20", Offset = "0x3170D20", VA = "0x183171D20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, HFBGOGMEEFA range) PADEIDMLAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x38D0DC0", Offset = "0x38CFDC0", VA = "0x1838D0DC0")]
			get
			{
				return default((T, HFBGOGMEEFA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x38D0ED0", Offset = "0x38CFED0", VA = "0x1838D0ED0")]
		public JDMNIFFJLIN(NativeArray<T>.ReadOnly FHOLKIOOKFG, TComparer DPCOIAEMLLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x38D0E90", Offset = "0x38CFE90", VA = "0x1838D0E90")]
		public JDMNIFFJLIN<T, TComparer> PKEKCLMIDEH()
		{
			return default(JDMNIFFJLIN<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x38D0BE0", Offset = "0x38CFBE0", VA = "0x1838D0BE0")]
		public bool IONEFAECJHK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x250B5A0", Offset = "0x250A5A0", VA = "0x18250B5A0")]
	public static COPCDDBHLFP<T> NHLHLGIAJNN<T>(this NativeArray<T> FHOLKIOOKFG) where T : struct
	{
		return default(COPCDDBHLFP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface LODAGMGLGPH
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class NCBCCAGFHNH
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct NKKCHHMDCED<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class DDENEPIINEE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NKKCHHMDCED<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9C95B0", Offset = "0x9C85B0", VA = "0x1809C95B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x34AB9F0", Offset = "0x34AA9F0", VA = "0x1834AB9F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public DDENEPIINEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4D91B70", Offset = "0x4D90B70", VA = "0x184D91B70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4D91D20", Offset = "0x4D90D20", VA = "0x184D91D20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> NCNMDNOOKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream EODNJPIMPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream EEMLPANJIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf KDFFFMLCHKE;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int EPGHPPHAJKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8620A0", Offset = "0x8610A0", VA = "0x1808620A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3D25690", Offset = "0x3D24690", VA = "0x183D25690")]
	private NKKCHHMDCED(byte[] DOAIHCCMJDP, Action<Protobuf> NCNMDNOOKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x242E820", Offset = "0x242D820", VA = "0x18242E820")]
	public static NKKCHHMDCED<Protobuf> BJANKEDJCNP<Data>(ReadOnlySpan<byte> LNCOLHOCFJN, ReadOnlySpan<Data> DHAGBOIMPBD, Action<Protobuf> NCNMDNOOKKD)
	{
		return default(NKKCHHMDCED<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3D25500", Offset = "0x3D24500", VA = "0x183D25500", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3D25540", Offset = "0x3D24540", VA = "0x183D25540", Slot = "4")]
	[IteratorStateMachine(typeof(NKKCHHMDCED<>.DDENEPIINEE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3D25630", Offset = "0x3D24630", VA = "0x183D25630", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct FAMLFGCGLHA<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] DOAIHCCMJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf KDFFFMLCHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream EODNJPIMPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream DPMAMBPFLKI;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3446790", Offset = "0x3445790", VA = "0x183446790")]
	private FAMLFGCGLHA(byte[] DOAIHCCMJDP, [In] Protobuf KDFFFMLCHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2E0ACD0", Offset = "0x2E09CD0", VA = "0x182E0ACD0")]
	public static FAMLFGCGLHA<Protobuf> BJANKEDJCNP<T>(ReadOnlySpan<T> DHAGBOIMPBD)
	{
		return default(FAMLFGCGLHA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3446760", Offset = "0x3445760", VA = "0x183446760")]
	public void OIPPJKCOLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x34466D0", Offset = "0x34456D0", VA = "0x1834466D0")]
	public ByteString KOBOCMAMHIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x34465A0", Offset = "0x34455A0", VA = "0x1834465A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct EKBJIBHGOOC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream EODNJPIMPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream EEMLPANJIBL;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5EC62D0", Offset = "0x5EC52D0", VA = "0x185EC62D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct EJHIAEMAIHD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] DOAIHCCMJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream EODNJPIMPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream DPMAMBPFLKI;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5F00", Offset = "0x5EC4F00", VA = "0x185EC5F00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class PHJGALLKINB
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void MPBBFJJJKDH<From, To>(From AEMKIPDFHEB, To HPCDKOJJCBN, HNBGCPCCNKG OPHMJAFDELD);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class EFEBCFDHICE<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static MPBBFJJJKDH<From, To> EPBJLPKHFAL;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public EFEBCFDHICE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7370", Offset = "0x5EC6370", VA = "0x185EC7370")]
	static PHJGALLKINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x264AC40", Offset = "0x2649C40", VA = "0x18264AC40")]
	public static void PCDPMIFCHLN<T>(MPBBFJJJKDH<T, T> AAGMCAAMDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x264B400", Offset = "0x264A400", VA = "0x18264B400")]
	public static void PCDPMIFCHLN<From, To>(MPBBFJJJKDH<From, To> AAGMCAAMDGB, MPBBFJJJKDH<To, From> DNHKJJLHBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x264A9D0", Offset = "0x26499D0", VA = "0x18264A9D0")]
	public static void PCDPMIFCHLN<From, To>(MPBBFJJJKDH<From, To> EPBJLPKHFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x264E7E0", Offset = "0x264D7E0", VA = "0x18264E7E0")]
	public static MPBBFJJJKDH<From, To> PLMBBEFCENK<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2648770", Offset = "0x2647770", VA = "0x182648770")]
	public static void KHMKEDFKPIC<From, To>(From AEMKIPDFHEB, To HPCDKOJJCBN, HNBGCPCCNKG OPHMJAFDELD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class HNBGCPCCNKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> JIBIEHLGCLI;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1C91B30", Offset = "0x1C90B30", VA = "0x181C91B30")]
	public HNBGCPCCNKG(NativeArray<EntityRemapUtility.EntityRemapInfo> JIBIEHLGCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EC68A0", Offset = "0x5EC58A0", VA = "0x185EC68A0")]
	public Entity NDFCAKJLADH(Entity ONDDMEPBDDI)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class CIOGJJLHCPC
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5B80", Offset = "0x5EC4B80", VA = "0x185EC5B80")]
	public static ulong CNOIKILPCAN(Type CFGJPNBLNDJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5C10", Offset = "0x5EC4C10", VA = "0x185EC5C10")]
	public static ulong CNOIKILPCAN(string FAPMPALHAJP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum OPJFPDKMOCP
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
public class JAENGFDPEOJ : GBHCDPMMINH
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x780100", Offset = "0x77F100", VA = "0x180780100")]
	public JAENGFDPEOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class EJLEAOLPCJP
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6090", Offset = "0x5EC5090", VA = "0x185EC6090")]
	private unsafe static Span<byte> GDPIINHGPGK(Unity.Entities.Chunk* LGELEHBGOKE, int JPADAKIILJM)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x23BD540", Offset = "0x23BC540", VA = "0x1823BD540")]
	public unsafe static Span<T> MFCPMBEDDAE<T>(Unity.Entities.Chunk* LGELEHBGOKE, int JPADAKIILJM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x23BD510", Offset = "0x23BC510", VA = "0x1823BD510")]
	public static Span<T> MFCPMBEDDAE<T>(this Unity.Entities.Chunk LGELEHBGOKE, int JPADAKIILJM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6030", Offset = "0x5EC5030", VA = "0x185EC6030")]
	public unsafe static Span<Entity> AOLGBJHIIDN(Unity.Entities.Chunk* LGELEHBGOKE)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6160", Offset = "0x5EC5160", VA = "0x185EC6160")]
	public unsafe static void PMEKKAMOFIE(Unity.Entities.Chunk* LGELEHBGOKE, int JPADAKIILJM)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class OHHMJHHAJKD
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public OHHMJHHAJKD()
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

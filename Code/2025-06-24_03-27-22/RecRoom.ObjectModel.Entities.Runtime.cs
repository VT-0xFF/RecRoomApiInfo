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
using RecRoom;
using Unity.Burst;
using Unity.Burst.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F883A0", Offset = "0x7F86FA0", VA = "0x187F883A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F87AD0", Offset = "0x7F866D0", VA = "0x187F87AD0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NDGFBGBBCFA : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	POLGAOBAGKI LMODLJNFGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KNJKLJHJDMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFBFJGPHJFM(Entity JMNEAPNCNHN, object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BKFOMEKPDFH(Entity JMNEAPNCNHN, object HEDGIMBCGHA, [Out] bool KKMNCPHDMFH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GDGEOICOELD(Entity JMNEAPNCNHN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KKAKFCDPKCF<TComponentData, TValue> : AAFLHNCNHLM<TValue>, IDisposable where TComponentData : struct, NDGFBGBBCFA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class OIAHMMHMGJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> DNNGKIFFAHG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int OJAJOFHLGMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x428CDB0", Offset = "0x428B9B0", VA = "0x18428CDB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5665D20", Offset = "0x5664920", VA = "0x185665D20")]
		public bool IIGKEALBIPE([Out] TValue OOHGFGHCOAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5665DF0", Offset = "0x56649F0", VA = "0x185665DF0")]
		public void NKAMMCABBBC(object HEDGIMBCGHA, TValue OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5665CA0", Offset = "0x56648A0", VA = "0x185665CA0")]
		public bool HMCNGGMNMHK(object HEDGIMBCGHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5665EA0", Offset = "0x5664AA0", VA = "0x185665EA0")]
		public int OJMMCCEOOLO(object HEDGIMBCGHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5665F80", Offset = "0x5664B80", VA = "0x185665F80")]
		public OIAHMMHMGJA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<OIAHMMHMGJA> KKMJPNHCLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private ELOOCDDJBDF<POLGAOBAGKI, OIAHMMHMGJA> JOHJJANDNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager HGAKBEIGHGE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x51EE440", Offset = "0x51ED040", VA = "0x1851EE440")]
	public KKAKFCDPKCF(EntityManager HGAKBEIGHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x51EE000", Offset = "0x51ECC00", VA = "0x1851EE000", Slot = "4")]
	public void EFBFJGPHJFM(Entity JMNEAPNCNHN, object HEDGIMBCGHA, TValue OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x51EDE60", Offset = "0x51ECA60", VA = "0x1851EDE60", Slot = "5")]
	public bool BKFOMEKPDFH(Entity JMNEAPNCNHN, object HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x51EE1F0", Offset = "0x51ECDF0", VA = "0x1851EE1F0", Slot = "6")]
	public bool IIGKEALBIPE(Entity JMNEAPNCNHN, [Out] TValue OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x51EDFE0", Offset = "0x51ECBE0", VA = "0x1851EDFE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x51EE2D0", Offset = "0x51ECED0", VA = "0x1851EE2D0")]
	private void LDHBEINBAND(OIAHMMHMGJA KFEECOMMJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x51EE140", Offset = "0x51ECD40", VA = "0x1851EE140")]
	private bool GCMIFAKGIDM(Entity JMNEAPNCNHN, [Out] POLGAOBAGKI BEPAMKMBKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x51EE360", Offset = "0x51ECF60", VA = "0x1851EE360")]
	private void MFIKAIMKJJC(Entity JMNEAPNCNHN, POLGAOBAGKI BEPAMKMBKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x51EE120", Offset = "0x51ECD20", VA = "0x1851EE120")]
	private bool FOKAJCPKJMN(POLGAOBAGKI BEPAMKMBKNC, [Out] OIAHMMHMGJA KFEECOMMJMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x51EDD80", Offset = "0x51EC980", VA = "0x1851EDD80")]
	private OIAHMMHMGJA ANILFKFEABL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AAFLHNCNHLM<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFBFJGPHJFM(Entity JMNEAPNCNHN, object HEDGIMBCGHA, TValue OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BKFOMEKPDFH(Entity JMNEAPNCNHN, object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IIGKEALBIPE(Entity JMNEAPNCNHN, [Out] TValue OOHGFGHCOAJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct POLGAOBAGKI : PNKHKLJALOP, IEquatable<POLGAOBAGKI>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly POLGAOBAGKI CBFHDBFDJFA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int FCJKCAOMEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int DLHOIMFANJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2FF6F80", Offset = "0x2FF5B80", VA = "0x182FF6F80", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4900", Offset = "0x6FA3500", VA = "0x186FA4900", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F887D0", Offset = "0x7F873D0", VA = "0x187F887D0", Slot = "8")]
	public bool Equals(POLGAOBAGKI GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F88820", Offset = "0x7F87420", VA = "0x187F88820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BHENEFJBGPC<THasTokensTag> : KNJKLJHJDMK, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, POLGAOBAGKI> NLLMJJIKCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> KKMJPNHCLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ELOOCDDJBDF<POLGAOBAGKI, HashSet<object>> JOHJJANDNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager HGAKBEIGHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem LACOBAHMAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool HPDIEOLMMOM;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63AB610", Offset = "0x63AA210", VA = "0x1863AB610")]
	public BHENEFJBGPC(EntityManager HGAKBEIGHGE, EntityCommandBufferSystem LACOBAHMAHJ, JPIBGNDAFKP EBAEGCHIPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63AA140", Offset = "0x63A8D40", VA = "0x1863AA140", Slot = "4")]
	public bool EFBFJGPHJFM(Entity JMNEAPNCNHN, object HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63A9050", Offset = "0x63A7C50", VA = "0x1863A9050", Slot = "5")]
	public bool BKFOMEKPDFH(Entity JMNEAPNCNHN, object HEDGIMBCGHA, [Out] bool KKMNCPHDMFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63AAB30", Offset = "0x63A9730", VA = "0x1863AAB30", Slot = "6")]
	public bool GDGEOICOELD(Entity JMNEAPNCNHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x63AAA80", Offset = "0x63A9680", VA = "0x1863AAA80", Slot = "8")]
	public bool GDGEOICOELD(POLGAOBAGKI BEPAMKMBKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63A9BD0", Offset = "0x63A87D0", VA = "0x1863A9BD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63AB290", Offset = "0x63A9E90", VA = "0x1863AB290")]
	private void LDHBEINBAND(HashSet<object> KFEECOMMJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x63AA790", Offset = "0x63A9390", VA = "0x1863AA790")]
	private bool GCMIFAKGIDM(Entity JMNEAPNCNHN, [Out] POLGAOBAGKI BEPAMKMBKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x63A9780", Offset = "0x63A8380", VA = "0x1863A9780")]
	private bool CPIAFHLGIFM(Entity JMNEAPNCNHN, [Out] POLGAOBAGKI BEPAMKMBKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x63AA5D0", Offset = "0x63A91D0", VA = "0x1863AA5D0")]
	private void FMOGLPPEIFK(Entity JMNEAPNCNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x63AB010", Offset = "0x63A9C10", VA = "0x1863AB010")]
	private void GILFJNLNIDF(Entity JMNEAPNCNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x63A9A10", Offset = "0x63A8610", VA = "0x1863A9A10")]
	private void DNAAAEEDGOO(Entity JMNEAPNCNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x63AB5A0", Offset = "0x63AA1A0", VA = "0x1863AB5A0")]
	private void MFIKAIMKJJC(Entity JMNEAPNCNHN, POLGAOBAGKI BEPAMKMBKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x63AB110", Offset = "0x63A9D10", VA = "0x1863AB110")]
	private bool ILOLOLIBFOH(POLGAOBAGKI BEPAMKMBKNC, [Out] HashSet<object> KFEECOMMJMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63A8FB0", Offset = "0x63A7BB0", VA = "0x1863A8FB0")]
	private HashSet<object> ANILFKFEABL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JGBEOBJOKNH
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct AGOCIALCBMK : NJHDMGIJODE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F87780", Offset = "0x7F86380", VA = "0x187F87780")]
	public float LJKHFOFMFJM([In] float3 OOHGFGHCOAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F87780", Offset = "0x7F86380", VA = "0x187F87780", Slot = "4")]
	private float MHCNIBLIHIG([In] float3 OOHGFGHCOAJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FEGGLPLEBEJ : NJHDMGIJODE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F87BF0", Offset = "0x7F867F0", VA = "0x187F87BF0")]
	public float LJKHFOFMFJM([In] float3 OOHGFGHCOAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F87BF0", Offset = "0x7F867F0", VA = "0x187F87BF0", Slot = "4")]
	private float MHCNIBLIHIG([In] float3 OOHGFGHCOAJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HFEINGJDHKO : NJHDMGIJODE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xF1A820", Offset = "0xF19420", VA = "0x180F1A820")]
	public float LJKHFOFMFJM([In] float3 OOHGFGHCOAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xF1A820", Offset = "0xF19420", VA = "0x180F1A820", Slot = "4")]
	private float MHCNIBLIHIG([In] float3 OOHGFGHCOAJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DEOBBMFHPCL : NJHDMGIJODE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2329350", Offset = "0x2327F50", VA = "0x182329350")]
	public int LJKHFOFMFJM([In] int3 OOHGFGHCOAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2329350", Offset = "0x2327F50", VA = "0x182329350", Slot = "4")]
	private int PGIMDHABPMO([In] int3 OOHGFGHCOAJ)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JEIJGAGCGII : NJHDMGIJODE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x12B0DE0", Offset = "0x12AF9E0", VA = "0x1812B0DE0")]
	public int LJKHFOFMFJM([In] int3 OOHGFGHCOAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x12B0DE0", Offset = "0x12AF9E0", VA = "0x1812B0DE0", Slot = "4")]
	private int PGIMDHABPMO([In] int3 OOHGFGHCOAJ)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct GKMOINMLEEC : NJHDMGIJODE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xF00280", Offset = "0xEFEE80", VA = "0x180F00280")]
	public int LJKHFOFMFJM([In] int3 OOHGFGHCOAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xF00280", Offset = "0xEFEE80", VA = "0x180F00280", Slot = "4")]
	private int PGIMDHABPMO([In] int3 OOHGFGHCOAJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HEMGNMIBOCM : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x220C420", Offset = "0x220B020", VA = "0x18220C420")]
	public HEMGNMIBOCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class BCHHLKDMOPB : SystemBase, DGNPHCILKBG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string AJPMCBKCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F87880", Offset = "0x7F86480", VA = "0x187F87880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x38332C0", Offset = "0x3831EC0", VA = "0x1838332C0")]
	public void JLLKELELCDC<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x38332C0", Offset = "0x3831EC0", VA = "0x1838332C0")]
	public void NMBKKFNJHOJ<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F877C0", Offset = "0x7F863C0", VA = "0x187F877C0")]
	public JobHandle GBAPKIGFBPB(ReadOnlySpan<int> MJALPMMKMLN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3833FE0", Offset = "0x3832BE0", VA = "0x183833FE0")]
	public JobHandle PLDIOLJBCGB<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F87A40", Offset = "0x7F86640", VA = "0x187F87A40")]
	public JobHandle PLDIOLJBCGB(ReadOnlySpan<int> MJALPMMKMLN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x38333D0", Offset = "0x3831FD0", VA = "0x1838333D0")]
	public void NLGBHOJOHHJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x38337A0", Offset = "0x38323A0", VA = "0x1838337A0")]
	public JobHandle NLGBHOJOHHJ<T>(JobHandle BEPAMKMBKNC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F87970", Offset = "0x7F86570", VA = "0x187F87970")]
	public JobHandle NLGBHOJOHHJ(ReadOnlySpan<int> MJALPMMKMLN, JobHandle BEPAMKMBKNC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x38333D0", Offset = "0x3831FD0", VA = "0x1838333D0")]
	public void LCHBNOHDHAK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3833310", Offset = "0x3831F10", VA = "0x183833310")]
	public JobHandle LCHBNOHDHAK<T>(JobHandle BEPAMKMBKNC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F87810", Offset = "0x7F86410", VA = "0x187F87810")]
	public JobHandle LCHBNOHDHAK(Span<int> MJALPMMKMLN, JobHandle BEPAMKMBKNC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x38336F0", Offset = "0x38322F0", VA = "0x1838336F0")]
	public ComponentDataFromEntity NIBPFCDLMNF<T>(bool NICELLELNGE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F878B0", Offset = "0x7F864B0", VA = "0x187F878B0")]
	public ComponentDataFromEntity NIBPFCDLMNF(int PCPIAGCOKAF, bool NICELLELNGE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3833220", Offset = "0x3831E20", VA = "0x183833220")]
	public SharedComponentIndexFromEntity<T> ICKGIHIOKLA<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F879E0", Offset = "0x7F865E0", VA = "0x187F879E0")]
	[BurstCompatible]
	public ComponentTypeHandle OIHDGLJCPCH(ComponentType MCNLEPLIBHJ)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F877A0", Offset = "0x7F863A0", VA = "0x187F877A0")]
	public EntityExistenceLookupByEntity BIDIFLJKAAD()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F87A90", Offset = "0x7F86690", VA = "0x187F87A90", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3833660", Offset = "0x3832260", VA = "0x183833660")]
	public bool MKCIHNPJAGM<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x220C420", Offset = "0x220B020", VA = "0x18220C420")]
	protected BCHHLKDMOPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class NLIIFLIOBJA : BCHHLKDMOPB
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F880E0", Offset = "0x7F86CE0", VA = "0x187F880E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x220C420", Offset = "0x220B020", VA = "0x18220C420")]
	protected NLIIFLIOBJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MHAEADDKGLG
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BCNKODJNHND : EntityCommandBufferSystem, DGNPHCILKBG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JPIBGNDAFKP HOEGMFFOKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE22F20", Offset = "0xE21B20", VA = "0x180E22F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F87AA0", Offset = "0x7F866A0", VA = "0x187F87AA0")]
	public BCNKODJNHND(JPIBGNDAFKP FAOMHPPHFKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NJHDMGIJODE<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LJKHFOFMFJM([In] TFrom OOHGFGHCOAJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PKFIDGNCAGI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBMJFBENNGB(T OOHGFGHCOAJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct OHIBNPIOMJI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> NKHJILJFELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer INAJDPGHEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes ONPALAGGLAB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F88420", Offset = "0x7F87020", VA = "0x187F88420", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct ABBBEPKCMFM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> NKHJILJFELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer INAJDPGHEJJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F87650", Offset = "0x7F86250", VA = "0x187F87650", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct KJLOMBCDHMN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> NKHJILJFELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer INAJDPGHEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType MCNLEPLIBHJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F87F90", Offset = "0x7F86B90", VA = "0x187F87F90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct PLFFGOPMBCB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> NKHJILJFELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> PEDMEJIDLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer INAJDPGHEJJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x57E19A0", Offset = "0x57E05A0", VA = "0x1857E19A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct PADAMJCOGPA<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> NKHJILJFELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> AIPJHMCGMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer INAJDPGHEJJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct CAEKBELDPGN<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> NKHJILJFELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T OOHGFGHCOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer INAJDPGHEJJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct LENHLDBMBLL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NJHDMGIJODE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> FGAIMNFMHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> AEPEAFOALCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap IFDCDCHOGGB;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct FAEBENPPIOF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity NNPJBLFAHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> FGAIMNFMHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> AEPEAFOALCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int JEJNLLILMLG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F87AF0", Offset = "0x7F866F0", VA = "0x187F87AF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct CAONFAADPDC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BLHFHBJIIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> FGAIMNFMHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> OOGMFAMIOLG;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct GNNFHCKPDBJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NJHDMGIJODE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> IKCPFNGGLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> AEPEAFOALCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap IFDCDCHOGGB;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct BAKAAKMNEIC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GFHGDIFNAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> OLBGCPBHGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> NNHJPDEGLIL;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct IMOJJPFBCAI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GFHGDIFNAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> OLBGCPBHGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> NNHJPDEGLIL;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4E82370", Offset = "0x4E80F70", VA = "0x184E82370", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct FNPILAOILLO<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> FGAIMNFMHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> OOGMFAMIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> EHEMLAPPKKF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4C21E90", Offset = "0x4C20A90", VA = "0x184C21E90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct HEGLMACLPPL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : NJHDMGIJODE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> FGAIMNFMHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> OOGMFAMIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> EHEMLAPPKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap IFDCDCHOGGB;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct GKHPKHJFMAO<T, TPredicate> : IJob where T : struct where TPredicate : struct, PKFIDGNCAGI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> FGAIMNFMHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> BNONFPFPJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> KBAAOAPMJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate IFDCDCHOGGB;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct HNPKJDIALAP<T, TPredicate> : IJob where T : struct where TPredicate : struct, PKFIDGNCAGI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> FGAIMNFMHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> OOGMFAMIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate IFDCDCHOGGB;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct IDPGIOKNHMD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity GFHGDIFNAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> OLBGCPBHGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> NFOGBJFONAO;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F87D20", Offset = "0x7F86920", VA = "0x187F87D20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct MCOCOCEHJML : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity GFHGDIFNAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> OLBGCPBHGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> NFOGBJFONAO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7F88050", Offset = "0x7F86C50", VA = "0x187F88050", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class GPLMPMBCBMJ
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class KIDDEHJGGAN
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3B685F0", Offset = "0x3B671F0", VA = "0x183B685F0")]
	public static bool GBLCBCHGOMN<T>(this NativeArray<Entity> OLBGCPBHGIK, EntityManager HGAKBEIGHGE, Allocator CMJGNOOCEGA = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class AGNFMIIFLKC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class ANOPCACPFCP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public ANOPCACPFCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class JHHPAKEPMLG<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public JHHPAKEPMLG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> HMEIOAMPLKJ;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7F876F0", Offset = "0x7F862F0", VA = "0x187F876F0")]
	public AGNFMIIFLKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AIJEHGFFIIL
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class ONAKDAODPBH
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct DAINHJFEFPE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct BGIIDBFJNBG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal DAINHJFEFPE<TFrom> LIPFJJEAFCE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> ENEAIMANIIG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct ECJHEDGCKKK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct GFBDBOBNAEM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal ECJHEDGCKKK<TFrom> LIPFJJEAFCE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> ENEAIMANIIG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct FAGAKLHAGEC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct NOEJBNNIPNN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal FAGAKLHAGEC<TFrom> LIPFJJEAFCE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> ENEAIMANIIG;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct JJCNCHKEOEF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct GEBLHJJLJKB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal JJCNCHKEOEF<TFrom> LIPFJJEAFCE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> ENEAIMANIIG;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JMLPKMBHLEI
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class CEFCDCDGHPE
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3896BE0", Offset = "0x38957E0", VA = "0x183896BE0")]
	public static NativeList<T> EEONLNICANG<T>(this NativeArray<T> IJLCLCILCDL, Allocator CMJGNOOCEGA = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class JMBJLPHCOJP
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class POABKLIHGML
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3C88350", Offset = "0x3C86F50", VA = "0x183C88350")]
	[OFJELFFNKCM]
	public static JobHandle ODEGNFKPLIN<T>(this EntityCommandBufferSystem LACOBAHMAHJ, NativeArray<Entity> NKHJILJFELH, NativeArray<T> PEDMEJIDLNB) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3C881F0", Offset = "0x3C86DF0", VA = "0x183C881F0")]
	[OFJELFFNKCM]
	public static JobHandle ODEGNFKPLIN<T>(this EntityCommandBufferSystem LACOBAHMAHJ, NativeArrayAsync<Entity> NKHJILJFELH, NativeArrayAsync<T> PEDMEJIDLNB, [Optional] JobHandle OLHPIOMJOOH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3C880D0", Offset = "0x3C86CD0", VA = "0x183C880D0")]
	[OFJELFFNKCM]
	public static JobHandle ODEGNFKPLIN<T>(this EntityCommandBufferSystem LACOBAHMAHJ, NativeArray<Entity> NKHJILJFELH, [Optional] JobHandle OLHPIOMJOOH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F88660", Offset = "0x7F87260", VA = "0x187F88660")]
	[OFJELFFNKCM]
	public static JobHandle ODEGNFKPLIN(this EntityCommandBufferSystem LACOBAHMAHJ, NativeArray<Entity> NKHJILJFELH, ComponentTypes ONPALAGGLAB, [Optional] JobHandle OLHPIOMJOOH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F88510", Offset = "0x7F87110", VA = "0x187F88510")]
	[OFJELFFNKCM]
	public static JobHandle ODEGNFKPLIN(this EntityCommandBufferSystem LACOBAHMAHJ, EntityCommandBuffer INAJDPGHEJJ, NativeArray<Entity> NKHJILJFELH, ComponentTypes ONPALAGGLAB, [Optional] JobHandle OLHPIOMJOOH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EPAKMGLCMHN
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class NOOJIEIPPJO
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F88210", Offset = "0x7F86E10", VA = "0x187F88210")]
	[OFJELFFNKCM]
	public static JobHandle AEOJMAODPKC(this EntityCommandBufferSystem LACOBAHMAHJ, NativeList<Entity> NKHJILJFELH, [Optional] JobHandle OLHPIOMJOOH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7F88110", Offset = "0x7F86D10", VA = "0x187F88110")]
	[OFJELFFNKCM]
	public static JobHandle AEOJMAODPKC(this EntityCommandBufferSystem LACOBAHMAHJ, NativeArrayAsync<Entity> NKHJILJFELH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class AALMJAMAKKC
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3031300", Offset = "0x302FF00", VA = "0x183031300")]
	public static void LHFFHAGDLLK<T>(this EntityCommandBufferSystem LACOBAHMAHJ, EntityQuery KPNAGIAKBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3031260", Offset = "0x302FE60", VA = "0x183031260")]
	[OFJELFFNKCM]
	public static JobHandle DMGNKDCKLNC<T>(this EntityCommandBufferSystem LACOBAHMAHJ, NativeArrayAsync<Entity> NKHJILJFELH, [Optional] JobHandle OLHPIOMJOOH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F874C0", Offset = "0x7F860C0", VA = "0x187F874C0")]
	[OFJELFFNKCM]
	public static JobHandle DMGNKDCKLNC(this EntityCommandBufferSystem LACOBAHMAHJ, NativeArrayAsync<Entity> NKHJILJFELH, ComponentType MCNLEPLIBHJ, [Optional] JobHandle OLHPIOMJOOH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class POALBKOJCDF
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3C886E0", Offset = "0x3C872E0", VA = "0x183C886E0")]
	[OFJELFFNKCM]
	public static JobHandle JODFCAOAPFN<T>(this EntityCommandBufferSystem LACOBAHMAHJ, NativeArray<Entity> NKHJILJFELH, NativeArray<T> PEDMEJIDLNB, JobHandle OLHPIOMJOOH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class CGFOINPDLDH
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NHGCCGMAJNO
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JDOEHMDPJDE
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3B1EBD0", Offset = "0x3B1D7D0", VA = "0x183B1EBD0")]
	public static NativeArray<T> FILCJFFPPCK<T>(this NativeList<Entity> IJLCLCILCDL, EntityManager HGAKBEIGHGE, Allocator CMJGNOOCEGA = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3B1EA10", Offset = "0x3B1D610", VA = "0x183B1EA10")]
	public static NativeArray<T> FILCJFFPPCK<T>(this NativeArray<Entity> IJLCLCILCDL, EntityManager HGAKBEIGHGE, Allocator CMJGNOOCEGA = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F87DB0", Offset = "0x7F869B0", VA = "0x187F87DB0")]
	public static NativeArray<Entity> EBPGHKINEKL(this NativeArray<Entity> IJLCLCILCDL, EntityManager HGAKBEIGHGE, ComponentType MCNLEPLIBHJ, Allocator CMJGNOOCEGA = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F320", Offset = "0x3B1DF20", VA = "0x183B1F320")]
	public static NativeArray<T> PFCCECMGIKA<T>(this NativeArray<Entity> IJLCLCILCDL, EntityManager HGAKBEIGHGE, Allocator CMJGNOOCEGA = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class EMOIEHADNDK
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct HJBAOGEFMMD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct LDPNOMHBIMK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public HJBAOGEFMMD<TFrom> ENEAIMANIIG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> FGAIMNFMHIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct ICNGEIHBDJP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct HGAFEMJFMAF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public ICNGEIHBDJP<TFrom> ENEAIMANIIG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> FGAIMNFMHIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct DEFPKIIOBDG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct OPHAMFJCHKJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public DEFPKIIOBDG<TFrom> ENEAIMANIIG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> FGAIMNFMHIB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NFBKBJIEFCH
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class LPAINFJAMCK
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct BAADOEMGJKP : NJHDMGIJODE<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> KPBJEHDGCEO;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7F87790", Offset = "0x7F86390", VA = "0x187F87790")]
		[BurstCompatible]
		public Entity LJKHFOFMFJM([In] Entity OOHGFGHCOAJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7F87790", Offset = "0x7F86390", VA = "0x187F87790", Slot = "4")]
		private Entity OFAPGFHBAPG([In] Entity OOHGFGHCOAJ)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class OGMIOKIHGKC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct NBOPCHDJOMJ<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x551A490", Offset = "0x5519090", VA = "0x18551A490", Slot = "4")]
		public int Compare((TKey, TValue) KFGAJBKADFK, (TKey, TValue) FEABMDLFEMA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3C729A0", Offset = "0x3C715A0", VA = "0x183C729A0")]
	public static void FODDEDLHKEL<TKey, TValue>(NativeList<TKey> LEECCEKENMA, NativeList<TValue> AIPJHMCGMIB) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3C72C10", Offset = "0x3C71810", VA = "0x183C72C10")]
	public static void FODDEDLHKEL<TKey, TValue>(NativeArray<TKey> LEECCEKENMA, NativeArray<TValue> AIPJHMCGMIB) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3C72DD0", Offset = "0x3C719D0", VA = "0x183C72DD0")]
	public static void FODDEDLHKEL<TKey, TValue, U>(NativeArray<TKey> LEECCEKENMA, NativeArray<TValue> AIPJHMCGMIB, U JHNKKDPNALJ) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class IDCGFKGKHKM
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct IAFNOBMIHBP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> BNONFPFPJOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> FGAIMNFMHIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct DPNKJJOAHNM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> BNONFPFPJOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> FGAIMNFMHIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct MOEPBNGMKPL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> BNONFPFPJOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> FGAIMNFMHIB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class JNKKJCANMLE
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class DPBOHHLEGMH
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct HNIGKGJLMLK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> FGAIMNFMHIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct GMEDCPKKFND<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> FGAIMNFMHIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct EOJKMNBJEOF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> FGAIMNFMHIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct ICGJBHGIFJF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator CMJGNOOCEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> FGAIMNFMHIB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class BEBLGOMMLGM
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class DMFDCDNEBJF
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x38ED1B0", Offset = "0x38EBDB0", VA = "0x1838ED1B0")]
	public static NativeList<Entity> FFHNCDFKCBP<T>(this NativeList<Entity> OLBGCPBHGIK, EntityManager HGAKBEIGHGE, Allocator CMJGNOOCEGA = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38ECA30", Offset = "0x38EB630", VA = "0x1838ECA30")]
	public static NativeList<Entity> FFHNCDFKCBP<T>(this NativeArray<Entity> OLBGCPBHGIK, EntityManager HGAKBEIGHGE, Allocator CMJGNOOCEGA = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class OCKOEGDDGNF
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3C68720", Offset = "0x3C67320", VA = "0x183C68720")]
	public static NativeList<Entity> FHDAMEACBGG<T>(this NativeArray<Entity> OLBGCPBHGIK, EntityManager HGAKBEIGHGE, Allocator CMJGNOOCEGA = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class ICBNILFEOIH
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct GPDJDHBAMDO<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> IKALPCJBCLK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct EPJBOGBGHBF<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> IKALPCJBCLK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct HFOPNPDEKJM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NJHDMGIJODE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> IKALPCJBCLK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct ELJNIJILJLF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, NJHDMGIJODE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> IKALPCJBCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector LNCILPLMDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int EMMACFPOKFB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct DALEEACKPKF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NJHDMGIJODE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private ELJNIJILJLF<TSrc, TValue, TSelector> PBCAONFLPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue PGIFGNLIDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int DPCFFPEBOPM;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class GMBIAMAPKHC
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct NHOIFJCIDKF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> IKALPCJBCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int DPCFFPEBOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int CJPMLMCDNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T PGIFGNLIDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T OENFCEMGBJL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public HJOGNENAABH MIFMCOLCAKO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4BED270", Offset = "0x4BEBE70", VA = "0x184BED270")]
			get
			{
				return default(HJOGNENAABH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T CCHJBKKKNPC
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, HJOGNENAABH) FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4BED280", Offset = "0x4BEBE80", VA = "0x184BED280")]
			get
			{
				return default((T, HJOGNENAABH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5523040", Offset = "0x5521C40", VA = "0x185523040")]
		public NHOIFJCIDKF(NativeArray<T> IKALPCJBCLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x42C4180", Offset = "0x42C2D80", VA = "0x1842C4180")]
		public NHOIFJCIDKF<T> MEEEBEDBKAB()
		{
			return default(NHOIFJCIDKF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5522C00", Offset = "0x5521800", VA = "0x185522C00")]
		public bool MNOHJEBJBPH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x41E8A40", Offset = "0x41E7640", VA = "0x1841E8A40")]
		public FEIGDKNHFKK<T, TComparer> IJPCCHNBJDI<TComparer>([Optional] TComparer JHNKKDPNALJ) where TComparer : struct, IEqualityComparer<T>
		{
			return default(FEIGDKNHFKK<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct FEIGDKNHFKK<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> IKALPCJBCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int DPCFFPEBOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int CJPMLMCDNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T PGIFGNLIDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T OENFCEMGBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer JHNKKDPNALJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HJOGNENAABH MIFMCOLCAKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4BED270", Offset = "0x4BEBE70", VA = "0x184BED270")]
			get
			{
				return default(HJOGNENAABH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T CCHJBKKKNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, HJOGNENAABH range) FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x4BED280", Offset = "0x4BEBE80", VA = "0x184BED280")]
			get
			{
				return default((T, HJOGNENAABH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4BED680", Offset = "0x4BEC280", VA = "0x184BED680")]
		public FEIGDKNHFKK(NativeArray<T> IKALPCJBCLK, TComparer JHNKKDPNALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x38E06A0", Offset = "0x38DF2A0", VA = "0x1838E06A0")]
		public FEIGDKNHFKK<T, TComparer> MEEEBEDBKAB()
		{
			return default(FEIGDKNHFKK<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4BED470", Offset = "0x4BEC070", VA = "0x184BED470")]
		public bool MNOHJEBJBPH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7F00", Offset = "0x3AA6B00", VA = "0x183AA7F00")]
	public static NHOIFJCIDKF<T> AKJEOMMHFGN<T>(this NativeArray<T> IKALPCJBCLK) where T : struct
	{
		return default(NHOIFJCIDKF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface FLIHFDMMHNA
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class ABNLIGCIBIE
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct FIOCCDDOALD<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class DLBJMBDHJAI : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public FIOCCDDOALD<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xCADF90", Offset = "0xCACB90", VA = "0x180CADF90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x42C4620", Offset = "0x42C3220", VA = "0x1842C4620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public DLBJMBDHJAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x42C4420", Offset = "0x42C3020", VA = "0x1842C4420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x42C45D0", Offset = "0x42C31D0", VA = "0x1842C45D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> FOENJPCACGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream EHEOFFBMPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream FGABFKDHCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf LHMLMAPKPBE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int COFHLHAAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4C14FE0", Offset = "0x4C13BE0", VA = "0x184C14FE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4C15020", Offset = "0x4C13C20", VA = "0x184C15020", Slot = "4")]
	[IteratorStateMachine(typeof(FIOCCDDOALD<>.DLBJMBDHJAI))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4C15110", Offset = "0x4C13D10", VA = "0x184C15110", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct IJGKDCDDPOK<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] DPMBBHPEMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf LHMLMAPKPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream EHEOFFBMPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream LEADNMIIJJM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CEF0", Offset = "0x4E7BAF0", VA = "0x184E7CEF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct LNHLIFCJNON : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream EHEOFFBMPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream FGABFKDHCNA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F88010", Offset = "0x7F86C10", VA = "0x187F88010", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct FNHDNGODMGH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] DPMBBHPEMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream EHEOFFBMPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream LEADNMIIJJM;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F87C00", Offset = "0x7F86800", VA = "0x187F87C00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class FFGCAJPBOFJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class HBGOKELBLEL
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum PNAFCPAOAPE
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class NLBAECIHHLL
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class GCLFJLNKBGD
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public GCLFJLNKBGD()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
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

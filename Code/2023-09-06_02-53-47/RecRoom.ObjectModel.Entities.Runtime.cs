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
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
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
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F00200", Offset = "0x6EFE800", VA = "0x186F00200")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FEKNCDMAKKI
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class POKJMOLDDNF<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] KONKLNLEGDB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1C8ECC0", Offset = "0x1C8D2C0", VA = "0x181C8ECC0")]
	public static void GDPEAENNECB<TField>(int OLGOBCPPPBB, string ECMAPGHKHFB, ELBEJOMIKKE IFBKJBDGNKE, out FEHHJLHONFC<TField> JCPKNOEICEG) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1C8FF70", Offset = "0x1C8E570", VA = "0x181C8FF70")]
	public static void LANKNBAGAMB<TField>(int OLGOBCPPPBB, string ECMAPGHKHFB, out GOHNKJBJJHB<TField> EFINPLKEDMK) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class KACJPPDMKKP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F012B0", Offset = "0x6EFF8B0", VA = "0x186F012B0")]
	public static FieldInfo[] LGANOHPPJAP(Type KLGGKKGCLHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class OGDHHFEPFIF<View, Data> : IMNNLGNGPKK where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType GAAHIJOHEHF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type FOFEDJIHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2F2CE60", Offset = "0x2F2B460", VA = "0x182F2CE60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int CEEPGPEEPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2F2C060", Offset = "0x2F2A660", VA = "0x182F2C060", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2F2C120", Offset = "0x2F2A720", VA = "0x182F2C120")]
	public Data IKHFOIMGCMD(Entity MPAGCMNFGMI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2F2C190", Offset = "0x2F2A790", VA = "0x182F2C190")]
	public Data KHGMJKHJNBD(Entity MPAGCMNFGMI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View ODGAKJDNNCF(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2597DF0", Offset = "0x25963F0", VA = "0x182597DF0", Slot = "14")]
	public override T ODGAKJDNNCF<T>(Entity MPAGCMNFGMI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1798FD0", Offset = "0x17975D0", VA = "0x181798FD0")]
	protected OGDHHFEPFIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class IMNNLGNGPKK : ELBEJOMIKKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle MFCIFPPOHBM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xBE6D90", Offset = "0xBE5390", VA = "0x180BE6D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type FOFEDJIHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int CEEPGPEEPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type JKIBAFLIHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1AFEA90", Offset = "0x1AFD090", VA = "0x181AFEA90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int IFNCJMBEFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F00450", Offset = "0x6EFEA50", VA = "0x186F00450", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private EPFAAOCCGEJ[] EHJCLEIDIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x15BD9C0", Offset = "0x15BBFC0", VA = "0x1815BD9C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual EPFAAOCCGEJ[] GIEKDLKKKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F006B0", Offset = "0x6EFECB0", VA = "0x186F006B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F00590", Offset = "0x6EFEB90", VA = "0x186F00590")]
	public void GMAKAKECEDK(EntityManager PHHGGAMLDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T ODGAKJDNNCF<T>(Entity MPAGCMNFGMI) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F004C0", Offset = "0x6EFEAC0", VA = "0x186F004C0", Slot = "8")]
	public (uint, uint) GDKCFJKPHMK(Entity MPAGCMNFGMI)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F003B0", Offset = "0x6EFE9B0", VA = "0x186F003B0", Slot = "9")]
	public bool AMHHHBOFGAN(Entity MPAGCMNFGMI, (uint order, uint change) MPNDOHBKHJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	protected IMNNLGNGPKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JDOBAEGPJED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int EBMCNIDEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private int FJLPCOJGEJP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ENMONBGIHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9530D0", Offset = "0x9516D0", VA = "0x1809530D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1D43610", Offset = "0x1D41C10", VA = "0x181D43610")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A83C00", Offset = "0x2A82200", VA = "0x182A83C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HFENFGFAHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9530D0", Offset = "0x9516D0", VA = "0x1809530D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x953140", Offset = "0x951740", VA = "0x180953140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int JFHEJCIOGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F00770", Offset = "0x6EFED70", VA = "0x186F00770")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F00780", Offset = "0x6EFED80", VA = "0x186F00780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xA54600", Offset = "0xA52C00", VA = "0x180A54600")]
	private JDOBAEGPJED(int EBMCNIDEEKK, int FJLPCOJGEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2C196F0", Offset = "0x2C17CF0", VA = "0x182C196F0")]
	public static JDOBAEGPJED LMPDDMFCIGA(int EBMCNIDEEKK, int FJLPCOJGEJP)
	{
		return default(JDOBAEGPJED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F00790", Offset = "0x6EFED90", VA = "0x186F00790")]
	public static JDOBAEGPJED DHJBOKBAECA(int FIDLKHDDPII, int HOLOHKLLGJH)
	{
		return default(JDOBAEGPJED);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F007A0", Offset = "0x6EFEDA0", VA = "0x186F007A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CHNKGOHFCHF : DKBCPEINLOI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6637470", Offset = "0x6635A70", VA = "0x186637470")]
	public float KOCCOHMJDND(in float3 MOLEJFDINLH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6637470", Offset = "0x6635A70", VA = "0x186637470", Slot = "4")]
	private float FCHAOMOOANG(in float3 MOLEJFDINLH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HGINGKNIGFC : DKBCPEINLOI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6638280", Offset = "0x6636880", VA = "0x186638280")]
	public float KOCCOHMJDND(in float3 MOLEJFDINLH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6638280", Offset = "0x6636880", VA = "0x186638280", Slot = "4")]
	private float FCHAOMOOANG(in float3 MOLEJFDINLH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct PMDMCIEABGC : DKBCPEINLOI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xFEF330", Offset = "0xFED930", VA = "0x180FEF330")]
	public float KOCCOHMJDND(in float3 MOLEJFDINLH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xFEF330", Offset = "0xFED930", VA = "0x180FEF330", Slot = "4")]
	private float FCHAOMOOANG(in float3 MOLEJFDINLH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct FINMMJPIHNL : DKBCPEINLOI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xBF9BB0", Offset = "0xBF81B0", VA = "0x180BF9BB0")]
	public int KOCCOHMJDND(in int3 MOLEJFDINLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xBF9BB0", Offset = "0xBF81B0", VA = "0x180BF9BB0", Slot = "4")]
	private int ABLAFDLANMN(in int3 MOLEJFDINLH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NEEBPODBMJG : DKBCPEINLOI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6427940", Offset = "0x6425F40", VA = "0x186427940")]
	public int KOCCOHMJDND(in int3 MOLEJFDINLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6427940", Offset = "0x6425F40", VA = "0x186427940", Slot = "4")]
	private int ABLAFDLANMN(in int3 MOLEJFDINLH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CFELICFJIFB : DKBCPEINLOI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x98B450", Offset = "0x989A50", VA = "0x18098B450")]
	public int KOCCOHMJDND(in int3 MOLEJFDINLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x98B450", Offset = "0x989A50", VA = "0x18098B450", Slot = "4")]
	private int ABLAFDLANMN(in int3 MOLEJFDINLH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KDONMPEHPAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly byte[] GLAHAIKDMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MemoryStream IENEGNABBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CodedOutputStream KFHOEAIPDJJ;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F01400", Offset = "0x6EFFA00", VA = "0x186F01400", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
internal struct NDLEKJNBHIJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public ComponentDataFromEntity FIMMBMNEBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[ReadOnly]
	public NativeArray<Entity> OLBKEPEGOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeList<Entity> HBPDFGPCCHA;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F016C0", Offset = "0x6EFFCC0", VA = "0x186F016C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class DLMHBOABPCD
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F00070", Offset = "0x6EFE670", VA = "0x186F00070")]
	[GCIEFGJFKFP]
	public static JobHandle IEBLCGOBCII(this EntityCommandBufferSystem NKHEOBELIKH, NativeList<Entity> NCEOACJJMCN, [Optional] JobHandle AIKFNHNINEI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFF60", Offset = "0x6EFE560", VA = "0x186EFFF60")]
	[GCIEFGJFKFP]
	public static JobHandle IEBLCGOBCII(this EntityCommandBufferSystem NKHEOBELIKH, NativeArrayAsync<Entity> NCEOACJJMCN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CCACCELBNBK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3093FF0", Offset = "0x30925F0", VA = "0x183093FF0")]
	public static void LONLKJPFJHI<T>(this EntityCommandBufferSystem NKHEOBELIKH, EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3094060", Offset = "0x3092660", VA = "0x183094060")]
	[GCIEFGJFKFP]
	public static JobHandle MLCFOLDCIAO<T>(this EntityCommandBufferSystem NKHEOBELIKH, NativeListAsync<Entity> NCEOACJJMCN, [Optional] JobHandle AIKFNHNINEI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3094120", Offset = "0x3092720", VA = "0x183094120")]
	[GCIEFGJFKFP]
	public static JobHandle MLCFOLDCIAO<T>(this EntityCommandBufferSystem NKHEOBELIKH, NativeArrayAsync<Entity> NCEOACJJMCN, [Optional] JobHandle AIKFNHNINEI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CIPDOJHKGLE
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct ILJPDKOKOPL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public NativeArray<Entity> MALODJPNOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NativeArray<T> BDMCNIAKCGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct ANDMEJLMCIP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public NativeList<Entity> MALODJPNOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NativeArray<T> BDMCNIAKCGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct HEGBACEGIGK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NativeArrayAsync<Entity> MALODJPNOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NativeArrayAsync<T> BDMCNIAKCGH;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1CB2E90", Offset = "0x1CB1490", VA = "0x181CB2E90")]
		public NativeListAsync<Entity> EOLIKBBBPPP<TPredicate>() where TPredicate : struct, LKDFNLJKLKK<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x191CCF0", Offset = "0x191B2F0", VA = "0x18191CCF0")]
	public static HEGBACEGIGK<T> EGNJIJMMNDF<T>(this NativeArrayAsync<Entity> OLBKEPEGOFH, NativeArrayAsync<T> CCGBMDONPHN, Allocator HINEEPDGLPG = Allocator.TempJob) where T : struct
	{
		return default(HEGBACEGIGK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MICFNIENDPM : EAGNFDFLHGH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Type BEHDKCIENKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Type BLJNIOGAGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F01530", Offset = "0x6EFFB30", VA = "0x186F01530")]
	public MICFNIENDPM(Type MADGFLGDIPM, Type FIMMBMNEBLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class NFKGELAIBOE
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class AMMBCNBLAGF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xE195C0", Offset = "0xE17BC0", VA = "0x180E195C0")]
	public static NativeList<Entity> CDCKMLJFNPK<T>(this NativeArray<Entity> OLBKEPEGOFH, EntityManager PHHGGAMLDGB, Allocator HINEEPDGLPG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MKNPEGODPID : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly MemoryStream IENEGNABBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CodedInputStream MFIPHHGPAGF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F01580", Offset = "0x6EFFB80", VA = "0x186F01580", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class JBEFIKCKKPA
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct NKKCDIJJNNI : DKBCPEINLOI<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> IGGBGMFLLKM;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6F018D0", Offset = "0x6EFFED0", VA = "0x186F018D0")]
		[BurstCompatible]
		public Entity KOCCOHMJDND(in Entity MOLEJFDINLH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6F018D0", Offset = "0x6EFFED0", VA = "0x186F018D0", Slot = "4")]
		private Entity BNKOPDNLLDN(in Entity MOLEJFDINLH)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct IKNDGBPADAD<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LBPJHIJKEFP : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public IKNDGBPADAD<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int <i>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Protobuf <element>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9C97A0", Offset = "0x9C7DA0", VA = "0x1809C97A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1D4BC60", Offset = "0x1D4A260", VA = "0x181D4BC60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x19A28C0", Offset = "0x19A0EC0", VA = "0x1819A28C0")]
		[DebuggerHidden]
		public LBPJHIJKEFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BA60", Offset = "0x1D4A060", VA = "0x181D4BA60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BC20", Offset = "0x1D4A220", VA = "0x181D4BC20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Action<Protobuf> CBFIIHBBBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MemoryStream IENEGNABBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CodedInputStream MFIPHHGPAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Protobuf CKBIKICODGK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int ALHMBJNHGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x90DC40", Offset = "0x90C240", VA = "0x18090DC40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3051640", Offset = "0x304FC40", VA = "0x183051640")]
	private IKNDGBPADAD(byte[] GLAHAIKDMIH, Action<Protobuf> CBFIIHBBBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3E70", Offset = "0x1CB2470", VA = "0x181CB3E70")]
	public static IKNDGBPADAD<Protobuf> HKLENFAPHAP<Data>(ReadOnlySpan<byte> NFNCBDOMNAL, ReadOnlySpan<Data> NCBGBGGOJOG, Action<Protobuf> CBFIIHBBBHC)
	{
		return default(IKNDGBPADAD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x30514B0", Offset = "0x304FAB0", VA = "0x1830514B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x30514F0", Offset = "0x304FAF0", VA = "0x1830514F0", Slot = "4")]
	[IteratorStateMachine(typeof(IKNDGBPADAD<>.LBPJHIJKEFP))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x30515F0", Offset = "0x304FBF0", VA = "0x1830515F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class OGKEHGMFKCC : GHDAJGIMJFL
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F01980", Offset = "0x6EFFF80", VA = "0x186F01980", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase LKCJPAMAHDJ();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F01930", Offset = "0x6EFFF30", VA = "0x186F01930")]
	protected ComponentSystemBase NDMLDCGCCFP(params ComponentSystemBase[] NPKGKGEPBBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x22FEF40", Offset = "0x22FD540", VA = "0x1822FEF40")]
	protected ComponentSystemBase NDMLDCGCCFP<T>(params ComponentSystemBase[] NPKGKGEPBBI) where T : GHDAJGIMJFL, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x22FEF00", Offset = "0x22FD500", VA = "0x1822FEF00")]
	protected ComponentSystemBase OKMBCDDKEPP<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x22FEF00", Offset = "0x22FD500", VA = "0x1822FEF00")]
	protected ComponentSystemBase CMBACCDHPGL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F018E0", Offset = "0x6EFFEE0", VA = "0x186F018E0")]
	protected ComponentSystemBase BFNPJEFDAIK(params SystemHandleUntyped[] NPKGKGEPBBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x22FEE20", Offset = "0x22FD420", VA = "0x1822FEE20")]
	protected ComponentSystemBase BFNPJEFDAIK<T>(params SystemHandleUntyped[] NPKGKGEPBBI) where T : GHDAJGIMJFL, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x22FEEB0", Offset = "0x22FD4B0", VA = "0x1822FEEB0")]
	protected SystemHandleUntyped CLCHBHPLKOI<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F00330", Offset = "0x6EFE930", VA = "0x186F00330")]
	protected OGKEHGMFKCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class BJLJMPBHILO
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x359D3B0", Offset = "0x359B9B0", VA = "0x18359D3B0")]
	public static NativeList<T> EOFOPHGLLMJ<T>(NativeList<T> CCGBMDONPHN, Allocator HINEEPDGLPG) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class FPACLCJEPCL
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct BEDOGDJIJLK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : DKBCPEINLOI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> BDMCNIAKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeList<TFrom> GCBHFBLABKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeParallelHashSet<TTo> GOGEJEOAIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap ILLCNPCAHGD;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct AJFMDPDMHJE<T, TPredicate> : IJob where T : struct where TPredicate : struct, LKDFNLJKLKK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<T> BDMCNIAKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> MALODJPNOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeList<Entity> JALJHOBHJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public TPredicate ILLCNPCAHGD;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x207B1F0", Offset = "0x20797F0", VA = "0x18207B1F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct OCIEAEKBEPD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DKBCPEINLOI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<TFrom> CFMKPFMPPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[WriteOnly]
	public NativeList<TTo> PGPICFJKPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public TMap ILLCNPCAHGD;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class KHCAGCKMDIL
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct KBBGHJHGKID<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly NativeArray<T>.ReadOnly IACDCADJJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int FJBDCKBJAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int NLAPAOKAIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private T CNBAOOFLKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private T LCPMGAFAGOE;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public JDOBAEGPJED CMGDKHMKDPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2415BA0", Offset = "0x24141A0", VA = "0x182415BA0")]
			get
			{
				return default(JDOBAEGPJED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T ADKDJMCEOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2415B80", Offset = "0x2414180", VA = "0x182415B80")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (T, JDOBAEGPJED) PLBILPKBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2540600", Offset = "0x253EC00", VA = "0x182540600")]
			get
			{
				return default((T, JDOBAEGPJED));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2540AC0", Offset = "0x253F0C0", VA = "0x182540AC0")]
		public KBBGHJHGKID(NativeArray<T> IACDCADJJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x232D460", Offset = "0x232BA60", VA = "0x18232D460")]
		public KBBGHJHGKID<T> FGHGHABHEPH()
		{
			return default(KBBGHJHGKID<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2540780", Offset = "0x253ED80", VA = "0x182540780")]
		public bool LPFPIBLKIAC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1CB6AE0", Offset = "0x1CB50E0", VA = "0x181CB6AE0")]
		public MPMCABKELCG<T, TComparer> AHHONNPOBPB<TComparer>([Optional] TComparer MPDDGKMOGFF) where TComparer : struct, IEqualityComparer<T>
		{
			return default(MPMCABKELCG<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct MPMCABKELCG<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly NativeArray<T>.ReadOnly IACDCADJJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int FJBDCKBJAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int NLAPAOKAIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T CNBAOOFLKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private T LCPMGAFAGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TComparer MPDDGKMOGFF;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public JDOBAEGPJED CMGDKHMKDPN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2415BA0", Offset = "0x24141A0", VA = "0x182415BA0")]
			get
			{
				return default(JDOBAEGPJED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public T ADKDJMCEOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2415B80", Offset = "0x2414180", VA = "0x182415B80")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public (T value, JDOBAEGPJED range) PLBILPKBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2415BB0", Offset = "0x24141B0", VA = "0x182415BB0")]
			get
			{
				return default((T, JDOBAEGPJED));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2415EE0", Offset = "0x24144E0", VA = "0x182415EE0")]
		public MPMCABKELCG(NativeArray<T>.ReadOnly IACDCADJJAN, TComparer MPDDGKMOGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x232D810", Offset = "0x232BE10", VA = "0x18232D810")]
		public MPMCABKELCG<T, TComparer> FGHGHABHEPH()
		{
			return default(MPMCABKELCG<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2415C80", Offset = "0x2414280", VA = "0x182415C80")]
		public bool LPFPIBLKIAC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xF39880", Offset = "0xF37E80", VA = "0x180F39880")]
	public static KBBGHJHGKID<T> NDMLDCGCCFP<T>(this NativeArray<T> IACDCADJJAN) where T : struct
	{
		return default(KBBGHJHGKID<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DKBCPEINLOI<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo KOCCOHMJDND(in TFrom MOLEJFDINLH);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BJMNMCHHFPL
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NKIPLMLGKOB
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LNIPJONMIIE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public LNIPJONMIIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class INIDACJHKEC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		public INIDACJHKEC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<Func<JobHandle, JobHandle>> NKNFEAFFJIM;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6F01850", Offset = "0x6EFFE50", VA = "0x186F01850")]
	public NKIPLMLGKOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class IIDCFGNPJDC
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class IHADAAMNPBN : EntityCommandBufferSystem, LEHPGAEOJJK
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
	protected IHADAAMNPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class POCLIIKIFDF
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2312A10", Offset = "0x2311010", VA = "0x182312A10")]
	[GCIEFGJFKFP]
	public static JobHandle CCDJCIBJPEN<T>(this EntityCommandBufferSystem NKHEOBELIKH, NativeArray<Entity> NCEOACJJMCN, NativeArray<T> JAIGDBINGHO, JobHandle AIKFNHNINEI) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct AELLAKOMPHE<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<T> BDMCNIAKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<T> GCBHFBLABKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<T> GOGEJEOAIDE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x29D4190", Offset = "0x29D2790", VA = "0x1829D4190", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct CGPJPCOHIMC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> NCEOACJJMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EntityCommandBuffer EJOBGFBIEJO;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFDD0", Offset = "0x6EFE3D0", VA = "0x186EFFDD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MIHEDGBPOJD
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0E20", Offset = "0x1A9F420", VA = "0x181AA0E20")]
	public static NativeArray<T> GBBIFGMKLNN<T>(this NativeList<Entity> CCGBMDONPHN, EntityManager PHHGGAMLDGB, Allocator HINEEPDGLPG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0C50", Offset = "0x1A9F250", VA = "0x181AA0C50")]
	public static NativeArray<T> GBBIFGMKLNN<T>(this NativeArray<Entity> CCGBMDONPHN, EntityManager PHHGGAMLDGB, Allocator HINEEPDGLPG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FHCLFPFNBMB
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class HIFGFNDMNMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal struct CBCPOBHFMHI<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> NCEOACJJMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public T MOLEJFDINLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public EntityCommandBuffer EJOBGFBIEJO;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DB70", Offset = "0x2B6C170", VA = "0x182B6DB70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class NJABPEHHHHJ
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x20AF5F0", Offset = "0x20ADBF0", VA = "0x1820AF5F0")]
	[GCIEFGJFKFP]
	public static JobHandle PJEBEMCLLLG<T>(this EntityCommandBufferSystem NKHEOBELIKH, EntityCommandBuffer EJOBGFBIEJO, EntityQuery OGAAEGIJKLI, T MOLEJFDINLH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class KBEMIHNGAKB<Data> : ICJILNNOMND where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public virtual Data EOJNEJPDGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C420", Offset = "0x1A4AA20", VA = "0x181A4C420", Slot = "8")]
	protected virtual bool PGJCKELNAHG(ReadOnlySpan<Data> NCBGBGGOJOG, LFPMKGDJPHH IMICHANCJBJ, out ReadOnlySpan<byte> NFNCBDOMNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x928C00", Offset = "0x927200", VA = "0x180928C00", Slot = "9")]
	protected virtual bool ICFKHIBHCNH(int MPNDOHBKHJO, Span<Data> NCBGBGGOJOG, in ReadOnlySpan<byte> NFNCBDOMNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2542F10", Offset = "0x2541510", VA = "0x182542F10", Slot = "5")]
	internal sealed override bool PGJCKELNAHG(ref Unity.Entities.Chunk FCONCDBMPAA, int NJEILGFLIHH, LFPMKGDJPHH IMICHANCJBJ, out ReadOnlySpan<byte> NFNCBDOMNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2541370", Offset = "0x253F970", VA = "0x182541370", Slot = "6")]
	internal sealed override bool ICFKHIBHCNH(int MPNDOHBKHJO, ref Unity.Entities.Chunk FCONCDBMPAA, int NJEILGFLIHH, in ReadOnlySpan<byte> NFNCBDOMNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6B30", Offset = "0x1CB5130", VA = "0x181CB6B30")]
	protected MKMJJFCPHML<Protobuf> GJLDBLFEANC<Protobuf>(ReadOnlySpan<Data> NCBGBGGOJOG) where Protobuf : IMessage, new()
	{
		return default(MKMJJFCPHML<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6B80", Offset = "0x1CB5180", VA = "0x181CB6B80")]
	protected IKNDGBPADAD<Protobuf> PKDNNCKLDPK<Protobuf>(ReadOnlySpan<byte> NFNCBDOMNAL, ReadOnlySpan<Data> NCBGBGGOJOG, Action<Protobuf> CBFIIHBBBHC) where Protobuf : IMessage, new()
	{
		return default(IKNDGBPADAD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1798FD0", Offset = "0x17975D0", VA = "0x181798FD0")]
	protected KBEMIHNGAKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class ICJILNNOMND
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected abstract int CHHMHDKPLJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6F00390", Offset = "0x6EFE990", VA = "0x186F00390", Slot = "5")]
	internal virtual bool PGJCKELNAHG(ref Unity.Entities.Chunk FCONCDBMPAA, int NJEILGFLIHH, LFPMKGDJPHH IMICHANCJBJ, out ReadOnlySpan<byte> NFNCBDOMNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x928C00", Offset = "0x927200", VA = "0x180928C00", Slot = "6")]
	internal virtual bool ICFKHIBHCNH(int MPNDOHBKHJO, ref Unity.Entities.Chunk FCONCDBMPAA, int NJEILGFLIHH, in ReadOnlySpan<byte> NFNCBDOMNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	protected ICJILNNOMND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class LKPKPFDHNCB
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct NAIMELFIHMM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct KMPEGMHDOAM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal NAIMELFIHMM<TFrom> HDBBNLFBJKG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> POIAHNIMHKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct IJFPDIJMAHN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public struct LFGLAKNGKPK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal IJFPDIJMAHN<TFrom> HDBBNLFBJKG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> POIAHNIMHKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct MFJLJNGFFOB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public struct JFGNNEDPCHE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal MFJLJNGFFOB<TFrom> HDBBNLFBJKG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> POIAHNIMHKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct AHNPNJAEFFP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public struct NJFEIJGNEEM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal AHNPNJAEFFP<TFrom> HDBBNLFBJKG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> POIAHNIMHKJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct NGPPNDFDCBG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	public ComponentDataFromEntity BCBOOMMHGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	public NativeArray<Entity> BDMCNIAKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[WriteOnly]
	public NativeArray<byte> PGPICFJKPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int AJHFAKMNONL;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6F01750", Offset = "0x6EFFD50", VA = "0x186F01750", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[BurstCompile]
internal struct IGHCFAPIIAB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FIMMBMNEBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[ReadOnly]
	public NativeArray<Entity> OLBKEPEGOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<bool> LHHFMEKONDJ;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal struct IDLKNEFDJLB<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[ReadOnly]
	public NativeArray<Entity> NCEOACJJMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[ReadOnly]
	public NativeArray<T> AEEDPBOFDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public EntityCommandBuffer EJOBGFBIEJO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class AOGFBMPFCIL
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xE1B240", Offset = "0xE19840", VA = "0x180E1B240")]
	public static NativeListAsync<Entity> MKOBGJFABBL<T, TPredicate>(this NativeArrayAsync<T> CCGBMDONPHN, NativeArrayAsync<Entity> OLBKEPEGOFH, Allocator HINEEPDGLPG = Allocator.TempJob) where T : struct where TPredicate : struct, LKDFNLJKLKK<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xE1B090", Offset = "0xE19690", VA = "0x180E1B090")]
	private static NativeListAsync<Entity> CICDABPPOGC<T, TPredicate>(NativeArrayAsync<T> LBGHLKBEGGJ, NativeArrayAsync<Entity> OLBKEPEGOFH, int BFDDLCIBNMB, Allocator HINEEPDGLPG) where T : struct where TPredicate : struct, LKDFNLJKLKK<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class AGKGGBEGBKN
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xE18AF0", Offset = "0xE170F0", VA = "0x180E18AF0")]
	[GCIEFGJFKFP]
	public static JobHandle JKPHOLGHKMP<T>(this EntityCommandBufferSystem NKHEOBELIKH, NativeArray<Entity> NCEOACJJMCN, T MOLEJFDINLH, [Optional] JobHandle AIKFNHNINEI) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xE18BC0", Offset = "0xE171C0", VA = "0x180E18BC0")]
	[GCIEFGJFKFP]
	public static JobHandle JKPHOLGHKMP<T>(this EntityCommandBufferSystem NKHEOBELIKH, EntityCommandBuffer EJOBGFBIEJO, NativeArray<Entity> NCEOACJJMCN, T MOLEJFDINLH, [Optional] JobHandle AIKFNHNINEI) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class LFPMKGDJPHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> PHBMIEBOBOG;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x20466F0", Offset = "0x2044CF0", VA = "0x1820466F0")]
	public LFPMKGDJPHH(NativeArray<EntityRemapUtility.EntityRemapInfo> PHBMIEBOBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F01520", Offset = "0x6EFFB20", VA = "0x186F01520")]
	public Entity OEEIJCMLLJE(Entity PAKFOBAPADB)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class JJCPPAFODLI
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2171770", Offset = "0x216FD70", VA = "0x182171770")]
	public static NativeList<T> EOFOPHGLLMJ<T>(this NativeList<T> CCGBMDONPHN, Allocator HINEEPDGLPG = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x21715A0", Offset = "0x216FBA0", VA = "0x1821715A0")]
	public static NativeList<T> EOFOPHGLLMJ<T>(this NativeArray<T> CCGBMDONPHN, Allocator HINEEPDGLPG = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class ODAKBPFNBLH
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct PAGCHOHNJMO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> BDMCNIAKCGH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct GHKFNBKJGLO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<T> BDMCNIAKCGH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct GFDAMGGLIML<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<T> BDMCNIAKCGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct JOAFJPBDPCG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeListAsync<T> BDMCNIAKCGH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
internal struct IEBHMDCEACL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DKBCPEINLOI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeArray<TFrom> BDMCNIAKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[WriteOnly]
	public NativeArray<TTo> PGPICFJKPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TMap ILLCNPCAHGD;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface LKDFNLJKLKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOLIKBBBPPP(T MOLEJFDINLH);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
internal struct ACHKAKEGKEL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	public NativeArray<Entity> NCEOACJJMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public EntityCommandBuffer EJOBGFBIEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public ComponentTypes MDCDGJAHCMO;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFD40", Offset = "0x6EFE340", VA = "0x186EFFD40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[BurstCompile]
internal struct KFOEJEHEBKD<T, TPredicate> : IJob where T : struct where TPredicate : struct, LKDFNLJKLKK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	public NativeArray<T> BDMCNIAKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<T> GCBHFBLABKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public TPredicate ILLCNPCAHGD;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class GHDAJGIMJFL : PIPKMIGGODP
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F00300", Offset = "0x6EFE900", VA = "0x186F00300", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F00330", Offset = "0x6EFE930", VA = "0x186F00330")]
	public GHDAJGIMJFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[BurstCompile]
internal struct HGAEJOILPPF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FIMMBMNEBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	public NativeArray<Entity> OLBKEPEGOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<bool> LHHFMEKONDJ;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x218A800", Offset = "0x2188E00", VA = "0x18218A800", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct AIAEHLNAMIE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<Entity> NCEOACJJMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	public NativeArray<T> JAIGDBINGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public EntityCommandBuffer EJOBGFBIEJO;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x29E4230", Offset = "0x29E2830", VA = "0x1829E4230", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MPLBJGPEIKJ
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6F015C0", Offset = "0x6EFFBC0", VA = "0x186F015C0")]
	public static ulong IGDLGGIIJCI(Type KLGGKKGCLHM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F01650", Offset = "0x6EFFC50", VA = "0x186F01650")]
	public static ulong IGDLGGIIJCI(string EHINBKGLPIK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class BEPOGFEHFHC : EAGNFDFLHGH
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Type BLJNIOGAGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x26FC680", Offset = "0x26FAC80", VA = "0x1826FC680")]
	public BEPOGFEHFHC(Type FIMMBMNEBLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[BurstCompile]
internal struct PMPDDIANDEE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public ComponentDataFromEntity FIMMBMNEBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	public NativeArray<Entity> OLBKEPEGOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<Entity> HBPDFGPCCHA;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6F019D0", Offset = "0x6EFFFD0", VA = "0x186F019D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public abstract class DIIPAOKEIKC : SystemBase, LEHPGAEOJJK
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFE30", Offset = "0x6EFE430", VA = "0x186EFFE30")]
	public ComponentDataFromEntity FFOCNPKELOH(int MPGHGDABPMN, bool IIIFGLBBIHC = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFF00", Offset = "0x6EFE500", VA = "0x186EFFF00")]
	public EntityExistenceLookupByEntity IIDOKPNPDAB()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFF20", Offset = "0x6EFE520", VA = "0x186EFFF20", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8D40F0", Offset = "0x8D26F0", VA = "0x1808D40F0")]
	protected DIIPAOKEIKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class AEKGPLOBAHI : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFDA0", Offset = "0x6EFE3A0", VA = "0x186EFFDA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8D40F0", Offset = "0x8D26F0", VA = "0x1808D40F0")]
	protected AEKGPLOBAHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class EHLPNBEPLAH
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct MKMJJFCPHML<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly byte[] GLAHAIKDMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Protobuf CKBIKICODGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly MemoryStream IENEGNABBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly CodedOutputStream KFHOEAIPDJJ;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B62E00", Offset = "0x2B61400", VA = "0x182B62E00")]
	private MKMJJFCPHML(byte[] GLAHAIKDMIH, in Protobuf CKBIKICODGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x30BA7A0", Offset = "0x30B8DA0", VA = "0x1830BA7A0")]
	public static MKMJJFCPHML<Protobuf> HKLENFAPHAP<T>(ReadOnlySpan<T> NCBGBGGOJOG)
	{
		return default(MKMJJFCPHML<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B62CB0", Offset = "0x2B612B0", VA = "0x182B62CB0")]
	public void DCCMGDANBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B62C20", Offset = "0x2B61220", VA = "0x182B62C20")]
	public ByteString AEMGEGAIHLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2B62CE0", Offset = "0x2B612E0", VA = "0x182B62CE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface LEHPGAEOJJK
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public abstract class PIPKMIGGODP : ComponentSystemGroup, LEHPGAEOJJK
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F00330", Offset = "0x6EFE930", VA = "0x186F00330")]
	protected PIPKMIGGODP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class LIAEMJCPGKA
{
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[BurstCompile]
internal struct JLAJEGNHMEM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MFCNAOKPFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public NativeArray<Entity> BDMCNIAKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[WriteOnly]
	public NativeList<T> GCBHFBLABKK;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[Flags]
public enum JCCPMAHLPOA
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class DKCELLAMNKK : EAGNFDFLHGH
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8D40F0", Offset = "0x8D26F0", VA = "0x1808D40F0")]
	public DKCELLAMNKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class BLOLELIJAFI
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public readonly struct MILMOGHKGCC<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly NativeArray<TSrc> IACDCADJJAN;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAE2E80", Offset = "0xAE1480", VA = "0x180AE2E80")]
		public MILMOGHKGCC(NativeArray<TSrc> IACDCADJJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xB91190", Offset = "0xB8F790", VA = "0x180B91190")]
		public LBBJGAAIIKK<TSrc, TValue> KLDHGKAHLMN<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(LBBJGAAIIKK<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct LBBJGAAIIKK<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly NativeArray<TSrc> IACDCADJJAN;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAE2E80", Offset = "0xAE1480", VA = "0x180AE2E80")]
		public LBBJGAAIIKK(NativeArray<TSrc> IACDCADJJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xB91190", Offset = "0xB8F790", VA = "0x180B91190")]
		public HKOLIIPEPFN<TSrc, TValue, TSelector> MBIMCOBDDIA<TSelector>() where TSelector : struct, DKBCPEINLOI<TSrc, TValue>
		{
			return default(HKOLIIPEPFN<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct HKOLIIPEPFN<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DKBCPEINLOI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly NativeArray<TSrc> IACDCADJJAN;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAE2E80", Offset = "0xAE1480", VA = "0x180AE2E80")]
		public HKOLIIPEPFN(NativeArray<TSrc> IACDCADJJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2EF8770", Offset = "0x2EF6D70", VA = "0x182EF8770")]
		public MEDDBNKFNHG<TSrc, TValue, TSelector> NDMLDCGCCFP()
		{
			return default(MEDDBNKFNHG<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct EJAKMHCDNLG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, DKBCPEINLOI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly NativeArray<TSrc> IACDCADJJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TSelector OHJHOGOEIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int OLGOBCPPPBB;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TValue PLBILPKBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x18C43D0", Offset = "0x18C29D0", VA = "0x1818C43D0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int FIFIFGFPIHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x935920", Offset = "0x933F20", VA = "0x180935920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int ALHMBJNHGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x18BCEF0", Offset = "0x18BB4F0", VA = "0x1818BCEF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x18C4570", Offset = "0x18C2B70", VA = "0x1818C4570")]
		public EJAKMHCDNLG(NativeArray<TSrc> IACDCADJJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x18C4440", Offset = "0x18C2A40", VA = "0x1818C4440")]
		public bool LPFPIBLKIAC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x18C4450", Offset = "0x18C2A50", VA = "0x1818C4450")]
		private TSrc OLHJKBABJNI(int GPAKLECDLDD)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public struct MEDDBNKFNHG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DKBCPEINLOI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private EJAKMHCDNLG<TSrc, TValue, TSelector> GCEOFBACMDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TValue CNBAOOFLKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int FJBDCKBJAGA;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public JDOBAEGPJED CMGDKHMKDPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x33B4D80", Offset = "0x33B3380", VA = "0x1833B4D80")]
			get
			{
				return default(JDOBAEGPJED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TValue ADKDJMCEOIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x928590", Offset = "0x926B90", VA = "0x180928590")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (TValue value, JDOBAEGPJED range) PLBILPKBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x33B4DC0", Offset = "0x33B33C0", VA = "0x1833B4DC0")]
			get
			{
				return default((TValue, JDOBAEGPJED));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x33B4FC0", Offset = "0x33B35C0", VA = "0x1833B4FC0")]
		public MEDDBNKFNHG(NativeArray<TSrc> IACDCADJJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D433E0", Offset = "0x1D419E0", VA = "0x181D433E0")]
		public MEDDBNKFNHG<TSrc, TValue, TSelector> FGHGHABHEPH()
		{
			return default(MEDDBNKFNHG<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x33B4E90", Offset = "0x33B3490", VA = "0x1833B4E90")]
		public bool LPFPIBLKIAC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x359D6C0", Offset = "0x359BCC0", VA = "0x18359D6C0")]
	public static MILMOGHKGCC<T> HOFPOPOKMDD<T>(this NativeList<T> CKIKFMIOAHP) where T : struct
	{
		return default(MILMOGHKGCC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xB91190", Offset = "0xB8F790", VA = "0x180B91190")]
	public static MILMOGHKGCC<T> HOFPOPOKMDD<T>(this NativeArray<T> IACDCADJJAN) where T : struct
	{
		return default(MILMOGHKGCC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class GFBOLBJDPJO
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct AMHMKHPLFNH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct JALKCEFKOEM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public AMHMKHPLFNH<TFrom> POIAHNIMHKJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NativeArray<TFrom> BDMCNIAKCGH;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct AAOKMAEMKAM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public struct CCOCOGBNPDM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AAOKMAEMKAM<TFrom> POIAHNIMHKJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeArrayAsync<TFrom> BDMCNIAKCGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct KGLNOJGGILP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public struct AFOOLLBKAPD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public KGLNOJGGILP<TFrom> POIAHNIMHKJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Allocator HINEEPDGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NativeListAsync<TFrom> BDMCNIAKCGH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[BurstCompile]
internal struct DLIPOMBICAN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	public NativeArray<Entity> NCEOACJJMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public EntityCommandBuffer EJOBGFBIEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public ComponentType OLPLAHPNFFJ;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFF30", Offset = "0x6EFE530", VA = "0x186EFFF30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class GLGKBECCHBH
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B41750", Offset = "0x2B3FD50", VA = "0x182B41750")]
	public static bool IJDLJLEGNBP<T>(this NativeArray<Entity> OLBKEPEGOFH, EntityManager PHHGGAMLDGB, Allocator HINEEPDGLPG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class AEHCONPPPOF
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class OMNFPCEIBBM
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class JKFAAJMOKDA
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public delegate void CAPOLNGOPKM<From, To>(From POIAHNIMHKJ, ref To GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ);

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private class HCFDENEPOHF<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static CAPOLNGOPKM<From, To> FJADGKAIEAM;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public HCFDENEPOHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F00830", Offset = "0x6EFEE30", VA = "0x186F00830")]
	static JKFAAJMOKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2172520", Offset = "0x2170B20", VA = "0x182172520")]
	public static void BOLGFHMCOCF<T>(CAPOLNGOPKM<T, T> AOFKOMBAJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2172050", Offset = "0x2170650", VA = "0x182172050")]
	public static void BOLGFHMCOCF<From, To>(CAPOLNGOPKM<From, To> AOFKOMBAJNC, CAPOLNGOPKM<To, From> JDGDJKNNCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x21720E0", Offset = "0x21706E0", VA = "0x1821720E0")]
	public static void BOLGFHMCOCF<From, To>(CAPOLNGOPKM<From, To> FJADGKAIEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2174940", Offset = "0x2172F40", VA = "0x182174940")]
	public static CAPOLNGOPKM<From, To> FCDEPPDPEOC<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x217B060", Offset = "0x2179660", VA = "0x18217B060")]
	public static void HGBLABAFCKF<From, To>(From POIAHNIMHKJ, ref To GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class JNBDHGKHKPD
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1B32670", Offset = "0x1B30C70", VA = "0x181B32670")]
	[GCIEFGJFKFP]
	public static JobHandle CCCHDOKAOFJ<T>(this EntityCommandBufferSystem NKHEOBELIKH, NativeArrayAsync<Entity> NCEOACJJMCN, NativeArrayAsync<T> JAIGDBINGHO, [Optional] JobHandle AIKFNHNINEI) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1B328E0", Offset = "0x1B30EE0", VA = "0x181B328E0")]
	[GCIEFGJFKFP]
	public static JobHandle CCCHDOKAOFJ<T>(this EntityCommandBufferSystem NKHEOBELIKH, NativeArrayAsync<Entity> NCEOACJJMCN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1B327C0", Offset = "0x1B30DC0", VA = "0x181B327C0")]
	[GCIEFGJFKFP]
	public static JobHandle CCCHDOKAOFJ<T>(this EntityCommandBufferSystem NKHEOBELIKH, NativeArray<Entity> NCEOACJJMCN, [Optional] JobHandle AIKFNHNINEI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F00B30", Offset = "0x6EFF130", VA = "0x186F00B30")]
	[GCIEFGJFKFP]
	public static JobHandle CCCHDOKAOFJ(this EntityCommandBufferSystem NKHEOBELIKH, NativeArray<Entity> NCEOACJJMCN, ComponentTypes MDCDGJAHCMO, [Optional] JobHandle AIKFNHNINEI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F00CA0", Offset = "0x6EFF2A0", VA = "0x186F00CA0")]
	[GCIEFGJFKFP]
	public static JobHandle CCCHDOKAOFJ(this EntityCommandBufferSystem NKHEOBELIKH, EntityCommandBuffer EJOBGFBIEJO, NativeArray<Entity> NCEOACJJMCN, ComponentTypes MDCDGJAHCMO, [Optional] JobHandle AIKFNHNINEI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class JPCCMHMOHBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F010F0", Offset = "0x6EFF6F0", VA = "0x186F010F0")]
	private unsafe static Span<byte> JEBEMNLGHIM(Unity.Entities.Chunk* FCONCDBMPAA, int NJEILGFLIHH)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1B37390", Offset = "0x1B35990", VA = "0x181B37390")]
	public unsafe static Span<T> DPEIEEGDCDF<T>(Unity.Entities.Chunk* FCONCDBMPAA, int NJEILGFLIHH)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1B37520", Offset = "0x1B35B20", VA = "0x181B37520")]
	public static Span<T> DPEIEEGDCDF<T>(this ref Unity.Entities.Chunk FCONCDBMPAA, int NJEILGFLIHH)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F01080", Offset = "0x6EFF680", VA = "0x186F01080")]
	public unsafe static Span<Entity> HLIPHHANJOG(Unity.Entities.Chunk* FCONCDBMPAA)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F00E00", Offset = "0x6EFF400", VA = "0x186F00E00")]
	public unsafe static void FBJOPIHCMHF(Unity.Entities.Chunk* FCONCDBMPAA, int NJEILGFLIHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[AttributeUsage(AttributeTargets.Class)]
public class FDPKGHKBDDG : EAGNFDFLHGH
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8D40F0", Offset = "0x8D26F0", VA = "0x1808D40F0")]
	public FDPKGHKBDDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface NNNHDPACMOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CCNIAMGGANG(Entity MPAGCMNFGMI, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AFMHLMMKAND(Entity MPAGCMNFGMI, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IEFDKMIOCGO(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KACAHBKCECI(Entity MPAGCMNFGMI);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class KLIIOIBMNEI<TComponentData, TValue> : DMBMMLONJCJ<TValue>, IDisposable where TComponentData : struct, FNCDDBGLKGE
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class CKCAGEKJGEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private List<(object token, TValue value)> CKIKFMIOAHP;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int AEJJJIDCFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x17B56D0", Offset = "0x17B3CD0", VA = "0x1817B56D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x29CA9A0", Offset = "0x29C8FA0", VA = "0x1829CA9A0")]
		public bool HAIOIBOKNFJ(out TValue MOLEJFDINLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x29CAA60", Offset = "0x29C9060", VA = "0x1829CAA60")]
		public void PDDBDHJNBOH(object DCEGGIJLHGI, TValue MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x29CA920", Offset = "0x29C8F20", VA = "0x1829CA920")]
		public bool EIILGGCBFDG(object DCEGGIJLHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x29CA870", Offset = "0x29C8E70", VA = "0x1829CA870")]
		public int EFGPFPJHKMF(object DCEGGIJLHGI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x29CAB10", Offset = "0x29C9110", VA = "0x1829CAB10")]
		public CKCAGEKJGEA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly Stack<CKCAGEKJGEA> CFGNNJIMCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private KMKKAEEIGLF<GENIMFADPLB, CKCAGEKJGEA> DLCMJHDEMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private EntityManager PHHGGAMLDGB;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2663800", Offset = "0x2661E00", VA = "0x182663800")]
	public KLIIOIBMNEI(EntityManager PHHGGAMLDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2663380", Offset = "0x2661980", VA = "0x182663380", Slot = "4")]
	public void CCNIAMGGANG(Entity MPAGCMNFGMI, object DCEGGIJLHGI, TValue MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2663120", Offset = "0x2661720", VA = "0x182663120", Slot = "5")]
	public bool AFMHLMMKAND(Entity MPAGCMNFGMI, object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2663600", Offset = "0x2661C00", VA = "0x182663600", Slot = "6")]
	public bool HAIOIBOKNFJ(Entity MPAGCMNFGMI, out TValue MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2663510", Offset = "0x2661B10", VA = "0x182663510", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x26636D0", Offset = "0x2661CD0", VA = "0x1826636D0")]
	private void HIINHOPGKII(CKCAGEKJGEA LGFHMILAAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2663530", Offset = "0x2661B30", VA = "0x182663530")]
	private bool EHOPCHDGAND(Entity MPAGCMNFGMI, out GENIMFADPLB FCDGNCOICKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2663750", Offset = "0x2661D50", VA = "0x182663750")]
	private void LHJNLAEBPLJ(Entity MPAGCMNFGMI, GENIMFADPLB FCDGNCOICKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x26637E0", Offset = "0x2661DE0", VA = "0x1826637E0")]
	private bool MAKIOKHAOMG(GENIMFADPLB FCDGNCOICKN, out CKCAGEKJGEA LGFHMILAAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x26632B0", Offset = "0x26618B0", VA = "0x1826632B0")]
	private CKCAGEKJGEA BLGJFKNJOEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface DMBMMLONJCJ<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCNIAMGGANG(Entity MPAGCMNFGMI, object DCEGGIJLHGI, TValue MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AFMHLMMKAND(Entity MPAGCMNFGMI, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HAIOIBOKNFJ(Entity MPAGCMNFGMI, out TValue MOLEJFDINLH);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface FNCDDBGLKGE : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	GENIMFADPLB KLLBDNMCGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct GENIMFADPLB : EPBCOPJMPPK, IEquatable<GENIMFADPLB>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly GENIMFADPLB CJBAGCINGJC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	[CreateProperty]
	public int FIFIFGFPIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9530D0", Offset = "0x9516D0", VA = "0x1809530D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x953140", Offset = "0x951740", VA = "0x180953140", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	[CreateProperty]
	public int CHHMHDKPLJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1D43610", Offset = "0x1D41C10", VA = "0x181D43610", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A83C00", Offset = "0x2A82200", VA = "0x182A83C00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F00220", Offset = "0x6EFE820", VA = "0x186F00220", Slot = "8")]
	public bool Equals(GENIMFADPLB FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F00270", Offset = "0x6EFE870", VA = "0x186F00270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class DEILPLKIBNJ<THasTokensTag> : NNNHDPACMOP, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Dictionary<Entity, GENIMFADPLB> JKMAAICJBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Stack<HashSet<object>> CFGNNJIMCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private KMKKAEEIGLF<GENIMFADPLB, HashSet<object>> DLCMJHDEMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private EntityManager PHHGGAMLDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private EntityCommandBufferSystem NKHEOBELIKH;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0070", Offset = "0x2DAE670", VA = "0x182DB0070")]
	public DEILPLKIBNJ(EntityManager PHHGGAMLDGB, EntityCommandBufferSystem NKHEOBELIKH, IAMDAJKPFJC AOBKGKBPPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2DADFF0", Offset = "0x2DAC5F0", VA = "0x182DADFF0", Slot = "4")]
	public bool CCNIAMGGANG(Entity MPAGCMNFGMI, object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD050", Offset = "0x2DAB650", VA = "0x182DAD050", Slot = "5")]
	public bool AFMHLMMKAND(Entity MPAGCMNFGMI, object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE920", Offset = "0x2DACF20", VA = "0x182DAE920", Slot = "6")]
	public bool IEFDKMIOCGO(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEB80", Offset = "0x2DAD180", VA = "0x182DAEB80", Slot = "9")]
	public bool IEFDKMIOCGO(GENIMFADPLB FCDGNCOICKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF170", Offset = "0x2DAD770", VA = "0x182DAF170", Slot = "7")]
	public bool KACAHBKCECI(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE250", Offset = "0x2DAC850", VA = "0x182DAE250", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE760", Offset = "0x2DACD60", VA = "0x182DAE760")]
	private void HIINHOPGKII(HashSet<object> LGFHMILAAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE370", Offset = "0x2DAC970", VA = "0x182DAE370")]
	private bool EHOPCHDGAND(Entity MPAGCMNFGMI, out GENIMFADPLB FCDGNCOICKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF430", Offset = "0x2DADA30", VA = "0x182DAF430")]
	private bool KGIFJCMKBJI(Entity MPAGCMNFGMI, out GENIMFADPLB FCDGNCOICKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD440", Offset = "0x2DABA40", VA = "0x182DAD440")]
	private void BDELDLNJEKP(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF7B0", Offset = "0x2DADDB0", VA = "0x182DAF7B0")]
	private void KKNGCDCNPOC(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD4D0", Offset = "0x2DABAD0", VA = "0x182DAD4D0")]
	private void BFNCFNPFDAF(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF840", Offset = "0x2DADE40", VA = "0x182DAF840")]
	private void LHJNLAEBPLJ(Entity MPAGCMNFGMI, GENIMFADPLB FCDGNCOICKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEDE0", Offset = "0x2DAD3E0", VA = "0x182DAEDE0")]
	private bool JGBFFBKDIEL(GENIMFADPLB FCDGNCOICKN, out HashSet<object> LGFHMILAAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD890", Offset = "0x2DABE90", VA = "0x182DAD890")]
	private HashSet<object> BLGJFKNJOEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class INEEHDKGBPB
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void BIIKLGCLHKP(this IAMDAJKPFJC BILPDCGHAAG, NativeArray<Entity> NCEOACJJMCN, [Optional][CallerFilePath] string NFHOABINDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void BIIKLGCLHKP(this IAMDAJKPFJC BILPDCGHAAG, string ECMAPGHKHFB, NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void BIIKLGCLHKP(this IAMDAJKPFJC BILPDCGHAAG, string NFHOABINDAH, NativeArray<Entity> NCEOACJJMCN, bool CLIONKHIKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void IFBILMLBLLN(this IAMDAJKPFJC BILPDCGHAAG, NativeArray<Entity> NCEOACJJMCN, EntityManager PHHGGAMLDGB, [Optional][CallerFilePath] string NFHOABINDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void IFBILMLBLLN(this IAMDAJKPFJC BILPDCGHAAG, string NFHOABINDAH, NativeArray<Entity> NCEOACJJMCN, EntityManager PHHGGAMLDGB, bool CLIONKHIKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void LHIHDFNMBLN(this IAMDAJKPFJC BILPDCGHAAG, NativeArray<Entity> NCEOACJJMCN, NativeArray<Entity> OJOAPPOPJPA, [Optional][CallerFilePath] string NFHOABINDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void LHIHDFNMBLN(this IAMDAJKPFJC BILPDCGHAAG, string NFHOABINDAH, NativeArray<Entity> NCEOACJJMCN, NativeArray<Entity> OJOAPPOPJPA, bool CLIONKHIKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x11E1120", Offset = "0x11DF720", VA = "0x1811E1120")]
	public static void PILHJMJGDPC<T>(this IAMDAJKPFJC BILPDCGHAAG, string ECMAPGHKHFB, NativeArray<Entity> NCEOACJJMCN, NativeList<T> JAIGDBINGHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x11E11B0", Offset = "0x11DF7B0", VA = "0x1811E11B0")]
	public static void PILHJMJGDPC<T>(this IAMDAJKPFJC BILPDCGHAAG, NativeArray<Entity> NCEOACJJMCN, NativeArray<T> JAIGDBINGHO, [Optional][CallerFilePath] string NFHOABINDAH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x11E1200", Offset = "0x11DF800", VA = "0x1811E1200")]
	public static void PILHJMJGDPC<T>(this IAMDAJKPFJC BILPDCGHAAG, string ECMAPGHKHFB, NativeArray<Entity> NCEOACJJMCN, NativeArray<T> JAIGDBINGHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void PILHJMJGDPC<T>(this IAMDAJKPFJC BILPDCGHAAG, string NFHOABINDAH, NativeArray<Entity> NCEOACJJMCN, NativeArray<T> JAIGDBINGHO, bool CLIONKHIKKL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x11E1090", Offset = "0x11DF690", VA = "0x1811E1090")]
	public static void DKKDHKNLKEF<T>(this IAMDAJKPFJC BILPDCGHAAG, NativeList<T> JAIGDBINGHO, [Optional][CallerFilePath] string NFHOABINDAH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x11E10F0", Offset = "0x11DF6F0", VA = "0x1811E10F0")]
	public static void DKKDHKNLKEF<T>(this IAMDAJKPFJC BILPDCGHAAG, NativeArray<T> JAIGDBINGHO, [Optional][CallerFilePath] string NFHOABINDAH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void DKKDHKNLKEF<T>(this IAMDAJKPFJC BILPDCGHAAG, string NFHOABINDAH, NativeArray<T> JAIGDBINGHO, bool CLIONKHIKKL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void HHKJNAEAAMP(this IAMDAJKPFJC BILPDCGHAAG, EntityQuery OGAAEGIJKLI, [Optional][CallerFilePath] string NFHOABINDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void HHKJNAEAAMP(this IAMDAJKPFJC BILPDCGHAAG, string ECMAPGHKHFB, EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void HHKJNAEAAMP(this IAMDAJKPFJC BILPDCGHAAG, string NFHOABINDAH, EntityQuery OGAAEGIJKLI, bool CLIONKHIKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x11E1060", Offset = "0x11DF660", VA = "0x1811E1060")]
	public static void AMOJKBAFHNM<T, T2>(this IAMDAJKPFJC BILPDCGHAAG, string ECMAPGHKHFB, EntityQuery OGAAEGIJKLI) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void AMOJKBAFHNM<T, T2>(this IAMDAJKPFJC BILPDCGHAAG, string NFHOABINDAH, EntityQuery OGAAEGIJKLI, bool CLIONKHIKKL) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x11E1060", Offset = "0x11DF660", VA = "0x1811E1060")]
	public static void FCJDOCLEHPL<T>(this IAMDAJKPFJC BILPDCGHAAG, string ECMAPGHKHFB, NativeList<T> IACDCADJJAN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void FCJDOCLEHPL<T>(this IAMDAJKPFJC BILPDCGHAAG, string NFHOABINDAH, NativeList<T> IACDCADJJAN, bool CLIONKHIKKL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x11E1060", Offset = "0x11DF660", VA = "0x1811E1060")]
	public static void BKJPHJDFJHP<T>(this IAMDAJKPFJC BILPDCGHAAG, string ECMAPGHKHFB, NativeArray<T> IACDCADJJAN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public static void BKJPHJDFJHP<T>(this IAMDAJKPFJC BILPDCGHAAG, string NFHOABINDAH, NativeArray<T> IACDCADJJAN, bool CLIONKHIKKL) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class JCIBJNJLFPG
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public JCIBJNJLFPG()
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

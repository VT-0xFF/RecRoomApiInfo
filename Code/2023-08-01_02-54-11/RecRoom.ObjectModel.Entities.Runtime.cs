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
		[Cpp2IlInjected.Address(RVA = "0x8484E0", Offset = "0x8474E0", VA = "0x1808484E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8484E0", Offset = "0x8474E0", VA = "0x1808484E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x71D13A0", Offset = "0x71D03A0", VA = "0x1871D13A0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AAHAMFEBLEA
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class LCIKPBJCEEE<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] PFAPACKPBJA;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x21EF380", Offset = "0x21EE380", VA = "0x1821EF380")]
	public static void JACKMLCDFOI<TField>(int EJNMEMKEIOD, string OKONKHNEMOO, AOIEHFJMOLK HFEPKJHJLKH, out GHGAIGEBNGH<TField> FJCNAJDOIIE) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21F1B50", Offset = "0x21F0B50", VA = "0x1821F1B50")]
	public static void LAJFBCEBBFA<TField>(int EJNMEMKEIOD, string OKONKHNEMOO, out BNAHOABKGKK<TField> HBOAIEOOPAF) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class PLKJLFCAFLA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x71D2AA0", Offset = "0x71D1AA0", VA = "0x1871D2AA0")]
	public static FieldInfo[] ENFIPAADNJJ(Type FLAJIGGIBOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class NPPMFBLFNBD<View, Data> : OLGNLABKOLK where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType LNKONBMMGCB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type OKKGJLJGJJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A88770", Offset = "0x2A87770", VA = "0x182A88770", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int NHGLEOPBBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A889B0", Offset = "0x2A879B0", VA = "0x182A889B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A883F0", Offset = "0x2A873F0", VA = "0x182A883F0")]
	public Data CIOLGLOJFNJ(Entity OIDNDCEGFCN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A88460", Offset = "0x2A87460", VA = "0x182A88460")]
	public Data KDJGCHPFCEA(Entity OIDNDCEGFCN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View ILHKMIJEONN(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x21FC5A0", Offset = "0x21FB5A0", VA = "0x1821FC5A0", Slot = "14")]
	public override T ILHKMIJEONN<T>(Entity OIDNDCEGFCN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2329D30", Offset = "0x2328D30", VA = "0x182329D30")]
	protected NPPMFBLFNBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class OLGNLABKOLK : AOIEHFJMOLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle NDDAPBBCJGM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager DDMBMPJOHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x943AA0", Offset = "0x942AA0", VA = "0x180943AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type OKKGJLJGJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int NHGLEOPBBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type OIKPLCMCMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x471AF70", Offset = "0x4719F70", VA = "0x18471AF70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int AOCLOPKJAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x71D2A30", Offset = "0x71D1A30", VA = "0x1871D2A30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private PDHNEODNMGH[] GMKCKJCMMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1260BD0", Offset = "0x125FBD0", VA = "0x181260BD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual PDHNEODNMGH[] EFALADHKMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x71D26E0", Offset = "0x71D16E0", VA = "0x1871D26E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x71D2910", Offset = "0x71D1910", VA = "0x1871D2910")]
	public void JFGMJMMFADK(EntityManager DKCFIIHAPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T ILHKMIJEONN<T>(Entity OIDNDCEGFCN) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x71D2840", Offset = "0x71D1840", VA = "0x1871D2840", Slot = "8")]
	public (uint, uint) FMDCDKABMBO(Entity OIDNDCEGFCN)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x71D27A0", Offset = "0x71D17A0", VA = "0x1871D27A0", Slot = "9")]
	public bool FHNLJNFGLBO(Entity OIDNDCEGFCN, (uint order, uint change) DFLAEIEBLPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	protected OLGNLABKOLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NAPHKHHANCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int OBKOEDDJOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private int PFDGPOIGHFM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JGOONMMKCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C3F0", Offset = "0x1E2B3F0", VA = "0x181E2C3F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x11BC270", Offset = "0x11BB270", VA = "0x1811BC270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FCIGFFEHMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA79570", Offset = "0xA78570", VA = "0x180A79570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int BJFHGMFDOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x71D2430", Offset = "0x71D1430", VA = "0x1871D2430")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x71D2450", Offset = "0x71D1450", VA = "0x1871D2450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xAEEDE0", Offset = "0xAEDDE0", VA = "0x180AEEDE0")]
	private NAPHKHHANCM(int OBKOEDDJOMJ, int PFDGPOIGHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE00", Offset = "0x30FAE00", VA = "0x1830FBE00")]
	public static NAPHKHHANCM EDMIHDGGEGO(int OBKOEDDJOMJ, int PFDGPOIGHFM)
	{
		return default(NAPHKHHANCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x71D2440", Offset = "0x71D1440", VA = "0x1871D2440")]
	public static NAPHKHHANCM IMKKOHEEJAG(int MAKGFFNPBIJ, int HKJNHGFOJEO)
	{
		return default(NAPHKHHANCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x71D2460", Offset = "0x71D1460", VA = "0x1871D2460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JGAGFGHFGFN : FHPPMKFAEIE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A550", Offset = "0x6B19550", VA = "0x186B1A550")]
	public float LONKECOJNKD(in float3 CKMKMNKGMMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A550", Offset = "0x6B19550", VA = "0x186B1A550", Slot = "4")]
	private float CGGKKMJNGIP(in float3 CKMKMNKGMMC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HMDHHCKIAGC : FHPPMKFAEIE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B18F40", Offset = "0x6B17F40", VA = "0x186B18F40")]
	public float LONKECOJNKD(in float3 CKMKMNKGMMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B18F40", Offset = "0x6B17F40", VA = "0x186B18F40", Slot = "4")]
	private float CGGKKMJNGIP(in float3 CKMKMNKGMMC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct EHOAKHGCIAD : FHPPMKFAEIE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xB6CDC0", Offset = "0xB6BDC0", VA = "0x180B6CDC0")]
	public float LONKECOJNKD(in float3 CKMKMNKGMMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xB6CDC0", Offset = "0xB6BDC0", VA = "0x180B6CDC0", Slot = "4")]
	private float CGGKKMJNGIP(in float3 CKMKMNKGMMC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NHNJJHBGAMN : FHPPMKFAEIE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xB331B0", Offset = "0xB321B0", VA = "0x180B331B0")]
	public int LONKECOJNKD(in int3 CKMKMNKGMMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xB331B0", Offset = "0xB321B0", VA = "0x180B331B0", Slot = "4")]
	private int IHFJFJGKLCH(in int3 CKMKMNKGMMC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NDFHCIGAMMF : FHPPMKFAEIE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6500900", Offset = "0x64FF900", VA = "0x186500900")]
	public int LONKECOJNKD(in int3 CKMKMNKGMMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6500900", Offset = "0x64FF900", VA = "0x186500900", Slot = "4")]
	private int IHFJFJGKLCH(in int3 CKMKMNKGMMC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EDADEAKIMJJ : FHPPMKFAEIE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xBE3A00", Offset = "0xBE2A00", VA = "0x180BE3A00")]
	public int LONKECOJNKD(in int3 CKMKMNKGMMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xBE3A00", Offset = "0xBE2A00", VA = "0x180BE3A00", Slot = "4")]
	private int IHFJFJGKLCH(in int3 CKMKMNKGMMC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HIKIKCKDNKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly byte[] FFBNIGIPHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MemoryStream IJMHEHCCCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CodedOutputStream DBLNBLOKKMF;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x71D1820", Offset = "0x71D0820", VA = "0x1871D1820", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
internal struct BLLKMBNDLIJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public ComponentDataFromEntity ECLKPGFEKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[ReadOnly]
	public NativeArray<Entity> LBGECGACKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeList<Entity> LDLACBCEGFO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x71D0F50", Offset = "0x71CFF50", VA = "0x1871D0F50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GABLLEIPEKK
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x71D1480", Offset = "0x71D0480", VA = "0x1871D1480")]
	[CBACCLKMMIE]
	public static JobHandle FEFAMHJHBEN(this EntityCommandBufferSystem ACFLGOEKGAE, NativeList<Entity> OBBDNLKJJED, [Optional] JobHandle JIEHHILAPHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x71D1610", Offset = "0x71D0610", VA = "0x1871D1610")]
	[CBACCLKMMIE]
	public static JobHandle FEFAMHJHBEN(this EntityCommandBufferSystem ACFLGOEKGAE, NativeArrayAsync<Entity> OBBDNLKJJED)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DBBGHPHKNOM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2216DF0", Offset = "0x2215DF0", VA = "0x182216DF0")]
	public static void AAFKPDCOEEO<T>(this EntityCommandBufferSystem ACFLGOEKGAE, EntityQuery IKPDHHKCFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2216E60", Offset = "0x2215E60", VA = "0x182216E60")]
	[CBACCLKMMIE]
	public static JobHandle ABDAFILFDHF<T>(this EntityCommandBufferSystem ACFLGOEKGAE, NativeListAsync<Entity> OBBDNLKJJED, [Optional] JobHandle JIEHHILAPHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2216F20", Offset = "0x2215F20", VA = "0x182216F20")]
	[CBACCLKMMIE]
	public static JobHandle ABDAFILFDHF<T>(this EntityCommandBufferSystem ACFLGOEKGAE, NativeArrayAsync<Entity> OBBDNLKJJED, [Optional] JobHandle JIEHHILAPHJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CFPHAEBDAKO
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct DNNLNMAFLGH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public NativeArray<Entity> BODDBNJOKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NativeArray<T> MCBAOGBOLLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct FLFMOPLBDBN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public NativeList<Entity> BODDBNJOKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NativeArray<T> MCBAOGBOLLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct LIKGPPBBCDH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NativeArrayAsync<Entity> BODDBNJOKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NativeArrayAsync<T> MCBAOGBOLLG;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x21F2ED0", Offset = "0x21F1ED0", VA = "0x1821F2ED0")]
		public NativeListAsync<Entity> AFLCAJJIPHF<TPredicate>() where TPredicate : struct, HKMMKCNPMEN<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A14160", Offset = "0x2A13160", VA = "0x182A14160")]
	public static LIKGPPBBCDH<T> GKPJNIKPPNP<T>(this NativeArrayAsync<Entity> LBGECGACKBM, NativeArrayAsync<T> IBHIPLMPOFD, Allocator LEPNDEGMIDH = Allocator.TempJob) where T : struct
	{
		return default(LIKGPPBBCDH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BKNMDJBIOGH : FLIAAMNMIFP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Type FGAEPFHFLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Type FPIEEOLIMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x71D0EF0", Offset = "0x71CFEF0", VA = "0x1871D0EF0")]
	public BKNMDJBIOGH(Type KDANBALNPNA, Type ECLKPGFEKIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class HKIPNABGHBK
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class EDGBJKNMPPB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2576D60", Offset = "0x2575D60", VA = "0x182576D60")]
	public static NativeList<Entity> BCLONDJCAPO<T>(this NativeArray<Entity> LBGECGACKBM, EntityManager DKCFIIHAPKN, Allocator LEPNDEGMIDH = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CMCNGAPOPIE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly MemoryStream IJMHEHCCCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CodedInputStream INPCBFOGHDF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x71D0FE0", Offset = "0x71CFFE0", VA = "0x1871D0FE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class PBMOOPCHNNP
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct NMDGNKJNGAI : FHPPMKFAEIE<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> IHJJMEDMNEM;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x71D24F0", Offset = "0x71D14F0", VA = "0x1871D24F0")]
		[BurstCompatible]
		public Entity LONKECOJNKD(in Entity CKMKMNKGMMC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x71D24F0", Offset = "0x71D14F0", VA = "0x1871D24F0", Slot = "4")]
		private Entity KBJJJMOGCKF(in Entity CKMKMNKGMMC)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct JAGEALGBDBE<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LJMINIILJHN : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JAGEALGBDBE<Protobuf> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xACBFD0", Offset = "0xACAFD0", VA = "0x180ACBFD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2686B70", Offset = "0x2685B70", VA = "0x182686B70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x185C630", Offset = "0x185B630", VA = "0x18185C630")]
		[DebuggerHidden]
		public LJMINIILJHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2E75CC0", Offset = "0x2E74CC0", VA = "0x182E75CC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2E75E80", Offset = "0x2E74E80", VA = "0x182E75E80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Action<Protobuf> BGKNCMNCADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MemoryStream IJMHEHCCCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CodedInputStream INPCBFOGHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Protobuf OMNHNNHGJAE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int MGNEPOBDAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA74E00", Offset = "0xA73E00", VA = "0x180A74E00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3095560", Offset = "0x3094560", VA = "0x183095560")]
	private JAGEALGBDBE(byte[] FFBNIGIPHNB, Action<Protobuf> BGKNCMNCADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x21EC450", Offset = "0x21EB450", VA = "0x1821EC450")]
	public static JAGEALGBDBE<Protobuf> GGPPECCFBMF<Data>(ReadOnlySpan<byte> AOBDCPLDMJI, ReadOnlySpan<Data> KKCHKODIJBH, Action<Protobuf> BGKNCMNCADG)
	{
		return default(JAGEALGBDBE<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x30953D0", Offset = "0x30943D0", VA = "0x1830953D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3095410", Offset = "0x3094410", VA = "0x183095410", Slot = "4")]
	[IteratorStateMachine(typeof(JAGEALGBDBE<>.LJMINIILJHN))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3095510", Offset = "0x3094510", VA = "0x183095510", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class KFDEPAMOKAC : MFJDJFHKHKN
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x71D1ED0", Offset = "0x71D0ED0", VA = "0x1871D1ED0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase PLCMNKEMNMN();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x71D1E80", Offset = "0x71D0E80", VA = "0x1871D1E80")]
	protected ComponentSystemBase FOMCCJOCOPP(params ComponentSystemBase[] NEFLIPPAGDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2346870", Offset = "0x2345870", VA = "0x182346870")]
	protected ComponentSystemBase FOMCCJOCOPP<T>(params ComponentSystemBase[] NEFLIPPAGDL) where T : MFJDJFHKHKN, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x23467E0", Offset = "0x23457E0", VA = "0x1823467E0")]
	protected ComponentSystemBase ENEFALCKGNM<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x23467E0", Offset = "0x23457E0", VA = "0x1823467E0")]
	protected ComponentSystemBase BLNFOBKKIGB<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x71D1F20", Offset = "0x71D0F20", VA = "0x1871D1F20")]
	protected ComponentSystemBase PEOBKDPJEHG(params SystemHandleUntyped[] NEFLIPPAGDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2346910", Offset = "0x2345910", VA = "0x182346910")]
	protected ComponentSystemBase PEOBKDPJEHG<T>(params SystemHandleUntyped[] NEFLIPPAGDL) where T : MFJDJFHKHKN, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2346820", Offset = "0x2345820", VA = "0x182346820")]
	protected SystemHandleUntyped CNPBGLJOHNP<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x71D1F70", Offset = "0x71D0F70", VA = "0x1871D1F70")]
	protected KFDEPAMOKAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JEAEJNGFKOC
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x20AFE80", Offset = "0x20AEE80", VA = "0x1820AFE80")]
	public static NativeList<T> IKCMCMKMGCN<T>(NativeList<T> IBHIPLMPOFD, Allocator LEPNDEGMIDH) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JOHMLLJHMPC
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct MMDNLKNAMMM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : FHPPMKFAEIE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> MCBAOGBOLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeList<TFrom> AADMHPKOHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeParallelHashSet<TTo> LOAKNOKOKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap NPNCNABHINE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct ECJECNOMLHF<T, TPredicate> : IJob where T : struct where TPredicate : struct, HKMMKCNPMEN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<T> MCBAOGBOLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> BODDBNJOKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeList<Entity> HBGJPMABDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public TPredicate NPNCNABHINE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27C83A0", Offset = "0x27C73A0", VA = "0x1827C83A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct DJIOOFNBPPA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FHPPMKFAEIE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<TFrom> OLBNKCHJCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[WriteOnly]
	public NativeList<TTo> APMALOGGOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public TMap NPNCNABHINE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class BAEHABKKGEF
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct EGJKGHBPFFM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly NativeArray<T>.ReadOnly OGEGDDKCPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int GOKCMPDIEBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int DKICCEPBOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private T DKPPAPNILGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private T GCECBPOMLJH;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public NAPHKHHANCM GEMJNMLBAIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x27CDB30", Offset = "0x27CCB30", VA = "0x1827CDB30")]
			get
			{
				return default(NAPHKHHANCM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T BCJKLOAGJJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x23453E0", Offset = "0x23443E0", VA = "0x1823453E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (T, NAPHKHHANCM) DALPLHLAAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x27CDB40", Offset = "0x27CCB40", VA = "0x1827CDB40")]
			get
			{
				return default((T, NAPHKHHANCM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x27CE000", Offset = "0x27CD000", VA = "0x1827CE000")]
		public EGJKGHBPFFM(NativeArray<T> OGEGDDKCPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2345230", Offset = "0x2344230", VA = "0x182345230")]
		public EGJKGHBPFFM<T> DHFGGODEIOI()
		{
			return default(EGJKGHBPFFM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x27CDE70", Offset = "0x27CCE70", VA = "0x1827CDE70")]
		public bool OPHKMIEKJIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x29CEAE0", Offset = "0x29CDAE0", VA = "0x1829CEAE0")]
		public HEAENFMCPID<T, TComparer> OCGCPKCEIOB<TComparer>([Optional] TComparer BEIFJNPPPMC) where TComparer : struct, IEqualityComparer<T>
		{
			return default(HEAENFMCPID<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct HEAENFMCPID<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly NativeArray<T>.ReadOnly OGEGDDKCPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int GOKCMPDIEBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int DKICCEPBOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T DKPPAPNILGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private T GCECBPOMLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TComparer BEIFJNPPPMC;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NAPHKHHANCM GEMJNMLBAIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x27CDB30", Offset = "0x27CCB30", VA = "0x1827CDB30")]
			get
			{
				return default(NAPHKHHANCM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public T BCJKLOAGJJA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x23453E0", Offset = "0x23443E0", VA = "0x1823453E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public (T value, NAPHKHHANCM range) DALPLHLAAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2CED7D0", Offset = "0x2CEC7D0", VA = "0x182CED7D0")]
			get
			{
				return default((T, NAPHKHHANCM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2CEDB00", Offset = "0x2CECB00", VA = "0x182CEDB00")]
		public HEAENFMCPID(NativeArray<T>.ReadOnly OGEGDDKCPPH, TComparer BEIFJNPPPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x21D0B60", Offset = "0x21CFB60", VA = "0x1821D0B60")]
		public HEAENFMCPID<T, TComparer> DHFGGODEIOI()
		{
			return default(HEAENFMCPID<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2CED8A0", Offset = "0x2CEC8A0", VA = "0x182CED8A0")]
		public bool OPHKMIEKJIG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2C98240", Offset = "0x2C97240", VA = "0x182C98240")]
	public static EGJKGHBPFFM<T> FOMCCJOCOPP<T>(this NativeArray<T> OGEGDDKCPPH) where T : struct
	{
		return default(EGJKGHBPFFM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FHPPMKFAEIE<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LONKECOJNKD(in TFrom CKMKMNKGMMC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class LPPDEANNINC
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class EJBOJCBMHIK
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EGJHJKBNHND<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public EGJHJKBNHND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class LEIMDIPCKJD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		public LEIMDIPCKJD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<Func<JobHandle, JobHandle>> OEBMGHIKKHB;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x71D1320", Offset = "0x71D0320", VA = "0x1871D1320")]
	public EJBOJCBMHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class KIFIMMACFMI
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class NPDDGIOMOGM : EntityCommandBufferSystem, HCCCHBLBEMM
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8484E0", Offset = "0x8474E0", VA = "0x1808484E0")]
	protected NPDDGIOMOGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NLONDCOFKMP
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x31215F0", Offset = "0x31205F0", VA = "0x1831215F0")]
	[CBACCLKMMIE]
	public static JobHandle LIKOMAHAMPO<T>(this EntityCommandBufferSystem ACFLGOEKGAE, NativeArray<Entity> OBBDNLKJJED, NativeArray<T> HCKNMLENIIG, JobHandle JIEHHILAPHJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct DGPODEDHNCK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<T> MCBAOGBOLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<T> AADMHPKOHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<T> LOAKNOKOKFD;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2694E40", Offset = "0x2693E40", VA = "0x182694E40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct JGCHPLJHKLD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> OBBDNLKJJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EntityCommandBuffer NLEKDLBPJNL;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x71D1970", Offset = "0x71D0970", VA = "0x1871D1970", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DGLEMBKCMME
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x221F420", Offset = "0x221E420", VA = "0x18221F420")]
	public static NativeArray<T> FJIKLBHEMMH<T>(this NativeList<Entity> IBHIPLMPOFD, EntityManager DKCFIIHAPKN, Allocator LEPNDEGMIDH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x221F080", Offset = "0x221E080", VA = "0x18221F080")]
	public static NativeArray<T> FJIKLBHEMMH<T>(this NativeArray<Entity> IBHIPLMPOFD, EntityManager DKCFIIHAPKN, Allocator LEPNDEGMIDH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HPBINIJLKBF
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LLAFDCOIOJP
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal struct NPNIDDKGHOG<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> OBBDNLKJJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public T CKMKMNKGMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public EntityCommandBuffer NLEKDLBPJNL;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2A86350", Offset = "0x2A85350", VA = "0x182A86350", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class IIHKHECELOH
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x18A06B0", Offset = "0x189F6B0", VA = "0x1818A06B0")]
	[CBACCLKMMIE]
	public static JobHandle EKMJNIAKGHE<T>(this EntityCommandBufferSystem ACFLGOEKGAE, EntityCommandBuffer NLEKDLBPJNL, EntityQuery IKPDHHKCFNO, T CKMKMNKGMMC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class BHHAEJEGCKP<Data> : BDGAHMNGEHF where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public virtual Data FHJNMCMHCKN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FC2C50", Offset = "0x1FC1C50", VA = "0x181FC2C50", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD500", Offset = "0x1FAC500", VA = "0x181FAD500", Slot = "8")]
	protected virtual bool DGCLLMNPHON(ReadOnlySpan<Data> KKCHKODIJBH, BLCPACFGGAB NPICGHFIINL, out ReadOnlySpan<byte> AOBDCPLDMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x84F1E0", Offset = "0x84E1E0", VA = "0x18084F1E0", Slot = "9")]
	protected virtual bool KBFOOFPNEPE(int DFLAEIEBLPA, Span<Data> KKCHKODIJBH, in ReadOnlySpan<byte> AOBDCPLDMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3E05DF0", Offset = "0x3E04DF0", VA = "0x183E05DF0", Slot = "5")]
	internal sealed override bool DGCLLMNPHON(ref Unity.Entities.Chunk FMIICDBIHDH, int JDILGHPOLGF, BLCPACFGGAB NPICGHFIINL, out ReadOnlySpan<byte> AOBDCPLDMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3E068F0", Offset = "0x3E058F0", VA = "0x183E068F0", Slot = "6")]
	internal sealed override bool KBFOOFPNEPE(int DFLAEIEBLPA, ref Unity.Entities.Chunk FMIICDBIHDH, int JDILGHPOLGF, in ReadOnlySpan<byte> AOBDCPLDMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x25B1DD0", Offset = "0x25B0DD0", VA = "0x1825B1DD0")]
	protected CACFDNEIIKP<Protobuf> OFNGPFLCJEE<Protobuf>(ReadOnlySpan<Data> KKCHKODIJBH) where Protobuf : IMessage, new()
	{
		return default(CACFDNEIIKP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25B1D40", Offset = "0x25B0D40", VA = "0x1825B1D40")]
	protected JAGEALGBDBE<Protobuf> IMOOEMKCONB<Protobuf>(ReadOnlySpan<byte> AOBDCPLDMJI, ReadOnlySpan<Data> KKCHKODIJBH, Action<Protobuf> BGKNCMNCADG) where Protobuf : IMessage, new()
	{
		return default(JAGEALGBDBE<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2329D30", Offset = "0x2328D30", VA = "0x182329D30")]
	protected BHHAEJEGCKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class BDGAHMNGEHF
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected abstract int AHEIGHJAOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x71D0ED0", Offset = "0x71CFED0", VA = "0x1871D0ED0", Slot = "5")]
	internal virtual bool DGCLLMNPHON(ref Unity.Entities.Chunk FMIICDBIHDH, int JDILGHPOLGF, BLCPACFGGAB NPICGHFIINL, out ReadOnlySpan<byte> AOBDCPLDMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x84F1E0", Offset = "0x84E1E0", VA = "0x18084F1E0", Slot = "6")]
	internal virtual bool KBFOOFPNEPE(int DFLAEIEBLPA, ref Unity.Entities.Chunk FMIICDBIHDH, int JDILGHPOLGF, in ReadOnlySpan<byte> AOBDCPLDMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	protected BDGAHMNGEHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FIAOPLOMNBA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct GFEKLFHNIKJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct NGBHADABADD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal GFEKLFHNIKJ<TFrom> AGFCJPGACCB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> GDILAPBOMGI;
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct FLLAPHIDHOF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public struct DADJMGDADMA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal FLLAPHIDHOF<TFrom> AGFCJPGACCB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> GDILAPBOMGI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct HBHGLJJKIPC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public struct HNGNGDFHMCO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal HBHGLJJKIPC<TFrom> AGFCJPGACCB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> GDILAPBOMGI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct PHMOMMMHAKE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public struct PIKMINBBDBB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal PHMOMMMHAKE<TFrom> AGFCJPGACCB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> GDILAPBOMGI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct HBLKLDKAMNJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	public ComponentDataFromEntity LODMKMJNOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	public NativeArray<Entity> MCBAOGBOLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[WriteOnly]
	public NativeArray<byte> APMALOGGOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int PODKGHCMDGB;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x71D1720", Offset = "0x71D0720", VA = "0x1871D1720", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[BurstCompile]
internal struct HMFAOGKABII<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ECLKPGFEKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[ReadOnly]
	public NativeArray<Entity> LBGECGACKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<bool> LKEDDOCLAFG;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal struct BAJELBHNJPF<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[ReadOnly]
	public NativeArray<Entity> OBBDNLKJJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[ReadOnly]
	public NativeArray<T> JIBLOMPBADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public EntityCommandBuffer NLEKDLBPJNL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class BJEJGPBGANJ
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x26269F0", Offset = "0x26259F0", VA = "0x1826269F0")]
	public static NativeListAsync<Entity> EHCKHODMGBM<T, TPredicate>(this NativeArrayAsync<T> IBHIPLMPOFD, NativeArrayAsync<Entity> LBGECGACKBM, Allocator LEPNDEGMIDH = Allocator.TempJob) where T : struct where TPredicate : struct, HKMMKCNPMEN<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2626AB0", Offset = "0x2625AB0", VA = "0x182626AB0")]
	private static NativeListAsync<Entity> KNIECFAFHDJ<T, TPredicate>(NativeArrayAsync<T> LNAHBKCHPAD, NativeArrayAsync<Entity> LBGECGACKBM, int GAKMECKICIG, Allocator LEPNDEGMIDH) where T : struct where TPredicate : struct, HKMMKCNPMEN<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class BCGEDOGHGFJ
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2C98B20", Offset = "0x2C97B20", VA = "0x182C98B20")]
	[CBACCLKMMIE]
	public static JobHandle IDOPAMJJGAI<T>(this EntityCommandBufferSystem ACFLGOEKGAE, NativeArray<Entity> OBBDNLKJJED, T CKMKMNKGMMC, [Optional] JobHandle JIEHHILAPHJ) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2C98BF0", Offset = "0x2C97BF0", VA = "0x182C98BF0")]
	[CBACCLKMMIE]
	public static JobHandle IDOPAMJJGAI<T>(this EntityCommandBufferSystem ACFLGOEKGAE, EntityCommandBuffer NLEKDLBPJNL, NativeArray<Entity> OBBDNLKJJED, T CKMKMNKGMMC, [Optional] JobHandle JIEHHILAPHJ) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class BLCPACFGGAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> HLNHHDCJNID;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x216C4E0", Offset = "0x216B4E0", VA = "0x18216C4E0")]
	public BLCPACFGGAB(NativeArray<EntityRemapUtility.EntityRemapInfo> HLNHHDCJNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x71D0F40", Offset = "0x71CFF40", VA = "0x1871D0F40")]
	public Entity CIBDLHIBPPN(Entity PCALNIOABDP)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class GNONIDOEKIE
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x29659F0", Offset = "0x29649F0", VA = "0x1829659F0")]
	public static NativeList<T> IKCMCMKMGCN<T>(this NativeList<T> IBHIPLMPOFD, Allocator LEPNDEGMIDH = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2965820", Offset = "0x2964820", VA = "0x182965820")]
	public static NativeList<T> IKCMCMKMGCN<T>(this NativeArray<T> IBHIPLMPOFD, Allocator LEPNDEGMIDH = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class DPLANIDKFGK
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct DLBOBJONPEM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> MCBAOGBOLLG;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct IPGNGMDJFAD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<T> MCBAOGBOLLG;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct JGILNHHCAPM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<T> MCBAOGBOLLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct PCGEMPNJDEE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeListAsync<T> MCBAOGBOLLG;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
internal struct PKHDNJMDIEP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FHPPMKFAEIE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeArray<TFrom> MCBAOGBOLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[WriteOnly]
	public NativeArray<TTo> APMALOGGOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TMap NPNCNABHINE;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface HKMMKCNPMEN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFLCAJJIPHF(T CKMKMNKGMMC);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
internal struct KGAHKANNAJC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	public NativeArray<Entity> OBBDNLKJJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public EntityCommandBuffer NLEKDLBPJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public ComponentTypes LBMPLLOBPJH;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x71D1FD0", Offset = "0x71D0FD0", VA = "0x1871D1FD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[BurstCompile]
internal struct MFPBHHNDBJC<T, TPredicate> : IJob where T : struct where TPredicate : struct, HKMMKCNPMEN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	public NativeArray<T> MCBAOGBOLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<T> AADMHPKOHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public TPredicate NPNCNABHINE;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MFJDJFHKHKN : PNBNJGKIDMM
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x71D2300", Offset = "0x71D1300", VA = "0x1871D2300", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x71D1F70", Offset = "0x71D0F70", VA = "0x1871D1F70")]
	public MFJDJFHKHKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[BurstCompile]
internal struct LNCNFGCIJBK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ECLKPGFEKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	public NativeArray<Entity> LBGECGACKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<bool> LKEDDOCLAFG;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x24BB0F0", Offset = "0x24BA0F0", VA = "0x1824BB0F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct EBMACIEHDEA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<Entity> OBBDNLKJJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	public NativeArray<T> HCKNMLENIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public EntityCommandBuffer NLEKDLBPJNL;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x27C19D0", Offset = "0x27C09D0", VA = "0x1827C19D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MNCBBOEGIBG
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x71D2330", Offset = "0x71D1330", VA = "0x1871D2330")]
	public static ulong LGPKOFNNBJI(Type FLAJIGGIBOB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x71D23C0", Offset = "0x71D13C0", VA = "0x1871D23C0")]
	public static ulong LGPKOFNNBJI(string MHKMEFOBAGE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class JCGDEGAFNNB : FLIAAMNMIFP
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Type FPIEEOLIMKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x31EF450", Offset = "0x31EE450", VA = "0x1831EF450")]
	public JCGDEGAFNNB(Type ECLKPGFEKIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[BurstCompile]
internal struct FAHPFLHFJKI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public ComponentDataFromEntity ECLKPGFEKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	public NativeArray<Entity> LBGECGACKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<Entity> LDLACBCEGFO;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x71D13C0", Offset = "0x71D03C0", VA = "0x1871D13C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public abstract class OFFFNLLOPIC : SystemBase, HCCCHBLBEMM
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x71D2600", Offset = "0x71D1600", VA = "0x1871D2600")]
	public ComponentDataFromEntity EONNBHFGFCG(int BKAKEAMNOAC, bool FCPNEDMPJPP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x71D25E0", Offset = "0x71D15E0", VA = "0x1871D25E0")]
	public EntityExistenceLookupByEntity ENOABPCDBPM()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x71D26D0", Offset = "0x71D16D0", VA = "0x1871D26D0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9CACE0", Offset = "0x9C9CE0", VA = "0x1809CACE0")]
	protected OFFFNLLOPIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class JAGGPLGNDAK : OFFFNLLOPIC
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x71D1940", Offset = "0x71D0940", VA = "0x1871D1940", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x9CACE0", Offset = "0x9C9CE0", VA = "0x1809CACE0")]
	protected JAGGPLGNDAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class FGJDFKKDCLK
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct CACFDNEIIKP<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly byte[] FFBNIGIPHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Protobuf OMNHNNHGJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly MemoryStream IJMHEHCCCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly CodedOutputStream DBLNBLOKKMF;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB9A0", Offset = "0x2CDA9A0", VA = "0x182CDB9A0")]
	private CACFDNEIIKP(byte[] FFBNIGIPHNB, in Protobuf OMNHNNHGJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x29B7FF0", Offset = "0x29B6FF0", VA = "0x1829B7FF0")]
	public static CACFDNEIIKP<Protobuf> GGPPECCFBMF<T>(ReadOnlySpan<T> KKCHKODIJBH)
	{
		return default(CACFDNEIIKP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB8E0", Offset = "0x2CDA8E0", VA = "0x182CDB8E0")]
	public void IOEJIAOLMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB910", Offset = "0x2CDA910", VA = "0x182CDB910")]
	public ByteString LMOGLGNNLBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB7C0", Offset = "0x2CDA7C0", VA = "0x182CDB7C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface HCCCHBLBEMM
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public abstract class PNBNJGKIDMM : ComponentSystemGroup, HCCCHBLBEMM
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x71D1F70", Offset = "0x71D0F70", VA = "0x1871D1F70")]
	protected PNBNJGKIDMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class JPLINKLPIMI
{
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[BurstCompile]
internal struct HBANAEHNDMN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MFNJICLGGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public NativeArray<Entity> MCBAOGBOLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[WriteOnly]
	public NativeList<T> AADMHPKOHDE;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[Flags]
public enum LNDEDGGBBFB
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
public class CPKJPNKIPKB : FLIAAMNMIFP
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x9CACE0", Offset = "0x9C9CE0", VA = "0x1809CACE0")]
	public CPKJPNKIPKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class FMEJIGBPLMB
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public readonly struct AENCIPCOEDC<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly NativeArray<TSrc> OGEGDDKCPPH;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x15EA3E0", Offset = "0x15E93E0", VA = "0x1815EA3E0")]
		public AENCIPCOEDC(NativeArray<TSrc> OGEGDDKCPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		public NNHPBFLHPFF<TSrc, TValue> BBLCKAIHEHK<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(NNHPBFLHPFF<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct NNHPBFLHPFF<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly NativeArray<TSrc> OGEGDDKCPPH;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x15EA3E0", Offset = "0x15E93E0", VA = "0x1815EA3E0")]
		public NNHPBFLHPFF(NativeArray<TSrc> OGEGDDKCPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		public IOIJMICCBKP<TSrc, TValue, TSelector> KFLOEIDAMHD<TSelector>() where TSelector : struct, FHPPMKFAEIE<TSrc, TValue>
		{
			return default(IOIJMICCBKP<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct IOIJMICCBKP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FHPPMKFAEIE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly NativeArray<TSrc> OGEGDDKCPPH;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x15EA3E0", Offset = "0x15E93E0", VA = "0x1815EA3E0")]
		public IOIJMICCBKP(NativeArray<TSrc> OGEGDDKCPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F250", Offset = "0x2A9E250", VA = "0x182A9F250")]
		public ENEPJKEFDDL<TSrc, TValue, TSelector> FOMCCJOCOPP()
		{
			return default(ENEPJKEFDDL<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct EAAPEBODHIF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, FHPPMKFAEIE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly NativeArray<TSrc> OGEGDDKCPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TSelector BODAADIHHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int EJNMEMKEIOD;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TValue DALPLHLAAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x22A6010", Offset = "0x22A5010", VA = "0x1822A6010")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int EHPNNEFNFPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x9A6670", Offset = "0x9A5670", VA = "0x1809A6670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int MGNEPOBDAFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA9F770", Offset = "0xA9E770", VA = "0x180A9F770")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x22A61B0", Offset = "0x22A51B0", VA = "0x1822A61B0")]
		public EAAPEBODHIF(NativeArray<TSrc> OGEGDDKCPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x22A61A0", Offset = "0x22A51A0", VA = "0x1822A61A0")]
		public bool OPHKMIEKJIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x22A6080", Offset = "0x22A5080", VA = "0x1822A6080")]
		private TSrc NNEALAFMKCH(int MBMAEEFDADD)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public struct ENEPJKEFDDL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FHPPMKFAEIE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private EAAPEBODHIF<TSrc, TValue, TSelector> FOFFMOPCHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TValue DKPPAPNILGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int GOKCMPDIEBG;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NAPHKHHANCM GEMJNMLBAIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x1355990", Offset = "0x1354990", VA = "0x181355990")]
			get
			{
				return default(NAPHKHHANCM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TValue BCJKLOAGJJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x999690", Offset = "0x998690", VA = "0x180999690")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (TValue value, NAPHKHHANCM range) DALPLHLAAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x13559D0", Offset = "0x13549D0", VA = "0x1813559D0")]
			get
			{
				return default((TValue, NAPHKHHANCM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1355BF0", Offset = "0x1354BF0", VA = "0x181355BF0")]
		public ENEPJKEFDDL(NativeArray<TSrc> OGEGDDKCPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1355AA0", Offset = "0x1354AA0", VA = "0x181355AA0")]
		public ENEPJKEFDDL<TSrc, TValue, TSelector> DHFGGODEIOI()
		{
			return default(ENEPJKEFDDL<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1355AC0", Offset = "0x1354AC0", VA = "0x181355AC0")]
		public bool OPHKMIEKJIG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x13E6C20", Offset = "0x13E5C20", VA = "0x1813E6C20")]
	public static AENCIPCOEDC<T> EAPNAMCFFDC<T>(this NativeList<T> IHMGNIOOIJN) where T : struct
	{
		return default(AENCIPCOEDC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
	public static AENCIPCOEDC<T> EAPNAMCFFDC<T>(this NativeArray<T> OGEGDDKCPPH) where T : struct
	{
		return default(AENCIPCOEDC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class HKADMIEDJJN
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct NJHMIKLKLHE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct FNBMKPJHBPP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public NJHMIKLKLHE<TFrom> GDILAPBOMGI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NativeArray<TFrom> MCBAOGBOLLG;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct BCKIDKCKKEA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public struct CPKEFBGNDKI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public BCKIDKCKKEA<TFrom> GDILAPBOMGI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeArrayAsync<TFrom> MCBAOGBOLLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct PGDCFONDKPC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public struct HLLHABKFDBH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public PGDCFONDKPC<TFrom> GDILAPBOMGI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Allocator LEPNDEGMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NativeListAsync<TFrom> MCBAOGBOLLG;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[BurstCompile]
internal struct FLENHEMNKEE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	public NativeArray<Entity> OBBDNLKJJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public EntityCommandBuffer NLEKDLBPJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public ComponentType BKPOGOMFHHA;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x71D1450", Offset = "0x71D0450", VA = "0x1871D1450", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class HDOMFLCHCJP
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x29699E0", Offset = "0x29689E0", VA = "0x1829699E0")]
	public static bool JOOPMDICJGG<T>(this NativeArray<Entity> LBGECGACKBM, EntityManager DKCFIIHAPKN, Allocator LEPNDEGMIDH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class MENJCCPACDM
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class AJCAEAPHKOF
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class EICNNAPHMNI
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public delegate void NJKEMHKPDIF<From, To>(From GDILAPBOMGI, ref To OPPNHDACHEH, BLCPACFGGAB NPICGHFIINL);

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private class EPCGCAHEADE<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static NJKEMHKPDIF<From, To> DOEMNCCPIEO;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public EPCGCAHEADE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x71D1020", Offset = "0x71D0020", VA = "0x1871D1020")]
	static EICNNAPHMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2579680", Offset = "0x2578680", VA = "0x182579680")]
	public static void FBAAHPJOJJG<T>(NJKEMHKPDIF<T, T> NCHEHAFAMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2E04CB0", Offset = "0x2E03CB0", VA = "0x182E04CB0")]
	public static void FBAAHPJOJJG<From, To>(NJKEMHKPDIF<From, To> NCHEHAFAMPC, NJKEMHKPDIF<To, From> GOKIGPEMAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2579630", Offset = "0x2578630", VA = "0x182579630")]
	public static void FBAAHPJOJJG<From, To>(NJKEMHKPDIF<From, To> DOEMNCCPIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2E07140", Offset = "0x2E06140", VA = "0x182E07140")]
	public static NJKEMHKPDIF<From, To> ODFFKMABOFC<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D700", Offset = "0x2E0C700", VA = "0x182E0D700")]
	public static void PJMOJBJNMEK<From, To>(From GDILAPBOMGI, ref To OPPNHDACHEH, BLCPACFGGAB NPICGHFIINL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class LHMOGDLLCAE
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2357B40", Offset = "0x2356B40", VA = "0x182357B40")]
	[CBACCLKMMIE]
	public static JobHandle NOOBAKOGMEE<T>(this EntityCommandBufferSystem ACFLGOEKGAE, NativeArrayAsync<Entity> OBBDNLKJJED, NativeArrayAsync<T> HCKNMLENIIG, [Optional] JobHandle JIEHHILAPHJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2357DB0", Offset = "0x2356DB0", VA = "0x182357DB0")]
	[CBACCLKMMIE]
	public static JobHandle NOOBAKOGMEE<T>(this EntityCommandBufferSystem ACFLGOEKGAE, NativeArrayAsync<Entity> OBBDNLKJJED)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2357C90", Offset = "0x2356C90", VA = "0x182357C90")]
	[CBACCLKMMIE]
	public static JobHandle NOOBAKOGMEE<T>(this EntityCommandBufferSystem ACFLGOEKGAE, NativeArray<Entity> OBBDNLKJJED, [Optional] JobHandle JIEHHILAPHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x71D2190", Offset = "0x71D1190", VA = "0x1871D2190")]
	[CBACCLKMMIE]
	public static JobHandle NOOBAKOGMEE(this EntityCommandBufferSystem ACFLGOEKGAE, NativeArray<Entity> OBBDNLKJJED, ComponentTypes LBMPLLOBPJH, [Optional] JobHandle JIEHHILAPHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x71D2030", Offset = "0x71D1030", VA = "0x1871D2030")]
	[CBACCLKMMIE]
	public static JobHandle NOOBAKOGMEE(this EntityCommandBufferSystem ACFLGOEKGAE, EntityCommandBuffer NLEKDLBPJNL, NativeArray<Entity> OBBDNLKJJED, ComponentTypes LBMPLLOBPJH, [Optional] JobHandle JIEHHILAPHJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class KBKCPHGKIII
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x71D1CC0", Offset = "0x71D0CC0", VA = "0x1871D1CC0")]
	private unsafe static Span<byte> KAEGBHCAELK(Unity.Entities.Chunk* FMIICDBIHDH, int JDILGHPOLGF)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x13B5AC0", Offset = "0x13B4AC0", VA = "0x1813B5AC0")]
	public unsafe static Span<T> ADKEKKHLEMM<T>(Unity.Entities.Chunk* FMIICDBIHDH, int JDILGHPOLGF)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x13B5A80", Offset = "0x13B4A80", VA = "0x1813B5A80")]
	public static Span<T> ADKEKKHLEMM<T>(this ref Unity.Entities.Chunk FMIICDBIHDH, int JDILGHPOLGF)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x71D1C50", Offset = "0x71D0C50", VA = "0x1871D1C50")]
	public unsafe static Span<Entity> FMPHPGOGCAH(Unity.Entities.Chunk* FMIICDBIHDH)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x71D19D0", Offset = "0x71D09D0", VA = "0x1871D19D0")]
	public unsafe static void EPCDHGCGJPK(Unity.Entities.Chunk* FMIICDBIHDH, int JDILGHPOLGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[AttributeUsage(AttributeTargets.Class)]
public class PDDKLKCDAFO : FLIAAMNMIFP
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x9CACE0", Offset = "0x9C9CE0", VA = "0x1809CACE0")]
	public PDDKLKCDAFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface CODPOJJKDJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BHPOAIDJHEK(Entity OIDNDCEGFCN, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OCAHKHCIHHN(Entity OIDNDCEGFCN, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LPIPFLLCJPB(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<object> KOOGKPCJFPP(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AOMNLCKLMBH(Entity OIDNDCEGFCN);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class JDAFHKMJDAF<TComponentData, TValue> : PAMAAJCPGKH<TValue>, IDisposable where TComponentData : struct, OEDIPNFGKIO
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class EJEIEJOFOJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private List<(object token, TValue value)> IHMGNIOOIJN;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int EBKBMNDKLEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x1C59E30", Offset = "0x1C58E30", VA = "0x181C59E30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x27D4000", Offset = "0x27D3000", VA = "0x1827D4000")]
		public bool KHDDCDLGOFK(out TValue CKMKMNKGMMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x27D40C0", Offset = "0x27D30C0", VA = "0x1827D40C0")]
		public void KKDPLFKFCJN(object DMHDKAFNNAC, TValue CKMKMNKGMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x27D3F80", Offset = "0x27D2F80", VA = "0x1827D3F80")]
		public bool HBPDDHHFGHN(object DMHDKAFNNAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x27D3ED0", Offset = "0x27D2ED0", VA = "0x1827D3ED0")]
		public int AHDNCPMDOKF(object DMHDKAFNNAC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x27D4170", Offset = "0x27D3170", VA = "0x1827D4170")]
		public EJEIEJOFOJC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly Stack<EJEIEJOFOJC> OKLCGIHFMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private DGDOEFFNHGM<OEFBJNHPFGD, EJEIEJOFOJC> EOEKHJENCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private EntityManager DKCFIIHAPKN;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x31EC1F0", Offset = "0x31EB1F0", VA = "0x1831EC1F0")]
	public JDAFHKMJDAF(EntityManager DKCFIIHAPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x31EBDC0", Offset = "0x31EADC0", VA = "0x1831EBDC0", Slot = "4")]
	public void BHPOAIDJHEK(Entity OIDNDCEGFCN, object DMHDKAFNNAC, TValue CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x31EBFD0", Offset = "0x31EAFD0", VA = "0x1831EBFD0", Slot = "5")]
	public bool OCAHKHCIHHN(Entity OIDNDCEGFCN, object DMHDKAFNNAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x31EBF00", Offset = "0x31EAF00", VA = "0x1831EBF00", Slot = "6")]
	public bool KHDDCDLGOFK(Entity OIDNDCEGFCN, out TValue CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x31EBEE0", Offset = "0x31EAEE0", VA = "0x1831EBEE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x31EBC50", Offset = "0x31EAC50", VA = "0x1831EBC50")]
	private void AFBKDACDJDE(EJEIEJOFOJC BHLJNMJJAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x31EBB80", Offset = "0x31EAB80", VA = "0x1831EBB80")]
	private bool AAGDHBDMJBI(Entity OIDNDCEGFCN, out OEFBJNHPFGD ELGBGLBKDOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x31EC160", Offset = "0x31EB160", VA = "0x1831EC160")]
	private void OLHCPKMFNJD(Entity OIDNDCEGFCN, OEFBJNHPFGD ELGBGLBKDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x31EBCD0", Offset = "0x31EACD0", VA = "0x1831EBCD0")]
	private bool ANBLPDPGGJL(OEFBJNHPFGD ELGBGLBKDOD, out EJEIEJOFOJC BHLJNMJJAHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x31EBCF0", Offset = "0x31EACF0", VA = "0x1831EBCF0")]
	private EJEIEJOFOJC AOKCAKCFJEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface PAMAAJCPGKH<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHPOAIDJHEK(Entity OIDNDCEGFCN, object DMHDKAFNNAC, TValue CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OCAHKHCIHHN(Entity OIDNDCEGFCN, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHDDCDLGOFK(Entity OIDNDCEGFCN, out TValue CKMKMNKGMMC);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface OEDIPNFGKIO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OEFBJNHPFGD NGODFKEHODI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct OEFBJNHPFGD : CEKEPAAIMKF<OEFBJNHPFGD>, CKPCDNGLPGP, IEquatable<OEFBJNHPFGD>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly OEFBJNHPFGD GGJAJAICBCN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	[CreateProperty]
	public int EHPNNEFNFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA79570", Offset = "0xA78570", VA = "0x180A79570", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	[CreateProperty]
	public int AHEIGHJAOII
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C3F0", Offset = "0x1E2B3F0", VA = "0x181E2C3F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x11BC270", Offset = "0x11BB270", VA = "0x1811BC270", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x71D2500", Offset = "0x71D1500", VA = "0x1871D2500", Slot = "8")]
	public bool Equals(OEFBJNHPFGD JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x71D2550", Offset = "0x71D1550", VA = "0x1871D2550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class HBBCMKNDCAD<THasTokensTag> : CODPOJJKDJP, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Dictionary<Entity, OEFBJNHPFGD> EMPJAMOCCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Stack<HashSet<object>> OKLCGIHFMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private DGDOEFFNHGM<OEFBJNHPFGD, HashSet<object>> EOEKHJENCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private EntityManager DKCFIIHAPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private EntityCommandBufferSystem ACFLGOEKGAE;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2CE1760", Offset = "0x2CE0760", VA = "0x182CE1760")]
	public HBBCMKNDCAD(EntityManager DKCFIIHAPKN, EntityCommandBufferSystem ACFLGOEKGAE, FACALIAHOGE PKLDNNBNGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2CDEDA0", Offset = "0x2CDDDA0", VA = "0x182CDEDA0", Slot = "4")]
	public bool BHPOAIDJHEK(Entity OIDNDCEGFCN, object DMHDKAFNNAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0AE0", Offset = "0x2CDFAE0", VA = "0x182CE0AE0", Slot = "5")]
	public bool OCAHKHCIHHN(Entity OIDNDCEGFCN, object DMHDKAFNNAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0550", Offset = "0x2CDF550", VA = "0x182CE0550", Slot = "6")]
	public bool LPIPFLLCJPB(Entity OIDNDCEGFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0670", Offset = "0x2CDF670", VA = "0x182CE0670", Slot = "10")]
	public bool LPIPFLLCJPB(OEFBJNHPFGD ELGBGLBKDOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2CE01F0", Offset = "0x2CDF1F0", VA = "0x182CE01F0", Slot = "7")]
	public IEnumerable<object> KOOGKPCJFPP(Entity OIDNDCEGFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2CE02B0", Offset = "0x2CDF2B0", VA = "0x182CE02B0", Slot = "11")]
	public IEnumerable<object> KOOGKPCJFPP(OEFBJNHPFGD ELGBGLBKDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2CDEAD0", Offset = "0x2CDDAD0", VA = "0x182CDEAD0", Slot = "8")]
	public bool AOMNLCKLMBH(Entity OIDNDCEGFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF510", Offset = "0x2CDE510", VA = "0x182CDF510", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE410", Offset = "0x2CDD410", VA = "0x182CDE410")]
	private void AFBKDACDJDE(HashSet<object> BHLJNMJJAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE020", Offset = "0x2CDD020", VA = "0x182CDE020")]
	private bool AAGDHBDMJBI(Entity OIDNDCEGFCN, out OEFBJNHPFGD ELGBGLBKDOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF9B0", Offset = "0x2CDE9B0", VA = "0x182CDF9B0")]
	private bool KFOOHHCJKKN(Entity OIDNDCEGFCN, out OEFBJNHPFGD ELGBGLBKDOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF480", Offset = "0x2CDE480", VA = "0x182CDF480")]
	private void COLFGNCIHJJ(Entity OIDNDCEGFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2CE1020", Offset = "0x2CE0020", VA = "0x182CE1020")]
	private void OLEPGABPECO(Entity OIDNDCEGFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF850", Offset = "0x2CDE850", VA = "0x182CDF850")]
	private void JPOIGDKHEDK(Entity OIDNDCEGFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2CE1270", Offset = "0x2CE0270", VA = "0x182CE1270")]
	private void OLHCPKMFNJD(Entity OIDNDCEGFCN, OEFBJNHPFGD ELGBGLBKDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0810", Offset = "0x2CDF810", VA = "0x182CE0810")]
	private bool MFHPPEIJIDA(OEFBJNHPFGD ELGBGLBKDOD, out HashSet<object> BHLJNMJJAHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE850", Offset = "0x2CDD850", VA = "0x182CDE850")]
	private HashSet<object> AOKCAKCFJEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class GFDOEFIJIHH
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void AIDEMCOFDKJ(this FACALIAHOGE IHHCPPEACEL, NativeArray<Entity> OBBDNLKJJED, [Optional][CallerFilePath] string NLCPLNFJNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void AIDEMCOFDKJ(this FACALIAHOGE IHHCPPEACEL, string OKONKHNEMOO, NativeArray<Entity> OBBDNLKJJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void AIDEMCOFDKJ(this FACALIAHOGE IHHCPPEACEL, string NLCPLNFJNCG, NativeArray<Entity> OBBDNLKJJED, bool IEEKCBEDONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void HBOCMOOLCCE(this FACALIAHOGE IHHCPPEACEL, NativeArray<Entity> OBBDNLKJJED, EntityManager DKCFIIHAPKN, [Optional][CallerFilePath] string NLCPLNFJNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void HBOCMOOLCCE(this FACALIAHOGE IHHCPPEACEL, string NLCPLNFJNCG, NativeArray<Entity> OBBDNLKJJED, EntityManager DKCFIIHAPKN, bool IEEKCBEDONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void LJOJCFMKCPO(this FACALIAHOGE IHHCPPEACEL, NativeArray<Entity> OBBDNLKJJED, NativeArray<Entity> HENDKFPKLHK, [Optional][CallerFilePath] string NLCPLNFJNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void LJOJCFMKCPO(this FACALIAHOGE IHHCPPEACEL, string NLCPLNFJNCG, NativeArray<Entity> OBBDNLKJJED, NativeArray<Entity> HENDKFPKLHK, bool IEEKCBEDONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2956A60", Offset = "0x2955A60", VA = "0x182956A60")]
	public static void GCEDIIGIGHI<T>(this FACALIAHOGE IHHCPPEACEL, string OKONKHNEMOO, NativeArray<Entity> OBBDNLKJJED, NativeList<T> HCKNMLENIIG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2956AF0", Offset = "0x2955AF0", VA = "0x182956AF0")]
	public static void GCEDIIGIGHI<T>(this FACALIAHOGE IHHCPPEACEL, NativeArray<Entity> OBBDNLKJJED, NativeArray<T> HCKNMLENIIG, [Optional][CallerFilePath] string NLCPLNFJNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2956A20", Offset = "0x2955A20", VA = "0x182956A20")]
	public static void GCEDIIGIGHI<T>(this FACALIAHOGE IHHCPPEACEL, string OKONKHNEMOO, NativeArray<Entity> OBBDNLKJJED, NativeArray<T> HCKNMLENIIG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void GCEDIIGIGHI<T>(this FACALIAHOGE IHHCPPEACEL, string NLCPLNFJNCG, NativeArray<Entity> OBBDNLKJJED, NativeArray<T> HCKNMLENIIG, bool IEEKCBEDONA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2956B70", Offset = "0x2955B70", VA = "0x182956B70")]
	public static void JODHLFOGDML<T>(this FACALIAHOGE IHHCPPEACEL, NativeList<T> HCKNMLENIIG, [Optional][CallerFilePath] string NLCPLNFJNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2956B40", Offset = "0x2955B40", VA = "0x182956B40")]
	public static void JODHLFOGDML<T>(this FACALIAHOGE IHHCPPEACEL, NativeArray<T> HCKNMLENIIG, [Optional][CallerFilePath] string NLCPLNFJNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void JODHLFOGDML<T>(this FACALIAHOGE IHHCPPEACEL, string NLCPLNFJNCG, NativeArray<T> HCKNMLENIIG, bool IEEKCBEDONA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void LIDILIAGPNB(this FACALIAHOGE IHHCPPEACEL, EntityQuery IKPDHHKCFNO, [Optional][CallerFilePath] string NLCPLNFJNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void LIDILIAGPNB(this FACALIAHOGE IHHCPPEACEL, string OKONKHNEMOO, EntityQuery IKPDHHKCFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void LIDILIAGPNB(this FACALIAHOGE IHHCPPEACEL, string NLCPLNFJNCG, EntityQuery IKPDHHKCFNO, bool IEEKCBEDONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x29569F0", Offset = "0x29559F0", VA = "0x1829569F0")]
	public static void GGJPHNHCOKO<T, T2>(this FACALIAHOGE IHHCPPEACEL, string OKONKHNEMOO, EntityQuery IKPDHHKCFNO) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	private static void GGJPHNHCOKO<T, T2>(this FACALIAHOGE IHHCPPEACEL, string NLCPLNFJNCG, EntityQuery IKPDHHKCFNO, bool IEEKCBEDONA) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x29569F0", Offset = "0x29559F0", VA = "0x1829569F0")]
	public static void LMLFEFFIDJO<T>(this FACALIAHOGE IHHCPPEACEL, string OKONKHNEMOO, NativeList<T> OGEGDDKCPPH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void LMLFEFFIDJO<T>(this FACALIAHOGE IHHCPPEACEL, string NLCPLNFJNCG, NativeList<T> OGEGDDKCPPH, bool IEEKCBEDONA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x29569F0", Offset = "0x29559F0", VA = "0x1829569F0")]
	public static void AIBMHGMNGOJ<T>(this FACALIAHOGE IHHCPPEACEL, string OKONKHNEMOO, NativeArray<T> OGEGDDKCPPH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void AIBMHGMNGOJ<T>(this FACALIAHOGE IHHCPPEACEL, string NLCPLNFJNCG, NativeArray<T> OGEGDDKCPPH, bool IEEKCBEDONA) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
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

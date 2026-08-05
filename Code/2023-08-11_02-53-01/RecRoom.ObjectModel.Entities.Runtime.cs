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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E2F760", Offset = "0x6E2DF60", VA = "0x186E2F760")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FCEHOMFODIA
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class IDOFJPFHIIG<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] DCJGCHPJMAI;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C4D0", Offset = "0x2D5ACD0", VA = "0x182D5C4D0")]
	public static void MHBCCMEOPHK<TField>(int AMOEKOMGDLG, string MDOAADHDBMA, BMPCFGMBEIA EOMGPEBEOPL, out NIJBLPDKGGM<TField> OPCEAOKDBMJ) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2D5E2E0", Offset = "0x2D5CAE0", VA = "0x182D5E2E0")]
	public static void OEGCCHALMFA<TField>(int AMOEKOMGDLG, string MDOAADHDBMA, out KNCFGIDDJIE<TField> ELAAPFMOMBJ) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class KGAPOEAMIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FE10", Offset = "0x6E2E610", VA = "0x186E2FE10")]
	public static FieldInfo[] LFBMKICJLEH(Type EIOLDDJPDLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class HMJBEIODLNF<View, Data> : ADGLENNGCHF where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType HNNLLGAFCEB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type FCMLDNAMHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3FA3580", Offset = "0x3FA1D80", VA = "0x183FA3580", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int LGOOLBAFLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A2DBA0", Offset = "0x3A2C3A0", VA = "0x183A2DBA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3A2E9E0", Offset = "0x3A2D1E0", VA = "0x183A2E9E0")]
	public Data OJKIECLGKCN(Entity AJDEFAPHMKF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3A2DB30", Offset = "0x3A2C330", VA = "0x183A2DB30")]
	public Data CCKFDEMLMOG(Entity AJDEFAPHMKF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View GHONLIMLIHJ(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F67130", Offset = "0x1F65930", VA = "0x181F67130", Slot = "14")]
	public override T GHONLIMLIHJ<T>(Entity AJDEFAPHMKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5BD0", Offset = "0x1FA43D0", VA = "0x181FA5BD0")]
	protected HMJBEIODLNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class ADGLENNGCHF : BMPCFGMBEIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle APLOJPKPABL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xBCC320", Offset = "0xBCAB20", VA = "0x180BCC320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type FCMLDNAMHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int LGOOLBAFLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type AHAMFBMPGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1C081A0", Offset = "0x1C069A0", VA = "0x181C081A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int MLKPAFIHKHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E2F100", Offset = "0x6E2D900", VA = "0x186E2F100", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private BLECIIOHDPI[] CJCNNDBNODB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1638200", Offset = "0x1636A00", VA = "0x181638200", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual BLECIIOHDPI[] EFMMGHNDFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E2F040", Offset = "0x6E2D840", VA = "0x186E2F040", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E2EDB0", Offset = "0x6E2D5B0", VA = "0x186E2EDB0")]
	public void BDCEDMLOOPD(EntityManager EADLBIHJKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T GHONLIMLIHJ<T>(Entity AJDEFAPHMKF) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E2EF70", Offset = "0x6E2D770", VA = "0x186E2EF70", Slot = "8")]
	public (uint, uint) HOJAFNDLCOI(Entity AJDEFAPHMKF)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2EED0", Offset = "0x6E2D6D0", VA = "0x186E2EED0", Slot = "9")]
	public bool BDINEGGJLMH(Entity AJDEFAPHMKF, (uint order, uint change) MNJCDKNLLPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	protected ADGLENNGCHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BECDCKEMJCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int CNJDAMBDKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private int JMKNAPEFDDB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DDDGGALLAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB1A680", Offset = "0xB18E80", VA = "0x180B1A680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1AB09C0", Offset = "0x1AAF1C0", VA = "0x181AB09C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x24EBED0", Offset = "0x24EA6D0", VA = "0x1824EBED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NLOOCBKLNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB1A680", Offset = "0xB18E80", VA = "0x180B1A680")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB1A5C0", Offset = "0xB18DC0", VA = "0x180B1A5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int HOBKBMKCCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E2F180", Offset = "0x6E2D980", VA = "0x186E2F180")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E2F170", Offset = "0x6E2D970", VA = "0x186E2F170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xAB38B0", Offset = "0xAB20B0", VA = "0x180AB38B0")]
	private BECDCKEMJCA(int CNJDAMBDKMB, int JMKNAPEFDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30CC740", Offset = "0x30CAF40", VA = "0x1830CC740")]
	public static BECDCKEMJCA GIOEMLCOALK(int CNJDAMBDKMB, int JMKNAPEFDDB)
	{
		return default(BECDCKEMJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F190", Offset = "0x6E2D990", VA = "0x186E2F190")]
	public static BECDCKEMJCA POFCICANMNH(int HKIGKJAPFHM, int IODGGLFACBF)
	{
		return default(BECDCKEMJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F1A0", Offset = "0x6E2D9A0", VA = "0x186E2F1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BJAEAAEMEAE : DBJBEBMCMPD<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x665AA60", Offset = "0x6659260", VA = "0x18665AA60")]
	public float PBIFCHCLFAG(in float3 MENBIMCLIOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x665AA60", Offset = "0x6659260", VA = "0x18665AA60", Slot = "4")]
	private float DCFNFCHONLK(in float3 MENBIMCLIOI)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct INJMEHNEANJ : DBJBEBMCMPD<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x665F960", Offset = "0x665E160", VA = "0x18665F960")]
	public float PBIFCHCLFAG(in float3 MENBIMCLIOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x665F960", Offset = "0x665E160", VA = "0x18665F960", Slot = "4")]
	private float DCFNFCHONLK(in float3 MENBIMCLIOI)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IHHKNOHAGDF : DBJBEBMCMPD<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA43FC0", Offset = "0xA427C0", VA = "0x180A43FC0")]
	public float PBIFCHCLFAG(in float3 MENBIMCLIOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA43FC0", Offset = "0xA427C0", VA = "0x180A43FC0", Slot = "4")]
	private float DCFNFCHONLK(in float3 MENBIMCLIOI)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct FOCHFIEMPHL : DBJBEBMCMPD<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xB74FC0", Offset = "0xB737C0", VA = "0x180B74FC0")]
	public int PBIFCHCLFAG(in int3 MENBIMCLIOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xB74FC0", Offset = "0xB737C0", VA = "0x180B74FC0", Slot = "4")]
	private int MMCLLMIOJMA(in int3 MENBIMCLIOI)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CNHMFHMMGHH : DBJBEBMCMPD<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6367510", Offset = "0x6365D10", VA = "0x186367510")]
	public int PBIFCHCLFAG(in int3 MENBIMCLIOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6367510", Offset = "0x6365D10", VA = "0x186367510", Slot = "4")]
	private int MMCLLMIOJMA(in int3 MENBIMCLIOI)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HOJFPIMIJLN : DBJBEBMCMPD<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xCC8A60", Offset = "0xCC7260", VA = "0x180CC8A60")]
	public int PBIFCHCLFAG(in int3 MENBIMCLIOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xCC8A60", Offset = "0xCC7260", VA = "0x180CC8A60", Slot = "4")]
	private int MMCLLMIOJMA(in int3 MENBIMCLIOI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JIDGKENIAEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly byte[] CEEEFJEILLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MemoryStream PCGLKMCPDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CodedOutputStream PPIBPAJLCNE;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FC60", Offset = "0x6E2E460", VA = "0x186E2FC60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
internal struct MIBNAECFONM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public ComponentDataFromEntity AJOAKIECNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[ReadOnly]
	public NativeArray<Entity> FCFOPHNGLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeList<Entity> HOPGCBKGIDN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E302D0", Offset = "0x6E2EAD0", VA = "0x186E302D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EPJILCFBEJF
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F5D0", Offset = "0x6E2DDD0", VA = "0x186E2F5D0")]
	[PNKOKLHJFMG]
	public static JobHandle HHGBKCONGJA(this EntityCommandBufferSystem KFAEBKFHHLM, NativeList<Entity> KFLBCCAJFMN, [Optional] JobHandle BFAAEILACKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F4C0", Offset = "0x6E2DCC0", VA = "0x186E2F4C0")]
	[PNKOKLHJFMG]
	public static JobHandle HHGBKCONGJA(this EntityCommandBufferSystem KFAEBKFHHLM, NativeArrayAsync<Entity> KFLBCCAJFMN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ACCGCPAMCPM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x11A4920", Offset = "0x11A3120", VA = "0x1811A4920")]
	public static void IHHMPAJGIDK<T>(this EntityCommandBufferSystem KFAEBKFHHLM, EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x11A4990", Offset = "0x11A3190", VA = "0x1811A4990")]
	[PNKOKLHJFMG]
	public static JobHandle LOGOHMOICME<T>(this EntityCommandBufferSystem KFAEBKFHHLM, NativeListAsync<Entity> KFLBCCAJFMN, [Optional] JobHandle BFAAEILACKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x11A4A50", Offset = "0x11A3250", VA = "0x1811A4A50")]
	[PNKOKLHJFMG]
	public static JobHandle LOGOHMOICME<T>(this EntityCommandBufferSystem KFAEBKFHHLM, NativeArrayAsync<Entity> KFLBCCAJFMN, [Optional] JobHandle BFAAEILACKK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AAGAEMKGOFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct HFEFBBAJNLP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public NativeArray<Entity> NLJHBEHICHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NativeArray<T> LABDDAGPCHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct CHDNNMDOFHM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public NativeList<Entity> NLJHBEHICHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NativeArray<T> LABDDAGPCHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct FICADFLEDJF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NativeArrayAsync<Entity> NLJHBEHICHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NativeArrayAsync<T> LABDDAGPCHI;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1F62CF0", Offset = "0x1F614F0", VA = "0x181F62CF0")]
		public NativeListAsync<Entity> EDEIOAAABHB<TPredicate>() where TPredicate : struct, OKAJMKCABLI<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x119D070", Offset = "0x119B870", VA = "0x18119D070")]
	public static FICADFLEDJF<T> DDPDKHJOCGP<T>(this NativeArrayAsync<Entity> FCFOPHNGLIA, NativeArrayAsync<T> NCMCPNPEBHH, Allocator HMGEFCKKBID = Allocator.TempJob) where T : struct
	{
		return default(FICADFLEDJF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MAHNBMLCOML : EFDDNEKNAJL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Type HAKOEKINHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Type OJPNFCHBMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FF60", Offset = "0x6E2E760", VA = "0x186E2FF60")]
	public MAHNBMLCOML(Type LFLJMBLIFLD, Type AJOAKIECNFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class CPLPHIMIGDL
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class AMEIJEDFFCM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1DF24C0", Offset = "0x1DF0CC0", VA = "0x181DF24C0")]
	public static NativeList<Entity> HGFGAGIAJPN<T>(this NativeArray<Entity> FCFOPHNGLIA, EntityManager EADLBIHJKBG, Allocator HMGEFCKKBID = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct NEMGBAGEKOF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly MemoryStream PCGLKMCPDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CodedInputStream ILBFJDPCPEA;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E30440", Offset = "0x6E2EC40", VA = "0x186E30440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EHPGLLENJHJ
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct DJCBMEDHLGB : DBJBEBMCMPD<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> CBADKBDCCJN;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6E2F330", Offset = "0x6E2DB30", VA = "0x186E2F330")]
		[BurstCompatible]
		public Entity PBIFCHCLFAG(in Entity MENBIMCLIOI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6E2F330", Offset = "0x6E2DB30", VA = "0x186E2F330", Slot = "4")]
		private Entity DBEGGIBLFDP(in Entity MENBIMCLIOI)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct AMKEDPBIAAL<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ANOKPFHNGFA : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AMKEDPBIAAL<Protobuf> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA64970", Offset = "0xA63170", VA = "0x180A64970", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2704750", Offset = "0x2702F50", VA = "0x182704750", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x19018C0", Offset = "0x19000C0", VA = "0x1819018C0")]
		[DebuggerHidden]
		public ANOKPFHNGFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2704550", Offset = "0x2702D50", VA = "0x182704550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2704710", Offset = "0x2702F10", VA = "0x182704710", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Action<Protobuf> ICLIAAJPFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MemoryStream PCGLKMCPDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CodedInputStream ILBFJDPCPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Protobuf MCEDLDGOIFG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int EGAMNLBINDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD10", Offset = "0x7DE510", VA = "0x1807DFD10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x27010D0", Offset = "0x26FF8D0", VA = "0x1827010D0")]
	private AMKEDPBIAAL(byte[] CEEEFJEILLD, Action<Protobuf> ICLIAAJPFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x21B8570", Offset = "0x21B6D70", VA = "0x1821B8570")]
	public static AMKEDPBIAAL<Protobuf> OIAKNFDBOOD<Data>(ReadOnlySpan<byte> BLAINNBNMDK, ReadOnlySpan<Data> BODGCAEFMPH, Action<Protobuf> ICLIAAJPFGM)
	{
		return default(AMKEDPBIAAL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2700F40", Offset = "0x26FF740", VA = "0x182700F40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2700F80", Offset = "0x26FF780", VA = "0x182700F80", Slot = "4")]
	[IteratorStateMachine(typeof(AMKEDPBIAAL<>.ANOKPFHNGFA))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2701080", Offset = "0x26FF880", VA = "0x182701080", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class GJJADNOGMIL : HEGFKOOIJBF
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FB80", Offset = "0x6E2E380", VA = "0x186E2FB80", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase CMFPJFIFJLA();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FAE0", Offset = "0x6E2E2E0", VA = "0x186E2FAE0")]
	protected ComponentSystemBase HKEIMHBHNEL(params ComponentSystemBase[] HMNAFOKFDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6E20", Offset = "0x1CA5620", VA = "0x181CA6E20")]
	protected ComponentSystemBase HKEIMHBHNEL<T>(params ComponentSystemBase[] HMNAFOKFDKP) where T : HEGFKOOIJBF, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6EC0", Offset = "0x1CA56C0", VA = "0x181CA6EC0")]
	protected ComponentSystemBase NECAPIIBMKA<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6EC0", Offset = "0x1CA56C0", VA = "0x181CA6EC0")]
	protected ComponentSystemBase OFHHEEKJKCH<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FB30", Offset = "0x6E2E330", VA = "0x186E2FB30")]
	protected ComponentSystemBase OCOJFECCANL(params SystemHandleUntyped[] HMNAFOKFDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6F00", Offset = "0x1CA5700", VA = "0x181CA6F00")]
	protected ComponentSystemBase OCOJFECCANL<T>(params SystemHandleUntyped[] HMNAFOKFDKP) where T : HEGFKOOIJBF, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6DD0", Offset = "0x1CA55D0", VA = "0x181CA6DD0")]
	protected SystemHandleUntyped BJMFJLOHBIJ<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FBD0", Offset = "0x6E2E3D0", VA = "0x186E2FBD0")]
	protected GJJADNOGMIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class HOHNHLNCBDD
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2A21260", Offset = "0x2A1FA60", VA = "0x182A21260")]
	public static NativeList<T> HICOPAFHMMG<T>(NativeList<T> NCMCPNPEBHH, Allocator HMGEFCKKBID) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class GEJBEMMJAFD
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct LIGFOHGNGAK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : DBJBEBMCMPD<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> LABDDAGPCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeList<TFrom> DAGBHEDMDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeParallelHashSet<TTo> OJICEFMMHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap COPPLLLOGLG;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct BPAELNEFJJA<T, TPredicate> : IJob where T : struct where TPredicate : struct, OKAJMKCABLI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<T> LABDDAGPCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> NLJHBEHICHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeList<Entity> LNMIFLKDCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public TPredicate COPPLLLOGLG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27210D0", Offset = "0x271F8D0", VA = "0x1827210D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct DMHDHFONOBI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DBJBEBMCMPD<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<TFrom> MHLKNLBLDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[WriteOnly]
	public NativeList<TTo> MLPGDAIMBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public TMap COPPLLLOGLG;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class JKLDOGFDCML
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct LADOMBMLENL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly NativeArray<T>.ReadOnly DLLMPOAIBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int ODFELLLMBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int OLADFOBBKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private T PILMLOMABIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private T OBDIMDDAHMH;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public BECDCKEMJCA GPPGFEPIJLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2067410", Offset = "0x2065C10", VA = "0x182067410")]
			get
			{
				return default(BECDCKEMJCA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T NDBCNNOOLKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1AB0C20", Offset = "0x1AAF420", VA = "0x181AB0C20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (T, BECDCKEMJCA) PDEEINOIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x24CD5B0", Offset = "0x24CBDB0", VA = "0x1824CD5B0")]
			get
			{
				return default((T, BECDCKEMJCA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x24CDA50", Offset = "0x24CC250", VA = "0x1824CDA50")]
		public LADOMBMLENL(NativeArray<T> DLLMPOAIBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0770", Offset = "0x1AAEF70", VA = "0x181AB0770")]
		public LADOMBMLENL<T> GAACJCPNEFN()
		{
			return default(LADOMBMLENL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x24CD680", Offset = "0x24CBE80", VA = "0x1824CD680")]
		public bool KHFLJGAOMBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2D65170", Offset = "0x2D63970", VA = "0x182D65170")]
		public LFMNBPNHAFM<T, TComparer> DCKBOKOEJMH<TComparer>([Optional] TComparer LJPJIHPPFEM) where TComparer : struct, IEqualityComparer<T>
		{
			return default(LFMNBPNHAFM<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct LFMNBPNHAFM<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly NativeArray<T>.ReadOnly DLLMPOAIBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int ODFELLLMBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int OLADFOBBKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T PILMLOMABIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private T OBDIMDDAHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TComparer LJPJIHPPFEM;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public BECDCKEMJCA GPPGFEPIJLF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2067410", Offset = "0x2065C10", VA = "0x182067410")]
			get
			{
				return default(BECDCKEMJCA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public T NDBCNNOOLKG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1AB0C20", Offset = "0x1AAF420", VA = "0x181AB0C20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public (T value, BECDCKEMJCA range) PDEEINOIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2067300", Offset = "0x2065B00", VA = "0x182067300")]
			get
			{
				return default((T, BECDCKEMJCA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2067680", Offset = "0x2065E80", VA = "0x182067680")]
		public LFMNBPNHAFM(NativeArray<T>.ReadOnly DLLMPOAIBGN, TComparer LJPJIHPPFEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x20673D0", Offset = "0x2065BD0", VA = "0x1820673D0")]
		public LFMNBPNHAFM<T, TComparer> GAACJCPNEFN()
		{
			return default(LFMNBPNHAFM<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2067420", Offset = "0x2065C20", VA = "0x182067420")]
		public bool KHFLJGAOMBC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x26D3B00", Offset = "0x26D2300", VA = "0x1826D3B00")]
	public static LADOMBMLENL<T> HKEIMHBHNEL<T>(this NativeArray<T> DLLMPOAIBGN) where T : struct
	{
		return default(LADOMBMLENL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DBJBEBMCMPD<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo PBIFCHCLFAG(in TFrom MENBIMCLIOI);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class NLFOEPEEEPJ
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class EMNODCMDNKK
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PNIFHJOJPGK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public PNIFHJOJPGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class EPPGKIKJGOE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		public EPPGKIKJGOE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<Func<JobHandle, JobHandle>> BEJNPEONNON;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F440", Offset = "0x6E2DC40", VA = "0x186E2F440")]
	public EMNODCMDNKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class KLNPHEFOBHB
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class BBADPFDDMLN : EntityCommandBufferSystem, NLJHLDOEDAL
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
	protected BBADPFDDMLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class DDJKFCJGKKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3BE1620", Offset = "0x3BDFE20", VA = "0x183BE1620")]
	[PNKOKLHJFMG]
	public static JobHandle GICFBOFIACA<T>(this EntityCommandBufferSystem KFAEBKFHHLM, NativeArray<Entity> KFLBCCAJFMN, NativeArray<T> NFBDMLCENEN, JobHandle BFAAEILACKK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct IEEMFFNCHHK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<T> LABDDAGPCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<T> DAGBHEDMDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<T> OJICEFMMHOH;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x19D4F40", Offset = "0x19D3740", VA = "0x1819D4F40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct FGBEADHBPKM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> KFLBCCAJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EntityCommandBuffer PFGPHODPKBL;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F780", Offset = "0x6E2DF80", VA = "0x186E2F780", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class HKPANKCAJKG
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2A1D600", Offset = "0x2A1BE00", VA = "0x182A1D600")]
	public static NativeArray<T> IDFPCHNHNOI<T>(this NativeList<Entity> NCMCPNPEBHH, EntityManager EADLBIHJKBG, Allocator HMGEFCKKBID = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2A1D260", Offset = "0x2A1BA60", VA = "0x182A1D260")]
	public static NativeArray<T> IDFPCHNHNOI<T>(this NativeArray<Entity> NCMCPNPEBHH, EntityManager EADLBIHJKBG, Allocator HMGEFCKKBID = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface OMJECFBIAPA
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class CILPEACBACC
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal struct BONBCAFLIIL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> KFLBCCAJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public T MENBIMCLIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public EntityCommandBuffer PFGPHODPKBL;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2721030", Offset = "0x271F830", VA = "0x182721030", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class IKCCICBAEHA
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x110D1E0", Offset = "0x110B9E0", VA = "0x18110D1E0")]
	[PNKOKLHJFMG]
	public static JobHandle MHHPBEKNOHO<T>(this EntityCommandBufferSystem KFAEBKFHHLM, EntityCommandBuffer PFGPHODPKBL, EntityQuery EGFJCKOAGFH, T MENBIMCLIOI) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class FMLLJCMLNJP<Data> : MGDMPJGJKNM where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public virtual Data GDCPNJEFLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1EA53F0", Offset = "0x1EA3BF0", VA = "0x181EA53F0", Slot = "8")]
	protected virtual bool GJCFBLICDIP(ReadOnlySpan<Data> BODGCAEFMPH, NGDOIACAINC IALCMDCBOGJ, out ReadOnlySpan<byte> BLAINNBNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8A3C30", Offset = "0x8A2430", VA = "0x1808A3C30", Slot = "9")]
	protected virtual bool NHPFIHINGCM(int MNJCDKNLLPF, Span<Data> BODGCAEFMPH, in ReadOnlySpan<byte> BLAINNBNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2040110", Offset = "0x203E910", VA = "0x182040110", Slot = "5")]
	internal sealed override bool GJCFBLICDIP(ref Unity.Entities.Chunk OPMNIAACDHI, int HLNBNEPDGFF, NGDOIACAINC IALCMDCBOGJ, out ReadOnlySpan<byte> BLAINNBNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x20404C0", Offset = "0x203ECC0", VA = "0x1820404C0", Slot = "6")]
	internal sealed override bool NHPFIHINGCM(int MNJCDKNLLPF, ref Unity.Entities.Chunk OPMNIAACDHI, int HLNBNEPDGFF, in ReadOnlySpan<byte> BLAINNBNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F62DF0", Offset = "0x1F615F0", VA = "0x181F62DF0")]
	protected CLBPDAMEOEO<Protobuf> HPNOIPJOILB<Protobuf>(ReadOnlySpan<Data> BODGCAEFMPH) where Protobuf : IMessage, new()
	{
		return default(CLBPDAMEOEO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1F62D60", Offset = "0x1F61560", VA = "0x181F62D60")]
	protected AMKEDPBIAAL<Protobuf> GECJBCILEBD<Protobuf>(ReadOnlySpan<byte> BLAINNBNMDK, ReadOnlySpan<Data> BODGCAEFMPH, Action<Protobuf> ICLIAAJPFGM) where Protobuf : IMessage, new()
	{
		return default(AMKEDPBIAAL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5BD0", Offset = "0x1FA43D0", VA = "0x181FA5BD0")]
	protected FMLLJCMLNJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class MGDMPJGJKNM
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected abstract int IHOKMDEGNLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FFB0", Offset = "0x6E2E7B0", VA = "0x186E2FFB0", Slot = "5")]
	internal virtual bool GJCFBLICDIP(ref Unity.Entities.Chunk OPMNIAACDHI, int HLNBNEPDGFF, NGDOIACAINC IALCMDCBOGJ, out ReadOnlySpan<byte> BLAINNBNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8A3C30", Offset = "0x8A2430", VA = "0x1808A3C30", Slot = "6")]
	internal virtual bool NHPFIHINGCM(int MNJCDKNLLPF, ref Unity.Entities.Chunk OPMNIAACDHI, int HLNBNEPDGFF, in ReadOnlySpan<byte> BLAINNBNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	protected MGDMPJGJKNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GKJLEIDHFHI
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct EMNHLAKDHDN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct NHPJCIDMJMJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal EMNHLAKDHDN<TFrom> GJPBCFJDGCH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> EMGBKAPJLEO;
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct JLENAJIBNOO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public struct CJNBDPBNDFL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal JLENAJIBNOO<TFrom> GJPBCFJDGCH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> EMGBKAPJLEO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct AKIBHLGFCEA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public struct PPGHMIFDMAN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal AKIBHLGFCEA<TFrom> GJPBCFJDGCH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> EMGBKAPJLEO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct DBCPEHEILMB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public struct IKKHLFDIHOE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal DBCPEHEILMB<TFrom> GJPBCFJDGCH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> EMGBKAPJLEO;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct CIPPBNPNDHL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	public ComponentDataFromEntity PNNIGCJHNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	public NativeArray<Entity> LABDDAGPCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[WriteOnly]
	public NativeArray<byte> MLPGDAIMBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int HJLDFBDBBHM;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F230", Offset = "0x6E2DA30", VA = "0x186E2F230", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[BurstCompile]
internal struct IMKOJPLKKPE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AJOAKIECNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[ReadOnly]
	public NativeArray<Entity> FCFOPHNGLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<bool> ODKKNLBGAKL;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal struct MLIFPPDJPOA<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[ReadOnly]
	public NativeArray<Entity> KFLBCCAJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[ReadOnly]
	public NativeArray<T> ONNFNOJDECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public EntityCommandBuffer PFGPHODPKBL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class DCPJFCCKMHK
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3BE1390", Offset = "0x3BDFB90", VA = "0x183BE1390")]
	public static NativeListAsync<Entity> GAKMOMKNOEF<T, TPredicate>(this NativeArrayAsync<T> NCMCPNPEBHH, NativeArrayAsync<Entity> FCFOPHNGLIA, Allocator HMGEFCKKBID = Allocator.TempJob) where T : struct where TPredicate : struct, OKAJMKCABLI<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3BE1450", Offset = "0x3BDFC50", VA = "0x183BE1450")]
	private static NativeListAsync<Entity> NAJLBFAJBPF<T, TPredicate>(NativeArrayAsync<T> EDONNJGHANC, NativeArrayAsync<Entity> FCFOPHNGLIA, int AKLMFDJHPFM, Allocator HMGEFCKKBID) where T : struct where TPredicate : struct, OKAJMKCABLI<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class KKEFJLDCJND
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x9A5670", Offset = "0x9A3E70", VA = "0x1809A5670")]
	[PNKOKLHJFMG]
	public static JobHandle MHEOHKKMMEJ<T>(this EntityCommandBufferSystem KFAEBKFHHLM, NativeArray<Entity> KFLBCCAJFMN, T MENBIMCLIOI, [Optional] JobHandle BFAAEILACKK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x9A55A0", Offset = "0x9A3DA0", VA = "0x1809A55A0")]
	[PNKOKLHJFMG]
	public static JobHandle MHEOHKKMMEJ<T>(this EntityCommandBufferSystem KFAEBKFHHLM, EntityCommandBuffer PFGPHODPKBL, NativeArray<Entity> KFLBCCAJFMN, T MENBIMCLIOI, [Optional] JobHandle BFAAEILACKK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class NGDOIACAINC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> NACBHKLHOEF;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x20D80B0", Offset = "0x20D68B0", VA = "0x1820D80B0")]
	public NGDOIACAINC(NativeArray<EntityRemapUtility.EntityRemapInfo> NACBHKLHOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6E30480", Offset = "0x6E2EC80", VA = "0x186E30480")]
	public Entity CMCJNMHAFMD(Entity ODHKMJMLAIP)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class AGNDCIIBPLE
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1DF08F0", Offset = "0x1DEF0F0", VA = "0x181DF08F0")]
	public static NativeList<T> HICOPAFHMMG<T>(this NativeList<T> NCMCPNPEBHH, Allocator HMGEFCKKBID = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0970", Offset = "0x1DEF170", VA = "0x181DF0970")]
	public static NativeList<T> HICOPAFHMMG<T>(this NativeArray<T> NCMCPNPEBHH, Allocator HMGEFCKKBID = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class GBJOIIPGJML
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct CMKBOAHDDAH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> LABDDAGPCHI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct GMNECIJBGME<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<T> LABDDAGPCHI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct NEEMMICDGGJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<T> LABDDAGPCHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct JBCNEAGKENM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeListAsync<T> LABDDAGPCHI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
internal struct OPNJOPDOLEN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DBJBEBMCMPD<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeArray<TFrom> LABDDAGPCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[WriteOnly]
	public NativeArray<TTo> MLPGDAIMBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TMap COPPLLLOGLG;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface OKAJMKCABLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EDEIOAAABHB(T MENBIMCLIOI);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
internal struct JJJBAIAKIBH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	public NativeArray<Entity> KFLBCCAJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public EntityCommandBuffer PFGPHODPKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public ComponentTypes KIKBKFAAADF;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FD80", Offset = "0x6E2E580", VA = "0x186E2FD80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[BurstCompile]
internal struct KNKOPPPGFII<T, TPredicate> : IJob where T : struct where TPredicate : struct, OKAJMKCABLI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	public NativeArray<T> LABDDAGPCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<T> DAGBHEDMDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public TPredicate COPPLLLOGLG;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HEGFKOOIJBF : IBBLNIHHOKF
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FC30", Offset = "0x6E2E430", VA = "0x186E2FC30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FBD0", Offset = "0x6E2E3D0", VA = "0x186E2FBD0")]
	public HEGFKOOIJBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[BurstCompile]
internal struct OBJHAKLHOPA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AJOAKIECNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	public NativeArray<Entity> FCFOPHNGLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<bool> ODKKNLBGAKL;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x21F0270", Offset = "0x21EEA70", VA = "0x1821F0270", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct KHHODJNHCOD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<Entity> KFLBCCAJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	public NativeArray<T> NFBDMLCENEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public EntityCommandBuffer PFGPHODPKBL;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x227EA40", Offset = "0x227D240", VA = "0x18227EA40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class EHOPIGAODDG
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F340", Offset = "0x6E2DB40", VA = "0x186E2F340")]
	public static ulong LLJJICLMLPK(Type EIOLDDJPDLH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F3D0", Offset = "0x6E2DBD0", VA = "0x186E2F3D0")]
	public static ulong LLJJICLMLPK(string NHMDFBJECFE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class IIOLMGNHMOA : EFDDNEKNAJL
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Type OJPNFCHBMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2FDD840", Offset = "0x2FDC040", VA = "0x182FDD840")]
	public IIOLMGNHMOA(Type AJOAKIECNFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[BurstCompile]
internal struct OGEPAOOLDDL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public ComponentDataFromEntity AJOAKIECNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	public NativeArray<Entity> FCFOPHNGLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<Entity> HOPGCBKGIDN;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6E30590", Offset = "0x6E2ED90", VA = "0x186E30590", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public abstract class NHLEGKPBPCC : SystemBase, NLJHLDOEDAL
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6E304B0", Offset = "0x6E2ECB0", VA = "0x186E304B0")]
	public ComponentDataFromEntity NMMOFKIBMAK(int KFGBCCEFCMB, bool JDJJPAIGOMA = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E30490", Offset = "0x6E2EC90", VA = "0x186E30490")]
	public EntityExistenceLookupByEntity EMPAKFFCOBK()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E30580", Offset = "0x6E2ED80", VA = "0x186E30580", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x97A870", Offset = "0x979070", VA = "0x18097A870")]
	protected NHLEGKPBPCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class JKEMFGGLHGI : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FDE0", Offset = "0x6E2E5E0", VA = "0x186E2FDE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x97A870", Offset = "0x979070", VA = "0x18097A870")]
	protected JKEMFGGLHGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class DBNEMHFPNAK
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct CLBPDAMEOEO<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly byte[] CEEEFJEILLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Protobuf MCEDLDGOIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly MemoryStream PCGLKMCPDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly CodedOutputStream PPIBPAJLCNE;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x243DCD0", Offset = "0x243C4D0", VA = "0x18243DCD0")]
	private CLBPDAMEOEO(byte[] CEEEFJEILLD, in Protobuf MCEDLDGOIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B310", Offset = "0x1F59B10", VA = "0x181F5B310")]
	public static CLBPDAMEOEO<Protobuf> OIAKNFDBOOD<T>(ReadOnlySpan<T> BODGCAEFMPH)
	{
		return default(CLBPDAMEOEO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x243DAF0", Offset = "0x243C2F0", VA = "0x18243DAF0")]
	public void CDEGAJPHIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x243DC40", Offset = "0x243C440", VA = "0x18243DC40")]
	public ByteString OHMEEAJBIJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x243DB20", Offset = "0x243C320", VA = "0x18243DB20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface NLJHLDOEDAL
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public abstract class IBBLNIHHOKF : ComponentSystemGroup, NLJHLDOEDAL
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FBD0", Offset = "0x6E2E3D0", VA = "0x186E2FBD0")]
	protected IBBLNIHHOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class BPOONGLOPPI
{
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[BurstCompile]
internal struct BCLIBNJLHCC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LELDKBFEBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public NativeArray<Entity> LABDDAGPCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[WriteOnly]
	public NativeList<T> DAGBHEDMDAE;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[Flags]
public enum IBOHJLEOMFL
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
public class PJEHGGACMLC : EFDDNEKNAJL
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x97A870", Offset = "0x979070", VA = "0x18097A870")]
	public PJEHGGACMLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class CJBCBBKIHHA
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public readonly struct DOLEFMPILOI<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly NativeArray<TSrc> DLLMPOAIBGN;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2089BA0", Offset = "0x20883A0", VA = "0x182089BA0")]
		public DOLEFMPILOI(NativeArray<TSrc> DLLMPOAIBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		public HEOPHAPALFL<TSrc, TValue> LLJBLPBNDNB<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(HEOPHAPALFL<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct HEOPHAPALFL<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly NativeArray<TSrc> DLLMPOAIBGN;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2089BA0", Offset = "0x20883A0", VA = "0x182089BA0")]
		public HEOPHAPALFL(NativeArray<TSrc> DLLMPOAIBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		public BDAGDJMLPDJ<TSrc, TValue, TSelector> EOGNMOLMFAG<TSelector>() where TSelector : struct, DBJBEBMCMPD<TSrc, TValue>
		{
			return default(BDAGDJMLPDJ<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct BDAGDJMLPDJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DBJBEBMCMPD<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly NativeArray<TSrc> DLLMPOAIBGN;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2089BA0", Offset = "0x20883A0", VA = "0x182089BA0")]
		public BDAGDJMLPDJ(NativeArray<TSrc> DLLMPOAIBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x21872B0", Offset = "0x2185AB0", VA = "0x1821872B0")]
		public FFKMBAGDMOC<TSrc, TValue, TSelector> HKEIMHBHNEL()
		{
			return default(FFKMBAGDMOC<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct GKKAJLNGIGP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, DBJBEBMCMPD<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly NativeArray<TSrc> DLLMPOAIBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TSelector PDGKFCFIMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int AMOEKOMGDLG;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TValue PDEEINOIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x208A190", Offset = "0x2088990", VA = "0x18208A190")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int JNDMMPHMODJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x918E20", Offset = "0x917620", VA = "0x180918E20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int EGAMNLBINDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1A82220", Offset = "0x1A80A20", VA = "0x181A82220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x208A330", Offset = "0x2088B30", VA = "0x18208A330")]
		public GKKAJLNGIGP(NativeArray<TSrc> DLLMPOAIBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x208A200", Offset = "0x2088A00", VA = "0x18208A200")]
		public bool KHFLJGAOMBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x208A210", Offset = "0x2088A10", VA = "0x18208A210")]
		private TSrc PGCPIIFHDDI(int NLNOELCPLOI)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public struct FFKMBAGDMOC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DBJBEBMCMPD<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private GKKAJLNGIGP<TSrc, TValue, TSelector> EAIMLCNINDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TValue PILMLOMABIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int ODFELLLMBAO;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public BECDCKEMJCA GPPGFEPIJLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x348F860", Offset = "0x348E060", VA = "0x18348F860")]
			get
			{
				return default(BECDCKEMJCA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TValue NDBCNNOOLKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x90BAA0", Offset = "0x90A2A0", VA = "0x18090BAA0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (TValue value, BECDCKEMJCA range) PDEEINOIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x348F790", Offset = "0x348DF90", VA = "0x18348F790")]
			get
			{
				return default((TValue, BECDCKEMJCA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x348F9D0", Offset = "0x348E1D0", VA = "0x18348F9D0")]
		public FFKMBAGDMOC(NativeArray<TSrc> DLLMPOAIBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0710", Offset = "0x1AAEF10", VA = "0x181AB0710")]
		public FFKMBAGDMOC<TSrc, TValue, TSelector> GAACJCPNEFN()
		{
			return default(FFKMBAGDMOC<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x348F8A0", Offset = "0x348E0A0", VA = "0x18348F8A0")]
		public bool KHFLJGAOMBC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2D8EA40", Offset = "0x2D8D240", VA = "0x182D8EA40")]
	public static DOLEFMPILOI<T> NIBHNLBEAKN<T>(this NativeList<T> DFMKDLJIHMN) where T : struct
	{
		return default(DOLEFMPILOI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
	public static DOLEFMPILOI<T> NIBHNLBEAKN<T>(this NativeArray<T> DLLMPOAIBGN) where T : struct
	{
		return default(DOLEFMPILOI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class CAHLHJGPDKA
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct LMHPKHBLJDF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct CKFFLPJJGKJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public LMHPKHBLJDF<TFrom> EMGBKAPJLEO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NativeArray<TFrom> LABDDAGPCHI;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct CEFMBAJJOOP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public struct NOOLAKEFDPN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public CEFMBAJJOOP<TFrom> EMGBKAPJLEO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeArrayAsync<TFrom> LABDDAGPCHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct BHDKFLBJLIH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public struct ANHDECHHKEO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public BHDKFLBJLIH<TFrom> EMGBKAPJLEO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Allocator HMGEFCKKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NativeListAsync<TFrom> LABDDAGPCHI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[BurstCompile]
internal struct GDBBOMHHMMJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	public NativeArray<Entity> KFLBCCAJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public EntityCommandBuffer PFGPHODPKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public ComponentType JHKLCDEPMAD;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FAB0", Offset = "0x6E2E2B0", VA = "0x186E2FAB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class OKPBIEPJMCA
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2BFA5C0", Offset = "0x2BF8DC0", VA = "0x182BFA5C0")]
	public static bool MNDCAEIHDDB<T>(this NativeArray<Entity> FCFOPHNGLIA, EntityManager EADLBIHJKBG, Allocator HMGEFCKKBID = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class IEHEHGIGCHE
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class OMKCFODADCJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class MHPBBHKNDCB
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public delegate void LOJNBHLJJDP<From, To>(From EMGBKAPJLEO, ref To KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ);

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private class JBIMOFCFBPM<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static LOJNBHLJJDP<From, To> MGPDOBLDCGO;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public JBIMOFCFBPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FFD0", Offset = "0x6E2E7D0", VA = "0x186E2FFD0")]
	static MHPBBHKNDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2B6FE50", Offset = "0x2B6E650", VA = "0x182B6FE50")]
	public static void BBMCLAMEOFF<T>(LOJNBHLJJDP<T, T> GHMMJBFHEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F980", Offset = "0x2B6E180", VA = "0x182B6F980")]
	public static void BBMCLAMEOFF<From, To>(LOJNBHLJJDP<From, To> GHMMJBFHEGM, LOJNBHLJJDP<To, From> MFAKDBOCOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2B6FA10", Offset = "0x2B6E210", VA = "0x182B6FA10")]
	public static void BBMCLAMEOFF<From, To>(LOJNBHLJJDP<From, To> MGPDOBLDCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1D7AFE0", Offset = "0x1D797E0", VA = "0x181D7AFE0")]
	public static LOJNBHLJJDP<From, To> MCLGCFBMMFE<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2B73830", Offset = "0x2B72030", VA = "0x182B73830")]
	public static void GCKJENMEFPK<From, To>(From EMGBKAPJLEO, ref To KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class FNODFCKHKKC
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1B8A940", Offset = "0x1B89140", VA = "0x181B8A940")]
	[PNKOKLHJFMG]
	public static JobHandle EANPAIIJLEC<T>(this EntityCommandBufferSystem KFAEBKFHHLM, NativeArrayAsync<Entity> KFLBCCAJFMN, NativeArrayAsync<T> NFBDMLCENEN, [Optional] JobHandle BFAAEILACKK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1B8ABB0", Offset = "0x1B893B0", VA = "0x181B8ABB0")]
	[PNKOKLHJFMG]
	public static JobHandle EANPAIIJLEC<T>(this EntityCommandBufferSystem KFAEBKFHHLM, NativeArrayAsync<Entity> KFLBCCAJFMN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1B8AA90", Offset = "0x1B89290", VA = "0x181B8AA90")]
	[PNKOKLHJFMG]
	public static JobHandle EANPAIIJLEC<T>(this EntityCommandBufferSystem KFAEBKFHHLM, NativeArray<Entity> KFLBCCAJFMN, [Optional] JobHandle BFAAEILACKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F940", Offset = "0x6E2E140", VA = "0x186E2F940")]
	[PNKOKLHJFMG]
	public static JobHandle EANPAIIJLEC(this EntityCommandBufferSystem KFAEBKFHHLM, NativeArray<Entity> KFLBCCAJFMN, ComponentTypes KIKBKFAAADF, [Optional] JobHandle BFAAEILACKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F7E0", Offset = "0x6E2DFE0", VA = "0x186E2F7E0")]
	[PNKOKLHJFMG]
	public static JobHandle EANPAIIJLEC(this EntityCommandBufferSystem KFAEBKFHHLM, EntityCommandBuffer PFGPHODPKBL, NativeArray<Entity> KFLBCCAJFMN, ComponentTypes KIKBKFAAADF, [Optional] JobHandle BFAAEILACKK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class OMFOEPJOFML
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6E308A0", Offset = "0x6E2F0A0", VA = "0x186E308A0")]
	private unsafe static Span<byte> EHLKFJLGJOM(Unity.Entities.Chunk* OPMNIAACDHI, int HLNBNEPDGFF)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2BFBE60", Offset = "0x2BFA660", VA = "0x182BFBE60")]
	public unsafe static Span<T> IGMGKPFAOCF<T>(Unity.Entities.Chunk* OPMNIAACDHI, int HLNBNEPDGFF)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x22EE230", Offset = "0x22ECA30", VA = "0x1822EE230")]
	public static Span<T> IGMGKPFAOCF<T>(this ref Unity.Entities.Chunk OPMNIAACDHI, int HLNBNEPDGFF)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6E30A60", Offset = "0x6E2F260", VA = "0x186E30A60")]
	public unsafe static Span<Entity> FMECHPOLJOL(Unity.Entities.Chunk* OPMNIAACDHI)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6E30620", Offset = "0x6E2EE20", VA = "0x186E30620")]
	public unsafe static void EEMEPIGIECC(Unity.Entities.Chunk* OPMNIAACDHI, int HLNBNEPDGFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[AttributeUsage(AttributeTargets.Class)]
public class GDHDJEDPJKJ : EFDDNEKNAJL
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x97A870", Offset = "0x979070", VA = "0x18097A870")]
	public GDHDJEDPJKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface CCMLHCDHEIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HGOHDAPNHBO(Entity AJDEFAPHMKF, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHEPEANNKCN(Entity AJDEFAPHMKF, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AFOBMJOLKHH(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JALGGMCELFM(Entity AJDEFAPHMKF);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class BNCOFINEJLB<TComponentData, TValue> : JBEJBDJJMKO<TValue>, IDisposable where TComponentData : struct, KMINMJBDKBF
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class NFLNKDGKBKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private List<(object token, TValue value)> DFMKDLJIHMN;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int GKGAEPJBJAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1C5F220", Offset = "0x1C5DA20", VA = "0x181C5F220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4035010", Offset = "0x4033810", VA = "0x184035010")]
		public bool BEAFOMPHFKM(out TValue MENBIMCLIOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4035200", Offset = "0x4033A00", VA = "0x184035200")]
		public void GLILACFFLBJ(object AMCDGOPKAOE, TValue MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4035180", Offset = "0x4033980", VA = "0x184035180")]
		public bool FNJGHMKCCPI(object AMCDGOPKAOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x40350D0", Offset = "0x40338D0", VA = "0x1840350D0")]
		public int FJEBBHPOEBK(object AMCDGOPKAOE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x40352B0", Offset = "0x4033AB0", VA = "0x1840352B0")]
		public NFLNKDGKBKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly Stack<NFLNKDGKBKC> MPKBIJIJEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private MHOFOLMCDLI<MLDDGBCIKAP, NFLNKDGKBKC> DLEDKBCLLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private EntityManager EADLBIHJKBG;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2714DF0", Offset = "0x27135F0", VA = "0x182714DF0")]
	public BNCOFINEJLB(EntityManager EADLBIHJKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2714B20", Offset = "0x2713320", VA = "0x182714B20", Slot = "4")]
	public void HGOHDAPNHBO(Entity AJDEFAPHMKF, object AMCDGOPKAOE, TValue MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2714C40", Offset = "0x2713440", VA = "0x182714C40", Slot = "5")]
	public bool HHEPEANNKCN(Entity AJDEFAPHMKF, object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2714850", Offset = "0x2713050", VA = "0x182714850", Slot = "6")]
	public bool BEAFOMPHFKM(Entity AJDEFAPHMKF, out TValue MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x27149A0", Offset = "0x27131A0", VA = "0x1827149A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2714920", Offset = "0x2713120", VA = "0x182714920")]
	private void DHFNHELLHDF(NFLNKDGKBKC ELNHJBKCMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2714780", Offset = "0x2712F80", VA = "0x182714780")]
	private bool BBHHADPNPAC(Entity AJDEFAPHMKF, out MLDDGBCIKAP BJJHADPHPJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x27149C0", Offset = "0x27131C0", VA = "0x1827149C0")]
	private void ENHLAANEABB(Entity AJDEFAPHMKF, MLDDGBCIKAP BJJHADPHPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2714DD0", Offset = "0x27135D0", VA = "0x182714DD0")]
	private bool JHKNAFOBKIH(MLDDGBCIKAP BJJHADPHPJP, out NFLNKDGKBKC ELNHJBKCMGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2714A50", Offset = "0x2713250", VA = "0x182714A50")]
	private NFLNKDGKBKC FKHNCOCCMCC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface JBEJBDJJMKO<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGOHDAPNHBO(Entity AJDEFAPHMKF, object AMCDGOPKAOE, TValue MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHEPEANNKCN(Entity AJDEFAPHMKF, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BEAFOMPHFKM(Entity AJDEFAPHMKF, out TValue MENBIMCLIOI);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface KMINMJBDKBF : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MLDDGBCIKAP NOIOKMKEGKN
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
public struct MLDDGBCIKAP : IAJADHNJCKN, IEquatable<MLDDGBCIKAP>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly MLDDGBCIKAP HCMFGAEBPME;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	[CreateProperty]
	public int JNDMMPHMODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xB1A680", Offset = "0xB18E80", VA = "0x180B1A680", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xB1A5C0", Offset = "0xB18DC0", VA = "0x180B1A5C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	[CreateProperty]
	public int IHOKMDEGNLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1AB09C0", Offset = "0x1AAF1C0", VA = "0x181AB09C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x24EBED0", Offset = "0x24EA6D0", VA = "0x1824EBED0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E30360", Offset = "0x6E2EB60", VA = "0x186E30360", Slot = "8")]
	public bool Equals(MLDDGBCIKAP OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6E303B0", Offset = "0x6E2EBB0", VA = "0x186E303B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class NDIDPNIFDGF<THasTokensTag> : CCMLHCDHEIF, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Dictionary<Entity, MLDDGBCIKAP> IPEMBCCICMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Stack<HashSet<object>> MPKBIJIJEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private MHOFOLMCDLI<MLDDGBCIKAP, HashSet<object>> DLEDKBCLLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private EntityManager EADLBIHJKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private EntityCommandBufferSystem KFAEBKFHHLM;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x402E660", Offset = "0x402CE60", VA = "0x18402E660")]
	public NDIDPNIFDGF(EntityManager EADLBIHJKBG, EntityCommandBufferSystem KFAEBKFHHLM, JNGNMMOLKFF ADBLAEENMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x402CA40", Offset = "0x402B240", VA = "0x18402CA40", Slot = "4")]
	public bool HGOHDAPNHBO(Entity AJDEFAPHMKF, object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x402D110", Offset = "0x402B910", VA = "0x18402D110", Slot = "5")]
	public bool HHEPEANNKCN(Entity AJDEFAPHMKF, object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x402B820", Offset = "0x402A020", VA = "0x18402B820", Slot = "6")]
	public bool AFOBMJOLKHH(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x402B940", Offset = "0x402A140", VA = "0x18402B940", Slot = "9")]
	public bool AFOBMJOLKHH(MLDDGBCIKAP BJJHADPHPJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x402DBF0", Offset = "0x402C3F0", VA = "0x18402DBF0", Slot = "7")]
	public bool JALGGMCELFM(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x402C290", Offset = "0x402AA90", VA = "0x18402C290", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x402C020", Offset = "0x402A820", VA = "0x18402C020")]
	private void DHFNHELLHDF(HashSet<object> ELNHJBKCMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x402BCA0", Offset = "0x402A4A0", VA = "0x18402BCA0")]
	private bool BBHHADPNPAC(Entity AJDEFAPHMKF, out MLDDGBCIKAP BJJHADPHPJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x402E240", Offset = "0x402CA40", VA = "0x18402E240")]
	private bool NAAKPJPLGKJ(Entity AJDEFAPHMKF, out MLDDGBCIKAP BJJHADPHPJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x402DFF0", Offset = "0x402C7F0", VA = "0x18402DFF0")]
	private void MHCLKIDGEFM(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x402DF60", Offset = "0x402C760", VA = "0x18402DF60")]
	private void KPFDCALOCDI(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x402DCE0", Offset = "0x402C4E0", VA = "0x18402DCE0")]
	private void KEJDONFKMMN(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x402C390", Offset = "0x402AB90", VA = "0x18402C390")]
	private void ENHLAANEABB(Entity AJDEFAPHMKF, MLDDGBCIKAP BJJHADPHPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x402D6B0", Offset = "0x402BEB0", VA = "0x18402D6B0")]
	private bool HIKAOPDGCBF(MLDDGBCIKAP BJJHADPHPJP, out HashSet<object> ELNHJBKCMGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x402C660", Offset = "0x402AE60", VA = "0x18402C660")]
	private HashSet<object> FKHNCOCCMCC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class MEJJAMIOBAI
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void MDIJALOOALC(this JNGNMMOLKFF MBNJNNGOKFP, NativeArray<Entity> KFLBCCAJFMN, [Optional][CallerFilePath] string AJHNILFIFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void MDIJALOOALC(this JNGNMMOLKFF MBNJNNGOKFP, string MDOAADHDBMA, NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void MDIJALOOALC(this JNGNMMOLKFF MBNJNNGOKFP, string AJHNILFIFHG, NativeArray<Entity> KFLBCCAJFMN, bool KGMLPBEJDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void PLIGMILJFFH(this JNGNMMOLKFF MBNJNNGOKFP, NativeArray<Entity> KFLBCCAJFMN, EntityManager EADLBIHJKBG, [Optional][CallerFilePath] string AJHNILFIFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void PLIGMILJFFH(this JNGNMMOLKFF MBNJNNGOKFP, string AJHNILFIFHG, NativeArray<Entity> KFLBCCAJFMN, EntityManager EADLBIHJKBG, bool KGMLPBEJDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void CDNOKNKDPNB(this JNGNMMOLKFF MBNJNNGOKFP, NativeArray<Entity> KFLBCCAJFMN, NativeArray<Entity> KKDNOJEGEJF, [Optional][CallerFilePath] string AJHNILFIFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void CDNOKNKDPNB(this JNGNMMOLKFF MBNJNNGOKFP, string AJHNILFIFHG, NativeArray<Entity> KFLBCCAJFMN, NativeArray<Entity> KKDNOJEGEJF, bool KGMLPBEJDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2B67C00", Offset = "0x2B66400", VA = "0x182B67C00")]
	public static void IOPFIOPEKJN<T>(this JNGNMMOLKFF MBNJNNGOKFP, string MDOAADHDBMA, NativeArray<Entity> KFLBCCAJFMN, NativeList<T> NFBDMLCENEN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2B67BB0", Offset = "0x2B663B0", VA = "0x182B67BB0")]
	public static void IOPFIOPEKJN<T>(this JNGNMMOLKFF MBNJNNGOKFP, NativeArray<Entity> KFLBCCAJFMN, NativeArray<T> NFBDMLCENEN, [Optional][CallerFilePath] string AJHNILFIFHG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2B67B70", Offset = "0x2B66370", VA = "0x182B67B70")]
	public static void IOPFIOPEKJN<T>(this JNGNMMOLKFF MBNJNNGOKFP, string MDOAADHDBMA, NativeArray<Entity> KFLBCCAJFMN, NativeArray<T> NFBDMLCENEN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void IOPFIOPEKJN<T>(this JNGNMMOLKFF MBNJNNGOKFP, string AJHNILFIFHG, NativeArray<Entity> KFLBCCAJFMN, NativeArray<T> NFBDMLCENEN, bool KGMLPBEJDNB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2B67C90", Offset = "0x2B66490", VA = "0x182B67C90")]
	public static void MEEDABCJHJI<T>(this JNGNMMOLKFF MBNJNNGOKFP, NativeList<T> NFBDMLCENEN, [Optional][CallerFilePath] string AJHNILFIFHG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2B67CF0", Offset = "0x2B664F0", VA = "0x182B67CF0")]
	public static void MEEDABCJHJI<T>(this JNGNMMOLKFF MBNJNNGOKFP, NativeArray<T> NFBDMLCENEN, [Optional][CallerFilePath] string AJHNILFIFHG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void MEEDABCJHJI<T>(this JNGNMMOLKFF MBNJNNGOKFP, string AJHNILFIFHG, NativeArray<T> NFBDMLCENEN, bool KGMLPBEJDNB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void ELBPNNJEENO(this JNGNMMOLKFF MBNJNNGOKFP, EntityQuery EGFJCKOAGFH, [Optional][CallerFilePath] string AJHNILFIFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void ELBPNNJEENO(this JNGNMMOLKFF MBNJNNGOKFP, string MDOAADHDBMA, EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void ELBPNNJEENO(this JNGNMMOLKFF MBNJNNGOKFP, string AJHNILFIFHG, EntityQuery EGFJCKOAGFH, bool KGMLPBEJDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2B67B40", Offset = "0x2B66340", VA = "0x182B67B40")]
	public static void GNMPBIKGKFK<T, T2>(this JNGNMMOLKFF MBNJNNGOKFP, string MDOAADHDBMA, EntityQuery EGFJCKOAGFH) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void GNMPBIKGKFK<T, T2>(this JNGNMMOLKFF MBNJNNGOKFP, string AJHNILFIFHG, EntityQuery EGFJCKOAGFH, bool KGMLPBEJDNB) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2B67B40", Offset = "0x2B66340", VA = "0x182B67B40")]
	public static void DEINHLJOBOA<T>(this JNGNMMOLKFF MBNJNNGOKFP, string MDOAADHDBMA, NativeList<T> DLLMPOAIBGN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void DEINHLJOBOA<T>(this JNGNMMOLKFF MBNJNNGOKFP, string AJHNILFIFHG, NativeList<T> DLLMPOAIBGN, bool KGMLPBEJDNB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2B67B40", Offset = "0x2B66340", VA = "0x182B67B40")]
	public static void HONCAAFPHNE<T>(this JNGNMMOLKFF MBNJNNGOKFP, string MDOAADHDBMA, NativeArray<T> DLLMPOAIBGN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public static void HONCAAFPHNE<T>(this JNGNMMOLKFF MBNJNNGOKFP, string AJHNILFIFHG, NativeArray<T> DLLMPOAIBGN, bool KGMLPBEJDNB) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class PGBKCKFKJGL
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public PGBKCKFKJGL()
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

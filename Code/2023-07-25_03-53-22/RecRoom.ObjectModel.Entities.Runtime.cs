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
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7218890", Offset = "0x7217890", VA = "0x187218890")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LPMNCBJJIEI
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class FKOOGOPJHKP<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] IMMMOLABPBJ;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xE605C0", Offset = "0xE5F5C0", VA = "0x180E605C0")]
	public static void ANAKCMFGFLI<TField>(int CCELBNKPBGB, string OALFIBFPPAC, PFBAFHPMHJD KKIFECJBFNE, out EMKOIFLBOGI<TField> LDJJMGJLECK) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xE61D50", Offset = "0xE60D50", VA = "0x180E61D50")]
	public static void OIGLDFFMLJM<TField>(int CCELBNKPBGB, string OALFIBFPPAC, out MOHEIECGODL<TField> GOOBHDEKEHB) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class LMHEOFFGCGA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7219340", Offset = "0x7218340", VA = "0x187219340")]
	public static FieldInfo[] DOLHHGDCMGP(Type DPPJBLOOGOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class OJPKNFOMKLK<View, Data> : BGPBFEOPJNE where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType JEEHPLOKOBO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type AJDGFDBDNPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA500", Offset = "0x2FE9500", VA = "0x182FEA500", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int ANJJFJFKAFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA380", Offset = "0x2FE9380", VA = "0x182FEA380", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA560", Offset = "0x2FE9560", VA = "0x182FEA560")]
	public Data HNKKDDEBAEJ(Entity NNCCHIHKALO)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA5D0", Offset = "0x2FE95D0", VA = "0x182FEA5D0")]
	public Data PGIFDPIFOLH(Entity NNCCHIHKALO)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View BPACPINDECF(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBB70", Offset = "0x1FCAB70", VA = "0x181FCBB70", Slot = "14")]
	public override T BPACPINDECF<T>(Entity NNCCHIHKALO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xBFF7C0", Offset = "0xBFE7C0", VA = "0x180BFF7C0")]
	protected OJPKNFOMKLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class BGPBFEOPJNE : PFBAFHPMHJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle CPOGPMKLKOE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager KLDHCJDHBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xDF4760", Offset = "0xDF3760", VA = "0x180DF4760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type AJDGFDBDNPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int ANJJFJFKAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type KADHHHCBFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4603140", Offset = "0x4602140", VA = "0x184603140", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int OGPMHKGKDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7217FC0", Offset = "0x7216FC0", VA = "0x187217FC0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private HOCJLCNHINC[] PBIEKHKPAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x11ECF90", Offset = "0x11EBF90", VA = "0x1811ECF90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual HOCJLCNHINC[] KGEEPIBBLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7217F00", Offset = "0x7216F00", VA = "0x187217F00", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72181A0", Offset = "0x72171A0", VA = "0x1872181A0")]
	public void LLEBBJIFEDK(EntityManager PFNOJANOPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T BPACPINDECF<T>(Entity NNCCHIHKALO) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x72180D0", Offset = "0x72170D0", VA = "0x1872180D0", Slot = "8")]
	public (uint, uint) LEGAONDFFFG(Entity NNCCHIHKALO)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7218030", Offset = "0x7217030", VA = "0x187218030", Slot = "9")]
	public bool HOELMEBEKPJ(Entity NNCCHIHKALO, (uint order, uint change) ELKCHAMAHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	protected BGPBFEOPJNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OBCPLOEMJAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int FCCAKNLHEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private int LEOAEOJMCHD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int COLPJJEEHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x12EC400", Offset = "0x12EB400", VA = "0x1812EC400")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1874F20", Offset = "0x1873F20", VA = "0x181874F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LJONEJGAFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86DD20", Offset = "0x86CD20", VA = "0x18086DD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int ILIAJIKNDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72199C0", Offset = "0x72189C0", VA = "0x1872199C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72199A0", Offset = "0x72189A0", VA = "0x1872199A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xB93FA0", Offset = "0xB92FA0", VA = "0x180B93FA0")]
	private OBCPLOEMJAL(int FCCAKNLHEPE, int LEOAEOJMCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x201C350", Offset = "0x201B350", VA = "0x18201C350")]
	public static OBCPLOEMJAL HMFFJCEHJHB(int FCCAKNLHEPE, int LEOAEOJMCHD)
	{
		return default(OBCPLOEMJAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x72199B0", Offset = "0x72189B0", VA = "0x1872199B0")]
	public static OBCPLOEMJAL MPBPKGGLODJ(int NKCNADFHDPD, int AOJGCGDGNAM)
	{
		return default(OBCPLOEMJAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72199D0", Offset = "0x72189D0", VA = "0x1872199D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HBJGFKKHFCG : BACOBOFHMJN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B230", Offset = "0x6B0A230", VA = "0x186B0B230")]
	public float BBELINJFKHO(in float3 CKDFGEALFAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B230", Offset = "0x6B0A230", VA = "0x186B0B230", Slot = "4")]
	private float EINBFOPBPIC(in float3 CKDFGEALFAK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GBJGBJDEICD : BACOBOFHMJN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CFE0", Offset = "0x6B0BFE0", VA = "0x186B0CFE0")]
	public float BBELINJFKHO(in float3 CKDFGEALFAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CFE0", Offset = "0x6B0BFE0", VA = "0x186B0CFE0", Slot = "4")]
	private float EINBFOPBPIC(in float3 CKDFGEALFAK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct NHEAADBLBIK : BACOBOFHMJN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xDC93B0", Offset = "0xDC83B0", VA = "0x180DC93B0")]
	public float BBELINJFKHO(in float3 CKDFGEALFAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xDC93B0", Offset = "0xDC83B0", VA = "0x180DC93B0", Slot = "4")]
	private float EINBFOPBPIC(in float3 CKDFGEALFAK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KEDDEFDCNKL : BACOBOFHMJN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xD85C30", Offset = "0xD84C30", VA = "0x180D85C30")]
	public int BBELINJFKHO(in int3 CKDFGEALFAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xD85C30", Offset = "0xD84C30", VA = "0x180D85C30", Slot = "4")]
	private int CPALELFNJAD(in int3 CKDFGEALFAK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CBNGLIMPEKN : BACOBOFHMJN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6560E00", Offset = "0x655FE00", VA = "0x186560E00")]
	public int BBELINJFKHO(in int3 CKDFGEALFAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6560E00", Offset = "0x655FE00", VA = "0x186560E00", Slot = "4")]
	private int CPALELFNJAD(in int3 CKDFGEALFAK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GMACPMHIEEL : BACOBOFHMJN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x115A440", Offset = "0x1159440", VA = "0x18115A440")]
	public int BBELINJFKHO(in int3 CKDFGEALFAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x115A440", Offset = "0x1159440", VA = "0x18115A440", Slot = "4")]
	private int CPALELFNJAD(in int3 CKDFGEALFAK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OGKPKBGBCEM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly byte[] FNLIPLLPDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MemoryStream LDKNDLKOFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CodedOutputStream CPBHNDOGJOK;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7219A60", Offset = "0x7218A60", VA = "0x187219A60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
internal struct CHLJMLHIAJB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public ComponentDataFromEntity EPLPIMFBELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[ReadOnly]
	public NativeArray<Entity> CECJHMIMHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeList<Entity> MLOIECCMJJI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7218450", Offset = "0x7217450", VA = "0x187218450", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FHBAKMIMPCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7218DC0", Offset = "0x7217DC0", VA = "0x187218DC0")]
	[FCCJPELLBLM]
	public static JobHandle AJMJJAPPAHP(this EntityCommandBufferSystem OMPMOFIICIH, NativeList<Entity> GLEBEEEMOOC, [Optional] JobHandle IDJCGGIDFOH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7218CB0", Offset = "0x7217CB0", VA = "0x187218CB0")]
	[FCCJPELLBLM]
	public static JobHandle AJMJJAPPAHP(this EntityCommandBufferSystem OMPMOFIICIH, NativeArrayAsync<Entity> GLEBEEEMOOC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LBLBCFNAKIP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2B64130", Offset = "0x2B63130", VA = "0x182B64130")]
	public static void LEGCHFHCMBE<T>(this EntityCommandBufferSystem OMPMOFIICIH, EntityQuery JGNEONGLEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B64070", Offset = "0x2B63070", VA = "0x182B64070")]
	[FCCJPELLBLM]
	public static JobHandle IHJOBOPKNIA<T>(this EntityCommandBufferSystem OMPMOFIICIH, NativeListAsync<Entity> GLEBEEEMOOC, [Optional] JobHandle IDJCGGIDFOH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2B63EE0", Offset = "0x2B62EE0", VA = "0x182B63EE0")]
	[FCCJPELLBLM]
	public static JobHandle IHJOBOPKNIA<T>(this EntityCommandBufferSystem OMPMOFIICIH, NativeArrayAsync<Entity> GLEBEEEMOOC, [Optional] JobHandle IDJCGGIDFOH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KFJJFKBBIGN
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct AJBNHMNGBGD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public NativeArray<Entity> BGMLIGEPDIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NativeArray<T> FIGDNGDPLDE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct OKFIJAABBBI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public NativeList<Entity> BGMLIGEPDIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NativeArray<T> FIGDNGDPLDE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct FHEHMMCEOKH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NativeArrayAsync<Entity> BGMLIGEPDIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NativeArrayAsync<T> FIGDNGDPLDE;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xE60550", Offset = "0xE5F550", VA = "0x180E60550")]
		public NativeListAsync<Entity> PKLANLJFCJB<TPredicate>() where TPredicate : struct, BLPBFAMOFHH<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2123830", Offset = "0x2122830", VA = "0x182123830")]
	public static FHEHMMCEOKH<T> LJEAIPIDAAG<T>(this NativeArrayAsync<Entity> CECJHMIMHMD, NativeArrayAsync<T> HCBHJPPICMK, Allocator HFHMLIPGBBB = Allocator.TempJob) where T : struct
	{
		return default(FHEHMMCEOKH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EMBDGOCMGME : GNKEBIFFBCC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Type DMNIJMEKFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Type BOJIIFKOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7218840", Offset = "0x7217840", VA = "0x187218840")]
	public EMBDGOCMGME(Type KFNIOFCFEKJ, Type EPLPIMFBELK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FNKNDIKHGPC
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BPCNIBOPAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x24FBF40", Offset = "0x24FAF40", VA = "0x1824FBF40")]
	public static NativeList<Entity> MCMEBJOFOGD<T>(this NativeArray<Entity> CECJHMIMHMD, EntityManager PFNOJANOPHC, Allocator HFHMLIPGBBB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HGDKIFLPIBM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly MemoryStream LDKNDLKOFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CodedInputStream EGAPNNCFDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72190D0", Offset = "0x72180D0", VA = "0x1872190D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class OOGBAIHAKPN
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct HDCHGBMOAHF : BACOBOFHMJN<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> FJBEPADOONK;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x72190C0", Offset = "0x72180C0", VA = "0x1872190C0")]
		[BurstCompatible]
		public Entity BBELINJFKHO(in Entity CKDFGEALFAK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x72190C0", Offset = "0x72180C0", VA = "0x1872190C0", Slot = "4")]
		private Entity BNJOJOFINGH(in Entity CKDFGEALFAK)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct EEJHBJJOHFL<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ILHDAFKCKHL : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public EEJHBJJOHFL<Protobuf> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xBF8100", Offset = "0xBF7100", VA = "0x180BF8100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xBF8150", Offset = "0xBF7150", VA = "0x180BF8150", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xBF81A0", Offset = "0xBF71A0", VA = "0x180BF81A0")]
		[DebuggerHidden]
		public ILHDAFKCKHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xBF7F40", Offset = "0xBF6F40", VA = "0x180BF7F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xBF8110", Offset = "0xBF7110", VA = "0x180BF8110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Action<Protobuf> OOKJDKGPGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MemoryStream LDKNDLKOFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CodedInputStream EGAPNNCFDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Protobuf DJGCJCMOFFD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int NKLAFIEKONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xBB0410", Offset = "0xBAF410", VA = "0x180BB0410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x321BC20", Offset = "0x321AC20", VA = "0x18321BC20")]
	private EEJHBJJOHFL(byte[] FNLIPLLPDBH, Action<Protobuf> OOKJDKGPGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xE5D4B0", Offset = "0xE5C4B0", VA = "0x180E5D4B0")]
	public static EEJHBJJOHFL<Protobuf> HFOCJEBDOBL<Data>(ReadOnlySpan<byte> PDFBAGGMCIA, ReadOnlySpan<Data> DLHPGJHCOIO, Action<Protobuf> OOKJDKGPGPC)
	{
		return default(EEJHBJJOHFL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x321BA90", Offset = "0x321AA90", VA = "0x18321BA90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x321BAD0", Offset = "0x321AAD0", VA = "0x18321BAD0", Slot = "4")]
	[IteratorStateMachine(typeof(EEJHBJJOHFL<>.ILHDAFKCKHL))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x321BBD0", Offset = "0x321ABD0", VA = "0x18321BBD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class LBJIAMDHCJI : IKKHFEIBOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72192F0", Offset = "0x72182F0", VA = "0x1872192F0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase EMLCJAADMAD();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x72192A0", Offset = "0x72182A0", VA = "0x1872192A0")]
	protected ComponentSystemBase KBEDBJMHBNG(params ComponentSystemBase[] PNLCMCKFGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2B63950", Offset = "0x2B62950", VA = "0x182B63950")]
	protected ComponentSystemBase KBEDBJMHBNG<T>(params ComponentSystemBase[] PNLCMCKFGMK) where T : IKKHFEIBOLP, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B63880", Offset = "0x2B62880", VA = "0x182B63880")]
	protected ComponentSystemBase EBFJJNEPOHE<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B63880", Offset = "0x2B62880", VA = "0x182B63880")]
	protected ComponentSystemBase KJBGBNNFKNC<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7219250", Offset = "0x7218250", VA = "0x187219250")]
	protected ComponentSystemBase EHMHMFEONEA(params SystemHandleUntyped[] PNLCMCKFGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B638C0", Offset = "0x2B628C0", VA = "0x182B638C0")]
	protected ComponentSystemBase EHMHMFEONEA<T>(params SystemHandleUntyped[] PNLCMCKFGMK) where T : IKKHFEIBOLP, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B639F0", Offset = "0x2B629F0", VA = "0x182B639F0")]
	protected SystemHandleUntyped OBCMOMBMNPG<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x72187E0", Offset = "0x72177E0", VA = "0x1872187E0")]
	protected LBJIAMDHCJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class POFBMLKHBGL
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3A34120", Offset = "0x3A33120", VA = "0x183A34120")]
	public static NativeList<T> FOMOGHIHKML<T>(NativeList<T> HCBHJPPICMK, Allocator HFHMLIPGBBB) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MONGCBPHBMK
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct AJDLCOGGGNE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : BACOBOFHMJN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> FIGDNGDPLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeList<TFrom> JMDBCFPABJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeParallelHashSet<TTo> CAMKFIDILHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap OKCPFPFJOFL;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct BCKGAPGECNB<T, TPredicate> : IJob where T : struct where TPredicate : struct, BLPBFAMOFHH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<T> FIGDNGDPLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> BGMLIGEPDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeList<Entity> HNLIGINJEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public TPredicate OKCPFPFJOFL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5A10", Offset = "0x2BD4A10", VA = "0x182BD5A10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct AIJOENICLFN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BACOBOFHMJN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<TFrom> PDPCCDLMEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[WriteOnly]
	public NativeList<TTo> CNCLOJJALKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public TMap OKCPFPFJOFL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class KGPKAEDDIAG
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct CPLGOEMONJE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly NativeArray<T>.ReadOnly GJAKHOONFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int PDAGAKEPNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int DFAFDFCNNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private T FNALKACKEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private T DPHGEMPEHHD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public OBCPLOEMJAL OOFOHLLBOFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2435070", Offset = "0x2434070", VA = "0x182435070")]
			get
			{
				return default(OBCPLOEMJAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T IGGJAKADOPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x12EC7B0", Offset = "0x12EB7B0", VA = "0x1812EC7B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (T, OBCPLOEMJAL) LMEBIHANEPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3460820", Offset = "0x345F820", VA = "0x183460820")]
			get
			{
				return default((T, OBCPLOEMJAL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3460CE0", Offset = "0x345FCE0", VA = "0x183460CE0")]
		public CPLGOEMONJE(NativeArray<T> GJAKHOONFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2346320", Offset = "0x2345320", VA = "0x182346320")]
		public CPLGOEMONJE<T> EFCEFGGNIIL()
		{
			return default(CPLGOEMONJE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3460B50", Offset = "0x345FB50", VA = "0x183460B50")]
		public bool DECNHOEABDK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xE5A210", Offset = "0xE59210", VA = "0x180E5A210")]
		public NHMEEOFBABJ<T, TComparer> FCMCKJBEFPP<TComparer>([Optional] TComparer KDDNEKEHDIO) where TComparer : struct, IEqualityComparer<T>
		{
			return default(NHMEEOFBABJ<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct NHMEEOFBABJ<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly NativeArray<T>.ReadOnly GJAKHOONFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int PDAGAKEPNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int DFAFDFCNNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T FNALKACKEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private T DPHGEMPEHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TComparer KDDNEKEHDIO;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public OBCPLOEMJAL OOFOHLLBOFE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2435070", Offset = "0x2434070", VA = "0x182435070")]
			get
			{
				return default(OBCPLOEMJAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public T IGGJAKADOPH
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x12EC7B0", Offset = "0x12EB7B0", VA = "0x1812EC7B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public (T value, OBCPLOEMJAL range) LMEBIHANEPB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2434FA0", Offset = "0x2433FA0", VA = "0x182434FA0")]
			get
			{
				return default((T, OBCPLOEMJAL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x24352E0", Offset = "0x24342E0", VA = "0x1824352E0")]
		public NHMEEOFBABJ(NativeArray<T>.ReadOnly GJAKHOONFBO, TComparer KDDNEKEHDIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x23468D0", Offset = "0x23458D0", VA = "0x1823468D0")]
		public NHMEEOFBABJ<T, TComparer> EFCEFGGNIIL()
		{
			return default(NHMEEOFBABJ<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2435080", Offset = "0x2434080", VA = "0x182435080")]
		public bool DECNHOEABDK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2123B60", Offset = "0x2122B60", VA = "0x182123B60")]
	public static CPLGOEMONJE<T> KBEDBJMHBNG<T>(this NativeArray<T> GJAKHOONFBO) where T : struct
	{
		return default(CPLGOEMONJE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BACOBOFHMJN<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo BBELINJFKHO(in TFrom CKDFGEALFAK);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class JFPOCAHJAEA
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class PNJOFLLNMHH
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JDDJMLHLGPN<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public JDDJMLHLGPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class PCGDAPMDOGL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		public PCGDAPMDOGL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<Func<JobHandle, JobHandle>> BPAABGJCEFI;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7219B80", Offset = "0x7218B80", VA = "0x187219B80")]
	public PNJOFLLNMHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HKAINJPBGJP
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class KAGMJMHDDHM : EntityCommandBufferSystem, DMAOLHFEOJM
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
	protected KAGMJMHDDHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NPGJIMBJIIM
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2527670", Offset = "0x2526670", VA = "0x182527670")]
	[FCCJPELLBLM]
	public static JobHandle NMOPHBFLBOH<T>(this EntityCommandBufferSystem OMPMOFIICIH, NativeArray<Entity> GLEBEEEMOOC, NativeArray<T> HHCEHFFEAKN, JobHandle IDJCGGIDFOH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct OBNBJOOCKBP<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<T> FIGDNGDPLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<T> JMDBCFPABJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<T> CAMKFIDILHM;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2350C30", Offset = "0x234FC30", VA = "0x182350C30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct GEFPNKFICHK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> GLEBEEEMOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EntityCommandBuffer IFKBGIEODAK;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7218F60", Offset = "0x7217F60", VA = "0x187218F60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class CBBCPLMPFAB
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2C836C0", Offset = "0x2C826C0", VA = "0x182C836C0")]
	public static NativeArray<T> JJKLECPDCGG<T>(this NativeList<Entity> HCBHJPPICMK, EntityManager PFNOJANOPHC, Allocator HFHMLIPGBBB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2C83150", Offset = "0x2C82150", VA = "0x182C83150")]
	public static NativeArray<T> JJKLECPDCGG<T>(this NativeArray<Entity> HCBHJPPICMK, EntityManager PFNOJANOPHC, Allocator HFHMLIPGBBB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface PDJKDAHGHKH
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IJFMGHCONPF
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal struct POJALNBHOLO<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> GLEBEEEMOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public T CKDFGEALFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public EntityCommandBuffer IFKBGIEODAK;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x204F370", Offset = "0x204E370", VA = "0x18204F370", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class FABOFJAFPCM
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1A6C440", Offset = "0x1A6B440", VA = "0x181A6C440")]
	[FCCJPELLBLM]
	public static JobHandle GHAOIBPEAPB<T>(this EntityCommandBufferSystem OMPMOFIICIH, EntityCommandBuffer IFKBGIEODAK, EntityQuery JGNEONGLEIH, T CKDFGEALFAK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class KLLFPPIOLKN<Data> : BDBABGBIICN where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public virtual Data JCGFDJGGMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x30DB680", Offset = "0x30DA680", VA = "0x1830DB680", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1E81BA0", Offset = "0x1E80BA0", VA = "0x181E81BA0", Slot = "8")]
	protected virtual bool KJKDLFDFPPP(ReadOnlySpan<Data> DLHPGJHCOIO, FOBDKADMOIM PIGDEHAKGEH, out ReadOnlySpan<byte> PDFBAGGMCIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x98E270", Offset = "0x98D270", VA = "0x18098E270", Slot = "9")]
	protected virtual bool NLAAFDFIGHP(int ELKCHAMAHHH, Span<Data> DLHPGJHCOIO, in ReadOnlySpan<byte> PDFBAGGMCIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x30DB770", Offset = "0x30DA770", VA = "0x1830DB770", Slot = "5")]
	internal sealed override bool KJKDLFDFPPP(ref Unity.Entities.Chunk FBFHMCNKMFH, int DBKLDJGFLBN, FOBDKADMOIM PIGDEHAKGEH, out ReadOnlySpan<byte> PDFBAGGMCIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x30DBB30", Offset = "0x30DAB30", VA = "0x1830DBB30", Slot = "6")]
	internal sealed override bool NLAAFDFIGHP(int ELKCHAMAHHH, ref Unity.Entities.Chunk FBFHMCNKMFH, int DBKLDJGFLBN, in ReadOnlySpan<byte> PDFBAGGMCIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x22A6EA0", Offset = "0x22A5EA0", VA = "0x1822A6EA0")]
	protected FOBEGCAMAAC<Protobuf> GLGGPMIMNOP<Protobuf>(ReadOnlySpan<Data> DLHPGJHCOIO) where Protobuf : IMessage, new()
	{
		return default(FOBEGCAMAAC<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x22A6EF0", Offset = "0x22A5EF0", VA = "0x1822A6EF0")]
	protected EEJHBJJOHFL<Protobuf> ILHFLGNDJGJ<Protobuf>(ReadOnlySpan<byte> PDFBAGGMCIA, ReadOnlySpan<Data> DLHPGJHCOIO, Action<Protobuf> OOKJDKGPGPC) where Protobuf : IMessage, new()
	{
		return default(EEJHBJJOHFL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xBFF7C0", Offset = "0xBFE7C0", VA = "0x180BFF7C0")]
	protected KLLFPPIOLKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class BDBABGBIICN
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected abstract int EBOJEELKNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7217EE0", Offset = "0x7216EE0", VA = "0x187217EE0", Slot = "5")]
	internal virtual bool KJKDLFDFPPP(ref Unity.Entities.Chunk FBFHMCNKMFH, int DBKLDJGFLBN, FOBDKADMOIM PIGDEHAKGEH, out ReadOnlySpan<byte> PDFBAGGMCIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x98E270", Offset = "0x98D270", VA = "0x18098E270", Slot = "6")]
	internal virtual bool NLAAFDFIGHP(int ELKCHAMAHHH, ref Unity.Entities.Chunk FBFHMCNKMFH, int DBKLDJGFLBN, in ReadOnlySpan<byte> PDFBAGGMCIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	protected BDBABGBIICN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class LFCACLMCHPO
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct MHMIGMLMBNB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct KINCLKAFENJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal MHMIGMLMBNB<TFrom> DJAGPEDCGHG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> NCAAFEBNDOO;
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct PMHCLEPAANH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public struct BIOKHPHGNJD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal PMHCLEPAANH<TFrom> DJAGPEDCGHG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> NCAAFEBNDOO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct HEJLOBFFNBK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public struct EIHAHHEFBKI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal HEJLOBFFNBK<TFrom> DJAGPEDCGHG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> NCAAFEBNDOO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct BOALCGNHBLM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public struct JMJEOJDNKPD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal BOALCGNHBLM<TFrom> DJAGPEDCGHG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> NCAAFEBNDOO;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct FFHHFFCNNDB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	public ComponentDataFromEntity OICDMPCGLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	public NativeArray<Entity> FIGDNGDPLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[WriteOnly]
	public NativeArray<byte> CNCLOJJALKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int FKGKIHJAAFF;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7218BB0", Offset = "0x7217BB0", VA = "0x187218BB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[BurstCompile]
internal struct HNPCOIDMBEO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EPLPIMFBELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[ReadOnly]
	public NativeArray<Entity> CECJHMIMHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<bool> CBBELMCBNCJ;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal struct MGFDLEAHCLH<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[ReadOnly]
	public NativeArray<Entity> GLEBEEEMOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[ReadOnly]
	public NativeArray<T> LGIIOJHKOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public EntityCommandBuffer IFKBGIEODAK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class IBAJINIPAON
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x107BAD0", Offset = "0x107AAD0", VA = "0x18107BAD0")]
	public static NativeListAsync<Entity> JIMHJHFFLOE<T, TPredicate>(this NativeArrayAsync<T> HCBHJPPICMK, NativeArrayAsync<Entity> CECJHMIMHMD, Allocator HFHMLIPGBBB = Allocator.TempJob) where T : struct where TPredicate : struct, BLPBFAMOFHH<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x107B920", Offset = "0x107A920", VA = "0x18107B920")]
	private static NativeListAsync<Entity> BLFCHPOBCHI<T, TPredicate>(NativeArrayAsync<T> MEMBKFIIGMK, NativeArrayAsync<Entity> CECJHMIMHMD, int PKGBKHCIKEH, Allocator HFHMLIPGBBB) where T : struct where TPredicate : struct, BLPBFAMOFHH<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class MEKFMKHJDHO
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x257C720", Offset = "0x257B720", VA = "0x18257C720")]
	[FCCJPELLBLM]
	public static JobHandle FEBMPNBPIFC<T>(this EntityCommandBufferSystem OMPMOFIICIH, NativeArray<Entity> GLEBEEEMOOC, T CKDFGEALFAK, [Optional] JobHandle IDJCGGIDFOH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x257C7F0", Offset = "0x257B7F0", VA = "0x18257C7F0")]
	[FCCJPELLBLM]
	public static JobHandle FEBMPNBPIFC<T>(this EntityCommandBufferSystem OMPMOFIICIH, EntityCommandBuffer IFKBGIEODAK, NativeArray<Entity> GLEBEEEMOOC, T CKDFGEALFAK, [Optional] JobHandle IDJCGGIDFOH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class FOBDKADMOIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> HJHMGFKOJDJ;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x20BB670", Offset = "0x20BA670", VA = "0x1820BB670")]
	public FOBDKADMOIM(NativeArray<EntityRemapUtility.EntityRemapInfo> HJHMGFKOJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7218F50", Offset = "0x7217F50", VA = "0x187218F50")]
	public Entity KFIMINDBNFH(Entity LPNPMOOMCIB)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class ILPGELBNHKH
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x10898F0", Offset = "0x10888F0", VA = "0x1810898F0")]
	public static NativeList<T> FOMOGHIHKML<T>(this NativeList<T> HCBHJPPICMK, Allocator HFHMLIPGBBB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1089720", Offset = "0x1088720", VA = "0x181089720")]
	public static NativeList<T> FOMOGHIHKML<T>(this NativeArray<T> HCBHJPPICMK, Allocator HFHMLIPGBBB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class OHEBNKPCFON
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct BJFCHMCLCKG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> FIGDNGDPLDE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct LCNIIMHGGMC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<T> FIGDNGDPLDE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct JBICPIJLGDL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<T> FIGDNGDPLDE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct LNIJPODLHLC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeListAsync<T> FIGDNGDPLDE;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
internal struct KKANLCJFLOG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BACOBOFHMJN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeArray<TFrom> FIGDNGDPLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[WriteOnly]
	public NativeArray<TTo> CNCLOJJALKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TMap OKCPFPFJOFL;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface BLPBFAMOFHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKLANLJFCJB(T CKDFGEALFAK);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
internal struct MHGLKNGNJKN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	public NativeArray<Entity> GLEBEEEMOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public EntityCommandBuffer IFKBGIEODAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public ComponentTypes CHDBPGAHGIF;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7219490", Offset = "0x7218490", VA = "0x187219490", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[BurstCompile]
internal struct KFOAHOIFOCL<T, TPredicate> : IJob where T : struct where TPredicate : struct, BLPBFAMOFHH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	public NativeArray<T> FIGDNGDPLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<T> JMDBCFPABJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public TPredicate OKCPFPFJOFL;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class IKKHFEIBOLP : DNLFAAMMKBD
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x72191F0", Offset = "0x72181F0", VA = "0x1872191F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x72187E0", Offset = "0x72177E0", VA = "0x1872187E0")]
	public IKKHFEIBOLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[BurstCompile]
internal struct PFPOGECKAMF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EPLPIMFBELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	public NativeArray<Entity> CECJHMIMHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<bool> CBBELMCBNCJ;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3B31B10", Offset = "0x3B30B10", VA = "0x183B31B10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct BCFEJPPHDNB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<Entity> GLEBEEEMOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	public NativeArray<T> HHCEHFFEAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public EntityCommandBuffer IFKBGIEODAK;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3B10", Offset = "0x2BD2B10", VA = "0x182BD3B10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class CELDBBHIGHG
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x72183C0", Offset = "0x72173C0", VA = "0x1872183C0")]
	public static ulong LCBBDPMIOJN(Type DPPJBLOOGOO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7218350", Offset = "0x7217350", VA = "0x187218350")]
	public static ulong LCBBDPMIOJN(string IPIOOFBEJHM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class DBNKNFEIMCG : GNKEBIFFBCC
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Type BOJIIFKOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3494CB0", Offset = "0x3493CB0", VA = "0x183494CB0")]
	public DBNKNFEIMCG(Type EPLPIMFBELK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[BurstCompile]
internal struct CECCOGBGDBM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public ComponentDataFromEntity EPLPIMFBELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	public NativeArray<Entity> CECJHMIMHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<Entity> MLOIECCMJJI;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x72182C0", Offset = "0x72172C0", VA = "0x1872182C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public abstract class GLJJODNHDIP : SystemBase, DMAOLHFEOJM
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7218FE0", Offset = "0x7217FE0", VA = "0x187218FE0")]
	public ComponentDataFromEntity NNDIKLBDEOB(int EELINDLPCIF, bool JPCODLKAKEL = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7218FC0", Offset = "0x7217FC0", VA = "0x187218FC0")]
	public EntityExistenceLookupByEntity LNJBBHEGGMH()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x72190B0", Offset = "0x72180B0", VA = "0x1872190B0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xAAA3B0", Offset = "0xAA93B0", VA = "0x180AAA3B0")]
	protected GLJJODNHDIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class JGBOCJIOKIC : GLJJODNHDIP
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7219220", Offset = "0x7218220", VA = "0x187219220", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xAAA3B0", Offset = "0xAA93B0", VA = "0x180AAA3B0")]
	protected JGBOCJIOKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class LDAGGOKPIPJ
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct FOBEGCAMAAC<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly byte[] FNLIPLLPDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Protobuf DJGCJCMOFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly MemoryStream LDKNDLKOFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly CodedOutputStream CPBHNDOGJOK;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3550C50", Offset = "0x354FC50", VA = "0x183550C50")]
	private FOBEGCAMAAC(byte[] FNLIPLLPDBH, in Protobuf DJGCJCMOFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C02C90", Offset = "0x2C01C90", VA = "0x182C02C90")]
	public static FOBEGCAMAAC<Protobuf> HFOCJEBDOBL<T>(ReadOnlySpan<T> DLHPGJHCOIO)
	{
		return default(FOBEGCAMAAC<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3550B90", Offset = "0x354FB90", VA = "0x183550B90")]
	public void HMLOBKDNCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3550BC0", Offset = "0x354FBC0", VA = "0x183550BC0")]
	public ByteString PPKHGPBAOJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3550A70", Offset = "0x354FA70", VA = "0x183550A70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface DMAOLHFEOJM
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public abstract class DNLFAAMMKBD : ComponentSystemGroup, DMAOLHFEOJM
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x72187E0", Offset = "0x72177E0", VA = "0x1872187E0")]
	protected DNLFAAMMKBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class PGCMHFLAPOB
{
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[BurstCompile]
internal struct CCOMNAEOPML<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MEBPDFIONDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public NativeArray<Entity> FIGDNGDPLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[WriteOnly]
	public NativeList<T> JMDBCFPABJI;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[Flags]
public enum JCIIPFFEOHD
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
public class CPDBNMKLAKF : GNKEBIFFBCC
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xAAA3B0", Offset = "0xAA93B0", VA = "0x180AAA3B0")]
	public CPDBNMKLAKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class POAECHLKGHE
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public readonly struct JCJDOMFHEGD<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly NativeArray<TSrc> GJAKHOONFBO;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
		public JCJDOMFHEGD(NativeArray<TSrc> GJAKHOONFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		public CDFMKOHNOOF<TSrc, TValue> BGMJAFMMDGB<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(CDFMKOHNOOF<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct CDFMKOHNOOF<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly NativeArray<TSrc> GJAKHOONFBO;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
		public CDFMKOHNOOF(NativeArray<TSrc> GJAKHOONFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		public IHDKHJJODBN<TSrc, TValue, TSelector> FNMDLAHILIK<TSelector>() where TSelector : struct, BACOBOFHMJN<TSrc, TValue>
		{
			return default(IHDKHJJODBN<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct IHDKHJJODBN<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BACOBOFHMJN<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly NativeArray<TSrc> GJAKHOONFBO;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
		public IHDKHJJODBN(NativeArray<TSrc> GJAKHOONFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xBE2E80", Offset = "0xBE1E80", VA = "0x180BE2E80")]
		public HENJNCOCDFK<TSrc, TValue, TSelector> KBEDBJMHBNG()
		{
			return default(HENJNCOCDFK<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct LOLOGGHLNFA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, BACOBOFHMJN<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly NativeArray<TSrc> GJAKHOONFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TSelector EHOLPOGLFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int CCELBNKPBGB;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TValue LMEBIHANEPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x2513E70", Offset = "0x2512E70", VA = "0x182513E70")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int EODOJNLPHFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x91B190", Offset = "0x91A190", VA = "0x18091B190")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int NKLAFIEKONA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA2BF90", Offset = "0xA2AF90", VA = "0x180A2BF90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2513EF0", Offset = "0x2512EF0", VA = "0x182513EF0")]
		public LOLOGGHLNFA(NativeArray<TSrc> GJAKHOONFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2513EE0", Offset = "0x2512EE0", VA = "0x182513EE0")]
		public bool DECNHOEABDK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2513D50", Offset = "0x2512D50", VA = "0x182513D50")]
		private TSrc BIIIAPGOMOG(int KJPGMJFNNHE)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public struct HENJNCOCDFK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BACOBOFHMJN<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private LOLOGGHLNFA<TSrc, TValue, TSelector> GMJKLGDIAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TValue FNALKACKEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int PDAGAKEPNHP;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public OBCPLOEMJAL OOFOHLLBOFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x203F3C0", Offset = "0x203E3C0", VA = "0x18203F3C0")]
			get
			{
				return default(OBCPLOEMJAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TValue IGGJAKADOPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x9AEAB0", Offset = "0x9ADAB0", VA = "0x1809AEAB0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (TValue value, OBCPLOEMJAL range) LMEBIHANEPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x203F2F0", Offset = "0x203E2F0", VA = "0x18203F2F0")]
			get
			{
				return default((TValue, OBCPLOEMJAL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x203F530", Offset = "0x203E530", VA = "0x18203F530")]
		public HENJNCOCDFK(NativeArray<TSrc> GJAKHOONFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x12EC250", Offset = "0x12EB250", VA = "0x1812EC250")]
		public HENJNCOCDFK<TSrc, TValue, TSelector> EFCEFGGNIIL()
		{
			return default(HENJNCOCDFK<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x203F400", Offset = "0x203E400", VA = "0x18203F400")]
		public bool DECNHOEABDK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3A33DF0", Offset = "0x3A32DF0", VA = "0x183A33DF0")]
	public static JCJDOMFHEGD<T> PGBBHFNCLAG<T>(this NativeList<T> BHINNEMAJAD) where T : struct
	{
		return default(JCJDOMFHEGD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
	public static JCJDOMFHEGD<T> PGBBHFNCLAG<T>(this NativeArray<T> GJAKHOONFBO) where T : struct
	{
		return default(JCJDOMFHEGD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class EFCJMAHMCJA
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct PHOJELIPMGP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct LAGAMDLIGEL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public PHOJELIPMGP<TFrom> NCAAFEBNDOO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NativeArray<TFrom> FIGDNGDPLDE;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct HOKLCEBHGNI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public struct FKOELOOLONM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public HOKLCEBHGNI<TFrom> NCAAFEBNDOO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeArrayAsync<TFrom> FIGDNGDPLDE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct BIDMMJCJDMN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public struct BLGBINGFGBB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public BIDMMJCJDMN<TFrom> NCAAFEBNDOO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Allocator HFHMLIPGBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NativeListAsync<TFrom> FIGDNGDPLDE;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[BurstCompile]
internal struct DBGJPMFDFAE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	public NativeArray<Entity> GLEBEEEMOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public EntityCommandBuffer IFKBGIEODAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public ComponentType CMPFEHALBCD;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x72187B0", Offset = "0x72177B0", VA = "0x1872187B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class MEJGKEHFKKC
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x257C560", Offset = "0x257B560", VA = "0x18257C560")]
	public static bool GCGFEDKJLLP<T>(this NativeArray<Entity> CECJHMIMHMD, EntityManager PFNOJANOPHC, Allocator HFHMLIPGBBB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class EMGCIEIFIGO
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class LBCGFICPENK
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class FDCPMPCDLKE
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public delegate void CKFLDJOBANO<From, To>(From NCAAFEBNDOO, ref To OOMAONFBFID, FOBDKADMOIM PIGDEHAKGEH);

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private class ONFFAONDEIH<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static CKFLDJOBANO<From, To> BBOHKMCBFHF;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public ONFFAONDEIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x72188B0", Offset = "0x72178B0", VA = "0x1872188B0")]
	static FDCPMPCDLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1A7C980", Offset = "0x1A7B980", VA = "0x181A7C980")]
	public static void FGCIPKKIHED<T>(CKFLDJOBANO<T, T> FMAPPKFEDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1A7C620", Offset = "0x1A7B620", VA = "0x181A7C620")]
	public static void FGCIPKKIHED<From, To>(CKFLDJOBANO<From, To> FMAPPKFEDAC, CKFLDJOBANO<To, From> MHFEGNHCEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A7C5D0", Offset = "0x1A7B5D0", VA = "0x181A7C5D0")]
	public static void FGCIPKKIHED<From, To>(CKFLDJOBANO<From, To> BBOHKMCBFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1A76010", Offset = "0x1A75010", VA = "0x181A76010")]
	public static CKFLDJOBANO<From, To> BCIBMOAMKIM<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1A7FB20", Offset = "0x1A7EB20", VA = "0x181A7FB20")]
	public static void MFNMGBFOEAN<From, To>(From NCAAFEBNDOO, ref To OOMAONFBFID, FOBDKADMOIM PIGDEHAKGEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class CNEOHANPALE
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1BC4F00", Offset = "0x1BC3F00", VA = "0x181BC4F00")]
	[FCCJPELLBLM]
	public static JobHandle PENFBENDGIG<T>(this EntityCommandBufferSystem OMPMOFIICIH, NativeArrayAsync<Entity> GLEBEEEMOOC, NativeArrayAsync<T> HHCEHFFEAKN, [Optional] JobHandle IDJCGGIDFOH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1BC4E60", Offset = "0x1BC3E60", VA = "0x181BC4E60")]
	[FCCJPELLBLM]
	public static JobHandle PENFBENDGIG<T>(this EntityCommandBufferSystem OMPMOFIICIH, NativeArrayAsync<Entity> GLEBEEEMOOC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1BC4D40", Offset = "0x1BC3D40", VA = "0x181BC4D40")]
	[FCCJPELLBLM]
	public static JobHandle PENFBENDGIG<T>(this EntityCommandBufferSystem OMPMOFIICIH, NativeArray<Entity> GLEBEEEMOOC, [Optional] JobHandle IDJCGGIDFOH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7218640", Offset = "0x7217640", VA = "0x187218640")]
	[FCCJPELLBLM]
	public static JobHandle PENFBENDGIG(this EntityCommandBufferSystem OMPMOFIICIH, NativeArray<Entity> GLEBEEEMOOC, ComponentTypes CHDBPGAHGIF, [Optional] JobHandle IDJCGGIDFOH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x72184E0", Offset = "0x72174E0", VA = "0x1872184E0")]
	[FCCJPELLBLM]
	public static JobHandle PENFBENDGIG(this EntityCommandBufferSystem OMPMOFIICIH, EntityCommandBuffer IFKBGIEODAK, NativeArray<Entity> GLEBEEEMOOC, ComponentTypes CHDBPGAHGIF, [Optional] JobHandle IDJCGGIDFOH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class NJJACALCGHM
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7219560", Offset = "0x7218560", VA = "0x187219560")]
	private unsafe static Span<byte> BJMGCNMFPMO(Unity.Entities.Chunk* FBFHMCNKMFH, int DBKLDJGFLBN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x251F410", Offset = "0x251E410", VA = "0x18251F410")]
	public unsafe static Span<T> OLKLLPFHKON<T>(Unity.Entities.Chunk* FBFHMCNKMFH, int DBKLDJGFLBN)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x251F5A0", Offset = "0x251E5A0", VA = "0x18251F5A0")]
	public static Span<T> OLKLLPFHKON<T>(this ref Unity.Entities.Chunk FBFHMCNKMFH, int DBKLDJGFLBN)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x72194F0", Offset = "0x72184F0", VA = "0x1872194F0")]
	public unsafe static Span<Entity> BJFDAGHDMMH(Unity.Entities.Chunk* FBFHMCNKMFH)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7219720", Offset = "0x7218720", VA = "0x187219720")]
	public unsafe static void PPNJFNMKMCA(Unity.Entities.Chunk* FBFHMCNKMFH, int DBKLDJGFLBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[AttributeUsage(AttributeTargets.Class)]
public class CCGEDKJMHOK : GNKEBIFFBCC
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xAAA3B0", Offset = "0xAA93B0", VA = "0x180AAA3B0")]
	public CCGEDKJMHOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface GHEPLNMMAKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEHDBNFBJCF(Entity NNCCHIHKALO, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EJBGDPBKJGN(Entity NNCCHIHKALO, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OHNJIHPCMGF(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<object> HKGLMFOBBGD(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HOEPOEDLGNC(Entity NNCCHIHKALO);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class AGHNODPMNEC<TComponentData, TValue> : MEDJCKOBHGE<TValue>, IDisposable where TComponentData : struct, CBGKOLHPOGA
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class IFIOMDELJBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private List<(object token, TValue value)> BHINNEMAJAD;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int NMOEOEAONON
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xBFE320", Offset = "0xBFD320", VA = "0x180BFE320")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1586DB0", Offset = "0x1585DB0", VA = "0x181586DB0")]
		public bool CCDEGKIBIPD(out TValue CKDFGEALFAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1586D00", Offset = "0x1585D00", VA = "0x181586D00")]
		public void AMLBOIMHPGF(object FFKJLIDBALM, TValue CKDFGEALFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1586E70", Offset = "0x1585E70", VA = "0x181586E70")]
		public bool DNDEJFPIDIA(object FFKJLIDBALM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1586EF0", Offset = "0x1585EF0", VA = "0x181586EF0")]
		public int FKFLNHOEGNA(object FFKJLIDBALM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1586FA0", Offset = "0x1585FA0", VA = "0x181586FA0")]
		public IFIOMDELJBF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly Stack<IFIOMDELJBF> ICPOOEICNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private HAFOFGMPBFH<IEEGMNGDKEC, IFIOMDELJBF> ECDFINBGCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private EntityManager PFNOJANOPHC;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9270", Offset = "0x2BF8270", VA = "0x182BF9270")]
	public AGHNODPMNEC(EntityManager PFNOJANOPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2BF8C00", Offset = "0x2BF7C00", VA = "0x182BF8C00", Slot = "4")]
	public void BEHDBNFBJCF(Entity NNCCHIHKALO, object FFKJLIDBALM, TValue CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2BF8E90", Offset = "0x2BF7E90", VA = "0x182BF8E90", Slot = "5")]
	public bool EJBGDPBKJGN(Entity NNCCHIHKALO, object FFKJLIDBALM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BF8D20", Offset = "0x2BF7D20", VA = "0x182BF8D20", Slot = "6")]
	public bool CCDEGKIBIPD(Entity NNCCHIHKALO, out TValue CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2BF8E70", Offset = "0x2BF7E70", VA = "0x182BF8E70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2BF8DF0", Offset = "0x2BF7DF0", VA = "0x182BF8DF0")]
	private void CILLNONKCLI(IFIOMDELJBF PNCNPDFLBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2BF91A0", Offset = "0x2BF81A0", VA = "0x182BF91A0")]
	private bool LFOFFLPOALN(Entity NNCCHIHKALO, out IEEGMNGDKEC DLOGIKEFHAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9020", Offset = "0x2BF8020", VA = "0x182BF9020")]
	private void FLGLFOFPFIA(Entity NNCCHIHKALO, IEEGMNGDKEC DLOGIKEFHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9180", Offset = "0x2BF8180", VA = "0x182BF9180")]
	private bool JBLIMKBCPHH(IEEGMNGDKEC DLOGIKEFHAN, out IFIOMDELJBF PNCNPDFLBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2BF90B0", Offset = "0x2BF80B0", VA = "0x182BF90B0")]
	private IFIOMDELJBF ICJOBHGDLLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface MEDJCKOBHGE<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEHDBNFBJCF(Entity NNCCHIHKALO, object FFKJLIDBALM, TValue CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EJBGDPBKJGN(Entity NNCCHIHKALO, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCDEGKIBIPD(Entity NNCCHIHKALO, out TValue CKDFGEALFAK);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface CBGKOLHPOGA : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IEEGMNGDKEC DPGCFNIHEAN
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
public struct IEEGMNGDKEC : KCABKHEOOAI<IEEGMNGDKEC>, BCBJEENMDEC, IEquatable<IEEGMNGDKEC>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly IEEGMNGDKEC JJICOGFFINC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	[CreateProperty]
	public int EODOJNLPHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86DD20", Offset = "0x86CD20", VA = "0x18086DD20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	[CreateProperty]
	public int EBOJEELKNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x12EC400", Offset = "0x12EB400", VA = "0x1812EC400", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1874F20", Offset = "0x1873F20", VA = "0x181874F20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7219110", Offset = "0x7218110", VA = "0x187219110", Slot = "8")]
	public bool Equals(IEEGMNGDKEC BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7219160", Offset = "0x7218160", VA = "0x187219160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class CKBFNHDCPIB<THasTokensTag> : GHEPLNMMAKJ, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Dictionary<Entity, IEEGMNGDKEC> DMLOOHMFPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Stack<HashSet<object>> ICPOOEICNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private HAFOFGMPBFH<IEEGMNGDKEC, HashSet<object>> ECDFINBGCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private EntityManager PFNOJANOPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private EntityCommandBufferSystem OMPMOFIICIH;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x218A210", Offset = "0x2189210", VA = "0x18218A210")]
	public CKBFNHDCPIB(EntityManager PFNOJANOPHC, EntityCommandBufferSystem OMPMOFIICIH, HPPHLHFLMDP GKJHLPLJKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2186CD0", Offset = "0x2185CD0", VA = "0x182186CD0", Slot = "4")]
	public bool BEHDBNFBJCF(Entity NNCCHIHKALO, object FFKJLIDBALM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x21877A0", Offset = "0x21867A0", VA = "0x1821877A0", Slot = "5")]
	public bool EJBGDPBKJGN(Entity NNCCHIHKALO, object FFKJLIDBALM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2189B70", Offset = "0x2188B70", VA = "0x182189B70", Slot = "6")]
	public bool OHNJIHPCMGF(Entity NNCCHIHKALO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2189E70", Offset = "0x2188E70", VA = "0x182189E70", Slot = "10")]
	public bool OHNJIHPCMGF(IEEGMNGDKEC DLOGIKEFHAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x21882E0", Offset = "0x21872E0", VA = "0x1821882E0", Slot = "7")]
	public IEnumerable<object> HKGLMFOBBGD(Entity NNCCHIHKALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2188880", Offset = "0x2187880", VA = "0x182188880", Slot = "11")]
	public IEnumerable<object> HKGLMFOBBGD(IEEGMNGDKEC DLOGIKEFHAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2188B40", Offset = "0x2187B40", VA = "0x182188B40", Slot = "8")]
	public bool HOEPOEDLGNC(Entity NNCCHIHKALO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x21876E0", Offset = "0x21866E0", VA = "0x1821876E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2187580", Offset = "0x2186580", VA = "0x182187580")]
	private void CILLNONKCLI(HashSet<object> PNCNPDFLBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x21897F0", Offset = "0x21887F0", VA = "0x1821897F0")]
	private bool LFOFFLPOALN(Entity NNCCHIHKALO, out IEEGMNGDKEC DLOGIKEFHAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2188FE0", Offset = "0x2187FE0", VA = "0x182188FE0")]
	private bool IBPNIOHJNHO(Entity NNCCHIHKALO, out IEEGMNGDKEC DLOGIKEFHAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2189680", Offset = "0x2188680", VA = "0x182189680")]
	private void JMKBEDPGIGH(Entity NNCCHIHKALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x21889C0", Offset = "0x21879C0", VA = "0x1821889C0")]
	private void HLFKBJJNJPI(Entity NNCCHIHKALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2187E30", Offset = "0x2186E30", VA = "0x182187E30")]
	private void FJFMEGHMHOI(Entity NNCCHIHKALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2188190", Offset = "0x2187190", VA = "0x182188190")]
	private void FLGLFOFPFIA(Entity NNCCHIHKALO, IEEGMNGDKEC DLOGIKEFHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2187310", Offset = "0x2186310", VA = "0x182187310")]
	private bool CHAIFEDHFHE(IEEGMNGDKEC DLOGIKEFHAN, out HashSet<object> PNCNPDFLBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x21895E0", Offset = "0x21885E0", VA = "0x1821895E0")]
	private HashSet<object> ICJOBHGDLLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class JDGCKOHIKJC
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void MHHINILOCKN(this HPPHLHFLMDP CGJPMMKJEHF, NativeArray<Entity> GLEBEEEMOOC, [Optional][CallerFilePath] string LONFBICOBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void MHHINILOCKN(this HPPHLHFLMDP CGJPMMKJEHF, string OALFIBFPPAC, NativeArray<Entity> GLEBEEEMOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void MHHINILOCKN(this HPPHLHFLMDP CGJPMMKJEHF, string LONFBICOBOG, NativeArray<Entity> GLEBEEEMOOC, bool CECBKJKJGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void AHGMNHIGGCI(this HPPHLHFLMDP CGJPMMKJEHF, NativeArray<Entity> GLEBEEEMOOC, EntityManager PFNOJANOPHC, [Optional][CallerFilePath] string LONFBICOBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void AHGMNHIGGCI(this HPPHLHFLMDP CGJPMMKJEHF, string LONFBICOBOG, NativeArray<Entity> GLEBEEEMOOC, EntityManager PFNOJANOPHC, bool CECBKJKJGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void KOEHBENDLNB(this HPPHLHFLMDP CGJPMMKJEHF, NativeArray<Entity> GLEBEEEMOOC, NativeArray<Entity> PMMHGJKNCFI, [Optional][CallerFilePath] string LONFBICOBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void KOEHBENDLNB(this HPPHLHFLMDP CGJPMMKJEHF, string LONFBICOBOG, NativeArray<Entity> GLEBEEEMOOC, NativeArray<Entity> PMMHGJKNCFI, bool CECBKJKJGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x25953C0", Offset = "0x25943C0", VA = "0x1825953C0")]
	public static void JACEFAGBILG<T>(this HPPHLHFLMDP CGJPMMKJEHF, string OALFIBFPPAC, NativeArray<Entity> GLEBEEEMOOC, NativeList<T> HHCEHFFEAKN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2595370", Offset = "0x2594370", VA = "0x182595370")]
	public static void JACEFAGBILG<T>(this HPPHLHFLMDP CGJPMMKJEHF, NativeArray<Entity> GLEBEEEMOOC, NativeArray<T> HHCEHFFEAKN, [Optional][CallerFilePath] string LONFBICOBOG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2595330", Offset = "0x2594330", VA = "0x182595330")]
	public static void JACEFAGBILG<T>(this HPPHLHFLMDP CGJPMMKJEHF, string OALFIBFPPAC, NativeArray<Entity> GLEBEEEMOOC, NativeArray<T> HHCEHFFEAKN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void JACEFAGBILG<T>(this HPPHLHFLMDP CGJPMMKJEHF, string LONFBICOBOG, NativeArray<Entity> GLEBEEEMOOC, NativeArray<T> HHCEHFFEAKN, bool CECBKJKJGNH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x25952A0", Offset = "0x25942A0", VA = "0x1825952A0")]
	public static void IKAKDDAPPNM<T>(this HPPHLHFLMDP CGJPMMKJEHF, NativeList<T> HHCEHFFEAKN, [Optional][CallerFilePath] string LONFBICOBOG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2595300", Offset = "0x2594300", VA = "0x182595300")]
	public static void IKAKDDAPPNM<T>(this HPPHLHFLMDP CGJPMMKJEHF, NativeArray<T> HHCEHFFEAKN, [Optional][CallerFilePath] string LONFBICOBOG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void IKAKDDAPPNM<T>(this HPPHLHFLMDP CGJPMMKJEHF, string LONFBICOBOG, NativeArray<T> HHCEHFFEAKN, bool CECBKJKJGNH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void GBPOHEPOMDN(this HPPHLHFLMDP CGJPMMKJEHF, EntityQuery JGNEONGLEIH, [Optional][CallerFilePath] string LONFBICOBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void GBPOHEPOMDN(this HPPHLHFLMDP CGJPMMKJEHF, string OALFIBFPPAC, EntityQuery JGNEONGLEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void GBPOHEPOMDN(this HPPHLHFLMDP CGJPMMKJEHF, string LONFBICOBOG, EntityQuery JGNEONGLEIH, bool CECBKJKJGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2595270", Offset = "0x2594270", VA = "0x182595270")]
	public static void HJCDDJJBAEE<T, T2>(this HPPHLHFLMDP CGJPMMKJEHF, string OALFIBFPPAC, EntityQuery JGNEONGLEIH) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	private static void HJCDDJJBAEE<T, T2>(this HPPHLHFLMDP CGJPMMKJEHF, string LONFBICOBOG, EntityQuery JGNEONGLEIH, bool CECBKJKJGNH) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2595270", Offset = "0x2594270", VA = "0x182595270")]
	public static void KLMNEFKCBDH<T>(this HPPHLHFLMDP CGJPMMKJEHF, string OALFIBFPPAC, NativeList<T> GJAKHOONFBO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void KLMNEFKCBDH<T>(this HPPHLHFLMDP CGJPMMKJEHF, string LONFBICOBOG, NativeList<T> GJAKHOONFBO, bool CECBKJKJGNH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2595270", Offset = "0x2594270", VA = "0x182595270")]
	public static void EOKJOCNIAOG<T>(this HPPHLHFLMDP CGJPMMKJEHF, string OALFIBFPPAC, NativeArray<T> GJAKHOONFBO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void EOKJOCNIAOG<T>(this HPPHLHFLMDP CGJPMMKJEHF, string LONFBICOBOG, NativeArray<T> GJAKHOONFBO, bool CECBKJKJGNH) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
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

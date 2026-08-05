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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E865C0", Offset = "0x6E857C0", VA = "0x186E865C0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NJEEECOKNOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class KBPLGFONBAJ<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] GHMJNPCJNAH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x30282E0", Offset = "0x30274E0", VA = "0x1830282E0")]
	public static void BFJFHEPABLB<TField>(int NNAODBDJDNJ, string JPKENOAMLIN, JHNBELMGFMH BOPEEAOLBPH, out LGOHODJFODN<TField> BGOCDAGKFNE) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3028550", Offset = "0x3027750", VA = "0x183028550")]
	public static void OLDJBAKGHFN<TField>(int NNAODBDJDNJ, string JPKENOAMLIN, out CPFKEJJKDHF<TField> LPNKBGEMCBF) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class HEPECJCOFIB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E867B0", Offset = "0x6E859B0", VA = "0x186E867B0")]
	public static FieldInfo[] FMLPAFKDELL(Type FBNKHAJKFLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class LHCIKCGJKLI<View, Data> : DCLNFEIOJHB where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType LKKCKNADAGP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type AJNFKCOHCED
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5516480", Offset = "0x5515680", VA = "0x185516480", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int OAFNEENIMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5516970", Offset = "0x5515B70", VA = "0x185516970", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5515810", Offset = "0x5514A10", VA = "0x185515810")]
	public Data EMCKMOGLEEH(Entity BLNICJMKCEF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5516900", Offset = "0x5515B00", VA = "0x185516900")]
	public Data KOPINBFFLLA(Entity BLNICJMKCEF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View LOABNIPDDML(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x302EC40", Offset = "0x302DE40", VA = "0x18302EC40", Slot = "14")]
	public override T LOABNIPDDML<T>(Entity BLNICJMKCEF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x21FF520", Offset = "0x21FE720", VA = "0x1821FF520")]
	protected LHCIKCGJKLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class DCLNFEIOJHB : JHNBELMGFMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle HEJEJPHFLIG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE38740", Offset = "0xE37940", VA = "0x180E38740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type AJNFKCOHCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int OAFNEENIMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type FLEJCHNLAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1B2B630", Offset = "0x1B2A830", VA = "0x181B2B630", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int JLNMKHMBMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E86420", Offset = "0x6E85620", VA = "0x186E86420", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private PLBLNCEJEDA[] PKCOGFHMHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x15D4390", Offset = "0x15D3590", VA = "0x1815D4390", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual PLBLNCEJEDA[] LHBAIFFNKCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E86290", Offset = "0x6E85490", VA = "0x186E86290", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E86490", Offset = "0x6E85690", VA = "0x186E86490")]
	public void KCEHONPEIFO(EntityManager NMHMIPEFENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T LOABNIPDDML<T>(Entity BLNICJMKCEF) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E86350", Offset = "0x6E85550", VA = "0x186E86350", Slot = "8")]
	public (uint, uint) HFLLCEAHCAL(Entity BLNICJMKCEF)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E861F0", Offset = "0x6E853F0", VA = "0x186E861F0", Slot = "9")]
	public bool COAGMNJHOFB(Entity BLNICJMKCEF, (uint order, uint change) KBIJDJHCEBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	protected DCLNFEIOJHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JJDOOCODKMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int MLHOBKJDKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private int BKHJHJOLNNF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HPFFKDDEMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC50", Offset = "0x15BCE50", VA = "0x1815BDC50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2454AF0", Offset = "0x2453CF0", VA = "0x182454AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LJMDFBLFDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int IBBPKBDNAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E86D10", Offset = "0x6E85F10", VA = "0x186E86D10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E86D20", Offset = "0x6E85F20", VA = "0x186E86D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A50", Offset = "0x8B5C50", VA = "0x1808B6A50")]
	private JJDOOCODKMA(int MLHOBKJDKGI, int BKHJHJOLNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x323D1B0", Offset = "0x323C3B0", VA = "0x18323D1B0")]
	public static JJDOOCODKMA FNPHHJMFDEN(int MLHOBKJDKGI, int BKHJHJOLNNF)
	{
		return default(JJDOOCODKMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E86D00", Offset = "0x6E85F00", VA = "0x186E86D00")]
	public static JJDOOCODKMA EDEOILGPCPP(int KACNNGPFBFG, int GLFOLGBEBEM)
	{
		return default(JJDOOCODKMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E86D30", Offset = "0x6E85F30", VA = "0x186E86D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AKKNOMNIDNP : DCJMLDOFHBP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x664CFB0", Offset = "0x664C1B0", VA = "0x18664CFB0")]
	public float DKJAIIGAJBI(in float3 NABCGCEIEGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x664CFB0", Offset = "0x664C1B0", VA = "0x18664CFB0", Slot = "4")]
	private float EMKCGLEAEDF(in float3 NABCGCEIEGG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct IKFMGJGNINJ : DCJMLDOFHBP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6653AE0", Offset = "0x6652CE0", VA = "0x186653AE0")]
	public float DKJAIIGAJBI(in float3 NABCGCEIEGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6653AE0", Offset = "0x6652CE0", VA = "0x186653AE0", Slot = "4")]
	private float EMKCGLEAEDF(in float3 NABCGCEIEGG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct FBMDLNMKOLO : DCJMLDOFHBP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x16FEBC0", Offset = "0x16FDDC0", VA = "0x1816FEBC0")]
	public float DKJAIIGAJBI(in float3 NABCGCEIEGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x16FEBC0", Offset = "0x16FDDC0", VA = "0x1816FEBC0", Slot = "4")]
	private float EMKCGLEAEDF(in float3 NABCGCEIEGG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BAEOCMCELDN : DCJMLDOFHBP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xCC0140", Offset = "0xCBF340", VA = "0x180CC0140")]
	public int DKJAIIGAJBI(in int3 NABCGCEIEGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xCC0140", Offset = "0xCBF340", VA = "0x180CC0140", Slot = "4")]
	private int HPMOGHLMGEJ(in int3 NABCGCEIEGG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HGMILBFPOMP : DCJMLDOFHBP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63544D0", Offset = "0x63536D0", VA = "0x1863544D0")]
	public int DKJAIIGAJBI(in int3 NABCGCEIEGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x63544D0", Offset = "0x63536D0", VA = "0x1863544D0", Slot = "4")]
	private int HPMOGHLMGEJ(in int3 NABCGCEIEGG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LIIKMLJOHNJ : DCJMLDOFHBP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xC01BF0", Offset = "0xC00DF0", VA = "0x180C01BF0")]
	public int DKJAIIGAJBI(in int3 NABCGCEIEGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xC01BF0", Offset = "0xC00DF0", VA = "0x180C01BF0", Slot = "4")]
	private int HPMOGHLMGEJ(in int3 NABCGCEIEGG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LECPACCGEBP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly byte[] JEDMILCBKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MemoryStream MHCBCKNNNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CodedOutputStream GLDNKGPNKDB;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E87430", Offset = "0x6E86630", VA = "0x186E87430", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
internal struct CIGFJJEBDAL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public ComponentDataFromEntity ACEGKBOGPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[ReadOnly]
	public NativeArray<Entity> BOMLLFOALBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeList<Entity> OEEAGFCAOKP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E86160", Offset = "0x6E85360", VA = "0x186E86160", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JGHJNNPEBKN
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E86A60", Offset = "0x6E85C60", VA = "0x186E86A60")]
	[KEGHNJHAGNJ]
	public static JobHandle GKMHJHELBLP(this EntityCommandBufferSystem FBICPICMEOC, NativeList<Entity> IBGFBPGPJKP, [Optional] JobHandle FOFFIFNKDII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E86BF0", Offset = "0x6E85DF0", VA = "0x186E86BF0")]
	[KEGHNJHAGNJ]
	public static JobHandle GKMHJHELBLP(this EntityCommandBufferSystem FBICPICMEOC, NativeArrayAsync<Entity> IBGFBPGPJKP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DCDNMABBMHI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1CC7EB0", Offset = "0x1CC70B0", VA = "0x181CC7EB0")]
	public static void LHEAOMNIBJB<T>(this EntityCommandBufferSystem FBICPICMEOC, EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1CC80B0", Offset = "0x1CC72B0", VA = "0x181CC80B0")]
	[KEGHNJHAGNJ]
	public static JobHandle PGKFNOKBAPP<T>(this EntityCommandBufferSystem FBICPICMEOC, NativeListAsync<Entity> IBGFBPGPJKP, [Optional] JobHandle FOFFIFNKDII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1CC7F20", Offset = "0x1CC7120", VA = "0x181CC7F20")]
	[KEGHNJHAGNJ]
	public static JobHandle PGKFNOKBAPP<T>(this EntityCommandBufferSystem FBICPICMEOC, NativeArrayAsync<Entity> IBGFBPGPJKP, [Optional] JobHandle FOFFIFNKDII)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JPFDINIDEFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct MHOMPHFGPPJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public NativeArray<Entity> PJEBHNGCFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NativeArray<T> HMKEDKHEIEH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct KMNPCDJPGPC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public NativeList<Entity> PJEBHNGCFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NativeArray<T> HMKEDKHEIEH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct DPCMIMEDBLD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NativeArrayAsync<Entity> PJEBHNGCFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NativeArrayAsync<T> HMKEDKHEIEH;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xF75930", Offset = "0xF74B30", VA = "0x180F75930")]
		public NativeListAsync<Entity> AIODCINPHKB<TPredicate>() where TPredicate : struct, HBMOGNJLPON<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1B388F0", Offset = "0x1B37AF0", VA = "0x181B388F0")]
	public static DPCMIMEDBLD<T> HJHLGCFOOPM<T>(this NativeArrayAsync<Entity> BOMLLFOALBE, NativeArrayAsync<T> NLPPJLIGDJN, Allocator KPFKDHLBOGB = Allocator.TempJob) where T : struct
	{
		return default(DPCMIMEDBLD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FOPPAKNPGFB : BILDCBEKACL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Type DDLAMCIMKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Type OBFMOHIHALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E866E0", Offset = "0x6E858E0", VA = "0x186E866E0")]
	public FOPPAKNPGFB(Type BDALGCMCDAK, Type ACEGKBOGPHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class KKOKAGOHICH
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MDKJIFLBMAF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D910", Offset = "0x3B9CB10", VA = "0x183B9D910")]
	public static NativeList<Entity> EEPFBIJKMFK<T>(this NativeArray<Entity> BOMLLFOALBE, EntityManager NMHMIPEFENM, Allocator KPFKDHLBOGB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JDPKNILJGNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly MemoryStream MHCBCKNNNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CodedInputStream LPLNIDNJNFK;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E86A20", Offset = "0x6E85C20", VA = "0x186E86A20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class PIPAEHHKKCD
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct EJOEBCIPMJB : DCJMLDOFHBP<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> GJPGMLLAPPD;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6E865B0", Offset = "0x6E857B0", VA = "0x186E865B0")]
		[BurstCompatible]
		public Entity DKJAIIGAJBI(in Entity NABCGCEIEGG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6E865B0", Offset = "0x6E857B0", VA = "0x186E865B0", Slot = "4")]
		private Entity IOPILCJDINO(in Entity NABCGCEIEGG)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HEGCOHPOOEN<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class BOIJHHPJJGF : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HEGCOHPOOEN<Protobuf> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1FE10", Offset = "0xA1F010", VA = "0x180A1FE10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2E6A3E0", Offset = "0x2E695E0", VA = "0x182E6A3E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1A49490", Offset = "0x1A48690", VA = "0x181A49490")]
		[DebuggerHidden]
		public BOIJHHPJJGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2E6A1E0", Offset = "0x2E693E0", VA = "0x182E6A1E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2E6A3A0", Offset = "0x2E695A0", VA = "0x182E6A3A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Action<Protobuf> MPDLMACNMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MemoryStream MHCBCKNNNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CodedInputStream LPLNIDNJNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Protobuf GBFIIPCAAGJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int CKAIEHNDOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8B2840", Offset = "0x8B1A40", VA = "0x1808B2840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2439820", Offset = "0x2438A20", VA = "0x182439820")]
	private HEGCOHPOOEN(byte[] JEDMILCBKJE, Action<Protobuf> MPDLMACNMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x20FE550", Offset = "0x20FD750", VA = "0x1820FE550")]
	public static HEGCOHPOOEN<Protobuf> JKAAGGANCJG<Data>(ReadOnlySpan<byte> CCBKAEHNCPH, ReadOnlySpan<Data> FBIMPHNMCAK, Action<Protobuf> MPDLMACNMOI)
	{
		return default(HEGCOHPOOEN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2439690", Offset = "0x2438890", VA = "0x182439690", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x24396D0", Offset = "0x24388D0", VA = "0x1824396D0", Slot = "4")]
	[IteratorStateMachine(typeof(HEGCOHPOOEN<>.BOIJHHPJJGF))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x24397D0", Offset = "0x24389D0", VA = "0x1824397D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class IDOKENEHHKM : JAGPBMEIJKO
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E869A0", Offset = "0x6E85BA0", VA = "0x186E869A0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase FGKBKPLMNKJ();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E86950", Offset = "0x6E85B50", VA = "0x186E86950")]
	protected ComponentSystemBase MIBEDDJMDAK(params ComponentSystemBase[] BLJLNGLFFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2185520", Offset = "0x2184720", VA = "0x182185520")]
	protected ComponentSystemBase MIBEDDJMDAK<T>(params ComponentSystemBase[] BLJLNGLFFBB) where T : JAGPBMEIJKO, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2185450", Offset = "0x2184650", VA = "0x182185450")]
	protected ComponentSystemBase PAIGEILIKGG<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2185450", Offset = "0x2184650", VA = "0x182185450")]
	protected ComponentSystemBase DNLBIFOPLLG<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E86900", Offset = "0x6E85B00", VA = "0x186E86900")]
	protected ComponentSystemBase GLAKADGPOIL(params SystemHandleUntyped[] BLJLNGLFFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2185490", Offset = "0x2184690", VA = "0x182185490")]
	protected ComponentSystemBase GLAKADGPOIL<T>(params SystemHandleUntyped[] BLJLNGLFFBB) where T : JAGPBMEIJKO, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2185400", Offset = "0x2184600", VA = "0x182185400")]
	protected SystemHandleUntyped BMALLKHMPLG<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E86730", Offset = "0x6E85930", VA = "0x186E86730")]
	protected IDOKENEHHKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class GBANKHHBHNJ
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E272F0", Offset = "0x1E264F0", VA = "0x181E272F0")]
	public static NativeList<T> GELBMKMJBGO<T>(NativeList<T> NLPPJLIGDJN, Allocator KPFKDHLBOGB) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class OEJDLAAOMCE
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct GBDJNAEOMHG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : DCJMLDOFHBP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> HMKEDKHEIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeList<TFrom> JCBPBACJNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeParallelHashSet<TTo> PNAKIENPNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap AMEKOPCKNIK;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct DLALDHALJKC<T, TPredicate> : IJob where T : struct where TPredicate : struct, HBMOGNJLPON<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<T> HMKEDKHEIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> PJEBHNGCFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeList<Entity> JAFLLPFENID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public TPredicate AMEKOPCKNIK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2C768F0", Offset = "0x2C75AF0", VA = "0x182C768F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct JHEGDNNJNDO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DCJMLDOFHBP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<TFrom> JGPJIPDNPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[WriteOnly]
	public NativeList<TTo> ANINOLKFICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public TMap AMEKOPCKNIK;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NGJGJFADPFD
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct KNFPGAGKDOB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly NativeArray<T>.ReadOnly LMFDNLBGHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int ILJCPGHFJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int NBFBEPFFGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private T HDHBMDFFMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private T HIKFJBBEHDB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public JJDOOCODKMA LPIPOABIENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x21C8F00", Offset = "0x21C8100", VA = "0x1821C8F00")]
			get
			{
				return default(JJDOOCODKMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T HBMCOPJLDLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x21C8EE0", Offset = "0x21C80E0", VA = "0x1821C8EE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (T, JJDOOCODKMA) JLCKGMHIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x37D6880", Offset = "0x37D5A80", VA = "0x1837D6880")]
			get
			{
				return default((T, JJDOOCODKMA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x37D6D20", Offset = "0x37D5F20", VA = "0x1837D6D20")]
		public KNFPGAGKDOB(NativeArray<T> LMFDNLBGHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B45810", Offset = "0x2B44A10", VA = "0x182B45810")]
		public KNFPGAGKDOB<T> EEOIHAEEMHN()
		{
			return default(KNFPGAGKDOB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x37D6B00", Offset = "0x37D5D00", VA = "0x1837D6B00")]
		public bool ECNCACELDMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x302D600", Offset = "0x302C800", VA = "0x18302D600")]
		public DGNCLKPIMPD<T, TComparer> HKFIKPKALDB<TComparer>([Optional] TComparer GMBHFLMLEHM) where TComparer : struct, IEqualityComparer<T>
		{
			return default(DGNCLKPIMPD<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct DGNCLKPIMPD<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly NativeArray<T>.ReadOnly LMFDNLBGHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int ILJCPGHFJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int NBFBEPFFGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T HDHBMDFFMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private T HIKFJBBEHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TComparer GMBHFLMLEHM;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public JJDOOCODKMA LPIPOABIENK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x21C8F00", Offset = "0x21C8100", VA = "0x1821C8F00")]
			get
			{
				return default(JJDOOCODKMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public T HBMCOPJLDLD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x21C8EE0", Offset = "0x21C80E0", VA = "0x1821C8EE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public (T value, JJDOOCODKMA range) JLCKGMHIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x21C8B70", Offset = "0x21C7D70", VA = "0x1821C8B70")]
			get
			{
				return default((T, JJDOOCODKMA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x21C8F10", Offset = "0x21C8110", VA = "0x1821C8F10")]
		public DGNCLKPIMPD(NativeArray<T>.ReadOnly LMFDNLBGHBA, TComparer GMBHFLMLEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x21C8EA0", Offset = "0x21C80A0", VA = "0x1821C8EA0")]
		public DGNCLKPIMPD<T, TComparer> EEOIHAEEMHN()
		{
			return default(DGNCLKPIMPD<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x21C8C40", Offset = "0x21C7E40", VA = "0x1821C8C40")]
		public bool ECNCACELDMB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x380F000", Offset = "0x380E200", VA = "0x18380F000")]
	public static KNFPGAGKDOB<T> MIBEDDJMDAK<T>(this NativeArray<T> LMFDNLBGHBA) where T : struct
	{
		return default(KNFPGAGKDOB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DCJMLDOFHBP<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo DKJAIIGAJBI(in TFrom NABCGCEIEGG);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BEPPKEGJPKP
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MLOCDLCJMAL
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JMLDNHHKNIP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public JMLDNHHKNIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class ALGNDNJNGDP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		public ALGNDNJNGDP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<Func<JobHandle, JobHandle>> IFHAMDBNLIA;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E87650", Offset = "0x6E86850", VA = "0x186E87650")]
	public MLOCDLCJMAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NPCDAFKAPAN
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class KFPLABIADMD : EntityCommandBufferSystem, EFDIBKMJCHI
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
	protected KFPLABIADMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LFLNGOIHKNL
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x19EF930", Offset = "0x19EEB30", VA = "0x1819EF930")]
	[KEGHNJHAGNJ]
	public static JobHandle EOMAAFCIGPK<T>(this EntityCommandBufferSystem FBICPICMEOC, NativeArray<Entity> IBGFBPGPJKP, NativeArray<T> JFGIPFOFKHL, JobHandle FOFFIFNKDII) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct HNMONNBCDAB<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<T> HMKEDKHEIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<T> JCBPBACJNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<T> PNAKIENPNBK;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x25820C0", Offset = "0x25812C0", VA = "0x1825820C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct KAFCIHGGFJL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> IBGFBPGPJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EntityCommandBuffer HEDKIIMNAJF;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E86DC0", Offset = "0x6E85FC0", VA = "0x186E86DC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class KEDGOECLNOK
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1CCE170", Offset = "0x1CCD370", VA = "0x181CCE170")]
	public static NativeArray<T> DNHMBBOKMEK<T>(this NativeList<Entity> NLPPJLIGDJN, EntityManager NMHMIPEFENM, Allocator KPFKDHLBOGB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1CCE220", Offset = "0x1CCD420", VA = "0x181CCE220")]
	public static NativeArray<T> DNHMBBOKMEK<T>(this NativeArray<Entity> NLPPJLIGDJN, EntityManager NMHMIPEFENM, Allocator KPFKDHLBOGB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface GKOKPGDLDNF
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class CEBEKACOFML
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal struct GCOAJEPCLJA<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> IBGFBPGPJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public T NABCGCEIEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public EntityCommandBuffer HEDKIIMNAJF;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3A90E70", Offset = "0x3A90070", VA = "0x183A90E70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class EHPGCMOFLKD
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xF13980", Offset = "0xF12B80", VA = "0x180F13980")]
	[KEGHNJHAGNJ]
	public static JobHandle KOCPFHJNCNF<T>(this EntityCommandBufferSystem FBICPICMEOC, EntityCommandBuffer HEDKIIMNAJF, EntityQuery JIAIANFJBDB, T NABCGCEIEGG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class LIOOCCCOOCC<Data> : HDGGNFNNNFC where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public virtual Data NBIAOCJLGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x13F2760", Offset = "0x13F1960", VA = "0x1813F2760", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1F22520", Offset = "0x1F21720", VA = "0x181F22520", Slot = "8")]
	protected virtual bool LJJDJGAKJMB(ReadOnlySpan<Data> FBIMPHNMCAK, NKGDHPLFPDK DJHOCJBGPEK, out ReadOnlySpan<byte> CCBKAEHNCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x929790", Offset = "0x928990", VA = "0x180929790", Slot = "9")]
	protected virtual bool HMKBPPPJBFA(int KBIJDJHCEBH, Span<Data> FBIMPHNMCAK, in ReadOnlySpan<byte> CCBKAEHNCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x29F78D0", Offset = "0x29F6AD0", VA = "0x1829F78D0", Slot = "5")]
	internal sealed override bool LJJDJGAKJMB(ref Unity.Entities.Chunk PEHGOEJDGEP, int ICOLAFBHLEJ, NKGDHPLFPDK DJHOCJBGPEK, out ReadOnlySpan<byte> CCBKAEHNCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x29F6120", Offset = "0x29F5320", VA = "0x1829F6120", Slot = "6")]
	internal sealed override bool HMKBPPPJBFA(int KBIJDJHCEBH, ref Unity.Entities.Chunk PEHGOEJDGEP, int ICOLAFBHLEJ, in ReadOnlySpan<byte> CCBKAEHNCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2366150", Offset = "0x2365350", VA = "0x182366150")]
	protected MLKEABCEECK<Protobuf> KKINMHNIANB<Protobuf>(ReadOnlySpan<Data> FBIMPHNMCAK) where Protobuf : IMessage, new()
	{
		return default(MLKEABCEECK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x23660C0", Offset = "0x23652C0", VA = "0x1823660C0")]
	protected HEGCOHPOOEN<Protobuf> CKBIAKADLDG<Protobuf>(ReadOnlySpan<byte> CCBKAEHNCPH, ReadOnlySpan<Data> FBIMPHNMCAK, Action<Protobuf> MPDLMACNMOI) where Protobuf : IMessage, new()
	{
		return default(HEGCOHPOOEN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x21FF520", Offset = "0x21FE720", VA = "0x1821FF520")]
	protected LIOOCCCOOCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class HDGGNFNNNFC
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected abstract int DGOHENJLBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6E86790", Offset = "0x6E85990", VA = "0x186E86790", Slot = "5")]
	internal virtual bool LJJDJGAKJMB(ref Unity.Entities.Chunk PEHGOEJDGEP, int ICOLAFBHLEJ, NKGDHPLFPDK DJHOCJBGPEK, out ReadOnlySpan<byte> CCBKAEHNCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x929790", Offset = "0x928990", VA = "0x180929790", Slot = "6")]
	internal virtual bool HMKBPPPJBFA(int KBIJDJHCEBH, ref Unity.Entities.Chunk PEHGOEJDGEP, int ICOLAFBHLEJ, in ReadOnlySpan<byte> CCBKAEHNCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	protected HDGGNFNNNFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CFLIFHMAIOB
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct PLAHBJFDCPD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct IFGNJFMPIEP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal PLAHBJFDCPD<TFrom> OJEMCPHOKBP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> LBIBKCFHCIL;
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct HIFJBOKOACK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public struct JBBHMPNDGJB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal HIFJBOKOACK<TFrom> OJEMCPHOKBP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> LBIBKCFHCIL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct CHBDBKCEOHM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public struct LHIPKGPDGBL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal CHBDBKCEOHM<TFrom> OJEMCPHOKBP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> LBIBKCFHCIL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct LONLBCBHMHD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public struct NFFPJONDOFM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal LONLBCBHMHD<TFrom> OJEMCPHOKBP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> LBIBKCFHCIL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct FIPCPOBHOJK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	public ComponentDataFromEntity KDFEGKDDLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	public NativeArray<Entity> HMKEDKHEIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[WriteOnly]
	public NativeArray<byte> ANINOLKFICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int LNKNEHIJKCB;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E865E0", Offset = "0x6E857E0", VA = "0x186E865E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[BurstCompile]
internal struct PGEHGPABCHP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ACEGKBOGPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[ReadOnly]
	public NativeArray<Entity> BOMLLFOALBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<bool> EKBMNBDIDDO;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal struct NGDAKEDIBBN<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[ReadOnly]
	public NativeArray<Entity> IBGFBPGPJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[ReadOnly]
	public NativeArray<T> DGPLNKPEMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public EntityCommandBuffer HEDKIIMNAJF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class BFPDDEJNPKJ
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2441F00", Offset = "0x2441100", VA = "0x182441F00")]
	public static NativeListAsync<Entity> OOKLNLPNDEF<T, TPredicate>(this NativeArrayAsync<T> NLPPJLIGDJN, NativeArrayAsync<Entity> BOMLLFOALBE, Allocator KPFKDHLBOGB = Allocator.TempJob) where T : struct where TPredicate : struct, HBMOGNJLPON<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2441D50", Offset = "0x2440F50", VA = "0x182441D50")]
	private static NativeListAsync<Entity> MKBEGDFGFAL<T, TPredicate>(NativeArrayAsync<T> JPMECENECHI, NativeArrayAsync<Entity> BOMLLFOALBE, int AAALINBAMFJ, Allocator KPFKDHLBOGB) where T : struct where TPredicate : struct, HBMOGNJLPON<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class KDOCJCHPGDJ
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCDFD0", Offset = "0x1CCD1D0", VA = "0x181CCDFD0")]
	[KEGHNJHAGNJ]
	public static JobHandle PCFEIGAGHIC<T>(this EntityCommandBufferSystem FBICPICMEOC, NativeArray<Entity> IBGFBPGPJKP, T NABCGCEIEGG, [Optional] JobHandle FOFFIFNKDII) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1CCE0A0", Offset = "0x1CCD2A0", VA = "0x181CCE0A0")]
	[KEGHNJHAGNJ]
	public static JobHandle PCFEIGAGHIC<T>(this EntityCommandBufferSystem FBICPICMEOC, EntityCommandBuffer HEDKIIMNAJF, NativeArray<Entity> IBGFBPGPJKP, T NABCGCEIEGG, [Optional] JobHandle FOFFIFNKDII) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class NKGDHPLFPDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> NAKHJNOLEKF;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x208FDB0", Offset = "0x208EFB0", VA = "0x18208FDB0")]
	public NKGDHPLFPDK(NativeArray<EntityRemapUtility.EntityRemapInfo> NAKHJNOLEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6E879D0", Offset = "0x6E86BD0", VA = "0x186E879D0")]
	public Entity EJAGNEFKCHH(Entity FGIADOJFAEB)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class JFCHDHKMMAE
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1B31BA0", Offset = "0x1B30DA0", VA = "0x181B31BA0")]
	public static NativeList<T> GELBMKMJBGO<T>(this NativeList<T> NLPPJLIGDJN, Allocator KPFKDHLBOGB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1B31C20", Offset = "0x1B30E20", VA = "0x181B31C20")]
	public static NativeList<T> GELBMKMJBGO<T>(this NativeArray<T> NLPPJLIGDJN, Allocator KPFKDHLBOGB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class CEOEMCFBKCE
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct AKOICNGOEKB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> HMKEDKHEIEH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct GBEGAAMAEHB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<T> HMKEDKHEIEH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct GEKGLFMCONI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<T> HMKEDKHEIEH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct COGOJAFNIIF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeListAsync<T> HMKEDKHEIEH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
internal struct PLACFKBABBA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DCJMLDOFHBP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeArray<TFrom> HMKEDKHEIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[WriteOnly]
	public NativeArray<TTo> ANINOLKFICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TMap AMEKOPCKNIK;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface HBMOGNJLPON<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AIODCINPHKB(T NABCGCEIEGG);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
internal struct KCNIHBPGKJO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	public NativeArray<Entity> IBGFBPGPJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public EntityCommandBuffer HEDKIIMNAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public ComponentTypes APJOFAMJHAH;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6E86E20", Offset = "0x6E86020", VA = "0x186E86E20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[BurstCompile]
internal struct ADGBBIOHAAF<T, TPredicate> : IJob where T : struct where TPredicate : struct, HBMOGNJLPON<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	public NativeArray<T> HMKEDKHEIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<T> JCBPBACJNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public TPredicate AMEKOPCKNIK;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class JAGPBMEIJKO : GIMHMHOIKPI
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6E869F0", Offset = "0x6E85BF0", VA = "0x186E869F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E86730", Offset = "0x6E85930", VA = "0x186E86730")]
	public JAGPBMEIJKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[BurstCompile]
internal struct JMONKNDJPJD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ACEGKBOGPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	public NativeArray<Entity> BOMLLFOALBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<bool> EKBMNBDIDDO;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x292F010", Offset = "0x292E210", VA = "0x18292F010", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct OBOIDBEHGBD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<Entity> IBGFBPGPJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	public NativeArray<T> JFGIPFOFKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public EntityCommandBuffer HEDKIIMNAJF;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D94E80", Offset = "0x2D94080", VA = "0x182D94E80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class LEJANNHFBBK
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6E875C0", Offset = "0x6E867C0", VA = "0x186E875C0")]
	public static ulong FGHKBBCNMJH(Type FBNKHAJKFLM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E87550", Offset = "0x6E86750", VA = "0x186E87550")]
	public static ulong FGHKBBCNMJH(string LKFBELAKGDK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class OHLCAKOBJLJ : BILDCBEKACL
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Type OBFMOHIHALC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x29562D0", Offset = "0x29554D0", VA = "0x1829562D0")]
	public OHLCAKOBJLJ(Type ACEGKBOGPHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[BurstCompile]
internal struct OGMCMLGMMAG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public ComponentDataFromEntity ACEGKBOGPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	public NativeArray<Entity> BOMLLFOALBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<Entity> OEEAGFCAOKP;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6E879E0", Offset = "0x6E86BE0", VA = "0x186E879E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public abstract class KNNEOPGGIBD : SystemBase, EFDIBKMJCHI
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6E87330", Offset = "0x6E86530", VA = "0x186E87330")]
	public ComponentDataFromEntity NGDPAJGJFFB(int CNBPDHPGPFI, bool JMPIAKIDPLJ = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E87400", Offset = "0x6E86600", VA = "0x186E87400")]
	public EntityExistenceLookupByEntity PJPEPMIAAAF()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E87420", Offset = "0x6E86620", VA = "0x186E87420", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8C2A40", Offset = "0x8C1C40", VA = "0x1808C2A40")]
	protected KNNEOPGGIBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class AFFEALIJNOO : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E85E60", Offset = "0x6E85060", VA = "0x186E85E60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8C2A40", Offset = "0x8C1C40", VA = "0x1808C2A40")]
	protected AFFEALIJNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class BDPCIHIKMJC
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct MLKEABCEECK<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly byte[] JEDMILCBKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Protobuf GBFIIPCAAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly MemoryStream MHCBCKNNNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly CodedOutputStream GLDNKGPNKDB;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8800", Offset = "0x3AB7A00", VA = "0x183AB8800")]
	private MLKEABCEECK(byte[] JEDMILCBKJE, in Protobuf GBFIIPCAAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x236D900", Offset = "0x236CB00", VA = "0x18236D900")]
	public static MLKEABCEECK<Protobuf> JKAAGGANCJG<T>(ReadOnlySpan<T> FBIMPHNMCAK)
	{
		return default(MLKEABCEECK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8740", Offset = "0x3AB7940", VA = "0x183AB8740")]
	public void FBNKAPOLDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8770", Offset = "0x3AB7970", VA = "0x183AB8770")]
	public ByteString PDFKDPENEKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8620", Offset = "0x3AB7820", VA = "0x183AB8620", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface EFDIBKMJCHI
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public abstract class GIMHMHOIKPI : ComponentSystemGroup, EFDIBKMJCHI
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E86730", Offset = "0x6E85930", VA = "0x186E86730")]
	protected GIMHMHOIKPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class LCLIGJIDIMO
{
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[BurstCompile]
internal struct JBAMOMDIHML<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JFEPIEFEIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public NativeArray<Entity> HMKEDKHEIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[WriteOnly]
	public NativeList<T> JCBPBACJNHP;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[Flags]
public enum GNGBDELHNDD
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
public class IPBFKBDDJKA : BILDCBEKACL
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8C2A40", Offset = "0x8C1C40", VA = "0x1808C2A40")]
	public IPBFKBDDJKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class NLCIDGNONNP
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public readonly struct AFHHKEINALF<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly NativeArray<TSrc> LMFDNLBGHBA;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x208D210", Offset = "0x208C410", VA = "0x18208D210")]
		public AFHHKEINALF(NativeArray<TSrc> LMFDNLBGHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xE6A190", Offset = "0xE69390", VA = "0x180E6A190")]
		public GNAAIBKACDA<TSrc, TValue> DLELCOJDDFP<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(GNAAIBKACDA<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct GNAAIBKACDA<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly NativeArray<TSrc> LMFDNLBGHBA;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x208D210", Offset = "0x208C410", VA = "0x18208D210")]
		public GNAAIBKACDA(NativeArray<TSrc> LMFDNLBGHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xE6A190", Offset = "0xE69390", VA = "0x180E6A190")]
		public EADHKJCCBGP<TSrc, TValue, TSelector> PBALIILNINH<TSelector>() where TSelector : struct, DCJMLDOFHBP<TSrc, TValue>
		{
			return default(EADHKJCCBGP<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct EADHKJCCBGP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DCJMLDOFHBP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly NativeArray<TSrc> LMFDNLBGHBA;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x208D210", Offset = "0x208C410", VA = "0x18208D210")]
		public EADHKJCCBGP(NativeArray<TSrc> LMFDNLBGHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C24920", Offset = "0x2C23B20", VA = "0x182C24920")]
		public PDGFILDMNCB<TSrc, TValue, TSelector> MIBEDDJMDAK()
		{
			return default(PDGFILDMNCB<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct CLCBCDEMCCH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, DCJMLDOFHBP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly NativeArray<TSrc> LMFDNLBGHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TSelector MNDCACPEAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int NNAODBDJDNJ;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TValue JLCKGMHIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x26B1510", Offset = "0x26B0710", VA = "0x1826B1510")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int BBOMBIMAMPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x99B8A0", Offset = "0x99AAA0", VA = "0x18099B8A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int CKAIEHNDOML
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x15BDD70", Offset = "0x15BCF70", VA = "0x1815BDD70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x26B16B0", Offset = "0x26B08B0", VA = "0x1826B16B0")]
		public CLCBCDEMCCH(NativeArray<TSrc> LMFDNLBGHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x26B1580", Offset = "0x26B0780", VA = "0x1826B1580")]
		public bool ECNCACELDMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x26B1590", Offset = "0x26B0790", VA = "0x1826B1590")]
		private TSrc FHMBBANJKKB(int LHPGLCOPMKK)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public struct PDGFILDMNCB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DCJMLDOFHBP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private CLCBCDEMCCH<TSrc, TValue, TSelector> LMCDAHACENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TValue HDHBMDFFMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int ILJCPGHFJPN;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public JJDOOCODKMA LPIPOABIENK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x2A24C30", Offset = "0x2A23E30", VA = "0x182A24C30")]
			get
			{
				return default(JJDOOCODKMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TValue HBMCOPJLDLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C20", Offset = "0x8C7E20", VA = "0x1808C8C20")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (TValue value, JJDOOCODKMA range) JLCKGMHIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2A24A30", Offset = "0x2A23C30", VA = "0x182A24A30")]
			get
			{
				return default((TValue, JJDOOCODKMA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A24C70", Offset = "0x2A23E70", VA = "0x182A24C70")]
		public PDGFILDMNCB(NativeArray<TSrc> LMFDNLBGHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x15BDA90", Offset = "0x15BCC90", VA = "0x1815BDA90")]
		public PDGFILDMNCB<TSrc, TValue, TSelector> EEOIHAEEMHN()
		{
			return default(PDGFILDMNCB<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A24B00", Offset = "0x2A23D00", VA = "0x182A24B00")]
		public bool ECNCACELDMB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x26EC6C0", Offset = "0x26EB8C0", VA = "0x1826EC6C0")]
	public static AFHHKEINALF<T> DEAIDJNGHLD<T>(this NativeList<T> MLEOGHHEJOI) where T : struct
	{
		return default(AFHHKEINALF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xE6A190", Offset = "0xE69390", VA = "0x180E6A190")]
	public static AFHHKEINALF<T> DEAIDJNGHLD<T>(this NativeArray<T> LMFDNLBGHBA) where T : struct
	{
		return default(AFHHKEINALF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class OJCEJIKICEO
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct EJPPJPGMDEN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct MBBJACPPIAH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public EJPPJPGMDEN<TFrom> LBIBKCFHCIL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NativeArray<TFrom> HMKEDKHEIEH;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct LPGNNHFJADN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public struct JNNACDJIBEM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public LPGNNHFJADN<TFrom> LBIBKCFHCIL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeArrayAsync<TFrom> HMKEDKHEIEH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct FNGPHPIHJEC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public struct PAPDOHFODHN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public FNGPHPIHJEC<TFrom> LBIBKCFHCIL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Allocator KPFKDHLBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NativeListAsync<TFrom> HMKEDKHEIEH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[BurstCompile]
internal struct PFBIGIBEBKN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	public NativeArray<Entity> IBGFBPGPJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public EntityCommandBuffer HEDKIIMNAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public ComponentType PKEBPHKAGGB;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6E87B50", Offset = "0x6E86D50", VA = "0x186E87B50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class FJPBFBFGOIH
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1E22C20", Offset = "0x1E21E20", VA = "0x181E22C20")]
	public static bool IGBMODCDDEJ<T>(this NativeArray<Entity> BOMLLFOALBE, EntityManager NMHMIPEFENM, Allocator KPFKDHLBOGB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class CMACDHAMADB
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class KHDNCDPLKOB
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class NJEGJCHLDEH
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public delegate void BHBGIEKKOCB<From, To>(From LBIBKCFHCIL, ref To GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK);

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private class BLIMPMLDAEC<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static BHBGIEKKOCB<From, To> CEDCBCGPECF;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public BLIMPMLDAEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6E876D0", Offset = "0x6E868D0", VA = "0x186E876D0")]
	static NJEGJCHLDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x26E9840", Offset = "0x26E8A40", VA = "0x1826E9840")]
	public static void OGJNDJLKPLP<T>(BHBGIEKKOCB<T, T> EDLCFGJKJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x26E92A0", Offset = "0x26E84A0", VA = "0x1826E92A0")]
	public static void OGJNDJLKPLP<From, To>(BHBGIEKKOCB<From, To> EDLCFGJKJHA, BHBGIEKKOCB<To, From> CGEPBMIEAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x26E9250", Offset = "0x26E8450", VA = "0x1826E9250")]
	public static void OGJNDJLKPLP<From, To>(BHBGIEKKOCB<From, To> CEDCBCGPECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3814930", Offset = "0x3813B30", VA = "0x183814930")]
	public static BHBGIEKKOCB<From, To> LGGKLPNFBOL<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3813AD0", Offset = "0x3812CD0", VA = "0x183813AD0")]
	public static void GPOHNMGDBID<From, To>(From LBIBKCFHCIL, ref To GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class BHGIABNIKII
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2443A50", Offset = "0x2442C50", VA = "0x182443A50")]
	[KEGHNJHAGNJ]
	public static JobHandle EBHMAJHNIOG<T>(this EntityCommandBufferSystem FBICPICMEOC, NativeArrayAsync<Entity> IBGFBPGPJKP, NativeArrayAsync<T> JFGIPFOFKHL, [Optional] JobHandle FOFFIFNKDII) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2443CC0", Offset = "0x2442EC0", VA = "0x182443CC0")]
	[KEGHNJHAGNJ]
	public static JobHandle EBHMAJHNIOG<T>(this EntityCommandBufferSystem FBICPICMEOC, NativeArrayAsync<Entity> IBGFBPGPJKP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2443BA0", Offset = "0x2442DA0", VA = "0x182443BA0")]
	[KEGHNJHAGNJ]
	public static JobHandle EBHMAJHNIOG<T>(this EntityCommandBufferSystem FBICPICMEOC, NativeArray<Entity> IBGFBPGPJKP, [Optional] JobHandle FOFFIFNKDII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6E85E90", Offset = "0x6E85090", VA = "0x186E85E90")]
	[KEGHNJHAGNJ]
	public static JobHandle EBHMAJHNIOG(this EntityCommandBufferSystem FBICPICMEOC, NativeArray<Entity> IBGFBPGPJKP, ComponentTypes APJOFAMJHAH, [Optional] JobHandle FOFFIFNKDII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6E86000", Offset = "0x6E85200", VA = "0x186E86000")]
	[KEGHNJHAGNJ]
	public static JobHandle EBHMAJHNIOG(this EntityCommandBufferSystem FBICPICMEOC, EntityCommandBuffer HEDKIIMNAJF, NativeArray<Entity> IBGFBPGPJKP, ComponentTypes APJOFAMJHAH, [Optional] JobHandle FOFFIFNKDII)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class KMPMIEOLEJD
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6E87170", Offset = "0x6E86370", VA = "0x186E87170")]
	private unsafe static Span<byte> PBHPKLCHNHA(Unity.Entities.Chunk* PEHGOEJDGEP, int ICOLAFBHLEJ)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1CE24D0", Offset = "0x1CE16D0", VA = "0x181CE24D0")]
	public unsafe static Span<T> PFFLFMGPCOL<T>(Unity.Entities.Chunk* PEHGOEJDGEP, int ICOLAFBHLEJ)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x19E22A0", Offset = "0x19E14A0", VA = "0x1819E22A0")]
	public static Span<T> PFFLFMGPCOL<T>(this ref Unity.Entities.Chunk PEHGOEJDGEP, int ICOLAFBHLEJ)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6E87100", Offset = "0x6E86300", VA = "0x186E87100")]
	public unsafe static Span<Entity> OMMEJDGFJDC(Unity.Entities.Chunk* PEHGOEJDGEP)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6E86E80", Offset = "0x6E86080", VA = "0x186E86E80")]
	public unsafe static void HNOBOGMOMNO(Unity.Entities.Chunk* PEHGOEJDGEP, int ICOLAFBHLEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[AttributeUsage(AttributeTargets.Class)]
public class LMEPOJGEOJO : BILDCBEKACL
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8C2A40", Offset = "0x8C1C40", VA = "0x1808C2A40")]
	public LMEPOJGEOJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface AOJDBHGLIIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HMIDCMINBGC(Entity BLNICJMKCEF, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKANJCBKJEC(Entity BLNICJMKCEF, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BODJOIHIKDN(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EHJHAINDFPM(Entity BLNICJMKCEF);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class FEFNNKAJBMA<TComponentData, TValue> : FHHKGGGPNKC<TValue>, IDisposable where TComponentData : struct, GDNHGAGIENF
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class DPDBOBFABMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private List<(object token, TValue value)> MLEOGHHEJOI;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int JKNHGEMPCNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1BC1560", Offset = "0x1BC0760", VA = "0x181BC1560")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B2F0", Offset = "0x2C7A4F0", VA = "0x182C7B2F0")]
		public bool IAOJOAOFJFM(out TValue NABCGCEIEGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B1C0", Offset = "0x2C7A3C0", VA = "0x182C7B1C0")]
		public void CKPKOIJGHLD(object FDCOCHLAHJD, TValue NABCGCEIEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B270", Offset = "0x2C7A470", VA = "0x182C7B270")]
		public bool HCICIMHFKFM(object FDCOCHLAHJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B3B0", Offset = "0x2C7A5B0", VA = "0x182C7B3B0")]
		public int KCFKECEKLJA(object FDCOCHLAHJD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B460", Offset = "0x2C7A660", VA = "0x182C7B460")]
		public DPDBOBFABMG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly Stack<DPDBOBFABMG> HBJLGJIIDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private HGANPBCHOHB<PCJNFDJKBDM, DPDBOBFABMG> OFAGPNHANEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private EntityManager NMHMIPEFENM;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B850", Offset = "0x1C6AA50", VA = "0x181C6B850")]
	public FEFNNKAJBMA(EntityManager NMHMIPEFENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B360", Offset = "0x1C6A560", VA = "0x181C6B360", Slot = "4")]
	public void HMIDCMINBGC(Entity BLNICJMKCEF, object FDCOCHLAHJD, TValue NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B640", Offset = "0x1C6A840", VA = "0x181C6B640", Slot = "5")]
	public bool PKANJCBKJEC(Entity BLNICJMKCEF, object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B480", Offset = "0x1C6A680", VA = "0x181C6B480", Slot = "6")]
	public bool IAOJOAOFJFM(Entity BLNICJMKCEF, out TValue NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B270", Offset = "0x1C6A470", VA = "0x181C6B270", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B7D0", Offset = "0x1C6A9D0", VA = "0x181C6B7D0")]
	private void PKHGINJAOJO(DPDBOBFABMG OEJGCHGMMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B290", Offset = "0x1C6A490", VA = "0x181C6B290")]
	private bool FDCNBMMJGFH(Entity BLNICJMKCEF, out PCJNFDJKBDM EMCKGOPIABN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B1E0", Offset = "0x1C6A3E0", VA = "0x181C6B1E0")]
	private void BCCACODONPG(Entity BLNICJMKCEF, PCJNFDJKBDM EMCKGOPIABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B620", Offset = "0x1C6A820", VA = "0x181C6B620")]
	private bool OOBAGMHANBO(PCJNFDJKBDM EMCKGOPIABN, out DPDBOBFABMG OEJGCHGMMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B550", Offset = "0x1C6A750", VA = "0x181C6B550")]
	private DPDBOBFABMG LLFGJMOJMGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface FHHKGGGPNKC<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMIDCMINBGC(Entity BLNICJMKCEF, object FDCOCHLAHJD, TValue NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKANJCBKJEC(Entity BLNICJMKCEF, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IAOJOAOFJFM(Entity BLNICJMKCEF, out TValue NABCGCEIEGG);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface GDNHGAGIENF : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	PCJNFDJKBDM HICMPCHIMDF
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
public struct PCJNFDJKBDM : GBHJAOJCEHA, IEquatable<PCJNFDJKBDM>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly PCJNFDJKBDM MOBOMNFBKHP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	[CreateProperty]
	public int BBOMBIMAMPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	[CreateProperty]
	public int DGOHENJLBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC50", Offset = "0x15BCE50", VA = "0x1815BDC50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2454AF0", Offset = "0x2453CF0", VA = "0x182454AF0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E87A70", Offset = "0x6E86C70", VA = "0x186E87A70", Slot = "8")]
	public bool Equals(PCJNFDJKBDM JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6E87AC0", Offset = "0x6E86CC0", VA = "0x186E87AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class LDMKCLHFENF<THasTokensTag> : AOJDBHGLIIG, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Dictionary<Entity, PCJNFDJKBDM> GBKGNAAAKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Stack<HashSet<object>> HBJLGJIIDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private HGANPBCHOHB<PCJNFDJKBDM, HashSet<object>> OFAGPNHANEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private EntityManager NMHMIPEFENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private EntityCommandBufferSystem FBICPICMEOC;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2C43700", Offset = "0x2C42900", VA = "0x182C43700")]
	public LDMKCLHFENF(EntityManager NMHMIPEFENM, EntityCommandBufferSystem FBICPICMEOC, PEKDFCFCENH ALPAPAHANNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2C42320", Offset = "0x2C41520", VA = "0x182C42320", Slot = "4")]
	public bool HMIDCMINBGC(Entity BLNICJMKCEF, object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2C42C00", Offset = "0x2C41E00", VA = "0x182C42C00", Slot = "5")]
	public bool PKANJCBKJEC(Entity BLNICJMKCEF, object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2C40A10", Offset = "0x2C3FC10", VA = "0x182C40A10", Slot = "6")]
	public bool BODJOIHIKDN(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C40A90", Offset = "0x2C3FC90", VA = "0x182C40A90", Slot = "9")]
	public bool BODJOIHIKDN(PCJNFDJKBDM EMCKGOPIABN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C413A0", Offset = "0x2C405A0", VA = "0x182C413A0", Slot = "7")]
	public bool EHJHAINDFPM(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C40DD0", Offset = "0x2C3FFD0", VA = "0x182C40DD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2C43290", Offset = "0x2C42490", VA = "0x182C43290")]
	private void PKHGINJAOJO(HashSet<object> OEJGCHGMMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2C41760", Offset = "0x2C40960", VA = "0x182C41760")]
	private bool FDCNBMMJGFH(Entity BLNICJMKCEF, out PCJNFDJKBDM EMCKGOPIABN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2C40E50", Offset = "0x2C40050", VA = "0x182C40E50")]
	private bool EHAGHEHBBDP(Entity BLNICJMKCEF, out PCJNFDJKBDM EMCKGOPIABN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2C42A20", Offset = "0x2C41C20", VA = "0x182C42A20")]
	private void PGIBOAPOEKB(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2C43370", Offset = "0x2C42570", VA = "0x182C43370")]
	private void PPDIKJLDCJP(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2C42480", Offset = "0x2C41680", VA = "0x182C42480")]
	private void INNCONGNDGJ(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2C407B0", Offset = "0x2C3F9B0", VA = "0x182C407B0")]
	private void BCCACODONPG(Entity BLNICJMKCEF, PCJNFDJKBDM EMCKGOPIABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2C41CE0", Offset = "0x2C40EE0", VA = "0x182C41CE0")]
	private bool FGECHNKJIPG(PCJNFDJKBDM EMCKGOPIABN, out HashSet<object> OEJGCHGMMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2C427A0", Offset = "0x2C419A0", VA = "0x182C427A0")]
	private HashSet<object> LLFGJMOJMGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class HOIJCLIKOFO
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void EJCDPANBCJI(this PEKDFCFCENH LHCMKIAHBCL, NativeArray<Entity> IBGFBPGPJKP, [Optional][CallerFilePath] string EEMDLEAHCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void EJCDPANBCJI(this PEKDFCFCENH LHCMKIAHBCL, string JPKENOAMLIN, NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void EJCDPANBCJI(this PEKDFCFCENH LHCMKIAHBCL, string EEMDLEAHCMG, NativeArray<Entity> IBGFBPGPJKP, bool EEAKFAFPNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void BJKMNBIBOLE(this PEKDFCFCENH LHCMKIAHBCL, NativeArray<Entity> IBGFBPGPJKP, EntityManager NMHMIPEFENM, [Optional][CallerFilePath] string EEMDLEAHCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void BJKMNBIBOLE(this PEKDFCFCENH LHCMKIAHBCL, string EEMDLEAHCMG, NativeArray<Entity> IBGFBPGPJKP, EntityManager NMHMIPEFENM, bool EEAKFAFPNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void MIEAMFPANAB(this PEKDFCFCENH LHCMKIAHBCL, NativeArray<Entity> IBGFBPGPJKP, NativeArray<Entity> AEILOOJABFG, [Optional][CallerFilePath] string EEMDLEAHCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void MIEAMFPANAB(this PEKDFCFCENH LHCMKIAHBCL, string EEMDLEAHCMG, NativeArray<Entity> IBGFBPGPJKP, NativeArray<Entity> AEILOOJABFG, bool EEAKFAFPNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x217D1B0", Offset = "0x217C3B0", VA = "0x18217D1B0")]
	public static void KGAKPOHPEJN<T>(this PEKDFCFCENH LHCMKIAHBCL, string JPKENOAMLIN, NativeArray<Entity> IBGFBPGPJKP, NativeList<T> JFGIPFOFKHL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x217D160", Offset = "0x217C360", VA = "0x18217D160")]
	public static void KGAKPOHPEJN<T>(this PEKDFCFCENH LHCMKIAHBCL, NativeArray<Entity> IBGFBPGPJKP, NativeArray<T> JFGIPFOFKHL, [Optional][CallerFilePath] string EEMDLEAHCMG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x217D120", Offset = "0x217C320", VA = "0x18217D120")]
	public static void KGAKPOHPEJN<T>(this PEKDFCFCENH LHCMKIAHBCL, string JPKENOAMLIN, NativeArray<Entity> IBGFBPGPJKP, NativeArray<T> JFGIPFOFKHL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void KGAKPOHPEJN<T>(this PEKDFCFCENH LHCMKIAHBCL, string EEMDLEAHCMG, NativeArray<Entity> IBGFBPGPJKP, NativeArray<T> JFGIPFOFKHL, bool EEAKFAFPNPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x217D090", Offset = "0x217C290", VA = "0x18217D090")]
	public static void HPDOIBHMHHC<T>(this PEKDFCFCENH LHCMKIAHBCL, NativeList<T> JFGIPFOFKHL, [Optional][CallerFilePath] string EEMDLEAHCMG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x217D0F0", Offset = "0x217C2F0", VA = "0x18217D0F0")]
	public static void HPDOIBHMHHC<T>(this PEKDFCFCENH LHCMKIAHBCL, NativeArray<T> JFGIPFOFKHL, [Optional][CallerFilePath] string EEMDLEAHCMG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void HPDOIBHMHHC<T>(this PEKDFCFCENH LHCMKIAHBCL, string EEMDLEAHCMG, NativeArray<T> JFGIPFOFKHL, bool EEAKFAFPNPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void MDGEFOAIBIB(this PEKDFCFCENH LHCMKIAHBCL, EntityQuery JIAIANFJBDB, [Optional][CallerFilePath] string EEMDLEAHCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void MDGEFOAIBIB(this PEKDFCFCENH LHCMKIAHBCL, string JPKENOAMLIN, EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void MDGEFOAIBIB(this PEKDFCFCENH LHCMKIAHBCL, string EEMDLEAHCMG, EntityQuery JIAIANFJBDB, bool EEAKFAFPNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x217D060", Offset = "0x217C260", VA = "0x18217D060")]
	public static void LKALDCAHLMG<T, T2>(this PEKDFCFCENH LHCMKIAHBCL, string JPKENOAMLIN, EntityQuery JIAIANFJBDB) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void LKALDCAHLMG<T, T2>(this PEKDFCFCENH LHCMKIAHBCL, string EEMDLEAHCMG, EntityQuery JIAIANFJBDB, bool EEAKFAFPNPD) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x217D060", Offset = "0x217C260", VA = "0x18217D060")]
	public static void DDOAEGCNGJO<T>(this PEKDFCFCENH LHCMKIAHBCL, string JPKENOAMLIN, NativeList<T> LMFDNLBGHBA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void DDOAEGCNGJO<T>(this PEKDFCFCENH LHCMKIAHBCL, string EEMDLEAHCMG, NativeList<T> LMFDNLBGHBA, bool EEAKFAFPNPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x217D060", Offset = "0x217C260", VA = "0x18217D060")]
	public static void JDOKPHEBLGE<T>(this PEKDFCFCENH LHCMKIAHBCL, string JPKENOAMLIN, NativeArray<T> LMFDNLBGHBA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public static void JDOKPHEBLGE<T>(this PEKDFCFCENH LHCMKIAHBCL, string EEMDLEAHCMG, NativeArray<T> LMFDNLBGHBA, bool EEAKFAFPNPD) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class MDBJHPDEIOP
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public MDBJHPDEIOP()
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

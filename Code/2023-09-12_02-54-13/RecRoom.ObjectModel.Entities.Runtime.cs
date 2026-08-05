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
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
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
		[Cpp2IlInjected.Address(RVA = "0x7135E90", Offset = "0x7135290", VA = "0x187135E90")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KALFHDDHNDD
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class ANHGAFCFNJJ<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] PDNNLEIFHFG;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2318D30", Offset = "0x2318130", VA = "0x182318D30")]
	public static void JBAJEDOHDEP<TField>(int BNOAGGNAMKG, string GDKOBCHHFLB, LFHCENHMBCH HCOGCOOEIEP, out DFGKOFELELE<TField> LEMJCNJPDLJ) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2316BE0", Offset = "0x2315FE0", VA = "0x182316BE0")]
	public static void FDKJACHAEJO<TField>(int BNOAGGNAMKG, string GDKOBCHHFLB, out ENIPADEGOMD<TField> OCFGMKDOPDP) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class OOECCEDNONE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7136510", Offset = "0x7135910", VA = "0x187136510")]
	public static FieldInfo[] BHKPKHGKKHM(Type GANFKPHKNKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class EICCPBGMOMN<View, Data> : CMCADLOKOGK where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType OOMINBLBOCF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type ICNKMGDBELH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3A2EE30", Offset = "0x3A2E230", VA = "0x183A2EE30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int OEBBNLFJOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B75F50", Offset = "0x2B75350", VA = "0x182B75F50", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B769E0", Offset = "0x2B75DE0", VA = "0x182B769E0")]
	public Data FPFCLJOBNLF(Entity GKMECPLEALF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B76010", Offset = "0x2B75410", VA = "0x182B76010")]
	public Data BIIOLCDDLHF(Entity GKMECPLEALF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View MDMDMEMIHOB(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x426CDB0", Offset = "0x426C1B0", VA = "0x18426CDB0", Slot = "14")]
	public override T MDMDMEMIHOB<T>(Entity GKMECPLEALF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6C80", Offset = "0x1CA6080", VA = "0x181CA6C80")]
	protected EICCPBGMOMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class CMCADLOKOGK : LFHCENHMBCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle MPDOACJPLKK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEE8340", Offset = "0xEE7740", VA = "0x180EE8340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type ICNKMGDBELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int OEBBNLFJOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type GGMPPOJBHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2B40", Offset = "0x1BA1F40", VA = "0x181BA2B40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int FDDGIEOMCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x71359A0", Offset = "0x7134DA0", VA = "0x1871359A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private KEJDGFDNFFK[] GAAFFKHIADA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x159D8A0", Offset = "0x159CCA0", VA = "0x18159D8A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual KEJDGFDNFFK[] AELEPOEPMJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x71356F0", Offset = "0x7134AF0", VA = "0x1871356F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7135880", Offset = "0x7134C80", VA = "0x187135880")]
	public void MHIDNOPDKCM(EntityManager BEBIJONEMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T MDMDMEMIHOB<T>(Entity GKMECPLEALF) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x71357B0", Offset = "0x7134BB0", VA = "0x1871357B0", Slot = "8")]
	public (uint, uint) LENCHPICOIF(Entity GKMECPLEALF)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7135650", Offset = "0x7134A50", VA = "0x187135650", Slot = "9")]
	public bool AMNIIBHEDHA(Entity GKMECPLEALF, (uint order, uint change) LJJHJABONIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	protected CMCADLOKOGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct EEMOBOLLAKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int AEHKIMOEIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private int FJFMKNIHPDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ENIJHDDIJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x176BAF0", Offset = "0x176AEF0", VA = "0x18176BAF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2954C40", Offset = "0x2954040", VA = "0x182954C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DFBHDMGEPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int NPJNKCPHLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7135DD0", Offset = "0x71351D0", VA = "0x187135DD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7135DE0", Offset = "0x71351E0", VA = "0x187135DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xAEEC80", Offset = "0xAEE080", VA = "0x180AEEC80")]
	private EEMOBOLLAKL(int AEHKIMOEIJL, int FJFMKNIHPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2D93C30", Offset = "0x2D93030", VA = "0x182D93C30")]
	public static EEMOBOLLAKL LOMMHLPLEBJ(int AEHKIMOEIJL, int FJFMKNIHPDJ)
	{
		return default(EEMOBOLLAKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7135DF0", Offset = "0x71351F0", VA = "0x187135DF0")]
	public static EEMOBOLLAKL NADICACJDDI(int OANIJIEMEHN, int ELBJBJNOEIJ)
	{
		return default(EEMOBOLLAKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7135E00", Offset = "0x7135200", VA = "0x187135E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AFMEKFJJNPN : APLPGNLHJBF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6836D20", Offset = "0x6836120", VA = "0x186836D20")]
	public float EGDPOBLMKNF(in float3 AGLCIEKHLEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6836D20", Offset = "0x6836120", VA = "0x186836D20", Slot = "4")]
	private float ILACHPNCCEP(in float3 AGLCIEKHLEE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OPIDGEKOMOP : APLPGNLHJBF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6832620", Offset = "0x6831A20", VA = "0x186832620")]
	public float EGDPOBLMKNF(in float3 AGLCIEKHLEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6832620", Offset = "0x6831A20", VA = "0x186832620", Slot = "4")]
	private float ILACHPNCCEP(in float3 AGLCIEKHLEE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IAPGMGMKKKF : APLPGNLHJBF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x175BB50", Offset = "0x175AF50", VA = "0x18175BB50")]
	public float EGDPOBLMKNF(in float3 AGLCIEKHLEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x175BB50", Offset = "0x175AF50", VA = "0x18175BB50", Slot = "4")]
	private float ILACHPNCCEP(in float3 AGLCIEKHLEE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct OMCAHBGDFLO : APLPGNLHJBF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9A40", VA = "0x180BEA640")]
	public int EGDPOBLMKNF(in int3 AGLCIEKHLEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9A40", VA = "0x180BEA640", Slot = "4")]
	private int MHNNHHCFFMA(in int3 AGLCIEKHLEE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DKAFCGBKNPI : APLPGNLHJBF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x65AA070", Offset = "0x65A9470", VA = "0x1865AA070")]
	public int EGDPOBLMKNF(in int3 AGLCIEKHLEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x65AA070", Offset = "0x65A9470", VA = "0x1865AA070", Slot = "4")]
	private int MHNNHHCFFMA(in int3 AGLCIEKHLEE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FDMLPAHIGFE : APLPGNLHJBF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x9D28D0", Offset = "0x9D1CD0", VA = "0x1809D28D0")]
	public int EGDPOBLMKNF(in int3 AGLCIEKHLEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x9D28D0", Offset = "0x9D1CD0", VA = "0x1809D28D0", Slot = "4")]
	private int MHNNHHCFFMA(in int3 AGLCIEKHLEE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FBKIJKHNHHA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly byte[] BCGCPPBLPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MemoryStream ICGCONBOMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CodedOutputStream HDAIEAFAGED;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7135EB0", Offset = "0x71352B0", VA = "0x187135EB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
internal struct CJIHPLONAEF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public ComponentDataFromEntity EFDPHMAFPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[ReadOnly]
	public NativeArray<Entity> MEHONAIFBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeList<Entity> CJJCANJBPFE;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x71355C0", Offset = "0x71349C0", VA = "0x1871355C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PDNDIPNHNNO
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7136F70", Offset = "0x7136370", VA = "0x187136F70")]
	[PFCFPONLICD]
	public static JobHandle MNKKLHLCJLF(this EntityCommandBufferSystem ICHBDANIEME, NativeList<Entity> NOEOKDNGNCK, [Optional] JobHandle BMMIBMDGEID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7137100", Offset = "0x7136500", VA = "0x187137100")]
	[PFCFPONLICD]
	public static JobHandle MNKKLHLCJLF(this EntityCommandBufferSystem ICHBDANIEME, NativeArrayAsync<Entity> NOEOKDNGNCK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EAAINIAJMPM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2239CC0", Offset = "0x22390C0", VA = "0x182239CC0")]
	public static void GDNPGAKPLPN<T>(this EntityCommandBufferSystem ICHBDANIEME, EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2239ED0", Offset = "0x22392D0", VA = "0x182239ED0")]
	[PFCFPONLICD]
	public static JobHandle MGNKHOGODIL<T>(this EntityCommandBufferSystem ICHBDANIEME, NativeListAsync<Entity> NOEOKDNGNCK, [Optional] JobHandle BMMIBMDGEID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2239D40", Offset = "0x2239140", VA = "0x182239D40")]
	[PFCFPONLICD]
	public static JobHandle MGNKHOGODIL<T>(this EntityCommandBufferSystem ICHBDANIEME, NativeArrayAsync<Entity> NOEOKDNGNCK, [Optional] JobHandle BMMIBMDGEID)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IDHIKLAIKMH
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct JDOCGPJBLFL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public NativeArray<Entity> CNNHDDIKMCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NativeArray<T> NOIHCELINAP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct NEIIKNLKIBC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public NativeList<Entity> CNNHDDIKMCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NativeArray<T> NOIHCELINAP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct MIHIADAPLEP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NativeArrayAsync<Entity> CNNHDDIKMCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NativeArrayAsync<T> NOIHCELINAP;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2DE0", Offset = "0x1BC21E0", VA = "0x181BC2DE0")]
		public NativeListAsync<Entity> DJEDHDKNJHJ<TPredicate>() where TPredicate : struct, HDPFBKINIJO<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x227F840", Offset = "0x227EC40", VA = "0x18227F840")]
	public static MIHIADAPLEP<T> NEOAPPIJFOO<T>(this NativeArrayAsync<Entity> MEHONAIFBIF, NativeArrayAsync<T> MBOAMKIIHKG, Allocator DGGNDNPDKKD = Allocator.TempJob) where T : struct
	{
		return default(MIHIADAPLEP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EBDMOIPALJL : HFNAELOJHJC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Type OCGKLMALPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Type MCPHNLGOKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7135D80", Offset = "0x7135180", VA = "0x187135D80")]
	public EBDMOIPALJL(Type BGJNCELOPOM, Type EFDPHMAFPCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MEHMDPCJLOP
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LOGOEDONNEG
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x238B000", Offset = "0x238A400", VA = "0x18238B000")]
	public static NativeList<Entity> CJAOPAEMLJD<T>(this NativeArray<Entity> MEHONAIFBIF, EntityManager BEBIJONEMLA, Allocator DGGNDNPDKKD = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CJIHJAJCELJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly MemoryStream ICGCONBOMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CodedInputStream KCMGFBLOLLG;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7135580", Offset = "0x7134980", VA = "0x187135580", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GJKPJIOHNHP
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct MGNMNKLAHNN : APLPGNLHJBF<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> DOJAGJPNBFL;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7136400", Offset = "0x7135800", VA = "0x187136400")]
		[BurstCompatible]
		public Entity EGDPOBLMKNF(in Entity AGLCIEKHLEE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7136400", Offset = "0x7135800", VA = "0x187136400", Slot = "4")]
		private Entity NAOKECJHLEH(in Entity AGLCIEKHLEE)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct BANOPIMHDDH<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PBCPKCMLJFA : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BANOPIMHDDH<Protobuf> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9D48A0", Offset = "0x9D3CA0", VA = "0x1809D48A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x338FDD0", Offset = "0x338F1D0", VA = "0x18338FDD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x19DEBC0", Offset = "0x19DDFC0", VA = "0x1819DEBC0")]
		[DebuggerHidden]
		public PBCPKCMLJFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x338FBD0", Offset = "0x338EFD0", VA = "0x18338FBD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x338FD90", Offset = "0x338F190", VA = "0x18338FD90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Action<Protobuf> ENLDDMOKEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MemoryStream ICGCONBOMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CodedInputStream KCMGFBLOLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Protobuf ONMAPMKGDAJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int NMCJNDHCAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA0C050", Offset = "0xA0B450", VA = "0x180A0C050")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x40CAD70", Offset = "0x40CA170", VA = "0x1840CAD70")]
	private BANOPIMHDDH(byte[] BCGCPPBLPOA, Action<Protobuf> ENLDDMOKEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2142770", Offset = "0x2141B70", VA = "0x182142770")]
	public static BANOPIMHDDH<Protobuf> DEDAFMGEJMH<Data>(ReadOnlySpan<byte> DCBJJADOEJL, ReadOnlySpan<Data> JFJPDDKMGLD, Action<Protobuf> ENLDDMOKEOB)
	{
		return default(BANOPIMHDDH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x40CABE0", Offset = "0x40C9FE0", VA = "0x1840CABE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x40CAC20", Offset = "0x40CA020", VA = "0x1840CAC20", Slot = "4")]
	[IteratorStateMachine(typeof(BANOPIMHDDH<>.PBCPKCMLJFA))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x40CAD20", Offset = "0x40CA120", VA = "0x1840CAD20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class MGAGGMBOOMG : LAOHLEGNFJB
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x71363B0", Offset = "0x71357B0", VA = "0x1871363B0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase CEMGMADDGGN();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7136360", Offset = "0x7135760", VA = "0x187136360")]
	protected ComponentSystemBase NGAFJJJGDKP(params ComponentSystemBase[] NNFPDEGNOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2173130", Offset = "0x2172530", VA = "0x182173130")]
	protected ComponentSystemBase NGAFJJJGDKP<T>(params ComponentSystemBase[] NNFPDEGNOEP) where T : LAOHLEGNFJB, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2173010", Offset = "0x2172410", VA = "0x182173010")]
	protected ComponentSystemBase HNBLHJANKIL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2173010", Offset = "0x2172410", VA = "0x182173010")]
	protected ComponentSystemBase CMCHGKLEOGB<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7136310", Offset = "0x7135710", VA = "0x187136310")]
	protected ComponentSystemBase GGFFJMJLILO(params SystemHandleUntyped[] NNFPDEGNOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2173050", Offset = "0x2172450", VA = "0x182173050")]
	protected ComponentSystemBase GGFFJMJLILO<T>(params SystemHandleUntyped[] NNFPDEGNOEP) where T : LAOHLEGNFJB, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x21730E0", Offset = "0x21724E0", VA = "0x1821730E0")]
	protected SystemHandleUntyped IMPJIMFGOCO<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x71360E0", Offset = "0x71354E0", VA = "0x1871360E0")]
	protected MGAGGMBOOMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JGCIDMEPEJH
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x163E220", Offset = "0x163D620", VA = "0x18163E220")]
	public static NativeList<T> OBMJLKCOOCK<T>(NativeList<T> MBOAMKIIHKG, Allocator DGGNDNPDKKD) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class CCOOLPIOGJC
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct PBHMFPMLHHF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : APLPGNLHJBF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> NOIHCELINAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeList<TFrom> IIBCOEJKHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeParallelHashSet<TTo> HMHINJBEENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap NDPBOAHDPLI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct CDBNLKJKBKG<T, TPredicate> : IJob where T : struct where TPredicate : struct, HDPFBKINIJO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<T> NOIHCELINAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> CNNHDDIKMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeList<Entity> HMMLBDMIBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public TPredicate NDPBOAHDPLI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3155C20", Offset = "0x3155020", VA = "0x183155C20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct ODFGJEPGLHG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, APLPGNLHJBF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<TFrom> CDCBEMHCPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[WriteOnly]
	public NativeList<TTo> JMOKDKNBCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public TMap NDPBOAHDPLI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class FHEOCFCLBBC
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct NIIKENCIOHE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly NativeArray<T>.ReadOnly EACKPMFPNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int ILIPJAOBBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int IKDBHJNKDOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private T BNPJFJKHDBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private T CDDMJOBFBFM;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public EEMOBOLLAKL GGLFGGNNNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x21E91D0", Offset = "0x21E85D0", VA = "0x1821E91D0")]
			get
			{
				return default(EEMOBOLLAKL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T JEPPDMMFKIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x176BEE0", Offset = "0x176B2E0", VA = "0x18176BEE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (T, EEMOBOLLAKL) AOPJILKHAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2791480", Offset = "0x2790880", VA = "0x182791480")]
			get
			{
				return default((T, EEMOBOLLAKL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2791550", Offset = "0x2790950", VA = "0x182791550")]
		public NIIKENCIOHE(NativeArray<T> EACKPMFPNLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x26DD0D0", Offset = "0x26DC4D0", VA = "0x1826DD0D0")]
		public NIIKENCIOHE<T> MHIEAIINAGJ()
		{
			return default(NIIKENCIOHE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2791090", Offset = "0x2790490", VA = "0x182791090")]
		public bool FKEKIBADBKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1BC5940", Offset = "0x1BC4D40", VA = "0x181BC5940")]
		public DKHHGNMFGPH<T, TComparer> AFHLOJBIKHI<TComparer>([Optional] TComparer GECLPENELIN) where TComparer : struct, IEqualityComparer<T>
		{
			return default(DKHHGNMFGPH<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct DKHHGNMFGPH<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly NativeArray<T>.ReadOnly EACKPMFPNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int ILIPJAOBBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int IKDBHJNKDOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T BNPJFJKHDBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private T CDDMJOBFBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TComparer GECLPENELIN;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public EEMOBOLLAKL GGLFGGNNNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x21E91D0", Offset = "0x21E85D0", VA = "0x1821E91D0")]
			get
			{
				return default(EEMOBOLLAKL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public T JEPPDMMFKIE
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x176BEE0", Offset = "0x176B2E0", VA = "0x18176BEE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public (T value, EEMOBOLLAKL range) AOPJILKHAOB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x21E9480", Offset = "0x21E8880", VA = "0x1821E9480")]
			get
			{
				return default((T, EEMOBOLLAKL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x21E9550", Offset = "0x21E8950", VA = "0x1821E9550")]
		public DKHHGNMFGPH(NativeArray<T>.ReadOnly EACKPMFPNLH, TComparer GECLPENELIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x21E9440", Offset = "0x21E8840", VA = "0x1821E9440")]
		public DKHHGNMFGPH<T, TComparer> MHIEAIINAGJ()
		{
			return default(DKHHGNMFGPH<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x21E91E0", Offset = "0x21E85E0", VA = "0x1821E91E0")]
		public bool FKEKIBADBKC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x17AF760", Offset = "0x17AEB60", VA = "0x1817AF760")]
	public static NIIKENCIOHE<T> NGAFJJJGDKP<T>(this NativeArray<T> EACKPMFPNLH) where T : struct
	{
		return default(NIIKENCIOHE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface APLPGNLHJBF<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo EGDPOBLMKNF(in TFrom AGLCIEKHLEE);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class AOHIJBOGAHO
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HNEOBLLKHPI
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GFEBBNEEOEH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public GFEBBNEEOEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JDMCELMKPNO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		public JDMCELMKPNO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<Func<JobHandle, JobHandle>> FGAEAIPNOKJ;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7136260", Offset = "0x7135660", VA = "0x187136260")]
	public HNEOBLLKHPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class COIDJMLLLGL
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class FDPFJCKHLML : EntityCommandBufferSystem, NCOMPJIPGCA
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
	protected FDPFJCKHLML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PJNAMLJEHBM
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x32315F0", Offset = "0x32309F0", VA = "0x1832315F0")]
	[PFCFPONLICD]
	public static JobHandle PIHBPAKPKKK<T>(this EntityCommandBufferSystem ICHBDANIEME, NativeArray<Entity> NOEOKDNGNCK, NativeArray<T> CLCAIFLMLCJ, JobHandle BMMIBMDGEID) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct EEFOOEPBMEK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<T> NOIHCELINAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<T> IIBCOEJKHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<T> HMHINJBEENE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3A200C0", Offset = "0x3A1F4C0", VA = "0x183A200C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct OPFBFONOGCH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> NOEOKDNGNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EntityCommandBuffer JNKKDKMNHPP;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7136760", Offset = "0x7135B60", VA = "0x187136760", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class EGMOBHCFAIP
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x223C350", Offset = "0x223B750", VA = "0x18223C350")]
	public static NativeArray<T> KHCDOLIBKON<T>(this NativeList<Entity> MBOAMKIIHKG, EntityManager BEBIJONEMLA, Allocator DGGNDNPDKKD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x223C180", Offset = "0x223B580", VA = "0x18223C180")]
	public static NativeArray<T> KHCDOLIBKON<T>(this NativeArray<Entity> MBOAMKIIHKG, EntityManager BEBIJONEMLA, Allocator DGGNDNPDKKD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FOJHDKPGHBP
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class JEKGIMKIDLF
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal struct MEKIOABFCGN<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> NOEOKDNGNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public T AGLCIEKHLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public EntityCommandBuffer JNKKDKMNHPP;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x22F3DE0", Offset = "0x22F31E0", VA = "0x1822F3DE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class KODKIALHIEH
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2371710", Offset = "0x2370B10", VA = "0x182371710")]
	[PFCFPONLICD]
	public static JobHandle BIOKPOIACKO<T>(this EntityCommandBufferSystem ICHBDANIEME, EntityCommandBuffer JNKKDKMNHPP, EntityQuery BEHDAMIMGBM, T AGLCIEKHLEE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class AIOEMIAEDDB<Data> : GKINOCIEEIK where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public virtual Data KCIIGNIKLNC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1DA7070", Offset = "0x1DA6470", VA = "0x181DA7070", Slot = "8")]
	protected virtual bool FHEKMPIJECB(ReadOnlySpan<Data> JFJPDDKMGLD, CNPNLDAEMGP JNKBIJELCHM, out ReadOnlySpan<byte> DCBJJADOEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8228B0", Offset = "0x821CB0", VA = "0x1808228B0", Slot = "9")]
	protected virtual bool HPJEOBEBHIB(int LJJHJABONIO, Span<Data> JFJPDDKMGLD, in ReadOnlySpan<byte> DCBJJADOEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2A29560", Offset = "0x2A28960", VA = "0x182A29560", Slot = "5")]
	internal sealed override bool FHEKMPIJECB(ref Unity.Entities.Chunk DHCAFCLHBAO, int POBEIOKOKDK, CNPNLDAEMGP JNKBIJELCHM, out ReadOnlySpan<byte> DCBJJADOEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2A29830", Offset = "0x2A28C30", VA = "0x182A29830", Slot = "6")]
	internal sealed override bool HPJEOBEBHIB(int LJJHJABONIO, ref Unity.Entities.Chunk DHCAFCLHBAO, int POBEIOKOKDK, in ReadOnlySpan<byte> DCBJJADOEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2315300", Offset = "0x2314700", VA = "0x182315300")]
	protected BGIGDKMBHOE<Protobuf> PKHLKCMDBFI<Protobuf>(ReadOnlySpan<Data> JFJPDDKMGLD) where Protobuf : IMessage, new()
	{
		return default(BGIGDKMBHOE<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2315270", Offset = "0x2314670", VA = "0x182315270")]
	protected BANOPIMHDDH<Protobuf> PKDFLHHDOLL<Protobuf>(ReadOnlySpan<byte> DCBJJADOEJL, ReadOnlySpan<Data> JFJPDDKMGLD, Action<Protobuf> ENLDDMOKEOB) where Protobuf : IMessage, new()
	{
		return default(BANOPIMHDDH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6C80", Offset = "0x1CA6080", VA = "0x181CA6C80")]
	protected AIOEMIAEDDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class GKINOCIEEIK
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected abstract int BLBNLGCJCGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7136140", Offset = "0x7135540", VA = "0x187136140", Slot = "5")]
	internal virtual bool FHEKMPIJECB(ref Unity.Entities.Chunk DHCAFCLHBAO, int POBEIOKOKDK, CNPNLDAEMGP JNKBIJELCHM, out ReadOnlySpan<byte> DCBJJADOEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8228B0", Offset = "0x821CB0", VA = "0x1808228B0", Slot = "6")]
	internal virtual bool HPJEOBEBHIB(int LJJHJABONIO, ref Unity.Entities.Chunk DHCAFCLHBAO, int POBEIOKOKDK, in ReadOnlySpan<byte> DCBJJADOEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	protected GKINOCIEEIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class JLPFICNAJFA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct KHJGNPBCFAA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct HDBEJDJFPPA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal KHJGNPBCFAA<TFrom> OJBGDMNECON;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> CIDBOBPIINF;
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct PNKILHBGBDB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public struct IOLCCPBGJKC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal PNKILHBGBDB<TFrom> OJBGDMNECON;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> CIDBOBPIINF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct MIJMLIMFHCD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public struct GKOLMHCHEHN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal MIJMLIMFHCD<TFrom> OJBGDMNECON;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> CIDBOBPIINF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct ADHCPHFPMNJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public struct LMDGCOAANIA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal ADHCPHFPMNJ<TFrom> OJBGDMNECON;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> CIDBOBPIINF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct OOGDFDACDOI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	public ComponentDataFromEntity EKJMBKFLBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	public NativeArray<Entity> NOIHCELINAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[WriteOnly]
	public NativeArray<byte> JMOKDKNBCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int GDKDDPCMMNB;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7136660", Offset = "0x7135A60", VA = "0x187136660", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[BurstCompile]
internal struct JCLEGMNAMAH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EFDPHMAFPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[ReadOnly]
	public NativeArray<Entity> MEHONAIFBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<bool> BIDCNBFBBKJ;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal struct IHBDNANIOPJ<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[ReadOnly]
	public NativeArray<Entity> NOEOKDNGNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[ReadOnly]
	public NativeArray<T> IKBLLODDBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public EntityCommandBuffer JNKKDKMNHPP;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class KIIENDLIBBM
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1D936C0", Offset = "0x1D92AC0", VA = "0x181D936C0")]
	public static NativeListAsync<Entity> DMAPEGALFBP<T, TPredicate>(this NativeArrayAsync<T> MBOAMKIIHKG, NativeArrayAsync<Entity> MEHONAIFBIF, Allocator DGGNDNPDKKD = Allocator.TempJob) where T : struct where TPredicate : struct, HDPFBKINIJO<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1D93510", Offset = "0x1D92910", VA = "0x181D93510")]
	private static NativeListAsync<Entity> ADKFIPJPPNA<T, TPredicate>(NativeArrayAsync<T> FAGIMAEOAIN, NativeArrayAsync<Entity> MEHONAIFBIF, int HBBGBOONHJE, Allocator DGGNDNPDKKD) where T : struct where TPredicate : struct, HDPFBKINIJO<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class EADDOOCBLIN
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x223A5B0", Offset = "0x22399B0", VA = "0x18223A5B0")]
	[PFCFPONLICD]
	public static JobHandle LCFDEIMNHEI<T>(this EntityCommandBufferSystem ICHBDANIEME, NativeArray<Entity> NOEOKDNGNCK, T AGLCIEKHLEE, [Optional] JobHandle BMMIBMDGEID) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x223A680", Offset = "0x2239A80", VA = "0x18223A680")]
	[PFCFPONLICD]
	public static JobHandle LCFDEIMNHEI<T>(this EntityCommandBufferSystem ICHBDANIEME, EntityCommandBuffer JNKKDKMNHPP, NativeArray<Entity> NOEOKDNGNCK, T AGLCIEKHLEE, [Optional] JobHandle BMMIBMDGEID) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class CNPNLDAEMGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> JKCPBNACBCC;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x20D11E0", Offset = "0x20D05E0", VA = "0x1820D11E0")]
	public CNPNLDAEMGP(NativeArray<EntityRemapUtility.EntityRemapInfo> JKCPBNACBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7135A10", Offset = "0x7134E10", VA = "0x187135A10")]
	public Entity IDEKNCAFNMK(Entity OIEACLJHHPB)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class NCCBONBHHOO
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2401580", Offset = "0x2400980", VA = "0x182401580")]
	public static NativeList<T> OBMJLKCOOCK<T>(this NativeList<T> MBOAMKIIHKG, Allocator DGGNDNPDKKD = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2401600", Offset = "0x2400A00", VA = "0x182401600")]
	public static NativeList<T> OBMJLKCOOCK<T>(this NativeArray<T> MBOAMKIIHKG, Allocator DGGNDNPDKKD = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class AFAFEBHECNJ
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct IPIDPOPEAJM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> NOIHCELINAP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct ADEGOAFADKG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<T> NOIHCELINAP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct OHOAPPANNBE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<T> NOIHCELINAP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct FCODCFLKAIK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeListAsync<T> NOIHCELINAP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
internal struct DAFDIACBAPO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, APLPGNLHJBF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeArray<TFrom> NOIHCELINAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[WriteOnly]
	public NativeArray<TTo> JMOKDKNBCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TMap NDPBOAHDPLI;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface HDPFBKINIJO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DJEDHDKNJHJ(T AGLCIEKHLEE);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
internal struct AMAOHIGNEDE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	public NativeArray<Entity> NOEOKDNGNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public EntityCommandBuffer JNKKDKMNHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public ComponentTypes EBNDPHJDIPK;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x71354F0", Offset = "0x71348F0", VA = "0x1871354F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[BurstCompile]
internal struct ENDNIEADFMD<T, TPredicate> : IJob where T : struct where TPredicate : struct, HDPFBKINIJO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	public NativeArray<T> NOIHCELINAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<T> IIBCOEJKHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public TPredicate NDPBOAHDPLI;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LAOHLEGNFJB : GBPLGIOBJHG
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x71362E0", Offset = "0x71356E0", VA = "0x1871362E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x71360E0", Offset = "0x71354E0", VA = "0x1871360E0")]
	public LAOHLEGNFJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[BurstCompile]
internal struct MEHADGCPEDC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EFDPHMAFPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	public NativeArray<Entity> MEHONAIFBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<bool> BIDCNBFBBKJ;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x22F3D40", Offset = "0x22F3140", VA = "0x1822F3D40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct AFBLPEBGEPA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<Entity> NOEOKDNGNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	public NativeArray<T> CLCAIFLMLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public EntityCommandBuffer JNKKDKMNHPP;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2A23530", Offset = "0x2A22930", VA = "0x182A23530", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class HEIENHDBOFM
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7136160", Offset = "0x7135560", VA = "0x187136160")]
	public static ulong FMHAOGJNPEA(Type GANFKPHKNKH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x71361F0", Offset = "0x71355F0", VA = "0x1871361F0")]
	public static ulong FMHAOGJNPEA(string LMBNFBMPCKB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class GPJMDNAJGCP : HFNAELOJHJC
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Type MCPHNLGOKBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC640", Offset = "0x2FFBA40", VA = "0x182FFC640")]
	public GPJMDNAJGCP(Type EFDPHMAFPCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[BurstCompile]
internal struct DDPLNDPOJPM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public ComponentDataFromEntity EFDPHMAFPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	public NativeArray<Entity> MEHONAIFBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<Entity> CJJCANJBPFE;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7135A20", Offset = "0x7134E20", VA = "0x187135A20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public abstract class NILFPPHEEJF : SystemBase, NCOMPJIPGCA
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7136410", Offset = "0x7135810", VA = "0x187136410")]
	public ComponentDataFromEntity BBJDPCEBOGI(int DCJNJIADGPK, bool AIEFANFKBOM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x71364E0", Offset = "0x71358E0", VA = "0x1871364E0")]
	public EntityExistenceLookupByEntity HLHNFEOECIP()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7136500", Offset = "0x7135900", VA = "0x187136500", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x823850", Offset = "0x822C50", VA = "0x180823850")]
	protected NILFPPHEEJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class CCBLHMCLOCJ : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7135550", Offset = "0x7134950", VA = "0x187135550", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x823850", Offset = "0x822C50", VA = "0x180823850")]
	protected CCBLHMCLOCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class HOFACFNDHKM
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct BGIGDKMBHOE<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly byte[] BCGCPPBLPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Protobuf ONMAPMKGDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly MemoryStream ICGCONBOMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly CodedOutputStream HDAIEAFAGED;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x205D130", Offset = "0x205C530", VA = "0x18205D130")]
	private BGIGDKMBHOE(byte[] BCGCPPBLPOA, in Protobuf ONMAPMKGDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2145B10", Offset = "0x2144F10", VA = "0x182145B10")]
	public static BGIGDKMBHOE<Protobuf> DEDAFMGEJMH<T>(ReadOnlySpan<T> JFJPDDKMGLD)
	{
		return default(BGIGDKMBHOE<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x205D100", Offset = "0x205C500", VA = "0x18205D100")]
	public void HFNPCKGPPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x205CF50", Offset = "0x205C350", VA = "0x18205CF50")]
	public ByteString CIBKNCFFHFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x205CFE0", Offset = "0x205C3E0", VA = "0x18205CFE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface NCOMPJIPGCA
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public abstract class GBPLGIOBJHG : ComponentSystemGroup, NCOMPJIPGCA
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x71360E0", Offset = "0x71354E0", VA = "0x1871360E0")]
	protected GBPLGIOBJHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class OHJGGBIKOPP
{
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[BurstCompile]
internal struct IDAPONDLBHN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DMHKONADMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public NativeArray<Entity> NOIHCELINAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[WriteOnly]
	public NativeList<T> IIBCOEJKHNO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[Flags]
public enum FJNMBOHBDKO
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
public class FPEACHBODJG : HFNAELOJHJC
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x823850", Offset = "0x822C50", VA = "0x180823850")]
	public FPEACHBODJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class BBKEOHEOGNH
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public readonly struct GOILLDHJLGL<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly NativeArray<TSrc> EACKPMFPNLH;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x20CE640", Offset = "0x20CDA40", VA = "0x1820CE640")]
		public GOILLDHJLGL(NativeArray<TSrc> EACKPMFPNLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0")]
		public CCMFLLDMGML<TSrc, TValue> ELLMIOPAJPH<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(CCMFLLDMGML<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct CCMFLLDMGML<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly NativeArray<TSrc> EACKPMFPNLH;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x20CE640", Offset = "0x20CDA40", VA = "0x1820CE640")]
		public CCMFLLDMGML(NativeArray<TSrc> EACKPMFPNLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0")]
		public AHKCEEDLCDC<TSrc, TValue, TSelector> HFJDIJBEMNM<TSelector>() where TSelector : struct, APLPGNLHJBF<TSrc, TValue>
		{
			return default(AHKCEEDLCDC<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct AHKCEEDLCDC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, APLPGNLHJBF<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly NativeArray<TSrc> EACKPMFPNLH;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x20CE640", Offset = "0x20CDA40", VA = "0x1820CE640")]
		public AHKCEEDLCDC(NativeArray<TSrc> EACKPMFPNLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A27580", Offset = "0x2A26980", VA = "0x182A27580")]
		public LLNGJBJMJDG<TSrc, TValue, TSelector> NGAFJJJGDKP()
		{
			return default(LLNGJBJMJDG<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct DJDNIEBADBI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, APLPGNLHJBF<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly NativeArray<TSrc> EACKPMFPNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TSelector CAHELJOKEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int BNOAGGNAMKG;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TValue AOPJILKHAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x21E5850", Offset = "0x21E4C50", VA = "0x1821E5850")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int FKHPMLNOHLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x985830", Offset = "0x984C30", VA = "0x180985830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int NMCJNDHCAJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x176BB40", Offset = "0x176AF40", VA = "0x18176BB40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x21E58C0", Offset = "0x21E4CC0", VA = "0x1821E58C0")]
		public DJDNIEBADBI(NativeArray<TSrc> EACKPMFPNLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x21E5840", Offset = "0x21E4C40", VA = "0x1821E5840")]
		public bool FKEKIBADBKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x21E5720", Offset = "0x21E4B20", VA = "0x1821E5720")]
		private TSrc DLMFMKDMKBE(int APEMPONKPBB)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public struct LLNGJBJMJDG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, APLPGNLHJBF<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private DJDNIEBADBI<TSrc, TValue, TSelector> OMJENHBNMFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TValue BNPJFJKHDBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int ILIPJAOBBJM;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public EEMOBOLLAKL GGLFGGNNNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x2BC3C30", Offset = "0x2BC3030", VA = "0x182BC3C30")]
			get
			{
				return default(EEMOBOLLAKL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TValue JEPPDMMFKIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x978170", Offset = "0x977570", VA = "0x180978170")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (TValue value, EEMOBOLLAKL range) AOPJILKHAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2BC3DA0", Offset = "0x2BC31A0", VA = "0x182BC3DA0")]
			get
			{
				return default((TValue, EEMOBOLLAKL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3E70", Offset = "0x2BC3270", VA = "0x182BC3E70")]
		public LLNGJBJMJDG(NativeArray<TSrc> EACKPMFPNLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x176B940", Offset = "0x176AD40", VA = "0x18176B940")]
		public LLNGJBJMJDG<TSrc, TValue, TSelector> MHIEAIINAGJ()
		{
			return default(LLNGJBJMJDG<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3C70", Offset = "0x2BC3070", VA = "0x182BC3C70")]
		public bool FKEKIBADBKC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2742330", Offset = "0x2741730", VA = "0x182742330")]
	public static GOILLDHJLGL<T> GFMINMGGGFA<T>(this NativeList<T> FIONHDMDJNK) where T : struct
	{
		return default(GOILLDHJLGL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0")]
	public static GOILLDHJLGL<T> GFMINMGGGFA<T>(this NativeArray<T> EACKPMFPNLH) where T : struct
	{
		return default(GOILLDHJLGL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class ELHOJBEHDBF
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct NBKHEDALPKH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct ILHGEJDHCEE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public NBKHEDALPKH<TFrom> CIDBOBPIINF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NativeArray<TFrom> NOIHCELINAP;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct OPKMPAGEAKG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public struct OJNIDFKGOIA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public OPKMPAGEAKG<TFrom> CIDBOBPIINF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeArrayAsync<TFrom> NOIHCELINAP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct KOILMANIPHI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public struct JCCHGEIMGNF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public KOILMANIPHI<TFrom> CIDBOBPIINF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Allocator DGGNDNPDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NativeListAsync<TFrom> NOIHCELINAP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[BurstCompile]
internal struct FCLJHLAJPEM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	public NativeArray<Entity> NOEOKDNGNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public EntityCommandBuffer JNKKDKMNHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public ComponentType OOMLHJHCPCJ;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7135FD0", Offset = "0x71353D0", VA = "0x187135FD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class CMOLIJLEGFL
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x21C9B60", Offset = "0x21C8F60", VA = "0x1821C9B60")]
	public static bool NJDNDFCNAAM<T>(this NativeArray<Entity> MEHONAIFBIF, EntityManager BEBIJONEMLA, Allocator DGGNDNPDKKD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class DIMIHPAIKJM
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class OHDDGJNCBNG
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class PBKFCKGEKGK
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public delegate void PBHKDKPFCDD<From, To>(From CIDBOBPIINF, ref To NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM);

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private class HPEIHFCFKPK<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static PBHKDKPFCDD<From, To> MCGBMBLLJAL;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public HPEIHFCFKPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7136C70", Offset = "0x7136070", VA = "0x187136C70")]
	static PBKFCKGEKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x203A810", Offset = "0x2039C10", VA = "0x18203A810")]
	public static void MLMAEAOEMAH<T>(PBHKDKPFCDD<T, T> JMFBFJAOEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x203A460", Offset = "0x2039860", VA = "0x18203A460")]
	public static void MLMAEAOEMAH<From, To>(PBHKDKPFCDD<From, To> JMFBFJAOEDA, PBHKDKPFCDD<To, From> NPNAHNMDMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x203A4F0", Offset = "0x20398F0", VA = "0x18203A4F0")]
	public static void MLMAEAOEMAH<From, To>(PBHKDKPFCDD<From, To> MCGBMBLLJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x203CD50", Offset = "0x203C150", VA = "0x18203CD50")]
	public static PBHKDKPFCDD<From, To> PFHNGDHGJBN<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2039470", Offset = "0x2038870", VA = "0x182039470")]
	public static void JKELMLILMEJ<From, To>(From CIDBOBPIINF, ref To NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class DMMFGPPDGFI
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2C83740", Offset = "0x2C82B40", VA = "0x182C83740")]
	[PFCFPONLICD]
	public static JobHandle MGBEBJDNBPK<T>(this EntityCommandBufferSystem ICHBDANIEME, NativeArrayAsync<Entity> NOEOKDNGNCK, NativeArrayAsync<T> CLCAIFLMLCJ, [Optional] JobHandle BMMIBMDGEID) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2C83B00", Offset = "0x2C82F00", VA = "0x182C83B00")]
	[PFCFPONLICD]
	public static JobHandle MGBEBJDNBPK<T>(this EntityCommandBufferSystem ICHBDANIEME, NativeArrayAsync<Entity> NOEOKDNGNCK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C83890", Offset = "0x2C82C90", VA = "0x182C83890")]
	[PFCFPONLICD]
	public static JobHandle MGBEBJDNBPK<T>(this EntityCommandBufferSystem ICHBDANIEME, NativeArray<Entity> NOEOKDNGNCK, [Optional] JobHandle BMMIBMDGEID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7135AB0", Offset = "0x7134EB0", VA = "0x187135AB0")]
	[PFCFPONLICD]
	public static JobHandle MGBEBJDNBPK(this EntityCommandBufferSystem ICHBDANIEME, NativeArray<Entity> NOEOKDNGNCK, ComponentTypes EBNDPHJDIPK, [Optional] JobHandle BMMIBMDGEID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7135C20", Offset = "0x7135020", VA = "0x187135C20")]
	[PFCFPONLICD]
	public static JobHandle MGBEBJDNBPK(this EntityCommandBufferSystem ICHBDANIEME, EntityCommandBuffer JNKKDKMNHPP, NativeArray<Entity> NOEOKDNGNCK, ComponentTypes EBNDPHJDIPK, [Optional] JobHandle BMMIBMDGEID)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class OPHGNIKJDFG
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x71367C0", Offset = "0x7135BC0", VA = "0x1871367C0")]
	private unsafe static Span<byte> AADKDPAPECF(Unity.Entities.Chunk* DHCAFCLHBAO, int POBEIOKOKDK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x202DD30", Offset = "0x202D130", VA = "0x18202DD30")]
	public unsafe static Span<T> FJAEGAIICKC<T>(Unity.Entities.Chunk* DHCAFCLHBAO, int POBEIOKOKDK)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x202DEC0", Offset = "0x202D2C0", VA = "0x18202DEC0")]
	public static Span<T> FJAEGAIICKC<T>(this ref Unity.Entities.Chunk DHCAFCLHBAO, int POBEIOKOKDK)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7136980", Offset = "0x7135D80", VA = "0x187136980")]
	public unsafe static Span<Entity> DGKGKDPPMEL(Unity.Entities.Chunk* DHCAFCLHBAO)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x71369F0", Offset = "0x7135DF0", VA = "0x1871369F0")]
	public unsafe static void PDPMCCCKLBI(Unity.Entities.Chunk* DHCAFCLHBAO, int POBEIOKOKDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[AttributeUsage(AttributeTargets.Class)]
public class EIHIJGBHNAM : HFNAELOJHJC
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x823850", Offset = "0x822C50", VA = "0x180823850")]
	public EIHIJGBHNAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface DIHICPLKFAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GBOELMEJBFJ(Entity GKMECPLEALF, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPOKAIGIDPM(Entity GKMECPLEALF, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HJLBKFDCDLJ(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BBDPEOGICKO(Entity GKMECPLEALF);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class FMGLEPMNDMM<TComponentData, TValue> : DFMOAIPJPDE<TValue>, IDisposable where TComponentData : struct, GNJLMOPJNKA
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class EDMKNPAHEPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private List<(object token, TValue value)> FIONHDMDJNK;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int HIBMACOFNKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1C906B0", Offset = "0x1C8FAB0", VA = "0x181C906B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3A1FB00", Offset = "0x3A1EF00", VA = "0x183A1FB00")]
		public bool NFEDGEACPJJ(out TValue AGLCIEKHLEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3A1FBC0", Offset = "0x3A1EFC0", VA = "0x183A1FBC0")]
		public void NNFBEGDMHOD(object AEMEEHLIDCM, TValue AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3A1FA80", Offset = "0x3A1EE80", VA = "0x183A1FA80")]
		public bool LOBOHMPHNJE(object AEMEEHLIDCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3A1F9D0", Offset = "0x3A1EDD0", VA = "0x183A1F9D0")]
		public int JHGGBFNCADF(object AEMEEHLIDCM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3A1FC70", Offset = "0x3A1F070", VA = "0x183A1FC70")]
		public EDMKNPAHEPA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly Stack<EDMKNPAHEPA> DMMAEEMJHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private MBHLHJKBIIN<FDHLCBIMPBP, EDMKNPAHEPA> AKFFMLAIDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private EntityManager BEBIJONEMLA;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x38148A0", Offset = "0x3813CA0", VA = "0x1838148A0")]
	public FMGLEPMNDMM(EntityManager BEBIJONEMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3814410", Offset = "0x3813810", VA = "0x183814410", Slot = "4")]
	public void GBOELMEJBFJ(Entity GKMECPLEALF, object AEMEEHLIDCM, TValue AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3814690", Offset = "0x3813A90", VA = "0x183814690", Slot = "5")]
	public bool OPOKAIGIDPM(Entity GKMECPLEALF, object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x38145C0", Offset = "0x38139C0", VA = "0x1838145C0", Slot = "6")]
	public bool NFEDGEACPJJ(Entity GKMECPLEALF, out TValue AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x38143D0", Offset = "0x38137D0", VA = "0x1838143D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3814820", Offset = "0x3813C20", VA = "0x183814820")]
	private void PIHOEEEOCMM(EDMKNPAHEPA KEKHJBLOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3814300", Offset = "0x3813700", VA = "0x183814300")]
	private bool DIMDONPNACD(Entity GKMECPLEALF, out FDHLCBIMPBP PAHMPOAEKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3814530", Offset = "0x3813930", VA = "0x183814530")]
	private void JGDNBMOGNNO(Entity GKMECPLEALF, FDHLCBIMPBP PAHMPOAEKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x38143F0", Offset = "0x38137F0", VA = "0x1838143F0")]
	private bool GAAFPHOGBAB(FDHLCBIMPBP PAHMPOAEKCN, out EDMKNPAHEPA KEKHJBLOECE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3814230", Offset = "0x3813630", VA = "0x183814230")]
	private EDMKNPAHEPA DFIPMMIAIJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface DFMOAIPJPDE<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBOELMEJBFJ(Entity GKMECPLEALF, object AEMEEHLIDCM, TValue AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPOKAIGIDPM(Entity GKMECPLEALF, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NFEDGEACPJJ(Entity GKMECPLEALF, out TValue AGLCIEKHLEE);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface GNJLMOPJNKA : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	FDHLCBIMPBP HMMPIOKGEJN
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
public struct FDHLCBIMPBP : LDJIGAKAEPB, IEquatable<FDHLCBIMPBP>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly FDHLCBIMPBP ENEHFIHPPLN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	[CreateProperty]
	public int FKHPMLNOHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	[CreateProperty]
	public int BLBNLGCJCGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x176BAF0", Offset = "0x176AEF0", VA = "0x18176BAF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2954C40", Offset = "0x2954040", VA = "0x182954C40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7136000", Offset = "0x7135400", VA = "0x187136000", Slot = "8")]
	public bool Equals(FDHLCBIMPBP ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7136050", Offset = "0x7135450", VA = "0x187136050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class DNDPKOJDFNF<THasTokensTag> : DIHICPLKFAA, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Dictionary<Entity, FDHLCBIMPBP> EKLMDIKLKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Stack<HashSet<object>> DMMAEEMJHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private MBHLHJKBIIN<FDHLCBIMPBP, HashSet<object>> AKFFMLAIDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private EntityManager BEBIJONEMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private EntityCommandBufferSystem ICHBDANIEME;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2E71E80", Offset = "0x2E71280", VA = "0x182E71E80")]
	public DNDPKOJDFNF(EntityManager BEBIJONEMLA, EntityCommandBufferSystem ICHBDANIEME, EHKEPJIBENP EHAEKKEFBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2E70050", Offset = "0x2E6F450", VA = "0x182E70050", Slot = "4")]
	public bool GBOELMEJBFJ(Entity GKMECPLEALF, object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2E712C0", Offset = "0x2E706C0", VA = "0x182E712C0", Slot = "5")]
	public bool OPOKAIGIDPM(Entity GKMECPLEALF, object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2E70450", Offset = "0x2E6F850", VA = "0x182E70450", Slot = "6")]
	public bool HJLBKFDCDLJ(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2E704D0", Offset = "0x2E6F8D0", VA = "0x182E704D0", Slot = "9")]
	public bool HJLBKFDCDLJ(FDHLCBIMPBP PAHMPOAEKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F280", Offset = "0x2E6E680", VA = "0x182E6F280", Slot = "7")]
	public bool BBDPEOGICKO(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FB30", Offset = "0x2E6EF30", VA = "0x182E6FB30", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2E71AA0", Offset = "0x2E70EA0", VA = "0x182E71AA0")]
	private void PIHOEEEOCMM(HashSet<object> KEKHJBLOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F770", Offset = "0x2E6EB70", VA = "0x182E6F770")]
	private bool DIMDONPNACD(Entity GKMECPLEALF, out FDHLCBIMPBP PAHMPOAEKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2E70C60", Offset = "0x2E70060", VA = "0x182E70C60")]
	private bool JLNDAEHILMD(Entity GKMECPLEALF, out FDHLCBIMPBP PAHMPOAEKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2E71050", Offset = "0x2E70450", VA = "0x182E71050")]
	private void MODOOLLJJEC(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2E70D40", Offset = "0x2E70140", VA = "0x182E70D40")]
	private void LEBAJIPMBLM(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2E70F50", Offset = "0x2E70350", VA = "0x182E70F50")]
	private void LHMBJFOBDBC(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2E70800", Offset = "0x2E6FC00", VA = "0x182E70800")]
	private void JGDNBMOGNNO(Entity GKMECPLEALF, FDHLCBIMPBP PAHMPOAEKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2E711A0", Offset = "0x2E705A0", VA = "0x182E711A0")]
	private bool NFOJEDNEIGE(FDHLCBIMPBP PAHMPOAEKCN, out HashSet<object> KEKHJBLOECE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F5F0", Offset = "0x2E6E9F0", VA = "0x182E6F5F0")]
	private HashSet<object> DFIPMMIAIJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class EMMOPNDNLHA
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void EOAAOCFKMIC(this EHKEPJIBENP IGCLICKKCHJ, NativeArray<Entity> NOEOKDNGNCK, [Optional][CallerFilePath] string GLPOOONCGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void EOAAOCFKMIC(this EHKEPJIBENP IGCLICKKCHJ, string GDKOBCHHFLB, NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void EOAAOCFKMIC(this EHKEPJIBENP IGCLICKKCHJ, string GLPOOONCGBE, NativeArray<Entity> NOEOKDNGNCK, bool PPBLDNAFMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void LPHHADNMLIH(this EHKEPJIBENP IGCLICKKCHJ, NativeArray<Entity> NOEOKDNGNCK, EntityManager BEBIJONEMLA, [Optional][CallerFilePath] string GLPOOONCGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void LPHHADNMLIH(this EHKEPJIBENP IGCLICKKCHJ, string GLPOOONCGBE, NativeArray<Entity> NOEOKDNGNCK, EntityManager BEBIJONEMLA, bool PPBLDNAFMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void LGKAOEIMDFE(this EHKEPJIBENP IGCLICKKCHJ, NativeArray<Entity> NOEOKDNGNCK, NativeArray<Entity> GBFJPPHEION, [Optional][CallerFilePath] string GLPOOONCGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void LGKAOEIMDFE(this EHKEPJIBENP IGCLICKKCHJ, string GLPOOONCGBE, NativeArray<Entity> NOEOKDNGNCK, NativeArray<Entity> GBFJPPHEION, bool PPBLDNAFMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x224C040", Offset = "0x224B440", VA = "0x18224C040")]
	public static void LLDBHACPGGB<T>(this EHKEPJIBENP IGCLICKKCHJ, string GDKOBCHHFLB, NativeArray<Entity> NOEOKDNGNCK, NativeList<T> CLCAIFLMLCJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x224C0D0", Offset = "0x224B4D0", VA = "0x18224C0D0")]
	public static void LLDBHACPGGB<T>(this EHKEPJIBENP IGCLICKKCHJ, NativeArray<Entity> NOEOKDNGNCK, NativeArray<T> CLCAIFLMLCJ, [Optional][CallerFilePath] string GLPOOONCGBE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x224C120", Offset = "0x224B520", VA = "0x18224C120")]
	public static void LLDBHACPGGB<T>(this EHKEPJIBENP IGCLICKKCHJ, string GDKOBCHHFLB, NativeArray<Entity> NOEOKDNGNCK, NativeArray<T> CLCAIFLMLCJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void LLDBHACPGGB<T>(this EHKEPJIBENP IGCLICKKCHJ, string GLPOOONCGBE, NativeArray<Entity> NOEOKDNGNCK, NativeArray<T> CLCAIFLMLCJ, bool PPBLDNAFMEH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x224BFE0", Offset = "0x224B3E0", VA = "0x18224BFE0")]
	public static void JKJEGJCJFGA<T>(this EHKEPJIBENP IGCLICKKCHJ, NativeList<T> CLCAIFLMLCJ, [Optional][CallerFilePath] string GLPOOONCGBE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x224BFB0", Offset = "0x224B3B0", VA = "0x18224BFB0")]
	public static void JKJEGJCJFGA<T>(this EHKEPJIBENP IGCLICKKCHJ, NativeArray<T> CLCAIFLMLCJ, [Optional][CallerFilePath] string GLPOOONCGBE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void JKJEGJCJFGA<T>(this EHKEPJIBENP IGCLICKKCHJ, string GLPOOONCGBE, NativeArray<T> CLCAIFLMLCJ, bool PPBLDNAFMEH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void AFLHIMMIHEB(this EHKEPJIBENP IGCLICKKCHJ, EntityQuery BEHDAMIMGBM, [Optional][CallerFilePath] string GLPOOONCGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void AFLHIMMIHEB(this EHKEPJIBENP IGCLICKKCHJ, string GDKOBCHHFLB, EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void AFLHIMMIHEB(this EHKEPJIBENP IGCLICKKCHJ, string GLPOOONCGBE, EntityQuery BEHDAMIMGBM, bool PPBLDNAFMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x224BF80", Offset = "0x224B380", VA = "0x18224BF80")]
	public static void KNHKAGEDLAF<T, T2>(this EHKEPJIBENP IGCLICKKCHJ, string GDKOBCHHFLB, EntityQuery BEHDAMIMGBM) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void KNHKAGEDLAF<T, T2>(this EHKEPJIBENP IGCLICKKCHJ, string GLPOOONCGBE, EntityQuery BEHDAMIMGBM, bool PPBLDNAFMEH) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x224BF80", Offset = "0x224B380", VA = "0x18224BF80")]
	public static void HCLIOBEFFGK<T>(this EHKEPJIBENP IGCLICKKCHJ, string GDKOBCHHFLB, NativeList<T> EACKPMFPNLH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void HCLIOBEFFGK<T>(this EHKEPJIBENP IGCLICKKCHJ, string GLPOOONCGBE, NativeList<T> EACKPMFPNLH, bool PPBLDNAFMEH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x224BF80", Offset = "0x224B380", VA = "0x18224BF80")]
	public static void AJLOPGPMIFG<T>(this EHKEPJIBENP IGCLICKKCHJ, string GDKOBCHHFLB, NativeArray<T> EACKPMFPNLH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public static void AJLOPGPMIFG<T>(this EHKEPJIBENP IGCLICKKCHJ, string GLPOOONCGBE, NativeArray<T> EACKPMFPNLH, bool PPBLDNAFMEH) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class MGDDIBLAEHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public MGDDIBLAEHJ()
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

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
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EABFA0", Offset = "0x6EAB3A0", VA = "0x186EABFA0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MDHMBOHMCDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class OBJKMIMMFKD<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] BMGNBCCILMJ;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x13A2EB0", Offset = "0x13A22B0", VA = "0x1813A2EB0")]
	public static void LNCOLDCAOGI<TField>(int NANJAGEOPJI, string DKPHPKDPBCM, OPHEKAOFDCM DCHMDMNLODC, out MDGCCNJAIOM<TField> HNNIGEFAIIM) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x13A1310", Offset = "0x13A0710", VA = "0x1813A1310")]
	public static void EKBGBPDBLCN<TField>(int NANJAGEOPJI, string DKPHPKDPBCM, out AFHAKKMHKHI<TField> KKIJPENOLBP) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class DHFLIJGANPL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB860", Offset = "0x6EAAC60", VA = "0x186EAB860")]
	public static FieldInfo[] KOJKOJFAOOC(Type JLNNFEOBAMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class OECAPDFJLLL<View, Data> : GKAKPCKINHA where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType LDKGIKHKCGM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type CKOMOAEOHDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8ABE0", Offset = "0x3E89FE0", VA = "0x183E8ABE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int HDMOGHBEKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2F25D90", Offset = "0x2F25190", VA = "0x182F25D90", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2F26520", Offset = "0x2F25920", VA = "0x182F26520")]
	public Data FLMOLMNIMPF(Entity FKNFFDFGNMN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2F264B0", Offset = "0x2F258B0", VA = "0x182F264B0")]
	public Data CCNEACCGEMI(Entity FKNFFDFGNMN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View FBCKBCGAFDP(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x13A3A70", Offset = "0x13A2E70", VA = "0x1813A3A70", Slot = "14")]
	public override T FBCKBCGAFDP<T>(Entity FKNFFDFGNMN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1EFEF40", Offset = "0x1EFE340", VA = "0x181EFEF40")]
	protected OECAPDFJLLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class GKAKPCKINHA : OPHEKAOFDCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle GBBIBJIKFFM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC747E0", Offset = "0xC73BE0", VA = "0x180C747E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type CKOMOAEOHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int HDMOGHBEKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type LLGPEHJOOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1B0C230", Offset = "0x1B0B630", VA = "0x181B0C230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int BMFNOJGJKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6EAC540", Offset = "0x6EAB940", VA = "0x186EAC540", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private OMADGHGGHJN[] EOFCENAAKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1531680", Offset = "0x1530A80", VA = "0x181531680", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual OMADGHGGHJN[] DGLNIIDFHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6EAC2C0", Offset = "0x6EAB6C0", VA = "0x186EAC2C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC420", Offset = "0x6EAB820", VA = "0x186EAC420")]
	public void BEFDPLAELIH(EntityManager GLPCEPPDPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T FBCKBCGAFDP<T>(Entity FKNFFDFGNMN) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC5B0", Offset = "0x6EAB9B0", VA = "0x186EAC5B0", Slot = "8")]
	public (uint, uint) NDGBPOMPPGO(Entity FKNFFDFGNMN)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC380", Offset = "0x6EAB780", VA = "0x186EAC380", Slot = "9")]
	public bool BEBJJPJJHPD(Entity FKNFFDFGNMN, (uint order, uint change) HEGEMCIFGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	protected GKAKPCKINHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NDLCDGPEBGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int IFONHBAKCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private int ECOAGJBCGAI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JLBPIHHCKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x16CFC90", Offset = "0x16CF090", VA = "0x1816CFC90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2513720", Offset = "0x2512B20", VA = "0x182513720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BPNNCLDOEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int NALFHPNKMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6EAD020", Offset = "0x6EAC420", VA = "0x186EAD020")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EAD010", Offset = "0x6EAC410", VA = "0x186EAD010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xA28DB0", Offset = "0xA281B0", VA = "0x180A28DB0")]
	private NDLCDGPEBGB(int IFONHBAKCAB, int ECOAGJBCGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1E54230", Offset = "0x1E53630", VA = "0x181E54230")]
	public static NDLCDGPEBGB ENAOKAOMBFN(int IFONHBAKCAB, int ECOAGJBCGAI)
	{
		return default(NDLCDGPEBGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD000", Offset = "0x6EAC400", VA = "0x186EAD000")]
	public static NDLCDGPEBGB IKLCICGKMED(int GNBCIEFMNKN, int IGMAELCNDHD)
	{
		return default(NDLCDGPEBGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD030", Offset = "0x6EAC430", VA = "0x186EAD030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IJNHFDJLHLM : CFICKDFMDBF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6600DA0", Offset = "0x66001A0", VA = "0x186600DA0")]
	public float MIOHAAIMNDI(in float3 KKIAKNLLHIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6600DA0", Offset = "0x66001A0", VA = "0x186600DA0", Slot = "4")]
	private float FPJHPLCFFJA(in float3 KKIAKNLLHIO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OKDOGLBOHOB : CFICKDFMDBF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6600BF0", Offset = "0x65FFFF0", VA = "0x186600BF0")]
	public float MIOHAAIMNDI(in float3 KKIAKNLLHIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6600BF0", Offset = "0x65FFFF0", VA = "0x186600BF0", Slot = "4")]
	private float FPJHPLCFFJA(in float3 KKIAKNLLHIO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct PPHJDJHEHOA : CFICKDFMDBF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xE27B80", Offset = "0xE26F80", VA = "0x180E27B80")]
	public float MIOHAAIMNDI(in float3 KKIAKNLLHIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xE27B80", Offset = "0xE26F80", VA = "0x180E27B80", Slot = "4")]
	private float FPJHPLCFFJA(in float3 KKIAKNLLHIO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KBDDBDMLILO : CFICKDFMDBF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xD91170", Offset = "0xD90570", VA = "0x180D91170")]
	public int MIOHAAIMNDI(in int3 KKIAKNLLHIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xD91170", Offset = "0xD90570", VA = "0x180D91170", Slot = "4")]
	private int APPCCIDKIMC(in int3 KKIAKNLLHIO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JJJNKFBIJLK : CFICKDFMDBF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6394720", Offset = "0x6393B20", VA = "0x186394720")]
	public int MIOHAAIMNDI(in int3 KKIAKNLLHIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6394720", Offset = "0x6393B20", VA = "0x186394720", Slot = "4")]
	private int APPCCIDKIMC(in int3 KKIAKNLLHIO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct DGIGBNAOMFK : CFICKDFMDBF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xCD2530", Offset = "0xCD1930", VA = "0x180CD2530")]
	public int MIOHAAIMNDI(in int3 KKIAKNLLHIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xCD2530", Offset = "0xCD1930", VA = "0x180CD2530", Slot = "4")]
	private int APPCCIDKIMC(in int3 KKIAKNLLHIO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct CHIDPNDDBOA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly byte[] GMNLDOEDEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MemoryStream ALHMIMOAGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CodedOutputStream ECOHCJBPDON;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB740", Offset = "0x6EAAB40", VA = "0x186EAB740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
internal struct NDKDLBJKEEL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public ComponentDataFromEntity HNMAMFPDOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[ReadOnly]
	public NativeArray<Entity> OCPHAAPMGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeList<Entity> ADGHFOGIHGF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6EACF70", Offset = "0x6EAC370", VA = "0x186EACF70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OPGKJHEJNDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD0C0", Offset = "0x6EAC4C0", VA = "0x186EAD0C0")]
	[EGNHCFBFNEE]
	public static JobHandle GKEJHKKHLJH(this EntityCommandBufferSystem DCLHOGPFELA, NativeList<Entity> PGJLMFPAKDA, [Optional] JobHandle OMGHOAKHCEK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD250", Offset = "0x6EAC650", VA = "0x186EAD250")]
	[EGNHCFBFNEE]
	public static JobHandle GKEJHKKHLJH(this EntityCommandBufferSystem DCLHOGPFELA, NativeArrayAsync<Entity> PGJLMFPAKDA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CFGCCKMPGIB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8140", Offset = "0x1CE7540", VA = "0x181CE8140")]
	public static void NEDHKOBCHCN<T>(this EntityCommandBufferSystem DCLHOGPFELA, EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7BE0", Offset = "0x1CE6FE0", VA = "0x181CE7BE0")]
	[EGNHCFBFNEE]
	public static JobHandle CIALPEFNOBG<T>(this EntityCommandBufferSystem DCLHOGPFELA, NativeListAsync<Entity> PGJLMFPAKDA, [Optional] JobHandle OMGHOAKHCEK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7A50", Offset = "0x1CE6E50", VA = "0x181CE7A50")]
	[EGNHCFBFNEE]
	public static JobHandle CIALPEFNOBG<T>(this EntityCommandBufferSystem DCLHOGPFELA, NativeArrayAsync<Entity> PGJLMFPAKDA, [Optional] JobHandle OMGHOAKHCEK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IEFDBIINOJA
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct BDOBKELKCJH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public NativeArray<Entity> EFBMNCNINGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NativeArray<T> KJGCOMABNAE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct CNJOLAOMPHD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public NativeList<Entity> EFBMNCNINGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NativeArray<T> KJGCOMABNAE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct PHJANOJNADO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NativeArrayAsync<Entity> EFBMNCNINGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NativeArrayAsync<T> KJGCOMABNAE;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3654AC0", Offset = "0x3653EC0", VA = "0x183654AC0")]
		public NativeListAsync<Entity> LBAEOOMNBFE<TPredicate>() where TPredicate : struct, HJDFDEAFANN<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1817E90", Offset = "0x1817290", VA = "0x181817E90")]
	public static PHJANOJNADO<T> AHJEFLJIEHL<T>(this NativeArrayAsync<Entity> OCPHAAPMGNM, NativeArrayAsync<T> JKBOOFJEDPD, Allocator GMMIODGPFPJ = Allocator.TempJob) where T : struct
	{
		return default(PHJANOJNADO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EIPIADGLHJL : IFPCMOOGJCE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Type MLJKKFEEKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Type EBEAMHCOOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6EABAA0", Offset = "0x6EAAEA0", VA = "0x186EABAA0")]
	public EIPIADGLHJL(Type GOAAPKKHEGI, Type HNMAMFPDOGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class KMEDMFBAEPH
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class EOOJFLMLKNK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1F988C0", Offset = "0x1F97CC0", VA = "0x181F988C0")]
	public static NativeList<Entity> KLKHPDFHGHB<T>(this NativeArray<Entity> OCPHAAPMGNM, EntityManager GLPCEPPDPLB, Allocator GMMIODGPFPJ = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BADFMMEBMHC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly MemoryStream ALHMIMOAGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CodedInputStream DAANECOBIGF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB660", Offset = "0x6EAAA60", VA = "0x186EAB660", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class ODCMMDMEFFL
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct BFDFKGAHECH : CFICKDFMDBF<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> AOCFJMJICCG;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB730", Offset = "0x6EAAB30", VA = "0x186EAB730")]
		[BurstCompatible]
		public Entity MIOHAAIMNDI(in Entity KKIAKNLLHIO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB730", Offset = "0x6EAAB30", VA = "0x186EAB730", Slot = "4")]
		private Entity NLPHNGHDHCG(in Entity KKIAKNLLHIO)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct BADHPBBFHPA<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ENDBJNLNEDA : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BADHPBBFHPA<Protobuf> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA38A80", Offset = "0xA37E80", VA = "0x180A38A80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1EF9100", Offset = "0x1EF8500", VA = "0x181EF9100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1A389D0", Offset = "0x1A37DD0", VA = "0x181A389D0")]
		[DebuggerHidden]
		public ENDBJNLNEDA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1EF8F00", Offset = "0x1EF8300", VA = "0x181EF8F00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1EF90C0", Offset = "0x1EF84C0", VA = "0x181EF90C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Action<Protobuf> CMJKONJHMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MemoryStream ALHMIMOAGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CodedInputStream DAANECOBIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Protobuf AMCOMEAPPLD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int KPHJAIPOAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA71600", Offset = "0xA70A00", VA = "0x180A71600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x24BB5B0", Offset = "0x24BA9B0", VA = "0x1824BB5B0")]
	private BADHPBBFHPA(byte[] GMNLDOEDEPH, Action<Protobuf> CMJKONJHMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x24921A0", Offset = "0x24915A0", VA = "0x1824921A0")]
	public static BADHPBBFHPA<Protobuf> OBPHLOEIGIJ<Data>(ReadOnlySpan<byte> OEKDIKJACFK, ReadOnlySpan<Data> KHFPKPBIJME, Action<Protobuf> CMJKONJHMFK)
	{
		return default(BADHPBBFHPA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x24BB420", Offset = "0x24BA820", VA = "0x1824BB420", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x24BB460", Offset = "0x24BA860", VA = "0x1824BB460", Slot = "4")]
	[IteratorStateMachine(typeof(BADHPBBFHPA<>.ENDBJNLNEDA))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x24BB560", Offset = "0x24BA960", VA = "0x1824BB560", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class HLOJAODEAAM : ECINBHDAKID
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EACB10", Offset = "0x6EABF10", VA = "0x186EACB10", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase BHJHPJOJPMN();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6EACA70", Offset = "0x6EABE70", VA = "0x186EACA70")]
	protected ComponentSystemBase BLGABLEPFLE(params ComponentSystemBase[] OEBMDJNIHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1811F20", Offset = "0x1811320", VA = "0x181811F20")]
	protected ComponentSystemBase BLGABLEPFLE<T>(params ComponentSystemBase[] OEBMDJNIHNJ) where T : ECINBHDAKID, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1811EE0", Offset = "0x18112E0", VA = "0x181811EE0")]
	protected ComponentSystemBase BKKFKNAJIHA<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1811EE0", Offset = "0x18112E0", VA = "0x181811EE0")]
	protected ComponentSystemBase JMCEBHHCICO<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6EACAC0", Offset = "0x6EABEC0", VA = "0x186EACAC0")]
	protected ComponentSystemBase HPPLGAGFHID(params SystemHandleUntyped[] OEBMDJNIHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1812010", Offset = "0x1811410", VA = "0x181812010")]
	protected ComponentSystemBase HPPLGAGFHID<T>(params SystemHandleUntyped[] OEBMDJNIHNJ) where T : ECINBHDAKID, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1811FC0", Offset = "0x18113C0", VA = "0x181811FC0")]
	protected SystemHandleUntyped GBKLHNDBKDD<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EABA40", Offset = "0x6EAAE40", VA = "0x186EABA40")]
	protected HLOJAODEAAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class IDALNLACNML
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1816E70", Offset = "0x1816270", VA = "0x181816E70")]
	public static NativeList<T> IJBOBBKIMPK<T>(NativeList<T> JKBOOFJEDPD, Allocator GMMIODGPFPJ) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class HJOPPMONHJO
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct NKOIMEGLIKG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : CFICKDFMDBF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> KJGCOMABNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeList<TFrom> FLOBPBCDEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeParallelHashSet<TTo> HNFFJIBONPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap FJBAKNFCPGP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct MFOIKCGEAFL<T, TPredicate> : IJob where T : struct where TPredicate : struct, HJDFDEAFANN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<T> KJGCOMABNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> EFBMNCNINGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeList<Entity> CNJEPHDJCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public TPredicate FJBAKNFCPGP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x30BA1B0", Offset = "0x30B95B0", VA = "0x1830BA1B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct ALIHNCAKCBB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, CFICKDFMDBF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<TFrom> NIOLDIMPMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[WriteOnly]
	public NativeList<TTo> IPFAFHCHKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public TMap FJBAKNFCPGP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class KGBKIFFMFNI
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct AGMJFPPIOIL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly NativeArray<T>.ReadOnly KGHLGBOMEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int MIICGJCNLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int IHKJOKJHBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private T MDIINIOKEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private T MKKPKAKGCKF;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public NDLCDGPEBGB CMGKIMKOJIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x27571A0", Offset = "0x27565A0", VA = "0x1827571A0")]
			get
			{
				return default(NDLCDGPEBGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T JCCMBABGMEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x16D0080", Offset = "0x16CF480", VA = "0x1816D0080")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (T, NDLCDGPEBGB) NEGPJPJCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2A2E5D0", Offset = "0x2A2D9D0", VA = "0x182A2E5D0")]
			get
			{
				return default((T, NDLCDGPEBGB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E7E0", Offset = "0x2A2DBE0", VA = "0x182A2E7E0")]
		public AGMJFPPIOIL(NativeArray<T> KGHLGBOMEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x16CFB00", Offset = "0x16CEF00", VA = "0x1816CFB00")]
		public AGMJFPPIOIL<T> FNKOJPGNHJL()
		{
			return default(AGMJFPPIOIL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E440", Offset = "0x2A2D840", VA = "0x182A2E440")]
		public bool MFPHEHFBDAF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2430640", Offset = "0x242FA40", VA = "0x182430640")]
		public MMNCABAOFFE<T, TComparer> JKKHMPDPJOF<TComparer>([Optional] TComparer GMACNHDLMPO) where TComparer : struct, IEqualityComparer<T>
		{
			return default(MMNCABAOFFE<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct MMNCABAOFFE<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly NativeArray<T>.ReadOnly KGHLGBOMEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int MIICGJCNLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int IHKJOKJHBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private T MDIINIOKEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private T MKKPKAKGCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TComparer GMACNHDLMPO;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NDLCDGPEBGB CMGKIMKOJIL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x27571A0", Offset = "0x27565A0", VA = "0x1827571A0")]
			get
			{
				return default(NDLCDGPEBGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public T JCCMBABGMEK
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x16D0080", Offset = "0x16CF480", VA = "0x1816D0080")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public (T value, NDLCDGPEBGB range) NEGPJPJCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2757410", Offset = "0x2756810", VA = "0x182757410")]
			get
			{
				return default((T, NDLCDGPEBGB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x27574E0", Offset = "0x27568E0", VA = "0x1827574E0")]
		public MMNCABAOFFE(NativeArray<T>.ReadOnly KGHLGBOMEFA, TComparer GMACNHDLMPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x26F9920", Offset = "0x26F8D20", VA = "0x1826F9920")]
		public MMNCABAOFFE<T, TComparer> FNKOJPGNHJL()
		{
			return default(MMNCABAOFFE<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x27571B0", Offset = "0x27565B0", VA = "0x1827571B0")]
		public bool MFPHEHFBDAF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2416CF0", Offset = "0x24160F0", VA = "0x182416CF0")]
	public static AGMJFPPIOIL<T> BLGABLEPFLE<T>(this NativeArray<T> KGHLGBOMEFA) where T : struct
	{
		return default(AGMJFPPIOIL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface CFICKDFMDBF<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo MIOHAAIMNDI(in TFrom KKIAKNLLHIO);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DBHJLGNGLAN
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HBELHDEFLDJ
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class KILKOGFPKNK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public KILKOGFPKNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class OHKGOIBIOFJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		public OHKGOIBIOFJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<Func<JobHandle, JobHandle>> GEDGEMIEIEO;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC9F0", Offset = "0x6EABDF0", VA = "0x186EAC9F0")]
	public HBELHDEFLDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class AGIILGJFDDL
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class KMPGAAGIPLF : EntityCommandBufferSystem, HNMPEJHBFDG
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
	protected KMPGAAGIPLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FEEGEJIBNLE
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8170", Offset = "0x1DA7570", VA = "0x181DA8170")]
	[EGNHCFBFNEE]
	public static JobHandle JJCJDDNJEDB<T>(this EntityCommandBufferSystem DCLHOGPFELA, NativeArray<Entity> PGJLMFPAKDA, NativeArray<T> KJFNAECAHBA, JobHandle OMGHOAKHCEK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct AMHHLBDPLHK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<T> KJGCOMABNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<T> FLOBPBCDEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<T> HNFFJIBONPK;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x30F36B0", Offset = "0x30F2AB0", VA = "0x1830F36B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct EBDOFNAIHBE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> PGJLMFPAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EntityCommandBuffer FFLDGNLHFCF;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB9B0", Offset = "0x6EAADB0", VA = "0x186EAB9B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NPPCHNEGGMK
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9ED0", Offset = "0x2BD92D0", VA = "0x182BD9ED0")]
	public static NativeArray<T> IGMGAJACJPL<T>(this NativeList<Entity> JKBOOFJEDPD, EntityManager GLPCEPPDPLB, Allocator GMMIODGPFPJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9D00", Offset = "0x2BD9100", VA = "0x182BD9D00")]
	public static NativeArray<T> IGMGAJACJPL<T>(this NativeArray<Entity> JKBOOFJEDPD, EntityManager GLPCEPPDPLB, Allocator GMMIODGPFPJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EBEKAMBNEOH
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DBDCMMGHJLC
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal struct LGDPPMLBOJF<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> PGJLMFPAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public T KKIAKNLLHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public EntityCommandBuffer FFLDGNLHFCF;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x20407C0", Offset = "0x203FBC0", VA = "0x1820407C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class PFMJEHKJKJA
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x12D1C90", Offset = "0x12D1090", VA = "0x1812D1C90")]
	[EGNHCFBFNEE]
	public static JobHandle BNKKHKGLEFA<T>(this EntityCommandBufferSystem DCLHOGPFELA, EntityCommandBuffer FFLDGNLHFCF, EntityQuery PNGFJEAJDGO, T KKIAKNLLHIO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class COGDMJFIJON<Data> : PKOHIJKDADP where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public virtual Data DEEICBABDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF900", Offset = "0x1EBED00", VA = "0x181EBF900", Slot = "8")]
	protected virtual bool NMMEKCFKCMH(ReadOnlySpan<Data> KHFPKPBIJME, GKONMMGJICI OOALNHDBAGI, out ReadOnlySpan<byte> OEKDIKJACFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E8C00", Offset = "0x7E8000", VA = "0x1807E8C00", Slot = "9")]
	protected virtual bool GCJJHEOCKGG(int HEGEMCIFGEI, Span<Data> KHFPKPBIJME, in ReadOnlySpan<byte> OEKDIKJACFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2C035F0", Offset = "0x2C029F0", VA = "0x182C035F0", Slot = "5")]
	internal sealed override bool NMMEKCFKCMH(ref Unity.Entities.Chunk NCPBFICMLEP, int HJMEELBLBIN, GKONMMGJICI OOALNHDBAGI, out ReadOnlySpan<byte> OEKDIKJACFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2C022C0", Offset = "0x2C016C0", VA = "0x182C022C0", Slot = "6")]
	internal sealed override bool GCJJHEOCKGG(int HEGEMCIFGEI, ref Unity.Entities.Chunk NCPBFICMLEP, int HJMEELBLBIN, in ReadOnlySpan<byte> OEKDIKJACFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2495A10", Offset = "0x2494E10", VA = "0x182495A10")]
	protected ANDKBLLGBOP<Protobuf> DLPMNPNBDEO<Protobuf>(ReadOnlySpan<Data> KHFPKPBIJME) where Protobuf : IMessage, new()
	{
		return default(ANDKBLLGBOP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2495A60", Offset = "0x2494E60", VA = "0x182495A60")]
	protected BADHPBBFHPA<Protobuf> KBGHMCIPEAP<Protobuf>(ReadOnlySpan<byte> OEKDIKJACFK, ReadOnlySpan<Data> KHFPKPBIJME, Action<Protobuf> CMJKONJHMFK) where Protobuf : IMessage, new()
	{
		return default(BADHPBBFHPA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1EFEF40", Offset = "0x1EFE340", VA = "0x181EFEF40")]
	protected COGDMJFIJON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class PKOHIJKDADP
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected abstract int EGCDHDOFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD360", Offset = "0x6EAC760", VA = "0x186EAD360", Slot = "5")]
	internal virtual bool NMMEKCFKCMH(ref Unity.Entities.Chunk NCPBFICMLEP, int HJMEELBLBIN, GKONMMGJICI OOALNHDBAGI, out ReadOnlySpan<byte> OEKDIKJACFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7E8C00", Offset = "0x7E8000", VA = "0x1807E8C00", Slot = "6")]
	internal virtual bool GCJJHEOCKGG(int HEGEMCIFGEI, ref Unity.Entities.Chunk NCPBFICMLEP, int HJMEELBLBIN, in ReadOnlySpan<byte> OEKDIKJACFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	protected PKOHIJKDADP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NAPGHOENMJK
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct CNEINJGLLAD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct FFPOCJGLMLI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal CNEINJGLLAD<TFrom> ILDFJHMNOPJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> CDNLFOGBLLG;
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct GJKFEGIFGNF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public struct LACHDEHOEEJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal GJKFEGIFGNF<TFrom> ILDFJHMNOPJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> CDNLFOGBLLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct CKEJFAMEBBC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public struct CKFIFCPGDLN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal CKEJFAMEBBC<TFrom> ILDFJHMNOPJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> CDNLFOGBLLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct CBBNHGCEICD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public struct MOGPJMCDJML<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal CBBNHGCEICD<TFrom> ILDFJHMNOPJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> CDNLFOGBLLG;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct LKENJMGJELG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	public ComponentDataFromEntity MCLEBMLJNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	public NativeArray<Entity> KJGCOMABNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[WriteOnly]
	public NativeArray<byte> IPFAFHCHKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int IBJLEPPHMPP;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6EACD70", Offset = "0x6EAC170", VA = "0x186EACD70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[BurstCompile]
internal struct MCJPOMJOHDG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HNMAMFPDOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[ReadOnly]
	public NativeArray<Entity> OCPHAAPMGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<bool> NHGGPJPGDDG;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal struct PIKHNMEAEJO<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[ReadOnly]
	public NativeArray<Entity> PGJLMFPAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[ReadOnly]
	public NativeArray<T> FHJNGFFBLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public EntityCommandBuffer FFLDGNLHFCF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class NOAOJFFIOME
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9740", Offset = "0x2BD8B40", VA = "0x182BD9740")]
	public static NativeListAsync<Entity> OPCFIONIAHA<T, TPredicate>(this NativeArrayAsync<T> JKBOOFJEDPD, NativeArrayAsync<Entity> OCPHAAPMGNM, Allocator GMMIODGPFPJ = Allocator.TempJob) where T : struct where TPredicate : struct, HJDFDEAFANN<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9590", Offset = "0x2BD8990", VA = "0x182BD9590")]
	private static NativeListAsync<Entity> BCGACJFKPCO<T, TPredicate>(NativeArrayAsync<T> FEJDNCNEPDB, NativeArrayAsync<Entity> OCPHAAPMGNM, int PGBALNGGNPG, Allocator GMMIODGPFPJ) where T : struct where TPredicate : struct, HJDFDEAFANN<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class PLEHLHNCLNJ
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x35BE520", Offset = "0x35BD920", VA = "0x1835BE520")]
	[EGNHCFBFNEE]
	public static JobHandle CENADEHNEMK<T>(this EntityCommandBufferSystem DCLHOGPFELA, NativeArray<Entity> PGJLMFPAKDA, T KKIAKNLLHIO, [Optional] JobHandle OMGHOAKHCEK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x35BE5F0", Offset = "0x35BD9F0", VA = "0x1835BE5F0")]
	[EGNHCFBFNEE]
	public static JobHandle CENADEHNEMK<T>(this EntityCommandBufferSystem DCLHOGPFELA, EntityCommandBuffer FFLDGNLHFCF, NativeArray<Entity> PGJLMFPAKDA, T KKIAKNLLHIO, [Optional] JobHandle OMGHOAKHCEK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GKONMMGJICI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> PEEBAALLMCO;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8910", Offset = "0x1FC7D10", VA = "0x181FC8910")]
	public GKONMMGJICI(NativeArray<EntityRemapUtility.EntityRemapInfo> PEEBAALLMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC6E0", Offset = "0x6EABAE0", VA = "0x186EAC6E0")]
	public Entity NEAHLDNEEML(Entity CANIEFMHGCA)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class EEFFLLHNBNC
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1F90F40", Offset = "0x1F90340", VA = "0x181F90F40")]
	public static NativeList<T> IJBOBBKIMPK<T>(this NativeList<T> JKBOOFJEDPD, Allocator GMMIODGPFPJ = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1F90D70", Offset = "0x1F90170", VA = "0x181F90D70")]
	public static NativeList<T> IJBOBBKIMPK<T>(this NativeArray<T> JKBOOFJEDPD, Allocator GMMIODGPFPJ = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IBBNINBEAKE
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct OPAOHDKAGCJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> KJGCOMABNAE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct GONFBPAJHBA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<T> KJGCOMABNAE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct EBOLKKJHHJK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<T> KJGCOMABNAE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct BMIPJHDPEPK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeListAsync<T> KJGCOMABNAE;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
internal struct FLMOMJJBMPC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, CFICKDFMDBF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeArray<TFrom> KJGCOMABNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[WriteOnly]
	public NativeArray<TTo> IPFAFHCHKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TMap FJBAKNFCPGP;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface HJDFDEAFANN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LBAEOOMNBFE(T KKIAKNLLHIO);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
internal struct GKMMJPLINOL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	public NativeArray<Entity> PGJLMFPAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public EntityCommandBuffer FFLDGNLHFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public ComponentTypes DLFDEDPKHME;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC680", Offset = "0x6EABA80", VA = "0x186EAC680", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[BurstCompile]
internal struct APKMHPECMKM<T, TPredicate> : IJob where T : struct where TPredicate : struct, HJDFDEAFANN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	public NativeArray<T> KJGCOMABNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<T> FLOBPBCDEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public TPredicate FJBAKNFCPGP;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class ECINBHDAKID : EFJAMNAKIBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6EABA10", Offset = "0x6EAAE10", VA = "0x186EABA10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6EABA40", Offset = "0x6EAAE40", VA = "0x186EABA40")]
	public ECINBHDAKID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[BurstCompile]
internal struct JPJFONEBONL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HNMAMFPDOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	public NativeArray<Entity> OCPHAAPMGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<bool> NHGGPJPGDDG;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3277890", Offset = "0x3276C90", VA = "0x183277890", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct LCJEFGOPJKH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<Entity> PGJLMFPAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	public NativeArray<T> KJFNAECAHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public EntityCommandBuffer FFLDGNLHFCF;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x203C2D0", Offset = "0x203B6D0", VA = "0x18203C2D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class LNNDNHEHAFG
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6EACEE0", Offset = "0x6EAC2E0", VA = "0x186EACEE0")]
	public static ulong GOJKIDNMNHM(Type JLNNFEOBAMK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6EACE70", Offset = "0x6EAC270", VA = "0x186EACE70")]
	public static ulong GOJKIDNMNHM(string CLIBLAFENCL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class JKECMDGJAIN : IFPCMOOGJCE
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Type EBEAMHCOOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x34655A0", Offset = "0x34649A0", VA = "0x1834655A0")]
	public JKECMDGJAIN(Type HNMAMFPDOGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[BurstCompile]
internal struct BEMKDHHGANK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public ComponentDataFromEntity HNMAMFPDOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	public NativeArray<Entity> OCPHAAPMGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<Entity> ADGHFOGIHGF;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB6A0", Offset = "0x6EAAAA0", VA = "0x186EAB6A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public abstract class JKIEMPJPHGI : SystemBase, HNMPEJHBFDG
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6EACC60", Offset = "0x6EAC060", VA = "0x186EACC60")]
	public ComponentDataFromEntity DAMDNJHIAOL(int EPAJCDGEEKI, bool LIHCGKJOJDH = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EACC40", Offset = "0x6EAC040", VA = "0x186EACC40")]
	public EntityExistenceLookupByEntity BDMHDIMLIKC()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6EACD30", Offset = "0x6EAC130", VA = "0x186EACD30", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16F50", VA = "0x180D17B50")]
	protected JKIEMPJPHGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class KBODFINGEBH : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6EACD40", Offset = "0x6EAC140", VA = "0x186EACD40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16F50", VA = "0x180D17B50")]
	protected KBODFINGEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class MBKNDBKOJPO
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct ANDKBLLGBOP<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly byte[] GMNLDOEDEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Protobuf AMCOMEAPPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly MemoryStream ALHMIMOAGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly CodedOutputStream ECOHCJBPDON;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x30F4F80", Offset = "0x30F4380", VA = "0x1830F4F80")]
	private ANDKBLLGBOP(byte[] GMNLDOEDEPH, in Protobuf AMCOMEAPPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2432480", Offset = "0x2431880", VA = "0x182432480")]
	public static ANDKBLLGBOP<Protobuf> OBPHLOEIGIJ<T>(ReadOnlySpan<T> KHFPKPBIJME)
	{
		return default(ANDKBLLGBOP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x30F4E30", Offset = "0x30F4230", VA = "0x1830F4E30")]
	public void BGLDHEPGIJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x30F4DA0", Offset = "0x30F41A0", VA = "0x1830F4DA0")]
	public ByteString AFMFBLIACIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x30F4E60", Offset = "0x30F4260", VA = "0x1830F4E60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface HNMPEJHBFDG
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public abstract class EFJAMNAKIBJ : ComponentSystemGroup, HNMPEJHBFDG
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6EABA40", Offset = "0x6EAAE40", VA = "0x186EABA40")]
	protected EFJAMNAKIBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class IDDDCGGHGNH
{
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[BurstCompile]
internal struct IFMNEBCENAC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KNJGGDAAPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public NativeArray<Entity> KJGCOMABNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[WriteOnly]
	public NativeList<T> FLOBPBCDEDC;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[Flags]
public enum AHCAMFMAIIJ
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
public class PFNECKMFGPE : IFPCMOOGJCE
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16F50", VA = "0x180D17B50")]
	public PFNECKMFGPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class NKKENBLBNDM
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public readonly struct APLDFHOBBAK<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly NativeArray<TSrc> KGHLGBOMEFA;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA5220", Offset = "0xAA4620", VA = "0x180AA5220")]
		public APLDFHOBBAK(NativeArray<TSrc> KGHLGBOMEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x12E63E0", Offset = "0x12E57E0", VA = "0x1812E63E0")]
		public JHNHJLFHPBJ<TSrc, TValue> DNIGDGHINHD<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(JHNHJLFHPBJ<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct JHNHJLFHPBJ<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly NativeArray<TSrc> KGHLGBOMEFA;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAA5220", Offset = "0xAA4620", VA = "0x180AA5220")]
		public JHNHJLFHPBJ(NativeArray<TSrc> KGHLGBOMEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x12E63E0", Offset = "0x12E57E0", VA = "0x1812E63E0")]
		public BPJBFHNFPKJ<TSrc, TValue, TSelector> PLCKEMCONAJ<TSelector>() where TSelector : struct, CFICKDFMDBF<TSrc, TValue>
		{
			return default(BPJBFHNFPKJ<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct BPJBFHNFPKJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, CFICKDFMDBF<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly NativeArray<TSrc> KGHLGBOMEFA;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAA5220", Offset = "0xAA4620", VA = "0x180AA5220")]
		public BPJBFHNFPKJ(NativeArray<TSrc> KGHLGBOMEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x23E9270", Offset = "0x23E8670", VA = "0x1823E9270")]
		public BKAIFHPCHAF<TSrc, TValue, TSelector> BLGABLEPFLE()
		{
			return default(BKAIFHPCHAF<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct CECOLMBOAKB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, CFICKDFMDBF<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly NativeArray<TSrc> KGHLGBOMEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TSelector DCBDGEGEAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int NANJAGEOPJI;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TValue NEGPJPJCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x2CDBE60", Offset = "0x2CDB260", VA = "0x182CDBE60")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int BJNMAHEDMNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x9CDAB0", Offset = "0x9CCEB0", VA = "0x1809CDAB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int KPHJAIPOAJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x16CFBC0", Offset = "0x16CEFC0", VA = "0x1816CFBC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBED0", Offset = "0x2CDB2D0", VA = "0x182CDBED0")]
		public CECOLMBOAKB(NativeArray<TSrc> KGHLGBOMEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBE50", Offset = "0x2CDB250", VA = "0x182CDBE50")]
		public bool MFPHEHFBDAF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBD30", Offset = "0x2CDB130", VA = "0x182CDBD30")]
		private TSrc BGNBOEOKNEH(int GNPGECNAJNK)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public struct BKAIFHPCHAF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, CFICKDFMDBF<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private CECOLMBOAKB<TSrc, TValue, TSelector> EOIJHGCOGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TValue MDIINIOKEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int MIICGJCNLLL;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NDLCDGPEBGB CMGKIMKOJIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x24D0FB0", Offset = "0x24D03B0", VA = "0x1824D0FB0")]
			get
			{
				return default(NDLCDGPEBGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TValue JCCMBABGMEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x9C0750", Offset = "0x9BFB50", VA = "0x1809C0750")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (TValue value, NDLCDGPEBGB range) NEGPJPJCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x24D1120", Offset = "0x24D0520", VA = "0x1824D1120")]
			get
			{
				return default((TValue, NDLCDGPEBGB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x24D11F0", Offset = "0x24D05F0", VA = "0x1824D11F0")]
		public BKAIFHPCHAF(NativeArray<TSrc> KGHLGBOMEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAB0", Offset = "0x16CEEB0", VA = "0x1816CFAB0")]
		public BKAIFHPCHAF<TSrc, TValue, TSelector> FNKOJPGNHJL()
		{
			return default(BKAIFHPCHAF<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x24D0FF0", Offset = "0x24D03F0", VA = "0x1824D0FF0")]
		public bool MFPHEHFBDAF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9330", Offset = "0x2BD8730", VA = "0x182BD9330")]
	public static APLDFHOBBAK<T> IJGNIHNKBDF<T>(this NativeList<T> OCCNFAKIALD) where T : struct
	{
		return default(APLDFHOBBAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x12E63E0", Offset = "0x12E57E0", VA = "0x1812E63E0")]
	public static APLDFHOBBAK<T> IJGNIHNKBDF<T>(this NativeArray<T> KGHLGBOMEFA) where T : struct
	{
		return default(APLDFHOBBAK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class BOHEFDICBJP
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct NMCHADGNPDN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct HEGIEMEDAFG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public NMCHADGNPDN<TFrom> CDNLFOGBLLG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NativeArray<TFrom> KJGCOMABNAE;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct NNMIGEHGIGF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public struct OCFKDNODLDJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public NNMIGEHGIGF<TFrom> CDNLFOGBLLG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeArrayAsync<TFrom> KJGCOMABNAE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct NGPEIHEGLNM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public struct CNGPGIKEMHD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public NGPEIHEGLNM<TFrom> CDNLFOGBLLG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Allocator GMMIODGPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NativeListAsync<TFrom> KJGCOMABNAE;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[BurstCompile]
internal struct GIGLGKCADNM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	public NativeArray<Entity> PGJLMFPAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public EntityCommandBuffer FFLDGNLHFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public ComponentType IJBDFBDGHPH;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC290", Offset = "0x6EAB690", VA = "0x186EAC290", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class GGCOMMHGJOG
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1975D30", Offset = "0x1975130", VA = "0x181975D30")]
	public static bool DMFDPMKCCMH<T>(this NativeArray<Entity> OCPHAAPMGNM, EntityManager GLPCEPPDPLB, Allocator GMMIODGPFPJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class HJBANKJDGED
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class JICDFBLEBKD
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class GOCHOHIDFOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public delegate void ANJCPCCCINP<From, To>(From CDNLFOGBLLG, ref To OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI);

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private class NIOLAODBNIK<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static ANJCPCCCINP<From, To> OOFLDPDAGPG;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public NIOLAODBNIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC6F0", Offset = "0x6EABAF0", VA = "0x186EAC6F0")]
	static GOCHOHIDFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x197CE80", Offset = "0x197C280", VA = "0x18197CE80")]
	public static void IBKOPODJDFC<T>(ANJCPCCCINP<T, T> JPCNADHMKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x18030C0", Offset = "0x18024C0", VA = "0x1818030C0")]
	public static void IBKOPODJDFC<From, To>(ANJCPCCCINP<From, To> JPCNADHMKLL, ANJCPCCCINP<To, From> EPCKNNGGGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1803ED0", Offset = "0x18032D0", VA = "0x181803ED0")]
	public static void IBKOPODJDFC<From, To>(ANJCPCCCINP<From, To> OOFLDPDAGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1805630", Offset = "0x1804A30", VA = "0x181805630")]
	public static ANJCPCCCINP<From, To> KFKLODKHPDJ<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x197B3A0", Offset = "0x197A7A0", VA = "0x18197B3A0")]
	public static void HOGEDLONAAA<From, To>(From CDNLFOGBLLG, ref To OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class GBHPOOOIJKD
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x196BF40", Offset = "0x196B340", VA = "0x18196BF40")]
	[EGNHCFBFNEE]
	public static JobHandle BIOEAMMECBN<T>(this EntityCommandBufferSystem DCLHOGPFELA, NativeArrayAsync<Entity> PGJLMFPAKDA, NativeArrayAsync<T> KJFNAECAHBA, [Optional] JobHandle OMGHOAKHCEK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x196C1E0", Offset = "0x196B5E0", VA = "0x18196C1E0")]
	[EGNHCFBFNEE]
	public static JobHandle BIOEAMMECBN<T>(this EntityCommandBufferSystem DCLHOGPFELA, NativeArrayAsync<Entity> PGJLMFPAKDA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x196BE20", Offset = "0x196B220", VA = "0x18196BE20")]
	[EGNHCFBFNEE]
	public static JobHandle BIOEAMMECBN<T>(this EntityCommandBufferSystem DCLHOGPFELA, NativeArray<Entity> PGJLMFPAKDA, [Optional] JobHandle OMGHOAKHCEK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6EABFC0", Offset = "0x6EAB3C0", VA = "0x186EABFC0")]
	[EGNHCFBFNEE]
	public static JobHandle BIOEAMMECBN(this EntityCommandBufferSystem DCLHOGPFELA, NativeArray<Entity> PGJLMFPAKDA, ComponentTypes DLFDEDPKHME, [Optional] JobHandle OMGHOAKHCEK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC130", Offset = "0x6EAB530", VA = "0x186EAC130")]
	[EGNHCFBFNEE]
	public static JobHandle BIOEAMMECBN(this EntityCommandBufferSystem DCLHOGPFELA, EntityCommandBuffer FFLDGNLHFCF, NativeArray<Entity> PGJLMFPAKDA, ComponentTypes DLFDEDPKHME, [Optional] JobHandle OMGHOAKHCEK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class EMNFEPNFNMC
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6EABAF0", Offset = "0x6EAAEF0", VA = "0x186EABAF0")]
	private unsafe static Span<byte> AJJNDOKCDCK(Unity.Entities.Chunk* NCPBFICMLEP, int HJMEELBLBIN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F92A60", Offset = "0x1F91E60", VA = "0x181F92A60")]
	public unsafe static Span<T> PPKMAAALINF<T>(Unity.Entities.Chunk* NCPBFICMLEP, int HJMEELBLBIN)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F92A20", Offset = "0x1F91E20", VA = "0x181F92A20")]
	public static Span<T> PPKMAAALINF<T>(this ref Unity.Entities.Chunk NCPBFICMLEP, int HJMEELBLBIN)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6EABCB0", Offset = "0x6EAB0B0", VA = "0x186EABCB0")]
	public unsafe static Span<Entity> HPBBPOGGGME(Unity.Entities.Chunk* NCPBFICMLEP)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6EABD20", Offset = "0x6EAB120", VA = "0x186EABD20")]
	public unsafe static void PEHJALIONDD(Unity.Entities.Chunk* NCPBFICMLEP, int HJMEELBLBIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[AttributeUsage(AttributeTargets.Class)]
public class GKFPOBEDICJ : IFPCMOOGJCE
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16F50", VA = "0x180D17B50")]
	public GKFPOBEDICJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface MAJNHENMBOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AINGAMLNGOC(Entity FKNFFDFGNMN, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBBDJKBBABP(Entity FKNFFDFGNMN, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BOMAGAFBIPN(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LHGDENCJPBH(Entity FKNFFDFGNMN);
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class GGBAMIOCDFC<TComponentData, TValue> : LKNDCGPKKAH<TValue>, IDisposable where TComponentData : struct, KFABDBNJOME
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class EJDHHNEFHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private List<(object token, TValue value)> OCCNFAKIALD;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int NPBPHODFKMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xEF36D0", Offset = "0xEF2AD0", VA = "0x180EF36D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2E7C790", Offset = "0x2E7BB90", VA = "0x182E7C790")]
		public bool JEMGMBLNCPO(out TValue KKIAKNLLHIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2E7C630", Offset = "0x2E7BA30", VA = "0x182E7C630")]
		public void EBOHBLNDMAL(object GAOLOMEJCOK, TValue KKIAKNLLHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2E7C850", Offset = "0x2E7BC50", VA = "0x182E7C850")]
		public bool PBDAKCGNFND(object GAOLOMEJCOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2E7C6E0", Offset = "0x2E7BAE0", VA = "0x182E7C6E0")]
		public int HPIHLCGNKBB(object GAOLOMEJCOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2E7C8D0", Offset = "0x2E7BCD0", VA = "0x182E7C8D0")]
		public EJDHHNEFHNC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly Stack<EJDHHNEFHNC> IMKODGIOIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private FAFDPBICOBM<IKOLGHEENFH, EJDHHNEFHNC> DMGMCIAGPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private EntityManager GLPCEPPDPLB;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x212A930", Offset = "0x2129D30", VA = "0x18212A930")]
	public GGBAMIOCDFC(EntityManager GLPCEPPDPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x212A2C0", Offset = "0x21296C0", VA = "0x18212A2C0", Slot = "4")]
	public void AINGAMLNGOC(Entity FKNFFDFGNMN, object GAOLOMEJCOK, TValue KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x212A4B0", Offset = "0x21298B0", VA = "0x18212A4B0", Slot = "5")]
	public bool CBBDJKBBABP(Entity FKNFFDFGNMN, object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x212A750", Offset = "0x2129B50", VA = "0x18212A750", Slot = "6")]
	public bool JEMGMBLNCPO(Entity FKNFFDFGNMN, out TValue KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x212A640", Offset = "0x2129A40", VA = "0x18212A640", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x212A8B0", Offset = "0x2129CB0", VA = "0x18212A8B0")]
	private void OHCAJNMCCAB(EJDHHNEFHNC BGIMJDCBHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x212A680", Offset = "0x2129A80", VA = "0x18212A680")]
	private bool JDABPIPNAEH(Entity FKNFFDFGNMN, out IKOLGHEENFH PPCGBBAKOHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x212A820", Offset = "0x2129C20", VA = "0x18212A820")]
	private void MBECBNMJEGB(Entity FKNFFDFGNMN, IKOLGHEENFH PPCGBBAKOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x212A660", Offset = "0x2129A60", VA = "0x18212A660")]
	private bool GNNAMBBIHAP(IKOLGHEENFH PPCGBBAKOHO, out EJDHHNEFHNC BGIMJDCBHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x212A3E0", Offset = "0x21297E0", VA = "0x18212A3E0")]
	private EJDHHNEFHNC BCFLKLCCGAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface LKNDCGPKKAH<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AINGAMLNGOC(Entity FKNFFDFGNMN, object GAOLOMEJCOK, TValue KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBBDJKBBABP(Entity FKNFFDFGNMN, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JEMGMBLNCPO(Entity FKNFFDFGNMN, out TValue KKIAKNLLHIO);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface KFABDBNJOME : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IKOLGHEENFH EKEDFBPLNFC
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
public struct IKOLGHEENFH : AJHCFBOLAKM, IEquatable<IKOLGHEENFH>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly IKOLGHEENFH GBNLDGHKLNF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	[CreateProperty]
	public int BJNMAHEDMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	[CreateProperty]
	public int EGCDHDOFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x16CFC90", Offset = "0x16CF090", VA = "0x1816CFC90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2513720", Offset = "0x2512B20", VA = "0x182513720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6EACB60", Offset = "0x6EABF60", VA = "0x186EACB60", Slot = "8")]
	public bool Equals(IKOLGHEENFH LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6EACBB0", Offset = "0x6EABFB0", VA = "0x186EACBB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class DFOLNBFBKAD<THasTokensTag> : MAJNHENMBOI, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Dictionary<Entity, IKOLGHEENFH> MIFHOPOAGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Stack<HashSet<object>> IMKODGIOIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private FAFDPBICOBM<IKOLGHEENFH, HashSet<object>> DMGMCIAGPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private EntityManager GLPCEPPDPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private EntityCommandBufferSystem DCLHOGPFELA;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3051500", Offset = "0x3050900", VA = "0x183051500")]
	public DFOLNBFBKAD(EntityManager GLPCEPPDPLB, EntityCommandBufferSystem DCLHOGPFELA, PILIJFIMAJF LJPCNBDDJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x304EDC0", Offset = "0x304E1C0", VA = "0x18304EDC0", Slot = "4")]
	public bool AINGAMLNGOC(Entity FKNFFDFGNMN, object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x304FB20", Offset = "0x304EF20", VA = "0x18304FB20", Slot = "5")]
	public bool CBBDJKBBABP(Entity FKNFFDFGNMN, object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x304F2E0", Offset = "0x304E6E0", VA = "0x18304F2E0", Slot = "6")]
	public bool BOMAGAFBIPN(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x304F4A0", Offset = "0x304E8A0", VA = "0x18304F4A0", Slot = "9")]
	public bool BOMAGAFBIPN(IKOLGHEENFH PPCGBBAKOHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3050D30", Offset = "0x3050130", VA = "0x183050D30", Slot = "7")]
	public bool LHGDENCJPBH(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x304FD80", Offset = "0x304F180", VA = "0x18304FD80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3051420", Offset = "0x3050820", VA = "0x183051420")]
	private void OHCAJNMCCAB(HashSet<object> BGIMJDCBHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x30507B0", Offset = "0x304FBB0", VA = "0x1830507B0")]
	private bool JDABPIPNAEH(Entity FKNFFDFGNMN, out IKOLGHEENFH PPCGBBAKOHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3050020", Offset = "0x304F420", VA = "0x183050020")]
	private bool HABIJLLFFBH(Entity FKNFFDFGNMN, out IKOLGHEENFH PPCGBBAKOHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3050480", Offset = "0x304F880", VA = "0x183050480")]
	private void HNOMKBCJFJN(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x304FC70", Offset = "0x304F070", VA = "0x18304FC70")]
	private void CKHAEPLJDGO(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3051250", Offset = "0x3050650", VA = "0x183051250")]
	private void NIHGGCFLNLC(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3050E90", Offset = "0x3050290", VA = "0x183050E90")]
	private void MBECBNMJEGB(Entity FKNFFDFGNMN, IKOLGHEENFH PPCGBBAKOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x304FEA0", Offset = "0x304F2A0", VA = "0x18304FEA0")]
	private bool GAOGCCINAEN(IKOLGHEENFH PPCGBBAKOHO, out HashSet<object> BGIMJDCBHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x304EF20", Offset = "0x304E320", VA = "0x18304EF20")]
	private HashSet<object> BCFLKLCCGAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class BLCAFNHLBHF
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void FPOKFGBKMMF(this PILIJFIMAJF FDJKGAAPBBG, NativeArray<Entity> PGJLMFPAKDA, [Optional][CallerFilePath] string DKMINILHIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void FPOKFGBKMMF(this PILIJFIMAJF FDJKGAAPBBG, string DKPHPKDPBCM, NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void FPOKFGBKMMF(this PILIJFIMAJF FDJKGAAPBBG, string DKMINILHIKE, NativeArray<Entity> PGJLMFPAKDA, bool KEGOAFNBFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void LAFCMPLCFEH(this PILIJFIMAJF FDJKGAAPBBG, NativeArray<Entity> PGJLMFPAKDA, EntityManager GLPCEPPDPLB, [Optional][CallerFilePath] string DKMINILHIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void LAFCMPLCFEH(this PILIJFIMAJF FDJKGAAPBBG, string DKMINILHIKE, NativeArray<Entity> PGJLMFPAKDA, EntityManager GLPCEPPDPLB, bool KEGOAFNBFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void MJCLKKJBDIO(this PILIJFIMAJF FDJKGAAPBBG, NativeArray<Entity> PGJLMFPAKDA, NativeArray<Entity> NKKFHEHKJKO, [Optional][CallerFilePath] string DKMINILHIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void MJCLKKJBDIO(this PILIJFIMAJF FDJKGAAPBBG, string DKMINILHIKE, NativeArray<Entity> PGJLMFPAKDA, NativeArray<Entity> NKKFHEHKJKO, bool KEGOAFNBFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3306450", Offset = "0x3305850", VA = "0x183306450")]
	public static void NLBFLAHDKMN<T>(this PILIJFIMAJF FDJKGAAPBBG, string DKPHPKDPBCM, NativeArray<Entity> PGJLMFPAKDA, NativeList<T> KJFNAECAHBA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x33064E0", Offset = "0x33058E0", VA = "0x1833064E0")]
	public static void NLBFLAHDKMN<T>(this PILIJFIMAJF FDJKGAAPBBG, NativeArray<Entity> PGJLMFPAKDA, NativeArray<T> KJFNAECAHBA, [Optional][CallerFilePath] string DKMINILHIKE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3306530", Offset = "0x3305930", VA = "0x183306530")]
	public static void NLBFLAHDKMN<T>(this PILIJFIMAJF FDJKGAAPBBG, string DKPHPKDPBCM, NativeArray<Entity> PGJLMFPAKDA, NativeArray<T> KJFNAECAHBA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void NLBFLAHDKMN<T>(this PILIJFIMAJF FDJKGAAPBBG, string DKMINILHIKE, NativeArray<Entity> PGJLMFPAKDA, NativeArray<T> KJFNAECAHBA, bool KEGOAFNBFKB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x33063C0", Offset = "0x33057C0", VA = "0x1833063C0")]
	public static void KOOOIALIDCL<T>(this PILIJFIMAJF FDJKGAAPBBG, NativeList<T> KJFNAECAHBA, [Optional][CallerFilePath] string DKMINILHIKE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3306420", Offset = "0x3305820", VA = "0x183306420")]
	public static void KOOOIALIDCL<T>(this PILIJFIMAJF FDJKGAAPBBG, NativeArray<T> KJFNAECAHBA, [Optional][CallerFilePath] string DKMINILHIKE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void KOOOIALIDCL<T>(this PILIJFIMAJF FDJKGAAPBBG, string DKMINILHIKE, NativeArray<T> KJFNAECAHBA, bool KEGOAFNBFKB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void CODNJDDMHNC(this PILIJFIMAJF FDJKGAAPBBG, EntityQuery PNGFJEAJDGO, [Optional][CallerFilePath] string DKMINILHIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void CODNJDDMHNC(this PILIJFIMAJF FDJKGAAPBBG, string DKPHPKDPBCM, EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void CODNJDDMHNC(this PILIJFIMAJF FDJKGAAPBBG, string DKMINILHIKE, EntityQuery PNGFJEAJDGO, bool KEGOAFNBFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3306390", Offset = "0x3305790", VA = "0x183306390")]
	public static void EPCCIGPFBBB<T, T2>(this PILIJFIMAJF FDJKGAAPBBG, string DKPHPKDPBCM, EntityQuery PNGFJEAJDGO) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void EPCCIGPFBBB<T, T2>(this PILIJFIMAJF FDJKGAAPBBG, string DKMINILHIKE, EntityQuery PNGFJEAJDGO, bool KEGOAFNBFKB) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3306390", Offset = "0x3305790", VA = "0x183306390")]
	public static void GEKLFICDCOM<T>(this PILIJFIMAJF FDJKGAAPBBG, string DKPHPKDPBCM, NativeList<T> KGHLGBOMEFA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void GEKLFICDCOM<T>(this PILIJFIMAJF FDJKGAAPBBG, string DKMINILHIKE, NativeList<T> KGHLGBOMEFA, bool KEGOAFNBFKB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3306390", Offset = "0x3305790", VA = "0x183306390")]
	public static void GAGCIAADMKD<T>(this PILIJFIMAJF FDJKGAAPBBG, string DKPHPKDPBCM, NativeArray<T> KGHLGBOMEFA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public static void GAGCIAADMKD<T>(this PILIJFIMAJF FDJKGAAPBBG, string DKMINILHIKE, NativeArray<T> KGHLGBOMEFA, bool KEGOAFNBFKB) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class CBCPDCNEBEL
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public CBCPDCNEBEL()
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

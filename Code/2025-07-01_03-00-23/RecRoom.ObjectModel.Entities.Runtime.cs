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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x816D820", Offset = "0x816BE20", VA = "0x18816D820")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
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
		[Cpp2IlInjected.Address(RVA = "0x816CB20", Offset = "0x816B120", VA = "0x18816CB20")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HOMABKLJMOO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	INJKFEIDPBK MFPDAEKCEDN
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
public interface BNMJFKBCCCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PPDHOBFIKFJ(Entity DFPJIKCEODG, object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OIJCOOCDACO(Entity DFPJIKCEODG, object DKFMAIJGPFL, [Out] bool LINJNHMFABI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HCMPKIANCOG(Entity DFPJIKCEODG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OBINIKMHNDI<TComponentData, TValue> : HGIDPCLMOFP<TValue>, IDisposable where TComponentData : struct, HOMABKLJMOO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class BHKPLMJHIKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> BGGFBGFNIID;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int DFHEGHDHDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x43253A0", Offset = "0x43239A0", VA = "0x1843253A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61F9700", Offset = "0x61F7D00", VA = "0x1861F9700")]
		public bool ANNPPKOOEED([Out] TValue KKGBKLFKCPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x61F9950", Offset = "0x61F7F50", VA = "0x1861F9950")]
		public void JDPCENHCAFL(object DKFMAIJGPFL, TValue KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x61F97F0", Offset = "0x61F7DF0", VA = "0x1861F97F0")]
		public bool BAFGFGCDOJB(object DKFMAIJGPFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x61F9870", Offset = "0x61F7E70", VA = "0x1861F9870")]
		public int EFKJNNOOGEF(object DKFMAIJGPFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x61F9A00", Offset = "0x61F8000", VA = "0x1861F9A00")]
		public BHKPLMJHIKO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<BHKPLMJHIKO> PPEJMLANPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private CDDOMKLENMF<INJKFEIDPBK, BHKPLMJHIKO> NHGCNCICLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager MAHCJNEKFMD;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x57A96B0", Offset = "0x57A7CB0", VA = "0x1857A96B0")]
	public OBINIKMHNDI(EntityManager MAHCJNEKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x57A9570", Offset = "0x57A7B70", VA = "0x1857A9570", Slot = "4")]
	public void PPDHOBFIKFJ(Entity DFPJIKCEODG, object DKFMAIJGPFL, TValue KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x57A93D0", Offset = "0x57A79D0", VA = "0x1857A93D0", Slot = "5")]
	public bool OIJCOOCDACO(Entity DFPJIKCEODG, object DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x57A9110", Offset = "0x57A7710", VA = "0x1857A9110", Slot = "6")]
	public bool ANNPPKOOEED(Entity DFPJIKCEODG, [Out] TValue KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x57A92A0", Offset = "0x57A78A0", VA = "0x1857A92A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x57A9210", Offset = "0x57A7810", VA = "0x1857A9210")]
	private void DLDJEGKKDDB(BHKPLMJHIKO MFGGHPAABCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x57A9050", Offset = "0x57A7650", VA = "0x1857A9050")]
	private bool AIJLHMFDBIP(Entity DFPJIKCEODG, [Out] INJKFEIDPBK MNCGAKBHIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x57A8F60", Offset = "0x57A7560", VA = "0x1857A8F60")]
	private void ACDHDOGPDLC(Entity DFPJIKCEODG, INJKFEIDPBK MNCGAKBHIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x57A92C0", Offset = "0x57A78C0", VA = "0x1857A92C0")]
	private bool EEJNGJFDCGJ(INJKFEIDPBK MNCGAKBHIPL, [Out] BHKPLMJHIKO MFGGHPAABCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x57A92E0", Offset = "0x57A78E0", VA = "0x1857A92E0")]
	private BHKPLMJHIKO GDMKMGMIOLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HGIDPCLMOFP<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPDHOBFIKFJ(Entity DFPJIKCEODG, object DKFMAIJGPFL, TValue KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OIJCOOCDACO(Entity DFPJIKCEODG, object DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ANNPPKOOEED(Entity DFPJIKCEODG, [Out] TValue KKGBKLFKCPO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct INJKFEIDPBK : PEDJJCFICCD, IEquatable<INJKFEIDPBK>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly INJKFEIDPBK PAIEKNMKJII;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int BPENJJIEFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int IECDKBKDFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x306D380", Offset = "0x306B980", VA = "0x18306D380", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7175C10", Offset = "0x7174210", VA = "0x187175C10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x816D050", Offset = "0x816B650", VA = "0x18816D050", Slot = "8")]
	public bool Equals(INJKFEIDPBK HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x816D0A0", Offset = "0x816B6A0", VA = "0x18816D0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GFAKMOEMCCM<THasTokensTag> : BNMJFKBCCCL, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, INJKFEIDPBK> HMNAPHALFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> PPEJMLANPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CDDOMKLENMF<INJKFEIDPBK, HashSet<object>> NHGCNCICLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager MAHCJNEKFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem MDKIABFNJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool DNDJADKEJII;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4D535B0", Offset = "0x4D51BB0", VA = "0x184D535B0")]
	public GFAKMOEMCCM(EntityManager MAHCJNEKFMD, EntityCommandBufferSystem MDKIABFNJOH, LHMKAIAPMBI MJKNLPEKIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4D52C10", Offset = "0x4D51210", VA = "0x184D52C10", Slot = "4")]
	public bool PPDHOBFIKFJ(Entity DFPJIKCEODG, object DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4D52760", Offset = "0x4D50D60", VA = "0x184D52760", Slot = "5")]
	public bool OIJCOOCDACO(Entity DFPJIKCEODG, object DKFMAIJGPFL, [Out] bool LINJNHMFABI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4D517F0", Offset = "0x4D4FDF0", VA = "0x184D517F0", Slot = "6")]
	public bool HCMPKIANCOG(Entity DFPJIKCEODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4D51880", Offset = "0x4D4FE80", VA = "0x184D51880", Slot = "8")]
	public bool HCMPKIANCOG(INJKFEIDPBK MNCGAKBHIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4D51440", Offset = "0x4D4FA40", VA = "0x184D51440", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4D51350", Offset = "0x4D4F950", VA = "0x184D51350")]
	private void DLDJEGKKDDB(HashSet<object> MFGGHPAABCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4D50C20", Offset = "0x4D4F220", VA = "0x184D50C20")]
	private bool AIJLHMFDBIP(Entity DFPJIKCEODG, [Out] INJKFEIDPBK MNCGAKBHIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D52B50", Offset = "0x4D51150", VA = "0x184D52B50")]
	private bool PBOFKCAOEPP(Entity DFPJIKCEODG, [Out] INJKFEIDPBK MNCGAKBHIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D510F0", Offset = "0x4D4F6F0", VA = "0x184D510F0")]
	private void DAMBLEBJOLE(Entity DFPJIKCEODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D51DC0", Offset = "0x4D503C0", VA = "0x184D51DC0")]
	private void LFIGOJGNCFO(Entity DFPJIKCEODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4D520D0", Offset = "0x4D506D0", VA = "0x184D520D0")]
	private void NJMFOMIBJDC(Entity DFPJIKCEODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4D50A10", Offset = "0x4D4F010", VA = "0x184D50A10")]
	private void ACDHDOGPDLC(Entity DFPJIKCEODG, INJKFEIDPBK MNCGAKBHIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4D51ED0", Offset = "0x4D504D0", VA = "0x184D51ED0")]
	private bool MOJDDJDDGJF(INJKFEIDPBK MNCGAKBHIPL, [Out] HashSet<object> MFGGHPAABCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D51600", Offset = "0x4D4FC00", VA = "0x184D51600")]
	private HashSet<object> GDMKMGMIOLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HICGLCNFJNK
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct CLEDFAAKMNB : EFIJGKGEBHP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x816C8A0", Offset = "0x816AEA0", VA = "0x18816C8A0")]
	public float EPIOCFCNAPF([In] float3 KKGBKLFKCPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x816C8A0", Offset = "0x816AEA0", VA = "0x18816C8A0", Slot = "4")]
	private float ONLNLMIFIPJ([In] float3 KKGBKLFKCPO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NNMKKKAGMOM : EFIJGKGEBHP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x816D810", Offset = "0x816BE10", VA = "0x18816D810")]
	public float EPIOCFCNAPF([In] float3 KKGBKLFKCPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x816D810", Offset = "0x816BE10", VA = "0x18816D810", Slot = "4")]
	private float ONLNLMIFIPJ([In] float3 KKGBKLFKCPO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct IEFKBPGFJDI : EFIJGKGEBHP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xF55F70", Offset = "0xF54570", VA = "0x180F55F70")]
	public float EPIOCFCNAPF([In] float3 KKGBKLFKCPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xF55F70", Offset = "0xF54570", VA = "0x180F55F70", Slot = "4")]
	private float ONLNLMIFIPJ([In] float3 KKGBKLFKCPO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KBMMLIDMNDJ : EFIJGKGEBHP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x236E430", Offset = "0x236CA30", VA = "0x18236E430")]
	public int EPIOCFCNAPF([In] int3 KKGBKLFKCPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x236E430", Offset = "0x236CA30", VA = "0x18236E430", Slot = "4")]
	private int DEIAGCOFBIC([In] int3 KKGBKLFKCPO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KNLKOOMMPBC : EFIJGKGEBHP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x12E2670", Offset = "0x12E0C70", VA = "0x1812E2670")]
	public int EPIOCFCNAPF([In] int3 KKGBKLFKCPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x12E2670", Offset = "0x12E0C70", VA = "0x1812E2670", Slot = "4")]
	private int DEIAGCOFBIC([In] int3 KKGBKLFKCPO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct CIECDHHMAII : EFIJGKGEBHP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xF1A7A0", Offset = "0xF18DA0", VA = "0x180F1A7A0")]
	public int EPIOCFCNAPF([In] int3 KKGBKLFKCPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xF1A7A0", Offset = "0xF18DA0", VA = "0x180F1A7A0", Slot = "4")]
	private int DEIAGCOFBIC([In] int3 KKGBKLFKCPO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HIMBGNLKCBC : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2253320", Offset = "0x2251920", VA = "0x182253320")]
	public HIMBGNLKCBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class JBGFFILIMFO : SystemBase, OOPLPEEGANI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x816D0F0", Offset = "0x816B6F0", VA = "0x18816D0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B980D0", Offset = "0x3B966D0", VA = "0x183B980D0")]
	public void FKDMFIBDIIN<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B980D0", Offset = "0x3B966D0", VA = "0x183B980D0")]
	public void KNFCKEKCMNE<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x816D2D0", Offset = "0x816B8D0", VA = "0x18816D2D0")]
	public JobHandle GMFNCMHAIOK(ReadOnlySpan<int> PDGNOAADDFI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B98400", Offset = "0x3B96A00", VA = "0x183B98400")]
	public JobHandle PHGBPLINJNA<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x816D390", Offset = "0x816B990", VA = "0x18816D390")]
	public JobHandle PHGBPLINJNA(ReadOnlySpan<int> PDGNOAADDFI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B97820", Offset = "0x3B95E20", VA = "0x183B97820")]
	public void DPJALBNOMKA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B97760", Offset = "0x3B95D60", VA = "0x183B97760")]
	public JobHandle DPJALBNOMKA<T>(JobHandle MNCGAKBHIPL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x816D120", Offset = "0x816B720", VA = "0x18816D120")]
	public JobHandle DPJALBNOMKA(ReadOnlySpan<int> PDGNOAADDFI, JobHandle MNCGAKBHIPL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B97820", Offset = "0x3B95E20", VA = "0x183B97820")]
	public void JAHKCIDEFAE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B98120", Offset = "0x3B96720", VA = "0x183B98120")]
	public JobHandle JAHKCIDEFAE<T>(JobHandle MNCGAKBHIPL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x816D320", Offset = "0x816B920", VA = "0x18816D320")]
	public JobHandle JAHKCIDEFAE(Span<int> PDGNOAADDFI, JobHandle MNCGAKBHIPL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B98020", Offset = "0x3B96620", VA = "0x183B98020")]
	public ComponentDataFromEntity EKGAGKMOFKI<T>(bool CDOBNCPPFGA = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x816D1B0", Offset = "0x816B7B0", VA = "0x18816D1B0")]
	public ComponentDataFromEntity EKGAGKMOFKI(int DMAFLMBDGGM, bool CDOBNCPPFGA = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3B98360", Offset = "0x3B96960", VA = "0x183B98360")]
	public SharedComponentIndexFromEntity<T> LABHLAPLKKJ<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x816D270", Offset = "0x816B870", VA = "0x18816D270")]
	[BurstCompatible]
	public ComponentTypeHandle FJNEHFOCGNN(ComponentType PMNIGOGOBHI)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x816D190", Offset = "0x816B790", VA = "0x18816D190")]
	public EntityExistenceLookupByEntity EHIFALDMBKK()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x816D3E0", Offset = "0x816B9E0", VA = "0x18816D3E0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B97640", Offset = "0x3B95C40", VA = "0x183B97640")]
	public bool AEFIEOAFBJC<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2253320", Offset = "0x2251920", VA = "0x182253320")]
	protected JBGFFILIMFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class KDKILMHOJMI : JBGFFILIMFO
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x816D400", Offset = "0x816BA00", VA = "0x18816D400", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2253320", Offset = "0x2251920", VA = "0x182253320")]
	protected KDKILMHOJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DLFBACOHCEP
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KFBFLAFEHLP : EntityCommandBufferSystem, OOPLPEEGANI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private LHMKAIAPMBI OAAFJAHOMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE31810", Offset = "0xE2FE10", VA = "0x180E31810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x816D430", Offset = "0x816BA30", VA = "0x18816D430")]
	public KFBFLAFEHLP(LHMKAIAPMBI NDJJBNFFFGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EFIJGKGEBHP<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo EPIOCFCNAPF([In] TFrom KKGBKLFKCPO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DEBACKHIMHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JAHNLJOHFKI(T KKGBKLFKCPO);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct NKOIJNLGNAK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> DCGEKCKMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer ODJNBPDHJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes AAONABAICIP;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x816D720", Offset = "0x816BD20", VA = "0x18816D720", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct CCLBPOMGJJE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> DCGEKCKMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer ODJNBPDHJIO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x816C800", Offset = "0x816AE00", VA = "0x18816C800", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct FNMAHLMIICA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> DCGEKCKMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer ODJNBPDHJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType PMNIGOGOBHI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x816CB40", Offset = "0x816B140", VA = "0x18816CB40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct JDOALLHFMKD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> DCGEKCKMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> ACJFHCNBBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer ODJNBPDHJIO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x518B3C0", Offset = "0x51899C0", VA = "0x18518B3C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct OEJODHMNDDG<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> DCGEKCKMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> NIJLHKNCLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer ODJNBPDHJIO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct CJHAALCBJDE<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> DCGEKCKMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T KKGBKLFKCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer ODJNBPDHJIO;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct LDDCPHNPEGK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, EFIJGKGEBHP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> GHMGNLLPNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> ONLJDEOJNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap CJDOILFHDJI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct ACAHIGODAGB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity PABMCJCLENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> GHMGNLLPNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> ONLJDEOJNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int NIJJGNDIEJH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x816C570", Offset = "0x816AB70", VA = "0x18816C570", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct OECEMLIHCOK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KBPCMMHMJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> GHMGNLLPNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> GDAJFNNGAML;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct EBJCBGAEAHP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, EFIJGKGEBHP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> DAADLAFBDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> ONLJDEOJNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap CJDOILFHDJI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct KOKJLHAILIH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AMBNOFPJNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> PHEOFFAPGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> BNFMFFBLBFK;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct FGBJJDALGIH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AMBNOFPJNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> PHEOFFAPGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> BNFMFFBLBFK;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4C07ED0", Offset = "0x4C064D0", VA = "0x184C07ED0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct IPEJCHCOMLH<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> GHMGNLLPNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> GDAJFNNGAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> CCLKAJNHDME;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0AC0", Offset = "0x4F9F0C0", VA = "0x184FA0AC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct GMKGCLJPOED<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : EFIJGKGEBHP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> GHMGNLLPNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> GDAJFNNGAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> CCLKAJNHDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap CJDOILFHDJI;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct PMOKBHLBPBH<T, TPredicate> : IJob where T : struct where TPredicate : struct, DEBACKHIMHF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> GHMGNLLPNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> PJKCHIAFHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> KAGBIDCKMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate CJDOILFHDJI;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct CAJEDGINGHD<T, TPredicate> : IJob where T : struct where TPredicate : struct, DEBACKHIMHF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> GHMGNLLPNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> GDAJFNNGAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate CJDOILFHDJI;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct CLHDMAFBIGB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity AMBNOFPJNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> PHEOFFAPGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> BIKBMHPNGBP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x816C8B0", Offset = "0x816AEB0", VA = "0x18816C8B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct PLAAOLJOLMG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity AMBNOFPJNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> PHEOFFAPGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> BIKBMHPNGBP;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x816D8A0", Offset = "0x816BEA0", VA = "0x18816D8A0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class BFBLGDEAIOF
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class FAKBOAKNGAI
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CA30", Offset = "0x3B1B030", VA = "0x183B1CA30")]
	public static bool CNFOAEOJGCL<T>(this NativeArray<Entity> PHEOFFAPGMH, EntityManager MAHCJNEKFMD, Allocator HOHBLCPFIEJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class GPJAEALCCPA
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class EOCINDMFKMB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public EOCINDMFKMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DENPCELHMKG<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public DENPCELHMKG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> BHLEHLGALIK;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x816CD30", Offset = "0x816B330", VA = "0x18816CD30")]
	public GPJAEALCCPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DLOBJHHNNHL
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class MAOIPNALCEK
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct KPDHAKHEDJG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct LLKMNDKJJHM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal KPDHAKHEDJG<TFrom> NBIJLPJHNNE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> LFMKIINCPNH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct CPPCCEAGBMG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct NICCJLDJHGG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal CPPCCEAGBMG<TFrom> NBIJLPJHNNE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> LFMKIINCPNH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct GHKKNAPNCMG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct AMFGEGBEJLF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal GHKKNAPNCMG<TFrom> NBIJLPJHNNE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> LFMKIINCPNH;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct LOPCHPJIGAE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct HIPBPCNBNOG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal LOPCHPJIGAE<TFrom> NBIJLPJHNNE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> LFMKIINCPNH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class FGDHIAPDFGI
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class OBDMAPEOHHA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6AF0", Offset = "0x3CE50F0", VA = "0x183CE6AF0")]
	public static NativeList<T> KPFFKNAGHJO<T>(this NativeArray<T> HCLIMLODNJL, Allocator HOHBLCPFIEJ = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class MIEJJLMHNDP
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class NANNPDPMFDI
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3C843B0", Offset = "0x3C829B0", VA = "0x183C843B0")]
	[NKGFHIOAOBD]
	public static JobHandle GACHCAICJDI<T>(this EntityCommandBufferSystem MDKIABFNJOH, NativeArray<Entity> DCGEKCKMHBF, NativeArray<T> ACJFHCNBBBO) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3C83F90", Offset = "0x3C82590", VA = "0x183C83F90")]
	[NKGFHIOAOBD]
	public static JobHandle GACHCAICJDI<T>(this EntityCommandBufferSystem MDKIABFNJOH, NativeArrayAsync<Entity> DCGEKCKMHBF, NativeArrayAsync<T> ACJFHCNBBBO, [Optional] JobHandle NPGGKLEPILC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3C83E70", Offset = "0x3C82470", VA = "0x183C83E70")]
	[NKGFHIOAOBD]
	public static JobHandle GACHCAICJDI<T>(this EntityCommandBufferSystem MDKIABFNJOH, NativeArray<Entity> DCGEKCKMHBF, [Optional] JobHandle NPGGKLEPILC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x816D460", Offset = "0x816BA60", VA = "0x18816D460")]
	[NKGFHIOAOBD]
	public static JobHandle GACHCAICJDI(this EntityCommandBufferSystem MDKIABFNJOH, NativeArray<Entity> DCGEKCKMHBF, ComponentTypes AAONABAICIP, [Optional] JobHandle NPGGKLEPILC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x816D5D0", Offset = "0x816BBD0", VA = "0x18816D5D0")]
	[NKGFHIOAOBD]
	public static JobHandle GACHCAICJDI(this EntityCommandBufferSystem MDKIABFNJOH, EntityCommandBuffer ODJNBPDHJIO, NativeArray<Entity> DCGEKCKMHBF, ComponentTypes AAONABAICIP, [Optional] JobHandle NPGGKLEPILC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class GLLODJFBJEN
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class HFPOHDJINOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x816CEC0", Offset = "0x816B4C0", VA = "0x18816CEC0")]
	[NKGFHIOAOBD]
	public static JobHandle HNABCNEAFLI(this EntityCommandBufferSystem MDKIABFNJOH, NativeList<Entity> DCGEKCKMHBF, [Optional] JobHandle NPGGKLEPILC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x816CDC0", Offset = "0x816B3C0", VA = "0x18816CDC0")]
	[NKGFHIOAOBD]
	public static JobHandle HNABCNEAFLI(this EntityCommandBufferSystem MDKIABFNJOH, NativeArrayAsync<Entity> DCGEKCKMHBF)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CCKNPPFCKLK
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x392C220", Offset = "0x392A820", VA = "0x18392C220")]
	public static void PDAOLINEMLA<T>(this EntityCommandBufferSystem MDKIABFNJOH, EntityQuery GBEHOCFFBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x392C180", Offset = "0x392A780", VA = "0x18392C180")]
	[NKGFHIOAOBD]
	public static JobHandle IMCMDPPPPBL<T>(this EntityCommandBufferSystem MDKIABFNJOH, NativeArrayAsync<Entity> DCGEKCKMHBF, [Optional] JobHandle NPGGKLEPILC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x816C670", Offset = "0x816AC70", VA = "0x18816C670")]
	[NKGFHIOAOBD]
	public static JobHandle IMCMDPPPPBL(this EntityCommandBufferSystem MDKIABFNJOH, NativeArrayAsync<Entity> DCGEKCKMHBF, ComponentType PMNIGOGOBHI, [Optional] JobHandle NPGGKLEPILC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class KJPHDMKCMCK
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE5C0", Offset = "0x3BDCBC0", VA = "0x183BDE5C0")]
	[NKGFHIOAOBD]
	public static JobHandle OCFGHPNJLGM<T>(this EntityCommandBufferSystem MDKIABFNJOH, NativeArray<Entity> DCGEKCKMHBF, NativeArray<T> ACJFHCNBBBO, JobHandle NPGGKLEPILC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class PGCBDFEEKDP
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NEMCJFGFKPA
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DPEALEHGIPO
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x39A27C0", Offset = "0x39A0DC0", VA = "0x1839A27C0")]
	public static NativeArray<T> HNFPCFKGHDH<T>(this NativeList<Entity> HCLIMLODNJL, EntityManager MAHCJNEKFMD, Allocator HOHBLCPFIEJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x39A2600", Offset = "0x39A0C00", VA = "0x1839A2600")]
	public static NativeArray<T> HNFPCFKGHDH<T>(this NativeArray<Entity> HCLIMLODNJL, EntityManager MAHCJNEKFMD, Allocator HOHBLCPFIEJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x816C940", Offset = "0x816AF40", VA = "0x18816C940")]
	public static NativeArray<Entity> EOEJMEHOABI(this NativeArray<Entity> HCLIMLODNJL, EntityManager MAHCJNEKFMD, ComponentType PMNIGOGOBHI, Allocator HOHBLCPFIEJ = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x39A2500", Offset = "0x39A0B00", VA = "0x1839A2500")]
	public static NativeArray<T> HACMCKAONLN<T>(this NativeArray<Entity> HCLIMLODNJL, EntityManager MAHCJNEKFMD, Allocator HOHBLCPFIEJ = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class JELKOJMGFDM
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct DEOEKOCEFGN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct DMCDHMPDAFK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public DEOEKOCEFGN<TFrom> LFMKIINCPNH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> GHMGNLLPNJI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct BDEPMAHOPHF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct EGAPPLBAHOB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public BDEPMAHOPHF<TFrom> LFMKIINCPNH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> GHMGNLLPNJI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct KJDCNAKNIPL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct LCAJDDLEMDE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public KJDCNAKNIPL<TFrom> LFMKIINCPNH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> GHMGNLLPNJI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class LDLNAMDOBAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class JFKIPODGNMI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct JEECCGKJAEF : EFIJGKGEBHP<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> GHDKPOFGKNN;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x816D3F0", Offset = "0x816B9F0", VA = "0x18816D3F0")]
		[BurstCompatible]
		public Entity EPIOCFCNAPF([In] Entity KKGBKLFKCPO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x816D3F0", Offset = "0x816B9F0", VA = "0x18816D3F0", Slot = "4")]
		private Entity LFAFIPBJFNL([In] Entity KKGBKLFKCPO)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class KCPKONCPMOC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct CFIBOCHGAHD<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6799AD0", Offset = "0x67980D0", VA = "0x186799AD0", Slot = "4")]
		public int Compare((TKey, TValue) POMHCCBBBGD, (TKey, TValue) JKKMGDMGNFG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA080", Offset = "0x3BC8680", VA = "0x183BCA080")]
	public static void LKCHPPHHBFL<TKey, TValue>(NativeList<TKey> FMGBKKGFMOM, NativeList<TValue> NIJLHKNCLKB) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA2F0", Offset = "0x3BC88F0", VA = "0x183BCA2F0")]
	public static void LKCHPPHHBFL<TKey, TValue>(NativeArray<TKey> FMGBKKGFMOM, NativeArray<TValue> NIJLHKNCLKB) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9E70", Offset = "0x3BC8470", VA = "0x183BC9E70")]
	public static void LKCHPPHHBFL<TKey, TValue, U>(NativeArray<TKey> FMGBKKGFMOM, NativeArray<TValue> NIJLHKNCLKB, U ALMJGIDFIMC) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class EIMPALODMGI
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct BPGGEDADIDF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> PJKCHIAFHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> GHMGNLLPNJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct CMDCNLHDMHG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> PJKCHIAFHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> GHMGNLLPNJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct FDFDJBDCMEL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> PJKCHIAFHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> GHMGNLLPNJI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class EHINDILKFOE
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class PCKONDEBIJB
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct EDNJIJOJHJI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> GHMGNLLPNJI;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct AFPPEIBJBCH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> GHMGNLLPNJI;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct MJBCIKOJCOE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> GHMGNLLPNJI;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct IHKGMJHLEFD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator HOHBLCPFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> GHMGNLLPNJI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class PJKFNFHFDOE
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class JCKMCOPLHEB
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A660", Offset = "0x3B98C60", VA = "0x183B9A660")]
	public static NativeList<Entity> BOOKMBCHKAB<T>(this NativeList<Entity> PHEOFFAPGMH, EntityManager MAHCJNEKFMD, Allocator HOHBLCPFIEJ = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A060", Offset = "0x3B98660", VA = "0x183B9A060")]
	public static NativeList<Entity> BOOKMBCHKAB<T>(this NativeArray<Entity> PHEOFFAPGMH, EntityManager MAHCJNEKFMD, Allocator HOHBLCPFIEJ = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class PAPKCCGGOFM
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3CF5200", Offset = "0x3CF3800", VA = "0x183CF5200")]
	public static NativeList<Entity> PAMKMKADLJC<T>(this NativeArray<Entity> PHEOFFAPGMH, EntityManager MAHCJNEKFMD, Allocator HOHBLCPFIEJ = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class FGPGDELNEOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct JOMPMIGPJNC<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> DDENONPPKCL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct ECHIIBAHNNK<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> DDENONPPKCL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct HLEDKOHFOAI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, EFIJGKGEBHP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> DDENONPPKCL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct GMBEIPEKAKI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, EFIJGKGEBHP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> DDENONPPKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector DHBPACPCEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int KHMHPNKMLMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct HDGNCAGOGNC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, EFIJGKGEBHP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private GMBEIPEKAKI<TSrc, TValue, TSelector> OOGKDOBKKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue MNCGHHHIJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int IGHNHCKLCCN;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class ILNGHLIMADP
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct PLNJBKDDIJA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> DDENONPPKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int IGHNHCKLCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int OIHHHIKEPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T MNCGHHHIJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T GBNLOLCONDO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public HABDMPMOHEE LFCNNBOOAOP
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4DF3310", Offset = "0x4DF1910", VA = "0x184DF3310")]
			get
			{
				return default(HABDMPMOHEE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T ONGJDJCOEBN
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, HABDMPMOHEE) CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4DF2EF0", Offset = "0x4DF14F0", VA = "0x184DF2EF0")]
			get
			{
				return default((T, HABDMPMOHEE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x58F3230", Offset = "0x58F1830", VA = "0x1858F3230")]
		public PLNJBKDDIJA(NativeArray<T> DDENONPPKCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FCA0", Offset = "0x2B8E2A0", VA = "0x182B8FCA0")]
		public PLNJBKDDIJA<T> DHKFMABLBKB()
		{
			return default(PLNJBKDDIJA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x58F2E00", Offset = "0x58F1400", VA = "0x1858F2E00")]
		public bool FBIFJHFEFCO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x42B5790", Offset = "0x42B3D90", VA = "0x1842B5790")]
		public HGMALMEHOFN<T, TComparer> LFPOBOFCIGB<TComparer>([Optional] TComparer ALMJGIDFIMC) where TComparer : struct, IEqualityComparer<T>
		{
			return default(HGMALMEHOFN<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct HGMALMEHOFN<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> DDENONPPKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int IGHNHCKLCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int OIHHHIKEPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T MNCGHHHIJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T GBNLOLCONDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer ALMJGIDFIMC;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HABDMPMOHEE LFCNNBOOAOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4DF3310", Offset = "0x4DF1910", VA = "0x184DF3310")]
			get
			{
				return default(HABDMPMOHEE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T ONGJDJCOEBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, HABDMPMOHEE range) CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x4DF2EF0", Offset = "0x4DF14F0", VA = "0x184DF2EF0")]
			get
			{
				return default((T, HABDMPMOHEE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4DF3320", Offset = "0x4DF1920", VA = "0x184DF3320")]
		public HGMALMEHOFN(NativeArray<T> DDENONPPKCL, TComparer ALMJGIDFIMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x484B6C0", Offset = "0x4849CC0", VA = "0x18484B6C0")]
		public HGMALMEHOFN<T, TComparer> DHKFMABLBKB()
		{
			return default(HGMALMEHOFN<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4DF3100", Offset = "0x4DF1700", VA = "0x184DF3100")]
		public bool FBIFJHFEFCO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B82E60", Offset = "0x3B81460", VA = "0x183B82E60")]
	public static PLNJBKDDIJA<T> JIMGALFGFHN<T>(this NativeArray<T> DDENONPPKCL) where T : struct
	{
		return default(PLNJBKDDIJA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface NIJCLFOJMNL
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class DKDMLFAKGBH
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct CDOKJPECLNG<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class PLBPDIIBGJE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CDOKJPECLNG<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D02AF0", Offset = "0x4D010F0", VA = "0x184D02AF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public PLBPDIIBGJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x58E7A30", Offset = "0x58E6030", VA = "0x1858E7A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x58E7BE0", Offset = "0x58E61E0", VA = "0x1858E7BE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> PEJOONKMFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream HPOBJJDBMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream ONJMODBGGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf OLLPKLKPIGH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6795E20", Offset = "0x6794420", VA = "0x186795E20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6795E60", Offset = "0x6794460", VA = "0x186795E60", Slot = "4")]
	[IteratorStateMachine(typeof(CDOKJPECLNG<>.PLBPDIIBGJE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6795F50", Offset = "0x6794550", VA = "0x186795F50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LJEIPKDBEGN<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] LBNJMEGEAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf OLLPKLKPIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream HPOBJJDBMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream LDNGLFJBJPA;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5415CF0", Offset = "0x54142F0", VA = "0x185415CF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct GHLDKOLKNCE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream HPOBJJDBMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream ONJMODBGGLL;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x816CCF0", Offset = "0x816B2F0", VA = "0x18816CCF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct GBCGHGPPADC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] LBNJMEGEAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream HPOBJJDBMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream LDNGLFJBJPA;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x816CBC0", Offset = "0x816B1C0", VA = "0x18816CBC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class KHFBIIMOKKA
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class FBPIJEKEGHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum NIGBEHFCPMA
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
internal static class AKGJBDNNJCJ
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class ILCOKFFEKFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ILCOKFFEKFJ()
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

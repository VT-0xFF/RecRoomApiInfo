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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82C38C0", Offset = "0x82C24C0", VA = "0x1882C38C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82C2F00", Offset = "0x82C1B00", VA = "0x1882C2F00")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JFMAFOHJGBG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GKFLOHMIEAL KENOBOABDKD
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
public interface LAINCKIPLAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OEOJDHEONPC(Entity CGLPEGHHGMM, object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ILGBNFLKMHG(Entity CGLPEGHHGMM, object DANCOEFIHDF, [Out] bool IDKDAOFNAMO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EIBOFOPGACF(Entity CGLPEGHHGMM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DABBNCGCEPC<TComponentData, TValue> : IKAHKHGAAFN<TValue>, IDisposable where TComponentData : struct, JFMAFOHJGBG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class EAJAENHHPOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> ADEANPNALNF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int POLDAEOLMKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x443AEA0", Offset = "0x4439AA0", VA = "0x18443AEA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x48C6F30", Offset = "0x48C5B30", VA = "0x1848C6F30")]
		public bool EBCNAFJBKNC([Out] TValue BKMPCFIAHIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x48C7160", Offset = "0x48C5D60", VA = "0x1848C7160")]
		public void NDGLNAHKHEG(object DANCOEFIHDF, TValue BKMPCFIAHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x48C7000", Offset = "0x48C5C00", VA = "0x1848C7000")]
		public bool ENKPLOICKCM(object DANCOEFIHDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x48C7080", Offset = "0x48C5C80", VA = "0x1848C7080")]
		public int KFAOOJCFEOF(object DANCOEFIHDF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x48C7210", Offset = "0x48C5E10", VA = "0x1848C7210")]
		public EAJAENHHPOK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<EAJAENHHPOK> JODMFKFMBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private COODAAFILBG<GKFLOHMIEAL, EAJAENHHPOK> JKNCCIKJFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager HFPCKBDCDBJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x444DE80", Offset = "0x444CA80", VA = "0x18444DE80")]
	public DABBNCGCEPC(EntityManager HFPCKBDCDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x444DD60", Offset = "0x444C960", VA = "0x18444DD60", Slot = "4")]
	public void OEOJDHEONPC(Entity CGLPEGHHGMM, object DANCOEFIHDF, TValue BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x444DAD0", Offset = "0x444C6D0", VA = "0x18444DAD0", Slot = "5")]
	public bool ILGBNFLKMHG(Entity CGLPEGHHGMM, object DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x444D850", Offset = "0x444C450", VA = "0x18444D850", Slot = "6")]
	public bool EBCNAFJBKNC(Entity CGLPEGHHGMM, [Out] TValue BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x444D830", Offset = "0x444C430", VA = "0x18444D830", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x444D7A0", Offset = "0x444C3A0", VA = "0x18444D7A0")]
	private void BGBGBKMBLNO(EAJAENHHPOK CKMLBEACEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x444DA10", Offset = "0x444C610", VA = "0x18444DA10")]
	private bool HDFIHANNKFB(Entity CGLPEGHHGMM, [Out] GKFLOHMIEAL PHMFHDLJBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x444DC80", Offset = "0x444C880", VA = "0x18444DC80")]
	private void MJMAIDOOECO(Entity CGLPEGHHGMM, GKFLOHMIEAL PHMFHDLJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x444DC60", Offset = "0x444C860", VA = "0x18444DC60")]
	private bool IPODAJMOBMF(GKFLOHMIEAL PHMFHDLJBOO, [Out] EAJAENHHPOK CKMLBEACEOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x444D930", Offset = "0x444C530", VA = "0x18444D930")]
	private EAJAENHHPOK GALNDAPMFEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IKAHKHGAAFN<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEOJDHEONPC(Entity CGLPEGHHGMM, object DANCOEFIHDF, TValue BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ILGBNFLKMHG(Entity CGLPEGHHGMM, object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EBCNAFJBKNC(Entity CGLPEGHHGMM, [Out] TValue BKMPCFIAHIG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GKFLOHMIEAL : PDCJNGLGLLH, IEquatable<GKFLOHMIEAL>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly GKFLOHMIEAL DNKJCLIALLN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int CLIFKJOPCGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x14B6AC0", Offset = "0x14B56C0", VA = "0x1814B6AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int IJGCLEGIDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3119BD0", Offset = "0x31187D0", VA = "0x183119BD0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E6AD40", Offset = "0x6E69940", VA = "0x186E6AD40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82C31E0", Offset = "0x82C1DE0", VA = "0x1882C31E0", Slot = "8")]
	public bool Equals(GKFLOHMIEAL IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82C3230", Offset = "0x82C1E30", VA = "0x1882C3230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HIIELAFIJJA<THasTokensTag> : LAINCKIPLAH, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, GKFLOHMIEAL> CGNDIBGOKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> JODMFKFMBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private COODAAFILBG<GKFLOHMIEAL, HashSet<object>> JKNCCIKJFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager HFPCKBDCDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem HOJDMKEGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool BNHFKKOIPKI;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4F94AE0", Offset = "0x4F936E0", VA = "0x184F94AE0")]
	public HIIELAFIJJA(EntityManager HFPCKBDCDBJ, EntityCommandBufferSystem HOJDMKEGOCA, PEOHNMCPNIJ PHJNONCNPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4F93E80", Offset = "0x4F92A80", VA = "0x184F93E80", Slot = "4")]
	public bool OEOJDHEONPC(Entity CGLPEGHHGMM, object DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4F93670", Offset = "0x4F92270", VA = "0x184F93670", Slot = "5")]
	public bool ILGBNFLKMHG(Entity CGLPEGHHGMM, object DANCOEFIHDF, [Out] bool IDKDAOFNAMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4F92630", Offset = "0x4F91230", VA = "0x184F92630", Slot = "6")]
	public bool EIBOFOPGACF(Entity CGLPEGHHGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4F926B0", Offset = "0x4F912B0", VA = "0x184F926B0", Slot = "8")]
	public bool EIBOFOPGACF(GKFLOHMIEAL PHMFHDLJBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4F92530", Offset = "0x4F91130", VA = "0x184F92530", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4F92250", Offset = "0x4F90E50", VA = "0x184F92250")]
	private void BGBGBKMBLNO(HashSet<object> CKMLBEACEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4F92D90", Offset = "0x4F91990", VA = "0x184F92D90")]
	private bool HDFIHANNKFB(Entity CGLPEGHHGMM, [Out] GKFLOHMIEAL PHMFHDLJBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4F94330", Offset = "0x4F92F30", VA = "0x184F94330")]
	private bool PFODKJLAFGA(Entity CGLPEGHHGMM, [Out] GKFLOHMIEAL PHMFHDLJBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4F93130", Offset = "0x4F91D30", VA = "0x184F93130")]
	private void HGPJIBNLKNJ(Entity CGLPEGHHGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4F91E70", Offset = "0x4F90A70", VA = "0x184F91E70")]
	private void AMKJPFMOOGB(Entity CGLPEGHHGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4F923B0", Offset = "0x4F90FB0", VA = "0x184F923B0")]
	private void DNGDKCJJPJH(Entity CGLPEGHHGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4F93C80", Offset = "0x4F92880", VA = "0x184F93C80")]
	private void MJMAIDOOECO(Entity CGLPEGHHGMM, GKFLOHMIEAL PHMFHDLJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4F93A70", Offset = "0x4F92670", VA = "0x184F93A70")]
	private bool LCNCADJEMMC(GKFLOHMIEAL PHMFHDLJBOO, [Out] HashSet<object> CKMLBEACEOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4F92AB0", Offset = "0x4F916B0", VA = "0x184F92AB0")]
	private HashSet<object> GALNDAPMFEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FMFFDNPBDGJ
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BIGLLHKDBBI : DLKIEPPGLAC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x82C2960", Offset = "0x82C1560", VA = "0x1882C2960")]
	public float OFHIIPOEOMG([In] float3 BKMPCFIAHIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x82C2960", Offset = "0x82C1560", VA = "0x1882C2960", Slot = "4")]
	private float LPKCNBEBGJM([In] float3 BKMPCFIAHIG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NKCOEBHMKOC : DLKIEPPGLAC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x82C38B0", Offset = "0x82C24B0", VA = "0x1882C38B0")]
	public float OFHIIPOEOMG([In] float3 BKMPCFIAHIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x82C38B0", Offset = "0x82C24B0", VA = "0x1882C38B0", Slot = "4")]
	private float LPKCNBEBGJM([In] float3 BKMPCFIAHIG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OEJEDMKNCCI : DLKIEPPGLAC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xFAC3D0", Offset = "0xFAAFD0", VA = "0x180FAC3D0")]
	public float OFHIIPOEOMG([In] float3 BKMPCFIAHIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xFAC3D0", Offset = "0xFAAFD0", VA = "0x180FAC3D0", Slot = "4")]
	private float LPKCNBEBGJM([In] float3 BKMPCFIAHIG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BPBNDHGFFGA : DLKIEPPGLAC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2427140", Offset = "0x2425D40", VA = "0x182427140")]
	public int OFHIIPOEOMG([In] int3 BKMPCFIAHIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2427140", Offset = "0x2425D40", VA = "0x182427140", Slot = "4")]
	private int JDBCBECBDMN([In] int3 BKMPCFIAHIG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CEMEKIINMOB : DLKIEPPGLAC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x13573D0", Offset = "0x1355FD0", VA = "0x1813573D0")]
	public int OFHIIPOEOMG([In] int3 BKMPCFIAHIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x13573D0", Offset = "0x1355FD0", VA = "0x1813573D0", Slot = "4")]
	private int JDBCBECBDMN([In] int3 BKMPCFIAHIG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct EAALPJFHIKM : DLKIEPPGLAC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xF737E0", Offset = "0xF723E0", VA = "0x180F737E0")]
	public int OFHIIPOEOMG([In] int3 BKMPCFIAHIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xF737E0", Offset = "0xF723E0", VA = "0x180F737E0", Slot = "4")]
	private int JDBCBECBDMN([In] int3 BKMPCFIAHIG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MDANLNGFGJN : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x230C7E0", Offset = "0x230B3E0", VA = "0x18230C7E0")]
	public MDANLNGFGJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class DJDDGPLMPFH : SystemBase, KECPJLKHNLK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string FEGHCLOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82C2E60", Offset = "0x82C1A60", VA = "0x1882C2E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3A90C20", Offset = "0x3A8F820", VA = "0x183A90C20")]
	public void CCGCBEHPCOB<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3A90C20", Offset = "0x3A8F820", VA = "0x183A90C20")]
	public void ACDHCIIEMAN<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x82C2DA0", Offset = "0x82C19A0", VA = "0x1882C2DA0")]
	public JobHandle JAMGMNLAGPM(ReadOnlySpan<int> BNMIECALDJK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3A915E0", Offset = "0x3A901E0", VA = "0x183A915E0")]
	public JobHandle FLMACFJKBGM<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x82C2D50", Offset = "0x82C1950", VA = "0x1882C2D50")]
	public JobHandle FLMACFJKBGM(ReadOnlySpan<int> BNMIECALDJK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3A90EA0", Offset = "0x3A8FAA0", VA = "0x183A90EA0")]
	public void EFJMFAPMPJF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3A90D20", Offset = "0x3A8F920", VA = "0x183A90D20")]
	public JobHandle EFJMFAPMPJF<T>(JobHandle PHMFHDLJBOO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x82C2CE0", Offset = "0x82C18E0", VA = "0x1882C2CE0")]
	public JobHandle EFJMFAPMPJF(ReadOnlySpan<int> BNMIECALDJK, JobHandle PHMFHDLJBOO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3A90EA0", Offset = "0x3A8FAA0", VA = "0x183A90EA0")]
	public void JPOCFDNGPMF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3A917A0", Offset = "0x3A903A0", VA = "0x183A917A0")]
	public JobHandle JPOCFDNGPMF<T>(JobHandle PHMFHDLJBOO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82C2DF0", Offset = "0x82C19F0", VA = "0x1882C2DF0")]
	public JobHandle JPOCFDNGPMF(Span<int> BNMIECALDJK, JobHandle PHMFHDLJBOO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3A90C70", Offset = "0x3A8F870", VA = "0x183A90C70")]
	public ComponentDataFromEntity BDBIDAMCDPE<T>(bool BCHGIOMMOEN = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82C2C20", Offset = "0x82C1820", VA = "0x1882C2C20")]
	public ComponentDataFromEntity BDBIDAMCDPE(int OMBGPNMLCNN, bool BCHGIOMMOEN = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3A919E0", Offset = "0x3A905E0", VA = "0x183A919E0")]
	public SharedComponentIndexFromEntity<T> PMKFDLFLENO<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82C2E90", Offset = "0x82C1A90", VA = "0x1882C2E90")]
	[BurstCompatible]
	public ComponentTypeHandle PKHKKJDFDIC(ComponentType EPFOOLJELNA)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82C2C00", Offset = "0x82C1800", VA = "0x1882C2C00")]
	public EntityExistenceLookupByEntity ADGAJFKPBFC()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82C2EF0", Offset = "0x82C1AF0", VA = "0x1882C2EF0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3A91680", Offset = "0x3A90280", VA = "0x183A91680")]
	public bool IHDDDMAOPBL<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x230C7E0", Offset = "0x230B3E0", VA = "0x18230C7E0")]
	protected DJDDGPLMPFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class HFHMKCOHMJP : DJDDGPLMPFH
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82C3280", Offset = "0x82C1E80", VA = "0x1882C3280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x230C7E0", Offset = "0x230B3E0", VA = "0x18230C7E0")]
	protected HFHMKCOHMJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NFIPDHHHEHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PJNKMLOFCJD : EntityCommandBufferSystem, KECPJLKHNLK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private PEOHNMCPNIJ OJAPELLDHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE81CA0", Offset = "0xE808A0", VA = "0x180E81CA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x82C3AC0", Offset = "0x82C26C0", VA = "0x1882C3AC0")]
	public PJNKMLOFCJD(PEOHNMCPNIJ GDLIBGFAMED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DLKIEPPGLAC<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo OFHIIPOEOMG([In] TFrom BKMPCFIAHIG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FHJOKPAOKIM<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DLKPFLFFJJF(T BKMPCFIAHIG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct BECFBIBNGDF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> ADEOCFOIFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer CNGABMJLEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes IHJEFNGLFPG;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82C27E0", Offset = "0x82C13E0", VA = "0x1882C27E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct PKDGGBHMLCK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> ADEOCFOIFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer CNGABMJLEIL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x82C3AF0", Offset = "0x82C26F0", VA = "0x1882C3AF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct OJNMODCLENL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> ADEOCFOIFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer CNGABMJLEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType EPFOOLJELNA;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x82C3940", Offset = "0x82C2540", VA = "0x1882C3940", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct HHDKCPHMILL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> ADEOCFOIFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> CBCNBAPLLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer CNGABMJLEIL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B220", Offset = "0x4F89E20", VA = "0x184F8B220", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct DFHAAMKGNFI<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> ADEOCFOIFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> OKFGGFMLPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer CNGABMJLEIL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct FEMEDJCHADA<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> ADEOCFOIFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T BKMPCFIAHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer CNGABMJLEIL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct CFIPFIDBMOA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DLKIEPPGLAC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> IHEJCAGMNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> EMOGLDCFHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap KLIEOOEGDML;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct ONLJGLFPPNB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity JELHLICFFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> IHEJCAGMNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> EMOGLDCFHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int DEBEIHLPLGJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x82C39C0", Offset = "0x82C25C0", VA = "0x1882C39C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct ALAKJEDNHHK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MILNGGEAIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> IHEJCAGMNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> AAOOJLNHJLA;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct EOKGHNPPNMD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DLKIEPPGLAC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> AGKDDCEFOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> EMOGLDCFHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap KLIEOOEGDML;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct IFFEDGFBCBP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FAEFLBOFBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> DMFDFHLCEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> IFMJEHDDJEK;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct KMKDOKLFCAA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FAEFLBOFBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> DMFDFHLCEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> IFMJEHDDJEK;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x53D1090", Offset = "0x53CFC90", VA = "0x1853D1090", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct HENLLEDLOMH<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> IHEJCAGMNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> AAOOJLNHJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> DEDCAGHHAEE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4F68B30", Offset = "0x4F67730", VA = "0x184F68B30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct HCADIHBMCPD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : DLKIEPPGLAC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> IHEJCAGMNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> AAOOJLNHJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> DEDCAGHHAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap KLIEOOEGDML;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct FELMEKMAPHA<T, TPredicate> : IJob where T : struct where TPredicate : struct, FHJOKPAOKIM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> IHEJCAGMNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> HFFDHABOMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> OAGPMGOJBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate KLIEOOEGDML;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct CGECKEABNJL<T, TPredicate> : IJob where T : struct where TPredicate : struct, FHJOKPAOKIM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> IHEJCAGMNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> AAOOJLNHJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate KLIEOOEGDML;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct BFHPMKMCAGN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity FAEFLBOFBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> DMFDFHLCEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> LGFPFCAGBIB;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x82C28D0", Offset = "0x82C14D0", VA = "0x1882C28D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct JNHAFLDIHDG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity FAEFLBOFBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> DMFDFHLCEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> LGFPFCAGBIB;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x82C3570", Offset = "0x82C2170", VA = "0x1882C3570", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class IONGCBMPEGI
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class AMLDKPFIBAD
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3194C50", Offset = "0x3193850", VA = "0x183194C50")]
	public static bool DODBMJLLLGH<T>(this NativeArray<Entity> DMFDFHLCEKE, EntityManager HFPCKBDCDBJ, Allocator HPEAGMDCCBL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class HFNEKJCDPMK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class EICPHIMJBPG<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public EICPHIMJBPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class AANGGLBLFIH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public AANGGLBLFIH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> IAFLMNKHDLH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x82C32B0", Offset = "0x82C1EB0", VA = "0x1882C32B0")]
	public HFNEKJCDPMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IFBFMHGFHHE
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class DKINNFDKKOL
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct OKAJJODLBOA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct BEKPKEIDJCO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal OKAJJODLBOA<TFrom> IEPNOLIPIDE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> OJNBCCCOMPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct LLFIALGHIPI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct PGNFFDFNNCF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal LLFIALGHIPI<TFrom> IEPNOLIPIDE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> OJNBCCCOMPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct FNCILAMFOII<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct JBLGBEDLEIJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal FNCILAMFOII<TFrom> IEPNOLIPIDE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> OJNBCCCOMPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct KPLPJLDKEHI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct GCHEBIMEHHI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal KPLPJLDKEHI<TFrom> IEPNOLIPIDE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> OJNBCCCOMPJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ECHNJBKAKJA
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class GNODBHEKGHC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3C4CF40", Offset = "0x3C4BB40", VA = "0x183C4CF40")]
	public static NativeList<T> IKMEMFIEBNE<T>(this NativeArray<T> MCLGOFPIMFI, Allocator HPEAGMDCCBL = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class OODPOFFCECN
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FKKBCMIFONO
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3C295D0", Offset = "0x3C281D0", VA = "0x183C295D0")]
	[GDGJKOKBJNF]
	public static JobHandle LIKGPMJPDLN<T>(this EntityCommandBufferSystem HOJDMKEGOCA, NativeArray<Entity> ADEOCFOIFAB, NativeArray<T> CBCNBAPLLJM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3C29470", Offset = "0x3C28070", VA = "0x183C29470")]
	[GDGJKOKBJNF]
	public static JobHandle LIKGPMJPDLN<T>(this EntityCommandBufferSystem HOJDMKEGOCA, NativeArrayAsync<Entity> ADEOCFOIFAB, NativeArrayAsync<T> CBCNBAPLLJM, [Optional] JobHandle OIHAJOEEKOI) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3C29350", Offset = "0x3C27F50", VA = "0x183C29350")]
	[GDGJKOKBJNF]
	public static JobHandle LIKGPMJPDLN<T>(this EntityCommandBufferSystem HOJDMKEGOCA, NativeArray<Entity> ADEOCFOIFAB, [Optional] JobHandle OIHAJOEEKOI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82C3070", Offset = "0x82C1C70", VA = "0x1882C3070")]
	[GDGJKOKBJNF]
	public static JobHandle LIKGPMJPDLN(this EntityCommandBufferSystem HOJDMKEGOCA, NativeArray<Entity> ADEOCFOIFAB, ComponentTypes IHJEFNGLFPG, [Optional] JobHandle OIHAJOEEKOI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x82C2F20", Offset = "0x82C1B20", VA = "0x1882C2F20")]
	[GDGJKOKBJNF]
	public static JobHandle LIKGPMJPDLN(this EntityCommandBufferSystem HOJDMKEGOCA, EntityCommandBuffer CNGABMJLEIL, NativeArray<Entity> ADEOCFOIFAB, ComponentTypes IHJEFNGLFPG, [Optional] JobHandle OIHAJOEEKOI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JPEFLEMFIJE
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class CKBLEAPFEBH
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82C2970", Offset = "0x82C1570", VA = "0x1882C2970")]
	[GDGJKOKBJNF]
	public static JobHandle EMGOOPHJDBG(this EntityCommandBufferSystem HOJDMKEGOCA, NativeList<Entity> ADEOCFOIFAB, [Optional] JobHandle OIHAJOEEKOI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x82C2B00", Offset = "0x82C1700", VA = "0x1882C2B00")]
	[GDGJKOKBJNF]
	public static JobHandle EMGOOPHJDBG(this EntityCommandBufferSystem HOJDMKEGOCA, NativeArrayAsync<Entity> ADEOCFOIFAB)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MMIEAMACICC
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3D59C50", Offset = "0x3D58850", VA = "0x183D59C50")]
	public static void GOEEPHONAMH<T>(this EntityCommandBufferSystem HOJDMKEGOCA, EntityQuery FKCEPNMCPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3D5A010", Offset = "0x3D58C10", VA = "0x183D5A010")]
	[GDGJKOKBJNF]
	public static JobHandle LFNHHLFICBJ<T>(this EntityCommandBufferSystem HOJDMKEGOCA, NativeArrayAsync<Entity> ADEOCFOIFAB, [Optional] JobHandle OIHAJOEEKOI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x82C3600", Offset = "0x82C2200", VA = "0x1882C3600")]
	[GDGJKOKBJNF]
	public static JobHandle LFNHHLFICBJ(this EntityCommandBufferSystem HOJDMKEGOCA, NativeArrayAsync<Entity> ADEOCFOIFAB, ComponentType EPFOOLJELNA, [Optional] JobHandle OIHAJOEEKOI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class EAOJJCOMLKN
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7790", Offset = "0x3AB6390", VA = "0x183AB7790")]
	[GDGJKOKBJNF]
	public static JobHandle AONCFLMCPNK<T>(this EntityCommandBufferSystem HOJDMKEGOCA, NativeArray<Entity> ADEOCFOIFAB, NativeArray<T> CBCNBAPLLJM, JobHandle OIHAJOEEKOI) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class JJCMPCKAELG
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class BGKEKHGGHAI
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class ICCCFEPDIDF
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3C99EC0", Offset = "0x3C98AC0", VA = "0x183C99EC0")]
	public static NativeArray<T> MNJMIOCNMGD<T>(this NativeList<Entity> MCLGOFPIMFI, EntityManager HFPCKBDCDBJ, Allocator HPEAGMDCCBL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3C99D00", Offset = "0x3C98900", VA = "0x183C99D00")]
	public static NativeArray<T> MNJMIOCNMGD<T>(this NativeArray<Entity> MCLGOFPIMFI, EntityManager HFPCKBDCDBJ, Allocator HPEAGMDCCBL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x82C3340", Offset = "0x82C1F40", VA = "0x1882C3340")]
	public static NativeArray<Entity> NNKEECLFFDC(this NativeArray<Entity> MCLGOFPIMFI, EntityManager HFPCKBDCDBJ, ComponentType EPFOOLJELNA, Allocator HPEAGMDCCBL = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3C99C00", Offset = "0x3C98800", VA = "0x183C99C00")]
	public static NativeArray<T> EBAAOHGGNAF<T>(this NativeArray<Entity> MCLGOFPIMFI, EntityManager HFPCKBDCDBJ, Allocator HPEAGMDCCBL = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class OFEOAEKPKPD
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct PPJIBJPPECL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct JPHDIFKMBDI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public PPJIBJPPECL<TFrom> OJNBCCCOMPJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> IHEJCAGMNJH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct NEKAGBJCEKB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct MEJGBKCJOPM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public NEKAGBJCEKB<TFrom> OJNBCCCOMPJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> IHEJCAGMNJH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct BCAMNFEPPGK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct FIDLPGGGDMO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public BCAMNFEPPGK<TFrom> OJNBCCCOMPJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> IHEJCAGMNJH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class IKCOGKMJJIK
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class GMNNLKKJGCH
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct JJNIADICCHK : DLKIEPPGLAC<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> DINBNKNLNPC;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x82C3560", Offset = "0x82C2160", VA = "0x1882C3560")]
		[BurstCompatible]
		public Entity OFHIIPOEOMG([In] Entity BKMPCFIAHIG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x82C3560", Offset = "0x82C2160", VA = "0x1882C3560", Slot = "4")]
		private Entity PDKMJAMOENO([In] Entity BKMPCFIAHIG)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class OEFIEJLIAAE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct EIIBMINECNC<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x48DE090", Offset = "0x48DCC90", VA = "0x1848DE090", Slot = "4")]
		public int Compare((TKey, TValue) LGCEHLADNJC, (TKey, TValue) LFHMHCKODDK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6910", Offset = "0x3DF5510", VA = "0x183DF6910")]
	public static void MHADBOJNHLA<TKey, TValue>(NativeList<TKey> KEGGHEJMEEC, NativeList<TValue> OKFGGFMLPHB) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6540", Offset = "0x3DF5140", VA = "0x183DF6540")]
	public static void MHADBOJNHLA<TKey, TValue>(NativeArray<TKey> KEGGHEJMEEC, NativeArray<TValue> OKFGGFMLPHB) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6700", Offset = "0x3DF5300", VA = "0x183DF6700")]
	public static void MHADBOJNHLA<TKey, TValue, U>(NativeArray<TKey> KEGGHEJMEEC, NativeArray<TValue> OKFGGFMLPHB, U EHKNJLNBCNC) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class NNGDFFKIAAM
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct AODKMCHMKGO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> HFFDHABOMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> IHEJCAGMNJH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct FIPAMOFBEDD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> HFFDHABOMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> IHEJCAGMNJH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct JAINMDNGEJG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> HFFDHABOMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> IHEJCAGMNJH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class JPBKIACOAAO
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class ILGMGJPGFPJ
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct HAIAOJBLINA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> IHEJCAGMNJH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct OPNJDIDAOLB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> IHEJCAGMNJH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct CBFIAJAGDKF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> IHEJCAGMNJH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct EGMJLOCBPKH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator HPEAGMDCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> IHEJCAGMNJH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class CEKOHODCGMM
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class ILAGHNKPFHC
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3CAB9B0", Offset = "0x3CAA5B0", VA = "0x183CAB9B0")]
	public static NativeList<Entity> DHKOJDGNBNO<T>(this NativeList<Entity> DMFDFHLCEKE, EntityManager HFPCKBDCDBJ, Allocator HPEAGMDCCBL = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3CAB230", Offset = "0x3CA9E30", VA = "0x183CAB230")]
	public static NativeList<Entity> DHKOJDGNBNO<T>(this NativeArray<Entity> DMFDFHLCEKE, EntityManager HFPCKBDCDBJ, Allocator HPEAGMDCCBL = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class AAEHBCBEOCP
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x31807D0", Offset = "0x317F3D0", VA = "0x1831807D0")]
	public static NativeList<Entity> CJFBDBPBGIJ<T>(this NativeArray<Entity> DMFDFHLCEKE, EntityManager HFPCKBDCDBJ, Allocator HPEAGMDCCBL = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class FHBBDBIGKBA
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct NEKOFACNCKO<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> COJHNLDFDFB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct BLOCOLMEHIJ<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> COJHNLDFDFB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct DCNEILNOJPI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DLKIEPPGLAC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> COJHNLDFDFB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct ALIHHCGHPGC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, DLKIEPPGLAC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> COJHNLDFDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector PEKEODNNFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int LCCBBMBENOH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CAEAJGDDGHJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DLKIEPPGLAC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private ALIHHCGHPGC<TSrc, TValue, TSelector> MBBNOHOAAJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue GEHGPAPBBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int FAHOKHGHPIJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class DJIGMCGMAKC
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct OMAHKBMBAIK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> COJHNLDFDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int FAHOKHGHPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int OLMDPIKJLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T GEHGPAPBBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T FHPGDKKPHMM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FPNBEMALHAC GMGOILPHOJC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5860840", Offset = "0x585F440", VA = "0x185860840")]
			get
			{
				return default(FPNBEMALHAC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T GKOEHDEEJKL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, FPNBEMALHAC) ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5860BA0", Offset = "0x585F7A0", VA = "0x185860BA0")]
			get
			{
				return default((T, FPNBEMALHAC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5885330", Offset = "0x5883F30", VA = "0x185885330")]
		public OMAHKBMBAIK(NativeArray<T> COJHNLDFDFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D800", Offset = "0x2C1C400", VA = "0x182C1D800")]
		public OMAHKBMBAIK<T> MIEHOANGBJG()
		{
			return default(OMAHKBMBAIK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5884F90", Offset = "0x5883B90", VA = "0x185884F90")]
		public bool PCJKIKDLNGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x43B4630", Offset = "0x43B3230", VA = "0x1843B4630")]
		public OGCLKDCOOKJ<T, TComparer> JPOLFPPJGAB<TComparer>([Optional] TComparer EHKNJLNBCNC) where TComparer : struct, IEqualityComparer<T>
		{
			return default(OGCLKDCOOKJ<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct OGCLKDCOOKJ<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> COJHNLDFDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int FAHOKHGHPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int OLMDPIKJLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T GEHGPAPBBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T FHPGDKKPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer EHKNJLNBCNC;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FPNBEMALHAC GMGOILPHOJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x5860840", Offset = "0x585F440", VA = "0x185860840")]
			get
			{
				return default(FPNBEMALHAC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T GKOEHDEEJKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, FPNBEMALHAC range) ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5860BA0", Offset = "0x585F7A0", VA = "0x185860BA0")]
			get
			{
				return default((T, FPNBEMALHAC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5860C50", Offset = "0x585F850", VA = "0x185860C50")]
		public OGCLKDCOOKJ(NativeArray<T> COJHNLDFDFB, TComparer EHKNJLNBCNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x49B3BE0", Offset = "0x49B27E0", VA = "0x1849B3BE0")]
		public OGCLKDCOOKJ<T, TComparer> MIEHOANGBJG()
		{
			return default(OGCLKDCOOKJ<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5860850", Offset = "0x585F450", VA = "0x185860850")]
		public bool PCJKIKDLNGG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3A91C20", Offset = "0x3A90820", VA = "0x183A91C20")]
	public static OMAHKBMBAIK<T> HONOJCLADAL<T>(this NativeArray<T> COJHNLDFDFB) where T : struct
	{
		return default(OMAHKBMBAIK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface GDHGIIBNDML
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class FLJHCECIJDM
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct LPLNEAFIOBG<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class LJAFJFDFDPO : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LPLNEAFIOBG<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xD1C5C0", Offset = "0xD1B1C0", VA = "0x180D1C5C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E27430", Offset = "0x4E26030", VA = "0x184E27430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public LJAFJFDFDPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5464BE0", Offset = "0x54637E0", VA = "0x185464BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5464D90", Offset = "0x5463990", VA = "0x185464D90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> PNJFFPLKHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream NKIPIPEKKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream ELIEJGBPGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf EIEILELNLLN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int PIELHOLGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAB6800", Offset = "0xAB5400", VA = "0x180AB6800")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x54790B0", Offset = "0x5477CB0", VA = "0x1854790B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x54790F0", Offset = "0x5477CF0", VA = "0x1854790F0", Slot = "4")]
	[IteratorStateMachine(typeof(LPLNEAFIOBG<>.LJAFJFDFDPO))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x54791E0", Offset = "0x5477DE0", VA = "0x1854791E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct AEJMMMECBIK<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] HAPOFGGDNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf EIEILELNLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream NKIPIPEKKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream OGPAIEONMMD;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5091580", Offset = "0x5090180", VA = "0x185091580", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct JGAEOOJNIEB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream NKIPIPEKKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream ELIEJGBPGGN;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x82C3520", Offset = "0x82C2120", VA = "0x1882C3520", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct NEPHHFJIJIL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] HAPOFGGDNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream NKIPIPEKKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream OGPAIEONMMD;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x82C3790", Offset = "0x82C2390", VA = "0x1882C3790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class KMNJGGJBCBM
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class MLIKAKIBCKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum GJJHEECGHIF
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
internal static class MFDFALNEBGE
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class MBCOCJPKMMG
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MBCOCJPKMMG()
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

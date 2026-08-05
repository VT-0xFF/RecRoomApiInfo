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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x77551D0", Offset = "0x77545D0", VA = "0x1877551D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7754440", Offset = "0x7753840", VA = "0x187754440")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OBAONHHGAGB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FEAEKKDDKCJ AHBGJIEIPMN
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
public interface NKNKONEEEMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PPEKHOKNKFA(Entity JNOEBKCCPMC, object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBOPJMKHCDN(Entity JNOEBKCCPMC, object OCDOGNMJENC, [Out] bool CBADGGJACIK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HPBCHNALIBD(Entity JNOEBKCCPMC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MOGLEHLCPEI<TComponentData, TValue> : DPBPDNCMPBC<TValue>, IDisposable where TComponentData : struct, OBAONHHGAGB
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class IPPAKJCKJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> DBJKHFJBKPC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ECPNGLCMABA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3D73AE0", Offset = "0x3D72EE0", VA = "0x183D73AE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4844CE0", Offset = "0x48440E0", VA = "0x184844CE0")]
		public bool DEKCCNPEJLH([Out] TValue PEBNJNGMMHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4844ED0", Offset = "0x48442D0", VA = "0x184844ED0")]
		public void KAAHFJDOOLK(object OCDOGNMJENC, TValue PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4844FB0", Offset = "0x48443B0", VA = "0x184844FB0")]
		public bool PBIACPFCCPC(object OCDOGNMJENC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4844DF0", Offset = "0x48441F0", VA = "0x184844DF0")]
		public int IMLLPNOEGNC(object OCDOGNMJENC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4845060", Offset = "0x4844460", VA = "0x184845060")]
		public IPPAKJCKJIF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<IPPAKJCKJIF> CMNEOIKNFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private GAAPGAHCHAH<FEAEKKDDKCJ, IPPAKJCKJIF> KAAGIMAHKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager HIKDABPFHKC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DD40", Offset = "0x4E1D140", VA = "0x184E1DD40")]
	public MOGLEHLCPEI(EntityManager HIKDABPFHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DBC0", Offset = "0x4E1CFC0", VA = "0x184E1DBC0", Slot = "4")]
	public void PPEKHOKNKFA(Entity JNOEBKCCPMC, object OCDOGNMJENC, TValue PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D4E0", Offset = "0x4E1C8E0", VA = "0x184E1D4E0", Slot = "5")]
	public bool CBOPJMKHCDN(Entity JNOEBKCCPMC, object OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D790", Offset = "0x4E1CB90", VA = "0x184E1D790", Slot = "6")]
	public bool DEKCCNPEJLH(Entity JNOEBKCCPMC, [Out] TValue PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D8A0", Offset = "0x4E1CCA0", VA = "0x184E1D8A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D8C0", Offset = "0x4E1CCC0", VA = "0x184E1D8C0")]
	private void FBHICHGPDBB(IPPAKJCKJIF HEFCLEIGIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D6D0", Offset = "0x4E1CAD0", VA = "0x184E1D6D0")]
	private bool CFKHOGNODJK(Entity JNOEBKCCPMC, [Out] FEAEKKDDKCJ ODHBLOGMAPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D980", Offset = "0x4E1CD80", VA = "0x184E1D980")]
	private void JKLCOOEGEBN(Entity JNOEBKCCPMC, FEAEKKDDKCJ ODHBLOGMAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DBA0", Offset = "0x4E1CFA0", VA = "0x184E1DBA0")]
	private bool LBCPAMMLILM(FEAEKKDDKCJ ODHBLOGMAPO, [Out] IPPAKJCKJIF HEFCLEIGIDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DA80", Offset = "0x4E1CE80", VA = "0x184E1DA80")]
	private IPPAKJCKJIF KIKBKGCIOFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DPBPDNCMPBC<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPEKHOKNKFA(Entity JNOEBKCCPMC, object OCDOGNMJENC, TValue PEBNJNGMMHE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBOPJMKHCDN(Entity JNOEBKCCPMC, object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DEKCCNPEJLH(Entity JNOEBKCCPMC, [Out] TValue PEBNJNGMMHE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FEAEKKDDKCJ : AOLNDNNNENI, IEquatable<FEAEKKDDKCJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly FEAEKKDDKCJ GMGPCBOIDPO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int NGGCGOFGPAK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int NGJHPPMLGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BEE380", Offset = "0x2BED780", VA = "0x182BEE380", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68ACF10", Offset = "0x68AC310", VA = "0x1868ACF10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7754640", Offset = "0x7753A40", VA = "0x187754640", Slot = "8")]
	public bool Equals(FEAEKKDDKCJ MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7754690", Offset = "0x7753A90", VA = "0x187754690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IINBEDFKNOG<THasTokensTag> : NKNKONEEEMN, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, FEAEKKDDKCJ> JMIGDIGGENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> CMNEOIKNFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private GAAPGAHCHAH<FEAEKKDDKCJ, HashSet<object>> KAAGIMAHKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager HIKDABPFHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem MJNMMECKKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool MPODDHPAEGG;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4816B10", Offset = "0x4815F10", VA = "0x184816B10")]
	public IINBEDFKNOG(EntityManager HIKDABPFHKC, EntityCommandBufferSystem MJNMMECKKOD, HLBHMADGLFA LNEJDOKMHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x48165E0", Offset = "0x48159E0", VA = "0x1848165E0", Slot = "4")]
	public bool PPEKHOKNKFA(Entity JNOEBKCCPMC, object OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4814210", Offset = "0x4813610", VA = "0x184814210", Slot = "5")]
	public bool CBOPJMKHCDN(Entity JNOEBKCCPMC, object OCDOGNMJENC, [Out] bool CBADGGJACIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4815690", Offset = "0x4814A90", VA = "0x184815690", Slot = "6")]
	public bool HPBCHNALIBD(Entity JNOEBKCCPMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4815740", Offset = "0x4814B40", VA = "0x184815740", Slot = "8")]
	public bool HPBCHNALIBD(FEAEKKDDKCJ ODHBLOGMAPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4815110", Offset = "0x4814510", VA = "0x184815110", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4815320", Offset = "0x4814720", VA = "0x184815320")]
	private void FBHICHGPDBB(HashSet<object> HEFCLEIGIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4814C10", Offset = "0x4814010", VA = "0x184814C10")]
	private bool CFKHOGNODJK(Entity JNOEBKCCPMC, [Out] FEAEKKDDKCJ ODHBLOGMAPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4815450", Offset = "0x4814850", VA = "0x184815450")]
	private bool FHEPHGHNLMN(Entity JNOEBKCCPMC, [Out] FEAEKKDDKCJ ODHBLOGMAPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4813E10", Offset = "0x4813210", VA = "0x184813E10")]
	private void BIEIHDHBHKC(Entity JNOEBKCCPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4814CD0", Offset = "0x48140D0", VA = "0x184814CD0")]
	private void DNJGLIGFANN(Entity JNOEBKCCPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4815FC0", Offset = "0x48153C0", VA = "0x184815FC0")]
	private void NBIEGNNOHAB(Entity JNOEBKCCPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4815CD0", Offset = "0x48150D0", VA = "0x184815CD0")]
	private void JKLCOOEGEBN(Entity JNOEBKCCPMC, FEAEKKDDKCJ ODHBLOGMAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4815AC0", Offset = "0x4814EC0", VA = "0x184815AC0")]
	private bool JFBFDOMKKMF(FEAEKKDDKCJ ODHBLOGMAPO, [Out] HashSet<object> HEFCLEIGIDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4815DE0", Offset = "0x48151E0", VA = "0x184815DE0")]
	private HashSet<object> KIKBKGCIOFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BEFMLKOAAJK
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct PECEOANCBNP : PPCKODFHBID<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7755590", Offset = "0x7754990", VA = "0x187755590")]
	public float NNJICJEBNHF([In] float3 PEBNJNGMMHE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7755590", Offset = "0x7754990", VA = "0x187755590", Slot = "4")]
	private float MFJPMNDLEIA([In] float3 PEBNJNGMMHE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FFBPKMMBNEF : PPCKODFHBID<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77546E0", Offset = "0x7753AE0", VA = "0x1877546E0")]
	public float NNJICJEBNHF([In] float3 PEBNJNGMMHE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x77546E0", Offset = "0x7753AE0", VA = "0x1877546E0", Slot = "4")]
	private float MFJPMNDLEIA([In] float3 PEBNJNGMMHE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AMGMGGDEFND : PPCKODFHBID<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xD688A0", Offset = "0xD67CA0", VA = "0x180D688A0")]
	public float NNJICJEBNHF([In] float3 PEBNJNGMMHE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xD688A0", Offset = "0xD67CA0", VA = "0x180D688A0", Slot = "4")]
	private float MFJPMNDLEIA([In] float3 PEBNJNGMMHE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IGDKEKCLCLN : PPCKODFHBID<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1F83240", Offset = "0x1F82640", VA = "0x181F83240")]
	public int NNJICJEBNHF([In] int3 PEBNJNGMMHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1F83240", Offset = "0x1F82640", VA = "0x181F83240", Slot = "4")]
	private int MLINFONGLGA([In] int3 PEBNJNGMMHE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GBKJNNBHANP : PPCKODFHBID<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7742BC0", Offset = "0x7741FC0", VA = "0x187742BC0")]
	public int NNJICJEBNHF([In] int3 PEBNJNGMMHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7742BC0", Offset = "0x7741FC0", VA = "0x187742BC0", Slot = "4")]
	private int MLINFONGLGA([In] int3 PEBNJNGMMHE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JMEDJBDBBFP : PPCKODFHBID<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xD44EB0", Offset = "0xD442B0", VA = "0x180D44EB0")]
	public int NNJICJEBNHF([In] int3 PEBNJNGMMHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xD44EB0", Offset = "0xD442B0", VA = "0x180D44EB0", Slot = "4")]
	private int MLINFONGLGA([In] int3 PEBNJNGMMHE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PENPMNOPCKO : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E71BF0", Offset = "0x1E70FF0", VA = "0x181E71BF0")]
	public PENPMNOPCKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class OKBGABKHKPB : SystemBase, NFGHMCDPDKN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x77553B0", Offset = "0x77547B0", VA = "0x1877553B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3658AA0", Offset = "0x3657EA0", VA = "0x183658AA0")]
	public void EJMMBDGBOEO<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3658AA0", Offset = "0x3657EA0", VA = "0x183658AA0")]
	public void DKAPALDBJIB<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x77552F0", Offset = "0x77546F0", VA = "0x1877552F0")]
	public JobHandle EAILHBIJIFN(ReadOnlySpan<int> NPNHMKGGCNB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x36597C0", Offset = "0x3658BC0", VA = "0x1836597C0")]
	public JobHandle PBIILNCANEK<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7755530", Offset = "0x7754930", VA = "0x187755530")]
	public JobHandle PBIILNCANEK(ReadOnlySpan<int> NPNHMKGGCNB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3658B00", Offset = "0x3657F00", VA = "0x183658B00")]
	public void LJPDHPFIGLA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3658E30", Offset = "0x3658230", VA = "0x183658E30")]
	public JobHandle LJPDHPFIGLA<T>(JobHandle ODHBLOGMAPO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7755400", Offset = "0x7754800", VA = "0x187755400")]
	public JobHandle LJPDHPFIGLA(ReadOnlySpan<int> NPNHMKGGCNB, JobHandle ODHBLOGMAPO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3658B00", Offset = "0x3657F00", VA = "0x183658B00")]
	public void EHEIGINCAJF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3658B90", Offset = "0x3657F90", VA = "0x183658B90")]
	public JobHandle EHEIGINCAJF<T>(JobHandle ODHBLOGMAPO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7755340", Offset = "0x7754740", VA = "0x187755340")]
	public JobHandle EHEIGINCAJF(Span<int> NPNHMKGGCNB, JobHandle ODHBLOGMAPO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x36596F0", Offset = "0x3658AF0", VA = "0x1836596F0")]
	public ComponentDataFromEntity MILEDKIMJFH<T>(bool EGGKGINNCNH = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7755470", Offset = "0x7754870", VA = "0x187755470")]
	public ComponentDataFromEntity MILEDKIMJFH(int ENEPDCJNLIB, bool EGGKGINNCNH = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x36589D0", Offset = "0x3657DD0", VA = "0x1836589D0")]
	public SharedComponentIndexFromEntity<T> DFLJOINGAHP<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7755290", Offset = "0x7754690", VA = "0x187755290")]
	[BurstCompatible]
	public ComponentTypeHandle CAEDAEFBNPI(ComponentType MEMCJOAFKML)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x77553E0", Offset = "0x77547E0", VA = "0x1877553E0")]
	public EntityExistenceLookupByEntity JJDMPCAFMFG()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7755580", Offset = "0x7754980", VA = "0x187755580", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x36588B0", Offset = "0x3657CB0", VA = "0x1836588B0")]
	public bool AGKKPGAMKHD<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E71BF0", Offset = "0x1E70FF0", VA = "0x181E71BF0")]
	protected OKBGABKHKPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class AOKADDPDIPK : OKBGABKHKPB
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7754380", Offset = "0x7753780", VA = "0x187754380", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1E71BF0", Offset = "0x1E70FF0", VA = "0x181E71BF0")]
	protected AOKADDPDIPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OENPAJHLMLO
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JHDGAOJMEEH : EntityCommandBufferSystem, NFGHMCDPDKN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private HLBHMADGLFA COHAOGFFGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC5B330", Offset = "0xC5A730", VA = "0x180C5B330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7754F80", Offset = "0x7754380", VA = "0x187754F80")]
	public JHDGAOJMEEH(HLBHMADGLFA GCIBFPDCNDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PPCKODFHBID<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo NNJICJEBNHF([In] TFrom PEBNJNGMMHE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GCGCDOOCALI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKIBNJDMILP(T PEBNJNGMMHE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct GPKODAGBCFL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> PPMNIACNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer JEEDLFOCDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes FFKABCLLPJL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7754AA0", Offset = "0x7753EA0", VA = "0x187754AA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct IDCJOMJGPKL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> PPMNIACNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer JEEDLFOCDFB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7754EE0", Offset = "0x77542E0", VA = "0x187754EE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct MJCNFGDOCLC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> PPMNIACNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer JEEDLFOCDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType MEMCJOAFKML;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7755140", Offset = "0x7754540", VA = "0x187755140", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct CPJNHMNCJKG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> PPMNIACNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> MJFOKKFMONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer JEEDLFOCDFB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x620D930", Offset = "0x620CD30", VA = "0x18620D930", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct INBICCENGNM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> PPMNIACNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> JPGIMCGBJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer JEEDLFOCDFB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct HGJAKPDGCOK<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> PPMNIACNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T PEBNJNGMMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer JEEDLFOCDFB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct FHGIFFCCIPI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, PPCKODFHBID<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> JICOGGDGFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> CFOBONHJMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap NJNJGNMEACN;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct MFMCIHKMHGM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity GHHIBFOFJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> JICOGGDGFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> CFOBONHJMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int OCOJJBBIOJP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7755040", Offset = "0x7754440", VA = "0x187755040", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct HCACAHJIMBA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FBOJINOBNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> JICOGGDGFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> CPKIENHDNKO;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct PPGDAAJJJOF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, PPCKODFHBID<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> ACILDMMNLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> CFOBONHJMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap NJNJGNMEACN;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct CCLIIHELCJK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JGEGAOFDMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> DIGEKCNCMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> CCLLNLKBHHJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct BGDNDJELGEA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JGEGAOFDMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> DIGEKCNCMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> CCLLNLKBHHJ;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5C85490", Offset = "0x5C84890", VA = "0x185C85490", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct PHODGOIIFBK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> JICOGGDGFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> CPKIENHDNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> FFEACDIHDEE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x50A1C80", Offset = "0x50A1080", VA = "0x1850A1C80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct CDJAGLJMNEA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : PPCKODFHBID<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> JICOGGDGFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> CPKIENHDNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> FFEACDIHDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap NJNJGNMEACN;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct IJIFKCHDOPI<T, TPredicate> : IJob where T : struct where TPredicate : struct, GCGCDOOCALI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> JICOGGDGFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> CJCFGEPMHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> LCNDADALIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate NJNJGNMEACN;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct BJLFDLCDJCC<T, TPredicate> : IJob where T : struct where TPredicate : struct, GCGCDOOCALI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> JICOGGDGFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> CPKIENHDNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate NJNJGNMEACN;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct KBBFCLLKNJD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity JGEGAOFDMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> DIGEKCNCMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> EAKMJBKMKHD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7754FB0", Offset = "0x77543B0", VA = "0x187754FB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct HPGBBJKKDFD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity JGEGAOFDMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> DIGEKCNCMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> EAKMJBKMKHD;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7754E50", Offset = "0x7754250", VA = "0x187754E50", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class LNCMGPCGKFG
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class JHCFGALJKCJ
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x351BFE0", Offset = "0x351B3E0", VA = "0x18351BFE0")]
	public static bool JIKKEKMBCMO<T>(this NativeArray<Entity> DIGEKCNCMDA, EntityManager HIKDABPFHKC, Allocator FALBINAEKDG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class EMHJOJGLELE
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class ECGPKNLAHMA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public ECGPKNLAHMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class JMMKAOAANFG<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public JMMKAOAANFG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> NIOJDGABGAM;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x77543B0", Offset = "0x77537B0", VA = "0x1877543B0")]
	public EMHJOJGLELE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NACLDLFHNDB
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class MIACCDIIDCF
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct CHDBKGMHKAG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct HJAIHCEKFBK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal CHDBKGMHKAG<TFrom> HKNGNFLDPKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> BLMGNEDEHDK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct GLEDLLPGANH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct HIAFBIFHIKO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal GLEDLLPGANH<TFrom> HKNGNFLDPKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> BLMGNEDEHDK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct CCDAMAJDLAI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct LDAKCKHJKCK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal CCDAMAJDLAI<TFrom> HKNGNFLDPKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> BLMGNEDEHDK;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct MILNLHDKKFC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct AGJHANMHCDF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal MILNLHDKKFC<TFrom> HKNGNFLDPKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> BLMGNEDEHDK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HBHEDIOFIHB
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class BDBCIOCNEMN
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x31FAF70", Offset = "0x31FA370", VA = "0x1831FAF70")]
	public static NativeList<T> AMOMLJEGAML<T>(this NativeArray<T> DHPDJFAKLDE, Allocator FALBINAEKDG = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class NACKIFIIHAK
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class HJMEAPBKKID
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x34DFD20", Offset = "0x34DF120", VA = "0x1834DFD20")]
	[PCEMDJFMHKI]
	public static JobHandle EPNLJNIPKPE<T>(this EntityCommandBufferSystem MJNMMECKKOD, NativeArray<Entity> PPMNIACNFOH, NativeArray<T> MJFOKKFMONL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x34DFF40", Offset = "0x34DF340", VA = "0x1834DFF40")]
	[PCEMDJFMHKI]
	public static JobHandle EPNLJNIPKPE<T>(this EntityCommandBufferSystem MJNMMECKKOD, NativeArrayAsync<Entity> PPMNIACNFOH, NativeArrayAsync<T> MJFOKKFMONL, [Optional] JobHandle CCIHKBAJMML) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x34DFE10", Offset = "0x34DF210", VA = "0x1834DFE10")]
	[PCEMDJFMHKI]
	public static JobHandle EPNLJNIPKPE<T>(this EntityCommandBufferSystem MJNMMECKKOD, NativeArray<Entity> PPMNIACNFOH, [Optional] JobHandle CCIHKBAJMML)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7754B90", Offset = "0x7753F90", VA = "0x187754B90")]
	[PCEMDJFMHKI]
	public static JobHandle EPNLJNIPKPE(this EntityCommandBufferSystem MJNMMECKKOD, NativeArray<Entity> PPMNIACNFOH, ComponentTypes FFKABCLLPJL, [Optional] JobHandle CCIHKBAJMML)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7754D00", Offset = "0x7754100", VA = "0x187754D00")]
	[PCEMDJFMHKI]
	public static JobHandle EPNLJNIPKPE(this EntityCommandBufferSystem MJNMMECKKOD, EntityCommandBuffer JEEDLFOCDFB, NativeArray<Entity> PPMNIACNFOH, ComponentTypes FFKABCLLPJL, [Optional] JobHandle CCIHKBAJMML)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class FEMACOKEPPD
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GBMPNOIHPMN
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x77547F0", Offset = "0x7753BF0", VA = "0x1877547F0")]
	[PCEMDJFMHKI]
	public static JobHandle OIJLGMFDDLF(this EntityCommandBufferSystem MJNMMECKKOD, NativeList<Entity> PPMNIACNFOH, [Optional] JobHandle CCIHKBAJMML)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x77546F0", Offset = "0x7753AF0", VA = "0x1877546F0")]
	[PCEMDJFMHKI]
	public static JobHandle OIJLGMFDDLF(this EntityCommandBufferSystem MJNMMECKKOD, NativeArrayAsync<Entity> PPMNIACNFOH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NDBKLMEJFHH
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LHNNJJGNNII
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x355D220", Offset = "0x355C620", VA = "0x18355D220")]
	[PCEMDJFMHKI]
	public static JobHandle DNBKCCEMDKA<T>(this EntityCommandBufferSystem MJNMMECKKOD, NativeArray<Entity> PPMNIACNFOH, NativeArray<T> MJFOKKFMONL, JobHandle CCIHKBAJMML) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class FAJMOIMCEJL
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class KEJJLGAHNKN
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class FAPPGPOBLFF
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x347C880", Offset = "0x347BC80", VA = "0x18347C880")]
	public static NativeArray<T> BEPKBNCFFFI<T>(this NativeList<Entity> DHPDJFAKLDE, EntityManager HIKDABPFHKC, Allocator FALBINAEKDG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x347C4C0", Offset = "0x347B8C0", VA = "0x18347C4C0")]
	public static NativeArray<T> BEPKBNCFFFI<T>(this NativeArray<Entity> DHPDJFAKLDE, EntityManager HIKDABPFHKC, Allocator FALBINAEKDG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7754460", Offset = "0x7753860", VA = "0x187754460")]
	public static NativeArray<Entity> AEPFICGKBGO(this NativeArray<Entity> DHPDJFAKLDE, EntityManager HIKDABPFHKC, ComponentType MEMCJOAFKML, Allocator FALBINAEKDG = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x347CC00", Offset = "0x347C000", VA = "0x18347CC00")]
	public static NativeArray<T> POAPCKDMIGI<T>(this NativeArray<Entity> DHPDJFAKLDE, EntityManager HIKDABPFHKC, Allocator FALBINAEKDG = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class LHIEJNAOKKI
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct BNNLEJDEANM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct OIJJFIHGMBE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public BNNLEJDEANM<TFrom> BLMGNEDEHDK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> JICOGGDGFPI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct NAPBHPONDDK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct GCHEACCNNHD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public NAPBHPONDDK<TFrom> BLMGNEDEHDK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> JICOGGDGFPI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct ODDEEDKCPCN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct DOGAFNDAOHB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public ODDEEDKCPCN<TFrom> BLMGNEDEHDK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> JICOGGDGFPI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HACBICBONAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class BLALBEBKBFE
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct MMGAHEOOIKK : PPCKODFHBID<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> KFAFNPBPIAA;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x77551C0", Offset = "0x77545C0", VA = "0x1877551C0")]
		[BurstCompatible]
		public Entity NNJICJEBNHF([In] Entity PEBNJNGMMHE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x77551C0", Offset = "0x77545C0", VA = "0x1877551C0", Slot = "4")]
		private Entity NNEJEOGOLJM([In] Entity PEBNJNGMMHE)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class EOAJKNNNCFH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct CNMFFIDMLNH<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x61FFBF0", Offset = "0x61FEFF0", VA = "0x1861FFBF0", Slot = "4")]
		public int Compare((TKey, TValue) COMHOHNLIIN, (TKey, TValue) PJGBAACMKFF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x33182D0", Offset = "0x33176D0", VA = "0x1833182D0")]
	public static void GKHEGAOHCIM<TKey, TValue>(NativeList<TKey> NNJAFBMMFGC, NativeList<TValue> JPGIMCGBJEJ) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x33187A0", Offset = "0x3317BA0", VA = "0x1833187A0")]
	public static void GKHEGAOHCIM<TKey, TValue>(NativeArray<TKey> NNJAFBMMFGC, NativeArray<TValue> JPGIMCGBJEJ) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3318560", Offset = "0x3317960", VA = "0x183318560")]
	public static void GKHEGAOHCIM<TKey, TValue, U>(NativeArray<TKey> NNJAFBMMFGC, NativeArray<TValue> JPGIMCGBJEJ, U AOJPHHLKMJI) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class CJAIBJICMJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct HPIIAJCHFOA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> CJCFGEPMHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> JICOGGDGFPI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct PDHJIMNPODJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> CJCFGEPMHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> JICOGGDGFPI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct LBNEMCJDPAH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> CJCFGEPMHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> JICOGGDGFPI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class FMLEHDEOKLJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class FOJEBHELBJF
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct DGMPMPCHBGO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> JICOGGDGFPI;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct BDGEDKDODDK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> JICOGGDGFPI;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct LKCJFKLCPCK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> JICOGGDGFPI;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct LGJDCCJADNN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator FALBINAEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> JICOGGDGFPI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class DPHHGFOMDBO
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class OIHOGFEIKAP
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3657360", Offset = "0x3656760", VA = "0x183657360")]
	public static NativeList<Entity> GONBJPKAOIC<T>(this NativeList<Entity> DIGEKCNCMDA, EntityManager HIKDABPFHKC, Allocator FALBINAEKDG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3656EB0", Offset = "0x36562B0", VA = "0x183656EB0")]
	public static NativeList<Entity> GONBJPKAOIC<T>(this NativeArray<Entity> DIGEKCNCMDA, EntityManager HIKDABPFHKC, Allocator FALBINAEKDG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class OBANPNLNLAF
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x364E420", Offset = "0x364D820", VA = "0x18364E420")]
	public static NativeList<Entity> DKMFAJEPMKB<T>(this NativeArray<Entity> DIGEKCNCMDA, EntityManager HIKDABPFHKC, Allocator FALBINAEKDG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class GHBLKJHKJCO
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct MBHFCCDJBGK<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> PHAPILEGACC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct NNEHEJGNCBI<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> PHAPILEGACC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct OJEJHDIPJBH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, PPCKODFHBID<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> PHAPILEGACC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct OGGNGCDOJMA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, PPCKODFHBID<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> PHAPILEGACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector AFMFIAECDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int FFCBHHABFJN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct JLNEMKGPOEA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, PPCKODFHBID<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private OGGNGCDOJMA<TSrc, TValue, TSelector> MDEDOOHPCNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue LNKOLLCFBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int PFCFNJKDJBK;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class DCHNFDDIOKE
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct PFKEDNJONDL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> PHAPILEGACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int PFCFNJKDJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int JCKENAHFFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T LNKOLLCFBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T NGEAKCNCKDI;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AOIKGLJHPKL AMACHMNLDAL
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x4150180", Offset = "0x414F580", VA = "0x184150180")]
			get
			{
				return default(AOIKGLJHPKL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T LJODJNPIFEG
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, AOIKGLJHPKL) ODFFHKFHEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x41504F0", Offset = "0x414F8F0", VA = "0x1841504F0")]
			get
			{
				return default((T, AOIKGLJHPKL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5092000", Offset = "0x5091400", VA = "0x185092000")]
		public PFKEDNJONDL(NativeArray<T> PHAPILEGACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4150590", Offset = "0x414F990", VA = "0x184150590")]
		public PFKEDNJONDL<T> NFFMPMPKJEP()
		{
			return default(PFKEDNJONDL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5091E30", Offset = "0x5091230", VA = "0x185091E30")]
		public bool HGNGIMJAKLP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x39AEED0", Offset = "0x39AE2D0", VA = "0x1839AEED0")]
		public EPMBAHHBLEG<T, TComparer> MLOBPBBMCOI<TComparer>([Optional] TComparer AOJPHHLKMJI) where TComparer : struct, IEqualityComparer<T>
		{
			return default(EPMBAHHBLEG<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct EPMBAHHBLEG<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> PHAPILEGACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int PFCFNJKDJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int JCKENAHFFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T LNKOLLCFBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T NGEAKCNCKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer AOJPHHLKMJI;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public AOIKGLJHPKL AMACHMNLDAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x4150180", Offset = "0x414F580", VA = "0x184150180")]
			get
			{
				return default(AOIKGLJHPKL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T LJODJNPIFEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, AOIKGLJHPKL range) ODFFHKFHEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x41504F0", Offset = "0x414F8F0", VA = "0x1841504F0")]
			get
			{
				return default((T, AOIKGLJHPKL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4150610", Offset = "0x414FA10", VA = "0x184150610")]
		public EPMBAHHBLEG(NativeArray<T> PHAPILEGACC, TComparer AOJPHHLKMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x327F710", Offset = "0x327EB10", VA = "0x18327F710")]
		public EPMBAHHBLEG<T, TComparer> NFFMPMPKJEP()
		{
			return default(EPMBAHHBLEG<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4150190", Offset = "0x414F590", VA = "0x184150190")]
		public bool HGNGIMJAKLP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x32CAF60", Offset = "0x32CA360", VA = "0x1832CAF60")]
	public static PFKEDNJONDL<T> HLHFCJNOAIN<T>(this NativeArray<T> PHAPILEGACC) where T : struct
	{
		return default(PFKEDNJONDL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface HFNKAIDMFKB
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class NLLNKPEEHDJ
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct JANAIGGLNDK<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class OFFCHCGMDAA : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public JANAIGGLNDK<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAFAF40", Offset = "0xAFA340", VA = "0x180AFAF40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x45E8950", Offset = "0x45E7D50", VA = "0x1845E8950", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public OFFCHCGMDAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4FA1AE0", Offset = "0x4FA0EE0", VA = "0x184FA1AE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4FA1CB0", Offset = "0x4FA10B0", VA = "0x184FA1CB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> GFAPFJDEHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream NCMIFGJNOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream LOGLENFMHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf KIMKLLCFIPN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int AKPIBKEABKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAE5990", Offset = "0xAE4D90", VA = "0x180AE5990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x49F5050", Offset = "0x49F4450", VA = "0x1849F5050", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x49F5090", Offset = "0x49F4490", VA = "0x1849F5090", Slot = "4")]
	[IteratorStateMachine(typeof(JANAIGGLNDK<>.OFFCHCGMDAA))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x49F5190", Offset = "0x49F4590", VA = "0x1849F5190", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LGEMKCLPBMB<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] LMNIHILKKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf KIMKLLCFIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream NCMIFGJNOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream PELIALLNLDC;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4BF40F0", Offset = "0x4BF34F0", VA = "0x184BF40F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct OAOFEMKANHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream NCMIFGJNOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream LOGLENFMHEA;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7755250", Offset = "0x7754650", VA = "0x187755250", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct GJPCDCCGGOM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] LMNIHILKKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream NCMIFGJNOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream PELIALLNLDC;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7754980", Offset = "0x7753D80", VA = "0x187754980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GBLJFDIOPLP
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class BMELBKMOCOE
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum MHLJPLCAKHK
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
internal static class FOFPLHJPNGH
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class FKHLMKNECEB
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public FKHLMKNECEB()
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

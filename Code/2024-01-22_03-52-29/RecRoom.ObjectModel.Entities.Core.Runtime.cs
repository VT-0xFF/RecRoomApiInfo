using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Jobs;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PGJEJCLJKOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct HJKLIGDHGKH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private EntityManager NJALJNGMKOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeArray<Entity> NNLFMKFJDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int FGBBDGJMFEH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x382A5E0", Offset = "0x38299E0", VA = "0x18382A5E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x382A680", Offset = "0x3829A80", VA = "0x18382A680")]
		public HJKLIGDHGKH(NativeArray<Entity> NNLFMKFJDMK, EntityManager NJALJNGMKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x382A670", Offset = "0x3829A70", VA = "0x18382A670")]
		public bool JLBCKNFAMDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x32E1C20", Offset = "0x32E1020", VA = "0x1832E1C20")]
		public HJKLIGDHGKH<T> FPDPCEFPILF()
		{
			return default(HJKLIGDHGKH<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct GKGHJCMJFOD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityManager NJALJNGMKOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeArray<Entity> NNLFMKFJDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int FGBBDGJMFEH;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2797180", Offset = "0x2796580", VA = "0x182797180")]
	public static int JMGJPJALLBH<T>(this NativeArray<T> PAHKKNONPEO) where T : struct
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2797190", Offset = "0x2796590", VA = "0x182797190")]
	public static int JMGJPJALLBH<T>(this NativeList<T> PAHKKNONPEO) where T : struct
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60ECB20", Offset = "0x60EBF20", VA = "0x1860ECB20")]
	public static void OHOPGAHNOCC(this NativeBitArray PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27973C0", Offset = "0x27967C0", VA = "0x1827973C0")]
	public static void OHOPGAHNOCC<T>(this NativeArray<T> PAHKKNONPEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2797380", Offset = "0x2796780", VA = "0x182797380")]
	public static void OHOPGAHNOCC<T>(this NativeList<T> PAHKKNONPEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2797A70", Offset = "0x2796E70", VA = "0x182797A70")]
	public static void OHOPGAHNOCC<T>(this NativeParallelHashSet<T> PAHKKNONPEO) where T : struct, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2797560", Offset = "0x2796960", VA = "0x182797560")]
	public static void OHOPGAHNOCC<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> PAHKKNONPEO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27975A0", Offset = "0x27969A0", VA = "0x1827975A0")]
	public static void OHOPGAHNOCC<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> PAHKKNONPEO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2797660", Offset = "0x2796A60", VA = "0x182797660")]
	public static JobHandle OHOPGAHNOCC<T>(this NativeArrayAsync<T> PAHKKNONPEO, JobHandle NONMHDKIABH) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2797720", Offset = "0x2796B20", VA = "0x182797720")]
	public static JobHandle OHOPGAHNOCC<T>(this NativeListAsync<T> PAHKKNONPEO, JobHandle NONMHDKIABH) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2797330", Offset = "0x2796730", VA = "0x182797330")]
	public static JobHandle OHOPGAHNOCC<T>(this NativeArray<T> PAHKKNONPEO, JobHandle NONMHDKIABH) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27973E0", Offset = "0x27967E0", VA = "0x1827973E0")]
	public static JobHandle OHOPGAHNOCC<T>(this NativeList<T> PAHKKNONPEO, JobHandle NONMHDKIABH) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27978D0", Offset = "0x2796CD0", VA = "0x1827978D0")]
	public static JobHandle OHOPGAHNOCC<T>(this NativeParallelHashSet<T> PAHKKNONPEO, JobHandle NONMHDKIABH) where T : struct, IEquatable<T>
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2797090", Offset = "0x2796490", VA = "0x182797090")]
	public static bool DCKNEPLMKNC<T>(this NativeArray<T> PAHKKNONPEO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27971E0", Offset = "0x27965E0", VA = "0x1827971E0")]
	public static HJKLIGDHGKH<T> MIFEDKILMCG<T>(this NativeList<Entity> BPDDGMKMDJL, EntityManager NJALJNGMKOL) where T : class
	{
		return default(HJKLIGDHGKH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2797280", Offset = "0x2796680", VA = "0x182797280")]
	public static HJKLIGDHGKH<T> MIFEDKILMCG<T>(this NativeArray<Entity> BPDDGMKMDJL, EntityManager NJALJNGMKOL) where T : class
	{
		return default(HJKLIGDHGKH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2797010", Offset = "0x2796410", VA = "0x182797010")]
	public static NativeArray<TKey> AOEKDLNOHGA<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> OGGBBPNBCPJ, Allocator FHOLEANHCPH, [Out] int PPGOHJOOOFC) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default(NativeArray<TKey>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27970B0", Offset = "0x27964B0", VA = "0x1827970B0")]
	public static void DEAIBIAHPPK<T1, T2>(this NativeParallelHashMap<T1, T2> NODLFLFFLNG, NativeArray<T1> JEMNPKEMDCP, NativeArray<T2> HHMCIHBKJAP) where T1 : struct, IEquatable<T1> where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x27972C0", Offset = "0x27966C0", VA = "0x1827972C0")]
	public static void OEGHLAHCHIH<TKey, TValue>(this KeyValue<TKey, TValue> FHDILOGEHPC, [Out] TKey CONEAMPCFEL, [Out] TValue PAHKKNONPEO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60ECA50", Offset = "0x60EBE50", VA = "0x1860ECA50")]
	public static NativeArray<Entity> EIAINKJMNND(this NativeParallelHashMap<Entity, Entity> HFOCNFKGMBM, NativeArray<Entity> LCFKKFCKFMH, Allocator FHOLEANHCPH)
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct ODNNLIELMCH : IEnumerable, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private ENBOGMKGGKB FMBECMFGEIP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JobHandle DODJHGDBEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60E94C0", Offset = "0x60E88C0", VA = "0x1860E94C0")]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60EC960", Offset = "0x60EBD60", VA = "0x1860EC960")]
	public ODNNLIELMCH(JobHandle NONMHDKIABH, int BPEPAFIGLCD = 8)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60E94C0", Offset = "0x60E88C0", VA = "0x1860E94C0")]
	public static JobHandle OOICJOKLJBF(ODNNLIELMCH CNKEMCPDLKD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2783E80", Offset = "0x2783280", VA = "0x182783E80")]
	public void DEAIBIAHPPK<T>(T OECGNBCIBFO) where T : struct, INativeDisposable
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2783DE0", Offset = "0x27831E0", VA = "0x182783DE0")]
	public void DEAIBIAHPPK<T>(NativeArrayAsync<T> EPAFMCCJAFF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2783DE0", Offset = "0x27831E0", VA = "0x182783DE0")]
	public void DEAIBIAHPPK<T>(NativeArray<T> EPAFMCCJAFF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2783DE0", Offset = "0x27831E0", VA = "0x182783DE0")]
	public void DEAIBIAHPPK<T>(NativeListAsync<T> EPAFMCCJAFF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2783DE0", Offset = "0x27831E0", VA = "0x182783DE0")]
	public void DEAIBIAHPPK<T>(NativeList<T> EPAFMCCJAFF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60E9310", Offset = "0x60E8710", VA = "0x1860E9310", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60EC900", Offset = "0x60EBD00", VA = "0x1860EC900", Slot = "4")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct ENBOGMKGGKB : IEnumerable, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly JobHandle NONMHDKIABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private NativeList<JobHandle> DEEBIKGCDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int FBOCICIEDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private JobHandle EHCBFOLHBMH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JobHandle IEKLJELPJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350")]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JobHandle DODJHGDBEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60E93F0", Offset = "0x60E87F0", VA = "0x1860E93F0")]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60E9550", Offset = "0x60E8950", VA = "0x1860E9550")]
	public ENBOGMKGGKB(JobHandle NONMHDKIABH, int BPEPAFIGLCD = 8)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60E94C0", Offset = "0x60E88C0", VA = "0x1860E94C0")]
	public static JobHandle OOICJOKLJBF(ENBOGMKGGKB FMBECMFGEIP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60E9240", Offset = "0x60E8640", VA = "0x1860E9240")]
	public void DEAIBIAHPPK(JobHandle AEBAPBHOHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60E9310", Offset = "0x60E8710", VA = "0x1860E9310", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60E94F0", Offset = "0x60E88F0", VA = "0x1860E94F0", Slot = "4")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60E9350", Offset = "0x60E8750", VA = "0x1860E9350")]
	private NativeList<JobHandle> FABEJEOGOGI()
	{
		return default(NativeList<JobHandle>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KBKPDACBLFD
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60EC790", Offset = "0x60EBB90", VA = "0x1860EC790")]
	public unsafe static NativeArray<byte> HJFDKEJHKPJ(byte* ELMMHONCPBG, int OGHJPGGPGJL, bool JHGABILHHDP = false)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60EC6E0", Offset = "0x60EBAE0", VA = "0x1860EC6E0")]
	public static NativeArray<byte> DIJCPKIJNFJ(ReadOnlySpan<byte> OLFKCHJCPLI)
	{
		return default(NativeArray<byte>);
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[NativeContainer]
	[NativeContainerSupportsMinMaxWriteRestriction]
	public struct ComponentTypeHandle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly bool m_IsReadOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal readonly bool m_IsZeroSized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly int m_Length;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x60E3CF0", Offset = "0x60E30F0", VA = "0x1860E3CF0")]
		internal ComponentTypeHandle(int typeIndex, bool isReadOnly, uint globalSystemVersion)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ComponentTypeList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ComponentTypes32 types;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<int> componentTypes;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x60E5AA0", Offset = "0x60E4EA0", VA = "0x1860E5AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IEnumerable<ComponentType> ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x60E5910", Offset = "0x60E4D10", VA = "0x1860E5910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x60E46B0", Offset = "0x60E3AB0", VA = "0x1860E46B0")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x60E4740", Offset = "0x60E3B40", VA = "0x1860E4740")]
		public Type GetType(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60E4640", Offset = "0x60E3A40", VA = "0x1860E4640")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x60E5160", Offset = "0x60E4560", VA = "0x1860E5160")]
		public ComponentTypeList(ComponentTypeList a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60E5040", Offset = "0x60E4440", VA = "0x1860E5040")]
		public ComponentTypeList(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x60E5270", Offset = "0x60E4670", VA = "0x1860E5270")]
		public ComponentTypeList(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x60E5840", Offset = "0x60E4C40", VA = "0x1860E5840")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x60E5760", Offset = "0x60E4B60", VA = "0x1860E5760")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x60E4B40", Offset = "0x60E3F40", VA = "0x1860E4B40")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x60E4C30", Offset = "0x60E4030", VA = "0x1860E4C30")]
		public ComponentTypeList(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x60E53A0", Offset = "0x60E47A0", VA = "0x1860E53A0")]
		public ComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60E3D80", Offset = "0x60E3180", VA = "0x1860E3D80")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x60E47B0", Offset = "0x60E3BB0", VA = "0x1860E47B0")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x60E41B0", Offset = "0x60E35B0", VA = "0x1860E41B0")]
		public static ComponentTypeList Add([In] ComponentTypeList a, [In] ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x60E4840", Offset = "0x60E3C40", VA = "0x1860E4840")]
		public static ComponentTypeList Subtract([In] ComponentTypeList a, [In] ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60E4030", Offset = "0x60E3430", VA = "0x1860E4030")]
		public static ComponentTypeList Add([In] ComponentTypeList src, params ComponentType[] additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60E4520", Offset = "0x60E3920", VA = "0x1860E4520")]
		public static ComponentTypeList Add([In] ComponentTypeList src, IEnumerable<ComponentType> additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60E5B00", Offset = "0x60E4F00", VA = "0x1860E5B00")]
		public static ComponentTypeList operator +(ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60E5B90", Offset = "0x60E4F90", VA = "0x1860E5B90")]
		public static ComponentTypeList operator -(ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x60E49E0", Offset = "0x60E3DE0", VA = "0x1860E49E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class ComponentTypeListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2492C70", Offset = "0x2492070", VA = "0x182492C70")]
		public static ComponentTypeList With<T>(this ComponentTypeList src)
		{
			return default(ComponentTypeList);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct ComponentTypes32
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct Masks
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public uint m_BufferMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public uint m_SystemStateComponentMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public uint m_SharedComponentMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public uint m_ZeroSizedMask;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private FixedList128Bytes<int> m_sorted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Masks m_masks;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x60E6850", Offset = "0x60E5C50", VA = "0x1860E6850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x60E6890", Offset = "0x60E5C90", VA = "0x1860E6890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60E5DC0", Offset = "0x60E51C0", VA = "0x1860E5DC0")]
		private void ComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60E5F90", Offset = "0x60E5390", VA = "0x1860E5F90")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60E5F10", Offset = "0x60E5310", VA = "0x1860E5F10")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60E6190", Offset = "0x60E5590", VA = "0x1860E6190")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60E67A0", Offset = "0x60E5BA0", VA = "0x1860E67A0")]
		public ComponentTypes32(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60E6210", Offset = "0x60E5610", VA = "0x1860E6210")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60E63D0", Offset = "0x60E57D0", VA = "0x1860E63D0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x60E62E0", Offset = "0x60E56E0", VA = "0x1860E62E0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x60E64B0", Offset = "0x60E58B0", VA = "0x1860E64B0")]
		public ComponentTypes32(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x60E6580", Offset = "0x60E5980", VA = "0x1860E6580")]
		public ComponentTypes32(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x60E5D70", Offset = "0x60E5170", VA = "0x1860E5D70")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x60E5FE0", Offset = "0x60E53E0", VA = "0x1860E5FE0")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x60E6030", Offset = "0x60E5430", VA = "0x1860E6030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[NativeContainer]
	public struct ComponentDataFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly int m_TypeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Unity.Entities.LookupCache m_Cache;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public NativeArray<byte> this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x60E39D0", Offset = "0x60E2DD0", VA = "0x1860E39D0")]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x60E3AE0", Offset = "0x60E2EE0", VA = "0x1860E3AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x60E3910", Offset = "0x60E2D10", VA = "0x1860E3910")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60E3870", Offset = "0x60E2C70", VA = "0x1860E3870")]
		public bool HasComponent(Entity entity)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[NativeContainer]
	public struct EntityExistenceLookupByEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
		internal unsafe EntityExistenceLookupByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x60E9770", Offset = "0x60E8B70", VA = "0x1860E9770")]
		public bool Exists(Entity entity)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x60EB2E0", Offset = "0x60EA6E0", VA = "0x1860EB2E0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, SystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x60EB3C0", Offset = "0x60EA7C0", VA = "0x1860EB3C0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x60EB4B0", Offset = "0x60EA8B0", VA = "0x1860EB4B0")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x60EB6D0", Offset = "0x60EAAD0", VA = "0x1860EB6D0")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x60EB5A0", Offset = "0x60EA9A0", VA = "0x1860EB5A0")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x60EB690", Offset = "0x60EAA90", VA = "0x1860EB690")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60EB7C0", Offset = "0x60EABC0", VA = "0x1860EB7C0")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x60EB6B0", Offset = "0x60EAAB0", VA = "0x1860EB6B0")]
		public static EntityQueryDesc WithFilterWriteGroup(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60EB000", Offset = "0x60EA400", VA = "0x1860EB000")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2511780", Offset = "0x2510B80", VA = "0x182511780")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x25116F0", Offset = "0x2510AF0", VA = "0x1825116F0")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x25116F0", Offset = "0x2510AF0", VA = "0x1825116F0")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x25116F0", Offset = "0x2510AF0", VA = "0x1825116F0")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x25116F0", Offset = "0x2510AF0", VA = "0x1825116F0")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2511720", Offset = "0x2510B20", VA = "0x182511720")]
		public static EntityQueryDesc WithAny<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2511720", Offset = "0x2510B20", VA = "0x182511720")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2511750", Offset = "0x2510B50", VA = "0x182511750")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2511750", Offset = "0x2510B50", VA = "0x182511750")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x25116F0", Offset = "0x2510AF0", VA = "0x1825116F0")]
		public static EntityQueryDesc WithAllRO<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x25116F0", Offset = "0x2510AF0", VA = "0x1825116F0")]
		public static EntityQueryDesc WithAllRO<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x25116F0", Offset = "0x2510AF0", VA = "0x1825116F0")]
		public static EntityQueryDesc WithAllRO<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x250CDF0", Offset = "0x250C1F0", VA = "0x18250CDF0")]
		private static ComponentType[] ExpandRW<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x250CEF0", Offset = "0x250C2F0", VA = "0x18250CEF0")]
		private static ComponentType[] ExpandRW<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x250D350", Offset = "0x250C750", VA = "0x18250D350")]
		private static ComponentType[] ExpandRW<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2510310", Offset = "0x250F710", VA = "0x182510310")]
		private static ComponentType[] ExpandRW<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2509E50", Offset = "0x2509250", VA = "0x182509E50")]
		private static ComponentType[] ExpandRO<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x250A4D0", Offset = "0x25098D0", VA = "0x18250A4D0")]
		private static ComponentType[] ExpandRO<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x250AE90", Offset = "0x250A290", VA = "0x18250AE90")]
		private static ComponentType[] ExpandRO<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x60EB210", Offset = "0x60EA610", VA = "0x1860EB210")]
		private static ComponentType[] Combine(ComponentType[] a, ComponentType[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ArchetypeChunkExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal static class ArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60E34C0", Offset = "0x60E28C0", VA = "0x1860E34C0")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class ChunkIterationUtilityEx
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class ComponentSystemBaseExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class DebugEntityInfoExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class DynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x24C76A0", Offset = "0x24C6AA0", VA = "0x1824C76A0")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x24C7930", Offset = "0x24C6D30", VA = "0x1824C7930")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x24C7880", Offset = "0x24C6C80", VA = "0x1824C7880")]
		public static int IndexOf<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x24C7990", Offset = "0x24C6D90", VA = "0x1824C7990")]
		public static bool Remove<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct ComponentTypeEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private EntityArchetype archetype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public ComponentType Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x60E3C70", Offset = "0x60E3070", VA = "0x1860E3C70")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x60E3C50", Offset = "0x60E3050", VA = "0x1860E3C50")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public ComponentType this[int i]
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x60E3CB0", Offset = "0x60E30B0", VA = "0x1860E3CB0")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x60E3C30", Offset = "0x60E3030", VA = "0x1860E3C30")]
			internal ComponentTypeEnumerator(EntityArchetype arch, bool includeEntity = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x3B753A0", Offset = "0x3B747A0", VA = "0x183B753A0")]
			public ComponentTypeEnumerator GetEnumerator()
			{
				return default(ComponentTypeEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x60E3C00", Offset = "0x60E3000", VA = "0x1860E3C00")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public struct AddEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private AddRemoveEnumerator enumerator;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public struct RemoveEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private AddRemoveEnumerator enumerator;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct AddRemoveEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private unsafe Unity.Entities.ComponentTypeInArchetype* srcTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private unsafe Unity.Entities.ComponentTypeInArchetype* dstTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int srcLen;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int dstLen;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private ComponentType componentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private bool add;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public (ComponentType component, bool add) Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x60E3460", Offset = "0x60E2860", VA = "0x1860E3460")]
				get
				{
					return default((ComponentType, bool));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x60E3410", Offset = "0x60E2810", VA = "0x1860E3410")]
			internal unsafe AddRemoveEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x32DD720", Offset = "0x32DCB20", VA = "0x1832DD720")]
			public AddRemoveEnumerator GetEnumerator()
			{
				return default(AddRemoveEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x60E3310", Offset = "0x60E2710", VA = "0x1860E3310")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x60E9740", Offset = "0x60E8B40", VA = "0x1860E9740")]
		public static EntityArchetype GetInstantiateArchetype(this EntityArchetype archetype)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x60E9600", Offset = "0x60E8A00", VA = "0x1860E9600")]
		public static ComponentTypeEnumerator EnumerateComponentTypes(this EntityArchetype archetype, bool includeEntity = false)
		{
			return default(ComponentTypeEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x60E9620", Offset = "0x60E8A20", VA = "0x1860E9620")]
		public static Span<int> GetAllTypeIndices(this EntityArchetype archetype)
		{
			return default(Span<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x60E9720", Offset = "0x60E8B20", VA = "0x1860E9720")]
		public static int GetEntityCount(this EntityArchetype archetype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x60E96C0", Offset = "0x60E8AC0", VA = "0x1860E96C0")]
		public static AddRemoveEnumerator GetComponentDifferences(this EntityArchetype src, EntityArchetype dst)
		{
			return default(AddRemoveEnumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class EntityManagerArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x60E9800", Offset = "0x60E8C00", VA = "0x1860E9800")]
		public static EntityArchetype CreateArchetype(this EntityManager entityManager, Span<ComponentType> types)
		{
			return default(EntityArchetype);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class EntityManagerAssertionExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class EntityManagerChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x60E98F0", Offset = "0x60E8CF0", VA = "0x1860E98F0")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(this EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x60E9A30", Offset = "0x60E8E30", VA = "0x1860E9A30")]
		public static void HackSetAllChangeVersionsToGlobalSystemVersion(this EntityManager em, Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x60E9940", Offset = "0x60E8D40", VA = "0x1860E9940")]
		public static NativeArray<ArchetypeChunk> GetChunks(this EntityManager em, NativeArray<Entity> entities, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<ArchetypeChunk>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class EntityManagerComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[BurstCompile]
		private struct SetComponentDataArrayFromArrayJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			[ReadOnly]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			[ReadOnly]
			public NativeArray<byte> src;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public ComponentDataFromEntity dst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public int typeSize;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x60ECF30", Offset = "0x60EC330", VA = "0x1860ECF30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[BurstCompile]
		private struct SetComponentDataArrayFromValueJob<T> : IJob where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			[WriteOnly]
			public ComponentDataFromEntity<T> dstArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4261850", Offset = "0x4260C50", VA = "0x184261850", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[BurstCompile]
		internal struct SetComponentDataChunkJob<T> : IJobChunk where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public ComponentTypeHandle<T> componentArrayType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x24ECAB0", Offset = "0x24EBEB0", VA = "0x1824ECAB0")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x24EC910", Offset = "0x24EBD10", VA = "0x1824EC910")]
		public static bool TryGetComponentDataField<TComponent, TValue>(this EntityManager entityManager, Entity entity, Func<TComponent, TValue> func, [Out] TValue value) where TComponent : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x60E9F80", Offset = "0x60E9380", VA = "0x1860E9F80")]
		public static void SetComponentData(this EntityManager entityManager, Entity entity, int typeIndex, ReadOnlySpan<byte> srcSpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x60E9D70", Offset = "0x60E9170", VA = "0x1860E9D70")]
		public static void SetComponentData(this EntityManager entityManager, ComponentType type, NativeArray<Entity> entities, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x24EB140", Offset = "0x24EA540", VA = "0x1824EB140")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x24EBC90", Offset = "0x24EB090", VA = "0x1824EBC90")]
		public static void SetTag<T>(this EntityManager entityManager, Entity entity, bool isTagSet) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x24EAFA0", Offset = "0x24EA3A0", VA = "0x1824EAFA0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60E9BC0", Offset = "0x60E8FC0", VA = "0x1860E9BC0")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		public static void AssertMatchingSize(int typeIndex, int length)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class EntityManagerComponentDataFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x60EA1E0", Offset = "0x60E95E0", VA = "0x1860EA1E0")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class EntityManagerEntityExistenceLookupByEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x60EA7B0", Offset = "0x60E9BB0", VA = "0x1860EA7B0")]
		public static EntityExistenceLookupByEntity GetEntityExistenceLookupByEntity(this EntityManager entityManager)
		{
			return default(EntityExistenceLookupByEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class EntityManagerComponentObjectExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x24EDE40", Offset = "0x24ED240", VA = "0x1824EDE40")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x24EDED0", Offset = "0x24ED2D0", VA = "0x1824EDED0")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, [Out] T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x24EDD60", Offset = "0x24ED160", VA = "0x1824EDD60")]
		public static void AddAndSetComponentObject<T>(this EntityManager entityManager, Entity entity, T value) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class EntityManagerComponentOrderExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class EntityManagerDependencyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x24EDFA0", Offset = "0x24ED3A0", VA = "0x1824EDFA0")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x24EE120", Offset = "0x24ED520", VA = "0x1824EE120")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x60EA530", Offset = "0x60E9930", VA = "0x1860EA530")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x60EA670", Offset = "0x60E9A70", VA = "0x1860EA670")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x60EA290", Offset = "0x60E9690", VA = "0x1860EA290")]
		public static JobHandle AddReadDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x60EA3E0", Offset = "0x60E97E0", VA = "0x1860EA3E0")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class EntityManagerDynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2507630", Offset = "0x2506A30", VA = "0x182507630")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x24EE850", Offset = "0x24EDC50", VA = "0x1824EE850")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x24EE3F0", Offset = "0x24ED7F0", VA = "0x1824EE3F0")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x24EE5B0", Offset = "0x24ED9B0", VA = "0x1824EE5B0")]
		public static DynamicBuffer<T> GetBufferRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class EntityManagerEditorExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class EntityManagerRemoveComponentExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class EntityManagerSharedComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2507850", Offset = "0x2506C50", VA = "0x182507850")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class EntityQueryArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x60EAEC0", Offset = "0x60EA2C0", VA = "0x1860EAEC0")]
		public static int CalculateArchetypeCount(this EntityQuery query)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x60EADB0", Offset = "0x60EA1B0", VA = "0x1860EADB0")]
		private static int CalculateArchetypeCount(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Unity.Entities.EntityQueryFilter filter)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class EntityQueryChangeVersionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2509D90", Offset = "0x2509190", VA = "0x182509D90")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2509E00", Offset = "0x2509200", VA = "0x182509E00")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x60EB7E0", Offset = "0x60EABE0", VA = "0x1860EB7E0")]
		public static Entity FirstMatchingEntity(this EntityQuery query)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x60EB8C0", Offset = "0x60EACC0", VA = "0x1860EB8C0")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x60EB900", Offset = "0x60EAD00", VA = "0x1860EB900")]
		public static bool IsEmpty(this EntityQuery entityQuery, [Out] int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x60EB950", Offset = "0x60EAD50", VA = "0x1860EB950")]
		public static bool IsEmpty(this EntityQueryInJob entityQuery, [Out] int count)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class EntityQueryToComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x251F9C0", Offset = "0x251EDC0", VA = "0x18251F9C0")]
		public static NativeArray<T> ToSharedComponentDataArray<T>(this EntityQuery entityQuery, Allocator allocator = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x251F1A0", Offset = "0x251E5A0", VA = "0x18251F1A0")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x60EC2E0", Offset = "0x60EB6E0", VA = "0x1860EC2E0")]
		[BurstCompatible(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", CompileTarget = BurstCompatibleAttribute.BurstCompatibleCompileTarget.Editor)]
		public static NativeArray<byte> ToComponentDataArray(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x251EB60", Offset = "0x251DF60", VA = "0x18251EB60")]
		public static NativeArrayAsync<T> ToComponentDataArrayAsync<T>(this EntityQuery query, Allocator allocator = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x60EC1A0", Offset = "0x60EB5A0", VA = "0x1860EC1A0")]
		private static NativeArray<byte> CreateComponentDataArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ComponentTypeHandle type, EntityQuery entityQuery, Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class EntityQueryToEntityArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60EC6B0", Offset = "0x60EBAB0", VA = "0x1860EC6B0")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x60EC5A0", Offset = "0x60EB9A0", VA = "0x1860EC5A0")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class JobChunkExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface IComponent
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct ArchetypeIterator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private ArchetypeChunkIterator iterator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private unsafe Unity.Entities.Archetype* lastArchetype;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface IUTF8BufferElementData : IBufferElementData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct ChunkFilterComponentChanged : IChunkChangeFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly DynamicComponentTypeHandle handle0;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x60E3840", Offset = "0x60E2C40", VA = "0x1860E3840", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct ChunkFilterAnyOf2ComponentsChanged : IChunkChangeFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly DynamicComponentTypeHandle handle0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly DynamicComponentTypeHandle handle1;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xB5FB00", Offset = "0xB5EF00", VA = "0x180B5FB00")]
		public ChunkFilterAnyOf2ComponentsChanged(DynamicComponentTypeHandle handle0, DynamicComponentTypeHandle handle1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x60E3550", Offset = "0x60E2950", VA = "0x1860E3550", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct ChunkFilterAnyOf3ComponentsChanged : IChunkChangeFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly DynamicComponentTypeHandle handle0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly DynamicComponentTypeHandle handle1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly DynamicComponentTypeHandle handle2;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x454E560", Offset = "0x454D960", VA = "0x18454E560")]
		public ChunkFilterAnyOf3ComponentsChanged(DynamicComponentTypeHandle handle0, DynamicComponentTypeHandle handle1, DynamicComponentTypeHandle handle2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x60E35D0", Offset = "0x60E29D0", VA = "0x1860E35D0", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct ChunkFilterAnyOf4ComponentsChanged : IChunkChangeFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly DynamicComponentTypeHandle handle0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly DynamicComponentTypeHandle handle1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly DynamicComponentTypeHandle handle2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly DynamicComponentTypeHandle handle3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x60E3670", Offset = "0x60E2A70", VA = "0x1860E3670", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct ChunkFilterAnyOf5ComponentsChanged : IChunkChangeFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly DynamicComponentTypeHandle handle0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly DynamicComponentTypeHandle handle1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly DynamicComponentTypeHandle handle2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly DynamicComponentTypeHandle handle3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly DynamicComponentTypeHandle handle4;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x60E3810", Offset = "0x60E2C10", VA = "0x1860E3810")]
		public ChunkFilterAnyOf5ComponentsChanged(DynamicComponentTypeHandle handle0, DynamicComponentTypeHandle handle1, DynamicComponentTypeHandle handle2, DynamicComponentTypeHandle handle3, DynamicComponentTypeHandle handle4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x60E3730", Offset = "0x60E2B30", VA = "0x1860E3730", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class ChunkChangeFilterExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x24649F0", Offset = "0x2463DF0", VA = "0x1824649F0")]
		public static ChunkFilterAnyOf2ComponentsChanged ChunkFilterAnyChanged<T1, T2>(this EntityManager entityManager)
		{
			return default(ChunkFilterAnyOf2ComponentsChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x24646D0", Offset = "0x2463AD0", VA = "0x1824646D0")]
		public static ChunkFilterAnyOf3ComponentsChanged ChunkFilterAnyChanged<T1, T2, T3>(this EntityManager entityManager)
		{
			return default(ChunkFilterAnyOf3ComponentsChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2464810", Offset = "0x2463C10", VA = "0x182464810")]
		public static ChunkFilterAnyOf5ComponentsChanged ChunkFilterAnyChanged<T1, T2, T3, T4, T5>(this EntityManager entityManager)
		{
			return default(ChunkFilterAnyOf5ComponentsChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2464580", Offset = "0x2463980", VA = "0x182464580")]
		public static int CalculateEntityCount<T>(this EntityQuery query, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2464EF0", Offset = "0x24642F0", VA = "0x182464EF0")]
		public static bool IsEmpty<T>(this EntityQuery query, T chunkChangeFilter, [Out] int count) where T : struct, IChunkChangeFilter
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2464F50", Offset = "0x2464350", VA = "0x182464F50")]
		public static bool IsEmpty<T>(this EntityQueryInJob query, T chunkChangeFilter, [Out] int count) where T : struct, IChunkChangeFilter
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[Flags]
	public enum CopyFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		NativeComponents = 1,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		ManagedComponents = 2,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		BufferComponents = 4,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		RemapEntityRefs = 8,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		All = 0xF
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal struct CopyEntitiesUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[BurstCompile]
		private struct PopulateRemappingArrayJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[ReadOnly]
			public NativeArray<Entity> dstEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x60ECB50", Offset = "0x60EBF50", VA = "0x1860ECB50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[BurstCompile]
		private struct RemapChunksFilteredJob : IJobParallelForBurstSchedulable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[ReadOnly]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[NativeDisableUnsafePtrRestriction]
			public unsafe Unity.Entities.EntityComponentStore* dstEntityComponentStore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int chunkHeaderType;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x60ECC50", Offset = "0x60EC050", VA = "0x1860ECC50", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x60E7D20", Offset = "0x60E7120", VA = "0x1860E7D20")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x60E8F90", Offset = "0x60E8390", VA = "0x1860E8F90")]
		private static NativeArray<ArchetypeChunk> GetChunksFromEntities(NativeArray<Entity> entities, EntityManager srcEntityManager)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x60E86B0", Offset = "0x60E7AB0", VA = "0x1860E86B0")]
		private unsafe static NativeArray<ArchetypeChunk> CopyEntitiesInternal(NativeArray<ArchetypeChunk> srcChunks, Unity.Entities.EntityDataAccess* srcAccess, CopyFlags copyFlags)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x60E90A0", Offset = "0x60E84A0", VA = "0x1860E90A0")]
		internal unsafe static void RemapEntityRefs(NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping, Unity.Entities.EntityDataAccess* dataAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1A6D470", Offset = "0x1A6C870", VA = "0x181A6D470")]
		private static bool HasFlag(CopyFlags copyFlags, CopyFlags testFlag)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x60E8D00", Offset = "0x60E8100", VA = "0x1860E8D00")]
		private unsafe static void CreateChunks(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x60E8BA0", Offset = "0x60E7FA0", VA = "0x1860E8BA0")]
		private unsafe static void CopyNames(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x60E7980", Offset = "0x60E6D80", VA = "0x1860E7980")]
		private static void CloneNativeComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x60E76A0", Offset = "0x60E6AA0", VA = "0x1860E76A0")]
		public unsafe static void CloneNativeComponents([In] Unity.Entities.EntityBatchInChunk srcBatch, Unity.Entities.Chunk* dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x60E69D0", Offset = "0x60E5DD0", VA = "0x1860E69D0")]
		private static void ClearBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x60E6C80", Offset = "0x60E6080", VA = "0x1860E6C80")]
		private static void ClearBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x60E6FE0", Offset = "0x60E63E0", VA = "0x1860E6FE0")]
		private static void CloneBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x60E7320", Offset = "0x60E6720", VA = "0x1860E7320")]
		private static void CloneBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x60E6E80", Offset = "0x60E6280", VA = "0x1860E6E80")]
		private static void ClearManagedComponents(NativeArray<ArchetypeChunk> chunks, uint globalSystemVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x60E7590", Offset = "0x60E6990", VA = "0x1860E7590")]
		private static void CloneManagedComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x60E8E50", Offset = "0x60E8250", VA = "0x1860E8E50")]
		private static NativeArray<Entity> CreateEntityArray(NativeArray<ArchetypeChunk> chunks, Allocator allocator, int entityCount)
		{
			return default(NativeArray<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[BurstCompatible]
	public struct EntityQueryInJob
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		internal struct NoFilter : IChunkChangeFilter
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "4")]
			public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe Unity.Entities.EntityQueryImpl* __impl;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsEmptyIgnoreFilter
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x60EBB80", Offset = "0x60EAF80", VA = "0x1860EBB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		public static implicit operator EntityQueryInJob(EntityQuery query)
		{
			return default(EntityQueryInJob);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3B75830", Offset = "0x3B74C30", VA = "0x183B75830")]
		public EntityQueryInJob(EntityQuery query)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x60EBA00", Offset = "0x60EAE00", VA = "0x1860EBA00")]
		public int CalculateEntityCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2519D90", Offset = "0x2519190", VA = "0x182519D90")]
		public int CalculateEntityCount<T>(T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60EBA50", Offset = "0x60EAE50", VA = "0x1860EBA50")]
		public ArchetypeChunkIterator GetArchetypeChunkIterator()
		{
			return default(ArchetypeChunkIterator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60EBB00", Offset = "0x60EAF00", VA = "0x1860EBB00")]
		[BurstCompatible]
		public NativeArray<Entity> ToEntityArray(EntityTypeHandle entityType, Allocator allocator = Allocator.Temp)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x251CEC0", Offset = "0x251C2C0", VA = "0x18251CEC0")]
		[BurstCompatible]
		public NativeArray<Entity> ToEntityArray<T>(EntityTypeHandle entityType, T chunkChangeFilter, Allocator allocator = Allocator.Temp) where T : struct, IChunkChangeFilter
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x251A5D0", Offset = "0x25199D0", VA = "0x18251A5D0")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle<T> componentType, Allocator allocator = Allocator.Temp) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x251A2D0", Offset = "0x25196D0", VA = "0x18251A2D0")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T, T2>(ComponentTypeHandle<T> componentType, T2 chunkChangeFilter, Allocator allocator = Allocator.Temp) where T : struct, IComponentData where T2 : struct, IChunkChangeFilter
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		internal unsafe Unity.Entities.EntityQueryImpl* _GetImpl()
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityQueryImpl*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x251E4F0", Offset = "0x251D8F0", VA = "0x18251E4F0")]
		private unsafe static void _GatherEntities<T>(Entity* entities, EntityTypeHandle entityTypeHandle, [In] Unity.Entities.UnsafeCachedChunkList cache, uint requiredChangeVersion, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x251DE30", Offset = "0x251D230", VA = "0x18251DE30")]
		private unsafe static void _GatherEntitiesWithFilter<T>(Entity* entities, Unity.Entities.EntityQueryFilter filter, Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, EntityTypeHandle entityTypeHandle, [In] Unity.Entities.UnsafeCachedChunkList cache, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x251DA30", Offset = "0x251CE30", VA = "0x18251DA30")]
		private unsafe static void _GatherComponentData<T>(byte* componentData, int typeIndex, [In] Unity.Entities.UnsafeCachedChunkList cache, uint requiredChangeVersion, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x251D510", Offset = "0x251C910", VA = "0x18251D510")]
		private unsafe static void _GatherComponentDataWithFilter<T>(byte* componentData, int typeIndex, [In] Unity.Entities.UnsafeCachedChunkList cache, [In] Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, Unity.Entities.EntityQueryFilter filter, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class EntityQueryInJobExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
		public static EntityQueryInJob UseInJob(this EntityQuery query)
		{
			return default(EntityQueryInJob);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public interface IChunkChangeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion);
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class ListExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class MemoryUtils
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x27474D0", Offset = "0x27468D0", VA = "0x1827474D0")]
		public static Memory<T> Rent<T>(int count)
		{
			return default(Memory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2747610", Offset = "0x2746A10", VA = "0x182747610")]
		public static void Return<T>(this Memory<T> memory)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public readonly struct NativeArrayAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3EC3800", Offset = "0x3EC2C00", VA = "0x183EC3800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1D31860", Offset = "0x1D30C60", VA = "0x181D31860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xB5FAF0", Offset = "0xB5EEF0", VA = "0x180B5FAF0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xB5FB00", Offset = "0xB5EF00", VA = "0x180B5FB00")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2DB0", Offset = "0x3EC21B0", VA = "0x183EC2DB0")]
		public NativeArray<T> Complete()
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2ED0", Offset = "0x3EC22D0", VA = "0x183EC2ED0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3EC3280", Offset = "0x3EC2680", VA = "0x183EC3280")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x253ED00", Offset = "0x253E100", VA = "0x18253ED00")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x276D770", Offset = "0x276CB70", VA = "0x18276D770")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x60EC810", Offset = "0x60EBC10", VA = "0x1860EC810")]
		public static JobHandle CombineHandles(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x60EC850", Offset = "0x60EBC50", VA = "0x1860EC850")]
		public static JobHandle Combine(this Span<JobHandle> handles)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct NativeListAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly NativeList<T> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3EC3800", Offset = "0x3EC2C00", VA = "0x183EC3800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x3F154C0", Offset = "0x3F148C0", VA = "0x183F154C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xB5FAF0", Offset = "0xB5EEF0", VA = "0x180B5FAF0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xB5FB00", Offset = "0xB5EF00", VA = "0x180B5FB00")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3F14FC0", Offset = "0x3F143C0", VA = "0x183F14FC0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2DB0", Offset = "0x3EC21B0", VA = "0x183EC2DB0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3F15310", Offset = "0x3F14710", VA = "0x183F15310", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3F153F0", Offset = "0x3F147F0", VA = "0x183F153F0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public readonly struct NativeMultiHashMapAsync<TKey, TValue> : IDisposable where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly NativeParallelMultiHashMap<TKey, TValue> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3F34AB0", Offset = "0x3F33EB0", VA = "0x183F34AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xB5FB00", Offset = "0xB5EF00", VA = "0x180B5FB00")]
		public NativeMultiHashMapAsync(NativeParallelMultiHashMap<TKey, TValue> map, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2DB0", Offset = "0x3EC21B0", VA = "0x183EC2DB0")]
		public NativeParallelMultiHashMap<TKey, TValue> Complete()
		{
			return default(NativeParallelMultiHashMap<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3F34A10", Offset = "0x3F33E10", VA = "0x183F34A10", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct NativeResultAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[BurstCompile]
	public struct RemapEntitiesInPlaceJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x60ECEC0", Offset = "0x60EC2C0", VA = "0x1860ECEC0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class SpanUtility
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x28C16A0", Offset = "0x28C0AA0", VA = "0x1828C16A0")]
		public static int MemCmp<T>(ReadOnlySpan<T> spanA, ReadOnlySpan<T> spanB, int length) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x28C1500", Offset = "0x28C0900", VA = "0x1828C1500")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x28C1600", Offset = "0x28C0A00", VA = "0x1828C1600")]
		public static Span<T> AsSpan<T>(this NativeList<T> list) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x28C12E0", Offset = "0x28C06E0", VA = "0x1828C12E0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28C13E0", Offset = "0x28C07E0", VA = "0x1828C13E0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class StructUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x25EC8F0", Offset = "0x25EBCF0", VA = "0x1825EC8F0")]
		public static bool Equals<T>(T a, T b) where T : struct
		{
			return default(bool);
		}
	}
}
namespace Unity.Entities.Scene
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class EntityQuerySceneExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public struct QueryResetFilterScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private EntityQuery query;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private static bool isInScope;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x60ECC00", Offset = "0x60EC000", VA = "0x1860ECC00")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x60ECBB0", Offset = "0x60EBFB0", VA = "0x1860ECBB0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x60EBDD0", Offset = "0x60EB1D0", VA = "0x1860EBDD0")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x60EC030", Offset = "0x60EB430", VA = "0x1860EC030")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x60EBD10", Offset = "0x60EB110", VA = "0x1860EBD10")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x60EBBD0", Offset = "0x60EAFD0", VA = "0x1860EBBD0")]
		public static int CalculateEntityCount(this EntityQuery query, SceneTag scene)
		{
			return default(int);
		}
	}
}
namespace Unity.Entities.LinkedEntityGroupExtensions
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class EntityManagerLinkedEntityGroupExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x60EAA60", Offset = "0x60E9E60", VA = "0x1860EAA60")]
		public static bool TryGetChildEntitySubArrayRO([In] this EntityManager entityManager, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x60EACC0", Offset = "0x60EA0C0", VA = "0x1860EACC0")]
		public static bool TryGetChildEntitySubArray([In] this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x60EAB90", Offset = "0x60E9F90", VA = "0x1860EAB90")]
		public static bool TryGetChildEntitySubArray([In] this DynamicBuffer<LinkedEntityGroup> buffer, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x60EA800", Offset = "0x60E9C00", VA = "0x1860EA800")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x60EA930", Offset = "0x60E9D30", VA = "0x1860EA930")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x60EAA30", Offset = "0x60E9E30", VA = "0x1860EAA30")]
		public static NativeArray<Entity> GetChildEntitySubArray(this DynamicBuffer<LinkedEntityGroup> buffer)
		{
			return default(NativeArray<Entity>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2325665843
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x60ED1B0", Offset = "0x60EC5B0", VA = "0x1860ED1B0")]
	public static void GCHCICJMICG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x60ED1A0", Offset = "0x60EC5A0", VA = "0x1860ED1A0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MCHCGHGHNGD
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public MCHCGHGHNGD()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
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

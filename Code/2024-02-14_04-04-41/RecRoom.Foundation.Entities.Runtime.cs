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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PDNAMIIBOCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct PBBGKOAFBFF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private EntityManager KFOGOLNDMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeArray<Entity> CLKJOCHJHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int OJANCMLFDOJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3F86580", Offset = "0x3F85980", VA = "0x183F86580")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3F86620", Offset = "0x3F85A20", VA = "0x183F86620")]
		public PBBGKOAFBFF(NativeArray<Entity> CLKJOCHJHDA, EntityManager KFOGOLNDMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3F86610", Offset = "0x3F85A10", VA = "0x183F86610")]
		public bool NLINJCHNNNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3579970", Offset = "0x3578D70", VA = "0x183579970")]
		public PBBGKOAFBFF<T> MFONJKCHJIL()
		{
			return default(PBBGKOAFBFF<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct JPCKFLCFNBA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityManager KFOGOLNDMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeArray<Entity> CLKJOCHJHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int OJANCMLFDOJ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x279DEE0", Offset = "0x279D2E0", VA = "0x18279DEE0")]
	public static int CHLAAIDMHAK<T>(this NativeArray<T> FDFHGIHHGHO) where T : struct
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x279DEF0", Offset = "0x279D2F0", VA = "0x18279DEF0")]
	public static int CHLAAIDMHAK<T>(this NativeList<T> FDFHGIHHGHO) where T : struct
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F9A0", Offset = "0x5F4EDA0", VA = "0x185F4F9A0")]
	public static void FPMLFJFDMCI(this NativeBitArray FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x279E2E0", Offset = "0x279D6E0", VA = "0x18279E2E0")]
	public static void FPMLFJFDMCI<T>(this NativeArray<T> FDFHGIHHGHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x279E2A0", Offset = "0x279D6A0", VA = "0x18279E2A0")]
	public static void FPMLFJFDMCI<T>(this NativeList<T> FDFHGIHHGHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x279E4A0", Offset = "0x279D8A0", VA = "0x18279E4A0")]
	public static void FPMLFJFDMCI<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> FDFHGIHHGHO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x279E4E0", Offset = "0x279D8E0", VA = "0x18279E4E0")]
	public static void FPMLFJFDMCI<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> FDFHGIHHGHO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x279E520", Offset = "0x279D920", VA = "0x18279E520")]
	public static JobHandle FPMLFJFDMCI<T>(this NativeArrayAsync<T> FDFHGIHHGHO, JobHandle OEAKLAEMPBC) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x279E5C0", Offset = "0x279D9C0", VA = "0x18279E5C0")]
	public static JobHandle FPMLFJFDMCI<T>(this NativeListAsync<T> FDFHGIHHGHO, JobHandle OEAKLAEMPBC) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x279E250", Offset = "0x279D650", VA = "0x18279E250")]
	public static JobHandle FPMLFJFDMCI<T>(this NativeArray<T> FDFHGIHHGHO, JobHandle OEAKLAEMPBC) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x279E320", Offset = "0x279D720", VA = "0x18279E320")]
	public static JobHandle FPMLFJFDMCI<T>(this NativeList<T> FDFHGIHHGHO, JobHandle OEAKLAEMPBC) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x279E750", Offset = "0x279DB50", VA = "0x18279E750")]
	public static JobHandle FPMLFJFDMCI<T>(this NativeParallelHashSet<T> FDFHGIHHGHO, JobHandle OEAKLAEMPBC) where T : struct, IEquatable<T>
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x279EA50", Offset = "0x279DE50", VA = "0x18279EA50")]
	public static bool INMLDJBGPFD<T>(this NativeArray<T> FDFHGIHHGHO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x279DF40", Offset = "0x279D340", VA = "0x18279DF40")]
	public static string DDELCBOHMPP<T>(this NativeArray<T> NIKMHLBDDHG, string IIKICHELIPL = ", ") where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x279EBA0", Offset = "0x279DFA0", VA = "0x18279EBA0")]
	public static PBBGKOAFBFF<T> NNFNBFOIICD<T>(this NativeList<Entity> PNDHBMNLPBD, EntityManager KFOGOLNDMKF) where T : class
	{
		return default(PBBGKOAFBFF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x279EB60", Offset = "0x279DF60", VA = "0x18279EB60")]
	public static PBBGKOAFBFF<T> NNFNBFOIICD<T>(this NativeArray<Entity> PNDHBMNLPBD, EntityManager KFOGOLNDMKF) where T : class
	{
		return default(PBBGKOAFBFF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x279EA70", Offset = "0x279DE70", VA = "0x18279EA70")]
	public static NativeArray<TKey> JIKLEKKBIMM<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> JAMEDNMIIII, Allocator FNHHOCKOINK, [Out] int JBAPJIPBGIK) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default(NativeArray<TKey>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x279E180", Offset = "0x279D580", VA = "0x18279E180")]
	public static void FLOHBAGDPJC<T1, T2>(this NativeParallelHashMap<T1, T2> NNIDGPDMKMK, NativeArray<T1> KFMNDJAIHBK, NativeArray<T2> FNPMCCBNOOB) where T1 : struct, IEquatable<T1> where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x279EAF0", Offset = "0x279DEF0", VA = "0x18279EAF0")]
	public static void LIIEGHCBNII<TKey, TValue>(this KeyValue<TKey, TValue> LGHEBJJLAGD, [Out] TKey KCGLPAPOILB, [Out] TValue FDFHGIHHGHO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F8D0", Offset = "0x5F4ECD0", VA = "0x185F4F8D0")]
	public static NativeArray<Entity> BGLKPAKIODD(this NativeParallelHashMap<Entity, Entity> OCNBGMBFNJO, NativeArray<Entity> MJHPDNECCJJ, Allocator FNHHOCKOINK)
	{
		return default(NativeArray<Entity>);
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[NativeContainer]
	[NativeContainerSupportsMinMaxWriteRestriction]
	public struct ComponentTypeHandle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly bool m_IsReadOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly bool m_IsZeroSized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int m_Length;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5F47110", Offset = "0x5F46510", VA = "0x185F47110")]
		internal ComponentTypeHandle(int typeIndex, bool isReadOnly, uint globalSystemVersion)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct ComponentTypeList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private ComponentTypes32 types;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<int> componentTypes;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5F48C20", Offset = "0x5F48020", VA = "0x185F48C20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IEnumerable<ComponentType> ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5F48A90", Offset = "0x5F47E90", VA = "0x185F48A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5F47830", Offset = "0x5F46C30", VA = "0x185F47830")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5F478C0", Offset = "0x5F46CC0", VA = "0x185F478C0")]
		public Type GetType(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F477C0", Offset = "0x5F46BC0", VA = "0x185F477C0")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5F481B0", Offset = "0x5F475B0", VA = "0x185F481B0")]
		public ComponentTypeList(ComponentTypeList a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5F482C0", Offset = "0x5F476C0", VA = "0x185F482C0")]
		public ComponentTypeList(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5F48080", Offset = "0x5F47480", VA = "0x185F48080")]
		public ComponentTypeList(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5F488D0", Offset = "0x5F47CD0", VA = "0x185F488D0")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5F483E0", Offset = "0x5F477E0", VA = "0x185F483E0")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5F489A0", Offset = "0x5F47DA0", VA = "0x185F489A0")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5F484C0", Offset = "0x5F478C0", VA = "0x185F484C0")]
		public ComponentTypeList(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5F47CC0", Offset = "0x5F470C0", VA = "0x185F47CC0")]
		public ComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F471A0", Offset = "0x5F465A0", VA = "0x185F471A0")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5F47930", Offset = "0x5F46D30", VA = "0x185F47930")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5F47450", Offset = "0x5F46850", VA = "0x185F47450")]
		public static ComponentTypeList Add([In] ComponentTypeList a, [In] ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5F479C0", Offset = "0x5F46DC0", VA = "0x185F479C0")]
		public static ComponentTypeList Subtract([In] ComponentTypeList a, [In] ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5F48C80", Offset = "0x5F48080", VA = "0x185F48C80")]
		public static ComponentTypeList operator +(ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5F48D10", Offset = "0x5F48110", VA = "0x185F48D10")]
		public static ComponentTypeList operator -(ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5F47B60", Offset = "0x5F46F60", VA = "0x185F47B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ComponentTypeListExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ComponentTypes32
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public struct Masks
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public uint m_BufferMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public uint m_SystemStateComponentMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public uint m_SharedComponentMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public uint m_ZeroSizedMask;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private FixedList128Bytes<int> m_sorted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Masks m_masks;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5F499D0", Offset = "0x5F48DD0", VA = "0x185F499D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5F49A10", Offset = "0x5F48E10", VA = "0x185F49A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5F48F40", Offset = "0x5F48340", VA = "0x185F48F40")]
		private void ComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5F49110", Offset = "0x5F48510", VA = "0x185F49110")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5F49090", Offset = "0x5F48490", VA = "0x185F49090")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5F494B0", Offset = "0x5F488B0", VA = "0x185F494B0")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5F49310", Offset = "0x5F48710", VA = "0x185F49310")]
		public ComponentTypes32(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5F49750", Offset = "0x5F48B50", VA = "0x185F49750")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5F498F0", Offset = "0x5F48CF0", VA = "0x185F498F0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5F493C0", Offset = "0x5F487C0", VA = "0x185F493C0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5F49820", Offset = "0x5F48C20", VA = "0x185F49820")]
		public ComponentTypes32(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5F49530", Offset = "0x5F48930", VA = "0x185F49530")]
		public ComponentTypes32(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5F48EF0", Offset = "0x5F482F0", VA = "0x185F48EF0")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F49160", Offset = "0x5F48560", VA = "0x185F49160")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5F491B0", Offset = "0x5F485B0", VA = "0x185F491B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[NativeContainer]
	public struct ComponentDataFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly int m_TypeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Unity.Entities.LookupCache m_Cache;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NativeArray<byte> this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5F46DF0", Offset = "0x5F461F0", VA = "0x185F46DF0")]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5F46F00", Offset = "0x5F46300", VA = "0x185F46F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5F46D30", Offset = "0x5F46130", VA = "0x185F46D30")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5F46C90", Offset = "0x5F46090", VA = "0x185F46C90")]
		public bool HasComponent(Entity entity)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[NativeContainer]
	public struct EntityExistenceLookupByEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80")]
		internal unsafe EntityExistenceLookupByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C530", Offset = "0x5F4B930", VA = "0x185F4C530")]
		public bool Exists(Entity entity)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E050", Offset = "0x5F4D450", VA = "0x185F4E050")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, SystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DF60", Offset = "0x5F4D360", VA = "0x185F4DF60")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E130", Offset = "0x5F4D530", VA = "0x185F4E130")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E350", Offset = "0x5F4D750", VA = "0x185F4E350")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E220", Offset = "0x5F4D620", VA = "0x185F4E220")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E310", Offset = "0x5F4D710", VA = "0x185F4E310")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E440", Offset = "0x5F4D840", VA = "0x185F4E440")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E330", Offset = "0x5F4D730", VA = "0x185F4E330")]
		public static EntityQueryDesc WithFilterWriteGroup(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DC80", Offset = "0x5F4D080", VA = "0x185F4DC80")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x254C9A0", Offset = "0x254BDA0", VA = "0x18254C9A0")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x254C910", Offset = "0x254BD10", VA = "0x18254C910")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x254C910", Offset = "0x254BD10", VA = "0x18254C910")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x254C910", Offset = "0x254BD10", VA = "0x18254C910")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x254C910", Offset = "0x254BD10", VA = "0x18254C910")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x254C940", Offset = "0x254BD40", VA = "0x18254C940")]
		public static EntityQueryDesc WithAny<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x254C940", Offset = "0x254BD40", VA = "0x18254C940")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x254C970", Offset = "0x254BD70", VA = "0x18254C970")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x254C970", Offset = "0x254BD70", VA = "0x18254C970")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x254C910", Offset = "0x254BD10", VA = "0x18254C910")]
		public static EntityQueryDesc WithAllRO<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x254C910", Offset = "0x254BD10", VA = "0x18254C910")]
		public static EntityQueryDesc WithAllRO<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x254C910", Offset = "0x254BD10", VA = "0x18254C910")]
		public static EntityQueryDesc WithAllRO<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x25482B0", Offset = "0x25476B0", VA = "0x1825482B0")]
		private static ComponentType[] ExpandRW<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2548210", Offset = "0x2547610", VA = "0x182548210")]
		private static ComponentType[] ExpandRW<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2549570", Offset = "0x2548970", VA = "0x182549570")]
		private static ComponentType[] ExpandRW<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2549DB0", Offset = "0x25491B0", VA = "0x182549DB0")]
		private static ComponentType[] ExpandRW<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x25435B0", Offset = "0x25429B0", VA = "0x1825435B0")]
		private static ComponentType[] ExpandRO<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2546F90", Offset = "0x2546390", VA = "0x182546F90")]
		private static ComponentType[] ExpandRO<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x25470D0", Offset = "0x25464D0", VA = "0x1825470D0")]
		private static ComponentType[] ExpandRO<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DE90", Offset = "0x5F4D290", VA = "0x185F4DE90")]
		private static ComponentType[] Combine(ComponentType[] a, ComponentType[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ArchetypeChunkExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class ArchetypeExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class ChunkIterationUtilityEx
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ComponentSystemBaseExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class DebugEntityInfoExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class DynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2500590", Offset = "0x24FF990", VA = "0x182500590")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2500820", Offset = "0x24FFC20", VA = "0x182500820")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2500770", Offset = "0x24FFB70", VA = "0x182500770")]
		public static int IndexOf<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2500880", Offset = "0x24FFC80", VA = "0x182500880")]
		public static bool Remove<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct ComponentTypeEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private EntityArchetype archetype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ComponentType Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x5F47090", Offset = "0x5F46490", VA = "0x185F47090")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x5F47070", Offset = "0x5F46470", VA = "0x185F47070")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public ComponentType this[int i]
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x5F470D0", Offset = "0x5F464D0", VA = "0x185F470D0")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5F47050", Offset = "0x5F46450", VA = "0x185F47050")]
			internal ComponentTypeEnumerator(EntityArchetype arch, bool includeEntity = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3B0B360", Offset = "0x3B0A760", VA = "0x183B0B360")]
			public ComponentTypeEnumerator GetEnumerator()
			{
				return default(ComponentTypeEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5F47020", Offset = "0x5F46420", VA = "0x185F47020")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct AddEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private AddRemoveEnumerator enumerator;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public struct RemoveEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private AddRemoveEnumerator enumerator;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct AddRemoveEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private unsafe Unity.Entities.ComponentTypeInArchetype* srcTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private unsafe Unity.Entities.ComponentTypeInArchetype* dstTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private int srcLen;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int dstLen;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private ComponentType componentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private bool add;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public (ComponentType component, bool add) Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x5F46750", Offset = "0x5F45B50", VA = "0x185F46750")]
				get
				{
					return default((ComponentType, bool));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5F46700", Offset = "0x5F45B00", VA = "0x185F46700")]
			internal unsafe AddRemoveEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x32C63A0", Offset = "0x32C57A0", VA = "0x1832C63A0")]
			public AddRemoveEnumerator GetEnumerator()
			{
				return default(AddRemoveEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5F46600", Offset = "0x5F45A00", VA = "0x185F46600")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C500", Offset = "0x5F4B900", VA = "0x185F4C500")]
		public static EntityArchetype GetInstantiateArchetype(this EntityArchetype archetype)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C3C0", Offset = "0x5F4B7C0", VA = "0x185F4C3C0")]
		public static ComponentTypeEnumerator EnumerateComponentTypes(this EntityArchetype archetype, bool includeEntity = false)
		{
			return default(ComponentTypeEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C3E0", Offset = "0x5F4B7E0", VA = "0x185F4C3E0")]
		public static Span<int> GetAllTypeIndices(this EntityArchetype archetype)
		{
			return default(Span<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C4E0", Offset = "0x5F4B8E0", VA = "0x185F4C4E0")]
		public static int GetEntityCount(this EntityArchetype archetype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C480", Offset = "0x5F4B880", VA = "0x185F4C480")]
		public static AddRemoveEnumerator GetComponentDifferences(this EntityArchetype src, EntityArchetype dst)
		{
			return default(AddRemoveEnumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class EntityManagerArchetypeExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class EntityManagerAssertionExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class EntityManagerChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C5C0", Offset = "0x5F4B9C0", VA = "0x185F4C5C0")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(this EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C700", Offset = "0x5F4BB00", VA = "0x185F4C700")]
		public static void HackSetAllChangeVersionsToGlobalSystemVersion(this EntityManager em, Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C610", Offset = "0x5F4BA10", VA = "0x185F4C610")]
		public static NativeArray<ArchetypeChunk> GetChunks(this EntityManager em, NativeArray<Entity> entities, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<ArchetypeChunk>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class EntityManagerComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[BurstCompile]
		private struct SetComponentDataArrayFromArrayJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			[ReadOnly]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			[ReadOnly]
			public NativeArray<byte> src;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public ComponentDataFromEntity dst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public int typeSize;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5F4FDB0", Offset = "0x5F4F1B0", VA = "0x185F4FDB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[BurstCompile]
		private struct SetComponentDataArrayFromValueJob<T> : IJob where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			[WriteOnly]
			public ComponentDataFromEntity<T> dstArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x41A6860", Offset = "0x41A5C60", VA = "0x1841A6860", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[BurstCompile]
		internal struct SetComponentDataChunkJob<T> : IJobChunk where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public ComponentTypeHandle<T> componentArrayType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2528600", Offset = "0x2527A00", VA = "0x182528600")]
		public static bool TrySetComponentData<T>(this EntityManager entityManager, Entity entity, T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x25264C0", Offset = "0x25258C0", VA = "0x1825264C0")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2526320", Offset = "0x2525720", VA = "0x182526320")]
		public static bool TryGetComponentDataField<TComponent, TValue>(this EntityManager entityManager, Entity entity, Func<TComponent, TValue> func, [Out] TValue value) where TComponent : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CA40", Offset = "0x5F4BE40", VA = "0x185F4CA40")]
		public static void SetComponentData(this EntityManager entityManager, Entity entity, int typeIndex, NativeArray<byte> src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CC50", Offset = "0x5F4C050", VA = "0x185F4CC50")]
		public static void SetComponentData(this EntityManager entityManager, ComponentType type, NativeArray<Entity> entities, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x25245D0", Offset = "0x25239D0", VA = "0x1825245D0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x25256A0", Offset = "0x2524AA0", VA = "0x1825256A0")]
		public static void SetTag<T>(this EntityManager entityManager, Entity entity, bool isTagSet) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x25247C0", Offset = "0x2523BC0", VA = "0x1825247C0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C890", Offset = "0x5F4BC90", VA = "0x185F4C890")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		public static void AssertMatchingSize(int typeIndex, int length)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class EntityManagerComponentDataFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CE60", Offset = "0x5F4C260", VA = "0x185F4CE60")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class EntityManagerEntityExistenceLookupByEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D430", Offset = "0x5F4C830", VA = "0x185F4D430")]
		public static EntityExistenceLookupByEntity GetEntityExistenceLookupByEntity(this EntityManager entityManager)
		{
			return default(EntityExistenceLookupByEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class EntityManagerComponentObjectExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x25289C0", Offset = "0x2527DC0", VA = "0x1825289C0")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2528A50", Offset = "0x2527E50", VA = "0x182528A50")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, [Out] T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x25288E0", Offset = "0x2527CE0", VA = "0x1825288E0")]
		public static void AddAndSetComponentObject<T>(this EntityManager entityManager, Entity entity, T value) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class EntityManagerComponentOrderExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class EntityManagerDependencyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2528B20", Offset = "0x2527F20", VA = "0x182528B20")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2528CA0", Offset = "0x25280A0", VA = "0x182528CA0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D1B0", Offset = "0x5F4C5B0", VA = "0x185F4D1B0")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D2F0", Offset = "0x5F4C6F0", VA = "0x185F4D2F0")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CF10", Offset = "0x5F4C310", VA = "0x185F4CF10")]
		public static JobHandle AddReadDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D060", Offset = "0x5F4C460", VA = "0x185F4D060")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class EntityManagerDynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2529810", Offset = "0x2528C10", VA = "0x182529810")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x25293D0", Offset = "0x25287D0", VA = "0x1825293D0")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2528F70", Offset = "0x2528370", VA = "0x182528F70")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2529130", Offset = "0x2528530", VA = "0x182529130")]
		public static DynamicBuffer<T> GetBufferRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class EntityManagerEditorExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class EntityManagerRemoveComponentExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class EntityManagerSharedComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2529A10", Offset = "0x2528E10", VA = "0x182529A10")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class EntityQueryArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DB40", Offset = "0x5F4CF40", VA = "0x185F4DB40")]
		public static int CalculateArchetypeCount(this EntityQuery query)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DA30", Offset = "0x5F4CE30", VA = "0x185F4DA30")]
		private static int CalculateArchetypeCount(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Unity.Entities.EntityQueryFilter filter)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class EntityQueryChangeVersionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2543540", Offset = "0x2542940", VA = "0x182543540")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x25434F0", Offset = "0x25428F0", VA = "0x1825434F0")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E460", Offset = "0x5F4D860", VA = "0x185F4E460")]
		public static Entity FirstMatchingEntity(this EntityQuery query)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E590", Offset = "0x5F4D990", VA = "0x185F4E590")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E540", Offset = "0x5F4D940", VA = "0x185F4E540")]
		public static bool IsEmpty(this EntityQuery entityQuery, [Out] int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E5D0", Offset = "0x5F4D9D0", VA = "0x185F4E5D0")]
		public static bool IsEmpty(this EntityQueryInJob entityQuery, [Out] int count)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class EntityQueryToComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x255A5A0", Offset = "0x25599A0", VA = "0x18255A5A0")]
		public static NativeArray<T> ToSharedComponentDataArray<T>(this EntityQuery entityQuery, Allocator allocator = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x255A320", Offset = "0x2559720", VA = "0x18255A320")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5F4EF60", Offset = "0x5F4E360", VA = "0x185F4EF60")]
		[BurstCompatible(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", CompileTarget = BurstCompatibleAttribute.BurstCompatibleCompileTarget.Editor)]
		public static NativeArray<byte> ToComponentDataArray(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2559FA0", Offset = "0x25593A0", VA = "0x182559FA0")]
		public static NativeArrayAsync<T> ToComponentDataArrayAsync<T>(this EntityQuery query, Allocator allocator = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5F4EE20", Offset = "0x5F4E220", VA = "0x185F4EE20")]
		private static NativeArray<byte> CreateComponentDataArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ComponentTypeHandle type, EntityQuery entityQuery, Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class EntityQueryToEntityArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F330", Offset = "0x5F4E730", VA = "0x185F4F330")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F220", Offset = "0x5F4E620", VA = "0x185F4F220")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class JobChunkExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct ArchetypeIterator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private ArchetypeChunkIterator iterator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private unsafe Unity.Entities.Archetype* lastArchetype;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface IUTF8BufferElementData : IBufferElementData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct AsyncDispose : IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private JobGroup group;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x5F46940", Offset = "0x5F45D40", VA = "0x185F46940")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5F46850", Offset = "0x5F45C50", VA = "0x185F46850")]
		public AsyncDispose(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5F46940", Offset = "0x5F45D40", VA = "0x185F46940")]
		public static implicit operator JobHandle(AsyncDispose set)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x23F86C0", Offset = "0x23F7AC0", VA = "0x1823F86C0")]
		public void Add<T>(T disposable) where T : struct, INativeDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x23F8620", Offset = "0x23F7A20", VA = "0x1823F8620")]
		public void Add<T>(NativeArrayAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x23F8620", Offset = "0x23F7A20", VA = "0x1823F8620")]
		public void Add<T>(NativeArray<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x23F8620", Offset = "0x23F7A20", VA = "0x1823F8620")]
		public void Add<T>(NativeListAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x23F8620", Offset = "0x23F7A20", VA = "0x1823F8620")]
		public void Add<T>(NativeList<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5F467B0", Offset = "0x5F45BB0", VA = "0x185F467B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5F467F0", Offset = "0x5F45BF0", VA = "0x185F467F0", Slot = "4")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct JobGroup : IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly JobHandle dependsOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private NativeList<JobHandle> handles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int combinedCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private JobHandle combined;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JobHandle DependsOn
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5F4F5E0", Offset = "0x5F4E9E0", VA = "0x185F4F5E0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F530", Offset = "0x5F4E930", VA = "0x185F4F530")]
		public JobGroup(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F360", Offset = "0x5F4E760", VA = "0x185F4F360")]
		public void Add(JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5F467B0", Offset = "0x5F45BB0", VA = "0x185F467B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F4D0", Offset = "0x5F4E8D0", VA = "0x185F4F4D0", Slot = "4")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F430", Offset = "0x5F4E830", VA = "0x185F4F430")]
		private NativeList<JobHandle> GetList()
		{
			return default(NativeList<JobHandle>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ChunkFilterComponentChanged : IChunkChangeFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly DynamicComponentTypeHandle handle0;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5F46C60", Offset = "0x5F46060", VA = "0x185F46C60", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ChunkFilterAnyOf2ComponentsChanged : IChunkChangeFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly DynamicComponentTypeHandle handle0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly DynamicComponentTypeHandle handle1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xB58680", Offset = "0xB57A80", VA = "0x180B58680")]
		public ChunkFilterAnyOf2ComponentsChanged(DynamicComponentTypeHandle handle0, DynamicComponentTypeHandle handle1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5F46970", Offset = "0x5F45D70", VA = "0x185F46970", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
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

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x446C820", Offset = "0x446BC20", VA = "0x18446C820")]
		public ChunkFilterAnyOf3ComponentsChanged(DynamicComponentTypeHandle handle0, DynamicComponentTypeHandle handle1, DynamicComponentTypeHandle handle2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5F469F0", Offset = "0x5F45DF0", VA = "0x185F469F0", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
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

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5F46A90", Offset = "0x5F45E90", VA = "0x185F46A90", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
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

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5F46C30", Offset = "0x5F46030", VA = "0x185F46C30")]
		public ChunkFilterAnyOf5ComponentsChanged(DynamicComponentTypeHandle handle0, DynamicComponentTypeHandle handle1, DynamicComponentTypeHandle handle2, DynamicComponentTypeHandle handle3, DynamicComponentTypeHandle handle4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5F46B50", Offset = "0x5F45F50", VA = "0x185F46B50", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class ChunkChangeFilterExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x249D860", Offset = "0x249CC60", VA = "0x18249D860")]
		public static ChunkFilterAnyOf2ComponentsChanged ChunkFilterAnyChanged<T1, T2>(this EntityManager entityManager)
		{
			return default(ChunkFilterAnyOf2ComponentsChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x249DE50", Offset = "0x249D250", VA = "0x18249DE50")]
		public static ChunkFilterAnyOf3ComponentsChanged ChunkFilterAnyChanged<T1, T2, T3>(this EntityManager entityManager)
		{
			return default(ChunkFilterAnyOf3ComponentsChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x249D950", Offset = "0x249CD50", VA = "0x18249D950")]
		public static ChunkFilterAnyOf5ComponentsChanged ChunkFilterAnyChanged<T1, T2, T3, T4, T5>(this EntityManager entityManager)
		{
			return default(ChunkFilterAnyOf5ComponentsChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x249D710", Offset = "0x249CB10", VA = "0x18249D710")]
		public static int CalculateEntityCount<T>(this EntityQuery query, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x249E080", Offset = "0x249D480", VA = "0x18249E080")]
		public static bool IsEmpty<T>(this EntityQuery query, T chunkChangeFilter, [Out] int count) where T : struct, IChunkChangeFilter
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x249E0E0", Offset = "0x249D4E0", VA = "0x18249E0E0")]
		public static bool IsEmpty<T>(this EntityQueryInJob query, T chunkChangeFilter, [Out] int count) where T : struct, IChunkChangeFilter
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
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
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal struct CopyEntitiesUtility
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
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

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x5F4F9D0", Offset = "0x5F4EDD0", VA = "0x185F4F9D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
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

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5F4FAD0", Offset = "0x5F4EED0", VA = "0x185F4FAD0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F4AEA0", Offset = "0x5F4A2A0", VA = "0x185F4AEA0")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C110", Offset = "0x5F4B510", VA = "0x185F4C110")]
		private static NativeArray<ArchetypeChunk> GetChunksFromEntities(NativeArray<Entity> entities, EntityManager srcEntityManager)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B830", Offset = "0x5F4AC30", VA = "0x185F4B830")]
		private unsafe static NativeArray<ArchetypeChunk> CopyEntitiesInternal(NativeArray<ArchetypeChunk> srcChunks, Unity.Entities.EntityDataAccess* srcAccess, CopyFlags copyFlags)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C220", Offset = "0x5F4B620", VA = "0x185F4C220")]
		internal unsafe static void RemapEntityRefs(NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping, Unity.Entities.EntityDataAccess* dataAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1A91480", Offset = "0x1A90880", VA = "0x181A91480")]
		private static bool HasFlag(CopyFlags copyFlags, CopyFlags testFlag)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5F4BE80", Offset = "0x5F4B280", VA = "0x185F4BE80")]
		private unsafe static void CreateChunks(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5F4BD20", Offset = "0x5F4B120", VA = "0x185F4BD20")]
		private unsafe static void CopyNames(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F4A820", Offset = "0x5F49C20", VA = "0x185F4A820")]
		private static void CloneNativeComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5F4ABC0", Offset = "0x5F49FC0", VA = "0x185F4ABC0")]
		public unsafe static void CloneNativeComponents([In] Unity.Entities.EntityBatchInChunk srcBatch, Unity.Entities.Chunk* dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5F49D50", Offset = "0x5F49150", VA = "0x185F49D50")]
		private static void ClearBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5F49B50", Offset = "0x5F48F50", VA = "0x185F49B50")]
		private static void ClearBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5F4A3D0", Offset = "0x5F497D0", VA = "0x185F4A3D0")]
		private static void CloneBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5F4A160", Offset = "0x5F49560", VA = "0x185F4A160")]
		private static void CloneBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5F4A000", Offset = "0x5F49400", VA = "0x185F4A000")]
		private static void ClearManagedComponents(NativeArray<ArchetypeChunk> chunks, uint globalSystemVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5F4A710", Offset = "0x5F49B10", VA = "0x185F4A710")]
		private static void CloneManagedComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5F4BFD0", Offset = "0x5F4B3D0", VA = "0x185F4BFD0")]
		private static NativeArray<Entity> CreateEntityArray(NativeArray<ArchetypeChunk> chunks, Allocator allocator, int entityCount)
		{
			return default(NativeArray<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[BurstCompatible]
	public struct EntityQueryInJob
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		internal struct NoFilter : IChunkChangeFilter
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x5F4E800", Offset = "0x5F4DC00", VA = "0x185F4E800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0")]
		public static implicit operator EntityQueryInJob(EntityQuery query)
		{
			return default(EntityQueryInJob);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3B72BB0", Offset = "0x3B71FB0", VA = "0x183B72BB0")]
		public EntityQueryInJob(EntityQuery query)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E680", Offset = "0x5F4DA80", VA = "0x185F4E680")]
		public int CalculateEntityCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2554E70", Offset = "0x2554270", VA = "0x182554E70")]
		public int CalculateEntityCount<T>(T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E6D0", Offset = "0x5F4DAD0", VA = "0x185F4E6D0")]
		public ArchetypeChunkIterator GetArchetypeChunkIterator()
		{
			return default(ArchetypeChunkIterator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E780", Offset = "0x5F4DB80", VA = "0x185F4E780")]
		[BurstCompatible]
		public NativeArray<Entity> ToEntityArray(EntityTypeHandle entityType, Allocator allocator = Allocator.Temp)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2558300", Offset = "0x2557700", VA = "0x182558300")]
		[BurstCompatible]
		public NativeArray<Entity> ToEntityArray<T>(EntityTypeHandle entityType, T chunkChangeFilter, Allocator allocator = Allocator.Temp) where T : struct, IChunkChangeFilter
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x25556B0", Offset = "0x2554AB0", VA = "0x1825556B0")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle<T> componentType, Allocator allocator = Allocator.Temp) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x25553B0", Offset = "0x25547B0", VA = "0x1825553B0")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T, T2>(ComponentTypeHandle<T> componentType, T2 chunkChangeFilter, Allocator allocator = Allocator.Temp) where T : struct, IComponentData where T2 : struct, IChunkChangeFilter
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0")]
		internal unsafe Unity.Entities.EntityQueryImpl* _GetImpl()
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityQueryImpl*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2559930", Offset = "0x2558D30", VA = "0x182559930")]
		private unsafe static void _GatherEntities<T>(Entity* entities, EntityTypeHandle entityTypeHandle, [In] Unity.Entities.UnsafeCachedChunkList cache, uint requiredChangeVersion, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2559270", Offset = "0x2558670", VA = "0x182559270")]
		private unsafe static void _GatherEntitiesWithFilter<T>(Entity* entities, Unity.Entities.EntityQueryFilter filter, Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, EntityTypeHandle entityTypeHandle, [In] Unity.Entities.UnsafeCachedChunkList cache, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2558E70", Offset = "0x2558270", VA = "0x182558E70")]
		private unsafe static void _GatherComponentData<T>(byte* componentData, int typeIndex, [In] Unity.Entities.UnsafeCachedChunkList cache, uint requiredChangeVersion, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2558950", Offset = "0x2557D50", VA = "0x182558950")]
		private unsafe static void _GatherComponentDataWithFilter<T>(byte* componentData, int typeIndex, [In] Unity.Entities.UnsafeCachedChunkList cache, [In] Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, Unity.Entities.EntityQueryFilter filter, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class EntityQueryInJobExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0")]
		public static EntityQueryInJob UseInJob(this EntityQuery query)
		{
			return default(EntityQueryInJob);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface IChunkChangeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion);
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class ListExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class MemoryUtils
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
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
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3E15640", Offset = "0x3E14A40", VA = "0x183E15640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1D46F30", Offset = "0x1D46330", VA = "0x181D46F30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xB58670", Offset = "0xB57A70", VA = "0x180B58670")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xB58680", Offset = "0xB57A80", VA = "0x180B58680")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E14BF0", Offset = "0x3E13FF0", VA = "0x183E14BF0")]
		public NativeArray<T> Complete()
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E15520", Offset = "0x3E14920", VA = "0x183E15520", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E15240", Offset = "0x3E14640", VA = "0x183E15240")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x256ECB0", Offset = "0x256E0B0", VA = "0x18256ECB0")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2772130", Offset = "0x2771530", VA = "0x182772130")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F6B0", Offset = "0x5F4EAB0", VA = "0x185F4F6B0")]
		public static JobHandle CombineHandles(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F6F0", Offset = "0x5F4EAF0", VA = "0x185F4F6F0")]
		public static JobHandle Combine(this Span<JobHandle> handles)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class NativeArrayUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F7A0", Offset = "0x5F4EBA0", VA = "0x185F4F7A0")]
		public unsafe static NativeArray<byte> AsArray(byte* ptr, int length, bool isReadOnly = false)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F820", Offset = "0x5F4EC20", VA = "0x185F4F820")]
		public static NativeArray<byte> AsReadOnlyArray(ReadOnlySpan<byte> span)
		{
			return default(NativeArray<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
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
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x3E15640", Offset = "0x3E14A40", VA = "0x183E15640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x3E58300", Offset = "0x3E57700", VA = "0x183E58300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xB58670", Offset = "0xB57A70", VA = "0x180B58670")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xB58680", Offset = "0xB57A80", VA = "0x180B58680")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3E57DC0", Offset = "0x3E571C0", VA = "0x183E57DC0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3E14BF0", Offset = "0x3E13FF0", VA = "0x183E14BF0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3E58040", Offset = "0x3E57440", VA = "0x183E58040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3E57F70", Offset = "0x3E57370", VA = "0x183E57F70")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
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
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x3E78E20", Offset = "0x3E78220", VA = "0x183E78E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xB58680", Offset = "0xB57A80", VA = "0x180B58680")]
		public NativeMultiHashMapAsync(NativeParallelMultiHashMap<TKey, TValue> map, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3E14BF0", Offset = "0x3E13FF0", VA = "0x183E14BF0")]
		public NativeParallelMultiHashMap<TKey, TValue> Complete()
		{
			return default(NativeParallelMultiHashMap<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3E78D80", Offset = "0x3E78180", VA = "0x183E78D80", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct NativeResultAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[BurstCompile]
	public struct RemapEntitiesInPlaceJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5F4FD40", Offset = "0x5F4F140", VA = "0x185F4FD40", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class SpanUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28CFE60", Offset = "0x28CF260", VA = "0x1828CFE60")]
		public static int MemCmp<T>(ReadOnlySpan<T> spanA, ReadOnlySpan<T> spanB, int length) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28CFD60", Offset = "0x28CF160", VA = "0x1828CFD60")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28CFB40", Offset = "0x28CEF40", VA = "0x1828CFB40")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x28CFBC0", Offset = "0x28CEFC0", VA = "0x1828CFBC0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class StructUtility
	{
	}
}
namespace Unity.Entities.Scene
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class EntityQuerySceneExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public struct QueryResetFilterScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private EntityQuery query;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private static bool isInScope;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x5F4FA80", Offset = "0x5F4EE80", VA = "0x185F4FA80")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x5F4FA30", Offset = "0x5F4EE30", VA = "0x185F4FA30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5F4EA50", Offset = "0x5F4DE50", VA = "0x185F4EA50")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5F4ECB0", Offset = "0x5F4E0B0", VA = "0x185F4ECB0")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E990", Offset = "0x5F4DD90", VA = "0x185F4E990")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E850", Offset = "0x5F4DC50", VA = "0x185F4E850")]
		public static int CalculateEntityCount(this EntityQuery query, SceneTag scene)
		{
			return default(int);
		}
	}
}
namespace Unity.Entities.LinkedEntityGroupExtensions
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class EntityManagerLinkedEntityGroupExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D6E0", Offset = "0x5F4CAE0", VA = "0x185F4D6E0")]
		public static bool TryGetChildEntitySubArrayRO([In] this EntityManager entityManager, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D810", Offset = "0x5F4CC10", VA = "0x185F4D810")]
		public static bool TryGetChildEntitySubArray([In] this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D900", Offset = "0x5F4CD00", VA = "0x185F4D900")]
		public static bool TryGetChildEntitySubArray([In] this DynamicBuffer<LinkedEntityGroup> buffer, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D580", Offset = "0x5F4C980", VA = "0x185F4D580")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D480", Offset = "0x5F4C880", VA = "0x185F4D480")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D6B0", Offset = "0x5F4CAB0", VA = "0x185F4D6B0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this DynamicBuffer<LinkedEntityGroup> buffer)
		{
			return default(NativeArray<Entity>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1464308068
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5F50020", Offset = "0x5F4F420", VA = "0x185F50020")]
	public static void DHKPLIPCEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5F500B0", Offset = "0x5F4F4B0", VA = "0x185F500B0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class MOKIHPOCJIO
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public MOKIHPOCJIO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
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

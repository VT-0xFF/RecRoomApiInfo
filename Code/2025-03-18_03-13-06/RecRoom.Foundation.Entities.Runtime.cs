using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Entities.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NKIOJPJEIKE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct NNNJOPAKPFN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private EntityManager HOPEOGNNILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeArray<Entity> DNOHLBIMBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int KOOLKCPAFBB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4E59DD0", Offset = "0x4E58FD0", VA = "0x184E59DD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4E59E60", Offset = "0x4E59060", VA = "0x184E59E60")]
		public NNNJOPAKPFN(NativeArray<Entity> DNOHLBIMBBG, EntityManager HOPEOGNNILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4E59DC0", Offset = "0x4E58FC0", VA = "0x184E59DC0")]
		public bool NFFHEIPLBGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x32C71C0", Offset = "0x32C63C0", VA = "0x1832C71C0")]
		public NNNJOPAKPFN<T> PACLDABBHPO()
		{
			return default(NNNJOPAKPFN<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct AALAMOEONFP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityManager HOPEOGNNILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeArray<Entity> DNOHLBIMBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int KOOLKCPAFBB;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3615CC0", Offset = "0x3614EC0", VA = "0x183615CC0")]
	public static NNNJOPAKPFN<T> KHFNGMEINBK<T>(this NativeList<Entity> MFDBHAMLAOJ, EntityManager HOPEOGNNILD) where T : class
	{
		return default(NNNJOPAKPFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3615C80", Offset = "0x3614E80", VA = "0x183615C80")]
	public static NNNJOPAKPFN<T> KHFNGMEINBK<T>(this NativeArray<Entity> MFDBHAMLAOJ, EntityManager HOPEOGNNILD) where T : class
	{
		return default(NNNJOPAKPFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3615BE0", Offset = "0x3614DE0", VA = "0x183615BE0")]
	public static NativeArray<TKey> FAJPKLJGDDP<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> PBKGIMHJLME, Allocator JNKCCGKBKPB, [Out] int DPPEPOPNCJN) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default(NativeArray<TKey>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3615B40", Offset = "0x3614D40", VA = "0x183615B40")]
	public static NativeParallelHashMap<TKey, TValue> BDNMAJPHGPJ<TKey, TValue>(this NativeArray<TKey> ILCILCLKBAH, NativeArray<TValue> ALKPNNHBNLO, Allocator JNKCCGKBKPB) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(NativeParallelHashMap<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3615FB0", Offset = "0x36151B0", VA = "0x183615FB0")]
	public static NativeParallelHashSet<T> PILNEMCHLBB<T>(this NativeArray<T> LLHKKFGDNEM, AllocatorManager.AllocatorHandle JNKCCGKBKPB) where T : struct, IEquatable<T>
	{
		return default(NativeParallelHashSet<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3616040", Offset = "0x3615240", VA = "0x183616040")]
	public static NativeParallelHashSet<T> PILNEMCHLBB<T>(this NativeList<T> LLHKKFGDNEM, AllocatorManager.AllocatorHandle JNKCCGKBKPB) where T : struct, IEquatable<T>
	{
		return default(NativeParallelHashSet<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3615EE0", Offset = "0x36150E0", VA = "0x183615EE0")]
	public static void OFEFHMDJLMD<T1, T2>(this NativeParallelHashMap<T1, T2> INMHGMBPIOL, NativeArray<T1> ILCILCLKBAH, NativeArray<T2> ALKPNNHBNLO) where T1 : struct, IEquatable<T1> where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3615D80", Offset = "0x3614F80", VA = "0x183615D80")]
	public static void LMCCANMANFL<TKey, TValue>(this KeyValue<TKey, TValue> NNDJDIFFAID, [Out] TKey MBDBONINAPC, [Out] TValue OMFJNFBDJCA) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7607A00", Offset = "0x7606C00", VA = "0x187607A00")]
	public static NativeArray<Entity> IBKDJAFECPK(this NativeParallelHashMap<Entity, Entity> DJNAJLMHOOH, NativeArray<Entity> LIFDNDDDAJA, Allocator JNKCCGKBKPB)
	{
		return default(NativeArray<Entity>);
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[NativeContainer]
	public struct BufferFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly bool m_IsReadOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int m_InternalCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Unity.Entities.LookupCache m_Cache;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int TypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x25BDAC0", Offset = "0x25BCCC0", VA = "0x1825BDAC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DynamicBuffer this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x75FBDB0", Offset = "0x75FAFB0", VA = "0x1875FBDB0")]
			get
			{
				return default(DynamicBuffer);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x75FBCD0", Offset = "0x75FAED0", VA = "0x1875FBCD0")]
		internal unsafe BufferFromEntity(int typeIndex, Unity.Entities.EntityDataAccess* access, bool isReadOnly)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[NativeContainerSupportsMinMaxWriteRestriction]
	[NativeContainer]
	public struct ComponentTypeHandle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal readonly bool m_IsReadOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal readonly bool m_IsZeroSized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly int m_Length;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x75FC440", Offset = "0x75FB640", VA = "0x1875FC440")]
		internal ComponentTypeHandle(int typeIndex, bool isReadOnly, uint globalSystemVersion)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[BurstCompatible]
	public readonly struct ComponentTypeIndex : IEquatable<ComponentTypeIndex>, IComparable<ComponentTypeIndex>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly int typeIndex;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1123120", Offset = "0x1122320", VA = "0x181123120")]
		public ComponentTypeIndex(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1F61D20", Offset = "0x1F60F20", VA = "0x181F61D20", Slot = "4")]
		public bool Equals(ComponentTypeIndex other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4B8C6E0", Offset = "0x4B8B8E0", VA = "0x184B8C6E0", Slot = "5")]
		public int CompareTo(ComponentTypeIndex other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75FC4D0", Offset = "0x75FB6D0", VA = "0x1875FC4D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD44C0", Offset = "0x2BD36C0", VA = "0x182BD44C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x75FC560", Offset = "0x75FB760", VA = "0x1875FC560", Slot = "3")]
		[NotBurstCompatible]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1C8B720", Offset = "0x1C8A920", VA = "0x181C8B720")]
		public static implicit operator int(ComponentTypeIndex x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1C8B720", Offset = "0x1C8A920", VA = "0x181C8B720")]
		public static implicit operator ComponentTypeIndex(int x)
		{
			return default(ComponentTypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1C8B720", Offset = "0x1C8A920", VA = "0x181C8B720")]
		public static implicit operator ComponentTypeIndex(ComponentType type)
		{
			return default(ComponentTypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1F61D40", Offset = "0x1F60F40", VA = "0x181F61D40")]
		public static bool operator ==(ComponentTypeIndex a, ComponentTypeIndex b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x32B0BE0", Offset = "0x32AFDE0", VA = "0x1832B0BE0")]
		public static ComponentTypeIndex From<T>()
		{
			return default(ComponentTypeIndex);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ComponentTypeList : IEnumerable<ComponentType>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private ComponentTypes32 types;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<int> componentTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool isDirty;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x75FD2E0", Offset = "0x75FC4E0", VA = "0x1875FD2E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IEnumerable<ComponentType> ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x75FD190", Offset = "0x75FC390", VA = "0x1875FD190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x75FCBD0", Offset = "0x75FBDD0", VA = "0x1875FCBD0")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x75FCB10", Offset = "0x75FBD10", VA = "0x1875FCB10")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x75FD0B0", Offset = "0x75FC2B0", VA = "0x1875FD0B0")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x75FCEA0", Offset = "0x75FC0A0", VA = "0x1875FCEA0")]
		public ComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x75FC590", Offset = "0x75FB790", VA = "0x1875FC590")]
		public void Add(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x75FCC40", Offset = "0x75FBE40", VA = "0x1875FCC40")]
		public void Remove(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75FC7B0", Offset = "0x75FB9B0", VA = "0x1875FC7B0")]
		private void DistinctSort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x75FD360", Offset = "0x75FC560", VA = "0x1875FD360")]
		public static ComponentTypeList operator -(ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x75FCCD0", Offset = "0x75FBED0", VA = "0x1875FCCD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x75FCB80", Offset = "0x75FBD80", VA = "0x1875FCB80", Slot = "4")]
		public IEnumerator<ComponentType> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x75FCB80", Offset = "0x75FBD80", VA = "0x1875FCB80", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct ComponentTypes32
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
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
		private Masks m_masks;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x75FDA70", Offset = "0x75FCC70", VA = "0x1875FDA70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public readonly IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x75FDAB0", Offset = "0x75FCCB0", VA = "0x1875FDAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x75FD910", Offset = "0x75FCB10", VA = "0x1875FD910")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x75FD990", Offset = "0x75FCB90", VA = "0x1875FD990")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x75FD400", Offset = "0x75FC600", VA = "0x1875FD400")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x75FD720", Offset = "0x75FC920", VA = "0x1875FD720")]
		public void Remove(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x75FD770", Offset = "0x75FC970", VA = "0x1875FD770")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75FD680", Offset = "0x75FC880", VA = "0x1875FD680")]
		public readonly int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x75FD5A0", Offset = "0x75FC7A0", VA = "0x1875FD5A0")]
		public readonly ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x75FD7C0", Offset = "0x75FC9C0", VA = "0x1875FD7C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x75FD450", Offset = "0x75FC650", VA = "0x1875FD450")]
		private void ComputeMasks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[NativeContainer]
	public struct ArchetypeChunkFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ArchetypeChunk this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x75FB900", Offset = "0x75FAB00", VA = "0x1875FB900")]
			get
			{
				return default(ArchetypeChunk);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
		internal unsafe ArchetypeChunkFromEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x75FB740", Offset = "0x75FA940", VA = "0x1875FB740")]
		public EntityInChunk GetEntityInChunk(Entity entity)
		{
			return default(EntityInChunk);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75FB5B0", Offset = "0x75FA7B0", VA = "0x1875FB5B0")]
		public ArchetypeChunk GetArchetypeChunkAndIndex(Entity entity, [Out] int index)
		{
			return default(ArchetypeChunk);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x75FB690", Offset = "0x75FA890", VA = "0x1875FB690")]
		public UnsafeUntypedBufferAccessor GetBufferAccessorAndIndex(Entity entity, DynamicComponentTypeHandle chunkBufferTypeHandle, [Out] int indexInChunk)
		{
			return default(UnsafeUntypedBufferAccessor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x75FB4A0", Offset = "0x75FA6A0", VA = "0x1875FB4A0")]
		public unsafe bool CopyToEntity(Entity entity, DynamicComponentTypeHandle chunkBufferTypeHandle, void* srcPtr, int srcElementCount, int srcBufferSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x75FB7F0", Offset = "0x75FA9F0", VA = "0x1875FB7F0")]
		public unsafe bool TryGetReadOnlyDataBufferForEntity(Entity entity, DynamicComponentTypeHandle chunkBufferTypeHandle, [Out] void* ptr, [Out] int elementCount, [Out] int bufferSize)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[NativeContainer]
	public struct ArchetypeFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public EntityArchetype this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x75FB9C0", Offset = "0x75FABC0", VA = "0x1875FB9C0")]
			get
			{
				return default(EntityArchetype);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
		internal unsafe ArchetypeFromEntity(Unity.Entities.EntityDataAccess* access)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[NativeContainer]
	public struct ComponentDataFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly int m_TypeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Unity.Entities.LookupCache m_Cache;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int TypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x25BDAC0", Offset = "0x25BCCC0", VA = "0x1825BDAC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NativeArray<byte> this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x75FC120", Offset = "0x75FB320", VA = "0x1875FC120")]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x75FC230", Offset = "0x75FB430", VA = "0x1875FC230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x75FC060", Offset = "0x75FB260", VA = "0x1875FC060")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x75FBEE0", Offset = "0x75FB0E0", VA = "0x1875FBEE0")]
		public bool HasComponent(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x75FBF80", Offset = "0x75FB180", VA = "0x1875FBF80")]
		public bool TryGetComponent(Entity entity, [Out] NativeArray<byte> componentData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[NativeContainer]
	public struct EntityExistenceLookupByEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
		internal unsafe EntityExistenceLookupByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x76021C0", Offset = "0x76013C0", VA = "0x1876021C0")]
		public bool Exists(Entity entity)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[NativeContainer]
	public struct HasComponentByEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
		internal unsafe HasComponentByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x76075A0", Offset = "0x76067A0", VA = "0x1876075A0")]
		public bool HasComponent(Entity entity, int typeIndex)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[NativeContainer]
	public struct SharedComponentIndexFromEntity<T> where T : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly int m_TypeIndex;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5342B20", Offset = "0x5341D20", VA = "0x185342B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5342990", Offset = "0x5341B90", VA = "0x185342990")]
		internal unsafe SharedComponentIndexFromEntity(int typeIndex, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5342750", Offset = "0x5341950", VA = "0x185342750")]
		public bool TryGetSharedComponentIndex(Entity entity, [Out] int sharedIndex)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[JobProducerType(typeof(JobEntityBatchTwoQueryExtensions.JobEntityBatchTwoQueryProducer<>))]
	public interface IJobEntityBatchTwoQuery
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Execute(ArchetypeChunk batchInChunk, int batchIndex);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum ScheduleGranularity
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		Chunk,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		Entity
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class JobEntityBatchTwoQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		internal struct JobEntityBatchWrapper<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public T JobData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Unity.Entities.UnsafeMatchingArchetypePtrList MatchingArchetypes0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public Unity.Entities.UnsafeCachedChunkList CachedChunks0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Unity.Entities.EntityQueryFilter Filter0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public Unity.Entities.UnsafeMatchingArchetypePtrList MatchingArchetypes1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Unity.Entities.UnsafeCachedChunkList CachedChunks1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public Unity.Entities.EntityQueryFilter Filter1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int IsParallel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public int SkipSubChunkBatching0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public int SkipSubChunkBatching1;
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		internal struct JobEntityBatchTwoQueryProducer<T> where T : struct, IJobEntityBatchTwoQuery
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public delegate void ExecuteJobFunction(JobEntityBatchWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex);

			[Cpp2IlInjected.Token(Token = "0x400003A")]
			internal static readonly SharedStatic<IntPtr> reflectionData;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x49D83F0", Offset = "0x49D75F0", VA = "0x1849D83F0")]
			[Preserve]
			internal static void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x49AECF0", Offset = "0x49ADEF0", VA = "0x1849AECF0")]
			public static void Execute(JobEntityBatchWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x49D7F50", Offset = "0x49D7150", VA = "0x1849D7F50")]
			[SkipLocalsInit]
			internal static void ExecuteInternal(JobEntityBatchWrapper<T> jobWrapper, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x34D7E60", Offset = "0x34D7060", VA = "0x1834D7E60")]
		public static void EarlyJobInit<T>() where T : struct, IJobEntityBatchTwoQuery
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[BurstCompile]
	internal struct DummyJobEntityBatchTwoQuery : IJobEntityBatchTwoQuery
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
		public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[BurstCompile]
	internal static class DummyJobEntityBatchTwoQueryScheduler
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[DefaultMember("Item")]
	[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}")]
	[NativeContainer]
	[DebuggerTypeProxy(typeof(DynamicBufferDebugView))]
	public struct DynamicBuffer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[NoAlias]
		[NativeDisableUnsafePtrRestriction]
		private unsafe Unity.Entities.BufferHeader* m_Buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int m_ElementSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int m_AlignmentInBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int m_InternalCapacity;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x40B1760", Offset = "0x40B0960", VA = "0x1840B1760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7601F70", Offset = "0x7601170", VA = "0x187601F70")]
		internal unsafe DynamicBuffer(Unity.Entities.BufferHeader* header, int typeIndex, int internalCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7601B50", Offset = "0x7600D50", VA = "0x187601B50")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckBounds(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7601E20", Offset = "0x7601020", VA = "0x187601E20")]
		public ReadOnlySpan<byte> ElementAt(int index)
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7601F10", Offset = "0x7601110", VA = "0x187601F10")]
		public void ResizeUninitialized(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7601ED0", Offset = "0x76010D0", VA = "0x187601ED0")]
		public void EnsureCapacity(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x40AAFF0", Offset = "0x40AA1F0", VA = "0x1840AAFF0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x76019D0", Offset = "0x7600BD0", VA = "0x1876019D0")]
		public void AddRange(ReadOnlySpan<byte> srcSpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7601AC0", Offset = "0x7600CC0", VA = "0x187601AC0")]
		public NativeArray<byte> AsNativeArray()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7601C30", Offset = "0x7600E30", VA = "0x187601C30")]
		public void CopyFrom(NativeArray<byte> v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7601D70", Offset = "0x7600F70", VA = "0x187601D70")]
		public void CopyFrom(DynamicBuffer v)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal sealed class DynamicBufferDebugView
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7605970", Offset = "0x7604B70", VA = "0x187605970")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, ComponentSystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7605A50", Offset = "0x7604C50", VA = "0x187605A50")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7605B40", Offset = "0x7604D40", VA = "0x187605B40")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7605D40", Offset = "0x7604F40", VA = "0x187605D40")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7605C30", Offset = "0x7604E30", VA = "0x187605C30")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7605D20", Offset = "0x7604F20", VA = "0x187605D20")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7605E30", Offset = "0x7605030", VA = "0x187605E30")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7605690", Offset = "0x7604890", VA = "0x187605690")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3369540", Offset = "0x3368740", VA = "0x183369540")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3369480", Offset = "0x3368680", VA = "0x183369480")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3369480", Offset = "0x3368680", VA = "0x183369480")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3369480", Offset = "0x3368680", VA = "0x183369480")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3369480", Offset = "0x3368680", VA = "0x183369480")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3369480", Offset = "0x3368680", VA = "0x183369480")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4, T5>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x33694C0", Offset = "0x33686C0", VA = "0x1833694C0")]
		public static EntityQueryDesc WithAny<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x33694C0", Offset = "0x33686C0", VA = "0x1833694C0")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3369500", Offset = "0x3368700", VA = "0x183369500")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3369500", Offset = "0x3368700", VA = "0x183369500")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3369500", Offset = "0x3368700", VA = "0x183369500")]
		public static EntityQueryDesc WithNone<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3369480", Offset = "0x3368680", VA = "0x183369480")]
		public static EntityQueryDesc WithAllRO<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3369480", Offset = "0x3368680", VA = "0x183369480")]
		public static EntityQueryDesc WithAllRO<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3369480", Offset = "0x3368680", VA = "0x183369480")]
		public static EntityQueryDesc WithAllRO<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x33694C0", Offset = "0x33686C0", VA = "0x1833694C0")]
		public static EntityQueryDesc WithAnyRO<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x33694C0", Offset = "0x33686C0", VA = "0x1833694C0")]
		public static EntityQueryDesc WithAnyRO<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x33604A0", Offset = "0x335F6A0", VA = "0x1833604A0")]
		private static ComponentType[] ExpandRW<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x33603E0", Offset = "0x335F5E0", VA = "0x1833603E0")]
		private static ComponentType[] ExpandRW<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3367FB0", Offset = "0x33671B0", VA = "0x183367FB0")]
		private static ComponentType[] ExpandRW<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3368280", Offset = "0x3367480", VA = "0x183368280")]
		private static ComponentType[] ExpandRW<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3368AF0", Offset = "0x3367CF0", VA = "0x183368AF0")]
		private static ComponentType[] ExpandRW<T1, T2, T3, T4, T5>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3359C60", Offset = "0x3358E60", VA = "0x183359C60")]
		private static ComponentType[] ExpandRO<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3359CF0", Offset = "0x3358EF0", VA = "0x183359CF0")]
		private static ComponentType[] ExpandRO<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x335F630", Offset = "0x335E830", VA = "0x18335F630")]
		private static ComponentType[] ExpandRO<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x76058A0", Offset = "0x7604AA0", VA = "0x1876058A0")]
		private static ComponentType[] Combine(ComponentType[] a, ComponentType[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void EntityQueryDescBuilderInit(EntityQueryDescBuilder builder);
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class EntityQueryDescBuilderExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class ArchetypeChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3C183E0", Offset = "0x3C175E0", VA = "0x183C183E0")]
		public static ManagedComponentAccessor<T> GetManagedComponentAccessor<T>(this ArchetypeChunk chunk, ComponentTypeHandle<T> componentTypeHandle, EntityQuery query) where T : class
		{
			return default(ManagedComponentAccessor<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class ArchetypeExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class ChunkIterationUtilityEx
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class DebugEntityInfoExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x76017D0", Offset = "0x76009D0", VA = "0x1876017D0")]
		public static void DebugLogEntityInfo(this EntityManager entityManager, Entity entity, int maxDepth = 3, string componentSeparator = "\n    ")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7601710", Offset = "0x7600910", VA = "0x187601710")]
		public static string DebugGetEntityInfo(this EntityManager entityManager, Entity entity, int maxDepth = 3, string componentSeparator = "\n    ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7600680", Offset = "0x75FF880", VA = "0x187600680")]
		private static void DebugAppendEntityInfo(this EntityManager entityManager, Entity entity, StringBuilder str, int maxDepth, string componentSeparator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7600640", Offset = "0x75FF840", VA = "0x187600640")]
		private static void DebugAppendComponentInfo(EntityManager entityManager, Entity entity, ComponentType componentType, StringBuilder str, int maxDepth, string leafPrefix = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7600C40", Offset = "0x75FFE40", VA = "0x187600C40")]
		private static void DebugAppendObjectInfo(object obj, int maxDepth, StringBuilder str, string leafPrefix = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7601450", Offset = "0x7600650", VA = "0x187601450")]
		public static object DebugGetComponentBoxed(this EntityManager entityManager, Entity entity, ComponentType componentType)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class DynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x32E4DD0", Offset = "0x32E3FD0", VA = "0x1832E4DD0")]
		public static bool Contains<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x32E4F30", Offset = "0x32E4130", VA = "0x1832E4F30")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x32E5580", Offset = "0x32E4780", VA = "0x1832E5580")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x32E5460", Offset = "0x32E4660", VA = "0x1832E5460")]
		public static void RemoveAllSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x32E54F0", Offset = "0x32E46F0", VA = "0x1832E54F0")]
		public static void RemoveSetSwapBack<T>(this DynamicBuffer<T> buffer, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x32E4E10", Offset = "0x32E4010", VA = "0x1832E4E10")]
		public static bool Contains<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x32E5270", Offset = "0x32E4470", VA = "0x1832E5270")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x32E4E50", Offset = "0x32E4050", VA = "0x1832E4E50")]
		public static int IndexOf<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x32E5680", Offset = "0x32E4880", VA = "0x1832E5680")]
		public static bool Remove<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x32E55F0", Offset = "0x32E47F0", VA = "0x1832E55F0")]
		public static bool Remove<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public struct ComponentTypeEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private EntityArchetype archetype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public ComponentType Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x75FC3C0", Offset = "0x75FB5C0", VA = "0x1875FC3C0")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x75FC3A0", Offset = "0x75FB5A0", VA = "0x1875FC3A0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public ComponentType this[int i]
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x75FC400", Offset = "0x75FB600", VA = "0x1875FC400")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x75FC380", Offset = "0x75FB580", VA = "0x1875FC380")]
			internal ComponentTypeEnumerator(EntityArchetype arch, bool includeEntity = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x4A5B2B0", Offset = "0x4A5A4B0", VA = "0x184A5B2B0")]
			public ComponentTypeEnumerator GetEnumerator()
			{
				return default(ComponentTypeEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x75FC350", Offset = "0x75FB550", VA = "0x1875FC350")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public struct AddEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private AddRemoveEnumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public ComponentType Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x75FB270", Offset = "0x75FA470", VA = "0x1875FB270")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x75FB1E0", Offset = "0x75FA3E0", VA = "0x1875FB1E0")]
			internal unsafe AddEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x41C4610", Offset = "0x41C3810", VA = "0x1841C4610")]
			public AddEnumerator GetEnumerator()
			{
				return default(AddEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x75FB160", Offset = "0x75FA360", VA = "0x1875FB160")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public struct RemoveEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private AddRemoveEnumerator enumerator;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public struct AddRemoveEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private unsafe Unity.Entities.ComponentTypeInArchetype* srcTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private unsafe Unity.Entities.ComponentTypeInArchetype* dstTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int srcLen;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private int dstLen;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private ComponentType componentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private bool existsInDstNotInSrc;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public (ComponentType component, bool existsInDstNotInSrc) Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x75FB440", Offset = "0x75FA640", VA = "0x1875FB440")]
				get
				{
					return default((ComponentType, bool));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x75FB3F0", Offset = "0x75FA5F0", VA = "0x1875FB3F0")]
			internal unsafe AddRemoveEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x75FB2D0", Offset = "0x75FA4D0", VA = "0x1875FB2D0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7602190", Offset = "0x7601390", VA = "0x187602190")]
		public static EntityArchetype GetInstantiateArchetype(this EntityArchetype archetype)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7602010", Offset = "0x7601210", VA = "0x187602010")]
		public static ComponentTypeEnumerator EnumerateComponentTypes(this EntityArchetype archetype, bool includeEntity = false)
		{
			return default(ComponentTypeEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7602030", Offset = "0x7601230", VA = "0x187602030")]
		public static Span<int> GetAllTypeIndices(this EntityArchetype archetype)
		{
			return default(Span<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7602170", Offset = "0x7601370", VA = "0x187602170")]
		public static int GetEntityCount(this EntityArchetype archetype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x76020D0", Offset = "0x76012D0", VA = "0x1876020D0")]
		public static AddEnumerator GetComponentsToAdd(this EntityArchetype src, EntityArchetype dst)
		{
			return default(AddEnumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class EntityCommandBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3302770", Offset = "0x3301970", VA = "0x183302770")]
		public static void SetComponentData<T>(this EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3302AB0", Offset = "0x3301CB0", VA = "0x183302AB0")]
		public static void SetComponentData<T>(this EntityCommandBuffer.ParallelWriter ecb, int sortKey, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class ArchetypeIteratorExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x75FBA70", Offset = "0x75FAC70", VA = "0x1875FBA70")]
		public static int GetSharedComponentIndex(this ArchetypeChunkIterator it, int typeIndex)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class EntityManagerArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7602250", Offset = "0x7601450", VA = "0x187602250")]
		public static EntityArchetype CreateArchetypeWithAdditionalComponents(this EntityManager entityManager, EntityArchetype srcArchetype, NativeArray<int> typeIndices)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x76025D0", Offset = "0x76017D0", VA = "0x1876025D0")]
		public static EntityArchetype CreateArchetypeWithModifiedComponents(this EntityManager entityManager, EntityArchetype srcArchetype, NativeArray<int> adds, NativeArray<int> removes)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7602CC0", Offset = "0x7601EC0", VA = "0x187602CC0")]
		public static bool MoveToNextChunkWithEntity(this ArchetypeChunkIterator it, [Out] Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7602BE0", Offset = "0x7601DE0", VA = "0x187602BE0")]
		public static EntityArchetype GetArchetype(this EntityManager entityManager, Entity entity)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7602B40", Offset = "0x7601D40", VA = "0x187602B40")]
		public static int GetArchetypeCount(this EntityManager entityManager)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class EntityManagerArchetypeFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7602D90", Offset = "0x7601F90", VA = "0x187602D90")]
		public static ArchetypeFromEntity GetArchetypeFromEntity(this EntityManager entityManager)
		{
			return default(ArchetypeFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7602D40", Offset = "0x7601F40", VA = "0x187602D40")]
		public static ArchetypeChunkFromEntity GetArchetypeChunkFromEntity(this EntityManager entityManager)
		{
			return default(ArchetypeChunkFromEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class EntityManagerAssertionExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class EntityManagerBufferFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7602DE0", Offset = "0x7601FE0", VA = "0x187602DE0")]
		public static BufferFromEntity GetBufferFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(BufferFromEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class EntityManagerChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7602E70", Offset = "0x7602070", VA = "0x187602E70")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(this EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7602EC0", Offset = "0x76020C0", VA = "0x187602EC0")]
		public static NativeArray<ArchetypeChunk> GetChunks(this EntityManager em, NativeArray<Entity> entities, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<ArchetypeChunk>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class EntityManagerComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[BurstCompile]
		private struct SetComponentDataArrayFromArrayJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			[ReadOnly]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			[ReadOnly]
			public NativeArray<byte> src;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public ComponentDataFromEntity dst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int typeSize;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7608860", Offset = "0x7607A60", VA = "0x187608860", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[BurstCompile]
		private struct SetComponentDataArrayFromValueJob<T> : IJob where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[WriteOnly]
			public ComponentDataFromEntity<T> dstArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x5336360", Offset = "0x5335560", VA = "0x185336360", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[BurstCompile]
		private struct SetComponentDataArrayFromValueJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[ReadOnly]
			public NativeArray<byte> value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[WriteOnly]
			public ComponentDataFromEntity dstArray;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7608930", Offset = "0x7607B30", VA = "0x187608930", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[BurstCompile]
		internal struct SetComponentDataChunkJob<T> : IJobChunk where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public ComponentTypeHandle<T> componentArrayType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x33431C0", Offset = "0x33423C0", VA = "0x1833431C0")]
		public static bool TrySetComponentData<T>(this EntityManager entityManager, Entity entity, T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x76036A0", Offset = "0x76028A0", VA = "0x1876036A0")]
		public unsafe static bool TryGetComponentDataRawRW(this EntityManager entityManager, Entity entity, int typeIndex, [Out] void* ptr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7603580", Offset = "0x7602780", VA = "0x187603580")]
		public unsafe static bool TryGetComponentDataRawRO(this EntityManager entityManager, Entity entity, int typeIndex, [Out] void* ptr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x333DEB0", Offset = "0x333D0B0", VA = "0x18333DEB0")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x333B650", Offset = "0x333A850", VA = "0x18333B650")]
		public static T GetComponentDataOrDefault<T>(this EntityManager entityManager, Entity entity, [Optional] T defaultValue) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x333B7A0", Offset = "0x333A9A0", VA = "0x18333B7A0")]
		public static NativeArray<T> GetComponentDataOrDefault<T>(this EntityManager entityManager, NativeArray<Entity> entities, Allocator allocator, [Optional] T defaultValue) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x333DCE0", Offset = "0x333CEE0", VA = "0x18333DCE0")]
		public static bool TryGetComponentDataField<TComponent, TValue>(this EntityManager entityManager, Entity entity, Func<TComponent, TValue> func, [Out] TValue value) where TComponent : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x333B9D0", Offset = "0x333ABD0", VA = "0x18333B9D0")]
		public static RefRW<T> GetComponentDataRefRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IComponentData
		{
			return default(RefRW<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7603160", Offset = "0x7602360", VA = "0x187603160")]
		public static void SetComponentData(this EntityManager entityManager, Entity entity, int typeIndex, NativeArray<byte> src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7603370", Offset = "0x7602570", VA = "0x187603370")]
		public static void SetComponentData(this EntityManager entityManager, ComponentType type, NativeArray<Entity> entities, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x333BC90", Offset = "0x333AE90", VA = "0x18333BC90")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x333D6B0", Offset = "0x333C8B0", VA = "0x18333D6B0")]
		public static void SetTag<T>(this EntityManager entityManager, Entity entity, bool isTagSet) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x333C0B0", Offset = "0x333B2B0", VA = "0x18333C0B0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7602FB0", Offset = "0x76021B0", VA = "0x187602FB0")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		public static void AssertMatchingSize(int typeIndex, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		public static void AssertIsComponentData(int typeIndex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class EntityManagerComponentDataFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x76037D0", Offset = "0x76029D0", VA = "0x1876037D0")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3343C70", Offset = "0x3342E70", VA = "0x183343C70")]
		public static SharedComponentIndexFromEntity<T> GetSharedComponentIndexFromEntity<T>(this EntityManager entityManager) where T : ISharedComponentData
		{
			return default(SharedComponentIndexFromEntity<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class EntityManagerComponentObjectExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3344170", Offset = "0x3343370", VA = "0x183344170")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3344210", Offset = "0x3343410", VA = "0x183344210")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, [Out] T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3343F60", Offset = "0x3343160", VA = "0x183343F60")]
		public static void AddComponentObject<T>(this EntityManager entityManager, NativeArray<Entity> entities, HHHEOGCAMKO<T> componentArray) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3343EB0", Offset = "0x33430B0", VA = "0x183343EB0")]
		public static void AddAndSetComponentObject<T>(this EntityManager entityManager, Entity entity, T value) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class EntityManagerComponentOrderExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class EntityManagerCreateEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7603880", Offset = "0x7602A80", VA = "0x187603880")]
		public static Entity CopyEntity(this EntityManager entityManager, Entity srcEntity)
		{
			return default(Entity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class EntityManagerDependencyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7603E70", Offset = "0x7603070", VA = "0x187603E70")]
		public static void CompleteReadAndWriteDependency(this EntityManager entityManager, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x33442E0", Offset = "0x33434E0", VA = "0x1833442E0")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x33443B0", Offset = "0x33435B0", VA = "0x1833443B0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7603FF0", Offset = "0x76031F0", VA = "0x187603FF0")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7603F00", Offset = "0x7603100", VA = "0x187603F00")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, ReadOnlySpan<int> typeIndices)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7604260", Offset = "0x7603460", VA = "0x187604260")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7604170", Offset = "0x7603370", VA = "0x187604170")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, ReadOnlySpan<int> typeIndices)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7603950", Offset = "0x7602B50", VA = "0x187603950")]
		public static JobHandle AddReadDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7603AE0", Offset = "0x7602CE0", VA = "0x187603AE0")]
		public static JobHandle AddReadDependency(this EntityManager entityManager, ReadOnlySpan<int> typeIndices, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7603D00", Offset = "0x7602F00", VA = "0x187603D00")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7603BF0", Offset = "0x7602DF0", VA = "0x187603BF0")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, Span<int> typeIndices, JobHandle handle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class EntityManagerDynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7604780", Offset = "0x7603980", VA = "0x187604780")]
		public static bool TryGetBuffer(this EntityManager entityManager, Entity entity, int typeIndex, [Out] DynamicBuffer buffer, bool isReadOnly = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x76043E0", Offset = "0x76035E0", VA = "0x1876043E0")]
		public static DynamicBuffer GetBuffer(this EntityManager entityManager, Entity entity, int typeIndex, bool isReadOnly = false)
		{
			return default(DynamicBuffer);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7604480", Offset = "0x7603680", VA = "0x187604480")]
		private unsafe static DynamicBuffer GetBuffer(Unity.Entities.EntityDataAccess* access, Entity entity, int typeIndex, bool isReadOnly = false)
		{
			return default(DynamicBuffer);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3344A40", Offset = "0x3343C40", VA = "0x183344A40")]
		public static bool TryGetBufferAsRW<T>(this EntityManager entityManager, Entity entity, int typeIndex, [Out] DynamicBuffer<T> buffer) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3344770", Offset = "0x3343970", VA = "0x183344770")]
		public static DynamicBuffer<T> GetBufferAsRW<T>(this EntityManager entityManager, Entity entity, int typeIndex) where T : struct
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3344A90", Offset = "0x3343C90", VA = "0x183344A90")]
		private static bool TryGetBufferAs<T>(this EntityManager entityManager, Entity entity, int typeIndex, bool isReadOnly, [Out] DynamicBuffer<T> buffer) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x33459C0", Offset = "0x3344BC0", VA = "0x1833459C0")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3344CC0", Offset = "0x3343EC0", VA = "0x183344CC0")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3345EA0", Offset = "0x33450A0", VA = "0x183345EA0")]
		public static bool TryGetBuffer<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer, bool isReadOnly) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3344800", Offset = "0x3343A00", VA = "0x183344800")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3344890", Offset = "0x3343A90", VA = "0x183344890")]
		public static DynamicBuffer<T> GetBufferRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class EntityManagerEditorExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class EntityManagerEntityExistenceLookupByEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7604890", Offset = "0x7603A90", VA = "0x187604890")]
		public static EntityExistenceLookupByEntity GetEntityExistenceLookupByEntity(this EntityManager entityManager)
		{
			return default(EntityExistenceLookupByEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class EntityManagerFilterToExistingEntitiesExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7604E20", Offset = "0x7604020", VA = "0x187604E20")]
		public static bool PartitionExistingEntitiesUnstable(this NativeArray<Entity> liveEntities, EntityManager entityManager, [Out] NativeArray<Entity> deadEntities, bool keepCleanupEntities = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7604B70", Offset = "0x7603D70", VA = "0x187604B70")]
		public static bool PartitionExistingEntitiesUnstable(this EntityManager entityManager, NativeArray<Entity> liveEntities, [Out] NativeArray<Entity> deadEntities, bool keepCleanupEntities = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x76048E0", Offset = "0x7603AE0", VA = "0x1876048E0")]
		public static bool FilterToExistingEntities(this NativeArray<Entity> entities, EntityManager entityManager, bool keepCleanupEntities = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7604900", Offset = "0x7603B00", VA = "0x187604900")]
		public static bool FilterToExistingEntities(this EntityManager entityManager, NativeArray<Entity> entities, bool keepCleanupEntities = true)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class EntityManagerHasComponentByEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7604E40", Offset = "0x7604040", VA = "0x187604E40")]
		public static HasComponentByEntity GetHasComponentByEntity(this EntityManager entityManager)
		{
			return default(HasComponentByEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class EntityManagerIntegrityExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class EntityManagerRemoveComponentExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class EntityManagerSharedComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x33460F0", Offset = "0x33452F0", VA = "0x1833460F0")]
		public static T GetSharedComponentData<T>(this EntityManager em, ArchetypeChunkIterator it) where T : struct, ISharedComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3346290", Offset = "0x3345490", VA = "0x183346290")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class ExclusiveEntityTransactionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x342D170", Offset = "0x342C370", VA = "0x18342D170")]
		[BurstCompatible]
		public static int GetSharedComponentDataIndex<T>(this ExclusiveEntityTransaction transaction, Entity entity) where T : struct, ISharedComponentData
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x342D1F0", Offset = "0x342C3F0", VA = "0x18342D1F0")]
		[BurstCompatible]
		public static bool TryGetBufferRO<T>(this ExclusiveEntityTransaction transaction, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class RREntityRemapUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[BurstCompile]
		private struct RemapChunksFilteredJob : IJobParallelForBurstSchedulable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[NativeDisableUnsafePtrRestriction]
			public unsafe Unity.Entities.EntityComponentStore* dstEntityComponentStore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int chunkHeaderType;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x76084C0", Offset = "0x76076C0", VA = "0x1876084C0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7607B40", Offset = "0x7606D40", VA = "0x187607B40")]
		public unsafe static void PatchMatchingEntities(EntityRemapUtility.EntityPatchInfo* scalarPatches, int scalarPatchCount, EntityRemapUtility.BufferEntityPatchInfo* bufferPatches, int bufferPatchCount, byte* chunkBuffer, int entityOffset, int entityCount, NativeParallelHashMap<Entity, Entity> remapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x76081E0", Offset = "0x76073E0", VA = "0x1876081E0")]
		public static Entity RemapMatchingEntity(NativeParallelHashMap<Entity, Entity> map, Entity source)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7607DE0", Offset = "0x7606FE0", VA = "0x187607DE0")]
		public static JobHandle RemapAllMatchingEntities(this EntityManager entityManager, NativeParallelHashMap<Entity, Entity> map)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7607FD0", Offset = "0x76071D0", VA = "0x187607FD0")]
		public static JobHandle RemapAllMatchingEntities(this EntityQuery query, NativeParallelHashMap<Entity, Entity> map, EntityManager entityManager, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class EntityQueryArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7605550", Offset = "0x7604750", VA = "0x187605550")]
		public static int CalculateArchetypeCount(this EntityQuery query)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7605440", Offset = "0x7604640", VA = "0x187605440")]
		private static int CalculateArchetypeCount(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Unity.Entities.EntityQueryFilter filter)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class EntityQueryChangeVersionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x33598E0", Offset = "0x3358AE0", VA = "0x1833598E0")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3359A80", Offset = "0x3358C80", VA = "0x183359A80")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3359980", Offset = "0x3358B80", VA = "0x183359980")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3, T4>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3359B40", Offset = "0x3358D40", VA = "0x183359B40")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3, T4, T5>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3359880", Offset = "0x3358A80", VA = "0x183359880")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7605FE0", Offset = "0x76051E0", VA = "0x187605FE0")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7605EE0", Offset = "0x76050E0", VA = "0x187605EE0")]
		public static bool IsEmpty(this EntityQuery entityQuery, [Out] int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7605F30", Offset = "0x7605130", VA = "0x187605F30")]
		public static bool IsEmpty(this EntityQueryInJob entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3369610", Offset = "0x3368810", VA = "0x183369610")]
		public static AIPBCFHHAOO<T> ToComponentObjectArray<T>(this EntityQuery query) where T : class
		{
			return default(AIPBCFHHAOO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x33695A0", Offset = "0x33687A0", VA = "0x1833695A0")]
		public static ComponentTypeHandle<T> GetComponentTypeHandle<T>(this EntityQuery query, bool isReadOnly)
		{
			return default(ComponentTypeHandle<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3627460", Offset = "0x3626660", VA = "0x183627460")]
		internal unsafe static Unity.Entities.EntityDataAccess* GetEntityDataAccess(this EntityQuery query)
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityDataAccess*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7605E50", Offset = "0x7605050", VA = "0x187605E50")]
		public static uint GetGlobalSystemVersion(this EntityQuery query)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class EntityQueryToComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x337ECF0", Offset = "0x337DEF0", VA = "0x18337ECF0")]
		public static NativeArray<T> ToSharedComponentDataArray<T>(this EntityQuery entityQuery, Allocator allocator = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x337E730", Offset = "0x337D930", VA = "0x18337E730")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x76071A0", Offset = "0x76063A0", VA = "0x1876071A0")]
		[BurstCompatible(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", CompileTarget = BurstCompatibleAttribute.BurstCompatibleCompileTarget.Editor)]
		public static NativeArray<byte> ToComponentDataArray(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x337E650", Offset = "0x337D850", VA = "0x18337E650")]
		public static NativeArrayAsync<T> ToComponentDataArrayAsync<T>(this EntityQuery query, Allocator allocator = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7607060", Offset = "0x7606260", VA = "0x187607060")]
		private static NativeArray<byte> CreateComponentDataArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ComponentTypeHandle type, EntityQuery entityQuery, Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class EntityQueryToEntityArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7607570", Offset = "0x7606770", VA = "0x187607570")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7607460", Offset = "0x7606660", VA = "0x187607460")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class EntityQueryToEntityArrayFilteredExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class JobChunkExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal static class LookupCacheExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7607990", Offset = "0x7606B90", VA = "0x187607990")]
		public unsafe static int GetIndexInTypeArray(this Unity.Entities.LookupCache lookupCache, Unity.Entities.Archetype* archetype, int typeIndex)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public ref struct RefRO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private unsafe void* ptr;
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public ref struct RefRW<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private unsafe void* ptr;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
		internal unsafe RefRW(void* ptr)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class UnsafeBitArrayExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct GroupByKey<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<(TKey, NativeArray<TValue>, int, int)>, IEnumerable where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public struct Enumerator : IEnumerator<(TKey, NativeArray<TValue>, int, int)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private GroupByKey<TKey, TValue> grouped;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x41B5DE0", Offset = "0x41B4FE0", VA = "0x1841B5DE0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public (TKey key, NativeArray<TValue> values, int offset, int count) Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x41B81C0", Offset = "0x41B73C0", VA = "0x1841B81C0", Slot = "4")]
				get
				{
					return default((TKey, NativeArray<TValue>, int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x41B80E0", Offset = "0x41B72E0", VA = "0x1841B80E0")]
			public Enumerator(GroupByKey<TKey, TValue> grouped)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x41B3CE0", Offset = "0x41B2EE0", VA = "0x1841B3CE0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x41B24A0", Offset = "0x41B16A0", VA = "0x1841B24A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<TKey> uniqueKeys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<int> counts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeArray<TValue> valuesGroupedByKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeParallelHashMap<TKey, int> indexByKey;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public readonly bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x46813A0", Offset = "0x46805A0", VA = "0x1846813A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4681370", Offset = "0x4680570", VA = "0x184681370")]
		public GroupByKey(NativeArray<TKey> uniqueKeys, NativeArray<int> offsets, NativeArray<int> counts, NativeArray<TValue> valuesGroupedByKey, NativeParallelHashMap<TKey, int> indexByKey)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x467F870", Offset = "0x467EA70", VA = "0x18467F870", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x467FFC0", Offset = "0x467F1C0", VA = "0x18467FFC0")]
		public readonly NativeArray<TValue> GetValues(TKey key)
		{
			return default(NativeArray<TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x467FDD0", Offset = "0x467EFD0", VA = "0x18467FDD0")]
		public readonly NativeArray<TValue> GetValues(int index)
		{
			return default(NativeArray<TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x467F6E0", Offset = "0x467E8E0", VA = "0x18467F6E0", Slot = "4")]
		public readonly JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4680C30", Offset = "0x467FE30", VA = "0x184680C30")]
		public static GroupByKey<TKey, TValue> Group(NativeArray<TKey> keys, NativeArray<TValue> values, Allocator allocator = Allocator.Temp)
		{
			return default(GroupByKey<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x467F2F0", Offset = "0x467E4F0", VA = "0x18467F2F0")]
		[BurstDiscard]
		private static void CheckLengths(NativeArray<TKey> keys, NativeArray<TValue> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x467FD00", Offset = "0x467EF00", VA = "0x18467FD00")]
		public readonly Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x46811D0", Offset = "0x46803D0", VA = "0x1846811D0", Slot = "6")]
		private IEnumerator<(TKey, NativeArray<TValue>, int, int)> System.Collections.Generic.IEnumerable<(TKeykey,Unity.Collections.NativeArray<TValue>values,System.Int32offset,System.Int32count)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x46811D0", Offset = "0x46803D0", VA = "0x1846811D0", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct ArchetypeIterator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private ArchetypeChunkIterator iterator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private unsafe Unity.Entities.Archetype* lastArchetype;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public interface IUTF8BufferElementData : IBufferElementData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct AsyncDispose : IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private JobGroup group;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x75FBCA0", Offset = "0x75FAEA0", VA = "0x1875FBCA0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x75FBBB0", Offset = "0x75FADB0", VA = "0x1875FBBB0")]
		public AsyncDispose(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x75FBCA0", Offset = "0x75FAEA0", VA = "0x1875FBCA0")]
		public static implicit operator JobHandle(AsyncDispose set)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3130670", Offset = "0x312F870", VA = "0x183130670")]
		public void Add<T>(T disposable) where T : struct, INativeDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3130570", Offset = "0x312F770", VA = "0x183130570")]
		public void Add<T>(NativeArrayAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3130570", Offset = "0x312F770", VA = "0x183130570")]
		public void Add<T>(NativeArray<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3130570", Offset = "0x312F770", VA = "0x183130570")]
		public void Add<T>(NativeListAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3130570", Offset = "0x312F770", VA = "0x183130570")]
		public void Add<T>(NativeList<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x75FBB10", Offset = "0x75FAD10", VA = "0x1875FBB10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x75FBB50", Offset = "0x75FAD50", VA = "0x1875FBB50", Slot = "4")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public readonly struct DisableJobSchedulingScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly int existingWorkerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool disableScheduling;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7601990", Offset = "0x7600B90", VA = "0x187601990")]
		private DisableJobSchedulingScope(bool disableScheduling)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7601980", Offset = "0x7600B80", VA = "0x187601980", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7601940", Offset = "0x7600B40", VA = "0x187601940")]
		public static DisableJobSchedulingScope DisableSchedulingIfTrue(bool disableScheduling)
		{
			return default(DisableJobSchedulingScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct JobGroup : IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly JobHandle dependsOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private NativeList<JobHandle> handles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int combinedCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private JobHandle combined;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JobHandle DependsOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x76078C0", Offset = "0x7606AC0", VA = "0x1876078C0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7607810", Offset = "0x7606A10", VA = "0x187607810")]
		public JobGroup(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7607640", Offset = "0x7606840", VA = "0x187607640")]
		public void Add(JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x75FBB10", Offset = "0x75FAD10", VA = "0x1875FBB10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x76077B0", Offset = "0x76069B0", VA = "0x1876077B0", Slot = "4")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7607710", Offset = "0x7606910", VA = "0x187607710")]
		private NativeList<JobHandle> GetList()
		{
			return default(NativeList<JobHandle>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[Flags]
	public enum CopyFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		NativeComponents = 1,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		ManagedComponents = 2,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		BufferComponents = 4,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		RemapEntityRefs = 8,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		All = 0xF
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	internal struct CopyEntitiesUtility
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[BurstCompile]
		private struct PopulateRemappingArrayJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			[ReadOnly]
			public NativeArray<Entity> dstEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x7607AD0", Offset = "0x7606CD0", VA = "0x187607AD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[BurstCompile]
		private struct RemapChunksFilteredJob : IJobParallelForBurstSchedulable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			[ReadOnly]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			[NativeDisableUnsafePtrRestriction]
			public unsafe Unity.Entities.EntityComponentStore* dstEntityComponentStore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public int chunkHeaderType;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7608250", Offset = "0x7607450", VA = "0x187608250", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x75FEF50", Offset = "0x75FE150", VA = "0x1875FEF50")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7600080", Offset = "0x75FF280", VA = "0x187600080")]
		private static NativeArray<ArchetypeChunk> GetChunksFromEntities(NativeArray<Entity> entities, EntityManager srcEntityManager)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x75FF790", Offset = "0x75FE990", VA = "0x1875FF790")]
		private unsafe static NativeArray<ArchetypeChunk> CopyEntitiesInternal(NativeArray<ArchetypeChunk> srcChunks, Unity.Entities.EntityDataAccess* srcAccess, CopyFlags copyFlags)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7600340", Offset = "0x75FF540", VA = "0x187600340")]
		internal unsafe static void RemapEntityRefs(NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping, Unity.Entities.EntityDataAccess* dataAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x76004E0", Offset = "0x75FF6E0", VA = "0x1876004E0")]
		internal static void RemapEntityRefs(EntityManager entityManager, NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7600190", Offset = "0x75FF390", VA = "0x187600190")]
		public static JobHandle RemapAllEntities(EntityManager entityManager, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x66D0A30", Offset = "0x66CFC30", VA = "0x1866D0A30")]
		private static bool HasFlag(CopyFlags copyFlags, CopyFlags testFlag)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x75FFDF0", Offset = "0x75FEFF0", VA = "0x1875FFDF0")]
		private unsafe static void CreateChunks(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x75FFC90", Offset = "0x75FEE90", VA = "0x1875FFC90")]
		private unsafe static void CopyNames(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x75FE8B0", Offset = "0x75FDAB0", VA = "0x1875FE8B0")]
		private static void CloneNativeComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x75FEC60", Offset = "0x75FDE60", VA = "0x1875FEC60")]
		public unsafe static void CloneNativeComponents([In] Unity.Entities.EntityBatchInChunk srcBatch, Unity.Entities.Chunk* dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x75FDDF0", Offset = "0x75FCFF0", VA = "0x1875FDDF0")]
		private static void ClearBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x75FDBF0", Offset = "0x75FCDF0", VA = "0x1875FDBF0")]
		private static void ClearBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x75FE460", Offset = "0x75FD660", VA = "0x1875FE460")]
		private static void CloneBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x75FE1F0", Offset = "0x75FD3F0", VA = "0x1875FE1F0")]
		private static void CloneBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x75FE0A0", Offset = "0x75FD2A0", VA = "0x1875FE0A0")]
		private static void ClearManagedComponents(NativeArray<ArchetypeChunk> chunks, uint globalSystemVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x75FE7A0", Offset = "0x75FD9A0", VA = "0x1875FE7A0")]
		private static void CloneManagedComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x75FFF40", Offset = "0x75FF140", VA = "0x1875FFF40")]
		private static NativeArray<Entity> CreateEntityArray(NativeArray<ArchetypeChunk> chunks, Allocator allocator, int entityCount)
		{
			return default(NativeArray<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[BurstCompatible]
	public struct EntityQueryInJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe Unity.Entities.EntityQueryImpl* __impl;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7606E90", Offset = "0x7606090", VA = "0x187606E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool IsEmptyIgnoreFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x7606E40", Offset = "0x7606040", VA = "0x187606E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7606020", Offset = "0x7605220", VA = "0x187606020")]
		public static implicit operator EntityQueryInJob(EntityQuery query)
		{
			return default(EntityQueryInJob);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7606E10", Offset = "0x7606010", VA = "0x187606E10")]
		public EntityQueryInJob(EntityQuery query)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7606100", Offset = "0x7605300", VA = "0x187606100")]
		public int CalculateEntityCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7606300", Offset = "0x7605500", VA = "0x187606300")]
		public bool HasFilter()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x76061D0", Offset = "0x76053D0", VA = "0x1876061D0")]
		public ArchetypeChunkIterator GetArchetypeChunkIterator()
		{
			return default(ArchetypeChunkIterator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7606350", Offset = "0x7605550", VA = "0x187606350")]
		[BurstCompatible]
		public NativeArray<Entity> ToEntityArray(EntityTypeHandle entityType, Allocator allocator = Allocator.Temp)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x33797D0", Offset = "0x33789D0", VA = "0x1833797D0")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle componentType, Allocator allocator = Allocator.Temp) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3377CD0", Offset = "0x3376ED0", VA = "0x183377CD0")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle<T> componentType, Allocator allocator = Allocator.Temp) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		internal unsafe Unity.Entities.EntityQueryImpl* _GetImpl()
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityQueryImpl*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7606CA0", Offset = "0x7605EA0", VA = "0x187606CA0")]
		private unsafe static void _GatherEntities(Entity* entities, EntityTypeHandle entityTypeHandle, [In] Unity.Entities.UnsafeCachedChunkList cache, uint requiredChangeVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7606A90", Offset = "0x7605C90", VA = "0x187606A90")]
		private unsafe static void _GatherEntitiesWithFilter(Entity* entities, Unity.Entities.EntityQueryFilter filter, Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, EntityTypeHandle entityTypeHandle, [In] Unity.Entities.UnsafeCachedChunkList cache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x76068E0", Offset = "0x7605AE0", VA = "0x1876068E0")]
		private unsafe static void _GatherComponentData(byte* componentData, int typeIndex, [In] Unity.Entities.UnsafeCachedChunkList cache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x76066A0", Offset = "0x76058A0", VA = "0x1876066A0")]
		private unsafe static void _GatherComponentDataWithFilter(byte* componentData, int typeIndex, [In] Unity.Entities.UnsafeCachedChunkList cache, [In] Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, Unity.Entities.EntityQueryFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7606060", Offset = "0x7605260", VA = "0x187606060")]
		private void CalculateChunkAndEntityCount([Out] int entityCount, [Out] int chunkCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class EntityQueryInJobExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7606020", Offset = "0x7605220", VA = "0x187606020")]
		public static EntityQueryInJob UseInJob(this EntityQuery query)
		{
			return default(EntityQueryInJob);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public interface IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Execute(ArchetypeChunk batch, int batchIndex);
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class IQueryInJobEntityBatchExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x34DF760", Offset = "0x34DE960", VA = "0x1834DF760")]
		public static void Run<T>(this T operation, EntityQueryInJob query) where T : struct, IQueryInJobEntityBatch
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x34DF730", Offset = "0x34DE930", VA = "0x1834DF730")]
		public static void RunRef<T>(this T operation, EntityQueryInJob query) where T : struct, IQueryInJobEntityBatch
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x34DDF20", Offset = "0x34DD120", VA = "0x1834DDF20")]
		[SkipLocalsInit]
		private static void RunInternal<T>(this T operation, EntityQueryInJob query) where T : struct, IQueryInJobEntityBatch
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	internal struct DummyQueryInJobEntityBatch : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
		public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	internal static class DummyQueryInJobEntityBatchScheduler
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public static class ListExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class MemoryUtils
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct NativeMultiHashMapAsync<TKey, TValue> : IDisposable where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeParallelMultiHashMap<TKey, TValue> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4EF58E0", Offset = "0x4EF4AE0", VA = "0x184EF58E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4B14DE0", Offset = "0x4B13FE0", VA = "0x184B14DE0")]
		public NativeMultiHashMapAsync(NativeParallelMultiHashMap<TKey, TValue> map, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2B40", Offset = "0x4EB1D40", VA = "0x184EB2B40")]
		public NativeParallelMultiHashMap<TKey, TValue> Complete()
		{
			return default(NativeParallelMultiHashMap<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4EF5840", Offset = "0x4EF4A40", VA = "0x184EF5840", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct NativeResultAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[BurstCompile]
	public struct RemapEntitiesParallelForBatchJob : IJobParallelForBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[ReadOnly]
		public NativeArray<Entity> src;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NativeArray<Entity> dst;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x76087F0", Offset = "0x76079F0", VA = "0x1876087F0", Slot = "4")]
		public void Execute(int startIndex, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[BurstCompile]
	public struct RemapEntitiesInPlaceJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemappingRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public NativeArray<Entity> entitiesRW;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7608790", Offset = "0x7607990", VA = "0x187608790", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class StructUtility
	{
	}
}
namespace Unity.Entities.Scene
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public static class EntityQuerySceneExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct QueryResetFilterScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private EntityQuery query;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x7607B30", Offset = "0x7606D30", VA = "0x187607B30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7606EB0", Offset = "0x76060B0", VA = "0x187606EB0")]
		public static void DestroyEntitiesInScene(this EntityQuery query, SceneTag scene, EntityManager entityManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7606FD0", Offset = "0x76061D0", VA = "0x187606FD0")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}
	}
}
namespace Unity.Entities.LinkedEntityGroupExtensions
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class EntityManagerLinkedEntityGroupExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x76050F0", Offset = "0x76042F0", VA = "0x1876050F0")]
		public static bool TryGetChildEntitySubArrayRO([In] this EntityManager entityManager, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7605220", Offset = "0x7604420", VA = "0x187605220")]
		public static bool TryGetChildEntitySubArray([In] this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7605310", Offset = "0x7604510", VA = "0x187605310")]
		public static bool TryGetChildEntitySubArray([In] this DynamicBuffer<LinkedEntityGroup> buffer, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7604F90", Offset = "0x7604190", VA = "0x187604F90")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7604E90", Offset = "0x7604090", VA = "0x187604E90")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x76050C0", Offset = "0x76042C0", VA = "0x1876050C0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this DynamicBuffer<LinkedEntityGroup> buffer)
		{
			return default(NativeArray<Entity>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2322779911
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7608C40", Offset = "0x7607E40", VA = "0x187608C40")]
	public static void LAKKIDAJBKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7608C30", Offset = "0x7607E30", VA = "0x187608C30")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class DCKHMIAOKJO
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DCKHMIAOKJO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
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

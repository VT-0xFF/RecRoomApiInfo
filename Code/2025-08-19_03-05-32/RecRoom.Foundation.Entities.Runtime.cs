using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using AOT;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.Foundation.Collections;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Entities.LowLevel.Unsafe;
using Unity.IO.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using Unity.Serialization.Binary;
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85A0D70", Offset = "0x859FB70", VA = "0x1885A0D70")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LTSHTWTHUCB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct ObjectEnumerator<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private EntityManager entityManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int index;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T ZJUSDRVWEMA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5CC2360", Offset = "0x5CC1160", VA = "0x185CC2360")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CC2540", Offset = "0x5CC1340", VA = "0x185CC2540")]
		public ObjectEnumerator(NativeArray<Entity> entities, EntityManager entityManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC2350", Offset = "0x5CC1150", VA = "0x185CC2350")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x42DC540", Offset = "0x42DB340", VA = "0x1842DC540")]
		public ObjectEnumerator<T> GetEnumerator()
		{
			return default(ObjectEnumerator<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct IndexedObjectEnumerator<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private EntityManager entityManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int index;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x39F3560", Offset = "0x39F2360", VA = "0x1839F3560")]
	public static ObjectEnumerator<b> MXYIZGFNVBR<b>(this NativeList<Entity> a, EntityManager b) where b : class
	{
		return default(ObjectEnumerator<b>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x39F34D0", Offset = "0x39F22D0", VA = "0x1839F34D0")]
	public static ObjectEnumerator<c> MXYIZGFNVBR<c>(this NativeArray<Entity> a, EntityManager b) where c : class
	{
		return default(ObjectEnumerator<c>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x39F3700", Offset = "0x39F2500", VA = "0x1839F3700")]
	public static NativeArray<TKey> UBOILCMWMRY<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> a, Allocator b, [Out] int c) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default(NativeArray<TKey>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x39F2060", Offset = "0x39F0E60", VA = "0x1839F2060")]
	public static NativeParallelHashMap<TKey, TValue> BRTGCNYFTEQ<TKey, TValue>(this NativeArray<TKey> a, NativeArray<TValue> b, Allocator c) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(NativeParallelHashMap<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x39F2300", Offset = "0x39F1100", VA = "0x1839F2300")]
	public static NativeParallelHashSet<T> FGLUFCTURNM<T>(this NativeArray<T> a, AllocatorManager.AllocatorHandle b) where T : struct, IEquatable<T>
	{
		return default(NativeParallelHashSet<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x39F24C0", Offset = "0x39F12C0", VA = "0x1839F24C0")]
	public static NativeParallelHashSet<T> FGLUFCTURNM<T>(this NativeList<T> a, AllocatorManager.AllocatorHandle b) where T : struct, IEquatable<T>
	{
		return default(NativeParallelHashSet<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x39F1D90", Offset = "0x39F0B90", VA = "0x1839F1D90")]
	public static void Add<T1, T2>(this NativeParallelHashMap<T1, T2> map, NativeArray<T1> keys, NativeArray<T2> values) where T1 : struct, IEquatable<T1> where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x39F3050", Offset = "0x39F1E50", VA = "0x1839F3050")]
	public static void KAKPPNOMYGN<TKey, TValue>(this KeyValue<TKey, TValue> a, [Out] TKey b, [Out] TValue c) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x85A0990", Offset = "0x859F790", VA = "0x1885A0990")]
	public static NativeArray<Entity> XJGNOBCSEPC(this NativeParallelHashMap<Entity, Entity> a, NativeArray<Entity> b, Allocator c)
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class MUPXUODILAN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
	public MUPXUODILAN()
	{
	}
}
namespace _LogRegistration.RecRoom_Foundation_Entities_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85A0A60", Offset = "0x859F860", VA = "0x1885A0A60", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[NativeContainer]
	public struct BufferLookup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Unity.Entities.LookupCache m_Cache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TypeIndex m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int m_InternalCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly byte m_IsReadOnly;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TypeIndex TypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			get
			{
				return default(TypeIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DynamicBuffer this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8591470", Offset = "0x8590270", VA = "0x188591470")]
			get
			{
				return default(DynamicBuffer);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85913A0", Offset = "0x85901A0", VA = "0x1885913A0")]
		internal unsafe BufferLookup(int typeIndex, Unity.Entities.EntityDataAccess* access, bool isReadOnly)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[NativeContainer]
	[NativeContainerSupportsMinMaxWriteRestriction]
	public struct ComponentTypeHandle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal Unity.Entities.LookupCache m_LookupCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal readonly TypeIndex m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal readonly int m_SizeInChunk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		internal uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal readonly byte m_IsReadOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		internal readonly byte m_IsZeroSized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly int m_Length;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8591BA0", Offset = "0x85909A0", VA = "0x188591BA0")]
		internal ComponentTypeHandle(TypeIndex typeIndex, bool isReadOnly, uint globalSystemVersion)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[GenerateTestsForBurstCompatibility]
	public readonly struct ComponentTypeIndex : IEquatable<ComponentTypeIndex>, IComparable<ComponentTypeIndex>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly int typeIndex;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
		public ComponentTypeIndex(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x24D03F0", Offset = "0x24CF1F0", VA = "0x1824D03F0", Slot = "4")]
		public bool Equals(ComponentTypeIndex other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x24D7CC0", Offset = "0x24D6AC0", VA = "0x1824D7CC0", Slot = "5")]
		public int CompareTo(ComponentTypeIndex other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8591C80", Offset = "0x8590A80", VA = "0x188591C80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x15EEEE0", Offset = "0x15EDCE0", VA = "0x1815EEEE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8591D10", Offset = "0x8590B10", VA = "0x188591D10", Slot = "3")]
		[ExcludeFromBurstCompatTesting("String is managed")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8591D80", Offset = "0x8590B80", VA = "0x188591D80")]
		public static implicit operator TypeIndex(ComponentTypeIndex x)
		{
			return default(TypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x21AA350", Offset = "0x21A9150", VA = "0x1821AA350")]
		public static implicit operator ComponentTypeIndex(TypeIndex x)
		{
			return default(ComponentTypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x21AA350", Offset = "0x21A9150", VA = "0x1821AA350")]
		public static implicit operator int(ComponentTypeIndex x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x21AA350", Offset = "0x21A9150", VA = "0x1821AA350")]
		public static implicit operator ComponentTypeIndex(int x)
		{
			return default(ComponentTypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x21AA350", Offset = "0x21A9150", VA = "0x1821AA350")]
		public static implicit operator ComponentTypeIndex(ComponentType type)
		{
			return default(ComponentTypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3737E50", Offset = "0x3736C50", VA = "0x183737E50")]
		public static ComponentTypeIndex From<T>()
		{
			return default(ComponentTypeIndex);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct ComponentTypes32
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public struct Masks
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public uint m_BufferMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public uint m_SystemStateComponentMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public uint m_SharedComponentMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public uint m_ZeroSizedMask;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private FixedList128Bytes<int> m_sorted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Masks m_masks;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public readonly int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x85924F0", Offset = "0x85912F0", VA = "0x1885924F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8592540", Offset = "0x8591340", VA = "0x188592540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8592350", Offset = "0x8591150", VA = "0x188592350")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85923E0", Offset = "0x85911E0", VA = "0x1885923E0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8591D90", Offset = "0x8590B90", VA = "0x188591D90")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8592100", Offset = "0x8590F00", VA = "0x188592100")]
		public void Remove(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85921C0", Offset = "0x8590FC0", VA = "0x1885921C0")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85920B0", Offset = "0x8590EB0", VA = "0x1885920B0")]
		public readonly int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8592020", Offset = "0x8590E20", VA = "0x188592020")]
		public readonly ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8592210", Offset = "0x8591010", VA = "0x188592210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8591DE0", Offset = "0x8590BE0", VA = "0x188591DE0")]
		private void ComputeMasks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[NativeContainer]
	public struct ArchetypeChunkFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ArchetypeChunk this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x85910B0", Offset = "0x858FEB0", VA = "0x1885910B0")]
			get
			{
				return default(ArchetypeChunk);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		internal unsafe ArchetypeChunkFromEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8590F10", Offset = "0x858FD10", VA = "0x188590F10")]
		public EntityInChunk GetEntityInChunk(Entity entity)
		{
			return default(EntityInChunk);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8590DA0", Offset = "0x858FBA0", VA = "0x188590DA0")]
		public ArchetypeChunk GetArchetypeChunkAndIndex(Entity entity, [Out] int index)
		{
			return default(ArchetypeChunk);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8590E80", Offset = "0x858FC80", VA = "0x188590E80")]
		public UnsafeUntypedBufferAccessor GetBufferAccessorAndIndex(Entity entity, DynamicComponentTypeHandle chunkBufferTypeHandle, [Out] int indexInChunk)
		{
			return default(UnsafeUntypedBufferAccessor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8590CB0", Offset = "0x858FAB0", VA = "0x188590CB0")]
		public unsafe bool CopyToEntity(Entity entity, DynamicComponentTypeHandle chunkBufferTypeHandle, void* srcPtr, int srcElementCount, int srcBufferSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8590FC0", Offset = "0x858FDC0", VA = "0x188590FC0")]
		public unsafe bool TryGetReadOnlyDataBufferForEntity(Entity entity, DynamicComponentTypeHandle chunkBufferTypeHandle, [Out] void* ptr, [Out] int elementCount, [Out] int bufferSize)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[NativeContainer]
	public struct ArchetypeFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public EntityArchetype this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8591170", Offset = "0x858FF70", VA = "0x188591170")]
			get
			{
				return default(EntityArchetype);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		internal unsafe ArchetypeFromEntity(Unity.Entities.EntityDataAccess* access)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[NativeContainer]
	public struct ComponentDataFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly int m_TypeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Unity.Entities.LookupCache m_Cache;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int TypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xF7C730", Offset = "0xF7B530", VA = "0x180F7C730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public NativeArray<byte> this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8591850", Offset = "0x8590650", VA = "0x188591850")]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8591970", Offset = "0x8590770", VA = "0x188591970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8591790", Offset = "0x8590590", VA = "0x188591790")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85915F0", Offset = "0x85903F0", VA = "0x1885915F0")]
		public bool HasComponent(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85916A0", Offset = "0x85904A0", VA = "0x1885916A0")]
		public bool TryGetComponent(Entity entity, [Out] NativeArray<byte> componentData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[NativeContainer]
	public struct EntityExistenceLookupByEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		internal unsafe EntityExistenceLookupByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8599E20", Offset = "0x8598C20", VA = "0x188599E20")]
		public bool Exists(Entity entity)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[NativeContainer]
	public struct HasComponentByEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		internal unsafe HasComponentByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x859FEF0", Offset = "0x859ECF0", VA = "0x18859FEF0")]
		public bool HasComponent(Entity entity, int typeIndex)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[NativeContainer]
	public struct SharedComponentIndexFromEntity<T> where T : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly int m_TypeIndex;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x615AEE0", Offset = "0x6159CE0", VA = "0x18615AEE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x615AD30", Offset = "0x6159B30", VA = "0x18615AD30")]
		internal unsafe SharedComponentIndexFromEntity(int typeIndex, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x615AC70", Offset = "0x6159A70", VA = "0x18615AC70")]
		public bool TryGetSharedComponentIndex(Entity entity, [Out] int sharedIndex)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[JobProducerType(typeof(JobChunkTwoQueryExtensions.JobChunkTwoQueryProducer<>))]
	public interface IJobChunkTwoQuery
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class JobChunkTwoQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		internal struct JobChunkTwoQueryWrapper<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public T JobData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Unity.Entities.UnsafeMatchingArchetypePtrList MatchingArchetypes0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Unity.Entities.UnsafeCachedChunkList CachedChunks0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public Unity.Entities.EntityQueryFilter Filter0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Unity.Entities.UnsafeMatchingArchetypePtrList MatchingArchetypes1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public Unity.Entities.UnsafeCachedChunkList CachedChunks1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Unity.Entities.EntityQueryFilter Filter1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public int IsParallel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int QueryHasEnableableComponents0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public int QueryHasEnableableComponents1;
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		internal struct JobChunkTwoQueryProducer<T> where T : struct, IJobChunkTwoQuery
		{
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public delegate void ExecuteJobFunction(JobChunkTwoQueryWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex);

			[Cpp2IlInjected.Token(Token = "0x4000039")]
			internal static readonly SharedStatic<IntPtr> reflectionData;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct DeferredEntityCommandBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private NativeList<byte> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private NativeParallelHashMap<Entity, EntityModification> entityModifications;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private EntityManager entityManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Allocator allocator;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x85984A0", Offset = "0x85972A0", VA = "0x1885984A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85983E0", Offset = "0x85971E0", VA = "0x1885983E0")]
		public DeferredEntityCommandBuffer(EntityManager entityManager, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8597230", Offset = "0x8596030", VA = "0x188597230", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8597710", Offset = "0x8596510", VA = "0x188597710")]
		public void Playback(EntityModification.TrySetPrefabDataType trySetPrefabDataType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x37E3B40", Offset = "0x37E2940", VA = "0x1837E3B40")]
		public bool HasComponent<T>(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85975C0", Offset = "0x85963C0", VA = "0x1885975C0")]
		public bool HasComponent(Entity entity, ComponentType componentType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x37E4120", Offset = "0x37E2F20", VA = "0x1837E4120")]
		public bool TryGetComponent<T>(Entity entity, [Out] T value) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x37E2950", Offset = "0x37E1750", VA = "0x1837E2950")]
		public void AddBuffer<T>(Entity entity, NativeArray<T> array) where T : struct, IBufferElementData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8597F00", Offset = "0x8596D00", VA = "0x188597F00")]
		private void UnsafeAddBuffer(Entity entity, ComponentType componentType, int alignment, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x37E3000", Offset = "0x37E1E00", VA = "0x1837E3000")]
		public void AddComponent<T>(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8596BA0", Offset = "0x85959A0", VA = "0x188596BA0")]
		public void AddComponent(Entity entity, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x37E2F50", Offset = "0x37E1D50", VA = "0x1837E2F50")]
		public void AddComponent<T>(NativeArray<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8596C20", Offset = "0x8595A20", VA = "0x188596C20")]
		public void AddComponent(NativeArray<Entity> entities, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x37E30A0", Offset = "0x37E1EA0", VA = "0x1837E30A0")]
		public void AddOrSetComponent<T>(Entity entity, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8596D90", Offset = "0x8595B90", VA = "0x188596D90")]
		public void AddOrSetComponent(NativeArray<Entity> entities, ComponentType componentType, int align, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8596FC0", Offset = "0x8595DC0", VA = "0x188596FC0")]
		public void AddOrSetComponent(Entity entity, ComponentType componentType, int alignment, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8597FA0", Offset = "0x8596DA0", VA = "0x188597FA0")]
		private void UnsafeAddOrSetComponent(Entity entity, ComponentType componentType, int alignment, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8598170", Offset = "0x8596F70", VA = "0x188598170")]
		private void UnsafeAddOrSetComponent(Entity entity, ComponentType componentType, RecRoom.Foundation.Collections.Range range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x37E3C80", Offset = "0x37E2A80", VA = "0x1837E3C80")]
		public void RemoveComponent<T>(Entity entity) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x37E3D20", Offset = "0x37E2B20", VA = "0x1837E3D20")]
		public void RemoveComponent<T>(NativeArray<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8597BB0", Offset = "0x85969B0", VA = "0x188597BB0")]
		public void RemoveComponent(NativeArray<Entity> entities, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8597D20", Offset = "0x8596B20", VA = "0x188597D20")]
		public void RemoveComponent(Entity entity, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x37E39A0", Offset = "0x37E27A0", VA = "0x1837E39A0")]
		public void AddOrSetSharedComponent<T>(Entity entity, T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8597060", Offset = "0x8595E60", VA = "0x188597060")]
		private void AddOrSetSharedComponent(Entity entity, ComponentType componentType, int alignment, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8597510", Offset = "0x8596310", VA = "0x188597510")]
		private EntityModification GetOrAddModification(Entity entity)
		{
			return default(EntityModification);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[DefaultMember("Item")]
	[NativeContainer]
	[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}")]
	[DebuggerTypeProxy(typeof(DynamicBufferDebugView))]
	public struct DynamicBuffer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		private unsafe Unity.Entities.BufferHeader* m_Buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int m_ElementSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int m_AlignmentInBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int m_InternalCapacity;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x493DB80", Offset = "0x493C980", VA = "0x18493DB80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8598B40", Offset = "0x8597940", VA = "0x188598B40")]
		internal unsafe DynamicBuffer(Unity.Entities.BufferHeader* header, int typeIndex, int internalCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8598750", Offset = "0x8597550", VA = "0x188598750")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckBounds(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8598A10", Offset = "0x8597810", VA = "0x188598A10")]
		public ReadOnlySpan<byte> ElementAt(int index)
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8598AE0", Offset = "0x85978E0", VA = "0x188598AE0")]
		public void ResizeUninitialized(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8598AA0", Offset = "0x85978A0", VA = "0x188598AA0")]
		public void EnsureCapacity(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x493A880", Offset = "0x4939680", VA = "0x18493A880")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x85985D0", Offset = "0x85973D0", VA = "0x1885985D0")]
		public void AddRange(ReadOnlySpan<byte> srcSpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85986C0", Offset = "0x85974C0", VA = "0x1885986C0")]
		public NativeArray<byte> AsNativeArray()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8598820", Offset = "0x8597620", VA = "0x188598820")]
		public void CopyFrom(NativeArray<byte> v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8598960", Offset = "0x8597760", VA = "0x188598960")]
		public void CopyFrom(DynamicBuffer v)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal sealed class DynamicBufferDebugView
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct EntityModification : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate bool TrySetPrefabDataType(EntityManager em, Entity entity, ComponentTypeIndex componentTypeIndex, ReadOnlySpan<byte> data);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private UnsafeParallelHashMap<ComponentTypeIndex, RecRoom.Foundation.Collections.Range> addedComponents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private UnsafeParallelHashSet<ComponentTypeIndex> removedComponents;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x859E100", Offset = "0x859CF00", VA = "0x18859E100")]
		public EntityModification(Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x859DFC0", Offset = "0x859CDC0", VA = "0x18859DFC0")]
		public bool HasComponent(EntityManager em, Entity entity, ComponentType componentType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x859D870", Offset = "0x859C670", VA = "0x18859D870")]
		public void AddOrSetComponent(NativeList<byte> componentsData, ComponentType componentType, int align, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x859D7F0", Offset = "0x859C5F0", VA = "0x18859D7F0")]
		public void AddOrSetComponent(ComponentType componentType, RecRoom.Foundation.Collections.Range range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x859E090", Offset = "0x859CE90", VA = "0x18859E090")]
		public void RemoveComponent(ComponentType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3838C50", Offset = "0x3837A50", VA = "0x183838C50")]
		public bool TryGetComponent<T>(NativeList<byte> componentsData, EntityManager em, Entity entity, [Out] T value) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x859D9A0", Offset = "0x859C7A0", VA = "0x18859D9A0")]
		public void AddOrSetSharedComponent(NativeList<byte> componentsData, ComponentType componentType, int align, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x859DEE0", Offset = "0x859CCE0", VA = "0x18859DEE0")]
		public NativeArray<ComponentTypeIndex> GetAddedComponentTypes(Allocator allocator)
		{
			return default(NativeArray<ComponentTypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x859DF50", Offset = "0x859CD50", VA = "0x18859DF50")]
		public NativeArray<ComponentTypeIndex> GetRemovedComponentTypes(Allocator allocator)
		{
			return default(NativeArray<ComponentTypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x859D9D0", Offset = "0x859C7D0", VA = "0x18859D9D0")]
		public void ApplyAddedComponents(NativeArray<byte> componentsData, EntityManager em, Entity entity, TrySetPrefabDataType trySetPrefabDataType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x859DE80", Offset = "0x859CC80", VA = "0x18859DE80", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x859E7B0", Offset = "0x859D5B0", VA = "0x18859E7B0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, ComponentSystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x859E890", Offset = "0x859D690", VA = "0x18859E890")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x859E990", Offset = "0x859D790", VA = "0x18859E990")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x859EB90", Offset = "0x859D990", VA = "0x18859EB90")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x859EA80", Offset = "0x859D880", VA = "0x18859EA80")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x859EB70", Offset = "0x859D970", VA = "0x18859EB70")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x859EC80", Offset = "0x859DA80", VA = "0x18859EC80")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x859E4D0", Offset = "0x859D2D0", VA = "0x18859E4D0")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x383FCE0", Offset = "0x383EAE0", VA = "0x18383FCE0")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x383D8E0", Offset = "0x383C6E0", VA = "0x18383D8E0")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x383D9B0", Offset = "0x383C7B0", VA = "0x18383D9B0")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x383DFA0", Offset = "0x383CDA0", VA = "0x18383DFA0")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x383E2D0", Offset = "0x383D0D0", VA = "0x18383E2D0")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x383EBB0", Offset = "0x383D9B0", VA = "0x18383EBB0")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4, T5>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x383EEA0", Offset = "0x383DCA0", VA = "0x18383EEA0")]
		public static EntityQueryDesc WithAny<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x383EDC0", Offset = "0x383DBC0", VA = "0x18383EDC0")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x383F510", Offset = "0x383E310", VA = "0x18383F510")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x383F6D0", Offset = "0x383E4D0", VA = "0x18383F6D0")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x383F9B0", Offset = "0x383E7B0", VA = "0x18383F9B0")]
		public static EntityQueryDesc WithNone<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x383C440", Offset = "0x383B240", VA = "0x18383C440")]
		private static ComponentType[] ExpandRO<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x383C4E0", Offset = "0x383B2E0", VA = "0x18383C4E0")]
		private static ComponentType[] ExpandRO<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x383C9C0", Offset = "0x383B7C0", VA = "0x18383C9C0")]
		private static ComponentType[] ExpandRO<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x383CF80", Offset = "0x383BD80", VA = "0x18383CF80")]
		private static ComponentType[] ExpandRO<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x383D730", Offset = "0x383C530", VA = "0x18383D730")]
		private static ComponentType[] ExpandRO<T1, T2, T3, T4, T5>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x859E6E0", Offset = "0x859D4E0", VA = "0x18859E6E0")]
		private static ComponentType[] Combine(ComponentType[] a, ComponentType[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate void EntityQueryBuilderInit(EntityQueryBuilder builder);
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class EntityQueryBuilderExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x859E450", Offset = "0x859D250", VA = "0x18859E450")]
		public static EntityQueryBuilder WithAll(this EntityQueryBuilder desc, ComponentType componentType)
		{
			return default(EntityQueryBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x859E490", Offset = "0x859D290", VA = "0x18859E490")]
		public static EntityQueryBuilder WithNone(this EntityQueryBuilder desc, ComponentType componentType)
		{
			return default(EntityQueryBuilder);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class ArchetypeChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x32B4910", Offset = "0x32B3710", VA = "0x1832B4910")]
		public static ManagedComponentAccessor<T> GetManagedComponentAccessor<T>(this ArchetypeChunk chunk, ComponentTypeHandle<T> typeHandle, EntityQuery query) where T : class
		{
			return default(ManagedComponentAccessor<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class ArchetypeExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class DebugEntityInfoExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8596A30", Offset = "0x8595830", VA = "0x188596A30")]
		public static void DebugLogEntityInfo(this EntityManager entityManager, Entity entity, int maxDepth = 3, string componentSeparator = "\n    ")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8596960", Offset = "0x8595760", VA = "0x188596960")]
		public static string DebugGetEntityInfo(this EntityManager entityManager, Entity entity, int maxDepth = 3, string componentSeparator = "\n    ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8595950", Offset = "0x8594750", VA = "0x188595950")]
		private static void DebugAppendEntityInfo(this EntityManager entityManager, Entity entity, StringBuilder str, int maxDepth, string componentSeparator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8595910", Offset = "0x8594710", VA = "0x188595910")]
		private static void DebugAppendComponentInfo(EntityManager entityManager, Entity entity, ComponentType componentType, StringBuilder str, int maxDepth, string leafPrefix = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8595EB0", Offset = "0x8594CB0", VA = "0x188595EB0")]
		private static void DebugAppendObjectInfo(object obj, int maxDepth, StringBuilder str, string leafPrefix = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x85966A0", Offset = "0x85954A0", VA = "0x1885966A0")]
		public static object DebugGetComponentBoxed(this EntityManager entityManager, Entity entity, ComponentType componentType)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class DynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x37F0100", Offset = "0x37EEF00", VA = "0x1837F0100")]
		public static bool Contains<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x37F0360", Offset = "0x37EF160", VA = "0x1837F0360")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x37F1200", Offset = "0x37F0000", VA = "0x1837F1200")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x37F0DB0", Offset = "0x37EFBB0", VA = "0x1837F0DB0")]
		public static void RemoveAllSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x37F1050", Offset = "0x37EFE50", VA = "0x1837F1050")]
		public static void RemoveSetSwapBack<T>(this DynamicBuffer<T> buffer, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x37F01E0", Offset = "0x37EEFE0", VA = "0x1837F01E0")]
		public static bool Contains<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x37F0B60", Offset = "0x37EF960", VA = "0x1837F0B60")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x37F09F0", Offset = "0x37EF7F0", VA = "0x1837F09F0")]
		public static int IndexOf<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x37F1530", Offset = "0x37F0330", VA = "0x1837F1530")]
		public static bool Remove<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public struct ComponentTypeEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private EntityArchetype archetype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public ComponentType Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x8591B10", Offset = "0x8590910", VA = "0x188591B10")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x8591AF0", Offset = "0x85908F0", VA = "0x188591AF0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public ComponentType this[int i]
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x8591B20", Offset = "0x8590920", VA = "0x188591B20")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x8591AD0", Offset = "0x85908D0", VA = "0x188591AD0")]
			internal ComponentTypeEnumerator(EntityArchetype arch, bool includeEntity = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x12B3B60", Offset = "0x12B2960", VA = "0x1812B3B60")]
			public ComponentTypeEnumerator GetEnumerator()
			{
				return default(ComponentTypeEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8591AA0", Offset = "0x85908A0", VA = "0x188591AA0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public struct AddEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private AddRemoveEnumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public ComponentType Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x8590400", Offset = "0x858F200", VA = "0x188590400")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8590380", Offset = "0x858F180", VA = "0x188590380")]
			internal unsafe AddEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x42DC540", Offset = "0x42DB340", VA = "0x1842DC540")]
			public AddEnumerator GetEnumerator()
			{
				return default(AddEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8590300", Offset = "0x858F100", VA = "0x188590300")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public struct RemoveEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private AddRemoveEnumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public ComponentType Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x8590400", Offset = "0x858F200", VA = "0x188590400")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8590380", Offset = "0x858F180", VA = "0x188590380")]
			internal unsafe RemoveEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x42DC540", Offset = "0x42DB340", VA = "0x1842DC540")]
			public RemoveEnumerator GetEnumerator()
			{
				return default(RemoveEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x85A1E10", Offset = "0x85A0C10", VA = "0x1885A1E10")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public struct AddRemoveEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private unsafe Unity.Entities.ComponentTypeInArchetype* srcTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private unsafe Unity.Entities.ComponentTypeInArchetype* dstTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private int srcLen;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int dstLen;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private ComponentType componentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private bool existsInDstNotInSrc;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public (ComponentType component, bool existsInDstNotInSrc) Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x8590690", Offset = "0x858F490", VA = "0x188590690")]
				get
				{
					return default((ComponentType, bool));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8590640", Offset = "0x858F440", VA = "0x188590640")]
			internal unsafe AddRemoveEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8590520", Offset = "0x858F320", VA = "0x188590520")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8599CF0", Offset = "0x8598AF0", VA = "0x188599CF0")]
		public static EntityArchetype GetInstantiateArchetype(this EntityArchetype archetype)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8599BB0", Offset = "0x85989B0", VA = "0x188599BB0")]
		public static ComponentTypeEnumerator EnumerateComponentTypes(this EntityArchetype archetype, bool includeEntity = false)
		{
			return default(ComponentTypeEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8599BD0", Offset = "0x85989D0", VA = "0x188599BD0")]
		public static Span<int> GetAllTypeIndices(this EntityArchetype archetype)
		{
			return default(Span<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8599CD0", Offset = "0x8598AD0", VA = "0x188599CD0")]
		public static int GetEntityCount(this EntityArchetype archetype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8599C40", Offset = "0x8598A40", VA = "0x188599C40")]
		public static AddEnumerator GetComponentsToAdd(this EntityArchetype src, EntityArchetype dst)
		{
			return default(AddEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8599C40", Offset = "0x8598A40", VA = "0x188599C40")]
		public static RemoveEnumerator GetComponentsToRemove(this EntityArchetype src, EntityArchetype dst)
		{
			return default(RemoveEnumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal static class EntityBatchInChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8599D00", Offset = "0x8598B00", VA = "0x188599D00")]
		public static void CopyTo(this Unity.Entities.EntityBatchInChunk srcBatch, Unity.Entities.EntityBatchInChunk dstBatch, int srcIndexInArchetype, int dstIndexInArchetype, uint globalSystemVersion)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class EntityCommandBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static Log log;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x380EFB0", Offset = "0x380DDB0", VA = "0x18380EFB0")]
		public static void SetComponentData<T>(this EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x380F310", Offset = "0x380E110", VA = "0x18380F310")]
		public static void SetComponentData<T>(this EntityCommandBuffer.ParallelWriter ecb, int sortKey, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class EntityManagerArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8599EB0", Offset = "0x8598CB0", VA = "0x188599EB0")]
		public static EntityArchetype CreateArchetypeWithAdditionalComponents(this EntityManager entityManager, EntityArchetype srcArchetype, NativeArray<int> typeIndices)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x859A2A0", Offset = "0x85990A0", VA = "0x18859A2A0")]
		public static EntityArchetype CreateArchetypeWithModifiedComponents(this EntityManager entityManager, EntityArchetype srcArchetype, NativeArray<int> adds, NativeArray<int> removes)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x859A7A0", Offset = "0x85995A0", VA = "0x18859A7A0")]
		public static EntityArchetype CreateArchetype(this EntityManager entityManager, Span<ComponentType> types, bool addSimulateIfMissing)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x859A9B0", Offset = "0x85997B0", VA = "0x18859A9B0")]
		public static EntityArchetype GetArchetype(this EntityManager entityManager, Entity entity)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x859A8A0", Offset = "0x85996A0", VA = "0x18859A8A0")]
		public static int GetArchetypeCount(this EntityManager entityManager)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class EntityManagerArchetypeFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x859AAD0", Offset = "0x85998D0", VA = "0x18859AAD0")]
		public static ArchetypeFromEntity GetArchetypeFromEntity(this EntityManager entityManager)
		{
			return default(ArchetypeFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x859AA80", Offset = "0x8599880", VA = "0x18859AA80")]
		public static ArchetypeChunkFromEntity GetArchetypeChunkFromEntity(this EntityManager entityManager)
		{
			return default(ArchetypeChunkFromEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class EntityManagerAssertionExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class EntityManagerBufferFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x859AB20", Offset = "0x8599920", VA = "0x18859AB20")]
		public static BufferLookup GetBufferLookup(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(BufferLookup);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class EntityManagerChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x859ABC0", Offset = "0x85999C0", VA = "0x18859ABC0")]
		[ExcludeFromBurstCompatTesting(null)]
		public static void CopyEntitiesFrom(this EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x859AC30", Offset = "0x8599A30", VA = "0x18859AC30")]
		public static NativeArray<ArchetypeChunk> GetChunks(this EntityManager em, NativeArray<Entity> entities, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<ArchetypeChunk>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class EntityManagerComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[BurstCompile]
		private struct SetComponentDataArrayFromArrayJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[Unity.Collections.ReadOnly]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Unity.Collections.ReadOnly]
			public NativeArray<byte> src;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ComponentDataFromEntity dst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public int typeSize;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x85A7700", Offset = "0x85A6500", VA = "0x1885A7700", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[BurstCompile]
		private struct SetComponentDataArrayFromValueJob<T> : IJob where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Unity.Collections.ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[WriteOnly]
			public ComponentLookup<T> dstArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6145EF0", Offset = "0x6144CF0", VA = "0x186145EF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[BurstCompile]
		private struct SetComponentDataArrayFromValueJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Unity.Collections.ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[Unity.Collections.ReadOnly]
			public NativeArray<byte> value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[WriteOnly]
			public ComponentDataFromEntity dstArray;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x85A77D0", Offset = "0x85A65D0", VA = "0x1885A77D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[BurstCompile]
		internal struct SetComponentDataChunkJob<T> : IJobChunk where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public ComponentTypeHandle<T> componentArrayType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x6145F90", Offset = "0x6144D90", VA = "0x186145F90")]
			public void Execute([In] ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6146260", Offset = "0x6145060", VA = "0x186146260", Slot = "4")]
			void IJobChunk.Execute([In] ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x859AE70", Offset = "0x8599C70", VA = "0x18859AE70")]
		public static void CopyComponent(this EntityManager entityManager, Entity dst, Entity src, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x859B340", Offset = "0x859A140", VA = "0x18859B340")]
		public static bool TryCopyComponent(this EntityManager entityManager, Entity dst, Entity src, ComponentType componentType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3834B10", Offset = "0x3833910", VA = "0x183834B10")]
		public static bool TrySetComponentData<T>(this EntityManager entityManager, Entity entity, T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x859B790", Offset = "0x859A590", VA = "0x18859B790")]
		public unsafe static bool TryGetComponentDataRawRW(this EntityManager entityManager, Entity entity, int typeIndex, [Out] void* ptr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x859B640", Offset = "0x859A440", VA = "0x18859B640")]
		public unsafe static bool TryGetComponentDataRawRO(this EntityManager entityManager, Entity entity, int typeIndex, [Out] void* ptr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x381C3B0", Offset = "0x381B1B0", VA = "0x18381C3B0")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3819510", Offset = "0x3818310", VA = "0x183819510")]
		public static T GetComponentDataOrDefault<T>(this EntityManager entityManager, Entity entity, [Optional] T defaultValue) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3819480", Offset = "0x3818280", VA = "0x183819480")]
		public static DynamicBuffer<T> GetBufferROOrDefault<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x381A060", Offset = "0x3818E60", VA = "0x18381A060")]
		public static NativeArray<T> GetComponentDataOrDefault<T>(this EntityManager entityManager, NativeArray<Entity> entities, Allocator allocator, [Optional] T defaultValue) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3833750", Offset = "0x3832550", VA = "0x183833750")]
		public static bool TryGetComponentDataField<TComponent, TValue>(this EntityManager entityManager, Entity entity, Func<TComponent, TValue> func, [Out] TValue value) where TComponent : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x381A6B0", Offset = "0x38194B0", VA = "0x18381A6B0")]
		public static RefRW<T> GetComponentDataRefRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IComponentData
		{
			return default(RefRW<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x859AF80", Offset = "0x8599D80", VA = "0x18859AF80")]
		public static void SetComponentData(this EntityManager entityManager, Entity entity, int typeIndex, NativeArray<byte> src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x859B160", Offset = "0x8599F60", VA = "0x18859B160")]
		public static void SetComponentData(this EntityManager entityManager, ComponentType type, NativeArray<Entity> entities, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x381A7D0", Offset = "0x38195D0", VA = "0x18381A7D0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x381C250", Offset = "0x381B050", VA = "0x18381C250")]
		public static void SetTag<T>(this EntityManager entityManager, Entity entity, bool isTagSet) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x381ACE0", Offset = "0x3819AE0", VA = "0x18381ACE0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x859AD10", Offset = "0x8599B10", VA = "0x18859AD10")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		public static void AssertMatchingSize(int typeIndex, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		public static void AssertIsComponentData(int typeIndex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class EntityManagerComponentDataFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x859B8F0", Offset = "0x859A6F0", VA = "0x18859B8F0")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3835760", Offset = "0x3834560", VA = "0x183835760")]
		public static SharedComponentIndexFromEntity<T> GetSharedComponentIndexFromEntity<T>(this EntityManager entityManager) where T : ISharedComponentData
		{
			return default(SharedComponentIndexFromEntity<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class EntityManagerComponentObjectExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3835C70", Offset = "0x3834A70", VA = "0x183835C70")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3835E90", Offset = "0x3834C90", VA = "0x183835E90")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, [Out] T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x38358A0", Offset = "0x38346A0", VA = "0x1838358A0")]
		public static void AddComponentObject<T>(this EntityManager entityManager, NativeArray<Entity> entities, RentedSpan<T> componentArray) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3835800", Offset = "0x3834600", VA = "0x183835800")]
		public static void AddAndSetComponentObject<T>(this EntityManager entityManager, Entity entity, T value) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x859B9A0", Offset = "0x859A7A0", VA = "0x18859B9A0")]
		public static bool HasComponents(this EntityManager entityManager, Entity entity, ComponentTypeSet requiredComponentTypes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class EntityManagerComponentOrderExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class EntityManagerCreateEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x859BB30", Offset = "0x859A930", VA = "0x18859BB30")]
		public static Entity CopyEntity(this EntityManager entityManager, Entity srcEntity)
		{
			return default(Entity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class EntityManagerDependencyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x859C160", Offset = "0x859AF60", VA = "0x18859C160")]
		public static void CompleteReadAndWriteDependency(this EntityManager entityManager, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3835F60", Offset = "0x3834D60", VA = "0x183835F60")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3836130", Offset = "0x3834F30", VA = "0x183836130")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x859C200", Offset = "0x859B000", VA = "0x18859C200")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, TypeIndex typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x859C380", Offset = "0x859B180", VA = "0x18859C380")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, ReadOnlySpan<TypeIndex> typeIndices)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3836280", Offset = "0x3835080", VA = "0x183836280")]
		public static JobHandle GetReadWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x859C480", Offset = "0x859B280", VA = "0x18859C480")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, TypeIndex typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x859C600", Offset = "0x859B400", VA = "0x18859C600")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, ReadOnlySpan<TypeIndex> typeIndices)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x859BD20", Offset = "0x859AB20", VA = "0x18859BD20")]
		public static JobHandle AddReadDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x859BC00", Offset = "0x859AA00", VA = "0x18859BC00")]
		public static JobHandle AddReadDependency(this EntityManager entityManager, ReadOnlySpan<TypeIndex> typeIndices, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x859BFF0", Offset = "0x859ADF0", VA = "0x18859BFF0")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, TypeIndex typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x859BED0", Offset = "0x859ACD0", VA = "0x18859BED0")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, Span<TypeIndex> typeIndices, JobHandle handle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class EntityManagerDynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x859CB80", Offset = "0x859B980", VA = "0x18859CB80")]
		public static bool TryGetBuffer(this EntityManager entityManager, Entity entity, int typeIndex, [Out] DynamicBuffer buffer, bool isReadOnly = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x859C700", Offset = "0x859B500", VA = "0x18859C700")]
		public static DynamicBuffer GetBufferRO(this EntityManager entityManager, Entity entity, int typeIndex)
		{
			return default(DynamicBuffer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x859C7B0", Offset = "0x859B5B0", VA = "0x18859C7B0")]
		public static DynamicBuffer GetBuffer(this EntityManager entityManager, Entity entity, int typeIndex, bool isReadOnly = false)
		{
			return default(DynamicBuffer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x859C860", Offset = "0x859B660", VA = "0x18859C860")]
		private unsafe static DynamicBuffer GetBuffer(Unity.Entities.EntityDataAccess* access, Entity entity, int typeIndex, bool isReadOnly = false)
		{
			return default(DynamicBuffer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x38368B0", Offset = "0x38356B0", VA = "0x1838368B0")]
		public static bool TryGetBufferAsRW<T>(this EntityManager entityManager, Entity entity, int typeIndex, [Out] DynamicBuffer<T> buffer) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x38362F0", Offset = "0x38350F0", VA = "0x1838362F0")]
		public static DynamicBuffer<T> GetBufferAsRW<T>(this EntityManager entityManager, Entity entity, int typeIndex) where T : struct
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x38369D0", Offset = "0x38357D0", VA = "0x1838369D0")]
		private static bool TryGetBufferAs<T>(this EntityManager entityManager, Entity entity, int typeIndex, bool isReadOnly, [Out] DynamicBuffer<T> buffer) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x38370A0", Offset = "0x3835EA0", VA = "0x1838370A0")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3836E30", Offset = "0x3835C30", VA = "0x183836E30")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3837310", Offset = "0x3836110", VA = "0x183837310")]
		public static bool TryGetBuffer<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer, bool isReadOnly) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x38364F0", Offset = "0x38352F0", VA = "0x1838364F0")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x38366D0", Offset = "0x38354D0", VA = "0x1838366D0")]
		public static DynamicBuffer<T> GetBufferRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class EntityManagerEditorExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class EntityManagerEntityExistenceLookupByEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x859CCD0", Offset = "0x859BAD0", VA = "0x18859CCD0")]
		public static EntityExistenceLookupByEntity GetEntityExistenceLookupByEntity(this EntityManager entityManager)
		{
			return default(EntityExistenceLookupByEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class EntityManagerFilterToExistingEntitiesExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x859D250", Offset = "0x859C050", VA = "0x18859D250")]
		public static bool PartitionExistingEntitiesUnstable(this NativeArray<Entity> liveEntities, EntityManager entityManager, [Out] NativeArray<Entity> deadEntities, bool keepCleanupEntities = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x859CFB0", Offset = "0x859BDB0", VA = "0x18859CFB0")]
		public static bool PartitionExistingEntitiesUnstable(this EntityManager entityManager, NativeArray<Entity> liveEntities, [Out] NativeArray<Entity> deadEntities, bool keepCleanupEntities = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x859CD20", Offset = "0x859BB20", VA = "0x18859CD20")]
		public static bool FilterToExistingEntities(this NativeArray<Entity> entities, EntityManager entityManager, bool keepCleanupEntities = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x859CD50", Offset = "0x859BB50", VA = "0x18859CD50")]
		public static bool FilterToExistingEntities(this EntityManager entityManager, NativeArray<Entity> entities, bool keepCleanupEntities = true)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class EntityManagerHasComponentByEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x859D280", Offset = "0x859C080", VA = "0x18859D280")]
		public static HasComponentByEntity GetHasComponentByEntity(this EntityManager entityManager)
		{
			return default(HasComponentByEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class EntityManagerIntegrityExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class EntityManagerRemoveComponentExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class EntityManagerSharedComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3837B20", Offset = "0x3836920", VA = "0x183837B20")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class ExclusiveEntityTransactionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x38C7140", Offset = "0x38C5F40", VA = "0x1838C7140")]
		[GenerateTestsForBurstCompatibility]
		public static int GetSharedComponentDataIndex<T>(this ExclusiveEntityTransaction transaction, Entity entity) where T : struct, ISharedComponentData
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x38C7230", Offset = "0x38C6030", VA = "0x1838C7230")]
		[GenerateTestsForBurstCompatibility]
		public static bool TryGetBufferRO<T>(this ExclusiveEntityTransaction transaction, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class RREntityRemapUtility
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[BurstCompile]
		private struct RemapChunksFilteredJob : IJobParallelFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[Unity.Collections.ReadOnly]
			public NativeParallelHashMap<Entity, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Unity.Collections.ReadOnly]
			public NativeArray<ArchetypeChunk> chunks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[NativeDisableUnsafePtrRestriction]
			public unsafe Unity.Entities.EntityComponentStore* dstEntityComponentStore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public int chunkHeaderType;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x85A1B00", Offset = "0x85A0900", VA = "0x1885A1B00", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x85A1250", Offset = "0x85A0050", VA = "0x1885A1250")]
		public unsafe static void PatchMatchingEntities(EntityRemapUtility.EntityPatchInfo* scalarPatches, int scalarPatchCount, EntityRemapUtility.BufferEntityPatchInfo* bufferPatches, int bufferPatchCount, byte* chunkBuffer, int entityOffset, int entityCount, NativeParallelHashMap<Entity, Entity> remapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x85A18D0", Offset = "0x85A06D0", VA = "0x1885A18D0")]
		public static Entity RemapMatchingEntity(NativeParallelHashMap<Entity, Entity> map, Entity source)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x85A14F0", Offset = "0x85A02F0", VA = "0x1885A14F0")]
		public static JobHandle RemapAllMatchingEntities(this EntityManager entityManager, NativeParallelHashMap<Entity, Entity> map)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x85A16D0", Offset = "0x85A04D0", VA = "0x1885A16D0")]
		public static JobHandle RemapAllMatchingEntities(this EntityQuery query, NativeParallelHashMap<Entity, Entity> map, EntityManager entityManager, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class EntityQueryArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x859E2C0", Offset = "0x859D0C0", VA = "0x18859E2C0")]
		public static int CalculateArchetypeCount(this EntityQuery query)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x859E1B0", Offset = "0x859CFB0", VA = "0x18859E1B0")]
		private static int CalculateArchetypeCount(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Unity.Entities.EntityQueryFilter filter)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class EntityQueryChangeVersionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x383B4C0", Offset = "0x383A2C0", VA = "0x18383B4C0")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x383BAB0", Offset = "0x383A8B0", VA = "0x18383BAB0")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x383B9D0", Offset = "0x383A7D0", VA = "0x18383B9D0")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3, T4>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x383BB70", Offset = "0x383A970", VA = "0x18383BB70")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3, T4, T5>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x383B430", Offset = "0x383A230", VA = "0x18383B430")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x859EDA0", Offset = "0x859DBA0", VA = "0x18859EDA0")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x859ED50", Offset = "0x859DB50", VA = "0x18859ED50")]
		public static bool IsEmpty(this EntityQuery entityQuery, [Out] int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x383FEB0", Offset = "0x383ECB0", VA = "0x18383FEB0")]
		public static RentedArray<T> ToComponentObjectArray<T>(this EntityQuery query) where T : class
		{
			return default(RentedArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x383FE20", Offset = "0x383EC20", VA = "0x18383FE20")]
		public static ComponentTypeHandle<T> GetComponentTypeHandle<T>(this EntityQuery query, bool isReadOnly)
		{
			return default(ComponentTypeHandle<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x859ECA0", Offset = "0x859DAA0", VA = "0x18859ECA0")]
		internal unsafe static Unity.Entities.EntityDataAccess* GetEntityDataAccess(this EntityQuery query)
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityDataAccess*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x859ECC0", Offset = "0x859DAC0", VA = "0x18859ECC0")]
		public static uint GetGlobalSystemVersion(this EntityQuery query)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class EntityQueryToComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x384F7D0", Offset = "0x384E5D0", VA = "0x18384F7D0")]
		public static NativeArray<T> ToSharedComponentDataArray<T>(this EntityQuery entityQuery, Allocator allocator = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x384E990", Offset = "0x384D790", VA = "0x18384E990")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x859FB70", Offset = "0x859E970", VA = "0x18859FB70")]
		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", CompileTarget = GenerateTestsForBurstCompatibilityAttribute.BurstCompatibleCompileTarget.Editor)]
		public static NativeArray<byte> ToComponentDataArray(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x384F1E0", Offset = "0x384DFE0", VA = "0x18384F1E0")]
		public static NativeListAsync<T> ToComponentDataListAsync<T>(this EntityQuery query, Allocator allocator = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(NativeListAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x859F940", Offset = "0x859E740", VA = "0x18859F940")]
		private static NativeArray<byte> CreateComponentDataArrayRun(AllocatorManager.AllocatorHandle allocator, ComponentTypeHandle typeHandle, int entityCount, EntityQuery entityQuery)
		{
			return default(NativeArray<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class EntityQueryToEntityArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x859FD80", Offset = "0x859EB80", VA = "0x18859FD80")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x859FDD0", Offset = "0x859EBD0", VA = "0x18859FDD0")]
		public static NativeListAsync<Entity> ToEntityListAsync(this EntityQuery query, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeListAsync<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class EntityQueryToEntityArrayFilteredExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal static class LookupCacheExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x85A0B20", Offset = "0x859F920", VA = "0x1885A0B20")]
		public unsafe static int GetIndexInTypeArray(this Unity.Entities.LookupCache lookupCache, Unity.Entities.Archetype* archetype, int typeIndex)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class RRChunkUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x85A0E80", Offset = "0x859FC80", VA = "0x1885A0E80")]
		public unsafe static void GatherBatches(Entity* aEntities, Entity* bEntities, int count, NativeList<(Unity.Entities.EntityBatchInChunk a, Unity.Entities.EntityBatchInChunk b)> batches, Unity.Entities.EntityComponentStore* ecs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x85A0E60", Offset = "0x859FC60", VA = "0x1885A0E60")]
		private static Unity.Entities.EntityBatchInChunk Batch(EntityInChunk prev, EntityInChunk curr)
		{
			return default(Unity.Entities.EntityBatchInChunk);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x85A1230", Offset = "0x85A0030", VA = "0x1885A1230")]
		private static EntityInChunk Next(EntityInChunk prev)
		{
			return default(EntityInChunk);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class UnsafeBitArrayExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct GroupByKey<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<(TKey, NativeArray<TValue>, int, int)>, IEnumerable where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public struct Enumerator : IEnumerator<(TKey, NativeArray<TValue>, int, int)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private GroupByKey<TKey, TValue> grouped;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x4AE2550", Offset = "0x4AE1350", VA = "0x184AE2550", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public (TKey key, NativeArray<TValue> values, int offset, int count) Current
			{
				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x4AE4E40", Offset = "0x4AE3C40", VA = "0x184AE4E40", Slot = "4")]
				get
				{
					return default((TKey, NativeArray<TValue>, int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x4AE4E10", Offset = "0x4AE3C10", VA = "0x184AE4E10")]
			public Enumerator(GroupByKey<TKey, TValue> grouped)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x493D230", Offset = "0x493C030", VA = "0x18493D230", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x4ADFCE0", Offset = "0x4ADEAE0", VA = "0x184ADFCE0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<TKey> uniqueKeys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArray<int> counts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<TValue> valuesGroupedByKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeParallelHashMap<TKey, int> indexByKey;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public readonly bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x51D55D0", Offset = "0x51D43D0", VA = "0x1851D55D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x51D55A0", Offset = "0x51D43A0", VA = "0x1851D55A0")]
		public GroupByKey(NativeArray<TKey> uniqueKeys, NativeArray<int> offsets, NativeArray<int> counts, NativeArray<TValue> valuesGroupedByKey, NativeParallelHashMap<TKey, int> indexByKey)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x51D2F60", Offset = "0x51D1D60", VA = "0x1851D2F60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x51D3260", Offset = "0x51D2060", VA = "0x1851D3260")]
		public readonly NativeArray<TValue> GetValues(int index)
		{
			return default(NativeArray<TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x51D2B40", Offset = "0x51D1940", VA = "0x1851D2B40", Slot = "4")]
		public readonly JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x51D4E50", Offset = "0x51D3C50", VA = "0x1851D4E50")]
		public static GroupByKey<TKey, TValue> Group(NativeArray<TKey> keys, NativeArray<TValue> values, Allocator allocator = Allocator.Temp)
		{
			return default(GroupByKey<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x51D2540", Offset = "0x51D1340", VA = "0x1851D2540")]
		[BurstDiscard]
		private static void CheckLengths(NativeArray<TKey> keys, NativeArray<TValue> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x51D3190", Offset = "0x51D1F90", VA = "0x1851D3190")]
		public readonly Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x51D53F0", Offset = "0x51D41F0", VA = "0x1851D53F0", Slot = "6")]
		private IEnumerator<(TKey, NativeArray<TValue>, int, int)> System.Collections.Generic.IEnumerable<(TKeykey,Unity.Collections.NativeArray<TValue>values,System.Int32offset,System.Int32count)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x51D53F0", Offset = "0x51D41F0", VA = "0x1851D53F0", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface IUTF8BufferElementData : IBufferElementData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct AsyncDispose : IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private JobGroup group;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8591370", Offset = "0x8590170", VA = "0x188591370")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8591290", Offset = "0x8590090", VA = "0x188591290")]
		public AsyncDispose(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8591370", Offset = "0x8590170", VA = "0x188591370")]
		public static implicit operator JobHandle(AsyncDispose set)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x355C9D0", Offset = "0x355B7D0", VA = "0x18355C9D0")]
		public void Add<T>(T disposable) where T : struct, INativeDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x355C300", Offset = "0x355B100", VA = "0x18355C300")]
		public void Add<T>(NativeArrayAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x355C570", Offset = "0x355B370", VA = "0x18355C570")]
		public void Add<T>(NativeArray<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x355C470", Offset = "0x355B270", VA = "0x18355C470")]
		public void Add<T>(NativeListAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x355C380", Offset = "0x355B180", VA = "0x18355C380")]
		public void Add<T>(NativeList<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8591200", Offset = "0x8590000", VA = "0x188591200", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8591240", Offset = "0x8590040", VA = "0x188591240", Slot = "4")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct DisableJobSchedulingScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly int existingWorkerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly bool disableScheduling;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8598530", Offset = "0x8597330", VA = "0x188598530")]
		private DisableJobSchedulingScope(bool disableScheduling)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8598520", Offset = "0x8597320", VA = "0x188598520", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x85984E0", Offset = "0x85972E0", VA = "0x1885984E0")]
		public static DisableJobSchedulingScope DisableSchedulingIfTrue(bool disableScheduling)
		{
			return default(DisableJobSchedulingScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct JobGroup : IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly JobHandle dependsOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private NativeList<JobHandle> handles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int combinedCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private JobHandle combined;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public JobHandle DependsOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x12B3B60", Offset = "0x12B2960", VA = "0x1812B3B60")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x85A08A0", Offset = "0x859F6A0", VA = "0x1885A08A0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x85A07F0", Offset = "0x859F5F0", VA = "0x1885A07F0")]
		public JobGroup(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x85A06C0", Offset = "0x859F4C0", VA = "0x1885A06C0")]
		public void Add(JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8591200", Offset = "0x8590000", VA = "0x188591200", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x85A07A0", Offset = "0x859F5A0", VA = "0x1885A07A0", Slot = "4")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x85A0720", Offset = "0x859F520", VA = "0x1885A0720")]
		private NativeList<JobHandle> GetList()
		{
			return default(NativeList<JobHandle>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[Flags]
	public enum CopyFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		NativeComponents = 1,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		ManagedComponents = 2,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		BufferComponents = 4,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		RemapEntityRefs = 8,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		All = 0xF
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct CopyEntitiesUtility
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[BurstCompile]
		private struct PopulateRemappingArrayJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			[Unity.Collections.ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			[Unity.Collections.ReadOnly]
			public NativeArray<Entity> dstEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x85A0DF0", Offset = "0x859FBF0", VA = "0x1885A0DF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[BurstCompile]
		private struct RemapChunksFilteredJob : IJobParallelFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			[Unity.Collections.ReadOnly]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			[Unity.Collections.ReadOnly]
			public NativeArray<ArchetypeChunk> remapChunks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			[NativeDisableUnsafePtrRestriction]
			public unsafe Unity.Entities.EntityComponentStore* dstEntityComponentStore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public TypeIndex chunkHeaderType;

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x85A1940", Offset = "0x85A0740", VA = "0x1885A1940", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8593C90", Offset = "0x8592A90", VA = "0x188593C90")]
		[ExcludeFromBurstCompatTesting("Uses EntityManager")]
		public static void CopyEntitiesFrom(EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8595240", Offset = "0x8594040", VA = "0x188595240")]
		private static NativeArray<ArchetypeChunk> GetChunksFromEntities(NativeArray<Entity> entities, EntityManager srcEntityManager)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x85947D0", Offset = "0x85935D0", VA = "0x1885947D0")]
		private unsafe static NativeArray<ArchetypeChunk> CopyEntitiesInternal(NativeArray<ArchetypeChunk> srcChunks, Unity.Entities.EntityDataAccess* srcAccess, CopyFlags copyFlags)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x85954F0", Offset = "0x85942F0", VA = "0x1885954F0")]
		internal unsafe static void RemapEntityRefs(NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping, Unity.Entities.EntityDataAccess* dataAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8595670", Offset = "0x8594470", VA = "0x188595670")]
		internal static void RemapEntityRefs(EntityManager entityManager, NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8595350", Offset = "0x8594150", VA = "0x188595350")]
		public static JobHandle RemapAllEntities(EntityManager entityManager, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x75A22F0", Offset = "0x75A10F0", VA = "0x1875A22F0")]
		private static bool HasFlag(CopyFlags copyFlags, CopyFlags testFlag)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8594FD0", Offset = "0x8593DD0", VA = "0x188594FD0")]
		private unsafe static void CreateChunks(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8594E90", Offset = "0x8593C90", VA = "0x188594E90")]
		private unsafe static void CopyNames(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8593610", Offset = "0x8592410", VA = "0x188593610")]
		private static void CloneNativeComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x85939A0", Offset = "0x85927A0", VA = "0x1885939A0")]
		public unsafe static void CloneNativeComponents([In] Unity.Entities.EntityBatchInChunk srcBatch, Unity.Entities.Chunk* dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8592830", Offset = "0x8591630", VA = "0x188592830")]
		private static void ClearBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8592690", Offset = "0x8591490", VA = "0x188592690")]
		private static void ClearBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8592DA0", Offset = "0x8591BA0", VA = "0x188592DA0")]
		private static void CloneBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8592B90", Offset = "0x8591990", VA = "0x188592B90")]
		private static void CloneBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8592A70", Offset = "0x8591870", VA = "0x188592A70")]
		private static void ClearManagedComponents(NativeArray<ArchetypeChunk> chunks, uint globalSystemVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8593540", Offset = "0x8592340", VA = "0x188593540")]
		private static void CloneManagedComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8593070", Offset = "0x8591E70", VA = "0x188593070")]
		private static void CloneEnabledBits(NativeArray<ArchetypeChunk> srcArchetypeChunks, NativeArray<ArchetypeChunk> dstArchetypeChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8593340", Offset = "0x8592140", VA = "0x188593340")]
		private static void CloneEnabledBits(ArchetypeChunk srcArchetypeChunk, ArchetypeChunk dstArchetypeChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8595100", Offset = "0x8593F00", VA = "0x188595100")]
		private static NativeArray<Entity> CreateEntityArray(NativeArray<ArchetypeChunk> chunks, Allocator allocator, int entityCount)
		{
			return default(NativeArray<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[GenerateTestsForBurstCompatibility]
	public struct EntityQueryInJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe Unity.Entities.EntityQueryImpl* __impl;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x859F770", Offset = "0x859E570", VA = "0x18859F770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IsEmptyIgnoreFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x859F720", Offset = "0x859E520", VA = "0x18859F720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x859EDE0", Offset = "0x859DBE0", VA = "0x18859EDE0")]
		public static implicit operator EntityQueryInJob(EntityQuery query)
		{
			return default(EntityQueryInJob);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x859F6B0", Offset = "0x859E4B0", VA = "0x18859F6B0")]
		public EntityQueryInJob(EntityQuery query)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x859F040", Offset = "0x859DE40", VA = "0x18859F040")]
		public int CalculateEntityCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x859F130", Offset = "0x859DF30", VA = "0x18859F130")]
		public bool HasFilter()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x859F180", Offset = "0x859DF80", VA = "0x18859F180")]
		public NativeArray<ArchetypeChunk> ToArchetypeChunkArray(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x859F3D0", Offset = "0x859E1D0", VA = "0x18859F3D0")]
		[GenerateTestsForBurstCompatibility]
		public NativeArray<Entity> ToEntityArray(EntityTypeHandle entityType, Allocator allocator = Allocator.Temp)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x384CEA0", Offset = "0x384BCA0", VA = "0x18384CEA0")]
		[GenerateTestsForBurstCompatibility]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle typeHandle, Allocator allocator = Allocator.Temp) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x384CA60", Offset = "0x384B860", VA = "0x18384CA60")]
		[GenerateTestsForBurstCompatibility]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle<T> typeHandle, Allocator allocator = Allocator.Temp) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
		internal unsafe Unity.Entities.EntityQueryImpl* _GetImpl()
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityQueryImpl*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x859EE50", Offset = "0x859DC50", VA = "0x18859EE50")]
		private void CalculateChunkAndEntityCount([Out] int entityCount, [Out] int chunkCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x859EF60", Offset = "0x859DD60", VA = "0x18859EF60")]
		public int CalculateChunkCountWithoutFiltering()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class EntityQueryInJobExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x859EDE0", Offset = "0x859DBE0", VA = "0x18859EDE0")]
		public static EntityQueryInJob UseInJob(this EntityQuery query)
		{
			return default(EntityQueryInJob);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public interface IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Execute([In] ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, [In] v128 chunkEnabledMask);
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class IQueryInJobEntityBatchExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x39957D0", Offset = "0x39945D0", VA = "0x1839957D0")]
		public static void Run<T>(this T operation, EntityQueryInJob query) where T : struct, IQueryInJobEntityBatch
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x39957D0", Offset = "0x39945D0", VA = "0x1839957D0")]
		public static void RunRef<T>(this T operation, EntityQueryInJob query) where T : struct, IQueryInJobEntityBatch
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3994A20", Offset = "0x3993820", VA = "0x183994A20")]
		[SkipLocalsInit]
		private static void RunInternal<T>(this T operation, EntityQueryInJob query) where T : struct, IQueryInJobEntityBatch
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[BurstCompile]
	internal struct DummyQueryInJobEntityBatch : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8598570", Offset = "0x8597370", VA = "0x188598570")]
		public void Execute([In] ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, [In] v128 chunkEnabledMask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x85985B0", Offset = "0x85973B0", VA = "0x1885985B0", Slot = "4")]
		void IQueryInJobEntityBatch.Execute([In] ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, [In] v128 chunkEnabledMask)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	internal static class DummyQueryInJobEntityBatchScheduler
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public static class ListExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class MemoryUtils
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public readonly struct NativeMultiHashMapAsync<TKey, TValue> : IDisposable where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly NativeParallelMultiHashMap<TKey, TValue> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x5BFA210", Offset = "0x5BF9010", VA = "0x185BFA210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x508CB50", Offset = "0x508B950", VA = "0x18508CB50")]
		public NativeMultiHashMapAsync(NativeParallelMultiHashMap<TKey, TValue> map, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5BFA040", Offset = "0x5BF8E40", VA = "0x185BFA040")]
		public NativeParallelMultiHashMap<TKey, TValue> Complete()
		{
			return default(NativeParallelMultiHashMap<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5BFA080", Offset = "0x5BF8E80", VA = "0x185BFA080", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct NativeResultAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5B45640", Offset = "0x5B44440", VA = "0x185B45640", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct RemapEntitiesParallelForBatchJob : IJobParallelForBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> src;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public NativeArray<Entity> dst;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x85A1DA0", Offset = "0x85A0BA0", VA = "0x1885A1DA0", Slot = "4")]
		public void Execute(int startIndex, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[BurstCompile]
	public struct RemapEntitiesInPlaceJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Unity.Collections.ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemappingRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public NativeArray<Entity> entitiesRW;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x85A1D40", Offset = "0x85A0B40", VA = "0x1885A1D40", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class StructUtility
	{
	}
}
namespace Unity.Entities.Scene
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class EntityQuerySceneExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public struct QueryResetFilterScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private EntityQuery query;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x151F1E0", Offset = "0x151DFE0", VA = "0x18151F1E0")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x85A0E50", Offset = "0x859FC50", VA = "0x1885A0E50", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x859F790", Offset = "0x859E590", VA = "0x18859F790")]
		public static void DestroyEntitiesInScene(this EntityQuery query, SceneTag scene, EntityManager entityManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x859F8B0", Offset = "0x859E6B0", VA = "0x18859F8B0")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}
	}
}
namespace Unity.Entities.LinkedEntityGroupExtensions
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public static class EntityManagerLinkedEntityGroupExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x859D4F0", Offset = "0x859C2F0", VA = "0x18859D4F0")]
		public static bool TryGetChildEntitySubArrayRO(this EntityManager entityManager, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x859D740", Offset = "0x859C540", VA = "0x18859D740")]
		public static bool TryGetChildEntitySubArray(this BufferLookup<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x859D610", Offset = "0x859C410", VA = "0x18859D610")]
		public static bool TryGetChildEntitySubArray([In] this DynamicBuffer<LinkedEntityGroup> buffer, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x859D3A0", Offset = "0x859C1A0", VA = "0x18859D3A0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x859D2D0", Offset = "0x859C0D0", VA = "0x18859D2D0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferLookup<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x859D4C0", Offset = "0x859C2C0", VA = "0x18859D4C0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this DynamicBuffer<LinkedEntityGroup> buffer)
		{
			return default(NativeArray<Entity>);
		}
	}
}
namespace Unity.Entities.Serialization
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal struct StableArchetypeCompareV73 : IComparer<IntPtr>
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x85A79A0", Offset = "0x85A67A0", VA = "0x1885A79A0", Slot = "4")]
		public int Compare(IntPtr x, IntPtr y)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[GenerateBurstMonoInterop("SerializeUtilityV73")]
	[BurstCompile]
	internal struct SerializeUtilityInteropV73
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate int AllocAndQueueReadChunkCommands_00000275$PostfixBurstDelegate(long readOffset, int totalChunkCount, UnsafeList<SerializeUtilityV73.MegaChunkInfo>* megaChunkInfo, UnsafeList<ReadCommand>* readCommands);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		internal static class AllocAndQueueReadChunkCommands_00000275$BurstDirectCall
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private static IntPtr Pointer;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x85906F0", Offset = "0x858F4F0", VA = "0x1885906F0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(IntPtr P_0)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x8590860", Offset = "0x858F660", VA = "0x188590860")]
			private static IntPtr GetFunctionPointer()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x85909C0", Offset = "0x858F7C0", VA = "0x1885909C0")]
			public unsafe static int Invoke(long readOffset, int totalChunkCount, UnsafeList<SerializeUtilityV73.MegaChunkInfo>* megaChunkInfo, UnsafeList<ReadCommand>* readCommands)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void AddExistingChunk_00000276$PostfixBurstDelegate(Unity.Entities.Chunk* chunk, int* sharedComponentIndices, byte* enabledBitsValuesForChunk, int* perComponentDisabledBitCount);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		internal static class AddExistingChunk_00000276$BurstDirectCall
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void ImportChunks_00000277$PostfixBurstDelegate(SerializeUtilityV73.WorldDeserializationStatus* status, BurstableMemoryBinaryReader bufferReader, UnsafeList<EntityArchetype>* archetypes, int* sharedComponentArray, int numSharedComponents, int* sharedComponentRemap, UnsafeList<ArchetypeChunk>* blobAssetRefChunks, byte* componentEnabledBits, int* enabledBitsHierarchicalData, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		internal static class ImportChunks_00000277$BurstDirectCall
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private static IntPtr Pointer;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x859FFA0", Offset = "0x859EDA0", VA = "0x18859FFA0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(IntPtr P_0)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x85A0120", Offset = "0x859EF20", VA = "0x1885A0120")]
			private static IntPtr GetFunctionPointer()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x85A02A0", Offset = "0x859F0A0", VA = "0x1885A02A0")]
			public unsafe static void Invoke(SerializeUtilityV73.WorldDeserializationStatus* status, BurstableMemoryBinaryReader bufferReader, UnsafeList<EntityArchetype>* archetypes, int* sharedComponentArray, int numSharedComponents, int* sharedComponentRemap, UnsafeList<ArchetypeChunk>* blobAssetRefChunks, byte* componentEnabledBits, int* enabledBitsHierarchicalData, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x85A2000", Offset = "0x85A0E00", VA = "0x1885A2000")]
		[BurstMonoInteropMethod(false, MakePublic = false)]
		internal unsafe static void AllocateConsecutiveEntitiesForLoading(Unity.Entities.EntityComponentStore* store, int entityCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x85A1FF0", Offset = "0x85A0DF0", VA = "0x1885A1FF0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(Unity.Entities.Serialization.AllocAndQueueReadChunkCommands_00000275$PostfixBurstDelegate))]
		internal unsafe static int AllocAndQueueReadChunkCommands(long readOffset, int totalChunkCount, UnsafeList<SerializeUtilityV73.MegaChunkInfo>* megaChunkInfo, UnsafeList<ReadCommand>* readCommands)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x85A2E50", Offset = "0x85A1C50", VA = "0x1885A2E50")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(Unity.Entities.Serialization.ImportChunks_00000277$PostfixBurstDelegate))]
		internal unsafe static void ImportChunks(SerializeUtilityV73.WorldDeserializationStatus* status, BurstableMemoryBinaryReader bufferReader, UnsafeList<EntityArchetype>* archetypes, int* sharedComponentArray, int numSharedComponents, int* sharedComponentRemap, UnsafeList<ArchetypeChunk>* blobAssetRefChunks, byte* componentEnabledBits, int* enabledBitsHierarchicalData, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x85A3A30", Offset = "0x85A2830", VA = "0x1885A3A30")]
		private unsafe static void ProcessChunkWithGuaranteedSupportedCapacity(UnsafeList<ArchetypeChunk>* blobAssetRefChunks, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities, Unity.Entities.Chunk* chunk, int totalBlobAssetSize, Unity.Entities.Archetype* archetype, void* blobAssetBuffer, int* remappedSharedComponentValues, byte* enabledBitsForChunk, int* enabledBitsHierarchicalDataForChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x85A3D30", Offset = "0x85A2B30", VA = "0x1885A3D30")]
		private unsafe static void ProcessChunkWithPotentialExcessCapacity(UnsafeList<ArchetypeChunk>* blobAssetRefChunks, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities, Unity.Entities.Chunk* chunk, int totalBlobAssetSize, Unity.Entities.Archetype* archetype, void* blobAssetBuffer, int* remapedSharedComponentValues, byte* enabledBitsForChunk, int* enabledBitsHierarchicalDataForChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x85A3260", Offset = "0x85A2060", VA = "0x1885A3260")]
		private unsafe static void PatchChunkForCapacityChange(Unity.Entities.Chunk* chunk, Unity.Entities.Archetype* archetype, Span<int> oldLayoutOffsets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x85A2EC0", Offset = "0x85A1CC0", VA = "0x1885A2EC0")]
		private unsafe static void MoveExcessDataToNewChunks(UnsafeList<ArchetypeChunk>* blobAssetRefChunks, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities, Unity.Entities.Chunk* existingChunk, int totalBlobAssetSize, Unity.Entities.Archetype* archetype, void* blobAssetBuffer, int* remappedSharedComponentValues, byte* existingEnabledBitsForChunk, int* existingEnabledBitsHierarchicalDataForChunk, Span<int> oldLayoutOffsets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x85A2060", Offset = "0x85A0E60", VA = "0x1885A2060")]
		private unsafe static void ExtractOneAdditionalChunk(UnsafeList<ArchetypeChunk>* blobAssetRefChunks, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities, Unity.Entities.Chunk* oldChunk, int totalBlobAssetSize, Unity.Entities.Archetype* archetype, void* blobAssetBuffer, int* remappedSharedComponentValues, byte* oldEnabledBitsForChunk, int* oldEnabledHierarchicalDataForChunk, Span<int> oldLayoutOffsets, int thisChunkIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x85A4250", Offset = "0x85A3050", VA = "0x1885A4250")]
		private unsafe static void RemapAllEnabledBitsForChunk(byte* oldEnabledBitsForChunk, Unity.Entities.Archetype* archetype, byte* newChunkEnabledComponentData, int* newChunkEnabledHierarchicalData, int chunkIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x85A4410", Offset = "0x85A3210", VA = "0x1885A4410")]
		private unsafe static void RemapEnabledBitsFromOldToNew(byte* oldEnabledBitsForChunk, int thisChunkIndex, int indexInArchetype, int typeMemoryOrderIndex, byte* newChunkEnabledComponentData, int* newChunkEnabledHierarchicalData, int newChunkCapacity, int oldChunkCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x85A28B0", Offset = "0x85A16B0", VA = "0x1885A28B0")]
		private unsafe static int GetOldLayoutCapacity(Unity.Entities.Archetype* archetype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x85A38F0", Offset = "0x85A26F0", VA = "0x1885A38F0")]
		private unsafe static void PopulateOldOffsets(Unity.Entities.Archetype* archetype, Span<int> offsets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x85A4500", Offset = "0x85A3300", VA = "0x1885A4500")]
		private unsafe static void RemapSharedComponentIndices(int* destValues, Unity.Entities.Archetype* archetype, int* remappedIndices, int* sourceValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x85A3340", Offset = "0x85A2140", VA = "0x1885A3340")]
		private unsafe static void PatchChunkForMemoryOrderChanges(Unity.Entities.Archetype* archetype, Unity.Entities.Chunk* chunk, byte* temp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x85A45B0", Offset = "0x85A33B0", VA = "0x1885A45B0")]
		private static int RemapToOldTypeFlags(int srcTypeFlags)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x85A2760", Offset = "0x85A1560", VA = "0x1885A2760")]
		private static void GenerateOldMemoryOrdering(ReadOnlySpan<int> oldFormatTypeFlags, ReadOnlySpan<ulong> srcMemoryOrderings, Span<int> oldMemoryOrderToIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3E42890", Offset = "0x3E41690", VA = "0x183E42890")]
		private unsafe static byte* OffsetFromPointer(void* ptr, int offset)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x85A2FE0", Offset = "0x85A1DE0", VA = "0x1885A2FE0")]
		private unsafe static void PatchBlobAssetsInChunkAfterLoad(Unity.Entities.Chunk* chunk, byte* allBlobAssetData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x85A1E90", Offset = "0x85A0C90", VA = "0x1885A1E90")]
		[BurstCompile]
		public unsafe static int AllocAndQueueReadChunkCommands$BurstManaged(long readOffset, int totalChunkCount, UnsafeList<SerializeUtilityV73.MegaChunkInfo>* megaChunkInfo, UnsafeList<ReadCommand>* readCommands)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x85A2930", Offset = "0x85A1730", VA = "0x1885A2930")]
		[BurstCompile]
		public unsafe static void ImportChunks$BurstManaged(SerializeUtilityV73.WorldDeserializationStatus* status, BurstableMemoryBinaryReader bufferReader, UnsafeList<EntityArchetype>* archetypes, int* sharedComponentArray, int numSharedComponents, int* sharedComponentRemap, UnsafeList<ArchetypeChunk>* blobAssetRefChunks, byte* componentEnabledBits, int* enabledBitsHierarchicalData, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public static class SerializeUtilityV73
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		internal struct Settings
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			internal static readonly Settings Default;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			internal bool SerializeComponentTypeNames;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			internal Entity PrefabRoot;
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private class ManagedObjectWriterAdapter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		private class ManagedObjectReaderAdapter : IBinaryAdapter<Entity>, IBinaryAdapter, IBinaryAdapter<Unity.Entities.BlobAssetReferenceData>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private unsafe readonly byte* m_BlobAssetBatch;

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x735B5F0", Offset = "0x735A3F0", VA = "0x18735B5F0")]
			public unsafe ManagedObjectReaderAdapter(byte* blobAssetBatch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x85A0D20", Offset = "0x859FB20", VA = "0x1885A0D20", Slot = "4")]
			void IBinaryAdapter<Entity>.Serialize([In] BinarySerializationContext<Entity> context, Entity value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x85A0C30", Offset = "0x859FA30", VA = "0x1885A0C30", Slot = "6")]
			void IBinaryAdapter<Unity.Entities.BlobAssetReferenceData>.Serialize([In] BinarySerializationContext<Unity.Entities.BlobAssetReferenceData> context, Unity.Entities.BlobAssetReferenceData value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x85A0C80", Offset = "0x859FA80", VA = "0x1885A0C80", Slot = "5")]
			Entity IBinaryAdapter<Entity>.Deserialize([In] BinaryDeserializationContext<Entity> context)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x85A0BA0", Offset = "0x859F9A0", VA = "0x1885A0BA0", Slot = "7")]
			Unity.Entities.BlobAssetReferenceData IBinaryAdapter<Unity.Entities.BlobAssetReferenceData>.Deserialize([In] BinaryDeserializationContext<Unity.Entities.BlobAssetReferenceData> context)
			{
				return default(Unity.Entities.BlobAssetReferenceData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007A")]
		internal struct BufferPatchRecord
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public int ChunkOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int AllocSizeBytes;
		}

		[Cpp2IlInjected.Token(Token = "0x200007B")]
		internal struct BlobAssetRefPatchRecord
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public int ChunkOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public int BlobDataOffset;
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		internal struct SharedComponentRecord
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public ulong StableTypeHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int ComponentSize;
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		internal struct MegaChunkInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public unsafe byte* MegaChunkAddress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public int MegaChunkSize;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2AD1130", Offset = "0x2ACFF30", VA = "0x182AD1130")]
			public unsafe MegaChunkInfo(byte* chunks, int size)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		internal struct WorldDeserializationStatus
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			internal UnsafeList<MegaChunkInfo> MegaChunkInfoList;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public Unity.Entities.Serialization.DotsSerializationReader.NodeHandle.PrefetchState ArchetypePrefetchState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			[NativeDisableUnsafePtrRestriction]
			public unsafe void* BlobAssetBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public int BlobAssetSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public Unity.Entities.Serialization.DotsSerializationReader.NodeHandle.PrefetchState SharedComponentPrefetchState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public Unity.Entities.Serialization.DotsSerializationReader.NodeHandle.PrefetchState EnabledBitsPrefetchState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public Unity.Entities.Serialization.DotsSerializationReader.NodeHandle.PrefetchState BufferElementPrefetchState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Unity.Entities.Serialization.DotsSerializationReader.NodeHandle.PrefetchState PrefabPrefetchState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public int TotalChunkCount;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x85A7D60", Offset = "0x85A6B60", VA = "0x1885A7D60")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007F")]
		internal struct WorldDeserializationResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			internal Entity PrefabRoot;
		}

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal static Hash128 WorldFileType;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		internal static Hash128 WorldNodeType;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		internal static Hash128 DebugSectionNodeType;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		internal static Hash128 TypesNameStringTableNodeType;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal static Hash128 TypesNameNodeType;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal static Hash128 ArchetypesNodeType;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		internal static Hash128 SharedAndManagedComponentsNodeType;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		internal static Hash128 EnabledBitsNodeType;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		internal static Hash128 BlobAssetsNodeType;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		internal static Hash128 ChunksNodeType;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		internal static Hash128 BufferDataNodeType;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal static Hash128 PrefabNodeType;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x85A66D0", Offset = "0x85A54D0", VA = "0x1885A66D0")]
		private static UnsafeList<EntityArchetype> ReadArchetypes(BinaryReader reader, NativeArray<TypeIndex> types, ExclusiveEntityTransaction entityManager, [Out] int totalEntityCount)
		{
			return default(UnsafeList<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x85A6C50", Offset = "0x85A5A50", VA = "0x1885A6C50")]
		private static NativeArray<TypeIndex> ReadTypeArray(BinaryReader reader, Unity.Entities.Serialization.DotsSerializationReader dotsReader)
		{
			return default(NativeArray<TypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F30", Offset = "0x85A4D30", VA = "0x1885A5F30")]
		private unsafe static void FillReadCommands(Unity.Entities.Serialization.DotsSerializationReader dotsReader, UnsafeList<ReadCommand>* readCommands, [Out] WorldDeserializationStatus status)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x85A4670", Offset = "0x85A3470", VA = "0x1885A4670")]
		internal static ReadHandle BeginDeserializeWorld(string serializationFilePathName, Unity.Entities.Serialization.DotsSerializationReader dotsReader, [Out] WorldDeserializationStatus status, [Out] UnsafeList<ReadCommand> readCommands)
		{
			return default(ReadHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x85A4F60", Offset = "0x85A3D60", VA = "0x1885A4F60")]
		internal static void EndDeserializeWorld(ExclusiveEntityTransaction manager, Unity.Entities.Serialization.DotsSerializationReader dotsReader, WorldDeserializationStatus status, [Out] WorldDeserializationResult deserializationResult, [Optional] object[] unityObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x85A4ED0", Offset = "0x85A3CD0", VA = "0x1885A4ED0")]
		public static void DeserializeWorld(ExclusiveEntityTransaction manager, BinaryReader reader, [Optional] object[] unityObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x85A47B0", Offset = "0x85A35B0", VA = "0x1885A47B0")]
		internal static void DeserializeWorld(ExclusiveEntityTransaction manager, BinaryReader reader, [Out] WorldDeserializationResult deserializationResult, [Optional] object[] unityObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x85A6AE0", Offset = "0x85A58E0", VA = "0x1885A6AE0")]
		private static void ReadSharedComponents(ExclusiveEntityTransaction manager, Unity.Entities.Serialization.ManagedObjectBinaryReader managedDataReader, NativeArray<int> sharedComponentRemap, NativeArray<SharedComponentRecord> sharedComponentRecordArray)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x85A69A0", Offset = "0x85A57A0", VA = "0x1885A69A0")]
		private static int ReadSharedComponentMetadata(BinaryReader reader, [Out] NativeArray<int> sharedComponentArrays, [Out] NativeArray<SharedComponentRecord> sharedComponentRecordArray)
		{
			return default(int);
		}
	}
}
namespace Unity.Entities.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct DynamicComponentTypeList : IEnumerable<ComponentType>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private ComponentTypes32 types;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private List<TypeIndex> componentTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private bool isDirty;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8599A80", Offset = "0x8598880", VA = "0x188599A80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IEnumerable<ComponentType> ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8599940", Offset = "0x8598740", VA = "0x188599940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x85992E0", Offset = "0x85980E0", VA = "0x1885992E0")]
		public TypeIndex GetTypeIndex(int index)
		{
			return default(TypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8599220", Offset = "0x8598020", VA = "0x188599220")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8599610", Offset = "0x8598410", VA = "0x188599610")]
		public DynamicComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x85996F0", Offset = "0x85984F0", VA = "0x1885996F0")]
		public DynamicComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8598B90", Offset = "0x8597990", VA = "0x188598B90")]
		public void Add(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8599380", Offset = "0x8598180", VA = "0x188599380")]
		public void Remove(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8598DD0", Offset = "0x8597BD0", VA = "0x188598DD0")]
		private void DistinctSort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8599B10", Offset = "0x8598910", VA = "0x188599B10")]
		public static DynamicComponentTypeList operator -(DynamicComponentTypeList a, DynamicComponentTypeList b)
		{
			return default(DynamicComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x85993F0", Offset = "0x85981F0", VA = "0x1885993F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8599290", Offset = "0x8598090", VA = "0x188599290", Slot = "4")]
		public IEnumerator<ComponentType> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8599290", Offset = "0x8598090", VA = "0x188599290", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__4119401939
{
	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x85A7E00", Offset = "0x85A6C00", VA = "0x1885A7E00")]
	public static void HLHXEDCBNRB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x85A7DF0", Offset = "0x85A6BF0", VA = "0x1885A7DF0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x85A7B00", Offset = "0x85A6900", VA = "0x1885A7B00")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
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

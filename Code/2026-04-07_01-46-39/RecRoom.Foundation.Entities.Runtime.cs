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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x99CCAD0", Offset = "0x99CBAD0", VA = "0x1899CCAD0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OTVALSGBJBQ
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
		public T WRHCKBISNLF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7465060", Offset = "0x7464060", VA = "0x187465060")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7465250", Offset = "0x7464250", VA = "0x187465250")]
		public ObjectEnumerator(NativeArray<Entity> entities, EntityManager entityManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7465240", Offset = "0x7464240", VA = "0x187465240")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5369420", Offset = "0x5368420", VA = "0x185369420")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D68BA0", Offset = "0x3D67BA0", VA = "0x183D68BA0")]
	public static ObjectEnumerator<b> CGHJRROIDFM<b>(this NativeList<Entity> a, EntityManager b) where b : class
	{
		return default(ObjectEnumerator<b>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D68C90", Offset = "0x3D67C90", VA = "0x183D68C90")]
	public static ObjectEnumerator<c> CGHJRROIDFM<c>(this NativeArray<Entity> a, EntityManager b) where c : class
	{
		return default(ObjectEnumerator<c>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D69F30", Offset = "0x3D68F30", VA = "0x183D69F30")]
	public static NativeArray<TKey> UVZLYNOLIIZ<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> a, Allocator b, [Out] int c) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default(NativeArray<TKey>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D69760", Offset = "0x3D68760", VA = "0x183D69760")]
	public static NativeParallelHashMap<TKey, TValue> NDZYPBOHIZB<TKey, TValue>(this NativeArray<TKey> a, NativeArray<TValue> b, Allocator c) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(NativeParallelHashMap<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D685C0", Offset = "0x3D675C0", VA = "0x183D685C0")]
	public static NativeParallelHashSet<T> AZUDKASWWCV<T>(this NativeArray<T> a, AllocatorManager.AllocatorHandle b) where T : struct, IEquatable<T>
	{
		return default(NativeParallelHashSet<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D68780", Offset = "0x3D67780", VA = "0x183D68780")]
	public static NativeParallelHashSet<T> AZUDKASWWCV<T>(this NativeList<T> a, AllocatorManager.AllocatorHandle b) where T : struct, IEquatable<T>
	{
		return default(NativeParallelHashSet<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D688D0", Offset = "0x3D678D0", VA = "0x183D688D0")]
	public static void Add<T1, T2>(this NativeParallelHashMap<T1, T2> map, NativeArray<T1> keys, NativeArray<T2> values) where T1 : struct, IEquatable<T1> where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D69A00", Offset = "0x3D68A00", VA = "0x183D69A00")]
	public static void URCAFVCDNTE<TKey, TValue>(this KeyValue<TKey, TValue> a, [Out] TKey b, [Out] TValue c) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x99CCB50", Offset = "0x99CBB50", VA = "0x1899CCB50")]
	public static NativeArray<Entity> GRLNHIHQISP(this NativeParallelHashMap<Entity, Entity> a, NativeArray<Entity> b, Allocator c)
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UFSCIDMSTJW
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
	[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
	public UFSCIDMSTJW()
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
		[Cpp2IlInjected.Address(RVA = "0x99CC7C0", Offset = "0x99CB7C0", VA = "0x1899CC7C0", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
			get
			{
				return default(TypeIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DynamicBuffer this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x99BD250", Offset = "0x99BC250", VA = "0x1899BD250")]
			get
			{
				return default(DynamicBuffer);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99BD180", Offset = "0x99BC180", VA = "0x1899BD180")]
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
		[Cpp2IlInjected.Address(RVA = "0x99BD980", Offset = "0x99BC980", VA = "0x1899BD980")]
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
		[Cpp2IlInjected.Address(RVA = "0x15C1E10", Offset = "0x15C0E10", VA = "0x1815C1E10")]
		public ComponentTypeIndex(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2388AE0", Offset = "0x2387AE0", VA = "0x182388AE0", Slot = "4")]
		public bool Equals(ComponentTypeIndex other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2394CB0", Offset = "0x2393CB0", VA = "0x182394CB0", Slot = "5")]
		public int CompareTo(ComponentTypeIndex other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99BDA60", Offset = "0x99BCA60", VA = "0x1899BDA60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x161C860", Offset = "0x161B860", VA = "0x18161C860", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99BDAF0", Offset = "0x99BCAF0", VA = "0x1899BDAF0", Slot = "3")]
		[ExcludeFromBurstCompatTesting("String is managed")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99BDB60", Offset = "0x99BCB60", VA = "0x1899BDB60")]
		public static implicit operator TypeIndex(ComponentTypeIndex x)
		{
			return default(TypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8F40", Offset = "0x1CC7F40", VA = "0x181CC8F40")]
		public static implicit operator ComponentTypeIndex(TypeIndex x)
		{
			return default(ComponentTypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8F40", Offset = "0x1CC7F40", VA = "0x181CC8F40")]
		public static implicit operator int(ComponentTypeIndex x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8F40", Offset = "0x1CC7F40", VA = "0x181CC8F40")]
		public static implicit operator ComponentTypeIndex(int x)
		{
			return default(ComponentTypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8F40", Offset = "0x1CC7F40", VA = "0x181CC8F40")]
		public static implicit operator ComponentTypeIndex(ComponentType type)
		{
			return default(ComponentTypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3864410", Offset = "0x3863410", VA = "0x183864410")]
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
			[Cpp2IlInjected.Address(RVA = "0x99BE2E0", Offset = "0x99BD2E0", VA = "0x1899BE2E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x99BE330", Offset = "0x99BD330", VA = "0x1899BE330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x99BE140", Offset = "0x99BD140", VA = "0x1899BE140")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x99BE1D0", Offset = "0x99BD1D0", VA = "0x1899BE1D0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99BDB70", Offset = "0x99BCB70", VA = "0x1899BDB70")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99BDEE0", Offset = "0x99BCEE0", VA = "0x1899BDEE0")]
		public void Remove(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99BDFA0", Offset = "0x99BCFA0", VA = "0x1899BDFA0")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99BDE90", Offset = "0x99BCE90", VA = "0x1899BDE90")]
		public readonly int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99BDE00", Offset = "0x99BCE00", VA = "0x1899BDE00")]
		public readonly ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99BDFF0", Offset = "0x99BCFF0", VA = "0x1899BDFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x99BDBC0", Offset = "0x99BCBC0", VA = "0x1899BDBC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99BCE90", Offset = "0x99BBE90", VA = "0x1899BCE90")]
			get
			{
				return default(ArchetypeChunk);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1407120", Offset = "0x1406120", VA = "0x181407120")]
		internal unsafe ArchetypeChunkFromEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99BCCF0", Offset = "0x99BBCF0", VA = "0x1899BCCF0")]
		public EntityInChunk GetEntityInChunk(Entity entity)
		{
			return default(EntityInChunk);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99BCB80", Offset = "0x99BBB80", VA = "0x1899BCB80")]
		public ArchetypeChunk GetArchetypeChunkAndIndex(Entity entity, [Out] int index)
		{
			return default(ArchetypeChunk);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99BCC60", Offset = "0x99BBC60", VA = "0x1899BCC60")]
		public UnsafeUntypedBufferAccessor GetBufferAccessorAndIndex(Entity entity, DynamicComponentTypeHandle chunkBufferTypeHandle, [Out] int indexInChunk)
		{
			return default(UnsafeUntypedBufferAccessor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99BCA90", Offset = "0x99BBA90", VA = "0x1899BCA90")]
		public unsafe bool CopyToEntity(Entity entity, DynamicComponentTypeHandle chunkBufferTypeHandle, void* srcPtr, int srcElementCount, int srcBufferSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99BCDA0", Offset = "0x99BBDA0", VA = "0x1899BCDA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99BCF50", Offset = "0x99BBF50", VA = "0x1899BCF50")]
			get
			{
				return default(EntityArchetype);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1407120", Offset = "0x1406120", VA = "0x181407120")]
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
			[Cpp2IlInjected.Address(RVA = "0xF584A0", Offset = "0xF574A0", VA = "0x180F584A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public NativeArray<byte> this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x99BD630", Offset = "0x99BC630", VA = "0x1899BD630")]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x99BD750", Offset = "0x99BC750", VA = "0x1899BD750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x99BD570", Offset = "0x99BC570", VA = "0x1899BD570")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99BD3D0", Offset = "0x99BC3D0", VA = "0x1899BD3D0")]
		public bool HasComponent(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x99BD480", Offset = "0x99BC480", VA = "0x1899BD480")]
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
		[Cpp2IlInjected.Address(RVA = "0x1407120", Offset = "0x1406120", VA = "0x181407120")]
		internal unsafe EntityExistenceLookupByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x99C5C40", Offset = "0x99C4C40", VA = "0x1899C5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x1407120", Offset = "0x1406120", VA = "0x181407120")]
		internal unsafe HasComponentByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x99CBD10", Offset = "0x99CAD10", VA = "0x1899CBD10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B392F0", Offset = "0x7B382F0", VA = "0x187B392F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7B39140", Offset = "0x7B38140", VA = "0x187B39140")]
		internal unsafe SharedComponentIndexFromEntity(int typeIndex, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7B39080", Offset = "0x7B38080", VA = "0x187B39080")]
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
			[Cpp2IlInjected.Address(RVA = "0x99C42B0", Offset = "0x99C32B0", VA = "0x1899C42B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99C41F0", Offset = "0x99C31F0", VA = "0x1899C41F0")]
		public DeferredEntityCommandBuffer(EntityManager entityManager, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99C3030", Offset = "0x99C2030", VA = "0x1899C3030", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99C3510", Offset = "0x99C2510", VA = "0x1899C3510")]
		public void Playback(EntityModification.TrySetPrefabDataType trySetPrefabDataType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x392C940", Offset = "0x392B940", VA = "0x18392C940")]
		public bool HasComponent<T>(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x99C33C0", Offset = "0x99C23C0", VA = "0x1899C33C0")]
		public bool HasComponent(Entity entity, ComponentType componentType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x392CDD0", Offset = "0x392BDD0", VA = "0x18392CDD0")]
		public bool TryGetComponent<T>(Entity entity, [Out] T value) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x392B470", Offset = "0x392A470", VA = "0x18392B470")]
		public void AddBuffer<T>(Entity entity, NativeArray<T> array) where T : struct, IBufferElementData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x99C3D00", Offset = "0x99C2D00", VA = "0x1899C3D00")]
		private void UnsafeAddBuffer(Entity entity, ComponentType componentType, int alignment, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x392BB20", Offset = "0x392AB20", VA = "0x18392BB20")]
		public void AddComponent<T>(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99C29A0", Offset = "0x99C19A0", VA = "0x1899C29A0")]
		public void AddComponent(Entity entity, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x392BA70", Offset = "0x392AA70", VA = "0x18392BA70")]
		public void AddComponent<T>(NativeArray<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99C2A20", Offset = "0x99C1A20", VA = "0x1899C2A20")]
		public void AddComponent(NativeArray<Entity> entities, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x392BBC0", Offset = "0x392ABC0", VA = "0x18392BBC0")]
		public void AddOrSetComponent<T>(Entity entity, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x99C2B90", Offset = "0x99C1B90", VA = "0x1899C2B90")]
		public void AddOrSetComponent(NativeArray<Entity> entities, ComponentType componentType, int align, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x99C2DC0", Offset = "0x99C1DC0", VA = "0x1899C2DC0")]
		public void AddOrSetComponent(Entity entity, ComponentType componentType, int alignment, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x99C3DA0", Offset = "0x99C2DA0", VA = "0x1899C3DA0")]
		private void UnsafeAddOrSetComponent(Entity entity, ComponentType componentType, int alignment, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99C3F70", Offset = "0x99C2F70", VA = "0x1899C3F70")]
		private void UnsafeAddOrSetComponent(Entity entity, ComponentType componentType, RecRoom.Foundation.Collections.Range range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x392C9E0", Offset = "0x392B9E0", VA = "0x18392C9E0")]
		public void RemoveComponent<T>(Entity entity) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x392CA80", Offset = "0x392BA80", VA = "0x18392CA80")]
		public void RemoveComponent<T>(NativeArray<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x99C39B0", Offset = "0x99C29B0", VA = "0x1899C39B0")]
		public void RemoveComponent(NativeArray<Entity> entities, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x99C3B20", Offset = "0x99C2B20", VA = "0x1899C3B20")]
		public void RemoveComponent(Entity entity, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x392C7A0", Offset = "0x392B7A0", VA = "0x18392C7A0")]
		public void AddOrSetSharedComponent<T>(Entity entity, T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x99C2E60", Offset = "0x99C1E60", VA = "0x1899C2E60")]
		private void AddOrSetSharedComponent(Entity entity, ComponentType componentType, int alignment, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99C3310", Offset = "0x99C2310", VA = "0x1899C3310")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B1CEA0", Offset = "0x5B1BEA0", VA = "0x185B1CEA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99C4950", Offset = "0x99C3950", VA = "0x1899C4950")]
		internal unsafe DynamicBuffer(Unity.Entities.BufferHeader* header, int typeIndex, int internalCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x99C4560", Offset = "0x99C3560", VA = "0x1899C4560")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckBounds(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x99C4820", Offset = "0x99C3820", VA = "0x1899C4820")]
		public ReadOnlySpan<byte> ElementAt(int index)
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x99C48F0", Offset = "0x99C38F0", VA = "0x1899C48F0")]
		public void ResizeUninitialized(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99C48B0", Offset = "0x99C38B0", VA = "0x1899C48B0")]
		public void EnsureCapacity(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5B1B290", Offset = "0x5B1A290", VA = "0x185B1B290")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x99C43E0", Offset = "0x99C33E0", VA = "0x1899C43E0")]
		public void AddRange(ReadOnlySpan<byte> srcSpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99C44D0", Offset = "0x99C34D0", VA = "0x1899C44D0")]
		public NativeArray<byte> AsNativeArray()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x99C4630", Offset = "0x99C3630", VA = "0x1899C4630")]
		public void CopyFrom(NativeArray<byte> v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x99C4770", Offset = "0x99C3770", VA = "0x1899C4770")]
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
		[Cpp2IlInjected.Address(RVA = "0x99C9F20", Offset = "0x99C8F20", VA = "0x1899C9F20")]
		public EntityModification(Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x99C9DE0", Offset = "0x99C8DE0", VA = "0x1899C9DE0")]
		public bool HasComponent(EntityManager em, Entity entity, ComponentType componentType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x99C9690", Offset = "0x99C8690", VA = "0x1899C9690")]
		public void AddOrSetComponent(NativeList<byte> componentsData, ComponentType componentType, int align, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x99C9610", Offset = "0x99C8610", VA = "0x1899C9610")]
		public void AddOrSetComponent(ComponentType componentType, RecRoom.Foundation.Collections.Range range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x99C9EB0", Offset = "0x99C8EB0", VA = "0x1899C9EB0")]
		public void RemoveComponent(ComponentType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x398AA10", Offset = "0x3989A10", VA = "0x18398AA10")]
		public bool TryGetComponent<T>(NativeList<byte> componentsData, EntityManager em, Entity entity, [Out] T value) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99C97C0", Offset = "0x99C87C0", VA = "0x1899C97C0")]
		public void AddOrSetSharedComponent(NativeList<byte> componentsData, ComponentType componentType, int align, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99C9D00", Offset = "0x99C8D00", VA = "0x1899C9D00")]
		public NativeArray<ComponentTypeIndex> GetAddedComponentTypes(Allocator allocator)
		{
			return default(NativeArray<ComponentTypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x99C9D70", Offset = "0x99C8D70", VA = "0x1899C9D70")]
		public NativeArray<ComponentTypeIndex> GetRemovedComponentTypes(Allocator allocator)
		{
			return default(NativeArray<ComponentTypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99C97F0", Offset = "0x99C87F0", VA = "0x1899C97F0")]
		public void ApplyAddedComponents(NativeArray<byte> componentsData, EntityManager em, Entity entity, TrySetPrefabDataType trySetPrefabDataType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x99C9CA0", Offset = "0x99C8CA0", VA = "0x1899C9CA0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x99CA5D0", Offset = "0x99C95D0", VA = "0x1899CA5D0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, ComponentSystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99CA6B0", Offset = "0x99C96B0", VA = "0x1899CA6B0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99CA7B0", Offset = "0x99C97B0", VA = "0x1899CA7B0")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99CA9B0", Offset = "0x99C99B0", VA = "0x1899CA9B0")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x99CA8A0", Offset = "0x99C98A0", VA = "0x1899CA8A0")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x99CA990", Offset = "0x99C9990", VA = "0x1899CA990")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x99CAAA0", Offset = "0x99C9AA0", VA = "0x1899CAAA0")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x99CA2F0", Offset = "0x99C92F0", VA = "0x1899CA2F0")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3991F20", Offset = "0x3990F20", VA = "0x183991F20")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3990890", Offset = "0x398F890", VA = "0x183990890")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3990960", Offset = "0x398F960", VA = "0x183990960")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3990E70", Offset = "0x398FE70", VA = "0x183990E70")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x39910A0", Offset = "0x39900A0", VA = "0x1839910A0")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x39913C0", Offset = "0x39903C0", VA = "0x1839913C0")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4, T5>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x39915D0", Offset = "0x39905D0", VA = "0x1839915D0")]
		public static EntityQueryDesc WithAny<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x39914F0", Offset = "0x39904F0", VA = "0x1839914F0")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3991950", Offset = "0x3990950", VA = "0x183991950")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3991BE0", Offset = "0x3990BE0", VA = "0x183991BE0")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3991CC0", Offset = "0x3990CC0", VA = "0x183991CC0")]
		public static EntityQueryDesc WithNone<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x398FB40", Offset = "0x398EB40", VA = "0x18398FB40")]
		private static ComponentType[] ExpandRO<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x398FBE0", Offset = "0x398EBE0", VA = "0x18398FBE0")]
		private static ComponentType[] ExpandRO<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x398FF60", Offset = "0x398EF60", VA = "0x18398FF60")]
		private static ComponentType[] ExpandRO<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3990500", Offset = "0x398F500", VA = "0x183990500")]
		private static ComponentType[] ExpandRO<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3990790", Offset = "0x398F790", VA = "0x183990790")]
		private static ComponentType[] ExpandRO<T1, T2, T3, T4, T5>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x99CA500", Offset = "0x99C9500", VA = "0x1899CA500")]
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
		[Cpp2IlInjected.Address(RVA = "0x99CA270", Offset = "0x99C9270", VA = "0x1899CA270")]
		public static EntityQueryBuilder WithAll(this EntityQueryBuilder desc, ComponentType componentType)
		{
			return default(EntityQueryBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x99CA2B0", Offset = "0x99C92B0", VA = "0x1899CA2B0")]
		public static EntityQueryBuilder WithNone(this EntityQueryBuilder desc, ComponentType componentType)
		{
			return default(EntityQueryBuilder);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class ArchetypeChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x339A590", Offset = "0x3399590", VA = "0x18339A590")]
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
		[Cpp2IlInjected.Address(RVA = "0x99C2830", Offset = "0x99C1830", VA = "0x1899C2830")]
		public static void DebugLogEntityInfo(this EntityManager entityManager, Entity entity, int maxDepth = 3, string componentSeparator = "\n    ")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x99C2760", Offset = "0x99C1760", VA = "0x1899C2760")]
		public static string DebugGetEntityInfo(this EntityManager entityManager, Entity entity, int maxDepth = 3, string componentSeparator = "\n    ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x99C1740", Offset = "0x99C0740", VA = "0x1899C1740")]
		private static void DebugAppendEntityInfo(this EntityManager entityManager, Entity entity, StringBuilder str, int maxDepth, string componentSeparator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x99C1700", Offset = "0x99C0700", VA = "0x1899C1700")]
		private static void DebugAppendComponentInfo(EntityManager entityManager, Entity entity, ComponentType componentType, StringBuilder str, int maxDepth, string leafPrefix = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x99C1CB0", Offset = "0x99C0CB0", VA = "0x1899C1CB0")]
		private static void DebugAppendObjectInfo(object obj, int maxDepth, StringBuilder str, string leafPrefix = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x99C24A0", Offset = "0x99C14A0", VA = "0x1899C24A0")]
		public static object DebugGetComponentBoxed(this EntityManager entityManager, Entity entity, ComponentType componentType)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class DynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3938D80", Offset = "0x3937D80", VA = "0x183938D80")]
		public static bool Contains<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3938FD0", Offset = "0x3937FD0", VA = "0x183938FD0")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3939E50", Offset = "0x3938E50", VA = "0x183939E50")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3939A00", Offset = "0x3938A00", VA = "0x183939A00")]
		public static void RemoveAllSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3939CA0", Offset = "0x3938CA0", VA = "0x183939CA0")]
		public static void RemoveSetSwapBack<T>(this DynamicBuffer<T> buffer, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3938E60", Offset = "0x3937E60", VA = "0x183938E60")]
		public static bool Contains<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x39397C0", Offset = "0x39387C0", VA = "0x1839397C0")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3939650", Offset = "0x3938650", VA = "0x183939650")]
		public static int IndexOf<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x393A180", Offset = "0x3939180", VA = "0x18393A180")]
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
				[Cpp2IlInjected.Address(RVA = "0x99BD8F0", Offset = "0x99BC8F0", VA = "0x1899BD8F0")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x99BD8D0", Offset = "0x99BC8D0", VA = "0x1899BD8D0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public ComponentType this[int i]
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x99BD900", Offset = "0x99BC900", VA = "0x1899BD900")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x99BD8B0", Offset = "0x99BC8B0", VA = "0x1899BD8B0")]
			internal ComponentTypeEnumerator(EntityArchetype arch, bool includeEntity = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30")]
			public ComponentTypeEnumerator GetEnumerator()
			{
				return default(ComponentTypeEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x99BD880", Offset = "0x99BC880", VA = "0x1899BD880")]
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
				[Cpp2IlInjected.Address(RVA = "0x99BC1C0", Offset = "0x99BB1C0", VA = "0x1899BC1C0")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x99BC140", Offset = "0x99BB140", VA = "0x1899BC140")]
			internal unsafe AddEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x5369420", Offset = "0x5368420", VA = "0x185369420")]
			public AddEnumerator GetEnumerator()
			{
				return default(AddEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x99BC0C0", Offset = "0x99BB0C0", VA = "0x1899BC0C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x99BC1C0", Offset = "0x99BB1C0", VA = "0x1899BC1C0")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x99BC140", Offset = "0x99BB140", VA = "0x1899BC140")]
			internal unsafe RemoveEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5369420", Offset = "0x5368420", VA = "0x185369420")]
			public RemoveEnumerator GetEnumerator()
			{
				return default(RemoveEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x99CDC40", Offset = "0x99CCC40", VA = "0x1899CDC40")]
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
				[Cpp2IlInjected.Address(RVA = "0x99BC450", Offset = "0x99BB450", VA = "0x1899BC450")]
				get
				{
					return default((ComponentType, bool));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x99BC400", Offset = "0x99BB400", VA = "0x1899BC400")]
			internal unsafe AddRemoveEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x99BC2E0", Offset = "0x99BB2E0", VA = "0x1899BC2E0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x99C5B00", Offset = "0x99C4B00", VA = "0x1899C5B00")]
		public static EntityArchetype GetInstantiateArchetype(this EntityArchetype archetype)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x99C59C0", Offset = "0x99C49C0", VA = "0x1899C59C0")]
		public static ComponentTypeEnumerator EnumerateComponentTypes(this EntityArchetype archetype, bool includeEntity = false)
		{
			return default(ComponentTypeEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x99C59E0", Offset = "0x99C49E0", VA = "0x1899C59E0")]
		public static Span<int> GetAllTypeIndices(this EntityArchetype archetype)
		{
			return default(Span<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x99C5AE0", Offset = "0x99C4AE0", VA = "0x1899C5AE0")]
		public static int GetEntityCount(this EntityArchetype archetype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x99C5A50", Offset = "0x99C4A50", VA = "0x1899C5A50")]
		public static AddEnumerator GetComponentsToAdd(this EntityArchetype src, EntityArchetype dst)
		{
			return default(AddEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x99C5A50", Offset = "0x99C4A50", VA = "0x1899C5A50")]
		public static RemoveEnumerator GetComponentsToRemove(this EntityArchetype src, EntityArchetype dst)
		{
			return default(RemoveEnumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal static class EntityBatchInChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x99C5B10", Offset = "0x99C4B10", VA = "0x1899C5B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3963420", Offset = "0x3962420", VA = "0x183963420")]
		public static void SetComponentData<T>(this EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3963780", Offset = "0x3962780", VA = "0x183963780")]
		public static void SetComponentData<T>(this EntityCommandBuffer.ParallelWriter ecb, int sortKey, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class EntityManagerArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x99C5CD0", Offset = "0x99C4CD0", VA = "0x1899C5CD0")]
		public static EntityArchetype CreateArchetypeWithAdditionalComponents(this EntityManager entityManager, EntityArchetype srcArchetype, NativeArray<int> typeIndices)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x99C60C0", Offset = "0x99C50C0", VA = "0x1899C60C0")]
		public static EntityArchetype CreateArchetypeWithModifiedComponents(this EntityManager entityManager, EntityArchetype srcArchetype, NativeArray<int> adds, NativeArray<int> removes)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x99C65C0", Offset = "0x99C55C0", VA = "0x1899C65C0")]
		public static EntityArchetype CreateArchetype(this EntityManager entityManager, Span<ComponentType> types, bool addSimulateIfMissing)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x99C67D0", Offset = "0x99C57D0", VA = "0x1899C67D0")]
		public static EntityArchetype GetArchetype(this EntityManager entityManager, Entity entity)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x99C66C0", Offset = "0x99C56C0", VA = "0x1899C66C0")]
		public static int GetArchetypeCount(this EntityManager entityManager)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class EntityManagerArchetypeFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x99C68F0", Offset = "0x99C58F0", VA = "0x1899C68F0")]
		public static ArchetypeFromEntity GetArchetypeFromEntity(this EntityManager entityManager)
		{
			return default(ArchetypeFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x99C68A0", Offset = "0x99C58A0", VA = "0x1899C68A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99C6940", Offset = "0x99C5940", VA = "0x1899C6940")]
		public static BufferLookup GetBufferLookup(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(BufferLookup);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class EntityManagerChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x99C69E0", Offset = "0x99C59E0", VA = "0x1899C69E0")]
		[ExcludeFromBurstCompatTesting(null)]
		public static void CopyEntitiesFrom(this EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x99C6A50", Offset = "0x99C5A50", VA = "0x1899C6A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x99D3580", Offset = "0x99D2580", VA = "0x1899D3580", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B20DD0", Offset = "0x7B1FDD0", VA = "0x187B20DD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x99D3650", Offset = "0x99D2650", VA = "0x1899D3650", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B20E70", Offset = "0x7B1FE70", VA = "0x187B20E70")]
			public void Execute([In] ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, [In] v128 chunkEnabledMask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7B21140", Offset = "0x7B20140", VA = "0x187B21140", Slot = "4")]
			void IJobChunk.Execute([In] ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, [In] v128 chunkEnabledMask)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x99C6C90", Offset = "0x99C5C90", VA = "0x1899C6C90")]
		public static void CopyComponent(this EntityManager entityManager, Entity dst, Entity src, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x99C7160", Offset = "0x99C6160", VA = "0x1899C7160")]
		public static bool TryCopyComponent(this EntityManager entityManager, Entity dst, Entity src, ComponentType componentType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x39824B0", Offset = "0x39814B0", VA = "0x1839824B0")]
		public static bool TrySetComponentData<T>(this EntityManager entityManager, Entity entity, T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x99C75B0", Offset = "0x99C65B0", VA = "0x1899C75B0")]
		public unsafe static bool TryGetComponentDataRawRW(this EntityManager entityManager, Entity entity, int typeIndex, [Out] void* ptr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x99C7460", Offset = "0x99C6460", VA = "0x1899C7460")]
		public unsafe static bool TryGetComponentDataRawRO(this EntityManager entityManager, Entity entity, int typeIndex, [Out] void* ptr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x39803B0", Offset = "0x397F3B0", VA = "0x1839803B0")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x397CE80", Offset = "0x397BE80", VA = "0x18397CE80")]
		public static T GetComponentDataOrDefault<T>(this EntityManager entityManager, Entity entity, [Optional] T defaultValue) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x397CD90", Offset = "0x397BD90", VA = "0x18397CD90")]
		public static DynamicBuffer<T> GetBufferROOrDefault<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x397D9D0", Offset = "0x397C9D0", VA = "0x18397D9D0")]
		public static NativeArray<T> GetComponentDataOrDefault<T>(this EntityManager entityManager, NativeArray<Entity> entities, Allocator allocator, [Optional] T defaultValue) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x397FF80", Offset = "0x397EF80", VA = "0x18397FF80")]
		public static bool TryGetComponentDataField<TComponent, TValue>(this EntityManager entityManager, Entity entity, Func<TComponent, TValue> func, [Out] TValue value) where TComponent : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x397E0B0", Offset = "0x397D0B0", VA = "0x18397E0B0")]
		public static RefRW<T> GetComponentDataRefRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IComponentData
		{
			return default(RefRW<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x99C6DA0", Offset = "0x99C5DA0", VA = "0x1899C6DA0")]
		public static void SetComponentData(this EntityManager entityManager, Entity entity, int typeIndex, NativeArray<byte> src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x99C6F80", Offset = "0x99C5F80", VA = "0x1899C6F80")]
		public static void SetComponentData(this EntityManager entityManager, ComponentType type, NativeArray<Entity> entities, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x397E140", Offset = "0x397D140", VA = "0x18397E140")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x397FD30", Offset = "0x397ED30", VA = "0x18397FD30")]
		public static void SetTag<T>(this EntityManager entityManager, Entity entity, bool isTagSet) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x397E650", Offset = "0x397D650", VA = "0x18397E650")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x99C6B30", Offset = "0x99C5B30", VA = "0x1899C6B30")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		public static void AssertMatchingSize(int typeIndex, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
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
		[Cpp2IlInjected.Address(RVA = "0x99C7710", Offset = "0x99C6710", VA = "0x1899C7710")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3983400", Offset = "0x3982400", VA = "0x183983400")]
		public static SharedComponentIndexFromEntity<T> GetSharedComponentIndexFromEntity<T>(this EntityManager entityManager) where T : ISharedComponentData
		{
			return default(SharedComponentIndexFromEntity<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class EntityManagerComponentObjectExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3983910", Offset = "0x3982910", VA = "0x183983910")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3983B30", Offset = "0x3982B30", VA = "0x183983B30")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, [Out] T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3983540", Offset = "0x3982540", VA = "0x183983540")]
		public static void AddComponentObject<T>(this EntityManager entityManager, NativeArray<Entity> entities, RentedSpan<T> componentArray) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x39834A0", Offset = "0x39824A0", VA = "0x1839834A0")]
		public static void AddAndSetComponentObject<T>(this EntityManager entityManager, Entity entity, T value) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x99C77C0", Offset = "0x99C67C0", VA = "0x1899C77C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99C7950", Offset = "0x99C6950", VA = "0x1899C7950")]
		public static Entity CopyEntity(this EntityManager entityManager, Entity srcEntity)
		{
			return default(Entity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class EntityManagerDependencyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x99C7F80", Offset = "0x99C6F80", VA = "0x1899C7F80")]
		public static void CompleteReadAndWriteDependency(this EntityManager entityManager, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3983C00", Offset = "0x3982C00", VA = "0x183983C00")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3983DD0", Offset = "0x3982DD0", VA = "0x183983DD0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x99C8020", Offset = "0x99C7020", VA = "0x1899C8020")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, TypeIndex typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x99C81A0", Offset = "0x99C71A0", VA = "0x1899C81A0")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, ReadOnlySpan<TypeIndex> typeIndices)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3983EB0", Offset = "0x3982EB0", VA = "0x183983EB0")]
		public static JobHandle GetReadWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x99C82A0", Offset = "0x99C72A0", VA = "0x1899C82A0")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, TypeIndex typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x99C8420", Offset = "0x99C7420", VA = "0x1899C8420")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, ReadOnlySpan<TypeIndex> typeIndices)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x99C7B40", Offset = "0x99C6B40", VA = "0x1899C7B40")]
		public static JobHandle AddReadDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x99C7A20", Offset = "0x99C6A20", VA = "0x1899C7A20")]
		public static JobHandle AddReadDependency(this EntityManager entityManager, ReadOnlySpan<TypeIndex> typeIndices, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x99C7E10", Offset = "0x99C6E10", VA = "0x1899C7E10")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, TypeIndex typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x99C7CF0", Offset = "0x99C6CF0", VA = "0x1899C7CF0")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, Span<TypeIndex> typeIndices, JobHandle handle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class EntityManagerDynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x99C89A0", Offset = "0x99C79A0", VA = "0x1899C89A0")]
		public static bool TryGetBuffer(this EntityManager entityManager, Entity entity, int typeIndex, [Out] DynamicBuffer buffer, bool isReadOnly = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x99C8520", Offset = "0x99C7520", VA = "0x1899C8520")]
		public static DynamicBuffer GetBufferRO(this EntityManager entityManager, Entity entity, int typeIndex)
		{
			return default(DynamicBuffer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x99C85D0", Offset = "0x99C75D0", VA = "0x1899C85D0")]
		public static DynamicBuffer GetBuffer(this EntityManager entityManager, Entity entity, int typeIndex, bool isReadOnly = false)
		{
			return default(DynamicBuffer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x99C8680", Offset = "0x99C7680", VA = "0x1899C8680")]
		private unsafe static DynamicBuffer GetBuffer(Unity.Entities.EntityDataAccess* access, Entity entity, int typeIndex, bool isReadOnly = false)
		{
			return default(DynamicBuffer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3984440", Offset = "0x3983440", VA = "0x183984440")]
		public static bool TryGetBufferAsRW<T>(this EntityManager entityManager, Entity entity, int typeIndex, [Out] DynamicBuffer<T> buffer) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3983F20", Offset = "0x3982F20", VA = "0x183983F20")]
		public static DynamicBuffer<T> GetBufferAsRW<T>(this EntityManager entityManager, Entity entity, int typeIndex) where T : struct
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3984560", Offset = "0x3983560", VA = "0x183984560")]
		private static bool TryGetBufferAs<T>(this EntityManager entityManager, Entity entity, int typeIndex, bool isReadOnly, [Out] DynamicBuffer<T> buffer) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3984D00", Offset = "0x3983D00", VA = "0x183984D00")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x39849C0", Offset = "0x39839C0", VA = "0x1839849C0")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3985040", Offset = "0x3984040", VA = "0x183985040")]
		public static bool TryGetBuffer<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer, bool isReadOnly) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3984120", Offset = "0x3983120", VA = "0x183984120")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3984300", Offset = "0x3983300", VA = "0x183984300")]
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
		[Cpp2IlInjected.Address(RVA = "0x99C8AF0", Offset = "0x99C7AF0", VA = "0x1899C8AF0")]
		public static EntityExistenceLookupByEntity GetEntityExistenceLookupByEntity(this EntityManager entityManager)
		{
			return default(EntityExistenceLookupByEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class EntityManagerFilterToExistingEntitiesExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x99C9070", Offset = "0x99C8070", VA = "0x1899C9070")]
		public static bool PartitionExistingEntitiesUnstable(this NativeArray<Entity> liveEntities, EntityManager entityManager, [Out] NativeArray<Entity> deadEntities, bool keepCleanupEntities = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x99C8DD0", Offset = "0x99C7DD0", VA = "0x1899C8DD0")]
		public static bool PartitionExistingEntitiesUnstable(this EntityManager entityManager, NativeArray<Entity> liveEntities, [Out] NativeArray<Entity> deadEntities, bool keepCleanupEntities = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x99C8B40", Offset = "0x99C7B40", VA = "0x1899C8B40")]
		public static bool FilterToExistingEntities(this NativeArray<Entity> entities, EntityManager entityManager, bool keepCleanupEntities = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x99C8B70", Offset = "0x99C7B70", VA = "0x1899C8B70")]
		public static bool FilterToExistingEntities(this EntityManager entityManager, NativeArray<Entity> entities, bool keepCleanupEntities = true)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class EntityManagerHasComponentByEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x99C90A0", Offset = "0x99C80A0", VA = "0x1899C90A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3985850", Offset = "0x3984850", VA = "0x183985850")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class ExclusiveEntityTransactionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3AB17F0", Offset = "0x3AB07F0", VA = "0x183AB17F0")]
		[GenerateTestsForBurstCompatibility]
		public static int GetSharedComponentDataIndex<T>(this ExclusiveEntityTransaction transaction, Entity entity) where T : struct, ISharedComponentData
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3AB18E0", Offset = "0x3AB08E0", VA = "0x183AB18E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99CD930", Offset = "0x99CC930", VA = "0x1899CD930", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x99CD080", Offset = "0x99CC080", VA = "0x1899CD080")]
		public unsafe static void PatchMatchingEntities(EntityRemapUtility.EntityPatchInfo* scalarPatches, int scalarPatchCount, EntityRemapUtility.BufferEntityPatchInfo* bufferPatches, int bufferPatchCount, byte* chunkBuffer, int entityOffset, int entityCount, NativeParallelHashMap<Entity, Entity> remapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x99CD700", Offset = "0x99CC700", VA = "0x1899CD700")]
		public static Entity RemapMatchingEntity(NativeParallelHashMap<Entity, Entity> map, Entity source)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x99CD320", Offset = "0x99CC320", VA = "0x1899CD320")]
		public static JobHandle RemapAllMatchingEntities(this EntityManager entityManager, NativeParallelHashMap<Entity, Entity> map)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x99CD500", Offset = "0x99CC500", VA = "0x1899CD500")]
		public static JobHandle RemapAllMatchingEntities(this EntityQuery query, NativeParallelHashMap<Entity, Entity> map, EntityManager entityManager, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class EntityQueryArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x99CA0E0", Offset = "0x99C90E0", VA = "0x1899CA0E0")]
		public static int CalculateArchetypeCount(this EntityQuery query)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x99C9FD0", Offset = "0x99C8FD0", VA = "0x1899C9FD0")]
		private static int CalculateArchetypeCount(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Unity.Entities.EntityQueryFilter filter)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class EntityQueryChangeVersionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x398F0D0", Offset = "0x398E0D0", VA = "0x18398F0D0")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x398F750", Offset = "0x398E750", VA = "0x18398F750")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x398F670", Offset = "0x398E670", VA = "0x18398F670")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3, T4>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x398F810", Offset = "0x398E810", VA = "0x18398F810")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3, T4, T5>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x398F040", Offset = "0x398E040", VA = "0x18398F040")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x99CABC0", Offset = "0x99C9BC0", VA = "0x1899CABC0")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x99CAB70", Offset = "0x99C9B70", VA = "0x1899CAB70")]
		public static bool IsEmpty(this EntityQuery entityQuery, [Out] int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x39920F0", Offset = "0x39910F0", VA = "0x1839920F0")]
		public static RentedArray<T> ToComponentObjectArray<T>(this EntityQuery query) where T : class
		{
			return default(RentedArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3992060", Offset = "0x3991060", VA = "0x183992060")]
		public static ComponentTypeHandle<T> GetComponentTypeHandle<T>(this EntityQuery query, bool isReadOnly)
		{
			return default(ComponentTypeHandle<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x99CAAC0", Offset = "0x99C9AC0", VA = "0x1899CAAC0")]
		internal unsafe static Unity.Entities.EntityDataAccess* GetEntityDataAccess(this EntityQuery query)
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityDataAccess*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x99CAAE0", Offset = "0x99C9AE0", VA = "0x1899CAAE0")]
		public static uint GetGlobalSystemVersion(this EntityQuery query)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class EntityQueryToComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x399EA30", Offset = "0x399DA30", VA = "0x18399EA30")]
		public static NativeArray<T> ToSharedComponentDataArray<T>(this EntityQuery entityQuery, Allocator allocator = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x399DE90", Offset = "0x399CE90", VA = "0x18399DE90")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x99CB990", Offset = "0x99CA990", VA = "0x1899CB990")]
		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", CompileTarget = GenerateTestsForBurstCompatibilityAttribute.BurstCompatibleCompileTarget.Editor)]
		public static NativeArray<byte> ToComponentDataArray(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x399E440", Offset = "0x399D440", VA = "0x18399E440")]
		public static NativeListAsync<T> ToComponentDataListAsync<T>(this EntityQuery query, Allocator allocator = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(NativeListAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x99CB760", Offset = "0x99CA760", VA = "0x1899CB760")]
		private static NativeArray<byte> CreateComponentDataArrayRun(AllocatorManager.AllocatorHandle allocator, ComponentTypeHandle typeHandle, int entityCount, EntityQuery entityQuery)
		{
			return default(NativeArray<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class EntityQueryToEntityArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x99CBBA0", Offset = "0x99CABA0", VA = "0x1899CBBA0")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x99CBBF0", Offset = "0x99CABF0", VA = "0x1899CBBF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99CC880", Offset = "0x99CB880", VA = "0x1899CC880")]
		public unsafe static int GetIndexInTypeArray(this Unity.Entities.LookupCache lookupCache, Unity.Entities.Archetype* archetype, int typeIndex)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class RRChunkUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x99CCCB0", Offset = "0x99CBCB0", VA = "0x1899CCCB0")]
		public unsafe static void GatherBatches(Entity* aEntities, Entity* bEntities, int count, NativeList<(Unity.Entities.EntityBatchInChunk a, Unity.Entities.EntityBatchInChunk b)> batches, Unity.Entities.EntityComponentStore* ecs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x99CCC90", Offset = "0x99CBC90", VA = "0x1899CCC90")]
		private static Unity.Entities.EntityBatchInChunk Batch(EntityInChunk prev, EntityInChunk curr)
		{
			return default(Unity.Entities.EntityBatchInChunk);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x99CD060", Offset = "0x99CC060", VA = "0x1899CD060")]
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
				[Cpp2IlInjected.Address(RVA = "0x5BF3090", Offset = "0x5BF2090", VA = "0x185BF3090", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public (TKey key, NativeArray<TValue> values, int offset, int count) Current
			{
				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x5BF5010", Offset = "0x5BF4010", VA = "0x185BF5010", Slot = "4")]
				get
				{
					return default((TKey, NativeArray<TValue>, int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x5BF4F90", Offset = "0x5BF3F90", VA = "0x185BF4F90")]
			public Enumerator(GroupByKey<TKey, TValue> grouped)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x4F4AB50", Offset = "0x4F49B50", VA = "0x184F4AB50", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x5BF08C0", Offset = "0x5BEF8C0", VA = "0x185BF08C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6505D70", Offset = "0x6504D70", VA = "0x186505D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6505D40", Offset = "0x6504D40", VA = "0x186505D40")]
		public GroupByKey(NativeArray<TKey> uniqueKeys, NativeArray<int> offsets, NativeArray<int> counts, NativeArray<TValue> valuesGroupedByKey, NativeParallelHashMap<TKey, int> indexByKey)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6503700", Offset = "0x6502700", VA = "0x186503700", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6503A00", Offset = "0x6502A00", VA = "0x186503A00")]
		public readonly NativeArray<TValue> GetValues(int index)
		{
			return default(NativeArray<TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x65032E0", Offset = "0x65022E0", VA = "0x1865032E0", Slot = "4")]
		public readonly JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x65055F0", Offset = "0x65045F0", VA = "0x1865055F0")]
		public static GroupByKey<TKey, TValue> Group(NativeArray<TKey> keys, NativeArray<TValue> values, Allocator allocator = Allocator.Temp)
		{
			return default(GroupByKey<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6502CE0", Offset = "0x6501CE0", VA = "0x186502CE0")]
		[BurstDiscard]
		private static void CheckLengths(NativeArray<TKey> keys, NativeArray<TValue> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6503930", Offset = "0x6502930", VA = "0x186503930")]
		public readonly Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6505B90", Offset = "0x6504B90", VA = "0x186505B90", Slot = "6")]
		private IEnumerator<(TKey, NativeArray<TValue>, int, int)> System.Collections.Generic.IEnumerable<(TKeykey,Unity.Collections.NativeArray<TValue>values,System.Int32offset,System.Int32count)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6505B90", Offset = "0x6504B90", VA = "0x186505B90", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x99BD150", Offset = "0x99BC150", VA = "0x1899BD150")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x99BD070", Offset = "0x99BC070", VA = "0x1899BD070")]
		public AsyncDispose(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x99BD150", Offset = "0x99BC150", VA = "0x1899BD150")]
		public static implicit operator JobHandle(AsyncDispose set)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x369C230", Offset = "0x369B230", VA = "0x18369C230")]
		public void Add<T>(T disposable) where T : struct, INativeDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x369BB60", Offset = "0x369AB60", VA = "0x18369BB60")]
		public void Add<T>(NativeArrayAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x369BDD0", Offset = "0x369ADD0", VA = "0x18369BDD0")]
		public void Add<T>(NativeArray<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x369BCD0", Offset = "0x369ACD0", VA = "0x18369BCD0")]
		public void Add<T>(NativeListAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x369BBE0", Offset = "0x369ABE0", VA = "0x18369BBE0")]
		public void Add<T>(NativeList<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x99BCFE0", Offset = "0x99BBFE0", VA = "0x1899BCFE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x99BD020", Offset = "0x99BC020", VA = "0x1899BD020", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x99C4340", Offset = "0x99C3340", VA = "0x1899C4340")]
		private DisableJobSchedulingScope(bool disableScheduling)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x99C4330", Offset = "0x99C3330", VA = "0x1899C4330", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x99C42F0", Offset = "0x99C32F0", VA = "0x1899C42F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x99CC6D0", Offset = "0x99CB6D0", VA = "0x1899CC6D0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x99CC620", Offset = "0x99CB620", VA = "0x1899CC620")]
		public JobGroup(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x99CC4F0", Offset = "0x99CB4F0", VA = "0x1899CC4F0")]
		public void Add(JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x99BCFE0", Offset = "0x99BBFE0", VA = "0x1899BCFE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x99CC5D0", Offset = "0x99CB5D0", VA = "0x1899CC5D0", Slot = "4")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x99CC550", Offset = "0x99CB550", VA = "0x1899CC550")]
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
			[Cpp2IlInjected.Address(RVA = "0x99CCC20", Offset = "0x99CBC20", VA = "0x1899CCC20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x99CD770", Offset = "0x99CC770", VA = "0x1899CD770", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x99BFA80", Offset = "0x99BEA80", VA = "0x1899BFA80")]
		[ExcludeFromBurstCompatTesting("Uses EntityManager")]
		public static void CopyEntitiesFrom(EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x99C1030", Offset = "0x99C0030", VA = "0x1899C1030")]
		private static NativeArray<ArchetypeChunk> GetChunksFromEntities(NativeArray<Entity> entities, EntityManager srcEntityManager)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x99C05C0", Offset = "0x99BF5C0", VA = "0x1899C05C0")]
		private unsafe static NativeArray<ArchetypeChunk> CopyEntitiesInternal(NativeArray<ArchetypeChunk> srcChunks, Unity.Entities.EntityDataAccess* srcAccess, CopyFlags copyFlags)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x99C12E0", Offset = "0x99C02E0", VA = "0x1899C12E0")]
		internal unsafe static void RemapEntityRefs(NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping, Unity.Entities.EntityDataAccess* dataAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x99C1460", Offset = "0x99C0460", VA = "0x1899C1460")]
		internal static void RemapEntityRefs(EntityManager entityManager, NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x99C1140", Offset = "0x99C0140", VA = "0x1899C1140")]
		public static JobHandle RemapAllEntities(EntityManager entityManager, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x899F960", Offset = "0x899E960", VA = "0x18899F960")]
		private static bool HasFlag(CopyFlags copyFlags, CopyFlags testFlag)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x99C0DC0", Offset = "0x99BFDC0", VA = "0x1899C0DC0")]
		private unsafe static void CreateChunks(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x99C0C80", Offset = "0x99BFC80", VA = "0x1899C0C80")]
		private unsafe static void CopyNames(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x99BF400", Offset = "0x99BE400", VA = "0x1899BF400")]
		private static void CloneNativeComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x99BF790", Offset = "0x99BE790", VA = "0x1899BF790")]
		public unsafe static void CloneNativeComponents([In] Unity.Entities.EntityBatchInChunk srcBatch, Unity.Entities.Chunk* dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x99BE620", Offset = "0x99BD620", VA = "0x1899BE620")]
		private static void ClearBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x99BE480", Offset = "0x99BD480", VA = "0x1899BE480")]
		private static void ClearBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x99BEB90", Offset = "0x99BDB90", VA = "0x1899BEB90")]
		private static void CloneBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x99BE980", Offset = "0x99BD980", VA = "0x1899BE980")]
		private static void CloneBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x99BE860", Offset = "0x99BD860", VA = "0x1899BE860")]
		private static void ClearManagedComponents(NativeArray<ArchetypeChunk> chunks, uint globalSystemVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x99BF330", Offset = "0x99BE330", VA = "0x1899BF330")]
		private static void CloneManagedComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x99BEE60", Offset = "0x99BDE60", VA = "0x1899BEE60")]
		private static void CloneEnabledBits(NativeArray<ArchetypeChunk> srcArchetypeChunks, NativeArray<ArchetypeChunk> dstArchetypeChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x99BF130", Offset = "0x99BE130", VA = "0x1899BF130")]
		private static void CloneEnabledBits(ArchetypeChunk srcArchetypeChunk, ArchetypeChunk dstArchetypeChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x99C0EF0", Offset = "0x99BFEF0", VA = "0x1899C0EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99CB590", Offset = "0x99CA590", VA = "0x1899CB590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IsEmptyIgnoreFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x99CB540", Offset = "0x99CA540", VA = "0x1899CB540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x99CAC00", Offset = "0x99C9C00", VA = "0x1899CAC00")]
		public static implicit operator EntityQueryInJob(EntityQuery query)
		{
			return default(EntityQueryInJob);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x99CB4D0", Offset = "0x99CA4D0", VA = "0x1899CB4D0")]
		public EntityQueryInJob(EntityQuery query)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x99CAE60", Offset = "0x99C9E60", VA = "0x1899CAE60")]
		public int CalculateEntityCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x99CAF50", Offset = "0x99C9F50", VA = "0x1899CAF50")]
		public bool HasFilter()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x99CAFA0", Offset = "0x99C9FA0", VA = "0x1899CAFA0")]
		public NativeArray<ArchetypeChunk> ToArchetypeChunkArray(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x99CB1F0", Offset = "0x99CA1F0", VA = "0x1899CB1F0")]
		[GenerateTestsForBurstCompatibility]
		public NativeArray<Entity> ToEntityArray(EntityTypeHandle entityType, Allocator allocator = Allocator.Temp)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x399C3A0", Offset = "0x399B3A0", VA = "0x18399C3A0")]
		[GenerateTestsForBurstCompatibility]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle typeHandle, Allocator allocator = Allocator.Temp) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x399BF60", Offset = "0x399AF60", VA = "0x18399BF60")]
		[GenerateTestsForBurstCompatibility]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle<T> typeHandle, Allocator allocator = Allocator.Temp) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
		internal unsafe Unity.Entities.EntityQueryImpl* _GetImpl()
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityQueryImpl*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x99CAC70", Offset = "0x99C9C70", VA = "0x1899CAC70")]
		private void CalculateChunkAndEntityCount([Out] int entityCount, [Out] int chunkCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x99CAD80", Offset = "0x99C9D80", VA = "0x1899CAD80")]
		public int CalculateChunkCountWithoutFiltering()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class EntityQueryInJobExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x99CAC00", Offset = "0x99C9C00", VA = "0x1899CAC00")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B47430", Offset = "0x3B46430", VA = "0x183B47430")]
		public static void Run<T>(this T operation, EntityQueryInJob query) where T : struct, IQueryInJobEntityBatch
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3B47430", Offset = "0x3B46430", VA = "0x183B47430")]
		public static void RunRef<T>(this T operation, EntityQueryInJob query) where T : struct, IQueryInJobEntityBatch
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3B46680", Offset = "0x3B45680", VA = "0x183B46680")]
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
		[Cpp2IlInjected.Address(RVA = "0x99C4380", Offset = "0x99C3380", VA = "0x1899C4380")]
		public void Execute([In] ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, [In] v128 chunkEnabledMask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x99C43C0", Offset = "0x99C33C0", VA = "0x1899C43C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x737F120", Offset = "0x737E120", VA = "0x18737F120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x63165A0", Offset = "0x63155A0", VA = "0x1863165A0")]
		public NativeMultiHashMapAsync(NativeParallelMultiHashMap<TKey, TValue> map, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x737EF50", Offset = "0x737DF50", VA = "0x18737EF50")]
		public NativeParallelMultiHashMap<TKey, TValue> Complete()
		{
			return default(NativeParallelMultiHashMap<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x737EF90", Offset = "0x737DF90", VA = "0x18737EF90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A5D70", Offset = "0x72A4D70", VA = "0x1872A5D70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x99CDBD0", Offset = "0x99CCBD0", VA = "0x1899CDBD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x99CDB70", Offset = "0x99CCB70", VA = "0x1899CDB70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x15315F0", Offset = "0x15305F0", VA = "0x1815315F0")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x99CCC80", Offset = "0x99CBC80", VA = "0x1899CCC80", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x99CB5B0", Offset = "0x99CA5B0", VA = "0x1899CB5B0")]
		public static void DestroyEntitiesInScene(this EntityQuery query, SceneTag scene, EntityManager entityManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x99CB6D0", Offset = "0x99CA6D0", VA = "0x1899CB6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99C9310", Offset = "0x99C8310", VA = "0x1899C9310")]
		public static bool TryGetChildEntitySubArrayRO(this EntityManager entityManager, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x99C9560", Offset = "0x99C8560", VA = "0x1899C9560")]
		public static bool TryGetChildEntitySubArray(this BufferLookup<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x99C9430", Offset = "0x99C8430", VA = "0x1899C9430")]
		public static bool TryGetChildEntitySubArray([In] this DynamicBuffer<LinkedEntityGroup> buffer, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x99C91C0", Offset = "0x99C81C0", VA = "0x1899C91C0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x99C90F0", Offset = "0x99C80F0", VA = "0x1899C90F0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferLookup<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x99C92E0", Offset = "0x99C82E0", VA = "0x1899C92E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99D3820", Offset = "0x99D2820", VA = "0x1899D3820", Slot = "4")]
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
		internal unsafe delegate int AllocAndQueueReadChunkCommands_00000275$PostfixBurstDelegate(long readOffset, int totalChunkCount, UnsafeList<SerializeUtilityV73.MegaChunkInfo>* megaChunkInfo, UnsafeList<ReadCommand>* readCommands);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		internal static class AllocAndQueueReadChunkCommands_00000275$BurstDirectCall
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private static IntPtr Pointer;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x99BC4B0", Offset = "0x99BB4B0", VA = "0x1899BC4B0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(IntPtr P_0)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x99BC630", Offset = "0x99BB630", VA = "0x1899BC630")]
			private static IntPtr GetFunctionPointer()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x99BC7A0", Offset = "0x99BB7A0", VA = "0x1899BC7A0")]
			public unsafe static int Invoke(long readOffset, int totalChunkCount, UnsafeList<SerializeUtilityV73.MegaChunkInfo>* megaChunkInfo, UnsafeList<ReadCommand>* readCommands)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void AddExistingChunk_00000276$PostfixBurstDelegate(Unity.Entities.Chunk* chunk, int* sharedComponentIndices, byte* enabledBitsValuesForChunk, int* perComponentDisabledBitCount);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		internal static class AddExistingChunk_00000276$BurstDirectCall
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void ImportChunks_00000277$PostfixBurstDelegate(SerializeUtilityV73.WorldDeserializationStatus* status, BurstableMemoryBinaryReader bufferReader, UnsafeList<EntityArchetype>* archetypes, int* sharedComponentArray, int numSharedComponents, int* sharedComponentRemap, UnsafeList<ArchetypeChunk>* blobAssetRefChunks, byte* componentEnabledBits, int* enabledBitsHierarchicalData, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		internal static class ImportChunks_00000277$BurstDirectCall
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private static IntPtr Pointer;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x99CBDC0", Offset = "0x99CADC0", VA = "0x1899CBDC0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(IntPtr P_0)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x99CBF50", Offset = "0x99CAF50", VA = "0x1899CBF50")]
			private static IntPtr GetFunctionPointer()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x99CC0D0", Offset = "0x99CB0D0", VA = "0x1899CC0D0")]
			public unsafe static void Invoke(SerializeUtilityV73.WorldDeserializationStatus* status, BurstableMemoryBinaryReader bufferReader, UnsafeList<EntityArchetype>* archetypes, int* sharedComponentArray, int numSharedComponents, int* sharedComponentRemap, UnsafeList<ArchetypeChunk>* blobAssetRefChunks, byte* componentEnabledBits, int* enabledBitsHierarchicalData, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x99CDE30", Offset = "0x99CCE30", VA = "0x1899CDE30")]
		[BurstMonoInteropMethod(false, MakePublic = false)]
		internal unsafe static void AllocateConsecutiveEntitiesForLoading(Unity.Entities.EntityComponentStore* store, int entityCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x99CDE20", Offset = "0x99CCE20", VA = "0x1899CDE20")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(Unity.Entities.Serialization.AllocAndQueueReadChunkCommands_00000275$PostfixBurstDelegate))]
		internal unsafe static int AllocAndQueueReadChunkCommands(long readOffset, int totalChunkCount, UnsafeList<SerializeUtilityV73.MegaChunkInfo>* megaChunkInfo, UnsafeList<ReadCommand>* readCommands)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x99CEC80", Offset = "0x99CDC80", VA = "0x1899CEC80")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(Unity.Entities.Serialization.ImportChunks_00000277$PostfixBurstDelegate))]
		internal unsafe static void ImportChunks(SerializeUtilityV73.WorldDeserializationStatus* status, BurstableMemoryBinaryReader bufferReader, UnsafeList<EntityArchetype>* archetypes, int* sharedComponentArray, int numSharedComponents, int* sharedComponentRemap, UnsafeList<ArchetypeChunk>* blobAssetRefChunks, byte* componentEnabledBits, int* enabledBitsHierarchicalData, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x99CF860", Offset = "0x99CE860", VA = "0x1899CF860")]
		private unsafe static void ProcessChunkWithGuaranteedSupportedCapacity(UnsafeList<ArchetypeChunk>* blobAssetRefChunks, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities, Unity.Entities.Chunk* chunk, int totalBlobAssetSize, Unity.Entities.Archetype* archetype, void* blobAssetBuffer, int* remappedSharedComponentValues, byte* enabledBitsForChunk, int* enabledBitsHierarchicalDataForChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x99CFB60", Offset = "0x99CEB60", VA = "0x1899CFB60")]
		private unsafe static void ProcessChunkWithPotentialExcessCapacity(UnsafeList<ArchetypeChunk>* blobAssetRefChunks, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities, Unity.Entities.Chunk* chunk, int totalBlobAssetSize, Unity.Entities.Archetype* archetype, void* blobAssetBuffer, int* remapedSharedComponentValues, byte* enabledBitsForChunk, int* enabledBitsHierarchicalDataForChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x99CF090", Offset = "0x99CE090", VA = "0x1899CF090")]
		private unsafe static void PatchChunkForCapacityChange(Unity.Entities.Chunk* chunk, Unity.Entities.Archetype* archetype, Span<int> oldLayoutOffsets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x99CECF0", Offset = "0x99CDCF0", VA = "0x1899CECF0")]
		private unsafe static void MoveExcessDataToNewChunks(UnsafeList<ArchetypeChunk>* blobAssetRefChunks, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities, Unity.Entities.Chunk* existingChunk, int totalBlobAssetSize, Unity.Entities.Archetype* archetype, void* blobAssetBuffer, int* remappedSharedComponentValues, byte* existingEnabledBitsForChunk, int* existingEnabledBitsHierarchicalDataForChunk, Span<int> oldLayoutOffsets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x99CDE90", Offset = "0x99CCE90", VA = "0x1899CDE90")]
		private unsafe static void ExtractOneAdditionalChunk(UnsafeList<ArchetypeChunk>* blobAssetRefChunks, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities, Unity.Entities.Chunk* oldChunk, int totalBlobAssetSize, Unity.Entities.Archetype* archetype, void* blobAssetBuffer, int* remappedSharedComponentValues, byte* oldEnabledBitsForChunk, int* oldEnabledHierarchicalDataForChunk, Span<int> oldLayoutOffsets, int thisChunkIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x99D0080", Offset = "0x99CF080", VA = "0x1899D0080")]
		private unsafe static void RemapAllEnabledBitsForChunk(byte* oldEnabledBitsForChunk, Unity.Entities.Archetype* archetype, byte* newChunkEnabledComponentData, int* newChunkEnabledHierarchicalData, int chunkIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x99D0240", Offset = "0x99CF240", VA = "0x1899D0240")]
		private unsafe static void RemapEnabledBitsFromOldToNew(byte* oldEnabledBitsForChunk, int thisChunkIndex, int indexInArchetype, int typeMemoryOrderIndex, byte* newChunkEnabledComponentData, int* newChunkEnabledHierarchicalData, int newChunkCapacity, int oldChunkCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x99CE6E0", Offset = "0x99CD6E0", VA = "0x1899CE6E0")]
		private unsafe static int GetOldLayoutCapacity(Unity.Entities.Archetype* archetype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x99CF720", Offset = "0x99CE720", VA = "0x1899CF720")]
		private unsafe static void PopulateOldOffsets(Unity.Entities.Archetype* archetype, Span<int> offsets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x99D0330", Offset = "0x99CF330", VA = "0x1899D0330")]
		private unsafe static void RemapSharedComponentIndices(int* destValues, Unity.Entities.Archetype* archetype, int* remappedIndices, int* sourceValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x99CF170", Offset = "0x99CE170", VA = "0x1899CF170")]
		private unsafe static void PatchChunkForMemoryOrderChanges(Unity.Entities.Archetype* archetype, Unity.Entities.Chunk* chunk, byte* temp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x99D03E0", Offset = "0x99CF3E0", VA = "0x1899D03E0")]
		private static int RemapToOldTypeFlags(int srcTypeFlags)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x99CE590", Offset = "0x99CD590", VA = "0x1899CE590")]
		private static void GenerateOldMemoryOrdering(ReadOnlySpan<int> oldFormatTypeFlags, ReadOnlySpan<ulong> srcMemoryOrderings, Span<int> oldMemoryOrderToIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x406B900", Offset = "0x406A900", VA = "0x18406B900")]
		private unsafe static byte* OffsetFromPointer(void* ptr, int offset)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x99CEE10", Offset = "0x99CDE10", VA = "0x1899CEE10")]
		private unsafe static void PatchBlobAssetsInChunkAfterLoad(Unity.Entities.Chunk* chunk, byte* allBlobAssetData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x99CDCC0", Offset = "0x99CCCC0", VA = "0x1899CDCC0")]
		[BurstCompile]
		internal unsafe static int AllocAndQueueReadChunkCommands$BurstManaged(long readOffset, int totalChunkCount, UnsafeList<SerializeUtilityV73.MegaChunkInfo>* megaChunkInfo, UnsafeList<ReadCommand>* readCommands)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x99CE760", Offset = "0x99CD760", VA = "0x1899CE760")]
		[BurstCompile]
		internal unsafe static void ImportChunks$BurstManaged(SerializeUtilityV73.WorldDeserializationStatus* status, BurstableMemoryBinaryReader bufferReader, UnsafeList<EntityArchetype>* archetypes, int* sharedComponentArray, int numSharedComponents, int* sharedComponentRemap, UnsafeList<ArchetypeChunk>* blobAssetRefChunks, byte* componentEnabledBits, int* enabledBitsHierarchicalData, Unity.Entities.EntityComponentStore* ecs, UnsafeList<ArchetypeChunk>* chunksWithMetaChunkEntities)
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
			[Cpp2IlInjected.Address(RVA = "0x4FDBB60", Offset = "0x4FDAB60", VA = "0x184FDBB60")]
			public unsafe ManagedObjectReaderAdapter(byte* blobAssetBatch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x99CCA80", Offset = "0x99CBA80", VA = "0x1899CCA80", Slot = "4")]
			void IBinaryAdapter<Entity>.Serialize([In] BinarySerializationContext<Entity> context, Entity value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x99CC990", Offset = "0x99CB990", VA = "0x1899CC990", Slot = "6")]
			void IBinaryAdapter<Unity.Entities.BlobAssetReferenceData>.Serialize([In] BinarySerializationContext<Unity.Entities.BlobAssetReferenceData> context, Unity.Entities.BlobAssetReferenceData value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x99CC9E0", Offset = "0x99CB9E0", VA = "0x1899CC9E0", Slot = "5")]
			Entity IBinaryAdapter<Entity>.Deserialize([In] BinaryDeserializationContext<Entity> context)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x99CC900", Offset = "0x99CB900", VA = "0x1899CC900", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B67E80", Offset = "0x2B66E80", VA = "0x182B67E80")]
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
			[Cpp2IlInjected.Address(RVA = "0x99D3BE0", Offset = "0x99D2BE0", VA = "0x1899D3BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99D2520", Offset = "0x99D1520", VA = "0x1899D2520")]
		private static UnsafeList<EntityArchetype> ReadArchetypes(BinaryReader reader, NativeArray<TypeIndex> types, ExclusiveEntityTransaction entityManager, [Out] int totalEntityCount)
		{
			return default(UnsafeList<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x99D2AA0", Offset = "0x99D1AA0", VA = "0x1899D2AA0")]
		private static NativeArray<TypeIndex> ReadTypeArray(BinaryReader reader, Unity.Entities.Serialization.DotsSerializationReader dotsReader)
		{
			return default(NativeArray<TypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x99D1D60", Offset = "0x99D0D60", VA = "0x1899D1D60")]
		private unsafe static void FillReadCommands(Unity.Entities.Serialization.DotsSerializationReader dotsReader, UnsafeList<ReadCommand>* readCommands, [Out] WorldDeserializationStatus status)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x99D04A0", Offset = "0x99CF4A0", VA = "0x1899D04A0")]
		internal static ReadHandle BeginDeserializeWorld(string serializationFilePathName, Unity.Entities.Serialization.DotsSerializationReader dotsReader, [Out] WorldDeserializationStatus status, [Out] UnsafeList<ReadCommand> readCommands)
		{
			return default(ReadHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x99D0D90", Offset = "0x99CFD90", VA = "0x1899D0D90")]
		internal static void EndDeserializeWorld(ExclusiveEntityTransaction manager, Unity.Entities.Serialization.DotsSerializationReader dotsReader, WorldDeserializationStatus status, [Out] WorldDeserializationResult deserializationResult, [Optional] object[] unityObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x99D0D00", Offset = "0x99CFD00", VA = "0x1899D0D00")]
		public static void DeserializeWorld(ExclusiveEntityTransaction manager, BinaryReader reader, [Optional] object[] unityObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x99D05E0", Offset = "0x99CF5E0", VA = "0x1899D05E0")]
		internal static void DeserializeWorld(ExclusiveEntityTransaction manager, BinaryReader reader, [Out] WorldDeserializationResult deserializationResult, [Optional] object[] unityObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x99D2930", Offset = "0x99D1930", VA = "0x1899D2930")]
		private static void ReadSharedComponents(ExclusiveEntityTransaction manager, Unity.Entities.Serialization.ManagedObjectBinaryReader managedDataReader, NativeArray<int> sharedComponentRemap, NativeArray<SharedComponentRecord> sharedComponentRecordArray)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x99D27F0", Offset = "0x99D17F0", VA = "0x1899D27F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99C5890", Offset = "0x99C4890", VA = "0x1899C5890")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IEnumerable<ComponentType> ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x99C5750", Offset = "0x99C4750", VA = "0x1899C5750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x99C5100", Offset = "0x99C4100", VA = "0x1899C5100")]
		public TypeIndex GetTypeIndex(int index)
		{
			return default(TypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x99C5040", Offset = "0x99C4040", VA = "0x1899C5040")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x99C5440", Offset = "0x99C4440", VA = "0x1899C5440")]
		public DynamicComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x99C5520", Offset = "0x99C4520", VA = "0x1899C5520")]
		public DynamicComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x99C49A0", Offset = "0x99C39A0", VA = "0x1899C49A0")]
		public void Add(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x99C51A0", Offset = "0x99C41A0", VA = "0x1899C51A0")]
		public void Remove(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x99C4BF0", Offset = "0x99C3BF0", VA = "0x1899C4BF0")]
		private void DistinctSort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x99C5920", Offset = "0x99C4920", VA = "0x1899C5920")]
		public static DynamicComponentTypeList operator -(DynamicComponentTypeList a, DynamicComponentTypeList b)
		{
			return default(DynamicComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x99C5210", Offset = "0x99C4210", VA = "0x1899C5210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x99C50B0", Offset = "0x99C40B0", VA = "0x1899C50B0", Slot = "4")]
		public IEnumerator<ComponentType> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x99C50B0", Offset = "0x99C40B0", VA = "0x1899C50B0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1614819816
{
	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x99D3C80", Offset = "0x99D2C80", VA = "0x1899D3C80")]
	public static void PQMGTAMPKVS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x99D3C70", Offset = "0x99D2C70", VA = "0x1899D3C70")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x99D3980", Offset = "0x99D2980", VA = "0x1899D3980")]
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

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
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78239C0", Offset = "0x7822DC0", VA = "0x1878239C0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NLOJCIDKHCG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct JKOJEGEIJCF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private EntityManager EDIIKMBGJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private NativeArray<Entity> CCIGPBFJEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int KDCAMOIGIMA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x4BF6CC0", Offset = "0x4BF60C0", VA = "0x184BF6CC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4BF6D60", Offset = "0x4BF6160", VA = "0x184BF6D60")]
		public JKOJEGEIJCF(NativeArray<Entity> CCIGPBFJEAO, EntityManager EDIIKMBGJIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4BF6D50", Offset = "0x4BF6150", VA = "0x184BF6D50")]
		public bool OPMFPOJCPHB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x341B8F0", Offset = "0x341ACF0", VA = "0x18341B8F0")]
		public JKOJEGEIJCF<T> NHFIHKFCIDL()
		{
			return default(JKOJEGEIJCF<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct IANAPCKILFB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private EntityManager EDIIKMBGJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private NativeArray<Entity> CCIGPBFJEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int KDCAMOIGIMA;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x37A0860", Offset = "0x379FC60", VA = "0x1837A0860")]
	public static JKOJEGEIJCF<T> MBJPJOEOCDB<T>(this NativeList<Entity> NNBDIDMOBNM, EntityManager EDIIKMBGJIA) where T : class
	{
		return default(JKOJEGEIJCF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37A0820", Offset = "0x379FC20", VA = "0x1837A0820")]
	public static JKOJEGEIJCF<T> MBJPJOEOCDB<T>(this NativeArray<Entity> NNBDIDMOBNM, EntityManager EDIIKMBGJIA) where T : class
	{
		return default(JKOJEGEIJCF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x37A0550", Offset = "0x379F950", VA = "0x1837A0550")]
	public static NativeArray<TKey> KDDGGCJJDEO<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> JAIBFAIMPCH, Allocator LENIJMBFHJK, [Out] int GMJMELDMDFM) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default(NativeArray<TKey>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37A0920", Offset = "0x379FD20", VA = "0x1837A0920")]
	public static NativeParallelHashMap<TKey, TValue> PAJMFLHKNMP<TKey, TValue>(this NativeArray<TKey> MKCLAIOIKNO, NativeArray<TValue> EDJBENPLFOA, Allocator LENIJMBFHJK) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(NativeParallelHashMap<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37A0440", Offset = "0x379F840", VA = "0x1837A0440")]
	public static NativeParallelHashSet<T> GLOPMBPMPMN<T>(this NativeArray<T> HDDHAKEIJGE, AllocatorManager.AllocatorHandle LENIJMBFHJK) where T : struct, IEquatable<T>
	{
		return default(NativeParallelHashSet<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37A04D0", Offset = "0x379F8D0", VA = "0x1837A04D0")]
	public static NativeParallelHashSet<T> GLOPMBPMPMN<T>(this NativeList<T> HDDHAKEIJGE, AllocatorManager.AllocatorHandle LENIJMBFHJK) where T : struct, IEquatable<T>
	{
		return default(NativeParallelHashSet<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x37A0750", Offset = "0x379FB50", VA = "0x1837A0750")]
	public static void LLICHLCEEGA<T1, T2>(this NativeParallelHashMap<T1, T2> EBAHFMPNPGP, NativeArray<T1> MKCLAIOIKNO, NativeArray<T2> EDJBENPLFOA) where T1 : struct, IEquatable<T1> where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37A05F0", Offset = "0x379F9F0", VA = "0x1837A05F0")]
	public static void KGKDCLGKMAN<TKey, TValue>(this KeyValue<TKey, TValue> JFJPEDLJOKC, [Out] TKey MCBJECJLDOM, [Out] TValue FIIKLGCIAGG) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x78238F0", Offset = "0x7822CF0", VA = "0x1878238F0")]
	public static NativeArray<Entity> OOKBHDJJKED(this NativeParallelHashMap<Entity, Entity> JMDDLLHBMEE, NativeArray<Entity> PFADBNAMCKA, Allocator LENIJMBFHJK)
	{
		return default(NativeArray<Entity>);
	}
}
namespace _LogRegistration.RecRoom_Foundation_Entities_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x78237F0", Offset = "0x7822BF0", VA = "0x1878237F0", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[NativeContainer]
	public struct BufferFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly bool m_IsReadOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int m_InternalCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Unity.Entities.LookupCache m_Cache;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int TypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xD074A0", Offset = "0xD068A0", VA = "0x180D074A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DynamicBuffer this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x78159D0", Offset = "0x7814DD0", VA = "0x1878159D0")]
			get
			{
				return default(DynamicBuffer);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x78158F0", Offset = "0x7814CF0", VA = "0x1878158F0")]
		internal unsafe BufferFromEntity(int typeIndex, Unity.Entities.EntityDataAccess* access, bool isReadOnly)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[NativeContainerSupportsMinMaxWriteRestriction]
	[NativeContainer]
	public struct ComponentTypeHandle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal readonly bool m_IsReadOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal readonly bool m_IsZeroSized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly int m_Length;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7816060", Offset = "0x7815460", VA = "0x187816060")]
		internal ComponentTypeHandle(int typeIndex, bool isReadOnly, uint globalSystemVersion)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[BurstCompatible]
	public readonly struct ComponentTypeIndex : IEquatable<ComponentTypeIndex>, IComparable<ComponentTypeIndex>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int typeIndex;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
		public ComponentTypeIndex(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1FF4240", Offset = "0x1FF3640", VA = "0x181FF4240", Slot = "4")]
		public bool Equals(ComponentTypeIndex other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x426D850", Offset = "0x426CC50", VA = "0x18426D850", Slot = "5")]
		public int CompareTo(ComponentTypeIndex other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x78160F0", Offset = "0x78154F0", VA = "0x1878160F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2C6A520", Offset = "0x2C69920", VA = "0x182C6A520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7816180", Offset = "0x7815580", VA = "0x187816180", Slot = "3")]
		[NotBurstCompatible]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1D17060", Offset = "0x1D16460", VA = "0x181D17060")]
		public static implicit operator int(ComponentTypeIndex x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1D17060", Offset = "0x1D16460", VA = "0x181D17060")]
		public static implicit operator ComponentTypeIndex(int x)
		{
			return default(ComponentTypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1D17060", Offset = "0x1D16460", VA = "0x181D17060")]
		public static implicit operator ComponentTypeIndex(ComponentType type)
		{
			return default(ComponentTypeIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1FF4260", Offset = "0x1FF3660", VA = "0x181FF4260")]
		public static bool operator ==(ComponentTypeIndex a, ComponentTypeIndex b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x33F12E0", Offset = "0x33F06E0", VA = "0x1833F12E0")]
		public static ComponentTypeIndex From<T>()
		{
			return default(ComponentTypeIndex);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct ComponentTypeList : IEnumerable<ComponentType>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private ComponentTypes32 types;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<int> componentTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private bool isDirty;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7816F10", Offset = "0x7816310", VA = "0x187816F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IEnumerable<ComponentType> ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7816DC0", Offset = "0x78161C0", VA = "0x187816DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x78167F0", Offset = "0x7815BF0", VA = "0x1878167F0")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7816730", Offset = "0x7815B30", VA = "0x187816730")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7816CE0", Offset = "0x78160E0", VA = "0x187816CE0")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7816AC0", Offset = "0x7815EC0", VA = "0x187816AC0")]
		public ComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x78161B0", Offset = "0x78155B0", VA = "0x1878161B0")]
		public void Add(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7816860", Offset = "0x7815C60", VA = "0x187816860")]
		public void Remove(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x78163D0", Offset = "0x78157D0", VA = "0x1878163D0")]
		private void DistinctSort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7816F90", Offset = "0x7816390", VA = "0x187816F90")]
		public static ComponentTypeList operator -(ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x78168F0", Offset = "0x7815CF0", VA = "0x1878168F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x78167A0", Offset = "0x7815BA0", VA = "0x1878167A0", Slot = "4")]
		public IEnumerator<ComponentType> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x78167A0", Offset = "0x7815BA0", VA = "0x1878167A0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct ComponentTypes32
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public struct Masks
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public uint m_BufferMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public uint m_SystemStateComponentMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public uint m_SharedComponentMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public uint m_ZeroSizedMask;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FixedList128Bytes<int> m_sorted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Masks m_masks;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x78176A0", Offset = "0x7816AA0", VA = "0x1878176A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public readonly IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x78176E0", Offset = "0x7816AE0", VA = "0x1878176E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7817540", Offset = "0x7816940", VA = "0x187817540")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x78175C0", Offset = "0x78169C0", VA = "0x1878175C0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7817030", Offset = "0x7816430", VA = "0x187817030")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7817350", Offset = "0x7816750", VA = "0x187817350")]
		public void Remove(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x78173A0", Offset = "0x78167A0", VA = "0x1878173A0")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x78172B0", Offset = "0x78166B0", VA = "0x1878172B0")]
		public readonly int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x78171D0", Offset = "0x78165D0", VA = "0x1878171D0")]
		public readonly ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x78173F0", Offset = "0x78167F0", VA = "0x1878173F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7817080", Offset = "0x7816480", VA = "0x187817080")]
		private void ComputeMasks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[NativeContainer]
	public struct ArchetypeChunkFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ArchetypeChunk this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7815520", Offset = "0x7814920", VA = "0x187815520")]
			get
			{
				return default(ArchetypeChunk);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50")]
		internal unsafe ArchetypeChunkFromEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7815360", Offset = "0x7814760", VA = "0x187815360")]
		public EntityInChunk GetEntityInChunk(Entity entity)
		{
			return default(EntityInChunk);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x78151D0", Offset = "0x78145D0", VA = "0x1878151D0")]
		public ArchetypeChunk GetArchetypeChunkAndIndex(Entity entity, [Out] int index)
		{
			return default(ArchetypeChunk);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x78152B0", Offset = "0x78146B0", VA = "0x1878152B0")]
		public UnsafeUntypedBufferAccessor GetBufferAccessorAndIndex(Entity entity, DynamicComponentTypeHandle chunkBufferTypeHandle, [Out] int indexInChunk)
		{
			return default(UnsafeUntypedBufferAccessor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x78150C0", Offset = "0x78144C0", VA = "0x1878150C0")]
		public unsafe bool CopyToEntity(Entity entity, DynamicComponentTypeHandle chunkBufferTypeHandle, void* srcPtr, int srcElementCount, int srcBufferSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7815410", Offset = "0x7814810", VA = "0x187815410")]
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
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public EntityArchetype this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x78155E0", Offset = "0x78149E0", VA = "0x1878155E0")]
			get
			{
				return default(EntityArchetype);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50")]
		internal unsafe ArchetypeFromEntity(Unity.Entities.EntityDataAccess* access)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[NativeContainer]
	public struct ComponentDataFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly int m_TypeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Unity.Entities.LookupCache m_Cache;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int TypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xD074A0", Offset = "0xD068A0", VA = "0x180D074A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NativeArray<byte> this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7815D40", Offset = "0x7815140", VA = "0x187815D40")]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7815E50", Offset = "0x7815250", VA = "0x187815E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7815C80", Offset = "0x7815080", VA = "0x187815C80")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7815B00", Offset = "0x7814F00", VA = "0x187815B00")]
		public bool HasComponent(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7815BA0", Offset = "0x7814FA0", VA = "0x187815BA0")]
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
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50")]
		internal unsafe EntityExistenceLookupByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x781D720", Offset = "0x781CB20", VA = "0x18781D720")]
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
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50")]
		internal unsafe HasComponentByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7823400", Offset = "0x7822800", VA = "0x187823400")]
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
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly int m_TypeIndex;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x551C1C0", Offset = "0x551B5C0", VA = "0x18551C1C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x551C1B0", Offset = "0x551B5B0", VA = "0x18551C1B0")]
		internal unsafe SharedComponentIndexFromEntity(int typeIndex, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x551C030", Offset = "0x551B430", VA = "0x18551C030")]
		public bool TryGetSharedComponentIndex(Entity entity, [Out] int sharedIndex)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[JobProducerType(typeof(JobEntityBatchTwoQueryExtensions.JobEntityBatchTwoQueryProducer<>))]
	public interface IJobEntityBatchTwoQuery
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Execute(ArchetypeChunk batchInChunk, int batchIndex);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum ScheduleGranularity
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		Chunk,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Entity
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class JobEntityBatchTwoQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		internal struct JobEntityBatchWrapper<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public T JobData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public Unity.Entities.UnsafeMatchingArchetypePtrList MatchingArchetypes0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Unity.Entities.UnsafeCachedChunkList CachedChunks0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public Unity.Entities.EntityQueryFilter Filter0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Unity.Entities.UnsafeMatchingArchetypePtrList MatchingArchetypes1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public Unity.Entities.UnsafeCachedChunkList CachedChunks1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public Unity.Entities.EntityQueryFilter Filter1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public int IsParallel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public int SkipSubChunkBatching0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public int SkipSubChunkBatching1;
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal struct JobEntityBatchTwoQueryProducer<T> where T : struct, IJobEntityBatchTwoQuery
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public delegate void ExecuteJobFunction(JobEntityBatchWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex);

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			internal static readonly SharedStatic<IntPtr> reflectionData;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4C49460", Offset = "0x4C48860", VA = "0x184C49460")]
			[UnityEngine.Scripting.Preserve]
			internal static void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x4C1FCC0", Offset = "0x4C1F0C0", VA = "0x184C1FCC0")]
			public static void Execute(JobEntityBatchWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4C48FC0", Offset = "0x4C483C0", VA = "0x184C48FC0")]
			[SkipLocalsInit]
			internal static void ExecuteInternal(JobEntityBatchWrapper<T> jobWrapper, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3659AE0", Offset = "0x3658EE0", VA = "0x183659AE0")]
		public static void EarlyJobInit<T>() where T : struct, IJobEntityBatchTwoQuery
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[BurstCompile]
	internal struct DummyJobEntityBatchTwoQuery : IJobEntityBatchTwoQuery
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
		public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[BurstCompile]
	internal static class DummyJobEntityBatchTwoQueryScheduler
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct DeferredEntityCommandBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private NativeList<byte> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeParallelHashMap<Entity, EntityModification> entityModifications;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private EntityManager entityManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Allocator allocator;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x781CE60", Offset = "0x781C260", VA = "0x18781CE60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x781CDA0", Offset = "0x781C1A0", VA = "0x18781CDA0")]
		public DeferredEntityCommandBuffer(EntityManager entityManager, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x781BBB0", Offset = "0x781AFB0", VA = "0x18781BBB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x781C060", Offset = "0x781B460", VA = "0x18781C060")]
		public void Playback(EntityModification.TrySetPrefabDataType trySetPrefabDataType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x342C7F0", Offset = "0x342BBF0", VA = "0x18342C7F0")]
		public bool HasComponent<T>(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x781BF90", Offset = "0x781B390", VA = "0x18781BF90")]
		public bool HasComponent(Entity entity, ComponentType componentType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x342CF10", Offset = "0x342C310", VA = "0x18342CF10")]
		public bool TryGetComponent<T>(Entity entity, [Out] T value) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x342AFA0", Offset = "0x342A3A0", VA = "0x18342AFA0")]
		public void AddBuffer<T>(Entity entity, NativeArray<T> array) where T : struct, IBufferElementData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x781C820", Offset = "0x781BC20", VA = "0x18781C820")]
		private void UnsafeAddBuffer(Entity entity, ComponentType componentType, int alignment, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x342BB20", Offset = "0x342AF20", VA = "0x18342BB20")]
		public void AddComponent<T>(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x781B4F0", Offset = "0x781A8F0", VA = "0x18781B4F0")]
		public void AddComponent(Entity entity, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x342BBB0", Offset = "0x342AFB0", VA = "0x18342BBB0")]
		public void AddComponent<T>(NativeArray<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x781B570", Offset = "0x781A970", VA = "0x18781B570")]
		public void AddComponent(NativeArray<Entity> entities, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x342BD80", Offset = "0x342B180", VA = "0x18342BD80")]
		public void AddOrSetComponent<T>(Entity entity, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x781B6C0", Offset = "0x781AAC0", VA = "0x18781B6C0")]
		public void AddOrSetComponent(NativeArray<Entity> entities, ComponentType componentType, int align, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x781B8A0", Offset = "0x781ACA0", VA = "0x18781B8A0")]
		public void AddOrSetComponent(Entity entity, ComponentType componentType, int alignment, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x781C8C0", Offset = "0x781BCC0", VA = "0x18781C8C0")]
		private void UnsafeAddOrSetComponent(Entity entity, ComponentType componentType, int alignment, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x781CB30", Offset = "0x781BF30", VA = "0x18781CB30")]
		private void UnsafeAddOrSetComponent(Entity entity, ComponentType componentType, JMJNMGPMDKG range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x342CAE0", Offset = "0x342BEE0", VA = "0x18342CAE0")]
		public void RemoveComponent<T>(Entity entity) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x342C9A0", Offset = "0x342BDA0", VA = "0x18342C9A0")]
		public void RemoveComponent<T>(NativeArray<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x781C500", Offset = "0x781B900", VA = "0x18781C500")]
		public void RemoveComponent(NativeArray<Entity> entities, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x781C640", Offset = "0x781BA40", VA = "0x18781C640")]
		public void RemoveComponent(Entity entity, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x342C6C0", Offset = "0x342BAC0", VA = "0x18342C6C0")]
		public void AddOrSetSharedComponent<T>(Entity entity, T value) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x781B940", Offset = "0x781AD40", VA = "0x18781B940")]
		private void AddOrSetSharedComponent(Entity entity, ComponentType componentType, int alignment, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x781BEE0", Offset = "0x781B2E0", VA = "0x18781BEE0")]
		private EntityModification GetOrAddModification(Entity entity)
		{
			return default(EntityModification);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}")]
	[NativeContainer]
	[DebuggerTypeProxy(typeof(DynamicBufferDebugView))]
	[DefaultMember("Item")]
	public struct DynamicBuffer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[NoAlias]
		[NativeDisableUnsafePtrRestriction]
		private unsafe Unity.Entities.BufferHeader* m_Buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int m_ElementSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int m_AlignmentInBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int m_InternalCapacity;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x41D34D0", Offset = "0x41D28D0", VA = "0x1841D34D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x781D4D0", Offset = "0x781C8D0", VA = "0x18781D4D0")]
		internal unsafe DynamicBuffer(Unity.Entities.BufferHeader* header, int typeIndex, int internalCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x781D0B0", Offset = "0x781C4B0", VA = "0x18781D0B0")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckBounds(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x781D380", Offset = "0x781C780", VA = "0x18781D380")]
		public ReadOnlySpan<byte> ElementAt(int index)
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x781D470", Offset = "0x781C870", VA = "0x18781D470")]
		public void ResizeUninitialized(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x781D430", Offset = "0x781C830", VA = "0x18781D430")]
		public void EnsureCapacity(int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x41CCDB0", Offset = "0x41CC1B0", VA = "0x1841CCDB0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x781CF30", Offset = "0x781C330", VA = "0x18781CF30")]
		public void AddRange(ReadOnlySpan<byte> srcSpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x781D020", Offset = "0x781C420", VA = "0x18781D020")]
		public NativeArray<byte> AsNativeArray()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x781D190", Offset = "0x781C590", VA = "0x18781D190")]
		public void CopyFrom(NativeArray<byte> v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x781D2D0", Offset = "0x781C6D0", VA = "0x18781D2D0")]
		public void CopyFrom(DynamicBuffer v)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal sealed class DynamicBufferDebugView
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct EntityModification : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool TrySetPrefabDataType(EntityManager em, Entity entity, ComponentTypeIndex componentTypeIndex, ReadOnlySpan<byte> data);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private UnsafeParallelHashMap<ComponentTypeIndex, JMJNMGPMDKG> addedComponents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private UnsafeParallelHashSet<ComponentTypeIndex> removedComponents;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x78211F0", Offset = "0x78205F0", VA = "0x1878211F0")]
		public EntityModification(Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x78210A0", Offset = "0x78204A0", VA = "0x1878210A0")]
		public bool HasComponent(EntityManager em, Entity entity, ComponentType componentType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7820A20", Offset = "0x781FE20", VA = "0x187820A20")]
		public void AddOrSetComponent(NativeList<byte> componentsData, ComponentType componentType, int align, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x78209A0", Offset = "0x781FDA0", VA = "0x1878209A0")]
		public void AddOrSetComponent(ComponentType componentType, JMJNMGPMDKG range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7821180", Offset = "0x7820580", VA = "0x187821180")]
		public void RemoveComponent(ComponentType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x34A8670", Offset = "0x34A7A70", VA = "0x1834A8670")]
		public bool TryGetComponent<T>(NativeList<byte> componentsData, EntityManager em, Entity entity, [Out] T value) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7820B40", Offset = "0x781FF40", VA = "0x187820B40")]
		public void AddOrSetSharedComponent(NativeList<byte> componentsData, ComponentType componentType, int align, ReadOnlySpan<byte> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7820FC0", Offset = "0x78203C0", VA = "0x187820FC0")]
		public NativeArray<ComponentTypeIndex> GetAddedComponentTypes(Allocator allocator)
		{
			return default(NativeArray<ComponentTypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7821030", Offset = "0x7820430", VA = "0x187821030")]
		public NativeArray<ComponentTypeIndex> GetRemovedComponentTypes(Allocator allocator)
		{
			return default(NativeArray<ComponentTypeIndex>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7820B80", Offset = "0x781FF80", VA = "0x187820B80")]
		public void ApplyAddedComponents(NativeArray<byte> componentsData, EntityManager em, Entity entity, TrySetPrefabDataType trySetPrefabDataType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7820F60", Offset = "0x7820360", VA = "0x187820F60", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x78217D0", Offset = "0x7820BD0", VA = "0x1878217D0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, ComponentSystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x78218B0", Offset = "0x7820CB0", VA = "0x1878218B0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x78219A0", Offset = "0x7820DA0", VA = "0x1878219A0")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7821BA0", Offset = "0x7820FA0", VA = "0x187821BA0")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7821A90", Offset = "0x7820E90", VA = "0x187821A90")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7821B80", Offset = "0x7820F80", VA = "0x187821B80")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7821C90", Offset = "0x7821090", VA = "0x187821C90")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x78214F0", Offset = "0x78208F0", VA = "0x1878214F0")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x34BB000", Offset = "0x34BA400", VA = "0x1834BB000")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x34BAF40", Offset = "0x34BA340", VA = "0x1834BAF40")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x34BAF40", Offset = "0x34BA340", VA = "0x1834BAF40")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x34BAF40", Offset = "0x34BA340", VA = "0x1834BAF40")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x34BAF40", Offset = "0x34BA340", VA = "0x1834BAF40")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x34BAF40", Offset = "0x34BA340", VA = "0x1834BAF40")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4, T5>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x34BAF80", Offset = "0x34BA380", VA = "0x1834BAF80")]
		public static EntityQueryDesc WithAny<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x34BAF80", Offset = "0x34BA380", VA = "0x1834BAF80")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x34BAFC0", Offset = "0x34BA3C0", VA = "0x1834BAFC0")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x34BAFC0", Offset = "0x34BA3C0", VA = "0x1834BAFC0")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x34BAFC0", Offset = "0x34BA3C0", VA = "0x1834BAFC0")]
		public static EntityQueryDesc WithNone<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x34BAF40", Offset = "0x34BA340", VA = "0x1834BAF40")]
		public static EntityQueryDesc WithAllRO<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x34BAF40", Offset = "0x34BA340", VA = "0x1834BAF40")]
		public static EntityQueryDesc WithAllRO<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x34BAF40", Offset = "0x34BA340", VA = "0x1834BAF40")]
		public static EntityQueryDesc WithAllRO<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x34BAF80", Offset = "0x34BA380", VA = "0x1834BAF80")]
		public static EntityQueryDesc WithAnyRO<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x34BAF80", Offset = "0x34BA380", VA = "0x1834BAF80")]
		public static EntityQueryDesc WithAnyRO<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x34B4680", Offset = "0x34B3A80", VA = "0x1834B4680")]
		private static ComponentType[] ExpandRW<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x34B4B60", Offset = "0x34B3F60", VA = "0x1834B4B60")]
		private static ComponentType[] ExpandRW<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x34B47A0", Offset = "0x34B3BA0", VA = "0x1834B47A0")]
		private static ComponentType[] ExpandRW<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x34B74D0", Offset = "0x34B68D0", VA = "0x1834B74D0")]
		private static ComponentType[] ExpandRW<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x34B9D80", Offset = "0x34B9180", VA = "0x1834B9D80")]
		private static ComponentType[] ExpandRW<T1, T2, T3, T4, T5>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x34ADF00", Offset = "0x34AD300", VA = "0x1834ADF00")]
		private static ComponentType[] ExpandRO<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x34AE1D0", Offset = "0x34AD5D0", VA = "0x1834AE1D0")]
		private static ComponentType[] ExpandRO<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x34B38D0", Offset = "0x34B2CD0", VA = "0x1834B38D0")]
		private static ComponentType[] ExpandRO<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7821700", Offset = "0x7820B00", VA = "0x187821700")]
		private static ComponentType[] Combine(ComponentType[] a, ComponentType[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate void EntityQueryDescBuilderInit(EntityQueryDescBuilder builder);
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class EntityQueryDescBuilderExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class ArchetypeChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3DAF6A0", Offset = "0x3DAEAA0", VA = "0x183DAF6A0")]
		public static ManagedComponentAccessor<T> GetManagedComponentAccessor<T>(this ArchetypeChunk chunk, ComponentTypeHandle<T> componentTypeHandle, EntityQuery query) where T : class
		{
			return default(ManagedComponentAccessor<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class ArchetypeExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class ChunkIterationUtilityEx
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class DebugEntityInfoExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x781B380", Offset = "0x781A780", VA = "0x18781B380")]
		public static void DebugLogEntityInfo(this EntityManager entityManager, Entity entity, int maxDepth = 3, string componentSeparator = "\n    ")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x781B2C0", Offset = "0x781A6C0", VA = "0x18781B2C0")]
		public static string DebugGetEntityInfo(this EntityManager entityManager, Entity entity, int maxDepth = 3, string componentSeparator = "\n    ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x781A2B0", Offset = "0x78196B0", VA = "0x18781A2B0")]
		private static void DebugAppendEntityInfo(this EntityManager entityManager, Entity entity, StringBuilder str, int maxDepth, string componentSeparator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x781A270", Offset = "0x7819670", VA = "0x18781A270")]
		private static void DebugAppendComponentInfo(EntityManager entityManager, Entity entity, ComponentType componentType, StringBuilder str, int maxDepth, string leafPrefix = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x781A7F0", Offset = "0x7819BF0", VA = "0x18781A7F0")]
		private static void DebugAppendObjectInfo(object obj, int maxDepth, StringBuilder str, string leafPrefix = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x781B000", Offset = "0x781A400", VA = "0x18781B000")]
		public static object DebugGetComponentBoxed(this EntityManager entityManager, Entity entity, ComponentType componentType)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class DynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3430CA0", Offset = "0x34300A0", VA = "0x183430CA0")]
		public static bool Contains<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3430D20", Offset = "0x3430120", VA = "0x183430D20")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3431450", Offset = "0x3430850", VA = "0x183431450")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3431330", Offset = "0x3430730", VA = "0x183431330")]
		public static void RemoveAllSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x34313C0", Offset = "0x34307C0", VA = "0x1834313C0")]
		public static void RemoveSetSwapBack<T>(this DynamicBuffer<T> buffer, NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3430CE0", Offset = "0x34300E0", VA = "0x183430CE0")]
		public static bool Contains<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3431140", Offset = "0x3430540", VA = "0x183431140")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3430F00", Offset = "0x3430300", VA = "0x183430F00")]
		public static int IndexOf<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x34314D0", Offset = "0x34308D0", VA = "0x1834314D0")]
		public static bool Remove<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3431550", Offset = "0x3430950", VA = "0x183431550")]
		public static bool Remove<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public struct ComponentTypeEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private EntityArchetype archetype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public ComponentType Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x7815FE0", Offset = "0x78153E0", VA = "0x187815FE0")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x7815FC0", Offset = "0x78153C0", VA = "0x187815FC0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public ComponentType this[int i]
			{
				[Cpp2IlInjected.Token(Token = "0x60000D7")]
				[Cpp2IlInjected.Address(RVA = "0x7816020", Offset = "0x7815420", VA = "0x187816020")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7815FA0", Offset = "0x78153A0", VA = "0x187815FA0")]
			internal ComponentTypeEnumerator(EntityArchetype arch, bool includeEntity = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x4D46F60", Offset = "0x4D46360", VA = "0x184D46F60")]
			public ComponentTypeEnumerator GetEnumerator()
			{
				return default(ComponentTypeEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7815F70", Offset = "0x7815370", VA = "0x187815F70")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public struct AddEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private AddRemoveEnumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public ComponentType Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x7814E90", Offset = "0x7814290", VA = "0x187814E90")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7814E00", Offset = "0x7814200", VA = "0x187814E00")]
			internal unsafe AddEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x43651E0", Offset = "0x43645E0", VA = "0x1843651E0")]
			public AddEnumerator GetEnumerator()
			{
				return default(AddEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7814D80", Offset = "0x7814180", VA = "0x187814D80")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public struct RemoveEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private AddRemoveEnumerator enumerator;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public struct AddRemoveEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private unsafe Unity.Entities.ComponentTypeInArchetype* srcTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private unsafe Unity.Entities.ComponentTypeInArchetype* dstTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int srcLen;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private int dstLen;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private ComponentType componentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private bool existsInDstNotInSrc;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public (ComponentType component, bool existsInDstNotInSrc) Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x7815060", Offset = "0x7814460", VA = "0x187815060")]
				get
				{
					return default((ComponentType, bool));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7815010", Offset = "0x7814410", VA = "0x187815010")]
			internal unsafe AddRemoveEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7814EF0", Offset = "0x78142F0", VA = "0x187814EF0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x781D6F0", Offset = "0x781CAF0", VA = "0x18781D6F0")]
		public static EntityArchetype GetInstantiateArchetype(this EntityArchetype archetype)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x781D570", Offset = "0x781C970", VA = "0x18781D570")]
		public static ComponentTypeEnumerator EnumerateComponentTypes(this EntityArchetype archetype, bool includeEntity = false)
		{
			return default(ComponentTypeEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x781D590", Offset = "0x781C990", VA = "0x18781D590")]
		public static Span<int> GetAllTypeIndices(this EntityArchetype archetype)
		{
			return default(Span<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x781D6D0", Offset = "0x781CAD0", VA = "0x18781D6D0")]
		public static int GetEntityCount(this EntityArchetype archetype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x781D630", Offset = "0x781CA30", VA = "0x18781D630")]
		public static AddEnumerator GetComponentsToAdd(this EntityArchetype src, EntityArchetype dst)
		{
			return default(AddEnumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class EntityCommandBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x345B2C0", Offset = "0x345A6C0", VA = "0x18345B2C0")]
		public static void SetComponentData<T>(this EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x345B440", Offset = "0x345A840", VA = "0x18345B440")]
		public static void SetComponentData<T>(this EntityCommandBuffer.ParallelWriter ecb, int sortKey, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class ArchetypeIteratorExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7815690", Offset = "0x7814A90", VA = "0x187815690")]
		public static int GetSharedComponentIndex(this ArchetypeChunkIterator it, int typeIndex)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class EntityManagerArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x781D7B0", Offset = "0x781CBB0", VA = "0x18781D7B0")]
		public static EntityArchetype CreateArchetypeWithAdditionalComponents(this EntityManager entityManager, EntityArchetype srcArchetype, NativeArray<int> typeIndices)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x781DB30", Offset = "0x781CF30", VA = "0x18781DB30")]
		public static EntityArchetype CreateArchetypeWithModifiedComponents(this EntityManager entityManager, EntityArchetype srcArchetype, NativeArray<int> adds, NativeArray<int> removes)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x781E220", Offset = "0x781D620", VA = "0x18781E220")]
		public static bool MoveToNextChunkWithEntity(this ArchetypeChunkIterator it, [Out] Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x781E140", Offset = "0x781D540", VA = "0x18781E140")]
		public static EntityArchetype GetArchetype(this EntityManager entityManager, Entity entity)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x781E0A0", Offset = "0x781D4A0", VA = "0x18781E0A0")]
		public static int GetArchetypeCount(this EntityManager entityManager)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class EntityManagerArchetypeFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x781E2F0", Offset = "0x781D6F0", VA = "0x18781E2F0")]
		public static ArchetypeFromEntity GetArchetypeFromEntity(this EntityManager entityManager)
		{
			return default(ArchetypeFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x781E2A0", Offset = "0x781D6A0", VA = "0x18781E2A0")]
		public static ArchetypeChunkFromEntity GetArchetypeChunkFromEntity(this EntityManager entityManager)
		{
			return default(ArchetypeChunkFromEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class EntityManagerAssertionExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class EntityManagerBufferFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x781E340", Offset = "0x781D740", VA = "0x18781E340")]
		public static BufferFromEntity GetBufferFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(BufferFromEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class EntityManagerChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x781E3D0", Offset = "0x781D7D0", VA = "0x18781E3D0")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(this EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x781E420", Offset = "0x781D820", VA = "0x18781E420")]
		public static NativeArray<ArchetypeChunk> GetChunks(this EntityManager em, NativeArray<Entity> entities, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<ArchetypeChunk>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class EntityManagerComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[BurstCompile]
		private struct SetComponentDataArrayFromArrayJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[ReadOnly]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[ReadOnly]
			public NativeArray<byte> src;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public ComponentDataFromEntity dst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public int typeSize;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x78247D0", Offset = "0x7823BD0", VA = "0x1878247D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[BurstCompile]
		private struct SetComponentDataArrayFromValueJob<T> : IJob where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[WriteOnly]
			public ComponentDataFromEntity<T> dstArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x550F650", Offset = "0x550EA50", VA = "0x18550F650", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[BurstCompile]
		private struct SetComponentDataArrayFromValueJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[ReadOnly]
			public NativeArray<byte> value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[WriteOnly]
			public ComponentDataFromEntity dstArray;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x78248A0", Offset = "0x7823CA0", VA = "0x1878248A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[BurstCompile]
		internal struct SetComponentDataChunkJob<T> : IJobChunk where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public ComponentTypeHandle<T> componentArrayType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x347E280", Offset = "0x347D680", VA = "0x18347E280")]
		public static bool TrySetComponentData<T>(this EntityManager entityManager, Entity entity, T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x781EC00", Offset = "0x781E000", VA = "0x18781EC00")]
		public unsafe static bool TryGetComponentDataRawRW(this EntityManager entityManager, Entity entity, int typeIndex, [Out] void* ptr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x781EAE0", Offset = "0x781DEE0", VA = "0x18781EAE0")]
		public unsafe static bool TryGetComponentDataRawRO(this EntityManager entityManager, Entity entity, int typeIndex, [Out] void* ptr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3478D40", Offset = "0x3478140", VA = "0x183478D40")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3476220", Offset = "0x3475620", VA = "0x183476220")]
		public static T GetComponentDataOrDefault<T>(this EntityManager entityManager, Entity entity, [Optional] T defaultValue) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3476370", Offset = "0x3475770", VA = "0x183476370")]
		public static NativeArray<T> GetComponentDataOrDefault<T>(this EntityManager entityManager, NativeArray<Entity> entities, Allocator allocator, [Optional] T defaultValue) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3478B60", Offset = "0x3477F60", VA = "0x183478B60")]
		public static bool TryGetComponentDataField<TComponent, TValue>(this EntityManager entityManager, Entity entity, Func<TComponent, TValue> func, [Out] TValue value) where TComponent : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x34765B0", Offset = "0x34759B0", VA = "0x1834765B0")]
		public static RefRW<T> GetComponentDataRefRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IComponentData
		{
			return default(RefRW<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x781E6C0", Offset = "0x781DAC0", VA = "0x18781E6C0")]
		public static void SetComponentData(this EntityManager entityManager, Entity entity, int typeIndex, NativeArray<byte> src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x781E8D0", Offset = "0x781DCD0", VA = "0x18781E8D0")]
		public static void SetComponentData(this EntityManager entityManager, ComponentType type, NativeArray<Entity> entities, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3476960", Offset = "0x3475D60", VA = "0x183476960")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3478530", Offset = "0x3477930", VA = "0x183478530")]
		public static void SetTag<T>(this EntityManager entityManager, Entity entity, bool isTagSet) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3476870", Offset = "0x3475C70", VA = "0x183476870")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x781E510", Offset = "0x781D910", VA = "0x18781E510")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		public static void AssertMatchingSize(int typeIndex, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		public static void AssertIsComponentData(int typeIndex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class EntityManagerComponentDataFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x781ED30", Offset = "0x781E130", VA = "0x18781ED30")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x347ED30", Offset = "0x347E130", VA = "0x18347ED30")]
		public static SharedComponentIndexFromEntity<T> GetSharedComponentIndexFromEntity<T>(this EntityManager entityManager) where T : ISharedComponentData
		{
			return default(SharedComponentIndexFromEntity<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class EntityManagerComponentObjectExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x347F230", Offset = "0x347E630", VA = "0x18347F230")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x347F2D0", Offset = "0x347E6D0", VA = "0x18347F2D0")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, [Out] T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x347F020", Offset = "0x347E420", VA = "0x18347F020")]
		public static void AddComponentObject<T>(this EntityManager entityManager, NativeArray<Entity> entities, MKPOFIPENHI<T> componentArray) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x347EF70", Offset = "0x347E370", VA = "0x18347EF70")]
		public static void AddAndSetComponentObject<T>(this EntityManager entityManager, Entity entity, T value) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class EntityManagerComponentOrderExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class EntityManagerCreateEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x781EDE0", Offset = "0x781E1E0", VA = "0x18781EDE0")]
		public static Entity CopyEntity(this EntityManager entityManager, Entity srcEntity)
		{
			return default(Entity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class EntityManagerDependencyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x781F3D0", Offset = "0x781E7D0", VA = "0x18781F3D0")]
		public static void CompleteReadAndWriteDependency(this EntityManager entityManager, ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x347F3A0", Offset = "0x347E7A0", VA = "0x18347F3A0")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x347F470", Offset = "0x347E870", VA = "0x18347F470")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x781F550", Offset = "0x781E950", VA = "0x18781F550")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x781F460", Offset = "0x781E860", VA = "0x18781F460")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, ReadOnlySpan<int> typeIndices)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x781F7C0", Offset = "0x781EBC0", VA = "0x18781F7C0")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x781F6D0", Offset = "0x781EAD0", VA = "0x18781F6D0")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, ReadOnlySpan<int> typeIndices)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x781EEB0", Offset = "0x781E2B0", VA = "0x18781EEB0")]
		public static JobHandle AddReadDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x781F040", Offset = "0x781E440", VA = "0x18781F040")]
		public static JobHandle AddReadDependency(this EntityManager entityManager, ReadOnlySpan<int> typeIndices, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x781F260", Offset = "0x781E660", VA = "0x18781F260")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x781F150", Offset = "0x781E550", VA = "0x18781F150")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, Span<int> typeIndices, JobHandle handle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class EntityManagerDynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x781FCE0", Offset = "0x781F0E0", VA = "0x18781FCE0")]
		public static bool TryGetBuffer(this EntityManager entityManager, Entity entity, int typeIndex, [Out] DynamicBuffer buffer, bool isReadOnly = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x781F940", Offset = "0x781ED40", VA = "0x18781F940")]
		public static DynamicBuffer GetBuffer(this EntityManager entityManager, Entity entity, int typeIndex, bool isReadOnly = false)
		{
			return default(DynamicBuffer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x781F9E0", Offset = "0x781EDE0", VA = "0x18781F9E0")]
		private unsafe static DynamicBuffer GetBuffer(Unity.Entities.EntityDataAccess* access, Entity entity, int typeIndex, bool isReadOnly = false)
		{
			return default(DynamicBuffer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x347FB00", Offset = "0x347EF00", VA = "0x18347FB00")]
		public static bool TryGetBufferAsRW<T>(this EntityManager entityManager, Entity entity, int typeIndex, [Out] DynamicBuffer<T> buffer) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x347F830", Offset = "0x347EC30", VA = "0x18347F830")]
		public static DynamicBuffer<T> GetBufferAsRW<T>(this EntityManager entityManager, Entity entity, int typeIndex) where T : struct
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x347FB50", Offset = "0x347EF50", VA = "0x18347FB50")]
		private static bool TryGetBufferAs<T>(this EntityManager entityManager, Entity entity, int typeIndex, bool isReadOnly, [Out] DynamicBuffer<T> buffer) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3480A80", Offset = "0x347FE80", VA = "0x183480A80")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x347FD80", Offset = "0x347F180", VA = "0x18347FD80")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3480F60", Offset = "0x3480360", VA = "0x183480F60")]
		public static bool TryGetBuffer<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer, bool isReadOnly) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x347F8C0", Offset = "0x347ECC0", VA = "0x18347F8C0")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x347F950", Offset = "0x347ED50", VA = "0x18347F950")]
		public static DynamicBuffer<T> GetBufferRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class EntityManagerEditorExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class EntityManagerEntityExistenceLookupByEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x781FDF0", Offset = "0x781F1F0", VA = "0x18781FDF0")]
		public static EntityExistenceLookupByEntity GetEntityExistenceLookupByEntity(this EntityManager entityManager)
		{
			return default(EntityExistenceLookupByEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class EntityManagerFilterToExistingEntitiesExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7820380", Offset = "0x781F780", VA = "0x187820380")]
		public static bool PartitionExistingEntitiesUnstable(this NativeArray<Entity> liveEntities, EntityManager entityManager, [Out] NativeArray<Entity> deadEntities, bool keepCleanupEntities = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x78200D0", Offset = "0x781F4D0", VA = "0x1878200D0")]
		public static bool PartitionExistingEntitiesUnstable(this EntityManager entityManager, NativeArray<Entity> liveEntities, [Out] NativeArray<Entity> deadEntities, bool keepCleanupEntities = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x781FE40", Offset = "0x781F240", VA = "0x18781FE40")]
		public static bool FilterToExistingEntities(this NativeArray<Entity> entities, EntityManager entityManager, bool keepCleanupEntities = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x781FE60", Offset = "0x781F260", VA = "0x18781FE60")]
		public static bool FilterToExistingEntities(this EntityManager entityManager, NativeArray<Entity> entities, bool keepCleanupEntities = true)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class EntityManagerHasComponentByEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x78203A0", Offset = "0x781F7A0", VA = "0x1878203A0")]
		public static HasComponentByEntity GetHasComponentByEntity(this EntityManager entityManager)
		{
			return default(HasComponentByEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class EntityManagerIntegrityExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class EntityManagerRemoveComponentExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class EntityManagerSharedComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x34811B0", Offset = "0x34805B0", VA = "0x1834811B0")]
		public static T GetSharedComponentData<T>(this EntityManager em, ArchetypeChunkIterator it) where T : struct, ISharedComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3481350", Offset = "0x3480750", VA = "0x183481350")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class ExclusiveEntityTransactionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3585060", Offset = "0x3584460", VA = "0x183585060")]
		[BurstCompatible]
		public static int GetSharedComponentDataIndex<T>(this ExclusiveEntityTransaction transaction, Entity entity) where T : struct, ISharedComponentData
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x335E7D0", Offset = "0x335DBD0", VA = "0x18335E7D0")]
		[BurstCompatible]
		public static bool TryGetBufferRO<T>(this ExclusiveEntityTransaction transaction, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class RREntityRemapUtility
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		private struct RemapChunksFilteredJob : IJobParallelForBurstSchedulable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[NativeDisableUnsafePtrRestriction]
			public unsafe Unity.Entities.EntityComponentStore* dstEntityComponentStore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int chunkHeaderType;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7824430", Offset = "0x7823830", VA = "0x187824430", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7823AB0", Offset = "0x7822EB0", VA = "0x187823AB0")]
		public unsafe static void PatchMatchingEntities(EntityRemapUtility.EntityPatchInfo* scalarPatches, int scalarPatchCount, EntityRemapUtility.BufferEntityPatchInfo* bufferPatches, int bufferPatchCount, byte* chunkBuffer, int entityOffset, int entityCount, NativeParallelHashMap<Entity, Entity> remapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7824150", Offset = "0x7823550", VA = "0x187824150")]
		public static Entity RemapMatchingEntity(NativeParallelHashMap<Entity, Entity> map, Entity source)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7823D50", Offset = "0x7823150", VA = "0x187823D50")]
		public static JobHandle RemapAllMatchingEntities(this EntityManager entityManager, NativeParallelHashMap<Entity, Entity> map)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7823F40", Offset = "0x7823340", VA = "0x187823F40")]
		public static JobHandle RemapAllMatchingEntities(this EntityQuery query, NativeParallelHashMap<Entity, Entity> map, EntityManager entityManager, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class EntityQueryArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x78213B0", Offset = "0x78207B0", VA = "0x1878213B0")]
		public static int CalculateArchetypeCount(this EntityQuery query)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x78212A0", Offset = "0x78206A0", VA = "0x1878212A0")]
		private static int CalculateArchetypeCount(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Unity.Entities.EntityQueryFilter filter)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class EntityQueryChangeVersionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x34ADB60", Offset = "0x34ACF60", VA = "0x1834ADB60")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x34ADD00", Offset = "0x34AD100", VA = "0x1834ADD00")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x34ADC00", Offset = "0x34AD000", VA = "0x1834ADC00")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3, T4>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x34ADDD0", Offset = "0x34AD1D0", VA = "0x1834ADDD0")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3, T4, T5>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x34ADB00", Offset = "0x34ACF00", VA = "0x1834ADB00")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7821E40", Offset = "0x7821240", VA = "0x187821E40")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7821D40", Offset = "0x7821140", VA = "0x187821D40")]
		public static bool IsEmpty(this EntityQuery entityQuery, [Out] int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7821D90", Offset = "0x7821190", VA = "0x187821D90")]
		public static bool IsEmpty(this EntityQueryInJob entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x34BB280", Offset = "0x34BA680", VA = "0x1834BB280")]
		public static CACJNPHFLJO<T> ToComponentObjectArray<T>(this EntityQuery query) where T : class
		{
			return default(CACJNPHFLJO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x34BB210", Offset = "0x34BA610", VA = "0x1834BB210")]
		public static ComponentTypeHandle<T> GetComponentTypeHandle<T>(this EntityQuery query, bool isReadOnly)
		{
			return default(ComponentTypeHandle<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x37B01E0", Offset = "0x37AF5E0", VA = "0x1837B01E0")]
		internal unsafe static Unity.Entities.EntityDataAccess* GetEntityDataAccess(this EntityQuery query)
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityDataAccess*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7821CB0", Offset = "0x78210B0", VA = "0x187821CB0")]
		public static uint GetGlobalSystemVersion(this EntityQuery query)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class EntityQueryToComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x34D1A50", Offset = "0x34D0E50", VA = "0x1834D1A50")]
		public static NativeArray<T> ToSharedComponentDataArray<T>(this EntityQuery entityQuery, Allocator allocator = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x34D1490", Offset = "0x34D0890", VA = "0x1834D1490")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7823000", Offset = "0x7822400", VA = "0x187823000")]
		[BurstCompatible(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", CompileTarget = BurstCompatibleAttribute.BurstCompatibleCompileTarget.Editor)]
		public static NativeArray<byte> ToComponentDataArray(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x34D11F0", Offset = "0x34D05F0", VA = "0x1834D11F0")]
		public static NativeArrayAsync<T> ToComponentDataArrayAsync<T>(this EntityQuery query, Allocator allocator = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7822EC0", Offset = "0x78222C0", VA = "0x187822EC0")]
		private static NativeArray<byte> CreateComponentDataArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ComponentTypeHandle type, EntityQuery entityQuery, Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class EntityQueryToEntityArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x78233D0", Offset = "0x78227D0", VA = "0x1878233D0")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x78232C0", Offset = "0x78226C0", VA = "0x1878232C0")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class EntityQueryToEntityArrayFilteredExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class JobChunkExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class LookupCacheExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7823880", Offset = "0x7822C80", VA = "0x187823880")]
		public unsafe static int GetIndexInTypeArray(this Unity.Entities.LookupCache lookupCache, Unity.Entities.Archetype* archetype, int typeIndex)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public ref struct RefRO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private unsafe void* ptr;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public ref struct RefRW<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private unsafe void* ptr;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50")]
		internal unsafe RefRW(void* ptr)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class UnsafeBitArrayExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct GroupByKey<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<(TKey, NativeArray<TValue>, int, int)>, IEnumerable where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct Enumerator : IEnumerator<(TKey, NativeArray<TValue>, int, int)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private GroupByKey<TKey, TValue> grouped;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0x4355660", Offset = "0x4354A60", VA = "0x184355660", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public (TKey key, NativeArray<TValue> values, int offset, int count) Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0x4357DA0", Offset = "0x43571A0", VA = "0x184357DA0", Slot = "4")]
				get
				{
					return default((TKey, NativeArray<TValue>, int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4357D20", Offset = "0x4357120", VA = "0x184357D20")]
			public Enumerator(GroupByKey<TKey, TValue> grouped)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x4354500", Offset = "0x4353900", VA = "0x184354500", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4353420", Offset = "0x4352820", VA = "0x184353420", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<TKey> uniqueKeys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<int> offsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<int> counts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<TValue> valuesGroupedByKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeParallelHashMap<TKey, int> indexByKey;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public readonly bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x48668D0", Offset = "0x4865CD0", VA = "0x1848668D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x48668A0", Offset = "0x4865CA0", VA = "0x1848668A0")]
		public GroupByKey(NativeArray<TKey> uniqueKeys, NativeArray<int> offsets, NativeArray<int> counts, NativeArray<TValue> valuesGroupedByKey, NativeParallelHashMap<TKey, int> indexByKey)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4864F30", Offset = "0x4864330", VA = "0x184864F30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x48654F0", Offset = "0x48648F0", VA = "0x1848654F0")]
		public readonly NativeArray<TValue> GetValues(TKey key)
		{
			return default(NativeArray<TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4865300", Offset = "0x4864700", VA = "0x184865300")]
		public readonly NativeArray<TValue> GetValues(int index)
		{
			return default(NativeArray<TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4864C10", Offset = "0x4864010", VA = "0x184864C10", Slot = "4")]
		public readonly JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4866160", Offset = "0x4865560", VA = "0x184866160")]
		public static GroupByKey<TKey, TValue> Group(NativeArray<TKey> keys, NativeArray<TValue> values, Allocator allocator = Allocator.Temp)
		{
			return default(GroupByKey<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4864820", Offset = "0x4863C20", VA = "0x184864820")]
		[BurstDiscard]
		private static void CheckLengths(NativeArray<TKey> keys, NativeArray<TValue> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4865230", Offset = "0x4864630", VA = "0x184865230")]
		public readonly Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4866700", Offset = "0x4865B00", VA = "0x184866700", Slot = "6")]
		private IEnumerator<(TKey, NativeArray<TValue>, int, int)> System.Collections.Generic.IEnumerable<(TKeykey,Unity.Collections.NativeArray<TValue>values,System.Int32offset,System.Int32count)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4866700", Offset = "0x4865B00", VA = "0x184866700", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct ArchetypeIterator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private ArchetypeChunkIterator iterator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private unsafe Unity.Entities.Archetype* lastArchetype;
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public interface IUTF8BufferElementData : IBufferElementData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct AsyncDispose : IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private JobGroup group;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x78158C0", Offset = "0x7814CC0", VA = "0x1878158C0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x78157D0", Offset = "0x7814BD0", VA = "0x1878157D0")]
		public AsyncDispose(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x78158C0", Offset = "0x7814CC0", VA = "0x1878158C0")]
		public static implicit operator JobHandle(AsyncDispose set)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3295AD0", Offset = "0x3294ED0", VA = "0x183295AD0")]
		public void Add<T>(T disposable) where T : struct, INativeDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x32959D0", Offset = "0x3294DD0", VA = "0x1832959D0")]
		public void Add<T>(NativeArrayAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x32959D0", Offset = "0x3294DD0", VA = "0x1832959D0")]
		public void Add<T>(NativeArray<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x32959D0", Offset = "0x3294DD0", VA = "0x1832959D0")]
		public void Add<T>(NativeListAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x32959D0", Offset = "0x3294DD0", VA = "0x1832959D0")]
		public void Add<T>(NativeList<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7815730", Offset = "0x7814B30", VA = "0x187815730", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7815770", Offset = "0x7814B70", VA = "0x187815770", Slot = "4")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct DisableJobSchedulingScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly int existingWorkerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly bool disableScheduling;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x781CEF0", Offset = "0x781C2F0", VA = "0x18781CEF0")]
		private DisableJobSchedulingScope(bool disableScheduling)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x781CEE0", Offset = "0x781C2E0", VA = "0x18781CEE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x781CEA0", Offset = "0x781C2A0", VA = "0x18781CEA0")]
		public static DisableJobSchedulingScope DisableSchedulingIfTrue(bool disableScheduling)
		{
			return default(DisableJobSchedulingScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct JobGroup : IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly JobHandle dependsOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private NativeList<JobHandle> handles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int combinedCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private JobHandle combined;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public JobHandle DependsOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x7823720", Offset = "0x7822B20", VA = "0x187823720")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7823670", Offset = "0x7822A70", VA = "0x187823670")]
		public JobGroup(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x78234A0", Offset = "0x78228A0", VA = "0x1878234A0")]
		public void Add(JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7815730", Offset = "0x7814B30", VA = "0x187815730", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7823610", Offset = "0x7822A10", VA = "0x187823610", Slot = "4")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7823570", Offset = "0x7822970", VA = "0x187823570")]
		private NativeList<JobHandle> GetList()
		{
			return default(NativeList<JobHandle>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[Flags]
	public enum CopyFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		NativeComponents = 1,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		ManagedComponents = 2,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		BufferComponents = 4,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		RemapEntityRefs = 8,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		All = 0xF
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal struct CopyEntitiesUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[BurstCompile]
		private struct PopulateRemappingArrayJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			[ReadOnly]
			public NativeArray<Entity> dstEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x7823A40", Offset = "0x7822E40", VA = "0x187823A40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[BurstCompile]
		private struct RemapChunksFilteredJob : IJobParallelForBurstSchedulable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			[ReadOnly]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			[NativeDisableUnsafePtrRestriction]
			public unsafe Unity.Entities.EntityComponentStore* dstEntityComponentStore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int chunkHeaderType;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x78241C0", Offset = "0x78235C0", VA = "0x1878241C0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7818B80", Offset = "0x7817F80", VA = "0x187818B80")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7819CB0", Offset = "0x78190B0", VA = "0x187819CB0")]
		private static NativeArray<ArchetypeChunk> GetChunksFromEntities(NativeArray<Entity> entities, EntityManager srcEntityManager)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x78193C0", Offset = "0x78187C0", VA = "0x1878193C0")]
		private unsafe static NativeArray<ArchetypeChunk> CopyEntitiesInternal(NativeArray<ArchetypeChunk> srcChunks, Unity.Entities.EntityDataAccess* srcAccess, CopyFlags copyFlags)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7819F70", Offset = "0x7819370", VA = "0x187819F70")]
		internal unsafe static void RemapEntityRefs(NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping, Unity.Entities.EntityDataAccess* dataAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x781A110", Offset = "0x7819510", VA = "0x18781A110")]
		internal static void RemapEntityRefs(EntityManager entityManager, NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7819DC0", Offset = "0x78191C0", VA = "0x187819DC0")]
		public static JobHandle RemapAllEntities(EntityManager entityManager, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x68AFF60", Offset = "0x68AF360", VA = "0x1868AFF60")]
		private static bool HasFlag(CopyFlags copyFlags, CopyFlags testFlag)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7819A20", Offset = "0x7818E20", VA = "0x187819A20")]
		private unsafe static void CreateChunks(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x78198C0", Offset = "0x7818CC0", VA = "0x1878198C0")]
		private unsafe static void CopyNames(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x78184E0", Offset = "0x78178E0", VA = "0x1878184E0")]
		private static void CloneNativeComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7818890", Offset = "0x7817C90", VA = "0x187818890")]
		public unsafe static void CloneNativeComponents([In] Unity.Entities.EntityBatchInChunk srcBatch, Unity.Entities.Chunk* dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7817A20", Offset = "0x7816E20", VA = "0x187817A20")]
		private static void ClearBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7817820", Offset = "0x7816C20", VA = "0x187817820")]
		private static void ClearBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7818090", Offset = "0x7817490", VA = "0x187818090")]
		private static void CloneBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7817E20", Offset = "0x7817220", VA = "0x187817E20")]
		private static void CloneBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7817CD0", Offset = "0x78170D0", VA = "0x187817CD0")]
		private static void ClearManagedComponents(NativeArray<ArchetypeChunk> chunks, uint globalSystemVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x78183D0", Offset = "0x78177D0", VA = "0x1878183D0")]
		private static void CloneManagedComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7819B70", Offset = "0x7818F70", VA = "0x187819B70")]
		private static NativeArray<Entity> CreateEntityArray(NativeArray<ArchetypeChunk> chunks, Allocator allocator, int entityCount)
		{
			return default(NativeArray<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompatible]
	public struct EntityQueryInJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe Unity.Entities.EntityQueryImpl* __impl;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x7822CF0", Offset = "0x78220F0", VA = "0x187822CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool IsEmptyIgnoreFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7822CA0", Offset = "0x78220A0", VA = "0x187822CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7821E80", Offset = "0x7821280", VA = "0x187821E80")]
		public static implicit operator EntityQueryInJob(EntityQuery query)
		{
			return default(EntityQueryInJob);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7822C70", Offset = "0x7822070", VA = "0x187822C70")]
		public EntityQueryInJob(EntityQuery query)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7821F60", Offset = "0x7821360", VA = "0x187821F60")]
		public int CalculateEntityCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7822160", Offset = "0x7821560", VA = "0x187822160")]
		public bool HasFilter()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7822030", Offset = "0x7821430", VA = "0x187822030")]
		public ArchetypeChunkIterator GetArchetypeChunkIterator()
		{
			return default(ArchetypeChunkIterator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x78221B0", Offset = "0x78215B0", VA = "0x1878221B0")]
		[BurstCompatible]
		public NativeArray<Entity> ToEntityArray(EntityTypeHandle entityType, Allocator allocator = Allocator.Temp)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x34CC7F0", Offset = "0x34CBBF0", VA = "0x1834CC7F0")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle componentType, Allocator allocator = Allocator.Temp) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x34CA330", Offset = "0x34C9730", VA = "0x1834CA330")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle<T> componentType, Allocator allocator = Allocator.Temp) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0")]
		internal unsafe Unity.Entities.EntityQueryImpl* _GetImpl()
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityQueryImpl*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7822B00", Offset = "0x7821F00", VA = "0x187822B00")]
		private unsafe static void _GatherEntities(Entity* entities, EntityTypeHandle entityTypeHandle, [In] Unity.Entities.UnsafeCachedChunkList cache, uint requiredChangeVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x78228F0", Offset = "0x7821CF0", VA = "0x1878228F0")]
		private unsafe static void _GatherEntitiesWithFilter(Entity* entities, Unity.Entities.EntityQueryFilter filter, Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, EntityTypeHandle entityTypeHandle, [In] Unity.Entities.UnsafeCachedChunkList cache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7822740", Offset = "0x7821B40", VA = "0x187822740")]
		private unsafe static void _GatherComponentData(byte* componentData, int typeIndex, [In] Unity.Entities.UnsafeCachedChunkList cache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7822500", Offset = "0x7821900", VA = "0x187822500")]
		private unsafe static void _GatherComponentDataWithFilter(byte* componentData, int typeIndex, [In] Unity.Entities.UnsafeCachedChunkList cache, [In] Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, Unity.Entities.EntityQueryFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7821EC0", Offset = "0x78212C0", VA = "0x187821EC0")]
		private void CalculateChunkAndEntityCount([Out] int entityCount, [Out] int chunkCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public static class EntityQueryInJobExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7821E80", Offset = "0x7821280", VA = "0x187821E80")]
		public static EntityQueryInJob UseInJob(this EntityQuery query)
		{
			return default(EntityQueryInJob);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public interface IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Execute(ArchetypeChunk batch, int batchIndex);
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public static class IQueryInJobEntityBatchExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3666CF0", Offset = "0x36660F0", VA = "0x183666CF0")]
		public static void Run<T>(this T operation, EntityQueryInJob query) where T : struct, IQueryInJobEntityBatch
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x335C0D0", Offset = "0x335B4D0", VA = "0x18335C0D0")]
		public static void RunRef<T>(this T operation, EntityQueryInJob query) where T : struct, IQueryInJobEntityBatch
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3666610", Offset = "0x3665A10", VA = "0x183666610")]
		[SkipLocalsInit]
		private static void RunInternal<T>(this T operation, EntityQueryInJob query) where T : struct, IQueryInJobEntityBatch
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[BurstCompile]
	internal struct DummyQueryInJobEntityBatch : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
		public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[BurstCompile]
	internal static class DummyQueryInJobEntityBatchScheduler
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class ListExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class MemoryUtils
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct NativeMultiHashMapAsync<TKey, TValue> : IDisposable where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly NativeParallelMultiHashMap<TKey, TValue> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x50DA530", Offset = "0x50D9930", VA = "0x1850DA530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4D46DE0", Offset = "0x4D461E0", VA = "0x184D46DE0")]
		public NativeMultiHashMapAsync(NativeParallelMultiHashMap<TKey, TValue> map, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x50A5B90", Offset = "0x50A4F90", VA = "0x1850A5B90")]
		public NativeParallelMultiHashMap<TKey, TValue> Complete()
		{
			return default(NativeParallelMultiHashMap<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x50DA490", Offset = "0x50D9890", VA = "0x1850DA490", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct NativeResultAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[BurstCompile]
	public struct RemapEntitiesParallelForBatchJob : IJobParallelForBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[ReadOnly]
		public NativeArray<Entity> src;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public NativeArray<Entity> dst;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7824760", Offset = "0x7823B60", VA = "0x187824760", Slot = "4")]
		public void Execute(int startIndex, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[BurstCompile]
	public struct RemapEntitiesInPlaceJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemappingRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NativeArray<Entity> entitiesRW;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7824700", Offset = "0x7823B00", VA = "0x187824700", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class StructUtility
	{
	}
}
namespace Unity.Entities.Scene
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class EntityQuerySceneExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public struct QueryResetFilterScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private EntityQuery query;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x110A3E0", Offset = "0x11097E0", VA = "0x18110A3E0")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x7823AA0", Offset = "0x7822EA0", VA = "0x187823AA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7822D10", Offset = "0x7822110", VA = "0x187822D10")]
		public static void DestroyEntitiesInScene(this EntityQuery query, SceneTag scene, EntityManager entityManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7822E30", Offset = "0x7822230", VA = "0x187822E30")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}
	}
}
namespace Unity.Entities.LinkedEntityGroupExtensions
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public static class EntityManagerLinkedEntityGroupExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7820650", Offset = "0x781FA50", VA = "0x187820650")]
		public static bool TryGetChildEntitySubArrayRO([In] this EntityManager entityManager, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7820780", Offset = "0x781FB80", VA = "0x187820780")]
		public static bool TryGetChildEntitySubArray([In] this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7820870", Offset = "0x781FC70", VA = "0x187820870")]
		public static bool TryGetChildEntitySubArray([In] this DynamicBuffer<LinkedEntityGroup> buffer, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x78204F0", Offset = "0x781F8F0", VA = "0x1878204F0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x78203F0", Offset = "0x781F7F0", VA = "0x1878203F0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7820620", Offset = "0x781FA20", VA = "0x187820620")]
		public static NativeArray<Entity> GetChildEntitySubArray(this DynamicBuffer<LinkedEntityGroup> buffer)
		{
			return default(NativeArray<Entity>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2562287246
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7824CE0", Offset = "0x78240E0", VA = "0x187824CE0")]
	public static void NLACCDPEEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7824CD0", Offset = "0x78240D0", VA = "0x187824CD0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class DAKAGJPPDPP
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public DAKAGJPPDPP()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Mono.Math;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Jobs;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CNJBIHHPLAO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct MHPJLCLAMGA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private EntityManager BOGIEIBMFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeArray<Entity> NMNOLKKCICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int GABJOMFFJAI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T HMAPMKOECOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x38050F0", Offset = "0x38044F0", VA = "0x1838050F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3805160", Offset = "0x3804560", VA = "0x183805160")]
		public MHPJLCLAMGA(NativeArray<Entity> NMNOLKKCICL, EntityManager BOGIEIBMFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3805150", Offset = "0x3804550", VA = "0x183805150")]
		public bool KECFHJNJDGC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x17D1970", Offset = "0x17D0D70", VA = "0x1817D1970")]
		public MHPJLCLAMGA<T> IINGNKPPFJF()
		{
			return default(MHPJLCLAMGA<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct IANECIBOMDO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityManager BOGIEIBMFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeArray<Entity> NMNOLKKCICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int GABJOMFFJAI;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2CA17F0", Offset = "0x2CA0BF0", VA = "0x182CA17F0")]
	public static bool DLHPHEPOECD<T>(this NativeArray<T> FPLJCBGEJAP) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1A20", Offset = "0x2CA0E20", VA = "0x182CA1A20")]
	public static string NFEIOGJHKDK<T>(this NativeList<T> JOLFKOMKBCI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1820", Offset = "0x2CA0C20", VA = "0x182CA1820")]
	public static string NFEIOGJHKDK<T>(this NativeArray<T> OGMMNHCCDJE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1A70", Offset = "0x2CA0E70", VA = "0x182CA1A70")]
	public static MHPJLCLAMGA<T> OPPFJLKCHFJ<T>(this NativeList<Entity> HLPMIAJBFDL, EntityManager BOGIEIBMFCN) where T : class
	{
		return default(MHPJLCLAMGA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1B10", Offset = "0x2CA0F10", VA = "0x182CA1B10")]
	public static MHPJLCLAMGA<T> OPPFJLKCHFJ<T>(this NativeArray<Entity> HLPMIAJBFDL, EntityManager BOGIEIBMFCN) where T : class
	{
		return default(MHPJLCLAMGA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class AOJMOIMFIMM
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DIIGOIIMLCG
{
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[NativeContainerSupportsMinMaxWriteRestriction]
	[NativeContainer]
	public struct ArchetypeChunkComponentType
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

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x199E3B0", Offset = "0x199D7B0", VA = "0x18199E3B0")]
		internal ArchetypeChunkComponentType(int typeIndex, bool isReadOnly, uint globalSystemVersion)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[NativeContainer]
	public struct ComponentDataFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityComponentStore* m_EntityComponentStore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly int m_TypeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int m_TypeLookupCache;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Entity this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x199E5F0", Offset = "0x199D9F0", VA = "0x18199E5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x199E5D0", Offset = "0x199D9D0", VA = "0x18199E5D0")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityComponentStore* entityComponentStoreComponentStore)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x199E5C0", Offset = "0x199D9C0", VA = "0x18199E5C0")]
		public bool Exists(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x199E480", Offset = "0x199D880", VA = "0x18199E480")]
		public void CopyTo(Entity entity, NativeArray<byte> dstArray)
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

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x199FFA0", Offset = "0x199F3A0", VA = "0x18199FFA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x199FFF0", Offset = "0x199F3F0", VA = "0x18199FFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x199EFA0", Offset = "0x199E3A0", VA = "0x18199EFA0")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x199EF20", Offset = "0x199E320", VA = "0x18199EF20")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x199FEA0", Offset = "0x199F2A0", VA = "0x18199FEA0")]
		public ComponentTypeList(ComponentTypeList a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x199FDD0", Offset = "0x199F1D0", VA = "0x18199FDD0")]
		public ComponentTypeList(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x199FCD0", Offset = "0x199F0D0", VA = "0x18199FCD0")]
		public ComponentTypeList(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x199F420", Offset = "0x199E820", VA = "0x18199F420")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x199F300", Offset = "0x199E700", VA = "0x18199F300")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x199F1E0", Offset = "0x199E5E0", VA = "0x18199F1E0")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x199F8E0", Offset = "0x199ECE0", VA = "0x18199F8E0")]
		public ComponentTypeList(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x199F530", Offset = "0x199E930", VA = "0x18199F530")]
		public ComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x199E8A0", Offset = "0x199DCA0", VA = "0x18199E8A0")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x199F020", Offset = "0x199E420", VA = "0x18199F020")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x199EAF0", Offset = "0x199DEF0", VA = "0x18199EAF0")]
		public static ComponentTypeList Add(in ComponentTypeList a, in ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x199E690", Offset = "0x199DA90", VA = "0x18199E690")]
		public static ComponentTypeList Add(in ComponentTypeList src, params ComponentType[] additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x199EE00", Offset = "0x199E200", VA = "0x18199EE00")]
		public static ComponentTypeList Add(in ComponentTypeList src, IEnumerable<ComponentType> additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x199F080", Offset = "0x199E480", VA = "0x18199F080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class ComponentTypeListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1BA0", Offset = "0x2CB0FA0", VA = "0x182CB1BA0")]
		public static ComponentTypeList With<T>(this ComponentTypeList src)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x199E810", Offset = "0x199DC10", VA = "0x18199E810")]
		public static ComponentTypeList With(this ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x199E690", Offset = "0x199DA90", VA = "0x18199E690")]
		public static ComponentTypeList With(this ComponentTypeList a, params ComponentType[] additional)
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
		private FixedListInt128 m_sorted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Masks m_masks;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9EC800", Offset = "0x9EBC00", VA = "0x1809EC800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x19A09B0", Offset = "0x199FDB0", VA = "0x1819A09B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x19A0170", Offset = "0x199F570", VA = "0x1819A0170")]
		private void ComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x19A0340", Offset = "0x199F740", VA = "0x1819A0340")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x19A02C0", Offset = "0x199F6C0", VA = "0x1819A02C0")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x19A06A0", Offset = "0x199FAA0", VA = "0x1819A06A0")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x19A0580", Offset = "0x199F980", VA = "0x1819A0580")]
		public ComponentTypes32(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x19A06F0", Offset = "0x199FAF0", VA = "0x1819A06F0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x19A0780", Offset = "0x199FB80", VA = "0x1819A0780")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x19A05F0", Offset = "0x199F9F0", VA = "0x1819A05F0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x19A04D0", Offset = "0x199F8D0", VA = "0x1819A04D0")]
		public ComponentTypes32(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x19A0820", Offset = "0x199FC20", VA = "0x1819A0820")]
		public ComponentTypes32(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x19A0160", Offset = "0x199F560", VA = "0x1819A0160")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x19A0350", Offset = "0x199F750", VA = "0x1819A0350")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x19A0370", Offset = "0x199F770", VA = "0x1819A0370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x19A1480", Offset = "0x19A0880", VA = "0x1819A1480")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, SystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x19A13A0", Offset = "0x19A07A0", VA = "0x1819A13A0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x19A1560", Offset = "0x19A0960", VA = "0x1819A1560")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x19A1780", Offset = "0x19A0B80", VA = "0x1819A1780")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x19A1650", Offset = "0x19A0A50", VA = "0x1819A1650")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x19A1740", Offset = "0x19A0B40", VA = "0x1819A1740")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x19A1870", Offset = "0x19A0C70", VA = "0x1819A1870")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x19A1760", Offset = "0x19A0B60", VA = "0x1819A1760")]
		public static EntityQueryDesc WithFilterWriteGroup(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x19A1130", Offset = "0x19A0530", VA = "0x1819A1130")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2F3CE50", Offset = "0x2F3C250", VA = "0x182F3CE50")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2F3CE20", Offset = "0x2F3C220", VA = "0x182F3CE20")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2F3CE20", Offset = "0x2F3C220", VA = "0x182F3CE20")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2F3CE20", Offset = "0x2F3C220", VA = "0x182F3CE20")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2F3CE20", Offset = "0x2F3C220", VA = "0x182F3CE20")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x337BB00", Offset = "0x337AF00", VA = "0x18337BB00")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x337BB30", Offset = "0x337AF30", VA = "0x18337BB30")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x337BB30", Offset = "0x337AF30", VA = "0x18337BB30")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2F37FB0", Offset = "0x2F373B0", VA = "0x182F37FB0")]
		private static ComponentType[] Expand<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2F38030", Offset = "0x2F37430", VA = "0x182F38030")]
		private static ComponentType[] Expand<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2F388D0", Offset = "0x2F37CD0", VA = "0x182F388D0")]
		private static ComponentType[] Expand<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2F39D70", Offset = "0x2F39170", VA = "0x182F39D70")]
		private static ComponentType[] Expand<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x19A12D0", Offset = "0x19A06D0", VA = "0x1819A12D0")]
		private static ComponentType[] Combine(ComponentType[] a, ComponentType[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct EntityView
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public readonly Entity Entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly EntityManager EntityManager;
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
	public static class DynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x33F1110", Offset = "0x33F0510", VA = "0x1833F1110")]
		public static void RemoveAtSwapBack<T>(this DynamicBuffer<T> buffer, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x33F0E20", Offset = "0x33F0220", VA = "0x1833F0E20")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x33F1190", Offset = "0x33F0590", VA = "0x1833F1190")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x33F0F40", Offset = "0x33F0340", VA = "0x1833F0F40")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x33F1200", Offset = "0x33F0600", VA = "0x1833F1200")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class EntityManagerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x19A0AE0", Offset = "0x199FEE0", VA = "0x1819A0AE0")]
		public static EntityArchetype CreateArchetype(this EntityManager entityManager, Span<ComponentType> types)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x19A0B60", Offset = "0x199FF60", VA = "0x1819A0B60")]
		public static EntityArchetype GetArchetype(this EntityManager entityManager, Entity entity)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2F32070", Offset = "0x2F31470", VA = "0x182F32070")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, out DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2F31E30", Offset = "0x2F31230", VA = "0x182F31E30")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, out DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2F31370", Offset = "0x2F30770", VA = "0x182F31370")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2F31470", Offset = "0x2F30870", VA = "0x182F31470")]
		public static DynamicBuffer<T> GetBufferRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2F32100", Offset = "0x2F31500", VA = "0x182F32100")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2F33090", Offset = "0x2F32490", VA = "0x182F33090")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x19A0B90", Offset = "0x199FF90", VA = "0x1819A0B90")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2F31DE0", Offset = "0x2F311E0", VA = "0x182F31DE0")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2F32FD0", Offset = "0x2F323D0", VA = "0x182F32FD0")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, out T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2F319C0", Offset = "0x2F30DC0", VA = "0x182F319C0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x19A1BE0", Offset = "0x19A0FE0", VA = "0x1819A1BE0")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x19A1B90", Offset = "0x19A0F90", VA = "0x1819A1B90")]
		public static bool IsEmpty(this EntityQuery entityQuery, out int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x337C360", Offset = "0x337B760", VA = "0x18337C360")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x337C2F0", Offset = "0x337B6F0", VA = "0x18337C2F0")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x19A20E0", Offset = "0x19A14E0", VA = "0x1819A20E0")]
		public static EntityQuery WithChangedVersionFilter(this EntityQuery entityQuery, ComponentType componentType)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x19A20B0", Offset = "0x19A14B0", VA = "0x1819A20B0")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x337C0F0", Offset = "0x337B4F0", VA = "0x18337C0F0")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x337C000", Offset = "0x337B400", VA = "0x18337C000")]
		public static NativeArray<T> ToComponentDataArrayRun<T>(this EntityQuery entityQuery, Allocator allocator) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x19A1C20", Offset = "0x19A1020", VA = "0x1819A1C20")]
		public static NativeArray<byte> ToComponentDataArrayRun(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x19A1F40", Offset = "0x19A1340", VA = "0x1819A1F40")]
		public static NativeArray<Entity> ToEntityArrayRun(this EntityQuery entityQuery, Allocator allocator)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x19A1890", Offset = "0x19A0C90", VA = "0x1819A1890")]
		private static NativeArray<byte> CreateComponentDataArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkComponentType type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x337BB60", Offset = "0x337AF60", VA = "0x18337BB60")]
		private static NativeArray<T> CreateComponentDataArrayRun<T>(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkComponentType<T> type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x19A1A40", Offset = "0x19A0E40", VA = "0x1819A1A40")]
		private static NativeArray<Entity> CreateEntityArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkEntityType type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x19A1E30", Offset = "0x19A1230", VA = "0x1819A1E30")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x337BCC0", Offset = "0x337B0C0", VA = "0x18337BCC0")]
		public static NativeArrayAsync<T> ToComponentDataArrayAsync<T>(this EntityQuery query, Allocator allocator = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(NativeArrayAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IComponent
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class ListExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class MemoryUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB0F0", Offset = "0x3DCA4F0", VA = "0x183DCB0F0")]
		public static Memory<T> Rent<T>(int count)
		{
			return default(Memory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB370", Offset = "0x3DCA770", VA = "0x183DCB370")]
		public static void Return<T>(this Memory<T> memory)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct NativeArrayAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3364240", Offset = "0x3363640", VA = "0x183364240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3364280", Offset = "0x3363680", VA = "0x183364280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7EE2A0", Offset = "0x7ED6A0", VA = "0x1807EE2A0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x78E450", Offset = "0x78D850", VA = "0x18078E450")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAE5B20", Offset = "0xAE4F20", VA = "0x180AE5B20")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3363780", Offset = "0x3362B80", VA = "0x183363780")]
		public NativeArray<T> Complete()
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3363FF0", Offset = "0x33633F0", VA = "0x183363FF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x33637C0", Offset = "0x3362BC0", VA = "0x1833637C0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x19A2690", Offset = "0x19A1A90", VA = "0x1819A2690")]
		public static JobHandle CombineHandles(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x320D530", Offset = "0x320C930", VA = "0x18320D530")]
		public static JobHandle CombineHandles<T>(this JobHandle a, NativeArrayAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x320D530", Offset = "0x320C930", VA = "0x18320D530")]
		public static JobHandle CombineHandles<T>(this JobHandle a, NativeListAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x320D580", Offset = "0x320C980", VA = "0x18320D580")]
		public static JobHandle CombineHandles<T>(this NativeListAsync<T> a, NativeListAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x19A26D0", Offset = "0x19A1AD0", VA = "0x1819A26D0")]
		public static JobHandle Combine(this Span<JobHandle> handles)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct NativeListAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly NativeList<T> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x343F370", Offset = "0x343E770", VA = "0x18343F370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7EE2A0", Offset = "0x7ED6A0", VA = "0x1807EE2A0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAE5B20", Offset = "0xAE4F20", VA = "0x180AE5B20")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x343EE30", Offset = "0x343E230", VA = "0x18343EE30")]
		public NativeArrayAsync<T> AsDeferredArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3363780", Offset = "0x3362B80", VA = "0x183363780")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x343F080", Offset = "0x343E480", VA = "0x18343F080", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x343F1D0", Offset = "0x343E5D0", VA = "0x18343F1D0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct NativeResultAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class SpanUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x51F5220", Offset = "0x51F4620", VA = "0x1851F5220")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x51F5370", Offset = "0x51F4770", VA = "0x1851F5370")]
		public static Span<T> AsSpan<T>(this NativeList<T> list) where T : struct
		{
			return default(Span<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class StructUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3183F10", Offset = "0x3183310", VA = "0x183183F10")]
		public static bool Equals<T>(T a, T b) where T : struct
		{
			return default(bool);
		}
	}
}
namespace Unity.Entities.Scene
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class EntityQuerySceneExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct QueryResetFilterScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private EntityQuery query;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private static bool isInScope;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x19A27D0", Offset = "0x19A1BD0", VA = "0x1819A27D0")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x19A2780", Offset = "0x19A1B80", VA = "0x1819A2780", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x19A2310", Offset = "0x19A1710", VA = "0x1819A2310")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x19A2540", Offset = "0x19A1940", VA = "0x1819A2540")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x19A2250", Offset = "0x19A1650", VA = "0x1819A2250")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x19A2120", Offset = "0x19A1520", VA = "0x1819A2120")]
		public static int CalculateEntityCount(this EntityQuery query, SceneTag scene)
		{
			return default(int);
		}
	}
}
namespace Unity.Entities.LinkedEntityGroupExtensions
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class EntityManagerLinkedEntityGroupExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x19A0E20", Offset = "0x19A0220", VA = "0x1819A0E20")]
		public static bool TryGetChildEntitySubArrayRO(this in EntityManager entityManager, Entity parentEntity, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x19A1050", Offset = "0x19A0450", VA = "0x1819A1050")]
		public static bool TryGetChildEntitySubArray(this in BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x19A0F20", Offset = "0x19A0320", VA = "0x1819A0F20")]
		public static bool TryGetChildEntitySubArray(this in DynamicBuffer<LinkedEntityGroup> buffer, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x19A0D30", Offset = "0x19A0130", VA = "0x1819A0D30")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x19A0C50", Offset = "0x19A0050", VA = "0x1819A0C50")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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

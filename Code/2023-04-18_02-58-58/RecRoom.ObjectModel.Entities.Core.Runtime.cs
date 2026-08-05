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
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MINFEOOCPHN
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct PGAFEBDIIOE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private EntityManager IIODDCGHDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeArray<Entity> EJIAHCPIPFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int GMEHLIHLGEH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T DMBDEPMHMNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x30D2E60", Offset = "0x30D2060", VA = "0x1830D2E60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x30D2EC0", Offset = "0x30D20C0", VA = "0x1830D2EC0")]
		public PGAFEBDIIOE(NativeArray<Entity> EJIAHCPIPFJ, EntityManager IIODDCGHDHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x30D2E50", Offset = "0x30D2050", VA = "0x1830D2E50")]
		public bool JNNCKMAELPF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1BFAAA0", Offset = "0x1BF9CA0", VA = "0x181BFAAA0")]
		public PGAFEBDIIOE<T> BECNODPGHJK()
		{
			return default(PGAFEBDIIOE<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct FCNPLGAKMCO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityManager IIODDCGHDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeArray<Entity> EJIAHCPIPFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int GMEHLIHLGEH;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x13B8660", Offset = "0x13B7860", VA = "0x1813B8660")]
	public static bool KGIFMFOFOPL<T>(this NativeArray<T> IPMIIEAGJKC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x13B8690", Offset = "0x13B7890", VA = "0x1813B8690")]
	public static string KGPKJDCKOKD<T>(this NativeList<T> JAAGBDPDCIE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x13B86E0", Offset = "0x13B78E0", VA = "0x1813B86E0")]
	public static string KGPKJDCKOKD<T>(this NativeArray<T> HAHPMNMCEBD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x13B8920", Offset = "0x13B7B20", VA = "0x1813B8920")]
	public static PGAFEBDIIOE<T> LKOMLHCNEHF<T>(this NativeList<Entity> FGNBHCEFKCI, EntityManager IIODDCGHDHF) where T : class
	{
		return default(PGAFEBDIIOE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x13B88E0", Offset = "0x13B7AE0", VA = "0x1813B88E0")]
	public static PGAFEBDIIOE<T> LKOMLHCNEHF<T>(this NativeArray<Entity> FGNBHCEFKCI, EntityManager IIODDCGHDHF) where T : class
	{
		return default(PGAFEBDIIOE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class JAGEINOMKAH
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ADHMDBNOCEP
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
		[Cpp2IlInjected.Address(RVA = "0x66FF810", Offset = "0x66FEA10", VA = "0x1866FF810")]
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
			[Cpp2IlInjected.Address(RVA = "0x66FFA40", Offset = "0x66FEC40", VA = "0x1866FFA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x66FFA20", Offset = "0x66FEC20", VA = "0x1866FFA20")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityComponentStore* entityComponentStoreComponentStore)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2730E80", Offset = "0x2730080", VA = "0x182730E80")]
		public bool Exists(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x66FF8E0", Offset = "0x66FEAE0", VA = "0x1866FF8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x67013F0", Offset = "0x67005F0", VA = "0x1867013F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6701440", Offset = "0x6700640", VA = "0x186701440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x67003F0", Offset = "0x66FF5F0", VA = "0x1867003F0")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6700370", Offset = "0x66FF570", VA = "0x186700370")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x67012F0", Offset = "0x67004F0", VA = "0x1867012F0")]
		public ComponentTypeList(ComponentTypeList a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6701220", Offset = "0x6700420", VA = "0x186701220")]
		public ComponentTypeList(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6701120", Offset = "0x6700320", VA = "0x186701120")]
		public ComponentTypeList(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6700870", Offset = "0x66FFA70", VA = "0x186700870")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6700750", Offset = "0x66FF950", VA = "0x186700750")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6700630", Offset = "0x66FF830", VA = "0x186700630")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6700D30", Offset = "0x66FFF30", VA = "0x186700D30")]
		public ComponentTypeList(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6700980", Offset = "0x66FFB80", VA = "0x186700980")]
		public ComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x66FFCF0", Offset = "0x66FEEF0", VA = "0x1866FFCF0")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6700470", Offset = "0x66FF670", VA = "0x186700470")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x66FFF40", Offset = "0x66FF140", VA = "0x1866FFF40")]
		public static ComponentTypeList Add(in ComponentTypeList a, in ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x66FFAE0", Offset = "0x66FECE0", VA = "0x1866FFAE0")]
		public static ComponentTypeList Add(in ComponentTypeList src, params ComponentType[] additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6700250", Offset = "0x66FF450", VA = "0x186700250")]
		public static ComponentTypeList Add(in ComponentTypeList src, IEnumerable<ComponentType> additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67004D0", Offset = "0x66FF6D0", VA = "0x1867004D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class ComponentTypeListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1162540", Offset = "0x1161740", VA = "0x181162540")]
		public static ComponentTypeList With<T>(this ComponentTypeList src)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x66FFC60", Offset = "0x66FEE60", VA = "0x1866FFC60")]
		public static ComponentTypeList With(this ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x66FFAE0", Offset = "0x66FECE0", VA = "0x1866FFAE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C7980", Offset = "0x18C6B80", VA = "0x1818C7980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6701E00", Offset = "0x6701000", VA = "0x186701E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67015C0", Offset = "0x67007C0", VA = "0x1867015C0")]
		private void ComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6701790", Offset = "0x6700990", VA = "0x186701790")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6701710", Offset = "0x6700910", VA = "0x186701710")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6701AF0", Offset = "0x6700CF0", VA = "0x186701AF0")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67019D0", Offset = "0x6700BD0", VA = "0x1867019D0")]
		public ComponentTypes32(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6701B40", Offset = "0x6700D40", VA = "0x186701B40")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6701BD0", Offset = "0x6700DD0", VA = "0x186701BD0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6701A40", Offset = "0x6700C40", VA = "0x186701A40")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6701920", Offset = "0x6700B20", VA = "0x186701920")]
		public ComponentTypes32(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6701C70", Offset = "0x6700E70", VA = "0x186701C70")]
		public ComponentTypes32(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x67015B0", Offset = "0x67007B0", VA = "0x1867015B0")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x67017A0", Offset = "0x67009A0", VA = "0x1867017A0")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x67017C0", Offset = "0x67009C0", VA = "0x1867017C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x67028D0", Offset = "0x6701AD0", VA = "0x1867028D0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, SystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x67027F0", Offset = "0x67019F0", VA = "0x1867027F0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x67029B0", Offset = "0x6701BB0", VA = "0x1867029B0")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6702BD0", Offset = "0x6701DD0", VA = "0x186702BD0")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6702AA0", Offset = "0x6701CA0", VA = "0x186702AA0")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6702B90", Offset = "0x6701D90", VA = "0x186702B90")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6702CC0", Offset = "0x6701EC0", VA = "0x186702CC0")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6702BB0", Offset = "0x6701DB0", VA = "0x186702BB0")]
		public static EntityQueryDesc WithFilterWriteGroup(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6702580", Offset = "0x6701780", VA = "0x186702580")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C170", Offset = "0x1E6B370", VA = "0x181E6C170")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C0E0", Offset = "0x1E6B2E0", VA = "0x181E6C0E0")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C0E0", Offset = "0x1E6B2E0", VA = "0x181E6C0E0")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C0E0", Offset = "0x1E6B2E0", VA = "0x181E6C0E0")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C0E0", Offset = "0x1E6B2E0", VA = "0x181E6C0E0")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C110", Offset = "0x1E6B310", VA = "0x181E6C110")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C140", Offset = "0x1E6B340", VA = "0x181E6C140")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C140", Offset = "0x1E6B340", VA = "0x181E6C140")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1E67270", Offset = "0x1E66470", VA = "0x181E67270")]
		private static ComponentType[] Expand<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1E67370", Offset = "0x1E66570", VA = "0x181E67370")]
		private static ComponentType[] Expand<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1E67680", Offset = "0x1E66880", VA = "0x181E67680")]
		private static ComponentType[] Expand<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1E68DD0", Offset = "0x1E67FD0", VA = "0x181E68DD0")]
		private static ComponentType[] Expand<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6702720", Offset = "0x6701920", VA = "0x186702720")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D1F7A0", Offset = "0x1D1E9A0", VA = "0x181D1F7A0")]
		public static void RemoveAtSwapBack<T>(this DynamicBuffer<T> buffer, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1D1F4B0", Offset = "0x1D1E6B0", VA = "0x181D1F4B0")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1D1F820", Offset = "0x1D1EA20", VA = "0x181D1F820")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1D1F660", Offset = "0x1D1E860", VA = "0x181D1F660")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1D1F890", Offset = "0x1D1EA90", VA = "0x181D1F890")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class EntityManagerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6701F30", Offset = "0x6701130", VA = "0x186701F30")]
		public static EntityArchetype CreateArchetype(this EntityManager entityManager, Span<ComponentType> types)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6701FB0", Offset = "0x67011B0", VA = "0x186701FB0")]
		public static EntityArchetype GetArchetype(this EntityManager entityManager, Entity entity)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1E61420", Offset = "0x1E60620", VA = "0x181E61420")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, out DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1E611E0", Offset = "0x1E603E0", VA = "0x181E611E0")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, out DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1E60720", Offset = "0x1E5F920", VA = "0x181E60720")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1E60820", Offset = "0x1E5FA20", VA = "0x181E60820")]
		public static DynamicBuffer<T> GetBufferRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E614B0", Offset = "0x1E606B0", VA = "0x181E614B0")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E62450", Offset = "0x1E61650", VA = "0x181E62450")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6701FE0", Offset = "0x67011E0", VA = "0x186701FE0")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E61190", Offset = "0x1E60390", VA = "0x181E61190")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E62390", Offset = "0x1E61590", VA = "0x181E62390")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, out T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1E60D70", Offset = "0x1E5FF70", VA = "0x181E60D70")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6703030", Offset = "0x6702230", VA = "0x186703030")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6702FE0", Offset = "0x67021E0", VA = "0x186702FE0")]
		public static bool IsEmpty(this EntityQuery entityQuery, out int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C9E0", Offset = "0x1E6BBE0", VA = "0x181E6C9E0")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1E6CA20", Offset = "0x1E6BC20", VA = "0x181E6CA20")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6703530", Offset = "0x6702730", VA = "0x186703530")]
		public static EntityQuery WithChangedVersionFilter(this EntityQuery entityQuery, ComponentType componentType)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6703500", Offset = "0x6702700", VA = "0x186703500")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C760", Offset = "0x1E6B960", VA = "0x181E6C760")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C670", Offset = "0x1E6B870", VA = "0x181E6C670")]
		public static NativeArray<T> ToComponentDataArrayRun<T>(this EntityQuery entityQuery, Allocator allocator) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6703070", Offset = "0x6702270", VA = "0x186703070")]
		public static NativeArray<byte> ToComponentDataArrayRun(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6703390", Offset = "0x6702590", VA = "0x186703390")]
		public static NativeArray<Entity> ToEntityArrayRun(this EntityQuery entityQuery, Allocator allocator)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6702CE0", Offset = "0x6701EE0", VA = "0x186702CE0")]
		private static NativeArray<byte> CreateComponentDataArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkComponentType type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C190", Offset = "0x1E6B390", VA = "0x181E6C190")]
		private static NativeArray<T> CreateComponentDataArrayRun<T>(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkComponentType<T> type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6702E90", Offset = "0x6702090", VA = "0x186702E90")]
		private static NativeArray<Entity> CreateEntityArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkEntityType type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6703280", Offset = "0x6702480", VA = "0x186703280")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C2F0", Offset = "0x1E6B4F0", VA = "0x181E6C2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27D55A0", Offset = "0x27D47A0", VA = "0x1827D55A0")]
		public static Memory<T> Rent<T>(int count)
		{
			return default(Memory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x27D5820", Offset = "0x27D4A20", VA = "0x1827D5820")]
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
			[Cpp2IlInjected.Address(RVA = "0x1A71430", Offset = "0x1A70630", VA = "0x181A71430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x47B66B0", Offset = "0x47B58B0", VA = "0x1847B66B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7DA2E0", Offset = "0x7D94E0", VA = "0x1807DA2E0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1A71420", Offset = "0x1A70620", VA = "0x181A71420")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1A71040", Offset = "0x1A70240", VA = "0x181A71040")]
		public NativeArray<T> Complete()
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x47B5EC0", Offset = "0x47B50C0", VA = "0x1847B5EC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x47B6090", Offset = "0x47B5290", VA = "0x1847B6090")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6703CB0", Offset = "0x6702EB0", VA = "0x186703CB0")]
		public static JobHandle CombineHandles(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1C84290", Offset = "0x1C83490", VA = "0x181C84290")]
		public static JobHandle CombineHandles<T>(this JobHandle a, NativeArrayAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1C84290", Offset = "0x1C83490", VA = "0x181C84290")]
		public static JobHandle CombineHandles<T>(this JobHandle a, NativeListAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1C84240", Offset = "0x1C83440", VA = "0x181C84240")]
		public static JobHandle CombineHandles<T>(this NativeListAsync<T> a, NativeListAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6703CF0", Offset = "0x6702EF0", VA = "0x186703CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1A71430", Offset = "0x1A70630", VA = "0x181A71430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7DA2E0", Offset = "0x7D94E0", VA = "0x1807DA2E0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1A71420", Offset = "0x1A70620", VA = "0x181A71420")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1A70EA0", Offset = "0x1A700A0", VA = "0x181A70EA0")]
		public NativeArrayAsync<T> AsDeferredArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1A71040", Offset = "0x1A70240", VA = "0x181A71040")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1A712F0", Offset = "0x1A704F0", VA = "0x181A712F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1A71080", Offset = "0x1A70280", VA = "0x181A71080")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D5FED0", Offset = "0x4D5F0D0", VA = "0x184D5FED0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4D5FD70", Offset = "0x4D5EF70", VA = "0x184D5FD70")]
		public static Span<T> AsSpan<T>(this NativeList<T> list) where T : struct
		{
			return default(Span<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class StructUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2A6EE70", Offset = "0x2A6E070", VA = "0x182A6EE70")]
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
			[Cpp2IlInjected.Address(RVA = "0x6703DF0", Offset = "0x6702FF0", VA = "0x186703DF0")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6703DA0", Offset = "0x6702FA0", VA = "0x186703DA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6703760", Offset = "0x6702960", VA = "0x186703760")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6703990", Offset = "0x6702B90", VA = "0x186703990")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x67036A0", Offset = "0x67028A0", VA = "0x1867036A0")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6703570", Offset = "0x6702770", VA = "0x186703570")]
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
		[Cpp2IlInjected.Address(RVA = "0x6702270", Offset = "0x6701470", VA = "0x186702270")]
		public static bool TryGetChildEntitySubArrayRO(this in EntityManager entityManager, Entity parentEntity, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x67024A0", Offset = "0x67016A0", VA = "0x1867024A0")]
		public static bool TryGetChildEntitySubArray(this in BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6702370", Offset = "0x6701570", VA = "0x186702370")]
		public static bool TryGetChildEntitySubArray(this in DynamicBuffer<LinkedEntityGroup> buffer, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6702180", Offset = "0x6701380", VA = "0x186702180")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x67020A0", Offset = "0x67012A0", VA = "0x1867020A0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
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
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
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

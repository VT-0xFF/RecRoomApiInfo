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
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MGBKLBKEHEP
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct FNBODMLCCAN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private EntityManager AIFDIGHJEAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeArray<Entity> NBDCDJJEKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int LHHBOCAHDEE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T ILEBONKALNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2993690", Offset = "0x2991E90", VA = "0x182993690")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2993700", Offset = "0x2991F00", VA = "0x182993700")]
		public FNBODMLCCAN(NativeArray<Entity> NBDCDJJEKHD, EntityManager AIFDIGHJEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x29936F0", Offset = "0x2991EF0", VA = "0x1829936F0")]
		public bool GNDCJMNCJLD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1C5D730", Offset = "0x1C5BF30", VA = "0x181C5D730")]
		public FNBODMLCCAN<T> GCCEKDHECEG()
		{
			return default(FNBODMLCCAN<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct EHLNJJFLHJO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityManager AIFDIGHJEAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeArray<Entity> NBDCDJJEKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int LHHBOCAHDEE;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EC80", Offset = "0x2A9D480", VA = "0x182A9EC80")]
	public static bool BIJBAFFKCJE<T>(this NativeArray<T> NPHADDCNBHE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EF90", Offset = "0x2A9D790", VA = "0x182A9EF90")]
	public static string NKLBGMAEEHI<T>(this NativeList<T> HGPMCGJIADE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A9ED90", Offset = "0x2A9D590", VA = "0x182A9ED90")]
	public static string NKLBGMAEEHI<T>(this NativeArray<T> CIMBPHJAHGJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A9ECF0", Offset = "0x2A9D4F0", VA = "0x182A9ECF0")]
	public static FNBODMLCCAN<T> IDAGCJKEHGF<T>(this NativeList<Entity> OBDFPODMPBN, EntityManager AIFDIGHJEAF) where T : class
	{
		return default(FNBODMLCCAN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A9ECB0", Offset = "0x2A9D4B0", VA = "0x182A9ECB0")]
	public static FNBODMLCCAN<T> IDAGCJKEHGF<T>(this NativeArray<Entity> OBDFPODMPBN, EntityManager AIFDIGHJEAF) where T : class
	{
		return default(FNBODMLCCAN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KFHNAHIHKKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DKLGGKBKEIG
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
		[Cpp2IlInjected.Address(RVA = "0x65380D0", Offset = "0x65368D0", VA = "0x1865380D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6538300", Offset = "0x6536B00", VA = "0x186538300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65382E0", Offset = "0x6536AE0", VA = "0x1865382E0")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityComponentStore* entityComponentStoreComponentStore)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3A9E380", Offset = "0x3A9CB80", VA = "0x183A9E380")]
		public bool Exists(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65381A0", Offset = "0x65369A0", VA = "0x1865381A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6539CB0", Offset = "0x65384B0", VA = "0x186539CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6539D00", Offset = "0x6538500", VA = "0x186539D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6538CB0", Offset = "0x65374B0", VA = "0x186538CB0")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6538C30", Offset = "0x6537430", VA = "0x186538C30")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6539BB0", Offset = "0x65383B0", VA = "0x186539BB0")]
		public ComponentTypeList(ComponentTypeList a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6539AE0", Offset = "0x65382E0", VA = "0x186539AE0")]
		public ComponentTypeList(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x65399E0", Offset = "0x65381E0", VA = "0x1865399E0")]
		public ComponentTypeList(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6539130", Offset = "0x6537930", VA = "0x186539130")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6539010", Offset = "0x6537810", VA = "0x186539010")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6538EF0", Offset = "0x65376F0", VA = "0x186538EF0")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65395F0", Offset = "0x6537DF0", VA = "0x1865395F0")]
		public ComponentTypeList(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6539240", Offset = "0x6537A40", VA = "0x186539240")]
		public ComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x65385B0", Offset = "0x6536DB0", VA = "0x1865385B0")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6538D30", Offset = "0x6537530", VA = "0x186538D30")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6538800", Offset = "0x6537000", VA = "0x186538800")]
		public static ComponentTypeList Add(in ComponentTypeList a, in ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x65383A0", Offset = "0x6536BA0", VA = "0x1865383A0")]
		public static ComponentTypeList Add(in ComponentTypeList src, params ComponentType[] additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6538B10", Offset = "0x6537310", VA = "0x186538B10")]
		public static ComponentTypeList Add(in ComponentTypeList src, IEnumerable<ComponentType> additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6538D90", Offset = "0x6537590", VA = "0x186538D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class ComponentTypeListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x22F3710", Offset = "0x22F1F10", VA = "0x1822F3710")]
		public static ComponentTypeList With<T>(this ComponentTypeList src)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6538520", Offset = "0x6536D20", VA = "0x186538520")]
		public static ComponentTypeList With(this ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x65383A0", Offset = "0x6536BA0", VA = "0x1865383A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x87B750", Offset = "0x879F50", VA = "0x18087B750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x653A6C0", Offset = "0x6538EC0", VA = "0x18653A6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6539E80", Offset = "0x6538680", VA = "0x186539E80")]
		private void ComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x653A050", Offset = "0x6538850", VA = "0x18653A050")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6539FD0", Offset = "0x65387D0", VA = "0x186539FD0")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x653A3B0", Offset = "0x6538BB0", VA = "0x18653A3B0")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x653A290", Offset = "0x6538A90", VA = "0x18653A290")]
		public ComponentTypes32(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x653A400", Offset = "0x6538C00", VA = "0x18653A400")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x653A490", Offset = "0x6538C90", VA = "0x18653A490")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x653A300", Offset = "0x6538B00", VA = "0x18653A300")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x653A1E0", Offset = "0x65389E0", VA = "0x18653A1E0")]
		public ComponentTypes32(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x653A530", Offset = "0x6538D30", VA = "0x18653A530")]
		public ComponentTypes32(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6539E70", Offset = "0x6538670", VA = "0x186539E70")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x653A060", Offset = "0x6538860", VA = "0x18653A060")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x653A080", Offset = "0x6538880", VA = "0x18653A080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x653B190", Offset = "0x6539990", VA = "0x18653B190")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, SystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x653B0B0", Offset = "0x65398B0", VA = "0x18653B0B0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x653B270", Offset = "0x6539A70", VA = "0x18653B270")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x653B490", Offset = "0x6539C90", VA = "0x18653B490")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x653B360", Offset = "0x6539B60", VA = "0x18653B360")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x653B450", Offset = "0x6539C50", VA = "0x18653B450")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x653B580", Offset = "0x6539D80", VA = "0x18653B580")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x653B470", Offset = "0x6539C70", VA = "0x18653B470")]
		public static EntityQueryDesc WithFilterWriteGroup(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x653AE40", Offset = "0x6539640", VA = "0x18653AE40")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2454A70", Offset = "0x2453270", VA = "0x182454A70")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x24549E0", Offset = "0x24531E0", VA = "0x1824549E0")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x24549E0", Offset = "0x24531E0", VA = "0x1824549E0")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x24549E0", Offset = "0x24531E0", VA = "0x1824549E0")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x24549E0", Offset = "0x24531E0", VA = "0x1824549E0")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2454A10", Offset = "0x2453210", VA = "0x182454A10")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2454A40", Offset = "0x2453240", VA = "0x182454A40")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2454A40", Offset = "0x2453240", VA = "0x182454A40")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x244FB70", Offset = "0x244E370", VA = "0x18244FB70")]
		private static ComponentType[] Expand<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x244FDF0", Offset = "0x244E5F0", VA = "0x18244FDF0")]
		private static ComponentType[] Expand<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2450460", Offset = "0x244EC60", VA = "0x182450460")]
		private static ComponentType[] Expand<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2451CC0", Offset = "0x24504C0", VA = "0x182451CC0")]
		private static ComponentType[] Expand<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x653AFE0", Offset = "0x65397E0", VA = "0x18653AFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x230DCF0", Offset = "0x230C4F0", VA = "0x18230DCF0")]
		public static void RemoveAtSwapBack<T>(this DynamicBuffer<T> buffer, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x230DA00", Offset = "0x230C200", VA = "0x18230DA00")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x230DD70", Offset = "0x230C570", VA = "0x18230DD70")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x230DBB0", Offset = "0x230C3B0", VA = "0x18230DBB0")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x230DDE0", Offset = "0x230C5E0", VA = "0x18230DDE0")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class EntityManagerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x653A7F0", Offset = "0x6538FF0", VA = "0x18653A7F0")]
		public static EntityArchetype CreateArchetype(this EntityManager entityManager, Span<ComponentType> types)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x653A870", Offset = "0x6539070", VA = "0x18653A870")]
		public static EntityArchetype GetArchetype(this EntityManager entityManager, Entity entity)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2449D20", Offset = "0x2448520", VA = "0x182449D20")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, out DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2449AE0", Offset = "0x24482E0", VA = "0x182449AE0")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, out DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2449020", Offset = "0x2447820", VA = "0x182449020")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2449120", Offset = "0x2447920", VA = "0x182449120")]
		public static DynamicBuffer<T> GetBufferRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2449DB0", Offset = "0x24485B0", VA = "0x182449DB0")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x244AD50", Offset = "0x2449550", VA = "0x18244AD50")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x653A8A0", Offset = "0x65390A0", VA = "0x18653A8A0")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2449A90", Offset = "0x2448290", VA = "0x182449A90")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x244AC90", Offset = "0x2449490", VA = "0x18244AC90")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, out T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2449790", Offset = "0x2447F90", VA = "0x182449790")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x653B8F0", Offset = "0x653A0F0", VA = "0x18653B8F0")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x653B8A0", Offset = "0x653A0A0", VA = "0x18653B8A0")]
		public static bool IsEmpty(this EntityQuery entityQuery, out int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x24552E0", Offset = "0x2453AE0", VA = "0x1824552E0")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2455320", Offset = "0x2453B20", VA = "0x182455320")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x653BDF0", Offset = "0x653A5F0", VA = "0x18653BDF0")]
		public static EntityQuery WithChangedVersionFilter(this EntityQuery entityQuery, ComponentType componentType)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x653BDC0", Offset = "0x653A5C0", VA = "0x18653BDC0")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2455060", Offset = "0x2453860", VA = "0x182455060")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2454F70", Offset = "0x2453770", VA = "0x182454F70")]
		public static NativeArray<T> ToComponentDataArrayRun<T>(this EntityQuery entityQuery, Allocator allocator) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x653B930", Offset = "0x653A130", VA = "0x18653B930")]
		public static NativeArray<byte> ToComponentDataArrayRun(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x653BC50", Offset = "0x653A450", VA = "0x18653BC50")]
		public static NativeArray<Entity> ToEntityArrayRun(this EntityQuery entityQuery, Allocator allocator)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x653B5A0", Offset = "0x6539DA0", VA = "0x18653B5A0")]
		private static NativeArray<byte> CreateComponentDataArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkComponentType type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2454A90", Offset = "0x2453290", VA = "0x182454A90")]
		private static NativeArray<T> CreateComponentDataArrayRun<T>(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkComponentType<T> type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x653B750", Offset = "0x6539F50", VA = "0x18653B750")]
		private static NativeArray<Entity> CreateEntityArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkEntityType type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x653BB40", Offset = "0x653A340", VA = "0x18653BB40")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2454BF0", Offset = "0x24533F0", VA = "0x182454BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F0D730", Offset = "0x1F0BF30", VA = "0x181F0D730")]
		public static Memory<T> Rent<T>(int count)
		{
			return default(Memory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1F0D9B0", Offset = "0x1F0C1B0", VA = "0x181F0D9B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AFE5B0", Offset = "0x2AFCDB0", VA = "0x182AFE5B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE5F0", Offset = "0x2AFCDF0", VA = "0x182AFE5F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xC3D8C0", Offset = "0xC3C0C0", VA = "0x180C3D8C0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x19498B0", Offset = "0x19480B0", VA = "0x1819498B0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x204EA00", Offset = "0x204D200", VA = "0x18204EA00")]
		public NativeArray<T> Complete()
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDFB0", Offset = "0x2AFC7B0", VA = "0x182AFDFB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDEE0", Offset = "0x2AFC6E0", VA = "0x182AFDEE0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x653C3A0", Offset = "0x653ABA0", VA = "0x18653C3A0")]
		public static JobHandle CombineHandles(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x35EE940", Offset = "0x35ED140", VA = "0x1835EE940")]
		public static JobHandle CombineHandles<T>(this JobHandle a, NativeArrayAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x35EE940", Offset = "0x35ED140", VA = "0x1835EE940")]
		public static JobHandle CombineHandles<T>(this JobHandle a, NativeListAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x35EE990", Offset = "0x35ED190", VA = "0x1835EE990")]
		public static JobHandle CombineHandles<T>(this NativeListAsync<T> a, NativeListAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x653C3E0", Offset = "0x653ABE0", VA = "0x18653C3E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x204ED30", Offset = "0x204D530", VA = "0x18204ED30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x19498B0", Offset = "0x19480B0", VA = "0x1819498B0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x204E860", Offset = "0x204D060", VA = "0x18204E860")]
		public NativeArrayAsync<T> AsDeferredArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x204EA00", Offset = "0x204D200", VA = "0x18204EA00")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x204EB10", Offset = "0x204D310", VA = "0x18204EB10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x204EC60", Offset = "0x204D460", VA = "0x18204EC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DAD910", Offset = "0x4DAC110", VA = "0x184DAD910")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4DADA60", Offset = "0x4DAC260", VA = "0x184DADA60")]
		public static Span<T> AsSpan<T>(this NativeList<T> list) where T : struct
		{
			return default(Span<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class StructUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3F20", Offset = "0x3AF2720", VA = "0x183AF3F20")]
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
			[Cpp2IlInjected.Address(RVA = "0x653C6B0", Offset = "0x653AEB0", VA = "0x18653C6B0")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x653C660", Offset = "0x653AE60", VA = "0x18653C660", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x653C020", Offset = "0x653A820", VA = "0x18653C020")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x653C250", Offset = "0x653AA50", VA = "0x18653C250")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x653BF60", Offset = "0x653A760", VA = "0x18653BF60")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x653BE30", Offset = "0x653A630", VA = "0x18653BE30")]
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
		[Cpp2IlInjected.Address(RVA = "0x653AB30", Offset = "0x6539330", VA = "0x18653AB30")]
		public static bool TryGetChildEntitySubArrayRO(this in EntityManager entityManager, Entity parentEntity, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x653AD60", Offset = "0x6539560", VA = "0x18653AD60")]
		public static bool TryGetChildEntitySubArray(this in BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x653AC30", Offset = "0x6539430", VA = "0x18653AC30")]
		public static bool TryGetChildEntitySubArray(this in DynamicBuffer<LinkedEntityGroup> buffer, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x653AA40", Offset = "0x6539240", VA = "0x18653AA40")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x653A960", Offset = "0x6539160", VA = "0x18653A960")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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

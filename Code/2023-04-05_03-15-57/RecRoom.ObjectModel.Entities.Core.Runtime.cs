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
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JHKHJDAPJDO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct EPMKAAKOKHK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private EntityManager JGDEKKJFKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeArray<Entity> GMAMPIGCEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int EGBCAPEEJBF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T AGGOFNFHANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2029400", Offset = "0x2028400", VA = "0x182029400")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2029470", Offset = "0x2028470", VA = "0x182029470")]
		public EPMKAAKOKHK(NativeArray<Entity> GMAMPIGCEAB, EntityManager JGDEKKJFKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2029460", Offset = "0x2028460", VA = "0x182029460")]
		public bool JPIMAEJBKHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x11155A0", Offset = "0x11145A0", VA = "0x1811155A0")]
		public EPMKAAKOKHK<T> KGLEFCHHJJI()
		{
			return default(EPMKAAKOKHK<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct HKLNNLBMDBB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityManager JGDEKKJFKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeArray<Entity> GMAMPIGCEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int EGBCAPEEJBF;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x294E7A0", Offset = "0x294D7A0", VA = "0x18294E7A0")]
	public static bool CFLJFFCDDJL<T>(this NativeArray<T> KPPLMEOMNGF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x294E9D0", Offset = "0x294D9D0", VA = "0x18294E9D0")]
	public static string DCGFMADGGPN<T>(this NativeList<T> EHJGMBFBLBN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x294E7D0", Offset = "0x294D7D0", VA = "0x18294E7D0")]
	public static string DCGFMADGGPN<T>(this NativeArray<T> EGIDMCNFHCK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x294EA60", Offset = "0x294DA60", VA = "0x18294EA60")]
	public static EPMKAAKOKHK<T> PMDCHJDDIAC<T>(this NativeList<Entity> BMGAIMDJMKP, EntityManager JGDEKKJFKAJ) where T : class
	{
		return default(EPMKAAKOKHK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x294EA20", Offset = "0x294DA20", VA = "0x18294EA20")]
	public static EPMKAAKOKHK<T> PMDCHJDDIAC<T>(this NativeArray<Entity> BMGAIMDJMKP, EntityManager JGDEKKJFKAJ) where T : class
	{
		return default(EPMKAAKOKHK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class AHHHGMKMLKB
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NDCLLLIMLML
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
		[Cpp2IlInjected.Address(RVA = "0x65E3B20", Offset = "0x65E2B20", VA = "0x1865E3B20")]
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
			[Cpp2IlInjected.Address(RVA = "0x65E3D50", Offset = "0x65E2D50", VA = "0x1865E3D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65E3D30", Offset = "0x65E2D30", VA = "0x1865E3D30")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityComponentStore* entityComponentStoreComponentStore)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x33910F0", Offset = "0x33900F0", VA = "0x1833910F0")]
		public bool Exists(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65E3BF0", Offset = "0x65E2BF0", VA = "0x1865E3BF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x65E5700", Offset = "0x65E4700", VA = "0x1865E5700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x65E5750", Offset = "0x65E4750", VA = "0x1865E5750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x65E4700", Offset = "0x65E3700", VA = "0x1865E4700")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x65E4680", Offset = "0x65E3680", VA = "0x1865E4680")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x65E5600", Offset = "0x65E4600", VA = "0x1865E5600")]
		public ComponentTypeList(ComponentTypeList a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x65E5530", Offset = "0x65E4530", VA = "0x1865E5530")]
		public ComponentTypeList(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x65E5430", Offset = "0x65E4430", VA = "0x1865E5430")]
		public ComponentTypeList(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x65E4B80", Offset = "0x65E3B80", VA = "0x1865E4B80")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x65E4A60", Offset = "0x65E3A60", VA = "0x1865E4A60")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x65E4940", Offset = "0x65E3940", VA = "0x1865E4940")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65E5040", Offset = "0x65E4040", VA = "0x1865E5040")]
		public ComponentTypeList(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x65E4C90", Offset = "0x65E3C90", VA = "0x1865E4C90")]
		public ComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x65E4000", Offset = "0x65E3000", VA = "0x1865E4000")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x65E4780", Offset = "0x65E3780", VA = "0x1865E4780")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65E4250", Offset = "0x65E3250", VA = "0x1865E4250")]
		public static ComponentTypeList Add(in ComponentTypeList a, in ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x65E3DF0", Offset = "0x65E2DF0", VA = "0x1865E3DF0")]
		public static ComponentTypeList Add(in ComponentTypeList src, params ComponentType[] additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x65E4560", Offset = "0x65E3560", VA = "0x1865E4560")]
		public static ComponentTypeList Add(in ComponentTypeList src, IEnumerable<ComponentType> additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x65E47E0", Offset = "0x65E37E0", VA = "0x1865E47E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class ComponentTypeListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2125C20", Offset = "0x2124C20", VA = "0x182125C20")]
		public static ComponentTypeList With<T>(this ComponentTypeList src)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x65E3F70", Offset = "0x65E2F70", VA = "0x1865E3F70")]
		public static ComponentTypeList With(this ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x65E3DF0", Offset = "0x65E2DF0", VA = "0x1865E3DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x885750", Offset = "0x884750", VA = "0x180885750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x65E6110", Offset = "0x65E5110", VA = "0x1865E6110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x65E58D0", Offset = "0x65E48D0", VA = "0x1865E58D0")]
		private void ComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x65E5AA0", Offset = "0x65E4AA0", VA = "0x1865E5AA0")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x65E5A20", Offset = "0x65E4A20", VA = "0x1865E5A20")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x65E5E00", Offset = "0x65E4E00", VA = "0x1865E5E00")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x65E5CE0", Offset = "0x65E4CE0", VA = "0x1865E5CE0")]
		public ComponentTypes32(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x65E5E50", Offset = "0x65E4E50", VA = "0x1865E5E50")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x65E5EE0", Offset = "0x65E4EE0", VA = "0x1865E5EE0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x65E5D50", Offset = "0x65E4D50", VA = "0x1865E5D50")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x65E5C30", Offset = "0x65E4C30", VA = "0x1865E5C30")]
		public ComponentTypes32(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x65E5F80", Offset = "0x65E4F80", VA = "0x1865E5F80")]
		public ComponentTypes32(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x65E58C0", Offset = "0x65E48C0", VA = "0x1865E58C0")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x65E5AB0", Offset = "0x65E4AB0", VA = "0x1865E5AB0")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x65E5AD0", Offset = "0x65E4AD0", VA = "0x1865E5AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x65E6BE0", Offset = "0x65E5BE0", VA = "0x1865E6BE0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, SystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x65E6B00", Offset = "0x65E5B00", VA = "0x1865E6B00")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x65E6CC0", Offset = "0x65E5CC0", VA = "0x1865E6CC0")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x65E6EE0", Offset = "0x65E5EE0", VA = "0x1865E6EE0")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x65E6DB0", Offset = "0x65E5DB0", VA = "0x1865E6DB0")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x65E6EA0", Offset = "0x65E5EA0", VA = "0x1865E6EA0")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x65E6FD0", Offset = "0x65E5FD0", VA = "0x1865E6FD0")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x65E6EC0", Offset = "0x65E5EC0", VA = "0x1865E6EC0")]
		public static EntityQueryDesc WithFilterWriteGroup(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x65E6890", Offset = "0x65E5890", VA = "0x1865E6890")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1E32820", Offset = "0x1E31820", VA = "0x181E32820")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1E327F0", Offset = "0x1E317F0", VA = "0x181E327F0")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1E327F0", Offset = "0x1E317F0", VA = "0x181E327F0")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1E327F0", Offset = "0x1E317F0", VA = "0x181E327F0")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1E327F0", Offset = "0x1E317F0", VA = "0x181E327F0")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x27DE250", Offset = "0x27DD250", VA = "0x1827DE250")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x27DE280", Offset = "0x27DD280", VA = "0x1827DE280")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x27DE280", Offset = "0x27DD280", VA = "0x1827DE280")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DAE0", Offset = "0x1E2CAE0", VA = "0x181E2DAE0")]
		private static ComponentType[] Expand<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D980", Offset = "0x1E2C980", VA = "0x181E2D980")]
		private static ComponentType[] Expand<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E1D0", Offset = "0x1E2D1D0", VA = "0x181E2E1D0")]
		private static ComponentType[] Expand<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1E30BC0", Offset = "0x1E2FBC0", VA = "0x181E30BC0")]
		private static ComponentType[] Expand<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x65E6A30", Offset = "0x65E5A30", VA = "0x1865E6A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x21426D0", Offset = "0x21416D0", VA = "0x1821426D0")]
		public static void RemoveAtSwapBack<T>(this DynamicBuffer<T> buffer, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x21423E0", Offset = "0x21413E0", VA = "0x1821423E0")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2142750", Offset = "0x2141750", VA = "0x182142750")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2142590", Offset = "0x2141590", VA = "0x182142590")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x21427C0", Offset = "0x21417C0", VA = "0x1821427C0")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class EntityManagerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x65E6240", Offset = "0x65E5240", VA = "0x1865E6240")]
		public static EntityArchetype CreateArchetype(this EntityManager entityManager, Span<ComponentType> types)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x65E62C0", Offset = "0x65E52C0", VA = "0x1865E62C0")]
		public static EntityArchetype GetArchetype(this EntityManager entityManager, Entity entity)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1E27A40", Offset = "0x1E26A40", VA = "0x181E27A40")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, out DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1E27800", Offset = "0x1E26800", VA = "0x181E27800")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, out DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1E26D40", Offset = "0x1E25D40", VA = "0x181E26D40")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1E26E40", Offset = "0x1E25E40", VA = "0x181E26E40")]
		public static DynamicBuffer<T> GetBufferRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E27AD0", Offset = "0x1E26AD0", VA = "0x181E27AD0")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E28A60", Offset = "0x1E27A60", VA = "0x181E28A60")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x65E62F0", Offset = "0x65E52F0", VA = "0x1865E62F0")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E277B0", Offset = "0x1E267B0", VA = "0x181E277B0")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E289A0", Offset = "0x1E279A0", VA = "0x181E289A0")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, out T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1E274B0", Offset = "0x1E264B0", VA = "0x181E274B0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x65E7340", Offset = "0x65E6340", VA = "0x1865E7340")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x65E72F0", Offset = "0x65E62F0", VA = "0x1865E72F0")]
		public static bool IsEmpty(this EntityQuery entityQuery, out int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x27DEA40", Offset = "0x27DDA40", VA = "0x1827DEA40")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x27DEA80", Offset = "0x27DDA80", VA = "0x1827DEA80")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x65E7840", Offset = "0x65E6840", VA = "0x1865E7840")]
		public static EntityQuery WithChangedVersionFilter(this EntityQuery entityQuery, ComponentType componentType)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x65E7810", Offset = "0x65E6810", VA = "0x1865E7810")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x27DE840", Offset = "0x27DD840", VA = "0x1827DE840")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x27DE750", Offset = "0x27DD750", VA = "0x1827DE750")]
		public static NativeArray<T> ToComponentDataArrayRun<T>(this EntityQuery entityQuery, Allocator allocator) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x65E7380", Offset = "0x65E6380", VA = "0x1865E7380")]
		public static NativeArray<byte> ToComponentDataArrayRun(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x65E76A0", Offset = "0x65E66A0", VA = "0x1865E76A0")]
		public static NativeArray<Entity> ToEntityArrayRun(this EntityQuery entityQuery, Allocator allocator)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x65E6FF0", Offset = "0x65E5FF0", VA = "0x1865E6FF0")]
		private static NativeArray<byte> CreateComponentDataArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkComponentType type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x27DE2B0", Offset = "0x27DD2B0", VA = "0x1827DE2B0")]
		private static NativeArray<T> CreateComponentDataArrayRun<T>(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkComponentType<T> type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x65E71A0", Offset = "0x65E61A0", VA = "0x1865E71A0")]
		private static NativeArray<Entity> CreateEntityArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkEntityType type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x65E7590", Offset = "0x65E6590", VA = "0x1865E7590")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x27DE410", Offset = "0x27DD410", VA = "0x1827DE410")]
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
		[Cpp2IlInjected.Address(RVA = "0x277AEF0", Offset = "0x2779EF0", VA = "0x18277AEF0")]
		public static Memory<T> Rent<T>(int count)
		{
			return default(Memory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x277B170", Offset = "0x277A170", VA = "0x18277B170")]
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
			[Cpp2IlInjected.Address(RVA = "0x29D0D80", Offset = "0x29CFD80", VA = "0x1829D0D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x29D0DC0", Offset = "0x29CFDC0", VA = "0x1829D0DC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xCE53C0", Offset = "0xCE43C0", VA = "0x180CE53C0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xC478C0", Offset = "0xC468C0", VA = "0x180C478C0")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x20A60F0", Offset = "0x20A50F0", VA = "0x1820A60F0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x211B150", Offset = "0x211A150", VA = "0x18211B150")]
		public NativeArray<T> Complete()
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x29D05E0", Offset = "0x29CF5E0", VA = "0x1829D05E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x29D0B10", Offset = "0x29CFB10", VA = "0x1829D0B10")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x65E7FC0", Offset = "0x65E6FC0", VA = "0x1865E7FC0")]
		public static JobHandle CombineHandles(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x261B180", Offset = "0x261A180", VA = "0x18261B180")]
		public static JobHandle CombineHandles<T>(this JobHandle a, NativeArrayAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x261B180", Offset = "0x261A180", VA = "0x18261B180")]
		public static JobHandle CombineHandles<T>(this JobHandle a, NativeListAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x261B1D0", Offset = "0x261A1D0", VA = "0x18261B1D0")]
		public static JobHandle CombineHandles<T>(this NativeListAsync<T> a, NativeListAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x65E8000", Offset = "0x65E7000", VA = "0x1865E8000")]
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
			[Cpp2IlInjected.Address(RVA = "0x211B480", Offset = "0x211A480", VA = "0x18211B480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCE53C0", Offset = "0xCE43C0", VA = "0x180CE53C0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x20A60F0", Offset = "0x20A50F0", VA = "0x1820A60F0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x211AFB0", Offset = "0x2119FB0", VA = "0x18211AFB0")]
		public NativeArrayAsync<T> AsDeferredArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x211B150", Offset = "0x211A150", VA = "0x18211B150")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x211B400", Offset = "0x211A400", VA = "0x18211B400", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x211B330", Offset = "0x211A330", VA = "0x18211B330")]
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
		[Cpp2IlInjected.Address(RVA = "0x5A505D0", Offset = "0x5A4F5D0", VA = "0x185A505D0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5A50470", Offset = "0x5A4F470", VA = "0x185A50470")]
		public static Span<T> AsSpan<T>(this NativeList<T> list) where T : struct
		{
			return default(Span<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class StructUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x345E5F0", Offset = "0x345D5F0", VA = "0x18345E5F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x65E8100", Offset = "0x65E7100", VA = "0x1865E8100")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x65E80B0", Offset = "0x65E70B0", VA = "0x1865E80B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x65E7A70", Offset = "0x65E6A70", VA = "0x1865E7A70")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x65E7CA0", Offset = "0x65E6CA0", VA = "0x1865E7CA0")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x65E79B0", Offset = "0x65E69B0", VA = "0x1865E79B0")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x65E7880", Offset = "0x65E6880", VA = "0x1865E7880")]
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
		[Cpp2IlInjected.Address(RVA = "0x65E6580", Offset = "0x65E5580", VA = "0x1865E6580")]
		public static bool TryGetChildEntitySubArrayRO(this in EntityManager entityManager, Entity parentEntity, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x65E67B0", Offset = "0x65E57B0", VA = "0x1865E67B0")]
		public static bool TryGetChildEntitySubArray(this in BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x65E6680", Offset = "0x65E5680", VA = "0x1865E6680")]
		public static bool TryGetChildEntitySubArray(this in DynamicBuffer<LinkedEntityGroup> buffer, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x65E6490", Offset = "0x65E5490", VA = "0x1865E6490")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x65E63B0", Offset = "0x65E53B0", VA = "0x1865E63B0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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

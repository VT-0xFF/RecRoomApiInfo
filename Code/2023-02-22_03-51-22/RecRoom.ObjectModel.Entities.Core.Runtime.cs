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
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FJODMHKDIDE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct PLJOAMLOBDL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private EntityManager KNABDDPENKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeArray<Entity> GNGEEFEGDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int BELCAJFDAHD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x452DDD0", Offset = "0x452CFD0", VA = "0x18452DDD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x452DE30", Offset = "0x452D030", VA = "0x18452DE30")]
		public PLJOAMLOBDL(NativeArray<Entity> GNGEEFEGDCP, EntityManager KNABDDPENKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x452DDC0", Offset = "0x452CFC0", VA = "0x18452DDC0")]
		public bool DJDPPDACCLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1CD6AA0", Offset = "0x1CD5CA0", VA = "0x181CD6AA0")]
		public PLJOAMLOBDL<T> AHIPNMLLDNB()
		{
			return default(PLJOAMLOBDL<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct GOKBIBEBKKC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityManager KNABDDPENKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeArray<Entity> GNGEEFEGDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int BELCAJFDAHD;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2EA5260", Offset = "0x2EA4460", VA = "0x182EA5260")]
	public static bool LBAPGGCGMJM<T>(this NativeArray<T> JFBPNBNBHOE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2EA5130", Offset = "0x2EA4330", VA = "0x182EA5130")]
	public static string DMBJMBMLDPG<T>(this NativeList<T> NHOGENNANEB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4F30", Offset = "0x2EA4130", VA = "0x182EA4F30")]
	public static string DMBJMBMLDPG<T>(this NativeArray<T> PFCDNINKMFA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2EA5180", Offset = "0x2EA4380", VA = "0x182EA5180")]
	public static PLJOAMLOBDL<T> HLOBNGCLNGM<T>(this NativeList<Entity> LOKAAAHFJIL, EntityManager KNABDDPENKI) where T : class
	{
		return default(PLJOAMLOBDL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2EA5220", Offset = "0x2EA4420", VA = "0x182EA5220")]
	public static PLJOAMLOBDL<T> HLOBNGCLNGM<T>(this NativeArray<Entity> LOKAAAHFJIL, EntityManager KNABDDPENKI) where T : class
	{
		return default(PLJOAMLOBDL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LCMHLEEBIOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HJMFJPDDHDF
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
		[Cpp2IlInjected.Address(RVA = "0x63DDA90", Offset = "0x63DCC90", VA = "0x1863DDA90")]
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
			[Cpp2IlInjected.Address(RVA = "0x63DDCC0", Offset = "0x63DCEC0", VA = "0x1863DDCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x63DDCA0", Offset = "0x63DCEA0", VA = "0x1863DDCA0")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityComponentStore* entityComponentStoreComponentStore)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3BBD500", Offset = "0x3BBC700", VA = "0x183BBD500")]
		public bool Exists(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x63DDB60", Offset = "0x63DCD60", VA = "0x1863DDB60")]
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
			[Cpp2IlInjected.Address(RVA = "0x63DF670", Offset = "0x63DE870", VA = "0x1863DF670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x63DF6C0", Offset = "0x63DE8C0", VA = "0x1863DF6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x63DE670", Offset = "0x63DD870", VA = "0x1863DE670")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x63DE5F0", Offset = "0x63DD7F0", VA = "0x1863DE5F0")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x63DF570", Offset = "0x63DE770", VA = "0x1863DF570")]
		public ComponentTypeList(ComponentTypeList a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x63DF4A0", Offset = "0x63DE6A0", VA = "0x1863DF4A0")]
		public ComponentTypeList(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x63DF3A0", Offset = "0x63DE5A0", VA = "0x1863DF3A0")]
		public ComponentTypeList(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x63DEAF0", Offset = "0x63DDCF0", VA = "0x1863DEAF0")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x63DE9D0", Offset = "0x63DDBD0", VA = "0x1863DE9D0")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x63DE8B0", Offset = "0x63DDAB0", VA = "0x1863DE8B0")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x63DEFB0", Offset = "0x63DE1B0", VA = "0x1863DEFB0")]
		public ComponentTypeList(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x63DEC00", Offset = "0x63DDE00", VA = "0x1863DEC00")]
		public ComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x63DDF70", Offset = "0x63DD170", VA = "0x1863DDF70")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x63DE6F0", Offset = "0x63DD8F0", VA = "0x1863DE6F0")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63DE1C0", Offset = "0x63DD3C0", VA = "0x1863DE1C0")]
		public static ComponentTypeList Add(in ComponentTypeList a, in ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63DDD60", Offset = "0x63DCF60", VA = "0x1863DDD60")]
		public static ComponentTypeList Add(in ComponentTypeList src, params ComponentType[] additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x63DE4D0", Offset = "0x63DD6D0", VA = "0x1863DE4D0")]
		public static ComponentTypeList Add(in ComponentTypeList src, IEnumerable<ComponentType> additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x63DE750", Offset = "0x63DD950", VA = "0x1863DE750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class ComponentTypeListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x256C9A0", Offset = "0x256BBA0", VA = "0x18256C9A0")]
		public static ComponentTypeList With<T>(this ComponentTypeList src)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x63DDEE0", Offset = "0x63DD0E0", VA = "0x1863DDEE0")]
		public static ComponentTypeList With(this ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x63DDD60", Offset = "0x63DCF60", VA = "0x1863DDD60")]
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
			[Cpp2IlInjected.Address(RVA = "0x86D790", Offset = "0x86C990", VA = "0x18086D790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x63E0080", Offset = "0x63DF280", VA = "0x1863E0080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63DF840", Offset = "0x63DEA40", VA = "0x1863DF840")]
		private void ComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63DFA10", Offset = "0x63DEC10", VA = "0x1863DFA10")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63DF990", Offset = "0x63DEB90", VA = "0x1863DF990")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63DFD70", Offset = "0x63DEF70", VA = "0x1863DFD70")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63DFC50", Offset = "0x63DEE50", VA = "0x1863DFC50")]
		public ComponentTypes32(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63DFDC0", Offset = "0x63DEFC0", VA = "0x1863DFDC0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x63DFE50", Offset = "0x63DF050", VA = "0x1863DFE50")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63DFCC0", Offset = "0x63DEEC0", VA = "0x1863DFCC0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x63DFBA0", Offset = "0x63DEDA0", VA = "0x1863DFBA0")]
		public ComponentTypes32(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x63DFEF0", Offset = "0x63DF0F0", VA = "0x1863DFEF0")]
		public ComponentTypes32(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x63DF830", Offset = "0x63DEA30", VA = "0x1863DF830")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x63DFA20", Offset = "0x63DEC20", VA = "0x1863DFA20")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x63DFA40", Offset = "0x63DEC40", VA = "0x1863DFA40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x63E0D20", Offset = "0x63DFF20", VA = "0x1863E0D20")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, SystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x63E0C40", Offset = "0x63DFE40", VA = "0x1863E0C40")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x63E0E00", Offset = "0x63E0000", VA = "0x1863E0E00")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x63E1020", Offset = "0x63E0220", VA = "0x1863E1020")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x63E0EF0", Offset = "0x63E00F0", VA = "0x1863E0EF0")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x63E0FE0", Offset = "0x63E01E0", VA = "0x1863E0FE0")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63E1110", Offset = "0x63E0310", VA = "0x1863E1110")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63E1000", Offset = "0x63E0200", VA = "0x1863E1000")]
		public static EntityQueryDesc WithFilterWriteGroup(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x63E09D0", Offset = "0x63DFBD0", VA = "0x1863E09D0")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x252C1C0", Offset = "0x252B3C0", VA = "0x18252C1C0")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x252C130", Offset = "0x252B330", VA = "0x18252C130")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x252C130", Offset = "0x252B330", VA = "0x18252C130")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x252C130", Offset = "0x252B330", VA = "0x18252C130")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x252C130", Offset = "0x252B330", VA = "0x18252C130")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x252C160", Offset = "0x252B360", VA = "0x18252C160")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x252C190", Offset = "0x252B390", VA = "0x18252C190")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x252C190", Offset = "0x252B390", VA = "0x18252C190")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x25272C0", Offset = "0x25264C0", VA = "0x1825272C0")]
		private static ComponentType[] Expand<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2527440", Offset = "0x2526640", VA = "0x182527440")]
		private static ComponentType[] Expand<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2527C90", Offset = "0x2526E90", VA = "0x182527C90")]
		private static ComponentType[] Expand<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x252B640", Offset = "0x252A840", VA = "0x18252B640")]
		private static ComponentType[] Expand<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x63E0B70", Offset = "0x63DFD70", VA = "0x1863E0B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F94550", Offset = "0x1F93750", VA = "0x181F94550")]
		public static void RemoveAtSwapBack<T>(this DynamicBuffer<T> buffer, int index) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F93460", VA = "0x181F94260")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1F945D0", Offset = "0x1F937D0", VA = "0x181F945D0")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1F94380", Offset = "0x1F93580", VA = "0x181F94380")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1F94640", Offset = "0x1F93840", VA = "0x181F94640")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value, IEqualityComparer<T> equalityComparer) where T : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class EntityManagerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x63E0380", Offset = "0x63DF580", VA = "0x1863E0380")]
		public static EntityArchetype CreateArchetype(this EntityManager entityManager, Span<ComponentType> types)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x63E0400", Offset = "0x63DF600", VA = "0x1863E0400")]
		public static EntityArchetype GetArchetype(this EntityManager entityManager, Entity entity)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2525670", Offset = "0x2524870", VA = "0x182525670")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, out DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2525430", Offset = "0x2524630", VA = "0x182525430")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, out DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2524A90", Offset = "0x2523C90", VA = "0x182524A90")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2524BB0", Offset = "0x2523DB0", VA = "0x182524BB0")]
		public static DynamicBuffer<T> GetBufferRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2525700", Offset = "0x2524900", VA = "0x182525700")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x25266A0", Offset = "0x25258A0", VA = "0x1825266A0")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x63E0430", Offset = "0x63DF630", VA = "0x1863E0430")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x25253E0", Offset = "0x25245E0", VA = "0x1825253E0")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x25265E0", Offset = "0x25257E0", VA = "0x1825265E0")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, out T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2525150", Offset = "0x2524350", VA = "0x182525150")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x63E1480", Offset = "0x63E0680", VA = "0x1863E1480")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x63E1430", Offset = "0x63E0630", VA = "0x1863E1430")]
		public static bool IsEmpty(this EntityQuery entityQuery, out int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x252CA30", Offset = "0x252BC30", VA = "0x18252CA30")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x252CA70", Offset = "0x252BC70", VA = "0x18252CA70")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x63E1980", Offset = "0x63E0B80", VA = "0x1863E1980")]
		public static EntityQuery WithChangedVersionFilter(this EntityQuery entityQuery, ComponentType componentType)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63E1950", Offset = "0x63E0B50", VA = "0x1863E1950")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x252C7B0", Offset = "0x252B9B0", VA = "0x18252C7B0")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x252C6C0", Offset = "0x252B8C0", VA = "0x18252C6C0")]
		public static NativeArray<T> ToComponentDataArrayRun<T>(this EntityQuery entityQuery, Allocator allocator) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63E14C0", Offset = "0x63E06C0", VA = "0x1863E14C0")]
		public static NativeArray<byte> ToComponentDataArrayRun(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x63E17E0", Offset = "0x63E09E0", VA = "0x1863E17E0")]
		public static NativeArray<Entity> ToEntityArrayRun(this EntityQuery entityQuery, Allocator allocator)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x63E1130", Offset = "0x63E0330", VA = "0x1863E1130")]
		private static NativeArray<byte> CreateComponentDataArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkComponentType type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x252C1E0", Offset = "0x252B3E0", VA = "0x18252C1E0")]
		private static NativeArray<T> CreateComponentDataArrayRun<T>(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkComponentType<T> type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63E12E0", Offset = "0x63E04E0", VA = "0x1863E12E0")]
		private static NativeArray<Entity> CreateEntityArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ArchetypeChunkEntityType type, EntityQuery entityQuery, ref Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63E16D0", Offset = "0x63E08D0", VA = "0x1863E16D0")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x252C340", Offset = "0x252B540", VA = "0x18252C340")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D45240", Offset = "0x2D44440", VA = "0x182D45240")]
		public static Memory<T> Rent<T>(int count)
		{
			return default(Memory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2D454C0", Offset = "0x2D446C0", VA = "0x182D454C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B50480", Offset = "0x2B4F680", VA = "0x182B50480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3129330", Offset = "0x3128530", VA = "0x183129330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xCCCFF0", Offset = "0xCCC1F0", VA = "0x180CCCFF0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xC2F960", Offset = "0xC2EB60", VA = "0x180C2F960")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CD6620", Offset = "0x1CD5820", VA = "0x181CD6620")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B50120", Offset = "0x2B4F320", VA = "0x182B50120")]
		public NativeArray<T> Complete()
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3128AE0", Offset = "0x3127CE0", VA = "0x183128AE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3129260", Offset = "0x3128460", VA = "0x183129260")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x63E1F30", Offset = "0x63E1130", VA = "0x1863E1F30")]
		public static JobHandle CombineHandles(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C8B0", Offset = "0x2D5BAB0", VA = "0x182D5C8B0")]
		public static JobHandle CombineHandles<T>(this JobHandle a, NativeArrayAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C8B0", Offset = "0x2D5BAB0", VA = "0x182D5C8B0")]
		public static JobHandle CombineHandles<T>(this JobHandle a, NativeListAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C860", Offset = "0x2D5BA60", VA = "0x182D5C860")]
		public static JobHandle CombineHandles<T>(this NativeListAsync<T> a, NativeListAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x63E1F70", Offset = "0x63E1170", VA = "0x1863E1F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B50480", Offset = "0x2B4F680", VA = "0x182B50480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCCCFF0", Offset = "0xCCC1F0", VA = "0x180CCCFF0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1CD6620", Offset = "0x1CD5820", VA = "0x181CD6620")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B4FFF0", Offset = "0x2B4F1F0", VA = "0x182B4FFF0")]
		public NativeArrayAsync<T> AsDeferredArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B50120", Offset = "0x2B4F320", VA = "0x182B50120")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B503D0", Offset = "0x2B4F5D0", VA = "0x182B503D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B50230", Offset = "0x2B4F430", VA = "0x182B50230")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C01820", Offset = "0x4C00A20", VA = "0x184C01820")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4C016C0", Offset = "0x4C008C0", VA = "0x184C016C0")]
		public static Span<T> AsSpan<T>(this NativeList<T> list) where T : struct
		{
			return default(Span<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class StructUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2471A70", Offset = "0x2470C70", VA = "0x182471A70")]
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
			[Cpp2IlInjected.Address(RVA = "0x63E2070", Offset = "0x63E1270", VA = "0x1863E2070")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x63E2020", Offset = "0x63E1220", VA = "0x1863E2020", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x63E1BB0", Offset = "0x63E0DB0", VA = "0x1863E1BB0")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x63E1DE0", Offset = "0x63E0FE0", VA = "0x1863E1DE0")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x63E1AF0", Offset = "0x63E0CF0", VA = "0x1863E1AF0")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x63E19C0", Offset = "0x63E0BC0", VA = "0x1863E19C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x63E06C0", Offset = "0x63DF8C0", VA = "0x1863E06C0")]
		public static bool TryGetChildEntitySubArrayRO(this in EntityManager entityManager, Entity parentEntity, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x63E08F0", Offset = "0x63DFAF0", VA = "0x1863E08F0")]
		public static bool TryGetChildEntitySubArray(this in BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x63E07C0", Offset = "0x63DF9C0", VA = "0x1863E07C0")]
		public static bool TryGetChildEntitySubArray(this in DynamicBuffer<LinkedEntityGroup> buffer, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x63E05D0", Offset = "0x63DF7D0", VA = "0x1863E05D0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x63E04F0", Offset = "0x63DF6F0", VA = "0x1863E04F0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGIIOKJKKGL()
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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

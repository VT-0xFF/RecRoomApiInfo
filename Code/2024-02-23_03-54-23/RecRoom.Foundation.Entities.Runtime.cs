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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
			[Cpp2IlInjected.Address(RVA = "0x3FBD550", Offset = "0x3FBBF50", VA = "0x183FBD550")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3FBD5F0", Offset = "0x3FBBFF0", VA = "0x183FBD5F0")]
		public PBBGKOAFBFF(NativeArray<Entity> CLKJOCHJHDA, EntityManager KFOGOLNDMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3FBD5E0", Offset = "0x3FBBFE0", VA = "0x183FBD5E0")]
		public bool NLINJCHNNNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x35A4A10", Offset = "0x35A3410", VA = "0x1835A4A10")]
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
	[Cpp2IlInjected.Address(RVA = "0x27F3F10", Offset = "0x27F2910", VA = "0x1827F3F10")]
	public static int CHLAAIDMHAK<T>(this NativeArray<T> FDFHGIHHGHO) where T : struct
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27F3F20", Offset = "0x27F2920", VA = "0x1827F3F20")]
	public static int CHLAAIDMHAK<T>(this NativeList<T> FDFHGIHHGHO) where T : struct
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FC91F0", Offset = "0x5FC7BF0", VA = "0x185FC91F0")]
	public static void FPMLFJFDMCI(this NativeBitArray FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27F4310", Offset = "0x27F2D10", VA = "0x1827F4310")]
	public static void FPMLFJFDMCI<T>(this NativeArray<T> FDFHGIHHGHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27F42D0", Offset = "0x27F2CD0", VA = "0x1827F42D0")]
	public static void FPMLFJFDMCI<T>(this NativeList<T> FDFHGIHHGHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27F44D0", Offset = "0x27F2ED0", VA = "0x1827F44D0")]
	public static void FPMLFJFDMCI<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> FDFHGIHHGHO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x27F4510", Offset = "0x27F2F10", VA = "0x1827F4510")]
	public static void FPMLFJFDMCI<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> FDFHGIHHGHO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27F4550", Offset = "0x27F2F50", VA = "0x1827F4550")]
	public static JobHandle FPMLFJFDMCI<T>(this NativeArrayAsync<T> FDFHGIHHGHO, JobHandle OEAKLAEMPBC) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27F45F0", Offset = "0x27F2FF0", VA = "0x1827F45F0")]
	public static JobHandle FPMLFJFDMCI<T>(this NativeListAsync<T> FDFHGIHHGHO, JobHandle OEAKLAEMPBC) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27F4280", Offset = "0x27F2C80", VA = "0x1827F4280")]
	public static JobHandle FPMLFJFDMCI<T>(this NativeArray<T> FDFHGIHHGHO, JobHandle OEAKLAEMPBC) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27F4350", Offset = "0x27F2D50", VA = "0x1827F4350")]
	public static JobHandle FPMLFJFDMCI<T>(this NativeList<T> FDFHGIHHGHO, JobHandle OEAKLAEMPBC) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27F4780", Offset = "0x27F3180", VA = "0x1827F4780")]
	public static JobHandle FPMLFJFDMCI<T>(this NativeParallelHashSet<T> FDFHGIHHGHO, JobHandle OEAKLAEMPBC) where T : struct, IEquatable<T>
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27F4A80", Offset = "0x27F3480", VA = "0x1827F4A80")]
	public static bool INMLDJBGPFD<T>(this NativeArray<T> FDFHGIHHGHO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27F3F70", Offset = "0x27F2970", VA = "0x1827F3F70")]
	public static string DDELCBOHMPP<T>(this NativeArray<T> NIKMHLBDDHG, string IIKICHELIPL = ", ") where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27F4BD0", Offset = "0x27F35D0", VA = "0x1827F4BD0")]
	public static PBBGKOAFBFF<T> NNFNBFOIICD<T>(this NativeList<Entity> PNDHBMNLPBD, EntityManager KFOGOLNDMKF) where T : class
	{
		return default(PBBGKOAFBFF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x27F4B90", Offset = "0x27F3590", VA = "0x1827F4B90")]
	public static PBBGKOAFBFF<T> NNFNBFOIICD<T>(this NativeArray<Entity> PNDHBMNLPBD, EntityManager KFOGOLNDMKF) where T : class
	{
		return default(PBBGKOAFBFF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27F4AA0", Offset = "0x27F34A0", VA = "0x1827F4AA0")]
	public static NativeArray<TKey> JIKLEKKBIMM<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> JAMEDNMIIII, Allocator FNHHOCKOINK, [Out] int JBAPJIPBGIK) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default(NativeArray<TKey>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27F41B0", Offset = "0x27F2BB0", VA = "0x1827F41B0")]
	public static void FLOHBAGDPJC<T1, T2>(this NativeParallelHashMap<T1, T2> NNIDGPDMKMK, NativeArray<T1> KFMNDJAIHBK, NativeArray<T2> FNPMCCBNOOB) where T1 : struct, IEquatable<T1> where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x27F4B20", Offset = "0x27F3520", VA = "0x1827F4B20")]
	public static void LIIEGHCBNII<TKey, TValue>(this KeyValue<TKey, TValue> LGHEBJJLAGD, [Out] TKey KCGLPAPOILB, [Out] TValue FDFHGIHHGHO) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9120", Offset = "0x5FC7B20", VA = "0x185FC9120")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FC0960", Offset = "0x5FBF360", VA = "0x185FC0960")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FC2470", Offset = "0x5FC0E70", VA = "0x185FC2470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IEnumerable<ComponentType> ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5FC22E0", Offset = "0x5FC0CE0", VA = "0x185FC22E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1080", Offset = "0x5FBFA80", VA = "0x185FC1080")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1110", Offset = "0x5FBFB10", VA = "0x185FC1110")]
		public Type GetType(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1010", Offset = "0x5FBFA10", VA = "0x185FC1010")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1A00", Offset = "0x5FC0400", VA = "0x185FC1A00")]
		public ComponentTypeList(ComponentTypeList a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1B10", Offset = "0x5FC0510", VA = "0x185FC1B10")]
		public ComponentTypeList(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5FC18D0", Offset = "0x5FC02D0", VA = "0x185FC18D0")]
		public ComponentTypeList(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2120", Offset = "0x5FC0B20", VA = "0x185FC2120")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1C30", Offset = "0x5FC0630", VA = "0x185FC1C30")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FC21F0", Offset = "0x5FC0BF0", VA = "0x185FC21F0")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1D10", Offset = "0x5FC0710", VA = "0x185FC1D10")]
		public ComponentTypeList(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1510", Offset = "0x5FBFF10", VA = "0x185FC1510")]
		public ComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FC09F0", Offset = "0x5FBF3F0", VA = "0x185FC09F0")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1180", Offset = "0x5FBFB80", VA = "0x185FC1180")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0CA0", Offset = "0x5FBF6A0", VA = "0x185FC0CA0")]
		public static ComponentTypeList Add([In] ComponentTypeList a, [In] ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1210", Offset = "0x5FBFC10", VA = "0x185FC1210")]
		public static ComponentTypeList Subtract([In] ComponentTypeList a, [In] ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC24D0", Offset = "0x5FC0ED0", VA = "0x185FC24D0")]
		public static ComponentTypeList operator +(ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2560", Offset = "0x5FC0F60", VA = "0x185FC2560")]
		public static ComponentTypeList operator -(ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC13B0", Offset = "0x5FBFDB0", VA = "0x185FC13B0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FC3220", Offset = "0x5FC1C20", VA = "0x185FC3220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5FC3260", Offset = "0x5FC1C60", VA = "0x185FC3260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2790", Offset = "0x5FC1190", VA = "0x185FC2790")]
		private void ComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2960", Offset = "0x5FC1360", VA = "0x185FC2960")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC28E0", Offset = "0x5FC12E0", VA = "0x185FC28E0")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2D00", Offset = "0x5FC1700", VA = "0x185FC2D00")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2B60", Offset = "0x5FC1560", VA = "0x185FC2B60")]
		public ComponentTypes32(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2FA0", Offset = "0x5FC19A0", VA = "0x185FC2FA0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3140", Offset = "0x5FC1B40", VA = "0x185FC3140")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2C10", Offset = "0x5FC1610", VA = "0x185FC2C10")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3070", Offset = "0x5FC1A70", VA = "0x185FC3070")]
		public ComponentTypes32(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2D80", Offset = "0x5FC1780", VA = "0x185FC2D80")]
		public ComponentTypes32(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2740", Offset = "0x5FC1140", VA = "0x185FC2740")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5FC29B0", Offset = "0x5FC13B0", VA = "0x185FC29B0")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2A00", Offset = "0x5FC1400", VA = "0x185FC2A00", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FC0640", Offset = "0x5FBF040", VA = "0x185FC0640")]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5FC0750", Offset = "0x5FBF150", VA = "0x185FC0750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0580", Offset = "0x5FBEF80", VA = "0x185FC0580")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC04E0", Offset = "0x5FBEEE0", VA = "0x185FC04E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1774FC0", Offset = "0x17739C0", VA = "0x181774FC0")]
		internal unsafe EntityExistenceLookupByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5D80", Offset = "0x5FC4780", VA = "0x185FC5D80")]
		public bool Exists(Entity entity)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5FC78A0", Offset = "0x5FC62A0", VA = "0x185FC78A0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, SystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5FC77B0", Offset = "0x5FC61B0", VA = "0x185FC77B0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7980", Offset = "0x5FC6380", VA = "0x185FC7980")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7BA0", Offset = "0x5FC65A0", VA = "0x185FC7BA0")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7A70", Offset = "0x5FC6470", VA = "0x185FC7A70")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7B60", Offset = "0x5FC6560", VA = "0x185FC7B60")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7C90", Offset = "0x5FC6690", VA = "0x185FC7C90")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7B80", Offset = "0x5FC6580", VA = "0x185FC7B80")]
		public static EntityQueryDesc WithFilterWriteGroup(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5FC74D0", Offset = "0x5FC5ED0", VA = "0x185FC74D0")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x259DB50", Offset = "0x259C550", VA = "0x18259DB50")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x259DAC0", Offset = "0x259C4C0", VA = "0x18259DAC0")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x259DAC0", Offset = "0x259C4C0", VA = "0x18259DAC0")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x259DAC0", Offset = "0x259C4C0", VA = "0x18259DAC0")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x259DAC0", Offset = "0x259C4C0", VA = "0x18259DAC0")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x259DAF0", Offset = "0x259C4F0", VA = "0x18259DAF0")]
		public static EntityQueryDesc WithAny<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x259DAF0", Offset = "0x259C4F0", VA = "0x18259DAF0")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x259DB20", Offset = "0x259C520", VA = "0x18259DB20")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x259DB20", Offset = "0x259C520", VA = "0x18259DB20")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x259DAC0", Offset = "0x259C4C0", VA = "0x18259DAC0")]
		public static EntityQueryDesc WithAllRO<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x259DAC0", Offset = "0x259C4C0", VA = "0x18259DAC0")]
		public static EntityQueryDesc WithAllRO<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x259DAC0", Offset = "0x259C4C0", VA = "0x18259DAC0")]
		public static EntityQueryDesc WithAllRO<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2599460", Offset = "0x2597E60", VA = "0x182599460")]
		private static ComponentType[] ExpandRW<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x25993C0", Offset = "0x2597DC0", VA = "0x1825993C0")]
		private static ComponentType[] ExpandRW<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x259A720", Offset = "0x2599120", VA = "0x18259A720")]
		private static ComponentType[] ExpandRW<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x259AF60", Offset = "0x2599960", VA = "0x18259AF60")]
		private static ComponentType[] ExpandRW<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2596440", Offset = "0x2594E40", VA = "0x182596440")]
		private static ComponentType[] ExpandRO<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x25969C0", Offset = "0x25953C0", VA = "0x1825969C0")]
		private static ComponentType[] ExpandRO<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2596E00", Offset = "0x2595800", VA = "0x182596E00")]
		private static ComponentType[] ExpandRO<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC76E0", Offset = "0x5FC60E0", VA = "0x185FC76E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2552730", Offset = "0x2551130", VA = "0x182552730")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x25529C0", Offset = "0x25513C0", VA = "0x1825529C0")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2552910", Offset = "0x2551310", VA = "0x182552910")]
		public static int IndexOf<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2552A20", Offset = "0x2551420", VA = "0x182552A20")]
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
				[Cpp2IlInjected.Address(RVA = "0x5FC08E0", Offset = "0x5FBF2E0", VA = "0x185FC08E0")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x5FC08C0", Offset = "0x5FBF2C0", VA = "0x185FC08C0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public ComponentType this[int i]
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x5FC0920", Offset = "0x5FBF320", VA = "0x185FC0920")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5FC08A0", Offset = "0x5FBF2A0", VA = "0x185FC08A0")]
			internal ComponentTypeEnumerator(EntityArchetype arch, bool includeEntity = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3B3CF30", Offset = "0x3B3B930", VA = "0x183B3CF30")]
			public ComponentTypeEnumerator GetEnumerator()
			{
				return default(ComponentTypeEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5FC0870", Offset = "0x5FBF270", VA = "0x185FC0870")]
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
				[Cpp2IlInjected.Address(RVA = "0x5FBFFA0", Offset = "0x5FBE9A0", VA = "0x185FBFFA0")]
				get
				{
					return default((ComponentType, bool));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5FBFF50", Offset = "0x5FBE950", VA = "0x185FBFF50")]
			internal unsafe AddRemoveEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x32FA050", Offset = "0x32F8A50", VA = "0x1832FA050")]
			public AddRemoveEnumerator GetEnumerator()
			{
				return default(AddRemoveEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5FBFE50", Offset = "0x5FBE850", VA = "0x185FBFE50")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5D50", Offset = "0x5FC4750", VA = "0x185FC5D50")]
		public static EntityArchetype GetInstantiateArchetype(this EntityArchetype archetype)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5C10", Offset = "0x5FC4610", VA = "0x185FC5C10")]
		public static ComponentTypeEnumerator EnumerateComponentTypes(this EntityArchetype archetype, bool includeEntity = false)
		{
			return default(ComponentTypeEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5C30", Offset = "0x5FC4630", VA = "0x185FC5C30")]
		public static Span<int> GetAllTypeIndices(this EntityArchetype archetype)
		{
			return default(Span<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5D30", Offset = "0x5FC4730", VA = "0x185FC5D30")]
		public static int GetEntityCount(this EntityArchetype archetype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5CD0", Offset = "0x5FC46D0", VA = "0x185FC5CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FC5E10", Offset = "0x5FC4810", VA = "0x185FC5E10")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(this EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5F50", Offset = "0x5FC4950", VA = "0x185FC5F50")]
		public static void HackSetAllChangeVersionsToGlobalSystemVersion(this EntityManager em, Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5E60", Offset = "0x5FC4860", VA = "0x185FC5E60")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FC9600", Offset = "0x5FC8000", VA = "0x185FC9600", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41E05F0", Offset = "0x41DEFF0", VA = "0x1841E05F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x25923B0", Offset = "0x2590DB0", VA = "0x1825923B0")]
		public static bool TrySetComponentData<T>(this EntityManager entityManager, Entity entity, T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2590270", Offset = "0x258EC70", VA = "0x182590270")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x25900D0", Offset = "0x258EAD0", VA = "0x1825900D0")]
		public static bool TryGetComponentDataField<TComponent, TValue>(this EntityManager entityManager, Entity entity, Func<TComponent, TValue> func, [Out] TValue value) where TComponent : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6290", Offset = "0x5FC4C90", VA = "0x185FC6290")]
		public static void SetComponentData(this EntityManager entityManager, Entity entity, int typeIndex, NativeArray<byte> src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5FC64A0", Offset = "0x5FC4EA0", VA = "0x185FC64A0")]
		public static void SetComponentData(this EntityManager entityManager, ComponentType type, NativeArray<Entity> entities, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x258E910", Offset = "0x258D310", VA = "0x18258E910")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x258F9F0", Offset = "0x258E3F0", VA = "0x18258F9F0")]
		public static void SetTag<T>(this EntityManager entityManager, Entity entity, bool isTagSet) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x258EB00", Offset = "0x258D500", VA = "0x18258EB00")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC60E0", Offset = "0x5FC4AE0", VA = "0x185FC60E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FC66B0", Offset = "0x5FC50B0", VA = "0x185FC66B0")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class EntityManagerEntityExistenceLookupByEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6C80", Offset = "0x5FC5680", VA = "0x185FC6C80")]
		public static EntityExistenceLookupByEntity GetEntityExistenceLookupByEntity(this EntityManager entityManager)
		{
			return default(EntityExistenceLookupByEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class EntityManagerComponentObjectExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2592720", Offset = "0x2591120", VA = "0x182592720")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x25927B0", Offset = "0x25911B0", VA = "0x1825927B0")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, [Out] T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2592690", Offset = "0x2591090", VA = "0x182592690")]
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
		[Cpp2IlInjected.Address(RVA = "0x2592880", Offset = "0x2591280", VA = "0x182592880")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2592A00", Offset = "0x2591400", VA = "0x182592A00")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6A00", Offset = "0x5FC5400", VA = "0x185FC6A00")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6B40", Offset = "0x5FC5540", VA = "0x185FC6B40")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6760", Offset = "0x5FC5160", VA = "0x185FC6760")]
		public static JobHandle AddReadDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC68B0", Offset = "0x5FC52B0", VA = "0x185FC68B0")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class EntityManagerDynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x25934E0", Offset = "0x2591EE0", VA = "0x1825934E0")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x25930E0", Offset = "0x2591AE0", VA = "0x1825930E0")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2592CD0", Offset = "0x25916D0", VA = "0x182592CD0")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2592E70", Offset = "0x2591870", VA = "0x182592E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2593700", Offset = "0x2592100", VA = "0x182593700")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class EntityQueryArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7390", Offset = "0x5FC5D90", VA = "0x185FC7390")]
		public static int CalculateArchetypeCount(this EntityQuery query)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7280", Offset = "0x5FC5C80", VA = "0x185FC7280")]
		private static int CalculateArchetypeCount(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Unity.Entities.EntityQueryFilter filter)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class EntityQueryChangeVersionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x25963D0", Offset = "0x2594DD0", VA = "0x1825963D0")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2596380", Offset = "0x2594D80", VA = "0x182596380")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7CB0", Offset = "0x5FC66B0", VA = "0x185FC7CB0")]
		public static Entity FirstMatchingEntity(this EntityQuery query)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7DE0", Offset = "0x5FC67E0", VA = "0x185FC7DE0")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7D90", Offset = "0x5FC6790", VA = "0x185FC7D90")]
		public static bool IsEmpty(this EntityQuery entityQuery, [Out] int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7E20", Offset = "0x5FC6820", VA = "0x185FC7E20")]
		public static bool IsEmpty(this EntityQueryInJob entityQuery, [Out] int count)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class EntityQueryToComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x25AD430", Offset = "0x25ABE30", VA = "0x1825AD430")]
		public static NativeArray<T> ToSharedComponentDataArray<T>(this EntityQuery entityQuery, Allocator allocator = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x25AD1B0", Offset = "0x25ABBB0", VA = "0x1825AD1B0")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5FC87B0", Offset = "0x5FC71B0", VA = "0x185FC87B0")]
		[BurstCompatible(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", CompileTarget = BurstCompatibleAttribute.BurstCompatibleCompileTarget.Editor)]
		public static NativeArray<byte> ToComponentDataArray(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x25ACE30", Offset = "0x25AB830", VA = "0x1825ACE30")]
		public static NativeArrayAsync<T> ToComponentDataArrayAsync<T>(this EntityQuery query, Allocator allocator = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8670", Offset = "0x5FC7070", VA = "0x185FC8670")]
		private static NativeArray<byte> CreateComponentDataArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ComponentTypeHandle type, EntityQuery entityQuery, Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class EntityQueryToEntityArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8B80", Offset = "0x5FC7580", VA = "0x185FC8B80")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8A70", Offset = "0x5FC7470", VA = "0x185FC8A70")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FC0190", Offset = "0x5FBEB90", VA = "0x185FC0190")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5FC00A0", Offset = "0x5FBEAA0", VA = "0x185FC00A0")]
		public AsyncDispose(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0190", Offset = "0x5FBEB90", VA = "0x185FC0190")]
		public static implicit operator JobHandle(AsyncDispose set)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2449DD0", Offset = "0x24487D0", VA = "0x182449DD0")]
		public void Add<T>(T disposable) where T : struct, INativeDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2449D30", Offset = "0x2448730", VA = "0x182449D30")]
		public void Add<T>(NativeArrayAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2449D30", Offset = "0x2448730", VA = "0x182449D30")]
		public void Add<T>(NativeArray<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2449D30", Offset = "0x2448730", VA = "0x182449D30")]
		public void Add<T>(NativeListAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2449D30", Offset = "0x2448730", VA = "0x182449D30")]
		public void Add<T>(NativeList<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0000", Offset = "0x5FBEA00", VA = "0x185FC0000", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0040", Offset = "0x5FBEA40", VA = "0x185FC0040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5FC8E30", Offset = "0x5FC7830", VA = "0x185FC8E30")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8D80", Offset = "0x5FC7780", VA = "0x185FC8D80")]
		public JobGroup(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8BB0", Offset = "0x5FC75B0", VA = "0x185FC8BB0")]
		public void Add(JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0000", Offset = "0x5FBEA00", VA = "0x185FC0000", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8D20", Offset = "0x5FC7720", VA = "0x185FC8D20", Slot = "4")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8C80", Offset = "0x5FC7680", VA = "0x185FC8C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FC04B0", Offset = "0x5FBEEB0", VA = "0x185FC04B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xB644F0", Offset = "0xB62EF0", VA = "0x180B644F0")]
		public ChunkFilterAnyOf2ComponentsChanged(DynamicComponentTypeHandle handle0, DynamicComponentTypeHandle handle1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5FC01C0", Offset = "0x5FBEBC0", VA = "0x185FC01C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x44A72B0", Offset = "0x44A5CB0", VA = "0x1844A72B0")]
		public ChunkFilterAnyOf3ComponentsChanged(DynamicComponentTypeHandle handle0, DynamicComponentTypeHandle handle1, DynamicComponentTypeHandle handle2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0240", Offset = "0x5FBEC40", VA = "0x185FC0240", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FC02E0", Offset = "0x5FBECE0", VA = "0x185FC02E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FC0480", Offset = "0x5FBEE80", VA = "0x185FC0480")]
		public ChunkFilterAnyOf5ComponentsChanged(DynamicComponentTypeHandle handle0, DynamicComponentTypeHandle handle1, DynamicComponentTypeHandle handle2, DynamicComponentTypeHandle handle3, DynamicComponentTypeHandle handle4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5FC03A0", Offset = "0x5FBEDA0", VA = "0x185FC03A0", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class ChunkChangeFilterExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x25158B0", Offset = "0x25142B0", VA = "0x1825158B0")]
		public static ChunkFilterAnyOf2ComponentsChanged ChunkFilterAnyChanged<T1, T2>(this EntityManager entityManager)
		{
			return default(ChunkFilterAnyOf2ComponentsChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2515EA0", Offset = "0x25148A0", VA = "0x182515EA0")]
		public static ChunkFilterAnyOf3ComponentsChanged ChunkFilterAnyChanged<T1, T2, T3>(this EntityManager entityManager)
		{
			return default(ChunkFilterAnyOf3ComponentsChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x25159A0", Offset = "0x25143A0", VA = "0x1825159A0")]
		public static ChunkFilterAnyOf5ComponentsChanged ChunkFilterAnyChanged<T1, T2, T3, T4, T5>(this EntityManager entityManager)
		{
			return default(ChunkFilterAnyOf5ComponentsChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2515760", Offset = "0x2514160", VA = "0x182515760")]
		public static int CalculateEntityCount<T>(this EntityQuery query, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x25160D0", Offset = "0x2514AD0", VA = "0x1825160D0")]
		public static bool IsEmpty<T>(this EntityQuery query, T chunkChangeFilter, [Out] int count) where T : struct, IChunkChangeFilter
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2516130", Offset = "0x2514B30", VA = "0x182516130")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FC9220", Offset = "0x5FC7C20", VA = "0x185FC9220", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FC9320", Offset = "0x5FC7D20", VA = "0x185FC9320", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5FC46F0", Offset = "0x5FC30F0", VA = "0x185FC46F0")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5960", Offset = "0x5FC4360", VA = "0x185FC5960")]
		private static NativeArray<ArchetypeChunk> GetChunksFromEntities(NativeArray<Entity> entities, EntityManager srcEntityManager)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5080", Offset = "0x5FC3A80", VA = "0x185FC5080")]
		private unsafe static NativeArray<ArchetypeChunk> CopyEntitiesInternal(NativeArray<ArchetypeChunk> srcChunks, Unity.Entities.EntityDataAccess* srcAccess, CopyFlags copyFlags)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5A70", Offset = "0x5FC4470", VA = "0x185FC5A70")]
		internal unsafe static void RemapEntityRefs(NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping, Unity.Entities.EntityDataAccess* dataAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA2E0", Offset = "0x1AA8CE0", VA = "0x181AAA2E0")]
		private static bool HasFlag(CopyFlags copyFlags, CopyFlags testFlag)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5FC56D0", Offset = "0x5FC40D0", VA = "0x185FC56D0")]
		private unsafe static void CreateChunks(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5570", Offset = "0x5FC3F70", VA = "0x185FC5570")]
		private unsafe static void CopyNames(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4070", Offset = "0x5FC2A70", VA = "0x185FC4070")]
		private static void CloneNativeComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4410", Offset = "0x5FC2E10", VA = "0x185FC4410")]
		public unsafe static void CloneNativeComponents([In] Unity.Entities.EntityBatchInChunk srcBatch, Unity.Entities.Chunk* dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5FC35A0", Offset = "0x5FC1FA0", VA = "0x185FC35A0")]
		private static void ClearBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5FC33A0", Offset = "0x5FC1DA0", VA = "0x185FC33A0")]
		private static void ClearBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3C20", Offset = "0x5FC2620", VA = "0x185FC3C20")]
		private static void CloneBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5FC39B0", Offset = "0x5FC23B0", VA = "0x185FC39B0")]
		private static void CloneBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3850", Offset = "0x5FC2250", VA = "0x185FC3850")]
		private static void ClearManagedComponents(NativeArray<ArchetypeChunk> chunks, uint globalSystemVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3F60", Offset = "0x5FC2960", VA = "0x185FC3F60")]
		private static void CloneManagedComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5820", Offset = "0x5FC4220", VA = "0x185FC5820")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FC8050", Offset = "0x5FC6A50", VA = "0x185FC8050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x814590", Offset = "0x812F90", VA = "0x180814590")]
		public static implicit operator EntityQueryInJob(EntityQuery query)
		{
			return default(EntityQueryInJob);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3BA2800", Offset = "0x3BA1200", VA = "0x183BA2800")]
		public EntityQueryInJob(EntityQuery query)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7ED0", Offset = "0x5FC68D0", VA = "0x185FC7ED0")]
		public int CalculateEntityCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x25A6190", Offset = "0x25A4B90", VA = "0x1825A6190")]
		public int CalculateEntityCount<T>(T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7F20", Offset = "0x5FC6920", VA = "0x185FC7F20")]
		public ArchetypeChunkIterator GetArchetypeChunkIterator()
		{
			return default(ArchetypeChunkIterator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7FD0", Offset = "0x5FC69D0", VA = "0x185FC7FD0")]
		[BurstCompatible]
		public NativeArray<Entity> ToEntityArray(EntityTypeHandle entityType, Allocator allocator = Allocator.Temp)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x25A9620", Offset = "0x25A8020", VA = "0x1825A9620")]
		[BurstCompatible]
		public NativeArray<Entity> ToEntityArray<T>(EntityTypeHandle entityType, T chunkChangeFilter, Allocator allocator = Allocator.Temp) where T : struct, IChunkChangeFilter
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x25A69D0", Offset = "0x25A53D0", VA = "0x1825A69D0")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle<T> componentType, Allocator allocator = Allocator.Temp) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x25A66D0", Offset = "0x25A50D0", VA = "0x1825A66D0")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T, T2>(ComponentTypeHandle<T> componentType, T2 chunkChangeFilter, Allocator allocator = Allocator.Temp) where T : struct, IComponentData where T2 : struct, IChunkChangeFilter
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x814590", Offset = "0x812F90", VA = "0x180814590")]
		internal unsafe Unity.Entities.EntityQueryImpl* _GetImpl()
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityQueryImpl*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x25AA590", Offset = "0x25A8F90", VA = "0x1825AA590")]
		private unsafe static void _GatherEntities<T>(Entity* entities, EntityTypeHandle entityTypeHandle, [In] Unity.Entities.UnsafeCachedChunkList cache, uint requiredChangeVersion, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x25AC2F0", Offset = "0x25AACF0", VA = "0x1825AC2F0")]
		private unsafe static void _GatherEntitiesWithFilter<T>(Entity* entities, Unity.Entities.EntityQueryFilter filter, Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, EntityTypeHandle entityTypeHandle, [In] Unity.Entities.UnsafeCachedChunkList cache, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x25AA190", Offset = "0x25A8B90", VA = "0x1825AA190")]
		private unsafe static void _GatherComponentData<T>(byte* componentData, int typeIndex, [In] Unity.Entities.UnsafeCachedChunkList cache, uint requiredChangeVersion, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x25A9C70", Offset = "0x25A8670", VA = "0x1825A9C70")]
		private unsafe static void _GatherComponentDataWithFilter<T>(byte* componentData, int typeIndex, [In] Unity.Entities.UnsafeCachedChunkList cache, [In] Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, Unity.Entities.EntityQueryFilter filter, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class EntityQueryInJobExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x814590", Offset = "0x812F90", VA = "0x180814590")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E4B410", Offset = "0x3E49E10", VA = "0x183E4B410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1D60D30", Offset = "0x1D5F730", VA = "0x181D60D30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xB644E0", Offset = "0xB62EE0", VA = "0x180B644E0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xB644F0", Offset = "0xB62EF0", VA = "0x180B644F0")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B0F0", Offset = "0x3E49AF0", VA = "0x183E4B0F0")]
		public NativeArray<T> Complete()
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B380", Offset = "0x3E49D80", VA = "0x183E4B380", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B210", Offset = "0x3E49C10", VA = "0x183E4B210")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x25C5F40", Offset = "0x25C4940", VA = "0x1825C5F40")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x27C81E0", Offset = "0x27C6BE0", VA = "0x1827C81E0")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8F00", Offset = "0x5FC7900", VA = "0x185FC8F00")]
		public static JobHandle CombineHandles(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8F40", Offset = "0x5FC7940", VA = "0x185FC8F40")]
		public static JobHandle Combine(this Span<JobHandle> handles)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class NativeArrayUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8FF0", Offset = "0x5FC79F0", VA = "0x185FC8FF0")]
		public unsafe static NativeArray<byte> AsArray(byte* ptr, int length, bool isReadOnly = false)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9070", Offset = "0x5FC7A70", VA = "0x185FC9070")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E4B410", Offset = "0x3E49E10", VA = "0x183E4B410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x3E8C920", Offset = "0x3E8B320", VA = "0x183E8C920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xB644E0", Offset = "0xB62EE0", VA = "0x180B644E0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xB644F0", Offset = "0xB62EF0", VA = "0x180B644F0")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C3E0", Offset = "0x3E8ADE0", VA = "0x183E8C3E0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B0F0", Offset = "0x3E49AF0", VA = "0x183E4B0F0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C660", Offset = "0x3E8B060", VA = "0x183E8C660", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C590", Offset = "0x3E8AF90", VA = "0x183E8C590")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EAD440", Offset = "0x3EABE40", VA = "0x183EAD440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xB644F0", Offset = "0xB62EF0", VA = "0x180B644F0")]
		public NativeMultiHashMapAsync(NativeParallelMultiHashMap<TKey, TValue> map, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B0F0", Offset = "0x3E49AF0", VA = "0x183E4B0F0")]
		public NativeParallelMultiHashMap<TKey, TValue> Complete()
		{
			return default(NativeParallelMultiHashMap<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3EAD3A0", Offset = "0x3EABDA0", VA = "0x183EAD3A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FC9590", Offset = "0x5FC7F90", VA = "0x185FC9590", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class SpanUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2927600", Offset = "0x2926000", VA = "0x182927600")]
		public static int MemCmp<T>(ReadOnlySpan<T> spanA, ReadOnlySpan<T> spanB, int length) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2927500", Offset = "0x2925F00", VA = "0x182927500")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x29272E0", Offset = "0x2925CE0", VA = "0x1829272E0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2927360", Offset = "0x2925D60", VA = "0x182927360")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FC92D0", Offset = "0x5FC7CD0", VA = "0x185FC92D0")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x5FC9280", Offset = "0x5FC7C80", VA = "0x185FC9280", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5FC82A0", Offset = "0x5FC6CA0", VA = "0x185FC82A0")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8500", Offset = "0x5FC6F00", VA = "0x185FC8500")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5FC81E0", Offset = "0x5FC6BE0", VA = "0x185FC81E0")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5FC80A0", Offset = "0x5FC6AA0", VA = "0x185FC80A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FC6F30", Offset = "0x5FC5930", VA = "0x185FC6F30")]
		public static bool TryGetChildEntitySubArrayRO([In] this EntityManager entityManager, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7060", Offset = "0x5FC5A60", VA = "0x185FC7060")]
		public static bool TryGetChildEntitySubArray([In] this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7150", Offset = "0x5FC5B50", VA = "0x185FC7150")]
		public static bool TryGetChildEntitySubArray([In] this DynamicBuffer<LinkedEntityGroup> buffer, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6DD0", Offset = "0x5FC57D0", VA = "0x185FC6DD0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6CD0", Offset = "0x5FC56D0", VA = "0x185FC6CD0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6F00", Offset = "0x5FC5900", VA = "0x185FC6F00")]
		public static NativeArray<Entity> GetChildEntitySubArray(this DynamicBuffer<LinkedEntityGroup> buffer)
		{
			return default(NativeArray<Entity>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3827159303
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9870", Offset = "0x5FC8270", VA = "0x185FC9870")]
	public static void DHKPLIPCEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9900", Offset = "0x5FC8300", VA = "0x185FC9900")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GKEECMEFPEG
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct NDJLPKKMKLO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private EntityManager LMKGBBMBMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeArray<Entity> AFOPCKBACJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int HMFNCGHECPG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x4003150", Offset = "0x4002350", VA = "0x184003150")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x40031E0", Offset = "0x40023E0", VA = "0x1840031E0")]
		public NDJLPKKMKLO(NativeArray<Entity> AFOPCKBACJG, EntityManager LMKGBBMBMBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4003140", Offset = "0x4002340", VA = "0x184003140")]
		public bool EKIMDKEIFIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3804ED0", Offset = "0x38040D0", VA = "0x183804ED0")]
		public NDJLPKKMKLO<T> ODDJKKOCOEI()
		{
			return default(NDJLPKKMKLO<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct FCNBBBNPGPH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityManager LMKGBBMBMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeArray<Entity> AFOPCKBACJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int HMFNCGHECPG;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28E9C50", Offset = "0x28E8E50", VA = "0x1828E9C50")]
	public static int CCBMLBPHHMH<T>(this NativeArray<T> NICEPFIEJED) where T : struct
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28E9C00", Offset = "0x28E8E00", VA = "0x1828E9C00")]
	public static int CCBMLBPHHMH<T>(this NativeList<T> NICEPFIEJED) where T : struct
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61EF750", Offset = "0x61EE950", VA = "0x1861EF750")]
	public static void FJDMIDPGHGO(this NativeBitArray NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28E9CA0", Offset = "0x28E8EA0", VA = "0x1828E9CA0")]
	public static void FJDMIDPGHGO<T>(this NativeArray<T> NICEPFIEJED) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28E9C60", Offset = "0x28E8E60", VA = "0x1828E9C60")]
	public static void FJDMIDPGHGO<T>(this NativeList<T> NICEPFIEJED) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28EA2A0", Offset = "0x28E94A0", VA = "0x1828EA2A0")]
	public static void FJDMIDPGHGO<T>(this NativeParallelHashSet<T> NICEPFIEJED) where T : struct, IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28E9DD0", Offset = "0x28E8FD0", VA = "0x1828E9DD0")]
	public static void FJDMIDPGHGO<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> NICEPFIEJED) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28E9D90", Offset = "0x28E8F90", VA = "0x1828E9D90")]
	public static void FJDMIDPGHGO<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> NICEPFIEJED) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28EA010", Offset = "0x28E9210", VA = "0x1828EA010")]
	public static JobHandle FJDMIDPGHGO<T>(this NativeArrayAsync<T> NICEPFIEJED, JobHandle GBHDJGFBJBP) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x28E9F70", Offset = "0x28E9170", VA = "0x1828E9F70")]
	public static JobHandle FJDMIDPGHGO<T>(this NativeListAsync<T> NICEPFIEJED, JobHandle GBHDJGFBJBP) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28E9D40", Offset = "0x28E8F40", VA = "0x1828E9D40")]
	public static JobHandle FJDMIDPGHGO<T>(this NativeArray<T> NICEPFIEJED, JobHandle GBHDJGFBJBP) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x28E9CC0", Offset = "0x28E8EC0", VA = "0x1828E9CC0")]
	public static JobHandle FJDMIDPGHGO<T>(this NativeList<T> NICEPFIEJED, JobHandle GBHDJGFBJBP) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x28EA6C0", Offset = "0x28E98C0", VA = "0x1828EA6C0")]
	public static bool PPFMDOGEELH<T>(this NativeArray<T> NICEPFIEJED) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x28EA5E0", Offset = "0x28E97E0", VA = "0x1828EA5E0")]
	public static NDJLPKKMKLO<T> OPKMPMOELLD<T>(this NativeList<Entity> PCLFDNONBON, EntityManager LMKGBBMBMBN) where T : class
	{
		return default(NDJLPKKMKLO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x28EA680", Offset = "0x28E9880", VA = "0x1828EA680")]
	public static NDJLPKKMKLO<T> OPKMPMOELLD<T>(this NativeArray<Entity> PCLFDNONBON, EntityManager LMKGBBMBMBN) where T : class
	{
		return default(NDJLPKKMKLO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x28EA420", Offset = "0x28E9620", VA = "0x1828EA420")]
	public static NativeArray<TKey> MLAOMIBCAJO<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> OEENDMDOMOO, Allocator ILEAEEDKNCF, [Out] int OAIJHOBAKHO) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default(NativeArray<TKey>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x28EA510", Offset = "0x28E9710", VA = "0x1828EA510")]
	public static void OEOPOJPHCNL<T1, T2>(this NativeParallelHashMap<T1, T2> MMIHEHFLHMB, NativeArray<T1> CGNKMJKEIFI, NativeArray<T2> NGOGJHGFHFE) where T1 : struct, IEquatable<T1> where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x28EA4A0", Offset = "0x28E96A0", VA = "0x1828EA4A0")]
	public static void NAEOOGIIDLH<TKey, TValue>(this KeyValue<TKey, TValue> KPEEHKEJDAP, [Out] TKey GOBGGNLGONA, [Out] TValue NICEPFIEJED) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61EF780", Offset = "0x61EE980", VA = "0x1861EF780")]
	public static NativeArray<Entity> HJKMIENEDAL(this NativeParallelHashMap<Entity, Entity> KIKJIMAHICO, NativeArray<Entity> DDADEJNDDGL, Allocator ILEAEEDKNCF)
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

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x61E69E0", Offset = "0x61E5BE0", VA = "0x1861E69E0")]
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
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x61E8490", Offset = "0x61E7690", VA = "0x1861E8490")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IEnumerable<ComponentType> ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x61E8300", Offset = "0x61E7500", VA = "0x1861E8300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x61E70F0", Offset = "0x61E62F0", VA = "0x1861E70F0")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x61E7180", Offset = "0x61E6380", VA = "0x1861E7180")]
		public Type GetType(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x61E7080", Offset = "0x61E6280", VA = "0x1861E7080")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x61E7A40", Offset = "0x61E6C40", VA = "0x1861E7A40")]
		public ComponentTypeList(ComponentTypeList a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x61E7B50", Offset = "0x61E6D50", VA = "0x1861E7B50")]
		public ComponentTypeList(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61E7910", Offset = "0x61E6B10", VA = "0x1861E7910")]
		public ComponentTypeList(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61E8140", Offset = "0x61E7340", VA = "0x1861E8140")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x61E7C70", Offset = "0x61E6E70", VA = "0x1861E7C70")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x61E8210", Offset = "0x61E7410", VA = "0x1861E8210")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x61E7D50", Offset = "0x61E6F50", VA = "0x1861E7D50")]
		public ComponentTypeList(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x61E7570", Offset = "0x61E6770", VA = "0x1861E7570")]
		public ComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61E6A70", Offset = "0x61E5C70", VA = "0x1861E6A70")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61E71F0", Offset = "0x61E63F0", VA = "0x1861E71F0")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x61E6D10", Offset = "0x61E5F10", VA = "0x1861E6D10")]
		public static ComponentTypeList Add([In] ComponentTypeList a, [In] ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x61E7280", Offset = "0x61E6480", VA = "0x1861E7280")]
		public static ComponentTypeList Subtract([In] ComponentTypeList a, [In] ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x61E84F0", Offset = "0x61E76F0", VA = "0x1861E84F0")]
		public static ComponentTypeList operator +(ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x61E8580", Offset = "0x61E7780", VA = "0x1861E8580")]
		public static ComponentTypeList operator -(ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x61E7420", Offset = "0x61E6620", VA = "0x1861E7420", Slot = "3")]
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
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x61E9230", Offset = "0x61E8430", VA = "0x1861E9230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x61E9270", Offset = "0x61E8470", VA = "0x1861E9270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x61E87B0", Offset = "0x61E79B0", VA = "0x1861E87B0")]
		private void ComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x61E8980", Offset = "0x61E7B80", VA = "0x1861E8980")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x61E8900", Offset = "0x61E7B00", VA = "0x1861E8900")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x61E8D10", Offset = "0x61E7F10", VA = "0x1861E8D10")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x61E8B70", Offset = "0x61E7D70", VA = "0x1861E8B70")]
		public ComponentTypes32(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x61E8FB0", Offset = "0x61E81B0", VA = "0x1861E8FB0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x61E9150", Offset = "0x61E8350", VA = "0x1861E9150")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x61E8C20", Offset = "0x61E7E20", VA = "0x1861E8C20")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x61E9080", Offset = "0x61E8280", VA = "0x1861E9080")]
		public ComponentTypes32(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x61E8D90", Offset = "0x61E7F90", VA = "0x1861E8D90")]
		public ComponentTypes32(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x61E8760", Offset = "0x61E7960", VA = "0x1861E8760")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x61E89D0", Offset = "0x61E7BD0", VA = "0x1861E89D0")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x61E8A20", Offset = "0x61E7C20", VA = "0x1861E8A20", Slot = "3")]
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
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x61E66C0", Offset = "0x61E58C0", VA = "0x1861E66C0")]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x61E67D0", Offset = "0x61E59D0", VA = "0x1861E67D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x61E6600", Offset = "0x61E5800", VA = "0x1861E6600")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x61E6560", Offset = "0x61E5760", VA = "0x1861E6560")]
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

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
		internal unsafe EntityExistenceLookupByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x61EBD90", Offset = "0x61EAF90", VA = "0x1861EBD90")]
		public bool Exists(Entity entity)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x61ED8B0", Offset = "0x61ECAB0", VA = "0x1861ED8B0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, SystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x61ED7C0", Offset = "0x61EC9C0", VA = "0x1861ED7C0")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x61ED990", Offset = "0x61ECB90", VA = "0x1861ED990")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x61EDBB0", Offset = "0x61ECDB0", VA = "0x1861EDBB0")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x61EDA80", Offset = "0x61ECC80", VA = "0x1861EDA80")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x61EDB70", Offset = "0x61ECD70", VA = "0x1861EDB70")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x61EDCA0", Offset = "0x61ECEA0", VA = "0x1861EDCA0")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x61EDB90", Offset = "0x61ECD90", VA = "0x1861EDB90")]
		public static EntityQueryDesc WithFilterWriteGroup(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x61ED4E0", Offset = "0x61EC6E0", VA = "0x1861ED4E0")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x27C0E10", Offset = "0x27C0010", VA = "0x1827C0E10")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DB0", Offset = "0x27BFFB0", VA = "0x1827C0DB0")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DB0", Offset = "0x27BFFB0", VA = "0x1827C0DB0")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DB0", Offset = "0x27BFFB0", VA = "0x1827C0DB0")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DB0", Offset = "0x27BFFB0", VA = "0x1827C0DB0")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DE0", Offset = "0x27BFFE0", VA = "0x1827C0DE0")]
		public static EntityQueryDesc WithAny<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DE0", Offset = "0x27BFFE0", VA = "0x1827C0DE0")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DE0", Offset = "0x27BFFE0", VA = "0x1827C0DE0")]
		public static EntityQueryDesc WithAny<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x27E7750", Offset = "0x27E6950", VA = "0x1827E7750")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x27E7750", Offset = "0x27E6950", VA = "0x1827E7750")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DB0", Offset = "0x27BFFB0", VA = "0x1827C0DB0")]
		public static EntityQueryDesc WithAllRO<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DB0", Offset = "0x27BFFB0", VA = "0x1827C0DB0")]
		public static EntityQueryDesc WithAllRO<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DB0", Offset = "0x27BFFB0", VA = "0x1827C0DB0")]
		public static EntityQueryDesc WithAllRO<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DE0", Offset = "0x27BFFE0", VA = "0x1827C0DE0")]
		public static EntityQueryDesc WithAnyRO<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x27BC170", Offset = "0x27BB370", VA = "0x1827BC170")]
		private static ComponentType[] ExpandRW<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x27BC370", Offset = "0x27BB570", VA = "0x1827BC370")]
		private static ComponentType[] ExpandRW<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x27BC2C0", Offset = "0x27BB4C0", VA = "0x1827BC2C0")]
		private static ComponentType[] ExpandRW<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x27BC1F0", Offset = "0x27BB3F0", VA = "0x1827BC1F0")]
		private static ComponentType[] ExpandRW<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x27B8E40", Offset = "0x27B8040", VA = "0x1827B8E40")]
		private static ComponentType[] ExpandRO<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x27B9640", Offset = "0x27B8840", VA = "0x1827B9640")]
		private static ComponentType[] ExpandRO<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x27B9860", Offset = "0x27B8A60", VA = "0x1827B9860")]
		private static ComponentType[] ExpandRO<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x61ED6F0", Offset = "0x61EC8F0", VA = "0x1861ED6F0")]
		private static ComponentType[] Combine(ComponentType[] a, ComponentType[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ArchetypeChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x61E60A0", Offset = "0x61E52A0", VA = "0x1861E60A0")]
		public static void SetComponentEnabledBits(this ArchetypeChunk chunk, DynamicComponentTypeHandle typeHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2F486D0", Offset = "0x2F478D0", VA = "0x182F486D0")]
		public static void SetComponentEnabledBits<T>(this ArchetypeChunk chunk, ComponentTypeHandle<T> typeHandle) where T : struct, IEnableableComponent
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x61E5E80", Offset = "0x61E5080", VA = "0x1861E5E80")]
		public static void ClearComponentEnabledBits(this ArchetypeChunk chunk, DynamicComponentTypeHandle typeHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x61E61D0", Offset = "0x61E53D0", VA = "0x1861E61D0")]
		private static void UpdateComponentEnabledBits(this ArchetypeChunk chunk, UnsafeBitArray array, int typeIndex, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x61E5FB0", Offset = "0x61E51B0", VA = "0x1861E5FB0")]
		private static UnsafeBitArray GetComponentEnabledRW(this ArchetypeChunk chunk, DynamicComponentTypeHandle typeHandle)
		{
			return default(UnsafeBitArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2F485E0", Offset = "0x2F477E0", VA = "0x182F485E0")]
		private static UnsafeBitArray GetComponentEnabledRW<T>(this ArchetypeChunk chunk, ComponentTypeHandle<T> typeHandle) where T : struct, IEnableableComponent
		{
			return default(UnsafeBitArray);
		}
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
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2777160", Offset = "0x2776360", VA = "0x182777160")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x27773F0", Offset = "0x27765F0", VA = "0x1827773F0")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2777340", Offset = "0x2776540", VA = "0x182777340")]
		public static int IndexOf<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2777450", Offset = "0x2776650", VA = "0x182777450")]
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
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x61E6960", Offset = "0x61E5B60", VA = "0x1861E6960")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x61E6940", Offset = "0x61E5B40", VA = "0x1861E6940")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public ComponentType this[int i]
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x61E69A0", Offset = "0x61E5BA0", VA = "0x1861E69A0")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x61E6920", Offset = "0x61E5B20", VA = "0x1861E6920")]
			internal ComponentTypeEnumerator(EntityArchetype arch, bool includeEntity = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x916970", Offset = "0x915B70", VA = "0x180916970")]
			public ComponentTypeEnumerator GetEnumerator()
			{
				return default(ComponentTypeEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x61E68F0", Offset = "0x61E5AF0", VA = "0x1861E68F0")]
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
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x61E5E20", Offset = "0x61E5020", VA = "0x1861E5E20")]
				get
				{
					return default((ComponentType, bool));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x61E5DD0", Offset = "0x61E4FD0", VA = "0x1861E5DD0")]
			internal unsafe AddRemoveEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x353CA60", Offset = "0x353BC60", VA = "0x18353CA60")]
			public AddRemoveEnumerator GetEnumerator()
			{
				return default(AddRemoveEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x61E5CD0", Offset = "0x61E4ED0", VA = "0x1861E5CD0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61EBD60", Offset = "0x61EAF60", VA = "0x1861EBD60")]
		public static EntityArchetype GetInstantiateArchetype(this EntityArchetype archetype)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x61EBC20", Offset = "0x61EAE20", VA = "0x1861EBC20")]
		public static ComponentTypeEnumerator EnumerateComponentTypes(this EntityArchetype archetype, bool includeEntity = false)
		{
			return default(ComponentTypeEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x61EBC40", Offset = "0x61EAE40", VA = "0x1861EBC40")]
		public static Span<int> GetAllTypeIndices(this EntityArchetype archetype)
		{
			return default(Span<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x61EBD40", Offset = "0x61EAF40", VA = "0x1861EBD40")]
		public static int GetEntityCount(this EntityArchetype archetype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x61EBCE0", Offset = "0x61EAEE0", VA = "0x1861EBCE0")]
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
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x61EBE20", Offset = "0x61EB020", VA = "0x1861EBE20")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(this EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x61EBF60", Offset = "0x61EB160", VA = "0x1861EBF60")]
		public static void HackSetAllChangeVersionsToGlobalSystemVersion(this EntityManager em, Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x61EBE70", Offset = "0x61EB070", VA = "0x1861EBE70")]
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

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x61F01A0", Offset = "0x61EF3A0", VA = "0x1861F01A0", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x443DB10", Offset = "0x443CD10", VA = "0x18443DB10", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x279C010", Offset = "0x279B210", VA = "0x18279C010")]
		public static bool TrySetComponentData<T>(this EntityManager entityManager, Entity entity, T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2799790", Offset = "0x2798990", VA = "0x182799790")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x27995F0", Offset = "0x27987F0", VA = "0x1827995F0")]
		public static bool TryGetComponentDataField<TComponent, TValue>(this EntityManager entityManager, Entity entity, Func<TComponent, TValue> func, [Out] TValue value) where TComponent : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x61EC2A0", Offset = "0x61EB4A0", VA = "0x1861EC2A0")]
		public static void SetComponentData(this EntityManager entityManager, Entity entity, int typeIndex, NativeArray<byte> src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x61EC4B0", Offset = "0x61EB6B0", VA = "0x1861EC4B0")]
		public static void SetComponentData(this EntityManager entityManager, ComponentType type, NativeArray<Entity> entities, NativeArray<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2797910", Offset = "0x2796B10", VA = "0x182797910")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2798AB0", Offset = "0x2797CB0", VA = "0x182798AB0")]
		public static void SetTag<T>(this EntityManager entityManager, Entity entity, bool isTagSet) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2797840", Offset = "0x2796A40", VA = "0x182797840")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x61EC0F0", Offset = "0x61EB2F0", VA = "0x1861EC0F0")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		public static void AssertMatchingSize(int typeIndex, int length)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class EntityManagerComponentDataFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x61EC6C0", Offset = "0x61EB8C0", VA = "0x1861EC6C0")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class EntityManagerComponentObjectExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x279C3D0", Offset = "0x279B5D0", VA = "0x18279C3D0")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x279C460", Offset = "0x279B660", VA = "0x18279C460")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, [Out] T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x279C2F0", Offset = "0x279B4F0", VA = "0x18279C2F0")]
		public static void AddAndSetComponentObject<T>(this EntityManager entityManager, Entity entity, T value) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class EntityManagerComponentOrderExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class EntityManagerDependencyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x279C530", Offset = "0x279B730", VA = "0x18279C530")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x279C6B0", Offset = "0x279B8B0", VA = "0x18279C6B0")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x279C770", Offset = "0x279B970", VA = "0x18279C770")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61ECA10", Offset = "0x61EBC10", VA = "0x1861ECA10")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x61ECB50", Offset = "0x61EBD50", VA = "0x1861ECB50")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x61EC770", Offset = "0x61EB970", VA = "0x1861EC770")]
		public static JobHandle AddReadDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x61EC8C0", Offset = "0x61EBAC0", VA = "0x1861EC8C0")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class EntityManagerDynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x279D2E0", Offset = "0x279C4E0", VA = "0x18279D2E0")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x279CEA0", Offset = "0x279C0A0", VA = "0x18279CEA0")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, [Out] DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x279CA40", Offset = "0x279BC40", VA = "0x18279CA40")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x279CC00", Offset = "0x279BE00", VA = "0x18279CC00")]
		public static DynamicBuffer<T> GetBufferRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class EntityManagerEditorExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class EntityManagerEntityExistenceLookupByEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x61ECC90", Offset = "0x61EBE90", VA = "0x1861ECC90")]
		public static EntityExistenceLookupByEntity GetEntityExistenceLookupByEntity(this EntityManager entityManager)
		{
			return default(EntityExistenceLookupByEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class EntityManagerRemoveComponentExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class EntityManagerSharedComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x279D4E0", Offset = "0x279C6E0", VA = "0x18279D4E0")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, [Out] T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class EntityQueryArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x61ED3A0", Offset = "0x61EC5A0", VA = "0x1861ED3A0")]
		public static int CalculateArchetypeCount(this EntityQuery query)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x61ED290", Offset = "0x61EC490", VA = "0x1861ED290")]
		private static int CalculateArchetypeCount(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Unity.Entities.EntityQueryFilter filter)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class EntityQueryChangeVersionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x27B8DB0", Offset = "0x27B7FB0", VA = "0x1827B8DB0")]
		public static EntityQuery WithChangedVersionFilter<T1, T2, T3>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x27B8D40", Offset = "0x27B7F40", VA = "0x1827B8D40")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x27B8CF0", Offset = "0x27B7EF0", VA = "0x1827B8CF0")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x61EDCC0", Offset = "0x61ECEC0", VA = "0x1861EDCC0")]
		public static Entity FirstMatchingEntity(this EntityQuery query)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x61EDEC0", Offset = "0x61ED0C0", VA = "0x1861EDEC0")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x61EDDC0", Offset = "0x61ECFC0", VA = "0x1861EDDC0")]
		public static bool IsEmpty(this EntityQuery entityQuery, [Out] int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x61EDE10", Offset = "0x61ED010", VA = "0x1861EDE10")]
		public static bool IsEmpty(this EntityQueryInJob entityQuery)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class EntityQueryToComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x27F2B10", Offset = "0x27F1D10", VA = "0x1827F2B10")]
		public static NativeArray<T> ToSharedComponentDataArray<T>(this EntityQuery entityQuery, Allocator allocator = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x27F2890", Offset = "0x27F1A90", VA = "0x1827F2890")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x61EF350", Offset = "0x61EE550", VA = "0x1861EF350")]
		[BurstCompatible(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", CompileTarget = BurstCompatibleAttribute.BurstCompatibleCompileTarget.Editor)]
		public static NativeArray<byte> ToComponentDataArray(this EntityQuery entityQuery, Allocator allocator, int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x27F2510", Offset = "0x27F1710", VA = "0x1827F2510")]
		public static NativeArrayAsync<T> ToComponentDataArrayAsync<T>(this EntityQuery query, Allocator allocator = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x61EF210", Offset = "0x61EE410", VA = "0x1861EF210")]
		private static NativeArray<byte> CreateComponentDataArrayRun(Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, Allocator allocator, ComponentTypeHandle type, EntityQuery entityQuery, Unity.Entities.EntityQueryFilter filter)
		{
			return default(NativeArray<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class EntityQueryToEntityArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x61EF720", Offset = "0x61EE920", VA = "0x1861EF720")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x61EF610", Offset = "0x61EE810", VA = "0x1861EF610")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class EntityQueryToEntityArrayFilteredExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class JobChunkExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class UnsafeBitArrayExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct ArchetypeIterator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private ArchetypeChunkIterator iterator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private unsafe Unity.Entities.Archetype* lastArchetype;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface IUTF8BufferElementData : IBufferElementData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct AsyncDispose : IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private JobGroup group;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x61E6530", Offset = "0x61E5730", VA = "0x1861E6530")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x61E6440", Offset = "0x61E5640", VA = "0x1861E6440")]
		public AsyncDispose(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x61E6530", Offset = "0x61E5730", VA = "0x1861E6530")]
		public static implicit operator JobHandle(AsyncDispose set)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2636640", Offset = "0x2635840", VA = "0x182636640")]
		public void Add<T>(T disposable) where T : struct, INativeDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x26365A0", Offset = "0x26357A0", VA = "0x1826365A0")]
		public void Add<T>(NativeArrayAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x26365A0", Offset = "0x26357A0", VA = "0x1826365A0")]
		public void Add<T>(NativeArray<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x26365A0", Offset = "0x26357A0", VA = "0x1826365A0")]
		public void Add<T>(NativeListAsync<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x26365A0", Offset = "0x26357A0", VA = "0x1826365A0")]
		public void Add<T>(NativeList<T> list) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x61E63A0", Offset = "0x61E55A0", VA = "0x1861E63A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x61E63E0", Offset = "0x61E55E0", VA = "0x1861E63E0", Slot = "4")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
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
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x61EFAD0", Offset = "0x61EECD0", VA = "0x1861EFAD0")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x61EFA20", Offset = "0x61EEC20", VA = "0x1861EFA20")]
		public JobGroup(JobHandle dependsOn, int capacity = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x61EF850", Offset = "0x61EEA50", VA = "0x1861EF850")]
		public void Add(JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x61E63A0", Offset = "0x61E55A0", VA = "0x1861E63A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x61EF9C0", Offset = "0x61EEBC0", VA = "0x1861EF9C0", Slot = "4")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x61EF920", Offset = "0x61EEB20", VA = "0x1861EF920")]
		private NativeList<JobHandle> GetList()
		{
			return default(NativeList<JobHandle>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[Flags]
	public enum CopyFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		NativeComponents = 1,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		ManagedComponents = 2,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		BufferComponents = 4,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		RemapEntityRefs = 8,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		All = 0xF
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal struct CopyEntitiesUtility
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[BurstCompile]
		private struct PopulateRemappingArrayJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			[ReadOnly]
			public NativeArray<Entity> dstEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x61EFDC0", Offset = "0x61EEFC0", VA = "0x1861EFDC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[BurstCompile]
		private struct RemapChunksFilteredJob : IJobParallelForBurstSchedulable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			[ReadOnly]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			[NativeDisableUnsafePtrRestriction]
			public unsafe Unity.Entities.EntityComponentStore* dstEntityComponentStore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public int chunkHeaderType;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x61EFEC0", Offset = "0x61EF0C0", VA = "0x1861EFEC0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x61EA700", Offset = "0x61E9900", VA = "0x1861EA700")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, [Out] NativeArray<Entity> srcEntities, [Out] NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.All, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x61EB970", Offset = "0x61EAB70", VA = "0x1861EB970")]
		private static NativeArray<ArchetypeChunk> GetChunksFromEntities(NativeArray<Entity> entities, EntityManager srcEntityManager)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x61EB090", Offset = "0x61EA290", VA = "0x1861EB090")]
		private unsafe static NativeArray<ArchetypeChunk> CopyEntitiesInternal(NativeArray<ArchetypeChunk> srcChunks, Unity.Entities.EntityDataAccess* srcAccess, CopyFlags copyFlags)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x61EBA80", Offset = "0x61EAC80", VA = "0x1861EBA80")]
		internal unsafe static void RemapEntityRefs(NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping, Unity.Entities.EntityDataAccess* dataAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1BF2D50", Offset = "0x1BF1F50", VA = "0x181BF2D50")]
		private static bool HasFlag(CopyFlags copyFlags, CopyFlags testFlag)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x61EB6E0", Offset = "0x61EA8E0", VA = "0x1861EB6E0")]
		private unsafe static void CreateChunks(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x61EB580", Offset = "0x61EA780", VA = "0x1861EB580")]
		private unsafe static void CopyNames(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x61EA080", Offset = "0x61E9280", VA = "0x1861EA080")]
		private static void CloneNativeComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x61EA420", Offset = "0x61E9620", VA = "0x1861EA420")]
		public unsafe static void CloneNativeComponents([In] Unity.Entities.EntityBatchInChunk srcBatch, Unity.Entities.Chunk* dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x61E95B0", Offset = "0x61E87B0", VA = "0x1861E95B0")]
		private static void ClearBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61E93B0", Offset = "0x61E85B0", VA = "0x1861E93B0")]
		private static void ClearBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x61E9C30", Offset = "0x61E8E30", VA = "0x1861E9C30")]
		private static void CloneBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x61E99C0", Offset = "0x61E8BC0", VA = "0x1861E99C0")]
		private static void CloneBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x61E9860", Offset = "0x61E8A60", VA = "0x1861E9860")]
		private static void ClearManagedComponents(NativeArray<ArchetypeChunk> chunks, uint globalSystemVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x61E9F70", Offset = "0x61E9170", VA = "0x1861E9F70")]
		private static void CloneManagedComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x61EB830", Offset = "0x61EAA30", VA = "0x1861EB830")]
		private static NativeArray<Entity> CreateEntityArray(NativeArray<ArchetypeChunk> chunks, Allocator allocator, int entityCount)
		{
			return default(NativeArray<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[BurstCompatible]
	public struct EntityQueryInJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe Unity.Entities.EntityQueryImpl* __impl;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsEmptyIgnoreFilter
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x61EEBF0", Offset = "0x61EDDF0", VA = "0x1861EEBF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		public static implicit operator EntityQueryInJob(EntityQuery query)
		{
			return default(EntityQueryInJob);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A160", Offset = "0x3C69360", VA = "0x183C6A160")]
		public EntityQueryInJob(EntityQuery query)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x61EDFA0", Offset = "0x61ED1A0", VA = "0x1861EDFA0")]
		public int CalculateEntityCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x61EE0E0", Offset = "0x61ED2E0", VA = "0x1861EE0E0")]
		public bool HasFilter()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x61EE030", Offset = "0x61ED230", VA = "0x1861EE030")]
		public ArchetypeChunkIterator GetArchetypeChunkIterator()
		{
			return default(ArchetypeChunkIterator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x61EE130", Offset = "0x61ED330", VA = "0x1861EE130")]
		[BurstCompatible]
		public NativeArray<Entity> ToEntityArray(EntityTypeHandle entityType, Allocator allocator = Allocator.Temp)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x27EFC20", Offset = "0x27EEE20", VA = "0x1827EFC20")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle<T> componentType, Allocator allocator = Allocator.Temp) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		internal unsafe Unity.Entities.EntityQueryImpl* _GetImpl()
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityQueryImpl*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x61EEA80", Offset = "0x61EDC80", VA = "0x1861EEA80")]
		private unsafe static void _GatherEntities(Entity* entities, EntityTypeHandle entityTypeHandle, [In] Unity.Entities.UnsafeCachedChunkList cache, uint requiredChangeVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x61EE870", Offset = "0x61EDA70", VA = "0x1861EE870")]
		private unsafe static void _GatherEntitiesWithFilter(Entity* entities, Unity.Entities.EntityQueryFilter filter, Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, EntityTypeHandle entityTypeHandle, [In] Unity.Entities.UnsafeCachedChunkList cache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x61EE6C0", Offset = "0x61ED8C0", VA = "0x1861EE6C0")]
		private unsafe static void _GatherComponentData(byte* componentData, int typeIndex, [In] Unity.Entities.UnsafeCachedChunkList cache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x61EE480", Offset = "0x61ED680", VA = "0x1861EE480")]
		private unsafe static void _GatherComponentDataWithFilter(byte* componentData, int typeIndex, [In] Unity.Entities.UnsafeCachedChunkList cache, [In] Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, Unity.Entities.EntityQueryFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61EDF00", Offset = "0x61ED100", VA = "0x1861EDF00")]
		private void CalculateChunkAndEntityCount([Out] int entityCount, [Out] int chunkCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class EntityQueryInJobExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
		public static EntityQueryInJob UseInJob(this EntityQuery query)
		{
			return default(EntityQueryInJob);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class ListExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class MemoryUtils
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public readonly struct NativeArrayAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x4085A40", Offset = "0x4084C40", VA = "0x184085A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x843A80", Offset = "0x842C80", VA = "0x180843A80")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xBE7D10", Offset = "0xBE6F10", VA = "0x180BE7D10")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4084FF0", Offset = "0x40841F0", VA = "0x184084FF0")]
		public NativeArray<T> Complete()
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x40858D0", Offset = "0x4084AD0", VA = "0x1840858D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x40856D0", Offset = "0x40848D0", VA = "0x1840856D0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x280D860", Offset = "0x280CA60", VA = "0x18280D860")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A18CB0", Offset = "0x2A17EB0", VA = "0x182A18CB0")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x61EFBA0", Offset = "0x61EEDA0", VA = "0x1861EFBA0")]
		public static JobHandle CombineHandles(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x61EFBE0", Offset = "0x61EEDE0", VA = "0x1861EFBE0")]
		public static JobHandle Combine(this Span<JobHandle> handles)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class NativeArrayUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x61EFC90", Offset = "0x61EEE90", VA = "0x1861EFC90")]
		public unsafe static NativeArray<byte> AsArray(byte* ptr, int length, bool isReadOnly = false)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x61EFD10", Offset = "0x61EEF10", VA = "0x1861EFD10")]
		public static NativeArray<byte> AsReadOnlyArray(ReadOnlySpan<byte> span)
		{
			return default(NativeArray<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public readonly struct NativeListAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly NativeList<T> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x4085A40", Offset = "0x4084C40", VA = "0x184085A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x40C74F0", Offset = "0x40C66F0", VA = "0x1840C74F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x843A80", Offset = "0x842C80", VA = "0x180843A80")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xBE7D10", Offset = "0xBE6F10", VA = "0x180BE7D10")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x40C6FC0", Offset = "0x40C61C0", VA = "0x1840C6FC0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4084FF0", Offset = "0x40841F0", VA = "0x184084FF0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x40C7230", Offset = "0x40C6430", VA = "0x1840C7230", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x40C7160", Offset = "0x40C6360", VA = "0x1840C7160")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public readonly struct NativeMultiHashMapAsync<TKey, TValue> : IDisposable where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly NativeParallelMultiHashMap<TKey, TValue> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x40E7A90", Offset = "0x40E6C90", VA = "0x1840E7A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xBE7D10", Offset = "0xBE6F10", VA = "0x180BE7D10")]
		public NativeMultiHashMapAsync(NativeParallelMultiHashMap<TKey, TValue> map, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4084FF0", Offset = "0x40841F0", VA = "0x184084FF0")]
		public NativeParallelMultiHashMap<TKey, TValue> Complete()
		{
			return default(NativeParallelMultiHashMap<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x40E79B0", Offset = "0x40E6BB0", VA = "0x1840E79B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct NativeResultAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[BurstCompile]
	public struct RemapEntitiesInPlaceJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x61F0130", Offset = "0x61EF330", VA = "0x1861F0130", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class SpanUtility
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C800", Offset = "0x2B8BA00", VA = "0x182B8C800")]
		public static int MemCmp<T>(ReadOnlySpan<T> spanA, ReadOnlySpan<T> spanB, int length) where T : struct
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C700", Offset = "0x2B8B900", VA = "0x182B8C700")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C4E0", Offset = "0x2B8B6E0", VA = "0x182B8C4E0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C5E0", Offset = "0x2B8B7E0", VA = "0x182B8C5E0")]
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeList<T> list) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class StructUtility
	{
	}
}
namespace Unity.Entities.Scene
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class EntityQuerySceneExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct QueryResetFilterScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private EntityQuery query;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static bool isInScope;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x61EFE70", Offset = "0x61EF070", VA = "0x1861EFE70")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x61EFE20", Offset = "0x61EF020", VA = "0x1861EFE20", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x61EEE40", Offset = "0x61EE040", VA = "0x1861EEE40")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x61EF0A0", Offset = "0x61EE2A0", VA = "0x1861EF0A0")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x61EED80", Offset = "0x61EDF80", VA = "0x1861EED80")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x61EEC40", Offset = "0x61EDE40", VA = "0x1861EEC40")]
		public static int CalculateEntityCount(this EntityQuery query, SceneTag scene)
		{
			return default(int);
		}
	}
}
namespace Unity.Entities.LinkedEntityGroupExtensions
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class EntityManagerLinkedEntityGroupExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x61ECF40", Offset = "0x61EC140", VA = "0x1861ECF40")]
		public static bool TryGetChildEntitySubArrayRO([In] this EntityManager entityManager, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x61ED070", Offset = "0x61EC270", VA = "0x1861ED070")]
		public static bool TryGetChildEntitySubArray([In] this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x61ED160", Offset = "0x61EC360", VA = "0x1861ED160")]
		public static bool TryGetChildEntitySubArray([In] this DynamicBuffer<LinkedEntityGroup> buffer, [Out] NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x61ECDE0", Offset = "0x61EBFE0", VA = "0x1861ECDE0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x61ECCE0", Offset = "0x61EBEE0", VA = "0x1861ECCE0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x61ECF10", Offset = "0x61EC110", VA = "0x1861ECF10")]
		public static NativeArray<Entity> GetChildEntitySubArray(this DynamicBuffer<LinkedEntityGroup> buffer)
		{
			return default(NativeArray<Entity>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2741098276
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x61F03F0", Offset = "0x61EF5F0", VA = "0x1861F03F0")]
	public static void NHHHONPGHOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x61F03E0", Offset = "0x61EF5E0", VA = "0x1861F03E0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class NIBLCMOALME
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public NIBLCMOALME()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
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

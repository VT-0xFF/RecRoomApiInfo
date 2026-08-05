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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DAHNBKBOKKK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct DIILMDJJKDF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private EntityManager NMHMIPEFENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NativeArray<Entity> IBGFBPGPJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int NNAODBDJDNJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T JLCKGMHIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x21DCDE0", Offset = "0x21DBFE0", VA = "0x1821DCDE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x21DCE50", Offset = "0x21DC050", VA = "0x1821DCE50")]
		public DIILMDJJKDF(NativeArray<Entity> IBGFBPGPJKP, EntityManager NMHMIPEFENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x21DCE40", Offset = "0x21DC040", VA = "0x1821DCE40")]
		public bool ECNCACELDMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x15BDA90", Offset = "0x15BCC90", VA = "0x1815BDA90")]
		public DIILMDJJKDF<T> EEOIHAEEMHN()
		{
			return default(DIILMDJJKDF<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct KOAPMBLICED<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EntityManager NMHMIPEFENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NativeArray<Entity> IBGFBPGPJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int NNAODBDJDNJ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1CC6210", Offset = "0x1CC5410", VA = "0x181CC6210")]
	public static int MLAHEILLMBF<T>(this NativeArray<T> NABCGCEIEGG) where T : struct
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1CC6240", Offset = "0x1CC5440", VA = "0x181CC6240")]
	public static int MLAHEILLMBF<T>(this NativeList<T> NABCGCEIEGG) where T : struct
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68D9F10", Offset = "0x68D9110", VA = "0x1868D9F10")]
	public static void IMHGLAOCPPF(this ref NativeBitArray NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CC5A90", Offset = "0x1CC4C90", VA = "0x181CC5A90")]
	public static void IMHGLAOCPPF<T>(this ref NativeArray<T> NABCGCEIEGG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1CC58A0", Offset = "0x1CC4AA0", VA = "0x181CC58A0")]
	public static void IMHGLAOCPPF<T>(this ref NativeList<T> NABCGCEIEGG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1CC5E30", Offset = "0x1CC5030", VA = "0x181CC5E30")]
	public static void IMHGLAOCPPF<TKey, TValue>(this ref NativeParallelHashMap<TKey, TValue> NABCGCEIEGG) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1CC5B50", Offset = "0x1CC4D50", VA = "0x181CC5B50")]
	public static void IMHGLAOCPPF<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> NABCGCEIEGG) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1CC5960", Offset = "0x1CC4B60", VA = "0x181CC5960")]
	public static JobHandle IMHGLAOCPPF<T>(this ref NativeArrayAsync<T> NABCGCEIEGG, JobHandle FOFFIFNKDII) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1CC5C50", Offset = "0x1CC4E50", VA = "0x181CC5C50")]
	public static JobHandle IMHGLAOCPPF<T>(this ref NativeListAsync<T> NABCGCEIEGG, JobHandle FOFFIFNKDII) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CC58E0", Offset = "0x1CC4AE0", VA = "0x181CC58E0")]
	public static JobHandle IMHGLAOCPPF<T>(this ref NativeArray<T> NABCGCEIEGG, JobHandle FOFFIFNKDII) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1CC5A10", Offset = "0x1CC4C10", VA = "0x181CC5A10")]
	public static JobHandle IMHGLAOCPPF<T>(this ref NativeList<T> NABCGCEIEGG, JobHandle FOFFIFNKDII) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1CC5EB0", Offset = "0x1CC50B0", VA = "0x181CC5EB0")]
	public static JobHandle IMHGLAOCPPF<T>(this ref NativeParallelHashSet<T> NABCGCEIEGG, JobHandle FOFFIFNKDII) where T : struct, IEquatable<T>
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1CC57E0", Offset = "0x1CC49E0", VA = "0x181CC57E0")]
	public static bool AIIPHFCAOIP<T>(this NativeArray<T> NABCGCEIEGG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1CC62D0", Offset = "0x1CC54D0", VA = "0x181CC62D0")]
	public static DIILMDJJKDF<T> OGINPEEKGKB<T>(this NativeList<Entity> NLPPJLIGDJN, EntityManager NMHMIPEFENM) where T : class
	{
		return default(DIILMDJJKDF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1CC6290", Offset = "0x1CC5490", VA = "0x181CC6290")]
	public static DIILMDJJKDF<T> OGINPEEKGKB<T>(this NativeArray<Entity> NLPPJLIGDJN, EntityManager NMHMIPEFENM) where T : class
	{
		return default(DIILMDJJKDF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1CC5820", Offset = "0x1CC4A20", VA = "0x181CC5820")]
	public static NativeArray<TKey> FHHAEJLCIAM<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> EAAEGPDMONP, Allocator KPFKDHLBOGB, out int PBDCIOJHDLJ) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default(NativeArray<TKey>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FJHDJAIDHGM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68DC400", Offset = "0x68DB600", VA = "0x1868DC400")]
	public unsafe static NativeArray<byte> ICCHCPPDAJL(byte* PKEAPCMBMMC, int AAALINBAMFJ, bool JMPIAKIDPLJ = false)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68DC480", Offset = "0x68DB680", VA = "0x1868DC480")]
	public static NativeArray<byte> JLELMMDGCJA(ReadOnlySpan<byte> HFCNACJMMFH)
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct OAJEEBBBBBN : IEnumerable, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly JobHandle FOFFIFNKDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private NativeList<JobHandle> IBJHJABBAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int FKDMPINADBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private JobHandle MHOCFKBIHCO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JobHandle HNJCBPDJFLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xE6A190", Offset = "0xE69390", VA = "0x180E6A190")]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JobHandle OMMPADAGKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68DC8B0", Offset = "0x68DBAB0", VA = "0x1868DC8B0")]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68DCA80", Offset = "0x68DBC80", VA = "0x1868DCA80")]
	public OAJEEBBBBBN(JobHandle FOFFIFNKDII, int HCKHKGKDPCJ = 8)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68DC540", Offset = "0x68DB740", VA = "0x1868DC540")]
	public static JobHandle OMHOCPNBHHH(OAJEEBBBBBN MFKCFHJMFME)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68DC7E0", Offset = "0x68DB9E0", VA = "0x1868DC7E0")]
	public void CKPKOIJGHLD(JobHandle EMCKGOPIABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68DC570", Offset = "0x68DB770", VA = "0x1868DC570", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68DCA30", Offset = "0x68DBC30", VA = "0x1868DCA30", Slot = "4")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68DC990", Offset = "0x68DBB90", VA = "0x1868DC990")]
	private NativeList<JobHandle> PGIBKDDLCDE()
	{
		return default(NativeList<JobHandle>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LGFNJAMMGPB : IEnumerable, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private OAJEEBBBBBN MFKCFHJMFME;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JobHandle OMMPADAGKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68DC540", Offset = "0x68DB740", VA = "0x1868DC540")]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68DC600", Offset = "0x68DB800", VA = "0x1868DC600")]
	public LGFNJAMMGPB(JobHandle FOFFIFNKDII, int HCKHKGKDPCJ = 8)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68DC540", Offset = "0x68DB740", VA = "0x1868DC540")]
	public static JobHandle OMHOCPNBHHH(LGFNJAMMGPB PNAKIENPNBK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x19EFE60", Offset = "0x19EF060", VA = "0x1819EFE60")]
	public void CKPKOIJGHLD<T>(T AFMDFNKGAJN) where T : struct, INativeDisposable
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x19EFDC0", Offset = "0x19EEFC0", VA = "0x1819EFDC0")]
	public void CKPKOIJGHLD<T>(NativeArrayAsync<T> MLEOGHHEJOI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x19EFDC0", Offset = "0x19EEFC0", VA = "0x1819EFDC0")]
	public void CKPKOIJGHLD<T>(NativeArray<T> MLEOGHHEJOI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x19EFDC0", Offset = "0x19EEFC0", VA = "0x1819EFDC0")]
	public void CKPKOIJGHLD<T>(NativeListAsync<T> MLEOGHHEJOI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x19EFDC0", Offset = "0x19EEFC0", VA = "0x1819EFDC0")]
	public void CKPKOIJGHLD<T>(NativeList<T> MLEOGHHEJOI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x68DC570", Offset = "0x68DB770", VA = "0x1868DC570", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x68DC5B0", Offset = "0x68DB7B0", VA = "0x1868DC5B0", Slot = "4")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class StructUtility
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x182ACF0", Offset = "0x1829EF0", VA = "0x18182ACF0")]
		public static bool Equals<T>(T a, T b) where T : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class EntityQueryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68DBA60", Offset = "0x68DAC60", VA = "0x1868DBA60")]
		public static Entity FirstMatchingEntity(this EntityQuery query)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68DBBF0", Offset = "0x68DADF0", VA = "0x1868DBBF0")]
		public static bool IsEmpty(this EntityQuery entityQuery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68DBB50", Offset = "0x68DAD50", VA = "0x1868DBB50")]
		public static bool IsEmpty(this EntityQuery entityQuery, out int count)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68DBBA0", Offset = "0x68DADA0", VA = "0x1868DBBA0")]
		public static bool IsEmpty(this EntityQueryInJob entityQuery, out int count)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class EntityManagerComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile]
		private struct SetComponentDataArrayFromArrayJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			[ReadOnly]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			[ReadOnly]
			public NativeArray<byte> src;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public ComponentDataFromEntity dst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int typeSize;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x68DCE50", Offset = "0x68DC050", VA = "0x1868DCE50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[BurstCompile]
		private struct SetComponentDataArrayFromValueJob<T> : IJob where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			[WriteOnly]
			public ComponentDataFromEntity<T> dstArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x46AB0A0", Offset = "0x46AA2A0", VA = "0x1846AB0A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile]
		private struct SetComponentDataChunkJob<T> : IJobChunk where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			[WriteOnly]
			public ComponentTypeHandle<T> componentArrayType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x18F9E50", Offset = "0x18F9050", VA = "0x1818F9E50")]
		public static bool TryGetComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x18F9CD0", Offset = "0x18F8ED0", VA = "0x1818F9CD0")]
		public static bool TryGetComponentDataField<TComponent, TValue>(this EntityManager entityManager, Entity entity, Func<TComponent, TValue> func, out TValue value) where TComponent : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68DA500", Offset = "0x68D9700", VA = "0x1868DA500")]
		public static void SetComponentData(this EntityManager entityManager, Entity entity, int typeIndex, ReadOnlySpan<byte> srcSpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x18F91A0", Offset = "0x18F83A0", VA = "0x1818F91A0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x18F9C70", Offset = "0x18F8E70", VA = "0x1818F9C70")]
		public static void SetTag<T>(this EntityManager entityManager, Entity entity, bool isTagSet) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x18F8F80", Offset = "0x18F8180", VA = "0x1818F8F80")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68DA320", Offset = "0x68D9520", VA = "0x1868DA320")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		public static void AssertMatchingSize(int typeIndex, int length)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class EntityManagerComponentDataFromEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68DA890", Offset = "0x68D9A90", VA = "0x1868DA890")]
		public static ComponentDataFromEntity GetComponentDataBytesFromEntity(this EntityManager entityManager, int typeIndex, bool isReadOnly = false)
		{
			return default(ComponentDataFromEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class EntityManagerEntityExistenceLookupByEntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68DACC0", Offset = "0x68D9EC0", VA = "0x1868DACC0")]
		public static EntityExistenceLookupByEntity GetEntityExistenceLookupByEntity(this EntityManager entityManager)
		{
			return default(EntityExistenceLookupByEntity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class EntityManagerRemoveComponentExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class EntityManagerEditorExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class EntityQueryToComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x26CA930", Offset = "0x26C9B30", VA = "0x1826CA930")]
		public static NativeArray<T> ToSharedComponentDataArray<T>(this EntityQuery entityQuery, Allocator allocator = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x26CA670", Offset = "0x26C9870", VA = "0x1826CA670")]
		public static NativeArray<T> ToComponentDataArray<T>(this EntityQuery entityQuery) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x26CA210", Offset = "0x26C9410", VA = "0x1826CA210")]
		public static NativeArrayAsync<T> ToComponentDataArrayAsync<T>(this EntityQuery query, Allocator allocator = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(NativeArrayAsync<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class EntityManagerArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x68DA100", Offset = "0x68D9300", VA = "0x1868DA100")]
		public static EntityArchetype CreateArchetype(this EntityManager entityManager, Span<ComponentType> types)
		{
			return default(EntityArchetype);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class EntityQueryChangeVersionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1906DF0", Offset = "0x1905FF0", VA = "0x181906DF0")]
		public static EntityQuery WithChangedVersionFilter<T1, T2>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1906E60", Offset = "0x1906060", VA = "0x181906E60")]
		public static EntityQuery WithChangedVersionFilter<T>(this EntityQuery entityQuery)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct ComponentTypes32
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
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

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x68D7830", Offset = "0x68D6A30", VA = "0x1868D7830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IEnumerable<ComponentType> Types
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x68D7870", Offset = "0x68D6A70", VA = "0x1868D7870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68D6DC0", Offset = "0x68D5FC0", VA = "0x1868D6DC0")]
		private void ComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68D6FC0", Offset = "0x68D61C0", VA = "0x1868D6FC0")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F30", Offset = "0x68D6130", VA = "0x1868D6F30")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68D7440", Offset = "0x68D6640", VA = "0x1868D7440")]
		public ComponentTypes32(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68D72A0", Offset = "0x68D64A0", VA = "0x1868D72A0")]
		public ComponentTypes32(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68D74C0", Offset = "0x68D66C0", VA = "0x1868D74C0")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x68D7590", Offset = "0x68D6790", VA = "0x1868D7590")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x68D7350", Offset = "0x68D6550", VA = "0x1868D7350")]
		public ComponentTypes32(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x68D71C0", Offset = "0x68D63C0", VA = "0x1868D71C0")]
		public ComponentTypes32(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68D7670", Offset = "0x68D6870", VA = "0x1868D7670")]
		public ComponentTypes32(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x68D6D70", Offset = "0x68D5F70", VA = "0x1868D6D70")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x68D7010", Offset = "0x68D6210", VA = "0x1868D7010")]
		public void SortAndComputeMasks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x68D7060", Offset = "0x68D6260", VA = "0x1868D7060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class EntityQueryArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x68DB390", Offset = "0x68DA590", VA = "0x1868DB390")]
		public static int CalculateArchetypeCount(this EntityQuery query)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x68DB280", Offset = "0x68DA480", VA = "0x1868DB280")]
		private static int CalculateArchetypeCount(ref Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypes, ref Unity.Entities.EntityQueryFilter filter)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class ListExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[NativeContainerSupportsMinMaxWriteRestriction]
	[NativeContainer]
	public struct ComponentTypeHandle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal readonly bool m_IsReadOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal readonly bool m_IsZeroSized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly int m_Length;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class EntityQueryDescExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x68DB830", Offset = "0x68DAA30", VA = "0x1868DB830")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, SystemBase system)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x68DB750", Offset = "0x68DA950", VA = "0x1868DB750")]
		public static EntityQuery ToEntityQuery(this EntityQueryDesc desc, EntityManager entityManager)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68DB910", Offset = "0x68DAB10", VA = "0x1868DB910")]
		public static EntityQueryDesc WithAll(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68DB9F0", Offset = "0x68DABF0", VA = "0x1868DB9F0")]
		public static EntityQueryDesc WithNone(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x68DB960", Offset = "0x68DAB60", VA = "0x1868DB960")]
		public static EntityQueryDesc WithAny(this EntityQueryDesc desc, params ComponentType[] components)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x68DB9B0", Offset = "0x68DABB0", VA = "0x1868DB9B0")]
		public static EntityQueryDesc WithDisabled(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x68DBA40", Offset = "0x68DAC40", VA = "0x1868DBA40")]
		public static EntityQueryDesc WithPrefab(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x68DB9D0", Offset = "0x68DABD0", VA = "0x1868DB9D0")]
		public static EntityQueryDesc WithFilterWriteGroup(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x68DB4D0", Offset = "0x68DA6D0", VA = "0x1868DB4D0")]
		public static EntityQueryDesc Clone(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x190E810", Offset = "0x190DA10", VA = "0x18190E810")]
		public static EntityQueryDesc With<T>(this EntityQueryDesc desc, bool include)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x190E780", Offset = "0x190D980", VA = "0x18190E780")]
		public static EntityQueryDesc WithAll<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x190E780", Offset = "0x190D980", VA = "0x18190E780")]
		public static EntityQueryDesc WithAll<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x190E780", Offset = "0x190D980", VA = "0x18190E780")]
		public static EntityQueryDesc WithAll<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x190E780", Offset = "0x190D980", VA = "0x18190E780")]
		public static EntityQueryDesc WithAll<T1, T2, T3, T4>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x190E7B0", Offset = "0x190D9B0", VA = "0x18190E7B0")]
		public static EntityQueryDesc WithAny<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x190E7E0", Offset = "0x190D9E0", VA = "0x18190E7E0")]
		public static EntityQueryDesc WithNone<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x190E7E0", Offset = "0x190D9E0", VA = "0x18190E7E0")]
		public static EntityQueryDesc WithNone<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x190E780", Offset = "0x190D980", VA = "0x18190E780")]
		public static EntityQueryDesc WithAllRO<T1>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x190E780", Offset = "0x190D980", VA = "0x18190E780")]
		public static EntityQueryDesc WithAllRO<T1, T2>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x190E780", Offset = "0x190D980", VA = "0x18190E780")]
		public static EntityQueryDesc WithAllRO<T1, T2, T3>(this EntityQueryDesc desc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x19099A0", Offset = "0x1908BA0", VA = "0x1819099A0")]
		private static ComponentType[] ExpandRW<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x19098F0", Offset = "0x1908AF0", VA = "0x1819098F0")]
		private static ComponentType[] ExpandRW<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1909EE0", Offset = "0x19090E0", VA = "0x181909EE0")]
		private static ComponentType[] ExpandRW<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x190BBC0", Offset = "0x190ADC0", VA = "0x18190BBC0")]
		private static ComponentType[] ExpandRW<T1, T2, T3, T4>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1906EA0", Offset = "0x19060A0", VA = "0x181906EA0")]
		private static ComponentType[] ExpandRO<T1>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1907020", Offset = "0x1906220", VA = "0x181907020")]
		private static ComponentType[] ExpandRO<T1, T2>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1907530", Offset = "0x1906730", VA = "0x181907530")]
		private static ComponentType[] ExpandRO<T1, T2, T3>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x68DB670", Offset = "0x68DA870", VA = "0x1868DB670")]
		private static ComponentType[] Combine(ComponentType[] a, ComponentType[] b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface IComponent
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct ArchetypeIterator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private ArchetypeChunkIterator iterator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private unsafe Unity.Entities.Archetype* lastArchetype;
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[NativeContainer]
	public struct ComponentDataFromEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly int m_TypeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly int m_TypeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly uint m_GlobalSystemVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Unity.Entities.LookupCache m_Cache;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NativeArray<byte> this[Entity entity]
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x68D4AA0", Offset = "0x68D3CA0", VA = "0x1868D4AA0")]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x68D4B60", Offset = "0x68D3D60", VA = "0x1868D4B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x68D4A60", Offset = "0x68D3C60", VA = "0x1868D4A60")]
		internal unsafe ComponentDataFromEntity(int typeIndex, int typeSize, Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2A05710", Offset = "0x2A04910", VA = "0x182A05710")]
		public bool HasComponent(Entity entity)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class EntityQueryToEntityArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68DC3D0", Offset = "0x68DB5D0", VA = "0x1868DC3D0")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery entityQuery)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68DC2B0", Offset = "0x68DB4B0", VA = "0x1868DC2B0")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class EntityManagerDynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x18FB5D0", Offset = "0x18FA7D0", VA = "0x1818FB5D0")]
		public static bool TryGetBufferRW<T>(this EntityManager entityManager, Entity entity, out DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x18FB330", Offset = "0x18FA530", VA = "0x1818FB330")]
		public static bool TryGetBufferRO<T>(this EntityManager entityManager, Entity entity, out DynamicBuffer<T> buffer) where T : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x18FAEB0", Offset = "0x18FA0B0", VA = "0x1818FAEB0")]
		public static DynamicBuffer<T> GetBufferRO<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x18FB060", Offset = "0x18FA260", VA = "0x1818FB060")]
		public static DynamicBuffer<T> GetBufferRW<T>(this EntityManager entityManager, Entity entity) where T : struct, IBufferElementData
		{
			return default(DynamicBuffer<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class MemoryUtils
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x37FE0E0", Offset = "0x37FD2E0", VA = "0x1837FE0E0")]
		public static Memory<T> Rent<T>(int count)
		{
			return default(Memory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x37FE360", Offset = "0x37FD560", VA = "0x1837FE360")]
		public static void Return<T>(this Memory<T> memory)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class EntityManagerSharedComponentDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x18FB6D0", Offset = "0x18FA8D0", VA = "0x1818FB6D0")]
		public static bool TryGetSharedComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : struct, ISharedComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class DebugEntityInfoExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal static class ChunkIterationUtilityEx
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public readonly struct ChunkFilterComponentChanged : IChunkChangeFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly DynamicComponentTypeHandle handle0;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x68D4A30", Offset = "0x68D3C30", VA = "0x1868D4A30", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public readonly struct ChunkFilterAnyOf2ComponentsChanged : IChunkChangeFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly DynamicComponentTypeHandle handle0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly DynamicComponentTypeHandle handle1;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x15BD640", Offset = "0x15BC840", VA = "0x1815BD640")]
		public ChunkFilterAnyOf2ComponentsChanged(DynamicComponentTypeHandle handle0, DynamicComponentTypeHandle handle1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x68D4740", Offset = "0x68D3940", VA = "0x1868D4740", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct ChunkFilterAnyOf3ComponentsChanged : IChunkChangeFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly DynamicComponentTypeHandle handle0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly DynamicComponentTypeHandle handle1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly DynamicComponentTypeHandle handle2;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xE6A100", Offset = "0xE69300", VA = "0x180E6A100")]
		public ChunkFilterAnyOf3ComponentsChanged(DynamicComponentTypeHandle handle0, DynamicComponentTypeHandle handle1, DynamicComponentTypeHandle handle2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x68D47C0", Offset = "0x68D39C0", VA = "0x1868D47C0", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct ChunkFilterAnyOf4ComponentsChanged : IChunkChangeFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly DynamicComponentTypeHandle handle0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly DynamicComponentTypeHandle handle1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly DynamicComponentTypeHandle handle2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly DynamicComponentTypeHandle handle3;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x68D4860", Offset = "0x68D3A60", VA = "0x1868D4860", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct ChunkFilterAnyOf5ComponentsChanged : IChunkChangeFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly DynamicComponentTypeHandle handle0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly DynamicComponentTypeHandle handle1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly DynamicComponentTypeHandle handle2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly DynamicComponentTypeHandle handle3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly DynamicComponentTypeHandle handle4;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x68D4A00", Offset = "0x68D3C00", VA = "0x1868D4A00")]
		public ChunkFilterAnyOf5ComponentsChanged(DynamicComponentTypeHandle handle0, DynamicComponentTypeHandle handle1, DynamicComponentTypeHandle handle2, DynamicComponentTypeHandle handle3, DynamicComponentTypeHandle handle4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x68D4920", Offset = "0x68D3B20", VA = "0x1868D4920", Slot = "4")]
		public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct NativeMultiHashMapAsync<TKey, TValue> : IDisposable where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly NativeParallelMultiHashMap<TKey, TValue> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1B825A0", Offset = "0x1B817A0", VA = "0x181B825A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x15BD640", Offset = "0x15BC840", VA = "0x1815BD640")]
		public NativeMultiHashMapAsync(NativeParallelMultiHashMap<TKey, TValue> map, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1B824B0", Offset = "0x1B816B0", VA = "0x181B824B0")]
		public NativeParallelMultiHashMap<TKey, TValue> Complete()
		{
			return default(NativeParallelMultiHashMap<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1B824F0", Offset = "0x1B816F0", VA = "0x181B824F0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct NativeArrayAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x1C01FF0", Offset = "0x1C011F0", VA = "0x181C01FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x15BDD70", Offset = "0x15BCF70", VA = "0x1815BDD70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x99B850", Offset = "0x99AA50", VA = "0x18099B850")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NativeArray<T> Array
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xE6A190", Offset = "0xE69390", VA = "0x180E6A190")]
			get
			{
				return default(NativeArray<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x15BD640", Offset = "0x15BC840", VA = "0x1815BD640")]
		public NativeArrayAsync(NativeArray<T> array, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1B824B0", Offset = "0x1B816B0", VA = "0x181B824B0")]
		public NativeArray<T> Complete()
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A260", Offset = "0x2D79460", VA = "0x182D7A260", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0B0", Offset = "0x2D792B0", VA = "0x182D7A0B0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x23726D0", Offset = "0x23718D0", VA = "0x1823726D0")]
		public NativeArrayAsync<TTo> Reinterpret<TTo>() where TTo : struct
		{
			return default(NativeArrayAsync<TTo>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class NativeArrayAsyncExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x26F4810", Offset = "0x26F3A10", VA = "0x1826F4810")]
		public static NativeListAsync<T> AsAsync<T>(this NativeList<T> list, JobHandle handle) where T : struct
		{
			return default(NativeListAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x68DC6F0", Offset = "0x68DB8F0", VA = "0x1868DC6F0")]
		public static JobHandle CombineHandles(this JobHandle a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x26F4860", Offset = "0x26F3A60", VA = "0x1826F4860")]
		public static JobHandle CombineHandles<T>(this JobHandle a, NativeArrayAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x26F4860", Offset = "0x26F3A60", VA = "0x1826F4860")]
		public static JobHandle CombineHandles<T>(this JobHandle a, NativeListAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x26F48B0", Offset = "0x26F3AB0", VA = "0x1826F48B0")]
		public static JobHandle CombineHandles<T>(this NativeListAsync<T> a, NativeListAsync<T> b) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x68DC730", Offset = "0x68DB930", VA = "0x1868DC730")]
		public static JobHandle Combine(this Span<JobHandle> handles)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class EntityManagerChunkExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x68DA1D0", Offset = "0x68D93D0", VA = "0x1868DA1D0")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(this EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, out NativeArray<Entity> srcEntities, out NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.RemapEntityRefs, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x68DA220", Offset = "0x68D9420", VA = "0x1868DA220")]
		public static void HackSetAllChangeVersionsToGlobalSystemVersion(this EntityManager em, Entity entity)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[NativeContainer]
	public struct EntityExistenceLookupByEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly Unity.Entities.EntityDataAccess* m_Access;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0")]
		internal unsafe EntityExistenceLookupByEntity(Unity.Entities.EntityDataAccess* access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x68DA0D0", Offset = "0x68D92D0", VA = "0x1868DA0D0")]
		public bool Exists(Entity entity)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct NativeResultAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly NativeArray<T> array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct NativeListAsync<T> : IDisposable where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly NativeList<T> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IsCreated
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1C01FC0", Offset = "0x1C011C0", VA = "0x181C01FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x1C02070", Offset = "0x1C01270", VA = "0x181C02070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JobHandle Handle
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x99B850", Offset = "0x99AA50", VA = "0x18099B850")]
			get
			{
				return default(JobHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x15BD640", Offset = "0x15BC840", VA = "0x1815BD640")]
		public NativeListAsync(NativeList<T> list, JobHandle handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1C017F0", Offset = "0x1C009F0", VA = "0x181C017F0")]
		public NativeArrayAsync<T> AsDeferredJobArrayAsync()
		{
			return default(NativeArrayAsync<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1B824B0", Offset = "0x1B816B0", VA = "0x181B824B0")]
		public NativeList<T> Complete()
		{
			return default(NativeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1C01D40", Offset = "0x1C00F40", VA = "0x181C01D40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1C01AF0", Offset = "0x1C00CF0", VA = "0x181C01AF0")]
		public JobHandle Dispose(JobHandle jobHandle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class EntityManagerDependencyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x18FAAC0", Offset = "0x18F9CC0", VA = "0x1818FAAC0")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x18FABE0", Offset = "0x18F9DE0", VA = "0x1818FABE0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x68DAAB0", Offset = "0x68D9CB0", VA = "0x1868DAAB0")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x68DABB0", Offset = "0x68D9DB0", VA = "0x1868DABB0")]
		public static JobHandle GetReadWriteDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x68DA990", Offset = "0x68D9B90", VA = "0x1868DA990")]
		public static JobHandle AddReadWriteDependency(this EntityManager entityManager, int typeIndex, JobHandle handle)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct ComponentTypeList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private ComponentTypes32 types;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private List<int> componentTypes;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x68D6AA0", Offset = "0x68D5CA0", VA = "0x1868D6AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IEnumerable<ComponentType> ComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x68D6910", Offset = "0x68D5B10", VA = "0x1868D6910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x68D56D0", Offset = "0x68D48D0", VA = "0x1868D56D0")]
		public int GetTypeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x68D5770", Offset = "0x68D4970", VA = "0x1868D5770")]
		public Type GetType(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x68D5650", Offset = "0x68D4850", VA = "0x1868D5650")]
		public ComponentType GetComponentType(int index)
		{
			return default(ComponentType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x68D6810", Offset = "0x68D5A10", VA = "0x1868D6810")]
		public ComponentTypeList(ComponentTypeList a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x68D6700", Offset = "0x68D5900", VA = "0x1868D6700")]
		public ComponentTypeList(ComponentType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x68D65D0", Offset = "0x68D57D0", VA = "0x1868D65D0")]
		public ComponentTypeList(ComponentType a, ComponentType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x68D5D30", Offset = "0x68D4F30", VA = "0x1868D5D30")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x68D5C50", Offset = "0x68D4E50", VA = "0x1868D5C50")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x68D5B60", Offset = "0x68D4D60", VA = "0x1868D5B60")]
		public ComponentTypeList(ComponentType a, ComponentType b, ComponentType c, ComponentType d, ComponentType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x68D61B0", Offset = "0x68D53B0", VA = "0x1868D61B0")]
		public ComponentTypeList(params ComponentType[] componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x68D5E00", Offset = "0x68D5000", VA = "0x1868D5E00")]
		public ComponentTypeList(IEnumerable<ComponentType> componentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x68D4CF0", Offset = "0x68D3EF0", VA = "0x1868D4CF0")]
		public void AddUnsorted(ComponentType componentType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x68D57E0", Offset = "0x68D49E0", VA = "0x1868D57E0")]
		public void Sort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x68D4FB0", Offset = "0x68D41B0", VA = "0x1868D4FB0")]
		public static ComponentTypeList Add(in ComponentTypeList a, in ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x68D5860", Offset = "0x68D4A60", VA = "0x1868D5860")]
		public static ComponentTypeList Subtract(in ComponentTypeList a, in ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x68D54D0", Offset = "0x68D46D0", VA = "0x1868D54D0")]
		public static ComponentTypeList Add(in ComponentTypeList src, params ComponentType[] additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x68D53B0", Offset = "0x68D45B0", VA = "0x1868D53B0")]
		public static ComponentTypeList Add(in ComponentTypeList src, IEnumerable<ComponentType> additional)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x68D6B00", Offset = "0x68D5D00", VA = "0x1868D6B00")]
		public static ComponentTypeList operator +(ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x68D6B90", Offset = "0x68D5D90", VA = "0x1868D6B90")]
		public static ComponentTypeList operator -(ComponentTypeList a, ComponentTypeList b)
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x68D5A00", Offset = "0x68D4C00", VA = "0x1868D5A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class ComponentTypeListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1CBC9E0", Offset = "0x1CBBBE0", VA = "0x181CBC9E0")]
		public static ComponentTypeList With<T>(this ComponentTypeList src)
		{
			return default(ComponentTypeList);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class ArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x68D45C0", Offset = "0x68D37C0", VA = "0x1868D45C0")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class SpanUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4A6D0A0", Offset = "0x4A6C2A0", VA = "0x184A6D0A0")]
		public static Span<T> AsSpan<T>(this NativeArray<T> array) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4A6CF40", Offset = "0x4A6C140", VA = "0x184A6CF40")]
		public static Span<T> AsSpan<T>(this NativeList<T> list) where T : struct
		{
			return default(Span<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ComponentTypeEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private EntityArchetype archetype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public ComponentType Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D7")]
				[Cpp2IlInjected.Address(RVA = "0x68D4C70", Offset = "0x68D3E70", VA = "0x1868D4C70")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0x45FDA80", Offset = "0x45FCC80", VA = "0x1845FDA80")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public ComponentType this[int i]
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x68D4CB0", Offset = "0x68D3EB0", VA = "0x1868D4CB0")]
				get
				{
					return default(ComponentType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x68D4C50", Offset = "0x68D3E50", VA = "0x1868D4C50")]
			internal ComponentTypeEnumerator(EntityArchetype arch, bool includeEntity = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x15BDAC0", Offset = "0x15BCCC0", VA = "0x1815BDAC0")]
			public ComponentTypeEnumerator GetEnumerator()
			{
				return default(ComponentTypeEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x68D4C20", Offset = "0x68D3E20", VA = "0x1868D4C20")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct AddEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private AddRemoveEnumerator enumerator;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public struct RemoveEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private AddRemoveEnumerator enumerator;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct AddRemoveEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private unsafe Unity.Entities.ComponentTypeInArchetype* srcTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private unsafe Unity.Entities.ComponentTypeInArchetype* dstTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private int srcLen;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private int dstLen;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private ComponentType componentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private bool add;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public (ComponentType component, bool add) Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x68D4560", Offset = "0x68D3760", VA = "0x1868D4560")]
				get
				{
					return default((ComponentType, bool));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x68D4510", Offset = "0x68D3710", VA = "0x1868D4510")]
			internal unsafe AddRemoveEnumerator(Unity.Entities.Archetype* src, Unity.Entities.Archetype* dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x15BDB90", Offset = "0x15BCD90", VA = "0x1815BDB90")]
			public AddRemoveEnumerator GetEnumerator()
			{
				return default(AddRemoveEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x68D43F0", Offset = "0x68D35F0", VA = "0x1868D43F0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x68DA0A0", Offset = "0x68D92A0", VA = "0x1868DA0A0")]
		public static EntityArchetype GetInstantiateArchetype(this EntityArchetype archetype)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x68D9F40", Offset = "0x68D9140", VA = "0x1868D9F40")]
		public static ComponentTypeEnumerator EnumerateComponentTypes(this EntityArchetype archetype, bool includeEntity = false)
		{
			return default(ComponentTypeEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x68D9F80", Offset = "0x68D9180", VA = "0x1868D9F80")]
		public static Span<int> GetAllTypeIndices(this EntityArchetype archetype)
		{
			return default(Span<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x68DA080", Offset = "0x68D9280", VA = "0x1868DA080")]
		public static int GetEntityCount(this EntityArchetype archetype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x68DA020", Offset = "0x68D9220", VA = "0x1868DA020")]
		public static AddRemoveEnumerator GetComponentDifferences(this EntityArchetype src, EntityArchetype dst)
		{
			return default(AddRemoveEnumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class ChunkChangeFilterExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x223CCC0", Offset = "0x223BEC0", VA = "0x18223CCC0")]
		public static ChunkFilterAnyOf2ComponentsChanged ChunkFilterAnyChanged<T1, T2>(this EntityManager entityManager)
		{
			return default(ChunkFilterAnyOf2ComponentsChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x223CBC0", Offset = "0x223BDC0", VA = "0x18223CBC0")]
		public static ChunkFilterAnyOf3ComponentsChanged ChunkFilterAnyChanged<T1, T2, T3>(this EntityManager entityManager)
		{
			return default(ChunkFilterAnyOf3ComponentsChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x223CD70", Offset = "0x223BF70", VA = "0x18223CD70")]
		public static ChunkFilterAnyOf5ComponentsChanged ChunkFilterAnyChanged<T1, T2, T3, T4, T5>(this EntityManager entityManager)
		{
			return default(ChunkFilterAnyOf5ComponentsChanged);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x223CA80", Offset = "0x223BC80", VA = "0x18223CA80")]
		public static int CalculateEntityCount<T>(this EntityQuery query, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x223CF10", Offset = "0x223C110", VA = "0x18223CF10")]
		public static bool IsEmpty<T>(this EntityQuery query, T chunkChangeFilter, out int count) where T : struct, IChunkChangeFilter
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x223CF60", Offset = "0x223C160", VA = "0x18223CF60")]
		public static bool IsEmpty<T>(this EntityQueryInJob query, T chunkChangeFilter, out int count) where T : struct, IChunkChangeFilter
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class EntityManagerComponentOrderExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class EntityManagerAssertionExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class DynamicBufferExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xF0DED0", Offset = "0xF0D0D0", VA = "0x180F0DED0")]
		public static int IndexOf<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xF0E1B0", Offset = "0xF0D3B0", VA = "0x180F0E1B0")]
		public static bool RemoveSwapBack<T>(this DynamicBuffer<T> buffer, T value) where T : struct, IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xF0E110", Offset = "0xF0D310", VA = "0x180F0E110")]
		public static int IndexOf<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xF0E270", Offset = "0xF0D470", VA = "0x180F0E270")]
		public static bool Remove<T, T2>(this DynamicBuffer<T> buffer, T value, T2 equalityComparer) where T : struct where T2 : struct, IEqualityComparer<T>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class EntityManagerComponentObjectExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x18FA9B0", Offset = "0x18F9BB0", VA = "0x1818FA9B0")]
		public static void SetComponentObject<T>(this EntityManager entityManager, Entity entity, T componentObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x18FAA00", Offset = "0x18F9C00", VA = "0x1818FAA00")]
		public static bool TryGetComponentObject<T>(this EntityManager entityManager, Entity entity, out T component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x18FA950", Offset = "0x18F9B50", VA = "0x1818FA950")]
		public static void AddAndSetComponentObject<T>(this EntityManager entityManager, Entity entity, T value) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class JobChunkExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[BurstCompatible]
	public struct EntityQueryInJob
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal struct NoFilter : IChunkChangeFilter
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "4")]
			public bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe Unity.Entities.EntityQueryImpl* __impl;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool IsEmptyIgnoreFilter
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3E6B5A0", Offset = "0x3E6A7A0", VA = "0x183E6B5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x68DBC40", Offset = "0x68DAE40", VA = "0x1868DBC40")]
		public static implicit operator EntityQueryInJob(EntityQuery query)
		{
			return default(EntityQueryInJob);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x68DBCE0", Offset = "0x68DAEE0", VA = "0x1868DBCE0")]
		public EntityQueryInJob(EntityQuery query)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3E6AFE0", Offset = "0x3E6A1E0", VA = "0x183E6AFE0")]
		public int CalculateEntityCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x26C5CC0", Offset = "0x26C4EC0", VA = "0x1826C5CC0")]
		public int CalculateEntityCount<T>(T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3E6B310", Offset = "0x3E6A510", VA = "0x183E6B310")]
		public ArchetypeChunkIterator GetArchetypeChunkIterator()
		{
			return default(ArchetypeChunkIterator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x68DBC60", Offset = "0x68DAE60", VA = "0x1868DBC60")]
		[BurstCompatible]
		public NativeArray<Entity> ToEntityArray(EntityTypeHandle entityType, Allocator allocator = Allocator.Temp)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x26C8610", Offset = "0x26C7810", VA = "0x1826C8610")]
		[BurstCompatible]
		public NativeArray<Entity> ToEntityArray<T>(EntityTypeHandle entityType, T chunkChangeFilter, Allocator allocator = Allocator.Temp) where T : struct, IChunkChangeFilter
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x26C6340", Offset = "0x26C5540", VA = "0x1826C6340")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T>(ComponentTypeHandle<T> componentType, Allocator allocator = Allocator.Temp) where T : struct, IComponentData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x26C6080", Offset = "0x26C5280", VA = "0x1826C6080")]
		[BurstCompatible]
		public NativeArray<T> ToComponentDataArray<T, T2>(ComponentTypeHandle<T> componentType, T2 chunkChangeFilter, Allocator allocator = Allocator.Temp) where T : struct, IComponentData where T2 : struct, IChunkChangeFilter
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1646B90", Offset = "0x1645D90", VA = "0x181646B90")]
		internal unsafe Unity.Entities.EntityQueryImpl* _GetImpl()
		{
			//IL_0002: Expected I, but got O
			return (Unity.Entities.EntityQueryImpl*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x26C9BB0", Offset = "0x26C8DB0", VA = "0x1826C9BB0")]
		private unsafe static void _GatherEntities<T>(Entity* entities, ref EntityTypeHandle entityTypeHandle, in Unity.Entities.UnsafeCachedChunkList cache, uint requiredChangeVersion, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x26C94F0", Offset = "0x26C86F0", VA = "0x1826C94F0")]
		private unsafe static void _GatherEntitiesWithFilter<T>(Entity* entities, ref Unity.Entities.EntityQueryFilter filter, ref Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, ref EntityTypeHandle entityTypeHandle, in Unity.Entities.UnsafeCachedChunkList cache, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x26C9110", Offset = "0x26C8310", VA = "0x1826C9110")]
		private unsafe static void _GatherComponentData<T>(byte* componentData, int typeIndex, in Unity.Entities.UnsafeCachedChunkList cache, uint requiredChangeVersion, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x26C8BF0", Offset = "0x26C7DF0", VA = "0x1826C8BF0")]
		private unsafe static void _GatherComponentDataWithFilter<T>(byte* componentData, int typeIndex, in Unity.Entities.UnsafeCachedChunkList cache, in Unity.Entities.UnsafeMatchingArchetypePtrList matchingArchetypePtrList, ref Unity.Entities.EntityQueryFilter filter, T chunkChangeFilter) where T : struct, IChunkChangeFilter
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class EntityQueryInJobExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x68DBC40", Offset = "0x68DAE40", VA = "0x1868DBC40")]
		public static EntityQueryInJob UseInJob(this EntityQuery query)
		{
			return default(EntityQueryInJob);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class ComponentSystemBaseExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class ArchetypeChunkExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public interface IChunkChangeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DidChange(ArchetypeChunk archetypeChunk, uint lastSystemVersion);
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[Flags]
	public enum CopyFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		NativeComponents = 0,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ManagedComponents = 1,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		BufferComponents = 2,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		RemapEntityRefs = 3,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		All = 3
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct CopyEntitiesUtility
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[BurstCompile]
		private struct AddRemappingJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[ReadOnly]
			public NativeArray<Entity> dstEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x68D4390", Offset = "0x68D3590", VA = "0x1868D4390", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		private struct RemapChunksFilteredJob : IJobParallelForBurstSchedulable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[ReadOnly]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[NativeDisableUnsafePtrRestriction]
			public unsafe Unity.Entities.EntityComponentStore* dstEntityComponentStore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public int chunkHeaderType;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x68DCBD0", Offset = "0x68DBDD0", VA = "0x1868DCBD0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x68D89B0", Offset = "0x68D7BB0", VA = "0x1868D89B0")]
		[NotBurstCompatible]
		public static void CopyEntitiesFrom(EntityManager dstEntityManager, EntityManager srcEntityManager, EntityQuery srcQuery, out NativeArray<Entity> srcEntities, out NativeArray<Entity> dstEntities, CopyFlags copyFlags = CopyFlags.RemapEntityRefs, Allocator allocator = Allocator.TempJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x68D9CA0", Offset = "0x68D8EA0", VA = "0x1868D9CA0")]
		private static NativeArray<ArchetypeChunk> GetChunksFromEntities(NativeArray<Entity> entities, EntityManager srcEntityManager)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x68D94C0", Offset = "0x68D86C0", VA = "0x1868D94C0")]
		private unsafe static NativeArray<ArchetypeChunk> CopyEntitiesInternal(NativeArray<ArchetypeChunk> srcChunks, Unity.Entities.EntityDataAccess* srcAccess, CopyFlags copyFlags)
		{
			return default(NativeArray<ArchetypeChunk>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x68D9D90", Offset = "0x68D8F90", VA = "0x1868D9D90")]
		private unsafe static void RemapEntityRefs(NativeArray<ArchetypeChunk> chunks, NativeArray<Entity> srcEntities, NativeArray<Entity> dstEntities, NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping, Unity.Entities.EntityDataAccess* srcAccess, CopyFlags copyFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3ABF980", Offset = "0x3ABEB80", VA = "0x183ABF980")]
		private static bool HasFlag(CopyFlags copyFlags, CopyFlags testFlag)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x68D9A50", Offset = "0x68D8C50", VA = "0x1868D9A50")]
		private unsafe static void CreateChunks(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x68D9950", Offset = "0x68D8B50", VA = "0x1868D9950")]
		private unsafe static void CopyNames(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks, Unity.Entities.EntityComponentStore* srcECS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x68D86A0", Offset = "0x68D78A0", VA = "0x1868D86A0")]
		private static void CloneNativeComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x68D8750", Offset = "0x68D7950", VA = "0x1868D8750")]
		public unsafe static void CloneNativeComponents(in Unity.Entities.EntityBatchInChunk srcBatch, Unity.Entities.Chunk* dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x68D79B0", Offset = "0x68D6BB0", VA = "0x1868D79B0")]
		private static void ClearBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x68D7C60", Offset = "0x68D6E60", VA = "0x1868D7C60")]
		private static void ClearBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x68D8250", Offset = "0x68D7450", VA = "0x1868D8250")]
		private static void CloneBufferComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x68D7FC0", Offset = "0x68D71C0", VA = "0x1868D7FC0")]
		private static void CloneBufferComponents(ArchetypeChunk srcChunk, ArchetypeChunk dstChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x68D7E60", Offset = "0x68D7060", VA = "0x1868D7E60")]
		private static void ClearManagedComponents(NativeArray<ArchetypeChunk> chunks, uint globalSystemVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x68D8590", Offset = "0x68D7790", VA = "0x1868D8590")]
		private static void CloneManagedComponents(NativeArray<ArchetypeChunk> srcChunks, NativeArray<ArchetypeChunk> dstChunks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x68D9B50", Offset = "0x68D8D50", VA = "0x1868D9B50")]
		private static NativeArray<Entity> CreateEntityArray(NativeArray<ArchetypeChunk> chunks, Allocator allocator, int entityCount)
		{
			return default(NativeArray<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public interface IUTF8BufferElementData : IBufferElementData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[BurstCompile]
	public struct RemapEntitiesInPlaceJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x68DCDF0", Offset = "0x68DBFF0", VA = "0x1868DCDF0", Slot = "4")]
		public void Execute()
		{
		}
	}
}
namespace Unity.Entities.Scene
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class EntityQuerySceneExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public struct QueryResetFilterScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private EntityQuery query;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private static bool isInScope;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x68DCB80", Offset = "0x68DBD80", VA = "0x1868DCB80")]
			public QueryResetFilterScope(EntityQuery query)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x68DCB30", Offset = "0x68DBD30", VA = "0x1868DCB30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x68DBF00", Offset = "0x68DB100", VA = "0x1868DBF00")]
		public static NativeArrayAsync<Entity> ToEntityArrayAsync(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x68DC150", Offset = "0x68DB350", VA = "0x1868DC150")]
		public static NativeArray<Entity> ToEntityArray(this EntityQuery query, SceneTag scene, Allocator allocator = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x68DBE40", Offset = "0x68DB040", VA = "0x1868DBE40")]
		public static QueryResetFilterScope FilterToScene(this EntityQuery query, SceneTag scene)
		{
			return default(QueryResetFilterScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x68DBD00", Offset = "0x68DAF00", VA = "0x1868DBD00")]
		public static int CalculateEntityCount(this EntityQuery query, SceneTag scene)
		{
			return default(int);
		}
	}
}
namespace Unity.Entities.LinkedEntityGroupExtensions
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class EntityManagerLinkedEntityGroupExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x68DAF50", Offset = "0x68DA150", VA = "0x1868DAF50")]
		public static bool TryGetChildEntitySubArrayRO(this in EntityManager entityManager, Entity parentEntity, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x68DB190", Offset = "0x68DA390", VA = "0x1868DB190")]
		public static bool TryGetChildEntitySubArray(this in BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x68DB060", Offset = "0x68DA260", VA = "0x1868DB060")]
		public static bool TryGetChildEntitySubArray(this in DynamicBuffer<LinkedEntityGroup> buffer, out NativeArray<Entity> childEntitySubArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x68DAE20", Offset = "0x68DA020", VA = "0x1868DAE20")]
		public static NativeArray<Entity> GetChildEntitySubArray(this EntityManager entityManager, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x68DACE0", Offset = "0x68D9EE0", VA = "0x1868DACE0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this BufferFromEntity<LinkedEntityGroup> bufferFromEntity, Entity parentEntity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x68DADE0", Offset = "0x68D9FE0", VA = "0x1868DADE0")]
		public static NativeArray<Entity> GetChildEntitySubArray(this DynamicBuffer<LinkedEntityGroup> buffer)
		{
			return default(NativeArray<Entity>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1222723937
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x68DD0F0", Offset = "0x68DC2F0", VA = "0x1868DD0F0")]
	public static void PLBHNCBKHNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x68DD0E0", Offset = "0x68DC2E0", VA = "0x1868DD0E0")]
	[RuntimeInitializeOnLoadMethod]
	public static void EarlyInit()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MDBJHPDEIOP
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public MDBJHPDEIOP()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
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

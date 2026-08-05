using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.Toolkit.HighPerformance.Helpers;
using Mono.Math;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	internal static class ArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5A54660", Offset = "0x5A53460", VA = "0x185A54660")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5A55210", Offset = "0x5A54010", VA = "0x185A55210")]
		public static Span<int> GetTypeIndices(this EntityArchetype archetype)
		{
			return default(Span<int>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class DebugEntityInfoExtensions
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5A55280", Offset = "0x5A54080", VA = "0x185A55280")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class EntityManagerExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[BurstCompile]
		private struct SetComponentDataArrayJob<T> : IJob where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[ReadOnly]
			public NativeArray<Entity> srcEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			[WriteOnly]
			public ComponentDataFromEntity<T> dstArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x31CEC90", Offset = "0x31CDA90", VA = "0x1831CEC90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[BurstCompile]
		private struct SetComponentDataChunkJob<T> : IJobChunk where T : struct, IComponentData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			[WriteOnly]
			public ArchetypeChunkComponentType<T> componentArrayType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public T value;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2683290", Offset = "0x2682090", VA = "0x182683290")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2682AC0", Offset = "0x26818C0", VA = "0x182682AC0")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2682BC0", Offset = "0x26819C0", VA = "0x182682BC0")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2682FC0", Offset = "0x2681DC0", VA = "0x182682FC0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5A552A0", Offset = "0x5A540A0", VA = "0x185A552A0")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EDKCCAGKFAP<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DIHJIIMLCBE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::EDKCCAGKFAP<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x779B20", Offset = "0x778920", VA = "0x180779B20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2B10120", Offset = "0x2B0EF20", VA = "0x182B10120", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2300E10", Offset = "0x22FFC10", VA = "0x182300E10")]
		[DebuggerHidden]
		public DIHJIIMLCBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FF40", Offset = "0x2B0ED40", VA = "0x182B0FF40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B100E0", Offset = "0x2B0EEE0", VA = "0x182B100E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> PEEJMLAIOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream IFCPBBBMBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream DFICNDIFCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf NLKKDDCCJJH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int DAPOBDBACPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F68E0", Offset = "0x6F56E0", VA = "0x1806F68E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x33B2110", Offset = "0x33B0F10", VA = "0x1833B2110")]
	private EDKCCAGKFAP(byte[] IHLLHGOCNMO, Action<Protobuf> PEEJMLAIOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x26419E0", Offset = "0x26407E0", VA = "0x1826419E0")]
	public static global::EDKCCAGKFAP<Protobuf> FBMANFCLCAO<Data>(ReadOnlySpan<byte> HDHLDBBIAKI, ReadOnlySpan<Data> ICBAFEALNLG, Action<Protobuf> PEEJMLAIOHK)
	{
		return default(global::EDKCCAGKFAP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x33B1F80", Offset = "0x33B0D80", VA = "0x1833B1F80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x33B1FC0", Offset = "0x33B0DC0", VA = "0x1833B1FC0", Slot = "4")]
	[IteratorStateMachine(typeof(global::EDKCCAGKFAP<>.DIHJIIMLCBE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x33B20C0", Offset = "0x33B0EC0", VA = "0x1833B20C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EILIHCCELHA<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] IHLLHGOCNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf NLKKDDCCJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream IFCPBBBMBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream LKIJIAKBBNC;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x35123C0", Offset = "0x35111C0", VA = "0x1835123C0")]
	private EILIHCCELHA(byte[] IHLLHGOCNMO, in Protobuf NLKKDDCCJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x45CFCA0", Offset = "0x45CEAA0", VA = "0x1845CFCA0")]
	public static global::EILIHCCELHA<Protobuf> FBMANFCLCAO<T>(ReadOnlySpan<T> ICBAFEALNLG)
	{
		return default(global::EILIHCCELHA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x35121D0", Offset = "0x3510FD0", VA = "0x1835121D0")]
	public void BJELIJENBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3512330", Offset = "0x3511130", VA = "0x183512330")]
	public ByteString PDLFMIBHNAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3512200", Offset = "0x3511000", VA = "0x183512200", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct KCDAOEKLEIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream IFCPBBBMBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream DFICNDIFCNH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5A56980", Offset = "0x5A55780", VA = "0x185A56980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BNFHBEFOKIH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] IHLLHGOCNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream IFCPBBBMBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream LKIJIAKBBNC;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5A549E0", Offset = "0x5A537E0", VA = "0x185A549E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IBGDABKHOAG
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	public static void FNANIKMCBIP(this JFPIEAPAMJM MCHCOEKKPGN, NativeArray<Entity> NMONLDLIICI, [Optional][CallerFilePath] string KHKDDCNNLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	public static void FNANIKMCBIP(this JFPIEAPAMJM MCHCOEKKPGN, string EOPECGOILOC, NativeArray<Entity> NMONLDLIICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	public static void FNANIKMCBIP(this JFPIEAPAMJM MCHCOEKKPGN, string KHKDDCNNLHK, NativeArray<Entity> NMONLDLIICI, bool NPAKBFKDFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	public static void HLHINKGGFBH(this JFPIEAPAMJM MCHCOEKKPGN, NativeArray<Entity> NMONLDLIICI, NativeArray<Entity> DMDBPDDAOHM, [Optional][CallerFilePath] string KHKDDCNNLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	public static void HLHINKGGFBH(this JFPIEAPAMJM MCHCOEKKPGN, string KHKDDCNNLHK, NativeArray<Entity> NMONLDLIICI, NativeArray<Entity> DMDBPDDAOHM, bool NPAKBFKDFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x270B2B0", Offset = "0x270A0B0", VA = "0x18270B2B0")]
	public static void OKCOFNDEIMF<T>(this JFPIEAPAMJM MCHCOEKKPGN, string EOPECGOILOC, NativeArray<Entity> NMONLDLIICI, NativeList<T> PHAPMEHMHAK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x270B340", Offset = "0x270A140", VA = "0x18270B340")]
	public static void OKCOFNDEIMF<T>(this JFPIEAPAMJM MCHCOEKKPGN, string EOPECGOILOC, NativeArray<Entity> NMONLDLIICI, NativeArray<T> PHAPMEHMHAK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	public static void OKCOFNDEIMF<T>(this JFPIEAPAMJM MCHCOEKKPGN, string KHKDDCNNLHK, NativeArray<Entity> NMONLDLIICI, NativeArray<T> PHAPMEHMHAK, bool NPAKBFKDFCJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x270B1E0", Offset = "0x2709FE0", VA = "0x18270B1E0")]
	public static void IFHJNKKJGGO<T>(this JFPIEAPAMJM MCHCOEKKPGN, NativeList<T> PHAPMEHMHAK, [Optional][CallerFilePath] string KHKDDCNNLHK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x270B250", Offset = "0x270A050", VA = "0x18270B250")]
	public static void IFHJNKKJGGO<T>(this JFPIEAPAMJM MCHCOEKKPGN, NativeArray<T> PHAPMEHMHAK, [Optional][CallerFilePath] string KHKDDCNNLHK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	public static void IFHJNKKJGGO<T>(this JFPIEAPAMJM MCHCOEKKPGN, string KHKDDCNNLHK, NativeArray<T> PHAPMEHMHAK, bool NPAKBFKDFCJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	public static void ALIBFEJCGAI(this JFPIEAPAMJM MCHCOEKKPGN, EntityQuery KFFFLMFFADE, [Optional][CallerFilePath] string KHKDDCNNLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	public static void ALIBFEJCGAI(this JFPIEAPAMJM MCHCOEKKPGN, string EOPECGOILOC, EntityQuery KFFFLMFFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	public static void ALIBFEJCGAI(this JFPIEAPAMJM MCHCOEKKPGN, string KHKDDCNNLHK, EntityQuery KFFFLMFFADE, bool NPAKBFKDFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x270B280", Offset = "0x270A080", VA = "0x18270B280")]
	public static void LKBAMCOINEP<T, T2>(this JFPIEAPAMJM MCHCOEKKPGN, string EOPECGOILOC, EntityQuery KFFFLMFFADE) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	private static void LKBAMCOINEP<T, T2>(this JFPIEAPAMJM MCHCOEKKPGN, string KHKDDCNNLHK, EntityQuery KFFFLMFFADE, bool NPAKBFKDFCJ) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GLIHFOOKOJB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	DBABCCFIPAO OAHDEFOEFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BGOPFALLDEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KPBEHAGEHOF(Entity JCNIDEIPPBD, object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ONOKPBPBOFP(Entity JCNIDEIPPBD, object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LLIGIPPHBHC(Entity JCNIDEIPPBD);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LLIGIPPHBHC(DBABCCFIPAO EFHAIHKDJDK);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> LJBFOCIBHCD(Entity JCNIDEIPPBD);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AMKNNKFJHBG(Entity JCNIDEIPPBD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AHICODAJBCD<TComponentData, TValue> : global::CGDDICCPEIB<TValue>, IDisposable where TComponentData : struct, GLIHFOOKOJB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class EAAGGIJMCBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> LLMBPPCBLOM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int OAHKGMMAIIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x2642890", Offset = "0x2641690", VA = "0x182642890")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x33A4F70", Offset = "0x33A3D70", VA = "0x1833A4F70")]
		public bool MGHBPAEOPAL(out TValue NLHFEJHKLAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x33A4D90", Offset = "0x33A3B90", VA = "0x1833A4D90")]
		public void AHKNMMEAEHA(object INDCJAMMAIN, TValue NLHFEJHKLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x33A4EF0", Offset = "0x33A3CF0", VA = "0x1833A4EF0")]
		public bool IHKCCNMHHEB(object INDCJAMMAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x33A4E40", Offset = "0x33A3C40", VA = "0x1833A4E40")]
		public int EAKNCNMGFIF(object INDCJAMMAIN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x33A5030", Offset = "0x33A3E30", VA = "0x1833A5030")]
		public EAAGGIJMCBD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<EAAGGIJMCBD> LACFGPFMJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::OBLKPMNJCIK<DBABCCFIPAO, EAAGGIJMCBD> DKOOCJMAFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager OFPCNLPKKAK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2C33300", Offset = "0x2C32100", VA = "0x182C33300")]
	public AHICODAJBCD(EntityManager OFPCNLPKKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2C32FA0", Offset = "0x2C31DA0", VA = "0x182C32FA0", Slot = "4")]
	public void KPBEHAGEHOF(Entity JCNIDEIPPBD, object INDCJAMMAIN, TValue NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2C33190", Offset = "0x2C31F90", VA = "0x182C33190", Slot = "5")]
	public bool ONOKPBPBOFP(Entity JCNIDEIPPBD, object INDCJAMMAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2C330C0", Offset = "0x2C31EC0", VA = "0x182C330C0", Slot = "6")]
	public bool MGHBPAEOPAL(Entity JCNIDEIPPBD, out TValue NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2C32D60", Offset = "0x2C31B60", VA = "0x182C32D60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2C32CE0", Offset = "0x2C31AE0", VA = "0x182C32CE0")]
	private void CHFCOMAMJAC(EAAGGIJMCBD OGCHCFJBKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2C32E60", Offset = "0x2C31C60", VA = "0x182C32E60")]
	private bool FJDOCKNKJOO(Entity JCNIDEIPPBD, out DBABCCFIPAO EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2C32F10", Offset = "0x2C31D10", VA = "0x182C32F10")]
	private void GKMMDCIDOGP(Entity JCNIDEIPPBD, DBABCCFIPAO EFHAIHKDJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C32E40", Offset = "0x2C31C40", VA = "0x182C32E40")]
	private bool EGMJNPBAAED(DBABCCFIPAO EFHAIHKDJDK, out EAAGGIJMCBD OGCHCFJBKMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2C32D80", Offset = "0x2C31B80", VA = "0x182C32D80")]
	private EAAGGIJMCBD EDEGAFBAIGM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CGDDICCPEIB<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPBEHAGEHOF(Entity JCNIDEIPPBD, object INDCJAMMAIN, TValue NLHFEJHKLAH);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ONOKPBPBOFP(Entity JCNIDEIPPBD, object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MGHBPAEOPAL(Entity JCNIDEIPPBD, out TValue NLHFEJHKLAH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DBABCCFIPAO : global::IODKAPMFEOL<DBABCCFIPAO>, MNGNANHHIDL, IEquatable<DBABCCFIPAO>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly DBABCCFIPAO PEBOJACILFM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int HGGIJKLHICO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x73D530", Offset = "0x73C330", VA = "0x18073D530", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int LFENOMEJLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x795660", Offset = "0x794460", VA = "0x180795660", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x795670", Offset = "0x794470", VA = "0x180795670", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5A550A0", Offset = "0x5A53EA0", VA = "0x185A550A0", Slot = "8")]
	public bool Equals(DBABCCFIPAO ONICAEEHHFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5A550F0", Offset = "0x5A53EF0", VA = "0x185A550F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FEMGHOFDHBI<T> : BGOPFALLDEO, IDisposable where T : struct, GLIHFOOKOJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> LACFGPFMJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::OBLKPMNJCIK<DBABCCFIPAO, HashSet<object>> DKOOCJMAFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager OFPCNLPKKAK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x37BA8C0", Offset = "0x37B96C0", VA = "0x1837BA8C0")]
	public FEMGHOFDHBI(EntityManager OFPCNLPKKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x37B8C00", Offset = "0x37B7A00", VA = "0x1837B8C00", Slot = "4")]
	public bool KPBEHAGEHOF(Entity JCNIDEIPPBD, object INDCJAMMAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x37BA180", Offset = "0x37B8F80", VA = "0x1837BA180", Slot = "5")]
	public bool ONOKPBPBOFP(Entity JCNIDEIPPBD, object INDCJAMMAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x37B97E0", Offset = "0x37B85E0", VA = "0x1837B97E0", Slot = "6")]
	public bool LLIGIPPHBHC(Entity JCNIDEIPPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x37B9A40", Offset = "0x37B8840", VA = "0x1837B9A40", Slot = "7")]
	public bool LLIGIPPHBHC(DBABCCFIPAO EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x37B9520", Offset = "0x37B8320", VA = "0x1837B9520", Slot = "8")]
	public IEnumerable<object> LJBFOCIBHCD(Entity JCNIDEIPPBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x37B9260", Offset = "0x37B8060", VA = "0x1837B9260", Slot = "11")]
	public IEnumerable<object> LJBFOCIBHCD(DBABCCFIPAO EFHAIHKDJDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x37B7A60", Offset = "0x37B6860", VA = "0x1837B7A60", Slot = "9")]
	public bool AMKNNKFJHBG(Entity JCNIDEIPPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x37B8050", Offset = "0x37B6E50", VA = "0x1837B8050", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x37B7FE0", Offset = "0x37B6DE0", VA = "0x1837B7FE0")]
	private void CHFCOMAMJAC(HashSet<object> OGCHCFJBKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x37B8750", Offset = "0x37B7550", VA = "0x1837B8750")]
	private bool FJDOCKNKJOO(Entity JCNIDEIPPBD, out DBABCCFIPAO EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x37B9F40", Offset = "0x37B8D40", VA = "0x1837B9F40")]
	private bool NJPOEKEPDOE(Entity JCNIDEIPPBD, out DBABCCFIPAO EFHAIHKDJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x37B8190", Offset = "0x37B6F90", VA = "0x1837B8190")]
	private void EBDCMLAMKMA(Entity JCNIDEIPPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x37B8A30", Offset = "0x37B7830", VA = "0x1837B8A30")]
	private void GKMMDCIDOGP(Entity JCNIDEIPPBD, DBABCCFIPAO EFHAIHKDJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x37B7910", Offset = "0x37B6710", VA = "0x1837B7910")]
	private bool AJPBINPEODK(DBABCCFIPAO EFHAIHKDJDK, out HashSet<object> OGCHCFJBKMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x37B8430", Offset = "0x37B7230", VA = "0x1837B8430")]
	private HashSet<object> EDEGAFBAIGM()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BAFPEMGKEOM : global::NCLHHJLAOIH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5A547B0", Offset = "0x5A535B0", VA = "0x185A547B0", Slot = "4")]
	public float IHANJPMKCOB(float3 NLHFEJHKLAH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EIKEKHKHFKG : global::NCLHHJLAOIH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5A55140", Offset = "0x5A53F40", VA = "0x185A55140", Slot = "4")]
	public float IHANJPMKCOB(float3 NLHFEJHKLAH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct ILKNBGDNEPL : global::NCLHHJLAOIH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5A56890", Offset = "0x5A55690", VA = "0x185A56890", Slot = "4")]
	public float IHANJPMKCOB(float3 NLHFEJHKLAH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct DIPEGICNMJK : global::NCLHHJLAOIH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xB612B0", Offset = "0xB600B0", VA = "0x180B612B0", Slot = "4")]
	public int IHANJPMKCOB(int3 NLHFEJHKLAH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JFGFMBEECGK : global::NCLHHJLAOIH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x46C2EE0", Offset = "0x46C1CE0", VA = "0x1846C2EE0", Slot = "4")]
	public int IHANJPMKCOB(int3 NLHFEJHKLAH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct PPIGFKKIMPJ : global::NCLHHJLAOIH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5A595E0", Offset = "0x5A583E0", VA = "0x185A595E0", Slot = "4")]
	public int IHANJPMKCOB(int3 NLHFEJHKLAH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class PDMAPGNPMOE : MFBBOOODODO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type JDJHIKHIAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5A55580", Offset = "0x5A54380", VA = "0x185A55580")]
	public PDMAPGNPMOE(Type NNDIDJLAJFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GAJBPDLFFFM : PDMAPGNPMOE
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5A55580", Offset = "0x5A54380", VA = "0x185A55580")]
	public GAJBPDLFFFM(Type NNDIDJLAJFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JONDABLNINO : PDMAPGNPMOE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type OKDMACHOCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x701A00", Offset = "0x700800", VA = "0x180701A00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5A56930", Offset = "0x5A55730", VA = "0x185A56930")]
	public JONDABLNINO(Type KKBOPNHNIIH, Type NNDIDJLAJFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GFOMBCHLLFP : PDMAPGNPMOE
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5A55580", Offset = "0x5A54380", VA = "0x185A55580")]
	public GFOMBCHLLFP(Type NNDIDJLAJFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PNDCBMPMNFM : MFBBOOODODO
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public PNDCBMPMNFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NMAJANCAMID : MFBBOOODODO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LDINJCOIDIB DAPMMKBJFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6DA060", Offset = "0x6D8E60", VA = "0x1806DA060")]
		[CompilerGenerated]
		get
		{
			return default(LDINJCOIDIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5A58140", Offset = "0x5A56F40", VA = "0x185A58140")]
	public NMAJANCAMID(LDINJCOIDIB FELMKIDGPKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class LOOMEBBKBLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly PANKPCMPIOD PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager OFPCNLPKKAK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public PANKPCMPIOD LKMGEGIOGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5A576C0", Offset = "0x5A564C0", VA = "0x185A576C0")]
	public LOOMEBBKBLB(PANKPCMPIOD PGJEGNBAENG, EntityManager OFPCNLPKKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x25F5A50", Offset = "0x25F4850", VA = "0x1825F5A50")]
	public bool LAAJIGDOHFG<T>(Entity JCNIDEIPPBD) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x25F37E0", Offset = "0x25F25E0", VA = "0x1825F37E0")]
	public bool ADMFEGCNCBH<T>(Entity JCNIDEIPPBD, out T NLHFEJHKLAH) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x25F4070", Offset = "0x25F2E70", VA = "0x1825F4070")]
	public T KKNPCGBICEE<T>(Entity JCNIDEIPPBD) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x25F3870", Offset = "0x25F2670", VA = "0x1825F3870")]
	private ComponentType GFFJBDMCELK<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5A575F0", Offset = "0x5A563F0", VA = "0x185A575F0")]
	private ComponentType GFFJBDMCELK(Type MAIOHDHBGKE)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class GCICBKANCPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	protected GCICBKANCPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class EPPAAKNBNNL<View, Data> : GGBNGHABEPC where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType PGDFJIJGMFL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type OODPCIHGNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8EE0", Offset = "0x1FE7CE0", VA = "0x181FE8EE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type ONKNFJOGEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA640", Offset = "0x1FE9440", VA = "0x181FEA640", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int PCPFDDEALFE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE9A90", Offset = "0x1FE8890", VA = "0x181FE9A90", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9A20", Offset = "0x1FE8820", VA = "0x181FE9A20")]
	public Data FJKJNGEDOBH(Entity JCNIDEIPPBD)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8930", Offset = "0x1FE7730", VA = "0x181FE8930")]
	public Data ACBEAPFGKCN(Entity JCNIDEIPPBD)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View CODNFHIHOPI(Entity JCNIDEIPPBD);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x45D2EC0", Offset = "0x45D1CC0", VA = "0x1845D2EC0", Slot = "15")]
	protected internal override T CODNFHIHOPI<T>(Entity JCNIDEIPPBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAF40", Offset = "0x1FE9D40", VA = "0x181FEAF40")]
	protected EPPAAKNBNNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class GGBNGHABEPC : KKDMPHCELIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic KBAANCIFJBC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager OJBGCHBGJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7E8150", Offset = "0x7E6F50", VA = "0x1807E8150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type OODPCIHGNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type ONKNFJOGEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int PCPFDDEALFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type IDAPIBBNDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCC4670", Offset = "0xCC3470", VA = "0x180CC4670", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int HMEACPDDOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5A55960", Offset = "0x5A54760", VA = "0x185A55960", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private CPLDKIAEKDJ[] EDEEAAEBMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x16D77F0", Offset = "0x16D65F0", VA = "0x1816D77F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual CPLDKIAEKDJ[] OHNHILBEHFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5A556C0", Offset = "0x5A544C0", VA = "0x185A556C0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JLAOAKAMIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5A55A60", Offset = "0x5A54860", VA = "0x185A55A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5A55780", Offset = "0x5A54580", VA = "0x185A55780")]
	public void GIHONBOCKDC(EntityManager OFPCNLPKKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x73C0B0", Offset = "0x73AEB0", VA = "0x18073C0B0")]
	protected KKDMPHCELIM OBPNIIJPCHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T CODNFHIHOPI<T>(Entity JCNIDEIPPBD) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5A558A0", Offset = "0x5A546A0", VA = "0x185A558A0", Slot = "8")]
	public (uint, uint) HAAJKFDMCLL(Entity JCNIDEIPPBD)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5A559D0", Offset = "0x5A547D0", VA = "0x185A559D0", Slot = "9")]
	public bool LGJOKLEHNHL(Entity JCNIDEIPPBD, (uint order, uint change) CPFPNOFCGCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	protected GGBNGHABEPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class IBNPJGHOLCK<Data> : BFFPNPLHNJH where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data LKPPHHDONBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2AAED50", Offset = "0x2AADB50", VA = "0x182AAED50", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2804280", Offset = "0x2803080", VA = "0x182804280", Slot = "8")]
	protected virtual bool MCOFNAKFFJL(ReadOnlySpan<Data> ICBAFEALNLG, FFMBNOGKKDB BNNDCBJIDKG, out ReadOnlySpan<byte> HDHLDBBIAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "9")]
	protected virtual bool HMPPLMKKCJK(int CPFPNOFCGCI, Span<Data> ICBAFEALNLG, in ReadOnlySpan<byte> HDHLDBBIAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEDD0", Offset = "0x2AADBD0", VA = "0x182AAEDD0", Slot = "5")]
	internal sealed override bool MCOFNAKFFJL(ref Unity.Entities.Chunk GEBAOPIJCJA, int OJCFPADACHH, FFMBNOGKKDB BNNDCBJIDKG, out ReadOnlySpan<byte> HDHLDBBIAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2AAE560", Offset = "0x2AAD360", VA = "0x182AAE560", Slot = "6")]
	internal sealed override bool HMPPLMKKCJK(int CPFPNOFCGCI, ref Unity.Entities.Chunk GEBAOPIJCJA, int OJCFPADACHH, in ReadOnlySpan<byte> HDHLDBBIAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D28D90", Offset = "0x2D27B90", VA = "0x182D28D90")]
	protected global::EILIHCCELHA<Protobuf> KFNKBJGCNIN<Protobuf>(ReadOnlySpan<Data> ICBAFEALNLG) where Protobuf : IMessage, new()
	{
		return default(global::EILIHCCELHA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D28D00", Offset = "0x2D27B00", VA = "0x182D28D00")]
	protected global::EDKCCAGKFAP<Protobuf> KCPCONKNIHG<Protobuf>(ReadOnlySpan<byte> HDHLDBBIAKI, ReadOnlySpan<Data> ICBAFEALNLG, Action<Protobuf> PEEJMLAIOHK) where Protobuf : IMessage, new()
	{
		return default(global::EDKCCAGKFAP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAF40", Offset = "0x1FE9D40", VA = "0x181FEAF40")]
	protected IBNPJGHOLCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class BFFPNPLHNJH
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int LFENOMEJLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5A547C0", Offset = "0x5A535C0", VA = "0x185A547C0", Slot = "5")]
	internal virtual bool MCOFNAKFFJL(ref Unity.Entities.Chunk GEBAOPIJCJA, int OJCFPADACHH, FFMBNOGKKDB BNNDCBJIDKG, out ReadOnlySpan<byte> HDHLDBBIAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "6")]
	internal virtual bool HMPPLMKKCJK(int CPFPNOFCGCI, ref Unity.Entities.Chunk GEBAOPIJCJA, int OJCFPADACHH, in ReadOnlySpan<byte> HDHLDBBIAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	protected BFFPNPLHNJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NCLHHJLAOIH<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo IHANJPMKCOB(TFrom NLHFEJHKLAH);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface JJEEEJKHLGH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGKAMMBMDOO(T NLHFEJHKLAH);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct EICLOFIHLOE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::NCLHHJLAOIH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> DEFGEHDMFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> IEBPHHKJBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap KKJDJCJOLIF;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct BPJBABKBFAC<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::NCLHHJLAOIH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> NNGCOPJAKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> IEBPHHKJBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap KKJDJCJOLIF;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk GEBAOPIJCJA, int KPHCIFIAKKJ, int NNMLMPFHINO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct EBDCNIFAEHD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CHHPCBLHNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> DEFGEHDMFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> IEBPHHKJBNN;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x33A5FB0", Offset = "0x33A4DB0", VA = "0x1833A5FB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct GCAJHHHKOLD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CHHPCBLHNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> DEFGEHDMFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> CPLOKHOBBDC;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct EKCFBAPPNFC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::NCLHHJLAOIH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> BHJLDIBLGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> IEBPHHKJBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap KKJDJCJOLIF;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct EPONOHFNPFN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NNDIDJLAJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> FBCKFKMPEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> MIFJJFGPPCJ;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct KIOJCDDCKCD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NNDIDJLAJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> FBCKFKMPEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> MIFJJFGPPCJ;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2727DD0", Offset = "0x2726BD0", VA = "0x182727DD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct BFEDIMECMAB<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> DEFGEHDMFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> CPLOKHOBBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, BCGDFNNBADB> INAHGNNJAEA;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2979B60", Offset = "0x2978960", VA = "0x182979B60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct NMCHGFNIBBI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::NCLHHJLAOIH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> DEFGEHDMFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> CPLOKHOBBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, BCGDFNNBADB> INAHGNNJAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap KKJDJCJOLIF;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct PGFPLPBHFNF<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::JJEEEJKHLGH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> DEFGEHDMFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> CPLOKHOBBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate KKJDJCJOLIF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct AAJEKOPCANA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity NNDIDJLAJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> FBCKFKMPEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> CBJMKFAIEKD;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5A54270", Offset = "0x5A53070", VA = "0x185A54270", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct LLFKEJLDJFO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity NNDIDJLAJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> FBCKFKMPEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> CBJMKFAIEKD;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5A56F80", Offset = "0x5A55D80", VA = "0x185A56F80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LFIPNPDNJAJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class EKFFEJJHKFO
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x266D360", Offset = "0x266C160", VA = "0x18266D360")]
	public static bool NMFCLFDPPFO<T>(this NativeArray<Entity> FBCKFKMPEEC, EntityManager OFPCNLPKKAK, Allocator HIEJKCFDMDD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class JNGABFMPCKK
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class KJGLJCJNIDH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public KJGLJCJNIDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class JEPLNJLJION<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public JEPLNJLJION()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> BMDBDAFLKNO;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5A568B0", Offset = "0x5A556B0", VA = "0x185A568B0")]
	public JNGABFMPCKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class IBDFMFHEECL
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MONBBMNHCDD
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct FABEOBBFFAJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct JLALLMEHJLA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal FABEOBBFFAJ<TFrom> AABHIBJPKOH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator HIEJKCFDMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> ALDENJHFODN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct FNMOBFMMJKB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct IINOLNBCNHM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal FNMOBFMMJKB<TFrom> AABHIBJPKOH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator HIEJKCFDMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> ALDENJHFODN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct PJGDPIMKKEC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct GOMFBHOJHLK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal PJGDPIMKKEC<TFrom> AABHIBJPKOH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator HIEJKCFDMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> ALDENJHFODN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct KMHDLBPIAMH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct BCMPLIELDBM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal KMHDLBPIAMH<TFrom> AABHIBJPKOH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator HIEJKCFDMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> ALDENJHFODN;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class ABGEFNABDOC
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class EAJDCLEHFDK
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC050", Offset = "0x2FAAE50", VA = "0x182FAC050")]
	public static NativeList<T> LIEHAPJIAMP<T>(this NativeArray<T> MCCCFCLGMPG, Allocator HIEJKCFDMDD = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class JLFDAHMBLHH
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D518D0", Offset = "0x2D506D0", VA = "0x182D518D0")]
	public static NativeArray<T> CDCJBPKHDNE<T>(this NativeList<Entity> MCCCFCLGMPG, EntityManager OFPCNLPKKAK, Allocator HIEJKCFDMDD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2D516D0", Offset = "0x2D504D0", VA = "0x182D516D0")]
	public static NativeArray<T> CDCJBPKHDNE<T>(this NativeArray<Entity> MCCCFCLGMPG, EntityManager OFPCNLPKKAK, Allocator HIEJKCFDMDD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class OBOLOBCILFB
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct OOEOLKODCHJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct PECKOMHGNCA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public OOEOLKODCHJ<TFrom> ALDENJHFODN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator HIEJKCFDMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> DEFGEHDMFKI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct EIOLDINGCHI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct GCPHNMFCBPP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public EIOLDINGCHI<TFrom> ALDENJHFODN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator HIEJKCFDMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> DEFGEHDMFKI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct JAMBBIFOFFH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct BBNOCEHGMNO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public JAMBBIFOFFH<TFrom> ALDENJHFODN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator HIEJKCFDMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> DEFGEHDMFKI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class CAEAILMHACG
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class HOEIMNBOAGG
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct FNOEJCKGMAE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator HIEJKCFDMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> DEFGEHDMFKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct AIMLDBPCOIL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator HIEJKCFDMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> DEFGEHDMFKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct BCMEDDFPPHL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator HIEJKCFDMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> DEFGEHDMFKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct AKLHJFOCPGC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator HIEJKCFDMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> DEFGEHDMFKI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class MDPICOCBDPI
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class JDIDFDOPPMD
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2D49280", Offset = "0x2D48080", VA = "0x182D49280")]
	public static NativeList<Entity> JPOIKHMFFGF<T>(this NativeArray<Entity> FBCKFKMPEEC, EntityManager OFPCNLPKKAK, Allocator HIEJKCFDMDD = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class BLHIGIIHECN
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface DCCAGDANPAC
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface MHMGLMMGOKL
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class APDGFJBAOIF
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class AFBIDNLEJDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5A54300", Offset = "0x5A53100", VA = "0x185A54300")]
	public static bool KDDEBCIMNLF(Type MAIOHDHBGKE, Type LHJGFHONIHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class JGODHOBGEDA<Attribute, BaseClass> : global::EPPCMDLKBMI<BaseClass>, KEKECGOIGFJ where Attribute : PDMAPGNPMOE
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly JFPIEAPAMJM MCHCOEKKPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string EOPECGOILOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> OPPMDCPNHCD;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A890", Offset = "0x2F49690", VA = "0x182F4A890")]
	public JGODHOBGEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A7D0", Offset = "0x2F495D0", VA = "0x182F4A7D0", Slot = "4")]
	public bool PGDHOKOGAJF(int CABFLHODPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A300", Offset = "0x2F49100", VA = "0x182F4A300", Slot = "5")]
	public global::LJJOMMCCIHN<BaseClass> FNADAPIBCLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A6D0", Offset = "0x2F494D0", VA = "0x182F4A6D0", Slot = "7")]
	protected virtual bool KDDEBCIMNLF(Type MAIOHDHBGKE, int OOCCBPLJFOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A5B0", Offset = "0x2F493B0", VA = "0x182F4A5B0", Slot = "8")]
	protected virtual int GAKLHMFBGDL(Type MAIOHDHBGKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A640", Offset = "0x2F49440", VA = "0x182F4A640")]
	public void HLFKGNEPEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A260", Offset = "0x2F49060", VA = "0x182F4A260", Slot = "6")]
	public void CBFNCDGCFPB(Type MAIOHDHBGKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LJJOMMCCIHN<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> OFKIDFAMDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> MEJACNHHAFL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> FHKLAPMNNDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x31841F0", Offset = "0x3182FF0", VA = "0x1831841F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x31846C0", Offset = "0x31834C0", VA = "0x1831846C0")]
	public LJJOMMCCIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3184520", Offset = "0x3183320", VA = "0x183184520")]
	public LJJOMMCCIHN(int FPMMBKCOHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3184170", Offset = "0x3182F70", VA = "0x183184170")]
	internal void AHKNMMEAEHA(int CABFLHODPAB, BaseClass OHIOGOMEFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE0B0", Offset = "0x2ACCEB0", VA = "0x182ACE0B0")]
	public bool FNPLMLEJPPH<T>(out BaseClass NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3184420", Offset = "0x3183220", VA = "0x183184420")]
	public bool FNPLMLEJPPH(Type DLNLFAKMGEH, out BaseClass NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x31844C0", Offset = "0x31832C0", VA = "0x1831844C0")]
	public bool NBDEJACAPHE(int CABFLHODPAB, out BaseClass NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2ACEDC0", Offset = "0x2ACDBC0", VA = "0x182ACEDC0")]
	public T NLNDLNKPGLD<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x31844F0", Offset = "0x31832F0", VA = "0x1831844F0")]
	public BaseClass NLNDLNKPGLD(Type OOMLFDJPDJE)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class MPIGPGHHDJK : global::JGODHOBGEDA<GAJBPDLFFFM, GCICBKANCPJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5A580D0", Offset = "0x5A56ED0", VA = "0x185A580D0")]
	public MPIGPGHHDJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class KPKFBOEMGCH : global::JGODHOBGEDA<JONDABLNINO, GGBNGHABEPC>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5A56B90", Offset = "0x5A55990", VA = "0x185A56B90")]
	public KPKFBOEMGCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class AOIJPDFGMMP : global::JGODHOBGEDA<GFOMBCHLLFP, BFFPNPLHNJH>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5A545F0", Offset = "0x5A533F0", VA = "0x185A545F0")]
	public AOIJPDFGMMP()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[IDOCBBAEIFB(JHEANMHFGAO.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> JGOGDIOCDNG;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F00", Offset = "0x6F6D00", VA = "0x1806F7F00")]
		private ComponentSystemTypes(List<Type> JGOGDIOCDNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5A54CA0", Offset = "0x5A53AA0", VA = "0x185A54CA0")]
		public static void HLFKGNEPEFG(List<Type> JGOGDIOCDNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5A54D30", Offset = "0x5A53B30", VA = "0x185A54D30")]
		private void KBGGMCGBION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5A54FD0", Offset = "0x5A53DD0", VA = "0x185A54FD0")]
		private bool KDDEBCIMNLF(Type MAIOHDHBGKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5A54F70", Offset = "0x5A53D70", VA = "0x185A54F70")]
		private void KCOIBPDHNLN(Type MAIOHDHBGKE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class EKBCLFGBMGC : IHIDDBECDNH
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5A551D0", Offset = "0x5A53FD0", VA = "0x185A551D0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase BGHBIDDOHOH();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5A55180", Offset = "0x5A53F80", VA = "0x185A55180")]
	protected ComponentSystemBase MLKKIALELPJ(params ComponentSystemBase[] GINNLCCNCAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x266D2C0", Offset = "0x266C0C0", VA = "0x18266D2C0")]
	protected ComponentSystemBase MLKKIALELPJ<T>(params ComponentSystemBase[] GINNLCCNCAC) where T : IHIDDBECDNH, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x266D280", Offset = "0x266C080", VA = "0x18266D280")]
	protected ComponentSystemBase EKCHDADFGBF<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x266D280", Offset = "0x266C080", VA = "0x18266D280")]
	protected ComponentSystemBase CKLAKKFDOMO<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	protected EKBCLFGBMGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface EPPCMDLKBMI<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGDHOKOGAJF(int CABFLHODPAB);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::LJJOMMCCIHN<BaseClass> FNADAPIBCLE();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IHIDDBECDNH : GPNFFMJEPLA
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5A565E0", Offset = "0x5A553E0", VA = "0x185A565E0", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public IHIDDBECDNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class MILJNGODHBE : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5A57F30", Offset = "0x5A56D30", VA = "0x185A57F30")]
	public ComponentDataFromEntity LHKNKDPJOCE(int CABFLHODPAB, bool DCLDMIHOKIB = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5A57FD0", Offset = "0x5A56DD0", VA = "0x185A57FD0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90")]
	protected MILJNGODHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class CJCMIOIDEAO : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90")]
	protected CJCMIOIDEAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class EJELJBKAGMA : MILJNGODHBE
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5A55150", Offset = "0x5A53F50", VA = "0x185A55150", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
	protected void OJGGPFBMBLK(string DIONAEGNCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x860C90", Offset = "0x85FA90", VA = "0x180860C90")]
	protected EJELJBKAGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class PPDDACGKHAP
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class GPNFFMJEPLA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	protected GPNFFMJEPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[IDOCBBAEIFB(JHEANMHFGAO.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5A5A0F0", Offset = "0x5A58EF0", VA = "0x185A5A0F0")]
		public static ComponentSystemGroup[] IIPGOKDCPMK(World PGJEGNBAENG, CJOMEPILEPF FLLNKNAPBJM = CJOMEPILEPF.Default, bool KCLGACBAENC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5A5A440", Offset = "0x5A59240", VA = "0x185A5A440")]
		private static Type[] LPBKPIPDAPK(CJOMEPILEPF FLLNKNAPBJM, bool KCLGACBAENC, ComponentSystemGroup[] BJGALDIEECK, ComponentSystemGroup FOCKKBNPNMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5A59860", Offset = "0x5A58660", VA = "0x185A59860")]
		private static ComponentSystemGroup[] EIFMNLOPMBL(World PGJEGNBAENG, out ComponentSystemGroup FOCKKBNPNMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5A5A1C0", Offset = "0x5A58FC0", VA = "0x185A5A1C0")]
		internal static bool LIIOJDLPBDI(LDINJCOIDIB FELMKIDGPKI, out HKIHDNKIHGD CFIAIPMGFMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5A59720", Offset = "0x5A58520", VA = "0x185A59720")]
		private static ComponentSystemGroup CEONJHBNPFF(Type MAIOHDHBGKE, World PGJEGNBAENG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5A595F0", Offset = "0x5A583F0", VA = "0x185A595F0")]
		private static ComponentSystemGroup[] BOBGBLBPJDI(Type[] JGOGDIOCDNG, World PGJEGNBAENG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5A59B70", Offset = "0x5A58970", VA = "0x185A59B70")]
		internal static void FHIKOFPIMOE(World PGJEGNBAENG, Type[] LFGNMNAAJOE, ComponentSystemGroup[] BJGALDIEECK, ComponentSystemGroup FOCKKBNPNMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5A5A090", Offset = "0x5A58E90", VA = "0x185A5A090")]
		internal static bool IGLGEPBDMCA(ComponentSystemBase HDNGIEMACBN, ComponentSystemGroup[] BJGALDIEECK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5A59800", Offset = "0x5A58600", VA = "0x185A59800")]
		private static void DBNMHHDGNNN(ComponentSystemGroup[] BJGALDIEECK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct IOGGBCODAML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> FBNMGIFIACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> GINNLCCNCAC;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x9333E0", Offset = "0x9321E0", VA = "0x1809333E0")]
	public IOGGBCODAML(Dictionary<Type, List<Type>> FBNMGIFIACN, HashSet<Type> GINNLCCNCAC)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[IDOCBBAEIFB(JHEANMHFGAO.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class LGELDCCCNGO : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private Type <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private IEnumerable<Type> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public IEnumerable<Type> <>3__types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public RRFilterWorldSystems <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public RRFilterWorldSystems <>3__<>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private IEnumerator<Type> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			Type IEnumerator<Type>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
			[DebuggerHidden]
			public LGELDCCCNGO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5A56EA0", Offset = "0x5A55CA0", VA = "0x185A56EA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5A56C00", Offset = "0x5A55A00", VA = "0x185A56C00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5A56F30", Offset = "0x5A55D30", VA = "0x185A56F30")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5A56E60", Offset = "0x5A55C60", VA = "0x185A56E60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5A56DB0", Offset = "0x5A55BB0", VA = "0x185A56DB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5A56DB0", Offset = "0x5A55BB0", VA = "0x185A56DB0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct BGAELNABOJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type HHFFEAMMGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CJOMEPILEPF FLLNKNAPBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool KALEAJEIINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool ALPBECCHOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool KCLGACBAENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> NADOKKEPCPC;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5A5AA80", Offset = "0x5A59880", VA = "0x185A5AA80")]
		public static RRFilterWorldSystems FBMANFCLCAO()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5A5ADF0", Offset = "0x5A59BF0", VA = "0x185A5ADF0")]
		public RRFilterWorldSystems LCILCKDCPID(CJOMEPILEPF FELMKIDGPKI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5A5AAB0", Offset = "0x5A598B0", VA = "0x185A5AAB0")]
		public RRFilterWorldSystems FNOKKJOKILL(IEnumerable<Type> JGOGDIOCDNG)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5A5AAA0", Offset = "0x5A598A0", VA = "0x185A5AAA0")]
		public RRFilterWorldSystems FGDILOMLFIN(bool HHLDKIDOIMP)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5A5B0E0", Offset = "0x5A59EE0", VA = "0x185A5B0E0")]
		public RRFilterWorldSystems NLHOHCOGDHI(bool JICLAOJGDGG)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5A5A9F0", Offset = "0x5A597F0", VA = "0x185A5A9F0")]
		public IOGGBCODAML BOPIMJLOMKH(Type[] MIELBJCBLAM)
		{
			return default(IOGGBCODAML);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5A5AAF0", Offset = "0x5A598F0", VA = "0x185A5AAF0")]
		[IteratorStateMachine(typeof(LGELDCCCNGO))]
		internal IEnumerable<Type> GFPOHBBOPFE(IEnumerable<Type> JGOGDIOCDNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5A5AE00", Offset = "0x5A59C00", VA = "0x185A5AE00")]
		internal Dictionary<Type, List<Type>> NIDMOAGNFPG(IEnumerable<Type> JGOGDIOCDNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5A5ACE0", Offset = "0x5A59AE0", VA = "0x185A5ACE0")]
		private void IKFAKKFOJGI(Dictionary<Type, List<Type>> GJFKHPNECKG, Type MAIOHDHBGKE, Type KGGLMALHMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5A5A830", Offset = "0x5A59630", VA = "0x185A5A830")]
		internal HashSet<Type> BFJENDKLLME(IEnumerable<Type> BJGALDIEECK, Dictionary<Type, List<Type>> IEPEFMMEENM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5A5B0F0", Offset = "0x5A59EF0", VA = "0x185A5B0F0")]
		internal bool NMBJIHHNCGN(Type MAIOHDHBGKE, CJOMEPILEPF FLLNKNAPBJM, bool KCLGACBAENC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5A5AB80", Offset = "0x5A59980", VA = "0x185A5AB80")]
		[CompilerGenerated]
		internal static void IEACEPNKHMD(Type MAIOHDHBGKE, ref BGAELNABOJK P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class GHEHPIKKPCG
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool JDLNAGJIGCB;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5A55A90", Offset = "0x5A54890", VA = "0x185A55A90")]
	public static void GIHONBOCKDC(bool AJKJHFCHOAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5A55AF0", Offset = "0x5A548F0", VA = "0x185A55AF0")]
	private static void NFGMFINKOJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class MMBKLOACMIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5A580A0", Offset = "0x5A56EA0", VA = "0x185A580A0")]
	public static ulong AHIMBDOIKGK(Type MAIOHDHBGKE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5A57FE0", Offset = "0x5A56DE0", VA = "0x185A57FE0")]
	public static ulong AHIMBDOIKGK(string AILMDHJKBPN)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[IDOCBBAEIFB(JHEANMHFGAO.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct ALLOBINPJIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong OKOKAGJHDMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong GJMDLOMMEFI;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9454A0", Offset = "0x9442A0", VA = "0x1809454A0")]
			public ALLOBINPJIF(ulong KJOPCAFKEKK, ulong HCAPEJECKKC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5A54560", Offset = "0x5A53360", VA = "0x185A54560", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> FOBJGOMHMID;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static ALLOBINPJIF[] JLCCIHKIDJG;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool JDLNAGJIGCB;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5A5C090", Offset = "0x5A5AE90", VA = "0x185A5C090")]
		public static ulong HHJCENEHCKH(int CABFLHODPAB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5A5C440", Offset = "0x5A5B240", VA = "0x185A5C440")]
		public static int NJFBJGAIBPO(ulong HCAPEJECKKC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5A5BDC0", Offset = "0x5A5ABC0", VA = "0x185A5BDC0")]
		public static void GIHONBOCKDC(bool AJKJHFCHOAK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5A5C1D0", Offset = "0x5A5AFD0", VA = "0x185A5C1D0")]
		private static void LIDNILJJLMC(int IHFFLMHKGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5A5BAA0", Offset = "0x5A5A8A0", VA = "0x185A5BAA0")]
		private static void FBEMIKCKOBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5A5C0F0", Offset = "0x5A5AEF0", VA = "0x185A5C0F0")]
		private static ALLOBINPJIF IAGAMMMMKLL(Type MAIOHDHBGKE)
		{
			return default(ALLOBINPJIF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5A5B800", Offset = "0x5A5A600", VA = "0x185A5B800")]
		private static ulong ALMAOGPLDOA(Type MAIOHDHBGKE, ulong HCAPEJECKKC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5A5B870", Offset = "0x5A5A670", VA = "0x185A5B870")]
		private static void BBKOGGNEJOF(in ALLOBINPJIF HCJIKGDLLFI, TypeManager.TypeInfo GALCODAEOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5A5C2B0", Offset = "0x5A5B0B0", VA = "0x185A5C2B0")]
		private static void LJNELCPJAFE(ALLOBINPJIF GALCODAEOKD, int CABFLHODPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5A5BFB0", Offset = "0x5A5ADB0", VA = "0x185A5BFB0")]
		private static void GJKKEMDKPJM(ALLOBINPJIF GALCODAEOKD, int CABFLHODPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5A5C3B0", Offset = "0x5A5B1B0", VA = "0x185A5C3B0")]
		private static ALLOBINPJIF MFIMFCAANFL(int CABFLHODPAB)
		{
			return default(ALLOBINPJIF);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5A5BA90", Offset = "0x5A5A890", VA = "0x185A5BA90")]
		private static int DDGDNPJODBI(int CABFLHODPAB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class GMGLFFBBELC
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly KPKFBOEMGCH BIHBIHGDJPF;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly AOIJPDFGMMP ILMPBMBEMCO;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly MPIGPGHHDJK BCILHDILHNN;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> ONGBOAGPKCH;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool JDLNAGJIGCB;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::EPPCMDLKBMI<GGBNGHABEPC> CMIJLODHGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5A55D30", Offset = "0x5A54B30", VA = "0x185A55D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::EPPCMDLKBMI<BFFPNPLHNJH> FOOCNNLMBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5A56240", Offset = "0x5A55040", VA = "0x185A56240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::EPPCMDLKBMI<GCICBKANCPJ> PKPGJOBLODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5A562A0", Offset = "0x5A550A0", VA = "0x185A562A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5A55D90", Offset = "0x5A54B90", VA = "0x185A55D90")]
	public static void GIHONBOCKDC(bool AJKJHFCHOAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5A55CB0", Offset = "0x5A54AB0", VA = "0x185A55CB0")]
	public static Type[] EPMNAKLONBE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class OLACLDBANDN
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> JIEDEGFCJBB;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool JDLNAGJIGCB;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5A58560", Offset = "0x5A57360", VA = "0x185A58560")]
	public static int HAAJKFDMCLL(int CABFLHODPAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5A584C0", Offset = "0x5A572C0", VA = "0x185A584C0")]
	public static void GIHONBOCKDC(bool AJKJHFCHOAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5A58170", Offset = "0x5A56F70", VA = "0x185A58170")]
	private static void ANEOIIGDMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5A583F0", Offset = "0x5A571F0", VA = "0x185A583F0")]
	private static int DBFMAPNHPOK(Type MAIOHDHBGKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5A58440", Offset = "0x5A57240", VA = "0x185A58440")]
	private static void FDAOBHPPNLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class PANKPCMPIOD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World PGJEGNBAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World ILDDDCMMPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LOOMEBBKBLB OHIOGOMEFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] BJGALDIEECK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World LKMGEGIOGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World HNNGMFGFANA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager OJBGCHBGJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2040A60", Offset = "0x203F860", VA = "0x182040A60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public LOOMEBBKBLB PMPGCJKHBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::LJJOMMCCIHN<GGBNGHABEPC> CMIJLODHGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::LJJOMMCCIHN<BFFPNPLHNJH> FOOCNNLMBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6F7830", Offset = "0x6F6630", VA = "0x1806F7830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::LJJOMMCCIHN<GCICBKANCPJ> PKPGJOBLODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6FA150", Offset = "0x6F8F50", VA = "0x1806FA150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3E0", Offset = "0x6F91E0", VA = "0x1806FA3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> EOOBNKAGIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2082E70", Offset = "0x2081C70", VA = "0x182082E70")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] AOHHKHAGBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5A58680", Offset = "0x5A57480", VA = "0x185A58680")]
	public static PANKPCMPIOD BECCENLFIBL(string EOPECGOILOC, LDINJCOIDIB FELMKIDGPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5A590C0", Offset = "0x5A57EC0", VA = "0x185A590C0")]
	public PANKPCMPIOD(string EOPECGOILOC, LDINJCOIDIB FELMKIDGPKI = LDINJCOIDIB.Simulation, CJOMEPILEPF FLLNKNAPBJM = CJOMEPILEPF.Default, bool AJKJHFCHOAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5A590A0", Offset = "0x5A57EA0", VA = "0x185A590A0")]
	public ComponentSystemBase PNJALCDEGMA(Type MAIOHDHBGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x24AC7E0", Offset = "0x24AB5E0", VA = "0x1824AC7E0")]
	public T PNJALCDEGMA<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5A58F80", Offset = "0x5A57D80", VA = "0x185A58F80")]
	public void NPIDOPLOGGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5A58FE0", Offset = "0x5A57DE0", VA = "0x185A58FE0")]
	public void OEOCJGGPMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5A58700", Offset = "0x5A57500", VA = "0x185A58700")]
	public void BLKKMAFPABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5A58F20", Offset = "0x5A57D20", VA = "0x185A58F20")]
	public void NAPAEIDJOFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5A58760", Offset = "0x5A57560", VA = "0x185A58760")]
	public void BMKKDPBOEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5A59040", Offset = "0x5A57E40", VA = "0x185A59040")]
	public void OIEKHBNJJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5A587C0", Offset = "0x5A575C0", VA = "0x185A587C0")]
	public void CLBILNPJAFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5A58BC0", Offset = "0x5A579C0", VA = "0x185A58BC0")]
	public void HOLJAFFPABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5A58D60", Offset = "0x5A57B60", VA = "0x185A58D60")]
	public void JKEJFPIFIMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5A58820", Offset = "0x5A57620", VA = "0x185A58820")]
	public void CLHMOHNGMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5A58E40", Offset = "0x5A57C40", VA = "0x185A58E40")]
	internal void MKMMCGOLMCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5A58DC0", Offset = "0x5A57BC0", VA = "0x185A58DC0")]
	private bool KFFIEFAKLIK(ComponentSystemGroup BNOLJGPLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5A58880", Offset = "0x5A57680", VA = "0x185A58880")]
	private void DGLFFIPJMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5A58C50", Offset = "0x5A57A50", VA = "0x185A58C50")]
	private ComponentSystemGroup[] IIPGOKDCPMK(CJOMEPILEPF FLLNKNAPBJM, bool KCLGACBAENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5A58B50", Offset = "0x5A57950", VA = "0x185A58B50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum LDINJCOIDIB
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Game = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[AttributeUsage(AttributeTargets.Class)]
public sealed class MLCJDAFPEPD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public CJOMEPILEPF HCHJJAFKKEK;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum CJOMEPILEPF
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	GameObjectConversion = 0x30,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	EntitySceneOptimizations = 4,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	ProcessAfterLoad = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	HybridGameObjectConversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DotsRuntimeGameObjectConversion = 0x20
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface HKIHDNKIHGD
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type MGBLAHCHIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] EOBKPCMNBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class OLPOIKACOAB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool PDKMFLAEBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x70F850", Offset = "0x70E650", VA = "0x18070F850", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	protected OLPOIKACOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class DPLAFAILNFE : OLPOIKACOAB
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public DPLAFAILNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class HDPIHGBOAMO : OLPOIKACOAB
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public HDPIHGBOAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class COIKOELAAFL : OLPOIKACOAB
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public COIKOELAAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class JCJGFNBHNFK : OLPOIKACOAB
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public JCJGFNBHNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class ECOAHKAJBBE : OLPOIKACOAB
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public ECOAHKAJBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class JOIIIDFJBFG : OLPOIKACOAB
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public JOIIIDFJBFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class AFJALALCJFF : OLPOIKACOAB
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public AFJALALCJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class DNOJLBBKABM : OLPOIKACOAB
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public DNOJLBBKABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class FEGIBKPEJGH : OLPOIKACOAB
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public FEGIBKPEJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class FHFPMBJNELD : CEJCHPEKNCN
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public FHFPMBJNELD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class IGJOIFIIHPO : CEJCHPEKNCN
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public IGJOIFIIHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class PKAPABMKINH : CEJCHPEKNCN
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public PKAPABMKINH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class IMAHCPEKDHM : CEJCHPEKNCN
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public IMAHCPEKDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[COEFBNKMAPI(DADIFNCKKPF.Application)]
public class CEJCHPEKNCN : OLPOIKACOAB
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool PDKMFLAEBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5A544E0", Offset = "0x5A532E0", VA = "0x185A544E0")]
	public CEJCHPEKNCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class CNPKDPIJOGH : MFBBOOODODO
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x12BBB00", Offset = "0x12BA900", VA = "0x1812BBB00")]
	public CNPKDPIJOGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class BIONHHEHMCB
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void EBMDEDOBBAB<From, To>(From ALDENJHFODN, ref To ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class NIJCMCHGNFI<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static EBMDEDOBBAB<From, To> CCHADMNMMJO;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public NIJCMCHGNFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5A547E0", Offset = "0x5A535E0", VA = "0x185A547E0")]
	static BIONHHEHMCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x283E2D0", Offset = "0x283D0D0", VA = "0x18283E2D0")]
	public static void JIIGECBJGFH<T>(EBMDEDOBBAB<T, T> KBAOGNLCNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x283E160", Offset = "0x283CF60", VA = "0x18283E160")]
	public static void JIIGECBJGFH<From, To>(EBMDEDOBBAB<From, To> KBAOGNLCNFG, EBMDEDOBBAB<To, From> CIHHMAIFOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x283E1F0", Offset = "0x283CFF0", VA = "0x18283E1F0")]
	public static void JIIGECBJGFH<From, To>(EBMDEDOBBAB<From, To> CCHADMNMMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2CCB2F0", Offset = "0x2CCA0F0", VA = "0x182CCB2F0")]
	public static EBMDEDOBBAB<From, To> GLMGEIBGEOD<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE930", Offset = "0x2CCD730", VA = "0x182CCE930")]
	public static void HGFFGJANEIJ<From, To>(From ALDENJHFODN, ref To ACLNLJOHHEH, FFMBNOGKKDB BNNDCBJIDKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class FFMBNOGKKDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> JIOLOLAMACK;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x10CD220", Offset = "0x10CC020", VA = "0x1810CD220")]
	public FFMBNOGKKDB(NativeArray<EntityRemapUtility.EntityRemapInfo> JIOLOLAMACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2F06A90", Offset = "0x2F05890", VA = "0x182F06A90")]
	public Entity EMGHMANKLCA(Entity HOKEJKCPCMA)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class FALNMDFIBII
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> MMPIODJIFKF;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5A55390", Offset = "0x5A54190", VA = "0x185A55390")]
	public static bool PGLAAPGCFFC(ulong HJECOOILIMC, uint CPFPNOFCGCI, out string EOPECGOILOC)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[IDOCBBAEIFB(JHEANMHFGAO.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct OJCMJPKAINN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int HGGIJKLHICO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int LFENOMEJLFM;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x783340", Offset = "0x782140", VA = "0x180783340")]
			public OJCMJPKAINN(int CPOAAGLEIPE, int CPFPNOFCGCI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct CEEDAOJDPJA
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch OBFBKMKDGFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long ACCOHBNKMAI;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long KABDBGBNGKM
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x5A54B10", Offset = "0x5A53910", VA = "0x185A54B10")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long OEGBGBPFEIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5A54B70", Offset = "0x5A53970", VA = "0x185A54B70")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5A54BE0", Offset = "0x5A539E0", VA = "0x185A54BE0")]
			public static CEEDAOJDPJA JAFMPPMJCJM()
			{
				return default(CEEDAOJDPJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct MELFCFANPEC : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct GOPHGPKKHGF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* HODLNPHEPJL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly HNBPOHBNNCJ.BECIAPHAGLM.FHMLLMLBKKH LABOMDFNDKJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly FFMBNOGKKDB BNNDCBJIDKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::LJJOMMCCIHN<BFFPNPLHNJH> DODHBPGDFOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int OJCFPADACHH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int KPHCIFIAKKJ;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x5A56580", Offset = "0x5A55380", VA = "0x185A56580")]
				public unsafe GOPHGPKKHGF(Unity.Entities.Archetype* HODLNPHEPJL, HNBPOHBNNCJ.BECIAPHAGLM.FHMLLMLBKKH LABOMDFNDKJ, FFMBNOGKKDB BNNDCBJIDKG, global::LJJOMMCCIHN<BFFPNPLHNJH> DODHBPGDFOJ, int OJCFPADACHH, int KPHCIFIAKKJ = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5A56530", Offset = "0x5A55330", VA = "0x185A56530")]
				public GOPHGPKKHGF(in GOPHGPKKHGF PHAPMEHMHAK, int KPHCIFIAKKJ)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly GOPHGPKKHGF[] ICBAFEALNLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] IPHKBLHBGIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int PMANJNHBJFJ;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5A57DF0", Offset = "0x5A56BF0", VA = "0x185A57DF0")]
			public MELFCFANPEC(GOPHGPKKHGF[] ICBAFEALNLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5A57710", Offset = "0x5A56510", VA = "0x185A57710", Slot = "4")]
			public void Invoke(int CPOAAGLEIPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5A57770", Offset = "0x5A56570", VA = "0x185A57770")]
			private void NNLGKGOCPBL(in GOPHGPKKHGF PHAPMEHMHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5A57B20", Offset = "0x5A56920", VA = "0x185A57B20")]
			private static void PKKGIOGEFAL(in GOPHGPKKHGF PHAPMEHMHAK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class AHHJINLIBLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public HNBPOHBNNCJ asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::LJJOMMCCIHN<BFFPNPLHNJH> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public AHHJINLIBLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5A544F0", Offset = "0x5A532F0", VA = "0x185A544F0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class MKEBLLBEPNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public HNBPOHBNNCJ.BECIAPHAGLM.FHMLLMLBKKH srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AHHJINLIBLJ CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public MKEBLLBEPNL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class GBGFPBONPOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public MKEBLLBEPNL CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public GBGFPBONPOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5A555B0", Offset = "0x5A543B0", VA = "0x185A555B0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly JFPIEAPAMJM ALNODAEDDFH;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly JFPIEAPAMJM MFFBBPBFKKD;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly JFPIEAPAMJM JKDKILGIMNL;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly JFPIEAPAMJM BICNBJIFHPP;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool LDNEKMBJLPJ;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static HNBPOHBNNCJ.BECIAPHAGLM.OKCBNMDFDPG MPGPJEMLBFP;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5A5FE60", Offset = "0x5A5EC60", VA = "0x185A5FE60")]
		private unsafe static bool OJNOCHCDGCG(Unity.Entities.Archetype* PAMNOPDNHEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5A5DC00", Offset = "0x5A5CA00", VA = "0x185A5DC00")]
		internal unsafe static Unity.Entities.Archetype*[] DHIBLCMLMLK(ref Unity.Entities.EntityComponentStore OJNNKICGEHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F610", Offset = "0x5A5E410", VA = "0x185A5F610")]
		public static void KMECCADFFHN(PANKPCMPIOD PGJEGNBAENG, out ByteString HDHLDBBIAKI, out NativeArray<EntityRemapUtility.EntityRemapInfo> OFCDBGOMMGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5A5DDE0", Offset = "0x5A5CBE0", VA = "0x185A5DDE0")]
		internal static void EKPJLAJOMGJ(PANKPCMPIOD PGJEGNBAENG, HNBPOHBNNCJ HBDHPPPOKPJ, out NativeArray<EntityRemapUtility.EntityRemapInfo> OFCDBGOMMGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5A5D230", Offset = "0x5A5C030", VA = "0x185A5D230")]
		private unsafe static UnsafeHashMap<ulong, OJCMJPKAINN> BNCIBNGGJOD(Unity.Entities.Archetype*[] OJAEDOMBPID)
		{
			return default(UnsafeHashMap<ulong, OJCMJPKAINN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F0B0", Offset = "0x5A5DEB0", VA = "0x185A5F0B0")]
		private static void IILOGHOPHKF(HNBPOHBNNCJ HBDHPPPOKPJ, UnsafeHashMap<ulong, OJCMJPKAINN> APFDEEOBGLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F2E0", Offset = "0x5A5E0E0", VA = "0x185A5F2E0")]
		private unsafe static void KKNGMIEGIBI(HNBPOHBNNCJ HBDHPPPOKPJ, Unity.Entities.Archetype*[] OJAEDOMBPID, UnsafeHashMap<ulong, OJCMJPKAINN> APFDEEOBGLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5A5FF70", Offset = "0x5A5ED70", VA = "0x185A5FF70")]
		private unsafe static int PNMMANCIPPF(Unity.Entities.Archetype*[] OJAEDOMBPID)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5A5E7C0", Offset = "0x5A5D5C0", VA = "0x185A5E7C0")]
		private unsafe static void GPCMHANCGJM(HNBPOHBNNCJ HBDHPPPOKPJ, Unity.Entities.Archetype*[] OJAEDOMBPID, global::LJJOMMCCIHN<BFFPNPLHNJH> DODHBPGDFOJ, NativeArray<EntityRemapUtility.EntityRemapInfo> OFCDBGOMMGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5A5FBF0", Offset = "0x5A5E9F0", VA = "0x185A5FBF0")]
		private static NativeArray<int> NNEHPOOGFLF(HNBPOHBNNCJ HBDHPPPOKPJ)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F860", Offset = "0x5A5E660", VA = "0x185A5F860")]
		private static Memory<EntityArchetype> NFLBLMIANFH(HNBPOHBNNCJ HBDHPPPOKPJ, NativeArray<int> JGOGDIOCDNG, EntityManager OFPCNLPKKAK, out int IBFFPFDGGKM, out int EPNDCODKEKN)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5A5ED60", Offset = "0x5A5DB60", VA = "0x185A5ED60")]
		private unsafe static void IIEEBECJFLH(Unity.Entities.Chunk* BPFMLPJJJPJ, ReadOnlySpan<byte> HDHLDBBIAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5A5D4C0", Offset = "0x5A5C2C0", VA = "0x185A5D4C0")]
		private static void CNJODHOFINM(HNBPOHBNNCJ HBDHPPPOKPJ, NativeArray<int> JGOGDIOCDNG, Span<EntityArchetype> OJAEDOMBPID, EntityManager OFPCNLPKKAK, global::LJJOMMCCIHN<BFFPNPLHNJH> DODHBPGDFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F260", Offset = "0x5A5E060", VA = "0x185A5F260")]
		private unsafe static void JKKOOOOCLMB(Unity.Entities.Chunk* GEBAOPIJCJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5A5CF20", Offset = "0x5A5BD20", VA = "0x185A5CF20")]
		private unsafe static void BIOGLJJIBEH(HNBPOHBNNCJ.BECIAPHAGLM.FHMLLMLBKKH HODLNPHEPJL, int KKNAFOMGNGP, int DDNGDGOLCOP, Unity.Entities.Chunk* BPFMLPJJJPJ, HNBPOHBNNCJ HBDHPPPOKPJ, NativeArray<int> JGOGDIOCDNG, global::LJJOMMCCIHN<BFFPNPLHNJH> DODHBPGDFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5A5C840", Offset = "0x5A5B640", VA = "0x185A5C840")]
		public static void APIGIIENFMP(PANKPCMPIOD PGJEGNBAENG, in ByteString HDHLDBBIAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5A5C8D0", Offset = "0x5A5B6D0", VA = "0x185A5C8D0")]
		public static void APIGIIENFMP(EntityManager OFPCNLPKKAK, global::LJJOMMCCIHN<BFFPNPLHNJH> DODHBPGDFOJ, in ByteString HDHLDBBIAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5A5C580", Offset = "0x5A5B380", VA = "0x185A5C580")]
		private static bool AIKBGMIIADA(Type MAIOHDHBGKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5A5E510", Offset = "0x5A5D310", VA = "0x185A5E510")]
		private static void ENPNHCBAJLA(TypeManager.TypeInfo GALCODAEOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F6D0", Offset = "0x5A5E4D0", VA = "0x185A5F6D0")]
		private unsafe static int LIPJNDOIIMJ(Unity.Entities.Archetype*[] OJAEDOMBPID, NativeArray<EntityRemapUtility.EntityRemapInfo> OFCDBGOMMGD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5A5EBE0", Offset = "0x5A5D9E0", VA = "0x185A5EBE0")]
		private static int HAAJKFDMCLL(int CABFLHODPAB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5A5ECC0", Offset = "0x5A5DAC0", VA = "0x185A5ECC0")]
		private static ulong HHJCENEHCKH(int CABFLHODPAB)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class LOIBHBJKIFK
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5A57450", Offset = "0x5A56250", VA = "0x185A57450")]
	private unsafe static Span<byte> JPJDKNBGLFI(Unity.Entities.Chunk* GEBAOPIJCJA, int OJCFPADACHH)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x25EF2E0", Offset = "0x25EE0E0", VA = "0x1825EF2E0")]
	public unsafe static Span<T> HBKLICOLJPF<T>(Unity.Entities.Chunk* GEBAOPIJCJA, int OJCFPADACHH)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x25EF2A0", Offset = "0x25EE0A0", VA = "0x1825EF2A0")]
	public static Span<T> HBKLICOLJPF<T>(this ref Unity.Entities.Chunk GEBAOPIJCJA, int OJCFPADACHH)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5A573E0", Offset = "0x5A561E0", VA = "0x185A573E0")]
	public unsafe static Span<Entity> FGMFHFKFHCD(Unity.Entities.Chunk* GEBAOPIJCJA)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5A57140", Offset = "0x5A55F40", VA = "0x185A57140")]
	public unsafe static void FDAOBHPPNLM(Unity.Entities.Chunk* GEBAOPIJCJA, int OJCFPADACHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5A57010", Offset = "0x5A55E10", VA = "0x185A57010")]
	public static Entity DIHDANDNHJH(this EntityQuery KFFFLMFFADE)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : GIHBEMJPMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5A60240", Offset = "0x5A5F040", VA = "0x185A60240", Slot = "4")]
		public sealed override void HLFKGNEPEFG()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
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

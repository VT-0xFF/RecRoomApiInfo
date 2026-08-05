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
		[Cpp2IlInjected.Address(RVA = "0x5A21080", Offset = "0x5A20280", VA = "0x185A21080")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5A220C0", Offset = "0x5A212C0", VA = "0x185A220C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5A22130", Offset = "0x5A21330", VA = "0x185A22130")]
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
			[Cpp2IlInjected.Address(RVA = "0x29DC9A0", Offset = "0x29DBBA0", VA = "0x1829DC9A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E60EF0", Offset = "0x1E600F0", VA = "0x181E60EF0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E605A0", Offset = "0x1E5F7A0", VA = "0x181E605A0")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E606A0", Offset = "0x1E5F8A0", VA = "0x181E606A0")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E60AA0", Offset = "0x1E5FCA0", VA = "0x181E60AA0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5A22150", Offset = "0x5A21350", VA = "0x185A22150")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DEGFPCEOELD<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MLKGBHNMNOG : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::DEGFPCEOELD<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAD8450", Offset = "0xAD7650", VA = "0x180AD8450", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x26316F0", Offset = "0x26308F0", VA = "0x1826316F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1721F60", Offset = "0x1721160", VA = "0x181721F60")]
		[DebuggerHidden]
		public MLKGBHNMNOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2631510", Offset = "0x2630710", VA = "0x182631510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x26316B0", Offset = "0x26308B0", VA = "0x1826316B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> ACOGOFENGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream EDIGAFOKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream MACMIFOCGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf OFFJPOMOLDJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int ODCOGNPDKPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB720", Offset = "0x6FA920", VA = "0x1806FB720")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x20C3A70", Offset = "0x20C2C70", VA = "0x1820C3A70")]
	private DEGFPCEOELD(byte[] ACMMHKGMFIC, Action<Protobuf> ACOGOFENGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x235EF20", Offset = "0x235E120", VA = "0x18235EF20")]
	public static global::DEGFPCEOELD<Protobuf> GPGHDDABLEF<Data>(ReadOnlySpan<byte> NDFFNBIIOEO, ReadOnlySpan<Data> DKIPBFCBBBG, Action<Protobuf> ACOGOFENGKD)
	{
		return default(global::DEGFPCEOELD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x20C38E0", Offset = "0x20C2AE0", VA = "0x1820C38E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x20C3920", Offset = "0x20C2B20", VA = "0x1820C3920", Slot = "4")]
	[IteratorStateMachine(typeof(global::DEGFPCEOELD<>.MLKGBHNMNOG))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x20C3A20", Offset = "0x20C2C20", VA = "0x1820C3A20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MEANAMMMDOB<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] ACMMHKGMFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf OFFJPOMOLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream EDIGAFOKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream IPBDLBBDOBA;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2621FF0", Offset = "0x26211F0", VA = "0x182621FF0")]
	private MEANAMMMDOB(byte[] ACMMHKGMFIC, in Protobuf OFFJPOMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1F30C10", Offset = "0x1F2FE10", VA = "0x181F30C10")]
	public static global::MEANAMMMDOB<Protobuf> GPGHDDABLEF<T>(ReadOnlySpan<T> DKIPBFCBBBG)
	{
		return default(global::MEANAMMMDOB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2621E00", Offset = "0x2621000", VA = "0x182621E00")]
	public void DHMEPHDNKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2621F60", Offset = "0x2621160", VA = "0x182621F60")]
	public ByteString ENJFIGHINPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2621E30", Offset = "0x2621030", VA = "0x182621E30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OKHCCPOEENJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream EDIGAFOKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream MACMIFOCGLM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5A26230", Offset = "0x5A25430", VA = "0x185A26230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct AHBBPANPCNO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] ACMMHKGMFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream EDIGAFOKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream IPBDLBBDOBA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F20", Offset = "0x5A20120", VA = "0x185A20F20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EOGJCPCONCA
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	public static void OAKDEMEPJLB(this HDHIMOFHFJL AHADDDAMGKE, NativeArray<Entity> EJIAHCPIPFJ, [Optional][CallerFilePath] string HHPCAIEGGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	public static void OAKDEMEPJLB(this HDHIMOFHFJL AHADDDAMGKE, string KNOPFGAGMCN, NativeArray<Entity> EJIAHCPIPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	public static void OAKDEMEPJLB(this HDHIMOFHFJL AHADDDAMGKE, string HHPCAIEGGGM, NativeArray<Entity> EJIAHCPIPFJ, bool HNGJGPJCNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	public static void HKMAJNJICCP(this HDHIMOFHFJL AHADDDAMGKE, NativeArray<Entity> EJIAHCPIPFJ, NativeArray<Entity> BDDHHHHDEKA, [Optional][CallerFilePath] string HHPCAIEGGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	public static void HKMAJNJICCP(this HDHIMOFHFJL AHADDDAMGKE, string HHPCAIEGGGM, NativeArray<Entity> EJIAHCPIPFJ, NativeArray<Entity> BDDHHHHDEKA, bool HNGJGPJCNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x20E3E50", Offset = "0x20E3050", VA = "0x1820E3E50")]
	public static void CHDDGHBNJMB<T>(this HDHIMOFHFJL AHADDDAMGKE, string KNOPFGAGMCN, NativeArray<Entity> EJIAHCPIPFJ, NativeList<T> PCPEJHIMHJJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x20E3E10", Offset = "0x20E3010", VA = "0x1820E3E10")]
	public static void CHDDGHBNJMB<T>(this HDHIMOFHFJL AHADDDAMGKE, string KNOPFGAGMCN, NativeArray<Entity> EJIAHCPIPFJ, NativeArray<T> PCPEJHIMHJJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	public static void CHDDGHBNJMB<T>(this HDHIMOFHFJL AHADDDAMGKE, string HHPCAIEGGGM, NativeArray<Entity> EJIAHCPIPFJ, NativeArray<T> PCPEJHIMHJJ, bool HNGJGPJCNBJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x20E3F10", Offset = "0x20E3110", VA = "0x1820E3F10")]
	public static void HIIEMFKPPHP<T>(this HDHIMOFHFJL AHADDDAMGKE, NativeList<T> PCPEJHIMHJJ, [Optional][CallerFilePath] string HHPCAIEGGGM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x20E3F80", Offset = "0x20E3180", VA = "0x1820E3F80")]
	public static void HIIEMFKPPHP<T>(this HDHIMOFHFJL AHADDDAMGKE, NativeArray<T> PCPEJHIMHJJ, [Optional][CallerFilePath] string HHPCAIEGGGM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	public static void HIIEMFKPPHP<T>(this HDHIMOFHFJL AHADDDAMGKE, string HHPCAIEGGGM, NativeArray<T> PCPEJHIMHJJ, bool HNGJGPJCNBJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	public static void JAFEBDOKKGN(this HDHIMOFHFJL AHADDDAMGKE, EntityQuery ADGIOFAMOGF, [Optional][CallerFilePath] string HHPCAIEGGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	public static void JAFEBDOKKGN(this HDHIMOFHFJL AHADDDAMGKE, string KNOPFGAGMCN, EntityQuery ADGIOFAMOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	public static void JAFEBDOKKGN(this HDHIMOFHFJL AHADDDAMGKE, string HHPCAIEGGGM, EntityQuery ADGIOFAMOGF, bool HNGJGPJCNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x20E3EE0", Offset = "0x20E30E0", VA = "0x1820E3EE0")]
	public static void EHECFHPMNAL<T, T2>(this HDHIMOFHFJL AHADDDAMGKE, string KNOPFGAGMCN, EntityQuery ADGIOFAMOGF) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void EHECFHPMNAL<T, T2>(this HDHIMOFHFJL AHADDDAMGKE, string HHPCAIEGGGM, EntityQuery ADGIOFAMOGF, bool HNGJGPJCNBJ) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OEMKBCGGACH : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GDJECICPFDH ELOGHOABGGE
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
public interface DDONOJLIGHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ACLBIEKKMGM(Entity LHCPLOHKBCE, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EBEOLNKGPJA(Entity LHCPLOHKBCE, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OGFHDNBGHMH(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OGFHDNBGHMH(GDJECICPFDH PLFCHHKILCM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> LNPOEBLJDPM(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DDGHHJAEMMH(Entity LHCPLOHKBCE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BPEILBAOPBF<TComponentData, TValue> : global::GOBEPPLFEKJ<TValue>, IDisposable where TComponentData : struct, OEMKBCGGACH
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class MDEGKCAEEKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> JAAGBDPDCIE;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int BPIIJGBNBGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1932D80", Offset = "0x1931F80", VA = "0x181932D80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x261D6C0", Offset = "0x261C8C0", VA = "0x18261D6C0")]
		public bool NBPFADHCHKM(out TValue IPMIIEAGJKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x261D4E0", Offset = "0x261C6E0", VA = "0x18261D4E0")]
		public void CPCILMEHKPA(object IALNODEHBNN, TValue IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x261D640", Offset = "0x261C840", VA = "0x18261D640")]
		public bool MILDLLFOGOM(object IALNODEHBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x261D590", Offset = "0x261C790", VA = "0x18261D590")]
		public int JEBHMABMKPB(object IALNODEHBNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x261D780", Offset = "0x261C980", VA = "0x18261D780")]
		public MDEGKCAEEKN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<MDEGKCAEEKN> FNLHHAHKLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::MFEFOKNAOGN<GDJECICPFDH, MDEGKCAEEKN> NLNKBOLHCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager IIODDCGHDHF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF5D0", Offset = "0x1EBE7D0", VA = "0x181EBF5D0")]
	public BPEILBAOPBF(EntityManager IIODDCGHDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1EBEFB0", Offset = "0x1EBE1B0", VA = "0x181EBEFB0", Slot = "4")]
	public void ACLBIEKKMGM(Entity LHCPLOHKBCE, object IALNODEHBNN, TValue IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF1D0", Offset = "0x1EBE3D0", VA = "0x181EBF1D0", Slot = "5")]
	public bool EBEOLNKGPJA(Entity LHCPLOHKBCE, object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF470", Offset = "0x1EBE670", VA = "0x181EBF470", Slot = "6")]
	public bool NBPFADHCHKM(Entity LHCPLOHKBCE, out TValue IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF190", Offset = "0x1EBE390", VA = "0x181EBF190", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF340", Offset = "0x1EBE540", VA = "0x181EBF340")]
	private void FKMLGJABHIM(MDEGKCAEEKN HLFIHJCMDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF3C0", Offset = "0x1EBE5C0", VA = "0x181EBF3C0")]
	private bool GBMJEONMILO(Entity LHCPLOHKBCE, out GDJECICPFDH PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF540", Offset = "0x1EBE740", VA = "0x181EBF540")]
	private void NFBOGKBEDMD(Entity LHCPLOHKBCE, GDJECICPFDH PLFCHHKILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF1B0", Offset = "0x1EBE3B0", VA = "0x181EBF1B0")]
	private bool EACJNIOIJEG(GDJECICPFDH PLFCHHKILCM, out MDEGKCAEEKN HLFIHJCMDOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1EBF0D0", Offset = "0x1EBE2D0", VA = "0x181EBF0D0")]
	private MDEGKCAEEKN DMIIGKOEHDB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GOBEPPLFEKJ<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACLBIEKKMGM(Entity LHCPLOHKBCE, object IALNODEHBNN, TValue IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EBEOLNKGPJA(Entity LHCPLOHKBCE, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NBPFADHCHKM(Entity LHCPLOHKBCE, out TValue IPMIIEAGJKC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GDJECICPFDH : global::ECNPNPKOHHG<GDJECICPFDH>, ONMCCIDPEOK, IEquatable<GDJECICPFDH>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly GDJECICPFDH IGHAJOOKIHP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int BCGMDEIHEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x865EA0", Offset = "0x8650A0", VA = "0x180865EA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int OLGKJALIAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x18C79E0", Offset = "0x18C6BE0", VA = "0x1818C79E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x18C7A20", Offset = "0x18C6C20", VA = "0x1818C7A20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5A223A0", Offset = "0x5A215A0", VA = "0x185A223A0", Slot = "8")]
	public bool Equals(GDJECICPFDH HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5A223F0", Offset = "0x5A215F0", VA = "0x185A223F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PGKKAFJFFBH<T> : DDONOJLIGHB, IDisposable where T : struct, OEMKBCGGACH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> FNLHHAHKLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::MFEFOKNAOGN<GDJECICPFDH, HashSet<object>> NLNKBOLHCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager IIODDCGHDHF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x30DB870", Offset = "0x30DAA70", VA = "0x1830DB870")]
	public PGKKAFJFFBH(EntityManager IIODDCGHDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x30D8640", Offset = "0x30D7840", VA = "0x1830D8640", Slot = "4")]
	public bool ACLBIEKKMGM(Entity LHCPLOHKBCE, object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x30D98E0", Offset = "0x30D8AE0", VA = "0x1830D98E0", Slot = "5")]
	public bool EBEOLNKGPJA(Entity LHCPLOHKBCE, object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x30DB1D0", Offset = "0x30DA3D0", VA = "0x1830DB1D0", Slot = "6")]
	public bool OGFHDNBGHMH(Entity LHCPLOHKBCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x30DB430", Offset = "0x30DA630", VA = "0x1830DB430", Slot = "7")]
	public bool OGFHDNBGHMH(GDJECICPFDH PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x30DA820", Offset = "0x30D9A20", VA = "0x1830DA820", Slot = "8")]
	public IEnumerable<object> LNPOEBLJDPM(Entity LHCPLOHKBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x30DAC40", Offset = "0x30D9E40", VA = "0x1830DAC40", Slot = "11")]
	public IEnumerable<object> LNPOEBLJDPM(GDJECICPFDH PLFCHHKILCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x30D8E80", Offset = "0x30D8080", VA = "0x1830D8E80", Slot = "9")]
	public bool DDGHHJAEMMH(Entity LHCPLOHKBCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x30D9750", Offset = "0x30D8950", VA = "0x1830D9750", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x30DA2D0", Offset = "0x30D94D0", VA = "0x1830DA2D0")]
	private void FKMLGJABHIM(HashSet<object> HLFIHJCMDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x30DA6E0", Offset = "0x30D98E0", VA = "0x1830DA6E0")]
	private bool GBMJEONMILO(Entity LHCPLOHKBCE, out GDJECICPFDH PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x30DA1E0", Offset = "0x30D93E0", VA = "0x1830DA1E0")]
	private bool EFGOCOJGABJ(Entity LHCPLOHKBCE, out GDJECICPFDH PLFCHHKILCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x30D8C80", Offset = "0x30D7E80", VA = "0x1830D8C80")]
	private void BNNOBPLADOE(Entity LHCPLOHKBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x30DAF90", Offset = "0x30DA190", VA = "0x1830DAF90")]
	private void NFBOGKBEDMD(Entity LHCPLOHKBCE, GDJECICPFDH PLFCHHKILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x30D8D00", Offset = "0x30D7F00", VA = "0x1830D8D00")]
	private bool DCNOMHGKLOO(GDJECICPFDH PLFCHHKILCM, out HashSet<object> HLFIHJCMDOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x30D93D0", Offset = "0x30D85D0", VA = "0x1830D93D0")]
	private HashSet<object> DMIIGKOEHDB()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IEBLFPPKBPC : global::AGGAGFHIEEG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5A229C0", Offset = "0x5A21BC0", VA = "0x185A229C0", Slot = "4")]
	public float HKNOFHFBBKG(float3 IPMIIEAGJKC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BJNKCBNGLOP : global::AGGAGFHIEEG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5A213B0", Offset = "0x5A205B0", VA = "0x185A213B0", Slot = "4")]
	public float HKNOFHFBBKG(float3 IPMIIEAGJKC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PLNGIKFILBD : global::AGGAGFHIEEG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5A26270", Offset = "0x5A25470", VA = "0x185A26270", Slot = "4")]
	public float HKNOFHFBBKG(float3 IPMIIEAGJKC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct NFGGMCDNBPE : global::AGGAGFHIEEG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8D42C0", Offset = "0x8D34C0", VA = "0x1808D42C0", Slot = "4")]
	public int HKNOFHFBBKG(int3 IPMIIEAGJKC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BDFMBMJJHNL : global::AGGAGFHIEEG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3374BC0", Offset = "0x3373DC0", VA = "0x183374BC0", Slot = "4")]
	public int HKNOFHFBBKG(int3 IPMIIEAGJKC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct ICBKIKOICOE : global::AGGAGFHIEEG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5A229B0", Offset = "0x5A21BB0", VA = "0x185A229B0", Slot = "4")]
	public int HKNOFHFBBKG(int3 IPMIIEAGJKC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class JKCJPKONAAO : ECLDMCLCKCC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type FBGIAEIPGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x82F780", Offset = "0x82E980", VA = "0x18082F780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5A21050", Offset = "0x5A20250", VA = "0x185A21050")]
	public JKCJPKONAAO(Type CGHGFBHOFHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DEABIHNCNIC : JKCJPKONAAO
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5A21050", Offset = "0x5A20250", VA = "0x185A21050")]
	public DEABIHNCNIC(Type CGHGFBHOFHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FNCNKAKEKBP : JKCJPKONAAO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type ACCKBGEGCCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB00", Offset = "0x6FED00", VA = "0x1806FFB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5A22350", Offset = "0x5A21550", VA = "0x185A22350")]
	public FNCNKAKEKBP(Type NEABNLFBKEM, Type CGHGFBHOFHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AOMPPMBGCFH : JKCJPKONAAO
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5A21050", Offset = "0x5A20250", VA = "0x185A21050")]
	public AOMPPMBGCFH(Type CGHGFBHOFHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MPMKPCGOCAF : ECLDMCLCKCC
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public MPMKPCGOCAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OEFBFCOKFKI : ECLDMCLCKCC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NMAPNONNEIE JBEBPJIELNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400")]
		[CompilerGenerated]
		get
		{
			return default(NMAPNONNEIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5A26200", Offset = "0x5A25400", VA = "0x185A26200")]
	public OEFBFCOKFKI(NMAPNONNEIE PANELIGGJGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class DKCBHGMJMEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly NNHDOGKABEI PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager IIODDCGHDHF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NNHDOGKABEI JCJGOFJEAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5A21D70", Offset = "0x5A20F70", VA = "0x185A21D70")]
	public DKCBHGMJMEO(NNHDOGKABEI PHAHHGAAFFH, EntityManager IIODDCGHDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D1B0", Offset = "0x1D0C3B0", VA = "0x181D0D1B0")]
	public bool AKJCPJCNDJA<T>(Entity LHCPLOHKBCE) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D1F0", Offset = "0x1D0C3F0", VA = "0x181D0D1F0")]
	public bool JIJFKKDMPCE<T>(Entity LHCPLOHKBCE, out T IPMIIEAGJKC) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D280", Offset = "0x1D0C480", VA = "0x181D0D280")]
	public T LCBJNCOACAP<T>(Entity LHCPLOHKBCE) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EC60", Offset = "0x1D0DE60", VA = "0x181D0EC60")]
	private ComponentType MMPCFGKKOMJ<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5A21CA0", Offset = "0x5A20EA0", VA = "0x185A21CA0")]
	private ComponentType MMPCFGKKOMJ(Type NIFOGEBEDNG)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class CGCIGFDONLA
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	protected CGCIGFDONLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class EJOLFAAEBIB<View, Data> : CMBJNHHMHON where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType DLFFIIGOADD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type BPNEKDAPIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x27EB880", Offset = "0x27EAA80", VA = "0x1827EB880", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type JOPDMALFPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x27E9840", Offset = "0x27E8A40", VA = "0x1827E9840", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int AEILAHCEMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x27EAAA0", Offset = "0x27E9CA0", VA = "0x1827EAAA0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x27EAA30", Offset = "0x27E9C30", VA = "0x1827EAA30")]
	public Data CALHLHIJGJK(Entity LHCPLOHKBCE)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x27EBBE0", Offset = "0x27EADE0", VA = "0x1827EBBE0")]
	public Data PAONJOKKDGP(Entity LHCPLOHKBCE)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View FGNKGKNFPDN(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2370190", Offset = "0x236F390", VA = "0x182370190", Slot = "15")]
	protected internal override T FGNKGKNFPDN<T>(Entity LHCPLOHKBCE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x895C20", Offset = "0x894E20", VA = "0x180895C20")]
	protected EJOLFAAEBIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class CMBJNHHMHON : BKDBNLPNJFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic DLOCHPBMKFN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager KBDBPGCEONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xE853E0", Offset = "0xE845E0", VA = "0x180E853E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type BPNEKDAPIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type JOPDMALFPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int AEILAHCEMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type CIBEKLLEIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x13F2920", Offset = "0x13F1B20", VA = "0x1813F2920", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int AHCPEBKPIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5A21770", Offset = "0x5A20970", VA = "0x185A21770", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private NDGJEHEDOED[] AIOFCBMPPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x13F2900", Offset = "0x13F1B00", VA = "0x1813F2900", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual NDGJEHEDOED[] IGAEILAANOB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5A217E0", Offset = "0x5A209E0", VA = "0x185A217E0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MKJPOCEGIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5A21620", Offset = "0x5A20820", VA = "0x185A21620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5A21650", Offset = "0x5A20850", VA = "0x185A21650")]
	public void IHEKMEOIBOI(EntityManager IIODDCGHDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85CB60", VA = "0x18085D960")]
	protected BKDBNLPNJFE JJNFIHMKCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T FGNKGKNFPDN<T>(Entity LHCPLOHKBCE) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5A214D0", Offset = "0x5A206D0", VA = "0x185A214D0", Slot = "8")]
	public (uint, uint) BDCDBBPEAIJ(Entity LHCPLOHKBCE)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5A21590", Offset = "0x5A20790", VA = "0x185A21590", Slot = "9")]
	public bool DNMKMHELHID(Entity LHCPLOHKBCE, (uint order, uint change) EOGFAFNNICF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	protected CMBJNHHMHON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class MPPIOJGIBGJ<Data> : NDDLLHHFIJF where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data FBJHBFFDBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x241BB00", Offset = "0x241AD00", VA = "0x18241BB00", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1C56750", Offset = "0x1C55950", VA = "0x181C56750", Slot = "8")]
	protected virtual bool OOCPMEIOPFA(ReadOnlySpan<Data> DKIPBFCBBBG, EEJKADCLIHN ABLKPOMPEKC, out ReadOnlySpan<byte> NDFFNBIIOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "9")]
	protected virtual bool HPNNOMNIJED(int EOGFAFNNICF, Span<Data> DKIPBFCBBBG, in ReadOnlySpan<byte> NDFFNBIIOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x241BBF0", Offset = "0x241ADF0", VA = "0x18241BBF0", Slot = "5")]
	internal sealed override bool OOCPMEIOPFA(ref Unity.Entities.Chunk DMDHEKMOMJJ, int DJLHAINOAOG, EEJKADCLIHN ABLKPOMPEKC, out ReadOnlySpan<byte> NDFFNBIIOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x241A120", Offset = "0x2419320", VA = "0x18241A120", Slot = "6")]
	internal sealed override bool HPNNOMNIJED(int EOGFAFNNICF, ref Unity.Entities.Chunk DMDHEKMOMJJ, int DJLHAINOAOG, in ReadOnlySpan<byte> NDFFNBIIOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1F334A0", Offset = "0x1F326A0", VA = "0x181F334A0")]
	protected global::MEANAMMMDOB<Protobuf> NLDGDHBCIJB<Protobuf>(ReadOnlySpan<Data> DKIPBFCBBBG) where Protobuf : IMessage, new()
	{
		return default(global::MEANAMMMDOB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1F33410", Offset = "0x1F32610", VA = "0x181F33410")]
	protected global::DEGFPCEOELD<Protobuf> KNHFKJKOBNN<Protobuf>(ReadOnlySpan<byte> NDFFNBIIOEO, ReadOnlySpan<Data> DKIPBFCBBBG, Action<Protobuf> ACOGOFENGKD) where Protobuf : IMessage, new()
	{
		return default(global::DEGFPCEOELD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x895C20", Offset = "0x894E20", VA = "0x180895C20")]
	protected MPPIOJGIBGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class NDDLLHHFIJF
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int OLGKJALIAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5A24E00", Offset = "0x5A24000", VA = "0x185A24E00", Slot = "5")]
	internal virtual bool OOCPMEIOPFA(ref Unity.Entities.Chunk DMDHEKMOMJJ, int DJLHAINOAOG, EEJKADCLIHN ABLKPOMPEKC, out ReadOnlySpan<byte> NDFFNBIIOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "6")]
	internal virtual bool HPNNOMNIJED(int EOGFAFNNICF, ref Unity.Entities.Chunk DMDHEKMOMJJ, int DJLHAINOAOG, in ReadOnlySpan<byte> NDFFNBIIOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	protected NDDLLHHFIJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface AGGAGFHIEEG<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo HKNOFHFBBKG(TFrom IPMIIEAGJKC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface PMLFMLNLPDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INPBKODPGAA(T IPMIIEAGJKC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct FHFCPIJAHEN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::AGGAGFHIEEG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> NPNELLADPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> DKCOBFFEMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap IBKGKDECOEG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct CNOFIENFLNA<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::AGGAGFHIEEG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> FMOKKECDDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> DKCOBFFEMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap IBKGKDECOEG;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct HGKNJMBHMMJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MBOMPECMBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> NPNELLADPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> DKCOBFFEMJB;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3FF85C0", Offset = "0x3FF77C0", VA = "0x183FF85C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct KFFPCEDPEDH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MBOMPECMBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> NPNELLADPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> CNLFFDLPDEM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct NNECOCMIKGE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::AGGAGFHIEEG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> HMAHEJMDJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> DKCOBFFEMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap IBKGKDECOEG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct CLIKNNHCJDA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CGHGFBHOFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> HNLMOMAOEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> PICFINMIPMI;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct AGKLNFNKJID<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CGHGFBHOFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> HNLMOMAOEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> PICFINMIPMI;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x29F15D0", Offset = "0x29F07D0", VA = "0x1829F15D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct MLPMMCKGOPC<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> NPNELLADPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> CNLFFDLPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, MFEHAEMCKCJ> LCPAKHJBEOA;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2631940", Offset = "0x2630B40", VA = "0x182631940", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct JFOPFHDIJPD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::AGGAGFHIEEG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> NPNELLADPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> CNLFFDLPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, MFEHAEMCKCJ> LCPAKHJBEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap IBKGKDECOEG;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct PCHIGDDEPNC<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::PMLFMLNLPDC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> NPNELLADPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> CNLFFDLPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate IBKGKDECOEG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct NJGLNJLEJLB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity CGHGFBHOFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> HNLMOMAOEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> IFNKODBFJNG;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5A25210", Offset = "0x5A24410", VA = "0x185A25210", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct DLDIACPNDFD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity CGHGFBHOFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> HNLMOMAOEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> IFNKODBFJNG;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5A21DC0", Offset = "0x5A20FC0", VA = "0x185A21DC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class ODBDDKHOEGE
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class DCIJJKEDALC
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x116F090", Offset = "0x116E290", VA = "0x18116F090")]
	public static bool OIKNGLNCHDF<T>(this NativeArray<Entity> HNLMOMAOEAN, EntityManager IIODDCGHDHF, Allocator HCEMBCPANJM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class CEJHBJIBKMJ
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class IFABKOPOAPO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public IFABKOPOAPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class KFABPACAOCG<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public KFABPACAOCG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> GGOFGJEFIFA;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5A213C0", Offset = "0x5A205C0", VA = "0x185A213C0")]
	public CEJHBJIBKMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NGHCCGEDJJL
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HKFIKCGNEEP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct DFDCNKJJJBN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct CMHDJHAFHAJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal DFDCNKJJJBN<TFrom> HHFDFFDPCGO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator HCEMBCPANJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> CKOEFCDNGOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct PIIMPKCFBKI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct LKCCELJKBFB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal PIIMPKCFBKI<TFrom> HHFDFFDPCGO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator HCEMBCPANJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> CKOEFCDNGOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct GOHMAAHMEEL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CNADLDFIBAE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal GOHMAAHMEEL<TFrom> HHFDFFDPCGO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator HCEMBCPANJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> CKOEFCDNGOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct FAEGLOIKCOG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct OKFGOLDBAED<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal FAEGLOIKCOG<TFrom> HHFDFFDPCGO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator HCEMBCPANJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> CKOEFCDNGOI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NABLIPGCPGG
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class EKBHOAFHOKD
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D27FA0", Offset = "0x1D271A0", VA = "0x181D27FA0")]
	public static NativeList<T> EMDECGMDBAK<T>(this NativeArray<T> FGNBHCEFKCI, Allocator HCEMBCPANJM = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class ACFEABNEJND
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xE22500", Offset = "0xE21700", VA = "0x180E22500")]
	public static NativeArray<T> BCMNPJHPPPH<T>(this NativeList<Entity> FGNBHCEFKCI, EntityManager IIODDCGHDHF, Allocator HCEMBCPANJM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xE22400", Offset = "0xE21600", VA = "0x180E22400")]
	public static NativeArray<T> BCMNPJHPPPH<T>(this NativeArray<Entity> FGNBHCEFKCI, EntityManager IIODDCGHDHF, Allocator HCEMBCPANJM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class NEJCNCPEJBD
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct NDNJGKOAEJC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct MDFOPKEKCCP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public NDNJGKOAEJC<TFrom> CKOEFCDNGOI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator HCEMBCPANJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> NPNELLADPJM;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct IPJIOIPPNNM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct FJDCKPMFBEI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public IPJIOIPPNNM<TFrom> CKOEFCDNGOI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator HCEMBCPANJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> NPNELLADPJM;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct GGPNLIJNJGC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct OHHHHFJOAAH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public GGPNLIJNJGC<TFrom> CKOEFCDNGOI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator HCEMBCPANJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> NPNELLADPJM;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class KCOKJIMCDBO
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class FGCGFFLIAMP
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct ADDPDDMDOKI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator HCEMBCPANJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> NPNELLADPJM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct HBLBEHEPABH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator HCEMBCPANJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> NPNELLADPJM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct LFJGFFAFILK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator HCEMBCPANJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> NPNELLADPJM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct HGGCMMAEPJF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator HCEMBCPANJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> NPNELLADPJM;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class MPNCLOCHJHF
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class BHJLEPKNGJK
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2176730", Offset = "0x2175930", VA = "0x182176730")]
	public static NativeList<Entity> FLNNIGICPJL<T>(this NativeArray<Entity> HNLMOMAOEAN, EntityManager IIODDCGHDHF, Allocator HCEMBCPANJM = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class KMLAGINHOKB
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface BHEHLODGLPK
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface POPNIMEACKB
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class FKGPIJMJHML
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BIBPHFFEFDN
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5A211D0", Offset = "0x5A203D0", VA = "0x185A211D0")]
	public static bool GEHPNCMNMAI(Type NIFOGEBEDNG, Type HCOCNBHHCFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class ELPOILNOMIJ<Attribute, BaseClass> : global::GEOIKOPOIHO<BaseClass>, CPGHBJLKEEN where Attribute : JKCJPKONAAO
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly HDHIMOFHFJL AHADDDAMGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string KNOPFGAGMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> NFKDIPGGOOP;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x27ED010", Offset = "0x27EC210", VA = "0x1827ED010")]
	public ELPOILNOMIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x27ECA80", Offset = "0x27EBC80", VA = "0x1827ECA80", Slot = "4")]
	public bool BPCENLKELKP(int BEBJDDHDFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x27ECD00", Offset = "0x27EBF00", VA = "0x1827ECD00", Slot = "5")]
	public global::LCDGDDNFDOO<BaseClass> HKFPFLFCNHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x27ECC00", Offset = "0x27EBE00", VA = "0x1827ECC00", Slot = "7")]
	protected virtual bool GEHPNCMNMAI(Type NIFOGEBEDNG, int HOGIDFIOGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x27ECAE0", Offset = "0x27EBCE0", VA = "0x1827ECAE0", Slot = "8")]
	protected virtual int DONDOPHHNPE(Type NIFOGEBEDNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x27ECB70", Offset = "0x27EBD70", VA = "0x1827ECB70")]
	public void GAJKJBJLBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x27EC9E0", Offset = "0x27EBBE0", VA = "0x1827EC9E0", Slot = "6")]
	public void BNAKCAAHHPA(Type NIFOGEBEDNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LCDGDDNFDOO<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> KKLGILICPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> ABLJEAIANEI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> BMBGFGFIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2380", Offset = "0x3BE1580", VA = "0x183BE2380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3BE25B0", Offset = "0x3BE17B0", VA = "0x183BE25B0")]
	public LCDGDDNFDOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2740", Offset = "0x3BE1940", VA = "0x183BE2740")]
	public LCDGDDNFDOO(int FAPOEIDOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3BE22D0", Offset = "0x3BE14D0", VA = "0x183BE22D0")]
	internal void CPCILMEHKPA(int BEBJDDHDFCD, BaseClass ILPMCHGFIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F2AF50", Offset = "0x1F2A150", VA = "0x181F2AF50")]
	public bool BNLGNHCGMNI<T>(out BaseClass IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2230", Offset = "0x3BE1430", VA = "0x183BE2230")]
	public bool BNLGNHCGMNI(Type KBJJKACLINM, out BaseClass IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x21BA700", Offset = "0x21B9900", VA = "0x1821BA700")]
	public bool KHBOPMLHOFG(int BEBJDDHDFCD, out BaseClass IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F2BC60", Offset = "0x1F2AE60", VA = "0x181F2BC60")]
	public T MKEKGNKELBD<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2350", Offset = "0x3BE1550", VA = "0x183BE2350")]
	public BaseClass MKEKGNKELBD(Type EHFBBCGKJLP)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class JOCMNCLACPF : global::ELPOILNOMIJ<DEABIHNCNIC, CGCIGFDONLA>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5A234D0", Offset = "0x5A226D0", VA = "0x185A234D0")]
	public JOCMNCLACPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class MGDNCNCCOPC : global::ELPOILNOMIJ<FNCNKAKEKBP, CMBJNHHMHON>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5A240E0", Offset = "0x5A232E0", VA = "0x185A240E0")]
	public MGDNCNCCOPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class EDBNGINAKNF : global::ELPOILNOMIJ<AOMPPMBGCFH, NDDLLHHFIJF>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5A21E50", Offset = "0x5A21050", VA = "0x185A21E50")]
	public EDBNGINAKNF()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CGDKNMKPKIP(OOBCCNCEGNI.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> AFKPEPNHHAC;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7AF920", Offset = "0x7AEB20", VA = "0x1807AF920")]
		private ComponentSystemTypes(List<Type> AFKPEPNHHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5A21AE0", Offset = "0x5A20CE0", VA = "0x185A21AE0")]
		public static void GAJKJBJLBCF(List<Type> AFKPEPNHHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5A218A0", Offset = "0x5A20AA0", VA = "0x185A218A0")]
		private void BCOBHILEJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5A21B70", Offset = "0x5A20D70", VA = "0x185A21B70")]
		private bool GEHPNCMNMAI(Type NIFOGEBEDNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5A21BF0", Offset = "0x5A20DF0", VA = "0x185A21BF0")]
		private void GIABLIDFNHL(Type NIFOGEBEDNG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class HCIIOJALALA : KDBBKADLGNC
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5A22810", Offset = "0x5A21A10", VA = "0x185A22810", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase EIEDLCCHMCM();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5A227C0", Offset = "0x5A219C0", VA = "0x185A227C0")]
	protected ComponentSystemBase DEFFIGIMMDB(params ComponentSystemBase[] JBDCCFIPMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x226C5D0", Offset = "0x226B7D0", VA = "0x18226C5D0")]
	protected ComponentSystemBase DEFFIGIMMDB<T>(params ComponentSystemBase[] JBDCCFIPMAL) where T : KDBBKADLGNC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x226C670", Offset = "0x226B870", VA = "0x18226C670")]
	protected ComponentSystemBase DKIFHIMDLFC<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x226C670", Offset = "0x226B870", VA = "0x18226C670")]
	protected ComponentSystemBase LKIHJBGCCNG<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	protected HCIIOJALALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface GEOIKOPOIHO<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BPCENLKELKP(int BEBJDDHDFCD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::LCDGDDNFDOO<BaseClass> HKFPFLFCNHA();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class KDBBKADLGNC : DIJEOBLFIHC
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5A23540", Offset = "0x5A22740", VA = "0x185A23540", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public KDBBKADLGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class HDACKBGFGDN : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5A22850", Offset = "0x5A21A50", VA = "0x185A22850")]
	public ComponentDataFromEntity POBPFOGPFLN(int BEBJDDHDFCD, bool ANPMMNBJEGA = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5A228F0", Offset = "0x5A21AF0", VA = "0x185A228F0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0")]
	protected HDACKBGFGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class FEPOGEEKBIH : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0")]
	protected FEPOGEEKBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class MMOBGAEEAHF : HDACKBGFGDN
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5A24150", Offset = "0x5A23350", VA = "0x185A24150", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	protected void GGALHNMLAOJ(string MANKFIKGIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0")]
	protected MMOBGAEEAHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class FOOCHGPNGJE
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class DIJEOBLFIHC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	protected DIJEOBLFIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CGDKNMKPKIP(OOBCCNCEGNI.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5A26290", Offset = "0x5A25490", VA = "0x185A26290")]
		public static ComponentSystemGroup[] ADHJIGMHGBO(World PHAHHGAAFFH, KAGIAAMILBA PFHJFDKKPPJ = KAGIAAMILBA.Default, bool CKADGHLAKHI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5A270E0", Offset = "0x5A262E0", VA = "0x185A270E0")]
		private static Type[] PJJLLMLPLHE(KAGIAAMILBA PFHJFDKKPPJ, bool CKADGHLAKHI, ComponentSystemGroup[] CILJCNOBDBD, ComponentSystemGroup NLGCDDBCBPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5A26360", Offset = "0x5A25560", VA = "0x185A26360")]
		private static ComponentSystemGroup[] BKLNAAHFHOJ(World PHAHHGAAFFH, out ComponentSystemGroup NLGCDDBCBPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5A26670", Offset = "0x5A25870", VA = "0x185A26670")]
		internal static bool CKMNJIHBPFH(NMAPNONNEIE PANELIGGJGM, out BMJFDFMNLOB PMAEFDBNJAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5A268F0", Offset = "0x5A25AF0", VA = "0x185A268F0")]
		private static ComponentSystemGroup DLENEOLJADC(Type NIFOGEBEDNG, World PHAHHGAAFFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5A26A30", Offset = "0x5A25C30", VA = "0x185A26A30")]
		private static ComponentSystemGroup[] LLIDOFNOAEF(Type[] AFKPEPNHHAC, World PHAHHGAAFFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5A26BC0", Offset = "0x5A25DC0", VA = "0x185A26BC0")]
		internal static void PFPDGACDJKK(World PHAHHGAAFFH, Type[] INCLEPHBMOF, ComponentSystemGroup[] CILJCNOBDBD, ComponentSystemGroup NLGCDDBCBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5A269D0", Offset = "0x5A25BD0", VA = "0x185A269D0")]
		internal static bool EALFGNFHKEN(ComponentSystemBase NHEJJBLKANC, ComponentSystemGroup[] CILJCNOBDBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5A26B60", Offset = "0x5A25D60", VA = "0x185A26B60")]
		private static void MOAHHIHACGG(ComponentSystemGroup[] CILJCNOBDBD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct NIBBBDPDDEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> DBFMCDMHPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> JBDCCFIPMAL;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7AF930", Offset = "0x7AEB30", VA = "0x1807AF930")]
	public NIBBBDPDDEC(Dictionary<Type, List<Type>> DBFMCDMHPMN, HashSet<Type> JBDCCFIPMAL)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CGDKNMKPKIP(OOBCCNCEGNI.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class GHONDEPMFMO : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x873910", Offset = "0x872B10", VA = "0x180873910")]
			[DebuggerHidden]
			public GHONDEPMFMO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5A226E0", Offset = "0x5A218E0", VA = "0x185A226E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5A22440", Offset = "0x5A21640", VA = "0x185A22440", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5A22770", Offset = "0x5A21970", VA = "0x185A22770")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5A226A0", Offset = "0x5A218A0", VA = "0x185A226A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5A225F0", Offset = "0x5A217F0", VA = "0x185A225F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5A225F0", Offset = "0x5A217F0", VA = "0x185A225F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct NEEECMIGPLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type BMOHKBLFNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private KAGIAAMILBA PFHJFDKKPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool ALABOLNKNPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool OOLLJIJEBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool CKADGHLAKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> CDNFNCAGMBM;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5A27FA0", Offset = "0x5A271A0", VA = "0x185A27FA0")]
		public static RRFilterWorldSystems GPGHDDABLEF()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5A27E30", Offset = "0x5A27030", VA = "0x185A27E30")]
		public RRFilterWorldSystems CKFDKKKNKKG(KAGIAAMILBA PANELIGGJGM)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5A274D0", Offset = "0x5A266D0", VA = "0x185A274D0")]
		public RRFilterWorldSystems BMDEOMMDAMO(IEnumerable<Type> AFKPEPNHHAC)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5A28170", Offset = "0x5A27370", VA = "0x185A28170")]
		public RRFilterWorldSystems NHMBIFFEKCN(bool OCLCONAPCEC)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5A27FC0", Offset = "0x5A271C0", VA = "0x185A27FC0")]
		public RRFilterWorldSystems JMMLPPMJEKA(bool JOOKODGMFNI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5A27FD0", Offset = "0x5A271D0", VA = "0x185A27FD0")]
		public NIBBBDPDDEC KAMOKLMIFJO(Type[] GBOAIBBIMEA)
		{
			return default(NIBBBDPDDEC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5A28180", Offset = "0x5A27380", VA = "0x185A28180")]
		[IteratorStateMachine(typeof(GHONDEPMFMO))]
		internal IEnumerable<Type> NPAFFGJMEFA(IEnumerable<Type> AFKPEPNHHAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5A27B50", Offset = "0x5A26D50", VA = "0x185A27B50")]
		internal Dictionary<Type, List<Type>> CCLPEPHNBIJ(IEnumerable<Type> AFKPEPNHHAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5A28060", Offset = "0x5A27260", VA = "0x185A28060")]
		private void MCMELIFEAPJ(Dictionary<Type, List<Type>> OKKDPEMOHMC, Type NIFOGEBEDNG, Type HGGLAIPDLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5A28210", Offset = "0x5A27410", VA = "0x185A28210")]
		internal HashSet<Type> PGLFMPBCCGA(IEnumerable<Type> CILJCNOBDBD, Dictionary<Type, List<Type>> GHKLFJFOHKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5A27510", Offset = "0x5A26710", VA = "0x185A27510")]
		internal bool CCDEIFNBOJN(Type NIFOGEBEDNG, KAGIAAMILBA PFHJFDKKPPJ, bool CKADGHLAKHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5A27E40", Offset = "0x5A27040", VA = "0x185A27E40")]
		[CompilerGenerated]
		internal static void DMEJKGHHHLI(Type NIFOGEBEDNG, ref NEEECMIGPLB P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class NFNKOJGGGKK
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool HOCFFNMCCJJ;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5A251B0", Offset = "0x5A243B0", VA = "0x185A251B0")]
	public static void IHEKMEOIBOI(bool COPOILGLIAJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5A24FF0", Offset = "0x5A241F0", VA = "0x185A24FF0")]
	private static void IFCHEBOBMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class JBDJNHCJNDG
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5A22C80", Offset = "0x5A21E80", VA = "0x185A22C80")]
	public static ulong IJOJOCCIFDJ(Type NIFOGEBEDNG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5A22BC0", Offset = "0x5A21DC0", VA = "0x185A22BC0")]
	public static ulong IJOJOCCIFDJ(string NDHBLLBAIBG)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CGDKNMKPKIP(OOBCCNCEGNI.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct CKONNCMKKPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong OEJDJCFDLHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong DAKNJDONIAO;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x1BFA230", Offset = "0x1BF9430", VA = "0x181BFA230")]
			public CKONNCMKKPA(ulong PAPIEPKLLBA, ulong EKEJMNDFIHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5A21440", Offset = "0x5A20640", VA = "0x185A21440", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> AHBGGFKLIBF;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static CKONNCMKKPA[] PDAAEIAOLKG;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool HOCFFNMCCJJ;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5A284A0", Offset = "0x5A276A0", VA = "0x185A284A0")]
		public static ulong CNDPJIBAFEG(int BEBJDDHDFCD)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5A28570", Offset = "0x5A27770", VA = "0x185A28570")]
		public static int CPDCGOOBBIG(ulong EKEJMNDFIHH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5A288D0", Offset = "0x5A27AD0", VA = "0x185A288D0")]
		public static void IHEKMEOIBOI(bool COPOILGLIAJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5A287F0", Offset = "0x5A279F0", VA = "0x185A287F0")]
		private static void HJNGBCIDBHN(int KHJMBNFLCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5A28AC0", Offset = "0x5A27CC0", VA = "0x185A28AC0")]
		private static void ILGAOMPPLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5A28710", Offset = "0x5A27910", VA = "0x185A28710")]
		private static CKONNCMKKPA HJGBGOFKEMP(Type NIFOGEBEDNG)
		{
			return default(CKONNCMKKPA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5A28500", Offset = "0x5A27700", VA = "0x185A28500")]
		private static ulong CNEEHLEFCCC(Type NIFOGEBEDNG, ulong EKEJMNDFIHH)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5A28EE0", Offset = "0x5A280E0", VA = "0x185A28EE0")]
		private static void KLAJPBENNCG(in CKONNCMKKPA BJNKKHCNLKF, TypeManager.TypeInfo BCOMPDLNKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5A28DE0", Offset = "0x5A27FE0", VA = "0x185A28DE0")]
		private static void KKBJFCOOPCC(CKONNCMKKPA BCOMPDLNKFJ, int BEBJDDHDFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5A28620", Offset = "0x5A27820", VA = "0x185A28620")]
		private static void EHJMACOBFIL(CKONNCMKKPA BCOMPDLNKFJ, int BEBJDDHDFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5A29100", Offset = "0x5A28300", VA = "0x185A29100")]
		private static CKONNCMKKPA MODFIOJLEEB(int BEBJDDHDFCD)
		{
			return default(CKONNCMKKPA);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5A28700", Offset = "0x5A27900", VA = "0x185A28700")]
		private static int EJBNMMKOPKO(int BEBJDDHDFCD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class LMOBFEFJFHF
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly MGDNCNCCOPC FBHNCIIGAHP;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly EDBNGINAKNF JBOOKIHEOMO;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly JOCMNCLACPF FJHGJJDLGLC;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> EGILEIAHNHN;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool HOCFFNMCCJJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::GEOIKOPOIHO<CMBJNHHMHON> IOCNLPFAGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5A23E50", Offset = "0x5A23050", VA = "0x185A23E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::GEOIKOPOIHO<NDDLLHHFIJF> DOMPNFNENBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5A23DF0", Offset = "0x5A22FF0", VA = "0x185A23DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::GEOIKOPOIHO<CGCIGFDONLA> LHGKBMJBKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5A238E0", Offset = "0x5A22AE0", VA = "0x185A238E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5A23940", Offset = "0x5A22B40", VA = "0x185A23940")]
	public static void IHEKMEOIBOI(bool COPOILGLIAJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5A23860", Offset = "0x5A22A60", VA = "0x185A23860")]
	public static Type[] BFKFKKLOBHN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class MOOLGAKMKOO
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> EMPIMLLHOJE;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool HOCFFNMCCJJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5A248F0", Offset = "0x5A23AF0", VA = "0x185A248F0")]
	public static int BDCDBBPEAIJ(int BEBJDDHDFCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5A24A60", Offset = "0x5A23C60", VA = "0x185A24A60")]
	public static void IHEKMEOIBOI(bool COPOILGLIAJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5A24B00", Offset = "0x5A23D00", VA = "0x185A24B00")]
	private static void IHMKABHIBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5A24990", Offset = "0x5A23B90", VA = "0x185A24990")]
	private static int CNJEBANALBO(Type NIFOGEBEDNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5A249E0", Offset = "0x5A23BE0", VA = "0x185A249E0")]
	private static void GLBPPAIACJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class NNHDOGKABEI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World COKIOKOGLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly DKCBHGMJMEO ILPMCHGFIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] CILJCNOBDBD;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World JCJGOFJEAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World ADMAJPELGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager KBDBPGCEONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x17A7C40", Offset = "0x17A6E40", VA = "0x1817A7C40")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public DKCBHGMJMEO GHECNMHOJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::LCDGDDNFDOO<CMBJNHHMHON> IOCNLPFAGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7B43F0", Offset = "0x7B35F0", VA = "0x1807B43F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::LCDGDDNFDOO<NDDLLHHFIJF> DOMPNFNENBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x814E40", Offset = "0x814040", VA = "0x180814E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::LCDGDDNFDOO<CGCIGFDONLA> LHGKBMJBKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x813690", Offset = "0x812890", VA = "0x180813690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x814E30", Offset = "0x814030", VA = "0x180814E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x16E9530", Offset = "0x16E8730", VA = "0x1816E9530")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] PMKIELJPEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5A254D0", Offset = "0x5A246D0", VA = "0x185A254D0")]
	public static NNHDOGKABEI DEGGELMFACH(string KNOPFGAGMCN, NMAPNONNEIE PANELIGGJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5A25CE0", Offset = "0x5A24EE0", VA = "0x185A25CE0")]
	public NNHDOGKABEI(string KNOPFGAGMCN, NMAPNONNEIE PANELIGGJGM = NMAPNONNEIE.Simulation, KAGIAAMILBA PFHJFDKKPPJ = KAGIAAMILBA.Default, bool COPOILGLIAJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5A25CC0", Offset = "0x5A24EC0", VA = "0x185A25CC0")]
	public ComponentSystemBase NMKJCCCIELE(Type NIFOGEBEDNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1C82D40", Offset = "0x1C81F40", VA = "0x181C82D40")]
	public T NMKJCCCIELE<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5A25B80", Offset = "0x5A24D80", VA = "0x185A25B80")]
	public void NIHOIIDGMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5A25890", Offset = "0x5A24A90", VA = "0x185A25890")]
	public void EHFAKOPKBHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5A25410", Offset = "0x5A24610", VA = "0x185A25410")]
	public void BDPANICOEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5A259D0", Offset = "0x5A24BD0", VA = "0x185A259D0")]
	public void HHMAHEAAPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5A25A30", Offset = "0x5A24C30", VA = "0x185A25A30")]
	public void LBHOLNKPHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5A253B0", Offset = "0x5A245B0", VA = "0x185A253B0")]
	public void APEBBMBKOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5A25470", Offset = "0x5A24670", VA = "0x185A25470")]
	public void BOCEBLMBJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5A25A90", Offset = "0x5A24C90", VA = "0x185A25A90")]
	public void LLKJLGCPMKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5A25B20", Offset = "0x5A24D20", VA = "0x185A25B20")]
	public void MHPCINNLKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5A25970", Offset = "0x5A24B70", VA = "0x185A25970")]
	public void GLKMAPHLIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5A25BE0", Offset = "0x5A24DE0", VA = "0x185A25BE0")]
	internal void NIOIPHAIHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5A258F0", Offset = "0x5A24AF0", VA = "0x185A258F0")]
	private bool FPADJPLHKGD(ComponentSystemGroup CIFHMNKCLNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5A25550", Offset = "0x5A24750", VA = "0x185A25550")]
	private void DOOLPENDPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5A252A0", Offset = "0x5A244A0", VA = "0x185A252A0")]
	private ComponentSystemGroup[] ADHJIGMHGBO(KAGIAAMILBA PFHJFDKKPPJ, bool CKADGHLAKHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5A25820", Offset = "0x5A24A20", VA = "0x185A25820", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum NMAPNONNEIE
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
public sealed class FAPBCKHKILM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public KAGIAAMILBA FMJHNCCGMOE;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum KAGIAAMILBA
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
public interface BMJFDFMNLOB
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type MEKANAKNDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] NHIDJJDLKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class NKLAOGBFFIL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool MHONGNIGEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	protected NKLAOGBFFIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class FBFMLLJBOHO : NKLAOGBFFIL
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public FBFMLLJBOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class MGAMFCCKDIP : NKLAOGBFFIL
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public MGAMFCCKDIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class AKLNEOINLAE : NKLAOGBFFIL
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public AKLNEOINLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class BBJFHGJFLOG : NKLAOGBFFIL
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public BBJFHGJFLOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class HFNCMAAMEAD : NKLAOGBFFIL
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public HFNCMAAMEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class LCBCGAGCLLI : NKLAOGBFFIL
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public LCBCGAGCLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class DFJBFFLDIPJ : NKLAOGBFFIL
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public DFJBFFLDIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class AOMBNDEGEDH : NKLAOGBFFIL
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public AOMBNDEGEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class BIENIBHOMDC : NKLAOGBFFIL
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public BIENIBHOMDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class NOMOGFCIADP : IAKJECEAFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public NOMOGFCIADP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class EPPHCBJCGJF : IAKJECEAFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public EPPHCBJCGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class ACFFGDPLANH : IAKJECEAFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public ACFFGDPLANH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class PLPDNCCBGEC : IAKJECEAFLF
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public PLPDNCCBGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[CFJADOACGIL(IHBBGOJDEFH.Application)]
public class IAKJECEAFLF : NKLAOGBFFIL
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool MHONGNIGEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5A20F10", Offset = "0x5A20110", VA = "0x185A20F10")]
	public IAKJECEAFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class CPDNKOEGHHF : ECLDMCLCKCC
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public CPDNKOEGHHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class EMEPFKANBCO
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void PMENNGBAGEA<From, To>(From CKOEFCDNGOI, ref To CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class FKPENGDBEDJ<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static PMENNGBAGEA<From, To> LMINEBCLHGO;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public FKPENGDBEDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5A21EC0", Offset = "0x5A210C0", VA = "0x185A21EC0")]
	static EMEPFKANBCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x20D88E0", Offset = "0x20D7AE0", VA = "0x1820D88E0")]
	public static void AMBODMNCCMK<T>(PMENNGBAGEA<T, T> BPKEANIGKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x20D87C0", Offset = "0x20D79C0", VA = "0x1820D87C0")]
	public static void AMBODMNCCMK<From, To>(PMENNGBAGEA<From, To> BPKEANIGKON, PMENNGBAGEA<To, From> NCNJBBIMFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x20D8770", Offset = "0x20D7970", VA = "0x1820D8770")]
	public static void AMBODMNCCMK<From, To>(PMENNGBAGEA<From, To> LMINEBCLHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x20DD290", Offset = "0x20DC490", VA = "0x1820DD290")]
	public static PMENNGBAGEA<From, To> DBKFCBDGGCB<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x20DBFB0", Offset = "0x20DB1B0", VA = "0x1820DBFB0")]
	public static void BHKDGPNKFCO<From, To>(From CKOEFCDNGOI, ref To CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class EEJKADCLIHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> KALDFGDGKFL;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x269EF50", Offset = "0x269E150", VA = "0x18269EF50")]
	public EEJKADCLIHN(NativeArray<EntityRemapUtility.EntityRemapInfo> KALDFGDGKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA00E0", Offset = "0x2A9F2E0", VA = "0x182AA00E0")]
	public Entity CCJIOLHNHBG(Entity GLLFHCCFIGK)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class IJOJHBGACMG
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> GIANOPFGABN;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5A229D0", Offset = "0x5A21BD0", VA = "0x185A229D0")]
	public static bool MNCJCJOPDMH(ulong NDFMMDHCKFC, uint EOGFAFNNICF, out string KNOPFGAGMCN)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct OHGNMFGEKCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int BCGMDEIHEMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int OLGKJALIAAI;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x856470", Offset = "0x855670", VA = "0x180856470")]
			public OHGNMFGEKCI(int GMEHLIHLGEH, int EOGFAFNNICF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct MOKLKIDHBJK
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch LKKCBBBBCOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long FEHMMEPKFIH;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long FFGMFOBNNNL
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x5A247D0", Offset = "0x5A239D0", VA = "0x185A247D0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long GPBFKOMFMJN
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5A24760", Offset = "0x5A23960", VA = "0x185A24760")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5A24830", Offset = "0x5A23A30", VA = "0x185A24830")]
			public static MOKLKIDHBJK OJFIFFKKFLH()
			{
				return default(MOKLKIDHBJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct JIOCMHAFDOG : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct HNOOAAGPOCI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* GDBJMPBLMML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly FKEJOECIDBF.ECKDBHEJFMC.GOELDJFNGAK GJJBCGJAJBF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly EEJKADCLIHN ABLKPOMPEKC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::LCDGDDNFDOO<NDDLLHHFIJF> LBBGMEJFNPF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int DJLHAINOAOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int IFLKNFOCJOL;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x5A22900", Offset = "0x5A21B00", VA = "0x185A22900")]
				public unsafe HNOOAAGPOCI(Unity.Entities.Archetype* GDBJMPBLMML, FKEJOECIDBF.ECKDBHEJFMC.GOELDJFNGAK GJJBCGJAJBF, EEJKADCLIHN ABLKPOMPEKC, global::LCDGDDNFDOO<NDDLLHHFIJF> LBBGMEJFNPF, int DJLHAINOAOG, int IFLKNFOCJOL = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5A22960", Offset = "0x5A21B60", VA = "0x185A22960")]
				public HNOOAAGPOCI(in HNOOAAGPOCI PCPEJHIMHJJ, int IFLKNFOCJOL)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly HNOOAAGPOCI[] DKIPBFCBBBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] PMPBEOKAGLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int CNCNFGDGNGE;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5A23390", Offset = "0x5A22590", VA = "0x185A23390")]
			public JIOCMHAFDOG(HNOOAAGPOCI[] DKIPBFCBBBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5A23060", Offset = "0x5A22260", VA = "0x185A23060", Slot = "4")]
			public void Invoke(int GMEHLIHLGEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5A22CB0", Offset = "0x5A21EB0", VA = "0x185A22CB0")]
			private void AGPNDJABNHB(in HNOOAAGPOCI PCPEJHIMHJJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5A230C0", Offset = "0x5A222C0", VA = "0x185A230C0")]
			private static void PGMDDAIPIBA(in HNOOAAGPOCI PCPEJHIMHJJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class KKCPFPLCHLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public FKEJOECIDBF asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::LCDGDDNFDOO<NDDLLHHFIJF> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public KKCPFPLCHLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5A237F0", Offset = "0x5A229F0", VA = "0x185A237F0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class KPHKPFCMDFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public FKEJOECIDBF.ECKDBHEJFMC.GOELDJFNGAK srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public KKCPFPLCHLH CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public KPHKPFCMDFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class FGDBONEDNKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public KPHKPFCMDFA CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public FGDBONEDNKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5A22240", Offset = "0x5A21440", VA = "0x185A22240")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly HDHIMOFHFJL KGPMGPHJKLD;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly HDHIMOFHFJL BOFJLNBFKDE;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly HDHIMOFHFJL FIGJGDNNNMF;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly HDHIMOFHFJL HLBGGFPLDDK;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool KOCNDFGAAJL;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static FKEJOECIDBF.ECKDBHEJFMC.CDDCBPCKAGC DMPOKOAKLPP;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5A2BAF0", Offset = "0x5A2ACF0", VA = "0x185A2BAF0")]
		private unsafe static bool IFMGPIMONIE(Unity.Entities.Archetype* AOOCNFHGCNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5A292E0", Offset = "0x5A284E0", VA = "0x185A292E0")]
		internal unsafe static Unity.Entities.Archetype*[] AKDDOKEGCGH(ref Unity.Entities.EntityComponentStore CKAOFCLAEDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5A29220", Offset = "0x5A28420", VA = "0x185A29220")]
		public static void AIBJBMGLFMD(NNHDOGKABEI PHAHHGAAFFH, out ByteString NDFFNBIIOEO, out NativeArray<EntityRemapUtility.EntityRemapInfo> NNLAFJIOMBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5A2AFC0", Offset = "0x5A2A1C0", VA = "0x185A2AFC0")]
		internal static void GINICFGBHNA(NNHDOGKABEI PHAHHGAAFFH, FKEJOECIDBF NAHLNNEGIOC, out NativeArray<EntityRemapUtility.EntityRemapInfo> NNLAFJIOMBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5A2BE70", Offset = "0x5A2B070", VA = "0x185A2BE70")]
		private unsafe static UnsafeHashMap<ulong, OHGNMFGEKCI> IOCEHDGKOPE(Unity.Entities.Archetype*[] KGGOIGJKIGO)
		{
			return default(UnsafeHashMap<ulong, OHGNMFGEKCI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A0B0", Offset = "0x5A292B0", VA = "0x185A2A0B0")]
		private static void BOGOCEDKFDD(FKEJOECIDBF NAHLNNEGIOC, UnsafeHashMap<ulong, OHGNMFGEKCI> FEMIHJEIKGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A5B0", Offset = "0x5A297B0", VA = "0x185A2A5B0")]
		private unsafe static void FIHBEPAGDGA(FKEJOECIDBF NAHLNNEGIOC, Unity.Entities.Archetype*[] KGGOIGJKIGO, UnsafeHashMap<ulong, OHGNMFGEKCI> FEMIHJEIKGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5A2BA80", Offset = "0x5A2AC80", VA = "0x185A2BA80")]
		private unsafe static int IAMCHCBIJND(Unity.Entities.Archetype*[] KGGOIGJKIGO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C860", Offset = "0x5A2BA60", VA = "0x185A2C860")]
		private unsafe static void NJKLLNNKMDD(FKEJOECIDBF NAHLNNEGIOC, Unity.Entities.Archetype*[] KGGOIGJKIGO, global::LCDGDDNFDOO<NDDLLHHFIJF> LBBGMEJFNPF, NativeArray<EntityRemapUtility.EntityRemapInfo> NNLAFJIOMBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5A2BC00", Offset = "0x5A2AE00", VA = "0x185A2BC00")]
		private static NativeArray<int> IGAEIEFAKNF(FKEJOECIDBF NAHLNNEGIOC)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5A2B6F0", Offset = "0x5A2A8F0", VA = "0x185A2B6F0")]
		private static Memory<EntityArchetype> HANNFPOABOP(FKEJOECIDBF NAHLNNEGIOC, NativeArray<int> AFKPEPNHHAC, EntityManager IIODDCGHDHF, out int GPNJPMPPPHE, out int GDGEHMLMCLN)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5A29D60", Offset = "0x5A28F60", VA = "0x185A29D60")]
		private unsafe static void BKJBMCOBPAP(Unity.Entities.Chunk* NPNPPPIAFOH, ReadOnlySpan<byte> NDFFNBIIOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5A29620", Offset = "0x5A28820", VA = "0x185A29620")]
		private static void BFEDFHAEEIM(FKEJOECIDBF NAHLNNEGIOC, NativeArray<int> AFKPEPNHHAC, Span<EntityArchetype> KGGOIGJKIGO, EntityManager IIODDCGHDHF, global::LCDGDDNFDOO<NDDLLHHFIJF> LBBGMEJFNPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5A294C0", Offset = "0x5A286C0", VA = "0x185A294C0")]
		private unsafe static void ALDFLKMIEKM(Unity.Entities.Chunk* DMDHEKMOMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C550", Offset = "0x5A2B750", VA = "0x185A2C550")]
		private unsafe static void NJCLPDNCCNB(FKEJOECIDBF.ECKDBHEJFMC.GOELDJFNGAK GDBJMPBLMML, int HBEKDJPJIAD, int MGJMONNFCDE, Unity.Entities.Chunk* NPNPPPIAFOH, FKEJOECIDBF NAHLNNEGIOC, NativeArray<int> AFKPEPNHHAC, global::LCDGDDNFDOO<NDDLLHHFIJF> LBBGMEJFNPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A8E0", Offset = "0x5A29AE0", VA = "0x185A2A8E0")]
		public static void FNDBLMMHNCM(NNHDOGKABEI PHAHHGAAFFH, in ByteString NDFFNBIIOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A970", Offset = "0x5A29B70", VA = "0x185A2A970")]
		public static void FNDBLMMHNCM(EntityManager IIODDCGHDHF, global::LCDGDDNFDOO<NDDLLHHFIJF> LBBGMEJFNPF, in ByteString NDFFNBIIOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C100", Offset = "0x5A2B300", VA = "0x185A2C100")]
		private static bool LEDHOAHGCED(Type NIFOGEBEDNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A300", Offset = "0x5A29500", VA = "0x185A2A300")]
		private static void EEKBACMGAJB(TypeManager.TypeInfo BCOMPDLNKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C3C0", Offset = "0x5A2B5C0", VA = "0x185A2C3C0")]
		private unsafe static int LLCENLBHPIB(Unity.Entities.Archetype*[] KGGOIGJKIGO, NativeArray<EntityRemapUtility.EntityRemapInfo> NNLAFJIOMBI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5A29540", Offset = "0x5A28740", VA = "0x185A29540")]
		private static int BDCDBBPEAIJ(int BEBJDDHDFCD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A260", Offset = "0x5A29460", VA = "0x185A2A260")]
		private static ulong CNDPJIBAFEG(int BEBJDDHDFCD)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class MOJGCBGPANE
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5A24490", Offset = "0x5A23690", VA = "0x185A24490")]
	private unsafe static Span<byte> IDEMCOJMFMK(Unity.Entities.Chunk* DMDHEKMOMJJ, int DJLHAINOAOG)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x13BCF70", Offset = "0x13BC170", VA = "0x1813BCF70")]
	public unsafe static Span<T> OHLOMHKKFLH<T>(Unity.Entities.Chunk* DMDHEKMOMJJ, int DJLHAINOAOG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x13BCF30", Offset = "0x13BC130", VA = "0x1813BCF30")]
	public static Span<T> OHLOMHKKFLH<T>(this ref Unity.Entities.Chunk DMDHEKMOMJJ, int DJLHAINOAOG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5A24180", Offset = "0x5A23380", VA = "0x185A24180")]
	public unsafe static Span<Entity> EMEMAGBOLBO(Unity.Entities.Chunk* DMDHEKMOMJJ)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5A241F0", Offset = "0x5A233F0", VA = "0x185A241F0")]
	public unsafe static void GLBPPAIACJF(Unity.Entities.Chunk* DMDHEKMOMJJ, int DJLHAINOAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5A24630", Offset = "0x5A23830", VA = "0x185A24630")]
	public static Entity LGNPGPLDNJA(this EntityQuery ADGIOFAMOGF)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : HDLOHLLNPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CEE0", Offset = "0x5A2C0E0", VA = "0x185A2CEE0", Slot = "4")]
		public sealed override void GAJKJBJLBCF()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
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
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
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

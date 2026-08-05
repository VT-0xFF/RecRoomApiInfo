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
		[Cpp2IlInjected.Address(RVA = "0x5DFFCA0", Offset = "0x5DFF0A0", VA = "0x185DFFCA0")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E00A00", Offset = "0x5DFFE00", VA = "0x185E00A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E00A70", Offset = "0x5DFFE70", VA = "0x185E00A70")]
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
			[Cpp2IlInjected.Address(RVA = "0x37945C0", Offset = "0x37939C0", VA = "0x1837945C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2199D00", Offset = "0x2199100", VA = "0x182199D00")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2199530", Offset = "0x2198930", VA = "0x182199530")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2199630", Offset = "0x2198A30", VA = "0x182199630")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2199A30", Offset = "0x2198E30", VA = "0x182199A30")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E00A90", Offset = "0x5DFFE90", VA = "0x185E00A90")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct AEFDFDOMBNM<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FBJPLOGFHKH : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::AEFDFDOMBNM<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x735A00", Offset = "0x734E00", VA = "0x180735A00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2429690", Offset = "0x2428A90", VA = "0x182429690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEB70", Offset = "0x1DCDF70", VA = "0x181DCEB70")]
		[DebuggerHidden]
		public FBJPLOGFHKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x24294B0", Offset = "0x24288B0", VA = "0x1824294B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2429650", Offset = "0x2428A50", VA = "0x182429650", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> HPANBHPHLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream NEHKLODBFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream GNNJCMAKGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf KNOEGBEJAIO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int JJINKJIBOKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x735750", Offset = "0x734B50", VA = "0x180735750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B97700", Offset = "0x2B96B00", VA = "0x182B97700")]
	private AEFDFDOMBNM(byte[] NPOGECPDPEK, Action<Protobuf> HPANBHPHLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x252BA70", Offset = "0x252AE70", VA = "0x18252BA70")]
	public static global::AEFDFDOMBNM<Protobuf> IDIKGABNBEI<Data>(ReadOnlySpan<byte> EICPLPLLHGP, ReadOnlySpan<Data> BNJGAHEFJPB, Action<Protobuf> HPANBHPHLHP)
	{
		return default(global::AEFDFDOMBNM<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B97570", Offset = "0x2B96970", VA = "0x182B97570", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2B975B0", Offset = "0x2B969B0", VA = "0x182B975B0", Slot = "4")]
	[IteratorStateMachine(typeof(global::AEFDFDOMBNM<>.FBJPLOGFHKH))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2B976B0", Offset = "0x2B96AB0", VA = "0x182B976B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NJBGCNCAAGP<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] NPOGECPDPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf KNOEGBEJAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream NEHKLODBFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream FGODMGOOOAE;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x349D870", Offset = "0x349CC70", VA = "0x18349D870")]
	private NJBGCNCAAGP(byte[] NPOGECPDPEK, in Protobuf KNOEGBEJAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x159D3B0", Offset = "0x159C7B0", VA = "0x18159D3B0")]
	public static global::NJBGCNCAAGP<Protobuf> IDIKGABNBEI<T>(ReadOnlySpan<T> BNJGAHEFJPB)
	{
		return default(global::NJBGCNCAAGP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x349D840", Offset = "0x349CC40", VA = "0x18349D840")]
	public void HMLHHGOKLBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x349D680", Offset = "0x349CA80", VA = "0x18349D680")]
	public ByteString CPKNNIJFJGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x349D710", Offset = "0x349CB10", VA = "0x18349D710", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OPJGAAMMPBH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream NEHKLODBFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream GNNJCMAKGML;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E04990", Offset = "0x5E03D90", VA = "0x185E04990", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct EHNHEDMEEPP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] NPOGECPDPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream NEHKLODBFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream FGODMGOOOAE;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E008D0", Offset = "0x5DFFCD0", VA = "0x185E008D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FCPBIAEPICB
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public static void FBLAEOGELJL(this KLBHBMBPLOA JFFPIFJCILI, NativeArray<Entity> ABBIPALBHCK, [Optional][CallerFilePath] string OHBABGDFGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public static void FBLAEOGELJL(this KLBHBMBPLOA JFFPIFJCILI, string AMNLGEBHFHK, NativeArray<Entity> ABBIPALBHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public static void FBLAEOGELJL(this KLBHBMBPLOA JFFPIFJCILI, string OHBABGDFGKH, NativeArray<Entity> ABBIPALBHCK, bool DGJHENDBKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public static void MLBLCNKHBGE(this KLBHBMBPLOA JFFPIFJCILI, NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> EOPPFFEOLEM, [Optional][CallerFilePath] string OHBABGDFGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public static void MLBLCNKHBGE(this KLBHBMBPLOA JFFPIFJCILI, string OHBABGDFGKH, NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> EOPPFFEOLEM, bool DGJHENDBKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2613D30", Offset = "0x2613130", VA = "0x182613D30")]
	public static void IODBKODCPBL<T>(this KLBHBMBPLOA JFFPIFJCILI, string AMNLGEBHFHK, NativeArray<Entity> ABBIPALBHCK, NativeList<T> HIDEHJGLNHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2613CF0", Offset = "0x26130F0", VA = "0x182613CF0")]
	public static void IODBKODCPBL<T>(this KLBHBMBPLOA JFFPIFJCILI, string AMNLGEBHFHK, NativeArray<Entity> ABBIPALBHCK, NativeArray<T> HIDEHJGLNHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public static void IODBKODCPBL<T>(this KLBHBMBPLOA JFFPIFJCILI, string OHBABGDFGKH, NativeArray<Entity> ABBIPALBHCK, NativeArray<T> HIDEHJGLNHO, bool DGJHENDBKJI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2613C80", Offset = "0x2613080", VA = "0x182613C80")]
	public static void DKBHCEINAKG<T>(this KLBHBMBPLOA JFFPIFJCILI, NativeList<T> HIDEHJGLNHO, [Optional][CallerFilePath] string OHBABGDFGKH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2613C50", Offset = "0x2613050", VA = "0x182613C50")]
	public static void DKBHCEINAKG<T>(this KLBHBMBPLOA JFFPIFJCILI, NativeArray<T> HIDEHJGLNHO, [Optional][CallerFilePath] string OHBABGDFGKH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public static void DKBHCEINAKG<T>(this KLBHBMBPLOA JFFPIFJCILI, string OHBABGDFGKH, NativeArray<T> HIDEHJGLNHO, bool DGJHENDBKJI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public static void ALGHBCBHCJJ(this KLBHBMBPLOA JFFPIFJCILI, EntityQuery ANBHGOBNOFE, [Optional][CallerFilePath] string OHBABGDFGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public static void ALGHBCBHCJJ(this KLBHBMBPLOA JFFPIFJCILI, string AMNLGEBHFHK, EntityQuery ANBHGOBNOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	public static void ALGHBCBHCJJ(this KLBHBMBPLOA JFFPIFJCILI, string OHBABGDFGKH, EntityQuery ANBHGOBNOFE, bool DGJHENDBKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2613DC0", Offset = "0x26131C0", VA = "0x182613DC0")]
	public static void NAIDDCLMOAL<T, T2>(this KLBHBMBPLOA JFFPIFJCILI, string AMNLGEBHFHK, EntityQuery ANBHGOBNOFE) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	private static void NAIDDCLMOAL<T, T2>(this KLBHBMBPLOA JFFPIFJCILI, string OHBABGDFGKH, EntityQuery ANBHGOBNOFE, bool DGJHENDBKJI) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NIJKBPKBPOC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GELFNNAOOFF PIBPGDOMAAD
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
public interface AJNLODPELOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKEFDKDJLFA(Entity LCLDFKAJPDK, object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HONEOLFKKMC(Entity LCLDFKAJPDK, object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MJNHCKEGDDK(Entity LCLDFKAJPDK);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MJNHCKEGDDK(GELFNNAOOFF IGELLPOEMHM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> KGDGMLBLPJG(Entity LCLDFKAJPDK);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BHCJBLFDFCM(Entity LCLDFKAJPDK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MIOAAOMMLGI<TComponentData, TValue> : global::OOEJJHOEKAD<TValue>, IDisposable where TComponentData : struct, NIJKBPKBPOC
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class GCLPMNAMPOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> BDHPAGCMKHB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int JAMIBFCLJNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1621CA0", Offset = "0x16210A0", VA = "0x181621CA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3107920", Offset = "0x3106D20", VA = "0x183107920")]
		public bool DGDIKMJNIOG(out TValue LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3107870", Offset = "0x3106C70", VA = "0x183107870")]
		public void AGMLDLCGDGN(object MIFCLBEAOPM, TValue LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x31079E0", Offset = "0x3106DE0", VA = "0x1831079E0")]
		public bool FJEBMLODAAK(object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3107A60", Offset = "0x3106E60", VA = "0x183107A60")]
		public int JPAOIDBBCIF(object MIFCLBEAOPM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3107B10", Offset = "0x3106F10", VA = "0x183107B10")]
		public GCLPMNAMPOH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<GCLPMNAMPOH> OEFGDAGFKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::EAJFHNJEBAG<GELFNNAOOFF, GCLPMNAMPOH> JLMGALPCCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager MABCFMECCKD;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B265B0", Offset = "0x2B259B0", VA = "0x182B265B0")]
	public MIOAAOMMLGI(EntityManager MABCFMECCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B26010", Offset = "0x2B25410", VA = "0x182B26010", Slot = "4")]
	public void CKEFDKDJLFA(Entity LCLDFKAJPDK, object MIFCLBEAOPM, TValue LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B262D0", Offset = "0x2B256D0", VA = "0x182B262D0", Slot = "5")]
	public bool HONEOLFKKMC(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2B26130", Offset = "0x2B25530", VA = "0x182B26130", Slot = "6")]
	public bool DGDIKMJNIOG(Entity LCLDFKAJPDK, out TValue LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B26200", Offset = "0x2B25600", VA = "0x182B26200", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2B25F90", Offset = "0x2B25390", VA = "0x182B25F90")]
	private void AFAPAFCNBIM(GCLPMNAMPOH GAHFKLMJAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2B26440", Offset = "0x2B25840", VA = "0x182B26440")]
	private bool LHOMDJDAFHA(Entity LCLDFKAJPDK, out GELFNNAOOFF IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B26220", Offset = "0x2B25620", VA = "0x182B26220")]
	private void EJBKMMNEGKG(Entity LCLDFKAJPDK, GELFNNAOOFF IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B262B0", Offset = "0x2B256B0", VA = "0x182B262B0")]
	private bool FCALEKGFDAM(GELFNNAOOFF IGELLPOEMHM, out GCLPMNAMPOH GAHFKLMJAGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2B264F0", Offset = "0x2B258F0", VA = "0x182B264F0")]
	private GCLPMNAMPOH MEMAEODCOBL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OOEJJHOEKAD<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKEFDKDJLFA(Entity LCLDFKAJPDK, object MIFCLBEAOPM, TValue LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HONEOLFKKMC(Entity LCLDFKAJPDK, object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DGDIKMJNIOG(Entity LCLDFKAJPDK, out TValue LPJDDLMPNCG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GELFNNAOOFF : global::CMECDGBHMLE<GELFNNAOOFF>, AHPPOODHHGC, IEquatable<GELFNNAOOFF>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly GELFNNAOOFF LGIPBIEPLIP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int CMHFEELAEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8772D0", VA = "0x180877ED0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xBF6690", Offset = "0xBF5A90", VA = "0x180BF6690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int PELKNHEANOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x899ED0", Offset = "0x8992D0", VA = "0x180899ED0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xBF66A0", Offset = "0xBF5AA0", VA = "0x180BF66A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E00D60", Offset = "0x5E00160", VA = "0x185E00D60", Slot = "8")]
	public bool Equals(GELFNNAOOFF MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E00DB0", Offset = "0x5E001B0", VA = "0x185E00DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NFKGLAFFMGG<T> : AJNLODPELOG, IDisposable where T : struct, NIJKBPKBPOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> OEFGDAGFKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::EAJFHNJEBAG<GELFNNAOOFF, HashSet<object>> JLMGALPCCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager MABCFMECCKD;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x26E9870", Offset = "0x26E8C70", VA = "0x1826E9870")]
	public NFKGLAFFMGG(EntityManager MABCFMECCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26E71A0", Offset = "0x26E65A0", VA = "0x1826E71A0", Slot = "4")]
	public bool CKEFDKDJLFA(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x26E7970", Offset = "0x26E6D70", VA = "0x1826E7970", Slot = "5")]
	public bool HONEOLFKKMC(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x26E91D0", Offset = "0x26E85D0", VA = "0x1826E91D0", Slot = "6")]
	public bool MJNHCKEGDDK(Entity LCLDFKAJPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x26E9390", Offset = "0x26E8790", VA = "0x1826E9390", Slot = "7")]
	public bool MJNHCKEGDDK(GELFNNAOOFF IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x26E8A30", Offset = "0x26E7E30", VA = "0x1826E8A30", Slot = "8")]
	public IEnumerable<object> KGDGMLBLPJG(Entity LCLDFKAJPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x26E84B0", Offset = "0x26E78B0", VA = "0x1826E84B0", Slot = "11")]
	public IEnumerable<object> KGDGMLBLPJG(GELFNNAOOFF IGELLPOEMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C50", Offset = "0x26E6050", VA = "0x1826E6C50", Slot = "9")]
	public bool BHCJBLFDFCM(Entity LCLDFKAJPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x26E75E0", Offset = "0x26E69E0", VA = "0x1826E75E0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26E6A00", Offset = "0x26E5E00", VA = "0x1826E6A00")]
	private void AFAPAFCNBIM(HashSet<object> GAHFKLMJAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26E8D70", Offset = "0x26E8170", VA = "0x1826E8D70")]
	private bool LHOMDJDAFHA(Entity LCLDFKAJPDK, out GELFNNAOOFF IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x26E83C0", Offset = "0x26E77C0", VA = "0x1826E83C0")]
	private bool KCJNAEPDGFL(Entity LCLDFKAJPDK, out GELFNNAOOFF IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x26E9750", Offset = "0x26E8B50", VA = "0x1826E9750")]
	private void PAHOCGJANJP(Entity LCLDFKAJPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x26E77C0", Offset = "0x26E6BC0", VA = "0x1826E77C0")]
	private void EJBKMMNEGKG(Entity LCLDFKAJPDK, GELFNNAOOFF IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x26E95D0", Offset = "0x26E89D0", VA = "0x1826E95D0")]
	private bool OFNAKDLDNAG(GELFNNAOOFF IGELLPOEMHM, out HashSet<object> GAHFKLMJAGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x26E8F50", Offset = "0x26E8350", VA = "0x1826E8F50")]
	private HashSet<object> MEMAEODCOBL()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PHBPMKLKJGI : global::ADGHADFNANA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E04AE0", Offset = "0x5E03EE0", VA = "0x185E04AE0", Slot = "4")]
	public float OOIENOFBEMC(float3 LPJDDLMPNCG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FIJONPCOICI : global::ADGHADFNANA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E00C80", Offset = "0x5E00080", VA = "0x185E00C80", Slot = "4")]
	public float OOIENOFBEMC(float3 LPJDDLMPNCG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GEIDAJPHBOI : global::ADGHADFNANA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5E00D40", Offset = "0x5E00140", VA = "0x185E00D40", Slot = "4")]
	public float OOIENOFBEMC(float3 LPJDDLMPNCG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct AMGIBFEFANC : global::ADGHADFNANA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x103B490", Offset = "0x103A890", VA = "0x18103B490", Slot = "4")]
	public int OOIENOFBEMC(int3 LPJDDLMPNCG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LINMJEFDBPF : global::ADGHADFNANA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2BC61A0", Offset = "0x2BC55A0", VA = "0x182BC61A0", Slot = "4")]
	public int OOIENOFBEMC(int3 LPJDDLMPNCG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct HGMCOCMOPIN : global::ADGHADFNANA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5E01380", Offset = "0x5E00780", VA = "0x185E01380", Slot = "4")]
	public int OOIENOFBEMC(int3 LPJDDLMPNCG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class BKNFNKONCBF : PHNFFMLDBFK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type KKKPBNGAIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x734AE0", Offset = "0x733EE0", VA = "0x180734AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFE00", Offset = "0x5DFF200", VA = "0x185DFFE00")]
	public BKNFNKONCBF(Type BLFEFDPDIJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NOJIPINFHEG : BKNFNKONCBF
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFE00", Offset = "0x5DFF200", VA = "0x185DFFE00")]
	public NOJIPINFHEG(Type BLFEFDPDIJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IGBJMBJDJOJ : BKNFNKONCBF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type KLKOEFPFJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x734AF0", Offset = "0x733EF0", VA = "0x180734AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E019F0", Offset = "0x5E00DF0", VA = "0x185E019F0")]
	public IGBJMBJDJOJ(Type FOHLAPOCNKN, Type BLFEFDPDIJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KLLNJHKGGCN : BKNFNKONCBF
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFE00", Offset = "0x5DFF200", VA = "0x185DFFE00")]
	public KLLNJHKGGCN(Type BLFEFDPDIJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NDAPPBGAMDM : PHNFFMLDBFK
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public NDAPPBGAMDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DLJAHAIEDHD : PHNFFMLDBFK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BFEMEIIIFID AHLNEKABACB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x72B020", Offset = "0x72A420", VA = "0x18072B020")]
		[CompilerGenerated]
		get
		{
			return default(BFEMEIIIFID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E008A0", Offset = "0x5DFFCA0", VA = "0x185E008A0")]
	public DLJAHAIEDHD(BFEMEIIIFID CAAHBOFLBKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class PHIPKIFAENI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly MKDEFAJNDJH ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager MABCFMECCKD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MKDEFAJNDJH LJDGEIMOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E04BC0", Offset = "0x5E03FC0", VA = "0x185E04BC0")]
	public PHIPKIFAENI(MKDEFAJNDJH ACFGKGFDFPL, EntityManager MABCFMECCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x25C6400", Offset = "0x25C5800", VA = "0x1825C6400")]
	public bool KIKPOCBFMMA<T>(Entity LCLDFKAJPDK) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x25C4990", Offset = "0x25C3D90", VA = "0x1825C4990")]
	public bool BCLFMOEFKIH<T>(Entity LCLDFKAJPDK, out T LPJDDLMPNCG) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x25C4A20", Offset = "0x25C3E20", VA = "0x1825C4A20")]
	public T EOBHDFJLGJC<T>(Entity LCLDFKAJPDK) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x25C6440", Offset = "0x25C5840", VA = "0x1825C6440")]
	private ComponentType OBGINDJLFNE<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5E04AF0", Offset = "0x5E03EF0", VA = "0x185E04AF0")]
	private ComponentType OBGINDJLFNE(Type OGILDIMGIOH)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class EHHACAEHLKG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	protected EHHACAEHLKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class KIGJDDNFIGB<View, Data> : HOOPFMCFMDE where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType KCKGDDPGNEF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type IJPEOLBPFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x338F890", Offset = "0x338EC90", VA = "0x18338F890", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type PKEEOLIKIPM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x338EC70", Offset = "0x338E070", VA = "0x18338EC70", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int BFEBBHIMGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x338EF80", Offset = "0x338E380", VA = "0x18338EF80", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x338EF10", Offset = "0x338E310", VA = "0x18338EF10")]
	public Data CDGLPEEPBGD(Entity LCLDFKAJPDK)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x338F040", Offset = "0x338E440", VA = "0x18338F040")]
	public Data DBFLOLBHDAC(Entity LCLDFKAJPDK)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View MBFICJNDPOH(Entity LCLDFKAJPDK);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4D8ECE0", Offset = "0x4D8E0E0", VA = "0x184D8ECE0", Slot = "15")]
	protected internal override T MBFICJNDPOH<T>(Entity LCLDFKAJPDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xF93720", Offset = "0xF92B20", VA = "0x180F93720")]
	protected KIGJDDNFIGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class HOOPFMCFMDE : HPEJEEPDKIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic KOAJKAFOKAG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager BFILENFCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAA05E0", Offset = "0xA9F9E0", VA = "0x180AA05E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type IJPEOLBPFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type PKEEOLIKIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int BFEBBHIMGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type JICNPBELJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7EEBF0", Offset = "0x7EDFF0", VA = "0x1807EEBF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int ABHAJPGBNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E01890", Offset = "0x5E00C90", VA = "0x185E01890", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private ANIKAMAEHJJ[] PANMGMICCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7EEB20", Offset = "0x7EDF20", VA = "0x1807EEB20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual ANIKAMAEHJJ[] BDOBIEBIADC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E01930", Offset = "0x5E00D30", VA = "0x185E01930", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BCHLOBEAHMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E01900", Offset = "0x5E00D00", VA = "0x185E01900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5E01770", Offset = "0x5E00B70", VA = "0x185E01770")]
	public void KADCCJJCHBP(EntityManager MABCFMECCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7532F0", Offset = "0x7526F0", VA = "0x1807532F0")]
	protected HPEJEEPDKIC MAEMLBHOCDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T MBFICJNDPOH<T>(Entity LCLDFKAJPDK) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E016B0", Offset = "0x5E00AB0", VA = "0x185E016B0", Slot = "8")]
	public (uint, uint) HFKLKHBFEGG(Entity LCLDFKAJPDK)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E01620", Offset = "0x5E00A20", VA = "0x185E01620", Slot = "9")]
	public bool DMLNPENFHLB(Entity LCLDFKAJPDK, (uint order, uint change) NHBDMCDLELK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	protected HOOPFMCFMDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class LAINCMFJIOM<Data> : FGEMEIPGJHN where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data EBMJMAANCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x33BA400", Offset = "0x33B9800", VA = "0x1833BA400", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x22726F0", Offset = "0x2271AF0", VA = "0x1822726F0", Slot = "8")]
	protected virtual bool JAPPKCEDIFG(ReadOnlySpan<Data> BNJGAHEFJPB, NKBHFLFMPJO JCDMDNEMCAL, out ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "9")]
	protected virtual bool BCGHMNNLDCA(int NHBDMCDLELK, Span<Data> BNJGAHEFJPB, in ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x33BA340", Offset = "0x33B9740", VA = "0x1833BA340", Slot = "5")]
	internal sealed override bool JAPPKCEDIFG(ref Unity.Entities.Chunk ONPLFJPHGKJ, int GLMAMMHHIFE, NKBHFLFMPJO JCDMDNEMCAL, out ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x33B9310", Offset = "0x33B8710", VA = "0x1833B9310", Slot = "6")]
	internal sealed override bool BCGHMNNLDCA(int NHBDMCDLELK, ref Unity.Entities.Chunk ONPLFJPHGKJ, int GLMAMMHHIFE, in ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3171DC0", Offset = "0x31711C0", VA = "0x183171DC0")]
	protected global::NJBGCNCAAGP<Protobuf> JFKGOGDICFF<Protobuf>(ReadOnlySpan<Data> BNJGAHEFJPB) where Protobuf : IMessage, new()
	{
		return default(global::NJBGCNCAAGP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3171D30", Offset = "0x3171130", VA = "0x183171D30")]
	protected global::AEFDFDOMBNM<Protobuf> DGHFPFEFNAG<Protobuf>(ReadOnlySpan<byte> EICPLPLLHGP, ReadOnlySpan<Data> BNJGAHEFJPB, Action<Protobuf> HPANBHPHLHP) where Protobuf : IMessage, new()
	{
		return default(global::AEFDFDOMBNM<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xF93720", Offset = "0xF92B20", VA = "0x180F93720")]
	protected LAINCMFJIOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class FGEMEIPGJHN
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int PELKNHEANOH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E00B80", Offset = "0x5DFFF80", VA = "0x185E00B80", Slot = "5")]
	internal virtual bool JAPPKCEDIFG(ref Unity.Entities.Chunk ONPLFJPHGKJ, int GLMAMMHHIFE, NKBHFLFMPJO JCDMDNEMCAL, out ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "6")]
	internal virtual bool BCGHMNNLDCA(int NHBDMCDLELK, ref Unity.Entities.Chunk ONPLFJPHGKJ, int GLMAMMHHIFE, in ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	protected FGEMEIPGJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface ADGHADFNANA<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo OOIENOFBEMC(TFrom LPJDDLMPNCG);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CHKEPGCJAAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFDJOPCPCOF(T LPJDDLMPNCG);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct HCJOONEMCPO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::ADGHADFNANA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> BHKFLGJDPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> CHJGLLIDGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap DAAMKALKLMO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct KFJAMICFHHJ<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::ADGHADFNANA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> FFCJNPOIBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> CHJGLLIDGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap DAAMKALKLMO;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk ONPLFJPHGKJ, int PFAEPJABOKH, int NPNBCDOLONO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct PMFGEFPNIJF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CLODBLNLLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> BHKFLGJDPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> CHJGLLIDGNE;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x263AAC0", Offset = "0x2639EC0", VA = "0x18263AAC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct FJOMIIAAAJP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CLODBLNLLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> BHKFLGJDPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> COCDIBCKLCN;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct KCCFOKNLKHE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::ADGHADFNANA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> EPDLBMJLKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> CHJGLLIDGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap DAAMKALKLMO;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct IABEICCJEON<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BLFEFDPDIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> JILBKCFLHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> MEHOJHPNFFE;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct NGANPBFHAHF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BLFEFDPDIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> JILBKCFLHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> MEHOJHPNFFE;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x26EAA80", Offset = "0x26E9E80", VA = "0x1826EAA80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct FGMLHLPBPNL<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> BHKFLGJDPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> COCDIBCKLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, JAPIHNFIDBB> CPLDDCNHBMK;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2430DE0", Offset = "0x24301E0", VA = "0x182430DE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct CHKKLHDEDNM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::ADGHADFNANA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> BHKFLGJDPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> COCDIBCKLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, JAPIHNFIDBB> CPLDDCNHBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap DAAMKALKLMO;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct ICBPLICBNMB<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::CHKEPGCJAAC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> BHKFLGJDPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> COCDIBCKLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate DAAMKALKLMO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct NMHNAPLMMHD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity BLFEFDPDIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> JILBKCFLHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> OBNIMOJMKPM;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E044C0", Offset = "0x5E038C0", VA = "0x185E044C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct HJFBFACJHOF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity BLFEFDPDIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> JILBKCFLHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> OBNIMOJMKPM;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E01390", Offset = "0x5E00790", VA = "0x185E01390", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LMMPCDPEAMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class FMBCGANJFIC
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x261F730", Offset = "0x261EB30", VA = "0x18261F730")]
	public static bool KEAKGICNKJO<T>(this NativeArray<Entity> JILBKCFLHPF, EntityManager MABCFMECCKD, Allocator FKHAEPDPDAI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class MBCGFDDPIHN
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class KAGOCAIEMJB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public KAGOCAIEMJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class EBNPANPBJHM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public EBNPANPBJHM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> KHALHIHEELP;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E02260", Offset = "0x5E01660", VA = "0x185E02260")]
	public MBCGFDDPIHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class ICKMCJKONBI
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JCGPCHGPNFE
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct CIBCBBIGFFJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct OEKDKKJHIEB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal CIBCBBIGFFJ<TFrom> GGEKFPEBLKN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator FKHAEPDPDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> EBCEJCLCIMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct EMLJIKFAHDL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct FPAOENNPBOO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal EMLJIKFAHDL<TFrom> GGEKFPEBLKN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator FKHAEPDPDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> EBCEJCLCIMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct BBEGPGINCOG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct MPJBIMBEBBI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal BBEGPGINCOG<TFrom> GGEKFPEBLKN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator FKHAEPDPDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> EBCEJCLCIMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct NLBLBPLDFGJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct OJDIBLJDJFD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal NLBLBPLDFGJ<TFrom> GGEKFPEBLKN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator FKHAEPDPDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> EBCEJCLCIMI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NGDFNKOJFCN
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class GNAMADIMEIL
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x29F0130", Offset = "0x29EF530", VA = "0x1829F0130")]
	public static NativeList<T> FAHCICIBODO<T>(this NativeArray<T> KHGAHLGJBLG, Allocator FKHAEPDPDAI = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class NGLDLBFAGEA
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2832970", Offset = "0x2831D70", VA = "0x182832970")]
	public static NativeArray<T> DHJFCIFAGBA<T>(this NativeList<Entity> KHGAHLGJBLG, EntityManager MABCFMECCKD, Allocator FKHAEPDPDAI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2832870", Offset = "0x2831C70", VA = "0x182832870")]
	public static NativeArray<T> DHJFCIFAGBA<T>(this NativeArray<Entity> KHGAHLGJBLG, EntityManager MABCFMECCKD, Allocator FKHAEPDPDAI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class NBMIPIHHBNG
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct PAGEFNEFHOI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct NOMNCMLPGGK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public PAGEFNEFHOI<TFrom> EBCEJCLCIMI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator FKHAEPDPDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> BHKFLGJDPPD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct CHAAHKJKFOB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct DPBEMFLAEMI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public CHAAHKJKFOB<TFrom> EBCEJCLCIMI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator FKHAEPDPDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> BHKFLGJDPPD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct OKMBHJPGFPM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct BIAEGJIMACJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public OKMBHJPGFPM<TFrom> EBCEJCLCIMI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator FKHAEPDPDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> BHKFLGJDPPD;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class GPADKKANAOL
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class ALJOCDPGFMG
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct KMNEKBDEHHL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator FKHAEPDPDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> BHKFLGJDPPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct MMLCBIIAKFN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator FKHAEPDPDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> BHKFLGJDPPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct NLGKPIHCGLK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator FKHAEPDPDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> BHKFLGJDPPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct PICACGKAEMF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator FKHAEPDPDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> BHKFLGJDPPD;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class NAEDBDGEFDE
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class MLIGCCLBEIM
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x23CE6C0", Offset = "0x23CDAC0", VA = "0x1823CE6C0")]
	public static NativeList<Entity> BCGANCKGFMI<T>(this NativeArray<Entity> JILBKCFLHPF, EntityManager MABCFMECCKD, Allocator FKHAEPDPDAI = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class JDEDLEDCLDG
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface MCKLAKEFOEL
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JOBLNHDHOOE
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class GFEOCNJIJGC
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class MOKJEAJJCLG
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E042E0", Offset = "0x5E036E0", VA = "0x185E042E0")]
	public static bool BKIPNBPEEME(Type OGILDIMGIOH, Type NFNNKDNIAHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class CHOLKKIBDBM<Attribute, BaseClass> : global::ABLONIELJLO<BaseClass>, JJMIJJELAPO where Attribute : BKNFNKONCBF
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly KLBHBMBPLOA JFFPIFJCILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string AMNLGEBHFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> OOKFLMHHHAO;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x258B700", Offset = "0x258AB00", VA = "0x18258B700")]
	public CHOLKKIBDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x258B5B0", Offset = "0x258A9B0", VA = "0x18258B5B0", Slot = "4")]
	public bool GMBMHDKFMPB(int ODMCPPPIBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x258B260", Offset = "0x258A660", VA = "0x18258B260", Slot = "5")]
	public global::EILPMGINBJG<BaseClass> DKJEOCGMPBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x258B160", Offset = "0x258A560", VA = "0x18258B160", Slot = "7")]
	protected virtual bool BKIPNBPEEME(Type OGILDIMGIOH, int MEKBOFDHFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x258B0D0", Offset = "0x258A4D0", VA = "0x18258B0D0", Slot = "8")]
	protected virtual int BDNFJGGHMOC(Type OGILDIMGIOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x258B610", Offset = "0x258AA10", VA = "0x18258B610")]
	public void KLMOEJEAKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x258B510", Offset = "0x258A910", VA = "0x18258B510", Slot = "6")]
	public void EHOMCGHPBHE(Type OGILDIMGIOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class EILPMGINBJG<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> LNDFKAAGHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> LCCKEOPEEHF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> IDALJFOHJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A569D0", Offset = "0x3A55DD0", VA = "0x183A569D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A56DD0", Offset = "0x3A561D0", VA = "0x183A56DD0")]
	public EILPMGINBJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A56C30", Offset = "0x3A56030", VA = "0x183A56C30")]
	public EILPMGINBJG(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A568B0", Offset = "0x3A55CB0", VA = "0x183A568B0")]
	internal void AGMLDLCGDGN(int ODMCPPPIBBH, BaseClass GPADBKAKFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x24555F0", Offset = "0x24549F0", VA = "0x1824555F0")]
	public bool CLMGJHEHKEO<T>(out BaseClass LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3A56930", Offset = "0x3A55D30", VA = "0x183A56930")]
	public bool CLMGJHEHKEO(Type KCEEKGALKFC, out BaseClass LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F620", Offset = "0x2A9EA20", VA = "0x182A9F620")]
	public bool NCJPHBOOMNI(int ODMCPPPIBBH, out BaseClass LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2456300", Offset = "0x2455700", VA = "0x182456300")]
	public T KJIPHFIECOL<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A56C00", Offset = "0x3A56000", VA = "0x183A56C00")]
	public BaseClass KJIPHFIECOL(Type KDCMMGJKBFG)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class JFFGOEBFKBM : global::CHOLKKIBDBM<NOJIPINFHEG, EHHACAEHLKG>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E01A40", Offset = "0x5E00E40", VA = "0x185E01A40")]
	public JFFGOEBFKBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FIGANEKHCDA : global::CHOLKKIBDBM<IGBJMBJDJOJ, HOOPFMCFMDE>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E00C10", Offset = "0x5E00010", VA = "0x185E00C10")]
	public FIGANEKHCDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class HEPEOHPLAMP : global::CHOLKKIBDBM<KLLNJHKGGCN, FGEMEIPGJHN>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E01310", Offset = "0x5E00710", VA = "0x185E01310")]
	public HEPEOHPLAMP()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[JEGJCCBDMOE(OLCAJGBKOGB.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> OFGCLOACCDN;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x982140", Offset = "0x981540", VA = "0x180982140")]
		private ComponentSystemTypes(List<Type> OFGCLOACCDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E00180", Offset = "0x5DFF580", VA = "0x185E00180")]
		public static void KLMOEJEAKPE(List<Type> OFGCLOACCDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DFFF40", Offset = "0x5DFF340", VA = "0x185DFFF40")]
		private void CHEBJAGFHEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5DFFEC0", Offset = "0x5DFF2C0", VA = "0x185DFFEC0")]
		private bool BKIPNBPEEME(Type OGILDIMGIOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E00210", Offset = "0x5DFF610", VA = "0x185E00210")]
		private void OOOIJBLDDDJ(Type OGILDIMGIOH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class BPBHIFGCFAP : LLPKLCJBNBL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFE80", Offset = "0x5DFF280", VA = "0x185DFFE80", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase BDEPGHFEAKD();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFE30", Offset = "0x5DFF230", VA = "0x185DFFE30")]
	protected ComponentSystemBase CPGILBCLKLL(params ComponentSystemBase[] DFKHIBLIHPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1A89D50", Offset = "0x1A89150", VA = "0x181A89D50")]
	protected ComponentSystemBase CPGILBCLKLL<T>(params ComponentSystemBase[] DFKHIBLIHPO) where T : LLPKLCJBNBL, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1A89DF0", Offset = "0x1A891F0", VA = "0x181A89DF0")]
	protected ComponentSystemBase GNHLMIDMJAE<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1A89DF0", Offset = "0x1A891F0", VA = "0x181A89DF0")]
	protected ComponentSystemBase OLEKFFMJCLK<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	protected BPBHIFGCFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface ABLONIELJLO<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMBMHDKFMPB(int ODMCPPPIBBH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::EILPMGINBJG<BaseClass> DKJEOCGMPBJ();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class LLPKLCJBNBL : OLPDJAGMDNP
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E01FB0", Offset = "0x5E013B0", VA = "0x185E01FB0", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public LLPKLCJBNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class KHECDAFCLCI : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E01D30", Offset = "0x5E01130", VA = "0x185E01D30")]
	public ComponentDataFromEntity ADNIICGDIKK(int ODMCPPPIBBH, bool GLNNHMBNJIG = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E01DD0", Offset = "0x5E011D0", VA = "0x185E01DD0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
	protected KHECDAFCLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class CJKBCGBAKBI : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
	protected CJKBCGBAKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class OCHAMNFOLEM : KHECDAFCLCI
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E04550", Offset = "0x5E03950", VA = "0x185E04550", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
	protected void MCFEJMHAGOD(string HKNFNIPGHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
	protected OCHAMNFOLEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class JEKCLBIKINP
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class OLPDJAGMDNP : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	protected OLPDJAGMDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[JEGJCCBDMOE(OLCAJGBKOGB.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E06070", Offset = "0x5E05470", VA = "0x185E06070")]
		public static ComponentSystemGroup[] OHHIAHEAMCH(World ACFGKGFDFPL, JIILLPMKGHD NIJJBCMFBLB = JIILLPMKGHD.Default, bool LFCIOHFLKFK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E05120", Offset = "0x5E04520", VA = "0x185E05120")]
		private static Type[] FMHPAKHIOFA(JIILLPMKGHD NIJJBCMFBLB, bool LFCIOHFLKFK, ComponentSystemGroup[] LFPHNGHDAGB, ComponentSystemGroup IKJIKOONEKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E05480", Offset = "0x5E04880", VA = "0x185E05480")]
		private static ComponentSystemGroup[] GAAJLFGJBLH(World ACFGKGFDFPL, out ComponentSystemGroup IKJIKOONEKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E05D10", Offset = "0x5E05110", VA = "0x185E05D10")]
		internal static bool LICJKNMBHPE(BFEMEIIIFID CAAHBOFLBKP, out DAFHCDFAPLO MFNNHAMJBJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E05F90", Offset = "0x5E05390", VA = "0x185E05F90")]
		private static ComponentSystemGroup MNKGAHOOMCG(Type OGILDIMGIOH, World ACFGKGFDFPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E04FF0", Offset = "0x5E043F0", VA = "0x185E04FF0")]
		private static ComponentSystemGroup[] EMLGDPDOGLI(Type[] OFGCLOACCDN, World ACFGKGFDFPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E05790", Offset = "0x5E04B90", VA = "0x185E05790")]
		internal static void IOAMEGIHJLF(World ACFGKGFDFPL, Type[] JJADCBGAJDI, ComponentSystemGroup[] LFPHNGHDAGB, ComponentSystemGroup IKJIKOONEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E05CB0", Offset = "0x5E050B0", VA = "0x185E05CB0")]
		internal static bool KIDNMNNONCD(ComponentSystemBase HFKGGLPFCMG, ComponentSystemGroup[] LFPHNGHDAGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E04F90", Offset = "0x5E04390", VA = "0x185E04F90")]
		private static void CIEJAJLBHAH(ComponentSystemGroup[] LFPHNGHDAGB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct EGJJCHOBCMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> IPHCLAMBJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> DFKHIBLIHPO;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0F0", Offset = "0x7EA4F0", VA = "0x1807EB0F0")]
	public EGJJCHOBCMK(Dictionary<Type, List<Type>> IPHCLAMBJCI, HashSet<Type> DFKHIBLIHPO)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[JEGJCCBDMOE(OLCAJGBKOGB.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class PNPLPKKMDHI : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xB0C7E0", Offset = "0xB0BBE0", VA = "0x180B0C7E0")]
			[DebuggerHidden]
			public PNPLPKKMDHI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5E04EB0", Offset = "0x5E042B0", VA = "0x185E04EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5E04C10", Offset = "0x5E04010", VA = "0x185E04C10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5E04F40", Offset = "0x5E04340", VA = "0x185E04F40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5E04E70", Offset = "0x5E04270", VA = "0x185E04E70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5E04DC0", Offset = "0x5E041C0", VA = "0x185E04DC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5E04DC0", Offset = "0x5E041C0", VA = "0x185E04DC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct OLNFCEPPIFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type HDALBLMPBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private JIILLPMKGHD NIJJBCMFBLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool IGACDCGINDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool NLGKIJAONDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool LFCIOHFLKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> NCGGEDIDNAF;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E06D00", Offset = "0x5E06100", VA = "0x185E06D00")]
		public static RRFilterWorldSystems IDIKGABNBEI()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E06CB0", Offset = "0x5E060B0", VA = "0x185E06CB0")]
		public RRFilterWorldSystems FKIMJDCFPNF(JIILLPMKGHD CAAHBOFLBKP)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E06CC0", Offset = "0x5E060C0", VA = "0x185E06CC0")]
		public RRFilterWorldSystems GINGBGEFCAH(IEnumerable<Type> OFGCLOACCDN)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E070C0", Offset = "0x5E064C0", VA = "0x185E070C0")]
		public RRFilterWorldSystems PHJDMAEDPIJ(bool CEBCJEFJCOC)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E070B0", Offset = "0x5E064B0", VA = "0x185E070B0")]
		public RRFilterWorldSystems NANCCLMMJEG(bool CFDDKCJNAGE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E07020", Offset = "0x5E06420", VA = "0x185E07020")]
		public EGJJCHOBCMK MDOALHFJGGO(Type[] AAFKDBEKKGL)
		{
			return default(EGJJCHOBCMK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E06D20", Offset = "0x5E06120", VA = "0x185E06D20")]
		[IteratorStateMachine(typeof(PNPLPKKMDHI))]
		internal IEnumerable<Type> KOOPHPGIDIG(IEnumerable<Type> OFGCLOACCDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E061D0", Offset = "0x5E055D0", VA = "0x185E061D0")]
		internal Dictionary<Type, List<Type>> BNOHOKIPCAP(IEnumerable<Type> OFGCLOACCDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E06DB0", Offset = "0x5E061B0", VA = "0x185E06DB0")]
		private void LDLJGCEMOMD(Dictionary<Type, List<Type>> BOGHIFKGACA, Type OGILDIMGIOH, Type AECEMEIMACL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E064B0", Offset = "0x5E058B0", VA = "0x185E064B0")]
		internal HashSet<Type> EANJDMOBNAA(IEnumerable<Type> LFPHNGHDAGB, Dictionary<Type, List<Type>> MCHKFDMHGLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5E06670", Offset = "0x5E05A70", VA = "0x185E06670")]
		internal bool EGHAFJFCEDD(Type OGILDIMGIOH, JIILLPMKGHD NIJJBCMFBLB, bool LFCIOHFLKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5E06EC0", Offset = "0x5E062C0", VA = "0x185E06EC0")]
		[CompilerGenerated]
		internal static void LGNGPGIDMPD(Type OGILDIMGIOH, ref OLNFCEPPIFG P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class OHOHMBHDONJ
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool IIBFOCPMDPC;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E04770", Offset = "0x5E03B70", VA = "0x185E04770")]
	public static void KADCCJJCHBP(bool HKPPDHFDHMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5E047D0", Offset = "0x5E03BD0", VA = "0x185E047D0")]
	private static void NJNABJONAHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class JKHAEHCCHGE
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5E01AB0", Offset = "0x5E00EB0", VA = "0x185E01AB0")]
	public static ulong LNNDJOKNNGM(Type OGILDIMGIOH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5E01AE0", Offset = "0x5E00EE0", VA = "0x185E01AE0")]
	public static ulong LNNDJOKNNGM(string NMNENEOOHAJ)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[JEGJCCBDMOE(OLCAJGBKOGB.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct AOIEIFKCPOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong ABKOKNPIMFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong MNOKFDNKOHK;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xCD29D0", Offset = "0xCD1DD0", VA = "0x180CD29D0")]
			public AOIEIFKCPOM(ulong BELONAHFLCH, ulong MLICCODBALD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5DFFC10", Offset = "0x5DFF010", VA = "0x185DFFC10", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> POEMKAEEIGI;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static AOIEIFKCPOM[] NCBIOKJHAFD;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool IIBFOCPMDPC;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5E075B0", Offset = "0x5E069B0", VA = "0x185E075B0")]
		public static ulong DAECFLKHIHI(int ODMCPPPIBBH)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5E07C50", Offset = "0x5E07050", VA = "0x185E07C50")]
		public static int LAFHFIAOIAF(ulong MLICCODBALD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5E07A60", Offset = "0x5E06E60", VA = "0x185E07A60")]
		public static void KADCCJJCHBP(bool HKPPDHFDHMN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5E07610", Offset = "0x5E06A10", VA = "0x185E07610")]
		private static void DLDOBCIHKPC(int GHAKKCLOEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5E07290", Offset = "0x5E06690", VA = "0x185E07290")]
		private static void CFFKEOAKEII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5E07980", Offset = "0x5E06D80", VA = "0x185E07980")]
		private static AOIEIFKCPOM HEDEGMBOKGB(Type OGILDIMGIOH)
		{
			return default(AOIEIFKCPOM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5E076F0", Offset = "0x5E06AF0", VA = "0x185E076F0")]
		private static ulong EGPEGEGAHIC(Type OGILDIMGIOH, ulong MLICCODBALD)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5E07760", Offset = "0x5E06B60", VA = "0x185E07760")]
		private static void FOICPKAIFPK(in AOIEIFKCPOM JMHLNCMMHLN, TypeManager.TypeInfo KGDPFJPDODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5E07D00", Offset = "0x5E07100", VA = "0x185E07D00")]
		private static void MCMEJMAFJNG(AOIEIFKCPOM KGDPFJPDODM, int ODMCPPPIBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5E071B0", Offset = "0x5E065B0", VA = "0x185E071B0")]
		private static void ACKABFPLBMG(AOIEIFKCPOM KGDPFJPDODM, int ODMCPPPIBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5E07E00", Offset = "0x5E07200", VA = "0x185E07E00")]
		private static AOIEIFKCPOM NMEJIAOEKOJ(int ODMCPPPIBBH)
		{
			return default(AOIEIFKCPOM);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5E071A0", Offset = "0x5E065A0", VA = "0x185E071A0")]
		private static int AAEAGDIHJDB(int ODMCPPPIBBH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class MBGFCODAIAE
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly FIGANEKHCDA MPOJIEKCMLO;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly HEPEOHPLAMP KDCBPODHMKE;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly JFFGOEBFKBM IPGODJDEJOM;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> GJBAHFAADOP;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool IIBFOCPMDPC;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::ABLONIELJLO<HOOPFMCFMDE> DKDDFNMANGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5E027F0", Offset = "0x5E01BF0", VA = "0x185E027F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::ABLONIELJLO<FGEMEIPGJHN> IEKEOGJJOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5E022E0", Offset = "0x5E016E0", VA = "0x185E022E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::ABLONIELJLO<EHHACAEHLKG> KADGLNEFCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5E02850", Offset = "0x5E01C50", VA = "0x185E02850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5E02340", Offset = "0x5E01740", VA = "0x185E02340")]
	public static void KADCCJJCHBP(bool HKPPDHFDHMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5E028B0", Offset = "0x5E01CB0", VA = "0x185E028B0")]
	public static Type[] PJEELELNIJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class GLDDIODLLCL
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> NGKGFBJBHAJ;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool IIBFOCPMDPC;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5E01150", Offset = "0x5E00550", VA = "0x185E01150")]
	public static int HFKLKHBFEGG(int ODMCPPPIBBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5E011F0", Offset = "0x5E005F0", VA = "0x185E011F0")]
	public static void KADCCJJCHBP(bool HKPPDHFDHMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5E00E80", Offset = "0x5E00280", VA = "0x185E00E80")]
	private static void DEEKNFKCNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5E01100", Offset = "0x5E00500", VA = "0x185E01100")]
	private static int EAFNIENOPFJ(Type OGILDIMGIOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5E00E00", Offset = "0x5E00200", VA = "0x185E00E00")]
	private static void BONIBAPHNIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class MKDEFAJNDJH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World ACFGKGFDFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World INEGJJDGIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly PHIPKIFAENI GPADBKAKFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] LFPHNGHDAGB;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World LJDGEIMOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World JAPDBJIMKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager BFILENFCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1E4CFE0", Offset = "0x1E4C3E0", VA = "0x181E4CFE0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PHIPKIFAENI PDFOFNPFHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::EILPMGINBJG<HOOPFMCFMDE> DKDDFNMANGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0D30", VA = "0x1807B1930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::EILPMGINBJG<FGEMEIPGJHN> IEKEOGJJOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x735A10", Offset = "0x734E10", VA = "0x180735A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x735A20", Offset = "0x734E20", VA = "0x180735A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::EILPMGINBJG<EHHACAEHLKG> KADGLNEFCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x77E9A0", Offset = "0x77DDA0", VA = "0x18077E9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x77EAD0", Offset = "0x77DED0", VA = "0x18077EAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> HHNOCIKFPBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1C55DD0", Offset = "0x1C551D0", VA = "0x181C55DD0")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] JPHHCAKNDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5E02D90", Offset = "0x5E02190", VA = "0x185E02D90")]
	public static MKDEFAJNDJH FGLHHMEHBKP(string AMNLGEBHFHK, BFEMEIIIFID CAAHBOFLBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5E035A0", Offset = "0x5E029A0", VA = "0x185E035A0")]
	public MKDEFAJNDJH(string AMNLGEBHFHK, BFEMEIIIFID CAAHBOFLBKP = BFEMEIIIFID.Simulation, JIILLPMKGHD NIJJBCMFBLB = JIILLPMKGHD.Default, bool HKPPDHFDHMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5E02D70", Offset = "0x5E02170", VA = "0x185E02D70")]
	public ComponentSystemBase FCACOPJBHAF(Type OGILDIMGIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x23CCD90", Offset = "0x23CC190", VA = "0x1823CCD90")]
	public T FCACOPJBHAF<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5E031A0", Offset = "0x5E025A0", VA = "0x185E031A0")]
	public void IDEOMPDLCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5E032E0", Offset = "0x5E026E0", VA = "0x185E032E0")]
	public void JNAOAONIHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5E030E0", Offset = "0x5E024E0", VA = "0x185E030E0")]
	public void GNOCLHGPAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5E02B60", Offset = "0x5E01F60", VA = "0x185E02B60")]
	public void AALJJDJKAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5E03540", Offset = "0x5E02940", VA = "0x185E03540")]
	public void OJJNNBJOBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5E03140", Offset = "0x5E02540", VA = "0x185E03140")]
	public void HLIEGNNPLCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5E033D0", Offset = "0x5E027D0", VA = "0x185E033D0")]
	public void NMPIDOOGMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5E03340", Offset = "0x5E02740", VA = "0x185E03340")]
	public void MHABHGAONLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5E03280", Offset = "0x5E02680", VA = "0x185E03280")]
	public void JLKAEFPOFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5E02D10", Offset = "0x5E02110", VA = "0x185E02D10")]
	public void ENFGOLIEKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5E02BC0", Offset = "0x5E01FC0", VA = "0x185E02BC0")]
	internal void DNFHDOHJODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5E03200", Offset = "0x5E02600", VA = "0x185E03200")]
	private bool INBLLKIGFCG(ComponentSystemGroup KJJMKJFNPPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5E02E10", Offset = "0x5E02210", VA = "0x185E02E10")]
	private void GLLMDJAHEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5E03430", Offset = "0x5E02830", VA = "0x185E03430")]
	private ComponentSystemGroup[] OHHIAHEAMCH(JIILLPMKGHD NIJJBCMFBLB, bool LFCIOHFLKFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5E02CA0", Offset = "0x5E020A0", VA = "0x185E02CA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum BFEMEIIIFID
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
public sealed class FNEDGBMKFPL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public JIILLPMKGHD AKKMLGBEOLB;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum JIILLPMKGHD
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
public interface DAFHCDFAPLO
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type ODEEJHODFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] OOKOOBEKHPA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class GJEFNKDFLDC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool PDPIEAGPEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	protected GJEFNKDFLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class JEJGIJMBBJC : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public JEJGIJMBBJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class FINEFFIBJOC : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public FINEFFIBJOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class HMOJICADFJI : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public HMOJICADFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class BAOCFBCJAAC : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public BAOCFBCJAAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class MAPEDCOMLFB : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public MAPEDCOMLFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class NEKDNJJLLHF : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public NEKDNJJLLHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class NHCLKIBEPDE : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public NHCLKIBEPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class CPNGMNNGNAD : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public CPNGMNNGNAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class OIDENNPLDBB : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public OIDENNPLDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class JMEOBNBNAPP : LMFLAOGKEJF
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public JMEOBNBNAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class JCEOGDIEBAB : LMFLAOGKEJF
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public JCEOGDIEBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class JEJNLFLPINF : LMFLAOGKEJF
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public JEJNLFLPINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class MHFPHLOIMAP : LMFLAOGKEJF
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public MHFPHLOIMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[OKPMAHGBOHA(IKIGKMLBEFF.Application)]
public class LMFLAOGKEJF : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool PDPIEAGPEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDF0", Offset = "0x5DFF1F0", VA = "0x185DFFDF0")]
	public LMFLAOGKEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class ILCDEIKDENM : PHNFFMLDBFK
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	public ILCDEIKDENM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class HJODMMGNFMK
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void NBOMPPCKILD<From, To>(From EBCEJCLCIMI, ref To AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class OKGKNCFCAJJ<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static NBOMPPCKILD<From, To> MBBJKJNMLKK;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public OKGKNCFCAJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5E01420", Offset = "0x5E00820", VA = "0x185E01420")]
	static HJODMMGNFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2A09940", Offset = "0x2A08D40", VA = "0x182A09940")]
	public static void EBKJKFHHBBP<T>(NBOMPPCKILD<T, T> LHHCABEHHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2A09740", Offset = "0x2A08B40", VA = "0x182A09740")]
	public static void EBKJKFHHBBP<From, To>(NBOMPPCKILD<From, To> LHHCABEHHNI, NBOMPPCKILD<To, From> OHGKLADJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2A097D0", Offset = "0x2A08BD0", VA = "0x182A097D0")]
	public static void EBKJKFHHBBP<From, To>(NBOMPPCKILD<From, To> MBBJKJNMLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2A044C0", Offset = "0x2A038C0", VA = "0x182A044C0")]
	public static NBOMPPCKILD<From, To> EAAPGFFHDHI<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B7C0", Offset = "0x2A0ABC0", VA = "0x182A0B7C0")]
	public static void KHPMEFGGEHC<From, To>(From EBCEJCLCIMI, ref To AJINCMEHCPE, NKBHFLFMPJO JCDMDNEMCAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class NKBHFLFMPJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> OOIBMPGKCKE;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xCD6020", Offset = "0xCD5420", VA = "0x180CD6020")]
	public NKBHFLFMPJO(NativeArray<EntityRemapUtility.EntityRemapInfo> OOIBMPGKCKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x296C040", Offset = "0x296B440", VA = "0x18296C040")]
	public Entity KLNIBOPNDHF(Entity KCGHNGOMAMI)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class OHDCCBHDEPH
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> BCHGFHCDIOH;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5E04580", Offset = "0x5E03980", VA = "0x185E04580")]
	public static bool JKPNEMKOOPI(ulong IECKGMJMGEA, uint NHBDMCDLELK, out string AMNLGEBHFHK)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct JPLFAEABIDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int CMHFEELAEBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int PELKNHEANOH;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x735A30", Offset = "0x734E30", VA = "0x180735A30")]
			public JPLFAEABIDI(int EGNHJGKABLC, int NHBDMCDLELK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct KDKOODBKEKN
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch DDCPMELELDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long FAPMLKJJLDM;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long GHBLFPODMCL
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x5E01CD0", Offset = "0x5E010D0", VA = "0x185E01CD0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long HMFHCGDCGEI
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5E01BA0", Offset = "0x5E00FA0", VA = "0x185E01BA0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5E01C10", Offset = "0x5E01010", VA = "0x185E01C10")]
			public static KDKOODBKEKN FHHOHIGFIIH()
			{
				return default(KDKOODBKEKN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct MLBIJCEDAGJ : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct FKDNOMIPFAP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* HKFGPPCKAEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly PJLHDFLJMKK.EKNFOODINBI.EINCBHAINLA BDFDADPFIJB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly NKBHFLFMPJO JCDMDNEMCAL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::EILPMGINBJG<FGEMEIPGJHN> DKLBPBGOMJE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int GLMAMMHHIFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int PFAEPJABOKH;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x5E00C90", Offset = "0x5E00090", VA = "0x185E00C90")]
				public unsafe FKDNOMIPFAP(Unity.Entities.Archetype* HKFGPPCKAEL, PJLHDFLJMKK.EKNFOODINBI.EINCBHAINLA BDFDADPFIJB, NKBHFLFMPJO JCDMDNEMCAL, global::EILPMGINBJG<FGEMEIPGJHN> DKLBPBGOMJE, int GLMAMMHHIFE, int PFAEPJABOKH = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5E00CF0", Offset = "0x5E000F0", VA = "0x185E00CF0")]
				public FKDNOMIPFAP(in FKDNOMIPFAP HIDEHJGLNHO, int PFAEPJABOKH)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly FKDNOMIPFAP[] BNJGAHEFJPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] AKFLLHKFDKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int DFGMLPIDFOB;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5E041A0", Offset = "0x5E035A0", VA = "0x185E041A0")]
			public MLBIJCEDAGJ(FKDNOMIPFAP[] BNJGAHEFJPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5E03E70", Offset = "0x5E03270", VA = "0x185E03E70", Slot = "4")]
			public void Invoke(int EGNHJGKABLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5E03AC0", Offset = "0x5E02EC0", VA = "0x185E03AC0")]
			private void ALIAKFLFAPC(in FKDNOMIPFAP HIDEHJGLNHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5E03ED0", Offset = "0x5E032D0", VA = "0x185E03ED0")]
			private static void JGOJBDLJMIL(in FKDNOMIPFAP HIDEHJGLNHO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class FHCOFBMIKNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public PJLHDFLJMKK asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::EILPMGINBJG<FGEMEIPGJHN> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public FHCOFBMIKNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5E00BA0", Offset = "0x5DFFFA0", VA = "0x185E00BA0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class OEPLPLDEDFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public PJLHDFLJMKK.EKNFOODINBI.EINCBHAINLA srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public FHCOFBMIKNA CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public OEPLPLDEDFL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class PEHKJBFFLAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public OEPLPLDEDFL CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public PEHKJBFFLAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E049D0", Offset = "0x5E03DD0", VA = "0x185E049D0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly KLBHBMBPLOA CFECLIGCGNI;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly KLBHBMBPLOA IPANPJFPJCP;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly KLBHBMBPLOA MELPEOJIKCK;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly KLBHBMBPLOA EMPKGIEJLAE;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool AGIMNPMAAAH;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static PJLHDFLJMKK.EKNFOODINBI.DDEBFKOGFJF ILNJPEKACLL;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5E0B210", Offset = "0x5E0A610", VA = "0x185E0B210")]
		private unsafe static bool OKCOPLCCGKK(Unity.Entities.Archetype* NCPPLDKIKPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5E0AEA0", Offset = "0x5E0A2A0", VA = "0x185E0AEA0")]
		internal unsafe static Unity.Entities.Archetype*[] OICIAABCDGK(ref Unity.Entities.EntityComponentStore OLBCBGFBBGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5E0B590", Offset = "0x5E0A990", VA = "0x185E0B590")]
		public static void PEEAKNCHPCN(MKDEFAJNDJH ACFGKGFDFPL, out ByteString EICPLPLLHGP, out NativeArray<EntityRemapUtility.EntityRemapInfo> IGIGBKFKHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5E07F20", Offset = "0x5E07320", VA = "0x185E07F20")]
		internal static void ABPPPPHEFJC(MKDEFAJNDJH ACFGKGFDFPL, PJLHDFLJMKK IGGLPHHHOFD, out NativeArray<EntityRemapUtility.EntityRemapInfo> IGIGBKFKHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5E089A0", Offset = "0x5E07DA0", VA = "0x185E089A0")]
		private unsafe static UnsafeHashMap<ulong, JPLFAEABIDI> BNAOJHIJMKJ(Unity.Entities.Archetype*[] FIDGLPJCAFL)
		{
			return default(UnsafeHashMap<ulong, JPLFAEABIDI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5E097C0", Offset = "0x5E08BC0", VA = "0x185E097C0")]
		private static void IJCECFEEILP(PJLHDFLJMKK IGGLPHHHOFD, UnsafeHashMap<ulong, JPLFAEABIDI> LLGFAPHLCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5E0B650", Offset = "0x5E0AA50", VA = "0x185E0B650")]
		private unsafe static void PMMAHBHNAPM(PJLHDFLJMKK IGGLPHHHOFD, Unity.Entities.Archetype*[] FIDGLPJCAFL, UnsafeHashMap<ulong, JPLFAEABIDI> LLGFAPHLCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5E0AB20", Offset = "0x5E09F20", VA = "0x185E0AB20")]
		private unsafe static int NLMEDFFOCBL(Unity.Entities.Archetype*[] FIDGLPJCAFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5E093A0", Offset = "0x5E087A0", VA = "0x185E093A0")]
		private unsafe static void HFNOHMFPMFH(PJLHDFLJMKK IGGLPHHHOFD, Unity.Entities.Archetype*[] FIDGLPJCAFL, global::EILPMGINBJG<FGEMEIPGJHN> DKLBPBGOMJE, NativeArray<EntityRemapUtility.EntityRemapInfo> IGIGBKFKHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5E0B320", Offset = "0x5E0A720", VA = "0x185E0B320")]
		private static NativeArray<int> OOOHMBHBLHC(PJLHDFLJMKK IGGLPHHHOFD)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A790", Offset = "0x5E09B90", VA = "0x185E0A790")]
		private static Memory<EntityArchetype> NFDAOIIDMPJ(PJLHDFLJMKK IGGLPHHHOFD, NativeArray<int> OFGCLOACCDN, EntityManager MABCFMECCKD, out int HFFNDLACKLL, out int ODGDHOHLBIP)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5E08650", Offset = "0x5E07A50", VA = "0x185E08650")]
		private unsafe static void BMEHJEBAKPC(Unity.Entities.Chunk* NMNHKEICFGN, ReadOnlySpan<byte> EICPLPLLHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5E09970", Offset = "0x5E08D70", VA = "0x185E09970")]
		private static void KIMHMPACIEE(PJLHDFLJMKK IGGLPHHHOFD, NativeArray<int> OFGCLOACCDN, Span<EntityArchetype> FIDGLPJCAFL, EntityManager MABCFMECCKD, global::EILPMGINBJG<FGEMEIPGJHN> DKLBPBGOMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5E08CD0", Offset = "0x5E080D0", VA = "0x185E08CD0")]
		private unsafe static void DPFHDCNICON(Unity.Entities.Chunk* ONPLFJPHGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5E0AB90", Offset = "0x5E09F90", VA = "0x185E0AB90")]
		private unsafe static void OCGJPMFDJJH(PJLHDFLJMKK.EKNFOODINBI.EINCBHAINLA HKFGPPCKAEL, int LNCJALCPHED, int NHNJGCLOJBH, Unity.Entities.Chunk* NMNHKEICFGN, PJLHDFLJMKK IGGLPHHHOFD, NativeArray<int> OFGCLOACCDN, global::EILPMGINBJG<FGEMEIPGJHN> DKLBPBGOMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A0B0", Offset = "0x5E094B0", VA = "0x185E0A0B0")]
		public static void LCABLNOIOIK(MKDEFAJNDJH ACFGKGFDFPL, in ByteString EICPLPLLHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A140", Offset = "0x5E09540", VA = "0x185E0A140")]
		public static void LCABLNOIOIK(EntityManager MABCFMECCKD, global::EILPMGINBJG<FGEMEIPGJHN> DKLBPBGOMJE, in ByteString EICPLPLLHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5E08D50", Offset = "0x5E08150", VA = "0x185E08D50")]
		private static bool FILLHKACBFD(Type OGILDIMGIOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5E09010", Offset = "0x5E08410", VA = "0x185E09010")]
		private static void GODJDOGLKNA(TypeManager.TypeInfo KGDPFJPDODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5E0B080", Offset = "0x5E0A480", VA = "0x185E0B080")]
		private unsafe static int OJNHNDALFFJ(Unity.Entities.Archetype*[] FIDGLPJCAFL, NativeArray<EntityRemapUtility.EntityRemapInfo> IGIGBKFKHFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5E092C0", Offset = "0x5E086C0", VA = "0x185E092C0")]
		private static int HFKLKHBFEGG(int ODMCPPPIBBH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5E08C30", Offset = "0x5E08030", VA = "0x185E08C30")]
		private static ulong DAECFLKHIHI(int ODMCPPPIBBH)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class DDMCHCMBPLL
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E002C0", Offset = "0x5DFF6C0", VA = "0x185E002C0")]
	private unsafe static Span<byte> AFFEDLJMPMM(Unity.Entities.Chunk* ONPLFJPHGKJ, int GLMAMMHHIFE)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1680CA0", Offset = "0x16800A0", VA = "0x181680CA0")]
	public unsafe static Span<T> EMNDELNPAMA<T>(Unity.Entities.Chunk* ONPLFJPHGKJ, int GLMAMMHHIFE)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1680E20", Offset = "0x1680220", VA = "0x181680E20")]
	public static Span<T> EMNDELNPAMA<T>(this ref Unity.Entities.Chunk ONPLFJPHGKJ, int GLMAMMHHIFE)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E00700", Offset = "0x5DFFB00", VA = "0x185E00700")]
	public unsafe static Span<Entity> KAMHHFEPBKC(Unity.Entities.Chunk* ONPLFJPHGKJ)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E00460", Offset = "0x5DFF860", VA = "0x185E00460")]
	public unsafe static void BONIBAPHNIO(Unity.Entities.Chunk* ONPLFJPHGKJ, int GLMAMMHHIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E00770", Offset = "0x5DFFB70", VA = "0x185E00770")]
	public static Entity PNJKIPLFOIC(this EntityQuery ANBHGOBNOFE)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : AAHOHGIJHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E0BBE0", Offset = "0x5E0AFE0", VA = "0x185E0BBE0", Slot = "4")]
		public sealed override void KLMOEJEAKPE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KKMDFNBFHNC()
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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

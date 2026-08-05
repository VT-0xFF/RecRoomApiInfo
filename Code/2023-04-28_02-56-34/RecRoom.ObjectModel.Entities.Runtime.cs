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
		[Cpp2IlInjected.Address(RVA = "0x5D9FB10", Offset = "0x5D9E510", VA = "0x185D9FB10")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5DA0870", Offset = "0x5D9F270", VA = "0x185DA0870")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DA08E0", Offset = "0x5D9F2E0", VA = "0x185DA08E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3659B00", Offset = "0x3658500", VA = "0x183659B00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x21DAB10", Offset = "0x21D9510", VA = "0x1821DAB10")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21DA340", Offset = "0x21D8D40", VA = "0x1821DA340")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21DA440", Offset = "0x21D8E40", VA = "0x1821DA440")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21DA840", Offset = "0x21D9240", VA = "0x1821DA840")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA0900", Offset = "0x5D9F300", VA = "0x185DA0900")]
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
			[Cpp2IlInjected.Address(RVA = "0x731A00", Offset = "0x730400", VA = "0x180731A00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x38B0D00", Offset = "0x38AF700", VA = "0x1838B0D00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1EEBEF0", Offset = "0x1EEA8F0", VA = "0x181EEBEF0")]
		[DebuggerHidden]
		public FBJPLOGFHKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x38B0B20", Offset = "0x38AF520", VA = "0x1838B0B20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x38B0CC0", Offset = "0x38AF6C0", VA = "0x1838B0CC0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x731750", Offset = "0x730150", VA = "0x180731750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5C60", Offset = "0x2AA4660", VA = "0x182AA5C60")]
	private AEFDFDOMBNM(byte[] NPOGECPDPEK, Action<Protobuf> HPANBHPHLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x276E300", Offset = "0x276CD00", VA = "0x18276E300")]
	public static global::AEFDFDOMBNM<Protobuf> IDIKGABNBEI<Data>(ReadOnlySpan<byte> EICPLPLLHGP, ReadOnlySpan<Data> BNJGAHEFJPB, Action<Protobuf> HPANBHPHLHP)
	{
		return default(global::AEFDFDOMBNM<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5AD0", Offset = "0x2AA44D0", VA = "0x182AA5AD0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5B10", Offset = "0x2AA4510", VA = "0x182AA5B10", Slot = "4")]
	[IteratorStateMachine(typeof(global::AEFDFDOMBNM<>.FBJPLOGFHKH))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5C10", Offset = "0x2AA4610", VA = "0x182AA5C10", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x35A5D80", Offset = "0x35A4780", VA = "0x1835A5D80")]
	private NJBGCNCAAGP(byte[] NPOGECPDPEK, in Protobuf KNOEGBEJAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2083DA0", Offset = "0x20827A0", VA = "0x182083DA0")]
	public static global::NJBGCNCAAGP<Protobuf> IDIKGABNBEI<T>(ReadOnlySpan<T> BNJGAHEFJPB)
	{
		return default(global::NJBGCNCAAGP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x35A5D50", Offset = "0x35A4750", VA = "0x1835A5D50")]
	public void HMLHHGOKLBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x35A5B90", Offset = "0x35A4590", VA = "0x1835A5B90")]
	public ByteString CPKNNIJFJGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x35A5C20", Offset = "0x35A4620", VA = "0x1835A5C20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA4800", Offset = "0x5DA3200", VA = "0x185DA4800", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA0740", Offset = "0x5D9F140", VA = "0x185DA0740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FCPBIAEPICB
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public static void FBLAEOGELJL(this KLBHBMBPLOA JFFPIFJCILI, NativeArray<Entity> ABBIPALBHCK, [Optional][CallerFilePath] string OHBABGDFGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public static void FBLAEOGELJL(this KLBHBMBPLOA JFFPIFJCILI, string AMNLGEBHFHK, NativeArray<Entity> ABBIPALBHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public static void FBLAEOGELJL(this KLBHBMBPLOA JFFPIFJCILI, string OHBABGDFGKH, NativeArray<Entity> ABBIPALBHCK, bool DGJHENDBKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public static void MLBLCNKHBGE(this KLBHBMBPLOA JFFPIFJCILI, NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> EOPPFFEOLEM, [Optional][CallerFilePath] string OHBABGDFGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public static void MLBLCNKHBGE(this KLBHBMBPLOA JFFPIFJCILI, string OHBABGDFGKH, NativeArray<Entity> ABBIPALBHCK, NativeArray<Entity> EOPPFFEOLEM, bool DGJHENDBKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2F75B60", Offset = "0x2F74560", VA = "0x182F75B60")]
	public static void IODBKODCPBL<T>(this KLBHBMBPLOA JFFPIFJCILI, string AMNLGEBHFHK, NativeArray<Entity> ABBIPALBHCK, NativeList<T> HIDEHJGLNHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2F75B20", Offset = "0x2F74520", VA = "0x182F75B20")]
	public static void IODBKODCPBL<T>(this KLBHBMBPLOA JFFPIFJCILI, string AMNLGEBHFHK, NativeArray<Entity> ABBIPALBHCK, NativeArray<T> HIDEHJGLNHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public static void IODBKODCPBL<T>(this KLBHBMBPLOA JFFPIFJCILI, string OHBABGDFGKH, NativeArray<Entity> ABBIPALBHCK, NativeArray<T> HIDEHJGLNHO, bool DGJHENDBKJI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2F75AB0", Offset = "0x2F744B0", VA = "0x182F75AB0")]
	public static void DKBHCEINAKG<T>(this KLBHBMBPLOA JFFPIFJCILI, NativeList<T> HIDEHJGLNHO, [Optional][CallerFilePath] string OHBABGDFGKH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2F75A80", Offset = "0x2F74480", VA = "0x182F75A80")]
	public static void DKBHCEINAKG<T>(this KLBHBMBPLOA JFFPIFJCILI, NativeArray<T> HIDEHJGLNHO, [Optional][CallerFilePath] string OHBABGDFGKH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public static void DKBHCEINAKG<T>(this KLBHBMBPLOA JFFPIFJCILI, string OHBABGDFGKH, NativeArray<T> HIDEHJGLNHO, bool DGJHENDBKJI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public static void ALGHBCBHCJJ(this KLBHBMBPLOA JFFPIFJCILI, EntityQuery ANBHGOBNOFE, [Optional][CallerFilePath] string OHBABGDFGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public static void ALGHBCBHCJJ(this KLBHBMBPLOA JFFPIFJCILI, string AMNLGEBHFHK, EntityQuery ANBHGOBNOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	public static void ALGHBCBHCJJ(this KLBHBMBPLOA JFFPIFJCILI, string OHBABGDFGKH, EntityQuery ANBHGOBNOFE, bool DGJHENDBKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2F75BF0", Offset = "0x2F745F0", VA = "0x182F75BF0")]
	public static void NAIDDCLMOAL<T, T2>(this KLBHBMBPLOA JFFPIFJCILI, string AMNLGEBHFHK, EntityQuery ANBHGOBNOFE) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
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
			[Cpp2IlInjected.Address(RVA = "0x1AA53F0", Offset = "0x1AA3DF0", VA = "0x181AA53F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x32E6E20", Offset = "0x32E5820", VA = "0x1832E6E20")]
		public bool DGDIKMJNIOG(out TValue LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x32E6D70", Offset = "0x32E5770", VA = "0x1832E6D70")]
		public void AGMLDLCGDGN(object MIFCLBEAOPM, TValue LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x32E6EE0", Offset = "0x32E58E0", VA = "0x1832E6EE0")]
		public bool FJEBMLODAAK(object MIFCLBEAOPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x32E6F60", Offset = "0x32E5960", VA = "0x1832E6F60")]
		public int JPAOIDBBCIF(object MIFCLBEAOPM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x32E7010", Offset = "0x32E5A10", VA = "0x1832E7010")]
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
	[Cpp2IlInjected.Address(RVA = "0x302D650", Offset = "0x302C050", VA = "0x18302D650")]
	public MIOAAOMMLGI(EntityManager MABCFMECCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x302D0B0", Offset = "0x302BAB0", VA = "0x18302D0B0", Slot = "4")]
	public void CKEFDKDJLFA(Entity LCLDFKAJPDK, object MIFCLBEAOPM, TValue LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x302D370", Offset = "0x302BD70", VA = "0x18302D370", Slot = "5")]
	public bool HONEOLFKKMC(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x302D1D0", Offset = "0x302BBD0", VA = "0x18302D1D0", Slot = "6")]
	public bool DGDIKMJNIOG(Entity LCLDFKAJPDK, out TValue LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x302D2A0", Offset = "0x302BCA0", VA = "0x18302D2A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x302D030", Offset = "0x302BA30", VA = "0x18302D030")]
	private void AFAPAFCNBIM(GCLPMNAMPOH GAHFKLMJAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x302D4E0", Offset = "0x302BEE0", VA = "0x18302D4E0")]
	private bool LHOMDJDAFHA(Entity LCLDFKAJPDK, out GELFNNAOOFF IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x302D2C0", Offset = "0x302BCC0", VA = "0x18302D2C0")]
	private void EJBKMMNEGKG(Entity LCLDFKAJPDK, GELFNNAOOFF IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x302D350", Offset = "0x302BD50", VA = "0x18302D350")]
	private bool FCALEKGFDAM(GELFNNAOOFF IGELLPOEMHM, out GCLPMNAMPOH GAHFKLMJAGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x302D590", Offset = "0x302BF90", VA = "0x18302D590")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C14C0", VA = "0x1807C2AC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A30", Offset = "0x7C1430", VA = "0x1807C2A30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C40C0", Offset = "0x8C2AC0", VA = "0x1808C40C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xE340B0", Offset = "0xE32AB0", VA = "0x180E340B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0BD0", Offset = "0x5D9F5D0", VA = "0x185DA0BD0", Slot = "8")]
	public bool Equals(GELFNNAOOFF MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0C20", Offset = "0x5D9F620", VA = "0x185DA0C20", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x27BB070", Offset = "0x27B9A70", VA = "0x1827BB070")]
	public NFKGLAFFMGG(EntityManager MABCFMECCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x27B89A0", Offset = "0x27B73A0", VA = "0x1827B89A0", Slot = "4")]
	public bool CKEFDKDJLFA(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x27B9170", Offset = "0x27B7B70", VA = "0x1827B9170", Slot = "5")]
	public bool HONEOLFKKMC(Entity LCLDFKAJPDK, object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x27BA9D0", Offset = "0x27B93D0", VA = "0x1827BA9D0", Slot = "6")]
	public bool MJNHCKEGDDK(Entity LCLDFKAJPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27BAB90", Offset = "0x27B9590", VA = "0x1827BAB90", Slot = "7")]
	public bool MJNHCKEGDDK(GELFNNAOOFF IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27BA230", Offset = "0x27B8C30", VA = "0x1827BA230", Slot = "8")]
	public IEnumerable<object> KGDGMLBLPJG(Entity LCLDFKAJPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27B9CB0", Offset = "0x27B86B0", VA = "0x1827B9CB0", Slot = "11")]
	public IEnumerable<object> KGDGMLBLPJG(GELFNNAOOFF IGELLPOEMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x27B8450", Offset = "0x27B6E50", VA = "0x1827B8450", Slot = "9")]
	public bool BHCJBLFDFCM(Entity LCLDFKAJPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27B8DE0", Offset = "0x27B77E0", VA = "0x1827B8DE0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27B8200", Offset = "0x27B6C00", VA = "0x1827B8200")]
	private void AFAPAFCNBIM(HashSet<object> GAHFKLMJAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27BA570", Offset = "0x27B8F70", VA = "0x1827BA570")]
	private bool LHOMDJDAFHA(Entity LCLDFKAJPDK, out GELFNNAOOFF IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27B9BC0", Offset = "0x27B85C0", VA = "0x1827B9BC0")]
	private bool KCJNAEPDGFL(Entity LCLDFKAJPDK, out GELFNNAOOFF IGELLPOEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x27BAF50", Offset = "0x27B9950", VA = "0x1827BAF50")]
	private void PAHOCGJANJP(Entity LCLDFKAJPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x27B8FC0", Offset = "0x27B79C0", VA = "0x1827B8FC0")]
	private void EJBKMMNEGKG(Entity LCLDFKAJPDK, GELFNNAOOFF IGELLPOEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27BADD0", Offset = "0x27B97D0", VA = "0x1827BADD0")]
	private bool OFNAKDLDNAG(GELFNNAOOFF IGELLPOEMHM, out HashSet<object> GAHFKLMJAGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27BA750", Offset = "0x27B9150", VA = "0x1827BA750")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA4950", Offset = "0x5DA3350", VA = "0x185DA4950", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA0AF0", Offset = "0x5D9F4F0", VA = "0x185DA0AF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA0BB0", Offset = "0x5D9F5B0", VA = "0x185DA0BB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x11D4450", Offset = "0x11D2E50", VA = "0x1811D4450", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D775E0", Offset = "0x2D75FE0", VA = "0x182D775E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA11F0", Offset = "0x5D9FBF0", VA = "0x185DA11F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x730AE0", Offset = "0x72F4E0", VA = "0x180730AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC70", Offset = "0x5D9E670", VA = "0x185D9FC70")]
	public BKNFNKONCBF(Type BLFEFDPDIJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NOJIPINFHEG : BKNFNKONCBF
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC70", Offset = "0x5D9E670", VA = "0x185D9FC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x730AF0", Offset = "0x72F4F0", VA = "0x180730AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1860", Offset = "0x5DA0260", VA = "0x185DA1860")]
	public IGBJMBJDJOJ(Type FOHLAPOCNKN, Type BLFEFDPDIJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KLLNJHKGGCN : BKNFNKONCBF
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC70", Offset = "0x5D9E670", VA = "0x185D9FC70")]
	public KLLNJHKGGCN(Type BLFEFDPDIJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NDAPPBGAMDM : PHNFFMLDBFK
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x725A20", VA = "0x180727020")]
		[CompilerGenerated]
		get
		{
			return default(BFEMEIIIFID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0710", Offset = "0x5D9F110", VA = "0x185DA0710")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4A30", Offset = "0x5DA3430", VA = "0x185DA4A30")]
	public PHIPKIFAENI(MKDEFAJNDJH ACFGKGFDFPL, EntityManager MABCFMECCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x22C9150", Offset = "0x22C7B50", VA = "0x1822C9150")]
	public bool KIKPOCBFMMA<T>(Entity LCLDFKAJPDK) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x22C76E0", Offset = "0x22C60E0", VA = "0x1822C76E0")]
	public bool BCLFMOEFKIH<T>(Entity LCLDFKAJPDK, out T LPJDDLMPNCG) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x22C7770", Offset = "0x22C6170", VA = "0x1822C7770")]
	public T EOBHDFJLGJC<T>(Entity LCLDFKAJPDK) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x22C9190", Offset = "0x22C7B90", VA = "0x1822C9190")]
	private ComponentType OBGINDJLFNE<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4960", Offset = "0x5DA3360", VA = "0x185DA4960")]
	private ComponentType OBGINDJLFNE(Type OGILDIMGIOH)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class EHHACAEHLKG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x38EC6B0", Offset = "0x38EB0B0", VA = "0x1838EC6B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type PKEEOLIKIPM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x38EBA90", Offset = "0x38EA490", VA = "0x1838EBA90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int BFEBBHIMGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x38EBDA0", Offset = "0x38EA7A0", VA = "0x1838EBDA0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x38EBD30", Offset = "0x38EA730", VA = "0x1838EBD30")]
	public Data CDGLPEEPBGD(Entity LCLDFKAJPDK)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x38EBE60", Offset = "0x38EA860", VA = "0x1838EBE60")]
	public Data DBFLOLBHDAC(Entity LCLDFKAJPDK)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View MBFICJNDPOH(Entity LCLDFKAJPDK);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2C3DBA0", Offset = "0x2C3C5A0", VA = "0x182C3DBA0", Slot = "15")]
	protected internal override T MBFICJNDPOH<T>(Entity LCLDFKAJPDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x225B720", Offset = "0x225A120", VA = "0x18225B720")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xB78DE0", Offset = "0xB777E0", VA = "0x180B78DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x818F50", Offset = "0x817950", VA = "0x180818F50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int ABHAJPGBNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5DA1700", Offset = "0x5DA0100", VA = "0x185DA1700", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private ANIKAMAEHJJ[] PANMGMICCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x818E80", Offset = "0x817880", VA = "0x180818E80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual ANIKAMAEHJJ[] BDOBIEBIADC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA17A0", Offset = "0x5DA01A0", VA = "0x185DA17A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BCHLOBEAHMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5DA1770", Offset = "0x5DA0170", VA = "0x185DA1770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5DA15E0", Offset = "0x5D9FFE0", VA = "0x185DA15E0")]
	public void KADCCJJCHBP(EntityManager MABCFMECCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x84FC20", Offset = "0x84E620", VA = "0x18084FC20")]
	protected HPEJEEPDKIC MAEMLBHOCDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T MBFICJNDPOH<T>(Entity LCLDFKAJPDK) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1520", Offset = "0x5D9FF20", VA = "0x185DA1520", Slot = "8")]
	public (uint, uint) HFKLKHBFEGG(Entity LCLDFKAJPDK)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1490", Offset = "0x5D9FE90", VA = "0x185DA1490", Slot = "9")]
	public bool DMLNPENFHLB(Entity LCLDFKAJPDK, (uint order, uint change) NHBDMCDLELK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A38090", Offset = "0x2A36A90", VA = "0x182A38090", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2387CE0", Offset = "0x23866E0", VA = "0x182387CE0", Slot = "8")]
	protected virtual bool JAPPKCEDIFG(ReadOnlySpan<Data> BNJGAHEFJPB, NKBHFLFMPJO JCDMDNEMCAL, out ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "9")]
	protected virtual bool BCGHMNNLDCA(int NHBDMCDLELK, Span<Data> BNJGAHEFJPB, in ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A37FB0", Offset = "0x2A369B0", VA = "0x182A37FB0", Slot = "5")]
	internal sealed override bool JAPPKCEDIFG(ref Unity.Entities.Chunk ONPLFJPHGKJ, int GLMAMMHHIFE, NKBHFLFMPJO JCDMDNEMCAL, out ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A36F80", Offset = "0x2A35980", VA = "0x182A36F80", Slot = "6")]
	internal sealed override bool BCGHMNNLDCA(int NHBDMCDLELK, ref Unity.Entities.Chunk ONPLFJPHGKJ, int GLMAMMHHIFE, in ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x394CCD0", Offset = "0x394B6D0", VA = "0x18394CCD0")]
	protected global::NJBGCNCAAGP<Protobuf> JFKGOGDICFF<Protobuf>(ReadOnlySpan<Data> BNJGAHEFJPB) where Protobuf : IMessage, new()
	{
		return default(global::NJBGCNCAAGP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x394CC40", Offset = "0x394B640", VA = "0x18394CC40")]
	protected global::AEFDFDOMBNM<Protobuf> DGHFPFEFNAG<Protobuf>(ReadOnlySpan<byte> EICPLPLLHGP, ReadOnlySpan<Data> BNJGAHEFJPB, Action<Protobuf> HPANBHPHLHP) where Protobuf : IMessage, new()
	{
		return default(global::AEFDFDOMBNM<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x225B720", Offset = "0x225A120", VA = "0x18225B720")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA09F0", Offset = "0x5D9F3F0", VA = "0x185DA09F0", Slot = "5")]
	internal virtual bool JAPPKCEDIFG(ref Unity.Entities.Chunk ONPLFJPHGKJ, int GLMAMMHHIFE, NKBHFLFMPJO JCDMDNEMCAL, out ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "6")]
	internal virtual bool BCGHMNNLDCA(int NHBDMCDLELK, ref Unity.Entities.Chunk ONPLFJPHGKJ, int GLMAMMHHIFE, in ReadOnlySpan<byte> EICPLPLLHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x2610210", Offset = "0x260EC10", VA = "0x182610210", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x27BC2A0", Offset = "0x27BACA0", VA = "0x1827BC2A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x38BB7D0", Offset = "0x38BA1D0", VA = "0x1838BB7D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA4330", Offset = "0x5DA2D30", VA = "0x185DA4330", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA1200", Offset = "0x5D9FC00", VA = "0x185DA1200", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F81560", Offset = "0x2F7FF60", VA = "0x182F81560")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA20D0", Offset = "0x5DA0AD0", VA = "0x185DA20D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x36B8B10", Offset = "0x36B7510", VA = "0x1836B8B10")]
	public static NativeList<T> FAHCICIBODO<T>(this NativeArray<T> KHGAHLGJBLG, Allocator FKHAEPDPDAI = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class NGLDLBFAGEA
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2B64710", Offset = "0x2B63110", VA = "0x182B64710")]
	public static NativeArray<T> DHJFCIFAGBA<T>(this NativeList<Entity> KHGAHLGJBLG, EntityManager MABCFMECCKD, Allocator FKHAEPDPDAI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2B64610", Offset = "0x2B63010", VA = "0x182B64610")]
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
	[Cpp2IlInjected.Address(RVA = "0x28DFB50", Offset = "0x28DE550", VA = "0x1828DFB50")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA4150", Offset = "0x5DA2B50", VA = "0x185DA4150")]
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
	[Cpp2IlInjected.Address(RVA = "0x2EF8640", Offset = "0x2EF7040", VA = "0x182EF8640")]
	public CHOLKKIBDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2EF84F0", Offset = "0x2EF6EF0", VA = "0x182EF84F0", Slot = "4")]
	public bool GMBMHDKFMPB(int ODMCPPPIBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2EF81A0", Offset = "0x2EF6BA0", VA = "0x182EF81A0", Slot = "5")]
	public global::EILPMGINBJG<BaseClass> DKJEOCGMPBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2EF80A0", Offset = "0x2EF6AA0", VA = "0x182EF80A0", Slot = "7")]
	protected virtual bool BKIPNBPEEME(Type OGILDIMGIOH, int MEKBOFDHFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2EF8010", Offset = "0x2EF6A10", VA = "0x182EF8010", Slot = "8")]
	protected virtual int BDNFJGGHMOC(Type OGILDIMGIOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2EF8550", Offset = "0x2EF6F50", VA = "0x182EF8550")]
	public void KLMOEJEAKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2EF8450", Offset = "0x2EF6E50", VA = "0x182EF8450", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x4063AE0", Offset = "0x40624E0", VA = "0x184063AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4063EE0", Offset = "0x40628E0", VA = "0x184063EE0")]
	public EILPMGINBJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4063D40", Offset = "0x4062740", VA = "0x184063D40")]
	public EILPMGINBJG(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x40639C0", Offset = "0x40623C0", VA = "0x1840639C0")]
	internal void AGMLDLCGDGN(int ODMCPPPIBBH, BaseClass GPADBKAKFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x25F1EE0", Offset = "0x25F08E0", VA = "0x1825F1EE0")]
	public bool CLMGJHEHKEO<T>(out BaseClass LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4063A40", Offset = "0x4062440", VA = "0x184063A40")]
	public bool CLMGJHEHKEO(Type KCEEKGALKFC, out BaseClass LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x348E550", Offset = "0x348CF50", VA = "0x18348E550")]
	public bool NCJPHBOOMNI(int ODMCPPPIBBH, out BaseClass LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x25F2BF0", Offset = "0x25F15F0", VA = "0x1825F2BF0")]
	public T KJIPHFIECOL<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4063D10", Offset = "0x4062710", VA = "0x184063D10")]
	public BaseClass KJIPHFIECOL(Type KDCMMGJKBFG)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class JFFGOEBFKBM : global::CHOLKKIBDBM<NOJIPINFHEG, EHHACAEHLKG>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DA18B0", Offset = "0x5DA02B0", VA = "0x185DA18B0")]
	public JFFGOEBFKBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FIGANEKHCDA : global::CHOLKKIBDBM<IGBJMBJDJOJ, HOOPFMCFMDE>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0A80", Offset = "0x5D9F480", VA = "0x185DA0A80")]
	public FIGANEKHCDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class HEPEOHPLAMP : global::CHOLKKIBDBM<KLLNJHKGGCN, FGEMEIPGJHN>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1180", Offset = "0x5D9FB80", VA = "0x185DA1180")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D19D0", Offset = "0x8D03D0", VA = "0x1808D19D0")]
		private ComponentSystemTypes(List<Type> OFGCLOACCDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FFF0", Offset = "0x5D9E9F0", VA = "0x185D9FFF0")]
		public static void KLMOEJEAKPE(List<Type> OFGCLOACCDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FDB0", Offset = "0x5D9E7B0", VA = "0x185D9FDB0")]
		private void CHEBJAGFHEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FD30", Offset = "0x5D9E730", VA = "0x185D9FD30")]
		private bool BKIPNBPEEME(Type OGILDIMGIOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5DA0080", Offset = "0x5D9EA80", VA = "0x185DA0080")]
		private void OOOIJBLDDDJ(Type OGILDIMGIOH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class BPBHIFGCFAP : LLPKLCJBNBL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FCF0", Offset = "0x5D9E6F0", VA = "0x185D9FCF0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase BDEPGHFEAKD();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FCA0", Offset = "0x5D9E6A0", VA = "0x185D9FCA0")]
	protected ComponentSystemBase CPGILBCLKLL(params ComponentSystemBase[] DFKHIBLIHPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F7AF80", Offset = "0x1F79980", VA = "0x181F7AF80")]
	protected ComponentSystemBase CPGILBCLKLL<T>(params ComponentSystemBase[] DFKHIBLIHPO) where T : LLPKLCJBNBL, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F7B020", Offset = "0x1F79A20", VA = "0x181F7B020")]
	protected ComponentSystemBase GNHLMIDMJAE<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F7B020", Offset = "0x1F79A20", VA = "0x181F7B020")]
	protected ComponentSystemBase OLEKFFMJCLK<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	protected BPBHIFGCFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA1E20", Offset = "0x5DA0820", VA = "0x185DA1E20", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public LLPKLCJBNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class KHECDAFCLCI : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1BA0", Offset = "0x5DA05A0", VA = "0x185DA1BA0")]
	public ComponentDataFromEntity ADNIICGDIKK(int ODMCPPPIBBH, bool GLNNHMBNJIG = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1C40", Offset = "0x5DA0640", VA = "0x185DA1C40", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740")]
	protected KHECDAFCLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class CJKBCGBAKBI : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740")]
	protected CJKBCGBAKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class OCHAMNFOLEM : KHECDAFCLCI
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DA43C0", Offset = "0x5DA2DC0", VA = "0x185DA43C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
	protected void MCFEJMHAGOD(string HKNFNIPGHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777140", VA = "0x180778740")]
	protected OCHAMNFOLEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	protected OLPDJAGMDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DA5EE0", Offset = "0x5DA48E0", VA = "0x185DA5EE0")]
		public static ComponentSystemGroup[] OHHIAHEAMCH(World ACFGKGFDFPL, JIILLPMKGHD NIJJBCMFBLB = JIILLPMKGHD.Default, bool LFCIOHFLKFK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4F90", Offset = "0x5DA3990", VA = "0x185DA4F90")]
		private static Type[] FMHPAKHIOFA(JIILLPMKGHD NIJJBCMFBLB, bool LFCIOHFLKFK, ComponentSystemGroup[] LFPHNGHDAGB, ComponentSystemGroup IKJIKOONEKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5DA52F0", Offset = "0x5DA3CF0", VA = "0x185DA52F0")]
		private static ComponentSystemGroup[] GAAJLFGJBLH(World ACFGKGFDFPL, out ComponentSystemGroup IKJIKOONEKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5B80", Offset = "0x5DA4580", VA = "0x185DA5B80")]
		internal static bool LICJKNMBHPE(BFEMEIIIFID CAAHBOFLBKP, out DAFHCDFAPLO MFNNHAMJBJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5E00", Offset = "0x5DA4800", VA = "0x185DA5E00")]
		private static ComponentSystemGroup MNKGAHOOMCG(Type OGILDIMGIOH, World ACFGKGFDFPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4E60", Offset = "0x5DA3860", VA = "0x185DA4E60")]
		private static ComponentSystemGroup[] EMLGDPDOGLI(Type[] OFGCLOACCDN, World ACFGKGFDFPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5600", Offset = "0x5DA4000", VA = "0x185DA5600")]
		internal static void IOAMEGIHJLF(World ACFGKGFDFPL, Type[] JJADCBGAJDI, ComponentSystemGroup[] LFPHNGHDAGB, ComponentSystemGroup IKJIKOONEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5B20", Offset = "0x5DA4520", VA = "0x185DA5B20")]
		internal static bool KIDNMNNONCD(ComponentSystemBase HFKGGLPFCMG, ComponentSystemGroup[] LFPHNGHDAGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4E00", Offset = "0x5DA3800", VA = "0x185DA4E00")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C16B0", Offset = "0x7C00B0", VA = "0x1807C16B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
			[DebuggerHidden]
			public PNPLPKKMDHI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5DA4D20", Offset = "0x5DA3720", VA = "0x185DA4D20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5DA4A80", Offset = "0x5DA3480", VA = "0x185DA4A80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5DA4DB0", Offset = "0x5DA37B0", VA = "0x185DA4DB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5DA4CE0", Offset = "0x5DA36E0", VA = "0x185DA4CE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5DA4C30", Offset = "0x5DA3630", VA = "0x185DA4C30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5DA4C30", Offset = "0x5DA3630", VA = "0x185DA4C30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DA6B70", Offset = "0x5DA5570", VA = "0x185DA6B70")]
		public static RRFilterWorldSystems IDIKGABNBEI()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6B20", Offset = "0x5DA5520", VA = "0x185DA6B20")]
		public RRFilterWorldSystems FKIMJDCFPNF(JIILLPMKGHD CAAHBOFLBKP)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6B30", Offset = "0x5DA5530", VA = "0x185DA6B30")]
		public RRFilterWorldSystems GINGBGEFCAH(IEnumerable<Type> OFGCLOACCDN)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6F30", Offset = "0x5DA5930", VA = "0x185DA6F30")]
		public RRFilterWorldSystems PHJDMAEDPIJ(bool CEBCJEFJCOC)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6F20", Offset = "0x5DA5920", VA = "0x185DA6F20")]
		public RRFilterWorldSystems NANCCLMMJEG(bool CFDDKCJNAGE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6E90", Offset = "0x5DA5890", VA = "0x185DA6E90")]
		public EGJJCHOBCMK MDOALHFJGGO(Type[] AAFKDBEKKGL)
		{
			return default(EGJJCHOBCMK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6B90", Offset = "0x5DA5590", VA = "0x185DA6B90")]
		[IteratorStateMachine(typeof(PNPLPKKMDHI))]
		internal IEnumerable<Type> KOOPHPGIDIG(IEnumerable<Type> OFGCLOACCDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6040", Offset = "0x5DA4A40", VA = "0x185DA6040")]
		internal Dictionary<Type, List<Type>> BNOHOKIPCAP(IEnumerable<Type> OFGCLOACCDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6C20", Offset = "0x5DA5620", VA = "0x185DA6C20")]
		private void LDLJGCEMOMD(Dictionary<Type, List<Type>> BOGHIFKGACA, Type OGILDIMGIOH, Type AECEMEIMACL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6320", Offset = "0x5DA4D20", VA = "0x185DA6320")]
		internal HashSet<Type> EANJDMOBNAA(IEnumerable<Type> LFPHNGHDAGB, Dictionary<Type, List<Type>> MCHKFDMHGLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5DA64E0", Offset = "0x5DA4EE0", VA = "0x185DA64E0")]
		internal bool EGHAFJFCEDD(Type OGILDIMGIOH, JIILLPMKGHD NIJJBCMFBLB, bool LFCIOHFLKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6D30", Offset = "0x5DA5730", VA = "0x185DA6D30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA45E0", Offset = "0x5DA2FE0", VA = "0x185DA45E0")]
	public static void KADCCJJCHBP(bool HKPPDHFDHMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4640", Offset = "0x5DA3040", VA = "0x185DA4640")]
	private static void NJNABJONAHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class JKHAEHCCHGE
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1920", Offset = "0x5DA0320", VA = "0x185DA1920")]
	public static ulong LNNDJOKNNGM(Type OGILDIMGIOH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1950", Offset = "0x5DA0350", VA = "0x185DA1950")]
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
			[Cpp2IlInjected.Address(RVA = "0xE38640", Offset = "0xE37040", VA = "0x180E38640")]
			public AOIEIFKCPOM(ulong BELONAHFLCH, ulong MLICCODBALD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5D9FA80", Offset = "0x5D9E480", VA = "0x185D9FA80", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DA7420", Offset = "0x5DA5E20", VA = "0x185DA7420")]
		public static ulong DAECFLKHIHI(int ODMCPPPIBBH)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7AC0", Offset = "0x5DA64C0", VA = "0x185DA7AC0")]
		public static int LAFHFIAOIAF(ulong MLICCODBALD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5DA78D0", Offset = "0x5DA62D0", VA = "0x185DA78D0")]
		public static void KADCCJJCHBP(bool HKPPDHFDHMN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7480", Offset = "0x5DA5E80", VA = "0x185DA7480")]
		private static void DLDOBCIHKPC(int GHAKKCLOEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7100", Offset = "0x5DA5B00", VA = "0x185DA7100")]
		private static void CFFKEOAKEII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5DA77F0", Offset = "0x5DA61F0", VA = "0x185DA77F0")]
		private static AOIEIFKCPOM HEDEGMBOKGB(Type OGILDIMGIOH)
		{
			return default(AOIEIFKCPOM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7560", Offset = "0x5DA5F60", VA = "0x185DA7560")]
		private static ulong EGPEGEGAHIC(Type OGILDIMGIOH, ulong MLICCODBALD)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA75D0", Offset = "0x5DA5FD0", VA = "0x185DA75D0")]
		private static void FOICPKAIFPK(in AOIEIFKCPOM JMHLNCMMHLN, TypeManager.TypeInfo KGDPFJPDODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7B70", Offset = "0x5DA6570", VA = "0x185DA7B70")]
		private static void MCMEJMAFJNG(AOIEIFKCPOM KGDPFJPDODM, int ODMCPPPIBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7020", Offset = "0x5DA5A20", VA = "0x185DA7020")]
		private static void ACKABFPLBMG(AOIEIFKCPOM KGDPFJPDODM, int ODMCPPPIBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7C70", Offset = "0x5DA6670", VA = "0x185DA7C70")]
		private static AOIEIFKCPOM NMEJIAOEKOJ(int ODMCPPPIBBH)
		{
			return default(AOIEIFKCPOM);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7010", Offset = "0x5DA5A10", VA = "0x185DA7010")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DA2660", Offset = "0x5DA1060", VA = "0x185DA2660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::ABLONIELJLO<FGEMEIPGJHN> IEKEOGJJOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5DA2150", Offset = "0x5DA0B50", VA = "0x185DA2150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::ABLONIELJLO<EHHACAEHLKG> KADGLNEFCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5DA26C0", Offset = "0x5DA10C0", VA = "0x185DA26C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5DA21B0", Offset = "0x5DA0BB0", VA = "0x185DA21B0")]
	public static void KADCCJJCHBP(bool HKPPDHFDHMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2720", Offset = "0x5DA1120", VA = "0x185DA2720")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA0FC0", Offset = "0x5D9F9C0", VA = "0x185DA0FC0")]
	public static int HFKLKHBFEGG(int ODMCPPPIBBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1060", Offset = "0x5D9FA60", VA = "0x185DA1060")]
	public static void KADCCJJCHBP(bool HKPPDHFDHMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0CF0", Offset = "0x5D9F6F0", VA = "0x185DA0CF0")]
	private static void DEEKNFKCNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0F70", Offset = "0x5D9F970", VA = "0x185DA0F70")]
	private static int EAFNIENOPFJ(Type OGILDIMGIOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0C70", Offset = "0x5D9F670", VA = "0x185DA0C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World JAPDBJIMKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager BFILENFCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8D2930", Offset = "0x8D1330", VA = "0x1808D2930")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PHIPKIFAENI PDFOFNPFHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::EILPMGINBJG<HOOPFMCFMDE> DKDDFNMANGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7A9630", Offset = "0x7A8030", VA = "0x1807A9630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::EILPMGINBJG<FGEMEIPGJHN> IEKEOGJJOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x731A20", Offset = "0x730420", VA = "0x180731A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::EILPMGINBJG<EHHACAEHLKG> KADGLNEFCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76F9F0", VA = "0x180770FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x771120", Offset = "0x76FB20", VA = "0x180771120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> HHNOCIKFPBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8D2970", Offset = "0x8D1370", VA = "0x1808D2970")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] JPHHCAKNDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2C00", Offset = "0x5DA1600", VA = "0x185DA2C00")]
	public static MKDEFAJNDJH FGLHHMEHBKP(string AMNLGEBHFHK, BFEMEIIIFID CAAHBOFLBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3410", Offset = "0x5DA1E10", VA = "0x185DA3410")]
	public MKDEFAJNDJH(string AMNLGEBHFHK, BFEMEIIIFID CAAHBOFLBKP = BFEMEIIIFID.Simulation, JIILLPMKGHD NIJJBCMFBLB = JIILLPMKGHD.Default, bool HKPPDHFDHMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2BE0", Offset = "0x5DA15E0", VA = "0x185DA2BE0")]
	public ComponentSystemBase FCACOPJBHAF(Type OGILDIMGIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x28DE220", Offset = "0x28DCC20", VA = "0x1828DE220")]
	public T FCACOPJBHAF<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3010", Offset = "0x5DA1A10", VA = "0x185DA3010")]
	public void IDEOMPDLCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3150", Offset = "0x5DA1B50", VA = "0x185DA3150")]
	public void JNAOAONIHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2F50", Offset = "0x5DA1950", VA = "0x185DA2F50")]
	public void GNOCLHGPAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5DA29D0", Offset = "0x5DA13D0", VA = "0x185DA29D0")]
	public void AALJJDJKAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5DA33B0", Offset = "0x5DA1DB0", VA = "0x185DA33B0")]
	public void OJJNNBJOBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2FB0", Offset = "0x5DA19B0", VA = "0x185DA2FB0")]
	public void HLIEGNNPLCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3240", Offset = "0x5DA1C40", VA = "0x185DA3240")]
	public void NMPIDOOGMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5DA31B0", Offset = "0x5DA1BB0", VA = "0x185DA31B0")]
	public void MHABHGAONLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5DA30F0", Offset = "0x5DA1AF0", VA = "0x185DA30F0")]
	public void JLKAEFPOFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2B80", Offset = "0x5DA1580", VA = "0x185DA2B80")]
	public void ENFGOLIEKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2A30", Offset = "0x5DA1430", VA = "0x185DA2A30")]
	internal void DNFHDOHJODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3070", Offset = "0x5DA1A70", VA = "0x185DA3070")]
	private bool INBLLKIGFCG(ComponentSystemGroup KJJMKJFNPPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2C80", Offset = "0x5DA1680", VA = "0x185DA2C80")]
	private void GLLMDJAHEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA32A0", Offset = "0x5DA1CA0", VA = "0x185DA32A0")]
	private ComponentSystemGroup[] OHHIAHEAMCH(JIILLPMKGHD NIJJBCMFBLB, bool LFCIOHFLKFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2B10", Offset = "0x5DA1510", VA = "0x185DA2B10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	protected GJEFNKDFLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class JEJGIJMBBJC : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public JEJGIJMBBJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class FINEFFIBJOC : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public FINEFFIBJOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class HMOJICADFJI : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public HMOJICADFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class BAOCFBCJAAC : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public BAOCFBCJAAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class MAPEDCOMLFB : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public MAPEDCOMLFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class NEKDNJJLLHF : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public NEKDNJJLLHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class NHCLKIBEPDE : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public NHCLKIBEPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class CPNGMNNGNAD : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public CPNGMNNGNAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class OIDENNPLDBB : GJEFNKDFLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public OIDENNPLDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class JMEOBNBNAPP : LMFLAOGKEJF
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public JMEOBNBNAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class JCEOGDIEBAB : LMFLAOGKEJF
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public JCEOGDIEBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class JEJNLFLPINF : LMFLAOGKEJF
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public JEJNLFLPINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class MHFPHLOIMAP : LMFLAOGKEJF
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public MHFPHLOIMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC60", Offset = "0x5D9E660", VA = "0x185D9FC60")]
	public LMFLAOGKEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class ILCDEIKDENM : PHNFFMLDBFK
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xE32F50", Offset = "0xE31950", VA = "0x180E32F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public OKGKNCFCAJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1290", Offset = "0x5D9FC90", VA = "0x185DA1290")]
	static HJODMMGNFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2532BB0", Offset = "0x25315B0", VA = "0x182532BB0")]
	public static void EBKJKFHHBBP<T>(NBOMPPCKILD<T, T> LHHCABEHHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x25329B0", Offset = "0x25313B0", VA = "0x1825329B0")]
	public static void EBKJKFHHBBP<From, To>(NBOMPPCKILD<From, To> LHHCABEHHNI, NBOMPPCKILD<To, From> OHGKLADJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2532A40", Offset = "0x2531440", VA = "0x182532A40")]
	public static void EBKJKFHHBBP<From, To>(NBOMPPCKILD<From, To> MBBJKJNMLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x252D730", Offset = "0x252C130", VA = "0x18252D730")]
	public static NBOMPPCKILD<From, To> EAAPGFFHDHI<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2534A30", Offset = "0x2533430", VA = "0x182534A30")]
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
	[Cpp2IlInjected.Address(RVA = "0xCB93D0", Offset = "0xCB7DD0", VA = "0x180CB93D0")]
	public NKBHFLFMPJO(NativeArray<EntityRemapUtility.EntityRemapInfo> OOIBMPGKCKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2B26A50", Offset = "0x2B25450", VA = "0x182B26A50")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA43F0", Offset = "0x5DA2DF0", VA = "0x185DA43F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x731A30", Offset = "0x730430", VA = "0x180731A30")]
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
				[Cpp2IlInjected.Address(RVA = "0x5DA1B40", Offset = "0x5DA0540", VA = "0x185DA1B40")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long HMFHCGDCGEI
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5DA1A10", Offset = "0x5DA0410", VA = "0x185DA1A10")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5DA1A80", Offset = "0x5DA0480", VA = "0x185DA1A80")]
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
				[Cpp2IlInjected.Address(RVA = "0x5DA0B00", Offset = "0x5D9F500", VA = "0x185DA0B00")]
				public unsafe FKDNOMIPFAP(Unity.Entities.Archetype* HKFGPPCKAEL, PJLHDFLJMKK.EKNFOODINBI.EINCBHAINLA BDFDADPFIJB, NKBHFLFMPJO JCDMDNEMCAL, global::EILPMGINBJG<FGEMEIPGJHN> DKLBPBGOMJE, int GLMAMMHHIFE, int PFAEPJABOKH = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5DA0B60", Offset = "0x5D9F560", VA = "0x185DA0B60")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DA4010", Offset = "0x5DA2A10", VA = "0x185DA4010")]
			public MLBIJCEDAGJ(FKDNOMIPFAP[] BNJGAHEFJPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5DA3CE0", Offset = "0x5DA26E0", VA = "0x185DA3CE0", Slot = "4")]
			public void Invoke(int EGNHJGKABLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5DA3930", Offset = "0x5DA2330", VA = "0x185DA3930")]
			private void ALIAKFLFAPC(in FKDNOMIPFAP HIDEHJGLNHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5DA3D40", Offset = "0x5DA2740", VA = "0x185DA3D40")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public FHCOFBMIKNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5DA0A10", Offset = "0x5D9F410", VA = "0x185DA0A10")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public PEHKJBFFLAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5DA4840", Offset = "0x5DA3240", VA = "0x185DA4840")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DAB080", Offset = "0x5DA9A80", VA = "0x185DAB080")]
		private unsafe static bool OKCOPLCCGKK(Unity.Entities.Archetype* NCPPLDKIKPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5DAAD10", Offset = "0x5DA9710", VA = "0x185DAAD10")]
		internal unsafe static Unity.Entities.Archetype*[] OICIAABCDGK(ref Unity.Entities.EntityComponentStore OLBCBGFBBGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB400", Offset = "0x5DA9E00", VA = "0x185DAB400")]
		public static void PEEAKNCHPCN(MKDEFAJNDJH ACFGKGFDFPL, out ByteString EICPLPLLHGP, out NativeArray<EntityRemapUtility.EntityRemapInfo> IGIGBKFKHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7D90", Offset = "0x5DA6790", VA = "0x185DA7D90")]
		internal static void ABPPPPHEFJC(MKDEFAJNDJH ACFGKGFDFPL, PJLHDFLJMKK IGGLPHHHOFD, out NativeArray<EntityRemapUtility.EntityRemapInfo> IGIGBKFKHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8810", Offset = "0x5DA7210", VA = "0x185DA8810")]
		private unsafe static UnsafeHashMap<ulong, JPLFAEABIDI> BNAOJHIJMKJ(Unity.Entities.Archetype*[] FIDGLPJCAFL)
		{
			return default(UnsafeHashMap<ulong, JPLFAEABIDI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9630", Offset = "0x5DA8030", VA = "0x185DA9630")]
		private static void IJCECFEEILP(PJLHDFLJMKK IGGLPHHHOFD, UnsafeHashMap<ulong, JPLFAEABIDI> LLGFAPHLCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB4C0", Offset = "0x5DA9EC0", VA = "0x185DAB4C0")]
		private unsafe static void PMMAHBHNAPM(PJLHDFLJMKK IGGLPHHHOFD, Unity.Entities.Archetype*[] FIDGLPJCAFL, UnsafeHashMap<ulong, JPLFAEABIDI> LLGFAPHLCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA990", Offset = "0x5DA9390", VA = "0x185DAA990")]
		private unsafe static int NLMEDFFOCBL(Unity.Entities.Archetype*[] FIDGLPJCAFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9210", Offset = "0x5DA7C10", VA = "0x185DA9210")]
		private unsafe static void HFNOHMFPMFH(PJLHDFLJMKK IGGLPHHHOFD, Unity.Entities.Archetype*[] FIDGLPJCAFL, global::EILPMGINBJG<FGEMEIPGJHN> DKLBPBGOMJE, NativeArray<EntityRemapUtility.EntityRemapInfo> IGIGBKFKHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB190", Offset = "0x5DA9B90", VA = "0x185DAB190")]
		private static NativeArray<int> OOOHMBHBLHC(PJLHDFLJMKK IGGLPHHHOFD)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9000", VA = "0x185DAA600")]
		private static Memory<EntityArchetype> NFDAOIIDMPJ(PJLHDFLJMKK IGGLPHHHOFD, NativeArray<int> OFGCLOACCDN, EntityManager MABCFMECCKD, out int HFFNDLACKLL, out int ODGDHOHLBIP)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA84C0", Offset = "0x5DA6EC0", VA = "0x185DA84C0")]
		private unsafe static void BMEHJEBAKPC(Unity.Entities.Chunk* NMNHKEICFGN, ReadOnlySpan<byte> EICPLPLLHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA97E0", Offset = "0x5DA81E0", VA = "0x185DA97E0")]
		private static void KIMHMPACIEE(PJLHDFLJMKK IGGLPHHHOFD, NativeArray<int> OFGCLOACCDN, Span<EntityArchetype> FIDGLPJCAFL, EntityManager MABCFMECCKD, global::EILPMGINBJG<FGEMEIPGJHN> DKLBPBGOMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8B40", Offset = "0x5DA7540", VA = "0x185DA8B40")]
		private unsafe static void DPFHDCNICON(Unity.Entities.Chunk* ONPLFJPHGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5DAAA00", Offset = "0x5DA9400", VA = "0x185DAAA00")]
		private unsafe static void OCGJPMFDJJH(PJLHDFLJMKK.EKNFOODINBI.EINCBHAINLA HKFGPPCKAEL, int LNCJALCPHED, int NHNJGCLOJBH, Unity.Entities.Chunk* NMNHKEICFGN, PJLHDFLJMKK IGGLPHHHOFD, NativeArray<int> OFGCLOACCDN, global::EILPMGINBJG<FGEMEIPGJHN> DKLBPBGOMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9F20", Offset = "0x5DA8920", VA = "0x185DA9F20")]
		public static void LCABLNOIOIK(MKDEFAJNDJH ACFGKGFDFPL, in ByteString EICPLPLLHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9FB0", Offset = "0x5DA89B0", VA = "0x185DA9FB0")]
		public static void LCABLNOIOIK(EntityManager MABCFMECCKD, global::EILPMGINBJG<FGEMEIPGJHN> DKLBPBGOMJE, in ByteString EICPLPLLHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8BC0", Offset = "0x5DA75C0", VA = "0x185DA8BC0")]
		private static bool FILLHKACBFD(Type OGILDIMGIOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8E80", Offset = "0x5DA7880", VA = "0x185DA8E80")]
		private static void GODJDOGLKNA(TypeManager.TypeInfo KGDPFJPDODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5DAAEF0", Offset = "0x5DA98F0", VA = "0x185DAAEF0")]
		private unsafe static int OJNHNDALFFJ(Unity.Entities.Archetype*[] FIDGLPJCAFL, NativeArray<EntityRemapUtility.EntityRemapInfo> IGIGBKFKHFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9130", Offset = "0x5DA7B30", VA = "0x185DA9130")]
		private static int HFKLKHBFEGG(int ODMCPPPIBBH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8AA0", Offset = "0x5DA74A0", VA = "0x185DA8AA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DA0130", Offset = "0x5D9EB30", VA = "0x185DA0130")]
	private unsafe static Span<byte> AFFEDLJMPMM(Unity.Entities.Chunk* ONPLFJPHGKJ, int GLMAMMHHIFE)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x28AD370", Offset = "0x28ABD70", VA = "0x1828AD370")]
	public unsafe static Span<T> EMNDELNPAMA<T>(Unity.Entities.Chunk* ONPLFJPHGKJ, int GLMAMMHHIFE)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x28AD4F0", Offset = "0x28ABEF0", VA = "0x1828AD4F0")]
	public static Span<T> EMNDELNPAMA<T>(this ref Unity.Entities.Chunk ONPLFJPHGKJ, int GLMAMMHHIFE)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0570", Offset = "0x5D9EF70", VA = "0x185DA0570")]
	public unsafe static Span<Entity> KAMHHFEPBKC(Unity.Entities.Chunk* ONPLFJPHGKJ)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DA02D0", Offset = "0x5D9ECD0", VA = "0x185DA02D0")]
	public unsafe static void BONIBAPHNIO(Unity.Entities.Chunk* ONPLFJPHGKJ, int GLMAMMHHIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DA05E0", Offset = "0x5D9EFE0", VA = "0x185DA05E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5DABA50", Offset = "0x5DAA450", VA = "0x185DABA50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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

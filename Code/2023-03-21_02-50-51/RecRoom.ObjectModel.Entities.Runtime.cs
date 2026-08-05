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
		[Cpp2IlInjected.Address(RVA = "0x59F2930", Offset = "0x59F1130", VA = "0x1859F2930")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x59F3C20", Offset = "0x59F2420", VA = "0x1859F3C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x59F3C90", Offset = "0x59F2490", VA = "0x1859F3C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x4355920", Offset = "0x4354120", VA = "0x184355920", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2449670", Offset = "0x2447E70", VA = "0x182449670")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2448EA0", Offset = "0x24476A0", VA = "0x182448EA0")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2448FA0", Offset = "0x24477A0", VA = "0x182448FA0")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x24493A0", Offset = "0x2447BA0", VA = "0x1824493A0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x59F3CB0", Offset = "0x59F24B0", VA = "0x1859F3CB0")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GJOLFBIEAJA<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GKIMLCPDDEJ : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::GJOLFBIEAJA<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F6040", Offset = "0x6F4840", VA = "0x1806F6040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x27333F0", Offset = "0x2731BF0", VA = "0x1827333F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1492A40", Offset = "0x1491240", VA = "0x181492A40")]
		[DebuggerHidden]
		public GKIMLCPDDEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2733210", Offset = "0x2731A10", VA = "0x182733210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x27333B0", Offset = "0x2731BB0", VA = "0x1827333B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> EMDNJGKGIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream LPIADEMPDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream MPLCNGHKNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf HDLDANNDPFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int CADKIJKDIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D5010", Offset = "0x6D3810", VA = "0x1806D5010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27313D0", Offset = "0x272FBD0", VA = "0x1827313D0")]
	private GJOLFBIEAJA(byte[] DNLJJNDPNCG, Action<Protobuf> EMDNJGKGIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A66300", Offset = "0x2A64B00", VA = "0x182A66300")]
	public static global::GJOLFBIEAJA<Protobuf> OJONNLHFKNA<Data>(ReadOnlySpan<byte> GJAPHEDPMNB, ReadOnlySpan<Data> GDAMMKPBIEJ, Action<Protobuf> EMDNJGKGIMB)
	{
		return default(global::GJOLFBIEAJA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2731240", Offset = "0x272FA40", VA = "0x182731240", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2731280", Offset = "0x272FA80", VA = "0x182731280", Slot = "4")]
	[IteratorStateMachine(typeof(global::GJOLFBIEAJA<>.GKIMLCPDDEJ))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2731380", Offset = "0x272FB80", VA = "0x182731380", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AGECCCLEKNJ<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] DNLJJNDPNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf HDLDANNDPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream LPIADEMPDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream JAGBNBOIKFL;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x33ABC40", Offset = "0x33AA440", VA = "0x1833ABC40")]
	private AGECCCLEKNJ(byte[] DNLJJNDPNCG, in Protobuf HDLDANNDPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB700", Offset = "0x1FC9F00", VA = "0x181FCB700")]
	public static global::AGECCCLEKNJ<Protobuf> OJONNLHFKNA<T>(ReadOnlySpan<T> GDAMMKPBIEJ)
	{
		return default(global::AGECCCLEKNJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x33ABA50", Offset = "0x33AA250", VA = "0x1833ABA50")]
	public void AFLLIMNMCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x33ABBB0", Offset = "0x33AA3B0", VA = "0x1833ABBB0")]
	public ByteString MJIMJFIOAII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x33ABA80", Offset = "0x33AA280", VA = "0x1833ABA80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OCNHMNFFLJP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream LPIADEMPDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream MPLCNGHKNIM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x59F6E30", Offset = "0x59F5630", VA = "0x1859F6E30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct DDCHGLGKPHI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] DNLJJNDPNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream LPIADEMPDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream JAGBNBOIKFL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x59F3330", Offset = "0x59F1B30", VA = "0x1859F3330", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IHNBMAKACML
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	public static void ONFKFPPJGEH(this DELGGOALDMF MGFJDFPNJKC, NativeArray<Entity> NBDCDJJEKHD, [Optional][CallerFilePath] string JOKELAACHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	public static void ONFKFPPJGEH(this DELGGOALDMF MGFJDFPNJKC, string LOIAMCEJAFO, NativeArray<Entity> NBDCDJJEKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	public static void ONFKFPPJGEH(this DELGGOALDMF MGFJDFPNJKC, string JOKELAACHNK, NativeArray<Entity> NBDCDJJEKHD, bool EPGENEEAIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	public static void LNAIDELFAKO(this DELGGOALDMF MGFJDFPNJKC, NativeArray<Entity> NBDCDJJEKHD, NativeArray<Entity> OJCGOLJENME, [Optional][CallerFilePath] string JOKELAACHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	public static void LNAIDELFAKO(this DELGGOALDMF MGFJDFPNJKC, string JOKELAACHNK, NativeArray<Entity> NBDCDJJEKHD, NativeArray<Entity> OJCGOLJENME, bool EPGENEEAIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x36E6AE0", Offset = "0x36E52E0", VA = "0x1836E6AE0")]
	public static void FMPGHPJFLGK<T>(this DELGGOALDMF MGFJDFPNJKC, string LOIAMCEJAFO, NativeArray<Entity> NBDCDJJEKHD, NativeList<T> LBEMEOBAAJI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x36E6AA0", Offset = "0x36E52A0", VA = "0x1836E6AA0")]
	public static void FMPGHPJFLGK<T>(this DELGGOALDMF MGFJDFPNJKC, string LOIAMCEJAFO, NativeArray<Entity> NBDCDJJEKHD, NativeArray<T> LBEMEOBAAJI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	public static void FMPGHPJFLGK<T>(this DELGGOALDMF MGFJDFPNJKC, string JOKELAACHNK, NativeArray<Entity> NBDCDJJEKHD, NativeArray<T> LBEMEOBAAJI, bool EPGENEEAIGN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x36E6B70", Offset = "0x36E5370", VA = "0x1836E6B70")]
	public static void OCPHOCFCAAO<T>(this DELGGOALDMF MGFJDFPNJKC, NativeList<T> LBEMEOBAAJI, [Optional][CallerFilePath] string JOKELAACHNK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x36E6BE0", Offset = "0x36E53E0", VA = "0x1836E6BE0")]
	public static void OCPHOCFCAAO<T>(this DELGGOALDMF MGFJDFPNJKC, NativeArray<T> LBEMEOBAAJI, [Optional][CallerFilePath] string JOKELAACHNK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	public static void OCPHOCFCAAO<T>(this DELGGOALDMF MGFJDFPNJKC, string JOKELAACHNK, NativeArray<T> LBEMEOBAAJI, bool EPGENEEAIGN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	public static void NOLEOEFNFFH(this DELGGOALDMF MGFJDFPNJKC, EntityQuery PPFDACOOOGO, [Optional][CallerFilePath] string JOKELAACHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	public static void NOLEOEFNFFH(this DELGGOALDMF MGFJDFPNJKC, string LOIAMCEJAFO, EntityQuery PPFDACOOOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	public static void NOLEOEFNFFH(this DELGGOALDMF MGFJDFPNJKC, string JOKELAACHNK, EntityQuery PPFDACOOOGO, bool EPGENEEAIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x36E6C10", Offset = "0x36E5410", VA = "0x1836E6C10")]
	public static void OLNKFNPNMHL<T, T2>(this DELGGOALDMF MGFJDFPNJKC, string LOIAMCEJAFO, EntityQuery PPFDACOOOGO) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	private static void OLNKFNPNMHL<T, T2>(this DELGGOALDMF MGFJDFPNJKC, string JOKELAACHNK, EntityQuery PPFDACOOOGO, bool EPGENEEAIGN) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EPJOCCFBHFH : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BDEOIFFCGBF BIMLGGHFDNE
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
public interface PBHKOLDMHPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GDKBAOKJPMD(Entity DJGIAPPGDDP, object JPCLKLIDFBB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DFBHNGIANOK(Entity DJGIAPPGDDP, object JPCLKLIDFBB);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFNAMFBPCMD(Entity DJGIAPPGDDP);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GFNAMFBPCMD(BDEOIFFCGBF AEGKMFNDGLH);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> NCDICNADBEG(Entity DJGIAPPGDDP);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LHEPLKGBNHG(Entity DJGIAPPGDDP);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JEKNJGCOJLP<TComponentData, TValue> : global::DFPEFKJKIIK<TValue>, IDisposable where TComponentData : struct, EPJOCCFBHFH
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class FHJPOANPMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> HGPMCGJIADE;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int EIFLHBHGPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x17FF070", Offset = "0x17FD870", VA = "0x1817FF070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2C77C30", Offset = "0x2C76430", VA = "0x182C77C30")]
		public bool LKBCJMDBJBB(out TValue NPHADDCNBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2C77B80", Offset = "0x2C76380", VA = "0x182C77B80")]
		public void LGCDELLOPGJ(object JPCLKLIDFBB, TValue NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2C77A50", Offset = "0x2C76250", VA = "0x182C77A50")]
		public bool ALIFOBNBCOA(object JPCLKLIDFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2C77AD0", Offset = "0x2C762D0", VA = "0x182C77AD0")]
		public int FDIMGBOHNMI(object JPCLKLIDFBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2C77CF0", Offset = "0x2C764F0", VA = "0x182C77CF0")]
		public FHJPOANPMJK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<FHJPOANPMJK> NJMIFNDBMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::IBOAEEDDPMB<BDEOIFFCGBF, FHJPOANPMJK> PFAJFCEBAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager AIFDIGHJEAF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x259A370", Offset = "0x2598B70", VA = "0x18259A370")]
	public JEKNJGCOJLP(EntityManager AIFDIGHJEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2599FB0", Offset = "0x25987B0", VA = "0x182599FB0", Slot = "4")]
	public void GDKBAOKJPMD(Entity DJGIAPPGDDP, object JPCLKLIDFBB, TValue NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2599D50", Offset = "0x2598550", VA = "0x182599D50", Slot = "5")]
	public bool DFBHNGIANOK(Entity DJGIAPPGDDP, object JPCLKLIDFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x259A220", Offset = "0x2598A20", VA = "0x18259A220", Slot = "6")]
	public bool LKBCJMDBJBB(Entity DJGIAPPGDDP, out TValue NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2599EC0", Offset = "0x25986C0", VA = "0x182599EC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x259A2F0", Offset = "0x2598AF0", VA = "0x18259A2F0")]
	private void MCCEAOKBDFG(FHJPOANPMJK FNHNPELADGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2599EE0", Offset = "0x25986E0", VA = "0x182599EE0")]
	private bool EHNBAOAAEEI(Entity DJGIAPPGDDP, out BDEOIFFCGBF AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x259A0D0", Offset = "0x25988D0", VA = "0x18259A0D0")]
	private void GLIOLPAEEFJ(Entity DJGIAPPGDDP, BDEOIFFCGBF AEGKMFNDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2599F90", Offset = "0x2598790", VA = "0x182599F90")]
	private bool EINHFFNPIGD(BDEOIFFCGBF AEGKMFNDGLH, out FHJPOANPMJK FNHNPELADGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x259A160", Offset = "0x2598960", VA = "0x18259A160")]
	private FHJPOANPMJK GNLDLLNMAMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DFPEFKJKIIK<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDKBAOKJPMD(Entity DJGIAPPGDDP, object JPCLKLIDFBB, TValue NPHADDCNBHE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DFBHNGIANOK(Entity DJGIAPPGDDP, object JPCLKLIDFBB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LKBCJMDBJBB(Entity DJGIAPPGDDP, out TValue NPHADDCNBHE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BDEOIFFCGBF : global::DOCOAIDEBOB<BDEOIFFCGBF>, NHMOKLKPBCB, IEquatable<BDEOIFFCGBF>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly BDEOIFFCGBF ADEPDEBKGGB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int FPGJPBIHINK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x786DB0", Offset = "0x7855B0", VA = "0x180786DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int JAFPKKDIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x89E550", Offset = "0x89CD50", VA = "0x18089E550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xDD7530", Offset = "0xDD5D30", VA = "0x180DD7530", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x59F2A80", Offset = "0x59F1280", VA = "0x1859F2A80", Slot = "8")]
	public bool Equals(BDEOIFFCGBF HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x59F2AD0", Offset = "0x59F12D0", VA = "0x1859F2AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CACIMGOHFBI<T> : PBHKOLDMHPC, IDisposable where T : struct, EPJOCCFBHFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> NJMIFNDBMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::IBOAEEDDPMB<BDEOIFFCGBF, HashSet<object>> PFAJFCEBAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager AIFDIGHJEAF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3B8EEF0", Offset = "0x3B8D6F0", VA = "0x183B8EEF0")]
	public CACIMGOHFBI(EntityManager AIFDIGHJEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3B8CBD0", Offset = "0x3B8B3D0", VA = "0x183B8CBD0", Slot = "4")]
	public bool GDKBAOKJPMD(Entity DJGIAPPGDDP, object JPCLKLIDFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B8BF10", Offset = "0x3B8A710", VA = "0x183B8BF10", Slot = "5")]
	public bool DFBHNGIANOK(Entity DJGIAPPGDDP, object JPCLKLIDFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3B8D170", Offset = "0x3B8B970", VA = "0x183B8D170", Slot = "6")]
	public bool GFNAMFBPCMD(Entity DJGIAPPGDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3B8D1F0", Offset = "0x3B8B9F0", VA = "0x183B8D1F0", Slot = "7")]
	public bool GFNAMFBPCMD(BDEOIFFCGBF AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3B8EAB0", Offset = "0x3B8D2B0", VA = "0x183B8EAB0", Slot = "8")]
	public IEnumerable<object> NCDICNADBEG(Entity DJGIAPPGDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3B8EB70", Offset = "0x3B8D370", VA = "0x183B8EB70", Slot = "11")]
	public IEnumerable<object> NCDICNADBEG(BDEOIFFCGBF AEGKMFNDGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3B8DD30", Offset = "0x3B8C530", VA = "0x183B8DD30", Slot = "9")]
	public bool LHEPLKGBNHG(Entity DJGIAPPGDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B8C450", Offset = "0x3B8AC50", VA = "0x183B8C450", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3B8E580", Offset = "0x3B8CD80", VA = "0x183B8E580")]
	private void MCCEAOKBDFG(HashSet<object> FNHNPELADGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3B8C810", Offset = "0x3B8B010", VA = "0x183B8C810")]
	private bool EHNBAOAAEEI(Entity DJGIAPPGDDP, out BDEOIFFCGBF AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3B8E000", Offset = "0x3B8C800", VA = "0x183B8E000")]
	private bool LPDFEAPODHB(Entity DJGIAPPGDDP, out BDEOIFFCGBF AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3B8ECD0", Offset = "0x3B8D4D0", VA = "0x183B8ECD0")]
	private void OKEEMNHJAEP(Entity DJGIAPPGDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3B8D620", Offset = "0x3B8BE20", VA = "0x183B8D620")]
	private void GLIOLPAEEFJ(Entity DJGIAPPGDDP, BDEOIFFCGBF AEGKMFNDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3B8C8B0", Offset = "0x3B8B0B0", VA = "0x183B8C8B0")]
	private bool ELNJKGNDDHL(BDEOIFFCGBF AEGKMFNDGLH, out HashSet<object> FNHNPELADGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B8D9C0", Offset = "0x3B8C1C0", VA = "0x183B8D9C0")]
	private HashSet<object> GNLDLLNMAMJ()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ABFOEHEMOMN : global::HOCMJHODHFA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x59F2000", Offset = "0x59F0800", VA = "0x1859F2000", Slot = "4")]
	public float BGCCCMDHIBF(float3 NPHADDCNBHE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HNGFLFFOIBI : global::HOCMJHODHFA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x59F47D0", Offset = "0x59F2FD0", VA = "0x1859F47D0", Slot = "4")]
	public float BGCCCMDHIBF(float3 NPHADDCNBHE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NOEEDAGFDDG : global::HOCMJHODHFA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x59F6890", Offset = "0x59F5090", VA = "0x1859F6890", Slot = "4")]
	public float BGCCCMDHIBF(float3 NPHADDCNBHE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct CIIKLDPAMCH : global::HOCMJHODHFA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x138ADD0", Offset = "0x13895D0", VA = "0x18138ADD0", Slot = "4")]
	public int BGCCCMDHIBF(int3 NPHADDCNBHE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OEIDHOKNFCL : global::HOCMJHODHFA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4517060", Offset = "0x4515860", VA = "0x184517060", Slot = "4")]
	public int BGCCCMDHIBF(int3 NPHADDCNBHE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct LKBHGPFJIKN : global::HOCMJHODHFA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x59F5DD0", Offset = "0x59F45D0", VA = "0x1859F5DD0", Slot = "4")]
	public int BGCCCMDHIBF(int3 NPHADDCNBHE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class IPKAMMDCFEN : ENPMBAGPCIO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type NAPCLHBOPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F5130", Offset = "0x6F3930", VA = "0x1806F5130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xEA04C0", Offset = "0xE9ECC0", VA = "0x180EA04C0")]
	public IPKAMMDCFEN(Type GJBDIKKOLAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IIFGFLKKOJA : IPKAMMDCFEN
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xEA04C0", Offset = "0xE9ECC0", VA = "0x180EA04C0")]
	public IIFGFLKKOJA(Type GJBDIKKOLAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DOADLHAPKEN : IPKAMMDCFEN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type PDEPAFHIIAP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5140", Offset = "0x6F3940", VA = "0x1806F5140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x59F3460", Offset = "0x59F1C60", VA = "0x1859F3460")]
	public DOADLHAPKEN(Type OCAFJFLGBHA, Type GJBDIKKOLAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IGLOFDAMHJI : IPKAMMDCFEN
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xEA04C0", Offset = "0xE9ECC0", VA = "0x180EA04C0")]
	public IGLOFDAMHJI(Type GJBDIKKOLAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OIGNJMDILHE : ENPMBAGPCIO
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public OIGNJMDILHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BIHGCNEEIAG : ENPMBAGPCIO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EJBDBMPHFMP JHGFEMOJAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
		[CompilerGenerated]
		get
		{
			return default(EJBDBMPHFMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xEA0450", Offset = "0xE9EC50", VA = "0x180EA0450")]
	public BIHGCNEEIAG(EJBDBMPHFMP DOJAOGGMBHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class NBDMAOHFKJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly KPAAIPGAPMC IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager AIFDIGHJEAF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public KPAAIPGAPMC BCCOIHBMLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x59F6470", Offset = "0x59F4C70", VA = "0x1859F6470")]
	public NBDMAOHFKJB(KPAAIPGAPMC IFJKGEPFDIB, EntityManager AIFDIGHJEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1F1BC50", Offset = "0x1F1A450", VA = "0x181F1BC50")]
	public bool ADLLDFMOJEP<T>(Entity DJGIAPPGDDP) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1F1DE70", Offset = "0x1F1C670", VA = "0x181F1DE70")]
	public bool PJFAFGAOMKN<T>(Entity DJGIAPPGDDP, out T NPHADDCNBHE) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1F1C490", Offset = "0x1F1AC90", VA = "0x181F1C490")]
	public T NAFJIDLCFKL<T>(Entity DJGIAPPGDDP) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1F1BC90", Offset = "0x1F1A490", VA = "0x181F1BC90")]
	private ComponentType CLEOOCHACFD<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x59F63A0", Offset = "0x59F4BA0", VA = "0x1859F63A0")]
	private ComponentType CLEOOCHACFD(Type EHPFPOFFCEJ)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class FOKEMBEEBHE
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	protected FOKEMBEEBHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class OKANEIKOLPE<View, Data> : NDFGOBMDHCC where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType FIJIIABGJNK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type CEGIFDLHDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x35695A0", Offset = "0x3567DA0", VA = "0x1835695A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type HDLDCLGPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3568A80", Offset = "0x3567280", VA = "0x183568A80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int DEADDICONMN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x35690A0", Offset = "0x35678A0", VA = "0x1835690A0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3569160", Offset = "0x3567960", VA = "0x183569160")]
	public Data DBJGJFHDNKG(Entity DJGIAPPGDDP)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x35691D0", Offset = "0x35679D0", VA = "0x1835691D0")]
	public Data GNPFFENJIHE(Entity DJGIAPPGDDP)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View DLGBJBAENIF(Entity DJGIAPPGDDP);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x44D8800", Offset = "0x44D7000", VA = "0x1844D8800", Slot = "15")]
	protected internal override T DLGBJBAENIF<T>(Entity DJGIAPPGDDP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x149BDE0", Offset = "0x149A5E0", VA = "0x18149BDE0")]
	protected OKANEIKOLPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class NDFGOBMDHCC : KKMMECBGMDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic NHHBBEBBEHN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager NKKGJCLICDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xB6A920", Offset = "0xB69120", VA = "0x180B6A920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type CEGIFDLHDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type HDLDCLGPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int DEADDICONMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type HBBAPJOMGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE70", Offset = "0x7DB670", VA = "0x1807DCE70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int KBHIEPBGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x59F6820", Offset = "0x59F5020", VA = "0x1859F6820", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private PEFKAJGNEDD[] IDINLKIFFOD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7DCDA0", Offset = "0x7DB5A0", VA = "0x1807DCDA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual PEFKAJGNEDD[] HLEJCLDEHEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x59F6610", Offset = "0x59F4E10", VA = "0x1859F6610", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EBAHDAHMNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x59F66D0", Offset = "0x59F4ED0", VA = "0x1859F66D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x59F6700", Offset = "0x59F4F00", VA = "0x1859F6700")]
	public void ODGJJHFNDHJ(EntityManager AIFDIGHJEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E20", Offset = "0x7F2620", VA = "0x1807F3E20")]
	protected KKMMECBGMDP AOGDPIEJPPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T DLGBJBAENIF<T>(Entity DJGIAPPGDDP) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x59F6550", Offset = "0x59F4D50", VA = "0x1859F6550", Slot = "8")]
	public (uint, uint) AOLKCKLJFOE(Entity DJGIAPPGDDP)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x59F64C0", Offset = "0x59F4CC0", VA = "0x1859F64C0", Slot = "9")]
	public bool AJIPCBEEDJJ(Entity DJGIAPPGDDP, (uint order, uint change) OGPINCOPHCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	protected NDFGOBMDHCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class LGKEGBHEDDP<Data> : KDIEDIBMBFJ where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data KKHIANFEDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2D00240", Offset = "0x2CFEA40", VA = "0x182D00240", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2389790", Offset = "0x2387F90", VA = "0x182389790", Slot = "8")]
	protected virtual bool DGKCGBDJEIM(ReadOnlySpan<Data> GDAMMKPBIEJ, AFDHGGDCOPP HIGOLFJOLNG, out ReadOnlySpan<byte> GJAPHEDPMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "9")]
	protected virtual bool GPCMOABGGOK(int OGPINCOPHCL, Span<Data> GDAMMKPBIEJ, in ReadOnlySpan<byte> GJAPHEDPMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2D00160", Offset = "0x2CFE960", VA = "0x182D00160", Slot = "5")]
	internal sealed override bool DGKCGBDJEIM(ref Unity.Entities.Chunk FMCANOMFDBO, int DHODPIHCCEC, AFDHGGDCOPP HIGOLFJOLNG, out ReadOnlySpan<byte> GJAPHEDPMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D00EF0", Offset = "0x2CFF6F0", VA = "0x182D00EF0", Slot = "6")]
	internal sealed override bool GPCMOABGGOK(int OGPINCOPHCL, ref Unity.Entities.Chunk FMCANOMFDBO, int DHODPIHCCEC, in ReadOnlySpan<byte> GJAPHEDPMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x21C52D0", Offset = "0x21C3AD0", VA = "0x1821C52D0")]
	protected global::AGECCCLEKNJ<Protobuf> LAFCLBGNIBM<Protobuf>(ReadOnlySpan<Data> GDAMMKPBIEJ) where Protobuf : IMessage, new()
	{
		return default(global::AGECCCLEKNJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x21C5320", Offset = "0x21C3B20", VA = "0x1821C5320")]
	protected global::GJOLFBIEAJA<Protobuf> PHCLIMILCFO<Protobuf>(ReadOnlySpan<byte> GJAPHEDPMNB, ReadOnlySpan<Data> GDAMMKPBIEJ, Action<Protobuf> EMDNJGKGIMB) where Protobuf : IMessage, new()
	{
		return default(global::GJOLFBIEAJA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x149BDE0", Offset = "0x149A5E0", VA = "0x18149BDE0")]
	protected LGKEGBHEDDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class KDIEDIBMBFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int JAFPKKDIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x59F4BB0", Offset = "0x59F33B0", VA = "0x1859F4BB0", Slot = "5")]
	internal virtual bool DGKCGBDJEIM(ref Unity.Entities.Chunk FMCANOMFDBO, int DHODPIHCCEC, AFDHGGDCOPP HIGOLFJOLNG, out ReadOnlySpan<byte> GJAPHEDPMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "6")]
	internal virtual bool GPCMOABGGOK(int OGPINCOPHCL, ref Unity.Entities.Chunk FMCANOMFDBO, int DHODPIHCCEC, in ReadOnlySpan<byte> GJAPHEDPMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	protected KDIEDIBMBFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HOCMJHODHFA<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo BGCCCMDHIBF(TFrom NPHADDCNBHE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface AOLGENPJMBB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GOPFCAICKKI(T NPHADDCNBHE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct CPHHHOBFMOA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::HOCMJHODHFA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> GHBBNOHOOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> INHIFDKEOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap BEHJPKINPFB;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct IOEEKAEAMDI<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::HOCMJHODHFA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> JBNDPNEABBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> INHIFDKEOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap BEHJPKINPFB;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct NIIJEHOEPLC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ABECNJHGEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> GHBBNOHOOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> INHIFDKEOLE;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x34C5F90", Offset = "0x34C4790", VA = "0x1834C5F90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct GBJMPMFABNP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ABECNJHGEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> GHBBNOHOOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> IHILKKABLOH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct CNODEBAFJIF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::HOCMJHODHFA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> GNIJKGLMPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> INHIFDKEOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap BEHJPKINPFB;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct HJNOCAMCGMA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GJBDIKKOLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> MMGHHCCOBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> BPKBMJFMPDK;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct LAGOKDHDDAB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GJBDIKKOLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> MMGHHCCOBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> BPKBMJFMPDK;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E920", Offset = "0x1C5D120", VA = "0x181C5E920", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct KEBAKCGJPJF<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> GHBBNOHOOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> IHILKKABLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, HKDLOMPDCOH> IIAHLGNADOM;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x25F27F0", Offset = "0x25F0FF0", VA = "0x1825F27F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct KFDKJGFGNCA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::HOCMJHODHFA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> GHBBNOHOOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> IHILKKABLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, HKDLOMPDCOH> IIAHLGNADOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap BEHJPKINPFB;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct HGCHBCGPOJA<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::AOLGENPJMBB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> GHBBNOHOOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> IHILKKABLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate BEHJPKINPFB;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct MHHOJCNOMFN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity GJBDIKKOLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> MMGHHCCOBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> NGNEDBHONCN;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x59F6110", Offset = "0x59F4910", VA = "0x1859F6110", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct DCMMEPFKGJA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity GJBDIKKOLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> MMGHHCCOBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> NGNEDBHONCN;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x59F32A0", Offset = "0x59F1AA0", VA = "0x1859F32A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IFHJHFEHFFJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class BCLHNECCGIK
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x23DFE60", Offset = "0x23DE660", VA = "0x1823DFE60")]
	public static bool LGGNJLEDNHD<T>(this NativeArray<Entity> MMGHHCCOBFM, EntityManager AIFDIGHJEAF, Allocator OODGOAPHOCI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class KLOIGEHOMNL
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class BFKJKDPFDGA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public BFKJKDPFDGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class COPKJGEIPJA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public COPKJGEIPJA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> GAIGPKIKKBN;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x59F4DC0", Offset = "0x59F35C0", VA = "0x1859F4DC0")]
	public KLOIGEHOMNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KAIBNDGFKOG
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CJMEAOFKPPL
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct NBOEJMIHICB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct CNOCBPANPMP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal NBOEJMIHICB<TFrom> FAAJOMIIHED;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator OODGOAPHOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> OEDLDNKMKMJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct KBGAGAFCCFF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct KHAKLFFKMHH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal KBGAGAFCCFF<TFrom> FAAJOMIIHED;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator OODGOAPHOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> OEDLDNKMKMJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct HPMMKLJPKCE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct OBLKDODCIIL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal HPMMKLJPKCE<TFrom> FAAJOMIIHED;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator OODGOAPHOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> OEDLDNKMKMJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct HHHEBKIEMKE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct HMHEBEDMFBL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal HHHEBKIEMKE<TFrom> FAAJOMIIHED;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator OODGOAPHOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> OEDLDNKMKMJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class KOLGMFFPCPG
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class GNANPHOEOLD
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2556FE0", Offset = "0x25557E0", VA = "0x182556FE0")]
	public static NativeList<T> IMPAHLDIJGN<T>(this NativeArray<T> OBDFPODMPBN, Allocator OODGOAPHOCI = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class OGHGEHJHIPI
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2280180", Offset = "0x227E980", VA = "0x182280180")]
	public static NativeArray<T> BCLICEAHACF<T>(this NativeList<Entity> OBDFPODMPBN, EntityManager AIFDIGHJEAF, Allocator OODGOAPHOCI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2280080", Offset = "0x227E880", VA = "0x182280080")]
	public static NativeArray<T> BCLICEAHACF<T>(this NativeArray<Entity> OBDFPODMPBN, EntityManager AIFDIGHJEAF, Allocator OODGOAPHOCI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class FODAGMMPIHD
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct AGGJGLBCJKF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct GBCGPBMBNMM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AGGJGLBCJKF<TFrom> OEDLDNKMKMJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator OODGOAPHOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> GHBBNOHOOPL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct MAKNKAHPGLL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct MGBKEBGFFBO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public MAKNKAHPGLL<TFrom> OEDLDNKMKMJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator OODGOAPHOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> GHBBNOHOOPL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct FLKGOHGCGPP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct FJNKAHOAOJA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public FLKGOHGCGPP<TFrom> OEDLDNKMKMJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator OODGOAPHOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> GHBBNOHOOPL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class JJMMHPPECMA
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class DNIBFOHBGMO
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct LHGLBKFODAJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator OODGOAPHOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> GHBBNOHOOPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct BHKBACLEHBJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator OODGOAPHOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> GHBBNOHOOPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct HGGMDMFINDG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator OODGOAPHOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> GHBBNOHOOPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct FPPLCEAECLN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator OODGOAPHOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> GHBBNOHOOPL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JGIMHFFHLKF
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class MABIKPEBOCM
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x24F2160", Offset = "0x24F0960", VA = "0x1824F2160")]
	public static NativeList<Entity> DGNJNGDEGJJ<T>(this NativeArray<Entity> MMGHHCCOBFM, EntityManager AIFDIGHJEAF, Allocator OODGOAPHOCI = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class HFJIADGLIFP
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface LKBLDJAKHOL
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BJAGANEEPBG
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class GCAJADNOGBN
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class OHFEEJANLPE
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x59F6E70", Offset = "0x59F5670", VA = "0x1859F6E70")]
	public static bool FFAGOICFHIF(Type EHPFPOFFCEJ, Type FPPLNHOMBPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class DHGIKKMHMAN<Attribute, BaseClass> : global::LOELILLEALB<BaseClass>, GOEAEACHFJO where Attribute : IPKAMMDCFEN
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly DELGGOALDMF MGFJDFPNJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string LOIAMCEJAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> GDKDNLBLLMK;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A9ADF0", Offset = "0x3A995F0", VA = "0x183A9ADF0")]
	public DHGIKKMHMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A9E0", Offset = "0x3A991E0", VA = "0x183A9A9E0", Slot = "4")]
	public bool JEBNAOILLLF(int CGPOEJKODDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A9AAE0", Offset = "0x3A992E0", VA = "0x183A9AAE0", Slot = "5")]
	public global::APNDKDHFDGE<BaseClass> OPHILGDIGFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A850", Offset = "0x3A99050", VA = "0x183A9A850", Slot = "7")]
	protected virtual bool FFAGOICFHIF(Type EHPFPOFFCEJ, int GKDKDLJPHFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A7C0", Offset = "0x3A98FC0", VA = "0x183A9A7C0", Slot = "8")]
	protected virtual int CNHIINCPFFL(Type EHPFPOFFCEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A950", Offset = "0x3A99150", VA = "0x183A9A950")]
	public void JBLIKMGAHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A9AA40", Offset = "0x3A99240", VA = "0x183A9AA40", Slot = "6")]
	public void OFCCGGLDJKB(Type EHPFPOFFCEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class APNDKDHFDGE<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> FJLKKJGGJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> MMJPHAGIIOD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> MCJEDPCBFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2EA7510", Offset = "0x2EA5D10", VA = "0x182EA7510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7890", Offset = "0x2EA6090", VA = "0x182EA7890")]
	public APNDKDHFDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7A20", Offset = "0x2EA6220", VA = "0x182EA7A20")]
	public APNDKDHFDGE(int EBGHKBFPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2EA77E0", Offset = "0x2EA5FE0", VA = "0x182EA77E0")]
	internal void LGCDELLOPGJ(int CGPOEJKODDA, BaseClass JDOIGKNENIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FCE100", Offset = "0x1FCC900", VA = "0x181FCE100")]
	public bool LBPGIGAMNAL<T>(out BaseClass NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7740", Offset = "0x2EA5F40", VA = "0x182EA7740")]
	public bool LBPGIGAMNAL(Type DPFKFHBMMCC, out BaseClass NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x26F9A20", Offset = "0x26F8220", VA = "0x1826F9A20")]
	public bool EKJDGHHLPKL(int CGPOEJKODDA, out BaseClass NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FCEE10", Offset = "0x1FCD610", VA = "0x181FCEE10")]
	public T PJEMGJAHMFI<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7860", Offset = "0x2EA6060", VA = "0x182EA7860")]
	public BaseClass PJEMGJAHMFI(Type PELNLFFJFNE)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class PGNPBNPPGJB : global::DHGIKKMHMAN<IIFGFLKKOJA, FOKEMBEEBHE>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x59F7220", Offset = "0x59F5A20", VA = "0x1859F7220")]
	public PGNPBNPPGJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FLLCICBCHCK : global::DHGIKKMHMAN<DOADLHAPKEN, NDFGOBMDHCC>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x59F3E50", Offset = "0x59F2650", VA = "0x1859F3E50")]
	public FLLCICBCHCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class OCEEAKHKKHI : global::DHGIKKMHMAN<IGLOFDAMHJI, KDIEDIBMBFJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x59F68B0", Offset = "0x59F50B0", VA = "0x1859F68B0")]
	public OCEEAKHKKHI()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[IECCMKJMAAC(LAEALBOAPLI.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> ELMBJAGHLEM;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD70", Offset = "0x8AA570", VA = "0x1808ABD70")]
		private ComponentSystemTypes(List<Type> ELMBJAGHLEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x59F31C0", Offset = "0x59F19C0", VA = "0x1859F31C0")]
		public static void JBLIKMGAHBK(List<Type> ELMBJAGHLEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x59F2F20", Offset = "0x59F1720", VA = "0x1859F2F20")]
		private void HDHLIBMDNOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x59F2EA0", Offset = "0x59F16A0", VA = "0x1859F2EA0")]
		private bool FFAGOICFHIF(Type EHPFPOFFCEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x59F3160", Offset = "0x59F1960", VA = "0x1859F3160")]
		private void IGAEFAAGNBL(Type EHPFPOFFCEJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class AMLOANEKHPN : JHAOANHDNMH
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x59F28E0", Offset = "0x59F10E0", VA = "0x1859F28E0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase JIIGMLFDIHL();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x59F2890", Offset = "0x59F1090", VA = "0x1859F2890")]
	protected ComponentSystemBase FKCBNFAJCKM(params ComponentSystemBase[] CPOMNNHFPBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3465F40", Offset = "0x3464740", VA = "0x183465F40")]
	protected ComponentSystemBase FKCBNFAJCKM<T>(params ComponentSystemBase[] CPOMNNHFPBO) where T : JHAOANHDNMH, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3465F00", Offset = "0x3464700", VA = "0x183465F00")]
	protected ComponentSystemBase CGICJNCLJMM<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3465F00", Offset = "0x3464700", VA = "0x183465F00")]
	protected ComponentSystemBase JAHHCOPELLM<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	protected AMLOANEKHPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface LOELILLEALB<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEBNAOILLLF(int CGPOEJKODDA);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::APNDKDHFDGE<BaseClass> OPHILGDIGFI();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class JHAOANHDNMH : MIJOGJHOPFF
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x59F4900", Offset = "0x59F3100", VA = "0x1859F4900", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public JHAOANHDNMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class FGEMHNBDPAP : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x59F3DA0", Offset = "0x59F25A0", VA = "0x1859F3DA0")]
	public ComponentDataFromEntity PIPIINIIJGN(int CGPOEJKODDA, bool DICFAHGJIHP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x59F3E40", Offset = "0x59F2640", VA = "0x1859F3E40", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20")]
	protected FGEMHNBDPAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class OMFHDFNDNKE : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20")]
	protected OMFHDFNDNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class LJCGDKNAHPO : FGEMHNBDPAP
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x59F5DA0", Offset = "0x59F45A0", VA = "0x1859F5DA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	protected void BHHKNBHOOKM(string KJBCBDJGGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20")]
	protected LJCGDKNAHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class EBCAIHAIDJG
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class MIJOGJHOPFF : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	protected MIJOGJHOPFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[IECCMKJMAAC(LAEALBOAPLI.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x59F7CB0", Offset = "0x59F64B0", VA = "0x1859F7CB0")]
		public static ComponentSystemGroup[] JOFKCOIDGMK(World IFJKGEPFDIB, BPPHFOJPKNP EHKHFGGGAJC = BPPHFOJPKNP.Default, bool PLJCLDKKNGO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x59F8170", Offset = "0x59F6970", VA = "0x1859F8170")]
		private static Type[] NNKGAMOPDLN(BPPHFOJPKNP EHKHFGGGAJC, bool PLJCLDKKNGO, ComponentSystemGroup[] BLONJOAHKBG, ComponentSystemGroup FGGCMNAHANJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x59F7D80", Offset = "0x59F6580", VA = "0x1859F7D80")]
		private static ComponentSystemGroup[] KJEFHBGLCGE(World IFJKGEPFDIB, out ComponentSystemGroup FGGCMNAHANJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x59F7320", Offset = "0x59F5B20", VA = "0x1859F7320")]
		internal static bool AABIJDMABJH(EJBDBMPHFMP DOJAOGGMBHJ, out HOBANIPIPAH OHMLIOPAFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x59F8090", Offset = "0x59F6890", VA = "0x1859F8090")]
		private static ComponentSystemGroup MFPBOGENNCM(Type EHPFPOFFCEJ, World IFJKGEPFDIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x59F75A0", Offset = "0x59F5DA0", VA = "0x1859F75A0")]
		private static ComponentSystemGroup[] AIIOHHJFFFP(Type[] ELMBJAGHLEM, World IFJKGEPFDIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x59F7730", Offset = "0x59F5F30", VA = "0x1859F7730")]
		internal static void BJFPGHCHKCG(World IFJKGEPFDIB, Type[] FFKCGPAJMLA, ComponentSystemGroup[] BLONJOAHKBG, ComponentSystemGroup FGGCMNAHANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x59F7C50", Offset = "0x59F6450", VA = "0x1859F7C50")]
		internal static bool GNCIDDELGOB(ComponentSystemBase NDAAFLCINNI, ComponentSystemGroup[] BLONJOAHKBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x59F76D0", Offset = "0x59F5ED0", VA = "0x1859F76D0")]
		private static void AJCMPNACDBH(ComponentSystemGroup[] BLONJOAHKBG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct MGLOHAMLFKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> NHJCCLDOJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> CPOMNNHFPBO;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x785A30", Offset = "0x784230", VA = "0x180785A30")]
	public MGLOHAMLFKK(Dictionary<Type, List<Type>> NHJCCLDOJIK, HashSet<Type> CPOMNNHFPBO)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[IECCMKJMAAC(LAEALBOAPLI.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class CNCFMIEOCCK : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AE910", VA = "0x1808B0110")]
			[DebuggerHidden]
			public CNCFMIEOCCK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x59F2DC0", Offset = "0x59F15C0", VA = "0x1859F2DC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x59F2B20", Offset = "0x59F1320", VA = "0x1859F2B20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x59F2E50", Offset = "0x59F1650", VA = "0x1859F2E50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x59F2D80", Offset = "0x59F1580", VA = "0x1859F2D80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x59F2CD0", Offset = "0x59F14D0", VA = "0x1859F2CD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x59F2CD0", Offset = "0x59F14D0", VA = "0x1859F2CD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct MOFHGNFALDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type HACEMIMODIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private BPPHFOJPKNP EHKHFGGGAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool LLGIMEALHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool IHLNLEKDCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool PLJCLDKKNGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> MCCABEIOKBF;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x59F9400", Offset = "0x59F7C00", VA = "0x1859F9400")]
		public static RRFilterWorldSystems OJONNLHFKNA()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x59F93F0", Offset = "0x59F7BF0", VA = "0x1859F93F0")]
		public RRFilterWorldSystems NOIHKKALELK(BPPHFOJPKNP DOJAOGGMBHJ)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x59F9420", Offset = "0x59F7C20", VA = "0x1859F9420")]
		public RRFilterWorldSystems OKMJDHJGJHI(IEnumerable<Type> ELMBJAGHLEM)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x59F90E0", Offset = "0x59F78E0", VA = "0x1859F90E0")]
		public RRFilterWorldSystems GFAOKBCELEO(bool PEHBJJCCHIB)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x59F8A90", Offset = "0x59F7290", VA = "0x1859F8A90")]
		public RRFilterWorldSystems DIFBABGEPJJ(bool AJDODHMFJKO)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x59F90F0", Offset = "0x59F78F0", VA = "0x1859F90F0")]
		public MGLOHAMLFKK JGKHBELIGKL(Type[] HHMCMIOAMPA)
		{
			return default(MGLOHAMLFKK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x59F8560", Offset = "0x59F6D60", VA = "0x1859F8560")]
		[IteratorStateMachine(typeof(CNCFMIEOCCK))]
		internal IEnumerable<Type> BCFJNFIPBHN(IEnumerable<Type> ELMBJAGHLEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x59F87B0", Offset = "0x59F6FB0", VA = "0x1859F87B0")]
		internal Dictionary<Type, List<Type>> BOKLHAMEHLI(IEnumerable<Type> ELMBJAGHLEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x59F92E0", Offset = "0x59F7AE0", VA = "0x1859F92E0")]
		private void MCIPEGNFFEM(Dictionary<Type, List<Type>> MDNHGAAHKGD, Type EHPFPOFFCEJ, Type DNNIMNKLPKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x59F85F0", Offset = "0x59F6DF0", VA = "0x1859F85F0")]
		internal HashSet<Type> BCMOGHIGPHB(IEnumerable<Type> BLONJOAHKBG, Dictionary<Type, List<Type>> JFGKCBHLINC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x59F8AA0", Offset = "0x59F72A0", VA = "0x1859F8AA0")]
		internal bool FMLIIALDIKA(Type EHPFPOFFCEJ, BPPHFOJPKNP EHKHFGGGAJC, bool PLJCLDKKNGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x59F9180", Offset = "0x59F7980", VA = "0x1859F9180")]
		[CompilerGenerated]
		internal static void JLAEMAFBCBA(Type EHPFPOFFCEJ, ref MOFHGNFALDA P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class LKOHDAOOMIB
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool NPAKIBGAGIC;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x59F5FA0", Offset = "0x59F47A0", VA = "0x1859F5FA0")]
	public static void ODGJJHFNDHJ(bool HMGJFCJOMJC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x59F5DE0", Offset = "0x59F45E0", VA = "0x1859F5DE0")]
	private static void AEKGJHMEAEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class HMAAOKDBDNA
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x59F47A0", Offset = "0x59F2FA0", VA = "0x1859F47A0")]
	public static ulong LCMHBIJHADC(Type EHPFPOFFCEJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x59F46E0", Offset = "0x59F2EE0", VA = "0x1859F46E0")]
	public static ulong LCMHBIJHADC(string DNDOAFMMJHG)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[IECCMKJMAAC(LAEALBOAPLI.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct PIIOPJMHGPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong NJIHJBEKJHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong FPPGNNJPBLC;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xE9DF20", Offset = "0xE9C720", VA = "0x180E9DF20")]
			public PIIOPJMHGPD(ulong IDEBGJCONFA, ulong JILLPFDLBBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x59F7290", Offset = "0x59F5A90", VA = "0x1859F7290", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> JAADAIBBHIO;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static PIIOPJMHGPD[] KIGOACJOPFN;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool NPAKIBGAGIC;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x59F9AB0", Offset = "0x59F82B0", VA = "0x1859F9AB0")]
		public static ulong HMGHLLLGLBL(int CGPOEJKODDA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x59F9B10", Offset = "0x59F8310", VA = "0x1859F9B10")]
		public static int IPLIMJNNOME(ulong JILLPFDLBBJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x59F9F50", Offset = "0x59F8750", VA = "0x1859F9F50")]
		public static void ODGJJHFNDHJ(bool HMGJFCJOMJC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x59F96A0", Offset = "0x59F7EA0", VA = "0x1859F96A0")]
		private static void DPKBOMNJOBJ(int LLPDNAHJOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x59F9780", Offset = "0x59F7F80", VA = "0x1859F9780")]
		private static void GIBKLNPLCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x59F9BC0", Offset = "0x59F83C0", VA = "0x1859F9BC0")]
		private static PIIOPJMHGPD LHMFFKILHBK(Type EHPFPOFFCEJ)
		{
			return default(PIIOPJMHGPD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x59F9530", Offset = "0x59F7D30", VA = "0x1859F9530")]
		private static ulong CGNBEIMEHAK(Type EHPFPOFFCEJ, ulong JILLPFDLBBJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x59F9CA0", Offset = "0x59F84A0", VA = "0x1859F9CA0")]
		private static void LMNLDPLOJBK(in PIIOPJMHGPD CLLKOHIACCL, TypeManager.TypeInfo AAHEKGPMOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x59F95A0", Offset = "0x59F7DA0", VA = "0x1859F95A0")]
		private static void DHCGFOJBMAL(PIIOPJMHGPD AAHEKGPMOHC, int CGPOEJKODDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x59FA140", Offset = "0x59F8940", VA = "0x1859FA140")]
		private static void OOHIIILEFPG(PIIOPJMHGPD AAHEKGPMOHC, int CGPOEJKODDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x59F9EC0", Offset = "0x59F86C0", VA = "0x1859F9EC0")]
		private static PIIOPJMHGPD MCMDBDHNANL(int CGPOEJKODDA)
		{
			return default(PIIOPJMHGPD);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x59F9AA0", Offset = "0x59F82A0", VA = "0x1859F9AA0")]
		private static int HJIHFBNAJJD(int CGPOEJKODDA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class AILECPCCIHF
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly FLLCICBCHCK FIFPHPFICFI;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly OCEEAKHKKHI EBMKFLNFEJL;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly PGNPBNPPGJB KMHHBLBFLMN;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> FPIDFJLDADK;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool NPAKIBGAGIC;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::LOELILLEALB<NDFGOBMDHCC> IIEIICCNLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x59F2010", Offset = "0x59F0810", VA = "0x1859F2010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::LOELILLEALB<KDIEDIBMBFJ> CDCOJHBFNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x59F2150", Offset = "0x59F0950", VA = "0x1859F2150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::LOELILLEALB<FOKEMBEEBHE> FHIFPHBBMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x59F2070", Offset = "0x59F0870", VA = "0x1859F2070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x59F21B0", Offset = "0x59F09B0", VA = "0x1859F21B0")]
	public static void ODGJJHFNDHJ(bool HMGJFCJOMJC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x59F20D0", Offset = "0x59F08D0", VA = "0x1859F20D0")]
	public static Type[] GEEKPAPFAPN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class OCJEACMCOCG
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> CDABGEOKGDK;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool NPAKIBGAGIC;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x59F6920", Offset = "0x59F5120", VA = "0x1859F6920")]
	public static int AOLKCKLJFOE(int CGPOEJKODDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x59F6D10", Offset = "0x59F5510", VA = "0x1859F6D10")]
	public static void ODGJJHFNDHJ(bool HMGJFCJOMJC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x59F6A10", Offset = "0x59F5210", VA = "0x1859F6A10")]
	private static void KCEBOPNBMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x59F69C0", Offset = "0x59F51C0", VA = "0x1859F69C0")]
	private static int HHHBCMFNEDH(Type EHPFPOFFCEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x59F6C90", Offset = "0x59F5490", VA = "0x1859F6C90")]
	private static void MMLFENDEPMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class KPAAIPGAPMC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World HIOLADDKGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NBDMAOHFKJB JDOIGKNENIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] BLONJOAHKBG;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World BCCOIHBMLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World NGMBKINDIII
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager NKKGJCLICDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8ACCA0", Offset = "0x8AB4A0", VA = "0x1808ACCA0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public NBDMAOHFKJB AFGIMGNBGBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::APNDKDHFDGE<NDFGOBMDHCC> IIEIICCNLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x76DB00", Offset = "0x76C300", VA = "0x18076DB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::APNDKDHFDGE<KDIEDIBMBFJ> CDCOJHBFNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6DC590", Offset = "0x6DAD90", VA = "0x1806DC590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::APNDKDHFDGE<FOKEMBEEBHE> FHIFPHBBMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6DC580", Offset = "0x6DAD80", VA = "0x1806DC580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5A0", Offset = "0x6DADA0", VA = "0x1806DC5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> NODGMKJOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8ACCE0", Offset = "0x8AB4E0", VA = "0x1808ACCE0")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] LBJDKMGNDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x59F5030", Offset = "0x59F3830", VA = "0x1859F5030")]
	public static KPAAIPGAPMC GIDHNGMPIDI(string LOIAMCEJAFO, EJBDBMPHFMP DOJAOGGMBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x59F5880", Offset = "0x59F4080", VA = "0x1859F5880")]
	public KPAAIPGAPMC(string LOIAMCEJAFO, EJBDBMPHFMP DOJAOGGMBHJ = EJBDBMPHFMP.Simulation, BPPHFOJPKNP EHKHFGGGAJC = BPPHFOJPKNP.Default, bool HMGJFCJOMJC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x59F54A0", Offset = "0x59F3CA0", VA = "0x1859F54A0")]
	public ComponentSystemBase HMEMHLNCFML(Type EHPFPOFFCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x14C2C10", Offset = "0x14C1410", VA = "0x1814C2C10")]
	public T HMEMHLNCFML<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x59F4F70", Offset = "0x59F3770", VA = "0x1859F4F70")]
	public void FCNPOMAGCHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x59F53E0", Offset = "0x59F3BE0", VA = "0x1859F53E0")]
	public void HDKDNALMHFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x59F4F10", Offset = "0x59F3710", VA = "0x1859F4F10")]
	public void EEGKDCNCOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x59F57A0", Offset = "0x59F3FA0", VA = "0x1859F57A0")]
	public void LOJLBDKBPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x59F5440", Offset = "0x59F3C40", VA = "0x1859F5440")]
	public void HECLILLKMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x59F5630", Offset = "0x59F3E30", VA = "0x1859F5630")]
	public void JMINEPCEGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x59F50B0", Offset = "0x59F38B0", VA = "0x1859F50B0")]
	public void GLHBFFHMIFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x59F55A0", Offset = "0x59F3DA0", VA = "0x1859F55A0")]
	public void JKAPKIEBMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x59F4FD0", Offset = "0x59F37D0", VA = "0x1859F4FD0")]
	public void FFBDGKHKAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x59F4E40", Offset = "0x59F3640", VA = "0x1859F4E40")]
	public void CEMJKAMHCFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x59F54C0", Offset = "0x59F3CC0", VA = "0x1859F54C0")]
	internal void IDPNOCCDFIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x59F5800", Offset = "0x59F4000", VA = "0x1859F5800")]
	private bool MKDIBCHNLAJ(ComponentSystemGroup DAMNENENKAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x59F5110", Offset = "0x59F3910", VA = "0x1859F5110")]
	private void GOALGLAEAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x59F5690", Offset = "0x59F3E90", VA = "0x1859F5690")]
	private ComponentSystemGroup[] JOFKCOIDGMK(BPPHFOJPKNP EHKHFGGGAJC, bool PLJCLDKKNGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x59F4EA0", Offset = "0x59F36A0", VA = "0x1859F4EA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum EJBDBMPHFMP
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
public sealed class LFKFJKLNPOE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public BPPHFOJPKNP CBBPAHCIEKK;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum BPPHFOJPKNP
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
public interface HOBANIPIPAH
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type BLNKOFGOICB
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] LCIOEDLMHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class MPHLPAFELCC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool AEMJMHKOKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	protected MPHLPAFELCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class BGEGPOKDGKJ : MPHLPAFELCC
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public BGEGPOKDGKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class EKGJHMKLBLH : MPHLPAFELCC
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public EKGJHMKLBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class KFJBGNKENFC : MPHLPAFELCC
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public KFJBGNKENFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class NOONHJOANKP : MPHLPAFELCC
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public NOONHJOANKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class EBHEOPNGKMN : MPHLPAFELCC
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public EBHEOPNGKMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class CHMHBHDDDJC : MPHLPAFELCC
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public CHMHBHDDDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class JAHBOJBAOGH : MPHLPAFELCC
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public JAHBOJBAOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class BGDJHFPBMFO : MPHLPAFELCC
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public BGDJHFPBMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class FFABGDLAIHH : MPHLPAFELCC
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public FFABGDLAIHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class CKGMDBLLDEM : MIKLKGDLOLN
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public CKGMDBLLDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class EHJPMOLJHCA : MIKLKGDLOLN
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public EHJPMOLJHCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class FICHLIFKCLL : MIKLKGDLOLN
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public FICHLIFKCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class LHOLAAJHLBH : MIKLKGDLOLN
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public LHOLAAJHLBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[KKJJBJLJHEJ(EKKHFCELHOI.Application)]
public class MIKLKGDLOLN : MPHLPAFELCC
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool AEMJMHKOKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x59F2920", Offset = "0x59F1120", VA = "0x1859F2920")]
	public MIKLKGDLOLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class LHEALDPACNM : ENPMBAGPCIO
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public LHEALDPACNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class NAOPPFAIHHD
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void IOMAJDJHNLB<From, To>(From OEDLDNKMKMJ, ref To LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class CFHAJJGKPOD<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static IOMAJDJHNLB<From, To> BHFALMJJMHO;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public CFHAJJGKPOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x59F61A0", Offset = "0x59F49A0", VA = "0x1859F61A0")]
	static NAOPPFAIHHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1F11E90", Offset = "0x1F10690", VA = "0x181F11E90")]
	public static void DKJKPBHEMFF<T>(IOMAJDJHNLB<T, T> DNHBDOFBCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1F11D20", Offset = "0x1F10520", VA = "0x181F11D20")]
	public static void DKJKPBHEMFF<From, To>(IOMAJDJHNLB<From, To> DNHBDOFBCEA, IOMAJDJHNLB<To, From> OGFGOHJJDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1F11DB0", Offset = "0x1F105B0", VA = "0x181F11DB0")]
	public static void DKJKPBHEMFF<From, To>(IOMAJDJHNLB<From, To> BHFALMJJMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x1F13DA0", Offset = "0x1F125A0", VA = "0x181F13DA0")]
	public static IOMAJDJHNLB<From, To> DKOHECLJCDF<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1F1AC90", Offset = "0x1F19490", VA = "0x181F1AC90")]
	public static void NBOBJLAFMAI<From, To>(From OEDLDNKMKMJ, ref To LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class AFDHGGDCOPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> BEFIPCPGIOM;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xCE0D90", Offset = "0xCDF590", VA = "0x180CE0D90")]
	public AFDHGGDCOPP(NativeArray<EntityRemapUtility.EntityRemapInfo> BEFIPCPGIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x31D7310", Offset = "0x31D5B10", VA = "0x1831D7310")]
	public Entity AJDDIMPGEDA(Entity KJFIHMLIKBG)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class KKBCGHDLINE
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> FEMDHBEJMDG;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x59F4BD0", Offset = "0x59F33D0", VA = "0x1859F4BD0")]
	public static bool HBOKIMNLMFC(ulong MNONHEHGNJF, uint OGPINCOPHCL, out string LOIAMCEJAFO)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[IECCMKJMAAC(LAEALBOAPLI.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct KFKJMFAHJOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int FPGJPBIHINK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int JAFPKKDIEPK;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x6F6050", Offset = "0x6F4850", VA = "0x1806F6050")]
			public KFKJMFAHJOP(int LHHBOCAHDEE, int OGPINCOPHCL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct DPDJCIDMIPE
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch LKLCJCFHEKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long JIMOHJNGFLA;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long ADIFNBPEEKF
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x59F35E0", Offset = "0x59F1DE0", VA = "0x1859F35E0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long EFNLDCIIGMI
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x59F34B0", Offset = "0x59F1CB0", VA = "0x1859F34B0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x59F3520", Offset = "0x59F1D20", VA = "0x1859F3520")]
			public static DPDJCIDMIPE HKCEAJHPIGK()
			{
				return default(DPDJCIDMIPE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct FNDOEKAEDNO : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct HOFNCBKDJPF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* NGJMLDKIKPG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly OAEEAGFLFJH.GFFICHCNGOD.FBNKLAEEJJM HAPDMPJLBEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly AFDHGGDCOPP HIGOLFJOLNG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::APNDKDHFDGE<KDIEDIBMBFJ> PEBIPAKLPML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int DHODPIHCCEC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int MIFNFLOKLOO;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x59F4830", Offset = "0x59F3030", VA = "0x1859F4830")]
				public unsafe HOFNCBKDJPF(Unity.Entities.Archetype* NGJMLDKIKPG, OAEEAGFLFJH.GFFICHCNGOD.FBNKLAEEJJM HAPDMPJLBEF, AFDHGGDCOPP HIGOLFJOLNG, global::APNDKDHFDGE<KDIEDIBMBFJ> PEBIPAKLPML, int DHODPIHCCEC, int MIFNFLOKLOO = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x59F47E0", Offset = "0x59F2FE0", VA = "0x1859F47E0")]
				public HOFNCBKDJPF(in HOFNCBKDJPF LBEMEOBAAJI, int MIFNFLOKLOO)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly HOFNCBKDJPF[] GDAMMKPBIEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] LGMGLBPMEED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int BIEKMNGHGNH;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x59F45A0", Offset = "0x59F2DA0", VA = "0x1859F45A0")]
			public FNDOEKAEDNO(HOFNCBKDJPF[] GDAMMKPBIEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x59F4190", Offset = "0x59F2990", VA = "0x1859F4190", Slot = "4")]
			public void Invoke(int LHHBOCAHDEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x59F41F0", Offset = "0x59F29F0", VA = "0x1859F41F0")]
			private void OKPNNFMBNFK(in HOFNCBKDJPF LBEMEOBAAJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x59F3EC0", Offset = "0x59F26C0", VA = "0x1859F3EC0")]
			private static void FFEKMPEAILL(in HOFNCBKDJPF LBEMEOBAAJI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class IBINPFFPLHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public OAEEAGFLFJH asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::APNDKDHFDGE<KDIEDIBMBFJ> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public IBINPFFPLHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x59F4890", Offset = "0x59F3090", VA = "0x1859F4890")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class MOKHKECCNJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public OAEEAGFLFJH.GFFICHCNGOD.FBNKLAEEJJM srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public IBINPFFPLHN CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public MOKHKECCNJA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class MDOBKOICIAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public MOKHKECCNJA CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public MDOBKOICIAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x59F6000", Offset = "0x59F4800", VA = "0x1859F6000")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly DELGGOALDMF DPJGFNOIDED;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly DELGGOALDMF IMNKHOHPCOP;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly DELGGOALDMF FNIENDNFCLK;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly DELGGOALDMF MCLOOLHEDDH;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool PAHLJBGPONL;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static OAEEAGFLFJH.GFFICHCNGOD.CFEJLDFOOAC EGPEBIDPOGP;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x59FA2B0", Offset = "0x59F8AB0", VA = "0x1859FA2B0")]
		private unsafe static bool AEAEHKAIEEH(Unity.Entities.Archetype* CGGJCIPGPCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x59FCB00", Offset = "0x59FB300", VA = "0x1859FCB00")]
		internal unsafe static Unity.Entities.Archetype*[] JFFOADIMBAC(ref Unity.Entities.EntityComponentStore FEDDMIFBHCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x59FCA40", Offset = "0x59FB240", VA = "0x1859FCA40")]
		public static void IHODHCPGNOF(KPAAIPGAPMC IFJKGEPFDIB, out ByteString GJAPHEDPMNB, out NativeArray<EntityRemapUtility.EntityRemapInfo> PDJKAODKNJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x59FAD10", Offset = "0x59F9510", VA = "0x1859FAD10")]
		internal static void BONEFADIIHJ(KPAAIPGAPMC IFJKGEPFDIB, OAEEAGFLFJH BHFMHOBNEKE, out NativeArray<EntityRemapUtility.EntityRemapInfo> PDJKAODKNJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x59FCCE0", Offset = "0x59FB4E0", VA = "0x1859FCCE0")]
		private unsafe static UnsafeHashMap<ulong, KFKJMFAHJOP> JFJFJDHGBAA(Unity.Entities.Archetype*[] IPECPKGJLKC)
		{
			return default(UnsafeHashMap<ulong, KFKJMFAHJOP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x59FD5C0", Offset = "0x59FBDC0", VA = "0x1859FD5C0")]
		private static void LHABJGCAOKG(OAEEAGFLFJH BHFMHOBNEKE, UnsafeHashMap<ulong, KFKJMFAHJOP> AOAAIBONHLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x59FD9E0", Offset = "0x59FC1E0", VA = "0x1859FD9E0")]
		private unsafe static void PGDBGLLCBJF(OAEEAGFLFJH BHFMHOBNEKE, Unity.Entities.Archetype*[] IPECPKGJLKC, UnsafeHashMap<ulong, KFKJMFAHJOP> AOAAIBONHLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x59FB440", Offset = "0x59F9C40", VA = "0x1859FB440")]
		private unsafe static int CCAIPNAFGCN(Unity.Entities.Archetype*[] IPECPKGJLKC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x59FB7E0", Offset = "0x59F9FE0", VA = "0x1859FB7E0")]
		private unsafe static void DAMAHLFBIHE(OAEEAGFLFJH BHFMHOBNEKE, Unity.Entities.Archetype*[] IPECPKGJLKC, global::APNDKDHFDGE<KDIEDIBMBFJ> PEBIPAKLPML, NativeArray<EntityRemapUtility.EntityRemapInfo> PDJKAODKNJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x59FD770", Offset = "0x59FBF70", VA = "0x1859FD770")]
		private static NativeArray<int> ONAMGHAIGBM(OAEEAGFLFJH BHFMHOBNEKE)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x59FD230", Offset = "0x59FBA30", VA = "0x1859FD230")]
		private static Memory<EntityArchetype> LAAKKLAJDAH(OAEEAGFLFJH BHFMHOBNEKE, NativeArray<int> ELMBJAGHLEM, EntityManager AIFDIGHJEAF, out int BBMFALGNCOB, out int DKPIHPFLHBN)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x59FC650", Offset = "0x59FAE50", VA = "0x1859FC650")]
		private unsafe static void GEICMEJJOHH(Unity.Entities.Chunk* OEHNFIOACFK, ReadOnlySpan<byte> GJAPHEDPMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x59FBF10", Offset = "0x59FA710", VA = "0x1859FBF10")]
		private static void FHFHHJPFOML(OAEEAGFLFJH BHFMHOBNEKE, NativeArray<int> ELMBJAGHLEM, Span<EntityArchetype> IPECPKGJLKC, EntityManager AIFDIGHJEAF, global::APNDKDHFDGE<KDIEDIBMBFJ> PEBIPAKLPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x59FB4B0", Offset = "0x59F9CB0", VA = "0x1859FB4B0")]
		private unsafe static void CIHAHFDKEOL(Unity.Entities.Chunk* FMCANOMFDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x59FBC00", Offset = "0x59FA400", VA = "0x1859FBC00")]
		private unsafe static void DEJHIJCPEJG(OAEEAGFLFJH.GFFICHCNGOD.FBNKLAEEJJM NGJMLDKIKPG, int ENJJJEGEONO, int EDHPMJIPDGN, Unity.Entities.Chunk* OEHNFIOACFK, OAEEAGFLFJH BHFMHOBNEKE, NativeArray<int> ELMBJAGHLEM, global::APNDKDHFDGE<KDIEDIBMBFJ> PEBIPAKLPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x59FA3C0", Offset = "0x59F8BC0", VA = "0x1859FA3C0")]
		public static void AFFHDMIIFDA(KPAAIPGAPMC IFJKGEPFDIB, in ByteString GJAPHEDPMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x59FA450", Offset = "0x59F8C50", VA = "0x1859FA450")]
		public static void AFFHDMIIFDA(EntityManager AIFDIGHJEAF, global::APNDKDHFDGE<KDIEDIBMBFJ> PEBIPAKLPML, in ByteString GJAPHEDPMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x59FCF70", Offset = "0x59FB770", VA = "0x1859FCF70")]
		private static bool JJNLLKMNBCG(Type EHPFPOFFCEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x59FB530", Offset = "0x59F9D30", VA = "0x1859FB530")]
		private static void CMDKBPALKHM(TypeManager.TypeInfo AAHEKGPMOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x59FAB80", Offset = "0x59F9380", VA = "0x1859FAB80")]
		private unsafe static int BMJPAGKALOO(Unity.Entities.Archetype*[] IPECPKGJLKC, NativeArray<EntityRemapUtility.EntityRemapInfo> PDJKAODKNJI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x59FAAA0", Offset = "0x59F92A0", VA = "0x1859FAAA0")]
		private static int AOLKCKLJFOE(int CGPOEJKODDA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x59FC9A0", Offset = "0x59FB1A0", VA = "0x1859FC9A0")]
		private static ulong HMGHLLLGLBL(int CGPOEJKODDA)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class EJOBJFDFDAK
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x59F37E0", Offset = "0x59F1FE0", VA = "0x1859F37E0")]
	private unsafe static Span<byte> LHAMMLAOKLH(Unity.Entities.Chunk* FMCANOMFDBO, int DHODPIHCCEC)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x284B500", Offset = "0x2849D00", VA = "0x18284B500")]
	public unsafe static Span<T> FEOBHABKEEM<T>(Unity.Entities.Chunk* FMCANOMFDBO, int DHODPIHCCEC)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1F0A630", Offset = "0x1F08E30", VA = "0x181F0A630")]
	public static Span<T> FEOBHABKEEM<T>(this ref Unity.Entities.Chunk FMCANOMFDBO, int DHODPIHCCEC)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x59F3770", Offset = "0x59F1F70", VA = "0x1859F3770")]
	public unsafe static Span<Entity> EAEDJENCFHD(Unity.Entities.Chunk* FMCANOMFDBO)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x59F3980", Offset = "0x59F2180", VA = "0x1859F3980")]
	public unsafe static void MMLFENDEPMM(Unity.Entities.Chunk* FMCANOMFDBO, int DHODPIHCCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x59F3640", Offset = "0x59F1E40", VA = "0x1859F3640")]
	public static Entity BOMAGPCHFJF(this EntityQuery PPFDACOOOGO)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : PMFBNHDKHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x59FDF70", Offset = "0x59FC770", VA = "0x1859FDF70", Slot = "4")]
		public sealed override void JBLIKMGAHBK()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x5B35DF0", Offset = "0x5B351F0", VA = "0x185B35DF0")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5B366F0", Offset = "0x5B35AF0", VA = "0x185B366F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B36760", Offset = "0x5B35B60", VA = "0x185B36760")]
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
			[Cpp2IlInjected.Address(RVA = "0x2FB7B10", Offset = "0x2FB6F10", VA = "0x182FB7B10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x24C8900", Offset = "0x24C7D00", VA = "0x1824C8900")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24C8130", Offset = "0x24C7530", VA = "0x1824C8130")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24C8230", Offset = "0x24C7630", VA = "0x1824C8230")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x24C8630", Offset = "0x24C7A30", VA = "0x1824C8630")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5B36780", Offset = "0x5B35B80", VA = "0x185B36780")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HOLFGEBLJPB<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MEAANJACGPJ : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::HOLFGEBLJPB<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x701040", Offset = "0x700440", VA = "0x180701040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x30B3EE0", Offset = "0x30B32E0", VA = "0x1830B3EE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1E355D0", Offset = "0x1E349D0", VA = "0x181E355D0")]
		[DebuggerHidden]
		public MEAANJACGPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x30B3D00", Offset = "0x30B3100", VA = "0x1830B3D00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x30B3EA0", Offset = "0x30B32A0", VA = "0x1830B3EA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> BIIBMCMPIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream BBKJOBCNEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream APMEPKLGHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf GBEOCIOFDDF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int IEAACCILOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0010", Offset = "0x6DF410", VA = "0x1806E0010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F750", Offset = "0x2C1EB50", VA = "0x182C1F750")]
	private HOLFGEBLJPB(byte[] BFNDINBALAB, Action<Protobuf> BIIBMCMPIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x26D6A60", Offset = "0x26D5E60", VA = "0x1826D6A60")]
	public static global::HOLFGEBLJPB<Protobuf> BMDGCEOIEEG<Data>(ReadOnlySpan<byte> BMHLFOOGPAA, ReadOnlySpan<Data> KDCOOOFOCDB, Action<Protobuf> BIIBMCMPIKN)
	{
		return default(global::HOLFGEBLJPB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F5C0", Offset = "0x2C1E9C0", VA = "0x182C1F5C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F600", Offset = "0x2C1EA00", VA = "0x182C1F600", Slot = "4")]
	[IteratorStateMachine(typeof(global::HOLFGEBLJPB<>.MEAANJACGPJ))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F700", Offset = "0x2C1EB00", VA = "0x182C1F700", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DBNPOKMNHKB<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] BFNDINBALAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf GBEOCIOFDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream BBKJOBCNEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream IAEPPAKENEH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2FEAAA0", Offset = "0x2FE9EA0", VA = "0x182FEAAA0")]
	private DBNPOKMNHKB(byte[] BFNDINBALAB, in Protobuf GBEOCIOFDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2B81BF0", Offset = "0x2B80FF0", VA = "0x182B81BF0")]
	public static global::DBNPOKMNHKB<Protobuf> BMDGCEOIEEG<T>(ReadOnlySpan<T> KDCOOOFOCDB)
	{
		return default(global::DBNPOKMNHKB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA8B0", Offset = "0x2FE9CB0", VA = "0x182FEA8B0")]
	public void AOHDDDCFHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA8E0", Offset = "0x2FE9CE0", VA = "0x182FEA8E0")]
	public ByteString DKPGHNHACBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA970", Offset = "0x2FE9D70", VA = "0x182FEA970", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NGPBGJJGJHD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream BBKJOBCNEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream APMEPKLGHGA;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B39110", Offset = "0x5B38510", VA = "0x185B39110", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct CKBCEGLFLMF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] BFNDINBALAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream BBKJOBCNEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream IAEPPAKENEH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5B35FB0", Offset = "0x5B353B0", VA = "0x185B35FB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HOMINANNICH
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public static void EEJBPCLBJEC(this JHCDFELAIDH AOHKNGHOEPF, NativeArray<Entity> GMAMPIGCEAB, [Optional][CallerFilePath] string NHGNBMKPGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public static void EEJBPCLBJEC(this JHCDFELAIDH AOHKNGHOEPF, string GOENAEMJAON, NativeArray<Entity> GMAMPIGCEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public static void EEJBPCLBJEC(this JHCDFELAIDH AOHKNGHOEPF, string NHGNBMKPGCO, NativeArray<Entity> GMAMPIGCEAB, bool COANEGMLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public static void GHOMHCBLNAD(this JHCDFELAIDH AOHKNGHOEPF, NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> OCFBEMCGNEI, [Optional][CallerFilePath] string NHGNBMKPGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public static void GHOMHCBLNAD(this JHCDFELAIDH AOHKNGHOEPF, string NHGNBMKPGCO, NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> OCFBEMCGNEI, bool COANEGMLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x242D610", Offset = "0x242CA10", VA = "0x18242D610")]
	public static void KCEHCIOHKMH<T>(this JHCDFELAIDH AOHKNGHOEPF, string GOENAEMJAON, NativeArray<Entity> GMAMPIGCEAB, NativeList<T> FNIHENPLJHK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x242D5D0", Offset = "0x242C9D0", VA = "0x18242D5D0")]
	public static void KCEHCIOHKMH<T>(this JHCDFELAIDH AOHKNGHOEPF, string GOENAEMJAON, NativeArray<Entity> GMAMPIGCEAB, NativeArray<T> FNIHENPLJHK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public static void KCEHCIOHKMH<T>(this JHCDFELAIDH AOHKNGHOEPF, string NHGNBMKPGCO, NativeArray<Entity> GMAMPIGCEAB, NativeArray<T> FNIHENPLJHK, bool COANEGMLMGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x242D6D0", Offset = "0x242CAD0", VA = "0x18242D6D0")]
	public static void LNFFNGGNOLF<T>(this JHCDFELAIDH AOHKNGHOEPF, NativeList<T> FNIHENPLJHK, [Optional][CallerFilePath] string NHGNBMKPGCO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x242D6A0", Offset = "0x242CAA0", VA = "0x18242D6A0")]
	public static void LNFFNGGNOLF<T>(this JHCDFELAIDH AOHKNGHOEPF, NativeArray<T> FNIHENPLJHK, [Optional][CallerFilePath] string NHGNBMKPGCO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public static void LNFFNGGNOLF<T>(this JHCDFELAIDH AOHKNGHOEPF, string NHGNBMKPGCO, NativeArray<T> FNIHENPLJHK, bool COANEGMLMGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public static void KMOOMIJAMAP(this JHCDFELAIDH AOHKNGHOEPF, EntityQuery APEJLGJADFF, [Optional][CallerFilePath] string NHGNBMKPGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public static void KMOOMIJAMAP(this JHCDFELAIDH AOHKNGHOEPF, string GOENAEMJAON, EntityQuery APEJLGJADFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public static void KMOOMIJAMAP(this JHCDFELAIDH AOHKNGHOEPF, string NHGNBMKPGCO, EntityQuery APEJLGJADFF, bool COANEGMLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x242D5A0", Offset = "0x242C9A0", VA = "0x18242D5A0")]
	public static void IMBMHBLMNBH<T, T2>(this JHCDFELAIDH AOHKNGHOEPF, string GOENAEMJAON, EntityQuery APEJLGJADFF) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	private static void IMBMHBLMNBH<T, T2>(this JHCDFELAIDH AOHKNGHOEPF, string NHGNBMKPGCO, EntityQuery APEJLGJADFF, bool COANEGMLMGF) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LOINMAGCOGI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HLMPEBPKEBN OHODODKLPMK
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
public interface FOIFNBDOPHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJEFHPLBCMD(Entity PJEENOLDJIO, object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IKHJIOCDHHM(Entity PJEENOLDJIO, object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GNKDLLKCMAB(Entity PJEENOLDJIO);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GNKDLLKCMAB(HLMPEBPKEBN BDCLOJHOMDK);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> LOPGFNKJDGK(Entity PJEENOLDJIO);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OFNHOFOHAEF(Entity PJEENOLDJIO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CMEECFLOIOG<TComponentData, TValue> : global::IHKEKCKIHGK<TValue>, IDisposable where TComponentData : struct, LOINMAGCOGI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class AHDPKLIEAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> EHJGMBFBLBN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int IIEJMBAKGHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1F8F3B0", Offset = "0x1F8E7B0", VA = "0x181F8F3B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x25948C0", Offset = "0x2593CC0", VA = "0x1825948C0")]
		public bool IMMOPABFOGI(out TValue KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2594810", Offset = "0x2593C10", VA = "0x182594810")]
		public void GBJBCHALJOG(object JAKCBCDLMLB, TValue KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2594A30", Offset = "0x2593E30", VA = "0x182594A30")]
		public bool PMMODKPOELK(object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2594980", Offset = "0x2593D80", VA = "0x182594980")]
		public int LGFPODHHMBH(object JAKCBCDLMLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2594AB0", Offset = "0x2593EB0", VA = "0x182594AB0")]
		public AHDPKLIEAIF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<AHDPKLIEAIF> JAJAJEGKILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::IEDFOPGJHFB<HLMPEBPKEBN, AHDPKLIEAIF> PFCJDPNNIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager JGDEKKJFKAJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F190", Offset = "0x2F1E590", VA = "0x182F1F190")]
	public CMEECFLOIOG(EntityManager JGDEKKJFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F070", Offset = "0x2F1E470", VA = "0x182F1F070", Slot = "4")]
	public void OJEFHPLBCMD(Entity PJEENOLDJIO, object JAKCBCDLMLB, TValue KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EDA0", Offset = "0x2F1E1A0", VA = "0x182F1EDA0", Slot = "5")]
	public bool IKHJIOCDHHM(Entity PJEENOLDJIO, object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EF10", Offset = "0x2F1E310", VA = "0x182F1EF10", Slot = "6")]
	public bool IMMOPABFOGI(Entity PJEENOLDJIO, out TValue KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EC40", Offset = "0x2F1E040", VA = "0x182F1EC40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2F1ED20", Offset = "0x2F1E120", VA = "0x182F1ED20")]
	private void HBPBMEPNJCB(AHDPKLIEAIF EGEFLCDAMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EB70", Offset = "0x2F1DF70", VA = "0x182F1EB70")]
	private bool ACKKHJFPCJD(Entity PJEENOLDJIO, out HLMPEBPKEBN BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EFE0", Offset = "0x2F1E3E0", VA = "0x182F1EFE0")]
	private void JKOAADBDMIG(Entity PJEENOLDJIO, HLMPEBPKEBN BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EC20", Offset = "0x2F1E020", VA = "0x182F1EC20")]
	private bool DHLCOLHIBHJ(HLMPEBPKEBN BDCLOJHOMDK, out AHDPKLIEAIF EGEFLCDAMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EC60", Offset = "0x2F1E060", VA = "0x182F1EC60")]
	private AHDPKLIEAIF FKACGLNNIPM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IHKEKCKIHGK<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJEFHPLBCMD(Entity PJEENOLDJIO, object JAKCBCDLMLB, TValue KPPLMEOMNGF);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IKHJIOCDHHM(Entity PJEENOLDJIO, object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IMMOPABFOGI(Entity PJEENOLDJIO, out TValue KPPLMEOMNGF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HLMPEBPKEBN : global::AOOPJGHLJBJ<HLMPEBPKEBN>, LGHBPHHHPFG, IEquatable<HLMPEBPKEBN>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly HLMPEBPKEBN GDFEBAPAIEO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int NOAKOLDJPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x791E40", Offset = "0x791240", VA = "0x180791E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x791DB0", Offset = "0x7911B0", VA = "0x180791DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int CONDCHODOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9550", Offset = "0x8A8950", VA = "0x1808A9550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xE9C130", Offset = "0xE9B530", VA = "0x180E9C130", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5B372C0", Offset = "0x5B366C0", VA = "0x185B372C0", Slot = "8")]
	public bool Equals(HLMPEBPKEBN JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5B37310", Offset = "0x5B36710", VA = "0x185B37310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BLGJBPKCMHC<T> : FOIFNBDOPHG, IDisposable where T : struct, LOINMAGCOGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> JAJAJEGKILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::IEDFOPGJHFB<HLMPEBPKEBN, HashSet<object>> PFCJDPNNIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager JGDEKKJFKAJ;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4220", Offset = "0x3AC3620", VA = "0x183AC4220")]
	public BLGJBPKCMHC(EntityManager JGDEKKJFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3D60", Offset = "0x3AC3160", VA = "0x183AC3D60", Slot = "4")]
	public bool OJEFHPLBCMD(Entity PJEENOLDJIO, object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3AC26B0", Offset = "0x3AC1AB0", VA = "0x183AC26B0", Slot = "5")]
	public bool IKHJIOCDHHM(Entity PJEENOLDJIO, object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3AC1E40", Offset = "0x3AC1240", VA = "0x183AC1E40", Slot = "6")]
	public bool GNKDLLKCMAB(Entity PJEENOLDJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3AC1EC0", Offset = "0x3AC12C0", VA = "0x183AC1EC0", Slot = "7")]
	public bool GNKDLLKCMAB(HLMPEBPKEBN BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3210", Offset = "0x3AC2610", VA = "0x183AC3210", Slot = "8")]
	public IEnumerable<object> LOPGFNKJDGK(Entity PJEENOLDJIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2F70", Offset = "0x3AC2370", VA = "0x183AC2F70", Slot = "11")]
	public IEnumerable<object> LOPGFNKJDGK(HLMPEBPKEBN BDCLOJHOMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3630", Offset = "0x3AC2A30", VA = "0x183AC3630", Slot = "9")]
	public bool OFNHOFOHAEF(Entity PJEENOLDJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3AC1510", Offset = "0x3AC0910", VA = "0x183AC1510", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3AC22C0", Offset = "0x3AC16C0", VA = "0x183AC22C0")]
	private void HBPBMEPNJCB(HashSet<object> EGEFLCDAMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3AC1330", Offset = "0x3AC0730", VA = "0x183AC1330")]
	private bool ACKKHJFPCJD(Entity PJEENOLDJIO, out HLMPEBPKEBN BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3AC1850", Offset = "0x3AC0C50", VA = "0x183AC1850")]
	private bool FILIKAEMGGL(Entity PJEENOLDJIO, out HLMPEBPKEBN BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3AC1650", Offset = "0x3AC0A50", VA = "0x183AC1650")]
	private void EFOOCOLAJAL(Entity PJEENOLDJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2B30", Offset = "0x3AC1F30", VA = "0x183AC2B30")]
	private void JKOAADBDMIG(Entity PJEENOLDJIO, HLMPEBPKEBN BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3AC35D0", Offset = "0x3AC29D0", VA = "0x183AC35D0")]
	private bool ODKLJJEGKGC(HLMPEBPKEBN BDCLOJHOMDK, out HashSet<object> EGEFLCDAMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3AC1C60", Offset = "0x3AC1060", VA = "0x183AC1C60")]
	private HashSet<object> FKACGLNNIPM()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DBMKFKBDLGF : global::BOJNCJAIHHL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x33C7BC0", Offset = "0x33C6FC0", VA = "0x1833C7BC0", Slot = "4")]
	public float DCMLBICADBM(float3 KPPLMEOMNGF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DHIJGKECCOH : global::BOJNCJAIHHL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5B366E0", Offset = "0x5B35AE0", VA = "0x185B366E0", Slot = "4")]
	public float DCMLBICADBM(float3 KPPLMEOMNGF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KPBBOOPDKHD : global::BOJNCJAIHHL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5B38060", Offset = "0x5B37460", VA = "0x185B38060", Slot = "4")]
	public float DCMLBICADBM(float3 KPPLMEOMNGF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct DJIPACHIMDI : global::BOJNCJAIHHL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xFF5E20", Offset = "0xFF5220", VA = "0x180FF5E20", Slot = "4")]
	public int DCMLBICADBM(int3 KPPLMEOMNGF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JDDMOMGKAPH : global::BOJNCJAIHHL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2C59F40", Offset = "0x2C59340", VA = "0x182C59F40", Slot = "4")]
	public int DCMLBICADBM(int3 KPPLMEOMNGF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KHNKKBABMAN : global::BOJNCJAIHHL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5B37EC0", Offset = "0x5B372C0", VA = "0x185B37EC0", Slot = "4")]
	public int DCMLBICADBM(int3 KPPLMEOMNGF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class JALFHCFAMHA : EDPKKCFLJBE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type DFGAOKJEIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x700130", Offset = "0x6FF530", VA = "0x180700130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xEA4000", Offset = "0xEA3400", VA = "0x180EA4000")]
	public JALFHCFAMHA(Type ENDAIEKKAND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class INBKPPOJOGA : JALFHCFAMHA
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xEA4000", Offset = "0xEA3400", VA = "0x180EA4000")]
	public INBKPPOJOGA(Type ENDAIEKKAND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LHMMEJFDPBI : JALFHCFAMHA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type DACMCNOHHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x700140", Offset = "0x6FF540", VA = "0x180700140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5B38170", Offset = "0x5B37570", VA = "0x185B38170")]
	public LHMMEJFDPBI(Type AILKGGDFHIG, Type ENDAIEKKAND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BLPHJEIJPDJ : JALFHCFAMHA
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xEA4000", Offset = "0xEA3400", VA = "0x180EA4000")]
	public BLPHJEIJPDJ(Type ENDAIEKKAND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BEOLFPGNHND : EDPKKCFLJBE
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public BEOLFPGNHND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IMBAPBFDPJJ : EDPKKCFLJBE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JLLBPLFLIBM JPNBLPBIOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0040", Offset = "0x6DF440", VA = "0x1806E0040")]
		[CompilerGenerated]
		get
		{
			return default(JLLBPLFLIBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xEA3E00", Offset = "0xEA3200", VA = "0x180EA3E00")]
	public IMBAPBFDPJJ(JLLBPLFLIBM HGNBPKPAAFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class JLCGKPAGLMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly NPAPPEKNDDD BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager JGDEKKJFKAJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NPAPPEKNDDD BFPFOELPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5B37C80", Offset = "0x5B37080", VA = "0x185B37C80")]
	public JLCGKPAGLMB(NPAPPEKNDDD BKFHGKOCNCC, EntityManager JGDEKKJFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x22E6280", Offset = "0x22E5680", VA = "0x1822E6280")]
	public bool ABFOFNACMAN<T>(Entity PJEENOLDJIO) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x22E84A0", Offset = "0x22E78A0", VA = "0x1822E84A0")]
	public bool NBBBFAKKDKA<T>(Entity PJEENOLDJIO, out T KPPLMEOMNGF) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x22E6AC0", Offset = "0x22E5EC0", VA = "0x1822E6AC0")]
	public T KDPDHFPEAAJ<T>(Entity PJEENOLDJIO) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x22E62C0", Offset = "0x22E56C0", VA = "0x1822E62C0")]
	private ComponentType HENJBFOHHHM<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5B37BB0", Offset = "0x5B36FB0", VA = "0x185B37BB0")]
	private ComponentType HENJBFOHHHM(Type HAOFNDAEGFJ)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class OMMIJKDJINI
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	protected OMMIJKDJINI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class HHPEOOIEBJM<View, Data> : GBOCHCBEADE where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType KPBFACNHKOF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type KNGKHCOGJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4D5BBD0", Offset = "0x4D5AFD0", VA = "0x184D5BBD0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type EIHDHKLEKBM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4D5B840", Offset = "0x4D5AC40", VA = "0x184D5B840", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int CFFCMGDDICA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2C08760", Offset = "0x2C07B60", VA = "0x182C08760", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2C086F0", Offset = "0x2C07AF0", VA = "0x182C086F0")]
	public Data JFLJPOECIOA(Entity PJEENOLDJIO)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2C08680", Offset = "0x2C07A80", VA = "0x182C08680")]
	public Data CBACACCCGDM(Entity PJEENOLDJIO)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View FBNMHIGHIJH(Entity PJEENOLDJIO);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2B98570", Offset = "0x2B97970", VA = "0x182B98570", Slot = "15")]
	protected internal override T FBNMHIGHIJH<T>(Entity PJEENOLDJIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x14FF8B0", Offset = "0x14FECB0", VA = "0x1814FF8B0")]
	protected HHPEOOIEBJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class GBOCHCBEADE : EBDBOJDCJEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic FPFKLGDICPI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager DDFIBDHKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xB75920", Offset = "0xB74D20", VA = "0x180B75920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type KNGKHCOGJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type EIHDHKLEKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int CFFCMGDDICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type PGAOHOBBBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7E7E70", Offset = "0x7E7270", VA = "0x1807E7E70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int LAAALKCEJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5B36B70", Offset = "0x5B35F70", VA = "0x185B36B70", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private GJOKNGAFGLP[] NPOMKLCOHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7E7DA0", Offset = "0x7E71A0", VA = "0x1807E7DA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual GJOKNGAFGLP[] DPCFLKEACDN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5B36DF0", Offset = "0x5B361F0", VA = "0x185B36DF0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IJBPBIDLELB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5B36BE0", Offset = "0x5B35FE0", VA = "0x185B36BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5B36CD0", Offset = "0x5B360D0", VA = "0x185B36CD0")]
	public void JHHOMPLGCBC(EntityManager JGDEKKJFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE20", Offset = "0x7FE220", VA = "0x1807FEE20")]
	protected EBDBOJDCJEC HGJCKHGIFEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T FBNMHIGHIJH<T>(Entity PJEENOLDJIO) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5B36C10", Offset = "0x5B36010", VA = "0x185B36C10", Slot = "8")]
	public (uint, uint) JABMJFHHHKP(Entity PJEENOLDJIO)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5B36AE0", Offset = "0x5B35EE0", VA = "0x185B36AE0", Slot = "9")]
	public bool HGJBBDHLFGJ(Entity PJEENOLDJIO, (uint order, uint change) LFMBJAIIPEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	protected GBOCHCBEADE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class NMAOLABBAIB<Data> : OCFAEDPPFGC where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data LMPNKNOCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x33127E0", Offset = "0x3311BE0", VA = "0x1833127E0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x235DE40", Offset = "0x235D240", VA = "0x18235DE40", Slot = "8")]
	protected virtual bool LHGDJEIAACJ(ReadOnlySpan<Data> KDCOOOFOCDB, CAANBCJACEG LNANHOBPAPC, out ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "9")]
	protected virtual bool LEMCGNFOKAO(int LFMBJAIIPEH, Span<Data> KDCOOOFOCDB, in ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x33141F0", Offset = "0x33135F0", VA = "0x1833141F0", Slot = "5")]
	internal sealed override bool LHGDJEIAACJ(ref Unity.Entities.Chunk NBAMNFJPPMO, int EMBKHFLIEGM, CAANBCJACEG LNANHOBPAPC, out ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3313470", Offset = "0x3312870", VA = "0x183313470", Slot = "6")]
	internal sealed override bool LEMCGNFOKAO(int LFMBJAIIPEH, ref Unity.Entities.Chunk NBAMNFJPPMO, int EMBKHFLIEGM, in ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x26F15A0", Offset = "0x26F09A0", VA = "0x1826F15A0")]
	protected global::DBNPOKMNHKB<Protobuf> MBJBLDCGJJH<Protobuf>(ReadOnlySpan<Data> KDCOOOFOCDB) where Protobuf : IMessage, new()
	{
		return default(global::DBNPOKMNHKB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26F15F0", Offset = "0x26F09F0", VA = "0x1826F15F0")]
	protected global::HOLFGEBLJPB<Protobuf> PENLAPDOIBO<Protobuf>(ReadOnlySpan<byte> BMHLFOOGPAA, ReadOnlySpan<Data> KDCOOOFOCDB, Action<Protobuf> BIIBMCMPIKN) where Protobuf : IMessage, new()
	{
		return default(global::HOLFGEBLJPB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x14FF8B0", Offset = "0x14FECB0", VA = "0x1814FF8B0")]
	protected NMAOLABBAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class OCFAEDPPFGC
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int CONDCHODOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5B3A8D0", Offset = "0x5B39CD0", VA = "0x185B3A8D0", Slot = "5")]
	internal virtual bool LHGDJEIAACJ(ref Unity.Entities.Chunk NBAMNFJPPMO, int EMBKHFLIEGM, CAANBCJACEG LNANHOBPAPC, out ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "6")]
	internal virtual bool LEMCGNFOKAO(int LFMBJAIIPEH, ref Unity.Entities.Chunk NBAMNFJPPMO, int EMBKHFLIEGM, in ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	protected OCFAEDPPFGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BOJNCJAIHHL<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo DCMLBICADBM(TFrom KPPLMEOMNGF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KNIKDIANKCK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOCIKADFMCP(T KPPLMEOMNGF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct IGKOCKJFLBM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::BOJNCJAIHHL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> BFKGCCPFGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> DOMJOKHJDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap FFBLFKDINEA;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct ICAEGHJCNAF<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::BOJNCJAIHHL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> BOJHJAENAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> DOMJOKHJDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap FFBLFKDINEA;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct DCFHODMLLGC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PNNEJABHBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> BFKGCCPFGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> DOMJOKHJDPA;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2FEAD60", Offset = "0x2FEA160", VA = "0x182FEAD60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct IEJAPPEMFEH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PNNEJABHBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> BFKGCCPFGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> HKMKNPBEGLL;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct OMHFGAPBODA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::BOJNCJAIHHL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> DFIECBKIKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> DOMJOKHJDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap FFBLFKDINEA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct LNLLCFEGHJF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ENDAIEKKAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> INCINPMOBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> KJBGJLGOMED;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct KMADMILHDBP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ENDAIEKKAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> INCINPMOBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> KJBGJLGOMED;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2862F70", Offset = "0x2862370", VA = "0x182862F70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct HABBIEEJLOA<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> BFKGCCPFGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> HKMKNPBEGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, ADEHAJBPFKB> FBPIKFEBIAF;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x37B0AE0", Offset = "0x37AFEE0", VA = "0x1837B0AE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct LDOHJHCHIPD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::BOJNCJAIHHL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> BFKGCCPFGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> HKMKNPBEGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, ADEHAJBPFKB> FBPIKFEBIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap FFBLFKDINEA;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct EIHKNNPGIDA<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::KNIKDIANKCK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> BFKGCCPFGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> HKMKNPBEGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate FFBLFKDINEA;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct LINGABMLKMG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity ENDAIEKKAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> INCINPMOBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> NMOGIBLACBM;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B38450", Offset = "0x5B37850", VA = "0x185B38450", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct HOJNAAKEADO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity ENDAIEKKAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> INCINPMOBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> NMOGIBLACBM;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5B37360", Offset = "0x5B36760", VA = "0x185B37360", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class COPPJBMOJCA
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class GEDFBHKDJEB
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x238D740", Offset = "0x238CB40", VA = "0x18238D740")]
	public static bool CGMOCMJGLED<T>(this NativeArray<Entity> INCINPMOBBH, EntityManager JGDEKKJFKAJ, Allocator GOLNHBOGNGC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class HHMGEEGDGNO
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class KIAJCOLIIOH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public KIAJCOLIIOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class PKDONMJDGFO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public PKDONMJDGFO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> FMAJGHLMKFN;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5B37240", Offset = "0x5B36640", VA = "0x185B37240")]
	public HHMGEEGDGNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GKCKPKAAHFD
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KGODMCDHHKP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct HDKEKFBKHFO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct BKGPLDDIECN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal HDKEKFBKHFO<TFrom> OKMBLMILFGG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator GOLNHBOGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> GLOMCJNAEIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct HMFFDEGOBEK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct IJOKDPFGMIO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal HMFFDEGOBEK<TFrom> OKMBLMILFGG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator GOLNHBOGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> GLOMCJNAEIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct GPEBNIGGOGA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct GHDICADIAOF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal GPEBNIGGOGA<TFrom> OKMBLMILFGG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator GOLNHBOGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> GLOMCJNAEIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct EICPOFMFLCJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct LINGJHLEEOH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal EICPOFMFLCJ<TFrom> OKMBLMILFGG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator GOLNHBOGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> GLOMCJNAEIH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class ICJLOBFFHNE
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JKCMBMFILGP
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x22E60E0", Offset = "0x22E54E0", VA = "0x1822E60E0")]
	public static NativeList<T> MKMHNJHFNHF<T>(this NativeArray<T> BMGAIMDJMKP, Allocator GOLNHBOGNGC = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class JNHIMIEAAKL
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x22EAF30", Offset = "0x22EA330", VA = "0x1822EAF30")]
	public static NativeArray<T> DNABOMEPEIA<T>(this NativeList<Entity> BMGAIMDJMKP, EntityManager JGDEKKJFKAJ, Allocator GOLNHBOGNGC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x22EAD30", Offset = "0x22EA130", VA = "0x1822EAD30")]
	public static NativeArray<T> DNABOMEPEIA<T>(this NativeArray<Entity> BMGAIMDJMKP, EntityManager JGDEKKJFKAJ, Allocator GOLNHBOGNGC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class PMDIBBFBJMH
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct OEEKKNCOMIH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct CHDMHCCIJBM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public OEEKKNCOMIH<TFrom> GLOMCJNAEIH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator GOLNHBOGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> BFKGCCPFGFL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct GBFEDAHHPDG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct LBGBJPPLDIP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public GBFEDAHHPDG<TFrom> GLOMCJNAEIH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator GOLNHBOGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> BFKGCCPFGFL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct GECDDAIMOAP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct LBFHMAJAFJA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public GECDDAIMOAP<TFrom> GLOMCJNAEIH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator GOLNHBOGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> BFKGCCPFGFL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class DOFEIHKFGIO
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class ENOGCIOKJOL
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct PDCHLNONELI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator GOLNHBOGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> BFKGCCPFGFL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct FACMCFLMPLD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator GOLNHBOGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> BFKGCCPFGFL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct LNMJDHJNHGI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator GOLNHBOGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> BFKGCCPFGFL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct EDGJKIAIKNB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator GOLNHBOGNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> BFKGCCPFGFL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class MEOBIKGFEIG
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class AJBEFAGMNKG
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9820", Offset = "0x2BA8C20", VA = "0x182BA9820")]
	public static NativeList<Entity> EHLEMNBGGFL<T>(this NativeArray<Entity> INCINPMOBBH, EntityManager JGDEKKJFKAJ, Allocator GOLNHBOGNGC = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MDNHMPONGOJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HJDCDEJBGKL
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BANJOHGLCKJ
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class GGEAIDFLECK
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class FJCBINEFKGD
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5B36870", Offset = "0x5B35C70", VA = "0x185B36870")]
	public static bool KGMLKIAIHEG(Type HAOFNDAEGFJ, Type AOOOHDMDGMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class EPEKCOLHBBD<Attribute, BaseClass> : global::BBEFJCEPJMG<BaseClass>, NMBIFHBMHKB where Attribute : JALFHCFAMHA
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly JHCDFELAIDH AOHKNGHOEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string GOENAEMJAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> PHLDIHGHBPI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1F8EB60", Offset = "0x1F8DF60", VA = "0x181F8EB60")]
	public EPEKCOLHBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E530", Offset = "0x1F8D930", VA = "0x181F8E530", Slot = "4")]
	public bool BNDEAHDJONI(int DFMDKBNGDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E590", Offset = "0x1F8D990", VA = "0x181F8E590", Slot = "5")]
	public global::FOIBHJLLDAJ<BaseClass> CADGIGEAENM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E970", Offset = "0x1F8DD70", VA = "0x181F8E970", Slot = "7")]
	protected virtual bool KGMLKIAIHEG(Type HAOFNDAEGFJ, int POONMFMAMAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1F8EA70", Offset = "0x1F8DE70", VA = "0x181F8EA70", Slot = "8")]
	protected virtual int LJKDLEFAAGJ(Type HAOFNDAEGFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E840", Offset = "0x1F8DC40", VA = "0x181F8E840")]
	public void DOIEPELEGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E8D0", Offset = "0x1F8DCD0", VA = "0x181F8E8D0", Slot = "6")]
	public void GBHABPPKBJN(Type HAOFNDAEGFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class FOIBHJLLDAJ<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> KLFMBBEFJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> BDCIFADNLMN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> CDDFBAKJMCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3237610", Offset = "0x3236A10", VA = "0x183237610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x32378F0", Offset = "0x3236CF0", VA = "0x1832378F0")]
	public FOIBHJLLDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3237A80", Offset = "0x3236E80", VA = "0x183237A80")]
	public FOIBHJLLDAJ(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3237840", Offset = "0x3236C40", VA = "0x183237840")]
	internal void GBJBCHALJOG(int DFMDKBNGDLJ, BaseClass DCJBADMCBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B94680", Offset = "0x2B93A80", VA = "0x182B94680")]
	public bool AHDIBKPNAEK<T>(out BaseClass KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3237570", Offset = "0x3236970", VA = "0x183237570")]
	public bool AHDIBKPNAEK(Type DDFJPMOIHNM, out BaseClass KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x27459E0", Offset = "0x2744DE0", VA = "0x1827459E0")]
	public bool DEGIINJCDIK(int DFMDKBNGDLJ, out BaseClass KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2B95390", Offset = "0x2B94790", VA = "0x182B95390")]
	public T INGMCKIGKBJ<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x32378C0", Offset = "0x3236CC0", VA = "0x1832378C0")]
	public BaseClass INGMCKIGKBJ(Type LFJLMMMICEP)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class AAHDHJOPECO : global::EPEKCOLHBBD<INBKPPOJOGA, OMMIJKDJINI>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5B35D70", Offset = "0x5B35170", VA = "0x185B35D70")]
	public AAHDHJOPECO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class BPAFKCPHDAA : global::EPEKCOLHBBD<LHMMEJFDPBI, GBOCHCBEADE>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B35F40", Offset = "0x5B35340", VA = "0x185B35F40")]
	public BPAFKCPHDAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class OLGGJMDMEKJ : global::EPEKCOLHBBD<BLPHJEIJPDJ, OCFAEDPPFGC>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5B3A8F0", Offset = "0x5B39CF0", VA = "0x185B3A8F0")]
	public OLGGJMDMEKJ()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[OHGELDJCNJM(GGAOONGBEBH.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> HGOEKJDCDEG;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B6D70", Offset = "0x8B6170", VA = "0x1808B6D70")]
		private ComponentSystemTypes(List<Type> HGOEKJDCDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5B360E0", Offset = "0x5B354E0", VA = "0x185B360E0")]
		public static void DOIEPELEGLE(List<Type> HGOEKJDCDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5B361F0", Offset = "0x5B355F0", VA = "0x185B361F0")]
		private void LLCHACBLLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5B36170", Offset = "0x5B35570", VA = "0x185B36170")]
		private bool KGMLKIAIHEG(Type HAOFNDAEGFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5B36430", Offset = "0x5B35830", VA = "0x185B36430")]
		private void NBCONGBEDIN(Type HAOFNDAEGFJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class FMHBHMFLMCD : IJINHHBANEE
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5B36AA0", Offset = "0x5B35EA0", VA = "0x185B36AA0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase OJJGMJDNJEM();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5B36A50", Offset = "0x5B35E50", VA = "0x185B36A50")]
	protected ComponentSystemBase OPDIJCADOBO(params ComponentSystemBase[] FGEEBMNILFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x23880B0", Offset = "0x23874B0", VA = "0x1823880B0")]
	protected ComponentSystemBase OPDIJCADOBO<T>(params ComponentSystemBase[] FGEEBMNILFP) where T : IJINHHBANEE, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2388070", Offset = "0x2387470", VA = "0x182388070")]
	protected ComponentSystemBase JFLGOGLELCJ<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2388070", Offset = "0x2387470", VA = "0x182388070")]
	protected ComponentSystemBase PHNJKCCKGJL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	protected FMHBHMFLMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface BBEFJCEPJMG<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNDEAHDJONI(int DFMDKBNGDLJ);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::FOIBHJLLDAJ<BaseClass> CADGIGEAENM();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IJINHHBANEE : IKAKECJHJMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B37900", Offset = "0x5B36D00", VA = "0x185B37900", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public IJINHHBANEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class HCAPJDLAPMD : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5B36EB0", Offset = "0x5B362B0", VA = "0x185B36EB0")]
	public ComponentDataFromEntity NPBDALFPBDJ(int DFMDKBNGDLJ, bool BHCHPGOJODJ = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5B36F50", Offset = "0x5B36350", VA = "0x185B36F50", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20")]
	protected HCAPJDLAPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class NPGNNADCJEE : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20")]
	protected NPGNNADCJEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class MKDLICHFONK : HCAPJDLAPMD
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5B38D60", Offset = "0x5B38160", VA = "0x185B38D60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	protected void EEKLFDKHGFH(string KOEAHBDFFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20")]
	protected MKDLICHFONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class EELDDNAABAP
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class IKAKECJHJMJ : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	protected IKAKECJHJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[OHGELDJCNJM(GGAOONGBEBH.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B080", Offset = "0x5B3A480", VA = "0x185B3B080")]
		public static ComponentSystemGroup[] BPJNBJFOOMI(World BKFHGKOCNCC, CEBCGJLJOGN DJICPMCBKNJ = CEBCGJLJOGN.Default, bool FPDEJNOLBLN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5B3BC50", Offset = "0x5B3B050", VA = "0x185B3BC50")]
		private static Type[] MDFCBHGHFCD(CEBCGJLJOGN DJICPMCBKNJ, bool FPDEJNOLBLN, ComponentSystemGroup[] LGOJCCDMGJI, ComponentSystemGroup EEHHFAOOIAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B940", Offset = "0x5B3AD40", VA = "0x185B3B940")]
		private static ComponentSystemGroup[] KGODOJKMKFG(World BKFHGKOCNCC, out ComponentSystemGroup EEHHFAOOIAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5B3BFB0", Offset = "0x5B3B3B0", VA = "0x185B3BFB0")]
		internal static bool PLJBKGOBPIA(JLLBPLFLIBM HGNBPKPAAFI, out MHFGKCNGFOE IGDODBPHFLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B800", Offset = "0x5B3AC00", VA = "0x185B3B800")]
		private static ComponentSystemGroup JAAIJOIAGIO(Type HAOFNDAEGFJ, World BKFHGKOCNCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B1B0", Offset = "0x5B3A5B0", VA = "0x185B3B1B0")]
		private static ComponentSystemGroup[] EDNGEIAAEDD(Type[] HGOEKJDCDEG, World BKFHGKOCNCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B2E0", Offset = "0x5B3A6E0", VA = "0x185B3B2E0")]
		internal static void GBHJAKHGJME(World BKFHGKOCNCC, Type[] OILACFPONGC, ComponentSystemGroup[] LGOJCCDMGJI, ComponentSystemGroup EEHHFAOOIAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B8E0", Offset = "0x5B3ACE0", VA = "0x185B3B8E0")]
		internal static bool JHMBIBDALHL(ComponentSystemBase NGCKCOHKMBE, ComponentSystemGroup[] LGOJCCDMGJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B150", Offset = "0x5B3A550", VA = "0x185B3B150")]
		private static void DAKCPANEFIA(ComponentSystemGroup[] LGOJCCDMGJI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LLAFLGJMICP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> MMNGDECPGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> FGEEBMNILFP;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x790A30", Offset = "0x78FE30", VA = "0x180790A30")]
	public LLAFLGJMICP(Dictionary<Type, List<Type>> MMNGDECPGGL, HashSet<Type> FGEEBMNILFP)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[OHGELDJCNJM(GGAOONGBEBH.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class NBHHECCHEFM : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8BB110", Offset = "0x8BA510", VA = "0x1808BB110")]
			[DebuggerHidden]
			public NBHHECCHEFM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5B39030", Offset = "0x5B38430", VA = "0x185B39030", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5B38D90", Offset = "0x5B38190", VA = "0x185B38D90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5B390C0", Offset = "0x5B384C0", VA = "0x185B390C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5B38FF0", Offset = "0x5B383F0", VA = "0x185B38FF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5B38F40", Offset = "0x5B38340", VA = "0x185B38F40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5B38F40", Offset = "0x5B38340", VA = "0x185B38F40", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct FCOCEGONDLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type ELBLLPJBEAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CEBCGJLJOGN DJICPMCBKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool IHGDNPJKEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool OLJDPMNPCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool FPDEJNOLBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> HDCALLPKBOA;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C510", Offset = "0x5B3B910", VA = "0x185B3C510")]
		public static RRFilterWorldSystems BMDGCEOIEEG()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D040", Offset = "0x5B3C440", VA = "0x185B3D040")]
		public RRFilterWorldSystems MGLLFFAMPGL(CEBCGJLJOGN HGNBPKPAAFI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D050", Offset = "0x5B3C450", VA = "0x185B3D050")]
		public RRFilterWorldSystems NKHPEIIMCLP(IEnumerable<Type> HGOEKJDCDEG)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D090", Offset = "0x5B3C490", VA = "0x185B3D090")]
		public RRFilterWorldSystems ONGKMJMFFEF(bool AONFAPMEIPE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D0A0", Offset = "0x5B3C4A0", VA = "0x185B3D0A0")]
		public RRFilterWorldSystems PCCAAIIOADN(bool NFDMKKMOEEK)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C2C0", Offset = "0x5B3B6C0", VA = "0x185B3C2C0")]
		public LLAFLGJMICP AFLAFKPJEPI(Type[] ANMMHOBHCFL)
		{
			return default(LLAFLGJMICP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C530", Offset = "0x5B3B930", VA = "0x185B3C530")]
		[IteratorStateMachine(typeof(NBHHECCHEFM))]
		internal IEnumerable<Type> DJJCJMPLFHK(IEnumerable<Type> HGOEKJDCDEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5B3CD60", Offset = "0x5B3C160", VA = "0x185B3CD60")]
		internal Dictionary<Type, List<Type>> HCKBEEMIHGI(IEnumerable<Type> HGOEKJDCDEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D0B0", Offset = "0x5B3C4B0", VA = "0x185B3D0B0")]
		private void POADODIHPHF(Dictionary<Type, List<Type>> DJHPOGLHKJI, Type HAOFNDAEGFJ, Type BHFILOFNCMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C350", Offset = "0x5B3B750", VA = "0x185B3C350")]
		internal HashSet<Type> BBAPKHCONLK(IEnumerable<Type> LGOJCCDMGJI, Dictionary<Type, List<Type>> MOBIBCNEEOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C5C0", Offset = "0x5B3B9C0", VA = "0x185B3C5C0")]
		internal bool GCBPMOANFNN(Type HAOFNDAEGFJ, CEBCGJLJOGN DJICPMCBKNJ, bool FPDEJNOLBLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5B3CC00", Offset = "0x5B3C000", VA = "0x185B3CC00")]
		[CompilerGenerated]
		internal static void GKLDDOMJEBB(Type HAOFNDAEGFJ, ref FCOCEGONDLD P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class LILBNDKJNLL
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool HMGJGFNHBLJ;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5B38380", Offset = "0x5B37780", VA = "0x185B38380")]
	public static void JHHOMPLGCBC(bool AKNNPOEHKML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5B381C0", Offset = "0x5B375C0", VA = "0x185B381C0")]
	private static void CMCDJMKAMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class LDHMNPFIODA
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5B38140", Offset = "0x5B37540", VA = "0x185B38140")]
	public static ulong CDBBBPLGHAA(Type HAOFNDAEGFJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5B38080", Offset = "0x5B37480", VA = "0x185B38080")]
	public static ulong CDBBBPLGHAA(string MBJDGKHEFCE)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[OHGELDJCNJM(GGAOONGBEBH.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct PMFLICOOJGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong IKPGNNHEBKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong HOKPHOAKBIK;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xEA18D0", Offset = "0xEA0CD0", VA = "0x180EA18D0")]
			public PMFLICOOJGJ(ulong GDFHNMGENPI, ulong NEHCKFDJHML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5B3AFF0", Offset = "0x5B3A3F0", VA = "0x185B3AFF0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> LLJPCJCALLP;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static PMFLICOOJGJ[] NPFGLCLMEHO;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool HMGJGFNHBLJ;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5B3DA90", Offset = "0x5B3CE90", VA = "0x185B3DA90")]
		public static ulong OHFNHGLFNAB(int DFMDKBNGDLJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D390", Offset = "0x5B3C790", VA = "0x185B3D390")]
		public static int AFGHFCFNFBL(ulong NEHCKFDJHML)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D7B0", Offset = "0x5B3CBB0", VA = "0x185B3D7B0")]
		public static void JHHOMPLGCBC(bool AKNNPOEHKML = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D440", Offset = "0x5B3C840", VA = "0x185B3D440")]
		private static void EILMEAPBJFJ(int KILHPJIADDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5B3DAF0", Offset = "0x5B3CEF0", VA = "0x185B3DAF0")]
		private static void PBNFBKHDFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5B3DE10", Offset = "0x5B3D210", VA = "0x185B3DE10")]
		private static PMFLICOOJGJ PDOEDNFOOEG(Type HAOFNDAEGFJ)
		{
			return default(PMFLICOOJGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D520", Offset = "0x5B3C920", VA = "0x185B3D520")]
		private static ulong GKLCBLFPMEM(Type HAOFNDAEGFJ, ulong NEHCKFDJHML)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D590", Offset = "0x5B3C990", VA = "0x185B3D590")]
		private static void HDJDFKNAJCO(in PMFLICOOJGJ HBMDFFCGEML, TypeManager.TypeInfo NFCACLPGMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D290", Offset = "0x5B3C690", VA = "0x185B3D290")]
		private static void ACCJHFMMAGK(PMFLICOOJGJ NFCACLPGMLB, int DFMDKBNGDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D9B0", Offset = "0x5B3CDB0", VA = "0x185B3D9B0")]
		private static void KLHOLOJMKBK(PMFLICOOJGJ NFCACLPGMLB, int DFMDKBNGDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5B3DEF0", Offset = "0x5B3D2F0", VA = "0x185B3DEF0")]
		private static PMFLICOOJGJ PLONBCJOIFF(int DFMDKBNGDLJ)
		{
			return default(PMFLICOOJGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D9A0", Offset = "0x5B3CDA0", VA = "0x185B3D9A0")]
		private static int KDOGDMMMOOI(int DFMDKBNGDLJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class LPLNGBCJBBA
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly BPAFKCPHDAA OJACBLJELPC;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly OLGGJMDMEKJ MBHLHJLBBPD;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly AAHDHJOPECO HNGFOFFMDCN;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> GNNHGCBEPFL;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool HMGJGFNHBLJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::BBEFJCEPJMG<GBOCHCBEADE> CJLBMJOPKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5B384E0", Offset = "0x5B378E0", VA = "0x185B384E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::BBEFJCEPJMG<OCFAEDPPFGC> GEKLDANGMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5B38540", Offset = "0x5B37940", VA = "0x185B38540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::BBEFJCEPJMG<OMMIJKDJINI> OMDJFDNMKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5B38AD0", Offset = "0x5B37ED0", VA = "0x185B38AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5B385A0", Offset = "0x5B379A0", VA = "0x185B385A0")]
	public static void JHHOMPLGCBC(bool AKNNPOEHKML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5B38A50", Offset = "0x5B37E50", VA = "0x185B38A50")]
	public static Type[] OIEJAFGAPNA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class IBDICAANPGG
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> EAGMNFFKPGI;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool HMGJGFNHBLJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5B37740", Offset = "0x5B36B40", VA = "0x185B37740")]
	public static int JABMJFHHHKP(int DFMDKBNGDLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5B377E0", Offset = "0x5B36BE0", VA = "0x185B377E0")]
	public static void JHHOMPLGCBC(bool AKNNPOEHKML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5B373F0", Offset = "0x5B367F0", VA = "0x185B373F0")]
	private static void EEKKIEEECEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5B37670", Offset = "0x5B36A70", VA = "0x185B37670")]
	private static int FBEDMOEDMIP(Type HAOFNDAEGFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5B376C0", Offset = "0x5B36AC0", VA = "0x185B376C0")]
	private static void FPEOCMBDEPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class NPAPPEKNDDD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World HEEDGNMHMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly JLCGKPAGLMB DCJBADMCBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] LGOJCCDMGJI;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World BFPFOELPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World KFELBCCLKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager DDFIBDHKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CA0", Offset = "0x8B70A0", VA = "0x1808B7CA0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public JLCGKPAGLMB JADDHOMJIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::FOIBHJLLDAJ<GBOCHCBEADE> CJLBMJOPKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x778B00", Offset = "0x777F00", VA = "0x180778B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::FOIBHJLLDAJ<OCFAEDPPFGC> GEKLDANGMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6E7590", Offset = "0x6E6990", VA = "0x1806E7590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::FOIBHJLLDAJ<OMMIJKDJINI> OMDJFDNMKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6E7580", Offset = "0x6E6980", VA = "0x1806E7580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6E75A0", Offset = "0x6E69A0", VA = "0x1806E75A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> OMJDBNDAANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CE0", Offset = "0x8B70E0", VA = "0x1808B7CE0")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] CBDEDCOMEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5B396E0", Offset = "0x5B38AE0", VA = "0x185B396E0")]
	public static NPAPPEKNDDD FGJPGIBLBON(string GOENAEMJAON, JLLBPLFLIBM HGNBPKPAAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5B39B90", Offset = "0x5B38F90", VA = "0x185B39B90")]
	public NPAPPEKNDDD(string GOENAEMJAON, JLLBPLFLIBM HGNBPKPAAFI = JLLBPLFLIBM.Simulation, CEBCGJLJOGN DJICPMCBKNJ = CEBCGJLJOGN.Default, bool AKNNPOEHKML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5B39880", Offset = "0x5B38C80", VA = "0x185B39880")]
	public ComponentSystemBase KBLGHDAPCCJ(Type HAOFNDAEGFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FFB0", Offset = "0x2A3F3B0", VA = "0x182A3FFB0")]
	public T KBLGHDAPCCJ<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5B395B0", Offset = "0x5B389B0", VA = "0x185B395B0")]
	public void DKNINONLEBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5B39760", Offset = "0x5B38B60", VA = "0x185B39760")]
	public void FOBJGLHEHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5B39680", Offset = "0x5B38A80", VA = "0x185B39680")]
	public void FCKMCGKMDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5B39990", Offset = "0x5B38D90", VA = "0x185B39990")]
	public void LCDNAFBIGJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5B398A0", Offset = "0x5B38CA0", VA = "0x185B398A0")]
	public void KHLNDDHDJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5B39AD0", Offset = "0x5B38ED0", VA = "0x185B39AD0")]
	public void OLILDKFBCPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5B397C0", Offset = "0x5B38BC0", VA = "0x185B397C0")]
	public void HEBLFKGEONC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5B39900", Offset = "0x5B38D00", VA = "0x185B39900")]
	public void KNKJALMBGJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5B39B30", Offset = "0x5B38F30", VA = "0x185B39B30")]
	public void PCDPPNBBOKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5B39820", Offset = "0x5B38C20", VA = "0x185B39820")]
	public void IMKBOAAGOGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5B399F0", Offset = "0x5B38DF0", VA = "0x185B399F0")]
	internal void MCNONOIOMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5B39150", Offset = "0x5B38550", VA = "0x185B39150")]
	private bool AKGLDPGDOCP(ComponentSystemGroup DEGOBDGJJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5B391D0", Offset = "0x5B385D0", VA = "0x185B391D0")]
	private void ANNLJPLJDMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5B394A0", Offset = "0x5B388A0", VA = "0x185B394A0")]
	private ComponentSystemGroup[] BPJNBJFOOMI(CEBCGJLJOGN DJICPMCBKNJ, bool FPDEJNOLBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5B39610", Offset = "0x5B38A10", VA = "0x185B39610", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum JLLBPLFLIBM
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
public sealed class ANPBEPBBCEN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public CEBCGJLJOGN MDHHOBAACNB;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum CEBCGJLJOGN
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
public interface MHFGKCNGFOE
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type POLIJDHBFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] FCHPHLFAFPI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class LOBICMJMPOL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool DHHFHCNLDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x701020", Offset = "0x700420", VA = "0x180701020", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	protected LOBICMJMPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class OPGOAAIIKHF : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public OPGOAAIIKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class OHFPMLKFCAB : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public OHFPMLKFCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class AKGEPPMMEJK : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public AKGEPPMMEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class NMBGKHKPLBF : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public NMBGKHKPLBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class NIICOFFACFC : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public NIICOFFACFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class EIPLBFCEONH : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public EIPLBFCEONH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class CIJEBLFAOAC : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public CIJEBLFAOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class HGNDJEEEJJG : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public HGNDJEEEJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class DPPBHFFFOCM : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public DPPBHFFFOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class GPNGEBCHKBI : DMOFBNMPFIK
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public GPNGEBCHKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class KNAOFDPHFED : DMOFBNMPFIK
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public KNAOFDPHFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class FBDHCANIIBB : DMOFBNMPFIK
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public FBDHCANIIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class CAOCCHHGBCN : DMOFBNMPFIK
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public CAOCCHHGBCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[OHKEEAJFOEC(PGBOFPGBDBH.Application)]
public class DMOFBNMPFIK : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool DHHFHCNLDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B351E0", VA = "0x185B35DE0")]
	public DMOFBNMPFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class NCFMNHDMAHK : EDPKKCFLJBE
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public NCFMNHDMAHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class DGDOCDGGGAP
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void JGJLEPJFOGM<From, To>(From GLOMCJNAEIH, ref To KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class JPMGLOMNBGJ<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static JGJLEPJFOGM<From, To> JJMHKHKAEFL;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public JPMGLOMNBGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5B364E0", Offset = "0x5B358E0", VA = "0x185B364E0")]
	static DGDOCDGGGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x23348B0", Offset = "0x2333CB0", VA = "0x1823348B0")]
	public static void LHENBKNDDHG<T>(JGJLEPJFOGM<T, T> EFCHKHBOIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x22F4C20", Offset = "0x22F4020", VA = "0x1822F4C20")]
	public static void LHENBKNDDHG<From, To>(JGJLEPJFOGM<From, To> EFCHKHBOIMK, JGJLEPJFOGM<To, From> AJHGLAOKNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x22F52E0", Offset = "0x22F46E0", VA = "0x1822F52E0")]
	public static void LHENBKNDDHG<From, To>(JGJLEPJFOGM<From, To> JJMHKHKAEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x232F630", Offset = "0x232EA30", VA = "0x18232F630")]
	public static JGJLEPJFOGM<From, To> DBBKGOCIMCF<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x22F6920", Offset = "0x22F5D20", VA = "0x1822F6920")]
	public static void PEMAFCFLIEJ<From, To>(From GLOMCJNAEIH, ref To KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class CAANBCJACEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> PHKGOGKFNKN;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xCEBD90", Offset = "0xCEB190", VA = "0x180CEBD90")]
	public CAANBCJACEG(NativeArray<EntityRemapUtility.EntityRemapInfo> PHKGOGKFNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3124570", Offset = "0x3123970", VA = "0x183124570")]
	public Entity IDDJALPDFGA(Entity EHNCKNECPAL)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class KEDGJNPBDLH
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> DBFCBJFJDKO;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5B37CD0", Offset = "0x5B370D0", VA = "0x185B37CD0")]
	public static bool KLIFHMKMDAM(ulong ADPFJJODLPO, uint LFMBJAIIPEH, out string GOENAEMJAON)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[OHGELDJCNJM(GGAOONGBEBH.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct BHJPEAEGLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int NOAKOLDJPCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int CONDCHODOCK;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x701050", Offset = "0x700450", VA = "0x180701050")]
			public BHJPEAEGLOB(int EGBCAPEEJBF, int LFMBJAIIPEH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct KKMHGDKANDF
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch PKADFIOHLGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long DFAJCDNCKCP;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long HMOHDCAKFKL
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x5B38000", Offset = "0x5B37400", VA = "0x185B38000")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long BMOABHIDDHO
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5B37F90", Offset = "0x5B37390", VA = "0x185B37F90")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5B37ED0", Offset = "0x5B372D0", VA = "0x185B37ED0")]
			public static KKMHGDKANDF FENBOPOOPIH()
			{
				return default(KKMHGDKANDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct OAEADIOFOJI : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct OPJDMADIMOI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* AAHJEPPJFHH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly ODNNNPIKBNL.CEIFDJHGAJA.IMOJJDNGPKP AHJEPICPOEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly CAANBCJACEG LNANHOBPAPC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::FOIBHJLLDAJ<OCFAEDPPFGC> JEMCFCDDPDL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int EMBKHFLIEGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int NOFANLFHHDM;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x5B3AF40", Offset = "0x5B3A340", VA = "0x185B3AF40")]
				public unsafe OPJDMADIMOI(Unity.Entities.Archetype* AAHJEPPJFHH, ODNNNPIKBNL.CEIFDJHGAJA.IMOJJDNGPKP AHJEPICPOEP, CAANBCJACEG LNANHOBPAPC, global::FOIBHJLLDAJ<OCFAEDPPFGC> JEMCFCDDPDL, int EMBKHFLIEGM, int NOFANLFHHDM = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5B3AFA0", Offset = "0x5B3A3A0", VA = "0x185B3AFA0")]
				public OPJDMADIMOI(in OPJDMADIMOI FNIHENPLJHK, int NOFANLFHHDM)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly OPJDMADIMOI[] KDCOOOFOCDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] MNPPLFOAPCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int PMLEGILEAAE;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5B3A790", Offset = "0x5B39B90", VA = "0x185B3A790")]
			public OAEADIOFOJI(OPJDMADIMOI[] KDCOOOFOCDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5B3A0B0", Offset = "0x5B394B0", VA = "0x185B3A0B0", Slot = "4")]
			public void Invoke(int EGBCAPEEJBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5B3A110", Offset = "0x5B39510", VA = "0x185B3A110")]
			private void JAGFIKEFHBK(in OPJDMADIMOI FNIHENPLJHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5B3A4C0", Offset = "0x5B398C0", VA = "0x185B3A4C0")]
			private static void KGDFOKNIBAN(in OPJDMADIMOI FNIHENPLJHK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class LILHEEDLJOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public ODNNNPIKBNL asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::FOIBHJLLDAJ<OCFAEDPPFGC> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public LILHEEDLJOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5B383E0", Offset = "0x5B377E0", VA = "0x185B383E0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class PMGEFABPLGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public ODNNNPIKBNL.CEIFDJHGAJA.IMOJJDNGPKP srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public LILHEEDLJOC CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public PMGEFABPLGH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class HEFBOKOMOPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public PMGEFABPLGH CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public HEFBOKOMOPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5B36F60", Offset = "0x5B36360", VA = "0x185B36F60")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly JHCDFELAIDH HIBAFJNAMHL;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly JHCDFELAIDH PJBMMOADIPL;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly JHCDFELAIDH BAKPGAEKGIB;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly JHCDFELAIDH GMDPFHHKOIF;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool BJBHDHFADKN;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static ODNNNPIKBNL.CEIFDJHGAJA.PBOBNPGGJHM EFEPMMFIKLD;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E750", Offset = "0x5B3DB50", VA = "0x185B3E750")]
		private unsafe static bool BBILDKGADAK(Unity.Entities.Archetype* GOEEEEBMLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5B40410", Offset = "0x5B3F810", VA = "0x185B40410")]
		internal unsafe static Unity.Entities.Archetype*[] KHKDHCHFLMJ(ref Unity.Entities.EntityComponentStore HJLKIPABCHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5B3FC30", Offset = "0x5B3F030", VA = "0x185B3FC30")]
		public static void IDGEKAFJKEF(NPAPPEKNDDD BKFHGKOCNCC, out ByteString BMHLFOOGPAA, out NativeArray<EntityRemapUtility.EntityRemapInfo> HOLOKBFKLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5B41340", Offset = "0x5B40740", VA = "0x185B41340")]
		internal static void POLEFNPLJPG(NPAPPEKNDDD BKFHGKOCNCC, ODNNNPIKBNL NHPEPKCLMFJ, out NativeArray<EntityRemapUtility.EntityRemapInfo> HOLOKBFKLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5B3F110", Offset = "0x5B3E510", VA = "0x185B3F110")]
		private unsafe static UnsafeHashMap<ulong, BHJPEAEGLOB> DPPBLJGAHHK(Unity.Entities.Archetype*[] KIMMLDMFKBK)
		{
			return default(UnsafeHashMap<ulong, BHJPEAEGLOB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5B3F7C0", Offset = "0x5B3EBC0", VA = "0x185B3F7C0")]
		private static void GFPJKMNOFIL(ODNNNPIKBNL NHPEPKCLMFJ, UnsafeHashMap<ulong, BHJPEAEGLOB> GIMBKBDFHJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E860", Offset = "0x5B3DC60", VA = "0x185B3E860")]
		private unsafe static void BKNIBOJLPNA(ODNNNPIKBNL NHPEPKCLMFJ, Unity.Entities.Archetype*[] KIMMLDMFKBK, UnsafeHashMap<ulong, BHJPEAEGLOB> GIMBKBDFHJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5B410A0", Offset = "0x5B404A0", VA = "0x185B410A0")]
		private unsafe static int MLELNMJAEHD(Unity.Entities.Archetype*[] KIMMLDMFKBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5B3F3A0", Offset = "0x5B3E7A0", VA = "0x185B3F3A0")]
		private unsafe static void FGGGGABJKNO(ODNNNPIKBNL NHPEPKCLMFJ, Unity.Entities.Archetype*[] KIMMLDMFKBK, global::FOIBHJLLDAJ<OCFAEDPPFGC> JEMCFCDDPDL, NativeArray<EntityRemapUtility.EntityRemapInfo> HOLOKBFKLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5B3EB90", Offset = "0x5B3DF90", VA = "0x185B3EB90")]
		private static NativeArray<int> CHHJCGDHNDK(ODNNNPIKBNL NHPEPKCLMFJ)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5B3FCF0", Offset = "0x5B3F0F0", VA = "0x185B3FCF0")]
		private static Memory<EntityArchetype> IOGOCAHOPCA(ODNNNPIKBNL NHPEPKCLMFJ, NativeArray<int> HGOEKJDCDEG, EntityManager JGDEKKJFKAJ, out int BHMCBKCHADO, out int GNBPPLIAJDL)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5B405F0", Offset = "0x5B3F9F0", VA = "0x185B405F0")]
		private unsafe static void KNFAEPMCILA(Unity.Entities.Chunk* FCKIBBJGHEJ, ReadOnlySpan<byte> BMHLFOOGPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E010", Offset = "0x5B3D410", VA = "0x185B3E010")]
		private static void AECCACPHIHC(ODNNNPIKBNL NHPEPKCLMFJ, NativeArray<int> HGOEKJDCDEG, Span<EntityArchetype> KIMMLDMFKBK, EntityManager JGDEKKJFKAJ, global::FOIBHJLLDAJ<OCFAEDPPFGC> JEMCFCDDPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5B40940", Offset = "0x5B3FD40", VA = "0x185B40940")]
		private unsafe static void LCKKINNJDAL(Unity.Entities.Chunk* NBAMNFJPPMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5B3EE00", Offset = "0x5B3E200", VA = "0x185B3EE00")]
		private unsafe static void DNABPIKAOJA(ODNNNPIKBNL.CEIFDJHGAJA.IMOJJDNGPKP AAHJEPPJFHH, int OIAGCBNIECL, int DNBLCPBHHBF, Unity.Entities.Chunk* FCKIBBJGHEJ, ODNNNPIKBNL NHPEPKCLMFJ, NativeArray<int> HGOEKJDCDEG, global::FOIBHJLLDAJ<OCFAEDPPFGC> JEMCFCDDPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5B41010", Offset = "0x5B40410", VA = "0x185B41010")]
		public static void MKJBPNKKHJB(NPAPPEKNDDD BKFHGKOCNCC, in ByteString BMHLFOOGPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5B409C0", Offset = "0x5B3FDC0", VA = "0x185B409C0")]
		public static void MKJBPNKKHJB(EntityManager JGDEKKJFKAJ, global::FOIBHJLLDAJ<OCFAEDPPFGC> JEMCFCDDPDL, in ByteString BMHLFOOGPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5B3F970", Offset = "0x5B3ED70", VA = "0x185B3F970")]
		private static bool HGGKPLJOBJL(Type HAOFNDAEGFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5B40160", Offset = "0x5B3F560", VA = "0x185B40160")]
		private static void KCBNHGDDICE(TypeManager.TypeInfo NFCACLPGMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5B41110", Offset = "0x5B40510", VA = "0x185B41110")]
		private unsafe static int NINHKFKEEHN(Unity.Entities.Archetype*[] KIMMLDMFKBK, NativeArray<EntityRemapUtility.EntityRemapInfo> HOLOKBFKLNC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5B40080", Offset = "0x5B3F480", VA = "0x185B40080")]
		private static int JABMJFHHHKP(int DFMDKBNGDLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5B412A0", Offset = "0x5B406A0", VA = "0x185B412A0")]
		private static ulong OHFNHGLFNAB(int DFMDKBNGDLJ)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class ONPHEEMEAEM
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5B3ADA0", Offset = "0x5B3A1A0", VA = "0x185B3ADA0")]
	private unsafe static Span<byte> IMOKOOFLICL(Unity.Entities.Chunk* NBAMNFJPPMO, int EMBKHFLIEGM)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x233C030", Offset = "0x233B430", VA = "0x18233C030")]
	public unsafe static Span<T> FAGJGOLFBDI<T>(Unity.Entities.Chunk* NBAMNFJPPMO, int EMBKHFLIEGM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x20382B0", Offset = "0x20376B0", VA = "0x1820382B0")]
	public static Span<T> FAGJGOLFBDI<T>(this ref Unity.Entities.Chunk NBAMNFJPPMO, int EMBKHFLIEGM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5B3AD30", Offset = "0x5B3A130", VA = "0x185B3AD30")]
	public unsafe static Span<Entity> GAPCIALFHIH(Unity.Entities.Chunk* NBAMNFJPPMO)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5B3AA90", Offset = "0x5B39E90", VA = "0x185B3AA90")]
	public unsafe static void FPEOCMBDEPF(Unity.Entities.Chunk* NBAMNFJPPMO, int EMBKHFLIEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B3A960", Offset = "0x5B39D60", VA = "0x185B3A960")]
	public static Entity FIFECFCLEDF(this EntityQuery APEJLGJADFF)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : PLIGCBHMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5B41CD0", Offset = "0x5B410D0", VA = "0x185B41CD0", Slot = "4")]
		public sealed override void DOIEPELEGLE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HFBMMEPCDLM()
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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

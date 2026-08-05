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
		[Cpp2IlInjected.Address(RVA = "0x5AAC140", Offset = "0x5AAB140", VA = "0x185AAC140")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5AACA50", Offset = "0x5AABA50", VA = "0x185AACA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AACAC0", Offset = "0x5AABAC0", VA = "0x185AACAC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3031C50", Offset = "0x3030C50", VA = "0x183031C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E27390", Offset = "0x1E26390", VA = "0x181E27390")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E26BC0", Offset = "0x1E25BC0", VA = "0x181E26BC0")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E26CC0", Offset = "0x1E25CC0", VA = "0x181E26CC0")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E270C0", Offset = "0x1E260C0", VA = "0x181E270C0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5AACAE0", Offset = "0x5AABAE0", VA = "0x185AACAE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x700040", Offset = "0x6FF040", VA = "0x180700040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x31D81D0", Offset = "0x31D71D0", VA = "0x1831D81D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1112A30", Offset = "0x1111A30", VA = "0x181112A30")]
		[DebuggerHidden]
		public MEAANJACGPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x31D7FF0", Offset = "0x31D6FF0", VA = "0x1831D7FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x31D8190", Offset = "0x31D7190", VA = "0x1831D8190", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF010", Offset = "0x6DE010", VA = "0x1806DF010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x38E84F0", Offset = "0x38E74F0", VA = "0x1838E84F0")]
	private HOLFGEBLJPB(byte[] BFNDINBALAB, Action<Protobuf> BIIBMCMPIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x48CF890", Offset = "0x48CE890", VA = "0x1848CF890")]
	public static global::HOLFGEBLJPB<Protobuf> BMDGCEOIEEG<Data>(ReadOnlySpan<byte> BMHLFOOGPAA, ReadOnlySpan<Data> KDCOOOFOCDB, Action<Protobuf> BIIBMCMPIKN)
	{
		return default(global::HOLFGEBLJPB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x38E8360", Offset = "0x38E7360", VA = "0x1838E8360", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x38E83A0", Offset = "0x38E73A0", VA = "0x1838E83A0", Slot = "4")]
	[IteratorStateMachine(typeof(global::HOLFGEBLJPB<>.MEAANJACGPJ))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x38E84A0", Offset = "0x38E74A0", VA = "0x1838E84A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x299E7B0", Offset = "0x299D7B0", VA = "0x18299E7B0")]
	private DBNPOKMNHKB(byte[] BFNDINBALAB, in Protobuf GBEOCIOFDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x28E0F30", Offset = "0x28DFF30", VA = "0x1828E0F30")]
	public static global::DBNPOKMNHKB<Protobuf> BMDGCEOIEEG<T>(ReadOnlySpan<T> KDCOOOFOCDB)
	{
		return default(global::DBNPOKMNHKB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x299E5C0", Offset = "0x299D5C0", VA = "0x18299E5C0")]
	public void AOHDDDCFHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x299E5F0", Offset = "0x299D5F0", VA = "0x18299E5F0")]
	public ByteString DKPGHNHACBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x299E680", Offset = "0x299D680", VA = "0x18299E680", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AAF470", Offset = "0x5AAE470", VA = "0x185AAF470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AAC300", Offset = "0x5AAB300", VA = "0x185AAC300", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HOMINANNICH
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	public static void EEJBPCLBJEC(this JHCDFELAIDH AOHKNGHOEPF, NativeArray<Entity> GMAMPIGCEAB, [Optional][CallerFilePath] string NHGNBMKPGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	public static void EEJBPCLBJEC(this JHCDFELAIDH AOHKNGHOEPF, string GOENAEMJAON, NativeArray<Entity> GMAMPIGCEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	public static void EEJBPCLBJEC(this JHCDFELAIDH AOHKNGHOEPF, string NHGNBMKPGCO, NativeArray<Entity> GMAMPIGCEAB, bool COANEGMLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	public static void GHOMHCBLNAD(this JHCDFELAIDH AOHKNGHOEPF, NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> OCFBEMCGNEI, [Optional][CallerFilePath] string NHGNBMKPGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	public static void GHOMHCBLNAD(this JHCDFELAIDH AOHKNGHOEPF, string NHGNBMKPGCO, NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> OCFBEMCGNEI, bool COANEGMLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x22B8A70", Offset = "0x22B7A70", VA = "0x1822B8A70")]
	public static void KCEHCIOHKMH<T>(this JHCDFELAIDH AOHKNGHOEPF, string GOENAEMJAON, NativeArray<Entity> GMAMPIGCEAB, NativeList<T> FNIHENPLJHK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x22B8A30", Offset = "0x22B7A30", VA = "0x1822B8A30")]
	public static void KCEHCIOHKMH<T>(this JHCDFELAIDH AOHKNGHOEPF, string GOENAEMJAON, NativeArray<Entity> GMAMPIGCEAB, NativeArray<T> FNIHENPLJHK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	public static void KCEHCIOHKMH<T>(this JHCDFELAIDH AOHKNGHOEPF, string NHGNBMKPGCO, NativeArray<Entity> GMAMPIGCEAB, NativeArray<T> FNIHENPLJHK, bool COANEGMLMGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x22B8B30", Offset = "0x22B7B30", VA = "0x1822B8B30")]
	public static void LNFFNGGNOLF<T>(this JHCDFELAIDH AOHKNGHOEPF, NativeList<T> FNIHENPLJHK, [Optional][CallerFilePath] string NHGNBMKPGCO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x22B8B00", Offset = "0x22B7B00", VA = "0x1822B8B00")]
	public static void LNFFNGGNOLF<T>(this JHCDFELAIDH AOHKNGHOEPF, NativeArray<T> FNIHENPLJHK, [Optional][CallerFilePath] string NHGNBMKPGCO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	public static void LNFFNGGNOLF<T>(this JHCDFELAIDH AOHKNGHOEPF, string NHGNBMKPGCO, NativeArray<T> FNIHENPLJHK, bool COANEGMLMGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	public static void KMOOMIJAMAP(this JHCDFELAIDH AOHKNGHOEPF, EntityQuery APEJLGJADFF, [Optional][CallerFilePath] string NHGNBMKPGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	public static void KMOOMIJAMAP(this JHCDFELAIDH AOHKNGHOEPF, string GOENAEMJAON, EntityQuery APEJLGJADFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	public static void KMOOMIJAMAP(this JHCDFELAIDH AOHKNGHOEPF, string NHGNBMKPGCO, EntityQuery APEJLGJADFF, bool COANEGMLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x22B8A00", Offset = "0x22B7A00", VA = "0x1822B8A00")]
	public static void IMBMHBLMNBH<T, T2>(this JHCDFELAIDH AOHKNGHOEPF, string GOENAEMJAON, EntityQuery APEJLGJADFF) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2029390", Offset = "0x2028390", VA = "0x182029390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x24CE110", Offset = "0x24CD110", VA = "0x1824CE110")]
		public bool IMMOPABFOGI(out TValue KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x24CE060", Offset = "0x24CD060", VA = "0x1824CE060")]
		public void GBJBCHALJOG(object JAKCBCDLMLB, TValue KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x24CE280", Offset = "0x24CD280", VA = "0x1824CE280")]
		public bool PMMODKPOELK(object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x24CE1D0", Offset = "0x24CD1D0", VA = "0x1824CE1D0")]
		public int LGFPODHHMBH(object JAKCBCDLMLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x24CE300", Offset = "0x24CD300", VA = "0x1824CE300")]
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
	[Cpp2IlInjected.Address(RVA = "0x2EEB420", Offset = "0x2EEA420", VA = "0x182EEB420")]
	public CMEECFLOIOG(EntityManager JGDEKKJFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2EEB300", Offset = "0x2EEA300", VA = "0x182EEB300", Slot = "4")]
	public void OJEFHPLBCMD(Entity PJEENOLDJIO, object JAKCBCDLMLB, TValue KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2EEB030", Offset = "0x2EEA030", VA = "0x182EEB030", Slot = "5")]
	public bool IKHJIOCDHHM(Entity PJEENOLDJIO, object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2EEB1A0", Offset = "0x2EEA1A0", VA = "0x182EEB1A0", Slot = "6")]
	public bool IMMOPABFOGI(Entity PJEENOLDJIO, out TValue KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2EEAED0", Offset = "0x2EE9ED0", VA = "0x182EEAED0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2EEAFB0", Offset = "0x2EE9FB0", VA = "0x182EEAFB0")]
	private void HBPBMEPNJCB(AHDPKLIEAIF EGEFLCDAMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2EEAE00", Offset = "0x2EE9E00", VA = "0x182EEAE00")]
	private bool ACKKHJFPCJD(Entity PJEENOLDJIO, out HLMPEBPKEBN BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2EEB270", Offset = "0x2EEA270", VA = "0x182EEB270")]
	private void JKOAADBDMIG(Entity PJEENOLDJIO, HLMPEBPKEBN BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2EEAEB0", Offset = "0x2EE9EB0", VA = "0x182EEAEB0")]
	private bool DHLCOLHIBHJ(HLMPEBPKEBN BDCLOJHOMDK, out AHDPKLIEAIF EGEFLCDAMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2EEAEF0", Offset = "0x2EE9EF0", VA = "0x182EEAEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x790E40", Offset = "0x78FE40", VA = "0x180790E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x790DB0", Offset = "0x78FDB0", VA = "0x180790DB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A8550", Offset = "0x8A7550", VA = "0x1808A8550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xE96F30", Offset = "0xE95F30", VA = "0x180E96F30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD620", Offset = "0x5AAC620", VA = "0x185AAD620", Slot = "8")]
	public bool Equals(HLMPEBPKEBN JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD670", Offset = "0x5AAC670", VA = "0x185AAD670", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A2D290", Offset = "0x3A2C290", VA = "0x183A2D290")]
	public BLGJBPKCMHC(EntityManager JGDEKKJFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3A2CDD0", Offset = "0x3A2BDD0", VA = "0x183A2CDD0", Slot = "4")]
	public bool OJEFHPLBCMD(Entity PJEENOLDJIO, object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3A2B720", Offset = "0x3A2A720", VA = "0x183A2B720", Slot = "5")]
	public bool IKHJIOCDHHM(Entity PJEENOLDJIO, object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3A2AEB0", Offset = "0x3A29EB0", VA = "0x183A2AEB0", Slot = "6")]
	public bool GNKDLLKCMAB(Entity PJEENOLDJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3A2AF30", Offset = "0x3A29F30", VA = "0x183A2AF30", Slot = "7")]
	public bool GNKDLLKCMAB(HLMPEBPKEBN BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3A2C280", Offset = "0x3A2B280", VA = "0x183A2C280", Slot = "8")]
	public IEnumerable<object> LOPGFNKJDGK(Entity PJEENOLDJIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3A2BFE0", Offset = "0x3A2AFE0", VA = "0x183A2BFE0", Slot = "11")]
	public IEnumerable<object> LOPGFNKJDGK(HLMPEBPKEBN BDCLOJHOMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A2C6A0", Offset = "0x3A2B6A0", VA = "0x183A2C6A0", Slot = "9")]
	public bool OFNHOFOHAEF(Entity PJEENOLDJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A580", Offset = "0x3A29580", VA = "0x183A2A580", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3A2B330", Offset = "0x3A2A330", VA = "0x183A2B330")]
	private void HBPBMEPNJCB(HashSet<object> EGEFLCDAMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A3A0", Offset = "0x3A293A0", VA = "0x183A2A3A0")]
	private bool ACKKHJFPCJD(Entity PJEENOLDJIO, out HLMPEBPKEBN BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A8C0", Offset = "0x3A298C0", VA = "0x183A2A8C0")]
	private bool FILIKAEMGGL(Entity PJEENOLDJIO, out HLMPEBPKEBN BDCLOJHOMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A6C0", Offset = "0x3A296C0", VA = "0x183A2A6C0")]
	private void EFOOCOLAJAL(Entity PJEENOLDJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3A2BBA0", Offset = "0x3A2ABA0", VA = "0x183A2BBA0")]
	private void JKOAADBDMIG(Entity PJEENOLDJIO, HLMPEBPKEBN BDCLOJHOMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3A2C640", Offset = "0x3A2B640", VA = "0x183A2C640")]
	private bool ODKLJJEGKGC(HLMPEBPKEBN BDCLOJHOMDK, out HashSet<object> EGEFLCDAMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3A2ACD0", Offset = "0x3A29CD0", VA = "0x183A2ACD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AAC830", Offset = "0x5AAB830", VA = "0x185AAC830", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AACA40", Offset = "0x5AABA40", VA = "0x185AACA40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AAE3C0", Offset = "0x5AAD3C0", VA = "0x185AAE3C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x10091F0", Offset = "0x10081F0", VA = "0x1810091F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3BCC500", Offset = "0x3BCB500", VA = "0x183BCC500", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AAE220", Offset = "0x5AAD220", VA = "0x185AAE220", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6FF130", Offset = "0x6FE130", VA = "0x1806FF130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xE9EE00", Offset = "0xE9DE00", VA = "0x180E9EE00")]
	public JALFHCFAMHA(Type ENDAIEKKAND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class INBKPPOJOGA : JALFHCFAMHA
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xE9EE00", Offset = "0xE9DE00", VA = "0x180E9EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FF140", Offset = "0x6FE140", VA = "0x1806FF140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE4D0", Offset = "0x5AAD4D0", VA = "0x185AAE4D0")]
	public LHMMEJFDPBI(Type AILKGGDFHIG, Type ENDAIEKKAND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BLPHJEIJPDJ : JALFHCFAMHA
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xE9EE00", Offset = "0xE9DE00", VA = "0x180E9EE00")]
	public BLPHJEIJPDJ(Type ENDAIEKKAND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BEOLFPGNHND : EDPKKCFLJBE
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF040", Offset = "0x6DE040", VA = "0x1806DF040")]
		[CompilerGenerated]
		get
		{
			return default(JLLBPLFLIBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xE9EC00", Offset = "0xE9DC00", VA = "0x180E9EC00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5AADFE0", Offset = "0x5AACFE0", VA = "0x185AADFE0")]
	public JLCGKPAGLMB(NPAPPEKNDDD BKFHGKOCNCC, EntityManager JGDEKKJFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x294F110", Offset = "0x294E110", VA = "0x18294F110")]
	public bool ABFOFNACMAN<T>(Entity PJEENOLDJIO) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x21C8010", Offset = "0x21C7010", VA = "0x1821C8010")]
	public bool NBBBFAKKDKA<T>(Entity PJEENOLDJIO, out T KPPLMEOMNGF) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x294F950", Offset = "0x294E950", VA = "0x18294F950")]
	public T KDPDHFPEAAJ<T>(Entity PJEENOLDJIO) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x294F150", Offset = "0x294E150", VA = "0x18294F150")]
	private ComponentType HENJBFOHHHM<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5AADF10", Offset = "0x5AACF10", VA = "0x185AADF10")]
	private ComponentType HENJBFOHHHM(Type HAOFNDAEGFJ)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class OMMIJKDJINI
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x335FBB0", Offset = "0x335EBB0", VA = "0x18335FBB0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type EIHDHKLEKBM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x335E800", Offset = "0x335D800", VA = "0x18335E800", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int CFFCMGDDICA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x335EBF0", Offset = "0x335DBF0", VA = "0x18335EBF0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x335EB80", Offset = "0x335DB80", VA = "0x18335EB80")]
	public Data JFLJPOECIOA(Entity PJEENOLDJIO)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x335EB10", Offset = "0x335DB10", VA = "0x18335EB10")]
	public Data CBACACCCGDM(Entity PJEENOLDJIO)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View FBNMHIGHIJH(Entity PJEENOLDJIO);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x35AF830", Offset = "0x35AE830", VA = "0x1835AF830", Slot = "15")]
	protected internal override T FBNMHIGHIJH<T>(Entity PJEENOLDJIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1116540", Offset = "0x1115540", VA = "0x181116540")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xB74920", Offset = "0xB73920", VA = "0x180B74920")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E6E70", Offset = "0x7E5E70", VA = "0x1807E6E70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int LAAALKCEJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5AACED0", Offset = "0x5AABED0", VA = "0x185AACED0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private GJOKNGAFGLP[] NPOMKLCOHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6DA0", Offset = "0x7E5DA0", VA = "0x1807E6DA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual GJOKNGAFGLP[] DPCFLKEACDN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5AAD150", Offset = "0x5AAC150", VA = "0x185AAD150", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IJBPBIDLELB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5AACF40", Offset = "0x5AABF40", VA = "0x185AACF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD030", Offset = "0x5AAC030", VA = "0x185AAD030")]
	public void JHHOMPLGCBC(EntityManager JGDEKKJFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE20", Offset = "0x7FCE20", VA = "0x1807FDE20")]
	protected EBDBOJDCJEC HGJCKHGIFEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T FBNMHIGHIJH<T>(Entity PJEENOLDJIO) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5AACF70", Offset = "0x5AABF70", VA = "0x185AACF70", Slot = "8")]
	public (uint, uint) JABMJFHHHKP(Entity PJEENOLDJIO)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5AACE40", Offset = "0x5AABE40", VA = "0x185AACE40", Slot = "9")]
	public bool HGJBBDHLFGJ(Entity PJEENOLDJIO, (uint order, uint change) LFMBJAIIPEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x23CF340", Offset = "0x23CE340", VA = "0x1823CF340", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x22DF020", Offset = "0x22DE020", VA = "0x1822DF020", Slot = "8")]
	protected virtual bool LHGDJEIAACJ(ReadOnlySpan<Data> KDCOOOFOCDB, CAANBCJACEG LNANHOBPAPC, out ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "9")]
	protected virtual bool LEMCGNFOKAO(int LFMBJAIIPEH, Span<Data> KDCOOOFOCDB, in ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x23D0D50", Offset = "0x23CFD50", VA = "0x1823D0D50", Slot = "5")]
	internal sealed override bool LHGDJEIAACJ(ref Unity.Entities.Chunk NBAMNFJPPMO, int EMBKHFLIEGM, CAANBCJACEG LNANHOBPAPC, out ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x23CFE40", Offset = "0x23CEE40", VA = "0x1823CFE40", Slot = "6")]
	internal sealed override bool LEMCGNFOKAO(int LFMBJAIIPEH, ref Unity.Entities.Chunk NBAMNFJPPMO, int EMBKHFLIEGM, in ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2638390", Offset = "0x2637390", VA = "0x182638390")]
	protected global::DBNPOKMNHKB<Protobuf> MBJBLDCGJJH<Protobuf>(ReadOnlySpan<Data> KDCOOOFOCDB) where Protobuf : IMessage, new()
	{
		return default(global::DBNPOKMNHKB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26383E0", Offset = "0x26373E0", VA = "0x1826383E0")]
	protected global::HOLFGEBLJPB<Protobuf> PENLAPDOIBO<Protobuf>(ReadOnlySpan<byte> BMHLFOOGPAA, ReadOnlySpan<Data> KDCOOOFOCDB, Action<Protobuf> BIIBMCMPIKN) where Protobuf : IMessage, new()
	{
		return default(global::HOLFGEBLJPB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1116540", Offset = "0x1115540", VA = "0x181116540")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AB0C30", Offset = "0x5AAFC30", VA = "0x185AB0C30", Slot = "5")]
	internal virtual bool LHGDJEIAACJ(ref Unity.Entities.Chunk NBAMNFJPPMO, int EMBKHFLIEGM, CAANBCJACEG LNANHOBPAPC, out ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "6")]
	internal virtual bool LEMCGNFOKAO(int LFMBJAIIPEH, ref Unity.Entities.Chunk NBAMNFJPPMO, int EMBKHFLIEGM, in ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x299EA70", Offset = "0x299DA70", VA = "0x18299EA70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B5A580", Offset = "0x2B59580", VA = "0x182B5A580", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3712E20", Offset = "0x3711E20", VA = "0x183712E20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AAE7B0", Offset = "0x5AAD7B0", VA = "0x185AAE7B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AAD6C0", Offset = "0x5AAC6C0", VA = "0x185AAD6C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x231E220", Offset = "0x231D220", VA = "0x18231E220")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AAD5A0", Offset = "0x5AAC5A0", VA = "0x185AAD5A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x294EF70", Offset = "0x294DF70", VA = "0x18294EF70")]
	public static NativeList<T> MKMHNJHFNHF<T>(this NativeArray<T> BMGAIMDJMKP, Allocator GOLNHBOGNGC = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class JNHIMIEAAKL
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x21CAAA0", Offset = "0x21C9AA0", VA = "0x1821CAAA0")]
	public static NativeArray<T> DNABOMEPEIA<T>(this NativeList<Entity> BMGAIMDJMKP, EntityManager JGDEKKJFKAJ, Allocator GOLNHBOGNGC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x21CA8A0", Offset = "0x21C98A0", VA = "0x1821CA8A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x176A2C0", Offset = "0x17692C0", VA = "0x18176A2C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AACBD0", Offset = "0x5AABBD0", VA = "0x185AACBD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2028B90", Offset = "0x2027B90", VA = "0x182028B90")]
	public EPEKCOLHBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2028560", Offset = "0x2027560", VA = "0x182028560", Slot = "4")]
	public bool BNDEAHDJONI(int DFMDKBNGDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x20285C0", Offset = "0x20275C0", VA = "0x1820285C0", Slot = "5")]
	public global::FOIBHJLLDAJ<BaseClass> CADGIGEAENM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x20289A0", Offset = "0x20279A0", VA = "0x1820289A0", Slot = "7")]
	protected virtual bool KGMLKIAIHEG(Type HAOFNDAEGFJ, int POONMFMAMAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2028AA0", Offset = "0x2027AA0", VA = "0x182028AA0", Slot = "8")]
	protected virtual int LJKDLEFAAGJ(Type HAOFNDAEGFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2028870", Offset = "0x2027870", VA = "0x182028870")]
	public void DOIEPELEGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2028900", Offset = "0x2027900", VA = "0x182028900", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x31489A0", Offset = "0x31479A0", VA = "0x1831489A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3148C80", Offset = "0x3147C80", VA = "0x183148C80")]
	public FOIBHJLLDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3148E10", Offset = "0x3147E10", VA = "0x183148E10")]
	public FOIBHJLLDAJ(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3148BD0", Offset = "0x3147BD0", VA = "0x183148BD0")]
	internal void GBJBCHALJOG(int DFMDKBNGDLJ, BaseClass DCJBADMCBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x35AB940", Offset = "0x35AA940", VA = "0x1835AB940")]
	public bool AHDIBKPNAEK<T>(out BaseClass KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3148900", Offset = "0x3147900", VA = "0x183148900")]
	public bool AHDIBKPNAEK(Type DDFJPMOIHNM, out BaseClass KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2524C00", Offset = "0x2523C00", VA = "0x182524C00")]
	public bool DEGIINJCDIK(int DFMDKBNGDLJ, out BaseClass KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x35AC650", Offset = "0x35AB650", VA = "0x1835AC650")]
	public T INGMCKIGKBJ<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3148C50", Offset = "0x3147C50", VA = "0x183148C50")]
	public BaseClass INGMCKIGKBJ(Type LFJLMMMICEP)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class AAHDHJOPECO : global::EPEKCOLHBBD<INBKPPOJOGA, OMMIJKDJINI>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC0C0", Offset = "0x5AAB0C0", VA = "0x185AAC0C0")]
	public AAHDHJOPECO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class BPAFKCPHDAA : global::EPEKCOLHBBD<LHMMEJFDPBI, GBOCHCBEADE>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC290", Offset = "0x5AAB290", VA = "0x185AAC290")]
	public BPAFKCPHDAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class OLGGJMDMEKJ : global::EPEKCOLHBBD<BLPHJEIJPDJ, OCFAEDPPFGC>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5AB0C50", Offset = "0x5AAFC50", VA = "0x185AB0C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B5D70", Offset = "0x8B4D70", VA = "0x1808B5D70")]
		private ComponentSystemTypes(List<Type> HGOEKJDCDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC430", Offset = "0x5AAB430", VA = "0x185AAC430")]
		public static void DOIEPELEGLE(List<Type> HGOEKJDCDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC540", Offset = "0x5AAB540", VA = "0x185AAC540")]
		private void LLCHACBLLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC4C0", Offset = "0x5AAB4C0", VA = "0x185AAC4C0")]
		private bool KGMLKIAIHEG(Type HAOFNDAEGFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC780", Offset = "0x5AAB780", VA = "0x185AAC780")]
		private void NBCONGBEDIN(Type HAOFNDAEGFJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class FMHBHMFLMCD : IJINHHBANEE
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5AACE00", Offset = "0x5AABE00", VA = "0x185AACE00", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase OJJGMJDNJEM();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5AACDB0", Offset = "0x5AABDB0", VA = "0x185AACDB0")]
	protected ComponentSystemBase OPDIJCADOBO(params ComponentSystemBase[] FGEEBMNILFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2357D70", Offset = "0x2356D70", VA = "0x182357D70")]
	protected ComponentSystemBase OPDIJCADOBO<T>(params ComponentSystemBase[] FGEEBMNILFP) where T : IJINHHBANEE, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2357D30", Offset = "0x2356D30", VA = "0x182357D30")]
	protected ComponentSystemBase JFLGOGLELCJ<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2357D30", Offset = "0x2356D30", VA = "0x182357D30")]
	protected ComponentSystemBase PHNJKCCKGJL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	protected FMHBHMFLMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AADC60", Offset = "0x5AACC60", VA = "0x185AADC60", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public IJINHHBANEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class HCAPJDLAPMD : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD210", Offset = "0x5AAC210", VA = "0x185AAD210")]
	public ComponentDataFromEntity NPBDALFPBDJ(int DFMDKBNGDLJ, bool BHCHPGOJODJ = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD2B0", Offset = "0x5AAC2B0", VA = "0x185AAD2B0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20")]
	protected HCAPJDLAPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class NPGNNADCJEE : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20")]
	protected NPGNNADCJEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class MKDLICHFONK : HCAPJDLAPMD
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF0C0", Offset = "0x5AAE0C0", VA = "0x185AAF0C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	protected void EEKLFDKHGFH(string KOEAHBDFFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20")]
	protected MKDLICHFONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	protected IKAKECJHJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AB13E0", Offset = "0x5AB03E0", VA = "0x185AB13E0")]
		public static ComponentSystemGroup[] BPJNBJFOOMI(World BKFHGKOCNCC, CEBCGJLJOGN DJICPMCBKNJ = CEBCGJLJOGN.Default, bool FPDEJNOLBLN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1FB0", Offset = "0x5AB0FB0", VA = "0x185AB1FB0")]
		private static Type[] MDFCBHGHFCD(CEBCGJLJOGN DJICPMCBKNJ, bool FPDEJNOLBLN, ComponentSystemGroup[] LGOJCCDMGJI, ComponentSystemGroup EEHHFAOOIAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1CA0", Offset = "0x5AB0CA0", VA = "0x185AB1CA0")]
		private static ComponentSystemGroup[] KGODOJKMKFG(World BKFHGKOCNCC, out ComponentSystemGroup EEHHFAOOIAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2310", Offset = "0x5AB1310", VA = "0x185AB2310")]
		internal static bool PLJBKGOBPIA(JLLBPLFLIBM HGNBPKPAAFI, out MHFGKCNGFOE IGDODBPHFLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1B60", Offset = "0x5AB0B60", VA = "0x185AB1B60")]
		private static ComponentSystemGroup JAAIJOIAGIO(Type HAOFNDAEGFJ, World BKFHGKOCNCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1510", Offset = "0x5AB0510", VA = "0x185AB1510")]
		private static ComponentSystemGroup[] EDNGEIAAEDD(Type[] HGOEKJDCDEG, World BKFHGKOCNCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1640", Offset = "0x5AB0640", VA = "0x185AB1640")]
		internal static void GBHJAKHGJME(World BKFHGKOCNCC, Type[] OILACFPONGC, ComponentSystemGroup[] LGOJCCDMGJI, ComponentSystemGroup EEHHFAOOIAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1C40", Offset = "0x5AB0C40", VA = "0x185AB1C40")]
		internal static bool JHMBIBDALHL(ComponentSystemBase NGCKCOHKMBE, ComponentSystemGroup[] LGOJCCDMGJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AB14B0", Offset = "0x5AB04B0", VA = "0x185AB14B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x78FA30", Offset = "0x78EA30", VA = "0x18078FA30")]
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
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8BA110", Offset = "0x8B9110", VA = "0x1808BA110")]
			[DebuggerHidden]
			public NBHHECCHEFM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5AAF390", Offset = "0x5AAE390", VA = "0x185AAF390", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5AAF0F0", Offset = "0x5AAE0F0", VA = "0x185AAF0F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5AAF420", Offset = "0x5AAE420", VA = "0x185AAF420")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5AAF350", Offset = "0x5AAE350", VA = "0x185AAF350", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5AAF2A0", Offset = "0x5AAE2A0", VA = "0x185AAF2A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5AAF2A0", Offset = "0x5AAE2A0", VA = "0x185AAF2A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AB2870", Offset = "0x5AB1870", VA = "0x185AB2870")]
		public static RRFilterWorldSystems BMDGCEOIEEG()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5AB33A0", Offset = "0x5AB23A0", VA = "0x185AB33A0")]
		public RRFilterWorldSystems MGLLFFAMPGL(CEBCGJLJOGN HGNBPKPAAFI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5AB33B0", Offset = "0x5AB23B0", VA = "0x185AB33B0")]
		public RRFilterWorldSystems NKHPEIIMCLP(IEnumerable<Type> HGOEKJDCDEG)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5AB33F0", Offset = "0x5AB23F0", VA = "0x185AB33F0")]
		public RRFilterWorldSystems ONGKMJMFFEF(bool AONFAPMEIPE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3400", Offset = "0x5AB2400", VA = "0x185AB3400")]
		public RRFilterWorldSystems PCCAAIIOADN(bool NFDMKKMOEEK)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2620", Offset = "0x5AB1620", VA = "0x185AB2620")]
		public LLAFLGJMICP AFLAFKPJEPI(Type[] ANMMHOBHCFL)
		{
			return default(LLAFLGJMICP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2890", Offset = "0x5AB1890", VA = "0x185AB2890")]
		[IteratorStateMachine(typeof(NBHHECCHEFM))]
		internal IEnumerable<Type> DJJCJMPLFHK(IEnumerable<Type> HGOEKJDCDEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5AB30C0", Offset = "0x5AB20C0", VA = "0x185AB30C0")]
		internal Dictionary<Type, List<Type>> HCKBEEMIHGI(IEnumerable<Type> HGOEKJDCDEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3410", Offset = "0x5AB2410", VA = "0x185AB3410")]
		private void POADODIHPHF(Dictionary<Type, List<Type>> DJHPOGLHKJI, Type HAOFNDAEGFJ, Type BHFILOFNCMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5AB26B0", Offset = "0x5AB16B0", VA = "0x185AB26B0")]
		internal HashSet<Type> BBAPKHCONLK(IEnumerable<Type> LGOJCCDMGJI, Dictionary<Type, List<Type>> MOBIBCNEEOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2920", Offset = "0x5AB1920", VA = "0x185AB2920")]
		internal bool GCBPMOANFNN(Type HAOFNDAEGFJ, CEBCGJLJOGN DJICPMCBKNJ, bool FPDEJNOLBLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2F60", Offset = "0x5AB1F60", VA = "0x185AB2F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AAE6E0", Offset = "0x5AAD6E0", VA = "0x185AAE6E0")]
	public static void JHHOMPLGCBC(bool AKNNPOEHKML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE520", Offset = "0x5AAD520", VA = "0x185AAE520")]
	private static void CMCDJMKAMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class LDHMNPFIODA
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE4A0", Offset = "0x5AAD4A0", VA = "0x185AAE4A0")]
	public static ulong CDBBBPLGHAA(Type HAOFNDAEGFJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE3E0", Offset = "0x5AAD3E0", VA = "0x185AAE3E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE9C6D0", Offset = "0xE9B6D0", VA = "0x180E9C6D0")]
			public PMFLICOOJGJ(ulong GDFHNMGENPI, ulong NEHCKFDJHML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5AB1350", Offset = "0x5AB0350", VA = "0x185AB1350", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AB3DF0", Offset = "0x5AB2DF0", VA = "0x185AB3DF0")]
		public static ulong OHFNHGLFNAB(int DFMDKBNGDLJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5AB36F0", Offset = "0x5AB26F0", VA = "0x185AB36F0")]
		public static int AFGHFCFNFBL(ulong NEHCKFDJHML)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3B10", Offset = "0x5AB2B10", VA = "0x185AB3B10")]
		public static void JHHOMPLGCBC(bool AKNNPOEHKML = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5AB37A0", Offset = "0x5AB27A0", VA = "0x185AB37A0")]
		private static void EILMEAPBJFJ(int KILHPJIADDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3E50", Offset = "0x5AB2E50", VA = "0x185AB3E50")]
		private static void PBNFBKHDFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4170", Offset = "0x5AB3170", VA = "0x185AB4170")]
		private static PMFLICOOJGJ PDOEDNFOOEG(Type HAOFNDAEGFJ)
		{
			return default(PMFLICOOJGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3880", Offset = "0x5AB2880", VA = "0x185AB3880")]
		private static ulong GKLCBLFPMEM(Type HAOFNDAEGFJ, ulong NEHCKFDJHML)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5AB38F0", Offset = "0x5AB28F0", VA = "0x185AB38F0")]
		private static void HDJDFKNAJCO(in PMFLICOOJGJ HBMDFFCGEML, TypeManager.TypeInfo NFCACLPGMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5AB35F0", Offset = "0x5AB25F0", VA = "0x185AB35F0")]
		private static void ACCJHFMMAGK(PMFLICOOJGJ NFCACLPGMLB, int DFMDKBNGDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3D10", Offset = "0x5AB2D10", VA = "0x185AB3D10")]
		private static void KLHOLOJMKBK(PMFLICOOJGJ NFCACLPGMLB, int DFMDKBNGDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4250", Offset = "0x5AB3250", VA = "0x185AB4250")]
		private static PMFLICOOJGJ PLONBCJOIFF(int DFMDKBNGDLJ)
		{
			return default(PMFLICOOJGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3D00", Offset = "0x5AB2D00", VA = "0x185AB3D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AAE840", Offset = "0x5AAD840", VA = "0x185AAE840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::BBEFJCEPJMG<OCFAEDPPFGC> GEKLDANGMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5AAE8A0", Offset = "0x5AAD8A0", VA = "0x185AAE8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::BBEFJCEPJMG<OMMIJKDJINI> OMDJFDNMKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5AAEE30", Offset = "0x5AADE30", VA = "0x185AAEE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE900", Offset = "0x5AAD900", VA = "0x185AAE900")]
	public static void JHHOMPLGCBC(bool AKNNPOEHKML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5AAEDB0", Offset = "0x5AADDB0", VA = "0x185AAEDB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AADAA0", Offset = "0x5AACAA0", VA = "0x185AADAA0")]
	public static int JABMJFHHHKP(int DFMDKBNGDLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5AADB40", Offset = "0x5AACB40", VA = "0x185AADB40")]
	public static void JHHOMPLGCBC(bool AKNNPOEHKML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD750", Offset = "0x5AAC750", VA = "0x185AAD750")]
	private static void EEKKIEEECEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD9D0", Offset = "0x5AAC9D0", VA = "0x185AAD9D0")]
	private static int FBEDMOEDMIP(Type HAOFNDAEGFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5AADA20", Offset = "0x5AACA20", VA = "0x185AADA20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World KFELBCCLKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager DDFIBDHKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8B6CA0", Offset = "0x8B5CA0", VA = "0x1808B6CA0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public JLCGKPAGLMB JADDHOMJIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::FOIBHJLLDAJ<GBOCHCBEADE> CJLBMJOPKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x777B00", Offset = "0x776B00", VA = "0x180777B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::FOIBHJLLDAJ<OCFAEDPPFGC> GEKLDANGMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6E6590", Offset = "0x6E5590", VA = "0x1806E6590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::FOIBHJLLDAJ<OMMIJKDJINI> OMDJFDNMKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6E6580", Offset = "0x6E5580", VA = "0x1806E6580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6E65A0", Offset = "0x6E55A0", VA = "0x1806E65A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> OMJDBNDAANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8B6CE0", Offset = "0x8B5CE0", VA = "0x1808B6CE0")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] CBDEDCOMEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5AAFA40", Offset = "0x5AAEA40", VA = "0x185AAFA40")]
	public static NPAPPEKNDDD FGJPGIBLBON(string GOENAEMJAON, JLLBPLFLIBM HGNBPKPAAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5AAFEF0", Offset = "0x5AAEEF0", VA = "0x185AAFEF0")]
	public NPAPPEKNDDD(string GOENAEMJAON, JLLBPLFLIBM HGNBPKPAAFI = JLLBPLFLIBM.Simulation, CEBCGJLJOGN DJICPMCBKNJ = CEBCGJLJOGN.Default, bool AKNNPOEHKML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5AAFBE0", Offset = "0x5AAEBE0", VA = "0x185AAFBE0")]
	public ComponentSystemBase KBLGHDAPCCJ(Type HAOFNDAEGFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x261AAE0", Offset = "0x2619AE0", VA = "0x18261AAE0")]
	public T KBLGHDAPCCJ<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF910", Offset = "0x5AAE910", VA = "0x185AAF910")]
	public void DKNINONLEBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5AAFAC0", Offset = "0x5AAEAC0", VA = "0x185AAFAC0")]
	public void FOBJGLHEHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF9E0", Offset = "0x5AAE9E0", VA = "0x185AAF9E0")]
	public void FCKMCGKMDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5AAFCF0", Offset = "0x5AAECF0", VA = "0x185AAFCF0")]
	public void LCDNAFBIGJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5AAFC00", Offset = "0x5AAEC00", VA = "0x185AAFC00")]
	public void KHLNDDHDJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5AAFE30", Offset = "0x5AAEE30", VA = "0x185AAFE30")]
	public void OLILDKFBCPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5AAFB20", Offset = "0x5AAEB20", VA = "0x185AAFB20")]
	public void HEBLFKGEONC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5AAFC60", Offset = "0x5AAEC60", VA = "0x185AAFC60")]
	public void KNKJALMBGJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5AAFE90", Offset = "0x5AAEE90", VA = "0x185AAFE90")]
	public void PCDPPNBBOKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5AAFB80", Offset = "0x5AAEB80", VA = "0x185AAFB80")]
	public void IMKBOAAGOGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5AAFD50", Offset = "0x5AAED50", VA = "0x185AAFD50")]
	internal void MCNONOIOMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF4B0", Offset = "0x5AAE4B0", VA = "0x185AAF4B0")]
	private bool AKGLDPGDOCP(ComponentSystemGroup DEGOBDGJJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF530", Offset = "0x5AAE530", VA = "0x185AAF530")]
	private void ANNLJPLJDMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF800", Offset = "0x5AAE800", VA = "0x185AAF800")]
	private ComponentSystemGroup[] BPJNBJFOOMI(CEBCGJLJOGN DJICPMCBKNJ, bool FPDEJNOLBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5AAF970", Offset = "0x5AAE970", VA = "0x185AAF970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	protected LOBICMJMPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class OPGOAAIIKHF : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public OPGOAAIIKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class OHFPMLKFCAB : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public OHFPMLKFCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class AKGEPPMMEJK : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public AKGEPPMMEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class NMBGKHKPLBF : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public NMBGKHKPLBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class NIICOFFACFC : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public NIICOFFACFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class EIPLBFCEONH : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public EIPLBFCEONH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class CIJEBLFAOAC : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public CIJEBLFAOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class HGNDJEEEJJG : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public HGNDJEEEJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class DPPBHFFFOCM : LOBICMJMPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public DPPBHFFFOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class GPNGEBCHKBI : DMOFBNMPFIK
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public GPNGEBCHKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class KNAOFDPHFED : DMOFBNMPFIK
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public KNAOFDPHFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class FBDHCANIIBB : DMOFBNMPFIK
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public FBDHCANIIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class CAOCCHHGBCN : DMOFBNMPFIK
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public CAOCCHHGBCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC130", Offset = "0x5AAB130", VA = "0x185AAC130")]
	public DMOFBNMPFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class NCFMNHDMAHK : EDPKKCFLJBE
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public JPMGLOMNBGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC840", Offset = "0x5AAB840", VA = "0x185AAC840")]
	static DGDOCDGGGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2134B10", Offset = "0x2133B10", VA = "0x182134B10")]
	public static void LHENBKNDDHG<T>(JGJLEPJFOGM<T, T> EFCHKHBOIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2134960", Offset = "0x2133960", VA = "0x182134960")]
	public static void LHENBKNDDHG<From, To>(JGJLEPJFOGM<From, To> EFCHKHBOIMK, JGJLEPJFOGM<To, From> AJHGLAOKNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2134910", Offset = "0x2133910", VA = "0x182134910")]
	public static void LHENBKNDDHG<From, To>(JGJLEPJFOGM<From, To> JJMHKHKAEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x212F690", Offset = "0x212E690", VA = "0x18212F690")]
	public static JGJLEPJFOGM<From, To> DBBKGOCIMCF<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2136990", Offset = "0x2135990", VA = "0x182136990")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEAD90", Offset = "0xCE9D90", VA = "0x180CEAD90")]
	public CAANBCJACEG(NativeArray<EntityRemapUtility.EntityRemapInfo> PHKGOGKFNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x30EB070", Offset = "0x30EA070", VA = "0x1830EB070")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AAE030", Offset = "0x5AAD030", VA = "0x185AAE030")]
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
			[Cpp2IlInjected.Address(RVA = "0x700050", Offset = "0x6FF050", VA = "0x180700050")]
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
				[Cpp2IlInjected.Address(RVA = "0x5AAE360", Offset = "0x5AAD360", VA = "0x185AAE360")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long BMOABHIDDHO
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5AAE2F0", Offset = "0x5AAD2F0", VA = "0x185AAE2F0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5AAE230", Offset = "0x5AAD230", VA = "0x185AAE230")]
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
				[Cpp2IlInjected.Address(RVA = "0x5AB12A0", Offset = "0x5AB02A0", VA = "0x185AB12A0")]
				public unsafe OPJDMADIMOI(Unity.Entities.Archetype* AAHJEPPJFHH, ODNNNPIKBNL.CEIFDJHGAJA.IMOJJDNGPKP AHJEPICPOEP, CAANBCJACEG LNANHOBPAPC, global::FOIBHJLLDAJ<OCFAEDPPFGC> JEMCFCDDPDL, int EMBKHFLIEGM, int NOFANLFHHDM = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5AB1300", Offset = "0x5AB0300", VA = "0x185AB1300")]
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
			[Cpp2IlInjected.Address(RVA = "0x5AB0AF0", Offset = "0x5AAFAF0", VA = "0x185AB0AF0")]
			public OAEADIOFOJI(OPJDMADIMOI[] KDCOOOFOCDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5AB0410", Offset = "0x5AAF410", VA = "0x185AB0410", Slot = "4")]
			public void Invoke(int EGBCAPEEJBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5AB0470", Offset = "0x5AAF470", VA = "0x185AB0470")]
			private void JAGFIKEFHBK(in OPJDMADIMOI FNIHENPLJHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5AB0820", Offset = "0x5AAF820", VA = "0x185AB0820")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public LILHEEDLJOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5AAE740", Offset = "0x5AAD740", VA = "0x185AAE740")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public HEFBOKOMOPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5AAD2C0", Offset = "0x5AAC2C0", VA = "0x185AAD2C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AB4AB0", Offset = "0x5AB3AB0", VA = "0x185AB4AB0")]
		private unsafe static bool BBILDKGADAK(Unity.Entities.Archetype* GOEEEEBMLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5AB6770", Offset = "0x5AB5770", VA = "0x185AB6770")]
		internal unsafe static Unity.Entities.Archetype*[] KHKDHCHFLMJ(ref Unity.Entities.EntityComponentStore HJLKIPABCHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5AB5F90", Offset = "0x5AB4F90", VA = "0x185AB5F90")]
		public static void IDGEKAFJKEF(NPAPPEKNDDD BKFHGKOCNCC, out ByteString BMHLFOOGPAA, out NativeArray<EntityRemapUtility.EntityRemapInfo> HOLOKBFKLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5AB76A0", Offset = "0x5AB66A0", VA = "0x185AB76A0")]
		internal static void POLEFNPLJPG(NPAPPEKNDDD BKFHGKOCNCC, ODNNNPIKBNL NHPEPKCLMFJ, out NativeArray<EntityRemapUtility.EntityRemapInfo> HOLOKBFKLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5AB5470", Offset = "0x5AB4470", VA = "0x185AB5470")]
		private unsafe static UnsafeHashMap<ulong, BHJPEAEGLOB> DPPBLJGAHHK(Unity.Entities.Archetype*[] KIMMLDMFKBK)
		{
			return default(UnsafeHashMap<ulong, BHJPEAEGLOB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5AB5B20", Offset = "0x5AB4B20", VA = "0x185AB5B20")]
		private static void GFPJKMNOFIL(ODNNNPIKBNL NHPEPKCLMFJ, UnsafeHashMap<ulong, BHJPEAEGLOB> GIMBKBDFHJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4BC0", Offset = "0x5AB3BC0", VA = "0x185AB4BC0")]
		private unsafe static void BKNIBOJLPNA(ODNNNPIKBNL NHPEPKCLMFJ, Unity.Entities.Archetype*[] KIMMLDMFKBK, UnsafeHashMap<ulong, BHJPEAEGLOB> GIMBKBDFHJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5AB7400", Offset = "0x5AB6400", VA = "0x185AB7400")]
		private unsafe static int MLELNMJAEHD(Unity.Entities.Archetype*[] KIMMLDMFKBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5AB5700", Offset = "0x5AB4700", VA = "0x185AB5700")]
		private unsafe static void FGGGGABJKNO(ODNNNPIKBNL NHPEPKCLMFJ, Unity.Entities.Archetype*[] KIMMLDMFKBK, global::FOIBHJLLDAJ<OCFAEDPPFGC> JEMCFCDDPDL, NativeArray<EntityRemapUtility.EntityRemapInfo> HOLOKBFKLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4EF0", Offset = "0x5AB3EF0", VA = "0x185AB4EF0")]
		private static NativeArray<int> CHHJCGDHNDK(ODNNNPIKBNL NHPEPKCLMFJ)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5AB6050", Offset = "0x5AB5050", VA = "0x185AB6050")]
		private static Memory<EntityArchetype> IOGOCAHOPCA(ODNNNPIKBNL NHPEPKCLMFJ, NativeArray<int> HGOEKJDCDEG, EntityManager JGDEKKJFKAJ, out int BHMCBKCHADO, out int GNBPPLIAJDL)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5AB6950", Offset = "0x5AB5950", VA = "0x185AB6950")]
		private unsafe static void KNFAEPMCILA(Unity.Entities.Chunk* FCKIBBJGHEJ, ReadOnlySpan<byte> BMHLFOOGPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4370", Offset = "0x5AB3370", VA = "0x185AB4370")]
		private static void AECCACPHIHC(ODNNNPIKBNL NHPEPKCLMFJ, NativeArray<int> HGOEKJDCDEG, Span<EntityArchetype> KIMMLDMFKBK, EntityManager JGDEKKJFKAJ, global::FOIBHJLLDAJ<OCFAEDPPFGC> JEMCFCDDPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5AB6CA0", Offset = "0x5AB5CA0", VA = "0x185AB6CA0")]
		private unsafe static void LCKKINNJDAL(Unity.Entities.Chunk* NBAMNFJPPMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5AB5160", Offset = "0x5AB4160", VA = "0x185AB5160")]
		private unsafe static void DNABPIKAOJA(ODNNNPIKBNL.CEIFDJHGAJA.IMOJJDNGPKP AAHJEPPJFHH, int OIAGCBNIECL, int DNBLCPBHHBF, Unity.Entities.Chunk* FCKIBBJGHEJ, ODNNNPIKBNL NHPEPKCLMFJ, NativeArray<int> HGOEKJDCDEG, global::FOIBHJLLDAJ<OCFAEDPPFGC> JEMCFCDDPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5AB7370", Offset = "0x5AB6370", VA = "0x185AB7370")]
		public static void MKJBPNKKHJB(NPAPPEKNDDD BKFHGKOCNCC, in ByteString BMHLFOOGPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5AB6D20", Offset = "0x5AB5D20", VA = "0x185AB6D20")]
		public static void MKJBPNKKHJB(EntityManager JGDEKKJFKAJ, global::FOIBHJLLDAJ<OCFAEDPPFGC> JEMCFCDDPDL, in ByteString BMHLFOOGPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5AB5CD0", Offset = "0x5AB4CD0", VA = "0x185AB5CD0")]
		private static bool HGGKPLJOBJL(Type HAOFNDAEGFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5AB64C0", Offset = "0x5AB54C0", VA = "0x185AB64C0")]
		private static void KCBNHGDDICE(TypeManager.TypeInfo NFCACLPGMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5AB7470", Offset = "0x5AB6470", VA = "0x185AB7470")]
		private unsafe static int NINHKFKEEHN(Unity.Entities.Archetype*[] KIMMLDMFKBK, NativeArray<EntityRemapUtility.EntityRemapInfo> HOLOKBFKLNC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5AB63E0", Offset = "0x5AB53E0", VA = "0x185AB63E0")]
		private static int JABMJFHHHKP(int DFMDKBNGDLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5AB7600", Offset = "0x5AB6600", VA = "0x185AB7600")]
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
	[Cpp2IlInjected.Address(RVA = "0x5AB1100", Offset = "0x5AB0100", VA = "0x185AB1100")]
	private unsafe static Span<byte> IMOKOOFLICL(Unity.Entities.Chunk* NBAMNFJPPMO, int EMBKHFLIEGM)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2487270", Offset = "0x2486270", VA = "0x182487270")]
	public unsafe static Span<T> FAGJGOLFBDI<T>(Unity.Entities.Chunk* NBAMNFJPPMO, int EMBKHFLIEGM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x24873F0", Offset = "0x24863F0", VA = "0x1824873F0")]
	public static Span<T> FAGJGOLFBDI<T>(this ref Unity.Entities.Chunk NBAMNFJPPMO, int EMBKHFLIEGM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5AB1090", Offset = "0x5AB0090", VA = "0x185AB1090")]
	public unsafe static Span<Entity> GAPCIALFHIH(Unity.Entities.Chunk* NBAMNFJPPMO)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5AB0DF0", Offset = "0x5AAFDF0", VA = "0x185AB0DF0")]
	public unsafe static void FPEOCMBDEPF(Unity.Entities.Chunk* NBAMNFJPPMO, int EMBKHFLIEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5AB0CC0", Offset = "0x5AAFCC0", VA = "0x185AB0CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8030", Offset = "0x5AB7030", VA = "0x185AB8030", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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

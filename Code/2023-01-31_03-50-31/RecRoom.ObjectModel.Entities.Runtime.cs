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
		[Cpp2IlInjected.Address(RVA = "0x5AA9570", Offset = "0x5AA8370", VA = "0x185AA9570")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5AAA160", Offset = "0x5AA8F60", VA = "0x185AAA160")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AAA1D0", Offset = "0x5AA8FD0", VA = "0x185AAA1D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x49461A0", Offset = "0x4944FA0", VA = "0x1849461A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x35691F0", Offset = "0x3567FF0", VA = "0x1835691F0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x35688A0", Offset = "0x35676A0", VA = "0x1835688A0")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x35689A0", Offset = "0x35677A0", VA = "0x1835689A0")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3568DA0", Offset = "0x3567BA0", VA = "0x183568DA0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5AAA1F0", Offset = "0x5AA8FF0", VA = "0x185AAA1F0")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LJLPAFFKOGM<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ACMFPDCOJDL : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::LJLPAFFKOGM<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9FCE90", Offset = "0x9FBC90", VA = "0x1809FCE90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x457AB70", Offset = "0x4579970", VA = "0x18457AB70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2E6EE50", Offset = "0x2E6DC50", VA = "0x182E6EE50")]
		[DebuggerHidden]
		public ACMFPDCOJDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x457A990", Offset = "0x4579790", VA = "0x18457A990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x457AB30", Offset = "0x4579930", VA = "0x18457AB30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> FFICHOMLEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream KJHFBEBKBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream CFJCOFJCCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf KLNJKJCAPGC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int AFMNPELKBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x734720", Offset = "0x733520", VA = "0x180734720")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4457CE0", Offset = "0x4456AE0", VA = "0x184457CE0")]
	private LJLPAFFKOGM(byte[] FAHBHODOFIG, Action<Protobuf> FFICHOMLEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2F680E0", Offset = "0x2F66EE0", VA = "0x182F680E0")]
	public static global::LJLPAFFKOGM<Protobuf> HJNGNBALKKN<Data>(ReadOnlySpan<byte> GEGIPEOHNBF, ReadOnlySpan<Data> FKFMFNKJNOH, Action<Protobuf> FFICHOMLEMH)
	{
		return default(global::LJLPAFFKOGM<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4457B50", Offset = "0x4456950", VA = "0x184457B50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4457B90", Offset = "0x4456990", VA = "0x184457B90", Slot = "4")]
	[IteratorStateMachine(typeof(global::LJLPAFFKOGM<>.ACMFPDCOJDL))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4457C90", Offset = "0x4456A90", VA = "0x184457C90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MDCAJNGFNFL<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] FAHBHODOFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf KLNJKJCAPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream KJHFBEBKBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream KFEFBBJJDDH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x400EB20", Offset = "0x400D920", VA = "0x18400EB20")]
	private MDCAJNGFNFL(byte[] FAHBHODOFIG, in Protobuf KLNJKJCAPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2F6E4D0", Offset = "0x2F6D2D0", VA = "0x182F6E4D0")]
	public static global::MDCAJNGFNFL<Protobuf> HJNGNBALKKN<T>(ReadOnlySpan<T> FKFMFNKJNOH)
	{
		return default(global::MDCAJNGFNFL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x400E930", Offset = "0x400D730", VA = "0x18400E930")]
	public void AJHGBOOADGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x400EA90", Offset = "0x400D890", VA = "0x18400EA90")]
	public ByteString HGDFBDGENEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x400E960", Offset = "0x400D760", VA = "0x18400E960", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct AODNJLMCICM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream KJHFBEBKBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream CFJCOFJCCIA;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5AA9530", Offset = "0x5AA8330", VA = "0x185AA9530", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LGLIINPPKPD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] FAHBHODOFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream KJHFBEBKBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream KFEFBBJJDDH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB5B0", Offset = "0x5AAA3B0", VA = "0x185AAB5B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FMFDDBDCLID
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	public static void MJBFDABAMKA(this FBNJDMKEPCN KKLHLPEDHHE, NativeArray<Entity> BNEBECKGGLP, [Optional][CallerFilePath] string MAMFIJBOHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	public static void MJBFDABAMKA(this FBNJDMKEPCN KKLHLPEDHHE, string IADPDEAGFAB, NativeArray<Entity> BNEBECKGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	public static void MJBFDABAMKA(this FBNJDMKEPCN KKLHLPEDHHE, string MAMFIJBOHPN, NativeArray<Entity> BNEBECKGGLP, bool DBADFKHLJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	public static void MKDGCNJKKEH(this FBNJDMKEPCN KKLHLPEDHHE, NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> JMOFNBOBEAE, [Optional][CallerFilePath] string MAMFIJBOHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	public static void MKDGCNJKKEH(this FBNJDMKEPCN KKLHLPEDHHE, string MAMFIJBOHPN, NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> JMOFNBOBEAE, bool DBADFKHLJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3A146D0", Offset = "0x3A134D0", VA = "0x183A146D0")]
	public static void EAKNDGIPFKO<T>(this FBNJDMKEPCN KKLHLPEDHHE, string IADPDEAGFAB, NativeArray<Entity> BNEBECKGGLP, NativeList<T> FILAKGLBGGA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3A14760", Offset = "0x3A13560", VA = "0x183A14760")]
	public static void EAKNDGIPFKO<T>(this FBNJDMKEPCN KKLHLPEDHHE, string IADPDEAGFAB, NativeArray<Entity> BNEBECKGGLP, NativeArray<T> FILAKGLBGGA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	public static void EAKNDGIPFKO<T>(this FBNJDMKEPCN KKLHLPEDHHE, string MAMFIJBOHPN, NativeArray<Entity> BNEBECKGGLP, NativeArray<T> FILAKGLBGGA, bool DBADFKHLJMI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3A147D0", Offset = "0x3A135D0", VA = "0x183A147D0")]
	public static void KBDLLDEKBHG<T>(this FBNJDMKEPCN KKLHLPEDHHE, NativeList<T> FILAKGLBGGA, [Optional][CallerFilePath] string MAMFIJBOHPN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3A147A0", Offset = "0x3A135A0", VA = "0x183A147A0")]
	public static void KBDLLDEKBHG<T>(this FBNJDMKEPCN KKLHLPEDHHE, NativeArray<T> FILAKGLBGGA, [Optional][CallerFilePath] string MAMFIJBOHPN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	public static void KBDLLDEKBHG<T>(this FBNJDMKEPCN KKLHLPEDHHE, string MAMFIJBOHPN, NativeArray<T> FILAKGLBGGA, bool DBADFKHLJMI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	public static void EOLFAPCFDEO(this FBNJDMKEPCN KKLHLPEDHHE, EntityQuery FBENFNFLPOM, [Optional][CallerFilePath] string MAMFIJBOHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	public static void EOLFAPCFDEO(this FBNJDMKEPCN KKLHLPEDHHE, string IADPDEAGFAB, EntityQuery FBENFNFLPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	public static void EOLFAPCFDEO(this FBNJDMKEPCN KKLHLPEDHHE, string MAMFIJBOHPN, EntityQuery FBENFNFLPOM, bool DBADFKHLJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3A14840", Offset = "0x3A13640", VA = "0x183A14840")]
	public static void PKGJFEINHMN<T, T2>(this FBNJDMKEPCN KKLHLPEDHHE, string IADPDEAGFAB, EntityQuery FBENFNFLPOM) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	private static void PKGJFEINHMN<T, T2>(this FBNJDMKEPCN KKLHLPEDHHE, string MAMFIJBOHPN, EntityQuery FBENFNFLPOM, bool DBADFKHLJMI) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ADNHFABDAIG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HMIKLFBELAH BDHDLDFKJDF
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
public interface KGEAMOGNOJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CCDNHHDJMDL(Entity IEFFOCOBJJI, object KCCFEDJJGAN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KPKDACOAPCG(Entity IEFFOCOBJJI, object KCCFEDJJGAN);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMFCMIFFGPD(Entity IEFFOCOBJJI);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MMFCMIFFGPD(HMIKLFBELAH DCLMHANFEGK);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> HPNCIPNDFOB(Entity IEFFOCOBJJI);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IKFKBILPLPP(Entity IEFFOCOBJJI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LIFNMLFFFJC<TComponentData, TValue> : global::LHGPJLBEMAO<TValue>, IDisposable where TComponentData : struct, ADNHFABDAIG
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class HKIAKFGOLLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> DEEJEKFIHBB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int BCBDBMHFMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3443340", Offset = "0x3442140", VA = "0x183443340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B3D0", Offset = "0x3B1A1D0", VA = "0x183B1B3D0")]
		public bool MBBLMHLLNHP(out TValue DFEOJBAFBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B320", Offset = "0x3B1A120", VA = "0x183B1B320")]
		public void HMNAIPBHJIK(object KCCFEDJJGAN, TValue DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B1F0", Offset = "0x3B19FF0", VA = "0x183B1B1F0")]
		public bool FAHLDBEBGON(object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B270", Offset = "0x3B1A070", VA = "0x183B1B270")]
		public int FIGLOCELEJH(object KCCFEDJJGAN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B490", Offset = "0x3B1A290", VA = "0x183B1B490")]
		public HKIAKFGOLLC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<HKIAKFGOLLC> NIEHJLCAJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::AOPGFFKJFJG<HMIKLFBELAH, HKIAKFGOLLC> JOFMEFMEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager MKHPDCKNNBB;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4456770", Offset = "0x4455570", VA = "0x184456770")]
	public LIFNMLFFFJC(EntityManager MKHPDCKNNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4456150", Offset = "0x4454F50", VA = "0x184456150", Slot = "4")]
	public void CCDNHHDJMDL(Entity IEFFOCOBJJI, object KCCFEDJJGAN, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x44563F0", Offset = "0x44551F0", VA = "0x1844563F0", Slot = "5")]
	public bool KPKDACOAPCG(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x44565E0", Offset = "0x44553E0", VA = "0x1844565E0", Slot = "6")]
	public bool MBBLMHLLNHP(Entity IEFFOCOBJJI, out TValue DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4456320", Offset = "0x4455120", VA = "0x184456320", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4456560", Offset = "0x4455360", VA = "0x184456560")]
	private void LJJPDHMOMCE(HKIAKFGOLLC HLIGBNPNBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4456270", Offset = "0x4455070", VA = "0x184456270")]
	private bool DFIIPBPONKC(Entity IEFFOCOBJJI, out HMIKLFBELAH DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4456360", Offset = "0x4455160", VA = "0x184456360")]
	private void JAHJBFLMNLA(Entity IEFFOCOBJJI, HMIKLFBELAH DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4456340", Offset = "0x4455140", VA = "0x184456340")]
	private bool ECAPHJDNKHE(HMIKLFBELAH DCLMHANFEGK, out HKIAKFGOLLC HLIGBNPNBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x44566B0", Offset = "0x44554B0", VA = "0x1844566B0")]
	private HKIAKFGOLLC PJDNPEIDGEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LHGPJLBEMAO<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCDNHHDJMDL(Entity IEFFOCOBJJI, object KCCFEDJJGAN, TValue DFEOJBAFBHE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KPKDACOAPCG(Entity IEFFOCOBJJI, object KCCFEDJJGAN);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MBBLMHLLNHP(Entity IEFFOCOBJJI, out TValue DFEOJBAFBHE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HMIKLFBELAH : global::GAMKFLDBKPP<HMIKLFBELAH>, BCAIPGNNKGO, IEquatable<HMIKLFBELAH>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly HMIKLFBELAH KKELJKMFEKL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int EBAKNIMBLHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x91D790", Offset = "0x91C590", VA = "0x18091D790", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x91EFB0", Offset = "0x91DDB0", VA = "0x18091EFB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int DKBOPEOPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9FD200", Offset = "0x9FC000", VA = "0x1809FD200", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9FD210", Offset = "0x9FC010", VA = "0x1809FD210", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA970", Offset = "0x5AA9770", VA = "0x185AAA970", Slot = "8")]
	public bool Equals(HMIKLFBELAH KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA9C0", Offset = "0x5AA97C0", VA = "0x185AAA9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JAGLGPBNCCL<T> : KGEAMOGNOJJ, IDisposable where T : struct, ADNHFABDAIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> NIEHJLCAJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::AOPGFFKJFJG<HMIKLFBELAH, HashSet<object>> JOFMEFMEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager MKHPDCKNNBB;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x40E9EC0", Offset = "0x40E8CC0", VA = "0x1840E9EC0")]
	public JAGLGPBNCCL(EntityManager MKHPDCKNNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x40E6F50", Offset = "0x40E5D50", VA = "0x1840E6F50", Slot = "4")]
	public bool CCDNHHDJMDL(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x40E8C90", Offset = "0x40E7A90", VA = "0x1840E8C90", Slot = "5")]
	public bool KPKDACOAPCG(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x40E94A0", Offset = "0x40E82A0", VA = "0x1840E94A0", Slot = "6")]
	public bool MMFCMIFFGPD(Entity IEFFOCOBJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x40E9400", Offset = "0x40E8200", VA = "0x1840E9400", Slot = "7")]
	public bool MMFCMIFFGPD(HMIKLFBELAH DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x40E8300", Offset = "0x40E7100", VA = "0x1840E8300", Slot = "8")]
	public IEnumerable<object> HPNCIPNDFOB(Entity IEFFOCOBJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x40E81C0", Offset = "0x40E6FC0", VA = "0x1840E81C0", Slot = "11")]
	public IEnumerable<object> HPNCIPNDFOB(HMIKLFBELAH DCLMHANFEGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x40E8690", Offset = "0x40E7490", VA = "0x1840E8690", Slot = "9")]
	public bool IKFKBILPLPP(Entity IEFFOCOBJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x40E77D0", Offset = "0x40E65D0", VA = "0x1840E77D0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x40E91D0", Offset = "0x40E7FD0", VA = "0x1840E91D0")]
	private void LJJPDHMOMCE(HashSet<object> HLIGBNPNBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x40E71D0", Offset = "0x40E5FD0", VA = "0x1840E71D0")]
	private bool DFIIPBPONKC(Entity IEFFOCOBJJI, out HMIKLFBELAH DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40E7920", Offset = "0x40E6720", VA = "0x1840E7920")]
	private bool ENBGGFJNHJG(Entity IEFFOCOBJJI, out HMIKLFBELAH DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x40E7810", Offset = "0x40E6610", VA = "0x1840E7810")]
	private void EBGLOKLBDMC(Entity IEFFOCOBJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x40E8AB0", Offset = "0x40E78B0", VA = "0x1840E8AB0")]
	private void JAHJBFLMNLA(Entity IEFFOCOBJJI, HMIKLFBELAH DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x40E75B0", Offset = "0x40E63B0", VA = "0x1840E75B0")]
	private bool DPAOIAMHEBB(HMIKLFBELAH DCLMHANFEGK, out HashSet<object> HLIGBNPNBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x40E9980", Offset = "0x40E8780", VA = "0x1840E9980")]
	private HashSet<object> PJDNPEIDGEP()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ILEMGPNEOAB : global::NAPGCIEFEOB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5AAAAC0", Offset = "0x5AA98C0", VA = "0x185AAAAC0", Slot = "4")]
	public float PJMFIPBGOJA(float3 DFEOJBAFBHE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NOGDEPALEGL : global::NAPGCIEFEOB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB7E0", Offset = "0x5AAA5E0", VA = "0x185AAB7E0", Slot = "4")]
	public float PJMFIPBGOJA(float3 DFEOJBAFBHE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KJDABPGHLMJ : global::NAPGCIEFEOB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB350", Offset = "0x5AAA150", VA = "0x185AAB350", Slot = "4")]
	public float PJMFIPBGOJA(float3 DFEOJBAFBHE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct POJNPBFKNNA : global::NAPGCIEFEOB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x78FE20", Offset = "0x78EC20", VA = "0x18078FE20", Slot = "4")]
	public int PJMFIPBGOJA(int3 DFEOJBAFBHE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LKKLHLJOIEH : global::NAPGCIEFEOB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x14E6760", Offset = "0x14E5560", VA = "0x1814E6760", Slot = "4")]
	public int PJMFIPBGOJA(int3 DFEOJBAFBHE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GNHHNNLNKIM : global::NAPGCIEFEOB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA910", Offset = "0x5AA9710", VA = "0x185AAA910", Slot = "4")]
	public int PJMFIPBGOJA(int3 DFEOJBAFBHE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class BLMNNMGEPDH : DPKIKFFCGDF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type JALHAAEFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B2150", Offset = "0x6B0F50", VA = "0x1806B2150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2273F70", Offset = "0x2272D70", VA = "0x182273F70")]
	public BLMNNMGEPDH(Type AAGKLIPKMMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ILPFPDPNEBP : BLMNNMGEPDH
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2273F70", Offset = "0x2272D70", VA = "0x182273F70")]
	public ILPFPDPNEBP(Type AAGKLIPKMMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HHELEBCMGBG : BLMNNMGEPDH
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type HMBGNEFKOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7337A0", Offset = "0x7325A0", VA = "0x1807337A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA920", Offset = "0x5AA9720", VA = "0x185AAA920")]
	public HHELEBCMGBG(Type AIFMIOKONLH, Type AAGKLIPKMMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CNPLGNFBEPP : BLMNNMGEPDH
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2273F70", Offset = "0x2272D70", VA = "0x182273F70")]
	public CNPLGNFBEPP(Type AAGKLIPKMMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BLFKHCHIGFF : DPKIKFFCGDF
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public BLFKHCHIGFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GAMJJBEBIEK : DPKIKFFCGDF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LFELPHGLBIM KNDCODGLMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7332F0", Offset = "0x7320F0", VA = "0x1807332F0")]
		[CompilerGenerated]
		get
		{
			return default(LFELPHGLBIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2273D70", Offset = "0x2272B70", VA = "0x182273D70")]
	public GAMJJBEBIEK(LFELPHGLBIM DNPJACNCEDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class CGJFLAGLGMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly AHBEEJODFBD GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager MKHPDCKNNBB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AHBEEJODFBD MECEOFMEJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5AA98A0", Offset = "0x5AA86A0", VA = "0x185AA98A0")]
	public CGJFLAGLGMG(AHBEEJODFBD GLPDAIBKGJO, EntityManager MKHPDCKNNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x37A25E0", Offset = "0x37A13E0", VA = "0x1837A25E0")]
	public bool NHOAACKGCKM<T>(Entity IEFFOCOBJJI) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x37A0370", Offset = "0x379F170", VA = "0x1837A0370")]
	public bool AEDILPALBPG<T>(Entity IEFFOCOBJJI, out T DFEOJBAFBHE) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x37A0400", Offset = "0x379F200", VA = "0x1837A0400")]
	public T EMKPGFDPCID<T>(Entity IEFFOCOBJJI) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x37A1DE0", Offset = "0x37A0BE0", VA = "0x1837A1DE0")]
	private ComponentType NDADIIAEKKP<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5AA97D0", Offset = "0x5AA85D0", VA = "0x185AA97D0")]
	private ComponentType NDADIIAEKKP(Type IGEIBCJNCHF)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class MAAAHNNGDPO
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	protected MAAAHNNGDPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class PFLHINGOIIF<View, Data> : PGIKEAFDIOH where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType LBOGJMNEAKF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type MDFGGBFMAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4656CB0", Offset = "0x4655AB0", VA = "0x184656CB0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type JLJKAKGEBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x46581F0", Offset = "0x4656FF0", VA = "0x1846581F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int JDBGPHIFEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4656160", Offset = "0x4654F60", VA = "0x184656160", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4657310", Offset = "0x4656110", VA = "0x184657310")]
	public Data EGFJMGIIOMF(Entity IEFFOCOBJJI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4656220", Offset = "0x4655020", VA = "0x184656220")]
	public Data CCNGJMJMNMP(Entity IEFFOCOBJJI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View OLNKNOPMCHH(Entity IEFFOCOBJJI);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4C7C2C0", Offset = "0x4C7B0C0", VA = "0x184C7C2C0", Slot = "15")]
	protected internal override T OLNKNOPMCHH<T>(Entity IEFFOCOBJJI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF790", Offset = "0x2CDE590", VA = "0x182CDF790")]
	protected PFLHINGOIIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class PGIKEAFDIOH : KANENNLDGEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic OHHGJADLADP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager KEPLCDNBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0C0", Offset = "0x7A9EC0", VA = "0x1807AB0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type MDFGGBFMAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type JLJKAKGEBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int JDBGPHIFEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type LEPNBIFAGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xFE5380", Offset = "0xFE4180", VA = "0x180FE5380", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int JGKBMJHLHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5AACBA0", Offset = "0x5AAB9A0", VA = "0x185AACBA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private ONEPLGLDGPM[] BCIMBEFBCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xFE52B0", Offset = "0xFE40B0", VA = "0x180FE52B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual ONEPLGLDGPM[] ILODDHJBLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5AACAE0", Offset = "0x5AAB8E0", VA = "0x185AACAE0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EOKAGOLFOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC900", Offset = "0x5AAB700", VA = "0x185AAC900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC930", Offset = "0x5AAB730", VA = "0x185AAC930")]
	public void NAGCBALDEME(EntityManager MKHPDCKNNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x86FF90", Offset = "0x86ED90", VA = "0x18086FF90")]
	protected KANENNLDGEA ICHMDEIGEKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T OLNKNOPMCHH<T>(Entity IEFFOCOBJJI) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5AACC10", Offset = "0x5AABA10", VA = "0x185AACC10", Slot = "8")]
	public (uint, uint) PMAEJCKEABM(Entity IEFFOCOBJJI)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5AACA50", Offset = "0x5AAB850", VA = "0x185AACA50", Slot = "9")]
	public bool NNBHJPBHOAE(Entity IEFFOCOBJJI, (uint order, uint change) IIJDDKBOPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	protected PGIKEAFDIOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class HHKAFOKLEHG<Data> : CBDMAFGMIBG where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data DCLACCPOJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3B13480", Offset = "0x3B12280", VA = "0x183B13480", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x75AD70", Offset = "0x759B70", VA = "0x18075AD70", Slot = "8")]
	protected virtual bool GLCFABJPCDC(ReadOnlySpan<Data> FKFMFNKJNOH, LDGDBBFAFNK NEHLAILGLJO, out ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00", Slot = "9")]
	protected virtual bool EHOJBANGFCF(int IIJDDKBOPLN, Span<Data> FKFMFNKJNOH, in ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3B13530", Offset = "0x3B12330", VA = "0x183B13530", Slot = "5")]
	internal sealed override bool GLCFABJPCDC(ref Unity.Entities.Chunk LDGNGMADGKK, int NIKJDHGOLFL, LDGDBBFAFNK NEHLAILGLJO, out ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B12160", Offset = "0x3B10F60", VA = "0x183B12160", Slot = "6")]
	internal sealed override bool EHOJBANGFCF(int IIJDDKBOPLN, ref Unity.Entities.Chunk LDGNGMADGKK, int NIKJDHGOLFL, in ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2F64E60", Offset = "0x2F63C60", VA = "0x182F64E60")]
	protected global::MDCAJNGFNFL<Protobuf> CBKFCDHDFOC<Protobuf>(ReadOnlySpan<Data> FKFMFNKJNOH) where Protobuf : IMessage, new()
	{
		return default(global::MDCAJNGFNFL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2F64EB0", Offset = "0x2F63CB0", VA = "0x182F64EB0")]
	protected global::LJLPAFFKOGM<Protobuf> FHFIIKEGAFF<Protobuf>(ReadOnlySpan<byte> GEGIPEOHNBF, ReadOnlySpan<Data> FKFMFNKJNOH, Action<Protobuf> FFICHOMLEMH) where Protobuf : IMessage, new()
	{
		return default(global::LJLPAFFKOGM<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF790", Offset = "0x2CDE590", VA = "0x182CDF790")]
	protected HHKAFOKLEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class CBDMAFGMIBG
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int DKBOPEOPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5AA97B0", Offset = "0x5AA85B0", VA = "0x185AA97B0", Slot = "5")]
	internal virtual bool GLCFABJPCDC(ref Unity.Entities.Chunk LDGNGMADGKK, int NIKJDHGOLFL, LDGDBBFAFNK NEHLAILGLJO, out ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00", Slot = "6")]
	internal virtual bool EHOJBANGFCF(int IIJDDKBOPLN, ref Unity.Entities.Chunk LDGNGMADGKK, int NIKJDHGOLFL, in ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	protected CBDMAFGMIBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NAPGCIEFEOB<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo PJMFIPBGOJA(TFrom DFEOJBAFBHE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface JODPMOJLJEB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FKHEBADIFPK(T DFEOJBAFBHE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct LJENJDGMKBK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::NAPGCIEFEOB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> GKCKKOPKKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> DJABHCMDJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap KNOLDLABLMF;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct NDDNDNKNHKL<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::NAPGCIEFEOB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> AGGBDMPACAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> DJABHCMDJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap KNOLDLABLMF;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct AFHBFMNGJAO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LMKHAKHFJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> GKCKKOPKKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> DJABHCMDJML;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3FEA520", Offset = "0x3FE9320", VA = "0x183FEA520", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct BAEHPIOJCKF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LMKHAKHFJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> GKCKKOPKKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> BJIAPIHEEIN;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct BNFIPEINMNM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::NAPGCIEFEOB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> HNGGIGIEIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> DJABHCMDJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap KNOLDLABLMF;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct DHKAEFPBGMG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AAGKLIPKMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> PNFNAEBJOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> FNBMOBIFEGM;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct PCIIBAFEGAI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AAGKLIPKMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> PNFNAEBJOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> FNBMOBIFEGM;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x41E8450", Offset = "0x41E7250", VA = "0x1841E8450", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct HKIDFHPGCGA<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> GKCKKOPKKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> BJIAPIHEEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, PEFLLNEDEOA> IEOJBDIPJCJ;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3B1B510", Offset = "0x3B1A310", VA = "0x183B1B510", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct JIKAPLBKHMK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::NAPGCIEFEOB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> GKCKKOPKKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> BJIAPIHEEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, PEFLLNEDEOA> IEOJBDIPJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap KNOLDLABLMF;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct JNOMKBLJGPF<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::JODPMOJLJEB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> GKCKKOPKKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> BJIAPIHEEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate KNOLDLABLMF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct MFCGMGLFCJO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity AAGKLIPKMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> PNFNAEBJOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> LKHJOJCENFJ;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB6E0", Offset = "0x5AAA4E0", VA = "0x185AAB6E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct GHJELCJDGPB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity AAGKLIPKMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> PNFNAEBJOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> LKHJOJCENFJ;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA880", Offset = "0x5AA9680", VA = "0x185AAA880", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IOFDIFECDKH
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class OAEBMKFJJHO
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x469F190", Offset = "0x469DF90", VA = "0x18469F190")]
	public static bool BACLGINNGAL<T>(this NativeArray<Entity> PNFNAEBJOEK, EntityManager MKHPDCKNNBB, Allocator AEPJLHDIHPH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class HPMKOGAOEHA
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MAOHJIJLJPH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public MAOHJIJLJPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class LLKOLICKCEF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public LLKOLICKCEF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> JPHJGMABBJO;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5AAAA40", Offset = "0x5AA9840", VA = "0x185AAAA40")]
	public HPMKOGAOEHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HMNHLGDOHPO
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JHLDIDLMPGF
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct AGCCJPOHFOJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct EAKCPCDMEBM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal AGCCJPOHFOJ<TFrom> ICMEPOIJCJO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> PPLEFHADAKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct ODHLHDJBNJL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct DMBALNFIGKP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal ODHLHDJBNJL<TFrom> ICMEPOIJCJO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> PPLEFHADAKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct HPNGDBLOIEL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct ALGIKEPOEHM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal HPNGDBLOIEL<TFrom> ICMEPOIJCJO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> PPLEFHADAKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct CEPEEMKIMAM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct CHIFDEJJJFF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal CEPEEMKIMAM<TFrom> ICMEPOIJCJO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> PPLEFHADAKM;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class BBDIEEFDOKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class BLJAKMOJIDC
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x37991A0", Offset = "0x3797FA0", VA = "0x1837991A0")]
	public static NativeList<T> FABOAAKDEAI<T>(this NativeArray<T> ONGKEBNKDIN, Allocator AEPJLHDIHPH = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class GNIJKKPLNHP
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3A277A0", Offset = "0x3A265A0", VA = "0x183A277A0")]
	public static NativeArray<T> MNJOFNKPBBC<T>(this NativeList<Entity> ONGKEBNKDIN, EntityManager MKHPDCKNNBB, Allocator AEPJLHDIHPH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3A275A0", Offset = "0x3A263A0", VA = "0x183A275A0")]
	public static NativeArray<T> MNJOFNKPBBC<T>(this NativeArray<Entity> ONGKEBNKDIN, EntityManager MKHPDCKNNBB, Allocator AEPJLHDIHPH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class PMLMMKPJJBF
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct BLDJDHHGIDA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct PMBDCJGEAFB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public BLDJDHHGIDA<TFrom> PPLEFHADAKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> GKCKKOPKKIH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct IACDFNFANBC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct FCJFKPLDBKD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public IACDFNFANBC<TFrom> PPLEFHADAKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> GKCKKOPKKIH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct MJIKGJMAANK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct PAMCGEPKILE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public MJIKGJMAANK<TFrom> PPLEFHADAKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> GKCKKOPKKIH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FELABMIHKFB
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class AKGBIPPDIMD
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct HBHMOHKCJBJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> GKCKKOPKKIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct PJDKDBJNOOF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> GKCKKOPKKIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct LEHHPBBJNKO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> GKCKKOPKKIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct MGLAGNFEHBP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> GKCKKOPKKIH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class EFKKHJLILPP
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class CAOHMDMEJEA
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x379F990", Offset = "0x379E790", VA = "0x18379F990")]
	public static NativeList<Entity> HNKMBFABBLP<T>(this NativeArray<Entity> PNFNAEBJOEK, EntityManager MKHPDCKNNBB, Allocator AEPJLHDIHPH = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class OLHPAADAOIJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface NEAOMDHOEFC
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JKAOKLJHAJK
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class DOAEDFEDIKP
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DLGDJIKJNJP
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5AA9EF0", Offset = "0x5AA8CF0", VA = "0x185AA9EF0")]
	public static bool EOJJIBLENNI(Type IGEIBCJNCHF, Type BNEMKMLIIBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class DINPMFJKIMA<Attribute, BaseClass> : global::NIKBJEOPDLO<BaseClass>, JMNDOGGEHBE where Attribute : BLMNNMGEPDH
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly FBNJDMKEPCN KKLHLPEDHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string IADPDEAGFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> OJEPGCDOOOH;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3AB27D0", Offset = "0x3AB15D0", VA = "0x183AB27D0")]
	public DINPMFJKIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2550", Offset = "0x3AB1350", VA = "0x183AB2550", Slot = "4")]
	public bool HGEFFBLNLHD(int CNNKHGOHIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3AB22A0", Offset = "0x3AB10A0", VA = "0x183AB22A0", Slot = "5")]
	public global::BOONDFDEOBC<BaseClass> GDEMGPNGCHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3AB21A0", Offset = "0x3AB0FA0", VA = "0x183AB21A0", Slot = "7")]
	protected virtual bool EOJJIBLENNI(Type IGEIBCJNCHF, int CENMOHBFEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3AB25B0", Offset = "0x3AB13B0", VA = "0x183AB25B0", Slot = "8")]
	protected virtual int HLOHCPOHJGD(Type IGEIBCJNCHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2640", Offset = "0x3AB1440", VA = "0x183AB2640")]
	public void JJOFCNGHIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3AB26D0", Offset = "0x3AB14D0", VA = "0x183AB26D0", Slot = "6")]
	public void MNFGPLMIANE(Type IGEIBCJNCHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BOONDFDEOBC<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> PMCGALCIOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> IOFKIEAPBID;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> DGNLPPPJGJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x48A4BE0", Offset = "0x48A39E0", VA = "0x1848A4BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x48A5100", Offset = "0x48A3F00", VA = "0x1848A5100")]
	public BOONDFDEOBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x48A4F60", Offset = "0x48A3D60", VA = "0x1848A4F60")]
	public BOONDFDEOBC(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x48A4E10", Offset = "0x48A3C10", VA = "0x1848A4E10")]
	internal void HMNAIPBHJIK(int CNNKHGOHIDH, BaseClass LHAACBBCHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2F5D830", Offset = "0x2F5C630", VA = "0x182F5D830")]
	public bool KGFLIOPKLPH<T>(out BaseClass DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x48A4E90", Offset = "0x48A3C90", VA = "0x1848A4E90")]
	public bool KGFLIOPKLPH(Type OMMPBBANJJE, out BaseClass DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x42A9180", Offset = "0x42A7F80", VA = "0x1842A9180")]
	public bool BMHMBPBFCHN(int CNNKHGOHIDH, out BaseClass DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E540", Offset = "0x2F5D340", VA = "0x182F5E540")]
	public T NFCNICJMGHA<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x48A4F30", Offset = "0x48A3D30", VA = "0x1848A4F30")]
	public BaseClass NFCNICJMGHA(Type LOPGHOAOIIJ)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class NLEIAGJBLJM : global::DINPMFJKIMA<ILPFPDPNEBP, MAAAHNNGDPO>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB770", Offset = "0x5AAA570", VA = "0x185AAB770")]
	public NLEIAGJBLJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class KEKMCBHLKOG : global::DINPMFJKIMA<HHELEBCMGBG, PGIKEAFDIOH>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB2E0", Offset = "0x5AAA0E0", VA = "0x185AAB2E0")]
	public KEKMCBHLKOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class KJHNHOCGCNA : global::DINPMFJKIMA<CNPLGNFBEPP, CBDMAFGMIBG>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB370", Offset = "0x5AAA170", VA = "0x185AAB370")]
	public KJHNHOCGCNA()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[LMNMHFHDONH(IPKPBIMLPOB.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> ELKKGBGGKPO;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DE0", Offset = "0x6AFBE0", VA = "0x1806B0DE0")]
		private ComponentSystemTypes(List<Type> ELKKGBGGKPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9BD0", Offset = "0x5AA89D0", VA = "0x185AA9BD0")]
		public static void JJOFCNGHIKE(List<Type> ELKKGBGGKPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9C60", Offset = "0x5AA8A60", VA = "0x185AA9C60")]
		private void LLCMBFPMJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9AF0", Offset = "0x5AA88F0", VA = "0x185AA9AF0")]
		private bool EOJJIBLENNI(Type IGEIBCJNCHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5AA9B70", Offset = "0x5AA8970", VA = "0x185AA9B70")]
		private void FLIHGLDNEMP(Type IGEIBCJNCHF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class DLPLBLIFJLF : PAOJLIIMPCN
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA120", Offset = "0x5AA8F20", VA = "0x185AAA120", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase OENKBFADAEF();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA0D0", Offset = "0x5AA8ED0", VA = "0x185AAA0D0")]
	protected ComponentSystemBase KCHLGHPOBCA(params ComponentSystemBase[] GNCNHHEOEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3D04F00", Offset = "0x3D03D00", VA = "0x183D04F00")]
	protected ComponentSystemBase KCHLGHPOBCA<T>(params ComponentSystemBase[] GNCNHHEOEMG) where T : PAOJLIIMPCN, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3D04EC0", Offset = "0x3D03CC0", VA = "0x183D04EC0")]
	protected ComponentSystemBase CNIDCJAGEIL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3D04EC0", Offset = "0x3D03CC0", VA = "0x183D04EC0")]
	protected ComponentSystemBase NGNNIACNHML<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	protected DLPLBLIFJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface NIKBJEOPDLO<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HGEFFBLNLHD(int CNNKHGOHIDH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BOONDFDEOBC<BaseClass> GDEMGPNGCHF();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class PAOJLIIMPCN : CKEIFNPCMDD
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC070", Offset = "0x5AAAE70", VA = "0x185AAC070", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public PAOJLIIMPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class GAJBCDLDAEF : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA740", Offset = "0x5AA9540", VA = "0x185AAA740")]
	public ComponentDataFromEntity JPKLDMKIDKM(int CNNKHGOHIDH, bool FJBBIADFENA = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA7E0", Offset = "0x5AA95E0", VA = "0x185AAA7E0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0xC6A1E0", Offset = "0xC68FE0", VA = "0x180C6A1E0")]
	protected GAJBCDLDAEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class EIFFBCEFCLG : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xC6A1E0", Offset = "0xC68FE0", VA = "0x180C6A1E0")]
	protected EIFFBCEFCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class HNBBKDMFLBC : GAJBCDLDAEF
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5AAAA10", Offset = "0x5AA9810", VA = "0x185AAAA10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	protected void NIBCFDKIMOM(string BDICMGNPCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xC6A1E0", Offset = "0xC68FE0", VA = "0x180C6A1E0")]
	protected HNBBKDMFLBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class MGBCMMGGCNO
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class CKEIFNPCMDD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	protected CKEIFNPCMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[LMNMHFHDONH(IPKPBIMLPOB.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5AAD570", Offset = "0x5AAC370", VA = "0x185AAD570")]
		public static ComponentSystemGroup[] BGMBBEENKKB(World GLPDAIBKGJO, DJOCFFCOADN OKGGGEBIMAO = DJOCFFCOADN.Default, bool MPOCNFLGCIF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5AADC20", Offset = "0x5AACA20", VA = "0x185AADC20")]
		private static Type[] KCOGEMCJDOH(DJOCFFCOADN OKGGGEBIMAO, bool MPOCNFLGCIF, ComponentSystemGroup[] ANPKCHGPLIC, ComponentSystemGroup GBACFGPNNLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5AAD780", Offset = "0x5AAC580", VA = "0x185AAD780")]
		private static ComponentSystemGroup[] GJJIHKDAGMO(World GLPDAIBKGJO, out ComponentSystemGroup GBACFGPNNLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5AADF80", Offset = "0x5AACD80", VA = "0x185AADF80")]
		internal static bool MEHEABHKOFH(LFELPHGLBIM DNPJACNCEDM, out BKDOMKKCDOJ KNAMBEEGCIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5AAD640", Offset = "0x5AAC440", VA = "0x185AAD640")]
		private static ComponentSystemGroup CGAGCJBGNDC(Type IGEIBCJNCHF, World GLPDAIBKGJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5AADA90", Offset = "0x5AAC890", VA = "0x185AADA90")]
		private static ComponentSystemGroup[] IIDPDOKBBEI(Type[] ELKKGBGGKPO, World GLPDAIBKGJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5AAD050", Offset = "0x5AABE50", VA = "0x185AAD050")]
		internal static void APMCKFIBJKA(World GLPDAIBKGJO, Type[] DFBPANLIOFF, ComponentSystemGroup[] ANPKCHGPLIC, ComponentSystemGroup GBACFGPNNLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5AADBC0", Offset = "0x5AAC9C0", VA = "0x185AADBC0")]
		internal static bool JNMINHECNAO(ComponentSystemBase KFLDFPCKAGO, ComponentSystemGroup[] ANPKCHGPLIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AAD720", Offset = "0x5AAC520", VA = "0x185AAD720")]
		private static void CKHKCDNOHMM(ComponentSystemGroup[] ANPKCHGPLIC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct NEDBOLCHHNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> IGEGENPKKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> GNCNHHEOEMG;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xDAC5C0", Offset = "0xDAB3C0", VA = "0x180DAC5C0")]
	public NEDBOLCHHNN(Dictionary<Type, List<Type>> IGEGENPKKBC, HashSet<Type> GNCNHHEOEMG)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[LMNMHFHDONH(IPKPBIMLPOB.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class PLBLKANBODG : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x973950", Offset = "0x972750", VA = "0x180973950")]
			[DebuggerHidden]
			public PLBLKANBODG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5AACF70", Offset = "0x5AABD70", VA = "0x185AACF70", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5AACCD0", Offset = "0x5AABAD0", VA = "0x185AACCD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5AAD000", Offset = "0x5AABE00", VA = "0x185AAD000")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5AACF30", Offset = "0x5AABD30", VA = "0x185AACF30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5AACE80", Offset = "0x5AABC80", VA = "0x185AACE80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5AACE80", Offset = "0x5AABC80", VA = "0x185AACE80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct GDJMPGNJEKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type JGGMINKDHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private DJOCFFCOADN OKGGGEBIMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool GGBGOACPIMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool AAPLKFKFLDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool MPOCNFLGCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> HKHPPAFINGD;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5AAE4E0", Offset = "0x5AAD2E0", VA = "0x185AAE4E0")]
		public static RRFilterWorldSystems HJNGNBALKKN()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF0A0", Offset = "0x5AADEA0", VA = "0x185AAF0A0")]
		public RRFilterWorldSystems MPIADOAJDAO(DJOCFFCOADN DNPJACNCEDM)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF0B0", Offset = "0x5AADEB0", VA = "0x185AAF0B0")]
		public RRFilterWorldSystems OFKPJFIBLEJ(IEnumerable<Type> ELKKGBGGKPO)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5AAEC50", Offset = "0x5AADA50", VA = "0x185AAEC50")]
		public RRFilterWorldSystems JIPALONCGJB(bool CMGNCBMMLMB)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF0F0", Offset = "0x5AADEF0", VA = "0x185AAF0F0")]
		public RRFilterWorldSystems ONNDAMDAFHH(bool FPOFPFJLJFC)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF100", Offset = "0x5AADF00", VA = "0x185AAF100")]
		public NEDBOLCHHNN PPIGENGHNME(Type[] EBNDGIHJDLH)
		{
			return default(NEDBOLCHHNN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5AAE450", Offset = "0x5AAD250", VA = "0x185AAE450")]
		[IteratorStateMachine(typeof(PLBLKANBODG))]
		internal IEnumerable<Type> FPLKJAPIHCH(IEnumerable<Type> ELKKGBGGKPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5AAEDC0", Offset = "0x5AADBC0", VA = "0x185AAEDC0")]
		internal Dictionary<Type, List<Type>> KIIGPAOGDOM(IEnumerable<Type> ELKKGBGGKPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5AAEB40", Offset = "0x5AAD940", VA = "0x185AAEB40")]
		private void IILOHMKLEHC(Dictionary<Type, List<Type>> MIHJGHDPEEA, Type IGEIBCJNCHF, Type GLCHNOFKLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5AAE290", Offset = "0x5AAD090", VA = "0x185AAE290")]
		internal HashSet<Type> CFPAHCEKJNC(IEnumerable<Type> ANPKCHGPLIC, Dictionary<Type, List<Type>> LLHCHDMLAEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5AAE500", Offset = "0x5AAD300", VA = "0x185AAE500")]
		internal bool HMCFFKKHLAJ(Type IGEIBCJNCHF, DJOCFFCOADN OKGGGEBIMAO, bool MPOCNFLGCIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5AAEC60", Offset = "0x5AADA60", VA = "0x185AAEC60")]
		[CompilerGenerated]
		internal static void KDKHLOGMOPI(Type IGEIBCJNCHF, ref GDJMPGNJEKO P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class FLPDJKONBHF
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool HGHOOJICMNB;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA6E0", Offset = "0x5AA94E0", VA = "0x185AAA6E0")]
	public static void NAGCBALDEME(bool PAKHNBOHLFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA520", Offset = "0x5AA9320", VA = "0x185AAA520")]
	private static void ACOLCLNJHLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class BCNEMLAPGCF
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5AA96C0", Offset = "0x5AA84C0", VA = "0x185AA96C0")]
	public static ulong AFNNBPHKGAA(Type IGEIBCJNCHF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5AA96F0", Offset = "0x5AA84F0", VA = "0x185AA96F0")]
	public static ulong AFNNBPHKGAA(string HDJJFFIBBNJ)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[LMNMHFHDONH(IPKPBIMLPOB.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct GCKHIIMBHDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong MOEINDJENLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong GFHLLAPIEAG;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xDBE590", Offset = "0xDBD390", VA = "0x180DBE590")]
			public GCKHIIMBHDI(ulong FJJFFHMGFAL, ulong MDLBNCFOFDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5AAA7F0", Offset = "0x5AA95F0", VA = "0x185AAA7F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> BEGDEGNEFJH;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static GCKHIIMBHDI[] EMGMBLDHJKE;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool HGHOOJICMNB;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5AAFEF0", Offset = "0x5AAECF0", VA = "0x185AAFEF0")]
		public static ulong OKFECKLLABO(int CNNKHGOHIDH)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5AAFA70", Offset = "0x5AAE870", VA = "0x185AAFA70")]
		public static int DPGFPFKDPIB(ulong MDLBNCFOFDI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5AAFC70", Offset = "0x5AAEA70", VA = "0x185AAFC70")]
		public static void NAGCBALDEME(bool PAKHNBOHLFK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF560", Offset = "0x5AAE360", VA = "0x185AAF560")]
		private static void AKEPBEGGLJE(int CNIEHAHPHOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF750", Offset = "0x5AAE550", VA = "0x185AAF750")]
		private static void DGJMONBMJNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF480", Offset = "0x5AAE280", VA = "0x185AAF480")]
		private static GCKHIIMBHDI AEFPKHCEOFH(Type IGEIBCJNCHF)
		{
			return default(GCKHIIMBHDI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5AAFB20", Offset = "0x5AAE920", VA = "0x185AAFB20")]
		private static ulong FKHPHMEBLDI(Type IGEIBCJNCHF, ulong MDLBNCFOFDI)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF260", Offset = "0x5AAE060", VA = "0x185AAF260")]
		private static void AADKLAGAEDC(in GCKHIIMBHDI IHNPIFLOBIO, TypeManager.TypeInfo PMBEBMHHMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF640", Offset = "0x5AAE440", VA = "0x185AAF640")]
		private static void APPDIOILEEC(GCKHIIMBHDI PMBEBMHHMPM, int CNNKHGOHIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5AAFB90", Offset = "0x5AAE990", VA = "0x185AAFB90")]
		private static void HKPNBDCLCMC(GCKHIIMBHDI PMBEBMHHMPM, int CNNKHGOHIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5AAFE60", Offset = "0x5AAEC60", VA = "0x185AAFE60")]
		private static GCKHIIMBHDI NHPLJILLBKH(int CNNKHGOHIDH)
		{
			return default(GCKHIIMBHDI);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF740", Offset = "0x5AAE540", VA = "0x185AAF740")]
		private static int CIGFEDACOBI(int CNNKHGOHIDH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class ODCHIOCPCJD
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly KEKMCBHLKOG JKNNMJPPANC;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly KJHNHOCGCNA OMDCEIGHONB;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly NLEIAGJBLJM EHFEHCCHJCG;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> ALAEALIIMLM;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool HGHOOJICMNB;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::NIKBJEOPDLO<PGIKEAFDIOH> AIINFBCBPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5AAB7F0", Offset = "0x5AAA5F0", VA = "0x185AAB7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::NIKBJEOPDLO<CBDMAFGMIBG> IINCDJMOKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5AAB8D0", Offset = "0x5AAA6D0", VA = "0x185AAB8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::NIKBJEOPDLO<MAAAHNNGDPO> GIBKLNCIJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5AABDE0", Offset = "0x5AAABE0", VA = "0x185AABDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB930", Offset = "0x5AAA730", VA = "0x185AAB930")]
	public static void NAGCBALDEME(bool PAKHNBOHLFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB850", Offset = "0x5AAA650", VA = "0x185AAB850")]
	public static Type[] ELABNLHFDJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class JGMBJKEECBN
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> FCHNNIMCCCB;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool HGHOOJICMNB;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB1C0", Offset = "0x5AA9FC0", VA = "0x185AAB1C0")]
	public static int PMAEJCKEABM(int CNNKHGOHIDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5AAAEA0", Offset = "0x5AA9CA0", VA = "0x185AAAEA0")]
	public static void NAGCBALDEME(bool PAKHNBOHLFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5AAAF40", Offset = "0x5AA9D40", VA = "0x185AAAF40")]
	private static void NAMMKKIDOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5AAADD0", Offset = "0x5AA9BD0", VA = "0x185AAADD0")]
	private static int EFJNJOEOPGG(Type IGEIBCJNCHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5AAAE20", Offset = "0x5AA9C20", VA = "0x185AAAE20")]
	private static void EMOCNNJJBKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class AHBEEJODFBD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World KJHAPGELJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly CGJFLAGLGMG LHAACBBCHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] ANPKCHGPLIC;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World MECEOFMEJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World BGENOIKENDC
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager KEPLCDNBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x138A470", Offset = "0x1389270", VA = "0x18138A470")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CGJFLAGLGMG GBGKPEOJFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::BOONDFDEOBC<PGIKEAFDIOH> AIINFBCBPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x738030", Offset = "0x736E30", VA = "0x180738030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::BOONDFDEOBC<CBDMAFGMIBG> IINCDJMOKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6C07D0", Offset = "0x6BF5D0", VA = "0x1806C07D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x737900", Offset = "0x736700", VA = "0x180737900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::BOONDFDEOBC<MAAAHNNGDPO> GIBKLNCIJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x73C880", Offset = "0x73B680", VA = "0x18073C880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x73C1F0", Offset = "0x73AFF0", VA = "0x18073C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> JCLAJNCOHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x138A490", Offset = "0x1389290", VA = "0x18138A490")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] EBJOKCCEPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8C80", Offset = "0x5AA7A80", VA = "0x185AA8C80")]
	public static AHBEEJODFBD FIIKKBAJFPM(string IADPDEAGFAB, LFELPHGLBIM DNPJACNCEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8FA0", Offset = "0x5AA7DA0", VA = "0x185AA8FA0")]
	public AHBEEJODFBD(string IADPDEAGFAB, LFELPHGLBIM DNPJACNCEDM = LFELPHGLBIM.Simulation, DJOCFFCOADN OKGGGEBIMAO = DJOCFFCOADN.Default, bool PAKHNBOHLFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5AA88C0", Offset = "0x5AA76C0", VA = "0x185AA88C0")]
	public ComponentSystemBase CPCHBPHHPKH(Type IGEIBCJNCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x35FAF90", Offset = "0x35F9D90", VA = "0x1835FAF90")]
	public T CPCHBPHHPKH<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8E80", Offset = "0x5AA7C80", VA = "0x185AA8E80")]
	public void OFLJFKIPKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8E20", Offset = "0x5AA7C20", VA = "0x185AA8E20")]
	public void LCAIHBDCECF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8DC0", Offset = "0x5AA7BC0", VA = "0x185AA8DC0")]
	public void KCFCOLOKIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8560", Offset = "0x5AA7360", VA = "0x185AA8560")]
	public void ADPILCIAJEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8F40", Offset = "0x5AA7D40", VA = "0x185AA8F40")]
	public void OGJMHMGIGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5AA88E0", Offset = "0x5AA76E0", VA = "0x185AA88E0")]
	public void DLMOLMMLNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8D00", Offset = "0x5AA7B00", VA = "0x185AA8D00")]
	public void FOBMONNDEAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5AA85C0", Offset = "0x5AA73C0", VA = "0x185AA85C0")]
	public void BDNKGFPCEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8D60", Offset = "0x5AA7B60", VA = "0x185AA8D60")]
	public void IHODNNMJLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8EE0", Offset = "0x5AA7CE0", VA = "0x185AA8EE0")]
	public void OGEFIPAEEKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5AA87E0", Offset = "0x5AA75E0", VA = "0x185AA87E0")]
	internal void CMEAKHKIPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8760", Offset = "0x5AA7560", VA = "0x185AA8760")]
	private bool BNOABPADIMM(ComponentSystemGroup JOKFNNKABBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5AA89B0", Offset = "0x5AA77B0", VA = "0x185AA89B0")]
	private void FEMGEKLEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8650", Offset = "0x5AA7450", VA = "0x185AA8650")]
	private ComponentSystemGroup[] BGMBBEENKKB(DJOCFFCOADN OKGGGEBIMAO, bool MPOCNFLGCIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8940", Offset = "0x5AA7740", VA = "0x185AA8940", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum LFELPHGLBIM
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
public sealed class AKNKNKMHPHI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public DJOCFFCOADN CGKMNIPCKDH;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum DJOCFFCOADN
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
public interface BKDOMKKCDOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type PCPMHJMOFFI
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] PDBCIOGHAII
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class DAJBIMEDELB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool KJLNDPHJKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6B17F0", Offset = "0x6B05F0", VA = "0x1806B17F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	protected DAJBIMEDELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class NOJHNPFEEEK : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public NOJHNPFEEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class MKJABAMJHFG : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public MKJABAMJHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class CBMCNFGKKIE : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public CBMCNFGKKIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class GNLJPHBPHDD : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public GNLJPHBPHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class NFLLPDGJECH : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public NFLLPDGJECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class IEFOBDFNPEA : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public IEFOBDFNPEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class BIPCFAGHHOL : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public BIPCFAGHHOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class EMCPAACKFBP : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public EMCPAACKFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class MGLIHHFJPCA : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public MGLIHHFJPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class AGJALCIGKKG : AHKIEBBLMMB
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public AGJALCIGKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class EMNLGBGFAID : AHKIEBBLMMB
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public EMNLGBGFAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class GDGEEMHEIHE : AHKIEBBLMMB
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public GDGEEMHEIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class EJJAHMJHKIF : AHKIEBBLMMB
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public EJJAHMJHKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[HEOEGCBCCCD(KHFGEOAKOKD.Application)]
public class AHKIEBBLMMB : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool KJLNDPHJKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8550", Offset = "0x5AA7350", VA = "0x185AA8550")]
	public AHKIEBBLMMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class HFKGOIIGIAJ : DPKIKFFCGDF
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public HFKGOIIGIAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class CPAKEILGBEB
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void EEBCCDBGNKE<From, To>(From PPLEFHADAKM, ref To KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class EDDHPNIFIMD<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static EEBCCDBGNKE<From, To> NPJFBOKGGFJ;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public EDDHPNIFIMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5AA98F0", Offset = "0x5AA86F0", VA = "0x185AA98F0")]
	static CPAKEILGBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3982DB0", Offset = "0x3981BB0", VA = "0x183982DB0")]
	public static void ODPOHMGBFCJ<T>(EEBCCDBGNKE<T, T> PDOOFOCADKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3982C40", Offset = "0x3981A40", VA = "0x183982C40")]
	public static void ODPOHMGBFCJ<From, To>(EEBCCDBGNKE<From, To> PDOOFOCADKK, EEBCCDBGNKE<To, From> JCNMMNDBMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3982CD0", Offset = "0x3981AD0", VA = "0x183982CD0")]
	public static void ODPOHMGBFCJ<From, To>(EEBCCDBGNKE<From, To> NPJFBOKGGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x37AD720", Offset = "0x37AC520", VA = "0x1837AD720")]
	public static EEBCCDBGNKE<From, To> HBHHNEJDPJF<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x37B0FE0", Offset = "0x37AFDE0", VA = "0x1837B0FE0")]
	public static void HIJELFNCJBL<From, To>(From PPLEFHADAKM, ref To KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class LDGDBBFAFNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> PECHDIDCODG;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8EAB20", Offset = "0x8E9920", VA = "0x1808EAB20")]
	public LDGDBBFAFNK(NativeArray<EntityRemapUtility.EntityRemapInfo> PECHDIDCODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3E1EEC0", Offset = "0x3E1DCC0", VA = "0x183E1EEC0")]
	public Entity FCJOGJOJPII(Entity JFBGEPNCFEC)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class IPMIGCALIKI
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> HIPOIHIHJOM;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5AAABE0", Offset = "0x5AA99E0", VA = "0x185AAABE0")]
	public static bool FBOLGBJNPIJ(ulong NHBPPIHNEOH, uint IIJDDKBOPLN, out string IADPDEAGFAB)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[LMNMHFHDONH(IPKPBIMLPOB.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct INBAFFCDJNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int EBAKNIMBLHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int DKBOPEOPEBA;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8E87E0", Offset = "0x8E75E0", VA = "0x1808E87E0")]
			public INBAFFCDJNN(int NPDGHPHAKDK, int IIJDDKBOPLN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct FGMNFIHFJAM
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch DELOHPFEPEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long JKHPMALILOJ;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long FIHOJLMBNCJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x5AAA4C0", Offset = "0x5AA92C0", VA = "0x185AAA4C0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long MLLAOKHLMGM
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5AAA450", Offset = "0x5AA9250", VA = "0x185AAA450")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5AAA390", Offset = "0x5AA9190", VA = "0x185AAA390")]
			public static FGMNFIHFJAM DBEFHDBAOPI()
			{
				return default(FGMNFIHFJAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct AELLKNIPFPD : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct FDDOEMACDPC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* FCBBBPDAPJB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly BLKDOACIBKE.BBAKPJBAPBP.ELHEPFCCPBN HHJBIOEAPHP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly LDGDBBFAFNK NEHLAILGLJO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::BOONDFDEOBC<CBDMAFGMIBG> BMNJABIDNBC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int NIKJDHGOLFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int EHPHMOBJNOI;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x5AAA330", Offset = "0x5AA9130", VA = "0x185AAA330")]
				public unsafe FDDOEMACDPC(Unity.Entities.Archetype* FCBBBPDAPJB, BLKDOACIBKE.BBAKPJBAPBP.ELHEPFCCPBN HHJBIOEAPHP, LDGDBBFAFNK NEHLAILGLJO, global::BOONDFDEOBC<CBDMAFGMIBG> BMNJABIDNBC, int NIKJDHGOLFL, int EHPHMOBJNOI = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5AAA2E0", Offset = "0x5AA90E0", VA = "0x185AAA2E0")]
				public FDDOEMACDPC(in FDDOEMACDPC FILAKGLBGGA, int EHPHMOBJNOI)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly FDDOEMACDPC[] FKFMFNKJNOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] FABPGKJIHLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int GPPGBMINCCN;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5AA8410", Offset = "0x5AA7210", VA = "0x185AA8410")]
			public AELLKNIPFPD(FDDOEMACDPC[] FKFMFNKJNOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5AA8000", Offset = "0x5AA6E00", VA = "0x185AA8000", Slot = "4")]
			public void Invoke(int NPDGHPHAKDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5AA8060", Offset = "0x5AA6E60", VA = "0x185AA8060")]
			private void KLLDALDKDAE(in FDDOEMACDPC FILAKGLBGGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5AA7D30", Offset = "0x5AA6B30", VA = "0x185AA7D30")]
			private static void DGOPINBPHNO(in FDDOEMACDPC FILAKGLBGGA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class AINILPDEEOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public BLKDOACIBKE asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::BOONDFDEOBC<CBDMAFGMIBG> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public AINILPDEEOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5AA94C0", Offset = "0x5AA82C0", VA = "0x185AA94C0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class GKKIGPPEAAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public BLKDOACIBKE.BBAKPJBAPBP.ELHEPFCCPBN srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AINILPDEEOH CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public GKKIGPPEAAA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class INJLCCBFOAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public GKKIGPPEAAA CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public INJLCCBFOAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5AAAAD0", Offset = "0x5AA98D0", VA = "0x185AAAAD0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly FBNJDMKEPCN JMKJAKDNGGC;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly FBNJDMKEPCN GOJKHEJPMPP;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly FBNJDMKEPCN MNOBKDLBDNF;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly FBNJDMKEPCN GKKODJBFCAO;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool NOJIINFGMBD;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static BLKDOACIBKE.BBAKPJBAPBP.OOCGAJGLBHG KLBLLIGJDOI;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2750", Offset = "0x5AB1550", VA = "0x185AB2750")]
		private unsafe static bool ICIBLEHILDI(Unity.Entities.Archetype* FAAKDBHJKLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3010", Offset = "0x5AB1E10", VA = "0x185AB3010")]
		internal unsafe static Unity.Entities.Archetype*[] KBEPOIPIBIL(ref Unity.Entities.EntityComponentStore IGGABMEGPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5AB02F0", Offset = "0x5AAF0F0", VA = "0x185AB02F0")]
		public static void CCPOABEFOJK(AHBEEJODFBD GLPDAIBKGJO, out ByteString GEGIPEOHNBF, out NativeArray<EntityRemapUtility.EntityRemapInfo> NFLOAHPEMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2020", Offset = "0x5AB0E20", VA = "0x185AB2020")]
		internal static void HNLLOFGMABD(AHBEEJODFBD GLPDAIBKGJO, BLKDOACIBKE KPHIJHMJGGO, out NativeArray<EntityRemapUtility.EntityRemapInfo> NFLOAHPEMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1A60", Offset = "0x5AB0860", VA = "0x185AB1A60")]
		private unsafe static UnsafeHashMap<ulong, INBAFFCDJNN> HIIAGONLDHI(Unity.Entities.Archetype*[] DLELACHNGDH)
		{
			return default(UnsafeHashMap<ulong, INBAFFCDJNN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2860", Offset = "0x5AB1660", VA = "0x185AB2860")]
		private static void IFBEGDOBOAM(BLKDOACIBKE KPHIJHMJGGO, UnsafeHashMap<ulong, INBAFFCDJNN> BKMOHPHNBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1CF0", Offset = "0x5AB0AF0", VA = "0x185AB1CF0")]
		private unsafe static void HMLFJHDAKOJ(BLKDOACIBKE KPHIJHMJGGO, Unity.Entities.Archetype*[] DLELACHNGDH, UnsafeHashMap<ulong, INBAFFCDJNN> BKMOHPHNBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5AB19F0", Offset = "0x5AB07F0", VA = "0x185AB19F0")]
		private unsafe static int GHLLMGNNPKP(Unity.Entities.Archetype*[] DLELACHNGDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5AB03B0", Offset = "0x5AAF1B0", VA = "0x185AB03B0")]
		private unsafe static void EGEMONLNEAJ(BLKDOACIBKE KPHIJHMJGGO, Unity.Entities.Archetype*[] DLELACHNGDH, global::BOONDFDEOBC<CBDMAFGMIBG> BMNJABIDNBC, NativeArray<EntityRemapUtility.EntityRemapInfo> NFLOAHPEMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0EB0", Offset = "0x5AAFCB0", VA = "0x185AB0EB0")]
		private static NativeArray<int> FDOKHOJFLOD(BLKDOACIBKE KPHIJHMJGGO)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5AB34B0", Offset = "0x5AB22B0", VA = "0x185AB34B0")]
		private static Memory<EntityArchetype> MMFABMDDMFN(BLKDOACIBKE KPHIJHMJGGO, NativeArray<int> ELKKGBGGKPO, EntityManager MKHPDCKNNBB, out int HMFBBDOOMCF, out int IAFIDIECALG)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2A10", Offset = "0x5AB1810", VA = "0x185AB2A10")]
		private unsafe static void IFJJEDCBCHM(Unity.Entities.Chunk* OKOFJBFBBNF, ReadOnlySpan<byte> GEGIPEOHNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1120", Offset = "0x5AAFF20", VA = "0x185AB1120")]
		private static void FNLPCAPFDDE(BLKDOACIBKE KPHIJHMJGGO, NativeArray<int> ELKKGBGGKPO, Span<EntityArchetype> DLELACHNGDH, EntityManager MKHPDCKNNBB, global::BOONDFDEOBC<CBDMAFGMIBG> BMNJABIDNBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3840", Offset = "0x5AB2640", VA = "0x185AB3840")]
		private unsafe static void OIHBHHLAKFF(Unity.Entities.Chunk* LDGNGMADGKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5AAFFE0", Offset = "0x5AAEDE0", VA = "0x185AAFFE0")]
		private unsafe static void ALBPAPOCGNI(BLKDOACIBKE.BBAKPJBAPBP.ELHEPFCCPBN FCBBBPDAPJB, int PCFANJAIONI, int PELMEDIKHKE, Unity.Entities.Chunk* OKOFJBFBBNF, BLKDOACIBKE KPHIJHMJGGO, NativeArray<int> ELKKGBGGKPO, global::BOONDFDEOBC<CBDMAFGMIBG> BMNJABIDNBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5AB07D0", Offset = "0x5AAF5D0", VA = "0x185AB07D0")]
		public static void EPHJIJGNBHP(AHBEEJODFBD GLPDAIBKGJO, in ByteString GEGIPEOHNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0860", Offset = "0x5AAF660", VA = "0x185AB0860")]
		public static void EPHJIJGNBHP(EntityManager MKHPDCKNNBB, global::BOONDFDEOBC<CBDMAFGMIBG> BMNJABIDNBC, in ByteString GEGIPEOHNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5AB31F0", Offset = "0x5AB1FF0", VA = "0x185AB31F0")]
		private static bool LOIMOGGMAKK(Type IGEIBCJNCHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2D60", Offset = "0x5AB1B60", VA = "0x185AB2D60")]
		private static void IOIPGJKHNMK(TypeManager.TypeInfo PMBEBMHHMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1860", Offset = "0x5AB0660", VA = "0x185AB1860")]
		private unsafe static int FOFFOOCGKOC(Unity.Entities.Archetype*[] DLELACHNGDH, NativeArray<EntityRemapUtility.EntityRemapInfo> NFLOAHPEMAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3960", Offset = "0x5AB2760", VA = "0x185AB3960")]
		private static int PMAEJCKEABM(int CNNKHGOHIDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5AB38C0", Offset = "0x5AB26C0", VA = "0x185AB38C0")]
		private static ulong OKFECKLLABO(int CNNKHGOHIDH)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class PBIMCAKLMBE
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC630", Offset = "0x5AAB430", VA = "0x185AAC630")]
	private unsafe static Span<byte> JDCKMGAPEGJ(Unity.Entities.Chunk* LDGNGMADGKK, int NIKJDHGOLFL)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x33D2720", Offset = "0x33D1520", VA = "0x1833D2720")]
	public unsafe static Span<T> LMBHMKJPFDG<T>(Unity.Entities.Chunk* LDGNGMADGKK, int NIKJDHGOLFL)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x33D26E0", Offset = "0x33D14E0", VA = "0x1833D26E0")]
	public static Span<T> LMBHMKJPFDG<T>(this ref Unity.Entities.Chunk LDGNGMADGKK, int NIKJDHGOLFL)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC320", Offset = "0x5AAB120", VA = "0x185AAC320")]
	public unsafe static Span<Entity> ADNDJPPAIGG(Unity.Entities.Chunk* LDGNGMADGKK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC390", Offset = "0x5AAB190", VA = "0x185AAC390")]
	public unsafe static void EMOCNNJJBKM(Unity.Entities.Chunk* LDGNGMADGKK, int NIKJDHGOLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5AAC7D0", Offset = "0x5AAB5D0", VA = "0x185AAC7D0")]
	public static Entity PHEOEBJBIMO(this EntityQuery FBENFNFLPOM)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : GDNMPNNPIMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3CA0", Offset = "0x5AB2AA0", VA = "0x185AB3CA0", Slot = "4")]
		public sealed override void JJOFCNGHIKE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KJPGGDKBIND()
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
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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

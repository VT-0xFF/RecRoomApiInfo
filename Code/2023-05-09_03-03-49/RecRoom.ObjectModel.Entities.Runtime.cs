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
		[Cpp2IlInjected.Address(RVA = "0x6084110", Offset = "0x6082B10", VA = "0x186084110")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x60863B0", Offset = "0x6084DB0", VA = "0x1860863B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6086420", Offset = "0x6084E20", VA = "0x186086420")]
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
			[Cpp2IlInjected.Address(RVA = "0x46B4E00", Offset = "0x46B3800", VA = "0x1846B4E00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3585780", Offset = "0x3584180", VA = "0x183585780")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3584E30", Offset = "0x3583830", VA = "0x183584E30")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3584F30", Offset = "0x3583930", VA = "0x183584F30")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3585330", Offset = "0x3583D30", VA = "0x183585330")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6086440", Offset = "0x6084E40", VA = "0x186086440")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct MKCFBOFGMIB<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DLINKGKJABE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::MKCFBOFGMIB<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9273A0", Offset = "0x925DA0", VA = "0x1809273A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B87670", Offset = "0x3B86070", VA = "0x183B87670", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C300", Offset = "0x2F0AD00", VA = "0x182F0C300")]
		[DebuggerHidden]
		public DLINKGKJABE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B87490", Offset = "0x3B85E90", VA = "0x183B87490", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3B87630", Offset = "0x3B86030", VA = "0x183B87630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> CBAOCINHBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream PDPOBLJIPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream AMPJONIOGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf FHNHAAJIPME;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int ANNFCHOJNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CF0", Offset = "0x7D26F0", VA = "0x1807D3CF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1110", Offset = "0x3ADFB10", VA = "0x183AE1110")]
	private MKCFBOFGMIB(byte[] CKDPLHPNFKM, Action<Protobuf> CBAOCINHBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3576810", Offset = "0x3575210", VA = "0x183576810")]
	public static global::MKCFBOFGMIB<Protobuf> KMLFLFAGFOK<Data>(ReadOnlySpan<byte> CEMHLJHECJC, ReadOnlySpan<Data> KNIJIHCLOLF, Action<Protobuf> CBAOCINHBNK)
	{
		return default(global::MKCFBOFGMIB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3AE0F80", Offset = "0x3ADF980", VA = "0x183AE0F80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3AE0FC0", Offset = "0x3ADF9C0", VA = "0x183AE0FC0", Slot = "4")]
	[IteratorStateMachine(typeof(global::MKCFBOFGMIB<>.DLINKGKJABE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3AE10C0", Offset = "0x3ADFAC0", VA = "0x183AE10C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KFCDNINBHNP<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] CKDPLHPNFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf FHNHAAJIPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream PDPOBLJIPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream INCCCBEEAIN;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4648BB0", Offset = "0x46475B0", VA = "0x184648BB0")]
	private KFCDNINBHNP(byte[] CKDPLHPNFKM, in Protobuf FHNHAAJIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3562EC0", Offset = "0x35618C0", VA = "0x183562EC0")]
	public static global::KFCDNINBHNP<Protobuf> KMLFLFAGFOK<T>(ReadOnlySpan<T> KNIJIHCLOLF)
	{
		return default(global::KFCDNINBHNP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4648B80", Offset = "0x4647580", VA = "0x184648B80")]
	public void EPDLDKOEKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4648AF0", Offset = "0x46474F0", VA = "0x184648AF0")]
	public ByteString EEJCBPBMEMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x46489C0", Offset = "0x46473C0", VA = "0x1846489C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ODHOHMALBAA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream PDPOBLJIPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream AMPJONIOGHP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6089110", Offset = "0x6087B10", VA = "0x186089110", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct JPHDMEFKFHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] CKDPLHPNFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream PDPOBLJIPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream INCCCBEEAIN;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6087E70", Offset = "0x6086870", VA = "0x186087E70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AEIGJGGOMPO
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	public static void CBPINOKCHHC(this NNLEPLPFODN DPMCBMJDHJK, NativeArray<Entity> AJMHFNCBOJK, [Optional][CallerFilePath] string AIECEBAOANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	public static void CBPINOKCHHC(this NNLEPLPFODN DPMCBMJDHJK, string KMEGKECOLPJ, NativeArray<Entity> AJMHFNCBOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	public static void CBPINOKCHHC(this NNLEPLPFODN DPMCBMJDHJK, string AIECEBAOANH, NativeArray<Entity> AJMHFNCBOJK, bool KPLFGOOOGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	public static void JIPDHNFKLJE(this NNLEPLPFODN DPMCBMJDHJK, NativeArray<Entity> AJMHFNCBOJK, NativeArray<Entity> GEPCFDIHMBJ, [Optional][CallerFilePath] string AIECEBAOANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	public static void JIPDHNFKLJE(this NNLEPLPFODN DPMCBMJDHJK, string AIECEBAOANH, NativeArray<Entity> AJMHFNCBOJK, NativeArray<Entity> GEPCFDIHMBJ, bool KPLFGOOOGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x254F200", Offset = "0x254DC00", VA = "0x18254F200")]
	public static void JIFBKAHJBAL<T>(this NNLEPLPFODN DPMCBMJDHJK, string KMEGKECOLPJ, NativeArray<Entity> AJMHFNCBOJK, NativeList<T> MNILNHMNKJK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x254F290", Offset = "0x254DC90", VA = "0x18254F290")]
	public static void JIFBKAHJBAL<T>(this NNLEPLPFODN DPMCBMJDHJK, string KMEGKECOLPJ, NativeArray<Entity> AJMHFNCBOJK, NativeArray<T> MNILNHMNKJK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	public static void JIFBKAHJBAL<T>(this NNLEPLPFODN DPMCBMJDHJK, string AIECEBAOANH, NativeArray<Entity> AJMHFNCBOJK, NativeArray<T> MNILNHMNKJK, bool KPLFGOOOGNJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x254F160", Offset = "0x254DB60", VA = "0x18254F160")]
	public static void AMMBGPFPOOH<T>(this NNLEPLPFODN DPMCBMJDHJK, NativeList<T> MNILNHMNKJK, [Optional][CallerFilePath] string AIECEBAOANH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x254F130", Offset = "0x254DB30", VA = "0x18254F130")]
	public static void AMMBGPFPOOH<T>(this NNLEPLPFODN DPMCBMJDHJK, NativeArray<T> MNILNHMNKJK, [Optional][CallerFilePath] string AIECEBAOANH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	public static void AMMBGPFPOOH<T>(this NNLEPLPFODN DPMCBMJDHJK, string AIECEBAOANH, NativeArray<T> MNILNHMNKJK, bool KPLFGOOOGNJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	public static void AEKMIBANAEK(this NNLEPLPFODN DPMCBMJDHJK, EntityQuery IOEGIOMNPHI, [Optional][CallerFilePath] string AIECEBAOANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	public static void AEKMIBANAEK(this NNLEPLPFODN DPMCBMJDHJK, string KMEGKECOLPJ, EntityQuery IOEGIOMNPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	public static void AEKMIBANAEK(this NNLEPLPFODN DPMCBMJDHJK, string AIECEBAOANH, EntityQuery IOEGIOMNPHI, bool KPLFGOOOGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x254F1D0", Offset = "0x254DBD0", VA = "0x18254F1D0")]
	public static void DLFHGGDHKJD<T, T2>(this NNLEPLPFODN DPMCBMJDHJK, string KMEGKECOLPJ, EntityQuery IOEGIOMNPHI) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void DLFHGGDHKJD<T, T2>(this NNLEPLPFODN DPMCBMJDHJK, string AIECEBAOANH, EntityQuery IOEGIOMNPHI, bool KPLFGOOOGNJ) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MJEMKHPIPGA : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GIFDPGCIHLK FICIADCAIGB
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
public interface FIBIKGKDKJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IFFMCAIFEBB(Entity OOGAMDNOHNH, object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ACMGEEDHGBB(Entity OOGAMDNOHNH, object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AODGJLFDBFF(Entity OOGAMDNOHNH);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AODGJLFDBFF(GIFDPGCIHLK DFKGNJHDLAL);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> NPBOIPJDGMA(Entity OOGAMDNOHNH);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BOIDKCFCLLM(Entity OOGAMDNOHNH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BMCEMPIECED<TComponentData, TValue> : global::IFMDKBEKNAG<TValue>, IDisposable where TComponentData : struct, MJEMKHPIPGA
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class LEAHLOPIHBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> ECNPNAMGIHB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int GNKNLJGDNJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x2A08AA0", Offset = "0x2A074A0", VA = "0x182A08AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2A08C00", Offset = "0x2A07600", VA = "0x182A08C00")]
		public bool LKAINNJBEEH(out TValue MFBGAMJDOKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2A08B50", Offset = "0x2A07550", VA = "0x182A08B50")]
		public void IFPOOIAJHAI(object HMAOAMDKNDD, TValue MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2A08AD0", Offset = "0x2A074D0", VA = "0x182A08AD0")]
		public bool HEOHJOBENDL(object HMAOAMDKNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2A08CC0", Offset = "0x2A076C0", VA = "0x182A08CC0")]
		public int LODPMCNLMAH(object HMAOAMDKNDD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2A08D70", Offset = "0x2A07770", VA = "0x182A08D70")]
		public LEAHLOPIHBP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<LEAHLOPIHBP> NKKOJBCBKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::DDHALPPBFJD<GIFDPGCIHLK, LEAHLOPIHBP> ACELFOANICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager IMCLABBJAOB;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x36257C0", Offset = "0x36241C0", VA = "0x1836257C0")]
	public BMCEMPIECED(EntityManager IMCLABBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x36254C0", Offset = "0x3623EC0", VA = "0x1836254C0", Slot = "4")]
	public void IFFMCAIFEBB(Entity OOGAMDNOHNH, object HMAOAMDKNDD, TValue MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x36251A0", Offset = "0x3623BA0", VA = "0x1836251A0", Slot = "5")]
	public bool ACMGEEDHGBB(Entity OOGAMDNOHNH, object HMAOAMDKNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3625660", Offset = "0x3624060", VA = "0x183625660", Slot = "6")]
	public bool LKAINNJBEEH(Entity OOGAMDNOHNH, out TValue MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x36253C0", Offset = "0x3623DC0", VA = "0x1836253C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x36255E0", Offset = "0x3623FE0", VA = "0x1836255E0")]
	private void KPLJFDCGDJM(LEAHLOPIHBP CCCPHMAMAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3625310", Offset = "0x3623D10", VA = "0x183625310")]
	private bool DBEOMGNKAHA(Entity OOGAMDNOHNH, out GIFDPGCIHLK DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3625730", Offset = "0x3624130", VA = "0x183625730")]
	private void MOBODKLADBM(Entity OOGAMDNOHNH, GIFDPGCIHLK DFKGNJHDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x36254A0", Offset = "0x3623EA0", VA = "0x1836254A0")]
	private bool HPEMCILHBAF(GIFDPGCIHLK DFKGNJHDLAL, out LEAHLOPIHBP CCCPHMAMAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x36253E0", Offset = "0x3623DE0", VA = "0x1836253E0")]
	private LEAHLOPIHBP EJBAAGEFHMC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IFMDKBEKNAG<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFFMCAIFEBB(Entity OOGAMDNOHNH, object HMAOAMDKNDD, TValue MFBGAMJDOKA);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ACMGEEDHGBB(Entity OOGAMDNOHNH, object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LKAINNJBEEH(Entity OOGAMDNOHNH, out TValue MFBGAMJDOKA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GIFDPGCIHLK : global::EIJDEJKCJCH<GIFDPGCIHLK>, LFLEFMNCAPN, IEquatable<GIFDPGCIHLK>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly GIFDPGCIHLK CJDCPGONDDE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int EOGKCECFNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8650A0", Offset = "0x863AA0", VA = "0x1808650A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int GGPKANELEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x865090", Offset = "0x863A90", VA = "0x180865090", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x865100", Offset = "0x863B00", VA = "0x180865100", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6087260", Offset = "0x6085C60", VA = "0x186087260", Slot = "8")]
	public bool Equals(GIFDPGCIHLK EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x60872B0", Offset = "0x6085CB0", VA = "0x1860872B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NPAIFDLKEKJ<T> : FIBIKGKDKJA, IDisposable where T : struct, MJEMKHPIPGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> NKKOJBCBKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::DDHALPPBFJD<GIFDPGCIHLK, HashSet<object>> ACELFOANICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager IMCLABBJAOB;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x328ACB0", Offset = "0x32896B0", VA = "0x18328ACB0")]
	public NPAIFDLKEKJ(EntityManager IMCLABBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x32899C0", Offset = "0x32883C0", VA = "0x1832899C0", Slot = "4")]
	public bool IFFMCAIFEBB(Entity OOGAMDNOHNH, object HMAOAMDKNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x32881C0", Offset = "0x3286BC0", VA = "0x1832881C0", Slot = "5")]
	public bool ACMGEEDHGBB(Entity OOGAMDNOHNH, object HMAOAMDKNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3288310", Offset = "0x3286D10", VA = "0x183288310", Slot = "6")]
	public bool AODGJLFDBFF(Entity OOGAMDNOHNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x32884D0", Offset = "0x3286ED0", VA = "0x1832884D0", Slot = "7")]
	public bool AODGJLFDBFF(GIFDPGCIHLK DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x328A6D0", Offset = "0x32890D0", VA = "0x18328A6D0", Slot = "8")]
	public IEnumerable<object> NPBOIPJDGMA(Entity OOGAMDNOHNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x328AB10", Offset = "0x3289510", VA = "0x18328AB10", Slot = "11")]
	public IEnumerable<object> NPBOIPJDGMA(GIFDPGCIHLK DFKGNJHDLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3288890", Offset = "0x3287290", VA = "0x183288890", Slot = "9")]
	public bool BOIDKCFCLLM(Entity OOGAMDNOHNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3288F00", Offset = "0x3287900", VA = "0x183288F00", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3289FB0", Offset = "0x32889B0", VA = "0x183289FB0")]
	private void KPLJFDCGDJM(HashSet<object> CCCPHMAMAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3288B60", Offset = "0x3287560", VA = "0x183288B60")]
	private bool DBEOMGNKAHA(Entity OOGAMDNOHNH, out GIFDPGCIHLK DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3289EC0", Offset = "0x32888C0", VA = "0x183289EC0")]
	private bool JPOCPNMGNPA(Entity OOGAMDNOHNH, out GIFDPGCIHLK DFKGNJHDLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x328A1E0", Offset = "0x3288BE0", VA = "0x18328A1E0")]
	private void MFCLCPAOJHC(Entity OOGAMDNOHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x328A3B0", Offset = "0x3288DB0", VA = "0x18328A3B0")]
	private void MOBODKLADBM(Entity OOGAMDNOHNH, GIFDPGCIHLK DFKGNJHDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3289460", Offset = "0x3287E60", VA = "0x183289460")]
	private bool FCDGDLGEFDI(GIFDPGCIHLK DFKGNJHDLAL, out HashSet<object> CCCPHMAMAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3288FC0", Offset = "0x32879C0", VA = "0x183288FC0")]
	private HashSet<object> EJBAAGEFHMC()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JMBGCHFMGPA : global::NONFHEHKKKF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6087E60", Offset = "0x6086860", VA = "0x186087E60", Slot = "4")]
	public float DPMDMJNCKCK(float3 MFBGAMJDOKA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct AKAIMIDIEID : global::NONFHEHKKKF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6084100", Offset = "0x6082B00", VA = "0x186084100", Slot = "4")]
	public float DPMDMJNCKCK(float3 MFBGAMJDOKA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IAMLLANNNBH : global::NONFHEHKKKF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6087C20", Offset = "0x6086620", VA = "0x186087C20", Slot = "4")]
	public float DPMDMJNCKCK(float3 MFBGAMJDOKA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct LJKLGLFEKLK : global::NONFHEHKKKF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xFE1EE0", Offset = "0xFE08E0", VA = "0x180FE1EE0", Slot = "4")]
	public int DPMDMJNCKCK(int3 MFBGAMJDOKA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KIMJNOIGCJK : global::NONFHEHKKKF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4090", Offset = "0x3AA2A90", VA = "0x183AA4090", Slot = "4")]
	public int DPMDMJNCKCK(int3 MFBGAMJDOKA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct BHIHALHMOAO : global::NONFHEHKKKF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6084290", Offset = "0x6082C90", VA = "0x186084290", Slot = "4")]
	public int DPMDMJNCKCK(int3 MFBGAMJDOKA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class EICDPLHJPDE : PGOPFOOOOPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type HNJALJOJDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7D2880", Offset = "0x7D1280", VA = "0x1807D2880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1E79800", Offset = "0x1E78200", VA = "0x181E79800")]
	public EICDPLHJPDE(Type HPIICDKJLAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JIGFCOCIBKO : EICDPLHJPDE
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1E79800", Offset = "0x1E78200", VA = "0x181E79800")]
	public JIGFCOCIBKO(Type HPIICDKJLAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BMOHDDDPMOJ : EICDPLHJPDE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type MLJOMBBAHJF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7D2590", Offset = "0x7D0F90", VA = "0x1807D2590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6085200", Offset = "0x6083C00", VA = "0x186085200")]
	public BMOHDDDPMOJ(Type KIILOBMBDJE, Type HPIICDKJLAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FIIJIGCKEPD : EICDPLHJPDE
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1E79800", Offset = "0x1E78200", VA = "0x181E79800")]
	public FIIJIGCKEPD(Type HPIICDKJLAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IGKLDKDLNIM : PGOPFOOOOPJ
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public IGKLDKDLNIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MMLKNPGAEIO : PGOPFOOOOPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ECHGPOCMBHL CFNPKIAONAA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x755A00", Offset = "0x754400", VA = "0x180755A00")]
		[CompilerGenerated]
		get
		{
			return default(ECHGPOCMBHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E797D0", Offset = "0x1E781D0", VA = "0x181E797D0")]
	public MMLKNPGAEIO(ECHGPOCMBHL HHNNPAGKLBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class PJIOIOLLAAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly BKKHAMMBGFF ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager IMCLABBJAOB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BKKHAMMBGFF FPKDMGAMAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x60892B0", Offset = "0x6087CB0", VA = "0x1860892B0")]
	public PJIOIOLLAAE(BKKHAMMBGFF ENGIGCMGHCJ, EntityManager IMCLABBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x394CFD0", Offset = "0x394B9D0", VA = "0x18394CFD0")]
	public bool BLPFMDIIPBD<T>(Entity OOGAMDNOHNH) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x394D810", Offset = "0x394C210", VA = "0x18394D810")]
	public bool KECBOEPPFNA<T>(Entity OOGAMDNOHNH, out T MFBGAMJDOKA) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x394D8A0", Offset = "0x394C2A0", VA = "0x18394D8A0")]
	public T MINIOHNJOMO<T>(Entity OOGAMDNOHNH) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x394D010", Offset = "0x394BA10", VA = "0x18394D010")]
	private ComponentType IFJIHGHEPIO<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60891E0", Offset = "0x6087BE0", VA = "0x1860891E0")]
	private ComponentType IFJIHGHEPIO(Type EMKINACMDLO)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class MGBMFCFIAMC
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	protected MGBMFCFIAMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class OCICBMPHOCN<View, Data> : DPCOGLJGJDC where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType CBIAGJEBCHO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type NAOHEGGOLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x389C000", Offset = "0x389AA00", VA = "0x18389C000", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type JNMFEOOBDNL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x389B7F0", Offset = "0x389A1F0", VA = "0x18389B7F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int PHCNIOEEKGC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x389BBE0", Offset = "0x389A5E0", VA = "0x18389BBE0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x389C4E0", Offset = "0x389AEE0", VA = "0x18389C4E0")]
	public Data LAJGOMGGGFK(Entity OOGAMDNOHNH)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x389C550", Offset = "0x389AF50", VA = "0x18389C550")]
	public Data PNKLMFICELA(Entity OOGAMDNOHNH)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View KCJHDHOELAA(Entity OOGAMDNOHNH);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x357AF10", Offset = "0x3579910", VA = "0x18357AF10", Slot = "15")]
	protected internal override T KCJHDHOELAA<T>(Entity OOGAMDNOHNH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3166830", Offset = "0x3165230", VA = "0x183166830")]
	protected OCICBMPHOCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class DPCOGLJGJDC : JPCNDAPLHKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic HBBCPOMHOOH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager GMCADEOGFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x75C400", Offset = "0x75AE00", VA = "0x18075C400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type NAOHEGGOLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type JNMFEOOBDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int PHCNIOEEKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type PHIJNGPJFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xE4E220", Offset = "0xE4CC20", VA = "0x180E4E220", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int EKAMBKPBPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6086100", Offset = "0x6084B00", VA = "0x186086100", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private HMBIKFADCFA[] IBBLDPPEHFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xE4E150", Offset = "0xE4CB50", VA = "0x180E4E150", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual HMBIKFADCFA[] GGFKHOBKBJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6085F80", Offset = "0x6084980", VA = "0x186085F80", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EFEGNNABCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6085F50", Offset = "0x6084950", VA = "0x186085F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6086170", Offset = "0x6084B70", VA = "0x186086170")]
	public void NCBKDFJCMBF(EntityManager IMCLABBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8426B0", Offset = "0x8410B0", VA = "0x1808426B0")]
	protected JPCNDAPLHKB LMHGGFPIBAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T KCJHDHOELAA<T>(Entity OOGAMDNOHNH) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6086040", Offset = "0x6084A40", VA = "0x186086040", Slot = "8")]
	public (uint, uint) IEBCOIKKMEN(Entity OOGAMDNOHNH)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6086290", Offset = "0x6084C90", VA = "0x186086290", Slot = "9")]
	public bool PPANOBOMAMB(Entity OOGAMDNOHNH, (uint order, uint change) LHIPGOMOMEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	protected DPCOGLJGJDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class GJMDDHCBABN<Data> : LAAHJLIKAHN where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data NHIBPFHOELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3FE5920", Offset = "0x3FE4320", VA = "0x183FE5920", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7373C0", Offset = "0x735DC0", VA = "0x1807373C0", Slot = "8")]
	protected virtual bool EIDBDMHGFME(ReadOnlySpan<Data> KNIJIHCLOLF, CBHAKBPJLFK DJHHBMBBPIE, out ReadOnlySpan<byte> CEMHLJHECJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "9")]
	protected virtual bool EKHCLMLBEGC(int LHIPGOMOMEB, Span<Data> KNIJIHCLOLF, in ReadOnlySpan<byte> CEMHLJHECJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3FE59E0", Offset = "0x3FE43E0", VA = "0x183FE59E0", Slot = "5")]
	internal sealed override bool EIDBDMHGFME(ref Unity.Entities.Chunk PIKNKOLCJFP, int OIPOHJPAAPA, CBHAKBPJLFK DJHHBMBBPIE, out ReadOnlySpan<byte> CEMHLJHECJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3FE6100", Offset = "0x3FE4B00", VA = "0x183FE6100", Slot = "6")]
	internal sealed override bool EKHCLMLBEGC(int LHIPGOMOMEB, ref Unity.Entities.Chunk PIKNKOLCJFP, int OIPOHJPAAPA, in ReadOnlySpan<byte> CEMHLJHECJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x355BAC0", Offset = "0x355A4C0", VA = "0x18355BAC0")]
	protected global::KFCDNINBHNP<Protobuf> JBGOEKPLAIO<Protobuf>(ReadOnlySpan<Data> KNIJIHCLOLF) where Protobuf : IMessage, new()
	{
		return default(global::KFCDNINBHNP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x355BB10", Offset = "0x355A510", VA = "0x18355BB10")]
	protected global::MKCFBOFGMIB<Protobuf> NEKKIFINNMH<Protobuf>(ReadOnlySpan<byte> CEMHLJHECJC, ReadOnlySpan<Data> KNIJIHCLOLF, Action<Protobuf> CBAOCINHBNK) where Protobuf : IMessage, new()
	{
		return default(global::MKCFBOFGMIB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3166830", Offset = "0x3165230", VA = "0x183166830")]
	protected GJMDDHCBABN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class LAAHJLIKAHN
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int GGPKANELEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6088320", Offset = "0x6086D20", VA = "0x186088320", Slot = "5")]
	internal virtual bool EIDBDMHGFME(ref Unity.Entities.Chunk PIKNKOLCJFP, int OIPOHJPAAPA, CBHAKBPJLFK DJHHBMBBPIE, out ReadOnlySpan<byte> CEMHLJHECJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "6")]
	internal virtual bool EKHCLMLBEGC(int LHIPGOMOMEB, ref Unity.Entities.Chunk PIKNKOLCJFP, int OIPOHJPAAPA, in ReadOnlySpan<byte> CEMHLJHECJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	protected LAAHJLIKAHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NONFHEHKKKF<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo DPMDMJNCKCK(TFrom MFBGAMJDOKA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CKCNKEHPAGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGENFHMDEEO(T MFBGAMJDOKA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct POGJHNJHLNM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::NONFHEHKKKF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> JEDNOHIDIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> PJHMIIJBHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap DJJNLDOINEG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct OFGFEKPBNGA<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::NONFHEHKKKF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> DABAEAFGFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> PJHMIIJBHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap DJJNLDOINEG;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct DOAAHMAICDI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CMJCEAKMGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> JEDNOHIDIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> PJHMIIJBHBE;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3B95680", Offset = "0x3B94080", VA = "0x183B95680", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct BBEFCEKFBKE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CMJCEAKMGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> JEDNOHIDIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> OKJJNGGHNKG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct NFKFNALHAFJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::NONFHEHKKKF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> LGBCJIKKCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> PJHMIIJBHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap DJJNLDOINEG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct PKIGPIGCNKJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HPIICDKJLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> OAMHHOPCFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> PPDMFKCLJNM;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct AJFCENHEKCI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HPIICDKJLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> OAMHHOPCFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> PPDMFKCLJNM;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3CA7030", Offset = "0x3CA5A30", VA = "0x183CA7030", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct GPPHBJLBOHN<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> JEDNOHIDIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> OKJJNGGHNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, LEKKGHCNCEK> POGHGGJFFJI;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x494DCB0", Offset = "0x494C6B0", VA = "0x18494DCB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct IKDENFPEKJC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::NONFHEHKKKF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> JEDNOHIDIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> OKJJNGGHNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, LEKKGHCNCEK> POGHGGJFFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap DJJNLDOINEG;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct GMIPNBKPLID<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::CKCNKEHPAGE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> JEDNOHIDIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> OKJJNGGHNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate DJJNLDOINEG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct GNCHDPDCHJA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity HPIICDKJLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> OAMHHOPCFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> OJAPNJEMJGP;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6087300", Offset = "0x6085D00", VA = "0x186087300", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct OLJCJHIIMHB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity HPIICDKJLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> OAMHHOPCFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> OJAPNJEMJGP;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6089150", Offset = "0x6087B50", VA = "0x186089150", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DENIIJHCBAE
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class MJIOPCJFCBO
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x37D51E0", Offset = "0x37D3BE0", VA = "0x1837D51E0")]
	public static bool LILBOCPBMFL<T>(this NativeArray<Entity> OAMHHOPCFDF, EntityManager IMCLABBJAOB, Allocator APPJGCOGPBM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class CDAGOBLKJPP
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GEANKCHJHGD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public GEANKCHJHGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class LJMFLDHILGB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public LJMFLDHILGB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> OILAIJLJPOB;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6085440", Offset = "0x6083E40", VA = "0x186085440")]
	public CDAGOBLKJPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class MEOEPBAOHAO
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class PLECAGCHILN
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct ACDDHBPJLAL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct DOIMADEKJHK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal ACDDHBPJLAL<TFrom> EOBFGLJBCIJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator APPJGCOGPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> EHFHEFGEMIO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct GKCIKILOIHB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct JOJENPAEAGF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal GKCIKILOIHB<TFrom> EOBFGLJBCIJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator APPJGCOGPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> EHFHEFGEMIO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct DHIMFAGBEKD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct AHNADHEEHJA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal DHIMFAGBEKD<TFrom> EOBFGLJBCIJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator APPJGCOGPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> EHFHEFGEMIO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct IHAOOMHAGDC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct CJDNBKOEMDP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal IHAOOMHAGDC<TFrom> EOBFGLJBCIJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator APPJGCOGPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> EHFHEFGEMIO;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class JAAHMJEJPCH
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class EAJKLFPLNIM
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x32167A0", Offset = "0x32151A0", VA = "0x1832167A0")]
	public static NativeList<T> HACCNDFGEOO<T>(this NativeArray<T> EPILLMAPANB, Allocator APPJGCOGPBM = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class KKFDLALPNCF
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x36F70D0", Offset = "0x36F5AD0", VA = "0x1836F70D0")]
	public static NativeArray<T> ALJKOFGNAML<T>(this NativeList<Entity> EPILLMAPANB, EntityManager IMCLABBJAOB, Allocator APPJGCOGPBM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x36F6FD0", Offset = "0x36F59D0", VA = "0x1836F6FD0")]
	public static NativeArray<T> ALJKOFGNAML<T>(this NativeArray<Entity> EPILLMAPANB, EntityManager IMCLABBJAOB, Allocator APPJGCOGPBM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class PNCACPILHBE
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct PAPKAALLKNM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct INCOHJMEDCB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public PAPKAALLKNM<TFrom> EHFHEFGEMIO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator APPJGCOGPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> JEDNOHIDIGH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct KGKJLEAJKAD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct PPGDCCDDDNF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public KGKJLEAJKAD<TFrom> EHFHEFGEMIO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator APPJGCOGPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> JEDNOHIDIGH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct HAOGBCDPJFL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct HMBOAJCFPBE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public HAOGBCDPJFL<TFrom> EHFHEFGEMIO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator APPJGCOGPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> JEDNOHIDIGH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OBOGJMFHDGL
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class HGDDAAIJIMN
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct LJHODEBKGOE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator APPJGCOGPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> JEDNOHIDIGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct LOIPPMMKIGK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator APPJGCOGPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> JEDNOHIDIGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct LANKCNMJEKC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator APPJGCOGPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> JEDNOHIDIGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct PHMODKKHGOF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator APPJGCOGPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> JEDNOHIDIGH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class PNEMDBNJJEK
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class KOPHCBCKJHC
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x36F98B0", Offset = "0x36F82B0", VA = "0x1836F98B0")]
	public static NativeList<Entity> MINABPBPEPK<T>(this NativeArray<Entity> OAMHHOPCFDF, EntityManager IMCLABBJAOB, Allocator APPJGCOGPBM = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class BBENHPLGDFM
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface KOHBOFILENM
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KHOMIBADEIP
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class LAHPMOEGPML
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class CNEOCFKMNBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x60857E0", Offset = "0x60841E0", VA = "0x1860857E0")]
	public static bool ICAPHBAMDGI(Type EMKINACMDLO, Type PIIKDJDKOBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class KGEHEAFOCAC<Attribute, BaseClass> : global::JNMOKFDJNJH<BaseClass>, ELJGEMBGPCG where Attribute : EICDPLHJPDE
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly NNLEPLPFODN DPMCBMJDHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string KMEGKECOLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> IJJNMMMPIOJ;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x464A140", Offset = "0x4648B40", VA = "0x18464A140")]
	public KGEHEAFOCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4649B10", Offset = "0x4648510", VA = "0x184649B10", Slot = "4")]
	public bool AAFBPIPDPOL(int CKHJBBKEJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4649CA0", Offset = "0x46486A0", VA = "0x184649CA0", Slot = "5")]
	public global::BPPLLIHONDM<BaseClass> CBNEFFLOLPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4649F50", Offset = "0x4648950", VA = "0x184649F50", Slot = "7")]
	protected virtual bool ICAPHBAMDGI(Type EMKINACMDLO, int CGBJDLFGGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x464A050", Offset = "0x4648A50", VA = "0x18464A050", Slot = "8")]
	protected virtual int NGNKHODJHOB(Type EMKINACMDLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4649C10", Offset = "0x4648610", VA = "0x184649C10")]
	public void BGMNFOJPGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4649B70", Offset = "0x4648570", VA = "0x184649B70", Slot = "6")]
	public void AIDBCCOFMIA(Type EMKINACMDLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BPPLLIHONDM<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> OANDPDFAMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> NOBAOPGEPMK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> OCHAJLLNEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x362CC00", Offset = "0x362B600", VA = "0x18362CC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x362D150", Offset = "0x362BB50", VA = "0x18362D150")]
	public BPPLLIHONDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x362CFB0", Offset = "0x362B9B0", VA = "0x18362CFB0")]
	public BPPLLIHONDM(int ICKPJJPJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x362CE60", Offset = "0x362B860", VA = "0x18362CE60")]
	internal void IFPOOIAJHAI(int CKHJBBKEJPM, BaseClass LMLFCMLPFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x347B230", Offset = "0x3479C30", VA = "0x18347B230")]
	public bool ONPBMIAHIFM<T>(out BaseClass MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x362CF10", Offset = "0x362B910", VA = "0x18362CF10")]
	public bool ONPBMIAHIFM(Type EPNDONNEBFB, out BaseClass MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x362CEE0", Offset = "0x362B8E0", VA = "0x18362CEE0")]
	public bool KJLMDGCABFO(int CKHJBBKEJPM, out BaseClass MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x347B150", Offset = "0x3479B50", VA = "0x18347B150")]
	public T HHEAEGBMLDP<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x362CE30", Offset = "0x362B830", VA = "0x18362CE30")]
	public BaseClass HHEAEGBMLDP(Type FEJFEADILMK)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class MJNACBDMEIK : global::KGEHEAFOCAC<JIGFCOCIBKO, MGBMFCFIAMC>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x60884B0", Offset = "0x6086EB0", VA = "0x1860884B0")]
	public MJNACBDMEIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class CGPHAAMDFLG : global::KGEHEAFOCAC<BMOHDDDPMOJ, DPCOGLJGJDC>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x60854C0", Offset = "0x6083EC0", VA = "0x1860854C0")]
	public CGPHAAMDFLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class LJMIABLKAFD : global::KGEHEAFOCAC<FIIJIGCKEPD, LAAHJLIKAHN>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6088340", Offset = "0x6086D40", VA = "0x186088340")]
	public LJMIABLKAFD()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[KEFMDJAGLBH(IGKCNDFEDMC.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> AEENEACHPOE;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x875C70", Offset = "0x874670", VA = "0x180875C70")]
		private ComponentSystemTypes(List<Type> AEENEACHPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6085A20", Offset = "0x6084420", VA = "0x186085A20")]
		public static void BGMNFOJPGJK(List<Type> AEENEACHPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6085B30", Offset = "0x6084530", VA = "0x186085B30")]
		private void MEMEKLLAGNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6085AB0", Offset = "0x60844B0", VA = "0x186085AB0")]
		private bool ICAPHBAMDGI(Type EMKINACMDLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x60859C0", Offset = "0x60843C0", VA = "0x1860859C0")]
		private void BFABJGDNPOO(Type EMKINACMDLO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class EKOAMPPHLGH : CHOEGOEDAGH
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6086320", Offset = "0x6084D20", VA = "0x186086320", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase KHGOPPHJAIP();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6086360", Offset = "0x6084D60", VA = "0x186086360")]
	protected ComponentSystemBase PDAJCFPBIKM(params ComponentSystemBase[] DILFFHKMEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3222B80", Offset = "0x3221580", VA = "0x183222B80")]
	protected ComponentSystemBase PDAJCFPBIKM<T>(params ComponentSystemBase[] DILFFHKMEHB) where T : CHOEGOEDAGH, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3222B40", Offset = "0x3221540", VA = "0x183222B40")]
	protected ComponentSystemBase CPOHLLMAPFH<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3222B40", Offset = "0x3221540", VA = "0x183222B40")]
	protected ComponentSystemBase DKCOIPNNDEG<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	protected EKOAMPPHLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface JNMOKFDJNJH<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAFBPIPDPOL(int CKHJBBKEJPM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BPPLLIHONDM<BaseClass> CBNEFFLOLPB();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class CHOEGOEDAGH : IGOALPMNMDD
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6085530", Offset = "0x6083F30", VA = "0x186085530", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public CHOEGOEDAGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class HIEJFMJLCNL : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6087390", Offset = "0x6085D90", VA = "0x186087390")]
	public ComponentDataFromEntity GMNABJDGCHC(int CKHJBBKEJPM, bool HMMIOMHIJFE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6087430", Offset = "0x6085E30", VA = "0x186087430", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0")]
	protected HIEJFMJLCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class LBCEAGCCIOE : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0")]
	protected LBCEAGCCIOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class BFPKHLNEKPC : HIEJFMJLCNL
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6084260", Offset = "0x6082C60", VA = "0x186084260", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	protected void HNGFIMPFPEH(string PDNCIOCGJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0")]
	protected BFPKHLNEKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class LMPPLNIPCML
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class IGOALPMNMDD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	protected IGOALPMNMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[KEFMDJAGLBH(IGKCNDFEDMC.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6089300", Offset = "0x6087D00", VA = "0x186089300")]
		public static ComponentSystemGroup[] AMNHJDFHFNO(World ENGIGCMGHCJ, GFJDHJNOKKB HLAFJKPIFFI = GFJDHJNOKKB.Default, bool NOHEFEJEEKL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6089730", Offset = "0x6088130", VA = "0x186089730")]
		private static Type[] FOCCFGNGPAH(GFJDHJNOKKB HLAFJKPIFFI, bool NOHEFEJEEKL, ComponentSystemGroup[] EIGNDLJNFKP, ComponentSystemGroup IDMFMDMDBNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6089BC0", Offset = "0x60885C0", VA = "0x186089BC0")]
		private static ComponentSystemGroup[] LBLPFHHLEGI(World ENGIGCMGHCJ, out ComponentSystemGroup IDMFMDMDBNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60894B0", Offset = "0x6087EB0", VA = "0x1860894B0")]
		internal static bool DAPEAPGIOOG(ECHGPOCMBHL HHNNPAGKLBL, out IIFKKHPGHMD OCPCCOCDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x60893D0", Offset = "0x6087DD0", VA = "0x1860893D0")]
		private static ComponentSystemGroup CPFGGLKOFOF(Type EMKINACMDLO, World ENGIGCMGHCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6089A90", Offset = "0x6088490", VA = "0x186089A90")]
		private static ComponentSystemGroup[] KNKDLKIBDKG(Type[] AEENEACHPOE, World ENGIGCMGHCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6089F30", Offset = "0x6088930", VA = "0x186089F30")]
		internal static void ONOKLPEEPAH(World ENGIGCMGHCJ, Type[] KKBCOPGPIEB, ComponentSystemGroup[] EIGNDLJNFKP, ComponentSystemGroup IDMFMDMDBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x608A450", Offset = "0x6088E50", VA = "0x18608A450")]
		internal static bool PKEIMMACLKP(ComponentSystemBase APCKCJOBOPP, ComponentSystemGroup[] EIGNDLJNFKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6089ED0", Offset = "0x60888D0", VA = "0x186089ED0")]
		private static void MAHDAECEIEJ(ComponentSystemGroup[] EIGNDLJNFKP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct FKELMKMCDJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> BGJHJNHAIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> DILFFHKMEHB;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xC33810", Offset = "0xC32210", VA = "0x180C33810")]
	public FKELMKMCDJH(Dictionary<Type, List<Type>> BGJHJNHAIJE, HashSet<Type> DILFFHKMEHB)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[KEFMDJAGLBH(IGKCNDFEDMC.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class KDIMKHHGMMD : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
			[DebuggerHidden]
			public KDIMKHHGMMD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x6088240", Offset = "0x6086C40", VA = "0x186088240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6087FA0", Offset = "0x60869A0", VA = "0x186087FA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x60882D0", Offset = "0x6086CD0", VA = "0x1860882D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6088200", Offset = "0x6086C00", VA = "0x186088200", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6088150", Offset = "0x6086B50", VA = "0x186088150", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6088150", Offset = "0x6086B50", VA = "0x186088150", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct JDHACINLLCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type DJAGBBJDPAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private GFJDHJNOKKB HLAFJKPIFFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool GIBNJALEGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool FAINONPIBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool NOHEFEJEEKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> DGFOLFKPCOP;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x608A880", Offset = "0x6089280", VA = "0x18608A880")]
		public static RRFilterWorldSystems KMLFLFAGFOK()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x608A860", Offset = "0x6089260", VA = "0x18608A860")]
		public RRFilterWorldSystems GODPFJDFPIE(GFJDHJNOKKB HHNNPAGKLBL)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x608A5D0", Offset = "0x6088FD0", VA = "0x18608A5D0")]
		public RRFilterWorldSystems EENDNKDDAHC(IEnumerable<Type> AEENEACHPOE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x608A870", Offset = "0x6089270", VA = "0x18608A870")]
		public RRFilterWorldSystems JCOFGKOOJJP(bool PGEMHHMEDJF)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x608B430", Offset = "0x6089E30", VA = "0x18608B430")]
		public RRFilterWorldSystems PKJOEABNDJF(bool ONMFDDGGNLI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x608A540", Offset = "0x6088F40", VA = "0x18608A540")]
		public FKELMKMCDJH CEGLMNBCDCI(Type[] KFMFIGLDGDF)
		{
			return default(FKELMKMCDJH);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x608A610", Offset = "0x6089010", VA = "0x18608A610")]
		[IteratorStateMachine(typeof(KDIMKHHGMMD))]
		internal IEnumerable<Type> EIBPEKANEHM(IEnumerable<Type> AEENEACHPOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x608AEE0", Offset = "0x60898E0", VA = "0x18608AEE0")]
		internal Dictionary<Type, List<Type>> NGACENDOABO(IEnumerable<Type> AEENEACHPOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x608B320", Offset = "0x6089D20", VA = "0x18608B320")]
		private void OHINEKGFMPG(Dictionary<Type, List<Type>> GFIGBAPMFPP, Type EMKINACMDLO, Type BHACHHCHFBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x608A6A0", Offset = "0x60890A0", VA = "0x18608A6A0")]
		internal HashSet<Type> GLGNHNDIBDH(IEnumerable<Type> EIGNDLJNFKP, Dictionary<Type, List<Type>> IAGLEADCODA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x608A8A0", Offset = "0x60892A0", VA = "0x18608A8A0")]
		internal bool MLOHFDCDGMF(Type EMKINACMDLO, GFJDHJNOKKB HLAFJKPIFFI, bool NOHEFEJEEKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x608B1C0", Offset = "0x6089BC0", VA = "0x18608B1C0")]
		[CompilerGenerated]
		internal static void OEOAIOPLPOO(Type EMKINACMDLO, ref JDHACINLLCC P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class IOGKPIMGNNP
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool BDMDEKJELMI;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6087E00", Offset = "0x6086800", VA = "0x186087E00")]
	public static void NCBKDFJCMBF(bool BFIMHHIKINE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6087C40", Offset = "0x6086640", VA = "0x186087C40")]
	private static void GEKPODLIGJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class MMEMKPDAGPL
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6088520", Offset = "0x6086F20", VA = "0x186088520")]
	public static ulong HOOFINMJPOC(Type EMKINACMDLO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6088550", Offset = "0x6086F50", VA = "0x186088550")]
	public static ulong HOOFINMJPOC(string ILCNMNMJFKH)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[KEFMDJAGLBH(IGKCNDFEDMC.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct MFCIFMJPGNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong LECCEOKFLHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong ABBEDFDKGPG;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xC61740", Offset = "0xC60140", VA = "0x180C61740")]
			public MFCIFMJPGNJ(ulong NIABOMFKDFC, ulong MIKFPEGMKFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x6088420", Offset = "0x6086E20", VA = "0x186088420", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> FELHLGEKGJH;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static MFCIFMJPGNJ[] GALEOAHBDML;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool BDMDEKJELMI;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x608BF10", Offset = "0x608A910", VA = "0x18608BF10")]
		public static ulong OAGADDJBIAP(int CKHJBBKEJPM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x608BB90", Offset = "0x608A590", VA = "0x18608BB90")]
		public static int MDCOPFECAHI(ulong MIKFPEGMKFN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x608BC40", Offset = "0x608A640", VA = "0x18608BC40")]
		public static void NCBKDFJCMBF(bool BFIMHHIKINE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x608BE30", Offset = "0x608A830", VA = "0x18608BE30")]
		private static void NDPNINFCBAN(int LMKDBABHKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x608B870", Offset = "0x608A270", VA = "0x18608B870")]
		private static void KPDOMHDKKLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x608B790", Offset = "0x608A190", VA = "0x18608B790")]
		private static MFCIFMJPGNJ JBPKPLLOKID(Type EMKINACMDLO)
		{
			return default(MFCIFMJPGNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x608C190", Offset = "0x608AB90", VA = "0x18608C190")]
		private static ulong PFJENLKLOOP(Type EMKINACMDLO, ulong MIKFPEGMKFN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x608BF70", Offset = "0x608A970", VA = "0x18608BF70")]
		private static void OPDGHNJPPNO(in MFCIFMJPGNJ HELHPAMOKKD, TypeManager.TypeInfo AMFFDKLJGLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x608B510", Offset = "0x6089F10", VA = "0x18608B510")]
		private static void BHLLCLIJILI(MFCIFMJPGNJ AMFFDKLJGLN, int CKHJBBKEJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x608B610", Offset = "0x608A010", VA = "0x18608B610")]
		private static void CKFNGBFAOOJ(MFCIFMJPGNJ AMFFDKLJGLN, int CKHJBBKEJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x608B6F0", Offset = "0x608A0F0", VA = "0x18608B6F0")]
		private static MFCIFMJPGNJ GKNOFACHKPA(int CKHJBBKEJPM)
		{
			return default(MFCIFMJPGNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x608B780", Offset = "0x608A180", VA = "0x18608B780")]
		private static int IKEPAKNJDJJ(int CKHJBBKEJPM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class NPNCDDEGOBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly CGPHAAMDFLG MEIAPBAKNBO;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly LJMIABLKAFD FPMEFGLMLKM;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly MJNACBDMEIK FHODOKAJMAN;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> BIMJIEJIEPN;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool BDMDEKJELMI;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::JNMOKFDJNJH<DPCOGLJGJDC> IDEOBEADODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6088970", Offset = "0x6087370", VA = "0x186088970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::JNMOKFDJNJH<LAAHJLIKAHN> HKCJBBDPLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x60889D0", Offset = "0x60873D0", VA = "0x1860889D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::JNMOKFDJNJH<MGBMFCFIAMC> BAPDBIIECJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6088910", Offset = "0x6087310", VA = "0x186088910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6088A30", Offset = "0x6087430", VA = "0x186088A30")]
	public static void NCBKDFJCMBF(bool BFIMHHIKINE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6088890", Offset = "0x6087290", VA = "0x186088890")]
	public static Type[] DGADIODCLAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class FEHGNJHILMK
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> PGJMPHDEPDK;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool BDMDEKJELMI;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6086D50", Offset = "0x6085750", VA = "0x186086D50")]
	public static int IEBCOIKKMEN(int CKHJBBKEJPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6087070", Offset = "0x6085A70", VA = "0x186087070")]
	public static void NCBKDFJCMBF(bool BFIMHHIKINE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6086DF0", Offset = "0x60857F0", VA = "0x186086DF0")]
	private static void JLEKNKOHLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6087190", Offset = "0x6085B90", VA = "0x186087190")]
	private static int PNCNNCPKDNE(Type EMKINACMDLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6087110", Offset = "0x6085B10", VA = "0x186087110")]
	private static void PDOAHDCGLGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class BKKHAMMBGFF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World PEPBPKOJIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly PJIOIOLLAAE LMLFCMLPFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] EIGNDLJNFKP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World FPKDMGAMAMN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World EAMNELNJNBP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager GMCADEOGFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1169110", Offset = "0x1167B10", VA = "0x181169110")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PJIOIOLLAAE CMOPJKDIAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::BPPLLIHONDM<DPCOGLJGJDC> IDEOBEADODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D2D70", VA = "0x1807D4370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::BPPLLIHONDM<LAAHJLIKAHN> HKCJBBDPLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8464B0", Offset = "0x844EB0", VA = "0x1808464B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::BPPLLIHONDM<MGBMFCFIAMC> BAPDBIIECJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x878100", Offset = "0x876B00", VA = "0x180878100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> AGGKBGIFNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1169150", Offset = "0x1167B50", VA = "0x181169150")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] FNEAGEDGIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6084620", Offset = "0x6083020", VA = "0x186084620")]
	public static BKKHAMMBGFF IIPCFNEGAAH(string KMEGKECOLPJ, ECHGPOCMBHL HHNNPAGKLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6084CE0", Offset = "0x60836E0", VA = "0x186084CE0")]
	public BKKHAMMBGFF(string KMEGKECOLPJ, ECHGPOCMBHL HHNNPAGKLBL = ECHGPOCMBHL.Simulation, GFJDHJNOKKB HLAFJKPIFFI = GFJDHJNOKKB.Default, bool BFIMHHIKINE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x60844D0", Offset = "0x6082ED0", VA = "0x1860844D0")]
	public ComponentSystemBase DCGGOKLKOJC(Type EMKINACMDLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x38432B0", Offset = "0x3841CB0", VA = "0x1838432B0")]
	public T DCGGOKLKOJC<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6084410", Offset = "0x6082E10", VA = "0x186084410")]
	public void AMOPBIADJJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6084C00", Offset = "0x6083600", VA = "0x186084C00")]
	public void OHPKOEPIDGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6084AB0", Offset = "0x60834B0", VA = "0x186084AB0")]
	public void LKOODBCABHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6084B10", Offset = "0x6083510", VA = "0x186084B10")]
	public void MCBKBAPOALK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6084470", Offset = "0x6082E70", VA = "0x186084470")]
	public void CINPGKHAMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x60842A0", Offset = "0x6082CA0", VA = "0x1860842A0")]
	public void AFABPIGPPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6084A50", Offset = "0x6083450", VA = "0x186084A50")]
	public void LCPCKCBKDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6084B70", Offset = "0x6083570", VA = "0x186084B70")]
	public void MPAODEJDIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x60845C0", Offset = "0x6082FC0", VA = "0x1860845C0")]
	public void EOIHECJPHHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x60844F0", Offset = "0x6082EF0", VA = "0x1860844F0")]
	public void DCGIMODPBDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6084970", Offset = "0x6083370", VA = "0x186084970")]
	internal void JHMGNEFHNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6084C60", Offset = "0x6083660", VA = "0x186084C60")]
	private bool PPCCKGGGIFP(ComponentSystemGroup HGPMMCNKFAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x60846A0", Offset = "0x60830A0", VA = "0x1860846A0")]
	private void JDGAFGFEBHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6084300", Offset = "0x6082D00", VA = "0x186084300")]
	private ComponentSystemGroup[] AMNHJDFHFNO(GFJDHJNOKKB HLAFJKPIFFI, bool NOHEFEJEEKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6084550", Offset = "0x6082F50", VA = "0x186084550", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum ECHGPOCMBHL
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
public sealed class LCKFHFAKHBB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public GFJDHJNOKKB ALPPKINNNIE;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum GFJDHJNOKKB
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
public interface IIFKKHPGHMD
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type MMNCNAGHADO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] AIOCAPAAKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class AAJIOINJJLD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool LEDAFEJDIJE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	protected AAJIOINJJLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class IKHJBFCIMDC : AAJIOINJJLD
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public IKHJBFCIMDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class NHHNNEJLIGC : AAJIOINJJLD
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public NHHNNEJLIGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class PNHBMAAPKAJ : AAJIOINJJLD
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public PNHBMAAPKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class KKPJPIMDEAK : AAJIOINJJLD
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public KKPJPIMDEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class KGMJDNHONFF : AAJIOINJJLD
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public KGMJDNHONFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class GKMGABENHON : AAJIOINJJLD
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public GKMGABENHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class BIOCJGPCCDI : AAJIOINJJLD
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public BIOCJGPCCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class EPJHNENDAPM : AAJIOINJJLD
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public EPJHNENDAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class HDALKCODDML : AAJIOINJJLD
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public HDALKCODDML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class FJHFCANGJLJ : ALGGKJGKELO
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public FJHFCANGJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class GCIHEOBMDCE : ALGGKJGKELO
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public GCIHEOBMDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class KKAPOABMEBA : ALGGKJGKELO
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public KKAPOABMEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class HNLMKBGMPHI : ALGGKJGKELO
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public HNLMKBGMPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[KLEAGPOIIPF(PFPBFPDNLIO.Application)]
public class ALGGKJGKELO : AAJIOINJJLD
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool LEDAFEJDIJE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6083FE0", Offset = "0x60829E0", VA = "0x186083FE0")]
	public ALGGKJGKELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class LNDIBHKHMOM : PGOPFOOOOPJ
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public LNDIBHKHMOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class HPAOCNOHPJB
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void IEHMEHHOFEJ<From, To>(From EHFHEFGEMIO, ref To KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class PEEEMHPIOAG<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static IEHMEHHOFEJ<From, To> NPMBCANLKOC;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public PEEEMHPIOAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6087440", Offset = "0x6085E40", VA = "0x186087440")]
	static HPAOCNOHPJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x322FC80", Offset = "0x322E680", VA = "0x18322FC80")]
	public static void IHMKMDCEFGE<T>(IEHMEHHOFEJ<T, T> EBOEGMHLMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x322FAD0", Offset = "0x322E4D0", VA = "0x18322FAD0")]
	public static void IHMKMDCEFGE<From, To>(IEHMEHHOFEJ<From, To> EBOEGMHLMBC, IEHMEHHOFEJ<To, From> BPENENFGNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x322FA80", Offset = "0x322E480", VA = "0x18322FA80")]
	public static void IHMKMDCEFGE<From, To>(IEHMEHHOFEJ<From, To> NPMBCANLKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3234440", Offset = "0x3232E40", VA = "0x183234440")]
	public static IEHMEHHOFEJ<From, To> IHNMIHMHNDB<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3237A50", Offset = "0x3236450", VA = "0x183237A50")]
	public static void PHBFOKPHOPN<From, To>(From EHFHEFGEMIO, ref To KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class CBHAKBPJLFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> ACHLFBJFPOH;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1A6E300", Offset = "0x1A6CD00", VA = "0x181A6E300")]
	public CBHAKBPJLFK(NativeArray<EntityRemapUtility.EntityRemapInfo> ACHLFBJFPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x41C2630", Offset = "0x41C1030", VA = "0x1841C2630")]
	public Entity EAJDPHHFPFA(Entity BMKGEKNDEIG)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class CCIPNPFEAAG
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> PHHPLAAELJK;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6085250", Offset = "0x6083C50", VA = "0x186085250")]
	public static bool KNEIIGFKILJ(ulong OGHEGNBLHPM, uint LHIPGOMOMEB, out string KMEGKECOLPJ)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct JCNPBIJEIDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int EOGKCECFNOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int GGPKANELEKJ;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9480E0", Offset = "0x946AE0", VA = "0x1809480E0")]
			public JCNPBIJEIDF(int ALJOMNDNEBM, int LHIPGOMOMEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct DAMFCKAKICF
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch BNLNLKOJKLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long PNFMKFPEIBD;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long IAEEOOLABAG
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x6085EF0", Offset = "0x60848F0", VA = "0x186085EF0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long FKCJPMOGOHA
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x6085E80", Offset = "0x6084880", VA = "0x186085E80")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x6085DC0", Offset = "0x60847C0", VA = "0x186085DC0")]
			public static DAMFCKAKICF AJFOCJFBCII()
			{
				return default(DAMFCKAKICF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct FAOMBOPMAHH : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct NIKHKGHOAMN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* PINLJAELKGL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly PGNEMFIADIH.JPLGFNJIELF.MMKCNCGJKMI FKCMDINKKKC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly CBHAKBPJLFK DJHHBMBBPIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::BPPLLIHONDM<LAAHJLIKAHN> GIAFGFGMCGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int OIPOHJPAAPA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int KDLJIOFICIF;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x6088660", Offset = "0x6087060", VA = "0x186088660")]
				public unsafe NIKHKGHOAMN(Unity.Entities.Archetype* PINLJAELKGL, PGNEMFIADIH.JPLGFNJIELF.MMKCNCGJKMI FKCMDINKKKC, CBHAKBPJLFK DJHHBMBBPIE, global::BPPLLIHONDM<LAAHJLIKAHN> GIAFGFGMCGP, int OIPOHJPAAPA, int KDLJIOFICIF = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x6088610", Offset = "0x6087010", VA = "0x186088610")]
				public NIKHKGHOAMN(in NIKHKGHOAMN MNILNHMNKJK, int KDLJIOFICIF)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly NIKHKGHOAMN[] KNIJIHCLOLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] GNDPKFJMPAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int IDHHNLHGPOK;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x6086C10", Offset = "0x6085610", VA = "0x186086C10")]
			public FAOMBOPMAHH(NIKHKGHOAMN[] KNIJIHCLOLF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x60868E0", Offset = "0x60852E0", VA = "0x1860868E0", Slot = "4")]
			public void Invoke(int ALJOMNDNEBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x6086530", Offset = "0x6084F30", VA = "0x186086530")]
			private void BMGAAMBLIJO(in NIKHKGHOAMN MNILNHMNKJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x6086940", Offset = "0x6085340", VA = "0x186086940")]
			private static void OEMHEHGGKPG(in NIKHKGHOAMN MNILNHMNKJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class LPAJOJMDLEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public PGNEMFIADIH asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::BPPLLIHONDM<LAAHJLIKAHN> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public LPAJOJMDLEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x60883B0", Offset = "0x6086DB0", VA = "0x1860883B0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class ANNDBJFAODH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public PGNEMFIADIH.JPLGFNJIELF.MMKCNCGJKMI srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public LPAJOJMDLEK CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public ANNDBJFAODH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class AGBPEPOJKPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public ANNDBJFAODH CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public AGBPEPOJKPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x6083FF0", Offset = "0x60829F0", VA = "0x186083FF0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly NNLEPLPFODN CCJFDKFMPNN;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly NNLEPLPFODN HFMNENFLOOF;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly NNLEPLPFODN BHEEPJFKHCN;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly NNLEPLPFODN BPIGCILOFPA;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool LCLENPNHMDI;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static PGNEMFIADIH.JPLGFNJIELF.EDHADEDPCFM AIHNIFCLJIJ;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x608C290", Offset = "0x608AC90", VA = "0x18608C290")]
		private unsafe static bool ABLHIIJOKOP(Unity.Entities.Archetype* FFCMEKBDBJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x608DB90", Offset = "0x608C590", VA = "0x18608DB90")]
		internal unsafe static Unity.Entities.Archetype*[] GLPJAAPFGII(ref Unity.Entities.EntityComponentStore KKMPHDLMCCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x608DAD0", Offset = "0x608C4D0", VA = "0x18608DAD0")]
		public static void GCLNOHIFIPI(BKKHAMMBGFF ENGIGCMGHCJ, out ByteString CEMHLJHECJC, out NativeArray<EntityRemapUtility.EntityRemapInfo> FEODMODAEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x608E060", Offset = "0x608CA60", VA = "0x18608E060")]
		internal static void KPKJAGAFOAL(BKKHAMMBGFF ENGIGCMGHCJ, PGNEMFIADIH EHBBIPDMLNO, out NativeArray<EntityRemapUtility.EntityRemapInfo> FEODMODAEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x608C6B0", Offset = "0x608B0B0", VA = "0x18608C6B0")]
		private unsafe static UnsafeHashMap<ulong, JCNPBIJEIDF> BBKLPAPJIHJ(Unity.Entities.Archetype*[] PKFPICEOPNP)
		{
			return default(UnsafeHashMap<ulong, JCNPBIJEIDF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x608FB40", Offset = "0x608E540", VA = "0x18608FB40")]
		private static void PNKOHNCBECP(PGNEMFIADIH EHBBIPDMLNO, UnsafeHashMap<ulong, JCNPBIJEIDF> BNGLGLLLDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x608EA40", Offset = "0x608D440", VA = "0x18608EA40")]
		private unsafe static void LGFBFNNGEMK(PGNEMFIADIH EHBBIPDMLNO, Unity.Entities.Archetype*[] PKFPICEOPNP, UnsafeHashMap<ulong, JCNPBIJEIDF> BNGLGLLLDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x608CFD0", Offset = "0x608B9D0", VA = "0x18608CFD0")]
		private unsafe static int DBMPLEAILOP(Unity.Entities.Archetype*[] PKFPICEOPNP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x608CBB0", Offset = "0x608B5B0", VA = "0x18608CBB0")]
		private unsafe static void CIPGFBIJEKK(PGNEMFIADIH EHBBIPDMLNO, Unity.Entities.Archetype*[] PKFPICEOPNP, global::BPPLLIHONDM<LAAHJLIKAHN> GIAFGFGMCGP, NativeArray<EntityRemapUtility.EntityRemapInfo> FEODMODAEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x608C940", Offset = "0x608B340", VA = "0x18608C940")]
		private static NativeArray<int> BHFPOOJMHBG(PGNEMFIADIH EHBBIPDMLNO)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x608ED70", Offset = "0x608D770", VA = "0x18608ED70")]
		private static Memory<EntityArchetype> MEGDHEENFAC(PGNEMFIADIH EHBBIPDMLNO, NativeArray<int> AEENEACHPOE, EntityManager IMCLABBJAOB, out int KJKHPCPDPGA, out int HFONECOEPPE)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x608D780", Offset = "0x608C180", VA = "0x18608D780")]
		private unsafe static void EHOBNKCHCPP(Unity.Entities.Chunk* EPJPNILAING, ReadOnlySpan<byte> CEMHLJHECJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x608D040", Offset = "0x608BA40", VA = "0x18608D040")]
		private static void DHAOEIOJDOO(PGNEMFIADIH EHBBIPDMLNO, NativeArray<int> AEENEACHPOE, Span<EntityArchetype> PKFPICEOPNP, EntityManager IMCLABBJAOB, global::BPPLLIHONDM<LAAHJLIKAHN> GIAFGFGMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x608DFE0", Offset = "0x608C9E0", VA = "0x18608DFE0")]
		private unsafe static void JHFGOCDFFMF(Unity.Entities.Chunk* PIKNKOLCJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x608C3A0", Offset = "0x608ADA0", VA = "0x18608C3A0")]
		private unsafe static void ADKNNFPNLMM(PGNEMFIADIH.JPLGFNJIELF.MMKCNCGJKMI PINLJAELKGL, int OEODFPGBFLP, int BNPLBGABOKJ, Unity.Entities.Chunk* EPJPNILAING, PGNEMFIADIH EHBBIPDMLNO, NativeArray<int> AEENEACHPOE, global::BPPLLIHONDM<LAAHJLIKAHN> GIAFGFGMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x608F460", Offset = "0x608DE60", VA = "0x18608F460")]
		public static void OGABIKLIBEK(BKKHAMMBGFF ENGIGCMGHCJ, in ByteString CEMHLJHECJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x608F4F0", Offset = "0x608DEF0", VA = "0x18608F4F0")]
		public static void OGABIKLIBEK(EntityManager IMCLABBJAOB, global::BPPLLIHONDM<LAAHJLIKAHN> GIAFGFGMCGP, in ByteString CEMHLJHECJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x608F1A0", Offset = "0x608DBA0", VA = "0x18608F1A0")]
		private static bool OAOKHHADACK(Type EMKINACMDLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x608E790", Offset = "0x608D190", VA = "0x18608E790")]
		private static void LBACIKNOMCL(TypeManager.TypeInfo AMFFDKLJGLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x608DE50", Offset = "0x608C850", VA = "0x18608DE50")]
		private unsafe static int IKCJDCLBFPK(Unity.Entities.Archetype*[] PKFPICEOPNP, NativeArray<EntityRemapUtility.EntityRemapInfo> FEODMODAEDI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x608DD70", Offset = "0x608C770", VA = "0x18608DD70")]
		private static int IEBCOIKKMEN(int CKHJBBKEJPM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x608F100", Offset = "0x608DB00", VA = "0x18608F100")]
		private static ulong OAGADDJBIAP(int CKHJBBKEJPM)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class IAKJPCNLCJN
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6087640", Offset = "0x6086040", VA = "0x186087640")]
	private unsafe static Span<byte> APNHHFBHLDB(Unity.Entities.Chunk* PIKNKOLCJFP, int OIPOHJPAAPA)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x323DBB0", Offset = "0x323C5B0", VA = "0x18323DBB0")]
	public unsafe static Span<T> ELNDFLOLKJH<T>(Unity.Entities.Chunk* PIKNKOLCJFP, int OIPOHJPAAPA)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x323DB70", Offset = "0x323C570", VA = "0x18323DB70")]
	public static Span<T> ELNDFLOLKJH<T>(this ref Unity.Entities.Chunk PIKNKOLCJFP, int OIPOHJPAAPA)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x60877E0", Offset = "0x60861E0", VA = "0x1860877E0")]
	public unsafe static Span<Entity> FBCCNNABOJB(Unity.Entities.Chunk* PIKNKOLCJFP)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6087980", Offset = "0x6086380", VA = "0x186087980")]
	public unsafe static void PDOAHDCGLGB(Unity.Entities.Chunk* PIKNKOLCJFP, int OIPOHJPAAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6087850", Offset = "0x6086250", VA = "0x186087850")]
	public static Entity KBBIADCLNFL(this EntityQuery IOEGIOMNPHI)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : IAAKGJNKLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x608FF50", Offset = "0x608E950", VA = "0x18608FF50", Slot = "4")]
		public sealed override void BGMNFOJPGJK()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
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
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
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

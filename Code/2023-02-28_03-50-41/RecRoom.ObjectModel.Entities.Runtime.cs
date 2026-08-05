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
		[Cpp2IlInjected.Address(RVA = "0x591B390", Offset = "0x5919D90", VA = "0x18591B390")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x591D620", Offset = "0x591C020", VA = "0x18591D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x591D690", Offset = "0x591C090", VA = "0x18591D690")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D355B0", Offset = "0x3D33FB0", VA = "0x183D355B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x28F0570", Offset = "0x28EEF70", VA = "0x1828F0570")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28EFC30", Offset = "0x28EE630", VA = "0x1828EFC30")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28EFD30", Offset = "0x28EE730", VA = "0x1828EFD30")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28F01A0", Offset = "0x28EEBA0", VA = "0x1828F01A0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x591D6B0", Offset = "0x591C0B0", VA = "0x18591D6B0")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BCFFFHOPDBB<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LOGAGBGCLJG : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::BCFFFHOPDBB<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6E2040", Offset = "0x6E0A40", VA = "0x1806E2040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x299B410", Offset = "0x2999E10", VA = "0x18299B410", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1D687B0", Offset = "0x1D671B0", VA = "0x181D687B0")]
		[DebuggerHidden]
		public LOGAGBGCLJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x299B230", Offset = "0x2999C30", VA = "0x18299B230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x299B3D0", Offset = "0x2999DD0", VA = "0x18299B3D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> DGAEKHOODJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream BODAGHDNFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream HONIGENNLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf JFBNKDNJKOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int GBJCKAFHMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C1010", Offset = "0x6BFA10", VA = "0x1806C1010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x26C84C0", Offset = "0x26C6EC0", VA = "0x1826C84C0")]
	private BCFFFHOPDBB(byte[] DFIIPKJNKEL, Action<Protobuf> DGAEKHOODJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x24A4C50", Offset = "0x24A3650", VA = "0x1824A4C50")]
	public static global::BCFFFHOPDBB<Protobuf> GANMJPNFBJN<Data>(ReadOnlySpan<byte> DBKEJGOGOOA, ReadOnlySpan<Data> KPKJFELPMLM, Action<Protobuf> DGAEKHOODJM)
	{
		return default(global::BCFFFHOPDBB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x26C8330", Offset = "0x26C6D30", VA = "0x1826C8330", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x26C8370", Offset = "0x26C6D70", VA = "0x1826C8370", Slot = "4")]
	[IteratorStateMachine(typeof(global::BCFFFHOPDBB<>.LOGAGBGCLJG))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x26C8470", Offset = "0x26C6E70", VA = "0x1826C8470", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KPIBGHOAFLA<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] DFIIPKJNKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf JFBNKDNJKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream BODAGHDNFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream OKPNDFOLPPK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3B7CDD0", Offset = "0x3B7B7D0", VA = "0x183B7CDD0")]
	private KPIBGHOAFLA(byte[] DFIIPKJNKEL, in Protobuf JFBNKDNJKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2369F60", Offset = "0x2368960", VA = "0x182369F60")]
	public static global::KPIBGHOAFLA<Protobuf> GANMJPNFBJN<T>(ReadOnlySpan<T> KPKJFELPMLM)
	{
		return default(global::KPIBGHOAFLA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B7CD10", Offset = "0x3B7B710", VA = "0x183B7CD10")]
	public void ENAPNHDJLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B7CD40", Offset = "0x3B7B740", VA = "0x183B7CD40")]
	public ByteString KAMPKGCAGPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B7CBE0", Offset = "0x3B7B5E0", VA = "0x183B7CBE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CNFIDDJNMKF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream BODAGHDNFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream HONIGENNLMP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x591BB10", Offset = "0x591A510", VA = "0x18591BB10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct HPOPPHAOLEI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] DFIIPKJNKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream BODAGHDNFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream OKPNDFOLPPK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x591DEF0", Offset = "0x591C8F0", VA = "0x18591DEF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KODOIENNPFC
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public static void CLHIJMLCCFP(this KGOHPJFJCLE LHMILDDMKBL, NativeArray<Entity> CGCCIONMJJA, [Optional][CallerFilePath] string DJCECPCGODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public static void CLHIJMLCCFP(this KGOHPJFJCLE LHMILDDMKBL, string ANJJEPIBAGI, NativeArray<Entity> CGCCIONMJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public static void CLHIJMLCCFP(this KGOHPJFJCLE LHMILDDMKBL, string DJCECPCGODL, NativeArray<Entity> CGCCIONMJJA, bool GLGBBCABHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public static void GILMIJOMLCO(this KGOHPJFJCLE LHMILDDMKBL, NativeArray<Entity> CGCCIONMJJA, NativeArray<Entity> FEENBFHHDPC, [Optional][CallerFilePath] string DJCECPCGODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public static void GILMIJOMLCO(this KGOHPJFJCLE LHMILDDMKBL, string DJCECPCGODL, NativeArray<Entity> CGCCIONMJJA, NativeArray<Entity> FEENBFHHDPC, bool GLGBBCABHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x25D61E0", Offset = "0x25D4BE0", VA = "0x1825D61E0")]
	public static void LHIOCKLPJPM<T>(this KGOHPJFJCLE LHMILDDMKBL, string ANJJEPIBAGI, NativeArray<Entity> CGCCIONMJJA, NativeList<T> NIPBPKPBPPP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x25D6270", Offset = "0x25D4C70", VA = "0x1825D6270")]
	public static void LHIOCKLPJPM<T>(this KGOHPJFJCLE LHMILDDMKBL, string ANJJEPIBAGI, NativeArray<Entity> CGCCIONMJJA, NativeArray<T> NIPBPKPBPPP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public static void LHIOCKLPJPM<T>(this KGOHPJFJCLE LHMILDDMKBL, string DJCECPCGODL, NativeArray<Entity> CGCCIONMJJA, NativeArray<T> NIPBPKPBPPP, bool GLGBBCABHHI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x25D6170", Offset = "0x25D4B70", VA = "0x1825D6170")]
	public static void JGJNHHNDEBJ<T>(this KGOHPJFJCLE LHMILDDMKBL, NativeList<T> NIPBPKPBPPP, [Optional][CallerFilePath] string DJCECPCGODL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x25D6140", Offset = "0x25D4B40", VA = "0x1825D6140")]
	public static void JGJNHHNDEBJ<T>(this KGOHPJFJCLE LHMILDDMKBL, NativeArray<T> NIPBPKPBPPP, [Optional][CallerFilePath] string DJCECPCGODL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public static void JGJNHHNDEBJ<T>(this KGOHPJFJCLE LHMILDDMKBL, string DJCECPCGODL, NativeArray<T> NIPBPKPBPPP, bool GLGBBCABHHI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public static void NBNPLGBPJHJ(this KGOHPJFJCLE LHMILDDMKBL, EntityQuery CAMLCFELNDE, [Optional][CallerFilePath] string DJCECPCGODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public static void NBNPLGBPJHJ(this KGOHPJFJCLE LHMILDDMKBL, string ANJJEPIBAGI, EntityQuery CAMLCFELNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public static void NBNPLGBPJHJ(this KGOHPJFJCLE LHMILDDMKBL, string DJCECPCGODL, EntityQuery CAMLCFELNDE, bool GLGBBCABHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x25D6110", Offset = "0x25D4B10", VA = "0x1825D6110")]
	public static void EEEAHALLOEH<T, T2>(this KGOHPJFJCLE LHMILDDMKBL, string ANJJEPIBAGI, EntityQuery CAMLCFELNDE) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	private static void EEEAHALLOEH<T, T2>(this KGOHPJFJCLE LHMILDDMKBL, string DJCECPCGODL, EntityQuery CAMLCFELNDE, bool GLGBBCABHHI) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IMOHFLKNJIO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	EIJALHDNNPP MIOGPCOPEKG
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
public interface HCLJNDNCLEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHLBKJFCCKI(Entity GOANOLJBHPF, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ICBEAKDKCFJ(Entity GOANOLJBHPF, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LFBPAPAJLLJ(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LFBPAPAJLLJ(EIJALHDNNPP BIONDBIGACN);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> BCAIFNDIPPB(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GDAEPPLKICB(Entity GOANOLJBHPF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GBCMHMFPJGH<TComponentData, TValue> : global::MFOCLGLDEAM<TValue>, IDisposable where TComponentData : struct, IMOHFLKNJIO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class AINMGGKBJJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> OKDFPKLCDDM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int HPEOPAJJAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x2217480", Offset = "0x2215E80", VA = "0x182217480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3083DF0", Offset = "0x30827F0", VA = "0x183083DF0")]
		public bool DLLAPIGOMJI(out TValue MNIAGKNOHEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3083D40", Offset = "0x3082740", VA = "0x183083D40")]
		public void CPLOAHMOJFD(object DEGCIHEAIBD, TValue MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3083F60", Offset = "0x3082960", VA = "0x183083F60")]
		public bool OLCIACFECIH(object DEGCIHEAIBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3083EB0", Offset = "0x30828B0", VA = "0x183083EB0")]
		public int ODPHFPELANF(object DEGCIHEAIBD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3083FE0", Offset = "0x30829E0", VA = "0x183083FE0")]
		public AINMGGKBJJN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<AINMGGKBJJN> KNBEMOIPCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::PJDAAKMMIMP<EIJALHDNNPP, AINMGGKBJJN> MEGBPKOJFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager BJMEFCCEPHI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A818E0", Offset = "0x2A802E0", VA = "0x182A818E0")]
	public GBCMHMFPJGH(EntityManager BJMEFCCEPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A812E0", Offset = "0x2A7FCE0", VA = "0x182A812E0", Slot = "4")]
	public void CHLBKJFCCKI(Entity GOANOLJBHPF, object DEGCIHEAIBD, TValue MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2A81630", Offset = "0x2A80030", VA = "0x182A81630", Slot = "5")]
	public bool ICBEAKDKCFJ(Entity GOANOLJBHPF, object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A81400", Offset = "0x2A7FE00", VA = "0x182A81400", Slot = "6")]
	public bool DLLAPIGOMJI(Entity GOANOLJBHPF, out TValue MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A814D0", Offset = "0x2A7FED0", VA = "0x182A814D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A814F0", Offset = "0x2A7FEF0", VA = "0x182A814F0")]
	private void EPCBECFOFGJ(AINMGGKBJJN LLCFMFEIHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A81830", Offset = "0x2A80230", VA = "0x182A81830")]
	private bool OCIGEGEEMBH(Entity GOANOLJBHPF, out EIJALHDNNPP BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A817A0", Offset = "0x2A801A0", VA = "0x182A817A0")]
	private void LLIJJJLNOMF(Entity GOANOLJBHPF, EIJALHDNNPP BIONDBIGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A812C0", Offset = "0x2A7FCC0", VA = "0x182A812C0")]
	private bool ANLCLBMEPNJ(EIJALHDNNPP BIONDBIGACN, out AINMGGKBJJN LLCFMFEIHDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A81570", Offset = "0x2A7FF70", VA = "0x182A81570")]
	private AINMGGKBJJN HBMMBGGCJPO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MFOCLGLDEAM<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHLBKJFCCKI(Entity GOANOLJBHPF, object DEGCIHEAIBD, TValue MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ICBEAKDKCFJ(Entity GOANOLJBHPF, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DLLAPIGOMJI(Entity GOANOLJBHPF, out TValue MNIAGKNOHEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct EIJALHDNNPP : global::HFJJIJCEKGL<EIJALHDNNPP>, HOKCJDBMKAA, IEquatable<EIJALHDNNPP>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly EIJALHDNNPP EBOAMDEGHNP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int FOHLPAKJEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x772D90", Offset = "0x771790", VA = "0x180772D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int BNNADFINGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x88A590", Offset = "0x888F90", VA = "0x18088A590", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xEA60A0", Offset = "0xEA4AA0", VA = "0x180EA60A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x591D580", Offset = "0x591BF80", VA = "0x18591D580", Slot = "8")]
	public bool Equals(EIJALHDNNPP DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x591D5D0", Offset = "0x591BFD0", VA = "0x18591D5D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MMCBEEPMOEL<T> : HCLJNDNCLEM, IDisposable where T : struct, IMOHFLKNJIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> KNBEMOIPCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::PJDAAKMMIMP<EIJALHDNNPP, HashSet<object>> MEGBPKOJFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager BJMEFCCEPHI;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B26910", Offset = "0x2B25310", VA = "0x182B26910")]
	public MMCBEEPMOEL(EntityManager BJMEFCCEPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B23EC0", Offset = "0x2B228C0", VA = "0x182B23EC0", Slot = "4")]
	public bool CHLBKJFCCKI(Entity GOANOLJBHPF, object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B25390", Offset = "0x2B23D90", VA = "0x182B25390", Slot = "5")]
	public bool ICBEAKDKCFJ(Entity GOANOLJBHPF, object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2B25970", Offset = "0x2B24370", VA = "0x182B25970", Slot = "6")]
	public bool LFBPAPAJLLJ(Entity GOANOLJBHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B25BD0", Offset = "0x2B245D0", VA = "0x182B25BD0", Slot = "7")]
	public bool LFBPAPAJLLJ(EIJALHDNNPP BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2B23AC0", Offset = "0x2B224C0", VA = "0x182B23AC0", Slot = "8")]
	public IEnumerable<object> BCAIFNDIPPB(Entity GOANOLJBHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B23B80", Offset = "0x2B22580", VA = "0x182B23B80", Slot = "11")]
	public IEnumerable<object> BCAIFNDIPPB(EIJALHDNNPP BIONDBIGACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B24A70", Offset = "0x2B23470", VA = "0x182B24A70", Slot = "9")]
	public bool GDAEPPLKICB(Entity GOANOLJBHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B24620", Offset = "0x2B23020", VA = "0x182B24620", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B24740", Offset = "0x2B23140", VA = "0x182B24740")]
	private void EPCBECFOFGJ(HashSet<object> LLCFMFEIHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B265D0", Offset = "0x2B24FD0", VA = "0x182B265D0")]
	private bool OCIGEGEEMBH(Entity GOANOLJBHPF, out EIJALHDNNPP BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B26300", Offset = "0x2B24D00", VA = "0x182B26300")]
	private bool NMFHBJKBAKF(Entity GOANOLJBHPF, out EIJALHDNNPP BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B24500", Offset = "0x2B22F00", VA = "0x182B24500")]
	private void DNCFHPEHAGK(Entity GOANOLJBHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2B25D00", Offset = "0x2B24700", VA = "0x182B25D00")]
	private void LLIJJJLNOMF(Entity GOANOLJBHPF, EIJALHDNNPP BIONDBIGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B24E00", Offset = "0x2B23800", VA = "0x182B24E00")]
	private bool GIEAIMMLFOF(EIJALHDNNPP BIONDBIGACN, out HashSet<object> LLCFMFEIHDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B25060", Offset = "0x2B23A60", VA = "0x182B25060")]
	private HashSet<object> HBMMBGGCJPO()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MIKANPKNADH : global::MPBALJFINNN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x591F2A0", Offset = "0x591DCA0", VA = "0x18591F2A0", Slot = "4")]
	public float AOLMNMNMECN(float3 MNIAGKNOHEJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DMOGCLJGOLF : global::MPBALJFINNN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x591C010", Offset = "0x591AA10", VA = "0x18591C010", Slot = "4")]
	public float AOLMNMNMECN(float3 MNIAGKNOHEJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LHNIGLDFLMB : global::MPBALJFINNN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x591E9B0", Offset = "0x591D3B0", VA = "0x18591E9B0", Slot = "4")]
	public float AOLMNMNMECN(float3 MNIAGKNOHEJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct FKGJEKGDAFM : global::MPBALJFINNN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x112AF20", Offset = "0x1129920", VA = "0x18112AF20", Slot = "4")]
	public int AOLMNMNMECN(int3 MNIAGKNOHEJ)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LNDELIGJINJ : global::MPBALJFINNN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3BF7CD0", Offset = "0x3BF66D0", VA = "0x183BF7CD0", Slot = "4")]
	public int AOLMNMNMECN(int3 MNIAGKNOHEJ)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct BBDJMPAIIKI : global::MPBALJFINNN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x591B5F0", Offset = "0x5919FF0", VA = "0x18591B5F0", Slot = "4")]
	public int AOLMNMNMECN(int3 MNIAGKNOHEJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class OLDJJMGINHK : AGCFOLLKBED
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type MGMGJKDNKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6DFB30", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xEAE6E0", Offset = "0xEAD0E0", VA = "0x180EAE6E0")]
	public OLDJJMGINHK(Type JBHMOMKIBNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class COOJPHDNGHI : OLDJJMGINHK
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xEAE6E0", Offset = "0xEAD0E0", VA = "0x180EAE6E0")]
	public COOJPHDNGHI(Type JBHMOMKIBNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DMOBKPKAGOF : OLDJJMGINHK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type KGMHPKJNJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1140", Offset = "0x6DFB40", VA = "0x1806E1140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x591BFC0", Offset = "0x591A9C0", VA = "0x18591BFC0")]
	public DMOBKPKAGOF(Type OCBKIKIGHJD, Type JBHMOMKIBNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HNPKKIDOILC : OLDJJMGINHK
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xEAE6E0", Offset = "0xEAD0E0", VA = "0x180EAE6E0")]
	public HNPKKIDOILC(Type JBHMOMKIBNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OFACFEGCPFP : AGCFOLLKBED
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public OFACFEGCPFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MPALKKKLACC : AGCFOLLKBED
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IDCNBKCHOBE GMIIBDMKCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040")]
		[CompilerGenerated]
		get
		{
			return default(IDCNBKCHOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xEAE6B0", Offset = "0xEAD0B0", VA = "0x180EAE6B0")]
	public MPALKKKLACC(IDCNBKCHOBE HLCFNPLAIJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class JEHPLMMOFBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly EAPDPHILGKF HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager BJMEFCCEPHI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EAPDPHILGKF CIFPLKLELPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x591E170", Offset = "0x591CB70", VA = "0x18591E170")]
	public JEHPLMMOFBJ(EAPDPHILGKF HDJFKDANOCN, EntityManager BJMEFCCEPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x283B300", Offset = "0x2839D00", VA = "0x18283B300")]
	public bool JHJMAJMHPIL<T>(Entity GOANOLJBHPF) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x283AA70", Offset = "0x2839470", VA = "0x18283AA70")]
	public bool CJIEKLAJINA<T>(Entity GOANOLJBHPF, out T MNIAGKNOHEJ) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2839090", Offset = "0x2837A90", VA = "0x182839090")]
	public T BGJJEOLNAKF<T>(Entity GOANOLJBHPF) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x283AB00", Offset = "0x2839500", VA = "0x18283AB00")]
	private ComponentType HOMJGAIKHOC<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x591E0A0", Offset = "0x591CAA0", VA = "0x18591E0A0")]
	private ComponentType HOMJGAIKHOC(Type MAHAMGBPDNB)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class JDLAEJBBJBL
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	protected JDLAEJBBJBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class BLJDKLNLHEI<View, Data> : OOILAAHGBJC where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType MAPEHKPELKC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type PIEOJBJGLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x31954E0", Offset = "0x3193EE0", VA = "0x1831954E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type AGDJKMFMJAK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3194320", Offset = "0x3192D20", VA = "0x183194320", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int JOIACFGMHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x31931C0", Offset = "0x3191BC0", VA = "0x1831931C0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x31932F0", Offset = "0x3191CF0", VA = "0x1831932F0")]
	public Data JDBOIKEDIGA(Entity GOANOLJBHPF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3193280", Offset = "0x3191C80", VA = "0x183193280")]
	public Data GENJFMNIMOD(Entity GOANOLJBHPF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View FNHLLJHAFAK(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x24A6C90", Offset = "0x24A5690", VA = "0x1824A6C90", Slot = "15")]
	protected internal override T FNHLLJHAFAK<T>(Entity GOANOLJBHPF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x17A91C0", Offset = "0x17A7BC0", VA = "0x1817A91C0")]
	protected BLJDKLNLHEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class OOILAAHGBJC : GFMIPKBGENN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic DNHPFKCMFCK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager FLHDGCEBOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xB56960", Offset = "0xB55360", VA = "0x180B56960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type PIEOJBJGLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type AGDJKMFMJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int JOIACFGMHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type JNDGHMFAAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E50", Offset = "0x7C7850", VA = "0x1807C8E50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int FJAJNJOJKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5920140", Offset = "0x591EB40", VA = "0x185920140", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private FBPCPDKHEOJ[] KJBEKPAILNG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D80", Offset = "0x7C7780", VA = "0x1807C8D80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual FBPCPDKHEOJ[] KPGMMAHBADM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5920420", Offset = "0x591EE20", VA = "0x185920420", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CIODMMMNKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5920110", Offset = "0x591EB10", VA = "0x185920110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5920300", Offset = "0x591ED00", VA = "0x185920300")]
	public void JGKFDHOAMGH(EntityManager BJMEFCCEPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE00", Offset = "0x7DE800", VA = "0x1807DFE00")]
	protected GFMIPKBGENN HNIECDGAHLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T FNHLLJHAFAK<T>(Entity GOANOLJBHPF) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x59201B0", Offset = "0x591EBB0", VA = "0x1859201B0", Slot = "8")]
	public (uint, uint) EJEEHPHJHKE(Entity GOANOLJBHPF)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5920270", Offset = "0x591EC70", VA = "0x185920270", Slot = "9")]
	public bool GGJNAKDJGFB(Entity GOANOLJBHPF, (uint order, uint change) FMHBAJCDDEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	protected OOILAAHGBJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class NAEKMODAGEJ<Data> : PMOBPEKLJMO where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data JPMFPEEJFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x22FE350", Offset = "0x22FCD50", VA = "0x1822FE350", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x227CC10", Offset = "0x227B610", VA = "0x18227CC10", Slot = "8")]
	protected virtual bool GLGEGDNOAGK(ReadOnlySpan<Data> KPKJFELPMLM, MKAJIBPDGLA GMMMMEKOOIB, out ReadOnlySpan<byte> DBKEJGOGOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "9")]
	protected virtual bool JJMDHHBNBBO(int FMHBAJCDDEI, Span<Data> KPKJFELPMLM, in ReadOnlySpan<byte> DBKEJGOGOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x22FD9F0", Offset = "0x22FC3F0", VA = "0x1822FD9F0", Slot = "5")]
	internal sealed override bool GLGEGDNOAGK(ref Unity.Entities.Chunk MHMFPFMJMPM, int NNONLBIBKPL, MKAJIBPDGLA GMMMMEKOOIB, out ReadOnlySpan<byte> DBKEJGOGOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x22FE140", Offset = "0x22FCB40", VA = "0x1822FE140", Slot = "6")]
	internal sealed override bool JJMDHHBNBBO(int FMHBAJCDDEI, ref Unity.Entities.Chunk MHMFPFMJMPM, int NNONLBIBKPL, in ReadOnlySpan<byte> DBKEJGOGOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2800950", Offset = "0x27FF350", VA = "0x182800950")]
	protected global::KPIBGHOAFLA<Protobuf> NLDNKBPDGMH<Protobuf>(ReadOnlySpan<Data> KPKJFELPMLM) where Protobuf : IMessage, new()
	{
		return default(global::KPIBGHOAFLA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x28008C0", Offset = "0x27FF2C0", VA = "0x1828008C0")]
	protected global::BCFFFHOPDBB<Protobuf> EOHOEANBKAL<Protobuf>(ReadOnlySpan<byte> DBKEJGOGOOA, ReadOnlySpan<Data> KPKJFELPMLM, Action<Protobuf> DGAEKHOODJM) where Protobuf : IMessage, new()
	{
		return default(global::BCFFFHOPDBB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x17A91C0", Offset = "0x17A7BC0", VA = "0x1817A91C0")]
	protected NAEKMODAGEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class PMOBPEKLJMO
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int BNNADFINGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5920650", Offset = "0x591F050", VA = "0x185920650", Slot = "5")]
	internal virtual bool GLGEGDNOAGK(ref Unity.Entities.Chunk MHMFPFMJMPM, int NNONLBIBKPL, MKAJIBPDGLA GMMMMEKOOIB, out ReadOnlySpan<byte> DBKEJGOGOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "6")]
	internal virtual bool JJMDHHBNBBO(int FMHBAJCDDEI, ref Unity.Entities.Chunk MHMFPFMJMPM, int NNONLBIBKPL, in ReadOnlySpan<byte> DBKEJGOGOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	protected PMOBPEKLJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface MPBALJFINNN<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo AOLMNMNMECN(TFrom MNIAGKNOHEJ);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LCEJDFCCHBB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CPMCFNPMCON(T MNIAGKNOHEJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct PLOEGGAEOFJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::MPBALJFINNN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> ODCCKBFMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> DOJPKCJECCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap CKAPOBIDCEI;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct DONCNDCHFBG<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::MPBALJFINNN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> BBOGJNHFIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> DOJPKCJECCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap CKAPOBIDCEI;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct BNHDJHMMOPL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DLDBCDKDBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> ODCCKBFMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> DOJPKCJECCA;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2710650", Offset = "0x270F050", VA = "0x182710650", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct FGBDEMFIHCF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DLDBCDKDBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> ODCCKBFMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> JLFAGELNAGG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct DOOGACMAKBI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::MPBALJFINNN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> KMEGHGPDMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> DOJPKCJECCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap CKAPOBIDCEI;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct ANEJICPJKPK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JBHMOMKIBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> LDEKFDONKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> BOEJLOOMLNE;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct JBCHEEODLOO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JBHMOMKIBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> LDEKFDONKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> BOEJLOOMLNE;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x30B0870", Offset = "0x30AF270", VA = "0x1830B0870", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct AOMAKPLNLIH<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> ODCCKBFMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> JLFAGELNAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, OHKLLNGFCGP> JEFPNAKLJNI;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x35835C0", Offset = "0x3581FC0", VA = "0x1835835C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct MHHJCHEJDPE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::MPBALJFINNN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> ODCCKBFMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> JLFAGELNAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, OHKLLNGFCGP> JEFPNAKLJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap CKAPOBIDCEI;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct ECLPPPIDJJI<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::LCEJDFCCHBB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> ODCCKBFMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> JLFAGELNAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate CKAPOBIDCEI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct JMNMOMIHCGE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity JBHMOMKIBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> LDEKFDONKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> PDFGMEAAEHN;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x591E3A0", Offset = "0x591CDA0", VA = "0x18591E3A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct ECEGKKCAFEI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity JBHMOMKIBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> LDEKFDONKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> PDFGMEAAEHN;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x591D4F0", Offset = "0x591BEF0", VA = "0x18591D4F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class BEEPMMMBBIC
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class JEMEDAODDPC
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x283B340", Offset = "0x2839D40", VA = "0x18283B340")]
	public static bool OJEPJEJLOEG<T>(this NativeArray<Entity> LDEKFDONKGC, EntityManager BJMEFCCEPHI, Allocator GGPAKDMJHLJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class INLECEIFPGI
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class EFAHFLCFBGM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public EFAHFLCFBGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class KELEEJFOPMP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public KELEEJFOPMP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> IACLGAFKMOG;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x591E020", Offset = "0x591CA20", VA = "0x18591E020")]
	public INLECEIFPGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class JKAPJNOKJBH
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IBBPBAPHMBM
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct PEGHMJFEMNH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct OGHHIMIIEMN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal PEGHMJFEMNH<TFrom> ELGBIOMPEHN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator GGPAKDMJHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> APKDOIJAGNF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct BILABPAFGKK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct PGFLNJJPFJK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal BILABPAFGKK<TFrom> ELGBIOMPEHN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator GGPAKDMJHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> APKDOIJAGNF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct JGIKBFCOKAM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CABMCKLPFLP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal JGIKBFCOKAM<TFrom> ELGBIOMPEHN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator GGPAKDMJHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> APKDOIJAGNF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct FOHKBOALPBM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct JCBAMHCDPNA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal FOHKBOALPBM<TFrom> ELGBIOMPEHN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator GGPAKDMJHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> APKDOIJAGNF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NNEEPLAOMOD
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class AGCGMCJEKKK
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x23EA5A0", Offset = "0x23E8FA0", VA = "0x1823EA5A0")]
	public static NativeList<T> GDOEHKEIMOI<T>(this NativeArray<T> JCLJGOJIPLE, Allocator GGPAKDMJHLJ = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class JNHNPHPGPGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x25BF7F0", Offset = "0x25BE1F0", VA = "0x1825BF7F0")]
	public static NativeArray<T> MCMBHFLGIBA<T>(this NativeList<Entity> JCLJGOJIPLE, EntityManager BJMEFCCEPHI, Allocator GGPAKDMJHLJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x25BF5F0", Offset = "0x25BDFF0", VA = "0x1825BF5F0")]
	public static NativeArray<T> MCMBHFLGIBA<T>(this NativeArray<Entity> JCLJGOJIPLE, EntityManager BJMEFCCEPHI, Allocator GGPAKDMJHLJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class ACIKNNPNLOC
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct DECFOCFIJBG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct PKGBDKIJPFA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public DECFOCFIJBG<TFrom> APKDOIJAGNF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator GGPAKDMJHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> ODCCKBFMMCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct OAOJJCIGOBA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct KBLIKHAFBMP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public OAOJJCIGOBA<TFrom> APKDOIJAGNF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator GGPAKDMJHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> ODCCKBFMMCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct DIDEGMKEJJI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct BPPJGLNLFDJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public DIDEGMKEJJI<TFrom> APKDOIJAGNF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator GGPAKDMJHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> ODCCKBFMMCA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class MAFBNDJLKFO
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class FNDCHDLJDLC
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct FDGEPBLDGDG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator GGPAKDMJHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> ODCCKBFMMCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct BIKGLODIGCL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator GGPAKDMJHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> ODCCKBFMMCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct DAGMHCJJLED<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator GGPAKDMJHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> ODCCKBFMMCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct DLGOGDNINAL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator GGPAKDMJHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> ODCCKBFMMCA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class IPAGPLGKAFD
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class CCPLFDKGIGN
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1D48C80", Offset = "0x1D47680", VA = "0x181D48C80")]
	public static NativeList<Entity> KDNJJGPIHEF<T>(this NativeArray<Entity> LDEKFDONKGC, EntityManager BJMEFCCEPHI, Allocator GGPAKDMJHLJ = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class EEAIOHDDPON
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface NFIMJCECCGD
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface NJIADEOPPMO
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class NGOGKDJBBNA
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class JHNEOKILHHE
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x591E1C0", Offset = "0x591CBC0", VA = "0x18591E1C0")]
	public static bool MFOOAEIIAHL(Type MAHAMGBPDNB, Type HOENCEOBJJB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class DNHLJGMGIPP<Attribute, BaseClass> : global::DPMKFGOBEDP<BaseClass>, DLPKICFOGOL where Attribute : OLDJJMGINHK
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly KGOHPJFJCLE LHMILDDMKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string ANJJEPIBAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> MMKLEPMBIHB;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x32A0120", Offset = "0x329EB20", VA = "0x1832A0120")]
	public DNHLJGMGIPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x329FEC0", Offset = "0x329E8C0", VA = "0x18329FEC0", Slot = "4")]
	public bool GGIBFCBBJNK(int MDNDIFHMDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x329FB80", Offset = "0x329E580", VA = "0x18329FB80", Slot = "5")]
	public global::OKLNGFEDEOH<BaseClass> CIFAGNKPGGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x329FF20", Offset = "0x329E920", VA = "0x18329FF20", Slot = "7")]
	protected virtual bool MFOOAEIIAHL(Type MAHAMGBPDNB, int AGGCIHJOILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x329FAF0", Offset = "0x329E4F0", VA = "0x18329FAF0", Slot = "8")]
	protected virtual int CABIGFGOMPH(Type MAHAMGBPDNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x329FE30", Offset = "0x329E830", VA = "0x18329FE30")]
	public void DBHAPDCLOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x32A0020", Offset = "0x329EA20", VA = "0x1832A0020", Slot = "6")]
	public void OGMDKKEHOIN(Type MAHAMGBPDNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class OKLNGFEDEOH<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> NONGKMFEPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> CAAGOKBMALJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> BGLPEOPEDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2EB4C90", Offset = "0x2EB3690", VA = "0x182EB4C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4F90", Offset = "0x2EB3990", VA = "0x182EB4F90")]
	public OKLNGFEDEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2EB5120", Offset = "0x2EB3B20", VA = "0x182EB5120")]
	public OKLNGFEDEOH(int ADCMDGEMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4C10", Offset = "0x2EB3610", VA = "0x182EB4C10")]
	internal void CPLOAHMOJFD(int MDNDIFHMDOM, BaseClass OEJDFENKCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2802900", Offset = "0x2801300", VA = "0x182802900")]
	public bool JOJHMHDDBCC<T>(out BaseClass MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4EF0", Offset = "0x2EB38F0", VA = "0x182EB4EF0")]
	public bool JOJHMHDDBCC(Type NOIFPDMFLMJ, out BaseClass MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4BE0", Offset = "0x2EB35E0", VA = "0x182EB4BE0")]
	public bool BPAOFOODMJE(int MDNDIFHMDOM, out BaseClass MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2802820", Offset = "0x2801220", VA = "0x182802820")]
	public T IGLCLCPNGAM<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4EC0", Offset = "0x2EB38C0", VA = "0x182EB4EC0")]
	public BaseClass IGLCLCPNGAM(Type OBJJPOIFEAE)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class PBGGKPAHOPK : global::DNHLJGMGIPP<COOJPHDNGHI, JDLAEJBBJBL>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5920550", Offset = "0x591EF50", VA = "0x185920550")]
	public PBGGKPAHOPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class OPFKBDDHCAD : global::DNHLJGMGIPP<DMOBKPKAGOF, OOILAAHGBJC>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x59204E0", Offset = "0x591EEE0", VA = "0x1859204E0")]
	public OPFKBDDHCAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class DBJMILBCCEB : global::DNHLJGMGIPP<HNPKKIDOILC, PMOBPEKLJMO>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x591BF50", Offset = "0x591A950", VA = "0x18591BF50")]
	public DBJMILBCCEB()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[LOEOGANCBGC(EDPDLGMLNHJ.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> LJPCAFALCCO;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x897DB0", Offset = "0x8967B0", VA = "0x180897DB0")]
		private ComponentSystemTypes(List<Type> LJPCAFALCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x591BB50", Offset = "0x591A550", VA = "0x18591BB50")]
		public static void DBHAPDCLOEH(List<Type> LJPCAFALCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x591BBE0", Offset = "0x591A5E0", VA = "0x18591BBE0")]
		private void JGMAAOEIODP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x591BE20", Offset = "0x591A820", VA = "0x18591BE20")]
		private bool MFOOAEIIAHL(Type MAHAMGBPDNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x591BEA0", Offset = "0x591A8A0", VA = "0x18591BEA0")]
		private void MJMFCAHDKEL(Type MAHAMGBPDNB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class PMCACKOJIOD : FPJLAJEOELD
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5920610", Offset = "0x591F010", VA = "0x185920610", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase KPBIBFOBGME();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x59205C0", Offset = "0x591EFC0", VA = "0x1859205C0")]
	protected ComponentSystemBase CHJCPJNLCBN(params ComponentSystemBase[] DBKMNLNGAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2920920", Offset = "0x291F320", VA = "0x182920920")]
	protected ComponentSystemBase CHJCPJNLCBN<T>(params ComponentSystemBase[] DBKMNLNGAJC) where T : FPJLAJEOELD, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x29209C0", Offset = "0x291F3C0", VA = "0x1829209C0")]
	protected ComponentSystemBase MEILELPKDBL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x29209C0", Offset = "0x291F3C0", VA = "0x1829209C0")]
	protected ComponentSystemBase HMEHPGPIKGP<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	protected PMCACKOJIOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface DPMKFGOBEDP<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGIBFCBBJNK(int MDNDIFHMDOM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::OKLNGFEDEOH<BaseClass> CIFAGNKPGGI();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class FPJLAJEOELD : FMKOGOJMNNF
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x591D950", Offset = "0x591C350", VA = "0x18591D950", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public FPJLAJEOELD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class FOMCGHGDFHL : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x591D8A0", Offset = "0x591C2A0", VA = "0x18591D8A0")]
	public ComponentDataFromEntity BEFPNCFLPLK(int MDNDIFHMDOM, bool IJLDOICDBDC = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x591D940", Offset = "0x591C340", VA = "0x18591D940", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0")]
	protected FOMCGHGDFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class CGIMNOJBJNJ : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0")]
	protected CGIMNOJBJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class PPPEJONEMKB : FOMCGHGDFHL
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5920670", Offset = "0x591F070", VA = "0x185920670", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	protected void HKBANEKPIEA(string DBIMPNPPPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0")]
	protected PPPEJONEMKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class KOOCBEELIPK
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class FMKOGOJMNNF : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	protected FMKOGOJMNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[LOEOGANCBGC(EDPDLGMLNHJ.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5921780", Offset = "0x5920180", VA = "0x185921780")]
		public static ComponentSystemGroup[] OIICBFBJJCP(World HDJFKDANOCN, IPNNLFIHNAK MJBPOKJKHBJ = IPNNLFIHNAK.Default, bool JBOALKADFFF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5920F70", Offset = "0x591F970", VA = "0x185920F70")]
		private static Type[] DDDHJPEHBDL(IPNNLFIHNAK MJBPOKJKHBJ, bool JBOALKADFFF, ComponentSystemGroup[] NJKCMEBJENP, ComponentSystemGroup LPPHJCEGMJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5921410", Offset = "0x591FE10", VA = "0x185921410")]
		private static ComponentSystemGroup[] JBPFCBLNNPE(World HDJFKDANOCN, out ComponentSystemGroup LPPHJCEGMJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5920CF0", Offset = "0x591F6F0", VA = "0x185920CF0")]
		internal static bool CPMPGBKLAHP(IDCNBKCHOBE HLCFNPLAIJP, out CKNFIKGHKPF KLOJOODMOMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x59212D0", Offset = "0x591FCD0", VA = "0x1859212D0")]
		private static ComponentSystemGroup HDGHFDMBDEP(Type MAHAMGBPDNB, World HDJFKDANOCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5920BC0", Offset = "0x591F5C0", VA = "0x185920BC0")]
		private static ComponentSystemGroup[] BIKDCKLIEHH(Type[] LJPCAFALCCO, World HDJFKDANOCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x59206A0", Offset = "0x591F0A0", VA = "0x1859206A0")]
		internal static void AAEHDPKCGFH(World HDJFKDANOCN, Type[] HFNGHKNKLPH, ComponentSystemGroup[] NJKCMEBJENP, ComponentSystemGroup LPPHJCEGMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5921720", Offset = "0x5920120", VA = "0x185921720")]
		internal static bool MKMFKFPHIPJ(ComponentSystemBase GFDIEIODBJH, ComponentSystemGroup[] NJKCMEBJENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x59213B0", Offset = "0x591FDB0", VA = "0x1859213B0")]
		private static void IPLMIBKNPBG(ComponentSystemGroup[] NJKCMEBJENP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct MGGCFIAIFPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> KLEHCLEOBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> DBKMNLNGAJC;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x771A10", Offset = "0x770410", VA = "0x180771A10")]
	public MGGCFIAIFPG(Dictionary<Type, List<Type>> KLEHCLEOBLB, HashSet<Type> DBKMNLNGAJC)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[LOEOGANCBGC(EDPDLGMLNHJ.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class ECDJCCFEHKN : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
			[DebuggerHidden]
			public ECDJCCFEHKN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x591D410", Offset = "0x591BE10", VA = "0x18591D410", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x591D170", Offset = "0x591BB70", VA = "0x18591D170", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x591D4A0", Offset = "0x591BEA0", VA = "0x18591D4A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x591D3D0", Offset = "0x591BDD0", VA = "0x18591D3D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x591D320", Offset = "0x591BD20", VA = "0x18591D320", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x591D320", Offset = "0x591BD20", VA = "0x18591D320", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct FPJPNLDMGFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type KONJHJHDFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private IPNNLFIHNAK MJBPOKJKHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool POCDAJMIPCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool AEPHJLJBEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool JBOALKADFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> HFLDJBLGLKE;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5922250", Offset = "0x5920C50", VA = "0x185922250")]
		public static RRFilterWorldSystems GANMJPNFBJN()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5921A40", Offset = "0x5920440", VA = "0x185921A40")]
		public RRFilterWorldSystems CPNJJPOEPKF(IPNNLFIHNAK HLCFNPLAIJP)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x59219F0", Offset = "0x59203F0", VA = "0x1859219F0")]
		public RRFilterWorldSystems CBNPPCMDGNM(IEnumerable<Type> LJPCAFALCCO)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5922270", Offset = "0x5920C70", VA = "0x185922270")]
		public RRFilterWorldSystems HPLKGDBKMCJ(bool DAHJHNDHAJH)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5921A30", Offset = "0x5920430", VA = "0x185921A30")]
		public RRFilterWorldSystems CONNHOLNMGP(bool HBEFHIDGODN)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5922280", Offset = "0x5920C80", VA = "0x185922280")]
		public MGGCFIAIFPG IHHNAHDMAAI(Type[] BLNGCIAEIDK)
		{
			return default(MGGCFIAIFPG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5922750", Offset = "0x5921150", VA = "0x185922750")]
		[IteratorStateMachine(typeof(ECDJCCFEHKN))]
		internal IEnumerable<Type> MHEEJOGMOBA(IEnumerable<Type> LJPCAFALCCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5922310", Offset = "0x5920D10", VA = "0x185922310")]
		internal Dictionary<Type, List<Type>> JAEJMHCBKLO(IEnumerable<Type> LJPCAFALCCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x59218E0", Offset = "0x59202E0", VA = "0x1859218E0")]
		private void BAKENNFGDNL(Dictionary<Type, List<Type>> PFGJBHEKNMH, Type MAHAMGBPDNB, Type EJPFCFELGHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5921A50", Offset = "0x5920450", VA = "0x185921A50")]
		internal HashSet<Type> DPKOFIEOGLE(IEnumerable<Type> NJKCMEBJENP, Dictionary<Type, List<Type>> INLJGFGAJKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5921C10", Offset = "0x5920610", VA = "0x185921C10")]
		internal bool EKIEMJDCBLG(Type MAHAMGBPDNB, IPNNLFIHNAK MJBPOKJKHBJ, bool JBOALKADFFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x59225F0", Offset = "0x5920FF0", VA = "0x1859225F0")]
		[CompilerGenerated]
		internal static void LKPHOOELPNN(Type MAHAMGBPDNB, ref FPJPNLDMGFO P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class KNLBHDHFMMG
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool AAKELOLAKFK;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x591E790", Offset = "0x591D190", VA = "0x18591E790")]
	public static void JGKFDHOAMGH(bool GONNPACEKOP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x591E7F0", Offset = "0x591D1F0", VA = "0x18591E7F0")]
	private static void NJBABIBNENG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class GJNCGBOPJCD
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x591DC00", Offset = "0x591C600", VA = "0x18591DC00")]
	public static ulong EANDJMMNJBP(Type MAHAMGBPDNB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x591DC30", Offset = "0x591C630", VA = "0x18591DC30")]
	public static ulong EANDJMMNJBP(string ODAEIEFJEKN)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[LOEOGANCBGC(EDPDLGMLNHJ.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct FIBODPMLELG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong CCPNCHIJADL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong PHFPNGODALI;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xEAB980", Offset = "0xEAA380", VA = "0x180EAB980")]
			public FIBODPMLELG(ulong LGPFAHCJAEI, ulong DJCFOPJPEBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x591D7A0", Offset = "0x591C1A0", VA = "0x18591D7A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> LPOEBKPIKBN;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static FIBODPMLELG[] PMPMNLKPJAH;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool AAKELOLAKFK;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5923440", Offset = "0x5921E40", VA = "0x185923440")]
		public static ulong LMILEHPCJOH(int MDNDIFHMDOM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x59231A0", Offset = "0x5921BA0", VA = "0x1859231A0")]
		public static int JGBBCALAKME(ulong DJCFOPJPEBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5923250", Offset = "0x5921C50", VA = "0x185923250")]
		public static void JGKFDHOAMGH(bool GONNPACEKOP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x59229B0", Offset = "0x59213B0", VA = "0x1859229B0")]
		private static void BCFANPLLLGP(int PNFEKMHIIEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5922DA0", Offset = "0x59217A0", VA = "0x185922DA0")]
		private static void IHPFJIGBMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5922CC0", Offset = "0x59216C0", VA = "0x185922CC0")]
		private static FIBODPMLELG HPPPMGAMKJP(Type MAHAMGBPDNB)
		{
			return default(FIBODPMLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x59234A0", Offset = "0x5921EA0", VA = "0x1859234A0")]
		private static ulong MDCLNMECFOE(Type MAHAMGBPDNB, ulong DJCFOPJPEBB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5922AA0", Offset = "0x59214A0", VA = "0x185922AA0")]
		private static void HDGJNBLPLAJ(in FIBODPMLELG DCLIECFOFJF, TypeManager.TypeInfo BABJDMEGMBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x59228B0", Offset = "0x59212B0", VA = "0x1859228B0")]
		private static void BBGAOMEIFMD(FIBODPMLELG BABJDMEGMBP, int MDNDIFHMDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x59230C0", Offset = "0x5921AC0", VA = "0x1859230C0")]
		private static void JABDLEJADPI(FIBODPMLELG BABJDMEGMBP, int MDNDIFHMDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5923510", Offset = "0x5921F10", VA = "0x185923510")]
		private static FIBODPMLELG MMJECJMKHLD(int MDNDIFHMDOM)
		{
			return default(FIBODPMLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5922A90", Offset = "0x5921490", VA = "0x185922A90")]
		private static int GKDNIIKKPOJ(int MDNDIFHMDOM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class NGOPJDGHMME
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly OPFKBDDHCAD CNKCCNFILFF;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly DBJMILBCCEB MHLDDPIHIOH;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly PBGGKPAHOPK LOFDADCCAGL;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> BDBOMPMEAED;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool AAKELOLAKFK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::DPMKFGOBEDP<OOILAAHGBJC> PFKCHOLEJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x591FE80", Offset = "0x591E880", VA = "0x18591FE80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::DPMKFGOBEDP<PMOBPEKLJMO> MAELBLDECJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x591FE20", Offset = "0x591E820", VA = "0x18591FE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::DPMKFGOBEDP<JDLAEJBBJBL> NKGPKAIHGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x591F890", Offset = "0x591E290", VA = "0x18591F890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x591F970", Offset = "0x591E370", VA = "0x18591F970")]
	public static void JGKFDHOAMGH(bool GONNPACEKOP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x591F8F0", Offset = "0x591E2F0", VA = "0x18591F8F0")]
	public static Type[] HGJLKGMCGOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class BIPPELCHGIA
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> CEPDAAGFLMJ;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool AAKELOLAKFK;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x591B880", Offset = "0x591A280", VA = "0x18591B880")]
	public static int EJEEHPHJHKE(int MDNDIFHMDOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x591B970", Offset = "0x591A370", VA = "0x18591B970")]
	public static void JGKFDHOAMGH(bool GONNPACEKOP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x591B600", Offset = "0x591A000", VA = "0x18591B600")]
	private static void BNLFGDOHMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x591B920", Offset = "0x591A320", VA = "0x18591B920")]
	private static int HGHBMIBBPJG(Type MAHAMGBPDNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x591BA10", Offset = "0x591A410", VA = "0x18591BA10")]
	private static void NMFIICNHENP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class EAPDPHILGKF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World LMPFDLJPFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly JEHPLMMOFBJ OEJDFENKCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] NJKCMEBJENP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World CIFPLKLELPL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World HPHMIKCABBH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager FLHDGCEBOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x898CE0", Offset = "0x8976E0", VA = "0x180898CE0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public JEHPLMMOFBJ MLKKJKMLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::OKLNGFEDEOH<OOILAAHGBJC> PFKCHOLEJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::OKLNGFEDEOH<PMOBPEKLJMO> MAELBLDECJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6C8590", Offset = "0x6C6F90", VA = "0x1806C8590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::OKLNGFEDEOH<JDLAEJBBJBL> NKGPKAIHGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6C8580", Offset = "0x6C6F80", VA = "0x1806C8580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6C85A0", Offset = "0x6C6FA0", VA = "0x1806C85A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x898D20", Offset = "0x897720", VA = "0x180898D20")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] JHHHAGBCJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x591C290", Offset = "0x591AC90", VA = "0x18591C290")]
	public static EAPDPHILGKF CALOAGMKPKG(string ANJJEPIBAGI, IDCNBKCHOBE HLCFNPLAIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x591CC50", Offset = "0x591B650", VA = "0x18591CC50")]
	public EAPDPHILGKF(string ANJJEPIBAGI, IDCNBKCHOBE HLCFNPLAIJP = IDCNBKCHOBE.Simulation, IPNNLFIHNAK MJBPOKJKHBJ = IPNNLFIHNAK.Default, bool GONNPACEKOP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x591C270", Offset = "0x591AC70", VA = "0x18591C270")]
	public ComponentSystemBase BODJNFNOMLJ(Type MAHAMGBPDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x22ECC10", Offset = "0x22EB610", VA = "0x1822ECC10")]
	public T BODJNFNOMLJ<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x591CA80", Offset = "0x591B480", VA = "0x18591CA80")]
	public void LCLAPJEDGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x591C9C0", Offset = "0x591B3C0", VA = "0x18591C9C0")]
	public void JINIHIIGLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x591C210", Offset = "0x591AC10", VA = "0x18591C210")]
	public void BJDNGOPDGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x591C820", Offset = "0x591B220", VA = "0x18591C820")]
	public void HGPNMBAGCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x591C3F0", Offset = "0x591ADF0", VA = "0x18591C3F0")]
	public void DGNACJGHDGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x591C960", Offset = "0x591B360", VA = "0x18591C960")]
	public void ILPIEODEJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x591CBF0", Offset = "0x591B5F0", VA = "0x18591CBF0")]
	public void PNPBLGOFKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x591C790", Offset = "0x591B190", VA = "0x18591C790")]
	public void GOAGLIPAAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x591C390", Offset = "0x591AD90", VA = "0x18591C390")]
	public void DGKHDDCFDKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x591CA20", Offset = "0x591B420", VA = "0x18591CA20")]
	public void KGANOIMGCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x591C880", Offset = "0x591B280", VA = "0x18591C880")]
	internal void IKOPMJMGEAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x591C310", Offset = "0x591AD10", VA = "0x18591C310")]
	private bool CJFPOLAMLEC(ComponentSystemGroup EAGMPINEKBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x591C4C0", Offset = "0x591AEC0", VA = "0x18591C4C0")]
	private void ENFHBLPDEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x591CAE0", Offset = "0x591B4E0", VA = "0x18591CAE0")]
	private ComponentSystemGroup[] OIICBFBJJCP(IPNNLFIHNAK MJBPOKJKHBJ, bool JBOALKADFFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x591C450", Offset = "0x591AE50", VA = "0x18591C450", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum IDCNBKCHOBE
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
public sealed class BIPJPNJHEKJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public IPNNLFIHNAK BKNIGAEJCBG;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum IPNNLFIHNAK
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
public interface CKNFIKGHKPF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type FCCCLFMKNHM
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] MOMFGDPMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class NBBHFHPMMCD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool AHBDANOJJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	protected NBBHFHPMMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class NEMIBAOEOBF : NBBHFHPMMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public NEMIBAOEOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class KCNPDCCNDNC : NBBHFHPMMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public KCNPDCCNDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class EGLPLOIDBAA : NBBHFHPMMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public EGLPLOIDBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class IELIJNMCAKM : NBBHFHPMMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public IELIJNMCAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class GEFAPMJJHKL : NBBHFHPMMCD
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public GEFAPMJJHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class GFIDBFKGNMD : NBBHFHPMMCD
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public GFIDBFKGNMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class DMPHECIDDCJ : NBBHFHPMMCD
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public DMPHECIDDCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class KOCBDEHJFOP : NBBHFHPMMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public KOCBDEHJFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class BBBJKGPMKEI : NBBHFHPMMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public BBBJKGPMKEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class PDIHPADFJCF : DDJMBLPHHIF
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public PDIHPADFJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class CAMFPPPODPD : DDJMBLPHHIF
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public CAMFPPPODPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class NGKCFDDPEOF : DDJMBLPHHIF
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public NGKCFDDPEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class AIEDIMOOFMM : DDJMBLPHHIF
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public AIEDIMOOFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[PNKDNOBPNFK(EIJAKMAIFNG.Application)]
public class DDJMBLPHHIF : NBBHFHPMMCD
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool AHBDANOJJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x591B380", Offset = "0x5919D80", VA = "0x18591B380")]
	public DDJMBLPHHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class EFMPJBNPDLE : AGCFOLLKBED
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public EFMPJBNPDLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class HCGKONBIEIL
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void FCBEPBDJLOH<From, To>(From APKDOIJAGNF, ref To DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class NPJFLFAIAHM<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static FCBEPBDJLOH<From, To> MLFNLBFGCIN;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public NPJFLFAIAHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x591DCF0", Offset = "0x591C6F0", VA = "0x18591DCF0")]
	static HCGKONBIEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x222A180", Offset = "0x2228B80", VA = "0x18222A180")]
	public static void MLBNPMKOLIB<T>(FCBEPBDJLOH<T, T> OJAMOBNEIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x222A010", Offset = "0x2228A10", VA = "0x18222A010")]
	public static void MLBNPMKOLIB<From, To>(FCBEPBDJLOH<From, To> OJAMOBNEIBE, FCBEPBDJLOH<To, From> PIAMEADCPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x222A0A0", Offset = "0x2228AA0", VA = "0x18222A0A0")]
	public static void MLBNPMKOLIB<From, To>(FCBEPBDJLOH<From, To> MLFNLBFGCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE4A0", Offset = "0x2DCCEA0", VA = "0x182DCE4A0")]
	public static FCBEPBDJLOH<From, To> HNLKMENLEBO<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2DCB090", Offset = "0x2DC9A90", VA = "0x182DCB090")]
	public static void ADJPNCFFMOF<From, To>(From APKDOIJAGNF, ref To DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class MKAJIBPDGLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> DOHHLFNLMDG;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xCCCDD0", Offset = "0xCCB7D0", VA = "0x180CCCDD0")]
	public MKAJIBPDGLA(NativeArray<EntityRemapUtility.EntityRemapInfo> DOHHLFNLMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9C20", Offset = "0x2AE8620", VA = "0x182AE9C20")]
	public Entity CCGHCELGIOG(Entity MMPIIAHIKHE)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class DNLDNMLCEDM
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> NOHEEBPPAJA;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x591C020", Offset = "0x591AA20", VA = "0x18591C020")]
	public static bool BGHHEACPEED(ulong NFFMFBOGLMH, uint FMHBAJCDDEI, out string ANJJEPIBAGI)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct IFBAMGGALCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int FOHLPAKJEGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int BNNADFINGPC;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x6E2050", Offset = "0x6E0A50", VA = "0x1806E2050")]
			public IFBAMGGALCJ(int GFDMFLGCBKB, int FMHBAJCDDEI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct KJFNABCLPAA
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch ENOCBGFIEFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long MMNLBEPFGGE;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long AJDCILAOBKK
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x591E6C0", Offset = "0x591D0C0", VA = "0x18591E6C0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long EBNNAEDMKAA
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x591E720", Offset = "0x591D120", VA = "0x18591E720")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x591E600", Offset = "0x591D000", VA = "0x18591E600")]
			public static KJFNABCLPAA DAFLDHNIGKO()
			{
				return default(KJFNABCLPAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct LLIHNHCDPAK : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct LJKEIOJIIMP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* CHCFIHJDHBI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly OEBFMIPHJDH.INCAMDAEDOL.KMDFJLOGNFA FHIKFALMABG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly MKAJIBPDGLA GMMMMEKOOIB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::OKLNGFEDEOH<PMOBPEKLJMO> NMBOIKOFMEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int NNONLBIBKPL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int FCHLMALIADD;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x591EA20", Offset = "0x591D420", VA = "0x18591EA20")]
				public unsafe LJKEIOJIIMP(Unity.Entities.Archetype* CHCFIHJDHBI, OEBFMIPHJDH.INCAMDAEDOL.KMDFJLOGNFA FHIKFALMABG, MKAJIBPDGLA GMMMMEKOOIB, global::OKLNGFEDEOH<PMOBPEKLJMO> NMBOIKOFMEF, int NNONLBIBKPL, int FCHLMALIADD = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x591E9D0", Offset = "0x591D3D0", VA = "0x18591E9D0")]
				public LJKEIOJIIMP(in LJKEIOJIIMP NIPBPKPBPPP, int FCHLMALIADD)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly LJKEIOJIIMP[] KPKJFELPMLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] FDPLDDEPPLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int LLICKKBOPEK;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x591F160", Offset = "0x591DB60", VA = "0x18591F160")]
			public LLIHNHCDPAK(LJKEIOJIIMP[] KPKJFELPMLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x591EA80", Offset = "0x591D480", VA = "0x18591EA80", Slot = "4")]
			public void Invoke(int GFDMFLGCBKB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x591EAE0", Offset = "0x591D4E0", VA = "0x18591EAE0")]
			private void JIIJCNOHMFK(in LJKEIOJIIMP NIPBPKPBPPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x591EE90", Offset = "0x591D890", VA = "0x18591EE90")]
			private static void NLMPAKMKEKD(in LJKEIOJIIMP NIPBPKPBPPP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class FMHCACHHDPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public OEBFMIPHJDH asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::OKLNGFEDEOH<PMOBPEKLJMO> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public FMHCACHHDPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x591D830", Offset = "0x591C230", VA = "0x18591D830")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class HOPHPCJPCMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public OEBFMIPHJDH.INCAMDAEDOL.KMDFJLOGNFA srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public FMHCACHHDPL CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public HOPHPCJPCMA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class BAEJBJNMEKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public HOPHPCJPCMA CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public BAEJBJNMEKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x591B4E0", Offset = "0x5919EE0", VA = "0x18591B4E0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly KGOHPJFJCLE PCAOIFLAMFM;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly KGOHPJFJCLE HAJHOJLEGGB;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly KGOHPJFJCLE ONFEMCOBFDP;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly KGOHPJFJCLE NHBFGLLNFPH;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool AFFLNDOANHO;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static OEBFMIPHJDH.INCAMDAEDOL.GMDGLDFDKBE JBEFCOLJKLM;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x59262B0", Offset = "0x5924CB0", VA = "0x1859262B0")]
		private unsafe static bool MIODMLINLBB(Unity.Entities.Archetype* COAKPOHIAFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5924EA0", Offset = "0x59238A0", VA = "0x185924EA0")]
		internal unsafe static Unity.Entities.Archetype*[] FCACEKLMFHE(ref Unity.Entities.EntityComponentStore EKPAAPEDOLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5924DE0", Offset = "0x59237E0", VA = "0x185924DE0")]
		public static void EOPJHDNOGBH(EAPDPHILGKF HDJFKDANOCN, out ByteString DBKEJGOGOOA, out NativeArray<EntityRemapUtility.EntityRemapInfo> PEBFJPNHLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x59263C0", Offset = "0x5924DC0", VA = "0x1859263C0")]
		internal static void MPANNFBNCOC(EAPDPHILGKF HDJFKDANOCN, OEBFMIPHJDH FLIDLOFJMMO, out NativeArray<EntityRemapUtility.EntityRemapInfo> PEBFJPNHLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5925080", Offset = "0x5923A80", VA = "0x185925080")]
		private unsafe static UnsafeHashMap<ulong, IFBAMGGALCJ> FJDGGKLEIGG(Unity.Entities.Archetype*[] EBGMKLFMMCK)
		{
			return default(UnsafeHashMap<ulong, IFBAMGGALCJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5925A50", Offset = "0x5924450", VA = "0x185925A50")]
		private static void KLMAHJONPEF(OEBFMIPHJDH FLIDLOFJMMO, UnsafeHashMap<ulong, IFBAMGGALCJ> GJPCFNDCOEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5926AF0", Offset = "0x59254F0", VA = "0x185926AF0")]
		private unsafe static void OOAIBMLKCEJ(OEBFMIPHJDH FLIDLOFJMMO, Unity.Entities.Archetype*[] EBGMKLFMMCK, UnsafeHashMap<ulong, IFBAMGGALCJ> GJPCFNDCOEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5925310", Offset = "0x5923D10", VA = "0x185925310")]
		private unsafe static int IHBGEOFIDEI(Unity.Entities.Archetype*[] EBGMKLFMMCK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5925630", Offset = "0x5924030", VA = "0x185925630")]
		private unsafe static void KDKBJFDKMED(OEBFMIPHJDH FLIDLOFJMMO, Unity.Entities.Archetype*[] EBGMKLFMMCK, global::OKLNGFEDEOH<PMOBPEKLJMO> NMBOIKOFMEF, NativeArray<EntityRemapUtility.EntityRemapInfo> PEBFJPNHLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5926E20", Offset = "0x5925820", VA = "0x185926E20")]
		private static NativeArray<int> PCJFIDKHCPM(OEBFMIPHJDH FLIDLOFJMMO)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5923630", Offset = "0x5922030", VA = "0x185923630")]
		private static Memory<EntityArchetype> AAOFMBGHCGN(OEBFMIPHJDH FLIDLOFJMMO, NativeArray<int> LJPCAFALCCO, EntityManager BJMEFCCEPHI, out int LMNEEDEHLHA, out int DNJBLGNNBGD)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5925C00", Offset = "0x5924600", VA = "0x185925C00")]
		private unsafe static void LAOMEDLLLFN(Unity.Entities.Chunk* DNHJEGAFDJP, ReadOnlySpan<byte> DBKEJGOGOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5924120", Offset = "0x5922B20", VA = "0x185924120")]
		private static void CIBJGEAPAJB(OEBFMIPHJDH FLIDLOFJMMO, NativeArray<int> LJPCAFALCCO, Span<EntityArchetype> EBGMKLFMMCK, EntityManager BJMEFCCEPHI, global::OKLNGFEDEOH<PMOBPEKLJMO> NMBOIKOFMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x59240A0", Offset = "0x5922AA0", VA = "0x1859240A0")]
		private unsafe static void BLAPIJGAANE(Unity.Entities.Chunk* MHMFPFMJMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x59249F0", Offset = "0x59233F0", VA = "0x1859249F0")]
		private unsafe static void DHOOGBFBFNK(OEBFMIPHJDH.INCAMDAEDOL.KMDFJLOGNFA CHCFIHJDHBI, int GEBBIKJMJGM, int JDDEKLOIOMG, Unity.Entities.Chunk* DNHJEGAFDJP, OEBFMIPHJDH FLIDLOFJMMO, NativeArray<int> LJPCAFALCCO, global::OKLNGFEDEOH<PMOBPEKLJMO> NMBOIKOFMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x59239C0", Offset = "0x59223C0", VA = "0x1859239C0")]
		public static void AKGEPDOBLBB(EAPDPHILGKF HDJFKDANOCN, in ByteString DBKEJGOGOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5923A50", Offset = "0x5922450", VA = "0x185923A50")]
		public static void AKGEPDOBLBB(EntityManager BJMEFCCEPHI, global::OKLNGFEDEOH<PMOBPEKLJMO> NMBOIKOFMEF, in ByteString DBKEJGOGOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5925FF0", Offset = "0x59249F0", VA = "0x185925FF0")]
		private static bool MAHFOBHJEHM(Type MAHAMGBPDNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5925380", Offset = "0x5923D80", VA = "0x185925380")]
		private static void IIDDINEFOJJ(TypeManager.TypeInfo BABJDMEGMBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5924860", Offset = "0x5923260", VA = "0x185924860")]
		private unsafe static int DFHIJMFCNPO(Unity.Entities.Archetype*[] EBGMKLFMMCK, NativeArray<EntityRemapUtility.EntityRemapInfo> PEBFJPNHLBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5924D00", Offset = "0x5923700", VA = "0x185924D00")]
		private static int EJEEHPHJHKE(int MDNDIFHMDOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5925F50", Offset = "0x5924950", VA = "0x185925F50")]
		private static ulong LMILEHPCJOH(int MDNDIFHMDOM)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class NEGILCCKBHE
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x591F2B0", Offset = "0x591DCB0", VA = "0x18591F2B0")]
	private unsafe static Span<byte> HIBEJALEDPC(Unity.Entities.Chunk* MHMFPFMJMPM, int NNONLBIBKPL)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2BF14B0", Offset = "0x2BEFEB0", VA = "0x182BF14B0")]
	public unsafe static Span<T> APBJOLBNLMN<T>(Unity.Entities.Chunk* MHMFPFMJMPM, int NNONLBIBKPL)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8590", Offset = "0x2BE6F90", VA = "0x182BE8590")]
	public static Span<T> APBJOLBNLMN<T>(this ref Unity.Entities.Chunk MHMFPFMJMPM, int NNONLBIBKPL)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x591F450", Offset = "0x591DE50", VA = "0x18591F450")]
	public unsafe static Span<Entity> KOIKOMPDAFI(Unity.Entities.Chunk* MHMFPFMJMPM)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x591F4C0", Offset = "0x591DEC0", VA = "0x18591F4C0")]
	public unsafe static void NMFIICNHENP(Unity.Entities.Chunk* MHMFPFMJMPM, int NNONLBIBKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x591F760", Offset = "0x591E160", VA = "0x18591F760")]
	public static Entity OGNJBAKLCFH(this EntityQuery CAMLCFELNDE)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : NMOBLBLJIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x59272F0", Offset = "0x5925CF0", VA = "0x1859272F0", Slot = "4")]
		public sealed override void DBHAPDCLOEH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
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
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
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

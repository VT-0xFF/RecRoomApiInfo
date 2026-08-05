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
		[Cpp2IlInjected.Address(RVA = "0x5E97420", Offset = "0x5E96220", VA = "0x185E97420")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E98810", Offset = "0x5E97610", VA = "0x185E98810")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E98880", Offset = "0x5E97680", VA = "0x185E98880")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A1ABC0", Offset = "0x3A199C0", VA = "0x183A1ABC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x21ACCD0", Offset = "0x21ABAD0", VA = "0x1821ACCD0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21AC500", Offset = "0x21AB300", VA = "0x1821AC500")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21AC600", Offset = "0x21AB400", VA = "0x1821AC600")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21ACA00", Offset = "0x21AB800", VA = "0x1821ACA00")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E988A0", Offset = "0x5E976A0", VA = "0x185E988A0")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NHHEAJIJJOH<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BKJEDHIBOPD : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::NHHEAJIJJOH<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7621D0", Offset = "0x760FD0", VA = "0x1807621D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C9A310", Offset = "0x2C99110", VA = "0x182C9A310", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1D036E0", Offset = "0x1D024E0", VA = "0x181D036E0")]
		[DebuggerHidden]
		public BKJEDHIBOPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A130", Offset = "0x2C98F30", VA = "0x182C9A130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A2D0", Offset = "0x2C990D0", VA = "0x182C9A2D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> BMOFALKJPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream KHIILPEBNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream HGGCMNLJFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf CEDANDKJJLH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int GOGPPCBDCFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x740010", Offset = "0x73EE10", VA = "0x180740010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x31B71F0", Offset = "0x31B5FF0", VA = "0x1831B71F0")]
	private NHHEAJIJJOH(byte[] MMBEBPNKEHD, Action<Protobuf> BMOFALKJPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1BF7830", Offset = "0x1BF6630", VA = "0x181BF7830")]
	public static global::NHHEAJIJJOH<Protobuf> CJALKNOJAHB<Data>(ReadOnlySpan<byte> AAOFEOFDGLE, ReadOnlySpan<Data> BNPIGAGGDHK, Action<Protobuf> BMOFALKJPMP)
	{
		return default(global::NHHEAJIJJOH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x31B7060", Offset = "0x31B5E60", VA = "0x1831B7060", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x31B70A0", Offset = "0x31B5EA0", VA = "0x1831B70A0", Slot = "4")]
	[IteratorStateMachine(typeof(global::NHHEAJIJJOH<>.BKJEDHIBOPD))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x31B71A0", Offset = "0x31B5FA0", VA = "0x1831B71A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NENFILFCLGE<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] MMBEBPNKEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf CEDANDKJJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream KHIILPEBNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream GIEFGDCLDAH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x31B13D0", Offset = "0x31B01D0", VA = "0x1831B13D0")]
	private NENFILFCLGE(byte[] MMBEBPNKEHD, in Protobuf CEDANDKJJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1BF3550", Offset = "0x1BF2350", VA = "0x181BF3550")]
	public static global::NENFILFCLGE<Protobuf> CJALKNOJAHB<T>(ReadOnlySpan<T> BNPIGAGGDHK)
	{
		return default(global::NENFILFCLGE<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x31B13A0", Offset = "0x31B01A0", VA = "0x1831B13A0")]
	public void KIGPLHGLLJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x31B1310", Offset = "0x31B0110", VA = "0x1831B1310")]
	public ByteString HNEOOALIALE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x31B11E0", Offset = "0x31AFFE0", VA = "0x1831B11E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PLOOMLDFCGC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream KHIILPEBNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream HGGCMNLJFML;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C6A0", Offset = "0x5E9B4A0", VA = "0x185E9C6A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LHGKDNNADJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] MMBEBPNKEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream KHIILPEBNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream GIEFGDCLDAH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A070", Offset = "0x5E98E70", VA = "0x185E9A070", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JEBOOPBJIGB
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public static void KPEGHFBJDEB(this FGEMECIGOCC EKOKIILLNMO, NativeArray<Entity> KMDDIGFEEEI, [Optional][CallerFilePath] string DPEGDJOIEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public static void KPEGHFBJDEB(this FGEMECIGOCC EKOKIILLNMO, string ICIEGOLHGJN, NativeArray<Entity> KMDDIGFEEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public static void KPEGHFBJDEB(this FGEMECIGOCC EKOKIILLNMO, string DPEGDJOIEIC, NativeArray<Entity> KMDDIGFEEEI, bool GCFKLPPHEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public static void MDKGONCEBCH(this FGEMECIGOCC EKOKIILLNMO, NativeArray<Entity> KMDDIGFEEEI, NativeArray<Entity> ODLKGBFEGFG, [Optional][CallerFilePath] string DPEGDJOIEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public static void MDKGONCEBCH(this FGEMECIGOCC EKOKIILLNMO, string DPEGDJOIEIC, NativeArray<Entity> KMDDIGFEEEI, NativeArray<Entity> ODLKGBFEGFG, bool GCFKLPPHEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x277E110", Offset = "0x277CF10", VA = "0x18277E110")]
	public static void EOGDGGDMBEP<T>(this FGEMECIGOCC EKOKIILLNMO, string ICIEGOLHGJN, NativeArray<Entity> KMDDIGFEEEI, NativeList<T> MMJOHADFCHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x277E0D0", Offset = "0x277CED0", VA = "0x18277E0D0")]
	public static void EOGDGGDMBEP<T>(this FGEMECIGOCC EKOKIILLNMO, string ICIEGOLHGJN, NativeArray<Entity> KMDDIGFEEEI, NativeArray<T> MMJOHADFCHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public static void EOGDGGDMBEP<T>(this FGEMECIGOCC EKOKIILLNMO, string DPEGDJOIEIC, NativeArray<Entity> KMDDIGFEEEI, NativeArray<T> MMJOHADFCHO, bool GCFKLPPHEMH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x277E1D0", Offset = "0x277CFD0", VA = "0x18277E1D0")]
	public static void LGEDIPDLKOO<T>(this FGEMECIGOCC EKOKIILLNMO, NativeList<T> MMJOHADFCHO, [Optional][CallerFilePath] string DPEGDJOIEIC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x277E1A0", Offset = "0x277CFA0", VA = "0x18277E1A0")]
	public static void LGEDIPDLKOO<T>(this FGEMECIGOCC EKOKIILLNMO, NativeArray<T> MMJOHADFCHO, [Optional][CallerFilePath] string DPEGDJOIEIC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public static void LGEDIPDLKOO<T>(this FGEMECIGOCC EKOKIILLNMO, string DPEGDJOIEIC, NativeArray<T> MMJOHADFCHO, bool GCFKLPPHEMH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public static void KBDMMEKLHAM(this FGEMECIGOCC EKOKIILLNMO, EntityQuery NOJJNNFMBAH, [Optional][CallerFilePath] string DPEGDJOIEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public static void KBDMMEKLHAM(this FGEMECIGOCC EKOKIILLNMO, string ICIEGOLHGJN, EntityQuery NOJJNNFMBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public static void KBDMMEKLHAM(this FGEMECIGOCC EKOKIILLNMO, string DPEGDJOIEIC, EntityQuery NOJJNNFMBAH, bool GCFKLPPHEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x277E0A0", Offset = "0x277CEA0", VA = "0x18277E0A0")]
	public static void DAGBNIGNNKN<T, T2>(this FGEMECIGOCC EKOKIILLNMO, string ICIEGOLHGJN, EntityQuery NOJJNNFMBAH) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void DAGBNIGNNKN<T, T2>(this FGEMECIGOCC EKOKIILLNMO, string DPEGDJOIEIC, EntityQuery NOJJNNFMBAH, bool GCFKLPPHEMH) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GIILAPEPKKN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	FFMMEOPFOOM GDOAAODOKDA
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
public interface PNKPBLCDKGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INPEDIOJJNB(Entity NEAKDKENHHP, object AMBDKIOJFBL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JIJAMKEPNMD(Entity NEAKDKENHHP, object AMBDKIOJFBL);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EMMNAOBCCGJ(Entity NEAKDKENHHP);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EMMNAOBCCGJ(FFMMEOPFOOM EAHLOGLBEGD);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> IFAOLIKPNKN(Entity NEAKDKENHHP);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DFFHGNGLMIK(Entity NEAKDKENHHP);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MKJONDBJAIE<TComponentData, TValue> : global::MGNADEHMBPL<TValue>, IDisposable where TComponentData : struct, GIILAPEPKKN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class MOJBCNCMEIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> MPMKGFKPBEN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int JKIABPBFIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1050720", Offset = "0x104F520", VA = "0x181050720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x30D9FB0", Offset = "0x30D8DB0", VA = "0x1830D9FB0")]
		public bool FDHAAJODDKB(out TValue MGFMONLLLPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x30DA120", Offset = "0x30D8F20", VA = "0x1830DA120")]
		public void OEECIDDHIAM(object AMBDKIOJFBL, TValue MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x30D9F30", Offset = "0x30D8D30", VA = "0x1830D9F30")]
		public bool CJGLMEKHGBL(object AMBDKIOJFBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x30DA070", Offset = "0x30D8E70", VA = "0x1830DA070")]
		public int IHBPJFIMNDJ(object AMBDKIOJFBL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x30DA1D0", Offset = "0x30D8FD0", VA = "0x1830DA1D0")]
		public MOJBCNCMEIB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<MOJBCNCMEIB> EAJMKDJIOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::JEFOHNHCKHC<FFMMEOPFOOM, MOJBCNCMEIB> JFDPKICBDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager PAHBLOLNPLD;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x30D2AB0", Offset = "0x30D18B0", VA = "0x1830D2AB0")]
	public MKJONDBJAIE(EntityManager PAHBLOLNPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x30D2690", Offset = "0x30D1490", VA = "0x1830D2690", Slot = "4")]
	public void INPEDIOJJNB(Entity NEAKDKENHHP, object AMBDKIOJFBL, TValue MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x30D27B0", Offset = "0x30D15B0", VA = "0x1830D27B0", Slot = "5")]
	public bool JIJAMKEPNMD(Entity NEAKDKENHHP, object AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x30D25C0", Offset = "0x30D13C0", VA = "0x1830D25C0", Slot = "6")]
	public bool FDHAAJODDKB(Entity NEAKDKENHHP, out TValue MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x30D25A0", Offset = "0x30D13A0", VA = "0x1830D25A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x30D2490", Offset = "0x30D1290", VA = "0x1830D2490")]
	private void BNNAJHGMBIA(MOJBCNCMEIB INADGMOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x30D29E0", Offset = "0x30D17E0", VA = "0x1830D29E0")]
	private bool LIBENMGNCBE(Entity NEAKDKENHHP, out FFMMEOPFOOM EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x30D2510", Offset = "0x30D1310", VA = "0x1830D2510")]
	private void DPCOAKDBPCF(Entity NEAKDKENHHP, FFMMEOPFOOM EAHLOGLBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x30D2A90", Offset = "0x30D1890", VA = "0x1830D2A90")]
	private bool OKFLEFLPFNH(FFMMEOPFOOM EAHLOGLBEGD, out MOJBCNCMEIB INADGMOBDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x30D2920", Offset = "0x30D1720", VA = "0x1830D2920")]
	private MOJBCNCMEIB LDBCENPAMGK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MGNADEHMBPL<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INPEDIOJJNB(Entity NEAKDKENHHP, object AMBDKIOJFBL, TValue MGFMONLLLPD);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JIJAMKEPNMD(Entity NEAKDKENHHP, object AMBDKIOJFBL);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FDHAAJODDKB(Entity NEAKDKENHHP, out TValue MGFMONLLLPD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FFMMEOPFOOM : global::BIINDPJIKMP<FFMMEOPFOOM>, JMOHLFDBGCE, IEquatable<FFMMEOPFOOM>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly FFMMEOPFOOM IALIPEBLGLO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int CEEBBJGGBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x1807D54E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x80A490", Offset = "0x809290", VA = "0x18080A490", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int KAKKJFDONBF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x90B640", Offset = "0x90A440", VA = "0x18090B640", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xF02C00", Offset = "0xF01A00", VA = "0x180F02C00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E98990", Offset = "0x5E97790", VA = "0x185E98990", Slot = "8")]
	public bool Equals(FFMMEOPFOOM IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E989E0", Offset = "0x5E977E0", VA = "0x185E989E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NAJLOMAKLJC<T> : PNKPBLCDKGP, IDisposable where T : struct, GIILAPEPKKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> EAJMKDJIOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::JEFOHNHCKHC<FFMMEOPFOOM, HashSet<object>> JFDPKICBDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager PAHBLOLNPLD;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x31A9FB0", Offset = "0x31A8DB0", VA = "0x1831A9FB0")]
	public NAJLOMAKLJC(EntityManager PAHBLOLNPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x31A8F40", Offset = "0x31A7D40", VA = "0x1831A8F40", Slot = "4")]
	public bool INPEDIOJJNB(Entity NEAKDKENHHP, object AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x31A95B0", Offset = "0x31A83B0", VA = "0x1831A95B0", Slot = "5")]
	public bool JIJAMKEPNMD(Entity NEAKDKENHHP, object AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x31A7A70", Offset = "0x31A6870", VA = "0x1831A7A70", Slot = "6")]
	public bool EMMNAOBCCGJ(Entity NEAKDKENHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x31A7CD0", Offset = "0x31A6AD0", VA = "0x1831A7CD0", Slot = "7")]
	public bool EMMNAOBCCGJ(FFMMEOPFOOM EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x31A8550", Offset = "0x31A7350", VA = "0x1831A8550", Slot = "8")]
	public IEnumerable<object> IFAOLIKPNKN(Entity NEAKDKENHHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x31A83F0", Offset = "0x31A71F0", VA = "0x1831A83F0", Slot = "11")]
	public IEnumerable<object> IFAOLIKPNKN(FFMMEOPFOOM EAHLOGLBEGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x31A72A0", Offset = "0x31A60A0", VA = "0x1831A72A0", Slot = "9")]
	public bool DFFHGNGLMIK(Entity NEAKDKENHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x31A7930", Offset = "0x31A6730", VA = "0x1831A7930", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x31A7060", Offset = "0x31A5E60", VA = "0x1831A7060")]
	private void BNNAJHGMBIA(HashSet<object> INADGMOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x31A9E10", Offset = "0x31A8C10", VA = "0x1831A9E10")]
	private bool LIBENMGNCBE(Entity NEAKDKENHHP, out FFMMEOPFOOM EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x31A8A90", Offset = "0x31A7890", VA = "0x1831A8A90")]
	private bool IFDFHOOLDHL(Entity NEAKDKENHHP, out FFMMEOPFOOM EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x31A9850", Offset = "0x31A8650", VA = "0x1831A9850")]
	private void JKNPAIPCOLK(Entity NEAKDKENHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x31A76F0", Offset = "0x31A64F0", VA = "0x1831A76F0")]
	private void DPCOAKDBPCF(Entity NEAKDKENHHP, FFMMEOPFOOM EAHLOGLBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x31A7F30", Offset = "0x31A6D30", VA = "0x1831A7F30")]
	private bool GOJJNGGPKHC(FFMMEOPFOOM EAHLOGLBEGD, out HashSet<object> INADGMOBDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x31A9AF0", Offset = "0x31A88F0", VA = "0x1831A9AF0")]
	private HashSet<object> LDBCENPAMGK()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FKGIBJMLACD : global::CKOAMNMFCNE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E98A30", Offset = "0x5E97830", VA = "0x185E98A30", Slot = "4")]
	public float PPOEJODDKGM(float3 MGFMONLLLPD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DBDNNGBELLB : global::CKOAMNMFCNE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E97D40", Offset = "0x5E96B40", VA = "0x185E97D40", Slot = "4")]
	public float PPOEJODDKGM(float3 MGFMONLLLPD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct HLHAOODNGJA : global::CKOAMNMFCNE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5E98FA0", Offset = "0x5E97DA0", VA = "0x185E98FA0", Slot = "4")]
	public float PPOEJODDKGM(float3 MGFMONLLLPD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct EIBGDGGPBBM : global::CKOAMNMFCNE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x12FC650", Offset = "0x12FB450", VA = "0x1812FC650", Slot = "4")]
	public int PPOEJODDKGM(int3 MGFMONLLLPD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DHCNFHLAJGM : global::CKOAMNMFCNE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0310", Offset = "0x2AAF110", VA = "0x182AB0310", Slot = "4")]
	public int PPOEJODDKGM(int3 MGFMONLLLPD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct PCDNFMHEKLO : global::CKOAMNMFCNE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C460", Offset = "0x5E9B260", VA = "0x185E9C460", Slot = "4")]
	public int PPOEJODDKGM(int3 MGFMONLLLPD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class BAMKINGGNKJ : GJHEIIBGENE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type OOOMMDNEIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xF0AE20", Offset = "0xF09C20", VA = "0x180F0AE20")]
	public BAMKINGGNKJ(Type PAKAOLDIKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OALPEIBOLKA : BAMKINGGNKJ
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xF0AE20", Offset = "0xF09C20", VA = "0x180F0AE20")]
	public OALPEIBOLKA(Type PAKAOLDIKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ABDOLCDPOPA : BAMKINGGNKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type EPKGIKKGJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7612D0", Offset = "0x7600D0", VA = "0x1807612D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E973C0", Offset = "0x5E961C0", VA = "0x185E973C0")]
	public ABDOLCDPOPA(Type EMNLFOPKFFG, Type PAKAOLDIKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AFNDJJALAGK : BAMKINGGNKJ
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xF0AE20", Offset = "0xF09C20", VA = "0x180F0AE20")]
	public AFNDJJALAGK(Type PAKAOLDIKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JFPMCOMHGMD : GJHEIIBGENE
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public JFPMCOMHGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class KGBNGDCCBPL : GJHEIIBGENE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GBFMHHOKKMG OONEKGELKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x740040", Offset = "0x73EE40", VA = "0x180740040")]
		[CompilerGenerated]
		get
		{
			return default(GBFMHHOKKMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xF0B060", Offset = "0xF09E60", VA = "0x180F0B060")]
	public KGBNGDCCBPL(GBFMHHOKKMG AAPGBKEJGGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class DMGDMAGLCAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly MKGAEINCAIG BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager PAHBLOLNPLD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MKGAEINCAIG CADGIMEBGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E97E90", Offset = "0x5E96C90", VA = "0x185E97E90")]
	public DMGDMAGLCAD(MKGAEINCAIG BFCIPJDFKAG, EntityManager PAHBLOLNPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x209C0A0", Offset = "0x209AEA0", VA = "0x18209C0A0")]
	public bool GKHDLKEDGAC<T>(Entity NEAKDKENHHP) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x209C010", Offset = "0x209AE10", VA = "0x18209C010")]
	public bool CLFDJEBBMMO<T>(Entity NEAKDKENHHP, out T MGFMONLLLPD) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x209C8E0", Offset = "0x209B6E0", VA = "0x18209C8E0")]
	public T MNICMAMBJCN<T>(Entity NEAKDKENHHP) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x209C0E0", Offset = "0x209AEE0", VA = "0x18209C0E0")]
	private ComponentType IMLOCKKMDCA<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5E97DC0", Offset = "0x5E96BC0", VA = "0x185E97DC0")]
	private ComponentType IMLOCKKMDCA(Type LEDIIMFEFLP)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class DPMAFGCHFMD
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	protected DPMAFGCHFMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class JHCGCGMABIP<View, Data> : LPGGBJGEPLD where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType ALINNJMHNIB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type CMKLEDJIBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F690", Offset = "0x2A4E490", VA = "0x182A4F690", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type CKALLJELCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2A51650", Offset = "0x2A50450", VA = "0x182A51650", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int AMHMBGMHNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2A51880", Offset = "0x2A50680", VA = "0x182A51880", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2A51810", Offset = "0x2A50610", VA = "0x182A51810")]
	public Data BKKNELMJNAG(Entity NEAKDKENHHP)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2A51940", Offset = "0x2A50740", VA = "0x182A51940")]
	public Data MAGMGPAPPBJ(Entity NEAKDKENHHP)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View JHCINABABBE(Entity NEAKDKENHHP);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x304C9E0", Offset = "0x304B7E0", VA = "0x18304C9E0", Slot = "15")]
	protected internal override T JHCINABABBE<T>(Entity NEAKDKENHHP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1058C20", Offset = "0x1057A20", VA = "0x181058C20")]
	protected JHCGCGMABIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class LPGGBJGEPLD : KBEOGLGHKEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic MIINILFFPDN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager CCEKCIJDDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xBF78F0", Offset = "0xBF66F0", VA = "0x180BF78F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type CMKLEDJIBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type CKALLJELCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int AMHMBGMHNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type NNCGPCPAFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x860540", Offset = "0x85F340", VA = "0x180860540", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int JBDJAODADFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A4B0", Offset = "0x5E992B0", VA = "0x185E9A4B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private ANKHGKIKDDO[] HGGHEDJDENA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x860470", Offset = "0x85F270", VA = "0x180860470", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual ANKHGKIKDDO[] BBGHDOFPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A610", Offset = "0x5E99410", VA = "0x185E9A610", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PNIOCOCKGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A5E0", Offset = "0x5E993E0", VA = "0x185E9A5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A760", Offset = "0x5E99560", VA = "0x185E9A760")]
	public void PGIHAENGDGO(EntityManager PAHBLOLNPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7C69F0", Offset = "0x7C57F0", VA = "0x1807C69F0")]
	protected KBEOGLGHKEJ LNADKAPAEND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T JHCINABABBE<T>(Entity NEAKDKENHHP) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A520", Offset = "0x5E99320", VA = "0x185E9A520", Slot = "8")]
	public (uint, uint) FDOHOOGGPOD(Entity NEAKDKENHHP)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6D0", Offset = "0x5E994D0", VA = "0x185E9A6D0", Slot = "9")]
	public bool MIMFCAIIKEF(Entity NEAKDKENHHP, (uint order, uint change) HHCMOLFBCEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	protected LPGGBJGEPLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class CEFJPMBLBLP<Data> : EHDBFDAEFOI where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data ONJMHIPHCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x316FE70", Offset = "0x316EC70", VA = "0x18316FE70", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x23B2C80", Offset = "0x23B1A80", VA = "0x1823B2C80", Slot = "8")]
	protected virtual bool FIEMNCLHKDD(ReadOnlySpan<Data> BNPIGAGGDHK, KBICDOOODLG MNPIJNFAMOJ, out ReadOnlySpan<byte> AAOFEOFDGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "9")]
	protected virtual bool MOIFOFMFBNA(int HHCMOLFBCEB, Span<Data> BNPIGAGGDHK, in ReadOnlySpan<byte> AAOFEOFDGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x316FDB0", Offset = "0x316EBB0", VA = "0x18316FDB0", Slot = "5")]
	internal sealed override bool FIEMNCLHKDD(ref Unity.Entities.Chunk CFENEJCFJAK, int LHPMCKNABCE, KBICDOOODLG MNPIJNFAMOJ, out ReadOnlySpan<byte> AAOFEOFDGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3170C60", Offset = "0x316FA60", VA = "0x183170C60", Slot = "6")]
	internal sealed override bool MOIFOFMFBNA(int HHCMOLFBCEB, ref Unity.Entities.Chunk CFENEJCFJAK, int LHPMCKNABCE, in ReadOnlySpan<byte> AAOFEOFDGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x273C5E0", Offset = "0x273B3E0", VA = "0x18273C5E0")]
	protected global::NENFILFCLGE<Protobuf> BDMGLKKOBCA<Protobuf>(ReadOnlySpan<Data> BNPIGAGGDHK) where Protobuf : IMessage, new()
	{
		return default(global::NENFILFCLGE<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x273C630", Offset = "0x273B430", VA = "0x18273C630")]
	protected global::NHHEAJIJJOH<Protobuf> OJHPCHPJIAC<Protobuf>(ReadOnlySpan<byte> AAOFEOFDGLE, ReadOnlySpan<Data> BNPIGAGGDHK, Action<Protobuf> BMOFALKJPMP) where Protobuf : IMessage, new()
	{
		return default(global::NHHEAJIJJOH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1058C20", Offset = "0x1057A20", VA = "0x181058C20")]
	protected CEFJPMBLBLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class EHDBFDAEFOI
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int KAKKJFDONBF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E987F0", Offset = "0x5E975F0", VA = "0x185E987F0", Slot = "5")]
	internal virtual bool FIEMNCLHKDD(ref Unity.Entities.Chunk CFENEJCFJAK, int LHPMCKNABCE, KBICDOOODLG MNPIJNFAMOJ, out ReadOnlySpan<byte> AAOFEOFDGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "6")]
	internal virtual bool MOIFOFMFBNA(int HHCMOLFBCEB, ref Unity.Entities.Chunk CFENEJCFJAK, int LHPMCKNABCE, in ReadOnlySpan<byte> AAOFEOFDGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	protected EHDBFDAEFOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface CKOAMNMFCNE<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo PPOEJODDKGM(TFrom MGFMONLLLPD);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LKAELBGPJIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KCBPGBNAFJP(T MGFMONLLLPD);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct MEMDHIBJIFI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::CKOAMNMFCNE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> KAABDKEHING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> IPGMLNKJKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap JBJAGOLOBKN;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct ANLANFDNJPO<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::CKOAMNMFCNE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> GHHJACBGMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> IPGMLNKJKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap JBJAGOLOBKN;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct IOPLLCCONOM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KAEAJLLKEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> KAABDKEHING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> IPGMLNKJKNG;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x275F2A0", Offset = "0x275E0A0", VA = "0x18275F2A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct AIBPPJBMGPJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KAEAJLLKEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> KAABDKEHING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> GGLBPKGGCOK;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct PIDIBDNFJFG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::CKOAMNMFCNE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> AOALELHIILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> IPGMLNKJKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap JBJAGOLOBKN;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct PNKFDMGCFPP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PAKAOLDIKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> GIBCHKHFFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> HLNLEOKINJL;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct BIKKKCMLDOI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PAKAOLDIKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> GIBCHKHFFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> HLNLEOKINJL;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C97E40", Offset = "0x2C96C40", VA = "0x182C97E40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct DCGAAHIMCHA<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> KAABDKEHING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> GGLBPKGGCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, JCKJOPOBLHO> EGKBGLGDJLL;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2F874B0", Offset = "0x2F862B0", VA = "0x182F874B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct DKFAOMNNEGB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::CKOAMNMFCNE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> KAABDKEHING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> GGLBPKGGCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, JCKJOPOBLHO> EGKBGLGDJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap JBJAGOLOBKN;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct LJIAGNIMEEM<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::LKAELBGPJIF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> KAABDKEHING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> GGLBPKGGCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate JBJAGOLOBKN;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct NGKPKLMCBIJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity PAKAOLDIKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> GIBCHKHFFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> PIHKBOBMCDB;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C3D0", Offset = "0x5E9B1D0", VA = "0x185E9C3D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct MKPCMIOCMII : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity PAKAOLDIKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> GIBCHKHFFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> PIHKBOBMCDB;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C2D0", Offset = "0x5E9B0D0", VA = "0x185E9C2D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IFJKKLKEPFG
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class CADFMGAIDOA
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2606630", Offset = "0x2605430", VA = "0x182606630")]
	public static bool PNLBBBFOFMM<T>(this NativeArray<Entity> GIBCHKHFFAJ, EntityManager PAHBLOLNPLD, Allocator MBJMPHBLMBF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class LMDHLEOEIOI
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class OIMAJGDAHNE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public OIMAJGDAHNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class OMGHDJCFMEF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public OMGHDJCFMEF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> BMHJBMPODKI;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A230", Offset = "0x5E99030", VA = "0x185E9A230")]
	public LMDHLEOEIOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NCLNKLGKOMC
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HCGFLKMGBKB
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct MHALMOIDFIH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct FCLFPCPHLJB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal MHALMOIDFIH<TFrom> GANAMHNGMGO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator MBJMPHBLMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> EKDHPMHGKLM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct ADDDLDHFIKM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct OGPKLEKNCFN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal ADDDLDHFIKM<TFrom> GANAMHNGMGO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator MBJMPHBLMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> EKDHPMHGKLM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct BFHJIMEHEGL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct AOGNEMPFKLP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal BFHJIMEHEGL<TFrom> GANAMHNGMGO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator MBJMPHBLMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> EKDHPMHGKLM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct BMOMPNNKEDH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct FJDMBCBACDB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal BMOMPNNKEDH<TFrom> GANAMHNGMGO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator MBJMPHBLMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> EKDHPMHGKLM;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FHBLEBEGBJC
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DKNAIKHJGDM
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x209B5F0", Offset = "0x209A3F0", VA = "0x18209B5F0")]
	public static NativeList<T> EGMLNFPDMJJ<T>(this NativeArray<T> AEEDDODLLHN, Allocator MBJMPHBLMBF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class GEDNOMNHOEH
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x208ABA0", Offset = "0x20899A0", VA = "0x18208ABA0")]
	public static NativeArray<T> LNADBKOHFAD<T>(this NativeList<Entity> AEEDDODLLHN, EntityManager PAHBLOLNPLD, Allocator MBJMPHBLMBF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x208AAA0", Offset = "0x20898A0", VA = "0x18208AAA0")]
	public static NativeArray<T> LNADBKOHFAD<T>(this NativeArray<Entity> AEEDDODLLHN, EntityManager PAHBLOLNPLD, Allocator MBJMPHBLMBF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class NKMHFJOAGKB
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct ECNAIJHPCOD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct FPAIGCMHCOC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public ECNAIJHPCOD<TFrom> EKDHPMHGKLM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator MBJMPHBLMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> KAABDKEHING;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct MBDDDOCPCAO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct KJDBONJDIKE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public MBDDDOCPCAO<TFrom> EKDHPMHGKLM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator MBJMPHBLMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> KAABDKEHING;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct ENJHCFOEOBG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct HPLODNPDIHP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public ENJHCFOEOBG<TFrom> EKDHPMHGKLM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator MBJMPHBLMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> KAABDKEHING;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class KPHLMOILLBN
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class BGACDCGAECA
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct HNHELHLHLJF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator MBJMPHBLMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> KAABDKEHING;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct AJFPBBKNACP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator MBJMPHBLMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> KAABDKEHING;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct JDHJBJLDNBM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator MBJMPHBLMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> KAABDKEHING;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct KAPPHFFBLMJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator MBJMPHBLMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> KAABDKEHING;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class CMDMCFNLGKE
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class BEEJLLGAAIB
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x26583E0", Offset = "0x26571E0", VA = "0x1826583E0")]
	public static NativeList<Entity> GKMCMMJDLHK<T>(this NativeArray<Entity> GIBCHKHFFAJ, EntityManager PAHBLOLNPLD, Allocator MBJMPHBLMBF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class KLPHKNBNPDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface OBJIAFPELDN
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface FBFADHDJIFL
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class ABAJFPBKMOJ
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class GOEDIFHIHOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E98A40", Offset = "0x5E97840", VA = "0x185E98A40")]
	public static bool DKCFMIPGCLK(Type LEDIIMFEFLP, Type ODPMFLPACFE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class LICJAICOACK<Attribute, BaseClass> : global::FMKFFCNMFBN<BaseClass>, ANINIJFPHEJ where Attribute : BAMKINGGNKJ
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly FGEMECIGOCC EKOKIILLNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string ICIEGOLHGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> JOANAIJGOEN;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2BFCAA0", Offset = "0x2BFB8A0", VA = "0x182BFCAA0")]
	public LICJAICOACK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2BFC9E0", Offset = "0x2BFB7E0", VA = "0x182BFC9E0", Slot = "4")]
	public bool LDEEBLCAEDK(int JMJHPMGKKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2BFC730", Offset = "0x2BFB530", VA = "0x182BFC730", Slot = "5")]
	public global::LHAHHAJLMCG<BaseClass> KHCHFDMNPJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2BFC500", Offset = "0x2BFB300", VA = "0x182BFC500", Slot = "7")]
	protected virtual bool DKCFMIPGCLK(Type LEDIIMFEFLP, int FLIOLHEDOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2BFC470", Offset = "0x2BFB270", VA = "0x182BFC470", Slot = "8")]
	protected virtual int AFBMDHMEHMH(Type LEDIIMFEFLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2BFC600", Offset = "0x2BFB400", VA = "0x182BFC600")]
	public void FODOGCDFONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BFC690", Offset = "0x2BFB490", VA = "0x182BFC690", Slot = "6")]
	public void GLJEDJEGGBC(Type LEDIIMFEFLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LHAHHAJLMCG<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> BAAKANFFBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> KHOKONBCGEF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> CABPGNDMHFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2BF63B0", Offset = "0x2BF51B0", VA = "0x182BF63B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6660", Offset = "0x2BF5460", VA = "0x182BF6660")]
	public LHAHHAJLMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2BF67F0", Offset = "0x2BF55F0", VA = "0x182BF67F0")]
	public LHAHHAJLMCG(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2BF65E0", Offset = "0x2BF53E0", VA = "0x182BF65E0")]
	internal void OEECIDDHIAM(int JMJHPMGKKMH, BaseClass JKBGMBLHKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1BED490", Offset = "0x1BEC290", VA = "0x181BED490")]
	public bool BAIMCJHPDMA<T>(out BaseClass MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2BF62B0", Offset = "0x2BF50B0", VA = "0x182BF62B0")]
	public bool BAIMCJHPDMA(Type ACHMOOKCOKG, out BaseClass MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6350", Offset = "0x2BF5150", VA = "0x182BF6350")]
	public bool HGPGOFAKDAM(int JMJHPMGKKMH, out BaseClass MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1BEE1A0", Offset = "0x1BECFA0", VA = "0x181BEE1A0")]
	public T IDHJEDJPBGD<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6380", Offset = "0x2BF5180", VA = "0x182BF6380")]
	public BaseClass IDHJEDJPBGD(Type BPJAMIFJLGG)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class NACJIJDMFKE : global::LICJAICOACK<OALPEIBOLKA, DPMAFGCHFMD>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C360", Offset = "0x5E9B160", VA = "0x185E9C360")]
	public NACJIJDMFKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class DEBAADFFFFJ : global::LICJAICOACK<ABDOLCDPOPA, LPGGBJGEPLD>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E97D50", Offset = "0x5E96B50", VA = "0x185E97D50")]
	public DEBAADFFFFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class LBBFPDKONJA : global::LICJAICOACK<AFNDJJALAGK, EHDBFDAEFOI>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A000", Offset = "0x5E98E00", VA = "0x185E9A000")]
	public LBBFPDKONJA()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[DKGMECGHCPI(OJBFOICGDOF.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> LFNDHOPEOFJ;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x918E40", Offset = "0x917C40", VA = "0x180918E40")]
		private ComponentSystemTypes(List<Type> LFNDHOPEOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E979C0", Offset = "0x5E967C0", VA = "0x185E979C0")]
		public static void FODOGCDFONM(List<Type> LFNDHOPEOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E97AB0", Offset = "0x5E968B0", VA = "0x185E97AB0")]
		private void NECKLLOBJGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E97940", Offset = "0x5E96740", VA = "0x185E97940")]
		private bool DKCFMIPGCLK(Type LEDIIMFEFLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E97A50", Offset = "0x5E96850", VA = "0x185E97A50")]
		private void JDGKGAAEPCL(Type LEDIIMFEFLP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class EBJAMMGLKGI : CNPEJNDMKOG
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E97F30", Offset = "0x5E96D30", VA = "0x185E97F30", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase ELEDNLKCBIG();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E97EE0", Offset = "0x5E96CE0", VA = "0x185E97EE0")]
	protected ComponentSystemBase AGGFIAJOJJK(params ComponentSystemBase[] POEIPOGPNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x20AB610", Offset = "0x20AA410", VA = "0x1820AB610")]
	protected ComponentSystemBase AGGFIAJOJJK<T>(params ComponentSystemBase[] POEIPOGPNCF) where T : CNPEJNDMKOG, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x20AB6B0", Offset = "0x20AA4B0", VA = "0x1820AB6B0")]
	protected ComponentSystemBase ALLPPGDIMBA<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x20AB6B0", Offset = "0x20AA4B0", VA = "0x1820AB6B0")]
	protected ComponentSystemBase CNHEODJHPJB<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	protected EBJAMMGLKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface FMKFFCNMFBN<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LDEEBLCAEDK(int JMJHPMGKKMH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::LHAHHAJLMCG<BaseClass> KHCHFDMNPJI();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class CNPEJNDMKOG : JMMKLDJBDDA
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E97690", Offset = "0x5E96490", VA = "0x185E97690", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public CNPEJNDMKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class CENINKGGFPK : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E975E0", Offset = "0x5E963E0", VA = "0x185E975E0")]
	public ComponentDataFromEntity FKDHKMDBBLN(int JMJHPMGKKMH, bool CCJDKCIDKAA = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E97680", Offset = "0x5E96480", VA = "0x185E97680", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0")]
	protected CENINKGGFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class CCDGKGFAGLN : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0")]
	protected CCDGKGFAGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class PCJBNPNGPAF : CENINKGGFPK
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C470", Offset = "0x5E9B270", VA = "0x185E9C470", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	protected void MBCIOBBCNFF(string IMOOIIGBLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0")]
	protected PCJBNPNGPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class ANIKBPJJOLB
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class JMMKLDJBDDA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	protected JMMKLDJBDDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[DKGMECGHCPI(OJBFOICGDOF.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C6E0", Offset = "0x5E9B4E0", VA = "0x185E9C6E0")]
		public static ComponentSystemGroup[] CMGDHMLCICO(World BFCIPJDFKAG, HFABGEEFGCD HINPNJOEIEB = HFABGEEFGCD.Default, bool ABLCPGLLCBM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C7B0", Offset = "0x5E9B5B0", VA = "0x185E9C7B0")]
		private static Type[] EGEKLHJJMJN(HFABGEEFGCD HINPNJOEIEB, bool ABLCPGLLCBM, ComponentSystemGroup[] IBGDBBPHHGE, ComponentSystemGroup FHPOGFHNGON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CB10", Offset = "0x5E9B910", VA = "0x185E9CB10")]
		private static ComponentSystemGroup[] FBGIOAEAPCD(World BFCIPJDFKAG, out ComponentSystemGroup FHPOGFHNGON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D400", Offset = "0x5E9C200", VA = "0x185E9D400")]
		internal static bool MIAHGIMPHPE(GBFMHHOKKMG AAPGBKEJGGC, out PDAIJELFDEO IEAKMFJBJML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D680", Offset = "0x5E9C480", VA = "0x185E9D680")]
		private static ComponentSystemGroup PBNGAEABOPL(Type LEDIIMFEFLP, World BFCIPJDFKAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D760", Offset = "0x5E9C560", VA = "0x185E9D760")]
		private static ComponentSystemGroup[] PMBHILLAMJE(Type[] LFNDHOPEOFJ, World BFCIPJDFKAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CE20", Offset = "0x5E9BC20", VA = "0x185E9CE20")]
		internal static void HBLKKBBCIPC(World BFCIPJDFKAG, Type[] DOAJIKCPHAP, ComponentSystemGroup[] IBGDBBPHHGE, ComponentSystemGroup FHPOGFHNGON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D340", Offset = "0x5E9C140", VA = "0x185E9D340")]
		internal static bool JKDDLOCMKFD(ComponentSystemBase BAHPOEMJAPG, ComponentSystemGroup[] IBGDBBPHHGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D3A0", Offset = "0x5E9C1A0", VA = "0x185E9D3A0")]
		private static void LGMBELMMIPB(ComponentSystemGroup[] IBGDBBPHHGE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct ACGIMHMENLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> EJBAIEJEHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> POEIPOGPNCF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x809110", Offset = "0x807F10", VA = "0x180809110")]
	public ACGIMHMENLI(Dictionary<Type, List<Type>> EJBAIEJEHKL, HashSet<Type> POEIPOGPNCF)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[DKGMECGHCPI(OJBFOICGDOF.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class HDPNOHOJBCM : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
			[DebuggerHidden]
			public HDPNOHOJBCM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5E98EC0", Offset = "0x5E97CC0", VA = "0x185E98EC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5E98C20", Offset = "0x5E97A20", VA = "0x185E98C20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5E98F50", Offset = "0x5E97D50", VA = "0x185E98F50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5E98E80", Offset = "0x5E97C80", VA = "0x185E98E80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5E98DD0", Offset = "0x5E97BD0", VA = "0x185E98DD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5E98DD0", Offset = "0x5E97BD0", VA = "0x185E98DD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct OMHCJAIOGAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type MFGCBGDGMJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private HFABGEEFGCD HINPNJOEIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool JMIJFKPCBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool IALBMNAANHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool ABLCPGLLCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> FJNBJMPKOJI;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D920", Offset = "0x5E9C720", VA = "0x185E9D920")]
		public static RRFilterWorldSystems CJALKNOJAHB()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E270", Offset = "0x5E9D070", VA = "0x185E9E270")]
		public RRFilterWorldSystems JGNJPAKNLME(HFABGEEFGCD AAPGBKEJGGC)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E570", Offset = "0x5E9D370", VA = "0x185E9E570")]
		public RRFilterWorldSystems LIMMILANOJH(IEnumerable<Type> LFNDHOPEOFJ)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E280", Offset = "0x5E9D080", VA = "0x185E9E280")]
		public RRFilterWorldSystems JNIPEPGIDLM(bool CJHFFFLMJLI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DF80", Offset = "0x5E9CD80", VA = "0x185E9DF80")]
		public RRFilterWorldSystems DEJPKFDODKE(bool NAPCICFAOOA)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E150", Offset = "0x5E9CF50", VA = "0x185E9E150")]
		public ACGIMHMENLI HHCLPCDFKHF(Type[] MJCHEBLJOCF)
		{
			return default(ACGIMHMENLI);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E1E0", Offset = "0x5E9CFE0", VA = "0x185E9E1E0")]
		[IteratorStateMachine(typeof(HDPNOHOJBCM))]
		internal IEnumerable<Type> IJOOBNJJBMM(IEnumerable<Type> LFNDHOPEOFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E290", Offset = "0x5E9D090", VA = "0x185E9E290")]
		internal Dictionary<Type, List<Type>> KBMPEMOOIGJ(IEnumerable<Type> LFNDHOPEOFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E5B0", Offset = "0x5E9D3B0", VA = "0x185E9E5B0")]
		private void LJANGMILJFP(Dictionary<Type, List<Type>> NFHDJMINDPN, Type LEDIIMFEFLP, Type OCFPLEDAAJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DF90", Offset = "0x5E9CD90", VA = "0x185E9DF90")]
		internal HashSet<Type> DMMFIHDOKOB(IEnumerable<Type> IBGDBBPHHGE, Dictionary<Type, List<Type>> HNFKMIGCOAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D940", Offset = "0x5E9C740", VA = "0x185E9D940")]
		internal bool DDLJPGGOPCN(Type LEDIIMFEFLP, HFABGEEFGCD HINPNJOEIEB, bool ABLCPGLLCBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E6C0", Offset = "0x5E9D4C0", VA = "0x185E9E6C0")]
		[CompilerGenerated]
		internal static void OCDCBHHPEPA(Type LEDIIMFEFLP, ref OMHCJAIOGAL P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class KKBOMPKEECM
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool CDMODDELAKJ;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E99DB0", Offset = "0x5E98BB0", VA = "0x185E99DB0")]
	public static void PGIHAENGDGO(bool ONFDAKCOPIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5E99BF0", Offset = "0x5E989F0", VA = "0x185E99BF0")]
	private static void ODPNFPFHOPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class PJMBGOKDHNO
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C670", Offset = "0x5E9B470", VA = "0x185E9C670")]
	public static ulong KMDJMFFAEGL(Type LEDIIMFEFLP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C5B0", Offset = "0x5E9B3B0", VA = "0x185E9C5B0")]
	public static ulong KMDJMFFAEGL(string MDEOAPHIGLM)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[DKGMECGHCPI(OJBFOICGDOF.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct LKADLMLFCJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong PBEMMFNBGNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong NJMMNEHAGGI;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xF08C10", Offset = "0xF07A10", VA = "0x180F08C10")]
			public LKADLMLFCJI(ulong FMIEPBHPCJA, ulong CHHGECGKHJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5E9A1A0", Offset = "0x5E98FA0", VA = "0x185E9A1A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> HNHIJEGNBEK;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static LKADLMLFCJI[] DFINKOHHGLL;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool CDMODDELAKJ;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EBC0", Offset = "0x5E9D9C0", VA = "0x185E9EBC0")]
		public static ulong DNINCBNKAEE(int JMJHPMGKKMH)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EB10", Offset = "0x5E9D910", VA = "0x185E9EB10")]
		public static int DAGEIEOPBNI(ulong CHHGECGKHJL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F3F0", Offset = "0x5E9E1F0", VA = "0x185E9F3F0")]
		public static void PGIHAENGDGO(bool ONFDAKCOPIF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F310", Offset = "0x5E9E110", VA = "0x185E9F310")]
		private static void NHAINEMCJPD(int IACNFPPDGGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EF50", Offset = "0x5E9DD50", VA = "0x185E9EF50")]
		private static void KACOIGJEEIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EE70", Offset = "0x5E9DC70", VA = "0x185E9EE70")]
		private static LKADLMLFCJI JAGANJLBLOK(Type LEDIIMFEFLP)
		{
			return default(LKADLMLFCJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5E9ED20", Offset = "0x5E9DB20", VA = "0x185E9ED20")]
		private static ulong FNELPGLICIO(Type LEDIIMFEFLP, ulong CHHGECGKHJL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E8F0", Offset = "0x5E9D6F0", VA = "0x185E9E8F0")]
		private static void BACKPMOOAMH(in LKADLMLFCJI MEPGPBNFMPN, TypeManager.TypeInfo HKILGIJBCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EC20", Offset = "0x5E9DA20", VA = "0x185E9EC20")]
		private static void FCIDBPDGGMK(LKADLMLFCJI HKILGIJBCHI, int JMJHPMGKKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9ED90", Offset = "0x5E9DB90", VA = "0x185E9ED90")]
		private static void IGPGHMEAHHF(LKADLMLFCJI HKILGIJBCHI, int JMJHPMGKKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F280", Offset = "0x5E9E080", VA = "0x185E9F280")]
		private static LKADLMLFCJI NGJCPLEDGFK(int JMJHPMGKKMH)
		{
			return default(LKADLMLFCJI);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F270", Offset = "0x5E9E070", VA = "0x185E9F270")]
		private static int MHGMGPGJEMF(int JMJHPMGKKMH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class EEOMELFMHJG
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly DEBAADFFFFJ MIMBCCJGOEL;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly LBBFPDKONJA CLNBMBDLBNJ;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly NACJIJDMFKE OIFNBONJIAL;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> EDGCPHIDNNO;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool CDMODDELAKJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::FMKFFCNMFBN<LPGGBJGEPLD> AIFAPJMIFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5E980B0", Offset = "0x5E96EB0", VA = "0x185E980B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::FMKFFCNMFBN<EHDBFDAEFOI> NNNFPPOPGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5E97FD0", Offset = "0x5E96DD0", VA = "0x185E97FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::FMKFFCNMFBN<DPMAFGCHFMD> BECPDCFILHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5E97F70", Offset = "0x5E96D70", VA = "0x185E97F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5E98110", Offset = "0x5E96F10", VA = "0x185E98110")]
	public static void PGIHAENGDGO(bool ONFDAKCOPIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5E98030", Offset = "0x5E96E30", VA = "0x185E98030")]
	public static Type[] OBLFJPFNDGC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class MKGEBHOAFII
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> GOJMMIKGKKC;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool CDMODDELAKJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5E9BE10", Offset = "0x5E9AC10", VA = "0x185E9BE10")]
	public static int FDOHOOGGPOD(int JMJHPMGKKMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C1B0", Offset = "0x5E9AFB0", VA = "0x185E9C1B0")]
	public static void PGIHAENGDGO(bool ONFDAKCOPIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5E9BEB0", Offset = "0x5E9ACB0", VA = "0x185E9BEB0")]
	private static void IAHEHLOGGKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9BDC0", Offset = "0x5E9ABC0", VA = "0x185E9BDC0")]
	private static int CFGEPGGMOGA(Type LEDIIMFEFLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C130", Offset = "0x5E9AF30", VA = "0x185E9C130")]
	private static void ODCBHOABBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class MKGAEINCAIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World AEIDONAKGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly DMGDMAGLCAD JKBGMBLHKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] IBGDBBPHHGE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World CADGIMEBGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World EHMOILHLDLA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager CCEKCIJDDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918B70", VA = "0x180919D70")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public DMGDMAGLCAD EDDGIILAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::LHAHHAJLMCG<LPGGBJGEPLD> AIFAPJMIFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7F11E0", Offset = "0x7EFFE0", VA = "0x1807F11E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::LHAHHAJLMCG<EHDBFDAEFOI> NNNFPPOPGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x748BC0", Offset = "0x7479C0", VA = "0x180748BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::LHAHHAJLMCG<DPMAFGCHFMD> BECPDCFILHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x748BB0", Offset = "0x7479B0", VA = "0x180748BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x748BD0", Offset = "0x7479D0", VA = "0x180748BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> HOOKCAMEDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x919DB0", Offset = "0x918BB0", VA = "0x180919DB0")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] EPIBMMNKGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5E9AF20", Offset = "0x5E99D20", VA = "0x185E9AF20")]
	public static MKGAEINCAIG CMFGBJIGIJK(string ICIEGOLHGJN, GBFMHHOKKMG AAPGBKEJGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B8A0", Offset = "0x5E9A6A0", VA = "0x185E9B8A0")]
	public MKGAEINCAIG(string ICIEGOLHGJN, GBFMHHOKKMG AAPGBKEJGGC = GBFMHHOKKMG.Simulation, HFABGEEFGCD HINPNJOEIEB = HFABGEEFGCD.Default, bool ONFDAKCOPIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B880", Offset = "0x5E9A680", VA = "0x185E9B880")]
	public ComponentSystemBase PADGKLMFNPO(Type LEDIIMFEFLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x25111A0", Offset = "0x250FFA0", VA = "0x1825111A0")]
	public T PADGKLMFNPO<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B820", Offset = "0x5E9A620", VA = "0x185E9B820")]
	public void MLKOHBBCJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B4F0", Offset = "0x5E9A2F0", VA = "0x185E9B4F0")]
	public void MCGBFLAOCMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B490", Offset = "0x5E9A290", VA = "0x185E9B490")]
	public void LFKFBNIDHCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B340", Offset = "0x5E9A140", VA = "0x185E9B340")]
	public void IJEPMGFHAAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B200", Offset = "0x5E9A000", VA = "0x185E9B200")]
	public void FOOLNKDLBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B120", Offset = "0x5E99F20", VA = "0x185E9B120")]
	public void EDDDGAPKFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5E9AEC0", Offset = "0x5E99CC0", VA = "0x185E9AEC0")]
	public void CLFLDGOGFAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B3A0", Offset = "0x5E9A1A0", VA = "0x185E9B3A0")]
	public void JAJBIMFOILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5E9AE60", Offset = "0x5E99C60", VA = "0x185E9AE60")]
	public void APFJOFMDMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B430", Offset = "0x5E9A230", VA = "0x185E9B430")]
	public void JCAEEBAJAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B260", Offset = "0x5E9A060", VA = "0x185E9B260")]
	internal void HFKFBOOBHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B180", Offset = "0x5E99F80", VA = "0x185E9B180")]
	private bool FAIAPBAPNJB(ComponentSystemGroup HCBJJHBALOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B550", Offset = "0x5E9A350", VA = "0x185E9B550")]
	private void MGNKACCJLMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9AFA0", Offset = "0x5E99DA0", VA = "0x185E9AFA0")]
	private ComponentSystemGroup[] CMGDHMLCICO(HFABGEEFGCD HINPNJOEIEB, bool ABLCPGLLCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B0B0", Offset = "0x5E99EB0", VA = "0x185E9B0B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum GBFMHHOKKMG
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
public sealed class LMINJIELDAB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public HFABGEEFGCD IIFMEIBLIAG;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum HFABGEEFGCD
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
public interface PDAIJELFDEO
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type IEFAGFBLBFC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] HKKMFIENLHI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class BINIDEMJDCH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool KKJGJIGOJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	protected BINIDEMJDCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class FPMHFMCKIGB : BINIDEMJDCH
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public FPMHFMCKIGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class CCJBNKKKNFM : BINIDEMJDCH
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public CCJBNKKKNFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class POPEOKKPGPB : BINIDEMJDCH
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public POPEOKKPGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class CBGKKBIFHPA : BINIDEMJDCH
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public CBGKKBIFHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class LGEKDPLLGIK : BINIDEMJDCH
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public LGEKDPLLGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class ACMBDJLIJHF : BINIDEMJDCH
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public ACMBDJLIJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class GLLJIGHFJGA : BINIDEMJDCH
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public GLLJIGHFJGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class LEMPJHMHLKC : BINIDEMJDCH
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public LEMPJHMHLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class ELMEEGOIOBO : BINIDEMJDCH
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public ELMEEGOIOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class EMCOIEJOGIA : ALNHPMHHEJO
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public EMCOIEJOGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class BEMOBJNKEIN : ALNHPMHHEJO
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public BEMOBJNKEIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class FMMBGDGOJIL : ALNHPMHHEJO
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public FMMBGDGOJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class OHNNLDNHKCN : ALNHPMHHEJO
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public OHNNLDNHKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[AIMPMHLOEBK(DIMCOFJGPGL.Application)]
public class ALNHPMHHEJO : BINIDEMJDCH
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool KKJGJIGOJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5E97410", Offset = "0x5E96210", VA = "0x185E97410")]
	public ALNHPMHHEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class MJHKBCGNEBF : GJHEIIBGENE
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public MJHKBCGNEBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class LNNJOHIEJAD
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void GKDDFLPFPOI<From, To>(From EKDHPMHGKLM, ref To JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class OKIIBLGICBN<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static GKDDFLPFPOI<From, To> DIMLHAGBHKF;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public OKIIBLGICBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A2B0", Offset = "0x5E990B0", VA = "0x185E9A2B0")]
	static LNNJOHIEJAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2B1FB30", Offset = "0x2B1E930", VA = "0x182B1FB30")]
	public static void NGFCJPAOOOL<T>(GKDDFLPFPOI<T, T> APFFHHLMHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F8A0", Offset = "0x2B1E6A0", VA = "0x182B1F8A0")]
	public static void NGFCJPAOOOL<From, To>(GKDDFLPFPOI<From, To> APFFHHLMHAI, GKDDFLPFPOI<To, From> MCNCIJDHJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F930", Offset = "0x2B1E730", VA = "0x182B1F930")]
	public static void NGFCJPAOOOL<From, To>(GKDDFLPFPOI<From, To> DIMLHAGBHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2B21920", Offset = "0x2B20720", VA = "0x182B21920")]
	public static GKDDFLPFPOI<From, To> OFALBJJPEMF<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2B1CE00", Offset = "0x2B1BC00", VA = "0x182B1CE00")]
	public static void EIMPNBNIPFN<From, To>(From EKDHPMHGKLM, ref To JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class KBICDOOODLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> IBLLBIAFJCM;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xD60330", Offset = "0xD5F130", VA = "0x180D60330")]
	public KBICDOOODLG(NativeArray<EntityRemapUtility.EntityRemapInfo> IBLLBIAFJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CFF0", Offset = "0x2D1BDF0", VA = "0x182D1CFF0")]
	public Entity OGMFDCJPFKA(Entity NFJHHMHDKEL)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class KOHHBJELKDA
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> PIJPMCLOKDH;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5E99E10", Offset = "0x5E98C10", VA = "0x185E99E10")]
	public static bool BNIMBIKHPAJ(ulong PHHBPOOMOKI, uint HHCMOLFBCEB, out string ICIEGOLHGJN)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[DKGMECGHCPI(OJBFOICGDOF.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct BLOJNAOPBJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int CEEBBJGGBDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int KAKKJFDONBF;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x7621E0", Offset = "0x760FE0", VA = "0x1807621E0")]
			public BLOJNAOPBJG(int NNHNOIMLALG, int HHCMOLFBCEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct HLKBHLJMFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch CILOCLCFEGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long FOMBMIPGNFE;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long BKGLADJPJLG
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x5E98FC0", Offset = "0x5E97DC0", VA = "0x185E98FC0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long IBHHPNJLBBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5E990E0", Offset = "0x5E97EE0", VA = "0x185E990E0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5E99020", Offset = "0x5E97E20", VA = "0x185E99020")]
			public static HLKBHLJMFLJ EJEHGNMMKCK()
			{
				return default(HLKBHLJMFLJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct ILKGAGOLHEF : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct JOOEBKIINHE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* GCECKOCIPHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly JNACHDOMCFC.GGNBAEABPBG.DMPKOGOCLFH PDJACJAILLK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly KBICDOOODLG MNPIJNFAMOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::LHAHHAJLMCG<EHDBFDAEFOI> LACPOBNLJLI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int LHPMCKNABCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int BCPIMODLIBN;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x5E999C0", Offset = "0x5E987C0", VA = "0x185E999C0")]
				public unsafe JOOEBKIINHE(Unity.Entities.Archetype* GCECKOCIPHA, JNACHDOMCFC.GGNBAEABPBG.DMPKOGOCLFH PDJACJAILLK, KBICDOOODLG MNPIJNFAMOJ, global::LHAHHAJLMCG<EHDBFDAEFOI> LACPOBNLJLI, int LHPMCKNABCE, int BCPIMODLIBN = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5E99970", Offset = "0x5E98770", VA = "0x185E99970")]
				public JOOEBKIINHE(in JOOEBKIINHE MMJOHADFCHO, int BCPIMODLIBN)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly JOOEBKIINHE[] BNPIGAGGDHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] GHABINBEDLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int LCEDHCOJDIJ;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5E99830", Offset = "0x5E98630", VA = "0x185E99830")]
			public ILKGAGOLHEF(JOOEBKIINHE[] BNPIGAGGDHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5E99420", Offset = "0x5E98220", VA = "0x185E99420", Slot = "4")]
			public void Invoke(int NNHNOIMLALG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5E99480", Offset = "0x5E98280", VA = "0x185E99480")]
			private void MHCJMMDFGHB(in JOOEBKIINHE MMJOHADFCHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5E99150", Offset = "0x5E97F50", VA = "0x185E99150")]
			private static void GBLBCBEHCFB(in JOOEBKIINHE MMJOHADFCHO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class BCOCBFLLJPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public JNACHDOMCFC asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::LHAHHAJLMCG<EHDBFDAEFOI> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public BCOCBFLLJPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5E97570", Offset = "0x5E96370", VA = "0x185E97570")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class GABKDLJGKMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public JNACHDOMCFC.GGNBAEABPBG.DMPKOGOCLFH srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public BCOCBFLLJPK CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public GABKDLJGKMK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class PGINOIMMFCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public GABKDLJGKMK CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public PGINOIMMFCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E9C4A0", Offset = "0x5E9B2A0", VA = "0x185E9C4A0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly FGEMECIGOCC EKBOKAGOJBK;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly FGEMECIGOCC MGIBOFMIGMB;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly FGEMECIGOCC ABPIGPIDCJJ;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly FGEMECIGOCC CCLONCBHKHP;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool JCMLMGKHKLH;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static JNACHDOMCFC.GGNBAEABPBG.CNPJNGJCEGI JNMPNGCHENO;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0C60", Offset = "0x5E9FA60", VA = "0x185EA0C60")]
		private unsafe static bool HBPJNAFHGNJ(Unity.Entities.Archetype* DFDCBJPJDKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0670", Offset = "0x5E9F470", VA = "0x185EA0670")]
		internal unsafe static Unity.Entities.Archetype*[] DIHNBHDCAND(ref Unity.Entities.EntityComponentStore BGIPDJOGPOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5EA05B0", Offset = "0x5E9F3B0", VA = "0x185EA05B0")]
		public static void DDEFMFGIGDB(MKGAEINCAIG BFCIPJDFKAG, out ByteString AAOFEOFDGLE, out NativeArray<EntityRemapUtility.EntityRemapInfo> AMNCKIPHFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2610", Offset = "0x5EA1410", VA = "0x185EA2610")]
		internal static void PDDGAFLDAEE(MKGAEINCAIG BFCIPJDFKAG, JNACHDOMCFC OBJEIJDACGH, out NativeArray<EntityRemapUtility.EntityRemapInfo> AMNCKIPHFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5EA08F0", Offset = "0x5E9F6F0", VA = "0x185EA08F0")]
		private unsafe static UnsafeHashMap<ulong, BLOJNAOPBJG> EEHOOMLDMGC(Unity.Entities.Archetype*[] OMDFAOENJJO)
		{
			return default(UnsafeHashMap<ulong, BLOJNAOPBJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1850", Offset = "0x5EA0650", VA = "0x185EA1850")]
		private static void JDDONNDOPBK(JNACHDOMCFC OBJEIJDACGH, UnsafeHashMap<ulong, BLOJNAOPBJG> BPJFLHGGGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1520", Offset = "0x5EA0320", VA = "0x185EA1520")]
		private unsafe static void IFGOLKPFFDL(JNACHDOMCFC OBJEIJDACGH, Unity.Entities.Archetype*[] OMDFAOENJJO, UnsafeHashMap<ulong, BLOJNAOPBJG> BPJFLHGGGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5EA14B0", Offset = "0x5EA02B0", VA = "0x185EA14B0")]
		private unsafe static int IEHCNBDJEPP(Unity.Entities.Archetype*[] OMDFAOENJJO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FEE0", Offset = "0x5E9ECE0", VA = "0x185E9FEE0")]
		private unsafe static void CNMNEMIBIHL(JNACHDOMCFC OBJEIJDACGH, Unity.Entities.Archetype*[] OMDFAOENJJO, global::LHAHHAJLMCG<EHDBFDAEFOI> LACPOBNLJLI, NativeArray<EntityRemapUtility.EntityRemapInfo> AMNCKIPHFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1DD0", Offset = "0x5EA0BD0", VA = "0x185EA1DD0")]
		private static NativeArray<int> MONAPMIPADC(JNACHDOMCFC OBJEIJDACGH)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2D40", Offset = "0x5EA1B40", VA = "0x185EA2D40")]
		private static Memory<EntityArchetype> PMJDAOLEOLM(JNACHDOMCFC OBJEIJDACGH, NativeArray<int> LFNDHOPEOFJ, EntityManager PAHBLOLNPLD, out int OEMPGIBFGCN, out int LMEEKEMIHJC)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1A00", Offset = "0x5EA0800", VA = "0x185EA1A00")]
		private unsafe static void JHJCECBAIBF(Unity.Entities.Chunk* FFDDICKOJGJ, ReadOnlySpan<byte> AAOFEOFDGLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0D70", Offset = "0x5E9FB70", VA = "0x185EA0D70")]
		private static void IBOKKOONADE(JNACHDOMCFC OBJEIJDACGH, NativeArray<int> LFNDHOPEOFJ, Span<EntityArchetype> OMDFAOENJJO, EntityManager PAHBLOLNPLD, global::LHAHHAJLMCG<EHDBFDAEFOI> LACPOBNLJLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1D50", Offset = "0x5EA0B50", VA = "0x185EA1D50")]
		private unsafe static void JOOCOLCMOGH(Unity.Entities.Chunk* CFENEJCFJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2040", Offset = "0x5EA0E40", VA = "0x185EA2040")]
		private unsafe static void NCNCPDMMEHO(JNACHDOMCFC.GGNBAEABPBG.DMPKOGOCLFH GCECKOCIPHA, int GJAFANLBBKD, int OOPFEJNKHOO, Unity.Entities.Chunk* FFDDICKOJGJ, JNACHDOMCFC OBJEIJDACGH, NativeArray<int> LFNDHOPEOFJ, global::LHAHHAJLMCG<EHDBFDAEFOI> LACPOBNLJLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F670", Offset = "0x5E9E470", VA = "0x185E9F670")]
		public static void AGKAJOPCGIA(MKGAEINCAIG BFCIPJDFKAG, in ByteString AAOFEOFDGLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F700", Offset = "0x5E9E500", VA = "0x185E9F700")]
		public static void AGKAJOPCGIA(EntityManager PAHBLOLNPLD, global::LHAHHAJLMCG<EHDBFDAEFOI> LACPOBNLJLI, in ByteString AAOFEOFDGLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2350", Offset = "0x5EA1150", VA = "0x185EA2350")]
		private static bool OEIOAOIPNKL(Type LEDIIMFEFLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0300", Offset = "0x5E9F100", VA = "0x185EA0300")]
		private static void CPPICKNHCJJ(TypeManager.TypeInfo HKILGIJBCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FD50", Offset = "0x5E9EB50", VA = "0x185E9FD50")]
		private unsafe static int CFJKIKPBGLE(Unity.Entities.Archetype*[] OMDFAOENJJO, NativeArray<EntityRemapUtility.EntityRemapInfo> AMNCKIPHFNF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0B80", Offset = "0x5E9F980", VA = "0x185EA0B80")]
		private static int FDOHOOGGPOD(int JMJHPMGKKMH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0850", Offset = "0x5E9F650", VA = "0x185EA0850")]
		private static ulong DNINCBNKAEE(int JMJHPMGKKMH)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class MAIIFBAHLBF
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A8F0", Offset = "0x5E996F0", VA = "0x185E9A8F0")]
	private unsafe static Span<byte> HKMLCKDOMMB(Unity.Entities.Chunk* CFENEJCFJAK, int LHPMCKNABCE)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B35280", Offset = "0x2B34080", VA = "0x182B35280")]
	public unsafe static Span<T> JFHEIDLINIK<T>(Unity.Entities.Chunk* CFENEJCFJAK, int LHPMCKNABCE)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B35400", Offset = "0x2B34200", VA = "0x182B35400")]
	public static Span<T> JFHEIDLINIK<T>(this ref Unity.Entities.Chunk CFENEJCFJAK, int LHPMCKNABCE)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A880", Offset = "0x5E99680", VA = "0x185E9A880")]
	public unsafe static Span<Entity> AIFFNJECANG(Unity.Entities.Chunk* CFENEJCFJAK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E9AA90", Offset = "0x5E99890", VA = "0x185E9AA90")]
	public unsafe static void ODCBHOABBME(Unity.Entities.Chunk* CFENEJCFJAK, int LHPMCKNABCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E9AD30", Offset = "0x5E99B30", VA = "0x185E9AD30")]
	public static Entity PIIDFDPJNCM(this EntityQuery NOJJNNFMBAH)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : JHKNIKIBBPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3330", Offset = "0x5EA2130", VA = "0x185EA3330", Slot = "4")]
		public sealed override void FODOGCDFONM()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
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
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x5A01680", Offset = "0x5A00A80", VA = "0x185A01680")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5A03C00", Offset = "0x5A03000", VA = "0x185A03C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x5A03C70", Offset = "0x5A03070", VA = "0x185A03C70")]
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
			[Cpp2IlInjected.Address(RVA = "0x374DEA0", Offset = "0x374D2A0", VA = "0x18374DEA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3136F70", Offset = "0x3136370", VA = "0x183136F70")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3136630", Offset = "0x3135A30", VA = "0x183136630")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3136730", Offset = "0x3135B30", VA = "0x183136730")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3136BA0", Offset = "0x3135FA0", VA = "0x183136BA0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5A03C90", Offset = "0x5A03090", VA = "0x185A03C90")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EGHNNNPKEEJ<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NDIDDJOKEII : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::EGHNNNPKEEJ<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x760C90", Offset = "0x760090", VA = "0x180760C90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3556540", Offset = "0x3555940", VA = "0x183556540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x27E0CC0", Offset = "0x27E00C0", VA = "0x1827E0CC0")]
		[DebuggerHidden]
		public NDIDDJOKEII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3556360", Offset = "0x3555760", VA = "0x183556360", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3556500", Offset = "0x3555900", VA = "0x183556500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> CGNAFFDHJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream DMEDBCCHBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream FNMACIBIANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf FDDBADBDIPK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E08E0", Offset = "0x6DFCE0", VA = "0x1806E08E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C5B2F0", Offset = "0x3C5A6F0", VA = "0x183C5B2F0")]
	private EGHNNNPKEEJ(byte[] IEGPGBKLAIF, Action<Protobuf> CGNAFFDHJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x271AB00", Offset = "0x2719F00", VA = "0x18271AB00")]
	public static global::EGHNNNPKEEJ<Protobuf> BFPHDDBHNEE<Data>(ReadOnlySpan<byte> EJAHCFFDNJB, ReadOnlySpan<Data> HIMJHOIKJJP, Action<Protobuf> CGNAFFDHJNJ)
	{
		return default(global::EGHNNNPKEEJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3C5B160", Offset = "0x3C5A560", VA = "0x183C5B160", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3C5B1A0", Offset = "0x3C5A5A0", VA = "0x183C5B1A0", Slot = "4")]
	[IteratorStateMachine(typeof(global::EGHNNNPKEEJ<>.NDIDDJOKEII))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3C5B2A0", Offset = "0x3C5A6A0", VA = "0x183C5B2A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KMJHANKFCKN<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] IEGPGBKLAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf FDDBADBDIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream DMEDBCCHBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream MONDLBPDJLB;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2E7AC60", Offset = "0x2E7A060", VA = "0x182E7AC60")]
	private KMJHANKFCKN(byte[] IEGPGBKLAIF, in Protobuf FDDBADBDIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2723C10", Offset = "0x2723010", VA = "0x182723C10")]
	public static global::KMJHANKFCKN<Protobuf> BFPHDDBHNEE<T>(ReadOnlySpan<T> HIMJHOIKJJP)
	{
		return default(global::KMJHANKFCKN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2E7AA70", Offset = "0x2E79E70", VA = "0x182E7AA70")]
	public void AGMOJKLDJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2E7ABD0", Offset = "0x2E79FD0", VA = "0x182E7ABD0")]
	public ByteString NCBMHEIJFBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2E7AAA0", Offset = "0x2E79EA0", VA = "0x182E7AAA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NFDABMAANFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream DMEDBCCHBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream FNMACIBIANK;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5A05E10", Offset = "0x5A05210", VA = "0x185A05E10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct FMPGBNGPJCB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] IEGPGBKLAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream DMEDBCCHBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream MONDLBPDJLB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5A03DD0", Offset = "0x5A031D0", VA = "0x185A03DD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FCKDDBLMGBI
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	public static void BDPAIIEPPHB(this FADHLPPNOEF ICGADBEDOKK, NativeArray<Entity> GNGEEFEGDCP, [Optional][CallerFilePath] string EPMHFOMBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	public static void BDPAIIEPPHB(this FADHLPPNOEF ICGADBEDOKK, string IGHJIHNAPBA, NativeArray<Entity> GNGEEFEGDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	public static void BDPAIIEPPHB(this FADHLPPNOEF ICGADBEDOKK, string EPMHFOMBHAO, NativeArray<Entity> GNGEEFEGDCP, bool OCOPNGDLHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	public static void MMJNNMFNOPE(this FADHLPPNOEF ICGADBEDOKK, NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> NKDKBMKAAAG, [Optional][CallerFilePath] string EPMHFOMBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	public static void MMJNNMFNOPE(this FADHLPPNOEF ICGADBEDOKK, string EPMHFOMBHAO, NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> NKDKBMKAAAG, bool OCOPNGDLHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3766CA0", Offset = "0x37660A0", VA = "0x183766CA0")]
	public static void BEIDKKKJKMO<T>(this FADHLPPNOEF ICGADBEDOKK, string IGHJIHNAPBA, NativeArray<Entity> GNGEEFEGDCP, NativeList<T> ONIBEFDCPGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3766C60", Offset = "0x3766060", VA = "0x183766C60")]
	public static void BEIDKKKJKMO<T>(this FADHLPPNOEF ICGADBEDOKK, string IGHJIHNAPBA, NativeArray<Entity> GNGEEFEGDCP, NativeArray<T> ONIBEFDCPGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	public static void BEIDKKKJKMO<T>(this FADHLPPNOEF ICGADBEDOKK, string EPMHFOMBHAO, NativeArray<Entity> GNGEEFEGDCP, NativeArray<T> ONIBEFDCPGD, bool OCOPNGDLHNC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3766D90", Offset = "0x3766190", VA = "0x183766D90")]
	public static void PPCJIEAFDJG<T>(this FADHLPPNOEF ICGADBEDOKK, NativeList<T> ONIBEFDCPGD, [Optional][CallerFilePath] string EPMHFOMBHAO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3766D60", Offset = "0x3766160", VA = "0x183766D60")]
	public static void PPCJIEAFDJG<T>(this FADHLPPNOEF ICGADBEDOKK, NativeArray<T> ONIBEFDCPGD, [Optional][CallerFilePath] string EPMHFOMBHAO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	public static void PPCJIEAFDJG<T>(this FADHLPPNOEF ICGADBEDOKK, string EPMHFOMBHAO, NativeArray<T> ONIBEFDCPGD, bool OCOPNGDLHNC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	public static void FPMALFIOBKI(this FADHLPPNOEF ICGADBEDOKK, EntityQuery JLMGAJOHFKO, [Optional][CallerFilePath] string EPMHFOMBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	public static void FPMALFIOBKI(this FADHLPPNOEF ICGADBEDOKK, string IGHJIHNAPBA, EntityQuery JLMGAJOHFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	public static void FPMALFIOBKI(this FADHLPPNOEF ICGADBEDOKK, string EPMHFOMBHAO, EntityQuery JLMGAJOHFKO, bool OCOPNGDLHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3766D30", Offset = "0x3766130", VA = "0x183766D30")]
	public static void OGOJLDKFEMD<T, T2>(this FADHLPPNOEF ICGADBEDOKK, string IGHJIHNAPBA, EntityQuery JLMGAJOHFKO) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	private static void OGOJLDKFEMD<T, T2>(this FADHLPPNOEF ICGADBEDOKK, string EPMHFOMBHAO, EntityQuery JLMGAJOHFKO, bool OCOPNGDLHNC) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NBKDCFKNMHI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LEEGNLJBNDK FGCCDFCMGPN
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
public interface AKGLNOALMDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOLNMDKMLIP(Entity OAOGLFGGBPI, object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ECEBMHMMNFF(Entity OAOGLFGGBPI, object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EPILLKKPCLC(Entity OAOGLFGGBPI);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EPILLKKPCLC(LEEGNLJBNDK KJNCDAGJAPF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> OBHLCGBDGOB(Entity OAOGLFGGBPI);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NLBJKDDKNCO(Entity OAOGLFGGBPI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IMJKKCAJKJE<TComponentData, TValue> : global::PMFGMAIPJGC<TValue>, IDisposable where TComponentData : struct, NBKDCFKNMHI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class OIFNOGICOPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> NHOGENNANEB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int HGPJFHAOHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x29BC540", Offset = "0x29BB940", VA = "0x1829BC540")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x41757F0", Offset = "0x4174BF0", VA = "0x1841757F0")]
		public bool BCIEMKLIJOB(out TValue JFBPNBNBHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x41756C0", Offset = "0x4174AC0", VA = "0x1841756C0")]
		public void AOHLLDNPMGN(object AJDBKDIMOHA, TValue JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4175770", Offset = "0x4174B70", VA = "0x184175770")]
		public bool BCBAFCFKBLF(object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x41758B0", Offset = "0x4174CB0", VA = "0x1841758B0")]
		public int EDAEEPKFCFE(object AJDBKDIMOHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4175960", Offset = "0x4174D60", VA = "0x184175960")]
		public OIFNOGICOPL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<OIFNOGICOPL> MBFGHJLKLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::JBJIOMDHKBO<LEEGNLJBNDK, OIFNOGICOPL> LFCKAKLIKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager KNABDDPENKI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E8A0", Offset = "0x2B8DCA0", VA = "0x182B8E8A0")]
	public IMJKKCAJKJE(EntityManager KNABDDPENKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E280", Offset = "0x2B8D680", VA = "0x182B8E280", Slot = "4")]
	public void AOLNMDKMLIP(Entity OAOGLFGGBPI, object AJDBKDIMOHA, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E490", Offset = "0x2B8D890", VA = "0x182B8E490", Slot = "5")]
	public bool ECEBMHMMNFF(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E3A0", Offset = "0x2B8D7A0", VA = "0x182B8E3A0", Slot = "6")]
	public bool BCIEMKLIJOB(Entity OAOGLFGGBPI, out TValue JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E470", Offset = "0x2B8D870", VA = "0x182B8E470", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E750", Offset = "0x2B8DB50", VA = "0x182B8E750")]
	private void KEJMBHLFKGH(OIFNOGICOPL DEHJIMCABLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E7D0", Offset = "0x2B8DBD0", VA = "0x182B8E7D0")]
	private bool LCAKLFGAICA(Entity OAOGLFGGBPI, out LEEGNLJBNDK KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E600", Offset = "0x2B8DA00", VA = "0x182B8E600")]
	private void IGHPJCKBEEA(Entity OAOGLFGGBPI, LEEGNLJBNDK KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E880", Offset = "0x2B8DC80", VA = "0x182B8E880")]
	private bool NOAKMGHIMKC(LEEGNLJBNDK KJNCDAGJAPF, out OIFNOGICOPL DEHJIMCABLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E690", Offset = "0x2B8DA90", VA = "0x182B8E690")]
	private OIFNOGICOPL JOGHBIPPEJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PMFGMAIPJGC<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOLNMDKMLIP(Entity OAOGLFGGBPI, object AJDBKDIMOHA, TValue JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ECEBMHMMNFF(Entity OAOGLFGGBPI, object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BCIEMKLIJOB(Entity OAOGLFGGBPI, out TValue JFBPNBNBHOE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct LEEGNLJBNDK : global::BDDOIGLJFOK<LEEGNLJBNDK>, IGCGKLPONMN, IEquatable<LEEGNLJBNDK>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly LEEGNLJBNDK BAMMNFGMJMI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int ICGLEEKOOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x725CB0", Offset = "0x7250B0", VA = "0x180725CB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x727530", Offset = "0x726930", VA = "0x180727530", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int DMLEMNEAJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x761000", Offset = "0x760400", VA = "0x180761000", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x761010", Offset = "0x760410", VA = "0x180761010", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5A049E0", Offset = "0x5A03DE0", VA = "0x185A049E0", Slot = "8")]
	public bool Equals(LEEGNLJBNDK IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5A04A30", Offset = "0x5A03E30", VA = "0x185A04A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GGEJOAKONHH<T> : AKGLNOALMDP, IDisposable where T : struct, NBKDCFKNMHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> MBFGHJLKLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::JBJIOMDHKBO<LEEGNLJBNDK, HashSet<object>> LFCKAKLIKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager KNABDDPENKI;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3D76010", Offset = "0x3D75410", VA = "0x183D76010")]
	public GGEJOAKONHH(EntityManager KNABDDPENKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3D734E0", Offset = "0x3D728E0", VA = "0x183D734E0", Slot = "4")]
	public bool AOLNMDKMLIP(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3D738B0", Offset = "0x3D72CB0", VA = "0x183D738B0", Slot = "5")]
	public bool ECEBMHMMNFF(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3D73DF0", Offset = "0x3D731F0", VA = "0x183D73DF0", Slot = "6")]
	public bool EPILLKKPCLC(Entity OAOGLFGGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3D73FB0", Offset = "0x3D733B0", VA = "0x183D73FB0", Slot = "7")]
	public bool EPILLKKPCLC(LEEGNLJBNDK KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3D75B90", Offset = "0x3D74F90", VA = "0x183D75B90", Slot = "8")]
	public IEnumerable<object> OBHLCGBDGOB(Entity OAOGLFGGBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3D75830", Offset = "0x3D74C30", VA = "0x183D75830", Slot = "11")]
	public IEnumerable<object> OBHLCGBDGOB(LEEGNLJBNDK KJNCDAGJAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3D75650", Offset = "0x3D74A50", VA = "0x183D75650", Slot = "9")]
	public bool NLBJKDDKNCO(Entity OAOGLFGGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3D736E0", Offset = "0x3D72AE0", VA = "0x183D736E0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3D74A60", Offset = "0x3D73E60", VA = "0x183D74A60")]
	private void KEJMBHLFKGH(HashSet<object> DEHJIMCABLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3D74D90", Offset = "0x3D74190", VA = "0x183D74D90")]
	private bool LCAKLFGAICA(Entity OAOGLFGGBPI, out LEEGNLJBNDK KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D75290", Offset = "0x3D74690", VA = "0x183D75290")]
	private bool LPBDGENPIHN(Entity OAOGLFGGBPI, out LEEGNLJBNDK KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3D74190", Offset = "0x3D73590", VA = "0x183D74190")]
	private void GNMHOBCGIDC(Entity OAOGLFGGBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3D74420", Offset = "0x3D73820", VA = "0x183D74420")]
	private void IGHPJCKBEEA(Entity OAOGLFGGBPI, LEEGNLJBNDK KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3D74330", Offset = "0x3D73730", VA = "0x183D74330")]
	private bool HADJJFIACFD(LEEGNLJBNDK KJNCDAGJAPF, out HashSet<object> DEHJIMCABLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3D748E0", Offset = "0x3D73CE0", VA = "0x183D748E0")]
	private HashSet<object> JOGHBIPPEJA()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CPKNOBKFMFB : global::FLEFMMHNPIB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3E96CC0", Offset = "0x3E960C0", VA = "0x183E96CC0", Slot = "4")]
	public float LLEFBOHJFCP(float3 JFBPNBNBHOE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OKGCLHLJCBM : global::FLEFMMHNPIB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5A063F0", Offset = "0x5A057F0", VA = "0x185A063F0", Slot = "4")]
	public float LLEFBOHJFCP(float3 JFBPNBNBHOE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CFNCLKBDBDE : global::FLEFMMHNPIB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5A02C90", Offset = "0x5A02090", VA = "0x185A02C90", Slot = "4")]
	public float LLEFBOHJFCP(float3 JFBPNBNBHOE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct OIKCCKBIGMI : global::FLEFMMHNPIB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xC32010", Offset = "0xC31410", VA = "0x180C32010", Slot = "4")]
	public int LLEFBOHJFCP(int3 JFBPNBNBHOE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KBIMHLAMPFN : global::FLEFMMHNPIB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4258290", Offset = "0x4257690", VA = "0x184258290", Slot = "4")]
	public int LLEFBOHJFCP(int3 JFBPNBNBHOE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct ANDFPMHIGMA : global::FLEFMMHNPIB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5A01670", Offset = "0x5A00A70", VA = "0x185A01670", Slot = "4")]
	public int LLEFBOHJFCP(int3 JFBPNBNBHOE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class PDDKAKIGCDD : NOKAPBEALIO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type KIGFOADOLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F10", Offset = "0x6E1310", VA = "0x1806E1F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5A030D0", Offset = "0x5A024D0", VA = "0x185A030D0")]
	public PDDKAKIGCDD(Type JHEINIGHPCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DDFPMNGAPLM : PDDKAKIGCDD
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5A030D0", Offset = "0x5A024D0", VA = "0x185A030D0")]
	public DDFPMNGAPLM(Type JHEINIGHPCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FBDJPMECLEK : PDDKAKIGCDD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type JHOKPKHDMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6EBA00", Offset = "0x6EAE00", VA = "0x1806EBA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5A03D80", Offset = "0x5A03180", VA = "0x185A03D80")]
	public FBDJPMECLEK(Type FJCPIFFECBD, Type JHEINIGHPCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DFPBKKCJHKF : PDDKAKIGCDD
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5A030D0", Offset = "0x5A024D0", VA = "0x185A030D0")]
	public DFPBKKCJHKF(Type JHEINIGHPCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OEMDBJIOCGA : NOKAPBEALIO
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public OEMDBJIOCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LKFGEBEEFKK : NOKAPBEALIO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PCCEMKBGKDJ NOEAGCHEOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
		[CompilerGenerated]
		get
		{
			return default(PCCEMKBGKDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5A04B10", Offset = "0x5A03F10", VA = "0x185A04B10")]
	public LKFGEBEEFKK(PCCEMKBGKDJ NOECNPHPBKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class JCGKPCPJOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly MJGGLIPIDNP OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager KNABDDPENKI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MJGGLIPIDNP IIINLMPBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5A04650", Offset = "0x5A03A50", VA = "0x185A04650")]
	public JCGKPCPJOOI(MJGGLIPIDNP OACNPKMLCHI, EntityManager KNABDDPENKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x379E640", Offset = "0x379DA40", VA = "0x18379E640")]
	public bool GONGHJONBNE<T>(Entity OAOGLFGGBPI) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x379CBD0", Offset = "0x379BFD0", VA = "0x18379CBD0")]
	public bool AIHJLIGHGOO<T>(Entity OAOGLFGGBPI, out T JFBPNBNBHOE) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x379CC60", Offset = "0x379C060", VA = "0x18379CC60")]
	public T EEBEBPDLEBB<T>(Entity OAOGLFGGBPI) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x379E680", Offset = "0x379DA80", VA = "0x18379E680")]
	private ComponentType LFMNBIPPOGM<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5A04580", Offset = "0x5A03980", VA = "0x185A04580")]
	private ComponentType LFMNBIPPOGM(Type DDJDPMGLPAE)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class EHNCFNMGCGK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	protected EHNCFNMGCGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class MAJGBLJKLMA<View, Data> : BCNEEGFPPIH where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType PNJMNIDKGAI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type IFDLKKLJMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4A002A0", Offset = "0x49FF6A0", VA = "0x184A002A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type HFLBDCLBIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x49FF830", Offset = "0x49FEC30", VA = "0x1849FF830", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int NPFIBDMLPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x40D7DE0", Offset = "0x40D71E0", VA = "0x1840D7DE0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x40D7EA0", Offset = "0x40D72A0", VA = "0x1840D7EA0")]
	public Data IONCAKGEPEH(Entity OAOGLFGGBPI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x40D7D70", Offset = "0x40D7170", VA = "0x1840D7D70")]
	public Data DKDOEGECFDD(Entity OAOGLFGGBPI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View DKKLGNODAJI(Entity OAOGLFGGBPI);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4A94520", Offset = "0x4A93920", VA = "0x184A94520", Slot = "15")]
	protected internal override T DKKLGNODAJI<T>(Entity OAOGLFGGBPI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1B74E80", Offset = "0x1B74280", VA = "0x181B74E80")]
	protected MAJGBLJKLMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class BCNEEGFPPIH : CNAIHAMIBKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic OBJFOIDBNHL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x84E8A0", Offset = "0x84DCA0", VA = "0x18084E8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type IFDLKKLJMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type HFLBDCLBIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int NPFIBDMLPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type DIHNBJGBECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAFD2A0", Offset = "0xAFC6A0", VA = "0x180AFD2A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int OKODNLKNBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5A01930", Offset = "0x5A00D30", VA = "0x185A01930", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private GKFDLLIKKMD[] BKHMEBJPNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAFD1D0", Offset = "0xAFC5D0", VA = "0x180AFD1D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual GKFDLLIKKMD[] LAMFBEMMFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5A01AF0", Offset = "0x5A00EF0", VA = "0x185A01AF0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CPFKDKBAAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5A01AC0", Offset = "0x5A00EC0", VA = "0x185A01AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5A019A0", Offset = "0x5A00DA0", VA = "0x185A019A0")]
	public void BNACPANAOEJ(EntityManager KNABDDPENKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7260B0", Offset = "0x7254B0", VA = "0x1807260B0")]
	protected CNAIHAMIBKF BJINNEHPFHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T DKKLGNODAJI<T>(Entity OAOGLFGGBPI) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5A01870", Offset = "0x5A00C70", VA = "0x185A01870", Slot = "8")]
	public (uint, uint) BDKOAHPPKOB(Entity OAOGLFGGBPI)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5A01BB0", Offset = "0x5A00FB0", VA = "0x185A01BB0", Slot = "9")]
	public bool PHKNCADEDHN(Entity OAOGLFGGBPI, (uint order, uint change) FLPPPNDNNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	protected BCNEEGFPPIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class BHACELLLGBD<Data> : CMIJGGBLCJC where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data HMBHBEDALCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x29B9950", Offset = "0x29B8D50", VA = "0x1829B9950", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x29B9A90", Offset = "0x29B8E90", VA = "0x1829B9A90", Slot = "8")]
	protected virtual bool NKCHLENEANC(ReadOnlySpan<Data> HIMJHOIKJJP, CEADEEFJIGK CIEABJMCJGJ, out ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "9")]
	protected virtual bool DKHHDDPIABM(int FLPPPNDNNNB, Span<Data> HIMJHOIKJJP, in ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x29B99D0", Offset = "0x29B8DD0", VA = "0x1829B99D0", Slot = "5")]
	internal sealed override bool NKCHLENEANC(ref Unity.Entities.Chunk FGCHPEJCAHE, int LIMNOLJBNOG, CEADEEFJIGK CIEABJMCJGJ, out ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x29B8530", Offset = "0x29B7930", VA = "0x1829B8530", Slot = "6")]
	internal sealed override bool DKHHDDPIABM(int FLPPPNDNNNB, ref Unity.Entities.Chunk FGCHPEJCAHE, int LIMNOLJBNOG, in ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x27179A0", Offset = "0x2716DA0", VA = "0x1827179A0")]
	protected global::KMJHANKFCKN<Protobuf> EDKIFHOMMDO<Protobuf>(ReadOnlySpan<Data> HIMJHOIKJJP) where Protobuf : IMessage, new()
	{
		return default(global::KMJHANKFCKN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x27179F0", Offset = "0x2716DF0", VA = "0x1827179F0")]
	protected global::EGHNNNPKEEJ<Protobuf> JDPCILKAFOO<Protobuf>(ReadOnlySpan<byte> EJAHCFFDNJB, ReadOnlySpan<Data> HIMJHOIKJJP, Action<Protobuf> CGNAFFDHJNJ) where Protobuf : IMessage, new()
	{
		return default(global::EGHNNNPKEEJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1B74E80", Offset = "0x1B74280", VA = "0x181B74E80")]
	protected BHACELLLGBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class CMIJGGBLCJC
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int DMLEMNEAJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5A02CB0", Offset = "0x5A020B0", VA = "0x185A02CB0", Slot = "5")]
	internal virtual bool NKCHLENEANC(ref Unity.Entities.Chunk FGCHPEJCAHE, int LIMNOLJBNOG, CEADEEFJIGK CIEABJMCJGJ, out ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "6")]
	internal virtual bool DKHHDDPIABM(int FLPPPNDNNNB, ref Unity.Entities.Chunk FGCHPEJCAHE, int LIMNOLJBNOG, in ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	protected CMIJGGBLCJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface FLEFMMHNPIB<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LLEFBOHJFCP(TFrom JFBPNBNBHOE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface EJMMMNPKOBH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MONGDJMFKMD(T JFBPNBNBHOE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct KDCLMJIKHDJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::FLEFMMHNPIB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> PJKMBIPBMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> MNCPPCAONPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap GPNJNMLGIEN;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct LJDKOFKMKDD<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::FLEFMMHNPIB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> MKAMHFPEEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> MNCPPCAONPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap GPNJNMLGIEN;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct OHFADJHIGDE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DAMFEEKEGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> PJKMBIPBMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> MNCPPCAONPG;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x416A470", Offset = "0x4169870", VA = "0x18416A470", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct KLNPBJONHKL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DAMFEEKEGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> PJKMBIPBMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> BILEKPJCONA;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct EPKGEOPMBON<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::FLEFMMHNPIB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> IGBACEKFFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> MNCPPCAONPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap GPNJNMLGIEN;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct PPEOFMDMPAD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JHEINIGHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> EOPMDICNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> LJFGNBGIBCL;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct OLAJMLAJHGC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JHEINIGHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> EOPMDICNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> LJFGNBGIBCL;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2DF9330", Offset = "0x2DF8730", VA = "0x182DF9330", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct BJOGMOBDKOK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> PJKMBIPBMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> BILEKPJCONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, CHLMDABNGKB> HNCPDLIBBAB;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x29BC030", Offset = "0x29BB430", VA = "0x1829BC030", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct HBGDIHGGAOF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::FLEFMMHNPIB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> PJKMBIPBMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> BILEKPJCONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, CHLMDABNGKB> HNCPDLIBBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap GPNJNMLGIEN;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct IFNHFJHBNNA<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::EJMMMNPKOBH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> PJKMBIPBMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> BILEKPJCONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate GPNJNMLGIEN;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct AKBABAPEFJF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity JHEINIGHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> EOPMDICNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> AJPMICLNHDN;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5A015E0", Offset = "0x5A009E0", VA = "0x185A015E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct LCOBAAJDEIA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity JHEINIGHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> EOPMDICNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> AJPMICLNHDN;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5A046A0", Offset = "0x5A03AA0", VA = "0x185A046A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class BAIKILEAJIG
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class EMIHFIOJJMK
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x27C8760", Offset = "0x27C7B60", VA = "0x1827C8760")]
	public static bool PHABNNLDFEA<T>(this NativeArray<Entity> EOPMDICNPHI, EntityManager KNABDDPENKI, Allocator OPBLDCCKGEG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class BPCGDEJODGD
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MFGNCELPHKK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public MFGNCELPHKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class BDLIGFPJGDL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public BDLIGFPJGDL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> ENPMBJDHLFC;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5A02A50", Offset = "0x5A01E50", VA = "0x185A02A50")]
	public BPCGDEJODGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class PGHHJCDLODM
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KLFCDFCFNJH
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct JHKLFPFGNKK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct OELFLPNKDNN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal JHKLFPFGNKK<TFrom> GPFONCECPBK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator OPBLDCCKGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> NKOMPJIJHJB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct MBKMJGOEDEN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct KHKBEJFNGCP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal MBKMJGOEDEN<TFrom> GPFONCECPBK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator OPBLDCCKGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> NKOMPJIJHJB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct OKFHIHDPIOP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct LBEOLDAMEFP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal OKFHIHDPIOP<TFrom> GPFONCECPBK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator OPBLDCCKGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> NKOMPJIJHJB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct EPFCEKEIHCL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct LKKLGIMNJKC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal EPFCEKEIHCL<TFrom> GPFONCECPBK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator OPBLDCCKGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> NKOMPJIJHJB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class ANJOKDNNMCN
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DBMPJHCNFEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C448C0", Offset = "0x2C43CC0", VA = "0x182C448C0")]
	public static NativeList<T> MPKIADLDDNH<T>(this NativeArray<T> LOKAAAHFJIL, Allocator OPBLDCCKGEG = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class GIPJCMGFMOP
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E5FEC0", Offset = "0x2E5F2C0", VA = "0x182E5FEC0")]
	public static NativeArray<T> CDILAKKLAKI<T>(this NativeList<Entity> LOKAAAHFJIL, EntityManager KNABDDPENKI, Allocator OPBLDCCKGEG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E5FDC0", Offset = "0x2E5F1C0", VA = "0x182E5FDC0")]
	public static NativeArray<T> CDILAKKLAKI<T>(this NativeArray<Entity> LOKAAAHFJIL, EntityManager KNABDDPENKI, Allocator OPBLDCCKGEG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class IIPEGEOABOA
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct EFOLOBCICEI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct LKGBAMMDGGF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public EFOLOBCICEI<TFrom> NKOMPJIJHJB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator OPBLDCCKGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> PJKMBIPBMLB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct LOAJMOAOMDH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct DBMGEABLHHE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public LOAJMOAOMDH<TFrom> NKOMPJIJHJB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator OPBLDCCKGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> PJKMBIPBMLB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct PFHBJNOMCGP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct PLNOEACMJEJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public PFHBJNOMCGP<TFrom> NKOMPJIJHJB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator OPBLDCCKGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> PJKMBIPBMLB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FJHFEHJDADM
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class GDKBJPOAKEP
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct PMLEJIBPJKB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator OPBLDCCKGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> PJKMBIPBMLB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct GNGKGMNPKCG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator OPBLDCCKGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> PJKMBIPBMLB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct CBGPIJOAPHG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator OPBLDCCKGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> PJKMBIPBMLB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct JPMJFNHELHJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator OPBLDCCKGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> PJKMBIPBMLB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class GGMKCLEOMHO
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class GMAMBPBIEGO
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2E60790", Offset = "0x2E5FB90", VA = "0x182E60790")]
	public static NativeList<Entity> BEOJGGECBAP<T>(this NativeArray<Entity> EOPMDICNPHI, EntityManager KNABDDPENKI, Allocator OPBLDCCKGEG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class EPLJGKKNPDA
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HJIPHHDDKPK
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface PLLDOJJHDBC
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class AJAGLBHOLOC
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class LOJNAPBGJBG
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5A04B40", Offset = "0x5A03F40", VA = "0x185A04B40")]
	public static bool JIFLAFOBNIM(Type DDJDPMGLPAE, Type AHFHAGLCOKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class MNOPMBAAKNH<Attribute, BaseClass> : global::PFAMOLIMCKL<BaseClass>, NHFAACLOLLJ where Attribute : PDDKAKIGCDD
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly FADHLPPNOEF ICGADBEDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string IGHJIHNAPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> BFNNAFNBION;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3FC60D0", Offset = "0x3FC54D0", VA = "0x183FC60D0")]
	public MNOPMBAAKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3FC5BC0", Offset = "0x3FC4FC0", VA = "0x183FC5BC0", Slot = "4")]
	public bool GPEECKGOEKF(int NLGBDLLFIPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3FC5D20", Offset = "0x3FC5120", VA = "0x183FC5D20", Slot = "5")]
	public global::DGIKCDEPKDI<BaseClass> KHMHFCONDBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3FC5C20", Offset = "0x3FC5020", VA = "0x183FC5C20", Slot = "7")]
	protected virtual bool JIFLAFOBNIM(Type DDJDPMGLPAE, int PCILGJMHFDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3FC5AA0", Offset = "0x3FC4EA0", VA = "0x183FC5AA0", Slot = "8")]
	protected virtual int FHCBHFPLJDG(Type DDJDPMGLPAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3FC5B30", Offset = "0x3FC4F30", VA = "0x183FC5B30")]
	public void FKBDNONAKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3FC5FD0", Offset = "0x3FC53D0", VA = "0x183FC5FD0", Slot = "6")]
	public void KJDPCLCGNLB(Type DDJDPMGLPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DGIKCDEPKDI<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> EGAMAKGJOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> ECAOIAEJACA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> JOACEHDIPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x32EB980", Offset = "0x32EAD80", VA = "0x1832EB980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x32EBC50", Offset = "0x32EB050", VA = "0x1832EBC50")]
	public DGIKCDEPKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x32EBDE0", Offset = "0x32EB1E0", VA = "0x1832EBDE0")]
	public DGIKCDEPKDI(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x32EB900", Offset = "0x32EAD00", VA = "0x1832EB900")]
	internal void AOHLLDNPMGN(int NLGBDLLFIPJ, BaseClass BDAAELOCEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2719650", Offset = "0x2718A50", VA = "0x182719650")]
	public bool OBHIMHLDBEA<T>(out BaseClass JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x32EBBB0", Offset = "0x32EAFB0", VA = "0x1832EBBB0")]
	public bool OBHIMHLDBEA(Type HBILNHOEIJP, out BaseClass JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2D95DC0", Offset = "0x2D951C0", VA = "0x182D95DC0")]
	public bool PLNJJFMAJFL(int NLGBDLLFIPJ, out BaseClass JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2719570", Offset = "0x2718970", VA = "0x182719570")]
	public T AJOJPPMCNBH<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x32EB8D0", Offset = "0x32EACD0", VA = "0x1832EB8D0")]
	public BaseClass AJOJPPMCNBH(Type AEOIHBBMHFN)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class ABKEGIJMKKA : global::MNOPMBAAKNH<DDFPMNGAPLM, EHNCFNMGCGK>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5A01380", Offset = "0x5A00780", VA = "0x185A01380")]
	public ABKEGIJMKKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class BFBEPOBILJF : global::MNOPMBAAKNH<FBDJPMECLEK, BCNEEGFPPIH>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5A02150", Offset = "0x5A01550", VA = "0x185A02150")]
	public BFBEPOBILJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class HKFEIOAAPCD : global::MNOPMBAAKNH<DFPBKKCJHKF, CMIJGGBLCJC>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5A044E0", Offset = "0x5A038E0", VA = "0x185A044E0")]
	public HKFEIOAAPCD()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[MBALNPKLAGP(FOFKCKDBIPD.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> CDFICLLHOEC;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F00", Offset = "0x6E1300", VA = "0x1806E1F00")]
		private ComponentSystemTypes(List<Type> CDFICLLHOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5A02CD0", Offset = "0x5A020D0", VA = "0x185A02CD0")]
		public static void FKBDNONAKOB(List<Type> CDFICLLHOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5A02DE0", Offset = "0x5A021E0", VA = "0x185A02DE0")]
		private void KILOFIIMADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5A02D60", Offset = "0x5A02160", VA = "0x185A02D60")]
		private bool JIFLAFOBNIM(Type DDJDPMGLPAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5A03020", Offset = "0x5A02420", VA = "0x185A03020")]
		private void NBJLJAPHPCI(Type DDJDPMGLPAE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class LINMPAMPHKC : LDDGDFHPCLL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5A04AD0", Offset = "0x5A03ED0", VA = "0x185A04AD0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase OFJPBMMHHBG();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5A04A80", Offset = "0x5A03E80", VA = "0x185A04A80")]
	protected ComponentSystemBase LMGBGMAKAOM(params ComponentSystemBase[] HOCPKHHLENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x28785C0", Offset = "0x28779C0", VA = "0x1828785C0")]
	protected ComponentSystemBase LMGBGMAKAOM<T>(params ComponentSystemBase[] HOCPKHHLENG) where T : LDDGDFHPCLL, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2878580", Offset = "0x2877980", VA = "0x182878580")]
	protected ComponentSystemBase PDAPPLNMINF<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2878580", Offset = "0x2877980", VA = "0x182878580")]
	protected ComponentSystemBase ICFNCPBNEBL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	protected LINMPAMPHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface PFAMOLIMCKL<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPEECKGOEKF(int NLGBDLLFIPJ);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DGIKCDEPKDI<BaseClass> KHMHFCONDBB();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class LDDGDFHPCLL : NJNNEPAPPEL
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5A04730", Offset = "0x5A03B30", VA = "0x185A04730", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public LDDGDFHPCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class DHDEFGPGMMG : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5A03980", Offset = "0x5A02D80", VA = "0x185A03980")]
	public ComponentDataFromEntity CGCAABFHGFN(int NLGBDLLFIPJ, bool LPKIEPPBIHF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5A03A20", Offset = "0x5A02E20", VA = "0x185A03A20", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
	protected DHDEFGPGMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class CICADLGFANF : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
	protected CICADLGFANF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class ILHKCJPPBMP : DHDEFGPGMMG
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5A04550", Offset = "0x5A03950", VA = "0x185A04550", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	protected void BNCJEJEKKDP(string HKGFIHMBIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
	protected ILHKCJPPBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class HBHGBJHCDDK
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class NJNNEPAPPEL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	protected NJNNEPAPPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[MBALNPKLAGP(FOFKCKDBIPD.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5A06820", Offset = "0x5A05C20", VA = "0x185A06820")]
		public static ComponentSystemGroup[] FAMNOHPACPJ(World OACNPKMLCHI, DPJCHDCGBCJ FHIJGAAPLEJ = DPJCHDCGBCJ.Default, bool CNOLPIGFANK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5A06B70", Offset = "0x5A05F70", VA = "0x185A06B70")]
		private static Type[] KCFJIBFPFCA(DPJCHDCGBCJ FHIJGAAPLEJ, bool CNOLPIGFANK, ComponentSystemGroup[] ELJPDMBHKGP, ComponentSystemGroup NJHJCPCELCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5A06ED0", Offset = "0x5A062D0", VA = "0x185A06ED0")]
		private static ComponentSystemGroup[] LJMAOKAMKAH(World OACNPKMLCHI, out ComponentSystemGroup NJHJCPCELCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5A068F0", Offset = "0x5A05CF0", VA = "0x185A068F0")]
		internal static bool HECPNILDABA(PCCEMKBGKDJ NOECNPHPBKJ, out DFEDEMKJADL PENLMJJIFEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5A071E0", Offset = "0x5A065E0", VA = "0x185A071E0")]
		private static ComponentSystemGroup NGOJKMFMDLF(Type DDJDPMGLPAE, World OACNPKMLCHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5A066F0", Offset = "0x5A05AF0", VA = "0x185A066F0")]
		private static ComponentSystemGroup[] CDHDJGCKFDI(Type[] CDFICLLHOEC, World OACNPKMLCHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5A07380", Offset = "0x5A06780", VA = "0x185A07380")]
		internal static void PHMGKKNLGHB(World OACNPKMLCHI, Type[] AGBKMCALOHL, ComponentSystemGroup[] ELJPDMBHKGP, ComponentSystemGroup NJHJCPCELCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5A072C0", Offset = "0x5A066C0", VA = "0x185A072C0")]
		internal static bool NIEJNJCCIMF(ComponentSystemBase DCOPHBBEGEL, ComponentSystemGroup[] ELJPDMBHKGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5A07320", Offset = "0x5A06720", VA = "0x185A07320")]
		private static void OHLFOLEJDEM(ComponentSystemGroup[] ELJPDMBHKGP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct AIAJCPEANBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> KKCEAEGPCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> HOCPKHHLENG;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x9B6E00", Offset = "0x9B6200", VA = "0x1809B6E00")]
	public AIAJCPEANBP(Dictionary<Type, List<Type>> KKCEAEGPCGJ, HashSet<Type> HOCPKHHLENG)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[MBALNPKLAGP(FOFKCKDBIPD.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class OFENBEPHCCA : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x75EDA0", Offset = "0x75E1A0", VA = "0x18075EDA0")]
			[DebuggerHidden]
			public OFENBEPHCCA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5A06310", Offset = "0x5A05710", VA = "0x185A06310", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5A06070", Offset = "0x5A05470", VA = "0x185A06070", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5A063A0", Offset = "0x5A057A0", VA = "0x185A063A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5A062D0", Offset = "0x5A056D0", VA = "0x185A062D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5A06220", Offset = "0x5A05620", VA = "0x185A06220", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5A06220", Offset = "0x5A05620", VA = "0x185A06220", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct KAOCBJKJFMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type CHKODJILPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private DPJCHDCGBCJ FHIJGAAPLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool PMLBPANKLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool JJGKAAEHOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool CNOLPIGFANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> KOAPKMABCLK;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5A07930", Offset = "0x5A06D30", VA = "0x185A07930")]
		public static RRFilterWorldSystems BFPHDDBHNEE()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5A07B40", Offset = "0x5A06F40", VA = "0x185A07B40")]
		public RRFilterWorldSystems IFAFKPPLBHG(DPJCHDCGBCJ NOECNPHPBKJ)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5A086E0", Offset = "0x5A07AE0", VA = "0x185A086E0")]
		public RRFilterWorldSystems PCCLOBOHJOI(IEnumerable<Type> CDFICLLHOEC)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5A07B50", Offset = "0x5A06F50", VA = "0x185A07B50")]
		public RRFilterWorldSystems IGDGLCJFAKM(bool FGOIMOKCEPI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5A07DB0", Offset = "0x5A071B0", VA = "0x185A07DB0")]
		public RRFilterWorldSystems JPDAMDOIOGP(bool EINMLEBPFNI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5A07950", Offset = "0x5A06D50", VA = "0x185A07950")]
		public AIAJCPEANBP DPBLJNEKJFJ(Type[] GINBJMEIHMO)
		{
			return default(AIAJCPEANBP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5A07D20", Offset = "0x5A07120", VA = "0x185A07D20")]
		[IteratorStateMachine(typeof(OFENBEPHCCA))]
		internal IEnumerable<Type> JOEIFABPELP(IEnumerable<Type> CDFICLLHOEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5A08400", Offset = "0x5A07800", VA = "0x185A08400")]
		internal Dictionary<Type, List<Type>> NHGBKBHLPPO(IEnumerable<Type> CDFICLLHOEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5A08720", Offset = "0x5A07B20", VA = "0x185A08720")]
		private void PMLBNJLPAII(Dictionary<Type, List<Type>> PLBLCMNMLJO, Type DDJDPMGLPAE, Type NDBJGKINPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5A07B60", Offset = "0x5A06F60", VA = "0x185A07B60")]
		internal HashSet<Type> JBPBHNGAFOP(IEnumerable<Type> ELJPDMBHKGP, Dictionary<Type, List<Type>> KFCGKKLOJFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5A07DC0", Offset = "0x5A071C0", VA = "0x185A07DC0")]
		internal bool NCOBNAIOLLI(Type DDJDPMGLPAE, DPJCHDCGBCJ FHIJGAAPLEJ, bool CNOLPIGFANK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5A079E0", Offset = "0x5A06DE0", VA = "0x185A079E0")]
		[CompilerGenerated]
		internal static void GMLNFAKGJNM(Type DDJDPMGLPAE, ref KAOCBJKJFMO P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class ODJJFFNKECE
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool LCKFEIIEMOL;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5A05E50", Offset = "0x5A05250", VA = "0x185A05E50")]
	public static void BNACPANAOEJ(bool BIOMHNNIJHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5A05EB0", Offset = "0x5A052B0", VA = "0x185A05EB0")]
	private static void NHLFCDOAJNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class OPJAHMAGFMA
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5A06400", Offset = "0x5A05800", VA = "0x185A06400")]
	public static ulong IPKMFNMNHJC(Type DDJDPMGLPAE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5A06430", Offset = "0x5A05830", VA = "0x185A06430")]
	public static ulong IPKMFNMNHJC(string DJPLOAMEMKF)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[MBALNPKLAGP(FOFKCKDBIPD.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct BBDBCEIGBOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong MPOFDDDOIKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong BHJLMNGDDBL;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9C8E50", Offset = "0x9C8250", VA = "0x1809C8E50")]
			public BBDBCEIGBOC(ulong FLEGDLHOKBO, ulong LENMLPEBGNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5A017E0", Offset = "0x5A00BE0", VA = "0x185A017E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> LPDDPFIFLLB;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static BBDBCEIGBOC[] HJIECAGGNAJ;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool LCKFEIIEMOL;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5A09590", Offset = "0x5A08990", VA = "0x185A09590")]
		public static ulong OGGOCKFMKEA(int NLGBDLLFIPJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5A08BE0", Offset = "0x5A07FE0", VA = "0x185A08BE0")]
		public static int EPLBOJLNCOI(ulong LENMLPEBGNA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5A08910", Offset = "0x5A07D10", VA = "0x185A08910")]
		public static void BNACPANAOEJ(bool BIOMHNNIJHG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5A09440", Offset = "0x5A08840", VA = "0x185A09440")]
		private static void NHDOJKPOAGH(int MBBNHNOEHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5A09090", Offset = "0x5A08490", VA = "0x185A09090")]
		private static void KFNNFIPGBOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5A08B00", Offset = "0x5A07F00", VA = "0x185A08B00")]
		private static BBDBCEIGBOC CFODGOFDPHD(Type DDJDPMGLPAE)
		{
			return default(BBDBCEIGBOC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5A09520", Offset = "0x5A08920", VA = "0x185A09520")]
		private static ulong NLGODMBLJJK(Type DDJDPMGLPAE, ulong LENMLPEBGNA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5A08D70", Offset = "0x5A08170", VA = "0x185A08D70")]
		private static void IMMGCOIGDOL(in BBDBCEIGBOC AJFKKDDBKCH, TypeManager.TypeInfo LPJJKKGIFPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5A08F90", Offset = "0x5A08390", VA = "0x185A08F90")]
		private static void JBJPJHNKMIJ(BBDBCEIGBOC LPJJKKGIFPB, int NLGBDLLFIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5A08C90", Offset = "0x5A08090", VA = "0x185A08C90")]
		private static void IFCLAEPCDGH(BBDBCEIGBOC LPJJKKGIFPB, int NLGBDLLFIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5A093B0", Offset = "0x5A087B0", VA = "0x185A093B0")]
		private static BBDBCEIGBOC MGLBHJDLKJF(int NLGBDLLFIPJ)
		{
			return default(BBDBCEIGBOC);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5A08900", Offset = "0x5A07D00", VA = "0x185A08900")]
		private static int BFHECMOODID(int NLGBDLLFIPJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class DGEPDNCHNHF
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly BFBEPOBILJF HHDMBEAODIH;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly HKFEIOAAPCD GHOJHKIAGIE;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly ABKEGIJMKKA MNEPDFEBMEG;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> DBIGBDMICHB;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool LCKFEIIEMOL;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::PFAMOLIMCKL<BCNEEGFPPIH> OOPBLHFDPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5A03690", Offset = "0x5A02A90", VA = "0x185A03690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::PFAMOLIMCKL<CMIJGGBLCJC> INGMDHHFJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5A036F0", Offset = "0x5A02AF0", VA = "0x185A036F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::PFAMOLIMCKL<EHNCFNMGCGK> NDIDNHFPBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5A035B0", Offset = "0x5A029B0", VA = "0x185A035B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5A03100", Offset = "0x5A02500", VA = "0x185A03100")]
	public static void BNACPANAOEJ(bool BIOMHNNIJHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5A03610", Offset = "0x5A02A10", VA = "0x185A03610")]
	public static Type[] FCDEGJJLGLB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class BEBLOPBMCCG
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> GAILLBBHBGD;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool LCKFEIIEMOL;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5A01C40", Offset = "0x5A01040", VA = "0x185A01C40")]
	public static int BDKOAHPPKOB(int NLGBDLLFIPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5A01CE0", Offset = "0x5A010E0", VA = "0x185A01CE0")]
	public static void BNACPANAOEJ(bool BIOMHNNIJHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5A01E50", Offset = "0x5A01250", VA = "0x185A01E50")]
	private static void PNJLPMMGLLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5A01E00", Offset = "0x5A01200", VA = "0x185A01E00")]
	private static int OLHEAGGDLJJ(Type DDJDPMGLPAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5A01D80", Offset = "0x5A01180", VA = "0x185A01D80")]
	private static void FPNLAFLJCKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class MJGGLIPIDNP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World KIIGBAKFJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly JCGKPCPJOOI BDAAELOCEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] ELJPDMBHKGP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World IIINLMPBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World JMJANPOMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xDCB720", Offset = "0xDCAB20", VA = "0x180DCB720")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public JCGKPCPJOOI OHPMAEDABBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::DGIKCDEPKDI<BCNEEGFPPIH> OOPBLHFDPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7530C0", Offset = "0x7524C0", VA = "0x1807530C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::DGIKCDEPKDI<CMIJGGBLCJC> INGMDHHFJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6E1830", Offset = "0x6E0C30", VA = "0x1806E1830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::DGIKCDEPKDI<EHNCFNMGCGK> NDIDNHFPBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E3550", VA = "0x1806E4150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6E43E0", Offset = "0x6E37E0", VA = "0x1806E43E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> NGMCJEFJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xDCB760", Offset = "0xDCAB60", VA = "0x180DCB760")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] LEHOIONCOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5A05500", Offset = "0x5A04900", VA = "0x185A05500")]
	public static MJGGLIPIDNP LDDMAKHBJFK(string IGHJIHNAPBA, PCCEMKBGKDJ NOECNPHPBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5A058F0", Offset = "0x5A04CF0", VA = "0x185A058F0")]
	public MJGGLIPIDNP(string IGHJIHNAPBA, PCCEMKBGKDJ NOECNPHPBKJ = PCCEMKBGKDJ.Simulation, DPJCHDCGBCJ FHIJGAAPLEJ = DPJCHDCGBCJ.Default, bool BIOMHNNIJHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5A05480", Offset = "0x5A04880", VA = "0x185A05480")]
	public ComponentSystemBase JENJJJPAFEE(Type DDJDPMGLPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x33BDBA0", Offset = "0x33BCFA0", VA = "0x1833BDBA0")]
	public T JENJJJPAFEE<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5A04F70", Offset = "0x5A04370", VA = "0x185A04F70")]
	public void DBCKGBHABAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5A05660", Offset = "0x5A04A60", VA = "0x185A05660")]
	public void MLNADKJEIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5A04F10", Offset = "0x5A04310", VA = "0x185A04F10")]
	public void CONPHBKOBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5A056C0", Offset = "0x5A04AC0", VA = "0x185A056C0")]
	public void MMLCFFJDOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5A05580", Offset = "0x5A04980", VA = "0x185A05580")]
	public void LIGLPECAGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5A05150", Offset = "0x5A04550", VA = "0x185A05150")]
	public void HEIHMHFCDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5A04EB0", Offset = "0x5A042B0", VA = "0x185A04EB0")]
	public void BHGIMPDFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5A05860", Offset = "0x5A04C60", VA = "0x185A05860")]
	public void PDDOCHODEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5A05800", Offset = "0x5A04C00", VA = "0x185A05800")]
	public void OHKGNKPAFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5A054A0", Offset = "0x5A048A0", VA = "0x185A054A0")]
	public void JFOGKNPOCCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5A05720", Offset = "0x5A04B20", VA = "0x185A05720")]
	internal void NLKKAEFLIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5A055E0", Offset = "0x5A049E0", VA = "0x185A055E0")]
	private bool LOPHFAPFAIM(ComponentSystemGroup HMGHGFKHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5A051B0", Offset = "0x5A045B0", VA = "0x185A051B0")]
	private void IOLJICGAJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5A05040", Offset = "0x5A04440", VA = "0x185A05040")]
	private ComponentSystemGroup[] FAMNOHPACPJ(DPJCHDCGBCJ FHIJGAAPLEJ, bool CNOLPIGFANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5A04FD0", Offset = "0x5A043D0", VA = "0x185A04FD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum PCCEMKBGKDJ
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
public sealed class LAOCDCIFBNJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public DPJCHDCGBCJ FCJIAGMMPIE;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum DPJCHDCGBCJ
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
public interface DFEDEMKJADL
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type OOHLGBIDGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] IDJLFJAIGCO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class FCHADADEKJP : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool KPCCADDLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	protected FCHADADEKJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class BADAIICIPJH : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public BADAIICIPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class CDPBEFOKBPH : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public CDPBEFOKBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class PAADBABBJJN : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public PAADBABBJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class OODOIKMOLLK : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public OODOIKMOLLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class OLEIJCJDIOL : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public OLEIJCJDIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class FLHGDPEKGFK : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public FLHGDPEKGFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class BKFNKEDABJH : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public BKFNKEDABJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class GCJNDOFEDGI : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public GCJNDOFEDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class MBLOIJIFAEE : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public MBLOIJIFAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class MENAGEAHGAA : IJMENJKMODF
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public MENAGEAHGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class FOGAEHKMBML : IJMENJKMODF
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public FOGAEHKMBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class OFMMALPBPPE : IJMENJKMODF
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public OFMMALPBPPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class IOHJPJGEGDO : IJMENJKMODF
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public IOHJPJGEGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[ELANPKCEIEO(JHCKAKNDFFP.Application)]
public class IJMENJKMODF : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool KPCCADDLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0")]
	public IJMENJKMODF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class GHMAJOMNKOK : NOKAPBEALIO
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public GHMAJOMNKOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class OPOMPJLOPEP
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void NPMLLPDMEPH<From, To>(From NKOMPJIJHJB, ref To HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class MMAPGCLKFGC<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static NPMLLPDMEPH<From, To> KLBBKHKDGBJ;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public MMAPGCLKFGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5A064F0", Offset = "0x5A058F0", VA = "0x185A064F0")]
	static OPOMPJLOPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3271290", Offset = "0x3270690", VA = "0x183271290")]
	public static void ACMMGIDBFPP<T>(NPMLLPDMEPH<T, T> EFAEFNCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3271000", Offset = "0x3270400", VA = "0x183271000")]
	public static void ACMMGIDBFPP<From, To>(NPMLLPDMEPH<From, To> EFAEFNCLJOG, NPMLLPDMEPH<To, From> MEDIABCDJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3271090", Offset = "0x3270490", VA = "0x183271090")]
	public static void ACMMGIDBFPP<From, To>(NPMLLPDMEPH<From, To> KLBBKHKDGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3275B20", Offset = "0x3274F20", VA = "0x183275B20")]
	public static NPMLLPDMEPH<From, To> MHHDHGNGFPE<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3273080", Offset = "0x3272480", VA = "0x183273080")]
	public static void GNMIMBAOKMA<From, To>(From NKOMPJIJHJB, ref To HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class CEADEEFJIGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> BPEGOEMBBAG;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x15DDD00", Offset = "0x15DD100", VA = "0x1815DDD00")]
	public CEADEEFJIGK(NativeArray<EntityRemapUtility.EntityRemapInfo> BPEGOEMBBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3A40CE0", Offset = "0x3A400E0", VA = "0x183A40CE0")]
	public Entity NPBIPAECEOK(Entity GEMNKBDIDNJ)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class AGKHJBLJEGA
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> KIIMKNKFHCO;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5A013F0", Offset = "0x5A007F0", VA = "0x185A013F0")]
	public static bool MNAIEOGGAGG(ulong JBFGBNAHGLM, uint FLPPPNDNNNB, out string IGHJIHNAPBA)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct LDIOKPHAPDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int ICGLEEKOOLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int DMLEMNEAJDL;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x74EC80", Offset = "0x74E080", VA = "0x18074EC80")]
			public LDIOKPHAPDF(int BELCAJFDAHD, int FLPPPNDNNNB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct MCGJLILGCMB
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch FFELKINKGLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long AGIKNLKPKBN;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long OOOGFDBMHJB
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x5A04D20", Offset = "0x5A04120", VA = "0x185A04D20")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long PACOFFMFEOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5A04D80", Offset = "0x5A04180", VA = "0x185A04D80")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5A04DF0", Offset = "0x5A041F0", VA = "0x185A04DF0")]
			public static MCGJLILGCMB MKFHLJKEIIJ()
			{
				return default(MCGJLILGCMB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct BLOFIDHEGJI : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct CEOPENGJHAM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* MPCBDFOCLBI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly KANIABHNKKO.OEKIDHGKKEJ.OOPKIKNCKON ABANKMBKIGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly CEADEEFJIGK CIEABJMCJGJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::DGIKCDEPKDI<CMIJGGBLCJC> ANLABGKNJHG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int LIMNOLJBNOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int PONGFBAOBFE;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x5A02AD0", Offset = "0x5A01ED0", VA = "0x185A02AD0")]
				public unsafe CEOPENGJHAM(Unity.Entities.Archetype* MPCBDFOCLBI, KANIABHNKKO.OEKIDHGKKEJ.OOPKIKNCKON ABANKMBKIGM, CEADEEFJIGK CIEABJMCJGJ, global::DGIKCDEPKDI<CMIJGGBLCJC> ANLABGKNJHG, int LIMNOLJBNOG, int PONGFBAOBFE = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5A02B30", Offset = "0x5A01F30", VA = "0x185A02B30")]
				public CEOPENGJHAM(in CEOPENGJHAM ONIBEFDCPGD, int PONGFBAOBFE)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly CEOPENGJHAM[] HIMJHOIKJJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] LLCAHMAGNDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int MNJFEFOLHNE;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5A02910", Offset = "0x5A01D10", VA = "0x185A02910")]
			public BLOFIDHEGJI(CEOPENGJHAM[] HIMJHOIKJJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5A02500", Offset = "0x5A01900", VA = "0x185A02500", Slot = "4")]
			public void Invoke(int BELCAJFDAHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5A02560", Offset = "0x5A01960", VA = "0x185A02560")]
			private void JKDNNEEFPJL(in CEOPENGJHAM ONIBEFDCPGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5A02230", Offset = "0x5A01630", VA = "0x185A02230")]
			private static void AFFBPLOGKCO(in CEOPENGJHAM ONIBEFDCPGD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class BKADBJAMLFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public KANIABHNKKO asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::DGIKCDEPKDI<CMIJGGBLCJC> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public BKADBJAMLFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5A021C0", Offset = "0x5A015C0", VA = "0x185A021C0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class JFOKNAPKLEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public KANIABHNKKO.OEKIDHGKKEJ.OOPKIKNCKON srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public BKADBJAMLFP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public JFOKNAPKLEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class CEPMBPOOFFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public JFOKNAPKLEM CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public CEPMBPOOFFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5A02B80", Offset = "0x5A01F80", VA = "0x185A02B80")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly FADHLPPNOEF CEDIHMKBBKI;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly FADHLPPNOEF KBJDBPHHBBJ;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly FADHLPPNOEF JIPPJHEMEAJ;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly FADHLPPNOEF NEKMKEPOHJG;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool BIMHANOHKEA;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static KANIABHNKKO.OEKIDHGKKEJ.FPGMFCBKPCO FENBELBNGGE;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5A0BE00", Offset = "0x5A0B200", VA = "0x185A0BE00")]
		private unsafe static bool MANMIOFOOKH(Unity.Entities.Archetype* CAABDGCKDOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A3F0", Offset = "0x5A097F0", VA = "0x185A0A3F0")]
		internal unsafe static Unity.Entities.Archetype*[] FMGIMIAPLOD(ref Unity.Entities.EntityComponentStore IIKHMFDBIPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B770", Offset = "0x5A0AB70", VA = "0x185A0B770")]
		public static void KHCMMGKFHHP(MJGGLIPIDNP OACNPKMLCHI, out ByteString EJAHCFFDNJB, out NativeArray<EntityRemapUtility.EntityRemapInfo> AHNECMHNOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5A0AFC0", Offset = "0x5A0A3C0", VA = "0x185A0AFC0")]
		internal static void IEBIKOKELMA(MJGGLIPIDNP OACNPKMLCHI, KANIABHNKKO CNJEGHCILOA, out NativeArray<EntityRemapUtility.EntityRemapInfo> AHNECMHNOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C7F0", Offset = "0x5A0BBF0", VA = "0x185A0C7F0")]
		private unsafe static UnsafeHashMap<ulong, LDIOKPHAPDF> OAGDPKONCCM(Unity.Entities.Archetype*[] NPEBDGOMNHL)
		{
			return default(UnsafeHashMap<ulong, LDIOKPHAPDF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5A09680", Offset = "0x5A08A80", VA = "0x185A09680")]
		private static void BCLJMIKNEEN(KANIABHNKKO CNJEGHCILOA, UnsafeHashMap<ulong, LDIOKPHAPDF> DFAFPDHDKEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5A09830", Offset = "0x5A08C30", VA = "0x185A09830")]
		private unsafe static void BDIKBNFJILC(KANIABHNKKO CNJEGHCILOA, Unity.Entities.Archetype*[] NPEBDGOMNHL, UnsafeHashMap<ulong, LDIOKPHAPDF> DFAFPDHDKEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C0A0", Offset = "0x5A0B4A0", VA = "0x185A0C0A0")]
		private unsafe static int NCLHBKEDCMK(Unity.Entities.Archetype*[] NPEBDGOMNHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5A09FD0", Offset = "0x5A093D0", VA = "0x185A09FD0")]
		private unsafe static void DOBNJCAHEPM(KANIABHNKKO CNJEGHCILOA, Unity.Entities.Archetype*[] NPEBDGOMNHL, global::DGIKCDEPKDI<CMIJGGBLCJC> ANLABGKNJHG, NativeArray<EntityRemapUtility.EntityRemapInfo> AHNECMHNOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5A0CB20", Offset = "0x5A0BF20", VA = "0x185A0CB20")]
		private static NativeArray<int> OHOEDGCIODJ(KANIABHNKKO CNJEGHCILOA)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5A09C40", Offset = "0x5A09040", VA = "0x185A09C40")]
		private static Memory<EntityArchetype> DLLAIELCNGE(KANIABHNKKO CNJEGHCILOA, NativeArray<int> CDFICLLHOEC, EntityManager KNABDDPENKI, out int PGBINBOPHKG, out int JAJJCIPAIEL)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5A0CD90", Offset = "0x5A0C190", VA = "0x185A0CD90")]
		private unsafe static void ONIBJADJFCG(Unity.Entities.Chunk* IGAIEPMBJNN, ReadOnlySpan<byte> EJAHCFFDNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A880", Offset = "0x5A09C80", VA = "0x185A0A880")]
		private static void HFEEGPDPDDH(KANIABHNKKO CNJEGHCILOA, NativeArray<int> CDFICLLHOEC, Span<EntityArchetype> NPEBDGOMNHL, EntityManager KNABDDPENKI, global::DGIKCDEPKDI<CMIJGGBLCJC> ANLABGKNJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B6F0", Offset = "0x5A0AAF0", VA = "0x185A0B6F0")]
		private unsafe static void KEIACCLHLCJ(Unity.Entities.Chunk* FGCHPEJCAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5A0BAF0", Offset = "0x5A0AEF0", VA = "0x185A0BAF0")]
		private unsafe static void KMGBMDJBODI(KANIABHNKKO.OEKIDHGKKEJ.OOPKIKNCKON MPCBDFOCLBI, int LKMJJBOOLIN, int LAKBHKOOAKA, Unity.Entities.Chunk* IGAIEPMBJNN, KANIABHNKKO CNJEGHCILOA, NativeArray<int> CDFICLLHOEC, global::DGIKCDEPKDI<CMIJGGBLCJC> ANLABGKNJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C110", Offset = "0x5A0B510", VA = "0x185A0C110")]
		public static void NOOGCIKELGC(MJGGLIPIDNP OACNPKMLCHI, in ByteString EJAHCFFDNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C1A0", Offset = "0x5A0B5A0", VA = "0x185A0C1A0")]
		public static void NOOGCIKELGC(EntityManager KNABDDPENKI, global::DGIKCDEPKDI<CMIJGGBLCJC> ANLABGKNJHG, in ByteString EJAHCFFDNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B830", Offset = "0x5A0AC30", VA = "0x185A0B830")]
		private static bool KLALNFHOKNG(Type DDJDPMGLPAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A5D0", Offset = "0x5A099D0", VA = "0x185A0A5D0")]
		private static void GHIFFBLNEMA(TypeManager.TypeInfo LPJJKKGIFPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5A0BF10", Offset = "0x5A0B310", VA = "0x185A0BF10")]
		private unsafe static int MDMDONFOPNM(Unity.Entities.Archetype*[] NPEBDGOMNHL, NativeArray<EntityRemapUtility.EntityRemapInfo> AHNECMHNOFH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5A09B60", Offset = "0x5A08F60", VA = "0x185A09B60")]
		private static int BDKOAHPPKOB(int NLGBDLLFIPJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5A0CA80", Offset = "0x5A0BE80", VA = "0x185A0CA80")]
		private static ulong OGGOCKFMKEA(int NLGBDLLFIPJ)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class HBLJFLCMKKO
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5A04340", Offset = "0x5A03740", VA = "0x185A04340")]
	private unsafe static Span<byte> OCBNBIDCDGG(Unity.Entities.Chunk* FGCHPEJCAHE, int LIMNOLJBNOG)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C790", Offset = "0x2E6BB90", VA = "0x182E6C790")]
	public unsafe static Span<T> DMFCPCOJNDE<T>(Unity.Entities.Chunk* FGCHPEJCAHE, int LIMNOLJBNOG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C910", Offset = "0x2E6BD10", VA = "0x182E6C910")]
	public static Span<T> DMFCPCOJNDE<T>(this ref Unity.Entities.Chunk FGCHPEJCAHE, int LIMNOLJBNOG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5A03F00", Offset = "0x5A03300", VA = "0x185A03F00")]
	public unsafe static Span<Entity> FPJGNCEPLOG(Unity.Entities.Chunk* FGCHPEJCAHE)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5A03F70", Offset = "0x5A03370", VA = "0x185A03F70")]
	public unsafe static void FPNLAFLJCKH(Unity.Entities.Chunk* FGCHPEJCAHE, int LIMNOLJBNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5A04210", Offset = "0x5A03610", VA = "0x185A04210")]
	public static Entity HICLDAKOJOP(this EntityQuery JLMGAJOHFKO)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : IIPLPEOFAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5A0D340", Offset = "0x5A0C740", VA = "0x185A0D340", Slot = "4")]
		public sealed override void FKBDNONAKOB()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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

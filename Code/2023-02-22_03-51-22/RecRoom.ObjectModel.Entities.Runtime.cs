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
		[Cpp2IlInjected.Address(RVA = "0x59666B0", Offset = "0x59658B0", VA = "0x1859666B0")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5968C00", Offset = "0x5967E00", VA = "0x185968C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x5968C70", Offset = "0x5967E70", VA = "0x185968C70")]
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
			[Cpp2IlInjected.Address(RVA = "0x2FDD9C0", Offset = "0x2FDCBC0", VA = "0x182FDD9C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2525250", Offset = "0x2524450", VA = "0x182525250")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2524910", Offset = "0x2523B10", VA = "0x182524910")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2524A10", Offset = "0x2523C10", VA = "0x182524A10")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2524E80", Offset = "0x2524080", VA = "0x182524E80")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5968C90", Offset = "0x5967E90", VA = "0x185968C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E8040", Offset = "0x6E7240", VA = "0x1806E8040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B63610", Offset = "0x2B62810", VA = "0x182B63610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1DA40C0", Offset = "0x1DA32C0", VA = "0x181DA40C0")]
		[DebuggerHidden]
		public NDIDDJOKEII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B63430", Offset = "0x2B62630", VA = "0x182B63430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B635D0", Offset = "0x2B627D0", VA = "0x182B635D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C7010", Offset = "0x6C6210", VA = "0x1806C7010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2F59430", Offset = "0x2F58630", VA = "0x182F59430")]
	private EGHNNNPKEEJ(byte[] IEGPGBKLAIF, Action<Protobuf> CGNAFFDHJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3840", Offset = "0x1CE2A40", VA = "0x181CE3840")]
	public static global::EGHNNNPKEEJ<Protobuf> BFPHDDBHNEE<Data>(ReadOnlySpan<byte> EJAHCFFDNJB, ReadOnlySpan<Data> HIMJHOIKJJP, Action<Protobuf> CGNAFFDHJNJ)
	{
		return default(global::EGHNNNPKEEJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2F592A0", Offset = "0x2F584A0", VA = "0x182F592A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2F592E0", Offset = "0x2F584E0", VA = "0x182F592E0", Slot = "4")]
	[IteratorStateMachine(typeof(global::EGHNNNPKEEJ<>.NDIDDJOKEII))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2F593E0", Offset = "0x2F585E0", VA = "0x182F593E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2355A40", Offset = "0x2354C40", VA = "0x182355A40")]
	private KMJHANKFCKN(byte[] IEGPGBKLAIF, in Protobuf FDDBADBDIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CEC9C0", Offset = "0x1CEBBC0", VA = "0x181CEC9C0")]
	public static global::KMJHANKFCKN<Protobuf> BFPHDDBHNEE<T>(ReadOnlySpan<T> HIMJHOIKJJP)
	{
		return default(global::KMJHANKFCKN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2355850", Offset = "0x2354A50", VA = "0x182355850")]
	public void AGMOJKLDJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x23559B0", Offset = "0x2354BB0", VA = "0x1823559B0")]
	public ByteString NCBMHEIJFBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2355880", Offset = "0x2354A80", VA = "0x182355880", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x596ADE0", Offset = "0x5969FE0", VA = "0x18596ADE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5968DD0", Offset = "0x5967FD0", VA = "0x185968DD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FCKDDBLMGBI
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public static void BDPAIIEPPHB(this FADHLPPNOEF ICGADBEDOKK, NativeArray<Entity> GNGEEFEGDCP, [Optional][CallerFilePath] string EPMHFOMBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public static void BDPAIIEPPHB(this FADHLPPNOEF ICGADBEDOKK, string IGHJIHNAPBA, NativeArray<Entity> GNGEEFEGDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public static void BDPAIIEPPHB(this FADHLPPNOEF ICGADBEDOKK, string EPMHFOMBHAO, NativeArray<Entity> GNGEEFEGDCP, bool OCOPNGDLHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public static void MMJNNMFNOPE(this FADHLPPNOEF ICGADBEDOKK, NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> NKDKBMKAAAG, [Optional][CallerFilePath] string EPMHFOMBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public static void MMJNNMFNOPE(this FADHLPPNOEF ICGADBEDOKK, string EPMHFOMBHAO, NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> NKDKBMKAAAG, bool OCOPNGDLHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2EA1CA0", Offset = "0x2EA0EA0", VA = "0x182EA1CA0")]
	public static void BEIDKKKJKMO<T>(this FADHLPPNOEF ICGADBEDOKK, string IGHJIHNAPBA, NativeArray<Entity> GNGEEFEGDCP, NativeList<T> ONIBEFDCPGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2EA1C60", Offset = "0x2EA0E60", VA = "0x182EA1C60")]
	public static void BEIDKKKJKMO<T>(this FADHLPPNOEF ICGADBEDOKK, string IGHJIHNAPBA, NativeArray<Entity> GNGEEFEGDCP, NativeArray<T> ONIBEFDCPGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public static void BEIDKKKJKMO<T>(this FADHLPPNOEF ICGADBEDOKK, string EPMHFOMBHAO, NativeArray<Entity> GNGEEFEGDCP, NativeArray<T> ONIBEFDCPGD, bool OCOPNGDLHNC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2EA1D90", Offset = "0x2EA0F90", VA = "0x182EA1D90")]
	public static void PPCJIEAFDJG<T>(this FADHLPPNOEF ICGADBEDOKK, NativeList<T> ONIBEFDCPGD, [Optional][CallerFilePath] string EPMHFOMBHAO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2EA1D60", Offset = "0x2EA0F60", VA = "0x182EA1D60")]
	public static void PPCJIEAFDJG<T>(this FADHLPPNOEF ICGADBEDOKK, NativeArray<T> ONIBEFDCPGD, [Optional][CallerFilePath] string EPMHFOMBHAO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public static void PPCJIEAFDJG<T>(this FADHLPPNOEF ICGADBEDOKK, string EPMHFOMBHAO, NativeArray<T> ONIBEFDCPGD, bool OCOPNGDLHNC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public static void FPMALFIOBKI(this FADHLPPNOEF ICGADBEDOKK, EntityQuery JLMGAJOHFKO, [Optional][CallerFilePath] string EPMHFOMBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public static void FPMALFIOBKI(this FADHLPPNOEF ICGADBEDOKK, string IGHJIHNAPBA, EntityQuery JLMGAJOHFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public static void FPMALFIOBKI(this FADHLPPNOEF ICGADBEDOKK, string EPMHFOMBHAO, EntityQuery JLMGAJOHFKO, bool OCOPNGDLHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2EA1D30", Offset = "0x2EA0F30", VA = "0x182EA1D30")]
	public static void OGOJLDKFEMD<T, T2>(this FADHLPPNOEF ICGADBEDOKK, string IGHJIHNAPBA, EntityQuery JLMGAJOHFKO) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1F6CA80", Offset = "0x1F6BC80", VA = "0x181F6CA80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x382E5A0", Offset = "0x382D7A0", VA = "0x18382E5A0")]
		public bool BCIEMKLIJOB(out TValue JFBPNBNBHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x382E470", Offset = "0x382D670", VA = "0x18382E470")]
		public void AOHLLDNPMGN(object AJDBKDIMOHA, TValue JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x382E520", Offset = "0x382D720", VA = "0x18382E520")]
		public bool BCBAFCFKBLF(object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x382E660", Offset = "0x382D860", VA = "0x18382E660")]
		public int EDAEEPKFCFE(object AJDBKDIMOHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x382E710", Offset = "0x382D910", VA = "0x18382E710")]
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
	[Cpp2IlInjected.Address(RVA = "0x27E32C0", Offset = "0x27E24C0", VA = "0x1827E32C0")]
	public IMJKKCAJKJE(EntityManager KNABDDPENKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x27E2CA0", Offset = "0x27E1EA0", VA = "0x1827E2CA0", Slot = "4")]
	public void AOLNMDKMLIP(Entity OAOGLFGGBPI, object AJDBKDIMOHA, TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x27E2EB0", Offset = "0x27E20B0", VA = "0x1827E2EB0", Slot = "5")]
	public bool ECEBMHMMNFF(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27E2DC0", Offset = "0x27E1FC0", VA = "0x1827E2DC0", Slot = "6")]
	public bool BCIEMKLIJOB(Entity OAOGLFGGBPI, out TValue JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x27E2E90", Offset = "0x27E2090", VA = "0x1827E2E90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x27E3170", Offset = "0x27E2370", VA = "0x1827E3170")]
	private void KEJMBHLFKGH(OIFNOGICOPL DEHJIMCABLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x27E31F0", Offset = "0x27E23F0", VA = "0x1827E31F0")]
	private bool LCAKLFGAICA(Entity OAOGLFGGBPI, out LEEGNLJBNDK KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x27E3020", Offset = "0x27E2220", VA = "0x1827E3020")]
	private void IGHPJCKBEEA(Entity OAOGLFGGBPI, LEEGNLJBNDK KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27E32A0", Offset = "0x27E24A0", VA = "0x1827E32A0")]
	private bool NOAKMGHIMKC(LEEGNLJBNDK KJNCDAGJAPF, out OIFNOGICOPL DEHJIMCABLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x27E30B0", Offset = "0x27E22B0", VA = "0x1827E30B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x778D90", Offset = "0x777F90", VA = "0x180778D90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x890590", Offset = "0x88F790", VA = "0x180890590", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xEABC90", Offset = "0xEAAE90", VA = "0x180EABC90", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x59699E0", Offset = "0x5968BE0", VA = "0x1859699E0", Slot = "8")]
	public bool Equals(LEEGNLJBNDK IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5969A30", Offset = "0x5968C30", VA = "0x185969A30", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x35BB4D0", Offset = "0x35BA6D0", VA = "0x1835BB4D0")]
	public GGEJOAKONHH(EntityManager KNABDDPENKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x35B89A0", Offset = "0x35B7BA0", VA = "0x1835B89A0", Slot = "4")]
	public bool AOLNMDKMLIP(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x35B8D70", Offset = "0x35B7F70", VA = "0x1835B8D70", Slot = "5")]
	public bool ECEBMHMMNFF(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35B92B0", Offset = "0x35B84B0", VA = "0x1835B92B0", Slot = "6")]
	public bool EPILLKKPCLC(Entity OAOGLFGGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x35B9470", Offset = "0x35B8670", VA = "0x1835B9470", Slot = "7")]
	public bool EPILLKKPCLC(LEEGNLJBNDK KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x35BB050", Offset = "0x35BA250", VA = "0x1835BB050", Slot = "8")]
	public IEnumerable<object> OBHLCGBDGOB(Entity OAOGLFGGBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x35BACF0", Offset = "0x35B9EF0", VA = "0x1835BACF0", Slot = "11")]
	public IEnumerable<object> OBHLCGBDGOB(LEEGNLJBNDK KJNCDAGJAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x35BAB10", Offset = "0x35B9D10", VA = "0x1835BAB10", Slot = "9")]
	public bool NLBJKDDKNCO(Entity OAOGLFGGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x35B8BA0", Offset = "0x35B7DA0", VA = "0x1835B8BA0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x35B9F20", Offset = "0x35B9120", VA = "0x1835B9F20")]
	private void KEJMBHLFKGH(HashSet<object> DEHJIMCABLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x35BA250", Offset = "0x35B9450", VA = "0x1835BA250")]
	private bool LCAKLFGAICA(Entity OAOGLFGGBPI, out LEEGNLJBNDK KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x35BA750", Offset = "0x35B9950", VA = "0x1835BA750")]
	private bool LPBDGENPIHN(Entity OAOGLFGGBPI, out LEEGNLJBNDK KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x35B9650", Offset = "0x35B8850", VA = "0x1835B9650")]
	private void GNMHOBCGIDC(Entity OAOGLFGGBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x35B98E0", Offset = "0x35B8AE0", VA = "0x1835B98E0")]
	private void IGHPJCKBEEA(Entity OAOGLFGGBPI, LEEGNLJBNDK KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x35B97F0", Offset = "0x35B89F0", VA = "0x1835B97F0")]
	private bool HADJJFIACFD(LEEGNLJBNDK KJNCDAGJAPF, out HashSet<object> DEHJIMCABLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x35B9DA0", Offset = "0x35B8FA0", VA = "0x1835B9DA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x34CD1C0", Offset = "0x34CC3C0", VA = "0x1834CD1C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x596B3C0", Offset = "0x596A5C0", VA = "0x18596B3C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5967CC0", Offset = "0x5966EC0", VA = "0x185967CC0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x117D3E0", Offset = "0x117C5E0", VA = "0x18117D3E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A87930", Offset = "0x3A86B30", VA = "0x183A87930", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x59666A0", Offset = "0x59658A0", VA = "0x1859666A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E7130", Offset = "0x6E6330", VA = "0x1806E7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xEB4310", Offset = "0xEB3510", VA = "0x180EB4310")]
	public PDDKAKIGCDD(Type JHEINIGHPCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DDFPMNGAPLM : PDDKAKIGCDD
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xEB4310", Offset = "0xEB3510", VA = "0x180EB4310")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E7140", Offset = "0x6E6340", VA = "0x1806E7140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5968D80", Offset = "0x5967F80", VA = "0x185968D80")]
	public FBDJPMECLEK(Type FJCPIFFECBD, Type JHEINIGHPCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DFPBKKCJHKF : PDDKAKIGCDD
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xEB4310", Offset = "0xEB3510", VA = "0x180EB4310")]
	public DFPBKKCJHKF(Type JHEINIGHPCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OEMDBJIOCGA : NOKAPBEALIO
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C7040", Offset = "0x6C6240", VA = "0x1806C7040")]
		[CompilerGenerated]
		get
		{
			return default(PCCEMKBGKDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xEB40D0", Offset = "0xEB32D0", VA = "0x180EB40D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5969650", Offset = "0x5968850", VA = "0x185969650")]
	public JCGKPCPJOOI(MJGGLIPIDNP OACNPKMLCHI, EntityManager KNABDDPENKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1D4AC90", Offset = "0x1D49E90", VA = "0x181D4AC90")]
	public bool GONGHJONBNE<T>(Entity OAOGLFGGBPI) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3268380", Offset = "0x3267580", VA = "0x183268380")]
	public bool AIHJLIGHGOO<T>(Entity OAOGLFGGBPI, out T JFBPNBNBHOE) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3268410", Offset = "0x3267610", VA = "0x183268410")]
	public T EEBEBPDLEBB<T>(Entity OAOGLFGGBPI) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D4ACD0", Offset = "0x1D49ED0", VA = "0x181D4ACD0")]
	private ComponentType LFMNBIPPOGM<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5969580", Offset = "0x5968780", VA = "0x185969580")]
	private ComponentType LFMNBIPPOGM(Type DDJDPMGLPAE)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class EHNCFNMGCGK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DCA160", Offset = "0x3DC9360", VA = "0x183DCA160", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type HFLBDCLBIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8620", Offset = "0x3DC7820", VA = "0x183DC8620", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int NPFIBDMLPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC9730", Offset = "0x3DC8930", VA = "0x183DC9730", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3DC97F0", Offset = "0x3DC89F0", VA = "0x183DC97F0")]
	public Data IONCAKGEPEH(Entity OAOGLFGGBPI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3DC96C0", Offset = "0x3DC88C0", VA = "0x183DC96C0")]
	public Data DKDOEGECFDD(Entity OAOGLFGGBPI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View DKKLGNODAJI(Entity OAOGLFGGBPI);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x444FFB0", Offset = "0x444F1B0", VA = "0x18444FFB0", Slot = "15")]
	protected internal override T DKKLGNODAJI<T>(Entity OAOGLFGGBPI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1D06A30", Offset = "0x1D05C30", VA = "0x181D06A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xB5C9C0", Offset = "0xB5BBC0", VA = "0x180B5C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CEE50", Offset = "0x7CE050", VA = "0x1807CEE50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int OKODNLKNBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5966960", Offset = "0x5965B60", VA = "0x185966960", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private GKFDLLIKKMD[] BKHMEBJPNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7CED80", Offset = "0x7CDF80", VA = "0x1807CED80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual GKFDLLIKKMD[] LAMFBEMMFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5966B20", Offset = "0x5965D20", VA = "0x185966B20", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CPFKDKBAAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5966AF0", Offset = "0x5965CF0", VA = "0x185966AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x59669D0", Offset = "0x5965BD0", VA = "0x1859669D0")]
	public void BNACPANAOEJ(EntityManager KNABDDPENKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E00", Offset = "0x7E5000", VA = "0x1807E5E00")]
	protected CNAIHAMIBKF BJINNEHPFHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T DKKLGNODAJI<T>(Entity OAOGLFGGBPI) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x59668A0", Offset = "0x5965AA0", VA = "0x1859668A0", Slot = "8")]
	public (uint, uint) BDKOAHPPKOB(Entity OAOGLFGGBPI)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5966BE0", Offset = "0x5965DE0", VA = "0x185966BE0", Slot = "9")]
	public bool PHKNCADEDHN(Entity OAOGLFGGBPI, (uint order, uint change) FLPPPNDNNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x228C630", Offset = "0x228B830", VA = "0x18228C630", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x228C770", Offset = "0x228B970", VA = "0x18228C770", Slot = "8")]
	protected virtual bool NKCHLENEANC(ReadOnlySpan<Data> HIMJHOIKJJP, CEADEEFJIGK CIEABJMCJGJ, out ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "9")]
	protected virtual bool DKHHDDPIABM(int FLPPPNDNNNB, Span<Data> HIMJHOIKJJP, in ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x228C6B0", Offset = "0x228B8B0", VA = "0x18228C6B0", Slot = "5")]
	internal sealed override bool NKCHLENEANC(ref Unity.Entities.Chunk FGCHPEJCAHE, int LIMNOLJBNOG, CEADEEFJIGK CIEABJMCJGJ, out ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x228B870", Offset = "0x228AA70", VA = "0x18228B870", Slot = "6")]
	internal sealed override bool DKHHDDPIABM(int FLPPPNDNNNB, ref Unity.Entities.Chunk FGCHPEJCAHE, int LIMNOLJBNOG, in ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0560", Offset = "0x1CDF760", VA = "0x181CE0560")]
	protected global::KMJHANKFCKN<Protobuf> EDKIFHOMMDO<Protobuf>(ReadOnlySpan<Data> HIMJHOIKJJP) where Protobuf : IMessage, new()
	{
		return default(global::KMJHANKFCKN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1CE05B0", Offset = "0x1CDF7B0", VA = "0x181CE05B0")]
	protected global::EGHNNNPKEEJ<Protobuf> JDPCILKAFOO<Protobuf>(ReadOnlySpan<byte> EJAHCFFDNJB, ReadOnlySpan<Data> HIMJHOIKJJP, Action<Protobuf> CGNAFFDHJNJ) where Protobuf : IMessage, new()
	{
		return default(global::EGHNNNPKEEJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1D06A30", Offset = "0x1D05C30", VA = "0x181D06A30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5967CE0", Offset = "0x5966EE0", VA = "0x185967CE0", Slot = "5")]
	internal virtual bool NKCHLENEANC(ref Unity.Entities.Chunk FGCHPEJCAHE, int LIMNOLJBNOG, CEADEEFJIGK CIEABJMCJGJ, out ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "6")]
	internal virtual bool DKHHDDPIABM(int FLPPPNDNNNB, ref Unity.Entities.Chunk FGCHPEJCAHE, int LIMNOLJBNOG, in ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x3823220", Offset = "0x3822420", VA = "0x183823220", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x264D480", Offset = "0x264C680", VA = "0x18264D480", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x228ED60", Offset = "0x228DF60", VA = "0x18228ED60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5966610", Offset = "0x5965810", VA = "0x185966610", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x59696A0", Offset = "0x59688A0", VA = "0x1859696A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F9BDB0", Offset = "0x1F9AFB0", VA = "0x181F9BDB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5967A80", Offset = "0x5966C80", VA = "0x185967A80")]
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
	[Cpp2IlInjected.Address(RVA = "0x2574EE0", Offset = "0x25740E0", VA = "0x182574EE0")]
	public static NativeList<T> MPKIADLDDNH<T>(this NativeArray<T> LOKAAAHFJIL, Allocator OPBLDCCKGEG = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class GIPJCMGFMOP
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x25AFE80", Offset = "0x25AF080", VA = "0x1825AFE80")]
	public static NativeArray<T> CDILAKKLAKI<T>(this NativeList<Entity> LOKAAAHFJIL, EntityManager KNABDDPENKI, Allocator OPBLDCCKGEG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x25AFD80", Offset = "0x25AEF80", VA = "0x1825AFD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x25B0750", Offset = "0x25AF950", VA = "0x1825B0750")]
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
	[Cpp2IlInjected.Address(RVA = "0x5969B10", Offset = "0x5968D10", VA = "0x185969B10")]
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
	[Cpp2IlInjected.Address(RVA = "0x3084C70", Offset = "0x3083E70", VA = "0x183084C70")]
	public MNOPMBAAKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3084760", Offset = "0x3083960", VA = "0x183084760", Slot = "4")]
	public bool GPEECKGOEKF(int NLGBDLLFIPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x30848C0", Offset = "0x3083AC0", VA = "0x1830848C0", Slot = "5")]
	public global::DGIKCDEPKDI<BaseClass> KHMHFCONDBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x30847C0", Offset = "0x30839C0", VA = "0x1830847C0", Slot = "7")]
	protected virtual bool JIFLAFOBNIM(Type DDJDPMGLPAE, int PCILGJMHFDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3084640", Offset = "0x3083840", VA = "0x183084640", Slot = "8")]
	protected virtual int FHCBHFPLJDG(Type DDJDPMGLPAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x30846D0", Offset = "0x30838D0", VA = "0x1830846D0")]
	public void FKBDNONAKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3084B70", Offset = "0x3083D70", VA = "0x183084B70", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A15940", Offset = "0x2A14B40", VA = "0x182A15940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A15C40", Offset = "0x2A14E40", VA = "0x182A15C40")]
	public DGIKCDEPKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A15DD0", Offset = "0x2A14FD0", VA = "0x182A15DD0")]
	public DGIKCDEPKDI(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A158C0", Offset = "0x2A14AC0", VA = "0x182A158C0")]
	internal void AOHLLDNPMGN(int NLGBDLLFIPJ, BaseClass BDAAELOCEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2210", Offset = "0x1CE1410", VA = "0x181CE2210")]
	public bool OBHIMHLDBEA<T>(out BaseClass JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A15B70", Offset = "0x2A14D70", VA = "0x182A15B70")]
	public bool OBHIMHLDBEA(Type HBILNHOEIJP, out BaseClass JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A15C10", Offset = "0x2A14E10", VA = "0x182A15C10")]
	public bool PLNJJFMAJFL(int NLGBDLLFIPJ, out BaseClass JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2130", Offset = "0x1CE1330", VA = "0x181CE2130")]
	public T AJOJPPMCNBH<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A15890", Offset = "0x2A14A90", VA = "0x182A15890")]
	public BaseClass AJOJPPMCNBH(Type AEOIHBBMHFN)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class ABKEGIJMKKA : global::MNOPMBAAKNH<DDFPMNGAPLM, EHNCFNMGCGK>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x59663B0", Offset = "0x59655B0", VA = "0x1859663B0")]
	public ABKEGIJMKKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class BFBEPOBILJF : global::MNOPMBAAKNH<FBDJPMECLEK, BCNEEGFPPIH>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5967180", Offset = "0x5966380", VA = "0x185967180")]
	public BFBEPOBILJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class HKFEIOAAPCD : global::MNOPMBAAKNH<DFPBKKCJHKF, CMIJGGBLCJC>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x59694E0", Offset = "0x59686E0", VA = "0x1859694E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x89DDB0", Offset = "0x89CFB0", VA = "0x18089DDB0")]
		private ComponentSystemTypes(List<Type> CDFICLLHOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5967D00", Offset = "0x5966F00", VA = "0x185967D00")]
		public static void FKBDNONAKOB(List<Type> CDFICLLHOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5967E10", Offset = "0x5967010", VA = "0x185967E10")]
		private void KILOFIIMADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5967D90", Offset = "0x5966F90", VA = "0x185967D90")]
		private bool JIFLAFOBNIM(Type DDJDPMGLPAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5968050", Offset = "0x5967250", VA = "0x185968050")]
		private void NBJLJAPHPCI(Type DDJDPMGLPAE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class LINMPAMPHKC : LDDGDFHPCLL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5969AD0", Offset = "0x5968CD0", VA = "0x185969AD0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase OFJPBMMHHBG();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5969A80", Offset = "0x5968C80", VA = "0x185969A80")]
	protected ComponentSystemBase LMGBGMAKAOM(params ComponentSystemBase[] HOCPKHHLENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1D69450", Offset = "0x1D68650", VA = "0x181D69450")]
	protected ComponentSystemBase LMGBGMAKAOM<T>(params ComponentSystemBase[] HOCPKHHLENG) where T : LDDGDFHPCLL, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1D69410", Offset = "0x1D68610", VA = "0x181D69410")]
	protected ComponentSystemBase PDAPPLNMINF<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1D69410", Offset = "0x1D68610", VA = "0x181D69410")]
	protected ComponentSystemBase ICFNCPBNEBL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	protected LINMPAMPHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5969730", Offset = "0x5968930", VA = "0x185969730", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public LDDGDFHPCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class DHDEFGPGMMG : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5968980", Offset = "0x5967B80", VA = "0x185968980")]
	public ComponentDataFromEntity CGCAABFHGFN(int NLGBDLLFIPJ, bool LPKIEPPBIHF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5968A20", Offset = "0x5967C20", VA = "0x185968A20", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0")]
	protected DHDEFGPGMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class CICADLGFANF : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0")]
	protected CICADLGFANF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class ILHKCJPPBMP : DHDEFGPGMMG
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5969550", Offset = "0x5968750", VA = "0x185969550", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	protected void BNCJEJEKKDP(string HKGFIHMBIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0")]
	protected ILHKCJPPBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	protected NJNNEPAPPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x596B7F0", Offset = "0x596A9F0", VA = "0x18596B7F0")]
		public static ComponentSystemGroup[] FAMNOHPACPJ(World OACNPKMLCHI, DPJCHDCGBCJ FHIJGAAPLEJ = DPJCHDCGBCJ.Default, bool CNOLPIGFANK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x596BB40", Offset = "0x596AD40", VA = "0x18596BB40")]
		private static Type[] KCFJIBFPFCA(DPJCHDCGBCJ FHIJGAAPLEJ, bool CNOLPIGFANK, ComponentSystemGroup[] ELJPDMBHKGP, ComponentSystemGroup NJHJCPCELCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x596BEA0", Offset = "0x596B0A0", VA = "0x18596BEA0")]
		private static ComponentSystemGroup[] LJMAOKAMKAH(World OACNPKMLCHI, out ComponentSystemGroup NJHJCPCELCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x596B8C0", Offset = "0x596AAC0", VA = "0x18596B8C0")]
		internal static bool HECPNILDABA(PCCEMKBGKDJ NOECNPHPBKJ, out DFEDEMKJADL PENLMJJIFEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x596C1B0", Offset = "0x596B3B0", VA = "0x18596C1B0")]
		private static ComponentSystemGroup NGOJKMFMDLF(Type DDJDPMGLPAE, World OACNPKMLCHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x596B6C0", Offset = "0x596A8C0", VA = "0x18596B6C0")]
		private static ComponentSystemGroup[] CDHDJGCKFDI(Type[] CDFICLLHOEC, World OACNPKMLCHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x596C350", Offset = "0x596B550", VA = "0x18596C350")]
		internal static void PHMGKKNLGHB(World OACNPKMLCHI, Type[] AGBKMCALOHL, ComponentSystemGroup[] ELJPDMBHKGP, ComponentSystemGroup NJHJCPCELCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x596C290", Offset = "0x596B490", VA = "0x18596C290")]
		internal static bool NIEJNJCCIMF(ComponentSystemBase DCOPHBBEGEL, ComponentSystemGroup[] ELJPDMBHKGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x596C2F0", Offset = "0x596B4F0", VA = "0x18596C2F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x777A10", Offset = "0x776C10", VA = "0x180777A10")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
			[DebuggerHidden]
			public OFENBEPHCCA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x596B2E0", Offset = "0x596A4E0", VA = "0x18596B2E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x596B040", Offset = "0x596A240", VA = "0x18596B040", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x596B370", Offset = "0x596A570", VA = "0x18596B370")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x596B2A0", Offset = "0x596A4A0", VA = "0x18596B2A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x596B1F0", Offset = "0x596A3F0", VA = "0x18596B1F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x596B1F0", Offset = "0x596A3F0", VA = "0x18596B1F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x596C900", Offset = "0x596BB00", VA = "0x18596C900")]
		public static RRFilterWorldSystems BFPHDDBHNEE()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x596CB10", Offset = "0x596BD10", VA = "0x18596CB10")]
		public RRFilterWorldSystems IFAFKPPLBHG(DPJCHDCGBCJ NOECNPHPBKJ)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x596D6B0", Offset = "0x596C8B0", VA = "0x18596D6B0")]
		public RRFilterWorldSystems PCCLOBOHJOI(IEnumerable<Type> CDFICLLHOEC)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x596CB20", Offset = "0x596BD20", VA = "0x18596CB20")]
		public RRFilterWorldSystems IGDGLCJFAKM(bool FGOIMOKCEPI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x596CD80", Offset = "0x596BF80", VA = "0x18596CD80")]
		public RRFilterWorldSystems JPDAMDOIOGP(bool EINMLEBPFNI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x596C920", Offset = "0x596BB20", VA = "0x18596C920")]
		public AIAJCPEANBP DPBLJNEKJFJ(Type[] GINBJMEIHMO)
		{
			return default(AIAJCPEANBP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x596CCF0", Offset = "0x596BEF0", VA = "0x18596CCF0")]
		[IteratorStateMachine(typeof(OFENBEPHCCA))]
		internal IEnumerable<Type> JOEIFABPELP(IEnumerable<Type> CDFICLLHOEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x596D3D0", Offset = "0x596C5D0", VA = "0x18596D3D0")]
		internal Dictionary<Type, List<Type>> NHGBKBHLPPO(IEnumerable<Type> CDFICLLHOEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x596D6F0", Offset = "0x596C8F0", VA = "0x18596D6F0")]
		private void PMLBNJLPAII(Dictionary<Type, List<Type>> PLBLCMNMLJO, Type DDJDPMGLPAE, Type NDBJGKINPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x596CB30", Offset = "0x596BD30", VA = "0x18596CB30")]
		internal HashSet<Type> JBPBHNGAFOP(IEnumerable<Type> ELJPDMBHKGP, Dictionary<Type, List<Type>> KFCGKKLOJFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x596CD90", Offset = "0x596BF90", VA = "0x18596CD90")]
		internal bool NCOBNAIOLLI(Type DDJDPMGLPAE, DPJCHDCGBCJ FHIJGAAPLEJ, bool CNOLPIGFANK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x596C9B0", Offset = "0x596BBB0", VA = "0x18596C9B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x596AE20", Offset = "0x596A020", VA = "0x18596AE20")]
	public static void BNACPANAOEJ(bool BIOMHNNIJHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x596AE80", Offset = "0x596A080", VA = "0x18596AE80")]
	private static void NHLFCDOAJNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class OPJAHMAGFMA
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x596B3D0", Offset = "0x596A5D0", VA = "0x18596B3D0")]
	public static ulong IPKMFNMNHJC(Type DDJDPMGLPAE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x596B400", Offset = "0x596A600", VA = "0x18596B400")]
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
			[Cpp2IlInjected.Address(RVA = "0xEB1570", Offset = "0xEB0770", VA = "0x180EB1570")]
			public BBDBCEIGBOC(ulong FLEGDLHOKBO, ulong LENMLPEBGNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5966810", Offset = "0x5965A10", VA = "0x185966810", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x596E560", Offset = "0x596D760", VA = "0x18596E560")]
		public static ulong OGGOCKFMKEA(int NLGBDLLFIPJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x596DBB0", Offset = "0x596CDB0", VA = "0x18596DBB0")]
		public static int EPLBOJLNCOI(ulong LENMLPEBGNA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x596D8E0", Offset = "0x596CAE0", VA = "0x18596D8E0")]
		public static void BNACPANAOEJ(bool BIOMHNNIJHG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x596E410", Offset = "0x596D610", VA = "0x18596E410")]
		private static void NHDOJKPOAGH(int MBBNHNOEHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x596E060", Offset = "0x596D260", VA = "0x18596E060")]
		private static void KFNNFIPGBOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x596DAD0", Offset = "0x596CCD0", VA = "0x18596DAD0")]
		private static BBDBCEIGBOC CFODGOFDPHD(Type DDJDPMGLPAE)
		{
			return default(BBDBCEIGBOC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x596E4F0", Offset = "0x596D6F0", VA = "0x18596E4F0")]
		private static ulong NLGODMBLJJK(Type DDJDPMGLPAE, ulong LENMLPEBGNA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x596DD40", Offset = "0x596CF40", VA = "0x18596DD40")]
		private static void IMMGCOIGDOL(in BBDBCEIGBOC AJFKKDDBKCH, TypeManager.TypeInfo LPJJKKGIFPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x596DF60", Offset = "0x596D160", VA = "0x18596DF60")]
		private static void JBJPJHNKMIJ(BBDBCEIGBOC LPJJKKGIFPB, int NLGBDLLFIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x596DC60", Offset = "0x596CE60", VA = "0x18596DC60")]
		private static void IFCLAEPCDGH(BBDBCEIGBOC LPJJKKGIFPB, int NLGBDLLFIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x596E380", Offset = "0x596D580", VA = "0x18596E380")]
		private static BBDBCEIGBOC MGLBHJDLKJF(int NLGBDLLFIPJ)
		{
			return default(BBDBCEIGBOC);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x596D8D0", Offset = "0x596CAD0", VA = "0x18596D8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5968690", Offset = "0x5967890", VA = "0x185968690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::PFAMOLIMCKL<CMIJGGBLCJC> INGMDHHFJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x59686F0", Offset = "0x59678F0", VA = "0x1859686F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::PFAMOLIMCKL<EHNCFNMGCGK> NDIDNHFPBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x59685B0", Offset = "0x59677B0", VA = "0x1859685B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5968100", Offset = "0x5967300", VA = "0x185968100")]
	public static void BNACPANAOEJ(bool BIOMHNNIJHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5968610", Offset = "0x5967810", VA = "0x185968610")]
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
	[Cpp2IlInjected.Address(RVA = "0x5966C70", Offset = "0x5965E70", VA = "0x185966C70")]
	public static int BDKOAHPPKOB(int NLGBDLLFIPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5966D10", Offset = "0x5965F10", VA = "0x185966D10")]
	public static void BNACPANAOEJ(bool BIOMHNNIJHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5966E80", Offset = "0x5966080", VA = "0x185966E80")]
	private static void PNJLPMMGLLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5966E30", Offset = "0x5966030", VA = "0x185966E30")]
	private static int OLHEAGGDLJJ(Type DDJDPMGLPAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5966DB0", Offset = "0x5965FB0", VA = "0x185966DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World JMJANPOMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x89ECE0", Offset = "0x89DEE0", VA = "0x18089ECE0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public JCGKPCPJOOI OHPMAEDABBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::DGIKCDEPKDI<BCNEEGFPPIH> OOPBLHFDPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x75FAE0", Offset = "0x75ECE0", VA = "0x18075FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::DGIKCDEPKDI<CMIJGGBLCJC> INGMDHHFJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6CE570", Offset = "0x6CD770", VA = "0x1806CE570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6CE590", Offset = "0x6CD790", VA = "0x1806CE590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::DGIKCDEPKDI<EHNCFNMGCGK> NDIDNHFPBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6CE580", Offset = "0x6CD780", VA = "0x1806CE580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6CE5A0", Offset = "0x6CD7A0", VA = "0x1806CE5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> NGMCJEFJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x89ED20", Offset = "0x89DF20", VA = "0x18089ED20")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] LEHOIONCOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x596A4D0", Offset = "0x59696D0", VA = "0x18596A4D0")]
	public static MJGGLIPIDNP LDDMAKHBJFK(string IGHJIHNAPBA, PCCEMKBGKDJ NOECNPHPBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x596A8C0", Offset = "0x5969AC0", VA = "0x18596A8C0")]
	public MJGGLIPIDNP(string IGHJIHNAPBA, PCCEMKBGKDJ NOECNPHPBKJ = PCCEMKBGKDJ.Simulation, DPJCHDCGBCJ FHIJGAAPLEJ = DPJCHDCGBCJ.Default, bool BIOMHNNIJHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x596A450", Offset = "0x5969650", VA = "0x18596A450")]
	public ComponentSystemBase JENJJJPAFEE(Type DDJDPMGLPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3082640", Offset = "0x3081840", VA = "0x183082640")]
	public T JENJJJPAFEE<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5969F40", Offset = "0x5969140", VA = "0x185969F40")]
	public void DBCKGBHABAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x596A630", Offset = "0x5969830", VA = "0x18596A630")]
	public void MLNADKJEIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5969EE0", Offset = "0x59690E0", VA = "0x185969EE0")]
	public void CONPHBKOBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x596A690", Offset = "0x5969890", VA = "0x18596A690")]
	public void MMLCFFJDOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x596A550", Offset = "0x5969750", VA = "0x18596A550")]
	public void LIGLPECAGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x596A120", Offset = "0x5969320", VA = "0x18596A120")]
	public void HEIHMHFCDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5969E80", Offset = "0x5969080", VA = "0x185969E80")]
	public void BHGIMPDFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x596A830", Offset = "0x5969A30", VA = "0x18596A830")]
	public void PDDOCHODEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x596A7D0", Offset = "0x59699D0", VA = "0x18596A7D0")]
	public void OHKGNKPAFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x596A470", Offset = "0x5969670", VA = "0x18596A470")]
	public void JFOGKNPOCCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x596A6F0", Offset = "0x59698F0", VA = "0x18596A6F0")]
	internal void NLKKAEFLIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x596A5B0", Offset = "0x59697B0", VA = "0x18596A5B0")]
	private bool LOPHFAPFAIM(ComponentSystemGroup HMGHGFKHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x596A180", Offset = "0x5969380", VA = "0x18596A180")]
	private void IOLJICGAJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x596A010", Offset = "0x5969210", VA = "0x18596A010")]
	private ComponentSystemGroup[] FAMNOHPACPJ(DPJCHDCGBCJ FHIJGAAPLEJ, bool CNOLPIGFANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5969FA0", Offset = "0x59691A0", VA = "0x185969FA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E8020", Offset = "0x6E7220", VA = "0x1806E8020", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	protected FCHADADEKJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class BADAIICIPJH : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public BADAIICIPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class CDPBEFOKBPH : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public CDPBEFOKBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class PAADBABBJJN : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public PAADBABBJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class OODOIKMOLLK : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public OODOIKMOLLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class OLEIJCJDIOL : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public OLEIJCJDIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class FLHGDPEKGFK : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public FLHGDPEKGFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class BKFNKEDABJH : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public BKFNKEDABJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class GCJNDOFEDGI : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public GCJNDOFEDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class MBLOIJIFAEE : FCHADADEKJP
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public MBLOIJIFAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class MENAGEAHGAA : IJMENJKMODF
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public MENAGEAHGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class FOGAEHKMBML : IJMENJKMODF
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public FOGAEHKMBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class OFMMALPBPPE : IJMENJKMODF
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public OFMMALPBPPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class IOHJPJGEGDO : IJMENJKMODF
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public IOHJPJGEGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5966800", Offset = "0x5965A00", VA = "0x185966800")]
	public IJMENJKMODF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class GHMAJOMNKOK : NOKAPBEALIO
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public MMAPGCLKFGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x596B4C0", Offset = "0x596A6C0", VA = "0x18596B4C0")]
	static OPOMPJLOPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x29A7510", Offset = "0x29A6710", VA = "0x1829A7510")]
	public static void ACMMGIDBFPP<T>(NPMLLPDMEPH<T, T> EFAEFNCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x29A7280", Offset = "0x29A6480", VA = "0x1829A7280")]
	public static void ACMMGIDBFPP<From, To>(NPMLLPDMEPH<From, To> EFAEFNCLJOG, NPMLLPDMEPH<To, From> MEDIABCDJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x29A7310", Offset = "0x29A6510", VA = "0x1829A7310")]
	public static void ACMMGIDBFPP<From, To>(NPMLLPDMEPH<From, To> KLBBKHKDGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x29ABDA0", Offset = "0x29AAFA0", VA = "0x1829ABDA0")]
	public static NPMLLPDMEPH<From, To> MHHDHGNGFPE<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x29A9300", Offset = "0x29A8500", VA = "0x1829A9300")]
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
	[Cpp2IlInjected.Address(RVA = "0xCD29C0", Offset = "0xCD1BC0", VA = "0x180CD29C0")]
	public CEADEEFJIGK(NativeArray<EntityRemapUtility.EntityRemapInfo> BPEGOEMBBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x31A7CE0", Offset = "0x31A6EE0", VA = "0x1831A7CE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5966420", Offset = "0x5965620", VA = "0x185966420")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E8050", Offset = "0x6E7250", VA = "0x1806E8050")]
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
				[Cpp2IlInjected.Address(RVA = "0x5969CF0", Offset = "0x5968EF0", VA = "0x185969CF0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long PACOFFMFEOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5969D50", Offset = "0x5968F50", VA = "0x185969D50")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5969DC0", Offset = "0x5968FC0", VA = "0x185969DC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5967B00", Offset = "0x5966D00", VA = "0x185967B00")]
				public unsafe CEOPENGJHAM(Unity.Entities.Archetype* MPCBDFOCLBI, KANIABHNKKO.OEKIDHGKKEJ.OOPKIKNCKON ABANKMBKIGM, CEADEEFJIGK CIEABJMCJGJ, global::DGIKCDEPKDI<CMIJGGBLCJC> ANLABGKNJHG, int LIMNOLJBNOG, int PONGFBAOBFE = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5967B60", Offset = "0x5966D60", VA = "0x185967B60")]
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
			[Cpp2IlInjected.Address(RVA = "0x5967940", Offset = "0x5966B40", VA = "0x185967940")]
			public BLOFIDHEGJI(CEOPENGJHAM[] HIMJHOIKJJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5967530", Offset = "0x5966730", VA = "0x185967530", Slot = "4")]
			public void Invoke(int BELCAJFDAHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5967590", Offset = "0x5966790", VA = "0x185967590")]
			private void JKDNNEEFPJL(in CEOPENGJHAM ONIBEFDCPGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5967260", Offset = "0x5966460", VA = "0x185967260")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public BKADBJAMLFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x59671F0", Offset = "0x59663F0", VA = "0x1859671F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public CEPMBPOOFFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5967BB0", Offset = "0x5966DB0", VA = "0x185967BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5970DD0", Offset = "0x596FFD0", VA = "0x185970DD0")]
		private unsafe static bool MANMIOFOOKH(Unity.Entities.Archetype* CAABDGCKDOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x596F3C0", Offset = "0x596E5C0", VA = "0x18596F3C0")]
		internal unsafe static Unity.Entities.Archetype*[] FMGIMIAPLOD(ref Unity.Entities.EntityComponentStore IIKHMFDBIPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5970740", Offset = "0x596F940", VA = "0x185970740")]
		public static void KHCMMGKFHHP(MJGGLIPIDNP OACNPKMLCHI, out ByteString EJAHCFFDNJB, out NativeArray<EntityRemapUtility.EntityRemapInfo> AHNECMHNOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x596FF90", Offset = "0x596F190", VA = "0x18596FF90")]
		internal static void IEBIKOKELMA(MJGGLIPIDNP OACNPKMLCHI, KANIABHNKKO CNJEGHCILOA, out NativeArray<EntityRemapUtility.EntityRemapInfo> AHNECMHNOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x59717C0", Offset = "0x59709C0", VA = "0x1859717C0")]
		private unsafe static UnsafeHashMap<ulong, LDIOKPHAPDF> OAGDPKONCCM(Unity.Entities.Archetype*[] NPEBDGOMNHL)
		{
			return default(UnsafeHashMap<ulong, LDIOKPHAPDF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x596E650", Offset = "0x596D850", VA = "0x18596E650")]
		private static void BCLJMIKNEEN(KANIABHNKKO CNJEGHCILOA, UnsafeHashMap<ulong, LDIOKPHAPDF> DFAFPDHDKEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x596E800", Offset = "0x596DA00", VA = "0x18596E800")]
		private unsafe static void BDIKBNFJILC(KANIABHNKKO CNJEGHCILOA, Unity.Entities.Archetype*[] NPEBDGOMNHL, UnsafeHashMap<ulong, LDIOKPHAPDF> DFAFPDHDKEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5971070", Offset = "0x5970270", VA = "0x185971070")]
		private unsafe static int NCLHBKEDCMK(Unity.Entities.Archetype*[] NPEBDGOMNHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x596EFA0", Offset = "0x596E1A0", VA = "0x18596EFA0")]
		private unsafe static void DOBNJCAHEPM(KANIABHNKKO CNJEGHCILOA, Unity.Entities.Archetype*[] NPEBDGOMNHL, global::DGIKCDEPKDI<CMIJGGBLCJC> ANLABGKNJHG, NativeArray<EntityRemapUtility.EntityRemapInfo> AHNECMHNOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5971AF0", Offset = "0x5970CF0", VA = "0x185971AF0")]
		private static NativeArray<int> OHOEDGCIODJ(KANIABHNKKO CNJEGHCILOA)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x596EC10", Offset = "0x596DE10", VA = "0x18596EC10")]
		private static Memory<EntityArchetype> DLLAIELCNGE(KANIABHNKKO CNJEGHCILOA, NativeArray<int> CDFICLLHOEC, EntityManager KNABDDPENKI, out int PGBINBOPHKG, out int JAJJCIPAIEL)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5971D60", Offset = "0x5970F60", VA = "0x185971D60")]
		private unsafe static void ONIBJADJFCG(Unity.Entities.Chunk* IGAIEPMBJNN, ReadOnlySpan<byte> EJAHCFFDNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x596F850", Offset = "0x596EA50", VA = "0x18596F850")]
		private static void HFEEGPDPDDH(KANIABHNKKO CNJEGHCILOA, NativeArray<int> CDFICLLHOEC, Span<EntityArchetype> NPEBDGOMNHL, EntityManager KNABDDPENKI, global::DGIKCDEPKDI<CMIJGGBLCJC> ANLABGKNJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x59706C0", Offset = "0x596F8C0", VA = "0x1859706C0")]
		private unsafe static void KEIACCLHLCJ(Unity.Entities.Chunk* FGCHPEJCAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5970AC0", Offset = "0x596FCC0", VA = "0x185970AC0")]
		private unsafe static void KMGBMDJBODI(KANIABHNKKO.OEKIDHGKKEJ.OOPKIKNCKON MPCBDFOCLBI, int LKMJJBOOLIN, int LAKBHKOOAKA, Unity.Entities.Chunk* IGAIEPMBJNN, KANIABHNKKO CNJEGHCILOA, NativeArray<int> CDFICLLHOEC, global::DGIKCDEPKDI<CMIJGGBLCJC> ANLABGKNJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x59710E0", Offset = "0x59702E0", VA = "0x1859710E0")]
		public static void NOOGCIKELGC(MJGGLIPIDNP OACNPKMLCHI, in ByteString EJAHCFFDNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5971170", Offset = "0x5970370", VA = "0x185971170")]
		public static void NOOGCIKELGC(EntityManager KNABDDPENKI, global::DGIKCDEPKDI<CMIJGGBLCJC> ANLABGKNJHG, in ByteString EJAHCFFDNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5970800", Offset = "0x596FA00", VA = "0x185970800")]
		private static bool KLALNFHOKNG(Type DDJDPMGLPAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x596F5A0", Offset = "0x596E7A0", VA = "0x18596F5A0")]
		private static void GHIFFBLNEMA(TypeManager.TypeInfo LPJJKKGIFPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5970EE0", Offset = "0x59700E0", VA = "0x185970EE0")]
		private unsafe static int MDMDONFOPNM(Unity.Entities.Archetype*[] NPEBDGOMNHL, NativeArray<EntityRemapUtility.EntityRemapInfo> AHNECMHNOFH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x596EB30", Offset = "0x596DD30", VA = "0x18596EB30")]
		private static int BDKOAHPPKOB(int NLGBDLLFIPJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5971A50", Offset = "0x5970C50", VA = "0x185971A50")]
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
	[Cpp2IlInjected.Address(RVA = "0x5969340", Offset = "0x5968540", VA = "0x185969340")]
	private unsafe static Span<byte> OCBNBIDCDGG(Unity.Entities.Chunk* FGCHPEJCAHE, int LIMNOLJBNOG)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x25BC830", Offset = "0x25BBA30", VA = "0x1825BC830")]
	public unsafe static Span<T> DMFCPCOJNDE<T>(Unity.Entities.Chunk* FGCHPEJCAHE, int LIMNOLJBNOG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x25BC9B0", Offset = "0x25BBBB0", VA = "0x1825BC9B0")]
	public static Span<T> DMFCPCOJNDE<T>(this ref Unity.Entities.Chunk FGCHPEJCAHE, int LIMNOLJBNOG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5968F00", Offset = "0x5968100", VA = "0x185968F00")]
	public unsafe static Span<Entity> FPJGNCEPLOG(Unity.Entities.Chunk* FGCHPEJCAHE)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5968F70", Offset = "0x5968170", VA = "0x185968F70")]
	public unsafe static void FPNLAFLJCKH(Unity.Entities.Chunk* FGCHPEJCAHE, int LIMNOLJBNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5969210", Offset = "0x5968410", VA = "0x185969210")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5972310", Offset = "0x5971510", VA = "0x185972310", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x5B7FD60", Offset = "0x5B7F160", VA = "0x185B7FD60")]
		public static Span<Unity.Entities.ComponentTypeInArchetype> GetTypes(this ref Unity.Entities.Archetype archetype)
		{
			return default(Span<Unity.Entities.ComponentTypeInArchetype>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EntityArchetypeExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5B81500", Offset = "0x5B80900", VA = "0x185B81500")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B81570", Offset = "0x5B80970", VA = "0x185B81570")]
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
			[Cpp2IlInjected.Address(RVA = "0x39718A0", Offset = "0x3970CA0", VA = "0x1839718A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F31CC0", Offset = "0x2F310C0", VA = "0x182F31CC0")]
		public static void SetComponentData<T>(this EntityManager entityManager, NativeArray<Entity> entities, T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2F311F0", Offset = "0x2F305F0", VA = "0x182F311F0")]
		public static void CompleteReadAndWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2F312F0", Offset = "0x2F306F0", VA = "0x182F312F0")]
		public static void CompleteWriteDependency<T>(this EntityManager entityManager) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2F316F0", Offset = "0x2F30AF0", VA = "0x182F316F0")]
		public static JobHandle GetReadDependency<T>(this EntityManager entityManager) where T : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5B81590", Offset = "0x5B80990", VA = "0x185B81590")]
		public static JobHandle GetReadDependency(this EntityManager entityManager, int typeIndex)
		{
			return default(JobHandle);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BNKHDNDCLIB<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JOOBFOJNLCJ : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::BNKHDNDCLIB<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8291E0", Offset = "0x8285E0", VA = "0x1808291E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37B4AC0", Offset = "0x37B3EC0", VA = "0x1837B4AC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E910", Offset = "0x2A3DD10", VA = "0x182A3E910")]
		[DebuggerHidden]
		public JOOBFOJNLCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x37B48E0", Offset = "0x37B3CE0", VA = "0x1837B48E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x37B4A80", Offset = "0x37B3E80", VA = "0x1837B4A80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> ECMGIODEMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream LBMMCNGMDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream JNBOBMJNKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf IOAGLHEANGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int FKOLDOEAEID
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x764360", Offset = "0x763760", VA = "0x180764360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x31E6B40", Offset = "0x31E5F40", VA = "0x1831E6B40")]
	private BNKHDNDCLIB(byte[] DGPBECDNOKK, Action<Protobuf> ECMGIODEMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x336B520", Offset = "0x336A920", VA = "0x18336B520")]
	public static global::BNKHDNDCLIB<Protobuf> PELCFOCODBC<Data>(ReadOnlySpan<byte> LFBMPCLHCOB, ReadOnlySpan<Data> INJMMDAENFI, Action<Protobuf> ECMGIODEMHJ)
	{
		return default(global::BNKHDNDCLIB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x31E69B0", Offset = "0x31E5DB0", VA = "0x1831E69B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x31E69F0", Offset = "0x31E5DF0", VA = "0x1831E69F0", Slot = "4")]
	[IteratorStateMachine(typeof(global::BNKHDNDCLIB<>.JOOBFOJNLCJ))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x31E6AF0", Offset = "0x31E5EF0", VA = "0x1831E6AF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DMDNFBCHHAM<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] DGPBECDNOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf IOAGLHEANGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream LBMMCNGMDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream HHIDCLDMMDI;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3709320", Offset = "0x3708720", VA = "0x183709320")]
	private DMDNFBCHHAM(byte[] DGPBECDNOKK, in Protobuf IOAGLHEANGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3459F20", Offset = "0x3459320", VA = "0x183459F20")]
	public static global::DMDNFBCHHAM<Protobuf> PELCFOCODBC<T>(ReadOnlySpan<T> INJMMDAENFI)
	{
		return default(global::DMDNFBCHHAM<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x37092F0", Offset = "0x37086F0", VA = "0x1837092F0")]
	public void MGDPIKNEEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3709260", Offset = "0x3708660", VA = "0x183709260")]
	public ByteString HLAAGFDBDLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3709130", Offset = "0x3708530", VA = "0x183709130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NDGBJNDEPJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream LBMMCNGMDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream JNBOBMJNKKC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B82AE0", Offset = "0x5B81EE0", VA = "0x185B82AE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct ALKJOFAFAPH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] DGPBECDNOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream LBMMCNGMDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream HHIDCLDMMDI;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5B7FBB0", Offset = "0x5B7EFB0", VA = "0x185B7FBB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GOCFKGLBEBE
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public static void JBPDMDBFBEH(this BBHAOFNBCPD CDECIAPNKBP, NativeArray<Entity> NMNOLKKCICL, [Optional][CallerFilePath] string BNDMOPGGFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public static void JBPDMDBFBEH(this BBHAOFNBCPD CDECIAPNKBP, string LBEPPIIBMPA, NativeArray<Entity> NMNOLKKCICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public static void JBPDMDBFBEH(this BBHAOFNBCPD CDECIAPNKBP, string BNDMOPGGFHK, NativeArray<Entity> NMNOLKKCICL, bool NGINFEJBBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public static void FMIPLFKENGJ(this BBHAOFNBCPD CDECIAPNKBP, NativeArray<Entity> NMNOLKKCICL, NativeArray<Entity> ELOPNHNIFCF, [Optional][CallerFilePath] string BNDMOPGGFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public static void FMIPLFKENGJ(this BBHAOFNBCPD CDECIAPNKBP, string BNDMOPGGFHK, NativeArray<Entity> NMNOLKKCICL, NativeArray<Entity> ELOPNHNIFCF, bool NGINFEJBBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2DC8E20", Offset = "0x2DC8220", VA = "0x182DC8E20")]
	public static void FCDPEPAELCC<T>(this BBHAOFNBCPD CDECIAPNKBP, string LBEPPIIBMPA, NativeArray<Entity> NMNOLKKCICL, NativeList<T> MPEBBGJJODN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2DC8DE0", Offset = "0x2DC81E0", VA = "0x182DC8DE0")]
	public static void FCDPEPAELCC<T>(this BBHAOFNBCPD CDECIAPNKBP, string LBEPPIIBMPA, NativeArray<Entity> NMNOLKKCICL, NativeArray<T> MPEBBGJJODN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public static void FCDPEPAELCC<T>(this BBHAOFNBCPD CDECIAPNKBP, string BNDMOPGGFHK, NativeArray<Entity> NMNOLKKCICL, NativeArray<T> MPEBBGJJODN, bool NGINFEJBBLB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2DC8EE0", Offset = "0x2DC82E0", VA = "0x182DC8EE0")]
	public static void HPKONCCIJKO<T>(this BBHAOFNBCPD CDECIAPNKBP, NativeList<T> MPEBBGJJODN, [Optional][CallerFilePath] string BNDMOPGGFHK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2DC8EB0", Offset = "0x2DC82B0", VA = "0x182DC8EB0")]
	public static void HPKONCCIJKO<T>(this BBHAOFNBCPD CDECIAPNKBP, NativeArray<T> MPEBBGJJODN, [Optional][CallerFilePath] string BNDMOPGGFHK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public static void HPKONCCIJKO<T>(this BBHAOFNBCPD CDECIAPNKBP, string BNDMOPGGFHK, NativeArray<T> MPEBBGJJODN, bool NGINFEJBBLB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public static void OJOHCLBOGIB(this BBHAOFNBCPD CDECIAPNKBP, EntityQuery FDOFAODBNNC, [Optional][CallerFilePath] string BNDMOPGGFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public static void OJOHCLBOGIB(this BBHAOFNBCPD CDECIAPNKBP, string LBEPPIIBMPA, EntityQuery FDOFAODBNNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public static void OJOHCLBOGIB(this BBHAOFNBCPD CDECIAPNKBP, string BNDMOPGGFHK, EntityQuery FDOFAODBNNC, bool NGINFEJBBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2DC8F50", Offset = "0x2DC8350", VA = "0x182DC8F50")]
	public static void KOJDEIDILIB<T, T2>(this BBHAOFNBCPD CDECIAPNKBP, string LBEPPIIBMPA, EntityQuery FDOFAODBNNC) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	private static void KOJDEIDILIB<T, T2>(this BBHAOFNBCPD CDECIAPNKBP, string BNDMOPGGFHK, EntityQuery FDOFAODBNNC, bool NGINFEJBBLB) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IKMGKFNJFNI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NIFOBLJHHEF GONBOMHGDLO
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
public interface KOGHHCDPOPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGKIDJFGOHO(Entity OOEHGINMJGM, object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PONDPEHBLDD(Entity OOEHGINMJGM, object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JPHLGBLIGMF(Entity OOEHGINMJGM);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JPHLGBLIGMF(NIFOBLJHHEF CKELBFAAOKG);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> LFKELECIPDJ(Entity OOEHGINMJGM);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ALPHACHJIHE(Entity OOEHGINMJGM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EMFAIGONLBB<TComponentData, TValue> : global::KBIBONBKFLJ<TValue>, IDisposable where TComponentData : struct, IKMGKFNJFNI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class GJIMPJPDIKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> JOLFKOMKBCI;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int HMGCLIBMMBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x27EABD0", Offset = "0x27E9FD0", VA = "0x1827EABD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x33A2690", Offset = "0x33A1A90", VA = "0x1833A2690")]
		public bool MPAAEPKAHOF(out TValue FPLJCBGEJAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x33A24B0", Offset = "0x33A18B0", VA = "0x1833A24B0")]
		public void BKCAAEBNAMB(object JCHAGIDHJIB, TValue FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x33A2560", Offset = "0x33A1960", VA = "0x1833A2560")]
		public bool GAMANBAONBG(object JCHAGIDHJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x33A25E0", Offset = "0x33A19E0", VA = "0x1833A25E0")]
		public int GLKAIEBIFIN(object JCHAGIDHJIB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x33A2750", Offset = "0x33A1B50", VA = "0x1833A2750")]
		public GJIMPJPDIKF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<GJIMPJPDIKF> HGIIACEOIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::OGHFMFGNANG<NIFOBLJHHEF, GJIMPJPDIKF> FALBJNMCCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager BOGIEIBMFCN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x25259B0", Offset = "0x2524DB0", VA = "0x1825259B0")]
	public EMFAIGONLBB(EntityManager BOGIEIBMFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2525390", Offset = "0x2524790", VA = "0x182525390", Slot = "4")]
	public void AGKIDJFGOHO(Entity OOEHGINMJGM, object JCHAGIDHJIB, TValue FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2525840", Offset = "0x2524C40", VA = "0x182525840", Slot = "5")]
	public bool PONDPEHBLDD(Entity OOEHGINMJGM, object JCHAGIDHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2525630", Offset = "0x2524A30", VA = "0x182525630", Slot = "6")]
	public bool MPAAEPKAHOF(Entity OOEHGINMJGM, out TValue FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x25254D0", Offset = "0x25248D0", VA = "0x1825254D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2525700", Offset = "0x2524B00", VA = "0x182525700")]
	private void NBLDEBNCMFM(GJIMPJPDIKF JMPBCNHBNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x25254F0", Offset = "0x25248F0", VA = "0x1825254F0")]
	private bool EEDIFEBEPLK(Entity OOEHGINMJGM, out NIFOBLJHHEF CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x25255A0", Offset = "0x25249A0", VA = "0x1825255A0")]
	private void EFNPOFJPINJ(Entity OOEHGINMJGM, NIFOBLJHHEF CKELBFAAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25254B0", Offset = "0x25248B0", VA = "0x1825254B0")]
	private bool BOIAMMMNJIK(NIFOBLJHHEF CKELBFAAOKG, out GJIMPJPDIKF JMPBCNHBNDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2525780", Offset = "0x2524B80", VA = "0x182525780")]
	private GJIMPJPDIKF PLBNALIFLLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KBIBONBKFLJ<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGKIDJFGOHO(Entity OOEHGINMJGM, object JCHAGIDHJIB, TValue FPLJCBGEJAP);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PONDPEHBLDD(Entity OOEHGINMJGM, object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MPAAEPKAHOF(Entity OOEHGINMJGM, out TValue FPLJCBGEJAP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NIFOBLJHHEF : global::JNPHCKODDEF<NIFOBLJHHEF>, IKDLAGIDJHG, IEquatable<NIFOBLJHHEF>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly NIFOBLJHHEF CCAIINGOJEF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int JNPBIMHEMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CB0", Offset = "0x7B90B0", VA = "0x1807B9CB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int OABDMKOGJHH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x829550", Offset = "0x828950", VA = "0x180829550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x829560", Offset = "0x828960", VA = "0x180829560", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5B83100", Offset = "0x5B82500", VA = "0x185B83100", Slot = "8")]
	public bool Equals(NIFOBLJHHEF FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5B83150", Offset = "0x5B82550", VA = "0x185B83150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EIDJKICAODJ<T> : KOGHHCDPOPD, IDisposable where T : struct, IKMGKFNJFNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> HGIIACEOIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::OGHFMFGNANG<NIFOBLJHHEF, HashSet<object>> FALBJNMCCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager BOGIEIBMFCN;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3B35380", Offset = "0x3B34780", VA = "0x183B35380")]
	public EIDJKICAODJ(EntityManager BOGIEIBMFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3B32850", Offset = "0x3B31C50", VA = "0x183B32850", Slot = "4")]
	public bool AGKIDJFGOHO(Entity OOEHGINMJGM, object JCHAGIDHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B35130", Offset = "0x3B34530", VA = "0x183B35130", Slot = "5")]
	public bool PONDPEHBLDD(Entity OOEHGINMJGM, object JCHAGIDHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3B33AE0", Offset = "0x3B32EE0", VA = "0x183B33AE0", Slot = "6")]
	public bool JPHLGBLIGMF(Entity OOEHGINMJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3B33CA0", Offset = "0x3B330A0", VA = "0x183B33CA0", Slot = "7")]
	public bool JPHLGBLIGMF(NIFOBLJHHEF CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3B34340", Offset = "0x3B33740", VA = "0x183B34340", Slot = "8")]
	public IEnumerable<object> LFKELECIPDJ(Entity OOEHGINMJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3B340A0", Offset = "0x3B334A0", VA = "0x183B340A0", Slot = "11")]
	public IEnumerable<object> LFKELECIPDJ(NIFOBLJHHEF CKELBFAAOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3B32990", Offset = "0x3B31D90", VA = "0x183B32990", Slot = "9")]
	public bool ALPHACHJIHE(Entity OOEHGINMJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B32EA0", Offset = "0x3B322A0", VA = "0x183B32EA0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3B34610", Offset = "0x3B33A10", VA = "0x183B34610")]
	private void NBLDEBNCMFM(HashSet<object> JMPBCNHBNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3B32FA0", Offset = "0x3B323A0", VA = "0x183B32FA0")]
	private bool EEDIFEBEPLK(Entity OOEHGINMJGM, out NIFOBLJHHEF CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3B33590", Offset = "0x3B32990", VA = "0x183B33590")]
	private bool IGNLPAOPCIH(Entity OOEHGINMJGM, out NIFOBLJHHEF CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3B32E40", Offset = "0x3B32240", VA = "0x183B32E40")]
	private void DJGOAENHNDA(Entity OOEHGINMJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3B33470", Offset = "0x3B32870", VA = "0x183B33470")]
	private void EFNPOFJPINJ(Entity OOEHGINMJGM, NIFOBLJHHEF CKELBFAAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3B34810", Offset = "0x3B33C10", VA = "0x183B34810")]
	private bool PIJCGBPOOHA(NIFOBLJHHEF CKELBFAAOKG, out HashSet<object> JMPBCNHBNDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B34AB0", Offset = "0x3B33EB0", VA = "0x183B34AB0")]
	private HashSet<object> PLBNALIFLLN()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DDOPFFDIOEP : global::HLMBDCMCLOK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5B80E70", Offset = "0x5B80270", VA = "0x185B80E70", Slot = "4")]
	public float LLCPBCJKLID(float3 FPLJCBGEJAP)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EKGILKADPMP : global::HLMBDCMCLOK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5B81400", Offset = "0x5B80800", VA = "0x185B81400", Slot = "4")]
	public float LLCPBCJKLID(float3 FPLJCBGEJAP)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CJGMGMPCJCG : global::HLMBDCMCLOK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5B809B0", Offset = "0x5B7FDB0", VA = "0x185B809B0", Slot = "4")]
	public float LLCPBCJKLID(float3 FPLJCBGEJAP)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct NBKPHFNNBPI : global::HLMBDCMCLOK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xDACA50", Offset = "0xDABE50", VA = "0x180DACA50", Slot = "4")]
	public int LLCPBCJKLID(int3 FPLJCBGEJAP)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HFCIGMPCMGA : global::HLMBDCMCLOK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4ACB1D0", Offset = "0x4ACA5D0", VA = "0x184ACB1D0", Slot = "4")]
	public int LLCPBCJKLID(int3 FPLJCBGEJAP)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct INCNCMINGFM : global::HLMBDCMCLOK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5B82670", Offset = "0x5B81A70", VA = "0x185B82670", Slot = "4")]
	public int LLCPBCJKLID(int3 FPLJCBGEJAP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class OBDMMILGCAO : NNJMOBFDOCP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type JHNNPDACJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1A6B7D0", Offset = "0x1A6ABD0", VA = "0x181A6B7D0")]
	public OBDMMILGCAO(Type LGIILKBNMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KHBLHPCMBEB : OBDMMILGCAO
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1A6B7D0", Offset = "0x1A6ABD0", VA = "0x181A6B7D0")]
	public KHBLHPCMBEB(Type LGIILKBNMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BDHOHIGNKAF : OBDMMILGCAO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type CKDDAMBJECN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x77DF40", Offset = "0x77D340", VA = "0x18077DF40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5B7FEB0", Offset = "0x5B7F2B0", VA = "0x185B7FEB0")]
	public BDHOHIGNKAF(Type PLJIICNCENJ, Type LGIILKBNMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MKPGKAIPIEH : OBDMMILGCAO
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1A6B7D0", Offset = "0x1A6ABD0", VA = "0x181A6B7D0")]
	public MKPGKAIPIEH(Type LGIILKBNMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JMGOLFGIKPD : NNJMOBFDOCP
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public JMGOLFGIKPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FOLNNMOIIGM : NNJMOBFDOCP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ENNCJJGDJJI DPJBEDLANDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4780", Offset = "0x6E3B80", VA = "0x1806E4780")]
		[CompilerGenerated]
		get
		{
			return default(ENNCJJGDJJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1A6B840", Offset = "0x1A6AC40", VA = "0x181A6B840")]
	public FOLNNMOIIGM(ENNCJJGDJJI FAPLMCMDPDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class JIBOBOIGILH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly AJIJKHGHPDE LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager BOGIEIBMFCN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AJIJKHGHPDE PHIKONIBLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5B82750", Offset = "0x5B81B50", VA = "0x185B82750")]
	public JIBOBOIGILH(AJIJKHGHPDE LIPGMHFIHCI, EntityManager BOGIEIBMFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2954AB0", Offset = "0x2953EB0", VA = "0x182954AB0")]
	public bool EKMIMJEGPCO<T>(Entity OOEHGINMJGM) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2954A20", Offset = "0x2953E20", VA = "0x182954A20")]
	public bool DOIAKBELBPE<T>(Entity OOEHGINMJGM, out T FPLJCBGEJAP) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2954AF0", Offset = "0x2953EF0", VA = "0x182954AF0")]
	public T FDNGAIIBBOA<T>(Entity OOEHGINMJGM) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x29564D0", Offset = "0x29558D0", VA = "0x1829564D0")]
	private ComponentType HLIDNJAFJAM<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5B82680", Offset = "0x5B81A80", VA = "0x185B82680")]
	private ComponentType HLIDNJAFJAM(Type BKGBGEHNCAE)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class GJGFLACDHIB
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	protected GJGFLACDHIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class CCHBFAIHKPA<View, Data> : AEBPMMDNEJA where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType OFAFCMNGGOG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type GJCPCJJJNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAC20", Offset = "0x3ECA020", VA = "0x183ECAC20", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type CFBAALELGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3ECB460", Offset = "0x3ECA860", VA = "0x183ECB460", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int BDIDBLGBAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3B60EF0", Offset = "0x3B602F0", VA = "0x183B60EF0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E80", Offset = "0x3B60280", VA = "0x183B60E80")]
	public Data IOJHNGBIOMG(Entity OOEHGINMJGM)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3B5FA90", Offset = "0x3B5EE90", VA = "0x183B5FA90")]
	public Data CECNMJDMACI(Entity OOEHGINMJGM)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View NDGDKNACAFN(Entity OOEHGINMJGM);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x336D1E0", Offset = "0x336C5E0", VA = "0x18336D1E0", Slot = "15")]
	protected internal override T NDGDKNACAFN<T>(Entity OOEHGINMJGM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x25390D0", Offset = "0x25384D0", VA = "0x1825390D0")]
	protected CCHBFAIHKPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class AEBPMMDNEJA : JGGHPLEENKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic OODHBIPCIHO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager NPBNPNJJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x705B80", Offset = "0x704F80", VA = "0x180705B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type GJCPCJJJNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type CFBAALELGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int BDIDBLGBAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type FDCDKDJCLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xC21C40", Offset = "0xC21040", VA = "0x180C21C40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int GMEFPMHOKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E940", Offset = "0x5B7DD40", VA = "0x185B7E940", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private HNBCIHNKHJC[] EAILEOJJKAK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xC21B70", Offset = "0xC20F70", VA = "0x180C21B70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual HNBCIHNKHJC[] JPDHPKBIGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E880", Offset = "0x5B7DC80", VA = "0x185B7E880", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LNLOOIBJCJL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E9B0", Offset = "0x5B7DDB0", VA = "0x185B7E9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EA70", Offset = "0x5B7DE70", VA = "0x185B7EA70")]
	public void NPFGFFCDMGH(EntityManager BOGIEIBMFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
	protected JGGHPLEENKB CKPGMIHPHCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T NDGDKNACAFN<T>(Entity OOEHGINMJGM) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EB90", Offset = "0x5B7DF90", VA = "0x185B7EB90", Slot = "8")]
	public (uint, uint) PMENGNDEBBE(Entity OOEHGINMJGM)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E9E0", Offset = "0x5B7DDE0", VA = "0x185B7E9E0", Slot = "9")]
	public bool LJGOHAGNGNE(Entity OOEHGINMJGM, (uint order, uint change) IIMAMIPIKFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	protected AEBPMMDNEJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class JKDNFLNEOBJ<Data> : MABHHCIHNCA where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data OKLBJLNFLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x328E8E0", Offset = "0x328DCE0", VA = "0x18328E8E0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F60", Offset = "0x6C6360", VA = "0x1806C6F60", Slot = "8")]
	protected virtual bool PJFOMDNPNKF(ReadOnlySpan<Data> INJMMDAENFI, NFOMLMHEAPG HHEIDBCECNG, out ReadOnlySpan<byte> LFBMPCLHCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "9")]
	protected virtual bool DCFLACGFEND(int IIMAMIPIKFH, Span<Data> INJMMDAENFI, in ReadOnlySpan<byte> LFBMPCLHCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x328E950", Offset = "0x328DD50", VA = "0x18328E950", Slot = "5")]
	internal sealed override bool PJFOMDNPNKF(ref Unity.Entities.Chunk MMMDCDCMKJM, int DABCFJJGEPB, NFOMLMHEAPG HHEIDBCECNG, out ReadOnlySpan<byte> LFBMPCLHCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x328E6D0", Offset = "0x328DAD0", VA = "0x18328E6D0", Slot = "6")]
	internal sealed override bool DCFLACGFEND(int IIMAMIPIKFH, ref Unity.Entities.Chunk MMMDCDCMKJM, int DABCFJJGEPB, in ReadOnlySpan<byte> LFBMPCLHCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x30FBA60", Offset = "0x30FAE60", VA = "0x1830FBA60")]
	protected global::DMDNFBCHHAM<Protobuf> GGEODPDFFHH<Protobuf>(ReadOnlySpan<Data> INJMMDAENFI) where Protobuf : IMessage, new()
	{
		return default(global::DMDNFBCHHAM<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x30FBAB0", Offset = "0x30FAEB0", VA = "0x1830FBAB0")]
	protected global::BNKHDNDCLIB<Protobuf> LOCKKHIMDIH<Protobuf>(ReadOnlySpan<byte> LFBMPCLHCOB, ReadOnlySpan<Data> INJMMDAENFI, Action<Protobuf> ECMGIODEMHJ) where Protobuf : IMessage, new()
	{
		return default(global::BNKHDNDCLIB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x25390D0", Offset = "0x25384D0", VA = "0x1825390D0")]
	protected JKDNFLNEOBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class MABHHCIHNCA
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int OABDMKOGJHH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5B82A50", Offset = "0x5B81E50", VA = "0x185B82A50", Slot = "5")]
	internal virtual bool PJFOMDNPNKF(ref Unity.Entities.Chunk MMMDCDCMKJM, int DABCFJJGEPB, NFOMLMHEAPG HHEIDBCECNG, out ReadOnlySpan<byte> LFBMPCLHCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "6")]
	internal virtual bool DCFLACGFEND(int IIMAMIPIKFH, ref Unity.Entities.Chunk MMMDCDCMKJM, int DABCFJJGEPB, in ReadOnlySpan<byte> LFBMPCLHCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	protected MABHHCIHNCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HLMBDCMCLOK<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LLCPBCJKLID(TFrom FPLJCBGEJAP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HBLJMLCBBAH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MDDGLACACKL(T FPLJCBGEJAP);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct JPPLDIPLJBH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::HLMBDCMCLOK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> JACNBIIGPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> FAENBLPAONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap EFFJGLADCMH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct JABJMPCPAPF<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::HLMBDCMCLOK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> MIMINDGMGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> FAENBLPAONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap EFFJGLADCMH;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct COBDIPDEBNO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AMLNFHJAHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> JACNBIIGPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> FAENBLPAONP;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D945B0", Offset = "0x3D939B0", VA = "0x183D945B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct IMCFMLCIAFM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AMLNFHJAHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> JACNBIIGPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> NJIOMGFFAJD;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct KFBPPMLMBNL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::HLMBDCMCLOK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> HNKKOOFFBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> FAENBLPAONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap EFFJGLADCMH;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct NNOPDNBAEGF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LGIILKBNMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> PJGGFOCDOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> HIGIKKOFPPA;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct GEENOOCIFBH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LGIILKBNMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> PJGGFOCDOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> HIGIKKOFPPA;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3395B20", Offset = "0x3394F20", VA = "0x183395B20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct GGANMMGJHOH<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> JACNBIIGPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> NJIOMGFFAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, HOGMLAALAEJ> HMAHEBBHMNM;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3399E40", Offset = "0x3399240", VA = "0x183399E40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct BFIFCNFHHAE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::HLMBDCMCLOK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> JACNBIIGPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> NJIOMGFFAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, HOGMLAALAEJ> HMAHEBBHMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap EFFJGLADCMH;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct KJOJNONBDDP<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::HBLJMLCBBAH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> JACNBIIGPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> NJIOMGFFAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate EFFJGLADCMH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct LMLAMJGLMGF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity LGIILKBNMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> PJGGFOCDOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> OJEMNLBMOCO;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B829C0", Offset = "0x5B81DC0", VA = "0x185B829C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct BFNOIDCNHIG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity LGIILKBNMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> PJGGFOCDOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> OJEMNLBMOCO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5B80720", Offset = "0x5B7FB20", VA = "0x185B80720", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class HFIJFEDAOFB
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class JIDLNFBOOKA
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2956CD0", Offset = "0x29560D0", VA = "0x182956CD0")]
	public static bool ANHENCPDLFE<T>(this NativeArray<Entity> PJGGFOCDOMC, EntityManager BOGIEIBMFCN, Allocator NDJJBKEIGCD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class AMCANBPDLKB
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class EKMNPFAKBEM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public EKMNPFAKBEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class NKJCGNBKBPF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public NKJCGNBKBPF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> GAJPMIGKOPI;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5B7FCE0", Offset = "0x5B7F0E0", VA = "0x185B7FCE0")]
	public AMCANBPDLKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HNGPMDDCDIK
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KHKCPFHCAEP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct CJCKLBJEMCB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct KCHLOIFBJOL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal CJCKLBJEMCB<TFrom> CNDFBGEJOLI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator NDJJBKEIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> KEPPKNDIOGA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct AADMMJEGOBG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct LCCHPIFDGGD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal AADMMJEGOBG<TFrom> CNDFBGEJOLI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator NDJJBKEIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> KEPPKNDIOGA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct ODDCMDKDNKL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct JGGFBNOAMDK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal ODDCMDKDNKL<TFrom> CNDFBGEJOLI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator NDJJBKEIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> KEPPKNDIOGA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct JLMPDHACEDF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct ODELJIDBBGB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal JLMPDHACEDF<TFrom> CNDFBGEJOLI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator NDJJBKEIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> KEPPKNDIOGA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FOGLINILEMM
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JMGHFKPJFLN
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x29577C0", Offset = "0x2956BC0", VA = "0x1829577C0")]
	public static NativeList<T> LHDCBHKEIJP<T>(this NativeArray<T> HLPMIAJBFDL, Allocator NDJJBKEIGCD = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class NLMANBBALOH
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x320C710", Offset = "0x320BB10", VA = "0x18320C710")]
	public static NativeArray<T> ADNEIGAHDBH<T>(this NativeList<Entity> HLPMIAJBFDL, EntityManager BOGIEIBMFCN, Allocator NDJJBKEIGCD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x320C510", Offset = "0x320B910", VA = "0x18320C510")]
	public static NativeArray<T> ADNEIGAHDBH<T>(this NativeArray<Entity> HLPMIAJBFDL, EntityManager BOGIEIBMFCN, Allocator NDJJBKEIGCD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class LFFAEFBMDLI
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct MGGNDOEBJLL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct CABFKMEIIEP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public MGGNDOEBJLL<TFrom> KEPPKNDIOGA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator NDJJBKEIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> JACNBIIGPKC;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct AAEAOOAHNFL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct DGCFLGPFBGK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public AAEAOOAHNFL<TFrom> KEPPKNDIOGA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator NDJJBKEIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> JACNBIIGPKC;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct BLIPGDJKPFB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct ODPNNIJCNCC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public BLIPGDJKPFB<TFrom> KEPPKNDIOGA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator NDJJBKEIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> JACNBIIGPKC;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class ALKMBKHPBIO
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class PJECACBKHGD
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct OAKDHCBEINI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator NDJJBKEIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> JACNBIIGPKC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct LLINFJOHIAF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator NDJJBKEIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> JACNBIIGPKC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct LBCECMFKDJN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator NDJJBKEIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> JACNBIIGPKC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct CNHPDGPPKNM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator NDJJBKEIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> JACNBIIGPKC;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class PAIBJLIEIIJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class JCLCLCGIOEF
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2954220", Offset = "0x2953620", VA = "0x182954220")]
	public static NativeList<Entity> PKAAPFMAJHM<T>(this NativeArray<Entity> PJGGFOCDOMC, EntityManager BOGIEIBMFCN, Allocator NDJJBKEIGCD = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class KBIDLFLBJPK
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface MINBHMAHNGD
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface DCELCMCLNDM
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class KLAPBLBEMKA
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class PNPGJLJEIML
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5B83540", Offset = "0x5B82940", VA = "0x185B83540")]
	public static bool LGAKHNIOCAB(Type BKGBGEHNCAE, Type HPMNNKMOJPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class IIGKPKLPNOM<Attribute, BaseClass> : global::NKFIBKNNFLB<BaseClass>, KINDMNCCNKN where Attribute : OBDMMILGCAO
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly BBHAOFNBCPD CDECIAPNKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string LBEPPIIBMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> FCHMAFFHBBI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x28069C0", Offset = "0x2805DC0", VA = "0x1828069C0")]
	public IIGKPKLPNOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2806390", Offset = "0x2805790", VA = "0x182806390", Slot = "4")]
	public bool AGHBGCOAOGM(int KCBELKOOOJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2806510", Offset = "0x2805910", VA = "0x182806510", Slot = "5")]
	public global::BNIKHELKNNI<BaseClass> JALNKELPOBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x28067C0", Offset = "0x2805BC0", VA = "0x1828067C0", Slot = "7")]
	protected virtual bool LGAKHNIOCAB(Type BKGBGEHNCAE, int FEDEMMGMHFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x28063F0", Offset = "0x28057F0", VA = "0x1828063F0", Slot = "8")]
	protected virtual int FMMLAICKIJJ(Type BKGBGEHNCAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2806480", Offset = "0x2805880", VA = "0x182806480")]
	public void IPAAHMOMIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x28068C0", Offset = "0x2805CC0", VA = "0x1828068C0", Slot = "6")]
	public void MHBAMOAJPNP(Type BKGBGEHNCAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BNIKHELKNNI<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> HFOPNLACHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> GELCFGKCIPB;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> JJJFGALCOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x31E6450", Offset = "0x31E5850", VA = "0x1831E6450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x31E6680", Offset = "0x31E5A80", VA = "0x1831E6680")]
	public BNIKHELKNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x31E6810", Offset = "0x31E5C10", VA = "0x1831E6810")]
	public BNIKHELKNNI(int NANBMPFBPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x31E62D0", Offset = "0x31E56D0", VA = "0x1831E62D0")]
	internal void BKCAAEBNAMB(int KCBELKOOOJG, BaseClass OLBLAKNPIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x336A3C0", Offset = "0x33697C0", VA = "0x18336A3C0")]
	public bool GPODNCCLBJD<T>(out BaseClass FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x31E6350", Offset = "0x31E5750", VA = "0x1831E6350")]
	public bool GPODNCCLBJD(Type ACMABPBDHLP, out BaseClass FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x31E63F0", Offset = "0x31E57F0", VA = "0x1831E63F0")]
	public bool HDFFGIOBHJN(int KCBELKOOOJG, out BaseClass FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x336B0D0", Offset = "0x336A4D0", VA = "0x18336B0D0")]
	public T JEDAONAAMCO<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x31E6420", Offset = "0x31E5820", VA = "0x1831E6420")]
	public BaseClass JEDAONAAMCO(Type CLIHFOCAHPK)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class PJCHECLLBFB : global::IIGKPKLPNOM<KHBLHPCMBEB, GJGFLACDHIB>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5B834D0", Offset = "0x5B828D0", VA = "0x185B834D0")]
	public PJCHECLLBFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class MOMMACKLALA : global::IIGKPKLPNOM<BDHOHIGNKAF, AEBPMMDNEJA>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B82A70", Offset = "0x5B81E70", VA = "0x185B82A70")]
	public MOMMACKLALA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class FEFJHLADKPH : global::IIGKPKLPNOM<MKPGKAIPIEH, MABHHCIHNCA>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5B81680", Offset = "0x5B80A80", VA = "0x185B81680")]
	public FEFJHLADKPH()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[NAPHGBOEKGO(GPIMBHHJLKL.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> AOALHLGMLAI;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7809C0", Offset = "0x77FDC0", VA = "0x1807809C0")]
		private ComponentSystemTypes(List<Type> AOALHLGMLAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5B80AD0", Offset = "0x5B7FED0", VA = "0x185B80AD0")]
		public static void IPAAHMOMIKO(List<Type> AOALHLGMLAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5B80BE0", Offset = "0x5B7FFE0", VA = "0x185B80BE0")]
		private void PAIEAFJDOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5B80B60", Offset = "0x5B7FF60", VA = "0x185B80B60")]
		private bool LGAKHNIOCAB(Type BKGBGEHNCAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5B80A70", Offset = "0x5B7FE70", VA = "0x185B80A70")]
		private void EHFMHKPOMOP(Type BKGBGEHNCAE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class CPLEAJCINAE : PPGAFNDLJLE
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5B80A30", Offset = "0x5B7FE30", VA = "0x185B80A30", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase EGHJJGHDALP();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5B809E0", Offset = "0x5B7FDE0", VA = "0x185B809E0")]
	protected ComponentSystemBase ALBHNKAACLB(params ComponentSystemBase[] EIINEJPEGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4960", Offset = "0x2CA3D60", VA = "0x182CA4960")]
	protected ComponentSystemBase ALBHNKAACLB<T>(params ComponentSystemBase[] EIINEJPEGBG) where T : PPGAFNDLJLE, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4A00", Offset = "0x2CA3E00", VA = "0x182CA4A00")]
	protected ComponentSystemBase OJKFNMEFBHJ<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4A00", Offset = "0x2CA3E00", VA = "0x182CA4A00")]
	protected ComponentSystemBase DEKGLCGFJAJ<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	protected CPLEAJCINAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface NKFIBKNNFLB<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGHBGCOAOGM(int KCBELKOOOJG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BNIKHELKNNI<BaseClass> JALNKELPOBC();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class PPGAFNDLJLE : KJFBGJEBIND
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B83720", Offset = "0x5B82B20", VA = "0x185B83720", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public PPGAFNDLJLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class FNIOMAHLONI : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5B816F0", Offset = "0x5B80AF0", VA = "0x185B816F0")]
	public ComponentDataFromEntity JAOAKPINNAN(int KCBELKOOOJG, bool PDFHGGAOKAG = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5B81790", Offset = "0x5B80B90", VA = "0x185B81790", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640")]
	protected FNIOMAHLONI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class IHCOEHCAPMG : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640")]
	protected IHCOEHCAPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class LLHDIPFAHAE : FNIOMAHLONI
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5B82990", Offset = "0x5B81D90", VA = "0x185B82990", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	protected void EOAHMHBMJCM(string HPCOFNJFOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640")]
	protected LLHDIPFAHAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class ENGDAMHNNCN
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class KJFBGJEBIND : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	protected KJFBGJEBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[NAPHGBOEKGO(GPIMBHHJLKL.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5B84AB0", Offset = "0x5B83EB0", VA = "0x185B84AB0")]
		public static ComponentSystemGroup[] OLDHIPKLBDJ(World LIPGMHFIHCI, EKDPNLDEHKO LKGAHGJBBFM = EKDPNLDEHKO.Default, bool KGBPDBOKJJO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5B84160", Offset = "0x5B83560", VA = "0x185B84160")]
		private static Type[] GMPBAAOAFMJ(EKDPNLDEHKO LKGAHGJBBFM, bool KGBPDBOKJJO, ComponentSystemGroup[] JGGKFJBAHDP, ComponentSystemGroup DHDHFMMEBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5B844C0", Offset = "0x5B838C0", VA = "0x185B844C0")]
		private static ComponentSystemGroup[] HHMPJMLLNIG(World LIPGMHFIHCI, out ComponentSystemGroup DHDHFMMEBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5B84830", Offset = "0x5B83C30", VA = "0x185B84830")]
		internal static bool NMPNILJJOGG(ENNCJJGDJJI FAPLMCMDPDI, out DBKOLKOPCAB JBJFOEOLLJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5B84080", Offset = "0x5B83480", VA = "0x185B84080")]
		private static ComponentSystemGroup GBOAJFGHELA(Type BKGBGEHNCAE, World LIPGMHFIHCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5B839D0", Offset = "0x5B82DD0", VA = "0x185B839D0")]
		private static ComponentSystemGroup[] CECDAEGKONB(Type[] AOALHLGMLAI, World LIPGMHFIHCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5B83B00", Offset = "0x5B82F00", VA = "0x185B83B00")]
		internal static void DMCGJOPLIGB(World LIPGMHFIHCI, Type[] IMOGODOINGH, ComponentSystemGroup[] JGGKFJBAHDP, ComponentSystemGroup DHDHFMMEBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B847D0", Offset = "0x5B83BD0", VA = "0x185B847D0")]
		internal static bool LKIFIMGMHBP(ComponentSystemBase AAMAOJJKJKL, ComponentSystemGroup[] JGGKFJBAHDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B84020", Offset = "0x5B83420", VA = "0x185B84020")]
		private static void GBCDCGAFJJN(ComponentSystemGroup[] JGGKFJBAHDP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct KAGBOPAFPJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> KLNPLPIBBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> EIINEJPEGBG;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAABA10", Offset = "0xAAAE10", VA = "0x180AABA10")]
	public KAGBOPAFPJE(Dictionary<Type, List<Type>> KLNPLPIBBLO, HashSet<Type> EIINEJPEGBG)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[NAPHGBOEKGO(GPIMBHHJLKL.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class HLJGKAIOMNO : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
			[DebuggerHidden]
			public HLJGKAIOMNO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5B81AF0", Offset = "0x5B80EF0", VA = "0x185B81AF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5B81850", Offset = "0x5B80C50", VA = "0x185B81850", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5B81B80", Offset = "0x5B80F80", VA = "0x185B81B80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5B81AB0", Offset = "0x5B80EB0", VA = "0x185B81AB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5B81A00", Offset = "0x5B80E00", VA = "0x185B81A00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5B81A00", Offset = "0x5B80E00", VA = "0x185B81A00", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct NAKGJGDCODB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type AOAINDGHNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private EKDPNLDEHKO LKGAHGJBBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool JNIJKCOILLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool FCFNADCKBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool KGBPDBOKJJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> PGIONACLKPD;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5B85AF0", Offset = "0x5B84EF0", VA = "0x185B85AF0")]
		public static RRFilterWorldSystems PELCFOCODBC()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5B84CA0", Offset = "0x5B840A0", VA = "0x185B84CA0")]
		public RRFilterWorldSystems FHJFMANACJF(EKDPNLDEHKO FAPLMCMDPDI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5B84E70", Offset = "0x5B84270", VA = "0x185B84E70")]
		public RRFilterWorldSystems FOHLELPOCOP(IEnumerable<Type> AOALHLGMLAI)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5B859C0", Offset = "0x5B84DC0", VA = "0x185B859C0")]
		public RRFilterWorldSystems KIHADNJNLGE(bool OGCJHKFFCFA)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5B85AE0", Offset = "0x5B84EE0", VA = "0x185B85AE0")]
		public RRFilterWorldSystems NAEDJBFGJDG(bool HDPEPPNFKCB)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5B84C10", Offset = "0x5B84010", VA = "0x185B84C10")]
		public KAGBOPAFPJE DLPMLCPPAPD(Type[] IPECINPMLOB)
		{
			return default(KAGBOPAFPJE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5B854F0", Offset = "0x5B848F0", VA = "0x185B854F0")]
		[IteratorStateMachine(typeof(HLJGKAIOMNO))]
		internal IEnumerable<Type> HLMJIDCECOP(IEnumerable<Type> AOALHLGMLAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5B85580", Offset = "0x5B84980", VA = "0x185B85580")]
		internal Dictionary<Type, List<Type>> HNEEEFIMLEH(IEnumerable<Type> AOALHLGMLAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5B859D0", Offset = "0x5B84DD0", VA = "0x185B859D0")]
		private void MFALIGBEHAO(Dictionary<Type, List<Type>> GNLABAOMILF, Type BKGBGEHNCAE, Type LFOODKOAPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5B84CB0", Offset = "0x5B840B0", VA = "0x185B84CB0")]
		internal HashSet<Type> FMEKBEGKJCC(IEnumerable<Type> JGGKFJBAHDP, Dictionary<Type, List<Type>> MJKBPIALMBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5B84EB0", Offset = "0x5B842B0", VA = "0x185B84EB0")]
		internal bool HIHOJNNAALC(Type BKGBGEHNCAE, EKDPNLDEHKO LKGAHGJBBFM, bool KGBPDBOKJJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5B85860", Offset = "0x5B84C60", VA = "0x185B85860")]
		[CompilerGenerated]
		internal static void JMGINEALHKN(Type BKGBGEHNCAE, ref NAKGJGDCODB P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class NLMBCLMMLBB
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool FGGBDCIABAG;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5B83360", Offset = "0x5B82760", VA = "0x185B83360")]
	public static void NPFGFFCDMGH(bool MGJBBFOJNFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5B831A0", Offset = "0x5B825A0", VA = "0x185B831A0")]
	private static void CPEGBKPMNAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class EOCKDDMLMJP
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5B814D0", Offset = "0x5B808D0", VA = "0x185B814D0")]
	public static ulong CEMGGFAJGBC(Type BKGBGEHNCAE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5B81410", Offset = "0x5B80810", VA = "0x185B81410")]
	public static ulong CEMGGFAJGBC(string LEKCMGCJNKG)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[NAPHGBOEKGO(GPIMBHHJLKL.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct IJONLAJNBLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong BKHENLNNIGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong GEKCHGFBBMN;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x1015600", Offset = "0x1014A00", VA = "0x181015600")]
			public IJONLAJNBLC(ulong NLNEHINCJJB, ulong FLLILACKMGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5B825E0", Offset = "0x5B819E0", VA = "0x185B825E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> LKIEMDLDMAM;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static IJONLAJNBLC[] AJDPCBBCGBE;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool FGGBDCIABAG;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5B86330", Offset = "0x5B85730", VA = "0x185B86330")]
		public static ulong LKJIHJBHOKJ(int KCBELKOOOJG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5B85F60", Offset = "0x5B85360", VA = "0x185B85F60")]
		public static int GIDDJPDNKED(ulong FLLILACKMGP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5B86390", Offset = "0x5B85790", VA = "0x185B86390")]
		public static void NPFGFFCDMGH(bool MGJBBFOJNFN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5B866F0", Offset = "0x5B85AF0", VA = "0x185B866F0")]
		private static void PJNFKDACLHO(int MBFMPBBGNEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5B86010", Offset = "0x5B85410", VA = "0x185B86010")]
		private static void HLBFNJHGKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5B85E00", Offset = "0x5B85200", VA = "0x185B85E00")]
		private static IJONLAJNBLC DOMNPBNJOEK(Type BKGBGEHNCAE)
		{
			return default(IJONLAJNBLC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5B85EF0", Offset = "0x5B852F0", VA = "0x185B85EF0")]
		private static ulong FEDEDIDEFLL(Type BKGBGEHNCAE, ulong FLLILACKMGP)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5B85BE0", Offset = "0x5B84FE0", VA = "0x185B85BE0")]
		private static void DEPAGICFOCL(in IJONLAJNBLC ENOCLDDBPBE, TypeManager.TypeInfo DOJAIALBHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5B867D0", Offset = "0x5B85BD0", VA = "0x185B867D0")]
		private static void POKIDMBLMNF(IJONLAJNBLC DOJAIALBHCF, int KCBELKOOOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5B86610", Offset = "0x5B85A10", VA = "0x185B86610")]
		private static void PGOMDOFJJFN(IJONLAJNBLC DOJAIALBHCF, int KCBELKOOOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5B86580", Offset = "0x5B85980", VA = "0x185B86580")]
		private static IJONLAJNBLC OMJDJLLOHMN(int KCBELKOOOJG)
		{
			return default(IJONLAJNBLC);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5B85EE0", Offset = "0x5B852E0", VA = "0x185B85EE0")]
		private static int EEGAEIFAAGP(int KCBELKOOOJG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class IEALEADMHJC
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly MOMMACKLALA HIJNOCLJJGD;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly FEFJHLADKPH HPHEPPLEGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly PJCHECLLBFB ECDHMAIOLIB;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> DBPEBADCPPB;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool FGGBDCIABAG;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::NKFIBKNNFLB<AEBPMMDNEJA> FEDEKGEKICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5B81BD0", Offset = "0x5B80FD0", VA = "0x185B81BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::NKFIBKNNFLB<MABHHCIHNCA> PKICMCBJOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5B81C30", Offset = "0x5B81030", VA = "0x185B81C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::NKFIBKNNFLB<GJGFLACDHIB> JNGJACGPAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5B81C90", Offset = "0x5B81090", VA = "0x185B81C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5B81D70", Offset = "0x5B81170", VA = "0x185B81D70")]
	public static void NPFGFFCDMGH(bool MGJBBFOJNFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5B81CF0", Offset = "0x5B810F0", VA = "0x185B81CF0")]
	public static Type[] MIIBKJCFHJF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class EFBJGBJHNFB
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> JBLLMBEMMOI;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool FGGBDCIABAG;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5B812E0", Offset = "0x5B806E0", VA = "0x185B812E0")]
	public static int PMENGNDEBBE(int KCBELKOOOJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5B80FC0", Offset = "0x5B803C0", VA = "0x185B80FC0")]
	public static void NPFGFFCDMGH(bool MGJBBFOJNFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5B81060", Offset = "0x5B80460", VA = "0x185B81060")]
	private static void OJBPJJKLMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5B80F70", Offset = "0x5B80370", VA = "0x185B80F70")]
	private static int NGGLFHLFAKA(Type BKGBGEHNCAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5B80EF0", Offset = "0x5B802F0", VA = "0x185B80EF0")]
	private static void BIEFCABEIDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class AJIJKHGHPDE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World JIKCHAEDNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly JIBOBOIGILH OLBLAKNPIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] JGGKFJBAHDP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World PHIKONIBLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World KMLEAECJLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager NPBNPNJJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xE940D0", Offset = "0xE934D0", VA = "0x180E940D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public JIBOBOIGILH NANHEDFHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::BNIKHELKNNI<AEBPMMDNEJA> FEDEKGEKICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x81B670", Offset = "0x81AA70", VA = "0x18081B670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::BNIKHELKNNI<MABHHCIHNCA> PKICMCBJOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6C72D0", Offset = "0x6C66D0", VA = "0x1806C72D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7776A0", Offset = "0x776AA0", VA = "0x1807776A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::BNIKHELKNNI<GJGFLACDHIB> JNGJACGPAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6D2590", Offset = "0x6D1990", VA = "0x1806D2590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x782E50", Offset = "0x782250", VA = "0x180782E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> KLKODJCENGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xE94110", Offset = "0xE93510", VA = "0x180E94110")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] PBKPIFPANDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5B7ECB0", Offset = "0x5B7E0B0", VA = "0x185B7ECB0")]
	public static AJIJKHGHPDE BGJIFJEFALG(string LBEPPIIBMPA, ENNCJJGDJJI FAPLMCMDPDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F690", Offset = "0x5B7EA90", VA = "0x185B7F690")]
	public AJIJKHGHPDE(string LBEPPIIBMPA, ENNCJJGDJJI FAPLMCMDPDI = ENNCJJGDJJI.Simulation, EKDPNLDEHKO LKGAHGJBBFM = EKDPNLDEHKO.Default, bool MGJBBFOJNFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F410", Offset = "0x5B7E810", VA = "0x185B7F410")]
	public ComponentSystemBase JNOOLBMCIGN(Type BKGBGEHNCAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3815E40", Offset = "0x3815240", VA = "0x183815E40")]
	public T JNOOLBMCIGN<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F290", Offset = "0x5B7E690", VA = "0x185B7F290")]
	public void FAADECCCPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F2F0", Offset = "0x5B7E6F0", VA = "0x185B7F2F0")]
	public void FAHPCLFPFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F350", Offset = "0x5B7E750", VA = "0x185B7F350")]
	public void FKMAEBPHPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EC50", Offset = "0x5B7E050", VA = "0x185B7EC50")]
	public void APNFPCCDJKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F430", Offset = "0x5B7E830", VA = "0x185B7F430")]
	public void KJHJFHAIKNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F150", Offset = "0x5B7E550", VA = "0x185B7F150")]
	public void EAPFAJMMKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F3B0", Offset = "0x5B7E7B0", VA = "0x185B7F3B0")]
	public void IDGMCHMDBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F4F0", Offset = "0x5B7E8F0", VA = "0x185B7F4F0")]
	public void NEEMJIJFHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F1B0", Offset = "0x5B7E5B0", VA = "0x185B7F1B0")]
	public void EBBPIPJBKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F490", Offset = "0x5B7E890", VA = "0x185B7F490")]
	public void LPJLLDNBDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F000", Offset = "0x5B7E400", VA = "0x185B7F000")]
	internal void DMNOJFIBBGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F210", Offset = "0x5B7E610", VA = "0x185B7F210")]
	private bool ENDHNEKMMPI(ComponentSystemGroup MLMPFJIEGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5B7ED30", Offset = "0x5B7E130", VA = "0x185B7ED30")]
	private void CKDAOMGJKJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F580", Offset = "0x5B7E980", VA = "0x185B7F580")]
	private ComponentSystemGroup[] OLDHIPKLBDJ(EKDPNLDEHKO LKGAHGJBBFM, bool KGBPDBOKJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F0E0", Offset = "0x5B7E4E0", VA = "0x185B7F0E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum ENNCJJGDJJI
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
public sealed class KNLCILKGEDD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public EKDPNLDEHKO EOMFCNGGPOJ;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum EKDPNLDEHKO
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
public interface DBKOLKOPCAB
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type HKPGKBDNMBC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] INDKBFDAONE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class PHNOKNPMPIK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool KBDNIIIEKAM
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x798260", Offset = "0x797660", VA = "0x180798260", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	protected PHNOKNPMPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class EJJEKNIEJEG : PHNOKNPMPIK
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public EJJEKNIEJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class CMBMNPJPBFO : PHNOKNPMPIK
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public CMBMNPJPBFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class KCEIFHEFILO : PHNOKNPMPIK
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public KCEIFHEFILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class KPHLIOBCLNG : PHNOKNPMPIK
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public KPHLIOBCLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class KEGKPFMPCFC : PHNOKNPMPIK
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public KEGKPFMPCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class PDJIPGJNAFN : PHNOKNPMPIK
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public PDJIPGJNAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class MNKIBFDELDE : PHNOKNPMPIK
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public MNKIBFDELDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class DAONCNOMFNJ : PHNOKNPMPIK
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public DAONCNOMFNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class EENCLPOCMKD : PHNOKNPMPIK
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public EENCLPOCMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class FENPKCJMFAI : OCLIOOABDHG
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public FENPKCJMFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class FNIMKPCEBGE : OCLIOOABDHG
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public FNIMKPCEBGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class DPMJCGCLFLL : OCLIOOABDHG
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public DPMJCGCLFLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class HBAPGHAGNNO : OCLIOOABDHG
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public HBAPGHAGNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[AECGGFPDEPE(FPOGPJMGMEG.Application)]
public class OCLIOOABDHG : PHNOKNPMPIK
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool KBDNIIIEKAM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5B809D0", Offset = "0x5B7FDD0", VA = "0x185B809D0")]
	public OCLIOOABDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class ONGHGJGJFIP : NNJMOBFDOCP
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public ONGHGJGJFIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class CBEHPKJABGJ
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void CNIDMBCAAPB<From, To>(From KEPPKNDIOGA, ref To MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class HALAOEMBGLG<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static CNIDMBCAAPB<From, To> IDIJBCJJKMI;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public HALAOEMBGLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5B807B0", Offset = "0x5B7FBB0", VA = "0x185B807B0")]
	static CBEHPKJABGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x32A58C0", Offset = "0x32A4CC0", VA = "0x1832A58C0")]
	public static void HLFGFBMPMPI<T>(CNIDMBCAAPB<T, T> KNFDJOGGIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x32A5750", Offset = "0x32A4B50", VA = "0x1832A5750")]
	public static void HLFGFBMPMPI<From, To>(CNIDMBCAAPB<From, To> KNFDJOGGIMB, CNIDMBCAAPB<To, From> ILDHADFDMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x32A57E0", Offset = "0x32A4BE0", VA = "0x1832A57E0")]
	public static void HLFGFBMPMPI<From, To>(CNIDMBCAAPB<From, To> IDIJBCJJKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x32AA270", Offset = "0x32A9670", VA = "0x1832AA270")]
	public static CNIDMBCAAPB<From, To> MHFPPOKMEFG<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x32A3B10", Offset = "0x32A2F10", VA = "0x1832A3B10")]
	public static void DPFIAKCAAIL<From, To>(From KEPPKNDIOGA, ref To MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class NFOMLMHEAPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> GIOLOIKHKCE;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1698630", Offset = "0x1697A30", VA = "0x181698630")]
	public NFOMLMHEAPG(NativeArray<EntityRemapUtility.EntityRemapInfo> GIOLOIKHKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x37DE4B0", Offset = "0x37DD8B0", VA = "0x1837DE4B0")]
	public Entity LNBOMHFDHAD(Entity HNJNABPJHCC)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class LABBKLNMAOM
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> KOLMAPEAOLF;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5B827A0", Offset = "0x5B81BA0", VA = "0x185B827A0")]
	public static bool CAOKDLOPGCH(ulong FCNILJEDKDH, uint IIMAMIPIKFH, out string LBEPPIIBMPA)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct HICGNFKFMMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int JNPBIMHEMIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int OABDMKOGJHH;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x817230", Offset = "0x816630", VA = "0x180817230")]
			public HICGNFKFMMD(int GABJOMFFJAI, int IIMAMIPIKFH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct IGCEBBJGIEF
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch HFDOHNNPLHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long LKBOGPLMEJJ;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long AKCIGPFDJMP
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x5B82510", Offset = "0x5B81910", VA = "0x185B82510")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long BNCEGKFLDNN
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5B82570", Offset = "0x5B81970", VA = "0x185B82570")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5B82450", Offset = "0x5B81850", VA = "0x185B82450")]
			public static IGCEBBJGIEF ABMGALELFCO()
			{
				return default(IGCEBBJGIEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct BEAMHBDKGAA : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct GAFNKOBNKJE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* LOGNICHIBEB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly AIEMLIJFCID.PMHEBGICJDM.MKMOMHGCCKO FNLFFNJGBPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly NFOMLMHEAPG HHEIDBCECNG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::BNIKHELKNNI<MABHHCIHNCA> DJINGHENHLO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int DABCFJJGEPB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int CJHNCJBFHIC;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x5B817A0", Offset = "0x5B80BA0", VA = "0x185B817A0")]
				public unsafe GAFNKOBNKJE(Unity.Entities.Archetype* LOGNICHIBEB, AIEMLIJFCID.PMHEBGICJDM.MKMOMHGCCKO FNLFFNJGBPM, NFOMLMHEAPG HHEIDBCECNG, global::BNIKHELKNNI<MABHHCIHNCA> DJINGHENHLO, int DABCFJJGEPB, int CJHNCJBFHIC = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5B81800", Offset = "0x5B80C00", VA = "0x185B81800")]
				public GAFNKOBNKJE(in GAFNKOBNKJE MPEBBGJJODN, int CJHNCJBFHIC)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly GAFNKOBNKJE[] INJMMDAENFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] JCLCDHCOHCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int HEDBLNFNBDG;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5B805E0", Offset = "0x5B7F9E0", VA = "0x185B805E0")]
			public BEAMHBDKGAA(GAFNKOBNKJE[] INJMMDAENFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5B802B0", Offset = "0x5B7F6B0", VA = "0x185B802B0", Slot = "4")]
			public void Invoke(int GABJOMFFJAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5B7FF00", Offset = "0x5B7F300", VA = "0x185B7FF00")]
			private void FIKJKMABAPK(in GAFNKOBNKJE MPEBBGJJODN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5B80310", Offset = "0x5B7F710", VA = "0x185B80310")]
			private static void LIBPLJGKJPA(in GAFNKOBNKJE MPEBBGJJODN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class DJKDGCAFNHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public AIEMLIJFCID asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::BNIKHELKNNI<MABHHCIHNCA> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public DJKDGCAFNHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5B80E80", Offset = "0x5B80280", VA = "0x185B80E80")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class BHNNJKMCGBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public AIEMLIJFCID.PMHEBGICJDM.MKMOMHGCCKO srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public DJKDGCAFNHO CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public BHNNJKMCGBI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class PFHPBNIOJMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public BHNNJKMCGBI CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public PFHPBNIOJMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5B833C0", Offset = "0x5B827C0", VA = "0x185B833C0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly BBHAOFNBCPD FEEMOGGLIND;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly BBHAOFNBCPD ABDFILIEEPE;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly BBHAOFNBCPD DHLBPKINKAF;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly BBHAOFNBCPD PHFLEAENIOH;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool GMNLPIAGMDE;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static AIEMLIJFCID.PMHEBGICJDM.LOGFKMOONEF PFLKNAHPHFJ;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5B89C30", Offset = "0x5B89030", VA = "0x185B89C30")]
		private unsafe static bool ODLPBDOEHIM(Unity.Entities.Archetype* EEONIFNHKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5B88020", Offset = "0x5B87420", VA = "0x185B88020")]
		internal unsafe static Unity.Entities.Archetype*[] FGPOKNIHOCJ(ref Unity.Entities.EntityComponentStore IOJHKLIBFMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5B87DB0", Offset = "0x5B871B0", VA = "0x185B87DB0")]
		public static void DKBJOPOHEOD(AJIJKHGHPDE LIPGMHFIHCI, out ByteString LFBMPCLHCOB, out NativeArray<EntityRemapUtility.EntityRemapInfo> HCJKODLJNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5B86960", Offset = "0x5B85D60", VA = "0x185B86960")]
		internal static void AKGLEHPEBPD(AJIJKHGHPDE LIPGMHFIHCI, AIEMLIJFCID POLLOCBFPFF, out NativeArray<EntityRemapUtility.EntityRemapInfo> HCJKODLJNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5B87090", Offset = "0x5B86490", VA = "0x185B87090")]
		private unsafe static UnsafeHashMap<ulong, HICGNFKFMMD> BAGJDLGJPDG(Unity.Entities.Archetype*[] FAHCHCPPFOI)
		{
			return default(UnsafeHashMap<ulong, HICGNFKFMMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5B87E70", Offset = "0x5B87270", VA = "0x185B87E70")]
		private static void EILCOPCODNF(AIEMLIJFCID POLLOCBFPFF, UnsafeHashMap<ulong, HICGNFKFMMD> HAMONAFGNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5B89D40", Offset = "0x5B89140", VA = "0x185B89D40")]
		private unsafe static void OPDCNJGCLMM(AIEMLIJFCID POLLOCBFPFF, Unity.Entities.Archetype*[] FAHCHCPPFOI, UnsafeHashMap<ulong, HICGNFKFMMD> HAMONAFGNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5B88BE0", Offset = "0x5B87FE0", VA = "0x185B88BE0")]
		private unsafe static int LAJBKBNCMAN(Unity.Entities.Archetype*[] FAHCHCPPFOI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5B89680", Offset = "0x5B88A80", VA = "0x185B89680")]
		private unsafe static void MOHPBJGFKBB(AIEMLIJFCID POLLOCBFPFF, Unity.Entities.Archetype*[] FAHCHCPPFOI, global::BNIKHELKNNI<MABHHCIHNCA> DJINGHENHLO, NativeArray<EntityRemapUtility.EntityRemapInfo> HCJKODLJNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5B8A070", Offset = "0x5B89470", VA = "0x185B8A070")]
		private static NativeArray<int> PCONLGHFBMJ(AIEMLIJFCID POLLOCBFPFF)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5B88280", Offset = "0x5B87680", VA = "0x185B88280")]
		private static Memory<EntityArchetype> HPEJAOLNDCD(AIEMLIJFCID POLLOCBFPFF, NativeArray<int> AOALHLGMLAI, EntityManager BOGIEIBMFCN, out int DDNLFPNAFBF, out int LDEMIPAGHIL)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5B87A60", Offset = "0x5B86E60", VA = "0x185B87A60")]
		private unsafe static void CIMBHDCLLDF(Unity.Entities.Chunk* CKEBLBLOMAH, ReadOnlySpan<byte> LFBMPCLHCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5B87320", Offset = "0x5B86720", VA = "0x185B87320")]
		private static void BLIJAFOOBIP(AIEMLIJFCID POLLOCBFPFF, NativeArray<int> AOALHLGMLAI, Span<EntityArchetype> FAHCHCPPFOI, EntityManager BOGIEIBMFCN, global::BNIKHELKNNI<MABHHCIHNCA> DJINGHENHLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5B88200", Offset = "0x5B87600", VA = "0x185B88200")]
		private unsafe static void FIBAJDJHINA(Unity.Entities.Chunk* MMMDCDCMKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5B888D0", Offset = "0x5B87CD0", VA = "0x185B888D0")]
		private unsafe static void IGECGPLCJHI(AIEMLIJFCID.PMHEBGICJDM.MKMOMHGCCKO LOGNICHIBEB, int BMOEOONCBBP, int EGEHBHBOCEG, Unity.Entities.Chunk* CKEBLBLOMAH, AIEMLIJFCID POLLOCBFPFF, NativeArray<int> AOALHLGMLAI, global::BNIKHELKNNI<MABHHCIHNCA> DJINGHENHLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5B895F0", Offset = "0x5B889F0", VA = "0x185B895F0")]
		public static void MOGLOLDHCIK(AJIJKHGHPDE LIPGMHFIHCI, in ByteString LFBMPCLHCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5B88FA0", Offset = "0x5B883A0", VA = "0x185B88FA0")]
		public static void MOGLOLDHCIK(EntityManager BOGIEIBMFCN, global::BNIKHELKNNI<MABHHCIHNCA> DJINGHENHLO, in ByteString LFBMPCLHCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5B88610", Offset = "0x5B87A10", VA = "0x185B88610")]
		private static bool IDEIGJHALNP(Type BKGBGEHNCAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5B88CF0", Offset = "0x5B880F0", VA = "0x185B88CF0")]
		private static void MKKEPEEHPEM(TypeManager.TypeInfo DOJAIALBHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5B89AA0", Offset = "0x5B88EA0", VA = "0x185B89AA0")]
		private unsafe static int OCADNCHJNPN(Unity.Entities.Archetype*[] FAHCHCPPFOI, NativeArray<EntityRemapUtility.EntityRemapInfo> HCJKODLJNNK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5B8A2E0", Offset = "0x5B896E0", VA = "0x185B8A2E0")]
		private static int PMENGNDEBBE(int KCBELKOOOJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5B88C50", Offset = "0x5B88050", VA = "0x185B88C50")]
		private static ulong LKJIHJBHOKJ(int KCBELKOOOJG)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class NFDCKHAAEPM
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5B82F60", Offset = "0x5B82360", VA = "0x185B82F60")]
	private unsafe static Span<byte> KHMMIJHNHON(Unity.Entities.Chunk* MMMDCDCMKJM, int DABCFJJGEPB)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3203960", Offset = "0x3202D60", VA = "0x183203960")]
	public unsafe static Span<T> LOLDDJGJKEP<T>(Unity.Entities.Chunk* MMMDCDCMKJM, int DABCFJJGEPB)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3203AE0", Offset = "0x3202EE0", VA = "0x183203AE0")]
	public static Span<T> LOLDDJGJKEP<T>(this ref Unity.Entities.Chunk MMMDCDCMKJM, int DABCFJJGEPB)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5B82DC0", Offset = "0x5B821C0", VA = "0x185B82DC0")]
	public unsafe static Span<Entity> DLMDICPLOJJ(Unity.Entities.Chunk* MMMDCDCMKJM)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5B82B20", Offset = "0x5B81F20", VA = "0x185B82B20")]
	public unsafe static void BIEFCABEIDG(Unity.Entities.Chunk* MMMDCDCMKJM, int DABCFJJGEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B82E30", Offset = "0x5B82230", VA = "0x185B82E30")]
	public static Entity DMCICDAEJHB(this EntityQuery FDOFAODBNNC)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : AOMBDDGFEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5B8A620", Offset = "0x5B89A20", VA = "0x185B8A620", Slot = "4")]
		public sealed override void IPAAHMOMIKO()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
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
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
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

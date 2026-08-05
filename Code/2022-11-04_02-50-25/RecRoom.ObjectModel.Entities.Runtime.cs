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
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class DDGJHCEJPGC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5507530", Offset = "0x5506930", VA = "0x185507530")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> PFALDKOBAKO(this ref Unity.Entities.Archetype LKHIPKFNEGI)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MCEGMPBNJOA
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x550B500", Offset = "0x550A900", VA = "0x18550B500")]
	public static Span<int> FEJLANDNOMP(this EntityArchetype LKHIPKFNEGI)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KMAJMOFKBOM
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AAFPEBBBGPM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5506790", Offset = "0x5505B90", VA = "0x185506790")]
	public static bool COOCIDMCJJO(this Entity KCGBIDJFHLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PLCKNPIHMAM
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[BurstCompile]
	private struct NIODGPGALDF<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[ReadOnly]
		public NativeArray<Entity> CMKPAMKPOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[WriteOnly]
		public ComponentDataFromEntity<T> JLGPIDMNHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public T PKODKJLGOIN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x35BEAE0", Offset = "0x35BDEE0", VA = "0x1835BEAE0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[BurstCompile]
	private struct PHLEJCLKIPO<T> : IJobChunk where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[WriteOnly]
		public ArchetypeChunkComponentType<T> BCDKJBBONLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T PKODKJLGOIN;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27FAF20", Offset = "0x27FA320", VA = "0x1827FAF20")]
	public static void DABMJKGCJCF<T>(this EntityManager KLFKJJDHNIL, NativeArray<Entity> IHPLCMEEOEJ, T PKODKJLGOIN) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27FAFB0", Offset = "0x27FA3B0", VA = "0x1827FAFB0")]
	public static void EIDNLBNPFMI<T>(this EntityManager KLFKJJDHNIL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27FB660", Offset = "0x27FAA60", VA = "0x1827FB660")]
	public static void NKHDPEOJOCG<T>(this EntityManager KLFKJJDHNIL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x550B9C0", Offset = "0x550ADC0", VA = "0x18550B9C0")]
	public static JobHandle KMFCJPDLDDI(this EntityManager KLFKJJDHNIL, int IJKBMAIIDGK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct JMIACPJCDJO<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NDAGEDFDCDP : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::JMIACPJCDJO<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x68E040", Offset = "0x68D440", VA = "0x18068E040", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2D3F5D0", Offset = "0x2D3E9D0", VA = "0x182D3F5D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x141BFA0", Offset = "0x141B3A0", VA = "0x18141BFA0")]
		[DebuggerHidden]
		public NDAGEDFDCDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F3F0", Offset = "0x2D3E7F0", VA = "0x182D3F3F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F590", Offset = "0x2D3E990", VA = "0x182D3F590", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> EAEBEGBJLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream GHBMNGPKFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream AONLMJEJMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf ENLBFHGAFPD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int NHPHNALIONM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x66D010", Offset = "0x66C410", VA = "0x18066D010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2D26DB0", Offset = "0x2D261B0", VA = "0x182D26DB0")]
	private JMIACPJCDJO(byte[] BPMIJGKONLK, Action<Protobuf> EAEBEGBJLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E271E0", Offset = "0x1E265E0", VA = "0x181E271E0")]
	public static global::JMIACPJCDJO<Protobuf> GEGOECOOINK<Data>(ReadOnlySpan<byte> NBOKDDEOMCP, ReadOnlySpan<Data> FAFJGGGCDPH, Action<Protobuf> EAEBEGBJLKO)
	{
		return default(global::JMIACPJCDJO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2D26C20", Offset = "0x2D26020", VA = "0x182D26C20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2D26C60", Offset = "0x2D26060", VA = "0x182D26C60", Slot = "4")]
	[IteratorStateMachine(typeof(global::JMIACPJCDJO<>.NDAGEDFDCDP))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2D26D60", Offset = "0x2D26160", VA = "0x182D26D60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OCBEJIABIEA<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] BPMIJGKONLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf ENLBFHGAFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream GHBMNGPKFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream PDFBPKMOIFB;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x28CC4F0", Offset = "0x28CB8F0", VA = "0x1828CC4F0")]
	private OCBEJIABIEA(byte[] BPMIJGKONLK, in Protobuf ENLBFHGAFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E30220", Offset = "0x1E2F620", VA = "0x181E30220")]
	public static global::OCBEJIABIEA<Protobuf> GEGOECOOINK<T>(ReadOnlySpan<T> FAFJGGGCDPH)
	{
		return default(global::OCBEJIABIEA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x28CC4C0", Offset = "0x28CB8C0", VA = "0x1828CC4C0")]
	public void KCAHIPGLKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x28CC300", Offset = "0x28CB700", VA = "0x1828CC300")]
	public ByteString DKLIHNBDKFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x28CC390", Offset = "0x28CB790", VA = "0x1828CC390", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HIGLIIIBFKL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream GHBMNGPKFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream AONLMJEJMOJ;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5508BD0", Offset = "0x5507FD0", VA = "0x185508BD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LFJJNICLHPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] BPMIJGKONLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream GHBMNGPKFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream PDFBPKMOIFB;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x550B0C0", Offset = "0x550A4C0", VA = "0x18550B0C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IFMEHDPDMOA
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public static void BMGKBICOGBO(this EHNHFGEGKKP PDHCNHGCAHC, NativeArray<Entity> IHPLCMEEOEJ, [Optional][CallerFilePath] string OBCGOJKLBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public static void BMGKBICOGBO(this EHNHFGEGKKP PDHCNHGCAHC, string JODEBEIHAPC, NativeArray<Entity> IHPLCMEEOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public static void BMGKBICOGBO(this EHNHFGEGKKP PDHCNHGCAHC, string OBCGOJKLBAJ, NativeArray<Entity> IHPLCMEEOEJ, bool BIGIMFNMPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public static void OJLOOACCONM(this EHNHFGEGKKP PDHCNHGCAHC, NativeArray<Entity> IHPLCMEEOEJ, NativeArray<Entity> IKPELHJLNPD, [Optional][CallerFilePath] string OBCGOJKLBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public static void OJLOOACCONM(this EHNHFGEGKKP PDHCNHGCAHC, string OBCGOJKLBAJ, NativeArray<Entity> IHPLCMEEOEJ, NativeArray<Entity> IKPELHJLNPD, bool BIGIMFNMPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x21F26B0", Offset = "0x21F1AB0", VA = "0x1821F26B0")]
	public static void KBPFDALOAGB<T>(this EHNHFGEGKKP PDHCNHGCAHC, string JODEBEIHAPC, NativeArray<Entity> IHPLCMEEOEJ, NativeList<T> HANEMGLFJMM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x21F2740", Offset = "0x21F1B40", VA = "0x1821F2740")]
	public static void KBPFDALOAGB<T>(this EHNHFGEGKKP PDHCNHGCAHC, string JODEBEIHAPC, NativeArray<Entity> IHPLCMEEOEJ, NativeArray<T> HANEMGLFJMM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public static void KBPFDALOAGB<T>(this EHNHFGEGKKP PDHCNHGCAHC, string OBCGOJKLBAJ, NativeArray<Entity> IHPLCMEEOEJ, NativeArray<T> HANEMGLFJMM, bool BIGIMFNMPLJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x21F27B0", Offset = "0x21F1BB0", VA = "0x1821F27B0")]
	public static void OCLPHACNDMO<T>(this EHNHFGEGKKP PDHCNHGCAHC, NativeList<T> HANEMGLFJMM, [Optional][CallerFilePath] string OBCGOJKLBAJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x21F2780", Offset = "0x21F1B80", VA = "0x1821F2780")]
	public static void OCLPHACNDMO<T>(this EHNHFGEGKKP PDHCNHGCAHC, NativeArray<T> HANEMGLFJMM, [Optional][CallerFilePath] string OBCGOJKLBAJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public static void OCLPHACNDMO<T>(this EHNHFGEGKKP PDHCNHGCAHC, string OBCGOJKLBAJ, NativeArray<T> HANEMGLFJMM, bool BIGIMFNMPLJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public static void GDNALIOPBOP(this EHNHFGEGKKP PDHCNHGCAHC, EntityQuery KFGMFPAGHMA, [Optional][CallerFilePath] string OBCGOJKLBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public static void GDNALIOPBOP(this EHNHFGEGKKP PDHCNHGCAHC, string JODEBEIHAPC, EntityQuery KFGMFPAGHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public static void GDNALIOPBOP(this EHNHFGEGKKP PDHCNHGCAHC, string OBCGOJKLBAJ, EntityQuery KFGMFPAGHMA, bool BIGIMFNMPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x21F2680", Offset = "0x21F1A80", VA = "0x1821F2680")]
	public static void GCNNHHCKGJK<T, T2>(this EHNHFGEGKKP PDHCNHGCAHC, string JODEBEIHAPC, EntityQuery KFGMFPAGHMA) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	private static void GCNNHHCKGJK<T, T2>(this EHNHFGEGKKP PDHCNHGCAHC, string OBCGOJKLBAJ, EntityQuery KFGMFPAGHMA, bool BIGIMFNMPLJ) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JOFONMFINJP : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	PJOKDCEKIIH ABINDAPOFON
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PGDKJDMJHPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PAPAAFPBKAL(Entity KCGBIDJFHLF, object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HNFLHPHFEGO(Entity KCGBIDJFHLF, object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FMEIEIMPHLO(Entity KCGBIDJFHLF);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FMEIEIMPHLO(PJOKDCEKIIH IICPGPKAIEH);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> PBIBDPMGPMJ(Entity KCGBIDJFHLF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KDOFDPIGMHD(Entity KCGBIDJFHLF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IIDCNIPBHBO<TComponentData, TValue> : global::EBKMKJBCAGK<TValue>, IDisposable where TComponentData : struct, JOFONMFINJP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class NEPDBDBDDBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> BEOMDPHLMGK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int MHDOGPFGFFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x141C1C0", Offset = "0x141B5C0", VA = "0x18141C1C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2D508B0", Offset = "0x2D4FCB0", VA = "0x182D508B0")]
		public bool HJHCOFBLCPE(out TValue PKODKJLGOIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2D50780", Offset = "0x2D4FB80", VA = "0x182D50780")]
		public void EIPAABBBFMM(object PFJMMABJIDH, TValue PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2D50830", Offset = "0x2D4FC30", VA = "0x182D50830")]
		public bool GMLJNDAKNDK(object PFJMMABJIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2D50970", Offset = "0x2D4FD70", VA = "0x182D50970")]
		public int LPHHEGFFIAL(object PFJMMABJIDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2D50A20", Offset = "0x2D4FE20", VA = "0x182D50A20")]
		public NEPDBDBDDBC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<NEPDBDBDDBC> CCJADMFACJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::PHGCLLNIMJB<PJOKDCEKIIH, NEPDBDBDDBC> IHDGLNDGMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager KLFKJJDHNIL;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1420690", Offset = "0x141FA90", VA = "0x181420690")]
	public IIDCNIPBHBO(EntityManager KLFKJJDHNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1420570", Offset = "0x141F970", VA = "0x181420570", Slot = "4")]
	public void PAPAAFPBKAL(Entity KCGBIDJFHLF, object PFJMMABJIDH, TValue PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1420340", Offset = "0x141F740", VA = "0x181420340", Slot = "5")]
	public bool HNFLHPHFEGO(Entity KCGBIDJFHLF, object PFJMMABJIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1420270", Offset = "0x141F670", VA = "0x181420270", Slot = "6")]
	public bool HJHCOFBLCPE(Entity KCGBIDJFHLF, out TValue PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x14201D0", Offset = "0x141F5D0", VA = "0x1814201D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x14201F0", Offset = "0x141F5F0", VA = "0x1814201F0")]
	private void FNLHODKDIFN(NEPDBDBDDBC BGJABHBGHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1420070", Offset = "0x141F470", VA = "0x181420070")]
	private bool ABIMCCMFFEP(Entity KCGBIDJFHLF, out PJOKDCEKIIH IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1420140", Offset = "0x141F540", VA = "0x181420140")]
	private void DGBCEJBCIHJ(Entity KCGBIDJFHLF, PJOKDCEKIIH IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1420120", Offset = "0x141F520", VA = "0x181420120")]
	private bool CLIGGHOEJAO(PJOKDCEKIIH IICPGPKAIEH, out NEPDBDBDDBC BGJABHBGHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x14204B0", Offset = "0x141F8B0", VA = "0x1814204B0")]
	private NEPDBDBDDBC LKBKIHJJKLB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EBKMKJBCAGK<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAPAAFPBKAL(Entity KCGBIDJFHLF, object PFJMMABJIDH, TValue PKODKJLGOIN);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HNFLHPHFEGO(Entity KCGBIDJFHLF, object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HJHCOFBLCPE(Entity KCGBIDJFHLF, out TValue PKODKJLGOIN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct PJOKDCEKIIH : global::EFNHAFHOKBP<PJOKDCEKIIH>, JHCFGCJIHGF, IEquatable<PJOKDCEKIIH>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly PJOKDCEKIIH KCHJKIMPEDI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int JPEBDLEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x71EE20", Offset = "0x71E220", VA = "0x18071EE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x71ED90", Offset = "0x71E190", VA = "0x18071ED90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int JHIGGPANBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB60", Offset = "0x8AAF60", VA = "0x1808ABB60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xEBF6B0", Offset = "0xEBEAB0", VA = "0x180EBF6B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x550B920", Offset = "0x550AD20", VA = "0x18550B920", Slot = "8")]
	public bool Equals(PJOKDCEKIIH BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x550B970", Offset = "0x550AD70", VA = "0x18550B970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PNLCFHKCGAO<T> : PGDKJDMJHPC, IDisposable where T : struct, JOFONMFINJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> CCJADMFACJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::PHGCLLNIMJB<PJOKDCEKIIH, HashSet<object>> IHDGLNDGMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager KLFKJJDHNIL;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x41F55D0", Offset = "0x41F49D0", VA = "0x1841F55D0")]
	public PNLCFHKCGAO(EntityManager KLFKJJDHNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x41F4B50", Offset = "0x41F3F50", VA = "0x1841F4B50", Slot = "4")]
	public bool PAPAAFPBKAL(Entity KCGBIDJFHLF, object PFJMMABJIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x41F4240", Offset = "0x41F3640", VA = "0x1841F4240", Slot = "5")]
	public bool HNFLHPHFEGO(Entity KCGBIDJFHLF, object PFJMMABJIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2C280A0", Offset = "0x2C274A0", VA = "0x182C280A0", Slot = "6")]
	public bool FMEIEIMPHLO(Entity KCGBIDJFHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x41F3AB0", Offset = "0x41F2EB0", VA = "0x1841F3AB0", Slot = "7")]
	public bool FMEIEIMPHLO(PJOKDCEKIIH IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x41F51B0", Offset = "0x41F45B0", VA = "0x1841F51B0", Slot = "8")]
	public IEnumerable<object> PBIBDPMGPMJ(Entity KCGBIDJFHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x41F5110", Offset = "0x41F4510", VA = "0x1841F5110", Slot = "11")]
	public IEnumerable<object> PBIBDPMGPMJ(PJOKDCEKIIH IICPGPKAIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x41F4510", Offset = "0x41F3910", VA = "0x1841F4510", Slot = "9")]
	public bool KDOFDPIGMHD(Entity KCGBIDJFHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x41F3910", Offset = "0x41F2D10", VA = "0x1841F3910", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x41F3DE0", Offset = "0x41F31E0", VA = "0x1841F3DE0")]
	private void FNLHODKDIFN(HashSet<object> BGJABHBGHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x41F31D0", Offset = "0x41F25D0", VA = "0x1841F31D0")]
	private bool ABIMCCMFFEP(Entity KCGBIDJFHLF, out PJOKDCEKIIH IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x41F3310", Offset = "0x41F2710", VA = "0x1841F3310")]
	private bool AMAOGBBDCPB(Entity KCGBIDJFHLF, out PJOKDCEKIIH IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2C28570", Offset = "0x2C27970", VA = "0x182C28570")]
	private void OFBCHCPIEOD(Entity KCGBIDJFHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x41F36D0", Offset = "0x41F2AD0", VA = "0x1841F36D0")]
	private void DGBCEJBCIHJ(Entity KCGBIDJFHLF, PJOKDCEKIIH IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x41F44B0", Offset = "0x41F38B0", VA = "0x1841F44B0")]
	private bool IOCBBJELFMC(PJOKDCEKIIH IICPGPKAIEH, out HashSet<object> BGJABHBGHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x41F48D0", Offset = "0x41F3CD0", VA = "0x1841F48D0")]
	private HashSet<object> LKBKIHJJKLB()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DOFOBHDNFJN : global::MBPLKPBHPJE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5507680", Offset = "0x5506A80", VA = "0x185507680", Slot = "4")]
	public float AGBOLLJCJEP(float3 PKODKJLGOIN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HBEAMBLNMAJ : global::MBPLKPBHPJE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5508690", Offset = "0x5507A90", VA = "0x185508690", Slot = "4")]
	public float AGBOLLJCJEP(float3 PKODKJLGOIN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct DCKKIBGAMBE : global::MBPLKPBHPJE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5507510", Offset = "0x5506910", VA = "0x185507510", Slot = "4")]
	public float AGBOLLJCJEP(float3 PKODKJLGOIN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MGFGDJFCMKG : global::MBPLKPBHPJE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x11ADC20", Offset = "0x11AD020", VA = "0x1811ADC20", Slot = "4")]
	public int AGBOLLJCJEP(int3 PKODKJLGOIN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NGHOONOLDOO : global::MBPLKPBHPJE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1630C00", Offset = "0x1630000", VA = "0x181630C00", Slot = "4")]
	public int AGBOLLJCJEP(int3 PKODKJLGOIN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct EOALBAMEFDI : global::MBPLKPBHPJE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x55085F0", Offset = "0x55079F0", VA = "0x1855085F0", Slot = "4")]
	public int AGBOLLJCJEP(int3 PKODKJLGOIN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class GGGNJEOGMFL : BFFBEGLONBC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type KIPNHOEOGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x68D130", Offset = "0x68C530", VA = "0x18068D130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xF6D9F0", Offset = "0xF6CDF0", VA = "0x180F6D9F0")]
	public GGGNJEOGMFL(Type NELFDLPEFHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DKKDIDPNENE : GGGNJEOGMFL
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xF6D9F0", Offset = "0xF6CDF0", VA = "0x180F6D9F0")]
	public DKKDIDPNENE(Type NELFDLPEFHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NEEFIPMLBEM : GGGNJEOGMFL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type EGKOMBJDJJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68D140", Offset = "0x68C540", VA = "0x18068D140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x550B620", Offset = "0x550AA20", VA = "0x18550B620")]
	public NEEFIPMLBEM(Type KCNBAFINFMK, Type NELFDLPEFHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BLFPDGNAKFF : GGGNJEOGMFL
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xF6D9F0", Offset = "0xF6CDF0", VA = "0x180F6D9F0")]
	public BLFPDGNAKFF(Type NELFDLPEFHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NEKKAFLHHJJ : BFFBEGLONBC
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public NEKKAFLHHJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FICPFKAKBGH : BFFBEGLONBC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public OFJLJDAKPIJ GCAODEDEONI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x66D040", Offset = "0x66C440", VA = "0x18066D040")]
		[CompilerGenerated]
		get
		{
			return default(OFJLJDAKPIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xF6D7F0", Offset = "0xF6CBF0", VA = "0x180F6D7F0")]
	public FICPFKAKBGH(OFJLJDAKPIJ GHPHIAMLFNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class NPLLDKEDKFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DOGKLJKKAGC ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager KLFKJJDHNIL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DOGKLJKKAGC KHGEGLGEBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x550B7B0", Offset = "0x550ABB0", VA = "0x18550B7B0")]
	public NPLLDKEDKFD(DOGKLJKKAGC ICDEHOIBFMN, EntityManager KLFKJJDHNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x29FE520", Offset = "0x29FD920", VA = "0x1829FE520")]
	public bool BODCMPIJGAK<T>(Entity KCGBIDJFHLF) where T : struct, LPACCGKNOFB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x29FE560", Offset = "0x29FD960", VA = "0x1829FE560")]
	public bool DENOLCACDHJ<T>(Entity KCGBIDJFHLF, out T PKODKJLGOIN) where T : struct, LPACCGKNOFB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x29FE5F0", Offset = "0x29FD9F0", VA = "0x1829FE5F0")]
	public T GDLCBGKKNMI<T>(Entity KCGBIDJFHLF) where T : struct, LPACCGKNOFB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x29FFFD0", Offset = "0x29FF3D0", VA = "0x1829FFFD0")]
	private ComponentType NDFDMGPNNPM<T>() where T : struct, LPACCGKNOFB
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x550B6E0", Offset = "0x550AAE0", VA = "0x18550B6E0")]
	private ComponentType NDFDMGPNNPM(Type NLAFPPIOFPG)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class DEMAFNKHPIE
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	protected DEMAFNKHPIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class DHHPCONPPDN<View, Data> : CHDKGPPIPOE where View : struct, LPACCGKNOFB where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType FIJGEJMKNKM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type DLAJJKNDCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x36D5BB0", Offset = "0x36D4FB0", VA = "0x1836D5BB0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type PBFBDKHJBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x36D4280", Offset = "0x36D3680", VA = "0x1836D4280", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int CLFLIJFMADE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x36D3970", Offset = "0x36D2D70", VA = "0x1836D3970", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x36D5DF0", Offset = "0x36D51F0", VA = "0x1836D5DF0")]
	public Data LKPJCGEPMBD(Entity KCGBIDJFHLF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x36D5E60", Offset = "0x36D5260", VA = "0x1836D5E60")]
	public Data OIPIBBABBFB(Entity KCGBIDJFHLF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View CKPEEOBNOPI(Entity KCGBIDJFHLF);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DEE0", Offset = "0x3A4D2E0", VA = "0x183A4DEE0", Slot = "15")]
	protected internal override T CKPEEOBNOPI<T>(Entity KCGBIDJFHLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x11290E0", Offset = "0x11284E0", VA = "0x1811290E0")]
	protected DHHPCONPPDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class CHDKGPPIPOE : MDNFODCBPDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic IINKMELIPAL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager CPBCICNIGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x82EA50", Offset = "0x82DE50", VA = "0x18082EA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type DLAJJKNDCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type PBFBDKHJBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int CLFLIJFMADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type ECMMAMIIIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x78B800", Offset = "0x78AC00", VA = "0x18078B800", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int LHBNKCACNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5506EC0", Offset = "0x55062C0", VA = "0x185506EC0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private HAKAHGDBIOD[] DBFJGNODCLI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x78B730", Offset = "0x78AB30", VA = "0x18078B730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual HAKAHGDBIOD[] ONGMFGHDJHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5506F30", Offset = "0x5506330", VA = "0x185506F30", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NKGOAPMELMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5506D40", Offset = "0x5506140", VA = "0x185506D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5506FF0", Offset = "0x55063F0", VA = "0x185506FF0")]
	public void PAICICMJOCE(EntityManager KLFKJJDHNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500")]
	protected MDNFODCBPDK KDDMNGBGMAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T CKPEEOBNOPI<T>(Entity KCGBIDJFHLF) where T : struct, LPACCGKNOFB;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5506E00", Offset = "0x5506200", VA = "0x185506E00", Slot = "8")]
	public (uint, uint) LDLBJOIAKDL(Entity KCGBIDJFHLF)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5506D70", Offset = "0x5506170", VA = "0x185506D70", Slot = "9")]
	public bool GIHPAKJHIHP(Entity KCGBIDJFHLF, (uint order, uint change) CELCPLLAAGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	protected CHDKGPPIPOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class FDIDMKOKMFC<Data> : BLKKLCOOGHJ where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data MGJBOLMPFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x24DD390", Offset = "0x24DC790", VA = "0x1824DD390", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2377A50", Offset = "0x2376E50", VA = "0x182377A50", Slot = "8")]
	protected virtual bool EIOANJMFCHN(ReadOnlySpan<Data> FAFJGGGCDPH, DDAIMAPAILI ANOCPAKAOKI, out ReadOnlySpan<byte> NBOKDDEOMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "9")]
	protected virtual bool CAJOMCEOAEA(int CELCPLLAAGH, Span<Data> FAFJGGGCDPH, in ReadOnlySpan<byte> NBOKDDEOMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x24DD3C0", Offset = "0x24DC7C0", VA = "0x1824DD3C0", Slot = "5")]
	internal sealed override bool EIOANJMFCHN(ref Unity.Entities.Chunk LDKMHEJBNPK, int BKLGGKGOFGE, DDAIMAPAILI ANOCPAKAOKI, out ReadOnlySpan<byte> NBOKDDEOMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x24DCC40", Offset = "0x24DC040", VA = "0x1824DCC40", Slot = "6")]
	internal sealed override bool CAJOMCEOAEA(int CELCPLLAAGH, ref Unity.Entities.Chunk LDKMHEJBNPK, int BKLGGKGOFGE, in ReadOnlySpan<byte> NBOKDDEOMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B59DA0", Offset = "0x3B591A0", VA = "0x183B59DA0")]
	protected global::OCBEJIABIEA<Protobuf> ODKCKGGKFMB<Protobuf>(ReadOnlySpan<Data> FAFJGGGCDPH) where Protobuf : IMessage, new()
	{
		return default(global::OCBEJIABIEA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3B59D10", Offset = "0x3B59110", VA = "0x183B59D10")]
	protected global::JMIACPJCDJO<Protobuf> OBGJCNOODEK<Protobuf>(ReadOnlySpan<byte> NBOKDDEOMCP, ReadOnlySpan<Data> FAFJGGGCDPH, Action<Protobuf> EAEBEGBJLKO) where Protobuf : IMessage, new()
	{
		return default(global::JMIACPJCDJO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x11290E0", Offset = "0x11284E0", VA = "0x1811290E0")]
	protected FDIDMKOKMFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class BLKKLCOOGHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int JHIGGPANBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5506AA0", Offset = "0x5505EA0", VA = "0x185506AA0", Slot = "5")]
	internal virtual bool EIOANJMFCHN(ref Unity.Entities.Chunk LDKMHEJBNPK, int BKLGGKGOFGE, DDAIMAPAILI ANOCPAKAOKI, out ReadOnlySpan<byte> NBOKDDEOMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "6")]
	internal virtual bool CAJOMCEOAEA(int CELCPLLAAGH, ref Unity.Entities.Chunk LDKMHEJBNPK, int BKLGGKGOFGE, in ReadOnlySpan<byte> NBOKDDEOMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	protected BLKKLCOOGHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface MBPLKPBHPJE<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo AGBOLLJCJEP(TFrom PKODKJLGOIN);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FHIPFCBDPGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAOMCOCLHAM(T PKODKJLGOIN);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct CJGCFLIHJNL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::MBPLKPBHPJE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> FLAIIKFDCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> FGCJFBBKLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap PADKGNIPPLI;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct MPIKKHFOPKP<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::MBPLKPBHPJE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> EAHKFHHJBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> FGCJFBBKLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap PADKGNIPPLI;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk LDKMHEJBNPK, int IPJCONFGCLM, int MFKFPEDJCJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct ENCLPIJMDHE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OLJBLBBNOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> FLAIIKFDCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> FGCJFBBKLFH;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x40B7B20", Offset = "0x40B6F20", VA = "0x1840B7B20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct KANJGIABDGN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OLJBLBBNOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> FLAIIKFDCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> BOIPNIFIKPC;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct BJFCNLMGHIN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::MBPLKPBHPJE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> BOLPLMPKMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> FGCJFBBKLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap PADKGNIPPLI;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct PIMEHFMGAFL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NELFDLPEFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> CMKPAMKPOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> GFBAHPDNAPA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct MEHIIODACAK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NELFDLPEFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> CMKPAMKPOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> GFBAHPDNAPA;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x306E5B0", Offset = "0x306D9B0", VA = "0x18306E5B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct HHJJDHNDJLH<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> FLAIIKFDCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> BOIPNIFIKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, KMBCDIKKHFF> FIIMOOOHHPE;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F840", Offset = "0x2D9EC40", VA = "0x182D9F840", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct HJDBNEBGAJG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::MBPLKPBHPJE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> FLAIIKFDCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> BOIPNIFIKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, KMBCDIKKHFF> FIIMOOOHHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap PADKGNIPPLI;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct NGJNPMDDIGE<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::FHIPFCBDPGC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> FLAIIKFDCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> BOIPNIFIKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate PADKGNIPPLI;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct ALDDEOCIANO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public EEFBLJMPCLJ NELFDLPEFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> CMKPAMKPOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> PJLHDLKHOJD;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x55067C0", Offset = "0x5505BC0", VA = "0x1855067C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct BOAOFCOOKAG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public EEFBLJMPCLJ NELFDLPEFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> CMKPAMKPOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> PJLHDLKHOJD;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5506AC0", Offset = "0x5505EC0", VA = "0x185506AC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LCJLLNDLFDP
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class PIPBDHMLLHI
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x27F9CA0", Offset = "0x27F90A0", VA = "0x1827F9CA0")]
	public static bool OKGNJIOACMN<T>(this NativeArray<Entity> CMKPAMKPOPL, EntityManager KLFKJJDHNIL, Allocator NHNCCHNPCJI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class HBIDKMHPFDN
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class OAKMKAEGPKO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		public OAKMKAEGPKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class HCKPOGPOBAE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public HCKPOGPOBAE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> CCCIGLADNEH;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x55086A0", Offset = "0x5507AA0", VA = "0x1855086A0")]
	public HBIDKMHPFDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class OLEOEBLGIIM
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NMLIJAAFLML
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct AGPBHKODOPO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct LFPNENJBEEC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal AGPBHKODOPO<TFrom> BLENCGKHIJI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator NHNCCHNPCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> NOBDDMHFHPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct EMPDCPMLGNJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct JJMAEMLCKIA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal EMPDCPMLGNJ<TFrom> BLENCGKHIJI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator NHNCCHNPCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> NOBDDMHFHPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct BDKHKPCLKPP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct AMFADOCMMEN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal BDKHKPCLKPP<TFrom> BLENCGKHIJI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator NHNCCHNPCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal global::LJNKEFMLNCC<TFrom> NOBDDMHFHPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct JIBHOBJEOEI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct IDFNGGMIMJH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal JIBHOBJEOEI<TFrom> BLENCGKHIJI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator NHNCCHNPCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal global::CBNGKCNANOL<TFrom> NOBDDMHFHPJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class ADGOFPDOLFH
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class PGHBICPLMPP
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x27F99F0", Offset = "0x27F8DF0", VA = "0x1827F99F0")]
	public static NativeList<T> KCNJIPHEDNH<T>(this NativeArray<T> COMFNEOABDK, Allocator NHNCCHNPCJI = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class NNPPBLMCINK
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x29FE1F0", Offset = "0x29FD5F0", VA = "0x1829FE1F0")]
	public static NativeArray<T> LCKMFJJHOEI<T>(this NativeList<Entity> COMFNEOABDK, EntityManager KLFKJJDHNIL, Allocator NHNCCHNPCJI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x29FDFF0", Offset = "0x29FD3F0", VA = "0x1829FDFF0")]
	public static NativeArray<T> LCKMFJJHOEI<T>(this NativeArray<Entity> COMFNEOABDK, EntityManager KLFKJJDHNIL, Allocator NHNCCHNPCJI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class NBDMDEJEHIG
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct GKHLOFEFKNL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct AJLGJIDLJDB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public GKHLOFEFKNL<TFrom> NOBDDMHFHPJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator NHNCCHNPCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> FLAIIKFDCGL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct MHPDNNIIMJF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct BAOOLLKPJIC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public MHPDNNIIMJF<TFrom> NOBDDMHFHPJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator NHNCCHNPCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public global::LJNKEFMLNCC<TFrom> FLAIIKFDCGL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct HLOEHHPBLAL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct CMIOPFIKJGA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public HLOEHHPBLAL<TFrom> NOBDDMHFHPJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator NHNCCHNPCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public global::CBNGKCNANOL<TFrom> FLAIIKFDCGL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class GBEIENFMCCJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class HAGIGDLAFLC
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct CPEMLDBIPME<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator NHNCCHNPCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> FLAIIKFDCGL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct KAECLNDEKEL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator NHNCCHNPCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> FLAIIKFDCGL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct NNHODJBMJDI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator NHNCCHNPCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public global::LJNKEFMLNCC<T> FLAIIKFDCGL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct BLOOPGBIDNK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator NHNCCHNPCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public global::CBNGKCNANOL<T> FLAIIKFDCGL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class KFBLIDGKFHL
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class FNAMGNBENBN
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x27D1D60", Offset = "0x27D1160", VA = "0x1827D1D60")]
	public static NativeList<Entity> MEBKIOMAPJD<T>(this NativeArray<Entity> CMKPAMKPOPL, EntityManager KLFKJJDHNIL, Allocator NHNCCHNPCJI = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class IKOPJLGOOOH
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface FCCLHKCFJFG
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JKOKGMKCFLM
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class JHBABENCECD
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class AOPBENLKGJA
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5506850", Offset = "0x5505C50", VA = "0x185506850")]
	public static bool KBNFLJHOLNF(Type NLAFPPIOFPG, Type EPGHHOOIHEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class ACNOEDAIEFL<Attribute, BaseClass> : global::DIMJHFPGOFI<BaseClass>, CHOEKCDLPMC where Attribute : GGGNJEOGMFL
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly EHNHFGEGKKP PDHCNHGCAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string JODEBEIHAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> JONCBILJAJF;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2C93F30", Offset = "0x2C93330", VA = "0x182C93F30")]
	public ACNOEDAIEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2C93DE0", Offset = "0x2C931E0", VA = "0x182C93DE0", Slot = "4")]
	public bool OOGLABKJNAC(int IJKBMAIIDGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2C93A90", Offset = "0x2C92E90", VA = "0x182C93A90", Slot = "5")]
	public global::OLKIDMOIAPH<BaseClass> MDCODOHIHJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2C93990", Offset = "0x2C92D90", VA = "0x182C93990", Slot = "7")]
	protected virtual bool KBNFLJHOLNF(Type NLAFPPIOFPG, int LMEELFBGDNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2C93E40", Offset = "0x2C93240", VA = "0x182C93E40", Slot = "8")]
	protected virtual int PIBKJLEHEKO(Type NLAFPPIOFPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C93900", Offset = "0x2C92D00", VA = "0x182C93900")]
	public void AMKPAJEBOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2C93D40", Offset = "0x2C93140", VA = "0x182C93D40", Slot = "6")]
	public void MGGHGLFMIKB(Type NLAFPPIOFPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class OLKIDMOIAPH<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> PCGMHBJDNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> GPKHLFPMKAJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> FEDKGCPKBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4340A10", Offset = "0x433FE10", VA = "0x184340A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4340D10", Offset = "0x4340110", VA = "0x184340D10")]
	public OLKIDMOIAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4340EA0", Offset = "0x43402A0", VA = "0x184340EA0")]
	public OLKIDMOIAPH(int OIKPPNLJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4340990", Offset = "0x433FD90", VA = "0x184340990")]
	internal void EIPAABBBFMM(int IJKBMAIIDGK, BaseClass GLGOPOLOJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1E32A20", Offset = "0x1E31E20", VA = "0x181E32A20")]
	public bool LDBECGAPKFA<T>(out BaseClass PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4340C40", Offset = "0x4340040", VA = "0x184340C40")]
	public bool LDBECGAPKFA(Type DHGPLCEACKF, out BaseClass PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2766370", Offset = "0x2765770", VA = "0x182766370")]
	public bool FAEFFLOEAMF(int IJKBMAIIDGK, out BaseClass PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1E33730", Offset = "0x1E32B30", VA = "0x181E33730")]
	public T LHEFEAMILAN<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4340CE0", Offset = "0x43400E0", VA = "0x184340CE0")]
	public BaseClass LHEFEAMILAN(Type OGMFKBICEEM)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class BDDDKCOMMPI : global::ACNOEDAIEFL<DKKDIDPNENE, DEMAFNKHPIE>
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5506A30", Offset = "0x5505E30", VA = "0x185506A30")]
	public BDDDKCOMMPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class HCJIHBKHKBL : global::ACNOEDAIEFL<NEEFIPMLBEM, CHDKGPPIPOE>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55088B0", Offset = "0x5507CB0", VA = "0x1855088B0")]
	public HCJIHBKHKBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class NEFANBBPIAD : global::ACNOEDAIEFL<BLFPDGNAKFF, BLKKLCOOGHJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x550B670", Offset = "0x550AA70", VA = "0x18550B670")]
	public NEFANBBPIAD()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[AFAPMPFKDID(JCDEPCAPNFC.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> LLKPCNGMKKA;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x882B80", Offset = "0x881F80", VA = "0x180882B80")]
		private ComponentSystemTypes(List<Type> LLKPCNGMKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5507110", Offset = "0x5506510", VA = "0x185507110")]
		public static void AMKPAJEBOOH(List<Type> LLKPCNGMKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x55071A0", Offset = "0x55065A0", VA = "0x1855071A0")]
		private void EBOFJDFFPBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5507440", Offset = "0x5506840", VA = "0x185507440")]
		private bool KBNFLJHOLNF(Type NLAFPPIOFPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x55073E0", Offset = "0x55067E0", VA = "0x1855073E0")]
		private void EEBGICBKBOM(Type NLAFPPIOFPG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class KDNDLNICKKO : HIEMLNGKCMK
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x550A2C0", Offset = "0x55096C0", VA = "0x18550A2C0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase LNDALPBDGIO();

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x550A270", Offset = "0x5509670", VA = "0x18550A270")]
	protected ComponentSystemBase BCFJNANJMLG(params ComponentSystemBase[] BAKIKEOBNEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2BB06C0", Offset = "0x2BAFAC0", VA = "0x182BB06C0")]
	protected ComponentSystemBase BCFJNANJMLG<T>(params ComponentSystemBase[] BAKIKEOBNEJ) where T : HIEMLNGKCMK, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0760", Offset = "0x2BAFB60", VA = "0x182BB0760")]
	protected ComponentSystemBase BLAGKCECDML<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0760", Offset = "0x2BAFB60", VA = "0x182BB0760")]
	protected ComponentSystemBase LKBJMLCJLHM<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	protected KDNDLNICKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface DIMJHFPGOFI<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOGLABKJNAC(int IJKBMAIIDGK);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::OLKIDMOIAPH<BaseClass> MDCODOHIHJO();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class HIEMLNGKCMK : KIJJOKEBALK
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5508920", Offset = "0x5507D20", VA = "0x185508920", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public HIEMLNGKCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class HPFCFNHKHFD : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5509A70", Offset = "0x5508E70", VA = "0x185509A70")]
	public EEFBLJMPCLJ EMOFNGGEBFH(int IJKBMAIIDGK, bool CNDIMEFFGEE = false)
	{
		return default(EEFBLJMPCLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5509B10", Offset = "0x5508F10", VA = "0x185509B10", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0")]
	protected HPFCFNHKHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class DJAAOLBJGHI : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0")]
	protected DJAAOLBJGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class OPEENOIKAJM : HPFCFNHKHFD
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x550B800", Offset = "0x550AC00", VA = "0x18550B800", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	protected void NMFHFCNCOGB(string PIEECBDBBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0")]
	protected OPEENOIKAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class CBCMGHHBEEH
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class KIJJOKEBALK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	protected KIJJOKEBALK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[AFAPMPFKDID(JCDEPCAPNFC.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x550BE10", Offset = "0x550B210", VA = "0x18550BE10")]
		public static ComponentSystemGroup[] BALAGHAIAHL(World ICDEHOIBFMN, DMDKEBIMNCI KHBAHGABGEN = DMDKEBIMNCI.Default, bool EDICDOKAACE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x550BAB0", Offset = "0x550AEB0", VA = "0x18550BAB0")]
		private static Type[] ACLAALCFFLK(DMDKEBIMNCI KHBAHGABGEN, bool EDICDOKAACE, ComponentSystemGroup[] NFGPFGACOBL, ComponentSystemGroup ODLHLDBJDIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x550C160", Offset = "0x550B560", VA = "0x18550C160")]
		private static ComponentSystemGroup[] DIIDFODECGM(World ICDEHOIBFMN, out ComponentSystemGroup ODLHLDBJDIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x550BEE0", Offset = "0x550B2E0", VA = "0x18550BEE0")]
		internal static bool CDJDCLLILLO(OFJLJDAKPIJ GHPHIAMLFNM, out IHDBFJONIEJ OPMEGMJIOOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x550CB20", Offset = "0x550BF20", VA = "0x18550CB20")]
		private static ComponentSystemGroup KPEJEOMODBK(Type NLAFPPIOFPG, World ICDEHOIBFMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x550C9F0", Offset = "0x550BDF0", VA = "0x18550C9F0")]
		private static ComponentSystemGroup[] KCAKMNDCHFG(Type[] LLKPCNGMKKA, World ICDEHOIBFMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x550C470", Offset = "0x550B870", VA = "0x18550C470")]
		internal static void GOJAHOBFMOK(World ICDEHOIBFMN, Type[] BIIDLNMANML, ComponentSystemGroup[] NFGPFGACOBL, ComponentSystemGroup ODLHLDBJDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x550C990", Offset = "0x550BD90", VA = "0x18550C990")]
		internal static bool IPIDCEGCHEP(ComponentSystemBase PEOBFOOAMDB, ComponentSystemGroup[] NFGPFGACOBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x550CC00", Offset = "0x550C000", VA = "0x18550CC00")]
		private static void ONGDJODPJKB(ComponentSystemGroup[] NFGPFGACOBL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct PCEHAJOBEDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> LPMPFJBJFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> BAKIKEOBNEJ;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x71DA10", Offset = "0x71CE10", VA = "0x18071DA10")]
	public PCEHAJOBEDE(Dictionary<Type, List<Type>> LPMPFJBJFOO, HashSet<Type> BAKIKEOBNEJ)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[AFAPMPFKDID(JCDEPCAPNFC.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class LEGDHHIKBII : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
			[DebuggerHidden]
			public LEGDHHIKBII(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x550AFE0", Offset = "0x550A3E0", VA = "0x18550AFE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x550AD40", Offset = "0x550A140", VA = "0x18550AD40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x550B070", Offset = "0x550A470", VA = "0x18550B070")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x550AFA0", Offset = "0x550A3A0", VA = "0x18550AFA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x550AEF0", Offset = "0x550A2F0", VA = "0x18550AEF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x550AEF0", Offset = "0x550A2F0", VA = "0x18550AEF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct CIJIGOIGJNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type DKOALCDPJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private DMDKEBIMNCI KHBAHGABGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool BLKNDPDGAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool DOGBLJKDFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool EDICDOKAACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> GJHNEGDNJKP;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x550CCF0", Offset = "0x550C0F0", VA = "0x18550CCF0")]
		public static RRFilterWorldSystems GEGOECOOINK()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x550DBE0", Offset = "0x550CFE0", VA = "0x18550DBE0")]
		public RRFilterWorldSystems POMAOHGNNJA(DMDKEBIMNCI GHPHIAMLFNM)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x550CFF0", Offset = "0x550C3F0", VA = "0x18550CFF0")]
		public RRFilterWorldSystems GNHHCPILCBI(IEnumerable<Type> LLKPCNGMKKA)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x550D980", Offset = "0x550CD80", VA = "0x18550D980")]
		public RRFilterWorldSystems KAGKABIPBBE(bool OJEHBBBDBLB)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x550D030", Offset = "0x550C430", VA = "0x18550D030")]
		public RRFilterWorldSystems HAFBDDMHBJK(bool KBCMEGOGEKE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x550D7E0", Offset = "0x550CBE0", VA = "0x18550D7E0")]
		public PCEHAJOBEDE JABHLEPHMOI(Type[] OCAPLJKIFKB)
		{
			return default(PCEHAJOBEDE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x550DB50", Offset = "0x550CF50", VA = "0x18550DB50")]
		[IteratorStateMachine(typeof(LEGDHHIKBII))]
		internal IEnumerable<Type> LCKLJHCDDGM(IEnumerable<Type> LLKPCNGMKKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x550CD10", Offset = "0x550C110", VA = "0x18550CD10")]
		internal Dictionary<Type, List<Type>> GHFHMGEJPAK(IEnumerable<Type> LLKPCNGMKKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x550D870", Offset = "0x550CC70", VA = "0x18550D870")]
		private void JOFDDDOMFMN(Dictionary<Type, List<Type>> CJDMCMNNBID, Type NLAFPPIOFPG, Type NAFOELJNPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x550D990", Offset = "0x550CD90", VA = "0x18550D990")]
		internal HashSet<Type> KDCHGPHCDLJ(IEnumerable<Type> NFGPFGACOBL, Dictionary<Type, List<Type>> NACECODOGPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x550D1A0", Offset = "0x550C5A0", VA = "0x18550D1A0")]
		internal bool IIIGOELGGPI(Type NLAFPPIOFPG, DMDKEBIMNCI KHBAHGABGEN, bool EDICDOKAACE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x550D040", Offset = "0x550C440", VA = "0x18550D040")]
		[CompilerGenerated]
		internal static void HMIDKFJLDDL(Type NLAFPPIOFPG, ref CIJIGOIGJNF P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class KHFKBBAKBLF
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool NHMEHEIGDLL;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x550A4C0", Offset = "0x55098C0", VA = "0x18550A4C0")]
	public static void PAICICMJOCE(bool LGPEEBCPBMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x550A300", Offset = "0x5509700", VA = "0x18550A300")]
	private static void FGJDFCOFICI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class PEBBIFKJCMO
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x550B830", Offset = "0x550AC30", VA = "0x18550B830")]
	public static ulong CANFCKGGMMD(Type NLAFPPIOFPG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x550B860", Offset = "0x550AC60", VA = "0x18550B860")]
	public static ulong CANFCKGGMMD(string LKHKCGNGNGF)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[AFAPMPFKDID(JCDEPCAPNFC.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct EPNMMONPMNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong LHKAOFFPJFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong JHPIKIIMGOC;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xF6AF50", Offset = "0xF6A350", VA = "0x180F6AF50")]
			public EPNMMONPMNK(ulong INDLGNBMDCG, ulong OPMOMGKMGFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5508600", Offset = "0x5507A00", VA = "0x185508600", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> CLPBCHGKDAE;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static EPNMMONPMNK[] FIMHBEKNEPB;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool NHMEHEIGDLL;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x550E2E0", Offset = "0x550D6E0", VA = "0x18550E2E0")]
		public static ulong GMICCBODADF(int IJKBMAIIDGK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x550E230", Offset = "0x550D630", VA = "0x18550E230")]
		public static int GHKCNJIKINL(ulong OPMOMGKMGFI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x550E4C0", Offset = "0x550D8C0", VA = "0x18550E4C0")]
		public static void PAICICMJOCE(bool LGPEEBCPBMM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x550E6B0", Offset = "0x550DAB0", VA = "0x18550E6B0")]
		private static void PNLOLBPHEKM(int FEAIKHFKGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x550DF10", Offset = "0x550D310", VA = "0x18550DF10")]
		private static void FOOLGLKCBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x550DD30", Offset = "0x550D130", VA = "0x18550DD30")]
		private static EPNMMONPMNK DJNMJLMPJIA(Type NLAFPPIOFPG)
		{
			return default(EPNMMONPMNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x550DCC0", Offset = "0x550D0C0", VA = "0x18550DCC0")]
		private static ulong BDJBEKKEINK(Type NLAFPPIOFPG, ulong OPMOMGKMGFI)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x550E790", Offset = "0x550DB90", VA = "0x18550E790")]
		private static void PPHMCHNADFO(in EPNMMONPMNK DGJPJENEDPM, TypeManager.TypeInfo LBDGJNECAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x550DE10", Offset = "0x550D210", VA = "0x18550DE10")]
		private static void EIKFDGIMKII(EPNMMONPMNK LBDGJNECAPK, int IJKBMAIIDGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x550E3D0", Offset = "0x550D7D0", VA = "0x18550E3D0")]
		private static void KKPPHCJLINC(EPNMMONPMNK LBDGJNECAPK, int IJKBMAIIDGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x550E340", Offset = "0x550D740", VA = "0x18550E340")]
		private static EPNMMONPMNK HJLOAJLHNBK(int IJKBMAIIDGK)
		{
			return default(EPNMMONPMNK);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x550E4B0", Offset = "0x550D8B0", VA = "0x18550E4B0")]
		private static int OMCOGMFHGJP(int IJKBMAIIDGK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class HJKFIEKIIOL
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly HCJIHBKHKBL PMLHFBOOHNC;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly NEFANBBPIAD IEFMJFJOIKH;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly BDDDKCOMMPI HCLPJCFJEHA;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> OJIFOMDMAEM;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool NHMEHEIGDLL;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::DIMJHFPGOFI<CHDKGPPIPOE> CNGGHJPMNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5509330", Offset = "0x5508730", VA = "0x185509330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::DIMJHFPGOFI<BLKKLCOOGHJ> ADDMNOGEICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x55091F0", Offset = "0x55085F0", VA = "0x1855091F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::DIMJHFPGOFI<DEMAFNKHPIE> NELOLAGGGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x55092D0", Offset = "0x55086D0", VA = "0x1855092D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5509390", Offset = "0x5508790", VA = "0x185509390")]
	public static void PAICICMJOCE(bool LGPEEBCPBMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5509250", Offset = "0x5508650", VA = "0x185509250")]
	public static Type[] EDKCKBMAOGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class IHFELKILCHB
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> HPBMJIMGJLB;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool NHMEHEIGDLL;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5509BA0", Offset = "0x5508FA0", VA = "0x185509BA0")]
	public static int LDLBJOIAKDL(int IJKBMAIIDGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5509C40", Offset = "0x5509040", VA = "0x185509C40")]
	public static void PAICICMJOCE(bool LGPEEBCPBMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5509CE0", Offset = "0x55090E0", VA = "0x185509CE0")]
	private static void PGFNMABHNBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5509F60", Offset = "0x5509360", VA = "0x185509F60")]
	private static int PMMACEPODOG(Type NLAFPPIOFPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5509B20", Offset = "0x5508F20", VA = "0x185509B20")]
	private static void HLOEIBCGJID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class DOGKLJKKAGC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World ICDEHOIBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World HNOPBAGIJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NPLLDKEDKFD GLGOPOLOJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] NFGPFGACOBL;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World KHGEGLGEBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World JAFDKOADMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager CPBCICNIGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8D7660", Offset = "0x8D6A60", VA = "0x1808D7660")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public NPLLDKEDKFD KBCPAMGBEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::OLKIDMOIAPH<CHDKGPPIPOE> CNGGHJPMNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x705AE0", Offset = "0x704EE0", VA = "0x180705AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::OLKIDMOIAPH<BLKKLCOOGHJ> ADDMNOGEICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x674570", Offset = "0x673970", VA = "0x180674570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x674590", Offset = "0x673990", VA = "0x180674590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::OLKIDMOIAPH<DEMAFNKHPIE> NELOLAGGGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x674580", Offset = "0x673980", VA = "0x180674580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6745A0", Offset = "0x6739A0", VA = "0x1806745A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> GEFAJMMEOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8D76A0", Offset = "0x8D6AA0", VA = "0x1808D76A0")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] ECFLIHIJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5507F10", Offset = "0x5507310", VA = "0x185507F10")]
	public static DOGKLJKKAGC MKLDOIOOPOM(string JODEBEIHAPC, OFJLJDAKPIJ GHPHIAMLFNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x55080D0", Offset = "0x55074D0", VA = "0x1855080D0")]
	public DOGKLJKKAGC(string JODEBEIHAPC, OFJLJDAKPIJ GHPHIAMLFNM = OFJLJDAKPIJ.Simulation, DMDKEBIMNCI KHBAHGABGEN = DMDKEBIMNCI.Default, bool LGPEEBCPBMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5507910", Offset = "0x5506D10", VA = "0x185507910")]
	public ComponentSystemBase DOGNMBLFHED(Type NLAFPPIOFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x23CD710", Offset = "0x23CCB10", VA = "0x1823CD710")]
	public T DOGNMBLFHED<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5507AC0", Offset = "0x5506EC0", VA = "0x185507AC0")]
	public void IFKFBBJNIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5508070", Offset = "0x5507470", VA = "0x185508070")]
	public void OLNHNMEDKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5507B80", Offset = "0x5506F80", VA = "0x185507B80")]
	public void KMJMBCKBBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5507A00", Offset = "0x5506E00", VA = "0x185507A00")]
	public void HIFDNMPNCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5507A60", Offset = "0x5506E60", VA = "0x185507A60")]
	public void HNGIBMBPJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5507B20", Offset = "0x5506F20", VA = "0x185507B20")]
	public void JGDGDPMOPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x55079A0", Offset = "0x5506DA0", VA = "0x1855079A0")]
	public void HEFGOODOLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5507880", Offset = "0x5506C80", VA = "0x185507880")]
	public void DDFCCEBEILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5508010", Offset = "0x5507410", VA = "0x185508010")]
	public void NMOLCAIDLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5507EB0", Offset = "0x55072B0", VA = "0x185507EB0")]
	public void LPOBJBKCFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x55077A0", Offset = "0x5506BA0", VA = "0x1855077A0")]
	internal void CPEOCKGBJCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5507F90", Offset = "0x5507390", VA = "0x185507F90")]
	private bool NDFBHOMADCA(ComponentSystemGroup JALFPKPFAON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5507BE0", Offset = "0x5506FE0", VA = "0x185507BE0")]
	private void LNEFPKAHIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5507690", Offset = "0x5506A90", VA = "0x185507690")]
	private ComponentSystemGroup[] BALAGHAIAHL(DMDKEBIMNCI KHBAHGABGEN, bool EDICDOKAACE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5507930", Offset = "0x5506D30", VA = "0x185507930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum OFJLJDAKPIJ
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
public sealed class GEKHCHIJIDL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public DMDKEBIMNCI KFGGJEJNMNA;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum DMDKEBIMNCI
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
public interface IHDBFJONIEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type KHHNIJJCMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] ANGNAOEBGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class BENHMAMFPLA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool CJIFCLPLOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x68E020", Offset = "0x68D420", VA = "0x18068E020", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	protected BENHMAMFPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class KIJJKOCHGBB : BENHMAMFPLA
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public KIJJKOCHGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class MCCDCLBDPKF : BENHMAMFPLA
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public MCCDCLBDPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class EEOOCNPEGJD : BENHMAMFPLA
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public EEOOCNPEGJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class IMAGNLAEPGD : BENHMAMFPLA
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public IMAGNLAEPGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class KGOCGONGAKM : BENHMAMFPLA
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public KGOCGONGAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class MEGNHAFEFAA : BENHMAMFPLA
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public MEGNHAFEFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class FGGFGHNNJIF : BENHMAMFPLA
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public FGGFGHNNJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class KFJMOJFBOLO : BENHMAMFPLA
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public KFJMOJFBOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class KAFDGPOEHFA : BENHMAMFPLA
{
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public KAFDGPOEHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class AEGIDOOLGBC : CIBFPMKMJDI
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public AEGIDOOLGBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class DNHCEONGJON : CIBFPMKMJDI
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public DNHCEONGJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class CIDPOHDNPCF : CIBFPMKMJDI
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public CIDPOHDNPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class LPGEBAOCHLN : CIBFPMKMJDI
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public LPGEBAOCHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[KJKMMMHBKLF(BADKLKEFGCO.Application)]
public class CIBFPMKMJDI : BENHMAMFPLA
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool CJIFCLPLOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x55067B0", Offset = "0x5505BB0", VA = "0x1855067B0")]
	public CIBFPMKMJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class DKFCABINONO : BFFBEGLONBC
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0xF64AD0", Offset = "0xF63ED0", VA = "0x180F64AD0")]
	public DKFCABINONO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class MAOAFDLOCDD
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void CBOILNOEAOG<From, To>(From NOBDDMHFHPJ, ref To PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class DJPEHNDBCDH<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static CBOILNOEAOG<From, To> JEMEAAFMOCD;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public DJPEHNDBCDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x550B300", Offset = "0x550A700", VA = "0x18550B300")]
	static MAOAFDLOCDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C850", Offset = "0x2E4BC50", VA = "0x182E4C850")]
	public static void CDEBOFDMKNE<T>(CBOILNOEAOG<T, T> JFMAINCLGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C6A0", Offset = "0x2E4BAA0", VA = "0x182E4C6A0")]
	public static void CDEBOFDMKNE<From, To>(CBOILNOEAOG<From, To> JFMAINCLGAF, CBOILNOEAOG<To, From> AAJCKFMGDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C650", Offset = "0x2E4BA50", VA = "0x182E4C650")]
	public static void CDEBOFDMKNE<From, To>(CBOILNOEAOG<From, To> JEMEAAFMOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2E516F0", Offset = "0x2E50AF0", VA = "0x182E516F0")]
	public static CBOILNOEAOG<From, To> FPCNDFEDGID<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2E54F80", Offset = "0x2E54380", VA = "0x182E54F80")]
	public static void OPHMDAMJPLF<From, To>(From NOBDDMHFHPJ, ref To PLMCOCLAMMK, DDAIMAPAILI ANOCPAKAOKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class DDAIMAPAILI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> FOLGDNGLECP;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0xDA06B0", Offset = "0xD9FAB0", VA = "0x180DA06B0")]
	public DDAIMAPAILI(NativeArray<EntityRemapUtility.EntityRemapInfo> FOLGDNGLECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2C83D10", Offset = "0x2C83110", VA = "0x182C83D10")]
	public Entity IPEKGNOALBG(Entity EKGMIOGLPIC)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class CCJKPFIGOGI
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> MGBIAPKKLOE;

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5506B50", Offset = "0x5505F50", VA = "0x185506B50")]
	public static bool DGCNHGLMLPF(ulong GKJFFLLHHJJ, uint CELCPLLAAGH, out string JODEBEIHAPC)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[AFAPMPFKDID(JCDEPCAPNFC.Serialization, new string[] { "Timing", "Deprecated", "Types", "Archetypes" })]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct POEPCFDMHAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int JPEBDLEMFCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int JHIGGPANBBG;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x68E050", Offset = "0x68D450", VA = "0x18068E050")]
			public POEPCFDMHAC(int PGFOAHEHPOH, int CELCPLLAAGH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct HCHKBGCBCJD
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch OJJMKLKNPBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long CLNJAKCJEKA;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long PILFBGNAIBD
			{
				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x5508850", Offset = "0x5507C50", VA = "0x185508850")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long GGJNEHCEBAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x5508720", Offset = "0x5507B20", VA = "0x185508720")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x5508790", Offset = "0x5507B90", VA = "0x185508790")]
			public static HCHKBGCBCJD KIFBCELFNGG()
			{
				return default(HCHKBGCBCJD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct LBBHNFDNEFK : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct NDGPMIADPKA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* KFPBHKJIHCK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly IBNBGEBMAJL.MFAHIKEHIEO.MHENHKPKHOB AEBCBOINEKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly DDAIMAPAILI ANOCPAKAOKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::OLKIDMOIAPH<BLKKLCOOGHJ> PDNGJNGOJPF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int BKLGGKGOFGE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int IPJCONFGCLM;

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x550B5C0", Offset = "0x550A9C0", VA = "0x18550B5C0")]
				public unsafe NDGPMIADPKA(Unity.Entities.Archetype* KFPBHKJIHCK, IBNBGEBMAJL.MFAHIKEHIEO.MHENHKPKHOB AEBCBOINEKA, DDAIMAPAILI ANOCPAKAOKI, global::OLKIDMOIAPH<BLKKLCOOGHJ> PDNGJNGOJPF, int BKLGGKGOFGE, int IPJCONFGCLM = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x550B570", Offset = "0x550A970", VA = "0x18550B570")]
				public NDGPMIADPKA(in NDGPMIADPKA HANEMGLFJMM, int IPJCONFGCLM)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly NDGPMIADPKA[] FAFJGGGCDPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] ADPIBDOIKGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int AGNGMKFPJLC;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x550AC00", Offset = "0x550A000", VA = "0x18550AC00")]
			public LBBHNFDNEFK(NDGPMIADPKA[] FAFJGGGCDPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x550A8D0", Offset = "0x5509CD0", VA = "0x18550A8D0", Slot = "4")]
			public void Invoke(int PGFOAHEHPOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x550A520", Offset = "0x5509920", VA = "0x18550A520")]
			private void CIHAHIGPGLN(in NDGPMIADPKA HANEMGLFJMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x550A930", Offset = "0x5509D30", VA = "0x18550A930")]
			private static void KIMPDIHIHBC(in NDGPMIADPKA HANEMGLFJMM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class IOMDFNLGDBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public IBNBGEBMAJL asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::OLKIDMOIAPH<BLKKLCOOGHJ> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public IOMDFNLGDBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x550A200", Offset = "0x5509600", VA = "0x18550A200")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class GBOGFDOPMPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public IBNBGEBMAJL.MFAHIKEHIEO.MHENHKPKHOB srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public IOMDFNLGDBD CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public GBOGFDOPMPP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class LHLBAKHJFIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public GBOGFDOPMPP CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public LHLBAKHJFIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x550B1F0", Offset = "0x550A5F0", VA = "0x18550B1F0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static EHNHFGEGKKP GFAOMHEGENJ;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static EHNHFGEGKKP OJHPPDFJFGJ;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static EHNHFGEGKKP JJENFGPPBMA;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static EHNHFGEGKKP JADADCDKHEB;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool LNOOJFLOIMF;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static IBNBGEBMAJL.MFAHIKEHIEO.LOAKEJMOPPE KJCEGGHHCMI;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x550F010", Offset = "0x550E410", VA = "0x18550F010")]
		private unsafe static bool BDNPOMIALKO(Unity.Entities.Archetype* LKHIPKFNEGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5510AF0", Offset = "0x550FEF0", VA = "0x185510AF0")]
		internal unsafe static Unity.Entities.Archetype*[] KLGHABHIEPJ(ref Unity.Entities.EntityComponentStore CIPPJCIGMNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5510A30", Offset = "0x550FE30", VA = "0x185510A30")]
		public static void KKPPFGFCFDI(DOGKLJKKAGC ICDEHOIBFMN, out ByteString NBOKDDEOMCP, out NativeArray<EntityRemapUtility.EntityRemapInfo> DHHBKGMIPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5511830", Offset = "0x5510C30", VA = "0x185511830")]
		internal static void OIGNFLGCFDK(DOGKLJKKAGC ICDEHOIBFMN, IBNBGEBMAJL AIDGJJIKBKA, out NativeArray<EntityRemapUtility.EntityRemapInfo> DHHBKGMIPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5510DB0", Offset = "0x55101B0", VA = "0x185510DB0")]
		private unsafe static UnsafeHashMap<ulong, POEPCFDMHAC> LIMEPCAOBDL(Unity.Entities.Archetype*[] KEHAHHIGCIC)
		{
			return default(UnsafeHashMap<ulong, POEPCFDMHAC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5511F60", Offset = "0x5511360", VA = "0x185511F60")]
		private static void PJHNGLEIFFP(IBNBGEBMAJL AIDGJJIKBKA, UnsafeHashMap<ulong, POEPCFDMHAC> ILMPPPGAHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5510570", Offset = "0x550F970", VA = "0x185510570")]
		private unsafe static void JGEMEGPBLHB(IBNBGEBMAJL AIDGJJIKBKA, Unity.Entities.Archetype*[] KEHAHHIGCIC, UnsafeHashMap<ulong, POEPCFDMHAC> ILMPPPGAHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x550FAB0", Offset = "0x550EEB0", VA = "0x18550FAB0")]
		private unsafe static int EMEHEJNPJNB(Unity.Entities.Archetype*[] KEHAHHIGCIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5511410", Offset = "0x5510810", VA = "0x185511410")]
		private unsafe static void OEGNKCPJJKP(IBNBGEBMAJL AIDGJJIKBKA, Unity.Entities.Archetype*[] KEHAHHIGCIC, global::OLKIDMOIAPH<BLKKLCOOGHJ> PDNGJNGOJPF, NativeArray<EntityRemapUtility.EntityRemapInfo> DHHBKGMIPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x550FBC0", Offset = "0x550EFC0", VA = "0x18550FBC0")]
		private static NativeArray<int> GOCNAEKMCNH(IBNBGEBMAJL AIDGJJIKBKA)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5512110", Offset = "0x5511510", VA = "0x185512110")]
		private static Memory<EntityArchetype> PKAHPCEHPOO(IBNBGEBMAJL AIDGJJIKBKA, NativeArray<int> LLKPCNGMKKA, EntityManager KLFKJJDHNIL, out int LAIKJNEAOOP, out int LCCECHMNIBI)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x55110C0", Offset = "0x55104C0", VA = "0x1855110C0")]
		private unsafe static void MGFFBGOEHGG(Unity.Entities.Chunk* EMNIHNKDOMG, ReadOnlySpan<byte> NBOKDDEOMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x550FE30", Offset = "0x550F230", VA = "0x18550FE30")]
		private static void INDEKIPHCHF(IBNBGEBMAJL AIDGJJIKBKA, NativeArray<int> LLKPCNGMKKA, Span<EntityArchetype> KEHAHHIGCIC, EntityManager KLFKJJDHNIL, global::OLKIDMOIAPH<BLKKLCOOGHJ> PDNGJNGOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5511040", Offset = "0x5510440", VA = "0x185511040")]
		private unsafe static void LPJEGKDCCOI(Unity.Entities.Chunk* LDKMHEJBNPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x550ED00", Offset = "0x550E100", VA = "0x18550ED00")]
		private unsafe static void BAKLFPNAFKK(IBNBGEBMAJL.MFAHIKEHIEO.MHENHKPKHOB KFPBHKJIHCK, int KMOEKFPIDKN, int BAGPNAOOOIE, Unity.Entities.Chunk* EMNIHNKDOMG, IBNBGEBMAJL AIDGJJIKBKA, NativeArray<int> LLKPCNGMKKA, global::OLKIDMOIAPH<BLKKLCOOGHJ> PDNGJNGOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x550FA20", Offset = "0x550EE20", VA = "0x18550FA20")]
		public static void CLPAEFFIMAA(DOGKLJKKAGC ICDEHOIBFMN, in ByteString NBOKDDEOMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x550F3D0", Offset = "0x550E7D0", VA = "0x18550F3D0")]
		public static void CLPAEFFIMAA(EntityManager KLFKJJDHNIL, global::OLKIDMOIAPH<BLKKLCOOGHJ> PDNGJNGOJPF, in ByteString NBOKDDEOMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x550EA40", Offset = "0x550DE40", VA = "0x18550EA40")]
		private static bool ACNAKCCKGJG(Type NLAFPPIOFPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x550F120", Offset = "0x550E520", VA = "0x18550F120")]
		private static void BIPAEKCAIAE(TypeManager.TypeInfo LBDGJNECAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x55108A0", Offset = "0x550FCA0", VA = "0x1855108A0")]
		private unsafe static int JGFKBEOKALG(Unity.Entities.Archetype*[] KEHAHHIGCIC, NativeArray<EntityRemapUtility.EntityRemapInfo> DHHBKGMIPPB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5510CD0", Offset = "0x55100D0", VA = "0x185510CD0")]
		private static int LDLBJOIAKDL(int IJKBMAIIDGK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x550FB20", Offset = "0x550EF20", VA = "0x18550FB20")]
		private static ulong GMICCBODADF(int IJKBMAIIDGK)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class HJKECBCABDL
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5509050", Offset = "0x5508450", VA = "0x185509050")]
	private unsafe static Span<byte> OGENPOBBAJJ(Unity.Entities.Chunk* LDKMHEJBNPK, int BKLGGKGOFGE)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x21E1280", Offset = "0x21E0680", VA = "0x1821E1280")]
	public unsafe static Span<T> DOBNNCHMMLM<T>(Unity.Entities.Chunk* LDKMHEJBNPK, int BKLGGKGOFGE)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x21E1400", Offset = "0x21E0800", VA = "0x1821E1400")]
	public static Span<T> DOBNNCHMMLM<T>(this ref Unity.Entities.Chunk LDKMHEJBNPK, int BKLGGKGOFGE)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5508C10", Offset = "0x5508010", VA = "0x185508C10")]
	public unsafe static Span<Entity> DLOAHLMHLOH(Unity.Entities.Chunk* LDKMHEJBNPK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5508C80", Offset = "0x5508080", VA = "0x185508C80")]
	public unsafe static void HLOEIBCGJID(Unity.Entities.Chunk* LDKMHEJBNPK, int BKLGGKGOFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5508F20", Offset = "0x5508320", VA = "0x185508F20")]
	public static Entity OELPBAEOIMH(this EntityQuery KFGMFPAGHMA)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : EFIPBPLGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x5512700", Offset = "0x5511B00", VA = "0x185512700", Slot = "4")]
		public sealed override void AMKPAJEBOOH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
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

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
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

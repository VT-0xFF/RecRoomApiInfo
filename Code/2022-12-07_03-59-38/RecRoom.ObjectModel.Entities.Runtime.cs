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
internal static class AKJEENMEEEC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5671730", Offset = "0x5670330", VA = "0x185671730")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> JBICMKLDPKF(this ref Unity.Entities.Archetype JIDCFBAAHAH)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CBCPGKCGAON
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x56719B0", Offset = "0x56705B0", VA = "0x1856719B0")]
	public static Span<int> MPELNOMOOJI(this EntityArchetype JIDCFBAAHAH)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JEHNJNELGPM
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MMGKCALBPHM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5675BC0", Offset = "0x56747C0", VA = "0x185675BC0")]
	public static bool BPOKJGMAKGF(this Entity BODOHICDFAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ADBACBMBLHD
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[BurstCompile]
	private struct BFBKMFMHDMN<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[ReadOnly]
		public NativeArray<Entity> EECJKEGNNBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[WriteOnly]
		public ComponentDataFromEntity<T> KAFEKGMEGPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public T NENFOEKGNGK;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x369A100", Offset = "0x3698D00", VA = "0x18369A100", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[BurstCompile]
	private struct EINGLLDILEG<T> : IJobChunk where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[WriteOnly]
		public ArchetypeChunkComponentType<T> FOPOLLLIJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T NENFOEKGNGK;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E321D0", Offset = "0x1E30DD0", VA = "0x181E321D0")]
	public static void GJKODJHLFFK<T>(this EntityManager JOKFOKELNGA, NativeArray<Entity> EADNCMDNEKI, T NENFOEKGNGK) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E33660", Offset = "0x1E32260", VA = "0x181E33660")]
	public static void PJIHGELMKEN<T>(this EntityManager JOKFOKELNGA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1E335E0", Offset = "0x1E321E0", VA = "0x181E335E0")]
	public static void NIBJDHKEOAO<T>(this EntityManager JOKFOKELNGA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1E31BB0", Offset = "0x1E307B0", VA = "0x181E31BB0")]
	public static JobHandle DBPCEOKNKNO<T>(this EntityManager JOKFOKELNGA) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5670D30", Offset = "0x566F930", VA = "0x185670D30")]
	public static JobHandle DBPCEOKNKNO(this EntityManager JOKFOKELNGA, int FKPCJKABBEA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct IHHJGCBOBFN<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ONNIPIJJKBE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::IHHJGCBOBFN<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x714C90", Offset = "0x713890", VA = "0x180714C90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4622DB0", Offset = "0x46219B0", VA = "0x184622DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x261AE10", Offset = "0x2619A10", VA = "0x18261AE10")]
		[DebuggerHidden]
		public ONNIPIJJKBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4622BD0", Offset = "0x46217D0", VA = "0x184622BD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4622D70", Offset = "0x4621970", VA = "0x184622D70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> EKJBLPFFEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream LBBCPGHIOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream IFLIDJPFHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf JNACKIKIJBP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int JGBMPNHDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6948E0", Offset = "0x6934E0", VA = "0x1806948E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x31F8C10", Offset = "0x31F7810", VA = "0x1831F8C10")]
	private IHHJGCBOBFN(byte[] MMDGIKEBLFM, Action<Protobuf> EKJBLPFFEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A48910", Offset = "0x2A47510", VA = "0x182A48910")]
	public static global::IHHJGCBOBFN<Protobuf> NBONEDNFGGC<Data>(ReadOnlySpan<byte> PGJDMPEOAIC, ReadOnlySpan<Data> IBDDKLPMGNI, Action<Protobuf> EKJBLPFFEBO)
	{
		return default(global::IHHJGCBOBFN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x31F8A80", Offset = "0x31F7680", VA = "0x1831F8A80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x31F8AC0", Offset = "0x31F76C0", VA = "0x1831F8AC0", Slot = "4")]
	[IteratorStateMachine(typeof(global::IHHJGCBOBFN<>.ONNIPIJJKBE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x31F8BC0", Offset = "0x31F77C0", VA = "0x1831F8BC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AGODNOLDIGG<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] MMDGIKEBLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf JNACKIKIJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream LBBCPGHIOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream DJBGMBJPNON;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3057190", Offset = "0x3055D90", VA = "0x183057190")]
	private AGODNOLDIGG(byte[] MMDGIKEBLFM, in Protobuf JNACKIKIJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2F61150", Offset = "0x2F5FD50", VA = "0x182F61150")]
	public static global::AGODNOLDIGG<Protobuf> NBONEDNFGGC<T>(ReadOnlySpan<T> IBDDKLPMGNI)
	{
		return default(global::AGODNOLDIGG<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3057160", Offset = "0x3055D60", VA = "0x183057160")]
	public void PHCFFKOGLML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3056FA0", Offset = "0x3055BA0", VA = "0x183056FA0")]
	public ByteString CPOEGAGEAIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3057030", Offset = "0x3055C30", VA = "0x183057030", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GCKMEEHGCPN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream LBBCPGHIOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream IFLIDJPFHNN;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5674020", Offset = "0x5672C20", VA = "0x185674020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BNGOPPFAMMP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] MMDGIKEBLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream LBBCPGHIOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream DJBGMBJPNON;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5671880", Offset = "0x5670480", VA = "0x185671880", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HJOOCEOMDNH
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public static void JHNLAOLOGIB(this FCNKBCOKGMK OIFMFCIPKIK, NativeArray<Entity> EADNCMDNEKI, [Optional][CallerFilePath] string GOIGEAFHIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public static void JHNLAOLOGIB(this FCNKBCOKGMK OIFMFCIPKIK, string MKPDFAEIFFO, NativeArray<Entity> EADNCMDNEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public static void JHNLAOLOGIB(this FCNKBCOKGMK OIFMFCIPKIK, string GOIGEAFHIHC, NativeArray<Entity> EADNCMDNEKI, bool ELLFPNJNAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public static void EOJGGPNCOCB(this FCNKBCOKGMK OIFMFCIPKIK, NativeArray<Entity> EADNCMDNEKI, NativeArray<Entity> IGDNBGHNGMF, [Optional][CallerFilePath] string GOIGEAFHIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public static void EOJGGPNCOCB(this FCNKBCOKGMK OIFMFCIPKIK, string GOIGEAFHIHC, NativeArray<Entity> EADNCMDNEKI, NativeArray<Entity> IGDNBGHNGMF, bool ELLFPNJNAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37573D0", Offset = "0x3755FD0", VA = "0x1837573D0")]
	public static void OPHDIJHLIHI<T>(this FCNKBCOKGMK OIFMFCIPKIK, string MKPDFAEIFFO, NativeArray<Entity> EADNCMDNEKI, NativeList<T> GAGLKGONONJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3757390", Offset = "0x3755F90", VA = "0x183757390")]
	public static void OPHDIJHLIHI<T>(this FCNKBCOKGMK OIFMFCIPKIK, string MKPDFAEIFFO, NativeArray<Entity> EADNCMDNEKI, NativeArray<T> GAGLKGONONJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public static void OPHDIJHLIHI<T>(this FCNKBCOKGMK OIFMFCIPKIK, string GOIGEAFHIHC, NativeArray<Entity> EADNCMDNEKI, NativeArray<T> GAGLKGONONJ, bool ELLFPNJNAMH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x37572F0", Offset = "0x3755EF0", VA = "0x1837572F0")]
	public static void IHBFBCIAJGC<T>(this FCNKBCOKGMK OIFMFCIPKIK, NativeList<T> GAGLKGONONJ, [Optional][CallerFilePath] string GOIGEAFHIHC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x37572C0", Offset = "0x3755EC0", VA = "0x1837572C0")]
	public static void IHBFBCIAJGC<T>(this FCNKBCOKGMK OIFMFCIPKIK, NativeArray<T> GAGLKGONONJ, [Optional][CallerFilePath] string GOIGEAFHIHC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public static void IHBFBCIAJGC<T>(this FCNKBCOKGMK OIFMFCIPKIK, string GOIGEAFHIHC, NativeArray<T> GAGLKGONONJ, bool ELLFPNJNAMH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public static void ELHECLCPIFH(this FCNKBCOKGMK OIFMFCIPKIK, EntityQuery GJLGONPKKFL, [Optional][CallerFilePath] string GOIGEAFHIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public static void ELHECLCPIFH(this FCNKBCOKGMK OIFMFCIPKIK, string MKPDFAEIFFO, EntityQuery GJLGONPKKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public static void ELHECLCPIFH(this FCNKBCOKGMK OIFMFCIPKIK, string GOIGEAFHIHC, EntityQuery GJLGONPKKFL, bool ELLFPNJNAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3757360", Offset = "0x3755F60", VA = "0x183757360")]
	public static void MDDMDPLMCCA<T, T2>(this FCNKBCOKGMK OIFMFCIPKIK, string MKPDFAEIFFO, EntityQuery GJLGONPKKFL) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	private static void MDDMDPLMCCA<T, T2>(this FCNKBCOKGMK OIFMFCIPKIK, string GOIGEAFHIHC, EntityQuery GJLGONPKKFL, bool ELLFPNJNAMH) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PGKDDODDOMH : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KCHKFBIFFEM JMFFPDJDGFO
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
public interface INIILNIDGKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKJHEDBPJHO(Entity BODOHICDFAL, object GIHOLCNOBIB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHJKPCBDOGO(Entity BODOHICDFAL, object GIHOLCNOBIB);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool APKBPPNGJGB(Entity BODOHICDFAL);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool APKBPPNGJGB(KCHKFBIFFEM LBLAJOOMAIC);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> HANHNFKDCHM(Entity BODOHICDFAL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BCJHIMIIPOB(Entity BODOHICDFAL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GHGBKHFBJNN<TComponentData, TValue> : global::NDFLGEHBCNM<TValue>, IDisposable where TComponentData : struct, PGKDDODDOMH
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class EAKCBCLGICG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> FOLHIKGIGJA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int GEHHFJONLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x2628870", Offset = "0x2627470", VA = "0x182628870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x351E990", Offset = "0x351D590", VA = "0x18351E990")]
		public bool PAKPHIDHIDO(out TValue NENFOEKGNGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x351E7B0", Offset = "0x351D3B0", VA = "0x18351E7B0")]
		public void AABPNGPFBPJ(object GIHOLCNOBIB, TValue NENFOEKGNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x351E910", Offset = "0x351D510", VA = "0x18351E910")]
		public bool KFPKFODPJHB(object GIHOLCNOBIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x351E860", Offset = "0x351D460", VA = "0x18351E860")]
		public int GOBCNAPLMBL(object GIHOLCNOBIB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x351EA50", Offset = "0x351D650", VA = "0x18351EA50")]
		public EAKCBCLGICG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<EAKCBCLGICG> PIEJKOCBEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::FNIOGEGGNAD<KCHKFBIFFEM, EAKCBCLGICG> CLFLPBNOLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager JOKFOKELNGA;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x33A9D80", Offset = "0x33A8980", VA = "0x1833A9D80")]
	public GHGBKHFBJNN(EntityManager JOKFOKELNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x33A9C60", Offset = "0x33A8860", VA = "0x1833A9C60", Slot = "4")]
	public void PKJHEDBPJHO(Entity BODOHICDFAL, object GIHOLCNOBIB, TValue NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x33A9820", Offset = "0x33A8420", VA = "0x1833A9820", Slot = "5")]
	public bool DHJKPCBDOGO(Entity BODOHICDFAL, object GIHOLCNOBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x33A9B90", Offset = "0x33A8790", VA = "0x1833A9B90", Slot = "6")]
	public bool PAKPHIDHIDO(Entity BODOHICDFAL, out TValue NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x33A9990", Offset = "0x33A8590", VA = "0x1833A9990", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x33A9A80", Offset = "0x33A8680", VA = "0x1833A9A80")]
	private void JBFBENLGEJM(EAKCBCLGICG MJAOFFONKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x33A99B0", Offset = "0x33A85B0", VA = "0x1833A99B0")]
	private bool EEKDMCDDNND(Entity BODOHICDFAL, out KCHKFBIFFEM LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x33A9B00", Offset = "0x33A8700", VA = "0x1833A9B00")]
	private void LCJFLAJJBIA(Entity BODOHICDFAL, KCHKFBIFFEM LBLAJOOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33A9A60", Offset = "0x33A8660", VA = "0x1833A9A60")]
	private bool EMJELMNCBKL(KCHKFBIFFEM LBLAJOOMAIC, out EAKCBCLGICG MJAOFFONKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x33A9760", Offset = "0x33A8360", VA = "0x1833A9760")]
	private EAKCBCLGICG CHLOKIHHIJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NDFLGEHBCNM<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKJHEDBPJHO(Entity BODOHICDFAL, object GIHOLCNOBIB, TValue NENFOEKGNGK);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHJKPCBDOGO(Entity BODOHICDFAL, object GIHOLCNOBIB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PAKPHIDHIDO(Entity BODOHICDFAL, out TValue NENFOEKGNGK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KCHKFBIFFEM : global::AHIMPCNGIKJ<KCHKFBIFFEM>, IIENHJEKFBL, IEquatable<KCHKFBIFFEM>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly KCHKFBIFFEM EABHPAGIEPM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int KLCIKJBGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CB0", Offset = "0x6D88B0", VA = "0x1806D9CB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6DB530", Offset = "0x6DA130", VA = "0x1806DB530", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int LKNCJMEJAON
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x715000", Offset = "0x713C00", VA = "0x180715000", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x715010", Offset = "0x713C10", VA = "0x180715010", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x56757B0", Offset = "0x56743B0", VA = "0x1856757B0", Slot = "8")]
	public bool Equals(KCHKFBIFFEM GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5675800", Offset = "0x5674400", VA = "0x185675800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KDBALECIHLC<T> : INIILNIDGKG, IDisposable where T : struct, PGKDDODDOMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> PIEJKOCBEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::FNIOGEGGNAD<KCHKFBIFFEM, HashSet<object>> CLFLPBNOLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager JOKFOKELNGA;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7780", Offset = "0x2CF6380", VA = "0x182CF7780")]
	public KDBALECIHLC(EntityManager JOKFOKELNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7300", Offset = "0x2CF5F00", VA = "0x182CF7300", Slot = "4")]
	public bool PKJHEDBPJHO(Entity BODOHICDFAL, object GIHOLCNOBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5700", Offset = "0x2CF4300", VA = "0x182CF5700", Slot = "5")]
	public bool DHJKPCBDOGO(Entity BODOHICDFAL, object GIHOLCNOBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2CF46F0", Offset = "0x2CF32F0", VA = "0x182CF46F0", Slot = "6")]
	public bool APKBPPNGJGB(Entity BODOHICDFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4650", Offset = "0x2CF3250", VA = "0x182CF4650", Slot = "7")]
	public bool APKBPPNGJGB(KCHKFBIFFEM LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2CF64A0", Offset = "0x2CF50A0", VA = "0x182CF64A0", Slot = "8")]
	public IEnumerable<object> HANHNFKDCHM(Entity BODOHICDFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2CF62C0", Offset = "0x2CF4EC0", VA = "0x182CF62C0", Slot = "11")]
	public IEnumerable<object> HANHNFKDCHM(KCHKFBIFFEM LBLAJOOMAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4AE0", Offset = "0x2CF36E0", VA = "0x182CF4AE0", Slot = "9")]
	public bool BCJHIMIIPOB(Entity BODOHICDFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2CF58D0", Offset = "0x2CF44D0", VA = "0x182CF58D0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6A00", Offset = "0x2CF5600", VA = "0x182CF6A00")]
	private void JBFBENLGEJM(HashSet<object> MJAOFFONKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF60C0", Offset = "0x2CF4CC0", VA = "0x182CF60C0")]
	private bool EEKDMCDDNND(Entity BODOHICDFAL, out KCHKFBIFFEM LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5A80", Offset = "0x2CF4680", VA = "0x182CF5A80")]
	private bool EAHGLDHEDLM(Entity BODOHICDFAL, out KCHKFBIFFEM LBLAJOOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6A70", Offset = "0x2CF5670", VA = "0x182CF6A70")]
	private void KJHCKGNBPKM(Entity BODOHICDFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6A90", Offset = "0x2CF5690", VA = "0x182CF6A90")]
	private void LCJFLAJJBIA(Entity BODOHICDFAL, KCHKFBIFFEM LBLAJOOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6D60", Offset = "0x2CF5960", VA = "0x182CF6D60")]
	private bool LPEDCHAKPAP(KCHKFBIFFEM LBLAJOOMAIC, out HashSet<object> MJAOFFONKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5120", Offset = "0x2CF3D20", VA = "0x182CF5120")]
	private HashSet<object> CHLOKIHHIJC()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MHIAFKOFDAE : global::ACJCBDGDGJB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5675BB0", Offset = "0x56747B0", VA = "0x185675BB0", Slot = "4")]
	public float CDJMILEFHLC(float3 NENFOEKGNGK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PMECLAPPGME : global::ACJCBDGDGJB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x56760A0", Offset = "0x5674CA0", VA = "0x1856760A0", Slot = "4")]
	public float CDJMILEFHLC(float3 NENFOEKGNGK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EOCKFLBCADM : global::ACJCBDGDGJB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5673870", Offset = "0x5672470", VA = "0x185673870", Slot = "4")]
	public float CDJMILEFHLC(float3 NENFOEKGNGK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct HPGPAPNIEND : global::ACJCBDGDGJB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xDDDA40", Offset = "0xDDC640", VA = "0x180DDDA40", Slot = "4")]
	public int CDJMILEFHLC(int3 NENFOEKGNGK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PIKPNHCBCKD : global::ACJCBDGDGJB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1A57B00", Offset = "0x1A56700", VA = "0x181A57B00", Slot = "4")]
	public int CDJMILEFHLC(int3 NENFOEKGNGK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct LFHAKMEHLLJ : global::ACJCBDGDGJB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x56758C0", Offset = "0x56744C0", VA = "0x1856758C0", Slot = "4")]
	public int CDJMILEFHLC(int3 NENFOEKGNGK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class EPHBCKIDNHM : CKGBMCJBKPM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type KLHJPPHJMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x695F10", Offset = "0x694B10", VA = "0x180695F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5671A80", Offset = "0x5670680", VA = "0x185671A80")]
	public EPHBCKIDNHM(Type JIPJGJLKOHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GDPFPDEGDCA : EPHBCKIDNHM
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5671A80", Offset = "0x5670680", VA = "0x185671A80")]
	public GDPFPDEGDCA(Type JIPJGJLKOHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CCCDCDPGOAH : EPHBCKIDNHM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type KPLEDMKFDDB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69FA00", Offset = "0x69E600", VA = "0x18069FA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5671A30", Offset = "0x5670630", VA = "0x185671A30")]
	public CCCDCDPGOAH(Type DFBFPMJDEHH, Type JIPJGJLKOHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CEBCBLLOONF : EPHBCKIDNHM
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5671A80", Offset = "0x5670680", VA = "0x185671A80")]
	public CEBCBLLOONF(Type JIPJGJLKOHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NIHNIOJKONF : CKGBMCJBKPM
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public NIHNIOJKONF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LFODFFJJMDP : CKGBMCJBKPM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HMDFJLNCJCF BIJKPHEKFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x678060", Offset = "0x676C60", VA = "0x180678060")]
		[CompilerGenerated]
		get
		{
			return default(HMDFJLNCJCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x56758D0", Offset = "0x56744D0", VA = "0x1856758D0")]
	public LFODFFJJMDP(HMDFJLNCJCF BMNJICJIDIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class OAJACFAFCNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DEDLBKJDALP EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager JOKFOKELNGA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DEDLBKJDALP JJBDOGEBBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5675E00", Offset = "0x5674A00", VA = "0x185675E00")]
	public OAJACFAFCNG(DEDLBKJDALP EELLGOEIJJC, EntityManager JOKFOKELNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x29FC9D0", Offset = "0x29FB5D0", VA = "0x1829FC9D0")]
	public bool DHFJGBENPND<T>(Entity BODOHICDFAL) where T : struct, KFBHGAJPMMP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x29FCA10", Offset = "0x29FB610", VA = "0x1829FCA10")]
	public bool FJIMOLEHILP<T>(Entity BODOHICDFAL, out T NENFOEKGNGK) where T : struct, KFBHGAJPMMP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x29FCAA0", Offset = "0x29FB6A0", VA = "0x1829FCAA0")]
	public T IECEEHACGFG<T>(Entity BODOHICDFAL) where T : struct, KFBHGAJPMMP
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x29FE480", Offset = "0x29FD080", VA = "0x1829FE480")]
	private ComponentType IMGAJIMIJPK<T>() where T : struct, KFBHGAJPMMP
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5675D30", Offset = "0x5674930", VA = "0x185675D30")]
	private ComponentType IMGAJIMIJPK(Type JMPEGNOKOOB)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class OIFFKKBIOLH
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	protected OIFFKKBIOLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class PCDIPAFKKPJ<View, Data> : ELGFJHKNNCH where View : struct, KFBHGAJPMMP where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType JCGPIJDAANH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type IGHCINEDGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2DCCDE0", Offset = "0x2DCB9E0", VA = "0x182DCCDE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type ELABKHAGBKE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2DCBA70", Offset = "0x2DCA670", VA = "0x182DCBA70", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int ILBAONKICDN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2DCC480", Offset = "0x2DCB080", VA = "0x182DCC480", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2DCB060", Offset = "0x2DC9C60", VA = "0x182DCB060")]
	public Data BLJAOOAPAEL(Entity BODOHICDFAL)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2DCB0D0", Offset = "0x2DC9CD0", VA = "0x182DCB0D0")]
	public Data EKDEBIADOAO(Entity BODOHICDFAL)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View IKLLEHFOLDN(Entity BODOHICDFAL);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x433CCD0", Offset = "0x433B8D0", VA = "0x18433CCD0", Slot = "15")]
	protected internal override T IKLLEHFOLDN<T>(Entity BODOHICDFAL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB490", Offset = "0x1DCA090", VA = "0x181DCB490")]
	protected PCDIPAFKKPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class ELGFJHKNNCH : HHFMDBGAKBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic GNABHMHGDCH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager CNOHAEKAHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x802890", Offset = "0x801490", VA = "0x180802890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type IGHCINEDGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type ELABKHAGBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int ILBAONKICDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type PDHJLKKNNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA42610", Offset = "0xA41210", VA = "0x180A42610", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int HFNJJDKFMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5673790", Offset = "0x5672390", VA = "0x185673790", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private CFLHDMKEGPM[] DKBCKMKHPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA42540", Offset = "0xA41140", VA = "0x180A42540", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual CFLHDMKEGPM[] GJDECGOJDFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5673550", Offset = "0x5672150", VA = "0x185673550", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AICIGJODCEC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5673760", Offset = "0x5672360", VA = "0x185673760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5673430", Offset = "0x5672030", VA = "0x185673430")]
	public void CKNDJHJGHOM(EntityManager JOKFOKELNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0B0", Offset = "0x6D8CB0", VA = "0x1806DA0B0")]
	protected HHFMDBGAKBP BDLPDFEMDOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T IKLLEHFOLDN<T>(Entity BODOHICDFAL) where T : struct, KFBHGAJPMMP;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5673610", Offset = "0x5672210", VA = "0x185673610", Slot = "8")]
	public (uint, uint) ELIOJBPOCHE(Entity BODOHICDFAL)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x56736D0", Offset = "0x56722D0", VA = "0x1856736D0", Slot = "9")]
	public bool HNBIKOLCNLA(Entity BODOHICDFAL, (uint order, uint change) OLOLCGEOMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	protected ELGFJHKNNCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class KHEHEIKAEGJ<Data> : NPOFMEGBCMP where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data DJCOHFHFNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2D051E0", Offset = "0x2D03DE0", VA = "0x182D051E0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x29D83A0", Offset = "0x29D6FA0", VA = "0x1829D83A0", Slot = "8")]
	protected virtual bool GEMOCHBHCPJ(ReadOnlySpan<Data> IBDDKLPMGNI, GFBPCLDKMCE OBMKDNADDIP, out ReadOnlySpan<byte> PGJDMPEOAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0", Slot = "9")]
	protected virtual bool ILAPNIOHNJM(int OLOLCGEOMNE, Span<Data> IBDDKLPMGNI, in ReadOnlySpan<byte> PGJDMPEOAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2D052B0", Offset = "0x2D03EB0", VA = "0x182D052B0", Slot = "5")]
	internal sealed override bool GEMOCHBHCPJ(ref Unity.Entities.Chunk AEGPPFELHPO, int NOPJDLFNNEO, GFBPCLDKMCE OBMKDNADDIP, out ReadOnlySpan<byte> PGJDMPEOAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D05FC0", Offset = "0x2D04BC0", VA = "0x182D05FC0", Slot = "6")]
	internal sealed override bool ILAPNIOHNJM(int OLOLCGEOMNE, ref Unity.Entities.Chunk AEGPPFELHPO, int NOPJDLFNNEO, in ReadOnlySpan<byte> PGJDMPEOAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B2F0", Offset = "0x2A49EF0", VA = "0x182A4B2F0")]
	protected global::AGODNOLDIGG<Protobuf> LADKCIGANDL<Protobuf>(ReadOnlySpan<Data> IBDDKLPMGNI) where Protobuf : IMessage, new()
	{
		return default(global::AGODNOLDIGG<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B340", Offset = "0x2A49F40", VA = "0x182A4B340")]
	protected global::IHHJGCBOBFN<Protobuf> ODOEILNPHND<Protobuf>(ReadOnlySpan<byte> PGJDMPEOAIC, ReadOnlySpan<Data> IBDDKLPMGNI, Action<Protobuf> EKJBLPFFEBO) where Protobuf : IMessage, new()
	{
		return default(global::IHHJGCBOBFN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB490", Offset = "0x1DCA090", VA = "0x181DCB490")]
	protected KHEHEIKAEGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class NPOFMEGBCMP
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int LKNCJMEJAON
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5675D10", Offset = "0x5674910", VA = "0x185675D10", Slot = "5")]
	internal virtual bool GEMOCHBHCPJ(ref Unity.Entities.Chunk AEGPPFELHPO, int NOPJDLFNNEO, GFBPCLDKMCE OBMKDNADDIP, out ReadOnlySpan<byte> PGJDMPEOAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0", Slot = "6")]
	internal virtual bool ILAPNIOHNJM(int OLOLCGEOMNE, ref Unity.Entities.Chunk AEGPPFELHPO, int NOPJDLFNNEO, in ReadOnlySpan<byte> PGJDMPEOAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	protected NPOFMEGBCMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface ACJCBDGDGJB<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo CDJMILEFHLC(TFrom NENFOEKGNGK);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IMKJGOFBKIM<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBDPDCGMFLO(T NENFOEKGNGK);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct LFIAHHGGFIL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::ACJCBDGDGJB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> FHGFAKHPFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> JFOJALOOPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap MNJNLIAKBME;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct ABDJCGHBKAM<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::ACJCBDGDGJB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> IDBIELHDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> JFOJALOOPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap MNJNLIAKBME;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk AEGPPFELHPO, int PBPBGJKMKOA, int MHNHNDECOOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct KIBDGGHKDLA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OBFOLDMDCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> FHGFAKHPFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> JFOJALOOPDK;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x37B3A60", Offset = "0x37B2660", VA = "0x1837B3A60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct OFJIJJILHEC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OBFOLDMDCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> FHGFAKHPFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> OLFIADPDKEE;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct OMKDPMHJGCH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::ACJCBDGDGJB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> NDKHHFBAPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> JFOJALOOPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap MNJNLIAKBME;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct PMIPBHIEMHA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JIPJGJLKOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> EECJKEGNNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> JNALFAAFLAD;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct IHLIGLIMGJB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JIPJGJLKOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> EECJKEGNNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> JNALFAAFLAD;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x31F8D60", Offset = "0x31F7960", VA = "0x1831F8D60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct GFADBAOIBHK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> FHGFAKHPFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> OLFIADPDKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, CJFIGKJMGNA> LIDKKHLDANL;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x339EB50", Offset = "0x339D750", VA = "0x18339EB50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct IIKHDBPKGLO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::ACJCBDGDGJB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> FHGFAKHPFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> OLFIADPDKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, CJFIGKJMGNA> LIDKKHLDANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap MNJNLIAKBME;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct DIIPAFMBDAH<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::IMKJGOFBKIM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> FHGFAKHPFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> OLFIADPDKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate MNJNLIAKBME;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct AECKIPNPNAF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ACOGKCNIFAF JIPJGJLKOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> EECJKEGNNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> BKEHJDKOPOC;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5670E20", Offset = "0x566FA20", VA = "0x185670E20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct CKACNOKAPMI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ACOGKCNIFAF JIPJGJLKOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> EECJKEGNNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> BKEHJDKOPOC;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5671BC0", Offset = "0x56707C0", VA = "0x185671BC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LHPMPEJFADO
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class DNJMLEFOHNK
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C95900", Offset = "0x2C94500", VA = "0x182C95900")]
	public static bool PDNKOLJBCCA<T>(this NativeArray<Entity> EECJKEGNNBI, EntityManager JOKFOKELNGA, Allocator JMMNDPMBMFC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class NPHOBIPLKBG
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GKIHPIKNMFN<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public GKIHPIKNMFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class BADEFAFBACF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public BADEFAFBACF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> DFNJELODFPF;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5675C90", Offset = "0x5674890", VA = "0x185675C90")]
	public NPHOBIPLKBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class OJAAJIDDDHF
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class PDFDMJKELMN
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct KMHAKPCNAEB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct EOBIMHKDGOM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal KMHAKPCNAEB<TFrom> NIGFDFKEKGM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator JMMNDPMBMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> CJMCKLJFKJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct OMMHDMMAGJJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct PANKHLJPDIE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal OMMHDMMAGJJ<TFrom> NIGFDFKEKGM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator JMMNDPMBMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> CJMCKLJFKJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct JICECEMEKBP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct OOMPNFKFGLH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal JICECEMEKBP<TFrom> NIGFDFKEKGM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator JMMNDPMBMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal global::OEJJJGPOENI<TFrom> CJMCKLJFKJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct DMJFJGCDOJO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct FCOCAGMFAKD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal DMJFJGCDOJO<TFrom> NIGFDFKEKGM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator JMMNDPMBMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal global::GFPHNEMLNOJ<TFrom> CJMCKLJFKJI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class DGCEDFMAIBJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class EGHKOGEPGAI
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8170", Offset = "0x2CA6D70", VA = "0x182CA8170")]
	public static NativeList<T> OONNDGBJKEM<T>(this NativeArray<T> AEHMOBAFHAG, Allocator JMMNDPMBMFC = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class GIFNJJIKGBA
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3735190", Offset = "0x3733D90", VA = "0x183735190")]
	public static NativeArray<T> CGECGPAIGBE<T>(this NativeList<Entity> AEHMOBAFHAG, EntityManager JOKFOKELNGA, Allocator JMMNDPMBMFC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3735090", Offset = "0x3733C90", VA = "0x183735090")]
	public static NativeArray<T> CGECGPAIGBE<T>(this NativeArray<Entity> AEHMOBAFHAG, EntityManager JOKFOKELNGA, Allocator JMMNDPMBMFC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class HBIOGAEBIJM
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct LDIPHNOOBNF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct CHCNKFBMOAP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public LDIPHNOOBNF<TFrom> CJMCKLJFKJI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator JMMNDPMBMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> FHGFAKHPFLA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct KAJPPANBGHF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct EDECGAPHOJL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public KAJPPANBGHF<TFrom> CJMCKLJFKJI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator JMMNDPMBMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public global::OEJJJGPOENI<TFrom> FHGFAKHPFLA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct CFMIOKGBPNL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct GFJDGNJCMFL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public CFMIOKGBPNL<TFrom> CJMCKLJFKJI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator JMMNDPMBMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public global::GFPHNEMLNOJ<TFrom> FHGFAKHPFLA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class IJJMJJLGDLJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class HMLDGJCKGFM
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct NDOCPGDMMEC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator JMMNDPMBMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> FHGFAKHPFLA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct GHEKOFEEONI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator JMMNDPMBMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> FHGFAKHPFLA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct JFCKKCGILBB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator JMMNDPMBMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public global::OEJJJGPOENI<T> FHGFAKHPFLA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct EIKGBAMLIJA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator JMMNDPMBMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public global::GFPHNEMLNOJ<T> FHGFAKHPFLA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class DBIOGEPBHLO
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class ELBBMGIGLOF
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x28090E0", Offset = "0x2807CE0", VA = "0x1828090E0")]
	public static NativeList<Entity> OMEBMNDDFAM<T>(this NativeArray<Entity> EECJKEGNNBI, EntityManager JOKFOKELNGA, Allocator JMMNDPMBMFC = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class APDINKCAHJI
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface OLHKIFICFEF
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KOLAGKJFEMB
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class NPODPKMHJHI
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class JKDMGMKBLDF
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5675400", Offset = "0x5674000", VA = "0x185675400")]
	public static bool ADLIKOCPEMD(Type JMPEGNOKOOB, Type HIFFGEDALHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class GMMKDPPPMIE<Attribute, BaseClass> : global::DNPFLOBBLBK<BaseClass>, INCILGIJKHH where Attribute : EPHBCKIDNHM
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly FCNKBCOKGMK OIFMFCIPKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string MKPDFAEIFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> LOBCBOOILEO;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x33B8E80", Offset = "0x33B7A80", VA = "0x1833B8E80")]
	public GMMKDPPPMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x33B8C90", Offset = "0x33B7890", VA = "0x1833B8C90", Slot = "4")]
	public bool INBBKHIKIAC(int FKPCJKABBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x33B8950", Offset = "0x33B7550", VA = "0x1833B8950", Slot = "5")]
	public global::PEENCLMLKDL<BaseClass> DGGOFBOELOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x33B8850", Offset = "0x33B7450", VA = "0x1833B8850", Slot = "7")]
	protected virtual bool ADLIKOCPEMD(Type JMPEGNOKOOB, int EKMAHBIPJCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x33B8C00", Offset = "0x33B7800", VA = "0x1833B8C00", Slot = "8")]
	protected virtual int DNCEKGNPHNM(Type JMPEGNOKOOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x33B8D90", Offset = "0x33B7990", VA = "0x1833B8D90")]
	public void LOFJJDLCKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x33B8CF0", Offset = "0x33B78F0", VA = "0x1833B8CF0", Slot = "6")]
	public void JHOMPJHMJJA(Type JMPEGNOKOOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class PEENCLMLKDL<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> CGAGNAHPENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> IOOGIKPKNBF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> MAANHOKHEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8160", Offset = "0x2DD6D60", VA = "0x182DD8160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2DD8530", Offset = "0x2DD7130", VA = "0x182DD8530")]
	public PEENCLMLKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2DD8390", Offset = "0x2DD6F90", VA = "0x182DD8390")]
	public PEENCLMLKDL(int KOHJKAOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2DD7FE0", Offset = "0x2DD6BE0", VA = "0x182DD7FE0")]
	internal void AABPNGPFBPJ(int FKPCJKABBEA, BaseClass KKILKFBEMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2E4BB40", Offset = "0x2E4A740", VA = "0x182E4BB40")]
	public bool MPOABPIBAHC<T>(out BaseClass NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2DD80C0", Offset = "0x2DD6CC0", VA = "0x182DD80C0")]
	public bool MPOABPIBAHC(Type FDMNMHNCFEK, out BaseClass NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2DD8060", Offset = "0x2DD6C60", VA = "0x182DD8060")]
	public bool DIDLIDNBFEL(int FKPCJKABBEA, out BaseClass NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2E4BA60", Offset = "0x2E4A660", VA = "0x182E4BA60")]
	public T MEKPMHHPJOA<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2DD8090", Offset = "0x2DD6C90", VA = "0x182DD8090")]
	public BaseClass MEKPMHHPJOA(Type HJMJHIKJJBI)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class KLCDDBMCELO : global::GMMKDPPPMIE<GDPFPDEGDCA, OIFFKKBIOLH>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5675850", Offset = "0x5674450", VA = "0x185675850")]
	public KLCDDBMCELO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class GELINBONCME : global::GMMKDPPPMIE<CCCDCDPGOAH, ELGFJHKNNCH>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5674060", Offset = "0x5672C60", VA = "0x185674060")]
	public GELINBONCME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class JFEPCLDLOMB : global::GMMKDPPPMIE<CEBCBLLOONF, NPOFMEGBCMP>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5675390", Offset = "0x5673F90", VA = "0x185675390")]
	public JFEPCLDLOMB()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[GKALNADHNEP(DAHLALKJFLL.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> HAAPMPEHPPA;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x695F00", Offset = "0x694B00", VA = "0x180695F00")]
		private ComponentSystemTypes(List<Type> HAAPMPEHPPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5671F70", Offset = "0x5670B70", VA = "0x185671F70")]
		public static void LOFJJDLCKCK(List<Type> HAAPMPEHPPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5671CD0", Offset = "0x56708D0", VA = "0x185671CD0")]
		private void DDCPNPEMECP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5671C50", Offset = "0x5670850", VA = "0x185671C50")]
		private bool ADLIKOCPEMD(Type JMPEGNOKOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5671F10", Offset = "0x5670B10", VA = "0x185671F10")]
		private void GKJFLMCHPAO(Type JMPEGNOKOOB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class GEPHOAAGCCO : LPEKBLLHNJF
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x56740D0", Offset = "0x5672CD0", VA = "0x1856740D0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase PIDBAMCONIO();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5674110", Offset = "0x5672D10", VA = "0x185674110")]
	protected ComponentSystemBase PHIOHIOOHCC(params ComponentSystemBase[] OAMEEAPEBME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3734BD0", Offset = "0x37337D0", VA = "0x183734BD0")]
	protected ComponentSystemBase PHIOHIOOHCC<T>(params ComponentSystemBase[] OAMEEAPEBME) where T : LPEKBLLHNJF, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3734B90", Offset = "0x3733790", VA = "0x183734B90")]
	protected ComponentSystemBase PMPONDOEDCE<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3734B90", Offset = "0x3733790", VA = "0x183734B90")]
	protected ComponentSystemBase JMDKOKJHCLH<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	protected GEPHOAAGCCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface DNPFLOBBLBK<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INBBKHIKIAC(int FKPCJKABBEA);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::PEENCLMLKDL<BaseClass> DGGOFBOELOA();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class LPEKBLLHNJF : IFICCKDFKML
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5675900", Offset = "0x5674500", VA = "0x185675900", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public LPEKBLLHNJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class IKDACLPDLNJ : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x56752E0", Offset = "0x5673EE0", VA = "0x1856752E0")]
	public ACOGKCNIFAF HGAPEHEHDEP(int FKPCJKABBEA, bool GEAOBIGLECL = false)
	{
		return default(ACOGKCNIFAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5675380", Offset = "0x5673F80", VA = "0x185675380", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0")]
	protected IKDACLPDLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class NCJGNNIGIPP : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0")]
	protected NCJGNNIGIPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class PDHHEADABLB : IKDACLPDLNJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5676070", Offset = "0x5674C70", VA = "0x185676070", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	protected void DJEAOKOFLJM(string NOGJKHDOHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0")]
	protected PDHHEADABLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class FBKOHMOFJIE
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class IFICCKDFKML : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	protected IFICCKDFKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[GKALNADHNEP(DAHLALKJFLL.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5676410", Offset = "0x5675010", VA = "0x185676410")]
		public static ComponentSystemGroup[] FJNDLDPNONP(World EELLGOEIJJC, JLMJPPBICMJ MGBMBKJJDJF = JLMJPPBICMJ.Default, bool FLOGCCMEADP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5676B90", Offset = "0x5675790", VA = "0x185676B90")]
		private static Type[] PBJNEIIJIEG(JLMJPPBICMJ MGBMBKJJDJF, bool FLOGCCMEADP, ComponentSystemGroup[] EENNGEAKMFG, ComponentSystemGroup NPGFCJONDPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5676F50", Offset = "0x5675B50", VA = "0x185676F50")]
		private static ComponentSystemGroup[] PKBFOLACBMN(World EELLGOEIJJC, out ComponentSystemGroup NPGFCJONDPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5676190", Offset = "0x5674D90", VA = "0x185676190")]
		internal static bool BDLDFIMGGKL(HMDFJLNCJCF BMNJICJIDIA, out AODHPHPILFJ CIFAOHLMLPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x56760B0", Offset = "0x5674CB0", VA = "0x1856760B0")]
		private static ComponentSystemGroup ANFLBLEJJJB(Type JMPEGNOKOOB, World EELLGOEIJJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x56764E0", Offset = "0x56750E0", VA = "0x1856764E0")]
		private static ComponentSystemGroup[] GAIBPCCEFEI(Type[] HAAPMPEHPPA, World EELLGOEIJJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5676610", Offset = "0x5675210", VA = "0x185676610")]
		internal static void LJLIJJDMGFF(World EELLGOEIJJC, Type[] ANEKFGKJFND, ComponentSystemGroup[] EENNGEAKMFG, ComponentSystemGroup NPGFCJONDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5676B30", Offset = "0x5675730", VA = "0x185676B30")]
		internal static bool MICGMPHDFNO(ComponentSystemBase BHDJNCHMFPK, ComponentSystemGroup[] EENNGEAKMFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5676EF0", Offset = "0x5675AF0", VA = "0x185676EF0")]
		private static void PGPNOIHJEKA(ComponentSystemGroup[] EENNGEAKMFG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct CLHKINOKMOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> OHFBAMFPJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> OAMEEAPEBME;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x91D560", Offset = "0x91C160", VA = "0x18091D560")]
	public CLHKINOKMOI(Dictionary<Type, List<Type>> OHFBAMFPJMO, HashSet<Type> OAMEEAPEBME)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[GKALNADHNEP(DAHLALKJFLL.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class IEFLGEGBDOB : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x712DA0", Offset = "0x7119A0", VA = "0x180712DA0")]
			[DebuggerHidden]
			public IEFLGEGBDOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5674C20", Offset = "0x5673820", VA = "0x185674C20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5674980", Offset = "0x5673580", VA = "0x185674980", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5674CB0", Offset = "0x56738B0", VA = "0x185674CB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5674BE0", Offset = "0x56737E0", VA = "0x185674BE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5674B30", Offset = "0x5673730", VA = "0x185674B30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5674B30", Offset = "0x5673730", VA = "0x185674B30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct KJJCCIFACAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type MMPLNLGPNMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private JLMJPPBICMJ MGBMBKJJDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool NJANAJAOHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool DHIELAOLGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool FLOGCCMEADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> BFADEECCPDM;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5677B90", Offset = "0x5676790", VA = "0x185677B90")]
		public static RRFilterWorldSystems NBONEDNFGGC()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5677B80", Offset = "0x5676780", VA = "0x185677B80")]
		public RRFilterWorldSystems MPGJNCHNHBF(JLMJPPBICMJ BMNJICJIDIA)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5677860", Offset = "0x5676460", VA = "0x185677860")]
		public RRFilterWorldSystems KFINLOOKION(IEnumerable<Type> HAAPMPEHPPA)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5677570", Offset = "0x5676170", VA = "0x185677570")]
		public RRFilterWorldSystems ICPLKLBIEHL(bool IHFHOHHNKOE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x56772F0", Offset = "0x5675EF0", VA = "0x1856772F0")]
		public RRFilterWorldSystems BCMOKIFMNOG(bool FHFGNHEPLGL)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x56777D0", Offset = "0x56763D0", VA = "0x1856777D0")]
		public CLHKINOKMOI KECFBGEJDGD(Type[] JCHCBKFKKPG)
		{
			return default(CLHKINOKMOI);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5677740", Offset = "0x5676340", VA = "0x185677740")]
		[IteratorStateMachine(typeof(IEFLGEGBDOB))]
		internal IEnumerable<Type> JMPMOOLDPFF(IEnumerable<Type> HAAPMPEHPPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x56778A0", Offset = "0x56764A0", VA = "0x1856778A0")]
		internal Dictionary<Type, List<Type>> LNAKHNDNPAM(IEnumerable<Type> HAAPMPEHPPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5677300", Offset = "0x5675F00", VA = "0x185677300")]
		private void BMEIKGAGEDD(Dictionary<Type, List<Type>> LBMPGEENEFO, Type JMPEGNOKOOB, Type OJIKKLANPCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5677580", Offset = "0x5676180", VA = "0x185677580")]
		internal HashSet<Type> JHIDDMAKHEJ(IEnumerable<Type> EENNGEAKMFG, Dictionary<Type, List<Type>> FDJAPCCPCPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5677BB0", Offset = "0x56767B0", VA = "0x185677BB0")]
		internal bool NIBCKNPIOLH(Type JMPEGNOKOOB, JLMJPPBICMJ MGBMBKJJDJF, bool FLOGCCMEADP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5677410", Offset = "0x5676010", VA = "0x185677410")]
		[CompilerGenerated]
		internal static void GPGFNEPJAEB(Type JMPEGNOKOOB, ref KJJCCIFACAN P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class PCOOKFJIFPK
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool HCCHJFCHJGI;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5676010", Offset = "0x5674C10", VA = "0x185676010")]
	public static void CKNDJHJGHOM(bool HLLKIIKCMBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5675E50", Offset = "0x5674A50", VA = "0x185675E50")]
	private static void AHELEADKKCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class EOFIJDEDKGO
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5673E60", Offset = "0x5672A60", VA = "0x185673E60")]
	public static ulong JEMANAPGLCB(Type JMPEGNOKOOB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5673DA0", Offset = "0x56729A0", VA = "0x185673DA0")]
	public static ulong JEMANAPGLCB(string MIEGNEDCBLP)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[GKALNADHNEP(DAHLALKJFLL.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct EACLPNNJHDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong BFLKBHBEOMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong LOOKMPHLIOB;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x92F5C0", Offset = "0x92E1C0", VA = "0x18092F5C0")]
			public EACLPNNJHDD(ulong DCFLAINAOAN, ulong CDMEDBHCDNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5672FB0", Offset = "0x5671BB0", VA = "0x185672FB0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> LBAKPKAMHEP;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static EACLPNNJHDD[] EBFDBMMOOLB;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool HCCHJFCHJGI;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5678850", Offset = "0x5677450", VA = "0x185678850")]
		public static ulong HMLHNKLCMBB(int FKPCJKABBEA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x56788C0", Offset = "0x56774C0", VA = "0x1856788C0")]
		public static int JBPONJPFLPI(ulong CDMEDBHCDNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x56783A0", Offset = "0x5676FA0", VA = "0x1856783A0")]
		public static void CKNDJHJGHOM(bool HLLKIIKCMBO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x56782C0", Offset = "0x5676EC0", VA = "0x1856782C0")]
		private static void BFKHFPLMHPK(int ICPNFNHCIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5678C90", Offset = "0x5677890", VA = "0x185678C90")]
		private static void PIIFEJIHLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5678670", Offset = "0x5677270", VA = "0x185678670")]
		private static EACLPNNJHDD GBCPPHFLPLJ(Type JMPEGNOKOOB)
		{
			return default(EACLPNNJHDD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5678750", Offset = "0x5677350", VA = "0x185678750")]
		private static ulong GBFHJGFJPJB(Type JMPEGNOKOOB, ulong CDMEDBHCDNE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5678A70", Offset = "0x5677670", VA = "0x185678A70")]
		private static void PFDHNEMBBMP(in EACLPNNJHDD OMOJFJKIEFP, TypeManager.TypeInfo AOMOPBLLPHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5678970", Offset = "0x5677570", VA = "0x185678970")]
		private static void JCEBOKNNADP(EACLPNNJHDD AOMOPBLLPHG, int FKPCJKABBEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5678590", Offset = "0x5677190", VA = "0x185678590")]
		private static void COGAJGDMCPD(EACLPNNJHDD AOMOPBLLPHG, int FKPCJKABBEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x56787C0", Offset = "0x56773C0", VA = "0x1856787C0")]
		private static EACLPNNJHDD GKKDLPBDEHF(int FKPCJKABBEA)
		{
			return default(EACLPNNJHDD);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x56788B0", Offset = "0x56774B0", VA = "0x1856788B0")]
		private static int IACCCMGMIKI(int FKPCJKABBEA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class AHICFOBBADA
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly GELINBONCME BBMFMGHKONB;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly JFEPCLDLOMB EGEMCEDGEED;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly KLCDDBMCELO NDIPNCONGCM;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> JMEMOEENENH;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool HCCHJFCHJGI;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::DNPFLOBBLBK<ELGFJHKNNCH> ONJNABHAMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5671360", Offset = "0x566FF60", VA = "0x185671360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::DNPFLOBBLBK<NPOFMEGBCMP> JONHNNAGDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x56713C0", Offset = "0x566FFC0", VA = "0x1856713C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::DNPFLOBBLBK<OIFFKKBIOLH> DLPAHNJNGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x56714A0", Offset = "0x56700A0", VA = "0x1856714A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5670EB0", Offset = "0x566FAB0", VA = "0x185670EB0")]
	public static void CKNDJHJGHOM(bool HLLKIIKCMBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5671420", Offset = "0x5670020", VA = "0x185671420")]
	public static Type[] OBDOHKELBLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class EOEGJMCLGPJ
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> AAJEDCFLJEH;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool HCCHJFCHJGI;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5673930", Offset = "0x5672530", VA = "0x185673930")]
	public static int ELIOJBPOCHE(int FKPCJKABBEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5673890", Offset = "0x5672490", VA = "0x185673890")]
	public static void CKNDJHJGHOM(bool HLLKIIKCMBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5673A20", Offset = "0x5672620", VA = "0x185673A20")]
	private static void GGHCOELEMPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x56739D0", Offset = "0x56725D0", VA = "0x1856739D0")]
	private static int FPAHFGKFBJB(Type JMPEGNOKOOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5673CA0", Offset = "0x56728A0", VA = "0x185673CA0")]
	private static void GGNFLDPHLOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class DEDLBKJDALP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World EELLGOEIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World FAAHAAFMLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly OAJACFAFCNG KKILKFBEMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] EENNGEAKMFG;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World JJBDOGEBBHK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World MFHAIABCKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager CNOHAEKAHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xCB47A0", Offset = "0xCB33A0", VA = "0x180CB47A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public OAJACFAFCNG LALBODAPNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::PEENCLMLKDL<ELGFJHKNNCH> ONJNABHAMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7070C0", Offset = "0x705CC0", VA = "0x1807070C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::PEENCLMLKDL<NPOFMEGBCMP> JONHNNAGDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x694E70", Offset = "0x693A70", VA = "0x180694E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x695830", Offset = "0x694430", VA = "0x180695830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::PEENCLMLKDL<OIFFKKBIOLH> DLPAHNJNGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x698150", Offset = "0x696D50", VA = "0x180698150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6983E0", Offset = "0x696FE0", VA = "0x1806983E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> AABEJCEFACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xCB47E0", Offset = "0xCB33E0", VA = "0x180CB47E0")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] AFNMLBBNFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5672740", Offset = "0x5671340", VA = "0x185672740")]
	public static DEDLBKJDALP KCEHLHPHNME(string MKPDFAEIFFO, HMDFJLNCJCF BMNJICJIDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5672A90", Offset = "0x5671690", VA = "0x185672A90")]
	public DEDLBKJDALP(string MKPDFAEIFFO, HMDFJLNCJCF BMNJICJIDIA = HMDFJLNCJCF.Simulation, JLMJPPBICMJ MGBMBKJJDJF = JLMJPPBICMJ.Default, bool HLLKIIKCMBO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5672580", Offset = "0x5671180", VA = "0x185672580")]
	public ComponentSystemBase HNDNBNFDICE(Type JMPEGNOKOOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2554470", Offset = "0x2553070", VA = "0x182554470")]
	public T HNDNBNFDICE<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5672520", Offset = "0x5671120", VA = "0x185672520")]
	public void GALCEPIJCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5672050", Offset = "0x5670C50", VA = "0x185672050")]
	public void AHCEIOJGJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5672680", Offset = "0x5671280", VA = "0x185672680")]
	public void ILPBNAOCBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x56721F0", Offset = "0x5670DF0", VA = "0x1856721F0")]
	public void DKLJNECPKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x56722C0", Offset = "0x5670EC0", VA = "0x1856722C0")]
	public void EALBLKDAAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x56726E0", Offset = "0x56712E0", VA = "0x1856726E0")]
	public void JIIJNKILPLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5672190", Offset = "0x5670D90", VA = "0x185672190")]
	public void DFPDBOKIFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5672320", Offset = "0x5670F20", VA = "0x185672320")]
	public void ECDKIBOMPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x56720B0", Offset = "0x5670CB0", VA = "0x1856720B0")]
	public void BDBKIAFCJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x56723B0", Offset = "0x5670FB0", VA = "0x1856723B0")]
	public void EJGEMDPHOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x56725A0", Offset = "0x56711A0", VA = "0x1856725A0")]
	internal void HNPDOHCNPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5672110", Offset = "0x5670D10", VA = "0x185672110")]
	private bool CJDGEIDHCGK(ComponentSystemGroup INPEIBCNMCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x56727C0", Offset = "0x56713C0", VA = "0x1856727C0")]
	private void LBBADPFINED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5672410", Offset = "0x5671010", VA = "0x185672410")]
	private ComponentSystemGroup[] FJNDLDPNONP(JLMJPPBICMJ MGBMBKJJDJF, bool FLOGCCMEADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5672250", Offset = "0x5670E50", VA = "0x185672250", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum HMDFJLNCJCF
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
public sealed class ENGJKBODBPN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public JLMJPPBICMJ LEFLEAJHOEM;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum JLMJPPBICMJ
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
public interface AODHPHPILFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type OGFMKMJHNGN
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] MGGFEECCEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class HBLBKDLMNBD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool FPAOHGEMFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD850", Offset = "0x6AC450", VA = "0x1806AD850", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	protected HBLBKDLMNBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class OEJIAGBNNJL : HBLBKDLMNBD
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public OEJIAGBNNJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class GPDKACJMAKJ : HBLBKDLMNBD
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public GPDKACJMAKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class FJBGJNJJNNH : HBLBKDLMNBD
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public FJBGJNJJNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class OHEDMFPCHNC : HBLBKDLMNBD
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public OHEDMFPCHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class PBFLNCPBEHC : HBLBKDLMNBD
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public PBFLNCPBEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class HAPANKCAPFM : HBLBKDLMNBD
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public HAPANKCAPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class IJFIFDAPELI : HBLBKDLMNBD
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public IJFIFDAPELI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class DJPIIOCFNMB : HBLBKDLMNBD
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public DJPIIOCFNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class OKGBINHMDOA : HBLBKDLMNBD
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public OKGBINHMDOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class HGPPPNLMFMK : MJIIMKBBNHK
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public HGPPPNLMFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class IHAINNAIACB : MJIIMKBBNHK
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public IHAINNAIACB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class CBLCLIMDNBH : MJIIMKBBNHK
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public CBLCLIMDNBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class JPNCJBNDHJP : MJIIMKBBNHK
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public JPNCJBNDHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[HHHAKBKHMPJ(EBEBOFNGILK.Application)]
public class MJIIMKBBNHK : HBLBKDLMNBD
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool FPAOHGEMFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670620", VA = "0x185671A20")]
	public MJIIMKBBNHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class HOHJMEEIHJO : CKGBMCJBKPM
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x163ABA0", Offset = "0x16397A0", VA = "0x18163ABA0")]
	public HOHJMEEIHJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class EEMHLNBPKAI
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void ALFOCBOHIAB<From, To>(From CJMCKLJFKJI, ref To AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class JPLLHLMNJFO<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static ALFOCBOHIAB<From, To> GHKLKGOOAEH;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public JPLLHLMNJFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5673230", Offset = "0x5671E30", VA = "0x185673230")]
	static EEMHLNBPKAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0FE0", Offset = "0x2C9FBE0", VA = "0x182CA0FE0")]
	public static void OGPLLPEFEJA<T>(ALFOCBOHIAB<T, T> GLFNOBCDLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0EC0", Offset = "0x2C9FAC0", VA = "0x182CA0EC0")]
	public static void OGPLLPEFEJA<From, To>(ALFOCBOHIAB<From, To> GLFNOBCDLNG, ALFOCBOHIAB<To, From> MFAIANHKEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0E70", Offset = "0x2C9FA70", VA = "0x182CA0E70")]
	public static void OGPLLPEFEJA<From, To>(ALFOCBOHIAB<From, To> GHKLKGOOAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5830", Offset = "0x2CA4430", VA = "0x182CA5830")]
	public static ALFOCBOHIAB<From, To> PLGFPJMHODO<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F230", Offset = "0x2C9DE30", VA = "0x182C9F230")]
	public static void MIEOHBDNLGD<From, To>(From CJMCKLJFKJI, ref To AOGGOAKADIJ, GFBPCLDKMCE OBMKDNADDIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class GFBPCLDKMCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> COPJGAGJGHE;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1362210", Offset = "0x1360E10", VA = "0x181362210")]
	public GFBPCLDKMCE(NativeArray<EntityRemapUtility.EntityRemapInfo> COPJGAGJGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x308BD90", Offset = "0x308A990", VA = "0x18308BD90")]
	public Entity HKMODBJCDHA(Entity CNJLPBGBOKD)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class ECPEFIIAIPJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> OCOLNOJPHIP;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5673040", Offset = "0x5671C40", VA = "0x185673040")]
	public static bool DMAEAGCBKDA(ulong FHKABFEFMDN, uint OLOLCGEOMNE, out string MKPDFAEIFFO)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[GKALNADHNEP(DAHLALKJFLL.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct PBIPBHBEHAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int KLCIKJBGNKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int LKNCJMEJAON;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x702C80", Offset = "0x701880", VA = "0x180702C80")]
			public PBIPBHBEHAK(int KLEGICPDLIF, int OLOLCGEOMNE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct FJCBGFOEHDM
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch BHBHJNHOJNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long PGHNOFMKLFB;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long CFAHOLNJGKC
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x5673F00", Offset = "0x5672B00", VA = "0x185673F00")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long PAFLCKJADHD
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5673E90", Offset = "0x5672A90", VA = "0x185673E90")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5673F60", Offset = "0x5672B60", VA = "0x185673F60")]
			public static FJCBGFOEHDM NEICDGFOHHP()
			{
				return default(FJCBGFOEHDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct GKKBBFIAMCB : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct NEDBFODCDHJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* OPPKEJLNCDC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly EBLBPOHKAIA.OFJBFMEIIAF.IKHGBFOPFKC MNLOJPNMOEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly GFBPCLDKMCE OBMKDNADDIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::PEENCLMLKDL<NPOFMEGBCMP> KDLJOPEEIEB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int NOPJDLFNNEO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int PBPBGJKMKOA;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x5675BE0", Offset = "0x56747E0", VA = "0x185675BE0")]
				public unsafe NEDBFODCDHJ(Unity.Entities.Archetype* OPPKEJLNCDC, EBLBPOHKAIA.OFJBFMEIIAF.IKHGBFOPFKC MNLOJPNMOEF, GFBPCLDKMCE OBMKDNADDIP, global::PEENCLMLKDL<NPOFMEGBCMP> KDLJOPEEIEB, int NOPJDLFNNEO, int PBPBGJKMKOA = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5675C40", Offset = "0x5674840", VA = "0x185675C40")]
				public NEDBFODCDHJ(in NEDBFODCDHJ GAGLKGONONJ, int PBPBGJKMKOA)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly NEDBFODCDHJ[] IBDDKLPMGNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] DPHPCENBEHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int PGAKFPBLKDA;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5674840", Offset = "0x5673440", VA = "0x185674840")]
			public GKKBBFIAMCB(NEDBFODCDHJ[] IBDDKLPMGNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x56747E0", Offset = "0x56733E0", VA = "0x1856747E0", Slot = "4")]
			public void Invoke(int KLEGICPDLIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5674160", Offset = "0x5672D60", VA = "0x185674160")]
			private void GANGDEDOJKH(in NEDBFODCDHJ GAGLKGONONJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5674510", Offset = "0x5673110", VA = "0x185674510")]
			private static void IEOFHMNENNH(in NEDBFODCDHJ GAGLKGONONJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class EMDOAODMCKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public EBLBPOHKAIA asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::PEENCLMLKDL<NPOFMEGBCMP> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public EMDOAODMCKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5673800", Offset = "0x5672400", VA = "0x185673800")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class IACCADGDGIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public EBLBPOHKAIA.OFJBFMEIIAF.IKHGBFOPFKC srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public EMDOAODMCKG CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public IACCADGDGIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class CFJFDPEFDNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public IACCADGDGIO CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public CFJFDPEFDNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5671AB0", Offset = "0x56706B0", VA = "0x185671AB0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly FCNKBCOKGMK OIFMFCIPKIK;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly FCNKBCOKGMK CKDMHIIFFOH;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly FCNKBCOKGMK DGIHBDDAJBO;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly FCNKBCOKGMK OFAKCLCOFBN;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly FCNKBCOKGMK NEPEJNAJKDA;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool IBEBBAAKLGH;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static EBLBPOHKAIA.OFJBFMEIIAF.HPDDJNNHOLF PNEPGIJHGOJ;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5679DF0", Offset = "0x56789F0", VA = "0x185679DF0")]
		private unsafe static bool FJBGLPPKAEP(Unity.Entities.Archetype* JIDCFBAAHAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x567C480", Offset = "0x567B080", VA = "0x18567C480")]
		internal unsafe static Unity.Entities.Archetype*[] OGHMEBEBCJO(ref Unity.Entities.EntityComponentStore FEFBBJHPMCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x567A300", Offset = "0x5678F00", VA = "0x18567A300")]
		public static void KLGJHJHMALA(DEDLBKJDALP EELLGOEIJJC, out ByteString PGJDMPEOAIC, out NativeArray<EntityRemapUtility.EntityRemapInfo> KJHEIHJFOOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x567A3C0", Offset = "0x5678FC0", VA = "0x18567A3C0")]
		internal static void LKOOAPHJCHL(DEDLBKJDALP EELLGOEIJJC, EBLBPOHKAIA FFOEBAHAIEI, out NativeArray<EntityRemapUtility.EntityRemapInfo> KJHEIHJFOOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x567C040", Offset = "0x567AC40", VA = "0x18567C040")]
		private unsafe static UnsafeHashMap<ulong, PBIPBHBEHAK> ODBMFMHNLHK(Unity.Entities.Archetype*[] EDEIPNMEEKH)
		{
			return default(UnsafeHashMap<ulong, PBIPBHBEHAK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x567C2D0", Offset = "0x567AED0", VA = "0x18567C2D0")]
		private static void OFJGKMOIKGI(EBLBPOHKAIA FFOEBAHAIEI, UnsafeHashMap<ulong, PBIPBHBEHAK> MJEIJHJPGON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5679300", Offset = "0x5677F00", VA = "0x185679300")]
		private unsafe static void CHAAIEFNHLE(EBLBPOHKAIA FFOEBAHAIEI, Unity.Entities.Archetype*[] EDEIPNMEEKH, UnsafeHashMap<ulong, PBIPBHBEHAK> MJEIJHJPGON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5679FA0", Offset = "0x5678BA0", VA = "0x185679FA0")]
		private unsafe static int IBACDFOIOLC(Unity.Entities.Archetype*[] EDEIPNMEEKH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x567B150", Offset = "0x5679D50", VA = "0x18567B150")]
		private unsafe static void NAAIBKLLDDB(EBLBPOHKAIA FFOEBAHAIEI, Unity.Entities.Archetype*[] EDEIPNMEEKH, global::PEENCLMLKDL<NPOFMEGBCMP> KDLJOPEEIEB, NativeArray<EntityRemapUtility.EntityRemapInfo> KJHEIHJFOOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x567A090", Offset = "0x5678C90", VA = "0x18567A090")]
		private static NativeArray<int> JAKGCILGBBG(EBLBPOHKAIA FFOEBAHAIEI)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x567BCB0", Offset = "0x567A8B0", VA = "0x18567BCB0")]
		private static Memory<EntityArchetype> OAJGKHJLACB(EBLBPOHKAIA FFOEBAHAIEI, NativeArray<int> HAAPMPEHPPA, EntityManager JOKFOKELNGA, out int EOFNLKLGFCF, out int PIIDCPFBIOB)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x567AAF0", Offset = "0x56796F0", VA = "0x18567AAF0")]
		private unsafe static void LOAILGNFKHI(Unity.Entities.Chunk* KBOLLHMFIJK, ReadOnlySpan<byte> PGJDMPEOAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x567B570", Offset = "0x567A170", VA = "0x18567B570")]
		private static void NDINCOCHPHD(EBLBPOHKAIA FFOEBAHAIEI, NativeArray<int> HAAPMPEHPPA, Span<EntityArchetype> EDEIPNMEEKH, EntityManager JOKFOKELNGA, global::PEENCLMLKDL<NPOFMEGBCMP> KDLJOPEEIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x567A010", Offset = "0x5678C10", VA = "0x18567A010")]
		private unsafe static void ICODAOPJIJB(Unity.Entities.Chunk* AEGPPFELHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x567AE40", Offset = "0x5679A40", VA = "0x18567AE40")]
		private unsafe static void MBPLFFINLDJ(EBLBPOHKAIA.OFJBFMEIIAF.IKHGBFOPFKC OPPKEJLNCDC, int GAFPBGNGCBC, int CFKKKJNOAFF, Unity.Entities.Chunk* KBOLLHMFIJK, EBLBPOHKAIA FFOEBAHAIEI, NativeArray<int> HAAPMPEHPPA, global::PEENCLMLKDL<NPOFMEGBCMP> KDLJOPEEIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5679D60", Offset = "0x5678960", VA = "0x185679D60")]
		public static void EOAINJJAMBE(DEDLBKJDALP EELLGOEIJJC, in ByteString PGJDMPEOAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5679710", Offset = "0x5678310", VA = "0x185679710")]
		public static void EOAINJJAMBE(EntityManager JOKFOKELNGA, global::PEENCLMLKDL<NPOFMEGBCMP> KDLJOPEEIEB, in ByteString PGJDMPEOAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5679040", Offset = "0x5677C40", VA = "0x185679040")]
		private static bool AKMGDGOAJMN(Type JMPEGNOKOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x567C7F0", Offset = "0x567B3F0", VA = "0x18567C7F0")]
		private static void OLPBGLAFOOE(TypeManager.TypeInfo AOMOPBLLPHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x567C660", Offset = "0x567B260", VA = "0x18567C660")]
		private unsafe static int OKIAHMMMJME(Unity.Entities.Archetype*[] EDEIPNMEEKH, NativeArray<EntityRemapUtility.EntityRemapInfo> KJHEIHJFOOP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5679630", Offset = "0x5678230", VA = "0x185679630")]
		private static int ELIOJBPOCHE(int FKPCJKABBEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5679F00", Offset = "0x5678B00", VA = "0x185679F00")]
		private static ulong HMLHNKLCMBB(int FKPCJKABBEA)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class IILFPAGFJPO
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5674D00", Offset = "0x5673900", VA = "0x185674D00")]
	private unsafe static Span<byte> DGBKGIEOPIH(Unity.Entities.Chunk* AEGPPFELHPO, int NOPJDLFNNEO)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C80DF0", Offset = "0x2C7F9F0", VA = "0x182C80DF0")]
	public unsafe static Span<T> OMAKPKOEHAK<T>(Unity.Entities.Chunk* AEGPPFELHPO, int NOPJDLFNNEO)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C80F70", Offset = "0x2C7FB70", VA = "0x182C80F70")]
	public static Span<T> OMAKPKOEHAK<T>(this ref Unity.Entities.Chunk AEGPPFELHPO, int NOPJDLFNNEO)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5675140", Offset = "0x5673D40", VA = "0x185675140")]
	public unsafe static Span<Entity> JDDEDDLADAF(Unity.Entities.Chunk* AEGPPFELHPO)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5674EA0", Offset = "0x5673AA0", VA = "0x185674EA0")]
	public unsafe static void GGNFLDPHLOD(Unity.Entities.Chunk* AEGPPFELHPO, int NOPJDLFNNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x56751B0", Offset = "0x5673DB0", VA = "0x1856751B0")]
	public static Entity PODLCMKEKAG(this EntityQuery GJLGONPKKFL)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : BBLLDMGLLLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x567CD00", Offset = "0x567B900", VA = "0x18567CD00", Slot = "4")]
		public sealed override void LOFJJDLCKCK()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class JKMMEKILHLE
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] AGGHFJMNIJN;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int BFFGPOMCPJB;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int MBPNPBCPPJJ;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger ELICCIFCIHI;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JKMMEKILHLE()
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
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
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

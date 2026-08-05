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
internal static class NNPFIOICGEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x55605E0", Offset = "0x555F9E0", VA = "0x1855605E0")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> MLPDEDPOEFJ(this ref Unity.Entities.Archetype GMPHNAMECNH)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MFGFHLDFINI
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x555F8D0", Offset = "0x555ECD0", VA = "0x18555F8D0")]
	public static Span<int> JNPIJJIAMKD(this EntityArchetype GMPHNAMECNH)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FKLACEANAAH
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FPNBLGBEAAE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x555ECB0", Offset = "0x555E0B0", VA = "0x18555ECB0")]
	public static bool EFFOACKHLFJ(this Entity NOADJCMIKEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DDNPLECOPMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[BurstCompile]
	private struct KKOANDCEHMO<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[ReadOnly]
		public NativeArray<Entity> CLKOPKILJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[WriteOnly]
		public ComponentDataFromEntity<T> OKDMFPLDKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public T IGDJJEECDAF;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2969360", Offset = "0x2968760", VA = "0x182969360", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[BurstCompile]
	private struct FDBPKMBJPAJ<T> : IJobChunk where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[WriteOnly]
		public ArchetypeChunkComponentType<T> IOGIPHKAFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T IGDJJEECDAF;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26BFB70", Offset = "0x26BEF70", VA = "0x1826BFB70")]
	public static void NIIPFPJCENJ<T>(this EntityManager GKHNMAAJNKF, NativeArray<Entity> NPCFKLDOKOP, T IGDJJEECDAF) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26BE9F0", Offset = "0x26BDDF0", VA = "0x1826BE9F0")]
	public static void EFABJDNHKNO<T>(this EntityManager GKHNMAAJNKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x26BEAF0", Offset = "0x26BDEF0", VA = "0x1826BEAF0")]
	public static void IIEBLDAHFHG<T>(this EntityManager GKHNMAAJNKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x26BFC00", Offset = "0x26BF000", VA = "0x1826BFC00")]
	public static JobHandle OOJHOGFGIJF<T>(this EntityManager GKHNMAAJNKF) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x555D690", Offset = "0x555CA90", VA = "0x18555D690")]
	public static JobHandle OOJHOGFGIJF(this EntityManager GKHNMAAJNKF, int LGKEBNGGJEG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HHAMBFINAPJ<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FNKPADKOIID : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::HHAMBFINAPJ<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x699040", Offset = "0x698440", VA = "0x180699040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x25D86E0", Offset = "0x25D7AE0", VA = "0x1825D86E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1BB2500", Offset = "0x1BB1900", VA = "0x181BB2500")]
		[DebuggerHidden]
		public FNKPADKOIID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x25D8500", Offset = "0x25D7900", VA = "0x1825D8500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x25D86A0", Offset = "0x25D7AA0", VA = "0x1825D86A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> ALJPKIMIKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream DJGPEPEBOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream NBBFIKKLCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf MPEKIBHBCCO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int GCBADAOHFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x678010", Offset = "0x677410", VA = "0x180678010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0400", Offset = "0x2FCF800", VA = "0x182FD0400")]
	private HHAMBFINAPJ(byte[] CCBBJEPJPEO, Action<Protobuf> ALJPKIMIKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x23E15E0", Offset = "0x23E09E0", VA = "0x1823E15E0")]
	public static global::HHAMBFINAPJ<Protobuf> FNICMNFMKAL<Data>(ReadOnlySpan<byte> BIPDDAIIHHG, ReadOnlySpan<Data> KOPDMFDFEFH, Action<Protobuf> ALJPKIMIKLH)
	{
		return default(global::HHAMBFINAPJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0270", Offset = "0x2FCF670", VA = "0x182FD0270", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2FD02B0", Offset = "0x2FCF6B0", VA = "0x182FD02B0", Slot = "4")]
	[IteratorStateMachine(typeof(global::HHAMBFINAPJ<>.FNKPADKOIID))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2FD03B0", Offset = "0x2FCF7B0", VA = "0x182FD03B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NJEGEFEKCHO<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] CCBBJEPJPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf MPEKIBHBCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream DJGPEPEBOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream EIBKKECAKGB;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x39C3DD0", Offset = "0x39C31D0", VA = "0x1839C3DD0")]
	private NJEGEFEKCHO(byte[] CCBBJEPJPEO, in Protobuf MPEKIBHBCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2424720", Offset = "0x2423B20", VA = "0x182424720")]
	public static global::NJEGEFEKCHO<Protobuf> FNICMNFMKAL<T>(ReadOnlySpan<T> KOPDMFDFEFH)
	{
		return default(global::NJEGEFEKCHO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x39C3D10", Offset = "0x39C3110", VA = "0x1839C3D10")]
	public void HFJNIBPCGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x39C3D40", Offset = "0x39C3140", VA = "0x1839C3D40")]
	public ByteString JBEFKGNAIAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x39C3BE0", Offset = "0x39C2FE0", VA = "0x1839C3BE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct AOPEFKKCIHN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream DJGPEPEBOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream NBBFIKKLCLP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x555CE80", Offset = "0x555C280", VA = "0x18555CE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct FOMGCFDPFJC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] CCBBJEPJPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream DJGPEPEBOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream EIBKKECAKGB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x555EB80", Offset = "0x555DF80", VA = "0x18555EB80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NLBEKPHCJJO
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void OLDAPGGENJG(this DLHDGHMPCLG HCDIHNPPHMM, NativeArray<Entity> NPCFKLDOKOP, [Optional][CallerFilePath] string DNJACPJDGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void OLDAPGGENJG(this DLHDGHMPCLG HCDIHNPPHMM, string DHKKANIEGMN, NativeArray<Entity> NPCFKLDOKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void OLDAPGGENJG(this DLHDGHMPCLG HCDIHNPPHMM, string DNJACPJDGNO, NativeArray<Entity> NPCFKLDOKOP, bool HOJCMPMFJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void ANOGGNGLAKL(this DLHDGHMPCLG HCDIHNPPHMM, NativeArray<Entity> NPCFKLDOKOP, NativeArray<Entity> INBNACIKDKM, [Optional][CallerFilePath] string DNJACPJDGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void ANOGGNGLAKL(this DLHDGHMPCLG HCDIHNPPHMM, string DNJACPJDGNO, NativeArray<Entity> NPCFKLDOKOP, NativeArray<Entity> INBNACIKDKM, bool HOJCMPMFJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30DFAC0", Offset = "0x30DEEC0", VA = "0x1830DFAC0")]
	public static void IOCNIOHGEOI<T>(this DLHDGHMPCLG HCDIHNPPHMM, string DHKKANIEGMN, NativeArray<Entity> NPCFKLDOKOP, NativeList<T> PNMIIEJFOON) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x30DFA80", Offset = "0x30DEE80", VA = "0x1830DFA80")]
	public static void IOCNIOHGEOI<T>(this DLHDGHMPCLG HCDIHNPPHMM, string DHKKANIEGMN, NativeArray<Entity> NPCFKLDOKOP, NativeArray<T> PNMIIEJFOON) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void IOCNIOHGEOI<T>(this DLHDGHMPCLG HCDIHNPPHMM, string DNJACPJDGNO, NativeArray<Entity> NPCFKLDOKOP, NativeArray<T> PNMIIEJFOON, bool HOJCMPMFJFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30DF9E0", Offset = "0x30DEDE0", VA = "0x1830DF9E0")]
	public static void GHHCDLLGKBB<T>(this DLHDGHMPCLG HCDIHNPPHMM, NativeList<T> PNMIIEJFOON, [Optional][CallerFilePath] string DNJACPJDGNO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x30DF9B0", Offset = "0x30DEDB0", VA = "0x1830DF9B0")]
	public static void GHHCDLLGKBB<T>(this DLHDGHMPCLG HCDIHNPPHMM, NativeArray<T> PNMIIEJFOON, [Optional][CallerFilePath] string DNJACPJDGNO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void GHHCDLLGKBB<T>(this DLHDGHMPCLG HCDIHNPPHMM, string DNJACPJDGNO, NativeArray<T> PNMIIEJFOON, bool HOJCMPMFJFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void IJAMAABEGJM(this DLHDGHMPCLG HCDIHNPPHMM, EntityQuery JHDPAHIHIEJ, [Optional][CallerFilePath] string DNJACPJDGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void IJAMAABEGJM(this DLHDGHMPCLG HCDIHNPPHMM, string DHKKANIEGMN, EntityQuery JHDPAHIHIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void IJAMAABEGJM(this DLHDGHMPCLG HCDIHNPPHMM, string DNJACPJDGNO, EntityQuery JHDPAHIHIEJ, bool HOJCMPMFJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x30DFA50", Offset = "0x30DEE50", VA = "0x1830DFA50")]
	public static void HKOHFMMAOBG<T, T2>(this DLHDGHMPCLG HCDIHNPPHMM, string DHKKANIEGMN, EntityQuery JHDPAHIHIEJ) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	private static void HKOHFMMAOBG<T, T2>(this DLHDGHMPCLG HCDIHNPPHMM, string DNJACPJDGNO, EntityQuery JHDPAHIHIEJ, bool HOJCMPMFJFK) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IOPHLCGDAFI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NFHBINEABBA DHGMGGCIKCI
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
public interface HNIPCOLCLNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMOBLPOFNMC(Entity NOADJCMIKEF, object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIKPHDOHABL(Entity NOADJCMIKEF, object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JNPAKENCLIA(Entity NOADJCMIKEF);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JNPAKENCLIA(NFHBINEABBA CPAMCPHEBME);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> GLKPAFFADFL(Entity NOADJCMIKEF);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JEEEGKGOFND(Entity NOADJCMIKEF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GBMKOGAENAJ<TComponentData, TValue> : global::LMHJIKMILKO<TValue>, IDisposable where TComponentData : struct, IOPHLCGDAFI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class BJEIJIEAHMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> MOBONMBAIDJ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int IGGNICCPKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEDA0", Offset = "0x1FAE1A0", VA = "0x181FAEDA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x238ECC0", Offset = "0x238E0C0", VA = "0x18238ECC0")]
		public bool LGANPLKPOBH(out TValue IGDJJEECDAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x238EB90", Offset = "0x238DF90", VA = "0x18238EB90")]
		public void AKBMAMDKLNI(object MJNGPHMPILM, TValue IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x238EC40", Offset = "0x238E040", VA = "0x18238EC40")]
		public bool GKDAOIMBAHJ(object MJNGPHMPILM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x238ED80", Offset = "0x238E180", VA = "0x18238ED80")]
		public int PIPJCOJIJLM(object MJNGPHMPILM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x238EE30", Offset = "0x238E230", VA = "0x18238EE30")]
		public BJEIJIEAHMB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<BJEIJIEAHMB> FCCCBEOBLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::DAMBNPJKGIF<NFHBINEABBA, BJEIJIEAHMB> MFEOBMPCAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager GKHNMAAJNKF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2D3A480", Offset = "0x2D39880", VA = "0x182D3A480")]
	public GBMKOGAENAJ(EntityManager GKHNMAAJNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D39EA0", Offset = "0x2D392A0", VA = "0x182D39EA0", Slot = "4")]
	public void FMOBLPOFNMC(Entity NOADJCMIKEF, object MJNGPHMPILM, TValue IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2D3A250", Offset = "0x2D39650", VA = "0x182D3A250", Slot = "5")]
	public bool LIKPHDOHABL(Entity NOADJCMIKEF, object MJNGPHMPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D3A180", Offset = "0x2D39580", VA = "0x182D3A180", Slot = "6")]
	public bool LGANPLKPOBH(Entity NOADJCMIKEF, out TValue IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2D39E60", Offset = "0x2D39260", VA = "0x182D39E60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2D39FC0", Offset = "0x2D393C0", VA = "0x182D39FC0")]
	private void GOABEGCGPDH(BJEIJIEAHMB FCAECNPFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2D3A0D0", Offset = "0x2D394D0", VA = "0x182D3A0D0")]
	private bool LAFMCLOKAEF(Entity NOADJCMIKEF, out NFHBINEABBA CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D3A040", Offset = "0x2D39440", VA = "0x182D3A040")]
	private void HBKNCEPMJKN(Entity NOADJCMIKEF, NFHBINEABBA CPAMCPHEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D39E80", Offset = "0x2D39280", VA = "0x182D39E80")]
	private bool EGPLCGGHDOI(NFHBINEABBA CPAMCPHEBME, out BJEIJIEAHMB FCAECNPFBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D3A3C0", Offset = "0x2D397C0", VA = "0x182D3A3C0")]
	private BJEIJIEAHMB OAMOANIAGHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LMHJIKMILKO<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMOBLPOFNMC(Entity NOADJCMIKEF, object MJNGPHMPILM, TValue IGDJJEECDAF);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIKPHDOHABL(Entity NOADJCMIKEF, object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LGANPLKPOBH(Entity NOADJCMIKEF, out TValue IGDJJEECDAF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NFHBINEABBA : global::GPFPNOKLPCO<NFHBINEABBA>, PIEOKMGFPCE, IEquatable<NFHBINEABBA>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly NFHBINEABBA EAAMJEPFANE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int IJHDILKKDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x729E20", Offset = "0x729220", VA = "0x180729E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x729D90", Offset = "0x729190", VA = "0x180729D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int BBEGHBAAMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6B60", Offset = "0x8B5F60", VA = "0x1808B6B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xEAA170", Offset = "0xEA9570", VA = "0x180EAA170", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5560360", Offset = "0x555F760", VA = "0x185560360", Slot = "8")]
	public bool Equals(NFHBINEABBA EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x55603B0", Offset = "0x555F7B0", VA = "0x1855603B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PBPLGHILKPA<T> : HNIPCOLCLNG, IDisposable where T : struct, IOPHLCGDAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> FCCCBEOBLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::DAMBNPJKGIF<NFHBINEABBA, HashSet<object>> MFEOBMPCAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager GKHNMAAJNKF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x37576B0", Offset = "0x3756AB0", VA = "0x1837576B0")]
	public PBPLGHILKPA(EntityManager GKHNMAAJNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3754F70", Offset = "0x3754370", VA = "0x183754F70", Slot = "4")]
	public bool FMOBLPOFNMC(Entity NOADJCMIKEF, object MJNGPHMPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3756C20", Offset = "0x3756020", VA = "0x183756C20", Slot = "5")]
	public bool LIKPHDOHABL(Entity NOADJCMIKEF, object MJNGPHMPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x28D41D0", Offset = "0x28D35D0", VA = "0x1828D41D0", Slot = "6")]
	public bool JNPAKENCLIA(Entity NOADJCMIKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x37563D0", Offset = "0x37557D0", VA = "0x1837563D0", Slot = "7")]
	public bool JNPAKENCLIA(NFHBINEABBA CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3755470", Offset = "0x3754870", VA = "0x183755470", Slot = "8")]
	public IEnumerable<object> GLKPAFFADFL(Entity NOADJCMIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x37555D0", Offset = "0x37549D0", VA = "0x1837555D0", Slot = "11")]
	public IEnumerable<object> GLKPAFFADFL(NFHBINEABBA CPAMCPHEBME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3755F70", Offset = "0x3755370", VA = "0x183755F70", Slot = "9")]
	public bool JEEEGKGOFND(Entity NOADJCMIKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3754E70", Offset = "0x3754270", VA = "0x183754E70", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3755AD0", Offset = "0x3754ED0", VA = "0x183755AD0")]
	private void GOABEGCGPDH(HashSet<object> FCAECNPFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3756650", Offset = "0x3755A50", VA = "0x183756650")]
	private bool LAFMCLOKAEF(Entity NOADJCMIKEF, out NFHBINEABBA CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3756D70", Offset = "0x3756170", VA = "0x183756D70")]
	private bool MEDNFNOGFFA(Entity NOADJCMIKEF, out NFHBINEABBA CPAMCPHEBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x28D3D60", Offset = "0x28D3160", VA = "0x1828D3D60")]
	private void GAJEBFMAHEL(Entity NOADJCMIKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3755D60", Offset = "0x3755160", VA = "0x183755D60")]
	private void HBKNCEPMJKN(Entity NOADJCMIKEF, NFHBINEABBA CPAMCPHEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3755F10", Offset = "0x3755310", VA = "0x183755F10")]
	private bool HCGAKGNEPAK(NFHBINEABBA CPAMCPHEBME, out HashSet<object> FCAECNPFBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3757270", Offset = "0x3756670", VA = "0x183757270")]
	private HashSet<object> OAMOANIAGHB()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NNMBJFGFFOA : global::AKPAEOLPEJO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x55605D0", Offset = "0x555F9D0", VA = "0x1855605D0", Slot = "4")]
	public float PEHJMPIOOEN(float3 IGDJJEECDAF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct AMMNBAJFCDC : global::AKPAEOLPEJO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x555CE70", Offset = "0x555C270", VA = "0x18555CE70", Slot = "4")]
	public float PEHJMPIOOEN(float3 IGDJJEECDAF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EHJCBDNGGBK : global::AKPAEOLPEJO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x555DB90", Offset = "0x555CF90", VA = "0x18555DB90", Slot = "4")]
	public float PEHJMPIOOEN(float3 IGDJJEECDAF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct OHLEGJDJEMC : global::AKPAEOLPEJO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1172D90", Offset = "0x1172190", VA = "0x181172D90", Slot = "4")]
	public int PEHJMPIOOEN(int3 IGDJJEECDAF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HMOPBKKNBJN : global::AKPAEOLPEJO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x15B2C70", Offset = "0x15B2070", VA = "0x1815B2C70", Slot = "4")]
	public int PEHJMPIOOEN(int3 IGDJJEECDAF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GDLOJKGEBHE : global::AKPAEOLPEJO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x555F270", Offset = "0x555E670", VA = "0x18555F270", Slot = "4")]
	public int PEHJMPIOOEN(int3 IGDJJEECDAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class GNJJKECMKGK : GKLONNNGPKI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type JNJMKIOJLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x697530", VA = "0x180698130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xF70D50", Offset = "0xF70150", VA = "0x180F70D50")]
	public GNJJKECMKGK(Type IIHGJHACHCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MNBFNOGKLGN : GNJJKECMKGK
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xF70D50", Offset = "0xF70150", VA = "0x180F70D50")]
	public MNBFNOGKLGN(Type IIHGJHACHCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CFGIJCOJHCL : GNJJKECMKGK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type MFOBCLBGGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x697540", VA = "0x180698140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x555D1B0", Offset = "0x555C5B0", VA = "0x18555D1B0")]
	public CFGIJCOJHCL(Type HNHLLOFDHOI, Type IIHGJHACHCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AGANJGMMKAI : GNJJKECMKGK
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xF70D50", Offset = "0xF70150", VA = "0x180F70D50")]
	public AGANJGMMKAI(Type IIHGJHACHCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NIILAANKHKM : GKLONNNGPKI
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public NIILAANKHKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AJKBHFMLMDJ : GKLONNNGPKI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ODCPNHEJLHH OMPHMKEDIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677440", VA = "0x180678040")]
		[CompilerGenerated]
		get
		{
			return default(ODCPNHEJLHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xF70CE0", Offset = "0xF700E0", VA = "0x180F70CE0")]
	public AJKBHFMLMDJ(ODCPNHEJLHH AOFGAGALOCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class GDHFGEGLFMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly FBFMDKPKBLB KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager GKHNMAAJNKF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FBFMDKPKBLB GEMNOHGEBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x555F220", Offset = "0x555E620", VA = "0x18555F220")]
	public GDHFGEGLFMK(FBFMDKPKBLB KIEEJCIFMFE, EntityManager GKHNMAAJNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2C97E20", Offset = "0x2C97220", VA = "0x182C97E20")]
	public bool CPNCDOOCHMA<T>(Entity NOADJCMIKEF) where T : struct, HCHCPMMFEAE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2C99840", Offset = "0x2C98C40", VA = "0x182C99840")]
	public bool MJFCKBCGHNF<T>(Entity NOADJCMIKEF, out T IGDJJEECDAF) where T : struct, HCHCPMMFEAE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2C97E60", Offset = "0x2C97260", VA = "0x182C97E60")]
	public T MHCKHLPDNAK<T>(Entity NOADJCMIKEF) where T : struct, HCHCPMMFEAE
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2C97620", Offset = "0x2C96A20", VA = "0x182C97620")]
	private ComponentType AEANDDDLOND<T>() where T : struct, HCHCPMMFEAE
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x555F150", Offset = "0x555E550", VA = "0x18555F150")]
	private ComponentType AEANDDDLOND(Type FPPBLNEEHBP)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class IMCJFCGBGHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	protected IMCJFCGBGHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class LFMDPLAMAOB<View, Data> : GAPCPBFJDMJ where View : struct, HCHCPMMFEAE where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType JDJHNEGAOHH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type GPFKCOKKNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x38888F0", Offset = "0x3887CF0", VA = "0x1838888F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type MHMFKIIJGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3887960", Offset = "0x3886D60", VA = "0x183887960", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int CMMIKAMNDII
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3888530", Offset = "0x3887930", VA = "0x183888530", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3889670", Offset = "0x3888A70", VA = "0x183889670")]
	public Data MCIPNONLGBA(Entity NOADJCMIKEF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x38896E0", Offset = "0x3888AE0", VA = "0x1838896E0")]
	public Data MOAMEDLLJJD(Entity NOADJCMIKEF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View AMJFGAPBBJL(Entity NOADJCMIKEF);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x23E7D10", Offset = "0x23E7110", VA = "0x1823E7D10", Slot = "15")]
	protected internal override T AMJFGAPBBJL<T>(Entity NOADJCMIKEF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x11101F0", Offset = "0x110F5F0", VA = "0x1811101F0")]
	protected LFMDPLAMAOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class GAPCPBFJDMJ : HBHFLIIDJCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic EIMBLADOOBG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager HDMAFEMIPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x839A50", Offset = "0x838E50", VA = "0x180839A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type GPFKCOKKNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type MHMFKIIJGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int CMMIKAMNDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type GFMKIDGKKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x796800", Offset = "0x795C00", VA = "0x180796800", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int ODPHONJPODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x555EF10", Offset = "0x555E310", VA = "0x18555EF10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private FPGGICJALNG[] JOPJBBPCIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x796730", Offset = "0x795B30", VA = "0x180796730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual FPGGICJALNG[] PJDMIDKLEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x555ECD0", Offset = "0x555E0D0", VA = "0x18555ECD0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GKLPFKAPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x555EEE0", Offset = "0x555E2E0", VA = "0x18555EEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x555EF80", Offset = "0x555E380", VA = "0x18555EF80")]
	public void LJAJKOINHPD(EntityManager GKHNMAAJNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
	protected HBHFLIIDJCA NKLLGMGKOND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T AMJFGAPBBJL<T>(Entity NOADJCMIKEF) where T : struct, HCHCPMMFEAE;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x555EE20", Offset = "0x555E220", VA = "0x18555EE20", Slot = "8")]
	public (uint, uint) FJFKOLNMONB(Entity NOADJCMIKEF)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x555ED90", Offset = "0x555E190", VA = "0x18555ED90", Slot = "9")]
	public bool DKIINAMGGNL(Entity NOADJCMIKEF, (uint order, uint change) FMCKDMNHLLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	protected GAPCPBFJDMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class KGBEHDPOOPH<Data> : BEECNEOJECG where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data BKIMHMJINMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x32A5E20", Offset = "0x32A5220", VA = "0x1832A5E20", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2284750", Offset = "0x2283B50", VA = "0x182284750", Slot = "8")]
	protected virtual bool KPCOEHPAIKM(ReadOnlySpan<Data> KOPDMFDFEFH, OBEFJIDEFOJ JDIPGKNLNAI, out ReadOnlySpan<byte> BIPDDAIIHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "9")]
	protected virtual bool LBDKCIOBKJO(int FMCKDMNHLLD, Span<Data> KOPDMFDFEFH, in ReadOnlySpan<byte> BIPDDAIIHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x32A5EA0", Offset = "0x32A52A0", VA = "0x1832A5EA0", Slot = "5")]
	internal sealed override bool KPCOEHPAIKM(ref Unity.Entities.Chunk PPHKNFIBCEA, int DFPGLGOFFMO, OBEFJIDEFOJ JDIPGKNLNAI, out ReadOnlySpan<byte> BIPDDAIIHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x32A6400", Offset = "0x32A5800", VA = "0x1832A6400", Slot = "6")]
	internal sealed override bool LBDKCIOBKJO(int FMCKDMNHLLD, ref Unity.Entities.Chunk PPHKNFIBCEA, int DFPGLGOFFMO, in ReadOnlySpan<byte> BIPDDAIIHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x23E7740", Offset = "0x23E6B40", VA = "0x1823E7740")]
	protected global::NJEGEFEKCHO<Protobuf> CFDNFKIBNMA<Protobuf>(ReadOnlySpan<Data> KOPDMFDFEFH) where Protobuf : IMessage, new()
	{
		return default(global::NJEGEFEKCHO<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x23E76B0", Offset = "0x23E6AB0", VA = "0x1823E76B0")]
	protected global::HHAMBFINAPJ<Protobuf> BDKFLFLOFCJ<Protobuf>(ReadOnlySpan<byte> BIPDDAIIHHG, ReadOnlySpan<Data> KOPDMFDFEFH, Action<Protobuf> ALJPKIMIKLH) where Protobuf : IMessage, new()
	{
		return default(global::HHAMBFINAPJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x11101F0", Offset = "0x110F5F0", VA = "0x1811101F0")]
	protected KGBEHDPOOPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class BEECNEOJECG
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int BBEGHBAAMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x555CEC0", Offset = "0x555C2C0", VA = "0x18555CEC0", Slot = "5")]
	internal virtual bool KPCOEHPAIKM(ref Unity.Entities.Chunk PPHKNFIBCEA, int DFPGLGOFFMO, OBEFJIDEFOJ JDIPGKNLNAI, out ReadOnlySpan<byte> BIPDDAIIHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "6")]
	internal virtual bool LBDKCIOBKJO(int FMCKDMNHLLD, ref Unity.Entities.Chunk PPHKNFIBCEA, int DFPGLGOFFMO, in ReadOnlySpan<byte> BIPDDAIIHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	protected BEECNEOJECG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface AKPAEOLPEJO<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo PEHJMPIOOEN(TFrom IGDJJEECDAF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CPLBGBCKOOC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FODMILMEMBK(T IGDJJEECDAF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct FGBNAAMNCOH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::AKPAEOLPEJO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> GJNFEGKHHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> HJNOGGCIBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap LECDCDLGAEL;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct IKJLNCLCBMF<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::AKPAEOLPEJO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> HOIHDEGAHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> HJNOGGCIBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap LECDCDLGAEL;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct AIIFFDBCGHM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NNBBLGMPNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> GJNFEGKHHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> HJNOGGCIBBJ;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x38C3D20", Offset = "0x38C3120", VA = "0x1838C3D20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct MGNJIKAOCEC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NNBBLGMPNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> GJNFEGKHHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> JDGJAANJJKB;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct LONHHGPAIKI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::AKPAEOLPEJO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> BJAMACJLIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> HJNOGGCIBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap LECDCDLGAEL;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct FGPBLLJMHMJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IIHGJHACHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> CLKOPKILJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> LOEALFGMMJO;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct HJKMGACKKBG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IIHGJHACHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> CLKOPKILJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> LOEALFGMMJO;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F5B0", Offset = "0x2A3E9B0", VA = "0x182A3F5B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct NCCMLMAKLMK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> GJNFEGKHHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> JDGJAANJJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, IMOBLFIBELG> GKDAJBJDGBP;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2F8BD30", Offset = "0x2F8B130", VA = "0x182F8BD30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct COOCEDCJNKF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::AKPAEOLPEJO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> GJNFEGKHHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> JDGJAANJJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, IMOBLFIBELG> GKDAJBJDGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap LECDCDLGAEL;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct JNHFCAFLGFD<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::CPLBGBCKOOC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> GJNFEGKHHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> JDGJAANJJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate LECDCDLGAEL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct EHGKIGDDIEM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public GHPFKCKCCJM IIHGJHACHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> CLKOPKILJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> MINJMODGMLF;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x555DB00", Offset = "0x555CF00", VA = "0x18555DB00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct KEBGBJABCEC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public GHPFKCKCCJM IIHGJHACHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> CLKOPKILJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> MINJMODGMLF;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x555F610", Offset = "0x555EA10", VA = "0x18555F610", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class GAEPPPIFACE
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class ODAGLIOJKCN
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4D10", Offset = "0x1FB4110", VA = "0x181FB4D10")]
	public static bool JLIEBCHCKHA<T>(this NativeArray<Entity> CLKOPKILJMP, EntityManager GKHNMAAJNKF, Allocator JLPBABJNDBH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class ABALCKFBLOC
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class PFPLHIIGDIN<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public PFPLHIIGDIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class EOIOICCPBCD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public EOIOICCPBCD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> BACDGNFIBJB;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x555CB30", Offset = "0x555BF30", VA = "0x18555CB30")]
	public ABALCKFBLOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class PDMOEEFJKNM
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EHCBINIANNM
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct AHOEHMAMGJG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct NKPFGGANMIN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal AHOEHMAMGJG<TFrom> JFCNGAACNEO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator JLPBABJNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> OHCPCHAKDAC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct OILEGMGBOEG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct LHAABHLNJNM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal OILEGMGBOEG<TFrom> JFCNGAACNEO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator JLPBABJNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> OHCPCHAKDAC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct MKNFBBDCHIC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct HPCPDGAJPFJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal MKNFBBDCHIC<TFrom> JFCNGAACNEO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator JLPBABJNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal global::OPHMNPOEIJD<TFrom> OHCPCHAKDAC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct LHPJPHPNBCG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct PIMIOKKEAEK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal LHPJPHPNBCG<TFrom> JFCNGAACNEO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator JLPBABJNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal global::LAJJDKPAKGO<TFrom> OHCPCHAKDAC;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class ILPHJOFELME
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class GIAPPGILBFP
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C9AF10", Offset = "0x2C9A310", VA = "0x182C9AF10")]
	public static NativeList<T> NMBPEALNFJN<T>(this NativeArray<T> KCLKDAEJBKE, Allocator JLPBABJNDBH = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class PAGFHNOIBOH
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2E90", Offset = "0x1FC2290", VA = "0x181FC2E90")]
	public static NativeArray<T> LNODMLOJHMM<T>(this NativeList<Entity> KCLKDAEJBKE, EntityManager GKHNMAAJNKF, Allocator JLPBABJNDBH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2D90", Offset = "0x1FC2190", VA = "0x181FC2D90")]
	public static NativeArray<T> LNODMLOJHMM<T>(this NativeArray<Entity> KCLKDAEJBKE, EntityManager GKHNMAAJNKF, Allocator JLPBABJNDBH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class CNJCKPOJKEF
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct GIGCMCBMCPI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct IGFKMCECNDA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public GIGCMCBMCPI<TFrom> OHCPCHAKDAC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator JLPBABJNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> GJNFEGKHHIG;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct CPEOBLEAIKJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct MEDBPJDOMKO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public CPEOBLEAIKJ<TFrom> OHCPCHAKDAC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator JLPBABJNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public global::OPHMNPOEIJD<TFrom> GJNFEGKHHIG;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct KJEIHKOKIPN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct HGCJAAMNOPJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public KJEIHKOKIPN<TFrom> OHCPCHAKDAC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator JLPBABJNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public global::LAJJDKPAKGO<TFrom> GJNFEGKHHIG;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OGALJCBKGFJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class FAILBIGEHHM
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct PFHADKDNPFI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator JLPBABJNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> GJNFEGKHHIG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct PDMIIPKKAAC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator JLPBABJNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> GJNFEGKHHIG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct FNKMJDEKGFD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator JLPBABJNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public global::OPHMNPOEIJD<T> GJNFEGKHHIG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct ALMHGOBNCGM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator JLPBABJNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public global::LAJJDKPAKGO<T> GJNFEGKHHIG;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class HPJGOGAGEBK
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class JFDFFIABBBP
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F7E0", Offset = "0x2D0EBE0", VA = "0x182D0F7E0")]
	public static NativeList<Entity> DELCEPOAPLE<T>(this NativeArray<Entity> CLKOPKILJMP, EntityManager GKHNMAAJNKF, Allocator JLPBABJNDBH = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class HPABBJMHMGP
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface ILMKFJJIJEL
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface DFGLIEIJHKB
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class CNNLLPBNHNA
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class CBELBLCMEBC
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x555CFD0", Offset = "0x555C3D0", VA = "0x18555CFD0")]
	public static bool CKNCENBPGGD(Type FPPBLNEEHBP, Type FJBOJJEIMFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class POAKIHDOPOB<Attribute, BaseClass> : global::ONPOFKDAOMC<BaseClass>, CMGNOKEPMHL where Attribute : GNJJKECMKGK
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly DLHDGHMPCLG HCDIHNPPHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string DHKKANIEGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> MDIPFIJIPBA;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2DCA470", Offset = "0x2DC9870", VA = "0x182DCA470")]
	public POAKIHDOPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2DCA0F0", Offset = "0x2DC94F0", VA = "0x182DCA0F0", Slot = "4")]
	public bool BJDJCLJIFEK(int LGKEBNGGJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2DC9E40", Offset = "0x2DC9240", VA = "0x182DC9E40", Slot = "5")]
	public global::ECNCBCGDDPA<BaseClass> BCLEHMKHLKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2DCA150", Offset = "0x2DC9550", VA = "0x182DCA150", Slot = "7")]
	protected virtual bool CKNCENBPGGD(Type FPPBLNEEHBP, int EJBKKAKOPGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2DCA250", Offset = "0x2DC9650", VA = "0x182DCA250", Slot = "8")]
	protected virtual int HPMKHAEHNPI(Type FPPBLNEEHBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2DCA380", Offset = "0x2DC9780", VA = "0x182DCA380")]
	public void PJNICPDDEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2DCA2E0", Offset = "0x2DC96E0", VA = "0x182DCA2E0", Slot = "6")]
	public void JGOJGDHNHPP(Type FPPBLNEEHBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class ECNCBCGDDPA<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> FCBMBAKBDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> BFJGOBBCMNE;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> FFEMCJLANBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3D15F10", Offset = "0x3D15310", VA = "0x183D15F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3D16210", Offset = "0x3D15610", VA = "0x183D16210")]
	public ECNCBCGDDPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3D163A0", Offset = "0x3D157A0", VA = "0x183D163A0")]
	public ECNCBCGDDPA(int OAKAJHNNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3D15E90", Offset = "0x3D15290", VA = "0x183D15E90")]
	internal void AKBMAMDKLNI(int LGKEBNGGJEG, BaseClass BPDPPIDNPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x23DD690", Offset = "0x23DCA90", VA = "0x1823DD690")]
	public bool BCEBPPEODLI<T>(out BaseClass IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3D16140", Offset = "0x3D15540", VA = "0x183D16140")]
	public bool BCEBPPEODLI(Type JNPJOKNNCJF, out BaseClass IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x28E3600", Offset = "0x28E2A00", VA = "0x1828E3600")]
	public bool DIIDHGJDCID(int LGKEBNGGJEG, out BaseClass IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x23DE3A0", Offset = "0x23DD7A0", VA = "0x1823DE3A0")]
	public T CBBPLCHGBLO<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3D161E0", Offset = "0x3D155E0", VA = "0x183D161E0")]
	public BaseClass CBBPLCHGBLO(Type HFIPLDEKLHH)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class IBMGMIEDIPG : global::POAKIHDOPOB<MNBFNOGKLGN, IMCJFCGBGHJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x555F4A0", Offset = "0x555E8A0", VA = "0x18555F4A0")]
	public IBMGMIEDIPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FNDCCMCBHOD : global::POAKIHDOPOB<CFGIJCOJHCL, GAPCPBFJDMJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x555EB10", Offset = "0x555DF10", VA = "0x18555EB10")]
	public FNDCCMCBHOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class KHECIBGBBJM : global::POAKIHDOPOB<AGANJGMMKAI, BEECNEOJECG>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x555F6A0", Offset = "0x555EAA0", VA = "0x18555F6A0")]
	public KHECIBGBBJM()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[JLJFNDDLCBO(CBGNDNDJKHL.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> NONJEDCGPEF;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x88DB80", Offset = "0x88CF80", VA = "0x18088DB80")]
		private ComponentSystemTypes(List<Type> NONJEDCGPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x555D5B0", Offset = "0x555C9B0", VA = "0x18555D5B0")]
		public static void PJNICPDDEAL(List<Type> NONJEDCGPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x555D370", Offset = "0x555C770", VA = "0x18555D370")]
		private void OOMONBLFGCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x555D290", Offset = "0x555C690", VA = "0x18555D290")]
		private bool CKNCENBPGGD(Type FPPBLNEEHBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x555D310", Offset = "0x555C710", VA = "0x18555D310")]
		private void KJHLGDJOOPN(Type FPPBLNEEHBP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class CGHAJPCIAGI : ADABOGHGFDG
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x555D250", Offset = "0x555C650", VA = "0x18555D250", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase JFNPJNFKGCM();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x555D200", Offset = "0x555C600", VA = "0x18555D200")]
	protected ComponentSystemBase GCBPBPEGBKA(params ComponentSystemBase[] FCGMOLCPBPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x270A8A0", Offset = "0x2709CA0", VA = "0x18270A8A0")]
	protected ComponentSystemBase GCBPBPEGBKA<T>(params ComponentSystemBase[] FCGMOLCPBPL) where T : ADABOGHGFDG, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x270A940", Offset = "0x2709D40", VA = "0x18270A940")]
	protected ComponentSystemBase KFDGPMLKMDJ<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x270A940", Offset = "0x2709D40", VA = "0x18270A940")]
	protected ComponentSystemBase NHLKLFHJCOL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	protected CGHAJPCIAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface ONPOFKDAOMC<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJDJCLJIFEK(int LGKEBNGGJEG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::ECNCBCGDDPA<BaseClass> BCLEHMKHLKD();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class ADABOGHGFDG : KPCOKMCLCJC
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x555CBB0", Offset = "0x555BFB0", VA = "0x18555CBB0", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public ADABOGHGFDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class LOFKNNMMOFJ : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x555F820", Offset = "0x555EC20", VA = "0x18555F820")]
	public GHPFKCKCCJM HDIDIHJHGOD(int LGKEBNGGJEG, bool MFAHGLHJJKF = false)
	{
		return default(GHPFKCKCCJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x555F8C0", Offset = "0x555ECC0", VA = "0x18555F8C0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0")]
	protected LOFKNNMMOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class JMIBLMMDFIG : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0")]
	protected JMIBLMMDFIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class PKIGKAPJAOK : LOFKNNMMOFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5561720", Offset = "0x5560B20", VA = "0x185561720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	protected void HPDOPNHAGJK(string ICBCECIENAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0")]
	protected PKIGKAPJAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class HPFPIAJPDND
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class KPCOKMCLCJC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	protected KPCOKMCLCJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[JLJFNDDLCBO(CBGNDNDJKHL.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5562F30", Offset = "0x5562330", VA = "0x185562F30")]
		public static ComponentSystemGroup[] PEOBFJPCAPJ(World KIEEJCIFMFE, CAPJOFMNLPJ KABLLOBECPC = CAPJOFMNLPJ.Default, bool OOAAKEEHJLN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5562950", Offset = "0x5561D50", VA = "0x185562950")]
		private static Type[] OOJCMOEKINO(CAPJOFMNLPJ KABLLOBECPC, bool OOAAKEEHJLN, ComponentSystemGroup[] NKINNHKHOPN, ComponentSystemGroup PLJFHLGFGGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5561E50", Offset = "0x5561250", VA = "0x185561E50")]
		private static ComponentSystemGroup[] BPMCPAIIOAE(World KIEEJCIFMFE, out ComponentSystemGroup PLJFHLGFGGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5562CB0", Offset = "0x55620B0", VA = "0x185562CB0")]
		internal static bool PDDHPFLNJDG(ODCPNHEJLHH AOFGAGALOCP, out NMCAAIDNBNE HFOHDJIHFFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5562160", Offset = "0x5561560", VA = "0x185562160")]
		private static ComponentSystemGroup KALFIGKPFMO(Type FPPBLNEEHBP, World KIEEJCIFMFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x55622A0", Offset = "0x55616A0", VA = "0x1855622A0")]
		private static ComponentSystemGroup[] LAPDDKCIDDN(Type[] NONJEDCGPEF, World KIEEJCIFMFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5562430", Offset = "0x5561830", VA = "0x185562430")]
		internal static void OKFHMNMBJEI(World KIEEJCIFMFE, Type[] NLBCIJFJKMN, ComponentSystemGroup[] NKINNHKHOPN, ComponentSystemGroup PLJFHLGFGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5562240", Offset = "0x5561640", VA = "0x185562240")]
		internal static bool KGGEMCGHDCA(ComponentSystemBase PLEONGBKEBJ, ComponentSystemGroup[] NKINNHKHOPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x55623D0", Offset = "0x55617D0", VA = "0x1855623D0")]
		private static void OFIGPEIHONE(ComponentSystemGroup[] NKINNHKHOPN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct FIAHGAFBELO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> MJIAMOMBDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> FCGMOLCPBPL;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x728A10", Offset = "0x727E10", VA = "0x180728A10")]
	public FIAHGAFBELO(Dictionary<Type, List<Type>> MJIAMOMBDMA, HashSet<Type> FCGMOLCPBPL)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[JLJFNDDLCBO(CBGNDNDJKHL.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class DHEAKHDLOEI : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
			[DebuggerHidden]
			public DHEAKHDLOEI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x555DA20", Offset = "0x555CE20", VA = "0x18555DA20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x555D780", Offset = "0x555CB80", VA = "0x18555D780", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x555DAB0", Offset = "0x555CEB0", VA = "0x18555DAB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x555D9E0", Offset = "0x555CDE0", VA = "0x18555D9E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x555D930", Offset = "0x555CD30", VA = "0x18555D930", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x555D930", Offset = "0x555CD30", VA = "0x18555D930", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct ADPJCPNJNCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type EAOMPAHBCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CAPJOFMNLPJ KABLLOBECPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool FGDBFPLDKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool GODOBKFABAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool OOAAKEEHJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> JOCIKGAIBBE;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x55630A0", Offset = "0x55624A0", VA = "0x1855630A0")]
		public static RRFilterWorldSystems FNICMNFMKAL()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5563090", Offset = "0x5562490", VA = "0x185563090")]
		public RRFilterWorldSystems BDCEGJLONNJ(CAPJOFMNLPJ AOFGAGALOCP)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5563D90", Offset = "0x5563190", VA = "0x185563D90")]
		public RRFilterWorldSystems PFAEHDMLDCF(IEnumerable<Type> NONJEDCGPEF)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x55631F0", Offset = "0x55625F0", VA = "0x1855631F0")]
		public RRFilterWorldSystems JOJOGIKBPHL(bool FCDAKLLKAHK)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5563150", Offset = "0x5562550", VA = "0x185563150")]
		public RRFilterWorldSystems HMNEDEIEIHH(bool IHLCBDNPDLG)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x55630C0", Offset = "0x55624C0", VA = "0x1855630C0")]
		public FIAHGAFBELO GKBNPGDIGAN(Type[] KDEOLAPBMCA)
		{
			return default(FIAHGAFBELO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5563160", Offset = "0x5562560", VA = "0x185563160")]
		[IteratorStateMachine(typeof(DHEAKHDLOEI))]
		internal IEnumerable<Type> JGBEPNOOPCP(IEnumerable<Type> NONJEDCGPEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5563360", Offset = "0x5562760", VA = "0x185563360")]
		internal Dictionary<Type, List<Type>> NHDODCMLFDE(IEnumerable<Type> NONJEDCGPEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5563640", Offset = "0x5562A40", VA = "0x185563640")]
		private void NIPJDBEOPDD(Dictionary<Type, List<Type>> HEIHGIHIMEK, Type FPPBLNEEHBP, Type NDEIELKNIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5563DD0", Offset = "0x55631D0", VA = "0x185563DD0")]
		internal HashSet<Type> PJLFPFBEJGF(IEnumerable<Type> NKINNHKHOPN, Dictionary<Type, List<Type>> LJGGGAEIPBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5563750", Offset = "0x5562B50", VA = "0x185563750")]
		internal bool PAPILIDAION(Type FPPBLNEEHBP, CAPJOFMNLPJ KABLLOBECPC, bool OOAAKEEHJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5563200", Offset = "0x5562600", VA = "0x185563200")]
		[CompilerGenerated]
		internal static void MGPDEKGJKEB(Type FPPBLNEEHBP, ref ADPJCPNJNCG P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class HPLPMOGDBLB
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool MEFCNDPFEPA;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x555F440", Offset = "0x555E840", VA = "0x18555F440")]
	public static void LJAJKOINHPD(bool POKKNFLDEOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x555F280", Offset = "0x555E680", VA = "0x18555F280")]
	private static void BDPDCPGBCMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class BJNHBFJJNEM
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x555CEE0", Offset = "0x555C2E0", VA = "0x18555CEE0")]
	public static ulong MDKKHLNGJPO(Type FPPBLNEEHBP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x555CF10", Offset = "0x555C310", VA = "0x18555CF10")]
	public static ulong MDKKHLNGJPO(string EBFCIHIFLPP)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[JLJFNDDLCBO(CBGNDNDJKHL.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct KBCJLKJJABH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong KIBOGDMDNCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong ONFGNEEBKFF;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xF6EA70", Offset = "0xF6DE70", VA = "0x180F6EA70")]
			public KBCJLKJJABH(ulong FLEEIDPLJBA, ulong NOPIJLEJKBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x555F580", Offset = "0x555E980", VA = "0x18555F580", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> GFLIILPCDKF;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static KBCJLKJJABH[] JDDIBADMDMK;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool MEFCNDPFEPA;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5564CF0", Offset = "0x55640F0", VA = "0x185564CF0")]
		public static ulong OICCFBKKJME(int LGKEBNGGJEG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5564060", Offset = "0x5563460", VA = "0x185564060")]
		public static int AEICOBCLIDD(ulong NOPIJLEJKBC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x55648E0", Offset = "0x5563CE0", VA = "0x1855648E0")]
		public static void LJAJKOINHPD(bool POKKNFLDEOM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5564280", Offset = "0x5563680", VA = "0x185564280")]
		private static void BEEJPBPCEHL(int LIDCOHCHDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x55645C0", Offset = "0x55639C0", VA = "0x1855645C0")]
		private static void LEFAHEDGCKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5564360", Offset = "0x5563760", VA = "0x185564360")]
		private static KBCJLKJJABH CFMCFMFJOJN(Type FPPBLNEEHBP)
		{
			return default(KBCJLKJJABH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5564540", Offset = "0x5563940", VA = "0x185564540")]
		private static ulong HNIMABCJDAC(Type FPPBLNEEHBP, ulong NOPIJLEJKBC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5564AD0", Offset = "0x5563ED0", VA = "0x185564AD0")]
		private static void MGJBMJKPIBE(in KBCJLKJJABH JPMIALONIGA, TypeManager.TypeInfo OCMAKALKODL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5564440", Offset = "0x5563840", VA = "0x185564440")]
		private static void DBHMHJFPBDE(KBCJLKJJABH OCMAKALKODL, int LGKEBNGGJEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x55641A0", Offset = "0x55635A0", VA = "0x1855641A0")]
		private static void AKJIAJANPFE(KBCJLKJJABH OCMAKALKODL, int LGKEBNGGJEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5564110", Offset = "0x5563510", VA = "0x185564110")]
		private static KBCJLKJJABH AJLELKBBMKB(int LGKEBNGGJEG)
		{
			return default(KBCJLKJJABH);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x55645B0", Offset = "0x55639B0", VA = "0x1855645B0")]
		private static int JEDALEPHNJO(int LGKEBNGGJEG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class PAGCHLOKGFO
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly FNDCCMCBHOD EKIEFIJKPDP;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly KHECIBGBBJM MEGIHGEDHMC;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly IBMGMIEDIPG CECILNEHKBH;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> FHMIAGCGKIO;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool MEFCNDPFEPA;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::ONPOFKDAOMC<GAPCPBFJDMJ> DMMAPFAIJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5560730", Offset = "0x555FB30", VA = "0x185560730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::ONPOFKDAOMC<BEECNEOJECG> BABCGODBAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5560790", Offset = "0x555FB90", VA = "0x185560790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::ONPOFKDAOMC<IMCJFCGBGHJ> MAMIJAJFJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x55607F0", Offset = "0x555FBF0", VA = "0x1855607F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5560850", Offset = "0x555FC50", VA = "0x185560850")]
	public static void LJAJKOINHPD(bool POKKNFLDEOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5560D00", Offset = "0x5560100", VA = "0x185560D00")]
	public static Type[] NAPNHPBEGNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class PLLGBPPKJLP
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> BKFPOADCJPC;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool MEFCNDPFEPA;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x55617D0", Offset = "0x5560BD0", VA = "0x1855617D0")]
	public static int FJFKOLNMONB(int LGKEBNGGJEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5561AF0", Offset = "0x5560EF0", VA = "0x185561AF0")]
	public static void LJAJKOINHPD(bool POKKNFLDEOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5561870", Offset = "0x5560C70", VA = "0x185561870")]
	private static void JEKDIJMCAFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5561B90", Offset = "0x5560F90", VA = "0x185561B90")]
	private static int PKPGFDFKBBH(Type FPPBLNEEHBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5561750", Offset = "0x5560B50", VA = "0x185561750")]
	private static void BNMOGLEIOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class FBFMDKPKBLB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World OJNPBOJPPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly GDHFGEGLFMK BPDPPIDNPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] NKINNHKHOPN;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World GEMNOHGEBLC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World GBENHADGLKA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager HDMAFEMIPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8E2660", Offset = "0x8E1A60", VA = "0x1808E2660")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public GDHFGEGLFMK GBPJMMGCLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::ECNCBCGDDPA<GAPCPBFJDMJ> DMMAPFAIJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x710AE0", Offset = "0x70FEE0", VA = "0x180710AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::ECNCBCGDDPA<BEECNEOJECG> BABCGODBAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x67F570", Offset = "0x67E970", VA = "0x18067F570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x67F590", Offset = "0x67E990", VA = "0x18067F590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::ECNCBCGDDPA<IMCJFCGBGHJ> MAMIJAJFJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x67F580", Offset = "0x67E980", VA = "0x18067F580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x67F5A0", Offset = "0x67E9A0", VA = "0x18067F5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> BDCPKBMPNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8E26A0", Offset = "0x8E1AA0", VA = "0x1808E26A0")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] AKGACNCMFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x555E0A0", Offset = "0x555D4A0", VA = "0x18555E0A0")]
	public static FBFMDKPKBLB GPGLGNIEICP(string DHKKANIEGMN, ODCPNHEJLHH AOFGAGALOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x555E5F0", Offset = "0x555D9F0", VA = "0x18555E5F0")]
	public FBFMDKPKBLB(string DHKKANIEGMN, ODCPNHEJLHH AOFGAGALOCP = ODCPNHEJLHH.Simulation, CAPJOFMNLPJ KABLLOBECPC = CAPJOFMNLPJ.Default, bool POKKNFLDEOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x555E460", Offset = "0x555D860", VA = "0x18555E460")]
	public ComponentSystemBase OOGCCGJCGBG(Type FPPBLNEEHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2E878B0", Offset = "0x2E86CB0", VA = "0x182E878B0")]
	public T OOGCCGJCGBG<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x555E320", Offset = "0x555D720", VA = "0x18555E320")]
	public void MGDPOFBIGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x555E260", Offset = "0x555D660", VA = "0x18555E260")]
	public void JMAGKKCCBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x555DEE0", Offset = "0x555D2E0", VA = "0x18555DEE0")]
	public void CAKAMILKLGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x555E200", Offset = "0x555D600", VA = "0x18555E200")]
	public void JCPJPLCNJAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x555E2C0", Offset = "0x555D6C0", VA = "0x18555E2C0")]
	public void KNKKPDJBJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x555E040", Offset = "0x555D440", VA = "0x18555E040")]
	public void ELNLBGOBPHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x555E480", Offset = "0x555D880", VA = "0x18555E480")]
	public void OOPFHDHECCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x555DF40", Offset = "0x555D340", VA = "0x18555DF40")]
	public void CMMAOHMHIFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x555E380", Offset = "0x555D780", VA = "0x18555E380")]
	public void OHGNOMDMOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x555DBB0", Offset = "0x555CFB0", VA = "0x18555DBB0")]
	public void AALILPHEMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x555E120", Offset = "0x555D520", VA = "0x18555E120")]
	internal void HLBKOPLCJLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x555E3E0", Offset = "0x555D7E0", VA = "0x18555E3E0")]
	private bool ONOCMGMCHJE(ComponentSystemGroup EOONLHGBECH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x555DC10", Offset = "0x555D010", VA = "0x18555DC10")]
	private void BJLNJKDOIPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x555E4E0", Offset = "0x555D8E0", VA = "0x18555E4E0")]
	private ComponentSystemGroup[] PEOBFJPCAPJ(CAPJOFMNLPJ KABLLOBECPC, bool OOAAKEEHJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x555DFD0", Offset = "0x555D3D0", VA = "0x18555DFD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum ODCPNHEJLHH
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
public sealed class DLPCKIGDBPO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public CAPJOFMNLPJ OEAHLBGLBDH;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum CAPJOFMNLPJ
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
public interface NMCAAIDNBNE
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type LKIMPPOOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] FPCDEFFOLON
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class HPDFMLLLHON : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool NCAMONNOIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x699020", Offset = "0x698420", VA = "0x180699020", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	protected HPDFMLLLHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class IPAFJMCLHGI : HPDFMLLLHON
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public IPAFJMCLHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class AKLPCMBBDGP : HPDFMLLLHON
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public AKLPCMBBDGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class PCNOCMLMLLL : HPDFMLLLHON
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public PCNOCMLMLLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class HGLDNFGGGGB : HPDFMLLLHON
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public HGLDNFGGGGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class MGFOACDGJAL : HPDFMLLLHON
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public MGFOACDGJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class CIKJNEFGFPD : HPDFMLLLHON
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public CIKJNEFGFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class OKJDCIDJPAO : HPDFMLLLHON
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public OKJDCIDJPAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class DLOPILJGGDC : HPDFMLLLHON
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public DLOPILJGGDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class ONHCGIBINHC : HPDFMLLLHON
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public ONHCGIBINHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class FFEMAFADNDK : IOGBBJMILLB
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public FFEMAFADNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class EHONLCGGBPL : IOGBBJMILLB
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public EHONLCGGBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class GKNAOFBCFID : IOGBBJMILLB
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public GKNAOFBCFID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class NMAMPKJMJKG : IOGBBJMILLB
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public NMAMPKJMJKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[OKNDCPNCELC(GPPMCHFFAPH.Application)]
public class IOGBBJMILLB : HPDFMLLLHON
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool NCAMONNOIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x555CE60", Offset = "0x555C260", VA = "0x18555CE60")]
	public IOGBBJMILLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class OGKBFABIIKG : GKLONNNGPKI
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public OGKBFABIIKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class MHHJNPCLFCO
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void GNMNJOOBNJA<From, To>(From OHCPCHAKDAC, ref To JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class IBGDOMCMEML<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static GNMNJOOBNJA<From, To> OOKALFGKKJE;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public IBGDOMCMEML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5560160", Offset = "0x555F560", VA = "0x185560160")]
	static MHHJNPCLFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x255E0E0", Offset = "0x255D4E0", VA = "0x18255E0E0")]
	public static void LCLIIHCLOIF<T>(GNMNJOOBNJA<T, T> DEHJGLPNMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x255DF70", Offset = "0x255D370", VA = "0x18255DF70")]
	public static void LCLIIHCLOIF<From, To>(GNMNJOOBNJA<From, To> DEHJGLPNMBL, GNMNJOOBNJA<To, From> POPBLBBODND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x255E000", Offset = "0x255D400", VA = "0x18255E000")]
	public static void LCLIIHCLOIF<From, To>(GNMNJOOBNJA<From, To> OOKALFGKKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3231340", Offset = "0x3230740", VA = "0x183231340")]
	public static GNMNJOOBNJA<From, To> KFIAENDFMKF<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x322CF40", Offset = "0x322C340", VA = "0x18322CF40")]
	public static void JMBJLHBDPGB<From, To>(From OHCPCHAKDAC, ref To JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class OBEFJIDEFOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> EFALFOIKBFG;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xD8B120", Offset = "0xD8A520", VA = "0x180D8B120")]
	public OBEFJIDEFOJ(NativeArray<EntityRemapUtility.EntityRemapInfo> EFALFOIKBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1390", Offset = "0x2BD0790", VA = "0x182BD1390")]
	public Entity DAJBLDNMJMH(Entity KOEICPMBJFP)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class PNCKAMJGDBM
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> LFJNLHJEJLO;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5561C60", Offset = "0x5561060", VA = "0x185561C60")]
	public static bool LKHGGHJMBCA(ulong BMNGMMBLJFF, uint FMCKDMNHLLD, out string DHKKANIEGMN)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct GDNKBFHCPBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int IJHDILKKDIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int BBEGHBAAMGP;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x699050", Offset = "0x698450", VA = "0x180699050")]
			public GDNKBFHCPBN(int HMJKJGLHFKE, int FMCKDMNHLLD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct PJPLHJIHKBK
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch PBKGENHMNJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long CFDEGGGMMGE;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long DJKGILGPIEJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x55616C0", Offset = "0x5560AC0", VA = "0x1855616C0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long LFBCCGEBPHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5561590", Offset = "0x5560990", VA = "0x185561590")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5561600", Offset = "0x5560A00", VA = "0x185561600")]
			public static PJPLHJIHKBK DBNCCLOFLDA()
			{
				return default(PJPLHJIHKBK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct MGOKELJKFDM : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct GCEKCKICHEA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* NCBBJNALHKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly AMLHNDPNGJJ.DNPACIPADAF.IJOGKGODKNB IIBJPHICIJG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly OBEFJIDEFOJ JDIPGKNLNAI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::ECNCBCGDDPA<BEECNEOJECG> EALIDBKEJIK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int DFPGLGOFFMO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int PBMFIGFDOII;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x555F0A0", Offset = "0x555E4A0", VA = "0x18555F0A0")]
				public unsafe GCEKCKICHEA(Unity.Entities.Archetype* NCBBJNALHKB, AMLHNDPNGJJ.DNPACIPADAF.IJOGKGODKNB IIBJPHICIJG, OBEFJIDEFOJ JDIPGKNLNAI, global::ECNCBCGDDPA<BEECNEOJECG> EALIDBKEJIK, int DFPGLGOFFMO, int PBMFIGFDOII = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x555F100", Offset = "0x555E500", VA = "0x18555F100")]
				public GCEKCKICHEA(in GCEKCKICHEA PNMIIEJFOON, int PBMFIGFDOII)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly GCEKCKICHEA[] KOPDMFDFEFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] OMAEFNKDALC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int HGKBBLOHCPN;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5560020", Offset = "0x555F420", VA = "0x185560020")]
			public MGOKELJKFDM(GCEKCKICHEA[] KOPDMFDFEFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x555F940", Offset = "0x555ED40", VA = "0x18555F940", Slot = "4")]
			public void Invoke(int HMJKJGLHFKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x555FC70", Offset = "0x555F070", VA = "0x18555FC70")]
			private void OKKCKCLJEPO(in GCEKCKICHEA PNMIIEJFOON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x555F9A0", Offset = "0x555EDA0", VA = "0x18555F9A0")]
			private static void JDAELIGPMOE(in GCEKCKICHEA PNMIIEJFOON)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class JPAEALKFCEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public AMLHNDPNGJJ asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::ECNCBCGDDPA<BEECNEOJECG> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public JPAEALKFCEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x555F510", Offset = "0x555E910", VA = "0x18555F510")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class NLCGOOOMDAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public AMLHNDPNGJJ.DNPACIPADAF.IJOGKGODKNB srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public JPAEALKFCEE CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public NLCGOOOMDAP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class KJNFKKJODLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public NLCGOOOMDAP CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public KJNFKKJODLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x555F710", Offset = "0x555EB10", VA = "0x18555F710")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly DLHDGHMPCLG EDDAPCEJNNE;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly DLHDGHMPCLG MEELLKPAECK;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly DLHDGHMPCLG BKBMJDGNJBH;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly DLHDGHMPCLG IBCEKJCGLPK;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool PIFILLGPANB;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static AMLHNDPNGJJ.DNPACIPADAF.NEPLCKHGJMD HDJPKDAFGJM;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5565C80", Offset = "0x5565080", VA = "0x185565C80")]
		private unsafe static bool HBDAMMIODKE(Unity.Entities.Archetype* GMPHNAMECNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5567BF0", Offset = "0x5566FF0", VA = "0x185567BF0")]
		internal unsafe static Unity.Entities.Archetype*[] LKLLPNJILNB(ref Unity.Entities.EntityComponentStore IINEFMCDGBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5566A40", Offset = "0x5565E40", VA = "0x185566A40")]
		public static void KDJJNHBIKID(FBFMDKPKBLB KIEEJCIFMFE, out ByteString BIPDDAIIHHG, out NativeArray<EntityRemapUtility.EntityRemapInfo> LKFJMNCPGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5565550", Offset = "0x5564950", VA = "0x185565550")]
		internal static void GFBKPIBFICO(FBFMDKPKBLB KIEEJCIFMFE, AMLHNDPNGJJ BPMBKGDLDNE, out NativeArray<EntityRemapUtility.EntityRemapInfo> LKFJMNCPGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5564ED0", Offset = "0x55642D0", VA = "0x185564ED0")]
		private unsafe static UnsafeHashMap<ulong, GDNKBFHCPBN> EGFOHOHNJKD(Unity.Entities.Archetype*[] CBKIIGEPHNA)
		{
			return default(UnsafeHashMap<ulong, GDNKBFHCPBN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5567DD0", Offset = "0x55671D0", VA = "0x185567DD0")]
		private static void MMDJNIMKHHD(AMLHNDPNGJJ BPMBKGDLDNE, UnsafeHashMap<ulong, GDNKBFHCPBN> AAGMLMJBHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5566B00", Offset = "0x5565F00", VA = "0x185566B00")]
		private unsafe static void KHDNKEEGICA(AMLHNDPNGJJ BPMBKGDLDNE, Unity.Entities.Archetype*[] CBKIIGEPHNA, UnsafeHashMap<ulong, GDNKBFHCPBN> AAGMLMJBHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5564DE0", Offset = "0x55641E0", VA = "0x185564DE0")]
		private unsafe static int AHJAJCLACMI(Unity.Entities.Archetype*[] CBKIIGEPHNA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x55681F0", Offset = "0x55675F0", VA = "0x1855681F0")]
		private unsafe static void NEDFOKOPMJN(AMLHNDPNGJJ BPMBKGDLDNE, Unity.Entities.Archetype*[] CBKIIGEPHNA, global::ECNCBCGDDPA<BEECNEOJECG> EALIDBKEJIK, NativeArray<EntityRemapUtility.EntityRemapInfo> LKFJMNCPGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5567F80", Offset = "0x5567380", VA = "0x185567F80")]
		private static NativeArray<int> MPCIIPGNMME(AMLHNDPNGJJ BPMBKGDLDNE)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5566E30", Offset = "0x5566230", VA = "0x185566E30")]
		private static Memory<EntityArchetype> KLOJOGJNDEF(AMLHNDPNGJJ BPMBKGDLDNE, NativeArray<int> NONJEDCGPEF, EntityManager GKHNMAAJNKF, out int FPMFLOJKELC, out int PFDDOEEHMAC)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x55678A0", Offset = "0x5566CA0", VA = "0x1855678A0")]
		private unsafe static void LHNLPNEGIGB(Unity.Entities.Chunk* MGIFMNBDDCM, ReadOnlySpan<byte> BIPDDAIIHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5566300", Offset = "0x5565700", VA = "0x185566300")]
		private static void KCFPANJCCLO(AMLHNDPNGJJ BPMBKGDLDNE, NativeArray<int> NONJEDCGPEF, Span<EntityArchetype> CBKIIGEPHNA, EntityManager GKHNMAAJNKF, global::ECNCBCGDDPA<BEECNEOJECG> EALIDBKEJIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5564E50", Offset = "0x5564250", VA = "0x185564E50")]
		private unsafe static void BOPINJNDHOD(Unity.Entities.Chunk* PPHKNFIBCEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5565240", Offset = "0x5564640", VA = "0x185565240")]
		private unsafe static void GACLHGKLBGO(AMLHNDPNGJJ.DNPACIPADAF.IJOGKGODKNB NCBBJNALHKB, int DGAJAEDDCOC, int DELJNIKMJIF, Unity.Entities.Chunk* MGIFMNBDDCM, AMLHNDPNGJJ BPMBKGDLDNE, NativeArray<int> NONJEDCGPEF, global::ECNCBCGDDPA<BEECNEOJECG> EALIDBKEJIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x55671C0", Offset = "0x55665C0", VA = "0x1855671C0")]
		public static void LEDLOIFPDNE(FBFMDKPKBLB KIEEJCIFMFE, in ByteString BIPDDAIIHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5567250", Offset = "0x5566650", VA = "0x185567250")]
		public static void LEDLOIFPDNE(EntityManager GKHNMAAJNKF, global::ECNCBCGDDPA<BEECNEOJECG> EALIDBKEJIK, in ByteString BIPDDAIIHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5565D90", Offset = "0x5565190", VA = "0x185565D90")]
		private static bool HBLDLLEOPAI(Type FPPBLNEEHBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5566050", Offset = "0x5565450", VA = "0x185566050")]
		private static void KADKAGJICHA(TypeManager.TypeInfo OCMAKALKODL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x55686B0", Offset = "0x5567AB0", VA = "0x1855686B0")]
		private unsafe static int PMBDHJNMBBF(Unity.Entities.Archetype*[] CBKIIGEPHNA, NativeArray<EntityRemapUtility.EntityRemapInfo> LKFJMNCPGCI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5565160", Offset = "0x5564560", VA = "0x185565160")]
		private static int FJFKOLNMONB(int LGKEBNGGJEG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5568610", Offset = "0x5567A10", VA = "0x185568610")]
		private static ulong OICCFBKKJME(int LGKEBNGGJEG)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class PGAMFNJCMMK
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5561380", Offset = "0x5560780", VA = "0x185561380")]
	private unsafe static Span<byte> ELPIPKEEGDE(Unity.Entities.Chunk* PPHKNFIBCEA, int DFPGLGOFFMO)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC4A0", Offset = "0x1FCB8A0", VA = "0x181FCC4A0")]
	public unsafe static Span<T> NPJIJOAMOBP<T>(Unity.Entities.Chunk* PPHKNFIBCEA, int DFPGLGOFFMO)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC620", Offset = "0x1FCBA20", VA = "0x181FCC620")]
	public static Span<T> NPJIJOAMOBP<T>(this ref Unity.Entities.Chunk PPHKNFIBCEA, int DFPGLGOFFMO)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5561520", Offset = "0x5560920", VA = "0x185561520")]
	public unsafe static Span<Entity> HLPGIJCPJGB(Unity.Entities.Chunk* PPHKNFIBCEA)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5560FB0", Offset = "0x55603B0", VA = "0x185560FB0")]
	public unsafe static void BNMOGLEIOOC(Unity.Entities.Chunk* PPHKNFIBCEA, int DFPGLGOFFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5561250", Offset = "0x5560650", VA = "0x185561250")]
	public static Entity CDHHOOKIPLM(this EntityQuery JHDPAHIHIEJ)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : JAMCEJDIEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5568AA0", Offset = "0x5567EA0", VA = "0x185568AA0", Slot = "4")]
		public sealed override void PJNICPDDEAL()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class NLJAGALCJKH
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] JCLCDCCNAPM;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int BKAHGFCDIKL;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int GJMNCFGIJLO;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger MOEAOMJCPNL;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NLJAGALCJKH()
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
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
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

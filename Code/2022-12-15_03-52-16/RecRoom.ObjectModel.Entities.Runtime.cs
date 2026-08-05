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
internal static class IDNCDFHDFDA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x554DF80", Offset = "0x554C980", VA = "0x18554DF80")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> FGBHPLPBINA(this ref Unity.Entities.Archetype HEFFAMIFPAM)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NNKNAMAMCDH
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x554F080", Offset = "0x554DA80", VA = "0x18554F080")]
	public static Span<int> ODEGKKMKHCG(this EntityArchetype HEFFAMIFPAM)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class COEIBNPKIOD
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JKALLHKJDEA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x554E180", Offset = "0x554CB80", VA = "0x18554E180")]
	public static bool DEHMHJNDOKD(this Entity FLADPKIONGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class AAIJCMLIICL
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[BurstCompile]
	private struct FINJGLLJABI<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[ReadOnly]
		public NativeArray<Entity> FOMMJLEICDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[WriteOnly]
		public ComponentDataFromEntity<T> DNIDJBNHDGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public T MAKFNMHIJIF;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x31DB120", Offset = "0x31D9B20", VA = "0x1831DB120", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[BurstCompile]
	private struct JBDCLHIEOHP<T> : IJobChunk where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[WriteOnly]
		public ArchetypeChunkComponentType<T> NDKHHKOPPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T MAKFNMHIJIF;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x19DC9E0", Offset = "0x19DB3E0", VA = "0x1819DC9E0")]
	public static void HGONFLKICDE<T>(this EntityManager LNPEGOPJJGK, NativeArray<Entity> IJBCECFNJIL, T MAKFNMHIJIF) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x19DCB70", Offset = "0x19DB570", VA = "0x1819DCB70")]
	public static void HHGDOAODIAP<T>(this EntityManager LNPEGOPJJGK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x19DD470", Offset = "0x19DBE70", VA = "0x1819DD470")]
	public static void OFLLDOMMDOO<T>(this EntityManager LNPEGOPJJGK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x19DCED0", Offset = "0x19DB8D0", VA = "0x1819DCED0")]
	public static JobHandle MONNDKBJHPK<T>(this EntityManager LNPEGOPJJGK) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x554A3B0", Offset = "0x5548DB0", VA = "0x18554A3B0")]
	public static JobHandle MONNDKBJHPK(this EntityManager LNPEGOPJJGK, int HIMMGNBBIHM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct IMKHFHJHGID<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class AJOMHDNDJAC : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::IMKHFHJHGID<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696A40", VA = "0x180698040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3238060", Offset = "0x3236A60", VA = "0x183238060", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x14A4C10", Offset = "0x14A3610", VA = "0x1814A4C10")]
		[DebuggerHidden]
		public AJOMHDNDJAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3237E80", Offset = "0x3236880", VA = "0x183237E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3238020", Offset = "0x3236A20", VA = "0x183238020", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> PPKMMFHNOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream FJEDANIIFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream CFIOFPHICOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf EMONGICDNCF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int ELOKHHJFINF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x677010", Offset = "0x675A10", VA = "0x180677010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24B5C60", Offset = "0x24B4660", VA = "0x1824B5C60")]
	private IMKHFHJHGID(byte[] DICKNCEHGPP, Action<Protobuf> PPKMMFHNOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x273E140", Offset = "0x273CB40", VA = "0x18273E140")]
	public static global::IMKHFHJHGID<Protobuf> CBFHJGEFJHE<Data>(ReadOnlySpan<byte> FJHIHOOEHJM, ReadOnlySpan<Data> EPKPHBHDHGH, Action<Protobuf> PPKMMFHNOLF)
	{
		return default(global::IMKHFHJHGID<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24B5AD0", Offset = "0x24B44D0", VA = "0x1824B5AD0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x24B5B10", Offset = "0x24B4510", VA = "0x1824B5B10", Slot = "4")]
	[IteratorStateMachine(typeof(global::IMKHFHJHGID<>.AJOMHDNDJAC))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x24B5C10", Offset = "0x24B4610", VA = "0x1824B5C10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HJAAGDECNFB<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] DICKNCEHGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf EMONGICDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream FJEDANIIFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream NFFLKPCAMCB;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B850", Offset = "0x3F3A250", VA = "0x183F3B850")]
	private HJAAGDECNFB(byte[] DICKNCEHGPP, in Protobuf EMONGICDNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x273A410", Offset = "0x2738E10", VA = "0x18273A410")]
	public static global::HJAAGDECNFB<Protobuf> CBFHJGEFJHE<T>(ReadOnlySpan<T> EPKPHBHDHGH)
	{
		return default(global::HJAAGDECNFB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B820", Offset = "0x3F3A220", VA = "0x183F3B820")]
	public void MAGEMILPIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B660", Offset = "0x3F3A060", VA = "0x183F3B660")]
	public ByteString ADCLBDPECNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B6F0", Offset = "0x3F3A0F0", VA = "0x183F3B6F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GKMJMEDMODG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream FJEDANIIFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream CFIOFPHICOF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x554D930", Offset = "0x554C330", VA = "0x18554D930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct HIHMJLJMOHK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] DICKNCEHGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream FJEDANIIFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream NFFLKPCAMCB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x554DBA0", Offset = "0x554C5A0", VA = "0x18554DBA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PPGACODAFIA
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public static void PNCKOLEPIFB(this FGGEJMNNOEE LAEOPKAJMLP, NativeArray<Entity> IJBCECFNJIL, [Optional][CallerFilePath] string ONCPNKIDDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public static void PNCKOLEPIFB(this FGGEJMNNOEE LAEOPKAJMLP, string NBODBMLPNJA, NativeArray<Entity> IJBCECFNJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public static void PNCKOLEPIFB(this FGGEJMNNOEE LAEOPKAJMLP, string ONCPNKIDDOD, NativeArray<Entity> IJBCECFNJIL, bool LBGOBMKAOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public static void CEFPHHMFLJG(this FGGEJMNNOEE LAEOPKAJMLP, NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> AKGGBDCLIGD, [Optional][CallerFilePath] string ONCPNKIDDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public static void CEFPHHMFLJG(this FGGEJMNNOEE LAEOPKAJMLP, string ONCPNKIDDOD, NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> AKGGBDCLIGD, bool LBGOBMKAOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x279EC80", Offset = "0x279D680", VA = "0x18279EC80")]
	public static void JKIKGFNEMHM<T>(this FGGEJMNNOEE LAEOPKAJMLP, string NBODBMLPNJA, NativeArray<Entity> IJBCECFNJIL, NativeList<T> JIHCLPECHIB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x279ED10", Offset = "0x279D710", VA = "0x18279ED10")]
	public static void JKIKGFNEMHM<T>(this FGGEJMNNOEE LAEOPKAJMLP, string NBODBMLPNJA, NativeArray<Entity> IJBCECFNJIL, NativeArray<T> JIHCLPECHIB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public static void JKIKGFNEMHM<T>(this FGGEJMNNOEE LAEOPKAJMLP, string ONCPNKIDDOD, NativeArray<Entity> IJBCECFNJIL, NativeArray<T> JIHCLPECHIB, bool LBGOBMKAOKK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x279EBE0", Offset = "0x279D5E0", VA = "0x18279EBE0")]
	public static void HNAGJHLAGPF<T>(this FGGEJMNNOEE LAEOPKAJMLP, NativeList<T> JIHCLPECHIB, [Optional][CallerFilePath] string ONCPNKIDDOD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x279EBB0", Offset = "0x279D5B0", VA = "0x18279EBB0")]
	public static void HNAGJHLAGPF<T>(this FGGEJMNNOEE LAEOPKAJMLP, NativeArray<T> JIHCLPECHIB, [Optional][CallerFilePath] string ONCPNKIDDOD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public static void HNAGJHLAGPF<T>(this FGGEJMNNOEE LAEOPKAJMLP, string ONCPNKIDDOD, NativeArray<T> JIHCLPECHIB, bool LBGOBMKAOKK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public static void KEPCHJPFHMF(this FGGEJMNNOEE LAEOPKAJMLP, EntityQuery AMEIGJPGLKK, [Optional][CallerFilePath] string ONCPNKIDDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public static void KEPCHJPFHMF(this FGGEJMNNOEE LAEOPKAJMLP, string NBODBMLPNJA, EntityQuery AMEIGJPGLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public static void KEPCHJPFHMF(this FGGEJMNNOEE LAEOPKAJMLP, string ONCPNKIDDOD, EntityQuery AMEIGJPGLKK, bool LBGOBMKAOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x279EC50", Offset = "0x279D650", VA = "0x18279EC50")]
	public static void IJJHAOKKAPP<T, T2>(this FGGEJMNNOEE LAEOPKAJMLP, string NBODBMLPNJA, EntityQuery AMEIGJPGLKK) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	private static void IJJHAOKKAPP<T, T2>(this FGGEJMNNOEE LAEOPKAJMLP, string ONCPNKIDDOD, EntityQuery AMEIGJPGLKK, bool LBGOBMKAOKK) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FEHJDGBIBFC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GMLHAACHBKL NCHIEACOPDC
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
public interface KGGBBDKCFNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OCLLOJIAMME(Entity FLADPKIONGF, object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DKOMHAGKCFC(Entity FLADPKIONGF, object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JBJJGGGFHBP(Entity FLADPKIONGF);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JBJJGGGFHBP(GMLHAACHBKL ODMNDKFKJHN);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> JHNPKNIBINO(Entity FLADPKIONGF);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PIHHIEBAGHH(Entity FLADPKIONGF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MBBKMHEBCCI<TComponentData, TValue> : global::FJFPAKAENKI<TValue>, IDisposable where TComponentData : struct, FEHJDGBIBFC
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class PBLLIFLDIGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> ACLENHAHHHH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int ICNBMEOIEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1FE7930", Offset = "0x1FE6330", VA = "0x181FE7930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x40E68D0", Offset = "0x40E52D0", VA = "0x1840E68D0")]
		public bool FLKOLJMPNME(out TValue MAKFNMHIJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x40E6990", Offset = "0x40E5390", VA = "0x1840E6990")]
		public void MFMCNFFMIAP(object HKLDIENGNNB, TValue MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x40E6850", Offset = "0x40E5250", VA = "0x1840E6850")]
		public bool EMIFMEAGDDE(object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x40E6A40", Offset = "0x40E5440", VA = "0x1840E6A40")]
		public int NCLIALNFMIA(object HKLDIENGNNB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x40E6AF0", Offset = "0x40E54F0", VA = "0x1840E6AF0")]
		public PBLLIFLDIGF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<PBLLIFLDIGF> NHLDHGBMFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::BGFDJNFLFAN<GMLHAACHBKL, PBLLIFLDIGF> NGHJKOAFLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager LNPEGOPJJGK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC8A0", Offset = "0x3CEB2A0", VA = "0x183CEC8A0")]
	public MBBKMHEBCCI(EntityManager LNPEGOPJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC780", Offset = "0x3CEB180", VA = "0x183CEC780", Slot = "4")]
	public void OCLLOJIAMME(Entity FLADPKIONGF, object HKLDIENGNNB, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC300", Offset = "0x3CEAD00", VA = "0x183CEC300", Slot = "5")]
	public bool DKOMHAGKCFC(Entity FLADPKIONGF, object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC490", Offset = "0x3CEAE90", VA = "0x183CEC490", Slot = "6")]
	public bool FLKOLJMPNME(Entity FLADPKIONGF, out TValue MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC470", Offset = "0x3CEAE70", VA = "0x183CEC470", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC280", Offset = "0x3CEAC80", VA = "0x183CEC280")]
	private void COHLOOAFJNN(PBLLIFLDIGF MHNEIFAEMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC560", Offset = "0x3CEAF60", VA = "0x183CEC560")]
	private bool GIMIFKJKHKN(Entity FLADPKIONGF, out GMLHAACHBKL ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC630", Offset = "0x3CEB030", VA = "0x183CEC630")]
	private void ILIHCIBBOEO(Entity FLADPKIONGF, GMLHAACHBKL ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC610", Offset = "0x3CEB010", VA = "0x183CEC610")]
	private bool GOGNFCADBAF(GMLHAACHBKL ODMNDKFKJHN, out PBLLIFLDIGF MHNEIFAEMNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC6C0", Offset = "0x3CEB0C0", VA = "0x183CEC6C0")]
	private PBLLIFLDIGF MGKGAGEPOPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FJFPAKAENKI<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCLLOJIAMME(Entity FLADPKIONGF, object HKLDIENGNNB, TValue MAKFNMHIJIF);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DKOMHAGKCFC(Entity FLADPKIONGF, object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FLKOLJMPNME(Entity FLADPKIONGF, out TValue MAKFNMHIJIF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GMLHAACHBKL : global::LAJFKAIBBBL<GMLHAACHBKL>, LDGEBNEMAMI, IEquatable<GMLHAACHBKL>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly GMLHAACHBKL HDJNGGOKGFI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int DNFPKCNMAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727820", VA = "0x180728E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x728D90", Offset = "0x727790", VA = "0x180728D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int HOBPJIMDIAG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B60", Offset = "0x8B4560", VA = "0x1808B5B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xE8F640", Offset = "0xE8E040", VA = "0x180E8F640", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x554D970", Offset = "0x554C370", VA = "0x18554D970", Slot = "8")]
	public bool Equals(GMLHAACHBKL OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x554D9C0", Offset = "0x554C3C0", VA = "0x18554D9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BHECHFLOHKD<T> : KGGBBDKCFNK, IDisposable where T : struct, FEHJDGBIBFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> NHLDHGBMFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::BGFDJNFLFAN<GMLHAACHBKL, HashSet<object>> NGHJKOAFLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager LNPEGOPJJGK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x34244D0", Offset = "0x3422ED0", VA = "0x1834244D0")]
	public BHECHFLOHKD(EntityManager LNPEGOPJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3423200", Offset = "0x3421C00", VA = "0x183423200", Slot = "4")]
	public bool OCLLOJIAMME(Entity FLADPKIONGF, object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x34218B0", Offset = "0x34202B0", VA = "0x1834218B0", Slot = "5")]
	public bool DKOMHAGKCFC(Entity FLADPKIONGF, object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x34225A0", Offset = "0x3420FA0", VA = "0x1834225A0", Slot = "6")]
	public bool JBJJGGGFHBP(Entity FLADPKIONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3422500", Offset = "0x3420F00", VA = "0x183422500", Slot = "7")]
	public bool JBJJGGGFHBP(GMLHAACHBKL ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3422A20", Offset = "0x3421420", VA = "0x183422A20", Slot = "8")]
	public IEnumerable<object> JHNPKNIBINO(Entity FLADPKIONGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3422B80", Offset = "0x3421580", VA = "0x183422B80", Slot = "11")]
	public IEnumerable<object> JHNPKNIBINO(GMLHAACHBKL ODMNDKFKJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x34241F0", Offset = "0x3422BF0", VA = "0x1834241F0", Slot = "9")]
	public bool PIHHIEBAGHH(Entity FLADPKIONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3421C10", Offset = "0x3420610", VA = "0x183421C10", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3421350", Offset = "0x341FD50", VA = "0x183421350")]
	private void COHLOOAFJNN(HashSet<object> MHNEIFAEMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3421F10", Offset = "0x3420910", VA = "0x183421F10")]
	private bool GIMIFKJKHKN(Entity FLADPKIONGF, out GMLHAACHBKL ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3423E30", Offset = "0x3422830", VA = "0x183423E30")]
	private bool PFJGDNNNPGN(Entity FLADPKIONGF, out GMLHAACHBKL ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x34214A0", Offset = "0x341FEA0", VA = "0x1834214A0")]
	private void DHCOMGNHCDA(Entity FLADPKIONGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x34222B0", Offset = "0x3420CB0", VA = "0x1834222B0")]
	private void ILIHCIBBOEO(Entity FLADPKIONGF, GMLHAACHBKL ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3421DB0", Offset = "0x34207B0", VA = "0x183421DB0")]
	private bool FPIAHNMFEBM(GMLHAACHBKL ODMNDKFKJHN, out HashSet<object> MHNEIFAEMNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3423020", Offset = "0x3421A20", VA = "0x183423020")]
	private HashSet<object> MGKGAGEPOPC()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MDMEBGBKEJJ : global::HGCMHGOBKJN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x554EA40", Offset = "0x554D440", VA = "0x18554EA40", Slot = "4")]
	public float EALPAIFGGJG(float3 MAKFNMHIJIF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct COLCMADLEEB : global::HGCMHGOBKJN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x554ADA0", Offset = "0x55497A0", VA = "0x18554ADA0", Slot = "4")]
	public float EALPAIFGGJG(float3 MAKFNMHIJIF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PNCCDMLCDBJ : global::HGCMHGOBKJN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x554F6B0", Offset = "0x554E0B0", VA = "0x18554F6B0", Slot = "4")]
	public float EALPAIFGGJG(float3 MAKFNMHIJIF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct GJHKKBJHDIJ : global::HGCMHGOBKJN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x101ED90", Offset = "0x101D790", VA = "0x18101ED90", Slot = "4")]
	public int EALPAIFGGJG(int3 MAKFNMHIJIF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OLPIIDEOMHE : global::HGCMHGOBKJN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1587F60", Offset = "0x1586960", VA = "0x181587F60", Slot = "4")]
	public int EALPAIFGGJG(int3 MAKFNMHIJIF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct PDBKPGNOKLK : global::HGCMHGOBKJN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x554F610", Offset = "0x554E010", VA = "0x18554F610", Slot = "4")]
	public int EALPAIFGGJG(int3 MAKFNMHIJIF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class JOAMECNEEFA : EIOKMAELDBG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type BJKINDDBNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695B30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xF4F730", Offset = "0xF4E130", VA = "0x180F4F730")]
	public JOAMECNEEFA(Type MHGOOECIHJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AOABIAIICLA : JOAMECNEEFA
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xF4F730", Offset = "0xF4E130", VA = "0x180F4F730")]
	public AOABIAIICLA(Type MHGOOECIHJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LAOLKNOEOBH : JOAMECNEEFA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type HMOHGGFMMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695B40", VA = "0x180697140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x554E1A0", Offset = "0x554CBA0", VA = "0x18554E1A0")]
	public LAOLKNOEOBH(Type DKEKJGDHPMA, Type MHGOOECIHJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BPAPKMJCHMP : JOAMECNEEFA
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xF4F730", Offset = "0xF4E130", VA = "0x180F4F730")]
	public BPAPKMJCHMP(Type MHGOOECIHJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BCMMDDALFAJ : EIOKMAELDBG
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public BCMMDDALFAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IBMNMGLBDEG : EIOKMAELDBG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FMHJKFCFNOJ GCCMGLKJMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675A40", VA = "0x180677040")]
		[CompilerGenerated]
		get
		{
			return default(FMHJKFCFNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xF4F760", Offset = "0xF4E160", VA = "0x180F4F760")]
	public IBMNMGLBDEG(FMHJKFCFNOJ NBBMMINMBNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class NNAMEJEONOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DAOJGNOGCID KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager LNPEGOPJJGK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DAOJGNOGCID CMJHCGAKNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x554F030", Offset = "0x554DA30", VA = "0x18554F030")]
	public NNAMEJEONOI(DAOJGNOGCID KHDPJJEDHOA, EntityManager LNPEGOPJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x39DB820", Offset = "0x39DA220", VA = "0x1839DB820")]
	public bool JNNJPIJIDCB<T>(Entity FLADPKIONGF) where T : struct, AAHHDGCMAGO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x39DB860", Offset = "0x39DA260", VA = "0x1839DB860")]
	public bool MAILMCMPIPE<T>(Entity FLADPKIONGF, out T MAKFNMHIJIF) where T : struct, AAHHDGCMAGO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x39D9640", Offset = "0x39D8040", VA = "0x1839D9640")]
	public T CHLCDKGGGLH<T>(Entity FLADPKIONGF) where T : struct, AAHHDGCMAGO
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x39DB020", Offset = "0x39D9A20", VA = "0x1839DB020")]
	private ComponentType FJMJJIFHNJJ<T>() where T : struct, AAHHDGCMAGO
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x554EF60", Offset = "0x554D960", VA = "0x18554EF60")]
	private ComponentType FJMJJIFHNJJ(Type MCLMFJEAHEC)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class EKPBGJEDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	protected EKPBGJEDCGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class FNHJMJDHPPE<View, Data> : LDCIHJCLMHG where View : struct, AAHHDGCMAGO where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType MDCHNLMJDBP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type CFMGEGMOHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x31E7FA0", Offset = "0x31E69A0", VA = "0x1831E7FA0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type OIOMFNLIMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x31E8AB0", Offset = "0x31E74B0", VA = "0x1831E8AB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int JGCNEPIIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x31E8CE0", Offset = "0x31E76E0", VA = "0x1831E8CE0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x31E7750", Offset = "0x31E6150", VA = "0x1831E7750")]
	public Data HGJBPBOLLLE(Entity FLADPKIONGF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x31E76E0", Offset = "0x31E60E0", VA = "0x1831E76E0")]
	public Data FLABDBPHJLG(Entity FLADPKIONGF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View EPPJDKEHJDA(Entity FLADPKIONGF);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2D70B50", Offset = "0x2D6F550", VA = "0x182D70B50", Slot = "15")]
	protected internal override T EPPJDKEHJDA<T>(Entity FLADPKIONGF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x14A8070", Offset = "0x14A6A70", VA = "0x1814A8070")]
	protected FNHJMJDHPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class LDCIHJCLMHG : BCFEIPPIFOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic OCGADIDKGAG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager BPLKCGNFBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x838A50", Offset = "0x837450", VA = "0x180838A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type CFMGEGMOHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type OIOMFNLIMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int JGCNEPIIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type AJLAJCNPKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x795800", Offset = "0x794200", VA = "0x180795800", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int NBBIELIHPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x554E650", Offset = "0x554D050", VA = "0x18554E650", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private DHPNCKOALMM[] EECNCILCMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x795730", Offset = "0x794130", VA = "0x180795730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual DHPNCKOALMM[] DICNKIMDLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x554E590", Offset = "0x554CF90", VA = "0x18554E590", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EEDFJHCDHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x554E4A0", Offset = "0x554CEA0", VA = "0x18554E4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x554E6C0", Offset = "0x554D0C0", VA = "0x18554E6C0")]
	public void OIEJOMHJJDA(EntityManager LNPEGOPJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
	protected BCFEIPPIFOG BIDICBKOPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T EPPJDKEHJDA<T>(Entity FLADPKIONGF) where T : struct, AAHHDGCMAGO;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x554E4D0", Offset = "0x554CED0", VA = "0x18554E4D0", Slot = "8")]
	public (uint, uint) FFMFCFOLMGH(Entity FLADPKIONGF)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x554E410", Offset = "0x554CE10", VA = "0x18554E410", Slot = "9")]
	public bool CHICEPFNPLC(Entity FLADPKIONGF, (uint order, uint change) AJGHIJIKOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	protected LDCIHJCLMHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class CEHBFJKCPOI<Data> : PDFDIHHBJJI where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data MKNJDLGIAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2898DB0", Offset = "0x28977B0", VA = "0x182898DB0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x22D0710", Offset = "0x22CF110", VA = "0x1822D0710", Slot = "8")]
	protected virtual bool HABKFPAJILN(ReadOnlySpan<Data> EPKPHBHDHGH, LHDHMGCHIDM IHGCOMBDNKO, out ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "9")]
	protected virtual bool DFCKKOIGNHF(int AJGHIJIKOBE, Span<Data> EPKPHBHDHGH, in ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2898C60", Offset = "0x2897660", VA = "0x182898C60", Slot = "5")]
	internal sealed override bool HABKFPAJILN(ref Unity.Entities.Chunk ANLGKBAEBBF, int FNPPKCIEMHM, LHDHMGCHIDM IHGCOMBDNKO, out ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x28977F0", Offset = "0x28961F0", VA = "0x1828977F0", Slot = "6")]
	internal sealed override bool DFCKKOIGNHF(int AJGHIJIKOBE, ref Unity.Entities.Chunk ANLGKBAEBBF, int FNPPKCIEMHM, in ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D6BBE0", Offset = "0x2D6A5E0", VA = "0x182D6BBE0")]
	protected global::HJAAGDECNFB<Protobuf> AGELLCCOLKH<Protobuf>(ReadOnlySpan<Data> EPKPHBHDHGH) where Protobuf : IMessage, new()
	{
		return default(global::HJAAGDECNFB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D6BC30", Offset = "0x2D6A630", VA = "0x182D6BC30")]
	protected global::IMKHFHJHGID<Protobuf> CLCKCHBNIPN<Protobuf>(ReadOnlySpan<byte> FJHIHOOEHJM, ReadOnlySpan<Data> EPKPHBHDHGH, Action<Protobuf> PPKMMFHNOLF) where Protobuf : IMessage, new()
	{
		return default(global::IMKHFHJHGID<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x14A8070", Offset = "0x14A6A70", VA = "0x1814A8070")]
	protected CEHBFJKCPOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class PDFDIHHBJJI
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int HOBPJIMDIAG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x554F620", Offset = "0x554E020", VA = "0x18554F620", Slot = "5")]
	internal virtual bool HABKFPAJILN(ref Unity.Entities.Chunk ANLGKBAEBBF, int FNPPKCIEMHM, LHDHMGCHIDM IHGCOMBDNKO, out ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "6")]
	internal virtual bool DFCKKOIGNHF(int AJGHIJIKOBE, ref Unity.Entities.Chunk ANLGKBAEBBF, int FNPPKCIEMHM, in ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	protected PDFDIHHBJJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HGCMHGOBKJN<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo EALPAIFGGJG(TFrom MAKFNMHIJIF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KDDDCGDGPEN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDLAMKDIKHH(T MAKFNMHIJIF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct AFPHAABIGCA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::HGCMHGOBKJN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> MAJLHADOHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> NJILIONKKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap PBOHOIMMGFG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct FJADBIFDCGG<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::HGCMHGOBKJN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> PNHPNMEDDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> NJILIONKKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap PBOHOIMMGFG;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct PJHJJDJJAIN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AHHANDCDMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> MAJLHADOHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> NJILIONKKCN;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x317B1F0", Offset = "0x3179BF0", VA = "0x18317B1F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct GPMCCBNJEBF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AHHANDCDMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> MAJLHADOHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> FFALCHDMCMB;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct FIGNAMONKLP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::HGCMHGOBKJN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> GIFMOPNMMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> NJILIONKKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap PBOHOIMMGFG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct NKKCJMEIFJC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MHGOOECIHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> FOMMJLEICDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> PFKEAEABPFE;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct FLJNCCMANEN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MHGOOECIHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> FOMMJLEICDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> PFKEAEABPFE;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x31E72B0", Offset = "0x31E5CB0", VA = "0x1831E72B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct MHAEGHMJNNL<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> MAJLHADOHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> FFALCHDMCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, ABCENELPPGI> LGPKJBBIKKA;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2E99B00", Offset = "0x2E98500", VA = "0x182E99B00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct GOMKFDIIPLB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::HGCMHGOBKJN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> MAJLHADOHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> FFALCHDMCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, ABCENELPPGI> LGPKJBBIKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap PBOHOIMMGFG;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct PHIOMICBOLI<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::KDDDCGDGPEN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> MAJLHADOHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> FFALCHDMCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate PBOHOIMMGFG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct NPBACAKFBIG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public KAHEOPHNBCB MHGOOECIHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> FOMMJLEICDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> KEOHKGFHBNO;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x554F0F0", Offset = "0x554DAF0", VA = "0x18554F0F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct CPMDNNBEGLA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public KAHEOPHNBCB MHGOOECIHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> FOMMJLEICDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> KEOHKGFHBNO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x554ADB0", Offset = "0x55497B0", VA = "0x18554ADB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class FKNFCDCDOIL
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class BEHNNFDDJHK
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x25E1D10", Offset = "0x25E0710", VA = "0x1825E1D10")]
	public static bool OGDNFDKHCOB<T>(this NativeArray<Entity> FOMMJLEICDI, EntityManager LNPEGOPJJGK, Allocator GGLOKAHPEPM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class OMHLMOLLLHA
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class KMBINAALBCA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public KMBINAALBCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class OLIFKGNMIPD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public OLIFKGNMIPD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> GNJMFOAHPBC;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x554F590", Offset = "0x554DF90", VA = "0x18554F590")]
	public OMHLMOLLLHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CBOGFKKLKLG
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KAPDOMGNKAM
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct PFNCENNFOBI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct ALAIEPFNHBO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal PFNCENNFOBI<TFrom> LFAIGCEGCPL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator GGLOKAHPEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> EIAMEKHGGAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct APGLEBAHFHM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct PMCJDGABFBN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal APGLEBAHFHM<TFrom> LFAIGCEGCPL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator GGLOKAHPEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> EIAMEKHGGAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct LOFGJPBGCGG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct MDGDLLAEPJF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal LOFGJPBGCGG<TFrom> LFAIGCEGCPL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator GGLOKAHPEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal global::AFMKKOBINHK<TFrom> EIAMEKHGGAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct LAKCIGCLMAM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct NHAAIKIIDGB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal LAKCIGCLMAM<TFrom> LFAIGCEGCPL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator GGLOKAHPEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal global::NLPBCKKLMDB<TFrom> EIAMEKHGGAJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class IDHPPHBDPFP
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class EJNNLLJOCOL
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x254AC50", Offset = "0x2549650", VA = "0x18254AC50")]
	public static NativeList<T> ECPLKGMCDPG<T>(this NativeArray<T> LLLHIHGCNEF, Allocator GGLOKAHPEPM = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class KEGPBMHMFLK
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x22A2450", Offset = "0x22A0E50", VA = "0x1822A2450")]
	public static NativeArray<T> CBNNLIJPKGC<T>(this NativeList<Entity> LLLHIHGCNEF, EntityManager LNPEGOPJJGK, Allocator GGLOKAHPEPM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x22A2350", Offset = "0x22A0D50", VA = "0x1822A2350")]
	public static NativeArray<T> CBNNLIJPKGC<T>(this NativeArray<Entity> LLLHIHGCNEF, EntityManager LNPEGOPJJGK, Allocator GGLOKAHPEPM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class KBOPGNLNGNA
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct FHPMDEHKMFF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct DDNHCFCJICF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public FHPMDEHKMFF<TFrom> EIAMEKHGGAJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator GGLOKAHPEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> MAJLHADOHJK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct HJKOGOPIJPB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct CAPFHIGPAEJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public HJKOGOPIJPB<TFrom> EIAMEKHGGAJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator GGLOKAHPEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public global::AFMKKOBINHK<TFrom> MAJLHADOHJK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct FILDFPAGGGF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct HOCKMBIMIML<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public FILDFPAGGGF<TFrom> EIAMEKHGGAJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator GGLOKAHPEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public global::NLPBCKKLMDB<TFrom> MAJLHADOHJK;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class GJOGGDCCIOA
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class BABKOKENCJA
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct NOHNAOGDIJE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator GGLOKAHPEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> MAJLHADOHJK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct JIILEEGPFFN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator GGLOKAHPEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> MAJLHADOHJK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct GHJEIBBICCL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator GGLOKAHPEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public global::AFMKKOBINHK<T> MAJLHADOHJK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct MDCENFIBBNC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator GGLOKAHPEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public global::NLPBCKKLMDB<T> MAJLHADOHJK;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class OAKONKBIHIG
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class IMICLBKNGNJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x25F2D60", Offset = "0x25F1760", VA = "0x1825F2D60")]
	public static NativeList<Entity> GOFDMHLJDNA<T>(this NativeArray<Entity> FOMMJLEICDI, EntityManager LNPEGOPJJGK, Allocator GGLOKAHPEPM = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MMBMFKIOIBI
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface EOAGFLCNOJF
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JGEAFEFOMNH
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class NBOJDHPMAMI
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class ENNGGNNBACE
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x554C9B0", Offset = "0x554B3B0", VA = "0x18554C9B0")]
	public static bool LAOGKHBOPFK(Type MCLMFJEAHEC, Type GJHAJAIGCMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class AGBMNBALCAL<Attribute, BaseClass> : global::MDDBBGFDMGN<BaseClass>, MABIIIHNJEH where Attribute : JOAMECNEEFA
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly FGGEJMNNOEE LAEOPKAJMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string NBODBMLPNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> KKDJEBLKHMF;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x322EA10", Offset = "0x322D410", VA = "0x18322EA10")]
	public AGBMNBALCAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x322E720", Offset = "0x322D120", VA = "0x18322E720", Slot = "4")]
	public bool HEBLGIOGKGC(int HIMMGNBBIHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x322E3E0", Offset = "0x322CDE0", VA = "0x18322E3E0", Slot = "5")]
	public global::CBENKMECBMN<BaseClass> FJFLJBDONNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x322E8B0", Offset = "0x322D2B0", VA = "0x18322E8B0", Slot = "7")]
	protected virtual bool LAOGKHBOPFK(Type MCLMFJEAHEC, int CDADCJFJKFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x322E780", Offset = "0x322D180", VA = "0x18322E780", Slot = "8")]
	protected virtual int JNEKCABGOMM(Type MCLMFJEAHEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x322E690", Offset = "0x322D090", VA = "0x18322E690")]
	public void GBDHAHIIBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x322E810", Offset = "0x322D210", VA = "0x18322E810", Slot = "6")]
	public void KOEBKPOFGOP(Type MCLMFJEAHEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class CBENKMECBMN<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> BEPBBHIKBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> NNAKCBHNDGO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> KGGCNJKEFAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2F2AC20", Offset = "0x2F29620", VA = "0x182F2AC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2F2AF70", Offset = "0x2F29970", VA = "0x182F2AF70")]
	public CBENKMECBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F2B100", Offset = "0x2F29B00", VA = "0x182F2B100")]
	public CBENKMECBMN(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2F2AE50", Offset = "0x2F29850", VA = "0x182F2AE50")]
	internal void MFMCNFFMIAP(int HIMMGNBBIHM, BaseClass EENBDKCLMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D6A8D0", Offset = "0x2D692D0", VA = "0x182D6A8D0")]
	public bool MPFJBMOGOMP<T>(out BaseClass MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F2AED0", Offset = "0x2F298D0", VA = "0x182F2AED0")]
	public bool MPFJBMOGOMP(Type ALGBEENOGLE, out BaseClass MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2585D30", Offset = "0x2584730", VA = "0x182585D30")]
	public bool PKEKFKIENAA(int HIMMGNBBIHM, out BaseClass MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2D6A7F0", Offset = "0x2D691F0", VA = "0x182D6A7F0")]
	public T ELMJAHBLMEP<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2F2ABF0", Offset = "0x2F295F0", VA = "0x182F2ABF0")]
	public BaseClass ELMJAHBLMEP(Type BNPLNNFNMPH)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class BKKJILPLEII : global::AGBMNBALCAL<AOABIAIICLA, EKPBGJEDCGJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x554A4B0", Offset = "0x5548EB0", VA = "0x18554A4B0")]
	public BKKJILPLEII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FIDEDHLOPBM : global::AGBMNBALCAL<LAOLKNOEOBH, LDCIHJCLMHG>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x554CE70", Offset = "0x554B870", VA = "0x18554CE70")]
	public FIDEDHLOPBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class ECIECLPCNKB : global::AGBMNBALCAL<BPAPKMJCHMP, PDFDIHHBJJI>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x554C940", Offset = "0x554B340", VA = "0x18554C940")]
	public ECIECLPCNKB()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[DAINLFLPADL(OHEDAGNNHJA.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> KJJNFLPAOCJ;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x88CB80", Offset = "0x88B580", VA = "0x18088CB80")]
		private ComponentSystemTypes(List<Type> KJJNFLPAOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x554B130", Offset = "0x5549B30", VA = "0x18554B130")]
		public static void GBDHAHIIBFE(List<Type> KJJNFLPAOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x554AEF0", Offset = "0x55498F0", VA = "0x18554AEF0")]
		private void FPLBPAFGKNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x554B220", Offset = "0x5549C20", VA = "0x18554B220")]
		private bool LAOGKHBOPFK(Type MCLMFJEAHEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x554B1C0", Offset = "0x5549BC0", VA = "0x18554B1C0")]
		private void KDJENMMFLEJ(Type MCLMFJEAHEC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class OILIIHGJOFP : HMNHMIKHJNF
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x554F1D0", Offset = "0x554DBD0", VA = "0x18554F1D0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase GADCGJMGDAF();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x554F180", Offset = "0x554DB80", VA = "0x18554F180")]
	protected ComponentSystemBase NHMAABKLMAM(params ComponentSystemBase[] FLDPOGAHGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x35E0750", Offset = "0x35DF150", VA = "0x1835E0750")]
	protected ComponentSystemBase NHMAABKLMAM<T>(params ComponentSystemBase[] FLDPOGAHGIJ) where T : HMNHMIKHJNF, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x35E0710", Offset = "0x35DF110", VA = "0x1835E0710")]
	protected ComponentSystemBase ONFPCELIIGJ<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x35E0710", Offset = "0x35DF110", VA = "0x1835E0710")]
	protected ComponentSystemBase KGJKLFFINCC<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	protected OILIIHGJOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface MDDBBGFDMGN<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEBLGIOGKGC(int HIMMGNBBIHM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::CBENKMECBMN<BaseClass> FJFLJBDONNP();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class HMNHMIKHJNF : MGIENGIJDAI
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x554DCD0", Offset = "0x554C6D0", VA = "0x18554DCD0", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public HMNHMIKHJNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class CPOPPILPLCL : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x554AE40", Offset = "0x5549840", VA = "0x18554AE40")]
	public KAHEOPHNBCB FLOKLGDOEKF(int HIMMGNBBIHM, bool JPIIMKIJCFB = false)
	{
		return default(KAHEOPHNBCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x554AEE0", Offset = "0x55498E0", VA = "0x18554AEE0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0")]
	protected CPOPPILPLCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class LNFENIBMHJN : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0")]
	protected LNFENIBMHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class GJKIDHCFCFK : CPOPPILPLCL
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x554D700", Offset = "0x554C100", VA = "0x18554D700", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	protected void KKKEBBLEFHK(string MLGGMMOFMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0")]
	protected GJKIDHCFCFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class LKNJFEKBGPP
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class MGIENGIJDAI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	protected MGIENGIJDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[DAINLFLPADL(OHEDAGNNHJA.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x554FA30", Offset = "0x554E430", VA = "0x18554FA30")]
		public static ComponentSystemGroup[] BMBGBCHENNG(World KHDPJJEDHOA, LMDIBHKADJN AHGHICEFJLH = LMDIBHKADJN.Default, bool JDOJNLHMLPF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x554F6D0", Offset = "0x554E0D0", VA = "0x18554F6D0")]
		private static Type[] AEIPCGHPAHB(LMDIBHKADJN AHGHICEFJLH, bool JDOJNLHMLPF, ComponentSystemGroup[] HEDPAPLAOED, ComponentSystemGroup MDMIMMFINAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x554FC30", Offset = "0x554E630", VA = "0x18554FC30")]
		private static ComponentSystemGroup[] CIEIEGJJNPN(World KHDPJJEDHOA, out ComponentSystemGroup MDMIMMFINAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x554FF40", Offset = "0x554E940", VA = "0x18554FF40")]
		internal static bool CNPAPJJAMEP(FMHJKFCFNOJ NBBMMINMBNH, out CMHOIGNLIPP NMJCFNKPGHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5550740", Offset = "0x554F140", VA = "0x185550740")]
		private static ComponentSystemGroup PGKFBHGPHEE(Type MCLMFJEAHEC, World KHDPJJEDHOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x554FB00", Offset = "0x554E500", VA = "0x18554FB00")]
		private static ComponentSystemGroup[] BOJMAKFGFIH(Type[] KJJNFLPAOCJ, World KHDPJJEDHOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x55501C0", Offset = "0x554EBC0", VA = "0x1855501C0")]
		internal static void EKOKCOLHKOI(World KHDPJJEDHOA, Type[] NOHEEBHAGEC, ComponentSystemGroup[] HEDPAPLAOED, ComponentSystemGroup MDMIMMFINAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5550820", Offset = "0x554F220", VA = "0x185550820")]
		internal static bool PMMFBFOFBCB(ComponentSystemBase HKMOJLJDDFO, ComponentSystemGroup[] HEDPAPLAOED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x55506E0", Offset = "0x554F0E0", VA = "0x1855506E0")]
		private static void JDGECOGEOID(ComponentSystemGroup[] HEDPAPLAOED)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct FDFOJJLLKBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> AMMMFHGINOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> FLDPOGAHGIJ;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x727A10", Offset = "0x726410", VA = "0x180727A10")]
	public FDFOJJLLKBA(Dictionary<Type, List<Type>> AMMMFHGINOE, HashSet<Type> FLDPOGAHGIJ)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[DAINLFLPADL(OHEDAGNNHJA.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class OKLGNGEGLAH : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E7E10", VA = "0x1808E9410")]
			[DebuggerHidden]
			public OKLGNGEGLAH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x554F4B0", Offset = "0x554DEB0", VA = "0x18554F4B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x554F210", Offset = "0x554DC10", VA = "0x18554F210", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x554F540", Offset = "0x554DF40", VA = "0x18554F540")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x554F470", Offset = "0x554DE70", VA = "0x18554F470", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x554F3C0", Offset = "0x554DDC0", VA = "0x18554F3C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x554F3C0", Offset = "0x554DDC0", VA = "0x18554F3C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct DAGDIHFCPOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type KKCKLENOLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private LMDIBHKADJN AHGHICEFJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool KGCANIPKCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool AOCKLLCMNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool JDOJNLHMLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> PEGEBAAPDCG;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5550D40", Offset = "0x554F740", VA = "0x185550D40")]
		public static RRFilterWorldSystems CBFHJGEFJHE()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5550DF0", Offset = "0x554F7F0", VA = "0x185550DF0")]
		public RRFilterWorldSystems COOFIONFHJO(LMDIBHKADJN NBBMMINMBNH)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x55514F0", Offset = "0x554FEF0", VA = "0x1855514F0")]
		public RRFilterWorldSystems OCDCMCKOKLP(IEnumerable<Type> KJJNFLPAOCJ)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5551440", Offset = "0x554FE40", VA = "0x185551440")]
		public RRFilterWorldSystems HPMLNPHLAIH(bool OAAJPAICKOF)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5551450", Offset = "0x554FE50", VA = "0x185551450")]
		public RRFilterWorldSystems IDCGLKHKAAG(bool MEIIGEANOKE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5551460", Offset = "0x554FE60", VA = "0x185551460")]
		public FDFOJJLLKBA KHCOLCFBPDI(Type[] CBPLLNEFHMI)
		{
			return default(FDFOJJLLKBA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5550D60", Offset = "0x554F760", VA = "0x185550D60")]
		[IteratorStateMachine(typeof(OKLGNGEGLAH))]
		internal IEnumerable<Type> CNLLKHDIDAO(IEnumerable<Type> KJJNFLPAOCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5551530", Offset = "0x554FF30", VA = "0x185551530")]
		internal Dictionary<Type, List<Type>> PIKMKMNDPHD(IEnumerable<Type> KJJNFLPAOCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5550A70", Offset = "0x554F470", VA = "0x185550A70")]
		private void AGBLLOPBGGG(Dictionary<Type, List<Type>> PAHCBODMCHK, Type MCLMFJEAHEC, Type IBHPOPBOIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5550B80", Offset = "0x554F580", VA = "0x185550B80")]
		internal HashSet<Type> BHKNCNNMAFF(IEnumerable<Type> HEDPAPLAOED, Dictionary<Type, List<Type>> BLDLHAOGGDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5550E00", Offset = "0x554F800", VA = "0x185550E00")]
		internal bool EOAOAAINNHO(Type MCLMFJEAHEC, LMDIBHKADJN AHGHICEFJLH, bool JDOJNLHMLPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5550910", Offset = "0x554F310", VA = "0x185550910")]
		[CompilerGenerated]
		internal static void AFHMCGLAPFL(Type MCLMFJEAHEC, ref DAGDIHFCPOF P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class LBEKFOLCCOE
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool PHMAAFIDHJK;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x554E3B0", Offset = "0x554CDB0", VA = "0x18554E3B0")]
	public static void OIEJOMHJJDA(bool CBEIFKNKIIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x554E1F0", Offset = "0x554CBF0", VA = "0x18554E1F0")]
	private static void KCJLNCDJAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class FBJIMAFGNOI
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x554CE40", Offset = "0x554B840", VA = "0x18554CE40")]
	public static ulong EBGIHOEGOAO(Type MCLMFJEAHEC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x554CD80", Offset = "0x554B780", VA = "0x18554CD80")]
	public static ulong EBGIHOEGOAO(string IFBMBEGOEBI)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[DAINLFLPADL(OHEDAGNNHJA.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct LKAGDIHEDGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong EBKKOCLILFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong NGJALHBFBFO;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xF4CE50", Offset = "0xF4B850", VA = "0x180F4CE50")]
			public LKAGDIHEDGL(ulong PDABAAIKDHN, ulong FKINAIONFFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x554E7E0", Offset = "0x554D1E0", VA = "0x18554E7E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> PGCGMOBCJFL;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static LKAGDIHEDGL[] FBDJHCFPHOI;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool PHMAAFIDHJK;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x55521E0", Offset = "0x5550BE0", VA = "0x1855521E0")]
		public static ulong HHALPMBCHBK(int HIMMGNBBIHM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5552240", Offset = "0x5550C40", VA = "0x185552240")]
		public static int KHJCDGCMAFG(ulong FKINAIONFFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5552300", Offset = "0x5550D00", VA = "0x185552300")]
		public static void OIEJOMHJJDA(bool CBEIFKNKIIE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x55519E0", Offset = "0x55503E0", VA = "0x1855519E0")]
		private static void AGIJDFEALOD(int HENEENHMBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5551E30", Offset = "0x5550830", VA = "0x185551E30")]
		private static void GIPPPFGLDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x55524F0", Offset = "0x5550EF0", VA = "0x1855524F0")]
		private static LKAGDIHEDGL OKHOKHAEDNF(Type MCLMFJEAHEC)
		{
			return default(LKAGDIHEDGL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5551DC0", Offset = "0x55507C0", VA = "0x185551DC0")]
		private static ulong DOENOHONIAD(Type MCLMFJEAHEC, ulong FKINAIONFFA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5551BA0", Offset = "0x55505A0", VA = "0x185551BA0")]
		private static void COODNELOPCC(in LKAGDIHEDGL LPNCPIDHKNJ, TypeManager.TypeInfo BAODNDIFHDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x55518E0", Offset = "0x55502E0", VA = "0x1855518E0")]
		private static void ACPGOBKGNFF(LKAGDIHEDGL BAODNDIFHDH, int HIMMGNBBIHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5551AC0", Offset = "0x55504C0", VA = "0x185551AC0")]
		private static void AMEHPOHCICC(LKAGDIHEDGL BAODNDIFHDH, int HIMMGNBBIHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5552150", Offset = "0x5550B50", VA = "0x185552150")]
		private static LKAGDIHEDGL GNCBEKGOEPA(int HIMMGNBBIHM)
		{
			return default(LKAGDIHEDGL);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x55522F0", Offset = "0x5550CF0", VA = "0x1855522F0")]
		private static int OFPEIMCHEOK(int HIMMGNBBIHM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class CENMONHLEPD
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly FIDEDHLOPBM DNKMNCJNKNI;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly ECIECLPCNKB PBPDBHGLFHE;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly BKKJILPLEII GOGOHKDAIMB;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> AKOJPPNNJJK;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool PHMAAFIDHJK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::MDDBBGFDMGN<LDCIHJCLMHG> PDMCBIPBNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x554A660", Offset = "0x5549060", VA = "0x18554A660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::MDDBBGFDMGN<PDFDIHHBJJI> CGFDDNLDGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x554A5A0", Offset = "0x5548FA0", VA = "0x18554A5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::MDDBBGFDMGN<EKPBGJEDCGJ> JGONAJHDKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x554A600", Offset = "0x5549000", VA = "0x18554A600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x554A6C0", Offset = "0x55490C0", VA = "0x18554A6C0")]
	public static void OIEJOMHJJDA(bool CBEIFKNKIIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x554A520", Offset = "0x5548F20", VA = "0x18554A520")]
	public static Type[] EOAGABPEMPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class NLODCBHLCEA
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> KCFEMLHCPAA;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool PHMAAFIDHJK;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x554EAA0", Offset = "0x554D4A0", VA = "0x18554EAA0")]
	public static int FFMFCFOLMGH(int HIMMGNBBIHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x554EDC0", Offset = "0x554D7C0", VA = "0x18554EDC0")]
	public static void OIEJOMHJJDA(bool CBEIFKNKIIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x554EB40", Offset = "0x554D540", VA = "0x18554EB40")]
	private static void NOALDLJMJOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x554EA50", Offset = "0x554D450", VA = "0x18554EA50")]
	private static int CECMCJHAJHE(Type MCLMFJEAHEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x554EE60", Offset = "0x554D860", VA = "0x18554EE60")]
	private static void PGHHBKOCHPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class DAOJGNOGCID : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World PEOBGDFFFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NNAMEJEONOI EENBDKCLMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] HEDPAPLAOED;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World CMJHCGAKNHD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World KBIJMFLFDFC
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager BPLKCGNFBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8E1660", Offset = "0x8E0060", VA = "0x1808E1660")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public NNAMEJEONOI MLIEHBECBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::CBENKMECBMN<LDCIHJCLMHG> PDMCBIPBNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E4E0", VA = "0x18070FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::CBENKMECBMN<PDFDIHHBJJI> CGFDDNLDGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67CF70", VA = "0x18067E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x67E590", Offset = "0x67CF90", VA = "0x18067E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::CBENKMECBMN<EKPBGJEDCGJ> JGONAJHDKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x67E580", Offset = "0x67CF80", VA = "0x18067E580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x67E5A0", Offset = "0x67CFA0", VA = "0x18067E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> ABBJLIEIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8E16A0", Offset = "0x8E00A0", VA = "0x1808E16A0")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] FGGGHFAGEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x554BC10", Offset = "0x554A610", VA = "0x18554BC10")]
	public static DAOJGNOGCID NDCCACLNKIG(string NBODBMLPNJA, FMHJKFCFNOJ NBBMMINMBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x554BD30", Offset = "0x554A730", VA = "0x18554BD30")]
	public DAOJGNOGCID(string NBODBMLPNJA, FMHJKFCFNOJ NBBMMINMBNH = FMHJKFCFNOJ.Simulation, LMDIBHKADJN AHGHICEFJLH = LMDIBHKADJN.Default, bool CBEIFKNKIIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x554BC90", Offset = "0x554A690", VA = "0x18554BC90")]
	public ComponentSystemBase NMMLCJKFAEA(Type MCLMFJEAHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1C48250", Offset = "0x1C46C50", VA = "0x181C48250")]
	public T NMMLCJKFAEA<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x554B730", Offset = "0x554A130", VA = "0x18554B730")]
	public void DFHDCFOIOCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x554B800", Offset = "0x554A200", VA = "0x18554B800")]
	public void EAGHLIILKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x554BAF0", Offset = "0x554A4F0", VA = "0x18554BAF0")]
	public void LJBEHGPGGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x554B9A0", Offset = "0x554A3A0", VA = "0x18554B9A0")]
	public void HJCLLJGNECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x554BB50", Offset = "0x554A550", VA = "0x18554BB50")]
	public void LOLJJIPEIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x554BA90", Offset = "0x554A490", VA = "0x18554BA90")]
	public void LCKLGKEJONF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x554B2F0", Offset = "0x5549CF0", VA = "0x18554B2F0")]
	public void ADBKDFFPJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x554BA00", Offset = "0x554A400", VA = "0x18554BA00")]
	public void IHAAIJLACPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x554BBB0", Offset = "0x554A5B0", VA = "0x18554BBB0")]
	public void MAKAAILEALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x554B860", Offset = "0x554A260", VA = "0x18554B860")]
	public void FBMFPGJNNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x554B8C0", Offset = "0x554A2C0", VA = "0x18554B8C0")]
	internal void GMFLDBGAHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x554BCB0", Offset = "0x554A6B0", VA = "0x18554BCB0")]
	private bool PEPLPCFKDFH(ComponentSystemGroup NABGGPANDBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x554B460", Offset = "0x5549E60", VA = "0x18554B460")]
	private void BONDJDEKHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x554B350", Offset = "0x5549D50", VA = "0x18554B350")]
	private ComponentSystemGroup[] BMBGBCHENNG(LMDIBHKADJN AHGHICEFJLH, bool JDOJNLHMLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x554B790", Offset = "0x554A190", VA = "0x18554B790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum FMHJKFCFNOJ
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
public sealed class CAPAENMCMMB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public LMDIBHKADJN NIKINJDDAOL;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum LMDIBHKADJN
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
public interface CMHOIGNLIPP
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type HJBKGIGKPIP
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] GIBIOLDFAAO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class PFDNMICPDCC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool DCEIJGELLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696A20", VA = "0x180698020", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	protected PFDNMICPDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class BNOGFJKHCCG : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public BNOGFJKHCCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class MIDLJCMMMGD : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public MIDLJCMMMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class JJLONPGGJEC : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public JJLONPGGJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class ABLCJOKJLKE : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public ABLCJOKJLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class CODLCFFJGHP : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public CODLCFFJGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class HLMANKFCDIJ : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public HLMANKFCDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class GEBKMMJCFHB : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public GEBKMMJCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class FMGKIBHKAMG : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public FMGKIBHKAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class OHCABJHLPDG : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public OHCABJHLPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class DIAIFMCDODP : ADPHDPBLAAH
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public DIAIFMCDODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class NMGKDAKPLLN : ADPHDPBLAAH
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public NMGKDAKPLLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class DEMECKJCLKL : ADPHDPBLAAH
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public DEMECKJCLKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class HDLEHDDPGDO : ADPHDPBLAAH
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public HDLEHDDPGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[COKNBEFPPIE(HIFIKBEHMNK.Application)]
public class ADPHDPBLAAH : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool DCEIJGELLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x554A4A0", Offset = "0x5548EA0", VA = "0x18554A4A0")]
	public ADPHDPBLAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class CPNFHFBMMGK : EIOKMAELDBG
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public CPNFHFBMMGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class GKAOKGOEFNF
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void ELAEFGJBCAO<From, To>(From EIAMEKHGGAJ, ref To DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class PNMPOHHBOFC<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static ELAEFGJBCAO<From, To> GJNHBCODKAO;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public PNMPOHHBOFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x554D730", Offset = "0x554C130", VA = "0x18554D730")]
	static GKAOKGOEFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x24F9120", Offset = "0x24F7B20", VA = "0x1824F9120")]
	public static void JKFOFONBOOA<T>(ELAEFGJBCAO<T, T> LMIPPCBLACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x24F8EE0", Offset = "0x24F78E0", VA = "0x1824F8EE0")]
	public static void JKFOFONBOOA<From, To>(ELAEFGJBCAO<From, To> LMIPPCBLACH, ELAEFGJBCAO<To, From> FMLFONLNFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x24F8E90", Offset = "0x24F7890", VA = "0x1824F8E90")]
	public static void JKFOFONBOOA<From, To>(ELAEFGJBCAO<From, To> GJNHBCODKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x24F3C10", Offset = "0x24F2610", VA = "0x1824F3C10")]
	public static ELAEFGJBCAO<From, To> DMCFJJDMDMN<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x24FAF10", Offset = "0x24F9910", VA = "0x1824FAF10")]
	public static void PLMJBMGGDBE<From, To>(From EIAMEKHGGAJ, ref To DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class LHDHMGCHIDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> FICEFMOJFKC;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xD705F0", Offset = "0xD6EFF0", VA = "0x180D705F0")]
	public LHDHMGCHIDM(NativeArray<EntityRemapUtility.EntityRemapInfo> FICEFMOJFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D2F0", Offset = "0x2F1BCF0", VA = "0x182F1D2F0")]
	public Entity HJJKDENBCMF(Entity CELBLIIOMDE)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class EPOHJPFDFAP
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> IABJLMHGKOO;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x554CB90", Offset = "0x554B590", VA = "0x18554CB90")]
	public static bool LMPBKMEHEOE(ulong ECCMGNHBKIL, uint AJGHIJIKOBE, out string NBODBMLPNJA)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[DAINLFLPADL(OHEDAGNNHJA.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct MAEMELBPCKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int DNFPKCNMAKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int HOBPJIMDIAG;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x698050", Offset = "0x696A50", VA = "0x180698050")]
			public MAEMELBPCKG(int EBBLFLFCHFB, int AJGHIJIKOBE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct GNANPGDFHBE
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch BJBNCBNGCEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long JCJBGGEHJCO;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long KAHLIBHKHDC
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x554DA80", Offset = "0x554C480", VA = "0x18554DA80")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long DNLJFHDEAGA
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x554DA10", Offset = "0x554C410", VA = "0x18554DA10")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x554DAE0", Offset = "0x554C4E0", VA = "0x18554DAE0")]
			public static GNANPGDFHBE PMIJFIGEABJ()
			{
				return default(GNANPGDFHBE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct GAFBBFMCODN : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct IIGNDJMMAIO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* OJCAPAOALJK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly MFMBPJFJOGF.PIPCCENKNMO.HHCEANFINJG JKJLCIHNEKP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly LHDHMGCHIDM IHGCOMBDNKO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::CBENKMECBMN<PDFDIHHBJJI> HLCNJFHNKCM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int FNPPKCIEMHM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int LCDLJNKCNOD;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x554E0D0", Offset = "0x554CAD0", VA = "0x18554E0D0")]
				public unsafe IIGNDJMMAIO(Unity.Entities.Archetype* OJCAPAOALJK, MFMBPJFJOGF.PIPCCENKNMO.HHCEANFINJG JKJLCIHNEKP, LHDHMGCHIDM IHGCOMBDNKO, global::CBENKMECBMN<PDFDIHHBJJI> HLCNJFHNKCM, int FNPPKCIEMHM, int LCDLJNKCNOD = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x554E130", Offset = "0x554CB30", VA = "0x18554E130")]
				public IIGNDJMMAIO(in IIGNDJMMAIO JIHCLPECHIB, int LCDLJNKCNOD)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly IIGNDJMMAIO[] EPKPHBHDHGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] LDHNAMLHFCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int MPLDBLLPNEO;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x554D5C0", Offset = "0x554BFC0", VA = "0x18554D5C0")]
			public GAFBBFMCODN(IIGNDJMMAIO[] EPKPHBHDHGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x554D1B0", Offset = "0x554BBB0", VA = "0x18554D1B0", Slot = "4")]
			public void Invoke(int EBBLFLFCHFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x554D210", Offset = "0x554BC10", VA = "0x18554D210")]
			private void PAFIPANAKHG(in IIGNDJMMAIO JIHCLPECHIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x554CEE0", Offset = "0x554B8E0", VA = "0x18554CEE0")]
			private static void HLIHFNEACNL(in IIGNDJMMAIO JIHCLPECHIB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class PGBOBBHDIOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public MFMBPJFJOGF asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::CBENKMECBMN<PDFDIHHBJJI> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public PGBOBBHDIOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x554F640", Offset = "0x554E040", VA = "0x18554F640")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class GIFOLFFFOMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public MFMBPJFJOGF.PIPCCENKNMO.HHCEANFINJG srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public PGBOBBHDIOC CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public GIFOLFFFOMP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class DPLHALPPCNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public GIFOLFFFOMP CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public DPLHALPPCNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x554C830", Offset = "0x554B230", VA = "0x18554C830")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly FGGEJMNNOEE CENBFJJCBPG;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly FGGEJMNNOEE DBEAIOGAMOH;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly FGGEJMNNOEE CNBPNLMEODD;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly FGGEJMNNOEE BNBOFABMMGG;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool LOEJODGIGGL;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static MFMBPJFJOGF.PIPCCENKNMO.PNOJHICEHGG LCDJIMGOBKD;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5553820", Offset = "0x5552220", VA = "0x185553820")]
		private unsafe static bool GKGCEFDKAPE(Unity.Entities.Archetype* HEFFAMIFPAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5554700", Offset = "0x5553100", VA = "0x185554700")]
		internal unsafe static Unity.Entities.Archetype*[] MICNHOKNLLF(ref Unity.Entities.EntityComponentStore CCBEKMGKGMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5554640", Offset = "0x5553040", VA = "0x185554640")]
		public static void MHOEBEHGBOJ(DAOJGNOGCID KHDPJJEDHOA, out ByteString FJHIHOOEHJM, out NativeArray<EntityRemapUtility.EntityRemapInfo> HIEMJPKDECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5554B70", Offset = "0x5553570", VA = "0x185554B70")]
		internal static void NOOBLOCBMOM(DAOJGNOGCID KHDPJJEDHOA, MFMBPJFJOGF ALHBBHNIJBI, out NativeArray<EntityRemapUtility.EntityRemapInfo> HIEMJPKDECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x55548E0", Offset = "0x55532E0", VA = "0x1855548E0")]
		private unsafe static UnsafeHashMap<ulong, MAEMELBPCKG> NALAGFAKMHP(Unity.Entities.Archetype*[] AEAFIDJLPMD)
		{
			return default(UnsafeHashMap<ulong, MAEMELBPCKG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5553930", Offset = "0x5552330", VA = "0x185553930")]
		private static void HCILCCEHPNG(MFMBPJFJOGF ALHBBHNIJBI, UnsafeHashMap<ulong, MAEMELBPCKG> JIDNBDOLNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5552D10", Offset = "0x5551710", VA = "0x185552D10")]
		private unsafe static void EKGNAPEHGAN(MFMBPJFJOGF ALHBBHNIJBI, Unity.Entities.Archetype*[] AEAFIDJLPMD, UnsafeHashMap<ulong, MAEMELBPCKG> JIDNBDOLNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x55537B0", Offset = "0x55521B0", VA = "0x1855537B0")]
		private unsafe static int GKFFLKPFFCE(Unity.Entities.Archetype*[] AEAFIDJLPMD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5553B80", Offset = "0x5552580", VA = "0x185553B80")]
		private unsafe static void HLINCFHBHFN(MFMBPJFJOGF ALHBBHNIJBI, Unity.Entities.Archetype*[] AEAFIDJLPMD, global::CBENKMECBMN<PDFDIHHBJJI> HLCNJFHNKCM, NativeArray<EntityRemapUtility.EntityRemapInfo> HIEMJPKDECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5552AA0", Offset = "0x55514A0", VA = "0x185552AA0")]
		private static NativeArray<int> EIEMGFAEBCN(MFMBPJFJOGF ALHBBHNIJBI)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x55542B0", Offset = "0x5552CB0", VA = "0x1855542B0")]
		private static Memory<EntityArchetype> MHBKOHMKNPL(MFMBPJFJOGF ALHBBHNIJBI, NativeArray<int> KJJNFLPAOCJ, EntityManager LNPEGOPJJGK, out int JGMPICFAACP, out int ALLHLNNCNPJ)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x55531A0", Offset = "0x5551BA0", VA = "0x1855531A0")]
		private unsafe static void FKPEHBKFOGG(Unity.Entities.Chunk* PIGGIBAOELK, ReadOnlySpan<byte> FJHIHOOEHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5555980", Offset = "0x5554380", VA = "0x185555980")]
		private static void OODKFMBKCHL(MFMBPJFJOGF ALHBBHNIJBI, NativeArray<int> KJJNFLPAOCJ, Span<EntityArchetype> AEAFIDJLPMD, EntityManager LNPEGOPJJGK, global::CBENKMECBMN<PDFDIHHBJJI> HLCNJFHNKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5553120", Offset = "0x5551B20", VA = "0x185553120")]
		private unsafe static void FGMJFAGBPAH(Unity.Entities.Chunk* ANLGKBAEBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5553FA0", Offset = "0x55529A0", VA = "0x185553FA0")]
		private unsafe static void JGGCCKIKKBP(MFMBPJFJOGF.PIPCCENKNMO.HHCEANFINJG OJCAPAOALJK, int EKBHFIGODPK, int JJANDOLIOOF, Unity.Entities.Chunk* PIGGIBAOELK, MFMBPJFJOGF ALHBBHNIJBI, NativeArray<int> KJJNFLPAOCJ, global::CBENKMECBMN<PDFDIHHBJJI> HLCNJFHNKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x55552A0", Offset = "0x5553CA0", VA = "0x1855552A0")]
		public static void OMBAJNABOOG(DAOJGNOGCID KHDPJJEDHOA, in ByteString FJHIHOOEHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5555330", Offset = "0x5553D30", VA = "0x185555330")]
		public static void OMBAJNABOOG(EntityManager LNPEGOPJJGK, global::CBENKMECBMN<PDFDIHHBJJI> HLCNJFHNKCM, in ByteString FJHIHOOEHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x55534F0", Offset = "0x5551EF0", VA = "0x1855534F0")]
		private static bool FOPDEAPBAIG(Type MCLMFJEAHEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x55527F0", Offset = "0x55511F0", VA = "0x1855527F0")]
		private static void CEPFCHKAIDD(TypeManager.TypeInfo BAODNDIFHDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5552660", Offset = "0x5551060", VA = "0x185552660")]
		private unsafe static int CCBGOEJADHG(Unity.Entities.Archetype*[] AEAFIDJLPMD, NativeArray<EntityRemapUtility.EntityRemapInfo> HIEMJPKDECN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5553040", Offset = "0x5551A40", VA = "0x185553040")]
		private static int FFMFCFOLMGH(int HIMMGNBBIHM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5553AE0", Offset = "0x55524E0", VA = "0x185553AE0")]
		private static ulong HHALPMBCHBK(int HIMMGNBBIHM)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class DEGEOPGEKNL
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x554C250", Offset = "0x554AC50", VA = "0x18554C250")]
	private unsafe static Span<byte> ELGJMDBKNNE(Unity.Entities.Chunk* ANLGKBAEBBF, int FNPPKCIEMHM)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1C498F0", Offset = "0x1C482F0", VA = "0x181C498F0")]
	public unsafe static Span<T> NGGCBJBOINC<T>(Unity.Entities.Chunk* ANLGKBAEBBF, int FNPPKCIEMHM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1C49A70", Offset = "0x1C48470", VA = "0x181C49A70")]
	public static Span<T> NGGCBJBOINC<T>(this ref Unity.Entities.Chunk ANLGKBAEBBF, int FNPPKCIEMHM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x554C520", Offset = "0x554AF20", VA = "0x18554C520")]
	public unsafe static Span<Entity> ILNFDMDHMNP(Unity.Entities.Chunk* ANLGKBAEBBF)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x554C590", Offset = "0x554AF90", VA = "0x18554C590")]
	public unsafe static void PGHHBKOCHPM(Unity.Entities.Chunk* ANLGKBAEBBF, int FNPPKCIEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x554C3F0", Offset = "0x554ADF0", VA = "0x18554C3F0")]
	public static Entity IDJNNNOPOML(this EntityQuery AMEIGJPGLKK)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : AHAHNEIKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5556320", Offset = "0x5554D20", VA = "0x185556320", Slot = "4")]
		public sealed override void GBDHAHIIBFE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public MDBMMECDLKK()
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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

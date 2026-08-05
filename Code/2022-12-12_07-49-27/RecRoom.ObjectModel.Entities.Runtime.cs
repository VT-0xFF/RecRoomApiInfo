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
	[Cpp2IlInjected.Address(RVA = "0x5790560", Offset = "0x578EB60", VA = "0x185790560")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> FGBHPLPBINA(this ref Unity.Entities.Archetype HEFFAMIFPAM)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NNKNAMAMCDH
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5791660", Offset = "0x578FC60", VA = "0x185791660")]
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
	[Cpp2IlInjected.Address(RVA = "0x5790760", Offset = "0x578ED60", VA = "0x185790760")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DEFE10", Offset = "0x3DEE410", VA = "0x183DEFE10", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x27CE120", Offset = "0x27CC720", VA = "0x1827CE120")]
	public static void HGONFLKICDE<T>(this EntityManager LNPEGOPJJGK, NativeArray<Entity> IJBCECFNJIL, T MAKFNMHIJIF) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27CE2B0", Offset = "0x27CC8B0", VA = "0x1827CE2B0")]
	public static void HHGDOAODIAP<T>(this EntityManager LNPEGOPJJGK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27CEBB0", Offset = "0x27CD1B0", VA = "0x1827CEBB0")]
	public static void OFLLDOMMDOO<T>(this EntityManager LNPEGOPJJGK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x27CE610", Offset = "0x27CCC10", VA = "0x1827CE610")]
	public static JobHandle MONNDKBJHPK<T>(this EntityManager LNPEGOPJJGK) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x578C990", Offset = "0x578AF90", VA = "0x18578C990")]
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
			[Cpp2IlInjected.Address(RVA = "0x776CA0", Offset = "0x7752A0", VA = "0x180776CA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E2FFA0", Offset = "0x3E2E5A0", VA = "0x183E2FFA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2297590", Offset = "0x2295B90", VA = "0x182297590")]
		[DebuggerHidden]
		public AJOMHDNDJAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3E2FDC0", Offset = "0x3E2E3C0", VA = "0x183E2FDC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3E2FF60", Offset = "0x3E2E560", VA = "0x183E2FF60", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x70F350", Offset = "0x70D950", VA = "0x18070F350")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3284490", Offset = "0x3282A90", VA = "0x183284490")]
	private IMKHFHJHGID(byte[] DICKNCEHGPP, Action<Protobuf> PPKMMFHNOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x350C1B0", Offset = "0x350A7B0", VA = "0x18350C1B0")]
	public static global::IMKHFHJHGID<Protobuf> CBFHJGEFJHE<Data>(ReadOnlySpan<byte> FJHIHOOEHJM, ReadOnlySpan<Data> EPKPHBHDHGH, Action<Protobuf> PPKMMFHNOLF)
	{
		return default(global::IMKHFHJHGID<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3284300", Offset = "0x3282900", VA = "0x183284300", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3284340", Offset = "0x3282940", VA = "0x183284340", Slot = "4")]
	[IteratorStateMachine(typeof(global::IMKHFHJHGID<>.AJOMHDNDJAC))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3284440", Offset = "0x3282A40", VA = "0x183284440", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x46DFFC0", Offset = "0x46DE5C0", VA = "0x1846DFFC0")]
	private HJAAGDECNFB(byte[] DICKNCEHGPP, in Protobuf EMONGICDNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3508480", Offset = "0x3506A80", VA = "0x183508480")]
	public static global::HJAAGDECNFB<Protobuf> CBFHJGEFJHE<T>(ReadOnlySpan<T> EPKPHBHDHGH)
	{
		return default(global::HJAAGDECNFB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x46DFF90", Offset = "0x46DE590", VA = "0x1846DFF90")]
	public void MAGEMILPIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x46DFDD0", Offset = "0x46DE3D0", VA = "0x1846DFDD0")]
	public ByteString ADCLBDPECNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x46DFE60", Offset = "0x46DE460", VA = "0x1846DFE60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x578FF10", Offset = "0x578E510", VA = "0x18578FF10", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5790180", Offset = "0x578E780", VA = "0x185790180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PPGACODAFIA
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public static void PNCKOLEPIFB(this FGGEJMNNOEE LAEOPKAJMLP, NativeArray<Entity> IJBCECFNJIL, [Optional][CallerFilePath] string ONCPNKIDDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public static void PNCKOLEPIFB(this FGGEJMNNOEE LAEOPKAJMLP, string NBODBMLPNJA, NativeArray<Entity> IJBCECFNJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public static void PNCKOLEPIFB(this FGGEJMNNOEE LAEOPKAJMLP, string ONCPNKIDDOD, NativeArray<Entity> IJBCECFNJIL, bool LBGOBMKAOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public static void CEFPHHMFLJG(this FGGEJMNNOEE LAEOPKAJMLP, NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> AKGGBDCLIGD, [Optional][CallerFilePath] string ONCPNKIDDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public static void CEFPHHMFLJG(this FGGEJMNNOEE LAEOPKAJMLP, string ONCPNKIDDOD, NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> AKGGBDCLIGD, bool LBGOBMKAOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x356C9A0", Offset = "0x356AFA0", VA = "0x18356C9A0")]
	public static void JKIKGFNEMHM<T>(this FGGEJMNNOEE LAEOPKAJMLP, string NBODBMLPNJA, NativeArray<Entity> IJBCECFNJIL, NativeList<T> JIHCLPECHIB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x356CA30", Offset = "0x356B030", VA = "0x18356CA30")]
	public static void JKIKGFNEMHM<T>(this FGGEJMNNOEE LAEOPKAJMLP, string NBODBMLPNJA, NativeArray<Entity> IJBCECFNJIL, NativeArray<T> JIHCLPECHIB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public static void JKIKGFNEMHM<T>(this FGGEJMNNOEE LAEOPKAJMLP, string ONCPNKIDDOD, NativeArray<Entity> IJBCECFNJIL, NativeArray<T> JIHCLPECHIB, bool LBGOBMKAOKK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x356C900", Offset = "0x356AF00", VA = "0x18356C900")]
	public static void HNAGJHLAGPF<T>(this FGGEJMNNOEE LAEOPKAJMLP, NativeList<T> JIHCLPECHIB, [Optional][CallerFilePath] string ONCPNKIDDOD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x356C8D0", Offset = "0x356AED0", VA = "0x18356C8D0")]
	public static void HNAGJHLAGPF<T>(this FGGEJMNNOEE LAEOPKAJMLP, NativeArray<T> JIHCLPECHIB, [Optional][CallerFilePath] string ONCPNKIDDOD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public static void HNAGJHLAGPF<T>(this FGGEJMNNOEE LAEOPKAJMLP, string ONCPNKIDDOD, NativeArray<T> JIHCLPECHIB, bool LBGOBMKAOKK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public static void KEPCHJPFHMF(this FGGEJMNNOEE LAEOPKAJMLP, EntityQuery AMEIGJPGLKK, [Optional][CallerFilePath] string ONCPNKIDDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public static void KEPCHJPFHMF(this FGGEJMNNOEE LAEOPKAJMLP, string NBODBMLPNJA, EntityQuery AMEIGJPGLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public static void KEPCHJPFHMF(this FGGEJMNNOEE LAEOPKAJMLP, string ONCPNKIDDOD, EntityQuery AMEIGJPGLKK, bool LBGOBMKAOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x356C970", Offset = "0x356AF70", VA = "0x18356C970")]
	public static void IJJHAOKKAPP<T, T2>(this FGGEJMNNOEE LAEOPKAJMLP, string NBODBMLPNJA, EntityQuery AMEIGJPGLKK) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD7140", Offset = "0x2DD5740", VA = "0x182DD7140")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x47D31E0", Offset = "0x47D17E0", VA = "0x1847D31E0")]
		public bool FLKOLJMPNME(out TValue MAKFNMHIJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x47D32A0", Offset = "0x47D18A0", VA = "0x1847D32A0")]
		public void MFMCNFFMIAP(object HKLDIENGNNB, TValue MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x47D3160", Offset = "0x47D1760", VA = "0x1847D3160")]
		public bool EMIFMEAGDDE(object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x47D3350", Offset = "0x47D1950", VA = "0x1847D3350")]
		public int NCLIALNFMIA(object HKLDIENGNNB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x47D3400", Offset = "0x47D1A00", VA = "0x1847D3400")]
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
	[Cpp2IlInjected.Address(RVA = "0x45218E0", Offset = "0x451FEE0", VA = "0x1845218E0")]
	public MBBKMHEBCCI(EntityManager LNPEGOPJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x45217C0", Offset = "0x451FDC0", VA = "0x1845217C0", Slot = "4")]
	public void OCLLOJIAMME(Entity FLADPKIONGF, object HKLDIENGNNB, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4521340", Offset = "0x451F940", VA = "0x184521340", Slot = "5")]
	public bool DKOMHAGKCFC(Entity FLADPKIONGF, object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x45214D0", Offset = "0x451FAD0", VA = "0x1845214D0", Slot = "6")]
	public bool FLKOLJMPNME(Entity FLADPKIONGF, out TValue MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x45214B0", Offset = "0x451FAB0", VA = "0x1845214B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x45212C0", Offset = "0x451F8C0", VA = "0x1845212C0")]
	private void COHLOOAFJNN(PBLLIFLDIGF MHNEIFAEMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x45215A0", Offset = "0x451FBA0", VA = "0x1845215A0")]
	private bool GIMIFKJKHKN(Entity FLADPKIONGF, out GMLHAACHBKL ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4521670", Offset = "0x451FC70", VA = "0x184521670")]
	private void ILIHCIBBOEO(Entity FLADPKIONGF, GMLHAACHBKL ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4521650", Offset = "0x451FC50", VA = "0x184521650")]
	private bool GOGNFCADBAF(GMLHAACHBKL ODMNDKFKJHN, out PBLLIFLDIGF MHNEIFAEMNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4521700", Offset = "0x451FD00", VA = "0x184521700")]
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
		[Cpp2IlInjected.Address(RVA = "0x792CD0", Offset = "0x7912D0", VA = "0x180792CD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x794540", Offset = "0x792B40", VA = "0x180794540", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3C20", Offset = "0x7F2220", VA = "0x1807F3C20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C30", Offset = "0x7F2230", VA = "0x1807F3C30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x578FF50", Offset = "0x578E550", VA = "0x18578FF50", Slot = "8")]
	public bool Equals(GMLHAACHBKL OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x578FFA0", Offset = "0x578E5A0", VA = "0x18578FFA0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F9DEC0", Offset = "0x3F9C4C0", VA = "0x183F9DEC0")]
	public BHECHFLOHKD(EntityManager LNPEGOPJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3F9CBF0", Offset = "0x3F9B1F0", VA = "0x183F9CBF0", Slot = "4")]
	public bool OCLLOJIAMME(Entity FLADPKIONGF, object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3F9B2A0", Offset = "0x3F998A0", VA = "0x183F9B2A0", Slot = "5")]
	public bool DKOMHAGKCFC(Entity FLADPKIONGF, object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3F9BF90", Offset = "0x3F9A590", VA = "0x183F9BF90", Slot = "6")]
	public bool JBJJGGGFHBP(Entity FLADPKIONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3F9BEF0", Offset = "0x3F9A4F0", VA = "0x183F9BEF0", Slot = "7")]
	public bool JBJJGGGFHBP(GMLHAACHBKL ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3F9C410", Offset = "0x3F9AA10", VA = "0x183F9C410", Slot = "8")]
	public IEnumerable<object> JHNPKNIBINO(Entity FLADPKIONGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3F9C570", Offset = "0x3F9AB70", VA = "0x183F9C570", Slot = "11")]
	public IEnumerable<object> JHNPKNIBINO(GMLHAACHBKL ODMNDKFKJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3F9DBE0", Offset = "0x3F9C1E0", VA = "0x183F9DBE0", Slot = "9")]
	public bool PIHHIEBAGHH(Entity FLADPKIONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3F9B600", Offset = "0x3F99C00", VA = "0x183F9B600", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3F9AD40", Offset = "0x3F99340", VA = "0x183F9AD40")]
	private void COHLOOAFJNN(HashSet<object> MHNEIFAEMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3F9B900", Offset = "0x3F99F00", VA = "0x183F9B900")]
	private bool GIMIFKJKHKN(Entity FLADPKIONGF, out GMLHAACHBKL ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3F9D820", Offset = "0x3F9BE20", VA = "0x183F9D820")]
	private bool PFJGDNNNPGN(Entity FLADPKIONGF, out GMLHAACHBKL ODMNDKFKJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3F9AE90", Offset = "0x3F99490", VA = "0x183F9AE90")]
	private void DHCOMGNHCDA(Entity FLADPKIONGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3F9BCA0", Offset = "0x3F9A2A0", VA = "0x183F9BCA0")]
	private void ILIHCIBBOEO(Entity FLADPKIONGF, GMLHAACHBKL ODMNDKFKJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3F9B7A0", Offset = "0x3F99DA0", VA = "0x183F9B7A0")]
	private bool FPIAHNMFEBM(GMLHAACHBKL ODMNDKFKJHN, out HashSet<object> MHNEIFAEMNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3F9CA10", Offset = "0x3F9B010", VA = "0x183F9CA10")]
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
	[Cpp2IlInjected.Address(RVA = "0x5791020", Offset = "0x578F620", VA = "0x185791020", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x578D380", Offset = "0x578B980", VA = "0x18578D380", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5791C90", Offset = "0x5790290", VA = "0x185791C90", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1BE6E30", Offset = "0x1BE5430", VA = "0x181BE6E30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x237A590", Offset = "0x2378B90", VA = "0x18237A590", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5791BF0", Offset = "0x57901F0", VA = "0x185791BF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x71E880", Offset = "0x71CE80", VA = "0x18071E880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1D43E10", Offset = "0x1D42410", VA = "0x181D43E10")]
	public JOAMECNEEFA(Type MHGOOECIHJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AOABIAIICLA : JOAMECNEEFA
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1D43E10", Offset = "0x1D42410", VA = "0x181D43E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x728F30", Offset = "0x727530", VA = "0x180728F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5790780", Offset = "0x578ED80", VA = "0x185790780")]
	public LAOLKNOEOBH(Type DKEKJGDHPMA, Type MHGOOECIHJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BPAPKMJCHMP : JOAMECNEEFA
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D43E10", Offset = "0x1D42410", VA = "0x181D43E10")]
	public BPAPKMJCHMP(Type MHGOOECIHJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BCMMDDALFAJ : EIOKMAELDBG
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x695660", Offset = "0x693C60", VA = "0x180695660")]
		[CompilerGenerated]
		get
		{
			return default(FMHJKFCFNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D1A120", Offset = "0x1D18720", VA = "0x181D1A120")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5791610", Offset = "0x578FC10", VA = "0x185791610")]
	public NNAMEJEONOI(DAOJGNOGCID KHDPJJEDHOA, EntityManager LNPEGOPJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4347BE0", Offset = "0x43461E0", VA = "0x184347BE0")]
	public bool JNNJPIJIDCB<T>(Entity FLADPKIONGF) where T : struct, AAHHDGCMAGO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4347C20", Offset = "0x4346220", VA = "0x184347C20")]
	public bool MAILMCMPIPE<T>(Entity FLADPKIONGF, out T MAKFNMHIJIF) where T : struct, AAHHDGCMAGO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4345A00", Offset = "0x4344000", VA = "0x184345A00")]
	public T CHLCDKGGGLH<T>(Entity FLADPKIONGF) where T : struct, AAHHDGCMAGO
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x43473E0", Offset = "0x43459E0", VA = "0x1843473E0")]
	private ComponentType FJMJJIFHNJJ<T>() where T : struct, AAHHDGCMAGO
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5791540", Offset = "0x578FB40", VA = "0x185791540")]
	private ComponentType FJMJJIFHNJJ(Type MCLMFJEAHEC)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class EKPBGJEDCGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DFC9C0", Offset = "0x3DFAFC0", VA = "0x183DFC9C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type OIOMFNLIMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD4D0", Offset = "0x3DFBAD0", VA = "0x183DFD4D0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int JGCNEPIIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD700", Offset = "0x3DFBD00", VA = "0x183DFD700", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC170", Offset = "0x3DFA770", VA = "0x183DFC170")]
	public Data HGJBPBOLLLE(Entity FLADPKIONGF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC100", Offset = "0x3DFA700", VA = "0x183DFC100")]
	public Data FLABDBPHJLG(Entity FLADPKIONGF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View EPPJDKEHJDA(Entity FLADPKIONGF);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3A42C80", Offset = "0x3A41280", VA = "0x183A42C80", Slot = "15")]
	protected internal override T EPPJDKEHJDA<T>(Entity FLADPKIONGF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x229A9F0", Offset = "0x2298FF0", VA = "0x18229A9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6BA630", Offset = "0x6B8C30", VA = "0x1806BA630")]
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
		[Cpp2IlInjected.Address(RVA = "0xD03460", Offset = "0xD01A60", VA = "0x180D03460", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int NBBIELIHPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5790C30", Offset = "0x578F230", VA = "0x185790C30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private DHPNCKOALMM[] EECNCILCMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xD03390", Offset = "0xD01990", VA = "0x180D03390", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual DHPNCKOALMM[] DICNKIMDLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5790B70", Offset = "0x578F170", VA = "0x185790B70", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EEDFJHCDHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5790A80", Offset = "0x578F080", VA = "0x185790A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5790CA0", Offset = "0x578F2A0", VA = "0x185790CA0")]
	public void OIEJOMHJJDA(EntityManager LNPEGOPJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x71E890", Offset = "0x71CE90", VA = "0x18071E890")]
	protected BCFEIPPIFOG BIDICBKOPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T EPPJDKEHJDA<T>(Entity FLADPKIONGF) where T : struct, AAHHDGCMAGO;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5790AB0", Offset = "0x578F0B0", VA = "0x185790AB0", Slot = "8")]
	public (uint, uint) FFMFCFOLMGH(Entity FLADPKIONGF)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x57909F0", Offset = "0x578EFF0", VA = "0x1857909F0", Slot = "9")]
	public bool CHICEPFNPLC(Entity FLADPKIONGF, (uint order, uint change) AJGHIJIKOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x364BE90", Offset = "0x364A490", VA = "0x18364BE90", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x677280", Offset = "0x675880", VA = "0x180677280", Slot = "8")]
	protected virtual bool HABKFPAJILN(ReadOnlySpan<Data> EPKPHBHDHGH, LHDHMGCHIDM IHGCOMBDNKO, out ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "9")]
	protected virtual bool DFCKKOIGNHF(int AJGHIJIKOBE, Span<Data> EPKPHBHDHGH, in ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x364BD40", Offset = "0x364A340", VA = "0x18364BD40", Slot = "5")]
	internal sealed override bool HABKFPAJILN(ref Unity.Entities.Chunk ANLGKBAEBBF, int FNPPKCIEMHM, LHDHMGCHIDM IHGCOMBDNKO, out ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x364A8D0", Offset = "0x3648ED0", VA = "0x18364A8D0", Slot = "6")]
	internal sealed override bool DFCKKOIGNHF(int AJGHIJIKOBE, ref Unity.Entities.Chunk ANLGKBAEBBF, int FNPPKCIEMHM, in ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DD10", Offset = "0x3A3C310", VA = "0x183A3DD10")]
	protected global::HJAAGDECNFB<Protobuf> AGELLCCOLKH<Protobuf>(ReadOnlySpan<Data> EPKPHBHDHGH) where Protobuf : IMessage, new()
	{
		return default(global::HJAAGDECNFB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DD60", Offset = "0x3A3C360", VA = "0x183A3DD60")]
	protected global::IMKHFHJHGID<Protobuf> CLCKCHBNIPN<Protobuf>(ReadOnlySpan<byte> FJHIHOOEHJM, ReadOnlySpan<Data> EPKPHBHDHGH, Action<Protobuf> PPKMMFHNOLF) where Protobuf : IMessage, new()
	{
		return default(global::IMKHFHJHGID<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x229A9F0", Offset = "0x2298FF0", VA = "0x18229A9F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5791C00", Offset = "0x5790200", VA = "0x185791C00", Slot = "5")]
	internal virtual bool HABKFPAJILN(ref Unity.Entities.Chunk ANLGKBAEBBF, int FNPPKCIEMHM, LHDHMGCHIDM IHGCOMBDNKO, out ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "6")]
	internal virtual bool DFCKKOIGNHF(int AJGHIJIKOBE, ref Unity.Entities.Chunk ANLGKBAEBBF, int FNPPKCIEMHM, in ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D8FF70", Offset = "0x3D8E570", VA = "0x183D8FF70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DFBCD0", Offset = "0x3DFA2D0", VA = "0x183DFBCD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3B43CD0", Offset = "0x3B422D0", VA = "0x183B43CD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x57916D0", Offset = "0x578FCD0", VA = "0x1857916D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x578D390", Offset = "0x578B990", VA = "0x18578D390", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x33B0550", Offset = "0x33AEB50", VA = "0x1833B0550")]
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
	[Cpp2IlInjected.Address(RVA = "0x5791B70", Offset = "0x5790170", VA = "0x185791B70")]
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
	[Cpp2IlInjected.Address(RVA = "0x33193D0", Offset = "0x33179D0", VA = "0x1833193D0")]
	public static NativeList<T> ECPLKGMCDPG<T>(this NativeArray<T> LLLHIHGCNEF, Allocator GGLOKAHPEPM = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class KEGPBMHMFLK
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x308FD20", Offset = "0x308E320", VA = "0x18308FD20")]
	public static NativeArray<T> CBNNLIJPKGC<T>(this NativeList<Entity> LLLHIHGCNEF, EntityManager LNPEGOPJJGK, Allocator GGLOKAHPEPM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x308FC20", Offset = "0x308E220", VA = "0x18308FC20")]
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
	[Cpp2IlInjected.Address(RVA = "0x33C15A0", Offset = "0x33BFBA0", VA = "0x1833C15A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x578EF90", Offset = "0x578D590", VA = "0x18578EF90")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E26950", Offset = "0x3E24F50", VA = "0x183E26950")]
	public AGBMNBALCAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3E26660", Offset = "0x3E24C60", VA = "0x183E26660", Slot = "4")]
	public bool HEBLGIOGKGC(int HIMMGNBBIHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3E26320", Offset = "0x3E24920", VA = "0x183E26320", Slot = "5")]
	public global::CBENKMECBMN<BaseClass> FJFLJBDONNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3E267F0", Offset = "0x3E24DF0", VA = "0x183E267F0", Slot = "7")]
	protected virtual bool LAOGKHBOPFK(Type MCLMFJEAHEC, int CDADCJFJKFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3E266C0", Offset = "0x3E24CC0", VA = "0x183E266C0", Slot = "8")]
	protected virtual int JNEKCABGOMM(Type MCLMFJEAHEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3E265D0", Offset = "0x3E24BD0", VA = "0x183E265D0")]
	public void GBDHAHIIBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3E26750", Offset = "0x3E24D50", VA = "0x183E26750", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BD4AA0", Offset = "0x3BD30A0", VA = "0x183BD4AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3BD4DF0", Offset = "0x3BD33F0", VA = "0x183BD4DF0")]
	public CBENKMECBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3BD4F80", Offset = "0x3BD3580", VA = "0x183BD4F80")]
	public CBENKMECBMN(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3BD4CD0", Offset = "0x3BD32D0", VA = "0x183BD4CD0")]
	internal void MFMCNFFMIAP(int HIMMGNBBIHM, BaseClass EENBDKCLMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A3CA00", Offset = "0x3A3B000", VA = "0x183A3CA00")]
	public bool MPFJBMOGOMP<T>(out BaseClass MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BD4D50", Offset = "0x3BD3350", VA = "0x183BD4D50")]
	public bool MPFJBMOGOMP(Type ALGBEENOGLE, out BaseClass MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3354490", Offset = "0x3352A90", VA = "0x183354490")]
	public bool PKEKFKIENAA(int HIMMGNBBIHM, out BaseClass MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C920", Offset = "0x3A3AF20", VA = "0x183A3C920")]
	public T ELMJAHBLMEP<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3BD4A70", Offset = "0x3BD3070", VA = "0x183BD4A70")]
	public BaseClass ELMJAHBLMEP(Type BNPLNNFNMPH)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class BKKJILPLEII : global::AGBMNBALCAL<AOABIAIICLA, EKPBGJEDCGJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x578CA90", Offset = "0x578B090", VA = "0x18578CA90")]
	public BKKJILPLEII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FIDEDHLOPBM : global::AGBMNBALCAL<LAOLKNOEOBH, LDCIHJCLMHG>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x578F450", Offset = "0x578DA50", VA = "0x18578F450")]
	public FIDEDHLOPBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class ECIECLPCNKB : global::AGBMNBALCAL<BPAPKMJCHMP, PDFDIHHBJJI>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x578EF20", Offset = "0x578D520", VA = "0x18578EF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x72F870", Offset = "0x72DE70", VA = "0x18072F870")]
		private ComponentSystemTypes(List<Type> KJJNFLPAOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x578D710", Offset = "0x578BD10", VA = "0x18578D710")]
		public static void GBDHAHIIBFE(List<Type> KJJNFLPAOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x578D4D0", Offset = "0x578BAD0", VA = "0x18578D4D0")]
		private void FPLBPAFGKNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x578D800", Offset = "0x578BE00", VA = "0x18578D800")]
		private bool LAOGKHBOPFK(Type MCLMFJEAHEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x578D7A0", Offset = "0x578BDA0", VA = "0x18578D7A0")]
		private void KDJENMMFLEJ(Type MCLMFJEAHEC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class OILIIHGJOFP : HMNHMIKHJNF
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x57917B0", Offset = "0x578FDB0", VA = "0x1857917B0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase GADCGJMGDAF();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5791760", Offset = "0x578FD60", VA = "0x185791760")]
	protected ComponentSystemBase NHMAABKLMAM(params ComponentSystemBase[] FLDPOGAHGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x409D0C0", Offset = "0x409B6C0", VA = "0x18409D0C0")]
	protected ComponentSystemBase NHMAABKLMAM<T>(params ComponentSystemBase[] FLDPOGAHGIJ) where T : HMNHMIKHJNF, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x409D080", Offset = "0x409B680", VA = "0x18409D080")]
	protected ComponentSystemBase ONFPCELIIGJ<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x409D080", Offset = "0x409B680", VA = "0x18409D080")]
	protected ComponentSystemBase KGJKLFFINCC<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	protected OILIIHGJOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x57902B0", Offset = "0x578E8B0", VA = "0x1857902B0", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public HMNHMIKHJNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class CPOPPILPLCL : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x578D420", Offset = "0x578BA20", VA = "0x18578D420")]
	public KAHEOPHNBCB FLOKLGDOEKF(int HIMMGNBBIHM, bool JPIIMKIJCFB = false)
	{
		return default(KAHEOPHNBCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x578D4C0", Offset = "0x578BAC0", VA = "0x18578D4C0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0")]
	protected CPOPPILPLCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class LNFENIBMHJN : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0")]
	protected LNFENIBMHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class GJKIDHCFCFK : CPOPPILPLCL
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x578FCE0", Offset = "0x578E2E0", VA = "0x18578FCE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	protected void KKKEBBLEFHK(string MLGGMMOFMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0")]
	protected GJKIDHCFCFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	protected MGIENGIJDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5792010", Offset = "0x5790610", VA = "0x185792010")]
		public static ComponentSystemGroup[] BMBGBCHENNG(World KHDPJJEDHOA, LMDIBHKADJN AHGHICEFJLH = LMDIBHKADJN.Default, bool JDOJNLHMLPF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5791CB0", Offset = "0x57902B0", VA = "0x185791CB0")]
		private static Type[] AEIPCGHPAHB(LMDIBHKADJN AHGHICEFJLH, bool JDOJNLHMLPF, ComponentSystemGroup[] HEDPAPLAOED, ComponentSystemGroup MDMIMMFINAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5792210", Offset = "0x5790810", VA = "0x185792210")]
		private static ComponentSystemGroup[] CIEIEGJJNPN(World KHDPJJEDHOA, out ComponentSystemGroup MDMIMMFINAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5792520", Offset = "0x5790B20", VA = "0x185792520")]
		internal static bool CNPAPJJAMEP(FMHJKFCFNOJ NBBMMINMBNH, out CMHOIGNLIPP NMJCFNKPGHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5792D20", Offset = "0x5791320", VA = "0x185792D20")]
		private static ComponentSystemGroup PGKFBHGPHEE(Type MCLMFJEAHEC, World KHDPJJEDHOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x57920E0", Offset = "0x57906E0", VA = "0x1857920E0")]
		private static ComponentSystemGroup[] BOJMAKFGFIH(Type[] KJJNFLPAOCJ, World KHDPJJEDHOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x57927A0", Offset = "0x5790DA0", VA = "0x1857927A0")]
		internal static void EKOKCOLHKOI(World KHDPJJEDHOA, Type[] NOHEEBHAGEC, ComponentSystemGroup[] HEDPAPLAOED, ComponentSystemGroup MDMIMMFINAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5792E00", Offset = "0x5791400", VA = "0x185792E00")]
		internal static bool PMMFBFOFBCB(ComponentSystemBase HKMOJLJDDFO, ComponentSystemGroup[] HEDPAPLAOED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5792CC0", Offset = "0x57912C0", VA = "0x185792CC0")]
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
	[Cpp2IlInjected.Address(RVA = "0xAE7240", Offset = "0xAE5840", VA = "0x180AE7240")]
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
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
			[DebuggerHidden]
			public OKLGNGEGLAH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5791A90", Offset = "0x5790090", VA = "0x185791A90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x57917F0", Offset = "0x578FDF0", VA = "0x1857917F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5791B20", Offset = "0x5790120", VA = "0x185791B20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5791A50", Offset = "0x5790050", VA = "0x185791A50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x57919A0", Offset = "0x578FFA0", VA = "0x1857919A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x57919A0", Offset = "0x578FFA0", VA = "0x1857919A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5793320", Offset = "0x5791920", VA = "0x185793320")]
		public static RRFilterWorldSystems CBFHJGEFJHE()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x57933D0", Offset = "0x57919D0", VA = "0x1857933D0")]
		public RRFilterWorldSystems COOFIONFHJO(LMDIBHKADJN NBBMMINMBNH)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5793AD0", Offset = "0x57920D0", VA = "0x185793AD0")]
		public RRFilterWorldSystems OCDCMCKOKLP(IEnumerable<Type> KJJNFLPAOCJ)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5793A20", Offset = "0x5792020", VA = "0x185793A20")]
		public RRFilterWorldSystems HPMLNPHLAIH(bool OAAJPAICKOF)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5793A30", Offset = "0x5792030", VA = "0x185793A30")]
		public RRFilterWorldSystems IDCGLKHKAAG(bool MEIIGEANOKE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5793A40", Offset = "0x5792040", VA = "0x185793A40")]
		public FDFOJJLLKBA KHCOLCFBPDI(Type[] CBPLLNEFHMI)
		{
			return default(FDFOJJLLKBA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5793340", Offset = "0x5791940", VA = "0x185793340")]
		[IteratorStateMachine(typeof(OKLGNGEGLAH))]
		internal IEnumerable<Type> CNLLKHDIDAO(IEnumerable<Type> KJJNFLPAOCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5793B10", Offset = "0x5792110", VA = "0x185793B10")]
		internal Dictionary<Type, List<Type>> PIKMKMNDPHD(IEnumerable<Type> KJJNFLPAOCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5793050", Offset = "0x5791650", VA = "0x185793050")]
		private void AGBLLOPBGGG(Dictionary<Type, List<Type>> PAHCBODMCHK, Type MCLMFJEAHEC, Type IBHPOPBOIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5793160", Offset = "0x5791760", VA = "0x185793160")]
		internal HashSet<Type> BHKNCNNMAFF(IEnumerable<Type> HEDPAPLAOED, Dictionary<Type, List<Type>> BLDLHAOGGDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x57933E0", Offset = "0x57919E0", VA = "0x1857933E0")]
		internal bool EOAOAAINNHO(Type MCLMFJEAHEC, LMDIBHKADJN AHGHICEFJLH, bool JDOJNLHMLPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5792EF0", Offset = "0x57914F0", VA = "0x185792EF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5790990", Offset = "0x578EF90", VA = "0x185790990")]
	public static void OIEJOMHJJDA(bool CBEIFKNKIIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x57907D0", Offset = "0x578EDD0", VA = "0x1857907D0")]
	private static void KCJLNCDJAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class FBJIMAFGNOI
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x578F420", Offset = "0x578DA20", VA = "0x18578F420")]
	public static ulong EBGIHOEGOAO(Type MCLMFJEAHEC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x578F360", Offset = "0x578D960", VA = "0x18578F360")]
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
			[Cpp2IlInjected.Address(RVA = "0xAF9240", Offset = "0xAF7840", VA = "0x180AF9240")]
			public LKAGDIHEDGL(ulong PDABAAIKDHN, ulong FKINAIONFFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5790DC0", Offset = "0x578F3C0", VA = "0x185790DC0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x57947C0", Offset = "0x5792DC0", VA = "0x1857947C0")]
		public static ulong HHALPMBCHBK(int HIMMGNBBIHM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5794820", Offset = "0x5792E20", VA = "0x185794820")]
		public static int KHJCDGCMAFG(ulong FKINAIONFFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x57948E0", Offset = "0x5792EE0", VA = "0x1857948E0")]
		public static void OIEJOMHJJDA(bool CBEIFKNKIIE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5793FC0", Offset = "0x57925C0", VA = "0x185793FC0")]
		private static void AGIJDFEALOD(int HENEENHMBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5794410", Offset = "0x5792A10", VA = "0x185794410")]
		private static void GIPPPFGLDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5794AD0", Offset = "0x57930D0", VA = "0x185794AD0")]
		private static LKAGDIHEDGL OKHOKHAEDNF(Type MCLMFJEAHEC)
		{
			return default(LKAGDIHEDGL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x57943A0", Offset = "0x57929A0", VA = "0x1857943A0")]
		private static ulong DOENOHONIAD(Type MCLMFJEAHEC, ulong FKINAIONFFA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5794180", Offset = "0x5792780", VA = "0x185794180")]
		private static void COODNELOPCC(in LKAGDIHEDGL LPNCPIDHKNJ, TypeManager.TypeInfo BAODNDIFHDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5793EC0", Offset = "0x57924C0", VA = "0x185793EC0")]
		private static void ACPGOBKGNFF(LKAGDIHEDGL BAODNDIFHDH, int HIMMGNBBIHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x57940A0", Offset = "0x57926A0", VA = "0x1857940A0")]
		private static void AMEHPOHCICC(LKAGDIHEDGL BAODNDIFHDH, int HIMMGNBBIHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5794730", Offset = "0x5792D30", VA = "0x185794730")]
		private static LKAGDIHEDGL GNCBEKGOEPA(int HIMMGNBBIHM)
		{
			return default(LKAGDIHEDGL);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x57948D0", Offset = "0x5792ED0", VA = "0x1857948D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x578CC40", Offset = "0x578B240", VA = "0x18578CC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::MDDBBGFDMGN<PDFDIHHBJJI> CGFDDNLDGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x578CB80", Offset = "0x578B180", VA = "0x18578CB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::MDDBBGFDMGN<EKPBGJEDCGJ> JGONAJHDKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x578CBE0", Offset = "0x578B1E0", VA = "0x18578CBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x578CCA0", Offset = "0x578B2A0", VA = "0x18578CCA0")]
	public static void OIEJOMHJJDA(bool CBEIFKNKIIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x578CB00", Offset = "0x578B100", VA = "0x18578CB00")]
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
	[Cpp2IlInjected.Address(RVA = "0x5791080", Offset = "0x578F680", VA = "0x185791080")]
	public static int FFMFCFOLMGH(int HIMMGNBBIHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x57913A0", Offset = "0x578F9A0", VA = "0x1857913A0")]
	public static void OIEJOMHJJDA(bool CBEIFKNKIIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5791120", Offset = "0x578F720", VA = "0x185791120")]
	private static void NOALDLJMJOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5791030", Offset = "0x578F630", VA = "0x185791030")]
	private static int CECMCJHAJHE(Type MCLMFJEAHEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5791440", Offset = "0x578FA40", VA = "0x185791440")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World KBIJMFLFDFC
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager BPLKCGNFBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xFE39D0", Offset = "0xFE1FD0", VA = "0x180FE39D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public NNAMEJEONOI MLIEHBECBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::CBENKMECBMN<LDCIHJCLMHG> PDMCBIPBNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D70", Offset = "0x7E4370", VA = "0x1807E5D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::CBENKMECBMN<PDFDIHHBJJI> CGFDDNLDGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x722690", Offset = "0x720C90", VA = "0x180722690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::CBENKMECBMN<EKPBGJEDCGJ> JGONAJHDKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x684420", Offset = "0x682A20", VA = "0x180684420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x731D00", Offset = "0x730300", VA = "0x180731D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> ABBJLIEIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xFE3A10", Offset = "0xFE2010", VA = "0x180FE3A10")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] FGGGHFAGEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x578E1F0", Offset = "0x578C7F0", VA = "0x18578E1F0")]
	public static DAOJGNOGCID NDCCACLNKIG(string NBODBMLPNJA, FMHJKFCFNOJ NBBMMINMBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x578E310", Offset = "0x578C910", VA = "0x18578E310")]
	public DAOJGNOGCID(string NBODBMLPNJA, FMHJKFCFNOJ NBBMMINMBNH = FMHJKFCFNOJ.Simulation, LMDIBHKADJN AHGHICEFJLH = LMDIBHKADJN.Default, bool CBEIFKNKIIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x578E270", Offset = "0x578C870", VA = "0x18578E270")]
	public ComponentSystemBase NMMLCJKFAEA(Type MCLMFJEAHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2A39000", Offset = "0x2A37600", VA = "0x182A39000")]
	public T NMMLCJKFAEA<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x578DD10", Offset = "0x578C310", VA = "0x18578DD10")]
	public void DFHDCFOIOCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x578DDE0", Offset = "0x578C3E0", VA = "0x18578DDE0")]
	public void EAGHLIILKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x578E0D0", Offset = "0x578C6D0", VA = "0x18578E0D0")]
	public void LJBEHGPGGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x578DF80", Offset = "0x578C580", VA = "0x18578DF80")]
	public void HJCLLJGNECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x578E130", Offset = "0x578C730", VA = "0x18578E130")]
	public void LOLJJIPEIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x578E070", Offset = "0x578C670", VA = "0x18578E070")]
	public void LCKLGKEJONF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x578D8D0", Offset = "0x578BED0", VA = "0x18578D8D0")]
	public void ADBKDFFPJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x578DFE0", Offset = "0x578C5E0", VA = "0x18578DFE0")]
	public void IHAAIJLACPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x578E190", Offset = "0x578C790", VA = "0x18578E190")]
	public void MAKAAILEALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x578DE40", Offset = "0x578C440", VA = "0x18578DE40")]
	public void FBMFPGJNNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x578DEA0", Offset = "0x578C4A0", VA = "0x18578DEA0")]
	internal void GMFLDBGAHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x578E290", Offset = "0x578C890", VA = "0x18578E290")]
	private bool PEPLPCFKDFH(ComponentSystemGroup NABGGPANDBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x578DA40", Offset = "0x578C040", VA = "0x18578DA40")]
	private void BONDJDEKHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x578D930", Offset = "0x578BF30", VA = "0x18578D930")]
	private ComponentSystemGroup[] BMBGBCHENNG(LMDIBHKADJN AHGHICEFJLH, bool JDOJNLHMLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x578DD70", Offset = "0x578C370", VA = "0x18578DD70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	protected PFDNMICPDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class BNOGFJKHCCG : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public BNOGFJKHCCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class MIDLJCMMMGD : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public MIDLJCMMMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class JJLONPGGJEC : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public JJLONPGGJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class ABLCJOKJLKE : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public ABLCJOKJLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class CODLCFFJGHP : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public CODLCFFJGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class HLMANKFCDIJ : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public HLMANKFCDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class GEBKMMJCFHB : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public GEBKMMJCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class FMGKIBHKAMG : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public FMGKIBHKAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class OHCABJHLPDG : PFDNMICPDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public OHCABJHLPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class DIAIFMCDODP : ADPHDPBLAAH
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public DIAIFMCDODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class NMGKDAKPLLN : ADPHDPBLAAH
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public NMGKDAKPLLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class DEMECKJCLKL : ADPHDPBLAAH
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public DEMECKJCLKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class HDLEHDDPGDO : ADPHDPBLAAH
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public HDLEHDDPGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x578CA80", Offset = "0x578B080", VA = "0x18578CA80")]
	public ADPHDPBLAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class CPNFHFBMMGK : EIOKMAELDBG
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public PNMPOHHBOFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x578FD10", Offset = "0x578E310", VA = "0x18578FD10")]
	static GKAOKGOEFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x32C7940", Offset = "0x32C5F40", VA = "0x1832C7940")]
	public static void JKFOFONBOOA<T>(ELAEFGJBCAO<T, T> LMIPPCBLACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x32C7700", Offset = "0x32C5D00", VA = "0x1832C7700")]
	public static void JKFOFONBOOA<From, To>(ELAEFGJBCAO<From, To> LMIPPCBLACH, ELAEFGJBCAO<To, From> FMLFONLNFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x32C76B0", Offset = "0x32C5CB0", VA = "0x1832C76B0")]
	public static void JKFOFONBOOA<From, To>(ELAEFGJBCAO<From, To> GJNHBCODKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x32C2430", Offset = "0x32C0A30", VA = "0x1832C2430")]
	public static ELAEFGJBCAO<From, To> DMCFJJDMDMN<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x32C9730", Offset = "0x32C7D30", VA = "0x1832C9730")]
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
	[Cpp2IlInjected.Address(RVA = "0x192F910", Offset = "0x192DF10", VA = "0x18192F910")]
	public LHDHMGCHIDM(NativeArray<EntityRemapUtility.EntityRemapInfo> FICEFMOJFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7170", Offset = "0x3BC5770", VA = "0x183BC7170")]
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
	[Cpp2IlInjected.Address(RVA = "0x578F170", Offset = "0x578D770", VA = "0x18578F170")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E1950", Offset = "0x7DFF50", VA = "0x1807E1950")]
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
				[Cpp2IlInjected.Address(RVA = "0x5790060", Offset = "0x578E660", VA = "0x185790060")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long DNLJFHDEAGA
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x578FFF0", Offset = "0x578E5F0", VA = "0x18578FFF0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x57900C0", Offset = "0x578E6C0", VA = "0x1857900C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x57906B0", Offset = "0x578ECB0", VA = "0x1857906B0")]
				public unsafe IIGNDJMMAIO(Unity.Entities.Archetype* OJCAPAOALJK, MFMBPJFJOGF.PIPCCENKNMO.HHCEANFINJG JKJLCIHNEKP, LHDHMGCHIDM IHGCOMBDNKO, global::CBENKMECBMN<PDFDIHHBJJI> HLCNJFHNKCM, int FNPPKCIEMHM, int LCDLJNKCNOD = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5790710", Offset = "0x578ED10", VA = "0x185790710")]
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
			[Cpp2IlInjected.Address(RVA = "0x578FBA0", Offset = "0x578E1A0", VA = "0x18578FBA0")]
			public GAFBBFMCODN(IIGNDJMMAIO[] EPKPHBHDHGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x578F790", Offset = "0x578DD90", VA = "0x18578F790", Slot = "4")]
			public void Invoke(int EBBLFLFCHFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x578F7F0", Offset = "0x578DDF0", VA = "0x18578F7F0")]
			private void PAFIPANAKHG(in IIGNDJMMAIO JIHCLPECHIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x578F4C0", Offset = "0x578DAC0", VA = "0x18578F4C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public PGBOBBHDIOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5791C20", Offset = "0x5790220", VA = "0x185791C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public DPLHALPPCNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x578EE10", Offset = "0x578D410", VA = "0x18578EE10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5795E00", Offset = "0x5794400", VA = "0x185795E00")]
		private unsafe static bool GKGCEFDKAPE(Unity.Entities.Archetype* HEFFAMIFPAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5796CE0", Offset = "0x57952E0", VA = "0x185796CE0")]
		internal unsafe static Unity.Entities.Archetype*[] MICNHOKNLLF(ref Unity.Entities.EntityComponentStore CCBEKMGKGMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5796C20", Offset = "0x5795220", VA = "0x185796C20")]
		public static void MHOEBEHGBOJ(DAOJGNOGCID KHDPJJEDHOA, out ByteString FJHIHOOEHJM, out NativeArray<EntityRemapUtility.EntityRemapInfo> HIEMJPKDECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5797150", Offset = "0x5795750", VA = "0x185797150")]
		internal static void NOOBLOCBMOM(DAOJGNOGCID KHDPJJEDHOA, MFMBPJFJOGF ALHBBHNIJBI, out NativeArray<EntityRemapUtility.EntityRemapInfo> HIEMJPKDECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5796EC0", Offset = "0x57954C0", VA = "0x185796EC0")]
		private unsafe static UnsafeHashMap<ulong, MAEMELBPCKG> NALAGFAKMHP(Unity.Entities.Archetype*[] AEAFIDJLPMD)
		{
			return default(UnsafeHashMap<ulong, MAEMELBPCKG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5795F10", Offset = "0x5794510", VA = "0x185795F10")]
		private static void HCILCCEHPNG(MFMBPJFJOGF ALHBBHNIJBI, UnsafeHashMap<ulong, MAEMELBPCKG> JIDNBDOLNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x57952F0", Offset = "0x57938F0", VA = "0x1857952F0")]
		private unsafe static void EKGNAPEHGAN(MFMBPJFJOGF ALHBBHNIJBI, Unity.Entities.Archetype*[] AEAFIDJLPMD, UnsafeHashMap<ulong, MAEMELBPCKG> JIDNBDOLNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5795D90", Offset = "0x5794390", VA = "0x185795D90")]
		private unsafe static int GKFFLKPFFCE(Unity.Entities.Archetype*[] AEAFIDJLPMD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5796160", Offset = "0x5794760", VA = "0x185796160")]
		private unsafe static void HLINCFHBHFN(MFMBPJFJOGF ALHBBHNIJBI, Unity.Entities.Archetype*[] AEAFIDJLPMD, global::CBENKMECBMN<PDFDIHHBJJI> HLCNJFHNKCM, NativeArray<EntityRemapUtility.EntityRemapInfo> HIEMJPKDECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5795080", Offset = "0x5793680", VA = "0x185795080")]
		private static NativeArray<int> EIEMGFAEBCN(MFMBPJFJOGF ALHBBHNIJBI)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5796890", Offset = "0x5794E90", VA = "0x185796890")]
		private static Memory<EntityArchetype> MHBKOHMKNPL(MFMBPJFJOGF ALHBBHNIJBI, NativeArray<int> KJJNFLPAOCJ, EntityManager LNPEGOPJJGK, out int JGMPICFAACP, out int ALLHLNNCNPJ)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5795780", Offset = "0x5793D80", VA = "0x185795780")]
		private unsafe static void FKPEHBKFOGG(Unity.Entities.Chunk* PIGGIBAOELK, ReadOnlySpan<byte> FJHIHOOEHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5797F60", Offset = "0x5796560", VA = "0x185797F60")]
		private static void OODKFMBKCHL(MFMBPJFJOGF ALHBBHNIJBI, NativeArray<int> KJJNFLPAOCJ, Span<EntityArchetype> AEAFIDJLPMD, EntityManager LNPEGOPJJGK, global::CBENKMECBMN<PDFDIHHBJJI> HLCNJFHNKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5795700", Offset = "0x5793D00", VA = "0x185795700")]
		private unsafe static void FGMJFAGBPAH(Unity.Entities.Chunk* ANLGKBAEBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5796580", Offset = "0x5794B80", VA = "0x185796580")]
		private unsafe static void JGGCCKIKKBP(MFMBPJFJOGF.PIPCCENKNMO.HHCEANFINJG OJCAPAOALJK, int EKBHFIGODPK, int JJANDOLIOOF, Unity.Entities.Chunk* PIGGIBAOELK, MFMBPJFJOGF ALHBBHNIJBI, NativeArray<int> KJJNFLPAOCJ, global::CBENKMECBMN<PDFDIHHBJJI> HLCNJFHNKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5797880", Offset = "0x5795E80", VA = "0x185797880")]
		public static void OMBAJNABOOG(DAOJGNOGCID KHDPJJEDHOA, in ByteString FJHIHOOEHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5797910", Offset = "0x5795F10", VA = "0x185797910")]
		public static void OMBAJNABOOG(EntityManager LNPEGOPJJGK, global::CBENKMECBMN<PDFDIHHBJJI> HLCNJFHNKCM, in ByteString FJHIHOOEHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5795AD0", Offset = "0x57940D0", VA = "0x185795AD0")]
		private static bool FOPDEAPBAIG(Type MCLMFJEAHEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5794DD0", Offset = "0x57933D0", VA = "0x185794DD0")]
		private static void CEPFCHKAIDD(TypeManager.TypeInfo BAODNDIFHDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5794C40", Offset = "0x5793240", VA = "0x185794C40")]
		private unsafe static int CCBGOEJADHG(Unity.Entities.Archetype*[] AEAFIDJLPMD, NativeArray<EntityRemapUtility.EntityRemapInfo> HIEMJPKDECN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5795620", Offset = "0x5793C20", VA = "0x185795620")]
		private static int FFMFCFOLMGH(int HIMMGNBBIHM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x57960C0", Offset = "0x57946C0", VA = "0x1857960C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x578E830", Offset = "0x578CE30", VA = "0x18578E830")]
	private unsafe static Span<byte> ELGJMDBKNNE(Unity.Entities.Chunk* ANLGKBAEBBF, int FNPPKCIEMHM)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2A3A6A0", Offset = "0x2A38CA0", VA = "0x182A3A6A0")]
	public unsafe static Span<T> NGGCBJBOINC<T>(Unity.Entities.Chunk* ANLGKBAEBBF, int FNPPKCIEMHM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A3A820", Offset = "0x2A38E20", VA = "0x182A3A820")]
	public static Span<T> NGGCBJBOINC<T>(this ref Unity.Entities.Chunk ANLGKBAEBBF, int FNPPKCIEMHM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x578EB00", Offset = "0x578D100", VA = "0x18578EB00")]
	public unsafe static Span<Entity> ILNFDMDHMNP(Unity.Entities.Chunk* ANLGKBAEBBF)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x578EB70", Offset = "0x578D170", VA = "0x18578EB70")]
	public unsafe static void PGHHBKOCHPM(Unity.Entities.Chunk* ANLGKBAEBBF, int FNPPKCIEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x578E9D0", Offset = "0x578CFD0", VA = "0x18578E9D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5798900", Offset = "0x5796F00", VA = "0x185798900", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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

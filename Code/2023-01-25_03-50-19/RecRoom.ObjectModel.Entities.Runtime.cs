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
internal static class CHKJKOFOEBA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x55B8970", Offset = "0x55B7970", VA = "0x1855B8970")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> LCEPIACMFBE(this ref Unity.Entities.Archetype FAAKDBHJKLM)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MIAJMOFIACO
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x55BA8E0", Offset = "0x55B98E0", VA = "0x1855BA8E0")]
	public static Span<int> EFOGLNCAIGB(this EntityArchetype FAAKDBHJKLM)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CBHPKAAFOOJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BBMFKINPCMK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x55B86F0", Offset = "0x55B76F0", VA = "0x1855B86F0")]
	public static bool DOFAOAHKOHP(this Entity IEFFOCOBJJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class EDEFLIFHIIN
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[BurstCompile]
	private struct GPELJAMNNDJ<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[ReadOnly]
		public NativeArray<Entity> PNFNAEBJOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[WriteOnly]
		public ComponentDataFromEntity<T> IMLNMFIBABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public T DFEOJBAFBHE;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2859C00", Offset = "0x2858C00", VA = "0x182859C00", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[BurstCompile]
	private struct FHGFMPHMHLJ<T> : IJobChunk where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[WriteOnly]
		public ArchetypeChunkComponentType<T> CDLJOBPANEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T DFEOJBAFBHE;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25B8160", Offset = "0x25B7160", VA = "0x1825B8160")]
	public static void FCLGEOPHAAM<T>(this EntityManager MKHPDCKNNBB, NativeArray<Entity> BNEBECKGGLP, T DFEOJBAFBHE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x25B8500", Offset = "0x25B7500", VA = "0x1825B8500")]
	public static void HDBPJCFMEEI<T>(this EntityManager MKHPDCKNNBB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x25B7EC0", Offset = "0x25B6EC0", VA = "0x1825B7EC0")]
	public static void BHLIADOPKCN<T>(this EntityManager MKHPDCKNNBB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x25B9650", Offset = "0x25B8650", VA = "0x1825B9650")]
	public static JobHandle MNDFEFDFBJA<T>(this EntityManager MKHPDCKNNBB) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x55B9330", Offset = "0x55B8330", VA = "0x1855B9330")]
	public static JobHandle MNDFEFDFBJA(this EntityManager MKHPDCKNNBB, int CNNKHGOHIDH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LJLPAFFKOGM<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ACMFPDCOJDL : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::LJLPAFFKOGM<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x69F040", Offset = "0x69E040", VA = "0x18069F040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2950340", Offset = "0x294F340", VA = "0x182950340", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C420", Offset = "0x1E2B420", VA = "0x181E2C420")]
		[DebuggerHidden]
		public ACMFPDCOJDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2950160", Offset = "0x294F160", VA = "0x182950160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2950300", Offset = "0x294F300", VA = "0x182950300", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> FFICHOMLEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream KJHFBEBKBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream CFJCOFJCCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf KLNJKJCAPGC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int AFMNPELKBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67E010", Offset = "0x67D010", VA = "0x18067E010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x208B390", Offset = "0x208A390", VA = "0x18208B390")]
	private LJLPAFFKOGM(byte[] FAHBHODOFIG, Action<Protobuf> FFICHOMLEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E77090", Offset = "0x1E76090", VA = "0x181E77090")]
	public static global::LJLPAFFKOGM<Protobuf> HJNGNBALKKN<Data>(ReadOnlySpan<byte> GEGIPEOHNBF, ReadOnlySpan<Data> FKFMFNKJNOH, Action<Protobuf> FFICHOMLEMH)
	{
		return default(global::LJLPAFFKOGM<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x208B200", Offset = "0x208A200", VA = "0x18208B200", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x208B240", Offset = "0x208A240", VA = "0x18208B240", Slot = "4")]
	[IteratorStateMachine(typeof(global::LJLPAFFKOGM<>.ACMFPDCOJDL))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x208B340", Offset = "0x208A340", VA = "0x18208B340", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MDCAJNGFNFL<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] FAHBHODOFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf KLNJKJCAPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream KJHFBEBKBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream KFEFBBJJDDH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2F65DC0", Offset = "0x2F64DC0", VA = "0x182F65DC0")]
	private MDCAJNGFNFL(byte[] FAHBHODOFIG, in Protobuf KLNJKJCAPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x26CABE0", Offset = "0x26C9BE0", VA = "0x1826CABE0")]
	public static global::MDCAJNGFNFL<Protobuf> HJNGNBALKKN<T>(ReadOnlySpan<T> FKFMFNKJNOH)
	{
		return default(global::MDCAJNGFNFL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2F65BD0", Offset = "0x2F64BD0", VA = "0x182F65BD0")]
	public void AJHGBOOADGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2F65D30", Offset = "0x2F64D30", VA = "0x182F65D30")]
	public ByteString HGDFBDGENEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2F65C00", Offset = "0x2F64C00", VA = "0x182F65C00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct AODNJLMCICM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream KJHFBEBKBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream CFJCOFJCCIA;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x55B86B0", Offset = "0x55B76B0", VA = "0x1855B86B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LGLIINPPKPD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] FAHBHODOFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream KJHFBEBKBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream KFEFBBJJDDH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x55BA720", Offset = "0x55B9720", VA = "0x1855BA720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FMFDDBDCLID
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public static void MJBFDABAMKA(this FBNJDMKEPCN KKLHLPEDHHE, NativeArray<Entity> BNEBECKGGLP, [Optional][CallerFilePath] string MAMFIJBOHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public static void MJBFDABAMKA(this FBNJDMKEPCN KKLHLPEDHHE, string IADPDEAGFAB, NativeArray<Entity> BNEBECKGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public static void MJBFDABAMKA(this FBNJDMKEPCN KKLHLPEDHHE, string MAMFIJBOHPN, NativeArray<Entity> BNEBECKGGLP, bool DBADFKHLJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public static void MKDGCNJKKEH(this FBNJDMKEPCN KKLHLPEDHHE, NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> JMOFNBOBEAE, [Optional][CallerFilePath] string MAMFIJBOHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public static void MKDGCNJKKEH(this FBNJDMKEPCN KKLHLPEDHHE, string MAMFIJBOHPN, NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> JMOFNBOBEAE, bool DBADFKHLJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x27E8A70", Offset = "0x27E7A70", VA = "0x1827E8A70")]
	public static void EAKNDGIPFKO<T>(this FBNJDMKEPCN KKLHLPEDHHE, string IADPDEAGFAB, NativeArray<Entity> BNEBECKGGLP, NativeList<T> FILAKGLBGGA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x27E8B00", Offset = "0x27E7B00", VA = "0x1827E8B00")]
	public static void EAKNDGIPFKO<T>(this FBNJDMKEPCN KKLHLPEDHHE, string IADPDEAGFAB, NativeArray<Entity> BNEBECKGGLP, NativeArray<T> FILAKGLBGGA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public static void EAKNDGIPFKO<T>(this FBNJDMKEPCN KKLHLPEDHHE, string MAMFIJBOHPN, NativeArray<Entity> BNEBECKGGLP, NativeArray<T> FILAKGLBGGA, bool DBADFKHLJMI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x27E8B70", Offset = "0x27E7B70", VA = "0x1827E8B70")]
	public static void KBDLLDEKBHG<T>(this FBNJDMKEPCN KKLHLPEDHHE, NativeList<T> FILAKGLBGGA, [Optional][CallerFilePath] string MAMFIJBOHPN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x27E8B40", Offset = "0x27E7B40", VA = "0x1827E8B40")]
	public static void KBDLLDEKBHG<T>(this FBNJDMKEPCN KKLHLPEDHHE, NativeArray<T> FILAKGLBGGA, [Optional][CallerFilePath] string MAMFIJBOHPN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public static void KBDLLDEKBHG<T>(this FBNJDMKEPCN KKLHLPEDHHE, string MAMFIJBOHPN, NativeArray<T> FILAKGLBGGA, bool DBADFKHLJMI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public static void EOLFAPCFDEO(this FBNJDMKEPCN KKLHLPEDHHE, EntityQuery FBENFNFLPOM, [Optional][CallerFilePath] string MAMFIJBOHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public static void EOLFAPCFDEO(this FBNJDMKEPCN KKLHLPEDHHE, string IADPDEAGFAB, EntityQuery FBENFNFLPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public static void EOLFAPCFDEO(this FBNJDMKEPCN KKLHLPEDHHE, string MAMFIJBOHPN, EntityQuery FBENFNFLPOM, bool DBADFKHLJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x27E8BE0", Offset = "0x27E7BE0", VA = "0x1827E8BE0")]
	public static void PKGJFEINHMN<T, T2>(this FBNJDMKEPCN KKLHLPEDHHE, string IADPDEAGFAB, EntityQuery FBENFNFLPOM) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	private static void PKGJFEINHMN<T, T2>(this FBNJDMKEPCN KKLHLPEDHHE, string MAMFIJBOHPN, EntityQuery FBENFNFLPOM, bool DBADFKHLJMI) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ADNHFABDAIG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HMIKLFBELAH BDHDLDFKJDF
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
public interface KGEAMOGNOJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CCDNHHDJMDL(Entity IEFFOCOBJJI, object KCCFEDJJGAN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KPKDACOAPCG(Entity IEFFOCOBJJI, object KCCFEDJJGAN);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMFCMIFFGPD(Entity IEFFOCOBJJI);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MMFCMIFFGPD(HMIKLFBELAH DCLMHANFEGK);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> HPNCIPNDFOB(Entity IEFFOCOBJJI);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IKFKBILPLPP(Entity IEFFOCOBJJI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LIFNMLFFFJC<TComponentData, TValue> : global::LHGPJLBEMAO<TValue>, IDisposable where TComponentData : struct, ADNHFABDAIG
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class HKIAKFGOLLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> DEEJEKFIHBB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int BCBDBMHFMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1E22CE0", Offset = "0x1E21CE0", VA = "0x181E22CE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2E45940", Offset = "0x2E44940", VA = "0x182E45940")]
		public bool MBBLMHLLNHP(out TValue DFEOJBAFBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2E45890", Offset = "0x2E44890", VA = "0x182E45890")]
		public void HMNAIPBHJIK(object KCCFEDJJGAN, TValue DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2E45760", Offset = "0x2E44760", VA = "0x182E45760")]
		public bool FAHLDBEBGON(object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2E457E0", Offset = "0x2E447E0", VA = "0x182E457E0")]
		public int FIGLOCELEJH(object KCCFEDJJGAN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2E45A00", Offset = "0x2E44A00", VA = "0x182E45A00")]
		public HKIAKFGOLLC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<HKIAKFGOLLC> NIEHJLCAJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::AOPGFFKJFJG<HMIKLFBELAH, HKIAKFGOLLC> JOFMEFMEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager MKHPDCKNNBB;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2089B50", Offset = "0x2088B50", VA = "0x182089B50")]
	public LIFNMLFFFJC(EntityManager MKHPDCKNNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2089530", Offset = "0x2088530", VA = "0x182089530", Slot = "4")]
	public void CCDNHHDJMDL(Entity IEFFOCOBJJI, object KCCFEDJJGAN, TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x20897D0", Offset = "0x20887D0", VA = "0x1820897D0", Slot = "5")]
	public bool KPKDACOAPCG(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x20899C0", Offset = "0x20889C0", VA = "0x1820899C0", Slot = "6")]
	public bool MBBLMHLLNHP(Entity IEFFOCOBJJI, out TValue DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2089700", Offset = "0x2088700", VA = "0x182089700", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2089940", Offset = "0x2088940", VA = "0x182089940")]
	private void LJJPDHMOMCE(HKIAKFGOLLC HLIGBNPNBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2089650", Offset = "0x2088650", VA = "0x182089650")]
	private bool DFIIPBPONKC(Entity IEFFOCOBJJI, out HMIKLFBELAH DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2089740", Offset = "0x2088740", VA = "0x182089740")]
	private void JAHJBFLMNLA(Entity IEFFOCOBJJI, HMIKLFBELAH DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2089720", Offset = "0x2088720", VA = "0x182089720")]
	private bool ECAPHJDNKHE(HMIKLFBELAH DCLMHANFEGK, out HKIAKFGOLLC HLIGBNPNBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2089A90", Offset = "0x2088A90", VA = "0x182089A90")]
	private HKIAKFGOLLC PJDNPEIDGEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LHGPJLBEMAO<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCDNHHDJMDL(Entity IEFFOCOBJJI, object KCCFEDJJGAN, TValue DFEOJBAFBHE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KPKDACOAPCG(Entity IEFFOCOBJJI, object KCCFEDJJGAN);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MBBLMHLLNHP(Entity IEFFOCOBJJI, out TValue DFEOJBAFBHE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HMIKLFBELAH : global::GAMKFLDBKPP<HMIKLFBELAH>, BCAIPGNNKGO, IEquatable<HMIKLFBELAH>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly HMIKLFBELAH KKELJKMFEKL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int EBAKNIMBLHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x72FE20", Offset = "0x72EE20", VA = "0x18072FE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72FD90", Offset = "0x72ED90", VA = "0x18072FD90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int DKBOPEOPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8441E0", Offset = "0x8431E0", VA = "0x1808441E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xDED3C0", Offset = "0xDEC3C0", VA = "0x180DED3C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x55B9AE0", Offset = "0x55B8AE0", VA = "0x1855B9AE0", Slot = "8")]
	public bool Equals(HMIKLFBELAH KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x55B9B30", Offset = "0x55B8B30", VA = "0x1855B9B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JAGLGPBNCCL<T> : KGEAMOGNOJJ, IDisposable where T : struct, ADNHFABDAIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> NIEHJLCAJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::AOPGFFKJFJG<HMIKLFBELAH, HashSet<object>> JOFMEFMEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager MKHPDCKNNBB;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E4C0", Offset = "0x2F1D4C0", VA = "0x182F1E4C0")]
	public JAGLGPBNCCL(EntityManager MKHPDCKNNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B550", Offset = "0x2F1A550", VA = "0x182F1B550", Slot = "4")]
	public bool CCDNHHDJMDL(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D290", Offset = "0x2F1C290", VA = "0x182F1D290", Slot = "5")]
	public bool KPKDACOAPCG(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2F1DAA0", Offset = "0x2F1CAA0", VA = "0x182F1DAA0", Slot = "6")]
	public bool MMFCMIFFGPD(Entity IEFFOCOBJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2F1DA00", Offset = "0x2F1CA00", VA = "0x182F1DA00", Slot = "7")]
	public bool MMFCMIFFGPD(HMIKLFBELAH DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2F1C900", Offset = "0x2F1B900", VA = "0x182F1C900", Slot = "8")]
	public IEnumerable<object> HPNCIPNDFOB(Entity IEFFOCOBJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2F1C7C0", Offset = "0x2F1B7C0", VA = "0x182F1C7C0", Slot = "11")]
	public IEnumerable<object> HPNCIPNDFOB(HMIKLFBELAH DCLMHANFEGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2F1CC90", Offset = "0x2F1BC90", VA = "0x182F1CC90", Slot = "9")]
	public bool IKFKBILPLPP(Entity IEFFOCOBJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BDD0", Offset = "0x2F1ADD0", VA = "0x182F1BDD0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D7D0", Offset = "0x2F1C7D0", VA = "0x182F1D7D0")]
	private void LJJPDHMOMCE(HashSet<object> HLIGBNPNBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B7D0", Offset = "0x2F1A7D0", VA = "0x182F1B7D0")]
	private bool DFIIPBPONKC(Entity IEFFOCOBJJI, out HMIKLFBELAH DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BF20", Offset = "0x2F1AF20", VA = "0x182F1BF20")]
	private bool ENBGGFJNHJG(Entity IEFFOCOBJJI, out HMIKLFBELAH DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BE10", Offset = "0x2F1AE10", VA = "0x182F1BE10")]
	private void EBGLOKLBDMC(Entity IEFFOCOBJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D0B0", Offset = "0x2F1C0B0", VA = "0x182F1D0B0")]
	private void JAHJBFLMNLA(Entity IEFFOCOBJJI, HMIKLFBELAH DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BBB0", Offset = "0x2F1ABB0", VA = "0x182F1BBB0")]
	private bool DPAOIAMHEBB(HMIKLFBELAH DCLMHANFEGK, out HashSet<object> HLIGBNPNBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2F1DF80", Offset = "0x2F1CF80", VA = "0x182F1DF80")]
	private HashSet<object> PJDNPEIDGEP()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ILEMGPNEOAB : global::NAPGCIEFEOB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x55B9C30", Offset = "0x55B8C30", VA = "0x1855B9C30", Slot = "4")]
	public float PJMFIPBGOJA(float3 DFEOJBAFBHE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NOGDEPALEGL : global::NAPGCIEFEOB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x55BA9C0", Offset = "0x55B99C0", VA = "0x1855BA9C0", Slot = "4")]
	public float PJMFIPBGOJA(float3 DFEOJBAFBHE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KJDABPGHLMJ : global::NAPGCIEFEOB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x55BA4C0", Offset = "0x55B94C0", VA = "0x1855BA4C0", Slot = "4")]
	public float PJMFIPBGOJA(float3 DFEOJBAFBHE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct POJNPBFKNNA : global::NAPGCIEFEOB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x11ACA60", Offset = "0x11ABA60", VA = "0x1811ACA60", Slot = "4")]
	public int PJMFIPBGOJA(int3 DFEOJBAFBHE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LKKLHLJOIEH : global::NAPGCIEFEOB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x13FCC10", Offset = "0x13FBC10", VA = "0x1813FCC10", Slot = "4")]
	public int PJMFIPBGOJA(int3 DFEOJBAFBHE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GNHHNNLNKIM : global::NAPGCIEFEOB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x55B9A80", Offset = "0x55B8A80", VA = "0x1855B9A80", Slot = "4")]
	public int PJMFIPBGOJA(int3 DFEOJBAFBHE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class BLMNNMGEPDH : DPKIKFFCGDF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type JALHAAEFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69E130", Offset = "0x69D130", VA = "0x18069E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x55B8800", Offset = "0x55B7800", VA = "0x1855B8800")]
	public BLMNNMGEPDH(Type AAGKLIPKMMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ILPFPDPNEBP : BLMNNMGEPDH
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x55B8800", Offset = "0x55B7800", VA = "0x1855B8800")]
	public ILPFPDPNEBP(Type AAGKLIPKMMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HHELEBCMGBG : BLMNNMGEPDH
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type HMBGNEFKOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69E140", Offset = "0x69D140", VA = "0x18069E140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55B9A90", Offset = "0x55B8A90", VA = "0x1855B9A90")]
	public HHELEBCMGBG(Type AIFMIOKONLH, Type AAGKLIPKMMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CNPLGNFBEPP : BLMNNMGEPDH
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x55B8800", Offset = "0x55B7800", VA = "0x1855B8800")]
	public CNPLGNFBEPP(Type AAGKLIPKMMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BLFKHCHIGFF : DPKIKFFCGDF
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public BLFKHCHIGFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GAMJJBEBIEK : DPKIKFFCGDF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LFELPHGLBIM KNDCODGLMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67E040", Offset = "0x67D040", VA = "0x18067E040")]
		[CompilerGenerated]
		get
		{
			return default(LFELPHGLBIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x55B9930", Offset = "0x55B8930", VA = "0x1855B9930")]
	public GAMJJBEBIEK(LFELPHGLBIM DNPJACNCEDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class CGJFLAGLGMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly AHBEEJODFBD GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager MKHPDCKNNBB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AHBEEJODFBD MECEOFMEJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x55B8920", Offset = "0x55B7920", VA = "0x1855B8920")]
	public CGJFLAGLGMG(AHBEEJODFBD GLPDAIBKGJO, EntityManager MKHPDCKNNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x22E4BB0", Offset = "0x22E3BB0", VA = "0x1822E4BB0")]
	public bool NHOAACKGCKM<T>(Entity IEFFOCOBJJI) where T : struct, BIFMJHFCMBA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x22E2940", Offset = "0x22E1940", VA = "0x1822E2940")]
	public bool AEDILPALBPG<T>(Entity IEFFOCOBJJI, out T DFEOJBAFBHE) where T : struct, BIFMJHFCMBA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x22E29D0", Offset = "0x22E19D0", VA = "0x1822E29D0")]
	public T EMKPGFDPCID<T>(Entity IEFFOCOBJJI) where T : struct, BIFMJHFCMBA
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x22E43B0", Offset = "0x22E33B0", VA = "0x1822E43B0")]
	private ComponentType NDADIIAEKKP<T>() where T : struct, BIFMJHFCMBA
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x55B8850", Offset = "0x55B7850", VA = "0x1855B8850")]
	private ComponentType NDADIIAEKKP(Type IGEIBCJNCHF)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class MAAAHNNGDPO
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	protected MAAAHNNGDPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class PFLHINGOIIF<View, Data> : PGIKEAFDIOH where View : struct, BIFMJHFCMBA where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType LBOGJMNEAKF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type MDFGGBFMAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x346B510", Offset = "0x346A510", VA = "0x18346B510", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type JLJKAKGEBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x346CA50", Offset = "0x346BA50", VA = "0x18346CA50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int JDBGPHIFEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x346A9C0", Offset = "0x34699C0", VA = "0x18346A9C0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x346BB70", Offset = "0x346AB70", VA = "0x18346BB70")]
	public Data EGFJMGIIOMF(Entity IEFFOCOBJJI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x346AA80", Offset = "0x3469A80", VA = "0x18346AA80")]
	public Data CCNGJMJMNMP(Entity IEFFOCOBJJI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View OLNKNOPMCHH(Entity IEFFOCOBJJI);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DD90", Offset = "0x3A6CD90", VA = "0x183A6DD90", Slot = "15")]
	protected internal override T OLNKNOPMCHH<T>(Entity IEFFOCOBJJI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1E33270", Offset = "0x1E32270", VA = "0x181E33270")]
	protected PFLHINGOIIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class PGIKEAFDIOH : KANENNLDGEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic OHHGJADLADP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager KEPLCDNBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xADD070", Offset = "0xADC070", VA = "0x180ADD070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type MDFGGBFMAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type JLJKAKGEBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int JDBGPHIFEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type LEPNBIFAGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1994360", Offset = "0x1993360", VA = "0x181994360", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int JGKBMJHLHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x55BBD80", Offset = "0x55BAD80", VA = "0x1855BBD80", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private ONEPLGLDGPM[] BCIMBEFBCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1994460", Offset = "0x1993460", VA = "0x181994460", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual ONEPLGLDGPM[] ILODDHJBLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x55BBCC0", Offset = "0x55BACC0", VA = "0x1855BBCC0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EOKAGOLFOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x55BBAE0", Offset = "0x55BAAE0", VA = "0x1855BBAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x55BBB10", Offset = "0x55BAB10", VA = "0x1855BBB10")]
	public void NAGCBALDEME(EntityManager MKHPDCKNNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x77B500", Offset = "0x77A500", VA = "0x18077B500")]
	protected KANENNLDGEA ICHMDEIGEKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T OLNKNOPMCHH<T>(Entity IEFFOCOBJJI) where T : struct, BIFMJHFCMBA;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x55BBDF0", Offset = "0x55BADF0", VA = "0x1855BBDF0", Slot = "8")]
	public (uint, uint) PMAEJCKEABM(Entity IEFFOCOBJJI)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x55BBC30", Offset = "0x55BAC30", VA = "0x1855BBC30", Slot = "9")]
	public bool NNBHJPBHOAE(Entity IEFFOCOBJJI, (uint order, uint change) IIJDDKBOPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	protected PGIKEAFDIOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class HHKAFOKLEHG<Data> : CBDMAFGMIBG where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data DCLACCPOJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E010", Offset = "0x2E3D010", VA = "0x182E3E010", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2224430", Offset = "0x2223430", VA = "0x182224430", Slot = "8")]
	protected virtual bool GLCFABJPCDC(ReadOnlySpan<Data> FKFMFNKJNOH, LDGDBBFAFNK NEHLAILGLJO, out ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "9")]
	protected virtual bool EHOJBANGFCF(int IIJDDKBOPLN, Span<Data> FKFMFNKJNOH, in ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E040", Offset = "0x2E3D040", VA = "0x182E3E040", Slot = "5")]
	internal sealed override bool GLCFABJPCDC(ref Unity.Entities.Chunk LDGNGMADGKK, int NIKJDHGOLFL, LDGDBBFAFNK NEHLAILGLJO, out ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D5E0", Offset = "0x2E3C5E0", VA = "0x182E3D5E0", Slot = "6")]
	internal sealed override bool EHOJBANGFCF(int IIJDDKBOPLN, ref Unity.Entities.Chunk LDGNGMADGKK, int NIKJDHGOLFL, in ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1E73DB0", Offset = "0x1E72DB0", VA = "0x181E73DB0")]
	protected global::MDCAJNGFNFL<Protobuf> CBKFCDHDFOC<Protobuf>(ReadOnlySpan<Data> FKFMFNKJNOH) where Protobuf : IMessage, new()
	{
		return default(global::MDCAJNGFNFL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1E73E00", Offset = "0x1E72E00", VA = "0x181E73E00")]
	protected global::LJLPAFFKOGM<Protobuf> FHFIIKEGAFF<Protobuf>(ReadOnlySpan<byte> GEGIPEOHNBF, ReadOnlySpan<Data> FKFMFNKJNOH, Action<Protobuf> FFICHOMLEMH) where Protobuf : IMessage, new()
	{
		return default(global::LJLPAFFKOGM<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1E33270", Offset = "0x1E32270", VA = "0x181E33270")]
	protected HHKAFOKLEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class CBDMAFGMIBG
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int DKBOPEOPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x55B8830", Offset = "0x55B7830", VA = "0x1855B8830", Slot = "5")]
	internal virtual bool GLCFABJPCDC(ref Unity.Entities.Chunk LDGNGMADGKK, int NIKJDHGOLFL, LDGDBBFAFNK NEHLAILGLJO, out ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "6")]
	internal virtual bool EHOJBANGFCF(int IIJDDKBOPLN, ref Unity.Entities.Chunk LDGNGMADGKK, int NIKJDHGOLFL, in ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	protected CBDMAFGMIBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NAPGCIEFEOB<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo PJMFIPBGOJA(TFrom DFEOJBAFBHE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface JODPMOJLJEB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FKHEBADIFPK(T DFEOJBAFBHE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct LJENJDGMKBK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::NAPGCIEFEOB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> GKCKKOPKKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> DJABHCMDJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap KNOLDLABLMF;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct NDDNDNKNHKL<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::NAPGCIEFEOB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> AGGBDMPACAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> DJABHCMDJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap KNOLDLABLMF;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct AFHBFMNGJAO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LMKHAKHFJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> GKCKKOPKKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> DJABHCMDJML;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2956D20", Offset = "0x2955D20", VA = "0x182956D20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct BAEHPIOJCKF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LMKHAKHFJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> GKCKKOPKKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> BJIAPIHEEIN;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct BNFIPEINMNM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::NAPGCIEFEOB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> HNGGIGIEIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> DJABHCMDJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap KNOLDLABLMF;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct DHKAEFPBGMG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AAGKLIPKMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> PNFNAEBJOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> FNBMOBIFEGM;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct PCIIBAFEGAI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AAGKLIPKMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> PNFNAEBJOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> FNBMOBIFEGM;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3466D20", Offset = "0x3465D20", VA = "0x183466D20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct HKIDFHPGCGA<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> GKCKKOPKKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> BJIAPIHEEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, PEFLLNEDEOA> IEOJBDIPJCJ;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2E45A80", Offset = "0x2E44A80", VA = "0x182E45A80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct JIKAPLBKHMK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::NAPGCIEFEOB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> GKCKKOPKKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> BJIAPIHEEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, PEFLLNEDEOA> IEOJBDIPJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap KNOLDLABLMF;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct JNOMKBLJGPF<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::JODPMOJLJEB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> GKCKKOPKKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> BJIAPIHEEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate KNOLDLABLMF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct MFCGMGLFCJO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public BOHBJPNCJPN AAGKLIPKMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> PNFNAEBJOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> LKHJOJCENFJ;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x55BA850", Offset = "0x55B9850", VA = "0x1855BA850", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct GHJELCJDGPB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public BOHBJPNCJPN AAGKLIPKMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> PNFNAEBJOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> LKHJOJCENFJ;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x55B99F0", Offset = "0x55B89F0", VA = "0x1855B99F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IOFDIFECDKH
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class OAEBMKFJJHO
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x277B300", Offset = "0x277A300", VA = "0x18277B300")]
	public static bool BACLGINNGAL<T>(this NativeArray<Entity> PNFNAEBJOEK, EntityManager MKHPDCKNNBB, Allocator AEPJLHDIHPH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class HPMKOGAOEHA
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MAOHJIJLJPH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public MAOHJIJLJPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class LLKOLICKCEF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public LLKOLICKCEF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> JPHJGMABBJO;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x55B9BB0", Offset = "0x55B8BB0", VA = "0x1855B9BB0")]
	public HPMKOGAOEHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HMNHLGDOHPO
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JHLDIDLMPGF
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct AGCCJPOHFOJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct EAKCPCDMEBM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal AGCCJPOHFOJ<TFrom> ICMEPOIJCJO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> PPLEFHADAKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct ODHLHDJBNJL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct DMBALNFIGKP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal ODHLHDJBNJL<TFrom> ICMEPOIJCJO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> PPLEFHADAKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct HPNGDBLOIEL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct ALGIKEPOEHM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal HPNGDBLOIEL<TFrom> ICMEPOIJCJO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal global::OKGGDJPONBN<TFrom> PPLEFHADAKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct CEPEEMKIMAM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct CHIFDEJJJFF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal CEPEEMKIMAM<TFrom> ICMEPOIJCJO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal global::LNAIBACCGLG<TFrom> PPLEFHADAKM;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class BBDIEEFDOKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class BLJAKMOJIDC
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x22DC080", Offset = "0x22DB080", VA = "0x1822DC080")]
	public static NativeList<T> FABOAAKDEAI<T>(this NativeArray<T> ONGKEBNKDIN, Allocator AEPJLHDIHPH = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class GNIJKKPLNHP
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x225B2A0", Offset = "0x225A2A0", VA = "0x18225B2A0")]
	public static NativeArray<T> MNJOFNKPBBC<T>(this NativeList<Entity> ONGKEBNKDIN, EntityManager MKHPDCKNNBB, Allocator AEPJLHDIHPH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x225B0A0", Offset = "0x225A0A0", VA = "0x18225B0A0")]
	public static NativeArray<T> MNJOFNKPBBC<T>(this NativeArray<Entity> ONGKEBNKDIN, EntityManager MKHPDCKNNBB, Allocator AEPJLHDIHPH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class PMLMMKPJJBF
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct BLDJDHHGIDA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct PMBDCJGEAFB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public BLDJDHHGIDA<TFrom> PPLEFHADAKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> GKCKKOPKKIH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct IACDFNFANBC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct FCJFKPLDBKD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public IACDFNFANBC<TFrom> PPLEFHADAKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public global::OKGGDJPONBN<TFrom> GKCKKOPKKIH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct MJIKGJMAANK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct PAMCGEPKILE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public MJIKGJMAANK<TFrom> PPLEFHADAKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public global::LNAIBACCGLG<TFrom> GKCKKOPKKIH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FELABMIHKFB
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class AKGBIPPDIMD
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct HBHMOHKCJBJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> GKCKKOPKKIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct PJDKDBJNOOF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> GKCKKOPKKIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct LEHHPBBJNKO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public global::OKGGDJPONBN<T> GKCKKOPKKIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct MGLAGNFEHBP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator AEPJLHDIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public global::LNAIBACCGLG<T> GKCKKOPKKIH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class EFKKHJLILPP
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class CAOHMDMEJEA
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x22E1F60", Offset = "0x22E0F60", VA = "0x1822E1F60")]
	public static NativeList<Entity> HNKMBFABBLP<T>(this NativeArray<Entity> PNFNAEBJOEK, EntityManager MKHPDCKNNBB, Allocator AEPJLHDIHPH = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class OLHPAADAOIJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface NEAOMDHOEFC
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JKAOKLJHAJK
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class DOAEDFEDIKP
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DLGDJIKJNJP
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x55B90C0", Offset = "0x55B80C0", VA = "0x1855B90C0")]
	public static bool EOJJIBLENNI(Type IGEIBCJNCHF, Type BNEMKMLIIBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class DINPMFJKIMA<Attribute, BaseClass> : global::NIKBJEOPDLO<BaseClass>, JMNDOGGEHBE where Attribute : BLMNNMGEPDH
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly FBNJDMKEPCN KKLHLPEDHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string IADPDEAGFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> OJEPGCDOOOH;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x28D5BB0", Offset = "0x28D4BB0", VA = "0x1828D5BB0")]
	public DINPMFJKIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x28D5930", Offset = "0x28D4930", VA = "0x1828D5930", Slot = "4")]
	public bool HGEFFBLNLHD(int CNNKHGOHIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x28D5680", Offset = "0x28D4680", VA = "0x1828D5680", Slot = "5")]
	public global::BOONDFDEOBC<BaseClass> GDEMGPNGCHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x28D5580", Offset = "0x28D4580", VA = "0x1828D5580", Slot = "7")]
	protected virtual bool EOJJIBLENNI(Type IGEIBCJNCHF, int CENMOHBFEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x28D5990", Offset = "0x28D4990", VA = "0x1828D5990", Slot = "8")]
	protected virtual int HLOHCPOHJGD(Type IGEIBCJNCHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x28D5A20", Offset = "0x28D4A20", VA = "0x1828D5A20")]
	public void JJOFCNGHIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x28D5AB0", Offset = "0x28D4AB0", VA = "0x1828D5AB0", Slot = "6")]
	public void MNFGPLMIANE(Type IGEIBCJNCHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BOONDFDEOBC<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> PMCGALCIOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> IOFKIEAPBID;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> DGNLPPPJGJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2412D40", Offset = "0x2411D40", VA = "0x182412D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2413260", Offset = "0x2412260", VA = "0x182413260")]
	public BOONDFDEOBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x24130C0", Offset = "0x24120C0", VA = "0x1824130C0")]
	public BOONDFDEOBC(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2412F70", Offset = "0x2411F70", VA = "0x182412F70")]
	internal void HMNAIPBHJIK(int CNNKHGOHIDH, BaseClass LHAACBBCHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1E6C5C0", Offset = "0x1E6B5C0", VA = "0x181E6C5C0")]
	public bool KGFLIOPKLPH<T>(out BaseClass DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2412FF0", Offset = "0x2411FF0", VA = "0x182412FF0")]
	public bool KGFLIOPKLPH(Type OMMPBBANJJE, out BaseClass DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2412D10", Offset = "0x2411D10", VA = "0x182412D10")]
	public bool BMHMBPBFCHN(int CNNKHGOHIDH, out BaseClass DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1E6D2D0", Offset = "0x1E6C2D0", VA = "0x181E6D2D0")]
	public T NFCNICJMGHA<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2413090", Offset = "0x2412090", VA = "0x182413090")]
	public BaseClass NFCNICJMGHA(Type LOPGHOAOIIJ)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class NLEIAGJBLJM : global::DINPMFJKIMA<ILPFPDPNEBP, MAAAHNNGDPO>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55BA950", Offset = "0x55B9950", VA = "0x1855BA950")]
	public NLEIAGJBLJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class KEKMCBHLKOG : global::DINPMFJKIMA<HHELEBCMGBG, PGIKEAFDIOH>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55BA450", Offset = "0x55B9450", VA = "0x1855BA450")]
	public KEKMCBHLKOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class KJHNHOCGCNA : global::DINPMFJKIMA<CNPLGNFBEPP, CBDMAFGMIBG>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x55BA4E0", Offset = "0x55B94E0", VA = "0x1855BA4E0")]
	public KJHNHOCGCNA()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[LMNMHFHDONH(IPKPBIMLPOB.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> ELKKGBGGKPO;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x851A00", Offset = "0x850A00", VA = "0x180851A00")]
		private ComponentSystemTypes(List<Type> ELKKGBGGKPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x55B8DA0", Offset = "0x55B7DA0", VA = "0x1855B8DA0")]
		public static void JJOFCNGHIKE(List<Type> ELKKGBGGKPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x55B8E30", Offset = "0x55B7E30", VA = "0x1855B8E30")]
		private void LLCMBFPMJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x55B8CC0", Offset = "0x55B7CC0", VA = "0x1855B8CC0")]
		private bool EOJJIBLENNI(Type IGEIBCJNCHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x55B8D40", Offset = "0x55B7D40", VA = "0x1855B8D40")]
		private void FLIHGLDNEMP(Type IGEIBCJNCHF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class DLPLBLIFJLF : PAOJLIIMPCN
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x55B92F0", Offset = "0x55B82F0", VA = "0x1855B92F0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase OENKBFADAEF();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x55B92A0", Offset = "0x55B82A0", VA = "0x1855B92A0")]
	protected ComponentSystemBase KCHLGHPOBCA(params ComponentSystemBase[] GNCNHHEOEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x25AE260", Offset = "0x25AD260", VA = "0x1825AE260")]
	protected ComponentSystemBase KCHLGHPOBCA<T>(params ComponentSystemBase[] GNCNHHEOEMG) where T : PAOJLIIMPCN, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x25AE220", Offset = "0x25AD220", VA = "0x1825AE220")]
	protected ComponentSystemBase CNIDCJAGEIL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x25AE220", Offset = "0x25AD220", VA = "0x1825AE220")]
	protected ComponentSystemBase NGNNIACNHML<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	protected DLPLBLIFJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface NIKBJEOPDLO<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HGEFFBLNLHD(int CNNKHGOHIDH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BOONDFDEOBC<BaseClass> GDEMGPNGCHF();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class PAOJLIIMPCN : CKEIFNPCMDD
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x55BB250", Offset = "0x55BA250", VA = "0x1855BB250", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public PAOJLIIMPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class GAJBCDLDAEF : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x55B9880", Offset = "0x55B8880", VA = "0x1855B9880")]
	public BOHBJPNCJPN JPKLDMKIDKM(int CNNKHGOHIDH, bool FJBBIADFENA = false)
	{
		return default(BOHBJPNCJPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x55B9920", Offset = "0x55B8920", VA = "0x1855B9920", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0")]
	protected GAJBCDLDAEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class EIFFBCEFCLG : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0")]
	protected EIFFBCEFCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class HNBBKDMFLBC : GAJBCDLDAEF
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x55B9B80", Offset = "0x55B8B80", VA = "0x1855B9B80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	protected void NIBCFDKIMOM(string BDICMGNPCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0")]
	protected HNBBKDMFLBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class MGBCMMGGCNO
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class CKEIFNPCMDD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	protected CKEIFNPCMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[LMNMHFHDONH(IPKPBIMLPOB.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x55BC750", Offset = "0x55BB750", VA = "0x1855BC750")]
		public static ComponentSystemGroup[] BGMBBEENKKB(World GLPDAIBKGJO, DJOCFFCOADN OKGGGEBIMAO = DJOCFFCOADN.Default, bool MPOCNFLGCIF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x55BCE00", Offset = "0x55BBE00", VA = "0x1855BCE00")]
		private static Type[] KCOGEMCJDOH(DJOCFFCOADN OKGGGEBIMAO, bool MPOCNFLGCIF, ComponentSystemGroup[] ANPKCHGPLIC, ComponentSystemGroup GBACFGPNNLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x55BC960", Offset = "0x55BB960", VA = "0x1855BC960")]
		private static ComponentSystemGroup[] GJJIHKDAGMO(World GLPDAIBKGJO, out ComponentSystemGroup GBACFGPNNLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x55BD160", Offset = "0x55BC160", VA = "0x1855BD160")]
		internal static bool MEHEABHKOFH(LFELPHGLBIM DNPJACNCEDM, out BKDOMKKCDOJ KNAMBEEGCIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x55BC820", Offset = "0x55BB820", VA = "0x1855BC820")]
		private static ComponentSystemGroup CGAGCJBGNDC(Type IGEIBCJNCHF, World GLPDAIBKGJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x55BCC70", Offset = "0x55BBC70", VA = "0x1855BCC70")]
		private static ComponentSystemGroup[] IIDPDOKBBEI(Type[] ELKKGBGGKPO, World GLPDAIBKGJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x55BC230", Offset = "0x55BB230", VA = "0x1855BC230")]
		internal static void APMCKFIBJKA(World GLPDAIBKGJO, Type[] DFBPANLIOFF, ComponentSystemGroup[] ANPKCHGPLIC, ComponentSystemGroup GBACFGPNNLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x55BCDA0", Offset = "0x55BBDA0", VA = "0x1855BCDA0")]
		internal static bool JNMINHECNAO(ComponentSystemBase KFLDFPCKAGO, ComponentSystemGroup[] ANPKCHGPLIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x55BC900", Offset = "0x55BB900", VA = "0x1855BC900")]
		private static void CKHKCDNOHMM(ComponentSystemGroup[] ANPKCHGPLIC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct NEDBOLCHHNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> IGEGENPKKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> GNCNHHEOEMG;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x72EA10", Offset = "0x72DA10", VA = "0x18072EA10")]
	public NEDBOLCHHNN(Dictionary<Type, List<Type>> IGEGENPKKBC, HashSet<Type> GNCNHHEOEMG)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[LMNMHFHDONH(IPKPBIMLPOB.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class PLBLKANBODG : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
			[DebuggerHidden]
			public PLBLKANBODG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x55BC150", Offset = "0x55BB150", VA = "0x1855BC150", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x55BBEB0", Offset = "0x55BAEB0", VA = "0x1855BBEB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x55BC1E0", Offset = "0x55BB1E0", VA = "0x1855BC1E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x55BC110", Offset = "0x55BB110", VA = "0x1855BC110", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x55BC060", Offset = "0x55BB060", VA = "0x1855BC060", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x55BC060", Offset = "0x55BB060", VA = "0x1855BC060", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct GDJMPGNJEKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type JGGMINKDHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private DJOCFFCOADN OKGGGEBIMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool GGBGOACPIMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool AAPLKFKFLDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool MPOCNFLGCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> HKHPPAFINGD;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x55BD6C0", Offset = "0x55BC6C0", VA = "0x1855BD6C0")]
		public static RRFilterWorldSystems HJNGNBALKKN()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x55BE280", Offset = "0x55BD280", VA = "0x1855BE280")]
		public RRFilterWorldSystems MPIADOAJDAO(DJOCFFCOADN DNPJACNCEDM)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x55BE290", Offset = "0x55BD290", VA = "0x1855BE290")]
		public RRFilterWorldSystems OFKPJFIBLEJ(IEnumerable<Type> ELKKGBGGKPO)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x55BDE30", Offset = "0x55BCE30", VA = "0x1855BDE30")]
		public RRFilterWorldSystems JIPALONCGJB(bool CMGNCBMMLMB)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x55BE2D0", Offset = "0x55BD2D0", VA = "0x1855BE2D0")]
		public RRFilterWorldSystems ONNDAMDAFHH(bool FPOFPFJLJFC)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x55BE2E0", Offset = "0x55BD2E0", VA = "0x1855BE2E0")]
		public NEDBOLCHHNN PPIGENGHNME(Type[] EBNDGIHJDLH)
		{
			return default(NEDBOLCHHNN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x55BD630", Offset = "0x55BC630", VA = "0x1855BD630")]
		[IteratorStateMachine(typeof(PLBLKANBODG))]
		internal IEnumerable<Type> FPLKJAPIHCH(IEnumerable<Type> ELKKGBGGKPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x55BDFA0", Offset = "0x55BCFA0", VA = "0x1855BDFA0")]
		internal Dictionary<Type, List<Type>> KIIGPAOGDOM(IEnumerable<Type> ELKKGBGGKPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x55BDD20", Offset = "0x55BCD20", VA = "0x1855BDD20")]
		private void IILOHMKLEHC(Dictionary<Type, List<Type>> MIHJGHDPEEA, Type IGEIBCJNCHF, Type GLCHNOFKLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x55BD470", Offset = "0x55BC470", VA = "0x1855BD470")]
		internal HashSet<Type> CFPAHCEKJNC(IEnumerable<Type> ANPKCHGPLIC, Dictionary<Type, List<Type>> LLHCHDMLAEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x55BD6E0", Offset = "0x55BC6E0", VA = "0x1855BD6E0")]
		internal bool HMCFFKKHLAJ(Type IGEIBCJNCHF, DJOCFFCOADN OKGGGEBIMAO, bool MPOCNFLGCIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x55BDE40", Offset = "0x55BCE40", VA = "0x1855BDE40")]
		[CompilerGenerated]
		internal static void KDKHLOGMOPI(Type IGEIBCJNCHF, ref GDJMPGNJEKO P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class FLPDJKONBHF
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool HGHOOJICMNB;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x55B9820", Offset = "0x55B8820", VA = "0x1855B9820")]
	public static void NAGCBALDEME(bool PAKHNBOHLFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x55B9660", Offset = "0x55B8660", VA = "0x1855B9660")]
	private static void ACOLCLNJHLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class BCNEMLAPGCF
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x55B8710", Offset = "0x55B7710", VA = "0x1855B8710")]
	public static ulong AFNNBPHKGAA(Type IGEIBCJNCHF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x55B8740", Offset = "0x55B7740", VA = "0x1855B8740")]
	public static ulong AFNNBPHKGAA(string HDJJFFIBBNJ)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[LMNMHFHDONH(IPKPBIMLPOB.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct GCKHIIMBHDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong MOEINDJENLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong GFHLLAPIEAG;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xDF1520", Offset = "0xDF0520", VA = "0x180DF1520")]
			public GCKHIIMBHDI(ulong FJJFFHMGFAL, ulong MDLBNCFOFDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x55B9960", Offset = "0x55B8960", VA = "0x1855B9960", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> BEGDEGNEFJH;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static GCKHIIMBHDI[] EMGMBLDHJKE;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool HGHOOJICMNB;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x55BF0D0", Offset = "0x55BE0D0", VA = "0x1855BF0D0")]
		public static ulong OKFECKLLABO(int CNNKHGOHIDH)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x55BEC50", Offset = "0x55BDC50", VA = "0x1855BEC50")]
		public static int DPGFPFKDPIB(ulong MDLBNCFOFDI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x55BEE50", Offset = "0x55BDE50", VA = "0x1855BEE50")]
		public static void NAGCBALDEME(bool PAKHNBOHLFK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x55BE740", Offset = "0x55BD740", VA = "0x1855BE740")]
		private static void AKEPBEGGLJE(int CNIEHAHPHOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x55BE930", Offset = "0x55BD930", VA = "0x1855BE930")]
		private static void DGJMONBMJNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x55BE660", Offset = "0x55BD660", VA = "0x1855BE660")]
		private static GCKHIIMBHDI AEFPKHCEOFH(Type IGEIBCJNCHF)
		{
			return default(GCKHIIMBHDI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x55BED00", Offset = "0x55BDD00", VA = "0x1855BED00")]
		private static ulong FKHPHMEBLDI(Type IGEIBCJNCHF, ulong MDLBNCFOFDI)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x55BE440", Offset = "0x55BD440", VA = "0x1855BE440")]
		private static void AADKLAGAEDC(in GCKHIIMBHDI IHNPIFLOBIO, TypeManager.TypeInfo PMBEBMHHMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x55BE820", Offset = "0x55BD820", VA = "0x1855BE820")]
		private static void APPDIOILEEC(GCKHIIMBHDI PMBEBMHHMPM, int CNNKHGOHIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x55BED70", Offset = "0x55BDD70", VA = "0x1855BED70")]
		private static void HKPNBDCLCMC(GCKHIIMBHDI PMBEBMHHMPM, int CNNKHGOHIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x55BF040", Offset = "0x55BE040", VA = "0x1855BF040")]
		private static GCKHIIMBHDI NHPLJILLBKH(int CNNKHGOHIDH)
		{
			return default(GCKHIIMBHDI);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x55BE920", Offset = "0x55BD920", VA = "0x1855BE920")]
		private static int CIGFEDACOBI(int CNNKHGOHIDH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class ODCHIOCPCJD
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly KEKMCBHLKOG JKNNMJPPANC;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly KJHNHOCGCNA OMDCEIGHONB;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly NLEIAGJBLJM EHFEHCCHJCG;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> ALAEALIIMLM;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool HGHOOJICMNB;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::NIKBJEOPDLO<PGIKEAFDIOH> AIINFBCBPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x55BA9D0", Offset = "0x55B99D0", VA = "0x1855BA9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::NIKBJEOPDLO<CBDMAFGMIBG> IINCDJMOKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x55BAAB0", Offset = "0x55B9AB0", VA = "0x1855BAAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::NIKBJEOPDLO<MAAAHNNGDPO> GIBKLNCIJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x55BAFC0", Offset = "0x55B9FC0", VA = "0x1855BAFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x55BAB10", Offset = "0x55B9B10", VA = "0x1855BAB10")]
	public static void NAGCBALDEME(bool PAKHNBOHLFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x55BAA30", Offset = "0x55B9A30", VA = "0x1855BAA30")]
	public static Type[] ELABNLHFDJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class JGMBJKEECBN
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> FCHNNIMCCCB;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool HGHOOJICMNB;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x55BA330", Offset = "0x55B9330", VA = "0x1855BA330")]
	public static int PMAEJCKEABM(int CNNKHGOHIDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x55BA010", Offset = "0x55B9010", VA = "0x1855BA010")]
	public static void NAGCBALDEME(bool PAKHNBOHLFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x55BA0B0", Offset = "0x55B90B0", VA = "0x1855BA0B0")]
	private static void NAMMKKIDOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x55B9F40", Offset = "0x55B8F40", VA = "0x1855B9F40")]
	private static int EFJNJOEOPGG(Type IGEIBCJNCHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x55B9F90", Offset = "0x55B8F90", VA = "0x1855B9F90")]
	private static void EMOCNNJJBKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class AHBEEJODFBD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World KJHAPGELJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly CGJFLAGLGMG LHAACBBCHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] ANPKCHGPLIC;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World MECEOFMEJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World BGENOIKENDC
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager KEPLCDNBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x852930", Offset = "0x851930", VA = "0x180852930")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CGJFLAGLGMG GBGKPEOJFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::BOONDFDEOBC<PGIKEAFDIOH> AIINFBCBPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x716AE0", Offset = "0x715AE0", VA = "0x180716AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::BOONDFDEOBC<CBDMAFGMIBG> IINCDJMOKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x685570", Offset = "0x684570", VA = "0x180685570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x685590", Offset = "0x684590", VA = "0x180685590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::BOONDFDEOBC<MAAAHNNGDPO> GIBKLNCIJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x685580", Offset = "0x684580", VA = "0x180685580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6855A0", Offset = "0x6845A0", VA = "0x1806855A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> JCLAJNCOHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x852970", Offset = "0x851970", VA = "0x180852970")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] EBJOKCCEPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x55B7E00", Offset = "0x55B6E00", VA = "0x1855B7E00")]
	public static AHBEEJODFBD FIIKKBAJFPM(string IADPDEAGFAB, LFELPHGLBIM DNPJACNCEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x55B8120", Offset = "0x55B7120", VA = "0x1855B8120")]
	public AHBEEJODFBD(string IADPDEAGFAB, LFELPHGLBIM DNPJACNCEDM = LFELPHGLBIM.Simulation, DJOCFFCOADN OKGGGEBIMAO = DJOCFFCOADN.Default, bool PAKHNBOHLFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x55B7A40", Offset = "0x55B6A40", VA = "0x1855B7A40")]
	public ComponentSystemBase CPCHBPHHPKH(Type IGEIBCJNCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2279930", Offset = "0x2278930", VA = "0x182279930")]
	public T CPCHBPHHPKH<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x55B8000", Offset = "0x55B7000", VA = "0x1855B8000")]
	public void OFLJFKIPKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x55B7FA0", Offset = "0x55B6FA0", VA = "0x1855B7FA0")]
	public void LCAIHBDCECF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x55B7F40", Offset = "0x55B6F40", VA = "0x1855B7F40")]
	public void KCFCOLOKIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x55B76E0", Offset = "0x55B66E0", VA = "0x1855B76E0")]
	public void ADPILCIAJEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x55B80C0", Offset = "0x55B70C0", VA = "0x1855B80C0")]
	public void OGJMHMGIGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x55B7A60", Offset = "0x55B6A60", VA = "0x1855B7A60")]
	public void DLMOLMMLNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x55B7E80", Offset = "0x55B6E80", VA = "0x1855B7E80")]
	public void FOBMONNDEAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x55B7740", Offset = "0x55B6740", VA = "0x1855B7740")]
	public void BDNKGFPCEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x55B7EE0", Offset = "0x55B6EE0", VA = "0x1855B7EE0")]
	public void IHODNNMJLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x55B8060", Offset = "0x55B7060", VA = "0x1855B8060")]
	public void OGEFIPAEEKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x55B7960", Offset = "0x55B6960", VA = "0x1855B7960")]
	internal void CMEAKHKIPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x55B78E0", Offset = "0x55B68E0", VA = "0x1855B78E0")]
	private bool BNOABPADIMM(ComponentSystemGroup JOKFNNKABBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x55B7B30", Offset = "0x55B6B30", VA = "0x1855B7B30")]
	private void FEMGEKLEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x55B77D0", Offset = "0x55B67D0", VA = "0x1855B77D0")]
	private ComponentSystemGroup[] BGMBBEENKKB(DJOCFFCOADN OKGGGEBIMAO, bool MPOCNFLGCIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x55B7AC0", Offset = "0x55B6AC0", VA = "0x1855B7AC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum LFELPHGLBIM
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
public sealed class AKNKNKMHPHI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public DJOCFFCOADN CGKMNIPCKDH;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum DJOCFFCOADN
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
public interface BKDOMKKCDOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type PCPMHJMOFFI
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] PDBCIOGHAII
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class DAJBIMEDELB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool KJLNDPHJKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x69F020", Offset = "0x69E020", VA = "0x18069F020", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	protected DAJBIMEDELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class NOJHNPFEEEK : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public NOJHNPFEEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class MKJABAMJHFG : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public MKJABAMJHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class CBMCNFGKKIE : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public CBMCNFGKKIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class GNLJPHBPHDD : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public GNLJPHBPHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class NFLLPDGJECH : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public NFLLPDGJECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class IEFOBDFNPEA : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public IEFOBDFNPEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class BIPCFAGHHOL : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public BIPCFAGHHOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class EMCPAACKFBP : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public EMCPAACKFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class MGLIHHFJPCA : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public MGLIHHFJPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class AGJALCIGKKG : AHKIEBBLMMB
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public AGJALCIGKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class EMNLGBGFAID : AHKIEBBLMMB
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public EMNLGBGFAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class GDGEEMHEIHE : AHKIEBBLMMB
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public GDGEEMHEIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class EJJAHMJHKIF : AHKIEBBLMMB
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public EJJAHMJHKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[HEOEGCBCCCD(KHFGEOAKOKD.Application)]
public class AHKIEBBLMMB : DAJBIMEDELB
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool KJLNDPHJKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x55B76D0", Offset = "0x55B66D0", VA = "0x1855B76D0")]
	public AHKIEBBLMMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class HFKGOIIGIAJ : DPKIKFFCGDF
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public HFKGOIIGIAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class CPAKEILGBEB
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void EEBCCDBGNKE<From, To>(From PPLEFHADAKM, ref To KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class EDDHPNIFIMD<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static EEBCCDBGNKE<From, To> NPJFBOKGGFJ;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public EDDHPNIFIMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x55B8AC0", Offset = "0x55B7AC0", VA = "0x1855B8AC0")]
	static CPAKEILGBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x24E0680", Offset = "0x24DF680", VA = "0x1824E0680")]
	public static void ODPOHMGBFCJ<T>(EEBCCDBGNKE<T, T> PDOOFOCADKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x24E0510", Offset = "0x24DF510", VA = "0x1824E0510")]
	public static void ODPOHMGBFCJ<From, To>(EEBCCDBGNKE<From, To> PDOOFOCADKK, EEBCCDBGNKE<To, From> JCNMMNDBMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x24E05A0", Offset = "0x24DF5A0", VA = "0x1824E05A0")]
	public static void ODPOHMGBFCJ<From, To>(EEBCCDBGNKE<From, To> NPJFBOKGGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x24DB970", Offset = "0x24DA970", VA = "0x1824DB970")]
	public static EEBCCDBGNKE<From, To> HBHHNEJDPJF<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x24DF230", Offset = "0x24DE230", VA = "0x1824DF230")]
	public static void HIJELFNCJBL<From, To>(From PPLEFHADAKM, ref To KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class LDGDBBFAFNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> PECHDIDCODG;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xC3E9D0", Offset = "0xC3D9D0", VA = "0x180C3E9D0")]
	public LDGDBBFAFNK(NativeArray<EntityRemapUtility.EntityRemapInfo> PECHDIDCODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F370", Offset = "0x2A7E370", VA = "0x182A7F370")]
	public Entity FCJOGJOJPII(Entity JFBGEPNCFEC)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class IPMIGCALIKI
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> HIPOIHIHJOM;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x55B9D50", Offset = "0x55B8D50", VA = "0x1855B9D50")]
	public static bool FBOLGBJNPIJ(ulong NHBPPIHNEOH, uint IIJDDKBOPLN, out string IADPDEAGFAB)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[LMNMHFHDONH(IPKPBIMLPOB.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct INBAFFCDJNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int EBAKNIMBLHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int DKBOPEOPEBA;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x69F050", Offset = "0x69E050", VA = "0x18069F050")]
			public INBAFFCDJNN(int NPDGHPHAKDK, int IIJDDKBOPLN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct FGMNFIHFJAM
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch DELOHPFEPEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long JKHPMALILOJ;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long FIHOJLMBNCJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x55B9600", Offset = "0x55B8600", VA = "0x1855B9600")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long MLLAOKHLMGM
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x55B9590", Offset = "0x55B8590", VA = "0x1855B9590")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x55B94D0", Offset = "0x55B84D0", VA = "0x1855B94D0")]
			public static FGMNFIHFJAM DBEFHDBAOPI()
			{
				return default(FGMNFIHFJAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct AELLKNIPFPD : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct FDDOEMACDPC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* FCBBBPDAPJB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly BLKDOACIBKE.BBAKPJBAPBP.ELHEPFCCPBN HHJBIOEAPHP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly LDGDBBFAFNK NEHLAILGLJO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::BOONDFDEOBC<CBDMAFGMIBG> BMNJABIDNBC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int NIKJDHGOLFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int EHPHMOBJNOI;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x55B9470", Offset = "0x55B8470", VA = "0x1855B9470")]
				public unsafe FDDOEMACDPC(Unity.Entities.Archetype* FCBBBPDAPJB, BLKDOACIBKE.BBAKPJBAPBP.ELHEPFCCPBN HHJBIOEAPHP, LDGDBBFAFNK NEHLAILGLJO, global::BOONDFDEOBC<CBDMAFGMIBG> BMNJABIDNBC, int NIKJDHGOLFL, int EHPHMOBJNOI = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x55B9420", Offset = "0x55B8420", VA = "0x1855B9420")]
				public FDDOEMACDPC(in FDDOEMACDPC FILAKGLBGGA, int EHPHMOBJNOI)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly FDDOEMACDPC[] FKFMFNKJNOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] FABPGKJIHLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int GPPGBMINCCN;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x55B7590", Offset = "0x55B6590", VA = "0x1855B7590")]
			public AELLKNIPFPD(FDDOEMACDPC[] FKFMFNKJNOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x55B7180", Offset = "0x55B6180", VA = "0x1855B7180", Slot = "4")]
			public void Invoke(int NPDGHPHAKDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x55B71E0", Offset = "0x55B61E0", VA = "0x1855B71E0")]
			private void KLLDALDKDAE(in FDDOEMACDPC FILAKGLBGGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x55B6EB0", Offset = "0x55B5EB0", VA = "0x1855B6EB0")]
			private static void DGOPINBPHNO(in FDDOEMACDPC FILAKGLBGGA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class AINILPDEEOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public BLKDOACIBKE asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::BOONDFDEOBC<CBDMAFGMIBG> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public AINILPDEEOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x55B8640", Offset = "0x55B7640", VA = "0x1855B8640")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class GKKIGPPEAAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public BLKDOACIBKE.BBAKPJBAPBP.ELHEPFCCPBN srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AINILPDEEOH CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public GKKIGPPEAAA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class INJLCCBFOAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public GKKIGPPEAAA CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public INJLCCBFOAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x55B9C40", Offset = "0x55B8C40", VA = "0x1855B9C40")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly FBNJDMKEPCN JMKJAKDNGGC;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly FBNJDMKEPCN GOJKHEJPMPP;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly FBNJDMKEPCN MNOBKDLBDNF;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly FBNJDMKEPCN GKKODJBFCAO;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool NOJIINFGMBD;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static BLKDOACIBKE.BBAKPJBAPBP.OOCGAJGLBHG KLBLLIGJDOI;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x55C1930", Offset = "0x55C0930", VA = "0x1855C1930")]
		private unsafe static bool ICIBLEHILDI(Unity.Entities.Archetype* FAAKDBHJKLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x55C21F0", Offset = "0x55C11F0", VA = "0x1855C21F0")]
		internal unsafe static Unity.Entities.Archetype*[] KBEPOIPIBIL(ref Unity.Entities.EntityComponentStore IGGABMEGPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x55BF4D0", Offset = "0x55BE4D0", VA = "0x1855BF4D0")]
		public static void CCPOABEFOJK(AHBEEJODFBD GLPDAIBKGJO, out ByteString GEGIPEOHNBF, out NativeArray<EntityRemapUtility.EntityRemapInfo> NFLOAHPEMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x55C1200", Offset = "0x55C0200", VA = "0x1855C1200")]
		internal static void HNLLOFGMABD(AHBEEJODFBD GLPDAIBKGJO, BLKDOACIBKE KPHIJHMJGGO, out NativeArray<EntityRemapUtility.EntityRemapInfo> NFLOAHPEMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x55C0C40", Offset = "0x55BFC40", VA = "0x1855C0C40")]
		private unsafe static UnsafeHashMap<ulong, INBAFFCDJNN> HIIAGONLDHI(Unity.Entities.Archetype*[] DLELACHNGDH)
		{
			return default(UnsafeHashMap<ulong, INBAFFCDJNN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x55C1A40", Offset = "0x55C0A40", VA = "0x1855C1A40")]
		private static void IFBEGDOBOAM(BLKDOACIBKE KPHIJHMJGGO, UnsafeHashMap<ulong, INBAFFCDJNN> BKMOHPHNBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x55C0ED0", Offset = "0x55BFED0", VA = "0x1855C0ED0")]
		private unsafe static void HMLFJHDAKOJ(BLKDOACIBKE KPHIJHMJGGO, Unity.Entities.Archetype*[] DLELACHNGDH, UnsafeHashMap<ulong, INBAFFCDJNN> BKMOHPHNBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x55C0BD0", Offset = "0x55BFBD0", VA = "0x1855C0BD0")]
		private unsafe static int GHLLMGNNPKP(Unity.Entities.Archetype*[] DLELACHNGDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x55BF590", Offset = "0x55BE590", VA = "0x1855BF590")]
		private unsafe static void EGEMONLNEAJ(BLKDOACIBKE KPHIJHMJGGO, Unity.Entities.Archetype*[] DLELACHNGDH, global::BOONDFDEOBC<CBDMAFGMIBG> BMNJABIDNBC, NativeArray<EntityRemapUtility.EntityRemapInfo> NFLOAHPEMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x55C0090", Offset = "0x55BF090", VA = "0x1855C0090")]
		private static NativeArray<int> FDOKHOJFLOD(BLKDOACIBKE KPHIJHMJGGO)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x55C2690", Offset = "0x55C1690", VA = "0x1855C2690")]
		private static Memory<EntityArchetype> MMFABMDDMFN(BLKDOACIBKE KPHIJHMJGGO, NativeArray<int> ELKKGBGGKPO, EntityManager MKHPDCKNNBB, out int HMFBBDOOMCF, out int IAFIDIECALG)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x55C1BF0", Offset = "0x55C0BF0", VA = "0x1855C1BF0")]
		private unsafe static void IFJJEDCBCHM(Unity.Entities.Chunk* OKOFJBFBBNF, ReadOnlySpan<byte> GEGIPEOHNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x55C0300", Offset = "0x55BF300", VA = "0x1855C0300")]
		private static void FNLPCAPFDDE(BLKDOACIBKE KPHIJHMJGGO, NativeArray<int> ELKKGBGGKPO, Span<EntityArchetype> DLELACHNGDH, EntityManager MKHPDCKNNBB, global::BOONDFDEOBC<CBDMAFGMIBG> BMNJABIDNBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x55C2A20", Offset = "0x55C1A20", VA = "0x1855C2A20")]
		private unsafe static void OIHBHHLAKFF(Unity.Entities.Chunk* LDGNGMADGKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x55BF1C0", Offset = "0x55BE1C0", VA = "0x1855BF1C0")]
		private unsafe static void ALBPAPOCGNI(BLKDOACIBKE.BBAKPJBAPBP.ELHEPFCCPBN FCBBBPDAPJB, int PCFANJAIONI, int PELMEDIKHKE, Unity.Entities.Chunk* OKOFJBFBBNF, BLKDOACIBKE KPHIJHMJGGO, NativeArray<int> ELKKGBGGKPO, global::BOONDFDEOBC<CBDMAFGMIBG> BMNJABIDNBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x55BF9B0", Offset = "0x55BE9B0", VA = "0x1855BF9B0")]
		public static void EPHJIJGNBHP(AHBEEJODFBD GLPDAIBKGJO, in ByteString GEGIPEOHNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x55BFA40", Offset = "0x55BEA40", VA = "0x1855BFA40")]
		public static void EPHJIJGNBHP(EntityManager MKHPDCKNNBB, global::BOONDFDEOBC<CBDMAFGMIBG> BMNJABIDNBC, in ByteString GEGIPEOHNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x55C23D0", Offset = "0x55C13D0", VA = "0x1855C23D0")]
		private static bool LOIMOGGMAKK(Type IGEIBCJNCHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x55C1F40", Offset = "0x55C0F40", VA = "0x1855C1F40")]
		private static void IOIPGJKHNMK(TypeManager.TypeInfo PMBEBMHHMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x55C0A40", Offset = "0x55BFA40", VA = "0x1855C0A40")]
		private unsafe static int FOFFOOCGKOC(Unity.Entities.Archetype*[] DLELACHNGDH, NativeArray<EntityRemapUtility.EntityRemapInfo> NFLOAHPEMAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x55C2B40", Offset = "0x55C1B40", VA = "0x1855C2B40")]
		private static int PMAEJCKEABM(int CNNKHGOHIDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x55C2AA0", Offset = "0x55C1AA0", VA = "0x1855C2AA0")]
		private static ulong OKFECKLLABO(int CNNKHGOHIDH)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class PBIMCAKLMBE
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x55BB810", Offset = "0x55BA810", VA = "0x1855BB810")]
	private unsafe static Span<byte> JDCKMGAPEGJ(Unity.Entities.Chunk* LDGNGMADGKK, int NIKJDHGOLFL)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2790B50", Offset = "0x278FB50", VA = "0x182790B50")]
	public unsafe static Span<T> LMBHMKJPFDG<T>(Unity.Entities.Chunk* LDGNGMADGKK, int NIKJDHGOLFL)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2790B10", Offset = "0x278FB10", VA = "0x182790B10")]
	public static Span<T> LMBHMKJPFDG<T>(this ref Unity.Entities.Chunk LDGNGMADGKK, int NIKJDHGOLFL)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x55BB500", Offset = "0x55BA500", VA = "0x1855BB500")]
	public unsafe static Span<Entity> ADNDJPPAIGG(Unity.Entities.Chunk* LDGNGMADGKK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x55BB570", Offset = "0x55BA570", VA = "0x1855BB570")]
	public unsafe static void EMOCNNJJBKM(Unity.Entities.Chunk* LDGNGMADGKK, int NIKJDHGOLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x55BB9B0", Offset = "0x55BA9B0", VA = "0x1855BB9B0")]
	public static Entity PHEOEBJBIMO(this EntityQuery FBENFNFLPOM)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : GDNMPNNPIMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x55C2E80", Offset = "0x55C1E80", VA = "0x1855C2E80", Slot = "4")]
		public sealed override void JJOFCNGHIKE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KJPGGDKBIND()
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
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

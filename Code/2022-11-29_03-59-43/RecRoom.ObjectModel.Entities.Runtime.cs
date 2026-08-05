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
internal static class FPAOHDIPHEI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x559CD70", Offset = "0x559B970", VA = "0x18559CD70")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> KOBAAPOCEKF(this ref Unity.Entities.Archetype HNNIEOPALKC)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NIKPAGCHBMP
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x559F080", Offset = "0x559DC80", VA = "0x18559F080")]
	public static Span<int> OBNPNPKEOCK(this EntityArchetype HNNIEOPALKC)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EJBOMNGEOCP
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HHCJFKEJIFP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x559D0F0", Offset = "0x559BCF0", VA = "0x18559D0F0")]
	public static bool ILPKKNHIECH(this Entity LLEBIIAHFDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ONGPMNIBABD
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[BurstCompile]
	private struct MPBCPMAIDJE<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[ReadOnly]
		public NativeArray<Entity> OHKHEJKMDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[WriteOnly]
		public ComponentDataFromEntity<T> PAJHAMANKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public T GKFICKKHACC;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2558D00", Offset = "0x2557900", VA = "0x182558D00", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[BurstCompile]
	private struct MGPJMAHDLDH<T> : IJobChunk where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[WriteOnly]
		public ArchetypeChunkComponentType<T> EOBDMANLMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T GKFICKKHACC;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B64FE0", Offset = "0x2B63BE0", VA = "0x182B64FE0")]
	public static void GFEILCKAPIE<T>(this EntityManager CLLNDNAAIKP, NativeArray<Entity> FNMNPGEEPJI, T GKFICKKHACC) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B65520", Offset = "0x2B64120", VA = "0x182B65520")]
	public static void NLKAJGECPCE<T>(this EntityManager CLLNDNAAIKP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B65300", Offset = "0x2B63F00", VA = "0x182B65300")]
	public static void KPJDLJIHJMI<T>(this EntityManager CLLNDNAAIKP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B63E10", Offset = "0x2B62A10", VA = "0x182B63E10")]
	public static JobHandle BGDDHNIGPEB<T>(this EntityManager CLLNDNAAIKP) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x559F570", Offset = "0x559E170", VA = "0x18559F570")]
	public static JobHandle BGDDHNIGPEB(this EntityManager CLLNDNAAIKP, int BGAEBMDLBPN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OIPJFPILMBJ<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PENINHGKOBO : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::OIPJFPILMBJ<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696C40", VA = "0x180698040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B549E0", Offset = "0x2B535E0", VA = "0x182B549E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5730", Offset = "0x1FB4330", VA = "0x181FB5730")]
		[DebuggerHidden]
		public PENINHGKOBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B54800", Offset = "0x2B53400", VA = "0x182B54800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B549A0", Offset = "0x2B535A0", VA = "0x182B549A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> OKJHDDINGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream HPPBGHGOBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream JMCPKGLAFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf JLOCDKLJJOH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int ONIEICNEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x677010", Offset = "0x675C10", VA = "0x180677010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27584D0", Offset = "0x27570D0", VA = "0x1827584D0")]
	private OIPJFPILMBJ(byte[] NFMJIELOGNG, Action<Protobuf> OKJHDDINGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x23B0EA0", Offset = "0x23AFAA0", VA = "0x1823B0EA0")]
	public static global::OIPJFPILMBJ<Protobuf> GLBIKEOEKPG<Data>(ReadOnlySpan<byte> MEFFDBODCGD, ReadOnlySpan<Data> CKIGFGIEPDP, Action<Protobuf> OKJHDDINGCG)
	{
		return default(global::OIPJFPILMBJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2758340", Offset = "0x2756F40", VA = "0x182758340", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2758380", Offset = "0x2756F80", VA = "0x182758380", Slot = "4")]
	[IteratorStateMachine(typeof(global::OIPJFPILMBJ<>.PENINHGKOBO))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2758480", Offset = "0x2757080", VA = "0x182758480", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OIJLGNEDGDI<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] NFMJIELOGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf JLOCDKLJJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream HPPBGHGOBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream OBEFABEEHHP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2757EC0", Offset = "0x2756AC0", VA = "0x182757EC0")]
	private OIJLGNEDGDI(byte[] NFMJIELOGNG, in Protobuf JLOCDKLJJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x23AE330", Offset = "0x23ACF30", VA = "0x1823AE330")]
	public static global::OIJLGNEDGDI<Protobuf> GLBIKEOEKPG<T>(ReadOnlySpan<T> CKIGFGIEPDP)
	{
		return default(global::OIJLGNEDGDI<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2757E90", Offset = "0x2756A90", VA = "0x182757E90")]
	public void POIJPBDECIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2757E00", Offset = "0x2756A00", VA = "0x182757E00")]
	public ByteString KMNNOBBLEPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2757CD0", Offset = "0x27568D0", VA = "0x182757CD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EBOKFMBFINI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream HPPBGHGOBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream JMCPKGLAFAP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x559C620", Offset = "0x559B220", VA = "0x18559C620", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct ELBMMLICLFM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] NFMJIELOGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream HPPBGHGOBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream OBEFABEEHHP;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x559C720", Offset = "0x559B320", VA = "0x18559C720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LCFDEDCDBML
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	public static void FAPAIEBHNEJ(this FNIDFMEJGMB CBDAGBGGFJM, NativeArray<Entity> FNMNPGEEPJI, [Optional][CallerFilePath] string CGBPJHDDLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	public static void FAPAIEBHNEJ(this FNIDFMEJGMB CBDAGBGGFJM, string NLCIGFDKGEE, NativeArray<Entity> FNMNPGEEPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	public static void FAPAIEBHNEJ(this FNIDFMEJGMB CBDAGBGGFJM, string CGBPJHDDLMJ, NativeArray<Entity> FNMNPGEEPJI, bool DEKNKGENFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	public static void MFNLAGNJBDI(this FNIDFMEJGMB CBDAGBGGFJM, NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> MCPLHLPJDOB, [Optional][CallerFilePath] string CGBPJHDDLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	public static void MFNLAGNJBDI(this FNIDFMEJGMB CBDAGBGGFJM, string CGBPJHDDLMJ, NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> MCPLHLPJDOB, bool DEKNKGENFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3D148D0", Offset = "0x3D134D0", VA = "0x183D148D0")]
	public static void IAANGBJNDCF<T>(this FNIDFMEJGMB CBDAGBGGFJM, string NLCIGFDKGEE, NativeArray<Entity> FNMNPGEEPJI, NativeList<T> JLFCOOGLPMP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3D14960", Offset = "0x3D13560", VA = "0x183D14960")]
	public static void IAANGBJNDCF<T>(this FNIDFMEJGMB CBDAGBGGFJM, string NLCIGFDKGEE, NativeArray<Entity> FNMNPGEEPJI, NativeArray<T> JLFCOOGLPMP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	public static void IAANGBJNDCF<T>(this FNIDFMEJGMB CBDAGBGGFJM, string CGBPJHDDLMJ, NativeArray<Entity> FNMNPGEEPJI, NativeArray<T> JLFCOOGLPMP, bool DEKNKGENFOI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D149D0", Offset = "0x3D135D0", VA = "0x183D149D0")]
	public static void OFLHJLFCLGE<T>(this FNIDFMEJGMB CBDAGBGGFJM, NativeList<T> JLFCOOGLPMP, [Optional][CallerFilePath] string CGBPJHDDLMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D149A0", Offset = "0x3D135A0", VA = "0x183D149A0")]
	public static void OFLHJLFCLGE<T>(this FNIDFMEJGMB CBDAGBGGFJM, NativeArray<T> JLFCOOGLPMP, [Optional][CallerFilePath] string CGBPJHDDLMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	public static void OFLHJLFCLGE<T>(this FNIDFMEJGMB CBDAGBGGFJM, string CGBPJHDDLMJ, NativeArray<T> JLFCOOGLPMP, bool DEKNKGENFOI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	public static void KNKJJBNIBMB(this FNIDFMEJGMB CBDAGBGGFJM, EntityQuery NJIBLOIMOJA, [Optional][CallerFilePath] string CGBPJHDDLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	public static void KNKJJBNIBMB(this FNIDFMEJGMB CBDAGBGGFJM, string NLCIGFDKGEE, EntityQuery NJIBLOIMOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	public static void KNKJJBNIBMB(this FNIDFMEJGMB CBDAGBGGFJM, string CGBPJHDDLMJ, EntityQuery NJIBLOIMOJA, bool DEKNKGENFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D148A0", Offset = "0x3D134A0", VA = "0x183D148A0")]
	public static void GEABOHOPJAB<T, T2>(this FNIDFMEJGMB CBDAGBGGFJM, string NLCIGFDKGEE, EntityQuery NJIBLOIMOJA) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	private static void GEABOHOPJAB<T, T2>(this FNIDFMEJGMB CBDAGBGGFJM, string CGBPJHDDLMJ, EntityQuery NJIBLOIMOJA, bool DEKNKGENFOI) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NEJDHLEFDKK : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ECALDJBELBI JJELKCAHCLF
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
public interface GELKDICEMGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFBFCIOBDHE(Entity LLEBIIAHFDD, object JJFHDFJGCDG);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KCPCJNKGKEA(Entity LLEBIIAHFDD, object JJFHDFJGCDG);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NEPGOCILDIE(Entity LLEBIIAHFDD);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NEPGOCILDIE(ECALDJBELBI DKBLPJPHEMF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> IDEGJNBALHG(Entity LLEBIIAHFDD);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MCILOEENMGD(Entity LLEBIIAHFDD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AFDHPHLDLGD<TComponentData, TValue> : global::ALJMPJGEOPC<TValue>, IDisposable where TComponentData : struct, NEJDHLEFDKK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class MBMCPEFFGLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> LENGKEKMOEB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int EONFJIOMKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3310", Offset = "0x1FC1F10", VA = "0x181FC3310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2FEF060", Offset = "0x2FEDC60", VA = "0x182FEF060")]
		public bool GFMJJCOKGLI(out TValue GKFICKKHACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2FEEFB0", Offset = "0x2FEDBB0", VA = "0x182FEEFB0")]
		public void ELGBPIMHCCH(object JJFHDFJGCDG, TValue GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2FEEF30", Offset = "0x2FEDB30", VA = "0x182FEEF30")]
		public bool DOHHNJJEEIG(object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2FEF120", Offset = "0x2FEDD20", VA = "0x182FEF120")]
		public int NJHNFHMHPKP(object JJFHDFJGCDG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2FEF1D0", Offset = "0x2FEDDD0", VA = "0x182FEF1D0")]
		public MBMCPEFFGLB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<MBMCPEFFGLB> CKGPGEGHFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::FIGNPHGKAHK<ECALDJBELBI, MBMCPEFFGLB> KCODIAHCFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager CLLNDNAAIKP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3B96920", Offset = "0x3B95520", VA = "0x183B96920")]
	public AFDHPHLDLGD(EntityManager CLLNDNAAIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3B96800", Offset = "0x3B95400", VA = "0x183B96800", Slot = "4")]
	public void PFBFCIOBDHE(Entity LLEBIIAHFDD, object JJFHDFJGCDG, TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3B965D0", Offset = "0x3B951D0", VA = "0x183B965D0", Slot = "5")]
	public bool KCPCJNKGKEA(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3B96320", Offset = "0x3B94F20", VA = "0x183B96320", Slot = "6")]
	public bool GFMJJCOKGLI(Entity LLEBIIAHFDD, out TValue GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3B96300", Offset = "0x3B94F00", VA = "0x183B96300", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3B963F0", Offset = "0x3B94FF0", VA = "0x183B963F0")]
	private void GKFBMFONHHI(MBMCPEFFGLB KHEDNDCPGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B96520", Offset = "0x3B95120", VA = "0x183B96520")]
	private bool JLCNPKGMBFL(Entity LLEBIIAHFDD, out ECALDJBELBI DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B96490", Offset = "0x3B95090", VA = "0x183B96490")]
	private void IJAHJFJKKAH(Entity LLEBIIAHFDD, ECALDJBELBI DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3B96470", Offset = "0x3B95070", VA = "0x183B96470")]
	private bool GPFGLGBOMBI(ECALDJBELBI DKBLPJPHEMF, out MBMCPEFFGLB KHEDNDCPGJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B96740", Offset = "0x3B95340", VA = "0x183B96740")]
	private MBMCPEFFGLB LGBBGCMDKAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ALJMPJGEOPC<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFBFCIOBDHE(Entity LLEBIIAHFDD, object JJFHDFJGCDG, TValue GKFICKKHACC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KCPCJNKGKEA(Entity LLEBIIAHFDD, object JJFHDFJGCDG);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFMJJCOKGLI(Entity LLEBIIAHFDD, out TValue GKFICKKHACC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct ECALDJBELBI : global::LHEMAHBEHEJ<ECALDJBELBI>, MKBPDIMFNJC, IEquatable<ECALDJBELBI>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly ECALDJBELBI AFLCPHCCBKP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int OMNKALCAHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727A20", VA = "0x180728E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x728D90", Offset = "0x727990", VA = "0x180728D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int BDCBCEKMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B60", Offset = "0x8B4760", VA = "0x1808B5B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xEC96C0", Offset = "0xEC82C0", VA = "0x180EC96C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x559C660", Offset = "0x559B260", VA = "0x18559C660", Slot = "8")]
	public bool Equals(ECALDJBELBI MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x559C6B0", Offset = "0x559B2B0", VA = "0x18559C6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PBJIHBFONCG<T> : GELKDICEMGM, IDisposable where T : struct, NEJDHLEFDKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> CKGPGEGHFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::FIGNPHGKAHK<ECALDJBELBI, HashSet<object>> KCODIAHCFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager CLLNDNAAIKP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B453E0", Offset = "0x2B43FE0", VA = "0x182B453E0")]
	public PBJIHBFONCG(EntityManager CLLNDNAAIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B44CC0", Offset = "0x2B438C0", VA = "0x182B44CC0", Slot = "4")]
	public bool PFBFCIOBDHE(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B43710", Offset = "0x2B42310", VA = "0x182B43710", Slot = "5")]
	public bool KCPCJNKGKEA(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2B44420", Offset = "0x2B43020", VA = "0x182B44420", Slot = "6")]
	public bool NEPGOCILDIE(Entity LLEBIIAHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B44540", Offset = "0x2B43140", VA = "0x182B44540", Slot = "7")]
	public bool NEPGOCILDIE(ECALDJBELBI DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2B42D90", Offset = "0x2B41990", VA = "0x182B42D90", Slot = "8")]
	public IEnumerable<object> IDEGJNBALHG(Entity LLEBIIAHFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B42A50", Offset = "0x2B41650", VA = "0x182B42A50", Slot = "11")]
	public IEnumerable<object> IDEGJNBALHG(ECALDJBELBI DKBLPJPHEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B44330", Offset = "0x2B42F30", VA = "0x182B44330", Slot = "9")]
	public bool MCILOEENMGD(Entity LLEBIIAHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B420B0", Offset = "0x2B40CB0", VA = "0x182B420B0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B427F0", Offset = "0x2B413F0", VA = "0x182B427F0")]
	private void GKFBMFONHHI(HashSet<object> KHEDNDCPGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B43480", Offset = "0x2B42080", VA = "0x182B43480")]
	private bool JLCNPKGMBFL(Entity LLEBIIAHFDD, out ECALDJBELBI DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B421F0", Offset = "0x2B40DF0", VA = "0x182B421F0")]
	private bool GIGPELMCPGK(Entity LLEBIIAHFDD, out ECALDJBELBI DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B428D0", Offset = "0x2B414D0", VA = "0x182B428D0")]
	private void HIBCCIDMLNO(Entity LLEBIIAHFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2B42FD0", Offset = "0x2B41BD0", VA = "0x182B42FD0")]
	private void IJAHJFJKKAH(Entity LLEBIIAHFDD, ECALDJBELBI DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B44EC0", Offset = "0x2B43AC0", VA = "0x182B44EC0")]
	private bool PHCEDLGLDDI(ECALDJBELBI DKBLPJPHEMF, out HashSet<object> KHEDNDCPGJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B43C50", Offset = "0x2B42850", VA = "0x182B43C50")]
	private HashSet<object> LGBBGCMDKAB()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DHANEGJOLGG : global::ECLKMMBEIHE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x559B6F0", Offset = "0x559A2F0", VA = "0x18559B6F0", Slot = "4")]
	public float IOPLKCEOOIO(float3 GKFICKKHACC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GDFJDMBPOEB : global::ECLKMMBEIHE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x559CEC0", Offset = "0x559BAC0", VA = "0x18559CEC0", Slot = "4")]
	public float IOPLKCEOOIO(float3 GKFICKKHACC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PPKNDFJGDFG : global::ECLKMMBEIHE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x559F7E0", Offset = "0x559E3E0", VA = "0x18559F7E0", Slot = "4")]
	public float IOPLKCEOOIO(float3 GKFICKKHACC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct LEPPOOLKHJF : global::ECLKMMBEIHE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x128D500", Offset = "0x128C100", VA = "0x18128D500", Slot = "4")]
	public int IOPLKCEOOIO(int3 GKFICKKHACC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JPKDNPKBHFN : global::ECLKMMBEIHE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1532B70", Offset = "0x1531770", VA = "0x181532B70", Slot = "4")]
	public int IOPLKCEOOIO(int3 GKFICKKHACC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NHAKHMEDLGK : global::ECLKMMBEIHE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x559F070", Offset = "0x559DC70", VA = "0x18559F070", Slot = "4")]
	public int IOPLKCEOOIO(int3 GKFICKKHACC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class HFCJGNDPFEG : NDNOEJBHMOK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type MDCOMHOPGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695D30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xF90230", Offset = "0xF8EE30", VA = "0x180F90230")]
	public HFCJGNDPFEG(Type IBNLPGGMLFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IAAENPILNCG : HFCJGNDPFEG
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xF90230", Offset = "0xF8EE30", VA = "0x180F90230")]
	public IAAENPILNCG(Type IBNLPGGMLFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MBEPPANCEDB : HFCJGNDPFEG
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type PAHCGOPPLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695D40", VA = "0x180697140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x559F020", Offset = "0x559DC20", VA = "0x18559F020")]
	public MBEPPANCEDB(Type FMAMPKHAHKF, Type IBNLPGGMLFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NIINPNOELJA : HFCJGNDPFEG
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xF90230", Offset = "0xF8EE30", VA = "0x180F90230")]
	public NIINPNOELJA(Type IBNLPGGMLFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OPLAMEBGNBC : NDNOEJBHMOK
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public OPLAMEBGNBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class COFLBKKDFAJ : NDNOEJBHMOK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KDONHBHPBNG ALHLODPJMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675C40", VA = "0x180677040")]
		[CompilerGenerated]
		get
		{
			return default(KDONHBHPBNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xF902A0", Offset = "0xF8EEA0", VA = "0x180F902A0")]
	public COFLBKKDFAJ(KDONHBHPBNG MBNFLPKEEGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class DKCCOABIFKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly LGIKDIEECOD AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager CLLNDNAAIKP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LGIKDIEECOD IAMBCCOEDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x559BFF0", Offset = "0x559ABF0", VA = "0x18559BFF0")]
	public DKCCOABIFKH(LGIKDIEECOD AEEDEJIEEFL, EntityManager CLLNDNAAIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x23086B0", Offset = "0x23072B0", VA = "0x1823086B0")]
	public bool JHEJAAPOGPF<T>(Entity LLEBIIAHFDD) where T : struct, EPPHGLODPLG
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2308EF0", Offset = "0x2307AF0", VA = "0x182308EF0")]
	public bool OPOAONJGMIP<T>(Entity LLEBIIAHFDD, out T GKFICKKHACC) where T : struct, EPPHGLODPLG
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2306CD0", Offset = "0x23058D0", VA = "0x182306CD0")]
	public T CDJJENHCKHH<T>(Entity LLEBIIAHFDD) where T : struct, EPPHGLODPLG
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x23086F0", Offset = "0x23072F0", VA = "0x1823086F0")]
	private ComponentType MOHLCAGOCHK<T>() where T : struct, EPPHGLODPLG
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x559BF20", Offset = "0x559AB20", VA = "0x18559BF20")]
	private ComponentType MOHLCAGOCHK(Type BIEGICDMJCM)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class OCCCFKPBJLI
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	protected OCCCFKPBJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class DBEPIALKLEJ<View, Data> : OCECHDCDPOJ where View : struct, EPPHGLODPLG where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType DBGGHGJKCHC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type ALLEOEDFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2E13640", Offset = "0x2E12240", VA = "0x182E13640", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type MKHGEGPAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2E14470", Offset = "0x2E13070", VA = "0x182E14470", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int EKNNEAHLIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2E152E0", Offset = "0x2E13EE0", VA = "0x182E152E0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2E12EB0", Offset = "0x2E11AB0", VA = "0x182E12EB0")]
	public Data AMFGDDAKKBO(Entity LLEBIIAHFDD)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2E153A0", Offset = "0x2E13FA0", VA = "0x182E153A0")]
	public Data PEKHMHDJKDI(Entity LLEBIIAHFDD)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View GOEPJIPGGGM(Entity LLEBIIAHFDD);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x35CF0B0", Offset = "0x35CDCB0", VA = "0x1835CF0B0", Slot = "15")]
	protected internal override T GOEPJIPGGGM<T>(Entity LLEBIIAHFDD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1336860", Offset = "0x1335460", VA = "0x181336860")]
	protected DBEPIALKLEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class OCECHDCDPOJ : FIOMMIJIHBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic LGNBAPPLCOL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager FAINNDBCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x838A50", Offset = "0x837650", VA = "0x180838A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type ALLEOEDFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type MKHGEGPAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int EKNNEAHLIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type DIKDJDIHOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x795800", Offset = "0x794400", VA = "0x180795800", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int DJLLCLMJFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x559F1B0", Offset = "0x559DDB0", VA = "0x18559F1B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private FPHEKKDEPIJ[] DMOFFHGCONI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x795730", Offset = "0x794330", VA = "0x180795730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual FPHEKKDEPIJ[] MDNKEJMDPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x559F0F0", Offset = "0x559DCF0", VA = "0x18559F0F0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ONDFHEECFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x559F3D0", Offset = "0x559DFD0", VA = "0x18559F3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x559F220", Offset = "0x559DE20", VA = "0x18559F220")]
	public void FNJOFAEFPIL(EntityManager CLLNDNAAIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x773100", VA = "0x180774500")]
	protected FIOMMIJIHBF NMLPNLGCKMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T GOEPJIPGGGM<T>(Entity LLEBIIAHFDD) where T : struct, EPPHGLODPLG;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x559F400", Offset = "0x559E000", VA = "0x18559F400", Slot = "8")]
	public (uint, uint) LBGNMNJAEIO(Entity LLEBIIAHFDD)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x559F340", Offset = "0x559DF40", VA = "0x18559F340", Slot = "9")]
	public bool IAAAGEFBFAH(Entity LLEBIIAHFDD, (uint order, uint change) OPAPEIICLLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	protected OCECHDCDPOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class JOMLNCIGLGF<Data> : EJMMDFNNNIA where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data BLGCIDCPBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x27F9880", Offset = "0x27F8480", VA = "0x1827F9880", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x230E0C0", Offset = "0x230CCC0", VA = "0x18230E0C0", Slot = "8")]
	protected virtual bool HNNCLEKANIL(ReadOnlySpan<Data> CKIGFGIEPDP, IEAJMBBOLLL MKCMLPCNJGL, out ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679900", VA = "0x18067AD00", Slot = "9")]
	protected virtual bool NAJLBOJHHKN(int OPAPEIICLLC, Span<Data> CKIGFGIEPDP, in ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x27F9920", Offset = "0x27F8520", VA = "0x1827F9920", Slot = "5")]
	internal sealed override bool HNNCLEKANIL(ref Unity.Entities.Chunk CNILJNKKOIK, int GMFCANPCKKD, IEAJMBBOLLL MKCMLPCNJGL, out ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x27F9EA0", Offset = "0x27F8AA0", VA = "0x1827F9EA0", Slot = "6")]
	internal sealed override bool NAJLBOJHHKN(int OPAPEIICLLC, ref Unity.Entities.Chunk CNILJNKKOIK, int GMFCANPCKKD, in ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x23FCB90", Offset = "0x23FB790", VA = "0x1823FCB90")]
	protected global::OIJLGNEDGDI<Protobuf> LEGDMAMLLGL<Protobuf>(ReadOnlySpan<Data> CKIGFGIEPDP) where Protobuf : IMessage, new()
	{
		return default(global::OIJLGNEDGDI<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x23FCB00", Offset = "0x23FB700", VA = "0x1823FCB00")]
	protected global::OIPJFPILMBJ<Protobuf> IACIFNKIMME<Protobuf>(ReadOnlySpan<byte> MEFFDBODCGD, ReadOnlySpan<Data> CKIGFGIEPDP, Action<Protobuf> OKJHDDINGCG) where Protobuf : IMessage, new()
	{
		return default(global::OIPJFPILMBJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1336860", Offset = "0x1335460", VA = "0x181336860")]
	protected JOMLNCIGLGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class EJMMDFNNNIA
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int BDCBCEKMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x559C700", Offset = "0x559B300", VA = "0x18559C700", Slot = "5")]
	internal virtual bool HNNCLEKANIL(ref Unity.Entities.Chunk CNILJNKKOIK, int GMFCANPCKKD, IEAJMBBOLLL MKCMLPCNJGL, out ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679900", VA = "0x18067AD00", Slot = "6")]
	internal virtual bool NAJLBOJHHKN(int OPAPEIICLLC, ref Unity.Entities.Chunk CNILJNKKOIK, int GMFCANPCKKD, in ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	protected EJMMDFNNNIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface ECLKMMBEIHE<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo IOPLKCEOOIO(TFrom GKFICKKHACC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LIMNHFIKKPB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BBCKMOKKMKJ(T GKFICKKHACC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct BCDADPPFADG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::ECLKMMBEIHE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> JGDIPONDNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> HFNMHPNPHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap KDJGJCHCIKK;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct JDPDNGOMHJC<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::ECLKMMBEIHE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> KAEDMIBPCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> HFNMHPNPHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap KDJGJCHCIKK;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct CILOKMAHGGJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JAMEKNLPIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> JGDIPONDNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> HFNMHPNPHFK;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3574C60", Offset = "0x3573860", VA = "0x183574C60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct HODPGFNFEFB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JAMEKNLPIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> JGDIPONDNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> PBADLGEIKIK;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct IHCDFMAEDEM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::ECLKMMBEIHE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> CGIGIFHHEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> HFNMHPNPHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap KDJGJCHCIKK;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct IBHPDFEDOOA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IBNLPGGMLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> OHKHEJKMDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> OACJDBGKJBE;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct AIGBPPANIHN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IBNLPGGMLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> OHKHEJKMDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> OACJDBGKJBE;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3B9BBF0", Offset = "0x3B9A7F0", VA = "0x183B9BBF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct KHBNCLOOKAJ<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> JGDIPONDNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> PBADLGEIKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, OIGDPEFJPLN> GJJAOAGKAFC;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x369DE00", Offset = "0x369CA00", VA = "0x18369DE00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct CEPDMGBACOK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::ECLKMMBEIHE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> JGDIPONDNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> PBADLGEIKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, OIGDPEFJPLN> GJJAOAGKAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap KDJGJCHCIKK;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct JACEGIFEOFA<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::LIMNHFIKKPB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> JGDIPONDNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> PBADLGEIKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate KDJGJCHCIKK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct BIFAHHOAKFB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public LFHLPPKAALB IBNLPGGMLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> OHKHEJKMDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> LOAEKFOGIHB;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x559A990", Offset = "0x5599590", VA = "0x18559A990", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct BJEJCOPECHE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public LFHLPPKAALB IBNLPGGMLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> OHKHEJKMDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> LOAEKFOGIHB;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x559AA20", Offset = "0x5599620", VA = "0x18559AA20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class PAEHDOCDAIB
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class CDPLDOFNMJN
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x229EDF0", Offset = "0x229D9F0", VA = "0x18229EDF0")]
	public static bool JFECJILHNMK<T>(this NativeArray<Entity> OHKHEJKMDKP, EntityManager CLLNDNAAIKP, Allocator PBEDBDBGIPF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class FMNEDMIBDBG
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GCMGCOGMGLH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public GCMGCOGMGLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class IGAFEEKOPII<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public IGAFEEKOPII()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> KNMOEIHOLDE;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x559CCF0", Offset = "0x559B8F0", VA = "0x18559CCF0")]
	public FMNEDMIBDBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HBGHKOEGJAN
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KACNIMBOHMG
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct JJKHMLJHMLN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct DNJGJNGKIBI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal JJKHMLJHMLN<TFrom> GEOFAMNLJNK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator PBEDBDBGIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> HOGBBBFDPKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct EOAHIPIMFBE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct MMABOPAPGOL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal EOAHIPIMFBE<TFrom> GEOFAMNLJNK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator PBEDBDBGIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> HOGBBBFDPKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct OMJJKNDHFKB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct PILDNJEBPGI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal OMJJKNDHFKB<TFrom> GEOFAMNLJNK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator PBEDBDBGIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal global::GHKNLLBEIFC<TFrom> HOGBBBFDPKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct MDAADPIKHPB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct HJMPJCHBHPJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal MDAADPIKHPB<TFrom> GEOFAMNLJNK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator PBEDBDBGIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal global::BNGAOKMFDEK<TFrom> HOGBBBFDPKI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class JEFIJPMDGCI
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class FLKJONEJDNC
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x22E79A0", Offset = "0x22E65A0", VA = "0x1822E79A0")]
	public static NativeList<T> MFGOCMIMPBN<T>(this NativeArray<T> CLNPFCHALHA, Allocator PBEDBDBGIPF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class HBGOHGCCOOH
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3524530", Offset = "0x3523130", VA = "0x183524530")]
	public static NativeArray<T> FCCBDJOKMLL<T>(this NativeList<Entity> CLNPFCHALHA, EntityManager CLLNDNAAIKP, Allocator PBEDBDBGIPF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3524330", Offset = "0x3522F30", VA = "0x183524330")]
	public static NativeArray<T> FCCBDJOKMLL<T>(this NativeArray<Entity> CLNPFCHALHA, EntityManager CLLNDNAAIKP, Allocator PBEDBDBGIPF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class HFLFNOKFOBL
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct LLKBAFHFJAE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct AIFOLAEHLGH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public LLKBAFHFJAE<TFrom> HOGBBBFDPKI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator PBEDBDBGIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> JGDIPONDNGP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct JCFDFPBNCIH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct IKKEBIJLNBL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public JCFDFPBNCIH<TFrom> HOGBBBFDPKI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator PBEDBDBGIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public global::GHKNLLBEIFC<TFrom> JGDIPONDNGP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct GPLOIKNABBM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct JPCIOLCEBGC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public GPLOIKNABBM<TFrom> HOGBBBFDPKI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator PBEDBDBGIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public global::BNGAOKMFDEK<TFrom> JGDIPONDNGP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OGEMNKDDDIF
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class BBNOHGGFMLI
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct PKKGLOPENEB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator PBEDBDBGIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> JGDIPONDNGP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct AEFDDJKGPPD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator PBEDBDBGIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> JGDIPONDNGP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct FEIJONPPJIK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator PBEDBDBGIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public global::GHKNLLBEIFC<T> JGDIPONDNGP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct GFGLBJHFOHD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator PBEDBDBGIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public global::BNGAOKMFDEK<T> JGDIPONDNGP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class IJIEBPLINFO
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class APAKDCPACCH
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3A18EB0", Offset = "0x3A17AB0", VA = "0x183A18EB0")]
	public static NativeList<Entity> OLLIBAFBMFB<T>(this NativeArray<Entity> OHKHEJKMDKP, EntityManager CLLNDNAAIKP, Allocator PBEDBDBGIPF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class BONOIJOOICB
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface CEPCKEHFDBE
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JJHIAHNMBLD
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class FJLDELIIECN
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BKAFFECHDNN
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x559AAB0", Offset = "0x55996B0", VA = "0x18559AAB0")]
	public static bool FKOGFIBLFKN(Type BIEGICDMJCM, Type HOHIMJHMIGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class FMIIPLHCIMP<Attribute, BaseClass> : global::MHPJAAHALLD<BaseClass>, HALLEIJLOEG where Attribute : HFCJGNDPFEG
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly FNIDFMEJGMB CBDAGBGGFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string NLCIGFDKGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> ABFBEBHGOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x28A1BB0", Offset = "0x28A07B0", VA = "0x1828A1BB0")]
	public FMIIPLHCIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x28A1A60", Offset = "0x28A0660", VA = "0x1828A1A60", Slot = "4")]
	public bool KOOJGAMNGBI(int BGAEBMDLBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x28A17B0", Offset = "0x28A03B0", VA = "0x1828A17B0", Slot = "5")]
	public global::HAEGCKHPDHM<BaseClass> KCMDPNOPODN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x28A1620", Offset = "0x28A0220", VA = "0x1828A1620", Slot = "7")]
	protected virtual bool FKOGFIBLFKN(Type BIEGICDMJCM, int GNBFKPMADPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x28A1720", Offset = "0x28A0320", VA = "0x1828A1720", Slot = "8")]
	protected virtual int IFFCFGJMNDO(Type BIEGICDMJCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x28A1AC0", Offset = "0x28A06C0", VA = "0x1828A1AC0")]
	public void LHIOLPAIHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x28A1580", Offset = "0x28A0180", VA = "0x1828A1580", Slot = "6")]
	public void EHMHLLLMBAF(Type BIEGICDMJCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HAEGCKHPDHM<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> EEFOOOAMELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> CKEKGLDEEAA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> FJJLJNAJMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3B94040", Offset = "0x3B92C40", VA = "0x183B94040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3B942A0", Offset = "0x3B92EA0", VA = "0x183B942A0")]
	public HAEGCKHPDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3B94430", Offset = "0x3B93030", VA = "0x183B94430")]
	public HAEGCKHPDHM(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3B93F20", Offset = "0x3B92B20", VA = "0x183B93F20")]
	internal void ELGBPIMHCCH(int BGAEBMDLBPN, BaseClass PDOJIOEBHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x23F9B30", Offset = "0x23F8730", VA = "0x1823F9B30")]
	public bool ILGMKKODINB<T>(out BaseClass GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3B93FA0", Offset = "0x3B92BA0", VA = "0x183B93FA0")]
	public bool ILGMKKODINB(Type JIOJHELJNAL, out BaseClass GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x363F950", Offset = "0x363E550", VA = "0x18363F950")]
	public bool LDPEMCOHOGJ(int BGAEBMDLBPN, out BaseClass GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x23FA840", Offset = "0x23F9440", VA = "0x1823FA840")]
	public T LJFLFMHKEAF<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3B94270", Offset = "0x3B92E70", VA = "0x183B94270")]
	public BaseClass LJFLFMHKEAF(Type NHOJABADPMK)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class CDLEFDCPPPA : global::FMIIPLHCIMP<IAAENPILNCG, OCCCFKPBJLI>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x559B1A0", Offset = "0x5599DA0", VA = "0x18559B1A0")]
	public CDLEFDCPPPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FGOIFJIOAGM : global::FMIIPLHCIMP<MBEPPANCEDB, OCECHDCDPOJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x559C900", Offset = "0x559B500", VA = "0x18559C900")]
	public FGOIFJIOAGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class DELAFBDOMBH : global::FMIIPLHCIMP<NIINPNOELJA, EJMMDFNNNIA>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x559B680", Offset = "0x559A280", VA = "0x18559B680")]
	public DELAFBDOMBH()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[HFIGNCEGOKM(DDEOJCINOPG.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> BIPGMHLAMBH;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x88CB80", Offset = "0x88B780", VA = "0x18088CB80")]
		private ComponentSystemTypes(List<Type> BIPGMHLAMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x559B2F0", Offset = "0x5599EF0", VA = "0x18559B2F0")]
		public static void LHIOLPAIHGM(List<Type> BIPGMHLAMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x559B380", Offset = "0x5599F80", VA = "0x18559B380")]
		private void OPLGDBFECPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x559B210", Offset = "0x5599E10", VA = "0x18559B210")]
		private bool FKOGFIBLFKN(Type BIEGICDMJCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x559B290", Offset = "0x5599E90", VA = "0x18559B290")]
		private void HDNDDCAGELI(Type BIEGICDMJCM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class PHGAEFHEOPI : BHBEGOLDLHM
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x559F7A0", Offset = "0x559E3A0", VA = "0x18559F7A0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase HHLKDNFBDIA();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x559F750", Offset = "0x559E350", VA = "0x18559F750")]
	protected ComponentSystemBase DKJJICFOLAL(params ComponentSystemBase[] PCMOOAJDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x313B830", Offset = "0x313A430", VA = "0x18313B830")]
	protected ComponentSystemBase DKJJICFOLAL<T>(params ComponentSystemBase[] PCMOOAJDLNB) where T : BHBEGOLDLHM, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x313B8D0", Offset = "0x313A4D0", VA = "0x18313B8D0")]
	protected ComponentSystemBase NNPIPEJDLDL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x313B8D0", Offset = "0x313A4D0", VA = "0x18313B8D0")]
	protected ComponentSystemBase JDKFFGGPOFG<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	protected PHGAEFHEOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface MHPJAAHALLD<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOOJGAMNGBI(int BGAEBMDLBPN);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::HAEGCKHPDHM<BaseClass> KCMDPNOPODN();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class BHBEGOLDLHM : DFCHDCPEGBM
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x559A6D0", Offset = "0x55992D0", VA = "0x18559A6D0", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public BHBEGOLDLHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class OMEJOMKMFOF : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x559F4C0", Offset = "0x559E0C0", VA = "0x18559F4C0")]
	public LFHLPPKAALB GFFPKOPEJBK(int BGAEBMDLBPN, bool PHLJIIECGMC = false)
	{
		return default(LFHLPPKAALB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x559F560", Offset = "0x559E160", VA = "0x18559F560", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0")]
	protected OMEJOMKMFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class CGKIMGNLKPC : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0")]
	protected CGKIMGNLKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class HKNPFPHAGAE : OMEJOMKMFOF
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x559D110", Offset = "0x559BD10", VA = "0x18559D110", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	protected void MEEILHODDPH(string LGEKLMLBGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0")]
	protected HKNPFPHAGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class FNDJBHPJGMO
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class DFCHDCPEGBM : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	protected DFCHDCPEGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[HFIGNCEGOKM(DDEOJCINOPG.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x55A0570", Offset = "0x559F170", VA = "0x1855A0570")]
		public static ComponentSystemGroup[] JMBFJGFNNEC(World AEEDEJIEEFL, OBHNLCCGOKP ACGGEGBIPEF = OBHNLCCGOKP.Default, bool FBJFHIJHKIG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x559F800", Offset = "0x559E400", VA = "0x18559F800")]
		private static Type[] ACHNPADHHAK(OBHNLCCGOKP ACGGEGBIPEF, bool FBJFHIJHKIG, ComponentSystemGroup[] HANEBAOGDEE, ComponentSystemGroup JLHMIIMFCGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x55A06A0", Offset = "0x559F2A0", VA = "0x1855A06A0")]
		private static ComponentSystemGroup[] PJAEEIIICAI(World AEEDEJIEEFL, out ComponentSystemGroup JLHMIIMFCGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x55A0160", Offset = "0x559ED60", VA = "0x1855A0160")]
		internal static bool EKLOKHEGPOP(KDONHBHPBNG MBNFLPKEEGH, out GGGPKHLAKHC AJIIMKIMPPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x55A0080", Offset = "0x559EC80", VA = "0x1855A0080")]
		private static ComponentSystemGroup CPGMGEOJNFE(Type BIEGICDMJCM, World AEEDEJIEEFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x55A0440", Offset = "0x559F040", VA = "0x1855A0440")]
		private static ComponentSystemGroup[] HDBDAIBPOID(Type[] BIPGMHLAMBH, World AEEDEJIEEFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x559FB60", Offset = "0x559E760", VA = "0x18559FB60")]
		internal static void BFHFMOPNGMP(World AEEDEJIEEFL, Type[] CGOLEKCKGPG, ComponentSystemGroup[] HANEBAOGDEE, ComponentSystemGroup JLHMIIMFCGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x55A03E0", Offset = "0x559EFE0", VA = "0x1855A03E0")]
		internal static bool ENMNIFBGKDF(ComponentSystemBase AKNBNHOMNEL, ComponentSystemGroup[] HANEBAOGDEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x55A0640", Offset = "0x559F240", VA = "0x1855A0640")]
		private static void KCGDGDEDAIO(ComponentSystemGroup[] HANEBAOGDEE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct EEGLGFOMNKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> MFFJPCBJMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> PCMOOAJDLNB;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x727A10", Offset = "0x726610", VA = "0x180727A10")]
	public EEGLGFOMNKL(Dictionary<Type, List<Type>> MFFJPCBJMMN, HashSet<Type> PCMOOAJDLNB)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[HFIGNCEGOKM(DDEOJCINOPG.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class FMHBDPPNKKO : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
			[DebuggerHidden]
			public FMHBDPPNKKO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x559CC10", Offset = "0x559B810", VA = "0x18559CC10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x559C970", Offset = "0x559B570", VA = "0x18559C970", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x559CCA0", Offset = "0x559B8A0", VA = "0x18559CCA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x559CBD0", Offset = "0x559B7D0", VA = "0x18559CBD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x559CB20", Offset = "0x559B720", VA = "0x18559CB20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x559CB20", Offset = "0x559B720", VA = "0x18559CB20", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct FJGLAFFPCDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type POMMGLAHLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private OBHNLCCGOKP ACGGEGBIPEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool ILHKKAAHALK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool AFOJAFPPJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool FBJFHIJHKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> APPJOFDKAIN;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x55A1170", Offset = "0x559FD70", VA = "0x1855A1170")]
		public static RRFilterWorldSystems GLBIKEOEKPG()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x55A1190", Offset = "0x559FD90", VA = "0x1855A1190")]
		public RRFilterWorldSystems HOACCKBHINF(OBHNLCCGOKP MBNFLPKEEGH)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x55A11A0", Offset = "0x559FDA0", VA = "0x1855A11A0")]
		public RRFilterWorldSystems KEMOFNFBGEH(IEnumerable<Type> BIPGMHLAMBH)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x55A11E0", Offset = "0x559FDE0", VA = "0x1855A11E0")]
		public RRFilterWorldSystems KJEELIEBEPP(bool JLNBEMIOFEA)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x55A1160", Offset = "0x559FD60", VA = "0x1855A1160")]
		public RRFilterWorldSystems FNNIDDCMAJM(bool EHBDCHOFCJH)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x55A0A40", Offset = "0x559F640", VA = "0x1855A0A40")]
		public EEGLGFOMNKL BFICFLICCPH(Type[] NFBOJGHEKDL)
		{
			return default(EEGLGFOMNKL);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x55A10D0", Offset = "0x559FCD0", VA = "0x1855A10D0")]
		[IteratorStateMachine(typeof(FMHBDPPNKKO))]
		internal IEnumerable<Type> FGGLNLLDNCO(IEnumerable<Type> BIPGMHLAMBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x55A0DF0", Offset = "0x559F9F0", VA = "0x1855A0DF0")]
		internal Dictionary<Type, List<Type>> DOKCHJFDCHF(IEnumerable<Type> BIPGMHLAMBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x55A11F0", Offset = "0x559FDF0", VA = "0x1855A11F0")]
		private void LLIEJKAHKOO(Dictionary<Type, List<Type>> KPOBDKLHLOL, Type BIEGICDMJCM, Type BJBFIKMJGLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x55A0AD0", Offset = "0x559F6D0", VA = "0x1855A0AD0")]
		internal HashSet<Type> DMEFCPPCJHP(IEnumerable<Type> HANEBAOGDEE, Dictionary<Type, List<Type>> FAEKHNNILJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x55A1300", Offset = "0x559FF00", VA = "0x1855A1300")]
		internal bool OGFAOKAPJPH(Type BIEGICDMJCM, OBHNLCCGOKP ACGGEGBIPEF, bool FBJFHIJHKIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x55A0C90", Offset = "0x559F890", VA = "0x1855A0C90")]
		[CompilerGenerated]
		internal static void DOEAHFNHPMH(Type BIEGICDMJCM, ref FJGLAFFPCDK P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class HFLJNGBIBBD
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool FFGIGHHBOHO;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x559CED0", Offset = "0x559BAD0", VA = "0x18559CED0")]
	public static void FNJOFAEFPIL(bool JOGFOOOHGFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x559CF30", Offset = "0x559BB30", VA = "0x18559CF30")]
	private static void GLHJDCPGHIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class PBJKIFDADND
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x559F660", Offset = "0x559E260", VA = "0x18559F660")]
	public static ulong NICPEJAPPJC(Type BIEGICDMJCM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x559F690", Offset = "0x559E290", VA = "0x18559F690")]
	public static ulong NICPEJAPPJC(string IIPKNLDBGNC)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[HFIGNCEGOKM(DDEOJCINOPG.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct HOLIIAFFLHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong BODDJCGKOMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong GNFKEFHAHHJ;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xF8DFC0", Offset = "0xF8CBC0", VA = "0x180F8DFC0")]
			public HOLIIAFFLHN(ulong BLLFFKBBPFB, ulong OOEBCNMELDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x559D140", Offset = "0x559BD40", VA = "0x18559D140", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> COPAMBHICFK;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static HOLIIAFFLHN[] ALLDBCGHIPM;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool FFGIGHHBOHO;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x55A26A0", Offset = "0x55A12A0", VA = "0x1855A26A0")]
		public static ulong LFOAHCDMBKG(int BGAEBMDLBPN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x55A1E30", Offset = "0x55A0A30", VA = "0x1855A1E30")]
		public static int DCEIJLLHFJL(ulong OOEBCNMELDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x55A21E0", Offset = "0x55A0DE0", VA = "0x1855A21E0")]
		public static void FNJOFAEFPIL(bool JOGFOOOHGFG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x55A2540", Offset = "0x55A1140", VA = "0x1855A2540")]
		private static void KGINJBBNEJN(int OCMCKMEKEFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x55A1A10", Offset = "0x55A0610", VA = "0x1855A1A10")]
		private static void AKFKKFAEPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x55A2460", Offset = "0x55A1060", VA = "0x1855A2460")]
		private static HOLIIAFFLHN HEELHDAMOOB(Type BIEGICDMJCM)
		{
			return default(HOLIIAFFLHN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x55A2630", Offset = "0x55A1230", VA = "0x1855A2630")]
		private static ulong LAFMPDFDEOP(Type BIEGICDMJCM, ulong OOEBCNMELDN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x55A1FC0", Offset = "0x55A0BC0", VA = "0x1855A1FC0")]
		private static void EAFOHJLJJAG(in HOLIIAFFLHN FKKHFCEDHBB, TypeManager.TypeInfo JKMGKLCPIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x55A1D30", Offset = "0x55A0930", VA = "0x1855A1D30")]
		private static void CNEAKHNCEBA(HOLIIAFFLHN JKMGKLCPIAL, int BGAEBMDLBPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x55A1EE0", Offset = "0x55A0AE0", VA = "0x1855A1EE0")]
		private static void DIPGAPBDILC(HOLIIAFFLHN JKMGKLCPIAL, int BGAEBMDLBPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x55A23D0", Offset = "0x55A0FD0", VA = "0x1855A23D0")]
		private static HOLIIAFFLHN GGAKDNHKNOB(int BGAEBMDLBPN)
		{
			return default(HOLIIAFFLHN);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x55A2620", Offset = "0x55A1220", VA = "0x1855A2620")]
		private static int KIBGEOMDAJD(int BGAEBMDLBPN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class JHJDEBMNIDH
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly FGOIFJIOAGM CGELOILHNNH;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly DELAFBDOMBH KANIMIHABDC;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly CDLEFDCPPPA DJOILKEHCKD;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> BKIGPLACHEM;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool FFGIGHHBOHO;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::MHPJAAHALLD<OCECHDCDPOJ> AHHBECMIPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x559D230", Offset = "0x559BE30", VA = "0x18559D230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::MHPJAAHALLD<EJMMDFNNNIA> OLBNDKKKOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x559D7C0", Offset = "0x559C3C0", VA = "0x18559D7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::MHPJAAHALLD<OCCCFKPBJLI> ONNIFKIDBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x559D1D0", Offset = "0x559BDD0", VA = "0x18559D1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x559D310", Offset = "0x559BF10", VA = "0x18559D310")]
	public static void FNJOFAEFPIL(bool JOGFOOOHGFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x559D290", Offset = "0x559BE90", VA = "0x18559D290")]
	public static Type[] FLHEONDAKAH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class CAICOPJFJIM
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> LKLFCJGOMNI;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool FFGIGHHBOHO;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x559B080", Offset = "0x5599C80", VA = "0x18559B080")]
	public static int LBGNMNJAEIO(int BGAEBMDLBPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x559ACE0", Offset = "0x55998E0", VA = "0x18559ACE0")]
	public static void FNJOFAEFPIL(bool JOGFOOOHGFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x559AE00", Offset = "0x5599A00", VA = "0x18559AE00")]
	private static void HHNEIDPOHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x559AC90", Offset = "0x5599890", VA = "0x18559AC90")]
	private static int EDHKLGHFEDB(Type BIEGICDMJCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x559AD80", Offset = "0x5599980", VA = "0x18559AD80")]
	private static void GJPIAAEOJAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class LGIKDIEECOD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World OJFIHOOFCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly DKCCOABIFKH PDOJIOEBHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] HANEBAOGDEE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World IAMBCCOEDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World HDBHOPCOJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager FAINNDBCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8E1660", Offset = "0x8E0260", VA = "0x1808E1660")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public DKCCOABIFKH NBPAAHMKIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::HAEGCKHPDHM<OCECHDCDPOJ> AHHBECMIPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E6E0", VA = "0x18070FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::HAEGCKHPDHM<EJMMDFNNNIA> OLBNDKKKOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67D170", VA = "0x18067E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x67E590", Offset = "0x67D190", VA = "0x18067E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::HAEGCKHPDHM<OCCCFKPBJLI> ONNIFKIDBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x67E580", Offset = "0x67D180", VA = "0x18067E580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x67E5A0", Offset = "0x67D1A0", VA = "0x18067E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> OIAHPJDJAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8E16A0", Offset = "0x8E02A0", VA = "0x1808E16A0")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] LHHFHLIHAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x559E3E0", Offset = "0x559CFE0", VA = "0x18559E3E0")]
	public static LGIKDIEECOD LBFMPBGOIDE(string NLCIGFDKGEE, KDONHBHPBNG MBNFLPKEEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x559E660", Offset = "0x559D260", VA = "0x18559E660")]
	public LGIKDIEECOD(string NLCIGFDKGEE, KDONHBHPBNG MBNFLPKEEGH = KDONHBHPBNG.Simulation, OBHNLCCGOKP ACGGEGBIPEF = OBHNLCCGOKP.Default, bool JOGFOOOHGFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x559DC20", Offset = "0x559C820", VA = "0x18559DC20")]
	public ComponentSystemBase ALGCINDKBID(Type BIEGICDMJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3D14B90", Offset = "0x3D13790", VA = "0x183D14B90")]
	public T ALGCINDKBID<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x559DFA0", Offset = "0x559CBA0", VA = "0x18559DFA0")]
	public void JJIKBIPKOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x559DDF0", Offset = "0x559C9F0", VA = "0x18559DDF0")]
	public void FMKCALOCKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x559E520", Offset = "0x559D120", VA = "0x18559E520")]
	public void NICMDJKJDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x559DD30", Offset = "0x559C930", VA = "0x18559DD30")]
	public void FKAJADCCPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x559DEE0", Offset = "0x559CAE0", VA = "0x18559DEE0")]
	public void ILAIJENEGLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x559E4C0", Offset = "0x559D0C0", VA = "0x18559E4C0")]
	public void LMOGINMCBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x559E460", Offset = "0x559D060", VA = "0x18559E460")]
	public void LJIHAJMHNLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x559DE50", Offset = "0x559CA50", VA = "0x18559DE50")]
	public void IBHIIPENBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x559DD90", Offset = "0x559C990", VA = "0x18559DD90")]
	public void FMADODOOLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x559DF40", Offset = "0x559CB40", VA = "0x18559DF40")]
	public void IOKGMGDICKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x559E580", Offset = "0x559D180", VA = "0x18559E580")]
	internal void PBLMKCALPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x559DC40", Offset = "0x559C840", VA = "0x18559DC40")]
	private bool BONJJOKKIAP(ComponentSystemGroup MKEBBFCGOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x559E000", Offset = "0x559CC00", VA = "0x18559E000")]
	private void JJOJBOHPKPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x559E2D0", Offset = "0x559CED0", VA = "0x18559E2D0")]
	private ComponentSystemGroup[] JMBFJGFNNEC(OBHNLCCGOKP ACGGEGBIPEF, bool FBJFHIJHKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x559DCC0", Offset = "0x559C8C0", VA = "0x18559DCC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum KDONHBHPBNG
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
public sealed class HGOHCMNHDHK : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public OBHNLCCGOKP IFAOFFAGEFH;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum OBHNLCCGOKP
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
public interface GGGPKHLAKHC
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type PKEJLOOOFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] FGIAFNBEECL
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class IHKIMLFICLN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool FEGBMKCAMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696C20", VA = "0x180698020", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	protected IHKIMLFICLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class OJNKOOMMBEP : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public OJNKOOMMBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class JKEIGPDDDOI : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public JKEIGPDDDOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class ICPFKLKOHFJ : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public ICPFKLKOHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class EABLAKNILLA : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public EABLAKNILLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class IIOOIELHEMK : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public IIOOIELHEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class FKHMAEJEEFI : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public FKHMAEJEEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class LCHFDMBMNHG : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public LCHFDMBMNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class CDMCEDHHDIO : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public CDMCEDHHDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class OKAEFGGFCLF : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public OKAEFGGFCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class JJFJNGHFJIF : ICGEPIMCNPB
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public JJFJNGHFJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class PPAGBHHMAFC : ICGEPIMCNPB
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public PPAGBHHMAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class LDEEMODDDLN : ICGEPIMCNPB
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public LDEEMODDDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class NDFCAEHCOAK : ICGEPIMCNPB
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public NDFCAEHCOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[GMHCLNCMPDG(JIJBLGHADKE.Application)]
public class ICGEPIMCNPB : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool FEGBMKCAMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679900", VA = "0x18067AD00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x559A980", Offset = "0x5599580", VA = "0x18559A980")]
	public ICGEPIMCNPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class LFLHCBGKOFK : NDNOEJBHMOK
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public LFLHCBGKOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class MAIBGEJHOLH
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void CPKFFGBHOHC<From, To>(From HOGBBBFDPKI, ref To DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class BGPLIFCHEMM<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static CPKFFGBHOHC<From, To> PEMPKPNNPHG;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public BGPLIFCHEMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x559EE20", Offset = "0x559DA20", VA = "0x18559EE20")]
	static MAIBGEJHOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2A11660", Offset = "0x2A10260", VA = "0x182A11660")]
	public static void IHNOGONHAHJ<T>(CPKFFGBHOHC<T, T> IBFMBEMGJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2A11460", Offset = "0x2A10060", VA = "0x182A11460")]
	public static void IHNOGONHAHJ<From, To>(CPKFFGBHOHC<From, To> IBFMBEMGJII, CPKFFGBHOHC<To, From> FNEEGPFEGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2A114F0", Offset = "0x2A100F0", VA = "0x182A114F0")]
	public static void IHNOGONHAHJ<From, To>(CPKFFGBHOHC<From, To> PEMPKPNNPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2A134E0", Offset = "0x2A120E0", VA = "0x182A134E0")]
	public static CPKFFGBHOHC<From, To> PNPMMJCPHAE<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E9C0", Offset = "0x2A0D5C0", VA = "0x182A0E9C0")]
	public static void HAPLAILGCII<From, To>(From HOGBBBFDPKI, ref To DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class IEAJMBBOLLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> IBJANACDNHC;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xDAA6B0", Offset = "0xDA92B0", VA = "0x180DAA6B0")]
	public IEAJMBBOLLL(NativeArray<EntityRemapUtility.EntityRemapInfo> IBJANACDNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C3D0", Offset = "0x2A7AFD0", VA = "0x182A7C3D0")]
	public Entity KLKFAAOLNDM(Entity GPNGGDGNOJH)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class AKMJGNDMNPP
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> EFBFGDODCEC;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x559A4E0", Offset = "0x55990E0", VA = "0x18559A4E0")]
	public static bool HAPMGLLAGFE(ulong IAIMPBMLKHB, uint OPAPEIICLLC, out string NLCIGFDKGEE)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[HFIGNCEGOKM(DDEOJCINOPG.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct AAFMGKFFIIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int OMNKALCAHCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int BDCBCEKMBAK;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x698050", Offset = "0x696C50", VA = "0x180698050")]
			public AAFMGKFFIIG(int BNNEENLPEFO, int OPAPEIICLLC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct LNLPDNGEMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch LGEMGNOLLDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long JFMAOBFPHPH;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long NJGAOAMDFJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x559ED50", Offset = "0x559D950", VA = "0x18559ED50")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long FKDHLEBMPGG
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x559EDB0", Offset = "0x559D9B0", VA = "0x18559EDB0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x559EC90", Offset = "0x559D890", VA = "0x18559EC90")]
			public static LNLPDNGEMFJ BELAGFODGPI()
			{
				return default(LNLPDNGEMFJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct DJELFGBEGPO : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct ENLBKMFEKDF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* MMEANJKLADF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly HJMEOFIKHJN.NFEAGMIABAL.MNCPFEBENIJ JPFFEDHIPHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly IEAJMBBOLLL MKCMLPCNJGL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::HAEGCKHPDHM<EJMMDFNNNIA> DKBHOLHDIDD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int GMFCANPCKKD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int EOMAOLLPGDL;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x559C8A0", Offset = "0x559B4A0", VA = "0x18559C8A0")]
				public unsafe ENLBKMFEKDF(Unity.Entities.Archetype* MMEANJKLADF, HJMEOFIKHJN.NFEAGMIABAL.MNCPFEBENIJ JPFFEDHIPHI, IEAJMBBOLLL MKCMLPCNJGL, global::HAEGCKHPDHM<EJMMDFNNNIA> DKBHOLHDIDD, int GMFCANPCKKD, int EOMAOLLPGDL = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x559C850", Offset = "0x559B450", VA = "0x18559C850")]
				public ENLBKMFEKDF(in ENLBKMFEKDF JLFCOOGLPMP, int EOMAOLLPGDL)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly ENLBKMFEKDF[] CKIGFGIEPDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] IMKLONMFFAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int FFHMIOLDLGK;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x559BDE0", Offset = "0x559A9E0", VA = "0x18559BDE0")]
			public DJELFGBEGPO(ENLBKMFEKDF[] CKIGFGIEPDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x559B9D0", Offset = "0x559A5D0", VA = "0x18559B9D0", Slot = "4")]
			public void Invoke(int BNNEENLPEFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x559BA30", Offset = "0x559A630", VA = "0x18559BA30")]
			private void JEKCHJEGFEE(in ENLBKMFEKDF JLFCOOGLPMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x559B700", Offset = "0x559A300", VA = "0x18559B700")]
			private static void GFHNEELOCKM(in ENLBKMFEKDF JLFCOOGLPMP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class DDJFIHDPLLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public HJMEOFIKHJN asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::HAEGCKHPDHM<EJMMDFNNNIA> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public DDJFIHDPLLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x559B610", Offset = "0x559A210", VA = "0x18559B610")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class FANCCAAONPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public HJMEOFIKHJN.NFEAGMIABAL.MNCPFEBENIJ srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public DDJFIHDPLLF CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public FANCCAAONPG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class LLFGHGBJDGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public FANCCAAONPG CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public LLFGHGBJDGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x559EB80", Offset = "0x559D780", VA = "0x18559EB80")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly FNIDFMEJGMB DFMIEEBHCKA;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly FNIDFMEJGMB DDIODLGJCPN;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly FNIDFMEJGMB KOJNLJNDPGE;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly FNIDFMEJGMB HEBMCLPJMBK;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool CBBACEHMENG;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static HJMEOFIKHJN.NFEAGMIABAL.DEECCBOLPML OEKCJGPMNPJ;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x55A2790", Offset = "0x55A1390", VA = "0x1855A2790")]
		private unsafe static bool ADHEOKMKFEE(Unity.Entities.Archetype* HNNIEOPALKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x55A3940", Offset = "0x55A2540", VA = "0x1855A3940")]
		internal unsafe static Unity.Entities.Archetype*[] GFBDOAEPFIH(ref Unity.Entities.EntityComponentStore FPJCOMGLIOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x55A4A30", Offset = "0x55A3630", VA = "0x1855A4A30")]
		public static void JNACBIDAHJJ(LGIKDIEECOD AEEDEJIEEFL, out ByteString MEFFDBODCGD, out NativeArray<EntityRemapUtility.EntityRemapInfo> KMPPIJKOEHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x55A3EC0", Offset = "0x55A2AC0", VA = "0x1855A3EC0")]
		internal static void HOBOJOGMJPF(LGIKDIEECOD AEEDEJIEEFL, HJMEOFIKHJN FLIKPDMCMEL, out NativeArray<EntityRemapUtility.EntityRemapInfo> KMPPIJKOEHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x55A36B0", Offset = "0x55A22B0", VA = "0x1855A36B0")]
		private unsafe static UnsafeHashMap<ulong, AAFMGKFFIIG> FPPJIIKFONO(Unity.Entities.Archetype*[] AOLNEEKKMEO)
		{
			return default(UnsafeHashMap<ulong, AAFMGKFFIIG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x55A2B10", Offset = "0x55A1710", VA = "0x1855A2B10")]
		private static void BELBCLAAPNH(HJMEOFIKHJN FLIKPDMCMEL, UnsafeHashMap<ulong, AAFMGKFFIIG> IJNPAFFDMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x55A3B20", Offset = "0x55A2720", VA = "0x1855A3B20")]
		private unsafe static void GGNCIEGFFHF(HJMEOFIKHJN FLIKPDMCMEL, Unity.Entities.Archetype*[] AOLNEEKKMEO, UnsafeHashMap<ulong, AAFMGKFFIIG> IJNPAFFDMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x55A3E50", Offset = "0x55A2A50", VA = "0x1855A3E50")]
		private unsafe static int GPPJMCGLEGA(Unity.Entities.Archetype*[] AOLNEEKKMEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x55A2CC0", Offset = "0x55A18C0", VA = "0x1855A2CC0")]
		private unsafe static void BPMDHKGNGDH(HJMEOFIKHJN FLIKPDMCMEL, Unity.Entities.Archetype*[] AOLNEEKKMEO, global::HAEGCKHPDHM<EJMMDFNNNIA> DKBHOLHDIDD, NativeArray<EntityRemapUtility.EntityRemapInfo> KMPPIJKOEHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x55A28A0", Offset = "0x55A14A0", VA = "0x1855A28A0")]
		private static NativeArray<int> AGAMFHNLAHE(HJMEOFIKHJN FLIKPDMCMEL)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x55A52B0", Offset = "0x55A3EB0", VA = "0x1855A52B0")]
		private static Memory<EntityArchetype> LFKHGICBGKB(HJMEOFIKHJN FLIKPDMCMEL, NativeArray<int> BIPGMHLAMBH, EntityManager CLLNDNAAIKP, out int KFONIPAILEK, out int HLKEEBOMDKL)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x55A5E20", Offset = "0x55A4A20", VA = "0x1855A5E20")]
		private unsafe static void LMDHEECHIBJ(Unity.Entities.Chunk* NEGIHJLBKMF, ReadOnlySpan<byte> MEFFDBODCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x55A56E0", Offset = "0x55A42E0", VA = "0x1855A56E0")]
		private static void LGBLHJIBNAB(HJMEOFIKHJN FLIKPDMCMEL, NativeArray<int> BIPGMHLAMBH, Span<EntityArchetype> AOLNEEKKMEO, EntityManager CLLNDNAAIKP, global::HAEGCKHPDHM<EJMMDFNNNIA> DKBHOLHDIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x55A6170", Offset = "0x55A4D70", VA = "0x1855A6170")]
		private unsafe static void NBPHMELEDBP(Unity.Entities.Chunk* CNILJNKKOIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x55A33A0", Offset = "0x55A1FA0", VA = "0x1855A33A0")]
		private unsafe static void FGDKHPPGIAI(HJMEOFIKHJN.NFEAGMIABAL.MNCPFEBENIJ MMEANJKLADF, int FOJMKMGJEFE, int NIMIDPOOIDC, Unity.Entities.Chunk* NEGIHJLBKMF, HJMEOFIKHJN FLIKPDMCMEL, NativeArray<int> BIPGMHLAMBH, global::HAEGCKHPDHM<EJMMDFNNNIA> DKBHOLHDIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x55A5140", Offset = "0x55A3D40", VA = "0x1855A5140")]
		public static void KDKFFIPLDGF(LGIKDIEECOD AEEDEJIEEFL, in ByteString MEFFDBODCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x55A4AF0", Offset = "0x55A36F0", VA = "0x1855A4AF0")]
		public static void KDKFFIPLDGF(EntityManager CLLNDNAAIKP, global::HAEGCKHPDHM<EJMMDFNNNIA> DKBHOLHDIDD, in ByteString MEFFDBODCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x55A30E0", Offset = "0x55A1CE0", VA = "0x1855A30E0")]
		private static bool EINIPKDELIL(Type BIEGICDMJCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x55A45F0", Offset = "0x55A31F0", VA = "0x1855A45F0")]
		private static void IDIMJJLJPJC(TypeManager.TypeInfo JKMGKLCPIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x55A48A0", Offset = "0x55A34A0", VA = "0x1855A48A0")]
		private unsafe static int IJLEFAIBCBB(Unity.Entities.Archetype*[] AOLNEEKKMEO, NativeArray<EntityRemapUtility.EntityRemapInfo> KMPPIJKOEHO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x55A51D0", Offset = "0x55A3DD0", VA = "0x1855A51D0")]
		private static int LBGNMNJAEIO(int BGAEBMDLBPN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x55A5640", Offset = "0x55A4240", VA = "0x1855A5640")]
		private static ulong LFOAHCDMBKG(int BGAEBMDLBPN)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class DMCKBMOAFHD
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x559C170", Offset = "0x559AD70", VA = "0x18559C170")]
	private unsafe static Span<byte> FGJLPFFDLEH(Unity.Entities.Chunk* CNILJNKKOIK, int GMFCANPCKKD)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2309780", Offset = "0x2308380", VA = "0x182309780")]
	public unsafe static Span<T> CLHBKKOCEDB<T>(Unity.Entities.Chunk* CNILJNKKOIK, int GMFCANPCKKD)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1AB64D0", Offset = "0x1AB50D0", VA = "0x181AB64D0")]
	public static Span<T> CLHBKKOCEDB<T>(this ref Unity.Entities.Chunk CNILJNKKOIK, int GMFCANPCKKD)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x559C5B0", Offset = "0x559B1B0", VA = "0x18559C5B0")]
	public unsafe static Span<Entity> IDKDLEDPEEL(Unity.Entities.Chunk* CNILJNKKOIK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x559C310", Offset = "0x559AF10", VA = "0x18559C310")]
	public unsafe static void GJPIAAEOJAL(Unity.Entities.Chunk* CNILJNKKOIK, int GMFCANPCKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x559C040", Offset = "0x559AC40", VA = "0x18559C040")]
	public static Entity DDEOKIBMLGB(this EntityQuery NJIBLOIMOJA)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : OJPIMOLMMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x55A6450", Offset = "0x55A5050", VA = "0x1855A6450", Slot = "4")]
		public sealed override void LHIOLPAIHGM()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class KEJBIFLOMJJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] POAMPPAGKIJ;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int DNBFJGDJLJG;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int JPELDCGMMIM;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger LIKOKONEDPL;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KEJBIFLOMJJ()
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
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

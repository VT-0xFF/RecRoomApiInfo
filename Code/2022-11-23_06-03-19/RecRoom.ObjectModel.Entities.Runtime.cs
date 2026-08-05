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
	[Cpp2IlInjected.Address(RVA = "0x5484F20", Offset = "0x5483D20", VA = "0x185484F20")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> KOBAAPOCEKF(this ref Unity.Entities.Archetype HNNIEOPALKC)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NIKPAGCHBMP
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5487260", Offset = "0x5486060", VA = "0x185487260")]
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
	[Cpp2IlInjected.Address(RVA = "0x54852D0", Offset = "0x54840D0", VA = "0x1854852D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x37889F0", Offset = "0x37877F0", VA = "0x1837889F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x32560D0", Offset = "0x3254ED0", VA = "0x1832560D0")]
	public static void GFEILCKAPIE<T>(this EntityManager CLLNDNAAIKP, NativeArray<Entity> FNMNPGEEPJI, T GKFICKKHACC) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3256610", Offset = "0x3255410", VA = "0x183256610")]
	public static void NLKAJGECPCE<T>(this EntityManager CLLNDNAAIKP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x32563F0", Offset = "0x32551F0", VA = "0x1832563F0")]
	public static void KPJDLJIHJMI<T>(this EntityManager CLLNDNAAIKP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3254F00", Offset = "0x3253D00", VA = "0x183254F00")]
	public static JobHandle BGDDHNIGPEB<T>(this EntityManager CLLNDNAAIKP) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5487750", Offset = "0x5486550", VA = "0x185487750")]
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
			[Cpp2IlInjected.Address(RVA = "0x6CF580", Offset = "0x6CE380", VA = "0x1806CF580", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3077AB0", Offset = "0x30768B0", VA = "0x183077AB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x24E8DB0", Offset = "0x24E7BB0", VA = "0x1824E8DB0")]
		[DebuggerHidden]
		public PENINHGKOBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x30778D0", Offset = "0x30766D0", VA = "0x1830778D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3077A70", Offset = "0x3076870", VA = "0x183077A70", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F190", Offset = "0x64DF90", VA = "0x18064F190")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2F23000", Offset = "0x2F21E00", VA = "0x182F23000")]
	private OIPJFPILMBJ(byte[] NFMJIELOGNG, Action<Protobuf> OKJHDDINGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x270F550", Offset = "0x270E350", VA = "0x18270F550")]
	public static global::OIPJFPILMBJ<Protobuf> GLBIKEOEKPG<Data>(ReadOnlySpan<byte> MEFFDBODCGD, ReadOnlySpan<Data> CKIGFGIEPDP, Action<Protobuf> OKJHDDINGCG)
	{
		return default(global::OIPJFPILMBJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2F22E70", Offset = "0x2F21C70", VA = "0x182F22E70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2F22EB0", Offset = "0x2F21CB0", VA = "0x182F22EB0", Slot = "4")]
	[IteratorStateMachine(typeof(global::OIPJFPILMBJ<>.PENINHGKOBO))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2F22FB0", Offset = "0x2F21DB0", VA = "0x182F22FB0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F229F0", Offset = "0x2F217F0", VA = "0x182F229F0")]
	private OIJLGNEDGDI(byte[] NFMJIELOGNG, in Protobuf JLOCDKLJJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x270C9E0", Offset = "0x270B7E0", VA = "0x18270C9E0")]
	public static global::OIJLGNEDGDI<Protobuf> GLBIKEOEKPG<T>(ReadOnlySpan<T> CKIGFGIEPDP)
	{
		return default(global::OIJLGNEDGDI<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2F229C0", Offset = "0x2F217C0", VA = "0x182F229C0")]
	public void POIJPBDECIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2F22930", Offset = "0x2F21730", VA = "0x182F22930")]
	public ByteString KMNNOBBLEPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2F22800", Offset = "0x2F21600", VA = "0x182F22800", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54847D0", Offset = "0x54835D0", VA = "0x1854847D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54848D0", Offset = "0x54836D0", VA = "0x1854848D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LCFDEDCDBML
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public static void FAPAIEBHNEJ(this FNIDFMEJGMB CBDAGBGGFJM, NativeArray<Entity> FNMNPGEEPJI, [Optional][CallerFilePath] string CGBPJHDDLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public static void FAPAIEBHNEJ(this FNIDFMEJGMB CBDAGBGGFJM, string NLCIGFDKGEE, NativeArray<Entity> FNMNPGEEPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public static void FAPAIEBHNEJ(this FNIDFMEJGMB CBDAGBGGFJM, string CGBPJHDDLMJ, NativeArray<Entity> FNMNPGEEPJI, bool DEKNKGENFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public static void MFNLAGNJBDI(this FNIDFMEJGMB CBDAGBGGFJM, NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> MCPLHLPJDOB, [Optional][CallerFilePath] string CGBPJHDDLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public static void MFNLAGNJBDI(this FNIDFMEJGMB CBDAGBGGFJM, string CGBPJHDDLMJ, NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> MCPLHLPJDOB, bool DEKNKGENFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2DD32E0", Offset = "0x2DD20E0", VA = "0x182DD32E0")]
	public static void IAANGBJNDCF<T>(this FNIDFMEJGMB CBDAGBGGFJM, string NLCIGFDKGEE, NativeArray<Entity> FNMNPGEEPJI, NativeList<T> JLFCOOGLPMP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3370", Offset = "0x2DD2170", VA = "0x182DD3370")]
	public static void IAANGBJNDCF<T>(this FNIDFMEJGMB CBDAGBGGFJM, string NLCIGFDKGEE, NativeArray<Entity> FNMNPGEEPJI, NativeArray<T> JLFCOOGLPMP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public static void IAANGBJNDCF<T>(this FNIDFMEJGMB CBDAGBGGFJM, string CGBPJHDDLMJ, NativeArray<Entity> FNMNPGEEPJI, NativeArray<T> JLFCOOGLPMP, bool DEKNKGENFOI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2DD33E0", Offset = "0x2DD21E0", VA = "0x182DD33E0")]
	public static void OFLHJLFCLGE<T>(this FNIDFMEJGMB CBDAGBGGFJM, NativeList<T> JLFCOOGLPMP, [Optional][CallerFilePath] string CGBPJHDDLMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2DD33B0", Offset = "0x2DD21B0", VA = "0x182DD33B0")]
	public static void OFLHJLFCLGE<T>(this FNIDFMEJGMB CBDAGBGGFJM, NativeArray<T> JLFCOOGLPMP, [Optional][CallerFilePath] string CGBPJHDDLMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public static void OFLHJLFCLGE<T>(this FNIDFMEJGMB CBDAGBGGFJM, string CGBPJHDDLMJ, NativeArray<T> JLFCOOGLPMP, bool DEKNKGENFOI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public static void KNKJJBNIBMB(this FNIDFMEJGMB CBDAGBGGFJM, EntityQuery NJIBLOIMOJA, [Optional][CallerFilePath] string CGBPJHDDLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public static void KNKJJBNIBMB(this FNIDFMEJGMB CBDAGBGGFJM, string NLCIGFDKGEE, EntityQuery NJIBLOIMOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public static void KNKJJBNIBMB(this FNIDFMEJGMB CBDAGBGGFJM, string CGBPJHDDLMJ, EntityQuery NJIBLOIMOJA, bool DEKNKGENFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2DD32B0", Offset = "0x2DD20B0", VA = "0x182DD32B0")]
	public static void GEABOHOPJAB<T, T2>(this FNIDFMEJGMB CBDAGBGGFJM, string NLCIGFDKGEE, EntityQuery NJIBLOIMOJA) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
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
			[Cpp2IlInjected.Address(RVA = "0x24F68D0", Offset = "0x24F56D0", VA = "0x1824F68D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28A5240", Offset = "0x28A4040", VA = "0x1828A5240")]
		public bool GFMJJCOKGLI(out TValue GKFICKKHACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28A5190", Offset = "0x28A3F90", VA = "0x1828A5190")]
		public void ELGBPIMHCCH(object JJFHDFJGCDG, TValue GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28A5110", Offset = "0x28A3F10", VA = "0x1828A5110")]
		public bool DOHHNJJEEIG(object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x28A5300", Offset = "0x28A4100", VA = "0x1828A5300")]
		public int NJHNFHMHPKP(object JJFHDFJGCDG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28A53B0", Offset = "0x28A41B0", VA = "0x1828A53B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x37281A0", Offset = "0x3726FA0", VA = "0x1837281A0")]
	public AFDHPHLDLGD(EntityManager CLLNDNAAIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3728080", Offset = "0x3726E80", VA = "0x183728080", Slot = "4")]
	public void PFBFCIOBDHE(Entity LLEBIIAHFDD, object JJFHDFJGCDG, TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3727E50", Offset = "0x3726C50", VA = "0x183727E50", Slot = "5")]
	public bool KCPCJNKGKEA(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3727BA0", Offset = "0x37269A0", VA = "0x183727BA0", Slot = "6")]
	public bool GFMJJCOKGLI(Entity LLEBIIAHFDD, out TValue GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3727B80", Offset = "0x3726980", VA = "0x183727B80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3727C70", Offset = "0x3726A70", VA = "0x183727C70")]
	private void GKFBMFONHHI(MBMCPEFFGLB KHEDNDCPGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3727DA0", Offset = "0x3726BA0", VA = "0x183727DA0")]
	private bool JLCNPKGMBFL(Entity LLEBIIAHFDD, out ECALDJBELBI DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3727D10", Offset = "0x3726B10", VA = "0x183727D10")]
	private void IJAHJFJKKAH(Entity LLEBIIAHFDD, ECALDJBELBI DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3727CF0", Offset = "0x3726AF0", VA = "0x183727CF0")]
	private bool GPFGLGBOMBI(ECALDJBELBI DKBLPJPHEMF, out MBMCPEFFGLB KHEDNDCPGJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3727FC0", Offset = "0x3726DC0", VA = "0x183727FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6945A0", Offset = "0x6933A0", VA = "0x1806945A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x695E20", Offset = "0x694C20", VA = "0x180695E20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CF8F0", Offset = "0x6CE6F0", VA = "0x1806CF8F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6CF900", Offset = "0x6CE700", VA = "0x1806CF900", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5484810", Offset = "0x5483610", VA = "0x185484810", Slot = "8")]
	public bool Equals(ECALDJBELBI MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5484860", Offset = "0x5483660", VA = "0x185484860", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3068150", Offset = "0x3066F50", VA = "0x183068150")]
	public PBJIHBFONCG(EntityManager CLLNDNAAIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3067A30", Offset = "0x3066830", VA = "0x183067A30", Slot = "4")]
	public bool PFBFCIOBDHE(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3066480", Offset = "0x3065280", VA = "0x183066480", Slot = "5")]
	public bool KCPCJNKGKEA(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3067190", Offset = "0x3065F90", VA = "0x183067190", Slot = "6")]
	public bool NEPGOCILDIE(Entity LLEBIIAHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x30672B0", Offset = "0x30660B0", VA = "0x1830672B0", Slot = "7")]
	public bool NEPGOCILDIE(ECALDJBELBI DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3065B00", Offset = "0x3064900", VA = "0x183065B00", Slot = "8")]
	public IEnumerable<object> IDEGJNBALHG(Entity LLEBIIAHFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x30657C0", Offset = "0x30645C0", VA = "0x1830657C0", Slot = "11")]
	public IEnumerable<object> IDEGJNBALHG(ECALDJBELBI DKBLPJPHEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x30670A0", Offset = "0x3065EA0", VA = "0x1830670A0", Slot = "9")]
	public bool MCILOEENMGD(Entity LLEBIIAHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3064E20", Offset = "0x3063C20", VA = "0x183064E20", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3065560", Offset = "0x3064360", VA = "0x183065560")]
	private void GKFBMFONHHI(HashSet<object> KHEDNDCPGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x30661F0", Offset = "0x3064FF0", VA = "0x1830661F0")]
	private bool JLCNPKGMBFL(Entity LLEBIIAHFDD, out ECALDJBELBI DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3064F60", Offset = "0x3063D60", VA = "0x183064F60")]
	private bool GIGPELMCPGK(Entity LLEBIIAHFDD, out ECALDJBELBI DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3065640", Offset = "0x3064440", VA = "0x183065640")]
	private void HIBCCIDMLNO(Entity LLEBIIAHFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3065D40", Offset = "0x3064B40", VA = "0x183065D40")]
	private void IJAHJFJKKAH(Entity LLEBIIAHFDD, ECALDJBELBI DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3067C30", Offset = "0x3066A30", VA = "0x183067C30")]
	private bool PHCEDLGLDDI(ECALDJBELBI DKBLPJPHEMF, out HashSet<object> KHEDNDCPGJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x30669C0", Offset = "0x30657C0", VA = "0x1830669C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x54838A0", Offset = "0x54826A0", VA = "0x1854838A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5485070", Offset = "0x5483E70", VA = "0x185485070", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54879C0", Offset = "0x54867C0", VA = "0x1854879C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xCADAB0", Offset = "0xCAC8B0", VA = "0x180CADAB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DE4050", Offset = "0x1DE2E50", VA = "0x181DE4050", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5487250", Offset = "0x5486050", VA = "0x185487250", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6507C0", Offset = "0x64F5C0", VA = "0x1806507C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5485080", Offset = "0x5483E80", VA = "0x185485080")]
	public HFCJGNDPFEG(Type IBNLPGGMLFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IAAENPILNCG : HFCJGNDPFEG
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5485080", Offset = "0x5483E80", VA = "0x185485080")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A2C0", Offset = "0x6590C0", VA = "0x18065A2C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5487200", Offset = "0x5486000", VA = "0x185487200")]
	public MBEPPANCEDB(Type FMAMPKHAHKF, Type IBNLPGGMLFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NIINPNOELJA : HFCJGNDPFEG
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5485080", Offset = "0x5483E80", VA = "0x185485080")]
	public NIINPNOELJA(Type IBNLPGGMLFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OPLAMEBGNBC : NDNOEJBHMOK
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6695E0", Offset = "0x6683E0", VA = "0x1806695E0")]
		[CompilerGenerated]
		get
		{
			return default(KDONHBHPBNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5483390", Offset = "0x5482190", VA = "0x185483390")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x54841A0", Offset = "0x5482FA0", VA = "0x1854841A0")]
	public DKCCOABIFKH(LGIKDIEECOD AEEDEJIEEFL, EntityManager CLLNDNAAIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x26E7900", Offset = "0x26E6700", VA = "0x1826E7900")]
	public bool JHEJAAPOGPF<T>(Entity LLEBIIAHFDD) where T : struct, EPPHGLODPLG
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x26E8140", Offset = "0x26E6F40", VA = "0x1826E8140")]
	public bool OPOAONJGMIP<T>(Entity LLEBIIAHFDD, out T GKFICKKHACC) where T : struct, EPPHGLODPLG
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x26E5F20", Offset = "0x26E4D20", VA = "0x1826E5F20")]
	public T CDJJENHCKHH<T>(Entity LLEBIIAHFDD) where T : struct, EPPHGLODPLG
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x26E7940", Offset = "0x26E6740", VA = "0x1826E7940")]
	private ComponentType MOHLCAGOCHK<T>() where T : struct, EPPHGLODPLG
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x54840D0", Offset = "0x5482ED0", VA = "0x1854840D0")]
	private ComponentType MOHLCAGOCHK(Type BIEGICDMJCM)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class OCCCFKPBJLI
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3147A30", Offset = "0x3146830", VA = "0x183147A30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type MKHGEGPAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3148860", Offset = "0x3147660", VA = "0x183148860", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int EKNNEAHLIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x31496D0", Offset = "0x31484D0", VA = "0x1831496D0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x31472A0", Offset = "0x31460A0", VA = "0x1831472A0")]
	public Data AMFGDDAKKBO(Entity LLEBIIAHFDD)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3149790", Offset = "0x3148590", VA = "0x183149790")]
	public Data PEKHMHDJKDI(Entity LLEBIIAHFDD)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View GOEPJIPGGGM(Entity LLEBIIAHFDD);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x38F3F50", Offset = "0x38F2D50", VA = "0x1838F3F50", Slot = "15")]
	protected internal override T GOEPJIPGGGM<T>(Entity LLEBIIAHFDD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x176B080", Offset = "0x1769E80", VA = "0x18176B080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1B0", Offset = "0x7BBFB0", VA = "0x1807BD1B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x96E3A0", Offset = "0x96D1A0", VA = "0x18096E3A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int DJLLCLMJFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5487390", Offset = "0x5486190", VA = "0x185487390", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private FPHEKKDEPIJ[] DMOFFHGCONI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x96E2D0", Offset = "0x96D0D0", VA = "0x18096E2D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual FPHEKKDEPIJ[] MDNKEJMDPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x54872D0", Offset = "0x54860D0", VA = "0x1854872D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ONDFHEECFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x54875B0", Offset = "0x54863B0", VA = "0x1854875B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5487400", Offset = "0x5486200", VA = "0x185487400")]
	public void FNJOFAEFPIL(EntityManager CLLNDNAAIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6949A0", Offset = "0x6937A0", VA = "0x1806949A0")]
	protected FIOMMIJIHBF NMLPNLGCKMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T GOEPJIPGGGM<T>(Entity LLEBIIAHFDD) where T : struct, EPPHGLODPLG;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x54875E0", Offset = "0x54863E0", VA = "0x1854875E0", Slot = "8")]
	public (uint, uint) LBGNMNJAEIO(Entity LLEBIIAHFDD)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5487520", Offset = "0x5486320", VA = "0x185487520", Slot = "9")]
	public bool IAAAGEFBFAH(Entity LLEBIIAHFDD, (uint order, uint change) OPAPEIICLLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF1110", Offset = "0x2CEFF10", VA = "0x182CF1110", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2852430", Offset = "0x2851230", VA = "0x182852430", Slot = "8")]
	protected virtual bool HNNCLEKANIL(ReadOnlySpan<Data> CKIGFGIEPDP, IEAJMBBOLLL MKCMLPCNJGL, out ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0", Slot = "9")]
	protected virtual bool NAJLBOJHHKN(int OPAPEIICLLC, Span<Data> CKIGFGIEPDP, in ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2CF11B0", Offset = "0x2CEFFB0", VA = "0x182CF11B0", Slot = "5")]
	internal sealed override bool HNNCLEKANIL(ref Unity.Entities.Chunk CNILJNKKOIK, int GMFCANPCKKD, IEAJMBBOLLL MKCMLPCNJGL, out ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1730", Offset = "0x2CF0530", VA = "0x182CF1730", Slot = "6")]
	internal sealed override bool NAJLBOJHHKN(int OPAPEIICLLC, ref Unity.Entities.Chunk CNILJNKKOIK, int GMFCANPCKKD, in ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D410", Offset = "0x2A6C210", VA = "0x182A6D410")]
	protected global::OIJLGNEDGDI<Protobuf> LEGDMAMLLGL<Protobuf>(ReadOnlySpan<Data> CKIGFGIEPDP) where Protobuf : IMessage, new()
	{
		return default(global::OIJLGNEDGDI<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D380", Offset = "0x2A6C180", VA = "0x182A6D380")]
	protected global::OIPJFPILMBJ<Protobuf> IACIFNKIMME<Protobuf>(ReadOnlySpan<byte> MEFFDBODCGD, ReadOnlySpan<Data> CKIGFGIEPDP, Action<Protobuf> OKJHDDINGCG) where Protobuf : IMessage, new()
	{
		return default(global::OIPJFPILMBJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x176B080", Offset = "0x1769E80", VA = "0x18176B080")]
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
	[Cpp2IlInjected.Address(RVA = "0x54848B0", Offset = "0x54836B0", VA = "0x1854848B0", Slot = "5")]
	internal virtual bool HNNCLEKANIL(ref Unity.Entities.Chunk CNILJNKKOIK, int GMFCANPCKKD, IEAJMBBOLLL MKCMLPCNJGL, out ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0", Slot = "6")]
	internal virtual bool NAJLBOJHHKN(int OPAPEIICLLC, ref Unity.Entities.Chunk CNILJNKKOIK, int GMFCANPCKKD, in ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x417DEB0", Offset = "0x417CCB0", VA = "0x18417DEB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3FDEE00", Offset = "0x3FDDC00", VA = "0x183FDEE00", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3977C30", Offset = "0x3976A30", VA = "0x183977C30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5482B10", Offset = "0x5481910", VA = "0x185482B10", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5482BA0", Offset = "0x54819A0", VA = "0x185482BA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x27278E0", Offset = "0x27266E0", VA = "0x1827278E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5484EA0", Offset = "0x5483CA0", VA = "0x185484EA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3375740", Offset = "0x3374540", VA = "0x183375740")]
	public static NativeList<T> MFGOCMIMPBN<T>(this NativeArray<T> CLNPFCHALHA, Allocator PBEDBDBGIPF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class HBGOHGCCOOH
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D89480", Offset = "0x2D88280", VA = "0x182D89480")]
	public static NativeArray<T> FCCBDJOKMLL<T>(this NativeList<Entity> CLNPFCHALHA, EntityManager CLLNDNAAIKP, Allocator PBEDBDBGIPF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2D89280", Offset = "0x2D88080", VA = "0x182D89280")]
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
	[Cpp2IlInjected.Address(RVA = "0x3B02970", Offset = "0x3B01770", VA = "0x183B02970")]
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
	[Cpp2IlInjected.Address(RVA = "0x5482C30", Offset = "0x5481A30", VA = "0x185482C30")]
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
	[Cpp2IlInjected.Address(RVA = "0x339A100", Offset = "0x3398F00", VA = "0x18339A100")]
	public FMIIPLHCIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3399FB0", Offset = "0x3398DB0", VA = "0x183399FB0", Slot = "4")]
	public bool KOOJGAMNGBI(int BGAEBMDLBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3399D00", Offset = "0x3398B00", VA = "0x183399D00", Slot = "5")]
	public global::HAEGCKHPDHM<BaseClass> KCMDPNOPODN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3399B70", Offset = "0x3398970", VA = "0x183399B70", Slot = "7")]
	protected virtual bool FKOGFIBLFKN(Type BIEGICDMJCM, int GNBFKPMADPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3399C70", Offset = "0x3398A70", VA = "0x183399C70", Slot = "8")]
	protected virtual int IFFCFGJMNDO(Type BIEGICDMJCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x339A010", Offset = "0x3398E10", VA = "0x18339A010")]
	public void LHIOLPAIHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3399AD0", Offset = "0x33988D0", VA = "0x183399AD0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x381F5D0", Offset = "0x381E3D0", VA = "0x18381F5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x381F860", Offset = "0x381E660", VA = "0x18381F860")]
	public HAEGCKHPDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x381F9F0", Offset = "0x381E7F0", VA = "0x18381F9F0")]
	public HAEGCKHPDHM(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x381F4B0", Offset = "0x381E2B0", VA = "0x18381F4B0")]
	internal void ELGBPIMHCCH(int BGAEBMDLBPN, BaseClass PDOJIOEBHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A3B0", Offset = "0x2A691B0", VA = "0x182A6A3B0")]
	public bool ILGMKKODINB<T>(out BaseClass GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x381F530", Offset = "0x381E330", VA = "0x18381F530")]
	public bool ILGMKKODINB(Type JIOJHELJNAL, out BaseClass GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x381F800", Offset = "0x381E600", VA = "0x18381F800")]
	public bool LDPEMCOHOGJ(int BGAEBMDLBPN, out BaseClass GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B0C0", Offset = "0x2A69EC0", VA = "0x182A6B0C0")]
	public T LJFLFMHKEAF<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x381F830", Offset = "0x381E630", VA = "0x18381F830")]
	public BaseClass LJFLFMHKEAF(Type NHOJABADPMK)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class CDLEFDCPPPA : global::FMIIPLHCIMP<IAAENPILNCG, OCCCFKPBJLI>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5483320", Offset = "0x5482120", VA = "0x185483320")]
	public CDLEFDCPPPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FGOIFJIOAGM : global::FMIIPLHCIMP<MBEPPANCEDB, OCECHDCDPOJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5484AB0", Offset = "0x54838B0", VA = "0x185484AB0")]
	public FGOIFJIOAGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class DELAFBDOMBH : global::FMIIPLHCIMP<NIINPNOELJA, EJMMDFNNNIA>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5483830", Offset = "0x5482630", VA = "0x185483830")]
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
		[Cpp2IlInjected.Address(RVA = "0x6507B0", Offset = "0x64F5B0", VA = "0x1806507B0")]
		private ComponentSystemTypes(List<Type> BIPGMHLAMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x54834A0", Offset = "0x54822A0", VA = "0x1854834A0")]
		public static void LHIOLPAIHGM(List<Type> BIPGMHLAMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5483530", Offset = "0x5482330", VA = "0x185483530")]
		private void OPLGDBFECPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x54833C0", Offset = "0x54821C0", VA = "0x1854833C0")]
		private bool FKOGFIBLFKN(Type BIEGICDMJCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5483440", Offset = "0x5482240", VA = "0x185483440")]
		private void HDNDDCAGELI(Type BIEGICDMJCM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class PHGAEFHEOPI : BHBEGOLDLHM
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5487980", Offset = "0x5486780", VA = "0x185487980", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase HHLKDNFBDIA();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5487930", Offset = "0x5486730", VA = "0x185487930")]
	protected ComponentSystemBase DKJJICFOLAL(params ComponentSystemBase[] PCMOOAJDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFB00", Offset = "0x2DAE900", VA = "0x182DAFB00")]
	protected ComponentSystemBase DKJJICFOLAL<T>(params ComponentSystemBase[] PCMOOAJDLNB) where T : BHBEGOLDLHM, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFBA0", Offset = "0x2DAE9A0", VA = "0x182DAFBA0")]
	protected ComponentSystemBase NNPIPEJDLDL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFBA0", Offset = "0x2DAE9A0", VA = "0x182DAFBA0")]
	protected ComponentSystemBase JDKFFGGPOFG<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	protected PHGAEFHEOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5482850", Offset = "0x5481650", VA = "0x185482850", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public BHBEGOLDLHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class OMEJOMKMFOF : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x54876A0", Offset = "0x54864A0", VA = "0x1854876A0")]
	public LFHLPPKAALB GFFPKOPEJBK(int BGAEBMDLBPN, bool PHLJIIECGMC = false)
	{
		return default(LFHLPPKAALB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5487740", Offset = "0x5486540", VA = "0x185487740", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0")]
	protected OMEJOMKMFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class CGKIMGNLKPC : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0")]
	protected CGKIMGNLKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class HKNPFPHAGAE : OMEJOMKMFOF
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x54852F0", Offset = "0x54840F0", VA = "0x1854852F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	protected void MEEILHODDPH(string LGEKLMLBGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0")]
	protected HKNPFPHAGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	protected DFCHDCPEGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5488750", Offset = "0x5487550", VA = "0x185488750")]
		public static ComponentSystemGroup[] JMBFJGFNNEC(World AEEDEJIEEFL, OBHNLCCGOKP ACGGEGBIPEF = OBHNLCCGOKP.Default, bool FBJFHIJHKIG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x54879E0", Offset = "0x54867E0", VA = "0x1854879E0")]
		private static Type[] ACHNPADHHAK(OBHNLCCGOKP ACGGEGBIPEF, bool FBJFHIJHKIG, ComponentSystemGroup[] HANEBAOGDEE, ComponentSystemGroup JLHMIIMFCGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5488880", Offset = "0x5487680", VA = "0x185488880")]
		private static ComponentSystemGroup[] PJAEEIIICAI(World AEEDEJIEEFL, out ComponentSystemGroup JLHMIIMFCGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5488340", Offset = "0x5487140", VA = "0x185488340")]
		internal static bool EKLOKHEGPOP(KDONHBHPBNG MBNFLPKEEGH, out GGGPKHLAKHC AJIIMKIMPPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5488260", Offset = "0x5487060", VA = "0x185488260")]
		private static ComponentSystemGroup CPGMGEOJNFE(Type BIEGICDMJCM, World AEEDEJIEEFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5488620", Offset = "0x5487420", VA = "0x185488620")]
		private static ComponentSystemGroup[] HDBDAIBPOID(Type[] BIPGMHLAMBH, World AEEDEJIEEFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5487D40", Offset = "0x5486B40", VA = "0x185487D40")]
		internal static void BFHFMOPNGMP(World AEEDEJIEEFL, Type[] CGOLEKCKGPG, ComponentSystemGroup[] HANEBAOGDEE, ComponentSystemGroup JLHMIIMFCGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x54885C0", Offset = "0x54873C0", VA = "0x1854885C0")]
		internal static bool ENMNIFBGKDF(ComponentSystemBase AKNBNHOMNEL, ComponentSystemGroup[] HANEBAOGDEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5488820", Offset = "0x5487620", VA = "0x185488820")]
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
	[Cpp2IlInjected.Address(RVA = "0x84CA20", Offset = "0x84B820", VA = "0x18084CA20")]
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
				[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
			[DebuggerHidden]
			public FMHBDPPNKKO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5484DC0", Offset = "0x5483BC0", VA = "0x185484DC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5484B20", Offset = "0x5483920", VA = "0x185484B20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5484E50", Offset = "0x5483C50", VA = "0x185484E50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5484D80", Offset = "0x5483B80", VA = "0x185484D80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5484CD0", Offset = "0x5483AD0", VA = "0x185484CD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5484CD0", Offset = "0x5483AD0", VA = "0x185484CD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5489350", Offset = "0x5488150", VA = "0x185489350")]
		public static RRFilterWorldSystems GLBIKEOEKPG()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5489370", Offset = "0x5488170", VA = "0x185489370")]
		public RRFilterWorldSystems HOACCKBHINF(OBHNLCCGOKP MBNFLPKEEGH)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5489380", Offset = "0x5488180", VA = "0x185489380")]
		public RRFilterWorldSystems KEMOFNFBGEH(IEnumerable<Type> BIPGMHLAMBH)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x54893C0", Offset = "0x54881C0", VA = "0x1854893C0")]
		public RRFilterWorldSystems KJEELIEBEPP(bool JLNBEMIOFEA)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5489340", Offset = "0x5488140", VA = "0x185489340")]
		public RRFilterWorldSystems FNNIDDCMAJM(bool EHBDCHOFCJH)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5488C20", Offset = "0x5487A20", VA = "0x185488C20")]
		public EEGLGFOMNKL BFICFLICCPH(Type[] NFBOJGHEKDL)
		{
			return default(EEGLGFOMNKL);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x54892B0", Offset = "0x54880B0", VA = "0x1854892B0")]
		[IteratorStateMachine(typeof(FMHBDPPNKKO))]
		internal IEnumerable<Type> FGGLNLLDNCO(IEnumerable<Type> BIPGMHLAMBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5488FD0", Offset = "0x5487DD0", VA = "0x185488FD0")]
		internal Dictionary<Type, List<Type>> DOKCHJFDCHF(IEnumerable<Type> BIPGMHLAMBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x54893D0", Offset = "0x54881D0", VA = "0x1854893D0")]
		private void LLIEJKAHKOO(Dictionary<Type, List<Type>> KPOBDKLHLOL, Type BIEGICDMJCM, Type BJBFIKMJGLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5488CB0", Offset = "0x5487AB0", VA = "0x185488CB0")]
		internal HashSet<Type> DMEFCPPCJHP(IEnumerable<Type> HANEBAOGDEE, Dictionary<Type, List<Type>> FAEKHNNILJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x54894E0", Offset = "0x54882E0", VA = "0x1854894E0")]
		internal bool OGFAOKAPJPH(Type BIEGICDMJCM, OBHNLCCGOKP ACGGEGBIPEF, bool FBJFHIJHKIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5488E70", Offset = "0x5487C70", VA = "0x185488E70")]
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
	[Cpp2IlInjected.Address(RVA = "0x54850B0", Offset = "0x5483EB0", VA = "0x1854850B0")]
	public static void FNJOFAEFPIL(bool JOGFOOOHGFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5485110", Offset = "0x5483F10", VA = "0x185485110")]
	private static void GLHJDCPGHIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class PBJKIFDADND
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5487840", Offset = "0x5486640", VA = "0x185487840")]
	public static ulong NICPEJAPPJC(Type BIEGICDMJCM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5487870", Offset = "0x5486670", VA = "0x185487870")]
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
			[Cpp2IlInjected.Address(RVA = "0x895690", Offset = "0x894490", VA = "0x180895690")]
			public HOLIIAFFLHN(ulong BLLFFKBBPFB, ulong OOEBCNMELDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5485320", Offset = "0x5484120", VA = "0x185485320", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x548A880", Offset = "0x5489680", VA = "0x18548A880")]
		public static ulong LFOAHCDMBKG(int BGAEBMDLBPN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x548A010", Offset = "0x5488E10", VA = "0x18548A010")]
		public static int DCEIJLLHFJL(ulong OOEBCNMELDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x548A3C0", Offset = "0x54891C0", VA = "0x18548A3C0")]
		public static void FNJOFAEFPIL(bool JOGFOOOHGFG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x548A720", Offset = "0x5489520", VA = "0x18548A720")]
		private static void KGINJBBNEJN(int OCMCKMEKEFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5489BF0", Offset = "0x54889F0", VA = "0x185489BF0")]
		private static void AKFKKFAEPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x548A640", Offset = "0x5489440", VA = "0x18548A640")]
		private static HOLIIAFFLHN HEELHDAMOOB(Type BIEGICDMJCM)
		{
			return default(HOLIIAFFLHN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x548A810", Offset = "0x5489610", VA = "0x18548A810")]
		private static ulong LAFMPDFDEOP(Type BIEGICDMJCM, ulong OOEBCNMELDN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x548A1A0", Offset = "0x5488FA0", VA = "0x18548A1A0")]
		private static void EAFOHJLJJAG(in HOLIIAFFLHN FKKHFCEDHBB, TypeManager.TypeInfo JKMGKLCPIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5489F10", Offset = "0x5488D10", VA = "0x185489F10")]
		private static void CNEAKHNCEBA(HOLIIAFFLHN JKMGKLCPIAL, int BGAEBMDLBPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x548A0C0", Offset = "0x5488EC0", VA = "0x18548A0C0")]
		private static void DIPGAPBDILC(HOLIIAFFLHN JKMGKLCPIAL, int BGAEBMDLBPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x548A5B0", Offset = "0x54893B0", VA = "0x18548A5B0")]
		private static HOLIIAFFLHN GGAKDNHKNOB(int BGAEBMDLBPN)
		{
			return default(HOLIIAFFLHN);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x548A800", Offset = "0x5489600", VA = "0x18548A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x5485410", Offset = "0x5484210", VA = "0x185485410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::MHPJAAHALLD<EJMMDFNNNIA> OLBNDKKKOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x54859A0", Offset = "0x54847A0", VA = "0x1854859A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::MHPJAAHALLD<OCCCFKPBJLI> ONNIFKIDBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x54853B0", Offset = "0x54841B0", VA = "0x1854853B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x54854F0", Offset = "0x54842F0", VA = "0x1854854F0")]
	public static void FNJOFAEFPIL(bool JOGFOOOHGFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5485470", Offset = "0x5484270", VA = "0x185485470")]
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
	[Cpp2IlInjected.Address(RVA = "0x5483200", Offset = "0x5482000", VA = "0x185483200")]
	public static int LBGNMNJAEIO(int BGAEBMDLBPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5482E60", Offset = "0x5481C60", VA = "0x185482E60")]
	public static void FNJOFAEFPIL(bool JOGFOOOHGFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5482F80", Offset = "0x5481D80", VA = "0x185482F80")]
	private static void HHNEIDPOHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5482E10", Offset = "0x5481C10", VA = "0x185482E10")]
	private static int EDHKLGHFEDB(Type BIEGICDMJCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5482F00", Offset = "0x5481D00", VA = "0x185482F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World HDBHOPCOJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager FAINNDBCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xB83DD0", Offset = "0xB82BD0", VA = "0x180B83DD0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public DKCCOABIFKH NBPAAHMKIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::HAEGCKHPDHM<OCECHDCDPOJ> AHHBECMIPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6C19B0", Offset = "0x6C07B0", VA = "0x1806C19B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::HAEGCKHPDHM<EJMMDFNNNIA> OLBNDKKKOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x64F720", Offset = "0x64E520", VA = "0x18064F720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6500E0", Offset = "0x64EEE0", VA = "0x1806500E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::HAEGCKHPDHM<OCCCFKPBJLI> ONNIFKIDBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x652A00", Offset = "0x651800", VA = "0x180652A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x652C90", Offset = "0x651A90", VA = "0x180652C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> OIAHPJDJAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xB83E10", Offset = "0xB82C10", VA = "0x180B83E10")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] LHHFHLIHAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x54865C0", Offset = "0x54853C0", VA = "0x1854865C0")]
	public static LGIKDIEECOD LBFMPBGOIDE(string NLCIGFDKGEE, KDONHBHPBNG MBNFLPKEEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5486840", Offset = "0x5485640", VA = "0x185486840")]
	public LGIKDIEECOD(string NLCIGFDKGEE, KDONHBHPBNG MBNFLPKEEGH = KDONHBHPBNG.Simulation, OBHNLCCGOKP ACGGEGBIPEF = OBHNLCCGOKP.Default, bool JOGFOOOHGFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5485E00", Offset = "0x5484C00", VA = "0x185485E00")]
	public ComponentSystemBase ALGCINDKBID(Type BIEGICDMJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2DD35A0", Offset = "0x2DD23A0", VA = "0x182DD35A0")]
	public T ALGCINDKBID<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5486180", Offset = "0x5484F80", VA = "0x185486180")]
	public void JJIKBIPKOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5485FD0", Offset = "0x5484DD0", VA = "0x185485FD0")]
	public void FMKCALOCKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5486700", Offset = "0x5485500", VA = "0x185486700")]
	public void NICMDJKJDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5485F10", Offset = "0x5484D10", VA = "0x185485F10")]
	public void FKAJADCCPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x54860C0", Offset = "0x5484EC0", VA = "0x1854860C0")]
	public void ILAIJENEGLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x54866A0", Offset = "0x54854A0", VA = "0x1854866A0")]
	public void LMOGINMCBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5486640", Offset = "0x5485440", VA = "0x185486640")]
	public void LJIHAJMHNLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5486030", Offset = "0x5484E30", VA = "0x185486030")]
	public void IBHIIPENBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5485F70", Offset = "0x5484D70", VA = "0x185485F70")]
	public void FMADODOOLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5486120", Offset = "0x5484F20", VA = "0x185486120")]
	public void IOKGMGDICKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5486760", Offset = "0x5485560", VA = "0x185486760")]
	internal void PBLMKCALPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5485E20", Offset = "0x5484C20", VA = "0x185485E20")]
	private bool BONJJOKKIAP(ComponentSystemGroup MKEBBFCGOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x54861E0", Offset = "0x5484FE0", VA = "0x1854861E0")]
	private void JJOJBOHPKPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x54864B0", Offset = "0x54852B0", VA = "0x1854864B0")]
	private ComponentSystemGroup[] JMBFJGFNNEC(OBHNLCCGOKP ACGGEGBIPEF, bool FBJFHIJHKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5485EA0", Offset = "0x5484CA0", VA = "0x185485EA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x668120", Offset = "0x666F20", VA = "0x180668120", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	protected IHKIMLFICLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class OJNKOOMMBEP : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public OJNKOOMMBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class JKEIGPDDDOI : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public JKEIGPDDDOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class ICPFKLKOHFJ : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public ICPFKLKOHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class EABLAKNILLA : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public EABLAKNILLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class IIOOIELHEMK : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public IIOOIELHEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class FKHMAEJEEFI : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public FKHMAEJEEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class LCHFDMBMNHG : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public LCHFDMBMNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class CDMCEDHHDIO : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public CDMCEDHHDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class OKAEFGGFCLF : IHKIMLFICLN
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public OKAEFGGFCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class JJFJNGHFJIF : ICGEPIMCNPB
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public JJFJNGHFJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class PPAGBHHMAFC : ICGEPIMCNPB
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public PPAGBHHMAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class LDEEMODDDLN : ICGEPIMCNPB
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public LDEEMODDDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class NDFCAEHCOAK : ICGEPIMCNPB
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public NDFCAEHCOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5482B00", Offset = "0x5481900", VA = "0x185482B00")]
	public ICGEPIMCNPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class LFLHCBGKOFK : NDNOEJBHMOK
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public BGPLIFCHEMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5487000", Offset = "0x5485E00", VA = "0x185487000")]
	static MAIBGEJHOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2B2ACF0", Offset = "0x2B29AF0", VA = "0x182B2ACF0")]
	public static void IHNOGONHAHJ<T>(CPKFFGBHOHC<T, T> IBFMBEMGJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2B2AAF0", Offset = "0x2B298F0", VA = "0x182B2AAF0")]
	public static void IHNOGONHAHJ<From, To>(CPKFFGBHOHC<From, To> IBFMBEMGJII, CPKFFGBHOHC<To, From> FNEEGPFEGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2B2AB80", Offset = "0x2B29980", VA = "0x182B2AB80")]
	public static void IHNOGONHAHJ<From, To>(CPKFFGBHOHC<From, To> PEMPKPNNPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CB70", Offset = "0x2B2B970", VA = "0x182B2CB70")]
	public static CPKFFGBHOHC<From, To> PNPMMJCPHAE<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2B28050", Offset = "0x2B26E50", VA = "0x182B28050")]
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
	[Cpp2IlInjected.Address(RVA = "0x122AF60", Offset = "0x1229D60", VA = "0x18122AF60")]
	public IEAJMBBOLLL(NativeArray<EntityRemapUtility.EntityRemapInfo> IBJANACDNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x301A950", Offset = "0x3019750", VA = "0x18301A950")]
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
	[Cpp2IlInjected.Address(RVA = "0x5482660", Offset = "0x5481460", VA = "0x185482660")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BD570", Offset = "0x6BC370", VA = "0x1806BD570")]
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
				[Cpp2IlInjected.Address(RVA = "0x5486F30", Offset = "0x5485D30", VA = "0x185486F30")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long FKDHLEBMPGG
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x5486F90", Offset = "0x5485D90", VA = "0x185486F90")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5486E70", Offset = "0x5485C70", VA = "0x185486E70")]
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
				[Cpp2IlInjected.Address(RVA = "0x5484A50", Offset = "0x5483850", VA = "0x185484A50")]
				public unsafe ENLBKMFEKDF(Unity.Entities.Archetype* MMEANJKLADF, HJMEOFIKHJN.NFEAGMIABAL.MNCPFEBENIJ JPFFEDHIPHI, IEAJMBBOLLL MKCMLPCNJGL, global::HAEGCKHPDHM<EJMMDFNNNIA> DKBHOLHDIDD, int GMFCANPCKKD, int EOMAOLLPGDL = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x5484A00", Offset = "0x5483800", VA = "0x185484A00")]
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
			[Cpp2IlInjected.Address(RVA = "0x5483F90", Offset = "0x5482D90", VA = "0x185483F90")]
			public DJELFGBEGPO(ENLBKMFEKDF[] CKIGFGIEPDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5483B80", Offset = "0x5482980", VA = "0x185483B80", Slot = "4")]
			public void Invoke(int BNNEENLPEFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5483BE0", Offset = "0x54829E0", VA = "0x185483BE0")]
			private void JEKCHJEGFEE(in ENLBKMFEKDF JLFCOOGLPMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x54838B0", Offset = "0x54826B0", VA = "0x1854838B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public DDJFIHDPLLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x54837C0", Offset = "0x54825C0", VA = "0x1854837C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public LLFGHGBJDGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5486D60", Offset = "0x5485B60", VA = "0x185486D60")]
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
		[Cpp2IlInjected.Address(RVA = "0x548A970", Offset = "0x5489770", VA = "0x18548A970")]
		private unsafe static bool ADHEOKMKFEE(Unity.Entities.Archetype* HNNIEOPALKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x548BB20", Offset = "0x548A920", VA = "0x18548BB20")]
		internal unsafe static Unity.Entities.Archetype*[] GFBDOAEPFIH(ref Unity.Entities.EntityComponentStore FPJCOMGLIOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x548CC10", Offset = "0x548BA10", VA = "0x18548CC10")]
		public static void JNACBIDAHJJ(LGIKDIEECOD AEEDEJIEEFL, out ByteString MEFFDBODCGD, out NativeArray<EntityRemapUtility.EntityRemapInfo> KMPPIJKOEHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x548C0A0", Offset = "0x548AEA0", VA = "0x18548C0A0")]
		internal static void HOBOJOGMJPF(LGIKDIEECOD AEEDEJIEEFL, HJMEOFIKHJN FLIKPDMCMEL, out NativeArray<EntityRemapUtility.EntityRemapInfo> KMPPIJKOEHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x548B890", Offset = "0x548A690", VA = "0x18548B890")]
		private unsafe static UnsafeHashMap<ulong, AAFMGKFFIIG> FPPJIIKFONO(Unity.Entities.Archetype*[] AOLNEEKKMEO)
		{
			return default(UnsafeHashMap<ulong, AAFMGKFFIIG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x548ACF0", Offset = "0x5489AF0", VA = "0x18548ACF0")]
		private static void BELBCLAAPNH(HJMEOFIKHJN FLIKPDMCMEL, UnsafeHashMap<ulong, AAFMGKFFIIG> IJNPAFFDMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x548BD00", Offset = "0x548AB00", VA = "0x18548BD00")]
		private unsafe static void GGNCIEGFFHF(HJMEOFIKHJN FLIKPDMCMEL, Unity.Entities.Archetype*[] AOLNEEKKMEO, UnsafeHashMap<ulong, AAFMGKFFIIG> IJNPAFFDMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x548C030", Offset = "0x548AE30", VA = "0x18548C030")]
		private unsafe static int GPPJMCGLEGA(Unity.Entities.Archetype*[] AOLNEEKKMEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x548AEA0", Offset = "0x5489CA0", VA = "0x18548AEA0")]
		private unsafe static void BPMDHKGNGDH(HJMEOFIKHJN FLIKPDMCMEL, Unity.Entities.Archetype*[] AOLNEEKKMEO, global::HAEGCKHPDHM<EJMMDFNNNIA> DKBHOLHDIDD, NativeArray<EntityRemapUtility.EntityRemapInfo> KMPPIJKOEHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x548AA80", Offset = "0x5489880", VA = "0x18548AA80")]
		private static NativeArray<int> AGAMFHNLAHE(HJMEOFIKHJN FLIKPDMCMEL)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x548D490", Offset = "0x548C290", VA = "0x18548D490")]
		private static Memory<EntityArchetype> LFKHGICBGKB(HJMEOFIKHJN FLIKPDMCMEL, NativeArray<int> BIPGMHLAMBH, EntityManager CLLNDNAAIKP, out int KFONIPAILEK, out int HLKEEBOMDKL)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x548E000", Offset = "0x548CE00", VA = "0x18548E000")]
		private unsafe static void LMDHEECHIBJ(Unity.Entities.Chunk* NEGIHJLBKMF, ReadOnlySpan<byte> MEFFDBODCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x548D8C0", Offset = "0x548C6C0", VA = "0x18548D8C0")]
		private static void LGBLHJIBNAB(HJMEOFIKHJN FLIKPDMCMEL, NativeArray<int> BIPGMHLAMBH, Span<EntityArchetype> AOLNEEKKMEO, EntityManager CLLNDNAAIKP, global::HAEGCKHPDHM<EJMMDFNNNIA> DKBHOLHDIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x548E350", Offset = "0x548D150", VA = "0x18548E350")]
		private unsafe static void NBPHMELEDBP(Unity.Entities.Chunk* CNILJNKKOIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x548B580", Offset = "0x548A380", VA = "0x18548B580")]
		private unsafe static void FGDKHPPGIAI(HJMEOFIKHJN.NFEAGMIABAL.MNCPFEBENIJ MMEANJKLADF, int FOJMKMGJEFE, int NIMIDPOOIDC, Unity.Entities.Chunk* NEGIHJLBKMF, HJMEOFIKHJN FLIKPDMCMEL, NativeArray<int> BIPGMHLAMBH, global::HAEGCKHPDHM<EJMMDFNNNIA> DKBHOLHDIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x548D320", Offset = "0x548C120", VA = "0x18548D320")]
		public static void KDKFFIPLDGF(LGIKDIEECOD AEEDEJIEEFL, in ByteString MEFFDBODCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x548CCD0", Offset = "0x548BAD0", VA = "0x18548CCD0")]
		public static void KDKFFIPLDGF(EntityManager CLLNDNAAIKP, global::HAEGCKHPDHM<EJMMDFNNNIA> DKBHOLHDIDD, in ByteString MEFFDBODCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x548B2C0", Offset = "0x548A0C0", VA = "0x18548B2C0")]
		private static bool EINIPKDELIL(Type BIEGICDMJCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x548C7D0", Offset = "0x548B5D0", VA = "0x18548C7D0")]
		private static void IDIMJJLJPJC(TypeManager.TypeInfo JKMGKLCPIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x548CA80", Offset = "0x548B880", VA = "0x18548CA80")]
		private unsafe static int IJLEFAIBCBB(Unity.Entities.Archetype*[] AOLNEEKKMEO, NativeArray<EntityRemapUtility.EntityRemapInfo> KMPPIJKOEHO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x548D3B0", Offset = "0x548C1B0", VA = "0x18548D3B0")]
		private static int LBGNMNJAEIO(int BGAEBMDLBPN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x548D820", Offset = "0x548C620", VA = "0x18548D820")]
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
	[Cpp2IlInjected.Address(RVA = "0x5484320", Offset = "0x5483120", VA = "0x185484320")]
	private unsafe static Span<byte> FGJLPFFDLEH(Unity.Entities.Chunk* CNILJNKKOIK, int GMFCANPCKKD)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x26E89D0", Offset = "0x26E77D0", VA = "0x1826E89D0")]
	public unsafe static Span<T> CLHBKKOCEDB<T>(Unity.Entities.Chunk* CNILJNKKOIK, int GMFCANPCKKD)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x26E8B50", Offset = "0x26E7950", VA = "0x1826E8B50")]
	public static Span<T> CLHBKKOCEDB<T>(this ref Unity.Entities.Chunk CNILJNKKOIK, int GMFCANPCKKD)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5484760", Offset = "0x5483560", VA = "0x185484760")]
	public unsafe static Span<Entity> IDKDLEDPEEL(Unity.Entities.Chunk* CNILJNKKOIK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x54844C0", Offset = "0x54832C0", VA = "0x1854844C0")]
	public unsafe static void GJPIAAEOJAL(Unity.Entities.Chunk* CNILJNKKOIK, int GMFCANPCKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x54841F0", Offset = "0x5482FF0", VA = "0x1854841F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x548E630", Offset = "0x548D430", VA = "0x18548E630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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

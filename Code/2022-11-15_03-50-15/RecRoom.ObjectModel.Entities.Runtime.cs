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
internal static class NADBFLPOFJP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x538A960", Offset = "0x5389360", VA = "0x18538A960")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> MAIOKMGJPOO(this ref Unity.Entities.Archetype FHJHFHLOJMH)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OBLDFINGANB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x538AAB0", Offset = "0x53894B0", VA = "0x18538AAB0")]
	public static Span<int> EMOOCPHPPLB(this EntityArchetype FHJHFHLOJMH)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PAEMOMBEAKE
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HDFMDFIBENP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5388B50", Offset = "0x5387550", VA = "0x185388B50")]
	public static bool CHKFJDOKALL(this Entity EBOGCLNNJGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class AJCCJKMIDCO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[BurstCompile]
	private struct GDIFDIIAIBL<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[ReadOnly]
		public NativeArray<Entity> OAILNMMPLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[WriteOnly]
		public ComponentDataFromEntity<T> IGKMLAGHNAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public T NKJMIDIDBOE;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3AE0", Offset = "0x1CB24E0", VA = "0x181CB3AE0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[BurstCompile]
	private struct CLIGEJEDOOH<T> : IJobChunk where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[WriteOnly]
		public ArchetypeChunkComponentType<T> KGMFNAFMKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T NKJMIDIDBOE;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1700240", Offset = "0x16FEC40", VA = "0x181700240")]
	public static void EKMGCGMJNJA<T>(this EntityManager KACBFFMHDCF, NativeArray<Entity> GBNPHFOKMOH, T NKJMIDIDBOE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x16FFFC0", Offset = "0x16FE9C0", VA = "0x1816FFFC0")]
	public static void BBHGCBFNJDC<T>(this EntityManager KACBFFMHDCF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1701120", Offset = "0x16FFB20", VA = "0x181701120")]
	public static void LCINOOBAELH<T>(this EntityManager KACBFFMHDCF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x17013C0", Offset = "0x16FFDC0", VA = "0x1817013C0")]
	public static JobHandle PBDEMIDKHIJ<T>(this EntityManager KACBFFMHDCF) where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5387280", Offset = "0x5385C80", VA = "0x185387280")]
	public static JobHandle PBDEMIDKHIJ(this EntityManager KACBFFMHDCF, int FEFFHDFABJK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FCFPFJCMDHD<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BDPOKBJBACJ : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::FCFPFJCMDHD<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x909700", Offset = "0x908100", VA = "0x180909700", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x25B4160", Offset = "0x25B2B60", VA = "0x1825B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x162AC10", Offset = "0x1629610", VA = "0x18162AC10")]
		[DebuggerHidden]
		public BDPOKBJBACJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x25B3F80", Offset = "0x25B2980", VA = "0x1825B3F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x25B4120", Offset = "0x25B2B20", VA = "0x1825B4120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> AFGIMEDDBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream PLHINEOBEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream IJGMAPNDCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf BDIDCJGAGGJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int PAKKNJKLENP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E5670", Offset = "0x6E4070", VA = "0x1806E5670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1B58A20", Offset = "0x1B57420", VA = "0x181B58A20")]
	private FCFPFJCMDHD(byte[] MFPFCCDPGDI, Action<Protobuf> AFGIMEDDBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x17A6ED0", Offset = "0x17A58D0", VA = "0x1817A6ED0")]
	public static global::FCFPFJCMDHD<Protobuf> BJHKCBAGIGH<Data>(ReadOnlySpan<byte> IBDMDMLOLOO, ReadOnlySpan<Data> BKLDDIKBPBA, Action<Protobuf> AFGIMEDDBCL)
	{
		return default(global::FCFPFJCMDHD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1B58890", Offset = "0x1B57290", VA = "0x181B58890", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1B588D0", Offset = "0x1B572D0", VA = "0x181B588D0", Slot = "4")]
	[IteratorStateMachine(typeof(global::FCFPFJCMDHD<>.BDPOKBJBACJ))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1B589D0", Offset = "0x1B573D0", VA = "0x181B589D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ELPFGPCKDHN<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly byte[] MFPFCCDPGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Protobuf BDIDCJGAGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MemoryStream PLHINEOBEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CodedOutputStream KOPEELIFOGI;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2C32AD0", Offset = "0x2C314D0", VA = "0x182C32AD0")]
	private ELPFGPCKDHN(byte[] MFPFCCDPGDI, in Protobuf BDIDCJGAGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x17A3CE0", Offset = "0x17A26E0", VA = "0x1817A3CE0")]
	public static global::ELPFGPCKDHN<Protobuf> BJHKCBAGIGH<T>(ReadOnlySpan<T> BKLDDIKBPBA)
	{
		return default(global::ELPFGPCKDHN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2C32AA0", Offset = "0x2C314A0", VA = "0x182C32AA0")]
	public void OMDGLFMKBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2C328E0", Offset = "0x2C312E0", VA = "0x182C328E0")]
	public ByteString BDMNJDFOPDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C32970", Offset = "0x2C31370", VA = "0x182C32970", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct KHPNMODNGEN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream PLHINEOBEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedInputStream IJGMAPNDCCG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5389450", Offset = "0x5387E50", VA = "0x185389450", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IPFJNJPIOBC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] MFPFCCDPGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MemoryStream PLHINEOBEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CodedOutputStream KOPEELIFOGI;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5388FF0", Offset = "0x53879F0", VA = "0x185388FF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FCKIFOAAEAC
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public static void NIMDCODBFEJ(this LOOGELFKPLM ENHDLHMFJLO, NativeArray<Entity> GBNPHFOKMOH, [Optional][CallerFilePath] string GGNPABAAIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public static void NIMDCODBFEJ(this LOOGELFKPLM ENHDLHMFJLO, string KKJOOAJGLJI, NativeArray<Entity> GBNPHFOKMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public static void NIMDCODBFEJ(this LOOGELFKPLM ENHDLHMFJLO, string GGNPABAAIOA, NativeArray<Entity> GBNPHFOKMOH, bool DOFNLMHADCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public static void ADANNPDKKHG(this LOOGELFKPLM ENHDLHMFJLO, NativeArray<Entity> GBNPHFOKMOH, NativeArray<Entity> MBAGNKEDBGA, [Optional][CallerFilePath] string GGNPABAAIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public static void ADANNPDKKHG(this LOOGELFKPLM ENHDLHMFJLO, string GGNPABAAIOA, NativeArray<Entity> GBNPHFOKMOH, NativeArray<Entity> MBAGNKEDBGA, bool DOFNLMHADCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1AA7F50", Offset = "0x1AA6950", VA = "0x181AA7F50")]
	public static void IGEFBKKAKGA<T>(this LOOGELFKPLM ENHDLHMFJLO, string KKJOOAJGLJI, NativeArray<Entity> GBNPHFOKMOH, NativeList<T> PJIINDGLAPJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1AA7FE0", Offset = "0x1AA69E0", VA = "0x181AA7FE0")]
	public static void IGEFBKKAKGA<T>(this LOOGELFKPLM ENHDLHMFJLO, string KKJOOAJGLJI, NativeArray<Entity> GBNPHFOKMOH, NativeArray<T> PJIINDGLAPJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public static void IGEFBKKAKGA<T>(this LOOGELFKPLM ENHDLHMFJLO, string GGNPABAAIOA, NativeArray<Entity> GBNPHFOKMOH, NativeArray<T> PJIINDGLAPJ, bool DOFNLMHADCL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1AA8050", Offset = "0x1AA6A50", VA = "0x181AA8050")]
	public static void KOPFPMFOKNO<T>(this LOOGELFKPLM ENHDLHMFJLO, NativeList<T> PJIINDGLAPJ, [Optional][CallerFilePath] string GGNPABAAIOA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1AA8020", Offset = "0x1AA6A20", VA = "0x181AA8020")]
	public static void KOPFPMFOKNO<T>(this LOOGELFKPLM ENHDLHMFJLO, NativeArray<T> PJIINDGLAPJ, [Optional][CallerFilePath] string GGNPABAAIOA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public static void KOPFPMFOKNO<T>(this LOOGELFKPLM ENHDLHMFJLO, string GGNPABAAIOA, NativeArray<T> PJIINDGLAPJ, bool DOFNLMHADCL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public static void ADMLGIKMPCL(this LOOGELFKPLM ENHDLHMFJLO, EntityQuery NBKDJEEFFOH, [Optional][CallerFilePath] string GGNPABAAIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public static void ADMLGIKMPCL(this LOOGELFKPLM ENHDLHMFJLO, string KKJOOAJGLJI, EntityQuery NBKDJEEFFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public static void ADMLGIKMPCL(this LOOGELFKPLM ENHDLHMFJLO, string GGNPABAAIOA, EntityQuery NBKDJEEFFOH, bool DOFNLMHADCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1AA7F20", Offset = "0x1AA6920", VA = "0x181AA7F20")]
	public static void GKEMHFMIPOK<T, T2>(this LOOGELFKPLM ENHDLHMFJLO, string KKJOOAJGLJI, EntityQuery NBKDJEEFFOH) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	private static void GKEMHFMIPOK<T, T2>(this LOOGELFKPLM ENHDLHMFJLO, string GGNPABAAIOA, EntityQuery NBKDJEEFFOH, bool DOFNLMHADCL) where T : struct, IComponentData where T2 : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HPFKDEBDLEN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KCHDKMDKNCF AHFGFNJIHNJ
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
public interface KDHOHGHKHIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FICDADENOHM(Entity EBOGCLNNJGN, object KBCPLDFOJJL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GHOKPEAPJAI(Entity EBOGCLNNJGN, object KBCPLDFOJJL);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JOCENPKCKJP(Entity EBOGCLNNJGN);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JOCENPKCKJP(KCHDKMDKNCF LGNELGFKAEP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<object> DAALACJBLIK(Entity EBOGCLNNJGN);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NIBGGDLOAFK(Entity EBOGCLNNJGN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NNAHOGIEPBH<TComponentData, TValue> : global::PGMCMCFAJCB<TValue>, IDisposable where TComponentData : struct, HPFKDEBDLEN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class BDKLPEPJAJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<(object token, TValue value)> AMMGMIDPNEP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int OABDNEKKKBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1638810", Offset = "0x1637210", VA = "0x181638810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x25B33B0", Offset = "0x25B1DB0", VA = "0x1825B33B0")]
		public bool PFKIDMFMLNI(out TValue NKJMIDIDBOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x25B3280", Offset = "0x25B1C80", VA = "0x1825B3280")]
		public void MJIKPLNABDE(object KBCPLDFOJJL, TValue NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x25B3330", Offset = "0x25B1D30", VA = "0x1825B3330")]
		public bool OMBMHDCIFDM(object KBCPLDFOJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x25B31D0", Offset = "0x25B1BD0", VA = "0x1825B31D0")]
		public int FAPJKNPKKHA(object KBCPLDFOJJL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x25B3470", Offset = "0x25B1E70", VA = "0x1825B3470")]
		public BDKLPEPJAJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Stack<BDKLPEPJAJO> OIDNECGADAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::ABDMDAMINJC<KCHDKMDKNCF, BDKLPEPJAJO> JFGBPGPDBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityManager KACBFFMHDCF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x32D6140", Offset = "0x32D4B40", VA = "0x1832D6140")]
	public NNAHOGIEPBH(EntityManager KACBFFMHDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x32D5B40", Offset = "0x32D4540", VA = "0x1832D5B40", Slot = "4")]
	public void FICDADENOHM(Entity EBOGCLNNJGN, object KBCPLDFOJJL, TValue NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x32D5C60", Offset = "0x32D4660", VA = "0x1832D5C60", Slot = "5")]
	public bool GHOKPEAPJAI(Entity EBOGCLNNJGN, object KBCPLDFOJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x32D6070", Offset = "0x32D4A70", VA = "0x1832D6070", Slot = "6")]
	public bool PFKIDMFMLNI(Entity EBOGCLNNJGN, out TValue NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x32D5B20", Offset = "0x32D4520", VA = "0x1832D5B20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x32D5DF0", Offset = "0x32D47F0", VA = "0x1832D5DF0")]
	private void IBLHJKEPPJH(BDKLPEPJAJO JBBLOPJNDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x32D5F30", Offset = "0x32D4930", VA = "0x1832D5F30")]
	private bool KDFDBPNEFHI(Entity EBOGCLNNJGN, out KCHDKMDKNCF LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x32D5FE0", Offset = "0x32D49E0", VA = "0x1832D5FE0")]
	private void NEGDOFBPILB(Entity EBOGCLNNJGN, KCHDKMDKNCF LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x32D5DD0", Offset = "0x32D47D0", VA = "0x1832D5DD0")]
	private bool HLHJAFPKCLD(KCHDKMDKNCF LGNELGFKAEP, out BDKLPEPJAJO JBBLOPJNDAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x32D5E70", Offset = "0x32D4870", VA = "0x1832D5E70")]
	private BDKLPEPJAJO JGPICDOABAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PGMCMCFAJCB<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FICDADENOHM(Entity EBOGCLNNJGN, object KBCPLDFOJJL, TValue NKJMIDIDBOE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GHOKPEAPJAI(Entity EBOGCLNNJGN, object KBCPLDFOJJL);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PFKIDMFMLNI(Entity EBOGCLNNJGN, out TValue NKJMIDIDBOE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KCHDKMDKNCF : global::MDCCNADMIFA<KCHDKMDKNCF>, AMGKOAKLCKE, IEquatable<KCHDKMDKNCF>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly KCHDKMDKNCF CIDEMGIPOEP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CreateProperty]
	public int HMIPEGLEEME
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7608C0", Offset = "0x75F2C0", VA = "0x1807608C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x760940", Offset = "0x75F340", VA = "0x180760940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[CreateProperty]
	public int MIEMBAEOINL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x18486F0", Offset = "0x18470F0", VA = "0x1818486F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1848730", Offset = "0x1847130", VA = "0x181848730", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5389320", Offset = "0x5387D20", VA = "0x185389320", Slot = "8")]
	public bool Equals(KCHDKMDKNCF BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5389370", Offset = "0x5387D70", VA = "0x185389370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JLLCOHPACPA<T> : KDHOHGHKHIH, IDisposable where T : struct, HPFKDEBDLEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stack<HashSet<object>> OIDNECGADAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private global::ABDMDAMINJC<KCHDKMDKNCF, HashSet<object>> JFGBPGPDBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EntityManager KACBFFMHDCF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0B90", Offset = "0x2D9F590", VA = "0x182DA0B90")]
	public JLLCOHPACPA(EntityManager KACBFFMHDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E780", Offset = "0x2D9D180", VA = "0x182D9E780", Slot = "4")]
	public bool FICDADENOHM(Entity EBOGCLNNJGN, object KBCPLDFOJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2D9ECB0", Offset = "0x2D9D6B0", VA = "0x182D9ECB0", Slot = "5")]
	public bool GHOKPEAPJAI(Entity EBOGCLNNJGN, object KBCPLDFOJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F7E0", Offset = "0x2D9E1E0", VA = "0x182D9F7E0", Slot = "6")]
	public bool JOCENPKCKJP(Entity EBOGCLNNJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F900", Offset = "0x2D9E300", VA = "0x182D9F900", Slot = "7")]
	public bool JOCENPKCKJP(KCHDKMDKNCF LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2D9DA60", Offset = "0x2D9C460", VA = "0x182D9DA60", Slot = "8")]
	public IEnumerable<object> DAALACJBLIK(Entity EBOGCLNNJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E000", Offset = "0x2D9CA00", VA = "0x182D9E000", Slot = "11")]
	public IEnumerable<object> DAALACJBLIK(KCHDKMDKNCF LGNELGFKAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2DA04E0", Offset = "0x2D9EEE0", VA = "0x182DA04E0", Slot = "9")]
	public bool NIBGGDLOAFK(Entity EBOGCLNNJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E1C0", Offset = "0x2D9CBC0", VA = "0x182D9E1C0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F230", Offset = "0x2D9DC30", VA = "0x182D9F230")]
	private void IBLHJKEPPJH(HashSet<object> JBBLOPJNDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2D9FAE0", Offset = "0x2D9E4E0", VA = "0x182D9FAE0")]
	private bool KDFDBPNEFHI(Entity EBOGCLNNJGN, out KCHDKMDKNCF LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0120", Offset = "0x2D9EB20", VA = "0x182DA0120")]
	private bool NECCPKODMEH(Entity EBOGCLNNJGN, out KCHDKMDKNCF LGNELGFKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2D9EF50", Offset = "0x2D9D950", VA = "0x182D9EF50")]
	private void GJCBHOEMDAP(Entity EBOGCLNNJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2DA02A0", Offset = "0x2D9ECA0", VA = "0x182DA02A0")]
	private void NEGDOFBPILB(Entity EBOGCLNNJGN, KCHDKMDKNCF LGNELGFKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F090", Offset = "0x2D9DA90", VA = "0x182D9F090")]
	private bool GNGLJAFANJO(KCHDKMDKNCF LGNELGFKAEP, out HashSet<object> JBBLOPJNDAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F380", Offset = "0x2D9DD80", VA = "0x182D9F380")]
	private HashSet<object> JGPICDOABAF()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KALCGCMFFNG : global::MIFFJKLLBME<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5389120", Offset = "0x5387B20", VA = "0x185389120", Slot = "4")]
	public float GPCLMJCDOGA(float3 NKJMIDIDBOE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EHILMOAKKPG : global::MIFFJKLLBME<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5388670", Offset = "0x5387070", VA = "0x185388670", Slot = "4")]
	public float GPCLMJCDOGA(float3 NKJMIDIDBOE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CAGGICDLPKI : global::MIFFJKLLBME<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x53876E0", Offset = "0x53860E0", VA = "0x1853876E0", Slot = "4")]
	public float GPCLMJCDOGA(float3 NKJMIDIDBOE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct OFHHDJJNAJG : global::MIFFJKLLBME<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x991E10", Offset = "0x990810", VA = "0x180991E10", Slot = "4")]
	public int GPCLMJCDOGA(int3 NKJMIDIDBOE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MBMIAIOBLGD : global::MIFFJKLLBME<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xAA7A30", Offset = "0xAA6430", VA = "0x180AA7A30", Slot = "4")]
	public int GPCLMJCDOGA(int3 NKJMIDIDBOE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct HBFPGENOACB : global::MIFFJKLLBME<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5388B40", Offset = "0x5387540", VA = "0x185388B40", Slot = "4")]
	public int GPCLMJCDOGA(int3 NKJMIDIDBOE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class NLELAHOPGEC : MMHNEAAGHNG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type PIOFDBDJBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EA0", Offset = "0x6A38A0", VA = "0x1806A4EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5388B70", Offset = "0x5387570", VA = "0x185388B70")]
	public NLELAHOPGEC(Type IOCCOEIFPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KKLLFLCMAAC : NLELAHOPGEC
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5388B70", Offset = "0x5387570", VA = "0x185388B70")]
	public KKLLFLCMAAC(Type IOCCOEIFPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CLBBEHGLPDF : NLELAHOPGEC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Type EFGGLKOMEIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A4ED0", Offset = "0x6A38D0", VA = "0x1806A4ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5387FB0", Offset = "0x53869B0", VA = "0x185387FB0")]
	public CLBBEHGLPDF(Type NFBDINJIDIE, Type IOCCOEIFPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HJICCHMFEGP : NLELAHOPGEC
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5388B70", Offset = "0x5387570", VA = "0x185388B70")]
	public HJICCHMFEGP(Type IOCCOEIFPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EAKKFOPCDBA : MMHNEAAGHNG
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public EAKKFOPCDBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PDPPFJNHPKG : MMHNEAAGHNG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IAIEFIFAMIP OIEPILPNECC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6983B0", Offset = "0x696DB0", VA = "0x1806983B0")]
		[CompilerGenerated]
		get
		{
			return default(IAIEFIFAMIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x538C5D0", Offset = "0x538AFD0", VA = "0x18538C5D0")]
	public PDPPFJNHPKG(IAIEFIFAMIP ALIOHCFALJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
public class AMGOMELBDKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly OLNILFAFOLN MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EntityManager KACBFFMHDCF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OLNILFAFOLN DLPKPCDMEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5387440", Offset = "0x5385E40", VA = "0x185387440")]
	public AMGOMELBDKB(OLNILFAFOLN MKBCEHAIJKD, EntityManager KACBFFMHDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x17071F0", Offset = "0x1705BF0", VA = "0x1817071F0")]
	public bool AHJEGCBNAEI<T>(Entity EBOGCLNNJGN) where T : struct, BOHNNLBFCIM
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1707A30", Offset = "0x1706430", VA = "0x181707A30")]
	public bool IOBKGPCBKHC<T>(Entity EBOGCLNNJGN, out T NKJMIDIDBOE) where T : struct, BOHNNLBFCIM
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1707AC0", Offset = "0x17064C0", VA = "0x181707AC0")]
	public T NPNDEENLHIA<T>(Entity EBOGCLNNJGN) where T : struct, BOHNNLBFCIM
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1707230", Offset = "0x1705C30", VA = "0x181707230")]
	private ComponentType ICMJFBOEJOF<T>() where T : struct, BOHNNLBFCIM
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5387370", Offset = "0x5385D70", VA = "0x185387370")]
	private ComponentType ICMJFBOEJOF(Type NFMPIOLJBMO)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class LKCPANANAIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	protected LKCPANANAIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class ABFJGGLNJIB<View, Data> : HNAPDCCEHDA where View : struct, BOHNNLBFCIM where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ComponentType JCDONMNPLEJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override Type BPOPDMMPJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2E58A60", Offset = "0x2E57460", VA = "0x182E58A60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override Type NNAKGLPPLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2E57670", Offset = "0x2E56070", VA = "0x182E57670", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int FNJDKODBHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2E592C0", Offset = "0x2E57CC0", VA = "0x182E592C0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2E59250", Offset = "0x2E57C50", VA = "0x182E59250")]
	public Data HAFADDKNDDA(Entity EBOGCLNNJGN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2E591E0", Offset = "0x2E57BE0", VA = "0x182E591E0")]
	public Data GEODPHHPFFA(Entity EBOGCLNNJGN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View MPGOJDKNNAD(Entity EBOGCLNNJGN);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x441A800", Offset = "0x4419200", VA = "0x18441A800", Slot = "15")]
	protected internal override T MPGOJDKNNAD<T>(Entity EBOGCLNNJGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7CF650", Offset = "0x7CE050", VA = "0x1807CF650")]
	protected ABFJGGLNJIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class HNAPDCCEHDA : LJFKOBFLBJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ArchetypeChunkComponentTypeDynamic PJJLINMBBFC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EntityManager AJHOIKIBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xCD56A0", Offset = "0xCD40A0", VA = "0x180CD56A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public abstract Type BPOPDMMPJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public abstract Type NNAKGLPPLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public abstract int FNJDKODBHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Type GMOCFNNFKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x11A99B0", Offset = "0x11A83B0", VA = "0x1811A99B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private int CJIIDIMNIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5388BA0", Offset = "0x53875A0", VA = "0x185388BA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private FKCOPGJECPA[] EKPHGELHHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xF4A2B0", Offset = "0xF48CB0", VA = "0x180F4A2B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected internal virtual FKCOPGJECPA[] IBHNLBOOKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5388C10", Offset = "0x5387610", VA = "0x185388C10", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EIAAKDOIAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5388E80", Offset = "0x5387880", VA = "0x185388E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5388CD0", Offset = "0x53876D0", VA = "0x185388CD0")]
	public void GICNDCMAEJH(EntityManager KACBFFMHDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450")]
	protected LJFKOBFLBJG NGJOFMDGKGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T MPGOJDKNNAD<T>(Entity EBOGCLNNJGN) where T : struct, BOHNNLBFCIM;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5388EB0", Offset = "0x53878B0", VA = "0x185388EB0", Slot = "8")]
	public (uint, uint) PNAFBPICGGL(Entity EBOGCLNNJGN)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5388DF0", Offset = "0x53877F0", VA = "0x185388DF0", Slot = "9")]
	public bool MMDDDBHAGIN(Entity EBOGCLNNJGN, (uint order, uint change) FDLOHCDDBIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	protected HNAPDCCEHDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class BCIEJIFJLKK<Data> : MHOPCPJOHOK where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public virtual Data MHJMHHILEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x25B1500", Offset = "0x25AFF00", VA = "0x1825B1500", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x19FE790", Offset = "0x19FD190", VA = "0x1819FE790", Slot = "8")]
	protected virtual bool NJMFGBJKOHH(ReadOnlySpan<Data> BKLDDIKBPBA, EHDEHNCFGLN HLNMPCAECGF, out ReadOnlySpan<byte> IBDMDMLOLOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720", Slot = "9")]
	protected virtual bool CHKLGIPMIDG(int FDLOHCDDBIM, Span<Data> BKLDDIKBPBA, in ReadOnlySpan<byte> IBDMDMLOLOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x25B2D60", Offset = "0x25B1760", VA = "0x1825B2D60", Slot = "5")]
	internal sealed override bool NJMFGBJKOHH(ref Unity.Entities.Chunk FAHOIFKLOIG, int PABNLMEHKMK, EHDEHNCFGLN HLNMPCAECGF, out ReadOnlySpan<byte> IBDMDMLOLOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x25B20D0", Offset = "0x25B0AD0", VA = "0x1825B20D0", Slot = "6")]
	internal sealed override bool CHKLGIPMIDG(int FDLOHCDDBIM, ref Unity.Entities.Chunk FAHOIFKLOIG, int PABNLMEHKMK, in ReadOnlySpan<byte> IBDMDMLOLOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x179F8F0", Offset = "0x179E2F0", VA = "0x18179F8F0")]
	protected global::ELPFGPCKDHN<Protobuf> JLBCIJMNDDJ<Protobuf>(ReadOnlySpan<Data> BKLDDIKBPBA) where Protobuf : IMessage, new()
	{
		return default(global::ELPFGPCKDHN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x179F940", Offset = "0x179E340", VA = "0x18179F940")]
	protected global::FCFPFJCMDHD<Protobuf> LFKEEEAEPPM<Protobuf>(ReadOnlySpan<byte> IBDMDMLOLOO, ReadOnlySpan<Data> BKLDDIKBPBA, Action<Protobuf> AFGIMEDDBCL) where Protobuf : IMessage, new()
	{
		return default(global::FCFPFJCMDHD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7CF650", Offset = "0x7CE050", VA = "0x1807CF650")]
	protected BCIEJIFJLKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class MHOPCPJOHOK
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	protected internal abstract int MIEMBAEOINL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x538A940", Offset = "0x5389340", VA = "0x18538A940", Slot = "5")]
	internal virtual bool NJMFGBJKOHH(ref Unity.Entities.Chunk FAHOIFKLOIG, int PABNLMEHKMK, EHDEHNCFGLN HLNMPCAECGF, out ReadOnlySpan<byte> IBDMDMLOLOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720", Slot = "6")]
	internal virtual bool CHKLGIPMIDG(int FDLOHCDDBIM, ref Unity.Entities.Chunk FAHOIFKLOIG, int PABNLMEHKMK, in ReadOnlySpan<byte> IBDMDMLOLOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	protected MHOPCPJOHOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface MIFFJKLLBME<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo GPCLMJCDOGA(TFrom NKJMIDIDBOE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GJMHNNMJMAD<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOMLJIFJNEG(T NKJMIDIDBOE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct BCMKMDPLBJH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::MIFFJKLLBME<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public NativeArray<TFrom> GIAFOBCNNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeArray<TTo> GLDMBGPNMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TMap LBPAPOGAAHD;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct DIKBCKMFGKP<TFrom, TTo, TMap> : IJobChunk where TFrom : struct, IComponentData where TTo : struct where TMap : struct, global::MIFFJKLLBME<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ArchetypeChunkComponentType<TFrom> KBOBPONPNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[WriteOnly]
	public NativeArray<TTo> GLDMBGPNMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public TMap LBPAPOGAAHD;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct GFJBHNMICEC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FGMENCPKMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<Entity> GIAFOBCNNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[WriteOnly]
	public NativeArray<T> GLDMBGPNMBJ;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1CBCF60", Offset = "0x1CBB960", VA = "0x181CBCF60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct PNEFJLLLPMG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FGMENCPKMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<Entity> GIAFOBCNNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[WriteOnly]
	public NativeList<T> OLJONOLLBNI;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct ACKOMEHOHMP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::MIFFJKLLBME<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<TFrom> BKLDENKODIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[WriteOnly]
	public NativeList<TTo> GLDMBGPNMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap LBPAPOGAAHD;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct MNIHFDLILDJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IOCCOEIFPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> OAILNMMPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeArray<bool> IKPODLPICAF;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct AMFDBNMJFJO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IOCCOEIFPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<Entity> OAILNMMPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeArray<bool> IKPODLPICAF;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2031D90", Offset = "0x2030790", VA = "0x182031D90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct PFLPOJBHIEG<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> GIAFOBCNNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> OLJONOLLBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeHashMap<T, FIGHGNFLDFK> CFFEECEPDJE;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x23E6790", Offset = "0x23E5190", VA = "0x1823E6790", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct DGAJPLLAIPN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::MIFFJKLLBME<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<TFrom> GIAFOBCNNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<TFrom> OLJONOLLBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeHashMap<TTo, FIGHGNFLDFK> CFFEECEPDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TMap LBPAPOGAAHD;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct HCODHAKEGPA<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::GJMHNNMJMAD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> GIAFOBCNNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> OLJONOLLBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate LBPAPOGAAHD;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct BIDDJMOLMND : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public LDAFGDLEPJJ IOCCOEIFPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> OAILNMMPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> HGBEAODPLCM;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x53875C0", Offset = "0x5385FC0", VA = "0x1853875C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct BMGJLKBBGCH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public LDAFGDLEPJJ IOCCOEIFPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> OAILNMMPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> HGBEAODPLCM;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5387650", Offset = "0x5386050", VA = "0x185387650", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LADHCHFABGK
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class OCGKGKHCIEA
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2211040", Offset = "0x220FA40", VA = "0x182211040")]
	public static bool PIEAFFIJEAM<T>(this NativeArray<Entity> OAILNMMPLEK, EntityManager KACBFFMHDCF, Allocator FAMNMGKAFPB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class IACOLBIOIHH
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GFFBGKAEAPH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		public GFFBGKAEAPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class KDMBGCDBNMF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		public KDMBGCDBNMF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> ILHGKADODOD;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5388F70", Offset = "0x5387970", VA = "0x185388F70")]
	public IACOLBIOIHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class IAANKABKMEE
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JEKPEOGFBCA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct CCEGPCLGPEF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct JDOLNCNCMDJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal CCEGPCLGPEF<TFrom> EGNCPOLPGCD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator FAMNMGKAFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> DNHJJJCEBEN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct ANELFACNFNB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct EKAHDNJPHDL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal ANELFACNFNB<TFrom> EGNCPOLPGCD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator FAMNMGKAFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> DNHJJJCEBEN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct KOHBECMBEPC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct KMBCMNHABLB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal KOHBECMBEPC<TFrom> EGNCPOLPGCD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator FAMNMGKAFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal global::GBAIANKGCDO<TFrom> DNHJJJCEBEN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct LJHGCNNOFBN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct NMAJBOKCIAK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal LJHGCNNOFBN<TFrom> EGNCPOLPGCD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator FAMNMGKAFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal global::OIEIIGDBLKE<TFrom> DNHJJJCEBEN;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FAEOJNEHCMP
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JMFGKOHDMKN
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1768310", Offset = "0x1766D10", VA = "0x181768310")]
	public static NativeList<T> HMAMJMFLLGP<T>(this NativeArray<T> PFFMOAIJKFC, Allocator FAMNMGKAFPB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class JJJEAMDINKM
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x17680A0", Offset = "0x1766AA0", VA = "0x1817680A0")]
	public static NativeArray<T> GCJLKPGMDCP<T>(this NativeList<Entity> PFFMOAIJKFC, EntityManager KACBFFMHDCF, Allocator FAMNMGKAFPB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1767EA0", Offset = "0x17668A0", VA = "0x181767EA0")]
	public static NativeArray<T> GCJLKPGMDCP<T>(this NativeArray<Entity> PFFMOAIJKFC, EntityManager KACBFFMHDCF, Allocator FAMNMGKAFPB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class JGDGONDGIOH
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct HLINOFFHEKO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct PAICGOMFLII<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public HLINOFFHEKO<TFrom> DNHJJJCEBEN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator FAMNMGKAFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> GIAFOBCNNHC;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct KBENODHKAEJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct HHOFBOKFNNO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public KBENODHKAEJ<TFrom> DNHJJJCEBEN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator FAMNMGKAFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public global::GBAIANKGCDO<TFrom> GIAFOBCNNHC;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct GFGCLJKNGMH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct ABKLCALOHCG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public GFGCLJKNGMH<TFrom> DNHJJJCEBEN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator FAMNMGKAFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public global::OIEIIGDBLKE<TFrom> GIAFOBCNNHC;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class NFAACKCOCGN
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class KDHEDJHBNLF
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct GFNLHCNLEJE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator FAMNMGKAFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> GIAFOBCNNHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct CMNMONLBKOP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator FAMNMGKAFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> GIAFOBCNNHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct KIPBJIBMLCN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator FAMNMGKAFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public global::GBAIANKGCDO<T> GIAFOBCNNHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct FJDPJPAGCCF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator FAMNMGKAFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public global::OIEIIGDBLKE<T> GIAFOBCNNHC;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JPPKBMIHMDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class FCNECMKJHEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1AA83F0", Offset = "0x1AA6DF0", VA = "0x181AA83F0")]
	public static NativeList<Entity> AMHFOBINFFJ<T>(this NativeArray<Entity> OAILNMMPLEK, EntityManager KACBFFMHDCF, Allocator FAMNMGKAFPB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class EFLBFJBHHGN
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface KHBGHLOLJPF
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface IIIMEOCGHGJ
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class GGIHJNBMLOG
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class LFCBINLNHHN
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5389A70", Offset = "0x5388470", VA = "0x185389A70")]
	public static bool KEBHFJAJBGA(Type NFMPIOLJBMO, Type KJDNENPDOKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal abstract class AKEMDPJHHLI<Attribute, BaseClass> : global::MGBEFMAANNH<BaseClass>, JEMJAMBMPJB where Attribute : NLELAHOPGEC
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly LOOGELFKPLM ENHDLHMFJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly string KKJOOAJGLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<int, Type> NGCBFOFNHNI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x20279C0", Offset = "0x20263C0", VA = "0x1820279C0")]
	public AKEMDPJHHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2027640", Offset = "0x2026040", VA = "0x182027640", Slot = "4")]
	public bool CLJNJIAEHOP(int FEFFHDFABJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2027390", Offset = "0x2025D90", VA = "0x182027390", Slot = "5")]
	public global::CLOECBDOJED<BaseClass> BKJMKIDHEFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2027730", Offset = "0x2026130", VA = "0x182027730", Slot = "7")]
	protected virtual bool KEBHFJAJBGA(Type NFMPIOLJBMO, int LFLKAFOHJEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x20278D0", Offset = "0x20262D0", VA = "0x1820278D0", Slot = "8")]
	protected virtual int PKHGFKNBCFG(Type NFMPIOLJBMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x20276A0", Offset = "0x20260A0", VA = "0x1820276A0")]
	public void HGKEFMKAFGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2027830", Offset = "0x2026230", VA = "0x182027830", Slot = "6")]
	public void MKIHEFFHNPG(Type NFMPIOLJBMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class CLOECBDOJED<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<int, BaseClass> HLNJGNKPGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<Type, BaseClass> MLNEANFHJEK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEnumerable<BaseClass> KEKNPAHCAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x229D000", Offset = "0x229BA00", VA = "0x18229D000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x229D2B0", Offset = "0x229BCB0", VA = "0x18229D2B0")]
	public CLOECBDOJED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x229D440", Offset = "0x229BE40", VA = "0x18229D440")]
	public CLOECBDOJED(int CDECJIFLFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x229D230", Offset = "0x229BC30", VA = "0x18229D230")]
	internal void MJIKPLNABDE(int FEFFHDFABJK, BaseClass BHNPFBAANIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x179FAB0", Offset = "0x179E4B0", VA = "0x18179FAB0")]
	public bool KGDHKDLNBNH<T>(out BaseClass NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x229CF60", Offset = "0x229B960", VA = "0x18229CF60")]
	public bool KGDHKDLNBNH(Type DKBELBDDPBK, out BaseClass NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1C12CB0", Offset = "0x1C116B0", VA = "0x181C12CB0")]
	public bool LFCPLLLDMLL(int FEFFHDFABJK, out BaseClass NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x179F9D0", Offset = "0x179E3D0", VA = "0x18179F9D0")]
	public T HACOFLHCAFM<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x229CF30", Offset = "0x229B930", VA = "0x18229CF30")]
	public BaseClass HACOFLHCAFM(Type BPGJPDKJEEJ)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class DFNJPAGKHOF : global::AKEMDPJHHLI<KKLLFLCMAAC, LKCPANANAIJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5388400", Offset = "0x5386E00", VA = "0x185388400")]
	public DFNJPAGKHOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class MCEBNHIAIHH : global::AKEMDPJHHLI<CLBBEHGLPDF, HNAPDCCEHDA>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x538A550", Offset = "0x5388F50", VA = "0x18538A550")]
	public MCEBNHIAIHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class FMHECGDFMMC : global::AKEMDPJHHLI<HJICCHMFEGP, MHOPCPJOHOK>
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5388680", Offset = "0x5387080", VA = "0x185388680")]
	public FMHECGDFMMC()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[OJEJDFBPPED(FHFOPEOFOPD.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly List<Type> GKLDKDMPMKM;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EC0", Offset = "0x6A38C0", VA = "0x1806A4EC0")]
		private ComponentSystemTypes(List<Type> GKLDKDMPMKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5388000", Offset = "0x5386A00", VA = "0x185388000")]
		public static void HGKEFMKAFGI(List<Type> GKLDKDMPMKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5388170", Offset = "0x5386B70", VA = "0x185388170")]
		private void NMFGGKAJEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x53880F0", Offset = "0x5386AF0", VA = "0x1853880F0")]
		private bool KEBHFJAJBGA(Type NFMPIOLJBMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5388090", Offset = "0x5386A90", VA = "0x185388090")]
		private void IPLBKMOBJCL(Type NFMPIOLJBMO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class GEHLDJEIKIH : GFIPAIPJBPC
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5388740", Offset = "0x5387140", VA = "0x185388740", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract ComponentSystemBase GJJGBNJIDNA();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x53886F0", Offset = "0x53870F0", VA = "0x1853886F0")]
	protected ComponentSystemBase OBDNBELFDDD(params ComponentSystemBase[] ALJPPMMDDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC2B0", Offset = "0x1DBACB0", VA = "0x181DBC2B0")]
	protected ComponentSystemBase OBDNBELFDDD<T>(params ComponentSystemBase[] ALJPPMMDDBF) where T : GFIPAIPJBPC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC270", Offset = "0x1DBAC70", VA = "0x181DBC270")]
	protected ComponentSystemBase DIINCMIGNDM<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC270", Offset = "0x1DBAC70", VA = "0x181DBC270")]
	protected ComponentSystemBase DLPCOHNFDEP<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	protected GEHLDJEIKIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal interface MGBEFMAANNH<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLJNJIAEHOP(int FEFFHDFABJK);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::CLOECBDOJED<BaseClass> BKJMKIDHEFF();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class GFIPAIPJBPC : MAEMPEAFAOC
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5388780", Offset = "0x5387180", VA = "0x185388780", Slot = "15")]
	[Obsolete]
	public override void SortSystemUpdateList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public GFIPAIPJBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class BHPPPHCOIMM : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5387510", Offset = "0x5385F10", VA = "0x185387510")]
	public LDAFGDLEPJJ ENOPBIDCJAF(int FEFFHDFABJK, bool FMOAHOIEJLP = false)
	{
		return default(LDAFGDLEPJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x53875B0", Offset = "0x5385FB0", VA = "0x1853875B0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0")]
	protected BHPPPHCOIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class DGNMLKMPPHJ : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0")]
	protected DGNMLKMPPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class CDOOAJCMHMN : BHPPPHCOIMM
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5387F80", Offset = "0x5386980", VA = "0x185387F80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	protected void MPANPDAFJHI(string LJBOLOLGICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0")]
	protected CDOOAJCMHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class KHCDHHAIMAF
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class MAEMPEAFAOC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	protected MAEMPEAFAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[OJEJDFBPPED(FHFOPEOFOPD.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x538C660", Offset = "0x538B060", VA = "0x18538C660")]
		public static ComponentSystemGroup[] ECACHEAJLMF(World MKBCEHAIJKD, BONHMFNJPFE BGHFIDDLAJF = BONHMFNJPFE.Default, bool HCECECPHFLG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x538CBD0", Offset = "0x538B5D0", VA = "0x18538CBD0")]
		private static Type[] JPNBCFMHCDK(BONHMFNJPFE BGHFIDDLAJF, bool HCECECPHFLG, ComponentSystemGroup[] ENPLLKJCKIM, ComponentSystemGroup MPFHMMCGNBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x538C730", Offset = "0x538B130", VA = "0x18538C730")]
		private static ComponentSystemGroup[] FGBLEPOKLBM(World MKBCEHAIJKD, out ComponentSystemGroup MPFHMMCGNBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x538CF30", Offset = "0x538B930", VA = "0x18538CF30")]
		internal static bool LNDJIOAIAHI(IAIEFIFAMIP ALIOHCFALJN, out HOLLHDBLNEC KDOEDLHOFGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x538D1B0", Offset = "0x538BBB0", VA = "0x18538D1B0")]
		private static ComponentSystemGroup OCBEPEACECK(Type NFMPIOLJBMO, World MKBCEHAIJKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x538CAA0", Offset = "0x538B4A0", VA = "0x18538CAA0")]
		private static ComponentSystemGroup[] IDPKFMAMAHO(Type[] GKLDKDMPMKM, World MKBCEHAIJKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x538D290", Offset = "0x538BC90", VA = "0x18538D290")]
		internal static void OIKFNIMIKLP(World MKBCEHAIJKD, Type[] AJCIELMHFID, ComponentSystemGroup[] ENPLLKJCKIM, ComponentSystemGroup MPFHMMCGNBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x538CA40", Offset = "0x538B440", VA = "0x18538CA40")]
		internal static bool HHLAFKKIKKJ(ComponentSystemBase JGOKKFDANJI, ComponentSystemGroup[] ENPLLKJCKIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x538C600", Offset = "0x538B000", VA = "0x18538C600")]
		private static void BADBCEEHCMN(ComponentSystemGroup[] ENPLLKJCKIM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct BGEOPOJHDEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Dictionary<Type, List<Type>> LJDJICJLCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly HashSet<Type> ALJPPMMDDBF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x79C0E0", Offset = "0x79AAE0", VA = "0x18079C0E0")]
	public BGEOPOJHDEH(Dictionary<Type, List<Type>> LJDJICJLCAM, HashSet<Type> ALJPPMMDDBF)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[OJEJDFBPPED(FHFOPEOFOPD.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class MCLOKJPAFNM : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x877FD0", Offset = "0x8769D0", VA = "0x180877FD0")]
			[DebuggerHidden]
			public MCLOKJPAFNM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x538A860", Offset = "0x5389260", VA = "0x18538A860", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x538A5C0", Offset = "0x5388FC0", VA = "0x18538A5C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x538A8F0", Offset = "0x53892F0", VA = "0x18538A8F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x538A820", Offset = "0x5389220", VA = "0x18538A820", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x538A770", Offset = "0x5389170", VA = "0x18538A770", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x538A770", Offset = "0x5389170", VA = "0x18538A770", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct BMAMDOJPEHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Type HNMKBHKBKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private BONHMFNJPFE BGHFIDDLAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool GABIBMMJKIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool OANKGPKALIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool HCECECPHFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerable<Type> CDAKIMHJBKI;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x538DA30", Offset = "0x538C430", VA = "0x18538DA30")]
		public static RRFilterWorldSystems BJHKCBAGIGH()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x538E730", Offset = "0x538D130", VA = "0x18538E730")]
		public RRFilterWorldSystems PJODEAGPFCO(BONHMFNJPFE ALIOHCFALJN)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x538D840", Offset = "0x538C240", VA = "0x18538D840")]
		public RRFilterWorldSystems AAJPCJPECGK(IEnumerable<Type> GKLDKDMPMKM)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x538DA20", Offset = "0x538C420", VA = "0x18538DA20")]
		public RRFilterWorldSystems BAIIBFLKNLK(bool JMKHMOKFLPE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x538DBB0", Offset = "0x538C5B0", VA = "0x18538DBB0")]
		public RRFilterWorldSystems CNONIOBBPCE(bool AGKANBGKHIH)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x538D990", Offset = "0x538C390", VA = "0x18538D990")]
		public BGEOPOJHDEH ANLPOMEGEMG(Type[] GBNDPIGMHKA)
		{
			return default(BGEOPOJHDEH);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x538DBC0", Offset = "0x538C5C0", VA = "0x18538DBC0")]
		[IteratorStateMachine(typeof(MCLOKJPAFNM))]
		internal IEnumerable<Type> FCCILHAGHMD(IEnumerable<Type> GKLDKDMPMKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x538E450", Offset = "0x538CE50", VA = "0x18538E450")]
		internal Dictionary<Type, List<Type>> NMGOPPGNPJA(IEnumerable<Type> GKLDKDMPMKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x538D880", Offset = "0x538C280", VA = "0x18538D880")]
		private void AFNALEEMMHA(Dictionary<Type, List<Type>> DIDIDBBHIMI, Type NFMPIOLJBMO, Type POMNAMOFICD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x538DC50", Offset = "0x538C650", VA = "0x18538DC50")]
		internal HashSet<Type> INGNFMGFJMG(IEnumerable<Type> ENPLLKJCKIM, Dictionary<Type, List<Type>> BINBGBCIPDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x538DE10", Offset = "0x538C810", VA = "0x18538DE10")]
		internal bool NAGPOGBDPBB(Type NFMPIOLJBMO, BONHMFNJPFE BGHFIDDLAJF, bool HCECECPHFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x538DA50", Offset = "0x538C450", VA = "0x18538DA50")]
		[CompilerGenerated]
		internal static void CEBOPCLPLDI(Type NFMPIOLJBMO, ref BMAMDOJPEHE P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class LFOGPIJFIGF
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static bool OHOEKFEAFOL;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5389C50", Offset = "0x5388650", VA = "0x185389C50")]
	public static void GICNDCMAEJH(bool KPPPANMEOGF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5389CB0", Offset = "0x53886B0", VA = "0x185389CB0")]
	private static void LCEHOBKGJHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class OKHHPGLBJJK
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x538B580", Offset = "0x5389F80", VA = "0x18538B580")]
	public static ulong GKMHHFIECAD(Type NFMPIOLJBMO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x538B5B0", Offset = "0x5389FB0", VA = "0x18538B5B0")]
	public static ulong GKMHHFIECAD(string AAKLNMFBMMB)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[OJEJDFBPPED(FHFOPEOFOPD.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private struct KFPJHOPGMMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly ulong OHADOJKBFON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly ulong GEOAOAKJIHB;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x22DDA20", Offset = "0x22DC420", VA = "0x1822DDA20")]
			public KFPJHOPGMMO(ulong MPJAGPABPKL, ulong ENEIPDLHJKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x53893C0", Offset = "0x5387DC0", VA = "0x1853893C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static Dictionary<ulong, int> DFKOLNFAAGG;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static KFPJHOPGMMO[] LAGNIBGIBJC;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static bool OHOEKFEAFOL;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x538ED70", Offset = "0x538D770", VA = "0x18538ED70")]
		public static ulong LEODGLGPGIG(int FEFFHDFABJK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x538ECC0", Offset = "0x538D6C0", VA = "0x18538ECC0")]
		public static int JPBFJNFHBOI(ulong ENEIPDLHJKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x538EA60", Offset = "0x538D460", VA = "0x18538EA60")]
		public static void GICNDCMAEJH(bool KPPPANMEOGF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x538E810", Offset = "0x538D210", VA = "0x18538E810")]
		private static void DGFAFIFFELD(int FHEMBMOCNPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x538F1E0", Offset = "0x538DBE0", VA = "0x18538F1E0")]
		private static void OHNAKICOKON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x538E980", Offset = "0x538D380", VA = "0x18538E980")]
		private static KFPJHOPGMMO FOOMHCKNBPG(Type NFMPIOLJBMO)
		{
			return default(KFPJHOPGMMO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x538EC50", Offset = "0x538D650", VA = "0x18538EC50")]
		private static ulong GODADIENILK(Type NFMPIOLJBMO, ulong ENEIPDLHJKO)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x538EFB0", Offset = "0x538D9B0", VA = "0x18538EFB0")]
		private static void MPPBEAPHBHN(in KFPJHOPGMMO BJFABMMKIFK, TypeManager.TypeInfo PAPANJIEKLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x538EEB0", Offset = "0x538D8B0", VA = "0x18538EEB0")]
		private static void MNCPOMHGPJF(KFPJHOPGMMO PAPANJIEKLG, int FEFFHDFABJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x538EDD0", Offset = "0x538D7D0", VA = "0x18538EDD0")]
		private static void LJJLEIKJPEC(KFPJHOPGMMO PAPANJIEKLG, int FEFFHDFABJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x538E8F0", Offset = "0x538D2F0", VA = "0x18538E8F0")]
		private static KFPJHOPGMMO DMJJMNEHNLJ(int FEFFHDFABJK)
		{
			return default(KFPJHOPGMMO);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x538F1D0", Offset = "0x538DBD0", VA = "0x18538F1D0")]
		private static int NEJDMPNFABH(int FEFFHDFABJK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class CCBAEDGLAHA
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly MCEBNHIAIHH DOOLJEOAJCE;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly FMHECGDFMMC NMKCKGMCABO;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly DFNJPAGKHOF MIBDIPNALPD;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly List<Type> DFLEDFFKAJE;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static bool OHOEKFEAFOL;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal static global::MGBEFMAANNH<HNAPDCCEHDA> OHALLKEGMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5387CF0", Offset = "0x53866F0", VA = "0x185387CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal static global::MGBEFMAANNH<MHOPCPJOHOK> EPEKJGILGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5387700", Offset = "0x5386100", VA = "0x185387700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal static global::MGBEFMAANNH<LKCPANANAIJ> HMNDEEGAHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5387760", Offset = "0x5386160", VA = "0x185387760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5387840", Offset = "0x5386240", VA = "0x185387840")]
	public static void GICNDCMAEJH(bool KPPPANMEOGF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x53877C0", Offset = "0x53861C0", VA = "0x1853877C0")]
	public static Type[] DKAEBFJEEGB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class LLELGOBAENM
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly Dictionary<int, int> ICDLHKNMGPC;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static bool OHOEKFEAFOL;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x538A430", Offset = "0x5388E30", VA = "0x18538A430")]
	public static int PNAFBPICGGL(int FEFFHDFABJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x538A090", Offset = "0x5388A90", VA = "0x18538A090")]
	public static void GICNDCMAEJH(bool KPPPANMEOGF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x538A1B0", Offset = "0x5388BB0", VA = "0x18538A1B0")]
	private static void LNMDPAIJGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x538A040", Offset = "0x5388A40", VA = "0x18538A040")]
	private static int DDFAEAGFENB(Type NFMPIOLJBMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x538A130", Offset = "0x5388B30", VA = "0x18538A130")]
	private static void LCFMPIKHEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class OLNILFAFOLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly World MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly World HAAPHOAKHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly AMGOMELBDKB BHNPFBAANIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ComponentSystemGroup[] ENPLLKJCKIM;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public World DLPKPCDMEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public World IEBLHEBKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityManager AJHOIKIBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1447000", Offset = "0x1445A00", VA = "0x181447000")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public AMGOMELBDKB JMGIMDJFKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public global::CLOECBDOJED<HNAPDCCEHDA> OHALLKEGMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7939F0", Offset = "0x7923F0", VA = "0x1807939F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public global::CLOECBDOJED<MHOPCPJOHOK> EPEKJGILGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6B0AB0", Offset = "0x6AF4B0", VA = "0x1806B0AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8588D0", Offset = "0x8572D0", VA = "0x1808588D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public global::CLOECBDOJED<LKCPANANAIJ> HMNDEEGAHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6F0", Offset = "0x6AE0F0", VA = "0x1806AF6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x85EE80", Offset = "0x85D880", VA = "0x18085EE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> KCKPMIGEKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x14638B0", Offset = "0x14622B0", VA = "0x1814638B0")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ComponentSystemGroup[] JNMDJJCGGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x538B760", Offset = "0x538A160", VA = "0x18538B760")]
	public static OLNILFAFOLN CPFFFKCEHLD(string KKJOOAJGLJI, IAIEFIFAMIP ALIOHCFALJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x538C0B0", Offset = "0x538AAB0", VA = "0x18538C0B0")]
	public OLNILFAFOLN(string KKJOOAJGLJI, IAIEFIFAMIP ALIOHCFALJN = IAIEFIFAMIP.Simulation, BONHMFNJPFE BGHFIDDLAJF = BONHMFNJPFE.Default, bool KPPPANMEOGF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x538B960", Offset = "0x538A360", VA = "0x18538B960")]
	public ComponentSystemBase EKDBCCHOBKO(Type NFMPIOLJBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2217FD0", Offset = "0x22169D0", VA = "0x182217FD0")]
	public T EKDBCCHOBKO<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x538BDF0", Offset = "0x538A7F0", VA = "0x18538BDF0")]
	public void JGKOPAEPPHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x538BA60", Offset = "0x538A460", VA = "0x18538BA60")]
	public void HKHINJLEJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x538BEB0", Offset = "0x538A8B0", VA = "0x18538BEB0")]
	public void KBMNGHLAEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x538BF70", Offset = "0x538A970", VA = "0x18538BF70")]
	public void LEHJKFJIPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x538B700", Offset = "0x538A100", VA = "0x18538B700")]
	public void CGANKIOODNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x538BF10", Offset = "0x538A910", VA = "0x18538BF10")]
	public void KKFMMIIFOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x538BE50", Offset = "0x538A850", VA = "0x18538BE50")]
	public void JPBOHLEFCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x538B670", Offset = "0x538A070", VA = "0x18538B670")]
	public void CDHMDDHPNJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x538BD90", Offset = "0x538A790", VA = "0x18538BD90")]
	public void IPADCMKPJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x538BFD0", Offset = "0x538A9D0", VA = "0x18538BFD0")]
	public void NFJOCBPDKKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x538B980", Offset = "0x538A380", VA = "0x18538B980")]
	internal void HACDNBJENKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x538C030", Offset = "0x538AA30", VA = "0x18538C030")]
	private bool OCKDFHGKGEE(ComponentSystemGroup HLJJLMFOIKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x538BAC0", Offset = "0x538A4C0", VA = "0x18538BAC0")]
	private void ICNJGAJBKPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x538B850", Offset = "0x538A250", VA = "0x18538B850")]
	private ComponentSystemGroup[] ECACHEAJLMF(BONHMFNJPFE BGHFIDDLAJF, bool HCECECPHFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x538B7E0", Offset = "0x538A1E0", VA = "0x18538B7E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
public enum IAIEFIFAMIP
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
public sealed class NFKILPEMMMN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public BONHMFNJPFE COGHHOGBDAK;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[Flags]
public enum BONHMFNJPFE
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
public interface HOLLHDBLNEC
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Type OOGAGJAPDMN
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Type[] ELLNNFMEONE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class NMNNPCNPIJM : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public virtual bool JDEGJBPDCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6A32E0", Offset = "0x6A1CE0", VA = "0x1806A32E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	protected NMNNPCNPIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DisableAutoCreation]
public sealed class HKMIDKBBHLH : NMNNPCNPIJM
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public HKMIDKBBHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DisableAutoCreation]
public sealed class BHNEECMABCO : NMNNPCNPIJM
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public BHNEECMABCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DisableAutoCreation]
public sealed class EMOKGMDHBOP : NMNNPCNPIJM
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public EMOKGMDHBOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DisableAutoCreation]
public sealed class OAKCEFNCIMP : NMNNPCNPIJM
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public OAKCEFNCIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DisableAutoCreation]
public sealed class CBJHJIJABNL : NMNNPCNPIJM
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public CBJHJIJABNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DisableAutoCreation]
public sealed class HAHPEEDHECG : NMNNPCNPIJM
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public HAHPEEDHECG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DisableAutoCreation]
public sealed class EJICOLKNOJP : NMNNPCNPIJM
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public EJICOLKNOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DisableAutoCreation]
public sealed class DNBEBJNJPCI : NMNNPCNPIJM
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public DNBEBJNJPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DisableAutoCreation]
public sealed class BDPDGCAIHCL : NMNNPCNPIJM
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public BDPDGCAIHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class PLJKCOPECHA : JHFLNELLNDO
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public PLJKCOPECHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public sealed class FHIIJFHKBKH : JHFLNELLNDO
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public FHIIJFHKBKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class ANJIMOEOLEJ : JHFLNELLNDO
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public ANJIMOEOLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public sealed class IBMGGKEDHJB : JHFLNELLNDO
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public IBMGGKEDHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DisableAutoCreation]
[GMDIBPFFIEN(AHJKMAKLGJA.Application)]
public class JHFLNELLNDO : NMNNPCNPIJM
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool JDEGJBPDCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5387490", Offset = "0x5385E90", VA = "0x185387490")]
	public JHFLNELLNDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AttributeUsage(AttributeTargets.Class)]
public class JICPLAHIAGM : MMHNEAAGHNG
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public JICPLAHIAGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class EGFIALMLKNN
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public delegate void MPLOEBKPEFK<From, To>(From DNHJJJCEBEN, ref To BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF);

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class DKIKNCDANJN<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static MPLOEBKPEFK<From, To> KMHHOMLFJEB;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public DKIKNCDANJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5388470", Offset = "0x5386E70", VA = "0x185388470")]
	static EGFIALMLKNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x10ED5E0", Offset = "0x10EBFE0", VA = "0x1810ED5E0")]
	public static void PBOLNADJFGM<T>(MPLOEBKPEFK<T, T> PMIJOJBFNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x10ED470", Offset = "0x10EBE70", VA = "0x1810ED470")]
	public static void PBOLNADJFGM<From, To>(MPLOEBKPEFK<From, To> PMIJOJBFNBD, MPLOEBKPEFK<To, From> OAGACABEDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x10ED500", Offset = "0x10EBF00", VA = "0x1810ED500")]
	public static void PBOLNADJFGM<From, To>(MPLOEBKPEFK<From, To> KMHHOMLFJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x10E8770", Offset = "0x10E7170", VA = "0x1810E8770")]
	public static MPLOEBKPEFK<From, To> ILAEHIFCMDF<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x10EC000", Offset = "0x10EAA00", VA = "0x1810EC000")]
	public static void OLOGACBMBIO<From, To>(From DNHJJJCEBEN, ref To BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class EHDEHNCFGLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> GFAKAPBEKBH;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1862490", Offset = "0x1860E90", VA = "0x181862490")]
	public EHDEHNCFGLN(NativeArray<EntityRemapUtility.EntityRemapInfo> GFAKAPBEKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2192FE0", Offset = "0x21919E0", VA = "0x182192FE0")]
	public Entity CIAEEFNFAJJ(Entity JAKENEGIGGH)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class KAOLFHDJECK
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static Dictionary<(ulong hash, uint version), string> KAHNPGGICCE;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5389130", Offset = "0x5387B30", VA = "0x185389130")]
	public static bool IKEIEHKGHGO(ulong FHKNDMKDLNF, uint FDLOHCDDBIM, out string KKJOOAJGLJI)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[OJEJDFBPPED(FHFOPEOFOPD.Serialization)]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct BJLHIHFIHEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int HMIPEGLEEME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int MIEMBAEOINL;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8012C0", Offset = "0x7FFCC0", VA = "0x1808012C0")]
			public BJLHIHFIHEL(int NENMOOINMCH, int FDLOHCDDBIM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public struct OCBHALMCOIJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private static Stopwatch ALBCGGNCPGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private long PHHGMDLMOOK;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public long IAODMPKMMIO
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x538AB90", Offset = "0x5389590", VA = "0x18538AB90")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public long ODDGMNDNKBB
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x538AB20", Offset = "0x5389520", VA = "0x18538AB20")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x538ABF0", Offset = "0x53895F0", VA = "0x18538ABF0")]
			public static OCBHALMCOIJ LOIIHJFIPMJ()
			{
				return default(OCBHALMCOIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct OHDBCCIKOGO : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			public readonly struct OFGEKFPKBBG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public unsafe readonly Unity.Entities.Archetype* MJCBNNLIIHO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public readonly BLGDIFONKNI.KFOENJAMPMP.MEECJHIMOBK CMJEJKABNFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public readonly EHDEHNCFGLN HLNMPCAECGF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public readonly global::CLOECBDOJED<MHOPCPJOHOK> LAOKKABHFCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public readonly int PABNLMEHKMK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public readonly int IAHPOJFNEBE;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x538AD00", Offset = "0x5389700", VA = "0x18538AD00")]
				public unsafe OFGEKFPKBBG(Unity.Entities.Archetype* MJCBNNLIIHO, BLGDIFONKNI.KFOENJAMPMP.MEECJHIMOBK CMJEJKABNFC, EHDEHNCFGLN HLNMPCAECGF, global::CLOECBDOJED<MHOPCPJOHOK> LAOKKABHFCD, int PABNLMEHKMK, int IAHPOJFNEBE = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x538ACB0", Offset = "0x53896B0", VA = "0x18538ACB0")]
				public OFGEKFPKBBG(in OFGEKFPKBBG PJIINDGLAPJ, int IAHPOJFNEBE)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public readonly OFGEKFPKBBG[] BKLDDIKBPBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string[] INGOJOPPAPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int DKFGNKBFKFE;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x538B440", Offset = "0x5389E40", VA = "0x18538B440")]
			public OHDBCCIKOGO(OFGEKFPKBBG[] BKLDDIKBPBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x538B030", Offset = "0x5389A30", VA = "0x18538B030", Slot = "4")]
			public void Invoke(int NENMOOINMCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x538B090", Offset = "0x5389A90", VA = "0x18538B090")]
			private void NHEDNDHCLLD(in OFGEKFPKBBG PJIINDGLAPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x538AD60", Offset = "0x5389760", VA = "0x18538AD60")]
			private static void GDOMDBEJEKN(in OFGEKFPKBBG PJIINDGLAPJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class BCJFBIAIMDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public BLGDIFONKNI asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public global::CLOECBDOJED<MHOPCPJOHOK> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public BCJFBIAIMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x53874A0", Offset = "0x5385EA0", VA = "0x1853874A0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class HLIMDJHOMOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public BLGDIFONKNI.KFOENJAMPMP.MEECJHIMOBK srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public BCJFBIAIMDD CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public HLIMDJHOMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class GIMEMFKONBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public HLIMDJHOMOI CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public GIMEMFKONBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5388A30", Offset = "0x5387430", VA = "0x185388A30")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly LOOGELFKPLM NICMPNOKCBE;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly LOOGELFKPLM FGAHCCEAMAO;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly LOOGELFKPLM IFLPKDOFMGF;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly LOOGELFKPLM EEDAHNFPAEB;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static bool BKJEGOHGLAC;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static BLGDIFONKNI.KFOENJAMPMP.BIMPBBLMMBB EBKEGGPPDML;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5390950", Offset = "0x538F350", VA = "0x185390950")]
		private unsafe static bool LCJFBJIGBCB(Unity.Entities.Archetype* FHJHFHLOJMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5390770", Offset = "0x538F170", VA = "0x185390770")]
		internal unsafe static Unity.Entities.Archetype*[] KNLDIGBKFHL(ref Unity.Entities.EntityComponentStore DEBNIPLALGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x538F590", Offset = "0x538DF90", VA = "0x18538F590")]
		public static void CAHKMJHKANJ(OLNILFAFOLN MKBCEHAIJKD, out ByteString IBDMDMLOLOO, out NativeArray<EntityRemapUtility.EntityRemapInfo> KIMOLGKAGOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5390C90", Offset = "0x538F690", VA = "0x185390C90")]
		internal static void LINJNOECKDE(OLNILFAFOLN MKBCEHAIJKD, BLGDIFONKNI FPLPCIBCHGH, out NativeArray<EntityRemapUtility.EntityRemapInfo> KIMOLGKAGOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x538F650", Offset = "0x538E050", VA = "0x18538F650")]
		private unsafe static UnsafeHashMap<ulong, BJLHIHFIHEL> FIKHEKLCDGA(Unity.Entities.Archetype*[] HLIABPAOFPC)
		{
			return default(UnsafeHashMap<ulong, BJLHIHFIHEL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5390550", Offset = "0x538EF50", VA = "0x185390550")]
		private static void IHHDLENKMCG(BLGDIFONKNI FPLPCIBCHGH, UnsafeHashMap<ulong, BJLHIHFIHEL> EGDHNEJNIPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x538FB90", Offset = "0x538E590", VA = "0x18538FB90")]
		private unsafe static void HGNHJCMMCPN(BLGDIFONKNI FPLPCIBCHGH, Unity.Entities.Archetype*[] HLIABPAOFPC, UnsafeHashMap<ulong, BJLHIHFIHEL> EGDHNEJNIPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5390700", Offset = "0x538F100", VA = "0x185390700")]
		private unsafe static int JJPNJBDPBIF(Unity.Entities.Archetype*[] HLIABPAOFPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5391D10", Offset = "0x5390710", VA = "0x185391D10")]
		private unsafe static void OKCJPMDEEIK(BLGDIFONKNI FPLPCIBCHGH, Unity.Entities.Archetype*[] HLIABPAOFPC, global::CLOECBDOJED<MHOPCPJOHOK> LAOKKABHFCD, NativeArray<EntityRemapUtility.EntityRemapInfo> KIMOLGKAGOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x53913C0", Offset = "0x538FDC0", VA = "0x1853913C0")]
		private static NativeArray<int> MKIICPADKMI(BLGDIFONKNI FPLPCIBCHGH)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5392870", Offset = "0x5391270", VA = "0x185392870")]
		private static Memory<EntityArchetype> PKOHIAHGBGA(BLGDIFONKNI FPLPCIBCHGH, NativeArray<int> GKLDKDMPMKM, EntityManager KACBFFMHDCF, out int OKLJACPKHNA, out int NFMBLOFCMAO)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x538FF40", Offset = "0x538E940", VA = "0x18538FF40")]
		private unsafe static void HMDKJKMFICN(Unity.Entities.Chunk* EGDKGCGNIGO, ReadOnlySpan<byte> IBDMDMLOLOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5392130", Offset = "0x5390B30", VA = "0x185392130")]
		private static void OOIIBELCJAE(BLGDIFONKNI FPLPCIBCHGH, NativeArray<int> GKLDKDMPMKM, Span<EntityArchetype> HLIABPAOFPC, EntityManager KACBFFMHDCF, global::CLOECBDOJED<MHOPCPJOHOK> LAOKKABHFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x538FEC0", Offset = "0x538E8C0", VA = "0x18538FEC0")]
		private unsafe static void HLMPJBIJKII(Unity.Entities.Chunk* FAHOIFKLOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5392CE0", Offset = "0x53916E0", VA = "0x185392CE0")]
		private unsafe static void POEECLFAIII(BLGDIFONKNI.KFOENJAMPMP.MEECJHIMOBK MJCBNNLIIHO, int NCIAHPJPMCI, int NPGJJKKIMLL, Unity.Entities.Chunk* EGDKGCGNIGO, BLGDIFONKNI FPLPCIBCHGH, NativeArray<int> GKLDKDMPMKM, global::CLOECBDOJED<MHOPCPJOHOK> LAOKKABHFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5391630", Offset = "0x5390030", VA = "0x185391630")]
		public static void OAKEPINCODO(OLNILFAFOLN MKBCEHAIJKD, in ByteString IBDMDMLOLOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x53916C0", Offset = "0x53900C0", VA = "0x1853916C0")]
		public static void OAKEPINCODO(EntityManager KACBFFMHDCF, global::CLOECBDOJED<MHOPCPJOHOK> LAOKKABHFCD, in ByteString IBDMDMLOLOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5390290", Offset = "0x538EC90", VA = "0x185390290")]
		private static bool IANKPHCKKJL(Type NFMPIOLJBMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x538F8E0", Offset = "0x538E2E0", VA = "0x18538F8E0")]
		private static void GNBMCIBFEIG(TypeManager.TypeInfo PAPANJIEKLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5390B00", Offset = "0x538F500", VA = "0x185390B00")]
		private unsafe static int LFKCMLKAOMD(Unity.Entities.Archetype*[] HLIABPAOFPC, NativeArray<EntityRemapUtility.EntityRemapInfo> KIMOLGKAGOD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5392C00", Offset = "0x5391600", VA = "0x185392C00")]
		private static int PNAFBPICGGL(int FEFFHDFABJK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5390A60", Offset = "0x538F460", VA = "0x185390A60")]
		private static ulong LEODGLGPGIG(int FEFFHDFABJK)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal static class KKHFKDMBIKG
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5389490", Offset = "0x5387E90", VA = "0x185389490")]
	private unsafe static Span<byte> LAHADOCGEDH(Unity.Entities.Chunk* FAHOIFKLOIG, int PABNLMEHKMK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1779AC0", Offset = "0x17784C0", VA = "0x181779AC0")]
	public unsafe static Span<T> MHIFGPIFJJF<T>(Unity.Entities.Chunk* FAHOIFKLOIG, int PABNLMEHKMK)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1779A80", Offset = "0x1778480", VA = "0x181779A80")]
	public static Span<T> MHIFGPIFJJF<T>(this ref Unity.Entities.Chunk FAHOIFKLOIG, int PABNLMEHKMK)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5389A00", Offset = "0x5388400", VA = "0x185389A00")]
	public unsafe static Span<Entity> PJPKMJEGNGF(Unity.Entities.Chunk* FAHOIFKLOIG)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5389630", Offset = "0x5388030", VA = "0x185389630")]
	public unsafe static void LCFMPIKHEBH(Unity.Entities.Chunk* FAHOIFKLOIG, int PABNLMEHKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x53898D0", Offset = "0x53882D0", VA = "0x1853898D0")]
	public static Entity LLLFGDFGBHO(this EntityQuery NBKDJEEFFOH)
	{
		return default(Entity);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Preserve]
	internal class _RRAssemblyIndex : ODIDKPKCBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5393250", Offset = "0x5391C50", VA = "0x185393250", Slot = "4")]
		public sealed override void HGKEFMKAFGI()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class LHIPOBGMLKE
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static byte[] PNBNOGIJBMC;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static int DGEFGPNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static int GBGLKCBJBIA;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static BigInteger EPCGLFJDNLL;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHIPOBGMLKE()
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
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
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

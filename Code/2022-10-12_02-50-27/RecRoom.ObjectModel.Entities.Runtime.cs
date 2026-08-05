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
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class ELIBNJJCPON
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x560EE90", Offset = "0x560D690", VA = "0x18560EE90")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> DCOHPDIDCFN(this ref Unity.Entities.Archetype CEMLDGMJKAJ)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MPEDNAHLNOA
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5612210", Offset = "0x5610A10", VA = "0x185612210")]
	public static Span<int> KBCNCPMMOBN(this EntityArchetype CEMLDGMJKAJ)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FCEKALIGIGP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x560EFE0", Offset = "0x560D7E0", VA = "0x18560EFE0")]
	public static bool DPHKGIJFNKP(this Entity GDNDJKDEKFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NDGHEIPLELA
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct NLLCKIPODDA<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ONPMLBHHBCI : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public global::NLLCKIPODDA<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x74A710", Offset = "0x748F10", VA = "0x18074A710", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3B8DB90", Offset = "0x3B8C390", VA = "0x183B8DB90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2F88790", Offset = "0x2F86F90", VA = "0x182F88790")]
		[DebuggerHidden]
		public ONPMLBHHBCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D9B0", Offset = "0x3B8C1B0", VA = "0x183B8D9B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3B8DB50", Offset = "0x3B8C350", VA = "0x183B8DB50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Action<Protobuf> NAHFFDPOJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MemoryStream JMJPBBLODJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CodedInputStream IHOMMNLOLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Protobuf AKLHGPOFBHL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int FFGDBGPFOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C80", Offset = "0x6F3480", VA = "0x1806F4C80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3BF3F00", Offset = "0x3BF2700", VA = "0x183BF3F00")]
	private NLLCKIPODDA(byte[] NCCOCLJLPFP, Action<Protobuf> NAHFFDPOJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4504960", Offset = "0x4503160", VA = "0x184504960")]
	public static global::NLLCKIPODDA<Protobuf> MFNJFAEBAIM<Data>(ReadOnlySpan<byte> AHJGIIFAPKK, ReadOnlySpan<Data> CFFIGFCFHML, Action<Protobuf> NAHFFDPOJND)
	{
		return default(global::NLLCKIPODDA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3BF3D70", Offset = "0x3BF2570", VA = "0x183BF3D70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3BF3DB0", Offset = "0x3BF25B0", VA = "0x183BF3DB0", Slot = "4")]
	[IteratorStateMachine(typeof(global::NLLCKIPODDA<>.ONPMLBHHBCI))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3BF3EB0", Offset = "0x3BF26B0", VA = "0x183BF3EB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JEJFKOFAHMJ<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly byte[] NCCOCLJLPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly Protobuf AKLHGPOFBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MemoryStream JMJPBBLODJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CodedOutputStream LOHCJEGMCHL;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x32AB130", Offset = "0x32A9930", VA = "0x1832AB130")]
	private JEJFKOFAHMJ(byte[] NCCOCLJLPFP, in Protobuf AKLHGPOFBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3499640", Offset = "0x3497E40", VA = "0x183499640")]
	public static global::JEJFKOFAHMJ<Protobuf> MFNJFAEBAIM<T>(ReadOnlySpan<T> CFFIGFCFHML)
	{
		return default(global::JEJFKOFAHMJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x32AAF40", Offset = "0x32A9740", VA = "0x1832AAF40")]
	public void BPIIEOILJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x32AB0A0", Offset = "0x32A98A0", VA = "0x1832AB0A0")]
	public ByteString KEBHENPFBNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x32AAF70", Offset = "0x32A9770", VA = "0x1832AAF70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct JCDMEPCNCIH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MemoryStream JMJPBBLODJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CodedInputStream IHOMMNLOLJN;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x560F7F0", Offset = "0x560DFF0", VA = "0x18560F7F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BBDPFDOPEKC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly byte[] NCCOCLJLPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MemoryStream JMJPBBLODJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CodedOutputStream LOHCJEGMCHL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x560E1D0", Offset = "0x560C9D0", VA = "0x18560E1D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class ICAMLLOKIIC : KFLPBOMAPGE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Type JIPPLEFEHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8060", Offset = "0x6F6860", VA = "0x1806F8060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x560DFD0", Offset = "0x560C7D0", VA = "0x18560DFD0")]
	public ICAMLLOKIIC(Type HLLKGOFBLCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class APCNEFCKKAN : ICAMLLOKIIC
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x560DFD0", Offset = "0x560C7D0", VA = "0x18560DFD0")]
	public APCNEFCKKAN(Type HLLKGOFBLCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JFHDNGNMLHA : ICAMLLOKIIC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Type DIHDEKKGBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5010", Offset = "0x6F3810", VA = "0x1806F5010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x560F830", Offset = "0x560E030", VA = "0x18560F830")]
	public JFHDNGNMLHA(Type PKAPEBBDLPF, Type HLLKGOFBLCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OBPEJBMLPEP : ICAMLLOKIIC
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x560DFD0", Offset = "0x560C7D0", VA = "0x18560DFD0")]
	public OBPEJBMLPEP(Type HLLKGOFBLCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PAOAHFGMMNM : KFLPBOMAPGE
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public PAOAHFGMMNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KPDDDDKCLKD : KFLPBOMAPGE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CCPAEMCMCPC IGMFGGMGMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x648800", VA = "0x18064A000")]
		[CompilerGenerated]
		get
		{
			return default(CCPAEMCMCPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5611390", Offset = "0x560FB90", VA = "0x185611390")]
	public KPDDDDKCLKD(CCPAEMCMCPC ALKHBOMOJMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
public class BJBGOMFMFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JIGACBOPBKP EAMEDKLPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly EntityManager JGGNCNMICJO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JIGACBOPBKP LJFDDHDKJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x560E410", Offset = "0x560CC10", VA = "0x18560E410")]
	public BJBGOMFMFBL(JIGACBOPBKP EAMEDKLPJKC, EntityManager JGGNCNMICJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x560E300", Offset = "0x560CB00", VA = "0x18560E300")]
	public int EJCFOFCLJDG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x354D7A0", Offset = "0x354BFA0", VA = "0x18354D7A0")]
	public bool ECIEALCEEAH<T>(Entity GDNDJKDEKFN) where T : struct, ENOPOKMPGLP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x354D7E0", Offset = "0x354BFE0", VA = "0x18354D7E0")]
	public bool EODABGNJGDO<T>(Entity GDNDJKDEKFN, out T CCIMHDCKHOF) where T : struct, ENOPOKMPGLP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x354C210", Offset = "0x354AA10", VA = "0x18354C210")]
	public T ALGDCILMLGP<T>(Entity GDNDJKDEKFN) where T : struct, ENOPOKMPGLP
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x354D870", Offset = "0x354C070", VA = "0x18354D870")]
	private ComponentType OAPHDJJJPHH<T>() where T : struct, ENOPOKMPGLP
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x560E340", Offset = "0x560CB40", VA = "0x18560E340")]
	private ComponentType OAPHDJJJPHH(Type BCFKLEGAMEO)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class APKLEDPALBD
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	protected APKLEDPALBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class NGLIOJMCPIB<View, Data> : CMKIKNDBPFM where View : struct, ENOPOKMPGLP where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static ComponentType FJKPDKNHBFO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override Type FFCHHNBDBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x32E2AE0", Offset = "0x32E12E0", VA = "0x1832E2AE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override Type LELGGEPEAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x32E38D0", Offset = "0x32E20D0", VA = "0x1832E38D0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override int BBEKJFPLOPA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x32E2310", Offset = "0x32E0B10", VA = "0x1832E2310", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x32E22A0", Offset = "0x32E0AA0", VA = "0x1832E22A0")]
	public Data ABBJNMLLLFL(Entity GDNDJKDEKFN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x32E23D0", Offset = "0x32E0BD0", VA = "0x1832E23D0")]
	public Data CMFIHFLKLHD(Entity GDNDJKDEKFN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected internal abstract View GMDCNFONIJE(Entity GDNDJKDEKFN);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3938F20", Offset = "0x3937720", VA = "0x183938F20", Slot = "15")]
	protected internal override T GMDCNFONIJE<T>(Entity GDNDJKDEKFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x32E2440", Offset = "0x32E0C40", VA = "0x1832E2440", Slot = "16")]
	public override bool ECIEALCEEAH(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2FD7A60", Offset = "0x2FD6260", VA = "0x182FD7A60")]
	protected NGLIOJMCPIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class CMKIKNDBPFM : ICGJPAAOHAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private ArchetypeChunkComponentTypeDynamic PDFNOLINOLC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EntityManager FHACAKFHJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x661660", Offset = "0x65FE60", VA = "0x180661660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public abstract Type FFCHHNBDBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public abstract Type LELGGEPEAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public abstract int BBEKJFPLOPA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private Type HCLNPCKNNGA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xDE3240", Offset = "0xDE1A40", VA = "0x180DE3240", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int MNCJDABOEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x560EA00", Offset = "0x560D200", VA = "0x18560EA00", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private MIEGLNNJAGB[] MDPOBKFFLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xDE3170", Offset = "0xDE1970", VA = "0x180DE3170", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	protected internal virtual MIEGLNNJAGB[] HCGNKDEPDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x560E940", Offset = "0x560D140", VA = "0x18560E940", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FNINHPMMKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x560EBC0", Offset = "0x560D3C0", VA = "0x18560EBC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x560E820", Offset = "0x560D020", VA = "0x18560E820")]
	public void CDFKCHBFAME(EntityManager JGGNCNMICJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x722C40", Offset = "0x721440", VA = "0x180722C40")]
	protected ICGJPAAOHAG JOMAMNNCINN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T GMDCNFONIJE<T>(Entity GDNDJKDEKFN) where T : struct, ENOPOKMPGLP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract bool ECIEALCEEAH(Entity GDNDJKDEKFN);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x560EB00", Offset = "0x560D300", VA = "0x18560EB00", Slot = "8")]
	public (uint, uint) JGEKIAPOFNF(Entity GDNDJKDEKFN)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x560EA70", Offset = "0x560D270", VA = "0x18560EA70", Slot = "9")]
	public bool IEJEPDBIIFG(Entity GDNDJKDEKFN, (uint order, uint change) LDFDMKAILBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	protected CMKIKNDBPFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class DOEJIAOMGPE<Data> : CNGICFHGNIC where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public virtual Data PJLEDACBOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C27CE0", Offset = "0x3C264E0", VA = "0x183C27CE0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3192460", Offset = "0x3190C60", VA = "0x183192460", Slot = "8")]
	protected virtual bool GAOBNPLOLGE(ReadOnlySpan<Data> CFFIGFCFHML, NGNDNHAGNEP HDMBHNNBEPE, out ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x65E740", Offset = "0x65CF40", VA = "0x18065E740", Slot = "9")]
	protected virtual bool IMBMNGNFONL(int LDFDMKAILBI, Span<Data> CFFIGFCFHML, in ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3C261C0", Offset = "0x3C249C0", VA = "0x183C261C0", Slot = "5")]
	internal sealed override bool GAOBNPLOLGE(ref Unity.Entities.Chunk DAJPMMDPFFK, int CADJDPODOGC, NGNDNHAGNEP HDMBHNNBEPE, out ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3C27280", Offset = "0x3C25A80", VA = "0x183C27280", Slot = "6")]
	internal sealed override bool IMBMNGNFONL(int LDFDMKAILBI, ref Unity.Entities.Chunk DAJPMMDPFFK, int CADJDPODOGC, in ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3487440", Offset = "0x3485C40", VA = "0x183487440")]
	protected global::JEJFKOFAHMJ<Protobuf> HLMJEELKPCB<Protobuf>(ReadOnlySpan<Data> CFFIGFCFHML) where Protobuf : IMessage, new()
	{
		return default(global::JEJFKOFAHMJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3487490", Offset = "0x3485C90", VA = "0x183487490")]
	protected global::NLLCKIPODDA<Protobuf> MLGDHNFOIIE<Protobuf>(ReadOnlySpan<byte> AHJGIIFAPKK, ReadOnlySpan<Data> CFFIGFCFHML, Action<Protobuf> NAHFFDPOJND) where Protobuf : IMessage, new()
	{
		return default(global::NLLCKIPODDA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2FD7A60", Offset = "0x2FD6260", VA = "0x182FD7A60")]
	protected DOEJIAOMGPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class CNGICFHGNIC
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	protected internal abstract int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x560ED80", Offset = "0x560D580", VA = "0x18560ED80", Slot = "5")]
	internal virtual bool GAOBNPLOLGE(ref Unity.Entities.Chunk DAJPMMDPFFK, int CADJDPODOGC, NGNDNHAGNEP HDMBHNNBEPE, out ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x65E740", Offset = "0x65CF40", VA = "0x18065E740", Slot = "6")]
	internal virtual bool IMBMNGNFONL(int LDFDMKAILBI, ref Unity.Entities.Chunk DAJPMMDPFFK, int CADJDPODOGC, in ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	protected CNGICFHGNIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AMBIHNPKAHH
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[BurstCompile]
internal struct MFGAKFLIHNI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe Unity.Entities.EntityComponentStore* PNFONLNAGIC;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5612160", Offset = "0x5610960", VA = "0x185612160", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DPJJEADADHC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCKLJBOGDHK(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PDABNIBEMEG
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x396D060", Offset = "0x396B860", VA = "0x18396D060")]
	public static void ILKHMMPEJMI<T>(this ref T KKAHEDCANDC, ref ArchetypeChunkIterator DCHHMAHGJJP) where T : struct, DPJJEADADHC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x396CE50", Offset = "0x396B650", VA = "0x18396CE50")]
	public static void ILKHMMPEJMI<T>(this ref T KKAHEDCANDC, EntityQuery DCADDJLDIDL) where T : struct, DPJJEADADHC
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BMGPDHOLFGN
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x560E640", Offset = "0x560CE40", VA = "0x18560E640")]
	public static bool FGHGDDCGNGP(Type BCFKLEGAMEO, Type MKLOCAHDMDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal abstract class AKHIKMNMOHA<Attribute, BaseClass> : global::GHCPKNJFHMN<BaseClass>, PHGLGJMJAAI where Attribute : ICAMLLOKIIC
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly JJLACLCEPON MNIOACBCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string FOGNBJMCDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<int, Type> AEHNMNFFCJG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3ECE5A0", Offset = "0x3ECCDA0", VA = "0x183ECE5A0")]
	public AKHIKMNMOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3ECDFC0", Offset = "0x3ECC7C0", VA = "0x183ECDFC0", Slot = "4")]
	public bool CBBIGPLMGHA(int NDBJIKBMPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3ECE1C0", Offset = "0x3ECC9C0", VA = "0x183ECE1C0", Slot = "5")]
	public global::GEDPBPAGPNN<BaseClass> JKLLBHNMNFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3ECE020", Offset = "0x3ECC820", VA = "0x183ECE020", Slot = "7")]
	protected virtual bool FGHGDDCGNGP(Type BCFKLEGAMEO, int PBDMFBIJKBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3ECE4B0", Offset = "0x3ECCCB0", VA = "0x183ECE4B0", Slot = "8")]
	protected virtual int PEBHAKLAOHB(Type BCFKLEGAMEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3ECE470", Offset = "0x3ECCC70", VA = "0x183ECE470")]
	public void LAFCMKKIOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3ECE120", Offset = "0x3ECC920", VA = "0x183ECE120", Slot = "6")]
	public void IIGIGLNPDMN(Type BCFKLEGAMEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GEDPBPAGPNN<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<int, BaseClass> KBKMBFCBOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<Type, BaseClass> LDIONKBICDE;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IEnumerable<BaseClass> NONGEGFENBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4689F60", Offset = "0x4688760", VA = "0x184689F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x468A190", Offset = "0x4688990", VA = "0x18468A190")]
	public GEDPBPAGPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x468A320", Offset = "0x4688B20", VA = "0x18468A320")]
	public GEDPBPAGPNN(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4689E10", Offset = "0x4688610", VA = "0x184689E10")]
	internal void CEMPCIEDPMO(int NDBJIKBMPCB, BaseClass EDLBGDJBDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x34883D0", Offset = "0x3486BD0", VA = "0x1834883D0")]
	public bool EHKNBOOAJPO<T>(out BaseClass CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4689EC0", Offset = "0x46886C0", VA = "0x184689EC0")]
	public bool EHKNBOOAJPO(Type FMNFFKMHMLD, out BaseClass CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9010", Offset = "0x2FC7810", VA = "0x182FC9010")]
	public bool MNEPMBECLIM(int NDBJIKBMPCB, out BaseClass CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x34882F0", Offset = "0x3486AF0", VA = "0x1834882F0")]
	public T CONPOHNAHMN<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4689E90", Offset = "0x4688690", VA = "0x184689E90")]
	public BaseClass CONPOHNAHMN(Type AAJLGHCKCNC)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class LGGPJCAKOEJ : global::AKHIKMNMOHA<APCNEFCKKAN, APKLEDPALBD>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x56113C0", Offset = "0x560FBC0", VA = "0x1856113C0")]
	public LGGPJCAKOEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class IAOGMCMEHFA : global::AKHIKMNMOHA<JFHDNGNMLHA, CMKIKNDBPFM>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x560F1C0", Offset = "0x560D9C0", VA = "0x18560F1C0")]
	public IAOGMCMEHFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class NFKGLONDAHI : global::AKHIKMNMOHA<OBPEJBMLPEP, CNGICFHGNIC>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x56122B0", Offset = "0x5610AB0", VA = "0x1856122B0")]
	public NFKGLONDAHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct IEIHKMEDFKI
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly JJLACLCEPON MNIOACBCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Type> CEJOIBBGIME;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x757A80", Offset = "0x756280", VA = "0x180757A80")]
	private IEIHKMEDFKI(List<Type> CEJOIBBGIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x560F2B0", Offset = "0x560DAB0", VA = "0x18560F2B0")]
	public static void LAFCMKKIOHM(List<Type> CEJOIBBGIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x560F340", Offset = "0x560DB40", VA = "0x18560F340")]
	private void LBMALNMILEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x560F230", Offset = "0x560DA30", VA = "0x18560F230")]
	private bool FGHGDDCGNGP(Type BCFKLEGAMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x560F550", Offset = "0x560DD50", VA = "0x18560F550")]
	private void OCIOJBMFDPB(Type BCFKLEGAMEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface GHCPKNJFHMN<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBBIGPLMGHA(int NDBJIKBMPCB);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::GEDPBPAGPNN<BaseClass> JKLLBHNMNFM();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class NKMCJEEJMOK : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960")]
	protected NKMCJEEJMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class OFMIDBOIMPP : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960")]
	protected OFMIDBOIMPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class NFJLGLCMLLI : NKMCJEEJMOK
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5612280", Offset = "0x5610A80", VA = "0x185612280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	protected void JIIPOKCPALK(string NLDGIOOAAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960")]
	protected NFJLGLCMLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[HPLMCJEDJJG(KOEAPPNBOCD.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5612F80", Offset = "0x5611780", VA = "0x185612F80")]
		public static ComponentSystemGroup[] LGLEOEPINFK(World EAMEDKLPJKC, JLBHPEHJCKF GCNBGLBDJPB = JLBHPEHJCKF.Default, bool DADHBAADNID = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5613050", Offset = "0x5611850", VA = "0x185613050")]
		private static Type[] NMHHOCLELKK(JLBHPEHJCKF GCNBGLBDJPB, bool DADHBAADNID, ComponentSystemGroup[] OPPBCPADHDG, ComponentSystemGroup POOKNIMFKGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x56133B0", Offset = "0x5611BB0", VA = "0x1856133B0")]
		private static ComponentSystemGroup[] NPBMEFACDIB(World EAMEDKLPJKC, out ComponentSystemGroup POOKNIMFKGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5612600", Offset = "0x5610E00", VA = "0x185612600")]
		internal static bool AAHHBLPJIHM(CCPAEMCMCPC ALKHBOMOJMO, out EOAAJGFHLFL NFJKJJNJJGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5612850", Offset = "0x5611050", VA = "0x185612850")]
		private static ComponentSystemGroup ACLECPACGBE(Type BCFKLEGAMEO, World EAMEDKLPJKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5612E50", Offset = "0x5611650", VA = "0x185612E50")]
		private static ComponentSystemGroup[] EKCJADHEMOJ(Type[] CEJOIBBGIME, World EAMEDKLPJKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5612930", Offset = "0x5611130", VA = "0x185612930")]
		internal static void DKGLLICEEBE(World EAMEDKLPJKC, Type[] HFENGLLDHPK, ComponentSystemGroup[] OPPBCPADHDG, ComponentSystemGroup POOKNIMFKGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x56125A0", Offset = "0x5610DA0", VA = "0x1856125A0")]
		internal static bool AAAEGIHIAEK(ComponentSystemBase HMIDBHHAMPJ, ComponentSystemGroup[] OPPBCPADHDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x56136C0", Offset = "0x5611EC0", VA = "0x1856136C0")]
		private static void ODBNIBPBFIP(ComponentSystemGroup[] OPPBCPADHDG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct AOINGOGNEHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly Dictionary<Type, List<Type>> LKLGFOHBMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly HashSet<Type> PLPMKPECLOE;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x749D50", Offset = "0x748550", VA = "0x180749D50")]
	public AOINGOGNEHH(Dictionary<Type, List<Type>> LKLGFOHBMCF, HashSet<Type> PLPMKPECLOE)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[HPLMCJEDJJG(KOEAPPNBOCD.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class KCBNBEAMKPF : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private Type <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private IEnumerable<Type> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IEnumerable<Type> <>3__types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public RRFilterWorldSystems <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public RRFilterWorldSystems <>3__<>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private IEnumerator<Type> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Type IEnumerator<Type>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7F54B0", Offset = "0x7F3CB0", VA = "0x1807F54B0")]
			[DebuggerHidden]
			public KCBNBEAMKPF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5611240", Offset = "0x560FA40", VA = "0x185611240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x5610FA0", Offset = "0x560F7A0", VA = "0x185610FA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x56112D0", Offset = "0x560FAD0", VA = "0x1856112D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5611200", Offset = "0x560FA00", VA = "0x185611200", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5611150", Offset = "0x560F950", VA = "0x185611150", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5611150", Offset = "0x560F950", VA = "0x185611150", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct EBNJNLDBGEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Type COGKPEADMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private JLBHPEHJCKF GCNBGLBDJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool HIOIJEJLHHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool CHMJCIKHDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool DADHBAADNID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IEnumerable<Type> KJKGEDCMFNI;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5613CE0", Offset = "0x56124E0", VA = "0x185613CE0")]
		public static RRFilterWorldSystems MFNJFAEBAIM()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x56137B0", Offset = "0x5611FB0", VA = "0x1856137B0")]
		public RRFilterWorldSystems AKMLOGGNDLB(JLBHPEHJCKF ALKHBOMOJMO)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x56137C0", Offset = "0x5611FC0", VA = "0x1856137C0")]
		public RRFilterWorldSystems BGGHEANDMGJ(IEnumerable<Type> CEJOIBBGIME)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5613800", Offset = "0x5612000", VA = "0x185613800")]
		public RRFilterWorldSystems DGNBCBJFNEN(bool IHABDGIMEPJ)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5613920", Offset = "0x5612120", VA = "0x185613920")]
		public RRFilterWorldSystems INJOEAAOMAG(bool PODDHCIEBGB)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5614340", Offset = "0x5612B40", VA = "0x185614340")]
		public AOINGOGNEHH NMNMPNCNEIE(Type[] CGKMBNDCNFN)
		{
			return default(AOINGOGNEHH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5613A90", Offset = "0x5612290", VA = "0x185613A90")]
		[IteratorStateMachine(typeof(KCBNBEAMKPF))]
		internal IEnumerable<Type> KIBBJPPFMJL(IEnumerable<Type> CEJOIBBGIME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x56143D0", Offset = "0x5612BD0", VA = "0x1856143D0")]
		internal Dictionary<Type, List<Type>> PJFPOJOCKOE(IEnumerable<Type> CEJOIBBGIME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5613810", Offset = "0x5612010", VA = "0x185613810")]
		private void DLEONILAGPB(Dictionary<Type, List<Type>> HFOEOPEIJAG, Type BCFKLEGAMEO, Type ANLGMMGCPNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5613B20", Offset = "0x5612320", VA = "0x185613B20")]
		internal HashSet<Type> LPAFBKNEGBC(IEnumerable<Type> OPPBCPADHDG, Dictionary<Type, List<Type>> OOOLCIHHFKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5613D00", Offset = "0x5612500", VA = "0x185613D00")]
		internal bool MKKFGKBCAMG(Type BCFKLEGAMEO, JLBHPEHJCKF GCNBGLBDJPB, bool DADHBAADNID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5613930", Offset = "0x5612130", VA = "0x185613930")]
		[CompilerGenerated]
		internal static void JFBEMPPLHED(Type BCFKLEGAMEO, ref EBNJNLDBGEL P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class JBEPDHEECKB
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static bool AGJJECGFOAH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x560F5F0", Offset = "0x560DDF0", VA = "0x18560F5F0")]
	public static void CDFKCHBFAME(bool MJJPNLBDKFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x560F650", Offset = "0x560DE50", VA = "0x18560F650")]
	private static void EGFNKMJJNFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class ECLDHAHOJMI
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x560EDA0", Offset = "0x560D5A0", VA = "0x18560EDA0")]
	public static ulong NNODHPBNGAJ(Type BCFKLEGAMEO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x560EDD0", Offset = "0x560D5D0", VA = "0x18560EDD0")]
	public static ulong NNODHPBNGAJ(string GNBDBAGEFNC)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[HPLMCJEDJJG(KOEAPPNBOCD.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private struct NNPACEMCKMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public readonly ulong KLDEOKFJJBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public readonly ulong ALDMIGNJEHG;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xC018C0", Offset = "0xC000C0", VA = "0x180C018C0")]
			public NNPACEMCKMB(ulong NJDHKMODOMG, ulong AOEEJHOLDAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5612320", Offset = "0x5610B20", VA = "0x185612320", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static Dictionary<ulong, int> CGFDFDJJPIP;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static NNPACEMCKMB[] HBFKDKGFLDK;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static bool AGJJECGFOAH;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5614D90", Offset = "0x5613590", VA = "0x185614D90")]
		public static ulong EKKHLIJDJMB(int NDBJIKBMPCB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5614FC0", Offset = "0x56137C0", VA = "0x185614FC0")]
		public static int IDPIEAGMHPE(ulong AOEEJHOLDAN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x56147F0", Offset = "0x5612FF0", VA = "0x1856147F0")]
		public static void CDFKCHBFAME(bool MJJPNLBDKFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5614ED0", Offset = "0x56136D0", VA = "0x185614ED0")]
		private static void HAAECKMNDCM(int ALHKJNKNMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5614A70", Offset = "0x5613270", VA = "0x185614A70")]
		private static void DJNCOOHOGBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5615290", Offset = "0x5613A90", VA = "0x185615290")]
		private static NNPACEMCKMB LPJKJDHGCAF(Type BCFKLEGAMEO)
		{
			return default(NNPACEMCKMB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5614780", Offset = "0x5612F80", VA = "0x185614780")]
		private static ulong ACLPIBHPIGN(Type BCFKLEGAMEO, ulong AOEEJHOLDAN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5615070", Offset = "0x5613870", VA = "0x185615070")]
		private static void KBGABCBFJCE(in NNPACEMCKMB OBNMPMJCFKL, TypeManager.TypeInfo MGOBGJBJEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5615370", Offset = "0x5613B70", VA = "0x185615370")]
		private static void OPLOMJOPBGE(NNPACEMCKMB MGOBGJBJEIG, int NDBJIKBMPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5614DF0", Offset = "0x56135F0", VA = "0x185614DF0")]
		private static void GBIKKDHPGGO(NNPACEMCKMB MGOBGJBJEIG, int NDBJIKBMPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x56149E0", Offset = "0x56131E0", VA = "0x1856149E0")]
		private static NNPACEMCKMB CKIPDIAKMFN(int NDBJIKBMPCB)
		{
			return default(NNPACEMCKMB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5614FB0", Offset = "0x56137B0", VA = "0x185614FB0")]
		private static int HEMPPIPHKBK(int NDBJIKBMPCB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LPPHHMEKIAG
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly IAOGMCMEHFA NHLCLNBBKKK;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly NFKGLONDAHI LPCFPMJINJK;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly LGGPJCAKOEJ COMHAKGDOJE;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly List<Type> BBPCDFLKAGA;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static bool AGJJECGFOAH;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	internal static global::GHCPKNJFHMN<CMKIKNDBPFM> AEPFNMJEDHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5611960", Offset = "0x5610160", VA = "0x185611960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal static global::GHCPKNJFHMN<CNGICFHGNIC> IIJHJDGKNFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5611ED0", Offset = "0x56106D0", VA = "0x185611ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal static global::GHCPKNJFHMN<APKLEDPALBD> OPOFJMBEEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5611E70", Offset = "0x5610670", VA = "0x185611E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x56119C0", Offset = "0x56101C0", VA = "0x1856119C0")]
	public static void CDFKCHBFAME(bool MJJPNLBDKFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x56118E0", Offset = "0x56100E0", VA = "0x1856118E0")]
	public static Type[] BCBJAOBEHGP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AOFMIPEMIEM
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly Dictionary<int, int> IKBOGPABCCM;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool AGJJECGFOAH;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x560DB90", Offset = "0x560C390", VA = "0x18560DB90")]
	public static int JGEKIAPOFNF(int NDBJIKBMPCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x560DAF0", Offset = "0x560C2F0", VA = "0x18560DAF0")]
	public static void CDFKCHBFAME(bool MJJPNLBDKFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x560DD00", Offset = "0x560C500", VA = "0x18560DD00")]
	private static void PDHDNMPBLBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x560DC30", Offset = "0x560C430", VA = "0x18560DC30")]
	private static int LDIIPMMBCDA(Type BCFKLEGAMEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x560DC80", Offset = "0x560C480", VA = "0x18560DC80")]
	private static void OJEEPLKEKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class JIGACBOPBKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly World EAMEDKLPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly World NHKJKBOJALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly BJBGOMFMFBL EDLBGDJBDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly ComponentSystemGroup[] OPPBCPADHDG;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public World LJFDDHDKJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public World BGELJNJGDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EntityManager FHACAKFHJON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x11C1BE0", Offset = "0x11C03E0", VA = "0x1811C1BE0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public BJBGOMFMFBL NPECBMJOKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public global::GEDPBPAGPNN<CMKIKNDBPFM> AEPFNMJEDHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B40", Offset = "0x6F4340", VA = "0x1806F5B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A70", Offset = "0x6F4270", VA = "0x1806F5A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public global::GEDPBPAGPNN<CNGICFHGNIC> IIJHJDGKNFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x726A30", Offset = "0x725230", VA = "0x180726A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x726A50", Offset = "0x725250", VA = "0x180726A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public global::GEDPBPAGPNN<APKLEDPALBD> OPOFJMBEEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x746CE0", Offset = "0x7454E0", VA = "0x180746CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x74A6B0", Offset = "0x748EB0", VA = "0x18074A6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> BKOIEKNNDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x11C1C20", Offset = "0x11C0420", VA = "0x1811C1C20")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x560FDC0", Offset = "0x560E5C0", VA = "0x18560FDC0")]
	public static JIGACBOPBKP EIIKGLCCJIN(string FOGNBJMCDMG, CCPAEMCMCPC ALKHBOMOJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5610260", Offset = "0x560EA60", VA = "0x185610260")]
	public JIGACBOPBKP(string FOGNBJMCDMG, CCPAEMCMCPC ALKHBOMOJMO = CCPAEMCMCPC.Simulation, JLBHPEHJCKF GCNBGLBDJPB = JLBHPEHJCKF.Default, bool MJJPNLBDKFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x560FE40", Offset = "0x560E640", VA = "0x18560FE40")]
	public ComponentSystemBase FGPJJIKHFEC(Type BCFKLEGAMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2E13A50", Offset = "0x2E12250", VA = "0x182E13A50")]
	public T FGPJJIKHFEC<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x560FCF0", Offset = "0x560E4F0", VA = "0x18560FCF0")]
	public void DNGEACFPCPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x56101A0", Offset = "0x560E9A0", VA = "0x1856101A0")]
	public void OMDNOALHCJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x560FE60", Offset = "0x560E660", VA = "0x18560FE60")]
	public void JCGBBONJCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x560FC90", Offset = "0x560E490", VA = "0x18560FC90")]
	public void DGLLKHNGIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x560F960", Offset = "0x560E160", VA = "0x18560F960")]
	public void BPLDMKHFMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5610110", Offset = "0x560E910", VA = "0x185610110")]
	public void OCEBCFDMLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x56100B0", Offset = "0x560E8B0", VA = "0x1856100B0")]
	public void OADPHJAFBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x560F880", Offset = "0x560E080", VA = "0x18560F880")]
	public void AMFOIDAJGNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x560FEC0", Offset = "0x560E6C0", VA = "0x18560FEC0")]
	internal void KDICLELKEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x560F8E0", Offset = "0x560E0E0", VA = "0x18560F8E0")]
	private bool BGPMMPIFEIC(ComponentSystemGroup LGCEOGAHLEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x560F9C0", Offset = "0x560E1C0", VA = "0x18560F9C0")]
	private void DBGMBMHCEDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x560FFA0", Offset = "0x560E7A0", VA = "0x18560FFA0")]
	private ComponentSystemGroup[] LGLEOEPINFK(JLBHPEHJCKF GCNBGLBDJPB, bool DADHBAADNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5610200", Offset = "0x560EA00", VA = "0x185610200")]
	public void PPFJHNNOEMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x560FD50", Offset = "0x560E550", VA = "0x18560FD50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
public enum CCPAEMCMCPC
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Game = 5,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[AttributeUsage(AttributeTargets.Class)]
public sealed class ONGIMCLMJBG : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public JLBHPEHJCKF GHLHDJOFKLJ;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Flags]
public enum JLBHPEHJCKF
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	GameObjectConversion = 0x30,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	EntitySceneOptimizations = 4,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	ProcessAfterLoad = 8,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	HybridGameObjectConversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	DotsRuntimeGameObjectConversion = 0x20
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface EOAAJGFHLFL
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	Type CGJAADBHIED
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Type[] CKDBLNKNMKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class IKLMELFJGAF : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public virtual bool CIIHELJFMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x76F270", Offset = "0x76DA70", VA = "0x18076F270", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	protected IKLMELFJGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DisableAutoCreation]
public sealed class PJKOLMEHIFH : IKLMELFJGAF
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public PJKOLMEHIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DisableAutoCreation]
public sealed class DMBHLIDHMGJ : IKLMELFJGAF
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public DMBHLIDHMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DisableAutoCreation]
public sealed class HFGEIHKLDGF : IKLMELFJGAF
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public HFGEIHKLDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DisableAutoCreation]
public sealed class JCBICFNBBEL : IKLMELFJGAF
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public JCBICFNBBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DisableAutoCreation]
public sealed class HFPDGCKDHLP : IKLMELFJGAF
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public HFPDGCKDHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DisableAutoCreation]
public sealed class CKOMBPJODGO : IKLMELFJGAF
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public override bool CIIHELJFMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x65E740", Offset = "0x65CF40", VA = "0x18065E740", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public CKOMBPJODGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[AttributeUsage(AttributeTargets.Class)]
public class MGJNHNIALFH : KFLPBOMAPGE
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public MGJNHNIALFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class BMBCGNPBIOP
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate void JPAKPFGODAC<From, To>(From EADBNCPOLHD, ref To JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class JKFBGPCOGDF<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static JPAKPFGODAC<From, To> AGHAIFCGLOG;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public JKFBGPCOGDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x560E460", Offset = "0x560CC60", VA = "0x18560E460")]
	static BMBCGNPBIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3554A90", Offset = "0x3553290", VA = "0x183554A90")]
	public static void BJBPPFJFNHB<T>(JPAKPFGODAC<T, T> KJFHEJJKNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3554970", Offset = "0x3553170", VA = "0x183554970")]
	public static void BJBPPFJFNHB<From, To>(JPAKPFGODAC<From, To> KJFHEJJKNFD, JPAKPFGODAC<To, From> POJOKDKEAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3554920", Offset = "0x3553120", VA = "0x183554920")]
	public static void BJBPPFJFNHB<From, To>(JPAKPFGODAC<From, To> AGHAIFCGLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3550040", Offset = "0x354E840", VA = "0x183550040")]
	public static JPAKPFGODAC<From, To> BANNGHIDLMB<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x35565B0", Offset = "0x3554DB0", VA = "0x1835565B0")]
	public static void GDHIBEDPMBB<From, To>(From EADBNCPOLHD, ref To JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class NGNDNHAGNEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> BLANLCCIJII;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1B17C50", Offset = "0x1B16450", VA = "0x181B17C50")]
	public NGNDNHAGNEP(NativeArray<EntityRemapUtility.EntityRemapInfo> BLANLCCIJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3A98D60", Offset = "0x3A97560", VA = "0x183A98D60")]
	public Entity MNPNHMEHAHO(Entity LENKHFNFMLN)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class OMHKBLMMOCB
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Dictionary<(ulong hash, uint version), string> LOAGJFKHJGI;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x56123B0", Offset = "0x5610BB0", VA = "0x1856123B0")]
	public static bool PCMBEFEOPFK(ulong FPALDDOOOME, uint LDFDMKAILBI, out string FOGNBJMCDMG)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Serialization, new string[] { "Timing", "Deprecated", "Types", "Archetypes" })]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private struct BCIAPKGJAOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int DCEMEBHPCBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int ONIBILKIFBC;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7E5420", Offset = "0x7E3C20", VA = "0x1807E5420")]
			public BCIAPKGJAOH(int MMABPPDCBIB, int LDFDMKAILBI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct CNENDCHGLAA
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private static Stopwatch GFEIFEIINNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private long EIAHNAFDEHI;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public long AEGLNCNFNBK
			{
				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x560EBF0", Offset = "0x560D3F0", VA = "0x18560EBF0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public long MENIPLHPEIA
			{
				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x560EC50", Offset = "0x560D450", VA = "0x18560EC50")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x560ECC0", Offset = "0x560D4C0", VA = "0x18560ECC0")]
			public static CNENDCHGLAA PNNGHFKIKEM()
			{
				return default(CNENDCHGLAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private struct JILHIEFJPBH : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public readonly struct HLMAGHIHCFL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public unsafe readonly Unity.Entities.Archetype* FIDHECLCDDD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public readonly ACENMIBMELP.HDELCEDHJBH.DNDKPIBOKLB JCALFPGNNCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public readonly NGNDNHAGNEP HDMBHNNBEPE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000079")]
				public readonly global::GEDPBPAGPNN<CNGICFHGNIC> BOPHPJCPNOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public readonly int CADJDPODOGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public readonly int IADGFBHBNBE;

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x560F160", Offset = "0x560D960", VA = "0x18560F160")]
				public unsafe HLMAGHIHCFL(Unity.Entities.Archetype* FIDHECLCDDD, ACENMIBMELP.HDELCEDHJBH.DNDKPIBOKLB JCALFPGNNCP, NGNDNHAGNEP HDMBHNNBEPE, global::GEDPBPAGPNN<CNGICFHGNIC> BOPHPJCPNOG, int CADJDPODOGC, int IADGFBHBNBE = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x560F110", Offset = "0x560D910", VA = "0x18560F110")]
				public HLMAGHIHCFL(in HLMAGHIHCFL PJDKPCLOECB, int IADGFBHBNBE)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public readonly HLMAGHIHCFL[] CFFIGFCFHML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public string[] GAKGOEIIGME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int KMCFLONJEGG;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x5610E60", Offset = "0x560F660", VA = "0x185610E60")]
			public JILHIEFJPBH(HLMAGHIHCFL[] CFFIGFCFHML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x5610B30", Offset = "0x560F330", VA = "0x185610B30", Slot = "4")]
			public void Invoke(int MMABPPDCBIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x5610780", Offset = "0x560EF80", VA = "0x185610780")]
			private void HJEHNBEAEOM(in HLMAGHIHCFL PJDKPCLOECB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5610B90", Offset = "0x560F390", VA = "0x185610B90")]
			private static void KMPFOPEGEFG(in HLMAGHIHCFL PJDKPCLOECB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class KKJBDJGOLKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ACENMIBMELP asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public global::GEDPBPAGPNN<CNGICFHGNIC> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public KKJBDJGOLKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x5611320", Offset = "0x560FB20", VA = "0x185611320")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class GMNFHDELHNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public ACENMIBMELP.HDELCEDHJBH.DNDKPIBOKLB srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public KKJBDJGOLKH CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public GMNFHDELHNF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class GAOPMFINGAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public GMNFHDELHNF CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public GAOPMFINGAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x560F000", Offset = "0x560D800", VA = "0x18560F000")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static JJLACLCEPON OAHFHFPLFKO;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static JJLACLCEPON KAGKFGLHHOM;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static JJLACLCEPON GPJABHJMALD;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static JJLACLCEPON DLOGGJGIGPJ;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static bool MDMJNEHAPKE;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static ACENMIBMELP.HDELCEDHJBH.JOPABAMGADP CACLCAFLFND;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x56171A0", Offset = "0x56159A0", VA = "0x1856171A0")]
		private unsafe static bool EOOPKFABOME(Unity.Entities.Archetype* CEMLDGMJKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5617980", Offset = "0x5616180", VA = "0x185617980")]
		internal unsafe static Unity.Entities.Archetype*[] HGNGHBLMPAL(ref Unity.Entities.EntityComponentStore PNFONLNAGIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5617EB0", Offset = "0x56166B0", VA = "0x185617EB0")]
		public static void MHGLAJHJKJG(JIGACBOPBKP EAMEDKLPJKC, out ByteString AHJGIIFAPKK, out NativeArray<EntityRemapUtility.EntityRemapInfo> PNALEACAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5615500", Offset = "0x5613D00", VA = "0x185615500")]
		internal static void ANEFFBHFJKB(JIGACBOPBKP EAMEDKLPJKC, ACENMIBMELP GFNKHHJBHOF, out NativeArray<EntityRemapUtility.EntityRemapInfo> PNALEACAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x56188D0", Offset = "0x56170D0", VA = "0x1856188D0")]
		private unsafe static UnsafeHashMap<ulong, BCIAPKGJAOH> PBEMKCGMMOI(Unity.Entities.Archetype*[] IJMNLHEBFLH)
		{
			return default(UnsafeHashMap<ulong, BCIAPKGJAOH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x56172B0", Offset = "0x5615AB0", VA = "0x1856172B0")]
		private static void FEBCOLOJEAM(ACENMIBMELP GFNKHHJBHOF, UnsafeHashMap<ulong, BCIAPKGJAOH> GEDPDIMCEON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5616680", Offset = "0x5614E80", VA = "0x185616680")]
		private unsafe static void CJEHBLKGKJJ(ACENMIBMELP GFNKHHJBHOF, Unity.Entities.Archetype*[] IJMNLHEBFLH, UnsafeHashMap<ulong, BCIAPKGJAOH> GEDPDIMCEON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5618860", Offset = "0x5617060", VA = "0x185618860")]
		private unsafe static int OPOHJFKGHNH(Unity.Entities.Archetype*[] IJMNLHEBFLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5616CE0", Offset = "0x56154E0", VA = "0x185616CE0")]
		private unsafe static void DENOGLNJOGO(ACENMIBMELP GFNKHHJBHOF, Unity.Entities.Archetype*[] IJMNLHEBFLH, global::GEDPBPAGPNN<CNGICFHGNIC> BOPHPJCPNOG, NativeArray<EntityRemapUtility.EntityRemapInfo> PNALEACAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5617C40", Offset = "0x5616440", VA = "0x185617C40")]
		private static NativeArray<int> LOAKHHHACIN(ACENMIBMELP GFNKHHJBHOF)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5617460", Offset = "0x5615C60", VA = "0x185617460")]
		private static Memory<EntityArchetype> GGFBFOHIDNC(ACENMIBMELP GFNKHHJBHOF, NativeArray<int> CEJOIBBGIME, EntityManager JGGNCNMICJO, out int CEFIPBPEBII, out int BKIMMFEFLKA)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5618B60", Offset = "0x5617360", VA = "0x185618B60")]
		private unsafe static void PNIDHNKHBGP(Unity.Entities.Chunk* LHKKDLIBMLE, ReadOnlySpan<byte> AHJGIIFAPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5615C30", Offset = "0x5614430", VA = "0x185615C30")]
		private static void BMAFLMLOHDL(ACENMIBMELP GFNKHHJBHOF, NativeArray<int> CEJOIBBGIME, Span<EntityArchetype> IJMNLHEBFLH, EntityManager JGGNCNMICJO, global::GEDPBPAGPNN<CNGICFHGNIC> BOPHPJCPNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x56169B0", Offset = "0x56151B0", VA = "0x1856169B0")]
		private unsafe static void CPKJNPLFCNE(Unity.Entities.Chunk* DAJPMMDPFFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5616370", Offset = "0x5614B70", VA = "0x185616370")]
		private unsafe static void CDECIJFPJDK(ACENMIBMELP.HDELCEDHJBH.DNDKPIBOKLB FIDHECLCDDD, int NFHFFAABIOC, int PFILCINOEJO, Unity.Entities.Chunk* LHKKDLIBMLE, ACENMIBMELP GFNKHHJBHOF, NativeArray<int> CEJOIBBGIME, global::GEDPBPAGPNN<CNGICFHGNIC> BOPHPJCPNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5618510", Offset = "0x5616D10", VA = "0x185618510")]
		public static void MLFHPHHNPOI(JIGACBOPBKP EAMEDKLPJKC, in ByteString AHJGIIFAPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5617F70", Offset = "0x5616770", VA = "0x185617F70")]
		public static void MLFHPHHNPOI(EntityManager JGGNCNMICJO, global::GEDPBPAGPNN<CNGICFHGNIC> BOPHPJCPNOG, in ByteString AHJGIIFAPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x56185A0", Offset = "0x5616DA0", VA = "0x1856185A0")]
		private static bool NECAHBEBMHJ(Type BCFKLEGAMEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5616A30", Offset = "0x5615230", VA = "0x185616A30")]
		private static void DBDCEAIAMDF(TypeManager.TypeInfo MGOBGJBJEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x56177F0", Offset = "0x5615FF0", VA = "0x1856177F0")]
		private unsafe static int GNNHEIGPNPN(Unity.Entities.Archetype*[] IJMNLHEBFLH, NativeArray<EntityRemapUtility.EntityRemapInfo> PNALEACAIBD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5617B60", Offset = "0x5616360", VA = "0x185617B60")]
		private static int JGEKIAPOFNF(int NDBJIKBMPCB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5617100", Offset = "0x5615900", VA = "0x185617100")]
		private static ulong EKKHLIJDJMB(int NDBJIKBMPCB)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class LJNBFBKFDBC
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5611430", Offset = "0x560FC30", VA = "0x185611430")]
	private unsafe static Span<byte> FFFPIKEPCBE(Unity.Entities.Chunk* DAJPMMDPFFK, int CADJDPODOGC)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x36B4C10", Offset = "0x36B3410", VA = "0x1836B4C10")]
	public unsafe static Span<T> JPILOPFDBKO<T>(Unity.Entities.Chunk* DAJPMMDPFFK, int CADJDPODOGC)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x36B4D90", Offset = "0x36B3590", VA = "0x1836B4D90")]
	public static Span<T> JPILOPFDBKO<T>(this ref Unity.Entities.Chunk DAJPMMDPFFK, int CADJDPODOGC)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x56115D0", Offset = "0x560FDD0", VA = "0x1856115D0")]
	public unsafe static Span<Entity> LLPHPEHOGAO(Unity.Entities.Chunk* DAJPMMDPFFK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5611640", Offset = "0x560FE40", VA = "0x185611640")]
	public unsafe static void OJEEPLKEKIC(Unity.Entities.Chunk* DAJPMMDPFFK, int CADJDPODOGC)
	{
	}
}
namespace RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[Preserve]
	internal class _RRAssemblyIndex : NBDBIEGIKFP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5619110", Offset = "0x5617910", VA = "0x185619110", Slot = "4")]
		public sealed override void LAFCMKKIOHM()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class BAADKGJHJEL
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static byte[] ANBHIGGKLGA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int CIBDKMIJIHM;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static int HHBBDHEOEDG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static BigInteger JHIBJFGIFBI;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BAADKGJHJEL()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
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

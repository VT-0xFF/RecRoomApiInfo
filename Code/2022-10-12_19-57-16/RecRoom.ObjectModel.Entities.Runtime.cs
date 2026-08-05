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
	[Cpp2IlInjected.Address(RVA = "0x5488770", Offset = "0x5487770", VA = "0x185488770")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> DCOHPDIDCFN(this ref Unity.Entities.Archetype CEMLDGMJKAJ)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MPEDNAHLNOA
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x548BAF0", Offset = "0x548AAF0", VA = "0x18548BAF0")]
	public static Span<int> KBCNCPMMOBN(this EntityArchetype CEMLDGMJKAJ)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FCEKALIGIGP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x54888C0", Offset = "0x54878C0", VA = "0x1854888C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x66B040", Offset = "0x66A040", VA = "0x18066B040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D92D90", Offset = "0x2D91D90", VA = "0x182D92D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2015CB0", Offset = "0x2014CB0", VA = "0x182015CB0")]
		[DebuggerHidden]
		public ONPMLBHHBCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2D92BB0", Offset = "0x2D91BB0", VA = "0x182D92BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2D92D50", Offset = "0x2D91D50", VA = "0x182D92D50", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A010", Offset = "0x649010", VA = "0x18064A010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2E1A030", Offset = "0x2E19030", VA = "0x182E1A030")]
	private NLLCKIPODDA(byte[] NCCOCLJLPFP, Action<Protobuf> NAHFFDPOJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C4EA00", Offset = "0x3C4DA00", VA = "0x183C4EA00")]
	public static global::NLLCKIPODDA<Protobuf> MFNJFAEBAIM<Data>(ReadOnlySpan<byte> AHJGIIFAPKK, ReadOnlySpan<Data> CFFIGFCFHML, Action<Protobuf> NAHFFDPOJND)
	{
		return default(global::NLLCKIPODDA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2E19EA0", Offset = "0x2E18EA0", VA = "0x182E19EA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2E19EE0", Offset = "0x2E18EE0", VA = "0x182E19EE0", Slot = "4")]
	[IteratorStateMachine(typeof(global::NLLCKIPODDA<>.ONPMLBHHBCI))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2E19FE0", Offset = "0x2E18FE0", VA = "0x182E19FE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2339280", Offset = "0x2338280", VA = "0x182339280")]
	private JEJFKOFAHMJ(byte[] NCCOCLJLPFP, in Protobuf AKLHGPOFBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x258FC30", Offset = "0x258EC30", VA = "0x18258FC30")]
	public static global::JEJFKOFAHMJ<Protobuf> MFNJFAEBAIM<T>(ReadOnlySpan<T> CFFIGFCFHML)
	{
		return default(global::JEJFKOFAHMJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2339090", Offset = "0x2338090", VA = "0x182339090")]
	public void BPIIEOILJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x23391F0", Offset = "0x23381F0", VA = "0x1823391F0")]
	public ByteString KEBHENPFBNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x23390C0", Offset = "0x23380C0", VA = "0x1823390C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54890D0", Offset = "0x54880D0", VA = "0x1854890D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5487AB0", Offset = "0x5486AB0", VA = "0x185487AB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x66A130", Offset = "0x669130", VA = "0x18066A130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x54878B0", Offset = "0x54868B0", VA = "0x1854878B0")]
	public ICAMLLOKIIC(Type HLLKGOFBLCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class APCNEFCKKAN : ICAMLLOKIIC
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x54878B0", Offset = "0x54868B0", VA = "0x1854878B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66A140", Offset = "0x669140", VA = "0x18066A140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5489110", Offset = "0x5488110", VA = "0x185489110")]
	public JFHDNGNMLHA(Type PKAPEBBDLPF, Type HLLKGOFBLCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OBPEJBMLPEP : ICAMLLOKIIC
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x54878B0", Offset = "0x54868B0", VA = "0x1854878B0")]
	public OBPEJBMLPEP(Type HLLKGOFBLCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PAOAHFGMMNM : KFLPBOMAPGE
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A040", Offset = "0x649040", VA = "0x18064A040")]
		[CompilerGenerated]
		get
		{
			return default(CCPAEMCMCPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x548AC70", Offset = "0x5489C70", VA = "0x18548AC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5487CF0", Offset = "0x5486CF0", VA = "0x185487CF0")]
	public BJBGOMFMFBL(JIGACBOPBKP EAMEDKLPJKC, EntityManager JGGNCNMICJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5487BE0", Offset = "0x5486BE0", VA = "0x185487BE0")]
	public int EJCFOFCLJDG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2644110", Offset = "0x2643110", VA = "0x182644110")]
	public bool ECIEALCEEAH<T>(Entity GDNDJKDEKFN) where T : struct, ENOPOKMPGLP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2644150", Offset = "0x2643150", VA = "0x182644150")]
	public bool EODABGNJGDO<T>(Entity GDNDJKDEKFN, out T CCIMHDCKHOF) where T : struct, ENOPOKMPGLP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2642B80", Offset = "0x2641B80", VA = "0x182642B80")]
	public T ALGDCILMLGP<T>(Entity GDNDJKDEKFN) where T : struct, ENOPOKMPGLP
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x26441E0", Offset = "0x26431E0", VA = "0x1826441E0")]
	private ComponentType OAPHDJJJPHH<T>() where T : struct, ENOPOKMPGLP
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5487C20", Offset = "0x5486C20", VA = "0x185487C20")]
	private ComponentType OAPHDJJJPHH(Type BCFKLEGAMEO)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class APKLEDPALBD
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2371650", Offset = "0x2370650", VA = "0x182371650", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override Type LELGGEPEAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2372440", Offset = "0x2371440", VA = "0x182372440", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override int BBEKJFPLOPA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2370E80", Offset = "0x236FE80", VA = "0x182370E80", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2370E10", Offset = "0x236FE10", VA = "0x182370E10")]
	public Data ABBJNMLLLFL(Entity GDNDJKDEKFN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2370F40", Offset = "0x236FF40", VA = "0x182370F40")]
	public Data CMFIHFLKLHD(Entity GDNDJKDEKFN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected internal abstract View GMDCNFONIJE(Entity GDNDJKDEKFN);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2AD13C0", Offset = "0x2AD03C0", VA = "0x182AD13C0", Slot = "15")]
	protected internal override T GMDCNFONIJE<T>(Entity GDNDJKDEKFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2370FB0", Offset = "0x236FFB0", VA = "0x182370FB0", Slot = "16")]
	public override bool ECIEALCEEAH(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2065660", Offset = "0x2064660", VA = "0x182065660")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x826520", Offset = "0x825520", VA = "0x180826520")]
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
		[Cpp2IlInjected.Address(RVA = "0x783390", Offset = "0x782390", VA = "0x180783390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int MNCJDABOEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x54882E0", Offset = "0x54872E0", VA = "0x1854882E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private MIEGLNNJAGB[] MDPOBKFFLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7832C0", Offset = "0x7822C0", VA = "0x1807832C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	protected internal virtual MIEGLNNJAGB[] HCGNKDEPDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5488220", Offset = "0x5487220", VA = "0x185488220", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FNINHPMMKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x54884A0", Offset = "0x54874A0", VA = "0x1854884A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5488100", Offset = "0x5487100", VA = "0x185488100")]
	public void CDFKCHBFAME(EntityManager JGGNCNMICJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72A040", Offset = "0x729040", VA = "0x18072A040")]
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
	[Cpp2IlInjected.Address(RVA = "0x54883E0", Offset = "0x54873E0", VA = "0x1854883E0", Slot = "8")]
	public (uint, uint) JGEKIAPOFNF(Entity GDNDJKDEKFN)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5488350", Offset = "0x5487350", VA = "0x185488350", Slot = "9")]
	public bool IEJEPDBIIFG(Entity GDNDJKDEKFN, (uint order, uint change) LDFDMKAILBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E4DE50", Offset = "0x2E4CE50", VA = "0x182E4DE50", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x22204B0", Offset = "0x221F4B0", VA = "0x1822204B0", Slot = "8")]
	protected virtual bool GAOBNPLOLGE(ReadOnlySpan<Data> CFFIGFCFHML, NGNDNHAGNEP HDMBHNNBEPE, out ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00", Slot = "9")]
	protected virtual bool IMBMNGNFONL(int LDFDMKAILBI, Span<Data> CFFIGFCFHML, in ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C330", Offset = "0x2E4B330", VA = "0x182E4C330", Slot = "5")]
	internal sealed override bool GAOBNPLOLGE(ref Unity.Entities.Chunk DAJPMMDPFFK, int CADJDPODOGC, NGNDNHAGNEP HDMBHNNBEPE, out ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D3F0", Offset = "0x2E4C3F0", VA = "0x182E4D3F0", Slot = "6")]
	internal sealed override bool IMBMNGNFONL(int LDFDMKAILBI, ref Unity.Entities.Chunk DAJPMMDPFFK, int CADJDPODOGC, in ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x257DA30", Offset = "0x257CA30", VA = "0x18257DA30")]
	protected global::JEJFKOFAHMJ<Protobuf> HLMJEELKPCB<Protobuf>(ReadOnlySpan<Data> CFFIGFCFHML) where Protobuf : IMessage, new()
	{
		return default(global::JEJFKOFAHMJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x257DA80", Offset = "0x257CA80", VA = "0x18257DA80")]
	protected global::NLLCKIPODDA<Protobuf> MLGDHNFOIIE<Protobuf>(ReadOnlySpan<byte> AHJGIIFAPKK, ReadOnlySpan<Data> CFFIGFCFHML, Action<Protobuf> NAHFFDPOJND) where Protobuf : IMessage, new()
	{
		return default(global::NLLCKIPODDA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2065660", Offset = "0x2064660", VA = "0x182065660")]
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
	[Cpp2IlInjected.Address(RVA = "0x5488660", Offset = "0x5487660", VA = "0x185488660", Slot = "5")]
	internal virtual bool GAOBNPLOLGE(ref Unity.Entities.Chunk DAJPMMDPFFK, int CADJDPODOGC, NGNDNHAGNEP HDMBHNNBEPE, out ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00", Slot = "6")]
	internal virtual bool IMBMNGNFONL(int LDFDMKAILBI, ref Unity.Entities.Chunk DAJPMMDPFFK, int CADJDPODOGC, in ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
	[Cpp2IlInjected.Address(RVA = "0x548BA40", Offset = "0x548AA40", VA = "0x18548BA40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B05500", Offset = "0x2B04500", VA = "0x182B05500")]
	public static void ILKHMMPEJMI<T>(this ref T KKAHEDCANDC, ref ArchetypeChunkIterator DCHHMAHGJJP) where T : struct, DPJJEADADHC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2B052F0", Offset = "0x2B042F0", VA = "0x182B052F0")]
	public static void ILKHMMPEJMI<T>(this ref T KKAHEDCANDC, EntityQuery DCADDJLDIDL) where T : struct, DPJJEADADHC
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BMGPDHOLFGN
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5487F20", Offset = "0x5486F20", VA = "0x185487F20")]
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
	[Cpp2IlInjected.Address(RVA = "0x323DA00", Offset = "0x323CA00", VA = "0x18323DA00")]
	public AKHIKMNMOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x323D420", Offset = "0x323C420", VA = "0x18323D420", Slot = "4")]
	public bool CBBIGPLMGHA(int NDBJIKBMPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x323D620", Offset = "0x323C620", VA = "0x18323D620", Slot = "5")]
	public global::GEDPBPAGPNN<BaseClass> JKLLBHNMNFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x323D480", Offset = "0x323C480", VA = "0x18323D480", Slot = "7")]
	protected virtual bool FGHGDDCGNGP(Type BCFKLEGAMEO, int PBDMFBIJKBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x323D910", Offset = "0x323C910", VA = "0x18323D910", Slot = "8")]
	protected virtual int PEBHAKLAOHB(Type BCFKLEGAMEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x323D8D0", Offset = "0x323C8D0", VA = "0x18323D8D0")]
	public void LAFCMKKIOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x323D580", Offset = "0x323C580", VA = "0x18323D580", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EDF820", Offset = "0x3EDE820", VA = "0x183EDF820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3EDFA50", Offset = "0x3EDEA50", VA = "0x183EDFA50")]
	public GEDPBPAGPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3EDFBE0", Offset = "0x3EDEBE0", VA = "0x183EDFBE0")]
	public GEDPBPAGPNN(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF6D0", Offset = "0x3EDE6D0", VA = "0x183EDF6D0")]
	internal void CEMPCIEDPMO(int NDBJIKBMPCB, BaseClass EDLBGDJBDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x257E9C0", Offset = "0x257D9C0", VA = "0x18257E9C0")]
	public bool EHKNBOOAJPO<T>(out BaseClass CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF780", Offset = "0x3EDE780", VA = "0x183EDF780")]
	public bool EHKNBOOAJPO(Type FMNFFKMHMLD, out BaseClass CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2056C10", Offset = "0x2055C10", VA = "0x182056C10")]
	public bool MNEPMBECLIM(int NDBJIKBMPCB, out BaseClass CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x257E8E0", Offset = "0x257D8E0", VA = "0x18257E8E0")]
	public T CONPOHNAHMN<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF750", Offset = "0x3EDE750", VA = "0x183EDF750")]
	public BaseClass CONPOHNAHMN(Type AAJLGHCKCNC)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class LGGPJCAKOEJ : global::AKHIKMNMOHA<APCNEFCKKAN, APKLEDPALBD>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x548ACA0", Offset = "0x5489CA0", VA = "0x18548ACA0")]
	public LGGPJCAKOEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class IAOGMCMEHFA : global::AKHIKMNMOHA<JFHDNGNMLHA, CMKIKNDBPFM>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5488AA0", Offset = "0x5487AA0", VA = "0x185488AA0")]
	public IAOGMCMEHFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class NFKGLONDAHI : global::AKHIKMNMOHA<OBPEJBMLPEP, CNGICFHGNIC>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x548BB90", Offset = "0x548AB90", VA = "0x18548BB90")]
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
	[Cpp2IlInjected.Address(RVA = "0x87A620", Offset = "0x879620", VA = "0x18087A620")]
	private IEIHKMEDFKI(List<Type> CEJOIBBGIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5488B90", Offset = "0x5487B90", VA = "0x185488B90")]
	public static void LAFCMKKIOHM(List<Type> CEJOIBBGIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5488C20", Offset = "0x5487C20", VA = "0x185488C20")]
	private void LBMALNMILEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5488B10", Offset = "0x5487B10", VA = "0x185488B10")]
	private bool FGHGDDCGNGP(Type BCFKLEGAMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5488E30", Offset = "0x5487E30", VA = "0x185488E30")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
	protected NKMCJEEJMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class OFMIDBOIMPP : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
	protected OFMIDBOIMPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class NFJLGLCMLLI : NKMCJEEJMOK
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x548BB60", Offset = "0x548AB60", VA = "0x18548BB60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	protected void JIIPOKCPALK(string NLDGIOOAAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
	protected NFJLGLCMLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x548C860", Offset = "0x548B860", VA = "0x18548C860")]
		public static ComponentSystemGroup[] LGLEOEPINFK(World EAMEDKLPJKC, JLBHPEHJCKF GCNBGLBDJPB = JLBHPEHJCKF.Default, bool DADHBAADNID = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x548C930", Offset = "0x548B930", VA = "0x18548C930")]
		private static Type[] NMHHOCLELKK(JLBHPEHJCKF GCNBGLBDJPB, bool DADHBAADNID, ComponentSystemGroup[] OPPBCPADHDG, ComponentSystemGroup POOKNIMFKGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x548CC90", Offset = "0x548BC90", VA = "0x18548CC90")]
		private static ComponentSystemGroup[] NPBMEFACDIB(World EAMEDKLPJKC, out ComponentSystemGroup POOKNIMFKGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x548BEE0", Offset = "0x548AEE0", VA = "0x18548BEE0")]
		internal static bool AAHHBLPJIHM(CCPAEMCMCPC ALKHBOMOJMO, out EOAAJGFHLFL NFJKJJNJJGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x548C130", Offset = "0x548B130", VA = "0x18548C130")]
		private static ComponentSystemGroup ACLECPACGBE(Type BCFKLEGAMEO, World EAMEDKLPJKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x548C730", Offset = "0x548B730", VA = "0x18548C730")]
		private static ComponentSystemGroup[] EKCJADHEMOJ(Type[] CEJOIBBGIME, World EAMEDKLPJKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x548C210", Offset = "0x548B210", VA = "0x18548C210")]
		internal static void DKGLLICEEBE(World EAMEDKLPJKC, Type[] HFENGLLDHPK, ComponentSystemGroup[] OPPBCPADHDG, ComponentSystemGroup POOKNIMFKGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x548BE80", Offset = "0x548AE80", VA = "0x18548BE80")]
		internal static bool AAAEGIHIAEK(ComponentSystemBase HMIDBHHAMPJ, ComponentSystemGroup[] OPPBCPADHDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x548CFA0", Offset = "0x548BFA0", VA = "0x18548CFA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6FAA10", Offset = "0x6F9A10", VA = "0x1806FAA10")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E90", Offset = "0x8D5E90", VA = "0x1808D6E90")]
			[DebuggerHidden]
			public KCBNBEAMKPF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x548AB20", Offset = "0x5489B20", VA = "0x18548AB20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x548A880", Offset = "0x5489880", VA = "0x18548A880", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x548ABB0", Offset = "0x5489BB0", VA = "0x18548ABB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x548AAE0", Offset = "0x5489AE0", VA = "0x18548AAE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x548AA30", Offset = "0x5489A30", VA = "0x18548AA30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x548AA30", Offset = "0x5489A30", VA = "0x18548AA30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x548D5C0", Offset = "0x548C5C0", VA = "0x18548D5C0")]
		public static RRFilterWorldSystems MFNJFAEBAIM()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x548D090", Offset = "0x548C090", VA = "0x18548D090")]
		public RRFilterWorldSystems AKMLOGGNDLB(JLBHPEHJCKF ALKHBOMOJMO)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x548D0A0", Offset = "0x548C0A0", VA = "0x18548D0A0")]
		public RRFilterWorldSystems BGGHEANDMGJ(IEnumerable<Type> CEJOIBBGIME)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x548D0E0", Offset = "0x548C0E0", VA = "0x18548D0E0")]
		public RRFilterWorldSystems DGNBCBJFNEN(bool IHABDGIMEPJ)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x548D200", Offset = "0x548C200", VA = "0x18548D200")]
		public RRFilterWorldSystems INJOEAAOMAG(bool PODDHCIEBGB)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x548DC20", Offset = "0x548CC20", VA = "0x18548DC20")]
		public AOINGOGNEHH NMNMPNCNEIE(Type[] CGKMBNDCNFN)
		{
			return default(AOINGOGNEHH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x548D370", Offset = "0x548C370", VA = "0x18548D370")]
		[IteratorStateMachine(typeof(KCBNBEAMKPF))]
		internal IEnumerable<Type> KIBBJPPFMJL(IEnumerable<Type> CEJOIBBGIME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x548DCB0", Offset = "0x548CCB0", VA = "0x18548DCB0")]
		internal Dictionary<Type, List<Type>> PJFPOJOCKOE(IEnumerable<Type> CEJOIBBGIME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x548D0F0", Offset = "0x548C0F0", VA = "0x18548D0F0")]
		private void DLEONILAGPB(Dictionary<Type, List<Type>> HFOEOPEIJAG, Type BCFKLEGAMEO, Type ANLGMMGCPNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x548D400", Offset = "0x548C400", VA = "0x18548D400")]
		internal HashSet<Type> LPAFBKNEGBC(IEnumerable<Type> OPPBCPADHDG, Dictionary<Type, List<Type>> OOOLCIHHFKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x548D5E0", Offset = "0x548C5E0", VA = "0x18548D5E0")]
		internal bool MKKFGKBCAMG(Type BCFKLEGAMEO, JLBHPEHJCKF GCNBGLBDJPB, bool DADHBAADNID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x548D210", Offset = "0x548C210", VA = "0x18548D210")]
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
	[Cpp2IlInjected.Address(RVA = "0x5488ED0", Offset = "0x5487ED0", VA = "0x185488ED0")]
	public static void CDFKCHBFAME(bool MJJPNLBDKFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5488F30", Offset = "0x5487F30", VA = "0x185488F30")]
	private static void EGFNKMJJNFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class ECLDHAHOJMI
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5488680", Offset = "0x5487680", VA = "0x185488680")]
	public static ulong NNODHPBNGAJ(Type BCFKLEGAMEO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x54886B0", Offset = "0x54876B0", VA = "0x1854886B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF59900", Offset = "0xF58900", VA = "0x180F59900")]
			public NNPACEMCKMB(ulong NJDHKMODOMG, ulong AOEEJHOLDAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x548BC00", Offset = "0x548AC00", VA = "0x18548BC00", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x548E670", Offset = "0x548D670", VA = "0x18548E670")]
		public static ulong EKKHLIJDJMB(int NDBJIKBMPCB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x548E8A0", Offset = "0x548D8A0", VA = "0x18548E8A0")]
		public static int IDPIEAGMHPE(ulong AOEEJHOLDAN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x548E0D0", Offset = "0x548D0D0", VA = "0x18548E0D0")]
		public static void CDFKCHBFAME(bool MJJPNLBDKFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x548E7B0", Offset = "0x548D7B0", VA = "0x18548E7B0")]
		private static void HAAECKMNDCM(int ALHKJNKNMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x548E350", Offset = "0x548D350", VA = "0x18548E350")]
		private static void DJNCOOHOGBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x548EB70", Offset = "0x548DB70", VA = "0x18548EB70")]
		private static NNPACEMCKMB LPJKJDHGCAF(Type BCFKLEGAMEO)
		{
			return default(NNPACEMCKMB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x548E060", Offset = "0x548D060", VA = "0x18548E060")]
		private static ulong ACLPIBHPIGN(Type BCFKLEGAMEO, ulong AOEEJHOLDAN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x548E950", Offset = "0x548D950", VA = "0x18548E950")]
		private static void KBGABCBFJCE(in NNPACEMCKMB OBNMPMJCFKL, TypeManager.TypeInfo MGOBGJBJEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x548EC50", Offset = "0x548DC50", VA = "0x18548EC50")]
		private static void OPLOMJOPBGE(NNPACEMCKMB MGOBGJBJEIG, int NDBJIKBMPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x548E6D0", Offset = "0x548D6D0", VA = "0x18548E6D0")]
		private static void GBIKKDHPGGO(NNPACEMCKMB MGOBGJBJEIG, int NDBJIKBMPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x548E2C0", Offset = "0x548D2C0", VA = "0x18548E2C0")]
		private static NNPACEMCKMB CKIPDIAKMFN(int NDBJIKBMPCB)
		{
			return default(NNPACEMCKMB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x548E890", Offset = "0x548D890", VA = "0x18548E890")]
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
		[Cpp2IlInjected.Address(RVA = "0x548B240", Offset = "0x548A240", VA = "0x18548B240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal static global::GHCPKNJFHMN<CNGICFHGNIC> IIJHJDGKNFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x548B7B0", Offset = "0x548A7B0", VA = "0x18548B7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal static global::GHCPKNJFHMN<APKLEDPALBD> OPOFJMBEEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x548B750", Offset = "0x548A750", VA = "0x18548B750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x548B2A0", Offset = "0x548A2A0", VA = "0x18548B2A0")]
	public static void CDFKCHBFAME(bool MJJPNLBDKFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x548B1C0", Offset = "0x548A1C0", VA = "0x18548B1C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5487470", Offset = "0x5486470", VA = "0x185487470")]
	public static int JGEKIAPOFNF(int NDBJIKBMPCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x54873D0", Offset = "0x54863D0", VA = "0x1854873D0")]
	public static void CDFKCHBFAME(bool MJJPNLBDKFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x54875E0", Offset = "0x54865E0", VA = "0x1854875E0")]
	private static void PDHDNMPBLBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5487510", Offset = "0x5486510", VA = "0x185487510")]
	private static int LDIIPMMBCDA(Type BCFKLEGAMEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5487560", Offset = "0x5486560", VA = "0x185487560")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public World BGELJNJGDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EntityManager FHACAKFHJON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0E0", Offset = "0x8CE0E0", VA = "0x1808CF0E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public BJBGOMFMFBL NPECBMJOKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public global::GEDPBPAGPNN<CMKIKNDBPFM> AEPFNMJEDHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6606F0", Offset = "0x65F6F0", VA = "0x1806606F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AE0", Offset = "0x6E1AE0", VA = "0x1806E2AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public global::GEDPBPAGPNN<CNGICFHGNIC> IIJHJDGKNFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x651590", Offset = "0x650590", VA = "0x180651590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public global::GEDPBPAGPNN<APKLEDPALBD> OPOFJMBEEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x651580", Offset = "0x650580", VA = "0x180651580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6515A0", Offset = "0x6505A0", VA = "0x1806515A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> BKOIEKNNDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8CF120", Offset = "0x8CE120", VA = "0x1808CF120")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x54896A0", Offset = "0x54886A0", VA = "0x1854896A0")]
	public static JIGACBOPBKP EIIKGLCCJIN(string FOGNBJMCDMG, CCPAEMCMCPC ALKHBOMOJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5489B40", Offset = "0x5488B40", VA = "0x185489B40")]
	public JIGACBOPBKP(string FOGNBJMCDMG, CCPAEMCMCPC ALKHBOMOJMO = CCPAEMCMCPC.Simulation, JLBHPEHJCKF GCNBGLBDJPB = JLBHPEHJCKF.Default, bool MJJPNLBDKFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5489720", Offset = "0x5488720", VA = "0x185489720")]
	public ComponentSystemBase FGPJJIKHFEC(Type BCFKLEGAMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0750", Offset = "0x1E9F750", VA = "0x181EA0750")]
	public T FGPJJIKHFEC<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x54895D0", Offset = "0x54885D0", VA = "0x1854895D0")]
	public void DNGEACFPCPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5489A80", Offset = "0x5488A80", VA = "0x185489A80")]
	public void OMDNOALHCJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5489740", Offset = "0x5488740", VA = "0x185489740")]
	public void JCGBBONJCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5489570", Offset = "0x5488570", VA = "0x185489570")]
	public void DGLLKHNGIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5489240", Offset = "0x5488240", VA = "0x185489240")]
	public void BPLDMKHFMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x54899F0", Offset = "0x54889F0", VA = "0x1854899F0")]
	public void OCEBCFDMLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5489990", Offset = "0x5488990", VA = "0x185489990")]
	public void OADPHJAFBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5489160", Offset = "0x5488160", VA = "0x185489160")]
	public void AMFOIDAJGNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x54897A0", Offset = "0x54887A0", VA = "0x1854897A0")]
	internal void KDICLELKEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x54891C0", Offset = "0x54881C0", VA = "0x1854891C0")]
	private bool BGPMMPIFEIC(ComponentSystemGroup LGCEOGAHLEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x54892A0", Offset = "0x54882A0", VA = "0x1854892A0")]
	private void DBGMBMHCEDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5489880", Offset = "0x5488880", VA = "0x185489880")]
	private ComponentSystemGroup[] LGLEOEPINFK(JLBHPEHJCKF GCNBGLBDJPB, bool DADHBAADNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5489AE0", Offset = "0x5488AE0", VA = "0x185489AE0")]
	public void PPFJHNNOEMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5489630", Offset = "0x5488630", VA = "0x185489630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	protected IKLMELFJGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DisableAutoCreation]
public sealed class PJKOLMEHIFH : IKLMELFJGAF
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public PJKOLMEHIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DisableAutoCreation]
public sealed class DMBHLIDHMGJ : IKLMELFJGAF
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public DMBHLIDHMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DisableAutoCreation]
public sealed class HFGEIHKLDGF : IKLMELFJGAF
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public HFGEIHKLDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DisableAutoCreation]
public sealed class JCBICFNBBEL : IKLMELFJGAF
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public JCBICFNBBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DisableAutoCreation]
public sealed class HFPDGCKDHLP : IKLMELFJGAF
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public HFPDGCKDHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public CKOMBPJODGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[AttributeUsage(AttributeTargets.Class)]
public class MGJNHNIALFH : KFLPBOMAPGE
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public JKFBGPCOGDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5487D40", Offset = "0x5486D40", VA = "0x185487D40")]
	static BMBCGNPBIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x264B400", Offset = "0x264A400", VA = "0x18264B400")]
	public static void BJBPPFJFNHB<T>(JPAKPFGODAC<T, T> KJFHEJJKNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x264B2E0", Offset = "0x264A2E0", VA = "0x18264B2E0")]
	public static void BJBPPFJFNHB<From, To>(JPAKPFGODAC<From, To> KJFHEJJKNFD, JPAKPFGODAC<To, From> POJOKDKEAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x264B290", Offset = "0x264A290", VA = "0x18264B290")]
	public static void BJBPPFJFNHB<From, To>(JPAKPFGODAC<From, To> AGHAIFCGLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x26469B0", Offset = "0x26459B0", VA = "0x1826469B0")]
	public static JPAKPFGODAC<From, To> BANNGHIDLMB<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x264CF20", Offset = "0x264BF20", VA = "0x18264CF20")]
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
	[Cpp2IlInjected.Address(RVA = "0xD97D20", Offset = "0xD96D20", VA = "0x180D97D20")]
	public NGNDNHAGNEP(NativeArray<EntityRemapUtility.EntityRemapInfo> BLANLCCIJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C75ED0", Offset = "0x2C74ED0", VA = "0x182C75ED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x548BC90", Offset = "0x548AC90", VA = "0x18548BC90")]
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
			[Cpp2IlInjected.Address(RVA = "0x66B050", Offset = "0x66A050", VA = "0x18066B050")]
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
				[Cpp2IlInjected.Address(RVA = "0x54884D0", Offset = "0x54874D0", VA = "0x1854884D0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public long MENIPLHPEIA
			{
				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x5488530", Offset = "0x5487530", VA = "0x185488530")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x54885A0", Offset = "0x54875A0", VA = "0x1854885A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5488A40", Offset = "0x5487A40", VA = "0x185488A40")]
				public unsafe HLMAGHIHCFL(Unity.Entities.Archetype* FIDHECLCDDD, ACENMIBMELP.HDELCEDHJBH.DNDKPIBOKLB JCALFPGNNCP, NGNDNHAGNEP HDMBHNNBEPE, global::GEDPBPAGPNN<CNGICFHGNIC> BOPHPJCPNOG, int CADJDPODOGC, int IADGFBHBNBE = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x54889F0", Offset = "0x54879F0", VA = "0x1854889F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x548A740", Offset = "0x5489740", VA = "0x18548A740")]
			public JILHIEFJPBH(HLMAGHIHCFL[] CFFIGFCFHML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x548A410", Offset = "0x5489410", VA = "0x18548A410", Slot = "4")]
			public void Invoke(int MMABPPDCBIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x548A060", Offset = "0x5489060", VA = "0x18548A060")]
			private void HJEHNBEAEOM(in HLMAGHIHCFL PJDKPCLOECB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x548A470", Offset = "0x5489470", VA = "0x18548A470")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public KKJBDJGOLKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x548AC00", Offset = "0x5489C00", VA = "0x18548AC00")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public GAOPMFINGAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x54888E0", Offset = "0x54878E0", VA = "0x1854888E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5490A80", Offset = "0x548FA80", VA = "0x185490A80")]
		private unsafe static bool EOOPKFABOME(Unity.Entities.Archetype* CEMLDGMJKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5491260", Offset = "0x5490260", VA = "0x185491260")]
		internal unsafe static Unity.Entities.Archetype*[] HGNGHBLMPAL(ref Unity.Entities.EntityComponentStore PNFONLNAGIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5491790", Offset = "0x5490790", VA = "0x185491790")]
		public static void MHGLAJHJKJG(JIGACBOPBKP EAMEDKLPJKC, out ByteString AHJGIIFAPKK, out NativeArray<EntityRemapUtility.EntityRemapInfo> PNALEACAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x548EDE0", Offset = "0x548DDE0", VA = "0x18548EDE0")]
		internal static void ANEFFBHFJKB(JIGACBOPBKP EAMEDKLPJKC, ACENMIBMELP GFNKHHJBHOF, out NativeArray<EntityRemapUtility.EntityRemapInfo> PNALEACAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x54921B0", Offset = "0x54911B0", VA = "0x1854921B0")]
		private unsafe static UnsafeHashMap<ulong, BCIAPKGJAOH> PBEMKCGMMOI(Unity.Entities.Archetype*[] IJMNLHEBFLH)
		{
			return default(UnsafeHashMap<ulong, BCIAPKGJAOH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5490B90", Offset = "0x548FB90", VA = "0x185490B90")]
		private static void FEBCOLOJEAM(ACENMIBMELP GFNKHHJBHOF, UnsafeHashMap<ulong, BCIAPKGJAOH> GEDPDIMCEON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x548FF60", Offset = "0x548EF60", VA = "0x18548FF60")]
		private unsafe static void CJEHBLKGKJJ(ACENMIBMELP GFNKHHJBHOF, Unity.Entities.Archetype*[] IJMNLHEBFLH, UnsafeHashMap<ulong, BCIAPKGJAOH> GEDPDIMCEON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5492140", Offset = "0x5491140", VA = "0x185492140")]
		private unsafe static int OPOHJFKGHNH(Unity.Entities.Archetype*[] IJMNLHEBFLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x54905C0", Offset = "0x548F5C0", VA = "0x1854905C0")]
		private unsafe static void DENOGLNJOGO(ACENMIBMELP GFNKHHJBHOF, Unity.Entities.Archetype*[] IJMNLHEBFLH, global::GEDPBPAGPNN<CNGICFHGNIC> BOPHPJCPNOG, NativeArray<EntityRemapUtility.EntityRemapInfo> PNALEACAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5491520", Offset = "0x5490520", VA = "0x185491520")]
		private static NativeArray<int> LOAKHHHACIN(ACENMIBMELP GFNKHHJBHOF)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5490D40", Offset = "0x548FD40", VA = "0x185490D40")]
		private static Memory<EntityArchetype> GGFBFOHIDNC(ACENMIBMELP GFNKHHJBHOF, NativeArray<int> CEJOIBBGIME, EntityManager JGGNCNMICJO, out int CEFIPBPEBII, out int BKIMMFEFLKA)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5492440", Offset = "0x5491440", VA = "0x185492440")]
		private unsafe static void PNIDHNKHBGP(Unity.Entities.Chunk* LHKKDLIBMLE, ReadOnlySpan<byte> AHJGIIFAPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x548F510", Offset = "0x548E510", VA = "0x18548F510")]
		private static void BMAFLMLOHDL(ACENMIBMELP GFNKHHJBHOF, NativeArray<int> CEJOIBBGIME, Span<EntityArchetype> IJMNLHEBFLH, EntityManager JGGNCNMICJO, global::GEDPBPAGPNN<CNGICFHGNIC> BOPHPJCPNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5490290", Offset = "0x548F290", VA = "0x185490290")]
		private unsafe static void CPKJNPLFCNE(Unity.Entities.Chunk* DAJPMMDPFFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x548FC50", Offset = "0x548EC50", VA = "0x18548FC50")]
		private unsafe static void CDECIJFPJDK(ACENMIBMELP.HDELCEDHJBH.DNDKPIBOKLB FIDHECLCDDD, int NFHFFAABIOC, int PFILCINOEJO, Unity.Entities.Chunk* LHKKDLIBMLE, ACENMIBMELP GFNKHHJBHOF, NativeArray<int> CEJOIBBGIME, global::GEDPBPAGPNN<CNGICFHGNIC> BOPHPJCPNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5491DF0", Offset = "0x5490DF0", VA = "0x185491DF0")]
		public static void MLFHPHHNPOI(JIGACBOPBKP EAMEDKLPJKC, in ByteString AHJGIIFAPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5491850", Offset = "0x5490850", VA = "0x185491850")]
		public static void MLFHPHHNPOI(EntityManager JGGNCNMICJO, global::GEDPBPAGPNN<CNGICFHGNIC> BOPHPJCPNOG, in ByteString AHJGIIFAPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5491E80", Offset = "0x5490E80", VA = "0x185491E80")]
		private static bool NECAHBEBMHJ(Type BCFKLEGAMEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5490310", Offset = "0x548F310", VA = "0x185490310")]
		private static void DBDCEAIAMDF(TypeManager.TypeInfo MGOBGJBJEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x54910D0", Offset = "0x54900D0", VA = "0x1854910D0")]
		private unsafe static int GNNHEIGPNPN(Unity.Entities.Archetype*[] IJMNLHEBFLH, NativeArray<EntityRemapUtility.EntityRemapInfo> PNALEACAIBD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5491440", Offset = "0x5490440", VA = "0x185491440")]
		private static int JGEKIAPOFNF(int NDBJIKBMPCB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x54909E0", Offset = "0x548F9E0", VA = "0x1854909E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x548AD10", Offset = "0x5489D10", VA = "0x18548AD10")]
	private unsafe static Span<byte> FFFPIKEPCBE(Unity.Entities.Chunk* DAJPMMDPFFK, int CADJDPODOGC)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x27EBCA0", Offset = "0x27EACA0", VA = "0x1827EBCA0")]
	public unsafe static Span<T> JPILOPFDBKO<T>(Unity.Entities.Chunk* DAJPMMDPFFK, int CADJDPODOGC)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x27EBE20", Offset = "0x27EAE20", VA = "0x1827EBE20")]
	public static Span<T> JPILOPFDBKO<T>(this ref Unity.Entities.Chunk DAJPMMDPFFK, int CADJDPODOGC)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x548AEB0", Offset = "0x5489EB0", VA = "0x18548AEB0")]
	public unsafe static Span<Entity> LLPHPEHOGAO(Unity.Entities.Chunk* DAJPMMDPFFK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x548AF20", Offset = "0x5489F20", VA = "0x18548AF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x54929F0", Offset = "0x54919F0", VA = "0x1854929F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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

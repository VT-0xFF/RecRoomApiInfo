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
internal static class LGDFEBDAEPM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x346E090", Offset = "0x346C890", VA = "0x18346E090")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> GDAPCGNFEDB(this ref Unity.Entities.Archetype EOKDKGJACDA)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DEEGGOMKCOO
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x346B2A0", Offset = "0x3469AA0", VA = "0x18346B2A0")]
	public static Span<int> MPLPDENEIPN(this EntityArchetype EOKDKGJACDA)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IFNNFLABCHK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x346DCB0", Offset = "0x346C4B0", VA = "0x18346DCB0")]
	public static bool CPNLIKCPMHB(this Entity NBIJCGHBCCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FALDGIPEALA
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct AAPLIPHFHHD<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CLELICPJFMC : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public global::AAPLIPHFHHD<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x68E570", Offset = "0x68CD70", VA = "0x18068E570", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE31DE0", Offset = "0xE305E0", VA = "0x180E31DE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE31E30", Offset = "0xE30630", VA = "0x180E31E30")]
		[DebuggerHidden]
		public CLELICPJFMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xE31BE0", Offset = "0xE303E0", VA = "0x180E31BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xE31D90", Offset = "0xE30590", VA = "0x180E31D90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Action<Protobuf> HEPFNBHNLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MemoryStream ILAPMFLBPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CodedInputStream NEEIPIEFEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Protobuf DBDMNIIAGME;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KJDFLCMLCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x653E50", Offset = "0x652650", VA = "0x180653E50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xE2C4D0", Offset = "0xE2ACD0", VA = "0x180E2C4D0")]
	private AAPLIPHFHHD(byte[] POKOCMHLPLN, Action<Protobuf> HEPFNBHNLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4F3B010", Offset = "0x4F39810", VA = "0x184F3B010")]
	public static global::AAPLIPHFHHD<Protobuf> BHNJDAHDLKD<Data>(ReadOnlySpan<byte> HDPBFIPIIDN, ReadOnlySpan<Data> HPGJMGNMMCF, Action<Protobuf> HEPFNBHNLMK)
	{
		return default(global::AAPLIPHFHHD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xE2C330", Offset = "0xE2AB30", VA = "0x180E2C330", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xE2C370", Offset = "0xE2AB70", VA = "0x180E2C370", Slot = "4")]
	[IteratorStateMachine(typeof(global::AAPLIPHFHHD<>.CLELICPJFMC))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xE2C470", Offset = "0xE2AC70", VA = "0x180E2C470", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ICNAHHEFOFB<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly byte[] POKOCMHLPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly Protobuf DBDMNIIAGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MemoryStream ILAPMFLBPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CodedOutputStream PEFEDEBDOBH;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5360BB0", Offset = "0x535F3B0", VA = "0x185360BB0")]
	private ICNAHHEFOFB(byte[] POKOCMHLPLN, in Protobuf DBDMNIIAGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5251B80", Offset = "0x5250380", VA = "0x185251B80")]
	public static global::ICNAHHEFOFB<Protobuf> BHNJDAHDLKD<T>(ReadOnlySpan<T> HPGJMGNMMCF)
	{
		return default(global::ICNAHHEFOFB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5360A50", Offset = "0x535F250", VA = "0x185360A50")]
	public void BNGLDNJAIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x53609C0", Offset = "0x535F1C0", VA = "0x1853609C0")]
	public ByteString ABPPGPMEONB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5360A80", Offset = "0x535F280", VA = "0x185360A80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OALBECCGBNC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MemoryStream ILAPMFLBPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CodedInputStream NEEIPIEFEOF;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x346EA90", Offset = "0x346D290", VA = "0x18346EA90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KCHJHHMFAID : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly byte[] POKOCMHLPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MemoryStream ILAPMFLBPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CodedOutputStream PEFEDEBDOBH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x346DEE0", Offset = "0x346C6E0", VA = "0x18346DEE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class PBIPOHHMJNE : BFBIAJNEBGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Type IFFNPEBBHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5F6790", Offset = "0x5F4F90", VA = "0x1805F6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x346AB80", Offset = "0x3469380", VA = "0x18346AB80")]
	public PBIPOHHMJNE(Type OGNHINNEIEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LBJGPGJMNEL : PBIPOHHMJNE
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x346AB80", Offset = "0x3469380", VA = "0x18346AB80")]
	public LBJGPGJMNEL(Type OGNHINNEIEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HLFNPKCPOCF : PBIPOHHMJNE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Type EOFKFDACKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x643F60", Offset = "0x642760", VA = "0x180643F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x346D550", Offset = "0x346BD50", VA = "0x18346D550")]
	public HLFNPKCPOCF(Type KOHMJFBNFMF, Type OGNHINNEIEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BBMHGCKNDGC : PBIPOHHMJNE
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x346AB80", Offset = "0x3469380", VA = "0x18346AB80")]
	public BBMHGCKNDGC(Type OGNHINNEIEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MIDOOGOCAPK : BFBIAJNEBGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public MIDOOGOCAPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CCIJCDFGPFF : BFBIAJNEBGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GGFKBMKOJDK KKOEAHBIGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6348F0", Offset = "0x6330F0", VA = "0x1806348F0")]
		[CompilerGenerated]
		get
		{
			return default(GGFKBMKOJDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x346AE00", Offset = "0x3469600", VA = "0x18346AE00")]
	public CCIJCDFGPFF(GGFKBMKOJDK AGFHKAICCAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
public class ADAIPEODNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly FDJJGOGKMHG LMKNNIPOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly EntityManager FNBDEMCEOPA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FDJJGOGKMHG JAGNOKIGICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x346A670", Offset = "0x3468E70", VA = "0x18346A670")]
	public ADAIPEODNMG(FDJJGOGKMHG LMKNNIPOPLE, EntityManager FNBDEMCEOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x346A620", Offset = "0x3468E20", VA = "0x18346A620")]
	public int MOHGACEJHOP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1780BA0", Offset = "0x177F3A0", VA = "0x181780BA0")]
	public bool GCHLAHOLIPB<T>(Entity NBIJCGHBCCI) where T : struct, EICPOGHKDOL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1780B10", Offset = "0x177F310", VA = "0x181780B10")]
	public bool EMLPMKEAIFG<T>(Entity NBIJCGHBCCI, out T CJMMBFLIBMO) where T : struct, EICPOGHKDOL
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4EE28C0", Offset = "0x4EE10C0", VA = "0x184EE28C0")]
	public T KKLEMMPFLFO<T>(Entity NBIJCGHBCCI) where T : struct, EICPOGHKDOL
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1E8D4F0", Offset = "0x1E8BCF0", VA = "0x181E8D4F0")]
	private ComponentType JHODBJOANDF<T>() where T : struct, EICPOGHKDOL
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x346A570", Offset = "0x3468D70", VA = "0x18346A570")]
	private ComponentType JHODBJOANDF(Type BKDBLJPNPPJ)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class GLALDLOMEOC
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	protected GLALDLOMEOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class CHLAGFGPPLN<View, Data> : AIGPFJAOAFB where View : struct, EICPOGHKDOL where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static ComponentType MLGBNOGEODB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override Type PHDANDJFEME
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x55A33A0", Offset = "0x55A1BA0", VA = "0x1855A33A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override Type KHPBFKBIMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x55A3AA0", Offset = "0x55A22A0", VA = "0x1855A3AA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override int BCJBMKIMDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x55A38E0", Offset = "0x55A20E0", VA = "0x1855A38E0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x55A4880", Offset = "0x55A3080", VA = "0x1855A4880")]
	public Data KFIPDKMLOAA(Entity NBIJCGHBCCI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x55A4900", Offset = "0x55A3100", VA = "0x1855A4900")]
	public Data OIPLNLNIFEA(Entity NBIJCGHBCCI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected internal abstract View MJIDLCBNHAP(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9150", Offset = "0x4EE7950", VA = "0x184EE9150", Slot = "15")]
	protected internal override T MJIDLCBNHAP<T>(Entity NBIJCGHBCCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x55A39A0", Offset = "0x55A21A0", VA = "0x1855A39A0", Slot = "16")]
	public override bool GCHLAHOLIPB(Entity NBIJCGHBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x11F4EB0", Offset = "0x11F36B0", VA = "0x1811F4EB0")]
	protected CHLAGFGPPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class AIGPFJAOAFB : IHMDKDJBAJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private ArchetypeChunkComponentTypeDynamic KFJPKBGGKFA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EntityManager BNFBCOAMLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82F120", Offset = "0x82D920", VA = "0x18082F120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public abstract Type PHDANDJFEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public abstract Type KHPBFKBIMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public abstract int BCJBMKIMDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private Type ANJJMIBMHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EDEA0", VA = "0x1806EF6A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int ILFKCPKLHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x346A7C0", Offset = "0x3468FC0", VA = "0x18346A7C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private NOPBMJOJCGP[] JIDKDKMAHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF850", Offset = "0x6EE050", VA = "0x1806EF850", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	protected internal virtual NOPBMJOJCGP[] ECHCFPCIPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x346AA60", Offset = "0x3469260", VA = "0x18346AA60", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool IKAOJJBHDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x346A790", Offset = "0x3468F90", VA = "0x18346A790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x346A830", Offset = "0x3469030", VA = "0x18346A830")]
	public void LGHMODLDJCJ(EntityManager FNBDEMCEOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x86BBC0", Offset = "0x86A3C0", VA = "0x18086BBC0")]
	protected IHMDKDJBAJD JOPHDPCAEPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T MJIDLCBNHAP<T>(Entity NBIJCGHBCCI) where T : struct, EICPOGHKDOL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract bool GCHLAHOLIPB(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x346A6C0", Offset = "0x3468EC0", VA = "0x18346A6C0", Slot = "8")]
	public (uint, uint) CNFNDDGPMLL(Entity NBIJCGHBCCI)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x346A9C0", Offset = "0x34691C0", VA = "0x18346A9C0", Slot = "9")]
	public bool NCBDEMKPHPL(Entity NBIJCGHBCCI, (uint order, uint change) KAGEGNEPBEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	protected AIGPFJAOAFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class JLDPCMEIJDN<Data> : IICLMLPIBHG where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public virtual Data JBGJKCAJAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x562BDB0", Offset = "0x562A5B0", VA = "0x18562BDB0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xAEDCB0", Offset = "0xAEC4B0", VA = "0x180AEDCB0", Slot = "8")]
	protected virtual bool GKAPGBMNGMN(ReadOnlySpan<Data> HPGJMGNMMCF, EDEBCBMIEIE NIBNAFJNIDP, out ReadOnlySpan<byte> HDPBFIPIIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "9")]
	protected virtual bool FGFMIOLKIJB(int KAGEGNEPBEI, Span<Data> HPGJMGNMMCF, in ReadOnlySpan<byte> HDPBFIPIIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x562D990", Offset = "0x562C190", VA = "0x18562D990", Slot = "5")]
	internal sealed override bool GKAPGBMNGMN(ref Unity.Entities.Chunk ENPKJHPNEAL, int MIEFIAGGHNG, EDEBCBMIEIE NIBNAFJNIDP, out ReadOnlySpan<byte> HDPBFIPIIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x562C8F0", Offset = "0x562B0F0", VA = "0x18562C8F0", Slot = "6")]
	internal sealed override bool FGFMIOLKIJB(int KAGEGNEPBEI, ref Unity.Entities.Chunk ENPKJHPNEAL, int MIEFIAGGHNG, in ReadOnlySpan<byte> HDPBFIPIIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5257990", Offset = "0x5256190", VA = "0x185257990")]
	protected global::ICNAHHEFOFB<Protobuf> IBNMALGCHGC<Protobuf>(ReadOnlySpan<Data> HPGJMGNMMCF) where Protobuf : IMessage, new()
	{
		return default(global::ICNAHHEFOFB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4F48730", Offset = "0x4F46F30", VA = "0x184F48730")]
	protected global::AAPLIPHFHHD<Protobuf> CGJLKLOCDCG<Protobuf>(ReadOnlySpan<byte> HDPBFIPIIDN, ReadOnlySpan<Data> HPGJMGNMMCF, Action<Protobuf> HEPFNBHNLMK) where Protobuf : IMessage, new()
	{
		return default(global::AAPLIPHFHHD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x11F4EB0", Offset = "0x11F36B0", VA = "0x1811F4EB0")]
	protected JLDPCMEIJDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class IICLMLPIBHG
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	protected internal abstract int JLICIKJPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x346DCD0", Offset = "0x346C4D0", VA = "0x18346DCD0", Slot = "5")]
	internal virtual bool GKAPGBMNGMN(ref Unity.Entities.Chunk ENPKJHPNEAL, int MIEFIAGGHNG, EDEBCBMIEIE NIBNAFJNIDP, out ReadOnlySpan<byte> HDPBFIPIIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "6")]
	internal virtual bool FGFMIOLKIJB(int KAGEGNEPBEI, ref Unity.Entities.Chunk ENPKJHPNEAL, int MIEFIAGGHNG, in ReadOnlySpan<byte> HDPBFIPIIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	protected IICLMLPIBHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OKNAPOANHAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[BurstCompile]
internal struct HLMDHNAMCLA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe Unity.Entities.EntityComponentStore* DMMKOBFMDPN;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x346D5A0", Offset = "0x346BDA0", VA = "0x18346D5A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MKAKAIEDHMA
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEODPFKGBED(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class DEBOBDFKDMD
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xB54060", Offset = "0xB52860", VA = "0x180B54060")]
	public static void OFJDPFAILOI<T>(this ref T OFPFIAGIKFE, ref ArchetypeChunkIterator HGHFNAANBLP) where T : struct, MKAKAIEDHMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xB53FC0", Offset = "0xB527C0", VA = "0x180B53FC0")]
	public static void OFJDPFAILOI<T>(this ref T OFPFIAGIKFE, EntityQuery BBKLDNMAKNK) where T : struct, MKAKAIEDHMA
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HHEKCGJGKAI
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x346D3B0", Offset = "0x346BBB0", VA = "0x18346D3B0")]
	public static bool KOOIEADCIFN(Type BKDBLJPNPPJ, Type GOKIOEGCHGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal abstract class LJNAGCHLPPA<Attribute, BaseClass> : global::DFNDACOFICK<BaseClass>, MGHPJLKCEOL where Attribute : PBIPOHHMJNE
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly FLAFLKKHHEA APOHKGBDLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string JNAACNJBHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<int, Type> KKEHHBDKLFN;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x547B1C0", Offset = "0x54799C0", VA = "0x18547B1C0")]
	public LJNAGCHLPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x547B010", Offset = "0x5479810", VA = "0x18547B010", Slot = "4")]
	public bool JNEGJNMGLPF(int JCCEMLFDLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x547ABA0", Offset = "0x54793A0", VA = "0x18547ABA0", Slot = "5")]
	public global::NDHHJFCALDI<BaseClass> BPPMFNIFOHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x547B070", Offset = "0x5479870", VA = "0x18547B070", Slot = "7")]
	protected virtual bool KOOIEADCIFN(Type BKDBLJPNPPJ, int BIOBEBJPJDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x547AE70", Offset = "0x5479670", VA = "0x18547AE70", Slot = "8")]
	protected virtual int CNKODKECHEE(Type BKDBLJPNPPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x547AFA0", Offset = "0x54797A0", VA = "0x18547AFA0")]
	public void DJCOPMFLKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x547AF00", Offset = "0x5479700", VA = "0x18547AF00", Slot = "6")]
	public void DAFBLBFDDID(Type BKDBLJPNPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NDHHJFCALDI<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<int, BaseClass> KDPIINCDCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<Type, BaseClass> AAGFBHLFEEB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IEnumerable<BaseClass> EFJFJEIADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5780180", Offset = "0x577E980", VA = "0x185780180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5780670", Offset = "0x577EE70", VA = "0x185780670")]
	public NDHHJFCALDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x57804D0", Offset = "0x577ECD0", VA = "0x1857804D0")]
	public NDHHJFCALDI(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x57803B0", Offset = "0x577EBB0", VA = "0x1857803B0")]
	internal void NLKJJINIDJF(int JCCEMLFDLOM, BaseClass KKMCNGMCKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xFA6470", Offset = "0xFA4C70", VA = "0x180FA6470")]
	public bool OGIKEKFNGLJ<T>(out BaseClass CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5780430", Offset = "0x577EC30", VA = "0x185780430")]
	public bool OGIKEKFNGLJ(Type AOLKBDPFIGD, out BaseClass CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xE2AAA0", Offset = "0xE292A0", VA = "0x180E2AAA0")]
	public bool PIDLHIFHHGE(int JCCEMLFDLOM, out BaseClass CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA875B0", Offset = "0xA85DB0", VA = "0x180A875B0")]
	public T EKFGEOGOLEI<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5780150", Offset = "0x577E950", VA = "0x185780150")]
	public BaseClass EKFGEOGOLEI(Type ADJIAKCDPKB)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class MHBNMNIBGFF : global::LJNAGCHLPPA<LBJGPGJMNEL, GLALDLOMEOC>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x346E290", Offset = "0x346CA90", VA = "0x18346E290")]
	public MHBNMNIBGFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class BILCOMNMHMP : global::LJNAGCHLPPA<HLFNPKCPOCF, AIGPFJAOAFB>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x346AC20", Offset = "0x3469420", VA = "0x18346AC20")]
	public BILCOMNMHMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class ANMOCHBAGKE : global::LJNAGCHLPPA<BBMHGCKNDGC, IICLMLPIBHG>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x346AB20", Offset = "0x3469320", VA = "0x18346AB20")]
	public ANMOCHBAGKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct IBBBGELHOFF
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly FLAFLKKHHEA APOHKGBDLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Type> PDJCGKDLAGG;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA260", Offset = "0x6D8A60", VA = "0x1806DA260")]
	private IBBBGELHOFF(List<Type> PDJCGKDLAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x346D840", Offset = "0x346C040", VA = "0x18346D840")]
	public static void DJCOPMFLKGB(List<Type> PDJCGKDLAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x346DAD0", Offset = "0x346C2D0", VA = "0x18346DAD0")]
	private void PNIBBOCOBPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x346D8F0", Offset = "0x346C0F0", VA = "0x18346D8F0")]
	private bool KOOIEADCIFN(Type BKDBLJPNPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x346D7E0", Offset = "0x346BFE0", VA = "0x18346D7E0")]
	private void CJBDPOADAKB(Type BKDBLJPNPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface DFNDACOFICK<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JNEGJNMGLPF(int JCCEMLFDLOM);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::NDHHJFCALDI<BaseClass> BPPMFNIFOHA();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class IHCMLLDKAMA : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50")]
	protected IHCMLLDKAMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class NODCCJFPGAM : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50")]
	protected NODCCJFPGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class JHFMKABDHHH : IHCMLLDKAMA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x346DCF0", Offset = "0x346C4F0", VA = "0x18346DCF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	protected void HFFDOINNMCO(string IGABHJPIBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50")]
	protected JHFMKABDHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[DOHCKPDOJMD(PAPAHBCPMGP.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x346F560", Offset = "0x346DD60", VA = "0x18346F560")]
		public static ComponentSystemGroup[] GEKCLLNKOIJ(World LMKNNIPOPLE, DPINHNBBIOF FMPHLBLELOK = DPINHNBBIOF.Default, bool IPGJHFCIBIP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x346F630", Offset = "0x346DE30", VA = "0x18346F630")]
		private static Type[] HPKJNGHILCB(DPINHNBBIOF FMPHLBLELOK, bool IPGJHFCIBIP, ComponentSystemGroup[] PIAPKOCPFJJ, ComponentSystemGroup ADBDAENJINF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x346F930", Offset = "0x346E130", VA = "0x18346F930")]
		private static ComponentSystemGroup[] LEHJHAJPBOF(World LMKNNIPOPLE, out ComponentSystemGroup ADBDAENJINF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x346F1E0", Offset = "0x346D9E0", VA = "0x18346F1E0")]
		internal static bool BKJLDKGCJFE(GGFKBMKOJDK AGFHKAICCAO, out DODGNPMHCOJ MCDIBCJCBKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x346F490", Offset = "0x346DC90", VA = "0x18346F490")]
		private static ComponentSystemGroup GEFHPHBCLDL(Type BKDBLJPNPPJ, World LMKNNIPOPLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x346FBD0", Offset = "0x346E3D0", VA = "0x18346FBD0")]
		private static ComponentSystemGroup[] LIKKHNHDHKK(Type[] PDJCGKDLAGG, World LMKNNIPOPLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x346EDB0", Offset = "0x346D5B0", VA = "0x18346EDB0")]
		internal static void AOFCNGJNNGN(World LMKNNIPOPLE, Type[] AFABMLMCBFH, ComponentSystemGroup[] PIAPKOCPFJJ, ComponentSystemGroup ADBDAENJINF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x346F3D0", Offset = "0x346DBD0", VA = "0x18346F3D0")]
		internal static bool BLCFNGOADKF(ComponentSystemBase EDDAMLAHJFN, ComponentSystemGroup[] PIAPKOCPFJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x346F430", Offset = "0x346DC30", VA = "0x18346F430")]
		private static void CBDCHJOFPID(ComponentSystemGroup[] PIAPKOCPFJJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct MMAFNKOPLMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly Dictionary<Type, List<Type>> CAPEFOOLFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly HashSet<Type> ADHLECOCGGP;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F10", Offset = "0x6C0710", VA = "0x1806C1F10")]
	public MMAFNKOPLMH(Dictionary<Type, List<Type>> CAPEFOOLFBA, HashSet<Type> ADHLECOCGGP)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[DOHCKPDOJMD(PAPAHBCPMGP.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class GGBGLEHCPOK : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x61A260", Offset = "0x618A60", VA = "0x18061A260")]
			[DebuggerHidden]
			public GGBGLEHCPOK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x346C620", Offset = "0x346AE20", VA = "0x18346C620", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x346C370", Offset = "0x346AB70", VA = "0x18346C370", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x346C6D0", Offset = "0x346AED0", VA = "0x18346C6D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x346C5D0", Offset = "0x346ADD0", VA = "0x18346C5D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x346C520", Offset = "0x346AD20", VA = "0x18346C520", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x346C520", Offset = "0x346AD20", VA = "0x18346C520", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct BPPACODGBEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Type LMIGNLHGCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private DPINHNBBIOF FMPHLBLELOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool JCOAJBICFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool NAKKANFHOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool IPGJHFCIBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IEnumerable<Type> NILAGPCPJDN;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x34701A0", Offset = "0x346E9A0", VA = "0x1834701A0")]
		public static RRFilterWorldSystems BHNJDAHDLKD()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3470A70", Offset = "0x346F270", VA = "0x183470A70")]
		public RRFilterWorldSystems PGFOCKNNHIO(DPINHNBBIOF AGFHKAICCAO)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x34701D0", Offset = "0x346E9D0", VA = "0x1834701D0")]
		public RRFilterWorldSystems BPPADNDJFGJ(IEnumerable<Type> PDJCGKDLAGG)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3470410", Offset = "0x346EC10", VA = "0x183470410")]
		public RRFilterWorldSystems KIHJHMJAOJJ(bool GHGCPHDNMLB)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3470980", Offset = "0x346F180", VA = "0x183470980")]
		public RRFilterWorldSystems KNIEGFBMAFM(bool NKBJCEEODAH)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3470380", Offset = "0x346EB80", VA = "0x183470380")]
		public MMAFNKOPLMH GBAHJEDJFCC(Type[] IBJMAIFGJPO)
		{
			return default(MMAFNKOPLMH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3470A80", Offset = "0x346F280", VA = "0x183470A80")]
		[IteratorStateMachine(typeof(GGBGLEHCPOK))]
		internal IEnumerable<Type> PPHCMFNJOHL(IEnumerable<Type> PDJCGKDLAGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x346FE90", Offset = "0x346E690", VA = "0x18346FE90")]
		internal Dictionary<Type, List<Type>> AOCHIMLAHAI(IEnumerable<Type> PDJCGKDLAGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3470990", Offset = "0x346F190", VA = "0x183470990")]
		private void MPJHKNMIGMO(Dictionary<Type, List<Type>> DFGJAHNNJBK, Type BKDBLJPNPPJ, Type DMOMKOKPDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3470210", Offset = "0x346EA10", VA = "0x183470210")]
		internal HashSet<Type> FBLHGHPNAIJ(IEnumerable<Type> PIAPKOCPFJJ, Dictionary<Type, List<Type>> OMEFEABFKAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3470420", Offset = "0x346EC20", VA = "0x183470420")]
		internal bool KJBHPPHNLIK(Type BKDBLJPNPPJ, DPINHNBBIOF FMPHLBLELOK, bool IPGJHFCIBIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x346FD50", Offset = "0x346E550", VA = "0x18346FD50")]
		[CompilerGenerated]
		internal static void ACCJBCCIAEL(Type BKDBLJPNPPJ, ref BPPACODGBEN P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class EEELAFBJIIA
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static bool FNEJFJAGLOJ;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x346B320", Offset = "0x3469B20", VA = "0x18346B320")]
	public static void LGHMODLDJCJ(bool PDHIMENFOOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x346B370", Offset = "0x3469B70", VA = "0x18346B370")]
	private static void NOEEMGNBAIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class FCLJPJAANMO
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x346B5A0", Offset = "0x3469DA0", VA = "0x18346B5A0")]
	public static ulong HNBNLMDCBDE(Type BKDBLJPNPPJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x346B4F0", Offset = "0x3469CF0", VA = "0x18346B4F0")]
	public static ulong HNBNLMDCBDE(string ODGAGLDFHNO)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[DOHCKPDOJMD(PAPAHBCPMGP.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private struct KLGNNDADOMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public readonly ulong ELALDFENPBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public readonly ulong PMBAIEFMDAO;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x1461200", Offset = "0x145FA00", VA = "0x181461200")]
			public KLGNNDADOMK(ulong JOMAEJEBIKH, ulong JLBIPOJLAKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x346E010", Offset = "0x346C810", VA = "0x18346E010", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static Dictionary<ulong, int> NICJFLIMGOG;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static KLGNNDADOMK[] EFOLCGHGKGL;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static bool FNEJFJAGLOJ;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3471490", Offset = "0x346FC90", VA = "0x183471490")]
		public static ulong KPHPFHKGIIM(int JCCEMLFDLOM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3471740", Offset = "0x346FF40", VA = "0x183471740")]
		public static int OPCAIAMANMK(ulong JLBIPOJLAKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x34714F0", Offset = "0x346FCF0", VA = "0x1834714F0")]
		public static void LGHMODLDJCJ(bool PDHIMENFOOC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3471170", Offset = "0x346F970", VA = "0x183471170")]
		private static void IGMONAMKPJK(int GDOHGOEGINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3470CB0", Offset = "0x346F4B0", VA = "0x183470CB0")]
		private static void COAEHHHEDOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3470FB0", Offset = "0x346F7B0", VA = "0x183470FB0")]
		private static KLGNNDADOMK FMKILIGPOGJ(Type BKDBLJPNPPJ)
		{
			return default(KLGNNDADOMK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3471420", Offset = "0x346FC20", VA = "0x183471420")]
		private static ulong IOHINOCLIEO(Type BKDBLJPNPPJ, ulong JLBIPOJLAKF)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3471230", Offset = "0x346FA30", VA = "0x183471230")]
		private static void IHFBAEHNJFC(in KLGNNDADOMK HIDMGFHGKEB, TypeManager.TypeInfo CFCBKEKELBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3470BC0", Offset = "0x346F3C0", VA = "0x183470BC0")]
		private static void ANDLHGIFDCK(KLGNNDADOMK CFCBKEKELBA, int JCCEMLFDLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3471090", Offset = "0x346F890", VA = "0x183471090")]
		private static void GEJFCGNLKOF(KLGNNDADOMK CFCBKEKELBA, int JCCEMLFDLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x34716B0", Offset = "0x346FEB0", VA = "0x1834716B0")]
		private static KLGNNDADOMK LJKDNJEGAJF(int JCCEMLFDLOM)
		{
			return default(KLGNNDADOMK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3470BB0", Offset = "0x346F3B0", VA = "0x183470BB0")]
		private static int AIGFBECMNDK(int JCCEMLFDLOM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GOBECDOJCIM
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly BILCOMNMHMP PKHEPEKAAIO;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly ANMOCHBAGKE NJNKIOEDLMF;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly MHBNMNIBGFF INFDIJCLNBI;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly List<Type> DILGBDMAJBC;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static bool FNEJFJAGLOJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	internal static global::DFNDACOFICK<AIGPFJAOAFB> DLGCKDKKENK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x346CBD0", Offset = "0x346B3D0", VA = "0x18346CBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal static global::DFNDACOFICK<IICLMLPIBHG> CPAHMCIGEBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x346CC30", Offset = "0x346B430", VA = "0x18346CC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal static global::DFNDACOFICK<GLALDLOMEOC> LBIAJNKIIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x346CCF0", Offset = "0x346B4F0", VA = "0x18346CCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x346CD50", Offset = "0x346B550", VA = "0x18346CD50")]
	public static void LGHMODLDJCJ(bool PDHIMENFOOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x346D170", Offset = "0x346B970", VA = "0x18346D170")]
	public static Type[] MBPMMCCHMPM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CHMBINAHBHB
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly Dictionary<int, int> PHDEGEAKNKB;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool FNEJFJAGLOJ;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x346AE30", Offset = "0x3469630", VA = "0x18346AE30")]
	public static int CNFNDDGPMLL(int JCCEMLFDLOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x346AF30", Offset = "0x3469730", VA = "0x18346AF30")]
	public static void LGHMODLDJCJ(bool PDHIMENFOOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x346AFD0", Offset = "0x34697D0", VA = "0x18346AFD0")]
	private static void NMPICBPGAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x346B1F0", Offset = "0x34699F0", VA = "0x18346B1F0")]
	private static int OMKKGKJECFP(Type BKDBLJPNPPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x346AEC0", Offset = "0x34696C0", VA = "0x18346AEC0")]
	private static void IDPJIGKEBOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class FDJJGOGKMHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly World LMKNNIPOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly World MAKCDEHPICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly ADAIPEODNMG KKMCNGMCKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly ComponentSystemGroup[] PIAPKOCPFJJ;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public World JAGNOKIGICD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public World IBAIKALPOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EntityManager BNFBCOAMLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xBA3230", Offset = "0xBA1A30", VA = "0x180BA3230")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ADAIPEODNMG HOCMGGGFBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public global::NDHHJFCALDI<AIGPFJAOAFB> DLGCKDKKENK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x638B30", Offset = "0x637330", VA = "0x180638B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x671B60", Offset = "0x670360", VA = "0x180671B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public global::NDHHJFCALDI<IICLMLPIBHG> CPAHMCIGEBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5F99A0", Offset = "0x5F81A0", VA = "0x1805F99A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6440", Offset = "0x6D4C40", VA = "0x1806D6440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public global::NDHHJFCALDI<GLALDLOMEOC> LBIAJNKIIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5F9990", Offset = "0x5F8190", VA = "0x1805F9990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5F9350", Offset = "0x5F7B50", VA = "0x1805F9350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x236B320", Offset = "0x2369B20", VA = "0x18236B320")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x346B950", Offset = "0x346A150", VA = "0x18346B950")]
	public static FDJJGOGKMHG IJHOAGKDCLF(string JNAACNJBHOF, GGFKBMKOJDK AGFHKAICCAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x346BEA0", Offset = "0x346A6A0", VA = "0x18346BEA0")]
	public FDJJGOGKMHG(string JNAACNJBHOF, GGFKBMKOJDK AGFHKAICCAO = GGFKBMKOJDK.Simulation, DPINHNBBIOF FMPHLBLELOK = DPINHNBBIOF.Default, bool PDHIMENFOOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x346B750", Offset = "0x3469F50", VA = "0x18346B750")]
	public ComponentSystemBase DINIFEPAGAF(Type BKDBLJPNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1C34030", Offset = "0x1C32830", VA = "0x181C34030")]
	public T DINIFEPAGAF<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x346B630", Offset = "0x3469E30", VA = "0x18346B630")]
	public void CAHGKFOGDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x346B5D0", Offset = "0x3469DD0", VA = "0x18346B5D0")]
	public void BGEFLJGNICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x346BDC0", Offset = "0x346A5C0", VA = "0x18346BDC0")]
	public void NKFIBHOPCHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x346BD60", Offset = "0x346A560", VA = "0x18346BD60")]
	public void LPLNHNICGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x346BB70", Offset = "0x346A370", VA = "0x18346BB70")]
	public void KCELMCCJFKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x346BE20", Offset = "0x346A620", VA = "0x18346BE20")]
	public void PKHOCIAIPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x346B6F0", Offset = "0x3469EF0", VA = "0x18346B6F0")]
	public void DFMCHFJPHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x346B8F0", Offset = "0x346A0F0", VA = "0x18346B8F0")]
	public void GKDIENCKPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x346BC60", Offset = "0x346A460", VA = "0x18346BC60")]
	internal void LEDANGKKEKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x346BBD0", Offset = "0x346A3D0", VA = "0x18346BBD0")]
	private bool KHMFJOGHADD(ComponentSystemGroup AKCNNHAPOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x346B9D0", Offset = "0x346A1D0", VA = "0x18346B9D0")]
	private void JDKGGIBBCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x346B7E0", Offset = "0x3469FE0", VA = "0x18346B7E0")]
	private ComponentSystemGroup[] GEKCLLNKOIJ(DPINHNBBIOF FMPHLBLELOK, bool IPGJHFCIBIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x346B690", Offset = "0x3469E90", VA = "0x18346B690")]
	public void CHDNICDAHOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x346B770", Offset = "0x3469F70", VA = "0x18346B770", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
public enum GGFKBMKOJDK
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
public sealed class IPMCGJBJCAO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public DPINHNBBIOF JFIBOJHGBCI;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Flags]
public enum DPINHNBBIOF
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
public interface DODGNPMHCOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	Type DINALDIFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Type[] DEKBFFGOLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class FBDKAIFPLCP : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public virtual bool MFILHBIABJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6120B0", Offset = "0x6108B0", VA = "0x1806120B0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	protected FBDKAIFPLCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DisableAutoCreation]
public sealed class GNOGOBLAPME : FBDKAIFPLCP
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public GNOGOBLAPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DisableAutoCreation]
public sealed class NKFPBPHMDPM : FBDKAIFPLCP
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public NKFPBPHMDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DisableAutoCreation]
public sealed class CBGOJNFOINJ : FBDKAIFPLCP
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public CBGOJNFOINJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DisableAutoCreation]
public sealed class AGEGHLJDDBK : FBDKAIFPLCP
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public AGEGHLJDDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DisableAutoCreation]
public sealed class CGOHPMBPFBG : FBDKAIFPLCP
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public CGOHPMBPFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DisableAutoCreation]
public sealed class IMHFNPPBDHO : FBDKAIFPLCP
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public override bool MFILHBIABJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public IMHFNPPBDHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[AttributeUsage(AttributeTargets.Class)]
public class AAJOBPJHKPG : BFBIAJNEBGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public AAJOBPJHKPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JNACHFGCBBE
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate void EJEBAKCFMFP<From, To>(From HOIDFJHLMNC, ref To DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class KHKNGHLOGBO<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static EJEBAKCFMFP<From, To> CKGKALCEJPD;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public KHKNGHLOGBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x346DD20", Offset = "0x346C520", VA = "0x18346DD20")]
	static JNACHFGCBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xC5D030", Offset = "0xC5B830", VA = "0x180C5D030")]
	public static void PKFBMKIKJPG<T>(EJEBAKCFMFP<T, T> BFPIIBOIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xC5D470", Offset = "0xC5BC70", VA = "0x180C5D470")]
	public static void PKFBMKIKJPG<From, To>(EJEBAKCFMFP<From, To> BFPIIBOIDNP, EJEBAKCFMFP<To, From> DNFGPDAADMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0xC5CEC0", Offset = "0xC5B6C0", VA = "0x180C5CEC0")]
	public static void PKFBMKIKJPG<From, To>(EJEBAKCFMFP<From, To> CKGKALCEJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x525A110", Offset = "0x5258910", VA = "0x18525A110")]
	public static EJEBAKCFMFP<From, To> IEMPMEBCFGI<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xC5BCA0", Offset = "0xC5A4A0", VA = "0x180C5BCA0")]
	public static void AFABAMMDGPO<From, To>(From HOIDFJHLMNC, ref To DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class EDEBCBMIEIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> JIHDFNFMFNI;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F320", Offset = "0x1D4DB20", VA = "0x181D4F320")]
	public EDEBCBMIEIE(NativeArray<EntityRemapUtility.EntityRemapInfo> JIHDFNFMFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x346B310", Offset = "0x3469B10", VA = "0x18346B310")]
	public Entity AAMCPFCEHAJ(Entity MOLPKNIJMDK)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class HPLNFDKCPIA
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Dictionary<(ulong hash, uint version), string> CGLCAILHILD;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x346D650", Offset = "0x346BE50", VA = "0x18346D650")]
	public static bool GOMJIKEMHEG(ulong KEMMPLOELNM, uint KAGEGNEPBEI, out string JNAACNJBHOF)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Serialization, new string[] { "Timing", "Deprecated", "Types", "Archetypes" })]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private struct KINPIHEAMLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int PDGADEKDACK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int JLICIKJPFHO;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x76F510", Offset = "0x76DD10", VA = "0x18076F510")]
			public KINPIHEAMLN(int AKLHCIJHJKB, int KAGEGNEPBEI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct BLDHGGGGADP
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private static Stopwatch JCFPNGJPFLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private long HNPDPNHFFCE;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public long CPHJFCHNKHL
			{
				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x346AC80", Offset = "0x3469480", VA = "0x18346AC80")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public long MPANHCHCODK
			{
				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x346ACD0", Offset = "0x34694D0", VA = "0x18346ACD0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x346AD40", Offset = "0x3469540", VA = "0x18346AD40")]
			public static BLDHGGGGADP OMIJOPHAOIH()
			{
				return default(BLDHGGGGADP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private struct MIAHBHPHMAK : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public readonly struct MFAPKONKJPB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public unsafe readonly Unity.Entities.Archetype* OHINBOFGIAD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public readonly JKMFOOPDMJK.HPGDCODJCGM.HBPILEDIFBO KLNACBDGCOK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public readonly EDEBCBMIEIE NIBNAFJNIDP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000079")]
				public readonly global::NDHHJFCALDI<IICLMLPIBHG> NEDLOHNFGOO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public readonly int MIEFIAGGHNG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public readonly int CLJFBMDOKCI;

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x346E230", Offset = "0x346CA30", VA = "0x18346E230")]
				public unsafe MFAPKONKJPB(Unity.Entities.Archetype* OHINBOFGIAD, JKMFOOPDMJK.HPGDCODJCGM.HBPILEDIFBO KLNACBDGCOK, EDEBCBMIEIE NIBNAFJNIDP, global::NDHHJFCALDI<IICLMLPIBHG> NEDLOHNFGOO, int MIEFIAGGHNG, int CLJFBMDOKCI = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x346E1E0", Offset = "0x346C9E0", VA = "0x18346E1E0")]
				public MFAPKONKJPB(in MFAPKONKJPB DMDONNOOOJK, int CLJFBMDOKCI)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public readonly MFAPKONKJPB[] HPGJMGNMMCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public string[] LAJPKMJIBCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int MAMMOPEPELJ;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x346E950", Offset = "0x346D150", VA = "0x18346E950")]
			public MIAHBHPHMAK(MFAPKONKJPB[] HPGJMGNMMCF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x346E650", Offset = "0x346CE50", VA = "0x18346E650", Slot = "4")]
			public void Invoke(int AKLHCIJHJKB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x346E2F0", Offset = "0x346CAF0", VA = "0x18346E2F0")]
			private void GMCHFPBKEOM(in MFAPKONKJPB DMDONNOOOJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x346E6B0", Offset = "0x346CEB0", VA = "0x18346E6B0")]
			private static void MOKKJKGPJKJ(in MFAPKONKJPB DMDONNOOOJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class BDOJLCKBHAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public JKMFOOPDMJK asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public global::NDHHJFCALDI<IICLMLPIBHG> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public BDOJLCKBHAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x346ABB0", Offset = "0x34693B0", VA = "0x18346ABB0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class CCJDKBFLMII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public JKMFOOPDMJK.HPGDCODJCGM.HBPILEDIFBO srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public BDOJLCKBHAP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public CCJDKBFLMII()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class PABFPCHNPJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public CCJDKBFLMII CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public PABFPCHNPJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x346EAD0", Offset = "0x346D2D0", VA = "0x18346EAD0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static FLAFLKKHHEA PONIDKHMHNK;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static FLAFLKKHHEA LDMGPLDLLDF;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static FLAFLKKHHEA OEHDPJOLOJJ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static FLAFLKKHHEA KFLKKGJBCGA;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static bool IGJKFLBFNHN;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static JKMFOOPDMJK.HPGDCODJCGM.OONMKKMOIMM DDKFGBDMBEN;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3473990", Offset = "0x3472190", VA = "0x183473990")]
		private unsafe static bool IOEJNPNFDEP(Unity.Entities.Archetype* EOKDKGJACDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3471EE0", Offset = "0x34706E0", VA = "0x183471EE0")]
		internal unsafe static Unity.Entities.Archetype*[] EPCOBOMBGBB(ref Unity.Entities.EntityComponentStore DMMKOBFMDPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3473410", Offset = "0x3471C10", VA = "0x183473410")]
		public static void HDBNDDBCIJK(FDJJGOGKMHG LMKNNIPOPLE, out ByteString HDPBFIPIIDN, out NativeArray<EntityRemapUtility.EntityRemapInfo> IAAOHCGIMLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x34722B0", Offset = "0x3470AB0", VA = "0x1834722B0")]
		internal static void FFIIFLDMLAG(FDJJGOGKMHG LMKNNIPOPLE, JKMFOOPDMJK EGGAMCNGCAH, out NativeArray<EntityRemapUtility.EntityRemapInfo> IAAOHCGIMLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3474BA0", Offset = "0x34733A0", VA = "0x183474BA0")]
		private unsafe static UnsafeHashMap<ulong, KINPIHEAMLN> MKKHDGGHNPK(Unity.Entities.Archetype*[] IGIABEFFIFM)
		{
			return default(UnsafeHashMap<ulong, KINPIHEAMLN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3473A80", Offset = "0x3472280", VA = "0x183473A80")]
		private static void KGGMAOKJDCD(JKMFOOPDMJK EGGAMCNGCAH, UnsafeHashMap<ulong, KINPIHEAMLN> BKJOCEPLDDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3474640", Offset = "0x3472E40", VA = "0x183474640")]
		private unsafe static void LOFNPONMOLA(JKMFOOPDMJK EGGAMCNGCAH, Unity.Entities.Archetype*[] IGIABEFFIFM, UnsafeHashMap<ulong, KINPIHEAMLN> BKJOCEPLDDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3474E00", Offset = "0x3473600", VA = "0x183474E00")]
		private unsafe static int OFBJKPPLJPG(Unity.Entities.Archetype*[] IGIABEFFIFM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x34741A0", Offset = "0x34729A0", VA = "0x1834741A0")]
		private unsafe static void KKPMKIFDJJM(JKMFOOPDMJK EGGAMCNGCAH, Unity.Entities.Archetype*[] IGIABEFFIFM, global::NDHHJFCALDI<IICLMLPIBHG> NEDLOHNFGOO, NativeArray<EntityRemapUtility.EntityRemapInfo> IAAOHCGIMLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3472090", Offset = "0x3470890", VA = "0x183472090")]
		private static NativeArray<int> FEOBPCGLEEF(JKMFOOPDMJK EGGAMCNGCAH)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3473660", Offset = "0x3471E60", VA = "0x183473660")]
		private static Memory<EntityArchetype> HOHIOKMIEEH(JKMFOOPDMJK EGGAMCNGCAH, NativeArray<int> PDJCGKDLAGG, EntityManager FNBDEMCEOPA, out int DCGMGAFHKLB, out int OPJCOBLJHEI)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3471B30", Offset = "0x3470330", VA = "0x183471B30")]
		private unsafe static void ADANCLNPOPE(Unity.Entities.Chunk* NMBDMCFCHDJ, ReadOnlySpan<byte> HDPBFIPIIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3472D60", Offset = "0x3471560", VA = "0x183472D60")]
		private static void GOANPOECNID(JKMFOOPDMJK EGGAMCNGCAH, NativeArray<int> PDJCGKDLAGG, Span<EntityArchetype> IGIABEFFIFM, EntityManager FNBDEMCEOPA, global::NDHHJFCALDI<IICLMLPIBHG> NEDLOHNFGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3474E70", Offset = "0x3473670", VA = "0x183474E70")]
		private unsafe static void PNECLBBNLMC(Unity.Entities.Chunk* ENPKJHPNEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3471860", Offset = "0x3470060", VA = "0x183471860")]
		private unsafe static void ACGOEKLOEOO(JKMFOOPDMJK.HPGDCODJCGM.HBPILEDIFBO OHINBOFGIAD, int HPAECDNJPOG, int FNEGBOMJEKD, Unity.Entities.Chunk* NMBDMCFCHDJ, JKMFOOPDMJK EGGAMCNGCAH, NativeArray<int> PDJCGKDLAGG, global::NDHHJFCALDI<IICLMLPIBHG> NEDLOHNFGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3473C10", Offset = "0x3472410", VA = "0x183473C10")]
		public static void KGOPKPBAMCN(FDJJGOGKMHG LMKNNIPOPLE, in ByteString HDPBFIPIIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3473CA0", Offset = "0x34724A0", VA = "0x183473CA0")]
		public static void KGOPKPBAMCN(EntityManager FNBDEMCEOPA, global::NDHHJFCALDI<IICLMLPIBHG> NEDLOHNFGOO, in ByteString HDPBFIPIIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3474900", Offset = "0x3473100", VA = "0x183474900")]
		private static bool MCMMMLELGJF(Type BKDBLJPNPPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3472BB0", Offset = "0x34713B0", VA = "0x183472BB0")]
		private static void GKJADDHGCDO(TypeManager.TypeInfo CFCBKEKELBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x34734C0", Offset = "0x3471CC0", VA = "0x1834734C0")]
		private unsafe static int HGMOFAIMJEE(Unity.Entities.Archetype*[] IGIABEFFIFM, NativeArray<EntityRemapUtility.EntityRemapInfo> IAAOHCGIMLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3471E00", Offset = "0x3470600", VA = "0x183471E00")]
		private static int CNFNDDGPMLL(int JCCEMLFDLOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x34745A0", Offset = "0x3472DA0", VA = "0x1834745A0")]
		private static ulong KPHPFHKGIIM(int JCCEMLFDLOM)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class GKNGEHOMIKM
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x346CA30", Offset = "0x346B230", VA = "0x18346CA30")]
	private unsafe static Span<byte> OEKMNMDFJPB(Unity.Entities.Chunk* ENPKJHPNEAL, int MIEFIAGGHNG)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4F5AAC0", Offset = "0x4F592C0", VA = "0x184F5AAC0")]
	public unsafe static Span<T> LAJFLEKIHFG<T>(Unity.Entities.Chunk* ENPKJHPNEAL, int MIEFIAGGHNG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1AC2900", Offset = "0x1AC1100", VA = "0x181AC2900")]
	public static Span<T> LAJFLEKIHFG<T>(this ref Unity.Entities.Chunk ENPKJHPNEAL, int MIEFIAGGHNG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x346C720", Offset = "0x346AF20", VA = "0x18346C720")]
	public unsafe static Span<Entity> EPPHJFJLIGF(Unity.Entities.Chunk* ENPKJHPNEAL)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x346C780", Offset = "0x346AF80", VA = "0x18346C780")]
	public unsafe static void IDPJIGKEBOL(Unity.Entities.Chunk* ENPKJHPNEAL, int MIEFIAGGHNG)
	{
	}
}
namespace RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[Preserve]
	internal class _RRAssemblyIndex : KOGEJEDODIH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3475110", Offset = "0x3473910", VA = "0x183475110", Slot = "4")]
		public sealed override void DJCOPMFLKGB()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class PGKFNNKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static byte[] EGKMOPGLIPA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int JGABFFAEPHC;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static int OCNADIFHHML;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static BigInteger GACCCDCMEHO;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PGKFNNKCMAN()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
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

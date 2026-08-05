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
internal static class AOFLLEEIHPF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4B40800", Offset = "0x4B3F800", VA = "0x184B40800")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> FIPBFNEJIJJ(this ref Unity.Entities.Archetype CPEAGKNFJFE)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NLHODEGFBIP
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B43FF0", Offset = "0x4B42FF0", VA = "0x184B43FF0")]
	public static Span<int> MOBIMDHECHC(this EntityArchetype CPEAGKNFJFE)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BBPHHKFFFHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B40950", Offset = "0x4B3F950", VA = "0x184B40950")]
	public static bool NFKGIEPPODC(this Entity CLCJGDKEGGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EMOGBDNBJHP
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct CLCIMDLBJNE<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EEOIKIKHBHP : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public global::CLCIMDLBJNE<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5E6000", Offset = "0x5E5000", VA = "0x1805E6000", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x271F260", Offset = "0x271E260", VA = "0x18271F260", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1CB98B0", Offset = "0x1CB88B0", VA = "0x181CB98B0")]
		[DebuggerHidden]
		public EEOIKIKHBHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x271F060", Offset = "0x271E060", VA = "0x18271F060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x271F210", Offset = "0x271E210", VA = "0x18271F210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Action<Protobuf> EAIKOGBPNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MemoryStream GHCLMNIOMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CodedInputStream PPDFGJBGALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Protobuf EFNFNPMBGKJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PFBDFFJNJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CD0", Offset = "0x5E4CD0", VA = "0x1805E5CD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x271A290", Offset = "0x2719290", VA = "0x18271A290")]
	private CLCIMDLBJNE(byte[] AIKEPJOBOJF, Action<Protobuf> EAIKOGBPNOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x237C310", Offset = "0x237B310", VA = "0x18237C310")]
	public static global::CLCIMDLBJNE<Protobuf> FBMLCAAKPML<Data>(ReadOnlySpan<byte> OBPMMCCMALJ, ReadOnlySpan<Data> OOEEMCHEMCH, Action<Protobuf> EAIKOGBPNOF)
	{
		return default(global::CLCIMDLBJNE<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x271A0F0", Offset = "0x27190F0", VA = "0x18271A0F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x271A130", Offset = "0x2719130", VA = "0x18271A130", Slot = "4")]
	[IteratorStateMachine(typeof(global::CLCIMDLBJNE<>.EEOIKIKHBHP))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x271A230", Offset = "0x2719230", VA = "0x18271A230", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct DCNJLHKFDFG<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly byte[] AIKEPJOBOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly Protobuf EFNFNPMBGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MemoryStream GHCLMNIOMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CodedOutputStream HHJDLJAHJLP;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2178CD0", Offset = "0x2177CD0", VA = "0x182178CD0")]
	private DCNJLHKFDFG(byte[] AIKEPJOBOJF, in Protobuf EFNFNPMBGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x237F010", Offset = "0x237E010", VA = "0x18237F010")]
	public static global::DCNJLHKFDFG<Protobuf> FBMLCAAKPML<T>(ReadOnlySpan<T> OOEEMCHEMCH)
	{
		return default(global::DCNJLHKFDFG<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2178CA0", Offset = "0x2177CA0", VA = "0x182178CA0")]
	public void JFOCKMONHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2178AE0", Offset = "0x2177AE0", VA = "0x182178AE0")]
	public ByteString ALONMOIKOEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2178B70", Offset = "0x2177B70", VA = "0x182178B70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct JGOIJDIMFPO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MemoryStream GHCLMNIOMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CodedInputStream PPDFGJBGALG;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4B43440", Offset = "0x4B42440", VA = "0x184B43440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DBMAHHLHJAD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly byte[] AIKEPJOBOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MemoryStream GHCLMNIOMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CodedOutputStream HHJDLJAHJLP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4B41090", Offset = "0x4B40090", VA = "0x184B41090", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class GHANPLDJGAM : KLAMIKMDEHP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Type NFJMNLGODPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5490", Offset = "0x5E4490", VA = "0x1805E5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xE54080", Offset = "0xE53080", VA = "0x180E54080")]
	public GHANPLDJGAM(Type DAKGNAFFLOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DBPJPAFHGNL : GHANPLDJGAM
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xE54080", Offset = "0xE53080", VA = "0x180E54080")]
	public DBPJPAFHGNL(Type DAKGNAFFLOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KCMJHFGCDKG : GHANPLDJGAM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Type CGJLGANODPI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E54A0", Offset = "0x5E44A0", VA = "0x1805E54A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B43480", Offset = "0x4B42480", VA = "0x184B43480")]
	public KCMJHFGCDKG(Type PCJBNONMJIE, Type DAKGNAFFLOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MHFLLNJDCAI : GHANPLDJGAM
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xE54080", Offset = "0xE53080", VA = "0x180E54080")]
	public MHFLLNJDCAI(Type DAKGNAFFLOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ILJNJGIAJDG : KLAMIKMDEHP
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public ILJNJGIAJDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NAOOJGDIFNC : KLAMIKMDEHP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DIAOBOKGPEM OBHBOOFBAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E5ED0", Offset = "0x5E4ED0", VA = "0x1805E5ED0")]
		[CompilerGenerated]
		get
		{
			return default(DIAOBOKGPEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xE542B0", Offset = "0xE532B0", VA = "0x180E542B0")]
	public NAOOJGDIFNC(DIAOBOKGPEM AANEECAEOLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
public class PHHIOCMBCOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IEPEPKBAJCN BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly EntityManager EFLHIHFKEDM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEPEPKBAJCN NGCBAEGEPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4B44B70", Offset = "0x4B43B70", VA = "0x184B44B70")]
	public PHHIOCMBCOD(IEPEPKBAJCN BICCGEMNLEI, EntityManager EFLHIHFKEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4B44A70", Offset = "0x4B43A70", VA = "0x184B44A70")]
	public int JIHCOOCALIN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x24ED6B0", Offset = "0x24EC6B0", VA = "0x1824ED6B0")]
	public bool AIJGMEIBJBE<T>(Entity CLCJGDKEGGN) where T : struct, JPKKKJLCGBD
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x24ED6F0", Offset = "0x24EC6F0", VA = "0x1824ED6F0")]
	public bool GNHEHJNNNJC<T>(Entity CLCJGDKEGGN, out T JNLOLNFALGF) where T : struct, JPKKKJLCGBD
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x20C5B40", Offset = "0x20C4B40", VA = "0x1820C5B40")]
	public T NHMOMEKBJAP<T>(Entity CLCJGDKEGGN) where T : struct, JPKKKJLCGBD
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x390E960", Offset = "0x390D960", VA = "0x18390E960")]
	private ComponentType OBGIHPCOPNP<T>() where T : struct, JPKKKJLCGBD
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4B44AC0", Offset = "0x4B43AC0", VA = "0x184B44AC0")]
	private ComponentType OBGIHPCOPNP(Type GLKKDGLKBMK)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class HNBAIDHJJFO
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	protected HNBAIDHJJFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class AABIADOILAK<View, Data> : OIINEGGMHHI where View : struct, JPKKKJLCGBD where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static ComponentType HDKEMOACKKG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override Type CBJGAFHKFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5299100", Offset = "0x5298100", VA = "0x185299100", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override Type PKALFBMDPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5299160", Offset = "0x5298160", VA = "0x185299160", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override int HBGJEEAIOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x309E580", Offset = "0x309D580", VA = "0x18309E580", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x309D640", Offset = "0x309C640", VA = "0x18309D640")]
	public Data IDABPICLBKH(Entity CLCJGDKEGGN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x309D6C0", Offset = "0x309C6C0", VA = "0x18309D6C0")]
	public Data IKNOBPDJDGB(Entity CLCJGDKEGGN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected internal abstract View OFBPBDBEFAA(Entity CLCJGDKEGGN);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x204C220", Offset = "0x204B220", VA = "0x18204C220", Slot = "15")]
	protected internal override T OFBPBDBEFAA<T>(Entity CLCJGDKEGGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x309C7C0", Offset = "0x309B7C0", VA = "0x18309C7C0", Slot = "16")]
	public override bool AIJGMEIBJBE(Entity CLCJGDKEGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2000450", Offset = "0x1FFF450", VA = "0x182000450")]
	protected AABIADOILAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class OIINEGGMHHI : ENCFKNPILEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private ArchetypeChunkComponentTypeDynamic FKBDLELLGAL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EntityManager OLPNKMBFBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8FFB70", Offset = "0x8FEB70", VA = "0x1808FFB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public abstract Type CBJGAFHKFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public abstract Type PKALFBMDPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public abstract int HBGJEEAIOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private Type PLPGBIHKIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB100", Offset = "0x6CA100", VA = "0x1806CB100", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int EAKPCKCHFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4B447C0", Offset = "0x4B437C0", VA = "0x184B447C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private FOHAFCOAAJF[] OJJJMMCIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC18BF0", Offset = "0xC17BF0", VA = "0x180C18BF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	protected internal virtual FOHAFCOAAJF[] NIMHCIPCJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4B44900", Offset = "0x4B43900", VA = "0x184B44900", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MKENDPLDIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4B446F0", Offset = "0x4B436F0", VA = "0x184B446F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4B44560", Offset = "0x4B43560", VA = "0x184B44560")]
	public void AICHPOAHICB(EntityManager EFLHIHFKEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69AF60", Offset = "0x699F60", VA = "0x18069AF60")]
	protected ENCFKNPILEO AFHCAEPMEBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T OFBPBDBEFAA<T>(Entity CLCJGDKEGGN) where T : struct, JPKKKJLCGBD;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract bool AIJGMEIBJBE(Entity CLCJGDKEGGN);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4B44830", Offset = "0x4B43830", VA = "0x184B44830", Slot = "8")]
	public (uint, uint) JDEMNIGCMPB(Entity CLCJGDKEGGN)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4B44720", Offset = "0x4B43720", VA = "0x184B44720", Slot = "9")]
	public bool FNOEPDJHNIA(Entity CLCJGDKEGGN, (uint order, uint change) GDLEDDNCPGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	protected OIINEGGMHHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class BKGFJPEEJEL<Data> : IMAELFMBFEM where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public virtual Data CDLKEADKJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x24D0330", Offset = "0x24CF330", VA = "0x1824D0330", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1F998F0", Offset = "0x1F988F0", VA = "0x181F998F0", Slot = "8")]
	protected virtual bool EJPKJFPDJFG(ReadOnlySpan<Data> OOEEMCHEMCH, HDKJKHCKAFP PEEOAAMJPAN, out ReadOnlySpan<byte> OBPMMCCMALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "9")]
	protected virtual bool GKMEJJHJMGG(int GDLEDDNCPGJ, Span<Data> OOEEMCHEMCH, in ReadOnlySpan<byte> OBPMMCCMALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x24D0530", Offset = "0x24CF530", VA = "0x1824D0530", Slot = "5")]
	internal sealed override bool EJPKJFPDJFG(ref Unity.Entities.Chunk BLGAELJLCIM, int GGHMAFNNMAA, HDKJKHCKAFP PEEOAAMJPAN, out ReadOnlySpan<byte> OBPMMCCMALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x24D13A0", Offset = "0x24D03A0", VA = "0x1824D13A0", Slot = "6")]
	internal sealed override bool GKMEJJHJMGG(int GDLEDDNCPGJ, ref Unity.Entities.Chunk BLGAELJLCIM, int GGHMAFNNMAA, in ReadOnlySpan<byte> OBPMMCCMALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2377CA0", Offset = "0x2376CA0", VA = "0x182377CA0")]
	protected global::DCNJLHKFDFG<Protobuf> LDPNEPNJADM<Protobuf>(ReadOnlySpan<Data> OOEEMCHEMCH) where Protobuf : IMessage, new()
	{
		return default(global::DCNJLHKFDFG<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2377CF0", Offset = "0x2376CF0", VA = "0x182377CF0")]
	protected global::CLCIMDLBJNE<Protobuf> MDDCMKPEJKG<Protobuf>(ReadOnlySpan<byte> OBPMMCCMALJ, ReadOnlySpan<Data> OOEEMCHEMCH, Action<Protobuf> EAIKOGBPNOF) where Protobuf : IMessage, new()
	{
		return default(global::CLCIMDLBJNE<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2000450", Offset = "0x1FFF450", VA = "0x182000450")]
	protected BKGFJPEEJEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class IMAELFMBFEM
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	protected internal abstract int ICOAIKCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4B43280", Offset = "0x4B42280", VA = "0x184B43280", Slot = "5")]
	internal virtual bool EJPKJFPDJFG(ref Unity.Entities.Chunk BLGAELJLCIM, int GGHMAFNNMAA, HDKJKHCKAFP PEEOAAMJPAN, out ReadOnlySpan<byte> OBPMMCCMALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "6")]
	internal virtual bool GKMEJJHJMGG(int GDLEDDNCPGJ, ref Unity.Entities.Chunk BLGAELJLCIM, int GGHMAFNNMAA, in ReadOnlySpan<byte> OBPMMCCMALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	protected IMAELFMBFEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KLMIPCJCDPP
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[BurstCompile]
internal struct PIJCHEFJJFO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe Unity.Entities.EntityComponentStore* HOBFDLCLKEH;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4B44D50", Offset = "0x4B43D50", VA = "0x184B44D50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PCPHPFBIEPK
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMCBIJDGDOF(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class HBJFPKIAIBN
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2F670A0", Offset = "0x2F660A0", VA = "0x182F670A0")]
	public static void HFLBCOPIMHO<T>(this ref T COJAKLHGGGK, ref ArchetypeChunkIterator NLKABGNDIMP) where T : struct, PCPHPFBIEPK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2F67290", Offset = "0x2F66290", VA = "0x182F67290")]
	public static void HFLBCOPIMHO<T>(this ref T COJAKLHGGGK, EntityQuery MFJLNKKMCPM) where T : struct, PCPHPFBIEPK
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IPNIHFMFHEM
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4B432A0", Offset = "0x4B422A0", VA = "0x184B432A0")]
	public static bool GPHADCICHAL(Type GLKKDGLKBMK, Type FHEHGHAHEEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal abstract class LCLAHLHBPIG<Attribute, BaseClass> : global::IIGAODPMKFH<BaseClass>, MJIIOHDKLCN where Attribute : GHANPLDJGAM
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string MBHNCPMPIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<int, Type> HHLLFFPAFFL;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x27BE130", Offset = "0x27BD130", VA = "0x1827BE130")]
	public LCLAHLHBPIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27BDB80", Offset = "0x27BCB80", VA = "0x1827BDB80", Slot = "4")]
	public bool FAFGFNINKJO(int KICCJKJLKLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27BDD70", Offset = "0x27BCD70", VA = "0x1827BDD70", Slot = "5")]
	public global::LCJIKJFODKN<BaseClass> PAGPOODDPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27BDBE0", Offset = "0x27BCBE0", VA = "0x1827BDBE0", Slot = "7")]
	protected virtual bool GPHADCICHAL(Type GLKKDGLKBMK, int MINGPPIPHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27BE040", Offset = "0x27BD040", VA = "0x1827BE040", Slot = "8")]
	protected virtual int PCJNKPEELAB(Type GLKKDGLKBMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x27BDB10", Offset = "0x27BCB10", VA = "0x1827BDB10")]
	public void CIJCLICMJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x27BDCD0", Offset = "0x27BCCD0", VA = "0x1827BDCD0", Slot = "6")]
	public void HCCDLMMPDLB(Type GLKKDGLKBMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LCJIKJFODKN<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<int, BaseClass> PCLHLFJJGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<Type, BaseClass> PKJBIKAHENI;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IEnumerable<BaseClass> CJLKJJGHADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x27BD530", Offset = "0x27BC530", VA = "0x1827BD530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27BD980", Offset = "0x27BC980", VA = "0x1827BD980")]
	public LCJIKJFODKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x27BD7E0", Offset = "0x27BC7E0", VA = "0x1827BD7E0")]
	public LCJIKJFODKN(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x27BD760", Offset = "0x27BC760", VA = "0x1827BD760")]
	internal void PPCBFHPPBHE(int KICCJKJLKLA, BaseClass OPCFMFLMDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x24E13A0", Offset = "0x24E03A0", VA = "0x1824E13A0")]
	public bool NNHCNBEGLLJ<T>(out BaseClass JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x27BD490", Offset = "0x27BC490", VA = "0x1827BD490")]
	public bool NNHCNBEGLLJ(Type OHBFPBMFEHG, out BaseClass JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x26D6D60", Offset = "0x26D5D60", VA = "0x1826D6D60")]
	public bool KDBJOHMDHMJ(int KICCJKJLKLA, out BaseClass JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x20C0310", Offset = "0x20BF310", VA = "0x1820C0310")]
	public T JJCLHNFJHBA<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x27BD460", Offset = "0x27BC460", VA = "0x1827BD460")]
	public BaseClass JJCLHNFJHBA(Type CLFMOIAHPHG)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class EIMKDMOCIEB : global::LCLAHLHBPIG<DBPJPAFHGNL, HNBAIDHJJFO>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4B411C0", Offset = "0x4B401C0", VA = "0x184B411C0")]
	public EIMKDMOCIEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class GKAMDICMFCI : global::LCLAHLHBPIG<KCMJHFGCDKG, OIINEGGMHHI>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4B41F30", Offset = "0x4B40F30", VA = "0x184B41F30")]
	public GKAMDICMFCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class KIEDGNFLNDC : global::LCLAHLHBPIG<MHFLLNJDCAI, IMAELFMBFEM>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4B434D0", Offset = "0x4B424D0", VA = "0x184B434D0")]
	public KIEDGNFLNDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct OAHKHLHAABA
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Type> AKGOADBOKFP;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x726470", Offset = "0x725470", VA = "0x180726470")]
	private OAHKHLHAABA(List<Type> AKGOADBOKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4B44060", Offset = "0x4B43060", VA = "0x184B44060")]
	public static void CIJCLICMJID(List<Type> AKGOADBOKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4B44110", Offset = "0x4B43110", VA = "0x184B44110")]
	private void FBAJNCFBHME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4B44310", Offset = "0x4B43310", VA = "0x184B44310")]
	private bool GPHADCICHAL(Type GLKKDGLKBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4B442B0", Offset = "0x4B432B0", VA = "0x184B442B0")]
	private void FFPGOJMKEMM(Type GLKKDGLKBMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface IIGAODPMKFH<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAFGFNINKJO(int KICCJKJLKLA);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::LCJIKJFODKN<BaseClass> PAGPOODDPDD();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class HEODJEKIBCE : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0")]
	protected HEODJEKIBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class DCFPPMHCPFJ : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0")]
	protected DCFPPMHCPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class OHAOLCPCNLC : HEODJEKIBCE
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4B44530", Offset = "0x4B43530", VA = "0x184B44530", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	protected void DLGIFPHPCHO(string PLNPNPKDGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0")]
	protected OHAOLCPCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[DOKDCAPODCB(PBFEFLGCHAA.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4B45B20", Offset = "0x4B44B20", VA = "0x184B45B20")]
		public static ComponentSystemGroup[] MHJJIDKICNC(World BICCGEMNLEI, HGCMEPOMPAE NICKNBOCCIC = HGCMEPOMPAE.Default, bool OHPAPILKJAJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4B45BF0", Offset = "0x4B44BF0", VA = "0x184B45BF0")]
		private static Type[] MIMADAFHBIN(HGCMEPOMPAE NICKNBOCCIC, bool OHPAPILKJAJ, ComponentSystemGroup[] CIHKGONBIAB, ComponentSystemGroup NFDHJNAOJOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4B45880", Offset = "0x4B44880", VA = "0x184B45880")]
		private static ComponentSystemGroup[] LEBFGCMGGLC(World BICCGEMNLEI, out ComponentSystemGroup NFDHJNAOJOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4B455C0", Offset = "0x4B445C0", VA = "0x184B455C0")]
		internal static bool IFKJJBBPBDG(DIAOBOKGPEM AANEECAEOLG, out NBDAPPGFLGM KKOLAMBCFLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4B457B0", Offset = "0x4B447B0", VA = "0x184B457B0")]
		private static ComponentSystemGroup IIHFDKOAGBA(Type GLKKDGLKBMK, World BICCGEMNLEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4B45090", Offset = "0x4B44090", VA = "0x184B45090")]
		private static ComponentSystemGroup[] GHJHJKOJGCN(Type[] AKGOADBOKFP, World BICCGEMNLEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4B45190", Offset = "0x4B44190", VA = "0x184B45190")]
		internal static void HMEEHNMADOK(World BICCGEMNLEI, Type[] JDHNAOGLPNC, ComponentSystemGroup[] CIHKGONBIAB, ComponentSystemGroup NFDHJNAOJOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4B45030", Offset = "0x4B44030", VA = "0x184B45030")]
		internal static bool DIBDPIFPENF(ComponentSystemBase EIDKOILJGBL, ComponentSystemGroup[] CIHKGONBIAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4B44FD0", Offset = "0x4B43FD0", VA = "0x184B44FD0")]
		private static void CICGHGLBKJH(ComponentSystemGroup[] CIHKGONBIAB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct HDOGNPBKHIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly Dictionary<Type, List<Type>> CDOAADBFHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly HashSet<Type> AFGKGBPBAKC;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x60A7B0", Offset = "0x6097B0", VA = "0x18060A7B0")]
	public HDOGNPBKHIJ(Dictionary<Type, List<Type>> CDOAADBFHHB, HashSet<Type> AFGKGBPBAKC)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[DOKDCAPODCB(PBFEFLGCHAA.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class FGAICMNLCNP : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6F63E0", Offset = "0x6F53E0", VA = "0x1806F63E0")]
			[DebuggerHidden]
			public FGAICMNLCNP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x4B41E30", Offset = "0x4B40E30", VA = "0x184B41E30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x4B41B80", Offset = "0x4B40B80", VA = "0x184B41B80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x4B41EE0", Offset = "0x4B40EE0", VA = "0x184B41EE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x4B41DE0", Offset = "0x4B40DE0", VA = "0x184B41DE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x4B41D30", Offset = "0x4B40D30", VA = "0x184B41D30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4B41D30", Offset = "0x4B40D30", VA = "0x184B41D30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct JKIHPKNCIAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Type PGLALGIPJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private HGCMEPOMPAE NICKNBOCCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool JJPLDDEHHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool IPCPCIGGLKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool OHPAPILKJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IEnumerable<Type> BHOIFMAONBO;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4B460F0", Offset = "0x4B450F0", VA = "0x184B460F0")]
		public static RRFilterWorldSystems FBMLCAAKPML()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4B46D20", Offset = "0x4B45D20", VA = "0x184B46D20")]
		public RRFilterWorldSystems OMKKFOABPDE(HGCMEPOMPAE AANEECAEOLG)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4B46C00", Offset = "0x4B45C00", VA = "0x184B46C00")]
		public RRFilterWorldSystems NFNCFOCAEBD(IEnumerable<Type> AKGOADBOKFP)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4B46430", Offset = "0x4B45430", VA = "0x184B46430")]
		public RRFilterWorldSystems FJIGAHEEPDF(bool JPFHJGKCECO)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4B45F70", Offset = "0x4B44F70", VA = "0x184B45F70")]
		public RRFilterWorldSystems APBJMHFMMIH(bool PJGKEEONEGJ)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4B46610", Offset = "0x4B45610", VA = "0x184B46610")]
		public HDOGNPBKHIJ KDJPAELMGBH(Type[] EFHEDLHFJAK)
		{
			return default(HDOGNPBKHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4B46440", Offset = "0x4B45440", VA = "0x184B46440")]
		[IteratorStateMachine(typeof(FGAICMNLCNP))]
		internal IEnumerable<Type> FKDHKCDHPIA(IEnumerable<Type> AKGOADBOKFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4B46120", Offset = "0x4B45120", VA = "0x184B46120")]
		internal Dictionary<Type, List<Type>> FEMHPGDGPEF(IEnumerable<Type> AKGOADBOKFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4B46C40", Offset = "0x4B45C40", VA = "0x184B46C40")]
		private void OGNJFHINHAN(Dictionary<Type, List<Type>> DGKOICOAPAE, Type GLKKDGLKBMK, Type NLDPCDGLEIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4B45F80", Offset = "0x4B44F80", VA = "0x184B45F80")]
		internal HashSet<Type> EABOHAEOHJB(IEnumerable<Type> CIHKGONBIAB, Dictionary<Type, List<Type>> KINLBAPNNKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4B466A0", Offset = "0x4B456A0", VA = "0x184B466A0")]
		internal bool KPENCOOKOHH(Type GLKKDGLKBMK, HGCMEPOMPAE NICKNBOCCIC, bool OHPAPILKJAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4B464D0", Offset = "0x4B454D0", VA = "0x184B464D0")]
		[CompilerGenerated]
		internal static void INPHOMFBOJD(Type GLKKDGLKBMK, ref JKIHPKNCIAA P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class PJDHCJDKEOB
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static bool GIKDDFOMBOL;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4B44E00", Offset = "0x4B43E00", VA = "0x184B44E00")]
	public static void AICHPOAHICB(bool MJIEEJJMIKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4B44E50", Offset = "0x4B43E50", VA = "0x184B44E50")]
	private static void NMGPIHMCLND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class GNOCIJHEKDN
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4B424B0", Offset = "0x4B414B0", VA = "0x184B424B0")]
	public static ulong BJELIAKEOLL(Type GLKKDGLKBMK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4B42400", Offset = "0x4B41400", VA = "0x184B42400")]
	public static ulong BJELIAKEOLL(string OKJKJKOLGOC)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[DOKDCAPODCB(PBFEFLGCHAA.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private struct BDGLJAMAOIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public readonly ulong AJCNIPHDCJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public readonly ulong ENEOBAAKPJL;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xDB5450", Offset = "0xDB4450", VA = "0x180DB5450")]
			public BDGLJAMAOIA(ulong EHKBFNIKEFB, ulong CBABKKAIHPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x4B40970", Offset = "0x4B3F970", VA = "0x184B40970", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static Dictionary<ulong, int> HCHMGDIKJDB;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static BDGLJAMAOIA[] IDGMGOBNMNP;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static bool GIKDDFOMBOL;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4B478B0", Offset = "0x4B468B0", VA = "0x184B478B0")]
		public static ulong MNAHDGBCDMD(int KICCJKJLKLA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4B47770", Offset = "0x4B46770", VA = "0x184B47770")]
		public static int JLGOAGAFJBF(ulong CBABKKAIHPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4B47270", Offset = "0x4B46270", VA = "0x184B47270")]
		public static void AICHPOAHICB(bool MJIEEJJMIKK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4B470D0", Offset = "0x4B460D0", VA = "0x184B470D0")]
		private static void ADHHMLCAGIH(int GLCAOGJAHFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4B46DD0", Offset = "0x4B45DD0", VA = "0x184B46DD0")]
		private static void AAMDGLONHNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4B474A0", Offset = "0x4B464A0", VA = "0x184B474A0")]
		private static BDGLJAMAOIA EODGPEJDLFE(Type GLKKDGLKBMK)
		{
			return default(BDGLJAMAOIA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4B47430", Offset = "0x4B46430", VA = "0x184B47430")]
		private static ulong APOENMKLADB(Type GLKKDGLKBMK, ulong CBABKKAIHPF)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4B47580", Offset = "0x4B46580", VA = "0x184B47580")]
		private static void GLANMKEPFNF(in BDGLJAMAOIA LIPDIOHDLEM, TypeManager.TypeInfo CNPJDLDAEON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4B47910", Offset = "0x4B46910", VA = "0x184B47910")]
		private static void PKLEJACDNHM(BDGLJAMAOIA CNPJDLDAEON, int KICCJKJLKLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4B47190", Offset = "0x4B46190", VA = "0x184B47190")]
		private static void AHOIIAMCFAM(BDGLJAMAOIA CNPJDLDAEON, int KICCJKJLKLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4B47810", Offset = "0x4B46810", VA = "0x184B47810")]
		private static BDGLJAMAOIA KDPAGEHJHCL(int KICCJKJLKLA)
		{
			return default(BDGLJAMAOIA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4B478A0", Offset = "0x4B468A0", VA = "0x184B478A0")]
		private static int LONFGNDMAMJ(int KICCJKJLKLA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NGEFFDCEEDK
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly GKAMDICMFCI ENKBKGKLEOL;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly KIEDGNFLNDC MKKNKBMDDPE;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly EIMKDMOCIEB FNKDADCJBAL;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly List<Type> MBMCLPAFIPF;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static bool GIKDDFOMBOL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	internal static global::IIGAODPMKFH<OIINEGGMHHI> ABENAMCPKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4B43B10", Offset = "0x4B42B10", VA = "0x184B43B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal static global::IIGAODPMKFH<IMAELFMBFEM> AGMHEAAIBDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4B43BE0", Offset = "0x4B42BE0", VA = "0x184B43BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal static global::IIGAODPMKFH<HNBAIDHJJFO> CDCNLNCEBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4B43CA0", Offset = "0x4B42CA0", VA = "0x184B43CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4B436F0", Offset = "0x4B426F0", VA = "0x184B436F0")]
	public static void AICHPOAHICB(bool MJIEEJJMIKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4B43B70", Offset = "0x4B42B70", VA = "0x184B43B70")]
	public static Type[] CABFLCACACB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class GLPMONMKBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly Dictionary<int, int> BGGEJMGDECF;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool GIKDDFOMBOL;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4B422A0", Offset = "0x4B412A0", VA = "0x184B422A0")]
	public static int JDEMNIGCMPB(int KICCJKJLKLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4B41F90", Offset = "0x4B40F90", VA = "0x184B41F90")]
	public static void AICHPOAHICB(bool MJIEEJJMIKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4B42030", Offset = "0x4B41030", VA = "0x184B42030")]
	private static void IDMPMJPINBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4B42250", Offset = "0x4B41250", VA = "0x184B42250")]
	private static int IGHAFIKJHIO(Type GLKKDGLKBMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4B42330", Offset = "0x4B41330", VA = "0x184B42330")]
	private static void MCOHOPDDOPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class IEPEPKBAJCN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly World BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly World INFHBCMIELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly PHHIOCMBCOD OPCFMFLMDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly ComponentSystemGroup[] CIHKGONBIAB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public World NGCBAEGEPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public World MIKMLLKGKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EntityManager OLPNKMBFBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x14BDFF0", Offset = "0x14BCFF0", VA = "0x1814BDFF0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public PHHIOCMBCOD NOINFEGLIDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public global::LCJIKJFODKN<OIINEGGMHHI> ABENAMCPKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x71D880", Offset = "0x71C880", VA = "0x18071D880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public global::LCJIKJFODKN<IMAELFMBFEM> AGMHEAAIBDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E6010", Offset = "0x5E5010", VA = "0x1805E6010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E6020", Offset = "0x5E5020", VA = "0x1805E6020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public global::LCJIKJFODKN<HNBAIDHJJFO> CDCNLNCEBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D70", Offset = "0x5F7D70", VA = "0x1805F8D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x67FFC0", Offset = "0x67EFC0", VA = "0x18067FFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> FALFHKCLHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1C64470", Offset = "0x1C63470", VA = "0x181C64470")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4B425A0", Offset = "0x4B415A0", VA = "0x184B425A0")]
	public static IEPEPKBAJCN DLAMMICBHFE(string MBHNCPMPIFB, DIAOBOKGPEM AANEECAEOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4B42DB0", Offset = "0x4B41DB0", VA = "0x184B42DB0")]
	public IEPEPKBAJCN(string MBHNCPMPIFB, DIAOBOKGPEM AANEECAEOLG = DIAOBOKGPEM.Simulation, HGCMEPOMPAE NICKNBOCCIC = HGCMEPOMPAE.Default, bool MJIEEJJMIKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4B426F0", Offset = "0x4B416F0", VA = "0x184B426F0")]
	public ComponentSystemBase EJAKOGNNAML(Type GLKKDGLKBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x20B5120", Offset = "0x20B4120", VA = "0x1820B5120")]
	public T EJAKOGNNAML<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4B428C0", Offset = "0x4B418C0", VA = "0x184B428C0")]
	public void JFJEBMNFNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4B42620", Offset = "0x4B41620", VA = "0x184B42620")]
	public void DLOPFPKPKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4B42710", Offset = "0x4B41710", VA = "0x184B42710")]
	public void FFGAGNAHIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4B42540", Offset = "0x4B41540", VA = "0x184B42540")]
	public void CPNFEGENCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4B424E0", Offset = "0x4B414E0", VA = "0x184B424E0")]
	public void CEJPIPPANEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B42D30", Offset = "0x4B41D30", VA = "0x184B42D30")]
	public void POIHOMGNDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4B42800", Offset = "0x4B41800", VA = "0x184B42800")]
	public void IJNOEFFMPOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4B42860", Offset = "0x4B41860", VA = "0x184B42860")]
	public void JDKBDKOGGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4B42C30", Offset = "0x4B41C30", VA = "0x184B42C30")]
	internal void NHJAKHLNNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4B42770", Offset = "0x4B41770", VA = "0x184B42770")]
	private bool GEMODINKLOK(ComponentSystemGroup FCEAIEHCMHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4B42A90", Offset = "0x4B41A90", VA = "0x184B42A90")]
	private void MMDKNECNGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B42980", Offset = "0x4B41980", VA = "0x184B42980")]
	private ComponentSystemGroup[] MHJJIDKICNC(HGCMEPOMPAE NICKNBOCCIC, bool OHPAPILKJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4B42920", Offset = "0x4B41920", VA = "0x184B42920")]
	public void JJLINAGCMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4B42680", Offset = "0x4B41680", VA = "0x184B42680", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
public enum DIAOBOKGPEM
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
public sealed class IGGBKBMOAHP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public HGCMEPOMPAE JBGFODMGMKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Flags]
public enum HGCMEPOMPAE
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
public interface NBDAPPGFLGM
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	Type BEFIHIFGLLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Type[] HGKJCPCIDAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class IODFLDNFHOD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public virtual bool LHCCBCIFMID
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FE0", Offset = "0x5E4FE0", VA = "0x1805E5FE0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	protected IODFLDNFHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DisableAutoCreation]
public sealed class BKDGPEGPEMF : IODFLDNFHOD
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public BKDGPEGPEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DisableAutoCreation]
public sealed class PFLDJNCJBHH : IODFLDNFHOD
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public PFLDJNCJBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DisableAutoCreation]
public sealed class NDBIJHILLBK : IODFLDNFHOD
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public NDBIJHILLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DisableAutoCreation]
public sealed class DOPKKIMPBNG : IODFLDNFHOD
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public DOPKKIMPBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DisableAutoCreation]
public sealed class OELKHDELMBL : IODFLDNFHOD
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public OELKHDELMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DisableAutoCreation]
public sealed class MDLGMJDJCNF : IODFLDNFHOD
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public override bool LHCCBCIFMID
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public MDLGMJDJCNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[AttributeUsage(AttributeTargets.Class)]
public class DKBGLDDIENF : KLAMIKMDEHP
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public DKBGLDDIENF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class LGODOIFFNFK
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate void KMBOMKPNCBN<From, To>(From LCEEDPEAPOI, ref To JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class AODDCHJNOAG<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static KMBOMKPNCBN<From, To> ECEFCCEPILO;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public AODDCHJNOAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4B43530", Offset = "0x4B42530", VA = "0x184B43530")]
	static LGODOIFFNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3486DD0", Offset = "0x3485DD0", VA = "0x183486DD0")]
	public static void OCOFANOHJLO<T>(KMBOMKPNCBN<T, T> PFGKAIOOMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3486C20", Offset = "0x3485C20", VA = "0x183486C20")]
	public static void OCOFANOHJLO<From, To>(KMBOMKPNCBN<From, To> PFGKAIOOMAM, KMBOMKPNCBN<To, From> JPIOJBNHNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3285B50", Offset = "0x3284B50", VA = "0x183285B50")]
	public static void OCOFANOHJLO<From, To>(KMBOMKPNCBN<From, To> ECEFCCEPILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x260A140", Offset = "0x2609140", VA = "0x18260A140")]
	public static KMBOMKPNCBN<From, To> ALEMIFIKMKD<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3484BE0", Offset = "0x3483BE0", VA = "0x183484BE0")]
	public static void GONMIDPMMIB<From, To>(From LCEEDPEAPOI, ref To JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class HDKJKHCKAFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> EAABGADCCCA;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0xD5DB80", Offset = "0xD5CB80", VA = "0x180D5DB80")]
	public HDKJKHCKAFP(NativeArray<EntityRemapUtility.EntityRemapInfo> EAABGADCCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x25EBE50", Offset = "0x25EAE50", VA = "0x1825EBE50")]
	public Entity HPOJCOFDJFK(Entity LAAFNHPNJCJ)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class PHLJHJAHDMA
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Dictionary<(ulong hash, uint version), string> GFDIFDPCFEA;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4B44BC0", Offset = "0x4B43BC0", VA = "0x184B44BC0")]
	public static bool PKBLGKMNPEE(ulong KOPCAMHLCEK, uint GDLEDDNCPGJ, out string MBHNCPMPIFB)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[DOKDCAPODCB(PBFEFLGCHAA.Serialization, new string[] { "Timing", "Deprecated", "Types", "Archetypes" })]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private struct JJKLJFKGBLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int KBBNJEDOENJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int ICOAIKCLAGF;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x76ED30", Offset = "0x76DD30", VA = "0x18076ED30")]
			public JJKLJFKGBLI(int IIHEDPBOLFE, int GDLEDDNCPGJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct COBBLNKDPCO
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private static Stopwatch AEHDKKNNPGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private long JGAFFBLBKCA;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public long DELGPNJONBE
			{
				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x4B41040", Offset = "0x4B40040", VA = "0x184B41040")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public long ABEPOPKNPCA
			{
				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x4B40FD0", Offset = "0x4B3FFD0", VA = "0x184B40FD0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x4B40F10", Offset = "0x4B3FF10", VA = "0x184B40F10")]
			public static COBBLNKDPCO DGHCKKHBFIK()
			{
				return default(COBBLNKDPCO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private struct FBMBOMIAFBB : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public readonly struct PAFIPBEHNJH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public unsafe readonly Unity.Entities.Archetype* CDCEBELCEIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public readonly KFBBBEBPJAC.EDHHJIPJFKH.PMOBLNJDAOD AJGOOIKLJHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public readonly HDKJKHCKAFP PEEOAAMJPAN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000079")]
				public readonly global::LCJIKJFODKN<IMAELFMBFEM> NOJKDGAOHNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public readonly int GGHMAFNNMAA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public readonly int CIAPAADGBLF;

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x4B44A10", Offset = "0x4B43A10", VA = "0x184B44A10")]
				public unsafe PAFIPBEHNJH(Unity.Entities.Archetype* CDCEBELCEIG, KFBBBEBPJAC.EDHHJIPJFKH.PMOBLNJDAOD AJGOOIKLJHC, HDKJKHCKAFP PEEOAAMJPAN, global::LCJIKJFODKN<IMAELFMBFEM> NOJKDGAOHNK, int GGHMAFNNMAA, int CIAPAADGBLF = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x4B449C0", Offset = "0x4B439C0", VA = "0x184B449C0")]
				public PAFIPBEHNJH(in PAFIPBEHNJH JEJGBICCBLN, int CIAPAADGBLF)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public readonly PAFIPBEHNJH[] OOEEMCHEMCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public string[] OMEEMCAMIKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int IOJBFMHKDJK;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x4B41A40", Offset = "0x4B40A40", VA = "0x184B41A40")]
			public FBMBOMIAFBB(PAFIPBEHNJH[] OOEEMCHEMCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x4B413E0", Offset = "0x4B403E0", VA = "0x184B413E0", Slot = "4")]
			public void Invoke(int IIHEDPBOLFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x4B41440", Offset = "0x4B40440", VA = "0x184B41440")]
			private void MDFLMCADBPL(in PAFIPBEHNJH JEJGBICCBLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4B417A0", Offset = "0x4B407A0", VA = "0x184B417A0")]
			private static void PNEHBDDCGOK(in PAFIPBEHNJH JEJGBICCBLN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class CEEBKFANMJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public KFBBBEBPJAC asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public global::LCJIKJFODKN<IMAELFMBFEM> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public CEEBKFANMJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x4B40EA0", Offset = "0x4B3FEA0", VA = "0x184B40EA0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class POCIGEFKALK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public KFBBBEBPJAC.EDHHJIPJFKH.PMOBLNJDAOD srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public CEEBKFANMJD CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public POCIGEFKALK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class NGPODJANIKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public POCIGEFKALK CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public NGPODJANIKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x4B43ED0", Offset = "0x4B42ED0", VA = "0x184B43ED0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static LOBJLOAJGBA CEFCPMDHDNF;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static LOBJLOAJGBA CJPLALAELEI;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static LOBJLOAJGBA IDBOKJLJLEE;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static LOBJLOAJGBA GLOCDOKHLGF;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static bool OOOPFGGCPLC;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static KFBBBEBPJAC.EDHHJIPJFKH.HABFJFMIECC EACKMHAOEAO;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4B4AD50", Offset = "0x4B49D50", VA = "0x184B4AD50")]
		private unsafe static bool OMJKGMAPDMB(Unity.Entities.Archetype* CPEAGKNFJFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4B47B30", Offset = "0x4B46B30", VA = "0x184B47B30")]
		internal unsafe static Unity.Entities.Archetype*[] BNDLILEDJDG(ref Unity.Entities.EntityComponentStore HOBFDLCLKEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4B47A80", Offset = "0x4B46A80", VA = "0x184B47A80")]
		public static void AGIIMJNABGJ(IEPEPKBAJCN BICCGEMNLEI, out ByteString OBPMMCCMALJ, out NativeArray<EntityRemapUtility.EntityRemapInfo> LACJOLCCAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4B47CE0", Offset = "0x4B46CE0", VA = "0x184B47CE0")]
		internal static void CNBODFLDANB(IEPEPKBAJCN BICCGEMNLEI, KFBBBEBPJAC FBJDNBBGDNE, out NativeArray<EntityRemapUtility.EntityRemapInfo> LACJOLCCAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4B487E0", Offset = "0x4B477E0", VA = "0x184B487E0")]
		private unsafe static UnsafeHashMap<ulong, JJKLJFKGBLI> DGODGKIGJAJ(Unity.Entities.Archetype*[] LPHKLPIHEKG)
		{
			return default(UnsafeHashMap<ulong, JJKLJFKGBLI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4B48650", Offset = "0x4B47650", VA = "0x184B48650")]
		private static void DCCJLHHHNIE(KFBBBEBPJAC FBJDNBBGDNE, UnsafeHashMap<ulong, JJKLJFKGBLI> JKHPEIABHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4B4A370", Offset = "0x4B49370", VA = "0x184B4A370")]
		private unsafe static void LIGDMCPODAM(KFBBBEBPJAC FBJDNBBGDNE, Unity.Entities.Archetype*[] LPHKLPIHEKG, UnsafeHashMap<ulong, JJKLJFKGBLI> JKHPEIABHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4B485E0", Offset = "0x4B475E0", VA = "0x184B485E0")]
		private unsafe static int COMNJHOBBEP(Unity.Entities.Archetype*[] LPHKLPIHEKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4B495B0", Offset = "0x4B485B0", VA = "0x184B495B0")]
		private unsafe static void FACCNKHAMPN(KFBBBEBPJAC FBJDNBBGDNE, Unity.Entities.Archetype*[] LPHKLPIHEKG, global::LCJIKJFODKN<IMAELFMBFEM> NOJKDGAOHNK, NativeArray<EntityRemapUtility.EntityRemapInfo> LACJOLCCAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4B49390", Offset = "0x4B48390", VA = "0x184B49390")]
		private static NativeArray<int> EMBPHOJMCMO(KFBBBEBPJAC FBJDNBBGDNE)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4B4A900", Offset = "0x4B49900", VA = "0x184B4A900")]
		private static Memory<EntityArchetype> LOINALEKMNC(KFBBBEBPJAC FBJDNBBGDNE, NativeArray<int> AKGOADBOKFP, EntityManager EFLHIHFKEDM, out int IEPJEKGFCHN, out int IMACJGJEAPD)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4B4AE40", Offset = "0x4B49E40", VA = "0x184B4AE40")]
		private unsafe static void PFNFDFMHLGG(Unity.Entities.Chunk* JEOJAMJJLLO, ReadOnlySpan<byte> OBPMMCCMALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4B48A40", Offset = "0x4B47A40", VA = "0x184B48A40")]
		private static void DJFJKFBCABN(KFBBBEBPJAC FBJDNBBGDNE, NativeArray<int> AKGOADBOKFP, Span<EntityArchetype> LPHKLPIHEKG, EntityManager EFLHIHFKEDM, global::LCJIKJFODKN<IMAELFMBFEM> NOJKDGAOHNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4B4ACD0", Offset = "0x4B49CD0", VA = "0x184B4ACD0")]
		private unsafe static void NMMAIFGLONA(Unity.Entities.Chunk* BLGAELJLCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4B4A630", Offset = "0x4B49630", VA = "0x184B4A630")]
		private unsafe static void LLBFMINILKN(KFBBBEBPJAC.EDHHJIPJFKH.PMOBLNJDAOD CDCEBELCEIG, int GFOHIEMKIIC, int KCBMKPPFOGE, Unity.Entities.Chunk* JEOJAMJJLLO, KFBBBEBPJAC FBJDNBBGDNE, NativeArray<int> AKGOADBOKFP, global::LCJIKJFODKN<IMAELFMBFEM> NOJKDGAOHNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4B49EB0", Offset = "0x4B48EB0", VA = "0x184B49EB0")]
		public static void FLHGIEGBBCO(IEPEPKBAJCN BICCGEMNLEI, in ByteString OBPMMCCMALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4B499B0", Offset = "0x4B489B0", VA = "0x184B499B0")]
		public static void FLHGIEGBBCO(EntityManager EFLHIHFKEDM, global::LCJIKJFODKN<IMAELFMBFEM> NOJKDGAOHNK, in ByteString OBPMMCCMALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4B490F0", Offset = "0x4B480F0", VA = "0x184B490F0")]
		private static bool EEBAAFKAMAJ(Type GLKKDGLKBMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4B4A1C0", Offset = "0x4B491C0", VA = "0x184B4A1C0")]
		private static void JLPGNLDEAHK(TypeManager.TypeInfo CNPJDLDAEON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4B49F40", Offset = "0x4B48F40", VA = "0x184B49F40")]
		private unsafe static int IFLCCCBLIFN(Unity.Entities.Archetype*[] LPHKLPIHEKG, NativeArray<EntityRemapUtility.EntityRemapInfo> LACJOLCCAOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4B4A0E0", Offset = "0x4B490E0", VA = "0x184B4A0E0")]
		private static int JDEMNIGCMPB(int KICCJKJLKLA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4B4AC30", Offset = "0x4B49C30", VA = "0x184B4AC30")]
		private static ulong MNAHDGBCDMD(int KICCJKJLKLA)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class BFIINJIIMLF
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4B40D00", Offset = "0x4B3FD00", VA = "0x184B40D00")]
	private unsafe static Span<byte> PDBLNELPDMD(Unity.Entities.Chunk* BLGAELJLCIM, int GGHMAFNNMAA)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2151D60", Offset = "0x2150D60", VA = "0x182151D60")]
	public unsafe static Span<T> GHLBEMMHGGG<T>(Unity.Entities.Chunk* BLGAELJLCIM, int GGHMAFNNMAA)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2151F00", Offset = "0x2150F00", VA = "0x182151F00")]
	public static Span<T> GHLBEMMHGGG<T>(this ref Unity.Entities.Chunk BLGAELJLCIM, int GGHMAFNNMAA)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4B409F0", Offset = "0x4B3F9F0", VA = "0x184B409F0")]
	public unsafe static Span<Entity> HPMLGJPOKBA(Unity.Entities.Chunk* BLGAELJLCIM)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4B40A50", Offset = "0x4B3FA50", VA = "0x184B40A50")]
	public unsafe static void MCOHOPDDOPF(Unity.Entities.Chunk* BLGAELJLCIM, int GGHMAFNNMAA)
	{
	}
}
namespace RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[Preserve]
	internal class _RRAssemblyIndex : AICCCLPHIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4B4B330", Offset = "0x4B4A330", VA = "0x184B4B330", Slot = "4")]
		public sealed override void CIJCLICMJID()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EJDCELNBKPC
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static byte[] LJMFDKKPNGA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int EGAGCALIJCE;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static int AMPJBPFCKBN;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static BigInteger PJENGKNDPGI;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EJDCELNBKPC()
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
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
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

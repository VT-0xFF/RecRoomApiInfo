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
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class FMNBLEFMMOG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x544A670", Offset = "0x5449670", VA = "0x18544A670")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> EMBLFBKJDMN(this ref Unity.Entities.Archetype CEINJAHAPJN)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EBFAPONIKHK
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x544A250", Offset = "0x5449250", VA = "0x18544A250")]
	public static Span<int> BANJEEFHNEL(this EntityArchetype CEINJAHAPJN)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EJAKLIOPDID
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x544A2C0", Offset = "0x54492C0", VA = "0x18544A2C0")]
	public static bool PPICPACFBLI(this Entity GEEFHDFLBEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OCBAENFGEBO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x544C530", Offset = "0x544B530", VA = "0x18544C530")]
	public static void IAAMEIPGHNE(this EntityManager LKEHNCAJHHL, Entity GEEFHDFLBEH, AMFJBNENFOE IIHOIPENPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x544C920", Offset = "0x544B920", VA = "0x18544C920")]
	private static Span<ComponentType> PPBCLIHIDKJ(Span<int> NPAHGPDIAPJ, AMFJBNENFOE DNIBKDHCIAK, Span<ComponentType> EECGFMGLBHA)
	{
		return default(Span<ComponentType>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct DNGADCDNDIK<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MDDBMHANPKG : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public global::DNGADCDNDIK<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677040", VA = "0x180678040", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x301FF70", Offset = "0x301EF70", VA = "0x18301FF70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x21D1E20", Offset = "0x21D0E20", VA = "0x1821D1E20")]
		[DebuggerHidden]
		public MDDBMHANPKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x301FD90", Offset = "0x301ED90", VA = "0x18301FD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x301FF30", Offset = "0x301EF30", VA = "0x18301FF30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Action<Protobuf> AHEPBBCMBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MemoryStream KCFDLMABGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CodedInputStream BDHJPCDHNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Protobuf NMOGHPGOGOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int OIABCDOLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x656010", VA = "0x180657010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37661B0", Offset = "0x37651B0", VA = "0x1837661B0")]
	private DNGADCDNDIK(byte[] CLABEIKAHOI, Action<Protobuf> AHEPBBCMBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7C60", Offset = "0x2EA6C60", VA = "0x182EA7C60")]
	public static global::DNGADCDNDIK<Protobuf> DAKLFHBAJIH<Data>(ReadOnlySpan<byte> OFOCCMMPKKL, ReadOnlySpan<Data> JJDMEICMPFG, Action<Protobuf> AHEPBBCMBBJ)
	{
		return default(global::DNGADCDNDIK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3766020", Offset = "0x3765020", VA = "0x183766020", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3766060", Offset = "0x3765060", VA = "0x183766060", Slot = "4")]
	[IteratorStateMachine(typeof(global::DNGADCDNDIK<>.MDDBMHANPKG))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3766160", Offset = "0x3765160", VA = "0x183766160", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MFCMLPHKKPD<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly byte[] CLABEIKAHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly Protobuf NMOGHPGOGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MemoryStream KCFDLMABGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CodedOutputStream AGKGMDHFAGJ;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3022DC0", Offset = "0x3021DC0", VA = "0x183022DC0")]
	private MFCMLPHKKPD(byte[] CLABEIKAHOI, in Protobuf NMOGHPGOGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x29C3340", Offset = "0x29C2340", VA = "0x1829C3340")]
	public static global::MFCMLPHKKPD<Protobuf> DAKLFHBAJIH<T>(ReadOnlySpan<T> JJDMEICMPFG)
	{
		return default(global::MFCMLPHKKPD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3022D00", Offset = "0x3021D00", VA = "0x183022D00")]
	public void INENMPDAIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3022D30", Offset = "0x3021D30", VA = "0x183022D30")]
	public ByteString JHMKMPECGAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3022BD0", Offset = "0x3021BD0", VA = "0x183022BD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HIOPBAKIJAF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MemoryStream KCFDLMABGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CodedInputStream BDHJPCDHNKB;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x544A7C0", Offset = "0x54497C0", VA = "0x18544A7C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct EJFDGINJIFN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly byte[] CLABEIKAHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MemoryStream KCFDLMABGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CodedOutputStream AGKGMDHFAGJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x544A2E0", Offset = "0x54492E0", VA = "0x18544A2E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class MENLDHOCEOP : GNMMNAENLHM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Type LNOJDOEBIAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x676130", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xF6ABD0", Offset = "0xF69BD0", VA = "0x180F6ABD0")]
	public MENLDHOCEOP(Type KHOOFKPBCKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AGGLFMPJHMG : MENLDHOCEOP
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xF6ABD0", Offset = "0xF69BD0", VA = "0x180F6ABD0")]
	public AGGLFMPJHMG(Type KHOOFKPBCKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DNCBNAJFIBH : MENLDHOCEOP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Type GABHAMAFLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x676140", VA = "0x180677140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x544A200", Offset = "0x5449200", VA = "0x18544A200")]
	public DNCBNAJFIBH(Type MMOAOHAOFGC, Type KHOOFKPBCKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FLIEEAHPEDE : MENLDHOCEOP
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xF6ABD0", Offset = "0xF69BD0", VA = "0x180F6ABD0")]
	public FLIEEAHPEDE(Type KHOOFKPBCKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CIHFPOEPMJE : GNMMNAENLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public CIHFPOEPMJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AAFIHLNHDHN : GNMMNAENLHM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LBGCMANLNFC LFOHBBOJNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x657040", Offset = "0x656040", VA = "0x180657040")]
		[CompilerGenerated]
		get
		{
			return default(LBGCMANLNFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xF6ABA0", Offset = "0xF69BA0", VA = "0x180F6ABA0")]
	public AAFIHLNHDHN(LBGCMANLNFC IDKBHBKJHPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
public class DFDDJEKPLDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly PGLNEDJDCBK HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PGLNEDJDCBK NFGMALDPBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5449990", Offset = "0x5448990", VA = "0x185449990")]
	public DFDDJEKPLDJ(PGLNEDJDCBK HADAJAKADAH, EntityManager LKEHNCAJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2675820", Offset = "0x2674820", VA = "0x182675820")]
	public bool CNAKOGFIEPL<T>(Entity GEEFHDFLBEH) where T : struct, ENNIBMEKCDB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2677470", Offset = "0x2676470", VA = "0x182677470")]
	public bool OLGILBFEMLA<T>(Entity GEEFHDFLBEH, out T IGJPNMBCJPK) where T : struct, ENNIBMEKCDB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2675EE0", Offset = "0x2674EE0", VA = "0x182675EE0")]
	public T MCGLEKIFHMI<T>(Entity GEEFHDFLBEH) where T : struct, ENNIBMEKCDB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2675860", Offset = "0x2674860", VA = "0x182675860")]
	private ComponentType EOCKLHFNBEI<T>() where T : struct, ENNIBMEKCDB
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x54498C0", Offset = "0x54488C0", VA = "0x1854498C0")]
	private ComponentType EOCKLHFNBEI(Type NKICFHCCMMH)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class BOLFBGCGJHF
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	protected BOLFBGCGJHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class GAFLHNJJCHE<View, Data> : NOBHGMEMAKH where View : struct, ENNIBMEKCDB where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static ComponentType LCHGJBBDMJH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override Type PKDHCIAOFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3D5ED60", Offset = "0x3D5DD60", VA = "0x183D5ED60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override Type ICPOAFKOLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F620", Offset = "0x3D5E620", VA = "0x183D5F620", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override int PHKOIPHKEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x24D4820", Offset = "0x24D3820", VA = "0x1824D4820", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x24D4B90", Offset = "0x24D3B90", VA = "0x1824D4B90")]
	public Data IPAHFFMFJNJ(Entity GEEFHDFLBEH)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x24D4C00", Offset = "0x24D3C00", VA = "0x1824D4C00")]
	public Data JOODHILOOCK(Entity GEEFHDFLBEH)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected internal abstract View FEFGPJKGKAG(Entity GEEFHDFLBEH);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA100", Offset = "0x2EA9100", VA = "0x182EAA100", Slot = "15")]
	protected internal override T FEFGPJKGKAG<T>(Entity GEEFHDFLBEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x24D4A00", Offset = "0x24D3A00", VA = "0x1824D4A00", Slot = "16")]
	public override bool CNAKOGFIEPL(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1C9E990", Offset = "0x1C9D990", VA = "0x181C9E990")]
	protected GAFLHNJJCHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class NOBHGMEMAKH : COLPHKAFOHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private ArchetypeChunkComponentTypeDynamic LJOHBPADMOC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x833520", Offset = "0x832520", VA = "0x180833520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public abstract Type PKDHCIAOFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public abstract Type ICPOAFKOLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public abstract int PHKOIPHKEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private Type EJHMOEIJDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x790390", Offset = "0x78F390", VA = "0x180790390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int EMMJFGOBFKF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x544C450", Offset = "0x544B450", VA = "0x18544C450", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EGNDHFFDDFH[] GCBPPJHPFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7902C0", Offset = "0x78F2C0", VA = "0x1807902C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	protected internal virtual EGNDHFFDDFH[] LBNDLOLGMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x544C390", Offset = "0x544B390", VA = "0x18544C390", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool LGNHFHLEBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x544C360", Offset = "0x544B360", VA = "0x18544C360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x544C240", Offset = "0x544B240", VA = "0x18544C240")]
	public void ILMEFAAGLOH(EntityManager LKEHNCAJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x737040", Offset = "0x736040", VA = "0x180737040")]
	protected COLPHKAFOHI DEHDAHIHBCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T FEFGPJKGKAG<T>(Entity GEEFHDFLBEH) where T : struct, ENNIBMEKCDB;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract bool CNAKOGFIEPL(Entity GEEFHDFLBEH);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x544C0F0", Offset = "0x544B0F0", VA = "0x18544C0F0", Slot = "8")]
	public (uint, uint) EAHJHDPFEFN(Entity GEEFHDFLBEH)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x544C1B0", Offset = "0x544B1B0", VA = "0x18544C1B0", Slot = "9")]
	public bool HDCJELIGLFP(Entity GEEFHDFLBEH, (uint order, uint change) JKGBPKEJAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	protected NOBHGMEMAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class FOCPDKGLOOJ<Data> : PGOOPFJKLFO where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public virtual Data FOBBLKPOGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x284CE20", Offset = "0x284BE20", VA = "0x18284CE20", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x238DA50", Offset = "0x238CA50", VA = "0x18238DA50", Slot = "8")]
	protected virtual bool IPBMAHBFOKM(ReadOnlySpan<Data> JJDMEICMPFG, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659D00", VA = "0x18065AD00", Slot = "9")]
	protected virtual bool FPMCHDMPDKB(int JKGBPKEJAFA, Span<Data> JJDMEICMPFG, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x284CD60", Offset = "0x284BD60", VA = "0x18284CD60", Slot = "5")]
	internal sealed override bool IPBMAHBFOKM(ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x284B7D0", Offset = "0x284A7D0", VA = "0x18284B7D0", Slot = "6")]
	internal sealed override bool FPMCHDMPDKB(int JKGBPKEJAFA, ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA9D50", Offset = "0x2EA8D50", VA = "0x182EA9D50")]
	protected global::MFCMLPHKKPD<Protobuf> KGANMPHGLDN<Protobuf>(ReadOnlySpan<Data> JJDMEICMPFG) where Protobuf : IMessage, new()
	{
		return default(global::MFCMLPHKKPD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2EA9CC0", Offset = "0x2EA8CC0", VA = "0x182EA9CC0")]
	protected global::DNGADCDNDIK<Protobuf> KELBNDMOAKA<Protobuf>(ReadOnlySpan<byte> OFOCCMMPKKL, ReadOnlySpan<Data> JJDMEICMPFG, Action<Protobuf> AHEPBBCMBBJ) where Protobuf : IMessage, new()
	{
		return default(global::DNGADCDNDIK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1C9E990", Offset = "0x1C9D990", VA = "0x181C9E990")]
	protected FOCPDKGLOOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class PGOOPFJKLFO
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	protected internal abstract int FOEMNAHJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x544DBB0", Offset = "0x544CBB0", VA = "0x18544DBB0", Slot = "5")]
	internal virtual bool IPBMAHBFOKM(ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659D00", VA = "0x18065AD00", Slot = "6")]
	internal virtual bool FPMCHDMPDKB(int JKGBPKEJAFA, ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	protected PGOOPFJKLFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OBDMLNDADDA
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PFGAJLNHCIL
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBIDEKKHHGJ(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BEFOMENCFGG
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27AE780", Offset = "0x27AD780", VA = "0x1827AE780")]
	public static void DPEIADHEJGM<T>(this ref T LPGHNKKMKEB, ref ArchetypeChunkIterator FPFJEOIHGBB) where T : struct, PFGAJLNHCIL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27AE570", Offset = "0x27AD570", VA = "0x1827AE570")]
	public static void DPEIADHEJGM<T>(this ref T LPGHNKKMKEB, EntityQuery KKNMFCOPDMJ) where T : struct, PFGAJLNHCIL
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class IHCEEJFPFHE
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x544AAF0", Offset = "0x5449AF0", VA = "0x18544AAF0")]
	public static bool PPCAKDCCEDB(Type NKICFHCCMMH, Type GMELJICDHJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class ACMAOLIIJBA<Attribute, BaseClass> : global::OJMNPGPFHPH<BaseClass>, LBLNCNBBMIL where Attribute : MENLDHOCEOP
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly string BEMAPDNKPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<int, Type> JGLACLKIGLL;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x258AB20", Offset = "0x2589B20", VA = "0x18258AB20")]
	public ACMAOLIIJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x258A7F0", Offset = "0x25897F0", VA = "0x18258A7F0", Slot = "4")]
	public bool FKLGFCOHCLF(int DBMJEOKPFJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x258A540", Offset = "0x2589540", VA = "0x18258A540", Slot = "5")]
	public global::IGNGPODGPHC<BaseClass> BKEBLIAGHNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x258A9C0", Offset = "0x25899C0", VA = "0x18258A9C0", Slot = "7")]
	protected virtual bool PPCAKDCCEDB(Type NKICFHCCMMH, int KHFLDKPJMNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x258A890", Offset = "0x2589890", VA = "0x18258A890", Slot = "8")]
	protected virtual int HHIADBMEOHD(Type NKICFHCCMMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x258A850", Offset = "0x2589850", VA = "0x18258A850")]
	public void GEKIOEINPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x258A920", Offset = "0x2589920", VA = "0x18258A920", Slot = "6")]
	public void PJHBAIJLMNC(Type NKICFHCCMMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IGNGPODGPHC<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<int, BaseClass> IPNBNIFLFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<Type, BaseClass> JKAMIACJMAF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IEnumerable<BaseClass> CKCFIFNMDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x198EDE0", Offset = "0x198DDE0", VA = "0x18198EDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x198F0F0", Offset = "0x198E0F0", VA = "0x18198F0F0")]
	public IGNGPODGPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x198F280", Offset = "0x198E280", VA = "0x18198F280")]
	public IGNGPODGPHC(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x198F010", Offset = "0x198E010", VA = "0x18198F010")]
	internal void HEFJCCLOLGO(int DBMJEOKPFJK, BaseClass ECAHBHLDJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29BBF70", Offset = "0x29BAF70", VA = "0x1829BBF70")]
	public bool DKBMNIOKKIE<T>(out BaseClass IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x198ED40", Offset = "0x198DD40", VA = "0x18198ED40")]
	public bool DKBMNIOKKIE(Type MOBCJNJMMEJ, out BaseClass IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x198F090", Offset = "0x198E090", VA = "0x18198F090")]
	public bool IJCMBMJHEBD(int DBMJEOKPFJK, out BaseClass IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x29BCA70", Offset = "0x29BBA70", VA = "0x1829BCA70")]
	public T LJJPNAJBGDL<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x198F0C0", Offset = "0x198E0C0", VA = "0x18198F0C0")]
	public BaseClass LJJPNAJBGDL(Type MJEKEAHAIMA)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class ENOKCHMKPBH : global::ACMAOLIIJBA<AGGLFMPJHMG, BOLFBGCGJHF>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x544A410", Offset = "0x5449410", VA = "0x18544A410")]
	public ENOKCHMKPBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class MALPCKCKHAH : global::ACMAOLIIJBA<DNCBNAJFIBH, NOBHGMEMAKH>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x544C080", Offset = "0x544B080", VA = "0x18544C080")]
	public MALPCKCKHAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class ONCMEHHEOFA : global::ACMAOLIIJBA<FLIEEAHPEDE, PGOOPFJKLFO>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x544CB30", Offset = "0x544BB30", VA = "0x18544CB30")]
	public ONCMEHHEOFA()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[IFBLAMOEMKH(CMGBDLINHMB.ComponentSystemTypes)]
	internal struct ComponentSystemTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly List<Type> DCPGKOEBMPG;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x887620", Offset = "0x886620", VA = "0x180887620")]
		private ComponentSystemTypes(List<Type> DCPGKOEBMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5449760", Offset = "0x5448760", VA = "0x185449760")]
		public static void GEKIOEINPME(List<Type> DCPGKOEBMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x54494F0", Offset = "0x54484F0", VA = "0x1854494F0")]
		private void BMKKEJLIDNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x54497F0", Offset = "0x54487F0", VA = "0x1854497F0")]
		private bool PPCAKDCCEDB(Type NKICFHCCMMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5449700", Offset = "0x5448700", VA = "0x185449700")]
		private void ELOKPINLNDC(Type NKICFHCCMMH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface OJMNPGPFHPH<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FKLGFCOHCLF(int DBMJEOKPFJK);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::IGNGPODGPHC<BaseClass> BKEBLIAGHNE();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class IKEIJDHBAML : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0")]
	protected IKEIJDHBAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class DBEHBMCDNIE : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0")]
	protected DBEHBMCDNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class IKMBABCDPGL : IKEIJDHBAML
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x544AD80", Offset = "0x5449D80", VA = "0x18544AD80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	protected void BIAEOJAMGMN(string IALJJELLBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0")]
	protected IKMBABCDPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[IFBLAMOEMKH(CMGBDLINHMB.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x544EBA0", Offset = "0x544DBA0", VA = "0x18544EBA0")]
		public static ComponentSystemGroup[] JKOOGAFMBEC(World HADAJAKADAH, DEJCLABDFEB NJKJJANIDJB = DEJCLABDFEB.Default, bool BDGLGIDHPMA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x544DFB0", Offset = "0x544CFB0", VA = "0x18544DFB0")]
		private static Type[] GLNCEMNEBIA(DEJCLABDFEB NJKJJANIDJB, bool BDGLGIDHPMA, ComponentSystemGroup[] COLHOIJDBIK, ComponentSystemGroup GJAMECFFOKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x544E310", Offset = "0x544D310", VA = "0x18544E310")]
		private static ComponentSystemGroup[] ICBABKLHMDF(World HADAJAKADAH, out ComponentSystemGroup GJAMECFFOKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x544DBD0", Offset = "0x544CBD0", VA = "0x18544DBD0")]
		internal static bool CHKBPHPAAHM(LBGCMANLNFC IDKBHBKJHPJ, out EEDDFLCIHPA FBKAMCPDHHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x544EC70", Offset = "0x544DC70", VA = "0x18544EC70")]
		private static ComponentSystemGroup NCBIPKIPOGE(Type NKICFHCCMMH, World HADAJAKADAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x544DE20", Offset = "0x544CE20", VA = "0x18544DE20")]
		private static ComponentSystemGroup[] CLCKBGPHHJG(Type[] DCPGKOEBMPG, World HADAJAKADAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x544E680", Offset = "0x544D680", VA = "0x18544E680")]
		internal static void JKLEJAGIFDB(World HADAJAKADAH, Type[] COMOOCFPNPF, ComponentSystemGroup[] COLHOIJDBIK, ComponentSystemGroup GJAMECFFOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x544DF50", Offset = "0x544CF50", VA = "0x18544DF50")]
		internal static bool FBIDAMKCIOD(ComponentSystemBase CHJMLFMLCJF, ComponentSystemGroup[] COLHOIJDBIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x544E620", Offset = "0x544D620", VA = "0x18544E620")]
		private static void ILEDKCEDLLE(ComponentSystemGroup[] COLHOIJDBIK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct FPGIJHEELFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly Dictionary<Type, List<Type>> PHKFDNECCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly HashSet<Type> JLJNFPKFKNI;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x707A10", Offset = "0x706A10", VA = "0x180707A10")]
	public FPGIJHEELFO(Dictionary<Type, List<Type>> PHKFDNECCIL, HashSet<Type> JLJNFPKFKNI)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[IFBLAMOEMKH(CMGBDLINHMB.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class JAJLBOBBACH : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private Type <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private IEnumerable<Type> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public IEnumerable<Type> <>3__types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public RRFilterWorldSystems <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public RRFilterWorldSystems <>3__<>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private IEnumerator<Type> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Type IEnumerator<Type>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8E3E90", Offset = "0x8E2E90", VA = "0x1808E3E90")]
			[DebuggerHidden]
			public JAJLBOBBACH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x544BA60", Offset = "0x544AA60", VA = "0x18544BA60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x544B7C0", Offset = "0x544A7C0", VA = "0x18544B7C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x544BAF0", Offset = "0x544AAF0", VA = "0x18544BAF0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x544BA20", Offset = "0x544AA20", VA = "0x18544BA20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x544B970", Offset = "0x544A970", VA = "0x18544B970", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x544B970", Offset = "0x544A970", VA = "0x18544B970", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct LNIJCBDOOPF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Type HAPCBFEJJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private DEJCLABDFEB NJKJJANIDJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool AFFLCINLLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool ODGLGGAIIDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool BDGLGIDHPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private IEnumerable<Type> CBHFNELFLHD;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x544EDE0", Offset = "0x544DDE0", VA = "0x18544EDE0")]
		public static RRFilterWorldSystems DAKLFHBAJIH()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x544F480", Offset = "0x544E480", VA = "0x18544F480")]
		public RRFilterWorldSystems MPFIIJJAEOH(DEJCLABDFEB IDKBHBKJHPJ)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x544FCA0", Offset = "0x544ECA0", VA = "0x18544FCA0")]
		public RRFilterWorldSystems PGNFBJILHHE(IEnumerable<Type> DCPGKOEBMPG)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x544F3E0", Offset = "0x544E3E0", VA = "0x18544F3E0")]
		public RRFilterWorldSystems HDPNOHNEAFE(bool KEKJBICJBBE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x544FC90", Offset = "0x544EC90", VA = "0x18544FC90")]
		public RRFilterWorldSystems PANEBOGAIKK(bool MPCKDGOMPJA)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x544F3F0", Offset = "0x544E3F0", VA = "0x18544F3F0")]
		public FPGIJHEELFO JOJNJGOGONO(Type[] JLKLLDHFKFP)
		{
			return default(FPGIJHEELFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x544EF10", Offset = "0x544DF10", VA = "0x18544EF10")]
		[IteratorStateMachine(typeof(JAJLBOBBACH))]
		internal IEnumerable<Type> GBBEGHJLHHG(IEnumerable<Type> DCPGKOEBMPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x544EFA0", Offset = "0x544DFA0", VA = "0x18544EFA0")]
		internal Dictionary<Type, List<Type>> GFOKINOLNBI(IEnumerable<Type> DCPGKOEBMPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x544EE00", Offset = "0x544DE00", VA = "0x18544EE00")]
		private void FPIDEEHHIHB(Dictionary<Type, List<Type>> FALFIAAPAEL, Type NKICFHCCMMH, Type GOMNPNDGEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x544F490", Offset = "0x544E490", VA = "0x18544F490")]
		internal HashSet<Type> NOECJAPBKCA(IEnumerable<Type> COLHOIJDBIK, Dictionary<Type, List<Type>> AHGHAANFJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x544F650", Offset = "0x544E650", VA = "0x18544F650")]
		internal bool OHBKEALJJOM(Type NKICFHCCMMH, DEJCLABDFEB NJKJJANIDJB, bool BDGLGIDHPMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x544F280", Offset = "0x544E280", VA = "0x18544F280")]
		[CompilerGenerated]
		internal static void HBEAIPCIGJP(Type NKICFHCCMMH, ref LNIJCBDOOPF P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal static class HJMHMAKNHOO
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static bool MMCBPLCLJDF;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x544A9A0", Offset = "0x54499A0", VA = "0x18544A9A0")]
	public static void ILMEFAAGLOH(bool EFJKFNKFDIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x544A800", Offset = "0x5449800", VA = "0x18544A800")]
	private static void BOAPCJAEODE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class HOAKFABAAIA
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x544AA00", Offset = "0x5449A00", VA = "0x18544AA00")]
	public static ulong CGODPODANGB(Type NKICFHCCMMH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x544AA30", Offset = "0x5449A30", VA = "0x18544AA30")]
	public static ulong CGODPODANGB(string MHCADHHJAGG)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[IFBLAMOEMKH(CMGBDLINHMB.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private struct JPHAOPHJJBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public readonly ulong BLKGCDKLGNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public readonly ulong GHKBFILNEHA;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xF68720", Offset = "0xF67720", VA = "0x180F68720")]
			public JPHAOPHJJBE(ulong GPFJKHOIPCG, ulong LDMONCGFPAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x544BB40", Offset = "0x544AB40", VA = "0x18544BB40", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static Dictionary<ulong, int> GBIGJDAAIEN;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static JPHAOPHJJBE[] NJGAGJBNFKC;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static bool MMCBPLCLJDF;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5450960", Offset = "0x544F960", VA = "0x185450960")]
		public static ulong MNPHMHLFPFD(int DBMJEOKPFJK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5450220", Offset = "0x544F220", VA = "0x185450220")]
		public static int HBJLAMNGILN(ulong LDMONCGFPAM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5450360", Offset = "0x544F360", VA = "0x185450360")]
		public static void ILMEFAAGLOH(bool EFJKFNKFDIO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5450140", Offset = "0x544F140", VA = "0x185450140")]
		private static void GECEPBCLENC(int EGDEEAOPNJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x544FE20", Offset = "0x544EE20", VA = "0x18544FE20")]
		private static void GCGKDNGLDEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x54509C0", Offset = "0x544F9C0", VA = "0x1854509C0")]
		private static JPHAOPHJJBE PJNFCOBGPGN(Type NKICFHCCMMH)
		{
			return default(JPHAOPHJJBE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x544FDB0", Offset = "0x544EDB0", VA = "0x18544FDB0")]
		private static ulong AHKAMANCPAC(Type NKICFHCCMMH, ulong LDMONCGFPAM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5450740", Offset = "0x544F740", VA = "0x185450740")]
		private static void MKAKMMLABMN(in JPHAOPHJJBE ALGPHJLPHJO, TypeManager.TypeInfo MPEMJAALAAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5450550", Offset = "0x544F550", VA = "0x185450550")]
		private static void JEBGGIKNDLD(JPHAOPHJJBE MPEMJAALAAL, int DBMJEOKPFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5450660", Offset = "0x544F660", VA = "0x185450660")]
		private static void LDOLFKFGFFP(JPHAOPHJJBE MPEMJAALAAL, int DBMJEOKPFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x54502D0", Offset = "0x544F2D0", VA = "0x1854502D0")]
		private static JPHAOPHJJBE ILCLBADMEBN(int DBMJEOKPFJK)
		{
			return default(JPHAOPHJJBE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5450650", Offset = "0x544F650", VA = "0x185450650")]
		private static int JGDEPLCICHN(int DBMJEOKPFJK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class INMDEMPDONP
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly MALPCKCKHAH AFFDBGIBBOG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly ONCMEHHEOFA GNNEHJCPCBJ;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly ENOKCHMKPBH OMFMNNFGBEM;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly List<Type> JCDLHNFEECM;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static bool MMCBPLCLJDF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	internal static global::OJMNPGPFHPH<NOBHGMEMAKH> GGIKGBBCIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x544B3A0", Offset = "0x544A3A0", VA = "0x18544B3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal static global::OJMNPGPFHPH<PGOOPFJKLFO> BGFKNONEECL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x544B2E0", Offset = "0x544A2E0", VA = "0x18544B2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal static global::OJMNPGPFHPH<BOLFBGCGJHF> DIBCAMGFHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x544B340", Offset = "0x544A340", VA = "0x18544B340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x544AE30", Offset = "0x5449E30", VA = "0x18544AE30")]
	public static void ILMEFAAGLOH(bool EFJKFNKFDIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x544ADB0", Offset = "0x5449DB0", VA = "0x18544ADB0")]
	public static Type[] HFPJIAIMIHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class AJIIPINBOCH
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly Dictionary<int, int> NNHCPCEAHNE;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static bool MMCBPLCLJDF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5449010", Offset = "0x5448010", VA = "0x185449010")]
	public static int EAHJHDPFEFN(int DBMJEOKPFJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5449130", Offset = "0x5448130", VA = "0x185449130")]
	public static void ILMEFAAGLOH(bool EFJKFNKFDIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x54491D0", Offset = "0x54481D0", VA = "0x1854491D0")]
	private static void IOICFPBJEPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5449420", Offset = "0x5448420", VA = "0x185449420")]
	private static int KCCJOMEGCHO(Type NKICFHCCMMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x54490B0", Offset = "0x54480B0", VA = "0x1854490B0")]
	private static void IIOELKEIHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class PGLNEDJDCBK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly World HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly World IBLOHKEKNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly DFDDJEKPLDJ ECAHBHLDJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly ComponentSystemGroup[] COLHOIJDBIK;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public World NFGMALDPBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public World EKGNNGCIOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0E0", Offset = "0x8DB0E0", VA = "0x1808DC0E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DFDDJEKPLDJ KAAPDHONNOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public global::IGNGPODGPHC<NOBHGMEMAKH> GGIKGBBCIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EEAE0", VA = "0x1806EFAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public global::IGNGPODGPHC<PGOOPFJKLFO> BGFKNONEECL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D570", VA = "0x18065E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x65E590", Offset = "0x65D590", VA = "0x18065E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public global::IGNGPODGPHC<BOLFBGCGJHF> DIBCAMGFHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x65E580", Offset = "0x65D580", VA = "0x18065E580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x65E5A0", Offset = "0x65D5A0", VA = "0x18065E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> ELOFBPOOINO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8DC120", Offset = "0x8DB120", VA = "0x1808DC120")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x544D330", Offset = "0x544C330", VA = "0x18544D330")]
	public static PGLNEDJDCBK GACAKOPDIMA(string BEMAPDNKPAD, LBGCMANLNFC IDKBHBKJHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x544D690", Offset = "0x544C690", VA = "0x18544D690")]
	public PGLNEDJDCBK(string BEMAPDNKPAD, LBGCMANLNFC IDKBHBKJHPJ = LBGCMANLNFC.Simulation, DEJCLABDFEB NJKJJANIDJB = DEJCLABDFEB.Default, bool EFJKFNKFDIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x544D3B0", Offset = "0x544C3B0", VA = "0x18544D3B0")]
	public ComponentSystemBase GHLFOJENCOJ(Type NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3275E80", Offset = "0x3274E80", VA = "0x183275E80")]
	public T GHLFOJENCOJ<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x544CE70", Offset = "0x544BE70", VA = "0x18544CE70")]
	public void DPHPIFPPBBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x544D4C0", Offset = "0x544C4C0", VA = "0x18544D4C0")]
	public void HMDEEKCAALF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x544D3D0", Offset = "0x544C3D0", VA = "0x18544D3D0")]
	public void HJAKNCCJKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x544CFA0", Offset = "0x544BFA0", VA = "0x18544CFA0")]
	public void FDNMIFDFHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x544CF40", Offset = "0x544BF40", VA = "0x18544CF40")]
	public void ELBOOCHDDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x544D630", Offset = "0x544C630", VA = "0x18544D630")]
	public void NIINGCCOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x544D430", Offset = "0x544C430", VA = "0x18544D430")]
	public void HLMHFKCAAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x544D000", Offset = "0x544C000", VA = "0x18544D000")]
	public void FGBEMENNDNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x544CE10", Offset = "0x544BE10", VA = "0x18544CE10")]
	public void DLGKFBBKHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x544CD30", Offset = "0x544BD30", VA = "0x18544CD30")]
	internal void DKIMDJBDIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x544CCB0", Offset = "0x544BCB0", VA = "0x18544CCB0")]
	private bool CGLLPKJLEJA(ComponentSystemGroup DEIPGHEFMEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x544D060", Offset = "0x544C060", VA = "0x18544D060")]
	private void FPJEBEBNEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x544D520", Offset = "0x544C520", VA = "0x18544D520")]
	private ComponentSystemGroup[] JKOOGAFMBEC(DEJCLABDFEB NJKJJANIDJB, bool BDGLGIDHPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x544CED0", Offset = "0x544BED0", VA = "0x18544CED0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Flags]
public enum LBGCMANLNFC
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Game = 5,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[AttributeUsage(AttributeTargets.Class)]
public sealed class NEOACNLALLA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public DEJCLABDFEB PGEKGIGBKKK;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Flags]
public enum DEJCLABDFEB
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	GameObjectConversion = 0x30,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	EntitySceneOptimizations = 4,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	ProcessAfterLoad = 8,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	HybridGameObjectConversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	DotsRuntimeGameObjectConversion = 0x20
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface EEDDFLCIHPA
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	Type PHILEHBIAIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class JIGELGFIMAD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public virtual bool PFADBMCBDGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x678020", Offset = "0x677020", VA = "0x180678020", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	protected JIGELGFIMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[DisableAutoCreation]
public sealed class BINCJPPOHMK : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public BINCJPPOHMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DisableAutoCreation]
public sealed class NGBOFDOMIKJ : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public NGBOFDOMIKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DisableAutoCreation]
public sealed class ILHIKHAIJNM : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public ILHIKHAIJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DisableAutoCreation]
public sealed class KAHDFHOCEMC : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public KAHDFHOCEMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DisableAutoCreation]
public sealed class FNPHKNFELIE : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public FNPHKNFELIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DisableAutoCreation]
public sealed class ANCFDIJGMDO : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public ANCFDIJGMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DisableAutoCreation]
public sealed class KIABADAKEGB : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public KIABADAKEGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DisableAutoCreation]
public sealed class HEEHHHHFPDD : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public HEEHHHHFPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DisableAutoCreation]
public sealed class MKELNEOKOJK : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public MKELNEOKOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DisableAutoCreation]
public sealed class LKLKPHFEOKG : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public override bool PFADBMCBDGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659D00", VA = "0x18065AD00", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public LKLKPHFEOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[AttributeUsage(AttributeTargets.Class)]
public class NAOJPPNIGOE : GNMMNAENLHM
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public NAOJPPNIGOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class ADAIGOIIEOK
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void HPCFBKIFDLB<From, To>(From ICAAAENIBKC, ref To PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class HCCMGJPLKMA<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static HPCFBKIFDLB<From, To> JMGBKPCMOFH;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public HCCMGJPLKMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5448E30", Offset = "0x5447E30", VA = "0x185448E30")]
	static ADAIGOIIEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x21EF860", Offset = "0x21EE860", VA = "0x1821EF860")]
	public static void HOOBINPCHAM<T>(HPCFBKIFDLB<T, T> NHKDGEMAIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x21EF6B0", Offset = "0x21EE6B0", VA = "0x1821EF6B0")]
	public static void HOOBINPCHAM<From, To>(HPCFBKIFDLB<From, To> NHKDGEMAIFP, HPCFBKIFDLB<To, From> EBGNBGLEENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x21EF660", Offset = "0x21EE660", VA = "0x1821EF660")]
	public static void HOOBINPCHAM<From, To>(HPCFBKIFDLB<From, To> JMGBKPCMOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x21F6BD0", Offset = "0x21F5BD0", VA = "0x1821F6BD0")]
	public static HPCFBKIFDLB<From, To> MFFAHOPKPEH<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x21F2200", Offset = "0x21F1200", VA = "0x1821F2200")]
	public static void KLHMDOLPFPN<From, To>(From ICAAAENIBKC, ref To PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class KLBODNIPMJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> AELKIPHCLHB;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xD8B490", Offset = "0xD8A490", VA = "0x180D8B490")]
	public KLBODNIPMJE(NativeArray<EntityRemapUtility.EntityRemapInfo> AELKIPHCLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2E03690", Offset = "0x2E02690", VA = "0x182E03690")]
	public Entity NBLFNGOCDEM(Entity IKPEGPHMIII)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal static class FIHEIALDBOD
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Dictionary<(ulong hash, uint version), string> NJEANHANCMM;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x544A480", Offset = "0x5449480", VA = "0x18544A480")]
	public static bool ACGKGPAJKNE(ulong PKCNHEGJGNH, uint JKGBPKEJAFA, out string BEMAPDNKPAD)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[IFBLAMOEMKH(CMGBDLINHMB.Serialization, new string[] { "Timing", "Deprecated", "Types", "Archetypes" })]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private struct OJBCBOJHFKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int KIJOKCLKDIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int FOEMNAHJKFC;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x678050", Offset = "0x677050", VA = "0x180678050")]
			public OJBCBOJHFKO(int AIPHGHFENPJ, int JKGBPKEJAFA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct JAFGHMFCICB
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private static Stopwatch DCONEIAFJGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private long AGIHFJLDMFB;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public long FPEHLJJEBOM
			{
				[Cpp2IlInjected.Token(Token = "0x6000122")]
				[Cpp2IlInjected.Address(RVA = "0x544B630", Offset = "0x544A630", VA = "0x18544B630")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public long NEMNDPNMPOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x544B750", Offset = "0x544A750", VA = "0x18544B750")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x544B690", Offset = "0x544A690", VA = "0x18544B690")]
			public static JAFGHMFCICB JPAMEHCOEPI()
			{
				return default(JAFGHMFCICB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private struct DKCPJJLPNKB : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			public readonly struct IIGALELMLLI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				public unsafe readonly Unity.Entities.Archetype* NPABAFANPLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public readonly NLPFCDLIDGG.BPMCLEPAMGO.CHIFPGAOFMF HJPOJJGNAHE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public readonly KLBODNIPMJE NGGOKHONBCG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public readonly global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000079")]
				public readonly int CGIBPFOKKNL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public readonly int EFPAICPDPKD;

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x544AD20", Offset = "0x5449D20", VA = "0x18544AD20")]
				public unsafe IIGALELMLLI(Unity.Entities.Archetype* NPABAFANPLJ, NLPFCDLIDGG.BPMCLEPAMGO.CHIFPGAOFMF HJPOJJGNAHE, KLBODNIPMJE NGGOKHONBCG, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ, int CGIBPFOKKNL, int EFPAICPDPKD = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x544ACD0", Offset = "0x5449CD0", VA = "0x18544ACD0")]
				public IIGALELMLLI(in IIGALELMLLI JANIFNADDOP, int EFPAICPDPKD)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public readonly IIGALELMLLI[] JJDMEICMPFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public string[] MIHPCMIHFLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public int MEGPGBHCOJL;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x544A0C0", Offset = "0x54490C0", VA = "0x18544A0C0")]
			public DKCPJJLPNKB(IIGALELMLLI[] JJDMEICMPFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5449D90", Offset = "0x5448D90", VA = "0x185449D90", Slot = "4")]
			public void Invoke(int AIPHGHFENPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x54499E0", Offset = "0x54489E0", VA = "0x1854499E0")]
			private void COCDBPIPMNJ(in IIGALELMLLI JANIFNADDOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x5449DF0", Offset = "0x5448DF0", VA = "0x185449DF0")]
			private static void LIJHDDAODCF(in IIGALELMLLI JANIFNADDOP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class NOFKMEDEIEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public NLPFCDLIDGG asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public global::IGNGPODGPHC<PGOOPFJKLFO> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public NOFKMEDEIEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x544C4C0", Offset = "0x544B4C0", VA = "0x18544C4C0")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class CGKKIAICJGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public NLPFCDLIDGG.BPMCLEPAMGO.CHIFPGAOFMF srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public NOFKMEDEIEC CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public CGKKIAICJGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class PEBAEMMCPJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public CGKKIAICJGJ CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public PEBAEMMCPJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x544CBA0", Offset = "0x544BBA0", VA = "0x18544CBA0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static CGJHBFGPOOL IMLOALHAGJF;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static CGJHBFGPOOL KMDCBJCGGPO;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static CGJHBFGPOOL INLCJMCIIOG;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static CGJHBFGPOOL LIEMCHPOHAJ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static bool EEHBAHPIICC;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static NLPFCDLIDGG.BPMCLEPAMGO.IHNPCMIICLD IPNNONIDLMC;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x54543D0", Offset = "0x54533D0", VA = "0x1854543D0")]
		private unsafe static bool OGDFFIDIIFL(Unity.Entities.Archetype* CEINJAHAPJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5452380", Offset = "0x5451380", VA = "0x185452380")]
		internal unsafe static Unity.Entities.Archetype*[] FJIDPBEJPPE(ref Unity.Entities.EntityComponentStore APHBGABGANA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5451270", Offset = "0x5450270", VA = "0x185451270")]
		public static void CCMIFLHPNMM(PGLNEDJDCBK HADAJAKADAH, out ByteString OFOCCMMPKKL, out NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5451C50", Offset = "0x5450C50", VA = "0x185451C50")]
		internal static void FHPNCIJKCAP(PGLNEDJDCBK HADAJAKADAH, NLPFCDLIDGG GEJKEHJBJMH, out NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5453D70", Offset = "0x5452D70", VA = "0x185453D70")]
		private unsafe static UnsafeHashMap<ulong, OJBCBOJHFKO> LMLNIKEJBFM(Unity.Entities.Archetype*[] DBFCJKHGCAE)
		{
			return default(UnsafeHashMap<ulong, OJBCBOJHFKO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x54519C0", Offset = "0x54509C0", VA = "0x1854519C0")]
		private static void DFFBCHHKNDD(NLPFCDLIDGG GEJKEHJBJMH, UnsafeHashMap<ulong, OJBCBOJHFKO> LKGJBJECNAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5453100", Offset = "0x5452100", VA = "0x185453100")]
		private unsafe static void JOKDFPBAOKJ(NLPFCDLIDGG GEJKEHJBJMH, Unity.Entities.Archetype*[] DBFCJKHGCAE, UnsafeHashMap<ulong, OJBCBOJHFKO> LKGJBJECNAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5452560", Offset = "0x5451560", VA = "0x185452560")]
		private unsafe static int GABADFBBDML(Unity.Entities.Archetype*[] DBFCJKHGCAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x54515A0", Offset = "0x54505A0", VA = "0x1854515A0")]
		private unsafe static void COEFODJHPDP(NLPFCDLIDGG GEJKEHJBJMH, Unity.Entities.Archetype*[] DBFCJKHGCAE, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ, NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5451330", Offset = "0x5450330", VA = "0x185451330")]
		private static NativeArray<int> CJCGPIJGCJB(NLPFCDLIDGG GEJKEHJBJMH)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5452D70", Offset = "0x5451D70", VA = "0x185452D70")]
		private static Memory<EntityArchetype> IPMOCFOFHCI(NLPFCDLIDGG GEJKEHJBJMH, NativeArray<int> DCPGKOEBMPG, EntityManager LKEHNCAJHHL, out int IELPCPEIDAC, out int CMIKPKFHPAA)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x54525D0", Offset = "0x54515D0", VA = "0x1854525D0")]
		private unsafe static void GFCFEDEHPDH(Unity.Entities.Chunk* JPHCKLIEAMG, ReadOnlySpan<byte> OFOCCMMPKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5450B30", Offset = "0x544FB30", VA = "0x185450B30")]
		private static void BAMOFEBHOHH(NLPFCDLIDGG GEJKEHJBJMH, NativeArray<int> DCPGKOEBMPG, Span<EntityArchetype> DBFCJKHGCAE, EntityManager LKEHNCAJHHL, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5454350", Offset = "0x5453350", VA = "0x185454350")]
		private unsafe static void NHFNKOOIACO(Unity.Entities.Chunk* LJGMJGKCAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5453430", Offset = "0x5452430", VA = "0x185453430")]
		private unsafe static void KENDCPEFAMF(NLPFCDLIDGG.BPMCLEPAMGO.CHIFPGAOFMF NPABAFANPLJ, int OHEDCGDHPNL, int NMGKMENNNGH, Unity.Entities.Chunk* JPHCKLIEAMG, NLPFCDLIDGG GEJKEHJBJMH, NativeArray<int> DCPGKOEBMPG, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5453740", Offset = "0x5452740", VA = "0x185453740")]
		public static void LLEPKDOKEFO(PGLNEDJDCBK HADAJAKADAH, in ByteString OFOCCMMPKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x54537D0", Offset = "0x54527D0", VA = "0x1854537D0")]
		public static void LLEPKDOKEFO(EntityManager LKEHNCAJHHL, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ, in ByteString OFOCCMMPKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5452920", Offset = "0x5451920", VA = "0x185452920")]
		private static bool HEDLMKHPEJI(Type NKICFHCCMMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5454000", Offset = "0x5453000", VA = "0x185454000")]
		private static void MCOBDPCICHD(TypeManager.TypeInfo MPEMJAALAAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5452BE0", Offset = "0x5451BE0", VA = "0x185452BE0")]
		private unsafe static int HIONPCAIDOA(Unity.Entities.Archetype*[] DBFCJKHGCAE, NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5451B70", Offset = "0x5450B70", VA = "0x185451B70")]
		private static int EAHJHDPFEFN(int DBMJEOKPFJK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x54542B0", Offset = "0x54532B0", VA = "0x1854542B0")]
		private static ulong MNPHMHLFPFD(int DBMJEOKPFJK)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class KDEOPGAADHJ
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x544BBD0", Offset = "0x544ABD0", VA = "0x18544BBD0")]
	private unsafe static Span<byte> AOGBBLNDHGC(Unity.Entities.Chunk* LJGMJGKCAEK, int CGIBPFOKKNL)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2724CD0", Offset = "0x2723CD0", VA = "0x182724CD0")]
	public unsafe static Span<T> OPNNLHAOCBN<T>(Unity.Entities.Chunk* LJGMJGKCAEK, int CGIBPFOKKNL)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2724C90", Offset = "0x2723C90", VA = "0x182724C90")]
	public static Span<T> OPNNLHAOCBN<T>(this ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x544BD70", Offset = "0x544AD70", VA = "0x18544BD70")]
	public unsafe static Span<Entity> CELBPOKAPAG(Unity.Entities.Chunk* LJGMJGKCAEK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x544BDE0", Offset = "0x544ADE0", VA = "0x18544BDE0")]
	public unsafe static void IIOELKEIHEG(Unity.Entities.Chunk* LJGMJGKCAEK, int CGIBPFOKKNL)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[Preserve]
	internal class _RRAssemblyIndex : ICKAPGKMOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5454740", Offset = "0x5453740", VA = "0x185454740", Slot = "4")]
		public sealed override void GEKIOEINPME()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
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

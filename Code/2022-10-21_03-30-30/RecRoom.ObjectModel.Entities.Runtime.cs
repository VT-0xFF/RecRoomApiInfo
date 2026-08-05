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
	[Cpp2IlInjected.Address(RVA = "0x53F34D0", Offset = "0x53F22D0", VA = "0x1853F34D0")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> EMBLFBKJDMN(this ref Unity.Entities.Archetype CEINJAHAPJN)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EBFAPONIKHK
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x53F30B0", Offset = "0x53F1EB0", VA = "0x1853F30B0")]
	public static Span<int> BANJEEFHNEL(this EntityArchetype CEINJAHAPJN)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EJAKLIOPDID
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x53F3120", Offset = "0x53F1F20", VA = "0x1853F3120")]
	public static bool PPICPACFBLI(this Entity GEEFHDFLBEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OCBAENFGEBO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x53F5390", Offset = "0x53F4190", VA = "0x1853F5390")]
	public static void IAAMEIPGHNE(this EntityManager LKEHNCAJHHL, Entity GEEFHDFLBEH, AMFJBNENFOE IIHOIPENPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x53F5780", Offset = "0x53F4580", VA = "0x1853F5780")]
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
			[Cpp2IlInjected.Address(RVA = "0x661A00", Offset = "0x660800", VA = "0x180661A00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D08B40", Offset = "0x2D07940", VA = "0x182D08B40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1EB9940", Offset = "0x1EB8740", VA = "0x181EB9940")]
		[DebuggerHidden]
		public MDDBMHANPKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2D08960", Offset = "0x2D07760", VA = "0x182D08960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2D08B00", Offset = "0x2D07900", VA = "0x182D08B00", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x661750", Offset = "0x660550", VA = "0x180661750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x34AA930", Offset = "0x34A9730", VA = "0x1834AA930")]
	private DNGADCDNDIK(byte[] CLABEIKAHOI, Action<Protobuf> AHEPBBCMBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2B90820", Offset = "0x2B8F620", VA = "0x182B90820")]
	public static global::DNGADCDNDIK<Protobuf> DAKLFHBAJIH<Data>(ReadOnlySpan<byte> OFOCCMMPKKL, ReadOnlySpan<Data> JJDMEICMPFG, Action<Protobuf> AHEPBBCMBBJ)
	{
		return default(global::DNGADCDNDIK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x34AA7A0", Offset = "0x34A95A0", VA = "0x1834AA7A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x34AA7E0", Offset = "0x34A95E0", VA = "0x1834AA7E0", Slot = "4")]
	[IteratorStateMachine(typeof(global::DNGADCDNDIK<>.MDDBMHANPKG))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x34AA8E0", Offset = "0x34A96E0", VA = "0x1834AA8E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D0B990", Offset = "0x2D0A790", VA = "0x182D0B990")]
	private MFCMLPHKKPD(byte[] CLABEIKAHOI, in Protobuf NMOGHPGOGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26AB740", Offset = "0x26AA540", VA = "0x1826AB740")]
	public static global::MFCMLPHKKPD<Protobuf> DAKLFHBAJIH<T>(ReadOnlySpan<T> JJDMEICMPFG)
	{
		return default(global::MFCMLPHKKPD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B8D0", Offset = "0x2D0A6D0", VA = "0x182D0B8D0")]
	public void INENMPDAIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B900", Offset = "0x2D0A700", VA = "0x182D0B900")]
	public ByteString JHMKMPECGAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B7A0", Offset = "0x2D0A5A0", VA = "0x182D0B7A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x53F3620", Offset = "0x53F2420", VA = "0x1853F3620", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x53F3140", Offset = "0x53F1F40", VA = "0x1853F3140", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x660AE0", Offset = "0x65F8E0", VA = "0x180660AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x53F1E40", Offset = "0x53F0C40", VA = "0x1853F1E40")]
	public MENLDHOCEOP(Type KHOOFKPBCKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AGGLFMPJHMG : MENLDHOCEOP
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x53F1E40", Offset = "0x53F0C40", VA = "0x1853F1E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x660AF0", Offset = "0x65F8F0", VA = "0x180660AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x53F3060", Offset = "0x53F1E60", VA = "0x1853F3060")]
	public DNCBNAJFIBH(Type MMOAOHAOFGC, Type KHOOFKPBCKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FLIEEAHPEDE : MENLDHOCEOP
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x53F1E40", Offset = "0x53F0C40", VA = "0x1853F1E40")]
	public FLIEEAHPEDE(Type KHOOFKPBCKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CIHFPOEPMJE : GNMMNAENLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x657020", Offset = "0x655E20", VA = "0x180657020")]
		[CompilerGenerated]
		get
		{
			return default(LBGCMANLNFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x53F1A60", Offset = "0x53F0860", VA = "0x1853F1A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x53F27F0", Offset = "0x53F15F0", VA = "0x1853F27F0")]
	public DFDDJEKPLDJ(PGLNEDJDCBK HADAJAKADAH, EntityManager LKEHNCAJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x235D780", Offset = "0x235C580", VA = "0x18235D780")]
	public bool CNAKOGFIEPL<T>(Entity GEEFHDFLBEH) where T : struct, ENNIBMEKCDB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x235F3D0", Offset = "0x235E1D0", VA = "0x18235F3D0")]
	public bool OLGILBFEMLA<T>(Entity GEEFHDFLBEH, out T IGJPNMBCJPK) where T : struct, ENNIBMEKCDB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x235DE40", Offset = "0x235CC40", VA = "0x18235DE40")]
	public T MCGLEKIFHMI<T>(Entity GEEFHDFLBEH) where T : struct, ENNIBMEKCDB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x235D7C0", Offset = "0x235C5C0", VA = "0x18235D7C0")]
	private ComponentType EOCKLHFNBEI<T>() where T : struct, ENNIBMEKCDB
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x53F2720", Offset = "0x53F1520", VA = "0x1853F2720")]
	private ComponentType EOCKLHFNBEI(Type NKICFHCCMMH)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class BOLFBGCGJHF
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B42B50", Offset = "0x3B41950", VA = "0x183B42B50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override Type ICPOAFKOLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3B43410", Offset = "0x3B42210", VA = "0x183B43410", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override int PHKOIPHKEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x21BC5A0", Offset = "0x21BB3A0", VA = "0x1821BC5A0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x21BC910", Offset = "0x21BB710", VA = "0x1821BC910")]
	public Data IPAHFFMFJNJ(Entity GEEFHDFLBEH)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x21BC980", Offset = "0x21BB780", VA = "0x1821BC980")]
	public Data JOODHILOOCK(Entity GEEFHDFLBEH)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected internal abstract View FEFGPJKGKAG(Entity GEEFHDFLBEH);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B92CC0", Offset = "0x2B91AC0", VA = "0x182B92CC0", Slot = "15")]
	protected internal override T FEFGPJKGKAG<T>(Entity GEEFHDFLBEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x21BC780", Offset = "0x21BB580", VA = "0x1821BC780", Slot = "16")]
	public override bool CNAKOGFIEPL(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1985630", Offset = "0x1984430", VA = "0x181985630")]
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
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9ADEE0", Offset = "0x9ACCE0", VA = "0x1809ADEE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D1F70", Offset = "0x6D0D70", VA = "0x1806D1F70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int EMMJFGOBFKF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x53F52B0", Offset = "0x53F40B0", VA = "0x1853F52B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EGNDHFFDDFH[] GCBPPJHPFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D1EA0", Offset = "0x6D0CA0", VA = "0x1806D1EA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	protected internal virtual EGNDHFFDDFH[] LBNDLOLGMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x53F51F0", Offset = "0x53F3FF0", VA = "0x1853F51F0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool LGNHFHLEBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x53F51C0", Offset = "0x53F3FC0", VA = "0x1853F51C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x53F50A0", Offset = "0x53F3EA0", VA = "0x1853F50A0")]
	public void ILMEFAAGLOH(EntityManager LKEHNCAJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53F4F50", Offset = "0x53F3D50", VA = "0x1853F4F50", Slot = "8")]
	public (uint, uint) EAHJHDPFEFN(Entity GEEFHDFLBEH)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x53F5010", Offset = "0x53F3E10", VA = "0x1853F5010", Slot = "9")]
	public bool HDCJELIGLFP(Entity GEEFHDFLBEH, (uint order, uint change) JKGBPKEJAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x2535160", Offset = "0x2533F60", VA = "0x182535160", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2075770", Offset = "0x2074570", VA = "0x182075770", Slot = "8")]
	protected virtual bool IPBMAHBFOKM(ReadOnlySpan<Data> JJDMEICMPFG, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x65A820", Offset = "0x659620", VA = "0x18065A820", Slot = "9")]
	protected virtual bool FPMCHDMPDKB(int JKGBPKEJAFA, Span<Data> JJDMEICMPFG, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x25350A0", Offset = "0x2533EA0", VA = "0x1825350A0", Slot = "5")]
	internal sealed override bool IPBMAHBFOKM(ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2533B10", Offset = "0x2532910", VA = "0x182533B10", Slot = "6")]
	internal sealed override bool FPMCHDMPDKB(int JKGBPKEJAFA, ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2B92910", Offset = "0x2B91710", VA = "0x182B92910")]
	protected global::MFCMLPHKKPD<Protobuf> KGANMPHGLDN<Protobuf>(ReadOnlySpan<Data> JJDMEICMPFG) where Protobuf : IMessage, new()
	{
		return default(global::MFCMLPHKKPD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B92880", Offset = "0x2B91680", VA = "0x182B92880")]
	protected global::DNGADCDNDIK<Protobuf> KELBNDMOAKA<Protobuf>(ReadOnlySpan<byte> OFOCCMMPKKL, ReadOnlySpan<Data> JJDMEICMPFG, Action<Protobuf> AHEPBBCMBBJ) where Protobuf : IMessage, new()
	{
		return default(global::DNGADCDNDIK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1985630", Offset = "0x1984430", VA = "0x181985630")]
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
	[Cpp2IlInjected.Address(RVA = "0x53F6A10", Offset = "0x53F5810", VA = "0x1853F6A10", Slot = "5")]
	internal virtual bool IPBMAHBFOKM(ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x65A820", Offset = "0x659620", VA = "0x18065A820", Slot = "6")]
	internal virtual bool FPMCHDMPDKB(int JKGBPKEJAFA, ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x2496A40", Offset = "0x2495840", VA = "0x182496A40")]
	public static void DPEIADHEJGM<T>(this ref T LPGHNKKMKEB, ref ArchetypeChunkIterator FPFJEOIHGBB) where T : struct, PFGAJLNHCIL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2496830", Offset = "0x2495630", VA = "0x182496830")]
	public static void DPEIADHEJGM<T>(this ref T LPGHNKKMKEB, EntityQuery KKNMFCOPDMJ) where T : struct, PFGAJLNHCIL
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class IHCEEJFPFHE
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x53F3950", Offset = "0x53F2750", VA = "0x1853F3950")]
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
	[Cpp2IlInjected.Address(RVA = "0x22728C0", Offset = "0x22716C0", VA = "0x1822728C0")]
	public ACMAOLIIJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2272590", Offset = "0x2271390", VA = "0x182272590", Slot = "4")]
	public bool FKLGFCOHCLF(int DBMJEOKPFJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x22722E0", Offset = "0x22710E0", VA = "0x1822722E0", Slot = "5")]
	public global::IGNGPODGPHC<BaseClass> BKEBLIAGHNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2272760", Offset = "0x2271560", VA = "0x182272760", Slot = "7")]
	protected virtual bool PPCAKDCCEDB(Type NKICFHCCMMH, int KHFLDKPJMNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2272630", Offset = "0x2271430", VA = "0x182272630", Slot = "8")]
	protected virtual int HHIADBMEOHD(Type NKICFHCCMMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x22725F0", Offset = "0x22713F0", VA = "0x1822725F0")]
	public void GEKIOEINPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x22726C0", Offset = "0x22714C0", VA = "0x1822726C0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x1675AA0", Offset = "0x16748A0", VA = "0x181675AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1675DB0", Offset = "0x1674BB0", VA = "0x181675DB0")]
	public IGNGPODGPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1675F40", Offset = "0x1674D40", VA = "0x181675F40")]
	public IGNGPODGPHC(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1675CD0", Offset = "0x1674AD0", VA = "0x181675CD0")]
	internal void HEFJCCLOLGO(int DBMJEOKPFJK, BaseClass ECAHBHLDJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x26A4370", Offset = "0x26A3170", VA = "0x1826A4370")]
	public bool DKBMNIOKKIE<T>(out BaseClass IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1675A00", Offset = "0x1674800", VA = "0x181675A00")]
	public bool DKBMNIOKKIE(Type MOBCJNJMMEJ, out BaseClass IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1675D50", Offset = "0x1674B50", VA = "0x181675D50")]
	public bool IJCMBMJHEBD(int DBMJEOKPFJK, out BaseClass IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x26A4E70", Offset = "0x26A3C70", VA = "0x1826A4E70")]
	public T LJJPNAJBGDL<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1675D80", Offset = "0x1674B80", VA = "0x181675D80")]
	public BaseClass LJJPNAJBGDL(Type MJEKEAHAIMA)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class ENOKCHMKPBH : global::ACMAOLIIJBA<AGGLFMPJHMG, BOLFBGCGJHF>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x53F3270", Offset = "0x53F2070", VA = "0x1853F3270")]
	public ENOKCHMKPBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class MALPCKCKHAH : global::ACMAOLIIJBA<DNCBNAJFIBH, NOBHGMEMAKH>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x53F4EE0", Offset = "0x53F3CE0", VA = "0x1853F4EE0")]
	public MALPCKCKHAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class ONCMEHHEOFA : global::ACMAOLIIJBA<FLIEEAHPEDE, PGOOPFJKLFO>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x53F5990", Offset = "0x53F4790", VA = "0x1853F5990")]
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
		[Cpp2IlInjected.Address(RVA = "0x74C1F0", Offset = "0x74AFF0", VA = "0x18074C1F0")]
		private ComponentSystemTypes(List<Type> DCPGKOEBMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x53F25C0", Offset = "0x53F13C0", VA = "0x1853F25C0")]
		public static void GEKIOEINPME(List<Type> DCPGKOEBMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x53F2350", Offset = "0x53F1150", VA = "0x1853F2350")]
		private void BMKKEJLIDNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x53F2650", Offset = "0x53F1450", VA = "0x1853F2650")]
		private bool PPCAKDCCEDB(Type NKICFHCCMMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x53F2560", Offset = "0x53F1360", VA = "0x1853F2560")]
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
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190")]
	protected IKEIJDHBAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class DBEHBMCDNIE : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190")]
	protected DBEHBMCDNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class IKMBABCDPGL : IKEIJDHBAML
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x53F3BE0", Offset = "0x53F29E0", VA = "0x1853F3BE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	protected void BIAEOJAMGMN(string IALJJELLBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190")]
	protected IKMBABCDPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x53F7A00", Offset = "0x53F6800", VA = "0x1853F7A00")]
		public static ComponentSystemGroup[] JKOOGAFMBEC(World HADAJAKADAH, DEJCLABDFEB NJKJJANIDJB = DEJCLABDFEB.Default, bool BDGLGIDHPMA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x53F6E10", Offset = "0x53F5C10", VA = "0x1853F6E10")]
		private static Type[] GLNCEMNEBIA(DEJCLABDFEB NJKJJANIDJB, bool BDGLGIDHPMA, ComponentSystemGroup[] COLHOIJDBIK, ComponentSystemGroup GJAMECFFOKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x53F7170", Offset = "0x53F5F70", VA = "0x1853F7170")]
		private static ComponentSystemGroup[] ICBABKLHMDF(World HADAJAKADAH, out ComponentSystemGroup GJAMECFFOKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x53F6A30", Offset = "0x53F5830", VA = "0x1853F6A30")]
		internal static bool CHKBPHPAAHM(LBGCMANLNFC IDKBHBKJHPJ, out EEDDFLCIHPA FBKAMCPDHHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x53F7AD0", Offset = "0x53F68D0", VA = "0x1853F7AD0")]
		private static ComponentSystemGroup NCBIPKIPOGE(Type NKICFHCCMMH, World HADAJAKADAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x53F6C80", Offset = "0x53F5A80", VA = "0x1853F6C80")]
		private static ComponentSystemGroup[] CLCKBGPHHJG(Type[] DCPGKOEBMPG, World HADAJAKADAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x53F74E0", Offset = "0x53F62E0", VA = "0x1853F74E0")]
		internal static void JKLEJAGIFDB(World HADAJAKADAH, Type[] COMOOCFPNPF, ComponentSystemGroup[] COLHOIJDBIK, ComponentSystemGroup GJAMECFFOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x53F6DB0", Offset = "0x53F5BB0", VA = "0x1853F6DB0")]
		internal static bool FBIDAMKCIOD(ComponentSystemBase CHJMLFMLCJF, ComponentSystemGroup[] COLHOIJDBIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x53F7480", Offset = "0x53F6280", VA = "0x1853F7480")]
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
	[Cpp2IlInjected.Address(RVA = "0x6CE460", Offset = "0x6CD260", VA = "0x1806CE460")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x754F90", Offset = "0x753D90", VA = "0x180754F90")]
			[DebuggerHidden]
			public JAJLBOBBACH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x53F48C0", Offset = "0x53F36C0", VA = "0x1853F48C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x53F4620", Offset = "0x53F3420", VA = "0x1853F4620", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x53F4950", Offset = "0x53F3750", VA = "0x1853F4950")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x53F4880", Offset = "0x53F3680", VA = "0x1853F4880", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x53F47D0", Offset = "0x53F35D0", VA = "0x1853F47D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x53F47D0", Offset = "0x53F35D0", VA = "0x1853F47D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x53F7C40", Offset = "0x53F6A40", VA = "0x1853F7C40")]
		public static RRFilterWorldSystems DAKLFHBAJIH()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x53F82E0", Offset = "0x53F70E0", VA = "0x1853F82E0")]
		public RRFilterWorldSystems MPFIIJJAEOH(DEJCLABDFEB IDKBHBKJHPJ)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x53F8B00", Offset = "0x53F7900", VA = "0x1853F8B00")]
		public RRFilterWorldSystems PGNFBJILHHE(IEnumerable<Type> DCPGKOEBMPG)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x53F8240", Offset = "0x53F7040", VA = "0x1853F8240")]
		public RRFilterWorldSystems HDPNOHNEAFE(bool KEKJBICJBBE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x53F8AF0", Offset = "0x53F78F0", VA = "0x1853F8AF0")]
		public RRFilterWorldSystems PANEBOGAIKK(bool MPCKDGOMPJA)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x53F8250", Offset = "0x53F7050", VA = "0x1853F8250")]
		public FPGIJHEELFO JOJNJGOGONO(Type[] JLKLLDHFKFP)
		{
			return default(FPGIJHEELFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x53F7D70", Offset = "0x53F6B70", VA = "0x1853F7D70")]
		[IteratorStateMachine(typeof(JAJLBOBBACH))]
		internal IEnumerable<Type> GBBEGHJLHHG(IEnumerable<Type> DCPGKOEBMPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x53F7E00", Offset = "0x53F6C00", VA = "0x1853F7E00")]
		internal Dictionary<Type, List<Type>> GFOKINOLNBI(IEnumerable<Type> DCPGKOEBMPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x53F7C60", Offset = "0x53F6A60", VA = "0x1853F7C60")]
		private void FPIDEEHHIHB(Dictionary<Type, List<Type>> FALFIAAPAEL, Type NKICFHCCMMH, Type GOMNPNDGEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x53F82F0", Offset = "0x53F70F0", VA = "0x1853F82F0")]
		internal HashSet<Type> NOECJAPBKCA(IEnumerable<Type> COLHOIJDBIK, Dictionary<Type, List<Type>> AHGHAANFJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x53F84B0", Offset = "0x53F72B0", VA = "0x1853F84B0")]
		internal bool OHBKEALJJOM(Type NKICFHCCMMH, DEJCLABDFEB NJKJJANIDJB, bool BDGLGIDHPMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x53F80E0", Offset = "0x53F6EE0", VA = "0x1853F80E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53F3800", Offset = "0x53F2600", VA = "0x1853F3800")]
	public static void ILMEFAAGLOH(bool EFJKFNKFDIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x53F3660", Offset = "0x53F2460", VA = "0x1853F3660")]
	private static void BOAPCJAEODE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class HOAKFABAAIA
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x53F3860", Offset = "0x53F2660", VA = "0x1853F3860")]
	public static ulong CGODPODANGB(Type NKICFHCCMMH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x53F3890", Offset = "0x53F2690", VA = "0x1853F3890")]
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
			[Cpp2IlInjected.Address(RVA = "0xC4DB30", Offset = "0xC4C930", VA = "0x180C4DB30")]
			public JPHAOPHJJBE(ulong GPFJKHOIPCG, ulong LDMONCGFPAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x53F49A0", Offset = "0x53F37A0", VA = "0x1853F49A0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x53F97C0", Offset = "0x53F85C0", VA = "0x1853F97C0")]
		public static ulong MNPHMHLFPFD(int DBMJEOKPFJK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x53F9080", Offset = "0x53F7E80", VA = "0x1853F9080")]
		public static int HBJLAMNGILN(ulong LDMONCGFPAM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x53F91C0", Offset = "0x53F7FC0", VA = "0x1853F91C0")]
		public static void ILMEFAAGLOH(bool EFJKFNKFDIO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x53F8FA0", Offset = "0x53F7DA0", VA = "0x1853F8FA0")]
		private static void GECEPBCLENC(int EGDEEAOPNJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x53F8C80", Offset = "0x53F7A80", VA = "0x1853F8C80")]
		private static void GCGKDNGLDEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x53F9820", Offset = "0x53F8620", VA = "0x1853F9820")]
		private static JPHAOPHJJBE PJNFCOBGPGN(Type NKICFHCCMMH)
		{
			return default(JPHAOPHJJBE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x53F8C10", Offset = "0x53F7A10", VA = "0x1853F8C10")]
		private static ulong AHKAMANCPAC(Type NKICFHCCMMH, ulong LDMONCGFPAM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x53F95A0", Offset = "0x53F83A0", VA = "0x1853F95A0")]
		private static void MKAKMMLABMN(in JPHAOPHJJBE ALGPHJLPHJO, TypeManager.TypeInfo MPEMJAALAAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x53F93B0", Offset = "0x53F81B0", VA = "0x1853F93B0")]
		private static void JEBGGIKNDLD(JPHAOPHJJBE MPEMJAALAAL, int DBMJEOKPFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x53F94C0", Offset = "0x53F82C0", VA = "0x1853F94C0")]
		private static void LDOLFKFGFFP(JPHAOPHJJBE MPEMJAALAAL, int DBMJEOKPFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x53F9130", Offset = "0x53F7F30", VA = "0x1853F9130")]
		private static JPHAOPHJJBE ILCLBADMEBN(int DBMJEOKPFJK)
		{
			return default(JPHAOPHJJBE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x53F94B0", Offset = "0x53F82B0", VA = "0x1853F94B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53F4200", Offset = "0x53F3000", VA = "0x1853F4200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal static global::OJMNPGPFHPH<PGOOPFJKLFO> BGFKNONEECL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x53F4140", Offset = "0x53F2F40", VA = "0x1853F4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal static global::OJMNPGPFHPH<BOLFBGCGJHF> DIBCAMGFHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x53F41A0", Offset = "0x53F2FA0", VA = "0x1853F41A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x53F3C90", Offset = "0x53F2A90", VA = "0x1853F3C90")]
	public static void ILMEFAAGLOH(bool EFJKFNKFDIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x53F3C10", Offset = "0x53F2A10", VA = "0x1853F3C10")]
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
	[Cpp2IlInjected.Address(RVA = "0x53F1E70", Offset = "0x53F0C70", VA = "0x1853F1E70")]
	public static int EAHJHDPFEFN(int DBMJEOKPFJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x53F1F90", Offset = "0x53F0D90", VA = "0x1853F1F90")]
	public static void ILMEFAAGLOH(bool EFJKFNKFDIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x53F2030", Offset = "0x53F0E30", VA = "0x1853F2030")]
	private static void IOICFPBJEPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x53F2280", Offset = "0x53F1080", VA = "0x1853F2280")]
	private static int KCCJOMEGCHO(Type NKICFHCCMMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x53F1F10", Offset = "0x53F0D10", VA = "0x1853F1F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public World EKGNNGCIOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x74D170", Offset = "0x74BF70", VA = "0x18074D170")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DFDDJEKPLDJ KAAPDHONNOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public global::IGNGPODGPHC<NOBHGMEMAKH> GGIKGBBCIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6B19F0", Offset = "0x6B07F0", VA = "0x1806B19F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public global::IGNGPODGPHC<PGOOPFJKLFO> BGFKNONEECL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x661A10", Offset = "0x660810", VA = "0x180661A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x661A20", Offset = "0x660820", VA = "0x180661A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public global::IGNGPODGPHC<BOLFBGCGJHF> DIBCAMGFHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x67EA40", Offset = "0x67D840", VA = "0x18067EA40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x67EB70", Offset = "0x67D970", VA = "0x18067EB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> ELOFBPOOINO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x74D1B0", Offset = "0x74BFB0", VA = "0x18074D1B0")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x53F6190", Offset = "0x53F4F90", VA = "0x1853F6190")]
	public static PGLNEDJDCBK GACAKOPDIMA(string BEMAPDNKPAD, LBGCMANLNFC IDKBHBKJHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x53F64F0", Offset = "0x53F52F0", VA = "0x1853F64F0")]
	public PGLNEDJDCBK(string BEMAPDNKPAD, LBGCMANLNFC IDKBHBKJHPJ = LBGCMANLNFC.Simulation, DEJCLABDFEB NJKJJANIDJB = DEJCLABDFEB.Default, bool EFJKFNKFDIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x53F6210", Offset = "0x53F5010", VA = "0x1853F6210")]
	public ComponentSystemBase GHLFOJENCOJ(Type NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F74D80", Offset = "0x2F73B80", VA = "0x182F74D80")]
	public T GHLFOJENCOJ<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x53F5CD0", Offset = "0x53F4AD0", VA = "0x1853F5CD0")]
	public void DPHPIFPPBBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x53F6320", Offset = "0x53F5120", VA = "0x1853F6320")]
	public void HMDEEKCAALF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x53F6230", Offset = "0x53F5030", VA = "0x1853F6230")]
	public void HJAKNCCJKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x53F5E00", Offset = "0x53F4C00", VA = "0x1853F5E00")]
	public void FDNMIFDFHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x53F5DA0", Offset = "0x53F4BA0", VA = "0x1853F5DA0")]
	public void ELBOOCHDDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x53F6490", Offset = "0x53F5290", VA = "0x1853F6490")]
	public void NIINGCCOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x53F6290", Offset = "0x53F5090", VA = "0x1853F6290")]
	public void HLMHFKCAAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x53F5E60", Offset = "0x53F4C60", VA = "0x1853F5E60")]
	public void FGBEMENNDNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x53F5C70", Offset = "0x53F4A70", VA = "0x1853F5C70")]
	public void DLGKFBBKHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x53F5B90", Offset = "0x53F4990", VA = "0x1853F5B90")]
	internal void DKIMDJBDIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x53F5B10", Offset = "0x53F4910", VA = "0x1853F5B10")]
	private bool CGLLPKJLEJA(ComponentSystemGroup DEIPGHEFMEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x53F5EC0", Offset = "0x53F4CC0", VA = "0x1853F5EC0")]
	private void FPJEBEBNEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x53F6380", Offset = "0x53F5180", VA = "0x1853F6380")]
	private ComponentSystemGroup[] JKOOGAFMBEC(DEJCLABDFEB NJKJJANIDJB, bool BDGLGIDHPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x53F5D30", Offset = "0x53F4B30", VA = "0x1853F5D30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6619E0", Offset = "0x6607E0", VA = "0x1806619E0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	protected JIGELGFIMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[DisableAutoCreation]
public sealed class BINCJPPOHMK : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public BINCJPPOHMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DisableAutoCreation]
public sealed class NGBOFDOMIKJ : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public NGBOFDOMIKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DisableAutoCreation]
public sealed class ILHIKHAIJNM : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public ILHIKHAIJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DisableAutoCreation]
public sealed class KAHDFHOCEMC : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public KAHDFHOCEMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DisableAutoCreation]
public sealed class FNPHKNFELIE : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public FNPHKNFELIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DisableAutoCreation]
public sealed class ANCFDIJGMDO : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public ANCFDIJGMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DisableAutoCreation]
public sealed class KIABADAKEGB : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public KIABADAKEGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DisableAutoCreation]
public sealed class HEEHHHHFPDD : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public HEEHHHHFPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DisableAutoCreation]
public sealed class MKELNEOKOJK : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public MKELNEOKOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A820", Offset = "0x659620", VA = "0x18065A820", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C70", Offset = "0x26E5A70", VA = "0x1826E6C70")]
	public LKLKPHFEOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[AttributeUsage(AttributeTargets.Class)]
public class NAOJPPNIGOE : GNMMNAENLHM
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xC48CB0", Offset = "0xC47AB0", VA = "0x180C48CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public HCCMGJPLKMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x53F1C60", Offset = "0x53F0A60", VA = "0x1853F1C60")]
	static ADAIGOIIEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1ED7380", Offset = "0x1ED6180", VA = "0x181ED7380")]
	public static void HOOBINPCHAM<T>(HPCFBKIFDLB<T, T> NHKDGEMAIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1ED71D0", Offset = "0x1ED5FD0", VA = "0x181ED71D0")]
	public static void HOOBINPCHAM<From, To>(HPCFBKIFDLB<From, To> NHKDGEMAIFP, HPCFBKIFDLB<To, From> EBGNBGLEENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1ED7180", Offset = "0x1ED5F80", VA = "0x181ED7180")]
	public static void HOOBINPCHAM<From, To>(HPCFBKIFDLB<From, To> JMGBKPCMOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1EDE6F0", Offset = "0x1EDD4F0", VA = "0x181EDE6F0")]
	public static HPCFBKIFDLB<From, To> MFFAHOPKPEH<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1ED9D20", Offset = "0x1ED8B20", VA = "0x181ED9D20")]
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
	[Cpp2IlInjected.Address(RVA = "0xAC6AC0", Offset = "0xAC58C0", VA = "0x180AC6AC0")]
	public KLBODNIPMJE(NativeArray<EntityRemapUtility.EntityRemapInfo> AELKIPHCLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC180", Offset = "0x2AEAF80", VA = "0x182AEC180")]
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
	[Cpp2IlInjected.Address(RVA = "0x53F32E0", Offset = "0x53F20E0", VA = "0x1853F32E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x661A30", Offset = "0x660830", VA = "0x180661A30")]
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
				[Cpp2IlInjected.Address(RVA = "0x53F4490", Offset = "0x53F3290", VA = "0x1853F4490")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public long NEMNDPNMPOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x53F45B0", Offset = "0x53F33B0", VA = "0x1853F45B0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x53F44F0", Offset = "0x53F32F0", VA = "0x1853F44F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x53F3B80", Offset = "0x53F2980", VA = "0x1853F3B80")]
				public unsafe IIGALELMLLI(Unity.Entities.Archetype* NPABAFANPLJ, NLPFCDLIDGG.BPMCLEPAMGO.CHIFPGAOFMF HJPOJJGNAHE, KLBODNIPMJE NGGOKHONBCG, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ, int CGIBPFOKKNL, int EFPAICPDPKD = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x53F3B30", Offset = "0x53F2930", VA = "0x1853F3B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x53F2F20", Offset = "0x53F1D20", VA = "0x1853F2F20")]
			public DKCPJJLPNKB(IIGALELMLLI[] JJDMEICMPFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x53F2BF0", Offset = "0x53F19F0", VA = "0x1853F2BF0", Slot = "4")]
			public void Invoke(int AIPHGHFENPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x53F2840", Offset = "0x53F1640", VA = "0x1853F2840")]
			private void COCDBPIPMNJ(in IIGALELMLLI JANIFNADDOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x53F2C50", Offset = "0x53F1A50", VA = "0x1853F2C50")]
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
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public NOFKMEDEIEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x53F5320", Offset = "0x53F4120", VA = "0x1853F5320")]
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
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public PEBAEMMCPJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x53F5A00", Offset = "0x53F4800", VA = "0x1853F5A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x53FD230", Offset = "0x53FC030", VA = "0x1853FD230")]
		private unsafe static bool OGDFFIDIIFL(Unity.Entities.Archetype* CEINJAHAPJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x53FB1E0", Offset = "0x53F9FE0", VA = "0x1853FB1E0")]
		internal unsafe static Unity.Entities.Archetype*[] FJIDPBEJPPE(ref Unity.Entities.EntityComponentStore APHBGABGANA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x53FA0D0", Offset = "0x53F8ED0", VA = "0x1853FA0D0")]
		public static void CCMIFLHPNMM(PGLNEDJDCBK HADAJAKADAH, out ByteString OFOCCMMPKKL, out NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x53FAAB0", Offset = "0x53F98B0", VA = "0x1853FAAB0")]
		internal static void FHPNCIJKCAP(PGLNEDJDCBK HADAJAKADAH, NLPFCDLIDGG GEJKEHJBJMH, out NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x53FCBD0", Offset = "0x53FB9D0", VA = "0x1853FCBD0")]
		private unsafe static UnsafeHashMap<ulong, OJBCBOJHFKO> LMLNIKEJBFM(Unity.Entities.Archetype*[] DBFCJKHGCAE)
		{
			return default(UnsafeHashMap<ulong, OJBCBOJHFKO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x53FA820", Offset = "0x53F9620", VA = "0x1853FA820")]
		private static void DFFBCHHKNDD(NLPFCDLIDGG GEJKEHJBJMH, UnsafeHashMap<ulong, OJBCBOJHFKO> LKGJBJECNAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x53FBF60", Offset = "0x53FAD60", VA = "0x1853FBF60")]
		private unsafe static void JOKDFPBAOKJ(NLPFCDLIDGG GEJKEHJBJMH, Unity.Entities.Archetype*[] DBFCJKHGCAE, UnsafeHashMap<ulong, OJBCBOJHFKO> LKGJBJECNAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x53FB3C0", Offset = "0x53FA1C0", VA = "0x1853FB3C0")]
		private unsafe static int GABADFBBDML(Unity.Entities.Archetype*[] DBFCJKHGCAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x53FA400", Offset = "0x53F9200", VA = "0x1853FA400")]
		private unsafe static void COEFODJHPDP(NLPFCDLIDGG GEJKEHJBJMH, Unity.Entities.Archetype*[] DBFCJKHGCAE, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ, NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x53FA190", Offset = "0x53F8F90", VA = "0x1853FA190")]
		private static NativeArray<int> CJCGPIJGCJB(NLPFCDLIDGG GEJKEHJBJMH)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x53FBBD0", Offset = "0x53FA9D0", VA = "0x1853FBBD0")]
		private static Memory<EntityArchetype> IPMOCFOFHCI(NLPFCDLIDGG GEJKEHJBJMH, NativeArray<int> DCPGKOEBMPG, EntityManager LKEHNCAJHHL, out int IELPCPEIDAC, out int CMIKPKFHPAA)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x53FB430", Offset = "0x53FA230", VA = "0x1853FB430")]
		private unsafe static void GFCFEDEHPDH(Unity.Entities.Chunk* JPHCKLIEAMG, ReadOnlySpan<byte> OFOCCMMPKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x53F9990", Offset = "0x53F8790", VA = "0x1853F9990")]
		private static void BAMOFEBHOHH(NLPFCDLIDGG GEJKEHJBJMH, NativeArray<int> DCPGKOEBMPG, Span<EntityArchetype> DBFCJKHGCAE, EntityManager LKEHNCAJHHL, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x53FD1B0", Offset = "0x53FBFB0", VA = "0x1853FD1B0")]
		private unsafe static void NHFNKOOIACO(Unity.Entities.Chunk* LJGMJGKCAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x53FC290", Offset = "0x53FB090", VA = "0x1853FC290")]
		private unsafe static void KENDCPEFAMF(NLPFCDLIDGG.BPMCLEPAMGO.CHIFPGAOFMF NPABAFANPLJ, int OHEDCGDHPNL, int NMGKMENNNGH, Unity.Entities.Chunk* JPHCKLIEAMG, NLPFCDLIDGG GEJKEHJBJMH, NativeArray<int> DCPGKOEBMPG, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x53FC5A0", Offset = "0x53FB3A0", VA = "0x1853FC5A0")]
		public static void LLEPKDOKEFO(PGLNEDJDCBK HADAJAKADAH, in ByteString OFOCCMMPKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x53FC630", Offset = "0x53FB430", VA = "0x1853FC630")]
		public static void LLEPKDOKEFO(EntityManager LKEHNCAJHHL, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ, in ByteString OFOCCMMPKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x53FB780", Offset = "0x53FA580", VA = "0x1853FB780")]
		private static bool HEDLMKHPEJI(Type NKICFHCCMMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x53FCE60", Offset = "0x53FBC60", VA = "0x1853FCE60")]
		private static void MCOBDPCICHD(TypeManager.TypeInfo MPEMJAALAAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x53FBA40", Offset = "0x53FA840", VA = "0x1853FBA40")]
		private unsafe static int HIONPCAIDOA(Unity.Entities.Archetype*[] DBFCJKHGCAE, NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x53FA9D0", Offset = "0x53F97D0", VA = "0x1853FA9D0")]
		private static int EAHJHDPFEFN(int DBMJEOKPFJK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x53FD110", Offset = "0x53FBF10", VA = "0x1853FD110")]
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
	[Cpp2IlInjected.Address(RVA = "0x53F4A30", Offset = "0x53F3830", VA = "0x1853F4A30")]
	private unsafe static Span<byte> AOGBBLNDHGC(Unity.Entities.Chunk* LJGMJGKCAEK, int CGIBPFOKKNL)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x240CF50", Offset = "0x240BD50", VA = "0x18240CF50")]
	public unsafe static Span<T> OPNNLHAOCBN<T>(Unity.Entities.Chunk* LJGMJGKCAEK, int CGIBPFOKKNL)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x240CF10", Offset = "0x240BD10", VA = "0x18240CF10")]
	public static Span<T> OPNNLHAOCBN<T>(this ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x53F4BD0", Offset = "0x53F39D0", VA = "0x1853F4BD0")]
	public unsafe static Span<Entity> CELBPOKAPAG(Unity.Entities.Chunk* LJGMJGKCAEK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x53F4C40", Offset = "0x53F3A40", VA = "0x1853F4C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x660AD0", Offset = "0x65F8D0", VA = "0x180660AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x53FD5A0", Offset = "0x53FC3A0", VA = "0x1853FD5A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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

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
	[Cpp2IlInjected.Address(RVA = "0x5434C50", Offset = "0x5433A50", VA = "0x185434C50")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> EMBLFBKJDMN(this ref Unity.Entities.Archetype CEINJAHAPJN)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EBFAPONIKHK
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5434830", Offset = "0x5433630", VA = "0x185434830")]
	public static Span<int> BANJEEFHNEL(this EntityArchetype CEINJAHAPJN)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EJAKLIOPDID
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x54348A0", Offset = "0x54336A0", VA = "0x1854348A0")]
	public static bool PPICPACFBLI(this Entity GEEFHDFLBEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OCBAENFGEBO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5436B10", Offset = "0x5435910", VA = "0x185436B10")]
	public static void IAAMEIPGHNE(this EntityManager LKEHNCAJHHL, Entity GEEFHDFLBEH, AMFJBNENFOE IIHOIPENPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5436F00", Offset = "0x5435D00", VA = "0x185436F00")]
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
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x676E40", VA = "0x180678040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2E4A720", Offset = "0x2E49520", VA = "0x182E4A720", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA2D0", Offset = "0x1FF90D0", VA = "0x181FFA2D0")]
		[DebuggerHidden]
		public MDDBMHANPKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2E4A540", Offset = "0x2E49340", VA = "0x182E4A540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2E4A6E0", Offset = "0x2E494E0", VA = "0x182E4A6E0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x35910E0", Offset = "0x358FEE0", VA = "0x1835910E0")]
	private DNGADCDNDIK(byte[] CLABEIKAHOI, Action<Protobuf> AHEPBBCMBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD23F0", Offset = "0x2CD11F0", VA = "0x182CD23F0")]
	public static global::DNGADCDNDIK<Protobuf> DAKLFHBAJIH<Data>(ReadOnlySpan<byte> OFOCCMMPKKL, ReadOnlySpan<Data> JJDMEICMPFG, Action<Protobuf> AHEPBBCMBBJ)
	{
		return default(global::DNGADCDNDIK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3590F50", Offset = "0x358FD50", VA = "0x183590F50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3590F90", Offset = "0x358FD90", VA = "0x183590F90", Slot = "4")]
	[IteratorStateMachine(typeof(global::DNGADCDNDIK<>.MDDBMHANPKG))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3591090", Offset = "0x358FE90", VA = "0x183591090", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E4D570", Offset = "0x2E4C370", VA = "0x182E4D570")]
	private MFCMLPHKKPD(byte[] CLABEIKAHOI, in Protobuf NMOGHPGOGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x27ECB20", Offset = "0x27EB920", VA = "0x1827ECB20")]
	public static global::MFCMLPHKKPD<Protobuf> DAKLFHBAJIH<T>(ReadOnlySpan<T> JJDMEICMPFG)
	{
		return default(global::MFCMLPHKKPD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D4B0", Offset = "0x2E4C2B0", VA = "0x182E4D4B0")]
	public void INENMPDAIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D4E0", Offset = "0x2E4C2E0", VA = "0x182E4D4E0")]
	public ByteString JHMKMPECGAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D380", Offset = "0x2E4C180", VA = "0x182E4D380", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5434DA0", Offset = "0x5433BA0", VA = "0x185434DA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54348C0", Offset = "0x54336C0", VA = "0x1854348C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x675F30", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xD91420", Offset = "0xD90220", VA = "0x180D91420")]
	public MENLDHOCEOP(Type KHOOFKPBCKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AGGLFMPJHMG : MENLDHOCEOP
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xD91420", Offset = "0xD90220", VA = "0x180D91420")]
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
		[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x675F40", VA = "0x180677140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x54347E0", Offset = "0x54335E0", VA = "0x1854347E0")]
	public DNCBNAJFIBH(Type MMOAOHAOFGC, Type KHOOFKPBCKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FLIEEAHPEDE : MENLDHOCEOP
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xD91420", Offset = "0xD90220", VA = "0x180D91420")]
	public FLIEEAHPEDE(Type KHOOFKPBCKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CIHFPOEPMJE : GNMMNAENLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x657040", Offset = "0x655E40", VA = "0x180657040")]
		[CompilerGenerated]
		get
		{
			return default(LBGCMANLNFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xD913F0", Offset = "0xD901F0", VA = "0x180D913F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5433F70", Offset = "0x5432D70", VA = "0x185433F70")]
	public DFDDJEKPLDJ(PGLNEDJDCBK HADAJAKADAH, EntityManager LKEHNCAJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x249E3B0", Offset = "0x249D1B0", VA = "0x18249E3B0")]
	public bool CNAKOGFIEPL<T>(Entity GEEFHDFLBEH) where T : struct, ENNIBMEKCDB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x24A0000", Offset = "0x249EE00", VA = "0x1824A0000")]
	public bool OLGILBFEMLA<T>(Entity GEEFHDFLBEH, out T IGJPNMBCJPK) where T : struct, ENNIBMEKCDB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x249EA70", Offset = "0x249D870", VA = "0x18249EA70")]
	public T MCGLEKIFHMI<T>(Entity GEEFHDFLBEH) where T : struct, ENNIBMEKCDB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x249E3F0", Offset = "0x249D1F0", VA = "0x18249E3F0")]
	private ComponentType EOCKLHFNBEI<T>() where T : struct, ENNIBMEKCDB
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5433EA0", Offset = "0x5432CA0", VA = "0x185433EA0")]
	private ComponentType EOCKLHFNBEI(Type NKICFHCCMMH)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class BOLFBGCGJHF
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BA0250", Offset = "0x3B9F050", VA = "0x183BA0250", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override Type ICPOAFKOLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3BA0B10", Offset = "0x3B9F910", VA = "0x183BA0B10", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override int PHKOIPHKEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x22FD320", Offset = "0x22FC120", VA = "0x1822FD320", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x22FD690", Offset = "0x22FC490", VA = "0x1822FD690")]
	public Data IPAHFFMFJNJ(Entity GEEFHDFLBEH)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x22FD700", Offset = "0x22FC500", VA = "0x1822FD700")]
	public Data JOODHILOOCK(Entity GEEFHDFLBEH)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected internal abstract View FEFGPJKGKAG(Entity GEEFHDFLBEH);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4890", Offset = "0x2CD3690", VA = "0x182CD4890", Slot = "15")]
	protected internal override T FEFGPJKGKAG<T>(Entity GEEFHDFLBEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x22FD500", Offset = "0x22FC300", VA = "0x1822FD500", Slot = "16")]
	public override bool CNAKOGFIEPL(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1AC62E0", Offset = "0x1AC50E0", VA = "0x181AC62E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x14FB3F0", Offset = "0x14FA1F0", VA = "0x1814FB3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x779980", Offset = "0x778780", VA = "0x180779980", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int EMMJFGOBFKF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5436A30", Offset = "0x5435830", VA = "0x185436A30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EGNDHFFDDFH[] GCBPPJHPFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7798B0", Offset = "0x7786B0", VA = "0x1807798B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	protected internal virtual EGNDHFFDDFH[] LBNDLOLGMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5436970", Offset = "0x5435770", VA = "0x185436970", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool LGNHFHLEBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5436940", Offset = "0x5435740", VA = "0x185436940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5436820", Offset = "0x5435620", VA = "0x185436820")]
	public void ILMEFAAGLOH(EntityManager LKEHNCAJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x737040", Offset = "0x735E40", VA = "0x180737040")]
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
	[Cpp2IlInjected.Address(RVA = "0x54366D0", Offset = "0x54354D0", VA = "0x1854366D0", Slot = "8")]
	public (uint, uint) EAHJHDPFEFN(Entity GEEFHDFLBEH)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5436790", Offset = "0x5435590", VA = "0x185436790", Slot = "9")]
	public bool HDCJELIGLFP(Entity GEEFHDFLBEH, (uint order, uint change) JKGBPKEJAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2676530", Offset = "0x2675330", VA = "0x182676530", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x21B6540", Offset = "0x21B5340", VA = "0x1821B6540", Slot = "8")]
	protected virtual bool IPBMAHBFOKM(ReadOnlySpan<Data> JJDMEICMPFG, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659B00", VA = "0x18065AD00", Slot = "9")]
	protected virtual bool FPMCHDMPDKB(int JKGBPKEJAFA, Span<Data> JJDMEICMPFG, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2676470", Offset = "0x2675270", VA = "0x182676470", Slot = "5")]
	internal sealed override bool IPBMAHBFOKM(ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2674EE0", Offset = "0x2673CE0", VA = "0x182674EE0", Slot = "6")]
	internal sealed override bool FPMCHDMPDKB(int JKGBPKEJAFA, ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2CD44E0", Offset = "0x2CD32E0", VA = "0x182CD44E0")]
	protected global::MFCMLPHKKPD<Protobuf> KGANMPHGLDN<Protobuf>(ReadOnlySpan<Data> JJDMEICMPFG) where Protobuf : IMessage, new()
	{
		return default(global::MFCMLPHKKPD<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4450", Offset = "0x2CD3250", VA = "0x182CD4450")]
	protected global::DNGADCDNDIK<Protobuf> KELBNDMOAKA<Protobuf>(ReadOnlySpan<byte> OFOCCMMPKKL, ReadOnlySpan<Data> JJDMEICMPFG, Action<Protobuf> AHEPBBCMBBJ) where Protobuf : IMessage, new()
	{
		return default(global::DNGADCDNDIK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1AC62E0", Offset = "0x1AC50E0", VA = "0x181AC62E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5438190", Offset = "0x5436F90", VA = "0x185438190", Slot = "5")]
	internal virtual bool IPBMAHBFOKM(ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659B00", VA = "0x18065AD00", Slot = "6")]
	internal virtual bool FPMCHDMPDKB(int JKGBPKEJAFA, ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x25D7E70", Offset = "0x25D6C70", VA = "0x1825D7E70")]
	public static void DPEIADHEJGM<T>(this ref T LPGHNKKMKEB, ref ArchetypeChunkIterator FPFJEOIHGBB) where T : struct, PFGAJLNHCIL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25D7C60", Offset = "0x25D6A60", VA = "0x1825D7C60")]
	public static void DPEIADHEJGM<T>(this ref T LPGHNKKMKEB, EntityQuery KKNMFCOPDMJ) where T : struct, PFGAJLNHCIL
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class IHCEEJFPFHE
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x54350D0", Offset = "0x5433ED0", VA = "0x1854350D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x23B3620", Offset = "0x23B2420", VA = "0x1823B3620")]
	public ACMAOLIIJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x23B32F0", Offset = "0x23B20F0", VA = "0x1823B32F0", Slot = "4")]
	public bool FKLGFCOHCLF(int DBMJEOKPFJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23B3040", Offset = "0x23B1E40", VA = "0x1823B3040", Slot = "5")]
	public global::IGNGPODGPHC<BaseClass> BKEBLIAGHNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x23B34C0", Offset = "0x23B22C0", VA = "0x1823B34C0", Slot = "7")]
	protected virtual bool PPCAKDCCEDB(Type NKICFHCCMMH, int KHFLDKPJMNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x23B3390", Offset = "0x23B2190", VA = "0x1823B3390", Slot = "8")]
	protected virtual int HHIADBMEOHD(Type NKICFHCCMMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x23B3350", Offset = "0x23B2150", VA = "0x1823B3350")]
	public void GEKIOEINPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x23B3420", Offset = "0x23B2220", VA = "0x1823B3420", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x17B6710", Offset = "0x17B5510", VA = "0x1817B6710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x17B6A20", Offset = "0x17B5820", VA = "0x1817B6A20")]
	public IGNGPODGPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x17B6BB0", Offset = "0x17B59B0", VA = "0x1817B6BB0")]
	public IGNGPODGPHC(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x17B6940", Offset = "0x17B5740", VA = "0x1817B6940")]
	internal void HEFJCCLOLGO(int DBMJEOKPFJK, BaseClass ECAHBHLDJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x27E5750", Offset = "0x27E4550", VA = "0x1827E5750")]
	public bool DKBMNIOKKIE<T>(out BaseClass IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x17B6670", Offset = "0x17B5470", VA = "0x1817B6670")]
	public bool DKBMNIOKKIE(Type MOBCJNJMMEJ, out BaseClass IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x17B69C0", Offset = "0x17B57C0", VA = "0x1817B69C0")]
	public bool IJCMBMJHEBD(int DBMJEOKPFJK, out BaseClass IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x27E6250", Offset = "0x27E5050", VA = "0x1827E6250")]
	public T LJJPNAJBGDL<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x17B69F0", Offset = "0x17B57F0", VA = "0x1817B69F0")]
	public BaseClass LJJPNAJBGDL(Type MJEKEAHAIMA)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class ENOKCHMKPBH : global::ACMAOLIIJBA<AGGLFMPJHMG, BOLFBGCGJHF>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x54349F0", Offset = "0x54337F0", VA = "0x1854349F0")]
	public ENOKCHMKPBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class MALPCKCKHAH : global::ACMAOLIIJBA<DNCBNAJFIBH, NOBHGMEMAKH>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5436660", Offset = "0x5435460", VA = "0x185436660")]
	public MALPCKCKHAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class ONCMEHHEOFA : global::ACMAOLIIJBA<FLIEEAHPEDE, PGOOPFJKLFO>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5437110", Offset = "0x5435F10", VA = "0x185437110")]
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
		[Cpp2IlInjected.Address(RVA = "0x8648F0", Offset = "0x8636F0", VA = "0x1808648F0")]
		private ComponentSystemTypes(List<Type> DCPGKOEBMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5433D40", Offset = "0x5432B40", VA = "0x185433D40")]
		public static void GEKIOEINPME(List<Type> DCPGKOEBMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5433AD0", Offset = "0x54328D0", VA = "0x185433AD0")]
		private void BMKKEJLIDNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5433DD0", Offset = "0x5432BD0", VA = "0x185433DD0")]
		private bool PPCAKDCCEDB(Type NKICFHCCMMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5433CE0", Offset = "0x5432AE0", VA = "0x185433CE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0")]
	protected IKEIJDHBAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class DBEHBMCDNIE : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0")]
	protected DBEHBMCDNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class IKMBABCDPGL : IKEIJDHBAML
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5435360", Offset = "0x5434160", VA = "0x185435360", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	protected void BIAEOJAMGMN(string IALJJELLBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0")]
	protected IKMBABCDPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5439180", Offset = "0x5437F80", VA = "0x185439180")]
		public static ComponentSystemGroup[] JKOOGAFMBEC(World HADAJAKADAH, DEJCLABDFEB NJKJJANIDJB = DEJCLABDFEB.Default, bool BDGLGIDHPMA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5438590", Offset = "0x5437390", VA = "0x185438590")]
		private static Type[] GLNCEMNEBIA(DEJCLABDFEB NJKJJANIDJB, bool BDGLGIDHPMA, ComponentSystemGroup[] COLHOIJDBIK, ComponentSystemGroup GJAMECFFOKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x54388F0", Offset = "0x54376F0", VA = "0x1854388F0")]
		private static ComponentSystemGroup[] ICBABKLHMDF(World HADAJAKADAH, out ComponentSystemGroup GJAMECFFOKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x54381B0", Offset = "0x5436FB0", VA = "0x1854381B0")]
		internal static bool CHKBPHPAAHM(LBGCMANLNFC IDKBHBKJHPJ, out EEDDFLCIHPA FBKAMCPDHHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5439250", Offset = "0x5438050", VA = "0x185439250")]
		private static ComponentSystemGroup NCBIPKIPOGE(Type NKICFHCCMMH, World HADAJAKADAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5438400", Offset = "0x5437200", VA = "0x185438400")]
		private static ComponentSystemGroup[] CLCKBGPHHJG(Type[] DCPGKOEBMPG, World HADAJAKADAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5438C60", Offset = "0x5437A60", VA = "0x185438C60")]
		internal static void JKLEJAGIFDB(World HADAJAKADAH, Type[] COMOOCFPNPF, ComponentSystemGroup[] COLHOIJDBIK, ComponentSystemGroup GJAMECFFOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5438530", Offset = "0x5437330", VA = "0x185438530")]
		internal static bool FBIDAMKCIOD(ComponentSystemBase CHJMLFMLCJF, ComponentSystemGroup[] COLHOIJDBIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5438C00", Offset = "0x5437A00", VA = "0x185438C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x707A10", Offset = "0x706810", VA = "0x180707A10")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x9DD5E0", Offset = "0x9DC3E0", VA = "0x1809DD5E0")]
			[DebuggerHidden]
			public JAJLBOBBACH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5436040", Offset = "0x5434E40", VA = "0x185436040", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x5435DA0", Offset = "0x5434BA0", VA = "0x185435DA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x54360D0", Offset = "0x5434ED0", VA = "0x1854360D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5436000", Offset = "0x5434E00", VA = "0x185436000", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5435F50", Offset = "0x5434D50", VA = "0x185435F50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5435F50", Offset = "0x5434D50", VA = "0x185435F50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x54393C0", Offset = "0x54381C0", VA = "0x1854393C0")]
		public static RRFilterWorldSystems DAKLFHBAJIH()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5439A60", Offset = "0x5438860", VA = "0x185439A60")]
		public RRFilterWorldSystems MPFIIJJAEOH(DEJCLABDFEB IDKBHBKJHPJ)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x543A280", Offset = "0x5439080", VA = "0x18543A280")]
		public RRFilterWorldSystems PGNFBJILHHE(IEnumerable<Type> DCPGKOEBMPG)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x54399C0", Offset = "0x54387C0", VA = "0x1854399C0")]
		public RRFilterWorldSystems HDPNOHNEAFE(bool KEKJBICJBBE)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x543A270", Offset = "0x5439070", VA = "0x18543A270")]
		public RRFilterWorldSystems PANEBOGAIKK(bool MPCKDGOMPJA)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x54399D0", Offset = "0x54387D0", VA = "0x1854399D0")]
		public FPGIJHEELFO JOJNJGOGONO(Type[] JLKLLDHFKFP)
		{
			return default(FPGIJHEELFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x54394F0", Offset = "0x54382F0", VA = "0x1854394F0")]
		[IteratorStateMachine(typeof(JAJLBOBBACH))]
		internal IEnumerable<Type> GBBEGHJLHHG(IEnumerable<Type> DCPGKOEBMPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5439580", Offset = "0x5438380", VA = "0x185439580")]
		internal Dictionary<Type, List<Type>> GFOKINOLNBI(IEnumerable<Type> DCPGKOEBMPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x54393E0", Offset = "0x54381E0", VA = "0x1854393E0")]
		private void FPIDEEHHIHB(Dictionary<Type, List<Type>> FALFIAAPAEL, Type NKICFHCCMMH, Type GOMNPNDGEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5439A70", Offset = "0x5438870", VA = "0x185439A70")]
		internal HashSet<Type> NOECJAPBKCA(IEnumerable<Type> COLHOIJDBIK, Dictionary<Type, List<Type>> AHGHAANFJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5439C30", Offset = "0x5438A30", VA = "0x185439C30")]
		internal bool OHBKEALJJOM(Type NKICFHCCMMH, DEJCLABDFEB NJKJJANIDJB, bool BDGLGIDHPMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5439860", Offset = "0x5438660", VA = "0x185439860")]
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
	[Cpp2IlInjected.Address(RVA = "0x5434F80", Offset = "0x5433D80", VA = "0x185434F80")]
	public static void ILMEFAAGLOH(bool EFJKFNKFDIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5434DE0", Offset = "0x5433BE0", VA = "0x185434DE0")]
	private static void BOAPCJAEODE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class HOAKFABAAIA
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5434FE0", Offset = "0x5433DE0", VA = "0x185434FE0")]
	public static ulong CGODPODANGB(Type NKICFHCCMMH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5435010", Offset = "0x5433E10", VA = "0x185435010")]
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
			[Cpp2IlInjected.Address(RVA = "0xD8EF70", Offset = "0xD8DD70", VA = "0x180D8EF70")]
			public JPHAOPHJJBE(ulong GPFJKHOIPCG, ulong LDMONCGFPAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5436120", Offset = "0x5434F20", VA = "0x185436120", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x543AF40", Offset = "0x5439D40", VA = "0x18543AF40")]
		public static ulong MNPHMHLFPFD(int DBMJEOKPFJK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x543A800", Offset = "0x5439600", VA = "0x18543A800")]
		public static int HBJLAMNGILN(ulong LDMONCGFPAM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x543A940", Offset = "0x5439740", VA = "0x18543A940")]
		public static void ILMEFAAGLOH(bool EFJKFNKFDIO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x543A720", Offset = "0x5439520", VA = "0x18543A720")]
		private static void GECEPBCLENC(int EGDEEAOPNJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x543A400", Offset = "0x5439200", VA = "0x18543A400")]
		private static void GCGKDNGLDEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x543AFA0", Offset = "0x5439DA0", VA = "0x18543AFA0")]
		private static JPHAOPHJJBE PJNFCOBGPGN(Type NKICFHCCMMH)
		{
			return default(JPHAOPHJJBE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x543A390", Offset = "0x5439190", VA = "0x18543A390")]
		private static ulong AHKAMANCPAC(Type NKICFHCCMMH, ulong LDMONCGFPAM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x543AD20", Offset = "0x5439B20", VA = "0x18543AD20")]
		private static void MKAKMMLABMN(in JPHAOPHJJBE ALGPHJLPHJO, TypeManager.TypeInfo MPEMJAALAAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x543AB30", Offset = "0x5439930", VA = "0x18543AB30")]
		private static void JEBGGIKNDLD(JPHAOPHJJBE MPEMJAALAAL, int DBMJEOKPFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x543AC40", Offset = "0x5439A40", VA = "0x18543AC40")]
		private static void LDOLFKFGFFP(JPHAOPHJJBE MPEMJAALAAL, int DBMJEOKPFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x543A8B0", Offset = "0x54396B0", VA = "0x18543A8B0")]
		private static JPHAOPHJJBE ILCLBADMEBN(int DBMJEOKPFJK)
		{
			return default(JPHAOPHJJBE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x543AC30", Offset = "0x5439A30", VA = "0x18543AC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5435980", Offset = "0x5434780", VA = "0x185435980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal static global::OJMNPGPFHPH<PGOOPFJKLFO> BGFKNONEECL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x54358C0", Offset = "0x54346C0", VA = "0x1854358C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal static global::OJMNPGPFHPH<BOLFBGCGJHF> DIBCAMGFHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5435920", Offset = "0x5434720", VA = "0x185435920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5435410", Offset = "0x5434210", VA = "0x185435410")]
	public static void ILMEFAAGLOH(bool EFJKFNKFDIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5435390", Offset = "0x5434190", VA = "0x185435390")]
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
	[Cpp2IlInjected.Address(RVA = "0x54335F0", Offset = "0x54323F0", VA = "0x1854335F0")]
	public static int EAHJHDPFEFN(int DBMJEOKPFJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5433710", Offset = "0x5432510", VA = "0x185433710")]
	public static void ILMEFAAGLOH(bool EFJKFNKFDIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x54337B0", Offset = "0x54325B0", VA = "0x1854337B0")]
	private static void IOICFPBJEPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5433A00", Offset = "0x5432800", VA = "0x185433A00")]
	private static int KCCJOMEGCHO(Type NKICFHCCMMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5433690", Offset = "0x5432490", VA = "0x185433690")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public World EKGNNGCIOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1A0CBB0", Offset = "0x1A0B9B0", VA = "0x181A0CBB0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DFDDJEKPLDJ KAAPDHONNOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public global::IGNGPODGPHC<NOBHGMEMAKH> GGIKGBBCIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EE8E0", VA = "0x1806EFAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public global::IGNGPODGPHC<PGOOPFJKLFO> BGFKNONEECL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D370", VA = "0x18065E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x65E590", Offset = "0x65D390", VA = "0x18065E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public global::IGNGPODGPHC<BOLFBGCGJHF> DIBCAMGFHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x65E580", Offset = "0x65D380", VA = "0x18065E580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x65E5A0", Offset = "0x65D3A0", VA = "0x18065E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> ELOFBPOOINO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1BC3F20", Offset = "0x1BC2D20", VA = "0x181BC3F20")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5437910", Offset = "0x5436710", VA = "0x185437910")]
	public static PGLNEDJDCBK GACAKOPDIMA(string BEMAPDNKPAD, LBGCMANLNFC IDKBHBKJHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5437C70", Offset = "0x5436A70", VA = "0x185437C70")]
	public PGLNEDJDCBK(string BEMAPDNKPAD, LBGCMANLNFC IDKBHBKJHPJ = LBGCMANLNFC.Simulation, DEJCLABDFEB NJKJJANIDJB = DEJCLABDFEB.Default, bool EFJKFNKFDIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5437990", Offset = "0x5436790", VA = "0x185437990")]
	public ComponentSystemBase GHLFOJENCOJ(Type NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x30A0990", Offset = "0x309F790", VA = "0x1830A0990")]
	public T GHLFOJENCOJ<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5437450", Offset = "0x5436250", VA = "0x185437450")]
	public void DPHPIFPPBBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5437AA0", Offset = "0x54368A0", VA = "0x185437AA0")]
	public void HMDEEKCAALF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x54379B0", Offset = "0x54367B0", VA = "0x1854379B0")]
	public void HJAKNCCJKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5437580", Offset = "0x5436380", VA = "0x185437580")]
	public void FDNMIFDFHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5437520", Offset = "0x5436320", VA = "0x185437520")]
	public void ELBOOCHDDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5437C10", Offset = "0x5436A10", VA = "0x185437C10")]
	public void NIINGCCOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5437A10", Offset = "0x5436810", VA = "0x185437A10")]
	public void HLMHFKCAAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x54375E0", Offset = "0x54363E0", VA = "0x1854375E0")]
	public void FGBEMENNDNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x54373F0", Offset = "0x54361F0", VA = "0x1854373F0")]
	public void DLGKFBBKHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5437310", Offset = "0x5436110", VA = "0x185437310")]
	internal void DKIMDJBDIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5437290", Offset = "0x5436090", VA = "0x185437290")]
	private bool CGLLPKJLEJA(ComponentSystemGroup DEIPGHEFMEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5437640", Offset = "0x5436440", VA = "0x185437640")]
	private void FPJEBEBNEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5437B00", Offset = "0x5436900", VA = "0x185437B00")]
	private ComponentSystemGroup[] JKOOGAFMBEC(DEJCLABDFEB NJKJJANIDJB, bool BDGLGIDHPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x54374B0", Offset = "0x54362B0", VA = "0x1854374B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x678020", Offset = "0x676E20", VA = "0x180678020", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	protected JIGELGFIMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[DisableAutoCreation]
public sealed class BINCJPPOHMK : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public BINCJPPOHMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DisableAutoCreation]
public sealed class NGBOFDOMIKJ : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public NGBOFDOMIKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DisableAutoCreation]
public sealed class ILHIKHAIJNM : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public ILHIKHAIJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DisableAutoCreation]
public sealed class KAHDFHOCEMC : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public KAHDFHOCEMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DisableAutoCreation]
public sealed class FNPHKNFELIE : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public FNPHKNFELIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DisableAutoCreation]
public sealed class ANCFDIJGMDO : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public ANCFDIJGMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DisableAutoCreation]
public sealed class KIABADAKEGB : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public KIABADAKEGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DisableAutoCreation]
public sealed class HEEHHHHFPDD : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public HEEHHHHFPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DisableAutoCreation]
public sealed class MKELNEOKOJK : JIGELGFIMAD
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public MKELNEOKOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659B00", VA = "0x18065AD00", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public LKLKPHFEOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[AttributeUsage(AttributeTargets.Class)]
public class NAOJPPNIGOE : GNMMNAENLHM
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public HCCMGJPLKMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5433410", Offset = "0x5432210", VA = "0x185433410")]
	static ADAIGOIIEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016B10", VA = "0x182017D10")]
	public static void HOOBINPCHAM<T>(HPCFBKIFDLB<T, T> NHKDGEMAIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2017B60", Offset = "0x2016960", VA = "0x182017B60")]
	public static void HOOBINPCHAM<From, To>(HPCFBKIFDLB<From, To> NHKDGEMAIFP, HPCFBKIFDLB<To, From> EBGNBGLEENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2017B10", Offset = "0x2016910", VA = "0x182017B10")]
	public static void HOOBINPCHAM<From, To>(HPCFBKIFDLB<From, To> JMGBKPCMOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x201F080", Offset = "0x201DE80", VA = "0x18201F080")]
	public static HPCFBKIFDLB<From, To> MFFAHOPKPEH<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x201A6B0", Offset = "0x20194B0", VA = "0x18201A6B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2834DE0", Offset = "0x2833BE0", VA = "0x182834DE0")]
	public KLBODNIPMJE(NativeArray<EntityRemapUtility.EntityRemapInfo> AELKIPHCLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DE00", Offset = "0x2C2CC00", VA = "0x182C2DE00")]
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
	[Cpp2IlInjected.Address(RVA = "0x5434A60", Offset = "0x5433860", VA = "0x185434A60")]
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
			[Cpp2IlInjected.Address(RVA = "0x678050", Offset = "0x676E50", VA = "0x180678050")]
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
				[Cpp2IlInjected.Address(RVA = "0x5435C10", Offset = "0x5434A10", VA = "0x185435C10")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public long NEMNDPNMPOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x5435D30", Offset = "0x5434B30", VA = "0x185435D30")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5435C70", Offset = "0x5434A70", VA = "0x185435C70")]
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
				[Cpp2IlInjected.Address(RVA = "0x5435300", Offset = "0x5434100", VA = "0x185435300")]
				public unsafe IIGALELMLLI(Unity.Entities.Archetype* NPABAFANPLJ, NLPFCDLIDGG.BPMCLEPAMGO.CHIFPGAOFMF HJPOJJGNAHE, KLBODNIPMJE NGGOKHONBCG, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ, int CGIBPFOKKNL, int EFPAICPDPKD = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x54352B0", Offset = "0x54340B0", VA = "0x1854352B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x54346A0", Offset = "0x54334A0", VA = "0x1854346A0")]
			public DKCPJJLPNKB(IIGALELMLLI[] JJDMEICMPFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5434370", Offset = "0x5433170", VA = "0x185434370", Slot = "4")]
			public void Invoke(int AIPHGHFENPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x5433FC0", Offset = "0x5432DC0", VA = "0x185433FC0")]
			private void COCDBPIPMNJ(in IIGALELMLLI JANIFNADDOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x54343D0", Offset = "0x54331D0", VA = "0x1854343D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
			public NOFKMEDEIEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x5436AA0", Offset = "0x54358A0", VA = "0x185436AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
			public PEBAEMMCPJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x5437180", Offset = "0x5435F80", VA = "0x185437180")]
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
		[Cpp2IlInjected.Address(RVA = "0x543E9B0", Offset = "0x543D7B0", VA = "0x18543E9B0")]
		private unsafe static bool OGDFFIDIIFL(Unity.Entities.Archetype* CEINJAHAPJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x543C960", Offset = "0x543B760", VA = "0x18543C960")]
		internal unsafe static Unity.Entities.Archetype*[] FJIDPBEJPPE(ref Unity.Entities.EntityComponentStore APHBGABGANA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x543B850", Offset = "0x543A650", VA = "0x18543B850")]
		public static void CCMIFLHPNMM(PGLNEDJDCBK HADAJAKADAH, out ByteString OFOCCMMPKKL, out NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x543C230", Offset = "0x543B030", VA = "0x18543C230")]
		internal static void FHPNCIJKCAP(PGLNEDJDCBK HADAJAKADAH, NLPFCDLIDGG GEJKEHJBJMH, out NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x543E350", Offset = "0x543D150", VA = "0x18543E350")]
		private unsafe static UnsafeHashMap<ulong, OJBCBOJHFKO> LMLNIKEJBFM(Unity.Entities.Archetype*[] DBFCJKHGCAE)
		{
			return default(UnsafeHashMap<ulong, OJBCBOJHFKO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x543BFA0", Offset = "0x543ADA0", VA = "0x18543BFA0")]
		private static void DFFBCHHKNDD(NLPFCDLIDGG GEJKEHJBJMH, UnsafeHashMap<ulong, OJBCBOJHFKO> LKGJBJECNAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x543D6E0", Offset = "0x543C4E0", VA = "0x18543D6E0")]
		private unsafe static void JOKDFPBAOKJ(NLPFCDLIDGG GEJKEHJBJMH, Unity.Entities.Archetype*[] DBFCJKHGCAE, UnsafeHashMap<ulong, OJBCBOJHFKO> LKGJBJECNAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x543CB40", Offset = "0x543B940", VA = "0x18543CB40")]
		private unsafe static int GABADFBBDML(Unity.Entities.Archetype*[] DBFCJKHGCAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x543BB80", Offset = "0x543A980", VA = "0x18543BB80")]
		private unsafe static void COEFODJHPDP(NLPFCDLIDGG GEJKEHJBJMH, Unity.Entities.Archetype*[] DBFCJKHGCAE, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ, NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x543B910", Offset = "0x543A710", VA = "0x18543B910")]
		private static NativeArray<int> CJCGPIJGCJB(NLPFCDLIDGG GEJKEHJBJMH)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x543D350", Offset = "0x543C150", VA = "0x18543D350")]
		private static Memory<EntityArchetype> IPMOCFOFHCI(NLPFCDLIDGG GEJKEHJBJMH, NativeArray<int> DCPGKOEBMPG, EntityManager LKEHNCAJHHL, out int IELPCPEIDAC, out int CMIKPKFHPAA)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x543CBB0", Offset = "0x543B9B0", VA = "0x18543CBB0")]
		private unsafe static void GFCFEDEHPDH(Unity.Entities.Chunk* JPHCKLIEAMG, ReadOnlySpan<byte> OFOCCMMPKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x543B110", Offset = "0x5439F10", VA = "0x18543B110")]
		private static void BAMOFEBHOHH(NLPFCDLIDGG GEJKEHJBJMH, NativeArray<int> DCPGKOEBMPG, Span<EntityArchetype> DBFCJKHGCAE, EntityManager LKEHNCAJHHL, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x543E930", Offset = "0x543D730", VA = "0x18543E930")]
		private unsafe static void NHFNKOOIACO(Unity.Entities.Chunk* LJGMJGKCAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x543DA10", Offset = "0x543C810", VA = "0x18543DA10")]
		private unsafe static void KENDCPEFAMF(NLPFCDLIDGG.BPMCLEPAMGO.CHIFPGAOFMF NPABAFANPLJ, int OHEDCGDHPNL, int NMGKMENNNGH, Unity.Entities.Chunk* JPHCKLIEAMG, NLPFCDLIDGG GEJKEHJBJMH, NativeArray<int> DCPGKOEBMPG, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x543DD20", Offset = "0x543CB20", VA = "0x18543DD20")]
		public static void LLEPKDOKEFO(PGLNEDJDCBK HADAJAKADAH, in ByteString OFOCCMMPKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x543DDB0", Offset = "0x543CBB0", VA = "0x18543DDB0")]
		public static void LLEPKDOKEFO(EntityManager LKEHNCAJHHL, global::IGNGPODGPHC<PGOOPFJKLFO> NIGMPMDPOOJ, in ByteString OFOCCMMPKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x543CF00", Offset = "0x543BD00", VA = "0x18543CF00")]
		private static bool HEDLMKHPEJI(Type NKICFHCCMMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x543E5E0", Offset = "0x543D3E0", VA = "0x18543E5E0")]
		private static void MCOBDPCICHD(TypeManager.TypeInfo MPEMJAALAAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x543D1C0", Offset = "0x543BFC0", VA = "0x18543D1C0")]
		private unsafe static int HIONPCAIDOA(Unity.Entities.Archetype*[] DBFCJKHGCAE, NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x543C150", Offset = "0x543AF50", VA = "0x18543C150")]
		private static int EAHJHDPFEFN(int DBMJEOKPFJK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x543E890", Offset = "0x543D690", VA = "0x18543E890")]
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
	[Cpp2IlInjected.Address(RVA = "0x54361B0", Offset = "0x5434FB0", VA = "0x1854361B0")]
	private unsafe static Span<byte> AOGBBLNDHGC(Unity.Entities.Chunk* LJGMJGKCAEK, int CGIBPFOKKNL)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x254E350", Offset = "0x254D150", VA = "0x18254E350")]
	public unsafe static Span<T> OPNNLHAOCBN<T>(Unity.Entities.Chunk* LJGMJGKCAEK, int CGIBPFOKKNL)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x254E310", Offset = "0x254D110", VA = "0x18254E310")]
	public static Span<T> OPNNLHAOCBN<T>(this ref Unity.Entities.Chunk LJGMJGKCAEK, int CGIBPFOKKNL)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5436350", Offset = "0x5435150", VA = "0x185436350")]
	public unsafe static Span<Entity> CELBPOKAPAG(Unity.Entities.Chunk* LJGMJGKCAEK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x54363C0", Offset = "0x54351C0", VA = "0x1854363C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x543ED20", Offset = "0x543DB20", VA = "0x18543ED20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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

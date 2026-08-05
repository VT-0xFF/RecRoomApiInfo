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
internal static class MEJIEMPMKAN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x226B910", Offset = "0x226AB10", VA = "0x18226B910")]
	public static Span<Unity.Entities.ComponentTypeInArchetype> LDFGIPAMMOK(this ref Unity.Entities.Archetype ENFKEBIFHOI)
	{
		return default(Span<Unity.Entities.ComponentTypeInArchetype>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AINOABPFCCD
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x22681C0", Offset = "0x22673C0", VA = "0x1822681C0")]
	public static Span<int> GFJDNJILMPI(this EntityArchetype ENFKEBIFHOI)
	{
		return default(Span<int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EGCBFFMNPCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2269BB0", Offset = "0x2268DB0", VA = "0x182269BB0")]
	public static bool MJFCPIFHOGF(this Entity BBPBBOAPCHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NAAPBDNDKFC
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct GJOPEOPOEAF<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JMLCLEPFLHD : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public global::GJOPEOPOEAF<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7EA030", Offset = "0x7E9230", VA = "0x1807EA030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1E0BB50", Offset = "0x1E0AD50", VA = "0x181E0BB50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE94A80", Offset = "0xE93C80", VA = "0x180E94A80")]
		[DebuggerHidden]
		public JMLCLEPFLHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x44EB9A0", Offset = "0x44EABA0", VA = "0x1844EB9A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x44EBB50", Offset = "0x44EAD50", VA = "0x1844EBB50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Action<Protobuf> MIBBEOBEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MemoryStream MCLKJDJHIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CodedInputStream BJDBJOLPMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Protobuf HLELBFPFNEH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IPIKHFMIGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x610600", Offset = "0x60F800", VA = "0x180610600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x44E2690", Offset = "0x44E1890", VA = "0x1844E2690")]
	private GJOPEOPOEAF(byte[] MNCACBMIHMI, Action<Protobuf> MIBBEOBEFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x398B5F0", Offset = "0x398A7F0", VA = "0x18398B5F0")]
	public static global::GJOPEOPOEAF<Protobuf> CNOGLGNGFED<Data>(ReadOnlySpan<byte> DGNKACAAPPI, ReadOnlySpan<Data> EHBKMHADDAO, Action<Protobuf> MIBBEOBEFGA)
	{
		return default(global::GJOPEOPOEAF<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x44E24F0", Offset = "0x44E16F0", VA = "0x1844E24F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x44E2530", Offset = "0x44E1730", VA = "0x1844E2530", Slot = "4")]
	[IteratorStateMachine(typeof(global::GJOPEOPOEAF<>.JMLCLEPFLHD))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x44E2630", Offset = "0x44E1830", VA = "0x1844E2630", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LFCPEINOHOE<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly byte[] MNCACBMIHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly Protobuf HLELBFPFNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MemoryStream MCLKJDJHIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CodedOutputStream HDEEKIJIBGA;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xE8AA50", Offset = "0xE89C50", VA = "0x180E8AA50")]
	private LFCPEINOHOE(byte[] MNCACBMIHMI, in Protobuf HLELBFPFNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3CBA060", Offset = "0x3CB9260", VA = "0x183CBA060")]
	public static global::LFCPEINOHOE<Protobuf> CNOGLGNGFED<T>(ReadOnlySpan<T> EHBKMHADDAO)
	{
		return default(global::LFCPEINOHOE<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xE8A860", Offset = "0xE89A60", VA = "0x180E8A860")]
	public void CFFKPOGNOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xE8A9C0", Offset = "0xE89BC0", VA = "0x180E8A9C0")]
	public ByteString LPPBJNCKBIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xE8A890", Offset = "0xE89A90", VA = "0x180E8A890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct APHDKDKFBGJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MemoryStream MCLKJDJHIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CodedInputStream BJDBJOLPMBE;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2268230", Offset = "0x2267430", VA = "0x182268230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct CKJPPFAGCKA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly byte[] MNCACBMIHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MemoryStream MCLKJDJHIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CodedOutputStream HDEEKIJIBGA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2268960", Offset = "0x2267B60", VA = "0x182268960", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class NKAAPIHECCL : AKANPEPKPGH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Type CNKLGNBICFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE480", Offset = "0x6ED680", VA = "0x1806EE480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2269BD0", Offset = "0x2268DD0", VA = "0x182269BD0")]
	public NKAAPIHECCL(Type GOBGMPNFLNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PDPMFPOFILI : NKAAPIHECCL
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2269BD0", Offset = "0x2268DD0", VA = "0x182269BD0")]
	public PDPMFPOFILI(Type GOBGMPNFLNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MDBHOFLHDLD : NKAAPIHECCL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Type AIDKOMJJLDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x623BB0", Offset = "0x622DB0", VA = "0x180623BB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x226B8C0", Offset = "0x226AAC0", VA = "0x18226B8C0")]
	public MDBHOFLHDLD(Type EHGHLOEEKMD, Type GOBGMPNFLNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EHGELDODPME : NKAAPIHECCL
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2269BD0", Offset = "0x2268DD0", VA = "0x182269BD0")]
	public EHGELDODPME(Type GOBGMPNFLNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CMNCMGDNKIL : AKANPEPKPGH
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public CMNCMGDNKIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GOMOCALIPDK : AKANPEPKPGH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DLPFMOEFOIG JHBNPKJICHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62D550", Offset = "0x62C750", VA = "0x18062D550")]
		[CompilerGenerated]
		get
		{
			return default(DLPFMOEFOIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x226A7E0", Offset = "0x22699E0", VA = "0x18226A7E0")]
	public GOMOCALIPDK(DLPFMOEFOIG NKBIJCGCLBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
public class IOOAJLENKLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly EDJHMIKNCNB DDCODOIGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly EntityManager KHDMOGKDGKL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EDJHMIKNCNB IELCOFCMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x226B170", Offset = "0x226A370", VA = "0x18226B170")]
	public IOOAJLENKLJ(EDJHMIKNCNB DDCODOIGKNL, EntityManager KHDMOGKDGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x226B070", Offset = "0x226A270", VA = "0x18226B070")]
	public int AHMKCLNJANC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x46A08B0", Offset = "0x469FAB0", VA = "0x1846A08B0")]
	public bool FAJCMKBJNDO<T>(Entity BBPBBOAPCHN) where T : struct, JBFDMKKLKED
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x46A08F0", Offset = "0x469FAF0", VA = "0x1846A08F0")]
	public bool NPPIGCJJJJO<T>(Entity BBPBBOAPCHN, out T ADBNEBBHMOP) where T : struct, JBFDMKKLKED
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38547C0", Offset = "0x38539C0", VA = "0x1838547C0")]
	public T MKNHMOAFCGO<T>(Entity BBPBBOAPCHN) where T : struct, JBFDMKKLKED
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x44D9180", Offset = "0x44D8380", VA = "0x1844D9180")]
	private ComponentType NLOFCCCKEHI<T>() where T : struct, JBFDMKKLKED
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x226B0C0", Offset = "0x226A2C0", VA = "0x18226B0C0")]
	private ComponentType NLOFCCCKEHI(Type BGMCKNGNOJI)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class IOEKBOBEJBN
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	protected IOEKBOBEJBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class JNOGKBPMENK<View, Data> : JJHBGAMPJOH where View : struct, JBFDMKKLKED where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static ComponentType PJBJGKGDDNO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override Type HBLPJKEDJID
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2196180", Offset = "0x2195380", VA = "0x182196180", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override Type GJEHDNEMIPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2197280", Offset = "0x2196480", VA = "0x182197280", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override int NNOMDLOEMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2196AA0", Offset = "0x2195CA0", VA = "0x182196AA0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2196A20", Offset = "0x2195C20", VA = "0x182196A20")]
	public Data JLFECBEEBNM(Entity BBPBBOAPCHN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2195AC0", Offset = "0x2194CC0", VA = "0x182195AC0")]
	public Data CFJPOMPPLIC(Entity BBPBBOAPCHN)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected internal abstract View CHPIFPIGLOL(Entity BBPBBOAPCHN);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4AE3040", Offset = "0x4AE2240", VA = "0x184AE3040", Slot = "15")]
	protected internal override T CHPIFPIGLOL<T>(Entity BBPBBOAPCHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2195B40", Offset = "0x2194D40", VA = "0x182195B40", Slot = "16")]
	public override bool FAJCMKBJNDO(Entity BBPBBOAPCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xF36150", Offset = "0xF35350", VA = "0x180F36150")]
	protected JNOGKBPMENK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class JJHBGAMPJOH : PCMBKAMCBOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private ArchetypeChunkComponentTypeDynamic PEIFLOKALLB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EntityManager POMAKGKDHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6FD430", Offset = "0x6FC630", VA = "0x1806FD430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public abstract Type HBLPJKEDJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public abstract Type GJEHDNEMIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public abstract int NNOMDLOEMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private Type IHIEGGEFNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xBCC0C0", Offset = "0xBCB2C0", VA = "0x180BCC0C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int KCHIEEGIBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x226B1C0", Offset = "0x226A3C0", VA = "0x18226B1C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private PPDCFKFFIMN[] ONDFHDMIBIL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1C5F560", Offset = "0x1C5E760", VA = "0x181C5F560", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	protected internal virtual PPDCFKFFIMN[] APBOEKKLEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x226B230", Offset = "0x226A430", VA = "0x18226B230", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool COFPGFGHAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x226B2F0", Offset = "0x226A4F0", VA = "0x18226B2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x226B320", Offset = "0x226A520", VA = "0x18226B320")]
	public void MGEPLKAAEGI(EntityManager KHDMOGKDGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6330", Offset = "0x6D5530", VA = "0x1806D6330")]
	protected PCMBKAMCBOF JKDHNFCCDBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract T CHPIFPIGLOL<T>(Entity BBPBBOAPCHN) where T : struct, JBFDMKKLKED;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract bool FAJCMKBJNDO(Entity BBPBBOAPCHN);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x226B4B0", Offset = "0x226A6B0", VA = "0x18226B4B0", Slot = "8")]
	public (uint, uint) MNAKCCFMCMP(Entity BBPBBOAPCHN)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x226B580", Offset = "0x226A780", VA = "0x18226B580", Slot = "9")]
	public bool MNKAKGOLKII(Entity BBPBBOAPCHN, (uint order, uint change) BCHFMCCIDMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	protected JJHBGAMPJOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class NBJMAKBHHFG<Data> : MPONLINHFLA where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public virtual Data HPMHEACECHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xF352E0", Offset = "0xF344E0", VA = "0x180F352E0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7588B0", Offset = "0x757AB0", VA = "0x1807588B0", Slot = "8")]
	protected virtual bool FLONHJHCHLG(ReadOnlySpan<Data> EHBKMHADDAO, DKPOHEEMLHH KIPBEBBCCCB, out ReadOnlySpan<byte> DGNKACAAPPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "9")]
	protected virtual bool NELBOOBPPPJ(int BCHFMCCIDMH, Span<Data> EHBKMHADDAO, in ReadOnlySpan<byte> DGNKACAAPPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xF35320", Offset = "0xF34520", VA = "0x180F35320", Slot = "5")]
	internal sealed override bool FLONHJHCHLG(ref Unity.Entities.Chunk PDAFMJFPOLI, int PNFDOGEDGKK, DKPOHEEMLHH KIPBEBBCCCB, out ReadOnlySpan<byte> DGNKACAAPPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xF35C70", Offset = "0xF34E70", VA = "0x180F35C70", Slot = "6")]
	internal sealed override bool NELBOOBPPPJ(int BCHFMCCIDMH, ref Unity.Entities.Chunk PDAFMJFPOLI, int PNFDOGEDGKK, in ReadOnlySpan<byte> DGNKACAAPPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCE60", Offset = "0x3CBC060", VA = "0x183CBCE60")]
	protected global::LFCPEINOHOE<Protobuf> OJLILGKMODK<Protobuf>(ReadOnlySpan<Data> EHBKMHADDAO) where Protobuf : IMessage, new()
	{
		return default(global::LFCPEINOHOE<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3994A60", Offset = "0x3993C60", VA = "0x183994A60")]
	protected global::GJOPEOPOEAF<Protobuf> MIHHPIEIBLN<Protobuf>(ReadOnlySpan<byte> DGNKACAAPPI, ReadOnlySpan<Data> EHBKMHADDAO, Action<Protobuf> MIBBEOBEFGA) where Protobuf : IMessage, new()
	{
		return default(global::GJOPEOPOEAF<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xF36150", Offset = "0xF35350", VA = "0x180F36150")]
	protected NBJMAKBHHFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class MPONLINHFLA
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	protected internal abstract int IDFONEJIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x226BC00", Offset = "0x226AE00", VA = "0x18226BC00", Slot = "5")]
	internal virtual bool FLONHJHCHLG(ref Unity.Entities.Chunk PDAFMJFPOLI, int PNFDOGEDGKK, DKPOHEEMLHH KIPBEBBCCCB, out ReadOnlySpan<byte> DGNKACAAPPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "6")]
	internal virtual bool NELBOOBPPPJ(int BCHFMCCIDMH, ref Unity.Entities.Chunk PDAFMJFPOLI, int PNFDOGEDGKK, in ReadOnlySpan<byte> DGNKACAAPPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	protected MPONLINHFLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IIGMAOJOKLE
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[BurstCompile]
internal struct HGPDEJOIFMJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe Unity.Entities.EntityComponentStore* IJCJJELOABB;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x226A810", Offset = "0x2269A10", VA = "0x18226A810", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MPMLNCFKPMB
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLJKHHCPNAG(ArchetypeChunk PDAFMJFPOLI, int LKEMEKBOLNC, int LMGGHAGFMBJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class LGDDNACDHHM
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3D54E60", Offset = "0x3D54060", VA = "0x183D54E60")]
	public static void FIIMAKCILLB<T>(this ref T DPAIKCDDPBE, ref ArchetypeChunkIterator FIEIPDBMEMJ) where T : struct, MPMLNCFKPMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3D55030", Offset = "0x3D54230", VA = "0x183D55030")]
	public static void FIIMAKCILLB<T>(this ref T DPAIKCDDPBE, EntityQuery JJAAPBMAOBB) where T : struct, MPMLNCFKPMB
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MNCCKAKHFMA
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x226BA60", Offset = "0x226AC60", VA = "0x18226BA60")]
	public static bool PALKFJLBKHN(Type BGMCKNGNOJI, Type IEGNCHCBKLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal abstract class MPIOHOGDECC<Attribute, BaseClass> : global::NICKFMALGEO<BaseClass>, FAKGMCIHLJC where Attribute : NKAAPIHECCL
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly MKIMOBFPILG GPGEBBCKNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string JFLKGPEABBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<int, Type> BEPFFIPCGDH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1603410", Offset = "0x1602610", VA = "0x181603410")]
	public MPIOHOGDECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1602E80", Offset = "0x1602080", VA = "0x181602E80", Slot = "4")]
	public bool HIPEHFAIGLD(int NIDJEPOLHMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1602F50", Offset = "0x1602150", VA = "0x181602F50", Slot = "5")]
	public global::EGFHNBCKEKK<BaseClass> NBFDEEIPOGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x16032C0", Offset = "0x16024C0", VA = "0x1816032C0", Slot = "7")]
	protected virtual bool PALKFJLBKHN(Type BGMCKNGNOJI, int HPCCNFJCCEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1602DF0", Offset = "0x1601FF0", VA = "0x181602DF0", Slot = "8")]
	protected virtual int DJIJIPFIJCG(Type BGMCKNGNOJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1602EE0", Offset = "0x16020E0", VA = "0x181602EE0")]
	public void IGACKIBLPBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1603220", Offset = "0x1602420", VA = "0x181603220", Slot = "6")]
	public void NKCPCCNOLCN(Type BGMCKNGNOJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EGFHNBCKEKK<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<int, BaseClass> FPMCKPIAKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<Type, BaseClass> GNPFEHOCCKA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IEnumerable<BaseClass> HENPFAJALFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4663040", Offset = "0x4662240", VA = "0x184663040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4663560", Offset = "0x4662760", VA = "0x184663560")]
	public EGFHNBCKEKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x46633C0", Offset = "0x46625C0", VA = "0x1846633C0")]
	public EGFHNBCKEKK(int GOCCOAPEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x46632A0", Offset = "0x46624A0", VA = "0x1846632A0")]
	internal void KAGEPJABGKM(int NIDJEPOLHMB, BaseClass ELANOFHAKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x469E580", Offset = "0x469D780", VA = "0x18469E580")]
	public bool PMMNIEPBEDM<T>(out BaseClass ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4663320", Offset = "0x4662520", VA = "0x184663320")]
	public bool PMMNIEPBEDM(Type EPFBGGDPMCN, out BaseClass ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1E064A0", Offset = "0x1E056A0", VA = "0x181E064A0")]
	public bool CEDICGAPJAI(int NIDJEPOLHMB, out BaseClass ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x384A4E0", Offset = "0x38496E0", VA = "0x18384A4E0")]
	public T EHBDGCBKFFL<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4663270", Offset = "0x4662470", VA = "0x184663270")]
	public BaseClass EHBDGCBKFFL(Type MLJBFMLHFJH)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class DPDLGHNIGNN : global::MPIOHOGDECC<PDPMFPOFILI, IOEKBOBEJBN>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2268DB0", Offset = "0x2267FB0", VA = "0x182268DB0")]
	public DPDLGHNIGNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class JPIFIGPPCKJ : global::MPIOHOGDECC<MDBHOFLHDLD, JJHBGAMPJOH>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x226B620", Offset = "0x226A820", VA = "0x18226B620")]
	public JPIFIGPPCKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class ENBEJBHELEI : global::MPIOHOGDECC<EHGELDODPME, MPONLINHFLA>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2269C00", Offset = "0x2268E00", VA = "0x182269C00")]
	public ENBEJBHELEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct HOLFAEABGNG
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly MKIMOBFPILG GPGEBBCKNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Type> DGBCFCPCHGO;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8EF1D0", Offset = "0x8EE3D0", VA = "0x1808EF1D0")]
	private HOLFAEABGNG(List<Type> DGBCFCPCHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x226AB80", Offset = "0x2269D80", VA = "0x18226AB80")]
	public static void IGACKIBLPBJ(List<Type> DGBCFCPCHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x226A9E0", Offset = "0x2269BE0", VA = "0x18226A9E0")]
	private void EFMCPOJDMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x226AC90", Offset = "0x2269E90", VA = "0x18226AC90")]
	private bool PALKFJLBKHN(Type BGMCKNGNOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x226AC30", Offset = "0x2269E30", VA = "0x18226AC30")]
	private void IOAFLCDMGEH(Type BGMCKNGNOJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface NICKFMALGEO<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HIPEHFAIGLD(int NIDJEPOLHMB);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::EGFHNBCKEKK<BaseClass> NBFDEEIPOGP();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class MGFJEDJDOGN : SystemBase
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640")]
	protected MGFJEDJDOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class PAJLCNMKBFJ : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640")]
	protected PAJLCNMKBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class EPCNJOMJEHP : MGFJEDJDOGN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2269C60", Offset = "0x2268E60", VA = "0x182269C60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	protected void GAIBDEJGDCF(string GKALFAMOPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640")]
	protected EPCNJOMJEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[EJLOOKEAJML(HNJEFABFMIP.ComponentSystemTypes)]
	public static class RRDefaultWorldInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x226D2D0", Offset = "0x226C4D0", VA = "0x18226D2D0")]
		public static ComponentSystemGroup[] EBDOHCKJKPJ(World DDCODOIGKNL, NPHNDAGCMGK NNBIPBNDNJA = NPHNDAGCMGK.Default, bool OCMEMIPGOKC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x226DA60", Offset = "0x226CC60", VA = "0x18226DA60")]
		private static Type[] OPDDMJFJMFG(NPHNDAGCMGK NNBIPBNDNJA, bool OCMEMIPGOKC, ComponentSystemGroup[] BIAGIGOPDND, ComponentSystemGroup GACCIELPGJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x226D7C0", Offset = "0x226C9C0", VA = "0x18226D7C0")]
		private static ComponentSystemGroup[] OCABHCEJAFL(World DDCODOIGKNL, out ComponentSystemGroup GACCIELPGJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x226D3A0", Offset = "0x226C5A0", VA = "0x18226D3A0")]
		internal static bool EGKFEGJBBDJ(DLPFMOEFOIG NKBIJCGCLBL, out LMIAJPHNJEG JILOKIIGFNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x226D6F0", Offset = "0x226C8F0", VA = "0x18226D6F0")]
		private static ComponentSystemGroup NNFALFNBPOA(Type BGMCKNGNOJI, World DDCODOIGKNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x226D590", Offset = "0x226C790", VA = "0x18226D590")]
		private static ComponentSystemGroup[] HFAJIOJMAKC(Type[] DGBCFCPCHGO, World DDCODOIGKNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x226CE40", Offset = "0x226C040", VA = "0x18226CE40")]
		internal static void ABDHGHFECIP(World DDCODOIGKNL, Type[] BKJPEDPJHMK, ComponentSystemGroup[] BIAGIGOPDND, ComponentSystemGroup GACCIELPGJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x226D270", Offset = "0x226C470", VA = "0x18226D270")]
		internal static bool DCJAAHFCFNJ(ComponentSystemBase ENPNPHHDFHK, ComponentSystemGroup[] BIAGIGOPDND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x226D690", Offset = "0x226C890", VA = "0x18226D690")]
		private static void LKOHMNCMAHN(ComponentSystemGroup[] BIAGIGOPDND)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct EGPLLLMPNOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly Dictionary<Type, List<Type>> ICHNBNBEKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly HashSet<Type> HLDJHDFNBJL;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x826220", Offset = "0x825420", VA = "0x180826220")]
	public EGPLLLMPNOI(Dictionary<Type, List<Type>> ICHNBNBEKEP, HashSet<Type> HLDJHDFNBJL)
	{
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[EJLOOKEAJML(HNJEFABFMIP.ComponentSystemTypes)]
	public struct RRFilterWorldSystems
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class GEGBKMBGOBA : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x612CF0", Offset = "0x611EF0", VA = "0x180612CF0")]
			[DebuggerHidden]
			public GEGBKMBGOBA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x226A6E0", Offset = "0x22698E0", VA = "0x18226A6E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x226A430", Offset = "0x2269630", VA = "0x18226A430", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x226A790", Offset = "0x2269990", VA = "0x18226A790")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x226A690", Offset = "0x2269890", VA = "0x18226A690", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x226A5E0", Offset = "0x22697E0", VA = "0x18226A5E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x226A5E0", Offset = "0x22697E0", VA = "0x18226A5E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct KIKDLJFHMKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Dictionary<Type, List<Type>> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Queue<Type> queue;
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Type LJLMCNNBOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private NPHNDAGCMGK NNBIPBNDNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool AIEAJIOIOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool KOGNNHPKGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool OCMEMIPGOKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IEnumerable<Type> CJAONBMAOIP;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x226DEC0", Offset = "0x226D0C0", VA = "0x18226DEC0")]
		public static RRFilterWorldSystems CNOGLGNGFED()
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x226E930", Offset = "0x226DB30", VA = "0x18226E930")]
		public RRFilterWorldSystems JPKKIJMMFDN(NPHNDAGCMGK NKBIJCGCLBL)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x226E950", Offset = "0x226DB50", VA = "0x18226E950")]
		public RRFilterWorldSystems MIAMCIEIMDA(IEnumerable<Type> DGBCFCPCHGO)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x226E940", Offset = "0x226DB40", VA = "0x18226E940")]
		public RRFilterWorldSystems LMJHEGHHAJO(bool HNMAELGMEHD)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x226EB90", Offset = "0x226DD90", VA = "0x18226EB90")]
		public RRFilterWorldSystems PBNEPNOPAEP(bool HFPLLPBCFLN)
		{
			return default(RRFilterWorldSystems);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x226EB00", Offset = "0x226DD00", VA = "0x18226EB00")]
		public EGPLLLMPNOI NBBAJFHPEBM(Type[] ADECGAPFLHF)
		{
			return default(EGPLLLMPNOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x226E450", Offset = "0x226D650", VA = "0x18226E450")]
		[IteratorStateMachine(typeof(GEGBKMBGOBA))]
		internal IEnumerable<Type> IGCHBLJBCEK(IEnumerable<Type> DGBCFCPCHGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x226E4E0", Offset = "0x226D6E0", VA = "0x18226E4E0")]
		internal Dictionary<Type, List<Type>> JDIEEIGBHLJ(IEnumerable<Type> DGBCFCPCHGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x226DDE0", Offset = "0x226CFE0", VA = "0x18226DDE0")]
		private void ACBIKGACMGH(Dictionary<Type, List<Type>> DKJCFPOBMFD, Type BGMCKNGNOJI, Type OHKGANKGFDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226DB90", VA = "0x18226E990")]
		internal HashSet<Type> NAKLDOAKJHE(IEnumerable<Type> BIAGIGOPDND, Dictionary<Type, List<Type>> FIKJOBHDMCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x226DEF0", Offset = "0x226D0F0", VA = "0x18226DEF0")]
		internal bool EPFGGPEGAJM(Type BGMCKNGNOJI, NPHNDAGCMGK NNBIPBNDNJA, bool OCMEMIPGOKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x226E7F0", Offset = "0x226D9F0", VA = "0x18226E7F0")]
		[CompilerGenerated]
		internal static void JOLLIFHFIPC(Type BGMCKNGNOJI, ref KIKDLJFHMKH P_1)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class CLLLCIKHGCB
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static bool GNOJCCKGELD;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2268A90", Offset = "0x2267C90", VA = "0x182268A90")]
	public static void MGEPLKAAEGI(bool JCMDBKNCKJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2268AE0", Offset = "0x2267CE0", VA = "0x182268AE0")]
	private static void OONLAOGFNOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class DLPOANLEPGI
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2268CD0", Offset = "0x2267ED0", VA = "0x182268CD0")]
	public static ulong GNMHLNMNKIA(Type BGMCKNGNOJI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2268D00", Offset = "0x2267F00", VA = "0x182268D00")]
	public static ulong GNMHLNMNKIA(string HJNEPAPKMHO)
	{
		return default(ulong);
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[EJLOOKEAJML(HNJEFABFMIP.ComponentSystemTypes)]
	public static class RRTypeHashManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private struct KDFMEPOKOAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public readonly ulong DKBJJMFNDIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public readonly ulong HOEEBDBIJID;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA48E10", Offset = "0xA48010", VA = "0x180A48E10")]
			public KDFMEPOKOAH(ulong FBFBFDFJONJ, ulong IOOAIONEPOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x226B840", Offset = "0x226AA40", VA = "0x18226B840", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static Dictionary<ulong, int> BEHFDNOKCMG;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static KDFMEPOKOAH[] EKHFIFJPMFP;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static bool GNOJCCKGELD;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x226EF00", Offset = "0x226E100", VA = "0x18226EF00")]
		public static ulong JIPAIIGJJPD(int NIDJEPOLHMB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x226EE60", Offset = "0x226E060", VA = "0x18226EE60")]
		public static int JEOIMGMGIGK(ulong IOOAIONEPOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x226F3E0", Offset = "0x226E5E0", VA = "0x18226F3E0")]
		public static void MGEPLKAAEGI(bool JCMDBKNCKJK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x226EC50", Offset = "0x226DE50", VA = "0x18226EC50")]
		private static void CEKBAEBDAJP(int NLPCNFAHJPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x226EF60", Offset = "0x226E160", VA = "0x18226EF60")]
		private static void KLICJADOGJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x226F790", Offset = "0x226E990", VA = "0x18226F790")]
		private static KDFMEPOKOAH OLPFNLLCFCG(Type BGMCKNGNOJI)
		{
			return default(KDFMEPOKOAH);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x226EDF0", Offset = "0x226DFF0", VA = "0x18226EDF0")]
		private static ulong GDANHOBEMGE(Type BGMCKNGNOJI, ulong IOOAIONEPOK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x226F5A0", Offset = "0x226E7A0", VA = "0x18226F5A0")]
		private static void NFIOIHDGIFC(in KDFMEPOKOAH BKJNBLPCNFI, TypeManager.TypeInfo HEOHJADMHIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x226F2F0", Offset = "0x226E4F0", VA = "0x18226F2F0")]
		private static void LOEIFODLHOP(KDFMEPOKOAH HEOHJADMHIP, int NIDJEPOLHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x226ED10", Offset = "0x226DF10", VA = "0x18226ED10")]
		private static void EDBDENOEGKN(KDFMEPOKOAH HEOHJADMHIP, int NIDJEPOLHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x226F260", Offset = "0x226E460", VA = "0x18226F260")]
		private static KDFMEPOKOAH LAGIBCOEFNF(int NIDJEPOLHMB)
		{
			return default(KDFMEPOKOAH);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x226EC40", Offset = "0x226DE40", VA = "0x18226EC40")]
		private static int CAPFLBJBMPD(int NIDJEPOLHMB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class OELDPCHNBCF
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly JPIFIGPPCKJ DJIKOJAOCIO;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly ENBEJBHELEI OGBGJEHOLOE;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly DPDLGHNIGNN AJONDJPCKIG;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly List<Type> FMJEMBFFGJJ;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static bool GNOJCCKGELD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	internal static global::NICKFMALGEO<JJHBGAMPJOH> JGFDPNDFMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x226C5A0", Offset = "0x226B7A0", VA = "0x18226C5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal static global::NICKFMALGEO<MPONLINHFLA> JNGBLFCNMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x226C4E0", Offset = "0x226B6E0", VA = "0x18226C4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	internal static global::NICKFMALGEO<IOEKBOBEJBN> DHMFIOLBCDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x226C670", Offset = "0x226B870", VA = "0x18226C670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x226C6D0", Offset = "0x226B8D0", VA = "0x18226C6D0")]
	public static void MGEPLKAAEGI(bool JCMDBKNCKJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x226C600", Offset = "0x226B800", VA = "0x18226C600")]
	public static Type[] HENPBADJBJH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NBMNGEOFBNL
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly Dictionary<int, int> BLGNGLGMOPE;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool GNOJCCKGELD;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x226C380", Offset = "0x226B580", VA = "0x18226C380")]
	public static int MNAKCCFMCMP(int NIDJEPOLHMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x226C2E0", Offset = "0x226B4E0", VA = "0x18226C2E0")]
	public static void MGEPLKAAEGI(bool JCMDBKNCKJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x226C070", Offset = "0x226B270", VA = "0x18226C070")]
	private static void DHDEALJOPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x226C290", Offset = "0x226B490", VA = "0x18226C290")]
	private static int LFOJBBJDPAJ(Type BGMCKNGNOJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x226C410", Offset = "0x226B610", VA = "0x18226C410")]
	private static void NLALCDJNEAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class EDJHMIKNCNB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly World DDCODOIGKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly World JLFIKLKKIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IOOAJLENKLJ ELANOFHAKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly ComponentSystemGroup[] BIAGIGOPDND;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public World IELCOFCMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public World DCHGJMDAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EntityManager POMAKGKDHPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8FB600", Offset = "0x8FA800", VA = "0x1808FB600")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public IOOAJLENKLJ CIDDIKGGDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public global::EGFHNBCKEKK<JJHBGAMPJOH> JGFDPNDFMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x734270", Offset = "0x733470", VA = "0x180734270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7D6460", Offset = "0x7D5660", VA = "0x1807D6460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public global::EGFHNBCKEKK<MPONLINHFLA> JNGBLFCNMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FCDA0", Offset = "0x6FBFA0", VA = "0x1806FCDA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6FD080", Offset = "0x6FC280", VA = "0x1806FD080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public global::EGFHNBCKEKK<IOEKBOBEJBN> DHMFIOLBCDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF50", Offset = "0x5FA150", VA = "0x1805FAF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF60", Offset = "0x5FA160", VA = "0x1805FAF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> HIAJLBNENIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x18EFF70", Offset = "0x18EF170", VA = "0x1818EFF70")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2268E70", Offset = "0x2268070", VA = "0x182268E70")]
	public static EDJHMIKNCNB BIOBODJPOEP(string JFLKGPEABBP, DLPFMOEFOIG NKBIJCGCLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x22696E0", Offset = "0x22688E0", VA = "0x1822696E0")]
	public EDJHMIKNCNB(string JFLKGPEABBP, DLPFMOEFOIG NKBIJCGCLBL = DLPFMOEFOIG.Simulation, NPHNDAGCMGK NNBIPBNDNJA = NPHNDAGCMGK.Default, bool JCMDBKNCKJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2269210", Offset = "0x2268410", VA = "0x182269210")]
	public ComponentSystemBase KHBNNMEHOJO(Type BGMCKNGNOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x384A030", Offset = "0x3849230", VA = "0x18384A030")]
	public T KHBNNMEHOJO<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2269620", Offset = "0x2268820", VA = "0x182269620")]
	public void PBHLHKNKPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2269150", Offset = "0x2268350", VA = "0x182269150")]
	public void HHACLDBEAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2269320", Offset = "0x2268520", VA = "0x182269320")]
	public void NFNIPMBIJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2269680", Offset = "0x2268880", VA = "0x182269680")]
	public void PCKJAIDOILK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2269070", Offset = "0x2268270", VA = "0x182269070")]
	public void EPDILLFJAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x22690D0", Offset = "0x22682D0", VA = "0x1822690D0")]
	public void FNBABIKNEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2268E10", Offset = "0x2268010", VA = "0x182268E10")]
	public void AKGGGPHDKOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x22691B0", Offset = "0x22683B0", VA = "0x1822691B0")]
	public void JBCNABGOKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2269520", Offset = "0x2268720", VA = "0x182269520")]
	internal void OLFLGELIMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2269230", Offset = "0x2268430", VA = "0x182269230")]
	private bool KOECOCINFHG(ComponentSystemGroup CEHEJGDEHFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2269380", Offset = "0x2268580", VA = "0x182269380")]
	private void NNEONDLJLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2268F60", Offset = "0x2268160", VA = "0x182268F60")]
	private ComponentSystemGroup[] EBDOHCKJKPJ(NPHNDAGCMGK NNBIPBNDNJA, bool OCMEMIPGOKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x22692C0", Offset = "0x22684C0", VA = "0x1822692C0")]
	public void LKOFAGEBHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2268EF0", Offset = "0x22680F0", VA = "0x182268EF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
public enum DLPFMOEFOIG
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
public sealed class PPHHKCKMGIA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NPHNDAGCMGK HLPNHPJMEFK;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Flags]
public enum NPHNDAGCMGK
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
public interface LMIAJPHNJEG
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	Type CKAMBPMOPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Type[] MHOHLAFANOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class BGDAKALAANH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public virtual bool IHBHHFBKMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x601070", Offset = "0x600270", VA = "0x180601070", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	protected BGDAKALAANH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DisableAutoCreation]
public sealed class JMMMAGGBFMJ : BGDAKALAANH
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public JMMMAGGBFMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DisableAutoCreation]
public sealed class EKHHPOPCLJJ : BGDAKALAANH
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public EKHHPOPCLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DisableAutoCreation]
public sealed class FIPNLCKOIIN : BGDAKALAANH
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public FIPNLCKOIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DisableAutoCreation]
public sealed class AKEMGFKGCKJ : BGDAKALAANH
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public AKEMGFKGCKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DisableAutoCreation]
public sealed class MBOBDBBFLJF : BGDAKALAANH
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public MBOBDBBFLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DisableAutoCreation]
public sealed class KDIDCFHEIJF : BGDAKALAANH
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public override bool IHBHHFBKMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8726B0", Offset = "0x8718B0", VA = "0x1808726B0")]
	public KDIDCFHEIJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[AttributeUsage(AttributeTargets.Class)]
public class FJNEBDHFGAC : AKANPEPKPGH
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8708A0", Offset = "0x86FAA0", VA = "0x1808708A0")]
	public FJNEBDHFGAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JPJGLEAMBPE
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate void EHFIENFDHPN<From, To>(From JGKODHNKDPL, ref To MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class JLDPOAALGDJ<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static EHFIENFDHPN<From, To> MPCAEOCAOMP;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		public JLDPOAALGDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x226B680", Offset = "0x226A880", VA = "0x18226B680")]
	static JPJGLEAMBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3E14F00", Offset = "0x3E14100", VA = "0x183E14F00")]
	public static void IDNMOJHMPKG<T>(EHFIENFDHPN<T, T> DEJPHAILJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3E14F70", Offset = "0x3E14170", VA = "0x183E14F70")]
	public static void IDNMOJHMPKG<From, To>(EHFIENFDHPN<From, To> DEJPHAILJNK, EHFIENFDHPN<To, From> IPIAEEKBGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3D96390", Offset = "0x3D95590", VA = "0x183D96390")]
	public static void IDNMOJHMPKG<From, To>(EHFIENFDHPN<From, To> MPCAEOCAOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3CB74D0", Offset = "0x3CB66D0", VA = "0x183CB74D0")]
	public static EHFIENFDHPN<From, To> MINGNPMNKFJ<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3E16FD0", Offset = "0x3E161D0", VA = "0x183E16FD0")]
	public static void KKHKMDDMJOF<From, To>(From JGKODHNKDPL, ref To MPKGKJLGAII, DKPOHEEMLHH KIPBEBBCCCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class DKPOHEEMLHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> CFLGAILNLBP;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x858EA0", Offset = "0x8580A0", VA = "0x180858EA0")]
	public DKPOHEEMLHH(NativeArray<EntityRemapUtility.EntityRemapInfo> CFLGAILNLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public Entity GIBEDMJLPFP(Entity FKKKHANKMEH)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class CADFCMKIKHI
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Dictionary<(ulong hash, uint version), string> KLPPGLHGBAC;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2268270", Offset = "0x2267470", VA = "0x182268270")]
	public static bool GCCDIGFAJLA(ulong HGCLPJPLDLN, uint BCHFMCCIDMH, out string JFLKGPEABBP)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[EJLOOKEAJML(HNJEFABFMIP.Serialization, new string[] { "Timing", "Deprecated", "Types", "Archetypes" })]
	public static class SerializeUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private struct BBCNMKPFPBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int CCIFACONDAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int IDFONEJIHAP;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x884C10", Offset = "0x883E10", VA = "0x180884C10")]
			public BBCNMKPFPBJ(int MJNAIOAAGCG, int BCHFMCCIDMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct OKCCEBMJEHC
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private static Stopwatch PKCGGAGOMBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private long FDDAKBIEHMO;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public long BKBOMMJBDFM
			{
				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x226CCC0", Offset = "0x226BEC0", VA = "0x18226CCC0")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public long HMGPECEPINN
			{
				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x226CD10", Offset = "0x226BF10", VA = "0x18226CD10")]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x226CD80", Offset = "0x226BF80", VA = "0x18226CD80")]
			public static OKCCEBMJEHC LPCFCGJIHMB()
			{
				return default(OKCCEBMJEHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private struct FEGHHLLMJKD : IAction
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public readonly struct CCBLFKDIBEG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public unsafe readonly Unity.Entities.Archetype* LFFOGMMEDHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public readonly GNIEJANADKO.MFHPHGDOBAP.NIPGPHFGKCL LJGCBHHPBGF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public readonly DKPOHEEMLHH KIPBEBBCCCB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000079")]
				public readonly global::EGFHNBCKEKK<MPONLINHFLA> FBDLHHKBFLN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public readonly int PNFDOGEDGKK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public readonly int LKEMEKBOLNC;

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x22688B0", Offset = "0x2267AB0", VA = "0x1822688B0")]
				public unsafe CCBLFKDIBEG(Unity.Entities.Archetype* LFFOGMMEDHB, GNIEJANADKO.MFHPHGDOBAP.NIPGPHFGKCL LJGCBHHPBGF, DKPOHEEMLHH KIPBEBBCCCB, global::EGFHNBCKEKK<MPONLINHFLA> FBDLHHKBFLN, int PNFDOGEDGKK, int LKEMEKBOLNC = -1)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x2268910", Offset = "0x2267B10", VA = "0x182268910")]
				public CCBLFKDIBEG(in CCBLFKDIBEG ADIGGFBANFM, int LKEMEKBOLNC)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public readonly CCBLFKDIBEG[] EHBKMHADDAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public string[] ANIACGNJMFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int MLABLALDMJC;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x226A2F0", Offset = "0x22694F0", VA = "0x18226A2F0")]
			public FEGHHLLMJKD(CCBLFKDIBEG[] EHBKMHADDAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x2269C90", Offset = "0x2268E90", VA = "0x182269C90", Slot = "4")]
			public void Invoke(int MJNAIOAAGCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2269F90", Offset = "0x2269190", VA = "0x182269F90")]
			private void NHFLCBMGKBJ(in CCBLFKDIBEG ADIGGFBANFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2269CF0", Offset = "0x2268EF0", VA = "0x182269CF0")]
			private static void JLNFMGLJEBK(in CCBLFKDIBEG ADIGGFBANFM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class CMBJHNEIPOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public GNIEJANADKO asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public NativeArray<int> types;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public global::EGFHNBCKEKK<MPONLINHFLA> serializers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public List<Action> tasks;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public CMBJHNEIPOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2268C60", Offset = "0x2267E60", VA = "0x182268C60")]
			internal void <ReadComponents>b__0(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class GOAHIGOFKGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public GNIEJANADKO.MFHPHGDOBAP.NIPGPHFGKCL srcArch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public int archetypeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public CMBJHNEIPOH CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public GOAHIGOFKGD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class HKLNJKHKJGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public int chunkIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public unsafe Unity.Entities.Chunk* dstChunk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public GOAHIGOFKGD CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public HKLNJKHKJGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x226A8C0", Offset = "0x2269AC0", VA = "0x18226A8C0")]
			internal void <ReadComponents>b__1()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static MKIMOBFPILG GPGEBBCKNMO;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static MKIMOBFPILG BEJEBKGLHGP;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static MKIMOBFPILG KFOBNMOEAOL;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static MKIMOBFPILG FPIJBFNBHAJ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static MKIMOBFPILG ECOGNPDGHBB;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static bool FMKHMIJFHNH;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static GNIEJANADKO.MFHPHGDOBAP.PNGLHPLOKOH IIBALCFGFHF;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x22728C0", Offset = "0x2271AC0", VA = "0x1822728C0")]
		private unsafe static bool NAGJEBABPEJ(Unity.Entities.Archetype* ENFKEBIFHOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2271B20", Offset = "0x2270D20", VA = "0x182271B20")]
		internal unsafe static Unity.Entities.Archetype*[] IJFPMHBDLEA(ref Unity.Entities.EntityComponentStore IJCJJELOABB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2270D90", Offset = "0x226FF90", VA = "0x182270D90")]
		public static void EMDJPPJOMJI(EDJHMIKNCNB DDCODOIGKNL, out ByteString DGNKACAAPPI, out NativeArray<EntityRemapUtility.EntityRemapInfo> FOGIAJLHPPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x226FFB0", Offset = "0x226F1B0", VA = "0x18226FFB0")]
		internal static void CAMCLFLPBJN(EDJHMIKNCNB DDCODOIGKNL, GNIEJANADKO JIIDDCOLBMC, out NativeArray<EntityRemapUtility.EntityRemapInfo> FOGIAJLHPPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x226F8F0", Offset = "0x226EAF0", VA = "0x18226F8F0")]
		private unsafe static UnsafeHashMap<ulong, BBCNMKPFPBJ> ANNHOGMKDJP(Unity.Entities.Archetype*[] BKEABNOCPPC)
		{
			return default(UnsafeHashMap<ulong, BBCNMKPFPBJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x226FB50", Offset = "0x226ED50", VA = "0x18226FB50")]
		private static void AONJAAFNODF(GNIEJANADKO JIIDDCOLBMC, UnsafeHashMap<ulong, BBCNMKPFPBJ> MOMALMEPCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2270AD0", Offset = "0x226FCD0", VA = "0x182270AD0")]
		private unsafe static void EFFMHFOCFIF(GNIEJANADKO JIIDDCOLBMC, Unity.Entities.Archetype*[] BKEABNOCPPC, UnsafeHashMap<ulong, BBCNMKPFPBJ> MOMALMEPCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2271F10", Offset = "0x2271110", VA = "0x182271F10")]
		private unsafe static int JNMHLFEJIMM(Unity.Entities.Archetype*[] BKEABNOCPPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2271720", Offset = "0x2270920", VA = "0x182271720")]
		private unsafe static void GHJFDOJGFPO(GNIEJANADKO JIIDDCOLBMC, Unity.Entities.Archetype*[] BKEABNOCPPC, global::EGFHNBCKEKK<MPONLINHFLA> FBDLHHKBFLN, NativeArray<EntityRemapUtility.EntityRemapInfo> FOGIAJLHPPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x22708B0", Offset = "0x226FAB0", VA = "0x1822708B0")]
		private static NativeArray<int> EBCPOPGHBMK(GNIEJANADKO JIIDDCOLBMC)
		{
			return default(NativeArray<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x22729B0", Offset = "0x2271BB0", VA = "0x1822729B0")]
		private static Memory<EntityArchetype> OIFKAJBKFKI(GNIEJANADKO JIIDDCOLBMC, NativeArray<int> DGBCFCPCHGO, EntityManager KHDMOGKDGKL, out int GEAKCNHBECK, out int OPGMLFDCPGD)
		{
			return default(Memory<EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x226FCE0", Offset = "0x226EEE0", VA = "0x18226FCE0")]
		private unsafe static void AOPJFEGEFDA(Unity.Entities.Chunk* LOCIBFAMFOK, ReadOnlySpan<byte> DGNKACAAPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2272130", Offset = "0x2271330", VA = "0x182272130")]
		private static void MKFHLBHADEF(GNIEJANADKO JIIDDCOLBMC, NativeArray<int> DGBCFCPCHGO, Span<EntityArchetype> BKEABNOCPPC, EntityManager KHDMOGKDGKL, global::EGFHNBCKEKK<MPONLINHFLA> FBDLHHKBFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2270E40", Offset = "0x2270040", VA = "0x182270E40")]
		private unsafe static void FCLDOMIMPCN(Unity.Entities.Chunk* PDAFMJFPOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2270EC0", Offset = "0x22700C0", VA = "0x182270EC0")]
		private unsafe static void FENGKADNILJ(GNIEJANADKO.MFHPHGDOBAP.NIPGPHFGKCL LFFOGMMEDHB, int GFLMAGNMKAG, int JJOEAHBMLCI, Unity.Entities.Chunk* LOCIBFAMFOK, GNIEJANADKO JIIDDCOLBMC, NativeArray<int> DGBCFCPCHGO, global::EGFHNBCKEKK<MPONLINHFLA> FBDLHHKBFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2271190", Offset = "0x2270390", VA = "0x182271190")]
		public static void FONJGJHGEEG(EDJHMIKNCNB DDCODOIGKNL, in ByteString DGNKACAAPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2271220", Offset = "0x2270420", VA = "0x182271220")]
		public static void FONJGJHGEEG(EntityManager KHDMOGKDGKL, global::EGFHNBCKEKK<MPONLINHFLA> FBDLHHKBFLN, in ByteString DGNKACAAPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2272CE0", Offset = "0x2271EE0", VA = "0x182272CE0")]
		private static bool ONNHJONDILN(Type BGMCKNGNOJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2271F80", Offset = "0x2271180", VA = "0x182271F80")]
		private static void KNBPGOJNFPL(TypeManager.TypeInfo HEOHJADMHIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2271CD0", Offset = "0x2270ED0", VA = "0x182271CD0")]
		private unsafe static int JBOEFLIBKMK(Unity.Entities.Archetype*[] BKEABNOCPPC, NativeArray<EntityRemapUtility.EntityRemapInfo> FOGIAJLHPPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x22727E0", Offset = "0x22719E0", VA = "0x1822727E0")]
		private static int MNAKCCFMCMP(int NIDJEPOLHMB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2271E70", Offset = "0x2271070", VA = "0x182271E70")]
		private static ulong JIPAIIGJJPD(int NIDJEPOLHMB)
		{
			return default(ulong);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class CBBKNMJIDAL
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2268400", Offset = "0x2267600", VA = "0x182268400")]
	private unsafe static Span<byte> CHBDOGKNHOG(Unity.Entities.Chunk* PDAFMJFPOLI, int PNFDOGEDGKK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x44423E0", Offset = "0x44415E0", VA = "0x1844423E0")]
	public unsafe static Span<T> IPLGHDJAAHJ<T>(Unity.Entities.Chunk* PDAFMJFPOLI, int PNFDOGEDGKK)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4442350", Offset = "0x4441550", VA = "0x184442350")]
	public static Span<T> IPLGHDJAAHJ<T>(this ref Unity.Entities.Chunk PDAFMJFPOLI, int PNFDOGEDGKK)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2268850", Offset = "0x2267A50", VA = "0x182268850")]
	public unsafe static Span<Entity> PFKKOOEKOPO(Unity.Entities.Chunk* PDAFMJFPOLI)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x22685A0", Offset = "0x22677A0", VA = "0x1822685A0")]
	public unsafe static void NLALCDJNEAF(Unity.Entities.Chunk* PDAFMJFPOLI, int PNFDOGEDGKK)
	{
	}
}
namespace RecRoom.ObjectModel.Entities.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[Preserve]
	internal class _RRAssemblyIndex : BIJDGJCEPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x22733F0", Offset = "0x22725F0", VA = "0x1822733F0", Slot = "4")]
		public sealed override void IGACKIBLPBJ()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class INAFFMAFPID
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static byte[] JIMOKIHBHOH;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int FMDPFNLECKI;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static int AONCPEEEHKG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static BigInteger ILKJFGLFAMB;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INAFFMAFPID()
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
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
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

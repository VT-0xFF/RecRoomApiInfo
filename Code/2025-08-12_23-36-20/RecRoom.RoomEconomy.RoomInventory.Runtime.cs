using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RoomEconomy_RoomInventory_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8BDF0B0", Offset = "0x8BDDEB0", VA = "0x188BDF0B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DJOLMOLDIHF : LMIHLDGOBGN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PFKEFCPGHOL HBMPPEHIKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class NBEGPDINBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, PGINKKACHGB> FIPHPCKOOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, PGINKKACHGB> ILNJCFDNKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? DGNEFNFILLD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long PCLKEPGGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA98AC0", Offset = "0xA978C0", VA = "0x180A98AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PGINKKACHGB ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4050", Offset = "0x8BD2E50", VA = "0x188BD4050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8BD4430", Offset = "0x8BD3230", VA = "0x188BD4430")]
	public void GLIIHCMJEBC(long MDNJLMOPJKG, IEnumerable<GFMIADJGPJH> ECFKPCKAHAM, IEnumerable<GLJJEPBELIM> BHLCFIOIDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8BD52F0", Offset = "0x8BD40F0", VA = "0x188BD52F0")]
	public bool NGBLENLIPOM(Guid ENEOEDNPCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8BD4E50", Offset = "0x8BD3C50", VA = "0x188BD4E50")]
	public bool MDNHCHGJFLC(Guid ENEOEDNPCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8BD4E70", Offset = "0x8BD3C70", VA = "0x188BD4E70")]
	public bool MFDEDMAMDPL(GFMIADJGPJH NNODIPGBMLN, [Out] GFMIADJGPJH BPNOPJAAJLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8BD4C90", Offset = "0x8BD3A90", VA = "0x188BD4C90")]
	public IEnumerable<PGINKKACHGB> JJKLEMMAKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8BD42B0", Offset = "0x8BD30B0", VA = "0x188BD42B0")]
	public IEnumerable<GFMIADJGPJH> EIKHFFHBJPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8BD5350", Offset = "0x8BD4150", VA = "0x188BD5350")]
	public IEnumerable<GLJJEPBELIM> NKPPDHGICMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8BD40B0", Offset = "0x8BD2EB0", VA = "0x188BD40B0")]
	public bool APNDBPJHDAJ(Guid ENEOEDNPCBA, [Out] GFMIADJGPJH EJNEHIPFOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8BD4160", Offset = "0x8BD2F60", VA = "0x188BD4160")]
	public bool DFDMPGAMIBF(string KJBHFOFKJCH, [Out] GFMIADJGPJH EJNEHIPFOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8BD4200", Offset = "0x8BD3000", VA = "0x188BD4200")]
	public bool EEBNJFLHBNO(Guid ENEOEDNPCBA, [Out] GLJJEPBELIM PIGPNPJKFBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8BD56E0", Offset = "0x8BD44E0", VA = "0x188BD56E0")]
	public bool PAHEAAOBENG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8BD4DD0", Offset = "0x8BD3BD0", VA = "0x188BD4DD0")]
	private bool KCKGHAJIAFC(GFMIADJGPJH GNOMIJMEGAG, GFMIADJGPJH FIBPLJJCBHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8BD5490", Offset = "0x8BD4290", VA = "0x188BD5490")]
	private void OCEDPEAIJKB(Guid JJJJBEGKNIN, PGINKKACHGB ILGNDHJIPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8BD50A0", Offset = "0x8BD3EA0", VA = "0x188BD50A0")]
	private bool MFLFIIOLKNJ(Guid JJJJBEGKNIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8BD4CE0", Offset = "0x8BD3AE0", VA = "0x188BD4CE0")]
	private void KCKAJBDCELH(GFMIADJGPJH CFKEAJNHDJA, [Optional] GFMIADJGPJH KNAKBBMIPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8BD4AB0", Offset = "0x8BD38B0", VA = "0x188BD4AB0")]
	private bool HMFGKMENIGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8BD43F0", Offset = "0x8BD31F0", VA = "0x188BD43F0")]
	private static bool GLHEOKHANDA(GFMIADJGPJH IIHDHELGAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8BD5780", Offset = "0x8BD4580", VA = "0x188BD5780")]
	public NBEGPDINBKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PFKEFCPGHOL : JJGOLLENIHA, KCDGNBKAIKC, IDisposable, PCOBGDPJCFP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct HOPCAFJNJMG : IEquatable<HOPCAFJNJMG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long PCLKEPGGEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid JLKNCFMDCON;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x56651E0", Offset = "0x5663FE0", VA = "0x1856651E0")]
		public HOPCAFJNJMG(long MDNJLMOPJKG, Guid ENEOEDNPCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD05F0", Offset = "0x8BCF3F0", VA = "0x188BD05F0", Slot = "4")]
		public bool Equals(HOPCAFJNJMG FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0490", Offset = "0x8BCF290", VA = "0x188BD0490", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD06F0", Offset = "0x8BCF4F0", VA = "0x188BD06F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct NKGIMAALFAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<GFMIADJGPJH, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public RoomInventoryItemProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Guid? originId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte shape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<long> tagIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public List<OBBMAADMKFG> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<NMBCNJBJCJP<MMCGJDDLPCD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD58A0", Offset = "0x8BD46A0", VA = "0x188BD58A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD5DB0", Offset = "0x8BD4BB0", VA = "0x188BD5DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct DENJPLLKOHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<GFMIADJGPJH, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Dictionary<string, RoomInventoryTagClientProperties> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public RoomInventoryItemProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public List<long> tagIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public byte? shape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int? color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<NMBCNJBJCJP<MMCGJDDLPCD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCCDA0", Offset = "0x8BCBBA0", VA = "0x188BCCDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD5F0", Offset = "0x8BCC3F0", VA = "0x188BCD5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CBEMKEEDILO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private GFMIADJGPJH <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private KNPLFMAGNCA <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<KNPLFMAGNCA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB600", Offset = "0x8BCA400", VA = "0x188BCB600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBE10", Offset = "0x8BCAC10", VA = "0x188BCBE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct LCOCPLMPJFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AFLCFHLHEHB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1030", Offset = "0x8BCFE30", VA = "0x188BD1030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD13B0", Offset = "0x8BD01B0", VA = "0x188BD13B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OOKMAAMIPIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<MJLGILJJFNN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AFLCFHLHEHB recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<MJLGILJJFNN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD5E20", Offset = "0x8BD4C20", VA = "0x188BD5E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD6280", Offset = "0x8BD5080", VA = "0x188BD6280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DCKEKECPPEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<POJMEDGDKKM, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private POJMEDGDKKM <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC8B0", Offset = "0x8BCB6B0", VA = "0x188BCC8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8BCCD30", Offset = "0x8BCBB30", VA = "0x188BCCD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct DOJNOJECMAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<POJMEDGDKKM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<GECIHKBMECG<POJMEDGDKKM, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<KNPLFMAGNCA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8BCDD50", Offset = "0x8BCCB50", VA = "0x188BCDD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE960", Offset = "0x8BCD760", VA = "0x188BCE960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MIIGHIONGFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<KNPLFMAGNCA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3AC0", Offset = "0x8BD28C0", VA = "0x188BD3AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3FE0", Offset = "0x8BD2DE0", VA = "0x188BD3FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CEPMMPHHFGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, OBBMAADMKFG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<NMBCNJBJCJP<List<OBBMAADMKFG>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBE80", Offset = "0x8BCAC80", VA = "0x188BCBE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC840", Offset = "0x8BCB640", VA = "0x188BCC840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct NJCCNJGNMKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public GLJJEPBELIM playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct LNCLFHLLLIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<MJLGILJJFNN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private NJCCNJGNMKO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AFLCFHLHEHB awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<NPODIONALLL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1420", Offset = "0x8BD0220", VA = "0x188BD1420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1870", Offset = "0x8BD0670", VA = "0x188BD1870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct APFOCJDNHMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<HOPCAFJNJMG, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class ILPOIFAJOMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public NPODIONALLL result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ILPOIFAJOMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0FC0", Offset = "0x8BCFDC0", VA = "0x188BD0FC0")]
		internal HGDPGPPAEEI DCEAEKBOHAL(HOPCAFJNJMG id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct HHCBBLFBAEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<HOPCAFJNJMG, HGDPGPPAEEI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<HOPCAFJNJMG, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private APFOCJDNHMD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<HGDPGPPAEEI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF970", Offset = "0x8BCE770", VA = "0x188BCF970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0420", Offset = "0x8BCF220", VA = "0x188BD0420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct MCFKGABALMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<HGDPGPPAEEI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<HOPCAFJNJMG, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<HGDPGPPAEEI> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<HGDPGPPAEEI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2AF0", Offset = "0x8BD18F0", VA = "0x188BD2AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3A50", Offset = "0x8BD2850", VA = "0x188BD3A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PIDFBENOKPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<MMCGJDDLPCD>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<COAABHJIMMF>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<OBBMAADMKFG>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<LJJLEGAKDGN> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<GFMIADJGPJH> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<GLJJEPBELIM> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<POJMEDGDKKM> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<MMCGJDDLPCD>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<COAABHJIMMF>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<OBBMAADMKFG>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<LJJLEGAKDGN> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BDDBC0", Offset = "0x8BDC9C0", VA = "0x188BDDBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BDEDF0", Offset = "0x8BDDBF0", VA = "0x188BDEDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct DJKNJIIKOJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD660", Offset = "0x8BCC460", VA = "0x188BCD660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BCDCF0", Offset = "0x8BCCAF0", VA = "0x188BCDCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct IENNPFFNOBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AFLCFHLHEHB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0A50", Offset = "0x8BCF850", VA = "0x188BD0A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0F50", Offset = "0x8BCFD50", VA = "0x188BD0F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FDJHDLBIMGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<MJLGILJJFNN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AFLCFHLHEHB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<MJLGILJJFNN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE9D0", Offset = "0x8BCD7D0", VA = "0x188BCE9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEEF0", Offset = "0x8BCDCF0", VA = "0x188BCEEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct FLEEPDMHJKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public GFMIADJGPJH itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public PFKEFCPGHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<GECIHKBMECG<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEF60", Offset = "0x8BCDD60", VA = "0x188BCEF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF910", Offset = "0x8BCE710", VA = "0x188BCF910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan OMIKGNKLHHC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float OMKGHJIMHMO = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float HLKMCABHEDA = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int HMIFGPICNIF = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string DMDDJPDBBDH = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string GJMHBNAGOIF = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GHPHFNDNBAG GJBPFAIDCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DEAMLDNHCBH KOKKEEOLOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly ALMBKNLAGNO PFFEKMNEKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly ALDABFJJHPA PEMLCPKPDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KCDOBEOKNFA JBGDKEJCOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly DJOLMOLDIHF GKAMOCFNHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HCNPPOOIDEE PCFBHCOALKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CALKCCHENJG HJMBBEBBHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly HDLCKCHLJPK NLDCIFBADID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly NBEGPDINBKN LICMGCFNDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LPMPFCDKIOL BMCCBMEOPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly NDGMOLILNBN BLIOJJCNEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource HPEEPHFKMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly NBHGHIGJPON<HOPCAFJNJMG, HGDPGPPAEEI> GBKMLLCHHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NBHGHIGJPON<long, OBBMAADMKFG> OJMAHJGIGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LJPHCNLDGIM KLAHBKJOFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable JPKGBGIAJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task APOOCEPBKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource PGNLLMJGBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long GBMNAKJPELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool JAABGCKHGLN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private OAHJJJLMEEF AGDANODEHFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD76B0", Offset = "0x8BD64B0", VA = "0x188BD76B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MKAEDPHCCBC BACNDHPCMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xEB9C60", Offset = "0xEB8A60", VA = "0x180EB9C60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xEB9C70", Offset = "0xEB8A70", VA = "0x180EB9C70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GBCEOPMAPJH<GFMIADJGPJH> GCHPIFLDKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB63180", Offset = "0xB61F80", VA = "0x180B63180", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB8DFE0", Offset = "0xB8CDE0", VA = "0x180B8DFE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GBCEOPMAPJH<Guid> LACDFBICGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB63620", Offset = "0xB62420", VA = "0x180B63620", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB635C0", Offset = "0xB623C0", VA = "0x180B635C0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FLNBPEKPFIH<GLJJEPBELIM, int> KKBBEPDFEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB23990", Offset = "0xB22790", VA = "0x180B23990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB26F70", Offset = "0xB25D70", VA = "0x180B26F70", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GBCEOPMAPJH<POJMEDGDKKM> JILGHNCANDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAA30F0", Offset = "0xAA1EF0", VA = "0x180AA30F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAA30D0", Offset = "0xAA1ED0", VA = "0x180AA30D0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GBCEOPMAPJH<long> IADIKFDFPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xB275F0", Offset = "0xB263F0", VA = "0x180B275F0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xB26920", Offset = "0xB25720", VA = "0x180B26920", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MKAEDPHCCBC JDNMFKCHDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB275E0", Offset = "0xB263E0", VA = "0x180B275E0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB268D0", Offset = "0xB256D0", VA = "0x180B268D0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MKAEDPHCCBC GNBPOMIJANP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xB21D60", Offset = "0xB20B60", VA = "0x180B21D60", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB21FA0", Offset = "0xB20DA0", VA = "0x180B21FA0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7250", Offset = "0x8BD6050", VA = "0x188BD7250")]
	[NKOKDPHOKEP.EPFIDDHPHJC.MBGBOEIIBBL]
	internal static void DBCFEKMBJDE(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8BDD040", Offset = "0x8BDBE40", VA = "0x188BDD040")]
	[RecRoom.NoEngine.Common.Preserve]
	public PFKEFCPGHOL([POMNKOCGGBN(null)] GHPHFNDNBAG GJBPFAIDCJE, [POMNKOCGGBN(null)] DEAMLDNHCBH KOKKEEOLOCP, [POMNKOCGGBN(null)] ALMBKNLAGNO PFFEKMNEKHM, [POMNKOCGGBN(null)] ALDABFJJHPA PEMLCPKPDLB, [POMNKOCGGBN(null)] NFGFJOGJHBJ IMHHOFCJJBO, [POMNKOCGGBN(null)] KCDOBEOKNFA JBGDKEJCOFK, [POMNKOCGGBN(null)] DJOLMOLDIHF GKAMOCFNHCI, [POMNKOCGGBN(null)] IJPADAEDIMJ KLOFCILPHMC, [POMNKOCGGBN(null)] BNNEKKBOOPI PNJCOJLLHGH, [POMNKOCGGBN(null)] HCNPPOOIDEE PCFBHCOALKL, [POMNKOCGGBN(null)] CALKCCHENJG HJMBBEBBHKA, [POMNKOCGGBN(null)] HDLCKCHLJPK NLDCIFBADID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7ED0", Offset = "0x8BD6CD0", VA = "0x188BD7ED0", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8BD8850", Offset = "0x8BD7650", VA = "0x188BD8850", Slot = "52")]
	public Task EMLCOIDMGEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8BDB040", Offset = "0x8BD9E40", VA = "0x188BDB040", Slot = "20")]
	[AsyncStateMachine(typeof(NKGIMAALFAB))]
	public Task<GECIHKBMECG<GFMIADJGPJH, string>> LBDHMAEJOFI(Guid? LHMBOGGFNPO, long MDNJLMOPJKG, string PFLDDMDPCBI, string CDEPGINEGKG, string ECFOLMEBCEO, RoomInventoryItemProperties EAHIEHKAAEI, byte ADPIMLAGACM, int BGBIPHDMBPB, [Optional] List<long> HBDODEBOMAF, [Optional] List<OBBMAADMKFG> OMCANAEJFHP, bool GLOBDHAMDBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8BDB7D0", Offset = "0x8BDA5D0", VA = "0x188BDB7D0", Slot = "21")]
	[AsyncStateMachine(typeof(DENJPLLKOHJ))]
	public Task<GECIHKBMECG<GFMIADJGPJH, string>> LIDLMIIFNCA(Guid ENEOEDNPCBA, long MDNJLMOPJKG, [Optional] string PFLDDMDPCBI, [Optional] string CDEPGINEGKG, [Optional] string ECFOLMEBCEO, [Optional] List<long> HBDODEBOMAF, [Optional] Dictionary<string, RoomInventoryTagClientProperties> OMCANAEJFHP, [Optional] RoomInventoryItemProperties EAHIEHKAAEI, [Optional] byte? ADPIMLAGACM, [Optional] int? BGBIPHDMBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8BD6FE0", Offset = "0x8BD5DE0", VA = "0x188BD6FE0", Slot = "22")]
	[AsyncStateMachine(typeof(CBEMKEEDILO))]
	public Task<GECIHKBMECG<bool, string>> CHHBLHHEJGD(Guid ENEOEDNPCBA, long MDNJLMOPJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8BD8FC0", Offset = "0x8BD7DC0", VA = "0x188BD8FC0", Slot = "23")]
	public IReadOnlyList<GFMIADJGPJH> FDIJANNCJJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8BD9D70", Offset = "0x8BD8B70", VA = "0x188BD9D70", Slot = "24")]
	public IReadOnlyList<GFMIADJGPJH> IDDJPONDANJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7400", Offset = "0x8BD6200", VA = "0x188BD7400", Slot = "25")]
	public bool DFBOFJCDNPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8BD6870", Offset = "0x8BD5670", VA = "0x188BD6870", Slot = "26")]
	public bool APNDBPJHDAJ(Guid ENEOEDNPCBA, [Out] GFMIADJGPJH EJNEHIPFOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7500", Offset = "0x8BD6300", VA = "0x188BD7500", Slot = "27")]
	public bool DFDMPGAMIBF(string AJADEPPIBBF, [Out] GFMIADJGPJH EJNEHIPFOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8BD9B70", Offset = "0x8BD8970", VA = "0x188BD9B70", Slot = "28")]
	public IReadOnlyList<GLJJEPBELIM> IANAAMAHNPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8BD8720", Offset = "0x8BD7520", VA = "0x188BD8720", Slot = "29")]
	public bool EEBNJFLHBNO(Guid ENEOEDNPCBA, [Out] GLJJEPBELIM PIGPNPJKFBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8BDAA60", Offset = "0x8BD9860", VA = "0x188BDAA60", Slot = "30")]
	public long? JPBBIFPIEHN(Guid ENEOEDNPCBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8BD62F0", Offset = "0x8BD50F0", VA = "0x188BD62F0", Slot = "51")]
	public void ABHMBIMFOKP(IEnumerable<COAABHJIMMF> BHLCFIOIDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7110", Offset = "0x8BD5F10", VA = "0x188BD7110", Slot = "31")]
	[AsyncStateMachine(typeof(LCOCPLMPJFG))]
	public Task<int> CPOGPGDDLNA(AFLCFHLHEHB GLMBLPAKFLM, Guid ENEOEDNPCBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7D80", Offset = "0x8BD6B80", VA = "0x188BD7D80", Slot = "32")]
	[AsyncStateMachine(typeof(OOKMAAMIPIK))]
	public Task<MJLGILJJFNN> DKPPFJMHOCD(AFLCFHLHEHB CNKKHAFANFB, Guid ENEOEDNPCBA, int EBABNKEEAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8BDA160", Offset = "0x8BD8F60", VA = "0x188BDA160", Slot = "33")]
	public string JBMEIFIFEMI(NPODIONALLL MOBFLOHJOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8BD9660", Offset = "0x8BD8460", VA = "0x188BD9660", Slot = "34")]
	public bool GILGGMPNKGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8BDB990", Offset = "0x8BDA790", VA = "0x188BDB990", Slot = "38")]
	[AsyncStateMachine(typeof(DCKEKECPPEO))]
	public Task<GECIHKBMECG<POJMEDGDKKM, string>> LLGIOILLNHI(long LAHANCCOJIN, RoomInventoryTagClientProperties EAHIEHKAAEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8BD8A00", Offset = "0x8BD7800", VA = "0x188BD8A00", Slot = "39")]
	[AsyncStateMachine(typeof(DOJNOJECMAF))]
	public Task<GECIHKBMECG<bool, string>> ENOAJGPLADN(long LAHANCCOJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8BD8440", Offset = "0x8BD7240", VA = "0x188BD8440", Slot = "42")]
	public List<(long, int)> EAHICDGEHBB(long ALACKPBHGHK, int LOCEMHMAACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8BDA440", Offset = "0x8BD9240", VA = "0x188BDA440", Slot = "43")]
	public bool JDKODOKFKBL(long LAHANCCOJIN, [Out] POJMEDGDKKM FNLFDCDNBKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7620", Offset = "0x8BD6420", VA = "0x188BD7620", Slot = "44")]
	public bool DGKMEHIJFEL(string HELFCCCMPFC, [Out] POJMEDGDKKM FNLFDCDNBKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8BD6990", Offset = "0x8BD5790", VA = "0x188BD6990", Slot = "45")]
	public bool APPMNCCOGOD(long LAHANCCOJIN, Guid CGLKEOONBOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8BD6F10", Offset = "0x8BD5D10", VA = "0x188BD6F10", Slot = "46")]
	public IReadOnlyList<POJMEDGDKKM> BJLLDKPCIBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8BDA620", Offset = "0x8BD9420", VA = "0x188BDA620", Slot = "47")]
	public List<POJMEDGDKKM> JIJGDLCBFDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8BDA6B0", Offset = "0x8BD94B0", VA = "0x188BDA6B0", Slot = "48")]
	public IReadOnlyList<POJMEDGDKKM> JJABFOAFBAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8BD67F0", Offset = "0x8BD55F0", VA = "0x188BD67F0", Slot = "41")]
	public bool AOLGOLJJEDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8BD8CE0", Offset = "0x8BD7AE0", VA = "0x188BD8CE0", Slot = "49")]
	public IReadOnlyList<GFMIADJGPJH> FBEJMICPBIC(long LAHANCCOJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8BD6CB0", Offset = "0x8BD5AB0", VA = "0x188BD6CB0", Slot = "40")]
	[AsyncStateMachine(typeof(MIIGHIONGFO))]
	public Task<GECIHKBMECG<bool, string>> BDIIHMBOMLP(long MDNJLMOPJKG, bool HPHHJJMHCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8BDBC00", Offset = "0x8BDAA00", VA = "0x188BDBC00", Slot = "54")]
	public bool MILDHNIOCKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8BDB320", Offset = "0x8BDA120", VA = "0x188BDB320", Slot = "50")]
	public bool LFPDPAOKDHJ(string HELFCCCMPFC, [Out] IReadOnlyList<GFMIADJGPJH> LOAGAMKLHJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8BDA020", Offset = "0x8BD8E20", VA = "0x188BDA020")]
	[AsyncStateMachine(typeof(CEPMMPHHFGA))]
	private Task<Dictionary<long, OBBMAADMKFG>> IFKIJHENEGJ(Dictionary<long, int> JJPHDMFIAJE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8BDA4D0", Offset = "0x8BD92D0", VA = "0x188BDA4D0")]
	[AsyncStateMachine(typeof(LNCLFHLLLIG))]
	private Task<MJLGILJJFNN> JGAPHMOMMDI(Guid ENEOEDNPCBA, int EBABNKEEAMD, [Optional] Guid JDIFFABDPDF, [Optional] AFLCFHLHEHB GDGGMOHJFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8BD91F0", Offset = "0x8BD7FF0", VA = "0x188BD91F0")]
	[AsyncStateMachine(typeof(HHCBBLFBAEP))]
	private Task<Dictionary<HOPCAFJNJMG, HGDPGPPAEEI>> FHOEEIFLIPD(Dictionary<HOPCAFJNJMG, int> CLHDAKGBOPE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8BD94B0", Offset = "0x8BD82B0", VA = "0x188BD94B0")]
	[AsyncStateMachine(typeof(MCFKGABALMC))]
	private Task<List<HGDPGPPAEEI>> GDACBLPGGII(Dictionary<HOPCAFJNJMG, int> CLHDAKGBOPE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8BDC6B0", Offset = "0x8BDB4B0", VA = "0x188BDC6B0")]
	[AsyncStateMachine(typeof(PIDFBENOKPN))]
	private Task PHELEIBOOHN(long MDNJLMOPJKG, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7920", Offset = "0x8BD6720", VA = "0x188BD7920")]
	private Task DKHOENOPGGE(CHNMCCPJHLL NPIEBNDMCBK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8BD6E40", Offset = "0x8BD5C40", VA = "0x188BD6E40")]
	[AsyncStateMachine(typeof(DJKNJIIKOJE))]
	private Task BFJNLPHEFGD(CHNMCCPJHLL NPIEBNDMCBK, CancellationToken OLHLFCKNILO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8BDB200", Offset = "0x8BDA000", VA = "0x188BDB200")]
	private void LFGKBIABPBB(MMCGJDDLPCD LMJDFLKIALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8BDCB20", Offset = "0x8BDB920", VA = "0x188BDCB20")]
	[HMNKOIHOGHH]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string DDCDKIPOFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8BD9070", Offset = "0x8BD7E70", VA = "0x188BD9070")]
	private void FEECFAKOBJJ(Guid ENEOEDNPCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8BDCC60", Offset = "0x8BDBA60", VA = "0x188BDCC60")]
	[HMNKOIHOGHH]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid ENEOEDNPCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8BDBAC0", Offset = "0x8BDA8C0", VA = "0x188BDBAC0")]
	[AsyncStateMachine(typeof(IENNPFFNOBJ))]
	private Task<int> MGIEPBHCMPP(AFLCFHLHEHB GLMBLPAKFLM, Guid ENEOEDNPCBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8BDC930", Offset = "0x8BDB730", VA = "0x188BDC930")]
	[HMNKOIHOGHH]
	internal void RpcGetPlayerRoomInventoryCount(Guid ECLLBKCDLFA, Guid ENEOEDNPCBA, PDCFLIPGAOH NLCAIENELJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8BDC8B0", Offset = "0x8BDB6B0", VA = "0x188BDC8B0")]
	[HMNKOIHOGHH]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid ECLLBKCDLFA, int FFKCBONKOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8BD9840", Offset = "0x8BD8640", VA = "0x188BD9840")]
	[AsyncStateMachine(typeof(FDJHDLBIMGO))]
	private Task<MJLGILJJFNN> HBDDDBOOKKC(AFLCFHLHEHB GLMBLPAKFLM, Guid ENEOEDNPCBA, int EBABNKEEAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8BDC7E0", Offset = "0x8BDB5E0", VA = "0x188BDC7E0")]
	[HMNKOIHOGHH]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid ECLLBKCDLFA, Guid ENEOEDNPCBA, int EBABNKEEAMD, PDCFLIPGAOH NLCAIENELJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8BD8B20", Offset = "0x8BD7920", VA = "0x188BD8B20")]
	private void EPOCBOGCMND(AFLCFHLHEHB CNKKHAFANFB, Guid ECLLBKCDLFA, NPODIONALLL MOBFLOHJOKJ, long EGCMFLICLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8BDCF10", Offset = "0x8BDBD10", VA = "0x188BDCF10")]
	[HMNKOIHOGHH]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid ECLLBKCDLFA, int MOBFLOHJOKJ, long EGCMFLICLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8BDC470", Offset = "0x8BDB270", VA = "0x188BDC470")]
	private void OEMHMIHOMNB(bool HPHHJJMHCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8BDCEB0", Offset = "0x8BDBCB0", VA = "0x188BDCEB0")]
	[HMNKOIHOGHH]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool OHBFFEFJLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8BD6B90", Offset = "0x8BD5990", VA = "0x188BD6B90")]
	private void BDFONKPOEPC(List<OBBMAADMKFG> HCMEDGFIJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8BDCD00", Offset = "0x8BDBB00", VA = "0x188BDCD00")]
	[HMNKOIHOGHH]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string KDAONAOFAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8BD96D0", Offset = "0x8BD84D0", VA = "0x188BD96D0")]
	private void GPAMHJAJLJP(long LAHANCCOJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8BDCC90", Offset = "0x8BDBA90", VA = "0x188BDCC90")]
	[HMNKOIHOGHH]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long LAHANCCOJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7700", Offset = "0x8BD6500", VA = "0x188BD7700")]
	private GFMIADJGPJH DKAEHLHNEDO(MMCGJDDLPCD LMJDFLKIALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8BD9990", Offset = "0x8BD8790", VA = "0x188BD9990")]
	private List<POJMEDGDKKM> HCCLJBODHJP(List<OBBMAADMKFG> HCMEDGFIJLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8BD80F0", Offset = "0x8BD6EF0", VA = "0x188BD80F0")]
	private List<POJMEDGDKKM> EAEGCDNJJLP(IEnumerable<OBBMAADMKFG> HCMEDGFIJLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8BDBE30", Offset = "0x8BDAC30", VA = "0x188BDBE30", Slot = "36")]
	public RoomInventoryItemProperties NKCFGNOCPML(string PNDJKDLDJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8BDC2D0", Offset = "0x8BDB0D0", VA = "0x188BDC2D0")]
	private GFMIADJGPJH OBBAIFLPINE(MMCGJDDLPCD LMJDFLKIALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8BD72C0", Offset = "0x8BD60C0", VA = "0x188BD72C0", Slot = "35")]
	public MMCGJDDLPCD DFADGLNCEEG(GFMIADJGPJH KFAPLAGDMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8BD6560", Offset = "0x8BD5360", VA = "0x188BD6560")]
	private POJMEDGDKKM AEJCLHOEAIG(OBBMAADMKFG LMJDFLKIALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8BD95F0", Offset = "0x8BD83F0", VA = "0x188BD95F0")]
	private void GEEKIPNBBML(GLJJEPBELIM PIGPNPJKFBJ, int APKIEKDFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8BD6DD0", Offset = "0x8BD5BD0", VA = "0x188BD6DD0")]
	private void BEEOEHAKOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8BD9330", Offset = "0x8BD8130", VA = "0x188BD9330")]
	private Task FJPKDIOKOGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8BDC260", Offset = "0x8BDB060", VA = "0x188BDC260")]
	private void NKIKGNPBLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8BDC5F0", Offset = "0x8BDB3F0", VA = "0x188BDC5F0")]
	private void OLMPLEOANLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8BD88F0", Offset = "0x8BD76F0", VA = "0x188BD88F0")]
	private void EMPDDPAJDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8BDA330", Offset = "0x8BD9130", VA = "0x188BDA330")]
	[AsyncStateMachine(typeof(FLEEPDMHJKH))]
	private Task JDIKODDLLPO(GFMIADJGPJH IJECKDHBDIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8BD9D50", Offset = "0x8BD8B50", VA = "0x188BD9D50")]
	[CompilerGenerated]
	private void IBOOKGLKDKP(Task<TaskStatus> MGEGHBBNKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8BDABF0", Offset = "0x8BD99F0", VA = "0x188BDABF0")]
	[CompilerGenerated]
	private Task<NPODIONALLL> KEMJPEKLNAK(NJCCNJGNMKO P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8BDBC70", Offset = "0x8BDAA70", VA = "0x188BDBC70")]
	[CompilerGenerated]
	internal static Dictionary<HOPCAFJNJMG, HGDPGPPAEEI> NGEGDPKPKNK(NPODIONALLL MOBFLOHJOKJ, APFOCJDNHMD P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NDGMOLILNBN : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8BD5860", Offset = "0x8BD4660", VA = "0x188BD5860")]
	public NDGMOLILNBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BNNEKKBOOPI
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBEGPDINBKN HEJCMIHIMMC();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NDGMOLILNBN BBFFDFOALEG();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LPMPFCDKIOL OGCIEJHKPHE();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IBCMDGIGCIF : BNNEKKBOOPI
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8BD07E0", Offset = "0x8BCF5E0", VA = "0x188BD07E0")]
	[NKOKDPHOKEP.EPFIDDHPHJC.MBGBOEIIBBL]
	internal static void DBCFEKMBJDE(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	[RecRoom.NoEngine.Common.Preserve]
	public IBCMDGIGCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8BD0850", Offset = "0x8BCF650", VA = "0x188BD0850", Slot = "4")]
	public NBEGPDINBKN HEJCMIHIMMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8BD0770", Offset = "0x8BCF570", VA = "0x188BD0770", Slot = "5")]
	public NDGMOLILNBN BBFFDFOALEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8BD0960", Offset = "0x8BCF760", VA = "0x188BD0960", Slot = "6")]
	public LPMPFCDKIOL OGCIEJHKPHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LPMPFCDKIOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, POJMEDGDKKM> ILGAPHGFBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly POJMEDGDKKM[] GMKCPMBBGGF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FDCIDHBKMEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB7BBD0", Offset = "0xB7A9D0", VA = "0x180B7BBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AGGHFAJFEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2590", Offset = "0x8BD1390", VA = "0x188BD2590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long OAOIMEDAPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA98AC0", Offset = "0xA978C0", VA = "0x180A98AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8BD1A90", Offset = "0x8BD0890", VA = "0x188BD1A90")]
	public void GLIIHCMJEBC(long MDNJLMOPJKG, IEnumerable<POJMEDGDKKM> IEHEOLEINAP, bool MONKLFIIOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8BD18E0", Offset = "0x8BD06E0", VA = "0x188BD18E0")]
	public IReadOnlyList<POJMEDGDKKM> BMFMMCDEIEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xB7BBD0", Offset = "0xB7A9D0", VA = "0x180B7BBD0")]
	public void BPCPENFLBFA(bool HPHHJJMHCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8BD25F0", Offset = "0x8BD13F0", VA = "0x188BD25F0")]
	public bool LDMJPKMOIFK(long LAHANCCOJIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8BD2870", Offset = "0x8BD1670", VA = "0x188BD2870")]
	public bool OMDLPNNAPPP(POJMEDGDKKM LDCCIGOJKCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8BD2270", Offset = "0x8BD1070", VA = "0x188BD2270")]
	public bool JKHHDOMHEEO(List<POJMEDGDKKM> CIJOOCICACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8BD1F50", Offset = "0x8BD0D50", VA = "0x188BD1F50")]
	public bool HGPFJMAENCN(long LAHANCCOJIN, [Out] POJMEDGDKKM MIBLFIHKNOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8BD1FF0", Offset = "0x8BD0DF0", VA = "0x188BD1FF0")]
	public bool ICPECIODMNP(string PFLDDMDPCBI, [Out] POJMEDGDKKM MIBLFIHKNOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8BD21A0", Offset = "0x8BD0FA0", VA = "0x188BD21A0")]
	public List<POJMEDGDKKM> JHBBGLFGPCP(int JJJJBEGKNIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8BD26D0", Offset = "0x8BD14D0", VA = "0x188BD26D0")]
	public List<POJMEDGDKKM> LOMMEIAOKIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x71BC8B0", Offset = "0x71BB6B0", VA = "0x1871BC8B0")]
	public POJMEDGDKKM KFILELNJMKL(int JJJJBEGKNIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8BD2810", Offset = "0x8BD1610", VA = "0x188BD2810")]
	public IReadOnlyList<POJMEDGDKKM> OGCLOKMBMBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8BD2A30", Offset = "0x8BD1830", VA = "0x188BD2A30")]
	public LPMPFCDKIOL()
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

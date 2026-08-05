using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCF50", Offset = "0x8AFC350", VA = "0x188AFCF50", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x846E210", Offset = "0x846D610", VA = "0x18846E210", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD060", Offset = "0x8AFC460", VA = "0x188AFD060")]
		private void GBFKFENBIAE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD4D0", Offset = "0x8AFC8D0", VA = "0x188AFD4D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD2A0", Offset = "0x8AFC6A0", VA = "0x188AFD2A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD530", Offset = "0x8AFC930", VA = "0x188AFD530")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MODCGENOKPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int? BNKIMLCPLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool? BLOAOMPOJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OMBFNFBFMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLCGGBOKOAD();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LHOGJHALBOJ : MODCGENOKPJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly string MOJDKJCECOB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly string LDOOIEPDHJA;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly string IAFHNHCPJIG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly string CJEPFCDEDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FEGLFIFLMGC PPCODGLFELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int? DNBMPMLILKL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int? BNKIMLCPLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OMBFNFBFMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool? BLOAOMPOJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCA20", Offset = "0x8AFBE20", VA = "0x188AFCA20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	[UnityEngine.Scripting.Preserve]
	public LHOGJHALBOJ([PKIHAALFADL(null)][NotNull] FEGLFIFLMGC JNHBEKDBGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8AFCA70", Offset = "0x8AFBE70", VA = "0x188AFCA70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8AFCB70", Offset = "0x8AFBF70", VA = "0x188AFCB70")]
	[MKODAOGKIAA.LAFEFHEHFHN.PPBCBBDKDNB]
	[UsedImplicitly]
	public static void JOLJGOKIDFF(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8AFCCC0", Offset = "0x8AFC0C0", VA = "0x188AFCCC0", Slot = "5")]
	public void MLCGGBOKOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8AFC460", Offset = "0x8AFB860", VA = "0x188AFC460")]
	private void AAIMENNOHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8AFCBE0", Offset = "0x8AFBFE0", VA = "0x188AFCBE0")]
	private bool LDMKHKIDKBK(string JBJECGIOIKJ, [Out] BNCOHPPDMKG MFOPLKAAPAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BEJPPLIIEJK
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDEMDFANNEG();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KLAALNKGACD : BEJPPLIIEJK
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class GANEDFPNFBB : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public KLAALNKGACD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public GANEDFPNFBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBA00", Offset = "0x8AFAE00", VA = "0x188AFBA00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBAF0", Offset = "0x8AFAEF0", VA = "0x188AFBAF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private LDBPABGAEKE MAFFECPDKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int OIFBDKACION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool? GKCALOFPOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool DCGIDCDJBJA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static AKNCNLDICPO JFOJLBDGNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<string> NMLMNFEKKCP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8AFC340", Offset = "0x8AFB740", VA = "0x188AFC340")]
	[UnityEngine.Scripting.Preserve]
	public KLAALNKGACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8AFBB40", Offset = "0x8AFAF40", VA = "0x188AFBB40")]
	private LDBPABGAEKE HIEEIIBMONN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8AFBDD0", Offset = "0x8AFB1D0", VA = "0x188AFBDD0")]
	[IteratorStateMachine(typeof(GANEDFPNFBB))]
	private IEnumerator<KHJLACPAINM> JMAIGLLKKJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8AFBEC0", Offset = "0x8AFB2C0", VA = "0x188AFBEC0")]
	private void NBFONJOIBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8AFBE50", Offset = "0x8AFB250", VA = "0x188AFBE50")]
	[MKODAOGKIAA.PMDGGDAFIAI]
	public static void JOLJGOKIDFF(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8AFBC50", Offset = "0x8AFB050", VA = "0x188AFBC50", Slot = "4")]
	public void JDEMDFANNEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(BFEBLACBFGG), new string[] { })]
public class BFEBLACBFGG : NGBDAEKMHIJ, LLJNOAGPADG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FCGNKCHKJKB : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public BFEBLACBFGG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public FCGNKCHKJKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB790", Offset = "0x8AFAB90", VA = "0x188AFB790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB9B0", Offset = "0x8AFADB0", VA = "0x188AFB9B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private MODCGENOKPJ NBBJKKKJOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private ECFCPGIOFGO OKFKBKGCFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IDisposable PHMPMFIJGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private IDisposable JOKHIIKGPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HashSet<ReflectionProbe> HIIMIACILJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool IBJDMEOFBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private bool GBKFJHBJAAO;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB700", Offset = "0x8AFAB00", VA = "0x188AFB700")]
	[UnityEngine.Scripting.Preserve]
	public BFEBLACBFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB1D0", Offset = "0x8AFA5D0", VA = "0x188AFB1D0", Slot = "4")]
	public void InitExternal(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB1C0", Offset = "0x8AFA5C0", VA = "0x188AFB1C0")]
	private void IPEDAOKEKKJ(Scene OOOMFAMCOIH, LoadSceneMode BADJHCKOHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB010", Offset = "0x8AFA410", VA = "0x188AFB010")]
	private void IIFHAEHMEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB510", Offset = "0x8AFA910", VA = "0x188AFB510")]
	private void LMELECOKBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB350", Offset = "0x8AFA750", VA = "0x188AFB350")]
	private (ReflectionProbe, int) JFOCHHDLHNM()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA930", Offset = "0x8AF9D30", VA = "0x188AFA930")]
	[IteratorStateMachine(typeof(FCGNKCHKJKB))]
	private IEnumerator<KHJLACPAINM> BCAJBHIOJMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA9B0", Offset = "0x8AF9DB0", VA = "0x188AFA9B0")]
	private void GIDNBAFNBIL([CanBeNull] ReflectionProbe BGEHFNNPGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB640", Offset = "0x8AFAA40", VA = "0x188AFB640")]
	private void OKPPMIOBFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB5F0", Offset = "0x8AFA9F0", VA = "0x188AFB5F0")]
	private void OGGDBJKLINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8AFAF30", Offset = "0x8AFA330", VA = "0x188AFAF30", Slot = "5")]
	public void IFLOIAOAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8AFAA90", Offset = "0x8AF9E90", VA = "0x188AFAA90")]
	[CompilerGenerated]
	private void HFBHHMGFBAN()
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

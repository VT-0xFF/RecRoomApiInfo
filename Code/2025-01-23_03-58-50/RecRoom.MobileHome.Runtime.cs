using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FB96A0", Offset = "0x6FB7EA0", VA = "0x186FB96A0", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAF70", Offset = "0x6FB9770", VA = "0x186FBAF70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CILKCINEICM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Initializing = 1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ReadyForLogin = 2,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	PlayerLoading = 32,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	PlayerLoaded = 33,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	PlayerCustomization = 34,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	RoomLoading = 64,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InOrientation = 65,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InDorm = 66,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	InRoom = 67,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	InEvent = 68,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Logout = 128,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ExitingClient = 129
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LCNPPCADPAF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EHIJCFPIOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? PMLNFGOGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? LDAFNOPFCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? MIDFBKCNOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? EBDFDNEJLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	MNHIIICELAE EKNACEFCGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PDELBPNDADJ(CILKCINEICM LCFHGACCKAF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EHFCOOMFLME();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OCKFIJHLPPC();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CEAODFGHDHA(string DFNPEPOLIKL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BDLPHMFFDAD();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<MNHIIICELAE> OODFCPJEAJG([Optional] CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HOEOIFIDHMF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CJLKELOCLIB
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task INEMENFLGEI(MNHIIICELAE AAGABFGFBAB, [Optional] CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PAJJPPJPIOG : LCNPPCADPAF
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum NCNBJLEKBIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void DGHAEMFFKAK(string AAGABFGFBAB);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int IFFDNLOJKHD();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BHFOCFEIOJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<MNHIIICELAE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public PAJJPPJPIOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskCompletionSource<MNHIIICELAE> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<MNHIIICELAE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8FF0", Offset = "0x6FB77F0", VA = "0x186FB8FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9630", Offset = "0x6FB7E30", VA = "0x186FB9630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly FICDJCDJOAA CLLGOIEIHDM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static PAJJPPJPIOG BJNFKEAALFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly KHOLIEJJFCA JDGPAGIEHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AHGKHMPHOLL DCJDJCGFMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly PIPABNENLFP DFIEMBFNDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool KPCGOHANEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool OPBLOJCJGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool OFNLOPIDEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool CNGJGPGLCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private long? KFCIAGDJFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool KBCDHKGCMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private long? NPPCAIJKBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool EJKDDMHDMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Guid? IPNIEKEPJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private CILKCINEICM OHBFLHLJCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly object AEALFCJNBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Queue<MNHIIICELAE> INKIFJJBFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private TaskCompletionSource<MNHIIICELAE> MPGGEANEBCE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool EHIJCFPIOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? PMLNFGOGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9F10", Offset = "0x6FB8710", VA = "0x186FB9F10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? LDAFNOPFCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9C00", Offset = "0x6FB8400", VA = "0x186FB9C00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? MIDFBKCNOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA500", Offset = "0x6FB8D00", VA = "0x186FBA500", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? EBDFDNEJLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9AD0", Offset = "0x6FB82D0", VA = "0x186FB9AD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MNHIIICELAE EKNACEFCGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x996E90", Offset = "0x995690", VA = "0x180996E90", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xE8A230", Offset = "0xE88A30", VA = "0x180E8A230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAD00", Offset = "0x6FB9500", VA = "0x186FBAD00")]
	[RecRoom.NoEngine.Common.Preserve]
	public PAJJPPJPIOG([NDCFMLCHJCI(null)] KHOLIEJJFCA JDGPAGIEHPF, [NDCFMLCHJCI(null)] AHGKHMPHOLL DCJDJCGFMMN, [NDCFMLCHJCI(null)] PIPABNENLFP DFIEMBFNDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9C80", Offset = "0x6FB8480", VA = "0x186FB9C80", Slot = "11")]
	public void EHFCOOMFLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9960", Offset = "0x6FB8160", VA = "0x186FB9960", Slot = "14")]
	public void BDLPHMFFDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9FF0", Offset = "0x6FB87F0", VA = "0x186FB9FF0", Slot = "17")]
	public void JNNGGOJLHKO(string KFKFKCFOBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9A90", Offset = "0x6FB8290", VA = "0x186FB9A90", Slot = "12")]
	public void OCKFIJHLPPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9A90", Offset = "0x6FB8290", VA = "0x186FB9A90", Slot = "18")]
	public void JEAIDLOIGNB([Optional] string KMJLAGBCIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9A90", Offset = "0x6FB8290", VA = "0x186FB9A90", Slot = "13")]
	public void CEAODFGHDHA(string DFNPEPOLIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6FBABD0", Offset = "0x6FB93D0", VA = "0x186FBABD0", Slot = "10")]
	public void PDELBPNDADJ(CILKCINEICM LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9DF0", Offset = "0x6FB85F0", VA = "0x186FB9DF0", Slot = "16")]
	public void HOEOIFIDHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA820", Offset = "0x6FB9020", VA = "0x186FBA820", Slot = "15")]
	[AsyncStateMachine(typeof(BHFOCFEIOJN))]
	public Task<MNHIIICELAE> OODFCPJEAJG(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA940", Offset = "0x6FB9140", VA = "0x186FBA940")]
	private void PBPEAJIOJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAC20", Offset = "0x6FB9420", VA = "0x186FBAC20")]
	[MonoPInvokeCallback(typeof(DGHAEMFFKAK))]
	private static void PNHENCECMMC(string KFKFKCFOBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA590", Offset = "0x6FB8D90", VA = "0x186FBA590")]
	[MonoPInvokeCallback(typeof(IFFDNLOJKHD))]
	private static int LFCFNPPKEMF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA420", Offset = "0x6FB8C20", VA = "0x186FBA420")]
	private void JOIBLCMLNPH(string JNJMIANLNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9A50", Offset = "0x6FB8250", VA = "0x186FB9A50")]
	private void BNOCFAPKEOD(DGHAEMFFKAK KNMHMBJIFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA7E0", Offset = "0x6FB8FE0", VA = "0x186FBA7E0")]
	private void OAJGGOMELBO(IFFDNLOJKHD KNMHMBJIFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9A90", Offset = "0x6FB8290", VA = "0x186FB9A90")]
	private void OCKFIJHLPPC(NCNBJLEKBIK HLONLEDABCF, string AIKDIGKAHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9920", Offset = "0x6FB8120", VA = "0x186FB9920")]
	private void AHNGICLIDHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA4A0", Offset = "0x6FB8CA0", VA = "0x186FBA4A0")]
	private long? KCMJAGIOFID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA5F0", Offset = "0x6FB8DF0", VA = "0x186FBA5F0")]
	private long? LKEEGKJKLAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9B90", Offset = "0x6FB8390", VA = "0x186FB9B90")]
	private Guid? DKNHPFCDGJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9F90", Offset = "0x6FB8790", VA = "0x186FB9F90")]
	private double? IOCIGEGLECM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9970", Offset = "0x6FB8170", VA = "0x186FB9970")]
	internal static void BNJKPKIMGCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA650", Offset = "0x6FB8E50", VA = "0x186FBA650")]
	private void MHEBBNKJCEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OEBGMOALPKM
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9830", Offset = "0x6FB8030", VA = "0x186FB9830")]
	[PDAMAKFHAHC.GNFCFDNPMLH]
	internal static void GOKKBLJBDFN(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9730", Offset = "0x6FB7F30", VA = "0x186FB9730")]
	[GOEJJNJJNIL.ABCDFDECKHK]
	internal static void DJHMGECEMME()
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

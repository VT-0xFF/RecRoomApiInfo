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
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x728EE80", Offset = "0x728E080", VA = "0x18728EE80", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x728F1F0", Offset = "0x728E3F0", VA = "0x18728F1F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PELPKDKGHPO
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
public interface KCNIHEIBBAK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KGOLNGBKDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? DKKIFJBBJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? BLNEDJAOCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? PHAOOOGJHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? OOCPACIEKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	PDGPLJHDEOK BFLLCHIDLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ACDGDHBIONM(PELPKDKGHPO ONNLPKDFGPA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GGPOBANFNOP();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NDLLHJKOFEG();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BOLBANDFGBE(string OOGMDAJCDJN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<PDGPLJHDEOK> ONABCPMGBMD([Optional] CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LPMBNDAGJIE();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ADKMIKAHFGL
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HDJFHDLCGKG(PDGPLJHDEOK PEBFJACEDFH, [Optional] CancellationToken BGEKICMONBE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KJDNPEEJAAO : KCNIHEIBBAK
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum PICAGHOGHBI
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void OMCFAOPJHPK(string PEBFJACEDFH);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int CCOEGGHFEEJ();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IJGMOAMCCDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<PDGPLJHDEOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public KJDNPEEJAAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<PDGPLJHDEOK> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<PDGPLJHDEOK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x728D280", Offset = "0x728C480", VA = "0x18728D280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x728D8C0", Offset = "0x728CAC0", VA = "0x18728D8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly KJMCEDJMPPA IKHOJNLBJOK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static KJDNPEEJAAO IEFGENALBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly DEGKPLDMDPH NGMLJIELLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KPJFLMIHCDF DFMLAAKOBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JMOPHKIMIHA LKMDFODFPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool IOFNIFDJAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool GPJHOOFMHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool LFOGIHAJKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? FKEPNJBPKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool PGNAOJINKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? AFFMLMFDLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool EKDJLHKBJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? EGGKPOPDMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private PELPKDKGHPO FJLMLHCPNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object DCHIPKDBOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<PDGPLJHDEOK> NPFEKIFGHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<PDGPLJHDEOK> HPDBKEONKBL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KGOLNGBKDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? DKKIFJBBJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x728E050", Offset = "0x728D250", VA = "0x18728E050", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? BLNEDJAOCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x728E5D0", Offset = "0x728D7D0", VA = "0x18728E5D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? PHAOOOGJHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x728DEC0", Offset = "0x728D0C0", VA = "0x18728DEC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? OOCPACIEKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x728DF50", Offset = "0x728D150", VA = "0x18728DF50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PDGPLJHDEOK BFLLCHIDLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA8A360", Offset = "0xA89560", VA = "0x180A8A360", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x110FBD0", Offset = "0x110EDD0", VA = "0x18110FBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x728ED00", Offset = "0x728DF00", VA = "0x18728ED00")]
	[RecRoom.NoEngine.Common.Preserve]
	public KJDNPEEJAAO([FMJHJHHALCB(null)] DEGKPLDMDPH NGMLJIELLHO, [FMJHJHHALCB(null)] KPJFLMIHCDF DFMLAAKOBDI, [FMJHJHHALCB(null)] JMOPHKIMIHA LKMDFODFPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x728E0D0", Offset = "0x728D2D0", VA = "0x18728E0D0", Slot = "11")]
	public void GGPOBANFNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x728DA50", Offset = "0x728CC50", VA = "0x18728DA50", Slot = "16")]
	public void BMPFOMKNBJA(string NJLGLKLLCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x728DE80", Offset = "0x728D080", VA = "0x18728DE80", Slot = "12")]
	public void NDLLHJKOFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x728DE80", Offset = "0x728D080", VA = "0x18728DE80", Slot = "17")]
	public void IACKOKOKDMH([Optional] string NDDOLGJNCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x728DE80", Offset = "0x728D080", VA = "0x18728DE80", Slot = "13")]
	public void BOLBANDFGBE(string OOGMDAJCDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x728D930", Offset = "0x728CB30", VA = "0x18728D930", Slot = "10")]
	public void ACDGDHBIONM(PELPKDKGHPO ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x728E740", Offset = "0x728D940", VA = "0x18728E740", Slot = "15")]
	public void LPMBNDAGJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x728EA30", Offset = "0x728DC30", VA = "0x18728EA30", Slot = "14")]
	[AsyncStateMachine(typeof(IJGMOAMCCDN))]
	public Task<PDGPLJHDEOK> ONABCPMGBMD(CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x728E2A0", Offset = "0x728D4A0", VA = "0x18728E2A0")]
	private void IEPBMOEBMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x728E6D0", Offset = "0x728D8D0", VA = "0x18728E6D0")]
	[MonoPInvokeCallback(typeof(OMCFAOPJHPK))]
	private static void LJCAAJLKKGO(string NJLGLKLLCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x728E240", Offset = "0x728D440", VA = "0x18728E240")]
	[MonoPInvokeCallback(typeof(CCOEGGHFEEJ))]
	private static int HHBACPIPEMH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x728E650", Offset = "0x728D850", VA = "0x18728E650")]
	private void KJBCIDONPAK(string BIDGEGBKPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x728E010", Offset = "0x728D210", VA = "0x18728E010")]
	private void ENPDGHPONDF(OMCFAOPJHPK FOCHKIPOIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x728E530", Offset = "0x728D730", VA = "0x18728E530")]
	private void IINFKLAODDP(CCOEGGHFEEJ FOCHKIPOIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x728DE80", Offset = "0x728D080", VA = "0x18728DE80")]
	private void NDLLHJKOFEG(PICAGHOGHBI GLMJIDMBMEG, string OHLKIDDKJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x728E860", Offset = "0x728DA60", VA = "0x18728E860")]
	private void MEJEBIFFEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x728E570", Offset = "0x728D770", VA = "0x18728E570")]
	private long? IIPLNBELFJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x728D980", Offset = "0x728CB80", VA = "0x18728D980")]
	private long? AOGEJNKFBPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x728D9E0", Offset = "0x728CBE0", VA = "0x18728D9E0")]
	private Guid? BDPMANKDIEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x728EB50", Offset = "0x728DD50", VA = "0x18728EB50")]
	private double? PDIGFKMLILO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x728EBB0", Offset = "0x728DDB0", VA = "0x18728EBB0")]
	internal static void PICMKLNGKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x728E8A0", Offset = "0x728DAA0", VA = "0x18728E8A0")]
	private void OKLAJMIGLHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class POIBDCGMJCB
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x728F010", Offset = "0x728E210", VA = "0x18728F010")]
	[NAOGKPPNIGE.PBOHCEMILCE]
	internal static void PJCNNLMPMPA(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x728EF10", Offset = "0x728E110", VA = "0x18728EF10")]
	[KPFPOENAMPL.IOLLOIHFCAP]
	internal static void DFKOGNHAJHM()
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

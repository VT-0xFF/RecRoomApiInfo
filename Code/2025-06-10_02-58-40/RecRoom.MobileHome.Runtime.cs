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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7CD4280", Offset = "0x7CD3480", VA = "0x187CD4280", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CD5910", Offset = "0x7CD4B10", VA = "0x187CD5910", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AFPNNCMABNM
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
public interface ONIGKJICJLL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EPBJNJHHGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? GECIJDAKHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? HNFFAABKMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? CBLDHKABOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? JCHDILMHOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LLJJCBBMGPM KPIFFHFPAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LICFOAMONPB(AFPNNCMABNM CKCKEFFHJAP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AFLILFPIJAH();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BKKGFLPPFIM();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CJGBKFEICAL(string GNLDHDANFJL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<LLJJCBBMGPM> NHEBNINGEMF([Optional] CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BPHILKJNHFG();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DGIIHCGEPIP
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MOGGHCGILBJ : ONIGKJICJLL
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum DGKIGFHJJFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void NHHNLAMNPGJ(string GDGMAKLBFKF);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int AEGFIGJFCIG();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct KCOPPKFPOHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<LLJJCBBMGPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public MOGGHCGILBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<LLJJCBBMGPM> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<LLJJCBBMGPM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3BD0", Offset = "0x7CD2DD0", VA = "0x187CD3BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7CD4210", Offset = "0x7CD3410", VA = "0x187CD4210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly KEPOMIIOHBM AODHEIHGBPN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static MOGGHCGILBJ CAABJDKAONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly ABCAKKCKJPM MJKALHJOOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CDCCKKMKCIE OIIMMODDBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly COFHFABNMHG BJGKFMKAEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool LFBDLBKOAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool ALNBAKGBCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool MJJHEKCDEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? MEIDMKCHICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool NMMMNNIBMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? AHOEEDJDMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool ONOOOKDOLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? INHIBCOAJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private AFPNNCMABNM MEPEECLFJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object MJKOIMLKKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<LLJJCBBMGPM> AGMJLBPILIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<LLJJCBBMGPM> KLKLFMLEKOM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool EPBJNJHHGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? GECIJDAKHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7CD4C00", Offset = "0x7CD3E00", VA = "0x187CD4C00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? HNFFAABKMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7CD55C0", Offset = "0x7CD47C0", VA = "0x187CD55C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? CBLDHKABOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7CD4C80", Offset = "0x7CD3E80", VA = "0x187CD4C80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? JCHDILMHOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7CD4B40", Offset = "0x7CD3D40", VA = "0x187CD4B40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LLJJCBBMGPM KPIFFHFPAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC50C10", Offset = "0xC4FE10", VA = "0x180C50C10", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x13DDAA0", Offset = "0x13DCCA0", VA = "0x1813DDAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7CD56B0", Offset = "0x7CD48B0", VA = "0x187CD56B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MOGGHCGILBJ([NGLIAOPBMFM(null)] ABCAKKCKJPM MJKALHJOOHD, [NGLIAOPBMFM(null)] CDCCKKMKCIE OIIMMODDBEA, [NGLIAOPBMFM(null)] COFHFABNMHG BJGKFMKAEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CD43B0", Offset = "0x7CD35B0", VA = "0x187CD43B0", Slot = "11")]
	public void AFLILFPIJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD50D0", Offset = "0x7CD42D0", VA = "0x187CD50D0", Slot = "16")]
	public void ODDAFJOGLPO(string NFMCOJJEPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4610", Offset = "0x7CD3810", VA = "0x187CD4610", Slot = "12")]
	public void BKKGFLPPFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4610", Offset = "0x7CD3810", VA = "0x187CD4610", Slot = "17")]
	public void IMJMJAHCCJJ([Optional] string FFECHDNEJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4610", Offset = "0x7CD3810", VA = "0x187CD4610", Slot = "13")]
	public void CJGBKFEICAL(string GNLDHDANFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4D80", Offset = "0x7CD3F80", VA = "0x187CD4D80", Slot = "10")]
	public void LICFOAMONPB(AFPNNCMABNM CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4650", Offset = "0x7CD3850", VA = "0x187CD4650", Slot = "15")]
	public void BPHILKJNHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4F50", Offset = "0x7CD4150", VA = "0x187CD4F50", Slot = "14")]
	[AsyncStateMachine(typeof(KCOPPKFPOHK))]
	public Task<LLJJCBBMGPM> NHEBNINGEMF(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4850", Offset = "0x7CD3A50", VA = "0x187CD4850")]
	private void EEPDBJHBHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4D10", Offset = "0x7CD3F10", VA = "0x187CD4D10")]
	[MonoPInvokeCallback(typeof(NHHNLAMNPGJ))]
	private static void JEPDIKCIAEJ(string NFMCOJJEPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CD47B0", Offset = "0x7CD39B0", VA = "0x187CD47B0")]
	[MonoPInvokeCallback(typeof(AEGFIGJFCIG))]
	private static int DIELJKIMGBI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4520", Offset = "0x7CD3720", VA = "0x187CD4520")]
	private void AIIABNFIODB(string DLLNPFAIBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4770", Offset = "0x7CD3970", VA = "0x187CD4770")]
	private void COPLHOKPDNH(NHHNLAMNPGJ MHPGHAHOBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4310", Offset = "0x7CD3510", VA = "0x187CD4310")]
	private void AAEOFDIFEAO(AEGFIGJFCIG MHPGHAHOBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4610", Offset = "0x7CD3810", VA = "0x187CD4610")]
	private void BKKGFLPPFIM(DGKIGFHJJFA GBBFGBIIOBJ, string ICMEDEKCPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4810", Offset = "0x7CD3A10", VA = "0x187CD4810")]
	private void DPMKOLEFKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4AE0", Offset = "0x7CD3CE0", VA = "0x187CD4AE0")]
	private long? ELPPNKFGOMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4350", Offset = "0x7CD3550", VA = "0x187CD4350")]
	private long? ABJFJCDNOEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CD45A0", Offset = "0x7CD37A0", VA = "0x187CD45A0")]
	private Guid? AJLOAHLHMLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5070", Offset = "0x7CD4270", VA = "0x187CD5070")]
	private double? OBOKHNDIJEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CD54F0", Offset = "0x7CD46F0", VA = "0x187CD54F0")]
	internal static void PNBMLHKPKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4DD0", Offset = "0x7CD3FD0", VA = "0x187CD4DD0")]
	private void MPNLMJHNMPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IIACIHNCBLN
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CD39D0", Offset = "0x7CD2BD0", VA = "0x187CD39D0")]
	[MGCKGAIBEHC.PCMIGKEOIEO]
	internal static void DNNFNFINENH(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3AD0", Offset = "0x7CD2CD0", VA = "0x187CD3AD0")]
	[AMFDJJKGJPA.LNNANOGDNGN]
	internal static void LFEAAEEPEBD()
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

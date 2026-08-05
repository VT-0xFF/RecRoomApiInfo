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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x817E890", Offset = "0x817D490", VA = "0x18817E890", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x817EC10", Offset = "0x817D810", VA = "0x18817EC10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KMPHNMPMMBK
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
public interface PLEBJFOPBGO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MBCCPKPKHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? AMKIJMICAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? AMFPAJIJHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? MLIHGOFIKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? HBFMLDIPLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JPDMJLEDBLB GLINEIDPPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FIHCADFPBCE(KMPHNMPMMBK EKPDKNLBIHJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BFHPBJMBKJO();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IFPKGMNOLAO();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FOHDGJBIKLI(string OBEBDBPCMID);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<JPDMJLEDBLB> IBEKFPEJMNA([Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HKEJJJHIHAL();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FLAPNBAJIGL
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ICBFODDDFPE : PLEBJFOPBGO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum JHFIFCFGNID
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void AMFCEJHCBAF(string PDOJDCIDLMC);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int CEGMLGGJAGH();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BDDGACOINMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<JPDMJLEDBLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public ICBFODDDFPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<JPDMJLEDBLB> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<JPDMJLEDBLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x817CC90", Offset = "0x817B890", VA = "0x18817CC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x817D2D0", Offset = "0x817BED0", VA = "0x18817D2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly PEOHNMCPNIJ OJAPELLDHBE;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static ICBFODDDFPE MIOFGENCPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly PEHHKHACOAC IOMHNGAOLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EONKNFHOAOJ HGGBKAENIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MOIEHJINFNO KCFBMHNIOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool JMGEDAAIKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MCAAJCDOJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool NGHGGDNEDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? BABLKJAJJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool FKJBKOHHFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? GNNLOMLDMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool OBMEOGFBDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? KJPODDPLIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private KMPHNMPMMBK ECBLDBEGCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object IOPFPFNBACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<JPDMJLEDBLB> ADADFDAPIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<JPDMJLEDBLB> NAMPFBLEMHE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool MBCCPKPKHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? AMKIJMICAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x817D340", Offset = "0x817BF40", VA = "0x18817D340", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? AMFPAJIJHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x817E620", Offset = "0x817D220", VA = "0x18817E620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? MLIHGOFIKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x817E410", Offset = "0x817D010", VA = "0x18817E410", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? HBFMLDIPLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x817E500", Offset = "0x817D100", VA = "0x18817E500", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JPDMJLEDBLB GLINEIDPPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAC01F0", Offset = "0xABEDF0", VA = "0x180AC01F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xABDCF0", Offset = "0xABC8F0", VA = "0x180ABDCF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x817E710", Offset = "0x817D310", VA = "0x18817E710")]
	[RecRoom.NoEngine.Common.Preserve]
	public ICBFODDDFPE([HAKCNCGPHPD(null)] PEHHKHACOAC IOMHNGAOLND, [HAKCNCGPHPD(null)] EONKNFHOAOJ HGGBKAENIKL, [HAKCNCGPHPD(null)] MOIEHJINFNO KCFBMHNIOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x817D3C0", Offset = "0x817BFC0", VA = "0x18817D3C0", Slot = "11")]
	public void BFHPBJMBKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x817D850", Offset = "0x817C450", VA = "0x18817D850", Slot = "16")]
	public void CONIGIECGFH(string EICCANCLNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x817D730", Offset = "0x817C330", VA = "0x18817D730", Slot = "12")]
	public void IFPKGMNOLAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x817D730", Offset = "0x817C330", VA = "0x18817D730", Slot = "17")]
	public void BOCNJEJJHGP([Optional] string LONLFJJAOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x817D730", Offset = "0x817C330", VA = "0x18817D730", Slot = "13")]
	public void FOHDGJBIKLI(string OBEBDBPCMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x817DD90", Offset = "0x817C990", VA = "0x18817DD90", Slot = "10")]
	public void FIHCADFPBCE(KMPHNMPMMBK EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x817DE20", Offset = "0x817CA20", VA = "0x18817DE20", Slot = "15")]
	public void HKEJJJHIHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x817DF80", Offset = "0x817CB80", VA = "0x18817DF80", Slot = "14")]
	[AsyncStateMachine(typeof(BDDGACOINMM))]
	public Task<JPDMJLEDBLB> IBEKFPEJMNA(CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x817E100", Offset = "0x817CD00", VA = "0x18817E100")]
	private void IIGPFINLKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x817DC80", Offset = "0x817C880", VA = "0x18817DC80")]
	[MonoPInvokeCallback(typeof(AMFCEJHCBAF))]
	private static void DPFMDLNHLOH(string EICCANCLNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x817DD30", Offset = "0x817C930", VA = "0x18817DD30")]
	[MonoPInvokeCallback(typeof(CEGMLGGJAGH))]
	private static int EKCAAPFEJGB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x817E390", Offset = "0x817CF90", VA = "0x18817E390")]
	private void JEIPPHKOAFK(string LGNDPCOKEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x817DF40", Offset = "0x817CB40", VA = "0x18817DF40")]
	private void HPPGCJDFFNG(AMFCEJHCBAF HFBNHPDLHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x817DDE0", Offset = "0x817C9E0", VA = "0x18817DDE0")]
	private void GICPBIJDEAL(CEGMLGGJAGH HFBNHPDLHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x817D730", Offset = "0x817C330", VA = "0x18817D730")]
	private void IFPKGMNOLAO(JHFIFCFGNID LENOHNAJDNM, string FONHKPICBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x817DCF0", Offset = "0x817C8F0", VA = "0x18817DCF0")]
	private void EIFCDCEGJLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x817E5C0", Offset = "0x817D1C0", VA = "0x18817E5C0")]
	private long? MCCGHGBJDNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x817E4A0", Offset = "0x817D0A0", VA = "0x18817E4A0")]
	private long? KDMFLANGMPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x817D6C0", Offset = "0x817C2C0", VA = "0x18817D6C0")]
	private Guid? BJCNMACOJNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x817E0A0", Offset = "0x817CCA0", VA = "0x18817E0A0")]
	private double? IEIIEDIAIBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x817D770", Offset = "0x817C370", VA = "0x18817D770")]
	internal static void CAILKOKBOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x817D530", Offset = "0x817C130", VA = "0x18817D530")]
	private void BHNPOAIAIIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NAOKKBLNCKK
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x817E920", Offset = "0x817D520", VA = "0x18817E920")]
	[HHMPGEJNNFC.JKDCLEHGFFF]
	internal static void ACFPPHCGFGC(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x817EA20", Offset = "0x817D620", VA = "0x18817EA20")]
	[BDMFNNIICLO.FBLNOKJKJMK]
	internal static void CMGHCFAOKMP()
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

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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B7B510", Offset = "0x7B7A910", VA = "0x187B7B510", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B7B690", Offset = "0x7B7AA90", VA = "0x187B7B690", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum EFHLAGBCAMD
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
public interface PFFFGAOBKEP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DMENGBKBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? INMGMCDMOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? LBGIDGAKEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? FOCNBFPNEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? EOPGKCCPFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FOOOPOPDBKG BNMLAEBHIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CAMOELOHMMH(EFHLAGBCAMD FGCBFMGNEPC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ENMMELFAOHH();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CMMIHCANGGI();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DBLAENJJLIG(string GDODLHCOCDP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<FOOOPOPDBKG> EMBOFJAPGBA([Optional] CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BNNOOBLPDHO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FCMOAEKMAJD
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HHNGINFFDDO : PFFFGAOBKEP
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum PBHJOJPADKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void FMFIAONFCHH(string COOGOMPPBMK);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int CKEFHABGAJE();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GGFFPGIIOHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<FOOOPOPDBKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public HHNGINFFDDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<FOOOPOPDBKG> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<FOOOPOPDBKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B79910", Offset = "0x7B78D10", VA = "0x187B79910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B79F50", Offset = "0x7B79350", VA = "0x187B79F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly LMKAPNBAFDO BKFDGJHNENK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static HHNGINFFDDO KBMKBMHFKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MGDFFFNAIOO LGDKKODIABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EBPHMDLBLHI EBBHOONOGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MNNHDDKNOCP NEHAGNMHGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool ADGIBPIJOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool LKJJAKNJFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool MICEOHNDCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? CBFEGFMPACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool KIEJCHIFHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? CBLAIANHDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool GHJFELNMLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? CPINALJPMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EFHLAGBCAMD GEGMNOPMFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object PNAKDOHOCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<FOOOPOPDBKG> GDHEHHCPBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<FOOOPOPDBKG> JIPFLHNICGK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DMENGBKBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? INMGMCDMOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A630", Offset = "0x7B79A30", VA = "0x187B7A630", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? LBGIDGAKEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A940", Offset = "0x7B79D40", VA = "0x187B7A940", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? FOCNBFPNEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B7B210", Offset = "0x7B7A610", VA = "0x187B7B210", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? EOPGKCCPFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A570", Offset = "0x7B79970", VA = "0x187B7A570", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FOOOPOPDBKG BNMLAEBHIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBB23C0", Offset = "0xBB17C0", VA = "0x180BB23C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12684B0", Offset = "0x12678B0", VA = "0x1812684B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7B7B390", Offset = "0x7B7A790", VA = "0x187B7B390")]
	[RecRoom.NoEngine.Common.Preserve]
	public HHNGINFFDDO([MGCCDFKFGBG(null)] MGDFFFNAIOO LGDKKODIABC, [MGCCDFKFGBG(null)] EBPHMDLBLHI EBBHOONOGJP, [MGCCDFKFGBG(null)] MNNHDDKNOCP NEHAGNMHGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A7D0", Offset = "0x7B79BD0", VA = "0x187B7A7D0", Slot = "11")]
	public void ENMMELFAOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A9C0", Offset = "0x7B79DC0", VA = "0x187B7A9C0", Slot = "16")]
	public void IPALBIBGOPC(string MJNJLDPHMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A470", Offset = "0x7B79870", VA = "0x187B7A470", Slot = "12")]
	public void CMMIHCANGGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A470", Offset = "0x7B79870", VA = "0x187B7A470", Slot = "17")]
	public void ELANKOJGEOH([Optional] string MHILHNJDANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A470", Offset = "0x7B79870", VA = "0x187B7A470", Slot = "13")]
	public void DBLAENJJLIG(string GDODLHCOCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A150", Offset = "0x7B79550", VA = "0x187B7A150", Slot = "10")]
	public void CAMOELOHMMH(EFHLAGBCAMD FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B79FC0", Offset = "0x7B793C0", VA = "0x187B79FC0", Slot = "15")]
	public void BNNOOBLPDHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A6B0", Offset = "0x7B79AB0", VA = "0x187B7A6B0", Slot = "14")]
	[AsyncStateMachine(typeof(GGFFPGIIOHF))]
	public Task<FOOOPOPDBKG> EMBOFJAPGBA(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A1A0", Offset = "0x7B795A0", VA = "0x187B7A1A0")]
	private void CAPFFLJAEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A0E0", Offset = "0x7B794E0", VA = "0x187B7A0E0")]
	[MonoPInvokeCallback(typeof(FMFIAONFCHH))]
	private static void CADKDPEGNDG(string MJNJLDPHMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A4B0", Offset = "0x7B798B0", VA = "0x187B7A4B0")]
	[MonoPInvokeCallback(typeof(CKEFHABGAJE))]
	private static int DGMDDDBIHID()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B7B2A0", Offset = "0x7B7A6A0", VA = "0x187B7B2A0")]
	private void PKNAFOPANMJ(string GOBCDONNCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7B7AF80", Offset = "0x7B7A380", VA = "0x187B7AF80")]
	private void JIACDMPAFJP(FMFIAONFCHH IBDCICFCEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A430", Offset = "0x7B79830", VA = "0x187B7A430")]
	private void CMCKDBOGCBA(CKEFHABGAJE IBDCICFCEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A470", Offset = "0x7B79870", VA = "0x187B7A470")]
	private void CMMIHCANGGI(PBHJOJPADKB HJCCPGPOLBJ, string PEKFMJMPJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B7B170", Offset = "0x7B7A570", VA = "0x187B7B170")]
	private void OMMLPDNGKFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B7B1B0", Offset = "0x7B7A5B0", VA = "0x187B7B1B0")]
	private long? PFEHBODBOFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A510", Offset = "0x7B79910", VA = "0x187B7A510")]
	private long? DMKGGNHNDKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B7B020", Offset = "0x7B7A420", VA = "0x187B7B020")]
	private Guid? KEOAIBLEBDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7B7AFC0", Offset = "0x7B7A3C0", VA = "0x187B7AFC0")]
	private double? JMJGPKHFCNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7B7B090", Offset = "0x7B7A490", VA = "0x187B7B090")]
	internal static void KKAPEMAPMDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7ADF0", Offset = "0x7B7A1F0", VA = "0x187B7ADF0")]
	private void JFGHCIHILMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EPMGCHPDEKO
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B79710", Offset = "0x7B78B10", VA = "0x187B79710")]
	[ACPGCKDGGJH.EHOIKNIBKMA]
	internal static void EDMJPONJHMF(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7B79810", Offset = "0x7B78C10", VA = "0x187B79810")]
	[GEMHNPPGODB.JLNPPECHEJF]
	internal static void MLGOHAIDJAJ()
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

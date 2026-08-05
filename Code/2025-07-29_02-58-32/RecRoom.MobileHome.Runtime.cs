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
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8384680", Offset = "0x8383080", VA = "0x188384680", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8384800", Offset = "0x8383200", VA = "0x188384800", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MCBHDPNKPDK
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
public interface EGHGGKCBEFL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NGABAJDIKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? HJOPAELMOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? NEEGHEOEALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? GJEAJOOFOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? PPJOAGGMFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OLLFJIOOBON KJJBIHLPEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OKLIOGGEAPH(MCBHDPNKPDK BLKFHFCBEDC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ICNIAFDKEKI();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CFPBAFJEMFG();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LKKHFBAKKJL(string PKEPBFNDJEA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<OLLFJIOOBON> BDDDADLJOGN([Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DFOBFKNIKJD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BCMCKBKJAMO
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JGOBMNGDCJE : EGHGGKCBEFL
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum BEIIOCBGPLH
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void BMBADFICEHD(string MPNKMHPCACF);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int NBALBDDNOAB();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GAEOFPFPBLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<OLLFJIOOBON> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public JGOBMNGDCJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<OLLFJIOOBON> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<OLLFJIOOBON> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8382880", Offset = "0x8381280", VA = "0x188382880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8382EC0", Offset = "0x83818C0", VA = "0x188382EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly MEBJEIOEDLD GCLDEHJKFHJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static JGOBMNGDCJE PKGDNOOHCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly OADOONOPPPN EFOEDKKDJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MLKFEOENEPL MIABIFLBNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HGCEBKAFGFC OIBKHAEOLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool HEFCGONPEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MOKGKAADDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool AEJDHMMOBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? OECFIIJDJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool ADFMFBNMMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? DDPFMOODJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool HEIHELDCBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? NAEEGKAKDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private MCBHDPNKPDK KDKIBNJODAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object GHAJJMICNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<OLLFJIOOBON> LDFNBFKFEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<OLLFJIOOBON> ILJMAHMHOMF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NGABAJDIKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? HJOPAELMOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8384160", Offset = "0x8382B60", VA = "0x188384160", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? NEEGHEOEALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8383910", Offset = "0x8382310", VA = "0x188383910", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? GJEAJOOFOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8383EE0", Offset = "0x83828E0", VA = "0x188383EE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? PPJOAGGMFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8383D70", Offset = "0x8382770", VA = "0x188383D70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OLLFJIOOBON KJJBIHLPEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAEDCD0", Offset = "0xAEC6D0", VA = "0x180AEDCD0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAEB9B0", Offset = "0xAEA3B0", VA = "0x180AEB9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8384300", Offset = "0x8382D00", VA = "0x188384300")]
	[RecRoom.NoEngine.Common.Preserve]
	public JGOBMNGDCJE([LNLOHEINMEO(null)] OADOONOPPPN EFOEDKKDJDF, [LNLOHEINMEO(null)] MLKFEOENEPL MIABIFLBNOI, [LNLOHEINMEO(null)] HGCEBKAFGFC OIBKHAEOLEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8383C00", Offset = "0x8382600", VA = "0x188383C00", Slot = "11")]
	public void ICNIAFDKEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8382F30", Offset = "0x8381930", VA = "0x188382F30", Slot = "16")]
	public void ADOGODECDOO(string GFEIFADJHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x83834E0", Offset = "0x8381EE0", VA = "0x1883834E0", Slot = "12")]
	public void CFPBAFJEMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x83834E0", Offset = "0x8381EE0", VA = "0x1883834E0", Slot = "17")]
	public void BLPDDPIADNN([Optional] string NPNAGAGPODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83834E0", Offset = "0x8381EE0", VA = "0x1883834E0", Slot = "13")]
	public void LKKHFBAKKJL(string PKEPBFNDJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8384240", Offset = "0x8382C40", VA = "0x188384240", Slot = "10")]
	public void OKLIOGGEAPH(MCBHDPNKPDK BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x83837F0", Offset = "0x83821F0", VA = "0x1883837F0", Slot = "15")]
	public void DFOBFKNIKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x83833C0", Offset = "0x8381DC0", VA = "0x1883833C0", Slot = "14")]
	[AsyncStateMachine(typeof(GAEOFPFPBLC))]
	public Task<OLLFJIOOBON> BDDDADLJOGN(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8383520", Offset = "0x8381F20", VA = "0x188383520")]
	private void CKCFMIEMKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8384090", Offset = "0x8382A90", VA = "0x188384090")]
	[MonoPInvokeCallback(typeof(BMBADFICEHD))]
	private static void MBDIDPMEFCE(string GFEIFADJHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83841E0", Offset = "0x8382BE0", VA = "0x1883841E0")]
	[MonoPInvokeCallback(typeof(NBALBDDNOAB))]
	private static int OGAOLMFNEDE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8383990", Offset = "0x8382390", VA = "0x188383990")]
	private void EKEENNDCIMF(string LMPCCNJCIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8383F70", Offset = "0x8382970", VA = "0x188383F70")]
	private void LGJLMKICBOE(BMBADFICEHD EMBEDGKMMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x83837B0", Offset = "0x83821B0", VA = "0x1883837B0")]
	private void DCIEEBOGEID(NBALBDDNOAB EMBEDGKMMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x83834E0", Offset = "0x8381EE0", VA = "0x1883834E0")]
	private void CFPBAFJEMFG(BEIIOCBGPLH HDDLNGLMMKN, string KMODIFMOEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8383EA0", Offset = "0x83828A0", VA = "0x188383EA0")]
	private void JJJBDCBHAKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8383360", Offset = "0x8381D60", VA = "0x188383360")]
	private long? BAAFPGBDDEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8383BA0", Offset = "0x83825A0", VA = "0x188383BA0")]
	private long? GMMDLCEGIHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8383E30", Offset = "0x8382830", VA = "0x188383E30")]
	private Guid? JBOMGHKAIFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8384100", Offset = "0x8382B00", VA = "0x188384100")]
	private double? MDPGOGCJPKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8383FB0", Offset = "0x83829B0", VA = "0x188383FB0")]
	internal static void MAGEDHGBLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8383A10", Offset = "0x8382410", VA = "0x188383A10")]
	private void GAFAMIJPJOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KHNDFFBILHM
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8384580", Offset = "0x8382F80", VA = "0x188384580")]
	[PPMDKOHJEBA.KMGFFEOOKKA]
	internal static void LOAFDMHCDPA(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8384480", Offset = "0x8382E80", VA = "0x188384480")]
	[MNIIDFGFPJH.NIOOHGGENHL]
	internal static void BFDFDIBLCKC()
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

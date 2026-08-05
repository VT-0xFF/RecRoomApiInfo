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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2450", Offset = "0x7CE1450", VA = "0x187CE2450", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE25D0", Offset = "0x7CE15D0", VA = "0x187CE25D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IBMJPPCNENK
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
public interface MEJJLIAPEGO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PNNPAHOFFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? IJKKHADEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? MFCDHCGBFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? ENELNKECLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? ODMKPLGHHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BFLGLOAKMLK IBAOJCGPCIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NCGEOCLFGIM(IBMJPPCNENK IDAKFFICKHC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ANJKPBDKBKO();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LEOJGIFFNGE();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OHADIFDEBBE(string NCGJCKHFLGN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<BFLGLOAKMLK> KIGOCPGNDJA([Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CABPGINNDIB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BNAENKKPJFB
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DFBEMFNMLHO : MEJJLIAPEGO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum LGGGJMJFDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void PMAHHGCIOHA(string MJJGACADIKD);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int CJPNCCHMJEN();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BGPIFIDMMFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<BFLGLOAKMLK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public DFBEMFNMLHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<BFLGLOAKMLK> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<BFLGLOAKMLK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7CE0660", Offset = "0x7CDF660", VA = "0x187CE0660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7CE0CA0", Offset = "0x7CDFCA0", VA = "0x187CE0CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly JBBHIJHGEPM AHIMDJPCPBN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static DFBEMFNMLHO ELJDCHFNJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly LPGGOLFFKPF IKPDGGJCBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EDGGJKNOCEO DHNGNBLIOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GPNPIENJPLA AMLPPMJNIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool OAPNFMJEJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool JABMMDDHHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool PDHBHHCFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? HJDMFEDNIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool CLICCCLCPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? ODFJDCPHDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool DIBFJHLNPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? KFIGKGDHHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private IBMJPPCNENK DHLBONIGPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object JOMBCDCAOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<BFLGLOAKMLK> NCAAAOCOCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<BFLGLOAKMLK> OHKFEOKHAAL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PNNPAHOFFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? IJKKHADEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7CE0D10", Offset = "0x7CDFD10", VA = "0x187CE0D10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? MFCDHCGBFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7CE1A20", Offset = "0x7CE0A20", VA = "0x187CE1A20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? ENELNKECLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7CE1950", Offset = "0x7CE0950", VA = "0x187CE1950", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? ODMKPLGHHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7CE1110", Offset = "0x7CE0110", VA = "0x187CE1110", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BFLGLOAKMLK IBAOJCGPCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBDE270", Offset = "0xBDD270", VA = "0x180BDE270", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12CD960", Offset = "0x12CC960", VA = "0x1812CD960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7CE20E0", Offset = "0x7CE10E0", VA = "0x187CE20E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DFBEMFNMLHO([DJIFKCCBBND(null)] LPGGOLFFKPF IKPDGGJCBAM, [DJIFKCCBBND(null)] EDGGJKNOCEO DHNGNBLIOEP, [DJIFKCCBBND(null)] GPNPIENJPLA AMLPPMJNIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0E40", Offset = "0x7CDFE40", VA = "0x187CE0E40", Slot = "11")]
	public void ANJKPBDKBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE11D0", Offset = "0x7CE01D0", VA = "0x187CE11D0", Slot = "16")]
	public void GDEBDJMNPAH(string DODIBCABBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE19E0", Offset = "0x7CE09E0", VA = "0x187CE19E0", Slot = "12")]
	public void LEOJGIFFNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE19E0", Offset = "0x7CE09E0", VA = "0x187CE19E0", Slot = "17")]
	public void HJNDFKCMFBB([Optional] string MAEKHPDHHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE19E0", Offset = "0x7CE09E0", VA = "0x187CE19E0", Slot = "13")]
	public void OHADIFDEBBE(string NCGJCKHFLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1DB0", Offset = "0x7CE0DB0", VA = "0x187CE1DB0", Slot = "10")]
	public void NCGEOCLFGIM(IBMJPPCNENK IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0FB0", Offset = "0x7CDFFB0", VA = "0x187CE0FB0", Slot = "15")]
	public void CABPGINNDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1AA0", Offset = "0x7CE0AA0", VA = "0x187CE1AA0", Slot = "14")]
	[AsyncStateMachine(typeof(BGPIFIDMMFP))]
	public Task<BFLGLOAKMLK> KIGOCPGNDJA(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1660", Offset = "0x7CE0660", VA = "0x187CE1660")]
	private void GLEJMDJPJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1F20", Offset = "0x7CE0F20", VA = "0x187CE1F20")]
	[MonoPInvokeCallback(typeof(PMAHHGCIOHA))]
	private static void PAHDCODNEEP(string DODIBCABBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1600", Offset = "0x7CE0600", VA = "0x187CE1600")]
	[MonoPInvokeCallback(typeof(CJPNCCHMJEN))]
	private static int GECFCKMDBBJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1F90", Offset = "0x7CE0F90", VA = "0x187CE1F90")]
	private void PGPPKENPOOI(string PCCOJPIHKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0E00", Offset = "0x7CDFE00", VA = "0x187CE0E00")]
	private void AGAIILOCMPP(PMAHHGCIOHA COLEJLDPDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1E00", Offset = "0x7CE0E00", VA = "0x187CE1E00")]
	private void OAJEHDLIMHI(CJPNCCHMJEN COLEJLDPDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CE19E0", Offset = "0x7CE09E0", VA = "0x187CE19E0")]
	private void LEOJGIFFNGE(LGGGJMJFDJJ DKBCGBFNIGO, string POINMCJGEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CE10D0", Offset = "0x7CE00D0", VA = "0x187CE10D0")]
	private void DHLFHHEAGCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2010", Offset = "0x7CE1010", VA = "0x187CE2010")]
	private long? PMJNJHIEOBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE18F0", Offset = "0x7CE08F0", VA = "0x187CE18F0")]
	private long? HBLADACOFPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0D90", Offset = "0x7CDFD90", VA = "0x187CE0D90")]
	private Guid? AEIGMEACOCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1D50", Offset = "0x7CE0D50", VA = "0x187CE1D50")]
	private double? MENMNLKLIOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1E40", Offset = "0x7CE0E40", VA = "0x187CE1E40")]
	internal static void OJMMAMJAFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1BC0", Offset = "0x7CE0BC0", VA = "0x187CE1BC0")]
	private void LGIEIFOHPFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DOJAGDBFEJE
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2260", Offset = "0x7CE1260", VA = "0x187CE2260")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void IIICHJGEEFG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2350", Offset = "0x7CE1350", VA = "0x187CE2350")]
	[FHOLJFNIKPC.CJBPAKNLBCK]
	internal static void PPNIOEPNBEO()
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

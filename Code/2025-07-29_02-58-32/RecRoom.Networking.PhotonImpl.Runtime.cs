using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Voice.PUN;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x841C140", Offset = "0x841AB40", VA = "0x18841C140")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NetworkProfiler : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
	public NetworkProfiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class HANCCBFLEJK : NDGFICGAFID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EventData EOOLELFGEAP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EventData HMLFFMGHGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte ECFFFCOHNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x237BD30", Offset = "0x237A730", VA = "0x18237BD30", Slot = "4")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GHKKOHGBCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84117B0", Offset = "0x84101B0", VA = "0x1884117B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public object LKCAPNFOLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8411770", Offset = "0x8410170", VA = "0x188411770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public object EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8411790", Offset = "0x8410190", VA = "0x188411790", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public HANCCBFLEJK(EventData EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84117D0", Offset = "0x84101D0", VA = "0x1884117D0", Slot = "8")]
	public bool PKNEHCKDABA(byte LNBCHJPEENA, [Out] object PDKJBMPOMNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LMDIGPEBMLF : NJHBDKAEOIG, JEJOFHIOJBA, OJFIFCBMMIN, MBGCJNMBOPE, HEJKJBPJGII, PCHEMBGLEFG, NFEEIPGCNPI, MLEFAKFGCOD, GLACHBKCAEF, HJJGIKHHHGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class HCOCBKHCPKO : EFEDOCDCLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HNPOKJACJND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public HNPOKJACJND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7994990", Offset = "0x7993390", VA = "0x187994990")]
			internal void PMDOEAGBEOB(MBGDIBDLJEL rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool OOOKLMALEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8411800", Offset = "0x8410200", VA = "0x188411800", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool KLPFOOIMHNB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8411BC0", Offset = "0x84105C0", VA = "0x188411BC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public IReadOnlyList<(string code, int ping)> MFKJLOLPNLL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8411990", Offset = "0x8410390", VA = "0x188411990", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8411870", Offset = "0x8410270", VA = "0x188411870", Slot = "7")]
		public bool EBCNOMBBNMO(Action ILGIJLCLOED, string DPMIBJOACCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HCOCBKHCPKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly Hashtable DCOGOCJGMIA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly SendOptions DPODOMALPNA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly SendOptions EKIKHPICFIB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly SendOptions EDMOFGPOBKC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly SendOptions EMOEGLPGJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private ABOLDNGEPMH PLDMOABLNOF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static readonly byte[] ELJHANONHNC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PFFNFAKJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xF8FD60", Offset = "0xF8E760", VA = "0x180F8FD60", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override ABOLDNGEPMH PMNCIHHAEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OIKIFLPPAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8417E80", Offset = "0x8416880", VA = "0x188417E80", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool BMDKOGAEJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8416C00", Offset = "0x8415600", VA = "0x188416C00", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public POIAKMBAMML DCPOHCODDJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8417760", Offset = "0x8416160", VA = "0x188417760", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MELALFNNJBH LIFOGMBKHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84193C0", Offset = "0x8417DC0", VA = "0x1884193C0", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override bool KLLGBFGKBCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84186F0", Offset = "0x84170F0", VA = "0x1884186F0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84197E0", Offset = "0x84181E0", VA = "0x1884197E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override float NOHPIMNCOHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8418DA0", Offset = "0x84177A0", VA = "0x188418DA0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8417F00", Offset = "0x8416900", VA = "0x188417F00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public EFEDOCDCLLJ MMBHDBAHEOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA841B0", Offset = "0xA82BB0", VA = "0x180A841B0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool NFKMLGNELAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8418470", Offset = "0x8416E70", VA = "0x188418470", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84183C0", Offset = "0x8416DC0", VA = "0x1884183C0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DPBAIDIKFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8416D90", Offset = "0x8415790", VA = "0x188416D90", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool PKMBIMMCECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8417340", Offset = "0x8415D40", VA = "0x188417340", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public object PKLOJMLBENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84172A0", Offset = "0x8415CA0", VA = "0x1884172A0", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool PCLMHBIDBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8419470", Offset = "0x8417E70", VA = "0x188419470", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int MBNGHCGPNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8417890", Offset = "0x8416290", VA = "0x188417890", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int KKIBBDHBBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8416B90", Offset = "0x8415590", VA = "0x188416B90", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int CDOIJDLCCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8417C70", Offset = "0x8416670", VA = "0x188417C70", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public POIAKMBAMML PFBPJPFKPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8418050", Offset = "0x8416A50", VA = "0x188418050", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int KOPKFBLHDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8419340", Offset = "0x8417D40", VA = "0x188419340", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int KLGGNHHHJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84189A0", Offset = "0x84173A0", VA = "0x1884189A0", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool APCPMJALFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8418540", Offset = "0x8416F40", VA = "0x188418540", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string JCCCODLMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8416F90", Offset = "0x8415990", VA = "0x188416F90", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Func<string, string> GNNMFBDCHFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8419510", Offset = "0x8417F10", VA = "0x188419510", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int EHNJNKCPIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8419760", Offset = "0x8418160", VA = "0x188419760", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public double POFCFOMDDEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8417E40", Offset = "0x8416840", VA = "0x188417E40", Slot = "36")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int DJOGOIHHKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8417F50", Offset = "0x8416950", VA = "0x188417F50", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BJOGBHJDFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8417140", Offset = "0x8415B40", VA = "0x188417140", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string PHMGCEJGANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8416F50", Offset = "0x8415950", VA = "0x188416F50", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long NELMCHACADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8418500", Offset = "0x8416F00", VA = "0x188418500", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long JNFIOFALDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8417100", Offset = "0x8415B00", VA = "0x188417100", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool AGIFEOHHMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8419830", Offset = "0x8418230", VA = "0x188419830", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<POIAKMBAMML> PLJMNGGJIOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8419290", Offset = "0x8417C90", VA = "0x188419290", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84177E0", Offset = "0x84161E0", VA = "0x1884177E0", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<ABOLDNGEPMH, ABOLDNGEPMH> KKEDKEODHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8418640", Offset = "0x8417040", VA = "0x188418640", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8417530", Offset = "0x8415F30", VA = "0x188417530", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<NDGFICGAFID> DGLLFHDDKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8417950", Offset = "0x8416350", VA = "0x188417950", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84175E0", Offset = "0x8415FE0", VA = "0x1884175E0", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8418890", Offset = "0x8417290", VA = "0x188418890", Slot = "45")]
	public void MEJDBBHGBIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84171A0", Offset = "0x8415BA0", VA = "0x1884171A0")]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	internal static void CPNCCEEHJEL(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8419AB0", Offset = "0x84184B0", VA = "0x188419AB0")]
	[UnityEngine.Scripting.Preserve]
	public LMDIGPEBMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8416E50", Offset = "0x8415850", VA = "0x188416E50")]
	private void BFKDEKGPOAG(bool HBCPACHDPHM, bool NNMFGLNDLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8419410", Offset = "0x8417E10", VA = "0x188419410", Slot = "17")]
	public float OBHOBDKBMBB(bool OOBPCOKFEGC, int FMFLCJJNLFD = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8417690", Offset = "0x8416090", VA = "0x188417690", Slot = "82")]
	[CanBeNull]
	public POIAKMBAMML EHOJGGNNPOI(int OGACJNJBOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8417BA0", Offset = "0x84165A0", VA = "0x188417BA0", Slot = "84")]
	public POIAKMBAMML FNOFDDLJCKF(int OGACJNJBOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8416CD0", Offset = "0x84156D0", VA = "0x188416CD0", Slot = "83")]
	[CanBeNull]
	public POIAKMBAMML AHONALBBPDC(int LHPHKGMDHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8418370", Offset = "0x8416D70", VA = "0x188418370", Slot = "85")]
	public IReadOnlyList<POIAKMBAMML> JBKMDMCDAIH(bool HCHBGGHKOHP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84194C0", Offset = "0x8417EC0", VA = "0x1884194C0", Slot = "86")]
	public IReadOnlyList<POIAKMBAMML> ODIHBBCFFJA(bool HCHBGGHKOHP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8417900", Offset = "0x8416300", VA = "0x188417900", Slot = "87")]
	public bool FKCGABJOAIE(POIAKMBAMML JJGEFLDDLHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8418E50", Offset = "0x8417850", VA = "0x188418E50")]
	private static short NIPAELJLKII(StreamBuffer EPKIIEEFOOG, object OHLHBFADLBG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8417A00", Offset = "0x8416400", VA = "0x188417A00")]
	private static object FMGMPEBEMKM(StreamBuffer JLHIEMEEOOL, short KLLLBPFLPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8417380", Offset = "0x8415D80", VA = "0x188417380", Slot = "96")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8417050", Offset = "0x8415A50", VA = "0x188417050", Slot = "56")]
	public bool CECKAHLMJBL(object AGLELHDJFHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84177A0", Offset = "0x84161A0", VA = "0x1884177A0", Slot = "55")]
	public void FGLGBKHFALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8418190", Offset = "0x8416B90", VA = "0x188418190", Slot = "53")]
	public bool IMGDJEHDCNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8419570", Offset = "0x8417F70", VA = "0x188419570", Slot = "18")]
	public bool OMOBNNIPDKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8417720", Offset = "0x8416120", VA = "0x188417720", Slot = "8")]
	public override void EKNOFCDOAFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8418DE0", Offset = "0x84177E0", VA = "0x188418DE0", Slot = "20")]
	public void NIJFNJBICBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8417CB0", Offset = "0x84166B0", VA = "0x188417CB0", Slot = "21")]
	public void FPFOBCACBJL(List<object> CKDFPBCCFHO, int EMMDOKDGNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8418780", Offset = "0x8417180", VA = "0x188418780", Slot = "22")]
	public void MEFGCJOBBHD(int IGFMPONHNDC, object EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8418F00", Offset = "0x8417900", VA = "0x188418F00", Slot = "23")]
	public void NKMPJEIHMAP(IDictionary<object, object> FNPCEKCMMCN, int PCJBPIKLFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8418A20", Offset = "0x8417420", VA = "0x188418A20", Slot = "70")]
	public bool NFDKLIAMEJI(byte JBJEMPGNJPD, object DBCENLDHIPJ, LFCPHBACBIP KAFJCIDDMMN, DLFBKNHNOAP JHLCIINJOPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8418090", Offset = "0x8416A90", VA = "0x188418090", Slot = "54")]
	public bool ILLKLKDFOHB(string IAFDMNLJOII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84195B0", Offset = "0x8417FB0", VA = "0x1884195B0", Slot = "35")]
	public void PABKMLJNKHK(string OIBIKPIBLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8417EC0", Offset = "0x84168C0", VA = "0x188417EC0", Slot = "27")]
	public void IAIPAHPGAIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8416C40", Offset = "0x8415640", VA = "0x188416C40", Slot = "28")]
	public void AGNKEKDJGCC(object CEFJEHJNIAP, NativeList<byte> GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84182F0", Offset = "0x8416CF0", VA = "0x1884182F0", Slot = "29")]
	public object JBBKNKCPLNK(NativeArray<byte> GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8418410", Offset = "0x8416E10", VA = "0x188418410", Slot = "81")]
	public void KEGLJMKAJJM(string FLBFBHGDBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8417F90", Offset = "0x8416990", VA = "0x188417F90", Slot = "30")]
	public int IIHINMBAJJL(NDGFICGAFID EOOLELFGEAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8419890", Offset = "0x8418290", VA = "0x188419890", Slot = "95")]
	public int PPCDHMPHIEO()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8404040", Offset = "0x8402A40", VA = "0x188404040", Slot = "11")]
	private void JJPDKGEMFMN(Action PDKJBMPOMNC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84031B0", Offset = "0x8401BB0", VA = "0x1884031B0", Slot = "12")]
	private void AOGCKMFMHOK(Action PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8404030", Offset = "0x8402A30", VA = "0x188404030", Slot = "25")]
	private void JIHJLNEAONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8404070", Offset = "0x8402A70", VA = "0x188404070", Slot = "26")]
	private void JLLCLFNBKBC()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8404080", Offset = "0x8402A80", VA = "0x188404080", Slot = "31")]
	private void JOBGMMAKMDP(float PDKJBMPOMNC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8403C00", Offset = "0x8402600", VA = "0x188403C00", Slot = "32")]
	private void FOHFJCBMOFK(float PDKJBMPOMNC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84041C0", Offset = "0x8402BC0", VA = "0x1884041C0", Slot = "57")]
	private void KHGKMPEFFGD(Action<bool> PDKJBMPOMNC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8403190", Offset = "0x8401B90", VA = "0x188403190", Slot = "58")]
	private void AKMIABGLBIP(Action<bool> PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8403E70", Offset = "0x8402870", VA = "0x188403E70", Slot = "59")]
	private void IHNLCHMNHPG(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84031A0", Offset = "0x8401BA0", VA = "0x1884031A0", Slot = "60")]
	private void AOFNNBFFBGE(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84043B0", Offset = "0x8402DB0", VA = "0x1884043B0", Slot = "61")]
	private void LEFFMMLKMEH(object DHNMCOFINFM, bool BNIIJGIOPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84036D0", Offset = "0x84020D0", VA = "0x1884036D0", Slot = "62")]
	private IDisposable EJDEHFEPOPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84047E0", Offset = "0x84031E0", VA = "0x1884047E0", Slot = "63")]
	private bool OFIIDGPBMGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8404940", Offset = "0x8403340", VA = "0x188404940", Slot = "64")]
	private void PMOPECMEAHB(StringBuilder IPBAIMPPDKA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8403E60", Offset = "0x8402860", VA = "0x188403E60", Slot = "66")]
	private void IHCCEDOOENG(Action<string, long> PDKJBMPOMNC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84036E0", Offset = "0x84020E0", VA = "0x1884036E0", Slot = "67")]
	private void EKMNGFJGJDD(Action<string, long> PDKJBMPOMNC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8403440", Offset = "0x8401E40", VA = "0x188403440", Slot = "88")]
	private void CKDCNEKPJML(Action PDKJBMPOMNC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8403C90", Offset = "0x8402690", VA = "0x188403C90", Slot = "89")]
	private void HPCBKIDCOBF(Action PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8404910", Offset = "0x8403310", VA = "0x188404910", Slot = "90")]
	private void PKBOAHKOLPG()
	{
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8419D10", Offset = "0x8418710", VA = "0x188419D10", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x841CE10", Offset = "0x841B810", VA = "0x18841CE10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DCAKOBCCBDF : CFFBOIMLCAG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CFFBOIMLCAG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	NOJPLHNOJFK FIEBDEOKAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string ODKBBMBALGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Task MNFFMHFCABI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JPNPGCFPPLJ(NOJPLHNOJFK DEGDBDLIAHB);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FGLGBKHFALG([Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<NOJPLHNOJFK> NINKAOHACPP(NOJPLHNOJFK DEGDBDLIAHB, object AHLBPAOAMLM, [Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task FEECECEKCIB([Optional] CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FIOGAGIEFCF(FDKDBBELKJM PPNELMIEOOA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal interface EDNBBFBJOGA
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAJHJECEOPI(ushort NDLCMBGHPGB, LGOMHPHOKEA CEPKLDFFHEJ, params object[] EMIIKMMLNFK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal enum LGOMHPHOKEA
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Disconnect_AlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Disconnect_AlreadyDisconnected,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DisconnectInternal,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	DisconnectInternalTask,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	DisconnectInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	DisconnectFromRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DisconnectFromRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DisconnectFromRoomInstance_LeavingAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DisconnectFromRoomInstance_AlreadyLeftRoom,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DisconnectFromRoomInstanceInternal_BeforeLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DisconnectFromRoomInstanceInternal_AfterLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DisconnectFromRoomInstanceInternal_LeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisconnectFromRoomInstanceInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	ConnectToRegion,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ConnectToRegion_AddedAuthValues,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	ConnectToRegion_ConnectToRegionInternal,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	ConnectToRegion_ConnectToRegionInternalTask,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	ConnectToRegion_EnteredOfflineMode,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ConnectToRegion_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConnectToRegion_AlreadyConnected,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ConnectToRegion_DisconnectDueToCancellation,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ConnectToRegion_DisconnectDueToError,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ConnectToRegion_Connected,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ConnectWithAppSettings,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	ConnectToRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ConnectToRoomInstance_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ConnectToRoomInstance_AlreadyInRoom,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ConnectToRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ConnectToRoomInstanceInternal_Connected
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface APKPGOLLIMG : CFFBOIMLCAG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MOAOJJNBNKD PDJDKPDMGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MOAOJJNBNKD : DCAKOBCCBDF, CFFBOIMLCAG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> HEAMENBJFOP([Optional] TimeSpan? PGIHKJKOICJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BFFKIHPKLHB
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool GFMCAHEALEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	TimeSpan GOPEIHAFKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	TimeSpan AFADBNADANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object EPDEDHHBPKE(ABEGKALIIKC INAAJKILLBO);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NFPDMOICOLM NOFNABINGGK(ABEGKALIIKC INAAJKILLBO);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<ABEGKALIIKC> GPKMANHNEOI(CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PGMCFKBIHHO
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HPDJJKCNBLF PGDOELFBDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string EIOCBGFGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string POKCGFOBPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> GICELHOJFCE(string PHAHOKBOMHE, string PHAIPANOFOJ, string IAKDDGHFHLI);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task FGLGBKHFALG([Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal static class MFKEMCBLKJK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class DEHOIMDHPHB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Action<string, AFFODCPMGIK> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public ABOLDNGEPMH networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public MLEFAKFGCOD networking;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public DEHOIMDHPHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7DD0", Offset = "0x6FF67D0", VA = "0x186FF7DD0")]
		internal void EEBIINDAHNF(ODAHNAOHLPJ disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7850", Offset = "0x6FF6250", VA = "0x186FF7850")]
		internal void AHDCKNHIPJB(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7BB0", Offset = "0x6FF65B0", VA = "0x186FF7BB0")]
		internal void BDOIIJGLPNL(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HKOIEEBDIPL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public MLEFAKFGCOD networking;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HKOIEEBDIPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x50547F0", Offset = "0x50531F0", VA = "0x1850547F0")]
		internal void FKLBJBJHIPC(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5054D00", Offset = "0x5053700", VA = "0x185054D00")]
		internal void KCPFIKDCOIE(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5054950", Offset = "0x5053350", VA = "0x185054950")]
		internal void IENIKPAIFEN(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3DAC1A0", Offset = "0x3DAABA0", VA = "0x183DAC1A0")]
	public static void DMFDDBKCBMM<T>(this MLEFAKFGCOD HFINBJNJOEI, TaskCompletionSource<T> ALJABHEDHBP, [NotNull] ABOLDNGEPMH FCJKDELLNBL, AFFODCPMGIK GCHJLMBOALO, bool FDIHDIFMIHL, Action<string, AFFODCPMGIK> HJHMNJLNNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3DAC900", Offset = "0x3DAB300", VA = "0x183DAC900")]
	public static void NNNGLOPNCDK<T>(this MLEFAKFGCOD HFINBJNJOEI, TaskCompletionSource<T> ALJABHEDHBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class AJJLLMHFBAI<TNetworking> : DCAKOBCCBDF, CFFBOIMLCAG, IDisposable where TNetworking : class, OJFIFCBMMIN, MBGCJNMBOPE
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class CIHAFNIHGEF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private struct <<ConnectToRegionInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public AsyncTaskMethodBuilder<ABEGKALIIKC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public CIHAFNIHGEF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private TaskAwaiter<ABEGKALIIKC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4463990", Offset = "0x4462390", VA = "0x184463990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4463D00", Offset = "0x4462700", VA = "0x184463D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public ABEGKALIIKC photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CIHAFNIHGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6A405A0", Offset = "0x6A3EFA0", VA = "0x186A405A0")]
		[AsyncStateMachine(typeof(AJJLLMHFBAI<>.CIHAFNIHGEF.<<ConnectToRegionInternal>b__0>d))]
		internal Task<ABEGKALIIKC> LOEENHFIBOL(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct MJMDAGNPLCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<ABEGKALIIKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ABEGKALIIKC photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private CIHAFNIHGEF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<ABEGKALIIKC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5833E30", Offset = "0x5832830", VA = "0x185833E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5834A20", Offset = "0x5833420", VA = "0x185834A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct LIKPDHAEIPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<ABEGKALIIKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public ABEGKALIIKC photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5610D10", Offset = "0x560F710", VA = "0x185610D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5611990", Offset = "0x5610390", VA = "0x185611990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct BDLFMOJHHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x64B5850", Offset = "0x64B4250", VA = "0x1864B5850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x64B5AA0", Offset = "0x64B44A0", VA = "0x1864B5AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct KMOOBJLFFHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private AFFODCPMGIK <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5502960", Offset = "0x5501360", VA = "0x185502960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5502E80", Offset = "0x5501880", VA = "0x185502E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DAIKBIBELNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public DAIKBIBELNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA0E0", Offset = "0x6FE8AE0", VA = "0x186FEA0E0")]
		internal Task<bool> OMJHEGDOKEM(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct OOOFGMBJKDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private DAIKBIBELNI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private bool <isCurrentlyOfflineMode>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5A32190", Offset = "0x5A30B90", VA = "0x185A32190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5A32FB0", Offset = "0x5A319B0", VA = "0x185A32FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AMACJLLOAKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TaskCompletionSource<ODAHNAOHLPJ> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AMACJLLOAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5316720", Offset = "0x5315120", VA = "0x185316720")]
		internal void OFEGFODBIAF(ODAHNAOHLPJ disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5316650", Offset = "0x5315050", VA = "0x185316650")]
		internal void EHCMPOIAIEG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct LBFKHCBIMEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private AMACJLLOAKM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<ODAHNAOHLPJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5581660", Offset = "0x5580060", VA = "0x185581660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5582E00", Offset = "0x5581800", VA = "0x185582E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct BOGMGPNOJBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder<NOJPLHNOJFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NOJPLHNOJFK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private AFFODCPMGIK <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<NOJPLHNOJFK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x65B15E0", Offset = "0x65AFFE0", VA = "0x1865B15E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x65B2230", Offset = "0x65B0C30", VA = "0x1865B2230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class AFACKJCELGF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private struct <<ConnectToRoomInstanceInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AsyncTaskMethodBuilder<NOJPLHNOJFK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public AFACKJCELGF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private TaskAwaiter<NOJPLHNOJFK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x4463D70", Offset = "0x4462770", VA = "0x184463D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4464100", Offset = "0x4462B00", VA = "0x184464100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public NOJPLHNOJFK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AFACKJCELGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5236630", Offset = "0x5235030", VA = "0x185236630")]
		[AsyncStateMachine(typeof(AJJLLMHFBAI<>.AFACKJCELGF.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<NOJPLHNOJFK> OOFFNKOKIAM(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct CPILIBAIPCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AsyncTaskMethodBuilder<NOJPLHNOJFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public NOJPLHNOJFK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private AFACKJCELGF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<NOJPLHNOJFK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F4C0", Offset = "0x6A4DEC0", VA = "0x186A4F4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A50260", Offset = "0x6A4EC60", VA = "0x186A50260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class GCLMBFOCNBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TaskCompletionSource<EFMILOODCJD> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GCLMBFOCNBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4F46C60", Offset = "0x4F45660", VA = "0x184F46C60")]
		internal void ECEONMIJOGK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct FNKJDPOKIKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<NOJPLHNOJFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public NOJPLHNOJFK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private GCLMBFOCNBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Action <trySetResAction>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<ABEGKALIIKC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<EFMILOODCJD> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4E49860", Offset = "0x4E48260", VA = "0x184E49860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BBA0", Offset = "0x4E4A5A0", VA = "0x184E4BBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct CGNKKKEJMAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Task<ACDCHJGLGPC> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<ACDCHJGLGPC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A37570", Offset = "0x6A35F70", VA = "0x186A37570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct HJLEGINBKDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5050AB0", Offset = "0x504F4B0", VA = "0x185050AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5050CF0", Offset = "0x504F6F0", VA = "0x185050CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct MOJCEBCHEAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private AFFODCPMGIK <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x58471D0", Offset = "0x5845BD0", VA = "0x1858471D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5847650", Offset = "0x5846050", VA = "0x185847650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct CJMAKNMCIAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A471A0", Offset = "0x6A45BA0", VA = "0x186A471A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A47970", Offset = "0x6A46370", VA = "0x186A47970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EGNKKMDCEMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public EGNKKMDCEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4936B80", Offset = "0x4935580", VA = "0x184936B80")]
		internal Task<ACDCHJGLGPC> NILJECOHGLG(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NAJIHODNEBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private EGNKKMDCEMG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TaskAwaiter<ACDCHJGLGPC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x589E260", Offset = "0x589CC60", VA = "0x18589E260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x589ED80", Offset = "0x589D780", VA = "0x18589ED80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class KIIFKJODHAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public TaskCompletionSource<EFMILOODCJD> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KIIFKJODHAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x54F7440", Offset = "0x54F5E40", VA = "0x1854F7440")]
		internal void MLBBIIEJCOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x54F73B0", Offset = "0x54F5DB0", VA = "0x1854F73B0")]
		internal void GGHHLCGLMOJ(ODAHNAOHLPJ disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x54F7170", Offset = "0x54F5B70", VA = "0x1854F7170")]
		internal void EEHFHOMKPHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FKJHJBKGPKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public TaskCompletionSource<EFMILOODCJD> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public KIIFKJODHAC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FKJHJBKGPKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4E1F700", Offset = "0x4E1E100", VA = "0x184E1F700")]
		internal void PNJJPOLNFLL(ODAHNAOHLPJ disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4E1F660", Offset = "0x4E1E060", VA = "0x184E1F660")]
		internal void OAJGDGBGLBK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct GLOPNOAGKGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public AsyncTaskMethodBuilder<ACDCHJGLGPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private KIIFKJODHAC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private FKJHJBKGPKH <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter<EFMILOODCJD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4FB3B60", Offset = "0x4FB2560", VA = "0x184FB3B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4FB5E20", Offset = "0x4FB4820", VA = "0x184FB5E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class MHPIOMHDCLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public TaskCompletionSource<EFMILOODCJD> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MHPIOMHDCLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x582A470", Offset = "0x5828E70", VA = "0x18582A470")]
		internal string HKLNHCOCFGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x582A380", Offset = "0x5828D80", VA = "0x18582A380")]
		internal void FHEHJBOBGGC(EFMILOODCJD _1, EFMILOODCJD _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DGALPKMFPNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncTaskMethodBuilder<EFMILOODCJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private MHPIOMHDCLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter<EFMILOODCJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAE10", Offset = "0x6FF9810", VA = "0x186FFAE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6FFBB30", Offset = "0x6FFA530", VA = "0x186FFBB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DPCMIJGONFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x449B2D0", Offset = "0x4499CD0", VA = "0x18449B2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct CJGPLAGNKHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A46D00", Offset = "0x6A45700", VA = "0x186A46D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A47140", Offset = "0x6A45B40", VA = "0x186A47140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct DMAJHEDGMGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public ODAHNAOHLPJ disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private CEJJBMEAKLM <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x703CCB0", Offset = "0x703B6B0", VA = "0x18703CCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct EFNCDGICEPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public ODAHNAOHLPJ disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private HashSet<FDKDBBELKJM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4930220", Offset = "0x492EC20", VA = "0x184930220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4930C60", Offset = "0x492F660", VA = "0x184930C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct HODPCECAKKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private HashSet<ALBCKHPLACE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x506FD50", Offset = "0x506E750", VA = "0x18506FD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5070240", Offset = "0x506EC40", VA = "0x185070240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class PHGIGDEAMHE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PHGIGDEAMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		internal string HAJAGBAHLAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class ANJKNPLDBCH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public MNANMEOHPNL.NGCGFNGNPLB timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ANJKNPLDBCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5319200", Offset = "0x5317C00", VA = "0x185319200")]
		internal void INOHFBHOGIM(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5318EF0", Offset = "0x53178F0", VA = "0x185318EF0")]
		internal BCFHFAAGNAO BJKAELIOEAE(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class GBKDELFFEBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public TaskCompletionSource<EFMILOODCJD> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GBKDELFFEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4F424E0", Offset = "0x4F40EE0", VA = "0x184F424E0")]
		internal void HEMBCJNEHCF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct EGFBKFFONHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private GBKDELFFEBN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public EFMILOODCJD connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public object appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private TaskAwaiter<EFMILOODCJD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4932990", Offset = "0x4931390", VA = "0x184932990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4933CE0", Offset = "0x49326E0", VA = "0x184933CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CNKEINBOIKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CNKEINBOIKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6A4BB80", Offset = "0x6A4A580", VA = "0x186A4BB80")]
		internal object OBFDJHFFLGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NKDECBLPDFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NKDECBLPDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x58C3E10", Offset = "0x58C2810", VA = "0x1858C3E10")]
		internal object BOFOBHJFNCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class LAHJOBNKNBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AJJLLMHFBAI<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LAHJOBNKNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x557ECF0", Offset = "0x557D6F0", VA = "0x18557ECF0")]
		internal object GPNNADCHCFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly EDNBBFBJOGA DDONKNLECJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly GJHIFAKEEEG OCKJAHDHPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected readonly string ADIIGAGPGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected readonly BFFKIHPKLHB PMCGEIKOCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private TaskCompletionSource<ACDCHJGLGPC> NDCMEPPBJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected internal readonly TNetworking ODCAIOEMKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private ushort MJOMGJJGCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private ACAIEIAAFEK<ABEGKALIIKC> CMLFLCFCBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private ACAIEIAAFEK<bool> DDBBGLCHAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private ACAIEIAAFEK<NOJPLHNOJFK> FJLIMFALEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private ACAIEIAAFEK<ACDCHJGLGPC> POKFDHOOHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private bool BLLGCKOFDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool PEKGEJAAKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly HashSet<ALBCKHPLACE> AEGNMGLFBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HashSet<FDKDBBELKJM> NJOBGMEJODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool JNAAJFKIBLB;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PKMBIMMCECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x530AC90", Offset = "0x5309690", VA = "0x18530AC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[CanBeNull]
	public NOJPLHNOJFK FIEBDEOKAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x530AE60", Offset = "0x5309860", VA = "0x18530AE60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected EFMILOODCJD JIDCKHGPMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x530C540", Offset = "0x530AF40", VA = "0x18530C540")]
		get
		{
			return default(EFMILOODCJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[CanBeNull]
	public string ODKBBMBALGP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x530BFB0", Offset = "0x530A9B0", VA = "0x18530BFB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private TimeSpan GOPEIHAFKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x530B6D0", Offset = "0x530A0D0", VA = "0x18530B6D0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private TimeSpan AFADBNADANL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x530B8E0", Offset = "0x530A2E0", VA = "0x18530B8E0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task MNFFMHFCABI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x530D080", Offset = "0x530BA80", VA = "0x18530D080", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool JPNPGCFPPLJ(NOJPLHNOJFK DEGDBDLIAHB);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x530C3A0", Offset = "0x530ADA0", VA = "0x18530C3A0")]
	private static TimeSpan LMNHNNFIEHB(TimeSpan LLFPJIBFOAA, string FLBFBHGDBLM)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x530D6A0", Offset = "0x530C0A0", VA = "0x18530D6A0")]
	protected AJJLLMHFBAI(TNetworking HFINBJNJOEI, BFFKIHPKLHB BBAFOLEHIEL, string JEGJHPJDKGD, GJHIFAKEEEG OCKJAHDHPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x530D3B0", Offset = "0x530BDB0", VA = "0x18530D3B0")]
	internal AJJLLMHFBAI(TNetworking HFINBJNJOEI, BFFKIHPKLHB BBAFOLEHIEL, string JEGJHPJDKGD, GJHIFAKEEEG OCKJAHDHPHA, [Optional] EDNBBFBJOGA DDONKNLECJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x530A2F0", Offset = "0x5308CF0", VA = "0x18530A2F0")]
	private void ADCNFPKFFGP(bool GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x530C5B0", Offset = "0x530AFB0", VA = "0x18530C5B0")]
	private void MFMPAHHFLOH(EFMILOODCJD GDMNAFKAKCE, EFMILOODCJD BGDHMJBAEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x530D110", Offset = "0x530BB10", VA = "0x18530D110")]
	internal AFFODCPMGIK PJODIBPHJEH()
	{
		return default(AFFODCPMGIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x530CB10", Offset = "0x530B510", VA = "0x18530CB10")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.MJMDAGNPLCN))]
	private Task<ABEGKALIIKC> MLPEECBBNBN(AFFODCPMGIK GCHJLMBOALO, ABEGKALIIKC INAAJKILLBO, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x530A8D0", Offset = "0x53092D0", VA = "0x18530A8D0")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.LIKPDHAEIPK))]
	protected Task<ABEGKALIIKC> BIACKHBGJAJ(AFFODCPMGIK GCHJLMBOALO, ABEGKALIIKC INAAJKILLBO, CancellationToken ELPCCKIMMGK, CancellationToken KDABBJILPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x530C010", Offset = "0x530AA10", VA = "0x18530C010")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.BDLFMOJHHHG))]
	protected Task KNPODNOHONB(AFFODCPMGIK GCHJLMBOALO, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x530B470", Offset = "0x5309E70", VA = "0x18530B470", Slot = "7")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.KMOOBJLFFHL))]
	public Task FGLGBKHFALG([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x530B7A0", Offset = "0x530A1A0", VA = "0x18530B7A0")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.OOOFGMBJKDN))]
	private Task GJJFAMMLBNI(AFFODCPMGIK GCHJLMBOALO, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x530AD00", Offset = "0x5309700", VA = "0x18530AD00")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.LBFKHCBIMEM))]
	private Task<bool> DFOJHIGHCDI(AFFODCPMGIK GCHJLMBOALO, CancellationToken DHNMCOFINFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x530CD80", Offset = "0x530B780", VA = "0x18530CD80", Slot = "8")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.BOGMGPNOJBN))]
	public Task<NOJPLHNOJFK> NINKAOHACPP(NOJPLHNOJFK DEGDBDLIAHB, object AHLBPAOAMLM, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x530BE30", Offset = "0x530A830", VA = "0x18530BE30")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.CPILIBAIPCD))]
	private Task<NOJPLHNOJFK> KGDIDMPCFKK(AFFODCPMGIK GCHJLMBOALO, NOJPLHNOJFK DEGDBDLIAHB, object AHLBPAOAMLM, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x530CEE0", Offset = "0x530B8E0", VA = "0x18530CEE0")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.FNKJDPOKIKI))]
	private Task<NOJPLHNOJFK> OHGHMCHHIKP(AFFODCPMGIK GCHJLMBOALO, NOJPLHNOJFK DEGDBDLIAHB, object AHLBPAOAMLM, CancellationToken ELPCCKIMMGK, CancellationToken KDABBJILPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x530AF60", Offset = "0x5309960", VA = "0x18530AF60")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.CGNKKKEJMAE))]
	private void EFPACKCBKMB(Task<ACDCHJGLGPC> PINIBLHJFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x530B340", Offset = "0x5309D40", VA = "0x18530B340")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.HJLEGINBKDG))]
	private Task FEEJJIMMMNO(AFFODCPMGIK GCHJLMBOALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x530B230", Offset = "0x5309C30", VA = "0x18530B230", Slot = "9")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.MOJCEBCHEAB))]
	public Task FEECECEKCIB([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x530A3E0", Offset = "0x5308DE0", VA = "0x18530A3E0")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.CJMAKNMCIAD))]
	private Task AOMIFEOPLFN(AFFODCPMGIK GCHJLMBOALO, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x530AB40", Offset = "0x5309540", VA = "0x18530AB40")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.NAJIHODNEBL))]
	private Task CNNFCMMNHGJ(AFFODCPMGIK GCHJLMBOALO, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x530C810", Offset = "0x530B210", VA = "0x18530C810")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.GLOPNOAGKGP))]
	private Task<ACDCHJGLGPC> MHHLFBGJHLP(AFFODCPMGIK GCHJLMBOALO, CancellationToken ELPCCKIMMGK, CancellationToken KDABBJILPJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x530BCA0", Offset = "0x530A6A0", VA = "0x18530BCA0")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.DGALPKMFPNH))]
	private Task<EFMILOODCJD> JKGEHNMJMHA(AFFODCPMGIK GCHJLMBOALO, CancellationToken OMJKEHOJJFF, string FOAIPBIEILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x530B5E0", Offset = "0x5309FE0", VA = "0x18530B5E0", Slot = "14")]
	protected virtual void FLEPCNJCOME(AFFODCPMGIK GCHJLMBOALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x530B9B0", Offset = "0x530A3B0", VA = "0x18530B9B0", Slot = "15")]
	protected virtual void IFLKOPEIPPN(AFFODCPMGIK GCHJLMBOALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x530C160", Offset = "0x530AB60", VA = "0x18530C160")]
	private void LAJHJECEOPI(AFFODCPMGIK GCHJLMBOALO, LGOMHPHOKEA FOAIPBIEILM, params object[] GACFFBLMJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "16")]
	protected virtual void GGOEDOBOCGA(NOJPLHNOJFK CODDCJEFAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x530B180", Offset = "0x5309B80", VA = "0x18530B180")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.DPCMIJGONFB))]
	private void EOKHOEKANKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x530C2C0", Offset = "0x530ACC0", VA = "0x18530C2C0")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.CJGPLAGNKHC))]
	private Task LFDOAPMDDOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x530BBE0", Offset = "0x530A5E0", VA = "0x18530BBE0")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.DMAJHEDGMGB))]
	private void JGEBOAJPMOL(ODAHNAOHLPJ AINOMCJGGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x530CC80", Offset = "0x530B680", VA = "0x18530CC80")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.EFNCDGICEPO))]
	private Task MNNNLDEKPGC(ODAHNAOHLPJ AINOMCJGGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x530AA50", Offset = "0x5309450", VA = "0x18530AA50")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.HODPCECAKKI))]
	private Task CKEAKAAMMCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x530B580", Offset = "0x5309F80", VA = "0x18530B580", Slot = "10")]
	public void FIOGAGIEFCF(FDKDBBELKJM PPNELMIEOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x31B16A0", Offset = "0x31B00A0", VA = "0x1831B16A0")]
	private TaskCompletionSource<T> NLALIKHJABD<T>(AFFODCPMGIK GCHJLMBOALO, CancellationToken OMJKEHOJJFF, TimeSpan LCCCJECCOIL, string AFDOCIFODAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x31B17E0", Offset = "0x31B01E0", VA = "0x1831B17E0")]
	private TaskCompletionSource<T> NLALIKHJABD<T>(AFFODCPMGIK GCHJLMBOALO, CancellationToken OMJKEHOJJFF, TimeSpan LCCCJECCOIL, MNANMEOHPNL.NGCGFNGNPLB AFDOCIFODAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x530B020", Offset = "0x5309A20", VA = "0x18530B020")]
	[AsyncStateMachine(typeof(AJJLLMHFBAI<>.EGFBKFFONHB))]
	protected Task ENBJNGHDGGC(AFFODCPMGIK GCHJLMBOALO, object AGLELHDJFHJ, EFMILOODCJD EEIKDCKEMFM, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x530AEB0", Offset = "0x53098B0", VA = "0x18530AEB0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x530A530", Offset = "0x5308F30", VA = "0x18530A530", Slot = "17")]
	protected virtual void BELMKDGLCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x530BE10", Offset = "0x530A810", VA = "0x18530BE10")]
	private static string KDHOAGIENGH(AFFODCPMGIK GCHJLMBOALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	protected void GCLDEHJKFHJ(string ONGDPODJNBL, [Optional] AFFODCPMGIK GCHJLMBOALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x530C980", Offset = "0x530B380", VA = "0x18530C980")]
	protected void MIAECCEGCIC(string ONGDPODJNBL, [Optional] AFFODCPMGIK GCHJLMBOALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x530BA50", Offset = "0x530A450", VA = "0x18530BA50")]
	protected void IJNANOIGCCM(string ONGDPODJNBL, [Optional] AFFODCPMGIK GCHJLMBOALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x530D160", Offset = "0x530BB60", VA = "0x18530D160")]
	protected void PPBPIEBFMOA(string ONGDPODJNBL, Exception HPIGFEEDBKD, [Optional] AFFODCPMGIK GCHJLMBOALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x530B680", Offset = "0x530A080", VA = "0x18530B680")]
	public void GGJDANODOCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x530C6A0", Offset = "0x530B0A0", VA = "0x18530C6A0")]
	[CompilerGenerated]
	private void MHGNJDLKKGF(ABOLDNGEPMH PABDGLMAMFO, ABOLDNGEPMH NIGHBDGLDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x31B1D80", Offset = "0x31B0780", VA = "0x1831B1D80")]
	[CompilerGenerated]
	internal static string PPLIOFLBIJI<T>(TimeSpan APOGFIDPDKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct AFFODCPMGIK : IEquatable<AFFODCPMGIK>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public readonly ushort LNGFIACHHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly string ADIIGAGPGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly OJFIFCBMMIN HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly Stopwatch HEGAGIDFDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly List<(TimeSpan, EFMILOODCJD, EFMILOODCJD)> MHIMOJDHFLM;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public TimeSpan LLECAPBBFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x840A600", Offset = "0x8409000", VA = "0x18840A600")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IReadOnlyList<(TimeSpan time, EFMILOODCJD oldState, EFMILOODCJD newState)> MAJEAPLLMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x840A960", Offset = "0x8409360", VA = "0x18840A960")]
	public AFFODCPMGIK(ushort NDLCMBGHPGB, string JEGJHPJDKGD, OJFIFCBMMIN HFINBJNJOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x840A810", Offset = "0x8409210", VA = "0x18840A810")]
	private void GMAKFLHDOHD(EFMILOODCJD GDMNAFKAKCE, EFMILOODCJD BGDHMJBAEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x840A800", Offset = "0x8409200", VA = "0x18840A800", Slot = "4")]
	public bool Equals(AFFODCPMGIK EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x840A770", Offset = "0x8409170", VA = "0x18840A770", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x840A920", Offset = "0x8409320", VA = "0x18840A920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x840A940", Offset = "0x8409340", VA = "0x18840A940")]
	public static bool JJNADAGGMDE(AFFODCPMGIK OKDCNKNEMHO, AFFODCPMGIK AAJFLFEAFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x840A620", Offset = "0x8409020", VA = "0x18840A620", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class GOIBHIKECKD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct MNGKFJEGDFM<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public ACAIEIAAFEK<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public AFFODCPMGIK doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x583C1C0", Offset = "0x583ABC0", VA = "0x18583C1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x583C8B0", Offset = "0x583B2B0", VA = "0x18583C8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct FBFLHLCBBNJ<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public ACAIEIAAFEK<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AFFODCPMGIK doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4DEEB10", Offset = "0x4DED510", VA = "0x184DEEB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4DEEFB0", Offset = "0x4DED9B0", VA = "0x184DEEFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct DILIJLOPBME<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public ACAIEIAAFEK<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public CancellationToken newToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private CancellationTokenRegistration? <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x70035E0", Offset = "0x7001FE0", VA = "0x1870035E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4947CC0", Offset = "0x49466C0", VA = "0x184947CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3C775C0", Offset = "0x3C75FC0", VA = "0x183C775C0")]
	[AsyncStateMachine(typeof(MNGKFJEGDFM<>))]
	public static Task LBJJMBKAPFG<TArgs>(this ACAIEIAAFEK<TArgs> POPKCMKNMAL, [Optional] AFFODCPMGIK HLJPJLIJPAA) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3C770F0", Offset = "0x3C75AF0", VA = "0x183C770F0")]
	[AsyncStateMachine(typeof(FBFLHLCBBNJ<>))]
	public static Task EOOAFBCGIJC<TArgs>(this ACAIEIAAFEK<TArgs> POPKCMKNMAL, TimeSpan AMKPJFPJLCB, [Optional] AFFODCPMGIK HLJPJLIJPAA) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3C77350", Offset = "0x3C75D50", VA = "0x183C77350")]
	public static (bool, bool) GMHAGIOIIKL<TArgs>(this ACAIEIAAFEK<TArgs> POPKCMKNMAL, TArgs IMFCAPGBDGB, [Out] string CDCKKMODLBO) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3C77920", Offset = "0x3C76320", VA = "0x183C77920")]
	[AsyncStateMachine(typeof(DILIJLOPBME<>))]
	public static Task<TArgs> OAODCHFNMNO<TArgs>(this ACAIEIAAFEK<TArgs> POPKCMKNMAL, TArgs IMFCAPGBDGB, CancellationToken KBNBNIEEHFM) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class ACAIEIAAFEK<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate Task<TArgs> IPHAKEGIHHE(CancellationToken NJCJNNKFHIO, CancellationToken DBKAFBOKEDO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct FKDMAPIKKNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public ACAIEIAAFEK<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AFFODCPMGIK doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D420", Offset = "0x4E1BE20", VA = "0x184E1D420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4E1DA00", Offset = "0x4E1C400", VA = "0x184E1DA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct OPJOEDEMCOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ACAIEIAAFEK<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AFFODCPMGIK doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5A37330", Offset = "0x5A35D30", VA = "0x185A37330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5A37AE0", Offset = "0x5A364E0", VA = "0x185A37AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct BBCGKDGJPHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public ACAIEIAAFEK<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x64ADC70", Offset = "0x64AC670", VA = "0x1864ADC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x64AE390", Offset = "0x64ACD90", VA = "0x1864AE390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct GLNNJCBNJND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ACAIEIAAFEK<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public IPHAKEGIHHE taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private CancellationTokenSource <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4FB1F70", Offset = "0x4FB0970", VA = "0x184FB1F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4936390", Offset = "0x4934D90", VA = "0x184936390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct DIPKLLGAPCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public Task<TArgs> wrappedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public ACAIEIAAFEK<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x70040D0", Offset = "0x7002AD0", VA = "0x1870040D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4E25EC0", Offset = "0x4E248C0", VA = "0x184E25EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool JAFNIEKLOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool OEDFCBOFDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private bool JNEEDFLCNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private CancellationTokenSource CGOJJGOPONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private CancellationTokenSource HHNKNMMKKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly AFFODCPMGIK GCHJLMBOALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly CancellationToken BOJKDJLCGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly TArgs IMFCAPGBDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private TArgs DLHGOHOFAFO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public TArgs CEKGODBONJL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x51433A0", Offset = "0x5141DA0", VA = "0x1851433A0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TArgs OGLGFIDJJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5142C20", Offset = "0x5141620", VA = "0x185142C20")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[CanBeNull]
	public Task<TArgs> KKNGHIDKAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA841E0", Offset = "0xA82BE0", VA = "0x180A841E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA841C0", Offset = "0xA82BC0", VA = "0x180A841C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5143E40", Offset = "0x5142840", VA = "0x185143E40")]
	public ACAIEIAAFEK(TArgs FJBOIFJMCJO, CancellationToken BOJKDJLCGKE, AFFODCPMGIK GCHJLMBOALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5142290", Offset = "0x5140C90", VA = "0x185142290")]
	[AsyncStateMachine(typeof(ACAIEIAAFEK<>.FKDMAPIKKNI))]
	public Task BKMILDDJOGI(TimeSpan APFFEPLEAHN, AFFODCPMGIK EFMLPCKCKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5143750", Offset = "0x5142150", VA = "0x185143750")]
	[AsyncStateMachine(typeof(ACAIEIAAFEK<>.OPJOEDEMCOI))]
	public Task MOPKHJDHBBN(AFFODCPMGIK EFMLPCKCKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x51429E0", Offset = "0x51413E0", VA = "0x1851429E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5143480", Offset = "0x5141E80", VA = "0x185143480")]
	[AsyncStateMachine(typeof(ACAIEIAAFEK<>.BBCGKDGJPHE))]
	private Task MCGOHOENIOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5142650", Offset = "0x5141050", VA = "0x185142650")]
	[AsyncStateMachine(typeof(ACAIEIAAFEK<>.GLNNJCBNJND))]
	public Task<TArgs> BLNHABBJJEP(IPHAKEGIHHE KLMDLNDIACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5142E80", Offset = "0x5141880", VA = "0x185142E80")]
	[AsyncStateMachine(typeof(ACAIEIAAFEK<>.DIPKLLGAPCJ))]
	private Task<TArgs> EHDONEPPKBG(Task<TArgs> HEIODEMFEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5142FA0", Offset = "0x51419A0", VA = "0x185142FA0")]
	public bool IFBDOJNHOLM(TArgs DGFOJDLGJHN, [Out] string CDCKKMODLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5141C70", Offset = "0x5140670", VA = "0x185141C70")]
	private bool AJHKKICMHDE(TArgs DGFOJDLGJHN, [Out] string CDCKKMODLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x51439D0", Offset = "0x51423D0", VA = "0x1851439D0")]
	public CancellationTokenRegistration? PLPLIPBEMKA(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x51439B0", Offset = "0x51423B0", VA = "0x1851439B0")]
	[CompilerGenerated]
	private void NKIHDCAEHOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface GJHIFAKEEEG
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLEEBHEIKMB(string JEGJHPJDKGD, string NCDPHEDPILE, AFFODCPMGIK GCHJLMBOALO, [Optional] string PEEJGIIDCCO);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPIDPBFBAAH(string JEGJHPJDKGD, string NCDPHEDPILE, AFFODCPMGIK GCHJLMBOALO, [Optional] string PEEJGIIDCCO);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOKJFOPHPKB(string JEGJHPJDKGD, string NCDPHEDPILE, AFFODCPMGIK GCHJLMBOALO, [Optional] string PEEJGIIDCCO);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BNMOAGMPAFB(string JEGJHPJDKGD, string NCDPHEDPILE, AFFODCPMGIK GCHJLMBOALO, Exception CMHNFFEOOMC, [Optional] string PEEJGIIDCCO);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCHPALFNGNI(string JEGJHPJDKGD, CEJJBMEAKLM BEMGLJMIDAL);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class AFHNIANEMJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct FLGIOLIEPBO<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public GJHIFAKEEEG analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4E25650", Offset = "0x4E24050", VA = "0x184E25650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4E25EC0", Offset = "0x4E248C0", VA = "0x184E25EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct DJLFMBFLFKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public GJHIFAKEEEG analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x840CAB0", Offset = "0x840B4B0", VA = "0x18840CAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x840CF70", Offset = "0x840B970", VA = "0x18840CF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x31C3EC0", Offset = "0x31C28C0", VA = "0x1831C3EC0")]
	[AsyncStateMachine(typeof(FLGIOLIEPBO<>))]
	public static Task<T> CGLEGJCNICP<T>(this Task<T> AIPCFMDLKCK, [CanBeNull] GJHIFAKEEEG OCKJAHDHPHA, string JEGJHPJDKGD, string NCDPHEDPILE, AFFODCPMGIK GCHJLMBOALO, [Optional] string PEEJGIIDCCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x840ABC0", Offset = "0x84095C0", VA = "0x18840ABC0")]
	[AsyncStateMachine(typeof(DJLFMBFLFKP))]
	public static Task CGLEGJCNICP(this Task AIPCFMDLKCK, [CanBeNull] GJHIFAKEEEG OCKJAHDHPHA, string JEGJHPJDKGD, string NCDPHEDPILE, AFFODCPMGIK GCHJLMBOALO, [Optional] string PEEJGIIDCCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate Task ALBCKHPLACE();
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate Task FDKDBBELKJM(ODAHNAOHLPJ AINOMCJGGFO);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class CPMPDACAJIL : ABOLDNGEPMH, MLEFAKFGCOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class EJNHMPFFJAH : AEDANAAJMOD, HEICJCHFMBF, DKAHBIIDLNM, MOIDCFAGNEI, EOFGHGADKNN, AGCDILMPKOP, CMLGEKKJIPN, NJBPPHHAJPD, JIOJJPLFOAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly MELALFNNJBH[] LNBBDOBLBBD;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8410C90", Offset = "0x840F690", VA = "0x188410C90")]
		public EJNHMPFFJAH(IEnumerable<MELALFNNJBH> PECLDCLGPMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8410000", Offset = "0x840EA00", VA = "0x188410000", Slot = "33")]
		public virtual void OnDisconnected(BPCNBAPOLDB CCHFGODKBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x840FD50", Offset = "0x840E750", VA = "0x18840FD50", Slot = "4")]
		public void OnConnected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x840FCF0", Offset = "0x840E6F0", VA = "0x18840FCF0", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
		public void OnRegionListReceived(MBGDIBDLJEL DCOCGOJIOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x840FF60", Offset = "0x840E960", VA = "0x18840FF60", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> GPCDCFCPGFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x840FEC0", Offset = "0x840E8C0", VA = "0x18840FEC0", Slot = "9")]
		public void OnCustomAuthenticationFailed(string HFOFCGBNENB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8410900", Offset = "0x840F300", VA = "0x188410900", Slot = "10")]
		public void OnPlayerEnteredRoom(MJALBONKOJH IFFLFLAJAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8410AF0", Offset = "0x840F4F0", VA = "0x188410AF0", Slot = "11")]
		public void OnPlayerWillLeaveRoom(MJALBONKOJH IMKEHGKDPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x84109A0", Offset = "0x840F3A0", VA = "0x1884109A0", Slot = "12")]
		public void OnPlayerLeftRoom(MJALBONKOJH IMKEHGKDPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8410BF0", Offset = "0x840F5F0", VA = "0x188410BF0", Slot = "13")]
		public void OnRoomPropertiesUpdate(Hashtable NAEHMKBIGCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8410A40", Offset = "0x840F440", VA = "0x188410A40", Slot = "14")]
		public void OnPlayerPropertiesUpdate(MJALBONKOJH GPFCEEMMIIK, Hashtable OOLOAEDCNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8410860", Offset = "0x840F260", VA = "0x188410860", Slot = "15")]
		public void OnMasterClientSwitched(MJALBONKOJH GHEODBLCLFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8410680", Offset = "0x840F080", VA = "0x188410680", Slot = "16")]
		public void OnJoinedLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8410740", Offset = "0x840F140", VA = "0x188410740", Slot = "17")]
		public void OnLeftLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8410B90", Offset = "0x840F590", VA = "0x188410B90", Slot = "18")]
		public void OnRoomListUpdate(List<AHHJNEMBOBE> NGFAOLGJGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8410800", Offset = "0x840F200", VA = "0x188410800", Slot = "19")]
		public void OnLobbyStatisticsUpdate(List<PHHICOBHKPB> JLJCAIOAABG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8410570", Offset = "0x840EF70", VA = "0x188410570", Slot = "20")]
		public void OnFriendListUpdate(List<EJIOHHDCCDB> ELKGBLKMCDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x840FE60", Offset = "0x840E860", VA = "0x18840FE60", Slot = "21")]
		public void OnCreatedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x840FDB0", Offset = "0x840E7B0", VA = "0x18840FDB0", Slot = "22")]
		public void OnCreateRoomFailed(short AOHKACFOMNM, string ONGDPODJNBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x84106E0", Offset = "0x840F0E0", VA = "0x1884106E0", Slot = "23")]
		public void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x84105D0", Offset = "0x840EFD0", VA = "0x1884105D0", Slot = "24")]
		public void OnJoinRoomFailed(short AOHKACFOMNM, string ONGDPODJNBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "25")]
		public void OnJoinRandomFailed(short AOHKACFOMNM, string ONGDPODJNBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x84107A0", Offset = "0x840F1A0", VA = "0x1884107A0", Slot = "26")]
		public void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "30")]
		public void HEJLLBLGEBF(NIEAGPAKNOC LJOFOOFMAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "27")]
		public void DMPGFONJPAO(PhotonView MIBMBBBGFGE, MJALBONKOJH HBBJNPLOCFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "28")]
		public void BBHHKBLMBNA(PhotonView MIBMBBBGFGE, MJALBONKOJH FDNHMJLDGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "29")]
		public void OnWebRpcResponse(OperationResponse FNAGPCFFJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x84104A0", Offset = "0x840EEA0", VA = "0x1884104A0", Slot = "31")]
		public void OnEvent(EventData IJPBCOCGFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8410270", Offset = "0x840EC70", VA = "0x188410270", Slot = "32")]
		public void OnEventSend(EventData IJPBCOCGFOM, MOCIMAKAANE KAFJCIDDMMN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly LBCJIPEJCDP AFDJJODFJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly MELALFNNJBH IDOHDDGIMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly EJNHMPFFJAH JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Func<CPMPDACAJIL, bool> FNMCPEEKJBA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EFMILOODCJD JIDCKHGPMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x840C6E0", Offset = "0x840B0E0", VA = "0x18840C6E0", Slot = "4")]
		get
		{
			return default(EFMILOODCJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public KMNJKKOGDAK KOHJOLCMLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xBE2C20", Offset = "0xBE1620", VA = "0x180BE2C20", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MELALFNNJBH LIFOGMBKHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PKMBIMMCECE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x840C2B0", Offset = "0x840ACB0", VA = "0x18840C2B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool OIKIFLPPAHF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x840C540", Offset = "0x840AF40", VA = "0x18840C540", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool BMDKOGAEJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x840C220", Offset = "0x840AC20", VA = "0x18840C220", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool CMHLHFAMNCL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x840C240", Offset = "0x840AC40", VA = "0x18840C240", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Exception BADDGCAIHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xBE2F80", Offset = "0xBE1980", VA = "0x180BE2F80", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x840C6B0", Offset = "0x840B0B0", VA = "0x18840C6B0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int DBGBCBOLCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x840C700", Offset = "0x840B100", VA = "0x18840C700", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool JJANDCEGCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x840C720", Offset = "0x840B120", VA = "0x18840C720", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x840C280", Offset = "0x840AC80", VA = "0x18840C280", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<string, long> GKOPPPDNOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x840C600", Offset = "0x840B000", VA = "0x18840C600", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x840C490", Offset = "0x840AE90", VA = "0x18840C490", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<EFMILOODCJD, EFMILOODCJD> GHLLKNDEKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x840C2D0", Offset = "0x840ACD0", VA = "0x18840C2D0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x840C750", Offset = "0x840B150", VA = "0x18840C750", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x840C800", Offset = "0x840B200", VA = "0x18840C800")]
	public CPMPDACAJIL(LBCJIPEJCDP AFDJJODFJOB, [Optional] Func<CPMPDACAJIL, bool> FNMCPEEKJBA, [Optional] MLEFAKFGCOD HNBMALDGPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x840C560", Offset = "0x840AF60", VA = "0x18840C560")]
	private void JKIBPHNBKFH(LBCJIPEJCDP.CENMGLEBIPM LANAPDLOODN, long LJOABGLHEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x840C380", Offset = "0x840AD80", VA = "0x18840C380", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x840C260", Offset = "0x840AC60", VA = "0x18840C260")]
	private void BHJILCADIPC(MEFBGHMMEBL GDMNAFKAKCE, MEFBGHMMEBL BGDHMJBAEBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class MEHDDNBJDPK : APKPGOLLIMG, CFFBOIMLCAG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class JAFJHBNKNIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public NOJPLHNOJFK targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JAFJHBNKNIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8415DE0", Offset = "0x84147E0", VA = "0x188415DE0")]
		internal bool FIGFLMFKNBJ(DCAKOBCCBDF c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class MGNPJJHCMDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MGNPJJHCMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x841AF10", Offset = "0x8419910", VA = "0x18841AF10")]
		internal Task PNMDNOGABKF(DCAKOBCCBDF c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct OGMHLGLKKND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public MEHDDNBJDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x841C1C0", Offset = "0x841ABC0", VA = "0x18841C1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x841C670", Offset = "0x841B070", VA = "0x18841C670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct DONKNCCLODH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder<NOJPLHNOJFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public MEHDDNBJDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public NOJPLHNOJFK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private Task<NOJPLHNOJFK> <punConnectionTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private TaskAwaiter<NOJPLHNOJFK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x840ED80", Offset = "0x840D780", VA = "0x18840ED80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x840F770", Offset = "0x840E170", VA = "0x18840F770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class JMDFCMBLLJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JMDFCMBLLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8415FD0", Offset = "0x84149D0", VA = "0x188415FD0")]
		internal Task JKLJOLLGDPI(DCAKOBCCBDF c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct EBAIKAEFOJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public MEHDDNBJDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x840F7E0", Offset = "0x840E1E0", VA = "0x18840F7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x840FC90", Offset = "0x840E690", VA = "0x18840FC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct OMNKPFGEKKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public AsyncTaskMethodBuilder<NOJPLHNOJFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public MEHDDNBJDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public NOJPLHNOJFK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter<NOJPLHNOJFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x841C6D0", Offset = "0x841B0D0", VA = "0x18841C6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x841CA10", Offset = "0x841B410", VA = "0x18841CA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct MEJDBJLGOGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public MEHDDNBJDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x841AB80", Offset = "0x8419580", VA = "0x18841AB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x841AEB0", Offset = "0x84198B0", VA = "0x18841AEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct LCOKJFJBLNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public MEHDDNBJDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8416800", Offset = "0x8415200", VA = "0x188416800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8416B30", Offset = "0x8415530", VA = "0x188416B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly NPPBGIOCGGG PDJDKPDMGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly KAEAILOJMFB GFMMPPDOBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly IALNAKELMHO EMJJABKDKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly DCAKOBCCBDF[] FCMAHMJNGCK;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public NOJPLHNOJFK FIEBDEOKAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8419E20", Offset = "0x8418820", VA = "0x188419E20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string ODKBBMBALGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x841A590", Offset = "0x8418F90", VA = "0x18841A590", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private IEnumerable<DCAKOBCCBDF> BEDCJGHEMID
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8419DE0", Offset = "0x84187E0", VA = "0x188419DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private MOAOJJNBNKD EIKLOEEJLLK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Task MNFFMHFCABI
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x841A8A0", Offset = "0x84192A0", VA = "0x18841A8A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x841A4B0", Offset = "0x8418EB0", VA = "0x18841A4B0", Slot = "7")]
	public bool JPNPGCFPPLJ(NOJPLHNOJFK DEGDBDLIAHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x841A9E0", Offset = "0x84193E0", VA = "0x18841A9E0")]
	[UnityEngine.Scripting.Preserve]
	public MEHDDNBJDPK([LNLOHEINMEO(null)] NPPBGIOCGGG JMJOHMBPIFE, [LNLOHEINMEO(null)] KAEAILOJMFB DBNIMKJLMNJ, [LNLOHEINMEO(null)] IALNAKELMHO GIIPGOAMALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x841A1B0", Offset = "0x8418BB0", VA = "0x18841A1B0", Slot = "8")]
	[AsyncStateMachine(typeof(OGMHLGLKKND))]
	public Task FGLGBKHFALG([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x841A740", Offset = "0x8419140", VA = "0x18841A740", Slot = "9")]
	[AsyncStateMachine(typeof(DONKNCCLODH))]
	public Task<NOJPLHNOJFK> NINKAOHACPP(NOJPLHNOJFK DEGDBDLIAHB, object AHLBPAOAMLM, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x841A0C0", Offset = "0x8418AC0", VA = "0x18841A0C0", Slot = "10")]
	[AsyncStateMachine(typeof(EBAIKAEFOJD))]
	public Task FEECECEKCIB([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x841A5E0", Offset = "0x8418FE0", VA = "0x18841A5E0")]
	[AsyncStateMachine(typeof(OMNKPFGEKKP))]
	private Task<NOJPLHNOJFK> NHAGOFOBIEK(NOJPLHNOJFK DEGDBDLIAHB, object AHLBPAOAMLM, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x841A8F0", Offset = "0x84192F0", VA = "0x18841A8F0")]
	[AsyncStateMachine(typeof(MEJDBJLGOGD))]
	private Task POFDDABPDHH([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x841A3C0", Offset = "0x8418DC0", VA = "0x18841A3C0")]
	[AsyncStateMachine(typeof(LCOKJFJBLNO))]
	private Task JEADNGNALIP([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8419E70", Offset = "0x8418870", VA = "0x188419E70", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x841A2A0", Offset = "0x8418CA0", VA = "0x18841A2A0", Slot = "11")]
	public void FIOGAGIEFCF(FDKDBBELKJM PPNELMIEOOA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct ACDCHJGLGPC : IEquatable<ACDCHJGLGPC>
{
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public static readonly ACDCHJGLGPC MDAKIDAOHEC;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "4")]
	public bool Equals(ACDCHJGLGPC EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x840A220", Offset = "0x8408C20", VA = "0x18840A220", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FFHLLABOKKE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x840AE10", Offset = "0x8409810", VA = "0x18840AE10")]
	public FFHLLABOKKE(string ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8410CF0", Offset = "0x840F6F0", VA = "0x188410CF0")]
	public FFHLLABOKKE(string ONGDPODJNBL, Exception GNHHAMPPHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class FOOFCPMBDDI : FFHLLABOKKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public readonly string MKAPPPOHHHG;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x84111F0", Offset = "0x840FBF0", VA = "0x1884111F0")]
	public FOOFCPMBDDI(string LAIEMMECBKN, [NotNull] Exception GNHHAMPPHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class JHBKBGLANEC : FFHLLABOKKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public readonly NOJPLHNOJFK MNABDOMFFDJ;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8415EB0", Offset = "0x84148B0", VA = "0x188415EB0")]
	public JHBKBGLANEC(NOJPLHNOJFK ECKBKFEFJOI, [NotNull] Exception GNHHAMPPHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class EAEFJOLJDOK : FFHLLABOKKE
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x840AE10", Offset = "0x8409810", VA = "0x18840AE10")]
	public EAEFJOLJDOK(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class CEJJBMEAKLM : FFHLLABOKKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public readonly int? DBGBCBOLCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly ODAHNAOHLPJ NGMAGPFDOKK;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x840C010", Offset = "0x840AA10", VA = "0x18840C010")]
	public CEJJBMEAKLM(ODAHNAOHLPJ AINOMCJGGFO, Exception GNHHAMPPHJO, int? PPFLOAJFMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x840BDA0", Offset = "0x840A7A0", VA = "0x18840BDA0")]
	public static CEJJBMEAKLM AJIJNCDFNOB(ODAHNAOHLPJ CCHFGODKBPP, ABOLDNGEPMH FCJKDELLNBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class BHEKJLEFKIC : FFHLLABOKKE
{
	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x840AE10", Offset = "0x8409810", VA = "0x18840AE10")]
	public BHEKJLEFKIC(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class PMFNMMHJPDB : FFHLLABOKKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public readonly short BNCAPCFBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly string PIHPAHKDMAB;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x841CB60", Offset = "0x841B560", VA = "0x18841CB60")]
	public PMFNMMHJPDB(short EKKNDADGPGC, string AEACKMJCPHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class NJCMAFMGFGN : FFHLLABOKKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly short BNCAPCFBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly string PIHPAHKDMAB;

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x841B260", Offset = "0x8419C60", VA = "0x18841B260")]
	public NJCMAFMGFGN(short EKKNDADGPGC, string AEACKMJCPHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class OAHFCLOFGAO : FFHLLABOKKE
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x840AE10", Offset = "0x8409810", VA = "0x18840AE10")]
	public OAHFCLOFGAO(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class GFFFPGDELDB : FFHLLABOKKE
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8411320", Offset = "0x840FD20", VA = "0x188411320")]
	public GFFFPGDELDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class BCFHFAAGNAO : PJDMDJADMLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly Dictionary<string, string> JEJJDGCLMMF;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x840AD40", Offset = "0x8409740", VA = "0x18840AD40")]
	public BCFHFAAGNAO(TimeSpan LCCCJECCOIL, string ONGDPODJNBL, Dictionary<string, string> PEEJGIIDCCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class NPPBGIOCGGG : AJJLLMHFBAI<JEJOFHIOJBA>, MOAOJJNBNKD, DCAKOBCCBDF, CFFBOIMLCAG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct FHKIBGKOEMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public NPPBGIOCGGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8410D60", Offset = "0x840F760", VA = "0x188410D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class BOCLGCPKDBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public NPPBGIOCGGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AFFODCPMGIK actionContext;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BOCLGCPKDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x840AE70", Offset = "0x8409870", VA = "0x18840AE70")]
		internal void GPENNPLPBJE(OGMJCPNEHOO<string> timer, MEBJEIOEDLD log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct HMDCCDKBAJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public NPPBGIOCGGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private BOCLGCPKDBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private OGMJCPNEHOO<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter<ABEGKALIIKC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8411CD0", Offset = "0x84106D0", VA = "0x188411CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8413DD0", Offset = "0x84127D0", VA = "0x188413DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private CancellationTokenSource GGPAGMKHMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private CancellationTokenSource OCFIFIFKJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private CancellationToken PIJMOLFHKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private bool JLJAHPDLLBO;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private bool PMAOKJGHFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xAF4160", Offset = "0xAF2B60", VA = "0x180AF4160")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x841BE20", Offset = "0x841A820", VA = "0x18841BE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x841BDC0", Offset = "0x841A7C0", VA = "0x18841BDC0", Slot = "13")]
	public override bool JPNPGCFPPLJ(NOJPLHNOJFK DEGDBDLIAHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x841BF60", Offset = "0x841A960", VA = "0x18841BF60")]
	[UnityEngine.Scripting.Preserve]
	public NPPBGIOCGGG([LNLOHEINMEO(null)] JEJOFHIOJBA HFINBJNJOEI, [LNLOHEINMEO(null)] BFFKIHPKLHB BBAFOLEHIEL, [LNLOHEINMEO(null)] GJHIFAKEEEG OCKJAHDHPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x841C050", Offset = "0x841AA50", VA = "0x18841C050")]
	internal NPPBGIOCGGG(JEJOFHIOJBA HFINBJNJOEI, BFFKIHPKLHB BBAFOLEHIEL, GJHIFAKEEEG OCKJAHDHPHA, EDNBBFBJOGA DDONKNLECJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x841B830", Offset = "0x841A230", VA = "0x18841B830", Slot = "17")]
	protected override void BELMKDGLCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x841BB60", Offset = "0x841A560", VA = "0x18841BB60")]
	private void GLMKDKHHDNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x841BA00", Offset = "0x841A400", VA = "0x18841BA00", Slot = "16")]
	protected override void GGOEDOBOCGA(NOJPLHNOJFK CODDCJEFAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x841B930", Offset = "0x841A330", VA = "0x18841B930", Slot = "14")]
	protected override void FLEPCNJCOME(AFFODCPMGIK GCHJLMBOALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x841BD40", Offset = "0x841A740", VA = "0x18841BD40", Slot = "15")]
	protected override void IFLKOPEIPPN(AFFODCPMGIK GCHJLMBOALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x841B880", Offset = "0x841A280", VA = "0x18841B880")]
	[AsyncStateMachine(typeof(FHKIBGKOEMH))]
	private void FIEGGOBACKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x841BC10", Offset = "0x841A610", VA = "0x18841BC10", Slot = "18")]
	[AsyncStateMachine(typeof(HMDCCDKBAJE))]
	public Task<IReadOnlyDictionary<string, int>> HEAMENBJFOP([Optional] TimeSpan? PGIHKJKOICJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class NOJPLHNOJFK : ABEGKALIIKC, IEquatable<NOJPLHNOJFK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public readonly string LJEMONKNBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public readonly string? LBJLLNBNOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public readonly string? GFEOOAAKCJO;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x841B640", Offset = "0x841A040", VA = "0x18841B640")]
	public NOJPLHNOJFK(string AFEGMBGECCC, string AFEOOMIMEHG, string MFNLPHLCAID, string? HOHNEGAFMJL, string IAKDDGHFHLI, string IAFDMNLJOII, string? PHAHOKBOMHE, string? KGHOOOPKLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x841B5E0", Offset = "0x8419FE0", VA = "0x18841B5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x841B350", Offset = "0x8419D50", VA = "0x18841B350", Slot = "5")]
	public bool Equals(NOJPLHNOJFK? EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x841B3D0", Offset = "0x8419DD0", VA = "0x18841B3D0", Slot = "0")]
	public override bool Equals(object? CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x841B4A0", Offset = "0x8419EA0", VA = "0x18841B4A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1501BF0", Offset = "0x15005F0", VA = "0x181501BF0")]
	public static bool JJNADAGGMDE(NOJPLHNOJFK? OKDCNKNEMHO, NOJPLHNOJFK? AAJFLFEAFBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x1501350", Offset = "0x14FFD50", VA = "0x181501350")]
	public static bool CNNLEBNJPBE(NOJPLHNOJFK? OKDCNKNEMHO, NOJPLHNOJFK? AAJFLFEAFBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class ABEGKALIIKC : IEquatable<ABEGKALIIKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public readonly string BDIOKABKDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public readonly string? LDEAMPCHELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public readonly string? HOKKMOHLAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly string? CNJFFDPCOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly string CJBPDCGEJHC;

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x840A0D0", Offset = "0x8408AD0", VA = "0x18840A0D0")]
	public ABEGKALIIKC(string AFEGMBGECCC, string? AFEOOMIMEHG, string? MFNLPHLCAID, string? HOHNEGAFMJL, string IAKDDGHFHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x840A070", Offset = "0x8408A70", VA = "0x18840A070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8409E50", Offset = "0x8408850", VA = "0x188409E50", Slot = "4")]
	public bool Equals(ABEGKALIIKC? EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8409EE0", Offset = "0x84088E0", VA = "0x188409EE0", Slot = "0")]
	public override bool Equals(object? CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8409F80", Offset = "0x8408980", VA = "0x188409F80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class KAEAILOJMFB : AJJLLMHFBAI<KAEAILOJMFB.CCAFBBOIOBI>
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public interface LCJKFFLCPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BAIJLJGIJEK();
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class CCAFBBOIOBI : OJFIFCBMMIN, MBGCJNMBOPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private ABOLDNGEPMH PLDMOABLNOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private bool MMOLOAGMPDN;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private PhotonVoiceNetwork GOLCLBJOKBB
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x840BAD0", Offset = "0x840A4D0", VA = "0x18840BAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool PFFNFAKJMAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xC1B550", Offset = "0xC19F50", VA = "0x180C1B550", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public ABOLDNGEPMH PMNCIHHAEKP
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool OIKIFLPPAHF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x840B530", Offset = "0x8409F30", VA = "0x18840B530", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool BMDKOGAEJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x840AFC0", Offset = "0x84099C0", VA = "0x18840AFC0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool NFKMLGNELAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x840B880", Offset = "0x840A280", VA = "0x18840B880", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool DPBAIDIKFBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool PKMBIMMCECE
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x840B2E0", Offset = "0x8409CE0", VA = "0x18840B2E0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public object PKLOJMLBENO
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x840B190", Offset = "0x8409B90", VA = "0x18840B190", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool KLLGBFGKBCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x840B9C0", Offset = "0x840A3C0", VA = "0x18840B9C0", Slot = "16")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x840BD40", Offset = "0x840A740", VA = "0x18840BD40", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ABOLDNGEPMH, ABOLDNGEPMH> KKEDKEODHNA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x840B910", Offset = "0x840A310", VA = "0x18840B910", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x840B380", Offset = "0x8409D80", VA = "0x18840B380", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<bool> AEFGMGLDAIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "22")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "23")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x840BB30", Offset = "0x840A530", VA = "0x18840BB30", Slot = "10")]
		public void MEJDBBHGBIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x840B750", Offset = "0x840A150", VA = "0x18840B750", Slot = "18")]
		public bool IMGDJEHDCNL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x840B580", Offset = "0x8409F80", VA = "0x18840B580", Slot = "19")]
		public bool ILLKLKDFOHB(string IAFDMNLJOII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x840B430", Offset = "0x8409E30", VA = "0x18840B430", Slot = "20")]
		public void FGLGBKHFALG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x840B010", Offset = "0x8409A10", VA = "0x18840B010", Slot = "21")]
		public bool CECKAHLMJBL(object AGLELHDJFHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "24")]
		public void IAMANOOODOB(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "25")]
		public void KCPGNCEPFDH(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "26")]
		public void KKEFIJOFOOH(object DHNMCOFINFM, bool BNIIJGIOPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x840B330", Offset = "0x8409D30", VA = "0x18840B330", Slot = "27")]
		public IDisposable DMNKKMMJKHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "28")]
		private bool OFIIDGPBMGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "29")]
		public void FLDIFAOJJHE(StringBuilder IPBAIMPPDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x840BC40", Offset = "0x840A640", VA = "0x18840BC40", Slot = "30")]
		public bool NAAIBACONMJ(bool CHFGFGIAFFI, [Out] string GFHOJCCMEDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CCAFBBOIOBI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct ACFEOHENGEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public KAEAILOJMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public NPPBGIOCGGG clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter<NOJPLHNOJFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x840A290", Offset = "0x8408C90", VA = "0x18840A290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x840A5A0", Offset = "0x8408FA0", VA = "0x18840A5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct GKENLDJJCMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public KAEAILOJMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x84113A0", Offset = "0x840FDA0", VA = "0x1884113A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8411710", Offset = "0x8410110", VA = "0x188411710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly NPPBGIOCGGG JMJOHMBPIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly LCJKFFLCPEO PCALGEDEAJC;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8416270", Offset = "0x8414C70", VA = "0x188416270", Slot = "13")]
	public override bool JPNPGCFPPLJ(NOJPLHNOJFK DEGDBDLIAHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x84164C0", Offset = "0x8414EC0", VA = "0x1884164C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KAEAILOJMFB([LNLOHEINMEO(null)] NPPBGIOCGGG JMJOHMBPIFE, [LNLOHEINMEO(null)] BFFKIHPKLHB BBAFOLEHIEL, [LNLOHEINMEO(null)] LCJKFFLCPEO PCALGEDEAJC, [LNLOHEINMEO(null)] GJHIFAKEEEG OCKJAHDHPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x8416300", Offset = "0x8414D00", VA = "0x188416300")]
	private Task NOHOJFFBJPA(ODAHNAOHLPJ AINOMCJGGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x8416030", Offset = "0x8414A30", VA = "0x188416030")]
	[AsyncStateMachine(typeof(ACFEOHENGEO))]
	public Task BANODMGCHBC(NPPBGIOCGGG DFPFFCPFAOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8416120", Offset = "0x8414B20", VA = "0x188416120")]
	[CompilerGenerated]
	internal static void DEINGNBMBDB(ABOLDNGEPMH PABDGLMAMFO, ABOLDNGEPMH NIGHBDGLDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x84161A0", Offset = "0x8414BA0", VA = "0x1884161A0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GKENLDJJCMK))]
	private Task JBNNJCOENBP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[RecRoom.NoEngine.Common.Preserve]
public class DMGGFHBGIMA
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "AT", Required = Required.Always)]
	public byte[] AccessToken
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	[JsonProperty(PropertyName = "VB", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] VerificationBlob
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] ClientKeyA
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
	public byte[] ClientIVA
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
	public byte[] ClientPublicKey
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public DMGGFHBGIMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[RecRoom.NoEngine.Common.Preserve]
public class DNCGLJCCNPO
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	[JsonProperty(PropertyName = "KT", Required = Required.Default)]
	[RecRoom.NoEngine.Common.Preserve]
	public byte[] SessionKeyB
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public DNCGLJCCNPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class IALNAKELMHO : DCAKOBCCBDF, CFFBOIMLCAG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum AGCGHAJNCDM
	{
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private NetworkManager CAMGGGGOKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private TaskCompletionSource<NOJPLHNOJFK> COIFILLHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	protected readonly BFFKIHPKLHB DICKNDCPAOO;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly MEBJEIOEDLD GCLDEHJKFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly HashSet<FDKDBBELKJM> NJOBGMEJODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public AGCGHAJNCDM ODJPCCPKJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private NOJPLHNOJFK DEGDBDLIAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private RSACryptoServiceProvider NIOCGOIEKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private RSACryptoServiceProvider KHKONGPAPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private AesCryptoServiceProvider FEKEIFHLJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private byte[] JLKKCMABHGH;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public NOJPLHNOJFK FIEBDEOKAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string ODKBBMBALGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8414EE0", Offset = "0x84138E0", VA = "0x188414EE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Task MNFFMHFCABI
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8415AE0", Offset = "0x84144E0", VA = "0x188415AE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8414100", Offset = "0x8412B00", VA = "0x188414100", Slot = "10")]
	public void FIOGAGIEFCF(FDKDBBELKJM PPNELMIEOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8414E30", Offset = "0x8413830", VA = "0x188414E30", Slot = "6")]
	public bool JPNPGCFPPLJ(NOJPLHNOJFK DEGDBDLIAHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8415C20", Offset = "0x8414620", VA = "0x188415C20")]
	[RecRoom.NoEngine.Common.Preserve]
	public IALNAKELMHO([LNLOHEINMEO(null)] BFFKIHPKLHB HFIIENKLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8415090", Offset = "0x8413A90", VA = "0x188415090")]
	private void MFFEHJFFAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8413F90", Offset = "0x8412990", VA = "0x188413F90")]
	private void FFNGFHDFMCP(ulong CEFJEHJNIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8415B30", Offset = "0x8414530", VA = "0x188415B30")]
	private void PHBAJGNBAPC(bool GOCPFPNNJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x84152F0", Offset = "0x8413CF0", VA = "0x1884152F0")]
	private void MLIHEDLAPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x84141E0", Offset = "0x8412BE0", VA = "0x1884141E0")]
	private void GHNJMBFDHIC(ulong CEFJEHJNIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8414160", Offset = "0x8412B60", VA = "0x188414160")]
	private void GGOLJFNMEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8414E70", Offset = "0x8413870", VA = "0x188414E70")]
	private void KIGKPDGBBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x8414F10", Offset = "0x8413910", VA = "0x188414F10")]
	private void KJINGIMPAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x8415510", Offset = "0x8413F10", VA = "0x188415510")]
	private void NCKFHGACJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x8414700", Offset = "0x8413100", VA = "0x188414700")]
	private static (IPAddress, ushort) IEIHCKIEFDJ(string CBBLIMLOGLB)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x8414830", Offset = "0x8413230", VA = "0x188414830")]
	private void JGPBHDGLFKM(NOJPLHNOJFK KLKCGDIBPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8415680", Offset = "0x8414080", VA = "0x188415680", Slot = "8")]
	public Task<NOJPLHNOJFK> NINKAOHACPP(NOJPLHNOJFK DEGDBDLIAHB, object AHLBPAOAMLM, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8414010", Offset = "0x8412A10", VA = "0x188414010", Slot = "7")]
	public Task FGLGBKHFALG([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x8413EA0", Offset = "0x84128A0", VA = "0x188413EA0", Slot = "9")]
	public Task FEECECEKCIB([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8413E40", Offset = "0x8412840", VA = "0x188413E40", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class CIHLBDEEBEN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x840C150", Offset = "0x840AB50", VA = "0x18840C150")]
	public CIHLBDEEBEN(string ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x840C1B0", Offset = "0x840ABB0", VA = "0x18840C1B0")]
	public CIHLBDEEBEN(string ONGDPODJNBL, Exception GNHHAMPPHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class PFHNFBFHHAB : CIHLBDEEBEN
{
	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x841CA80", Offset = "0x841B480", VA = "0x18841CA80")]
	public PFHNFBFHHAB([NotNull] Exception GNHHAMPPHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class BEEFEHKJBBM : CIHLBDEEBEN
{
	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x840AD90", Offset = "0x8409790", VA = "0x18840AD90")]
	public BEEFEHKJBBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class BPHOEJCOGHB : CIHLBDEEBEN
{
	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x840AF40", Offset = "0x8409940", VA = "0x18840AF40")]
	public BPHOEJCOGHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class NIINAKNAKGK
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static AesCryptoServiceProvider PFHOAIEMEHF;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private static readonly string IIINCNOBGGF;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static readonly string FGLAILCBJOI;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static readonly string CGODODAGNGF;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x841B0C0", Offset = "0x8419AC0", VA = "0x18841B0C0")]
	public static string JPNIOCHMMFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x841B070", Offset = "0x8419A70", VA = "0x18841B070")]
	public static string EPNGNGGEOBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x841AF70", Offset = "0x8419970", VA = "0x18841AF70")]
	public static AesCryptoServiceProvider EOFJPONCGFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class DNNLKMFJMHG : PGMCFKBIHHO
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public enum DGODFGCHOIE
	{
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private HPDJJKCNBLF HCHCAEAONNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private NetworkManager CAMGGGGOKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	protected readonly BFFKIHPKLHB DICKNDCPAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private TaskCompletionSource<bool> LKAHIDIDLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public DGODFGCHOIE ODJPCCPKJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private RSACryptoServiceProvider NIOCGOIEKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private RSACryptoServiceProvider KHKONGPAPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private AesCryptoServiceProvider FEKEIFHLJML;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public HPDJJKCNBLF PGDOELFBDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string EIOCBGFGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string POKCGFOBPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x840D490", Offset = "0x840BE90", VA = "0x18840D490", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x840EBD0", Offset = "0x840D5D0", VA = "0x18840EBD0")]
	[UnityEngine.Scripting.Preserve]
	public DNNLKMFJMHG([LNLOHEINMEO(null)] BFFKIHPKLHB HFIIENKLMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x840E930", Offset = "0x840D330", VA = "0x18840E930")]
	private void MFFEHJFFAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x840D5B0", Offset = "0x840BFB0", VA = "0x18840D5B0")]
	private void FFNGFHDFMCP(ulong CEFJEHJNIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x840CFD0", Offset = "0x840B9D0", VA = "0x18840CFD0")]
	private void BKAIELGKCJK(ulong CEFJEHJNIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x840DA80", Offset = "0x840C480", VA = "0x18840DA80")]
	private void GHNJMBFDHIC(ulong CEFJEHJNIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x840D990", Offset = "0x840C390", VA = "0x18840D990")]
	private void GGOLJFNMEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x840E8C0", Offset = "0x840D2C0", VA = "0x18840E8C0")]
	private void KIGKPDGBBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x840EB30", Offset = "0x840D530", VA = "0x18840EB30")]
	private void NCKFHGACJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x840DFC0", Offset = "0x840C9C0", VA = "0x18840DFC0")]
	private static (IPAddress, ushort) IEIHCKIEFDJ(string CBBLIMLOGLB)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x840E0F0", Offset = "0x840CAF0", VA = "0x18840E0F0")]
	private void JGPBHDGLFKM(string IAKDDGHFHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x840DBD0", Offset = "0x840C5D0", VA = "0x18840DBD0", Slot = "7")]
	public Task<bool> GICELHOJFCE(string PHAHOKBOMHE, string PHAIPANOFOJ, string IAKDDGHFHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x840D8F0", Offset = "0x840C2F0", VA = "0x18840D8F0", Slot = "8")]
	public Task FGLGBKHFALG([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
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

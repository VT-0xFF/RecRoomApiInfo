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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB0630", Offset = "0x7EAF430", VA = "0x187EB0630")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NetworkProfiler : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
	public NetworkProfiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class BOKHGANAKMP : NEJHGGPCOKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EventData FELHJOMEEAD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EventData OEPJGNEPBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte JAOBBLBJLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x20FA640", Offset = "0x20F9440", VA = "0x1820FA640", Slot = "4")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EALAAGBDPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F3E0", Offset = "0x7E9E1E0", VA = "0x187E9F3E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public object GNFNGOLMLKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F400", Offset = "0x7E9E200", VA = "0x187E9F400", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public object ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F3C0", Offset = "0x7E9E1C0", VA = "0x187E9F3C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public BOKHGANAKMP(EventData FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E9F390", Offset = "0x7E9E190", VA = "0x187E9F390", Slot = "8")]
	public bool GNFCCDJDLII(byte MAKJJJECHHB, [Out] object OAIIHELJHLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NLAJNCNEFGB : HOLMOLJACNK, PNEPNDOKHCF, MJGCKMDKNME, KJFHLELIGPN, KEMOFGHCGFH, JKACFOLHIMF, HEPJOOJLFOI, MNBAHJGPANP, KPJDDBLOCLJ, DGOAAKKIPOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class NAFPGGGBEPF : PNDJJNCCOEH
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class AOLALLIHHOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public AOLALLIHHOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x74838E0", Offset = "0x74826E0", VA = "0x1874838E0")]
			internal void IHMIJCIPJIL(LHIMHEHFENP rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool HPEGCMPKOOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7EACA50", Offset = "0x7EAB850", VA = "0x187EACA50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool MCKCNKFOGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7EAC940", Offset = "0x7EAB740", VA = "0x187EAC940", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public IReadOnlyList<(string code, int ping)> EMMGBDFIOIP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7EACAC0", Offset = "0x7EAB8C0", VA = "0x187EACAC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7EAC820", Offset = "0x7EAB620", VA = "0x187EAC820", Slot = "7")]
		public bool ALNCMEALIFE(Action BAJFCCOCAON, string JDPBFOGIOOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NAFPGGGBEPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly Hashtable MDDGNNCNCAO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly SendOptions NOKAMBMFGJH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly SendOptions AONLDPNGIDP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly SendOptions JCEKDMFJAOB;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly SendOptions BHGPANNPNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KOKPHDNOEMH NNENMMBNDMI;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static readonly byte[] DEOPGJMMPGG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DFOJADFIGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xE36450", Offset = "0xE35250", VA = "0x180E36450", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override KOKPHDNOEMH PPDGFGNOMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PCKKANJMAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7EAED30", Offset = "0x7EADB30", VA = "0x187EAED30", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NMFFHPLAHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD340", Offset = "0x7EAC140", VA = "0x187EAD340", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AHNIMKBJLEJ HBMKGECCKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD140", Offset = "0x7EABF40", VA = "0x187EAD140", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DICOPAPILLO BLJDKHGNDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF9D0", Offset = "0x7EAE7D0", VA = "0x187EAF9D0", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override bool CKFGBNAFBPH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD7D0", Offset = "0x7EAC5D0", VA = "0x187EAD7D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD0F0", Offset = "0x7EABEF0", VA = "0x187EAD0F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override float FJAKPOGIEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD860", Offset = "0x7EAC660", VA = "0x187EAD860", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE1C0", Offset = "0x7EACFC0", VA = "0x187EAE1C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PNDJJNCCOEH BDJFOJHDNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA0D040", Offset = "0xA0BE40", VA = "0x180A0D040", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool NDANJPPHLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF8A0", Offset = "0x7EAE6A0", VA = "0x187EAF8A0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE600", Offset = "0x7EAD400", VA = "0x187EAE600", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool GNIIFIBAMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF240", Offset = "0x7EAE040", VA = "0x187EAF240", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool BBEMKJBNGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE140", Offset = "0x7EACF40", VA = "0x187EAE140", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public object DJPFJNAJABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE740", Offset = "0x7EAD540", VA = "0x187EAE740", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FEOAMLPKBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE820", Offset = "0x7EAD620", VA = "0x187EAE820", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int GNEJGECHKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE6D0", Offset = "0x7EAD4D0", VA = "0x187EAE6D0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int BIKFAJKKAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD480", Offset = "0x7EAC280", VA = "0x187EAD480", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int MBEKLDOELOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF930", Offset = "0x7EAE730", VA = "0x187EAF930", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AHNIMKBJLEJ GGGCAKCKKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD200", Offset = "0x7EAC000", VA = "0x187EAD200", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int JBMBFAOOFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD070", Offset = "0x7EABE70", VA = "0x187EAD070", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int CAPPFIMBOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD4F0", Offset = "0x7EAC2F0", VA = "0x187EAD4F0", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool MPFMOGHFLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF3C0", Offset = "0x7EAE1C0", VA = "0x187EAF3C0", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string NBAJJIGOEBK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7EAFB10", Offset = "0x7EAE910", VA = "0x187EAFB10", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Func<string, string> DLDABIOBFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF010", Offset = "0x7EADE10", VA = "0x187EAF010", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int NHIHMODMOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD180", Offset = "0x7EABF80", VA = "0x187EAD180", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public double GJBBGPENBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF4C0", Offset = "0x7EAE2C0", VA = "0x187EAF4C0", Slot = "36")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int GEMIKGFHNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE690", Offset = "0x7EAD490", VA = "0x187EAE690", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int MCLHJJIGPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7EAFA20", Offset = "0x7EAE820", VA = "0x187EAFA20", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string MHPAFLHHEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE650", Offset = "0x7EAD450", VA = "0x187EAE650", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long JCKMJFKLOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF6B0", Offset = "0x7EAE4B0", VA = "0x187EAF6B0", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long OCBLMCCMDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE180", Offset = "0x7EACF80", VA = "0x187EAE180", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool GBFLFCHGNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF970", Offset = "0x7EAE770", VA = "0x187EAF970", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<AHNIMKBJLEJ> FDJAPPFCHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF500", Offset = "0x7EAE300", VA = "0x187EAF500", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF6F0", Offset = "0x7EAE4F0", VA = "0x187EAF6F0", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<KOKPHDNOEMH, KOKPHDNOEMH> ELJGIFAKIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7EAEF60", Offset = "0x7EADD60", VA = "0x187EAEF60", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7EAEE70", Offset = "0x7EADC70", VA = "0x187EAEE70", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<NEJHGGPCOKC> ICDHGGPFBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD720", Offset = "0x7EAC520", VA = "0x187EAD720", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF5B0", Offset = "0x7EAE3B0", VA = "0x187EAF5B0", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7EADE90", Offset = "0x7EACC90", VA = "0x187EADE90", Slot = "45")]
	public void EDAEHIGPNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7EAED70", Offset = "0x7EADB70", VA = "0x187EAED70")]
	[ENKLKENGHAE.AANPNKKBMFF.ENPJKGAFAPD]
	internal static void JKEPFALEAEN(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFE50", Offset = "0x7EAEC50", VA = "0x187EAFE50")]
	[UnityEngine.Scripting.Preserve]
	public NLAJNCNEFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD380", Offset = "0x7EAC180", VA = "0x187EAD380")]
	private void CFGJNCOCCKK(bool COILPLMHHFE, bool OBDOEBLNIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE210", Offset = "0x7EAD010", VA = "0x187EAE210", Slot = "17")]
	public float FGBNLKDBDDC(bool DKCMKOJJOAJ, int BGJOHJJBHOG = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF100", Offset = "0x7EADF00", VA = "0x187EAF100", Slot = "82")]
	[CanBeNull]
	public AHNIMKBJLEJ KLLFNCOLKDI(int HCHHJGLKNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE980", Offset = "0x7EAD780", VA = "0x187EAE980", Slot = "84")]
	public AHNIMKBJLEJ IHKKGMBEGNK(int HCHHJGLKNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE8C0", Offset = "0x7EAD6C0", VA = "0x187EAE8C0", Slot = "83")]
	[CanBeNull]
	public AHNIMKBJLEJ IEAGFINMIMG(int OEBMJHLGKIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFAC0", Offset = "0x7EAE8C0", VA = "0x187EAFAC0", Slot = "85")]
	public IReadOnlyList<AHNIMKBJLEJ> PCHPGEKJNEH(bool LGNLAJIJLPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF660", Offset = "0x7EAE460", VA = "0x187EAF660", Slot = "86")]
	public IReadOnlyList<AHNIMKBJLEJ> MKCKCLGBCMD(bool LGNLAJIJLPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE870", Offset = "0x7EAD670", VA = "0x187EAE870", Slot = "87")]
	public bool HHJKLAJDHBC(AHNIMKBJLEJ ACKNEPODFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF190", Offset = "0x7EADF90", VA = "0x187EAF190")]
	private static short KNAEGFNGLDG(StreamBuffer DLBILMBBAMF, object KDPMNLPACDJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7EADFA0", Offset = "0x7EACDA0", VA = "0x187EADFA0")]
	private static object EHGDOMJEAIM(StreamBuffer OCOEABMDNFG, short NPCJGIOCILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7EADC20", Offset = "0x7EACA20", VA = "0x187EADC20", Slot = "96")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD240", Offset = "0x7EAC040", VA = "0x187EAD240", Slot = "56")]
	public bool CCPCLKLBCCG(object DGLBNKIMOMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7EAEF20", Offset = "0x7EADD20", VA = "0x187EAEF20", Slot = "55")]
	public void KAIHEAGEBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7EAEAC0", Offset = "0x7EAD8C0", VA = "0x187EAEAC0", Slot = "53")]
	public bool IPHALIMOHDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFA80", Offset = "0x7EAE880", VA = "0x187EAFA80", Slot = "18")]
	public bool OGFNCDMLIPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFBD0", Offset = "0x7EAE9D0", VA = "0x187EAFBD0", Slot = "8")]
	public override void PMJONIOBAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7EAEA50", Offset = "0x7EAD850", VA = "0x187EAEA50", Slot = "20")]
	public void ILNHMFBAEII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7EACEE0", Offset = "0x7EABCE0", VA = "0x187EACEE0", Slot = "21")]
	public void ADKGAMHCMAD(List<object> COKPAJOONAO, int AJOJFAFFHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7EAEC20", Offset = "0x7EADA20", VA = "0x187EAEC20", Slot = "22")]
	public void JCPLAHAKBCL(int LEDAMNBPIIM, object FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE270", Offset = "0x7EAD070", VA = "0x187EAE270", Slot = "23")]
	public void FJHDICFIHKJ(IDictionary<object, object> ADPBPEDNFCM, int LCALHIDHIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD8A0", Offset = "0x7EAC6A0", VA = "0x187EAD8A0", Slot = "70")]
	public bool DPJAECGGDEA(byte GDAEOLOIDMC, object NHNKMCAHFDJ, EEKDOOHAAOB PCLCKPBICJD, LADNPKPOAGM JEIGPENCGFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF7A0", Offset = "0x7EAE5A0", VA = "0x187EAF7A0", Slot = "54")]
	public bool NKCHFHFPGIC(string AJNKBHACFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD570", Offset = "0x7EAC370", VA = "0x187EAD570", Slot = "35")]
	public void DFNIBNEMDIB(string PLLKAKKCBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF300", Offset = "0x7EAE100", VA = "0x187EAF300", Slot = "27")]
	public void LDPNBBJNMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF070", Offset = "0x7EADE70", VA = "0x187EAF070", Slot = "28")]
	public void KIDMEGDOMCG(object GLEBGNJJOHG, NativeList<byte> FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF340", Offset = "0x7EAE140", VA = "0x187EAF340", Slot = "29")]
	public object LGDBIGPAFJK(NativeArray<byte> FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFC10", Offset = "0x7EAEA10", VA = "0x187EAFC10", Slot = "81")]
	public void PPFFPDPKLCJ(string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7EADDD0", Offset = "0x7EACBD0", VA = "0x187EADDD0", Slot = "30")]
	public int EBLCPEPHMBH(NEJHGGPCOKC FELHJOMEEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE7E0", Offset = "0x7EAD5E0", VA = "0x187EAE7E0", Slot = "95")]
	public int GPIIDGGGEOO()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E93200", Offset = "0x7E92000", VA = "0x187E93200", Slot = "11")]
	private void BKPBMBHEBCG(Action OAIIHELJHLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E93C10", Offset = "0x7E92A10", VA = "0x187E93C10", Slot = "12")]
	private void JNOHPMOGHHN(Action OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7E93EB0", Offset = "0x7E92CB0", VA = "0x187E93EB0", Slot = "25")]
	private void KMFMPFHCHBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7E94320", Offset = "0x7E93120", VA = "0x187E94320", Slot = "26")]
	private void MIJCKPIBLBG()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7E93750", Offset = "0x7E92550", VA = "0x187E93750", Slot = "31")]
	private void GHIGNFBMDJA(float OAIIHELJHLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7E93DA0", Offset = "0x7E92BA0", VA = "0x187E93DA0", Slot = "32")]
	private void KCHAEHIENLD(float OAIIHELJHLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E939D0", Offset = "0x7E927D0", VA = "0x187E939D0", Slot = "57")]
	private void IGKIDHOCHMP(Action<bool> OAIIHELJHLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E93E10", Offset = "0x7E92C10", VA = "0x187E93E10", Slot = "58")]
	private void KGCHNENNGLM(Action<bool> OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E93BF0", Offset = "0x7E929F0", VA = "0x187E93BF0", Slot = "59")]
	private void JKLPJBJFNJL(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7E93B40", Offset = "0x7E92940", VA = "0x187E93B40", Slot = "60")]
	private void JCFPFLKMPML(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7E93090", Offset = "0x7E91E90", VA = "0x187E93090", Slot = "61")]
	private void AEADLJNKHEI(object JLFLGDNCANL, bool LLOCMBEOOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7E93550", Offset = "0x7E92350", VA = "0x187E93550", Slot = "62")]
	private IDisposable EHIAKHEDGPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E94620", Offset = "0x7E93420", VA = "0x187E94620", Slot = "63")]
	private bool OPJDDBDODDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E930A0", Offset = "0x7E91EA0", VA = "0x187E930A0", Slot = "64")]
	private void AEGOIFKILMG(StringBuilder NIHOBNHAGFC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7E94560", Offset = "0x7E93360", VA = "0x187E94560", Slot = "66")]
	private void OFAJFIFLBDB(Action<string, long> OAIIHELJHLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7E938E0", Offset = "0x7E926E0", VA = "0x187E938E0", Slot = "67")]
	private void IAEJPCKCLMJ(Action<string, long> OAIIHELJHLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7E937B0", Offset = "0x7E925B0", VA = "0x187E937B0", Slot = "88")]
	private void HADHNHPGLLF(Action OAIIHELJHLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7E93C00", Offset = "0x7E92A00", VA = "0x187E93C00", Slot = "89")]
	private void JLBBNLIECAO(Action OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7E93B70", Offset = "0x7E92970", VA = "0x187E93B70", Slot = "90")]
	private void JECOFNILGIJ()
	{
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7EABAC0", Offset = "0x7EAA8C0", VA = "0x187EABAC0", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB21B0", Offset = "0x7EB0FB0", VA = "0x187EB21B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HPNEFIEBBJB : BOJJICCGBID, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BOJJICCGBID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	PELAEIAHGNO KANJLJEJBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string DIIHJEFHLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Task LAHMACNGMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LLLLKGOAHBI(PELAEIAHGNO OLECCPPNDFE);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KAIHEAGEBBJ([Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<PELAEIAHGNO> EJGJIOGEDHP(PELAEIAHGNO OLECCPPNDFE, object JCGPNELIJIN, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task GCDGKGFFLLF([Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KJEAGAHPFBI(OLMMEJLCNFM LNPKKFGGBHM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal interface CKDINOBKPJN
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFIOJMLAODO(ushort EENNBFLGEIP, HKHBBKMIBJB PDBPJODHGOI, params object[] CJDMKBGDNIG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal enum HKHBBKMIBJB
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
public interface OOALADCCJDG : BOJJICCGBID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PJNABLCEBHB BJFPMICMBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PJNABLCEBHB : HPNEFIEBBJB, BOJJICCGBID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> NBHODFNFMMC([Optional] TimeSpan? LGLKBIHNOCE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OBNFMOELGIC
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool ACDEKNBBIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	TimeSpan OOJPLEKOONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	TimeSpan NCEJBKHGFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object LPDPEHFJOIH(MFOGLPMCFJJ CNKHDJCBOKK);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LEFKNJLDGKF GFMMJLBIPFN(MFOGLPMCFJJ CNKHDJCBOKK);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MFOGLPMCFJJ> EJHFFEMAGME(CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IPGNPJNAFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	LLEAAEBCCKF AOBNECFHGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string EPLHHFIJJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string ACHMGMLMNPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> FIMFMEKHIAN(string PHBJHOMDIND, string MMKJBFMHPHO, string NDLPMEKHJDE);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task KAIHEAGEBBJ([Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal static class HAFLMDHFBFF
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class GIEEFJHGIHO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Action<string, OKLCPEFFPPG> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public KOKPHDNOEMH networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public MNBAHJGPANP networking;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GIEEFJHGIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4BC6E20", Offset = "0x4BC5C20", VA = "0x184BC6E20")]
		internal void GGKOPPDPKHA(OJIEIHJFFCG disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4BC6C60", Offset = "0x4BC5A60", VA = "0x184BC6C60")]
		internal void BIDOJCCBADG(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4BC7140", Offset = "0x4BC5F40", VA = "0x184BC7140")]
		internal void JNJCDNPIHLF(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class MLBBDBFBJCB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public MNBAHJGPANP networking;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MLBBDBFBJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x53CBB70", Offset = "0x53CA970", VA = "0x1853CBB70")]
		internal void EINNNLPMKAA(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x53CBD10", Offset = "0x53CAB10", VA = "0x1853CBD10")]
		internal void IPLHKGAMOEN(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x53CBF60", Offset = "0x53CAD60", VA = "0x1853CBF60")]
		internal void PKFGLKLLLLD(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3914FE0", Offset = "0x3913DE0", VA = "0x183914FE0")]
	public static void IOCALJEIOPF<T>(this MNBAHJGPANP KLBDPNGJELI, TaskCompletionSource<T> FDNGACKNMLA, [NotNull] KOKPHDNOEMH PFDJGMCDDEC, OKLCPEFFPPG CHGHHGBBNNH, bool BFKNFNNNDOJ, Action<string, OKLCPEFFPPG> NHLEILEPJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x39149C0", Offset = "0x39137C0", VA = "0x1839149C0")]
	public static void DANFFHHJFLN<T>(this MNBAHJGPANP KLBDPNGJELI, TaskCompletionSource<T> FDNGACKNMLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class KAGINFADFPA<TNetworking> : HPNEFIEBBJB, BOJJICCGBID, IDisposable where TNetworking : class, MJGCKMDKNME, KJFHLELIGPN
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class IDHALNEBBHP
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
			public AsyncTaskMethodBuilder<MFOGLPMCFJJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public IDHALNEBBHP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private TaskAwaiter<MFOGLPMCFJJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4193100", Offset = "0x4191F00", VA = "0x184193100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4193480", Offset = "0x4192280", VA = "0x184193480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public MFOGLPMCFJJ photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IDHALNEBBHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4D2E260", Offset = "0x4D2D060", VA = "0x184D2E260")]
		[AsyncStateMachine(typeof(KAGINFADFPA<>.IDHALNEBBHP.<<ConnectToRegionInternal>b__0>d))]
		internal Task<MFOGLPMCFJJ> HDDKDMNKPNA(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct PBMPMKPBIIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<MFOGLPMCFJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public MFOGLPMCFJJ photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private IDHALNEBBHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<MFOGLPMCFJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x576CC20", Offset = "0x576BA20", VA = "0x18576CC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x576D830", Offset = "0x576C630", VA = "0x18576D830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct OFOPMCGJJNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<MFOGLPMCFJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public MFOGLPMCFJJ photonServerConnectionInfo;

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
		[Cpp2IlInjected.Address(RVA = "0x565F3F0", Offset = "0x565E1F0", VA = "0x18565F3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x56600C0", Offset = "0x565EEC0", VA = "0x1856600C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct LMPAHJEKENC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x51B00F0", Offset = "0x51AEEF0", VA = "0x1851B00F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x51B0340", Offset = "0x51AF140", VA = "0x1851B0340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct MADFFKFFMMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private OKLCPEFFPPG <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x538A010", Offset = "0x5388E10", VA = "0x18538A010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x538A550", Offset = "0x5389350", VA = "0x18538A550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MNKLOBLCPPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MNKLOBLCPPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x53D9F30", Offset = "0x53D8D30", VA = "0x1853D9F30")]
		internal Task<bool> NHKAOAAGBIP(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct AOBDEEDBKON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private MNKLOBLCPPC <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x4E9B440", Offset = "0x4E9A240", VA = "0x184E9B440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4E9C290", Offset = "0x4E9B090", VA = "0x184E9C290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JKCEFCNJNDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TaskCompletionSource<OJIEIHJFFCG> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JKCEFCNJNDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4FC2670", Offset = "0x4FC1470", VA = "0x184FC2670")]
		internal void OEIJKAHIHOC(OJIEIHJFFCG disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4FC2580", Offset = "0x4FC1380", VA = "0x184FC2580")]
		internal void DLILBOMJGOD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct MKCMBOFLKHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private JKCEFCNJNDD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<OJIEIHJFFCG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x53C8400", Offset = "0x53C7200", VA = "0x1853C8400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x53C9C10", Offset = "0x53C8A10", VA = "0x1853C9C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct FEFOGFEPOJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder<PELAEIAHGNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PELAEIAHGNO targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private OKLCPEFFPPG <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<PELAEIAHGNO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E0E0", Offset = "0x4A4CEE0", VA = "0x184A4E0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4A4ED70", Offset = "0x4A4DB70", VA = "0x184A4ED70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ACJPAMFEPGL
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
			public AsyncTaskMethodBuilder<PELAEIAHGNO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public ACJPAMFEPGL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private TaskAwaiter<PELAEIAHGNO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x41934F0", Offset = "0x41922F0", VA = "0x1841934F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4193890", Offset = "0x4192690", VA = "0x184193890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public PELAEIAHGNO targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ACJPAMFEPGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4B9B480", Offset = "0x4B9A280", VA = "0x184B9B480")]
		[AsyncStateMachine(typeof(KAGINFADFPA<>.ACJPAMFEPGL.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<PELAEIAHGNO> JHLOKLKDIBF(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct PLGKFBEGIBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AsyncTaskMethodBuilder<PELAEIAHGNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public PELAEIAHGNO targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ACJPAMFEPGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<PELAEIAHGNO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x578DC70", Offset = "0x578CA70", VA = "0x18578DC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x578EA50", Offset = "0x578D850", VA = "0x18578EA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class AKMJFEBBDAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TaskCompletionSource<OJNBBCLMJHF> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AKMJFEBBDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4DC32A0", Offset = "0x4DC20A0", VA = "0x184DC32A0")]
		internal void FNLJLKCACNO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct JDMNEFCMIGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<PELAEIAHGNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public PELAEIAHGNO targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private AKMJFEBBDAM <>8__1;

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
		private TaskAwaiter<MFOGLPMCFJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<OJNBBCLMJHF> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DAF0", Offset = "0x4F7C8F0", VA = "0x184F7DAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4F7FEB0", Offset = "0x4F7ECB0", VA = "0x184F7FEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct ODMPJFBLMPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Task<NJCBAGIHLNK> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<NJCBAGIHLNK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x565CAA0", Offset = "0x565B8A0", VA = "0x18565CAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct FFMDDHHECLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4A61AA0", Offset = "0x4A608A0", VA = "0x184A61AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4A61CF0", Offset = "0x4A60AF0", VA = "0x184A61CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct HDNMCMIDPGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private OKLCPEFFPPG <actionContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4C1C330", Offset = "0x4C1B130", VA = "0x184C1C330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4C1C7C0", Offset = "0x4C1B5C0", VA = "0x184C1C7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct FPJLJOBJHGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public OKLCPEFFPPG actionContext;

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
		[Cpp2IlInjected.Address(RVA = "0x4AE83C0", Offset = "0x4AE71C0", VA = "0x184AE83C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4AE8BB0", Offset = "0x4AE79B0", VA = "0x184AE8BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MGMFKNLBJHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MGMFKNLBJHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x53BBCF0", Offset = "0x53BAAF0", VA = "0x1853BBCF0")]
		internal Task<NJCBAGIHLNK> PDGDKHHJCPN(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct MCIHGHLJIIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private MGMFKNLBJHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TaskAwaiter<NJCBAGIHLNK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x539A820", Offset = "0x5399620", VA = "0x18539A820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x539B370", Offset = "0x539A170", VA = "0x18539B370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CPOBNFNAMFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public TaskCompletionSource<OJNBBCLMJHF> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CPOBNFNAMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6720C40", Offset = "0x671FA40", VA = "0x186720C40")]
		internal void AANCJIDBGNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6720CE0", Offset = "0x671FAE0", VA = "0x186720CE0")]
		internal void BHPMMJBMGEM(OJIEIHJFFCG disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6720D80", Offset = "0x671FB80", VA = "0x186720D80")]
		internal void KOEGEDDHPFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CCLFFBMEGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public TaskCompletionSource<OJNBBCLMJHF> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CPOBNFNAMFF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CCLFFBMEGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x654A4E0", Offset = "0x65492E0", VA = "0x18654A4E0")]
		internal void IOJICINCFEG(OJIEIHJFFCG disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x654A440", Offset = "0x6549240", VA = "0x18654A440")]
		internal void CMKKCGHIGJC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct AGBADKGIDMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public AsyncTaskMethodBuilder<NJCBAGIHLNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private CPOBNFNAMFF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private CCLFFBMEGOF <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter<OJNBBCLMJHF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8F70", Offset = "0x4BA7D70", VA = "0x184BA8F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4BAB2A0", Offset = "0x4BAA0A0", VA = "0x184BAB2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class KHOABBDBDML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public TaskCompletionSource<OJNBBCLMJHF> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public KHOABBDBDML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x50AB810", Offset = "0x50AA610", VA = "0x1850AB810")]
		internal string LMKDKLDGHEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x50AB720", Offset = "0x50AA520", VA = "0x1850AB720")]
		internal void DJKDEMIPHBC(OJNBBCLMJHF _1, OJNBBCLMJHF _2)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct AOLOEIIAIMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncTaskMethodBuilder<OJNBBCLMJHF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private KHOABBDBDML <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter<OJNBBCLMJHF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4E9DC50", Offset = "0x4E9CA50", VA = "0x184E9DC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E9C0", Offset = "0x4E9D7C0", VA = "0x184E9E9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HODAKJECBFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4C55620", Offset = "0x4C54420", VA = "0x184C55620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct CDNOEOOPHAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6556D20", Offset = "0x6555B20", VA = "0x186556D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6557110", Offset = "0x6555F10", VA = "0x186557110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct GINHJJCEGMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public OJIEIHJFFCG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private MEFDMAJNKAA <exception>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4BCD860", Offset = "0x4BCC660", VA = "0x184BCD860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct LMFMFNIKELI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public OJIEIHJFFCG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private HashSet<OLMMEJLCNFM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x51AB8A0", Offset = "0x51AA6A0", VA = "0x1851AB8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x51AC330", Offset = "0x51AB130", VA = "0x1851AC330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct ELBKCNILOCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private HashSet<BPOMGPJPKJN>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x460EA30", Offset = "0x460D830", VA = "0x18460EA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x460EF20", Offset = "0x460DD20", VA = "0x18460EF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class CKIOKPOICGL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CKIOKPOICGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		internal string AEIDLENDJND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class ABCBCBMMKOJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ELKMHOLOOEB.CPMFEOKNMAK timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ABCBCBMMKOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4B98D80", Offset = "0x4B97B80", VA = "0x184B98D80")]
		internal void MJAMHFAKJEG(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4B98350", Offset = "0x4B97150", VA = "0x184B98350")]
		internal NBMIKJGNPIL INOANJDEEOH(TimeSpan timeoutTime)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class NLFOBDJMGJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public TaskCompletionSource<OJNBBCLMJHF> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NLFOBDJMGJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x54CF9C0", Offset = "0x54CE7C0", VA = "0x1854CF9C0")]
		internal void APPCCMLHGLB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct CBLMKJAOBMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private NLFOBDJMGJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public OJNBBCLMJHF connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public object appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private TaskAwaiter<OJNBBCLMJHF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6548400", Offset = "0x6547200", VA = "0x186548400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6549810", Offset = "0x6548610", VA = "0x186549810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JMGEAAMBCBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JMGEAAMBCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4FD3AC0", Offset = "0x4FD28C0", VA = "0x184FD3AC0")]
		internal object COIODAMNHMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class IKKGPCAEFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IKKGPCAEFAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4D43E60", Offset = "0x4D42C60", VA = "0x184D43E60")]
		internal object LDGKMGNIOLE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class PKKHANBEEHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public KAGINFADFPA<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PKKHANBEEHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x578C7E0", Offset = "0x578B5E0", VA = "0x18578C7E0")]
		internal object CEFOFGECLBM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CKDINOBKPJN PFOJGIOMKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly LMIEGECNFBF DABDCOCNOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected readonly string FBINGPLLJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected readonly OBNFMOELGIC MFDCIMBJGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private TaskCompletionSource<NJCBAGIHLNK> FJMCFLCPAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected internal readonly TNetworking PCDGBLIDLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private ushort AFBJFDOMMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private OFPIKMINANL<MFOGLPMCFJJ> EHHOJKFOLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private OFPIKMINANL<bool> EPDADLAIOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private OFPIKMINANL<PELAEIAHGNO> FCDBAIPEHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private OFPIKMINANL<NJCBAGIHLNK> CFHEDHFEBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private bool LKLFOJBMFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool LDHNFANBJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly HashSet<BPOMGPJPKJN> NOIEDCBEDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HashSet<OLMMEJLCNFM> HFGEFKPCMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool OMPJCPABCDP;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BBEMKJBNGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x508F9D0", Offset = "0x508E7D0", VA = "0x18508F9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[CanBeNull]
	public PELAEIAHGNO KANJLJEJBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x508F980", Offset = "0x508E780", VA = "0x18508F980", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected OJNBBCLMJHF KNICLIJBMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x508FD80", Offset = "0x508EB80", VA = "0x18508FD80")]
		get
		{
			return default(OJNBBCLMJHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[CanBeNull]
	public string DIIHJEFHLLG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5090420", Offset = "0x508F220", VA = "0x185090420", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private TimeSpan OOJPLEKOONK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5091A80", Offset = "0x5090880", VA = "0x185091A80")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private TimeSpan NCEJBKHGFON
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5091B50", Offset = "0x5090950", VA = "0x185091B50")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task LAHMACNGMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5090B90", Offset = "0x508F990", VA = "0x185090B90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool LLLLKGOAHBI(PELAEIAHGNO OLECCPPNDFE);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x50918E0", Offset = "0x50906E0", VA = "0x1850918E0")]
	private static TimeSpan NODKIOIALMN(TimeSpan MJFHAOOPOAG, string IHGFMOMOADA)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5092170", Offset = "0x5090F70", VA = "0x185092170")]
	protected KAGINFADFPA(TNetworking KLBDPNGJELI, OBNFMOELGIC PIKGEBLPBOL, string FCJCPNNHLPP, LMIEGECNFBF DABDCOCNOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5091E70", Offset = "0x5090C70", VA = "0x185091E70")]
	internal KAGINFADFPA(TNetworking KLBDPNGJELI, OBNFMOELGIC PIKGEBLPBOL, string FCJCPNNHLPP, LMIEGECNFBF DABDCOCNOJG, [Optional] CKDINOBKPJN PFOJGIOMKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x508F080", Offset = "0x508DE80", VA = "0x18508F080")]
	private void BLHHJPDANEH(bool AOJFFKDCAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50906E0", Offset = "0x508F4E0", VA = "0x1850906E0")]
	private void JINGBCKABHM(OJNBBCLMJHF CAGFCBLHBLD, OJNBBCLMJHF PNLIABINBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x508FBB0", Offset = "0x508E9B0", VA = "0x18508FBB0")]
	internal OKLCPEFFPPG FAFECBPBGPN()
	{
		return default(OKLCPEFFPPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x508FA40", Offset = "0x508E840", VA = "0x18508FA40")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.PBMPMKPBIIJ))]
	private Task<MFOGLPMCFJJ> ENFBOFLGOBB(OKLCPEFFPPG CHGHHGBBNNH, MFOGLPMCFJJ CNKHDJCBOKK, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x508FC00", Offset = "0x508EA00", VA = "0x18508FC00")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.OFOPMCGJJNB))]
	protected Task<MFOGLPMCFJJ> FIEEHMBFAKM(OKLCPEFFPPG CHGHHGBBNNH, MFOGLPMCFJJ CNKHDJCBOKK, CancellationToken NLBNDNAKGGK, CancellationToken BCPDAKAKBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x50913E0", Offset = "0x50901E0", VA = "0x1850913E0")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.LMPAHJEKENC))]
	protected Task MLEKCNABKLI(OKLCPEFFPPG CHGHHGBBNNH, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x50909D0", Offset = "0x508F7D0", VA = "0x1850909D0", Slot = "7")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.MADFFKFFMMM))]
	public Task KAIHEAGEBBJ([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x50917A0", Offset = "0x50905A0", VA = "0x1850917A0")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.AOBDEEDBKON))]
	private Task NFLNLCLFGAN(OKLCPEFFPPG CHGHHGBBNNH, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5090100", Offset = "0x508EF00", VA = "0x185090100")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.MKCMBOFLKHP))]
	private Task<bool> GOGOGJBPBEG(OKLCPEFFPPG CHGHHGBBNNH, CancellationToken JLFLGDNCANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x508F820", Offset = "0x508E620", VA = "0x18508F820", Slot = "8")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.FEFOGFEPOJG))]
	public Task<PELAEIAHGNO> EJGJIOGEDHP(PELAEIAHGNO OLECCPPNDFE, object JCGPNELIJIN, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x508ECC0", Offset = "0x508DAC0", VA = "0x18508ECC0")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.PLGKFBEGIBO))]
	private Task<PELAEIAHGNO> AHLELCLGDPA(OKLCPEFFPPG CHGHHGBBNNH, PELAEIAHGNO OLECCPPNDFE, object JCGPNELIJIN, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5091600", Offset = "0x5090400", VA = "0x185091600")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.JDMNEFCMIGD))]
	private Task<PELAEIAHGNO> NDFCFGLHJIP(OKLCPEFFPPG CHGHHGBBNNH, PELAEIAHGNO OLECCPPNDFE, object JCGPNELIJIN, CancellationToken NLBNDNAKGGK, CancellationToken BCPDAKAKBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x508FF80", Offset = "0x508ED80", VA = "0x18508FF80")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.ODMPJFBLMPN))]
	private void GHAOJGFOGCM(Task<NJCBAGIHLNK> PHONHDKMBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x50907E0", Offset = "0x508F5E0", VA = "0x1850907E0")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.FFMDDHHECLA))]
	private Task JLGCMDPKEAL(OKLCPEFFPPG CHGHHGBBNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x508FE70", Offset = "0x508EC70", VA = "0x18508FE70", Slot = "9")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.HDNMCMIDPGO))]
	public Task GCDGKGFFLLF([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x508F550", Offset = "0x508E350", VA = "0x18508F550")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.FPJLJOBJHGH))]
	private Task DMAFODCENFM(OKLCPEFFPPG CHGHHGBBNNH, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5091290", Offset = "0x5090090", VA = "0x185091290")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.MCIHGHLJIIH))]
	private Task MINMELIAGOP(OKLCPEFFPPG CHGHHGBBNNH, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5090D80", Offset = "0x508FB80", VA = "0x185090D80")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.AGBADKGIDMN))]
	private Task<NJCBAGIHLNK> MCCHBGMKPGE(OKLCPEFFPPG CHGHHGBBNNH, CancellationToken NLBNDNAKGGK, CancellationToken BCPDAKAKBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5090570", Offset = "0x508F370", VA = "0x185090570")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.AOLOEIIAIMC))]
	private Task<OJNBBCLMJHF> JCEHJBCDJJG(OKLCPEFFPPG CHGHHGBBNNH, CancellationToken GHKBKDKNIOM, string CFDGGKIIHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x508F6A0", Offset = "0x508E4A0", VA = "0x18508F6A0", Slot = "14")]
	protected virtual void DMEJAEFLJDC(OKLCPEFFPPG CHGHHGBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5090040", Offset = "0x508EE40", VA = "0x185090040", Slot = "15")]
	protected virtual void GHLMIIANABE(OKLCPEFFPPG CHGHHGBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x508F2E0", Offset = "0x508E0E0", VA = "0x18508F2E0")]
	private void DFIOJMLAODO(OKLCPEFFPPG CHGHHGBBNNH, HKHBBKMIBJB CFDGGKIIHOI, params object[] AOGFOJGFMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "16")]
	protected virtual void JJCEPGMDKBH(PELAEIAHGNO CBGLMCICHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x508EFE0", Offset = "0x508DDE0", VA = "0x18508EFE0")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.HODAKJECBFN))]
	private void APJINGMBOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5091530", Offset = "0x5090330", VA = "0x185091530")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.CDNOEOOPHAC))]
	private Task MMGCDJKDKPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5090910", Offset = "0x508F710", VA = "0x185090910")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.GINHJJCEGMG))]
	private void JMCLGJGIHLI(OJIEIHJFFCG EMEHDOCGFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x508F450", Offset = "0x508E250", VA = "0x18508F450")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.LMFMFNIKELI))]
	private Task DLFDNBMBLNE(OJIEIHJFFCG EMEHDOCGFNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5090480", Offset = "0x508F280", VA = "0x185090480")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.ELBKCNILOCH))]
	private Task IJLEBLABJJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5090B30", Offset = "0x508F930", VA = "0x185090B30", Slot = "10")]
	public void KJEAGAHPFBI(OLMMEJLCNFM LNPKKFGGBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3BB62F0", Offset = "0x3BB50F0", VA = "0x183BB62F0")]
	private TaskCompletionSource<T> ANHBOGACFAL<T>(OKLCPEFFPPG CHGHHGBBNNH, CancellationToken GHKBKDKNIOM, TimeSpan LCJLIMHGKHF, string MGJMEDHDOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6050", Offset = "0x3BB4E50", VA = "0x183BB6050")]
	private TaskCompletionSource<T> ANHBOGACFAL<T>(OKLCPEFFPPG CHGHHGBBNNH, CancellationToken GHKBKDKNIOM, TimeSpan LCJLIMHGKHF, ELKMHOLOOEB.CPMFEOKNMAK MGJMEDHDOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x508F180", Offset = "0x508DF80", VA = "0x18508F180")]
	[AsyncStateMachine(typeof(KAGINFADFPA<>.CBLMKJAOBMG))]
	protected Task DEIMDANJIFM(OKLCPEFFPPG CHGHHGBBNNH, object DGLBNKIMOMA, OJNBBCLMJHF NDLABCHHBED, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x508F760", Offset = "0x508E560", VA = "0x18508F760", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5090EF0", Offset = "0x508FCF0", VA = "0x185090EF0", Slot = "17")]
	protected virtual void MCNGEKPACKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5090260", Offset = "0x508F060", VA = "0x185090260")]
	private static string HDHCCPJKABI(OKLCPEFFPPG CHGHHGBBNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	protected void NDLHJECGFPL(string NJJDPBHNDPA, [Optional] OKLCPEFFPPG CHGHHGBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5091C20", Offset = "0x5090A20", VA = "0x185091C20")]
	protected void PJBJBOBMGNJ(string NJJDPBHNDPA, [Optional] OKLCPEFFPPG CHGHHGBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x508EE40", Offset = "0x508DC40", VA = "0x18508EE40")]
	protected void AJDOOHBHBHH(string NJJDPBHNDPA, [Optional] OKLCPEFFPPG CHGHHGBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5090280", Offset = "0x508F080", VA = "0x185090280")]
	protected void HJHBCOLPIEH(string NJJDPBHNDPA, Exception HELNJIPKBCP, [Optional] OKLCPEFFPPG CHGHHGBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5090AE0", Offset = "0x508F8E0", VA = "0x185090AE0")]
	public void KGGMGCICFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5090C20", Offset = "0x508FA20", VA = "0x185090C20")]
	[CompilerGenerated]
	private void LJNNEHHCJPG(KOKPHDNOEMH NKIHBIMPCMA, KOKPHDNOEMH AEIALKPFDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6870", Offset = "0x3BB5670", VA = "0x183BB6870")]
	[CompilerGenerated]
	internal static string COCABOPAHMI<T>(TimeSpan KLEIANNIJKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct OKLCPEFFPPG : IEquatable<OKLCPEFFPPG>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public readonly ushort FGNHCGNMOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly string FBINGPLLJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly MJGCKMDKNME KLBDPNGJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly Stopwatch FPMFLKNHPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly List<(TimeSpan, OJNBBCLMJHF, OJNBBCLMJHF)> MAOAKOIFAJL;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public TimeSpan PCHIJDKJLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7EB08F0", Offset = "0x7EAF6F0", VA = "0x187EB08F0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IReadOnlyList<(TimeSpan time, OJNBBCLMJHF oldState, OJNBBCLMJHF newState)> MGBMGMOGFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0B10", Offset = "0x7EAF910", VA = "0x187EB0B10")]
	public OKLCPEFFPPG(ushort EENNBFLGEIP, string FCJCPNNHLPP, MJGCKMDKNME KLBDPNGJELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB09D0", Offset = "0x7EAF7D0", VA = "0x187EB09D0")]
	private void MDFFBDNFIHM(OJNBBCLMJHF CAGFCBLHBLD, OJNBBCLMJHF PNLIABINBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0910", Offset = "0x7EAF710", VA = "0x187EB0910", Slot = "4")]
	public bool Equals(OKLCPEFFPPG HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0920", Offset = "0x7EAF720", VA = "0x187EB0920", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB09B0", Offset = "0x7EAF7B0", VA = "0x187EB09B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0AF0", Offset = "0x7EAF8F0", VA = "0x187EB0AF0")]
	public static bool PBEBFPKJKLO(OKLCPEFFPPG EFOOGHNHGNH, OKLCPEFFPPG IFJAPBHAPEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7EB07A0", Offset = "0x7EAF5A0", VA = "0x187EB07A0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class HEFOFNPAAGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct GGDMNNPAOML<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public OFPIKMINANL<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public OKLCPEFFPPG doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4BC31F0", Offset = "0x4BC1FF0", VA = "0x184BC31F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x4BC3500", Offset = "0x4BC2300", VA = "0x184BC3500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct AKJCAJCAHKK<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public OFPIKMINANL<TArgs> clientAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public TimeSpan forceCancelTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public OKLCPEFFPPG doesntMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4DC2C80", Offset = "0x4DC1A80", VA = "0x184DC2C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4DC3140", Offset = "0x4DC1F40", VA = "0x184DC3140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct EECEGHHPNPN<TArgs> : IAsyncStateMachine where TArgs : IEquatable<TArgs>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public OFPIKMINANL<TArgs> clientAction;

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
		[Cpp2IlInjected.Address(RVA = "0x45E1370", Offset = "0x45E0170", VA = "0x1845E1370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x45E18E0", Offset = "0x45E06E0", VA = "0x1845E18E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3918680", Offset = "0x3917480", VA = "0x183918680")]
	[AsyncStateMachine(typeof(GGDMNNPAOML<>))]
	public static Task IPAHNFAJPDG<TArgs>(this OFPIKMINANL<TArgs> FFJBKBOGMPH, [Optional] OKLCPEFFPPG JANFNNJBHEJ) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x39189E0", Offset = "0x39177E0", VA = "0x1839189E0")]
	[AsyncStateMachine(typeof(AKJCAJCAHKK<>))]
	public static Task JBLJCNNEDOF<TArgs>(this OFPIKMINANL<TArgs> FFJBKBOGMPH, TimeSpan KNCFBCNIIDL, [Optional] OKLCPEFFPPG JANFNNJBHEJ) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3918C40", Offset = "0x3917A40", VA = "0x183918C40")]
	public static (bool, bool) PLEEKENPNFD<TArgs>(this OFPIKMINANL<TArgs> FFJBKBOGMPH, TArgs GDCDKMJLKDH, [Out] string KFIOKDCLOED) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3918320", Offset = "0x3917120", VA = "0x183918320")]
	[AsyncStateMachine(typeof(EECEGHHPNPN<>))]
	public static Task<TArgs> HDBNHBAGMLO<TArgs>(this OFPIKMINANL<TArgs> FFJBKBOGMPH, TArgs GDCDKMJLKDH, CancellationToken HGHOGCJMHEG) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class OFPIKMINANL<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate Task<TArgs> EKPDEIEIJFE(CancellationToken JEDJKOPAGOO, CancellationToken ACIAKEDOLOM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct MFLMFGFNHOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public OFPIKMINANL<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public OKLCPEFFPPG doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x53B2AD0", Offset = "0x53B18D0", VA = "0x1853B2AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x53B3070", Offset = "0x53B1E70", VA = "0x1853B3070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct PPNHFCGAKFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public OFPIKMINANL<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public OKLCPEFFPPG doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x57C27A0", Offset = "0x57C15A0", VA = "0x1857C27A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x57C2FE0", Offset = "0x57C1DE0", VA = "0x1857C2FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct PMFFDDLMAHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public OFPIKMINANL<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x578F0F0", Offset = "0x578DEF0", VA = "0x18578F0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x578F840", Offset = "0x578E640", VA = "0x18578F840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct GNLPHJPJDBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public OFPIKMINANL<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public EKPDEIEIJFE taskFactory;

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
		[Cpp2IlInjected.Address(RVA = "0x4BDAD70", Offset = "0x4BD9B70", VA = "0x184BDAD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4BDB6F0", Offset = "0x4BDA4F0", VA = "0x184BDB6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct PHMBIDDBILD : IAsyncStateMachine
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
		public OFPIKMINANL<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5778A10", Offset = "0x5777810", VA = "0x185778A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4F82610", Offset = "0x4F81410", VA = "0x184F82610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool EKADHKFOHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool KIBNJKEMKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private bool HFLOGAHCPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private CancellationTokenSource DNCMCEOLALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private CancellationTokenSource OGOAOHCLJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly OKLCPEFFPPG CHGHHGBBNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly CancellationToken KKIGNHNCIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly TArgs GDCDKMJLKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private TArgs DDEBNKFKCJA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public TArgs CKHLHELFBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5660390", Offset = "0x565F190", VA = "0x185660390")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TArgs OHFJGKNFCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5661F40", Offset = "0x5660D40", VA = "0x185661F40")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[CanBeNull]
	public Task<TArgs> GKOLNIFPLNN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFF0", Offset = "0xA0BDF0", VA = "0x180A0CFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFE0", Offset = "0xA0BDE0", VA = "0x180A0CFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x56622B0", Offset = "0x56610B0", VA = "0x1856622B0")]
	public OFPIKMINANL(TArgs PNNJHOJNMIA, CancellationToken KKIGNHNCIEJ, OKLCPEFFPPG CHGHHGBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5661B80", Offset = "0x5660980", VA = "0x185661B80")]
	[AsyncStateMachine(typeof(OFPIKMINANL<>.MFLMFGFNHOJ))]
	public Task HFDFKAMDNHB(TimeSpan AFLDEPCBDGA, OKLCPEFFPPG BCCHAIMNCKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x56613F0", Offset = "0x56601F0", VA = "0x1856613F0")]
	[AsyncStateMachine(typeof(OFPIKMINANL<>.PPNHFCGAKFL))]
	public Task GMHKHHJBIMP(OKLCPEFFPPG BCCHAIMNCKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5660210", Offset = "0x565F010", VA = "0x185660210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5661E60", Offset = "0x5660C60", VA = "0x185661E60")]
	[AsyncStateMachine(typeof(OFPIKMINANL<>.PMFFDDLMAHJ))]
	private Task NDFCAFDBDOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5660A30", Offset = "0x565F830", VA = "0x185660A30")]
	[AsyncStateMachine(typeof(OFPIKMINANL<>.GNLPHJPJDBD))]
	public Task<TArgs> FOFAGJALJLB(EKPDEIEIJFE HDBALOOOPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5662070", Offset = "0x5660E70", VA = "0x185662070")]
	[AsyncStateMachine(typeof(OFPIKMINANL<>.PHMBIDDBILD))]
	private Task<TArgs> PJJPGHOKALN(Task<TArgs> OAGJGMINMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5660670", Offset = "0x565F470", VA = "0x185660670")]
	public bool EMLJAJNGNBJ(TArgs GBFMMNKIKKN, [Out] string KFIOKDCLOED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5660B60", Offset = "0x565F960", VA = "0x185660B60")]
	private bool GDMECEEEAEG(TArgs GBFMMNKIKKN, [Out] string KFIOKDCLOED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x56617B0", Offset = "0x56605B0", VA = "0x1856617B0")]
	public CancellationTokenRegistration? HEGIPBLOGBI(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5660130", Offset = "0x565EF30", VA = "0x185660130")]
	[CompilerGenerated]
	private void DLGFEPAPFHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface LMIEGECNFBF
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEKKCPOCGNL(string FCJCPNNHLPP, string MOBBBNKKEKN, OKLCPEFFPPG CHGHHGBBNNH, [Optional] string IEAIEKCDOCO);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOMHJEAFMNP(string FCJCPNNHLPP, string MOBBBNKKEKN, OKLCPEFFPPG CHGHHGBBNNH, [Optional] string IEAIEKCDOCO);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILLMMCMBFJM(string FCJCPNNHLPP, string MOBBBNKKEKN, OKLCPEFFPPG CHGHHGBBNNH, [Optional] string IEAIEKCDOCO);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNADJCGJCLM(string FCJCPNNHLPP, string MOBBBNKKEKN, OKLCPEFFPPG CHGHHGBBNNH, Exception BKLHGCIIDBN, [Optional] string IEAIEKCDOCO);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BIDFGKMODAK(string FCJCPNNHLPP, MEFDMAJNKAA ICCOKCDFPGP);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class EIJOJHOLGBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct PHIACGCHPBP<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public LMIEGECNFBF analytics;

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
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x57778D0", Offset = "0x57766D0", VA = "0x1857778D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4F82610", Offset = "0x4F81410", VA = "0x184F82610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct HHNFONJGKMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public LMIEGECNFBF analytics;

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
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6A40", Offset = "0x7EA5840", VA = "0x187EA6A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6F00", Offset = "0x7EA5D00", VA = "0x187EA6F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x37777D0", Offset = "0x37765D0", VA = "0x1837777D0")]
	[AsyncStateMachine(typeof(PHIACGCHPBP<>))]
	public static Task<T> EEOICEINEGI<T>(this Task<T> JDEJDGHOHNF, [CanBeNull] LMIEGECNFBF DABDCOCNOJG, string FCJCPNNHLPP, string MOBBBNKKEKN, OKLCPEFFPPG CHGHHGBBNNH, [Optional] string IEAIEKCDOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4C60", Offset = "0x7EA3A60", VA = "0x187EA4C60")]
	[AsyncStateMachine(typeof(HHNFONJGKMA))]
	public static Task EEOICEINEGI(this Task JDEJDGHOHNF, [CanBeNull] LMIEGECNFBF DABDCOCNOJG, string FCJCPNNHLPP, string MOBBBNKKEKN, OKLCPEFFPPG CHGHHGBBNNH, [Optional] string IEAIEKCDOCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate Task BPOMGPJPKJN();
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate Task OLMMEJLCNFM(OJIEIHJFFCG EMEHDOCGFNO);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DKFEGLLCPFP : KOKPHDNOEMH, MNBAHJGPANP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class KONBPLMLHHC : JPANFHEOGHC, LNKKFHHGPFC, PEKBFENJBFP, MKFEFPMCHMM, GKOPCMGGEKA, AEOCCCNBDLF, FIJICELIBCK, BFOIAMPGMPG, EGFHAJHDNKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly DICOPAPILLO[] KBGDMNFOKMD;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7EAAD80", Offset = "0x7EA9B80", VA = "0x187EAAD80")]
		public KONBPLMLHHC(IEnumerable<DICOPAPILLO> KCIFJEEBHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA0F0", Offset = "0x7EA8EF0", VA = "0x187EAA0F0", Slot = "33")]
		public virtual void OnDisconnected(DIDJCLIMBJA PHALJILMPBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9E40", Offset = "0x7EA8C40", VA = "0x187EA9E40", Slot = "4")]
		public void OnConnected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9DE0", Offset = "0x7EA8BE0", VA = "0x187EA9DE0", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
		public void OnRegionListReceived(LHIMHEHFENP IOPFLHBJBAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA050", Offset = "0x7EA8E50", VA = "0x187EAA050", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> FFEMKICJPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9FB0", Offset = "0x7EA8DB0", VA = "0x187EA9FB0", Slot = "9")]
		public void OnCustomAuthenticationFailed(string NBBNGJBAMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA9F0", Offset = "0x7EA97F0", VA = "0x187EAA9F0", Slot = "10")]
		public void OnPlayerEnteredRoom(MFCMIHICIBF EFJCJCFFEIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7EAABE0", Offset = "0x7EA99E0", VA = "0x187EAABE0", Slot = "11")]
		public void OnPlayerWillLeaveRoom(MFCMIHICIBF BGPDJLHAPJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7EAAA90", Offset = "0x7EA9890", VA = "0x187EAAA90", Slot = "12")]
		public void OnPlayerLeftRoom(MFCMIHICIBF BGPDJLHAPJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7EAACE0", Offset = "0x7EA9AE0", VA = "0x187EAACE0", Slot = "13")]
		public void OnRoomPropertiesUpdate(Hashtable ILIOPJAEPPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7EAAB30", Offset = "0x7EA9930", VA = "0x187EAAB30", Slot = "14")]
		public void OnPlayerPropertiesUpdate(MFCMIHICIBF JBJICEBBHIA, Hashtable HDEAGHIEAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA950", Offset = "0x7EA9750", VA = "0x187EAA950", Slot = "15")]
		public void OnMasterClientSwitched(MFCMIHICIBF OCMOPICGOLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA770", Offset = "0x7EA9570", VA = "0x187EAA770", Slot = "16")]
		public void OnJoinedLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA830", Offset = "0x7EA9630", VA = "0x187EAA830", Slot = "17")]
		public void OnLeftLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7EAAC80", Offset = "0x7EA9A80", VA = "0x187EAAC80", Slot = "18")]
		public void OnRoomListUpdate(List<OJMOFBGOODB> FCJDNLEJDPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA8F0", Offset = "0x7EA96F0", VA = "0x187EAA8F0", Slot = "19")]
		public void OnLobbyStatisticsUpdate(List<EBFGGCCJNBP> HDEODCOENNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA660", Offset = "0x7EA9460", VA = "0x187EAA660", Slot = "20")]
		public void OnFriendListUpdate(List<HBHCLOHMMPD> PMAJDJGBFCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9F50", Offset = "0x7EA8D50", VA = "0x187EA9F50", Slot = "21")]
		public void OnCreatedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9EA0", Offset = "0x7EA8CA0", VA = "0x187EA9EA0", Slot = "22")]
		public void OnCreateRoomFailed(short CBJLNGAENNA, string NJJDPBHNDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA7D0", Offset = "0x7EA95D0", VA = "0x187EAA7D0", Slot = "23")]
		public void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA6C0", Offset = "0x7EA94C0", VA = "0x187EAA6C0", Slot = "24")]
		public void OnJoinRoomFailed(short CBJLNGAENNA, string NJJDPBHNDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "25")]
		public void OnJoinRandomFailed(short CBJLNGAENNA, string NJJDPBHNDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA890", Offset = "0x7EA9690", VA = "0x187EAA890", Slot = "26")]
		public void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "30")]
		public void EJNIHBPBKJM(LFJEHFKMNHM DOKMLDLFBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "27")]
		public void COCJLNLFBMM(PhotonView MICFIEJJPJI, MFCMIHICIBF OIMMHJNPNEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "28")]
		public void JNMJFICAHPB(PhotonView MICFIEJJPJI, MFCMIHICIBF OGCMAOGIEEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "29")]
		public void OnWebRpcResponse(OperationResponse EBLIHNLGKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA590", Offset = "0x7EA9390", VA = "0x187EAA590", Slot = "31")]
		public void OnEvent(EventData BAHKNADPFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA360", Offset = "0x7EA9160", VA = "0x187EAA360", Slot = "32")]
		public void OnEventSend(EventData BAHKNADPFCK, PCDJALHAMLP PCLCKPBICJD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly GGEIFIFLKEB DOOCABNGOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly DICOPAPILLO NCFEJGAGDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly KONBPLMLHHC LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Func<DKFEGLLCPFP, bool> CPPGKMBHCON;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public OJNBBCLMJHF KNICLIJBMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7EA46D0", Offset = "0x7EA34D0", VA = "0x187EA46D0", Slot = "4")]
		get
		{
			return default(OJNBBCLMJHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IDHAFKHJEKD PGGCNACPGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAD15D0", Offset = "0xAD03D0", VA = "0x180AD15D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DICOPAPILLO BLJDKHGNDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool BBEMKJBNGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA46B0", Offset = "0x7EA34B0", VA = "0x187EA46B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool PCKKANJMAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7EA46F0", Offset = "0x7EA34F0", VA = "0x187EA46F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool NMFFHPLAHKH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4420", Offset = "0x7EA3220", VA = "0x187EA4420", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool LBMJKGNMEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4930", Offset = "0x7EA3730", VA = "0x187EA4930", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Exception LPGCEEABMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xAC8B10", Offset = "0xAC7910", VA = "0x180AC8B10", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7EA43D0", Offset = "0x7EA31D0", VA = "0x187EA43D0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int KJBDAOPEFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7EA47C0", Offset = "0x7EA35C0", VA = "0x187EA47C0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool LGHCHDCGEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7EA43A0", Offset = "0x7EA31A0", VA = "0x187EA43A0", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4370", Offset = "0x7EA3170", VA = "0x187EA4370", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<string, long> OFAIBAIPBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4440", Offset = "0x7EA3240", VA = "0x187EA4440", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7EA44F0", Offset = "0x7EA32F0", VA = "0x187EA44F0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<OJNBBCLMJHF, OJNBBCLMJHF> GOALCMFDEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4880", Offset = "0x7EA3680", VA = "0x187EA4880", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4710", Offset = "0x7EA3510", VA = "0x187EA4710", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4950", Offset = "0x7EA3750", VA = "0x187EA4950")]
	public DKFEGLLCPFP(GGEIFIFLKEB DOOCABNGOHD, [Optional] Func<DKFEGLLCPFP, bool> CPPGKMBHCON, [Optional] MNBAHJGPANP NMIEMEIMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7EA47E0", Offset = "0x7EA35E0", VA = "0x187EA47E0")]
	private void MPLAFFNPGGD(GGEIFIFLKEB.AGFPJHOCEKF GMDHJIHAEGA, long JLGDACAIGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7EA45A0", Offset = "0x7EA33A0", VA = "0x187EA45A0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4400", Offset = "0x7EA3200", VA = "0x187EA4400")]
	private void CAELLJABANG(EBCKKIHHIJK CAGFCBLHBLD, EBCKKIHHIJK PNLIABINBOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class PFIBGPOFBCO : OOALADCCJDG, BOJJICCGBID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class CBHBOFCDHEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public PELAEIAHGNO targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CBHBOFCDHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F420", Offset = "0x7E9E220", VA = "0x187E9F420")]
		internal bool OCMPFHNEBBA(HPNEFIEBBJB c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class EBGLNFMKGMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EBGLNFMKGMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4C00", Offset = "0x7EA3A00", VA = "0x187EA4C00")]
		internal Task MFHDHGJHCPB(HPNEFIEBBJB c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct LNIGAPCIBCH : IAsyncStateMachine
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
		public PFIBGPOFBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7EAB5B0", Offset = "0x7EAA3B0", VA = "0x187EAB5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7EABA60", Offset = "0x7EAA860", VA = "0x187EABA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct CDEPBJEJEHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder<PELAEIAHGNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public PFIBGPOFBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public PELAEIAHGNO targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private Task<PELAEIAHGNO> <punConnectionTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private TaskAwaiter<PELAEIAHGNO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F4F0", Offset = "0x7E9E2F0", VA = "0x187E9F4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7E9FE70", Offset = "0x7E9EC70", VA = "0x187E9FE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class GFFKDAGANDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GFFKDAGANDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5BC0", Offset = "0x7EA49C0", VA = "0x187EA5BC0")]
		internal Task KAMCDDBGCEB(HPNEFIEBBJB c)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct HBJFLBOIFCG : IAsyncStateMachine
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
		public PFIBGPOFBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6530", Offset = "0x7EA5330", VA = "0x187EA6530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7EA69E0", Offset = "0x7EA57E0", VA = "0x187EA69E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct KHHDPCIJLHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public AsyncTaskMethodBuilder<PELAEIAHGNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public PFIBGPOFBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public PELAEIAHGNO targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter<PELAEIAHGNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9A70", Offset = "0x7EA8870", VA = "0x187EA9A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9D70", Offset = "0x7EA8B70", VA = "0x187EA9D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct JKBJJKOPAEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public PFIBGPOFBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7EA7330", Offset = "0x7EA6130", VA = "0x187EA7330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7EA7660", Offset = "0x7EA6460", VA = "0x187EA7660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct MAIKCCLMMBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public PFIBGPOFBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7EABB90", Offset = "0x7EAA990", VA = "0x187EABB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7EABEC0", Offset = "0x7EAACC0", VA = "0x187EABEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly GLNACNOFCIC BJFPMICMBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly LDMAGIMPGJB IJNIDFPIOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly HPNEFIEBBJB[] JDBMALONGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly CFGMOGPJFIG OLDJFKCEEME;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public PELAEIAHGNO KANJLJEJBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7EB16F0", Offset = "0x7EB04F0", VA = "0x187EB16F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string DIIHJEFHLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1960", Offset = "0x7EB0760", VA = "0x187EB1960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private IEnumerable<HPNEFIEBBJB> JEMLKIKOCFE
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1920", Offset = "0x7EB0720", VA = "0x187EB1920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private PJNABLCEBHB IPHKAJFMCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Task LAHMACNGMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1BC0", Offset = "0x7EB09C0", VA = "0x187EB1BC0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1C10", Offset = "0x7EB0A10", VA = "0x187EB1C10", Slot = "7")]
	public bool LLLLKGOAHBI(PELAEIAHGNO OLECCPPNDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1E50", Offset = "0x7EB0C50", VA = "0x187EB1E50")]
	[UnityEngine.Scripting.Preserve]
	public PFIBGPOFBCO([LCNEJNNIOGA(null)] GLNACNOFCIC EEMILBEGAID, [LCNEJNNIOGA(null)] LDMAGIMPGJB GPLEDJMELND, [LCNEJNNIOGA(null)] CFGMOGPJFIG POCNPGLNGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB19B0", Offset = "0x7EB07B0", VA = "0x187EB19B0", Slot = "8")]
	[AsyncStateMachine(typeof(LNIGAPCIBCH))]
	public Task KAIHEAGEBBJ([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1590", Offset = "0x7EB0390", VA = "0x187EB1590", Slot = "9")]
	[AsyncStateMachine(typeof(CDEPBJEJEHC))]
	public Task<PELAEIAHGNO> EJGJIOGEDHP(PELAEIAHGNO OLECCPPNDFE, object JCGPNELIJIN, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1740", Offset = "0x7EB0540", VA = "0x187EB1740", Slot = "10")]
	[AsyncStateMachine(typeof(HBJFLBOIFCG))]
	public Task GCDGKGFFLLF([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1CF0", Offset = "0x7EB0AF0", VA = "0x187EB1CF0")]
	[AsyncStateMachine(typeof(KHHDPCIJLHE))]
	private Task<PELAEIAHGNO> PNNEDINGOBA(PELAEIAHGNO OLECCPPNDFE, object JCGPNELIJIN, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1250", Offset = "0x7EB0050", VA = "0x187EB1250")]
	[AsyncStateMachine(typeof(JKBJJKOPAEI))]
	private Task BOGIPGLMEIF([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1830", Offset = "0x7EB0630", VA = "0x187EB1830")]
	[AsyncStateMachine(typeof(MAIKCCLMMBC))]
	private Task HEALHKKGINE([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1340", Offset = "0x7EB0140", VA = "0x187EB1340", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1AA0", Offset = "0x7EB08A0", VA = "0x187EB1AA0", Slot = "11")]
	public void KJEAGAHPFBI(OLMMEJLCNFM LNPKKFGGBHM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct NJCBAGIHLNK : IEquatable<NJCBAGIHLNK>
{
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public static readonly NJCBAGIHLNK OOIHKAJEMOK;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "4")]
	public bool Equals(NJCBAGIHLNK HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7EACE70", Offset = "0x7EABC70", VA = "0x187EACE70", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class MHABLOENMAG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E9FEE0", Offset = "0x7E9ECE0", VA = "0x187E9FEE0")]
	public MHABLOENMAG(string NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC690", Offset = "0x7EAB490", VA = "0x187EAC690")]
	public MHABLOENMAG(string NJJDPBHNDPA, Exception IGKCCLCOBDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class NICADBGBBAC : MHABLOENMAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public readonly string LAGBJAPNKHO;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7EACD40", Offset = "0x7EABB40", VA = "0x187EACD40")]
	public NICADBGBBAC(string NLKIBCBLONK, [NotNull] Exception IGKCCLCOBDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MNFOKEAGCEO : MHABLOENMAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public readonly PELAEIAHGNO LIIHOPJAEFF;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC700", Offset = "0x7EAB500", VA = "0x187EAC700")]
	public MNFOKEAGCEO(PELAEIAHGNO GDDLGCMALCP, [NotNull] Exception IGKCCLCOBDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class EIPMIKCNENP : MHABLOENMAG
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7E9FEE0", Offset = "0x7E9ECE0", VA = "0x187E9FEE0")]
	public EIPMIKCNENP(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class MEFDMAJNKAA : MHABLOENMAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public readonly int? KJBDAOPEFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly OJIEIHJFFCG DGHANKFLOPK;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC190", Offset = "0x7EAAF90", VA = "0x187EAC190")]
	public MEFDMAJNKAA(OJIEIHJFFCG EMEHDOCGFNO, Exception IGKCCLCOBDG, int? MPFOBFDLBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7EABF20", Offset = "0x7EAAD20", VA = "0x187EABF20")]
	public static MEFDMAJNKAA AMMKMGAGMHF(OJIEIHJFFCG PHALJILMPBG, KOKPHDNOEMH PFDJGMCDDEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class CDKKIDJLPIO : MHABLOENMAG
{
	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E9FEE0", Offset = "0x7E9ECE0", VA = "0x187E9FEE0")]
	public CDKKIDJLPIO(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class OAAPBONMFPL : MHABLOENMAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public readonly short JFHCABOAJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly string CCDMABFCMCI;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7EB06B0", Offset = "0x7EAF4B0", VA = "0x187EB06B0")]
	public OAAPBONMFPL(short DMDAMPNBMKA, string PIGDKIAMIBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class NPONEPEDAKH : MHABLOENMAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly short JFHCABOAJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly string CCDMABFCMCI;

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0540", Offset = "0x7EAF340", VA = "0x187EB0540")]
	public NPONEPEDAKH(short DMDAMPNBMKA, string PIGDKIAMIBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class FINJHIGCLFL : MHABLOENMAG
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7E9FEE0", Offset = "0x7E9ECE0", VA = "0x187E9FEE0")]
	public FINJHIGCLFL(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class BNNPFMLGBBE : MHABLOENMAG
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E9F310", Offset = "0x7E9E110", VA = "0x187E9F310")]
	public BNNPFMLGBBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class NBMIKJGNPIL : MNIKLIGIOHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public readonly Dictionary<string, string> OCKLPCBCJPG;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7EACCF0", Offset = "0x7EABAF0", VA = "0x187EACCF0")]
	public NBMIKJGNPIL(TimeSpan LCJLIMHGKHF, string NJJDPBHNDPA, Dictionary<string, string> IEAIEKCDOCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class GLNACNOFCIC : KAGINFADFPA<PNEPNDOKHCF>, PJNABLCEBHB, HPNEFIEBBJB, BOJJICCGBID, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct NNIIHGHCOFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public GLNACNOFCIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7EB00B0", Offset = "0x7EAEEB0", VA = "0x187EB00B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class KGBEGMHOBJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public GLNACNOFCIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public OKLCPEFFPPG actionContext;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public KGBEGMHOBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9920", Offset = "0x7EA8720", VA = "0x187EA9920")]
		internal void HCAMDDGDNID(HBCKFDINPOH<string> timer, IEBEPMGFCGH log)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct JNDIAOAEOBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public GLNACNOFCIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private KGBEGMHOBJD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private HBCKFDINPOH<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Stopwatch <sw>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private Dictionary<string, int> <regionPings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter<MFOGLPMCFJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7EA76C0", Offset = "0x7EA64C0", VA = "0x187EA76C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EA97E0", Offset = "0x7EA85E0", VA = "0x187EA97E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private CancellationTokenSource GBDKPFMPBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private CancellationTokenSource OIHLONFOPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private CancellationToken DBMFLIACJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private bool NOOLAOEHECB;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private bool DBBAAFKAPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xC9B100", Offset = "0xC99F00", VA = "0x180C9B100")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5E50", Offset = "0x7EA4C50", VA = "0x187EA5E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6100", Offset = "0x7EA4F00", VA = "0x187EA6100", Slot = "13")]
	public override bool LLLLKGOAHBI(PELAEIAHGNO OLECCPPNDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6440", Offset = "0x7EA5240", VA = "0x187EA6440")]
	[UnityEngine.Scripting.Preserve]
	public GLNACNOFCIC([LCNEJNNIOGA(null)] PNEPNDOKHCF KLBDPNGJELI, [LCNEJNNIOGA(null)] OBNFMOELGIC PIKGEBLPBOL, [LCNEJNNIOGA(null)] LMIEGECNFBF DABDCOCNOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6350", Offset = "0x7EA5150", VA = "0x187EA6350")]
	internal GLNACNOFCIC(PNEPNDOKHCF KLBDPNGJELI, OBNFMOELGIC PIKGEBLPBOL, LMIEGECNFBF DABDCOCNOJG, CKDINOBKPJN PFOJGIOMKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6160", Offset = "0x7EA4F60", VA = "0x187EA6160", Slot = "17")]
	protected override void MCNGEKPACKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5CD0", Offset = "0x7EA4AD0", VA = "0x187EA5CD0")]
	private void DMDJEINFPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5FA0", Offset = "0x7EA4DA0", VA = "0x187EA5FA0", Slot = "16")]
	protected override void JJCEPGMDKBH(PELAEIAHGNO CBGLMCICHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5D80", Offset = "0x7EA4B80", VA = "0x187EA5D80", Slot = "14")]
	protected override void DMEJAEFLJDC(OKLCPEFFPPG CHGHHGBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5F20", Offset = "0x7EA4D20", VA = "0x187EA5F20", Slot = "15")]
	protected override void GHLMIIANABE(OKLCPEFFPPG CHGHHGBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5C20", Offset = "0x7EA4A20", VA = "0x187EA5C20")]
	[AsyncStateMachine(typeof(NNIIHGHCOFD))]
	private void DFFBNFJMNAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7EA61B0", Offset = "0x7EA4FB0", VA = "0x187EA61B0", Slot = "18")]
	[AsyncStateMachine(typeof(JNDIAOAEOBJ))]
	public Task<IReadOnlyDictionary<string, int>> NBHODFNFMMC([Optional] TimeSpan? LGLKBIHNOCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class PELAEIAHGNO : MFOGLPMCFJJ, IEquatable<PELAEIAHGNO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public readonly string JIMHKHKCPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public readonly string? GGALIFINJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public readonly string? JCFBGMDABLP;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1060", Offset = "0x7EAFE60", VA = "0x187EB1060")]
	public PELAEIAHGNO(string MNJJLIELGBH, string LIPJPHJDGEJ, string OLEEMFEJDGO, string? PIEOPDICHOM, string NDLPMEKHJDE, string AJNKBHACFAF, string? PHBJHOMDIND, string? KDHAAGMCHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1000", Offset = "0x7EAFE00", VA = "0x187EB1000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0E40", Offset = "0x7EAFC40", VA = "0x187EB0E40", Slot = "5")]
	public bool Equals(PELAEIAHGNO? HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0D70", Offset = "0x7EAFB70", VA = "0x187EB0D70", Slot = "0")]
	public override bool Equals(object? GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0EC0", Offset = "0x7EAFCC0", VA = "0x187EB0EC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x12E1920", Offset = "0x12E0720", VA = "0x1812E1920")]
	public static bool PBEBFPKJKLO(PELAEIAHGNO? EFOOGHNHGNH, PELAEIAHGNO? IFJAPBHAPEE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x12E1710", Offset = "0x12E0510", VA = "0x1812E1710")]
	public static bool INFPGDPCEAI(PELAEIAHGNO? EFOOGHNHGNH, PELAEIAHGNO? IFJAPBHAPEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class MFOGLPMCFJJ : IEquatable<MFOGLPMCFJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public readonly string GIMEJGIJCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public readonly string? JKEPDGOHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public readonly string? PPFKPOELJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly string? MJCCDIBDLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly string GBAOAGJNMFE;

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC540", Offset = "0x7EAB340", VA = "0x187EAC540")]
	public MFOGLPMCFJJ(string MNJJLIELGBH, string? LIPJPHJDGEJ, string? OLEEMFEJDGO, string? PIEOPDICHOM, string NDLPMEKHJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC4E0", Offset = "0x7EAB2E0", VA = "0x187EAC4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC360", Offset = "0x7EAB160", VA = "0x187EAC360", Slot = "4")]
	public bool Equals(MFOGLPMCFJJ? HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC2D0", Offset = "0x7EAB0D0", VA = "0x187EAC2D0", Slot = "0")]
	public override bool Equals(object? GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC3F0", Offset = "0x7EAB1F0", VA = "0x187EAC3F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class LDMAGIMPGJB : KAGINFADFPA<LDMAGIMPGJB.FCNCAHJDKLI>
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public interface BKHDKHFDFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CPPFNBDBMIJ();
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class FCNCAHJDKLI : MJGCKMDKNME, KJFHLELIGPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private KOKPHDNOEMH NNENMMBNDMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private bool ILJKFCIAHCA;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private PhotonVoiceNetwork DADGFEOLMNI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4E40", Offset = "0x7EA3C40", VA = "0x187EA4E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool DFOJADFIGKG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xA57B90", Offset = "0xA56990", VA = "0x180A57B90", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public KOKPHDNOEMH PPDGFGNOMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool PCKKANJMAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x7EA56B0", Offset = "0x7EA44B0", VA = "0x187EA56B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool NMFFHPLAHKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x7EA5020", Offset = "0x7EA3E20", VA = "0x187EA5020", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool NDANJPPHLGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x7EA5B30", Offset = "0x7EA4930", VA = "0x187EA5B30", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECB0", Offset = "0xA0DAB0", VA = "0x180A0ECB0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool GNIIFIBAMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool BBEMKJBNGAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x7EA53E0", Offset = "0x7EA41E0", VA = "0x187EA53E0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public object DJPFJNAJABF
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x7EA5430", Offset = "0x7EA4230", VA = "0x187EA5430", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool CKFGBNAFBPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x7EA51C0", Offset = "0x7EA3FC0", VA = "0x187EA51C0", Slot = "16")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4DE0", Offset = "0x7EA3BE0", VA = "0x187EA4DE0", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<KOKPHDNOEMH, KOKPHDNOEMH> ELJGIFAKIKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x7EA58B0", Offset = "0x7EA46B0", VA = "0x187EA58B0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x7EA5700", Offset = "0x7EA4500", VA = "0x187EA5700", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<bool> OCKIAFFECPK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "22")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "23")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7EA52D0", Offset = "0x7EA40D0", VA = "0x187EA52D0", Slot = "10")]
		public void EDAEHIGPNFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5580", Offset = "0x7EA4380", VA = "0x187EA5580", Slot = "18")]
		public bool IPHALIMOHDI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5960", Offset = "0x7EA4760", VA = "0x187EA5960", Slot = "19")]
		public bool NKCHFHFPGIC(string AJNKBHACFAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7EA57B0", Offset = "0x7EA45B0", VA = "0x187EA57B0", Slot = "20")]
		public void KAIHEAGEBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4EA0", Offset = "0x7EA3CA0", VA = "0x187EA4EA0", Slot = "21")]
		public bool CCPCLKLBCCG(object DGLBNKIMOMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "24")]
		public void EIMFOLHOLBC(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "25")]
		public void ANIPDKFLAMB(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "26")]
		public void COIJBGBKDGO(object JLFLGDNCANL, bool LLOCMBEOOFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5070", Offset = "0x7EA3E70", VA = "0x187EA5070", Slot = "27")]
		public IDisposable CJILODFAJEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "28")]
		private bool OPJDDBDODDF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "29")]
		public void BPKMKIIKOAP(StringBuilder NIHOBNHAGFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA50C0", Offset = "0x7EA3EC0", VA = "0x187EA50C0", Slot = "30")]
		public bool CPLOMDBJKKJ(bool PEDJGDAFCFA, [Out] string NGENEEODOJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FCNCAHJDKLI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct CEBOBMLHGNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public LDMAGIMPGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public GLNACNOFCIC clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter<PELAEIAHGNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7E9FF40", Offset = "0x7E9ED40", VA = "0x187E9FF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7EA0250", Offset = "0x7E9F050", VA = "0x187EA0250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct ICMFLNLFPJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public LDMAGIMPGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6F60", Offset = "0x7EA5D60", VA = "0x187EA6F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7EA72D0", Offset = "0x7EA60D0", VA = "0x187EA72D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly GLNACNOFCIC EEMILBEGAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly BKHDKHFDFMI JCKNGOKEEDL;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB1E0", Offset = "0x7EA9FE0", VA = "0x187EAB1E0", Slot = "13")]
	public override bool LLLLKGOAHBI(PELAEIAHGNO OLECCPPNDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB270", Offset = "0x7EAA070", VA = "0x187EAB270")]
	[RecRoom.NoEngine.Common.Preserve]
	public LDMAGIMPGJB([LCNEJNNIOGA(null)] GLNACNOFCIC EEMILBEGAID, [LCNEJNNIOGA(null)] OBNFMOELGIC PIKGEBLPBOL, [LCNEJNNIOGA(null)] BKHDKHFDFMI JCKNGOKEEDL, [LCNEJNNIOGA(null)] LMIEGECNFBF DABDCOCNOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7EAAE60", Offset = "0x7EA9C60", VA = "0x187EAAE60")]
	private Task CALDNHBBKNP(OJIEIHJFFCG EMEHDOCGFNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB0F0", Offset = "0x7EA9EF0", VA = "0x187EAB0F0")]
	[AsyncStateMachine(typeof(CEBOBMLHGNP))]
	public Task LHHENHIKJND(GLNACNOFCIC NCJJOCAKOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7EAADE0", Offset = "0x7EA9BE0", VA = "0x187EAADE0")]
	[CompilerGenerated]
	internal static void AMIHOKDFICK(KOKPHDNOEMH NKIHBIMPCMA, KOKPHDNOEMH AEIALKPFDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB020", Offset = "0x7EA9E20", VA = "0x187EAB020")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(ICMFLNLFPJP))]
	private Task KEKIDNDDMII()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[RecRoom.NoEngine.Common.Preserve]
public class GDHGEMKPFKA
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	[RecRoom.NoEngine.Common.Preserve]
	[JsonProperty(PropertyName = "AI", Required = Required.Always)]
	public string AccountId
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
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
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
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
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
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
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
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
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public GDHGEMKPFKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[RecRoom.NoEngine.Common.Preserve]
public class JBEJMINCDKP
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	[JsonProperty(PropertyName = "DR", Required = Required.Always)]
	[RecRoom.NoEngine.Common.Preserve]
	public string Reason
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
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
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public JBEJMINCDKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class CFGMOGPJFIG : HPNEFIEBBJB, BOJJICCGBID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum KOCMCAAEJNN
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
	private NetworkManager ANKFKNIJBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private TaskCompletionSource<PELAEIAHGNO> EBHHHJGABKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	protected readonly OBNFMOELGIC NCNAEBIBJCO;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly IEBEPMGFCGH NDLHJECGFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly HashSet<OLMMEJLCNFM> HFGEFKPCMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public KOCMCAAEJNN FKEOONMBHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private PELAEIAHGNO OLECCPPNDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private RSACryptoServiceProvider DGGAMIPONND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private RSACryptoServiceProvider GBFCLHNJPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private AesCryptoServiceProvider ELJGJHFHNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private byte[] DNNOJOBMKAF;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public PELAEIAHGNO KANJLJEJBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string DIIHJEFHLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1370", Offset = "0x7EA0170", VA = "0x187EA1370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Task LAHMACNGMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1810", Offset = "0x7EA0610", VA = "0x187EA1810", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1730", Offset = "0x7EA0530", VA = "0x187EA1730", Slot = "10")]
	public void KJEAGAHPFBI(OLMMEJLCNFM LNPKKFGGBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1860", Offset = "0x7EA0660", VA = "0x187EA1860", Slot = "6")]
	public bool LLLLKGOAHBI(PELAEIAHGNO OLECCPPNDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2090", Offset = "0x7EA0E90", VA = "0x187EA2090")]
	[RecRoom.NoEngine.Common.Preserve]
	public CFGMOGPJFIG([LCNEJNNIOGA(null)] OBNFMOELGIC DHACIOMGMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA18A0", Offset = "0x7EA06A0", VA = "0x187EA18A0")]
	private void MCDHNPMPBCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7EA15C0", Offset = "0x7EA03C0", VA = "0x187EA15C0")]
	private void JOHPHCGPBAC(ulong GLEBGNJJOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA0F50", Offset = "0x7E9FD50", VA = "0x187EA0F50")]
	private void FICKBPAKGIO(bool AHMHBJPAMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7EA13A0", Offset = "0x7EA01A0", VA = "0x187EA13A0")]
	private void JIGOPHLDBGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1B00", Offset = "0x7EA0900", VA = "0x187EA1B00")]
	private void NNBIDBNPLMG(ulong GLEBGNJJOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1790", Offset = "0x7EA0590", VA = "0x187EA1790")]
	private void KJOKGALHPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7EA0910", Offset = "0x7E9F710", VA = "0x187EA0910")]
	private void EADDCJEGNOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7EA10C0", Offset = "0x7E9FEC0", VA = "0x187EA10C0")]
	private void GEKGJEGPEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7EA0DE0", Offset = "0x7E9FBE0", VA = "0x187EA0DE0")]
	private void ENECKLCJGMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1240", Offset = "0x7EA0040", VA = "0x187EA1240")]
	private static (IPAddress, ushort) GJCLICPACDB(string NAHELFCHLBO)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7EA02B0", Offset = "0x7E9F0B0", VA = "0x187EA02B0")]
	private void CBFDAPFAJAC(PELAEIAHGNO EGFDOMDIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7EA0980", Offset = "0x7E9F780", VA = "0x187EA0980", Slot = "8")]
	public Task<PELAEIAHGNO> EJGJIOGEDHP(PELAEIAHGNO OLECCPPNDFE, object JCGPNELIJIN, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1640", Offset = "0x7EA0440", VA = "0x187EA1640", Slot = "7")]
	public Task KAIHEAGEBBJ([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA0FD0", Offset = "0x7E9FDD0", VA = "0x187EA0FD0", Slot = "9")]
	public Task GCDGKGFFLLF([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA08B0", Offset = "0x7E9F6B0", VA = "0x187EA08B0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class KAHAHCEPKIH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA9850", Offset = "0x7EA8650", VA = "0x187EA9850")]
	public KAHAHCEPKIH(string NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7EA98B0", Offset = "0x7EA86B0", VA = "0x187EA98B0")]
	public KAHAHCEPKIH(string NJJDPBHNDPA, Exception IGKCCLCOBDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class AEIMNOODDLP : KAHAHCEPKIH
{
	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7E9F230", Offset = "0x7E9E030", VA = "0x187E9F230")]
	public AEIMNOODDLP([NotNull] Exception IGKCCLCOBDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class DFIIGLGBOLF : KAHAHCEPKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7EA42F0", Offset = "0x7EA30F0", VA = "0x187EA42F0")]
	public DFIIGLGBOLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class KGNDHBMHGCH : KAHAHCEPKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7EA99F0", Offset = "0x7EA87F0", VA = "0x187EA99F0")]
	public KGNDHBMHGCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class CPGCJPAAPEF
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static AesCryptoServiceProvider EPBEBLOCGPN;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private static readonly string GOLGAGJJPLJ;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static readonly string BNBJOFLCBMM;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static readonly string ELOMFGANBIE;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4150", Offset = "0x7EA2F50", VA = "0x187EA4150")]
	public static string KJCKAJMMPEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4000", Offset = "0x7EA2E00", VA = "0x187EA4000")]
	public static string BIKOBDHILHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7EA4050", Offset = "0x7EA2E50", VA = "0x187EA4050")]
	public static AesCryptoServiceProvider CGPAGJHILFD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class CJHLECNLDLD : IPGNPJNAFHC
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public enum LHIMCDKPLPI
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
	private LLEAAEBCCKF IHEOFGNKODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private NetworkManager ANKFKNIJBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	protected readonly OBNFMOELGIC NCNAEBIBJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private TaskCompletionSource<bool> ACEFBFLCAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public LHIMCDKPLPI FKEOONMBHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private RSACryptoServiceProvider DGGAMIPONND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private RSACryptoServiceProvider GBFCLHNJPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private AesCryptoServiceProvider ELJGJHFHNCM;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public LLEAAEBCCKF AOBNECFHGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string EPLHHFIJJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string ACHMGMLMNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3850", Offset = "0x7EA2650", VA = "0x187EA3850", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3E50", Offset = "0x7EA2C50", VA = "0x187EA3E50")]
	[UnityEngine.Scripting.Preserve]
	public CJHLECNLDLD([LCNEJNNIOGA(null)] OBNFMOELGIC DHACIOMGMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3B00", Offset = "0x7EA2900", VA = "0x187EA3B00")]
	private void MCDHNPMPBCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3510", Offset = "0x7EA2310", VA = "0x187EA3510")]
	private void JOHPHCGPBAC(ulong GLEBGNJJOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2F20", Offset = "0x7EA1D20", VA = "0x187EA2F20")]
	private void GICHNFIICKD(ulong GLEBGNJJOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3D00", Offset = "0x7EA2B00", VA = "0x187EA3D00")]
	private void NNBIDBNPLMG(ulong GLEBGNJJOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3A10", Offset = "0x7EA2810", VA = "0x187EA3A10")]
	private void KJOKGALHPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2A20", Offset = "0x7EA1820", VA = "0x187EA2A20")]
	private void EADDCJEGNOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2A90", Offset = "0x7EA1890", VA = "0x187EA2A90")]
	private void ENECKLCJGMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7EA33E0", Offset = "0x7EA21E0", VA = "0x187EA33E0")]
	private static (IPAddress, ushort) GJCLICPACDB(string NAHELFCHLBO)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2250", Offset = "0x7EA1050", VA = "0x187EA2250")]
	private void CBFDAPFAJAC(string NDLPMEKHJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2B30", Offset = "0x7EA1930", VA = "0x187EA2B30", Slot = "7")]
	public Task<bool> FIMFMEKHIAN(string PHBJHOMDIND, string MMKJBFMHPHO, string NDLPMEKHJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3970", Offset = "0x7EA2770", VA = "0x187EA3970", Slot = "8")]
	public Task KAIHEAGEBBJ([Optional] CancellationToken GHKBKDKNIOM)
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
